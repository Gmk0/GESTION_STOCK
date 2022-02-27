Public Class FormTransaction
    Private controlProduit As New produitController
    Private ValeurControl As New ValeurController
    Private clientControler As New ClientController
    Private transactionControler As New TransactionController
    Dim Table As DataTable
    Private IdProduit As String
    Private idClient As String
    Private idPrix As String
    Private Sub FormTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chargementElement()

    End Sub

    Private Sub chargementElement()
        controlProduit.ChargementProduit(comboProduit)
        clientControler.chargementClient(comboClient)
    End Sub
   
    Private Sub chargemetId()
        Table = controlProduit.chargementID(comboProduit)
        If Table.Rows.Count > 0 Then
            IdProduit = Table.Rows(0)("id")
        End If
    End Sub
    Private Sub chargemetIdClient()
        Table = clientControler.chargementIdClient(comboClient)
        If Table.Rows.Count > 0 Then
            Idclient = Table.Rows(0)("id")
        End If
    End Sub
    Private Sub chargemetnPrix()

        Table = ValeurControl.showValeur(comboProduit)
        If Table.Rows.Count > 0 Then
            boxPrixValue.Text = Table.Rows(0)("prix")
            idPrix = Table.Rows(0)("id")
        Else
            boxPrixValue.Text = "0"
        End If
    End Sub

    Private Sub comboProduit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProduit.SelectedIndexChanged
        chargemetnPrix()
        chargemetId()
    End Sub

    Private Sub comboClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboClient.SelectedIndexChanged
        chargemetIdClient()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim idProd As String = IdProduit
        Dim idclient2 As String = idClient
        Dim IdPrix2 As String = idPrix
        transactionControler.ajoutPanier(DatagridProduit, IdProduit, IdPrix2, boxdates.Value.ToString, boxQte.Text, boxMontant.Text, idclient2, TransacNum.Text)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        transactionControler.insertionTransac(DatagridProduit)

    End Sub

    Public Sub chargemenTElementNum()
        transactionControler.chargementNumero(TransacNum.Text)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        chargemenTElementNum()
    End Sub
End Class