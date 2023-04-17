Public Class Functions
    Sub recentrar(ByVal label As Label, ByVal form As Form)
        Dim NuevoAncho As Integer
        NuevoAncho = form.Size.Width / 2 - label.Size.Width / 2
        label.Left = NuevoAncho
    End Sub
End Class
