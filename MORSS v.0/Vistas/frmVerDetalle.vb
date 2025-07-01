Imports Datos
Imports Entidades
Public Class frmVerDetalle
    Public Property IdSolicitud As Integer
    Public Property TipoDocumento As String

    Private Sub frmVerDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ' Cargar datos generales
            CargarSolicitudPorId(IdSolicitud)

            ' Cargar detalle según tipo
            Select Case TipoDocumento
                Case "Notarial"
                    CargarDetalleNotarial(IdSolicitud)
                    pnlNotarial.Visible = True
                    pnlJudicial.Visible = False
                    pnlCivil.Visible = False
                Case "Judicial"
                    CargarDetalleJudicial(IdSolicitud)
                    pnlJudicial.Visible = True
                    pnlNotarial.Visible = False
                    pnlCivil.Visible = False
                Case "Registro Civil"
                    CargarDetalleCivil(IdSolicitud)
                    pnlCivil.Visible = True
                    pnlNotarial.Visible = False
                    pnlJudicial.Visible = False
            End Select

            ' Cargar pago
            CargarPago(IdSolicitud)

        Catch ex As Exception
            MessageBox.Show("Error al cargar detalle: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarSolicitudPorId(ByVal id As Integer)
        Dim func As New Datos.fSolicitudes
        Dim dt As DataTable = func.ObtenerSolicitudPorId(id)

        If dt.Rows.Count > 0 Then
            txtIdSolicitud.Text = dt.Rows(0)("IdSolicitud").ToString()
            txtSolicitante.Text = dt.Rows(0)("ApellidosNombres").ToString()
            txtDni.Text = dt.Rows(0)("DNI").ToString()
            txtCelular.Text = dt.Rows(0)("Celular").ToString()
            txtDireccion.Text = dt.Rows(0)("Direccion").ToString()
            cboTipo.Text = dt.Rows(0)("TipoDocumento").ToString()

            Dim copias As String = dt.Rows(0)("Copias").ToString()
            If copias = "Simples" Then rbSimples.Checked = True
            If copias = "Certificadas" Then rbCertificadas.Checked = True
            If copias = "Testimonio" Then rbTestimonio.Checked = True

            dtpFechaDocumento.Value = Convert.ToDateTime(dt.Rows(0)("FechaRegistro"))
        End If
    End Sub
    Private Sub CargarDetalleNotarial(ByVal idSolicitud As Integer)
        Dim func As New Datos.fDetalleNotarial
        Dim dt As DataTable = func.ObtenerDetallePorSolicitud(idSolicitud)

        If dt.Rows.Count > 0 Then
            cboInstrumento.Text = dt.Rows(0)("Instrumento").ToString()
            txtActoProtocolar.Text = dt.Rows(0)("ActoProtocolar").ToString
            txtNotario.Text = dt.Rows(0)("Notario").ToString()
            dtpFechaDocumento.Value = Convert.ToDateTime(dt.Rows(0)("FechaDocumento"))
            txtOtorga.Text = dt.Rows(0)("OtorgadoPor").ToString()
            txtAfavor.Text = dt.Rows(0)("AFavorDe").ToString()
        End If
    End Sub
    Private Sub CargarDetalleJudicial(ByVal idSolicitud As Integer)
        Dim func As New Datos.fDetalleJudicial
        Dim dt As DataTable = func.ObtenerDetallePorSolicitud(idSolicitud)

        If dt.Rows.Count > 0 Then
            cboTipoProceso.Text = dt.Rows(0)("TipoProceso").ToString()
            txtNumExp.Text = dt.Rows(0)("NumExpediente").ToString()
            txtMateria.Text = dt.Rows(0)("Materia").ToString()
            txtDemandante.Text = dt.Rows(0)("Demandante").ToString()
            txtDemandado.Text = dt.Rows(0)("Demandado").ToString()
        End If
    End Sub
    Private Sub CargarDetalleCivil(ByVal idSolicitud As Integer)
        Dim func As New Datos.fDetalleCivil
        Dim dt As DataTable = func.ObtenerDetallePorSolicitud(idSolicitud)

        If dt.Rows.Count > 0 Then
            cboPartida.Text = dt.Rows(0)("TipoPartida").ToString()
            txtProvincia.Text = dt.Rows(0)("Provincia").ToString()
            txtDistrito.Text = dt.Rows(0)("Distrito").ToString()
            txtInteresado.Text = dt.Rows(0)("Interesado").ToString()
            dtpFechaDocumento.Value = Convert.ToDateTime(dt.Rows(0)("FechaPartida"))
        End If
    End Sub
    Private Sub CargarPago(ByVal idSolicitud As Integer)
        Dim func As New Datos.fPagos
        Dim dt As DataTable = func.ObtenerPagoPorSolicitud(idSolicitud)

        If dt.Rows.Count > 0 Then
            txtMonto.Text = dt.Rows(0)("Monto").ToString()
            txtNumVoucher.Text = dt.Rows(0)("Voucher").ToString()
            dtpFechaDocumento.Value = Convert.ToDateTime(dt.Rows(0)("FechaPago"))
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub rbEncontrado_CheckedChanged(sender As Object, e As EventArgs) Handles rbEncontrado.CheckedChanged
        If rbEncontrado.Checked = True Then
            gbFojas.Visible = True
        End If
    End Sub

    Private Sub rbNoencontrado_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoencontrado.CheckedChanged
        If rbNoencontrado.Checked = True Then
            gbFojas.Visible = False
        End If
    End Sub


    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            If txtIdSolicitud.Text = "" Then
                MessageBox.Show("Seleccione una solicitud primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim idSolicitud As Long = CLng(txtIdSolicitud.Text)
            Dim estado As String = ""
            If rbEncontrado.Checked Then
                estado = "Encontrado"
            ElseIf rbNoencontrado.Checked Then
                estado = "No Encontrado"
            Else
                MessageBox.Show("Debe seleccionar un estado de búsqueda.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim numeroFojas As Integer = 0
            If Not Integer.TryParse(txtNunFojas.Text.Trim(), numeroFojas) Then
                MessageBox.Show("Ingrese un número válido de fojas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim func As New Datos.fResultadoBusqueda

            If func.ActualizarEstadoSolicitud(idSolicitud, estado) AndAlso func.GuardarResultadoBusqueda(idSolicitud, estado, numeroFojas) Then
                MessageBox.Show("Resultado registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Recargar el DataGridView de frmSolicitudes
                For Each frm As Form In Application.OpenForms
                    If TypeOf frm Is frmSolicitudes Then
                        CType(frm, frmSolicitudes).CargarSolicitudes()
                        CType(frm, frmSolicitudes).MostrarSolicitudesEnGrid()
                        Exit For
                    End If
                Next

                Me.Close()
            Else
                MessageBox.Show("No se pudo guardar el resultado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Dim solicitud As New Entidades.EntSolicitudes
            With solicitud
                .gIdSolicitud = Convert.ToInt32(txtIdSolicitud.Text)
                .gApellidosNombres = txtSolicitante.Text
                .gDNI = txtDni.Text
                .gDireccion = txtDireccion.Text
                .gCelular = txtCelular.Text
                .gTipoDocumento = cboTipo.Text
                If rbCertificadas.Checked Then
                    .gCopias = "Certificadas"
                ElseIf rbSimples.Checked Then
                    .gCopias = "Simples"
                ElseIf rbTestimonio.Checked Then
                    .gCopias = "Testimonio"
                Else
                    .gCopias = "" ' O algún valor predeterminado si ninguno está seleccionado
                End If
                .gEstado = "En Busqueda"
            End With

            Dim funcSolicitud As New Datos.fSolicitudes
            Dim resultadoSolicitud = funcSolicitud.EditarSolicitud(solicitud)

            ' Detectar tipo de documento y actualizar detalle correspondiente
            Dim tipoDoc As String = cboTipo.Text


            Dim exitoDetalle As Boolean = False

            If tipoDoc = "Notarial" Then
                Dim detalle As New Entidades.EntDetalleNotarial
                With detalle
                    .gIdSolicitud = Convert.ToInt32(txtIdSolicitud.Text)
                    .gInstrumento = cboInstrumento.Text
                    .gActoProtocolar = txtActoProtocolar.Text
                    .gNotario = txtNotario.Text
                    .gFechaDocumento = dtpFechaDocumento.Value
                    .gOtorgadoPor = txtOtorga.Text
                    .gAFavor = txtAfavor.Text
                End With
                Dim f As New Datos.fDetalleNotarial
                exitoDetalle = f.EditarDetalleNotarial(detalle)

            ElseIf tipoDoc = "Judicial" Then
                Dim detalleJudicial As New Entidades.EntDetalleJudicial
                With detalleJudicial
                    .gIdSolicitud = Convert.ToInt32(txtIdSolicitud.Text)
                    .gTipoProceso = cboTipoProceso.Text
                    .gNumExpediente = txtNumExp.Text
                    .gMateria = txtMateria.Text
                    .gDemandante = txtDemandante.Text
                    .gDemandado = txtDemandado.Text
                End With
                Dim fJudicial As New Datos.fDetalleJudicial
                exitoDetalle = fJudicial.EditarDetalleJudicial(detalleJudicial)


            ElseIf tipoDoc = "Registro Civil" Then
                Dim detalleCivil As New Entidades.EntDetalleCivil
                With detalleCivil
                    .gIdSolicitud = Convert.ToInt32(txtIdSolicitud.Text)
                    .gTipoPartida = cboPartida.Text
                    .gProvincia = txtProvincia.Text
                    .gDistrito = txtDistrito.Text
                    .gInteresado = txtInteresado.Text
                    .gFechaPartida = dtpFechaDocumento.Value
                End With
                Dim fCivil As New Datos.fDetalleCivil
                exitoDetalle = fCivil.EditarDetalleCivil(detalleCivil)
            End If

            ' Actualizar pago
            Dim pago As New Entidades.EntPagos
            With pago
                .gIdSolicitud = Convert.ToInt32(txtIdSolicitud.Text)
                .gMonto = Convert.ToDecimal(txtMonto.Text)
                .gNumVoucher = txtNumVoucher.Text
                .gFechaPago = dtpFechaDocumento.Value
            End With
            Dim fPago As New Datos.fPagos
            Dim exitoPago = fPago.EditarPagos(pago)

            ' Mensaje final
            If resultadoSolicitud AndAlso exitoDetalle AndAlso exitoPago Then
                MessageBox.Show("Actualización completada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ocurrió un error durante la actualización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class