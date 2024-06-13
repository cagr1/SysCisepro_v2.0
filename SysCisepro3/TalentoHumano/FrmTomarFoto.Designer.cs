namespace SysCisepro3.TalentoHumano
{
    partial class FrmTomarFoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTomarFoto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.ButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.wcCapturar = new WebCAM.WebCam();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnAbrirFrontal = new System.Windows.Forms.Button();
            this.pbFotoCortadaFrontal = new System.Windows.Forms.PictureBox();
            this.btn180 = new System.Windows.Forms.Button();
            this.btn90 = new System.Windows.Forms.Button();
            this.btnVertical = new System.Windows.Forms.Button();
            this.btnHorizontal = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnAbrirPerfil = new System.Windows.Forms.Button();
            this.pbFotoCortadaPerfil = new System.Windows.Forms.PictureBox();
            this.btn180Perfil = new System.Windows.Forms.Button();
            this.btn90Perfil = new System.Windows.Forms.Button();
            this.btnVerticalPerfil = new System.Windows.Forms.Button();
            this.btnHorizontalPerfil = new System.Windows.Forms.Button();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.ofdAbrirImagen = new System.Windows.Forms.OpenFileDialog();
            this.videoSourceFoto = new AForge.Controls.VideoSourcePlayer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCortadaFrontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCortadaPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscar,
            this.ButtonCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(916, 31);
            this.toolStrip1.TabIndex = 216;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::SysCisepro3.Properties.Resources.photo_camera_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 28);
            this.btnBuscar.Text = "ACTIVAR ";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ButtonCancelar.Image = global::SysCisepro3.Properties.Resources.check_circle_24dp_FILL0_wght400_GRAD0_opsz24__3_;
            this.ButtonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(84, 28);
            this.ButtonCancelar.Text = "ACEPTAR";
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // wcCapturar
            // 
            this.wcCapturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wcCapturar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wcCapturar.Imagen = ((System.Drawing.Image)(resources.GetObject("wcCapturar.Imagen")));
            this.wcCapturar.Location = new System.Drawing.Point(10, 33);
            this.wcCapturar.MilisegundosCaptura = 100;
            this.wcCapturar.Name = "wcCapturar";
            this.wcCapturar.Size = new System.Drawing.Size(269, 222);
            this.wcCapturar.TabIndex = 217;
            this.wcCapturar.Visible = false;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Image = global::SysCisepro3.Properties.Resources.add_a_photo_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(481, 294);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(88, 29);
            this.btnPerfil.TabIndex = 219;
            this.btnPerfil.Text = "PERFIL";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Image = global::SysCisepro3.Properties.Resources.add_a_photo_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnCapturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapturar.Location = new System.Drawing.Point(342, 294);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(88, 29);
            this.btnCapturar.TabIndex = 218;
            this.btnCapturar.Text = "FRONTAL";
            this.btnCapturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Image = global::SysCisepro3.Properties.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24;
            this.Button1.Location = new System.Drawing.Point(247, 608);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(44, 38);
            this.Button1.TabIndex = 232;
            this.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.Button1, "Eliminar");
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 330);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 13);
            this.Label1.TabIndex = 231;
            this.Label1.Text = "FRONTAL";
            // 
            // btnAbrirFrontal
            // 
            this.btnAbrirFrontal.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirFrontal.Image = global::SysCisepro3.Properties.Resources.folder_open_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.btnAbrirFrontal.Location = new System.Drawing.Point(32, 608);
            this.btnAbrirFrontal.Name = "btnAbrirFrontal";
            this.btnAbrirFrontal.Size = new System.Drawing.Size(44, 38);
            this.btnAbrirFrontal.TabIndex = 230;
            this.btnAbrirFrontal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnAbrirFrontal, "Abrir");
            this.btnAbrirFrontal.UseVisualStyleBackColor = true;
            this.btnAbrirFrontal.Click += new System.EventHandler(this.btnAbrirFrontal_Click);
            // 
            // pbFotoCortadaFrontal
            // 
            this.pbFotoCortadaFrontal.BackColor = System.Drawing.Color.White;
            this.pbFotoCortadaFrontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoCortadaFrontal.Location = new System.Drawing.Point(314, 327);
            this.pbFotoCortadaFrontal.Name = "pbFotoCortadaFrontal";
            this.pbFotoCortadaFrontal.Size = new System.Drawing.Size(140, 160);
            this.pbFotoCortadaFrontal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoCortadaFrontal.TabIndex = 225;
            this.pbFotoCortadaFrontal.TabStop = false;
            // 
            // btn180
            // 
            this.btn180.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn180.Image = global::SysCisepro3.Properties.Resources.rotate_left_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btn180.Location = new System.Drawing.Point(204, 608);
            this.btn180.Name = "btn180";
            this.btn180.Size = new System.Drawing.Size(44, 38);
            this.btn180.TabIndex = 224;
            this.btn180.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn180, "Giro 180");
            this.btn180.UseVisualStyleBackColor = true;
            this.btn180.Click += new System.EventHandler(this.btn180_Click);
            // 
            // btn90
            // 
            this.btn90.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn90.Image = global::SysCisepro3.Properties.Resources.rotate_right_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btn90.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn90.Location = new System.Drawing.Point(161, 608);
            this.btn90.Name = "btn90";
            this.btn90.Size = new System.Drawing.Size(44, 38);
            this.btn90.TabIndex = 223;
            this.btn90.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn90, "Giro 90");
            this.btn90.UseVisualStyleBackColor = true;
            this.btn90.Click += new System.EventHandler(this.btn90_Click);
            // 
            // btnVertical
            // 
            this.btnVertical.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVertical.Image = global::SysCisepro3.Properties.Resources.align_vertical_bottom_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnVertical.Location = new System.Drawing.Point(75, 608);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(44, 38);
            this.btnVertical.TabIndex = 222;
            this.btnVertical.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnVertical, "Vertical");
            this.btnVertical.UseVisualStyleBackColor = true;
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorizontal.Image = global::SysCisepro3.Properties.Resources.align_horizontal_right_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnHorizontal.Location = new System.Drawing.Point(118, 608);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(44, 38);
            this.btnHorizontal.TabIndex = 221;
            this.btnHorizontal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnHorizontal, "Horizontal");
            this.btnHorizontal.UseVisualStyleBackColor = true;
            this.btnHorizontal.Click += new System.EventHandler(this.btnHorizontal_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.White;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(10, 327);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(301, 280);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 220;
            this.pbFoto.TabStop = false;
            this.pbFoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFoto_MouseMove);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = global::SysCisepro3.Properties.Resources.cancel_24dp_FILL0_wght400_GRAD0_opsz24;
            this.Button2.Location = new System.Drawing.Point(842, 608);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(44, 38);
            this.Button2.TabIndex = 245;
            this.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.Button2, "Eliminar");
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(606, 330);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 13);
            this.Label2.TabIndex = 244;
            this.Label2.Text = "PERFIL";
            // 
            // btnAbrirPerfil
            // 
            this.btnAbrirPerfil.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPerfil.Image = global::SysCisepro3.Properties.Resources.folder_open_24dp_FILL0_wght400_GRAD0_opsz24__2_;
            this.btnAbrirPerfil.Location = new System.Drawing.Point(627, 608);
            this.btnAbrirPerfil.Name = "btnAbrirPerfil";
            this.btnAbrirPerfil.Size = new System.Drawing.Size(44, 38);
            this.btnAbrirPerfil.TabIndex = 243;
            this.btnAbrirPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnAbrirPerfil, "Abrir");
            this.btnAbrirPerfil.UseVisualStyleBackColor = true;
            this.btnAbrirPerfil.Click += new System.EventHandler(this.btnAbrirPerfil_Click);
            // 
            // pbFotoCortadaPerfil
            // 
            this.pbFotoCortadaPerfil.BackColor = System.Drawing.Color.White;
            this.pbFotoCortadaPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoCortadaPerfil.Location = new System.Drawing.Point(460, 327);
            this.pbFotoCortadaPerfil.Name = "pbFotoCortadaPerfil";
            this.pbFotoCortadaPerfil.Size = new System.Drawing.Size(140, 160);
            this.pbFotoCortadaPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoCortadaPerfil.TabIndex = 238;
            this.pbFotoCortadaPerfil.TabStop = false;
            // 
            // btn180Perfil
            // 
            this.btn180Perfil.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn180Perfil.Image = global::SysCisepro3.Properties.Resources.rotate_left_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btn180Perfil.Location = new System.Drawing.Point(799, 608);
            this.btn180Perfil.Name = "btn180Perfil";
            this.btn180Perfil.Size = new System.Drawing.Size(44, 38);
            this.btn180Perfil.TabIndex = 237;
            this.btn180Perfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn180Perfil, "Giro 180");
            this.btn180Perfil.UseVisualStyleBackColor = true;
            this.btn180Perfil.Click += new System.EventHandler(this.btn180Perfil_Click);
            // 
            // btn90Perfil
            // 
            this.btn90Perfil.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn90Perfil.Image = global::SysCisepro3.Properties.Resources.rotate_right_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btn90Perfil.Location = new System.Drawing.Point(756, 608);
            this.btn90Perfil.Name = "btn90Perfil";
            this.btn90Perfil.Size = new System.Drawing.Size(44, 38);
            this.btn90Perfil.TabIndex = 236;
            this.btn90Perfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn90Perfil, "Giro 90");
            this.btn90Perfil.UseVisualStyleBackColor = true;
            this.btn90Perfil.Click += new System.EventHandler(this.btn90Perfil_Click);
            // 
            // btnVerticalPerfil
            // 
            this.btnVerticalPerfil.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerticalPerfil.Image = global::SysCisepro3.Properties.Resources.align_vertical_bottom_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnVerticalPerfil.Location = new System.Drawing.Point(670, 608);
            this.btnVerticalPerfil.Name = "btnVerticalPerfil";
            this.btnVerticalPerfil.Size = new System.Drawing.Size(44, 38);
            this.btnVerticalPerfil.TabIndex = 235;
            this.btnVerticalPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnVerticalPerfil, "Vertical");
            this.btnVerticalPerfil.UseVisualStyleBackColor = true;
            this.btnVerticalPerfil.Click += new System.EventHandler(this.btnVerticalPerfil_Click);
            // 
            // btnHorizontalPerfil
            // 
            this.btnHorizontalPerfil.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorizontalPerfil.Image = global::SysCisepro3.Properties.Resources.align_horizontal_right_24dp_FILL0_wght400_GRAD0_opsz24;
            this.btnHorizontalPerfil.Location = new System.Drawing.Point(713, 608);
            this.btnHorizontalPerfil.Name = "btnHorizontalPerfil";
            this.btnHorizontalPerfil.Size = new System.Drawing.Size(44, 38);
            this.btnHorizontalPerfil.TabIndex = 234;
            this.btnHorizontalPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnHorizontalPerfil, "Horizontal");
            this.btnHorizontalPerfil.UseVisualStyleBackColor = true;
            this.btnHorizontalPerfil.Click += new System.EventHandler(this.btnHorizontalPerfil_Click);
            // 
            // pbPerfil
            // 
            this.pbPerfil.BackColor = System.Drawing.Color.White;
            this.pbPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPerfil.Location = new System.Drawing.Point(603, 327);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(301, 280);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerfil.TabIndex = 233;
            this.pbPerfil.TabStop = false;
            this.pbPerfil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPerfil_MouseMove);
            // 
            // ofdAbrirImagen
            // 
            this.ofdAbrirImagen.FileName = "ofdCargarFoto";
            // 
            // videoSourceFoto
            // 
            this.videoSourceFoto.Location = new System.Drawing.Point(300, 33);
            this.videoSourceFoto.Name = "videoSourceFoto";
            this.videoSourceFoto.Size = new System.Drawing.Size(320, 258);
            this.videoSourceFoto.TabIndex = 246;
            this.videoSourceFoto.Text = "videoSourcePlayer1";
            this.videoSourceFoto.VideoSource = null;
            // 
            // FrmTomarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 651);
            this.Controls.Add(this.videoSourceFoto);
            this.Controls.Add(this.pbPerfil);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnAbrirPerfil);
            this.Controls.Add(this.pbFotoCortadaPerfil);
            this.Controls.Add(this.btn180Perfil);
            this.Controls.Add(this.btn90Perfil);
            this.Controls.Add(this.btnVerticalPerfil);
            this.Controls.Add(this.btnHorizontalPerfil);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnAbrirFrontal);
            this.Controls.Add(this.pbFotoCortadaFrontal);
            this.Controls.Add(this.btn180);
            this.Controls.Add(this.btn90);
            this.Controls.Add(this.btnVertical);
            this.Controls.Add(this.btnHorizontal);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.wcCapturar);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmTomarFoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 5F;
            this.Text = "CAPTURAR FOTO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTomarFoto_FormClosing);
            this.Load += new System.EventHandler(this.FrmTomarFoto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCortadaFrontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCortadaPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton ButtonCancelar;
        internal WebCAM.WebCam wcCapturar;
        internal System.Windows.Forms.Button btnPerfil;
        internal System.Windows.Forms.Button btnCapturar;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnAbrirFrontal;
        internal System.Windows.Forms.PictureBox pbFotoCortadaFrontal;
        internal System.Windows.Forms.Button btn180;
        internal System.Windows.Forms.Button btn90;
        internal System.Windows.Forms.Button btnVertical;
        internal System.Windows.Forms.Button btnHorizontal;
        internal System.Windows.Forms.PictureBox pbFoto;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnAbrirPerfil;
        internal System.Windows.Forms.PictureBox pbFotoCortadaPerfil;
        internal System.Windows.Forms.Button btn180Perfil;
        internal System.Windows.Forms.Button btn90Perfil;
        internal System.Windows.Forms.Button btnVerticalPerfil;
        internal System.Windows.Forms.Button btnHorizontalPerfil;
        internal System.Windows.Forms.PictureBox pbPerfil;
        internal System.Windows.Forms.OpenFileDialog ofdAbrirImagen;
        private AForge.Controls.VideoSourcePlayer videoSourceFoto;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}