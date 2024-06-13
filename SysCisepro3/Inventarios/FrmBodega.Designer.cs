namespace SysCisepro3.Inventarios
{
    partial class FrmBodega
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
            this.tcBodega = new System.Windows.Forms.TabControl();
            this.tpMantenimiento = new System.Windows.Forms.TabPage();
            this.msKardex = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarCustodio = new System.Windows.Forms.Button();
            this.dgvBodega = new System.Windows.Forms.DataGridView();
            this.txtNombresPersonal = new System.Windows.Forms.TextBox();
            this.txtIdPersonal = new System.Windows.Forms.TextBox();
            this.txtObservación = new System.Windows.Forms.TextBox();
            this.txtNombreBodega = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblObservación = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cbmUbicación = new System.Windows.Forms.ComboBox();
            this.lblUbicación = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblNombreBodega = new System.Windows.Forms.Label();
            this.tpReporteBodega = new System.Windows.Forms.TabPage();
            this.crvBodegas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tcBodega.SuspendLayout();
            this.tpMantenimiento.SuspendLayout();
            this.msKardex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).BeginInit();
            this.tpReporteBodega.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBodega
            // 
            this.tcBodega.Controls.Add(this.tpMantenimiento);
            this.tcBodega.Controls.Add(this.tpReporteBodega);
            this.tcBodega.Location = new System.Drawing.Point(3, 5);
            this.tcBodega.Name = "tcBodega";
            this.tcBodega.SelectedIndex = 0;
            this.tcBodega.Size = new System.Drawing.Size(999, 533);
            this.tcBodega.TabIndex = 1;
            // 
            // tpMantenimiento
            // 
            this.tpMantenimiento.Controls.Add(this.msKardex);
            this.tpMantenimiento.Controls.Add(this.txtTelefono);
            this.tpMantenimiento.Controls.Add(this.btnBuscarCustodio);
            this.tpMantenimiento.Controls.Add(this.dgvBodega);
            this.tpMantenimiento.Controls.Add(this.txtNombresPersonal);
            this.tpMantenimiento.Controls.Add(this.txtIdPersonal);
            this.tpMantenimiento.Controls.Add(this.txtObservación);
            this.tpMantenimiento.Controls.Add(this.txtNombreBodega);
            this.tpMantenimiento.Controls.Add(this.Label4);
            this.tpMantenimiento.Controls.Add(this.lblObservación);
            this.tpMantenimiento.Controls.Add(this.lblTelefono);
            this.tpMantenimiento.Controls.Add(this.cbmUbicación);
            this.tpMantenimiento.Controls.Add(this.lblUbicación);
            this.tpMantenimiento.Controls.Add(this.Label1);
            this.tpMantenimiento.Controls.Add(this.lblNombreBodega);
            this.tpMantenimiento.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tpMantenimiento.Name = "tpMantenimiento";
            this.tpMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tpMantenimiento.Size = new System.Drawing.Size(991, 507);
            this.tpMantenimiento.TabIndex = 0;
            this.tpMantenimiento.Text = "MANTENIMIENTO";
            this.tpMantenimiento.UseVisualStyleBackColor = true;
            // 
            // msKardex
            // 
            this.msKardex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.msKardex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.tsmNuevo,
            this.tsmGuardar,
            this.tsmActualizar,
            this.tsmCancelar,
            this.ToolStripMenuItem2});
            this.msKardex.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.msKardex.Location = new System.Drawing.Point(3, 3);
            this.msKardex.Name = "msKardex";
            this.msKardex.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msKardex.Size = new System.Drawing.Size(985, 32);
            this.msKardex.TabIndex = 179;
            this.msKardex.Text = "msIngresoBodega";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem1.Image = global::SysCisepro3.Properties.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(87, 28);
            this.ToolStripMenuItem1.Text = "BUSCAR";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // tsmNuevo
            // 
            this.tsmNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmNuevo.Image = global::SysCisepro3.Properties.Resources.add_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_;
            this.tsmNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmNuevo.Name = "tsmNuevo";
            this.tsmNuevo.Size = new System.Drawing.Size(82, 28);
            this.tsmNuevo.Text = "NUEVO";
            this.tsmNuevo.Click += new System.EventHandler(this.tsmNuevo_Click);
            // 
            // tsmGuardar
            // 
            this.tsmGuardar.Enabled = false;
            this.tsmGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmGuardar.Image = global::SysCisepro3.Properties.Resources.save_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.tsmGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmGuardar.Name = "tsmGuardar";
            this.tsmGuardar.Size = new System.Drawing.Size(97, 28);
            this.tsmGuardar.Text = "GUARDAR";
            this.tsmGuardar.Click += new System.EventHandler(this.tsmGuardar_Click);
            // 
            // tsmActualizar
            // 
            this.tsmActualizar.Enabled = false;
            this.tsmActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmActualizar.Image = global::SysCisepro3.Properties.Resources.edit_document_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.tsmActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmActualizar.Name = "tsmActualizar";
            this.tsmActualizar.Size = new System.Drawing.Size(112, 28);
            this.tsmActualizar.Text = "ACTUALIZAR";
            this.tsmActualizar.Click += new System.EventHandler(this.tsmActualizar_Click);
            // 
            // tsmCancelar
            // 
            this.tsmCancelar.Enabled = false;
            this.tsmCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCancelar.Image = global::SysCisepro3.Properties.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24;
            this.tsmCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmCancelar.Name = "tsmCancelar";
            this.tsmCancelar.Size = new System.Drawing.Size(103, 28);
            this.tsmCancelar.Text = "CANCELAR";
            this.tsmCancelar.Click += new System.EventHandler(this.tsmCancelar_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem2.Image = global::SysCisepro3.Properties.Resources.description_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(90, 28);
            this.ToolStripMenuItem2.Text = "REPORTE";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(86, 99);
            this.txtTelefono.Mask = "(99)0000-000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 58;
            // 
            // btnBuscarCustodio
            // 
            this.btnBuscarCustodio.BackColor = System.Drawing.Color.White;
            this.btnBuscarCustodio.Enabled = false;
            this.btnBuscarCustodio.FlatAppearance.BorderSize = 0;
            this.btnBuscarCustodio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscarCustodio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCustodio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCustodio.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCustodio.Image = global::SysCisepro3.Properties.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.btnBuscarCustodio.Location = new System.Drawing.Point(410, 69);
            this.btnBuscarCustodio.Name = "btnBuscarCustodio";
            this.btnBuscarCustodio.Size = new System.Drawing.Size(26, 26);
            this.btnBuscarCustodio.TabIndex = 55;
            this.btnBuscarCustodio.UseVisualStyleBackColor = false;
            this.btnBuscarCustodio.Click += new System.EventHandler(this.btnBuscarCustodio_Click);
            // 
            // dgvBodega
            // 
            this.dgvBodega.AllowUserToAddRows = false;
            this.dgvBodega.AllowUserToDeleteRows = false;
            this.dgvBodega.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBodega.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBodega.BackgroundColor = System.Drawing.Color.White;
            this.dgvBodega.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBodega.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBodega.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvBodega.Location = new System.Drawing.Point(3, 127);
            this.dgvBodega.MultiSelect = false;
            this.dgvBodega.Name = "dgvBodega";
            this.dgvBodega.ReadOnly = true;
            this.dgvBodega.RowHeadersVisible = false;
            this.dgvBodega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBodega.Size = new System.Drawing.Size(985, 377);
            this.dgvBodega.TabIndex = 54;
            this.dgvBodega.SelectionChanged += new System.EventHandler(this.dgvBodega_SelectionChanged);
            // 
            // txtNombresPersonal
            // 
            this.txtNombresPersonal.BackColor = System.Drawing.Color.White;
            this.txtNombresPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombresPersonal.Enabled = false;
            this.txtNombresPersonal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresPersonal.Location = new System.Drawing.Point(86, 71);
            this.txtNombresPersonal.Name = "txtNombresPersonal";
            this.txtNombresPersonal.Size = new System.Drawing.Size(324, 22);
            this.txtNombresPersonal.TabIndex = 40;
            // 
            // txtIdPersonal
            // 
            this.txtIdPersonal.BackColor = System.Drawing.Color.White;
            this.txtIdPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdPersonal.Enabled = false;
            this.txtIdPersonal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPersonal.Location = new System.Drawing.Point(86, 71);
            this.txtIdPersonal.Name = "txtIdPersonal";
            this.txtIdPersonal.Size = new System.Drawing.Size(44, 22);
            this.txtIdPersonal.TabIndex = 39;
            this.txtIdPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIdPersonal.Visible = false;
            // 
            // txtObservación
            // 
            this.txtObservación.BackColor = System.Drawing.Color.White;
            this.txtObservación.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservación.Enabled = false;
            this.txtObservación.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservación.Location = new System.Drawing.Point(583, 73);
            this.txtObservación.Multiline = true;
            this.txtObservación.Name = "txtObservación";
            this.txtObservación.Size = new System.Drawing.Size(361, 48);
            this.txtObservación.TabIndex = 37;
            // 
            // txtNombreBodega
            // 
            this.txtNombreBodega.BackColor = System.Drawing.Color.White;
            this.txtNombreBodega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreBodega.Enabled = false;
            this.txtNombreBodega.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBodega.Location = new System.Drawing.Point(86, 43);
            this.txtNombreBodega.Name = "txtNombreBodega";
            this.txtNombreBodega.Size = new System.Drawing.Size(355, 22);
            this.txtNombreBodega.TabIndex = 29;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(15, 74);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 13);
            this.Label4.TabIndex = 38;
            this.Label4.Text = "CUSTODIO:";
            // 
            // lblObservación
            // 
            this.lblObservación.AutoSize = true;
            this.lblObservación.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservación.Location = new System.Drawing.Point(491, 76);
            this.lblObservación.Name = "lblObservación";
            this.lblObservación.Size = new System.Drawing.Size(84, 13);
            this.lblObservación.TabIndex = 36;
            this.lblObservación.Text = "OBSERVACIÓN:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(15, 102);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(65, 13);
            this.lblTelefono.TabIndex = 34;
            this.lblTelefono.Text = "TELÉFONO:";
            // 
            // cbmUbicación
            // 
            this.cbmUbicación.BackColor = System.Drawing.Color.White;
            this.cbmUbicación.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmUbicación.Enabled = false;
            this.cbmUbicación.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmUbicación.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmUbicación.FormattingEnabled = true;
            this.cbmUbicación.Location = new System.Drawing.Point(583, 43);
            this.cbmUbicación.Name = "cbmUbicación";
            this.cbmUbicación.Size = new System.Drawing.Size(361, 21);
            this.cbmUbicación.TabIndex = 32;
            // 
            // lblUbicación
            // 
            this.lblUbicación.AutoSize = true;
            this.lblUbicación.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicación.Location = new System.Drawing.Point(491, 46);
            this.lblUbicación.Name = "lblUbicación";
            this.lblUbicación.Size = new System.Drawing.Size(68, 13);
            this.lblUbicación.TabIndex = 31;
            this.lblUbicación.Text = "UBICACIÓN:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(3, 123);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 13);
            this.Label1.TabIndex = 30;
            // 
            // lblNombreBodega
            // 
            this.lblNombreBodega.AutoSize = true;
            this.lblNombreBodega.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBodega.Location = new System.Drawing.Point(15, 46);
            this.lblNombreBodega.Name = "lblNombreBodega";
            this.lblNombreBodega.Size = new System.Drawing.Size(56, 13);
            this.lblNombreBodega.TabIndex = 28;
            this.lblNombreBodega.Text = "NOMBRE:";
            // 
            // tpReporteBodega
            // 
            this.tpReporteBodega.Controls.Add(this.crvBodegas);
            this.tpReporteBodega.Location = new System.Drawing.Point(4, 22);
            this.tpReporteBodega.Name = "tpReporteBodega";
            this.tpReporteBodega.Padding = new System.Windows.Forms.Padding(3);
            this.tpReporteBodega.Size = new System.Drawing.Size(991, 507);
            this.tpReporteBodega.TabIndex = 1;
            this.tpReporteBodega.Text = "REPORTE";
            this.tpReporteBodega.UseVisualStyleBackColor = true;
            // 
            // crvBodegas
            // 
            this.crvBodegas.ActiveViewIndex = -1;
            this.crvBodegas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBodegas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBodegas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvBodegas.Location = new System.Drawing.Point(3, 3);
            this.crvBodegas.Name = "crvBodegas";
            this.crvBodegas.Size = new System.Drawing.Size(985, 501);
            this.crvBodegas.TabIndex = 1;
            this.crvBodegas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 541);
            this.Controls.Add(this.tcBodega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 5F;
            this.Text = "REGISTRO BODEGAS";
            this.Load += new System.EventHandler(this.FrmBodega_Load);
            this.tcBodega.ResumeLayout(false);
            this.tpMantenimiento.ResumeLayout(false);
            this.tpMantenimiento.PerformLayout();
            this.msKardex.ResumeLayout(false);
            this.msKardex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).EndInit();
            this.tpReporteBodega.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl tcBodega;
        internal System.Windows.Forms.TabPage tpMantenimiento;
        internal System.Windows.Forms.MenuStrip msKardex;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem tsmNuevo;
        internal System.Windows.Forms.ToolStripMenuItem tsmGuardar;
        internal System.Windows.Forms.ToolStripMenuItem tsmActualizar;
        internal System.Windows.Forms.ToolStripMenuItem tsmCancelar;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        internal System.Windows.Forms.MaskedTextBox txtTelefono;
        internal System.Windows.Forms.Button btnBuscarCustodio;
        internal System.Windows.Forms.DataGridView dgvBodega;
        internal System.Windows.Forms.TextBox txtNombresPersonal;
        internal System.Windows.Forms.TextBox txtIdPersonal;
        internal System.Windows.Forms.TextBox txtObservación;
        internal System.Windows.Forms.TextBox txtNombreBodega;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblObservación;
        internal System.Windows.Forms.Label lblTelefono;
        internal System.Windows.Forms.ComboBox cbmUbicación;
        internal System.Windows.Forms.Label lblUbicación;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblNombreBodega;
        internal System.Windows.Forms.TabPage tpReporteBodega;
        internal CrystalDecisions.Windows.Forms.CrystalReportViewer crvBodegas;
    }
}