<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoomInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoomInformation))
        Me.TxtRoomNo = New System.Windows.Forms.TextBox()
        Me.LblHostelNo = New System.Windows.Forms.Label()
        Me.TxtHostelNo = New System.Windows.Forms.ComboBox()
        Me.LblRoomType = New System.Windows.Forms.Label()
        Me.LblRoomNo = New System.Windows.Forms.Label()
        Me.TxtSNo = New System.Windows.Forms.TextBox()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.LblSNo = New System.Windows.Forms.Label()
        Me.TxtRoomType = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
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
        'TxtRoomNo
        '
        Me.TxtRoomNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRoomNo.Location = New System.Drawing.Point(162, 176)
        Me.TxtRoomNo.MaxLength = 15
        Me.TxtRoomNo.Name = "TxtRoomNo"
        Me.TxtRoomNo.Size = New System.Drawing.Size(171, 26)
        Me.TxtRoomNo.TabIndex = 2
        '
        'LblHostelNo
        '
        Me.LblHostelNo.AutoSize = True
        Me.LblHostelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHostelNo.Location = New System.Drawing.Point(26, 87)
        Me.LblHostelNo.Name = "LblHostelNo"
        Me.LblHostelNo.Size = New System.Drawing.Size(63, 20)
        Me.LblHostelNo.TabIndex = 57
        Me.LblHostelNo.Text = "Hostel :"
        '
        'TxtHostelNo
        '
        Me.TxtHostelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtHostelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHostelNo.FormattingEnabled = True
        Me.TxtHostelNo.Location = New System.Drawing.Point(162, 84)
        Me.TxtHostelNo.Name = "TxtHostelNo"
        Me.TxtHostelNo.Size = New System.Drawing.Size(171, 28)
        Me.TxtHostelNo.TabIndex = 0
        '
        'LblRoomType
        '
        Me.LblRoomType.AutoSize = True
        Me.LblRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRoomType.Location = New System.Drawing.Point(26, 133)
        Me.LblRoomType.Name = "LblRoomType"
        Me.LblRoomType.Size = New System.Drawing.Size(94, 20)
        Me.LblRoomType.TabIndex = 53
        Me.LblRoomType.Text = "RoomType :"
        '
        'LblRoomNo
        '
        Me.LblRoomNo.AutoSize = True
        Me.LblRoomNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRoomNo.Location = New System.Drawing.Point(26, 174)
        Me.LblRoomNo.Name = "LblRoomNo"
        Me.LblRoomNo.Size = New System.Drawing.Size(84, 20)
        Me.LblRoomNo.TabIndex = 52
        Me.LblRoomNo.Text = "Room No :"
        '
        'TxtSNo
        '
        Me.TxtSNo.BackColor = System.Drawing.Color.Pink
        Me.TxtSNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSNo.Location = New System.Drawing.Point(162, 40)
        Me.TxtSNo.Name = "TxtSNo"
        Me.TxtSNo.ReadOnly = True
        Me.TxtSNo.Size = New System.Drawing.Size(171, 26)
        Me.TxtSNo.TabIndex = 1000
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Location = New System.Drawing.Point(29, 19)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.Size = New System.Drawing.Size(443, 291)
        Me.Dg.TabIndex = 51
        '
        'LblSNo
        '
        Me.LblSNo.AutoSize = True
        Me.LblSNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSNo.Location = New System.Drawing.Point(26, 41)
        Me.LblSNo.Name = "LblSNo"
        Me.LblSNo.Size = New System.Drawing.Size(81, 20)
        Me.LblSNo.TabIndex = 50
        Me.LblSNo.Text = "Serial No :"
        '
        'TxtRoomType
        '
        Me.TxtRoomType.BackColor = System.Drawing.Color.Pink
        Me.TxtRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRoomType.FormattingEnabled = True
        Me.TxtRoomType.Items.AddRange(New Object() {"Single", "Double", "Triple"})
        Me.TxtRoomType.Location = New System.Drawing.Point(162, 130)
        Me.TxtRoomType.Name = "TxtRoomType"
        Me.TxtRoomType.Size = New System.Drawing.Size(171, 28)
        Me.TxtRoomType.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.TxtRoomNo)
        Me.GroupBox1.Controls.Add(Me.TxtRoomType)
        Me.GroupBox1.Controls.Add(Me.LblHostelNo)
        Me.GroupBox1.Controls.Add(Me.TxtHostelNo)
        Me.GroupBox1.Controls.Add(Me.LblRoomNo)
        Me.GroupBox1.Controls.Add(Me.LblRoomType)
        Me.GroupBox1.Controls.Add(Me.TxtSNo)
        Me.GroupBox1.Controls.Add(Me.LblSNo)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 252)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 330)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(162, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 85)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(30, 225)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(121, 85)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(934, 603)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(27, 37)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(880, 209)
        Me.GroupBox4.TabIndex = 1003
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hostel_Management.My.Resources.Resources.colg
        Me.PictureBox1.Location = New System.Drawing.Point(28, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(821, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dg)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(404, 252)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(503, 330)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 26)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Room Registration Form"
        '
        'FrmRoomInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(961, 617)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.Color.Beige
        Me.MaximizeBox = False
        Me.Name = "FrmRoomInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Information"
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
    Friend WithEvents TxtRoomNo As System.Windows.Forms.TextBox
    Friend WithEvents LblHostelNo As System.Windows.Forms.Label
    Friend WithEvents TxtHostelNo As System.Windows.Forms.ComboBox
    Friend WithEvents LblRoomType As System.Windows.Forms.Label
    Friend WithEvents LblRoomNo As System.Windows.Forms.Label
    Friend WithEvents TxtSNo As System.Windows.Forms.TextBox
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents LblSNo As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
