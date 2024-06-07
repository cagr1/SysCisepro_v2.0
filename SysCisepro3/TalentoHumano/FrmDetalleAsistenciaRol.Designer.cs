namespace SysCisepro3.TalentoHumano
{
    partial class FrmDetalleAsistenciaRol
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargaBasica = new System.Windows.Forms.Button();
            this.btnCargarPersonal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.DateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListView3 = new System.Windows.Forms.ListView();
            this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.White;
            this.GroupBox1.Controls.Add(this.btnCargaBasica);
            this.GroupBox1.Controls.Add(this.btnCargarPersonal);
            this.GroupBox1.Controls.Add(this.textBox1);
            this.GroupBox1.Controls.Add(this.DateTimePicker6);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.DateTimePicker7);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(1, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(774, 131);
            this.GroupBox1.TabIndex = 203;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "REPORTE DE ASISTENCIA, POR PUESTO Y DÍAS TRABAJADOS:";
            // 
            // btnCargaBasica
            // 
            this.btnCargaBasica.BackColor = System.Drawing.Color.White;
            this.btnCargaBasica.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaBasica.Image = global::SysCisepro3.Properties.Resources.print_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnCargaBasica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargaBasica.Location = new System.Drawing.Point(677, 27);
            this.btnCargaBasica.Name = "btnCargaBasica";
            this.btnCargaBasica.Size = new System.Drawing.Size(91, 35);
            this.btnCargaBasica.TabIndex = 208;
            this.btnCargaBasica.Text = "Basico";
            this.btnCargaBasica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargaBasica.UseVisualStyleBackColor = false;
            this.btnCargaBasica.Click += new System.EventHandler(this.btnCargaBasica_Click);
            // 
            // btnCargarPersonal
            // 
            this.btnCargarPersonal.BackColor = System.Drawing.Color.White;
            this.btnCargarPersonal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPersonal.Image = global::SysCisepro3.Properties.Resources.print_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnCargarPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarPersonal.Location = new System.Drawing.Point(677, 70);
            this.btnCargarPersonal.Name = "btnCargarPersonal";
            this.btnCargarPersonal.Size = new System.Drawing.Size(91, 35);
            this.btnCargarPersonal.TabIndex = 207;
            this.btnCargarPersonal.Text = "Completo";
            this.btnCargarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarPersonal.UseVisualStyleBackColor = false;
            this.btnCargarPersonal.Click += new System.EventHandler(this.btnCargarPersonal_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(71, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 21);
            this.textBox1.TabIndex = 205;
            // 
            // DateTimePicker6
            // 
            this.DateTimePicker6.CustomFormat = "MMMM yyyy";
            this.DateTimePicker6.Enabled = false;
            this.DateTimePicker6.Location = new System.Drawing.Point(401, 90);
            this.DateTimePicker6.Name = "DateTimePicker6";
            this.DateTimePicker6.Size = new System.Drawing.Size(255, 21);
            this.DateTimePicker6.TabIndex = 202;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(370, 92);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(23, 13);
            this.Label3.TabIndex = 203;
            this.Label3.Text = "AL:";
            // 
            // DateTimePicker7
            // 
            this.DateTimePicker7.CustomFormat = "MMMM yyyy";
            this.DateTimePicker7.Enabled = false;
            this.DateTimePicker7.Location = new System.Drawing.Point(401, 68);
            this.DateTimePicker7.Name = "DateTimePicker7";
            this.DateTimePicker7.Size = new System.Drawing.Size(255, 21);
            this.DateTimePicker7.TabIndex = 200;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(367, 71);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 13);
            this.Label5.TabIndex = 201;
            this.Label5.Text = "DEL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 204;
            this.label1.Text = "FILTRO:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(630, 35);
            this.label2.TabIndex = 206;
            this.label2.Text = "ESTE LISTADO REPRESENTA LOS DÍAS DE ASISTENCIA, ATRASO, DOBLADA, FALTAS, VACACION" +
    "ES, ETC. DEL VIGILANTE SELECCIONADO EN EL RANGO DE FECHAS SELECCIONADO";
            // 
            // ListView3
            // 
            this.ListView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader11,
            this.ColumnHeader14,
            this.ColumnHeader15,
            this.ColumnHeader16,
            this.ColumnHeader18});
            this.ListView3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView3.FullRowSelect = true;
            this.ListView3.HideSelection = false;
            this.ListView3.Location = new System.Drawing.Point(-5, 137);
            this.ListView3.MultiSelect = false;
            this.ListView3.Name = "ListView3";
            this.ListView3.Size = new System.Drawing.Size(780, 379);
            this.ListView3.TabIndex = 208;
            this.ListView3.UseCompatibleStateImageBehavior = false;
            this.ListView3.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader11
            // 
            this.ColumnHeader11.Text = "IDS";
            this.ColumnHeader11.Width = 0;
            // 
            // ColumnHeader14
            // 
            this.ColumnHeader14.Text = "FECHA";
            this.ColumnHeader14.Width = 90;
            // 
            // ColumnHeader15
            // 
            this.ColumnHeader15.Text = "PUESTO";
            this.ColumnHeader15.Width = 250;
            // 
            // ColumnHeader16
            // 
            this.ColumnHeader16.Text = "DETALLE";
            this.ColumnHeader16.Width = 130;
            // 
            // ColumnHeader18
            // 
            this.ColumnHeader18.Text = "OBSERVACIONES";
            this.ColumnHeader18.Width = 300;
            // 
            // FrmDetalleAsistenciaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 528);
            this.Controls.Add(this.ListView3);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDetalleAsistenciaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 5F;
            this.Text = "DETALLE DE ASISTENCIA";
            this.Load += new System.EventHandler(this.FrmDetalleAsistenciaRol_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DateTimePicker DateTimePicker6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker DateTimePicker7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ListView ListView3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader11;
        internal System.Windows.Forms.ColumnHeader ColumnHeader14;
        internal System.Windows.Forms.ColumnHeader ColumnHeader15;
        internal System.Windows.Forms.ColumnHeader ColumnHeader16;
        internal System.Windows.Forms.ColumnHeader ColumnHeader18;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnCargarPersonal;
        internal System.Windows.Forms.Button btnCargaBasica;

        public string Mes { get; internal set; }
    }
}