<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCommune
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.DatagridVille = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnModifier = New FontAwesome.Sharp.IconButton()
        Me.LabelProd = New System.Windows.Forms.Label()
        Me.btnAjouter = New FontAwesome.Sharp.IconButton()
        Me.btnReset = New FontAwesome.Sharp.IconButton()
        Me.boxVille = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btnDeleteC = New FontAwesome.Sharp.IconButton()
        Me.boxVilleNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DatagridCom = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnModicierC = New FontAwesome.Sharp.IconButton()
        Me.comboVille = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxCommune = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAjouterC = New FontAwesome.Sharp.IconButton()
        Me.btnResetC = New FontAwesome.Sharp.IconButton()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.DatagridVille, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.DatagridCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 12
        Me.Guna2GroupBox1.Controls.Add(Me.IconButton2)
        Me.Guna2GroupBox1.Controls.Add(Me.btnDelete)
        Me.Guna2GroupBox1.Controls.Add(Me.DatagridVille)
        Me.Guna2GroupBox1.Controls.Add(Me.btnModifier)
        Me.Guna2GroupBox1.Controls.Add(Me.LabelProd)
        Me.Guna2GroupBox1.Controls.Add(Me.btnAjouter)
        Me.Guna2GroupBox1.Controls.Add(Me.btnReset)
        Me.Guna2GroupBox1.Controls.Add(Me.boxVille)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(35, 69)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(506, 460)
        Me.Guna2GroupBox1.TabIndex = 10
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Redo
        Me.IconButton2.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 35
        Me.IconButton2.Location = New System.Drawing.Point(411, 142)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(53, 45)
        Me.IconButton2.TabIndex = 19
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        Me.IconButton2.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnDelete.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.IconSize = 40
        Me.btnDelete.Location = New System.Drawing.Point(241, 142)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(137, 45)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'DatagridVille
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DatagridVille.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridVille.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridVille.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridVille.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DatagridVille.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridVille.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridVille.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridVille.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridVille.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridVille.DefaultCellStyle = DataGridViewCellStyle3
        Me.DatagridVille.EnableHeadersVisualStyles = False
        Me.DatagridVille.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridVille.Location = New System.Drawing.Point(20, 245)
        Me.DatagridVille.Name = "DatagridVille"
        Me.DatagridVille.RowHeadersVisible = False
        Me.DatagridVille.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridVille.Size = New System.Drawing.Size(462, 199)
        Me.DatagridVille.TabIndex = 13
        Me.DatagridVille.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DatagridVille.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DatagridVille.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DatagridVille.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DatagridVille.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DatagridVille.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DatagridVille.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DatagridVille.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridVille.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridVille.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DatagridVille.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DatagridVille.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DatagridVille.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DatagridVille.ThemeStyle.HeaderStyle.Height = 20
        Me.DatagridVille.ThemeStyle.ReadOnly = False
        Me.DatagridVille.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DatagridVille.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridVille.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DatagridVille.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DatagridVille.ThemeStyle.RowsStyle.Height = 22
        Me.DatagridVille.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridVille.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModifier.FlatAppearance.BorderSize = 0
        Me.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnModifier.ForeColor = System.Drawing.Color.White
        Me.btnModifier.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.btnModifier.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModifier.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnModifier.IconSize = 40
        Me.btnModifier.Location = New System.Drawing.Point(81, 142)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(137, 45)
        Me.btnModifier.TabIndex = 12
        Me.btnModifier.Text = "MODIFIER"
        Me.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifier.UseVisualStyleBackColor = False
        Me.btnModifier.Visible = False
        '
        'LabelProd
        '
        Me.LabelProd.AutoSize = True
        Me.LabelProd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelProd.ForeColor = System.Drawing.Color.Black
        Me.LabelProd.Location = New System.Drawing.Point(47, 64)
        Me.LabelProd.Name = "LabelProd"
        Me.LabelProd.Size = New System.Drawing.Size(35, 15)
        Me.LabelProd.TabIndex = 5
        Me.LabelProd.Text = "VILLE"
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAjouter.FlatAppearance.BorderSize = 0
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAjouter.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAjouter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAjouter.IconSize = 40
        Me.btnAjouter.Location = New System.Drawing.Point(81, 142)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(137, 45)
        Me.btnAjouter.TabIndex = 2
        Me.btnAjouter.Text = "AJOUTER"
        Me.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.IconChar = FontAwesome.Sharp.IconChar.Reply
        Me.btnReset.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReset.IconSize = 40
        Me.btnReset.Location = New System.Drawing.Point(241, 142)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(123, 45)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'boxVille
        '
        Me.boxVille.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxVille.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxVille.DefaultText = ""
        Me.boxVille.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxVille.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxVille.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxVille.DisabledState.Parent = Me.boxVille
        Me.boxVille.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxVille.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxVille.FocusedState.Parent = Me.boxVille
        Me.boxVille.ForeColor = System.Drawing.Color.Black
        Me.boxVille.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxVille.HoverState.Parent = Me.boxVille
        Me.boxVille.Location = New System.Drawing.Point(108, 43)
        Me.boxVille.Name = "boxVille"
        Me.boxVille.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxVille.PlaceholderText = ""
        Me.boxVille.SelectedText = ""
        Me.boxVille.ShadowDecoration.Parent = Me.boxVille
        Me.boxVille.Size = New System.Drawing.Size(297, 36)
        Me.boxVille.TabIndex = 3
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox2.BorderRadius = 12
        Me.Guna2GroupBox2.Controls.Add(Me.IconButton1)
        Me.Guna2GroupBox2.Controls.Add(Me.btnDeleteC)
        Me.Guna2GroupBox2.Controls.Add(Me.boxVilleNum)
        Me.Guna2GroupBox2.Controls.Add(Me.DatagridCom)
        Me.Guna2GroupBox2.Controls.Add(Me.btnModicierC)
        Me.Guna2GroupBox2.Controls.Add(Me.comboVille)
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.Controls.Add(Me.boxCommune)
        Me.Guna2GroupBox2.Controls.Add(Me.Label5)
        Me.Guna2GroupBox2.Controls.Add(Me.btnAjouterC)
        Me.Guna2GroupBox2.Controls.Add(Me.btnResetC)
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(650, 62)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(531, 460)
        Me.Guna2GroupBox2.TabIndex = 13
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Redo
        Me.IconButton1.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 35
        Me.IconButton1.Location = New System.Drawing.Point(437, 149)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(53, 45)
        Me.IconButton1.TabIndex = 20
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        Me.IconButton1.Visible = False
        '
        'btnDeleteC
        '
        Me.btnDeleteC.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDeleteC.FlatAppearance.BorderSize = 0
        Me.btnDeleteC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnDeleteC.ForeColor = System.Drawing.Color.White
        Me.btnDeleteC.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnDeleteC.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteC.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDeleteC.IconSize = 40
        Me.btnDeleteC.Location = New System.Drawing.Point(278, 145)
        Me.btnDeleteC.Name = "btnDeleteC"
        Me.btnDeleteC.Size = New System.Drawing.Size(137, 45)
        Me.btnDeleteC.TabIndex = 15
        Me.btnDeleteC.Text = "DELETE"
        Me.btnDeleteC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteC.UseVisualStyleBackColor = False
        Me.btnDeleteC.Visible = False
        '
        'boxVilleNum
        '
        Me.boxVilleNum.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxVilleNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxVilleNum.DefaultText = ""
        Me.boxVilleNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxVilleNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxVilleNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxVilleNum.DisabledState.Parent = Me.boxVilleNum
        Me.boxVilleNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxVilleNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxVilleNum.FocusedState.Parent = Me.boxVilleNum
        Me.boxVilleNum.ForeColor = System.Drawing.Color.Black
        Me.boxVilleNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxVilleNum.HoverState.Parent = Me.boxVilleNum
        Me.boxVilleNum.Location = New System.Drawing.Point(393, 43)
        Me.boxVilleNum.Name = "boxVilleNum"
        Me.boxVilleNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxVilleNum.PlaceholderText = ""
        Me.boxVilleNum.SelectedText = ""
        Me.boxVilleNum.ShadowDecoration.Parent = Me.boxVilleNum
        Me.boxVilleNum.Size = New System.Drawing.Size(81, 35)
        Me.boxVilleNum.TabIndex = 15
        Me.boxVilleNum.Visible = False
        '
        'DatagridCom
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DatagridCom.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DatagridCom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridCom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridCom.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DatagridCom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridCom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridCom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridCom.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DatagridCom.ColumnHeadersHeight = 20
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridCom.DefaultCellStyle = DataGridViewCellStyle6
        Me.DatagridCom.EnableHeadersVisualStyles = False
        Me.DatagridCom.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridCom.Location = New System.Drawing.Point(21, 245)
        Me.DatagridCom.Name = "DatagridCom"
        Me.DatagridCom.RowHeadersVisible = False
        Me.DatagridCom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridCom.Size = New System.Drawing.Size(487, 199)
        Me.DatagridCom.TabIndex = 14
        Me.DatagridCom.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DatagridCom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DatagridCom.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DatagridCom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DatagridCom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DatagridCom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DatagridCom.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DatagridCom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridCom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridCom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DatagridCom.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DatagridCom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DatagridCom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DatagridCom.ThemeStyle.HeaderStyle.Height = 20
        Me.DatagridCom.ThemeStyle.ReadOnly = False
        Me.DatagridCom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DatagridCom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridCom.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DatagridCom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.DatagridCom.ThemeStyle.RowsStyle.Height = 22
        Me.DatagridCom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridCom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnModicierC
        '
        Me.btnModicierC.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModicierC.FlatAppearance.BorderSize = 0
        Me.btnModicierC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModicierC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnModicierC.ForeColor = System.Drawing.Color.White
        Me.btnModicierC.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnModicierC.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModicierC.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnModicierC.IconSize = 40
        Me.btnModicierC.Location = New System.Drawing.Point(128, 145)
        Me.btnModicierC.Name = "btnModicierC"
        Me.btnModicierC.Size = New System.Drawing.Size(125, 45)
        Me.btnModicierC.TabIndex = 12
        Me.btnModicierC.Text = "MODIFIER"
        Me.btnModicierC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModicierC.UseVisualStyleBackColor = False
        Me.btnModicierC.Visible = False
        '
        'comboVille
        '
        Me.comboVille.BackColor = System.Drawing.Color.Transparent
        Me.comboVille.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboVille.FocusedColor = System.Drawing.Color.Empty
        Me.comboVille.FocusedState.Parent = Me.comboVille
        Me.comboVille.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboVille.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comboVille.FormattingEnabled = True
        Me.comboVille.HoverState.Parent = Me.comboVille
        Me.comboVille.ItemHeight = 30
        Me.comboVille.ItemsAppearance.Parent = Me.comboVille
        Me.comboVille.Location = New System.Drawing.Point(128, 43)
        Me.comboVille.Name = "comboVille"
        Me.comboVille.ShadowDecoration.Parent = Me.comboVille
        Me.comboVille.Size = New System.Drawing.Size(240, 36)
        Me.comboVille.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "VILLE"
        '
        'boxCommune
        '
        Me.boxCommune.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxCommune.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxCommune.DefaultText = ""
        Me.boxCommune.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxCommune.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxCommune.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxCommune.DisabledState.Parent = Me.boxCommune
        Me.boxCommune.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxCommune.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxCommune.FocusedState.Parent = Me.boxCommune
        Me.boxCommune.ForeColor = System.Drawing.Color.Black
        Me.boxCommune.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxCommune.HoverState.Parent = Me.boxCommune
        Me.boxCommune.Location = New System.Drawing.Point(128, 94)
        Me.boxCommune.Name = "boxCommune"
        Me.boxCommune.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxCommune.PlaceholderText = ""
        Me.boxCommune.SelectedText = ""
        Me.boxCommune.ShadowDecoration.Parent = Me.boxCommune
        Me.boxCommune.Size = New System.Drawing.Size(240, 36)
        Me.boxCommune.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(47, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "COMMUNE"
        '
        'btnAjouterC
        '
        Me.btnAjouterC.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAjouterC.FlatAppearance.BorderSize = 0
        Me.btnAjouterC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouterC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAjouterC.ForeColor = System.Drawing.Color.White
        Me.btnAjouterC.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAjouterC.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAjouterC.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAjouterC.IconSize = 40
        Me.btnAjouterC.Location = New System.Drawing.Point(128, 145)
        Me.btnAjouterC.Name = "btnAjouterC"
        Me.btnAjouterC.Size = New System.Drawing.Size(125, 45)
        Me.btnAjouterC.TabIndex = 2
        Me.btnAjouterC.Text = "AJOUTER"
        Me.btnAjouterC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAjouterC.UseVisualStyleBackColor = False
        '
        'btnResetC
        '
        Me.btnResetC.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnResetC.FlatAppearance.BorderSize = 0
        Me.btnResetC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnResetC.ForeColor = System.Drawing.Color.White
        Me.btnResetC.IconChar = FontAwesome.Sharp.IconChar.Reply
        Me.btnResetC.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnResetC.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnResetC.IconSize = 40
        Me.btnResetC.Location = New System.Drawing.Point(278, 145)
        Me.btnResetC.Name = "btnResetC"
        Me.btnResetC.Size = New System.Drawing.Size(110, 45)
        Me.btnResetC.TabIndex = 4
        Me.btnResetC.Text = "RESET"
        Me.btnResetC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResetC.UseVisualStyleBackColor = False
        '
        'FormCommune
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 574)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "FormCommune"
        Me.Text = "LOCALISATION"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.DatagridVille, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.DatagridCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnModifier As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelProd As Label
    Friend WithEvents btnAjouter As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReset As FontAwesome.Sharp.IconButton
    Friend WithEvents boxVille As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnModicierC As FontAwesome.Sharp.IconButton
    Friend WithEvents comboVille As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents boxCommune As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAjouterC As FontAwesome.Sharp.IconButton
    Friend WithEvents btnResetC As FontAwesome.Sharp.IconButton
    Friend WithEvents DatagridVille As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DatagridCom As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents boxVilleNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeleteC As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
