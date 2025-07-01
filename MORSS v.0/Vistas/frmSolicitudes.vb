Imports System.Diagnostics.Eventing.Reader
Imports System.Net.Mime.MediaTypeNames
Imports Datos
Imports Entidades
Public Class frmSolicitudes

    Public Property rolActual As String
    Public Property areaActual As String
    Public Property IdUsuarioActual As String


    Dim ObjetoClaseESolicitudes As New EntSolicitudes
    Dim ObjetoClaseFSolicitudes As New fSolicitudes
    Dim ObjetoClaseEDetalleNotarial As New EntDetalleNotarial
    Dim ObjetoClaseFDetalleNotarial As New fDetalleNotarial
    Dim ObjetoClaseEDetalleJudicial As New EntDetalleJudicial
    Dim ObjetoClaseFDetalleJudicial As New fDetalleJudicial
    Dim ObjetoClaseEDetalleCivil As New EntDetalleCivil
    Dim ObjetoClaseFDetalleCivil As New fDetalleCivil
    Dim ObjetoClaseEPagos As New EntPagos
    Dim ObjetoClaseFPagos As New fPagos
    Private Sub btnCerrarSolicitudes_Click(sender As Object, e As EventArgs) Handles btnCerrarSolicitudes.Click
        Me.Close()
    End Sub
    Public Sub MostrarSolicitudesEnGrid()
        Try
            Dim func As New Datos.fSolicitudes
            Dim tabla As DataTable = func.MostrarSolicitudes()

            If tabla IsNot Nothing AndAlso tabla.Rows.Count > 0 Then
                dgSolicitudes.DataSource = Nothing
                dgSolicitudes.AutoGenerateColumns = True
                dgSolicitudes.DataSource = tabla
                OcultarColumnas(dgSolicitudes, "IdSolicitud", "IdUsuario", "TipoDocumento")
                dgSolicitudes.ColumnHeadersVisible = True
                FormatearGrid()
            Else
                dgSolicitudes.DataSource = Nothing
                MessageBox.Show("No se encontraron solicitudes para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar las solicitudes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CargarSolicitudes()
        Try
            Dim rolUsuario As String = frmPrincipal.rolActual
            Dim areaUsuario As String = frmPrincipal.areaActual

            ' Ocultar pestañas si es usuario
            If rolUsuario = "Usuario" Then
                OcultarPestanasUsuario()
            End If

            ' Cargar solicitudes según rol y área
            Dim func As New Datos.fSolicitudes
            Dim tabla As DataTable = func.MostrarSolicitudesPorRolYArea(rolUsuario, areaUsuario)

            If tabla IsNot Nothing AndAlso tabla.Rows.Count > 0 Then
                dgBusqueda.DataSource = Nothing
                dgBusqueda.AutoGenerateColumns = True
                dgBusqueda.DataSource = tabla
                OcultarColumnas(dgBusqueda, "IdSolicitud", "IdUsuario", "TipoDocumento")
                dgBusqueda.ColumnHeadersVisible = True
                FormatearGrid()
            Else
                dgBusqueda.DataSource = Nothing
                MessageBox.Show("No se encontraron solicitudes para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar las solicitudes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub OcultarPestanasUsuario()
        For Each tab As TabPage In tbcSolicitudes.TabPages.Cast(Of TabPage).ToList()
            If tab.Name = "tpBuscar" OrElse tab.Name = "tpRegistrar" OrElse tab.Name = "tpAtencion" Then
                tbcSolicitudes.TabPages.Remove(tab)
            End If
        Next
    End Sub

    Private Sub FormatearGrid()
        With dgSolicitudes
            ' Asegura que los encabezados se vean
            .ColumnHeadersVisible = True
            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeight = 30
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            ' Autoajustar columnas
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            ' Mostrar nombres personalizados
            If .Columns.Contains("NumSolicitud") Then .Columns("NumSolicitud").HeaderText = "N° Solicitud"
            If .Columns.Contains("ApellidosNombres") Then .Columns("ApellidosNombres").HeaderText = "Solicitante"
            If .Columns.Contains("DNI") Then .Columns("DNI").HeaderText = "DNI"
            If .Columns.Contains("TipoDocumento") Then .Columns("TipoDocumento").HeaderText = "Tipo de Documento"
            If .Columns.Contains("Copias") Then .Columns("Copias").HeaderText = "Tipo de Copia"
            If .Columns.Contains("Estado") Then .Columns("Estado").HeaderText = "Estado Actual"
            If .Columns.Contains("FechaRegistro") Then .Columns("FechaRegistro").HeaderText = "Fecha de Registro"

            ' Ocultar columnas innecesarias (ejemplo)
            If .Columns.Contains("IdUsuario") Then .Columns("IdUsuario").Visible = False
            If .Columns.Contains("Direccion") Then .Columns("Direccion").Visible = False
        End With
        With dgBusqueda
            ' Asegura que los encabezados se vean
            .ColumnHeadersVisible = True
            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeight = 30
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            ' Autoajustar columnas
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            ' Mostrar nombres personalizados
            If .Columns.Contains("NumSolicitud") Then .Columns("NumSolicitud").HeaderText = "N° Solicitud"
            If .Columns.Contains("ApellidosNombres") Then .Columns("ApellidosNombres").HeaderText = "Solicitante"
            If .Columns.Contains("DNI") Then .Columns("DNI").HeaderText = "DNI"
            If .Columns.Contains("TipoDocumento") Then .Columns("TipoDocumento").HeaderText = "Tipo de Documento"
            If .Columns.Contains("Copias") Then .Columns("Copias").HeaderText = "Tipo de Copia"
            If .Columns.Contains("Estado") Then .Columns("Estado").HeaderText = "Estado Actual"
            If .Columns.Contains("FechaRegistro") Then .Columns("FechaRegistro").HeaderText = "Fecha de Registro"

            ' Ocultar columnas innecesarias (ejemplo)
            If .Columns.Contains("IdUsuario") Then .Columns("IdUsuario").Visible = False
            If .Columns.Contains("Direccion") Then .Columns("Direccion").Visible = False
        End With
    End Sub

    Private Sub OcultarColumnas(grid As DataGridView, ParamArray nombresColumnas() As String)
        For Each nombre In nombresColumnas
            If grid.Columns.Contains(nombre) Then
                grid.Columns(nombre).Visible = False
            End If
        Next
    End Sub
    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        If cboTipo.SelectedIndex = 0 Then
            cboPartida.Visible = False
            pnlNotarial.Visible = True
            pnlCivil.Visible = False
            pnlJudicial.Visible = False
        Else
            cboPartida.Visible = False
            lblPartida.Visible = False
        End If
        If cboTipo.SelectedIndex = 1 Then
            cboPartida.Visible = False
            pnlJudicial.Visible = True
            pnlCivil.Visible = False
            pnlNotarial.Visible = False
        Else
            cboPartida.Visible = False
            lblPartida.Visible = False
        End If
        If cboTipo.SelectedIndex = 2 Then
            cboPartida.Visible = True
            lblPartida.Visible = True
            pnlCivil.Visible = True
            pnlJudicial.Visible = False
            pnlNotarial.Visible = False
        Else
            cboPartida.Visible = False
            lblPartida.Visible = False
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Validación simple
        If txtSolicitante.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el nombre del solicitante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Crear objeto solicitud

        ObjetoClaseESolicitudes.gIdUsuario = IdUsuarioActual
        ObjetoClaseESolicitudes.gNumSolicitud = lblNumSolicitud.Text
        ObjetoClaseESolicitudes.gApellidosNombres = txtSolicitante.Text
        ObjetoClaseESolicitudes.gDNI = txtDni.Text
        ObjetoClaseESolicitudes.gCelular = txtCelular.Text
        ObjetoClaseESolicitudes.gDireccion = txtDireccion.Text
        ObjetoClaseESolicitudes.gTipoDocumento = cboTipo.Text

        If rbCertificadas.Checked Then
            ObjetoClaseESolicitudes.gCopias = "Certificadas"
        ElseIf rbSimples.Checked Then
            ObjetoClaseESolicitudes.gCopias = "Simples"
        ElseIf rbTestimonio.Checked Then
            ObjetoClaseESolicitudes.gCopias = "Testimonio"
        Else
            ObjetoClaseESolicitudes.gCopias = ""
        End If

        ObjetoClaseESolicitudes.gEstado = "En Búsqueda"
        ObjetoClaseESolicitudes.gFechaRegistro = DateTime.Today

        ' Insertar solicitud
        Dim idGenerado As Long = 0
        If ObjetoClaseFSolicitudes.InsertarSolicitudes(ObjetoClaseESolicitudes, idGenerado) Then
            txtIdSolicitud.Text = idGenerado.ToString()

            Dim tipoDocumento As String = cboTipo.Text
            Dim detalleGuardado As Boolean = False

            Select Case tipoDocumento
                Case "Notarial"
                    Dim detalleN As New Entidades.EntDetalleNotarial
                    detalleN.gIdSolicitud = idGenerado
                    detalleN.gInstrumento = cboInstrumento.Text
                    detalleN.gActoProtocolar = txtActoProtocolar.Text
                    detalleN.gNotario = txtNotario.Text
                    detalleN.gFechaDocumento = dtpFechaDocumento.Value
                    detalleN.gOtorgadoPor = txtOtorga.Text
                    detalleN.gAFavor = txtAfavor.Text

                    detalleGuardado = ObjetoClaseFDetalleNotarial.InsertarDetalleNotarial(detalleN)

                Case "Judicial"
                    Dim detalleJ As New Entidades.EntDetalleJudicial
                    detalleJ.gIdSolicitud = idGenerado
                    detalleJ.gTipoProceso = cboTipoProceso.SelectedItem
                    detalleJ.gNumExpediente = txtNumExp.Text
                    detalleJ.gMateria = txtMateria.Text
                    detalleJ.gDemandante = txtDemandante.Text
                    detalleJ.gDemandado = txtDemandado.Text

                    detalleGuardado = ObjetoClaseFDetalleJudicial.InsertarDetalleJudicial(detalleJ)

                Case "Registro Civil"
                    Dim detalleC As New Entidades.EntDetalleCivil
                    detalleC.gIdSolicitud = idGenerado
                    detalleC.gTipoPartida = cboPartida.Text
                    detalleC.gProvincia = txtProvincia.Text
                    detalleC.gDistrito = txtDistrito.Text
                    detalleC.gInteresado = txtInteresado.Text
                    detalleC.gFechaPartida = dtpFechaDocumento.Value

                    detalleGuardado = ObjetoClaseFDetalleCivil.InsertarDetalleCivil(detalleC)
            End Select

            ' Si el detalle fue guardado, se procede a guardar el pago
            If detalleGuardado Then
                Dim pago As New Entidades.EntPagos
                pago.gIdSolicitud = idGenerado
                pago.gMonto = Convert.ToDecimal(txtMonto.Text)
                pago.gNumVoucher = txtNumVoucher.Text
                pago.gFechaPago = dtpFechaDocumento.Value

                If ObjetoClaseFPagos.InsertarPagos(pago) Then
                    MessageBox.Show("Todo guardado correctamente: solicitud, detalle y pago.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    MostrarSolicitudesEnGrid()
                    CargarSolicitudes()
                Else
                    MessageBox.Show("Solicitud y detalle guardados, pero falló al guardar el pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Solicitud guardada, pero falló el detalle de tipo " & tipoDocumento & ".", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Error al grabar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Sub Limpiar()
        txtSolicitante.Clear()
        txtDni.Clear()
        txtCelular.Clear()
        txtDireccion.Clear()
        txtMonto.Clear()
        txtNumVoucher.Clear()
        cboTipo.SelectedIndex = -1
        cboPartida.SelectedIndex = -1
        cboTipoProceso.SelectedIndex = -1
        txtNumExp.Clear()
        txtMateria.Clear()
        txtDemandante.Clear()
        txtDemandado.Clear()
        cboInstrumento.SelectedIndex = -1
        txtActoProtocolar.Clear()
        txtNotario.Clear()
        txtOtorga.Clear()
        txtAfavor.Clear()
        txtProvincia.Clear()
        txtDistrito.Clear()
        txtInteresado.Clear()
        txtIdSolicitud.Clear()
    End Sub

    Private Sub frmSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarSolicitudesEnGrid()
        CargarSolicitudes()
        CargarSolicitudesConResultados()
        txtIdUsuario.Text = frmPrincipal.txtIdUsuario.Text
        ' Llamar al método con el rol actual
        OcultarPestanasSegunRol()

    End Sub
    Private Sub OcultarPestanasSegunRol()
        Try
            If rolActual = "Usuario" Then
                ' Crear lista de nombres de pestañas a ocultar
                Dim pestañasAOcultar As New List(Of String) From {"tpBuscar", "tpRegistrar", "tpAtencion"}

                ' Recorrer en reversa para evitar errores al remover
                For i As Integer = tbcSolicitudes.TabPages.Count - 1 To 0 Step -1
                    Dim tab As TabPage = tbcSolicitudes.TabPages(i)
                    If pestañasAOcultar.Contains(tab.Name) Then
                        tbcSolicitudes.TabPages.Remove(tab)
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error al ocultar pestañas: " & ex.Message)
        End Try
    End Sub


    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        If rbDni.Checked Then
            FiltrarSolicitudes("DNI", txtBuscar.Text.Trim())
        ElseIf rbApeNombres.Checked Then
            FiltrarSolicitudes("ApellidosNombres", txtBuscar.Text.Trim())
        End If
    End Sub
    Private Sub FiltrarSolicitudes(columna As String, valor As String)
        Try
            Dim func As New Datos.fSolicitudes
            Dim tabla As DataTable = func.BuscarSolicitudes(columna, valor)

            If tabla IsNot Nothing Then
                dgSolicitudes.DataSource = tabla
                FormatearGrid()
            Else
                dgSolicitudes.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error al filtrar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgBusqueda_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBusqueda.CellDoubleClick
        Try
            ' Validar que no sea encabezado
            If e.RowIndex >= 0 Then
                Dim fila As DataGridViewRow = dgBusqueda.Rows(e.RowIndex)
                Dim idSolicitud As Integer = Convert.ToInt32(fila.Cells("IdSolicitud").Value)

                ' Abrir el formulario de detalle
                Dim frm As New frmVerDetalle()
                frm.IdSolicitud = idSolicitud ' ← Pasamos el ID
                frm.TipoDocumento = fila.Cells("TipoDocumento").Value.ToString() ' ← Pasamos el tipo
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al abrir detalle: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgSolicitudes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSolicitudes.CellDoubleClick
        Try
            ' Validar que no sea encabezado
            If e.RowIndex >= 0 Then
                Dim fila As DataGridViewRow = dgSolicitudes.Rows(e.RowIndex)
                Dim idSolicitud As Integer = Convert.ToInt32(fila.Cells("IdSolicitud").Value)

                ' Abrir el formulario de detalle
                Dim frm As New frmVerDetalle()
                frm.IdSolicitud = idSolicitud ' ← Pasamos el ID
                frm.TipoDocumento = fila.Cells("TipoDocumento").Value.ToString() ' ← Pasamos el tipo
                frm.gbPago.Visible = True
                frm.btnActualizar.Visible = True
                frm.ShowDialog()

            End If
        Catch ex As Exception
            MessageBox.Show("Error al abrir detalle: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgAtencion_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAtencion.CellDoubleClick
        Try
            If e.RowIndex >= 0 Then
                Dim fila As DataGridViewRow = dgAtencion.Rows(e.RowIndex)
                Dim idSolicitud As Integer = Convert.ToInt32(fila.Cells("IdSolicitud").Value)

                ' Abrir formulario de detalle
                Dim frm As New frmVerDetalleAtencion()
                frm.IdSolicitud = idSolicitud ' Asegúrate de tener esta propiedad pública en frmVerDetalleAtencion
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al abrir detalle: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarSolicitudesConResultados()
        Try
            Dim func As New Datos.fSolicitudes
            Dim tabla As DataTable = func.MostrarSolicitudesConResultados()

            If tabla IsNot Nothing Then
                dgAtencion.DataSource = tabla
                FormatearGridAtencion()
            Else
                MessageBox.Show("No se pudieron cargar los datos de atención.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatearGridAtencion()
        With dgAtencion
            .ColumnHeadersVisible = True
            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeight = 30
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 88, 255)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True

            ' Encabezados personalizados
            If .Columns.Contains("NumSolicitud") Then .Columns("NumSolicitud").HeaderText = "N° Solicitud"
            If .Columns.Contains("ApellidosNombres") Then .Columns("ApellidosNombres").HeaderText = "Solicitante"
            If .Columns.Contains("DNI") Then .Columns("DNI").HeaderText = "DNI"
            If .Columns.Contains("TipoDocumento") Then .Columns("TipoDocumento").HeaderText = "Tipo de Documento"
            If .Columns.Contains("Copias") Then .Columns("Copias").HeaderText = "Tipo de Copia"
            If .Columns.Contains("EstadoSolicitud") Then .Columns("EstadoSolicitud").HeaderText = "Estado"
            If .Columns.Contains("EstadoBusqueda") Then .Columns("EstadoBusqueda").HeaderText = "Resultado Búsqueda"
            If .Columns.Contains("NumeroFojas") Then .Columns("NumeroFojas").HeaderText = "N° Fojas"
            If .Columns.Contains("FechaRegistro") Then .Columns("FechaRegistro").HeaderText = "Fecha de Registro"
        End With
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtBuscar.Clear()
    End Sub


End Class