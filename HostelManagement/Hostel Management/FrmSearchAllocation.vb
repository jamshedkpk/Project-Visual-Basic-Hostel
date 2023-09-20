Public Class FrmSearchAllocation
    Dim obj As New DBClass
    Private Sub FrmSearchAllocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        fillhostelno()
        dg.DataSource = obj.showdata("select Ano as AllocationNo, RoomNo as Room,SRegNo as RegistrationNo,SName as Name , deptname as Department, progname as Program, DateFrom,DateTo  from vwsearchallocation").Tables(0)
        Dg2.DataSource = obj.showdata("select * from TblHostel  ").Tables(0)
    End Sub
    Public Sub fillhostelno()
        TxtHostelNo.DataSource = obj.showdata("select * from tblhostel").Tables(0)
        TxtHostelNo.DisplayMember = "hostelname"
        TxtRoomNo.ValueMember = "hostelno"
    End Sub
    Public Sub fillroomno()
        TxtRoomNo.DataSource = obj.showdata("select * from VWSearchRoomStatus where hostelname='" & TxtHostelNo.Text & "'").Tables(0)
        TxtRoomNo.DisplayMember = "roomno"
        TxtRoomNo.ValueMember = "roomno"
    End Sub
    Private Sub TxtHostelNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHostelNo.SelectedIndexChanged
        fillroomno()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            dg.DataSource = obj.showdata("select Ano as AllocationNo, RoomNo as Room,SRegNo as RegistrationNo,SName as Name , deptname as Department, progname as Program, DateFrom,DateTo  from vwsearchallocation where sregno = '" & TxtSRegNo.Text & "' ").Tables(0)
            Dg2.DataSource = obj.showdata("select HostelNo, HostelName, HostelLocation from vwsearchallocation where sregno='" & TxtSRegNo.Text.Trim & "' ").Tables(0)
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dg.DataSource = obj.showdata("select Ano as AllocationNo, RoomNo as Room,SRegNo as RegistrationNo,SName as Name , deptname as Department, progname as Program, DateFrom,DateTo  from vwsearchallocation where HostelName='" & TxtHostelNo.Text & "' ").Tables(0)
        Dg2.DataSource = obj.showdata("select * from TblHostel where HostelName='" & TxtHostelNo.Text & "' ").Tables(0)
        TxtSRegNo.Clear()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dg.DataSource = obj.showdata("select Ano as AllocationNo, RoomNo as Room,SRegNo as RegistrationNo,SName as Name , deptname as Department, progname as Program, DateFrom,DateTo  from vwsearchallocation where RoomNo='" & TxtRoomNo.Text & "' and hostelname='" & TxtHostelNo.Text & "' ").Tables(0)
        Dg2.DataSource = obj.showdata("select * from TblHostel where HostelName='" & TxtHostelNo.Text & "' ").Tables(0)
        TxtSRegNo.Clear()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dg.DataSource = obj.showdata("select Ano as AllocationNo, RoomNo as Room,SRegNo as RegistrationNo,SName as Name , deptname as Department, progname as Program, DateFrom,DateTo  from vwsearchallocation").Tables(0)
        Dg2.DataSource = obj.showdata("select * from TblHostel where HostelName='" & TxtHostelNo.Text & "' ").Tables(0)
    End Sub
    Private Sub TxtSRegNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSRegNo.TextChanged
        Dim ds As New DataSet
        ds = obj.showdata("select Ano as AllocationNo, RoomNo as Room,SRegNo as RegistrationNo,SName as Name , deptname as Department, progname as Program, DateFrom,DateTo  from vwsearchallocation where sregno like '" & TxtSRegNo.Text & "%'")
        If ds.Tables(0).Rows.Count <> 0 Then
            dg.DataSource = ds.Tables(0)
            Dg2.DataSource = obj.showdata("select HostelNo,HostelName,HostelLocation from vwsearchallocation where sregno like '" & TxtSRegNo.Text & "%' ").Tables(0)
        Else
            TxtSRegNo.Clear()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            If TxtSRegNo.Text = "" And TxtSRegNo.Text = "" Then
                MsgBox("Please Enter A Student Registration No", MsgBoxStyle.Information)
            Else
                Dim rpt As New RptAllocation
                Dim frm As New Frmreport
                rpt.SetDataSource(obj.showdata("Select * from vwsearchallocation where sregno='" & TxtSRegNo.Text.Trim & "'  ").Tables(0))
                frm.V.ReportSource = rpt
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try
   
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            
                Dim rpt As New RptAllocation
                Dim frm As New Frmreport
            rpt.SetDataSource(obj.showdata("Select * from vwsearchallocation where hostelname='" & TxtHostelNo.Text.Trim & "'  ").Tables(0))
                frm.V.ReportSource = rpt
                frm.ShowDialog()
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try

            Dim rpt As New RptAllocation
            Dim frm As New Frmreport
            rpt.SetDataSource(obj.showdata("Select * from vwsearchallocation where hostelname='" & TxtHostelNo.Text.Trim & "'  and roomno='" & TxtRoomNo.Text.Trim & "'").Tables(0))
            frm.V.ReportSource = rpt
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Dispose()
    End Sub
End Class