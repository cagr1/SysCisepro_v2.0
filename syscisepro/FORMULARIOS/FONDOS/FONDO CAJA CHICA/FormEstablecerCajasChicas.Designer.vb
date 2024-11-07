Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FormEstablecerCajasChicas
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstablecerCajasChicas))
            Me.lblNombres = New System.Windows.Forms.TextBox()
            Me.cbmParroquia = New System.Windows.Forms.ComboBox()
            Me.btnBuscarCustodio = New System.Windows.Forms.Button()
            Me.txtIdCustodio = New System.Windows.Forms.TextBox()
            Me.cbmCiudad = New System.Windows.Forms.ComboBox()
            Me.cbmProvincia = New System.Windows.Forms.ComboBox()
            Me.txtCuentaContable = New System.Windows.Forms.TextBox()
            Me.cbmNivelCuenta = New System.Windows.Forms.ComboBox()
            Me.cbmTipoCuenta = New System.Windows.Forms.ComboBox()
            Me.cbmCentroCosto = New System.Windows.Forms.ComboBox()
            Me.txtValorGasto = New System.Windows.Forms.TextBox()
            Me.txtMonto = New System.Windows.Forms.TextBox()
            Me.txtDetalle = New System.Windows.Forms.TextBox()
            Me.txtIdCajaChica = New System.Windows.Forms.TextBox()
            Me.dgvCajas = New System.Windows.Forms.DataGridView()
            Me.crvCajasChicasCustodios = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnNuevaCaja = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnGuardar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnReporte = New System.Windows.Forms.ToolStripMenuItem()
            Me.tcDatos = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
            Me.KryptonPage1 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonPage2 = New ComponentFactory.Krypton.Navigator.KryptonPage()
            Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
            Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
            CType(Me.dgvCajas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MenuStrip1.SuspendLayout()
            CType(Me.tcDatos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcDatos.SuspendLayout()
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage1.SuspendLayout()
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonPage2.SuspendLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.KryptonGroupBox1.Panel.SuspendLayout()
            Me.KryptonGroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lblNombres
            '
            Me.lblNombres.BackColor = System.Drawing.Color.White
            Me.lblNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.lblNombres.Enabled = False
            Me.lblNombres.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNombres.Location = New System.Drawing.Point(81, 48)
            Me.lblNombres.Name = "lblNombres"
            Me.lblNombres.Size = New System.Drawing.Size(178, 21)
            Me.lblNombres.TabIndex = 55
            '
            'cbmParroquia
            '
            Me.cbmParroquia.BackColor = System.Drawing.Color.White
            Me.cbmParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmParroquia.Enabled = False
            Me.cbmParroquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmParroquia.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmParroquia.FormattingEnabled = True
            Me.cbmParroquia.Location = New System.Drawing.Point(412, 112)
            Me.cbmParroquia.Name = "cbmParroquia"
            Me.cbmParroquia.Size = New System.Drawing.Size(125, 21)
            Me.cbmParroquia.TabIndex = 54
            '
            'btnBuscarCustodio
            '
            Me.btnBuscarCustodio.BackColor = System.Drawing.Color.Transparent
            Me.btnBuscarCustodio.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnBuscarCustodio.Enabled = False
            Me.btnBuscarCustodio.FlatAppearance.BorderSize = 0
            Me.btnBuscarCustodio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBuscarCustodio.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnBuscarCustodio.Location = New System.Drawing.Point(275, 3)
            Me.btnBuscarCustodio.Name = "btnBuscarCustodio"
            Me.btnBuscarCustodio.Size = New System.Drawing.Size(28, 28)
            Me.btnBuscarCustodio.TabIndex = 44
            Me.btnBuscarCustodio.UseVisualStyleBackColor = False
            '
            'txtIdCustodio
            '
            Me.txtIdCustodio.BackColor = System.Drawing.Color.White
            Me.txtIdCustodio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdCustodio.Enabled = False
            Me.txtIdCustodio.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdCustodio.Location = New System.Drawing.Point(191, 7)
            Me.txtIdCustodio.Name = "txtIdCustodio"
            Me.txtIdCustodio.Size = New System.Drawing.Size(68, 21)
            Me.txtIdCustodio.TabIndex = 50
            '
            'cbmCiudad
            '
            Me.cbmCiudad.BackColor = System.Drawing.Color.White
            Me.cbmCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCiudad.Enabled = False
            Me.cbmCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCiudad.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCiudad.FormattingEnabled = True
            Me.cbmCiudad.Location = New System.Drawing.Point(412, 80)
            Me.cbmCiudad.Name = "cbmCiudad"
            Me.cbmCiudad.Size = New System.Drawing.Size(125, 21)
            Me.cbmCiudad.TabIndex = 49
            '
            'cbmProvincia
            '
            Me.cbmProvincia.BackColor = System.Drawing.Color.White
            Me.cbmProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmProvincia.Enabled = False
            Me.cbmProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmProvincia.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmProvincia.FormattingEnabled = True
            Me.cbmProvincia.Location = New System.Drawing.Point(412, 47)
            Me.cbmProvincia.Name = "cbmProvincia"
            Me.cbmProvincia.Size = New System.Drawing.Size(125, 21)
            Me.cbmProvincia.TabIndex = 48
            '
            'txtCuentaContable
            '
            Me.txtCuentaContable.BackColor = System.Drawing.Color.White
            Me.txtCuentaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCuentaContable.Enabled = False
            Me.txtCuentaContable.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCuentaContable.Location = New System.Drawing.Point(612, 84)
            Me.txtCuentaContable.Name = "txtCuentaContable"
            Me.txtCuentaContable.Size = New System.Drawing.Size(81, 21)
            Me.txtCuentaContable.TabIndex = 46
            Me.txtCuentaContable.Text = "101010101"
            Me.txtCuentaContable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'cbmNivelCuenta
            '
            Me.cbmNivelCuenta.BackColor = System.Drawing.Color.White
            Me.cbmNivelCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmNivelCuenta.Enabled = False
            Me.cbmNivelCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmNivelCuenta.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmNivelCuenta.FormattingEnabled = True
            Me.cbmNivelCuenta.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
            Me.cbmNivelCuenta.Location = New System.Drawing.Point(612, 47)
            Me.cbmNivelCuenta.Name = "cbmNivelCuenta"
            Me.cbmNivelCuenta.Size = New System.Drawing.Size(81, 21)
            Me.cbmNivelCuenta.TabIndex = 45
            '
            'cbmTipoCuenta
            '
            Me.cbmTipoCuenta.BackColor = System.Drawing.Color.White
            Me.cbmTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmTipoCuenta.Enabled = False
            Me.cbmTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmTipoCuenta.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmTipoCuenta.FormattingEnabled = True
            Me.cbmTipoCuenta.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
            Me.cbmTipoCuenta.Location = New System.Drawing.Point(612, 8)
            Me.cbmTipoCuenta.Name = "cbmTipoCuenta"
            Me.cbmTipoCuenta.Size = New System.Drawing.Size(81, 21)
            Me.cbmTipoCuenta.TabIndex = 43
            '
            'cbmCentroCosto
            '
            Me.cbmCentroCosto.BackColor = System.Drawing.Color.White
            Me.cbmCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbmCentroCosto.Enabled = False
            Me.cbmCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbmCentroCosto.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbmCentroCosto.FormattingEnabled = True
            Me.cbmCentroCosto.Location = New System.Drawing.Point(412, 7)
            Me.cbmCentroCosto.Name = "cbmCentroCosto"
            Me.cbmCentroCosto.Size = New System.Drawing.Size(125, 21)
            Me.cbmCentroCosto.TabIndex = 47
            '
            'txtValorGasto
            '
            Me.txtValorGasto.BackColor = System.Drawing.Color.White
            Me.txtValorGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtValorGasto.Enabled = False
            Me.txtValorGasto.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtValorGasto.Location = New System.Drawing.Point(204, 112)
            Me.txtValorGasto.Name = "txtValorGasto"
            Me.txtValorGasto.Size = New System.Drawing.Size(55, 21)
            Me.txtValorGasto.TabIndex = 38
            '
            'txtMonto
            '
            Me.txtMonto.BackColor = System.Drawing.Color.White
            Me.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMonto.Enabled = False
            Me.txtMonto.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMonto.Location = New System.Drawing.Point(81, 111)
            Me.txtMonto.Name = "txtMonto"
            Me.txtMonto.Size = New System.Drawing.Size(55, 21)
            Me.txtMonto.TabIndex = 36
            '
            'txtDetalle
            '
            Me.txtDetalle.BackColor = System.Drawing.Color.White
            Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDetalle.Enabled = False
            Me.txtDetalle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalle.Location = New System.Drawing.Point(81, 80)
            Me.txtDetalle.Name = "txtDetalle"
            Me.txtDetalle.Size = New System.Drawing.Size(178, 21)
            Me.txtDetalle.TabIndex = 33
            '
            'txtIdCajaChica
            '
            Me.txtIdCajaChica.BackColor = System.Drawing.Color.White
            Me.txtIdCajaChica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtIdCajaChica.Enabled = False
            Me.txtIdCajaChica.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtIdCajaChica.Location = New System.Drawing.Point(33, 8)
            Me.txtIdCajaChica.Name = "txtIdCajaChica"
            Me.txtIdCajaChica.Size = New System.Drawing.Size(55, 21)
            Me.txtIdCajaChica.TabIndex = 32
            '
            'dgvCajas
            '
            Me.dgvCajas.AllowUserToAddRows = False
            Me.dgvCajas.AllowUserToDeleteRows = False
            Me.dgvCajas.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dgvCajas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvCajas.BackgroundColor = System.Drawing.Color.White
            Me.dgvCajas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
            Me.dgvCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(123, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvCajas.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvCajas.Location = New System.Drawing.Point(2, 154)
            Me.dgvCajas.MultiSelect = False
            Me.dgvCajas.Name = "dgvCajas"
            Me.dgvCajas.ReadOnly = True
            Me.dgvCajas.RowHeadersVisible = False
            Me.dgvCajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvCajas.Size = New System.Drawing.Size(761, 264)
            Me.dgvCajas.TabIndex = 14
            '
            'crvCajasChicasCustodios
            '
            Me.crvCajasChicasCustodios.ActiveViewIndex = -1
            Me.crvCajasChicasCustodios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.crvCajasChicasCustodios.Cursor = System.Windows.Forms.Cursors.Default
            Me.crvCajasChicasCustodios.Dock = System.Windows.Forms.DockStyle.Fill
            Me.crvCajasChicasCustodios.Location = New System.Drawing.Point(0, 0)
            Me.crvCajasChicasCustodios.Name = "crvCajasChicasCustodios"
            Me.crvCajasChicasCustodios.ShowLogo = False
            Me.crvCajasChicasCustodios.Size = New System.Drawing.Size(879, 450)
            Me.crvCajasChicasCustodios.TabIndex = 0
            Me.crvCajasChicasCustodios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.btnNuevaCaja, Me.btnGuardar, Me.btnModificar, Me.btnCancelar, Me.btnReporte})
            Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip1.Size = New System.Drawing.Size(765, 32)
            Me.MenuStrip1.TabIndex = 198
            Me.MenuStrip1.Text = "msIngresoBodega"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolStripMenuItem1.Image = Global.syscisepro.My.Resources.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(85, 28)
            Me.ToolStripMenuItem1.Text = "BUSCAR"
            '
            'btnNuevaCaja
            '
            Me.btnNuevaCaja.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevaCaja.Image = Global.syscisepro.My.Resources.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_
            Me.btnNuevaCaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnNuevaCaja.Name = "btnNuevaCaja"
            Me.btnNuevaCaja.Size = New System.Drawing.Size(78, 28)
            Me.btnNuevaCaja.Text = "NUEVO"
            '
            'btnGuardar
            '
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGuardar.Image = Global.syscisepro.My.Resources.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(92, 28)
            Me.btnGuardar.Text = "GUARDAR"
            '
            'btnModificar
            '
            Me.btnModificar.Enabled = False
            Me.btnModificar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.syscisepro.My.Resources.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(106, 28)
            Me.btnModificar.Text = "MODIFICAR"
            '
            'btnCancelar
            '
            Me.btnCancelar.Enabled = False
            Me.btnCancelar.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.syscisepro.My.Resources.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24
            Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(99, 28)
            Me.btnCancelar.Text = "CANCELAR"
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = Global.syscisepro.My.Resources.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_
            Me.btnReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(92, 28)
            Me.btnReporte.Text = "REPORTE"
            '
            'tcDatos
            '
            Me.tcDatos.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
            Me.tcDatos.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
            Me.tcDatos.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
            Me.tcDatos.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.SelectPage
            Me.tcDatos.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic
            Me.tcDatos.Button.ContextMenuMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.Small
            Me.tcDatos.Button.ContextMenuMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.TextTitle
            Me.tcDatos.Button.NextButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
            Me.tcDatos.Button.NextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic
            Me.tcDatos.Button.PreviousButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
            Me.tcDatos.Button.PreviousButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic
            Me.tcDatos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcDatos.Group.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient
            Me.tcDatos.Group.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlClient
            Me.tcDatos.Header.HeaderStyleBar = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
            Me.tcDatos.Header.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
            Me.tcDatos.Header.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
            Me.tcDatos.Location = New System.Drawing.Point(0, 32)
            Me.tcDatos.Name = "tcDatos"
            Me.tcDatos.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarTabGroup
            Me.tcDatos.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient
            Me.tcDatos.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.KryptonPage1, Me.KryptonPage2})
            Me.tcDatos.Panel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
            Me.tcDatos.SelectedIndex = 0
            Me.tcDatos.Size = New System.Drawing.Size(765, 447)
            Me.tcDatos.TabIndex = 199
            Me.tcDatos.Text = "KryptonNavigator1"
            '
            'KryptonPage1
            '
            Me.KryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage1.Controls.Add(Me.KryptonGroupBox1)
            Me.KryptonPage1.Controls.Add(Me.dgvCajas)
            Me.KryptonPage1.Flags = 65534
            Me.KryptonPage1.LastVisibleSet = True
            Me.KryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage1.Name = "KryptonPage1"
            Me.KryptonPage1.Size = New System.Drawing.Size(763, 420)
            Me.KryptonPage1.Text = "Datos"
            Me.KryptonPage1.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip
            Me.KryptonPage1.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage1.UniqueName = "17EEDA42A0174407678C24A1A2486B82"
            '
            'KryptonPage2
            '
            Me.KryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
            Me.KryptonPage2.Controls.Add(Me.crvCajasChicasCustodios)
            Me.KryptonPage2.Flags = 65534
            Me.KryptonPage2.LastVisibleSet = True
            Me.KryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
            Me.KryptonPage2.Name = "KryptonPage2"
            Me.KryptonPage2.Size = New System.Drawing.Size(879, 450)
            Me.KryptonPage2.Text = "Reporte"
            Me.KryptonPage2.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip
            Me.KryptonPage2.ToolTipTitle = "Page ToolTip"
            Me.KryptonPage2.UniqueName = "28364F020BAD4D2B7FB04B9630471402"
            '
            'KryptonGroupBox1
            '
            Me.KryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption
            Me.KryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox
            Me.KryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox
            Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 3)
            Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
            '
            'KryptonGroupBox1.Panel
            '
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel13)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel12)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel11)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel10)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtCuentaContable)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmNivelCuenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmParroquia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCiudad)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmProvincia)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.lblNombres)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdCajaChica)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtIdCustodio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.btnBuscarCustodio)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmCentroCosto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtValorGasto)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.cbmTipoCuenta)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDetalle)
            Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtMonto)
            Me.KryptonGroupBox1.Size = New System.Drawing.Size(763, 150)
            Me.KryptonGroupBox1.TabIndex = 0
            Me.KryptonGroupBox1.Values.Heading = ""
            '
            'KryptonLabel1
            '
            Me.KryptonLabel1.Location = New System.Drawing.Point(3, 8)
            Me.KryptonLabel1.Name = "KryptonLabel1"
            Me.KryptonLabel1.Size = New System.Drawing.Size(21, 20)
            Me.KryptonLabel1.TabIndex = 0
            Me.KryptonLabel1.Values.Text = "Id"
            '
            'KryptonLabel2
            '
            Me.KryptonLabel2.Location = New System.Drawing.Point(112, 8)
            Me.KryptonLabel2.Name = "KryptonLabel2"
            Me.KryptonLabel2.Size = New System.Drawing.Size(73, 20)
            Me.KryptonLabel2.TabIndex = 33
            Me.KryptonLabel2.Values.Text = "Id Custodio"
            '
            'KryptonLabel3
            '
            Me.KryptonLabel3.Location = New System.Drawing.Point(324, 8)
            Me.KryptonLabel3.Name = "KryptonLabel3"
            Me.KryptonLabel3.Size = New System.Drawing.Size(82, 20)
            Me.KryptonLabel3.TabIndex = 51
            Me.KryptonLabel3.Values.Text = "Centro Costo"
            '
            'KryptonLabel4
            '
            Me.KryptonLabel4.Location = New System.Drawing.Point(554, 7)
            Me.KryptonLabel4.Name = "KryptonLabel4"
            Me.KryptonLabel4.Size = New System.Drawing.Size(34, 20)
            Me.KryptonLabel4.TabIndex = 52
            Me.KryptonLabel4.Values.Text = "Tipo"
            '
            'KryptonLabel5
            '
            Me.KryptonLabel5.Location = New System.Drawing.Point(3, 48)
            Me.KryptonLabel5.Name = "KryptonLabel5"
            Me.KryptonLabel5.Size = New System.Drawing.Size(59, 20)
            Me.KryptonLabel5.TabIndex = 56
            Me.KryptonLabel5.Values.Text = "Custodio"
            '
            'KryptonLabel6
            '
            Me.KryptonLabel6.Location = New System.Drawing.Point(3, 84)
            Me.KryptonLabel6.Name = "KryptonLabel6"
            Me.KryptonLabel6.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel6.TabIndex = 57
            Me.KryptonLabel6.Values.Text = "Detalle"
            '
            'KryptonLabel7
            '
            Me.KryptonLabel7.Location = New System.Drawing.Point(3, 110)
            Me.KryptonLabel7.Name = "KryptonLabel7"
            Me.KryptonLabel7.Size = New System.Drawing.Size(47, 20)
            Me.KryptonLabel7.TabIndex = 58
            Me.KryptonLabel7.Values.Text = "Monto"
            '
            'KryptonLabel8
            '
            Me.KryptonLabel8.Location = New System.Drawing.Point(159, 110)
            Me.KryptonLabel8.Name = "KryptonLabel8"
            Me.KryptonLabel8.Size = New System.Drawing.Size(39, 20)
            Me.KryptonLabel8.TabIndex = 59
            Me.KryptonLabel8.Values.Text = "Valor"
            '
            'KryptonLabel9
            '
            Me.KryptonLabel9.Location = New System.Drawing.Point(324, 47)
            Me.KryptonLabel9.Name = "KryptonLabel9"
            Me.KryptonLabel9.Size = New System.Drawing.Size(60, 20)
            Me.KryptonLabel9.TabIndex = 60
            Me.KryptonLabel9.Values.Text = "Provincia"
            '
            'KryptonLabel10
            '
            Me.KryptonLabel10.Location = New System.Drawing.Point(324, 80)
            Me.KryptonLabel10.Name = "KryptonLabel10"
            Me.KryptonLabel10.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel10.TabIndex = 61
            Me.KryptonLabel10.Values.Text = "Ciudad"
            '
            'KryptonLabel11
            '
            Me.KryptonLabel11.Location = New System.Drawing.Point(324, 113)
            Me.KryptonLabel11.Name = "KryptonLabel11"
            Me.KryptonLabel11.Size = New System.Drawing.Size(63, 20)
            Me.KryptonLabel11.TabIndex = 62
            Me.KryptonLabel11.Values.Text = "Parroquia"
            '
            'KryptonLabel12
            '
            Me.KryptonLabel12.Location = New System.Drawing.Point(554, 49)
            Me.KryptonLabel12.Name = "KryptonLabel12"
            Me.KryptonLabel12.Size = New System.Drawing.Size(38, 20)
            Me.KryptonLabel12.TabIndex = 63
            Me.KryptonLabel12.Values.Text = "Nivel"
            '
            'KryptonLabel13
            '
            Me.KryptonLabel13.Location = New System.Drawing.Point(554, 87)
            Me.KryptonLabel13.Name = "KryptonLabel13"
            Me.KryptonLabel13.Size = New System.Drawing.Size(49, 20)
            Me.KryptonLabel13.TabIndex = 64
            Me.KryptonLabel13.Values.Text = "Cuenta"
            '
            'FormEstablecerCajasChicas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(765, 479)
            Me.Controls.Add(Me.tcDatos)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FormEstablecerCajasChicas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
            Me.StateActive.Border.Rounding = 5.0!
            Me.Text = "ESTABLECER CAJAS CHICAS"
            CType(Me.dgvCajas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            CType(Me.tcDatos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcDatos.ResumeLayout(False)
            CType(Me.KryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage1.ResumeLayout(False)
            CType(Me.KryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonPage2.ResumeLayout(False)
            CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.Panel.ResumeLayout(False)
            Me.KryptonGroupBox1.Panel.PerformLayout()
            CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.KryptonGroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents cbmParroquia As System.Windows.Forms.ComboBox
        Friend WithEvents btnBuscarCustodio As System.Windows.Forms.Button
        Friend WithEvents txtIdCustodio As System.Windows.Forms.TextBox
        Friend WithEvents cbmCiudad As System.Windows.Forms.ComboBox
        Friend WithEvents cbmProvincia As System.Windows.Forms.ComboBox
        Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
        Friend WithEvents cbmNivelCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents cbmTipoCuenta As System.Windows.Forms.ComboBox
        Friend WithEvents cbmCentroCosto As System.Windows.Forms.ComboBox
        Friend WithEvents txtValorGasto As System.Windows.Forms.TextBox
        Friend WithEvents txtMonto As System.Windows.Forms.TextBox
        Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
        Friend WithEvents txtIdCajaChica As System.Windows.Forms.TextBox
        Friend WithEvents dgvCajas As System.Windows.Forms.DataGridView
        Friend WithEvents crvCajasChicasCustodios As CrystalDecisions.Windows.Forms.CrystalReportViewer
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents btnNuevaCaja As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnReporte As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblNombres As System.Windows.Forms.TextBox
        Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents tcDatos As ComponentFactory.Krypton.Navigator.KryptonNavigator
        Friend WithEvents KryptonPage1 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
        Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonPage2 As ComponentFactory.Krypton.Navigator.KryptonPage
        Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
        Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    End Class
End Namespace