
Public Class produitController
    Private table As DataTable
    Private loacalProduit As New ProduitManager
    Private GetProduit As New GET_Produit


    Public Sub insertionProduit(ByVal name As String, ByVal seuil As String, ByVal desc As String, ByVal cat As String)


        If name = "" Or seuil = "" Or cat = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetProduit.getProduit = UCase(name)
            GetProduit.getDescription = desc
            GetProduit.getSeuilRupture = seuil
            GetProduit.getCategorie = cat

            If loacalProduit.InsertionProduit(GetProduit) = True Then
                MsgBox("le Produit a ete ajoutee avec succes", MsgBoxStyle.Information, "REUSSITE")
            End If




        End If
    End Sub
    Public Sub updateProduit(ByVal name As String, ByVal seuil As String, ByVal desc As String, ByVal cat As String, ByVal id As String)


        If name = "" Or seuil = "" Or cat = "" Or id = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetProduit.getProduit = UCase(name)
            GetProduit.getDescription = desc
            GetProduit.getSeuilRupture = seuil
            GetProduit.getCategorie = cat
            GetProduit.getIdproduit = id

            loacalProduit.updateProduit(GetProduit)
            MsgBox("le Produit a ete modifier avec succes", MsgBoxStyle.Information, "REUSSITE")



        End If
    End Sub
    Public Sub deleteProduit(ByVal id As String)

        If id = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetProduit.getIdproduit = id
            If MsgBox("voulez vous suprimmer ce produit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                loacalProduit.deleteProduit(GetProduit)
                MsgBox("le produit  a ete effacer", MsgBoxStyle.Information)
            End If

        End If

    End Sub
    Public Sub ShowProduit(ByVal datagrid As DataGridView)
        table = loacalProduit.ShowProduit
        datagrid.DataSource = table

    End Sub
    Public Sub chargementProduit(ByVal rechereche As String, ByVal datagrid As DataGridView)
        GetProduit.getProduit = rechereche
        table = loacalProduit.ShowProduitRecherche(GetProduit)
        datagrid.DataSource = table


    End Sub
    Public Sub ChargementProduit(ByVal combo As ComboBox)
        table = loacalProduit.ShowProduit()
        If table.Rows.Count > 0 Then
            combo.DataSource = table
            combo.ValueMember = "Name"
            combo.DisplayMember = "Name"

        End If
    End Sub
    Public Function chargementID(ByVal combo As ComboBox) As DataTable
        Try
            GetProduit.getProduit = combo.Text
            table = loacalProduit.ShowIdProduit(GetProduit)
            Return table
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function chargementNameById(ByVal id As String) As DataTable
        Try
            GetProduit.getIdproduit = id
            table = loacalProduit.ShowIdProduitByName(GetProduit)
            Return table
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    'CAEGORIE

    Public Sub chargementCategorie(ByVal combo As ComboBox)
        table = loacalProduit.ShowCategorie()
        If table.Rows.Count > 0 Then
            combo.DataSource = table
            combo.ValueMember = "Name"
            combo.DisplayMember = "Name"

        End If
    End Sub

    Public Sub showCategorie(ByVal datagrid As DataGridView)
        table = loacalProduit.ShowCategorie
        datagrid.DataSource = table
    End Sub

    Public Sub insertionCatgeor(ByVal name As String)


        If name = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetProduit.getCategorie = name

            loacalProduit.InsertionCategorei(GetProduit)
            MsgBox("le Produit a ete ajoutee avec succes", MsgBoxStyle.Information, "REUSSITE")




        End If
    End Sub
    Public Sub updateCategorie(ByVal name As String, ByRef id As String)


        If name = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetProduit.getCategorie = name
            GetProduit.getINumCate = id

            loacalProduit.updateCategorie(GetProduit)
            MsgBox("le Produit a ete ajoutee avec succes", MsgBoxStyle.Information, "REUSSITE")



        End If
    End Sub
    Public Sub deleteCategorie(ByVal id As String)

        If id = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetProduit.getINumCate = id
            If MsgBox("voulez vous suprimmer cette Categorie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                loacalProduit.deleteCategorie(GetProduit)
                MsgBox("la categorie a ete effacer", MsgBoxStyle.Information, "EFFACEMENT")
            End If

        End If

    End Sub

End Class
