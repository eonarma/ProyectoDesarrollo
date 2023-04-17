<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenDetalleCRUD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtboxFecha = New System.Windows.Forms.TextBox()
        Me.btnMode = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.txtboxCantidad = New System.Windows.Forms.TextBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.txtboxNota = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtboxFecha
        '
        Me.txtboxFecha.Location = New System.Drawing.Point(145, 185)
        Me.txtboxFecha.Margin = New System.Windows.Forms.Padding(7, 5, 20, 5)
        Me.txtboxFecha.Name = "txtboxFecha"
        Me.txtboxFecha.Size = New System.Drawing.Size(216, 22)
        Me.txtboxFecha.TabIndex = 2
        '
        'btnMode
        '
        Me.btnMode.Location = New System.Drawing.Point(151, 344)
        Me.btnMode.Margin = New System.Windows.Forms.Padding(7, 18, 7, 25)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(104, 28)
        Me.btnMode.TabIndex = 5
        Me.btnMode.Text = "Guardar"
        Me.btnMode.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(268, 344)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(7, 6, 27, 25)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 28)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(145, 151)
        Me.cmbProducto.Margin = New System.Windows.Forms.Padding(7, 30, 20, 5)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(216, 24)
        Me.cmbProducto.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFecha.Location = New System.Drawing.Point(39, 183)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(69, 24)
        Me.lblFecha.TabIndex = 38
        Me.lblFecha.Text = "Fecha"
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNota.Location = New System.Drawing.Point(39, 247)
        Me.lblNota.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(53, 24)
        Me.lblNota.TabIndex = 37
        Me.lblNota.Text = "Nota"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCantidad.Location = New System.Drawing.Point(39, 215)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(92, 24)
        Me.lblCantidad.TabIndex = 36
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.SystemColors.Control
        Me.lblProducto.Location = New System.Drawing.Point(37, 151)
        Me.lblProducto.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(94, 24)
        Me.lblProducto.TabIndex = 35
        Me.lblProducto.Text = "Producto"
        '
        'txtboxCantidad
        '
        Me.txtboxCantidad.Location = New System.Drawing.Point(145, 217)
        Me.txtboxCantidad.Margin = New System.Windows.Forms.Padding(7, 5, 20, 5)
        Me.txtboxCantidad.Name = "txtboxCantidad"
        Me.txtboxCantidad.Size = New System.Drawing.Size(216, 22)
        Me.txtboxCantidad.TabIndex = 3
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMode.Location = New System.Drawing.Point(149, 70)
        Me.lblMode.Margin = New System.Windows.Forms.Padding(4, 30, 4, 0)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(106, 39)
        Me.lblMode.TabIndex = 33
        Me.lblMode.Text = "Mode"
        '
        'txtboxNota
        '
        Me.txtboxNota.Location = New System.Drawing.Point(145, 249)
        Me.txtboxNota.Margin = New System.Windows.Forms.Padding(7, 5, 20, 20)
        Me.txtboxNota.Multiline = True
        Me.txtboxNota.Name = "txtboxNota"
        Me.txtboxNota.Size = New System.Drawing.Size(216, 69)
        Me.txtboxNota.TabIndex = 4
        '
        'OrdenDetalleCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(408, 406)
        Me.Controls.Add(Me.txtboxNota)
        Me.Controls.Add(Me.txtboxFecha)
        Me.Controls.Add(Me.btnMode)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.txtboxCantidad)
        Me.Controls.Add(Me.lblMode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OrdenDetalleCRUD"
        Me.Text = "OrdenDetalle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxFecha As TextBox
    Friend WithEvents btnMode As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblNota As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents txtboxCantidad As TextBox
    Friend WithEvents lblMode As Label
    Friend WithEvents txtboxNota As TextBox
End Class
