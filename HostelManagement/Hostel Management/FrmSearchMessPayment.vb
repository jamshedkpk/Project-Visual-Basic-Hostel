Public Class FrmSearchMessPayment
    Dim obj As New DBClass
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
    Public Sub clear()
        dg1.DataSource = obj.showdata("select sregno as RegistrationNo,sname as Name,HostelName,deptname as Department,progname as ProgramName from vwsearchmesspayment").Tables(0)
        Dg.DataSource = obj.showdata("select PaymentId,PaymentDate,DateFrom,DateTo,AmountPaid from vwsearchmesspayment").Tables(0)
        TxtSRegNo.Clear()
    End Sub

    Private Sub FrmSearchMessPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Private Sub TxtPaymentNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ds As New DataSet
        ds = obj.showdata("select sregno as RegistrationNo,sname as Name,HostelName,deptname as Department,progname as ProgramName from vwsearchmesspayment where SREGNO='" & TxtSRegNo.Text.Trim & "' ")
        If ds.Tables(0).Rows.Count <> 0 Then
            dg1.DataSource = obj.showdata("select sregno as RegistrationNo,sname as Name,HostelName,deptname as Department,progname as ProgramName from vwsearchmesspayment  where SREGNO='" & TxtSRegNo.Text.Trim & "' ").Tables(0)
            Dg.DataSource = obj.showdata("select PaymentId,PaymentDate,DateFrom,DateTo,AmountPaid from vwsearchmesspayment  where SREGNO='" & TxtSRegNo.Text.Trim & "' ").Tables(0)
        Else
            TxtSRegNo.Clear()
        End If
    End Sub
    Private Sub TxtSRegNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSRegNo.TextChanged
        Dim ds As New DataSet
        ds = obj.showdata("select sregno as RegistrationNo,sname as Name,HostelName,deptname as Department,progname as ProgramName from vwsearchmesspayment where SRegNo LIKE'" & TxtSRegNo.Text.Trim & "%'")
        If ds.Tables(0).Rows.Count <> 0 Then
            dg1.DataSource = obj.showdata("select sregno as RegistrationNo,sname as Name,HostelName,deptname as Department,progname as ProgramName from vwsearchmesspayment where sregno LIKE'" & TxtSRegNo.Text & "%' ").Tables(0)
            Dg.DataSource = obj.showdata("select PaymentId,PaymentDate,DateFrom,DateTo,AmountPaid from vwsearchmesspayment  where sregno LIKE'" & TxtSRegNo.Text & "%' ").Tables(0)
        Else
            TxtSRegNo.Clear()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TxtSRegNo.Text = "" Then
            MsgBox("Please Enter A PaymentId Or Student Registration No", MsgBoxStyle.Information)
        Else
            Dim rpt As New Rptmesspayment
            Dim frm As New Frmreport
            rpt.SetDataSource(obj.showdata("Select * from vwsearchmesspayment where sregno='" & TxtSRegNo.Text.Trim & "' ").Tables(0))
            frm.V.ReportSource = rpt
            frm.ShowDialog()
        End If
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TxtSRegNo.Text = "" Then
                MsgBox("Please Enter Student Registration No Or Payment Id", MsgBoxStyle.Information)
            Else
                dg1.DataSource = obj.showdata("select sregno as RegistrationNo,sname as Name,HostelName,deptname as Department,progname as ProgramName from vwsearchmesspayment where sregno='" & TxtSRegNo.Text.Trim & "' ").Tables(0)
                Dg.DataSource = obj.showdata("select PaymentId,PaymentDate,DateFrom,DateTo,AmountPaid from vwsearchmesspayment where sregno='" & TxtSRegNo.Text.Trim & "' ").Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Sub
End Class