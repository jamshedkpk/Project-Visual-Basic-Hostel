<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMessPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMessPayment))
        Me.LblAmountPaid = New System.Windows.Forms.Label()
        Me.TxtAmountPaid = New System.Windows.Forms.TextBox()
        Me.TxtPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.LblHostelNo = New System.Windows.Forms.Label()
        Me.LblSRegNo = New System.Windows.Forms.Label()
        Me.TxtSRegNo = New System.Windows.Forms.ComboBox()
        Me.LblPaymentId = New System.Windows.Forms.Label()
        Me.TxtHostelNo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtPaymentId = New System.Windows.Forms.TextBox()
        Me.LblPaymentDate = New System.Windows.Forms.Label()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.LblTxtDateTo = New System.Windows.Forms.Label()
        Me.TxtDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.LblDateFrom = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblAmountPaid
        '
        Me.LblAmountPaid.AutoSize = True
        Me.LblAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountPaid.Location = New System.Drawing.Point(39, 304)
        Me.LblAmountPaid.Name = "LblAmountPaid"
        Me.LblAmountPaid.Size = New System.Drawing.Size(108, 20)
        Me.LblAmountPaid.TabIndex = 19
        Me.LblAmountPaid.Text = "Amount Paid :"
        '
        'TxtAmountPaid
        '
        Me.TxtAmountPaid.BackColor = System.Drawing.Color.Pink
        Me.TxtAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmountPaid.Location = New System.Drawing.Point(179, 304)
        Me.TxtAmountPaid.MaxLength = 6
        Me.TxtAmountPaid.Name = "TxtAmountPaid"
        Me.TxtAmountPaid.Size = New System.Drawing.Size(160, 26)
        Me.TxtAmountPaid.TabIndex = 5
        '
        'TxtPaymentDate
        '
        Me.TxtPaymentDate.Location = New System.Drawing.Point(179, 181)
        Me.TxtPaymentDate.Name = "TxtPaymentDate"
        Me.TxtPaymentDate.Size = New System.Drawing.Size(160, 20)
        Me.TxtPaymentDate.TabIndex = 2
        '
        'LblHostelNo
        '
        Me.LblHostelNo.AutoSize = True
        Me.LblHostelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHostelNo.Location = New System.Drawing.Point(36, 86)
        Me.LblHostelNo.Name = "LblHostelNo"
        Me.LblHostelNo.Size = New System.Drawing.Size(83, 20)
        Me.LblHostelNo.TabIndex = 14
        Me.LblHostelNo.Text = "HostelNo :"
        '
        'LblSRegNo
        '
        Me.LblSRegNo.AutoSize = True
        Me.LblSRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSRegNo.Location = New System.Drawing.Point(36, 140)
        Me.LblSRegNo.Name = "LblSRegNo"
        Me.LblSRegNo.Size = New System.Drawing.Size(74, 20)
        Me.LblSRegNo.TabIndex = 16
        Me.LblSRegNo.Text = "Student :"
        '
        'TxtSRegNo
        '
        Me.TxtSRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtSRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSRegNo.FormattingEnabled = True
        Me.TxtSRegNo.Location = New System.Drawing.Point(182, 132)
        Me.TxtSRegNo.Name = "TxtSRegNo"
        Me.TxtSRegNo.Size = New System.Drawing.Size(160, 28)
        Me.TxtSRegNo.TabIndex = 1
        '
        'LblPaymentId
        '
        Me.LblPaymentId.AutoSize = True
        Me.LblPaymentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaymentId.Location = New System.Drawing.Point(36, 42)
        Me.LblPaymentId.Name = "LblPaymentId"
        Me.LblPaymentId.Size = New System.Drawing.Size(97, 20)
        Me.LblPaymentId.TabIndex = 1
        Me.LblPaymentId.Text = "Payment Id :"
        '
        'TxtHostelNo
        '
        Me.TxtHostelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtHostelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHostelNo.FormattingEnabled = True
        Me.TxtHostelNo.Location = New System.Drawing.Point(179, 83)
        Me.TxtHostelNo.Name = "TxtHostelNo"
        Me.TxtHostelNo.Size = New System.Drawing.Size(160, 28)
        Me.TxtHostelNo.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(16, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 74)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtPaymentId
        '
        Me.TxtPaymentId.BackColor = System.Drawing.Color.Pink
        Me.TxtPaymentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaymentId.Location = New System.Drawing.Point(179, 36)
        Me.TxtPaymentId.Name = "TxtPaymentId"
        Me.TxtPaymentId.ReadOnly = True
        Me.TxtPaymentId.Size = New System.Drawing.Size(160, 26)
        Me.TxtPaymentId.TabIndex = 1000
        '
        'LblPaymentDate
        '
        Me.LblPaymentDate.AutoSize = True
        Me.LblPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaymentDate.Location = New System.Drawing.Point(39, 181)
        Me.LblPaymentDate.Name = "LblPaymentDate"
        Me.LblPaymentDate.Size = New System.Drawing.Size(56, 20)
        Me.LblPaymentDate.TabIndex = 5
        Me.LblPaymentDate.Text = "Date  :"
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Location = New System.Drawing.Point(15, 19)
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        Me.Dg.Size = New System.Drawing.Size(736, 383)
        Me.Dg.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TxtDateTo)
        Me.GroupBox1.Controls.Add(Me.LblTxtDateTo)
        Me.GroupBox1.Controls.Add(Me.TxtDateFrom)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LblDateFrom)
        Me.GroupBox1.Controls.Add(Me.LblAmountPaid)
        Me.GroupBox1.Controls.Add(Me.TxtAmountPaid)
        Me.GroupBox1.Controls.Add(Me.TxtPaymentDate)
        Me.GroupBox1.Controls.Add(Me.LblHostelNo)
        Me.GroupBox1.Controls.Add(Me.LblSRegNo)
        Me.GroupBox1.Controls.Add(Me.TxtSRegNo)
        Me.GroupBox1.Controls.Add(Me.LblPaymentId)
        Me.GroupBox1.Controls.Add(Me.TxtHostelNo)
        Me.GroupBox1.Controls.Add(Me.TxtPaymentId)
        Me.GroupBox1.Controls.Add(Me.LblPaymentDate)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 462)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(182, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 74)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TxtDateTo
        '
        Me.TxtDateTo.Location = New System.Drawing.Point(182, 263)
        Me.TxtDateTo.Name = "TxtDateTo"
        Me.TxtDateTo.Size = New System.Drawing.Size(160, 20)
        Me.TxtDateTo.TabIndex = 4
        '
        'LblTxtDateTo
        '
        Me.LblTxtDateTo.AutoSize = True
        Me.LblTxtDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTxtDateTo.Location = New System.Drawing.Point(39, 263)
        Me.LblTxtDateTo.Name = "LblTxtDateTo"
        Me.LblTxtDateTo.Size = New System.Drawing.Size(78, 20)
        Me.LblTxtDateTo.TabIndex = 22
        Me.LblTxtDateTo.Text = "Date  To :"
        '
        'TxtDateFrom
        '
        Me.TxtDateFrom.Location = New System.Drawing.Point(179, 222)
        Me.TxtDateFrom.Name = "TxtDateFrom"
        Me.TxtDateFrom.Size = New System.Drawing.Size(160, 20)
        Me.TxtDateFrom.TabIndex = 3
        '
        'LblDateFrom
        '
        Me.LblDateFrom.AutoSize = True
        Me.LblDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateFrom.Location = New System.Drawing.Point(39, 222)
        Me.LblDateFrom.Name = "LblDateFrom"
        Me.LblDateFrom.Size = New System.Drawing.Size(93, 20)
        Me.LblDateFrom.TabIndex = 20
        Me.LblDateFrom.Text = "Date From :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1187, 500)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dg)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(399, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(773, 420)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(568, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 39)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Mess Payment Record"
        '
        'FrmMessPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1216, 525)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MaximizeBox = False
        Me.Name = "FrmMessPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mess Payment"
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblAmountPaid As System.Windows.Forms.Label
    Friend WithEvents TxtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents TxtPaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblHostelNo As System.Windows.Forms.Label
    Friend WithEvents LblSRegNo As System.Windows.Forms.Label
    Friend WithEvents TxtSRegNo As System.Windows.Forms.ComboBox
    Friend WithEvents LblPaymentId As System.Windows.Forms.Label
    Friend WithEvents TxtHostelNo As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtPaymentId As System.Windows.Forms.TextBox
    Friend WithEvents LblPaymentDate As System.Windows.Forms.Label
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblTxtDateTo As System.Windows.Forms.Label
    Friend WithEvents TxtDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblDateFrom As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
