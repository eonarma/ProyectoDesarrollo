<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClienteCRUDmodal
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
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.btnMode = New System.Windows.Forms.Button()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.txtboxEmpresa = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtboxDireccion = New System.Windows.Forms.TextBox()
        Me.txtboxContacto = New System.Windows.Forms.TextBox()
        Me.lblContacto = New System.Windows.Forms.Label()
        Me.txtboxTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblModeCliente = New System.Windows.Forms.Label()
        Me.txtboxID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDireccion.Location = New System.Drawing.Point(35, 272)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(99, 24)
        Me.lblDireccion.TabIndex = 28
        Me.lblDireccion.Text = "Direccion"
        '
        'btnMode
        '
        Me.btnMode.Location = New System.Drawing.Point(188, 441)
        Me.btnMode.Margin = New System.Windows.Forms.Padding(7, 6, 7, 25)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(100, 28)
        Me.btnMode.TabIndex = 6
        Me.btnMode.Text = "Guardar"
        Me.btnMode.UseVisualStyleBackColor = True
        '
        'lblMode
        '
        Me.lblMode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMode.Location = New System.Drawing.Point(-196, 39)
        Me.lblMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(106, 39)
        Me.lblMode.TabIndex = 27
        Me.lblMode.Text = "Mode"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(301, 441)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(7, 6, 27, 25)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEmpresa.Location = New System.Drawing.Point(35, 238)
        Me.lblEmpresa.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(93, 24)
        Me.lblEmpresa.TabIndex = 23
        Me.lblEmpresa.Text = "Empresa"
        '
        'txtboxEmpresa
        '
        Me.txtboxEmpresa.Location = New System.Drawing.Point(177, 233)
        Me.txtboxEmpresa.Margin = New System.Windows.Forms.Padding(7, 6, 27, 6)
        Me.txtboxEmpresa.Name = "txtboxEmpresa"
        Me.txtboxEmpresa.Size = New System.Drawing.Size(223, 22)
        Me.txtboxEmpresa.TabIndex = 2
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.SystemColors.Control
        Me.lblId.Location = New System.Drawing.Point(39, 198)
        Me.lblId.Margin = New System.Windows.Forms.Padding(27, 198, 7, 6)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(29, 24)
        Me.lblId.TabIndex = 22
        Me.lblId.Text = "ID"
        '
        'txtboxDireccion
        '
        Me.txtboxDireccion.Location = New System.Drawing.Point(177, 270)
        Me.txtboxDireccion.Margin = New System.Windows.Forms.Padding(7, 6, 27, 6)
        Me.txtboxDireccion.Name = "txtboxDireccion"
        Me.txtboxDireccion.Size = New System.Drawing.Size(223, 22)
        Me.txtboxDireccion.TabIndex = 3
        '
        'txtboxContacto
        '
        Me.txtboxContacto.Location = New System.Drawing.Point(177, 306)
        Me.txtboxContacto.Margin = New System.Windows.Forms.Padding(7, 6, 27, 6)
        Me.txtboxContacto.Name = "txtboxContacto"
        Me.txtboxContacto.Size = New System.Drawing.Size(223, 22)
        Me.txtboxContacto.TabIndex = 4
        '
        'lblContacto
        '
        Me.lblContacto.AutoSize = True
        Me.lblContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContacto.ForeColor = System.Drawing.SystemColors.Control
        Me.lblContacto.Location = New System.Drawing.Point(35, 309)
        Me.lblContacto.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(92, 24)
        Me.lblContacto.TabIndex = 30
        Me.lblContacto.Text = "Contacto"
        '
        'txtboxTelefono
        '
        Me.txtboxTelefono.Location = New System.Drawing.Point(177, 343)
        Me.txtboxTelefono.Margin = New System.Windows.Forms.Padding(7, 6, 27, 6)
        Me.txtboxTelefono.Name = "txtboxTelefono"
        Me.txtboxTelefono.Size = New System.Drawing.Size(223, 22)
        Me.txtboxTelefono.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTelefono.Location = New System.Drawing.Point(35, 346)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(93, 24)
        Me.lblTelefono.TabIndex = 32
        Me.lblTelefono.Text = "Telefono"
        '
        'lblModeCliente
        '
        Me.lblModeCliente.AutoSize = True
        Me.lblModeCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeCliente.ForeColor = System.Drawing.SystemColors.Control
        Me.lblModeCliente.Location = New System.Drawing.Point(164, 78)
        Me.lblModeCliente.Margin = New System.Windows.Forms.Padding(7, 37, 7, 74)
        Me.lblModeCliente.Name = "lblModeCliente"
        Me.lblModeCliente.Size = New System.Drawing.Size(106, 39)
        Me.lblModeCliente.TabIndex = 34
        Me.lblModeCliente.Text = "Mode"
        '
        'txtboxID
        '
        Me.txtboxID.Location = New System.Drawing.Point(177, 196)
        Me.txtboxID.Margin = New System.Windows.Forms.Padding(7, 6, 27, 6)
        Me.txtboxID.Name = "txtboxID"
        Me.txtboxID.Size = New System.Drawing.Size(223, 22)
        Me.txtboxID.TabIndex = 1
        '
        'ClienteCRUDmodal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(440, 505)
        Me.Controls.Add(Me.txtboxID)
        Me.Controls.Add(Me.lblModeCliente)
        Me.Controls.Add(Me.txtboxTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtboxContacto)
        Me.Controls.Add(Me.lblContacto)
        Me.Controls.Add(Me.txtboxDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.btnMode)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.txtboxEmpresa)
        Me.Controls.Add(Me.lblId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ClienteCRUDmodal"
        Me.Text = "ClienteCRUDmodal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDireccion As Label
    Friend WithEvents btnMode As Button
    Friend WithEvents lblMode As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents txtboxEmpresa As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents txtboxDireccion As TextBox
    Friend WithEvents txtboxContacto As TextBox
    Friend WithEvents lblContacto As Label
    Friend WithEvents txtboxTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblModeCliente As Label
    Friend WithEvents txtboxID As TextBox
End Class
