<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategorie
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnModifier = New FontAwesome.Sharp.IconButton()
        Me.btnAjouter = New FontAwesome.Sharp.IconButton()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.btnReset = New FontAwesome.Sharp.IconButton()
        Me.LabelProd = New System.Windows.Forms.Label()
        Me.boxCategorie = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DatagridCategorie = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.DatagridCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.BorderRadius = 12
        Me.Guna2GroupBox1.Controls.Add(Me.IconButton1)
        Me.Guna2GroupBox1.Controls.Add(Me.btnModifier)
        Me.Guna2GroupBox1.Controls.Add(Me.btnAjouter)
        Me.Guna2GroupBox1.Controls.Add(Me.btnDelete)
        Me.Guna2GroupBox1.Controls.Add(Me.btnReset)
        Me.Guna2GroupBox1.Controls.Add(Me.LabelProd)
        Me.Guna2GroupBox1.Controls.Add(Me.boxCategorie)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(58, 46)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(805, 178)
        Me.Guna2GroupBox1.TabIndex = 11
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
        Me.btnModifier.Location = New System.Drawing.Point(159, 97)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(158, 45)
        Me.btnModifier.TabIndex = 17
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
        Me.btnAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAjouter.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAjouter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAjouter.IconSize = 40
        Me.btnAjouter.Location = New System.Drawing.Point(161, 97)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(158, 45)
        Me.btnAjouter.TabIndex = 16
        Me.btnAjouter.Text = "AJOUTER"
        Me.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAjouter.UseVisualStyleBackColor = False
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
        Me.btnDelete.Location = New System.Drawing.Point(356, 97)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(158, 45)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
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
        Me.btnReset.Location = New System.Drawing.Point(356, 97)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(156, 45)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'LabelProd
        '
        Me.LabelProd.AutoSize = True
        Me.LabelProd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelProd.ForeColor = System.Drawing.Color.Black
        Me.LabelProd.Location = New System.Drawing.Point(121, 25)
        Me.LabelProd.Name = "LabelProd"
        Me.LabelProd.Size = New System.Drawing.Size(67, 15)
        Me.LabelProd.TabIndex = 5
        Me.LabelProd.Text = "CATEGORIE"
        '
        'boxCategorie
        '
        Me.boxCategorie.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxCategorie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxCategorie.DefaultText = ""
        Me.boxCategorie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxCategorie.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxCategorie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxCategorie.DisabledState.Parent = Me.boxCategorie
        Me.boxCategorie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxCategorie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxCategorie.FocusedState.Parent = Me.boxCategorie
        Me.boxCategorie.ForeColor = System.Drawing.Color.Black
        Me.boxCategorie.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxCategorie.HoverState.Parent = Me.boxCategorie
        Me.boxCategorie.Location = New System.Drawing.Point(203, 13)
        Me.boxCategorie.Name = "boxCategorie"
        Me.boxCategorie.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxCategorie.PlaceholderText = ""
        Me.boxCategorie.SelectedText = ""
        Me.boxCategorie.ShadowDecoration.Parent = Me.boxCategorie
        Me.boxCategorie.Size = New System.Drawing.Size(366, 36)
        Me.boxCategorie.TabIndex = 3
        '
        'DatagridCategorie
        '
        Me.DatagridCategorie.AllowUserToAddRows = False
        Me.DatagridCategorie.AllowUserToDeleteRows = False
        Me.DatagridCategorie.AllowUserToResizeColumns = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DatagridCategorie.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DatagridCategorie.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridCategorie.BackgroundColor = System.Drawing.Color.White
        Me.DatagridCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridCategorie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridCategorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridCategorie.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DatagridCategorie.ColumnHeadersHeight = 25
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridCategorie.DefaultCellStyle = DataGridViewCellStyle6
        Me.DatagridCategorie.EnableHeadersVisualStyles = False
        Me.DatagridCategorie.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridCategorie.Location = New System.Drawing.Point(58, 250)
        Me.DatagridCategorie.Name = "DatagridCategorie"
        Me.DatagridCategorie.RowHeadersVisible = False
        Me.DatagridCategorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridCategorie.Size = New System.Drawing.Size(805, 207)
        Me.DatagridCategorie.TabIndex = 16
        Me.DatagridCategorie.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DatagridCategorie.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DatagridCategorie.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DatagridCategorie.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DatagridCategorie.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DatagridCategorie.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DatagridCategorie.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DatagridCategorie.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridCategorie.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.DatagridCategorie.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DatagridCategorie.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DatagridCategorie.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DatagridCategorie.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DatagridCategorie.ThemeStyle.HeaderStyle.Height = 25
        Me.DatagridCategorie.ThemeStyle.ReadOnly = False
        Me.DatagridCategorie.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DatagridCategorie.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridCategorie.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DatagridCategorie.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DatagridCategorie.ThemeStyle.RowsStyle.Height = 22
        Me.DatagridCategorie.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridCategorie.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.IconButton1.Location = New System.Drawing.Point(563, 97)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(53, 45)
        Me.IconButton1.TabIndex = 18
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        Me.IconButton1.Visible = False
        '
        'FormCategorie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 498)
        Me.Controls.Add(Me.DatagridCategorie)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "FormCategorie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCategorie"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.DatagridCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents LabelProd As Label
    Friend WithEvents boxCategorie As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReset As FontAwesome.Sharp.IconButton
    Friend WithEvents btnModifier As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAjouter As FontAwesome.Sharp.IconButton
    Friend WithEvents DatagridCategorie As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
