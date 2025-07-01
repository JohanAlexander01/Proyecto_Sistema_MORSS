Imports System.Runtime.CompilerServices

Public Class frmPrincipal
    Private Sub btnSolicitudes_Click(sender As Object, e As EventArgs) Handles btnSolicitudes.Click
        Dim fr As New frmSolicitudes()
        fr.MdiParent = Me
        fr.Show()
    End Sub
End Class