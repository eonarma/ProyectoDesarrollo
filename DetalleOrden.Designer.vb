<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetalleOrden
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
        Me.lblSemilla = New System.Windows.Forms.Label()
        Me.lblOrden = New System.Windows.Forms.Label()
        Me.txtboxFecha = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblOrdenes = New System.Windows.Forms.Label()
        Me.grpboxDatos = New System.Windows.Forms.GroupBox()
        Me.txtboxSemilla = New System.Windows.Forms.TextBox()
        Me.txtboxOrden = New System.Windows.Forms.TextBox()
        Me.txtboxEmpresa = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.dgvDetalleOrden = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.grpboxDatos.SuspendLayout()
        CType(Me.dgvDetalleOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSemilla
        '
        Me.lblSemilla.AutoSize = True
        Me.lblSemilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemilla.ForeColor = System.Drawing.SystemColors.Control
        Me.lblSemilla.Location = New System.Drawing.Point(524, 64)
        Me.lblSemilla.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblSemilla.Name = "lblSemilla"
        Me.lblSemilla.Size = New System.Drawing.Size(76, 25)
        Me.lblSemilla.TabIndex = 17
        Me.lblSemilla.Text = "Semilla"
        '
        'lblOrden
        '
        Me.lblOrden.AutoSize = True
        Me.lblOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrden.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOrden.Location = New System.Drawing.Point(11, 64)
        Me.lblOrden.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(67, 25)
        Me.lblOrden.TabIndex = 14
        Me.lblOrden.Text = "Orden"
        '
        'txtboxFecha
        '
        Me.txtboxFecha.Location = New System.Drawing.Point(617, 26)
        Me.txtboxFecha.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtboxFecha.Name = "txtboxFecha"
        Me.txtboxFecha.Size = New System.Drawing.Size(160, 22)
        Me.txtboxFecha.TabIndex = 13
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFecha.Location = New System.Drawing.Point(524, 26)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(27, 198, 27, 25)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(67, 25)
        Me.lblFecha.TabIndex = 12
        Me.lblFecha.Text = "Fecha"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEmpresa.Location = New System.Drawing.Point(11, 26)
        Me.lblEmpresa.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(90, 25)
        Me.lblEmpresa.TabIndex = 11
        Me.lblEmpresa.Text = "Empresa"
        '
        'lblOrdenes
        '
        Me.lblOrdenes.AutoSize = True
        Me.lblOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenes.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOrdenes.Location = New System.Drawing.Point(39, 65)
        Me.lblOrdenes.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.lblOrdenes.Name = "lblOrdenes"
        Me.lblOrdenes.Size = New System.Drawing.Size(169, 42)
        Me.lblOrdenes.TabIndex = 10
        Me.lblOrdenes.Text = "Ordenes"
        '
        'grpboxDatos
        '
        Me.grpboxDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpboxDatos.Controls.Add(Me.txtboxSemilla)
        Me.grpboxDatos.Controls.Add(Me.txtboxOrden)
        Me.grpboxDatos.Controls.Add(Me.txtboxEmpresa)
        Me.grpboxDatos.Controls.Add(Me.lblEmpresa)
        Me.grpboxDatos.Controls.Add(Me.lblFecha)
        Me.grpboxDatos.Controls.Add(Me.lblSemilla)
        Me.grpboxDatos.Controls.Add(Me.lblOrden)
        Me.grpboxDatos.Controls.Add(Me.txtboxFecha)
        Me.grpboxDatos.ForeColor = System.Drawing.SystemColors.Control
        Me.grpboxDatos.Location = New System.Drawing.Point(39, 138)
        Me.grpboxDatos.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.grpboxDatos.Name = "grpboxDatos"
        Me.grpboxDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.grpboxDatos.Size = New System.Drawing.Size(789, 110)
        Me.grpboxDatos.TabIndex = 20
        Me.grpboxDatos.TabStop = False
        Me.grpboxDatos.Text = "Datos de Orden"
        '
        'txtboxSemilla
        '
        Me.txtboxSemilla.Location = New System.Drawing.Point(617, 68)
        Me.txtboxSemilla.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtboxSemilla.Name = "txtboxSemilla"
        Me.txtboxSemilla.Size = New System.Drawing.Size(160, 22)
        Me.txtboxSemilla.TabIndex = 20
        '
        'txtboxOrden
        '
        Me.txtboxOrden.Location = New System.Drawing.Point(115, 67)
        Me.txtboxOrden.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtboxOrden.Name = "txtboxOrden"
        Me.txtboxOrden.Size = New System.Drawing.Size(160, 22)
        Me.txtboxOrden.TabIndex = 19
        '
        'txtboxEmpresa
        '
        Me.txtboxEmpresa.Location = New System.Drawing.Point(115, 30)
        Me.txtboxEmpresa.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtboxEmpresa.Name = "txtboxEmpresa"
        Me.txtboxEmpresa.Size = New System.Drawing.Size(160, 22)
        Me.txtboxEmpresa.TabIndex = 18
        '
        'btnBorrar
        '
        Me.btnBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrar.Location = New System.Drawing.Point(731, 455)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(27, 6, 27, 25)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(100, 28)
        Me.btnBorrar.TabIndex = 22
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegresar.Location = New System.Drawing.Point(0, 0)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(60, 60)
        Me.btnRegresar.TabIndex = 23
        Me.btnRegresar.Text = "<"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'dgvDetalleOrden
        '
        Me.dgvDetalleOrden.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalleOrden.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetalleOrden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleOrden.Location = New System.Drawing.Point(39, 279)
        Me.dgvDetalleOrden.Margin = New System.Windows.Forms.Padding(27, 25, 27, 25)
        Me.dgvDetalleOrden.Name = "dgvDetalleOrden"
        Me.dgvDetalleOrden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleOrden.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalleOrden.RowHeadersVisible = False
        Me.dgvDetalleOrden.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvDetalleOrden.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalleOrden.Size = New System.Drawing.Size(635, 204)
        Me.dgvDetalleOrden.TabIndex = 24
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(731, 378)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(5, 5, 20, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 28)
        Me.btnAgregar.TabIndex = 25
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Location = New System.Drawing.Point(731, 416)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(5, 5, 20, 5)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 28)
        Me.btnModificar.TabIndex = 26
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'DetalleOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 517)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvDetalleOrden)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.grpboxDatos)
        Me.Controls.Add(Me.lblOrdenes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DetalleOrden"
        Me.Text = "DetalleOrden"
        Me.grpboxDatos.ResumeLayout(False)
        Me.grpboxDatos.PerformLayout()
        CType(Me.dgvDetalleOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSemilla As Label
    Friend WithEvents lblOrden As Label
    Friend WithEvents txtboxFecha As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblEmpresa As Label
    Friend WithEvents lblOrdenes As Label
    Friend WithEvents grpboxDatos As GroupBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents producto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents nota As DataGridViewButtonColumn
    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtboxSemilla As TextBox
    Friend WithEvents txtboxOrden As TextBox
    Friend WithEvents txtboxEmpresa As TextBox
    Friend WithEvents dgvDetalleOrden As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
End Class
