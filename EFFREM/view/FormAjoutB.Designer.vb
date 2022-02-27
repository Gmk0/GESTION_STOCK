<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAjoutB
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
        Me.goru = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.boxCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.boxId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnModifier = New FontAwesome.Sharp.IconButton()
        Me.comboCategorie = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxSeuil = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LabelProd = New System.Windows.Forms.Label()
        Me.btnAjouter = New FontAwesome.Sharp.IconButton()
        Me.btnReset = New FontAwesome.Sharp.IconButton()
        Me.boxLibelle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.goru.SuspendLayout()
        Me.SuspendLayout()
        '
        'goru
        '
        Me.goru.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.goru.BorderRadius = 12
        Me.goru.Controls.Add(Me.btnDelete)
        Me.goru.Controls.Add(Me.boxCat)
        Me.goru.Controls.Add(Me.LabelId)
        Me.goru.Controls.Add(Me.boxId)
        Me.goru.Controls.Add(Me.btnModifier)
        Me.goru.Controls.Add(Me.comboCategorie)
        Me.goru.Controls.Add(Me.Label3)
        Me.goru.Controls.Add(Me.Label2)
        Me.goru.Controls.Add(Me.boxDesc)
        Me.goru.Controls.Add(Me.Label1)
        Me.goru.Controls.Add(Me.boxSeuil)
        Me.goru.Controls.Add(Me.LabelProd)
        Me.goru.Controls.Add(Me.btnAjouter)
        Me.goru.Controls.Add(Me.btnReset)
        Me.goru.Controls.Add(Me.boxLibelle)
        Me.goru.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.goru.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.goru.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.goru.Location = New System.Drawing.Point(21, 57)
        Me.goru.Name = "goru"
        Me.goru.ShadowDecoration.Parent = Me.goru
        Me.goru.Size = New System.Drawing.Size(693, 358)
        Me.goru.TabIndex = 3
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
        Me.btnDelete.Location = New System.Drawing.Point(375, 272)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(158, 45)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'boxCat
        '
        Me.boxCat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxCat.DefaultText = ""
        Me.boxCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxCat.DisabledState.Parent = Me.boxCat
        Me.boxCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxCat.FocusedState.Parent = Me.boxCat
        Me.boxCat.ForeColor = System.Drawing.Color.Black
        Me.boxCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxCat.HoverState.Parent = Me.boxCat
        Me.boxCat.Location = New System.Drawing.Point(328, 124)
        Me.boxCat.Name = "boxCat"
        Me.boxCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxCat.PlaceholderText = ""
        Me.boxCat.SelectedText = ""
        Me.boxCat.ShadowDecoration.Parent = Me.boxCat
        Me.boxCat.Size = New System.Drawing.Size(66, 28)
        Me.boxCat.TabIndex = 15
        Me.boxCat.Visible = False
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelId.ForeColor = System.Drawing.Color.Black
        Me.LabelId.Location = New System.Drawing.Point(17, 46)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(17, 15)
        Me.LabelId.TabIndex = 14
        Me.LabelId.Text = "Id"
        Me.LabelId.Visible = False
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
        Me.boxId.Location = New System.Drawing.Point(97, 27)
        Me.boxId.Name = "boxId"
        Me.boxId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxId.PlaceholderText = ""
        Me.boxId.SelectedText = ""
        Me.boxId.ShadowDecoration.Parent = Me.boxId
        Me.boxId.Size = New System.Drawing.Size(212, 34)
        Me.boxId.TabIndex = 13
        Me.boxId.Visible = False
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
        Me.btnModifier.Location = New System.Drawing.Point(151, 272)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(158, 45)
        Me.btnModifier.TabIndex = 12
        Me.btnModifier.Text = "MODIFIER"
        Me.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifier.UseVisualStyleBackColor = False
        Me.btnModifier.Visible = False
        '
        'comboCategorie
        '
        Me.comboCategorie.BackColor = System.Drawing.Color.Transparent
        Me.comboCategorie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCategorie.FocusedColor = System.Drawing.Color.Empty
        Me.comboCategorie.FocusedState.Parent = Me.comboCategorie
        Me.comboCategorie.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboCategorie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comboCategorie.FormattingEnabled = True
        Me.comboCategorie.HoverState.Parent = Me.comboCategorie
        Me.comboCategorie.ItemHeight = 30
        Me.comboCategorie.ItemsAppearance.Parent = Me.comboCategorie
        Me.comboCategorie.Location = New System.Drawing.Point(97, 116)
        Me.comboCategorie.Name = "comboCategorie"
        Me.comboCategorie.ShadowDecoration.Parent = Me.comboCategorie
        Me.comboCategorie.Size = New System.Drawing.Size(212, 36)
        Me.comboCategorie.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "CATEGORIE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SEUIL RUPTURE"
        '
        'boxDesc
        '
        Me.boxDesc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxDesc.DefaultText = ""
        Me.boxDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxDesc.DisabledState.Parent = Me.boxDesc
        Me.boxDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxDesc.FocusedState.Parent = Me.boxDesc
        Me.boxDesc.ForeColor = System.Drawing.Color.Black
        Me.boxDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxDesc.HoverState.Parent = Me.boxDesc
        Me.boxDesc.Location = New System.Drawing.Point(480, 61)
        Me.boxDesc.Multiline = True
        Me.boxDesc.Name = "boxDesc"
        Me.boxDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxDesc.PlaceholderText = ""
        Me.boxDesc.SelectedText = ""
        Me.boxDesc.ShadowDecoration.Parent = Me.boxDesc
        Me.boxDesc.Size = New System.Drawing.Size(188, 70)
        Me.boxDesc.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(395, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DESCRIPTION"
        '
        'boxSeuil
        '
        Me.boxSeuil.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxSeuil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxSeuil.DefaultText = ""
        Me.boxSeuil.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxSeuil.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxSeuil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxSeuil.DisabledState.Parent = Me.boxSeuil
        Me.boxSeuil.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxSeuil.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxSeuil.FocusedState.Parent = Me.boxSeuil
        Me.boxSeuil.ForeColor = System.Drawing.Color.Black
        Me.boxSeuil.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxSeuil.HoverState.Parent = Me.boxSeuil
        Me.boxSeuil.Location = New System.Drawing.Point(97, 182)
        Me.boxSeuil.Name = "boxSeuil"
        Me.boxSeuil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxSeuil.PlaceholderText = ""
        Me.boxSeuil.SelectedText = ""
        Me.boxSeuil.ShadowDecoration.Parent = Me.boxSeuil
        Me.boxSeuil.Size = New System.Drawing.Size(212, 36)
        Me.boxSeuil.TabIndex = 6
        '
        'LabelProd
        '
        Me.LabelProd.AutoSize = True
        Me.LabelProd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelProd.ForeColor = System.Drawing.Color.Black
        Me.LabelProd.Location = New System.Drawing.Point(17, 88)
        Me.LabelProd.Name = "LabelProd"
        Me.LabelProd.Size = New System.Drawing.Size(47, 15)
        Me.LabelProd.TabIndex = 5
        Me.LabelProd.Text = "LIBELLE"
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
        Me.btnAjouter.Location = New System.Drawing.Point(151, 272)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(158, 45)
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
        Me.btnReset.Font = New System.Drawing.Font("Lucida Fax", 10.0!)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.IconChar = FontAwesome.Sharp.IconChar.Reply
        Me.btnReset.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReset.IconSize = 40
        Me.btnReset.Location = New System.Drawing.Point(375, 272)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(156, 45)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'boxLibelle
        '
        Me.boxLibelle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxLibelle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxLibelle.DefaultText = ""
        Me.boxLibelle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxLibelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxLibelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxLibelle.DisabledState.Parent = Me.boxLibelle
        Me.boxLibelle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxLibelle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxLibelle.FocusedState.Parent = Me.boxLibelle
        Me.boxLibelle.ForeColor = System.Drawing.Color.Black
        Me.boxLibelle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxLibelle.HoverState.Parent = Me.boxLibelle
        Me.boxLibelle.Location = New System.Drawing.Point(97, 67)
        Me.boxLibelle.Name = "boxLibelle"
        Me.boxLibelle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxLibelle.PlaceholderText = ""
        Me.boxLibelle.SelectedText = ""
        Me.boxLibelle.ShadowDecoration.Parent = Me.boxLibelle
        Me.boxLibelle.Size = New System.Drawing.Size(212, 36)
        Me.boxLibelle.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(277, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 31)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "PRODUIT"
        '
        'FormAjoutB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 430)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.goru)
        Me.Name = "FormAjoutB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAjoutB"
        Me.goru.ResumeLayout(False)
        Me.goru.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents goru As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents boxDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents boxSeuil As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LabelProd As Label
    Friend WithEvents btnAjouter As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReset As FontAwesome.Sharp.IconButton
    Friend WithEvents boxLibelle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnModifier As FontAwesome.Sharp.IconButton
    Friend WithEvents comboCategorie As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents boxCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LabelId As Label
    Friend WithEvents boxId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
End Class
