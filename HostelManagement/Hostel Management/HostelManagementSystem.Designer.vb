<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HostelManagementSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.NewRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HostelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessRateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessAttendenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllocationReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearanceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessRateReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendenceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.RoomsReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Italic)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRegistrationToolStripMenuItem, Me.MessInformationToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1180, 31)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'NewRegistrationToolStripMenuItem
        '
        Me.NewRegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentToolStripMenuItem, Me.ProgramToolStripMenuItem, Me.HostelToolStripMenuItem, Me.RoomsToolStripMenuItem, Me.StudentToolStripMenuItem, Me.AllocationToolStripMenuItem, Me.ClearanceToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.NewRegistrationToolStripMenuItem.Name = "NewRegistrationToolStripMenuItem"
        Me.NewRegistrationToolStripMenuItem.Size = New System.Drawing.Size(155, 27)
        Me.NewRegistrationToolStripMenuItem.Text = "New Registration"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.DepartmentToolStripMenuItem.Text = "Department"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'HostelToolStripMenuItem
        '
        Me.HostelToolStripMenuItem.Name = "HostelToolStripMenuItem"
        Me.HostelToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.HostelToolStripMenuItem.Text = "Hostel"
        '
        'RoomsToolStripMenuItem
        '
        Me.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem"
        Me.RoomsToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.RoomsToolStripMenuItem.Text = "Rooms"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'AllocationToolStripMenuItem
        '
        Me.AllocationToolStripMenuItem.Name = "AllocationToolStripMenuItem"
        Me.AllocationToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.AllocationToolStripMenuItem.Text = "Allocation"
        '
        'ClearanceToolStripMenuItem
        '
        Me.ClearanceToolStripMenuItem.Name = "ClearanceToolStripMenuItem"
        Me.ClearanceToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.ClearanceToolStripMenuItem.Text = "Clearance"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MessInformationToolStripMenuItem
        '
        Me.MessInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessRateToolStripMenuItem, Me.MessAttendenceToolStripMenuItem, Me.MessPaymentToolStripMenuItem})
        Me.MessInformationToolStripMenuItem.Name = "MessInformationToolStripMenuItem"
        Me.MessInformationToolStripMenuItem.Size = New System.Drawing.Size(159, 27)
        Me.MessInformationToolStripMenuItem.Text = "Mess Information"
        '
        'MessRateToolStripMenuItem
        '
        Me.MessRateToolStripMenuItem.Name = "MessRateToolStripMenuItem"
        Me.MessRateToolStripMenuItem.Size = New System.Drawing.Size(210, 28)
        Me.MessRateToolStripMenuItem.Text = "Mess Rate"
        '
        'MessAttendenceToolStripMenuItem
        '
        Me.MessAttendenceToolStripMenuItem.Name = "MessAttendenceToolStripMenuItem"
        Me.MessAttendenceToolStripMenuItem.Size = New System.Drawing.Size(210, 28)
        Me.MessAttendenceToolStripMenuItem.Text = "Mess Attendence"
        '
        'MessPaymentToolStripMenuItem
        '
        Me.MessPaymentToolStripMenuItem.Name = "MessPaymentToolStripMenuItem"
        Me.MessPaymentToolStripMenuItem.Size = New System.Drawing.Size(210, 28)
        Me.MessPaymentToolStripMenuItem.Text = "Mess Payment"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(75, 27)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem1, Me.StudentToolStripMenuItem1, Me.AllocationReportToolStripMenuItem, Me.ClearanceReportToolStripMenuItem, Me.MessRateReportToolStripMenuItem, Me.AttendenceReportToolStripMenuItem, Me.PaymentReportToolStripMenuItem, Me.RoomsReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(81, 27)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ProgramToolStripMenuItem1
        '
        Me.ProgramToolStripMenuItem1.Name = "ProgramToolStripMenuItem1"
        Me.ProgramToolStripMenuItem1.Size = New System.Drawing.Size(223, 28)
        Me.ProgramToolStripMenuItem1.Text = "Program Report"
        '
        'StudentToolStripMenuItem1
        '
        Me.StudentToolStripMenuItem1.Name = "StudentToolStripMenuItem1"
        Me.StudentToolStripMenuItem1.Size = New System.Drawing.Size(223, 28)
        Me.StudentToolStripMenuItem1.Text = "Student Report"
        '
        'AllocationReportToolStripMenuItem
        '
        Me.AllocationReportToolStripMenuItem.Name = "AllocationReportToolStripMenuItem"
        Me.AllocationReportToolStripMenuItem.Size = New System.Drawing.Size(223, 28)
        Me.AllocationReportToolStripMenuItem.Text = "Allocation Report"
        '
        'ClearanceReportToolStripMenuItem
        '
        Me.ClearanceReportToolStripMenuItem.Name = "ClearanceReportToolStripMenuItem"
        Me.ClearanceReportToolStripMenuItem.Size = New System.Drawing.Size(223, 28)
        Me.ClearanceReportToolStripMenuItem.Text = "Clearance Report"
        '
        'MessRateReportToolStripMenuItem
        '
        Me.MessRateReportToolStripMenuItem.Name = "MessRateReportToolStripMenuItem"
        Me.MessRateReportToolStripMenuItem.Size = New System.Drawing.Size(223, 28)
        Me.MessRateReportToolStripMenuItem.Text = "Mess Rate Report"
        '
        'AttendenceReportToolStripMenuItem
        '
        Me.AttendenceReportToolStripMenuItem.Name = "AttendenceReportToolStripMenuItem"
        Me.AttendenceReportToolStripMenuItem.Size = New System.Drawing.Size(223, 28)
        Me.AttendenceReportToolStripMenuItem.Text = "Attendence Report"
        '
        'PaymentReportToolStripMenuItem
        '
        Me.PaymentReportToolStripMenuItem.Name = "PaymentReportToolStripMenuItem"
        Me.PaymentReportToolStripMenuItem.Size = New System.Drawing.Size(223, 28)
        Me.PaymentReportToolStripMenuItem.Text = "Payment Report"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(49, 27)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1180, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'RoomsReportToolStripMenuItem
        '
        Me.RoomsReportToolStripMenuItem.Name = "RoomsReportToolStripMenuItem"
        Me.RoomsReportToolStripMenuItem.Size = New System.Drawing.Size(223, 28)
        Me.RoomsReportToolStripMenuItem.Text = "Rooms Report"
        '
        'HostelManagementSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1180, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "HostelManagementSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HostelManagementSystem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents NewRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HostelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessRateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessAttendenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllocationReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearanceReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessRateReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendenceReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomsReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
