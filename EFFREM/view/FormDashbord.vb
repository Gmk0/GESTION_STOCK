Public Class FormDashbord
    Private clientControler As New ClientController
    Private table As DataTable
    Private ReadOnly form As New FormMenu3
    Private otherControl As New AutresControl

    Private Sub FormDashbord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        elementChargement()
    End Sub
    Sub elementChargement()
        table = clientControler.chargementClientCount()
        If table.Rows.Count > 0 Then
            LabelClient.Text = table.Rows(0)(0)
        End If

    End Sub

    Private Sub IconButton10_Click(sender As Object, e As EventArgs) Handles IconButton10.Click
        Cursor = Cursors.WaitCursor
        otherControl.showMenu(New FormClientA, form.PanelMenu)
        form.LabelTitre.Text = "CLIENT"
        Cursor = Cursors.Default
    End Sub
End Class