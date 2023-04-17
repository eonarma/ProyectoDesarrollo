Public Class UsuarioCRUD
    Private conexion As conexion = New conexion()

    Private Sub btnMode_Click(sender As Object, e As EventArgs) Handles btnMode.Click
        Dim lbltext As String = lblUsuarios.Text
        Dim Query As String

        Select Case lbltext
            Case "Nuevo"
                Query = "PA_insert_Usarios '" & txtboxUsuario.Text & "','" & txtContrasena.Text & "','" & cmprivilegio.Text & "'"
            Case "Modificar"
                Query = "UPDATE USUARIOS 
                         SET password_Usario = '" & txtContrasena.Text & "'
                         , Permiso_Usuario = '" & cmprivilegio.Text & "' 
                         WHERE Usuario_Usuario = '" & txtboxUsuario.Text & "'"
            Case "Borrar"
                Query = "DELETE FROM USUARIOS WHERE Usuario_Usuario = '" & txtboxUsuario.Text & "'"
        End Select

        conexion.EjecutarQuery(Query)
        conexion.Consulta("SELECT Usuario_Usuario AS Usuario, password_Usario AS Contraseña, Permiso_Usuario AS Privilegios FROM USUARIOS", "USUARIOS", Usuarios.dgvUsuarios)
        Me.Close()
    End Sub
End Class