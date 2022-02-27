Public Class GET_CLIENT


    Dim comNum As Integer
    Dim name, gsm, IdClient As String

    Public Property getIdClient
            Get
                Return IdClient
            End Get
            Set(ByVal value)
                IdClient = value
            End Set

        End Property
        Public Property getName
            Get
                Return name
            End Get
            Set(ByVal value)
                name = value
            End Set

        End Property
        Public Property getCommNum
            Get
                Return comNum
            End Get
            Set(ByVal value)
                comNum = value
            End Set

        End Property
        Public Property getGsm
            Get
                Return gsm
            End Get
            Set(ByVal value)
                gsm = value
            End Set

        End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idclient As Integer, ByVal name As String, ByVal commNum As Integer, ByVal gsm As String)
            getIdClient = idclient
            getName = name
            getCommNum = comNum
            getGsm = gsm
        End Sub

    End Class


