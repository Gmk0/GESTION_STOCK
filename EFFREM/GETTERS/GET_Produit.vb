Public Class GET_Produit
    Dim num As Integer
    Dim produit, seuilRupture, description, categorie, IdProduit As String

    Public Property getIdproduit
        Get
            Return IdProduit
        End Get
        Set(ByVal value)
            IdProduit = value
        End Set

    End Property
    Public Property getINumCate
        Get
            Return num
        End Get
        Set(ByVal value)
            num = value
        End Set

    End Property
    Public Property getProduit
        Get
            Return produit
        End Get
        Set(ByVal value)
            produit = value
        End Set

    End Property
    Public Property getSeuilRupture
        Get
            Return seuilRupture
        End Get
        Set(ByVal value)
            seuilRupture = value
        End Set

    End Property
    Public Property getDescription
        Get
            Return description
        End Get
        Set(ByVal value)
            description = value
        End Set

    End Property
    Public Property getCategorie
        Get
            Return categorie
        End Get
        Set(ByVal value)
            categorie = value
        End Set

    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal idProduit As String, ByVal produit As String, ByVal seuilRupture As String, ByVal description As String, ByVal categorie As String)
        getProduit = idProduit
        getProduit = produit
        getSeuilRupture = seuilRupture
        getDescription = description
        getCategorie = categorie


    End Sub

End Class
