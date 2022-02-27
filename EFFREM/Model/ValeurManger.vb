Imports System.Data.SqlClient
Imports System.Data
Public Class ValeurManger


    Inherits CONNEXIONBD
    Private command As SqlCommand
    Private requete As String
    Private table As DataTable
    Public adapter As SqlDataAdapter

    Public Function insertionValeur(ByVal GetValeur As GET_Valeur)
        Try
            requete = "insertionValeur"

            command = New SqlCommand(requete, GetConnection)
            command.CommandType = CommandType.StoredProcedure


            command.Parameters.AddWithValue("@prix", GetValeur.getPrix)
            command.Parameters.AddWithValue("@date", GetValeur.getDate)
            command.Parameters.AddWithValue("@produit", GetValeur.getProduitId)

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
    Public Function UpdateValeur(ByVal GetValeur As GET_Valeur)
        Try
            requete = "update histoValeur Set prix=@prix,valuerDate=@date,produitId=@produitId where Id=@id"

            command = New SqlCommand(requete, GetConnection)


            command.Parameters.AddWithValue("@id", GetValeur.getId)
            command.Parameters.AddWithValue("@prix", GetValeur.getPrix)
            command.Parameters.AddWithValue("@date", GetValeur.getDate)
            command.Parameters.AddWithValue("@produitId", GetValeur.getProduitId)

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

    Public Function deleteValeur(ByVal GetValeur As GET_Valeur)
        Try
            requete = "delete from histoValeur where Id=@id"

            command = New SqlCommand(requete, GetConnection)
            command.Parameters.AddWithValue("@id", GetValeur.getId)
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

    Public Function ShowValeur() As DataTable

        Try
            requete = "SELECT top(150)* FROM histoValeur"
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
    Public Function ShowValeur(ByVal GetValeur As GET_Valeur) As DataTable

        Try
            requete = "SELECT id,prix From HistoValeur where ProduitId in (SELECT id FROM DescProduit where Name=@name) order by valuerDate desc"
            command = New SqlCommand(requete, GetConnection)

            command.Parameters.AddWithValue("@name", GetValeur.getProduitId)

            adapter = New SqlDataAdapter(command)
            table = New DataTable()
            adapter.Fill(table)
            Return table

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


    Public Function ShowValeurId(ByVal GetValeur As GET_Valeur) As DataTable



    End Function


End Class
