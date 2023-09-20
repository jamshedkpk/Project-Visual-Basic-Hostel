<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoomAllocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRoomAllocation))
        Me.LblANo = New System.Windows.Forms.Label()
        Me.LblSRegNo = New System.Windows.Forms.Label()
        Me.TxtANo = New System.Windows.Forms.TextBox()
        Me.TxtSRegNo = New System.Windows.Forms.TextBox()
        Me.LblDateTo = New System.Windows.Forms.Label()
        Me.LblDateFrom = New System.Windows.Forms.Label()
        Me.TxtHostelNo = New System.Windows.Forms.ComboBox()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.TxtDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.LblHostelNo = New System.Windows.Forms.Label()
        Me.LblRoomNo = New System.Windows.Forms.Label()
        Me.TxtRoomNo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dg2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblANo
        '
        resources.ApplyResources(Me.LblANo, "LblANo")
        Me.LblANo.Name = "LblANo"
        '
        'LblSRegNo
        '
        resources.ApplyResources(Me.LblSRegNo, "LblSRegNo")
        Me.LblSRegNo.Name = "LblSRegNo"
        '
        'TxtANo
        '
        Me.TxtANo.BackColor = System.Drawing.Color.Pink
        resources.ApplyResources(Me.TxtANo, "TxtANo")
        Me.TxtANo.Name = "TxtANo"
        Me.TxtANo.ReadOnly = True
        '
        'TxtSRegNo
        '
        Me.TxtSRegNo.BackColor = System.Drawing.Color.Pink
        resources.ApplyResources(Me.TxtSRegNo, "TxtSRegNo")
        Me.TxtSRegNo.Name = "TxtSRegNo"
        '
        'LblDateTo
        '
        resources.ApplyResources(Me.LblDateTo, "LblDateTo")
        Me.LblDateTo.Name = "LblDateTo"
        '
        'LblDateFrom
        '
        resources.ApplyResources(Me.LblDateFrom, "LblDateFrom")
        Me.LblDateFrom.Name = "LblDateFrom"
        '
        'TxtHostelNo
        '
        Me.TxtHostelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.TxtHostelNo, "TxtHostelNo")
        Me.TxtHostelNo.FormattingEnabled = True
        Me.TxtHostelNo.Name = "TxtHostelNo"
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.AllowUserToDeleteRows = False
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.Dg, "Dg")
        Me.Dg.Name = "Dg"
        Me.Dg.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.TxtDateTo)
        Me.GroupBox1.Controls.Add(Me.TxtDateFrom)
        Me.GroupBox1.Controls.Add(Me.LblHostelNo)
        Me.GroupBox1.Controls.Add(Me.LblRoomNo)
        Me.GroupBox1.Controls.Add(Me.TxtRoomNo)
        Me.GroupBox1.Controls.Add(Me.LblANo)
        Me.GroupBox1.Controls.Add(Me.LblSRegNo)
        Me.GroupBox1.Controls.Add(Me.TxtHostelNo)
        Me.GroupBox1.Controls.Add(Me.TxtANo)
        Me.GroupBox1.Controls.Add(Me.TxtSRegNo)
        Me.GroupBox1.Controls.Add(Me.LblDateFrom)
        Me.GroupBox1.Controls.Add(Me.LblDateTo)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        resources.ApplyResources(Me.BtnAdd, "BtnAdd")
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'TxtDateTo
        '
        resources.ApplyResources(Me.TxtDateTo, "TxtDateTo")
        Me.TxtDateTo.Name = "TxtDateTo"
        '
        'TxtDateFrom
        '
        resources.ApplyResources(Me.TxtDateFrom, "TxtDateFrom")
        Me.TxtDateFrom.Name = "TxtDateFrom"
        '
        'LblHostelNo
        '
        resources.ApplyResources(Me.LblHostelNo, "LblHostelNo")
        Me.LblHostelNo.Name = "LblHostelNo"
        '
        'LblRoomNo
        '
        resources.ApplyResources(Me.LblRoomNo, "LblRoomNo")
        Me.LblRoomNo.Name = "LblRoomNo"
        '
        'TxtRoomNo
        '
        Me.TxtRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.TxtRoomNo, "TxtRoomNo")
        Me.TxtRoomNo.FormattingEnabled = True
        Me.TxtRoomNo.Name = "TxtRoomNo"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Dg2
        '
        Me.Dg2.AllowUserToAddRows = False
        Me.Dg2.AllowUserToDeleteRows = False
        Me.Dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.Dg2, "Dg2")
        Me.Dg2.Name = "Dg2"
        Me.Dg2.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Dg)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Dg2)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'FrmRoomAllocation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaximizeBox = False
        Me.Name = "FrmRoomAllocation"
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblANo As System.Windows.Forms.Label
    Friend WithEvents LblSRegNo As System.Windows.Forms.Label
    Friend WithEvents TxtANo As System.Windows.Forms.TextBox
    Friend WithEvents TxtSRegNo As System.Windows.Forms.TextBox
    Friend WithEvents LblDateTo As System.Windows.Forms.Label
    Friend WithEvents LblDateFrom As System.Windows.Forms.Label
    Friend WithEvents TxtHostelNo As System.Windows.Forms.ComboBox
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblHostelNo As System.Windows.Forms.Label
    Friend WithEvents LblRoomNo As System.Windows.Forms.Label
    Friend WithEvents TxtRoomNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dg2 As System.Windows.Forms.DataGridView
    Friend WithEvents TxtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
