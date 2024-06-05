using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using Krypton.Toolkit;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmBuscarRolPago : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para buscar rol de pagos
        /// </summary>
        private readonly ClassRolPago _objRolPago;
        public ClassUsuarioGeneral Usuario { get; set; }
        public TipoConexion TipoCon { get; set; }

        public bool MultiSelect { get; set; }

        public List<int> Roles;
        public List<string> Grupos;
        public int Mes { get; set; }
        public int Anio { get; set; }

        public FrmBuscarRolPago()
        {
            InitializeComponent();
            _objRolPago = new ClassRolPago();
            Roles = new List<int>();
            Grupos = new List<string>();
        }

        private void FrmBuscarRolPago_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label1.ForeColor = Color.White;
            lblHasta.ForeColor = Color.White;
            dgvRoles.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvRoles.MultiSelect = MultiSelect;

            lblHasta.Visible = !MultiSelect;
            dtpFechaDesde.Visible = !MultiSelect;
            dtpFechaHasta.Visible = !MultiSelect;

            dtpFechaMes.Visible = MultiSelect;

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

            var f = Usuario.Now(TipoCon);
            dtpFechaDesde.Value = new DateTime(f.Year, f.Month, 1, 0, 0, 0);
            dtpFechaHasta.Value = new DateTime(f.Year, f.Month, f.Day, 23, 59, 59);
            dtpFechaMes.Value = new DateTime(f.Year, f.Month, 1, 0, 0, 0);
            btnSig.Visible = MultiSelect;
        }

        private void dtpFechaElaborado_ValueChanged(object sender, EventArgs e)
        {
            CargarPersonalGeneral(dtpFechaDesde.Value, dtpFechaHasta.Value);
        }

        private void CargarPersonalGeneral(DateTime desde, DateTime hasta)
        {
            try
            {
                dgvRoles.DataSource = MultiSelect ? _objRolPago.SeleccionarRolesPorMesAnio(TipoCon, dtpFechaMes.Value.Month, dtpFechaMes.Value.Year) :
                    _objRolPago.SeleccionarRolesPorFecha(TipoCon, desde, hasta);                
                 
                dgvRoles.Columns[0].Width = 40;
                dgvRoles.Columns[1].Width = 80;
                dgvRoles.Columns[2].Visible = false;
                dgvRoles.Columns[3].Width = 90;
                dgvRoles.Columns[4].Width = 60;
                dgvRoles.Columns[5].Visible = false;
                dgvRoles.Columns[8].DefaultCellStyle.Format = "d";
                dgvRoles.Columns[9].DefaultCellStyle.Format = "d";
                dgvRoles.Columns[10].Width = 85;
                dgvRoles.Columns[11].Visible = false;
                dgvRoles.Columns[12].Width = 90; // estado
                dgvRoles.Columns[13].Width = 300;
                dgvRoles.Columns[14].Visible = false;
                dgvRoles.Columns[15].Visible = false;
                dgvRoles.Columns[16].Visible = false;
                dgvRoles.AutoResizeRows();

                foreach (DataGridViewRow row in dgvRoles.Rows)
                {
                    if (row.Cells[12].Value.ToString().Equals("VALIDADO")) row.Cells[12].Style.BackColor = Color.Green;
                }
            }
            catch
            {
                dgvRoles.DataSource = null;
            }
        }

        private void dgvCustodios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MultiSelect) return;
            if (e.RowIndex < 0) return;
            if (dgvRoles.RowCount == 0) return;
            if (dgvRoles.CurrentRow == null) return;
            DialogResult = DialogResult.OK;
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (dgvRoles.RowCount == 0) return;
            if (dgvRoles.SelectedRows.Count == 0) return;

            Roles.Clear();
            Grupos.Clear();

            foreach (DataGridViewRow row in dgvRoles.SelectedRows)
            {
                if (!Roles.Contains(Convert.ToInt32(row.Cells[0].Value))) Roles.Add(Convert.ToInt32(row.Cells[0].Value));
                if (!Grupos.Contains(row.Cells[16].Value.ToString())) Grupos.Add(row.Cells[16].Value.ToString());
            }
            Mes = dtpFechaMes.Value.Month;
            Anio = dtpFechaMes.Value.Year;
            if (Roles.Count == 0) return;
            Roles.Sort();

            DialogResult = DialogResult.OK;
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
