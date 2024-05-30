using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.DivisionGeografica;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.EstructuraEmpresa;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using Microsoft.Office.Interop.Excel;
using SysCisepro3.Datos;
using SysCisepro3.Operaciones;
using SysCisepro3.Properties;
using Office = Microsoft.Office.Interop;
using DataTable = System.Data.DataTable;
using Krypton.Toolkit;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmPersonal : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para registrar datos del personal, ingresos y salidas de la cia
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private readonly ClassPersonal _objPersonal;
        private readonly ClassAspirante _objAspirante;
        private readonly ClassContratos _objContratos;
        private readonly ClassSecuencialContratos _objSecuencialContratos;
        private readonly ClassBancos _objBancos;
        private readonly ClassHistorialLaboral _objHistorialLaboral;
        private readonly ClassCuentaPersonal _objCuentaPersonal;
        private readonly ClassArea _objArea;
        private readonly ClassCargo _objCargo;
        private readonly ClassProvincias _objProvincias;
        private readonly ClassCiudades _objCiudades;
        private readonly ClassParroquias _objParroquias;
        private readonly ClassSitiosTrabajo _objSitiosTrabajo;
        private readonly ClassDocumentosContrato _objDocumentosContrato;
        private FrmNotificarNovedades _frmNotificacion;

        private List<object[]> docs;


        private static FrmPersonal _instance;
        public static FrmPersonal Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmPersonal();
                return _instance;
            }
        }

        private FrmBuscarPuestoTrabajo _frmBuscarPuestoTrabajo;
        private FrmSeleccionarMotivoFechaSalida _objMotivoFechaSalida;
        private FrmBuscarAspirante _frmBuscarAspirante;

        private readonly List<SqlCommand> _sqlCommands;

        private int _estado;

        private FrmPersonal()
        {
            InitializeComponent();
            _estado = 0;
            docs = new List<object[]>();
            _sqlCommands = new List<SqlCommand>();
            _objPersonal = new ClassPersonal();
            _objAspirante = new ClassAspirante();
            _objContratos = new ClassContratos();
            _objSecuencialContratos = new ClassSecuencialContratos();
            _objBancos = new ClassBancos();
            _objHistorialLaboral = new ClassHistorialLaboral();
            _objCuentaPersonal = new ClassCuentaPersonal();
            _objArea = new ClassArea();
            _objCargo = new ClassCargo();
            _objProvincias = new ClassProvincias();
            _objCiudades = new ClassCiudades();
            _objParroquias = new ClassParroquias();
            _objSitiosTrabajo = new ClassSitiosTrabajo();
            _objDocumentosContrato = new ClassDocumentosContrato();
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {
            toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            DataGridView1.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvPersonal.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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

            pbFoto.Image = Resources._default;
            pbPerfil.Image = Resources._default;
            PictureBox1.Image = Resources._default;
            dgvPersonal.Font = new System.Drawing.Font("Roboto", 8, FontStyle.Regular);
            CargarProyectos(true);
            CargarProvincias();
            CargarBancos();
            CargarAreas();
            CargarCargos();

            txtFiltro.Focus();
        }

        private void CargarProyectos(bool todos)
        {
            try
            {
                cbxProyecto.DataSource = _objContratos.SeleccionarTodosLosRegistrosProyectos(TipoCon, todos);
                cbxProyecto.DisplayMember = "PROYECTO";
                cbxProyecto.ValueMember = "ID_PROYECTO";
                if (((DataTable)cbxProyecto.DataSource).Rows.Count > 0) cbxProyecto.SelectedIndex = 0; 
            }
            catch
            {
                cbxProyecto.DataSource = null;
            }
        }
    
        private void CargarProvincias()
        {
            try
            {
                cbmProvincia.DataSource = _objProvincias.SeleccionarTodosLosRegistrosProvincias(TipoCon);
                cbmProvincia.DisplayMember = "NOMBRE_PROVINCIAS";
                cbmProvincia.ValueMember = "ID_PROVINCIAS";
                if (((DataTable)cbmProvincia.DataSource).Rows.Count > 0) cbmProvincia.SelectedIndex = 0;
            }
            catch
            {
                cbmProvincia.DataSource = null;
            }
        }

        private void cbmProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbmProvincia.DataSource == null) return;
            if (cbmProvincia.SelectedValue is DataRowView) return;
            if (cbmProvincia.SelectedValue == null) return;
            CargarCiudades(cbmProvincia.SelectedValue.ToString());
        }

        private void CargarCiudades(string idp)
        {
            try
            {
                cbmCanton.DataSource = _objCiudades.BuscarNombreCiudadesXIdProvincia(TipoCon, idp);
                cbmCanton.DisplayMember = "NOMBRE_CIUDADES";
                cbmCanton.ValueMember = "ID_CIUDAD";
                if (((DataTable)cbmCanton.DataSource).Rows.Count > 0) cbmCanton.SelectedIndex = 0;
            }
            catch
            {
                cbmCanton.DataSource = null;
            }
        }

        private void cbmCanton_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbmCanton.DataSource == null) return;
            if (cbmCanton.SelectedValue is DataRowView) return;
            if (cbmCanton.SelectedValue == null) return;
            CargarParroquias(cbmCanton.SelectedValue.ToString());
        }

        private void CargarParroquias(string idc)
        {
            try
            {
                cbmParroquia.DataSource = _objParroquias.BuscarNombreParroquiaXIdCiudades(TipoCon, idc);
                cbmParroquia.DisplayMember = "NOMBRE_PARROQUIAS";
                cbmParroquia.ValueMember = "ID_PARROQUIAS";
                if (((DataTable)cbmParroquia.DataSource).Rows.Count > 0) cbmParroquia.SelectedIndex = 0;
            }
            catch
            {
                cbmParroquia.DataSource = null;
            }
        }

        private void CargarBancos()
        {
            try
            {
                cbxBanco.DataSource = _objBancos.SeleccionarRegistrosBancos(TipoCon);
                cbxBanco.DisplayMember = "NOMBRE_BANCO";
                cbxBanco.ValueMember = "ID_BANCO";
                if (((DataTable)cbxBanco.DataSource).Rows.Count > 0) cbxBanco.SelectedIndex = 0;
            }
            catch
            {
                cbxBanco.DataSource = null;
            }
        }

        private void CargarAreas()
        {
            try
            {
                cbArea.DataSource = _objArea.SeleccionarTodosLosRegistrosAreaRh(TipoCon);
                cbArea.DisplayMember = "NOMBRE_AREA";
                cbArea.ValueMember = "NOMBRE_AREA";
                if (((DataTable)cbArea.DataSource).Rows.Count > 0) cbArea.SelectedIndex = 0;
            }
            catch
            {
                cbArea.DataSource = null;
            }
        }

        private void CargarCargos()
        {
            try
            {
                cbCargo.DataSource = _objCargo.SeleccionarTodosLosRegistrosCargos(TipoCon);
                cbCargo.DisplayMember = "DESCRIPCION";
                cbCargo.ValueMember = "ID_CARGO_OCUPACIONAL";
                if (((DataTable)cbCargo.DataSource).Rows.Count > 0) cbCargo.SelectedIndex = 0;
            }
            catch
            {
                cbCargo.DataSource = null;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            CargarPersonal(string.Empty);
        }

        private void CargarPersonal(string filtro)
        {
            try
            {
                dgvPersonal.DataSource = _objPersonal.SeleccionarTodosRegistrosPersonalFiltroTodos(TipoCon, filtro);
                if (dgvPersonal.RowCount == 0) return;
                for (var i = 9; i <= dgvPersonal.ColumnCount - 1; i++) dgvPersonal.Columns[i].Visible = false;

                dgvPersonal.Columns[0].HeaderText = @"ID";
                dgvPersonal.Columns[0].Width = 50;
                dgvPersonal.Columns[1].Width = 80;
                dgvPersonal.Columns[2].Width = 120;
                dgvPersonal.Columns[3].Width = 120;
                dgvPersonal.Columns[4].Width = 120;
                dgvPersonal.Columns[5].Width = 300;
                dgvPersonal.Columns[6].HeaderText = @"F. NACIM.";
                dgvPersonal.Columns[6].Width = 120;
                dgvPersonal.Columns[7].Width = 90;
                dgvPersonal.Columns[8].Width = 120;
                //dgvPersonal.Columns[58].Width = 50;
                dgvPersonal.AutoResizeRows();

                foreach (var row in dgvPersonal.Rows.Cast<DataGridViewRow>().Where(row => Convert.ToInt32(row.Cells[18].Value) != 1))
                    row.DefaultCellStyle.BackColor = Color.Coral;

                dgvPersonal_SelectionChanged(null, null);
            }
            catch
            {
                dgvPersonal.DataSource = null;
            }
        }

        private void dgvPersonal_SelectionChanged(object sender, EventArgs e)
        {
            if (_estado != 0 || dgvPersonal.CurrentRow == null) return;
            try
            {
                var row = dgvPersonal.CurrentRow;

                lblIdPersonal.Text = row.Cells["ID_PERSONAL"].Value.ToString();
                txtCedula.Text = row.Cells["CEDULA"].Value.ToString();
                lblValCed.Visible = false;
                lblValCon.Visible = false;
                txtNombres.Text = row.Cells["NOMBRES"].Value.ToString();
                txtApellidos.Text = row.Cells["APELLIDOS"].Value.ToString();
                cbmSexo.Text = row.Cells["SEXO"].Value.ToString();
                dtpFechaNacimiento.Value = Convert.ToDateTime(row.Cells["FECHA_NACIMIENTO"].Value);

                txtEdad.Text = row.Cells["EDAD"].Value.ToString();
                cbEstadoCivil.Text = row.Cells["ESTADO_CIVIL"].Value.ToString();
                txtPasaporte.Text = row.Cells["PASAPORTE"].Value.ToString();
                cbmInstruccion.Text = row.Cells["INSTRUCCION"].Value.ToString();
                txtLibreta.Text = row.Cells["LIBRETA_MILITAR"].Value.ToString();
                cbmTipoSangre.Text = row.Cells["TIPO_SANGRE"].Value.ToString();
                txtPeso.Text = row.Cells["PESO"].Value.ToString();
                txtEstatura.Text = row.Cells["ESTATURA"].Value.ToString();
                object credencial = row.Cells["CREDENCIAL"].Value;
                
                if (credencial == DBNull.Value || Convert.ToInt32(credencial) == 0)
                {
                chkcredencial.Checked = false;
                }
                else 
                    {
                chkcredencial.Checked = true;
                }

                cbmProvincia.Text = row.Cells["PROVINCIA"].Value.ToString();
                cbmCanton.Text = row.Cells["CIUDAD"].Value.ToString();
                cbmParroquia.Text = row.Cells["PARROQUIA"].Value.ToString();

                txtDireccion.Text = row.Cells["DIRECCION"].Value.ToString();
                txtTelefono.Text = row.Cells["TELEFONO"].Value.ToString();
                txtMovil.Text = row.Cells["MOVIL"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();

                chkHistoriaClinica.Checked = row.Cells["HISTORIA_CLINICA"].Value.ToString().Equals("SI");
                cbmPruebaAntiDroga.Text = row.Cells["PRUEBA_ANTIDROGA"].Value.ToString();
                chbDiscapacitado.Checked = row.Cells["DISCAPACIDAD"].Value.ToString().Equals("SI");
                txtCarnetConadis.Text = row.Cells["CARNET_CONADIS"].Value.ToString();

                try
                {
                    var d = row.Cells["EXAMEN_PSICOLOGICO"].Value.ToString();
                    var da = d.Contains(";") ? d.Split(';')[0] : d;

                    chbExamenPsicologico.Checked = da.Equals("SI");
                    txtDocumentacion.Text = d.Contains(";") ? d.Substring(3, d.Length - 3) : string.Empty;
                }
                catch
                {
                    chbExamenPsicologico.Checked = row.Cells["EXAMEN_PSICOLOGICO"].Value.ToString().Equals("SI");
                }

                txtLugarExamenPsicologico.Text = row.Cells["LUGAR_EXAMEN_PSICOLOGICO"].Value.ToString();
                chkCursoVigilante.Checked = row.Cells["CURSO_VIGILANTE"].Value.ToString().Equals("SI");

                txtEmisorCursoVigilante.Text = chkCursoVigilante.Checked ? row.Cells["EMISOR_CURSO_VIGILANTE"].Value.ToString() : @"NO TIENE";

                dtpFechaIngreso.Text = row.Cells["FECHA_ENTRADA"].Value.ToString();

                chSalida.Checked = Convert.ToInt32(row.Cells["ESTADO_PERSONAL"].Value) == 0;
                dtpFechaSalida.Text = row.Cells["FECHA_SALIDA"].Value.ToString();

                panelEsatdo.BackColor = chSalida.Checked ? Color.Maroon : Color.DarkGreen;

                txtMotivoSalidaActual.Text = chSalida.Checked ? "RENUNCIA VOLUNTARIA" : @"EN FUNCIONES";

                txtMotivoSalidaAnterior.Text = row.Cells["MOTIVO_SALIDA_TRABAJO"].Value.ToString();
                cbCargo.SelectedValue = row.Cells["ID_CARGO_OCUPACIONAL"].Value.ToString();

                cbArea.SelectedValue = row.Cells["NOMBRE_AREA"].Value.ToString();

                try
                {
                    txtSitio.Tag = row.Cells["UBICACION"].Value;
                    txtSitio.Text = _objSitiosTrabajo.BuscarNombreSitioxIdSitio(TipoCon, txtSitio.Tag.ToString(), false).Trim();

                    if (txtSitio.Text.Trim().Length == 0)
                    {
                        txtSitio.Tag = 0;
                        txtSitio.Text = @"AUN NO SE ESPECIFICA";
                    }
                }
                catch
                {
                    txtSitio.Tag = 0;
                    txtSitio.Text = @"AUN NO SE ESPECIFICA";
                }

                NupSueldo.Value = (row.Cells["SUELDO"].Value + "").Trim().Length == 0 ? 0 : Convert.ToDecimal(row.Cells["SUELDO"].Value);

                chCasaPropia.Checked = row.Cells["CASA"].Value.ToString().Equals("SI");
                chArrienda.Checked = row.Cells["ARRIENDO"].Value.ToString().Equals("SI");
                chDeudorGarante.Checked = row.Cells["DEUDOR_GARANTE"].Value.ToString().Equals("SI");
                txtCantidadDeuda.Text = row.Cells["CANTIDAD_DEUDA"].Value.ToString();
                txtAquienAdeuda.Text = row.Cells["A_QUIEN_ADEUDA"].Value.ToString();
                nudCantidadHijos.Value = (row.Cells["CANTIDAD_HIJOS"].Value + "").Trim().Length == 0 ? 0 : Convert.ToDecimal(row.Cells["CANTIDAD_HIJOS"].Value);
                txtDatosHijos.Text = row.Cells["DATOS_HIJOS"].Value.ToString();
                txtDatosEsposa.Text = row.Cells["DATOS_ESPOSA"].Value.ToString();
                txtDatosFamiliar.Text = row.Cells["DATOS_FAMILIARES"].Value.ToString();
                txtDatosEmergencia.Text = row.Cells["DATOS_EMERGENCIA"].Value.ToString();
                chTrabajoAnterior.Checked = row.Cells["TRABAJO_ATERIORMENTE"].Value.ToString().Equals("SI");
                txtEmpresaLugar.Text = row.Cells["ANTERIOR_TRABAJO"].Value.ToString();
                txtCargoOcupo.Text = row.Cells["CARGO_ANTERIOR_TRABAJO"].Value.ToString();
                txtMotivoSalidaAnterior.Text = row.Cells["MOTIVO_SALIDA_TRABAJO"].Value.ToString();
                dtpFechaEntradaReferencia.Text = row.Cells["ENTRADA_ANTERIOR"].Value.ToString();
                dtpFechaSalidaReferencia.Text = row.Cells["SALIDA_ANTERIOR"].Value.ToString();
                txtNombresUltimoPatrono.Text = row.Cells["NOMBRES_PATRONO_ANTERIOR"].Value.ToString();
                txtTelefonoUltimoPatrono.Text = row.Cells["TELEFONO_PATRONO_ANTERIOR"].Value.ToString();
                txtRecomendaciones.Text = row.Cells["RECOMENDACIONES"].Value.ToString();

                try
                {
                    var cuenta = _objCuentaPersonal.SeleccionarCuenta(TipoCon, lblIdPersonal.Text.Trim());
                    cbxBanco.SelectedValue = cuenta.Rows[0][1];
                    txtNumCuenta.Text = cuenta.Rows[0][2].ToString().Trim();
                    cbxTipoCuenta.Text = cuenta.Rows[0][3].ToString().Trim();
                }
                catch
                {
                    txtNumCuenta.Clear();
                    cbxBanco.SelectedIndex = 0;
                    cbxTipoCuenta.SelectedIndex = 0;
                }

                try
                {
                    // contrato activo
                    var contrato = _objContratos.SeleccionarContratosPorIdPersonalGeneral1(TipoCon, lblIdPersonal.Text.Trim());
                    lblIdPersonal.Tag = contrato.Rows[0][0].ToString();

                    txtContrato.Text = contrato.Rows[0][1].ToString();
                    cbmTipoContrato.SelectedIndex = Convert.ToInt32(contrato.Rows[0][8]);

                    chkAfiliado.Checked = contrato.Rows[0][10].ToString().Equals("1");
                    dtpFechaAfiliado.Value = Convert.ToDateTime(contrato.Rows[0][11]);

                    txtObservacion.Text = contrato.Rows[0][15].ToString();

                    chkFondoRes.Checked = contrato.Rows[0][12].ToString().Equals("1");
                    chkXiii.Checked = contrato.Rows[0][13].ToString().Equals("1");
                    chkXiv.Checked = contrato.Rows[0][14].ToString().Equals("1");
                    chkAcumulaFondo.Checked = contrato.Rows[0][17].ToString().Equals("1");

                    cbxProyecto.SelectedValue = Convert.ToInt32(contrato.Rows[0][19]);

                    NupExtra.Value = Convert.ToDecimal(contrato.Rows[0][16]);                  
                }
                catch
                {
                    try
                    {
                        // contrato retirado
                        var contrato = _objContratos.SeleccionarContratoFiniquitoPorIdPersonalGeneral1(TipoCon, lblIdPersonal.Text.Trim());
                        lblIdPersonal.Tag = contrato.Rows[0][0].ToString();

                        txtContrato.Text = contrato.Rows[0][1].ToString();
                        cbmTipoContrato.SelectedIndex = Convert.ToInt32(contrato.Rows[0][8]);

                        chkAfiliado.Checked = contrato.Rows[0][10].ToString().Equals("1");
                        dtpFechaAfiliado.Value = Convert.ToDateTime(contrato.Rows[0][11]);

                        txtObservacion.Text = contrato.Rows[0][15].ToString();

                        chkFondoRes.Checked = contrato.Rows[0][12].ToString().Equals("1");
                        chkXiii.Checked = contrato.Rows[0][13].ToString().Equals("1");
                        chkXiv.Checked = contrato.Rows[0][14].ToString().Equals("1");
                        chkAcumulaFondo.Checked = contrato.Rows[0][17].ToString().Equals("1");

                        cbxProyecto.SelectedValue = Convert.ToInt32(contrato.Rows[0][19]);

                        NupExtra.Value = Convert.ToDecimal(contrato.Rows[0][16]);
                    }
                    catch
                    {
                        lblIdPersonal.Tag = "0";
                        txtContrato.Text = @"NO TIENE";
                        cbmTipoContrato.SelectedIndex = 1;
                        cbxProyecto.SelectedIndex = 0;
                        chkAfiliado.Checked = false;
                        dtpFechaAfiliado.Value = DateTime.Now;
                        txtObservacion.Clear();
                        chkFondoRes.Checked = false;
                        chkXiii.Checked = false;
                        chkXiv.Checked = false;
                        NupExtra.Value = 0;
                        chkAcumulaFondo.Checked = false;
                    }
                }

                try
                {
                    pbFoto.Image = ValidationForms.BytesToImage((byte[])row.Cells["FOTO"].Value);
                    PictureBox1.Image = ValidationForms.BytesToImage((byte[])row.Cells["FOTO"].Value);
                }
                catch
                {
                    PictureBox1.Image = Resources._default;
                    pbFoto.Image = Resources._default;
                }

                try
                {
                    pbPerfil.Image = ValidationForms.BytesToImage((byte[])row.Cells["PERFIL"].Value);
                }
                catch
                {
                    pbPerfil.Image = Resources._default;
                }


                CargarHistorialLaboral(lblIdPersonal.Text.Trim());

                if (Convert.ToInt32(row.Cells["ESTADO_PERSONAL"].Value) == 1)
                {
                    ButtonNuevoRegistro.Enabled = true;
                    ButtonGuardar.Enabled = false;
                    ButtonModificarRegistro.Enabled = true;
                    ButtonEliminarRegistro.Enabled = true;
                    ButtonCancelar.Enabled = false;
                }
                else
                {
                    ButtonNuevoRegistro.Enabled = true;
                    ButtonGuardar.Enabled = false;
                    ButtonModificarRegistro.Enabled = false;
                    ButtonEliminarRegistro.Enabled = false;
                    ButtonCancelar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error al cargar detalles del personal: " + ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarHistorialLaboral(string p)
        {
            try
            {
                var data = _objHistorialLaboral.SeleccionarTodosRegistrosHistorialPersonal(TipoCon, p);
                DataGridView1.DataSource = data;
                if (data.Rows.Count == 0) return;
                DataGridView1.Columns[0].Width = 40;
                DataGridView1.Columns[1].Width = 120;
                DataGridView1.Columns[2].Width = 820;
                DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                DataGridView1.AutoResizeRows();
            }
            catch
            {
                DataGridView1.DataSource = null;
            }
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            CargarPersonal(txtFiltro.Text.Trim());
        }

        private void LimpiarParametros()
        {
            lblIdPersonal.Text = "0";
            lblIdPersonal.Tag = "0";
            docs.Clear();
            txtCedula.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            cbmSexo.SelectedIndex = 0;
            dtpFechaNacimiento.Value = DateTime.Now;
            cbEstadoCivil.SelectedIndex = 0;
            txtPasaporte.Text = @"NO TIENE";
            txtEdad.Text = @"0";
            txtLibreta.Text = @"NO TIENE";
            cbmProvincia.SelectedIndex = 0;
            cbmCanton.SelectedIndex = 0;
            cbmParroquia.SelectedIndex = 0;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtMovil.Clear();
            txtEmail.Clear();
            cbxBanco.SelectedIndex = 0;
            txtNumCuenta.Clear();
            cbxTipoCuenta.SelectedIndex = 0;
            cbmTipoSangre.SelectedIndex = 0;
            txtPeso.Text = @"0";
            txtEstatura.Text = @"0";
            chkcredencial.Checked = false;

            panelEsatdo.BackColor = Color.White;

            chkHistoriaClinica.Checked = false;
            cbmPruebaAntiDroga.SelectedIndex = 0;
            chbDiscapacitado.Checked = false;
            txtCarnetConadis.Text = @"NO TIENE";
            chbExamenPsicologico.Checked = false;
            txtLugarExamenPsicologico.Text = @"NO TIENE";
            chkCursoVigilante.Checked = false;
            txtEmisorCursoVigilante.Text = @"NO TIENE";
            txtDocumentacion.Text = @"NO TIENE";

            dtpFechaIngreso.Value = DateTime.Now;
            chSalida.Checked = false;
            chSalida_CheckedChanged(null, null);

            chkAfiliado.Checked = false;
            chkAfiliado_CheckedChanged(null, null);

            txtMotivoSalidaActual.Text = @"EN FUNCIONES";
            cbCargo.SelectedIndex = 0;
            cbArea.SelectedIndex = 0;
            if (cbxProyecto.DataSource != null) cbxProyecto.SelectedIndex = 0;
            txtSitio.Text = @"AUN NO SE ESPECIFICA";
            cbmInstruccion.SelectedIndex = 0;
            cbmTipoContrato.SelectedIndex = 1;

            NupSueldo.Value = 0;
            NupExtra.Value = 0;
            txtObservacion.Clear();
            chCasaPropia.Checked = false;
            chArrienda.Checked = false;
            chDeudorGarante.Checked = false;
            txtCantidadDeuda.Text = @"0.00";
            txtAquienAdeuda.Text = @"SIN DATO DE QUIEN ADEUDA";
            nudCantidadHijos.Value = 0;
            txtDatosHijos.Text = @"PENDIENTE";
            txtDatosEsposa.Text = @"PENDIENTE";
            txtDatosFamiliar.Text = @"PENDIENTE";
            txtDatosEmergencia.Text = @"PENDIENTE";
            chTrabajoAnterior.Checked = false;
            txtCargoOcupo.Text = @"SIN DATO DE CARGO QUE OCUPO";
            txtEmpresaLugar.Text = @"SIN DATO DE EMPRESA O LUGAR";
            txtMotivoSalidaAnterior.Text = @"SIN DATO DE MOTIVO DE SALIDA";
            dtpFechaEntradaReferencia.Value = DateTime.Now;
            dtpFechaSalidaReferencia.Value = DateTime.Now;
            txtNombresUltimoPatrono.Text = @"SIN NOMBRE DE ULTIMO PATRONO";
            txtTelefonoUltimoPatrono.Text = @"SIN TELEFONO DE ULTIMO PATRONO";
            txtRecomendaciones.Text = @"NO TIENE";
            txtContrato.Clear();
            txtContrato.Tag = null;
            lblValCon.Tag = 0;

            DataGridView1.DataSource = null;

            pbFoto.Image = Resources._default;
            pbPerfil.Image = Resources._default;
            PictureBox1.Image = Resources._default;
        }

        private void HabilitarRegistro(bool enable, bool secundarios)
        {
            txtCedula.Enabled = enable;
            txtContrato.Enabled = false;
            txtNombres.Enabled = enable;
            txtApellidos.Enabled = enable;
            cbmSexo.Enabled = enable;
            dtpFechaNacimiento.Enabled = enable;
            txtEdad.Enabled = enable;
            cbEstadoCivil.Enabled = enable;
            cbmInstruccion.Enabled = enable;
            txtPasaporte.Enabled = enable;
            txtLibreta.Enabled = enable;
            cbmTipoSangre.Enabled = enable;
            txtPeso.Enabled = enable;
            txtEstatura.Enabled = enable;
            chkcredencial.Enabled = enable;
            cbmProvincia.Enabled = enable;
            cbmCanton.Enabled = enable;
            cbmParroquia.Enabled = enable;
            txtDireccion.Enabled = enable;
            txtTelefono.Enabled = enable;
            txtMovil.Enabled = enable;
            txtEmail.Enabled = enable;
            cbxBanco.Enabled = enable;
            chkHistoriaClinica.Enabled = enable;
            cbmPruebaAntiDroga.Enabled = enable;
            chbDiscapacitado.Enabled = enable;
            chbExamenPsicologico.Enabled = enable;
            chkCursoVigilante.Enabled = enable;
            dtpFechaIngreso.Enabled = enable;
            cbmTipoContrato.Enabled = enable;
            chkAfiliado.Enabled = enable;
            NupSueldo.Enabled = enable;
            NupExtra.Enabled = enable;
            chSalida.Enabled = false;
            cbArea.Enabled = enable;
            cbCargo.Enabled = enable;
            cbxProyecto.Enabled = enable;
            bntSitio.Enabled = enable;
            txtObservacion.Enabled = enable;
            txtDocumentacion.Enabled = false;
            btnDocumentacion.Enabled = enable;
            chCasaPropia.Enabled = enable;
            chArrienda.Enabled = enable;
            chDeudorGarante.Enabled = enable;
            nudCantidadHijos.Enabled = enable;
            txtDatosEsposa.Enabled = enable;
            txtDatosFamiliar.Enabled = enable;
            txtDatosEmergencia.Enabled = enable;
            chTrabajoAnterior.Enabled = enable;
            txtRecomendaciones.Enabled = true;
            txtNumCuenta.Enabled = enable;
            if (!secundarios) return;
            cbxTipoCuenta.Enabled = enable;
            txtCarnetConadis.Enabled = enable;
            txtLugarExamenPsicologico.Enabled = enable;
            txtEmisorCursoVigilante.Enabled = enable;
            dtpFechaAfiliado.Enabled = enable;
            dtpFechaSalida.Enabled = false;
            txtMotivoSalidaActual.Enabled = false;
            txtCantidadDeuda.Enabled = enable;
            txtAquienAdeuda.Enabled = enable;
            txtDatosHijos.Enabled = enable;
            txtEmpresaLugar.Enabled = enable;
            txtCargoOcupo.Enabled = enable;
            txtMotivoSalidaAnterior.Enabled = enable;
            dtpFechaEntradaReferencia.Enabled = enable;
            dtpFechaSalidaReferencia.Enabled = enable;
            txtNombresUltimoPatrono.Enabled = enable;
            txtTelefonoUltimoPatrono.Enabled = enable;
        }

        private void HabilitarBotonesMenu(bool botonNuevo, bool botonGuardar, bool botonModificar, bool botonEliminar, bool botonCancelar, bool botonFinalizar, bool botonAspirantes)
        {
            ButtonNuevoRegistro.Enabled = botonNuevo;
            ButtonGuardar.Enabled = botonGuardar;
            ButtonModificarRegistro.Enabled = botonModificar;
            ButtonEliminarRegistro.Enabled = botonEliminar;
            ButtonCancelar.Enabled = botonCancelar;
            ButtonEliminarRegistro.Enabled = botonFinalizar;
            btnAspirantes.Enabled = botonAspirantes;
        }

        private void ButtonNuevoRegistro_Click(object sender, EventArgs e)
        {
            LimpiarParametros();
            HabilitarRegistro(true, false);

            CargarProyectos(false);
            CargarProvincias();
            CargarBancos();
            CargarAreas();
            CargarCargos();

            _estado = 1;
            panelEsatdo.BackColor = Color.DarkGreen;

            HabilitarBotonesMenu(false, false, false, false, true, false, true);
            GenerarSecuencialContrato(dtpFechaIngreso.Value);


            txtCedula.Focus();
        }

        private void GenerarSecuencialContrato(DateTime fec)
        {
            if (_estado == 0) return;

            try
            {
                var sec = _objSecuencialContratos.BuscarMayorSecuencialXAnio(TipoCon, fec.Year);
                var mes = fec.Month < 9 ? string.Concat("0", fec.Month) : string.Concat(string.Empty, fec.Month);
                var dia = fec.Day < 9 ? string.Concat("0", fec.Day) : string.Concat(string.Empty, fec.Day);
                txtContrato.Text = string.Concat(fec.Year, mes, dia, Ceros(sec + 1));
                txtContrato_Leave(null, null);
            }
            catch
            {
                txtContrato.Text = @"00000000000";
            }
        }

        private string Ceros(int c)
        {
            return c > 99 ? string.Concat(c, string.Empty) : string.Concat(c > 99 ? "0" : "00", c);
        }

        private void txtContrato_Leave(object sender, EventArgs e)
        {
            try
            {
                var per = _objContratos.BuscarNroContratoRepetido(TipoCon, Convert.ToInt64(txtContrato.Text));
                if (per.Rows.Count == 0)
                {
                    lblValCon.Image = Resources.oki;
                    lblValCon.Visible = true;
                    lblValCon.Tag = 1;
                }
                else
                {
                    if (per.Rows[0][1].ToString().Equals("0"))
                    {
                        lblValCon.Image = Resources.oki;
                        lblValCon.Visible = true;
                        lblValCon.Tag = 1;
                    }
                    else
                    {
                        lblValCon.Image = Resources.erri;
                        lblValCon.Tag = 0;
                        txtContrato.Tag = @"NÚMERO DE CONTRATO YA SE ENCUENTRA REGISTRADO PARA: " + per.Rows[0][1];
                        MessageBox.Show(txtContrato.Tag.ToString(), "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                lblValCon.Image = Resources.erri;
                lblValCon.Visible = true;
                lblValCon.Tag = 0;
                txtContrato.Tag = @"OCURRIÓ UN PROBLEMA AL VERIFICAR NÚMERO DE CONTRATO";
                MessageBox.Show(txtContrato.Tag.ToString(), "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (txtContrato.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"Ingrese el número del contrato para personal ADMINISTRATIVO / OPERATIVO!",
                    "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_estado != 2 && lblValCon.Tag.ToString().Trim().Equals("0"))
            {
                MessageBox.Show(txtContrato.Tag + @" --- Por favor, verifique el secuencial para continuar!",
                    "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cbArea.Text.StartsWith("___") && cbArea.Text.EndsWith("___"))
            {
                MessageBox.Show(@"Seleccione el área asignada al personal ADMINISTRATIVO / OPERATIVO!",
                     "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtSitio.Tag == null)
            {
                MessageBox.Show(@"Ingrese el sitio / puesto de trabajo para el personal ADMINISTRATIVO / OPERATIVO!",
                     "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(@"Desea guardar el registro actual?",
                   "MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
               DialogResult.Yes) return;

            if (ValidacionParametros())
            {
                txtPasaporte.Text = txtPasaporte.Text.Trim().Length == 0 ? @"NO TIENE" : txtPasaporte.Text.Trim();
                txtLibreta.Text = txtLibreta.Text.Trim().Length == 0 ? @"NO TIENE" : txtLibreta.Text.Trim();

                txtPeso.Text = txtPeso.Text.Trim().Length == 0 ? @"0" : txtPeso.Text.Trim();
                txtPeso.Text = txtPeso.Text.Trim().Length == 0 ? @"0" : txtPeso.Text.Trim();

                txtTelefono.Text = txtTelefono.Text.Trim().Length == 0 ? @"NO TIENE" : txtTelefono.Text.Trim();
                txtMovil.Text = txtMovil.Text.Trim().Length == 0 ? @"NO TIENE" : txtMovil.Text.Trim();
                txtEmail.Text = txtEmail.Text.Trim().Length == 0 ? @"NO TIENE" : txtEmail.Text.Trim();

                txtDatosEsposa.Text = txtDatosEsposa.Text.Trim().Length == 0 ? @"PENDIENTE" : txtDatosEsposa.Text.Trim();
                txtDatosFamiliar.Text = txtDatosFamiliar.Text.Trim().Length == 0 ? @"PENDIENTE" : txtDatosFamiliar.Text.Trim();
                txtDatosEmergencia.Text = txtDatosEmergencia.Text.Trim().Length == 0 ? @"PENDIENTE" : txtDatosEmergencia.Text.Trim();

                if (chTrabajoAnterior.Checked)
                {
                    txtEmpresaLugar.Text = txtEmpresaLugar.Text.Trim().Length == 0 ? @"SIN DATO DE EMPRESA O LUGAR" : txtEmpresaLugar.Text.Trim();
                    txtCargoOcupo.Text = txtCargoOcupo.Text.Trim().Length == 0 ? @"SIN DATO DE CARGO QUE OCUPO" : txtCargoOcupo.Text.Trim();
                    txtMotivoSalidaAnterior.Text = txtMotivoSalidaAnterior.Text.Trim().Length == 0 ? @"SIN DATO DE MOTIVO DE SALIDA" : txtMotivoSalidaAnterior.Text.Trim();
                    txtNombresUltimoPatrono.Text = txtNombresUltimoPatrono.Text.Trim().Length == 0 ? @"SIN NOMBRE DE ULTIMO PATRONO" : txtNombresUltimoPatrono.Text.Trim();
                    txtTelefonoUltimoPatrono.Text = txtTelefonoUltimoPatrono.Text.Trim().Length == 0 ? @"SIN TELEFONO DE ULTIMO PATRONO" : txtTelefonoUltimoPatrono.Text.Trim();
                }

                if ((chbDiscapacitado.Checked && txtCarnetConadis.Text.Trim().Length == 0) ||
                   (chbExamenPsicologico.Checked && txtLugarExamenPsicologico.Text.Trim().Length == 0) ||
                    (chkCursoVigilante.Checked && txtEmisorCursoVigilante.Text.Trim().Length == 0) ||
                    (chDeudorGarante.Checked && (txtCantidadDeuda.Text.Trim().Length == 0 || txtAquienAdeuda.Text.Trim().Length == 0)) ||
                    (nudCantidadHijos.Value > 0 && txtDatosHijos.Text.Trim().Length == 0))
                {
                    MessageBox.Show(@"Por favor, ingrese los datos correspondientes a las casillas que ud. seleccionó!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _sqlCommands.Clear();

                switch (_estado)
                {
                    case 1:
                        GuardarRegistroNuevoPersonal();
                        break;
                    case 2:
                        GuardarRegistroModificadoPersonal();
                        break;
                    case 3:
                        GuardarRegistroModificadoPersonalReingreso();
                        break;
                }

                // CARGAR DOCUMENTOS
                if (docs.Count > 0)
                {
                    var iddoc = _objDocumentosContrato.BuscarMayorIdCodumento(TipoCon) + 1;

                    _objDocumentosContrato.IdContrato = _estado == 2 ? Convert.ToInt32(lblIdPersonal.Tag) : _objContratos.IdContrato;

                    foreach (object[] obj in docs) // new object[] { doc.txt1.Tag, "CV", doc._ci, doc.txt1.Text.Trim() };
                    {
                        if (obj[0].ToString().Equals("0"))
                        {                            
                            _objDocumentosContrato.TipoDocumento = obj[1].ToString();
                            _objDocumentosContrato.FechaCarga = _objContratos.FechaInicialContrato;
                            _objDocumentosContrato.DocumentoByte = (byte[])obj[2];
                            _objDocumentosContrato.IdDocumento = iddoc;
                            _objDocumentosContrato.NombreDocumento = obj[3].ToString();
                            _sqlCommands.Add(_objDocumentosContrato.RegistrarNuevoDocumentoPersonalCommand());
                            iddoc += 1;
                        }
                        else
                        {
                            _objDocumentosContrato.TipoDocumento = obj[1].ToString();
                            _objDocumentosContrato.DocumentoByte = (byte[])obj[2];
                            _objDocumentosContrato.NombreDocumento = obj[3].ToString();
                            _objDocumentosContrato.IdDocumento = Convert.ToInt32(obj[0].ToString());
                            _sqlCommands.Add(_objDocumentosContrato.ModificarDocumentoExistentePersonalCommand());
                        }
                    }
                }

                var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "REGISTRAR PERSONAL");

                if ((bool)res[0])
                {
                    lblIdPersonal.Text = _objPersonal.IdPersonal + "";
                    _estado = 0;
                    docs.Clear();

                    CargarProyectos(true);

                    HabilitarRegistro(false, true);
                    HabilitarBotonesMenu(true, false, true, true, false, true, false);

                    chkAfiliado.Enabled = false;
                    chkXiii.Enabled = false;
                    chkXiv.Enabled = false;
                    chkFondoRes.Enabled = false;
                    chkAcumulaFondo.Enabled = false;

                    CargarPersonal(txtFiltro.Text.Trim());

                    dgvPersonal_SelectionChanged(null, null);
                }
                MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(@"No se puede guardar debido a que no ha llenado todos los campos necesarios!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidacionParametros()
        {
            return (txtCedula.Text.Trim().Length > 0 && txtContrato.Text.Trim().Length > 0 &&
                txtNombres.Text.Trim().Length > 0 && txtApellidos.Text.Trim().Length > 0 &&
                txtEdad.Text.Trim().Length > 0 && txtDireccion.Text.Trim().Length > 0 && NupSueldo.Value > 50);
        }

        private void GuardarRegistroNuevoPersonal()
        {
            _objPersonal.IdPersonal = _objPersonal.BuscarMayorId(TipoCon) + 1;
            _objPersonal.CedulaPersonal = txtCedula.Text.Trim();
            _objPersonal.NombresPersonal = txtNombres.Text.Trim();
            _objPersonal.ApellidosPersonal = txtApellidos.Text.Trim();
            _objPersonal.ProvinciaPersonal = cbmProvincia.Text;
            _objPersonal.DireccionPersonal = txtDireccion.Text.Trim();
            _objPersonal.FechaNacimientoPersonal = dtpFechaNacimiento.Value;
            _objPersonal.SexoPersonal = cbmSexo.Text.Trim();
            _objPersonal.CiudadPersonal = cbmCanton.Text;
            _objPersonal.SueldoPersonal = NupSueldo.Value;
            _objPersonal.LibretaMilitarPersonal = txtLibreta.Text.Trim();
            _objPersonal.TipoSangrePersonal = cbmTipoSangre.Text.Trim();
            _objPersonal.PasaportePersonal = txtPasaporte.Text.Trim();
            _objPersonal.PesoPersonal = Convert.ToDecimal(txtPeso.Text);
            _objPersonal.EdadPersonal = Convert.ToInt32(txtEdad.Text);
            _objPersonal.PruebaAntidrogaPersona = cbmPruebaAntiDroga.Text.Trim();
            _objPersonal.FechaEntradaPersonal = dtpFechaIngreso.Value;
            _objPersonal.UbicacionPersonal = txtSitio.Tag.ToString();
            _objPersonal.InstruccionPersonal = cbmInstruccion.Text.Trim();
            _objPersonal.EstadoCivilPersonal = cbEstadoCivil.Text;
            _objPersonal.MovilPersonal = txtMovil.Text;
            _objPersonal.TelefonoPersonal = txtTelefono.Text;
            _objPersonal.FechaSalidaPersonal = new DateTime(1990, 1, 1, 0, 0, 0);
            _objPersonal.EstadoPersonal = 1;
            _objPersonal.IdCargoPersonal = Convert.ToInt32(cbCargo.SelectedValue);
            _objPersonal.IdAreaPersonal = _objArea.BuscarIdAreaGeneralPorNombreAreaGeneral(TipoCon, cbArea.Text);
            _objPersonal.CantidadHijosPersonal = Convert.ToInt32(nudCantidadHijos.Value);
            _objPersonal.HistoriaClinicaPersonal = chkHistoriaClinica.Checked ? "SI" : "NO";
            _objPersonal.ParroquiaPersonal = cbmParroquia.Text;
            _objPersonal.EstaturaPersonal = Convert.ToDecimal(txtEstatura.Text);
            _objPersonal.DiscapacidadPersonal = chbDiscapacitado.Checked ? "SI" : "NO";
            _objPersonal.ExamenPsicologicoPersonal = (chbExamenPsicologico.Checked ? "SI" : "NO") + ";" + txtDocumentacion.Text.Trim();
            _objPersonal.LugarExamenPsicologicoPersonal = txtLugarExamenPsicologico.Text;
            _objPersonal.CursoVigilante = chkCursoVigilante.Checked ? "SI" : "NO";
            _objPersonal.EmisorCursoVigilante = txtEmisorCursoVigilante.Text;
            _objPersonal.CarnetConadisPersonal = txtCarnetConadis.Text;
            _objPersonal.DatosHijosPersonal = txtDatosHijos.Text;
            _objPersonal.DatosEsposaPersonal = txtDatosEsposa.Text;
            _objPersonal.CasaPersonal = chCasaPropia.Checked ? "SI" : "NO";
            _objPersonal.ArriendoPersonal = chArrienda.Checked ? "SI" : "NO";
            _objPersonal.DeudorPersonal = chDeudorGarante.Checked ? "SI" : "NO";
            _objPersonal.CantidadDeudaPersonal = Convert.ToDecimal(txtCantidadDeuda.Text);
            _objPersonal.AQuienAdeudaPersonal = txtAquienAdeuda.Text;
            _objPersonal.TrabajoAnteriormentePersonal = chTrabajoAnterior.Checked ? "SI" : "NO";
            _objPersonal.AnteriorTrabajoPersonal = txtEmpresaLugar.Text;
            _objPersonal.CargoAnteriorTrabajoPersonal = txtCargoOcupo.Text;
            _objPersonal.MotivoSalidaTrabajoPersonal = txtMotivoSalidaAnterior.Text;
            _objPersonal.EntradaAnteriorPersonal = dtpFechaEntradaReferencia.Value;
            _objPersonal.SalidaAnteriorPersonal = dtpFechaSalidaReferencia.Value;
            _objPersonal.NombresPatronoAnteriorPersonal = txtNombresUltimoPatrono.Text;
            _objPersonal.TelefonoPatronoAnteriorPersonal = txtTelefonoUltimoPatrono.Text;
            _objPersonal.RecomendacionesPersonal = txtRecomendaciones.Text;
            _objPersonal.DatosFamiliaresPersonal = txtDatosFamiliar.Text;
            _objPersonal.DatosEmergenciaPersonal = txtDatosEmergencia.Text;
            _objPersonal.FotoPersonal = ValidationForms.ImageToBytes(pbFoto.Image);
            _objPersonal.PerfilPersonal = ValidationForms.ImageToBytes(pbPerfil.Image);
            _objPersonal.EmailPersonal = txtEmail.Text;
            _objPersonal.Observacion = txtObservacion.Text.Trim();
            _objPersonal.Credencial = chkcredencial.Checked ? 1 : 0;
            _sqlCommands.Add(_objPersonal.RegistrarNuevoPersonalCommand());

            _objContratos.IdContrato = _objContratos.BuscarMayorId(TipoCon) + 1;
            _objContratos.NroContrato = txtContrato.Text.Trim().Equals("NO TIENE") ? 0 : Convert.ToInt64(txtContrato.Text);
            _objContratos.FechaInicialContrato = _objPersonal.FechaEntradaPersonal;
            _objContratos.FechaFinalContrato = _objPersonal.FechaSalidaPersonal;
            _objContratos.PeriodoContrato = dtpFechaIngreso.Value.Year + "";
            _objContratos.TipoContrato = cbmTipoContrato.SelectedIndex;
            _objContratos.EstadoContrato = "VIGENTE";
            _objContratos.IdPersonalContrato = _objPersonal.IdPersonal;
            _objContratos.EstadoRegistroContrato = 1;
            _objContratos.IessContratox = chkAfiliado.Checked ? 1 : 0;
            _objContratos.FechaAfiliacionContrato = dtpFechaAfiliado.Value;
            _objContratos.AplicaFondoReservaContrato = chkFondoRes.Checked ? 1 : 0;
            _objContratos.XiiiEnRolContrato = chkXiii.Checked ? 1 : 0;
            _objContratos.XivEnRolContrato = chkXiv.Checked ? 1 : 0;
            _objContratos.AcumulaFondoReservaContrato = chkAcumulaFondo.Checked ? 1 : 0;
            _objContratos.Observacion = txtObservacion.Text.Trim();
            _objContratos.RecExtra = Convert.ToDouble(NupExtra.Value);
            _objContratos.SeDescuentaSerguro = 1;
            _objContratos.CobraQuince = 1;
            _objContratos.ExtSal = 0;
            _objContratos.IdProyecto = (int)cbxProyecto.SelectedValue;
            _sqlCommands.Add(_objContratos.RegistrarNuevoContratoCommand());

            _objHistorialLaboral.IdHistoriaLaboral = _objHistorialLaboral.BuscarMayorIdHistoriaLaboral(TipoCon) + 1;
            _objHistorialLaboral.FechaHistoriaLaboral = DateTime.Now;
            _objHistorialLaboral.DetalleHistoriaLaboral = "INGRESO A LA COMPAÑIA CON EL CARGO DE " + cbCargo.Text;
            _objHistorialLaboral.EstadoHistoriaLaboral = 1;
            _objHistorialLaboral.IdPersonalHistoriaLaboral = _objPersonal.IdPersonal;
            _objHistorialLaboral.IdSitioHistoriaLaboral = string.Empty;
            _sqlCommands.Add(_objHistorialLaboral.RegistrarNuevoHistorialLaboralCommand());

            var CuentaPersonal = (DataRowView)cbxBanco.SelectedItem;
            _objCuentaPersonal.IdBanco = Convert.ToInt32(CuentaPersonal["id_banco"]); 
            _objCuentaPersonal.IdPersonal = Convert.ToInt32(_objPersonal.IdPersonal);
            _objCuentaPersonal.NumCuenta = txtNumCuenta.Text;
            _objCuentaPersonal.Tipo = "AHO";
            _sqlCommands.Add(_objCuentaPersonal.RegistrarNuevoCuentaBancoPersonalCommand());

            _sqlCommands.Add(_objSecuencialContratos.ActualizarSecuencialContrato(dtpFechaIngreso.Value.Year));
        }

        private void GuardarRegistroModificadoPersonal()
        {
            _objPersonal.IdPersonal = Convert.ToInt32(lblIdPersonal.Text.Trim());
            _objPersonal.CedulaPersonal = txtCedula.Text.Trim();
            _objPersonal.NombresPersonal = txtNombres.Text.Trim();
            _objPersonal.ApellidosPersonal = txtApellidos.Text.Trim();
            _objPersonal.ProvinciaPersonal = cbmProvincia.Text;
            _objPersonal.DireccionPersonal = txtDireccion.Text.Trim();
            _objPersonal.FechaNacimientoPersonal = dtpFechaNacimiento.Value;
            _objPersonal.SexoPersonal = cbmSexo.Text.Trim();
            _objPersonal.CiudadPersonal = cbmCanton.Text;
            _objPersonal.SueldoPersonal = NupSueldo.Value;
            _objPersonal.LibretaMilitarPersonal = txtLibreta.Text.Trim();
            _objPersonal.TipoSangrePersonal = cbmTipoSangre.Text.Trim();
            _objPersonal.PasaportePersonal = txtPasaporte.Text.Trim();
            _objPersonal.PesoPersonal = Convert.ToDecimal(txtPeso.Text);
            _objPersonal.EdadPersonal = Convert.ToInt32(txtEdad.Text);
            _objPersonal.PruebaAntidrogaPersona = cbmPruebaAntiDroga.Text.Trim();
            _objPersonal.FechaEntradaPersonal = dtpFechaIngreso.Value;
            _objPersonal.UbicacionPersonal = txtSitio.Tag.ToString();
            _objPersonal.InstruccionPersonal = cbmInstruccion.Text.Trim();
            _objPersonal.EstadoCivilPersonal = cbEstadoCivil.Text;
            _objPersonal.MovilPersonal = txtMovil.Text;
            _objPersonal.TelefonoPersonal = txtTelefono.Text;
            _objPersonal.FechaSalidaPersonal = dtpFechaSalida.Value;
            _objPersonal.EstadoPersonal = chSalida.Checked ? 0 : 1;
            _objPersonal.IdCargoPersonal = Convert.ToInt32(cbCargo.SelectedValue);
            _objPersonal.IdAreaPersonal = _objArea.BuscarIdAreaGeneralPorNombreAreaGeneral(TipoCon, cbArea.Text);
            _objPersonal.CantidadHijosPersonal = Convert.ToInt32(nudCantidadHijos.Value);
            _objPersonal.HistoriaClinicaPersonal = chkHistoriaClinica.Checked ? "SI" : "NO";
            _objPersonal.ParroquiaPersonal = cbmParroquia.Text;
            _objPersonal.EstaturaPersonal = Convert.ToDecimal(txtEstatura.Text);
            _objPersonal.DiscapacidadPersonal = chbDiscapacitado.Checked ? "SI" : "NO";
            _objPersonal.ExamenPsicologicoPersonal = (chbExamenPsicologico.Checked ? "SI" : "NO") + ";" + txtDocumentacion.Text.Trim();
            _objPersonal.LugarExamenPsicologicoPersonal = txtLugarExamenPsicologico.Text;
            _objPersonal.CursoVigilante = chkCursoVigilante.Checked ? "SI" : "NO";
            _objPersonal.EmisorCursoVigilante = txtEmisorCursoVigilante.Text;
            _objPersonal.CarnetConadisPersonal = txtCarnetConadis.Text;
            _objPersonal.DatosHijosPersonal = txtDatosHijos.Text;
            _objPersonal.DatosEsposaPersonal = txtDatosEsposa.Text;
            _objPersonal.CasaPersonal = chCasaPropia.Checked ? "SI" : "NO";
            _objPersonal.ArriendoPersonal = chArrienda.Checked ? "SI" : "NO";
            _objPersonal.DeudorPersonal = chDeudorGarante.Checked ? "SI" : "NO";
            _objPersonal.CantidadDeudaPersonal = Convert.ToDecimal(txtCantidadDeuda.Text);
            _objPersonal.AQuienAdeudaPersonal = txtAquienAdeuda.Text;
            _objPersonal.TrabajoAnteriormentePersonal = chTrabajoAnterior.Checked ? "SI" : "NO";
            _objPersonal.AnteriorTrabajoPersonal = txtEmpresaLugar.Text;
            _objPersonal.CargoAnteriorTrabajoPersonal = txtCargoOcupo.Text;
            _objPersonal.MotivoSalidaTrabajoPersonal = txtMotivoSalidaAnterior.Text;
            _objPersonal.EntradaAnteriorPersonal = dtpFechaEntradaReferencia.Value;
            _objPersonal.SalidaAnteriorPersonal = dtpFechaSalidaReferencia.Value;
            _objPersonal.NombresPatronoAnteriorPersonal = txtNombresUltimoPatrono.Text;
            _objPersonal.TelefonoPatronoAnteriorPersonal = txtTelefonoUltimoPatrono.Text;
            _objPersonal.RecomendacionesPersonal = txtRecomendaciones.Text;
            _objPersonal.DatosFamiliaresPersonal = txtDatosFamiliar.Text;
            _objPersonal.DatosEmergenciaPersonal = txtDatosEmergencia.Text;
            _objPersonal.FotoPersonal = ValidationForms.ImageToBytes(pbFoto.Image);
            _objPersonal.PerfilPersonal = ValidationForms.ImageToBytes(pbPerfil.Image);
            _objPersonal.EmailPersonal = txtEmail.Text;
            _objPersonal.Observacion = txtObservacion.Text.Trim();
            _objPersonal.Credencial = chkcredencial.Checked ? 1 : 0;
            
            _sqlCommands.Add(_objPersonal.ModificarPersonalCompletoCommand());

            _objContratos.NroContrato = txtContrato.Text.Trim().Equals("NO TIENE") ? 0 : Convert.ToInt64(txtContrato.Text);
            _objContratos.FechaInicialContrato = dtpFechaIngreso.Value;
            _objContratos.FechaAfiliacionContrato = dtpFechaAfiliado.Value;
            _objContratos.FechaFinalContrato = _objPersonal.FechaSalidaPersonal;
            _objContratos.PeriodoContrato = dtpFechaIngreso.Value.Year + "";
            _objContratos.TipoContrato = cbmTipoContrato.SelectedIndex;
            _objContratos.Observacion = txtObservacion.Text.Trim();
            _objContratos.AplicaFondoReservaContrato = chkFondoRes.Checked ? 1 : 0;
            _objContratos.XiiiEnRolContrato = chkXiii.Checked ? 1 : 0;
            _objContratos.XivEnRolContrato = chkXiv.Checked ? 1 : 0;
            _objContratos.AcumulaFondoReservaContrato = chkAcumulaFondo.Checked ? 1 : 0;
            _objContratos.RecExtra = Convert.ToDouble(NupExtra.Value);
            _objContratos.IdPersonalContrato = _objPersonal.IdPersonal;
            _objContratos.SeDescuentaSerguro = 1;
            _objContratos.CobraQuince = 1;
            _objContratos.ExtSal = 0;
            _objContratos.IdProyecto = (int)cbxProyecto.SelectedValue;
            _sqlCommands.Add(_objContratos.ModificarContratoCommand());

            var CuentaPersonal = (DataRowView)cbxBanco.SelectedItem;
            _objCuentaPersonal.IdBanco = Convert.ToInt32(CuentaPersonal["id_banco"]);
            _objCuentaPersonal.IdPersonal = Convert.ToInt32(_objPersonal.IdPersonal);
            _objCuentaPersonal.NumCuenta = txtNumCuenta.Text;
            _objCuentaPersonal.Tipo = "AHO";
            _sqlCommands.Add(_objCuentaPersonal.RegistrarNuevoCuentaBancoPersonalCommand());



        }

        private void  GuardarRegistroModificadoPersonalReingreso()
        {
            _objPersonal.IdPersonal = Convert.ToInt32(lblIdPersonal.Text.Trim());
            _objPersonal.CedulaPersonal = txtCedula.Text.Trim();
            _objPersonal.NombresPersonal = txtNombres.Text.Trim();
            _objPersonal.ApellidosPersonal = txtApellidos.Text.Trim();
            _objPersonal.ProvinciaPersonal = cbmProvincia.Text;
            _objPersonal.DireccionPersonal = txtDireccion.Text.Trim();
            _objPersonal.FechaNacimientoPersonal = dtpFechaNacimiento.Value;
            _objPersonal.SexoPersonal = cbmSexo.Text.Trim();
            _objPersonal.CiudadPersonal = cbmCanton.Text;
            _objPersonal.SueldoPersonal = NupSueldo.Value;
            _objPersonal.LibretaMilitarPersonal = txtLibreta.Text.Trim();
            _objPersonal.TipoSangrePersonal = cbmTipoSangre.Text.Trim();
            _objPersonal.PasaportePersonal = txtPasaporte.Text.Trim();
            _objPersonal.PesoPersonal = Convert.ToDecimal(txtPeso.Text);
            _objPersonal.EdadPersonal = Convert.ToInt32(txtEdad.Text);
            _objPersonal.PruebaAntidrogaPersona = cbmPruebaAntiDroga.Text.Trim();
            _objPersonal.FechaEntradaPersonal = dtpFechaIngreso.Value;
            _objPersonal.UbicacionPersonal = txtSitio.Tag.ToString();
            _objPersonal.InstruccionPersonal = cbmInstruccion.Text.Trim();
            _objPersonal.EstadoCivilPersonal = cbEstadoCivil.Text;
            _objPersonal.MovilPersonal = txtMovil.Text;
            _objPersonal.TelefonoPersonal = txtTelefono.Text;
            _objPersonal.FechaSalidaPersonal = new DateTime(1990, 1, 1, 0, 0, 0);
            _objPersonal.EstadoPersonal = 1;
            _objPersonal.IdCargoPersonal = Convert.ToInt32(cbCargo.SelectedValue);
            _objPersonal.IdAreaPersonal = _objArea.BuscarIdAreaGeneralPorNombreAreaGeneral(TipoCon, cbArea.Text);
            _objPersonal.CantidadHijosPersonal = Convert.ToInt32(nudCantidadHijos.Value);
            _objPersonal.HistoriaClinicaPersonal = chkHistoriaClinica.Checked ? "SI" : "NO";
            _objPersonal.ParroquiaPersonal = cbmParroquia.Text;
            _objPersonal.EstaturaPersonal = Convert.ToDecimal(txtEstatura.Text);
            _objPersonal.DiscapacidadPersonal = chbDiscapacitado.Checked ? "SI" : "NO";
            _objPersonal.ExamenPsicologicoPersonal = (chbExamenPsicologico.Checked ? "SI" : "NO") + ";" + txtDocumentacion.Text.Trim();
            _objPersonal.LugarExamenPsicologicoPersonal = txtLugarExamenPsicologico.Text;
            _objPersonal.CursoVigilante = chkCursoVigilante.Checked ? "SI" : "NO";
            _objPersonal.EmisorCursoVigilante = txtEmisorCursoVigilante.Text;
            _objPersonal.CarnetConadisPersonal = txtCarnetConadis.Text;
            _objPersonal.DatosHijosPersonal = txtDatosHijos.Text;
            _objPersonal.DatosEsposaPersonal = txtDatosEsposa.Text;
            _objPersonal.CasaPersonal = chCasaPropia.Checked ? "SI" : "NO";
            _objPersonal.ArriendoPersonal = chArrienda.Checked ? "SI" : "NO";
            _objPersonal.DeudorPersonal = chDeudorGarante.Checked ? "SI" : "NO";
            _objPersonal.CantidadDeudaPersonal = Convert.ToDecimal(txtCantidadDeuda.Text);
            _objPersonal.AQuienAdeudaPersonal = txtAquienAdeuda.Text;
            _objPersonal.TrabajoAnteriormentePersonal = chTrabajoAnterior.Checked ? "SI" : "NO";
            _objPersonal.AnteriorTrabajoPersonal = txtEmpresaLugar.Text;
            _objPersonal.CargoAnteriorTrabajoPersonal = txtCargoOcupo.Text;
            _objPersonal.MotivoSalidaTrabajoPersonal = txtMotivoSalidaAnterior.Text;
            _objPersonal.EntradaAnteriorPersonal = dtpFechaEntradaReferencia.Value;
            _objPersonal.SalidaAnteriorPersonal = dtpFechaSalidaReferencia.Value;
            _objPersonal.NombresPatronoAnteriorPersonal = txtNombresUltimoPatrono.Text;
            _objPersonal.TelefonoPatronoAnteriorPersonal = txtTelefonoUltimoPatrono.Text;
            _objPersonal.RecomendacionesPersonal = txtRecomendaciones.Text;
            _objPersonal.DatosFamiliaresPersonal = txtDatosFamiliar.Text;
            _objPersonal.DatosEmergenciaPersonal = txtDatosEmergencia.Text;
            _objPersonal.FotoPersonal = ValidationForms.ImageToBytes(pbFoto.Image);
            _objPersonal.PerfilPersonal = ValidationForms.ImageToBytes(pbPerfil.Image);
            _objPersonal.EmailPersonal = txtEmail.Text;
            _objPersonal.Observacion = txtObservacion.Text.Trim();
            _objPersonal.Credencial = chkcredencial.Checked ? 1 : 0;
            _sqlCommands.Add(_objPersonal.ModificarPersonalCompletoCommand());

            _objContratos.IdContrato = _objContratos.BuscarMayorId(TipoCon) + 1;
            _objContratos.NroContrato = txtContrato.Text.Trim().Equals("NO TIENE") ? 0 : Convert.ToInt64(txtContrato.Text);
            _objContratos.FechaInicialContrato = _objPersonal.FechaEntradaPersonal;
            _objContratos.FechaFinalContrato = _objPersonal.FechaSalidaPersonal;
            _objContratos.PeriodoContrato = dtpFechaIngreso.Value.Year + "";
            _objContratos.TipoContrato = cbmTipoContrato.SelectedIndex;
            _objContratos.EstadoContrato = "VIGENTE";
            _objContratos.IdPersonalContrato = _objPersonal.IdPersonal;
            _objContratos.EstadoRegistroContrato = 1;
            _objContratos.IessContratox = chkAfiliado.Checked ? 1 : 0;
            _objContratos.FechaAfiliacionContrato = dtpFechaAfiliado.Value;
            _objContratos.AplicaFondoReservaContrato = chkFondoRes.Checked ? 1 : 0;
            _objContratos.XiiiEnRolContrato = chkXiii.Checked ? 1 : 0;
            _objContratos.XivEnRolContrato = chkXiv.Checked ? 1 : 0;
            _objContratos.AcumulaFondoReservaContrato = chkAcumulaFondo.Checked ? 1 : 0;
            _objContratos.Observacion = txtObservacion.Text.Trim();
            _objContratos.RecExtra = Convert.ToDouble(NupExtra.Value);
            _objContratos.SeDescuentaSerguro = 1;
            _objContratos.CobraQuince = 1;
            _objContratos.ExtSal = 0;
            _objContratos.IdProyecto = (int)cbxProyecto.SelectedValue;
            _sqlCommands.Add(_objContratos.RegistrarNuevoContratoCommand());

            _objHistorialLaboral.IdHistoriaLaboral = _objHistorialLaboral.BuscarMayorIdHistoriaLaboral(TipoCon) + 1;
            _objHistorialLaboral.FechaHistoriaLaboral = DateTime.Now;
            _objHistorialLaboral.DetalleHistoriaLaboral = "INGRESO A LA COMPAÑIA " + Validaciones.NombreCompany(TipoCon) + " CON EL CARGO DE " + cbCargo.Text;
            _objHistorialLaboral.EstadoHistoriaLaboral = 1;
            _objHistorialLaboral.IdPersonalHistoriaLaboral = _objPersonal.IdPersonal;
            _objHistorialLaboral.IdSitioHistoriaLaboral = string.Empty;
            _sqlCommands.Add(_objHistorialLaboral.RegistrarNuevoHistorialLaboralCommand());

            //_objCuentaPersonal.IdBanco = 0;
            //_objCuentaPersonal.IdPersonal = Convert.ToInt32(_objPersonal.IdPersonal);
            //_objCuentaPersonal.NumCuenta = "";
            //_objCuentaPersonal.Tipo = "AHO";


            var CuentaPersonal = (DataRowView)cbxBanco.SelectedItem;
            _objCuentaPersonal.IdBanco = Convert.ToInt32(CuentaPersonal["id_banco"]);
            _objCuentaPersonal.IdPersonal = Convert.ToInt32(_objPersonal.IdPersonal);
            _objCuentaPersonal.NumCuenta = txtNumCuenta.Text;
            _objCuentaPersonal.Tipo = "AHO";
            _sqlCommands.Add(_objCuentaPersonal.RegistrarNuevoCuentaBancoPersonalCommand());

            _sqlCommands.Add(_objSecuencialContratos.ActualizarSecuencialContrato(dtpFechaIngreso.Value.Year));
        }

        private void ButtonModificarRegistro_Click(object sender, EventArgs e)
        {
            if (lblIdPersonal.Text.Trim().Length < 1)
            {
                MessageBox.Show(@"Debe seleccionar un registro para modificar datos!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            docs.Clear();
            HabilitarRegistro(true, false);
            _estado = 2;

            CargarProyectos(false);

            txtContrato.Enabled = false;
            cbmTipoContrato.Enabled = true;

            dtpFechaIngreso.Enabled = true;
            chkAfiliado.Enabled = true;
            dtpFechaAfiliado.Enabled = true;

            chkXiii.Enabled = true;
            chkXiv.Enabled = true;
            chkFondoRes.Enabled = true;
            chkAcumulaFondo.Enabled = true;
            dtpFechaSalida.Enabled = chSalida.Checked;
            txtMotivoSalidaActual.Enabled = chSalida.Checked;

            lblValCon.Visible = false;
            HabilitarBotonesMenu(false, true, false, false, true, false, false);
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = txtApellidos.Text.Trim();

            LimpiarParametros();
            CargarProyectos(true);
            HabilitarRegistro(false, true);
            HabilitarBotonesMenu(true, false, false, false, false, false, false);

            lblValCon.Visible = false;
            _estado = 0;

            chkXiii.Enabled = false;
            chkXiv.Enabled = false;
            chkFondoRes.Enabled = false;
            chkAcumulaFondo.Enabled = false;
        }

        private void txtCedula_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCedula.Text.Trim().Length == 10) ValidarCedula();
        }

        private void ValidarCedula()
        {
            var r = _objPersonal.BuscarCedulaExistente(TipoCon, txtCedula.Text.Trim());
            if (r > 0)
            {
                lblValCed.Image = Resources.erri;
                ButtonGuardar.Enabled = false;
                MessageBox.Show(@"El número de cédula ingresado ya se encuentra registrado como personal con estado ACTIVO!",
                   @"MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var dl = _objPersonal.BuscarLegalExistente(TipoCon, txtCedula.Text.Trim());
                if (dl.Rows.Count > 0)
                {
                    _frmNotificacion = new FrmNotificarNovedades(TipoConexion.Cisepro, Usuario,
                        "ALERTA!!! Existen novedades relacionados con la C.I. que ingresó. Por favor, comuniquese con administración para acordar detalles del contrato!", 0) { DataNotificacion = dl };
                    _frmNotificacion.ShowDialog();
                }

                var data = _objPersonal.SeleccionarTodosRegistrosPersonalFiltroFull(TipoCon, txtCedula.Text.Trim());
                if (data.Rows.Count > 0)
                {
                    lblIdPersonal.Text = data.Rows[0]["ID_PERSONAL"].ToString();
                    txtCedula.Text = data.Rows[0]["CEDULA"].ToString();
                    txtNombres.Text = data.Rows[0]["NOMBRES"].ToString();
                    txtApellidos.Text = data.Rows[0]["APELLIDOS"].ToString();
                    cbmSexo.Text = data.Rows[0]["SEXO"].ToString();
                    dtpFechaNacimiento.Text = data.Rows[0]["FECHA_NACIMIENTO"].ToString();
                    cbEstadoCivil.Text = data.Rows[0]["ESTADO_CIVIL"].ToString();
                    txtPasaporte.Text = data.Rows[0]["PASAPORTE"].ToString();
                    txtEdad.Text = data.Rows[0]["EDAD"].ToString();
                    txtLibreta.Text = data.Rows[0]["LIBRETA_MILITAR"].ToString();
                    cbmProvincia.Text = data.Rows[0]["PROVINCIA"].ToString();
                    cbmCanton.Text = data.Rows[0]["CIUDAD"].ToString();
                    cbmParroquia.Text = data.Rows[0]["PARROQUIA"].ToString();
                    txtDireccion.Text = data.Rows[0]["DIRECCION"].ToString();
                    cbmTipoSangre.Text = data.Rows[0]["TIPO_SANGRE"].ToString();
                    txtPeso.Text = data.Rows[0]["PESO"].ToString();
                    txtEstatura.Text = data.Rows[0]["ESTATURA"].ToString();
                    //chkcredencial.Checked = data.Rows[0]["CREDENCIAL"].ToString().Equals("SI");
                    chkHistoriaClinica.Checked = data.Rows[0]["HISTORIA_CLINICA"].ToString().Equals("SI");
                    cbmPruebaAntiDroga.Text = data.Rows[0]["PRUEBA_ANTIDROGA"].ToString();
                    chbDiscapacitado.Checked = data.Rows[0]["DISCAPACIDAD"].ToString().Equals("SI");
                    txtCarnetConadis.Text = data.Rows[0]["CARNET_CONADIS"].ToString();
                    chbExamenPsicologico.Checked = data.Rows[0]["EXAMEN_PSICOLOGICO"].ToString().Equals("SI");
                    txtLugarExamenPsicologico.Text = data.Rows[0]["LUGAR_EXAMEN_PSICOLOGICO"].ToString();
                    chkCursoVigilante.Checked = data.Rows[0]["CURSO_VIGILANTE"].ToString().Equals("SI");
                    txtEmisorCursoVigilante.Text = chkCursoVigilante.Checked ? data.Rows[0]["EMISOR_CURSO_VIGILANTE"].ToString() : "NO TIENE";
                    dtpFechaIngreso.Text = data.Rows[0]["FECHA_ENTRADA"].ToString();
                    chSalida.Checked = data.Rows[0]["ESTADO_PERSONAL"].ToString().Equals("0");
                    dtpFechaSalida.Text = data.Rows[0]["FECHA_SALIDA"].ToString();
                    txtMotivoSalidaActual.Text = chSalida.Checked ? data.Rows[0]["MOTIVO_SALIDA_TRABAJO"].ToString() : "EN FUNCIONES";
                    cbCargo.SelectedValue = data.Rows[0]["ID_CARGO_OCUPACIONAL"].ToString();
                    cbArea.SelectedValue = _objArea.BuscarNombreAreaGeneralPorIdAreaGeneral(TipoCon, data.Rows[0]["ID_AREA"].ToString());
                    cbmInstruccion.Text = data.Rows[0]["INSTRUCCION"].ToString();
                    NupSueldo.Value = Convert.ToDecimal(data.Rows[0]["SUELDO"]);
                    chCasaPropia.Checked = data.Rows[0]["CASA"].ToString().Equals("SI");
                    chArrienda.Checked = data.Rows[0]["ARRIENDO"].ToString().Equals("SI");
                    chDeudorGarante.Checked = data.Rows[0]["DEUDOR_GARANTE"].ToString().Equals("SI");

                    txtCantidadDeuda.Text = data.Rows[0]["CANTIDAD_DEUDA"].ToString();
                    txtAquienAdeuda.Text = data.Rows[0]["A_QUIEN_ADEUDA"].ToString();
                    nudCantidadHijos.Value = Convert.ToInt32(data.Rows[0]["CANTIDAD_HIJOS"]);
                    txtDatosHijos.Text = data.Rows[0]["DATOS_HIJOS"].ToString();
                    txtDatosEsposa.Text = data.Rows[0]["DATOS_ESPOSA"].ToString();
                    txtDatosFamiliar.Text = data.Rows[0]["DATOS_FAMILIARES"].ToString();
                    txtDatosEmergencia.Text = data.Rows[0]["DATOS_EMERGENCIA"].ToString();
                    chTrabajoAnterior.Checked = data.Rows[0]["TRABAJO_ATERIORMENTE"].ToString().Equals("SI");
                    txtEmpresaLugar.Text = data.Rows[0]["ANTERIOR_TRABAJO"].ToString();
                    txtCargoOcupo.Text = data.Rows[0]["CARGO_ANTERIOR_TRABAJO"].ToString();
                    txtMotivoSalidaAnterior.Text = data.Rows[0]["MOTIVO_SALIDA_TRABAJO"].ToString();
                    dtpFechaEntradaReferencia.Text = data.Rows[0]["ENTRADA_ANTERIOR"].ToString();
                    dtpFechaSalidaReferencia.Text = data.Rows[0]["SALIDA_ANTERIOR"].ToString();
                    txtNombresUltimoPatrono.Text = data.Rows[0]["NOMBRES_PATRONO_ANTERIOR"].ToString();
                    txtTelefonoUltimoPatrono.Text = data.Rows[0]["TELEFONO_PATRONO_ANTERIOR"].ToString();
                    txtRecomendaciones.Text = data.Rows[0]["RECOMENDACIONES"].ToString();
                    txtMovil.Text = data.Rows[0]["MOVIL"].ToString();
                    txtTelefono.Text = data.Rows[0]["TELEFONO"].ToString();
                    txtEmail.Text = data.Rows[0]["EMAIL"].ToString();

                    try
                    {
                        var cuenta = _objCuentaPersonal.SeleccionarCuenta(TipoCon, lblIdPersonal.Text.Trim());
                        cbxBanco.SelectedValue = cuenta.Rows[0][1];
                        txtNumCuenta.Text = cuenta.Rows[0][2].ToString().Trim();
                        cbxTipoCuenta.Text = cuenta.Rows[0][3].ToString().Trim();
                    }
                    catch
                    {
                        txtNumCuenta.Clear();
                        cbxBanco.SelectedIndex = 0;
                        cbxTipoCuenta.SelectedIndex = 0;
                    }

                    try
                    {
                        pbFoto.Image = ValidationForms.BytesToImage((byte[])data.Rows[0]["FOTO"]);
                        PictureBox1.Image = ValidationForms.BytesToImage((byte[])data.Rows[0]["FOTO"]);
                    }
                    catch
                    {
                        PictureBox1.Image = Resources._default;
                        pbFoto.Image = Resources._default;
                    }

                    try
                    {
                        pbPerfil.Image = ValidationForms.BytesToImage((byte[])data.Rows[0]["PERFIL"]);
                    }
                    catch
                    {
                        pbPerfil.Image = Resources._default;
                    }
                    txtObservacion.Text = @"REINGRESO DE PERSONAL";
                    _estado = 3;
                }
                else
                {
                    var aspirante = _objAspirante.SeleccionarDatosAspiranteByCi(TipoCon, txtCedula.Text.Trim());
                    if (aspirante.Rows.Count > 0)
                    {
                        txtCedula.Text = aspirante.Rows[0]["CEDULA"].ToString();
                        txtNombres.Text = aspirante.Rows[0]["NOMBRES"].ToString();
                        txtApellidos.Text = aspirante.Rows[0]["APELLIDOS"].ToString();
                        cbmSexo.Text = aspirante.Rows[0]["SEXO"].ToString().Equals("M") ? "MASCULINO" : "FEMENINO";
                        dtpFechaNacimiento.Text = aspirante.Rows[0]["FECHA_NACIMIENTO"].ToString();
                        txtEdad.Text = aspirante.Rows[0]["ANIOS"].ToString();
                        cbEstadoCivil.Text = aspirante.Rows[0]["ESTADO_CIVIL"].ToString();
                        cbmInstruccion.Text = aspirante.Rows[0]["INSTRUCCION"].ToString();
                        txtMovil.Text = aspirante.Rows[0]["MOVIL"].ToString();
                        txtTelefono.Text = aspirante.Rows[0]["TELEFONO"].ToString();
                        txtEmail.Text = aspirante.Rows[0]["EMAIL"].ToString();
                        cbmProvincia.Text = aspirante.Rows[0]["PROVINCIA"].ToString();
                        cbmCanton.Text = aspirante.Rows[0]["CIUDAD"].ToString();
                        cbmParroquia.Text = aspirante.Rows[0]["PARROQUIA"].ToString();
                        txtDireccion.Text = aspirante.Rows[0]["DIRECCION"].ToString();
                    } 
                }

                lblValCed.Image = Resources.oki;
                ButtonGuardar.Enabled = true; 
            }
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            var f = (Usuario.Now(TipoCon).Subtract(dtpFechaNacimiento.Value).Days / 365.0);
            txtEdad.Text = Math.Floor(f) + "";
        }

        private void chbDiscapacitado_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtCarnetConadis.Enabled = chbDiscapacitado.Checked;
            txtCarnetConadis.Text = chbDiscapacitado.Checked ? string.Empty : "NO TIENE";
        }

        private void chbExamenPsicologico_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtLugarExamenPsicologico.Enabled = chbExamenPsicologico.Checked;
            txtLugarExamenPsicologico.Text = chbExamenPsicologico.Checked ? string.Empty : "NO TIENE";
        }

        private void chkCursoVigilante_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtEmisorCursoVigilante.Enabled = chkCursoVigilante.Checked;
            txtEmisorCursoVigilante.Text = chkCursoVigilante.Checked ? string.Empty : "NO TIENE";
        }

        private void chkAfiliado_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            chkXiii.Enabled = chkAfiliado.Checked;
            chkXiv.Enabled = chkAfiliado.Checked;
            chkFondoRes.Enabled = chkAfiliado.Checked;
            chkAcumulaFondo.Enabled = chkAfiliado.Checked;
            dtpFechaAfiliado.Enabled = chkAfiliado.Checked;

            if (!chkAfiliado.Checked)
            {
                chkXiii.Checked = false;
                chkXiv.Checked = false;
                chkFondoRes.Checked = false;
                chkAcumulaFondo.Checked = false;
            }
            dtpFechaAfiliado.Value = chkAfiliado.Checked ? dtpFechaIngreso.Value : DateTime.Now;
        }

        private void chDeudorGarante_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtCantidadDeuda.Enabled = chDeudorGarante.Checked;
            txtAquienAdeuda.Enabled = chDeudorGarante.Checked;
            txtCantidadDeuda.Text = @"0.00";
            txtAquienAdeuda.Text = @"SIN DATO DE QUIEN ADEUDA";
        }

        private void nudCantidadHijos_ValueChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtDatosHijos.Enabled = nudCantidadHijos.Value > 0;
            txtDatosHijos.Text = nudCantidadHijos.Value > 0 ? string.Empty : "PENDIENTE";
        }

        private void chTrabajoAnterior_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtEmpresaLugar.Enabled = chTrabajoAnterior.Checked;
            txtCargoOcupo.Enabled = chTrabajoAnterior.Checked;
            txtMotivoSalidaAnterior.Enabled = chTrabajoAnterior.Checked;
            dtpFechaEntradaReferencia.Enabled = chTrabajoAnterior.Checked;
            dtpFechaSalidaReferencia.Enabled = chTrabajoAnterior.Checked;
            txtNombresUltimoPatrono.Enabled = chTrabajoAnterior.Checked;
            txtTelefonoUltimoPatrono.Enabled = chTrabajoAnterior.Checked;
            txtEmpresaLugar.Text = chTrabajoAnterior.Checked ? string.Empty : "SIN DATO DE EMPRESA O LUGAR";
            txtCargoOcupo.Text = chTrabajoAnterior.Checked ? string.Empty : "SIN DATO DE CARGO QUE OCUPO";
            txtMotivoSalidaAnterior.Text = chTrabajoAnterior.Checked ? string.Empty : "SIN DATO DE MOTIVO DE SALIDA";
            txtNombresUltimoPatrono.Text = chTrabajoAnterior.Checked ? string.Empty : "SIN NOMBRE DE ULTIMO PATRONO";
            txtTelefonoUltimoPatrono.Text = chTrabajoAnterior.Checked ? string.Empty : "SIN TELEFONO DE ULTIMO PATRONO";
        }

        private void bntSitio_Click(object sender, EventArgs e)
        {
            _frmBuscarPuestoTrabajo = new FrmBuscarPuestoTrabajo { Label3 = { Text = @"TODOS LOS PUESTOS REGISTRADOS" }, TipoCon = TipoCon };
            try
            {
                if (_frmBuscarPuestoTrabajo.ShowDialog() != DialogResult.OK) return;
                txtSitio.Tag = _frmBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[0].Text.Trim();
                txtSitio.Text = _frmBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[2].Text + @" (" +
                    _frmBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[18].Text.Trim() + @")";
            }
            catch
            {
                txtSitio.Text = @"AUN NO SE ESPECIFICA";
                txtSitio.Tag = 0;
            }
        }

        private void btnDocumentacion_Click(object sender, EventArgs e)
        {
            if (_estado == 0 && (dgvPersonal.RowCount == 0 || dgvPersonal.CurrentRow == null))
            {
                MessageBox.Show(@"Debe seleccionar un registro para modificar datos!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var doc = new FrmDocumentos { TipoCon = TipoCon, IdPersonal = _estado == 1 ? 0 : Convert.ToInt32(lblIdPersonal.Text.Trim()), IdContrato = _estado == 1 ? 0 : Convert.ToInt32(lblIdPersonal.Tag.ToString().Trim()) };
            if (doc.ShowDialog() != DialogResult.OK) return;

            docs.Clear();
            var data = string.Empty;
            if (doc._cv != null) docs.Add(new object[] { doc.txt1.Tag, "CV", doc._cv, doc.txt1.Text.Trim() });
            if (doc._ci != null) docs.Add(new object[] { doc.txt2.Tag, "CI", doc._ci, doc.txt2.Text.Trim() });
            if (doc._cr != null) docs.Add(new object[] { doc.txt3.Tag, "CR", doc._cr, doc.txt3.Text.Trim() });
            if (doc._se != null) docs.Add(new object[] { doc.txt4.Tag, "SE", doc._se, doc.txt4.Text.Trim() });
            if (doc._ts != null) docs.Add(new object[] { doc.txt5.Tag, "TS", doc._ts, doc.txt5.Text.Trim() });
            if (doc._vs != null) docs.Add(new object[] { doc.txt6.Tag, "VS", doc._vs, doc.txt6.Text.Trim() });
            if (doc._es != null) docs.Add(new object[] { doc.txt7.Tag, "ES", doc._es, doc.txt7.Text.Trim() });
            if (doc._am != null) docs.Add(new object[] { doc.txt8.Tag, "AM", doc._am, doc.txt8.Text.Trim() });
            if (doc._pn != null) docs.Add(new object[] { doc.txt9.Tag, "PN", doc._pn, doc.txt9.Text.Trim() });
            if (doc._af != null) docs.Add(new object[] { doc.txt10.Tag, "AF", doc._af, doc.txt10.Text.Trim() });
            if (doc._em != null) docs.Add(new object[] { doc.txt11.Tag, "EM", doc._em, doc.txt11.Text.Trim() });
            if (doc._al != null) docs.Add(new object[] { doc.txt12.Tag, "AL", doc._al, doc.txt12.Text.Trim() });


            if (doc.CheckBox1.Checked) data += "CV;";
            if (doc.CheckBox2.Checked) data += "CI;";
            if (doc.CheckBox3.Checked) data += "CR;";
            if (doc.CheckBox4.Checked) data += "SE;";
            if (doc.CheckBox5.Checked) data += "TS;";
            if (doc.CheckBox6.Checked) data += "VS;";
            if (doc.CheckBox7.Checked) data += "ES;";
            if (doc.CheckBox8.Checked) data += "AM;";
            if (doc.CheckBox9.Checked) data += "PN;";
            if (doc.CheckBox10.Checked) data += "AF;";
            if (doc.CheckBox11.Checked) data += "EM;";
            if (doc.CheckBox12.Checked) data += "AL;";

            if (data.EndsWith(";")) data = data.Substring(0, data.Length - 1);
            txtDocumentacion.Text = data.Trim().Length == 0 ? "NO TIENE" : data.Trim();
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            tcPersonal.SelectedIndex = 3;
        }

        private FrmTomarFoto _frmFotoCis;
        private void pbFoto_Click(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            _frmFotoCis = new FrmTomarFoto();
            if (_frmFotoCis.ShowDialog() != DialogResult.OK) return;

            pbFoto.Image = _frmFotoCis.pbFotoCortadaFrontal.Image;
            pbPerfil.Image = _frmFotoCis.pbFotoCortadaPerfil.Image;
            PictureBox1.Image = _frmFotoCis.pbFotoCortadaFrontal.Image;
        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            GenerarSecuencialContrato(dtpFechaIngreso.Value);
        }

        private void ButtonEliminarRegistro_Click(object sender, EventArgs e)
        {
            if (lblIdPersonal.Text.Trim().Length < 1)
            {
                MessageBox.Show(@"Debe seleccionar un registro para modificar datos!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(@"DESEA DAR DE BAJA EL REGISTRO DE PERSONAL ADMINISTRATIVO / OPERATIVO? NOTA: Este proceso debe realizarlo cuando ya se haya cancelado la liquidación del mismo, de lo contrario seguirá generándose el rol de pagos correspondiente!",
                   "MENSAJE DELL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            _objMotivoFechaSalida = new FrmSeleccionarMotivoFechaSalida { TipoCon = TipoCon, TextBox1 = { Text = txtObservacion.Text } };

            if (_objMotivoFechaSalida.ShowDialog() != DialogResult.OK) return;

            var response = _objMotivoFechaSalida.TextBox1.Text.Trim();
            var fechaSal = _objMotivoFechaSalida.checkBox1.Checked ? new DateTime(1990, 01, 01) : _objMotivoFechaSalida.DateTimePicker1.Value;

            _sqlCommands.Clear();

            txtObservacion.Text = response;
            var f = Usuario.Now(TipoCon);

            GuardarRegistroFinalizarContratoPersonal(
                new DateTime(fechaSal.Year, fechaSal.Month, fechaSal.Day, f.Hour, f.Minute, f.Second),
                _objMotivoFechaSalida.checkBox1.Checked);

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "REGISTRAR PERSONAL");

            if ((bool)res[0])
            {
                CargarProyectos(true);
                CargarPersonal(txtCedula.Text.Trim());
                dgvPersonal_SelectionChanged(null, null);
            }
            MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GuardarRegistroFinalizarContratoPersonal(DateTime salida, bool noSePresento)
        {
            _objPersonal.IdPersonal = Convert.ToInt32(lblIdPersonal.Text.Trim());
            if (noSePresento) _objPersonal.FechaEntradaPersonal = salida;
            _objPersonal.FechaSalidaPersonal = salida;
            _sqlCommands.Add(_objPersonal.RegistrarFinContratoCommand(salida, noSePresento));

            _objContratos.Observacion = txtObservacion.Text.Trim();
            _objContratos.NroContrato = txtContrato.Text.Trim().Equals("NO TIENE") ? 0 : txtContrato.Text.Trim().Length == 0 ? 0 : Convert.ToInt64(txtContrato.Text);
            _objContratos.IdPersonalContrato = _objPersonal.IdPersonal;
            _sqlCommands.Add(_objContratos.RegistrarFinalizacionContratoCommand(salida, noSePresento));

            _objHistorialLaboral.IdHistoriaLaboral = _objHistorialLaboral.BuscarMayorIdHistoriaLaboral(TipoCon) + 1;
            _objHistorialLaboral.FechaHistoriaLaboral = salida;
            if (noSePresento) _objHistorialLaboral.DetalleHistoriaLaboral = "NO SE PRESENTÓ AL PUESTO PUESTO, N° " + _objContratos.NroContrato + ", CON EL CARGO DE " + cbCargo.Text + " OBSERVACIÓN: " + txtObservacion.Text.Trim();
            else _objHistorialLaboral.DetalleHistoriaLaboral = "SALIDA DE LA COMPAÑIA " + Validaciones.NombreCompany(TipoCon) + ", N° " + _objContratos.NroContrato + ", CON EL CARGO DE " + cbCargo.Text + " OBSERVACIÓN: " + txtObservacion.Text.Trim();
            _objHistorialLaboral.EstadoHistoriaLaboral = 1;
            _objHistorialLaboral.IdPersonalHistoriaLaboral = _objPersonal.IdPersonal;
            _objHistorialLaboral.IdSitioHistoriaLaboral = string.Empty;
            _sqlCommands.Add(_objHistorialLaboral.RegistrarNuevoHistorialLaboralCommand());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ExportarDatosExcel(dgvPersonal, "PERSONAL");
        }

        private void ExportarDatosExcel(DataGridView dataGridViewExp, string titulo)
        {
            if (dataGridViewExp.RowCount == 0)
            {
                MessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            { 
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];

                worksheet.Name = titulo;

                var l = -1;
                for (var i = 0; i <= dataGridViewExp.Columns.Count - 1; i++) if (dataGridViewExp.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l); // PARA FIRMA Y HUELLA

                var rc = dataGridViewExp.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - " + titulo;
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = titulo + "               Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;

                var x = 1;
                for (var i = 0; i <= dataGridViewExp.Columns.Count - 1; i++)
                {
                    if (!dataGridViewExp.Columns[i].Visible) continue;

                    worksheet.Cells[head, x] = dataGridViewExp.Columns[i].HeaderText;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (DataGridViewRow row in dataGridViewExp.Rows)
                {
                    var y = 1;
                    for (var j = 0; j <= dataGridViewExp.Columns.Count - 1; j++)
                    {
                        if (!dataGridViewExp.Columns[j].Visible) continue;
                        worksheet.Cells[head, y] = row.Cells[j].Value;
                        if ((row.Tag + "").Equals("2") || (row.Tag + "").Equals("3")) worksheet.Cells[head, y].Font.Bold = true;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                        y++;
                    }
                    head++;
                }

                var position = (Range)worksheet.Cells[2, 7];
                Clipboard.SetImage(ValidationForms.Logo(TipoCon));
                worksheet.Paste(position);

                worksheet.Range["A1:" + ic + rc].Columns.AutoFit();
                app.DisplayAlerts = false;
                app.Visible = true;
                MessageBox.Show(@"PERSONAL generado correctamente!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportarDatosExcel(DataGridView1, "HISTORIALES");
        }

        private void chSalida_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaSalida.Value = chSalida.Checked ? DateTime.Now : new DateTime(1990, 1, 1, 0, 0, 0);
            txtMotivoSalidaActual.Text = chSalida.Checked ? string.Empty : "EN FUNCIONES";
            txtMotivoSalidaActual.Enabled = chSalida.Checked && _estado != 0;
        }

        private void cbxProyecto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxProyecto.DataSource == null) return;
            if (cbxProyecto.SelectedValue is DataRowView) return;
            if (cbxProyecto.SelectedValue == null) return;
            var data = _objContratos.SeleccionarTodosLosRegistrosProyectosById(TipoCon,(int)cbxProyecto.SelectedValue);
            if (data.Rows.Count == 0)
            {
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                label32.Visible = false;
                label19.Text = "PROYECTO NO DEFINIDO (NO TIENE FECHA DE INICIO - FIN)";
                label19.ForeColor = SystemColors.ButtonShadow;
                return;
            }
            if (data.Rows[0][0].ToString().Equals("1"))
            {
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                label32.Visible = false;
                label19.Text = "PROYECTO NO DEFINIDO (NO TIENE FECHA DE INICIO - FIN)";
                label19.ForeColor = SystemColors.ButtonShadow;
                return;
            }
            label19.ForeColor = SystemColors.ControlText;
            label19.Text = "INICIO PR:";
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            label32.Visible = true;
            dateTimePicker1.Value = (DateTime)data.Rows[0][2];
            dateTimePicker2.Value = (DateTime)data.Rows[0][3];
        }

        private void btnAspirantes_Click(object sender, EventArgs e)
        {
            _frmBuscarAspirante = new FrmBuscarAspirante { Label3 = { Text = @"TODOS LOS ASPIRANTES" }, TipoCon = TipoCon };
            
            if (_frmBuscarAspirante.ShowDialog() != DialogResult.OK) return;
            var aspirante = _objAspirante.SeleccionarDatosAspiranteById(TipoCon, _frmBuscarAspirante.dgvAspirante.CurrentRow.Cells[0].Value.ToString()).Rows[0];
            if (_frmBuscarAspirante.dgvAspirante.CurrentRow.Cells[7].Value.ToString().Trim().Equals("ASPIRANTE"))
            {
                txtCedula.Text = aspirante["CEDULA"].ToString();
                txtNombres.Text = aspirante["NOMBRES"].ToString();
                txtApellidos.Text = aspirante["APELLIDOS"].ToString();
                cbmSexo.Text = aspirante["SEXO"].ToString().Equals("M") ? "MASCULINO" : "FEMENINO";
                dtpFechaNacimiento.Text = aspirante["FECHA_NACIMIENTO"].ToString();
                txtEdad.Text = aspirante["ANIOS"].ToString();
                cbEstadoCivil.Text = aspirante["ESTADO_CIVIL"].ToString();
                cbmInstruccion.Text = aspirante["INSTRUCCION"].ToString();
                txtMovil.Text = aspirante["MOVIL"].ToString();
                txtTelefono.Text = aspirante["TELEFONO"].ToString();
                txtEmail.Text = aspirante["EMAIL"].ToString();
                cbmProvincia.Text = aspirante["PROVINCIA"].ToString();
                cbmCanton.Text = aspirante["CIUDAD"].ToString();
                cbmParroquia.Text = aspirante["PARROQUIA"].ToString();
                txtDireccion.Text = aspirante["DIRECCION"].ToString();
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaSalida_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvPersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}