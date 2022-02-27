Public Class FormStock
    Private controlProduit As New produitController
    Private controlStock As New StockControler
    Private Table As New DataTable
    Private Sub FormStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargementElement()
    End Sub
    Private Sub chargementElement()
        controlProduit.ChargementProduit(comboProduit)
    End Sub
    Public Sub chargmentElemetId()
        Table = controlProduit.chargementID(comboProduit)
        If Table.Rows.Count > 0 Then
            boxId.Text = Table.Rows(0)("id")
        End If
    End Sub


    Private Sub comboProduit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProduit.SelectedIndexChanged

        chargmentElemetId()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        controlStock.ajoutPanier(DatagridProduit, boxId.Text, boxMontant.Text, boxDate.Value.ToString(), boxQte.Text)
        clean()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        controlStock.insertionStock(DatagridProduit)
        DatagridProduit.Rows.Clear()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        If DatagridProduit.Rows.Count > 0 Then
            DatagridProduit.Rows.RemoveAt(DatagridProduit.CurrentRow.Index)
        End If

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        clean()
        DatagridProduit.Rows.Clear()
    End Sub
    Sub clean()
        boxMontant.Clear()
        boxQte.Clear()

    End Sub
End Class