Imports System.Data.SqlClient
Public Class Reporte
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim dt As New DataTable
        'Using con As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=Invernaderos;Integrated Security=True")

        '    con.Open()
        '    Using cmd As New SqlCommand("SELECT * FROM vResumenQuarterly", con)

        '        Dim da As New SqlDataAdapter
        '        da.SelectCommand = cmd
        '        da.Fill(dt)

        '    End Using

        'End Using
        'With Me.ReportViewer1.LocalReport
        '    .DataSources.Clear()
        '    .ReportPath = "C:\Users\Allan\source\repos\InvernaderoPD\Report1.rdlc"
        '    .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))

        'End With

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBarra.Click
        lblReportes.Text = "Grafica de Barra"
        Dim dt As New DataTable
        Using con As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=Invernaderos;Integrated Security=True")

            con.Open()
            Using cmd As New SqlCommand("SELECT * FROM vResumenQuarterly", con)

                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(dt)

            End Using

        End Using
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "C:\Users\Allan\source\repos\InvernaderoPD\Report1.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))

        End With

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLinea.Click
        lblReportes.Text = "Grafica de Linea"
        Dim dt As New DataTable
        Using con As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=Invernaderos;Integrated Security=True")

            con.Open()
            Using cmd As New SqlCommand("SELECT * FROM vResumenQuarterly", con)

                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(dt)

            End Using

        End Using
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "C:\Users\Allan\source\repos\InvernaderoPD\Report2.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))

        End With

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class