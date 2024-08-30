using ClassLibraryCisepro3.DivisionGeografica;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.Invetarios;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.UsuarioGeneral;
using Krypton.Toolkit;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using SysCisepro3.Reportes;
using SysCisepro3.TalentoHumano;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SysCisepro3.Inventarios
{
    public partial class FrmBodega : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para administrar BODEGAS en sistema
        /// </summary>
        public static TipoConexion TipoCon { get; set; }
        public static ClassUsuarioGeneral Usuario { get; set; }

        private static FrmBodega _instance;
        public static FrmBodega Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmBodega();
                return _instance;
            }
        }

        private int _botonSeleccionado;
        private readonly ClassBodega _objBodega;
        private readonly ClassSitiosTrabajo _objSitios;
        private readonly crBodegas _crBodegas;
        private readonly List<SqlCommand> _sqlCommands;
        private FrmBuscarPersonal _frmBuscarPersonal;

        private FrmBodega()
        {
            InitializeComponent();
            _botonSeleccionado = 0;
            _sqlCommands = new List<SqlCommand>();
            _objSitios = new ClassSitiosTrabajo();
            _objBodega = new ClassBodega();
            _crBodegas = new crBodegas();
        }

        private void FrmBodega_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 

            //msKardex.BackColor = ValidationForms.GetColorSistema(TipoCon);
            msKardex.ForeColor = Color.White;
            dgvBodega.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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
            dgvBodega.Font = new Font("Roboto", 8, FontStyle.Regular);
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LlenarSitiosTrabajo();
            CargarBodegasActivas();
        }

        private void CargarBodegasActivas()
        {
            try
            {
                dgvBodega.DataSource = _objBodega.SeleccionarBodegasActivas(TipoCon);

                dgvBodega.AutoResizeColumns();
                dgvBodega.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvBodega.Columns[0].HeaderText = @"ID";
                dgvBodega.Columns[0].Width = 25;
                dgvBodega.Columns[1].Width = 150;
                dgvBodega.Columns[3].Width = 300;
                dgvBodega.Columns[4].Width = 70;
                dgvBodega.Columns[5].Visible = false;
                dgvBodega.Columns[6].Visible = false;
                dgvBodega.Columns[9].Visible = false;
                dgvBodega.Columns[10].Width = 120;
                dgvBodega.Columns[11].Width = 200;
                dgvBodega.Columns[12].Visible = false;
            }
            catch (Exception ex)
            {
                dgvBodega.DataSource = null;
                MessageBox.Show(@"Error al cargar detalles: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmNuevo_Click(object sender, EventArgs e)
        {
            _botonSeleccionado = 1;
            LlenarSitiosTrabajo();
            HabilitarParametros(true, true, true, true, false, false);
            HabilitarBotones(false, false, true, true);
            LimpiarParametros("", "", "", "", "", "");
            cbmUbicación.SelectedValue = 1; // cisepro
            txtNombreBodega.Focus();
        }

        private void LlenarSitiosTrabajo()
        {
            try
            {
                var data = _objSitios.SeleccionarSitios(TipoCon);
                cbmUbicación.DataSource = data;
                cbmUbicación.DisplayMember = "NOMBRE_SITIO_TRABAJO";
                cbmUbicación.ValueMember = "ID_SITIO_TRABAJO";
                cbmUbicación.DropDownWidth = 250;
                cbmUbicación.SelectedIndex = 0;
            }
            catch
            {
                cbmUbicación.DataSource = null;
            }
        }

        private void HabilitarBotones(bool botonNuevo, bool botonModificar, bool botonCancelar, bool botonGuardar)
        {
            tsmNuevo.Enabled = botonNuevo;
            tsmActualizar.Enabled = botonModificar;
            tsmCancelar.Enabled = botonCancelar;
            tsmGuardar.Enabled = botonGuardar;
        }

        private void HabilitarParametros(bool nombreBodega, bool ubicacionBodega, bool telefonoBodega, bool observacionBodega, bool idPersonalBodega, bool nombresPersonalBodega)
        {
            txtNombreBodega.Enabled = nombreBodega;
            cbmUbicación.Enabled = ubicacionBodega;
            txtTelefono.Enabled = telefonoBodega;
            txtObservación.Enabled = observacionBodega;
            txtIdPersonal.Enabled = idPersonalBodega;
            txtNombresPersonal.Enabled = nombresPersonalBodega;
            btnBuscarCustodio.Enabled = nombreBodega;
        }

        private void LimpiarParametros(string nombreBodega, string ubicacionBodega, string telefonoBodega, string observacionBodega, string idPersonalBodega, string nombresBodega)
        {
            txtNombreBodega.Text = nombreBodega;
            cbmUbicación.Text = ubicacionBodega;
            txtTelefono.Text = telefonoBodega;
            txtObservación.Text = observacionBodega;
            txtIdPersonal.Text = idPersonalBodega;
            txtNombresPersonal.Text = nombresBodega;
        }

        private void tsmActualizar_Click(object sender, EventArgs e)
        {
            _botonSeleccionado = 2;
            HabilitarBotones(false, false, true, true);
            HabilitarParametros(true, true, true, true, false, false);
            txtNombreBodega.Focus();
        }

        private void tsmCancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, true, false, false);
            HabilitarParametros(false, false, false, false, false, false);
            LimpiarParametros("", "", "", "", "", "");
            _botonSeleccionado = 0;
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                _crBodegas.SetDataSource(_objBodega.SeleccionarBodegasActivas(TipoCon));
                _crBodegas.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, Application.StartupPath));
                crvBodegas.ReportSource = _crBodegas;
                crvBodegas.Zoom(75);
                crvBodegas.Refresh();
                tcBodega.TabIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error al cargar detalles: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvBodega_SelectionChanged(object sender, EventArgs e)
        {
            if (_botonSeleccionado != 0) return;
            if (dgvBodega.RowCount == 0 || dgvBodega.CurrentRow == null) return;
            try
            {
                txtNombreBodega.Tag = dgvBodega.CurrentRow.Cells[0].Value.ToString();
                txtNombreBodega.Text = dgvBodega.CurrentRow.Cells[1].Value.ToString();
                txtTelefono.Text = dgvBodega.CurrentRow.Cells[2].Value.ToString();
                txtObservación.Text = dgvBodega.CurrentRow.Cells[3].Value.ToString();
                txtIdPersonal.Text = dgvBodega.CurrentRow.Cells[5].Value.ToString();
                txtNombresPersonal.Text = dgvBodega.CurrentRow.Cells[7].Value + @" " + dgvBodega.CurrentRow.Cells[8].Value;
                cbmUbicación.SelectedValue = dgvBodega.CurrentRow.Cells[9].Value.ToString();

                tsmActualizar.Enabled = dgvBodega.RowCount > 0 && dgvBodega.CurrentRow != null;
            }
            catch
            {
                LimpiarParametros("", "", "", "", "", "");
            }
        }

        private void btnBuscarCustodio_Click(object sender, EventArgs e)
        {
            _frmBuscarPersonal = new FrmBuscarPersonal { TipoCon = TipoCon, SoloActivos = true, Tipo = 0 };
            try
            {
                if (_frmBuscarPersonal.ShowDialog() != DialogResult.OK) return;
                if (_frmBuscarPersonal.dataGridView1.CurrentRow == null) return;

                txtNombresPersonal.Text = _frmBuscarPersonal.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtIdPersonal.Text = _frmBuscarPersonal.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
                txtNombresPersonal.Clear();
                txtIdPersonal.Clear();
            }
        }

        private void tsmGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreBodega.TextLength > 0 && txtNombresPersonal.TextLength > 0)
            {
                if (MessageBox.Show(@"Desea guardar el registro actual?",
                  "MENSAJE DELL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
              DialogResult.Yes) return;


                _sqlCommands.Clear();

                if (_botonSeleccionado == 1)
                {
                    _objBodega.IdBodega = _objBodega.BuscarMayorIdBodega(TipoCon) + 1;
                    _objBodega.NombreBodega = txtNombreBodega.Text;
                    _objBodega.IdSitioBodega = Convert.ToInt32(cbmUbicación.SelectedValue);
                    _objBodega.TelefonoBodega = txtTelefono.Text;
                    _objBodega.Observaci = txtObservación.Text;
                    _objBodega.IdPersonalBodega = Convert.ToInt32(txtIdPersonal.Text);
                    _objBodega.FechaBodega = DateTime.Now;
                    _objBodega.EstadoBodega = 1;
                    _sqlCommands.Add(_objBodega.NuevaBodega());
                }
                else
                {
                    _objBodega.IdBodega = Convert.ToInt32(txtNombreBodega.Tag);
                    _objBodega.NombreBodega = txtNombreBodega.Text;
                    _objBodega.IdSitioBodega = Convert.ToInt32(cbmUbicación.SelectedValue);
                    _objBodega.TelefonoBodega = txtTelefono.Text;
                    _objBodega.Observaci = txtObservación.Text;
                    _objBodega.IdPersonalBodega = Convert.ToInt32(txtIdPersonal.Text);
                    _objBodega.FechaBodega = DateTime.Now;
                    _objBodega.EstadoBodega = 1;
                    _sqlCommands.Add(_objBodega.ModificarBodegas());
                }

                var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR BODEGA");

                if ((bool)res[0])
                {
                    HabilitarParametros(false, false, false, false, false, false);
                    HabilitarBotones(true, true, false, false);
                    _botonSeleccionado = 0;
                    CargarBodegasActivas();
                }
                MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"PARA GUARDAR, ES NECESARIO LLENAR TODOS LOS CAMPOS!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
