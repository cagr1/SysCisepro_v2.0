using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Datos;
using SysCisepro3.Operaciones;
using SysCisepro3.Properties;
using Krypton.Toolkit;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmAgregarPersonalRolPago : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para agregar personal que no está en rol de pagos
        /// </summary>
        public TipoConexion TipoCon { get; set; }

        private FrmBuscarPersonal _frmBuscarPersonal;
        public FrmAgregarPersonalRolPago()
        {
            InitializeComponent(); 
        }
         
        private FrmBuscarPuestoTrabajo _femBuscarPuestoTrabajo;

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            _frmBuscarPersonal = new FrmBuscarPersonal { TipoCon = TipoCon, SoloActivos = false, Tipo = 0 };
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

        private void bntPuesto_Click(object sender, EventArgs e)
        {
            _femBuscarPuestoTrabajo = new FrmBuscarPuestoTrabajo { Label3 = { Text = @"TODOS LOS PUESTOS REGISTRADOS" }, TipoCon = TipoCon };
            try
            {
                if (_femBuscarPuestoTrabajo.ShowDialog() != DialogResult.OK) return;
                txtIdPuesto.Text = _femBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[0].Text.Trim();
                txtUbicacionPuesto.Text = _femBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[2].Text.Trim();
                txtCliente.Text = _femBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[18].Text.Trim();
                txtGrupo.Text = _femBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[22].Text.Trim(); 
            }
            catch
            {
                txtIdPuesto.Clear();
                txtUbicacionPuesto.Clear();
                txtCliente.Clear();
                txtGrupo.Clear();
            }
        }

        private void FrmAgregarPersonalRolPago_Load(object sender, EventArgs e)
        {

            GroupBox1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            GroupBox1.ForeColor = Color.White;
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
            cbxEstado.SelectedIndex = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
