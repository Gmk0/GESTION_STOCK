Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub
    Public Sub chargement_LIVRE()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargement_LIVRE()
    End Sub

    Public Sub hideMenu()
        If PanelRapport.Visible = True Then
            PanelRapport.Visible = False
        End If
        If PanelClient.Visible = True Then
            PanelClient.Visible = False
        End If
        If PanelOutils.Visible = True Then
            PanelOutils.Visible = False
        End If
    End Sub

    Public Sub showPanel(ByVal subMenu As Panel)
        If subMenu.Visible = False Then
            hideMenu()
            subMenu.Visible = True
            subMenu.BringToFront()


            Else
            subMenu.Visible = False

        End If
    End Sub
    Private activeForm As Form = Nothing
    Private Sub showMenu(ByRef childForm As Form)
        If activeForm IsNot Nothing Then
            activeForm.Close()
        End If
        activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelBody.Controls.Add(childForm)
        PanelBody.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        showMenu(New FormProduitA)
        hideMenu()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        showMenu(New FormClientA)
        hideMenu()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        hideMenu()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PanelBody_Paint(sender As Object, e As PaintEventArgs) Handles PanelBody.Paint

    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        showPanel(PanelClient)

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        showPanel(PanelRapport)

    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        showPanel(PanelOutils)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        showMenu(New FormClientA)
        hideMenu()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        showMenu(New FormCommune)
        hideMenu()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        showMenu(New FormTransaction)
        hideMenu()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        showMenu(New FormStock)
        hideMenu()
    End Sub

    Private Sub IconButton5_MouseHover(sender As Object, e As EventArgs) Handles IconButton5.MouseHover

    End Sub



    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        showMenu(New FormClientA)
        hideMenu()
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        showMenu(New FormCommune)
        hideMenu()
    End Sub

    Private Sub IconButton12_Click(sender As Object, e As EventArgs) Handles IconButton12.Click
        showMenu(New FormRapportStock)
    End Sub

    Private Sub IconButton13_Click(sender As Object, e As EventArgs) Handles IconButton13.Click
        showMenu(New FormRapportVente)
    End Sub
End Class
