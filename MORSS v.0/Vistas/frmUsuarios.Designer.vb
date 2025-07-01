<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTitulo = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbApeNombres = New System.Windows.Forms.RadioButton()
        Me.rbDni = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgUsuarios = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cboArea = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboRol = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboActivo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboSexo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditarUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.txtIdUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtContraseña = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDni = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApeMaterno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblUsuarioDisponible = New System.Windows.Forms.Label()
        Me.lblDniDisponible = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApePaterno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombres = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.btnCerrar)
        Me.pnlTitulo.Controls.Add(Me.Label1)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1300, 57)
        Me.pnlTitulo.TabIndex = 2
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
        Me.btnCerrar.Location = New System.Drawing.Point(1250, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 20)
        Me.btnCerrar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbApeNombres)
        Me.GroupBox1.Controls.Add(Me.rbDni)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(33, 84)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(725, 155)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por"
        '
        'rbApeNombres
        '
        Me.rbApeNombres.AutoSize = True
        Me.rbApeNombres.Location = New System.Drawing.Point(309, 46)
        Me.rbApeNombres.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbApeNombres.Name = "rbApeNombres"
        Me.rbApeNombres.Size = New System.Drawing.Size(169, 24)
        Me.rbApeNombres.TabIndex = 2
        Me.rbApeNombres.Text = "Apellidos y Nombres"
        Me.rbApeNombres.UseVisualStyleBackColor = True
        '
        'rbDni
        '
        Me.rbDni.AutoSize = True
        Me.rbDni.Checked = True
        Me.rbDni.Location = New System.Drawing.Point(67, 46)
        Me.rbDni.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbDni.Name = "rbDni"
        Me.rbDni.Size = New System.Drawing.Size(56, 24)
        Me.rbDni.TabIndex = 2
        Me.rbDni.TabStop = True
        Me.rbDni.Text = "DNI"
        Me.rbDni.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscar.DefaultText = ""
        Me.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(84, 91)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PlaceholderText = ""
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.Size = New System.Drawing.Size(557, 42)
        Me.txtBuscar.TabIndex = 1
        '
        'dgUsuarios
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgUsuarios.ColumnHeadersHeight = 4
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUsuarios.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgUsuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUsuarios.Location = New System.Drawing.Point(33, 272)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.RowHeadersVisible = False
        Me.dgUsuarios.RowHeadersWidth = 51
        Me.dgUsuarios.RowTemplate.Height = 24
        Me.dgUsuarios.Size = New System.Drawing.Size(725, 381)
        Me.dgUsuarios.TabIndex = 6
        Me.dgUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgUsuarios.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgUsuarios.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgUsuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgUsuarios.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgUsuarios.ThemeStyle.HeaderStyle.Height = 4
        Me.dgUsuarios.ThemeStyle.ReadOnly = False
        Me.dgUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgUsuarios.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgUsuarios.ThemeStyle.RowsStyle.Height = 24
        Me.dgUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.cboArea)
        Me.Guna2Panel1.Controls.Add(Me.cboRol)
        Me.Guna2Panel1.Controls.Add(Me.cboActivo)
        Me.Guna2Panel1.Controls.Add(Me.cboSexo)
        Me.Guna2Panel1.Controls.Add(Me.btnEliminar)
        Me.Guna2Panel1.Controls.Add(Me.btnEditarUsuario)
        Me.Guna2Panel1.Controls.Add(Me.txtIdUsuario)
        Me.Guna2Panel1.Controls.Add(Me.txtContraseña)
        Me.Guna2Panel1.Controls.Add(Me.Label11)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Controls.Add(Me.txtUsuario)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Controls.Add(Me.txtDni)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.txtApeMaterno)
        Me.Guna2Panel1.Controls.Add(Me.lblContraseña)
        Me.Guna2Panel1.Controls.Add(Me.lblUsuarioDisponible)
        Me.Guna2Panel1.Controls.Add(Me.lblDniDisponible)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.txtApePaterno)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.txtNombres)
        Me.Guna2Panel1.Controls.Add(Me.Label9)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(766, 95)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(504, 651)
        Me.Guna2Panel1.TabIndex = 7
        '
        'cboArea
        '
        Me.cboArea.BackColor = System.Drawing.Color.Transparent
        Me.cboArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboArea.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboArea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboArea.ItemHeight = 30
        Me.cboArea.Items.AddRange(New Object() {"SIN ASIGNAR", "CIVIL", "JUDICIAL", "NOTARIAL"})
        Me.cboArea.Location = New System.Drawing.Point(178, 468)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(308, 36)
        Me.cboArea.TabIndex = 9
        '
        'cboRol
        '
        Me.cboRol.BackColor = System.Drawing.Color.Transparent
        Me.cboRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRol.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboRol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboRol.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboRol.ItemHeight = 30
        Me.cboRol.Items.AddRange(New Object() {"ADMINISTRADOR", "USUARIO"})
        Me.cboRol.Location = New System.Drawing.Point(178, 410)
        Me.cboRol.Name = "cboRol"
        Me.cboRol.Size = New System.Drawing.Size(308, 36)
        Me.cboRol.TabIndex = 9
        '
        'cboActivo
        '
        Me.cboActivo.BackColor = System.Drawing.Color.Transparent
        Me.cboActivo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActivo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboActivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboActivo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboActivo.ItemHeight = 30
        Me.cboActivo.Items.AddRange(New Object() {"1", "0"})
        Me.cboActivo.Location = New System.Drawing.Point(178, 526)
        Me.cboActivo.Name = "cboActivo"
        Me.cboActivo.Size = New System.Drawing.Size(87, 36)
        Me.cboActivo.TabIndex = 9
        '
        'cboSexo
        '
        Me.cboSexo.BackColor = System.Drawing.Color.Transparent
        Me.cboSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboSexo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboSexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboSexo.ItemHeight = 30
        Me.cboSexo.Items.AddRange(New Object() {"F", "M"})
        Me.cboSexo.Location = New System.Drawing.Point(399, 222)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(87, 36)
        Me.cboSexo.TabIndex = 9
        '
        'btnEliminar
        '
        Me.btnEliminar.BorderRadius = 4
        Me.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEliminar.FillColor = System.Drawing.Color.DeepPink
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(345, 588)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(141, 44)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnEditarUsuario
        '
        Me.btnEditarUsuario.BorderRadius = 4
        Me.btnEditarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditarUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnEditarUsuario.Location = New System.Drawing.Point(178, 588)
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Size = New System.Drawing.Size(141, 44)
        Me.btnEditarUsuario.TabIndex = 7
        Me.btnEditarUsuario.Text = "Actualizar"
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.BorderRadius = 4
        Me.txtIdUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdUsuario.DefaultText = ""
        Me.txtIdUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIdUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIdUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdUsuario.Location = New System.Drawing.Point(8, 24)
        Me.txtIdUsuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.PlaceholderText = ""
        Me.txtIdUsuario.SelectedText = ""
        Me.txtIdUsuario.Size = New System.Drawing.Size(82, 44)
        Me.txtIdUsuario.TabIndex = 6
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderRadius = 4
        Me.txtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseña.DefaultText = ""
        Me.txtContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseña.Location = New System.Drawing.Point(178, 350)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PlaceholderText = "Ingresa tu contraseña"
        Me.txtContraseña.ReadOnly = True
        Me.txtContraseña.SelectedText = ""
        Me.txtContraseña.Size = New System.Drawing.Size(308, 44)
        Me.txtContraseña.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(120, 480)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Area"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(83, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contraseña"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(120, 422)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 20)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Rol"
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderRadius = 4
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.DefaultText = ""
        Me.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(178, 287)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PlaceholderText = "Ingresa tu usuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.Size = New System.Drawing.Size(308, 44)
        Me.txtUsuario.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(120, 538)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Activo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(107, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(341, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Sexo"
        '
        'txtDni
        '
        Me.txtDni.BorderRadius = 4
        Me.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDni.DefaultText = ""
        Me.txtDni.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDni.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDni.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDni.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDni.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDni.Location = New System.Drawing.Point(178, 222)
        Me.txtDni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.PlaceholderText = "Ingresa tu DNI"
        Me.txtDni.ReadOnly = True
        Me.txtDni.SelectedText = ""
        Me.txtDni.Size = New System.Drawing.Size(141, 44)
        Me.txtDni.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(131, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DNI"
        '
        'txtApeMaterno
        '
        Me.txtApeMaterno.BorderRadius = 4
        Me.txtApeMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApeMaterno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApeMaterno.DefaultText = ""
        Me.txtApeMaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtApeMaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtApeMaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApeMaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApeMaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApeMaterno.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApeMaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApeMaterno.Location = New System.Drawing.Point(178, 160)
        Me.txtApeMaterno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtApeMaterno.Name = "txtApeMaterno"
        Me.txtApeMaterno.PlaceholderText = "Ingresa tu apellido materno"
        Me.txtApeMaterno.ReadOnly = True
        Me.txtApeMaterno.SelectedText = ""
        Me.txtApeMaterno.Size = New System.Drawing.Size(308, 44)
        Me.txtApeMaterno.TabIndex = 6
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.BackColor = System.Drawing.Color.Transparent
        Me.lblContraseña.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.Color.DimGray
        Me.lblContraseña.Location = New System.Drawing.Point(193, 484)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(0, 20)
        Me.lblContraseña.TabIndex = 5
        '
        'lblUsuarioDisponible
        '
        Me.lblUsuarioDisponible.AutoSize = True
        Me.lblUsuarioDisponible.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuarioDisponible.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioDisponible.ForeColor = System.Drawing.Color.DimGray
        Me.lblUsuarioDisponible.Location = New System.Drawing.Point(193, 347)
        Me.lblUsuarioDisponible.Name = "lblUsuarioDisponible"
        Me.lblUsuarioDisponible.Size = New System.Drawing.Size(0, 20)
        Me.lblUsuarioDisponible.TabIndex = 5
        '
        'lblDniDisponible
        '
        Me.lblDniDisponible.AutoSize = True
        Me.lblDniDisponible.BackColor = System.Drawing.Color.Transparent
        Me.lblDniDisponible.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDniDisponible.ForeColor = System.Drawing.Color.DimGray
        Me.lblDniDisponible.Location = New System.Drawing.Point(193, 270)
        Me.lblDniDisponible.Name = "lblDniDisponible"
        Me.lblDniDisponible.Size = New System.Drawing.Size(0, 20)
        Me.lblDniDisponible.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(40, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido Materno"
        '
        'txtApePaterno
        '
        Me.txtApePaterno.BorderRadius = 4
        Me.txtApePaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApePaterno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApePaterno.DefaultText = ""
        Me.txtApePaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtApePaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtApePaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApePaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtApePaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApePaterno.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApePaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtApePaterno.Location = New System.Drawing.Point(178, 97)
        Me.txtApePaterno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtApePaterno.Name = "txtApePaterno"
        Me.txtApePaterno.PlaceholderText = "Ingresa tu apellido paterno"
        Me.txtApePaterno.ReadOnly = True
        Me.txtApePaterno.SelectedText = ""
        Me.txtApePaterno.Size = New System.Drawing.Size(308, 44)
        Me.txtApePaterno.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(46, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido Paterno"
        '
        'txtNombres
        '
        Me.txtNombres.BorderRadius = 4
        Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombres.DefaultText = ""
        Me.txtNombres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombres.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombres.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombres.Location = New System.Drawing.Point(178, 36)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.PlaceholderText = "Ingresa tus nombres"
        Me.txtNombres.ReadOnly = True
        Me.txtNombres.SelectedText = ""
        Me.txtNombres.Size = New System.Drawing.Size(308, 44)
        Me.txtNombres.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(96, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Nombres"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 790)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUsuarios"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitulo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbApeNombres As RadioButton
    Friend WithEvents rbDni As RadioButton
    Friend WithEvents txtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgUsuarios As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cboSexo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnEditarUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtContraseña As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDni As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApeMaterno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblUsuarioDisponible As Label
    Friend WithEvents lblDniDisponible As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApePaterno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombres As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboActivo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboRol As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIdUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cboArea As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label11 As Label
End Class
