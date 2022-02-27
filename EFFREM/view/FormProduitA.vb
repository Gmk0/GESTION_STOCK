Public Class FormProduitA
    Public manager As New ProduitManager()
    Private controlerProduit As New produitController
    Private otherControl As New AutresControl
    Dim table As New DataTable

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Dim Forma As New FormAjoutB
        Forma.ShowDialog()
    End Sub

    Private Sub FormClientA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargemntElement()

    End Sub


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim Forma As New FormAjoutB
        Forma.ShowDialog()
    End Sub

    Private Sub chargementNombre()
        If DatagridProduit.RowCount > 0 Then
            Dim nbre As Integer = Convert.ToInt32(DatagridProduit.Rows.Count)
            If nbre <= 1 Then
                LabelProd.Text = "Nombre de Produit:" + DatagridProduit.Rows.Count.ToString()
                LabelProd.ForeColor = Color.Black
            Else
                LabelProd.Text = "Nombre des Produits:" + DatagridProduit.Rows.Count.ToString()
                LabelProd.ForeColor = Color.Black
            End If
        Else


            LabelProd.Text = "Produit non trouvee"
            LabelProd.ForeColor = Color.Red


        End If
    End Sub
    Private Sub Recherche()




    End Sub
    Private Sub ChargemntElement()
        controlerProduit.ShowProduit(DatagridProduit)
        otherControl.AjoutButtonn(DatagridProduit)
        chargementNombre()

    End Sub

    Private Sub TextBoxRech_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRech.TextChanged

        controlerProduit.chargementProduit(TextBoxRech.Text, DatagridProduit)
        chargementNombre()



    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        DatagridProduit.Columns.Clear()

        ChargemntElement()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DatagridProduit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridProduit.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DatagridProduit.Columns("MODIFICATION").Index Then
            Dim row As DataGridViewRow = New DataGridViewRow()
            row = DatagridProduit.Rows(e.RowIndex)
            Dim form As New FormAjoutB
            form.boxId.Text = row.Cells("id").Value.ToString()
            form.boxLibelle.Text = row.Cells("Name").Value.ToString()
            form.boxSeuil.Text = row.Cells("seuilRuture").Value.ToString()
            form.boxDesc.Text = row.Cells("description").Value.ToString()
            form.boxCat.Text = row.Cells("categoryNum").Value.ToString()
            form.boxId.Visible = True
            form.boxCat.Visible = True
            form.LabelId.Visible = True
            form.visibleButtonD()
            form.ShowDialog()


        End If
    End Sub
End Class