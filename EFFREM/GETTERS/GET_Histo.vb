Public Class GET_HISTO
    Dim qte As Integer
    Dim produitId, dates, id As String
    Dim prix As Decimal


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
    Public Property getPrix()
        Get
            Return prix
        End Get
        Set(value)
            prix = value
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
    Public Sub New(ByVal produitId As String, ByVal id As String, ByVal dates As String, ByVal prix As Decimal, ByVal qte As Integer)
        getDate = dates
        getPrix = prix
        getProduitId = produitId
        getQte = qte
        getId = id

    End Sub



End Class
