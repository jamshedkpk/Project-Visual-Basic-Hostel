<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoom
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
        Me.TxtHostelNo = New System.Windows.Forms.ComboBox()
        Me.TxtRoomType = New System.Windows.Forms.TextBox()
        Me.LblCapacity = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblRoomType = New System.Windows.Forms.Label()
        Me.LblRoomNo = New System.Windows.Forms.Label()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        Me.TxtSNo = New System.Windows.Forms.TextBox()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.LblSNo = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtCapacity = New System.Windows.Forms.TextBox()
        Me.LblHostelNo = New System.Windows.Forms.Label()
        Me.TxtRoomNo = New System.Windows.Forms.TextBox()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtHostelNo
        '
        Me.TxtHostelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtHostelNo.FormattingEnabled = True
        Me.TxtHostelNo.Location = New System.Drawing.Point(216, 134)
        Me.TxtHostelNo.Name = "TxtHostelNo"
        Me.TxtHostelNo.Size = New System.Drawing.Size(143, 21)
        Me.TxtHostelNo.TabIndex = 34
        '
        'TxtRoomType
        '
        Me.TxtRoomType.Location = New System.Drawing.Point(553, 32)
        Me.TxtRoomType.Name = "TxtRoomType"
        Me.TxtRoomType.Size = New System.Drawing.Size(143, 20)
        Me.TxtRoomType.TabIndex = 32
        '
        'LblCapacity
        '
        Me.LblCapacity.AutoSize = True
        Me.LblCapacity.Location = New System.Drawing.Point(441, 134)
        Me.LblCapacity.Name = "LblCapacity"
        Me.LblCapacity.Size = New System.Drawing.Size(48, 13)
        Me.LblCapacity.TabIndex = 41
        Me.LblCapacity.Text = "Capacity"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(441, 87)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(37, 13)
        Me.LblStatus.TabIndex = 40
        Me.LblStatus.Text = "Status"
        '
        'LblRoomType
        '
        Me.LblRoomType.AutoSize = True
        Me.LblRoomType.Location = New System.Drawing.Point(441, 40)
        Me.LblRoomType.Name = "LblRoomType"
        Me.LblRoomType.Size = New System.Drawing.Size(59, 13)
        Me.LblRoomType.TabIndex = 39
        Me.LblRoomType.Text = "RoomType"
        '
        'LblRoomNo
        '
        Me.LblRoomNo.AutoSize = True
        Me.LblRoomNo.Location = New System.Drawing.Point(72, 92)
        Me.LblRoomNo.Name = "LblRoomNo"
        Me.LblRoomNo.Size = New System.Drawing.Size(52, 13)
        Me.LblRoomNo.TabIndex = 38
        Me.LblRoomNo.Text = "Room No"
        '
        'TxtStatus
        '
        Me.TxtStatus.Location = New System.Drawing.Point(553, 80)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(143, 20)
        Me.TxtStatus.TabIndex = 33
        '
        'TxtSNo
        '
        Me.TxtSNo.Location = New System.Drawing.Point(216, 35)
        Me.TxtSNo.Name = "TxtSNo"
        Me.TxtSNo.Size = New System.Drawing.Size(143, 20)
        Me.TxtSNo.TabIndex = 30
        '
        'Dg
        '
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Location = New System.Drawing.Point(75, 221)
        Me.Dg.Name = "Dg"
        Me.Dg.Size = New System.Drawing.Size(621, 150)
        Me.Dg.TabIndex = 37
        '
        'LblSNo
        '
        Me.LblSNo.AutoSize = True
        Me.LblSNo.Location = New System.Drawing.Point(72, 40)
        Me.LblSNo.Name = "LblSNo"
        Me.LblSNo.Size = New System.Drawing.Size(50, 13)
        Me.LblSNo.TabIndex = 36
        Me.LblSNo.Text = "Serial No"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(216, 181)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(143, 23)
        Me.BtnAdd.TabIndex = 35
        Me.BtnAdd.Text = "BtnAdd"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtCapacity
        '
        Me.TxtCapacity.Location = New System.Drawing.Point(553, 134)
        Me.TxtCapacity.Name = "TxtCapacity"
        Me.TxtCapacity.Size = New System.Drawing.Size(143, 20)
        Me.TxtCapacity.TabIndex = 42
        '
        'LblHostelNo
        '
        Me.LblHostelNo.AutoSize = True
        Me.LblHostelNo.Location = New System.Drawing.Point(72, 142)
        Me.LblHostelNo.Name = "LblHostelNo"
        Me.LblHostelNo.Size = New System.Drawing.Size(54, 13)
        Me.LblHostelNo.TabIndex = 43
        Me.LblHostelNo.Text = "Hostel No"
        '
        'TxtRoomNo
        '
        Me.TxtRoomNo.Location = New System.Drawing.Point(216, 89)
        Me.TxtRoomNo.Name = "TxtRoomNo"
        Me.TxtRoomNo.Size = New System.Drawing.Size(143, 20)
        Me.TxtRoomNo.TabIndex = 44
        '
        'FrmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 397)
        Me.Controls.Add(Me.TxtRoomNo)
        Me.Controls.Add(Me.LblHostelNo)
        Me.Controls.Add(Me.TxtCapacity)
        Me.Controls.Add(Me.TxtHostelNo)
        Me.Controls.Add(Me.TxtRoomType)
        Me.Controls.Add(Me.LblCapacity)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.LblRoomType)
        Me.Controls.Add(Me.LblRoomNo)
        Me.Controls.Add(Me.TxtStatus)
        Me.Controls.Add(Me.TxtSNo)
        Me.Controls.Add(Me.Dg)
        Me.Controls.Add(Me.LblSNo)
        Me.Controls.Add(Me.BtnAdd)
        Me.Name = "FrmRoom"
        Me.Text = "FrmRoom"
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtHostelNo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtRoomType As System.Windows.Forms.TextBox
    Friend WithEvents LblCapacity As System.Windows.Forms.Label
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents LblRoomType As System.Windows.Forms.Label
    Friend WithEvents LblRoomNo As System.Windows.Forms.Label
    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
    Friend WithEvents TxtSNo As System.Windows.Forms.TextBox
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents LblSNo As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtCapacity As System.Windows.Forms.TextBox
    Friend WithEvents LblHostelNo As System.Windows.Forms.Label
    Friend WithEvents TxtRoomNo As System.Windows.Forms.TextBox
End Class
