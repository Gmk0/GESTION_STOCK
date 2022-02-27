Public Class FormMenu3
    Private OtherControl As New AutresControl
    Private Sub FormMenu3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        custom()
    End Sub

    Public Sub custom()
        panelAchat.Visible = False
        panelProduit.Visible = False
        paneloutils.Visible = False
        panelVENTE.Visible = False
    End Sub
    Public Sub hideMenu()

        If panelVENTE.Visible = True Then
            panelVENTE.Visible = False
        End If

        If paneloutils.Visible = True Then
            paneloutils.Visible = False
        End If
        If panelAchat.Visible = True Then
            panelAchat.Visible = False
        End If

        If panelProduit.Visible = True Then
            panelProduit.Visible = False
        End If
    End Sub

    Private Sub showmenu(ByVal submenu As Panel)

        If submenu.Visible = False Then

            hideMenu()
            submenu.Visible = True

        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub iconButton2_Click(sender As Object, e As EventArgs) Handles iconButton2.Click
        showmenu(panelProduit)
    End Sub

    Private Sub iconButton13_Click(sender As Object, e As EventArgs) Handles iconButton13.Click
        showmenu(panelVENTE)
    End Sub

    Private Sub iconButton19_Click(sender As Object, e As EventArgs) Handles iconButton19.Click
        showmenu(panelAchat)
    End Sub

    Private Sub btnOutils_Click(sender As Object, e As EventArgs) Handles btnOutils.Click
        showmenu(paneloutils)
    End Sub

    Private Sub iconButton3_Click(sender As Object, e As EventArgs) Handles iconButton3.Click

        OtherControl.showMenu(New FormProduitA, PanelMenu)
        LabelTitre.Text = "PRODUIT"
        hideMenu()
    End Sub



    Private Sub iconButton12_Click(sender As Object, e As EventArgs) Handles iconButton12.Click
        OtherControl.showMenu(New FormTransaction, PanelMenu)
        hideMenu()
        LabelTitre.Text = "TRANSACTION"
    End Sub

    Private Sub iconButton11_Click(sender As Object, e As EventArgs) Handles iconButton11.Click

        OtherControl.showMenu(New FormRapportVente, PanelMenu)
        LabelTitre.Text = "RAPPORT DE VENTE"
        hideMenu()

    End Sub

    Private Sub iconButton17_Click(sender As Object, e As EventArgs) Handles iconButton17.Click
        OtherControl.showMenu(New FormRapportStock, PanelMenu)
        LabelTitre.Text = "STOCKAGE"
        hideMenu()
    End Sub

    Private Sub iconButton4_Click(sender As Object, e As EventArgs) Handles iconButton4.Click
        OtherControl.showMenu(New FormCategorie, PanelMenu)
        LabelTitre.Text = "CATEGORIE"
        hideMenu()
    End Sub

    Private Sub iconButton5_Click(sender As Object, e As EventArgs) Handles iconButton5.Click
        OtherControl.showMenu(New FormHistoValeur, PanelMenu)
        hideMenu()
        LabelTitre.Text = "VALEUR"
    End Sub

    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub iconButton32_Click(sender As Object, e As EventArgs) Handles iconButton32.Click
        OtherControl.showMenu(New FormClientA, PanelMenu)
        hideMenu()
        LabelTitre.Text = "TRANSACTION"
    End Sub

    Private Sub iconButton31_Click(sender As Object, e As EventArgs) Handles iconButton31.Click
        OtherControl.showMenu(New FormCommune, PanelMenu)
        hideMenu()
        LabelTitre.Text = "COMMUNE ET VILLE"
    End Sub

    Private Sub iconButton18_Click(sender As Object, e As EventArgs) Handles iconButton18.Click
        OtherControl.showMenu(New FormStock, PanelMenu)
        hideMenu()
        LabelTitre.Text = "STOCKAGE TOTAL"
    End Sub

    Private Sub iconButton10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub iconButton16_Click(sender As Object, e As EventArgs) Handles iconButton16.Click
        OtherControl.showMenu(New FormStockageTot, PanelMenu)
        hideMenu()
        LabelTitre.Text = "STOCKAGE TOTAL"
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click

    End Sub
End Class