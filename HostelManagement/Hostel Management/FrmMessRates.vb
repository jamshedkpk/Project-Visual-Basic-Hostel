Public Class FrmMessRates
    Dim obj As New DBClass
    Dim Rate As Integer
    Dim MessNo As Integer
    Dim qry As String
    Dim ds As New System.Data.DataSet
    Private Sub FrmMessRates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
        Rate = 0
    End Sub
    Public Sub clear()
        dg.DataSource = obj.showdata("select MessNo,HostelName,Rate from vwsearchMessRates").Tables(0)
        TxtMessNo.Text = obj.getKey("MessNo")
        fillhostels()
        TxtRate.Clear()
        TxtRate.Focus()
    End Sub
    Public Sub fillhostels()
        TxtHostelNo.DataSource = obj.showdata("select * from TblHostel").Tables(0)
        TxtHostelNo.DisplayMember = "HostelName"
        TxtHostelNo.ValueMember = "HostelNo"
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Try
            If TxtRate.Text = "" Then
                MsgBox("Please Fill Rate", MsgBoxStyle.Information)
            ElseIf checkduplicaterecord() = False Then
                MsgBox("Duplicate Record Is Not Allowed", MsgBoxStyle.Information)
                Else
                    obj.insert("insert into TblMessRates (MessNo,HostelNo,Rate) values ('" & TxtMessNo.Text.Trim & "' ,'" & TxtHostelNo.SelectedValue & "' , '" & TxtRate.Text.Trim & "' )")
                    obj.updateKey("MessNo", TxtMessNo.Text.Trim)
                clear()
                Me.Dispose()
                End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Added", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            If Rate = 0 Then
                MessNo = InputBox("Please Enter A Value")
                dg.DataSource = obj.showdata("select * from TblMessRates where Messno='" & MessNo & "' ").Tables(0)
                TxtRate.Text = obj.showdata("select * from TblMessRates where Messno='" & MessNo & "' ").Tables(0).Rows(0).Item("rate")
                Rate = 1
            ElseIf Rate = 1 Then
                obj.update("update TblMessRates set rate=' " & TxtRate.Text.Trim & "' where messno='" & MessNo & "' ")
                Rate = 0
                clear()
            End If

        Catch ex As Exception
            MsgBox("Record Is Not Updated", MsgBoxStyle.Information)
            clear()
        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub TxtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRate.KeyPress
        If (Asc(e.KeyChar) >= 48) And (Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function checkduplicaterecord() As Boolean
        qry = "Select * from tblMessrates where hostelno='" & TxtHostelNo.SelectedValue & "' "
        ds = obj.showdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub TxtHostelNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHostelNo.SelectedIndexChanged

    End Sub
End Class