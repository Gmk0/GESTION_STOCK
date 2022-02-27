Imports System.Data.SqlClient



Public Class CONNEXIONBD

    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\dd\TP_LangProg3_2022.mdf;Integrated Security=True;Connect Timeout=30")

    ReadOnly Property GetConnection() As SqlConnection
        Get
            Return connection
        End Get
    End Property

    Sub openConnection()
        If (connection.State = ConnectionState.Closed) Then
            connection.Open()
        End If
    End Sub

    Sub closeConnection()
        If (connection.State = ConnectionState.Open) Then
            connection.Close()
        End If
    End Sub



End Class
