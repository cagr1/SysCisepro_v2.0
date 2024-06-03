using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MaterialSkin;
using MaterialSkin.Controls;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using System.Web.UI.WebControls;
using AForge.Controls;







namespace SysCisepro3.Main
{
    public partial class FrmNewLogin : KryptonForm
    {
        public TipoConexion TipoCon { private get; set; }
        public int TiempoNotificacion { private get; set; }

        private readonly ClassUsuarioGeneral _objUsuario;

        private MdiParentMain _formMenu;
        private MdiParentMonitoreo _formMenuMonitoreo;


        public FrmNewLogin()
        {
            InitializeComponent();

            //PrivateFontCollection pfc = new PrivateFontCollection();
            //int fontLength = Properties.Resources.Roboto_Regular.Length;
            //byte[] fontData = Properties.Resources.Roboto_Regular;
            //System.IntPtr data = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            //System.Runtime.InteropServices.Marshal.Copy(fontData, 0, data, fontData.Length);
            //pfc.AddMemoryFont(data, fontData.Length);

            //lblUsuario.Font = new Font(pfc.Families[0], 11, FontStyle.Regular);                                              
            //lblPassword.Font = new Font(pfc.Families[0], 11, FontStyle.Regular);

            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.Blue700, TextShade.WHITE);
            _objUsuario = new ClassUsuarioGeneral();
            //cbxUser.Font = new Font("Roboto", 8, FontStyle.Regular);

        }

        private void FrmNewLogin_Load(object sender, EventArgs e)
        {
            CargarSisitema();
            //change background picture
            
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


            //btnAceptar.ForeColor = Color.White;
           // btnAceptar.BackColor = ValidationForms.GetColorSistema(TipoCon);

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
                MessageBox.Show(@"Error al iniciar: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void FrmNewLogin_FormClosing(object sender, EventArgs e)
        {
            _objUsuario.SalirSistema(TipoCon);
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var u = _objUsuario.BuscarUsuarioPorLogin(TipoCon, cbxUser.SelectedValue.ToString(), txtPassword.Text);

            if (u == null || !u.Password.Equals(txtPassword.Text)) // CLAVE DEBE COINCIDER EN MAYÚSCULAS Y/O MINÚSCULAS
            {
                txtPassword.Clear();
                KryptonMessageBox.Show(@"La contraseña ingresada es incorrecta!", @"MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //_frmNewLogin = this
                };
                _formMenu.Show();

            }

            this.DialogResult = DialogResult.OK;
            Hide();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;
            btnLogin_Click(null, null);
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            _objUsuario.SalirSistema(TipoCon);
            Dispose();
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

       

        

       
    
}
