<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.TransitGuna = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.btnhide2 = New FontAwesome.Sharp.IconButton()
        Me.btnShow2 = New FontAwesome.Sharp.IconButton()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelMenuSlide = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panelmenu = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.panelMenuSlide.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlToolTip1
        '
        Me.Guna2HtmlToolTip1.AllowLinksHandling = True
        Me.Guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'TransitGuna
        '
        Me.TransitGuna.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.TransitGuna.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.TransitGuna.DefaultAnimation = Animation2
        Me.TransitGuna.MaxAnimationTime = 1000
        '
        'Guna2Separator1
        '
        Me.TransitGuna.SetDecoration(Me.Guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Separator1.Location = New System.Drawing.Point(3, 533)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(200, 17)
        Me.Guna2Separator1.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.IconButton2)
        Me.Panel1.Controls.Add(Me.btnhide2)
        Me.Panel1.Controls.Add(Me.btnShow2)
        Me.TransitGuna.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 552)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 139)
        Me.Panel1.TabIndex = 0
        '
        'IconButton2
        '
        Me.IconButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IconButton2.AutoSize = True
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TransitGuna.SetDecoration(Me.IconButton2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.IconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Lucida Fax", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 42
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(-1, 88)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(196, 48)
        Me.IconButton2.TabIndex = 9
        Me.IconButton2.Tag = "ventes"
        Me.IconButton2.Text = "EXIT"
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'btnhide2
        '
        Me.btnhide2.AutoSize = True
        Me.btnhide2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TransitGuna.SetDecoration(Me.btnhide2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnhide2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnhide2.FlatAppearance.BorderSize = 0
        Me.btnhide2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnhide2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhide2.Font = New System.Drawing.Font("Lucida Fax", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhide2.ForeColor = System.Drawing.Color.White
        Me.btnhide2.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltLeft
        Me.btnhide2.IconColor = System.Drawing.Color.White
        Me.btnhide2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnhide2.IconSize = 42
        Me.btnhide2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhide2.Location = New System.Drawing.Point(162, 3)
        Me.btnhide2.Name = "btnhide2"
        Me.btnhide2.Size = New System.Drawing.Size(56, 48)
        Me.btnhide2.TabIndex = 11
        Me.btnhide2.Tag = "ventes"
        Me.btnhide2.UseVisualStyleBackColor = False
        '
        'btnShow2
        '
        Me.btnShow2.AutoSize = True
        Me.btnShow2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TransitGuna.SetDecoration(Me.btnShow2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnShow2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnShow2.FlatAppearance.BorderSize = 0
        Me.btnShow2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnShow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow2.Font = New System.Drawing.Font("Lucida Fax", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow2.ForeColor = System.Drawing.Color.White
        Me.btnShow2.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltRight
        Me.btnShow2.IconColor = System.Drawing.Color.White
        Me.btnShow2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnShow2.IconSize = 42
        Me.btnShow2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow2.Location = New System.Drawing.Point(-1, 0)
        Me.btnShow2.Name = "btnShow2"
        Me.btnShow2.Size = New System.Drawing.Size(48, 48)
        Me.btnShow2.TabIndex = 10
        Me.btnShow2.Tag = "ventes"
        Me.btnShow2.UseVisualStyleBackColor = False
        Me.btnShow2.Visible = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TransitGuna.SetDecoration(Me.Guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(202, 21)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1013, 44)
        Me.Guna2Panel2.TabIndex = 4
        '
        'Guna2Panel3
        '
        Me.TransitGuna.SetDecoration(Me.Guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(202, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(1013, 21)
        Me.Guna2Panel3.TabIndex = 5
        '
        'Guna2Panel4
        '
        Me.TransitGuna.SetDecoration(Me.Guna2Panel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(202, 136)
        Me.Guna2Panel4.TabIndex = 2
        '
        'panelMenuSlide
        '
        Me.panelMenuSlide.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.panelMenuSlide.BorderColor = System.Drawing.Color.White
        Me.panelMenuSlide.Controls.Add(Me.Guna2Separator1)
        Me.panelMenuSlide.Controls.Add(Me.Panel1)
        Me.panelMenuSlide.Controls.Add(Me.Guna2Panel4)
        Me.TransitGuna.SetDecoration(Me.panelMenuSlide, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.panelMenuSlide.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenuSlide.Location = New System.Drawing.Point(0, 0)
        Me.panelMenuSlide.Name = "panelMenuSlide"
        Me.panelMenuSlide.ShadowDecoration.Parent = Me.panelMenuSlide
        Me.panelMenuSlide.Size = New System.Drawing.Size(202, 691)
        Me.panelMenuSlide.TabIndex = 3
        '
        'Panelmenu
        '
        Me.TransitGuna.SetDecoration(Me.Panelmenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panelmenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.Panelmenu.Name = "Panelmenu"
        Me.Panelmenu.Size = New System.Drawing.Size(1215, 691)
        Me.Panelmenu.TabIndex = 6
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 400
        Me.ToolTip1.UseFading = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 691)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.panelMenuSlide)
        Me.Controls.Add(Me.Panelmenu)
        Me.TransitGuna.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Name = "FormMenu"
        Me.Text = "FormMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelMenuSlide.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents TransitGuna As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnhide2 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnShow2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelMenuSlide As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panelmenu As Panel
    Friend WithEvents ToolTip1 As ToolTip
End Class
