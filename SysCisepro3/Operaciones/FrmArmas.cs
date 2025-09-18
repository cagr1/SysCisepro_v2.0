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
using ClassLibraryCisepro3.Operaciones;

namespace SysCisepro3.Operaciones
{
    public partial class FrmArmas : KryptonForm
    {
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

       private readonly ClassArmas _objArmas = new ClassArmas();

        private static FrmArmas _instance;
        public static FrmArmas Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmArmas(TipoCon, Usuario);
                return _instance;
            }
        }

        public FrmArmas(TipoConexion tipoCon, ClassUsuarioGeneral usuario)
        {
            InitializeComponent();
            TipoCon = tipoCon;
            Usuario = usuario;
            _objArmas = new ClassArmas();

        }

        private void FrmArmas_Load(object sender, EventArgs e)
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
            ValidationForms.SetPlaceholder(txtBuscar, "Buscar...");
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CargarArmas(txtBuscar.Text.Trim());
        }

        private void CargarArmas(string filtro)
        {
            try
            { 
                dgvArmas.Rows.Clear();
                //agrega variable desde para enviar a funcion con datetime

                var desde = dtpFechaDesde.Value.ToString("yyyy-MM-dd 00:00:00");
                var hasta = dtpFechaHasta.Value.ToString("yyyy-MM-dd 23:59:59");


                var datos = _objArmas.buscar(TipoCon, filtro, Convert.ToDateTime(desde), Convert.ToDateTime(hasta));

                if (datos.Rows.Count == 0) return;


            }
            catch (Exception ex)
             {
                 KryptonMessageBox.Show(@"Error al cargar armas: " + ex.Message, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
               }
         
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
