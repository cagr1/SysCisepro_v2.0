namespace SysCisepro3.Contabilidad
{
    partial class FrmFlujoOperaciones
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
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCargar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            this.dtpFechaHasta = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpFechaDesde = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.dgvFlujoOperaciones = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlujoOperaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionOverlap = 0D;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(4, 5);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnCargar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonCheckBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtpFechaHasta);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtpFechaDesde);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(732, 74);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Busqueda";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.AutoSize = true;
            this.kryptonButton2.Location = new System.Drawing.Point(628, 6);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(88, 30);
            this.kryptonButton2.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.kryptonButton2.TabIndex = 297;
            this.kryptonButton2.Values.Image = global::SysCisepro3.Properties.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.kryptonButton2.Values.Text = "Reporte";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.AutoSize = true;
            this.kryptonButton1.Location = new System.Drawing.Point(527, 6);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(88, 30);
            this.kryptonButton1.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.kryptonButton1.TabIndex = 296;
            this.kryptonButton1.Values.Image = global::SysCisepro3.Properties.Resources.icons8_excel_48;
            this.kryptonButton1.Values.Text = "Excel";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.AutoSize = true;
            this.btnCargar.Location = new System.Drawing.Point(303, 8);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(88, 30);
            this.btnCargar.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnCargar.TabIndex = 295;
            this.btnCargar.Values.Image = global::SysCisepro3.Properties.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.btnCargar.Values.Text = "Cargar";
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(413, 14);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(108, 20);
            this.kryptonCheckBox1.TabIndex = 1;
            this.kryptonCheckBox1.Values.Text = "Personalizacion";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(196, 14);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dtpFechaHasta.Size = new System.Drawing.Size(87, 21);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(52, 15);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dtpFechaDesde.Size = new System.Drawing.Size(87, 21);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(149, 16);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Hasta";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(6, 15);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Desde";
            // 
            // dgvFlujoOperaciones
            // 
            this.dgvFlujoOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFlujoOperaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFlujoOperaciones.Location = new System.Drawing.Point(0, 0);
            this.dgvFlujoOperaciones.Name = "dgvFlujoOperaciones";
            this.dgvFlujoOperaciones.RowHeadersVisible = false;
            this.dgvFlujoOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlujoOperaciones.Size = new System.Drawing.Size(728, 495);
            this.dgvFlujoOperaciones.StateNormal.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvFlujoOperaciones.TabIndex = 3;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionOverlap = 0D;
            this.kryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(4, 85);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.dgvFlujoOperaciones);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(732, 519);
            this.kryptonGroupBox2.TabIndex = 4;
            this.kryptonGroupBox2.Values.Heading = "Flujo de Operacion";
            // 
            // FrmFlujoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(739, 609);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "FrmFlujoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 5F;
            this.Text = "Flujo Operativo";
            this.Load += new System.EventHandler(this.FrmFlujoOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlujoOperaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaHasta;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaDesde;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonDataGridView dgvFlujoOperaciones;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnCargar;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
    }
}