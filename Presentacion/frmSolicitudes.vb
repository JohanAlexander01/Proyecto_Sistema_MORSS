Public Class frmSolicitudes
    Private Sub btnCerrarSolicitudes_Click(sender As Object, e As EventArgs) Handles btnCerrarSolicitudes.Click
        Me.Close()
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        If cboTipo.SelectedIndex = 0 Then
            cboPartida.Visible = False
            pnlNotarial.Visible = True
            pnlCivil.Visible = False
            pnlJudicial.Visible = False
        Else
            cboPartida.Visible = False
            lblPartida.Visible = False
        End If
        If cboTipo.SelectedIndex = 1 Then
            cboPartida.Visible = False
            pnlJudicial.Visible = True
            pnlCivil.Visible = False
            pnlNotarial.Visible = False
        Else
            cboPartida.Visible = False
            lblPartida.Visible = False
        End If
        If cboTipo.SelectedIndex = 2 Then
            cboPartida.Visible = True
            lblPartida.Visible = True
            pnlCivil.Visible = True
            pnlJudicial.Visible = False
            pnlNotarial.Visible = False
        Else
            cboPartida.Visible = False
            lblPartida.Visible = False
        End If

    End Sub
End Class