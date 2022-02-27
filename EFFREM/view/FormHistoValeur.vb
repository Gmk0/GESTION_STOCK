Public Class FormHistoValeur
    Private valeurController As New ValeurController()
    Private controlProduit As New produitController
    Private Table As DataTable
    Private ID As String


    Private Sub FormHistoValeur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargementElement()
    End Sub
    Private Sub chargementNameById()
        Table = controlProduit.chargementNameById(boxId.Text)
        If Table.Rows.Count > 0 Then
            comboProduit.Text = Table.Rows(0)("name")
        Else

        End If

    End Sub
    Private Sub chargementElement()
        valeurController.showValeur(DatagridCom)
        controlProduit.ChargementProduit(comboProduit)
    End Sub
    Public Sub chargmentElemetId()
        Table = controlProduit.chargementID(comboProduit)
        If Table.Rows.Count > 0 Then
            boxId.Text = Table.Rows(0)("id")
        End If
    End Sub
    Public Sub chargemetnPrix()
        ' Table = valeurController()
        If Table.Rows.Count > 0 Then
            ' boxMontant.Text = Table.Rows(0)("prix")
        Else
            ' boxMontant.Text = "0"
        End If
    End Sub

    Private Sub comboProduit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProduit.SelectedIndexChanged
        chargmentElemetId()

    End Sub

    Private Sub btnAjouterC_Click(sender As Object, e As EventArgs)


    End Sub
    Public Sub visibleButtonD()
        btnAjouter.Visible = False
        btnReset.Visible = False
        btnDelete.Visible = True
        btnModifier.Visible = True
        IconButton1.Visible = True

    End Sub
    Public Sub visibleNot()
        btnAjouter.Visible = True
        btnReset.Visible = True
        btnDelete.Visible = False
        btnModifier.Visible = False
        IconButton1.Visible = False
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        valeurController.insertionValeur(boxId.Text, boxMontant.Text, boxDate.Value.ToString)
        chargementElement()
        boxMontant.Clear()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click

        valeurController.updateProduit(boxId.Text, boxMontant.Text, boxDate.Value.ToString, id)
        chargementElement()
        boxMontant.Clear()
        visibleNot()
        comboProduit.Enabled = True
        ' boxId.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        valeurController.deleteValeur(id)
        chargementElement()
        boxMontant.Clear()
        visibleNot()
        comboProduit.Enabled = True
        '  boxId.Enabled = True
    End Sub

    Private Sub DatagridCom_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridCom.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = New DataGridViewRow
            row = DatagridCom.Rows(e.RowIndex)
            ID = row.Cells("id").Value.ToString()
            boxId.Text = row.Cells("produitId").Value.ToString()
            boxMontant.Text = row.Cells("prix").Value.ToString()
            boxDate.Value = row.Cells("valuerDate").Value.ToString()
            chargementNameById()
            comboProduit.Enabled = False
            boxId.Enabled = False
            visibleButtonD()

        End If
    End Sub
    Sub blocageButton()

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        chargementElement()
        boxMontant.Clear()
        visibleNot()
    End Sub

    Private Sub DatagridCom_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridCom.CellContentClick

    End Sub
End Class