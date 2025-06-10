using System;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Datos;
using SysCisepro3.Operaciones;
using SysCisepro3.Properties;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmAgregarPersonalControl : KryptonForm
    {
        public TipoConexion TipoCon { get; set; }
        private FrmBuscarPersonal _frmBuscarPersonal;


        public int IdPersonal => int.Parse(txtIdPersonal.Text);
        public string Nombres  => txtPersonal.Text; 
        public string Cargo => txtCargo.Text;
        public string Area => txtArea.Text;
        public string Observaciones => txtObservaciones.Text.Trim();

        public FrmAgregarPersonalControl()
        {
            InitializeComponent();
        }

        private void FrmAgregarPersonalControl_Load(object sender, EventArgs e)
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

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            _frmBuscarPersonal = new FrmBuscarPersonal { TipoCon = TipoCon, SoloActivos = true, Tipo = 0 };
            try
            {
                if (_frmBuscarPersonal.ShowDialog() != DialogResult.OK) return;
                if (_frmBuscarPersonal.dataGridView1.CurrentRow == null) return;

                txtIdPersonal.Text = _frmBuscarPersonal.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPersonal.Text = _frmBuscarPersonal.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtCargo.Text = _frmBuscarPersonal.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtArea.Text = _frmBuscarPersonal.dataGridView1.CurrentRow.Cells["NOMBRE_AREA"].Value.ToString();
            }
            catch
            {
                txtPersonal.Text = @"NO DEFINIDO";
                txtIdPersonal.Clear();
                txtCargo.Clear();
                txtArea.Clear();
            }
        }
    }
}
