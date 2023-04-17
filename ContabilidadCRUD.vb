Public Class ContabilidadCRUD
    Private conexion As conexion = New conexion()
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub ContabilidadCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If lblContabilidad.Text = "Borrar" Then
            txtboxID.Enabled = False
            txtComentario.Enabled = False
            cbGestion.Enabled = False
            txtMonto.Enabled = False
            txtFecha.Enabled = False
        Else
            txtboxID.Enabled = True
            txtComentario.Enabled = True
            cbGestion.Enabled = True
            txtMonto.Enabled = True
            txtFecha.Enabled = True
        End If

    End Sub

    Private Sub btnMode_Click(sender As Object, e As EventArgs) Handles btnMode.Click
        Dim lbltext As String = lblContabilidad.Text
        Dim Query As String
        Select Case lbltext
            Case "Nuevo"
                Query = "INSERT INTO LIBRODIARIO VALUES (
                        " & txtComentario.Text & ",
                        '" & cbGestion.SelectedValue & "',
                        " & txtMonto.Text & ",
                        " & txtFecha.Text & "'"
            Case "Modificar"
                Query = "UPDATE LIBRODIARIO 
                         SET Movimiento_LibroDiario = '" & txtComentario.Text & "'
                         , ID_TipoCuenta = " & cbGestion.SelectedValue & "
                         , Monto_TipoCuenta = " & txtMonto.Text & "
                         , Fecha_Movimiento = " & txtFecha.Text & "
                         WHERE ID_LibroDiario = " & txtboxID.Text
            Case "Borrar"
                Query = "DELETE FROM LIBRODIARIO WHERE ID_LibroDiario = " & txtboxID.Text
        End Select

        conexion.EjecutarQuery(Query)
        conexion.Consulta("SELECT ID_LibroDiario AS ID, L.Movimiento_LibroDiario AS Movimiento, T.TipoCuenta AS Gestion, L.Monto_TipoCuenta AS Monto, L.Fecha_Movimiento AS Fecha FROM LIBRODIARIO L INNER JOIN TIPOCUENTA T ON T.ID_TipoCuenta = L.ID_TipoCuenta", "Productos", Inventario.dgvInventario)
        Me.Close()
    End Sub
End Class