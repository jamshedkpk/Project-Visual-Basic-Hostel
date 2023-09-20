<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmprogram
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmprogram))
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.TxtProglName = New System.Windows.Forms.TextBox()
        Me.TxtProgNo = New System.Windows.Forms.TextBox()
        Me.LblDeptNo = New System.Windows.Forms.Label()
        Me.LblProgName = New System.Windows.Forms.Label()
        Me.LblProgNo = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtDeptNo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Location = New System.Drawing.Point(27, 20)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.Size = New System.Drawing.Size(338, 190)
        Me.Dg.TabIndex = 115
        '
        'TxtProglName
        '
        Me.TxtProglName.BackColor = System.Drawing.Color.Pink
        Me.TxtProglName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProglName.Location = New System.Drawing.Point(166, 100)
        Me.TxtProglName.MaxLength = 20
        Me.TxtProglName.Name = "TxtProglName"
        Me.TxtProglName.Size = New System.Drawing.Size(168, 26)
        Me.TxtProglName.TabIndex = 1
        '
        'TxtProgNo
        '
        Me.TxtProgNo.BackColor = System.Drawing.Color.Pink
        Me.TxtProgNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProgNo.Location = New System.Drawing.Point(166, 20)
        Me.TxtProgNo.Name = "TxtProgNo"
        Me.TxtProgNo.ReadOnly = True
        Me.TxtProgNo.Size = New System.Drawing.Size(168, 26)
        Me.TxtProgNo.TabIndex = 1000
        '
        'LblDeptNo
        '
        Me.LblDeptNo.AutoSize = True
        Me.LblDeptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeptNo.Location = New System.Drawing.Point(6, 66)
        Me.LblDeptNo.Name = "LblDeptNo"
        Me.LblDeptNo.Size = New System.Drawing.Size(102, 20)
        Me.LblDeptNo.TabIndex = 11
        Me.LblDeptNo.Text = "Department :"
        '
        'LblProgName
        '
        Me.LblProgName.AutoSize = True
        Me.LblProgName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProgName.Location = New System.Drawing.Point(6, 103)
        Me.LblProgName.Name = "LblProgName"
        Me.LblProgName.Size = New System.Drawing.Size(123, 20)
        Me.LblProgName.TabIndex = 10
        Me.LblProgName.Text = "Program Name :"
        '
        'LblProgNo
        '
        Me.LblProgNo.AutoSize = True
        Me.LblProgNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProgNo.Location = New System.Drawing.Point(6, 29)
        Me.LblProgNo.Name = "LblProgNo"
        Me.LblProgNo.Size = New System.Drawing.Size(101, 20)
        Me.LblProgNo.TabIndex = 9
        Me.LblProgNo.Text = "Program No :"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(10, 135)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(139, 75)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtDeptNo
        '
        Me.TxtDeptNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtDeptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeptNo.FormattingEnabled = True
        Me.TxtDeptNo.Location = New System.Drawing.Point(166, 59)
        Me.TxtDeptNo.Name = "TxtDeptNo"
        Me.TxtDeptNo.Size = New System.Drawing.Size(168, 28)
        Me.TxtDeptNo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TxtProglName)
        Me.GroupBox1.Controls.Add(Me.TxtDeptNo)
        Me.GroupBox1.Controls.Add(Me.LblDeptNo)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.LblProgNo)
        Me.GroupBox1.Controls.Add(Me.LblProgName)
        Me.GroupBox1.Controls.Add(Me.TxtProgNo)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 291)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(166, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 75)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(810, 542)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(26, 58)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(765, 227)
        Me.GroupBox4.TabIndex = 1003
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hostel_Management.My.Resources.Resources.Hostel
        Me.PictureBox1.Location = New System.Drawing.Point(28, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(701, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dg)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(390, 291)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(401, 231)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 31)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Program Registration Form"
        '
        'Frmprogram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(844, 569)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaximizeBox = False
        Me.Name = "Frmprogram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program"
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents TxtProglName As System.Windows.Forms.TextBox
    Friend WithEvents TxtProgNo As System.Windows.Forms.TextBox
    Friend WithEvents LblDeptNo As System.Windows.Forms.Label
    Friend WithEvents LblProgName As System.Windows.Forms.Label
    Friend WithEvents LblProgNo As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtDeptNo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
