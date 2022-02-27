Public Class FormCommune
    Public table As DataTable
    Public loacalManager As New CommuneVilleManager
    Public GetLocal As New GET_Local
    Public Control As New CommunController
    Public villeNum As String
    Public CommuNum As String
    Private Sub FormCommune_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargementEleement()
    End Sub

    Private Sub chargementEleement()
        Control.chargementVille(DatagridVille)
        Control.chargementVilleNum(comboVille)
        Control.chargemrntCommune(DatagridCom)




    End Sub

    Public Sub showNumVille()
        table = Control.boxC(comboVille)
        If table.Rows.Count > 0 Then
            boxVilleNum.Text = table.Rows(0)("num")
        End If

    End Sub
    Public Sub showNameVille()
        table = Control.showNameVille(boxVilleNum.Text)
        If table.Rows.Count > 0 Then
            comboVille.Text = table.Rows(0)("name")
        End If

    End Sub


    Sub clean()
        boxVille.Clear()
        boxCommune.Clear()

    End Sub

    Private Sub comboVille_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboVille.SelectedIndexChanged
        showNumVille()

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Control.insertionVille(boxVille.Text)
        chargementEleement()
        clean()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles btnAjouterC.Click
        Control.insertionCommune(boxCommune.Text, boxVilleNum.Text)
        clean()
        chargementEleement()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clean()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles btnResetC.Click
        clean()
    End Sub

    Private Sub boxVilleNum_TextChanged(sender As Object, e As EventArgs) Handles boxVilleNum.TextChanged
        'showNameVille()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click

        Dim villeNum2 As String = villeNum
            Control.updateVille(boxVille.Text, villeNum2)
            chargementEleement()
            clean()
            visibleNot()


    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim villeNum1 As String = villeNum
            Control.deleteVille(villeNum1)
            clean()
            chargementEleement()
            visibleNot()


    End Sub

    Private Sub DatagridVille_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridVille.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = New DataGridViewRow()
            row = DatagridVille.Rows(e.RowIndex)
            boxVille.Text = row.Cells(1).Value.ToString()
            villeNum = row.Cells(0).Value.ToString()

            visibleButton()

        End If
    End Sub
    Public Sub visibleButton()
        btnAjouter.Visible = False
        btnReset.Visible = False
        btnDelete.Visible = True
        btnModifier.Visible = True
    End Sub
    Public Sub visibleButtonCommune()
        btnAjouterC.Visible = False
        btnResetC.Visible = False
        btnDeleteC.Visible = True
        btnModicierC.Visible = True
    End Sub
    Public Sub visibleButtonNot()
        btnAjouterC.Visible = True
        btnResetC.Visible = True
        btnDeleteC.Visible = False
        btnModicierC.Visible = False
    End Sub

    Public Sub visibleNot()
        btnAjouter.Visible = True
        btnReset.Visible = True
        btnDelete.Visible = False
        btnModifier.Visible = False
    End Sub

    Private Sub btnModicierC_Click(sender As Object, e As EventArgs) Handles btnModicierC.Click
        Dim comNum2 As String = CommuNum
        Control.updateCommune(boxCommune.Text, boxVilleNum.Text, comNum2)
        chargementEleement()
        visibleButtonNot()
        clean()
    End Sub

    Private Sub DatagridCom_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridCom.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = New DataGridViewRow()
            row = DatagridCom.Rows(e.RowIndex)
            boxCommune.Text = row.Cells(1).Value.ToString()
            CommuNum = row.Cells(0).Value.ToString()
            boxVilleNum.Text = row.Cells(2).Value.ToString()
            showNameVille()
            IconButton1.Visible = True
            visibleButtonCommune()

        End If
    End Sub

    Private Sub btnDeleteC_Click(sender As Object, e As EventArgs) Handles btnDeleteC.Click
        Dim comNum2 As String = CommuNum
        Control.deleteCommune(CommuNum)
        chargementEleement()
        clean()
        visibleButtonNot()
    End Sub

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click
        visibleButtonNot()
        IconButton1.Visible = False
        boxCommune.ResetText()


    End Sub
End Class