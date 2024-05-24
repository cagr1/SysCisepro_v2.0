namespace SysCisepro3.TalentoHumano
{
    partial class FrmCumpleanosPersonal
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
            this.tcCumpleañeros = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblEdad = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.crvCumpleañeros = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tcCumpleañeros.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCumpleañeros
            // 
            this.tcCumpleañeros.Controls.Add(this.TabPage1);
            this.tcCumpleañeros.Controls.Add(this.TabPage2);
            this.tcCumpleañeros.Location = new System.Drawing.Point(3, 3);
            this.tcCumpleañeros.Name = "tcCumpleañeros";
            this.tcCumpleañeros.SelectedIndex = 0;
            this.tcCumpleañeros.Size = new System.Drawing.Size(881, 354);
            this.tcCumpleañeros.TabIndex = 1;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.dataGridView1);
            this.TabPage1.Controls.Add(this.lblEdad);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.PictureBox1);
            this.TabPage1.Controls.Add(this.dtpFechaFinal);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.dtpFechaInicial);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.MenuStrip1);
            this.TabPage1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(873, 328);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "BUSCAR";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 32);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(739, 290);
            this.dataGridView1.TabIndex = 226;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEdad.Location = new System.Drawing.Point(753, 259);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(114, 34);
            this.lblEdad.TabIndex = 188;
            this.lblEdad.Text = "0";
            this.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(753, 209);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(112, 15);
            this.Label3.TabIndex = 187;
            this.Label3.Text = "EDAD QUE CUMPLE";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(751, 30);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(118, 131);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 186;
            this.PictureBox1.TabStop = false;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CalendarFont = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.CustomFormat = "dd MMMM";
            this.dtpFechaFinal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(254, 4);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(122, 22);
            this.dtpFechaFinal.TabIndex = 132;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(210, 8);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(39, 13);
            this.Label2.TabIndex = 135;
            this.Label2.Text = "Hasta:";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarFont = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.CustomFormat = "dd MMMM";
            this.dtpFechaInicial.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicial.Location = new System.Drawing.Point(60, 4);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(122, 22);
            this.dtpFechaInicial.TabIndex = 131;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(14, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(42, 13);
            this.Label1.TabIndex = 134;
            this.Label1.Text = "Desde:";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReporte,
            this.btnConsultar});
            this.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MenuStrip1.Location = new System.Drawing.Point(3, 3);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuStrip1.Size = new System.Drawing.Size(867, 24);
            this.MenuStrip1.TabIndex = 185;
            this.MenuStrip1.Text = "msIngresoBodega";
            // 
            // btnReporte
            // 
            this.btnReporte.Image = global::SysCisepro3.Properties.Resources.report;
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(82, 20);
            this.btnReporte.Text = "REPORTE";
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::SysCisepro3.Properties.Resources.BuscarRegistro;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(76, 20);
            this.btnConsultar.Text = "BUSCAR";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.crvCumpleañeros);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(873, 328);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "REPORTE";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // crvCumpleañeros
            // 
            this.crvCumpleañeros.ActiveViewIndex = -1;
            this.crvCumpleañeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCumpleañeros.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCumpleañeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCumpleañeros.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crvCumpleañeros.Location = new System.Drawing.Point(3, 3);
            this.crvCumpleañeros.Name = "crvCumpleañeros";
            this.crvCumpleañeros.Size = new System.Drawing.Size(867, 322);
            this.crvCumpleañeros.TabIndex = 0;
            this.crvCumpleañeros.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmCumpleanosPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 358);
            this.Controls.Add(this.tcCumpleañeros);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCumpleanosPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUMPLEAÑOS DEL PERSONAL";
            this.Load += new System.EventHandler(this.FrmCumpleanosPersonal_Load);
            this.tcCumpleañeros.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl tcCumpleañeros;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Label lblEdad;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.DateTimePicker dtpFechaFinal;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker dtpFechaInicial;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem btnReporte;
        internal System.Windows.Forms.ToolStripMenuItem btnConsultar;
        internal System.Windows.Forms.TabPage TabPage2;
        internal CrystalDecisions.Windows.Forms.CrystalReportViewer crvCumpleañeros;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}