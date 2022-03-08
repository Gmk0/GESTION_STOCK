Public Class StockControler
    Private table As DataTable
    Private stockManager As New StockManager
    Private GetClient As New GET_HISTO




    Public Sub ajoutPanier(ByVal datagrid As DataGridView, ByVal id As String, ByVal prix As String, ByVal dates As String, ByVal qte As String)
        If id = "" Or prix = "" Or qte = "" Then
            MsgBox("veuillez remplir tous les champs", MsgBoxStyle.Exclamation)
        Else
            Dim n As Integer = datagrid.Rows.Add()
            datagrid.Rows(n).Cells("produitId").Value = id
            datagrid.Rows(n).Cells("qte").Value = qte
            datagrid.Rows(n).Cells("prix").Value = prix
            datagrid.Rows(n).Cells("dateP").Value = dates


        End If


    End Sub
    Public Sub insertionStock(ByVal datagrid As DataGridView)
        Try
            If datagrid.Rows.Count > 0 Then
                Dim nombre As Integer = Convert.ToInt32(datagrid.Rows.Count)
                Dim i As Integer = 0

                While i < nombre
                    GetClient.getDate = datagrid.Rows(i).Cells("dateP").Value.ToString()
                    GetClient.getProduitId = datagrid.Rows(i).Cells("ProduitID").Value.ToString()
                    GetClient.getQte = datagrid.Rows(i).Cells("qte").Value.ToString()
                    GetClient.getPrix = datagrid.Rows(i).Cells("prix").Value.ToString()
                    stockManager.insertionStock(GetClient)
                    i += 1
                End While
                MsgBox("le stock a ete bien inserer", MsgBoxStyle.Information)

            Else
                MsgBox("la liste de stock est vide", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub ShowStock(ByVal datagrid As DataGridView, ByVal top As String)
        table = stockManager.ShowStock(top)
        datagrid.DataSource = table
    End Sub
    Public Sub ShowStockDate(ByVal datagrid As DataGridView, ByVal dateDu As String, ByVal dateAu As String)
        table = stockManager.ShowStockDate(dateDu, dateAu)
        datagrid.DataSource = table
    End Sub

    Public Sub ShowStockTot(ByVal datagrid As DataGridView, ByVal top As String)
        table = stockManager.ShowStockTotal(top)
        datagrid.DataSource = table
    End Sub

    Public Sub chargementProduit(ByVal rechereche As String, ByVal datagrid As DataGridView)

        table = stockManager.ShowProduitRecherche(rechereche)
        datagrid.DataSource = table


    End Sub

End Class
