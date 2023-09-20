<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TblClearance
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
        Me.TxtDateFrom = New System.Windows.Forms.TextBox()
        Me.LblRemarks = New System.Windows.Forms.Label()
        Me.LblANo = New System.Windows.Forms.Label()
        Me.TxtDateTo = New System.Windows.Forms.TextBox()
        Me.TxtCNo = New System.Windows.Forms.TextBox()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.LblCNo = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblSRegNo = New System.Windows.Forms.Label()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDateFrom
        '
        Me.TxtDateFrom.Location = New System.Drawing.Point(561, 18)
        Me.TxtDateFrom.Name = "TxtDateFrom"
        Me.TxtDateFrom.Size = New System.Drawing.Size(143, 20)
        Me.TxtDateFrom.TabIndex = 32
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Location = New System.Drawing.Point(449, 92)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(49, 13)
        Me.LblRemarks.TabIndex = 40
        Me.LblRemarks.Text = "Remarks"
        '
        'LblANo
        '
        Me.LblANo.AutoSize = True
        Me.LblANo.Location = New System.Drawing.Point(449, 26)
        Me.LblANo.Name = "LblANo"
        Me.LblANo.Size = New System.Drawing.Size(70, 13)
        Me.LblANo.TabIndex = 39
        Me.LblANo.Text = "Allocation No"
        '
        'TxtDateTo
        '
        Me.TxtDateTo.Location = New System.Drawing.Point(561, 85)
        Me.TxtDateTo.Name = "TxtDateTo"
        Me.TxtDateTo.Size = New System.Drawing.Size(143, 20)
        Me.TxtDateTo.TabIndex = 33
        '
        'TxtCNo
        '
        Me.TxtCNo.Location = New System.Drawing.Point(224, 21)
        Me.TxtCNo.Name = "TxtCNo"
        Me.TxtCNo.Size = New System.Drawing.Size(143, 20)
        Me.TxtCNo.TabIndex = 30
        '
        'Dg
        '
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Location = New System.Drawing.Point(83, 207)
        Me.Dg.Name = "Dg"
        Me.Dg.Size = New System.Drawing.Size(621, 150)
        Me.Dg.TabIndex = 37
        '
        'LblCNo
        '
        Me.LblCNo.AutoSize = True
        Me.LblCNo.Location = New System.Drawing.Point(80, 26)
        Me.LblCNo.Name = "LblCNo"
        Me.LblCNo.Size = New System.Drawing.Size(72, 13)
        Me.LblCNo.TabIndex = 36
        Me.LblCNo.Text = "Clearance No"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(224, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 20)
        Me.TextBox1.TabIndex = 41
        '
        'LblSRegNo
        '
        Me.LblSRegNo.AutoSize = True
        Me.LblSRegNo.Location = New System.Drawing.Point(80, 92)
        Me.LblSRegNo.Name = "LblSRegNo"
        Me.LblSRegNo.Size = New System.Drawing.Size(120, 13)
        Me.LblSRegNo.TabIndex = 42
        Me.LblSRegNo.Text = "Student Registration No"
        '
        'TblClearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 374)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblSRegNo)
        Me.Controls.Add(Me.TxtDateFrom)
        Me.Controls.Add(Me.LblRemarks)
        Me.Controls.Add(Me.LblANo)
        Me.Controls.Add(Me.TxtDateTo)
        Me.Controls.Add(Me.TxtCNo)
        Me.Controls.Add(Me.Dg)
        Me.Controls.Add(Me.LblCNo)
        Me.Name = "TblClearance"
        Me.Text = "TblClearance"
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDateFrom As System.Windows.Forms.TextBox
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents LblANo As System.Windows.Forms.Label
    Friend WithEvents TxtDateTo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCNo As System.Windows.Forms.TextBox
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents LblCNo As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LblSRegNo As System.Windows.Forms.Label
End Class
