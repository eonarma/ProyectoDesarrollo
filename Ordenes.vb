Public Class Ordenes
    Private conexion As conexion = New conexion()
    Private Functions As Functions = New Functions()
    Private OrdenCRUD As ordenCRUD = New ordenCRUD()
    Private Sub btnAny_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click, btnModificar.Click, btnBorrar.Click
        Dim btnConNombre As Button = CType(sender, Button)

        OrdenCRUD.lblMode.Text = btnConNombre.Text
        Functions.recentrar(OrdenCRUD.lblMode, OrdenCRUD)

        OrdenCRUD.btnMode.Text = "Guardar"

        Select Case btnConNombre.Text
            Case "Nuevo"
                OrdenCRUD.txtboxID.Text = ""
                OrdenCRUD.cmbCliente.Text = ""
                OrdenCRUD.cmbSemilla.Text = ""
                OrdenCRUD.txtboxFecha.Text = ""
                OrdenCRUD.txtboxFecha.Text = "mm/dd/aaaa"
            Case "Modificar", "Borrar"
                Dim Columna As Integer = dgvOrdenes.CurrentRow.Index

                OrdenCRUD.txtboxID.Enabled = False
                OrdenCRUD.txtboxID.Text = dgvOrdenes(0, Columna).Value
                OrdenCRUD.cmbCliente.Text = dgvOrdenes(1, Columna).Value
                OrdenCRUD.cmbSemilla.Text = dgvOrdenes(2, Columna).Value
                OrdenCRUD.txtboxFecha.Text = dgvOrdenes(3, Columna).Value

                If btnConNombre.Text = "Borrar" Then
                    OrdenCRUD.btnMode.Text = "Borrar"
                End If
        End Select
        ' prueba
        OrdenCRUD.ShowDialog()

    End Sub
    Private Sub btnVerDetalle_Click(sender As Object, e As EventArgs) Handles btnVerDetalle.Click
        Dim Columna As Integer = dgvOrdenes.CurrentRow.Index

        DetalleOrden.txtboxOrden.Enabled = False
        DetalleOrden.txtboxEmpresa.Enabled = False
        DetalleOrden.txtboxSemilla.Enabled = False
        DetalleOrden.txtboxFecha.Enabled = False

        DetalleOrden.txtboxOrden.Text = dgvOrdenes(0, Columna).Value
        DetalleOrden.txtboxEmpresa.Text = dgvOrdenes(1, Columna).Value
        DetalleOrden.txtboxSemilla.Text = dgvOrdenes(2, Columna).Value
        DetalleOrden.txtboxFecha.Text = dgvOrdenes(3, Columna).Value

        Form1.switchPanel(DetalleOrden, Form1.PanelMain)
    End Sub

    Private Sub Ordenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Consulta("SELECT ID_Orden AS Orden, Empresa_Cliente AS Cliente, Nombre_Semilla AS Semilla, Fecha_Orden as Fecha FROM ORDENES INNER JOIN CLIENTES ON CLIENTES.ID_Cliente = ORDENES.ID_Cliente INNER JOIN SEMILLAS ON SEMILLAS.ID_Semilla = ORDENES.ID_Semilla", "ORDENES", dgvOrdenes)
        conexion.ConsultacmbBox("SELECT * FROM CLIENTES", "ID_Cliente", "Empresa_Cliente", OrdenCRUD.cmbCliente)
        conexion.ConsultacmbBox("SELECT * FROM SEMILLAS", "ID_Semilla", "Nombre_Semilla", OrdenCRUD.cmbSemilla)
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        conexion.Consulta("SELECT ID_Orden AS Orden, Empresa_Cliente AS Cliente, Nombre_Semilla AS Semilla, Fecha_Orden as Fecha FROM ORDENES INNER JOIN CLIENTES ON CLIENTES.ID_Cliente = ORDENES.ID_Cliente INNER JOIN SEMILLAS ON SEMILLAS.ID_Semilla = ORDENES.ID_Semilla", "ORDENES", dgvOrdenes)
    End Sub

End Class