<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStudentInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStudentInformation))
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.LblSRegNo = New System.Windows.Forms.Label()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.TxtSRegNo = New System.Windows.Forms.TextBox()
        Me.TxtSName = New System.Windows.Forms.TextBox()
        Me.TxtSFatherName = New System.Windows.Forms.TextBox()
        Me.TxtSAddress = New System.Windows.Forms.TextBox()
        Me.TxtSContact = New System.Windows.Forms.TextBox()
        Me.LblDeptNo = New System.Windows.Forms.Label()
        Me.LblProgNo = New System.Windows.Forms.Label()
        Me.LblSName = New System.Windows.Forms.Label()
        Me.LblSFatherName = New System.Windows.Forms.Label()
        Me.LblSAddress = New System.Windows.Forms.Label()
        Me.LblSContact = New System.Windows.Forms.Label()
        Me.TxtDeptNo = New System.Windows.Forms.ComboBox()
        Me.TxtProgNo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblNicNo = New System.Windows.Forms.Label()
        Me.TxtNicNo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lblsessionend = New System.Windows.Forms.Label()
        Me.Lblsessionstart = New System.Windows.Forms.Label()
        Me.Txtsessionend = New System.Windows.Forms.DateTimePicker()
        Me.TxtSessionstart = New System.Windows.Forms.DateTimePicker()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(16, 337)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(191, 76)
        Me.BtnAdd.TabIndex = 6
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'LblSRegNo
        '
        Me.LblSRegNo.AutoSize = True
        Me.LblSRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSRegNo.Location = New System.Drawing.Point(12, 34)
        Me.LblSRegNo.Name = "LblSRegNo"
        Me.LblSRegNo.Size = New System.Drawing.Size(127, 20)
        Me.LblSRegNo.TabIndex = 1
        Me.LblSRegNo.Text = "Registration No :"
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Location = New System.Drawing.Point(17, 20)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.Size = New System.Drawing.Size(715, 352)
        Me.Dg.TabIndex = 2
        '
        'TxtSRegNo
        '
        Me.TxtSRegNo.BackColor = System.Drawing.Color.Pink
        Me.TxtSRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSRegNo.Location = New System.Drawing.Point(213, 31)
        Me.TxtSRegNo.Name = "TxtSRegNo"
        Me.TxtSRegNo.Size = New System.Drawing.Size(191, 26)
        Me.TxtSRegNo.TabIndex = 0
        '
        'TxtSName
        '
        Me.TxtSName.BackColor = System.Drawing.Color.Pink
        Me.TxtSName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSName.Location = New System.Drawing.Point(213, 84)
        Me.TxtSName.Name = "TxtSName"
        Me.TxtSName.Size = New System.Drawing.Size(191, 26)
        Me.TxtSName.TabIndex = 1
        '
        'TxtSFatherName
        '
        Me.TxtSFatherName.BackColor = System.Drawing.Color.Pink
        Me.TxtSFatherName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSFatherName.Location = New System.Drawing.Point(213, 137)
        Me.TxtSFatherName.Name = "TxtSFatherName"
        Me.TxtSFatherName.Size = New System.Drawing.Size(191, 26)
        Me.TxtSFatherName.TabIndex = 2
        '
        'TxtSAddress
        '
        Me.TxtSAddress.BackColor = System.Drawing.Color.Pink
        Me.TxtSAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSAddress.Location = New System.Drawing.Point(213, 190)
        Me.TxtSAddress.Name = "TxtSAddress"
        Me.TxtSAddress.Size = New System.Drawing.Size(191, 26)
        Me.TxtSAddress.TabIndex = 3
        '
        'TxtSContact
        '
        Me.TxtSContact.BackColor = System.Drawing.Color.Pink
        Me.TxtSContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSContact.Location = New System.Drawing.Point(213, 290)
        Me.TxtSContact.MaxLength = 15
        Me.TxtSContact.Name = "TxtSContact"
        Me.TxtSContact.Size = New System.Drawing.Size(191, 26)
        Me.TxtSContact.TabIndex = 5
        '
        'LblDeptNo
        '
        Me.LblDeptNo.AutoSize = True
        Me.LblDeptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeptNo.Location = New System.Drawing.Point(24, 31)
        Me.LblDeptNo.Name = "LblDeptNo"
        Me.LblDeptNo.Size = New System.Drawing.Size(98, 20)
        Me.LblDeptNo.TabIndex = 10
        Me.LblDeptNo.Text = "Department "
        '
        'LblProgNo
        '
        Me.LblProgNo.AutoSize = True
        Me.LblProgNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProgNo.Location = New System.Drawing.Point(377, 31)
        Me.LblProgNo.Name = "LblProgNo"
        Me.LblProgNo.Size = New System.Drawing.Size(78, 20)
        Me.LblProgNo.TabIndex = 11
        Me.LblProgNo.Text = "Programe"
        '
        'LblSName
        '
        Me.LblSName.AutoSize = True
        Me.LblSName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSName.Location = New System.Drawing.Point(12, 84)
        Me.LblSName.Name = "LblSName"
        Me.LblSName.Size = New System.Drawing.Size(120, 20)
        Me.LblSName.TabIndex = 12
        Me.LblSName.Text = "Student Name :"
        '
        'LblSFatherName
        '
        Me.LblSFatherName.AutoSize = True
        Me.LblSFatherName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSFatherName.Location = New System.Drawing.Point(12, 140)
        Me.LblSFatherName.Name = "LblSFatherName"
        Me.LblSFatherName.Size = New System.Drawing.Size(110, 20)
        Me.LblSFatherName.TabIndex = 13
        Me.LblSFatherName.Text = "Father Name :"
        '
        'LblSAddress
        '
        Me.LblSAddress.AutoSize = True
        Me.LblSAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSAddress.Location = New System.Drawing.Point(12, 193)
        Me.LblSAddress.Name = "LblSAddress"
        Me.LblSAddress.Size = New System.Drawing.Size(137, 20)
        Me.LblSAddress.TabIndex = 14
        Me.LblSAddress.Text = "Student Address :"
        '
        'LblSContact
        '
        Me.LblSContact.AutoSize = True
        Me.LblSContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSContact.Location = New System.Drawing.Point(15, 290)
        Me.LblSContact.Name = "LblSContact"
        Me.LblSContact.Size = New System.Drawing.Size(134, 20)
        Me.LblSContact.TabIndex = 15
        Me.LblSContact.Text = "Student Contact :"
        '
        'TxtDeptNo
        '
        Me.TxtDeptNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtDeptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeptNo.FormattingEnabled = True
        Me.TxtDeptNo.Location = New System.Drawing.Point(161, 31)
        Me.TxtDeptNo.Name = "TxtDeptNo"
        Me.TxtDeptNo.Size = New System.Drawing.Size(191, 28)
        Me.TxtDeptNo.TabIndex = 0
        '
        'TxtProgNo
        '
        Me.TxtProgNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtProgNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProgNo.FormattingEnabled = True
        Me.TxtProgNo.Location = New System.Drawing.Point(494, 31)
        Me.TxtProgNo.Name = "TxtProgNo"
        Me.TxtProgNo.Size = New System.Drawing.Size(191, 28)
        Me.TxtProgNo.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.LblNicNo)
        Me.GroupBox1.Controls.Add(Me.TxtNicNo)
        Me.GroupBox1.Controls.Add(Me.LblSFatherName)
        Me.GroupBox1.Controls.Add(Me.LblSName)
        Me.GroupBox1.Controls.Add(Me.TxtSName)
        Me.GroupBox1.Controls.Add(Me.TxtSFatherName)
        Me.GroupBox1.Controls.Add(Me.LblSRegNo)
        Me.GroupBox1.Controls.Add(Me.LblSContact)
        Me.GroupBox1.Controls.Add(Me.LblSAddress)
        Me.GroupBox1.Controls.Add(Me.TxtSRegNo)
        Me.GroupBox1.Controls.Add(Me.TxtSAddress)
        Me.GroupBox1.Controls.Add(Me.TxtSContact)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 531)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Hostel_Management.My.Resources.Resources.Pic__25_
        Me.Button2.Location = New System.Drawing.Point(213, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(191, 80)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(16, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 76)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LblNicNo
        '
        Me.LblNicNo.AutoSize = True
        Me.LblNicNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNicNo.Location = New System.Drawing.Point(15, 243)
        Me.LblNicNo.Name = "LblNicNo"
        Me.LblNicNo.Size = New System.Drawing.Size(68, 20)
        Me.LblNicNo.TabIndex = 19
        Me.LblNicNo.Text = "NIC No :"
        '
        'TxtNicNo
        '
        Me.TxtNicNo.BackColor = System.Drawing.Color.Pink
        Me.TxtNicNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNicNo.Location = New System.Drawing.Point(213, 243)
        Me.TxtNicNo.MaxLength = 13
        Me.TxtNicNo.Name = "TxtNicNo"
        Me.TxtNicNo.Size = New System.Drawing.Size(191, 26)
        Me.TxtNicNo.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1238, 613)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Dg)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox4.Location = New System.Drawing.Point(463, 198)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(750, 391)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 39)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = " Student Registration Form"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lblsessionend)
        Me.GroupBox3.Controls.Add(Me.LblDeptNo)
        Me.GroupBox3.Controls.Add(Me.Lblsessionstart)
        Me.GroupBox3.Controls.Add(Me.TxtDeptNo)
        Me.GroupBox3.Controls.Add(Me.LblProgNo)
        Me.GroupBox3.Controls.Add(Me.Txtsessionend)
        Me.GroupBox3.Controls.Add(Me.TxtProgNo)
        Me.GroupBox3.Controls.Add(Me.TxtSessionstart)
        Me.GroupBox3.Location = New System.Drawing.Point(461, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(752, 120)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'Lblsessionend
        '
        Me.Lblsessionend.AutoSize = True
        Me.Lblsessionend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsessionend.Location = New System.Drawing.Point(377, 78)
        Me.Lblsessionend.Name = "Lblsessionend"
        Me.Lblsessionend.Size = New System.Drawing.Size(99, 20)
        Me.Lblsessionend.TabIndex = 21
        Me.Lblsessionend.Text = "Session End"
        '
        'Lblsessionstart
        '
        Me.Lblsessionstart.AutoSize = True
        Me.Lblsessionstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsessionstart.Location = New System.Drawing.Point(24, 78)
        Me.Lblsessionstart.Name = "Lblsessionstart"
        Me.Lblsessionstart.Size = New System.Drawing.Size(105, 20)
        Me.Lblsessionstart.TabIndex = 20
        Me.Lblsessionstart.Text = "Session Start"
        '
        'Txtsessionend
        '
        Me.Txtsessionend.Location = New System.Drawing.Point(494, 78)
        Me.Txtsessionend.Name = "Txtsessionend"
        Me.Txtsessionend.Size = New System.Drawing.Size(191, 20)
        Me.Txtsessionend.TabIndex = 3
        '
        'TxtSessionstart
        '
        Me.TxtSessionstart.Location = New System.Drawing.Point(161, 78)
        Me.TxtSessionstart.Name = "TxtSessionstart"
        Me.TxtSessionstart.Size = New System.Drawing.Size(191, 20)
        Me.TxtSessionstart.TabIndex = 2
        '
        'FrmStudentInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.CancelButton = Me.BtnAdd
        Me.ClientSize = New System.Drawing.Size(1264, 637)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaximizeBox = False
        Me.Name = "FrmStudentInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information"
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LblSRegNo As System.Windows.Forms.Label
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSRegNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtSName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSFatherName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtSContact As System.Windows.Forms.TextBox
    Friend WithEvents LblDeptNo As System.Windows.Forms.Label
    Friend WithEvents LblProgNo As System.Windows.Forms.Label
    Friend WithEvents LblSName As System.Windows.Forms.Label
    Friend WithEvents LblSFatherName As System.Windows.Forms.Label
    Friend WithEvents LblSAddress As System.Windows.Forms.Label
    Friend WithEvents LblSContact As System.Windows.Forms.Label
    Friend WithEvents TxtDeptNo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtProgNo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNicNo As System.Windows.Forms.TextBox
    Friend WithEvents Txtsessionend As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtSessionstart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lblsessionend As System.Windows.Forms.Label
    Friend WithEvents Lblsessionstart As System.Windows.Forms.Label
    Friend WithEvents LblNicNo As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
