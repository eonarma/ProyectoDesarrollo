<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvCRUDmodal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnMode = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtboxProducto = New System.Windows.Forms.TextBox()
        Me.txtboxExistencia = New System.Windows.Forms.TextBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblExistencia = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.txtboxID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMode
        '
        Me.btnMode.Location = New System.Drawing.Point(148, 342)
        Me.btnMode.Margin = New System.Windows.Forms.Padding(7, 18, 7, 25)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(104, 28)
        Me.btnMode.TabIndex = 3
        Me.btnMode.Text = "Guardar"
        Me.btnMode.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(265, 342)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(7, 6, 27, 25)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 28)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtboxProducto
        '
        Me.txtboxProducto.Location = New System.Drawing.Point(155, 218)
        Me.txtboxProducto.Margin = New System.Windows.Forms.Padding(7, 74, 27, 6)
        Me.txtboxProducto.Name = "txtboxProducto"
        Me.txtboxProducto.Size = New System.Drawing.Size(216, 22)
        Me.txtboxProducto.TabIndex = 5
        '
        'txtboxExistencia
        '
        Me.txtboxExistencia.Location = New System.Drawing.Point(155, 255)
        Me.txtboxExistencia.Margin = New System.Windows.Forms.Padding(7, 6, 27, 6)
        Me.txtboxExistencia.Name = "txtboxExistencia"
        Me.txtboxExistencia.Size = New System.Drawing.Size(216, 22)
        Me.txtboxExistencia.TabIndex = 6
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.SystemColors.Control
        Me.lblProducto.Location = New System.Drawing.Point(39, 220)
        Me.lblProducto.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(94, 24)
        Me.lblProducto.TabIndex = 8
        Me.lblProducto.Text = "Producto"
        '
        'lblExistencia
        '
        Me.lblExistencia.AutoSize = True
        Me.lblExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistencia.ForeColor = System.Drawing.SystemColors.Control
        Me.lblExistencia.Location = New System.Drawing.Point(39, 257)
        Me.lblExistencia.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(106, 24)
        Me.lblExistencia.TabIndex = 9
        Me.lblExistencia.Text = "Existencia"
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMode.Location = New System.Drawing.Point(147, 74)
        Me.lblMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(106, 39)
        Me.lblMode.TabIndex = 14
        Me.lblMode.Text = "Mode"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCategoria.Location = New System.Drawing.Point(39, 290)
        Me.lblCategoria.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(99, 24)
        Me.lblCategoria.TabIndex = 16
        Me.lblCategoria.Text = "Categoria"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Items.AddRange(New Object() {"Seleccione"})
        Me.cmbCategoria.Location = New System.Drawing.Point(155, 292)
        Me.cmbCategoria.Margin = New System.Windows.Forms.Padding(7, 6, 27, 6)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(216, 24)
        Me.cmbCategoria.TabIndex = 17
        '
        'txtboxID
        '
        Me.txtboxID.Location = New System.Drawing.Point(155, 183)
        Me.txtboxID.Margin = New System.Windows.Forms.Padding(7, 74, 27, 6)
        Me.txtboxID.Name = "txtboxID"
        Me.txtboxID.Size = New System.Drawing.Size(216, 22)
        Me.txtboxID.TabIndex = 18
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblID.Location = New System.Drawing.Point(39, 186)
        Me.lblID.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(29, 24)
        Me.lblID.TabIndex = 19
        Me.lblID.Text = "ID"
        '
        'InvCRUDmodal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(408, 406)
        Me.Controls.Add(Me.txtboxID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.txtboxProducto)
        Me.Controls.Add(Me.btnMode)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblExistencia)
        Me.Controls.Add(Me.txtboxExistencia)
        Me.Controls.Add(Me.lblProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "InvCRUDmodal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMode As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtboxProducto As TextBox
    Friend WithEvents txtboxExistencia As TextBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblExistencia As Label
    Friend WithEvents lblMode As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents txtboxID As TextBox
    Friend WithEvents lblID As Label
End Class
