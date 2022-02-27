Imports System.Data.SqlClient
Imports System.Data
Public Class CommuneVilleManager
    Inherits CONNEXIONBD
    Private command As SqlCommand
    Private requete As String
    Private table As DataTable
    Public adapter As SqlDataAdapter

    Public Function insertionVille(ByVal loc As GET_Local)
        Try

            requete = "INSERT INTO enumVille(name) values(@name)"
            command = New SqlCommand(requete, GetConnection)
            command.Parameters.AddWithValue("@name", loc.getVilleName)
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
    Public Function UpdateVille(ByVal loc As GET_Local)
        Try

            requete = "UPDATE enumVille SET name=@name where num=@num"
            command = New SqlCommand(requete, GetConnection)
            command.Parameters.AddWithValue("@name", loc.getVilleName)
            command.Parameters.AddWithValue("@num", loc.getVilleNum)
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
    Public Function deleteVille(ByVal loc As GET_Local)
        Try

            requete = "DELETE FROM enumVille where num=@num"
            command = New SqlCommand(requete, GetConnection)
            command.Parameters.AddWithValue("@num", loc.getVilleNum)
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
    Public Function ShowVille()
        Try
            requete = "select * from enumVille"
            command = New SqlCommand(requete, GetConnection)
            adapter = New SqlDataAdapter(command)
            table = New DataTable
            adapter.Fill(table)
            Return table

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function ShowVilleName()
        Try
            requete = "select name from enumVille"
            command = New SqlCommand(requete, GetConnection)
            adapter = New SqlDataAdapter(command)
            table = New DataTable
            adapter.Fill(table)
            Return table

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function ShowVilleByName(ByVal loc As GET_Local)
        Try
            requete = "select num from enumVille where name =@name"
            command = New SqlCommand(requete, GetConnection)
            command.Parameters.AddWithValue("@name", loc.getVilleName)
            adapter = New SqlDataAdapter(command)
            table = New DataTable
            adapter.Fill(table)
            Return table

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function ShowVilleByNum(ByVal loc As GET_Local)
        Try
            requete = "select name from enumVille where num=@num"
            command = New SqlCommand(requete, GetConnection)
            command.Parameters.AddWithValue("@num", loc.getComNum)
            adapter = New SqlDataAdapter(command)
            table = New DataTable
            adapter.Fill(table)
            Return table

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


    Public Function insertionCommune(ByVal loc As GET_Local)
        Try

            requete = "INSERT INTO enumCommune(Name,villeNum) values(@name,@villeNum)"
            command = New SqlCommand(requete, GetConnection)
            command.Parameters.AddWithValue("@name", loc.getComName)
            command.Parameters.AddWithValue("@villeNum", loc.getVilleNum)
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
    Public Function UpdateCommune(ByVal loc As GET_Local)
        Try

            requete = "Update EnumCommune SET name=@name ,villeNum=@ville where num=@num"
            command = New SqlCommand(requete, GetConnection)
            command.Parameters.AddWithValue("@num", loc.getComNum)
            command.Parameters.AddWithValue("@name", loc.getComName)
            command.Parameters.AddWithValue("@ville", loc.getVilleNum)
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
    Public Function deleteCommune(ByVal loc As GET_Local)
        Try

            requete = "DELETE FROM enumCommune where num=@num"
            command = New SqlCommand(requete, GetConnection)
            command.Parameters.AddWithValue("@num", loc.getComNum)


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
    Public Function ShowCommune()
        Try
            requete = "select * from enumcommune"
            command = New SqlCommand(requete, GetConnection)
            adapter = New SqlDataAdapter(command)
            table = New DataTable
            adapter.Fill(table)
            Return table

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function ShowCommuneByVille(ByVal loc As GET_Local)
        Try
            requete = "select * from enumcommune where villeNum in(select num from enumVille where name = @name)"
            command = New SqlCommand(requete, GetConnection)
            command.Parameters.AddWithValue("@name", loc.getVilleName)
            adapter = New SqlDataAdapter(command)
            table = New DataTable
            adapter.Fill(table)
            Return table

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function showComuneByName(ByVal loc As GET_Local)
        Try
            requete = "select num from enumCommune where name ='" + loc.getComName + "'"
            command = New SqlCommand(requete, GetConnection)
            adapter = New SqlDataAdapter(command)
            table = New DataTable
            adapter.Fill(table)
            Return table

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


End Class
