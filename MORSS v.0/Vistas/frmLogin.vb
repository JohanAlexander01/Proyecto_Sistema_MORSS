Imports Datos
Imports Entidades


Public Class frmLogin

    Private Sub chkMostrarPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkMostrarPass.CheckedChanged
        If chkMostrarPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub lkRegistrate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkRegistrate.LinkClicked
        frmCrearUsuario.Show()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            ' Validar campos vacíos
            If txtUser.Text.Trim() = "" Or txtPass.Text.Trim() = "" Then
                MessageBox.Show("Debe ingresar usuario y contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Crear objeto EntUsuario
            Dim usuarioEnt As New Entidades.EntUsuario
            usuarioEnt.gUsuario = txtUser.Text.Trim()
            usuarioEnt.gContraseña = txtPass.Text.Trim()

            ' Llamar a la función de validación
            Dim funcion As New Datos.fUsuario
            Dim resultado As DataTable = funcion.ValidarUsuario(usuarioEnt)

            If resultado IsNot Nothing AndAlso resultado.Rows.Count > 0 Then
                ' Validar si está activo
                If resultado.Rows(0)("Activo").ToString() = "0" Then
                    MessageBox.Show("El usuario está inactivo. Comuníquese con el administrador para darle de alta.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If

                ' Mostrar ventana principal
                Dim frm As New frmPrincipal
                frm.txtIdUsuario.Text = resultado.Rows(0)("IdUsuario").ToString()
                frm.lblUser.Text = resultado.Rows(0)("Usuario").ToString()
                frm.lblRol.Text = resultado.Rows(0)("Rol").ToString()
                frm.lblSexo.Text = resultado.Rows(0)("Sexo").ToString()

                ' Asignar valores para uso posterior
                frmPrincipal.rolActual = resultado.Rows(0)("Rol").ToString()
                frmPrincipal.areaActual = resultado.Rows(0)("Area").ToString()

                ' Desactivar botones si es rol Usuario
                If frmPrincipal.rolActual = "Usuario" Then
                    frm.btnUsuarios.Enabled = False
                    frm.btnReportes.Enabled = False

                End If

                frm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al iniciar sesión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class