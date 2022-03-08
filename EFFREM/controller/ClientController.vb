Public Class ClientController
    Private table As DataTable
    Private loacalManager As New ClientManger



    Private GetClient As New GET_CLIENT



    Public Sub insertionClient(ByVal name As String, ByVal gsm As String, ByVal comm As String)


        If name = "" Or comm = "" Or gsm = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetClient.getName = UCase(name)
            GetClient.getGsm = gsm
            GetClient.getCommNum = comm
            loacalManager.InsertionClient(GetClient)
            MsgBox("le client a ete ajoutee avec succes", MsgBoxStyle.Information)



        End If
    End Sub
    Public Sub UpdateClient(ByVal name As String, ByVal gsm As String, ByVal comm As String, ByVal id As String)


        If name = "" Or comm = "" Or gsm = "" Or id = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetClient.getName = UCase(name)
            GetClient.getGsm = gsm
            GetClient.getIdClient = id
            GetClient.getCommNum = comm
            loacalManager.UpdateClient(GetClient)
            MsgBox("le client a ete Modifier avec succes", MsgBoxStyle.Information)



        End If
    End Sub
    Public Sub deleteClient(ByVal id As String)

        If id = "" Then
            MsgBox("veuillez remplir les champs", MsgBoxStyle.Critical)
        Else
            GetClient.getIdClient = id
            If MsgBox("voulez vous suprimmer ce produit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                loacalManager.DeleteClient(GetClient)
                MsgBox("le cleint  a ete effacer", MsgBoxStyle.Information)
            End If

        End If

    End Sub
    Public Sub chargementClient(ByVal datagrid As DataGridView)
        table = loacalManager.ShowClient
        datagrid.DataSource = table


    End Sub

    Public Sub chargementClientRechere(ByVal rechereche As String, ByVal datagrid As DataGridView)
        GetClient.getName() = rechereche
        table = loacalManager.ShowClientRecherche(GetClient)
        datagrid.DataSource = table


    End Sub
    Public Sub chargementClient(ByVal combo As ComboBox)
        Try
            table = loacalManager.ShowClient()
            If table.Rows.Count > 0 Then
                combo.DataSource = table
                combo.ValueMember = "Name"
                combo.DisplayMember = "Name"

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Function chargementIdClient(ByVal combo As ComboBox) As DataTable
        Try
            GetClient.getName = combo.Text
            table = loacalManager.ShowClientId(GetClient)
            Return table
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function chargementClientCount()
        Try

            table = loacalManager.ShowClientCount()
            Return table.Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function




End Class
