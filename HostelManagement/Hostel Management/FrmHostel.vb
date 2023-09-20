Public Class FrmHostel
    Dim obj As New DBClass
    Dim qry As String
    Dim ds As New System.Data.DataSet
    Dim rate As Integer
    Dim hostelno As Integer
    Private Sub FrmHostel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        TxtHostelNo.Text = obj.getKey("HostelNo")
        TxtHostelName.Clear()
        TxtHostelLocation.Clear()
        TxtHostelName.Focus()
        Dg.DataSource = obj.showdata("select HostelNo,HostelName,HostelLocation from TblHostel").Tables(0)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Try
            If TxtHostelName.Text = "" Then
                MsgBox("Please Enter A Hostel Name", MsgBoxStyle.Information)
            ElseIf TxtHostelLocation.Text = "" Then
                MsgBox("Please Enter A Hostel Location", MsgBoxStyle.Information)
            ElseIf checkduplicaterecord() = False Then
                MsgBox("Duplicate Record Is Not Allowed", MsgBoxStyle.Information)
            Else

                obj.insert("insert into TblHostel (HostelNo,HostelName,HostelLocation) values ('" & TxtHostelNo.Text.Trim & "' , '" & TxtHostelName.Text.Trim & "' , '" & TxtHostelLocation.Text.Trim & "' )")
                obj.updateKey("hostelno", TxtHostelNo.Text.Trim)
                clear()
                Dim obj2 As New FrmMessRates
                obj2.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Record Is Not Stored", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub TxtHostelName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHostelName.KeyPress
        If (Asc(e.KeyChar) >= 44) And (Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or (Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 90) Or
(Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 35 Or Asc(e.KeyChar) = 40 Or Asc(e.KeyChar) = 41 Or Asc(e.KeyChar) = 61 Or
Asc(e.KeyChar) = 95 Or Asc(e.KeyChar) = 34 Or Asc(e.KeyChar) = 59 Or Asc(e.KeyChar) = 58 Or Asc(e.KeyChar) = 32 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 13 Then
            TxtHostelLocation.Focus()
        End If
    End Sub
    
    Private Sub TxtHostelName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHostelName.TextChanged
    End Sub
    Private Sub TxtHostelLocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHostelLocation.KeyPress
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
    Public Function checkduplicaterecord() As Boolean
        qry = "Select * from tblhostel where hostelname='" & TxtHostelName.Text.Trim & "' "
        ds = obj.showdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If rate = 0 Then
                hostelno = InputBox("Please Enter A Value")
                Dg.DataSource = obj.showdata("select * from Tblhostel where hostelno='" & hostelno & "' ").Tables(0)
                TxtHostelName.Text = obj.showdata("select * from Tblhostel where hostelno='" & hostelno & "' ").Tables(0).Rows(0).Item("HostelName")
                TxtHostelLocation.Text = obj.showdata("select * from Tblhostel where hostelno='" & hostelno & "' ").Tables(0).Rows(0).Item("HostelLocation")
                rate = 1
            ElseIf rate = 1 Then
                obj.update("update Tblhostel set Hostelname=' " & TxtHostelName.Text.Trim & "', Hostellocation=' " & TxtHostelLocation.Text.Trim & "' where hostelno='" & hostelno & "' ")
                rate = 0
                clear()
            End If
        Catch ex As Exception
            MsgBox("Record Is Not Updated", MsgBoxStyle.Information)

        End Try
    End Sub
End Class
