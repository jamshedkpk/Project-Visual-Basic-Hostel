<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoomClearance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoomClearance))
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblCNo = New System.Windows.Forms.Label()
        Me.LblSRegNo = New System.Windows.Forms.Label()
        Me.TxtRemakrs = New System.Windows.Forms.TextBox()
        Me.TxtCNo = New System.Windows.Forms.TextBox()
        Me.LblRemarks = New System.Windows.Forms.Label()
        Me.TxtSRegNo = New System.Windows.Forms.TextBox()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Dg2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(24, 321)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(180, 64)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LblCNo)
        Me.GroupBox1.Controls.Add(Me.LblSRegNo)
        Me.GroupBox1.Controls.Add(Me.TxtRemakrs)
        Me.GroupBox1.Controls.Add(Me.TxtCNo)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.LblRemarks)
        Me.GroupBox1.Controls.Add(Me.TxtSRegNo)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 415)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(17, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(387, 39)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Student Clearance Form"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(210, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 64)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblCNo
        '
        Me.LblCNo.AutoSize = True
        Me.LblCNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCNo.Location = New System.Drawing.Point(20, 120)
        Me.LblCNo.Name = "LblCNo"
        Me.LblCNo.Size = New System.Drawing.Size(113, 20)
        Me.LblCNo.TabIndex = 12
        Me.LblCNo.Text = "Clearance No :"
        '
        'LblSRegNo
        '
        Me.LblSRegNo.AutoSize = True
        Me.LblSRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSRegNo.Location = New System.Drawing.Point(20, 184)
        Me.LblSRegNo.Name = "LblSRegNo"
        Me.LblSRegNo.Size = New System.Drawing.Size(127, 20)
        Me.LblSRegNo.TabIndex = 13
        Me.LblSRegNo.Text = "Registration No :"
        '
        'TxtRemakrs
        '
        Me.TxtRemakrs.BackColor = System.Drawing.Color.Pink
        Me.TxtRemakrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemakrs.Location = New System.Drawing.Point(210, 246)
        Me.TxtRemakrs.Name = "TxtRemakrs"
        Me.TxtRemakrs.Size = New System.Drawing.Size(180, 26)
        Me.TxtRemakrs.TabIndex = 1
        '
        'TxtCNo
        '
        Me.TxtCNo.BackColor = System.Drawing.Color.Pink
        Me.TxtCNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCNo.Location = New System.Drawing.Point(210, 120)
        Me.TxtCNo.Name = "TxtCNo"
        Me.TxtCNo.ReadOnly = True
        Me.TxtCNo.Size = New System.Drawing.Size(182, 26)
        Me.TxtCNo.TabIndex = 1000
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemarks.Location = New System.Drawing.Point(20, 252)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(81, 20)
        Me.LblRemarks.TabIndex = 17
        Me.LblRemarks.Text = "Remarks :"
        '
        'TxtSRegNo
        '
        Me.TxtSRegNo.BackColor = System.Drawing.Color.Pink
        Me.TxtSRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSRegNo.Location = New System.Drawing.Point(210, 184)
        Me.TxtSRegNo.Name = "TxtSRegNo"
        Me.TxtSRegNo.Size = New System.Drawing.Size(182, 26)
        Me.TxtSRegNo.TabIndex = 0
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Location = New System.Drawing.Point(17, 207)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.Size = New System.Drawing.Size(553, 183)
        Me.Dg.TabIndex = 24
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1069, 459)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Dg2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Dg)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox4.Location = New System.Drawing.Point(446, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(601, 415)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        '
        'Dg2
        '
        Me.Dg2.AllowUserToAddRows = False
        Me.Dg2.AllowUserToDeleteRows = False
        Me.Dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg2.Location = New System.Drawing.Point(17, 49)
        Me.Dg2.Name = "Dg2"
        Me.Dg2.ReadOnly = True
        Me.Dg2.Size = New System.Drawing.Size(553, 106)
        Me.Dg2.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(104, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 39)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Clearance Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(158, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 39)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Student Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1107, 499)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'FrmRoomClearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1141, 528)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaximizeBox = False
        Me.Name = "FrmRoomClearance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RoomClearance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblCNo As System.Windows.Forms.Label
    Friend WithEvents LblSRegNo As System.Windows.Forms.Label
    Friend WithEvents TxtRemakrs As System.Windows.Forms.TextBox
    Friend WithEvents TxtCNo As System.Windows.Forms.TextBox
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents TxtSRegNo As System.Windows.Forms.TextBox
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dg2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
