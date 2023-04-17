Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=Invernaderos;Integrated Security=True")
    Public cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter

    'Funcion Consulta a SQL
    Public Sub LoginVerification(ByVal Usuario As String, ByVal Password As String)
        Try
            Dim query As String = "SELECT * FROM USUARIOS WHERE Usuario_Usuario=@Username AND password_Usario=@Password"
            Dim command As New SqlCommand(query, conexion)
            command.Parameters.AddWithValue("@Username", Usuario)
            command.Parameters.AddWithValue("@Password", Password)

            conexion.Open()

            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then

                reader.Read()
                Dim userRole As String = reader("Permiso_Usuario").ToString()

                If userRole = "Admin" Then
                    Form1.btnUsuarios.Visible = True
                    Form1.btnReporte.Visible = True
                ElseIf userRole = "UsuarioRegular" Then
                    Form1.btnUsuarios.Visible = False
                    Form1.btnReporte.Visible = False
                End If
                MessageBox.Show("Sesion iniciada exitosamente")
                Form1.Show()
                Login.Hide()
            Else
                MessageBox.Show("Usuario o Contraseña invalida. Intente nuevamente.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String, ByVal dgv As DataGridView)

        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
        dgv.DataSource = ds.Tables(tabla)
    End Sub

    'Funcion Consulta que llena un combobox
    Public Sub ConsultacmbBox(ByVal sql As String, ByVal ID As String, ByVal Column As String, ByVal ComboBox As ComboBox)
        Dim dt As New DataTable()
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        da.Fill(dt)
        ComboBox.DataSource = dt
        ComboBox.ValueMember = ID
        ComboBox.DisplayMember = Column
    End Sub

    'Funcion Ejecuta query
    Public Sub EjecutarQuery(ByVal Query As String)
        Dim cmb As New SqlCommand(Query, conexion)
        conexion.Open()
        cmb.ExecuteNonQuery()
        conexion.Close()
    End Sub
End Class
