Public Class ValeurController
    Private table As DataTable
    Private valeurManger As New ValeurManger
    Private GetValeur As New GET_Valeur


    Public Sub insertionValeur(ByVal idProduit As String, ByVal prix As String, ByVal dates As String)

        If idProduit = "" Or prix = "" Then
            MsgBox("veuillez remplir tous les champs ", MsgBoxStyle.Exclamation)
        Else
            GetValeur.getPrix = prix
            GetValeur.getDate = dates
            GetValeur.getProduitId = idProduit
            If valeurManger.insertionValeur(GetValeur) = True Then
                MsgBox("la nouvelle valeur a ete ajouter", MsgBoxStyle.Information)
            End If

        End If

    End Sub
    Public Sub updateProduit(ByVal idProduit As String, ByVal prix As String, ByVal dates As String, ByVal id As String)

        If idProduit = "" Or prix = "" Then
            MsgBox("veuillez remplir tous les champs ", MsgBoxStyle.Exclamation)
        Else
            GetValeur.getId = id
            GetValeur.getPrix = prix
            GetValeur.getDate = dates
            GetValeur.getProduitId = idProduit
            If valeurManger.UpdateValeur(GetValeur) = True Then
                MsgBox("la valeur a ete Modifier avec Success", MsgBoxStyle.Information)
            End If

        End If

    End Sub
    Public Sub deleteValeur(ByVal id As String)

        If id = "" Then
            MsgBox("veuillez remplir tous les champs ", MsgBoxStyle.Exclamation)
        Else
            GetValeur.getId = id

            If valeurManger.deleteValeur(GetValeur) = True Then
                MsgBox("la valeur a ete effecer avec Success", MsgBoxStyle.Information)
            End If

        End If

    End Sub

    Public Sub showValeur(ByVal datagrid As DataGridView)
        table = valeurManger.showValeur()
        datagrid.DataSource = table

    End Sub

    Public Function showValeur(ByVal combo As ComboBox) As DataTable
        Try
            GetValeur.getProduitId = combo.Text
            table = valeurManger.ShowValeur(GetValeur)
            Return table
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

End Class
