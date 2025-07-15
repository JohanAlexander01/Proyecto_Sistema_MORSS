Imports System.Data.SqlClient
Imports Datos

Public Class ReporteDashBoard
    Private Sub ReporteDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpInicio.Value = Date.Today.AddDays(-7)
        dtpFinal.Value = Date.Today
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim fechaInicio As Date = dtpInicio.Value.Date
        Dim fechaFin As Date = dtpFinal.Value.Date

        If fechaInicio > fechaFin Then
            MessageBox.Show("La fecha de inicio no puede ser mayor que la de fin.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        CargarDashboardPorFechas(fechaInicio, fechaFin)
        lblEnBusqueda.Visible = True
        lblAtendidas.Visible = True
        lblPagos.Visible = True
    End Sub
    Private Sub CargarDashboardPorFechas(fechaInicio As Date, fechaFin As Date)
        Dim enBusqueda As Integer = 0
        Dim atendidas As Integer = 0
        Dim totalPagos As Decimal = 0

        Dim conexion As New ConexionBD()

        If conexion.conectar() Then
            Try
                ' En Búsqueda
                With conexion.cmd
                    .Connection = conexion.cnn
                    .CommandText = "Reporte_SolicitudesEnBusqueda"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@FechaInicio", fechaInicio)
                    .Parameters.AddWithValue("@FechaFin", fechaFin)
                End With
                enBusqueda = Convert.ToInt32(conexion.cmd.ExecuteScalar())

                ' Atendidas
                With conexion.cmd
                    .CommandText = "Reporte_SolicitudesAtendidas"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@FechaInicio", fechaInicio)
                    .Parameters.AddWithValue("@FechaFin", fechaFin)
                End With
                atendidas = Convert.ToInt32(conexion.cmd.ExecuteScalar())

                ' Total Pagos (leer TotalGeneral del SP)
                With conexion.cmd
                    .CommandText = "sp_Reporte_TotalPagos"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@FechaInicio", fechaInicio)
                    .Parameters.AddWithValue("@FechaFin", fechaFin)
                End With

                Using reader As SqlDataReader = conexion.cmd.ExecuteReader()
                    If reader.Read() Then
                        totalPagos = Convert.ToDecimal(reader("TotalGeneral"))
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al consultar el dashboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conexion.cnn.State = ConnectionState.Open Then conexion.cnn.Close()
            End Try

            ' Mostrar resultados
            lblEnBusqueda.Text = enBusqueda.ToString()
            lblAtendidas.Text = atendidas.ToString()
            lblPagos.Text = "S/ " & totalPagos.ToString("N2")

            ' Graficar
            ActualizarGrafico(enBusqueda, atendidas)

        Else
            MessageBox.Show("No se pudo conectar a la base de datos.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ActualizarGrafico(enBusqueda As Integer, atendidas As Integer)
        ChartSolicitudes.Series.Clear()
        ChartSolicitudes.Titles.Clear()

        ChartSolicitudes.Titles.Add("Solicitudes")
        Dim serie = ChartSolicitudes.Series.Add("Solicitudes")
        serie.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        serie.IsValueShownAsLabel = True

        serie.Points.AddXY("En Búsqueda", enBusqueda)
        serie.Points.AddXY("Atendidas", atendidas)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class

