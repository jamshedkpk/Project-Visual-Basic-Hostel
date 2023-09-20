Imports System.Windows.Forms

Public Class HostelManagementSystem

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        Dim obj As New Frmdepartment
        obj.MdiParent = Me
        obj.Show()
    End Sub

    Private Sub ProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramToolStripMenuItem.Click
        Dim obj As New Frmprogram
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub HostelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HostelToolStripMenuItem.Click
        Dim obj As New FrmHostel
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub RoomsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsToolStripMenuItem.Click
        Dim obj As New FrmRoomInformation
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        Dim obj As New FrmStudentInformation
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub AllocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllocationToolStripMenuItem.Click
        Dim obj As New FrmRoomAllocation
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub ClearanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearanceToolStripMenuItem.Click
        Dim obj As New FrmRoomClearance
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub MessRateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessRateToolStripMenuItem.Click
        Dim obj As New FrmMessRates
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub MessAttendenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessAttendenceToolStripMenuItem.Click
        Dim obj As New FrmMessAttendence
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub MessPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessPaymentToolStripMenuItem.Click
        Dim obj As New FrmMessPayment
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Dispose()
    End Sub

    Private Sub ProgramToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramToolStripMenuItem1.Click
        Dim obj As New frmsearchprogram
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub StudentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem1.Click
        Dim obj As New FrmSearchStudent
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub AllocationReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllocationReportToolStripMenuItem.Click
        Dim obj As New FrmSearchAllocation
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub ClearanceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearanceReportToolStripMenuItem.Click
        Dim obj As New FrmSearchClearance
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub MessRateReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessRateReportToolStripMenuItem.Click
        Dim obj As New FrmSearchMessRate
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub AttendenceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendenceReportToolStripMenuItem.Click
        Dim obj As New FrmSearchMessAttendence
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub PaymentReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentReportToolStripMenuItem.Click
        Dim obj As New FrmSearchMessPayment
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim obj As New FrmSearchRecord
        obj.MdiParent = Me
        obj.Show()
    End Sub

    Private Sub RoomsReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsReportToolStripMenuItem.Click
        Dim obj As New FrmSearchRoom
        obj.MdiParent = Me
        obj.Show()
    End Sub
End Class
