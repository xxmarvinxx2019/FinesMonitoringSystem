<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Me.sidtext = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.sfnametext = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ssectiontext = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Course = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CcsitFinesDataSet = New CCSITFineMonitoringSystem.ccsitFinesDataSet()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.ccombo = New System.Windows.Forms.ComboBox()
        Me.yearcombo = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.StudentTableAdapter = New CCSITFineMonitoringSystem.ccsitFinesDataSetTableAdapters.studentTableAdapter()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CcsitFinesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sidtext
        '
        Me.sidtext.BackColor = System.Drawing.Color.White
        Me.sidtext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sidtext.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.sidtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sidtext.HintForeColor = System.Drawing.Color.Empty
        Me.sidtext.HintText = "ID Number"
        Me.sidtext.isPassword = False
        Me.sidtext.LineFocusedColor = System.Drawing.Color.Blue
        Me.sidtext.LineIdleColor = System.Drawing.Color.Gray
        Me.sidtext.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.sidtext.LineThickness = 3
        Me.sidtext.Location = New System.Drawing.Point(296, 133)
        Me.sidtext.Margin = New System.Windows.Forms.Padding(4)
        Me.sidtext.Name = "sidtext"
        Me.sidtext.Size = New System.Drawing.Size(149, 33)
        Me.sidtext.TabIndex = 0
        Me.sidtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'sfnametext
        '
        Me.sfnametext.BackColor = System.Drawing.Color.White
        Me.sfnametext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sfnametext.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.sfnametext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sfnametext.HintForeColor = System.Drawing.Color.Empty
        Me.sfnametext.HintText = "Full Name"
        Me.sfnametext.isPassword = False
        Me.sfnametext.LineFocusedColor = System.Drawing.Color.Blue
        Me.sfnametext.LineIdleColor = System.Drawing.Color.Gray
        Me.sfnametext.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.sfnametext.LineThickness = 3
        Me.sfnametext.Location = New System.Drawing.Point(481, 133)
        Me.sfnametext.Margin = New System.Windows.Forms.Padding(4)
        Me.sfnametext.Name = "sfnametext"
        Me.sfnametext.Size = New System.Drawing.Size(290, 33)
        Me.sfnametext.TabIndex = 1
        Me.sfnametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ssectiontext
        '
        Me.ssectiontext.BackColor = System.Drawing.Color.White
        Me.ssectiontext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ssectiontext.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.ssectiontext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ssectiontext.HintForeColor = System.Drawing.Color.Empty
        Me.ssectiontext.HintText = "Section"
        Me.ssectiontext.isPassword = False
        Me.ssectiontext.LineFocusedColor = System.Drawing.Color.Blue
        Me.ssectiontext.LineIdleColor = System.Drawing.Color.Gray
        Me.ssectiontext.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.ssectiontext.LineThickness = 3
        Me.ssectiontext.Location = New System.Drawing.Point(296, 294)
        Me.ssectiontext.Margin = New System.Windows.Forms.Padding(4)
        Me.ssectiontext.Name = "ssectiontext"
        Me.ssectiontext.Size = New System.Drawing.Size(149, 33)
        Me.ssectiontext.TabIndex = 2
        Me.ssectiontext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Course
        '
        Me.Course.AutoSize = True
        Me.Course.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Course.Location = New System.Drawing.Point(293, 214)
        Me.Course.Name = "Course"
        Me.Course.Size = New System.Drawing.Size(49, 17)
        Me.Course.TabIndex = 12
        Me.Course.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(604, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Year Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(72, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 32)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Students Infromation"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(26, 56)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(998, 10)
        Me.BunifuSeparator1.TabIndex = 16
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.CcsitFinesDataSet
        '
        'CcsitFinesDataSet
        '
        Me.CcsitFinesDataSet.DataSetName = "ccsitFinesDataSet"
        Me.CcsitFinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'ccombo
        '
        Me.ccombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccombo.FormattingEnabled = True
        Me.ccombo.Items.AddRange(New Object() {"BS in Information Technology Major in Programming", "BS in Information Technology Major in Networking"})
        Me.ccombo.Location = New System.Drawing.Point(296, 234)
        Me.ccombo.Name = "ccombo"
        Me.ccombo.Size = New System.Drawing.Size(475, 24)
        Me.ccombo.TabIndex = 24
        '
        'yearcombo
        '
        Me.yearcombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearcombo.FormattingEnabled = True
        Me.yearcombo.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        Me.yearcombo.Location = New System.Drawing.Point(607, 306)
        Me.yearcombo.Name = "yearcombo"
        Me.yearcombo.Size = New System.Drawing.Size(164, 24)
        Me.yearcombo.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CCSITFineMonitoringSystem.My.Resources.Resources.icons8_student_male_64
        Me.PictureBox1.Location = New System.Drawing.Point(26, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 5
        Me.BunifuFlatButton5.ButtonText = "Clear"
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
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(296, 464)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.Yellow
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(188, 48)
        Me.BunifuFlatButton5.TabIndex = 36
        Me.BunifuFlatButton5.Text = "Clear"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 5
        Me.BunifuFlatButton4.ButtonText = "Update"
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
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(583, 384)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.Yellow
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(188, 48)
        Me.BunifuFlatButton4.TabIndex = 35
        Me.BunifuFlatButton4.Text = "Update"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 5
        Me.BunifuFlatButton3.ButtonText = "Save"
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
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(296, 384)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.DodgerBlue
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Yellow
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(188, 48)
        Me.BunifuFlatButton3.TabIndex = 34
        Me.BunifuFlatButton3.Text = "Save"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1050, 650)
        Me.ShapeContainer1.TabIndex = 47
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Silver
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.Location = New System.Drawing.Point(240, 107)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(585, 453)
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuFlatButton5)
        Me.Controls.Add(Me.BunifuFlatButton4)
        Me.Controls.Add(Me.BunifuFlatButton3)
        Me.Controls.Add(Me.yearcombo)
        Me.Controls.Add(Me.ccombo)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Course)
        Me.Controls.Add(Me.ssectiontext)
        Me.Controls.Add(Me.sfnametext)
        Me.Controls.Add(Me.sidtext)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(1050, 650)
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CcsitFinesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sidtext As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents sfnametext As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ssectiontext As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Course As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents yearcombo As System.Windows.Forms.ComboBox
    Friend WithEvents ccombo As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CcsitFinesDataSet As CCSITFineMonitoringSystem.ccsitFinesDataSet
    Friend WithEvents StudentTableAdapter As CCSITFineMonitoringSystem.ccsitFinesDataSetTableAdapters.studentTableAdapter
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape

End Class
