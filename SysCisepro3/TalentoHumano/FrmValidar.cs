using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using System.Windows.Forms;
using SysCisepro3.Properties;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmValidar : Form
    {
        public TipoConexion TipoCon { private get; set; }
        private readonly ClassUsuarioGeneral _objUsuario; 
        
        public FrmValidar()
        {
            InitializeComponent();
            _objUsuario = new ClassUsuarioGeneral();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
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


            if (u.TipoUsuario.Equals("ADMINISTRADOR"))
            {
                this.DialogResult = DialogResult.OK;
            }

        }

        private void FrmValidar_Load(object sender, EventArgs e)
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
                    
                    break;
                case TipoConexion.Asenava:
                    Icon = Resources.logo_a;
                    
                    pictureBoxS.Visible = false;
                    pictureBoxC.Visible = false;
                    
                    break;
                default: // CISEPRO
                    Icon = Resources.logo_c;
                    pictureBoxC.BackColor = Settings.Default.ColorCisepro;
                    pictureBoxS.Visible = false;
                    pictureBoxC.Visible = true;
                    
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
                MessageBox.Show(@"Error al iniciar: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;
            btnAceptar_Click(null, null);
        }
    }
}
