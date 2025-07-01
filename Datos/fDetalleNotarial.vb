Imports System.Data.SqlClient
Imports Entidades
Public Class fDetalleNotarial
    Inherits ConexionBD
    Public Function MostrarDetalleNotarial()
        Try
            conectar()
            cmd = New SqlCommand("mostrarDetalleNotarial")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
        cnn.Close()
    End Function

    Public Function ObtenerDetallePorSolicitud(ByVal idSolicitud As Integer) As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("ObtenerDetalleNotarialPorSolicitud", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdSolicitud", idSolicitud)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("Error al obtener detalle notarial: " & ex.Message)
            Return Nothing
        End Try
        cnn.Close()
    End Function
    Public Function InsertarDetalleNotarial(ByVal insertDetNotarial As Entidades.EntDetalleNotarial) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("InsertarDetalleNotarial", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters

                .AddWithValue("@IdSolicitud", insertDetNotarial.gIdSolicitud)
                .AddWithValue("@Instrumento", insertDetNotarial.gInstrumento)
                .AddWithValue("@ActoProtocolar", insertDetNotarial.gActoProtocolar)
                .AddWithValue("@Notario", insertDetNotarial.gNotario)
                .AddWithValue("@FechaDocumento", insertDetNotarial.gFechaDocumento)
                .AddWithValue("@OtorgadoPor", insertDetNotarial.gOtorgadoPor)
                .AddWithValue("@AFavor", insertDetNotarial.gAFavor)

                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        cnn.Close()
    End Function

    Public Function EditarDetalleNotarial(ByVal updateDetNotarial As Entidades.EntDetalleNotarial) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EditarDetalleNotarial", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("@IdSolicitud", updateDetNotarial.gIdSolicitud)
                .AddWithValue("@Instrumento", updateDetNotarial.gInstrumento)
                .AddWithValue("@ActoProtocolar", updateDetNotarial.gActoProtocolar)
                .AddWithValue("@Notario", updateDetNotarial.gNotario)
                .AddWithValue("@FechaDocumento", updateDetNotarial.gFechaDocumento)
                .AddWithValue("@OtorgadoPor", updateDetNotarial.gOtorgadoPor)
                .AddWithValue("@AFavorDe", updateDetNotarial.gAFavor)

                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        cnn.Close()
    End Function
    Public Function EliminarDetalleNotarial(ByVal deleteDetNotarial As Entidades.EntDetalleNotarial) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EliminarDetNotarial")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdDetalle", deleteDetNotarial.gIdDetalle)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        cnn.Close()
    End Function
End Class
