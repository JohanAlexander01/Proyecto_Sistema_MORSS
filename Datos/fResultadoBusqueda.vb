Imports System.Data.SqlClient

Imports Datos
Imports Entidades
Public Class fResultadoBusqueda
    Inherits ConexionBD
    Public Function GuardarResultadoBusqueda(idSolicitud As Long, estado As String, numeroFojas As Integer) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("InsertarResultadoBusqueda", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdSolicitud", idSolicitud)
            cmd.Parameters.AddWithValue("@Estado", estado)
            cmd.Parameters.AddWithValue("@NumFojas", numeroFojas)
            Return cmd.ExecuteNonQuery() > 0
        Catch ex As Exception
            MsgBox("Error al guardar resultado: " & ex.Message)
            Return False
        Finally
            cnn.Close()
        End Try
    End Function
    Public Function ObtenerResultadoPorIdSolicitud(idSolicitud As Integer) As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("SELECT * FROM ResultadosBusqueda WHERE IdSolicitud = @id", cnn)
            cmd.Parameters.AddWithValue("@id", idSolicitud)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("Error al obtener resultado: " & ex.Message)
            Return Nothing

        End Try
        cnn.Close()
    End Function
    Public Function ActualizarEstadoSolicitud(idSolicitud As Long, estado As String) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("ActualizarEstadoSolicitud", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdSolicitud", idSolicitud)
            cmd.Parameters.AddWithValue("@Estado", estado)
            Return cmd.ExecuteNonQuery() > 0
        Catch ex As Exception
            MsgBox("Error al actualizar estado: " & ex.Message)
            Return False
        Finally
            cnn.Close()
        End Try
    End Function
End Class
