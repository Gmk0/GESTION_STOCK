Imports System.Windows.Forms
Public Class AutresControl
    Private table As DataTable
    Private loacalManager As New ClientManger

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
    ' Private cursor As Cursor
    Public Sub showMenu(ByRef childForm As Form, ByVal panelMenu As Panel)


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
    End Sub

    Public Function chargementClientCount()
        Try

            table = loacalManager.ShowClientCount()
            Return table.Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function
    Public Function chargementProduitCount()
        Try

            table = loacalManager.ShowProduitCount()
            Return table.Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function
    Public Function chargementStockRCount()
        Try

            table = loacalManager.ShowProduitCountRupture()
            Return table.Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function

End Class
