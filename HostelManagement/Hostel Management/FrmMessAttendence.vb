Public Class FrmMessAttendence
    Dim obj As New DBClass
    Dim qry As String
    Dim ds As New System.Data.DataSet
    Private Sub FrmMessAttendence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        TxtAttNo.Text = obj.getKey("AttNo")
        Dg.DataSource = obj.showdata("select Attno as AttendenceNo,HostelName,sName as StudentName,Date,Quantity,TotalPrice  from vwsearchMessAttendence").Tables(0)
        TxtSRegNo.Focus()
        fillhostels()
        fillsregno()
        TxtQuantity.Clear()
    End Sub
    Public Sub fillhostels()
        TxtHostelNo.DataSource = obj.showdata("select * from TblHostel  ").Tables(0)
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
            If TxtQuantity.Text = "" Then
                MsgBox("Please Fill Quantity", MsgBoxStyle.Information)
            ElseIf checkduplicaterecord() = False Then
                MsgBox("Duplicate Record Is Not Allowed", MsgBoxStyle.Information)
            Else

                obj.insert("insert into TblMessAttendence (AttNo,HostelNo,SRegNo,Date,Status,Quantity,TotalPrice)VALUES ( '" & TxtAttNo.Text.Trim & "' , '" & TxtHostelNo.SelectedValue & "', '" & TxtSRegNo.SelectedValue & "', '" & TxtDate.Text & "','" & 1 & "' , '" & TxtQuantity.Text.Trim & "','" & checkmessrate() & "' )")
                obj.updateKey("AttNo", TxtAttNo.Text)
                clear()
            End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Added", MsgBoxStyle.Information)
        End Try
    End Sub
    Public Function checkmessrate() As Integer
        Try
            Dim totalprice As Integer
            Dim rate As Integer
            rate = obj.showdata("select Rate from TblMessRates where HostelNo='" & TxtHostelNo.SelectedValue & "' ").Tables(0).Rows(0).Item("Rate").ToString()
            totalprice = rate * TxtQuantity.Text
            Return totalprice
        Catch ex As Exception
            MsgBox("Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Function
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(checkmessrate)
    End Sub

    Private Sub TxtHostelNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHostelNo.SelectedIndexChanged
        fillsregno()
    End Sub
    Private Sub TxtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQuantity.KeyPress
        If (Asc(e.KeyChar) >= 48) And (Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function checkduplicaterecord() As Boolean
        qry = "Select * from tblMessattendence where date='" & TxtDate.Text.Trim & "' and sregno='" & TxtSRegNo.SelectedValue & "' "
        ds = obj.showdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()

    End Sub
End Class