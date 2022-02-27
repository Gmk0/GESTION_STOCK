<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHistoValeur
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
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.btnModifier = New FontAwesome.Sharp.IconButton()
        Me.btnAjouter = New FontAwesome.Sharp.IconButton()
        Me.btnReset = New FontAwesome.Sharp.IconButton()
        Me.boxDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DatagridCom = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.comboProduit = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxMontant = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.DatagridCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox2.BorderRadius = 12
        Me.Guna2GroupBox2.Controls.Add(Me.IconButton1)
        Me.Guna2GroupBox2.Controls.Add(Me.btnDelete)
        Me.Guna2GroupBox2.Controls.Add(Me.btnModifier)
        Me.Guna2GroupBox2.Controls.Add(Me.btnAjouter)
        Me.Guna2GroupBox2.Controls.Add(Me.btnReset)
        Me.Guna2GroupBox2.Controls.Add(Me.boxDate)
        Me.Guna2GroupBox2.Controls.Add(Me.Label2)
        Me.Guna2GroupBox2.Controls.Add(Me.boxId)
        Me.Guna2GroupBox2.Controls.Add(Me.comboProduit)
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.Controls.Add(Me.boxMontant)
        Me.Guna2GroupBox2.Controls.Add(Me.Label5)
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(56, 49)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1015, 198)
        Me.Guna2GroupBox2.TabIndex = 14
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Lucida Fax", 10.0!)
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Redo
        Me.IconButton1.IconColor = System.Drawing.Color.Cornsilk
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.Location = New System.Drawing.Point(586, 137)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(158, 45)
        Me.IconButton1.TabIndex = 36
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        Me.IconButton1.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Lucida Fax", 10.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnDelete.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.IconSize = 40
        Me.btnDelete.Location = New System.Drawing.Point(586, 73)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(158, 45)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModifier.FlatAppearance.BorderSize = 0
        Me.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifier.Font = New System.Drawing.Font("Lucida Fax", 10.0!)
        Me.btnModifier.ForeColor = System.Drawing.Color.White
        Me.btnModifier.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnModifier.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModifier.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnModifier.IconSize = 40
        Me.btnModifier.Location = New System.Drawing.Point(586, 12)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(158, 45)
        Me.btnModifier.TabIndex = 34
        Me.btnModifier.Text = "MODIFIER"
        Me.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifier.UseVisualStyleBackColor = False
        Me.btnModifier.Visible = False
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAjouter.FlatAppearance.BorderSize = 0
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Lucida Fax", 10.0!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAjouter.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAjouter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAjouter.IconSize = 40
        Me.btnAjouter.Location = New System.Drawing.Point(586, 12)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(158, 45)
        Me.btnAjouter.TabIndex = 32
        Me.btnAjouter.Text = "AJOUTER"
        Me.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Lucida Fax", 10.0!)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.IconChar = FontAwesome.Sharp.IconChar.Reply
        Me.btnReset.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReset.IconSize = 40
        Me.btnReset.Location = New System.Drawing.Point(586, 73)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(156, 45)
        Me.btnReset.TabIndex = 33
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'boxDate
        '
        Me.boxDate.CheckedState.Parent = Me.boxDate
        Me.boxDate.FillColor = System.Drawing.Color.Transparent
        Me.boxDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.boxDate.HoverState.Parent = Me.boxDate
        Me.boxDate.Location = New System.Drawing.Point(128, 116)
        Me.boxDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.boxDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.boxDate.Name = "boxDate"
        Me.boxDate.ShadowDecoration.Parent = Me.boxDate
        Me.boxDate.Size = New System.Drawing.Size(208, 36)
        Me.boxDate.TabIndex = 31
        Me.boxDate.Value = New Date(2022, 1, 12, 14, 31, 38, 965)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(47, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "DATE"
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
        Me.boxId.Location = New System.Drawing.Point(374, 23)
        Me.boxId.Name = "boxId"
        Me.boxId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxId.PlaceholderText = ""
        Me.boxId.ReadOnly = True
        Me.boxId.SelectedText = ""
        Me.boxId.ShadowDecoration.Parent = Me.boxId
        Me.boxId.Size = New System.Drawing.Size(138, 35)
        Me.boxId.TabIndex = 15
        Me.boxId.Visible = False
        '
        'DatagridCom
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DatagridCom.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridCom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridCom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridCom.BackgroundColor = System.Drawing.Color.White
        Me.DatagridCom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridCom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridCom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridCom.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridCom.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridCom.DefaultCellStyle = DataGridViewCellStyle3
        Me.DatagridCom.EnableHeadersVisualStyles = False
        Me.DatagridCom.GridColor = System.Drawing.Color.White
        Me.DatagridCom.Location = New System.Drawing.Point(56, 262)
        Me.DatagridCom.Name = "DatagridCom"
        Me.DatagridCom.RowHeadersVisible = False
        Me.DatagridCom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridCom.Size = New System.Drawing.Size(1015, 252)
        Me.DatagridCom.TabIndex = 14
        Me.DatagridCom.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DatagridCom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DatagridCom.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DatagridCom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DatagridCom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DatagridCom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DatagridCom.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DatagridCom.ThemeStyle.GridColor = System.Drawing.Color.White
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
        Me.comboProduit.Location = New System.Drawing.Point(128, 22)
        Me.comboProduit.Name = "comboProduit"
        Me.comboProduit.ShadowDecoration.Parent = Me.comboProduit
        Me.comboProduit.Size = New System.Drawing.Size(240, 36)
        Me.comboProduit.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PRODUIT"
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
        Me.boxMontant.Location = New System.Drawing.Point(128, 73)
        Me.boxMontant.Name = "boxMontant"
        Me.boxMontant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxMontant.PlaceholderText = ""
        Me.boxMontant.SelectedText = ""
        Me.boxMontant.ShadowDecoration.Parent = Me.boxMontant
        Me.boxMontant.Size = New System.Drawing.Size(240, 36)
        Me.boxMontant.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(47, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "PRIX"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(304, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "VALEUR"
        '
        'FormHistoValeur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 526)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.DatagridCom)
        Me.Name = "FormHistoValeur"
        Me.Text = "FormHistoValeur"
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.DatagridCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents boxId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DatagridCom As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents comboProduit As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents boxMontant As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents boxDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents btnModifier As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAjouter As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReset As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
End Class
