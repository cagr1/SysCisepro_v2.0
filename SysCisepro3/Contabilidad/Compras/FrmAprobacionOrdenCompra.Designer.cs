namespace SysCisepro3.Contabilidad.Compras
{
    partial class FrmAprobacionOrdenCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRecargar = new System.Windows.Forms.ToolStripButton();
            this.btnAprobarLiquidacion = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dgvOrdenCompra = new System.Windows.Forms.DataGridView();
            this.gbOrdenCompra = new System.Windows.Forms.GroupBox();
            this.txtTotalOrdenCompra = new System.Windows.Forms.TextBox();
            this.lblTotalORdenCompra = new System.Windows.Forms.Label();
            this.txtIvaOrdenCompra = new System.Windows.Forms.TextBox();
            this.lblIvaOrdenCompra = new System.Windows.Forms.Label();
            this.txtDescuentoOrdenCompra = new System.Windows.Forms.TextBox();
            this.lblDescuentoOrdenCompra = new System.Windows.Forms.Label();
            this.txtSubtotal0OrdenCompra = new System.Windows.Forms.TextBox();
            this.lblSubtotal0OrdenCompra = new System.Windows.Forms.Label();
            this.txtSubtotal12OrdenCompra = new System.Windows.Forms.TextBox();
            this.lblSubtotal12OrdenCompra = new System.Windows.Forms.Label();
            this.txtTipoPagoOrdenCompra = new System.Windows.Forms.TextBox();
            this.lblTipoPagoOrdenCompra = new System.Windows.Forms.Label();
            this.txtFormaPagoOrdenCompra = new System.Windows.Forms.TextBox();
            this.lblFormaPagoOrdenCompra = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.txtRucProveedor = new System.Windows.Forms.TextBox();
            this.lblRucProveedor = new System.Windows.Forms.Label();
            this.txtFechaOrdenCompra = new System.Windows.Forms.TextBox();
            this.txtIdOrdenCompra = new System.Windows.Forms.TextBox();
            this.lblFechaOrdenCompra = new System.Windows.Forms.Label();
            this.lblNroOrdenCompra = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDetalleOrdenCompra = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).BeginInit();
            this.gbOrdenCompra.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecargar,
            this.btnAprobarLiquidacion,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1020, 25);
            this.toolStrip1.TabIndex = 197;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRecargar
            // 
            this.btnRecargar.Image = global::SysCisepro3.Properties.Resources.BuscarRegistro;
            this.btnRecargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(116, 22);
            this.btnRecargar.Text = "RECARGAR ORD.";
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnAprobarLiquidacion
            // 
            this.btnAprobarLiquidacion.Enabled = false;
            this.btnAprobarLiquidacion.Image = global::SysCisepro3.Properties.Resources.ok;
            this.btnAprobarLiquidacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAprobarLiquidacion.Name = "btnAprobarLiquidacion";
            this.btnAprobarLiquidacion.Size = new System.Drawing.Size(110, 22);
            this.btnAprobarLiquidacion.Text = "APROBAR ORD.";
            this.btnAprobarLiquidacion.Click += new System.EventHandler(this.btnAprobarLiquidacion_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = global::SysCisepro3.Properties.Resources.cancel;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(117, 22);
            this.toolStripButton1.Text = "RECHAZAR ORD.";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dgvOrdenCompra
            // 
            this.dgvOrdenCompra.AllowUserToAddRows = false;
            this.dgvOrdenCompra.AllowUserToDeleteRows = false;
            this.dgvOrdenCompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvOrdenCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdenCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(60)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdenCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrdenCompra.Location = new System.Drawing.Point(4, 14);
            this.dgvOrdenCompra.MultiSelect = false;
            this.dgvOrdenCompra.Name = "dgvOrdenCompra";
            this.dgvOrdenCompra.ReadOnly = true;
            this.dgvOrdenCompra.RowHeadersVisible = false;
            this.dgvOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenCompra.Size = new System.Drawing.Size(1009, 105);
            this.dgvOrdenCompra.TabIndex = 198;
            this.dgvOrdenCompra.SelectionChanged += new System.EventHandler(this.dgvOrdenCompra_SelectionChanged);
            this.dgvOrdenCompra.Sorted += new System.EventHandler(this.dgvOrdenCompra_Sorted);
            // 
            // gbOrdenCompra
            // 
            this.gbOrdenCompra.BackColor = System.Drawing.Color.White;
            this.gbOrdenCompra.Controls.Add(this.txtTotalOrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.lblTotalORdenCompra);
            this.gbOrdenCompra.Controls.Add(this.txtIvaOrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.lblIvaOrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.txtDescuentoOrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.lblDescuentoOrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.txtSubtotal0OrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.lblSubtotal0OrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.txtSubtotal12OrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.lblSubtotal12OrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.txtTipoPagoOrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.lblTipoPagoOrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.txtFormaPagoOrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.lblFormaPagoOrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.txtNombreProveedor);
            this.gbOrdenCompra.Controls.Add(this.lblNombreProveedor);
            this.gbOrdenCompra.Controls.Add(this.txtRucProveedor);
            this.gbOrdenCompra.Controls.Add(this.lblRucProveedor);
            this.gbOrdenCompra.Controls.Add(this.txtFechaOrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.txtIdOrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.lblFechaOrdenCompra);
            this.gbOrdenCompra.Controls.Add(this.lblNroOrdenCompra);
            this.gbOrdenCompra.Location = new System.Drawing.Point(0, 156);
            this.gbOrdenCompra.Name = "gbOrdenCompra";
            this.gbOrdenCompra.Size = new System.Drawing.Size(1018, 96);
            this.gbOrdenCompra.TabIndex = 199;
            this.gbOrdenCompra.TabStop = false;
            this.gbOrdenCompra.Text = "DATOS ORDEN DE COMPRA";
            // 
            // txtTotalOrdenCompra
            // 
            this.txtTotalOrdenCompra.BackColor = System.Drawing.Color.White;
            this.txtTotalOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalOrdenCompra.Enabled = false;
            this.txtTotalOrdenCompra.Location = new System.Drawing.Point(946, 43);
            this.txtTotalOrdenCompra.Name = "txtTotalOrdenCompra";
            this.txtTotalOrdenCompra.Size = new System.Drawing.Size(64, 22);
            this.txtTotalOrdenCompra.TabIndex = 22;
            this.txtTotalOrdenCompra.Text = "0.00";
            this.txtTotalOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalOrdenCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubtotal12OrdenCompra_KeyPress);
            // 
            // lblTotalORdenCompra
            // 
            this.lblTotalORdenCompra.AutoSize = true;
            this.lblTotalORdenCompra.Location = new System.Drawing.Point(889, 47);
            this.lblTotalORdenCompra.Name = "lblTotalORdenCompra";
            this.lblTotalORdenCompra.Size = new System.Drawing.Size(41, 13);
            this.lblTotalORdenCompra.TabIndex = 21;
            this.lblTotalORdenCompra.Text = "TOTAL:";
            // 
            // txtIvaOrdenCompra
            // 
            this.txtIvaOrdenCompra.BackColor = System.Drawing.Color.White;
            this.txtIvaOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIvaOrdenCompra.Enabled = false;
            this.txtIvaOrdenCompra.Location = new System.Drawing.Point(946, 17);
            this.txtIvaOrdenCompra.Name = "txtIvaOrdenCompra";
            this.txtIvaOrdenCompra.Size = new System.Drawing.Size(64, 22);
            this.txtIvaOrdenCompra.TabIndex = 20;
            this.txtIvaOrdenCompra.Text = "0.00";
            this.txtIvaOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIvaOrdenCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubtotal12OrdenCompra_KeyPress);
            // 
            // lblIvaOrdenCompra
            // 
            this.lblIvaOrdenCompra.AutoSize = true;
            this.lblIvaOrdenCompra.Location = new System.Drawing.Point(889, 21);
            this.lblIvaOrdenCompra.Name = "lblIvaOrdenCompra";
            this.lblIvaOrdenCompra.Size = new System.Drawing.Size(56, 13);
            this.lblIvaOrdenCompra.TabIndex = 19;
            this.lblIvaOrdenCompra.Text = "IVA (12%):";
            // 
            // txtDescuentoOrdenCompra
            // 
            this.txtDescuentoOrdenCompra.BackColor = System.Drawing.Color.White;
            this.txtDescuentoOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescuentoOrdenCompra.Enabled = false;
            this.txtDescuentoOrdenCompra.Location = new System.Drawing.Point(783, 69);
            this.txtDescuentoOrdenCompra.Name = "txtDescuentoOrdenCompra";
            this.txtDescuentoOrdenCompra.Size = new System.Drawing.Size(64, 22);
            this.txtDescuentoOrdenCompra.TabIndex = 18;
            this.txtDescuentoOrdenCompra.Text = "0.00";
            this.txtDescuentoOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuentoOrdenCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubtotal12OrdenCompra_KeyPress);
            // 
            // lblDescuentoOrdenCompra
            // 
            this.lblDescuentoOrdenCompra.AutoSize = true;
            this.lblDescuentoOrdenCompra.Location = new System.Drawing.Point(704, 72);
            this.lblDescuentoOrdenCompra.Name = "lblDescuentoOrdenCompra";
            this.lblDescuentoOrdenCompra.Size = new System.Drawing.Size(73, 13);
            this.lblDescuentoOrdenCompra.TabIndex = 17;
            this.lblDescuentoOrdenCompra.Text = "DESCUENTO:";
            // 
            // txtSubtotal0OrdenCompra
            // 
            this.txtSubtotal0OrdenCompra.BackColor = System.Drawing.Color.White;
            this.txtSubtotal0OrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubtotal0OrdenCompra.Enabled = false;
            this.txtSubtotal0OrdenCompra.Location = new System.Drawing.Point(783, 43);
            this.txtSubtotal0OrdenCompra.Name = "txtSubtotal0OrdenCompra";
            this.txtSubtotal0OrdenCompra.Size = new System.Drawing.Size(64, 22);
            this.txtSubtotal0OrdenCompra.TabIndex = 16;
            this.txtSubtotal0OrdenCompra.Text = "0.00";
            this.txtSubtotal0OrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotal0OrdenCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubtotal12OrdenCompra_KeyPress);
            // 
            // lblSubtotal0OrdenCompra
            // 
            this.lblSubtotal0OrdenCompra.AutoSize = true;
            this.lblSubtotal0OrdenCompra.Location = new System.Drawing.Point(704, 46);
            this.lblSubtotal0OrdenCompra.Name = "lblSubtotal0OrdenCompra";
            this.lblSubtotal0OrdenCompra.Size = new System.Drawing.Size(70, 13);
            this.lblSubtotal0OrdenCompra.TabIndex = 15;
            this.lblSubtotal0OrdenCompra.Text = "SUBTOTAL 0:";
            // 
            // txtSubtotal12OrdenCompra
            // 
            this.txtSubtotal12OrdenCompra.BackColor = System.Drawing.Color.White;
            this.txtSubtotal12OrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubtotal12OrdenCompra.Enabled = false;
            this.txtSubtotal12OrdenCompra.Location = new System.Drawing.Point(783, 17);
            this.txtSubtotal12OrdenCompra.Name = "txtSubtotal12OrdenCompra";
            this.txtSubtotal12OrdenCompra.Size = new System.Drawing.Size(64, 22);
            this.txtSubtotal12OrdenCompra.TabIndex = 14;
            this.txtSubtotal12OrdenCompra.Text = "0.00";
            this.txtSubtotal12OrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotal12OrdenCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubtotal12OrdenCompra_KeyPress);
            // 
            // lblSubtotal12OrdenCompra
            // 
            this.lblSubtotal12OrdenCompra.AutoSize = true;
            this.lblSubtotal12OrdenCompra.Location = new System.Drawing.Point(704, 20);
            this.lblSubtotal12OrdenCompra.Name = "lblSubtotal12OrdenCompra";
            this.lblSubtotal12OrdenCompra.Size = new System.Drawing.Size(76, 13);
            this.lblSubtotal12OrdenCompra.TabIndex = 13;
            this.lblSubtotal12OrdenCompra.Text = "SUBTOTAL 12:";
            // 
            // txtTipoPagoOrdenCompra
            // 
            this.txtTipoPagoOrdenCompra.BackColor = System.Drawing.Color.White;
            this.txtTipoPagoOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoPagoOrdenCompra.Enabled = false;
            this.txtTipoPagoOrdenCompra.Location = new System.Drawing.Point(433, 69);
            this.txtTipoPagoOrdenCompra.Name = "txtTipoPagoOrdenCompra";
            this.txtTipoPagoOrdenCompra.Size = new System.Drawing.Size(151, 22);
            this.txtTipoPagoOrdenCompra.TabIndex = 12;
            // 
            // lblTipoPagoOrdenCompra
            // 
            this.lblTipoPagoOrdenCompra.AutoSize = true;
            this.lblTipoPagoOrdenCompra.Location = new System.Drawing.Point(368, 72);
            this.lblTipoPagoOrdenCompra.Name = "lblTipoPagoOrdenCompra";
            this.lblTipoPagoOrdenCompra.Size = new System.Drawing.Size(66, 13);
            this.lblTipoPagoOrdenCompra.TabIndex = 11;
            this.lblTipoPagoOrdenCompra.Text = "TIPO PAGO:";
            // 
            // txtFormaPagoOrdenCompra
            // 
            this.txtFormaPagoOrdenCompra.BackColor = System.Drawing.Color.White;
            this.txtFormaPagoOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPagoOrdenCompra.Enabled = false;
            this.txtFormaPagoOrdenCompra.Location = new System.Drawing.Point(95, 69);
            this.txtFormaPagoOrdenCompra.Name = "txtFormaPagoOrdenCompra";
            this.txtFormaPagoOrdenCompra.Size = new System.Drawing.Size(151, 22);
            this.txtFormaPagoOrdenCompra.TabIndex = 10;
            // 
            // lblFormaPagoOrdenCompra
            // 
            this.lblFormaPagoOrdenCompra.AutoSize = true;
            this.lblFormaPagoOrdenCompra.Location = new System.Drawing.Point(12, 72);
            this.lblFormaPagoOrdenCompra.Name = "lblFormaPagoOrdenCompra";
            this.lblFormaPagoOrdenCompra.Size = new System.Drawing.Size(81, 13);
            this.lblFormaPagoOrdenCompra.TabIndex = 9;
            this.lblFormaPagoOrdenCompra.Text = "FORMA PAGO:";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.BackColor = System.Drawing.Color.White;
            this.txtNombreProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreProveedor.Enabled = false;
            this.txtNombreProveedor.Location = new System.Drawing.Point(95, 43);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(489, 22);
            this.txtNombreProveedor.TabIndex = 8;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(12, 46);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(75, 13);
            this.lblNombreProveedor.TabIndex = 7;
            this.lblNombreProveedor.Text = "PROVEEDOR:";
            // 
            // txtRucProveedor
            // 
            this.txtRucProveedor.BackColor = System.Drawing.Color.White;
            this.txtRucProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRucProveedor.Enabled = false;
            this.txtRucProveedor.Location = new System.Drawing.Point(478, 17);
            this.txtRucProveedor.Name = "txtRucProveedor";
            this.txtRucProveedor.Size = new System.Drawing.Size(106, 22);
            this.txtRucProveedor.TabIndex = 6;
            // 
            // lblRucProveedor
            // 
            this.lblRucProveedor.AutoSize = true;
            this.lblRucProveedor.Location = new System.Drawing.Point(447, 20);
            this.lblRucProveedor.Name = "lblRucProveedor";
            this.lblRucProveedor.Size = new System.Drawing.Size(32, 13);
            this.lblRucProveedor.TabIndex = 5;
            this.lblRucProveedor.Text = "RUC:";
            // 
            // txtFechaOrdenCompra
            // 
            this.txtFechaOrdenCompra.BackColor = System.Drawing.Color.White;
            this.txtFechaOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFechaOrdenCompra.Enabled = false;
            this.txtFechaOrdenCompra.Location = new System.Drawing.Point(218, 17);
            this.txtFechaOrdenCompra.Name = "txtFechaOrdenCompra";
            this.txtFechaOrdenCompra.Size = new System.Drawing.Size(114, 22);
            this.txtFechaOrdenCompra.TabIndex = 4;
            // 
            // txtIdOrdenCompra
            // 
            this.txtIdOrdenCompra.BackColor = System.Drawing.Color.White;
            this.txtIdOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdOrdenCompra.Enabled = false;
            this.txtIdOrdenCompra.Location = new System.Drawing.Point(95, 17);
            this.txtIdOrdenCompra.Name = "txtIdOrdenCompra";
            this.txtIdOrdenCompra.Size = new System.Drawing.Size(51, 22);
            this.txtIdOrdenCompra.TabIndex = 3;
            // 
            // lblFechaOrdenCompra
            // 
            this.lblFechaOrdenCompra.AutoSize = true;
            this.lblFechaOrdenCompra.Location = new System.Drawing.Point(176, 20);
            this.lblFechaOrdenCompra.Name = "lblFechaOrdenCompra";
            this.lblFechaOrdenCompra.Size = new System.Drawing.Size(44, 13);
            this.lblFechaOrdenCompra.TabIndex = 2;
            this.lblFechaOrdenCompra.Text = "FECHA:";
            // 
            // lblNroOrdenCompra
            // 
            this.lblNroOrdenCompra.AutoSize = true;
            this.lblNroOrdenCompra.Location = new System.Drawing.Point(12, 20);
            this.lblNroOrdenCompra.Name = "lblNroOrdenCompra";
            this.lblNroOrdenCompra.Size = new System.Drawing.Size(21, 13);
            this.lblNroOrdenCompra.TabIndex = 1;
            this.lblNroOrdenCompra.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dgvOrdenCompra);
            this.groupBox2.Location = new System.Drawing.Point(2, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 125);
            this.groupBox2.TabIndex = 201;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÓRDENES DE COMPRA PENDIENTES";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvDetalleOrdenCompra);
            this.groupBox1.Location = new System.Drawing.Point(2, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 225);
            this.groupBox1.TabIndex = 202;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALLES DE LA ÓRDEN DE COMPRA";
            // 
            // dgvDetalleOrdenCompra
            // 
            this.dgvDetalleOrdenCompra.AllowUserToAddRows = false;
            this.dgvDetalleOrdenCompra.AllowUserToDeleteRows = false;
            this.dgvDetalleOrdenCompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDetalleOrdenCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleOrdenCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(60)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleOrdenCompra.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleOrdenCompra.Location = new System.Drawing.Point(4, 14);
            this.dgvDetalleOrdenCompra.MultiSelect = false;
            this.dgvDetalleOrdenCompra.Name = "dgvDetalleOrdenCompra";
            this.dgvDetalleOrdenCompra.ReadOnly = true;
            this.dgvDetalleOrdenCompra.RowHeadersVisible = false;
            this.dgvDetalleOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleOrdenCompra.Size = new System.Drawing.Size(1009, 205);
            this.dgvDetalleOrdenCompra.TabIndex = 198;
            this.dgvDetalleOrdenCompra.Sorted += new System.EventHandler(this.dgvDetalleOrdenCompra_Sorted);
            // 
            // FrmAprobacionOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbOrdenCompra);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAprobacionOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APROBACIÓN DE ORDEN DE COMPRA";
            this.Load += new System.EventHandler(this.FrmAprobacionOrdenCompra_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).EndInit();
            this.gbOrdenCompra.ResumeLayout(false);
            this.gbOrdenCompra.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrdenCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRecargar;
        private System.Windows.Forms.ToolStripButton btnAprobarLiquidacion;
        internal System.Windows.Forms.DataGridView dgvOrdenCompra;
        internal System.Windows.Forms.GroupBox gbOrdenCompra;
        internal System.Windows.Forms.TextBox txtTotalOrdenCompra;
        internal System.Windows.Forms.Label lblTotalORdenCompra;
        internal System.Windows.Forms.TextBox txtIvaOrdenCompra;
        internal System.Windows.Forms.Label lblIvaOrdenCompra;
        internal System.Windows.Forms.TextBox txtDescuentoOrdenCompra;
        internal System.Windows.Forms.Label lblDescuentoOrdenCompra;
        internal System.Windows.Forms.TextBox txtSubtotal0OrdenCompra;
        internal System.Windows.Forms.Label lblSubtotal0OrdenCompra;
        internal System.Windows.Forms.TextBox txtSubtotal12OrdenCompra;
        internal System.Windows.Forms.Label lblSubtotal12OrdenCompra;
        internal System.Windows.Forms.TextBox txtTipoPagoOrdenCompra;
        internal System.Windows.Forms.Label lblTipoPagoOrdenCompra;
        internal System.Windows.Forms.TextBox txtFormaPagoOrdenCompra;
        internal System.Windows.Forms.Label lblFormaPagoOrdenCompra;
        internal System.Windows.Forms.TextBox txtNombreProveedor;
        internal System.Windows.Forms.Label lblNombreProveedor;
        internal System.Windows.Forms.TextBox txtRucProveedor;
        internal System.Windows.Forms.Label lblRucProveedor;
        internal System.Windows.Forms.TextBox txtFechaOrdenCompra;
        internal System.Windows.Forms.TextBox txtIdOrdenCompra;
        internal System.Windows.Forms.Label lblFechaOrdenCompra;
        internal System.Windows.Forms.Label lblNroOrdenCompra;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgvDetalleOrdenCompra;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}