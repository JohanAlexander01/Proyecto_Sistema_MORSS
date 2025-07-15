Imports System.Data.SqlClient
Public Class ConexionBD
    Public cnn As New SqlConnection
    Public cmd As New SqlCommand

    Public Function conectar()
        Try
            cnn = New SqlConnection("Data Source=LAPTOP-LC7BS8RT\DATABASEUNDAC;Initial Catalog=MORSS;Integrated Security=True;")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
