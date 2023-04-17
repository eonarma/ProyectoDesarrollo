Public Class Inventario
    Private conexion As conexion = New conexion()
    Private Functions As Functions = New Functions()
    Private InventarioCRUD As InvCRUDmodal = New InvCRUDmodal()
    Private Sub btnAny_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click, btnModificar.Click, btnBorrar.Click
        Dim btnConNombre As Button = CType(sender, Button)

        InventarioCRUD.lblMode.Text = btnConNombre.Text
        Functions.recentrar(InventarioCRUD.lblMode, InventarioCRUD)

        InventarioCRUD.btnMode.Text = "Guardar"

        Select Case btnConNombre.Text
            Case "Nuevo"
                InventarioCRUD.txtboxID.Text = ""
                InventarioCRUD.txtboxProducto.Text = ""
                InventarioCRUD.txtboxExistencia.Text = ""
                InventarioCRUD.cmbCategoria.Text = ""
            Case "Modificar", "Borrar"
                Dim Columna As Integer = dgvInventario.CurrentRow.Index

                InventarioCRUD.txtboxID.Enabled = False
                InventarioCRUD.txtboxID.Text = dgvInventario(0, Columna).Value
                InventarioCRUD.txtboxProducto.Text = dgvInventario(1, Columna).Value
                InventarioCRUD.txtboxExistencia.Text = dgvInventario(2, Columna).Value
                InventarioCRUD.cmbCategoria.Text = dgvInventario(3, Columna).Value

                If btnConNombre.Text = "Borrar" Then
                    InventarioCRUD.btnMode.Text = "Borrar"
                End If
        End Select

        InventarioCRUD.ShowDialog()
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        conexion.Consulta("SELECT ID_Producto AS ID, Nombre_Producto AS Nombre, Existencia_Producto AS Existencia, Nombre_Categoria AS Categoria FROM PRODUCTOS INNER JOIN CATEGORIAS ON CATEGORIAS.Categoria_ID = PRODUCTOS.Categoria_ID", "Productos", dgvInventario)
    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Consulta("SELECT ID_Producto AS ID, Nombre_Producto AS Nombre, Existencia_Producto AS Existencia, Nombre_Categoria AS Categoria FROM PRODUCTOS INNER JOIN CATEGORIAS ON CATEGORIAS.Categoria_ID = PRODUCTOS.Categoria_ID", "Productos", dgvInventario)
        conexion.ConsultacmbBox("SELECT * FROM CATEGORIAS", "Categoria_ID", "Nombre_Categoria", InventarioCRUD.cmbCategoria)
    End Sub
End Class