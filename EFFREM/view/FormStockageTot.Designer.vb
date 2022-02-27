<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStockageTot
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateAu = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dateDu = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.LabelC = New System.Windows.Forms.Label()
        Me.DatagridProduit = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.DatagridProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.BorderRadius = 12
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.dateAu)
        Me.Guna2GroupBox1.Controls.Add(Me.dateDu)
        Me.Guna2GroupBox1.Controls.Add(Me.IconButton2)
        Me.Guna2GroupBox1.Controls.Add(Me.IconButton1)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(61, 41)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1026, 160)
        Me.Guna2GroupBox1.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(313, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "AU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "TOP"
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.Guna2ComboBox1.FocusedState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.FormattingEnabled = True
        Me.Guna2ComboBox1.HoverState.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"50", "100", "200", "500", "1000", "10000", "100000"})
        Me.Guna2ComboBox1.ItemsAppearance.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(87, 101)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.ShadowDecoration.Parent = Me.Guna2ComboBox1
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(140, 36)
        Me.Guna2ComboBox1.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(313, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "AU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DU"
        '
        'dateAu
        '
        Me.dateAu.CheckedState.Parent = Me.dateAu
        Me.dateAu.FillColor = System.Drawing.Color.Gray
        Me.dateAu.ForeColor = System.Drawing.Color.White
        Me.dateAu.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateAu.HoverState.Parent = Me.dateAu
        Me.dateAu.Location = New System.Drawing.Point(402, 25)
        Me.dateAu.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateAu.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateAu.Name = "dateAu"
        Me.dateAu.ShadowDecoration.Parent = Me.dateAu
        Me.dateAu.Size = New System.Drawing.Size(200, 36)
        Me.dateAu.TabIndex = 6
        Me.dateAu.Value = New Date(2022, 1, 17, 20, 25, 8, 394)
        '
        'dateDu
        '
        Me.dateDu.CheckedState.Parent = Me.dateDu
        Me.dateDu.FillColor = System.Drawing.Color.Gray
        Me.dateDu.ForeColor = System.Drawing.Color.White
        Me.dateDu.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateDu.HoverState.Parent = Me.dateDu
        Me.dateDu.Location = New System.Drawing.Point(87, 25)
        Me.dateDu.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateDu.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateDu.Name = "dateDu"
        Me.dateDu.ShadowDecoration.Parent = Me.dateDu
        Me.dateDu.Size = New System.Drawing.Size(200, 36)
        Me.dateDu.TabIndex = 5
        Me.dateDu.Value = New Date(2022, 1, 17, 20, 25, 8, 394)
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Lucida Fax", 10.0!)
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.NotesMedical
        Me.IconButton2.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 40
        Me.IconButton2.Location = New System.Drawing.Point(863, 16)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(158, 45)
        Me.IconButton2.TabIndex = 4
        Me.IconButton2.Text = "ACTUALISER"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Lucida Fax", 10.0!)
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.IconButton1.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.Location = New System.Drawing.Point(660, 16)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(158, 45)
        Me.IconButton1.TabIndex = 2
        Me.IconButton1.Text = "RECHERCHE"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'LabelC
        '
        Me.LabelC.AutoSize = True
        Me.LabelC.BackColor = System.Drawing.Color.White
        Me.LabelC.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.LabelC.ForeColor = System.Drawing.Color.Black
        Me.LabelC.Location = New System.Drawing.Point(625, 342)
        Me.LabelC.Name = "LabelC"
        Me.LabelC.Size = New System.Drawing.Size(0, 25)
        Me.LabelC.TabIndex = 22
        '
        'DatagridProduit
        '
        Me.DatagridProduit.AllowUserToAddRows = False
        Me.DatagridProduit.AllowUserToDeleteRows = False
        Me.DatagridProduit.AllowUserToResizeColumns = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.DatagridProduit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DatagridProduit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatagridProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatagridProduit.BackgroundColor = System.Drawing.Color.White
        Me.DatagridProduit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridProduit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DatagridProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridProduit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DatagridProduit.ColumnHeadersHeight = 20
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridProduit.DefaultCellStyle = DataGridViewCellStyle9
        Me.DatagridProduit.EnableHeadersVisualStyles = False
        Me.DatagridProduit.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridProduit.Location = New System.Drawing.Point(61, 218)
        Me.DatagridProduit.Name = "DatagridProduit"
        Me.DatagridProduit.RowHeadersVisible = False
        Me.DatagridProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridProduit.Size = New System.Drawing.Size(1026, 268)
        Me.DatagridProduit.TabIndex = 20
        Me.DatagridProduit.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DatagridProduit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DatagridProduit.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DatagridProduit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DatagridProduit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DatagridProduit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DatagridProduit.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DatagridProduit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatagridProduit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
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
        'FormStockageTot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 526)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.LabelC)
        Me.Controls.Add(Me.DatagridProduit)
        Me.Name = "FormStockageTot"
        Me.Text = "FormStockageTot"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.DatagridProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dateAu As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dateDu As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelC As Label
    Friend WithEvents DatagridProduit As Guna.UI2.WinForms.Guna2DataGridView
End Class
