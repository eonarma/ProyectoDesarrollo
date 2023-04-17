Imports System.Data.SqlClient

Public Class OrdenDetalleCRUD
    Dim HeaderOrdenCRUD As New DragPanel
    Private conexion As conexion = New conexion()
    Private Sub btnMode_Click(sender As Object, e As EventArgs) Handles btnMode.Click
        Dim lbltext As String = lblMode.Text
        Dim Query As String
        Select Case lbltext
            Case "Nuevo"
                Query = "INSERT INTO ORDEN_PRODUCTO VALUES (" & DetalleOrden.txtboxOrden.Text & "," & cmbProducto.SelectedValue & ",'" & txtboxFecha.Text & "'," & txtboxCantidad.Text & ",'" & txtboxNota.Text & "')"
            Case "Modificar"
                Query = "UPDATE ORDEN_PRODUCTO 
                         SET ID_Producto = 1" & cmbProducto.SelectedValue & "
                         , Fecha_OrdenProducto = '" & txtboxFecha.Text & "'
                         , Cantidad_OrdenProducto = " & txtboxCantidad.Text & "
                         WHERE ID_Orden = " & DetalleOrden.txtboxOrden.Text & " AND ID_Producto = " & cmbProducto.SelectedValue & " AND Fecha_OrdenProducto = '" & txtboxFecha.Text & "'"
            Case "Borrar"
                Query = "DELETE FROM ORDEN_PRODUCTO WHERE ID_Orden = " & DetalleOrden.txtboxOrden.Text & " AND ID_Producto = " & cmbProducto.SelectedValue & " AND Fecha_OrdenProducto = '" & txtboxFecha.Text & "'"
        End Select

        conexion.EjecutarQuery(Query)
        conexion.Consulta("SELECT PRODUCTOS.Nombre_Producto AS Producto, Fecha_OrdenProducto AS Fecha, Cantidad_OrdenProducto AS Cantidad, Nota_OrdenProducto AS Nota FROM ORDEN_PRODUCTO INNER JOIN PRODUCTOS ON PRODUCTOS.ID_Producto = ORDEN_PRODUCTO.ID_Producto WHERE ID_Orden = " & DetalleOrden.txtboxOrden.Text, "ORDEN_PRODUCTO", DetalleOrden.dgvDetalleOrden)
        Me.Close()
    End Sub
    Private Sub OrdenDetalleCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        HeaderOrdenCRUD.CreateHeader(Me)

        If lblMode.Text = "Borrar" Then
            cmbProducto.Enabled = False
            txtboxFecha.Enabled = False
            txtboxCantidad.Enabled = False
            txtboxNota.Enabled = False
        Else
            cmbProducto.Enabled = True
        txtboxFecha.Enabled = True
        txtboxCantidad.Enabled = True
        txtboxNota.Enabled = True
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class