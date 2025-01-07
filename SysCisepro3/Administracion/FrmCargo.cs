using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.EstructuraEmpresa;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.UsuarioGeneral;
using syscisepro;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using SysCisepro3.Reportes;
using Krypton.Toolkit;

namespace SysCisepro3.Administracion
{
    public partial class FrmCargo : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para administración de GRUPO, SERIE Y CARGO OCUPACIONAL
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmCargo _instance;
        public static FrmCargo Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmCargo();
                return _instance;
            }
        }

        private readonly ClassGrupoocupacional _objetoGrupoOcupacional;
        private readonly ClassSerieOcupacional _objetoSerieOcupacional;
        private readonly ClassCargo _objetoCargoOcupacional;
        
        private readonly List<SqlCommand> _sqlCommands;

        private readonly FrmVisualizadorReportes _frmReportes;
        private readonly crGrupoOcupacional _rptGrupoOcupacional;
        private readonly crSerieOcupacional _rptSerieOcupacional;
        private readonly crCargoOcupacional _rptCargoOcupacional;

        private int _botonSeleccionadoGrupo;
        private int _botonSeleccionadoSerie;
        private int _botonSeleccionadoCargo;

        private FrmCargo()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();
            _objetoGrupoOcupacional = new ClassGrupoocupacional();
            _objetoSerieOcupacional = new ClassSerieOcupacional();
            _objetoCargoOcupacional = new ClassCargo();

            _frmReportes = new FrmVisualizadorReportes();
            _rptSerieOcupacional = new crSerieOcupacional();
            _rptGrupoOcupacional = new crGrupoOcupacional();
            _rptCargoOcupacional = new crCargoOcupacional();
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            MenuStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            MenuStrip1.ForeColor = Color.White;
            MenuStrip2.BackColor = ValidationForms.GetColorSistema(TipoCon);
            MenuStrip2.ForeColor = Color.White;
            MenuStrip3.BackColor = ValidationForms.GetColorSistema(TipoCon);
            MenuStrip3.ForeColor = Color.White;
            dgGrupoOcupacional.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgSeries.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgCargo.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);

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

            LlenarCombos();
        }

        private void LlenarCombos()
        {
            LlenarComboGrupo();
            LlenarComboSeries();
        }

        private void LlenarComboGrupo()
        {
            try
            {
                cbmGrupo.DataSource = _objetoGrupoOcupacional.CargarDatosGrupoOcupacional(TipoCon);
                cbmGrupo.DisplayMember = "DESCRIPCION";
                cbmGrupo.ValueMember = "ID_GRUPO_OCUPACIONAL";
                if (((DataTable)cbmGrupo.DataSource).Rows.Count > 0) cbmGrupo.SelectedIndex = 0;
            }
            catch
            {
                cbmGrupo.DataSource = null;
            }
        }

        private void LlenarComboSeries()
        {
            try
            {
                cbmSerie.DataSource = _objetoSerieOcupacional.CargarDatosSerieOcupacional(TipoCon);
                cbmSerie.DisplayMember = "DESCRIPCION";
                cbmSerie.ValueMember = "ID_SERIE_OCUPACIONAL";
                if (((DataTable)cbmSerie.DataSource).Rows.Count > 0) cbmSerie.SelectedIndex = 0;
            }
            catch
            {
                cbmSerie.DataSource = null;
            }
        }

        private void CargarGrupoOcupacional()
        {
            try
            {
                var data = _objetoGrupoOcupacional.CargarDatosGrupoOcupacional(TipoCon);
                if (data == null || data.Rows.Count == 0)
                {
                    dgGrupoOcupacional.DataSource = null;
                    return;
                }
                dgGrupoOcupacional.DataSource = data;
                dgGrupoOcupacional.Columns[0].HeaderText = @"ID";
                dgGrupoOcupacional.Columns[1].HeaderText = @"DESCRIPCIÓN";
                dgGrupoOcupacional.Columns[2].Visible = false;
                dgGrupoOcupacional.AutoResizeColumns();
                dgGrupoOcupacional.AutoResizeRows();
            }
            catch (Exception ex)
            {
                dgGrupoOcupacional.DataSource = null;
                //MessageBox.Show(@"Error al cargar grupos: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KryptonMessageBox.Show("Error al cargar grupos: " + ex.Message, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
        }

        private void CargarSerieOcupacional()
        {
            try
            {
                var data = _objetoSerieOcupacional.CargarDatosSerieOcupacional(TipoCon);
                if (data == null || data.Rows.Count == 0)
                {
                    dgSeries.DataSource = null;
                    return;
                }
                dgSeries.DataSource = data;
                dgSeries.Columns[0].HeaderText = @"ID";
                dgSeries.Columns[1].HeaderText = @"DESCRIPCIÓN";
                dgSeries.Columns[2].Visible = false;
                dgSeries.Columns[3].Visible = false;
                dgSeries.AutoResizeColumns();
                dgSeries.AutoResizeRows();
            }
            catch (Exception ex)
            {
                dgSeries.DataSource = null;
                //MessageBox.Show(@"Error al cargar series: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KryptonMessageBox.Show("Error al cargar series: " + ex.Message, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
        }

        private void CargarCargo()
        {
            try
            {
                var data = _objetoCargoOcupacional.SeleccionarTodosLosRegistrosCargos(TipoCon);
                if (data == null || data.Rows.Count == 0)
                {
                    dgCargo.DataSource = null;
                    return;
                }
                dgCargo.DataSource = data;
                dgCargo.Columns[0].HeaderText = @"ID";
                dgCargo.Columns[1].HeaderText = @"CÓDIGO";
                dgCargo.Columns[2].HeaderText = @"DESCRIPCIÓN";
                dgCargo.Columns[3].Visible = false;
                dgCargo.Columns[4].Visible = false;
                dgCargo.Columns[5].HeaderText = @"SUELDO";
                dgCargo.AutoResizeColumns();
                dgCargo.AutoResizeRows();
            }
            catch (Exception ex)
            {
                dgCargo.DataSource = null;
                //MessageBox.Show(@"Error al cargar series: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KryptonMessageBox.Show("Error al cargar series: " + ex.Message, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
        }

        private void HabilitarRegistro()
        {
            txtDescripcion.Enabled = true;
        }

        private void HabilitarRegistroSerie()
        {
            txtDescripcionSerie.Enabled = true;
            cbmGrupo.Enabled = true;
        }

        private void HabilitarRegistroCargo()
        {
            txtDescripcionCargo.Enabled = true;
            cbmSerie.Enabled = true;
            txtSueldo.Enabled = true;
        }

        private void DeshabilitarRegistro()
        {
            txtDescripcion.Enabled = false;
        }

        private void DeshabilitarRegistroSerie()
        {
            txtDescripcionSerie.Enabled = false;
            cbmGrupo.Enabled = false;
        }

        private void DeshabilitarRegistroCargos()
        {
            txtDescripcionCargo.Enabled = false;
            cbmSerie.Enabled = false;
            txtSueldo.Enabled = false;
        }

        private bool ValidacionParametros()
        {
            return txtDescripcion.Text.Trim().Length != 0;
        }

        private bool ValidacionParametrosSerie()
        {
            return txtDescripcionSerie.Text.Trim().Length != 0 && cbmGrupo.Text.Trim().Length != 0;
        }

        private bool ValidacionParametrosCargo()
        {
            return txtDescripcionCargo.Text.Trim().Length != 0 && txtSueldo.Text.Trim().Length != 0 && cbmSerie.Text.Trim().Length != 0;
        }

        private void HabilitarBotones(bool botonNuevo, bool botonModificar, bool botonGuardar, bool botonCancelar)
        {
            btnNuevo.Enabled = botonNuevo;
            btnModificar.Enabled = botonModificar;
            btnGuardar.Enabled = botonGuardar;
            btnCancelar.Enabled = botonCancelar;
        }

        private void HabilitarBotonesSerie(bool botonNuevo, bool botonModificar, bool botonGuardar, bool botonCancelar)
        {
            btnNuevaSerie.Enabled = botonNuevo;
            btnModificarSerie.Enabled = botonModificar;
            btnGuardarSerie.Enabled = botonGuardar;
            btnCancelarSerie.Enabled = botonCancelar;
        }

        private void HabilitarBotonesCargos(bool botonNuevo, bool botonModificar, bool botonGuardar, bool botonCancelar)
        {
            btnNuevoCargo.Enabled = botonNuevo;
            btnModificarCargo.Enabled = botonModificar;
            btnGuardarCargo.Enabled = botonGuardar;
            btnCancelarCargo.Enabled = botonCancelar;
        }

        private void LimpiarParametros()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
        }

        private void LimpiarParametrosSerie()
        {
            txtCodigoSerie.Clear();
            txtDescripcionSerie.Clear();
            cbmGrupo.SelectedIndex = 0;
        }

        private void LimpiarParametrosCargos()
        {
            txtCodigoCargo.Clear();
            txtDescripcionCargo.Clear();
            cbmSerie.SelectedIndex = 0;
            txtSueldo.Clear();
        }

        private void btnCargarGerencia_Click(object sender, EventArgs e)
        {
            CargarGrupoOcupacional();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CargarSerieOcupacional();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CargarCargo();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false, false, true, true);
            LimpiarParametros();
            LlenarCombos();
            HabilitarRegistro();

            _botonSeleccionadoGrupo = 1;
            txtDescripcion.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidacionParametros())
            {
                //MessageBox.Show(@"Debe ingresar todos los datos para guardar!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KryptonMessageBox.Show("Debe ingresar todos los datos para guardar!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            //if (MessageBox.Show(@"Desea guardar los cambios realizados?",
            //        "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
            //    DialogResult.Yes) return;

            if (KryptonMessageBox.Show("Desea guardar los cambios realizados?", "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objetoGrupoOcupacional.GrupoOcupacionalId = _botonSeleccionadoGrupo == 1 ? _objetoGrupoOcupacional.BuscarMayorIdGrupoOcupacional(TipoCon) + 1 :
                Convert.ToInt32(txtCodigo.Text);
            _objetoGrupoOcupacional.GrupoOcupacionalDescripcion = txtDescripcion.Text.Trim();
            _objetoGrupoOcupacional.GrupoOcupacionalEstado = 1;

            _sqlCommands.Add(_botonSeleccionadoGrupo == 1 ? _objetoGrupoOcupacional.NuevoGrupoOcupacional() : _objetoGrupoOcupacional.ModificarGrupoOcupacional());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR GRUPOS OCUPACIONALES");

            if ((bool)res[0])
            {
                _botonSeleccionadoGrupo = 0;
                DeshabilitarRegistro();
                CargarGrupoOcupacional();
                HabilitarBotones(true, true, false, false);
                KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            else
            {
                KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
            //MessageBox.Show((string)res[1], "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarRegistro();
            HabilitarBotones(false, false, true, true);
            _botonSeleccionadoGrupo = 2;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarParametros();
            HabilitarBotones(true, true, false, false);
            DeshabilitarRegistro();
            _botonSeleccionadoGrupo = 0;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            try
            {
                _frmReportes.TipoCon = TipoCon;
                _frmReportes.Titulo = "REPORTE DE GRUPOS OCUPACIONALES";
                _rptGrupoOcupacional.SetDataSource(_objetoGrupoOcupacional.CargarDatosGrupoOcupacional(TipoCon));
                _rptGrupoOcupacional.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, Application.StartupPath)); 
                _frmReportes.crystalReportViewer1.ReportSource = _rptGrupoOcupacional;
                _frmReportes.ShowDialog();
            }

            catch (Exception ex)
            {
                //MessageBox.Show(@"Error al generar reporte!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KryptonMessageBox.Show("Error al generar reporte!" + ex.ToString() , "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void btnNuevaSerie_Click(object sender, EventArgs e)
        {
            LlenarComboGrupo();
            HabilitarBotonesSerie(false, false, true, true);
            LlenarCombos();
            HabilitarRegistroSerie();

            _botonSeleccionadoSerie = 1;
            LimpiarParametrosSerie();
            txtDescripcionSerie.Focus();
        }

        private void btnGuardarSerie_Click(object sender, EventArgs e)
        {
            if (!ValidacionParametrosSerie())
            {
                //MessageBox.Show(@"Debe ingresar todos los datos para guardar!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KryptonMessageBox.Show("Debe ingresar todos los datos para guardar!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            //if (MessageBox.Show(@"Desea guardar los cambios realizados?",
            //        "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
            //    DialogResult.Yes) return;
            if (KryptonMessageBox.Show("Desea guardar los cambios realizados?", "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objetoSerieOcupacional.SerieOcupacionalId = _botonSeleccionadoSerie == 1 ? _objetoSerieOcupacional.BuscarMayorIdSerieOcupacional(TipoCon) + 1 :
                Convert.ToInt32(txtCodigoSerie.Text);
            _objetoSerieOcupacional.SerieOcupacionalDescripcion = txtDescripcionSerie.Text.Trim();
            _objetoSerieOcupacional.SerieOcupacionalEstado = "1";
            _objetoSerieOcupacional.SerieOcupacionaIdGrupoOcupacional = Convert.ToInt32(cbmGrupo.SelectedValue);

            _sqlCommands.Add(_botonSeleccionadoSerie == 1 ? _objetoSerieOcupacional.NuevaSerieOcupacional() : _objetoSerieOcupacional.ModificarSerieOcupacional());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR SERIE OCUPACIONAL");

            if ((bool)res[0])
            {
                _botonSeleccionadoSerie = 0;
                DeshabilitarRegistroSerie();
                CargarSerieOcupacional();
                HabilitarBotonesSerie(true, true, false, false);
                KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

            }
            else
            {
                KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
            //MessageBox.Show((string)res[1], "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificarSerie_Click(object sender, EventArgs e)
        {
            HabilitarRegistroSerie();
            HabilitarBotonesSerie(false, false, true, true);
            LlenarComboGrupo();
            _botonSeleccionadoSerie = 2;
        }

        private void btnCancelarSerie_Click(object sender, EventArgs e)
        {
            LimpiarParametrosSerie();
            HabilitarBotonesSerie(true, true, false, false);
            DeshabilitarRegistroSerie();
            _botonSeleccionadoSerie = 0;
        }

        private void btnReporteSerie_Click(object sender, EventArgs e)
        {
            try
            {
                _frmReportes.TipoCon = TipoCon;
                _frmReportes.Titulo = "REPORTE DE SERIES OCUPACIONALES";
                _rptSerieOcupacional.SetDataSource(_objetoSerieOcupacional.CargarDatosSerieOcupacional(TipoCon));
                _rptSerieOcupacional.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, Application.StartupPath)); 
                _frmReportes.crystalReportViewer1.ReportSource = _rptSerieOcupacional;
                _frmReportes.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(@"Error al generar reporte! " + ex.Message.ToString(), "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KryptonMessageBox.Show("Error al generar reporte!" + ex.ToString(), "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void btnNuevoCargo_Click(object sender, EventArgs e)
        {
            LlenarComboSeries();
            HabilitarBotonesCargos(false, false, true, true);
            LlenarCombos();
            _botonSeleccionadoCargo = 1;
            HabilitarRegistroCargo();
            LimpiarParametrosCargos();
            txtDescripcionCargo.Focus();
        }

        private void btnGuardarCargo_Click(object sender, EventArgs e)
        {
            if (!ValidacionParametrosCargo())
            {
                //MessageBox.Show(@"Debe ingresar todos los datos para guardar!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KryptonMessageBox.Show("Debe ingresar todos los datos para guardar!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            //if (MessageBox.Show(@"Desea guardar los cambios realizados?",
            //        "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
            //    DialogResult.Yes) return;

            if (KryptonMessageBox.Show("Desea guardar los cambios realizados?", "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objetoCargoOcupacional.CargoId = _botonSeleccionadoCargo == 1 ? _objetoCargoOcupacional.BuscarMayorIdCargoOcupacional(TipoCon) + 1 :
                Convert.ToInt32(txtCodigo.Tag);

            _objetoCargoOcupacional.CargoCodigo = _botonSeleccionadoCargo == 1 ? _objetoCargoOcupacional.BuscarIdGrupoPorIdSerie(TipoCon, Convert.ToInt32(cbmSerie.SelectedValue)) + "." +
                cbmSerie.SelectedValue + "." + _objetoCargoOcupacional.ContarMayorPorIdSerieOcupacional(TipoCon) :
                txtCodigoCargo.Text.Trim();

            _objetoCargoOcupacional.CargoDescripcion = txtDescripcionCargo.Text.Trim();
            _objetoCargoOcupacional.CargoEstado = 1;
            _objetoCargoOcupacional.CargoIdSerie = Convert.ToInt32(cbmSerie.SelectedValue);
            _objetoCargoOcupacional.CargoSueldoBasico = Convert.ToDecimal(txtSueldo.Text.Trim());

            _sqlCommands.Add(_botonSeleccionadoCargo == 1 ? _objetoCargoOcupacional.NuevaCargoOcupacional() : _objetoCargoOcupacional.ModificarCargoOcupacional());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR CARGO OCUPACIONAL");

            if ((bool)res[0])
            {
                _botonSeleccionadoCargo = 0;
                DeshabilitarRegistroCargos();
                CargarCargo();
                HabilitarBotonesCargos(true, true, false, false);
                KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            else
            {
                KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
            //MessageBox.Show((string)res[1], "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificarCargo_Click(object sender, EventArgs e)
        {
            HabilitarRegistroCargo();
            HabilitarBotonesCargos(false, false, true, true);
            LlenarComboSeries();
            _botonSeleccionadoCargo = 2;
        }

        private void btnReporteCargo_Click(object sender, EventArgs e)
        {
            try
            {
                _frmReportes.TipoCon = TipoCon;
                _frmReportes.Titulo = "REPORTE DE GRUPOS OCUPACIONALES";
                _rptCargoOcupacional.SetDataSource(_objetoCargoOcupacional.SeleccionarTodosLosRegistrosCargos(TipoCon));
                _rptCargoOcupacional.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, Application.StartupPath)); 
                _frmReportes.crystalReportViewer1.ReportSource = _rptCargoOcupacional;
                _frmReportes.ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(@"Error al generar reporte!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KryptonMessageBox.Show("Error al generar reporte!" + ex.ToString(), "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void btnCancelarCargo_Click(object sender, EventArgs e)
        {
            LimpiarParametrosCargos();
            HabilitarBotonesCargos(true, true, false, false);
            DeshabilitarRegistroCargos();
            _botonSeleccionadoCargo = 0;
        }

        private void dgGrupoOcupacional_SelectionChanged(object sender, EventArgs e)
        {
            if (_botonSeleccionadoGrupo != 0) return;
            if (dgGrupoOcupacional.CurrentRow == null) return;
            try
            {
                txtCodigo.Text = dgGrupoOcupacional.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dgGrupoOcupacional.CurrentRow.Cells[1].Value.ToString();
                btnModificar.Enabled = true;
            }
            catch
            {
                LimpiarParametros();
                btnModificar.Enabled = false;
            }
        }

        private void dgSeries_SelectionChanged(object sender, EventArgs e)
        {
            if (_botonSeleccionadoSerie != 0) return;
            if (dgSeries.CurrentRow == null) return;
            try
            {
                txtCodigoSerie.Text = dgSeries.CurrentRow.Cells[0].Value.ToString();
                txtDescripcionSerie.Text = dgSeries.CurrentRow.Cells[1].Value.ToString();
                cbmGrupo.SelectedValue = dgSeries.CurrentRow.Cells[3].Value;
                btnModificarSerie.Enabled = true;
            }
            catch
            {
                LimpiarParametrosSerie();
                btnModificarSerie.Enabled = false;
            }
        }

        private void dgCargo_SelectionChanged(object sender, EventArgs e)
        {
            if (_botonSeleccionadoCargo != 0) return;
            if (dgCargo.CurrentRow == null) return;
            try
            {
                txtCodigo.Tag = dgCargo.CurrentRow.Cells[0].Value.ToString();
                txtCodigoCargo.Text = dgCargo.CurrentRow.Cells[1].Value.ToString();
                txtDescripcionCargo.Text = dgCargo.CurrentRow.Cells[2].Value.ToString();
                cbmSerie.SelectedValue = dgCargo.CurrentRow.Cells[4].Value;
                txtSueldo.Text = dgCargo.CurrentRow.Cells[5].Value.ToString();
                btnModificarCargo.Enabled = true;
            }
            catch
            {
                LimpiarParametrosCargos();
                btnModificarCargo.Enabled = false;
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validaciones.IsNumeroDecimal(e.KeyChar, txtSueldo.Text);
        }

        private void MenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
