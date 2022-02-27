<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClientB
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.boxCate = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.boxC = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.btnModifier = New FontAwesome.Sharp.IconButton()
        Me.comboCommune = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxGsm = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LabelProd = New System.Windows.Forms.Label()
        Me.btnAjouter = New FontAwesome.Sharp.IconButton()
        Me.btnReset = New FontAwesome.Sharp.IconButton()
        Me.boxName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboVille = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.boxCate.SuspendLayout()
        Me.SuspendLayout()
        '
        'boxCate
        '
        Me.boxCate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boxCate.BorderRadius = 12
        Me.boxCate.Controls.Add(Me.comboVille)
        Me.boxCate.Controls.Add(Me.Label1)
        Me.boxCate.Controls.Add(Me.boxC)
        Me.boxCate.Controls.Add(Me.btnDelete)
        Me.boxCate.Controls.Add(Me.btnModifier)
        Me.boxCate.Controls.Add(Me.comboCommune)
        Me.boxCate.Controls.Add(Me.Label3)
        Me.boxCate.Controls.Add(Me.Label2)
        Me.boxCate.Controls.Add(Me.boxGsm)
        Me.boxCate.Controls.Add(Me.LabelProd)
        Me.boxCate.Controls.Add(Me.btnAjouter)
        Me.boxCate.Controls.Add(Me.btnReset)
        Me.boxCate.Controls.Add(Me.boxName)
        Me.boxCate.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.boxCate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.boxCate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.boxCate.Location = New System.Drawing.Point(12, 44)
        Me.boxCate.Name = "boxCate"
        Me.boxCate.ShadowDecoration.Parent = Me.boxCate
        Me.boxCate.Size = New System.Drawing.Size(571, 358)
        Me.boxCate.TabIndex = 9
        '
        'boxC
        '
        Me.boxC.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxC.DefaultText = ""
        Me.boxC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxC.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxC.DisabledState.Parent = Me.boxC
        Me.boxC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxC.FocusedState.Parent = Me.boxC
        Me.boxC.ForeColor = System.Drawing.Color.Black
        Me.boxC.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxC.HoverState.Parent = Me.boxC
        Me.boxC.Location = New System.Drawing.Point(418, 135)
        Me.boxC.Name = "boxC"
        Me.boxC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxC.PlaceholderText = ""
        Me.boxC.SelectedText = ""
        Me.boxC.ShadowDecoration.Parent = Me.boxC
        Me.boxC.Size = New System.Drawing.Size(81, 36)
        Me.boxC.TabIndex = 14
        Me.boxC.Visible = False
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
        Me.btnDelete.Location = New System.Drawing.Point(312, 272)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(158, 45)
        Me.btnDelete.TabIndex = 13
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
        Me.btnModifier.Location = New System.Drawing.Point(120, 272)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(158, 45)
        Me.btnModifier.TabIndex = 12
        Me.btnModifier.Text = "MODIFIER"
        Me.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModifier.UseVisualStyleBackColor = False
        Me.btnModifier.Visible = False
        '
        'comboCommune
        '
        Me.comboCommune.BackColor = System.Drawing.Color.Transparent
        Me.comboCommune.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboCommune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCommune.FocusedColor = System.Drawing.Color.Empty
        Me.comboCommune.FocusedState.Parent = Me.comboCommune
        Me.comboCommune.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboCommune.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comboCommune.FormattingEnabled = True
        Me.comboCommune.HoverState.Parent = Me.comboCommune
        Me.comboCommune.ItemHeight = 30
        Me.comboCommune.ItemsAppearance.Parent = Me.comboCommune
        Me.comboCommune.Location = New System.Drawing.Point(152, 135)
        Me.comboCommune.Name = "comboCommune"
        Me.comboCommune.ShadowDecoration.Parent = Me.comboCommune
        Me.comboCommune.Size = New System.Drawing.Size(260, 36)
        Me.comboCommune.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(71, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "COOMIUNE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(71, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "TELEPHONE"
        '
        'boxGsm
        '
        Me.boxGsm.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxGsm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxGsm.DefaultText = ""
        Me.boxGsm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxGsm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxGsm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxGsm.DisabledState.Parent = Me.boxGsm
        Me.boxGsm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxGsm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxGsm.FocusedState.Parent = Me.boxGsm
        Me.boxGsm.ForeColor = System.Drawing.Color.Black
        Me.boxGsm.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxGsm.HoverState.Parent = Me.boxGsm
        Me.boxGsm.Location = New System.Drawing.Point(152, 179)
        Me.boxGsm.Name = "boxGsm"
        Me.boxGsm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxGsm.PlaceholderText = ""
        Me.boxGsm.SelectedText = ""
        Me.boxGsm.ShadowDecoration.Parent = Me.boxGsm
        Me.boxGsm.Size = New System.Drawing.Size(260, 36)
        Me.boxGsm.TabIndex = 6
        '
        'LabelProd
        '
        Me.LabelProd.AutoSize = True
        Me.LabelProd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelProd.ForeColor = System.Drawing.Color.Black
        Me.LabelProd.Location = New System.Drawing.Point(71, 73)
        Me.LabelProd.Name = "LabelProd"
        Me.LabelProd.Size = New System.Drawing.Size(36, 15)
        Me.LabelProd.TabIndex = 5
        Me.LabelProd.Text = "NOM"
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
        Me.btnAjouter.Location = New System.Drawing.Point(120, 272)
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
        Me.btnReset.Location = New System.Drawing.Point(312, 272)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(156, 45)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'boxName
        '
        Me.boxName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.boxName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.boxName.DefaultText = ""
        Me.boxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.boxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.boxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxName.DisabledState.Parent = Me.boxName
        Me.boxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.boxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxName.FocusedState.Parent = Me.boxName
        Me.boxName.ForeColor = System.Drawing.Color.Black
        Me.boxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxName.HoverState.Parent = Me.boxName
        Me.boxName.Location = New System.Drawing.Point(152, 52)
        Me.boxName.Name = "boxName"
        Me.boxName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.boxName.PlaceholderText = ""
        Me.boxName.SelectedText = ""
        Me.boxName.ShadowDecoration.Parent = Me.boxName
        Me.boxName.Size = New System.Drawing.Size(260, 36)
        Me.boxName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(235, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 31)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CLIENT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(72, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "VILLE"
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
        Me.comboVille.Location = New System.Drawing.Point(152, 92)
        Me.comboVille.Name = "comboVille"
        Me.comboVille.ShadowDecoration.Parent = Me.comboVille
        Me.comboVille.Size = New System.Drawing.Size(260, 36)
        Me.comboVille.TabIndex = 16
        '
        'FormClientB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 427)
        Me.Controls.Add(Me.boxCate)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FormClientB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormClientB"
        Me.boxCate.ResumeLayout(False)
        Me.boxCate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents boxCate As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnModifier As FontAwesome.Sharp.IconButton
    Friend WithEvents comboCommune As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents boxGsm As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LabelProd As Label
    Friend WithEvents btnAjouter As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReset As FontAwesome.Sharp.IconButton
    Friend WithEvents boxName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents boxC As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents comboVille As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
End Class
