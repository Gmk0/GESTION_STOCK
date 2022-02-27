Public Class GET_TRANSAC
    Dim qte, num As Integer
    Dim produitId, dates, id, clientId, prixId As String
    Dim montant As Decimal


    Public Property getClientId()
        Get
            Return clientId
        End Get
        Set(value)
            clientId = value
        End Set

    End Property
    Public Property getNum()
        Get
            Return num
        End Get
        Set(value)
            num = value
        End Set

    End Property
    Public Property getQte()
        Get
            Return qte
        End Get
        Set(value)
            qte = value
        End Set

    End Property
    Public Property getProduitId()
        Get
            Return produitId
        End Get
        Set(value)
            produitId = value
        End Set

    End Property
    Public Property getPrixId()
        Get
            Return prixId
        End Get
        Set(value)
            prixId = value
        End Set

    End Property
    Public Property getMontant()
        Get
            Return montant
        End Get
        Set(value)
            montant = value
        End Set

    End Property
    Public Property getDate()
        Get
            Return dates
        End Get
        Set(value)
            dates = value
        End Set

    End Property
    Public Property getId()
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set

    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal produitId As String, ByVal num As String, ByVal id As String, ByVal dates As String, ByVal prixId As String, ByVal clientId As String, ByVal qte As Integer, ByVal montant As String)
        getDate = dates
        getPrixId = prixId
        getProduitId = produitId
        getQte = qte
        getId = id
        getNum = num
        getClientId = clientId
        getMontant = montant

    End Sub



End Class
