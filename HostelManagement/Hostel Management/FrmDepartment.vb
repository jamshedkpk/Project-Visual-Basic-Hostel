Public Class Frmdepartment
    Dim obj As New DBClass
    Dim ds As New System.Data.DataSet
    Dim qry As String
    Dim rate As Integer
    Dim deptno As Integer
    Sub clear()
        TxtDeptNo.Text = obj.getKey("DeptNo")
        TxtDeptName.Clear()
        TxtDeptName.Focus()
        dg.DataSource = obj.showdata("select DEPTNO AS DepartmentNo,Deptname as DepartmentName from TblDepartment").Tables(0)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Try
            If TxtDeptName.Text = "" Then
                MsgBox("Please Enter A Department Name", MsgBoxStyle.Information)
            ElseIf checkduplicaterecord() = False Then
                    MsgBox("Duplicate Record Is Not Allowed", MsgBoxStyle.Information)
                Else
                    obj.insert("insert into tblDepartment(DeptNo, DeptName) values ('" & TxtDeptNo.Text.Trim & "', '" & TxtDeptName.Text.Trim & "')")
                    obj.updateKey("DeptNo", TxtDeptNo.Text.Trim)
                    clear()
                End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Stored", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
    End Sub
    Private Sub TxtDeptName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDeptName.KeyPress
        If Asc(e.KeyChar) = 8 Or (Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 90) Or Asc(e.KeyChar) = 32 Or
(Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function checkduplicaterecord() As Boolean
        qry = "Select * from tbldepartment where deptname='" & TxtDeptName.Text.Trim & "' "
        ds = obj.showdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If rate = 0 Then
                deptno = InputBox("Please Enter A Value")
                dg.DataSource = obj.showdata("select * from Tbldepartment where deptno='" & deptno & "' ").Tables(0)
                TxtDeptName.Text = obj.showdata("select * from tbldepartment where deptno='" & deptno & "' ").Tables(0).Rows(0).Item("deptName")
                rate = 1
            ElseIf rate = 1 Then
                obj.update("update Tbldepartment set deptname=' " & TxtDeptName.Text.Trim & "' where deptno='" & deptno & "' ")
                rate = 0
                clear()
            End If

        Catch ex As Exception
            MsgBox("Sorry Record Is Not Updated", MsgBoxStyle.Information)
            clear()
        End Try

    End Sub
End Class
