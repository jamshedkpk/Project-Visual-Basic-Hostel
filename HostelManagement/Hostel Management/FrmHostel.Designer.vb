<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHostel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHostel))
        Me.LblHostelNo = New System.Windows.Forms.Label()
        Me.LblHostelName = New System.Windows.Forms.Label()
        Me.LblHostelLocation = New System.Windows.Forms.Label()
        Me.TxtHostelNo = New System.Windows.Forms.TextBox()
        Me.TxtHostelName = New System.Windows.Forms.TextBox()
        Me.TxtHostelLocation = New System.Windows.Forms.TextBox()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblHostelNo
        '
        Me.LblHostelNo.AutoSize = True
        Me.LblHostelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHostelNo.Location = New System.Drawing.Point(11, 28)
        Me.LblHostelNo.Name = "LblHostelNo"
        Me.LblHostelNo.Size = New System.Drawing.Size(87, 20)
        Me.LblHostelNo.TabIndex = 1
        Me.LblHostelNo.Text = "Hostel No :"
        '
        'LblHostelName
        '
        Me.LblHostelName.AutoSize = True
        Me.LblHostelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHostelName.Location = New System.Drawing.Point(11, 127)
        Me.LblHostelName.Name = "LblHostelName"
        Me.LblHostelName.Size = New System.Drawing.Size(109, 20)
        Me.LblHostelName.TabIndex = 2
        Me.LblHostelName.Text = "Hostel Name :"
        '
        'LblHostelLocation
        '
        Me.LblHostelLocation.AutoSize = True
        Me.LblHostelLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHostelLocation.Location = New System.Drawing.Point(6, 229)
        Me.LblHostelLocation.Name = "LblHostelLocation"
        Me.LblHostelLocation.Size = New System.Drawing.Size(128, 20)
        Me.LblHostelLocation.TabIndex = 3
        Me.LblHostelLocation.Text = "Hostel Location :"
        '
        'TxtHostelNo
        '
        Me.TxtHostelNo.BackColor = System.Drawing.Color.Pink
        Me.TxtHostelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHostelNo.Location = New System.Drawing.Point(137, 22)
        Me.TxtHostelNo.Name = "TxtHostelNo"
        Me.TxtHostelNo.ReadOnly = True
        Me.TxtHostelNo.Size = New System.Drawing.Size(157, 26)
        Me.TxtHostelNo.TabIndex = 1000
        Me.TxtHostelNo.Tag = ""
        '
        'TxtHostelName
        '
        Me.TxtHostelName.BackColor = System.Drawing.Color.Pink
        Me.TxtHostelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHostelName.Location = New System.Drawing.Point(138, 121)
        Me.TxtHostelName.MaxLength = 15
        Me.TxtHostelName.Name = "TxtHostelName"
        Me.TxtHostelName.Size = New System.Drawing.Size(157, 26)
        Me.TxtHostelName.TabIndex = 0
        '
        'TxtHostelLocation
        '
        Me.TxtHostelLocation.BackColor = System.Drawing.Color.Pink
        Me.TxtHostelLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHostelLocation.Location = New System.Drawing.Point(138, 229)
        Me.TxtHostelLocation.MaxLength = 15
        Me.TxtHostelLocation.Name = "TxtHostelLocation"
        Me.TxtHostelLocation.Size = New System.Drawing.Size(157, 26)
        Me.TxtHostelLocation.TabIndex = 1
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Location = New System.Drawing.Point(16, 19)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.Size = New System.Drawing.Size(353, 294)
        Me.Dg.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.LblHostelNo)
        Me.GroupBox1.Controls.Add(Me.LblHostelName)
        Me.GroupBox1.Controls.Add(Me.LblHostelLocation)
        Me.GroupBox1.Controls.Add(Me.TxtHostelNo)
        Me.GroupBox1.Controls.Add(Me.TxtHostelName)
        Me.GroupBox1.Controls.Add(Me.TxtHostelLocation)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 331)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Hostel_Management.My.Resources.Resources.Pic__25_
        Me.Button2.Location = New System.Drawing.Point(317, 121)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 84)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(317, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 84)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(317, 19)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(157, 84)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hostel Registration Form"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(994, 605)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(956, 205)
        Me.GroupBox4.TabIndex = 1003
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hostel_Management.My.Resources.Resources.Hostel
        Me.PictureBox1.Location = New System.Drawing.Point(15, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(918, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dg)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(583, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 331)
        Me.GroupBox3.TabIndex = 101
        Me.GroupBox3.TabStop = False
        '
        'FrmHostel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1026, 620)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaximizeBox = False
        Me.Name = "FrmHostel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hostel"
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
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LblHostelNo As System.Windows.Forms.Label
    Friend WithEvents LblHostelName As System.Windows.Forms.Label
    Friend WithEvents LblHostelLocation As System.Windows.Forms.Label
    Friend WithEvents TxtHostelNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtHostelName As System.Windows.Forms.TextBox
    Friend WithEvents TxtHostelLocation As System.Windows.Forms.TextBox
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
