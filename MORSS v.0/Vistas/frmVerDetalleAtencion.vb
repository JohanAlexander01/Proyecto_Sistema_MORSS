﻿Imports System.Threading
Imports Datos
Imports Entidades
Public Class frmVerDetalleAtencion
    Public Property IdSolicitud As Integer
    Public Property TipoDocumento As String
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAtender_Click(sender As Object, e As EventArgs) Handles btnAtender.Click
        Try
            ' Validar campos obligatorios
            If txtIdSolicitud.Text = "" Or txtVoucher.Text = "" Or txtMonto1.Text = "" Then
                MessageBox.Show("Complete todos los campos requeridos antes de atender.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Variables
            Dim idSolicitud As Long = Convert.ToInt64(txtIdSolicitud.Text)
            Dim estadoFinal As String = "Atendido"

            ' 1. Actualizar estado en tabla Solicitudes
            Dim fSol As New Datos.fResultadoBusqueda
            Dim actualizadoEstado As Boolean = fSol.ActualizarEstadoSolicitud(idSolicitud, estadoFinal)

            ' 2. Insertar registro en tabla AtendidoArchivado
            Dim fAtendido As New Datos.fAtendidoArchivado
            Dim registradoAtendido As Boolean = fAtendido.InsertarAtencion(idSolicitud, estadoFinal, Date.Now)

            ' 3. Actualizar campos de copia en tabla Pagos
            Dim pago As New Entidades.EntPagos
            With pago
                .gIdSolicitud = idSolicitud
                .gMontoCopias = Convert.ToDecimal(txtMonto.Text)
                .gNumVoucherCopias = txtVoucher.Text
                .gFechaPagoCopias = dtpFechaDocumento.Value
            End With

            Dim fPago As New Datos.fPagos
            Dim actualizadoPago As Boolean = fPago.ActualizarPagoCopias(pago)

            ' 4. Verificación final
            If actualizadoEstado AndAlso registradoAtendido AndAlso actualizadoPago Then
                MessageBox.Show("La solicitud ha sido atendida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Limpiar campos
                Limpiar()
                ' Refrescar DataGridView

            Else
                MessageBox.Show("Hubo un problema al procesar la atención.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al atender solicitud: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub limpiar()
        txtSolicitante.Clear()
        txtDni.Clear()
        txtCelular.Clear()
        txtDireccion.Clear()
        txtMonto1.Clear()
        txtVoucher.Clear()
        txtEstado.Clear()
        txtCopias.Clear()
        txtNunFojas.Clear()
        cboTipo.SelectedIndex = -1
        cboPartida.SelectedIndex = -1
    End Sub
    Private Sub frmVerDetalleAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Cargar solicitud
            Dim fSolicitud As New Datos.fSolicitudes
            Dim solicitud As DataTable = fSolicitud.ObtenerSolicitudPorId(IdSolicitud)

            If solicitud IsNot Nothing AndAlso solicitud.Rows.Count > 0 Then
                Dim row = solicitud.Rows(0)
                txtSolicitante.Text = row("ApellidosNombres").ToString()
                txtDni.Text = row("DNI").ToString()
                txtDireccion.Text = row("Direccion").ToString()
                txtCelular.Text = row("Celular").ToString()
                cboTipo.Text = row("TipoDocumento").ToString()
                txtCopias.Text = row("Copias").ToString()
                txtEstado.Text = row("Estado").ToString()
            End If

            ' Cargar resultado de búsqueda
            Dim fResultado As New Datos.fResultadoBusqueda
            Dim resultado As DataTable = fResultado.ObtenerResultadoPorIdSolicitud(IdSolicitud)

            If resultado IsNot Nothing AndAlso resultado.Rows.Count > 0 Then
                Dim row = resultado.Rows(0)

                ' Asegúrate de que el nombre del campo coincida con la base de datos
                txtNunFojas.Text = row("NumFojas").ToString()
                CalcularMonto()
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar el detalle: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalcularMonto()
        Try
            Dim fojas As Integer = 0
            Dim monto As Decimal = 0

            ' Validar que haya valor en txtNunFojas
            If Not Integer.TryParse(txtNunFojas.Text, fojas) Then
                txtMonto1.Text = "0.00"
                Exit Sub
            End If

            Select Case txtCopias.Text.Trim().ToLower()
                Case "certificadas"
                    monto = fojas * 11
                Case "simples"
                    monto = fojas * 6
                Case "testimonio"
                    ' Testimonio cuesta 12 más el total de copias certificadas
                    monto = 12 + (fojas * 11)
                Case Else
                    monto = 0
            End Select

            txtMonto1.Text = monto.ToString("F2") ' Formato con dos decimales
        Catch ex As Exception
            MessageBox.Show("Error al calcular el monto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class