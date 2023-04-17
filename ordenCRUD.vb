Public Class ordenCRUD
    Private conexion As conexion = New conexion()

    Private Sub btnMode_Click(sender As Object, e As EventArgs) Handles btnMode.Click
        Dim lbltext As String = lblMode.Text
        Dim Query As String
        Select Case lbltext
            Case "Nuevo"
                Query = "INSERT INTO ORDENES VALUES (
                        " & txtboxID.Text & ",
                        " & cmbCliente.SelectedValue & ",
                        " & cmbSemilla.SelectedValue & ",
                        '" & txtboxFecha.Text & "')"
            Case "Modificar"
                Query = "UPDATE ORDENES 
                         SET ID_Cliente = " & cmbCliente.SelectedValue & "
                         , ID_Semilla = " & cmbSemilla.SelectedValue & "
                         , Fecha_Orden = '" & txtboxFecha.Text & "'
                         WHERE ID_Orden = " & txtboxID.Text
            Case "Borrar"
                Query = "DELETE FROM ORDENES WHERE ID_Orden = " & txtboxID.Text
        End Select

        conexion.EjecutarQuery(Query)
        conexion.Consulta("SELECT ID_Orden AS Orden, Empresa_Cliente AS Cliente, Nombre_Semilla AS Semilla, Fecha_Orden as Fecha FROM ORDENES INNER JOIN CLIENTES ON CLIENTES.ID_Cliente = ORDENES.ID_Cliente INNER JOIN SEMILLAS ON SEMILLAS.ID_Semilla = ORDENES.ID_Semilla", "ORDENES", Ordenes.dgvOrdenes)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub ordenCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If lblMode.Text = "Borrar" Then
            txtboxID.Enabled = False
            cmbCliente.Enabled = False
            cmbSemilla.Enabled = False
            txtboxFecha.Enabled = False
        Else
            txtboxID.Enabled = True
            cmbCliente.Enabled = True
            cmbSemilla.Enabled = True
            txtboxFecha.Enabled = True
        End If

    End Sub

End Class