Public Class DragPanel
    Dim mousepresionado As Boolean
    Dim FormWidth As Integer
    Dim MainForm As Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MainForm.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        MainForm.WindowState = 1
    End Sub

    'Funcion que cambia barra de tamaño en base a formulario donde se esta llamando(Tiene error, hay que corregir)
    Public Function CreateHeader(ByVal CurrentForm As Form) As Form
        FormWidth = CurrentForm.Size.Width
        Me.Width = FormWidth
        btnClose.Left = FormWidth - 30
        btnMinimizar.Left = FormWidth - 60
        MainForm = CurrentForm
        Return CurrentForm
    End Function

    'Codigo permite mover ventana agarrando el panel
    Private Sub DragPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        mousepresionado = True
    End Sub

    Private Sub DragPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If mousepresionado = True Then
            Dim mouseX = MousePosition.X - FormWidth / 2
            Dim mouseY = MousePosition.Y - 20
            MainForm.SetDesktopLocation(mouseX, mouseY)
        End If
    End Sub

    Private Sub DragPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        mousepresionado = False
    End Sub

End Class