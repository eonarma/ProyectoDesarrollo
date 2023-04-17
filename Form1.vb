Public Class Form1

    Dim conexion As conexion = New conexion


    'Procedimiento para cambiar de form en un panel, parametro 1 es el formulario a mostrar, parametro 2 es en panel donde se mostrara el formulario
    Public Sub switchPanel(ByVal form As Form, ByVal ContainingPanel As Panel)
        ContainingPanel.Controls.Clear()
        form.TopLevel = False
        ContainingPanel.Controls.Add(form)
        form.Show()
    End Sub


    Public Sub formInPanelResize()

    End Sub

    Public Sub recentrar(ByVal label As Label, ByVal form As Form)
        Dim NuevoAncho As Integer
        NuevoAncho = form.Size.Width / 2 - label.Size.Width / 2
        label.Left = NuevoAncho
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        switchPanel(Clientes, PanelMain)
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        switchPanel(Inventario, PanelMain)


    End Sub

    Private Sub btnOrdenes_Click(sender As Object, e As EventArgs) Handles btnOrdenes.Click
        switchPanel(Ordenes, PanelMain)
    End Sub

    Private Sub BtnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        Me.Close()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Clientes.Width = PanelMain.Width
        Clientes.Height = PanelMain.Height

        Ordenes.Width = PanelMain.Width
        Ordenes.Height = PanelMain.Height


        Inventario.Width = PanelMain.Width
        Inventario.Height = PanelMain.Height

        Contabilidad1.Width = PanelMain.Width
        Contabilidad1.Height = PanelMain.Height

        DetalleOrden.Width = PanelMain.Width
        DetalleOrden.Height = PanelMain.Height

        Usuarios.Width = PanelMain.Width
        Usuarios.Height = PanelMain.Height

        Reporte.Width = PanelMain.Width
        Reporte.Height = PanelMain.Height
    End Sub

    Private Sub btnContabilidad_Click(sender As Object, e As EventArgs) Handles btnContabilidad.Click
        switchPanel(Contabilidad1, PanelMain)
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        switchPanel(Usuarios, PanelMain)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        switchPanel(Reporte, PanelMain)
    End Sub
End Class
