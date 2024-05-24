using System;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using AForge.Video.DirectShow;
using System.IO;
using System.Drawing;
using System.Diagnostics;




namespace SysCisepro3.TalentoHumano
{
    public partial class FrmTomarFoto : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para tomar foto del registro del personal
        /// </summary>
        /// 

        public static TipoConexion TipoCon { get; set; }
        private VideoCaptureDevice videoSource;
        public int _idFoto = 0;
        
            




        public FrmTomarFoto()
        {
            InitializeComponent();
        }

        private void FrmTomarFoto_Load(object sender, EventArgs e)
        {
            toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White; 
            switch (TipoCon)
            {
                case TipoConexion.Seportpac:
                    Icon = Resources.logo_s;
                    break;
                case TipoConexion.Asenava:
                    Icon = Resources.logo_a;
                    break;
                default: // CISEPRO
                    Icon = Resources.logo_c;
                    break;
            }

            
        }

        private void FrmTomarFoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            wcCapturar.Stop();
            videoSourceFoto.Stop();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                StartCamera();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            wcCapturar.Stop();
            videoSourceFoto.Stop();
            DialogResult = DialogResult.OK;

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            //pbFoto.Image = wcCapturar.Imagen;
            //pbFotoCortadaFrontal.Image = wcCapturar.Imagen;

             Bitmap capturaImage = videoSourceFoto.GetCurrentVideoFrame();
             String path = Path.Combine(Application.StartupPath + "\\Leer XML Temp\\foto.png");
              capturaImage.Save(path, System.Drawing.Imaging.ImageFormat.Png);
            _idFoto = 1;

            if (capturaImage != null)
            {
                RemoveBackground();
               String output = Path.Combine(Application.StartupPath + "\\Leer XML Temp\\foto_no_bg.png");
                if (File.Exists(output))
                {
                   using( Image outputImage = Image.FromFile(output))
                    {
                        pbFoto.Image = new Bitmap(outputImage);
                        pbFotoCortadaFrontal.Image = new Bitmap(outputImage);
                    }
                    
                }
                else
                { 
                MessageBox.Show("No se pudo cargar la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


               
                
            }

            
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

            Bitmap capturaImage2 = videoSourceFoto.GetCurrentVideoFrame();
            String path = Path.Combine(Application.StartupPath + "\\Leer XML Temp\\FotoPerfil.png");
            capturaImage2.Save(path, System.Drawing.Imaging.ImageFormat.Png);

            _idFoto = 2;
            if (capturaImage2 != null)
            {
                RemoveBackground();



                String output = Path.Combine(Application.StartupPath + "\\Leer XML Temp\\fotoPerfil_no_bg.png");
                if (File.Exists(output))
                {
                    using (Image outputImage = Image.FromFile(output))
                    {
                        pbPerfil.Image = new Bitmap(outputImage);
                        pbFotoCortadaPerfil.Image = new Bitmap(outputImage);
                    }

                }

                else
                {
                    MessageBox.Show("No se pudo cargar la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                                
               
            }
            
        }

        private void btnAbrirFrontal_Click(object sender, EventArgs e)
        {
            if (ofdAbrirImagen.ShowDialog() != DialogResult.OK) return;
            pbFoto.Image = Image.FromFile(ofdAbrirImagen.FileName);
            pbFotoCortadaFrontal.Image = Image.FromFile(ofdAbrirImagen.FileName);
        }

        private void btnAbrirPerfil_Click(object sender, EventArgs e)
        {
            if (ofdAbrirImagen.ShowDialog() != DialogResult.OK) return;
            pbPerfil.Image = System.Drawing.Image.FromFile(ofdAbrirImagen.FileName);
            pbFotoCortadaPerfil.Image = Image.FromFile(ofdAbrirImagen.FileName);
        }

        private void btnVertical_Click(object sender, EventArgs e)
        {
            if (pbFoto.Image == null) return;
            pbFoto.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pbFoto.Refresh();
        }

        private void btnVerticalPerfil_Click(object sender, EventArgs e)
        {
            if (pbPerfil.Image == null) return;
            pbPerfil.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pbPerfil.Refresh();
        }

        private void btnHorizontal_Click(object sender, EventArgs e)
        {
            if (pbFoto.Image == null) return;
            pbFoto.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pbFoto.Refresh();
        }

        private void btnHorizontalPerfil_Click(object sender, EventArgs e)
        {
            if (pbPerfil.Image == null) return;
            pbPerfil.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pbPerfil.Refresh();
        }

        private void btn90_Click(object sender, EventArgs e)
        {
            if (pbFoto.Image == null) return;
            pbFoto.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            pbFoto.Refresh();
        }

        private void btn90Perfil_Click(object sender, EventArgs e)
        {
            if (pbPerfil.Image == null) return;
            pbPerfil.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            pbPerfil.Refresh();
        }

        private void btn180_Click(object sender, EventArgs e)
        {
            if (pbFoto.Image == null) return;
            pbFoto.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            pbFoto.Refresh();
        }

        private void btn180Perfil_Click(object sender, EventArgs e)
        {
            if (pbPerfil.Image == null) return;
            pbPerfil.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            pbPerfil.Refresh();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pbFoto.Image = Resources._default;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pbPerfil.Image = Resources._default;
        }
         

        private void pbFoto_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Bitmap cropImage = new Bitmap(pbFotoCortadaFrontal.Width, pbFotoCortadaFrontal.Height);
            try
            { 
                Rectangle cropRect = new Rectangle(e.X, e.Y, pbFotoCortadaFrontal.Width, pbFotoCortadaFrontal.Height);
                using (Graphics g = Graphics.FromImage(cropImage))
                {
                    g.DrawImage(pbFoto.Image, 0,0,cropRect,GraphicsUnit.Millimeter);
                }

                pbFotoCortadaFrontal.Image = cropImage;


            }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Surgio un Error, faltan elegir las coordenadas!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

           
        }

        private void pbPerfil_MouseMove(object sender, MouseEventArgs e)
        { 
            if (e.Button != MouseButtons.Left) return;
           
            Bitmap cropImage = new Bitmap(pbFotoCortadaPerfil.Width, pbFotoCortadaPerfil.Height);
            try
            {
                Rectangle cropRect = new Rectangle(e.X, e.Y, pbFotoCortadaPerfil.Width, pbFotoCortadaPerfil.Height);
                using (Graphics g = Graphics.FromImage(cropImage))
                {
                    g.DrawImage(pbFoto.Image, 0, 0, cropRect, GraphicsUnit.Millimeter);
                }

                pbFotoCortadaPerfil.Image = cropImage;
            }
            catch
            {
                MessageBox.Show(@"Surgio un Error, faltan elegir las coordenadas!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void RemoveBackground()
        {
                                               
            string fotoBash = Path.Combine(Application.StartupPath, @"Leer XML Temp\foto.sh");
            string fotoPerfilBash = Path.Combine(Application.StartupPath, @"Leer XML Temp\fotoPerfil.sh");
            string gitBash = @"C:\Program Files\Git\git-bash.exe";
            try


            {
                
                if (_idFoto == 1 )
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = gitBash;
                        process.StartInfo.Arguments = $"\"{fotoBash}\"";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.Start();                                      

                    }

                }

                if (_idFoto == 2)
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = gitBash;
                        process.StartInfo.Arguments = $"\"{fotoPerfilBash}\"";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.Start();
                 
                    }
                }
                                    


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error running Python script: " + ex.Message);
            }


        }
                      

        private void StartCamera()
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video devices found.");
                return;
            }

            
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSourceFoto.VideoSource = videoSource;
            videoSourceFoto.Start();
        }

        

       
    }
}