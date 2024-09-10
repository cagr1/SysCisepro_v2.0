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
using SysCisepro3.Datos;
using SysCisepro3.Operaciones;
using SysCisepro3.Properties;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.EstructuraEmpresa;
using ClassLibraryCisepro3.UsuarioGeneral;
using ClassLibraryCisepro3.ProcesosSql;
using SysCisepro3.TalentoHumano;
using System.Data.SqlClient;

namespace SysCisepro3.Contabilidad.Compras
{
    public partial class FrmTablaComparacionCompra : KryptonForm
    {

        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmTablaComparacionCompra _instance;
        public static FrmTablaComparacionCompra Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmTablaComparacionCompra();
                return _instance;
            }
        }

        private readonly List<SqlCommand> _sqlCommands;

        public FrmTablaComparacionCompra()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();

        }

        private void FrmTablaComparacionCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
