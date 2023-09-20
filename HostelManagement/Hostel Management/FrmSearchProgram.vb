Public Class frmsearchprogram
    Dim obj As New DBClass
    Private Sub frmsearchprogram_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        filldept()
        dg.DataSource = obj.showdata("select ProgNo,ProgName from VWSearchProgram  ").Tables(0)
        dg2.DataSource = obj.showdata("select * from TblDepartment ").Tables(0)
    End Sub
    Public Sub filldept()
        TxtDeptlNo.DataSource = obj.showdata("select * from TblDepartment ").Tables(0)
        TxtDeptlNo.DisplayMember = "DeptName"
        TxtDeptlNo.ValueMember = "DeptNo"
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            dg.DataSource = obj.showdata("select ProgNo,ProgName from VWSearchProgram where deptname='" & TxtDeptlNo.Text & "' ").Tables(0)
            dg2.DataSource = obj.showdata("select * from TblDepartment where DeptNo='" & TxtDeptlNo.SelectedValue & "' ").Tables(0)
        Catch ex As Exception
            MsgBox("Sorry Record Is Not Found", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim rpt As New RptProgram
        Dim frm As New Frmreport
        rpt.SetDataSource(obj.showdata("Select * from vwsearchprogram where deptno='" & TxtDeptlNo.SelectedValue & "'").Tables(0))
        frm.V.ReportSource = rpt
        frm.ShowDialog()
    End Sub
End Class