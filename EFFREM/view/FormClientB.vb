Public Class FormClientB
    Public controlClient As New ClientController
    Public controlCommune As New CommunController
    Public id As String

    Private table As DataTable
    Private Sub FormClientB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargementElement()
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

        controlClient.insertionClient(boxName.Text, boxGsm.Text, boxC.Text)
        clean()

    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Dim idClient As String = id
        controlClient.UpdateClient(boxName.Text, boxGsm.Text, boxC.Text, id)
        clean()
    End Sub

    Sub clean()
        boxGsm.Clear()
        boxName.Clear()
        boxC.Clear()

    End Sub
    Public Sub visibleButtonD()
        btnAjouter.Visible = False
        btnReset.Visible = False
        btnDelete.Visible = True
        btnModifier.Visible = True
        IconButton1.Visible = True

    End Sub
    Public Sub visibleNot()
        btnAjouter.Visible = True
        btnReset.Visible = True
        btnDelete.Visible = False
        btnModifier.Visible = False
        IconButton1.Visible = False
    End Sub
    Public Sub chargementElement()
        controlCommune.chargementVilleNum(comboVille)

    End Sub
    Public Sub chargementCommune()
        controlCommune.chargementCommune(comboCommune, comboVille.Text)
    End Sub

    Private Sub comboCommune_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCommune.SelectedIndexChanged
        comm()

    End Sub

    Public Sub comm()

        table = controlCommune.shoWComune(comboCommune)
        If table.Rows.Count > 0 Then
            boxC.Text = table.Rows(0)(0)
        End If

    End Sub
    Private Sub boxC_TextChanged(sender As Object, e As EventArgs) Handles boxC.TextChanged

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim idClient As String = id
        controlClient.deleteClient(idClient)
        clean()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub comboVille_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboVille.SelectedIndexChanged
        chargementCommune()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        visibleNot()
        clean()
    End Sub
End Class