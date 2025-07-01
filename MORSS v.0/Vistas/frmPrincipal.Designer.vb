<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTitulo = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlLateral = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cirbwomen = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.cirbman = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.txtIdUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCerrarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUsuarios = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReportes = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSolicitudes = New Guna.UI2.WinForms.Guna2Button()
        Me.btnInicio = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlLateral.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.cirbwomen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cirbman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.Label1)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1663, 78)
        Me.pnlTitulo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MODULO DE REGISTRO Y SEGUIMIENTO DE SOLICITUDES"
        '
        'pnlLateral
        '
        Me.pnlLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pnlLateral.Controls.Add(Me.Guna2Panel2)
        Me.pnlLateral.Controls.Add(Me.lblSexo)
        Me.pnlLateral.Controls.Add(Me.lblRol)
        Me.pnlLateral.Controls.Add(Me.txtIdUsuario)
        Me.pnlLateral.Controls.Add(Me.btnCerrarSesion)
        Me.pnlLateral.Controls.Add(Me.btnUsuarios)
        Me.pnlLateral.Controls.Add(Me.btnReportes)
        Me.pnlLateral.Controls.Add(Me.btnSolicitudes)
        Me.pnlLateral.Controls.Add(Me.btnInicio)
        Me.pnlLateral.Controls.Add(Me.Guna2Panel1)
        Me.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLateral.Location = New System.Drawing.Point(0, 78)
        Me.pnlLateral.Name = "pnlLateral"
        Me.pnlLateral.Size = New System.Drawing.Size(237, 971)
        Me.pnlLateral.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.cirbwomen)
        Me.Guna2Panel2.Controls.Add(Me.cirbman)
        Me.Guna2Panel2.Controls.Add(Me.lblUser)
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 883)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(237, 88)
        Me.Guna2Panel2.TabIndex = 8
        '
        'cirbwomen
        '
        Me.cirbwomen.Image = Global.MORSS_v._0.My.Resources.Resources.user_women
        Me.cirbwomen.ImageRotate = 0!
        Me.cirbwomen.Location = New System.Drawing.Point(31, 12)
        Me.cirbwomen.Name = "cirbwomen"
        Me.cirbwomen.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cirbwomen.Size = New System.Drawing.Size(65, 64)
        Me.cirbwomen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cirbwomen.TabIndex = 9
        Me.cirbwomen.TabStop = False
        '
        'cirbman
        '
        Me.cirbman.Image = Global.MORSS_v._0.My.Resources.Resources.user_man
        Me.cirbman.ImageRotate = 0!
        Me.cirbman.Location = New System.Drawing.Point(31, 12)
        Me.cirbman.Name = "cirbman"
        Me.cirbman.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cirbman.Size = New System.Drawing.Size(65, 64)
        Me.cirbman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cirbman.TabIndex = 9
        Me.cirbman.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUser.Location = New System.Drawing.Point(113, 33)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(76, 25)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "usuario"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(153, 383)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(36, 16)
        Me.lblSexo.TabIndex = 7
        Me.lblSexo.Text = "sexo"
        Me.lblSexo.Visible = False
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(74, 427)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(22, 16)
        Me.lblRol.TabIndex = 7
        Me.lblRol.Text = "rol"
        Me.lblRol.Visible = False
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdUsuario.DefaultText = ""
        Me.txtIdUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIdUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIdUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdUsuario.Location = New System.Drawing.Point(10, 371)
        Me.txtIdUsuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.PlaceholderText = ""
        Me.txtIdUsuario.SelectedText = ""
        Me.txtIdUsuario.Size = New System.Drawing.Size(71, 37)
        Me.txtIdUsuario.TabIndex = 6
        Me.txtIdUsuario.Visible = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCerrarSesion.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Image = Global.MORSS_v._0.My.Resources.Resources.icons8_Power_Off_Button_50px_1
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 300)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(237, 45)
        Me.btnCerrarSesion.TabIndex = 5
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        '
        'btnUsuarios
        '
        Me.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuarios.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnUsuarios.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Image = Global.MORSS_v._0.My.Resources.Resources.icons8_people_50px
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 255)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(237, 45)
        Me.btnUsuarios.TabIndex = 4
        Me.btnUsuarios.Text = "Usuarios"
        '
        'btnReportes
        '
        Me.btnReportes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReportes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReportes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReportes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportes.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnReportes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Image = Global.MORSS_v._0.My.Resources.Resources.icons8_bar_chart_50px
        Me.btnReportes.Location = New System.Drawing.Point(0, 210)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(237, 45)
        Me.btnReportes.TabIndex = 3
        Me.btnReportes.Text = "Reportes"
        '
        'btnSolicitudes
        '
        Me.btnSolicitudes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSolicitudes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSolicitudes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSolicitudes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSolicitudes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSolicitudes.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnSolicitudes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSolicitudes.ForeColor = System.Drawing.Color.White
        Me.btnSolicitudes.Image = Global.MORSS_v._0.My.Resources.Resources.icons8_bar_chart_50px
        Me.btnSolicitudes.Location = New System.Drawing.Point(0, 165)
        Me.btnSolicitudes.Name = "btnSolicitudes"
        Me.btnSolicitudes.Size = New System.Drawing.Size(237, 45)
        Me.btnSolicitudes.TabIndex = 2
        Me.btnSolicitudes.Text = "Solicitudes"
        '
        'btnInicio
        '
        Me.btnInicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInicio.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnInicio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Image = Global.MORSS_v._0.My.Resources.Resources.icons8_home_50px
        Me.btnInicio.Location = New System.Drawing.Point(0, 120)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(237, 45)
        Me.btnInicio.TabIndex = 1
        Me.btnInicio.Text = "Inicio"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Silver
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(237, 120)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.MORSS_v._0.My.Resources.Resources.morss
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(52, 25)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(137, 75)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1663, 1049)
        Me.Controls.Add(Me.pnlLateral)
        Me.Controls.Add(Me.pnlTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlLateral.ResumeLayout(False)
        Me.pnlLateral.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.cirbwomen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cirbman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitulo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlLateral As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInicio As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnCerrarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUsuarios As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReportes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSolicitudes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblUser As Label
    Friend WithEvents txtIdUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblRol As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cirbman As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents cirbwomen As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblSexo As Label
End Class
