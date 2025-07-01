Imports System.Data.SqlClient
Imports Entidades
Public Class fPagos
    Inherits ConexionBD
    Public Function MostrarPagos()
        Try
            conectar()
            cmd = New SqlCommand("mostrarPagos")
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
    Public Function ObtenerPagoPorSolicitud(id As Integer) As DataTable
        Try
            conectar()
            Dim cmd As New SqlCommand("sp_ObtenerPagoPorSolicitud", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdSolicitud", id)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return Nothing

        End Try
        cnn.Close()
    End Function
    Public Function InsertarPagos(ByVal insertPagos As Entidades.EntPagos) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("InsertarPago", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters

                .AddWithValue("@IdSolicitud", insertPagos.gIdSolicitud)
                .AddWithValue("@Monto", insertPagos.gMonto)
                .AddWithValue("@Voucher", insertPagos.gNumVoucher)
                .AddWithValue("@FechaPago", insertPagos.gFechaPago)

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

    Public Function EditarPagos(ByVal updatePagos As Entidades.EntPagos) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EditarPago", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters

                .AddWithValue("@IdSolicitud", updatePagos.gIdSolicitud)
                .AddWithValue("@Monto", updatePagos.gMonto)
                .AddWithValue("@Voucher", updatePagos.gNumVoucher)
                .AddWithValue("@FechaPago", updatePagos.gFechaPago)
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
    Public Function ActualizarPagoCopias(pago As Entidades.EntPagos) As Boolean
        Try
            conectar()
            Dim cmd As New SqlCommand("ActualizarPagoCopias", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@IdSolicitud", pago.gIdSolicitud)
            cmd.Parameters.AddWithValue("@MontoCopias", pago.gMontoCopias)
            cmd.Parameters.AddWithValue("@VoucherCopias", pago.gNumVoucherCopias)
            cmd.Parameters.AddWithValue("@FechaPagoCopias", pago.gFechaPagoCopias)

            Return cmd.ExecuteNonQuery() > 0
        Catch ex As Exception
            MsgBox("Error al actualizar el pago de copias: " & ex.Message)
            Return False

        End Try
        cnn.Close()
    End Function

    Public Function EliminarPagos(ByVal deletePagos As Entidades.EntPagos) As Boolean
        Try
            conectar()
            cmd = New SqlCommand("EliminarPago")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdDetalle", deletePagos.gIdPago)

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
