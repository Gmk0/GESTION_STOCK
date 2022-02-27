Public Class FormRapportVente
    Private TransactionControler As New TransactionController
    Private Sub FormRapportVente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  chargementElement()
        chargementNombre()
    End Sub

    Private Sub chargementElement()
        Cursor = Cursors.WaitCursor
        TransactionControler.ChargementElement(DatagridProduit, Guna2ComboBox1.Text)
        Cursor = Cursors.Default
    End Sub
    Private Sub chargementElementDate()
        Cursor = Cursors.WaitCursor
        TransactionControler.ChargementElementDate(DatagridProduit, dateDu.Value.ToString, DateAu.Value.ToString())
        Cursor = Cursors.Default
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        chargementElement()
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        chargementElement()
    End Sub

    Private Sub Guna2DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateAu.ValueChanged

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        chargementElementDate()
    End Sub
    Private Sub chargementNombre()
        If DatagridProduit.RowCount > 0 Then
            LabelText.Visible = False
        Else
            LabelText.Visible = True
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class