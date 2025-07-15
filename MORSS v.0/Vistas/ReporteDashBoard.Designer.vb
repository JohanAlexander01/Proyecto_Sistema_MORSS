<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteDashBoard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ChartSolicitudes = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblEnBusqueda = New System.Windows.Forms.Label()
        Me.lblAtendidas = New System.Windows.Forms.Label()
        Me.lblPagos = New System.Windows.Forms.Label()
        Me.lblRangoFechas = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlTitulo = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCerrar = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.ChartSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChartSolicitudes
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartSolicitudes.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartSolicitudes.Legends.Add(Legend1)
        Me.ChartSolicitudes.Location = New System.Drawing.Point(573, 278)
        Me.ChartSolicitudes.Name = "ChartSolicitudes"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartSolicitudes.Series.Add(Series1)
        Me.ChartSolicitudes.Size = New System.Drawing.Size(492, 357)
        Me.ChartSolicitudes.TabIndex = 1
        Me.ChartSolicitudes.Text = "Chart1"
        '
        'lblEnBusqueda
        '
        Me.lblEnBusqueda.AutoSize = True
        Me.lblEnBusqueda.Location = New System.Drawing.Point(327, 241)
        Me.lblEnBusqueda.Name = "lblEnBusqueda"
        Me.lblEnBusqueda.Size = New System.Drawing.Size(48, 16)
        Me.lblEnBusqueda.TabIndex = 2
        Me.lblEnBusqueda.Text = "Label1"
        Me.lblEnBusqueda.Visible = False
        '
        'lblAtendidas
        '
        Me.lblAtendidas.AutoSize = True
        Me.lblAtendidas.Location = New System.Drawing.Point(327, 278)
        Me.lblAtendidas.Name = "lblAtendidas"
        Me.lblAtendidas.Size = New System.Drawing.Size(48, 16)
        Me.lblAtendidas.TabIndex = 2
        Me.lblAtendidas.Text = "Label1"
        Me.lblAtendidas.Visible = False
        '
        'lblPagos
        '
        Me.lblPagos.AutoSize = True
        Me.lblPagos.Location = New System.Drawing.Point(327, 316)
        Me.lblPagos.Name = "lblPagos"
        Me.lblPagos.Size = New System.Drawing.Size(48, 16)
        Me.lblPagos.TabIndex = 2
        Me.lblPagos.Text = "Label1"
        Me.lblPagos.Visible = False
        '
        'lblRangoFechas
        '
        Me.lblRangoFechas.AutoSize = True
        Me.lblRangoFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRangoFechas.Location = New System.Drawing.Point(154, 113)
        Me.lblRangoFechas.Name = "lblRangoFechas"
        Me.lblRangoFechas.Size = New System.Drawing.Size(91, 16)
        Me.lblRangoFechas.TabIndex = 2
        Me.lblRangoFechas.Text = "Fecha Inicio"
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(98, 149)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(200, 22)
        Me.dtpInicio.TabIndex = 3
        '
        'dtpFinal
        '
        Me.dtpFinal.Location = New System.Drawing.Point(372, 149)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(200, 22)
        Me.dtpFinal.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.BorderRadius = 4
        Me.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(657, 126)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(118, 45)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Generar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad de Solicitudes  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Solicitudes Atendidas  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingreso Total  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(435, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha Final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(12, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "REPORTES"
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.btnCerrar)
        Me.pnlTitulo.Controls.Add(Me.Label5)
        Me.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1300, 57)
        Me.pnlTitulo.TabIndex = 5
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
        'ReporteDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 790)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dtpFinal)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPagos)
        Me.Controls.Add(Me.lblAtendidas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRangoFechas)
        Me.Controls.Add(Me.lblEnBusqueda)
        Me.Controls.Add(Me.ChartSolicitudes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReporteDashBoard"
        Me.Text = "ReporteDashBoard"
        CType(Me.ChartSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChartSolicitudes As DataVisualization.Charting.Chart
    Friend WithEvents lblEnBusqueda As Label
    Friend WithEvents lblAtendidas As Label
    Friend WithEvents lblPagos As Label
    Friend WithEvents lblRangoFechas As Label
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents dtpFinal As DateTimePicker
    Friend WithEvents btnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlTitulo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCerrar As Guna.UI2.WinForms.Guna2Button
End Class
