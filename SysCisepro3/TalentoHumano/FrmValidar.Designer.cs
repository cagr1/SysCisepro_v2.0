namespace SysCisepro3.TalentoHumano
{
    partial class FrmValidar
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
            this.pictureBoxC = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.cbLogin = new System.Windows.Forms.ComboBox();
            this.pictureBoxS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxC
            // 
            this.pictureBoxC.BackgroundImage = global::SysCisepro3.Properties.Resources.Cisepro_Wall;
            this.pictureBoxC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxC.Location = new System.Drawing.Point(2, 0);
            this.pictureBoxC.Name = "pictureBoxC";
            this.pictureBoxC.Size = new System.Drawing.Size(385, 142);
            this.pictureBoxC.TabIndex = 13;
            this.pictureBoxC.TabStop = false;
            this.pictureBoxC.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptar.CausesValidation = false;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(119, 206);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(141, 32);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "VALIDAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(21, 180);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 15);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(98, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(197, 23);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(48, 151);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(44, 15);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "LOGIN:";
            // 
            // cbLogin
            // 
            this.cbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLogin.FormattingEnabled = true;
            this.cbLogin.Location = new System.Drawing.Point(98, 148);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(197, 23);
            this.cbLogin.TabIndex = 16;
            // 
            // pictureBoxS
            // 
            this.pictureBoxS.BackgroundImage = global::SysCisepro3.Properties.Resources.SeportPac_Wall;
            this.pictureBoxS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxS.Location = new System.Drawing.Point(2, 0);
            this.pictureBoxS.Name = "pictureBoxS";
            this.pictureBoxS.Size = new System.Drawing.Size(385, 142);
            this.pictureBoxS.TabIndex = 19;
            this.pictureBoxS.TabStop = false;
            this.pictureBoxS.Visible = false;
            // 
            // FrmValidar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 249);
            this.Controls.Add(this.pictureBoxS);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.cbLogin);
            this.Controls.Add(this.pictureBoxC);
            this.Name = "FrmValidar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validacion";
            this.Load += new System.EventHandler(this.FrmValidar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox pictureBoxC;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label lblLogin;
        internal System.Windows.Forms.ComboBox cbLogin;
        internal System.Windows.Forms.PictureBox pictureBoxS;
    }
}