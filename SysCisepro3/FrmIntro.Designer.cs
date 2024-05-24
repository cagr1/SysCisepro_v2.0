namespace SysCisepro3
{
    partial class FrmIntro
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
            this.components = new System.ComponentModel.Container();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblDerechos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbs = new System.Windows.Forms.ProgressBar();
            this.btnContinuar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbNombreSistema = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImage = global::SysCisepro3.Properties.Resources.cisepro;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(166, 44);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(112, 109);
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // lblDerechos
            // 
            this.lblDerechos.BackColor = System.Drawing.Color.Transparent;
            this.lblDerechos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerechos.ForeColor = System.Drawing.Color.White;
            this.lblDerechos.Location = new System.Drawing.Point(12, 174);
            this.lblDerechos.Name = "lblDerechos";
            this.lblDerechos.Size = new System.Drawing.Size(238, 41);
            this.lblDerechos.TabIndex = 41;
            this.lblDerechos.Text = "                     Copyright © 2020 \r\nTodos los derechos reservados";
            this.lblDerechos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbs
            // 
            this.pbs.BackColor = System.Drawing.Color.White;
            this.pbs.Location = new System.Drawing.Point(101, 179);
            this.pbs.Name = "pbs";
            this.pbs.Size = new System.Drawing.Size(90, 23);
            this.pbs.TabIndex = 45;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(316, 174);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnContinuar.Size = new System.Drawing.Size(112, 41);
            this.btnContinuar.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnContinuar.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnContinuar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContinuar.StateCommon.Border.Rounding = 20;
            this.btnContinuar.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnContinuar.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnContinuar.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContinuar.StateNormal.Border.Rounding = 20;
            this.btnContinuar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContinuar.StateTracking.Border.Rounding = 20;
            this.btnContinuar.TabIndex = 47;
            this.btnContinuar.Values.Text = "Continuar";
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lbNombreSistema
            // 
            this.lbNombreSistema.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNombreSistema.ForeColor = System.Drawing.Color.White;
            this.lbNombreSistema.Location = new System.Drawing.Point(324, 18);
            this.lbNombreSistema.Name = "lbNombreSistema";
            this.lbNombreSistema.Size = new System.Drawing.Size(154, 71);
            this.lbNombreSistema.TabIndex = 46;
            this.lbNombreSistema.Text = "label1";
            // 
            // FrmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(21)))), ((int)(((byte)(115)))));
            this.BackgroundImage = global::SysCisepro3.Properties.Resources.background_6795625_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 273);
            this.Controls.Add(this.lblDerechos);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lbNombreSistema);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.pbs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 30;
            this.StateActive.Border.Width = 0;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20;
            this.StateCommon.Border.Width = 0;
            this.Text = "FrmIntro";
            this.Load += new System.EventHandler(this.FrmIntro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblDerechos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbs;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnContinuar;
        private System.Windows.Forms.Label lbNombreSistema;
    }
}