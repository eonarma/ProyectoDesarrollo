Public Class Login
    Private conexion As conexion = New conexion()
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        'conexion.LoginVerif(txtboxUsuario.Text, txtboxContra.Text)
        conexion.LoginVerification(txtboxUsuario.Text, txtboxContra.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class