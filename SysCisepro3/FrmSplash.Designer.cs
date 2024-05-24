namespace SysCisepro3
{
    partial class FrmSplash
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbs = new System.Windows.Forms.ProgressBar();
            this.lblDerechos = new System.Windows.Forms.Label();
            this.lbNombreSistema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContinuar.FlatAppearance.BorderSize = 2;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Location = new System.Drawing.Point(413, 168);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 37;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbs
            // 
            this.pbs.Location = new System.Drawing.Point(12, 178);
            this.pbs.Name = "pbs";
            this.pbs.Size = new System.Drawing.Size(51, 10);
            this.pbs.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbs.TabIndex = 39;
            this.pbs.Visible = false;
            // 
            // lblDerechos
            // 
            this.lblDerechos.BackColor = System.Drawing.Color.Transparent;
            this.lblDerechos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerechos.ForeColor = System.Drawing.Color.Gray;
            this.lblDerechos.Location = new System.Drawing.Point(9, 165);
            this.lblDerechos.Name = "lblDerechos";
            this.lblDerechos.Size = new System.Drawing.Size(157, 26);
            this.lblDerechos.TabIndex = 40;
            this.lblDerechos.Text = "                     Copyright © 2020 \r\nTodos los derechos reservados";
            this.lblDerechos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDerechos.Visible = false;
            // 
            // lbNombreSistema
            // 
            this.lbNombreSistema.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNombreSistema.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreSistema.ForeColor = System.Drawing.Color.White;
            this.lbNombreSistema.Location = new System.Drawing.Point(339, 9);
            this.lbNombreSistema.Name = "lbNombreSistema";
            this.lbNombreSistema.Size = new System.Drawing.Size(158, 70);
            this.lbNombreSistema.TabIndex = 41;
            this.lbNombreSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNombreSistema.Visible = false;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.lbNombreSistema);
            this.Controls.Add(this.lblDerechos);
            this.Controls.Add(this.pbs);
            this.Controls.Add(this.btnContinuar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CISEPRO";
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.ProgressBar pbs;
        private System.Windows.Forms.Label lblDerechos;
        private System.Windows.Forms.Label lbNombreSistema;
    }
}

