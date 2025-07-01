Imports System.Data.SqlClient
Imports Entidades
Public Class fDetalleCivil
    Inherits ConexionBD
    Public Function MostrarDetalleCivil()
        Try
            conectar()
            cmd = New SqlCommand("mostrarDetalleCivil")
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
            Dim cmd As New SqlCommand("ObtenerDetalleCivilPorSolicitud", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdSolicitud", idSolicitud)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("Error al obtener detalle civil: " & ex.Message)
            Return Nothing
        End Try
        cnn.Close()
    End Function
    Public Function InsertarDetalleCivil(ByVal insertDetCivil As Entidades.EntDetalleCivil) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("InsertarDetalleCivil", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters

                .AddWithValue("@IdSolicitud", insertDetCivil.gIdSolicitud)
                .AddWithValue("@TipoPartida", insertDetCivil.gTipoPartida)
                .AddWithValue("@Provincia", insertDetCivil.gProvincia)
                .AddWithValue("@Distrito", insertDetCivil.gDistrito)
                .AddWithValue("@Interesado", insertDetCivil.gInteresado)
                .AddWithValue("@FechaPartida", insertDetCivil.gFechaPartida)

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

    Public Function EditarDetalleCivil(ByVal updateDetCivil As Entidades.EntDetalleCivil) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EditarDetalleCivil", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters

                .AddWithValue("@IdSolicitud", updateDetCivil.gIdSolicitud)
                .AddWithValue("@TipoPartida", updateDetCivil.gTipoPartida)
                .AddWithValue("@Provincia", updateDetCivil.gProvincia)
                .AddWithValue("@Distrito", updateDetCivil.gDistrito)
                .AddWithValue("@Interesado", updateDetCivil.gInteresado)
                .AddWithValue("@FechaPartida", updateDetCivil.gFechaPartida)

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
    Public Function EliminarDetalleCivil(ByVal deleteDetCivil As Entidades.EntDetalleCivil) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EliminarDetCivil")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdDetalle", deleteDetCivil.gIdDetalle)

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
