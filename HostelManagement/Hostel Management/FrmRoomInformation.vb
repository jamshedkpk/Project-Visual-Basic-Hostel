Public Class FrmRoomInformation
    Dim obj As New DBClass
    Dim ds As New System.Data.DataSet
    Dim qry As String
    Private Sub FrmRoomInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        TxtSNo.Text = obj.getKey("SNo")
        TxtRoomNo.Clear()
        TxtRoomNo.Focus()
        fillhostel()
        Dg.DataSource = obj.showdata("select Sno as SerialNo,HostelName,RoomNo,RoomType,Status,Capacity from vwsearchroom").Tables(0)
    End Sub
    Public Sub fillhostel()
        TxtHostelNo.DataSource = obj.showdata("select * from TblHostel").Tables(0)
        TxtHostelNo.DisplayMember = "HostelName"
        TxtHostelNo.ValueMember = "HostelNo"
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Try
            If TxtRoomNo.Text = "" Then
                MsgBox("Please Enter Room No", MsgBoxStyle.Information)
            ElseIf TxtRoomType.Text = "" Then
                MsgBox("Please Enter A Type For A Room", MsgBoxStyle.Information)
            ElseIf checkduplicaterecord() = False Then
                MsgBox("Duplicate Record Is Not Allowed", MsgBoxStyle.Information)
            Else
                fillrooms()
                obj.insert("insert into TblRoomInformation (SNo,RoomNo,HostelNo,Roomtype,Status,Capacity)VALUES ( '" & TxtSNo.Text.Trim & "' , '" & TxtRoomNo.Text.Trim & "', '" & TxtHostelNo.SelectedValue & "', '" & TxtRoomType.Text.Trim & "' , ' 0 ', '" & fillrooms() & "') ")
                obj.updateKey("SNo", TxtSNo.Text)
                clear()
            End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Stored", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub TxtRoomType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRoomType.SelectedIndexChanged
        fillrooms()
    End Sub
    Public Function fillrooms() As Integer
        If TxtRoomType.SelectedIndex = 0 Then
            Return 1
        ElseIf TxtRoomType.SelectedIndex = 1 Then
            Return 2
        ElseIf TxtRoomType.SelectedIndex = 2 Then
            Return 3
        End If
    End Function
    Private Sub TxtHostelNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtHostelNo.TextChanged
        fillrooms()
    End Sub

    Private Sub TxtRoomNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRoomNo.KeyPress
        If (Asc(e.KeyChar) >= 44) And (Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or (Asc(e.KeyChar) >= 65) And (Asc(e.KeyChar) <= 90) Or
(Asc(e.KeyChar) >= 97) And (Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 35 Or Asc(e.KeyChar) = 40 Or Asc(e.KeyChar) = 41 Or Asc(e.KeyChar) = 61 Or
 Asc(e.KeyChar) = 95 Or Asc(e.KeyChar) = 34 Or Asc(e.KeyChar) = 59 Or Asc(e.KeyChar) = 58 Or Asc(e.KeyChar) = 32 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function checkduplicaterecord() As Boolean
        qry = "Select * from tblroominformation where hostelno='" & TxtHostelNo.SelectedValue & "' and roomno='" & TxtRoomNo.Text.Trim & "' "
        ds = obj.showdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub TxtRoomNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRoomNo.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TxtSNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSNo.TextChanged

    End Sub

    Private Sub TxtHostelNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHostelNo.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub
End Class