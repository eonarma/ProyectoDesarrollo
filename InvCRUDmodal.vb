Imports System.Data.SqlClient

Public Class InvCRUDmodal
    Private conexion As conexion = New conexion()
    Private Sub btnMode_Click(sender As Object, e As EventArgs) Handles btnMode.Click
        Dim lbltext As String = lblMode.Text
        Dim Query As String
        Select Case lbltext
            Case "Nuevo"
                Query = "INSERT INTO PRODUCTOS VALUES (
                        " & txtboxID.Text & ",
                        '" & txtboxProducto.Text & "',
                        " & txtboxExistencia.Text & ",
                        " & cmbCategoria.SelectedValue & ")"
            Case "Modificar"
                Query = "UPDATE PRODUCTOS 
                         SET Nombre_Producto = '" & txtboxProducto.Text & "'
                         , Existencia_Producto = " & txtboxExistencia.Text & "
                         , Categoria_ID = " & cmbCategoria.SelectedValue & "
                         WHERE ID_Producto = " & txtboxID.Text
            Case "Borrar"
                Query = "DELETE FROM PRODUCTOS WHERE ID_Producto = " & txtboxID.Text
        End Select

        conexion.EjecutarQuery(Query)
        conexion.Consulta("SELECT ID_Producto AS ID, Nombre_Producto AS Nombre, Existencia_Producto AS Existencia, Nombre_Categoria AS Categoria FROM PRODUCTOS INNER JOIN CATEGORIAS ON CATEGORIAS.Categoria_ID = PRODUCTOS.Categoria_ID", "Productos", Inventario.dgvInventario)
        Me.Close()
    End Sub
    '   Private Sub InvCRUDmodal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        Form1.switchPanel(HeaderInvCRUD, PanelHeaderInvCRUD)
    '    HeaderInvCRUD.CreateHeader(Me)


    '   If lblMode.Text = "Borrar" Then
    '      txtboxProducto.Enabled = False
    '     txtboxExistencia.Enabled = False
    '    cmbCategoria.Enabled = False
    '   Else
    '      txtboxProducto.Enabled = True
    '     txtboxExistencia.Enabled = True
    '    cmbCategoria.Enabled = True
    'End If

    '    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class