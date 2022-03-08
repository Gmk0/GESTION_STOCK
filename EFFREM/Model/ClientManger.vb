Imports System.Data.SqlClient
Imports System.Data
Public Class ClientManger


    Inherits CONNEXIONBD
        Private command As SqlCommand
        Private requete As String
        Private table As DataTable
        Public adapter As SqlDataAdapter

    Public Sub InsertionClient(ByVal clientC As GET_CLIENT)
        Try
            requete = "insertionClient"
            command = New SqlCommand(requete, GetConnection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@name", clientC.getName)
            command.Parameters.AddWithValue("@gsm", clientC.getGsm)
            command.Parameters.AddWithValue("@com", clientC.getCommNum)



            openConnection()
            command.ExecuteNonQuery()
            closeConnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ShowClient() As DataTable

        Try
            requete = "SELECT * FROM DescClient order by Name"
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

    Public Function ShowClientCount() As DataTable

        Try
            requete = "SELECT count(*) FROM DescClient"
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

    Public Function UpdateClient(ByVal clientC As GET_CLIENT)
        Try
            requete = "updateClient"

            command = New SqlCommand(requete, GetConnection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@id", clientC.getIdClient)
            command.Parameters.AddWithValue("@name", clientC.getName)
            command.Parameters.AddWithValue("@gsm", clientC.getGsm)
            command.Parameters.AddWithValue("@com", clientC.getCommNum)


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

    Public Function DeleteClient(ByVal clientC As GET_CLIENT)
        Try
            requete = "deleteClient"
            command = New SqlCommand(requete, GetConnection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@id", clientC.getIdClient)

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

    'LOCALISATION
    Public Function ShowClientRecherche(ByVal client As GET_CLIENT) As DataTable

        Try
            requete = "SELECT * FROM DescClient where NAME LIKE '%" + client.getName() + "%'"
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
    Public Function ShowClientId(ByVal client As GET_CLIENT) As DataTable

        Try
            requete = "SELECT id FROM DescClient where NAME='" + client.getName() + "'"
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
    ''

    Public Function ShowProduitCount() As DataTable

        Try
            requete = "SELECT count(*) FROM DescProduit"
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

    Public Function ShowProduitCountRupture() As DataTable

        Try
            requete = "SELECT count(*) FROM histostockTot where reste < 10"
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



