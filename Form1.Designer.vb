<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.PanelSide = New System.Windows.Forms.Panel()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnContabilidad = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.btnOrdenes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.PanelSide.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSide
        '
        Me.PanelSide.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelSide.AutoSize = True
        Me.PanelSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanelSide.Controls.Add(Me.btnReporte)
        Me.PanelSide.Controls.Add(Me.btnUsuarios)
        Me.PanelSide.Controls.Add(Me.btnContabilidad)
        Me.PanelSide.Controls.Add(Me.btnClientes)
        Me.PanelSide.Controls.Add(Me.btnShutdown)
        Me.PanelSide.Controls.Add(Me.btnOrdenes)
        Me.PanelSide.Controls.Add(Me.PictureBox1)
        Me.PanelSide.Controls.Add(Me.btnInventario)
        Me.PanelSide.Location = New System.Drawing.Point(0, -1)
        Me.PanelSide.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelSide.Name = "PanelSide"
        Me.PanelSide.Size = New System.Drawing.Size(284, 682)
        Me.PanelSide.TabIndex = 0
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PanelMain.Location = New System.Drawing.Point(277, -1)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1156, 689)
        Me.PanelMain.TabIndex = 2
        '
        'btnReporte
        '
        Me.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReporte.FlatAppearance.BorderSize = 0
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReporte.Image = Global.Invernadero.My.Resources.Resources.black_and_white_shaking_hands
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(13, 416)
        Me.btnReporte.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(265, 32)
        Me.btnReporte.TabIndex = 7
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUsuarios.Image = Global.Invernadero.My.Resources.Resources.white__3_
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(13, 376)
        Me.btnUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(265, 32)
        Me.btnUsuarios.TabIndex = 6
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnContabilidad
        '
        Me.btnContabilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnContabilidad.FlatAppearance.BorderSize = 0
        Me.btnContabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContabilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContabilidad.ForeColor = System.Drawing.SystemColors.Control
        Me.btnContabilidad.Image = Global.Invernadero.My.Resources.Resources.order_food
        Me.btnContabilidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContabilidad.Location = New System.Drawing.Point(13, 337)
        Me.btnContabilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.btnContabilidad.Name = "btnContabilidad"
        Me.btnContabilidad.Size = New System.Drawing.Size(265, 32)
        Me.btnContabilidad.TabIndex = 5
        Me.btnContabilidad.Text = "Contabilidad"
        Me.btnContabilidad.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClientes.Image = Global.Invernadero.My.Resources.Resources.client
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(13, 257)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(265, 32)
        Me.btnClientes.TabIndex = 4
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnShutdown
        '
        Me.btnShutdown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShutdown.AutoSize = True
        Me.btnShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnShutdown.FlatAppearance.BorderSize = 0
        Me.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShutdown.ForeColor = System.Drawing.SystemColors.Control
        Me.btnShutdown.Image = Global.Invernadero.My.Resources.Resources.power
        Me.btnShutdown.Location = New System.Drawing.Point(13, 625)
        Me.btnShutdown.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(48, 44)
        Me.btnShutdown.TabIndex = 2
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'btnOrdenes
        '
        Me.btnOrdenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOrdenes.FlatAppearance.BorderSize = 0
        Me.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenes.ForeColor = System.Drawing.SystemColors.Control
        Me.btnOrdenes.Image = Global.Invernadero.My.Resources.Resources.order_food
        Me.btnOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrdenes.Location = New System.Drawing.Point(13, 297)
        Me.btnOrdenes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrdenes.Name = "btnOrdenes"
        Me.btnOrdenes.Size = New System.Drawing.Size(265, 32)
        Me.btnOrdenes.TabIndex = 1
        Me.btnOrdenes.Text = "Ordenes"
        Me.btnOrdenes.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Invernadero.My.Resources.Resources.greenhouse_green
        Me.PictureBox1.Location = New System.Drawing.Point(51, 37)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnInventario
        '
        Me.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInventario.FlatAppearance.BorderSize = 0
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.ForeColor = System.Drawing.SystemColors.Control
        Me.btnInventario.Image = Global.Invernadero.My.Resources.Resources.ready_stock
        Me.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventario.Location = New System.Drawing.Point(13, 217)
        Me.btnInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(265, 32)
        Me.btnInventario.TabIndex = 0
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1423, 681)
        Me.Controls.Add(Me.PanelSide)
        Me.Controls.Add(Me.PanelMain)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.PanelSide.ResumeLayout(False)
        Me.PanelSide.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelSide As Panel
    Friend WithEvents btnInventario As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents btnShutdown As Button
    Friend WithEvents btnOrdenes As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnContabilidad As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnReporte As Button
End Class
