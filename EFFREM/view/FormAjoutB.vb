Public Class FormAjoutB
    Private controlsProduit As New produitController
    Private idCategorie As String
    Private Sub FormAjoutB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargementElement()
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

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim idb As String = idCategorie
        controlsProduit.insertionProduit(boxLibelle.Text, boxSeuil.Text, boxDesc.Text, idb)
        clean()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        controlsProduit.updateProduit(boxLibelle.Text, boxSeuil.Text, boxDesc.Text, boxCat.Text, boxId.Text)
        clean()
        visibleButtonD()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        controlsProduit.deleteProduit(boxId.Text)
        clean()
        visibleButtonD()
    End Sub
    Sub clean()
        boxId.Clear()
        boxLibelle.Clear()
        boxSeuil.Clear()
        boxCat.Clear()
        boxDesc.Clear()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clean()
    End Sub

    Sub chargementElement()
        controlsProduit.chargementCategorie(comboCategorie)
    End Sub
    Sub charmentIdCateg()
        Try
            Dim localManager As New ProduitManager
            Dim GetProduit As New GET_Produit
            GetProduit.getCategorie = comboCategorie.Text
            Dim table As DataTable = localManager.ShowCategorie(GetProduit)
            If table.Rows.Count > 0 Then
                idCategorie = table.Rows(0)(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub comboCategorie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCategorie.SelectedIndexChanged
        charmentIdCateg()
    End Sub
End Class