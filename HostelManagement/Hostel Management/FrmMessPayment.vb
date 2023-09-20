Public Class FrmMessPayment
    Dim obj As New DBClass
    Private Sub FrmMessAttendence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        TxtPaymentId.Text = obj.getKey("PaymentId")
        Dg.DataSource = obj.showdata("select PaymentId,HostelName,sname as StudentName,PaymentDate,DateFrom,DateTo,AmountPaid from vwsearchMessPayment").Tables(0)
        TxtPaymentDate.Focus()
        fillhostels()
        fillsregno()
        TxtAmountPaid.Clear()
        TxtAmountPaid.Focus()
    End Sub
    Public Sub fillhostels()
        TxtHostelNo.DataSource = obj.showdata("select * from TblHostel").Tables(0)
        TxtHostelNo.DisplayMember = "HostelName"
        TxtHostelNo.ValueMember = "HostelNo"
    End Sub
    Public Sub fillsregno()
        TxtSRegNo.DataSource = obj.showdata("select * from vwsearchallocation where HostelName='" & TxtHostelNo.Text & "' ").Tables(0)
        TxtSRegNo.DisplayMember = "SName"
        TxtSRegNo.ValueMember = "SRegNo"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TxtAmountPaid.Text = "" Then
                MsgBox("Please Fill Paid Amount", MsgBoxStyle.Information)
            Else
                obj.insert("insert into TblMessPayment (PaymentId,HostelNo,SRegNo,AmountPaid,PaymentDate,DateFrom,DateTo)VALUES ( '" & TxtPaymentId.Text.Trim & "' , '" & TxtHostelNo.SelectedValue & "', '" & TxtSRegNo.SelectedValue & "', '" & TxtAmountPaid.Text.Trim & "' , '" & TxtPaymentDate.Text.Trim & "' , '" & TxtDateFrom.Text.Trim & "','" & TxtDateTo.Text.Trim & "' )")
                obj.updateKey("PaymentId", TxtPaymentId.Text.Trim)
                clear()
            End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Added", MsgBoxStyle.Information)
        End Try

    End Sub
    Private Sub TxtHostelNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHostelNo.SelectedIndexChanged
        fillsregno()
    End Sub
    Private Sub TxtAmountPaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmountPaid.KeyPress
        If (Asc(e.KeyChar) >= 48) And (Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()

    End Sub
End Class