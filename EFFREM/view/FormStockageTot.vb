Public Class FormStockageTot
    Private controlStock As New StockControler
    Private Sub FormStockageTot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub chargementElement()
        Cursor = Cursors.WaitCursor
        controlStock.ShowStockTot(DatagridProduit, Guna2ComboBox1.Text)
        Label5.Text = ""
        Cursor = Cursors.Default
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        chargementElement()
    End Sub
End Class