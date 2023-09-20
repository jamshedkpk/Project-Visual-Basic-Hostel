Public Class FrmSearchMessRate
    Dim OBJ As New DBClass
    Private Sub FrmSearchMessRates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Public Sub clear()
        dg.DataSource = OBJ.showdata("select HostelNo, HostelName, HostelLocation, Rate from vwsearchmessrates").Tables(0)
        fillhostels()
    End Sub
    Public Sub fillhostels()
        TxtHostelNo.DataSource = OBJ.showdata("select * from TblHostel  ").Tables(0)
        TxtHostelNo.DisplayMember = "HostelName"
        TxtHostelNo.ValueMember = "HostelNo"
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        dg.DataSource = OBJ.showdata("select HostelNo, HostelName, HostelLocation, Rate from vwsearchmessrates where HostelName='" & TxtHostelNo.Text & "' ").Tables(0)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rpt As New RptMessRate
            Dim frm As New Frmreport
        rpt.SetDataSource(OBJ.showdata("Select * from vwsearchmessrates where hostelname='" & TxtHostelNo.Text & "' ").Tables(0))
            frm.V.ReportSource = rpt
            frm.ShowDialog()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class