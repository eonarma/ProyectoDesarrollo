Public Class ClienteCRUDmodal

    Private conexion As conexion = New conexion()
    Private Sub btnMode_Click(sender As Object, e As EventArgs) Handles btnMode.Click
        Dim lbltext As String = lblModeCliente.Text
        Dim Query As String

        Select Case lbltext
            Case "Nuevo"
                Query = "INSERT INTO CLIENTES VALUES (" & txtboxID.Text & ",'" & txtboxEmpresa.Text & "','" & txtboxDireccion.Text & "','" & txtboxContacto.Text & "','" & txtboxTelefono.Text & "')"
            Case "Modificar"
                Query = "UPDATE CLIENTES 
                         SET Empresa_Cliente = '" & txtboxEmpresa.Text & "'
                         , Direccion_Cliente = '" & txtboxDireccion.Text & "'
                         , Contacto_Empresa = '" & txtboxContacto.Text & "'
                         , Telefono_Cliente = '" & txtboxTelefono.Text & "' 
                         WHERE ID_Cliente = " & txtboxID.Text
            Case "Borrar"
                Query = "DELETE FROM CLIENTES WHERE ID_Cliente = " & txtboxID.Text
        End Select

        conexion.EjecutarQuery(Query)
        conexion.Consulta("SELECT ID_Cliente AS ID, Empresa_Cliente AS Cliente, Direccion_Cliente AS Direccion, Contacto_Empresa AS Contacto, Telefono_Cliente AS Telefono FROM CLIENTES", "Clientes", Clientes.dvgClientes)
        Me.Close()
    End Sub
    Private Sub ClienteCRUDmodal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If lblModeCliente.Text = "Borrar" Then
            txtboxID.Enabled = False
            txtboxEmpresa.Enabled = False
            txtboxDireccion.Enabled = False
            txtboxContacto.Enabled = False
            txtboxTelefono.Enabled = False
        Else
            txtboxID.Enabled = True
            txtboxEmpresa.Enabled = True
            txtboxDireccion.Enabled = True
            txtboxContacto.Enabled = True
            txtboxTelefono.Enabled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class