<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashbord
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
        Me.PanelDashbord = New System.Windows.Forms.Panel()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.LabelClient = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IconButton10 = New FontAwesome.Sharp.IconButton()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IconButton9 = New FontAwesome.Sharp.IconButton()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IconButton8 = New FontAwesome.Sharp.IconButton()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton7 = New FontAwesome.Sharp.IconButton()
        Me.PanelDashbord.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDashbord
        '
        Me.PanelDashbord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PanelDashbord.BackColor = System.Drawing.SystemColors.Control
        Me.PanelDashbord.Controls.Add(Me.Guna2GroupBox4)
        Me.PanelDashbord.Controls.Add(Me.Guna2GroupBox3)
        Me.PanelDashbord.Controls.Add(Me.Guna2GroupBox2)
        Me.PanelDashbord.Controls.Add(Me.Guna2GroupBox1)
        Me.PanelDashbord.Location = New System.Drawing.Point(72, 35)
        Me.PanelDashbord.Name = "PanelDashbord"
        Me.PanelDashbord.Size = New System.Drawing.Size(926, 488)
        Me.PanelDashbord.TabIndex = 1
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox4.BorderRadius = 12
        Me.Guna2GroupBox4.Controls.Add(Me.LabelClient)
        Me.Guna2GroupBox4.Controls.Add(Me.Label9)
        Me.Guna2GroupBox4.Controls.Add(Me.IconButton10)
        Me.Guna2GroupBox4.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox4.FillColor = System.Drawing.Color.Cornsilk
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(542, 300)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.ShadowDecoration.Parent = Me.Guna2GroupBox4
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(331, 154)
        Me.Guna2GroupBox4.TabIndex = 4
        '
        'LabelClient
        '
        Me.LabelClient.AutoSize = True
        Me.LabelClient.BackColor = System.Drawing.Color.Transparent
        Me.LabelClient.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelClient.Location = New System.Drawing.Point(141, 62)
        Me.LabelClient.Name = "LabelClient"
        Me.LabelClient.Size = New System.Drawing.Size(28, 28)
        Me.LabelClient.TabIndex = 3
        Me.LabelClient.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(88, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "NOMBRE DES CLIENT"
        '
        'IconButton10
        '
        Me.IconButton10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IconButton10.BackColor = System.Drawing.Color.Transparent
        Me.IconButton10.FlatAppearance.BorderSize = 0
        Me.IconButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton10.ForeColor = System.Drawing.Color.Black
        Me.IconButton10.IconChar = FontAwesome.Sharp.IconChar.AngleDown
        Me.IconButton10.IconColor = System.Drawing.SystemColors.Desktop
        Me.IconButton10.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton10.IconSize = 30
        Me.IconButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton10.Location = New System.Drawing.Point(3, 122)
        Me.IconButton10.Name = "IconButton10"
        Me.IconButton10.Size = New System.Drawing.Size(325, 27)
        Me.IconButton10.TabIndex = 2
        Me.IconButton10.Text = "VOIR PLUS"
        Me.IconButton10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.IconButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton10.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox3.BorderRadius = 12
        Me.Guna2GroupBox3.Controls.Add(Me.Label6)
        Me.Guna2GroupBox3.Controls.Add(Me.Label7)
        Me.Guna2GroupBox3.Controls.Add(Me.IconButton9)
        Me.Guna2GroupBox3.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox3.FillColor = System.Drawing.Color.PeachPuff
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(64, 299)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(334, 160)
        Me.Guna2GroupBox3.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(141, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 28)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(88, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "PRODUIT EN STOCK"
        '
        'IconButton9
        '
        Me.IconButton9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IconButton9.BackColor = System.Drawing.Color.Transparent
        Me.IconButton9.FlatAppearance.BorderSize = 0
        Me.IconButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton9.ForeColor = System.Drawing.Color.Black
        Me.IconButton9.IconChar = FontAwesome.Sharp.IconChar.AngleDown
        Me.IconButton9.IconColor = System.Drawing.SystemColors.Desktop
        Me.IconButton9.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton9.IconSize = 30
        Me.IconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton9.Location = New System.Drawing.Point(3, 128)
        Me.IconButton9.Name = "IconButton9"
        Me.IconButton9.Size = New System.Drawing.Size(328, 27)
        Me.IconButton9.TabIndex = 2
        Me.IconButton9.Text = "VOIR PLUS"
        Me.IconButton9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.IconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton9.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox2.BorderRadius = 12
        Me.Guna2GroupBox2.Controls.Add(Me.Label4)
        Me.Guna2GroupBox2.Controls.Add(Me.Label5)
        Me.Guna2GroupBox2.Controls.Add(Me.IconButton8)
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.SkyBlue
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(539, 53)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(334, 154)
        Me.Guna2GroupBox2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(141, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(53, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(258, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "PRODUIT EN RUPTURE DE STOCK"
        '
        'IconButton8
        '
        Me.IconButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IconButton8.BackColor = System.Drawing.Color.Transparent
        Me.IconButton8.FlatAppearance.BorderSize = 0
        Me.IconButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton8.ForeColor = System.Drawing.Color.Black
        Me.IconButton8.IconChar = FontAwesome.Sharp.IconChar.AngleDown
        Me.IconButton8.IconColor = System.Drawing.SystemColors.Desktop
        Me.IconButton8.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton8.IconSize = 30
        Me.IconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton8.Location = New System.Drawing.Point(3, 122)
        Me.IconButton8.Name = "IconButton8"
        Me.IconButton8.Size = New System.Drawing.Size(328, 27)
        Me.IconButton8.TabIndex = 2
        Me.IconButton8.Text = "VOIR PLUS"
        Me.IconButton8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.IconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton8.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2GroupBox1.BorderRadius = 12
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.IconButton7)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Turquoise
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(64, 48)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(334, 154)
        Me.Guna2GroupBox1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(141, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(88, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PRODUIT EN STOCK"
        '
        'IconButton7
        '
        Me.IconButton7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IconButton7.BackColor = System.Drawing.Color.Transparent
        Me.IconButton7.FlatAppearance.BorderSize = 0
        Me.IconButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton7.ForeColor = System.Drawing.Color.Black
        Me.IconButton7.IconChar = FontAwesome.Sharp.IconChar.AngleDown
        Me.IconButton7.IconColor = System.Drawing.SystemColors.Desktop
        Me.IconButton7.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton7.IconSize = 30
        Me.IconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton7.Location = New System.Drawing.Point(3, 122)
        Me.IconButton7.Name = "IconButton7"
        Me.IconButton7.Size = New System.Drawing.Size(328, 27)
        Me.IconButton7.TabIndex = 2
        Me.IconButton7.Text = "VOIR PLUS"
        Me.IconButton7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.IconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton7.UseVisualStyleBackColor = False
        '
        'FormDashbord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 573)
        Me.Controls.Add(Me.PanelDashbord)
        Me.Name = "FormDashbord"
        Me.Text = "FormDashbord"
        Me.PanelDashbord.ResumeLayout(False)
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox4.PerformLayout()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelDashbord As Panel
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents LabelClient As Label
    Friend WithEvents Label9 As Label
    Private WithEvents IconButton10 As FontAwesome.Sharp.IconButton
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Private WithEvents IconButton9 As FontAwesome.Sharp.IconButton
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Private WithEvents IconButton8 As FontAwesome.Sharp.IconButton
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Private WithEvents IconButton7 As FontAwesome.Sharp.IconButton
End Class
