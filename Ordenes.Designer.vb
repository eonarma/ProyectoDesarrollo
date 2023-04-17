<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ordenes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblOrdenes = New System.Windows.Forms.Label()
        Me.btnVerDetalle = New System.Windows.Forms.Button()
        Me.dgvOrdenes = New System.Windows.Forms.DataGridView()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOrdenes
        '
        Me.lblOrdenes.AutoSize = True
        Me.lblOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenes.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOrdenes.Location = New System.Drawing.Point(39, 36)
        Me.lblOrdenes.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblOrdenes.Name = "lblOrdenes"
        Me.lblOrdenes.Size = New System.Drawing.Size(169, 42)
        Me.lblOrdenes.TabIndex = 0
        Me.lblOrdenes.Text = "Ordenes"
        '
        'btnVerDetalle
        '
        Me.btnVerDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVerDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetalle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVerDetalle.Location = New System.Drawing.Point(152, 453)
        Me.btnVerDetalle.Margin = New System.Windows.Forms.Padding(7, 25, 27, 25)
        Me.btnVerDetalle.Name = "btnVerDetalle"
        Me.btnVerDetalle.Size = New System.Drawing.Size(100, 28)
        Me.btnVerDetalle.TabIndex = 7
        Me.btnVerDetalle.Text = "Ver Detalle"
        Me.btnVerDetalle.UseVisualStyleBackColor = True
        '
        'dgvOrdenes
        '
        Me.dgvOrdenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOrdenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdenes.Location = New System.Drawing.Point(39, 92)
        Me.dgvOrdenes.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.dgvOrdenes.Name = "dgvOrdenes"
        Me.dgvOrdenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrdenes.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOrdenes.RowHeadersVisible = False
        Me.dgvOrdenes.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvOrdenes.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOrdenes.Size = New System.Drawing.Size(789, 332)
        Me.dgvOrdenes.TabIndex = 9
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVisualizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVisualizar.Location = New System.Drawing.Point(39, 453)
        Me.btnVisualizar.Margin = New System.Windows.Forms.Padding(27, 25, 7, 25)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(100, 28)
        Me.btnVisualizar.TabIndex = 10
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNuevo.Location = New System.Drawing.Point(501, 453)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(7, 25, 7, 25)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 28)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(615, 453)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(7, 25, 7, 25)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 28)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBorrar.Location = New System.Drawing.Point(728, 453)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(7, 25, 27, 25)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(100, 28)
        Me.btnBorrar.TabIndex = 13
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Ordenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 517)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.dgvOrdenes)
        Me.Controls.Add(Me.btnVerDetalle)
        Me.Controls.Add(Me.lblOrdenes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Ordenes"
        Me.Text = "Ordenes"
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOrdenes As Label
    Friend WithEvents btnVerDetalle As Button
    Friend WithEvents dgvOrdenes As DataGridView
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBorrar As Button
End Class
