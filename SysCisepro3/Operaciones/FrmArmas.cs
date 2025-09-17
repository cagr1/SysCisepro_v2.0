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
using ClassLibraryCisepro3.UsuarioGeneral;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Datos;
using SysCisepro3.Properties;

namespace SysCisepro3.Operaciones
{
    public partial class FrmArmas : KryptonForm
    {
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        

        private static FrmArmas _instance;
        public static FrmArmas Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmArmas();
                return _instance;
            }
        }

        public FrmArmas()
        {
            InitializeComponent();
        }

        private void FrmArmas_Load(object sender, EventArgs e)
        {

        }
    }
}
