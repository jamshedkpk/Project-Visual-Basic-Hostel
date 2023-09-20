Imports System.Data
Imports System.Data.SqlClient
Public Class DBClass
    Dim cn As New SqlConnection("Data Source=LocalHost\SQLEXPRESS;Initial Catalog=HostelManagementsystem;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Sub insert(ByVal qry As String)
        cn.Open()
        cmd = New SqlCommand(qry, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
    Sub update(ByVal qry As String)
        cn.Open()
        cmd = New SqlCommand(qry, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
    Sub delete(ByVal qry As String)
        cn.Open()
        cmd = New SqlCommand(qry, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
    Function showdata(ByVal qry As String) As DataSet
        Dim ds As New DataSet
        cn.Open()
        da = New SqlDataAdapter(qry, cn)
        da.Fill(ds)
        cn.Close()
        Return ds
    End Function
    Function getKey(ByVal key As String) As Integer
        Dim ds As New DataSet
        cn.Open()
        da = New SqlDataAdapter("select * from tblAutoKey where PKey='" & key & "'", cn)
        da.Fill(ds)
        cn.Close()
        Return ds.Tables(0).Rows(0).Item("Val").ToString + 1
    End Function
    Sub updateKey(ByVal key As String, ByVal val As String)
        cn.Open()
        cmd = New SqlCommand("update TblAutoKey set val='" & val & "' where Pkey='" & key & "'", cn)
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
