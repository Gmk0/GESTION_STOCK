Imports System.Data.SqlClient
Imports System.Data
Public Class ProduitManager
    Inherits CONNEXIONBD
    Private command As SqlCommand
    Private requete As String
    Private table As DataTable
    Public adapter As SqlDataAdapter

    Public Function InsertionProduit(ByVal produitC As GET_Produit)
        Try
            requete = "InsertionProduit"
            command = New SqlCommand(requete, GetConnection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@nom", produitC.getProduit)
            command.Parameters.AddWithValue("@seuil", produitC.getSeuilRupture)
            command.Parameters.AddWithValue("@desc", produitC.getDescription)
            command.Parameters.AddWithValue("@categ", produitC.getCategorie)

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

    Public Function ShowProduit() As DataTable

        Try
            requete = "SELECT * FROM DescProduit order by Name"
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



    Public Function updateProduit(ByVal produitC As GET_Produit)
        Try
            requete = "updateProduit"

            command = New SqlCommand(requete, GetConnection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@id", produitC.getIdproduit)
            command.Parameters.AddWithValue("@nom", produitC.getProduit)
            command.Parameters.AddWithValue("@seuil", produitC.getSeuilRupture)
            command.Parameters.AddWithValue("@desc", produitC.getDescription)
            command.Parameters.AddWithValue("@cate", produitC.getCategorie)

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

    Public Function deleteProduit(ByVal produitC As GET_Produit)
        Try
            requete = "deleteProduit"
            command = New SqlCommand(requete, GetConnection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@id", produitC.getIdproduit)

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
    Public Function ShowProduitRecherche(ByVal produit As GET_Produit) As DataTable

        Try
            requete = "SELECT * FROM DescProduit where NAME LIKE '%" + produit.getProduit() + "%'"
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
    Public Function ShowIdProduit(ByVal GetP As GET_Produit) As DataTable

        Try
            requete = "SELECT ID FROM DescProduit where name='" + GetP.getProduit + "'"
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
    Public Function ShowIdProduitByName(ByVal GetP As GET_Produit) As DataTable

        Try
            requete = "SELECT name FROM DescProduit where id='" + GetP.getIdproduit + "'"
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
    'Categorie

    Public Function ShowCategorie() As DataTable

        Try
            requete = "SELECT * FROM EnumCategories order by num"
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
    Public Function ShowCategorie(ByVal GetP As GET_Produit) As DataTable

        Try
            requete = "SELECT num FROM EnumCategories where name='" + GetP.getCategorie + "'"
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

    Public Sub InsertionCategorei(ByVal produitC As GET_Produit)
        Try
            requete = "insert into enumCategories(name) values(@name)"
            command = New SqlCommand(requete, GetConnection)

            command.Parameters.AddWithValue("@name", produitC.getCategorie)
            openConnection()
            command.ExecuteNonQuery()
            closeConnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'mise a jour categories
    Public Sub updateCategorie(ByVal produitC As GET_Produit)
        Try
            requete = "update Enumcategories set name=@name where num=@num"
            command = New SqlCommand(requete, GetConnection)

            command.Parameters.AddWithValue("@name", produitC.getCategorie)
            command.Parameters.AddWithValue("@num", produitC.getINumCate)
            openConnection()
            command.ExecuteNonQuery()
            closeConnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub deleteCategorie(ByVal produitC As GET_Produit)
        Try
            requete = "delete from enumcategories where num=@num"
            command = New SqlCommand(requete, GetConnection)

            command.Parameters.AddWithValue("@num", produitC.getINumCate)
            openConnection()
            command.ExecuteNonQuery()
            closeConnection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
