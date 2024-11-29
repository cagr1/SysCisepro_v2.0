using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using SysCisepro3.Properties;

namespace SysCisepro3.Main
{
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// LOGIN
        /// </summary>
        public TipoConexion TipoCon { private get; set; }
        public int TiempoNotificacion { private get; set; }

        private readonly ClassUsuarioGeneral _objUsuario; 
        
        private MdiParentMain _formMenu;
        private MdiParentMonitoreo _formMenuMonitoreo;
        
        public FrmLogin()
        {
            InitializeComponent();
            _objUsuario = new ClassUsuarioGeneral();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        { 
            // BUSCAR DATOS DEL USUSARIO
            var u = _objUsuario.BuscarUsuarioPorLogin(TipoCon, cbLogin.SelectedValue.ToString(), txtPassword.Text);

            if (u == null || !u.Password.Equals(txtPassword.Text)) // CLAVE DEBE COINCIDER EN MAYÚSCULAS Y/O MINÚSCULAS
            {
                txtPassword.Clear();
                MessageBox.Show(@"La contraseña ingresada es incorrecta!", @"Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // SE DEFINE USUARIO POR DEFECTO
            Settings.Default.Usuario = cbLogin.SelectedValue.ToString();
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
                    _frmLogin = this
                };
                _formMenu.Show();

            }
           
            this.DialogResult = DialogResult.OK;
            Hide();
        }
         
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;
            btnAceptar_Click(null, null);
        }

        private void FrmLoginCisepro_FormClosing(object sender, FormClosingEventArgs e)
        {
            // CERRAR CONEXION EXISTENTE
            _objUsuario.SalirSistema(TipoCon);
            Application.Exit();
        }

        // CARGA LOS ESTILOS VISUALES SEGUN CISEPRO, SEPORTAPC, ASERNAVA
        private void FrmLogin_Load(object sender, EventArgs e)
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
                    pictureBoxS.BackColor = Settings.Default.ColorSeportpac;
                    pictureBoxS.Visible = true;
                    pictureBoxC.Visible = false;
                    pictureBoxA.Visible = false;
                    break;
                case TipoConexion.Asenava:
                    Icon = Resources.logo_a;
                    pictureBoxA.BackColor = Settings.Default.ColorAsenava;
                    pictureBoxS.Visible = false;
                    pictureBoxC.Visible = false;
                    pictureBoxA.Visible = true;
                    break;
                default: // CISEPRO
                    Icon = Resources.logo_c;
                    pictureBoxC.BackColor = Settings.Default.ColorCisepro;
                    pictureBoxS.Visible = false;
                    pictureBoxC.Visible = true;
                    pictureBoxA.Visible = false;
                    break;
            }
            btnAceptar.ForeColor = Color.White;
            btnAceptar.BackColor = ValidationForms.GetColorSistema(TipoCon);

            // CARGAR USUARIOS DEL SISTEMA
            try
            {
                cbLogin.DataSource = _objUsuario.SeleccionarUsuariosGeneral(TipoCon);
                cbLogin.DisplayMember = "login";
                cbLogin.ValueMember = "login";

                // DEFINIR USUARIO POR DEFECTO
                if (string.IsNullOrEmpty(Settings.Default.Usuario)) cbLogin.SelectedIndex = 0;
                else cbLogin.SelectedValue = Settings.Default.Usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error al iniciar: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void cbLogin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}