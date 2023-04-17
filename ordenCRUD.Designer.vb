<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ordenCRUD
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
        Me.lblMode = New System.Windows.Forms.Label()
        Me.txtboxID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblSemilla = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cmbSemilla = New System.Windows.Forms.ComboBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.btnMode = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtboxFecha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMode.Location = New System.Drawing.Point(137, 79)
        Me.lblMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(106, 39)
        Me.lblMode.TabIndex = 0
        Me.lblMode.Text = "Mode"
        '
        'txtboxID
        '
        Me.txtboxID.Location = New System.Drawing.Point(145, 165)
        Me.txtboxID.Margin = New System.Windows.Forms.Padding(7, 74, 27, 6)
        Me.txtboxID.Name = "txtboxID"
        Me.txtboxID.Size = New System.Drawing.Size(216, 22)
        Me.txtboxID.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblID.Location = New System.Drawing.Point(39, 167)
        Me.lblID.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(94, 24)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "ID Orden"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCliente.Location = New System.Drawing.Point(39, 206)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(75, 24)
        Me.lblCliente.TabIndex = 22
        Me.lblCliente.Text = "Cliente"
        '
        'lblSemilla
        '
        Me.lblSemilla.AutoSize = True
        Me.lblSemilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemilla.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSemilla.Location = New System.Drawing.Point(39, 244)
        Me.lblSemilla.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblSemilla.Name = "lblSemilla"
        Me.lblSemilla.Size = New System.Drawing.Size(78, 24)
        Me.lblSemilla.TabIndex = 24
        Me.lblSemilla.Text = "Semilla"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFecha.Location = New System.Drawing.Point(39, 274)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(69, 24)
        Me.lblFecha.TabIndex = 26
        Me.lblFecha.Text = "Fecha"
        '
        'cmbSemilla
        '
        Me.cmbSemilla.FormattingEnabled = True
        Me.cmbSemilla.Location = New System.Drawing.Point(145, 240)
        Me.cmbSemilla.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.cmbSemilla.Name = "cmbSemilla"
        Me.cmbSemilla.Size = New System.Drawing.Size(216, 24)
        Me.cmbSemilla.TabIndex = 3
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(145, 202)
        Me.cmbCliente.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(216, 24)
        Me.cmbCliente.TabIndex = 2
        '
        'btnMode
        '
        Me.btnMode.Location = New System.Drawing.Point(151, 345)
        Me.btnMode.Margin = New System.Windows.Forms.Padding(7, 18, 7, 25)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(104, 28)
        Me.btnMode.TabIndex = 5
        Me.btnMode.Text = "Guardar"
        Me.btnMode.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(268, 345)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(7, 6, 27, 25)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 28)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtboxFecha
        '
        Me.txtboxFecha.Location = New System.Drawing.Point(145, 274)
        Me.txtboxFecha.Margin = New System.Windows.Forms.Padding(7, 5, 27, 6)
        Me.txtboxFecha.Name = "txtboxFecha"
        Me.txtboxFecha.Size = New System.Drawing.Size(216, 22)
        Me.txtboxFecha.TabIndex = 4
        '
        'ordenCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(408, 406)
        Me.Controls.Add(Me.txtboxFecha)
        Me.Controls.Add(Me.btnMode)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.cmbSemilla)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblSemilla)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtboxID)
        Me.Controls.Add(Me.lblMode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "ordenCRUD"
        Me.Text = "Orden"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMode As Label
    Friend WithEvents txtboxID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblSemilla As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents cmbSemilla As ComboBox
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents btnMode As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtboxFecha As TextBox
End Class
