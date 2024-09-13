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
            this.btnCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnGuardarTabla = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNuevaTabla = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.dgvIngresoTabla = new Krypton.Toolkit.KryptonDataGridView();
            this.id_secuencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFecha = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonPage3 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage3,
            this.kryptonPage2});
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
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "D4060D1C0D89425282AA47AD5C22FCF4";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(-1, 3);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnCancelar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnGuardarTabla);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnNuevaTabla);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtObservaciones);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dgvIngresoTabla);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtpFecha);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(807, 280);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Datos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(708, 17);
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
            // 
            // btnGuardarTabla
            // 
            this.btnGuardarTabla.Location = new System.Drawing.Point(670, 17);
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
            this.btnNuevaTabla.Location = new System.Drawing.Point(632, 17);
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
            this.btnNuevaTabla.Values.ImageStates.ImageDisabled = global::SysCisepro3.Properties.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_;
            this.btnNuevaTabla.Values.ImageStates.ImageNormal = global::SysCisepro3.Properties.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_;
            this.btnNuevaTabla.Values.ImageStates.ImagePressed = global::SysCisepro3.Properties.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnNuevaTabla.Values.ImageStates.ImageTracking = global::SysCisepro3.Properties.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnNuevaTabla.Values.Text = "";
            this.btnNuevaTabla.Click += new System.EventHandler(this.btnNuevaTabla_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(109, 30);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(398, 21);
            this.txtObservaciones.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 30);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Observaciones";
            // 
            // dgvIngresoTabla
            // 
            this.dgvIngresoTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIngresoTabla.ColumnHeadersHeight = 24;
            this.dgvIngresoTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_secuencial,
            this.producto_servicio,
            this.id_proveedor,
            this.proveedor,
            this.precio,
            this.credito,
            this.dias});
            this.dgvIngresoTabla.Enabled = false;
            this.dgvIngresoTabla.Location = new System.Drawing.Point(4, 57);
            this.dgvIngresoTabla.Name = "dgvIngresoTabla";
            this.dgvIngresoTabla.Size = new System.Drawing.Size(790, 190);
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
            // id_proveedor
            // 
            this.id_proveedor.HeaderText = "Id";
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.ReadOnly = true;
            this.id_proveedor.Width = 40;
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            this.proveedor.Width = 260;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.Width = 50;
            // 
            // credito
            // 
            this.credito.HeaderText = "Credito";
            this.credito.Name = "credito";
            this.credito.Width = 50;
            // 
            // dias
            // 
            this.dias.HeaderText = "Dias";
            this.dias.Name = "dias";
            this.dias.Width = 50;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(521, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(88, 21);
            this.dtpFecha.TabIndex = 0;
            // 
            // kryptonPage3
            // 
            this.kryptonPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage3.Flags = 65534;
            this.kryptonPage3.LastVisibleSet = true;
            this.kryptonPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage3.Name = "kryptonPage3";
            this.kryptonPage3.Size = new System.Drawing.Size(806, 423);
            this.kryptonPage3.Text = "Buscar";
            this.kryptonPage3.ToolTipTitle = "Page ToolTip";
            this.kryptonPage3.UniqueName = "52EB43BB56504659649444E3236E61E5";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(806, 423);
            this.kryptonPage2.Text = "Reporte";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "1E3B42D390BC4975BF83023BF932CB93";
            // 
            // FrmTablaComparacionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.kryptonNavigator1);
            this.Name = "FrmTablaComparacionCompra";
            this.ShowIcon = false;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 5F;
            this.Text = "FrmTablaComparacionCompra";
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id_secuencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias;
        private System.Windows.Forms.TextBox txtObservaciones;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNuevaTabla;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGuardarTabla;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage3;
    }
}