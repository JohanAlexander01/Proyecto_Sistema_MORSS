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
End Class