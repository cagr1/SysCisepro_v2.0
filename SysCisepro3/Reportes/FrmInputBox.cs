using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Properties;

namespace SysCisepro3.Reportes
{
    public partial class FrmInputBox : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para RECIBIR UN DATO como INPUTBOX
        /// </summary>
        public TipoConexion TipoCon { private get; set; }
        public string Titulo { private get; set; }
        public string Mensaje { private get; set; }

        public FrmInputBox()
        {
            InitializeComponent();
        }

        private void FrmInputBox_Load(object sender, System.EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
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
            Text = Titulo;
            label1.Text = Mensaje;
        }
    }
}
