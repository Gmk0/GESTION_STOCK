Public Class FormMenu3
    Public OtherControl As New AutresControl




    Private Sub FormMenu3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        custom()
        'showDash()
        chargementDash()
    End Sub

    Sub chargementDash()
        LabelClient.Text = OtherControl.chargementClientCount()
        LabelProduit.Text = OtherControl.chargementProduitCount()
        LabelRutute.Text = OtherControl.chargementStockRCount()


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
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormProduitA, PanelMenu)
        LabelTitre.Text = "PRODUIT"
        hideMenu()

        Cursor = Cursors.Default
    End Sub



    Private Sub iconButton12_Click(sender As Object, e As EventArgs) Handles iconButton12.Click
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormTransaction, PanelMenu)
        hideMenu()
        LabelTitre.Text = "TRANSACTION"
        Cursor = Cursors.Default
    End Sub

    Private Sub iconButton11_Click(sender As Object, e As EventArgs) Handles iconButton11.Click
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormRapportVente, PanelMenu)
        LabelTitre.Text = "RAPPORT DE VENTE"
        hideMenu()
        Cursor = Cursors.Default


    End Sub

    Private Sub iconButton17_Click(sender As Object, e As EventArgs) Handles iconButton17.Click
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormRapportStock, PanelMenu)
        LabelTitre.Text = "STOCKAGE"
        hideMenu()
        Cursor = Cursors.Default
    End Sub

    Private Sub iconButton4_Click(sender As Object, e As EventArgs) Handles iconButton4.Click
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormCategorie, PanelMenu)
        LabelTitre.Text = "CATEGORIE"
        hideMenu()
        Cursor = Cursors.Default
    End Sub

    Private Sub iconButton5_Click(sender As Object, e As EventArgs) Handles iconButton5.Click
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormHistoValeur, PanelMenu)
        hideMenu()
        LabelTitre.Text = "VALEUR"
        Cursor = Cursors.Default
    End Sub

    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub iconButton32_Click(sender As Object, e As EventArgs) Handles iconButton32.Click
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormClientA, PanelMenu)
        hideMenu()
        LabelTitre.Text = "CLIENT"
        Cursor = Cursors.Default
    End Sub

    Private Sub iconButton31_Click(sender As Object, e As EventArgs) Handles iconButton31.Click
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormCommune, PanelMenu)
        hideMenu()
        LabelTitre.Text = "COMMUNE ET VILLE"
        Cursor = Cursors.Default
    End Sub


    Private Sub iconButton18_Click(sender As Object, e As EventArgs) Handles iconButton18.Click
        Cursor = Cursors.WaitCursor

        OtherControl.showMenu(New FormStock, PanelMenu)
        hideMenu()
        LabelTitre.Text = "STOCKAGE TOTAL"
        Cursor = Cursors.Default
    End Sub

    Private Sub iconButton10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub iconButton16_Click(sender As Object, e As EventArgs) Handles iconButton16.Click
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormStockageTot, PanelMenu)
        hideMenu()
        LabelTitre.Text = "STOCKAGE TOTAL"
        Cursor = Cursors.Default
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click

    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        If MsgBox("Voulez vous fermer l'appplicaction", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton7_Click_1(sender As Object, e As EventArgs)
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormProduitA, PanelMenu)
        LabelTitre.Text = "PRODUIT"
        hideMenu()
        Cursor = Cursors.Default
    End Sub

    Private Sub IconButton10_Click_1(sender As Object, e As EventArgs)
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormClientA, PanelMenu)
        hideMenu()
        LabelTitre.Text = "CLIENT"
        Cursor = Cursors.Default
    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs)
        Cursor = Cursors.WaitCursor

        OtherControl.showMenu(New FormStock, PanelMenu)
        hideMenu()
        LabelTitre.Text = "STOCKAGE TOTAL"
        Cursor = Cursors.Default
    End Sub

    Private Sub iconButton1_Click(sender As Object, e As EventArgs) Handles iconButton1.Click

        PanelMenu2.BringToFront()


    End Sub
    Public Sub showDash()
        Cursor = Cursors.WaitCursor

        OtherControl.showMenu(New FormDashbord, PanelMenu)
        hideMenu()
        LabelTitre.Text = "DASHBORD"
        Cursor = Cursors.Default
    End Sub

    Private Sub PanelMenu2_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu2.Paint

    End Sub

    Private Sub PanelDashbord_Paint(sender As Object, e As PaintEventArgs) Handles PanelDashbord.Paint

    End Sub

    Private Sub IconButton10_Click_2(sender As Object, e As EventArgs) Handles IconButton10.Click
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormClientA, PanelMenu)
        hideMenu()
        LabelTitre.Text = "CLIENT"
        Cursor = Cursors.Default
    End Sub

    Private Sub IconButton9_Click(sender As Object, e As EventArgs) Handles IconButton9.Click
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormProduitA, PanelMenu)
        LabelTitre.Text = "PRODUIT"
        hideMenu()

        Cursor = Cursors.Default
    End Sub

    Private Sub IconButton8_Click_1(sender As Object, e As EventArgs) Handles IconButton8.Click
        Cursor = Cursors.WaitCursor

        OtherControl.showMenu(New FormStock, PanelMenu)
        hideMenu()
        LabelTitre.Text = "STOCKAGE TOTAL"
        Cursor = Cursors.Default
    End Sub

    Private Sub IconButton7_Click_2(sender As Object, e As EventArgs) Handles IconButton7.Click
        Cursor = Cursors.WaitCursor
        OtherControl.showMenu(New FormRapportVente, PanelMenu)
        LabelTitre.Text = "RAPPORT DE VENTE"
        hideMenu()
        Cursor = Cursors.Default

    End Sub
End Class