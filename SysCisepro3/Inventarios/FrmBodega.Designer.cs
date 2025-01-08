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
            this.cbmUbicación = new System.Windows.Forms.ComboBox();
            this.tcBodega = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.crvBodegas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.msKardex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcBodega)).BeginInit();
            this.tcBodega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            this.SuspendLayout();
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
            this.msKardex.Location = new System.Drawing.Point(0, 0);
            this.msKardex.Name = "msKardex";
            this.msKardex.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msKardex.Size = new System.Drawing.Size(925, 32);
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
            this.txtTelefono.Location = new System.Drawing.Point(76, 95);
            this.txtTelefono.Mask = "(99)0000-000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 58;
            // 
            // btnBuscarCustodio
            // 
            this.btnBuscarCustodio.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCustodio.Enabled = false;
            this.btnBuscarCustodio.FlatAppearance.BorderSize = 0;
            this.btnBuscarCustodio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscarCustodio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCustodio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCustodio.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCustodio.Image = global::SysCisepro3.Properties.Resources.search_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.btnBuscarCustodio.Location = new System.Drawing.Point(407, 64);
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
            this.dgvBodega.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvBodega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBodega.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBodega.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBodega.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvBodega.Location = new System.Drawing.Point(9, 128);
            this.dgvBodega.MultiSelect = false;
            this.dgvBodega.Name = "dgvBodega";
            this.dgvBodega.ReadOnly = true;
            this.dgvBodega.RowHeadersVisible = false;
            this.dgvBodega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBodega.Size = new System.Drawing.Size(905, 304);
            this.dgvBodega.TabIndex = 54;
            this.dgvBodega.SelectionChanged += new System.EventHandler(this.dgvBodega_SelectionChanged);
            // 
            // txtNombresPersonal
            // 
            this.txtNombresPersonal.BackColor = System.Drawing.Color.White;
            this.txtNombresPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombresPersonal.Enabled = false;
            this.txtNombresPersonal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresPersonal.Location = new System.Drawing.Point(76, 67);
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
            this.txtIdPersonal.Location = new System.Drawing.Point(265, 67);
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
            this.txtObservación.Location = new System.Drawing.Point(530, 65);
            this.txtObservación.Multiline = true;
            this.txtObservación.Name = "txtObservación";
            this.txtObservación.Size = new System.Drawing.Size(347, 24);
            this.txtObservación.TabIndex = 37;
            // 
            // txtNombreBodega
            // 
            this.txtNombreBodega.BackColor = System.Drawing.Color.White;
            this.txtNombreBodega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreBodega.Enabled = false;
            this.txtNombreBodega.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBodega.Location = new System.Drawing.Point(76, 39);
            this.txtNombreBodega.Name = "txtNombreBodega";
            this.txtNombreBodega.Size = new System.Drawing.Size(324, 22);
            this.txtNombreBodega.TabIndex = 29;
            // 
            // cbmUbicación
            // 
            this.cbmUbicación.BackColor = System.Drawing.Color.White;
            this.cbmUbicación.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmUbicación.Enabled = false;
            this.cbmUbicación.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmUbicación.FormattingEnabled = true;
            this.cbmUbicación.Location = new System.Drawing.Point(530, 38);
            this.cbmUbicación.Name = "cbmUbicación";
            this.cbmUbicación.Size = new System.Drawing.Size(347, 21);
            this.cbmUbicación.TabIndex = 32;
            // 
            // tcBodega
            // 
            this.tcBodega.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.tcBodega.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.tcBodega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBodega.Location = new System.Drawing.Point(0, 0);
            this.tcBodega.Name = "tcBodega";
            this.tcBodega.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.tcBodega.SelectedIndex = 0;
            this.tcBodega.Size = new System.Drawing.Size(927, 475);
            this.tcBodega.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.tcBodega.TabIndex = 2;
            this.tcBodega.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.kryptonLabel5);
            this.kryptonPage1.Controls.Add(this.dgvBodega);
            this.kryptonPage1.Controls.Add(this.txtTelefono);
            this.kryptonPage1.Controls.Add(this.kryptonLabel4);
            this.kryptonPage1.Controls.Add(this.kryptonLabel3);
            this.kryptonPage1.Controls.Add(this.kryptonLabel2);
            this.kryptonPage1.Controls.Add(this.kryptonLabel1);
            this.kryptonPage1.Controls.Add(this.txtObservación);
            this.kryptonPage1.Controls.Add(this.btnBuscarCustodio);
            this.kryptonPage1.Controls.Add(this.msKardex);
            this.kryptonPage1.Controls.Add(this.txtNombreBodega);
            this.kryptonPage1.Controls.Add(this.txtNombresPersonal);
            this.kryptonPage1.Controls.Add(this.cbmUbicación);
            this.kryptonPage1.Controls.Add(this.txtIdPersonal);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(925, 448);
            this.kryptonPage1.Text = "Mantenimiento";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "F8A390BEFCE04F1B408009AB155EA7CA";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.crvBodegas);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(949, 209);
            this.kryptonPage2.Text = "Reporte";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "5F728D65400A4EA2C4A34798F65448A5";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 39);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel1.TabIndex = 180;
            this.kryptonLabel1.Values.Text = "Nombre";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(14, 65);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel2.TabIndex = 181;
            this.kryptonLabel2.Values.Text = "Custodio";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(446, 39);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(64, 20);
            this.kryptonLabel3.TabIndex = 182;
            this.kryptonLabel3.Values.Text = "Ubicacion";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(446, 65);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel4.TabIndex = 183;
            this.kryptonLabel4.Values.Text = "Observacion";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(14, 91);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel5.TabIndex = 184;
            this.kryptonLabel5.Values.Text = "Telefono";
            // 
            // crvBodegas
            // 
            this.crvBodegas.ActiveViewIndex = -1;
            this.crvBodegas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBodegas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvBodegas.Location = new System.Drawing.Point(0, 0);
            this.crvBodegas.Name = "crvBodegas";
            this.crvBodegas.ShowCloseButton = false;
            this.crvBodegas.ShowLogo = false;
            this.crvBodegas.Size = new System.Drawing.Size(949, 209);
            this.crvBodegas.TabIndex = 2;
            this.crvBodegas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(927, 475);
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
            this.msKardex.ResumeLayout(false);
            this.msKardex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcBodega)).EndInit();
            this.tcBodega.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.kryptonPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        internal System.Windows.Forms.ComboBox cbmUbicación;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator tcBodega;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        internal CrystalDecisions.Windows.Forms.CrystalReportViewer crvBodegas;
    }
}