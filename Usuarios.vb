Public Class Usuarios
    Private conexion As conexion = New conexion()
    Private Functions As Functions = New Functions()
    Private UsuarioCRUD As UsuarioCRUD = New UsuarioCRUD

    Private Sub Usuarios_Click(sender As Object, e As EventArgs) Handles MyBase.Click, btnNuevo.Click, btnModificar.Click, btnBorrar.Click
        Dim btn As Button = CType(sender, Button)

        UsuarioCRUD.lblUsuarios.Text = btn.Text
        Functions.recentrar(UsuarioCRUD.lblUsuarios, UsuarioCRUD)

        UsuarioCRUD.btnMode.Text = "Guardar"

        Select Case btn.Text
            Case "Nuevo"
                UsuarioCRUD.txtboxUsuario.Text = ""
                UsuarioCRUD.txtContrasena.Text = ""
                UsuarioCRUD.cmprivilegio.Text = ""

            Case "Modificar", "Borrar"
                Dim Columna As Integer = dgvUsuarios.CurrentRow.Index

                UsuarioCRUD.txtboxUsuario.Enabled = False
                UsuarioCRUD.txtboxUsuario.Text = dgvUsuarios(0, Columna).Value
                UsuarioCRUD.txtContrasena.Text = dgvUsuarios(1, Columna).Value
                UsuarioCRUD.cmprivilegio.Text = dgvUsuarios(2, Columna).Value

                If btn.Text = "Borrar" Then
                    UsuarioCRUD.btnMode.Text = "Borrar"

                    UsuarioCRUD.txtboxUsuario.Enabled = False
                    UsuarioCRUD.txtContrasena.Enabled = False
                    UsuarioCRUD.cmprivilegio.Enabled = False

                End If
        End Select

        UsuarioCRUD.ShowDialog()
    End Sub
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Consulta("SELECT Usuario_Usuario AS Usuario, password_Usario AS Contraseña, Permiso_Usuario AS Privilegios FROM USUARIOS", "USUARIOS", dgvUsuarios)
    End Sub
End Class