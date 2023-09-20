Public Class FrmSearchStudent
    Dim obj As New DBClass
    Dim qry As String
    Dim ds As New System.Data.DataSet
    Private Sub FrmSearchStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        dg.DataSource = obj.showdata("select SRegNo as RegistrationNo,SName StudentName,SFatherName as FatherName,SAddress as Address,snic as NICNo ,SContact As Contact,DeptName as Department,ProgName as Program,SessionStart,SessionEnd from VWSearchStudent").Tables(0)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clear()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TxtSRegNo.Text = "" Then
            MsgBox("Please Enter A Student Registration", MsgBoxStyle.Information)
        Else
            Dim rpt As New RptStudent
            Dim frm As New Frmreport
            rpt.SetDataSource(obj.showdata("Select * from vwsearchstudent where sregno='" & TxtSRegNo.Text.Trim & "' ").Tables(0))
            frm.V.ReportSource = rpt
            frm.ShowDialog()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If TxtSRegNo.Text = "" Then
                MsgBox("Please Enter A Student Registration", MsgBoxStyle.Information)
            Else
                dg.DataSource = obj.showdata("select SRegNo as RegistrationNo,SName StudentName,SFatherName as FatherName,SAddress as Address,snic as NICNo ,SContact As Contact,DeptName as Department,ProgName as Program,SessionStart,SessionEnd from VWSearchStudent where SRegNo = '" & TxtSRegNo.Text & "' ").Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub TxtSRegNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSRegNo.TextChanged
        Dim ds As New DataSet
        ds = obj.showdata("select SRegNo as RegistrationNo,SName StudentName,SFatherName as FatherName,SAddress as Address,snic as NICNo ,SContact As Contact,DeptName as Department,ProgName as Program,SessionStart,SessionEnd from VWSearchStudent where SRegNo LIKE'" & TxtSRegNo.Text.Trim & "%'")
        If ds.Tables(0).Rows.Count <> 0 Then
            dg.DataSource = ds.Tables(0)
        Else
            TxtSRegNo.Clear()
        End If
    End Sub
End Class