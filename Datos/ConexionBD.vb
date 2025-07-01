Imports System.Data.SqlClient
Public Class ConexionBD
    Public cnn As New SqlConnection
    Public cmd As New SqlCommand

    Public Function conectar()
        Try
            cnn = New SqlConnection("Data Source=DESKTOP-6VI5PD9\SQLSERVER22;Initial Catalog=MORSS;User ID=sa;Password=190110")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
