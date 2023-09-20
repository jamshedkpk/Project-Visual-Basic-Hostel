Public Class Frmprogram
    Dim obj As New DBClass
    Dim ds As New System.Data.DataSet
    Dim qry As String
    Private Sub FrmHostel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        TxtProgNo.Text = obj.getKey("ProgNo")
        TxtProglName.Clear()
        TxtProglName.Focus()
        Dg.DataSource = obj.showdata("select ProgNo as ProgramNo,deptName as Department,Progname as ProgrameName from vwsearchprogram").Tables(0)
        filldeptno()
    End Sub
    Public Sub filldeptno()
        TxtDeptNo.DataSource = obj.showdata("select * from tbldepartment").Tables(0)
        TxtDeptNo.DisplayMember = "Deptname"
        TxtDeptNo.ValueMember = "Deptno"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Try
            If TxtProglName.Text = "" Then
                MsgBox("Please Enter A Program Name", MsgBoxStyle.Information)
            ElseIf checkduplicaterecord() = False Then
                MsgBox("Duplicate Record Is Not Allowed", MsgBoxStyle.Information)
            Else
                obj.insert("insert into TblProgram (ProgNo,DeptNo,ProgName) values ('" & TxtProgNo.Text.Trim & "' , '" & TxtDeptNo.SelectedValue & "' , '" & TxtProglName.Text.Trim & "'  )")
                Dg.DataSource = obj.showdata("select * from TblProgram").Tables(0)
                obj.updateKey("ProgNo", TxtProgNo.Text.Trim)
                clear()
            End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Stored", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub TxtProglName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtProglName.KeyPress
        If (Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 121) Or (Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function checkduplicaterecord() As Boolean
        qry = "Select * from tblprogram where progname='" & TxtProglName.Text.Trim & "' and deptno='" & TxtDeptNo.SelectedValue & "' "
        ds = obj.showdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub TxtProglName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProglName.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class