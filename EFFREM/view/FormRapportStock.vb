Public Class FormRapportStock
    ' Private controlProduit As New produitController
    Private controlStock As New StockControler
    Private Table As New DataTable
    Private Sub FormRapportStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chargementElement()
        Cursor = Cursors.WaitCursor
        controlStock.ShowStock(DatagridProduit, Guna2ComboBox1.Text)

        Cursor = Cursors.Default
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Cursor = Cursors.WaitCursor
        controlStock.ShowStockDate(DatagridProduit, dateDu.Value.ToString("yyyy/MM/dd"), dateAu.Value.ToString("yyyy/MM/dd"))
        Cursor = Cursors.Default
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        chargementElement()
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        chargementElement()
    End Sub

    Private Sub dateDu_ValueChanged(sender As Object, e As EventArgs) Handles dateDu.ValueChanged

    End Sub
End Class