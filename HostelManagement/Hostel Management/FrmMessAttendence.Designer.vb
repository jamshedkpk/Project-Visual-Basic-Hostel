<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMessAttendence
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMessAttendence))
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.TxtDate = New System.Windows.Forms.DateTimePicker()
        Me.LblHostelNo = New System.Windows.Forms.Label()
        Me.LblSRegNo = New System.Windows.Forms.Label()
        Me.TxtSRegNo = New System.Windows.Forms.ComboBox()
        Me.LblAttNo = New System.Windows.Forms.Label()
        Me.TxtHostelNo = New System.Windows.Forms.ComboBox()
        Me.TxtAttNo = New System.Windows.Forms.TextBox()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Location = New System.Drawing.Point(25, 19)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.Size = New System.Drawing.Size(629, 279)
        Me.Dg.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.LblQuantity)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TxtQuantity)
        Me.GroupBox1.Controls.Add(Me.TxtDate)
        Me.GroupBox1.Controls.Add(Me.LblHostelNo)
        Me.GroupBox1.Controls.Add(Me.LblSRegNo)
        Me.GroupBox1.Controls.Add(Me.TxtSRegNo)
        Me.GroupBox1.Controls.Add(Me.LblAttNo)
        Me.GroupBox1.Controls.Add(Me.TxtHostelNo)
        Me.GroupBox1.Controls.Add(Me.TxtAttNo)
        Me.GroupBox1.Controls.Add(Me.LblDate)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 321)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(176, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 83)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuantity.Location = New System.Drawing.Point(14, 180)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(76, 20)
        Me.LblQuantity.TabIndex = 19
        Me.LblQuantity.Text = "Quantity :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(18, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 84)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtQuantity
        '
        Me.TxtQuantity.BackColor = System.Drawing.Color.Pink
        Me.TxtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuantity.Location = New System.Drawing.Point(176, 181)
        Me.TxtQuantity.MaxLength = 2
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(157, 26)
        Me.TxtQuantity.TabIndex = 1
        '
        'TxtDate
        '
        Me.TxtDate.Location = New System.Drawing.Point(176, 146)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(157, 20)
        Me.TxtDate.TabIndex = 3
        '
        'LblHostelNo
        '
        Me.LblHostelNo.AutoSize = True
        Me.LblHostelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHostelNo.Location = New System.Drawing.Point(14, 62)
        Me.LblHostelNo.Name = "LblHostelNo"
        Me.LblHostelNo.Size = New System.Drawing.Size(83, 20)
        Me.LblHostelNo.TabIndex = 14
        Me.LblHostelNo.Text = "HostelNo :"
        '
        'LblSRegNo
        '
        Me.LblSRegNo.AutoSize = True
        Me.LblSRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSRegNo.Location = New System.Drawing.Point(14, 106)
        Me.LblSRegNo.Name = "LblSRegNo"
        Me.LblSRegNo.Size = New System.Drawing.Size(120, 20)
        Me.LblSRegNo.TabIndex = 16
        Me.LblSRegNo.Text = "Student Name :"
        '
        'TxtSRegNo
        '
        Me.TxtSRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtSRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSRegNo.FormattingEnabled = True
        Me.TxtSRegNo.Location = New System.Drawing.Point(176, 103)
        Me.TxtSRegNo.Name = "TxtSRegNo"
        Me.TxtSRegNo.Size = New System.Drawing.Size(157, 28)
        Me.TxtSRegNo.TabIndex = 0
        '
        'LblAttNo
        '
        Me.LblAttNo.AutoSize = True
        Me.LblAttNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAttNo.Location = New System.Drawing.Point(14, 18)
        Me.LblAttNo.Name = "LblAttNo"
        Me.LblAttNo.Size = New System.Drawing.Size(120, 20)
        Me.LblAttNo.TabIndex = 1
        Me.LblAttNo.Text = "AttendenceNo :"
        '
        'TxtHostelNo
        '
        Me.TxtHostelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtHostelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHostelNo.FormattingEnabled = True
        Me.TxtHostelNo.Location = New System.Drawing.Point(176, 60)
        Me.TxtHostelNo.Name = "TxtHostelNo"
        Me.TxtHostelNo.Size = New System.Drawing.Size(157, 28)
        Me.TxtHostelNo.TabIndex = 1
        '
        'TxtAttNo
        '
        Me.TxtAttNo.BackColor = System.Drawing.Color.Pink
        Me.TxtAttNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAttNo.Location = New System.Drawing.Point(176, 19)
        Me.TxtAttNo.Name = "TxtAttNo"
        Me.TxtAttNo.ReadOnly = True
        Me.TxtAttNo.Size = New System.Drawing.Size(157, 26)
        Me.TxtAttNo.TabIndex = 1000
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.Location = New System.Drawing.Point(14, 145)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(52, 20)
        Me.LblDate.TabIndex = 5
        Me.LblDate.Text = "Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 39)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Mess Attendence Form"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1092, 402)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dg)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(391, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(681, 321)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'FrmMessAttendence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1124, 437)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaximizeBox = False
        Me.Name = "FrmMessAttendence"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mess  Attendence"
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblHostelNo As System.Windows.Forms.Label
    Friend WithEvents LblSRegNo As System.Windows.Forms.Label
    Friend WithEvents TxtSRegNo As System.Windows.Forms.ComboBox
    Friend WithEvents LblAttNo As System.Windows.Forms.Label
    Friend WithEvents TxtHostelNo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAttNo As System.Windows.Forms.TextBox
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents LblQuantity As System.Windows.Forms.Label
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
