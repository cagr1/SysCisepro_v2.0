namespace SysCisepro3.Operaciones
{
    partial class FrmArmas
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
            this.KryptonGroupBox5 = new Krypton.Toolkit.KryptonGroupBox();
            this.btnExportarPresupuesto = new Krypton.Toolkit.KryptonButton();
            this.KryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            this.KryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            this.dtpFechaDesde = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpFechaHasta = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvArmas = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KryptonGroupBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KryptonGroupBox5.Panel)).BeginInit();
            this.KryptonGroupBox5.Panel.SuspendLayout();
            this.KryptonGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmas)).BeginInit();
            this.SuspendLayout();
            // 
            // KryptonGroupBox5
            // 
            this.KryptonGroupBox5.CaptionOverlap = 0D;
            this.KryptonGroupBox5.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.KryptonGroupBox5.Location = new System.Drawing.Point(9, 14);
            this.KryptonGroupBox5.Name = "KryptonGroupBox5";
            // 
            // KryptonGroupBox5.Panel
            // 
            this.KryptonGroupBox5.Panel.Controls.Add(this.txtBuscar);
            this.KryptonGroupBox5.Panel.Controls.Add(this.btnExportarPresupuesto);
            this.KryptonGroupBox5.Panel.Controls.Add(this.KryptonLabel12);
            this.KryptonGroupBox5.Panel.Controls.Add(this.KryptonLabel13);
            this.KryptonGroupBox5.Panel.Controls.Add(this.dtpFechaDesde);
            this.KryptonGroupBox5.Panel.Controls.Add(this.dtpFechaHasta);
            this.KryptonGroupBox5.Size = new System.Drawing.Size(778, 69);
            this.KryptonGroupBox5.TabIndex = 232;
            this.KryptonGroupBox5.Values.Heading = "Busqueda";
            // 
            // btnExportarPresupuesto
            // 
            this.btnExportarPresupuesto.Location = new System.Drawing.Point(653, 3);
            this.btnExportarPresupuesto.Name = "btnExportarPresupuesto";
            this.btnExportarPresupuesto.Size = new System.Drawing.Size(30, 30);
            this.btnExportarPresupuesto.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.btnExportarPresupuesto.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.btnExportarPresupuesto.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExportarPresupuesto.TabIndex = 234;
            this.btnExportarPresupuesto.Values.Image = global::SysCisepro3.Properties.Resources.icons8_excel_48;
            this.btnExportarPresupuesto.Values.Text = "";
            // 
            // KryptonLabel12
            // 
            this.KryptonLabel12.Location = new System.Drawing.Point(385, 8);
            this.KryptonLabel12.Name = "KryptonLabel12";
            this.KryptonLabel12.Size = new System.Drawing.Size(41, 20);
            this.KryptonLabel12.TabIndex = 231;
            this.KryptonLabel12.Values.Text = "Hasta";
            // 
            // KryptonLabel13
            // 
            this.KryptonLabel13.Location = new System.Drawing.Point(240, 9);
            this.KryptonLabel13.Name = "KryptonLabel13";
            this.KryptonLabel13.Size = new System.Drawing.Size(45, 20);
            this.KryptonLabel13.TabIndex = 230;
            this.KryptonLabel13.Values.Text = "Desde";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.AlwaysActive = false;
            this.dtpFechaDesde.CalendarTodayDate = new System.DateTime(2025, 2, 4, 0, 0, 0, 0);
            this.dtpFechaDesde.CustomFormat = "MMMM - yyyy";
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.dtpFechaDesde.Location = new System.Drawing.Point(291, 9);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(85, 21);
            this.dtpFechaDesde.TabIndex = 228;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.AlwaysActive = false;
            this.dtpFechaHasta.CalendarTodayDate = new System.DateTime(2025, 2, 4, 0, 0, 0, 0);
            this.dtpFechaHasta.CustomFormat = "MMMM - yyyy";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.dtpFechaHasta.Location = new System.Drawing.Point(436, 9);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(86, 21);
            this.dtpFechaHasta.TabIndex = 229;
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
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.kryptonNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(800, 450);
            this.kryptonNavigator1.TabIndex = 233;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.dgvArmas);
            this.kryptonPage1.Controls.Add(this.KryptonGroupBox5);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(798, 421);
            this.kryptonPage1.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.kryptonPage1.Text = "Busqueda";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "E0949EB55B8741E81CAFE398E33AAF64";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(798, 423);
            this.kryptonPage2.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.kryptonPage2.Text = "Reporte";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "82851DB7F0E2442FA998EB8B7A4AF715";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(22, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(183, 20);
            this.txtBuscar.TabIndex = 296;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // dgvArmas
            // 
            this.dgvArmas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArmas.Location = new System.Drawing.Point(9, 89);
            this.dgvArmas.Name = "dgvArmas";
            this.dgvArmas.Size = new System.Drawing.Size(778, 321);
            this.dgvArmas.StateNormal.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvArmas.TabIndex = 233;
            // 
            // FrmArmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonNavigator1);
            this.Name = "FrmArmas";
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 5F;
            this.Text = "Armas";
            this.Load += new System.EventHandler(this.FrmArmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KryptonGroupBox5.Panel)).EndInit();
            this.KryptonGroupBox5.Panel.ResumeLayout(false);
            this.KryptonGroupBox5.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KryptonGroupBox5)).EndInit();
            this.KryptonGroupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Krypton.Toolkit.KryptonGroupBox KryptonGroupBox5;
        internal Krypton.Toolkit.KryptonButton btnExportarPresupuesto;
        internal Krypton.Toolkit.KryptonLabel KryptonLabel12;
        internal Krypton.Toolkit.KryptonLabel KryptonLabel13;
        internal Krypton.Toolkit.KryptonDateTimePicker dtpFechaDesde;
        internal Krypton.Toolkit.KryptonDateTimePicker dtpFechaHasta;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private System.Windows.Forms.TextBox txtBuscar;
        private Krypton.Toolkit.KryptonDataGridView dgvArmas;
    }
}