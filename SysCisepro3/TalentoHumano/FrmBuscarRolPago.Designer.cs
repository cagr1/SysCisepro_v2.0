namespace SysCisepro3.TalentoHumano
{
    partial class FrmBuscarRolPago
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
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.btnSig = new System.Windows.Forms.Button();
            this.dtpFechaMes = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(465, 12);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaHasta.TabIndex = 38;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaElaborado_ValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.White;
            this.lblHasta.Location = new System.Drawing.Point(404, 15);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 14);
            this.lblHasta.TabIndex = 37;
            this.lblHasta.Text = "HASTA:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(263, 12);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaDesde.TabIndex = 36;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaElaborado_ValueChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(6, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(174, 14);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "BUSCAR  ROLES DE PAGO DESDE:";
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRoles.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(60)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoles.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvRoles.Location = new System.Drawing.Point(2, 45);
            this.dgvRoles.MultiSelect = false;
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.RowHeadersVisible = false;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(970, 318);
            this.dgvRoles.TabIndex = 34;
            this.dgvRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellContentClick);
            this.dgvRoles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustodios_CellDoubleClick);
            // 
            // btnSig
            // 
            this.btnSig.BackColor = System.Drawing.Color.White;
            this.btnSig.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSig.Image = global::SysCisepro3.Properties.Resources.check_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_;
            this.btnSig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSig.Location = new System.Drawing.Point(862, 5);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(100, 34);
            this.btnSig.TabIndex = 213;
            this.btnSig.Text = "    ACEPTAR";
            this.btnSig.UseVisualStyleBackColor = false;
            this.btnSig.Visible = false;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // dtpFechaMes
            // 
            this.dtpFechaMes.CustomFormat = "MMMM - yyyy";
            this.dtpFechaMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaMes.Location = new System.Drawing.Point(233, 12);
            this.dtpFechaMes.Name = "dtpFechaMes";
            this.dtpFechaMes.Size = new System.Drawing.Size(136, 20);
            this.dtpFechaMes.TabIndex = 214;
            this.dtpFechaMes.Visible = false;
            this.dtpFechaMes.ValueChanged += new System.EventHandler(this.dtpFechaElaborado_ValueChanged);
            // 
            // FrmBuscarRolPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 364);
            this.Controls.Add(this.dtpFechaMes);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dgvRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBuscarRolPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 5F;
            this.Text = "BUSCAR ROL DE PAGO";
            this.Load += new System.EventHandler(this.FrmBuscarRolPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker dtpFechaHasta;
        internal System.Windows.Forms.Label lblHasta;
        internal System.Windows.Forms.DateTimePicker dtpFechaDesde;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgvRoles;
        internal System.Windows.Forms.Button btnSig;
        internal System.Windows.Forms.DateTimePicker dtpFechaMes;
    }
}