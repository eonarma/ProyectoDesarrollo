<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuarioCRUD
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
        Me.btnMode = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblUsuarios = New System.Windows.Forms.Label()
        Me.cmprivilegio = New System.Windows.Forms.ComboBox()
        Me.lblPrivilegio = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtboxUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnMode
        '
        Me.btnMode.Location = New System.Drawing.Point(151, 344)
        Me.btnMode.Margin = New System.Windows.Forms.Padding(7, 18, 7, 25)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(104, 28)
        Me.btnMode.TabIndex = 7
        Me.btnMode.Text = "Guardar"
        Me.btnMode.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(268, 344)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(7, 6, 27, 25)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 28)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblUsuarios
        '
        Me.lblUsuarios.AutoSize = True
        Me.lblUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarios.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUsuarios.Location = New System.Drawing.Point(137, 79)
        Me.lblUsuarios.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(106, 39)
        Me.lblUsuarios.TabIndex = 9
        Me.lblUsuarios.Text = "Mode"
        '
        'cmprivilegio
        '
        Me.cmprivilegio.FormattingEnabled = True
        Me.cmprivilegio.Location = New System.Drawing.Point(156, 254)
        Me.cmprivilegio.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.cmprivilegio.Name = "cmprivilegio"
        Me.cmprivilegio.Size = New System.Drawing.Size(216, 24)
        Me.cmprivilegio.TabIndex = 27
        '
        'lblPrivilegio
        '
        Me.lblPrivilegio.AutoSize = True
        Me.lblPrivilegio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrivilegio.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPrivilegio.Location = New System.Drawing.Point(38, 254)
        Me.lblPrivilegio.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblPrivilegio.Name = "lblPrivilegio"
        Me.lblPrivilegio.Size = New System.Drawing.Size(96, 24)
        Me.lblPrivilegio.TabIndex = 30
        Me.lblPrivilegio.Text = "Privilegio"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPassword.Location = New System.Drawing.Point(38, 216)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(116, 24)
        Me.lblPassword.TabIndex = 29
        Me.lblPassword.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUsuario.Location = New System.Drawing.Point(38, 177)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(27, 6, 7, 6)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(81, 24)
        Me.lblUsuario.TabIndex = 28
        Me.lblUsuario.Text = "Usuario"
        '
        'txtboxUsuario
        '
        Me.txtboxUsuario.Location = New System.Drawing.Point(156, 179)
        Me.txtboxUsuario.Margin = New System.Windows.Forms.Padding(7, 74, 27, 6)
        Me.txtboxUsuario.Name = "txtboxUsuario"
        Me.txtboxUsuario.Size = New System.Drawing.Size(216, 22)
        Me.txtboxUsuario.TabIndex = 25
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(156, 218)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(7, 74, 27, 6)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(216, 22)
        Me.txtContrasena.TabIndex = 31
        '
        'UsuarioCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(408, 406)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.cmprivilegio)
        Me.Controls.Add(Me.lblPrivilegio)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtboxUsuario)
        Me.Controls.Add(Me.lblUsuarios)
        Me.Controls.Add(Me.btnMode)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UsuarioCRUD"
        Me.Text = "UsuarioCRUD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMode As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblUsuarios As Label
    Friend WithEvents cmprivilegio As ComboBox
    Friend WithEvents lblPrivilegio As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtboxUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
End Class
