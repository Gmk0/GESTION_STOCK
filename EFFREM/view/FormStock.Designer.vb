<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStock
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
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.DatagridProduit = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ProduitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.boxDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.boxMontant = New Guna.UI2.WinForms.Guna2TextBox()
        Me.boxQte = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboProduit = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LabelProd = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        CType(Me.DatagridProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IconButton2.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.IconButton2.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 40
        Me.IconButton2.Location = New System.Drawing.Point(572, 477)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(173, 45)
        Me.IconButton2.TabIndex = 23
        Me.IconButton2.Text = "VALIDER"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'DatagridProduit
        '
        Me.DatagridProduit.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DatagridProduit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridProduit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridProduit.BackgroundColor = System.Drawing.Color.White
        Me.DatagridProduit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridProduit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridProduit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridProduit.ColumnHeadersHeight = 20
        Me.DatagridProduit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProduitID, Me.Qte, Me.Prix, Me.DateP})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridProduit.DefaultCellStyle = DataGridViewCellStyle3
        Me.DatagridProduit.EnableHeadersVisualStyles = False
        Me.DatagridProduit.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridProduit.Location = New System.Drawing.Point(69, 273)
        Me.DatagridProduit.Name = "DatagridProduit"
        Me.DatagridProduit.RowHeadersVisible = False
        Me.DatagridProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridProduit.Size = New System.Drawing.Size(1133, 198)
        Me.DatagridProduit.TabIndex = 22
        Me.DatagridProduit.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DatagridProduit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DatagridProduit.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DatagridProduit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DatagridProduit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DatagridProduit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DatagridProduit.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DatagridProduit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridProduit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.DatagridProduit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DatagridProduit.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DatagridProduit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DatagridProduit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DatagridProduit.ThemeStyle.HeaderStyle.Height = 20
        Me.DatagridProduit.ThemeStyle.ReadOnly = False
        Me.DatagridProduit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DatagridProduit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridProduit.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DatagridProduit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DatagridProduit.ThemeStyle.RowsStyle.Height = 22
        Me.DatagridProduit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridProduit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ProduitID
        '
        Me.ProduitID.HeaderText = "PRODUIT ID"
        Me.ProduitID.Name = "ProduitID"
        '
        'Qte
        '
        Me.Qte.HeaderText = "QTE"
        Me.Qte.Name = "Qte"
        '
        'Prix
        '
        Me.Prix.HeaderText = "PRIX "
        Me.Prix.Name = "Prix"
        '
        'DateP
        '
        Me.DateP.HeaderText = "DATE"
        Me.DateP.Name = "DateP"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.BorderRadius = 12
        Me.Guna2GroupBox1.Controls.Add(Me.IconButton4)
        Me.Guna2GroupBox1.Controls.Add(Me.boxDate)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.boxId)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.boxMontant)
        Me.Guna2GroupBox1.Controls.Add(Me.boxQte)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.comboProduit)
        Me.Guna2GroupBox1.Controls.Add(Me.LabelProd)
        Me.Guna2GroupBox1.Controls.Add(Me.IconButton1)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(69, 50)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1145, 206)
        Me.Guna2GroupBox1.TabIndex = 21
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.IconButton4.ForeColor = System.Drawing.Color.White
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Redo
        Me.IconButton4.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 40
        Me.IconButton4.Location = New System.Drawing.Point(563, 142)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(189, 45)
        Me.IconButton4.TabIndex = 31
        Me.IconButton4.Text = "RESET"
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'boxDate
        '
        Me.boxDate.CheckedState.Parent = Me.boxDate
        Me.boxDate.FillColor = System.Drawing.Color.Transparent
        Me.boxDate.ForeColor = System.Drawing.Color.Black
        Me.boxDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.boxDate.HoverState.Parent = Me.boxDate
        Me.boxDate.Location = New System.Drawing.Point(576, 9)
        Me.boxDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.boxDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.boxDate.Name = "boxDate"
        Me.boxDate.ShadowDecoration.Parent = Me.boxDate
        Me.boxDate.Size = New System.Drawing.Size(208, 36)
        Me.boxDate.TabIndex = 30
        Me.boxDate.Value = New Date(2022, 1, 12, 14, 31, 38, 965)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(828, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "IDProduit"
        Me.Label2.Visible = False
        '
        'boxId
        '
        Me.boxId.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxId.DefaultText = ""
        Me.boxId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxId.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxId.DisabledState.Parent = Me.boxId
        Me.boxId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxId.FocusedState.Parent = Me.boxId
        Me.boxId.ForeColor = System.Drawing.Color.Black
        Me.boxId.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxId.HoverState.Parent = Me.boxId
        Me.boxId.Location = New System.Drawing.Point(912, 13)
        Me.boxId.Name = "boxId"
        Me.boxId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxId.PlaceholderText = ""
        Me.boxId.ReadOnly = True
        Me.boxId.SelectedText = ""
        Me.boxId.ShadowDecoration.Parent = Me.boxId
        Me.boxId.Size = New System.Drawing.Size(208, 32)
        Me.boxId.TabIndex = 27
        Me.boxId.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 19)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "QTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(443, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "MONTANT"
        '
        'boxMontant
        '
        Me.boxMontant.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxMontant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxMontant.DefaultText = ""
        Me.boxMontant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxMontant.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxMontant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxMontant.DisabledState.Parent = Me.boxMontant
        Me.boxMontant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxMontant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxMontant.FocusedState.Parent = Me.boxMontant
        Me.boxMontant.ForeColor = System.Drawing.Color.Black
        Me.boxMontant.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxMontant.HoverState.Parent = Me.boxMontant
        Me.boxMontant.Location = New System.Drawing.Point(576, 61)
        Me.boxMontant.Name = "boxMontant"
        Me.boxMontant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxMontant.PlaceholderText = ""
        Me.boxMontant.SelectedText = ""
        Me.boxMontant.ShadowDecoration.Parent = Me.boxMontant
        Me.boxMontant.Size = New System.Drawing.Size(208, 32)
        Me.boxMontant.TabIndex = 23
        '
        'boxQte
        '
        Me.boxQte.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxQte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxQte.DefaultText = ""
        Me.boxQte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxQte.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxQte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxQte.DisabledState.Parent = Me.boxQte
        Me.boxQte.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxQte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxQte.FocusedState.Parent = Me.boxQte
        Me.boxQte.ForeColor = System.Drawing.Color.Black
        Me.boxQte.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxQte.HoverState.Parent = Me.boxQte
        Me.boxQte.Location = New System.Drawing.Point(99, 65)
        Me.boxQte.Name = "boxQte"
        Me.boxQte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxQte.PlaceholderText = ""
        Me.boxQte.SelectedText = ""
        Me.boxQte.ShadowDecoration.Parent = Me.boxQte
        Me.boxQte.Size = New System.Drawing.Size(302, 36)
        Me.boxQte.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(443, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "DATE"
        '
        'comboProduit
        '
        Me.comboProduit.BackColor = System.Drawing.Color.Transparent
        Me.comboProduit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboProduit.FocusedColor = System.Drawing.Color.Empty
        Me.comboProduit.FocusedState.Parent = Me.comboProduit
        Me.comboProduit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboProduit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comboProduit.FormattingEnabled = True
        Me.comboProduit.HoverState.Parent = Me.comboProduit
        Me.comboProduit.ItemHeight = 30
        Me.comboProduit.ItemsAppearance.Parent = Me.comboProduit
        Me.comboProduit.Location = New System.Drawing.Point(99, 9)
        Me.comboProduit.Name = "comboProduit"
        Me.comboProduit.ShadowDecoration.Parent = Me.comboProduit
        Me.comboProduit.Size = New System.Drawing.Size(302, 36)
        Me.comboProduit.TabIndex = 16
        '
        'LabelProd
        '
        Me.LabelProd.AutoSize = True
        Me.LabelProd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelProd.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelProd.ForeColor = System.Drawing.Color.Black
        Me.LabelProd.Location = New System.Drawing.Point(15, 26)
        Me.LabelProd.Name = "LabelProd"
        Me.LabelProd.Size = New System.Drawing.Size(67, 19)
        Me.LabelProd.TabIndex = 5
        Me.LabelProd.Text = "PRODUIT"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.IconButton1.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.Location = New System.Drawing.Point(338, 142)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(189, 45)
        Me.IconButton1.TabIndex = 2
        Me.IconButton1.Text = "AJOUTER"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton3.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.IconButton3.ForeColor = System.Drawing.Color.White
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.IconButton3.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 40
        Me.IconButton3.Location = New System.Drawing.Point(1208, 323)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(55, 45)
        Me.IconButton3.TabIndex = 32
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'FormStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 533)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.DatagridProduit)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "FormStock"
        Me.Text = "FormStock"
        CType(Me.DatagridProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents DatagridProduit As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents boxDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents boxId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents boxMontant As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents boxQte As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comboProduit As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LabelProd As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ProduitID As DataGridViewTextBoxColumn
    Friend WithEvents Qte As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents DateP As DataGridViewTextBoxColumn
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
End Class
