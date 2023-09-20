Public Class FrmRoomAllocation
    Dim obj As New DBClass
    Dim qry As String
    Dim ds As New System.Data.DataSet

    Private Sub FrmRoomAllocation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        fillsno()
    End Sub
    Private Sub FrmRoomAllocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        TxtANo.Text = obj.getKey("ANo")
        TxtSRegNo.Clear()
        fillhostels()
        Dg.DataSource = obj.showdata("select ano as AllocationNo,Sregno as StudenRegistrationNo,HostelName,RoomNo,DateFrom,DateTo from vwsearchallocation").Tables(0)
        TxtSRegNo.Focus()
    End Sub
    Public Sub fillrooms()
        TxtRoomNo.DataSource = obj.showdata("select * from VWSearchRoomStatus where hostelname='" & TxtHostelNo.Text & "' and  capacity>status ").Tables(0)
        TxtRoomNo.DisplayMember = "RoomName"
        TxtRoomNo.ValueMember = "RoomNo"
    End Sub
    Public Sub fillhostels()
        TxtHostelNo.DataSource = obj.showdata("select * from TblHostel").Tables(0)
        TxtHostelNo.DisplayMember = "HostelName"
        TxtHostelNo.ValueMember = "HostelNo"
    End Sub
    Private Sub TxtSRegNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSRegNo.TextChanged
        Dim ds As New DataSet
        ds = obj.showdata("select SRegNo AS RegistrationNo,sName as Name , sFatherName as FatherName,sNic as NICNo,Scontact as Contact from TblStudentInformation where SRegNo LIKE'" & TxtSRegNo.Text.Trim & "%'")
        If ds.Tables(0).Rows.Count <> 0 Then
            Dg2.DataSource = ds.Tables(0)
        Else
            TxtSRegNo.Clear()
        End If
         End Sub
    Private Sub TxtHostelNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHostelNo.KeyPress
        e.Handled = True
    End Sub
    Private Sub TxtHostelNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHostelNo.SelectedIndexChanged
        fillrooms()
    End Sub
    Private Sub BtnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Try
            If TxtSRegNo.Text = "" Then
                MsgBox("Please Enter A Student Registration No", MsgBoxStyle.Information)
            ElseIf checkduplicaterecord() = False Then
                MsgBox("Duplicate Record Is Not Allowed", MsgBoxStyle.Information)
                Else

                    obj.insert("insert into TblRoomAllocation (ANo,SRegNo,DateFrom,DateTo,SNo) values ('" & TxtANo.Text.Trim & "' , '" & TxtSRegNo.Text.Trim & "' , '" & TxtDateFrom.Text.Trim & "' , '" & TxtDateTo.Text.Trim & "' , '" & fillsno() & "' ) ")
                    obj.update("update TblRoomInformation set status = Status + 1 where SNo='" & fillsno() & "' ")
                    obj.updateKey("ANo", TxtANo.Text.Trim)
                    clear()
                End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Stored", MsgBoxStyle.Information)
        End Try
    End Sub
    Public Function fillsno() As Integer
        Try
            Return obj.showdata("select sno from VWSearchroom where hostelno='" & TxtHostelNo.SelectedValue & "' and roomno='" & TxtRoomNo.SelectedValue & "'").Tables(0).Rows(0).Item("sno")
        Catch ex As Exception
            MsgBox("There Is No Room Available In The Selected Hostel", MsgBoxStyle.Information)
        End Try
    End Function
    Public Function checkduplicaterecord() As Boolean
        qry = "Select * from tblroomallocation where sregno='" & TxtSRegNo.Text.Trim & "' "
        ds = obj.showdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class