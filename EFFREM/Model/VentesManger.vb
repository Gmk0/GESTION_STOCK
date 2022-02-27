Imports System.Data.SqlClient
Imports System.Data
Public Class VentesManger
    Inherits CONNEXIONBD
    Private command As SqlCommand
    Private requete As String
    Private table As DataTable
    Public adapter As SqlDataAdapter

    Public Function ShowTransac(ByVal top As Integer) As DataTable

        Try
            requete = "SELECT Top(@top)  * FROM histoTransaction"
            command = New SqlCommand(requete, GetConnection)
            command.Parameters.AddWithValue("@top", top)
            adapter = New SqlDataAdapter(command)
            table = New DataTable()
            adapter.Fill(table)
            Return table

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function ShowTransacCount()

        Try
            requete = "SELECT max(TransactionNum) FROM histoTransaction"
            command = New SqlCommand(requete, GetConnection)

            adapter = New SqlDataAdapter(command)
            table = New DataTable()
            adapter.Fill(table)
            Dim numFact As Integer = table.Rows(0)(0)
            Dim num As Integer = numFact
            num += 1
            Return num.ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function ShowTransacDate(ByVal dateDu As String, ByVal dateAu As String) As DataTable

        Try
            requete = "SELECT * FROM HistoTransaction where TransactionDate between '" + dateDu + "' and '" + dateAu + "'"
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

    Public Function insertionTransaction(ByVal GetTransac As GET_TRANSAC)
        Try
            requete = "insertionTransaction"

            command = New SqlCommand(requete, GetConnection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@transacNum", GetTransac.getNum)
            command.Parameters.AddWithValue("@transacDate", GetTransac.getDate)
            command.Parameters.AddWithValue("@qte", GetTransac.getQte)
            command.Parameters.AddWithValue("@montant", GetTransac.getMontant)
            command.Parameters.AddWithValue("@produitId", GetTransac.getProduitId)
            command.Parameters.AddWithValue("@clientId", GetTransac.getClientId)
            command.Parameters.AddWithValue("@prixId", GetTransac.getPrixId)


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
End Class
