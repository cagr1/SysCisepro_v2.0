using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using MaterialSkin;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using System.Web.UI.WebControls;

namespace SysCisepro3.Main
{
    public partial class FrmNewLogin2 : KryptonForm
    {
        public TipoConexion TipoCon { private get; set; }
        public int TiempoNotificacion { private get; set; }

        private readonly ClassUsuarioGeneral _objUsuario;

        private MdiParentMain _formMenu;
        private MdiParentMonitoreo _formMenuMonitoreo;

        public FrmNewLogin2()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.Blue700, TextShade.WHITE);
            _objUsuario = new ClassUsuarioGeneral();
            
        }

        private void FrmNewLogin2_Load(object sender, EventArgs e)
        {
            CargarSisitema();
            
        }

        public void CargarSisitema()
        {
            // DEFINIR TIPO SISTEMA     
            Text = Validaciones.NombreCompany(TipoCon) + @" - LOGIN";
            switch (TipoCon)
            {
                case TipoConexion.Seportpac:
                    Icon = Resources.logo_s;
                    pbxCisepro.Image = Resources.SeportPac_Wall;
                    //pictureBoxS.BackColor = Settings.Default.ColorSeportpac;
                    //pictureBoxS.Visible = true;
                    //pictureBoxC.Visible = false;
                    //pictureBoxA.Visible = false;
                    break;
                case TipoConexion.Asenava:
                    Icon = Resources.logo_a;
                    pbxCisepro.BackColor = Settings.Default.ColorSeportpac;
                    //pictureBoxA.BackColor = Settings.Default.ColorAsenava;
                    //pictureBoxS.Visible = false;
                    //pictureBoxC.Visible = false;
                    //pictureBoxA.Visible = true;
                    break;
                default: // CISEPRO
                    Icon = Resources.logo_c;
                    pbxCisepro.Image = Resources.Cisepro_Wall;
                    //pictureBoxC.BackColor = Settings.Default.ColorCisepro;
                    //pictureBoxS.Visible = false;
                    pbxCisepro.Visible = true;
                    //pictureBoxA.Visible = false;
                    break;
            }




            // CARGAR USUARIOS DEL SISTEMA
            try
            {
                cbxUser.DataSource = _objUsuario.SeleccionarUsuariosGeneral(TipoCon);
                cbxUser.DisplayMember = "login";
                cbxUser.ValueMember = "login";

                // DEFINIR USUARIO POR DEFECTO
                if (string.IsNullOrEmpty(Settings.Default.Usuario)) cbxUser.SelectedIndex = 0;
                else cbxUser.SelectedValue = Settings.Default.Usuario;
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(@"Error al iniciar: " + ex.Message, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }


           
        }

        private void FrmNewLogin2_FormClosing(object sender, FormClosingEventArgs e)
        {
            _objUsuario.SalirSistema(TipoCon);
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;
            btnLogin_Click(null, null);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var u = _objUsuario.BuscarUsuarioPorLogin(TipoCon, cbxUser.SelectedValue.ToString(), txtPassword.Text);

            if (u == null || !u.Password.Equals(txtPassword.Text)) // CLAVE DEBE COINCIDER EN MAYÚSCULAS Y/O MINÚSCULAS
            {
                txtPassword.Clear();
                KryptonMessageBox.Show(@"La contraseña ingresada es incorrecta!", @"Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            // SE DEFINE USUARIO POR DEFECTO
            Settings.Default.Usuario = cbxUser.SelectedValue.ToString();
            Settings.Default.Save();

            if (u.TipoUsuario.Contains("MONITOREO") || u.TipoUsuario.Contains("OPERACIONES"))
            {
                // FORMULARIO MENU OPERACIONES - MONITOREO
                _formMenuMonitoreo = new MdiParentMonitoreo
                {
                    ObjUsuario = u,
                    TiempoNotificacion = TiempoNotificacion
                };

                _formMenuMonitoreo.Show();
            }
            else
            {
                // FORMULARIO MENU PRINCIPAL
                _formMenu = new MdiParentMain
                {
                    TipoCon = TipoCon,
                    ObjUsuario = u,
                    TiempoNotificacion = TiempoNotificacion,
                    _frmNewLogin = this
                };
                _formMenu.Show();

            }

            this.DialogResult = DialogResult.OK;
            Hide();
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
