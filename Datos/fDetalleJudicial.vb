Imports System.Data.SqlClient
Imports Entidades
Public Class fDetalleJudicial
    Inherits ConexionBD
    Public Function MostrarDetalleJudicial()
        Try
            conectar()
            cmd = New SqlCommand("mostrarDetalleJudicial")
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
            Dim cmd As New SqlCommand("ObtenerDetalleJudicialPorSolicitud", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdSolicitud", idSolicitud)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("Error al obtener detalle judicial: " & ex.Message)
            Return Nothing

        End Try
        cnn.Close()
    End Function
    Public Function InsertarDetalleJudicial(ByVal insertDetJudicial As Entidades.EntDetalleJudicial) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("InsertarDetalleJudicial", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters

                .AddWithValue("@IdSolicitud", insertDetJudicial.gIdSolicitud)
                .AddWithValue("@TipoProceso", insertDetJudicial.gTipoProceso)
                .AddWithValue("@NumExpediente", insertDetJudicial.gNumExpediente)
                .AddWithValue("@Materia", insertDetJudicial.gMateria)
                .AddWithValue("@Demandante", insertDetJudicial.gDemandante)
                .AddWithValue("@Demandado", insertDetJudicial.gDemandado)

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

    Public Function EditarDetalleJudicial(ByVal updateDetJudicial As Entidades.EntDetalleJudicial) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EditarDetalleJudicial", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("@IdDetalle", updateDetJudicial.gIdDetalle)
                .AddWithValue("@IdSolicitud", updateDetJudicial.gIdSolicitud)
                .AddWithValue("@TipoProceso", updateDetJudicial.gTipoProceso)
                .AddWithValue("@NumExpediente", updateDetJudicial.gNumExpediente)
                .AddWithValue("@Materia", updateDetJudicial.gMateria)
                .AddWithValue("@Demandante", updateDetJudicial.gDemandante)
                .AddWithValue("@Demandado", updateDetJudicial.gDemandado)

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
    Public Function EliminarDetalleJudicial(ByVal deleteDetJudicial As Entidades.EntDetalleJudicial) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EliminarDetJudicial")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdDetalle", deleteDetJudicial.gIdDetalle)

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
