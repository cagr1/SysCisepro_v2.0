Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.REQUERIMIENTOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAprovacionRequisicion
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAprovacionRequisicion))
            Me.dgvRequisicionProductoServicio = New System.Windows.Forms.DataGridView()
            Me.gbRequisicion = New System.Windows.Forms.GroupBox()
            Me.txtPrioridadEntregaRequisicion = New System.Windows.Forms.TextBox()
            Me.lblEstadoRequisicionProductoServicio = New System.Windows.Forms.Label()
            Me.txtIdRequisicionProductoServicio = New System.Windows.Forms.TextBox()
            Me.txtTiempoEntregaRequisicion = New System.Windows.Forms.TextBox()
            Me.txtFechaRequisicionProducto = New System.Windows.Forms.TextBox()
            Me.lblEtiquetaNumeroRequisicion = New System.Windows.Forms.Label()
            Me.lblEntregaRequerimientoProductoServicio = New System.Windows.Forms.Label()
            Me.lblFechaRequisicionProductoServicio = New System.Windows.Forms.Label()
            Me.txtNombrePersonal = New System.Windows.Forms.TextBox()
            Me.lblRealizadoPor = New System.Windows.Forms.Label()
            Me.dgvDetalleRequisicionProductoServicio = New System.Windows.Forms.DataGridView()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnRecargar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAprovar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnRechazar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.dgvRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbRequisicion.SuspendLayout()
            CType(Me.dgvDetalleRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgvRequisicionProductoServicio
            '
            Me.dgvRequisicionProductoServicio.AllowUserToAddRows = False
            Me.dgvRequisicionProductoServicio.AllowUserToDeleteRows = False
            Me.dgvRequisicionProductoServicio.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvRequisicionProductoServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvRequisicionProductoServicio.BackgroundColor = System.Drawing.Color.White
            Me.dgvRequisicionProductoServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvRequisicionProductoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvRequisicionProductoServicio.Location = New System.Drawing.Point(2, 32)
            Me.dgvRequisicionProductoServicio.Name = "dgvRequisicionProductoServicio"
            Me.dgvRequisicionProductoServicio.RowHeadersVisible = False
            Me.dgvRequisicionProductoServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRequisicionProductoServicio.Size = New System.Drawing.Size(539, 150)
            Me.dgvRequisicionProductoServicio.TabIndex = 0
            '
            'gbRequisicion
            '
            Me.gbRequisicion.BackColor = System.Drawing.Color.White
            Me.gbRequisicion.Controls.Add(Me.txtPrioridadEntregaRequisicion)
            Me.gbRequisicion.Controls.Add(Me.lblEstadoRequisicionProductoServicio)
            Me.gbRequisicion.Controls.Add(Me.txtIdRequisicionProductoServicio)
            Me.gbRequisicion.Controls.Add(Me.txtTiempoEntregaRequisicion)
            Me.gbRequisicion.Controls.Add(Me.txtFechaRequisicionProducto)
            Me.gbRequisicion.Controls.Add(Me.lblEtiquetaNumeroRequisicion)
            Me.gbRequisicion.Controls.Add(Me.lblEntregaRequerimientoProductoServicio)
            Me.gbRequisicion.Controls.Add(Me.lblFechaRequisicionProductoServicio)
            Me.gbRequisicion.Controls.Add(Me.txtNombrePersonal)
            Me.gbRequisicion.Controls.Add(Me.lblRealizadoPor)
            Me.gbRequisicion.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbRequisicion.Location = New System.Drawing.Point(541, 32)
            Me.gbRequisicion.Name = "gbRequisicion"
            Me.gbRequisicion.Size = New System.Drawing.Size(439, 150)
            Me.gbRequisicion.TabIndex = 1
            Me.gbRequisicion.TabStop = False
            Me.gbRequisicion.Text = "DATOS REQUISICIÓN"
            '
            'txtPrioridadEntregaRequisicion
            '
            Me.txtPrioridadEntregaRequisicion.BackColor = System.Drawing.Color.White
            Me.txtPrioridadEntregaRequisicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrioridadEntregaRequisicion.Enabled = False
            Me.txtPrioridadEntregaRequisicion.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrioridadEntregaRequisicion.Location = New System.Drawing.Point(106, 111)
            Me.txtPrioridadEntregaRequisicion.Name = "txtPrioridadEntregaRequisicion"
            Me.txtPrioridadEntregaRequisicion.Size = New System.Drawing.Size(148, 22)
            Me.txtPrioridadEntregaRequisicion.TabIndex = 25
            '
            'lblEstadoRequisicionProductoServicio
            '
            Me.lblEstadoRequisicionProductoServicio.AutoSize = True
            Me.lblEstadoRequisicionProductoServicio.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstadoRequisicionProductoServicio.Location = New System.Drawing.Point(4, 114)
            Me.lblEstadoRequisicionProductoServicio.Name = "lblEstadoRequisicionProductoServicio"
            Me.lblEstadoRequisicionProductoServicio.Size = New System.Drawing.Size(70, 14)
            Me.lblEstadoRequisicionProductoServicio.TabIndex = 24
            Me.lblEstadoRequisicionProductoServicio.Text = "PRIORIDAD:"
            '
            'txtIdRequisicionProductoServicio
            '
            Me.txtIdRequisicionProductoServicio.BackColor = System.Drawing.Color.White
            Me.txtIdRequisicionProductoServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdRequisicionProductoServicio.Enabled = False
            Me.txtIdRequisicionProductoServicio.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdRequisicionProductoServicio.Location = New System.Drawing.Point(106, 27)
            Me.txtIdRequisicionProductoServicio.Name = "txtIdRequisicionProductoServicio"
            Me.txtIdRequisicionProductoServicio.Size = New System.Drawing.Size(69, 22)
            Me.txtIdRequisicionProductoServicio.TabIndex = 23
            '
            'txtTiempoEntregaRequisicion
            '
            Me.txtTiempoEntregaRequisicion.BackColor = System.Drawing.Color.White
            Me.txtTiempoEntregaRequisicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTiempoEntregaRequisicion.Enabled = False
            Me.txtTiempoEntregaRequisicion.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTiempoEntregaRequisicion.Location = New System.Drawing.Point(328, 111)
            Me.txtTiempoEntregaRequisicion.Name = "txtTiempoEntregaRequisicion"
            Me.txtTiempoEntregaRequisicion.Size = New System.Drawing.Size(106, 22)
            Me.txtTiempoEntregaRequisicion.TabIndex = 20
            '
            'txtFechaRequisicionProducto
            '
            Me.txtFechaRequisicionProducto.BackColor = System.Drawing.Color.White
            Me.txtFechaRequisicionProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaRequisicionProducto.Enabled = False
            Me.txtFechaRequisicionProducto.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaRequisicionProducto.Location = New System.Drawing.Point(106, 55)
            Me.txtFechaRequisicionProducto.Name = "txtFechaRequisicionProducto"
            Me.txtFechaRequisicionProducto.Size = New System.Drawing.Size(148, 22)
            Me.txtFechaRequisicionProducto.TabIndex = 15
            '
            'lblEtiquetaNumeroRequisicion
            '
            Me.lblEtiquetaNumeroRequisicion.AutoSize = True
            Me.lblEtiquetaNumeroRequisicion.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiquetaNumeroRequisicion.Location = New System.Drawing.Point(4, 30)
            Me.lblEtiquetaNumeroRequisicion.Name = "lblEtiquetaNumeroRequisicion"
            Me.lblEtiquetaNumeroRequisicion.Size = New System.Drawing.Size(87, 14)
            Me.lblEtiquetaNumeroRequisicion.TabIndex = 22
            Me.lblEtiquetaNumeroRequisicion.Text = "REQ. NÚMERO:"
            '
            'lblEntregaRequerimientoProductoServicio
            '
            Me.lblEntregaRequerimientoProductoServicio.AutoSize = True
            Me.lblEntregaRequerimientoProductoServicio.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEntregaRequerimientoProductoServicio.Location = New System.Drawing.Point(260, 114)
            Me.lblEntregaRequerimientoProductoServicio.Name = "lblEntregaRequerimientoProductoServicio"
            Me.lblEntregaRequerimientoProductoServicio.Size = New System.Drawing.Size(63, 14)
            Me.lblEntregaRequerimientoProductoServicio.TabIndex = 18
            Me.lblEntregaRequerimientoProductoServicio.Text = "ENTREGA:"
            '
            'lblFechaRequisicionProductoServicio
            '
            Me.lblFechaRequisicionProductoServicio.AutoSize = True
            Me.lblFechaRequisicionProductoServicio.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaRequisicionProductoServicio.Location = New System.Drawing.Point(4, 58)
            Me.lblFechaRequisicionProductoServicio.Name = "lblFechaRequisicionProductoServicio"
            Me.lblFechaRequisicionProductoServicio.Size = New System.Drawing.Size(49, 14)
            Me.lblFechaRequisicionProductoServicio.TabIndex = 14
            Me.lblFechaRequisicionProductoServicio.Text = "FECHA:"
            '
            'txtNombrePersonal
            '
            Me.txtNombrePersonal.BackColor = System.Drawing.Color.White
            Me.txtNombrePersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombrePersonal.Enabled = False
            Me.txtNombrePersonal.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombrePersonal.Location = New System.Drawing.Point(106, 83)
            Me.txtNombrePersonal.Name = "txtNombrePersonal"
            Me.txtNombrePersonal.Size = New System.Drawing.Size(328, 22)
            Me.txtNombrePersonal.TabIndex = 17
            '
            'lblRealizadoPor
            '
            Me.lblRealizadoPor.AutoSize = True
            Me.lblRealizadoPor.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRealizadoPor.Location = New System.Drawing.Point(4, 86)
            Me.lblRealizadoPor.Name = "lblRealizadoPor"
            Me.lblRealizadoPor.Size = New System.Drawing.Size(98, 14)
            Me.lblRealizadoPor.TabIndex = 16
            Me.lblRealizadoPor.Text = "REALIZADO POR:"
            '
            'dgvDetalleRequisicionProductoServicio
            '
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToAddRows = False
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToDeleteRows = False
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToOrderColumns = True
            Me.dgvDetalleRequisicionProductoServicio.AllowUserToResizeRows = False
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleRequisicionProductoServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvDetalleRequisicionProductoServicio.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleRequisicionProductoServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDetalleRequisicionProductoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleRequisicionProductoServicio.Location = New System.Drawing.Point(2, 185)
            Me.dgvDetalleRequisicionProductoServicio.Name = "dgvDetalleRequisicionProductoServicio"
            Me.dgvDetalleRequisicionProductoServicio.RowHeadersVisible = False
            Me.dgvDetalleRequisicionProductoServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleRequisicionProductoServicio.Size = New System.Drawing.Size(978, 369)
            Me.dgvDetalleRequisicionProductoServicio.TabIndex = 2
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRecargar, Me.btnAprovar, Me.btnRechazar, Me.btnModificar, Me.btnGuardar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.MenuStrip1.Size = New System.Drawing.Size(982, 24)
            Me.MenuStrip1.TabIndex = 184
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnRecargar
            '
            Me.btnRecargar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRecargar.Image = Global.syscisepro.My.Resources.Resources.BuscarRegistro
            Me.btnRecargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnRecargar.Name = "btnRecargar"
            Me.btnRecargar.Size = New System.Drawing.Size(126, 20)
            Me.btnRecargar.Text = "RECARGAR REQ."
            '
            'btnAprovar
            '
            Me.btnAprovar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAprovar.Image = Global.syscisepro.My.Resources.Resources.ok
            Me.btnAprovar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnAprovar.Name = "btnAprovar"
            Me.btnAprovar.Size = New System.Drawing.Size(84, 20)
            Me.btnAprovar.Text = "APROBAR"
            '
            'btnRechazar
            '
            Me.btnRechazar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRechazar.Image = Global.syscisepro.My.Resources.Resources.remove
            Me.btnRechazar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnRechazar.Name = "btnRechazar"
            Me.btnRechazar.Size = New System.Drawing.Size(90, 20)
            Me.btnRechazar.Text = "RECHAZAR"
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.ModificarRegistro
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(95, 20)
            Me.btnModificar.Text = "MODIFICAR"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(87, 20)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(89, 20)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'FormAprovacionRequisicion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(982, 557)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvDetalleRequisicionProductoServicio)
            Me.Controls.Add(Me.gbRequisicion)
            Me.Controls.Add(Me.dgvRequisicionProductoServicio)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAprovacionRequisicion"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "APROBACIÓN DE REQUISICIÓN DE PRODUCTO/SERVICIO"
            CType(Me.dgvRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbRequisicion.ResumeLayout(False)
            Me.gbRequisicion.PerformLayout()
            CType(Me.dgvDetalleRequisicionProductoServicio, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgvRequisicionProductoServicio As System.Windows.Forms.DataGridView
        Friend WithEvents gbRequisicion As System.Windows.Forms.GroupBox
        Friend WithEvents txtIdRequisicionProductoServicio As System.Windows.Forms.TextBox
        Friend WithEvents txtTiempoEntregaRequisicion As System.Windows.Forms.TextBox
        Friend WithEvents txtFechaRequisicionProducto As System.Windows.Forms.TextBox
        Friend WithEvents lblEtiquetaNumeroRequisicion As System.Windows.Forms.Label
        Friend WithEvents lblEntregaRequerimientoProductoServicio As System.Windows.Forms.Label
        Friend WithEvents lblFechaRequisicionProductoServicio As System.Windows.Forms.Label
        Friend WithEvents txtNombrePersonal As System.Windows.Forms.TextBox
        Friend WithEvents lblRealizadoPor As System.Windows.Forms.Label
        Friend WithEvents dgvDetalleRequisicionProductoServicio As System.Windows.Forms.DataGridView
        Friend WithEvents txtPrioridadEntregaRequisicion As System.Windows.Forms.TextBox
        Friend WithEvents lblEstadoRequisicionProductoServicio As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnAprovar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnRechazar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnRecargar As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace