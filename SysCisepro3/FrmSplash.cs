using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using SysCisepro3.Main;
using SysCisepro3.Properties;
using ClassLibraryCisepro3.UsuarioGeneral;

namespace SysCisepro3
{
    public partial class FrmSplash : Form
    {
        private readonly TipoConexion _tipoCon; // TIPO DE CONEXION (CISEPRO, SEPORTAPC, ASERNAVA)
        private readonly int _tiempoNotificacion; // TIEMPO PARA NOTIFICACION

        private FrmLogin _loginForm;
        private FrmNewLogin _newLoginForm;

        public FrmSplash(TipoConexion tipoCon, int tiempoNotificacion)
        {
            InitializeComponent();
            _tipoCon = tipoCon;
            _tiempoNotificacion = tiempoNotificacion;
        }

        // CARGA LOS ESTILOS VISUALES SEGUN CISEPRO, SEPORTAPC, ASERNAVA
        private void FrmSplash_Load(object sender, EventArgs e)
        {
            lbNombreSistema.Text = Validaciones.NombreCompany(_tipoCon) + @" 2020";
            Text = Validaciones.NombreCompany(_tipoCon);
            switch (_tipoCon)
            {
                case TipoConexion.Seportpac:
                    Icon = Resources.logo_s;
                    BackColor =  Settings.Default.ColorSeportpac;
                    BackgroundImage =  Resources.SeportPac_Wall;
                    lbNombreSistema.ForeColor = Color.DarkBlue;
                    lblDerechos.ForeColor = Color.DarkBlue;
                    btnContinuar.ForeColor = Color.DarkBlue;
                    btnContinuar.FlatAppearance.MouseDownBackColor = Color.Gold;
                    btnContinuar.FlatAppearance.MouseOverBackColor = Color.Gold;
                    break;
                case TipoConexion.Asenava:
                    Icon = Resources.logo_a;
                    BackColor = Settings.Default.ColorAsenava;
                    BackgroundImage = null;
                    lbNombreSistema.ForeColor = Color.White;
                    lblDerechos.ForeColor = Color.White;
                    btnContinuar.ForeColor = Color.White; 
                    btnContinuar.FlatAppearance.MouseDownBackColor = Color.Black;
                    btnContinuar.FlatAppearance.MouseOverBackColor = Color.Black;
                    break;
                default: // CISEPRO
                    Icon = Resources.logo_c;
                    BackColor = Settings.Default.ColorCisepro;
                    BackgroundImage = Resources.Cisepro_Wall;
                    lbNombreSistema.ForeColor = Color.Gold;
                    lblDerechos.ForeColor = Color.Gold;
                    btnContinuar.ForeColor = Color.Gold;  
                    btnContinuar.FlatAppearance.MouseDownBackColor = Color.Red;
                    btnContinuar.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;
            }
             
            BackgroundImageLayout = ImageLayout.Zoom;
 
            Refresh();
            timer1.Start(); // INICIA TEMPORIZADOR PARA NOTIFICACIONES (CADA 10 MINUTOS)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbs.Value >= 100)
            {
                Opacity = 100;
                timer1.Stop();
                lblDerechos.Visible = true;
                lbNombreSistema.Visible = true;
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
    }
}