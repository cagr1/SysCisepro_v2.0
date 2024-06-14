using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibraryCisepro3.UsuarioGeneral;
using ClassLibraryCisepro3.Enums;
using System.Data.SqlClient;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.TalentoHumano;
using syscisepro.FORMULARIOS.INVENTARIOS.PROCESO;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.Operaciones;
using Krypton.Toolkit;

namespace SysCisepro3.Operaciones
{
    public partial class FrmOrdenRevisionTecnica : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// PARA ORDENES DE REVISION TÉCNICA
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmOrdenRevisionTecnica _instance;
        public static FrmOrdenRevisionTecnica Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmOrdenRevisionTecnica();
                return _instance;
            }
        }
        private readonly List<SqlCommand> _sqlCommands;
        private readonly ClassPersonal _objPersonal;
        private FrmBuscarProveedorCliente _frmBuscarProveedorCliente;
        private ClassOrdenRevisionTecnica _objOrdenRevisionTecnica;
        private ClassDetalleOrdenRevisionTecnica _objDetalleOrdenRevisionTecnica;
        private DateTime _hoy;

        public FrmOrdenRevisionTecnica()
        {
            InitializeComponent();
            _objPersonal = new ClassPersonal();
            _sqlCommands = new List<SqlCommand>();
            _objOrdenRevisionTecnica = new ClassOrdenRevisionTecnica();
            _objDetalleOrdenRevisionTecnica = new ClassDetalleOrdenRevisionTecnica();
        }

        private void FrmOrdenRevisionTecnica_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            //toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            Label24.BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label24.ForeColor = Color.White;
            Label1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label1.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvDetallesOrden.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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
            dataGridView1.Font = new Font("Roboto", 8, FontStyle.Regular);
            dgvDetallesOrden.Font = new Font("Roboto", 8, FontStyle.Regular);
            _hoy = Usuario.Now(TipoCon);
            cbxFiltro.SelectedIndex = 0;
            dtpFechaDesde.Value = new DateTime(_hoy.Year, _hoy.Month, 1);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _hoy = Usuario.Now(TipoCon);

            txtIdOrden.Clear();
            txtCiRuc.Clear();
            txtNombreSolicitante.Clear();
            txtClienteSolicitante.Clear();
            txtIdSe.Clear();
            cbxTipo.SelectedIndex = 0;

            dtpFechaNotificacion.Value = _hoy;
            cbxEstado.SelectedIndex = 1;

            cbxTipo.Enabled = true;
            txtIdOrden.Enabled = false;
            txtCiRuc.Enabled = true;
            txtNombreSolicitante.Enabled = true;
            txtIdSe.Enabled = true;
            btnCliente.Enabled = true;
            cbxEstado.Enabled = false;
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            dtpFechaNotificacion.Enabled = true;
            dgvDetallesOrden.ReadOnly = false;
            dgvDetallesOrden.Rows.Clear();

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnAnular.Enabled = false;
            btnCancelar.Enabled = true;

            txtIdOrden.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(@"Desea guardar la orden técnica actual?",
                   "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
               DialogResult.Yes) return;

            if (txtCiRuc.Text.Trim().Length == 0 || txtNombreSolicitante.Text.Trim().Length == 0 || txtClienteSolicitante.Text.Trim().Length == 0)
            {
                KryptonMessageBox.Show(@"Debe definir los datos de la orden técnicapara guardar!",
                    "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            _sqlCommands.Clear();

            dgvDetallesOrden.EndEdit();

            _hoy = Usuario.Now(TipoCon);
            dtpFechaNotificacion.Value = _hoy;
            _objOrdenRevisionTecnica.IdOrden = _objOrdenRevisionTecnica.BuscarMayorIdOrdenTecnica(TipoCon) + 1;
            _objOrdenRevisionTecnica.FechaRegistro = _hoy;
            _objOrdenRevisionTecnica.FechaOrden = dtpFechaNotificacion.Value;
            _objOrdenRevisionTecnica.CedulaRuc = txtCiRuc.Text.Trim();
            _objOrdenRevisionTecnica.ApellidosNombres = txtNombreSolicitante.Text.Trim();
            _objOrdenRevisionTecnica.IdClienteGeneral = Convert.ToInt32(txtClienteSolicitante.Tag);
            _objOrdenRevisionTecnica.Estado = cbxEstado.SelectedIndex;
            _objOrdenRevisionTecnica.Detalle = string.Empty;
            _objOrdenRevisionTecnica.Tipo = cbxTipo.SelectedIndex; // 0 - MONITOREO, 1 - SUPERVISION
            _objOrdenRevisionTecnica.IdSeguridadElectronica = txtIdSe.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtIdSe.Text.Trim());
            _objOrdenRevisionTecnica.FechaIniciaRevision = new DateTime(1990,1,1,0,0,0);
            _objOrdenRevisionTecnica.FechaRevisionPendiente = new DateTime(1990, 1, 1, 0, 0, 0);
            _objOrdenRevisionTecnica.FechaRevisionRealizado = new DateTime(1990, 1, 1, 0, 0, 0);
            _sqlCommands.Add(_objOrdenRevisionTecnica.NuevoRegistroOrdenCommands());

            var idd = _objDetalleOrdenRevisionTecnica.BuscarMayorIdDetalleOrdenTecnica(TipoCon) + 1;
            foreach (DataGridViewRow row in dgvDetallesOrden.Rows)
            {
                _objDetalleOrdenRevisionTecnica.IdOrden = _objOrdenRevisionTecnica.IdOrden;
                _objDetalleOrdenRevisionTecnica.IdDetalle = idd;
                _objDetalleOrdenRevisionTecnica.Detalle = row.Cells[0].Value.ToString();
                _objDetalleOrdenRevisionTecnica.Ok = 0;
                _objDetalleOrdenRevisionTecnica.Observacion = row.Cells[1].Value.ToString();
                _sqlCommands.Add(_objDetalleOrdenRevisionTecnica.NuevoRegistroDetalleOrdenCommands());
                idd++;
            }

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR ORDEN TECNICA");

            if ((bool)res[0])
            {
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = true;
                btnCancelar.Enabled = false;

                txtIdOrden.Text = _objOrdenRevisionTecnica.IdOrden + "";
                dtpFechaNotificacion.Enabled = false;
                txtCiRuc.Enabled = false;
                txtNombreSolicitante.Enabled = false;
                txtClienteSolicitante.Enabled = false;
                txtIdSe.Enabled = false;
                cbxTipo.Enabled = false;
                cbxEstado.Enabled = false;

                txtFiltro.Clear();
                dgvDetallesOrden.Rows.Clear();

                CargarMantenimientos();
            }
            KryptonMessageBox.Show((string)res[1], "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (dataGridView1.CurrentRow == null) return;
            if (KryptonMessageBox.Show(@"Desea anular la orden seleccioando?", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objOrdenRevisionTecnica.IdOrden = Convert.ToInt32(txtIdOrden.Text);
            _objOrdenRevisionTecnica.Estado = 0;
            _sqlCommands.Add(_objOrdenRevisionTecnica.AnularRegistroOrdenTecnica());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "ANULAR NOTIFICACION");

            if ((bool)res[0])
            {
                dtpFechaNotificacion.Enabled = false;
                txtIdOrden.Enabled = false;
                txtCiRuc.Enabled = false;
                txtNombreSolicitante.Enabled = false;
                txtClienteSolicitante.Enabled = false;
                txtIdSe.Enabled = false;
                cbxTipo.Enabled = false;
                cbxEstado.Enabled = false;

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = false;
                btnCancelar.Enabled = false;

                txtFiltro.Clear();
                CargarMantenimientos();
            }
            KryptonMessageBox.Show((string)res[1], "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtpFechaNotificacion.Enabled = false;
            txtIdOrden.Enabled = false;
            txtCiRuc.Enabled = false;
            txtNombreSolicitante.Enabled = false;
            btnCliente.Enabled = false;
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            dgvDetallesOrden.Rows.Clear();
            dgvDetallesOrden.ReadOnly = true;
            cbxTipo.SelectedIndex = 0;

            dtpFechaNotificacion.Tag = null;
            txtIdOrden.Clear();
            txtCiRuc.Clear();
            txtNombreSolicitante.Clear();
            txtClienteSolicitante.Clear();
            txtIdSe.Clear();
            txtIdSe.Enabled = false;
            cbxTipo.Enabled = false;
            cbxEstado.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = false;
            btnCancelar.Enabled = false;

            CargarMantenimientos();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            CargarMantenimientos();
        }

        private void CargarMantenimientos()
        {
            try
            {
                dataGridView1.Rows.Clear();

                var fechaDesde = dtpFechaDesde.Value.Year + "-" + dtpFechaDesde.Value.Month + "-" + dtpFechaDesde.Value.Day + " 00:00:00";
                var fechaHasta = dtpFechaHasta.Value.Year + "-" + dtpFechaHasta.Value.Month + "-" + dtpFechaHasta.Value.Day + " 23:59:59";

                var data = _objOrdenRevisionTecnica.SeleccionarOrdenTecnicaSupervision(TipoCon, fechaDesde, fechaHasta, txtFiltro.Text.Trim(), cbxFiltro.SelectedIndex);

                foreach (DataRow row in data.Rows)
                {
                    var frev = Convert.ToDateTime(row[7]) == new DateTime(1990, 1, 1, 0, 0, 0) ? "-" : row[7];
                    var fpen = Convert.ToDateTime(row[8]) == new DateTime(1990, 1, 1, 0, 0, 0) ? "-" : row[8];
                    var frea = Convert.ToDateTime(row[9]) == new DateTime(1990, 1, 1, 0, 0, 0) ? "-" : row[9];
                    dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], frev, fpen, frea, row[10], row[11]);
                }

                dataGridView1.AutoResizeRows();
                Label1.Text = dataGridView1.RowCount + @" REGISTRO(S)";

                btnAnular.Enabled = dataGridView1.RowCount > 0 && dataGridView1.CurrentRow != null;

                if (dataGridView1.CurrentRow != null) CargarDetallesMantenimiento(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            }
            catch (Exception ex)
            {
                dataGridView1.Rows.Clear();
                KryptonMessageBox.Show(@"Error al cargar ordenes: " + ex.Message, "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void CargarDetallesMantenimiento(int idorden)
        {
            try
            {
                dgvDetallesOrden.Rows.Clear();
                var data = _objDetalleOrdenRevisionTecnica.SeleccionarRegistroDetalle(TipoCon, idorden);
                foreach (DataRow row in data.Rows) dgvDetallesOrden.Rows.Add(row[2], row[4], row[3]);
            }
            catch (Exception ex)
            {
                dgvDetallesOrden.Rows.Clear();
                KryptonMessageBox.Show(@"Error al cargar detalles orden: " + ex.Message, "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            CargarMantenimientos();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (dataGridView1.CurrentRow == null) return;
            if (!btnNuevo.Enabled) return;

            txtIdOrden.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();            
            txtCiRuc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNombreSolicitante.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString().Split('|')[0].Trim();
            txtClienteSolicitante.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString().Split('|')[1].Trim();
            cbxEstado.SelectedIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            txtIdSe.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            cbxTipo.SelectedIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value.ToString());

            CargarDetallesMantenimiento(Convert.ToInt32(txtIdOrden.Text));

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validaciones.IsNumeroEntero(e.KeyChar);
        }

        private void txtCiRuc_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCiRuc.Text.Trim().Length < 10) return;
            txtNombreSolicitante.Text = _objPersonal.BuscarNombresPersonalXCedula(TipoCon, txtCiRuc.Text.Trim());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            _frmBuscarProveedorCliente = new FrmBuscarProveedorCliente();
            _frmBuscarProveedorCliente.TipoCox = TipoCon == TipoConexion.Cisepro ? 0 : 1;
            _frmBuscarProveedorCliente.rbtProveedor.Visible = false;
            _frmBuscarProveedorCliente.rbtPersonal.Visible = false;
            _frmBuscarProveedorCliente.rbtCliente.Checked = true;
            _frmBuscarProveedorCliente.rbtCliente.Enabled = false;
            _frmBuscarProveedorCliente.txtParametrobusqueda.Width = _frmBuscarProveedorCliente.txtParametrobusqueda.Width + _frmBuscarProveedorCliente.rbtProveedor.Width + _frmBuscarProveedorCliente.rbtPersonal.Width;
            _frmBuscarProveedorCliente.Todos = true;

            try
            {
                if (_frmBuscarProveedorCliente.ShowDialog() != DialogResult.OK) return;
                txtClienteSolicitante.Tag = _frmBuscarProveedorCliente.dgvCustodios.CurrentRow.Cells[0].Value.ToString().Trim();
                txtClienteSolicitante.Text = _frmBuscarProveedorCliente.dgvCustodios.CurrentRow.Cells[5].Value.ToString().Trim();
            }
            catch
            {
                txtClienteSolicitante.Tag = null;
                txtClienteSolicitante.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvDetallesOrden.Rows.Add(string.Empty,  string.Empty, false);
            dgvDetallesOrden.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvDetallesOrden.RowCount == 0) return;
            dgvDetallesOrden.Rows.Remove(dgvDetallesOrden.CurrentRow);
        }

        private void dgvDetallesOrden_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = btnNuevo.Enabled;
        }

        private void textIdSe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validaciones.IsNumeroEntero(e.KeyChar);
        }

        private void dgvDetallesOrden_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDetallesOrden.CurrentCell.ColumnIndex == 2) return;
            (e.Control as TextBox).CharacterCasing = CharacterCasing.Upper;
        } 
    }
}
//ANULADO
//SIN REVISIÓN
//EN PROCESO
//PENDIENTE
//REALIZADO