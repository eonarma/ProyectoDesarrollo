Imports System.Xml

Public Class Clientes
    Private conexion As conexion = New conexion()
    Private Functions As Functions = New Functions()
    Private ClienteCRUD As ClienteCRUDmodal = New ClienteCRUDmodal

    Private Sub btnAny_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click, btnModificar.Click, btnBorrar.Click
        Dim btn As Button = CType(sender, Button)

        ClienteCRUD.lblModeCliente.Text = btn.Text
        Functions.recentrar(ClienteCRUD.lblModeCliente, ClienteCRUD)

        ClienteCRUD.btnMode.Text = "Guardar"

        Select Case btn.Text
            Case "Nuevo"
                ClienteCRUD.txtboxID.Text = ""
                ClienteCRUD.txtboxEmpresa.Text = ""
                ClienteCRUD.txtboxDireccion.Text = ""
                ClienteCRUD.txtboxContacto.Text = ""
                ClienteCRUD.txtboxTelefono.Text = ""

            Case "Modificar", "Borrar"
                Dim Columna As Integer = dvgClientes.CurrentRow.Index

                ClienteCRUD.txtboxID.Enabled = False
                ClienteCRUD.txtboxID.Text = dvgClientes(0, Columna).Value
                ClienteCRUD.txtboxEmpresa.Text = dvgClientes(1, Columna).Value
                ClienteCRUD.txtboxDireccion.Text = dvgClientes(2, Columna).Value
                ClienteCRUD.txtboxContacto.Text = dvgClientes(3, Columna).Value
                ClienteCRUD.txtboxTelefono.Text = dvgClientes(4, Columna).Value

                If btn.Text = "Borrar" Then
                    ClienteCRUD.btnMode.Text = "Borrar"

                    ClienteCRUD.txtboxEmpresa.Enabled = False
                    ClienteCRUD.txtboxDireccion.Enabled = False
                    ClienteCRUD.txtboxContacto.Enabled = False
                    ClienteCRUD.txtboxTelefono.Enabled = False
                End If
        End Select

        ClienteCRUD.ShowDialog()
    End Sub


    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        conexion.Consulta("SELECT ID_Cliente AS ID, Empresa_Cliente AS Cliente, Direccion_Cliente AS Direccion, Contacto_Empresa AS Contacto, Telefono_Cliente AS Telefono FROM CLIENTES", "Clientes", dvgClientes)
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Consulta("SELECT ID_Cliente AS ID, Empresa_Cliente AS Cliente, Direccion_Cliente AS Direccion, Contacto_Empresa AS Contacto, Telefono_Cliente AS Telefono FROM CLIENTES", "Clientes", dvgClientes)
    End Sub

End Class