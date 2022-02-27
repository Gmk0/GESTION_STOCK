Public Class FormCategorie

    Private controlerProduit As New produitController
    Private idCat As String
    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub FormCategorie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargementElement()
    End Sub



    Public Sub chargementElement()
        controlerProduit.showCategorie(DatagridCategorie)


    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        controlerProduit.insertionCatgeor(boxCategorie.Text)
        boxCategorie.Clear()
        chargementElement()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Dim id As String = idCat
        controlerProduit.updateCategorie(boxCategorie.Text, id)
        boxCategorie.Clear()
        chargementElement()
        visibleNot()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As String = idCat
        controlerProduit.deleteCategorie(id)
        boxCategorie.Clear()
        chargementElement()
        visibleNot()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        boxCategorie.Clear()
    End Sub

    Private Sub DatagridCategorie_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = New DataGridViewRow
            row = DatagridCategorie.Rows(e.RowIndex)
            idCat = row.Cells(0).Value.ToString()
            boxCategorie.Text = row.Cells(1).Value.ToString()
            visibleButtonD()

        End If
    End Sub
    Public Sub visibleButtonD()
        btnAjouter.Visible = False
        btnReset.Visible = False
        btnDelete.Visible = True
        btnModifier.Visible = True

    End Sub
    Public Sub visibleNot()
        btnAjouter.Visible = True
        btnReset.Visible = True
        btnDelete.Visible = False
        btnModifier.Visible = False
    End Sub

End Class