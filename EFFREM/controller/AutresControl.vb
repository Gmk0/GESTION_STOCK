Imports System.Windows
Public Class AutresControl
    Public Sub AjoutButtonn(ByVal datagrid As DataGridView)
        With datagrid.Columns
            Dim btn As New DataGridViewButtonColumn
            btn.Name = "MODIFICATION"
            btn.HeaderText = "MODIFIACTION"
            btn.Text = "MODIFIER"
            btn.FlatStyle = FlatStyle.Flat

            ' btn.DefaultCellStyle.BackColor = Color.CornflowerBlue
            btn.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue
            btn.Width = 100

            btn.UseColumnTextForButtonValue = True
            .Add(btn)
        End With
    End Sub

    Private activeForm As Form = Nothing
    Private cursor As Cursor
    Public Sub showMenu(ByRef childForm As Form, ByRef panelMenu As Panel)

        cursor = Cursors.WaitCursor
        If activeForm IsNot Nothing Then
            activeForm.Close()
        End If
        activeForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelMenu.Controls.Add(childForm)
        panelMenu.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        cursor = Cursors.Default


    End Sub
End Class
