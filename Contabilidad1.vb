Public Class Contabilidad1
    Private conexion As conexion = New conexion()
    Private Functions As Functions = New Functions()
    Private contaCRUD As ContabilidadCRUD = New ContabilidadCRUD()
    Private Sub Contabilidad1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Consulta("SELECT ID_LibroDiario AS ID, L.Movimiento_LibroDiario AS Movimiento, T.TipoCuenta AS Gestion, L.Monto_TipoCuenta AS Monto, L.Fecha_Movimiento AS Fecha FROM LIBRODIARIO L INNER JOIN TIPOCUENTA T ON T.ID_TipoCuenta = L.ID_TipoCuenta", "LIBRODIARIO", dgvVentas)
        conexion.ConsultacmbBox("SELECT * FROM TIPOCUENTA", "ID_TipoCuenta", "TipoCuenta", contaCRUD.cbGestion)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click, btnModificar.Click, btnBorrar.Click
        Dim btnConNombre As Button = CType(sender, Button)

        contaCRUD.lblContabilidad.Text = btnConNombre.Text
        Functions.recentrar(contaCRUD.lblContabilidad, contaCRUD)

        contaCRUD.btnMode.Text = "Guardar"

        Select Case btnConNombre.Text
            Case "Nuevo"
                contaCRUD.txtFecha.Text = ""
                contaCRUD.cbGestion.Text = ""
                contaCRUD.txtMonto.Text = ""
                contaCRUD.txtComentario.Text = ""
            Case "Modificar", "Borrar"
                Dim Columna As Integer = dgvVentas.CurrentRow.Index

                contaCRUD.txtboxID.Enabled = False
                contaCRUD.txtboxID.Text = dgvVentas(0, Columna).Value
                contaCRUD.txtComentario.Text = dgvVentas(1, Columna).Value
                contaCRUD.cbGestion.Text = dgvVentas(2, Columna).Value
                contaCRUD.txtMonto.Text = dgvVentas(3, Columna).Value
                contaCRUD.txtFecha.Text = dgvVentas(4, Columna).Value

                If btnConNombre.Text = "Borrar" Then
                    contaCRUD.btnMode.Text = "Borrar"
                End If
        End Select

        contaCRUD.ShowDialog()
    End Sub
End Class