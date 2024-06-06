Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormActualizarCostosSolicitudesMantenimientos
        'Inherits System.Windows.Forms.Form
        Inherits Krypton.Toolkit.KryptonForm
        'Form reemplaza a Dispose para limpiar la lista de componentes.
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

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormActualizarCostosSolicitudesMantenimientos))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dgvSolicitudesMantenimientos = New System.Windows.Forms.DataGridView()
            Me.dgvDetallesmantenimientos = New System.Windows.Forms.DataGridView()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dgvAsientosMantenimientos = New System.Windows.Forms.DataGridView()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dgvComprobanteCompra = New System.Windows.Forms.DataGridView()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnExportar = New System.Windows.Forms.Button()
            CType(Me.dgvSolicitudesMantenimientos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDetallesmantenimientos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvAsientosMantenimientos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(-2, 2)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(103, 19)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "PENDIENTES"
            '
            'dgvSolicitudesMantenimientos
            '
            Me.dgvSolicitudesMantenimientos.AllowUserToAddRows = False
            Me.dgvSolicitudesMantenimientos.AllowUserToDeleteRows = False
            Me.dgvSolicitudesMantenimientos.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvSolicitudesMantenimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvSolicitudesMantenimientos.BackgroundColor = System.Drawing.Color.White
            Me.dgvSolicitudesMantenimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvSolicitudesMantenimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvSolicitudesMantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvSolicitudesMantenimientos.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvSolicitudesMantenimientos.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dgvSolicitudesMantenimientos.Location = New System.Drawing.Point(1, 27)
            Me.dgvSolicitudesMantenimientos.MultiSelect = False
            Me.dgvSolicitudesMantenimientos.Name = "dgvSolicitudesMantenimientos"
            Me.dgvSolicitudesMantenimientos.ReadOnly = True
            Me.dgvSolicitudesMantenimientos.RowHeadersVisible = False
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvSolicitudesMantenimientos.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvSolicitudesMantenimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvSolicitudesMantenimientos.Size = New System.Drawing.Size(542, 162)
            Me.dgvSolicitudesMantenimientos.TabIndex = 206
            '
            'dgvDetallesmantenimientos
            '
            Me.dgvDetallesmantenimientos.AllowUserToAddRows = False
            Me.dgvDetallesmantenimientos.AllowUserToDeleteRows = False
            Me.dgvDetallesmantenimientos.AllowUserToResizeRows = False
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetallesmantenimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvDetallesmantenimientos.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetallesmantenimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDetallesmantenimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvDetallesmantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDetallesmantenimientos.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgvDetallesmantenimientos.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dgvDetallesmantenimientos.Location = New System.Drawing.Point(549, 27)
            Me.dgvDetallesmantenimientos.MultiSelect = False
            Me.dgvDetallesmantenimientos.Name = "dgvDetallesmantenimientos"
            Me.dgvDetallesmantenimientos.ReadOnly = True
            Me.dgvDetallesmantenimientos.RowHeadersVisible = False
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvDetallesmantenimientos.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgvDetallesmantenimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetallesmantenimientos.Size = New System.Drawing.Size(480, 162)
            Me.dgvDetallesmantenimientos.TabIndex = 207
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(545, 2)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(85, 19)
            Me.Label2.TabIndex = 208
            Me.Label2.Text = "DETALLES"
            '
            'dgvAsientosMantenimientos
            '
            Me.dgvAsientosMantenimientos.AllowUserToAddRows = False
            Me.dgvAsientosMantenimientos.AllowUserToDeleteRows = False
            Me.dgvAsientosMantenimientos.AllowUserToResizeRows = False
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvAsientosMantenimientos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvAsientosMantenimientos.BackgroundColor = System.Drawing.Color.White
            Me.dgvAsientosMantenimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvAsientosMantenimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
            Me.dgvAsientosMantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvAsientosMantenimientos.DefaultCellStyle = DataGridViewCellStyle11
            Me.dgvAsientosMantenimientos.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dgvAsientosMantenimientos.Location = New System.Drawing.Point(1, 216)
            Me.dgvAsientosMantenimientos.MultiSelect = False
            Me.dgvAsientosMantenimientos.Name = "dgvAsientosMantenimientos"
            Me.dgvAsientosMantenimientos.ReadOnly = True
            Me.dgvAsientosMantenimientos.RowHeadersVisible = False
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvAsientosMantenimientos.RowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvAsientosMantenimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvAsientosMantenimientos.Size = New System.Drawing.Size(1028, 168)
            Me.dgvAsientosMantenimientos.TabIndex = 209
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(1, 190)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(84, 19)
            Me.Label3.TabIndex = 210
            Me.Label3.Text = "ASIENTOS"
            '
            'dgvComprobanteCompra
            '
            Me.dgvComprobanteCompra.AllowUserToAddRows = False
            Me.dgvComprobanteCompra.AllowUserToDeleteRows = False
            Me.dgvComprobanteCompra.AllowUserToResizeRows = False
            DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvComprobanteCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvComprobanteCompra.BackgroundColor = System.Drawing.Color.White
            Me.dgvComprobanteCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvComprobanteCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
            Me.dgvComprobanteCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvComprobanteCompra.DefaultCellStyle = DataGridViewCellStyle15
            Me.dgvComprobanteCompra.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.dgvComprobanteCompra.Location = New System.Drawing.Point(0, 411)
            Me.dgvComprobanteCompra.MultiSelect = False
            Me.dgvComprobanteCompra.Name = "dgvComprobanteCompra"
            Me.dgvComprobanteCompra.ReadOnly = True
            Me.dgvComprobanteCompra.RowHeadersVisible = False
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvComprobanteCompra.RowsDefaultCellStyle = DataGridViewCellStyle16
            Me.dgvComprobanteCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvComprobanteCompra.Size = New System.Drawing.Size(1029, 194)
            Me.dgvComprobanteCompra.TabIndex = 211
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(1, 387)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(133, 23)
            Me.Label4.TabIndex = 212
            Me.Label4.Text = "COMPROBANTE"
            '
            'btnExportar
            '
            Me.btnExportar.BackColor = System.Drawing.Color.White
            Me.btnExportar.Font = New System.Drawing.Font("Consolas", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(932, 2)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(97, 23)
            Me.btnExportar.TabIndex = 230
            Me.btnExportar.Text = "EXPORTAR"
            Me.btnExportar.UseVisualStyleBackColor = False
            '
            'FormActualizarCostosSolicitudesMantenimientos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1030, 609)
            Me.Controls.Add(Me.btnExportar)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.dgvComprobanteCompra)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dgvAsientosMantenimientos)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dgvDetallesmantenimientos)
            Me.Controls.Add(Me.dgvSolicitudesMantenimientos)
            Me.Controls.Add(Me.Label1)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormActualizarCostosSolicitudesMantenimientos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ACTUALIZACION DE COSTOS DE MANTENIMIENTOS DE ACTIVOS FIJOS"
            CType(Me.dgvSolicitudesMantenimientos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDetallesmantenimientos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvAsientosMantenimientos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dgvSolicitudesMantenimientos As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetallesmantenimientos As System.Windows.Forms.DataGridView
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dgvAsientosMantenimientos As System.Windows.Forms.DataGridView
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dgvComprobanteCompra As System.Windows.Forms.DataGridView
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents btnExportar As System.Windows.Forms.Button
    End Class
End Namespace