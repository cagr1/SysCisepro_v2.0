Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormAgregarContactoProveedorCalificado
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAgregarContactoProveedorCalificado))
            Me.gbProveedor = New System.Windows.Forms.GroupBox()
            Me.btnBuscarProveedorCalificado = New System.Windows.Forms.Button()
            Me.lblIdProveedor = New System.Windows.Forms.Label()
            Me.txtIdProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblRucCiProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtRucCiProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.lblRazonSocialProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtRazonSocial = New System.Windows.Forms.TextBox()
            Me.lblNombreComercialProveedorGeneral = New System.Windows.Forms.Label()
            Me.txtNombreComercialProveedorGeneral = New System.Windows.Forms.TextBox()
            Me.dgvContactosProveedorCalificado = New System.Windows.Forms.DataGridView()
            Me.idContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nombresContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.apellidosContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cargoContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.telefonoContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.celularContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.emailContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.estadoContactoProveedorCalificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.idProveedorGeneral = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.panelAgregarEliminar = New System.Windows.Forms.Panel()
            Me.lblEtiquetaContactosProveedor = New System.Windows.Forms.Label()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.btnNuevoProveedorCalificado = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardarProveedorCalificado = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelarProveedorCalificado = New System.Windows.Forms.ToolStripMenuItem()
            Me.gbProveedor.SuspendLayout()
            CType(Me.dgvContactosProveedorCalificado, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelAgregarEliminar.SuspendLayout()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbProveedor
            '
            Me.gbProveedor.BackColor = System.Drawing.Color.White
            Me.gbProveedor.Controls.Add(Me.btnBuscarProveedorCalificado)
            Me.gbProveedor.Controls.Add(Me.lblIdProveedor)
            Me.gbProveedor.Controls.Add(Me.txtIdProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblRucCiProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtRucCiProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.lblRazonSocialProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtRazonSocial)
            Me.gbProveedor.Controls.Add(Me.lblNombreComercialProveedorGeneral)
            Me.gbProveedor.Controls.Add(Me.txtNombreComercialProveedorGeneral)
            Me.gbProveedor.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbProveedor.Location = New System.Drawing.Point(3, 35)
            Me.gbProveedor.Name = "gbProveedor"
            Me.gbProveedor.Size = New System.Drawing.Size(699, 99)
            Me.gbProveedor.TabIndex = 29
            Me.gbProveedor.TabStop = False
            Me.gbProveedor.Text = "DATOS DEL PROVEEDOR"
            '
            'btnBuscarProveedorCalificado
            '
            Me.btnBuscarProveedorCalificado.BackColor = System.Drawing.Color.White
            Me.btnBuscarProveedorCalificado.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarProveedorCalificado.Location = New System.Drawing.Point(649, 14)
            Me.btnBuscarProveedorCalificado.Name = "btnBuscarProveedorCalificado"
            Me.btnBuscarProveedorCalificado.Size = New System.Drawing.Size(28, 28)
            Me.btnBuscarProveedorCalificado.TabIndex = 24
            Me.btnBuscarProveedorCalificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBuscarProveedorCalificado.UseVisualStyleBackColor = False
            '
            'lblIdProveedor
            '
            Me.lblIdProveedor.AutoSize = True
            Me.lblIdProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdProveedor.Location = New System.Drawing.Point(4, 20)
            Me.lblIdProveedor.Name = "lblIdProveedor"
            Me.lblIdProveedor.Size = New System.Drawing.Size(92, 13)
            Me.lblIdProveedor.TabIndex = 0
            Me.lblIdProveedor.Text = "ID PROVEEDOR:"
            '
            'txtIdProveedorGeneral
            '
            Me.txtIdProveedorGeneral.Enabled = False
            Me.txtIdProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdProveedorGeneral.Location = New System.Drawing.Point(132, 17)
            Me.txtIdProveedorGeneral.Name = "txtIdProveedorGeneral"
            Me.txtIdProveedorGeneral.Size = New System.Drawing.Size(99, 21)
            Me.txtIdProveedorGeneral.TabIndex = 1
            '
            'lblRucCiProveedorGeneral
            '
            Me.lblRucCiProveedorGeneral.AutoSize = True
            Me.lblRucCiProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRucCiProveedorGeneral.Location = New System.Drawing.Point(237, 20)
            Me.lblRucCiProveedorGeneral.Name = "lblRucCiProveedorGeneral"
            Me.lblRucCiProveedorGeneral.Size = New System.Drawing.Size(54, 13)
            Me.lblRucCiProveedorGeneral.TabIndex = 4
            Me.lblRucCiProveedorGeneral.Text = "RUC / CI:"
            '
            'txtRucCiProveedorGeneral
            '
            Me.txtRucCiProveedorGeneral.Enabled = False
            Me.txtRucCiProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRucCiProveedorGeneral.Location = New System.Drawing.Point(297, 17)
            Me.txtRucCiProveedorGeneral.Name = "txtRucCiProveedorGeneral"
            Me.txtRucCiProveedorGeneral.Size = New System.Drawing.Size(100, 21)
            Me.txtRucCiProveedorGeneral.TabIndex = 5
            '
            'lblRazonSocialProveedorGeneral
            '
            Me.lblRazonSocialProveedorGeneral.AutoSize = True
            Me.lblRazonSocialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRazonSocialProveedorGeneral.Location = New System.Drawing.Point(4, 46)
            Me.lblRazonSocialProveedorGeneral.Name = "lblRazonSocialProveedorGeneral"
            Me.lblRazonSocialProveedorGeneral.Size = New System.Drawing.Size(89, 13)
            Me.lblRazonSocialProveedorGeneral.TabIndex = 6
            Me.lblRazonSocialProveedorGeneral.Text = "RAZON SOCIAL:"
            '
            'txtRazonSocial
            '
            Me.txtRazonSocial.Enabled = False
            Me.txtRazonSocial.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRazonSocial.Location = New System.Drawing.Point(132, 43)
            Me.txtRazonSocial.Name = "txtRazonSocial"
            Me.txtRazonSocial.Size = New System.Drawing.Size(562, 21)
            Me.txtRazonSocial.TabIndex = 7
            '
            'lblNombreComercialProveedorGeneral
            '
            Me.lblNombreComercialProveedorGeneral.AutoSize = True
            Me.lblNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombreComercialProveedorGeneral.Location = New System.Drawing.Point(4, 72)
            Me.lblNombreComercialProveedorGeneral.Name = "lblNombreComercialProveedorGeneral"
            Me.lblNombreComercialProveedorGeneral.Size = New System.Drawing.Size(122, 13)
            Me.lblNombreComercialProveedorGeneral.TabIndex = 8
            Me.lblNombreComercialProveedorGeneral.Text = "NOMBRE COMERCIAL:"
            '
            'txtNombreComercialProveedorGeneral
            '
            Me.txtNombreComercialProveedorGeneral.Enabled = False
            Me.txtNombreComercialProveedorGeneral.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreComercialProveedorGeneral.Location = New System.Drawing.Point(132, 69)
            Me.txtNombreComercialProveedorGeneral.Name = "txtNombreComercialProveedorGeneral"
            Me.txtNombreComercialProveedorGeneral.Size = New System.Drawing.Size(562, 21)
            Me.txtNombreComercialProveedorGeneral.TabIndex = 9
            '
            'dgvContactosProveedorCalificado
            '
            Me.dgvContactosProveedorCalificado.AllowUserToAddRows = False
            Me.dgvContactosProveedorCalificado.AllowUserToDeleteRows = False
            Me.dgvContactosProveedorCalificado.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvContactosProveedorCalificado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvContactosProveedorCalificado.BackgroundColor = System.Drawing.Color.White
            Me.dgvContactosProveedorCalificado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvContactosProveedorCalificado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idContactoProveedorCalificado, Me.nombresContactoProveedorCalificado, Me.apellidosContactoProveedorCalificado, Me.cargoContactoProveedorCalificado, Me.telefonoContactoProveedorCalificado, Me.celularContactoProveedorCalificado, Me.emailContactoProveedorCalificado, Me.estadoContactoProveedorCalificado, Me.idProveedorGeneral})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvContactosProveedorCalificado.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvContactosProveedorCalificado.Location = New System.Drawing.Point(3, 167)
            Me.dgvContactosProveedorCalificado.Name = "dgvContactosProveedorCalificado"
            Me.dgvContactosProveedorCalificado.ReadOnly = True
            Me.dgvContactosProveedorCalificado.RowHeadersVisible = False
            Me.dgvContactosProveedorCalificado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvContactosProveedorCalificado.Size = New System.Drawing.Size(699, 244)
            Me.dgvContactosProveedorCalificado.TabIndex = 33
            '
            'idContactoProveedorCalificado
            '
            Me.idContactoProveedorCalificado.HeaderText = "ID"
            Me.idContactoProveedorCalificado.Name = "idContactoProveedorCalificado"
            Me.idContactoProveedorCalificado.ReadOnly = True
            '
            'nombresContactoProveedorCalificado
            '
            Me.nombresContactoProveedorCalificado.HeaderText = "NOMBRES"
            Me.nombresContactoProveedorCalificado.Name = "nombresContactoProveedorCalificado"
            Me.nombresContactoProveedorCalificado.ReadOnly = True
            '
            'apellidosContactoProveedorCalificado
            '
            Me.apellidosContactoProveedorCalificado.HeaderText = "APELLIDOS"
            Me.apellidosContactoProveedorCalificado.Name = "apellidosContactoProveedorCalificado"
            Me.apellidosContactoProveedorCalificado.ReadOnly = True
            '
            'cargoContactoProveedorCalificado
            '
            Me.cargoContactoProveedorCalificado.HeaderText = "CARGO"
            Me.cargoContactoProveedorCalificado.Name = "cargoContactoProveedorCalificado"
            Me.cargoContactoProveedorCalificado.ReadOnly = True
            '
            'telefonoContactoProveedorCalificado
            '
            Me.telefonoContactoProveedorCalificado.HeaderText = "TELEFONO"
            Me.telefonoContactoProveedorCalificado.Name = "telefonoContactoProveedorCalificado"
            Me.telefonoContactoProveedorCalificado.ReadOnly = True
            '
            'celularContactoProveedorCalificado
            '
            Me.celularContactoProveedorCalificado.HeaderText = "CELULAR"
            Me.celularContactoProveedorCalificado.Name = "celularContactoProveedorCalificado"
            Me.celularContactoProveedorCalificado.ReadOnly = True
            '
            'emailContactoProveedorCalificado
            '
            Me.emailContactoProveedorCalificado.HeaderText = "E-MAIL"
            Me.emailContactoProveedorCalificado.Name = "emailContactoProveedorCalificado"
            Me.emailContactoProveedorCalificado.ReadOnly = True
            '
            'estadoContactoProveedorCalificado
            '
            Me.estadoContactoProveedorCalificado.HeaderText = "EST"
            Me.estadoContactoProveedorCalificado.Name = "estadoContactoProveedorCalificado"
            Me.estadoContactoProveedorCalificado.ReadOnly = True
            '
            'idProveedorGeneral
            '
            Me.idProveedorGeneral.HeaderText = "ID PG"
            Me.idProveedorGeneral.Name = "idProveedorGeneral"
            Me.idProveedorGeneral.ReadOnly = True
            '
            'panelAgregarEliminar
            '
            Me.panelAgregarEliminar.BackColor = System.Drawing.Color.White
            Me.panelAgregarEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panelAgregarEliminar.Controls.Add(Me.lblEtiquetaContactosProveedor)
            Me.panelAgregarEliminar.Controls.Add(Me.btnEliminar)
            Me.panelAgregarEliminar.Controls.Add(Me.btnAgregar)
            Me.panelAgregarEliminar.Location = New System.Drawing.Point(3, 134)
            Me.panelAgregarEliminar.Name = "panelAgregarEliminar"
            Me.panelAgregarEliminar.Size = New System.Drawing.Size(699, 32)
            Me.panelAgregarEliminar.TabIndex = 32
            '
            'lblEtiquetaContactosProveedor
            '
            Me.lblEtiquetaContactosProveedor.AutoSize = True
            Me.lblEtiquetaContactosProveedor.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiquetaContactosProveedor.Location = New System.Drawing.Point(253, 9)
            Me.lblEtiquetaContactosProveedor.Name = "lblEtiquetaContactosProveedor"
            Me.lblEtiquetaContactosProveedor.Size = New System.Drawing.Size(172, 14)
            Me.lblEtiquetaContactosProveedor.TabIndex = 2
            Me.lblEtiquetaContactosProveedor.Text = "CONTÁCTOS DEL PROVEEDOR"
            '
            'btnEliminar
            '
            Me.btnEliminar.BackColor = System.Drawing.Color.White
            Me.btnEliminar.FlatAppearance.BorderSize = 0
            Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminar.Image = Global.syscisepro.My.Resources.Resources.do_not_disturb_on_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnEliminar.Location = New System.Drawing.Point(661, 1)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(32, 28)
            Me.btnEliminar.TabIndex = 1
            Me.btnEliminar.UseVisualStyleBackColor = False
            '
            'btnAgregar
            '
            Me.btnAgregar.BackColor = System.Drawing.Color.White
            Me.btnAgregar.FlatAppearance.BorderSize = 0
            Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAgregar.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnAgregar.Location = New System.Drawing.Point(630, 1)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(28, 28)
            Me.btnAgregar.TabIndex = 0
            Me.btnAgregar.UseVisualStyleBackColor = False
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoProveedorCalificado, Me.btnGuardarProveedorCalificado, Me.btnCancelarProveedorCalificado})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(704, 32)
            Me.MenuStrip1.TabIndex = 190
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'btnNuevoProveedorCalificado
            '
            Me.btnNuevoProveedorCalificado.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevoProveedorCalificado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevoProveedorCalificado.Name = "btnNuevoProveedorCalificado"
            Me.btnNuevoProveedorCalificado.Size = New System.Drawing.Size(82, 28)
            Me.btnNuevoProveedorCalificado.Text = "NUEVO"
            '
            'btnGuardarProveedorCalificado
            '
            Me.btnGuardarProveedorCalificado.Enabled = False
            Me.btnGuardarProveedorCalificado.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardarProveedorCalificado.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardarProveedorCalificado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardarProveedorCalificado.Name = "btnGuardarProveedorCalificado"
            Me.btnGuardarProveedorCalificado.Size = New System.Drawing.Size(95, 28)
            Me.btnGuardarProveedorCalificado.Text = "GUARDAR"
            '
            'btnCancelarProveedorCalificado
            '
            Me.btnCancelarProveedorCalificado.Enabled = False
            Me.btnCancelarProveedorCalificado.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelarProveedorCalificado.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelarProveedorCalificado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelarProveedorCalificado.Name = "btnCancelarProveedorCalificado"
            Me.btnCancelarProveedorCalificado.Size = New System.Drawing.Size(97, 28)
            Me.btnCancelarProveedorCalificado.Text = "CANCELAR"
            '
            'FormAgregarContactoProveedorCalificado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(704, 413)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Controls.Add(Me.dgvContactosProveedorCalificado)
            Me.Controls.Add(Me.panelAgregarEliminar)
            Me.Controls.Add(Me.gbProveedor)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormAgregarContactoProveedorCalificado"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "AGREGAR CONTÁCTOS PROVEEDOR CALIFICADO"
            Me.gbProveedor.ResumeLayout(False)
            Me.gbProveedor.PerformLayout()
            CType(Me.dgvContactosProveedorCalificado, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelAgregarEliminar.ResumeLayout(False)
            Me.panelAgregarEliminar.PerformLayout()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents gbProveedor As System.Windows.Forms.GroupBox
        Friend WithEvents btnBuscarProveedorCalificado As System.Windows.Forms.Button
        Friend WithEvents lblIdProveedor As System.Windows.Forms.Label
        Friend WithEvents txtIdProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblRucCiProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtRucCiProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents lblRazonSocialProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
        Friend WithEvents lblNombreComercialProveedorGeneral As System.Windows.Forms.Label
        Friend WithEvents txtNombreComercialProveedorGeneral As System.Windows.Forms.TextBox
        Friend WithEvents dgvContactosProveedorCalificado As System.Windows.Forms.DataGridView
        Friend WithEvents idContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents nombresContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents apellidosContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cargoContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents telefonoContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents celularContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents emailContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents estadoContactoProveedorCalificado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents idProveedorGeneral As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents panelAgregarEliminar As System.Windows.Forms.Panel
        Friend WithEvents lblEtiquetaContactosProveedor As System.Windows.Forms.Label
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevoProveedorCalificado As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardarProveedorCalificado As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelarProveedorCalificado As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace