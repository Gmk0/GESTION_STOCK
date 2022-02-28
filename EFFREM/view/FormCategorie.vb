Public Class FormCategorie

    Private controlerProduit As New produitController
    Private idCat As String
    Private otherControl As New AutresControl
    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub FormCategorie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargementElement()
        ShowbUtton()
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

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        visibleNot()
        boxCategorie.Clear()
    End Sub
    Private Sub ShowbUtton()
        otherControl.AjoutButtonn(DatagridCategorie)
    End Sub

    Private Sub DatagridCategorie_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridCategorie.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DatagridCategorie.Columns("MODIFICATION").Index Then
            Dim row As DataGridViewRow = New DataGridViewRow
            row = DatagridCategorie.Rows(e.RowIndex)
            idCat = row.Cells("Num").Value.ToString()
            boxCategorie.Text = row.Cells("Name").Value.ToString()
            visibleButtonD()

        End If
    End Sub
End Class