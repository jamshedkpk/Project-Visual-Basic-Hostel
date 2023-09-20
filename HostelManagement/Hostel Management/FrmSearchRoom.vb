Public Class FrmSearchRoom
    Dim obj As New DBClass
    Private Sub FrmSearchRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        fillhostel()
        dg.DataSource = obj.showdata("select SNo as SerialNo,RoomNo,RoomType,Status,Capacity  from VWSearchRoom  ").Tables(0)
        dg2.DataSource = obj.showdata("select HostelNo,HostelName,HostelLocation from TblHostel  ").Tables(0)
    End Sub
    Public Sub fillhostel()
        TxtHostelNo.DataSource = obj.showdata("select * from TblHostel").Tables(0)
        TxtHostelNo.DisplayMember = "HostelName"
        TxtHostelNo.ValueMember = "HostelNo"
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dg.DataSource = obj.showdata("select SNo as SerialNo,RoomNo,RoomType,Status,Capacity  from VWSearchRoom where HostelName='" & TxtHostelNo.Text & "' ").Tables(0)
        dg2.DataSource = obj.showdata("select HostelNo,HostelName,HostelLocation from TblHostel where HostelNo='" & TxtHostelNo.SelectedValue & "' ").Tables(0)
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dg.DataSource = obj.showdata("select SNo as SerialNo,RoomNo,RoomType,Status,Capacity from VWSearchRoomStatus where hostelname='" & TxtHostelNo.Text & "' and capacity-status=0").Tables(0)
        dg2.DataSource = obj.showdata("select HostelNo,HostelName,HostelLocation from TblHostel where HostelNo='" & TxtHostelNo.SelectedValue & "' ").Tables(0)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dg.DataSource = obj.showdata("select SNo as SerialNo,RoomNo,RoomType,Status,Capacity from VWSearchRoomStatus where hostelname='" & TxtHostelNo.Text & "' and capacity-status>0 ").Tables(0)
        dg2.DataSource = obj.showdata("select HostelNo,HostelName,HostelLocation from TblHostel where HostelNo='" & TxtHostelNo.SelectedValue & "' ").Tables(0)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub

    Private Sub dg2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg2.CellContentClick

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        dg.DataSource = obj.showdata("select SNo as SerialNo,RoomNo,RoomType,Status,Capacity from VWSearchRoom where hostelname='" & TxtHostelNo.Text & "' ").Tables(0)
        dg2.DataSource = obj.showdata("select HostelNo,HostelName,HostelLocation from TblHostel where HostelNo='" & TxtHostelNo.SelectedValue & "' ").Tables(0)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim rpt As New RptRoom
            Dim frm As New Frmreport
            rpt.SetDataSource(obj.showdata("Select * from vwsearchroom where hostelNO='" & TxtHostelNo.SelectedValue & "' and capacity-status>0 ").Tables(0))
            frm.V.ReportSource = rpt
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim rpt As New RptRoom
            Dim frm As New Frmreport
            rpt.SetDataSource(obj.showdata("Select * from vwsearchroom where hostelNO='" & TxtHostelNo.SelectedValue & "' and capacity-status=0 ").Tables(0))
            frm.V.ReportSource = rpt
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim rpt As New RptRoom
            Dim frm As New Frmreport
            rpt.SetDataSource(obj.showdata("Select * from vwsearchroom where hostelNO='" & TxtHostelNo.SelectedValue & "' ").Tables(0))
            frm.V.ReportSource = rpt
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Sub
End Class