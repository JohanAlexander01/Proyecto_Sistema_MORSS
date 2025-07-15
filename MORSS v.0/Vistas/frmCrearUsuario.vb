Imports Datos
Imports Entidades
Imports Guna.UI2.Native.WinApi

Public Class frmCrearUsuario
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        Dim usuario As String = txtUsuario.Text.Trim()
        Dim funcion As New fUsuario

        If usuario <> "" Then
            If funcion.UsuarioExiste(usuario) Then
                lblUsuarioDisponible.Text = "Usuario ya existe"
                lblUsuarioDisponible.ForeColor = Color.Red
            Else
                lblUsuarioDisponible.Text = "Usuario disponible"
                lblUsuarioDisponible.ForeColor = Color.Green
            End If
        Else
            lblUsuarioDisponible.Text = ""
        End If
    End Sub
    Private Sub txtDNI_TextChanged(sender As Object, e As EventArgs) Handles txtDni.TextChanged
        Dim dni As String = txtDni.Text.Trim()
        Dim funcion As New fUsuario

        If dni.Length = 8 Then
            If funcion.DniExiste(dni) Then
                lblDniDisponible.Text = "DNI ya registrado"
                lblDniDisponible.ForeColor = Color.Red
            Else
                lblDniDisponible.Text = "DNI disponible"
                lblDniDisponible.ForeColor = Color.Green
            End If
        Else
            lblDniDisponible.Text = ""
        End If
    End Sub

    Private Sub txtRepetirContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtRepetirContraseña.TextChanged
        If txtContraseña.Text <> txtRepetirContraseña.Text Then
            lblContraseña.Text = "Contraseñas no coinciden"
            lblContraseña.ForeColor = Color.Red
        Else
            lblContraseña.Text = "Contraseñas coinciden"
            lblContraseña.ForeColor = Color.Green
        End If
    End Sub
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim usuario As String = txtUsuario.Text.Trim()
        Dim dni As String = txtDNI.Text.Trim()
        Dim pass1 As String = txtContraseña.Text
        Dim pass2 As String = txtRepetirContraseña.Text
        Dim entidad As New EntUsuario
        Dim funcion As New fUsuario

        ' Crear entidad
        entidad.gNombres = txtNombres.Text
        entidad.gApellidoPaterno = txtApePaterno.Text
        entidad.gApellidoMaterno = txtApeMaterno.Text
        entidad.gDNI = dni
        entidad.gSexo = cboSexo.SelectedItem
        entidad.gUsuario = usuario
        entidad.gContraseña = pass1
        entidad.gRol = "USUARIO"
        entidad.gArea = "SIN ASIGNAR"
        entidad.gActivo = "0"
        entidad.gFechaRegistro = DateTime.Now

        ' Guardar
        If funcion.InsertarUsuario(entidad) Then
            MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiar()
            Me.Close()
        Else
            MessageBox.Show("Error al registrar usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub limpiar()
        txtNombres.Clear()
        txtApePaterno.Clear()
        txtApeMaterno.Clear()
        txtDni.Clear()
        cboSexo.SelectedIndex = -1
        txtContraseña.Clear()
        txtRepetirContraseña.Clear()
        Me.Close()
    End Sub


End Class