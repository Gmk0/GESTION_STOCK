Public Class FormClientA
    Dim ClientManger As New ClientManger
    Dim getClient As New GET_CLIENT
    Public table As DataTable
    Public controlClient As New ClientController
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim FormClientB As New FormClientB
        FormClientB.ShowDialog()
    End Sub

    Private Sub FormClientA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargementElement()
    End Sub



    Public Sub AjoutButtonn()
        With DatagridProduit.Columns
            Dim btn As New DataGridViewButtonColumn
            btn.Name = "MODIFICATION"
            btn.HeaderText = "MODIFIACTION"
            btn.Text = "MODIFIER"
            btn.FlatStyle = FlatStyle.Flat

            ' btn.DefaultCellStyle.BackColor = Color.CornflowerBlue
            btn.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue



            btn.UseColumnTextForButtonValue = True
            .Add(btn)
        End With
    End Sub
    Public Sub ChargementElement()
        controlClient.chargementClient(DatagridProduit)
        chargementNombre()
        AjoutButtonn()
    End Sub
    Private Sub chargementNombre()
        If DatagridProduit.RowCount > 0 Then
            Dim nbre As Integer = Convert.ToInt32(DatagridProduit.Rows.Count)
            If nbre <= 1 Then
                LabelProd.Text = "Nombre de Client:" + DatagridProduit.Rows.Count.ToString()
                LabelProd.ForeColor = Color.Black
            Else
                LabelProd.Text = "Nombre des Clients:" + DatagridProduit.Rows.Count.ToString()
                LabelProd.ForeColor = Color.Black
            End If
        Else


            LabelProd.Text = "Client non trouvee"
            LabelProd.ForeColor = Color.Red


        End If
    End Sub

    Private Sub TextBoxRech_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRech.TextChanged
        controlClient.chargementClientRechere(TextBoxRech.Text, DatagridProduit)
        chargementNombre()
    End Sub

    Private Sub DatagridProduit_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridProduit.CellContentDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DatagridProduit.Columns("MODIFICATION").Index Then
            Dim row As DataGridViewRow = New DataGridViewRow()
            row = DatagridProduit.Rows(e.RowIndex)
            Dim form As New FormClientB
            form.id = row.Cells("Id").Value.ToString()
            form.boxName.Text = row.Cells("name").Value.ToString()
            form.boxGsm.Text = row.Cells("gsm").Value.ToString()
            form.boxC.Text = row.Cells("communeNum").Value.ToString()
            form.boxC.Visible = True
            form.visibleButtonD()
            form.ShowDialog()


        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click


        DatagridProduit.Columns.Clear()
        TextBoxRech.Clear()

        ChargementElement()



    End Sub
End Class