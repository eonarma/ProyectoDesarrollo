Public Class DetalleOrden
    Private conexion As conexion = New conexion()
    Private detalleordenCRUD As OrdenDetalleCRUD = New OrdenDetalleCRUD
    Private Sub DetalleOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Consulta("SELECT PRODUCTOS.Nombre_Producto AS Producto, Fecha_OrdenProducto AS Fecha, Cantidad_OrdenProducto AS Cantidad, Nota_OrdenProducto AS Nota FROM ORDEN_PRODUCTO INNER JOIN PRODUCTOS ON PRODUCTOS.ID_Producto = ORDEN_PRODUCTO.ID_Producto WHERE ID_Orden = " & txtboxOrden.Text, "ORDEN_PRODUCTO", dgvDetalleOrden)
        conexion.ConsultacmbBox("SELECT * FROM PRODUCTOS", "ID_Producto", "Nombre_Producto", detalleordenCRUD.cmbProducto)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.switchPanel(Ordenes, Form1.PanelMain)
    End Sub

    Private Sub btnAny_Click(sender As Object, e As EventArgs) Handles btnModificar.Click, btnBorrar.Click, btnAgregar.Click
        Dim btnConNombre As Button = CType(sender, Button)

        detalleordenCRUD.lblMode.Text = btnConNombre.Text
        recentrar(detalleordenCRUD.lblMode, detalleordenCRUD)

        detalleordenCRUD.btnMode.Text = "Guardar"

        Select Case btnConNombre.Text
            Case "Nuevo"
                detalleordenCRUD.cmbProducto.Text = ""
                detalleordenCRUD.txtboxFecha.Text = ""
                detalleordenCRUD.txtboxCantidad.Text = ""
                detalleordenCRUD.txtboxNota.Text = ""
            Case "Modificar", "Borrar"
                Dim Columna As Integer = dgvDetalleOrden.CurrentRow.Index

                detalleordenCRUD.cmbProducto.Text = dgvDetalleOrden(0, Columna).Value
                detalleordenCRUD.txtboxFecha.Text = dgvDetalleOrden(1, Columna).Value
                detalleordenCRUD.txtboxCantidad.Text = dgvDetalleOrden(2, Columna).Value
                detalleordenCRUD.txtboxNota.Text = dgvDetalleOrden(3, Columna).Value

                If btnConNombre.Text = "Borrar" Then
                    detalleordenCRUD.btnMode.Text = "Borrar"
                End If
        End Select

        detalleordenCRUD.ShowDialog()
    End Sub
    Public Sub recentrar(ByVal label As Label, ByVal form As Form)
        Dim NuevoAncho As Integer
        NuevoAncho = form.Size.Width / 2 - label.Size.Width / 2
        label.Left = NuevoAncho
    End Sub
End Class