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
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.EstructuraEmpresa;
using System.Data.SqlClient;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmAsientoRoles : KryptonForm
    {
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmAsientoRoles _instance;
        public static FrmAsientoRoles Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmAsientoRoles();
                return _instance;
            }
        }

        private readonly List<SqlCommand> _sqlCommands;

        private FrmAsientoRoles()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();

        }

        private void FrmAsientoRoles_Load(object sender, EventArgs e)
        {


        }
    }
}
