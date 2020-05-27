<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl4
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl4))
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuCustomDataGrid2 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.IdnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogoutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CcsitFinesDataSet2 = New CCSITFineMonitoringSystem.ccsitFinesDataSet2()
        Me.AttendanceTableAdapter = New CCSITFineMonitoringSystem.ccsitFinesDataSet2TableAdapters.attendanceTableAdapter()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.semtext1 = New System.Windows.Forms.ComboBox()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCheckbox1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BunifuCheckbox2 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.BunifuCustomDataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CcsitFinesDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(26, 56)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(998, 10)
        Me.BunifuSeparator1.TabIndex = 20
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(72, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 32)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Attendance"
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox2.BorderThickness = 1
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(50, 101)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(132, 30)
        Me.BunifuMetroTextbox2.TabIndex = 29
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(47, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Section:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(397, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Course:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(227, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Year Level:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Items.AddRange(New Object() {"1st Assembly Meeting"})
        Me.ComboBox1.Location = New System.Drawing.Point(50, 183)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(310, 30)
        Me.ComboBox1.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(47, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Event:"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.White
        Me.ComboBox2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.IntegralHeight = False
        Me.ComboBox2.Items.AddRange(New Object() {"BS in Information Technology Major in Programming", "BS in Information Technology Major in Networking"})
        Me.ComboBox2.Location = New System.Drawing.Point(400, 101)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(609, 30)
        Me.ComboBox2.TabIndex = 42
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuCustomDataGrid2
        '
        Me.BunifuCustomDataGrid2.AllowUserToAddRows = False
        Me.BunifuCustomDataGrid2.AllowUserToDeleteRows = False
        Me.BunifuCustomDataGrid2.AllowUserToResizeColumns = False
        Me.BunifuCustomDataGrid2.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomDataGrid2.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.BunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid2.ColumnHeadersHeight = 50
        Me.BunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BunifuCustomDataGrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdnumDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.LoginsDataGridViewTextBoxColumn, Me.LogoutDataGridViewTextBoxColumn})
        Me.BunifuCustomDataGrid2.DataSource = Me.AttendanceBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuCustomDataGrid2.DefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuCustomDataGrid2.DoubleBuffered = True
        Me.BunifuCustomDataGrid2.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid2.GridColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid2.Location = New System.Drawing.Point(50, 331)
        Me.BunifuCustomDataGrid2.Name = "BunifuCustomDataGrid2"
        Me.BunifuCustomDataGrid2.ReadOnly = True
        Me.BunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BunifuCustomDataGrid2.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BunifuCustomDataGrid2.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.BunifuCustomDataGrid2.RowTemplate.DividerHeight = 1
        Me.BunifuCustomDataGrid2.RowTemplate.Height = 30
        Me.BunifuCustomDataGrid2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuCustomDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuCustomDataGrid2.Size = New System.Drawing.Size(959, 291)
        Me.BunifuCustomDataGrid2.TabIndex = 53
        '
        'IdnumDataGridViewTextBoxColumn
        '
        Me.IdnumDataGridViewTextBoxColumn.DataPropertyName = "Idnum"
        Me.IdnumDataGridViewTextBoxColumn.HeaderText = "ID Number"
        Me.IdnumDataGridViewTextBoxColumn.Name = "IdnumDataGridViewTextBoxColumn"
        Me.IdnumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoginsDataGridViewTextBoxColumn
        '
        Me.LoginsDataGridViewTextBoxColumn.DataPropertyName = "logins"
        Me.LoginsDataGridViewTextBoxColumn.HeaderText = "Login"
        Me.LoginsDataGridViewTextBoxColumn.Name = "LoginsDataGridViewTextBoxColumn"
        Me.LoginsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LogoutDataGridViewTextBoxColumn
        '
        Me.LogoutDataGridViewTextBoxColumn.DataPropertyName = "logout"
        Me.LogoutDataGridViewTextBoxColumn.HeaderText = "Logout"
        Me.LogoutDataGridViewTextBoxColumn.Name = "LogoutDataGridViewTextBoxColumn"
        Me.LogoutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttendanceBindingSource
        '
        Me.AttendanceBindingSource.DataMember = "attendance"
        Me.AttendanceBindingSource.DataSource = Me.CcsitFinesDataSet2
        '
        'CcsitFinesDataSet2
        '
        Me.CcsitFinesDataSet2.DataSetName = "ccsitFinesDataSet2"
        Me.CcsitFinesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendanceTableAdapter
        '
        Me.AttendanceTableAdapter.ClearBeforeFill = True
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(26, 232)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(998, 10)
        Me.BunifuSeparator2.TabIndex = 54
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CCSITFineMonitoringSystem.My.Resources.Resources.icons8_study_64
        Me.PictureBox1.Location = New System.Drawing.Point(26, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 5
        Me.BunifuFlatButton2.ButtonText = "Save"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0.0R
        Me.BunifuFlatButton2.IconVisible = False
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(429, 267)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Yellow
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(157, 48)
        Me.BunifuFlatButton2.TabIndex = 35
        Me.BunifuFlatButton2.Text = "Save"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 5
        Me.BunifuFlatButton1.ButtonText = "Search"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = False
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(680, 165)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Yellow
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(128, 48)
        Me.BunifuFlatButton1.TabIndex = 33
        Me.BunifuFlatButton1.Text = "Search"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'semtext1
        '
        Me.semtext1.BackColor = System.Drawing.Color.White
        Me.semtext1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semtext1.FormattingEnabled = True
        Me.semtext1.IntegralHeight = False
        Me.semtext1.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        Me.semtext1.Location = New System.Drawing.Point(230, 101)
        Me.semtext1.Name = "semtext1"
        Me.semtext1.Size = New System.Drawing.Size(130, 30)
        Me.semtext1.TabIndex = 55
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 5
        Me.BunifuFlatButton3.ButtonText = "Clear"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0.0R
        Me.BunifuFlatButton3.IconVisible = False
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(881, 165)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Yellow
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(128, 48)
        Me.BunifuFlatButton3.TabIndex = 56
        Me.BunifuFlatButton3.Text = "Clear"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(50, 283)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(132, 32)
        Me.BunifuMetroTextbox1.TabIndex = 59
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCheckbox1
        '
        Me.BunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox1.Checked = False
        Me.BunifuCheckbox1.CheckedOnColor = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuCheckbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox1.Location = New System.Drawing.Point(20, 24)
        Me.BunifuCheckbox1.Name = "BunifuCheckbox1"
        Me.BunifuCheckbox1.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox1.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(46, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 17)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Login"
        '
        'BunifuCheckbox2
        '
        Me.BunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox2.Checked = False
        Me.BunifuCheckbox2.CheckedOnColor = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuCheckbox2.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox2.Location = New System.Drawing.Point(94, 24)
        Me.BunifuCheckbox2.Name = "BunifuCheckbox2"
        Me.BunifuCheckbox2.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox2.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(120, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Logout"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(47, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "ID Number:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.BunifuCheckbox2)
        Me.GroupBox1.Controls.Add(Me.BunifuCheckbox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(189, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 58)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Attendance"
        '
        'UserControl4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.BunifuFlatButton3)
        Me.Controls.Add(Me.semtext1)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuCustomDataGrid2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuMetroTextbox2)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "UserControl4"
        Me.Size = New System.Drawing.Size(1050, 650)
        CType(Me.BunifuCustomDataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CcsitFinesDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCustomDataGrid2 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents AttendanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CcsitFinesDataSet2 As CCSITFineMonitoringSystem.ccsitFinesDataSet2
    Friend WithEvents AttendanceTableAdapter As CCSITFineMonitoringSystem.ccsitFinesDataSet2TableAdapters.attendanceTableAdapter
    Friend WithEvents IdnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoginsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogoutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents semtext1 As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BunifuCheckbox2 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BunifuCheckbox1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
