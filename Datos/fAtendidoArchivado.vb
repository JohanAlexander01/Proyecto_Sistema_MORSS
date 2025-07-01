Imports System.Data.SqlClient

Public Class fAtendidoArchivado
    Inherits ConexionBD
    Public Function InsertarAtencion(idSolicitud As Integer, estado As String, fecha As DateTime) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("InsertarAtendidoArchivado", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdSolicitud", idSolicitud)
            cmd.Parameters.AddWithValue("@Estado", estado)
            cmd.Parameters.AddWithValue("@Fecha", fecha)
            Return cmd.ExecuteNonQuery() > 0
        Catch ex As Exception
            MsgBox("Error al registrar en AtendidoArchivado: " & ex.Message)
            Return False

        End Try
        cnn.close
    End Function
End Class
