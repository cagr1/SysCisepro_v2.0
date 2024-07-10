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
    /// <summary>
    /// CISEPRO 2019
    /// Para administración de ESTRUCTURA ADMINISTRATIVA
    /// </summary>
    public partial class FrmEstructuraAdministrativa : KryptonForm
    {
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { get; set; }

        private static FrmEstructuraAdministrativa _instance;
        public static FrmEstructuraAdministrativa Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmEstructuraAdministrativa();
                return _instance;
            }
        }

        private readonly ClassEmpresa _objEmpresa;
        private readonly ClassSucursal _objSucursal;
        private readonly ClassGerencia _objGerencia;
        private readonly ClassGerenciasGeneral _objGerencias;
        private readonly ClassArea _objAreas;
        private readonly ClassSecciones _objSecciones;
        private readonly ClassSubSeccion _objSubSecciones;

        private readonly crGerencia _rptGerencia;
        private readonly crGerencias _rptGerencias;        
        private readonly crSeccion _rptSeccion;
        private readonly crSubSecciones _rptSubSeccion;
        private readonly crAreas _rptAreas;

        private readonly FrmVisualizadorReportes _frmReportes;

        private readonly List<SqlCommand> _sqlCommands;

        int _btnSelGerencia;
        int _btnSelGerencias;
        int _btnSelAreas;
        int _btnSelSecciones;
        int _btnSelSubSecciones;

        private FrmEstructuraAdministrativa()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();
            _objEmpresa = new ClassEmpresa();
            _objSucursal = new ClassSucursal();
            _objGerencia = new ClassGerencia();
            _objGerencias = new ClassGerenciasGeneral();
            _objAreas = new ClassArea();
            _objSecciones = new ClassSecciones();
            _objSubSecciones = new ClassSubSeccion();

            _rptGerencia = new crGerencia();
            _rptGerencias = new crGerencias();
            _rptAreas = new crAreas();
            _rptSeccion = new crSeccion();
            _rptSubSeccion = new crSubSecciones();

            _frmReportes = new FrmVisualizadorReportes();
           this.Resize += new EventHandler(FrmEstructuraAdministrativa_Resize);


        }

        private void FrmEstructuraAdministrativa_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            toolStrip2.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip2.ForeColor = Color.White;
            toolStrip3.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip3.ForeColor = Color.White;
            toolStrip4.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip4.ForeColor = Color.White;
            toolStrip5.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip5.ForeColor = Color.White;
            dgvGerencias.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvGerencia.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvAreas.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvSecciones.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvSubSecciones.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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

            //Width = this.ClientSize.Width - 150;
            //Height = this.ClientSize.Height - 250;
        }

        private void LlenarCombos()
        {
            LlenarComboEmpresa();
            LlenarComboSucursal();
            LlenascomboGerencia();
            LlenarcomboGerencias();
            LlenarcomboAreas();
            LlenarcomboSecciones();
        }

        private void btnCargarGerencia_Click(object sender, EventArgs e)
        {
            CargarGerencia();
        }

        private void btnCargarGerencias_Click(object sender, EventArgs e)
        {
            CargarGerencias();
        }

        private void btnCargarAreas_Click(object sender, EventArgs e)
        {
            CargarAreas();
        }

        private void btnCargarSeccion_Click(object sender, EventArgs e)
        {
            CargarSecciones();
        }

        private void btnCargarSubSeccion_Click(object sender, EventArgs e)
        {
            CargarSubSecciones();
        }

        private void HabilitarRegistroGerencia()
        {
            txtDescripcionGerencia.Enabled = true;
            cbEmpresa.Enabled = true;
            cbSucursal.Enabled = true;
        }

        private void HabilitarRegistroGerencias()
        {
            txtNombreGerencias.Enabled = true;
            cbGerencia.Enabled = true;
        }

        private void HabilitarRegistrosAreas()
        {
            txtNombreAreas.Enabled = true;
            cbGerencias.Enabled = true;
        }

        private void HabilitarRegistrosSecciones()
        {
            txtNombreSeccion.Enabled = true;
            cbArea.Enabled = true;
        }

        private void HabilitarRegistrosSubSecciones()
        {
            txtNombreSubSeccion.Enabled = true;
            cbSeccion.Enabled = true;
        }

        private void DeshabilitarRegistrosGerencia()
        {
            txtCodigoGerencia.Enabled = false;
            txtDescripcionGerencia.Enabled = false;
            cbEmpresa.Enabled = false;
            cbSucursal.Enabled = false;
        }

        private void DeshabilitarRegistrosGerencias()
        {
            txtCodigoGerencias.Enabled = false;
            txtNombreGerencias.Enabled = false;
            cbGerencia.Enabled = false;
        }

        private void DeshabilitarRegistrosAreas()
        {
            txtCodigoAreas.Enabled = false;
            txtNombreAreas.Enabled = false;
            cbGerencias.Enabled = false;
        }

        private void DeshabilitarRegistrosSecciones()
        {
            txtCodigoSeccion.Enabled = false;
            txtNombreSeccion.Enabled = false;
            cbArea.Enabled = false;
        }

        private void DeshabilitarRegistrosSubSecciones()
        {
            txtCodigoSubSeccion.Enabled = false;
            txtNombreSubSeccion.Enabled = false;
            cbSeccion.Enabled = false;
        }

        private bool ValidacionParametrosGerencia()
        {
            return txtDescripcionGerencia.Text.Trim().Length != 0 && cbEmpresa.Text.Trim().Length != 0 && cbSucursal.Text.Trim().Length != 0;
        }

        private bool ValidacionParametrosGerencias()
        {

            return txtNombreGerencias.Text.Trim().Length != 0 && cbGerencia.Text.Trim().Length != 0;
        }

        private bool ValidacionParametrosAreas()
        {

            return txtNombreAreas.Text.Trim().Length != 0 && cbGerencias.Text.Trim().Length != 0;
        }

        private bool ValidacionParametrosSecciones()
        {
            return txtNombreSeccion.Text.Trim().Length != 0 && cbArea.Text.Trim().Length != 0;
        }

        private bool ValidacionParametrosSubSecciones()
        {

            return txtNombreSubSeccion.Text.Trim().Length != 0 && cbSeccion.Text.Trim().Length != 0;
        }

        private void HabilitarBotones(bool botonNuevo, bool botonModificar, bool botonGuardar, bool botonCancelar)
        {
            btnNuevoGerencia.Enabled = botonNuevo;
            btnModificarGerencia.Enabled = botonModificar;
            btnGuardarGerencia.Enabled = botonGuardar;
            btnCancelarGerencia.Enabled = botonCancelar;
        }

        private void HabilitarBotonesGerencias(bool botonNuevo, bool botonModificar, bool botonGuardar, bool botonCancelar)
        {
            btnNuevoGerencias.Enabled = botonNuevo;
            btnModificarGerencias.Enabled = botonModificar;
            btnGuardarGerencias.Enabled = botonGuardar;
            btnCancelarGerencias.Enabled = botonCancelar;
        }

        private void HabilitarBotonesAreas(bool botonNuevo, bool botonModificar, bool botonGuardar, bool botonCancelar)
        {
            btnNuevoAreas.Enabled = botonNuevo;
            btnModificarAreas.Enabled = botonModificar;
            btnGuardarAreas.Enabled = botonGuardar;
            btnCancelarAreas.Enabled = botonCancelar;
        }

        private void HabilitarBotonesSecciones(bool botonNuevo, bool botonModificar, bool botonGuardar, bool botonCancelar)
        {
            btnNuevaSeccion.Enabled = botonNuevo;
            btnModificarSeccion.Enabled = botonModificar;
            btnGuardarSeccion.Enabled = botonGuardar;
            btnCancelarSeccion.Enabled = botonCancelar;
        }

        private void HabilitarBotonesSubSecciones(bool botonNuevo, bool botonModificar, bool botonGuardar, bool botonCancelar)
        {
            btnNuevoSubSeccion.Enabled = botonNuevo;
            btnModificarSubSeccion.Enabled = botonModificar;
            btnGuardarSubSeccion.Enabled = botonGuardar;
            btnCancelarSubSeccion.Enabled = botonCancelar;
        }

        private void CargarGerencia()
        {
            try
            {
                var data = _objGerencia.SeleccionarTodosLosRegistrosGerencia(TipoCon);
                if (data == null || data.Rows.Count == 0)
                {
                    dgvGerencia.DataSource = null;
                    return;
                }
                dgvGerencia.DataSource = data;
                dgvGerencia.Columns[0].HeaderText = @"ID";
                dgvGerencia.Columns[1].HeaderText = @"CÓDIGO";
                dgvGerencia.Columns[2].HeaderText = @"DESCRIPCIÓN";
                dgvGerencia.Columns[3].Visible = false;
                dgvGerencia.Columns[4].Visible = false;
                dgvGerencia.Columns[5].Visible = false;
                dgvGerencia.AutoResizeColumns();
                dgvGerencia.AutoResizeRows();
            }
            catch (Exception ex)
            {
                dgvGerencia.DataSource = null;
                MessageBox.Show(@"Error al cargar gerencia: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarGerencias()
        {
            try
            {
                var data = _objGerencias.SeleccionarTodosLosRegistrosGerenciasGeneral(TipoCon);
                if (data == null || data.Rows.Count == 0)
                {
                    dgvGerencias.DataSource = null;
                    return;
                }
                dgvGerencias.DataSource = data;
                dgvGerencias.Columns[0].HeaderText = @"ID";
                dgvGerencias.Columns[1].HeaderText = @"CÓDIGO";
                dgvGerencias.Columns[2].HeaderText = @"DESCRIPCIÓN";
                dgvGerencias.Columns[3].Visible = false;
                dgvGerencias.Columns[4].Visible = false;
                dgvGerencias.AutoResizeColumns();
                dgvGerencias.AutoResizeRows();
            }
            catch (Exception ex)
            {
                dgvGerencias.DataSource = null;
                MessageBox.Show(@"Error al cargar gerencias: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarAreas()
        {
            try
            {
                var data = _objAreas.SeleccionarTodosLosRegistrosArea(TipoCon);
                if (data == null || data.Rows.Count == 0)
                {
                    dgvAreas.DataSource = null;
                    return;
                }
                dgvAreas.DataSource = data;
                dgvAreas.Columns[0].HeaderText = @"ID";
                dgvAreas.Columns[1].HeaderText = @"CÓDIGO";
                dgvAreas.Columns[2].HeaderText = @"DESCRIPCIÓN";
                dgvAreas.Columns[3].Visible = false;
                dgvAreas.Columns[4].Visible = false;
                dgvAreas.AutoResizeColumns();
                dgvAreas.AutoResizeRows();
            }
            catch (Exception ex)
            {
                dgvAreas.DataSource = null;
                MessageBox.Show(@"Error al cargar áreas: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarSecciones()
        {
            try
            {
                var data = _objSecciones.SeleccionarTodosLosRegistrosSeccion(TipoCon);
                if (data == null || data.Rows.Count == 0)
                {
                    dgvSecciones.DataSource = null;
                    return;
                }
                dgvSecciones.DataSource = data;
                dgvSecciones.Columns[0].HeaderText = @"ID";
                dgvSecciones.Columns[1].HeaderText = @"CÓDIGO";
                dgvSecciones.Columns[2].HeaderText = @"DESCRIPCIÓN";
                dgvSecciones.Columns[3].Visible = false;
                dgvSecciones.Columns[4].Visible = false;
                dgvSecciones.AutoResizeColumns();
                dgvSecciones.AutoResizeRows();
            }
            catch (Exception ex)
            {
                dgvSecciones.DataSource = null;
                MessageBox.Show(@"Error al cargar secciones: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarSubSecciones()
        {
            try
            {
                var data = _objSubSecciones.SeleccionarTodosLosRegistrosSubSeccion(TipoCon);
                if (data == null || data.Rows.Count == 0)
                {
                    dgvSubSecciones.DataSource = null;
                    return;
                }
                dgvSubSecciones.DataSource = data;
                dgvSubSecciones.Columns[0].HeaderText = @"ID";
                dgvSubSecciones.Columns[1].HeaderText = @"CÓDIGO";
                dgvSubSecciones.Columns[2].HeaderText = @"DESCRIPCIÓN";
                dgvSubSecciones.Columns[3].Visible = false;
                dgvSubSecciones.Columns[4].Visible = false;
                dgvSubSecciones.AutoResizeColumns();
                dgvSubSecciones.AutoResizeRows();
            }
            catch (Exception ex)
            {
                dgvSubSecciones.DataSource = null;
                MessageBox.Show(@"Error al cargar subsecciones: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LlenarComboEmpresa()
        {
            try
            {
                cbEmpresa.DataSource = _objEmpresa.SeleccionarTodosLosRegistrosEmpresa(TipoCon);
                cbEmpresa.DisplayMember = "RAZON_SOCIAL_EMPRESA";
                cbEmpresa.ValueMember = "ID_EMPRESA";
                if (((DataTable)cbEmpresa.DataSource).Rows.Count > 0) cbEmpresa.SelectedIndex = 0;
            }
            catch
            {
                cbEmpresa.DataSource = null;
            }
        }

        private void LlenarComboSucursal()
        {
            try
            {
                cbSucursal.DataSource = _objSucursal.SeleccionarTodosLosRegistrosSucursal(TipoCon);
                cbSucursal.DisplayMember = "NOMBRE_SUCURSAL";
                cbSucursal.ValueMember = "ID_SUCURSAL";
                if (((DataTable)cbSucursal.DataSource).Rows.Count > 0) cbSucursal.SelectedIndex = 0;
            }
            catch
            {
                cbSucursal.DataSource = null;
            }
        }

        private void LlenascomboGerencia()
        {
            try
            {
                cbGerencia.DataSource = _objGerencia.SeleccionarTodosLosRegistrosGerencia(TipoCon);
                cbGerencia.DisplayMember = "DESCRIPCION";
                cbGerencia.ValueMember = "ID_GERENCIA";
                if (((DataTable)cbGerencia.DataSource).Rows.Count > 0) cbGerencia.SelectedIndex = 0;
            }
            catch
            {
                cbGerencia.DataSource = null;
            }
        }

        private void LlenarcomboGerencias()
        {
            try
            {
                cbGerencias.DataSource = _objGerencias.SeleccionarTodosLosRegistrosGerenciasGeneral(TipoCon);
                cbGerencias.DisplayMember = "NOMBRE_GERENCIAS";
                cbGerencias.ValueMember = "ID_GERENCIAS_GENERAL";
                if (((DataTable)cbGerencias.DataSource).Rows.Count > 0) cbGerencias.SelectedIndex = 0;
            }
            catch
            {
                cbGerencias.DataSource = null;
            }
        }

        private void LlenarcomboAreas()
        {
            try
            {
                cbArea.DataSource = _objAreas.SeleccionarTodosLosRegistrosArea(TipoCon);
                cbArea.DisplayMember = "NOMBRE_AREA";
                cbArea.ValueMember = "ID_AREA_GENERAL";
                if (((DataTable)cbArea.DataSource).Rows.Count > 0) cbArea.SelectedIndex = 0;
            }
            catch
            {
                cbArea.DataSource = null;
            }
        }

        private void LlenarcomboSecciones()
        {
            try
            {
                cbSeccion.DataSource = _objSecciones.SeleccionarTodosLosRegistrosSeccion(TipoCon);
                cbSeccion.DisplayMember = "NOMBRE_SECCION";
                cbSeccion.ValueMember = "ID_SECCION";
                if (((DataTable)cbSeccion.DataSource).Rows.Count > 0) cbSeccion.SelectedIndex = 0;
            }
            catch
            {
                cbSeccion.DataSource = null;
            }
        }

        private void LimpiarParametrosGerencia()
        {
            txtIdGerencia.Clear();
            txtCodigoGerencia.Clear();
            txtDescripcionGerencia.Clear();
            cbEmpresa.SelectedIndex = 0;
            cbSucursal.SelectedIndex = 0;
        }

        private void LimpiarParametrosGerencias()
        {
            txtIdGerencias.Clear();
            txtCodigoGerencias.Clear();
            txtNombreGerencias.Clear();
            cbGerencia.SelectedIndex = 0;
            cbSucursal.SelectedIndex = 0;
        }

        private void LimpiarParametrosAreas()
        {
            txtIdAreas.Clear();
            txtCodigoAreas.Clear();
            txtNombreAreas.Clear();
            cbGerencias.SelectedIndex = 0;
        }

        private void LimpiarParametrosSecciones()
        {
            txtIdSeccion.Clear();
            txtCodigoSeccion.Clear();
            txtNombreSeccion.Clear();
            cbArea.SelectedIndex = 0;
        }

        private void LimpiarParametrosSubSecciones()
        {
            txtIdSubSeccion.Clear();
            txtCodigoSubSeccion.Clear();
            txtNombreSubSeccion.Clear();
            cbSeccion.SelectedIndex = 0;
        }

        private void btnNuevoGerencia_Click(object sender, EventArgs e)
        {
            LimpiarParametrosGerencia();
            HabilitarBotones(false, false, true, true);
            txtIdGerencia.Text = @"AUTO";
            HabilitarRegistroGerencia();
            _btnSelGerencia = 1;
        }

        private void btnNuevoGerencias_Click(object sender, EventArgs e)
        {
            LimpiarParametrosGerencias();
            LlenarCombos();
            HabilitarBotonesGerencias(false, false, true, true);
            txtIdGerencias.Text = @"AUTO";
            HabilitarRegistroGerencias();
            _btnSelGerencias = 1;
        }

        private void btnNuevoAreas_Click(object sender, EventArgs e)
        {
            LimpiarParametrosAreas();
            LlenarCombos();
            HabilitarBotonesAreas(false, false, true, true);
            txtIdAreas.Text = @"AUTO";
            HabilitarRegistrosAreas();
            _btnSelAreas = 1;
        }

        private void btnNuevaSeccion_Click(object sender, EventArgs e)
        {
            LimpiarParametrosSecciones();
            LlenarCombos();
            HabilitarBotonesSecciones(false, false, true, true);
            txtIdSeccion.Text = @"AUTO";
            HabilitarRegistrosSecciones();
            _btnSelSecciones = 1;
        }

        private void btnNuevoSubSeccion_Click(object sender, EventArgs e)
        {
            LimpiarParametrosSubSecciones();
            LlenarCombos();
            HabilitarBotonesSubSecciones(false, false, true, true);
            txtIdSubSeccion.Text = @"AUTO";
            HabilitarRegistrosSubSecciones();
            _btnSelSubSecciones = 1;
        }

        private void btnModificarGerencia_Click(object sender, EventArgs e)
        {
            HabilitarRegistroGerencia();
            HabilitarBotones(false, false, true, true);
            _btnSelGerencia = 2;
        }

        private void btnModificarGerencias_Click(object sender, EventArgs e)
        {
            HabilitarRegistroGerencias();
            HabilitarBotonesGerencias(false, false, true, true);
            _btnSelGerencias = 2;
        }

        private void btnModificarAreas_Click(object sender, EventArgs e)
        {
            btnReporteAreas.Enabled = false;
            HabilitarRegistrosAreas();
            HabilitarBotonesAreas(false, false, true, true);
            _btnSelAreas = 2;
        }

        private void btnModificarSeccion_Click(object sender, EventArgs e)
        {
            HabilitarRegistrosSecciones();
            HabilitarBotonesSecciones(false, false, true, true);
            _btnSelSecciones = 2;
        }

        private void btnModificarSubSeccion_Click(object sender, EventArgs e)
        {
            HabilitarRegistrosSubSecciones();
            HabilitarBotonesSubSecciones(false, false, true, true);
            _btnSelSubSecciones = 2;
        }

        private void btnCancelarGerencia_Click(object sender, EventArgs e)
        {
            LimpiarParametrosGerencia();
            HabilitarBotones(true, true, false, false);
            DeshabilitarRegistrosGerencia();
            _btnSelGerencia = 0;
        }

        private void btnCancelarGerencias_Click(object sender, EventArgs e)
        {
            LimpiarParametrosGerencias();
            HabilitarBotonesGerencias(true, true, false, false);
            DeshabilitarRegistrosGerencias();
            _btnSelGerencias = 0;
        }

        private void btnCancelarAreas_Click(object sender, EventArgs e)
        {
            LimpiarParametrosAreas();
            HabilitarBotonesAreas(true, true, false, false);
            DeshabilitarRegistrosAreas();
            _btnSelAreas = 0;
        }

        private void btnCancelarSeccion_Click(object sender, EventArgs e)
        {
            LimpiarParametrosSecciones();
            HabilitarBotonesSecciones(true, true, false, false);
            DeshabilitarRegistrosSecciones();
            _btnSelSecciones = 0;
        }

        private void btnCancelarSubSeccion_Click(object sender, EventArgs e)
        {
            LimpiarParametrosSubSecciones();
            HabilitarBotonesSubSecciones(true, true, false, false);
            DeshabilitarRegistrosSubSecciones();
            _btnSelSubSecciones = 0;
        }

        private void btnGuardarGerencia_Click(object sender, EventArgs e)
        {
            if (!ValidacionParametrosGerencia())
            {
                MessageBox.Show(@"Debe ingresar todos los datos para guardar!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(@"Desea guardar los cambios realizados?",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objGerencia.IdGerencia = _btnSelGerencia == 1 ? _objGerencia.BuscarMayorIdGerencia(TipoCon) + 1 :
                Convert.ToInt32(txtIdGerencia.Text.Trim());

            _objGerencia.CodigoGerencia = _btnSelGerencia == 1 ?
                cbEmpresa.SelectedValue + "." + cbSucursal.SelectedValue + "." + (_objGerencia.ContarMayorGerenciaPorIdEmpresa(TipoCon, Convert.ToInt32(cbEmpresa.SelectedValue), Convert.ToInt32(cbSucursal.SelectedValue)) + 1) :
                txtCodigoGerencia.Text.Trim();

            _objGerencia.DescripcionGerencia = txtDescripcionGerencia.Text.Trim();
            _objGerencia.EstadoGerencia = 1;
            _objGerencia.IdEmpresa = Convert.ToInt32(cbEmpresa.SelectedValue);
            _objGerencia.IdSucursal = Convert.ToInt32(cbSucursal.SelectedValue);
            _sqlCommands.Add(_btnSelGerencia == 1 ? _objGerencia.NuevaGerencia() : _objGerencia.ModificarGerencia());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR GERENCIA");

            if ((bool)res[0])
            {
                _btnSelGerencia = 0;
                DeshabilitarRegistrosGerencia();
                HabilitarBotones(true, true, false, false);
                CargarGerencia();
            }
            MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarGerencias_Click(object sender, EventArgs e)
        {
            if (!ValidacionParametrosGerencias())
            {
                MessageBox.Show(@"Debe ingresar todos los datos para guardar!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(@"Desea guardar los cambios realizados?",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objGerencias.GerenciasId = _btnSelGerencias == 1 ? _objGerencias.BuscarMayorIdGerencias(TipoCon) + 1 : Convert.ToInt32(txtIdGerencias.Text.Trim());

            _objGerencias.GerenciasCodigo = _btnSelGerencias == 1 ?
                (_objGerencias.GenerarCodigoSiguienteGerenciasPorIdGerencias(TipoCon, Convert.ToInt32(cbGerencia.SelectedValue)) + 1) + "" :
                txtCodigoGerencias.Text.Trim();

            _objGerencias.GerenciasNombre = txtNombreGerencias.Text.Trim();
            _objGerencias.GerenciasEstado = 1;
            _objGerencias.GerenciasIdGerencia = Convert.ToInt32(cbGerencia.SelectedValue);

            _sqlCommands.Add(_btnSelGerencias == 1 ? _objGerencias.NuevaGerencias() : _objGerencias.ModificarGerencias());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR GERENCIAS");

            if ((bool)res[0])
            {
                _btnSelGerencias = 0;
                DeshabilitarRegistrosGerencias();
                HabilitarBotonesGerencias(true, true, false, false);
                CargarGerencias();
            }
            MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarAreas_Click(object sender, EventArgs e)
        {
            if (!ValidacionParametrosAreas())
            {
                MessageBox.Show(@"Debe ingresar todos los datos para guardar!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(@"Desea guardar los cambios realizados?",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objAreas.AreaId = _btnSelAreas == 1 ? _objAreas.BuscarMayorIdArea(TipoCon) + 1 : Convert.ToInt32(txtIdAreas.Text.Trim());

            _objAreas.AreaCodigo = _btnSelAreas == 1 ?
                (_objAreas.GenerarCodigoSiguienteAreaPorIdGerencias(TipoCon, Convert.ToInt32(cbGerencias.SelectedValue)) + 1) + "" :
                txtCodigoAreas.Text.Trim();

            _objAreas.AreaNombre = txtNombreAreas.Text.Trim();
            _objAreas.AreaEstado = 1;
            _objAreas.AreaIdGerenciaGeneral = Convert.ToInt32(cbGerencias.SelectedValue);

            _sqlCommands.Add(_btnSelAreas == 1 ? _objAreas.NuevaAreas() : _objAreas.ModificarAreas());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR AREAS");

            if ((bool)res[0])
            {
                _btnSelAreas = 0;
                DeshabilitarRegistrosAreas();
                HabilitarBotonesAreas(true, true, false, false);
                CargarAreas();
            }
            MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarSeccion_Click(object sender, EventArgs e)
        {
            if (!ValidacionParametrosSecciones())
            {
                MessageBox.Show(@"Debe ingresar todos los datos para guardar!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(@"Desea guardar los cambios realizados?",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objSecciones.SeccionId = _btnSelSecciones == 1 ? _objSecciones.BuscarMayorIdSeccion(TipoCon) + 1 : Convert.ToInt32(txtIdSeccion.Text.Trim());

            _objSecciones.SeccionCodigo = _btnSelSecciones == 1 ?
                (_objSecciones.GenerarCodigoSiguienteSeccionPorIdArea(TipoCon, Convert.ToInt32(cbArea.SelectedValue)) + 1) + "" :
                txtCodigoSeccion.Text.Trim();

            _objSecciones.SeccionNombre = txtNombreSeccion.Text.Trim();
            _objSecciones.SeccionEstado = 1;
            _objSecciones.SeccionIdArea = Convert.ToInt32(cbArea.SelectedValue);

            _sqlCommands.Add(_btnSelSecciones == 1 ? _objSecciones.NuevaSeccion() : _objSecciones.ModificarSeccion());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR SECCION");

            if ((bool)res[0])
            {
                _btnSelSecciones = 0;
                DeshabilitarRegistrosSecciones();
                HabilitarBotonesSecciones(true, true, false, false);
                CargarSecciones();
            }
            MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardarSubSeccion_Click(object sender, EventArgs e)
        {
            if (!ValidacionParametrosSubSecciones())
            {
                MessageBox.Show(@"Debe ingresar todos los datos para guardar!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(@"Desea guardar los cambios realizados?",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objSubSecciones.SubSeccionId = _btnSelSubSecciones == 1 ? _objSubSecciones.BuscarMayorIdSubSeccion(TipoCon) + 1 : Convert.ToInt32(txtIdSubSeccion.Text.Trim());

            _objSubSecciones.SubSeccionCodigo = _btnSelSubSecciones == 1 ?
                (_objSubSecciones.GenerarCodigoSiguienteSubSeccionPorIdSubSeccion(TipoCon, Convert.ToInt32(cbSeccion.SelectedValue)) + 1) + "" :
                txtCodigoSubSeccion.Text.Trim();

            _objSubSecciones.SubSeccionNombre = txtNombreSubSeccion.Text.Trim();
            _objSubSecciones.SubSeccionEstado = 1;
            _objSubSecciones.SubSeccionidSeccion = Convert.ToInt32(cbSeccion.SelectedValue);

            _sqlCommands.Add(_btnSelSubSecciones == 1 ? _objSubSecciones.NuevaSubSeccion() : _objSubSecciones.ModificarSubSeccion());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR SUBSECCION");

            if ((bool)res[0])
            {
                _btnSelSubSecciones = 0;
                DeshabilitarRegistrosSubSecciones();
                HabilitarBotonesSubSecciones(true, true, false, false);
                CargarSubSecciones();
            }
            MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvGerencia_SelectionChanged(object sender, EventArgs e)
        {
            if (_btnSelGerencia != 0) return;
            if (dgvGerencia.CurrentRow == null) return;
            try
            {
                txtIdGerencia.Text = dgvGerencia.CurrentRow.Cells[0].Value.ToString();
                txtCodigoGerencia.Text = dgvGerencia.CurrentRow.Cells[1].Value.ToString();
                txtDescripcionGerencia.Text = dgvGerencia.CurrentRow.Cells[2].Value.ToString();
                cbEmpresa.SelectedValue = dgvGerencia.CurrentRow.Cells[4].Value.ToString();
                cbSucursal.SelectedValue = dgvGerencia.CurrentRow.Cells[5].Value.ToString();
                btnModificarGerencia.Enabled = true;
            }
            catch
            {
                LimpiarParametrosGerencia();
                btnModificarGerencia.Enabled = false;
            }
        }

        private void dgvGerencias_SelectionChanged(object sender, EventArgs e)
        {
            if (_btnSelGerencias != 0) return;
            if (dgvGerencias.CurrentRow == null) return;
            try
            {
                txtIdGerencias.Text = dgvGerencias.CurrentRow.Cells[0].Value.ToString();
                txtCodigoGerencias.Text = dgvGerencias.CurrentRow.Cells[1].Value.ToString();
                txtNombreGerencias.Text = dgvGerencias.CurrentRow.Cells[2].Value.ToString();
                cbGerencia.SelectedValue = dgvGerencias.CurrentRow.Cells[4].Value.ToString();
                btnModificarGerencias.Enabled = true;
            }
            catch
            {
                LimpiarParametrosGerencias();
                btnModificarGerencias.Enabled = false;
            }
        }

        private void dgvAreas_SelectionChanged(object sender, EventArgs e)
        {
            if (_btnSelAreas != 0) return;
            if (dgvAreas.CurrentRow == null) return;
            try
            {
                txtIdAreas.Text = dgvAreas.CurrentRow.Cells[0].Value.ToString();
                txtCodigoAreas.Text = dgvAreas.CurrentRow.Cells[1].Value.ToString();
                txtNombreAreas.Text = dgvAreas.CurrentRow.Cells[2].Value.ToString();
                cbGerencias.SelectedValue = dgvAreas.CurrentRow.Cells[4].Value.ToString();
                btnModificarAreas.Enabled = true;
            }
            catch
            {
                LimpiarParametrosAreas();
                btnModificarAreas.Enabled = false;
            }
        }

        private void dgvSecciones_SelectionChanged(object sender, EventArgs e)
        {
            if (_btnSelSecciones != 0) return;
            if (dgvSecciones.CurrentRow == null) return;
            try
            {
                txtIdSeccion.Text = dgvSecciones.CurrentRow.Cells[0].Value.ToString();
                txtCodigoSeccion.Text = dgvSecciones.CurrentRow.Cells[1].Value.ToString();
                txtNombreSeccion.Text = dgvSecciones.CurrentRow.Cells[2].Value.ToString();
                cbArea.SelectedValue = dgvSecciones.CurrentRow.Cells[4].Value.ToString();
                btnModificarSeccion.Enabled = true;
            }
            catch
            {
                LimpiarParametrosSecciones();
                btnModificarSeccion.Enabled = false;
            }
        }

        private void dgvSubSecciones_SelectionChanged(object sender, EventArgs e)
        {
            if (_btnSelSubSecciones != 0) return;
            if (dgvSubSecciones.CurrentRow == null) return;
            try
            {
                txtIdSubSeccion.Text = dgvSubSecciones.CurrentRow.Cells[0].Value.ToString();
                txtCodigoSubSeccion.Text = dgvSubSecciones.CurrentRow.Cells[1].Value.ToString();
                txtNombreSubSeccion.Text = dgvSubSecciones.CurrentRow.Cells[2].Value.ToString();
                cbSeccion.SelectedValue = dgvSubSecciones.CurrentRow.Cells[4].Value.ToString();
                btnModificarSubSeccion.Enabled = true;
            }
            catch
            {
                LimpiarParametrosSubSecciones();
                btnModificarSubSeccion.Enabled = false;
            }
        }

        private void btnReportesGerencia_Click(object sender, EventArgs e)
        {
            try
            {
                _frmReportes.TipoCon = TipoCon;
                _frmReportes.Titulo = "REPORTE DE GERENCIAS";
                _rptGerencia.SetDataSource(_objGerencia.SeleccionarTodosLosRegistrosGerencia(TipoCon));
                _rptGerencia.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, Application.StartupPath)); 
                _frmReportes.crystalReportViewer1.ReportSource = _rptGerencia;
                _frmReportes.ShowDialog();
            }
            catch
            {
                MessageBox.Show(@"Error al generar reporte!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReporteGerencias_Click(object sender, EventArgs e)
        {
            try
            {
                _frmReportes.TipoCon = TipoCon;
                _frmReportes.Titulo = "REPORTE DE GERENCIAS";
                _rptGerencias.SetDataSource(_objGerencias.SeleccionarTodosLosRegistrosGerenciasGeneral(TipoCon));
                _rptGerencias.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, Application.StartupPath)); 
                _frmReportes.crystalReportViewer1.ReportSource = _rptGerencias;
                _frmReportes.ShowDialog();
            }
            catch
            {
                MessageBox.Show(@"Error al generar reporte!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReporteAreas_Click(object sender, EventArgs e)
        {
            try
            {
                _frmReportes.TipoCon = TipoCon;
                _frmReportes.Titulo = "REPORTE DE ÁREAS";
                _rptAreas.SetDataSource(_objAreas.SeleccionarTodosLosRegistrosArea(TipoCon));
                _rptAreas.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, Application.StartupPath)); 
                _frmReportes.crystalReportViewer1.ReportSource = _rptAreas;
                _frmReportes.ShowDialog();
            }
            catch
            {
                MessageBox.Show(@"Error al generar reporte!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReportesSeccion_Click(object sender, EventArgs e)
        {
            try
            {
                _frmReportes.TipoCon = TipoCon;
                _frmReportes.Titulo = "REPORTE DE SECCIONES";
                _rptSeccion.SetDataSource(_objSecciones.SeleccionarTodosLosRegistrosSeccion(TipoCon));
                _rptSeccion.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, Application.StartupPath)); 
                _frmReportes.crystalReportViewer1.ReportSource = _rptSeccion;
                _frmReportes.ShowDialog();
            }
            catch
            {
                MessageBox.Show(@"Error al generar reporte!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReporteSubSeccion_Click(object sender, EventArgs e)
        {
            try
            {
                _frmReportes.TipoCon = TipoCon;
                _frmReportes.Titulo = "REPORTE DE SUBSECCIONES";
                _rptSubSeccion.SetDataSource(_objSubSecciones.SeleccionarTodosLosRegistrosSubSeccion(TipoCon));
                _rptSubSeccion.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, Application.StartupPath)); 
                _frmReportes.crystalReportViewer1.ReportSource = _rptSubSeccion;
                _frmReportes.ShowDialog();
            }
            catch
            {
                MessageBox.Show(@"Error al generar reporte!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmEstructuraAdministrativa_Resize(object sender, EventArgs e)
        {
           
        }
    }
}
