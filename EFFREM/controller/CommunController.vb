Public Class CommunController
    Public table As DataTable
    Public loacalManager As New CommuneVilleManager
    Public GetLocal As New GET_Local

    Public Sub insertionVille(ByVal ville As String)


        If ville = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetLocal.getVilleName = ville
            loacalManager.insertionVille(GetLocal)
            MsgBox("la ville" + ville + " a ete ajoutee avec succes", MsgBoxStyle.Information)



        End If
    End Sub
    Public Sub updateVille(ByVal ville As String, ByVal villeNum As String)


        If ville = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetLocal.getVilleName = ville
            GetLocal.getVilleNum = villeNum
            loacalManager.UpdateVille(GetLocal)
            MsgBox("la ville " + ville + " a ete  Modifier", MsgBoxStyle.Information)



        End If
    End Sub
    Public Sub deleteVille(ByVal villeNum As String)

        If villeNum = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetLocal.getVilleNum = villeNum
            If MsgBox("voulez vous suprimmer ce produit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                loacalManager.deleteVille(GetLocal)
                MsgBox("la ville a ete effacer", MsgBoxStyle.Information)
            End If

        End If

    End Sub
    Public Sub insertionCommune(ByVal commune As String, ByVal boxNum As String)


        If commune = "" Or boxNum = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetLocal.getComName = commune
            GetLocal.getVilleNum = boxNum
            loacalManager.insertionCommune(GetLocal)
            MsgBox("la ville  " + commune + " a ete ajoutee avec succes", MsgBoxStyle.Information)



        End If
    End Sub
    'Delete COMMUNE
    Public Sub deleteCommune(ByVal comNum As String)

        If comNum = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetLocal.getComNum = comNum
            If MsgBox("voulez vous suprimmer cette commune", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                loacalManager.deleteCommune(GetLocal)
                MsgBox("la commune a ete effacer", , MsgBoxStyle.Information)
            End If

        End If

    End Sub
    'UpdateCommune
    Public Sub updateCommune(ByVal commune As String, ByVal villeNum As String, ByVal comNum As String)


        If commune = "" Or comNum = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetLocal.getComName = commune
            GetLocal.getVilleNum = villeNum
            GetLocal.getComNum = comNum
            loacalManager.UpdateCommune(GetLocal)
            MsgBox("la commune  a ete  Modifier", MsgBoxStyle.Information)



        End If
    End Sub

    Public Sub chargemrntCommune(ByVal datagrid As DataGridView)
        table = loacalManager.ShowCommune()
        datagrid.DataSource = table
    End Sub
    Public Sub chargementVille(ByVal datagrid As DataGridView)
        table = loacalManager.ShowVille()
        datagrid.DataSource = table

    End Sub


    Public Sub chargementVilleNum(ByVal combo As ComboBox)
        table = loacalManager.ShowVille()
        If table.Rows.Count > 0 Then
            combo.DataSource = table
            combo.ValueMember = "Name"
            combo.DisplayMember = "Name"

        End If
    End Sub
    Public Sub chargementCommune(ByVal combo As ComboBox, ByVal ville As String)
        GetLocal.getVilleName = ville
        table = loacalManager.ShowCommuneByVille(GetLocal)
        If table.Rows.Count > 0 Then
            combo.DataSource = table
            combo.ValueMember = "Name"
            combo.DisplayMember = "Name"

        End If

    End Sub
    Public Function boxC(ByVal combo As ComboBox) As DataTable
        Try
            GetLocal.getVilleName = combo.Text
            table = loacalManager.ShowVilleByName(GetLocal)
            Return table
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function showNameVille(ByVal num As String) As DataTable
        Try
            GetLocal.getComNum = num
            table = loacalManager.ShowVilleByNum(GetLocal)
            Return table
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function shoWComune(ByVal combo As ComboBox) As DataTable
        Try
            GetLocal.getComName = combo.Text
            table = loacalManager.showComuneByName(GetLocal)
            Return table
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
