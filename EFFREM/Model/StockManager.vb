Imports System.Data.SqlClient
Imports System.Data
Public Class StockManager
    Inherits CONNEXIONBD

    Private command As SqlCommand
    Private requete As String
    Private table As DataTable
    Public adapter As SqlDataAdapter


    Public Function insertionStock(ByVal GetHisto As GET_HISTO)
        Try
            requete = "insertionStock"

            command = New SqlCommand(requete, GetConnection)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@qte", GetHisto.getQte)
            command.Parameters.AddWithValue("@prix", GetHisto.getPrix)
            command.Parameters.AddWithValue("@date", GetHisto.getDate)
            command.Parameters.AddWithValue("@produitId", GetHisto.getProduitId)

            openConnection()
            If command.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            closeConnection()
        End Try

    End Function

    Public Function ShowStock(ByVal top As String) As DataTable

        Try
            requete = "SELECT TOP (@top)HistoStock.Id,name as'PRODUIT',qte as'QUANTITE',PRIX,stockDate as 'DATE' FROM histoStock inner join DescProduit on descProduit.id=histoStock.ProduitId"
            command = New SqlCommand(requete, GetConnection)
            adapter = New SqlDataAdapter(command)
            command.Parameters.AddWithValue("@top", Convert.ToInt32(top))
            table = New DataTable()
            adapter.Fill(table)
            Return table

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function ShowStockTotal(ByVal top As String) As DataTable

        Try
            requete = "SELECT TOP (@top)Produit as'PRODUIT',seuilRupture,Reste,ProduitId FROM histoStockTot order by produit"
            command = New SqlCommand(requete, GetConnection)
            adapter = New SqlDataAdapter(command)
            command.Parameters.AddWithValue("@top", Convert.ToInt32(top))
            table = New DataTable()
            adapter.Fill(table)
            Return table

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function ShowStockDate(ByVal dateDu As String, ByVal dateAu As String) As DataTable

        Try
            requete = "SELECT HistoStock.Id,name as'PRODUIT',qte as'QUANTITE',PRIX,stockDate as 'DATE' FROM histoStock inner join DescProduit on descProduit.id=histoStock.ProduitId  where stockDate between '" + dateDu + "' and '" + dateAu + "' order by StockDate"
            command = New SqlCommand(requete, GetConnection)
            adapter = New SqlDataAdapter(command)
            table = New DataTable()
            adapter.Fill(table)
            Return table

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
End Class
