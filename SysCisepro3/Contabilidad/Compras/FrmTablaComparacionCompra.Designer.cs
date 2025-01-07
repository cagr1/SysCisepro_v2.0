namespace SysCisepro3.Contabilidad.Compras
{
    partial class FrmTablaComparacionCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lblIdProveedor = new Krypton.Toolkit.KryptonLabel();
            this.btnAgregar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.btnCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnGuardarTabla = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNuevaTabla = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.dgvIngresoTabla = new Krypton.Toolkit.KryptonDataGridView();
            this.id_secuencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFecha = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonPage3 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.btnExportar = new Krypton.Toolkit.KryptonButton();
            this.dgvDetalleTablaComparativa = new Krypton.Toolkit.KryptonDataGridView();
            this.dgvTablaComparativa = new Krypton.Toolkit.KryptonDataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).BeginInit();
            this.kryptonPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTablaComparativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaComparativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.RemovePageAndDispose;
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Button.ContextButtonAction = ComponentFactory.Krypton.Navigator.ContextButtonAction.SelectPage;
            this.kryptonNavigator1.Button.ContextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Button.ContextMenuMapImage = ComponentFactory.Krypton.Navigator.MapKryptonPageImage.Small;
            this.kryptonNavigator1.Button.ContextMenuMapText = ComponentFactory.Krypton.Navigator.MapKryptonPageText.TextTitle;
            this.kryptonNavigator1.Button.NextButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kryptonNavigator1.Button.NextButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Button.PreviousButtonAction = ComponentFactory.Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction;
            this.kryptonNavigator1.Button.PreviousButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Logic;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Group.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonNavigator1.Group.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlClient;
            this.kryptonNavigator1.Header.HeaderStyleBar = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonNavigator1.Header.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            this.kryptonNavigator1.Header.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarTabGroup;
            this.kryptonNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage3,
            this.kryptonPage2});
            this.kryptonNavigator1.Panel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(808, 450);
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(806, 423);
            this.kryptonPage1.Text = "Tabla";
            this.kryptonPage1.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "D4060D1C0D89425282AA47AD5C22FCF4";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(-1, 3);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblIdProveedor);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnAgregar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtProveedor);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnCancelar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnGuardarTabla);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnNuevaTabla);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtObservaciones);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dgvIngresoTabla);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtpFecha);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(807, 409);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Datos";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(502, 17);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(42, 20);
            this.kryptonLabel3.TabIndex = 14;
            this.kryptonLabel3.Values.Text = "Fecha";
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.Location = new System.Drawing.Point(670, 346);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(22, 20);
            this.lblIdProveedor.TabIndex = 13;
            this.lblIdProveedor.Values.Text = "ID";
            this.lblIdProveedor.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(454, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(32, 32);
            this.btnAgregar.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.btnAgregar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAgregar.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.btnAgregar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAgregar.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnAgregar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar Proveedor");
            this.btnAgregar.Values.ImageStates.ImageCheckedNormal = null;
            this.btnAgregar.Values.ImageStates.ImageCheckedPressed = null;
            this.btnAgregar.Values.ImageStates.ImageCheckedTracking = null;
            this.btnAgregar.Values.ImageStates.ImageDisabled = global::SysCisepro3.Properties.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_;
            this.btnAgregar.Values.ImageStates.ImageNormal = global::SysCisepro3.Properties.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_;
            this.btnAgregar.Values.ImageStates.ImagePressed = global::SysCisepro3.Properties.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnAgregar.Values.ImageStates.ImageTracking = global::SysCisepro3.Properties.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnAgregar.Values.Text = "";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 19);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(67, 20);
            this.kryptonLabel2.TabIndex = 11;
            this.kryptonLabel2.Values.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(98, 17);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(331, 21);
            this.txtProveedor.TabIndex = 10;
            this.txtProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProveedor_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(742, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(32, 32);
            this.btnCancelar.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.btnCancelar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCancelar.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.btnCancelar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancelar.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCancelar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseMnemonic = false;
            this.btnCancelar.Values.ImageStates.ImageCheckedNormal = null;
            this.btnCancelar.Values.ImageStates.ImageCheckedPressed = null;
            this.btnCancelar.Values.ImageStates.ImageCheckedTracking = null;
            this.btnCancelar.Values.ImageStates.ImageDisabled = global::SysCisepro3.Properties.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnCancelar.Values.ImageStates.ImageNormal = global::SysCisepro3.Properties.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnCancelar.Values.ImageStates.ImagePressed = global::SysCisepro3.Properties.Resources.cancel_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnCancelar.Values.ImageStates.ImageTracking = global::SysCisepro3.Properties.Resources.cancel_24dp_000000_FILL0_wght400_GRAD0_opsz24;
            this.btnCancelar.Values.Text = "";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarTabla
            // 
            this.btnGuardarTabla.Location = new System.Drawing.Point(704, 7);
            this.btnGuardarTabla.Name = "btnGuardarTabla";
            this.btnGuardarTabla.Size = new System.Drawing.Size(32, 32);
            this.btnGuardarTabla.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.btnGuardarTabla.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnGuardarTabla.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.btnGuardarTabla.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGuardarTabla.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnGuardarTabla.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnGuardarTabla, "Guardar Tabla");
            this.btnGuardarTabla.Values.ImageStates.ImageCheckedNormal = null;
            this.btnGuardarTabla.Values.ImageStates.ImageCheckedPressed = null;
            this.btnGuardarTabla.Values.ImageStates.ImageCheckedTracking = null;
            this.btnGuardarTabla.Values.ImageStates.ImageDisabled = global::SysCisepro3.Properties.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.btnGuardarTabla.Values.ImageStates.ImageNormal = global::SysCisepro3.Properties.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.btnGuardarTabla.Values.ImageStates.ImagePressed = global::SysCisepro3.Properties.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnGuardarTabla.Values.ImageStates.ImageTracking = global::SysCisepro3.Properties.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnGuardarTabla.Values.Text = "";
            this.btnGuardarTabla.Click += new System.EventHandler(this.btnGuardarTabla_Click);
            // 
            // btnNuevaTabla
            // 
            this.btnNuevaTabla.Location = new System.Drawing.Point(666, 7);
            this.btnNuevaTabla.Name = "btnNuevaTabla";
            this.btnNuevaTabla.Size = new System.Drawing.Size(32, 32);
            this.btnNuevaTabla.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.btnNuevaTabla.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnNuevaTabla.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.btnNuevaTabla.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNuevaTabla.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnNuevaTabla.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnNuevaTabla, "Nueva Tabla");
            this.btnNuevaTabla.Values.ImageStates.ImageCheckedNormal = null;
            this.btnNuevaTabla.Values.ImageStates.ImageCheckedPressed = null;
            this.btnNuevaTabla.Values.ImageStates.ImageCheckedTracking = null;
            this.btnNuevaTabla.Values.ImageStates.ImageDisabled = global::SysCisepro3.Properties.Resources.note_add_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnNuevaTabla.Values.ImageStates.ImageNormal = global::SysCisepro3.Properties.Resources.note_add_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnNuevaTabla.Values.ImageStates.ImagePressed = global::SysCisepro3.Properties.Resources.note_add_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.btnNuevaTabla.Values.ImageStates.ImageTracking = global::SysCisepro3.Properties.Resources.note_add_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.btnNuevaTabla.Values.Text = "";
            this.btnNuevaTabla.Click += new System.EventHandler(this.btnNuevaTabla_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(109, 346);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(398, 21);
            this.txtObservaciones.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 346);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Observaciones";
            this.kryptonLabel1.Click += new System.EventHandler(this.kryptonLabel1_Click);
            // 
            // dgvIngresoTabla
            // 
            this.dgvIngresoTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIngresoTabla.ColumnHeadersHeight = 24;
            this.dgvIngresoTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_secuencial,
            this.producto_servicio});
            this.dgvIngresoTabla.Enabled = false;
            this.dgvIngresoTabla.Location = new System.Drawing.Point(4, 59);
            this.dgvIngresoTabla.Name = "dgvIngresoTabla";
            this.dgvIngresoTabla.Size = new System.Drawing.Size(796, 258);
            this.dgvIngresoTabla.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvIngresoTabla.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvIngresoTabla.TabIndex = 1;
            this.dgvIngresoTabla.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngresoTabla_CellEndEdit);
            this.dgvIngresoTabla.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvIngresoTabla_EditingControlShowing);
            // 
            // id_secuencial
            // 
            this.id_secuencial.HeaderText = "Id";
            this.id_secuencial.Name = "id_secuencial";
            this.id_secuencial.ReadOnly = true;
            this.id_secuencial.Width = 40;
            // 
            // producto_servicio
            // 
            this.producto_servicio.HeaderText = "Producto/Servicio";
            this.producto_servicio.Name = "producto_servicio";
            this.producto_servicio.Width = 260;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(560, 18);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(88, 21);
            this.dtpFecha.TabIndex = 0;
            // 
            // kryptonPage3
            // 
            this.kryptonPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage3.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPage3.Flags = 65534;
            this.kryptonPage3.LastVisibleSet = true;
            this.kryptonPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage3.Name = "kryptonPage3";
            this.kryptonPage3.Size = new System.Drawing.Size(806, 423);
            this.kryptonPage3.StateCommon.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.kryptonPage3.StateCommon.Page.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPage3.Text = "Buscar";
            this.kryptonPage3.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.kryptonPage3.ToolTipTitle = "Page ToolTip";
            this.kryptonPage3.UniqueName = "52EB43BB56504659649444E3236E61E5";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(11, 16);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnExportar);
            this.kryptonGroupBox2.Panel.Controls.Add(this.dgvDetalleTablaComparativa);
            this.kryptonGroupBox2.Panel.Controls.Add(this.dgvTablaComparativa);
            this.kryptonGroupBox2.Panel.Controls.Add(this.txtBuscar);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(784, 396);
            this.kryptonGroupBox2.TabIndex = 0;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(307, 10);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(34, 34);
            this.btnExportar.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.btnExportar.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.btnExportar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Values.Image = global::SysCisepro3.Properties.Resources.pdf_;
            this.btnExportar.Values.Text = "";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvDetalleTablaComparativa
            // 
            this.dgvDetalleTablaComparativa.AllowUserToAddRows = false;
            this.dgvDetalleTablaComparativa.AllowUserToDeleteRows = false;
            this.dgvDetalleTablaComparativa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetalleTablaComparativa.ColumnHeadersHeight = 24;
            this.dgvDetalleTablaComparativa.Location = new System.Drawing.Point(5, 179);
            this.dgvDetalleTablaComparativa.Name = "dgvDetalleTablaComparativa";
            this.dgvDetalleTablaComparativa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleTablaComparativa.Size = new System.Drawing.Size(772, 208);
            this.dgvDetalleTablaComparativa.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvDetalleTablaComparativa.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvDetalleTablaComparativa.TabIndex = 3;
            // 
            // dgvTablaComparativa
            // 
            this.dgvTablaComparativa.AllowUserToAddRows = false;
            this.dgvTablaComparativa.AllowUserToDeleteRows = false;
            this.dgvTablaComparativa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTablaComparativa.ColumnHeadersHeight = 24;
            this.dgvTablaComparativa.Location = new System.Drawing.Point(5, 50);
            this.dgvTablaComparativa.Name = "dgvTablaComparativa";
            this.dgvTablaComparativa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaComparativa.Size = new System.Drawing.Size(772, 121);
            this.dgvTablaComparativa.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvTablaComparativa.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvTablaComparativa.TabIndex = 2;
            this.dgvTablaComparativa.SelectionChanged += new System.EventHandler(this.dgvTablaComparativa_SelectionChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(14, 22);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(220, 21);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.pdfViewer1);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(806, 423);
            this.kryptonPage2.Text = "Reporte";
            this.kryptonPage2.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "1E3B42D390BC4975BF83023BF932CB93";
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(2, 3);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(801, 438);
            this.pdfViewer1.TabIndex = 0;
            // 
            // FrmTablaComparacionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.kryptonNavigator1);
            this.Name = "FrmTablaComparacionCompra";
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 5F;
            this.Text = "Tabla Comparacion Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTablaComparacionCompra_FormClosing);
            this.Load += new System.EventHandler(this.FrmTablaComparacionCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).EndInit();
            this.kryptonPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTablaComparativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaComparativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFecha;
        private Krypton.Toolkit.KryptonDataGridView dgvIngresoTabla;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNuevaTabla;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGuardarTabla;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage3;
        private Krypton.Toolkit.KryptonLabel lblIdProveedor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAgregar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.TextBox txtProveedor;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private System.Windows.Forms.TextBox txtBuscar;
        private Krypton.Toolkit.KryptonDataGridView dgvDetalleTablaComparativa;
        private Krypton.Toolkit.KryptonDataGridView dgvTablaComparativa;
        private Krypton.Toolkit.KryptonButton btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_secuencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto_servicio;
        private PdfiumViewer.PdfViewer pdfViewer1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
    }
}