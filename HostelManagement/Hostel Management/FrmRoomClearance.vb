Public Class FrmRoomClearance
    Dim obj As New DBClass
    Dim ds As New System.Data.DataSet
    Dim qry As String
    Private Sub FrmRoomAllocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        TxtCNo.Text = obj.getKey("CNo")
        TxtRemakrs.Clear()
        TxtSRegNo.Clear()
        Dg.DataSource = obj.showdata("select Cno as ClearanceNo,sregno as RegistrationNo,sName as Name,RoomNo,DateFrom,DateTo,Remarks from vwsearchClearance").Tables(0)
        TxtSRegNo.Focus()
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Try
            If TxtSRegNo.Text = "" Then
                MsgBox("Please Enter A Student Registration No", MsgBoxStyle.Information)
            ElseIf TxtRemakrs.Text = "" Then
                MsgBox("Please Enter A Remarks", MsgBoxStyle.Information)
            ElseIf checkduplicaterecord() = False Then
                MsgBox("Sorry The Student Has Already Cleared Its Record", MsgBoxStyle.Information)
            Else
                obj.insert("insert into TblRoomClearance values ('" & TxtCNo.Text & "' , '" & TxtSRegNo.Text & "' , '" & fillano() & "' , '" & TxtRemakrs.Text & "' ) ")
                obj.updateKey("CNo", TxtCNo.Text.Trim)
                obj.update("update TblRoomInformation set status = Status - 1 where SNo='" & fillsno() & "' ")
                clear()
            End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Stored", MsgBoxStyle.Information)
        End Try
    End Sub
    Public Function fillsno() As Integer
        Return obj.showdata("select * from vwsearchclearance where sregno='" & TxtSRegNo.Text & "' ").Tables(0).Rows(0).Item("sno")
    End Function
    Public Function fillano() As Integer
        Try
            Return obj.showdata("select * from tblroomallocation where SRegNo='" & TxtSRegNo.Text.Trim & "' ").Tables(0).Rows(0).Item("ANo").ToString
        Catch ex As Exception
            MsgBox("The Student Does Not Exist", MsgBoxStyle.Information)
        End Try
    End Function
    Private Sub TxtSRegNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSRegNo.TextChanged
        Dim ds As New DataSet
        ds = obj.showdata("select SRegNo AS RegistrationNo,sName as Name , sFatherName as FatherName,sNic as NICNo,Scontact as Contact from VWSEARCHALLOCATION where SRegNo LIKE'" & TxtSRegNo.Text.Trim & "%'")
        If ds.Tables(0).Rows.Count <> 0 Then
            Dg2.DataSource = ds.Tables(0)
        Else
            TxtSRegNo.Clear()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(fillsno)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Public Function checkduplicaterecord() As Boolean
        qry = "Select * from tblroomclearance where sregno='" & TxtSRegNo.Text.Trim & "'  "
        ds = obj.showdata(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TxtCNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCNo.TextChanged

    End Sub
End Class