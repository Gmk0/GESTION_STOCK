Public Class TransactionController
    Private table As DataTable
    Private getTransac As New GET_TRANSAC
    Private TransacManager As New VentesManger




    Public Sub ajoutPanier(ByVal datagrid As DataGridView, ByVal id As String, ByVal prix As String, ByVal dates As String, ByVal qte As String, ByVal montant As String, ByVal client As String, ByVal transactId As String)
        If id = "" Or prix = "" Or qte = "" Then
            MsgBox("veuillez remplir tous les champs", MsgBoxStyle.Exclamation)
        Else
            Dim n As Integer = datagrid.Rows.Add()
            datagrid.Rows(n).Cells("produitId").Value = id
            datagrid.Rows(n).Cells("qte").Value = qte
            datagrid.Rows(n).Cells("prix").Value = prix
            datagrid.Rows(n).Cells("dates").Value = dates
            datagrid.Rows(n).Cells("montant").Value = montant
            datagrid.Rows(n).Cells("clientId").Value = client
            datagrid.Rows(n).Cells("TransactionId").Value = transactId

        End If
    End Sub

    Public Sub insertionTransac(ByVal datagrid As DataGridView)
        Try
            If datagrid.Rows.Count > 0 Then
                Dim nombre As Integer = Convert.ToInt32(datagrid.Rows.Count)
                Dim i As Integer = 0

                While i < nombre
                    getTransac.getDate = datagrid.Rows(i).Cells("dates").Value.ToString()
                    getTransac.getProduitId = datagrid.Rows(i).Cells("ProduitID").Value.ToString()
                    getTransac.getQte = datagrid.Rows(i).Cells("qte").Value.ToString()
                    getTransac.getClientId = datagrid.Rows(i).Cells("clientId").Value.ToString()
                    getTransac.getMontant = datagrid.Rows(i).Cells("montant").Value.ToString()
                    getTransac.getNum = datagrid.Rows(i).Cells("TransactionId").Value.ToString()
                    getTransac.getPrixId = datagrid.Rows(i).Cells("prix").Value.ToString()
                    TransacManager.insertionTransaction(getTransac)
                    i += 1
                End While
                MsgBox("le stock a ete bien inserer", MsgBoxStyle.Information)
                datagrid.Rows.Clear()
            Else
                MsgBox("la listes de stock est vide", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub ChargementElement(ByVal datagrid As DataGridView, ByVal combo As String)



        table = TransacManager.ShowTransac(Convert.ToInt32(combo))
            datagrid.DataSource = table


    End Sub
    Public Sub ChargementElementDate(ByVal datagrid As DataGridView, ByVal dateDu As String, ByVal dateAu As String)
        table = TransacManager.ShowTransacDate(dateDu, dateAu)
        datagrid.DataSource = table
    End Sub
    Public Sub chargementNumero(ByVal numero As String)
        numero = TransacManager.ShowTransacCount()

    End Sub

End Class
