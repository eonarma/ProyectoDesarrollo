<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtboxUsuario = New System.Windows.Forms.TextBox()
        Me.txtboxContra = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(155, 415)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(75, 23)
        Me.btnInicio.TabIndex = 0
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(155, 448)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtboxUsuario
        '
        Me.txtboxUsuario.Location = New System.Drawing.Point(220, 270)
        Me.txtboxUsuario.Name = "txtboxUsuario"
        Me.txtboxUsuario.Size = New System.Drawing.Size(100, 22)
        Me.txtboxUsuario.TabIndex = 2
        '
        'txtboxContra
        '
        Me.txtboxContra.Location = New System.Drawing.Point(220, 325)
        Me.txtboxContra.Name = "txtboxContra"
        Me.txtboxContra.Size = New System.Drawing.Size(100, 22)
        Me.txtboxContra.TabIndex = 3
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.lblUsuario.Location = New System.Drawing.Point(91, 266)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(86, 25)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.SystemColors.Control
        Me.lblContraseña.Location = New System.Drawing.Point(66, 321)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(124, 25)
        Me.lblContraseña.TabIndex = 5
        Me.lblContraseña.Text = "Contraseña"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Invernadero.My.Resources.Resources.greenhouse_light
        Me.PictureBox1.Location = New System.Drawing.Point(107, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 500)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtboxContra)
        Me.Controls.Add(Me.txtboxUsuario)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInicio As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtboxUsuario As TextBox
    Friend WithEvents txtboxContra As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblContraseña As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
