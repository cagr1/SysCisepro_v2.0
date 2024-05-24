namespace SysCisepro3.Main
{
    partial class FrmLogin
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
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.cbLogin = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureBoxC = new System.Windows.Forms.PictureBox();
            this.pictureBoxS = new System.Windows.Forms.PictureBox();
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(33, 180);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 15);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "PASSWORD:";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(110, 177);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(197, 23);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged_1);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(60, 151);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(44, 15);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "LOGIN:";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // cbLogin
            // 
            this.cbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogin.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLogin.FormattingEnabled = true;
            this.cbLogin.Location = new System.Drawing.Point(110, 148);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(197, 23);
            this.cbLogin.TabIndex = 9;
            this.cbLogin.SelectedIndexChanged += new System.EventHandler(this.cbLogin_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptar.CausesValidation = false;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = global::SysCisepro3.Properties.Resources.login;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(131, 206);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(141, 32);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "INGRESAR AL SISTEMA";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pictureBoxC
            // 
            this.pictureBoxC.BackgroundImage = global::SysCisepro3.Properties.Resources.Cisepro_Wall;
            this.pictureBoxC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxC.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxC.Name = "pictureBoxC";
            this.pictureBoxC.Size = new System.Drawing.Size(385, 142);
            this.pictureBoxC.TabIndex = 12;
            this.pictureBoxC.TabStop = false;
            this.pictureBoxC.Visible = false;
            // 
            // pictureBoxS
            // 
            this.pictureBoxS.BackgroundImage = global::SysCisepro3.Properties.Resources.SeportPac_Wall;
            this.pictureBoxS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxS.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxS.Name = "pictureBoxS";
            this.pictureBoxS.Size = new System.Drawing.Size(385, 142);
            this.pictureBoxS.TabIndex = 13;
            this.pictureBoxS.TabStop = false;
            this.pictureBoxS.Visible = false;
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxA.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(385, 142);
            this.pictureBoxA.TabIndex = 14;
            this.pictureBoxA.TabStop = false;
            this.pictureBoxA.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 242);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.cbLogin);
            this.Controls.Add(this.pictureBoxC);
            this.Controls.Add(this.pictureBoxS);
            this.Controls.Add(this.pictureBoxA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CISEPRO - LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLoginCisepro_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label lblLogin;
        internal System.Windows.Forms.ComboBox cbLogin;
        internal System.Windows.Forms.PictureBox pictureBoxC;
        internal System.Windows.Forms.PictureBox pictureBoxS;
        internal System.Windows.Forms.PictureBox pictureBoxA;
    }
}