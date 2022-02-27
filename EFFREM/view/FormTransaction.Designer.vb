<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaction
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
        Me.boxPrix = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TransacNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.boxPrixValue = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.boxdates = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.boxMontant = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.boxQte = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboClient = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.comboProduit = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LabelProd = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.DatagridProduit = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TransactionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produitId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dates = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.boxPrix.SuspendLayout()
        CType(Me.DatagridProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boxPrix
        '
        Me.boxPrix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boxPrix.BorderRadius = 12
        Me.boxPrix.Controls.Add(Me.Label2)
        Me.boxPrix.Controls.Add(Me.TransacNum)
        Me.boxPrix.Controls.Add(Me.boxPrixValue)
        Me.boxPrix.Controls.Add(Me.Label4)
        Me.boxPrix.Controls.Add(Me.IconButton4)
        Me.boxPrix.Controls.Add(Me.boxdates)
        Me.boxPrix.Controls.Add(Me.IconButton3)
        Me.boxPrix.Controls.Add(Me.Label6)
        Me.boxPrix.Controls.Add(Me.Label5)
        Me.boxPrix.Controls.Add(Me.boxMontant)
        Me.boxPrix.Controls.Add(Me.Label3)
        Me.boxPrix.Controls.Add(Me.boxQte)
        Me.boxPrix.Controls.Add(Me.Label1)
        Me.boxPrix.Controls.Add(Me.comboClient)
        Me.boxPrix.Controls.Add(Me.comboProduit)
        Me.boxPrix.Controls.Add(Me.LabelProd)
        Me.boxPrix.Controls.Add(Me.IconButton1)
        Me.boxPrix.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.boxPrix.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.boxPrix.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.boxPrix.Location = New System.Drawing.Point(51, 47)
        Me.boxPrix.Name = "boxPrix"
        Me.boxPrix.ShadowDecoration.Parent = Me.boxPrix
        Me.boxPrix.Size = New System.Drawing.Size(1024, 211)
        Me.boxPrix.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(376, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 19)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "NUM"
        '
        'TransacNum
        '
        Me.TransacNum.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TransacNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TransacNum.DefaultText = ""
        Me.TransacNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TransacNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TransacNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TransacNum.DisabledState.Parent = Me.TransacNum
        Me.TransacNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TransacNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransacNum.FocusedState.Parent = Me.TransacNum
        Me.TransacNum.ForeColor = System.Drawing.Color.Black
        Me.TransacNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TransacNum.HoverState.Parent = Me.TransacNum
        Me.TransacNum.Location = New System.Drawing.Point(435, 51)
        Me.TransacNum.Name = "TransacNum"
        Me.TransacNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TransacNum.PlaceholderText = ""
        Me.TransacNum.SelectedText = ""
        Me.TransacNum.ShadowDecoration.Parent = Me.TransacNum
        Me.TransacNum.Size = New System.Drawing.Size(232, 36)
        Me.TransacNum.TabIndex = 34
        '
        'boxPrixValue
        '
        Me.boxPrixValue.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxPrixValue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxPrixValue.DefaultText = ""
        Me.boxPrixValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxPrixValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxPrixValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxPrixValue.DisabledState.Parent = Me.boxPrixValue
        Me.boxPrixValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxPrixValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxPrixValue.FocusedState.Parent = Me.boxPrixValue
        Me.boxPrixValue.ForeColor = System.Drawing.Color.Black
        Me.boxPrixValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxPrixValue.HoverState.Parent = Me.boxPrixValue
        Me.boxPrixValue.Location = New System.Drawing.Point(99, 51)
        Me.boxPrixValue.Name = "boxPrixValue"
        Me.boxPrixValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxPrixValue.PlaceholderText = ""
        Me.boxPrixValue.SelectedText = ""
        Me.boxPrixValue.ShadowDecoration.Parent = Me.boxPrixValue
        Me.boxPrixValue.Size = New System.Drawing.Size(251, 36)
        Me.boxPrixValue.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(376, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 19)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "DATE"
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.IconButton4.ForeColor = System.Drawing.Color.White
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.RedoAlt
        Me.IconButton4.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 40
        Me.IconButton4.Location = New System.Drawing.Point(804, 116)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(128, 45)
        Me.IconButton4.TabIndex = 31
        Me.IconButton4.Text = "RESET"
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'boxdates
        '
        Me.boxdates.CheckedState.Parent = Me.boxdates
        Me.boxdates.FillColor = System.Drawing.Color.Transparent
        Me.boxdates.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.boxdates.HoverState.Parent = Me.boxdates
        Me.boxdates.Location = New System.Drawing.Point(435, 125)
        Me.boxdates.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.boxdates.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.boxdates.Name = "boxdates"
        Me.boxdates.ShadowDecoration.Parent = Me.boxdates
        Me.boxdates.Size = New System.Drawing.Size(173, 36)
        Me.boxdates.TabIndex = 30
        Me.boxdates.Value = New Date(2022, 1, 12, 14, 31, 38, 965)
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.IconButton3.ForeColor = System.Drawing.Color.White
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.IconButton3.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 40
        Me.IconButton3.Location = New System.Drawing.Point(804, 13)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(128, 45)
        Me.IconButton3.TabIndex = 29
        Me.IconButton3.Text = "NEW"
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 112)
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
        Me.Label5.Location = New System.Drawing.Point(15, 158)
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
        Me.boxMontant.Location = New System.Drawing.Point(99, 137)
        Me.boxMontant.Name = "boxMontant"
        Me.boxMontant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxMontant.PlaceholderText = ""
        Me.boxMontant.SelectedText = ""
        Me.boxMontant.ShadowDecoration.Parent = Me.boxMontant
        Me.boxMontant.Size = New System.Drawing.Size(251, 40)
        Me.boxMontant.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "PRIX"
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
        Me.boxQte.Location = New System.Drawing.Point(99, 94)
        Me.boxQte.Name = "boxQte"
        Me.boxQte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxQte.PlaceholderText = ""
        Me.boxQte.SelectedText = ""
        Me.boxQte.ShadowDecoration.Parent = Me.boxQte
        Me.boxQte.Size = New System.Drawing.Size(251, 37)
        Me.boxQte.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(376, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "CLIENT"
        '
        'comboClient
        '
        Me.comboClient.BackColor = System.Drawing.Color.Transparent
        Me.comboClient.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboClient.FocusedColor = System.Drawing.Color.Empty
        Me.comboClient.FocusedState.Parent = Me.comboClient
        Me.comboClient.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboClient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comboClient.FormattingEnabled = True
        Me.comboClient.HoverState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.comboClient.HoverState.Parent = Me.comboClient
        Me.comboClient.ItemHeight = 25
        Me.comboClient.ItemsAppearance.Parent = Me.comboClient
        Me.comboClient.Location = New System.Drawing.Point(435, 9)
        Me.comboClient.Name = "comboClient"
        Me.comboClient.ShadowDecoration.Parent = Me.comboClient
        Me.comboClient.Size = New System.Drawing.Size(267, 31)
        Me.comboClient.TabIndex = 17
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
        Me.comboProduit.HoverState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.comboProduit.HoverState.Parent = Me.comboProduit
        Me.comboProduit.ItemHeight = 25
        Me.comboProduit.ItemsAppearance.Parent = Me.comboProduit
        Me.comboProduit.Location = New System.Drawing.Point(99, 9)
        Me.comboProduit.Name = "comboProduit"
        Me.comboProduit.ShadowDecoration.Parent = Me.comboProduit
        Me.comboProduit.Size = New System.Drawing.Size(251, 31)
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
        Me.IconButton1.Location = New System.Drawing.Point(664, 116)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(124, 45)
        Me.IconButton1.TabIndex = 2
        Me.IconButton1.Text = "AJOUTER"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
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
        Me.DatagridProduit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionId, Me.produitId, Me.qte, Me.montant, Me.Prix, Me.clientId, Me.dates})
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
        Me.DatagridProduit.Location = New System.Drawing.Point(51, 270)
        Me.DatagridProduit.Name = "DatagridProduit"
        Me.DatagridProduit.RowHeadersVisible = False
        Me.DatagridProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridProduit.Size = New System.Drawing.Size(1024, 191)
        Me.DatagridProduit.TabIndex = 4
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
        'TransactionId
        '
        Me.TransactionId.HeaderText = "TransactionId"
        Me.TransactionId.Name = "TransactionId"
        '
        'produitId
        '
        Me.produitId.HeaderText = "PRODUIT ID"
        Me.produitId.Name = "produitId"
        '
        'qte
        '
        Me.qte.HeaderText = "QTE"
        Me.qte.Name = "qte"
        '
        'montant
        '
        Me.montant.HeaderText = "MONTANT"
        Me.montant.Name = "montant"
        '
        'Prix
        '
        Me.Prix.HeaderText = "PRIX ID"
        Me.Prix.Name = "Prix"
        '
        'clientId
        '
        Me.clientId.HeaderText = "CLIENT ID"
        Me.clientId.Name = "clientId"
        '
        'dates
        '
        Me.dates.HeaderText = "DATE"
        Me.dates.Name = "dates"
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
        Me.IconButton2.Location = New System.Drawing.Point(486, 467)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(173, 47)
        Me.IconButton2.TabIndex = 20
        Me.IconButton2.Text = "VALIDER"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'FormTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 526)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.DatagridProduit)
        Me.Controls.Add(Me.boxPrix)
        Me.Name = "FormTransaction"
        Me.Text = "FormTransaction"
        Me.boxPrix.ResumeLayout(False)
        Me.boxPrix.PerformLayout()
        CType(Me.DatagridProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boxPrix As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents LabelProd As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents comboClient As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents comboProduit As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents boxQte As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DatagridProduit As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents boxdates As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents boxMontant As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents boxPrixValue As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents TransacNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TransactionId As DataGridViewTextBoxColumn
    Friend WithEvents produitId As DataGridViewTextBoxColumn
    Friend WithEvents qte As DataGridViewTextBoxColumn
    Friend WithEvents montant As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents clientId As DataGridViewTextBoxColumn
    Friend WithEvents dates As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
