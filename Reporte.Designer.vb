<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBarra = New System.Windows.Forms.Button()
        Me.btnLinea = New System.Windows.Forms.Button()
        Me.lblReportes = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Invernadero.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(742, 256)
        Me.ReportViewer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ReportViewer1)
        Me.Panel1.Location = New System.Drawing.Point(29, 102)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 256)
        Me.Panel1.TabIndex = 1
        '
        'btnBarra
        '
        Me.btnBarra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBarra.Location = New System.Drawing.Point(696, 398)
        Me.btnBarra.Margin = New System.Windows.Forms.Padding(20)
        Me.btnBarra.Name = "btnBarra"
        Me.btnBarra.Size = New System.Drawing.Size(75, 23)
        Me.btnBarra.TabIndex = 2
        Me.btnBarra.Text = "Barra"
        Me.btnBarra.UseVisualStyleBackColor = True
        '
        'btnLinea
        '
        Me.btnLinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLinea.Location = New System.Drawing.Point(581, 398)
        Me.btnLinea.Margin = New System.Windows.Forms.Padding(20)
        Me.btnLinea.Name = "btnLinea"
        Me.btnLinea.Size = New System.Drawing.Size(75, 23)
        Me.btnLinea.TabIndex = 3
        Me.btnLinea.Text = "Linea"
        Me.btnLinea.UseVisualStyleBackColor = True
        '
        'lblReportes
        '
        Me.lblReportes.AutoSize = True
        Me.lblReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportes.ForeColor = System.Drawing.SystemColors.Control
        Me.lblReportes.Location = New System.Drawing.Point(36, 15)
        Me.lblReportes.Margin = New System.Windows.Forms.Padding(27, 6, 7, 25)
        Me.lblReportes.Name = "lblReportes"
        Me.lblReportes.Size = New System.Drawing.Size(170, 42)
        Me.lblReportes.TabIndex = 8
        Me.lblReportes.Text = "Reportes"
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblReportes)
        Me.Controls.Add(Me.btnLinea)
        Me.Controls.Add(Me.btnBarra)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBarra As Button
    Friend WithEvents btnLinea As Button
    Friend WithEvents lblReportes As Label
End Class
