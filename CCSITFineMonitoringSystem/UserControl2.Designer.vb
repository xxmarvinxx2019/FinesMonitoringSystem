<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl2))
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.eventtext = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.finestext = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.semtext = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.daytext = New System.Windows.Forms.ComboBox()
        Me.monthtext = New System.Windows.Forms.ComboBox()
        Me.yeartext = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomDataGrid2 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.EventstBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CcsitFinesDataSet8 = New CCSITFineMonitoringSystem.ccsitFinesDataSet8()
        Me.EventstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CcsitFinesDataSet1 = New CCSITFineMonitoringSystem.ccsitFinesDataSet1()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.EventstTableAdapter = New CCSITFineMonitoringSystem.ccsitFinesDataSet1TableAdapters.eventstTableAdapter()
        Me.EventstTableAdapter1 = New CCSITFineMonitoringSystem.ccsitFinesDataSet8TableAdapters.eventstTableAdapter()
        Me.EventdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateofevent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monthofevent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearofevent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventfinesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BunifuCustomDataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventstBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CcsitFinesDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CcsitFinesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BunifuSeparator1.TabIndex = 18
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
        Me.Label3.Size = New System.Drawing.Size(351, 32)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Events and Happening in CCSIT"
        '
        'eventtext
        '
        Me.eventtext.BorderColorFocused = System.Drawing.Color.Blue
        Me.eventtext.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.eventtext.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.eventtext.BorderThickness = 1
        Me.eventtext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.eventtext.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.eventtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.eventtext.isPassword = False
        Me.eventtext.Location = New System.Drawing.Point(45, 97)
        Me.eventtext.Margin = New System.Windows.Forms.Padding(4)
        Me.eventtext.Name = "eventtext"
        Me.eventtext.Size = New System.Drawing.Size(370, 30)
        Me.eventtext.TabIndex = 19
        Me.eventtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(42, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Events:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(435, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Date of Event:"
        '
        'finestext
        '
        Me.finestext.BorderColorFocused = System.Drawing.Color.Blue
        Me.finestext.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.finestext.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.finestext.BorderThickness = 1
        Me.finestext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.finestext.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.finestext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.finestext.isPassword = False
        Me.finestext.Location = New System.Drawing.Point(45, 180)
        Me.finestext.Margin = New System.Windows.Forms.Padding(4)
        Me.finestext.Name = "finestext"
        Me.finestext.Size = New System.Drawing.Size(132, 30)
        Me.finestext.TabIndex = 28
        Me.finestext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(42, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Event Fines:"
        '
        'semtext
        '
        Me.semtext.BackColor = System.Drawing.Color.White
        Me.semtext.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semtext.FormattingEnabled = True
        Me.semtext.IntegralHeight = False
        Me.semtext.Items.AddRange(New Object() {"1st", "2nd"})
        Me.semtext.Location = New System.Drawing.Point(864, 97)
        Me.semtext.Name = "semtext"
        Me.semtext.Size = New System.Drawing.Size(153, 30)
        Me.semtext.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(861, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Semester:"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.ComboBox1.Location = New System.Drawing.Point(533, 259)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(153, 30)
        Me.ComboBox1.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(530, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Year:"
        '
        'daytext
        '
        Me.daytext.BackColor = System.Drawing.Color.White
        Me.daytext.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daytext.FormattingEnabled = True
        Me.daytext.IntegralHeight = False
        Me.daytext.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.daytext.Location = New System.Drawing.Point(438, 97)
        Me.daytext.Name = "daytext"
        Me.daytext.Size = New System.Drawing.Size(74, 30)
        Me.daytext.TabIndex = 49
        Me.daytext.Text = "Day"
        '
        'monthtext
        '
        Me.monthtext.BackColor = System.Drawing.Color.White
        Me.monthtext.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthtext.FormattingEnabled = True
        Me.monthtext.IntegralHeight = False
        Me.monthtext.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.monthtext.Location = New System.Drawing.Point(533, 97)
        Me.monthtext.Name = "monthtext"
        Me.monthtext.Size = New System.Drawing.Size(176, 30)
        Me.monthtext.TabIndex = 50
        Me.monthtext.Text = "Month"
        '
        'yeartext
        '
        Me.yeartext.BackColor = System.Drawing.Color.White
        Me.yeartext.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yeartext.FormattingEnabled = True
        Me.yeartext.IntegralHeight = False
        Me.yeartext.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.yeartext.Location = New System.Drawing.Point(727, 97)
        Me.yeartext.Name = "yeartext"
        Me.yeartext.Size = New System.Drawing.Size(79, 30)
        Me.yeartext.TabIndex = 51
        Me.yeartext.Text = "Year"
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
        Me.BunifuCustomDataGrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventdayDataGridViewTextBoxColumn, Me.dateofevent, Me.monthofevent, Me.yearofevent, Me.sem, Me.EventfinesDataGridViewTextBoxColumn})
        Me.BunifuCustomDataGrid2.DataSource = Me.EventstBindingSource1
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
        Me.BunifuCustomDataGrid2.Location = New System.Drawing.Point(41, 306)
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
        Me.BunifuCustomDataGrid2.Size = New System.Drawing.Size(976, 273)
        Me.BunifuCustomDataGrid2.TabIndex = 52
        '
        'EventstBindingSource1
        '
        Me.EventstBindingSource1.DataMember = "eventst"
        Me.EventstBindingSource1.DataSource = Me.CcsitFinesDataSet8
        '
        'CcsitFinesDataSet8
        '
        Me.CcsitFinesDataSet8.DataSetName = "ccsitFinesDataSet8"
        Me.CcsitFinesDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EventstBindingSource
        '
        Me.EventstBindingSource.DataMember = "eventst"
        Me.EventstBindingSource.DataSource = Me.CcsitFinesDataSet1
        '
        'CcsitFinesDataSet1
        '
        Me.CcsitFinesDataSet1.DataSetName = "ccsitFinesDataSet1"
        Me.CcsitFinesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(26, 227)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(998, 10)
        Me.BunifuSeparator2.TabIndex = 53
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 5
        Me.BunifuFlatButton2.ButtonText = "Delete"
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
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(799, 180)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Yellow
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(218, 40)
        Me.BunifuFlatButton2.TabIndex = 48
        Me.BunifuFlatButton2.Text = "Delete"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CCSITFineMonitoringSystem.My.Resources.Resources.icons8_schedule_64
        Me.PictureBox1.Location = New System.Drawing.Point(26, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 5
        Me.BunifuFlatButton1.ButtonText = "Add Event"
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(533, 180)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Yellow
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(218, 40)
        Me.BunifuFlatButton1.TabIndex = 21
        Me.BunifuFlatButton1.Text = "Add Event"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 5
        Me.BunifuFlatButton3.ButtonText = "Search"
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
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(710, 259)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Yellow
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(134, 30)
        Me.BunifuFlatButton3.TabIndex = 54
        Me.BunifuFlatButton3.Text = "Search"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 5
        Me.BunifuFlatButton4.ButtonText = "Clear"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0.0R
        Me.BunifuFlatButton4.IconVisible = False
        Me.BunifuFlatButton4.IconZoom = 90.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(883, 259)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.Yellow
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(134, 30)
        Me.BunifuFlatButton4.TabIndex = 55
        Me.BunifuFlatButton4.Text = "Clear"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 5
        Me.BunifuFlatButton5.ButtonText = "Add student"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0.0R
        Me.BunifuFlatButton5.IconVisible = False
        Me.BunifuFlatButton5.IconZoom = 90.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(799, 595)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.Yellow
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(218, 40)
        Me.BunifuFlatButton5.TabIndex = 56
        Me.BunifuFlatButton5.Text = "Add student"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'EventstTableAdapter
        '
        Me.EventstTableAdapter.ClearBeforeFill = True
        '
        'EventstTableAdapter1
        '
        Me.EventstTableAdapter1.ClearBeforeFill = True
        '
        'EventdayDataGridViewTextBoxColumn
        '
        Me.EventdayDataGridViewTextBoxColumn.DataPropertyName = "eventday"
        Me.EventdayDataGridViewTextBoxColumn.HeaderText = "Event"
        Me.EventdayDataGridViewTextBoxColumn.Name = "EventdayDataGridViewTextBoxColumn"
        Me.EventdayDataGridViewTextBoxColumn.ReadOnly = True
        Me.EventdayDataGridViewTextBoxColumn.Width = 300
        '
        'dateofevent
        '
        Me.dateofevent.DataPropertyName = "dateofevent"
        Me.dateofevent.HeaderText = "Day"
        Me.dateofevent.Name = "dateofevent"
        Me.dateofevent.ReadOnly = True
        '
        'monthofevent
        '
        Me.monthofevent.DataPropertyName = "monthofevent"
        Me.monthofevent.HeaderText = "Month"
        Me.monthofevent.Name = "monthofevent"
        Me.monthofevent.ReadOnly = True
        Me.monthofevent.Width = 200
        '
        'yearofevent
        '
        Me.yearofevent.DataPropertyName = "yearofevent"
        Me.yearofevent.HeaderText = "Year"
        Me.yearofevent.Name = "yearofevent"
        Me.yearofevent.ReadOnly = True
        '
        'sem
        '
        Me.sem.DataPropertyName = "sem"
        Me.sem.HeaderText = "Sem"
        Me.sem.Name = "sem"
        Me.sem.ReadOnly = True
        Me.sem.Width = 80
        '
        'EventfinesDataGridViewTextBoxColumn
        '
        Me.EventfinesDataGridViewTextBoxColumn.DataPropertyName = "eventfines"
        Me.EventfinesDataGridViewTextBoxColumn.HeaderText = "Fines"
        Me.EventfinesDataGridViewTextBoxColumn.Name = "EventfinesDataGridViewTextBoxColumn"
        Me.EventfinesDataGridViewTextBoxColumn.ReadOnly = True
        Me.EventfinesDataGridViewTextBoxColumn.Width = 195
        '
        'UserControl2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BunifuFlatButton5)
        Me.Controls.Add(Me.BunifuFlatButton4)
        Me.Controls.Add(Me.BunifuFlatButton3)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuCustomDataGrid2)
        Me.Controls.Add(Me.yeartext)
        Me.Controls.Add(Me.monthtext)
        Me.Controls.Add(Me.daytext)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.semtext)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.finestext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.eventtext)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "UserControl2"
        Me.Size = New System.Drawing.Size(1050, 650)
        CType(Me.BunifuCustomDataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventstBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CcsitFinesDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CcsitFinesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents eventtext As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents finestext As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents semtext As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents yeartext As System.Windows.Forms.ComboBox
    Friend WithEvents monthtext As System.Windows.Forms.ComboBox
    Friend WithEvents daytext As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuCustomDataGrid2 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents EventstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CcsitFinesDataSet1 As CCSITFineMonitoringSystem.ccsitFinesDataSet1
    Friend WithEvents EventstTableAdapter As CCSITFineMonitoringSystem.ccsitFinesDataSet1TableAdapters.eventstTableAdapter
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents EventstBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CcsitFinesDataSet8 As CCSITFineMonitoringSystem.ccsitFinesDataSet8
    Friend WithEvents EventstTableAdapter1 As CCSITFineMonitoringSystem.ccsitFinesDataSet8TableAdapters.eventstTableAdapter
    Friend WithEvents EventdayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateofevent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monthofevent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yearofevent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventfinesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
