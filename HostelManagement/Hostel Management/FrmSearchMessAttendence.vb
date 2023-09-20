Public Class FrmSearchMessAttendence
    Dim obj As New DBClass
    Private Sub FrmSearchMessAttendence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        dg.DataSource = obj.showdata("select AttNo as AttendenceNo,Date,Quantity,TotalPrice From vwsearchmessattendence").Tables(0)
        dg2.DataSource = obj.showdata("select SRegNo as Registration, SName as Name,HostelName,Deptname as Department,Progname as Program from vwsearchmessattendence").Tables(0)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSRegNo.TextChanged
        Dim ds As New DataSet
        ds = obj.showdata("select SRegNo as Registration, SName as Name,HostelName,Deptname as Department,Progname as Program from vwsearchmessattendence  where SRegNo LIKE'" & TxtSRegNo.Text.Trim & "%'")
        If ds.Tables(0).Rows.Count <> 0 Then
            dg2.DataSource = ds.Tables(0)
            dg.DataSource = obj.showdata("select AttNo as AttendenceNo,Date,Quantity,TotalPrice From vwsearchmessattendence  where SRegNo LIKE'" & TxtSRegNo.Text.Trim & "%'").Tables(0)
        Else
            TxtSRegNo.Clear()
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim rpt As New RptMessAttendence
        Dim frm As New Frmreport
        rpt.SetDataSource(obj.showdata("Select * from VWSearchmessattendence where sregno='" & TxtSRegNo.Text & "' ").Tables(0))
        frm.V.ReportSource = rpt
        frm.ShowDialog()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If TxtSRegNo.Text = "" Then
                MsgBox("Please Enter A Registration No", MsgBoxStyle.Information)
            Else
                dg2.DataSource = obj.showdata("select SRegNo as Registration, SName as Name,HostelName,Deptname as Department,Progname as Program from vwsearchmessattendence where sregno='" & TxtSRegNo.Text & "' ").Tables(0)
            End If
Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class