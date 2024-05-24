using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Properties;

namespace SysCisepro3.Reportes
{
    public partial class FrmVisualizadorReportes : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para visualizar CRYSTAL REPORTS
        /// </summary>
        public TipoConexion TipoCon { private get; set; }
        public string Titulo { private get; set; }

        public FrmVisualizadorReportes()
        {
            InitializeComponent();
        }

        private void FrmVisualizadorReportes_Load(object sender, System.EventArgs e)
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
            crystalReportViewer1.Zoom(2);
        }
    }
}
