Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormBuscarEvaluacionProveedor
        Inherits System.Windows.Forms.Form

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuscarEvaluacionProveedor))
            Me.dgvEvaluacionProveedor = New System.Windows.Forms.DataGridView()
            Me.gbNombreComercialProveedor = New System.Windows.Forms.GroupBox()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblIdProveedorGeneral = New System.Windows.Forms.Label()
            Me.gbRangoFechas = New System.Windows.Forms.GroupBox()
            Me.lblIdEvaluacionProveedor = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
            Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
            Me.gbParametrosBusqueda = New System.Windows.Forms.GroupBox()
            Me.rbTodo = New System.Windows.Forms.RadioButton()
            Me.rbServicios = New System.Windows.Forms.RadioButton()
            Me.rbProductos = New System.Windows.Forms.RadioButton()
            Me.rbProveedor = New System.Windows.Forms.RadioButton()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnBuscar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarProveedorGeneral = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvEvaluacionProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbNombreComercialProveedor.SuspendLayout()
            Me.gbRangoFechas.SuspendLayout()
            Me.gbParametrosBusqueda.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvEvaluacionProveedor
            '
            Me.dgvEvaluacionProveedor.AllowUserToAddRows = False
            Me.dgvEvaluacionProveedor.AllowUserToDeleteRows = False
            Me.dgvEvaluacionProveedor.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvEvaluacionProveedor.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvEvaluacionProveedor.BackgroundColor = System.Drawing.Color.White
            Me.dgvEvaluacionProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvEvaluacionProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvEvaluacionProveedor.Location = New System.Drawing.Point(2, 88)
            Me.dgvEvaluacionProveedor.MultiSelect = False
            Me.dgvEvaluacionProveedor.Name = "dgvEvaluacionProveedor"
            Me.dgvEvaluacionProveedor.ReadOnly = True
            Me.dgvEvaluacionProveedor.RowHeadersVisible = False
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgvEvaluacionProveedor.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvEvaluacionProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvEvaluacionProveedor.Size = New System.Drawing.Size(1016, 530)
            Me.dgvEvaluacionProveedor.TabIndex = 107
            '
            'gbNombreComercialProveedor
            '
            Me.gbNombreComercialProveedor.BackColor = System.Drawing.Color.White
            Me.gbNombreComercialProveedor.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.gbNombreComercialProveedor.Controls.Add(Me.lblIdProveedorGeneral)
            Me.gbNombreComercialProveedor.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbNombreComercialProveedor.Location = New System.Drawing.Point(184, 25)
            Me.gbNombreComercialProveedor.Name = "gbNombreComercialProveedor"
            Me.gbNombreComercialProveedor.Size = New System.Drawing.Size(586, 61)
            Me.gbNombreComercialProveedor.TabIndex = 106
            Me.gbNombreComercialProveedor.TabStop = False
            Me.gbNombreComercialProveedor.Text = "PROVEEDOR"
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.BackColor = System.Drawing.Color.White
            Me.txtNombreComercialProveedorGeneral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(21, 24)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(542, 20)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 2
            '
            'lblIdProveedorGeneral
            '
            Me.lblIdProveedorGeneral.AutoSize = True
            Me.lblIdProveedorGeneral.Location = New System.Drawing.Point(74, -1)
            Me.lblIdProveedorGeneral.Name = "lblIdProveedorGeneral"
            Me.lblIdProveedorGeneral.Size = New System.Drawing.Size(13, 13)
            Me.lblIdProveedorGeneral.TabIndex = 76
            Me.lblIdProveedorGeneral.Text = "0"
            '
            'gbRangoFechas
            '
            Me.gbRangoFechas.BackColor = System.Drawing.Color.White
            Me.gbRangoFechas.Controls.Add(Me.lblIdEvaluacionProveedor)
            Me.gbRangoFechas.Controls.Add(Me.Label1)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaHasta)
            Me.gbRangoFechas.Controls.Add(Me.dtpFechaDesde)
            Me.gbRangoFechas.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRangoFechas.Location = New System.Drawing.Point(770, 25)
            Me.gbRangoFechas.Name = "gbRangoFechas"
            Me.gbRangoFechas.Size = New System.Drawing.Size(248, 61)
            Me.gbRangoFechas.TabIndex = 109
            Me.gbRangoFechas.TabStop = False
            Me.gbRangoFechas.Text = "RANGO DE FECHAS"
            '
            'lblIdEvaluacionProveedor
            '
            Me.lblIdEvaluacionProveedor.AutoSize = True
            Me.lblIdEvaluacionProveedor.Location = New System.Drawing.Point(211, -1)
            Me.lblIdEvaluacionProveedor.Name = "lblIdEvaluacionProveedor"
            Me.lblIdEvaluacionProveedor.Size = New System.Drawing.Size(25, 13)
            Me.lblIdEvaluacionProveedor.TabIndex = 3
            Me.lblIdEvaluacionProveedor.Text = "..."
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(117, 28)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(13, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "a"
            '
            'dtpFechaHasta
            '
            Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaHasta.Location = New System.Drawing.Point(136, 24)
            Me.dtpFechaHasta.Name = "dtpFechaHasta"
            Me.dtpFechaHasta.Size = New System.Drawing.Size(103, 20)
            Me.dtpFechaHasta.TabIndex = 1
            '
            'dtpFechaDesde
            '
            Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaDesde.Location = New System.Drawing.Point(9, 24)
            Me.dtpFechaDesde.Name = "dtpFechaDesde"
            Me.dtpFechaDesde.Size = New System.Drawing.Size(103, 20)
            Me.dtpFechaDesde.TabIndex = 0
            '
            'gbParametrosBusqueda
            '
            Me.gbParametrosBusqueda.BackColor = System.Drawing.Color.White
            Me.gbParametrosBusqueda.Controls.Add(Me.rbTodo)
            Me.gbParametrosBusqueda.Controls.Add(Me.rbServicios)
            Me.gbParametrosBusqueda.Controls.Add(Me.rbProductos)
            Me.gbParametrosBusqueda.Controls.Add(Me.rbProveedor)
            Me.gbParametrosBusqueda.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbParametrosBusqueda.Location = New System.Drawing.Point(2, 25)
            Me.gbParametrosBusqueda.Name = "gbParametrosBusqueda"
            Me.gbParametrosBusqueda.Size = New System.Drawing.Size(182, 61)
            Me.gbParametrosBusqueda.TabIndex = 108
            Me.gbParametrosBusqueda.TabStop = False
            Me.gbParametrosBusqueda.Text = "TIPO BUSQUEDA"
            '
            'rbTodo
            '
            Me.rbTodo.AutoSize = True
            Me.rbTodo.Checked = True
            Me.rbTodo.Location = New System.Drawing.Point(101, 37)
            Me.rbTodo.Name = "rbTodo"
            Me.rbTodo.Size = New System.Drawing.Size(49, 17)
            Me.rbTodo.TabIndex = 3
            Me.rbTodo.TabStop = True
            Me.rbTodo.Text = "TODO"
            Me.rbTodo.UseVisualStyleBackColor = True
            '
            'rbServicios
            '
            Me.rbServicios.AutoSize = True
            Me.rbServicios.Location = New System.Drawing.Point(10, 37)
            Me.rbServicios.Name = "rbServicios"
            Me.rbServicios.Size = New System.Drawing.Size(79, 17)
            Me.rbServicios.TabIndex = 2
            Me.rbServicios.Text = "SERVICIOS"
            Me.rbServicios.UseVisualStyleBackColor = True
            '
            'rbProductos
            '
            Me.rbProductos.AutoSize = True
            Me.rbProductos.Location = New System.Drawing.Point(10, 17)
            Me.rbProductos.Name = "rbProductos"
            Me.rbProductos.Size = New System.Drawing.Size(85, 17)
            Me.rbProductos.TabIndex = 1
            Me.rbProductos.Text = "MATERIALES"
            Me.rbProductos.UseVisualStyleBackColor = True
            '
            'rbProveedor
            '
            Me.rbProveedor.AutoSize = True
            Me.rbProveedor.Location = New System.Drawing.Point(101, 17)
            Me.rbProveedor.Name = "rbProveedor"
            Me.rbProveedor.Size = New System.Drawing.Size(79, 17)
            Me.rbProveedor.TabIndex = 0
            Me.rbProveedor.Text = "PROVEEDOR"
            Me.rbProveedor.UseVisualStyleBackColor = True
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnReporte, Me.btnCancelarProveedorGeneral})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(1020, 24)
            Me.MenuStrip1.TabIndex = 191
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnBuscar
            '
            Me.btnBuscar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(79, 20)
            Me.btnBuscar.Text = "BUSCAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.report
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(82, 20)
            Me.btnReporte.Text = "REPORTE"
            '
            'btnCancelarProveedorGeneral
            '
            Me.btnCancelarProveedorGeneral.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarProveedorGeneral.Image = Global.syscisepro.My.Resources.Resources.excel_icon
            Me.btnCancelarProveedorGeneral.Name = "btnCancelarProveedorGeneral"
            Me.btnCancelarProveedorGeneral.Size = New System.Drawing.Size(88, 20)
            Me.btnCancelarProveedorGeneral.Text = "EXPORTAR"
            '
            'FormBuscarEvaluacionProveedor
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1020, 620)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvEvaluacionProveedor)
            Me.Controls.Add(Me.gbNombreComercialProveedor)
            Me.Controls.Add(Me.gbRangoFechas)
            Me.Controls.Add(Me.gbParametrosBusqueda)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormBuscarEvaluacionProveedor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "BUSCAR EVALUACION DE PROVEEDOR"
            CType(Me.dgvEvaluacionProveedor, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbNombreComercialProveedor.ResumeLayout(False)
            Me.gbNombreComercialProveedor.PerformLayout()
            Me.gbRangoFechas.ResumeLayout(False)
            Me.gbRangoFechas.PerformLayout()
            Me.gbParametrosBusqueda.ResumeLayout(False)
            Me.gbParametrosBusqueda.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvEvaluacionProveedor As System.Windows.Forms.DataGridView
        Friend WithEvents gbNombreComercialProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblIdProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
        Friend WithEvents lblIdEvaluacionProveedor As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
        Friend WithEvents gbParametrosBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents rbTodo As System.Windows.Forms.RadioButton
        Friend WithEvents rbServicios As System.Windows.Forms.RadioButton
        Friend WithEvents rbProductos As System.Windows.Forms.RadioButton
        Friend WithEvents rbProveedor As System.Windows.Forms.RadioButton
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarProveedorGeneral As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace