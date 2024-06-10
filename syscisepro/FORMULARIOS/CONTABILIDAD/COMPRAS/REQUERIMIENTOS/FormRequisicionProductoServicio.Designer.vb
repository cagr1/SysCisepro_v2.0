Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.REQUERIMIENTOS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormRequisicionProductoServicio
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRequisicionProductoServicio))
            Me.gbCabecera = New System.Windows.Forms.GroupBox()
            Me.txtIdRequisicionProductoServicio = New System.Windows.Forms.TextBox()
            Me.btnBuscarPersonal = New System.Windows.Forms.Button()
            Me.txtEntregaNumeroDias = New System.Windows.Forms.TextBox()
            Me.rbEntregaNormal = New System.Windows.Forms.RadioButton()
            Me.rbEntregaUrgente = New System.Windows.Forms.RadioButton()
            Me.txtNombrePersonal = New System.Windows.Forms.TextBox()
            Me.txtFechaRequisicionProducto = New System.Windows.Forms.TextBox()
            Me.lblIdPersonal = New System.Windows.Forms.Label()
            Me.lblFechaRequisicionProductoServicio = New System.Windows.Forms.Label()
            Me.lblEtiquetaNumeroRequisicion = New System.Windows.Forms.Label()
            Me.lblRealizadoPor = New System.Windows.Forms.Label()
            Me.lblPlazoEntrega = New System.Windows.Forms.Label()
            Me.lblDias = New System.Windows.Forms.Label()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.dgvDetalleRequisicionPS = New System.Windows.Forms.DataGridView()
            Me.idItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nombreProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.unidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cantidadProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.especificacionProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.observacionesProductoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.panelDetalle = New System.Windows.Forms.Panel()
            Me.lblDetalleSolicitud = New System.Windows.Forms.Label()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevo = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbCabecera.SuspendLayout()
            CType(Me.dgvDetalleRequisicionPS, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelDetalle.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbCabecera
            '
            Me.gbCabecera.BackColor = System.Drawing.Color.White
            Me.gbCabecera.Controls.Add(Me.txtIdRequisicionProductoServicio)
            Me.gbCabecera.Controls.Add(Me.btnBuscarPersonal)
            Me.gbCabecera.Controls.Add(Me.txtEntregaNumeroDias)
            Me.gbCabecera.Controls.Add(Me.rbEntregaNormal)
            Me.gbCabecera.Controls.Add(Me.rbEntregaUrgente)
            Me.gbCabecera.Controls.Add(Me.txtNombrePersonal)
            Me.gbCabecera.Controls.Add(Me.txtFechaRequisicionProducto)
            Me.gbCabecera.Controls.Add(Me.lblIdPersonal)
            Me.gbCabecera.Controls.Add(Me.lblFechaRequisicionProductoServicio)
            Me.gbCabecera.Controls.Add(Me.lblEtiquetaNumeroRequisicion)
            Me.gbCabecera.Controls.Add(Me.lblRealizadoPor)
            Me.gbCabecera.Controls.Add(Me.lblPlazoEntrega)
            Me.gbCabecera.Controls.Add(Me.lblDias)
            Me.gbCabecera.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbCabecera.Location = New System.Drawing.Point(2, 26)
            Me.gbCabecera.Name = "gbCabecera"
            Me.gbCabecera.Size = New System.Drawing.Size(761, 80)
            Me.gbCabecera.TabIndex = 0
            Me.gbCabecera.TabStop = False
            '
            'txtIdRequisicionProductoServicio
            '
            Me.txtIdRequisicionProductoServicio.BackColor = System.Drawing.Color.White
            Me.txtIdRequisicionProductoServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdRequisicionProductoServicio.Location = New System.Drawing.Point(28, 13)
            Me.txtIdRequisicionProductoServicio.Name = "txtIdRequisicionProductoServicio"
            Me.txtIdRequisicionProductoServicio.Size = New System.Drawing.Size(42, 21)
            Me.txtIdRequisicionProductoServicio.TabIndex = 13
            '
            'btnBuscarPersonal
            '
            Me.btnBuscarPersonal.BackColor = System.Drawing.Color.White
            Me.btnBuscarPersonal.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarPersonal.Location = New System.Drawing.Point(730, 10)
            Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
            Me.btnBuscarPersonal.Size = New System.Drawing.Size(26, 26)
            Me.btnBuscarPersonal.TabIndex = 4
            Me.btnBuscarPersonal.TextAlign = System.Drawing.ContentAlignment.TopLeft
            Me.btnBuscarPersonal.UseVisualStyleBackColor = False
            '
            'txtEntregaNumeroDias
            '
            Me.txtEntregaNumeroDias.BackColor = System.Drawing.Color.White
            Me.txtEntregaNumeroDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtEntregaNumeroDias.Location = New System.Drawing.Point(424, 49)
            Me.txtEntregaNumeroDias.Name = "txtEntregaNumeroDias"
            Me.txtEntregaNumeroDias.Size = New System.Drawing.Size(32, 21)
            Me.txtEntregaNumeroDias.TabIndex = 10
            '
            'rbEntregaNormal
            '
            Me.rbEntregaNormal.AutoSize = True
            Me.rbEntregaNormal.Checked = True
            Me.rbEntregaNormal.Location = New System.Drawing.Point(190, 50)
            Me.rbEntregaNormal.Name = "rbEntregaNormal"
            Me.rbEntregaNormal.Size = New System.Drawing.Size(123, 17)
            Me.rbEntregaNormal.TabIndex = 8
            Me.rbEntregaNormal.TabStop = True
            Me.rbEntregaNormal.Text = "ENTREGA NORMAL"
            Me.rbEntregaNormal.UseVisualStyleBackColor = True
            '
            'rbEntregaUrgente
            '
            Me.rbEntregaUrgente.AutoSize = True
            Me.rbEntregaUrgente.Location = New System.Drawing.Point(28, 50)
            Me.rbEntregaUrgente.Name = "rbEntregaUrgente"
            Me.rbEntregaUrgente.Size = New System.Drawing.Size(126, 17)
            Me.rbEntregaUrgente.TabIndex = 7
            Me.rbEntregaUrgente.Text = "ENTREGA URGENTE"
            Me.rbEntregaUrgente.UseVisualStyleBackColor = True
            '
            'txtNombrePersonal
            '
            Me.txtNombrePersonal.BackColor = System.Drawing.Color.White
            Me.txtNombrePersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombrePersonal.Location = New System.Drawing.Point(365, 13)
            Me.txtNombrePersonal.Name = "txtNombrePersonal"
            Me.txtNombrePersonal.Size = New System.Drawing.Size(359, 21)
            Me.txtNombrePersonal.TabIndex = 3
            '
            'txtFechaRequisicionProducto
            '
            Me.txtFechaRequisicionProducto.BackColor = System.Drawing.Color.White
            Me.txtFechaRequisicionProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtFechaRequisicionProducto.Location = New System.Drawing.Point(134, 13)
            Me.txtFechaRequisicionProducto.Name = "txtFechaRequisicionProducto"
            Me.txtFechaRequisicionProducto.Size = New System.Drawing.Size(118, 21)
            Me.txtFechaRequisicionProducto.TabIndex = 1
            '
            'lblIdPersonal
            '
            Me.lblIdPersonal.AutoSize = True
            Me.lblIdPersonal.Location = New System.Drawing.Point(662, 16)
            Me.lblIdPersonal.Name = "lblIdPersonal"
            Me.lblIdPersonal.Size = New System.Drawing.Size(19, 13)
            Me.lblIdPersonal.TabIndex = 5
            Me.lblIdPersonal.Text = "00"
            '
            'lblFechaRequisicionProductoServicio
            '
            Me.lblFechaRequisicionProductoServicio.AutoSize = True
            Me.lblFechaRequisicionProductoServicio.Location = New System.Drawing.Point(91, 16)
            Me.lblFechaRequisicionProductoServicio.Name = "lblFechaRequisicionProductoServicio"
            Me.lblFechaRequisicionProductoServicio.Size = New System.Drawing.Size(44, 13)
            Me.lblFechaRequisicionProductoServicio.TabIndex = 0
            Me.lblFechaRequisicionProductoServicio.Text = "FECHA:"
            '
            'lblEtiquetaNumeroRequisicion
            '
            Me.lblEtiquetaNumeroRequisicion.AutoSize = True
            Me.lblEtiquetaNumeroRequisicion.Location = New System.Drawing.Point(7, 16)
            Me.lblEtiquetaNumeroRequisicion.Name = "lblEtiquetaNumeroRequisicion"
            Me.lblEtiquetaNumeroRequisicion.Size = New System.Drawing.Size(22, 13)
            Me.lblEtiquetaNumeroRequisicion.TabIndex = 12
            Me.lblEtiquetaNumeroRequisicion.Text = "N°:"
            '
            'lblRealizadoPor
            '
            Me.lblRealizadoPor.AutoSize = True
            Me.lblRealizadoPor.Location = New System.Drawing.Point(270, 16)
            Me.lblRealizadoPor.Name = "lblRealizadoPor"
            Me.lblRealizadoPor.Size = New System.Drawing.Size(93, 13)
            Me.lblRealizadoPor.TabIndex = 2
            Me.lblRealizadoPor.Text = "REALIZADO POR:"
            '
            'lblPlazoEntrega
            '
            Me.lblPlazoEntrega.AutoSize = True
            Me.lblPlazoEntrega.Location = New System.Drawing.Point(362, 52)
            Me.lblPlazoEntrega.Name = "lblPlazoEntrega"
            Me.lblPlazoEntrega.Size = New System.Drawing.Size(63, 13)
            Me.lblPlazoEntrega.TabIndex = 9
            Me.lblPlazoEntrega.Text = "PLAZO      ["
            '
            'lblDias
            '
            Me.lblDias.AutoSize = True
            Me.lblDias.Location = New System.Drawing.Point(456, 52)
            Me.lblDias.Name = "lblDias"
            Me.lblDias.Size = New System.Drawing.Size(35, 13)
            Me.lblDias.TabIndex = 11
            Me.lblDias.Text = "] Días"
            '
            'btnEliminar
            '
            Me.btnEliminar.BackColor = System.Drawing.Color.White
            Me.btnEliminar.FlatAppearance.BorderSize = 0
            Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminar.Location = New System.Drawing.Point(729, 0)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(27, 27)
            Me.btnEliminar.TabIndex = 3
            Me.btnEliminar.UseVisualStyleBackColor = False
            '
            'dgvDetalleRequisicionPS
            '
            Me.dgvDetalleRequisicionPS.AllowUserToDeleteRows = False
            Me.dgvDetalleRequisicionPS.AllowUserToOrderColumns = True
            Me.dgvDetalleRequisicionPS.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvDetalleRequisicionPS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvDetalleRequisicionPS.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalleRequisicionPS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvDetalleRequisicionPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalleRequisicionPS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idItem, Me.nombreProductoServicio, Me.unidadMedida, Me.cantidadProductoServicio, Me.especificacionProductoServicio, Me.observacionesProductoServicio})
            Me.dgvDetalleRequisicionPS.Location = New System.Drawing.Point(2, 138)
            Me.dgvDetalleRequisicionPS.Name = "dgvDetalleRequisicionPS"
            Me.dgvDetalleRequisicionPS.RowHeadersVisible = False
            Me.dgvDetalleRequisicionPS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalleRequisicionPS.Size = New System.Drawing.Size(761, 364)
            Me.dgvDetalleRequisicionPS.TabIndex = 3
            '
            'idItem
            '
            Me.idItem.HeaderText = "ID"
            Me.idItem.Name = "idItem"
            Me.idItem.ReadOnly = True
            Me.idItem.Width = 35
            '
            'nombreProductoServicio
            '
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.nombreProductoServicio.DefaultCellStyle = DataGridViewCellStyle2
            Me.nombreProductoServicio.HeaderText = "PRODUCTO/SERVICIO"
            Me.nombreProductoServicio.Name = "nombreProductoServicio"
            Me.nombreProductoServicio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.nombreProductoServicio.Width = 220
            '
            'unidadMedida
            '
            Me.unidadMedida.HeaderText = "UM"
            Me.unidadMedida.Name = "unidadMedida"
            Me.unidadMedida.ReadOnly = True
            Me.unidadMedida.Width = 40
            '
            'cantidadProductoServicio
            '
            Me.cantidadProductoServicio.HeaderText = "CANT."
            Me.cantidadProductoServicio.Name = "cantidadProductoServicio"
            Me.cantidadProductoServicio.Width = 40
            '
            'especificacionProductoServicio
            '
            Me.especificacionProductoServicio.HeaderText = "ESPECIFICACION"
            Me.especificacionProductoServicio.Name = "especificacionProductoServicio"
            Me.especificacionProductoServicio.Width = 200
            '
            'observacionesProductoServicio
            '
            Me.observacionesProductoServicio.HeaderText = "OBSERVACIONES"
            Me.observacionesProductoServicio.Name = "observacionesProductoServicio"
            Me.observacionesProductoServicio.Width = 220
            '
            'panelDetalle
            '
            Me.panelDetalle.Controls.Add(Me.lblDetalleSolicitud)
            Me.panelDetalle.Controls.Add(Me.btnEliminar)
            Me.panelDetalle.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panelDetalle.Location = New System.Drawing.Point(2, 108)
            Me.panelDetalle.Name = "panelDetalle"
            Me.panelDetalle.Size = New System.Drawing.Size(761, 26)
            Me.panelDetalle.TabIndex = 37
            '
            'lblDetalleSolicitud
            '
            Me.lblDetalleSolicitud.AutoSize = True
            Me.lblDetalleSolicitud.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDetalleSolicitud.Location = New System.Drawing.Point(267, 5)
            Me.lblDetalleSolicitud.Name = "lblDetalleSolicitud"
            Me.lblDetalleSolicitud.Size = New System.Drawing.Size(192, 18)
            Me.lblDetalleSolicitud.TabIndex = 17
            Me.lblDetalleSolicitud.Text = "DETALLE ORDEN DE COMPRA"
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(765, 32)
            Me.MenuStrip1.TabIndex = 187
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(82, 28)
            Me.btnNuevo.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(97, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(103, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'FormRequisicionProductoServicio
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(765, 503)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.panelDetalle)
            Me.Controls.Add(Me.dgvDetalleRequisicionPS)
            Me.Controls.Add(Me.gbCabecera)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormRequisicionProductoServicio"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "REQUISICIÓN DE PRODUCTO / SERVICIO"
            Me.gbCabecera.ResumeLayout(False)
            Me.gbCabecera.PerformLayout()
            CType(Me.dgvDetalleRequisicionPS, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelDetalle.ResumeLayout(False)
            Me.panelDetalle.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents lblDias As System.Windows.Forms.Label
        Friend WithEvents txtEntregaNumeroDias As System.Windows.Forms.TextBox
        Friend WithEvents lblPlazoEntrega As System.Windows.Forms.Label
        Friend WithEvents rbEntregaNormal As System.Windows.Forms.RadioButton
        Friend WithEvents rbEntregaUrgente As System.Windows.Forms.RadioButton
        Friend WithEvents lblIdPersonal As System.Windows.Forms.Label
        Friend WithEvents btnBuscarPersonal As System.Windows.Forms.Button
        Friend WithEvents txtNombrePersonal As System.Windows.Forms.TextBox
        Friend WithEvents lblRealizadoPor As System.Windows.Forms.Label
        Friend WithEvents txtFechaRequisicionProducto As System.Windows.Forms.TextBox
        Friend WithEvents lblFechaRequisicionProductoServicio As System.Windows.Forms.Label
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents dgvDetalleRequisicionPS As System.Windows.Forms.DataGridView
        Friend WithEvents lblEtiquetaNumeroRequisicion As System.Windows.Forms.Label
        Friend WithEvents txtIdRequisicionProductoServicio As System.Windows.Forms.TextBox
        Friend WithEvents panelDetalle As System.Windows.Forms.Panel
        Friend WithEvents lblDetalleSolicitud As System.Windows.Forms.Label
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents idItem As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents nombreProductoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents unidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cantidadProductoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents especificacionProductoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents observacionesProductoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace