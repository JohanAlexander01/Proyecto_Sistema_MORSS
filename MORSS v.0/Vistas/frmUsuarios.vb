
Imports Datos
Imports Entidades
Imports Guna.UI2.Native.WinApi

Public Class frmUsuarios
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub
    Private Sub CargarUsuarios()
        Try
            Dim func As New Datos.fUsuario
            Dim tabla As DataTable = func.MostrarUsuario()

            If tabla IsNot Nothing Then
                dgUsuarios.DataSource = Nothing
                dgUsuarios.AutoGenerateColumns = True
                dgUsuarios.DataSource = tabla
                OcultarColumnas(dgUsuarios, "IdUsuario", "ApellidoMaterno", "FechaRegistro")
                dgUsuarios.ColumnHeadersVisible = True
                FormatearGrid()
            Else
                MessageBox.Show("No se pudieron cargar los usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub FiltrarUsuarios(columna As String, valor As String)
        Try
            Dim func As New Datos.fUsuario
            Dim tabla As DataTable = func.BuscarUsuarios(columna, valor)

            If tabla IsNot Nothing Then
                dgUsuarios.DataSource = tabla
            Else
                dgUsuarios.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error al filtrar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FormatearGrid()
        With dgUsuarios
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

            ' Personalizar encabezados si las columnas existen
            If .Columns.Contains("Nombres") Then .Columns("Nombres").HeaderText = "Nombres"
            If .Columns.Contains("ApellidoPaterno") Then .Columns("ApellidoPaterno").HeaderText = "Apellido Paterno"
            If .Columns.Contains("ApellidoMaterno") Then .Columns("ApellidoMaterno").HeaderText = "Apellido Materno"
            If .Columns.Contains("DNI") Then .Columns("DNI").HeaderText = "DNI"
            If .Columns.Contains("Sexo") Then .Columns("Sexo").HeaderText = "Sexo"
            If .Columns.Contains("Usuario") Then .Columns("Usuario").HeaderText = "Usuario"
            If .Columns.Contains("Rol") Then .Columns("Rol").HeaderText = "Rol"
            If .Columns.Contains("Activo") Then .Columns("Activo").HeaderText = "Estado"
            If .Columns.Contains("FechaRegistro") Then .Columns("FechaRegistro").HeaderText = "Fecha de Registro"


        End With
    End Sub
    Private Sub OcultarColumnas(grid As DataGridView, ParamArray nombresColumnas() As String)
        For Each nombre In nombresColumnas
            If grid.Columns.Contains(nombre) Then
                grid.Columns(nombre).Visible = False
            End If
        Next
    End Sub
    Private Sub dgUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsuarios.CellDoubleClick
        Try
            If e.RowIndex >= 0 Then
                Dim fila As DataGridViewRow = dgUsuarios.Rows(e.RowIndex)

                txtIdUsuario.Text = fila.Cells("IdUsuario").Value.ToString()
                txtNombres.Text = fila.Cells("Nombres").Value.ToString()
                txtApePaterno.Text = fila.Cells("ApellidoPaterno").Value.ToString()
                txtApeMaterno.Text = fila.Cells("ApellidoMaterno").Value.ToString()
                txtDni.Text = fila.Cells("DNI").Value.ToString()
                cboSexo.Text = fila.Cells("Sexo").Value.ToString()
                txtUsuario.Text = fila.Cells("Usuario").Value.ToString()
                txtContraseña.Text = fila.Cells("Contraseña").Value.ToString()
                If cboRol.Items.Contains(fila.Cells("Rol").Value.ToString()) Then
                    cboRol.SelectedItem = fila.Cells("Rol").Value.ToString()
                Else
                    cboRol.SelectedIndex = -1 ' Opción por si no está en la lista
                End If
                If cboActivo.Items.Contains(fila.Cells("Activo").Value.ToString()) Then
                    cboActivo.SelectedItem = fila.Cells("Activo").Value.ToString()
                Else
                    cboActivo.SelectedIndex = -1
                End If
                If cboArea.Items.Contains(fila.Cells("Area").Value.ToString()) Then
                    cboArea.SelectedItem = fila.Cells("Area").Value.ToString()
                Else
                    cboArea.SelectedIndex = -1
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al seleccionar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditarUsuario_Click(sender As Object, e As EventArgs) Handles btnEditarUsuario.Click
        Try
            If txtIdUsuario.Text = "" Then
                MessageBox.Show("Seleccione un usuario para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Crear la entidad y asignar valores del formulario
            Dim usuario As New Entidades.EntUsuario
            usuario.gIdUsuario = CInt(txtIdUsuario.Text)
            usuario.gNombres = txtNombres.Text.Trim()
            usuario.gApellidoPaterno = txtApePaterno.Text.Trim()
            usuario.gApellidoMaterno = txtApeMaterno.Text.Trim()
            usuario.gDNI = txtDni.Text.Trim()
            usuario.gSexo = cboSexo.Text
            usuario.gUsuario = txtUsuario.Text.Trim()
            usuario.gContraseña = txtContraseña.Text.Trim()
            usuario.gRol = cboRol.Text
            usuario.gArea = cboArea.text
            usuario.gActivo = cboActivo.Text

            ' Llamar a la capa de datos
            Dim func As New Datos.fUsuario
            If func.EditarUsuario(usuario) Then
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarUsuarios()
                limpiar() ' Refrescar DataGridView
            Else
                MessageBox.Show("No se pudo editar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al editar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub limpiar()
        txtIdUsuario.Clear()
        txtNombres.Clear()
        txtApePaterno.Clear()
        txtApeMaterno.Clear()
        txtDni.Clear()
        cboSexo.SelectedIndex = -1
        txtUsuario.Clear()
        txtContraseña.Clear()
        cboActivo.SelectedIndex = -1
        cboRol.SelectedIndex = -1
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If rbDni.Checked Then
            FiltrarUsuarios("DNI", txtBuscar.Text.Trim())
        ElseIf rbApeNombres.Checked Then
            FiltrarUsuarios("ApellidosNombres", txtBuscar.Text.Trim())
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            ' Verificar si se seleccionó un usuario
            If txtIdUsuario.Text = "" Then
                MessageBox.Show("Seleccione un usuario para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Confirmar la eliminación
            Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.No Then
                Exit Sub
            End If

            ' Crear entidad con el ID del usuario
            Dim usuarioEnt As New Entidades.EntUsuario
            usuarioEnt.gIdUsuario = CInt(txtIdUsuario.Text)

            ' Ejecutar eliminación
            Dim func As New Datos.fUsuario
            If func.EliminarUsuario(usuarioEnt) Then
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarUsuarios() ' Refrescar tabla
                limpiar()
            Else
                MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class