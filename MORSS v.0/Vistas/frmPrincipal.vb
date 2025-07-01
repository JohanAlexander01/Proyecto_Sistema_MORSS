Imports System.Runtime.CompilerServices

Public Class frmPrincipal
    Public Property rolActual As String
    Public Property areaActual As String
    Private Sub btnSolicitudes_Click(sender As Object, e As EventArgs) Handles btnSolicitudes.Click
        Dim fr As New frmSolicitudes()

        fr.rolActual = Me.rolActual
        fr.MdiParent = Me
        fr.IdUsuarioActual = txtIdUsuario.Text ' Aquí pasas el ID
        fr.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblSexo.Text = "M" Then
            cirbman.Visible = True
        Else
            cirbman.Visible = False
        End If
        If lblSexo.Text = " F" Then
            cirbwomen.Visible = True
        Else
            cirbwomen.Visible = False
        End If
        If rolActual = "Usuario" Then
            btnUsuarios.Enabled = False
            btnReportes.Enabled = False
        End If
    End Sub


    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim fr As New frmUsuarios()

        fr.MdiParent = Me

        fr.Show()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click

    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click


    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
        frmLogin.Show()
    End Sub
End Class