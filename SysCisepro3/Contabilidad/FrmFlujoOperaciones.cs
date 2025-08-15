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
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Contabilidad.PlanDeCuentas;
using SysCisepro3.Properties;

using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using SysCisepro3.TalentoHumano;
using ClosedXML.Excel;

namespace SysCisepro3.Contabilidad
{
    public partial class FrmFlujoOperaciones : KryptonForm
    {
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }
        private readonly ClassPlanDeCuentas _objClassPlanDeCuentas;

        private static FrmFlujoOperaciones _instance;
        public static FrmFlujoOperaciones Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmFlujoOperaciones();
                return _instance;
            }
        }

        public FrmFlujoOperaciones(TipoConexion tipoCon, ClassUsuarioGeneral usuario)
        {
            InitializeComponent();        
            TipoCon = tipoCon;
            Usuario = usuario;
            _objClassPlanDeCuentas = new ClassPlanDeCuentas();
        }

        private FrmFlujoOperaciones()
        {
            InitializeComponent();
            _objClassPlanDeCuentas = new ClassPlanDeCuentas();
        }




        private void FrmFlujoOperaciones_Load(object sender, EventArgs e)
        {
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

        }
    }
}
