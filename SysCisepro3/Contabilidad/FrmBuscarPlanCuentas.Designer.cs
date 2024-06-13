namespace SysCisepro3.Contabilidad
{
    partial class FrmBuscarPlanCuentas
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtParametrobusqueda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(6, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 14);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "BUSCAR:";
            // 
            // txtParametrobusqueda
            // 
            this.txtParametrobusqueda.BackColor = System.Drawing.Color.White;
            this.txtParametrobusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametrobusqueda.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametrobusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(60)))), ((int)(((byte)(123)))));
            this.txtParametrobusqueda.Location = new System.Drawing.Point(59, 4);
            this.txtParametrobusqueda.Name = "txtParametrobusqueda";
            this.txtParametrobusqueda.Size = new System.Drawing.Size(295, 21);
            this.txtParametrobusqueda.TabIndex = 19;
            this.txtParametrobusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtParametrobusqueda_KeyUp);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(709, 68);
            this.label4.TabIndex = 23;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader4,
            this.ColumnHeader3});
            this.listView1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 32);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(729, 263);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "ID";
            this.ColumnHeader1.Width = 0;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "CÓDIGO";
            this.ColumnHeader4.Width = 100;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "CUENTA";
            this.ColumnHeader3.Width = 600;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(406, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "TIPO:";
            // 
            // cbxTipoCuenta
            // 
            this.cbxTipoCuenta.BackColor = System.Drawing.Color.White;
            this.cbxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipoCuenta.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoCuenta.FormattingEnabled = true;
            this.cbxTipoCuenta.Items.AddRange(new object[] {
            "-- TODOS --",
            "ACTIVOS",
            "PASIVOS",
            "PATRIMONIO",
            "INGRESOS",
            "GASTOS",
            "GANANCIAS"});
            this.cbxTipoCuenta.Location = new System.Drawing.Point(445, 4);
            this.cbxTipoCuenta.Name = "cbxTipoCuenta";
            this.cbxTipoCuenta.Size = new System.Drawing.Size(116, 21);
            this.cbxTipoCuenta.TabIndex = 132;
            this.cbxTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cbxTipoCuenta_SelectedIndexChanged);
            // 
            // FrmBuscarPlanCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 298);
            this.Controls.Add(this.cbxTipoCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtParametrobusqueda);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBuscarPlanCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 5F;
            this.Text = "BUSCAR CUENTAS CONTABLES";
            this.Load += new System.EventHandler(this.FrmBuscarPlanCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtParametrobusqueda;
        public System.Windows.Forms.ComboBox cbxTipoCuenta;
    }
}