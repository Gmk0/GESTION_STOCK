Public Class GET_Local
    Dim villNum, comNum As Integer
    Dim villeName, comName As String

    Public Property getVilleNum
        Get
            Return villNum
        End Get
        Set(value)
            villNum = value
        End Set
    End Property
    Public Property getComName
        Get
            Return comName
        End Get
        Set(value)
            comName = value
        End Set
    End Property
    Public Property getComNum
        Get
            Return comNum
        End Get
        Set(value)
            comNum = value
        End Set
    End Property
    Public Property getVilleName
        Get
            Return villeName
        End Get
        Set(value)
            villeName = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal villeNum As Integer, ByVal villeName As String, ByVal comNum As Integer, ByVal comName As String)
        getComName = comName
        getVilleName = villeName
        getComNum = comNum
        getVilleNum = villNum

    End Sub

End Class
