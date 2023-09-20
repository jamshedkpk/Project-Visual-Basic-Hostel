Public Class FrmStudentInformation
    Dim obj As New DBClass
    Dim ds As New System.Data.DataSet
    Dim qry As String
    Dim rate As Integer
    Dim regno As String
    Private Sub FrmStudentInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        TxtSAddress.Text = ""
        TxtSContact.Text = ""
        TxtSFatherName.Text = ""
        TxtSName.Text = ""
        TxtSRegNo.Clear()
        TxtSRegNo.Focus()
        TxtNicNo.Clear()
        Dg.DataSource = obj.showdata("select SREGNO AS RegistrationNo,sname as Name,sfathername as FatherName,saddress as Address,scontact as Contact,snic as NICNo,DeptName as Department,ProgName as Programe,Sessionstart,SessionEnd from VWSEARCHSTUDENT").Tables(0)
        Call filldeptno()
    End Sub
    Public Sub filldeptno()
        TxtDeptNo.DataSource = obj.showdata("select * from Tbldepartment").Tables(0)
        TxtDeptNo.DisplayMember = "Deptname"
        TxtDeptNo.ValueMember = "Deptno"
    End Sub
    Public Sub fillprogno()
        TxtProgNo.DataSource = obj.showdata("select * from VWSearchProgram where deptname='" & TxtDeptNo.Text & "' ").Tables(0)
        TxtProgNo.DisplayMember = "ProgName"
        TxtProgNo.ValueMember = "ProgNo"
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Try
            If TxtSRegNo.Text = "" Then
                MsgBox("Please Enter A Student Registration No", MsgBoxStyle.Information)
                TxtSRegNo.Focus()
            ElseIf TxtSName.Text = "" Then
                MsgBox("Please Enter A Name No Of A Student", MsgBoxStyle.Information)
                TxtSName.Focus()
            ElseIf TxtSFatherName.Text = "" Then
                MsgBox("Please Enter A Father Name No Of A Student", MsgBoxStyle.Information)
                TxtSFatherName.Focus()
            ElseIf TxtSAddress.Text = "" Then
                MsgBox("Please Enter An Address Of A Student", MsgBoxStyle.Information)
                TxtSAddress.Focus()
            ElseIf TxtNicNo.Text = "" Then
                MsgBox("Please Enter A Student CNIC No", MsgBoxStyle.Information)
                TxtNicNo.Focus()
            ElseIf TxtSContact.Text = "" Then
                MsgBox("Please Enter A Contact No Of A Student", MsgBoxStyle.Information)
                TxtSContact.Focus()
            ElseIf checkduplicaterecord() = False Then
                MsgBox("Duplicate Record Is Not Allowed", MsgBoxStyle.Information)
                Else
                    obj.insert("insert into TblStudentInformation (SRegNo,DeptNo,ProgNo,SName,SFatherName,SAddress,SContact,snic,SessionStart,SessionEnd) values ('" & TxtSRegNo.Text.Trim & "' , '" & TxtDeptNo.SelectedValue & "' , '" & TxtProgNo.SelectedValue & "' , '" & TxtSName.Text.Trim & "' , '" & TxtSFatherName.Text.Trim & "' , '" & TxtSAddress.Text.Trim & "' ,  '" & TxtSContact.Text.Trim & "' , '" & TxtNicNo.Text.Trim & "' , '" & TxtSessionstart.Text.Trim & "' , '" & Txtsessionend.Text.Trim & "'  )")
                    clear()
                End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Stored", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub TxtDeptNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDeptNo.SelectedIndexChanged
        fillprogno()
    End Sub
    Private Sub TxtSName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSName.KeyPress
        If Asc(e.KeyChar) = 8 Or (Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 90) Or
(Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TxtSContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSContact.KeyPress
        If (Asc(e.KeyChar) >= 48) And (Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TxtSRegNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSRegNo.KeyPress
        If (Asc(e.KeyChar) >= 44) And (Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or (Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 90) Or
       (Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 35 Or Asc(e.KeyChar) = 40 Or Asc(e.KeyChar) = 41 Or Asc(e.KeyChar) = 61 Or
       Asc(e.KeyChar) = 95 Or Asc(e.KeyChar) = 34 Or Asc(e.KeyChar) = 59 Or Asc(e.KeyChar) = 58 Or Asc(e.KeyChar) = 32 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then
            BtnAdd.Focus()
        End If
    End Sub

    Private Sub TxtSRegNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSRegNo.TextChanged

    End Sub

    Private Sub TxtSFatherName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSFatherName.KeyPress
        If Asc(e.KeyChar) = 8 Or (Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 90) Or
(Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 32 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then
            BtnAdd.Focus()
        End If
    End Sub
    Private Sub TxtSAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSAddress.KeyPress
        If (Asc(e.KeyChar) >= 44) And (Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or (Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 90) Or
(Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 35 Or Asc(e.KeyChar) = 40 Or Asc(e.KeyChar) = 41 Or Asc(e.KeyChar) = 61 Or
Asc(e.KeyChar) = 95 Or Asc(e.KeyChar) = 34 Or Asc(e.KeyChar) = 59 Or Asc(e.KeyChar) = 58 Or Asc(e.KeyChar) = 32 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TxtNicNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNicNo.KeyPress
        If (Asc(e.KeyChar) >= 48) And (Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function checkduplicaterecord() As Boolean
        qry = "Select * from tblstudentinformation where sregno='" & TxtSRegNo.Text.Trim & "' "
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

    Private Sub Txtsessionend_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtsessionend.ValueChanged
    End Sub

    Private Sub TxtNicNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNicNo.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If rate = 0 Then
                regno = InputBox("Please Enter A Value")
                Dg.DataSource = obj.showdata("select * from TblStudentinformation where sregno='" & regno & "' ").Tables(0)
                TxtSName.Text = obj.showdata("select * from tblstudentinformation where sregno='" & regno & "' ").Tables(0).Rows(0).Item("sName")
                TxtSFatherName.Text = obj.showdata("select * from tblstudentinformation where sregno='" & regno & "' ").Tables(0).Rows(0).Item("sfathername")
                TxtSAddress.Text = obj.showdata("select * from tblstudentinformation where sregno='" & regno & "' ").Tables(0).Rows(0).Item("saddress")
                TxtNicNo.Text = obj.showdata("select * from tblstudentinformation where sregno='" & regno & "' ").Tables(0).Rows(0).Item("snic")
                TxtSContact.Text = obj.showdata("select * from tblstudentinformation where sregno='" & regno & "' ").Tables(0).Rows(0).Item("scontact")
                rate = 1
            ElseIf rate = 1 Then
                obj.update("update TblStudentinformation set sname=' " & TxtSName.Text.Trim & "', sfathername='" & TxtSFatherName.Text.Trim & "' ,  saddress='" & TxtSAddress.Text.Trim & "' ,  snic='" & TxtNicNo.Text.Trim & "' ,  scontact='" & TxtSContact.Text.Trim & "'  where sregno='" & regno & "' ")
                rate = 0
                clear()
            End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Updated", MsgBoxStyle.Information)
            clear()
        End Try

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class