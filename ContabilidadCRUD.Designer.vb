<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContabilidadCRUD
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblContabilidad = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblGestion = New System.Windows.Forms.Label()
        Me.lblComentario = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.btnMode = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtboxID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cbGestion = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblContabilidad
        '
        Me.lblContabilidad.AutoSize = True
        Me.lblContabilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContabilidad.ForeColor = System.Drawing.SystemColors.Control
        Me.lblContabilidad.Location = New System.Drawing.Point(63, 22)
        Me.lblContabilidad.Margin = New System.Windows.Forms.Padding(4, 30, 4, 0)
        Me.lblContabilidad.Name = "lblContabilidad"
        Me.lblContabilidad.Size = New System.Drawing.Size(229, 39)
        Me.lblContabilidad.TabIndex = 34
        Me.lblContabilidad.Text = "Awaiting LBL"
        Me.lblContabilidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(16, 116)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(64, 24)
        Me.lblFecha.TabIndex = 35
        Me.lblFecha.Text = "Fecha"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.White
        Me.lblMonto.Location = New System.Drawing.Point(16, 178)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(63, 24)
        Me.lblMonto.TabIndex = 36
        Me.lblMonto.Text = "Monto"
        '
        'lblGestion
        '
        Me.lblGestion.AutoSize = True
        Me.lblGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestion.ForeColor = System.Drawing.Color.White
        Me.lblGestion.Location = New System.Drawing.Point(16, 146)
        Me.lblGestion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGestion.Name = "lblGestion"
        Me.lblGestion.Size = New System.Drawing.Size(74, 24)
        Me.lblGestion.TabIndex = 37
        Me.lblGestion.Text = "Gestión"
        '
        'lblComentario
        '
        Me.lblComentario.AutoSize = True
        Me.lblComentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComentario.ForeColor = System.Drawing.Color.White
        Me.lblComentario.Location = New System.Drawing.Point(16, 234)
        Me.lblComentario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComentario.Name = "lblComentario"
        Me.lblComentario.Size = New System.Drawing.Size(107, 24)
        Me.lblComentario.TabIndex = 38
        Me.lblComentario.Text = "Comentario"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(156, 116)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(196, 22)
        Me.txtFecha.TabIndex = 2
        Me.txtFecha.Text = "12/10/2023"
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(156, 180)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(196, 22)
        Me.txtMonto.TabIndex = 4
        Me.txtMonto.Text = "L 1,232.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(20, 270)
        Me.txtComentario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(332, 90)
        Me.txtComentario.TabIndex = 5
        '
        'btnMode
        '
        Me.btnMode.Location = New System.Drawing.Point(138, 370)
        Me.btnMode.Margin = New System.Windows.Forms.Padding(7, 6, 7, 25)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(100, 28)
        Me.btnMode.TabIndex = 7
        Me.btnMode.Text = "Guardar"
        Me.btnMode.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(251, 370)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(7, 6, 27, 25)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtboxID
        '
        Me.txtboxID.Location = New System.Drawing.Point(155, 86)
        Me.txtboxID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxID.Name = "txtboxID"
        Me.txtboxID.Size = New System.Drawing.Size(196, 22)
        Me.txtboxID.TabIndex = 1
        Me.txtboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(15, 84)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(27, 24)
        Me.lblID.TabIndex = 46
        Me.lblID.Text = "ID"
        '
        'cbGestion
        '
        Me.cbGestion.FormattingEnabled = True
        Me.cbGestion.Location = New System.Drawing.Point(155, 146)
        Me.cbGestion.Margin = New System.Windows.Forms.Padding(7, 30, 20, 5)
        Me.cbGestion.Name = "cbGestion"
        Me.cbGestion.Size = New System.Drawing.Size(203, 24)
        Me.cbGestion.TabIndex = 3
        '
        'ContabilidadCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(387, 432)
        Me.Controls.Add(Me.cbGestion)
        Me.Controls.Add(Me.txtboxID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnMode)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.lblComentario)
        Me.Controls.Add(Me.lblGestion)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblContabilidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ContabilidadCRUD"
        Me.Text = "ContabilidadCRUD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblContabilidad As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblGestion As Label
    Friend WithEvents lblComentario As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents btnMode As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtboxID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents cbGestion As ComboBox
End Class
