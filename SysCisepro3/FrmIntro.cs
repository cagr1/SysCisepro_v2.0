using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using SysCisepro3.Main;
using SysCisepro3.Properties;
using ClassLibraryCisepro3.UsuarioGeneral;
using ComponentFactory.Krypton.Toolkit;

namespace SysCisepro3
{
    public partial class FrmIntro : KryptonForm
    {
        private readonly TipoConexion _tipoCon; // TIPO DE CONEXION (CISEPRO, SEPORTAPC, ASERNAVA)
        private readonly int _tiempoNotificacion; // TIEMPO PARA NOTIFICACION

        private FrmLogin _loginForm;
        private FrmNewLogin _newLoginForm;
        
        public FrmIntro(TipoConexion tipoCon, int tiempoNotificacion)
        {
            InitializeComponent();
            _tipoCon = tipoCon;
            _tiempoNotificacion = tiempoNotificacion;
        }

        private void FrmIntro_Load(object sender, EventArgs e)
        {
            lblNombreSistema.Text = Validaciones.NombreCompany(_tipoCon) + " " + DateTime.Now.Year.ToString();
            lblDerechos.Text = "Todos los derechos reservados © " + DateTime.Now.Year.ToString();
            Text = Validaciones.NombreCompany(_tipoCon);
            switch (_tipoCon)
            {
                case TipoConexion.Seportpac:
                    Icon = Resources.logo_s;
                    //BackColor = Settings.Default.Color;
                    BackgroundImage = Resources.background_6795625_1280;
                    //BackgroundImageLayout = ImageLayout.Stretch;
                    pbxLogo.Image = Resources.SeportPac_Wall;
                    //btnContinuar.FlatAppearance.MouseDownBackColor = Color.Gold;
                    //btnContinuar.FlatAppearance.MouseOverBackColor = Color.Gold;
                    break;
                case TipoConexion.Asenava:
                    Icon = Resources.logo_a;
                    //BackColor = Settings.Default.ColorAsenava;
                    //BackgroundImage = null;
                    pbxLogo.Image = null;
                    break;
                default: // CISEPRO
                    Icon = Resources.logo_c;
                    BackgroundImage = Resources.background_6795625_1280;
                    //BackgroundImageLayout = ImageLayout.None;
                    //BackColor = Settings.Default.ColorCisepro;

                    //btnContinuar.ForeColor = Color.Gold;
                    //btnContinuar.FlatAppearance.MouseDownBackColor = Color.Red;
                    //btnContinuar.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;
            }

            //BackgroundImageLayout = ImageLayout.Zoom;

            Refresh();

        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbs.Value >= 50)
            {
                Opacity = 100;
                timer1.Stop();
                lblDerechos.Visible = true;
                lblNombreSistema.Visible = true;
                btnContinuar.Visible = true;
            }
            else
            {
                pbs.Value += 5;
                Opacity += 0.015;
                Width = pbs.Value * 5;
                Height = pbs.Value * 2;
                CenterToScreen();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Hide();
            //_loginForm = new FrmLogin { TipoCon = _tipoCon, TiempoNotificacion = _tiempoNotificacion };
            //_loginForm.Show();

            _newLoginForm = new FrmNewLogin();
            _newLoginForm.Show();
        }

        private void lblDerechos_Click(object sender, EventArgs e)
        {

        }

        private void lblDerechos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
