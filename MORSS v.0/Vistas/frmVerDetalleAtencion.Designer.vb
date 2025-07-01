<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerDetalleAtencion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlTitulo = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCerrarSolicitudes = New Guna.UI2.WinForms.Guna2Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnArchivar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAtender = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpFechaDocumento = New System.Windows.Forms.DateTimePicker()
        Me.txtIdSolicitud = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cboPartida = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.gDatos = New System.Windows.Forms.GroupBox()
        Me.txtVoucher = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMonto1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCopias = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNunFojas = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboTipo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gbPago = New System.Windows.Forms.GroupBox()
        Me.txtNumVoucher = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMonto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Estado = New System.Windows.Forms.Label()
        Me.lblPartida = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDireccion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDni = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEstado = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCelular = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSolicitante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlTitulo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gDatos.SuspendLayout()
        Me.gbPago.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlTitulo.Controls.Add(Me.btnCerrar)
        Me.pnlTitulo.Controls.Add(Me.btnCerrarSolicitudes)
        Me.pnlTitulo.Controls.Add(Me.Label25)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1180, 57)
        Me.pnlTitulo.TabIndex = 4
        '
        'btnCerrar
        '
        Me.btnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCerrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = Global.MORSS_v._0.My.Resources.Resources.icons8_Close_30px
        Me.btnCerrar.Location = New System.Drawing.Point(1117, 18)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 20)
        Me.btnCerrar.TabIndex = 2
        '
        'btnCerrarSolicitudes
        '
        Me.btnCerrarSolicitudes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrarSolicitudes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrarSolicitudes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCerrarSolicitudes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCerrarSolicitudes.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCerrarSolicitudes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCerrarSolicitudes.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSolicitudes.Image = Global.MORSS_v._0.My.Resources.Resources.icons8_Close_30px
        Me.btnCerrarSolicitudes.Location = New System.Drawing.Point(1268, 12)
        Me.btnCerrarSolicitudes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrarSolicitudes.Name = "btnCerrarSolicitudes"
        Me.btnCerrarSolicitudes.Size = New System.Drawing.Size(20, 20)
        Me.btnCerrarSolicitudes.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label25.Location = New System.Drawing.Point(12, 18)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 20)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "DETALLE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnArchivar)
        Me.GroupBox2.Controls.Add(Me.btnAtender)
        Me.GroupBox2.Controls.Add(Me.dtpFechaDocumento)
        Me.GroupBox2.Controls.Add(Me.txtIdSolicitud)
        Me.GroupBox2.Controls.Add(Me.cboPartida)
        Me.GroupBox2.Controls.Add(Me.gDatos)
        Me.GroupBox2.Controls.Add(Me.cboTipo)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.gbPago)
        Me.GroupBox2.Controls.Add(Me.Estado)
        Me.GroupBox2.Controls.Add(Me.lblPartida)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.txtDni)
        Me.GroupBox2.Controls.Add(Me.txtEstado)
        Me.GroupBox2.Controls.Add(Me.txtCelular)
        Me.GroupBox2.Controls.Add(Me.txtSolicitante)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1156, 398)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del solicitante"
        '
        'btnArchivar
        '
        Me.btnArchivar.BorderRadius = 4
        Me.btnArchivar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnArchivar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnArchivar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnArchivar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnArchivar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnArchivar.ForeColor = System.Drawing.Color.White
        Me.btnArchivar.Location = New System.Drawing.Point(1004, 336)
        Me.btnArchivar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnArchivar.Name = "btnArchivar"
        Me.btnArchivar.Size = New System.Drawing.Size(129, 46)
        Me.btnArchivar.TabIndex = 17
        Me.btnArchivar.Text = "Archivar"
        '
        'btnAtender
        '
        Me.btnAtender.BorderRadius = 4
        Me.btnAtender.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAtender.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAtender.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAtender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAtender.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAtender.ForeColor = System.Drawing.Color.White
        Me.btnAtender.Location = New System.Drawing.Point(841, 336)
        Me.btnAtender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAtender.Name = "btnAtender"
        Me.btnAtender.Size = New System.Drawing.Size(129, 46)
        Me.btnAtender.TabIndex = 17
        Me.btnAtender.Text = "Atender"
        '
        'dtpFechaDocumento
        '
        Me.dtpFechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDocumento.Location = New System.Drawing.Point(598, 285)
        Me.dtpFechaDocumento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFechaDocumento.Name = "dtpFechaDocumento"
        Me.dtpFechaDocumento.Size = New System.Drawing.Size(191, 27)
        Me.dtpFechaDocumento.TabIndex = 21
        '
        'txtIdSolicitud
        '
        Me.txtIdSolicitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdSolicitud.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdSolicitud.DefaultText = ""
        Me.txtIdSolicitud.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIdSolicitud.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIdSolicitud.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdSolicitud.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdSolicitud.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdSolicitud.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdSolicitud.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdSolicitud.Location = New System.Drawing.Point(10, 98)
        Me.txtIdSolicitud.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdSolicitud.Name = "txtIdSolicitud"
        Me.txtIdSolicitud.PlaceholderText = ""
        Me.txtIdSolicitud.SelectedText = ""
        Me.txtIdSolicitud.Size = New System.Drawing.Size(76, 44)
        Me.txtIdSolicitud.TabIndex = 6
        '
        'cboPartida
        '
        Me.cboPartida.BackColor = System.Drawing.Color.Transparent
        Me.cboPartida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPartida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartida.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPartida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPartida.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboPartida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboPartida.ItemHeight = 30
        Me.cboPartida.Items.AddRange(New Object() {"Nacimiento", "Matrimonio", "Defuncion"})
        Me.cboPartida.Location = New System.Drawing.Point(548, 228)
        Me.cboPartida.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboPartida.Name = "cboPartida"
        Me.cboPartida.Size = New System.Drawing.Size(241, 36)
        Me.cboPartida.TabIndex = 20
        Me.cboPartida.Visible = False
        '
        'gDatos
        '
        Me.gDatos.Controls.Add(Me.txtVoucher)
        Me.gDatos.Controls.Add(Me.Label6)
        Me.gDatos.Controls.Add(Me.txtMonto1)
        Me.gDatos.Controls.Add(Me.Label1)
        Me.gDatos.Controls.Add(Me.txtCopias)
        Me.gDatos.Controls.Add(Me.txtNunFojas)
        Me.gDatos.Controls.Add(Me.Label7)
        Me.gDatos.Controls.Add(Me.Label24)
        Me.gDatos.Location = New System.Drawing.Point(839, 27)
        Me.gDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gDatos.Name = "gDatos"
        Me.gDatos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gDatos.Size = New System.Drawing.Size(294, 285)
        Me.gDatos.TabIndex = 2
        Me.gDatos.TabStop = False
        Me.gDatos.Text = "Datos"
        '
        'txtVoucher
        '
        Me.txtVoucher.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVoucher.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVoucher.DefaultText = ""
        Me.txtVoucher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVoucher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVoucher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVoucher.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtVoucher.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVoucher.Location = New System.Drawing.Point(115, 208)
        Me.txtVoucher.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.PlaceholderText = ""
        Me.txtVoucher.SelectedText = ""
        Me.txtVoucher.Size = New System.Drawing.Size(153, 44)
        Me.txtVoucher.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "N° Voucher"
        '
        'txtMonto1
        '
        Me.txtMonto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMonto1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMonto1.DefaultText = ""
        Me.txtMonto1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMonto1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMonto1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMonto1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMonto1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMonto1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMonto1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMonto1.Location = New System.Drawing.Point(115, 156)
        Me.txtMonto1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMonto1.Name = "txtMonto1"
        Me.txtMonto1.PlaceholderText = ""
        Me.txtMonto1.SelectedText = ""
        Me.txtMonto1.Size = New System.Drawing.Size(153, 44)
        Me.txtMonto1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Monto  S/."
        '
        'txtCopias
        '
        Me.txtCopias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCopias.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCopias.DefaultText = ""
        Me.txtCopias.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCopias.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCopias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCopias.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCopias.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCopias.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCopias.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCopias.Location = New System.Drawing.Point(113, 47)
        Me.txtCopias.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCopias.Name = "txtCopias"
        Me.txtCopias.PlaceholderText = ""
        Me.txtCopias.SelectedText = ""
        Me.txtCopias.Size = New System.Drawing.Size(153, 46)
        Me.txtCopias.TabIndex = 5
        '
        'txtNunFojas
        '
        Me.txtNunFojas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNunFojas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNunFojas.DefaultText = ""
        Me.txtNunFojas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNunFojas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNunFojas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNunFojas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNunFojas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNunFojas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNunFojas.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNunFojas.Location = New System.Drawing.Point(115, 102)
        Me.txtNunFojas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNunFojas.Name = "txtNunFojas"
        Me.txtNunFojas.PlaceholderText = ""
        Me.txtNunFojas.SelectedText = ""
        Me.txtNunFojas.Size = New System.Drawing.Size(153, 46)
        Me.txtNunFojas.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Copias"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(19, 116)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 20)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Cant. Fojas"
        '
        'cboTipo
        '
        Me.cboTipo.BackColor = System.Drawing.Color.Transparent
        Me.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTipo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboTipo.ItemHeight = 30
        Me.cboTipo.Items.AddRange(New Object() {"Notarial", "Judicial", "Registro Civil"})
        Me.cboTipo.Location = New System.Drawing.Point(200, 228)
        Me.cboTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(241, 36)
        Me.cboTipo.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(526, 289)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 20)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Fecha"
        '
        'gbPago
        '
        Me.gbPago.Controls.Add(Me.txtNumVoucher)
        Me.gbPago.Controls.Add(Me.Label11)
        Me.gbPago.Controls.Add(Me.txtMonto)
        Me.gbPago.Controls.Add(Me.Label3)
        Me.gbPago.Location = New System.Drawing.Point(839, 27)
        Me.gbPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbPago.Name = "gbPago"
        Me.gbPago.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbPago.Size = New System.Drawing.Size(261, 186)
        Me.gbPago.TabIndex = 2
        Me.gbPago.TabStop = False
        Me.gbPago.Text = "Pago"
        Me.gbPago.Visible = False
        '
        'txtNumVoucher
        '
        Me.txtNumVoucher.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumVoucher.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumVoucher.DefaultText = ""
        Me.txtNumVoucher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNumVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNumVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumVoucher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumVoucher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumVoucher.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNumVoucher.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumVoucher.Location = New System.Drawing.Point(115, 92)
        Me.txtNumVoucher.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumVoucher.Name = "txtNumVoucher"
        Me.txtNumVoucher.PlaceholderText = ""
        Me.txtNumVoucher.SelectedText = ""
        Me.txtNumVoucher.Size = New System.Drawing.Size(125, 44)
        Me.txtNumVoucher.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 20)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "N° Voucher"
        '
        'txtMonto
        '
        Me.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMonto.DefaultText = ""
        Me.txtMonto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMonto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMonto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMonto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMonto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMonto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMonto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMonto.Location = New System.Drawing.Point(115, 38)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PlaceholderText = ""
        Me.txtMonto.SelectedText = ""
        Me.txtMonto.Size = New System.Drawing.Size(125, 46)
        Me.txtMonto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Monto     S/."
        '
        'Estado
        '
        Me.Estado.AutoSize = True
        Me.Estado.Location = New System.Drawing.Point(120, 297)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(54, 20)
        Me.Estado.TabIndex = 18
        Me.Estado.Text = "Estado"
        '
        'lblPartida
        '
        Me.lblPartida.AutoSize = True
        Me.lblPartida.Location = New System.Drawing.Point(467, 235)
        Me.lblPartida.Name = "lblPartida"
        Me.lblPartida.Size = New System.Drawing.Size(55, 20)
        Me.lblPartida.TabIndex = 17
        Me.lblPartida.Text = "Partida"
        Me.lblPartida.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(131, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Tipo "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Dirección"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(119, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "DNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(467, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Celular"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Solicitante"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDireccion.DefaultText = ""
        Me.txtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(200, 158)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PlaceholderText = ""
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.Size = New System.Drawing.Size(589, 46)
        Me.txtDireccion.TabIndex = 4
        '
        'txtDni
        '
        Me.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDni.DefaultText = ""
        Me.txtDni.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDni.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDni.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDni.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDni.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDni.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDni.Location = New System.Drawing.Point(200, 98)
        Me.txtDni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.PlaceholderText = ""
        Me.txtDni.ReadOnly = True
        Me.txtDni.SelectedText = ""
        Me.txtDni.Size = New System.Drawing.Size(243, 46)
        Me.txtDni.TabIndex = 2
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEstado.DefaultText = ""
        Me.txtEstado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEstado.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEstado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEstado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEstado.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEstado.Location = New System.Drawing.Point(198, 285)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.PlaceholderText = ""
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.SelectedText = ""
        Me.txtEstado.Size = New System.Drawing.Size(243, 46)
        Me.txtEstado.TabIndex = 3
        '
        'txtCelular
        '
        Me.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCelular.DefaultText = ""
        Me.txtCelular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCelular.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCelular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCelular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCelular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCelular.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCelular.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCelular.Location = New System.Drawing.Point(548, 98)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.PlaceholderText = ""
        Me.txtCelular.ReadOnly = True
        Me.txtCelular.SelectedText = ""
        Me.txtCelular.Size = New System.Drawing.Size(243, 46)
        Me.txtCelular.TabIndex = 3
        '
        'txtSolicitante
        '
        Me.txtSolicitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSolicitante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSolicitante.DefaultText = ""
        Me.txtSolicitante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSolicitante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSolicitante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSolicitante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSolicitante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSolicitante.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSolicitante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSolicitante.Location = New System.Drawing.Point(200, 39)
        Me.txtSolicitante.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.PlaceholderText = ""
        Me.txtSolicitante.ReadOnly = True
        Me.txtSolicitante.SelectedText = ""
        Me.txtSolicitante.Size = New System.Drawing.Size(589, 46)
        Me.txtSolicitante.TabIndex = 1
        '
        'frmVerDetalleAtencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1180, 518)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVerDetalleAtencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVerDetalleAtencion"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gDatos.ResumeLayout(False)
        Me.gDatos.PerformLayout()
        Me.gbPago.ResumeLayout(False)
        Me.gbPago.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlTitulo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCerrarSolicitudes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtIdSolicitud As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gDatos As GroupBox
    Friend WithEvents txtMonto1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNunFojas As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents gbPago As GroupBox
    Friend WithEvents txtNumVoucher As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMonto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDireccion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDni As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCelular As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSolicitante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpFechaDocumento As DateTimePicker
    Friend WithEvents cboPartida As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtVoucher As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboTipo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblPartida As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAtender As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnArchivar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCopias As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Estado As Label
    Friend WithEvents txtEstado As Guna.UI2.WinForms.Guna2TextBox
End Class
