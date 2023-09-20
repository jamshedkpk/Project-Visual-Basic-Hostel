Public Class FrmSearchClearance
    Dim obj As New DBClass
    Private Sub FrmSearchRoomClearance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        dg.DataSource = obj.showdata("Select cno as ClearanceNo,SRegno as RegistrationNo,SName as Name,HostelName,RoomNo,DateFrom,DateTo,Remarks from VWSearchClearance").Tables(0)
        fillhostelno()
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
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            dg.DataSource = obj.showdata("Select cno as ClearanceNo,SRegno as RegistrationNo,SName as Name,HostelName,RoomNo,DateFrom,DateTo,Remarks from VWSearchClearance where hostelname='" & TxtHostelNo.Text & "' ").Tables(0)
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub TxtHostelNo_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHostelNo.SelectedIndexChanged
        fillroomno()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            dg.DataSource = obj.showdata("Select cno as ClearanceNo,SRegno as RegistrationNo,SName as Name,HostelName,RoomNo,DateFrom,DateTo,Remarks from VWSearchClearance where roomno='" & TxtRoomNo.Text & "' and hostelname='" & TxtHostelNo.Text & "' ").Tables(0)
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If TxtSRegNo.Text = "" Then
                MsgBox("Please Enter A Registration No", MsgBoxStyle.Information)
            Else
                dg.DataSource = obj.showdata("Select cno as ClearanceNo,SRegno as RegistrationNo,SName as Name,HostelName,RoomNo,DateFrom,DateTo,Remarks from VWSearchClearance where SRegNo='" & TxtSRegNo.Text & "' ").Tables(0)
            End If
Catch ex As Exception
            MsgBox("Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub TxtSRegNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSRegNo.TextChanged
        Dim ds As New DataSet
        ds = obj.showdata("Select cno as ClearanceNo,SRegno as RegistrationNo,SName as Name,HostelName,RoomNo,DateFrom,DateTo,Remarks from VWSearchClearance where SRegNo LIKE'" & TxtSRegNo.Text.Trim & "%'")
        If ds.Tables(0).Rows.Count <> 0 Then
            dg.DataSource = ds.Tables(0)
        Else
            TxtSRegNo.Clear()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Dispose()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TxtSRegNo.Text = "" Then
            MsgBox("Please Enter A Student Registraion No", MsgBoxStyle.Information)
        Else
            Dim rpt As New RptClearance
            Dim frm As New Frmreport
            rpt.SetDataSource(obj.showdata("Select * from VWSearchClearance where SRegNo='" & TxtSRegNo.Text & "' ").Tables(0))
            frm.V.ReportSource = rpt
            frm.ShowDialog()
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim rpt As New RptClearance
        Dim frm As New Frmreport
        rpt.SetDataSource(obj.showdata("Select * from VWSearchClearance where hostelname='" & TxtHostelNo.Text & "' ").Tables(0))
        frm.V.ReportSource = rpt
        frm.ShowDialog()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Dim rpt As New RptClearance
            Dim frm As New Frmreport
            rpt.SetDataSource(obj.showdata("Select * from VWSearchClearance where hostelname='" & TxtHostelNo.Text & "' and roomno='" & TxtRoomNo.Text & "'  ").Tables(0))
            frm.V.ReportSource = rpt
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found")
        End Try
    End Sub
End Class