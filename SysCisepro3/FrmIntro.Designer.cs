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
            this.btnContinuar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbs = new System.Windows.Forms.ProgressBar();
            this.lblNombreSistema = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDerechos = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.Image = global::SysCisepro3.Properties.Resources.Cisepro_Wall;
            this.pbxLogo.Location = new System.Drawing.Point(201, 63);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(117, 130);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(211, 210);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(98, 39);
            this.btnContinuar.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnContinuar.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnContinuar.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnContinuar.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnContinuar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnContinuar.StateCommon.Border.Rounding = 20;
            this.btnContinuar.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnContinuar.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnContinuar.TabIndex = 42;
            this.btnContinuar.Values.Text = "Continuar";
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbs
            // 
            this.pbs.Location = new System.Drawing.Point(327, 267);
            this.pbs.Name = "pbs";
            this.pbs.Size = new System.Drawing.Size(100, 23);
            this.pbs.TabIndex = 43;
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.AutoSize = false;
            this.lblNombreSistema.Location = new System.Drawing.Point(171, 4);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(244, 53);
            this.lblNombreSistema.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblNombreSistema.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.lblNombreSistema.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSistema.TabIndex = 45;
            this.lblNombreSistema.Values.Text = "";
            // 
            // lblDerechos
            // 
            this.lblDerechos.AutoSize = false;
            this.lblDerechos.Location = new System.Drawing.Point(297, 255);
            this.lblDerechos.Name = "lblDerechos";
            this.lblDerechos.Size = new System.Drawing.Size(223, 42);
            this.lblDerechos.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.lblDerechos.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.lblDerechos.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerechos.TabIndex = 46;
            this.lblDerechos.Values.Text = "     ";
            // 
            // FrmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 302);
            this.Controls.Add(this.lblDerechos);
            this.Controls.Add(this.lblNombreSistema);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.pbs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 20;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20;
            this.Text = "FrmIntro";
            this.Load += new System.EventHandler(this.FrmIntro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxLogo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnContinuar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbs;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNombreSistema;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDerechos;
    }
}