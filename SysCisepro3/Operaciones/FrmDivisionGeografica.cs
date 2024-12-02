using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryCisepro3.DivisionGeografica;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using Krypton.Toolkit;

namespace SysCisepro3.Operaciones
{
    public partial class FrmDivisionGeografica : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// DIVISION GEOGRAFICA ECUADOR
        /// </summary>
        public static TipoConexion TipoCon { get; set; }
        public static ClassUsuarioGeneral Usuario { get; set; }

        private readonly ClassProvincias _objProvincias;
        private readonly ClassCiudades _objCiudades;
        private readonly ClassParroquias _objParroquias;

        private static FrmDivisionGeografica _instance;
        public static FrmDivisionGeografica Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmDivisionGeografica();
                return _instance;
            }
        }

        private readonly List<SqlCommand> _sqlCommands;
        private int _estado;

        public FrmDivisionGeografica()
        {
            InitializeComponent();
            _estado = 0;
            _sqlCommands = new List<SqlCommand>();
            _objProvincias = new ClassProvincias();
            _objCiudades = new ClassCiudades();
            _objParroquias = new ClassParroquias();
        }

        private void FrmDivisionGeografica_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 

            //toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            //MenuStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            MenuStrip1.ForeColor = Color.White;
            //MenuStrip2.BackColor = ValidationForms.GetColorSistema(TipoCon);
            MenuStrip2.ForeColor = Color.White;
            dgvProvincias.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvCiudades.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvParroquias.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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
            dgvProvincias.Font = new Font("Roboto", 8, FontStyle.Regular);
            dgvCiudades.Font = new Font("Roboto", 8, FontStyle.Regular);
            dgvParroquias.Font = new Font("Roboto", 8, FontStyle.Regular);
            CargarProvincias();
        }

        private void CargarProvincias()
        {
            try
            {
                var data = _objProvincias.SeleccionarTodosLosRegistrosProvincias(TipoCon);
                if (data == null || data.Rows.Count == 0)
                {
                    dgvProvincias.DataSource = null;
                    return;
                }

                dgvProvincias.DataSource = data;

                dgvProvincias.Columns[0].HeaderText = @"ID";
                dgvProvincias.Columns[0].Width = 60;
                dgvProvincias.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
                dgvProvincias.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProvincias.Columns[1].HeaderText = @"NOMBRE";
                dgvProvincias.Columns[1].Width = 320;
                dgvProvincias.Columns[2].Visible = false;
                dgvProvincias.Columns[3].Visible = false;
                dgvProvincias.AutoResizeRows();
                dgvProvincias.ReadOnly = false;
                dgvProvincias.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            catch (Exception ex)
            {
                dgvProvincias.DataSource = null;
                MessageBox.Show(@"Error al cargar provincias: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProvincias_SelectionChanged(object sender, EventArgs e)
        {
            if (_estado != 0) return;
            if (dgvProvincias.CurrentRow == null) return;
            if (dgvProvincias.CurrentRow.Cells[0] == null) return;

            txtIdProvincia.Text = dgvProvincias.CurrentRow.Cells[0].Value.ToString();
            txtNombreProvincia.Text = dgvProvincias.CurrentRow.Cells[1].Value.ToString();

            CargarCiudades(txtIdProvincia.Text);

            btnNuevoProvincia.Enabled = true;
            btnGuardarProvincia.Enabled = false;
            btnModificarProvincia.Enabled = true;
            btnCancelarProvincia.Enabled = false;
        }

        private void CargarCiudades(string idp)
        {
            try
            {
                var data = _objCiudades.BuscarNombreCiudadesXIdProvincia(TipoCon, idp);
                if (data == null || data.Rows.Count == 0)
                {
                    dgvCiudades.DataSource = null;
                    return;
                }

                dgvCiudades.DataSource = data;

                dgvCiudades.Columns[0].HeaderText = @"ID";
                dgvCiudades.Columns[0].Width = 60;
                dgvCiudades.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
                dgvCiudades.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCiudades.Columns[1].HeaderText = @"NOMBRE";
                dgvCiudades.Columns[1].Width = 300;
                dgvCiudades.Columns[2].Visible = false;
                dgvCiudades.Columns[3].Visible = false;
                dgvCiudades.AutoResizeRows();
                dgvCiudades.ReadOnly = false;
                dgvCiudades.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            catch (Exception ex)
            {
                dgvCiudades.DataSource = null;
                MessageBox.Show(@"Error al cargar provincias: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCiudades_SelectionChanged(object sender, EventArgs e)
        {
            if (_estado != 0) return;
            if (dgvCiudades.CurrentRow == null) return;
            if (dgvCiudades.CurrentRow.Cells[0] == null) return;

            txtIdCiudades.Text = dgvCiudades.CurrentRow.Cells[0].Value.ToString();
            txtNombreCiudades.Text = dgvCiudades.CurrentRow.Cells[1].Value.ToString();

            CargarParroquias(txtIdCiudades.Text);

            btnNuevoCiudad.Enabled = true;
            btnGuardarCiudad.Enabled = false;
            btnModificarCiudad.Enabled = true;
            btnCancelarCiudad.Enabled = false;
        }

        private void CargarParroquias(string idc)
        {
            try
            {
                var data = _objParroquias.BuscarNombreParroquiaXIdCiudades(TipoCon, idc);
                if (data == null || data.Rows.Count == 0)
                {
                    dgvParroquias.DataSource = null;
                    return;
                }

                dgvParroquias.DataSource = data;

                dgvParroquias.Columns[0].HeaderText = @"ID";
                dgvParroquias.Columns[0].Width = 60;
                dgvParroquias.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
                dgvParroquias.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvParroquias.Columns[1].HeaderText = @"NOMBRE";
                dgvParroquias.Columns[1].Width = 300;
                dgvParroquias.Columns[2].Visible = false;
                dgvParroquias.Columns[3].Visible = false;
                dgvParroquias.AutoResizeRows();
                dgvParroquias.ReadOnly = false;
                dgvParroquias.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            catch (Exception ex)
            {
                dgvParroquias.DataSource = null;
                MessageBox.Show(@"Error al cargar provincias: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvParroquias_SelectionChanged(object sender, EventArgs e)
        {
            if (_estado != 0) return;
            if (dgvParroquias.CurrentRow == null) return;
            if (dgvParroquias.CurrentRow.Cells[0] == null) return;

            txtIdParroquia.Text = dgvParroquias.CurrentRow.Cells[0].Value.ToString();
            txtNombreParroquia.Text = dgvParroquias.CurrentRow.Cells[1].Value.ToString();

            btnNuevaParroquia.Enabled = true;
            btnGuardarParroquia.Enabled = false;
            btnModificarParroquia.Enabled = true;
            btnCancelarParroquia.Enabled = false;
        }

        private void btnCargarProvincias_Click(object sender, EventArgs e)
        {
            if (_estado != 0) return;
            CargarProvincias();
        }

        private void btnCargarCiudades_Click(object sender, EventArgs e)
        {
            if (_estado != 0) return;
            if (dgvProvincias.CurrentRow == null) return;
            CargarCiudades(dgvProvincias.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnCargarParroquias_Click(object sender, EventArgs e)
        {
            if (_estado != 0) return;
            if (dgvCiudades.CurrentRow == null) return;
            CargarParroquias(dgvCiudades.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnNuevoProvincia_Click(object sender, EventArgs e)
        {
            txtIdProvincia.Clear();
            txtNombreProvincia.Clear();

            txtIdProvincia.Enabled = false;
            txtNombreProvincia.Enabled = true;
            btnNuevoProvincia.Enabled = false;
            btnGuardarProvincia.Enabled = true;
            btnModificarProvincia.Enabled = false;
            btnCancelarProvincia.Enabled = true;
            btnCargarProvincias.Enabled = false;

            txtIdCiudades.Enabled = false;
            txtNombreCiudades.Enabled = false;
            btnNuevoCiudad.Enabled = false;
            btnGuardarCiudad.Enabled = false;
            btnModificarCiudad.Enabled = false;
            btnCancelarCiudad.Enabled = false;
            btnCargarCiudades.Enabled = false;

            txtIdParroquia.Enabled = false;
            txtNombreParroquia.Enabled = false;
            btnNuevaParroquia.Enabled = false;
            btnGuardarParroquia.Enabled = false;
            btnModificarParroquia.Enabled = false;
            btnCancelarParroquia.Enabled = false;
            btnCargarParroquias.Enabled = false;
            _estado = 1;
        }

        private void btnNuevoCiudad_Click(object sender, EventArgs e)
        {
            txtIdCiudades.Clear();
            txtNombreCiudades.Clear();

            txtIdProvincia.Enabled = false;
            txtNombreProvincia.Enabled = false;
            btnNuevoProvincia.Enabled = false;
            btnGuardarProvincia.Enabled = false;
            btnModificarProvincia.Enabled = false;
            btnCancelarProvincia.Enabled = false;
            btnCargarProvincias.Enabled = false;

            txtIdCiudades.Enabled = false;
            txtNombreCiudades.Enabled = true;
            btnNuevoCiudad.Enabled = false;
            btnGuardarCiudad.Enabled = true;
            btnModificarCiudad.Enabled = false;
            btnCancelarCiudad.Enabled = true;
            btnCargarCiudades.Enabled = false;

            txtIdParroquia.Enabled = false;
            txtNombreParroquia.Enabled = false;
            btnNuevaParroquia.Enabled = false;
            btnGuardarParroquia.Enabled = false;
            btnModificarParroquia.Enabled = false;
            btnCancelarParroquia.Enabled = false;
            btnCargarParroquias.Enabled = false;
            _estado = 1;
        }

        private void btnNuevaParroquia_Click(object sender, EventArgs e)
        {
            txtIdParroquia.Clear();
            txtNombreParroquia.Clear();

            txtIdProvincia.Enabled = false;
            txtNombreProvincia.Enabled = false;
            btnNuevoProvincia.Enabled = false;
            btnGuardarProvincia.Enabled = false;
            btnModificarProvincia.Enabled = false;
            btnCancelarProvincia.Enabled = false;
            btnCargarProvincias.Enabled = false;

            txtIdCiudades.Enabled = false;
            txtNombreCiudades.Enabled = false;
            btnNuevoCiudad.Enabled = false;
            btnGuardarCiudad.Enabled = false;
            btnModificarCiudad.Enabled = false;
            btnCancelarCiudad.Enabled = false;
            btnCargarCiudades.Enabled = false;

            txtIdParroquia.Enabled = false;
            txtNombreParroquia.Enabled = true;
            btnNuevaParroquia.Enabled = false;
            btnGuardarParroquia.Enabled = true;
            btnModificarParroquia.Enabled = false;
            btnCancelarParroquia.Enabled = true;
            btnCargarParroquias.Enabled = false;
            _estado = 1;
        }

        private void btnGuardarProvincia_Click(object sender, EventArgs e)
        {
            if (txtNombreProvincia.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"No se ha ingresado el nombre!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show(@"Desea guardar los cambios realizados?",
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;
            _sqlCommands.Clear();
            _objProvincias.IdProvinciaProvincias = _estado == 1 ? _objProvincias.BuscarMayorIdProvincia(TipoCon) + 1 : Convert.ToInt32(txtIdProvincia.Text.Trim());
            _objProvincias.IdPaisProvincias = 1;
            _objProvincias.EstadoProvincias = "1";
            _objProvincias.NombreProvinciaProvincias = txtNombreProvincia.Text.Trim();
            _sqlCommands.Add(_estado == 1 ? _objProvincias.NuevoProvincia() : _objProvincias.ActualizarProvincia());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR PROVINCIAS");

            if ((bool)res[0])
            {
                _estado = 0;
                btnCargarProvincias.PerformClick();

                txtIdProvincia.Enabled = false;
                txtNombreProvincia.Enabled = false;
                btnNuevoProvincia.Enabled = true;
                btnGuardarProvincia.Enabled = false;
                btnModificarProvincia.Enabled = dgvProvincias.RowCount > 0;
                btnCancelarProvincia.Enabled = false;
                btnCargarProvincias.Enabled = true;

                txtIdCiudades.Enabled = false;
                txtNombreCiudades.Enabled = false;
                btnNuevoCiudad.Enabled = true;
                btnGuardarCiudad.Enabled = false;
                btnModificarCiudad.Enabled = dgvCiudades.RowCount > 0;
                btnCancelarCiudad.Enabled = false;
                btnCargarCiudades.Enabled = true;

                txtIdParroquia.Enabled = false;
                txtNombreParroquia.Enabled = false;
                btnNuevaParroquia.Enabled = true;
                btnGuardarParroquia.Enabled = false;
                btnModificarParroquia.Enabled = dgvParroquias.RowCount > 0;
                btnCancelarParroquia.Enabled = false;
                btnCargarParroquias.Enabled = true;
            }
            MessageBox.Show((string)res[1], "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarCiudad_Click(object sender, EventArgs e)
        {
            if (txtNombreCiudades.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"No se ha ingresado el nombre!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show(@"Desea guardar los cambios realizados?",
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;
            _sqlCommands.Clear();
            _objCiudades.IdCiudadCiudades = _estado == 1 ? _objCiudades.BuscarMayorIdCiudades(TipoCon) + 1 : Convert.ToInt32(txtIdCiudades.Text.Trim());
            _objCiudades.IdProvinciaCiudades = Convert.ToInt32(txtIdProvincia.Text.Trim());
            _objCiudades.EstadoCiudades = 1;
            _objCiudades.NombreCiudadesCiudades = txtNombreCiudades.Text.Trim();
            _sqlCommands.Add(_estado == 1 ? _objCiudades.NuevoCiudad() : _objCiudades.ActualziarCiudad());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR CIUDADES");

            if ((bool)res[0])
            {
                _estado = 0;
                btnCargarCiudades.PerformClick();

                txtIdProvincia.Enabled = false;
                txtNombreProvincia.Enabled = false;
                btnNuevoProvincia.Enabled = true;
                btnGuardarProvincia.Enabled = false;
                btnModificarProvincia.Enabled = dgvProvincias.RowCount > 0 && dgvProvincias.CurrentRow != null;
                btnCancelarProvincia.Enabled = false;
                btnCargarProvincias.Enabled = true;

                txtIdCiudades.Enabled = false;
                txtNombreCiudades.Enabled = false;
                btnNuevoCiudad.Enabled = true;
                btnGuardarCiudad.Enabled = false;
                btnModificarCiudad.Enabled = dgvCiudades.RowCount > 0 && dgvCiudades.CurrentRow != null;
                btnCancelarCiudad.Enabled = false;
                btnCargarCiudades.Enabled = true;

                txtIdParroquia.Enabled = false;
                txtNombreParroquia.Enabled = false;
                btnNuevaParroquia.Enabled = true;
                btnGuardarParroquia.Enabled = false;
                btnModificarParroquia.Enabled = dgvParroquias.RowCount > 0 && dgvParroquias.CurrentRow != null;
                btnCancelarParroquia.Enabled = false;
                btnCargarParroquias.Enabled = true;
            }
            MessageBox.Show((string)res[1], "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarParroquia_Click(object sender, EventArgs e)
        {
            if (txtNombreParroquia.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"No se ha ingresado el nombre!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show(@"Desea guardar los cambios realizados?",
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;
            _sqlCommands.Clear();
            _objParroquias.IdParroquiaParroquias = _estado == 1 ? _objParroquias.BuscarMayorIdParroquias(TipoCon) + 1 : Convert.ToInt32(txtIdParroquia.Text.Trim());
            _objParroquias.IdCiudadParroquias = Convert.ToInt32(txtIdCiudades.Text.Trim());
            _objParroquias.EstadoParroquias = 1;
            _objParroquias.NombreParroquiaParroquias = txtNombreParroquia.Text.Trim();
            _sqlCommands.Add(_estado == 1 ? _objParroquias.NuevoParroquia() : _objParroquias.ActualizarParroquia());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR PARROQUIAS");

            if ((bool)res[0])
            {
                _estado = 0;
                btnCargarParroquias.PerformClick();

                txtIdProvincia.Enabled = false;
                txtNombreProvincia.Enabled = false;
                btnNuevoProvincia.Enabled = true;
                btnGuardarProvincia.Enabled = false;
                btnModificarProvincia.Enabled = dgvProvincias.RowCount > 0 && dgvProvincias.CurrentRow != null;
                btnCancelarProvincia.Enabled = false;
                btnCargarProvincias.Enabled = true;

                txtIdCiudades.Enabled = false;
                txtNombreCiudades.Enabled = false;
                btnNuevoCiudad.Enabled = true;
                btnGuardarCiudad.Enabled = false;
                btnModificarCiudad.Enabled = dgvCiudades.RowCount > 0 && dgvCiudades.CurrentRow != null;
                btnCancelarCiudad.Enabled = false;
                btnCargarCiudades.Enabled = true;

                txtIdParroquia.Enabled = false;
                txtNombreParroquia.Enabled = false;
                btnNuevaParroquia.Enabled = true;
                btnGuardarParroquia.Enabled = false;
                btnModificarParroquia.Enabled = dgvParroquias.RowCount > 0 && dgvParroquias.CurrentRow != null;
                btnCancelarParroquia.Enabled = false;
                btnCargarParroquias.Enabled = true;
            }
            MessageBox.Show((string)res[1], "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificarProvincia_Click(object sender, EventArgs e)
        {
            if (txtNombreProvincia.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"No se ha ingresado el nombre!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtIdProvincia.Enabled = false;
            txtNombreProvincia.Enabled = true;
            btnNuevoProvincia.Enabled = false;
            btnGuardarProvincia.Enabled = true;
            btnModificarProvincia.Enabled = false;
            btnCancelarProvincia.Enabled = true;
            btnCargarProvincias.Enabled = false;

            txtIdCiudades.Enabled = false;
            txtNombreCiudades.Enabled = false;
            btnNuevoCiudad.Enabled = false;
            btnGuardarCiudad.Enabled = false;
            btnModificarCiudad.Enabled = false;
            btnCancelarCiudad.Enabled = false;
            btnCargarCiudades.Enabled = false;

            txtIdParroquia.Enabled = false;
            txtNombreParroquia.Enabled = false;
            btnNuevaParroquia.Enabled = false;
            btnGuardarParroquia.Enabled = false;
            btnModificarParroquia.Enabled = false;
            btnCancelarParroquia.Enabled = false;
            btnCargarParroquias.Enabled = false;
            _estado = 2;
        }

        private void btnModificarCiudad_Click(object sender, EventArgs e)
        {
            txtIdProvincia.Enabled = false;
            txtNombreProvincia.Enabled = false;
            btnNuevoProvincia.Enabled = false;
            btnGuardarProvincia.Enabled = false;
            btnModificarProvincia.Enabled = false;
            btnCancelarProvincia.Enabled = false;
            btnCargarProvincias.Enabled = false;

            txtIdCiudades.Enabled = false;
            txtNombreCiudades.Enabled = true;
            btnNuevoCiudad.Enabled = false;
            btnGuardarCiudad.Enabled = true;
            btnModificarCiudad.Enabled = false;
            btnCancelarCiudad.Enabled = true;
            btnCargarCiudades.Enabled = false;

            txtIdParroquia.Enabled = false;
            txtNombreParroquia.Enabled = false;
            btnNuevaParroquia.Enabled = false;
            btnGuardarParroquia.Enabled = false;
            btnModificarParroquia.Enabled = false;
            btnCancelarParroquia.Enabled = false;
            btnCargarParroquias.Enabled = false;
            _estado = 2;
        }

        private void btnModificarParroquia_Click(object sender, EventArgs e)
        {
            txtIdProvincia.Enabled = false;
            txtNombreProvincia.Enabled = false;
            btnNuevoProvincia.Enabled = false;
            btnGuardarProvincia.Enabled = false;
            btnModificarProvincia.Enabled = false;
            btnCancelarProvincia.Enabled = false;
            btnCargarProvincias.Enabled = false;

            txtIdCiudades.Enabled = false;
            txtNombreCiudades.Enabled = false;
            btnNuevoCiudad.Enabled = false;
            btnGuardarCiudad.Enabled = false;
            btnModificarCiudad.Enabled = false;
            btnCancelarCiudad.Enabled = false;
            btnCargarCiudades.Enabled = false;

            txtIdParroquia.Enabled = false;
            txtNombreParroquia.Enabled = true;
            btnNuevaParroquia.Enabled = false;
            btnGuardarParroquia.Enabled = true;
            btnModificarParroquia.Enabled = false;
            btnCancelarParroquia.Enabled = true;
            btnCargarParroquias.Enabled = false;
            _estado = 2;
        }

        private void btnCancelarProvincia_Click(object sender, EventArgs e)
        {
            txtIdProvincia.Enabled = false;
            txtNombreProvincia.Enabled = false;
            btnNuevoProvincia.Enabled = true;
            btnGuardarProvincia.Enabled = false;
            btnModificarProvincia.Enabled = false;
            btnCancelarProvincia.Enabled = false;
            btnCargarProvincias.Enabled = true;

            txtIdCiudades.Enabled = false;
            txtNombreCiudades.Enabled = false;
            btnNuevoCiudad.Enabled = true;
            btnGuardarCiudad.Enabled = false;
            btnModificarCiudad.Enabled = false;
            btnCancelarCiudad.Enabled = false;
            btnCargarCiudades.Enabled = true;

            txtIdParroquia.Enabled = false;
            txtNombreParroquia.Enabled = false;
            btnNuevaParroquia.Enabled = true;
            btnGuardarParroquia.Enabled = false;
            btnModificarParroquia.Enabled = false;
            btnCancelarParroquia.Enabled = false;
            btnCargarParroquias.Enabled = true;
            _estado = 0;
        }

        private void btnCancelarCiudad_Click(object sender, EventArgs e)
        {
            txtIdProvincia.Enabled = false;
            txtNombreProvincia.Enabled = false;
            btnNuevoProvincia.Enabled = true;
            btnGuardarProvincia.Enabled = false;
            btnModificarProvincia.Enabled = false;
            btnCancelarProvincia.Enabled = false;
            btnCargarProvincias.Enabled = true;

            txtIdCiudades.Enabled = false;
            txtNombreCiudades.Enabled = false;
            btnNuevoCiudad.Enabled = true;
            btnGuardarCiudad.Enabled = false;
            btnModificarCiudad.Enabled = false;
            btnCancelarCiudad.Enabled = false;
            btnCargarCiudades.Enabled = true;

            txtIdParroquia.Enabled = false;
            txtNombreParroquia.Enabled = false;
            btnNuevaParroquia.Enabled = true;
            btnGuardarParroquia.Enabled = false;
            btnModificarParroquia.Enabled = false;
            btnCancelarParroquia.Enabled = false;
            btnCargarParroquias.Enabled = true;
            _estado = 0;
        }

        private void btnCancelarParroquia_Click(object sender, EventArgs e)
        {
            txtIdProvincia.Enabled = false;
            txtNombreProvincia.Enabled = false;
            btnNuevoProvincia.Enabled = true;
            btnGuardarProvincia.Enabled = false;
            btnModificarProvincia.Enabled = false;
            btnCancelarProvincia.Enabled = false;
            btnCargarProvincias.Enabled = true;

            txtIdCiudades.Enabled = false;
            txtNombreCiudades.Enabled = false;
            btnNuevoCiudad.Enabled = true;
            btnGuardarCiudad.Enabled = false;
            btnModificarCiudad.Enabled = false;
            btnCancelarCiudad.Enabled = false;
            btnCargarCiudades.Enabled = true;

            txtIdParroquia.Enabled = false;
            txtNombreParroquia.Enabled = false;
            btnNuevaParroquia.Enabled = true;
            btnGuardarParroquia.Enabled = false;
            btnModificarParroquia.Enabled = false;
            btnCancelarParroquia.Enabled = false;
            btnCargarParroquias.Enabled = true;
            _estado = 0;
        }
    }
}
