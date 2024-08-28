using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using ClassLibraryCisepro3.DivisionGeografica;
using System.Data.SqlClient;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.TalentoHumano;
using System.IO;
using DataTable = System.Data.DataTable;
using Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Interop;
using ClassLibraryCisepro3.Estaticas;
using Krypton.Toolkit;


namespace SysCisepro3.TalentoHumano
{
    public partial class FrmAspirantes : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para registrar datos del personal, ingresos y salidas de la cia
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private readonly ClassPersonal _objPersonal;
        private readonly ClassAspirante _objAspirante;
        private readonly ClassProvincias _objProvincias;
        private readonly ClassCiudades _objCiudades;
        private readonly ClassParroquias _objParroquias;

        public byte[] documento;

        private FrmNotificarNovedades _frmNotificacion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private static FrmAspirantes _instance;
        public static FrmAspirantes Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmAspirantes();
                return _instance;
            }
        }

        private readonly List<SqlCommand> _sqlCommands;

        private int _estado;

        private FrmAspirantes()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();
            _objProvincias = new ClassProvincias();
            _objCiudades = new ClassCiudades();
            _objParroquias = new ClassParroquias();
            _objAspirante = new ClassAspirante();
            _objPersonal = new ClassPersonal();
            _estado = 0;
            documento = null;

            openFileDialog1 = new System.Windows.Forms.OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "SELECCIONAR DOCUMENTO PDF",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "pdf",
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
        }

        private void FrmAspirantes_Load(object sender, EventArgs e)
        {
            //toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;

            label9.BackColor = ValidationForms.GetColorSistema(TipoCon);
            label9.ForeColor = Color.White; 
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
            cbxFiltro.SelectedIndex = 0;
            dgvPersonal.Font = new System.Drawing.Font("Roboto", 8, FontStyle.Regular);

            CargarProvincias();
            txtFiltro.Focus();
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

        private void CargarPersonal()
        {
            try
            {
                dgvPersonal.DataSource = _objAspirante.SeleccionarTodosRegistrosAspiranteFiltro(TipoCon, cbxFiltro.SelectedIndex, txtFiltro.Text.Trim());
                if (dgvPersonal.RowCount == 0) return;

                dgvPersonal.Columns[0].Width = 40;
                dgvPersonal.Columns[1].Width = 80;
                dgvPersonal.Columns[2].Width = 250; 
                dgvPersonal.Columns[3].Width = 100;
                dgvPersonal.Columns[4].Width = 300; 
                dgvPersonal.Columns[5].Width = 300;
                dgvPersonal.Columns[6].Width = 80;
                dgvPersonal.Columns[7].Width = 80;
                dgvPersonal.Columns[8].Width = 300;
                dgvPersonal.Columns[9].Width = 120;
                dgvPersonal.Columns[9].DefaultCellStyle.Format = "g";
                dgvPersonal.AutoResizeRows();

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
                lblValCed.Visible = false;

                lblAspirante.Text = row.Cells["ID"].Value.ToString();
                var asp = _objAspirante.SeleccionarDatosAspiranteById(TipoCon, lblAspirante.Text.Trim()).Rows[0];

                txtCedula.Text = asp["CEDULA"].ToString();
                cbmSexo.Text = asp["SEXO"].ToString();
                dtpFechaNacimiento.Value = Convert.ToDateTime(asp["FECHA_NACIMIENTO"]);
                dtpHoy.Value = Convert.ToDateTime(asp["FECHA_REGISTRO"]);

                txtEdad.Text = asp["ANIOS"].ToString();
                txtNombres.Text = asp["NOMBRES"].ToString();
                txtApellidos.Text = asp["APELLIDOS"].ToString();
                cbEstadoCivil.Text = asp["ESTADO_CIVIL"].ToString();
                cbmInstruccion.Text = asp["INSTRUCCION"].ToString();
                txtTelefono.Text = asp["TELEFONO"].ToString();
                txtMovil.Text = asp["MOVIL"].ToString();
                txtEmail.Text = asp["EMAIL"].ToString();
                cbmProvincia.Text = asp["PROVINCIA"].ToString();
                cbmCanton.Text = asp["CIUDAD"].ToString();
                cbmParroquia.Text = asp["PARROQUIA"].ToString();
                txtDireccion.Text = asp["DIRECCION"].ToString();
                txtObservacion.Text = asp["OBSERVACION"].ToString();
                cbmPara.Text = asp["APTO_PARA"].ToString();

                chkCedula.Checked = Convert.ToInt32(asp["TIENE_CEDULA"].ToString()) == 1;

                chkVotacion.Checked = Convert.ToInt32(asp["TIENE_CERTIFICADO_VOTACION"].ToString()) == 1;
                chkMilitar.Checked = Convert.ToInt32(asp["TIENE_LIBRETA_MILITAR"].ToString()) == 1;

                chkDiscapacitado.Checked = Convert.ToInt32(asp["TIENE_DISCAPACIDAD"].ToString()) == 1;
                txtDiscapacitado.Text = asp["TIPO_DISCAPACIDAD"].ToString();

                chkCursoVigilante.Checked = Convert.ToInt32(asp["TIENE_CURSO"].ToString()) == 1;
                txtEmisorCursoVigilante.Text = asp["ENTIDAD_CURSO"].ToString();

                chkCredencial.Checked = Convert.ToInt32(asp["TIENE_CREDENCIAL"].ToString()) == 1;
                txtCredencial.Text = asp["ENTIDAD_CREDENCIAL"].ToString();

                chkAntecedentes.Checked = Convert.ToInt32(asp["TIENE_ANTECEDENTES"].ToString()) == 1;
                txtAntecedentes.Text = asp["DETALLE_ANTECEDENTES"].ToString();


                chkNoViolencia.Checked = Convert.ToInt32(asp["TIENE_NO_VIOLENCIA"].ToString()) == 1;
                txtNoViolencia.Text = asp["DETALLE_NO_VIOLENCIA"].ToString();


                chkPiscologico.Checked = Convert.ToInt32(asp["TIENE_PSICOLOGICO"].ToString()) == 1;
                txtPiscologico.Text = asp["DETALLE_PSICOLOGICO"].ToString();


                chkCertificadoTrabajo.Checked = Convert.ToInt32(asp["TIENE_CERT_TRABAJO"].ToString()) == 1;
                txtCertificadoTrabajo.Text = asp["DETALLE_CERT_TRABAJO"].ToString();

                chkRecomendaciones.Checked = Convert.ToInt32(asp["TIENE_RECOMENDACION"].ToString()) == 1;
                txtRecomendaciones.Text = asp["DETALLE_RECOMENDACION"].ToString();


                chkBachiller.Checked = Convert.ToInt32(asp["TIENE_BACHILLER"].ToString()) == 1;
                txtBachiller.Text = asp["DETALLE_BACHILLER"].ToString();


                chkPoligrafica.Checked = Convert.ToInt32(asp["TIENE_POLIGRAFICA"].ToString()) == 1;
                txtPoligrafica.Text = asp["DETALLE_POLIGRAFICA"].ToString();


                chkAfis.Checked = Convert.ToInt32(asp["TIENE_AFIS"].ToString()) == 1;
                txtAfis.Text = asp["DETALLE_AFIS"].ToString();

                chkVehiculo.Checked = Convert.ToInt32(asp["TIENE_VEHICULO"].ToString()) == 1;
                txtVehiculo.Text = asp["DETALLE_VEHICULO"].ToString();


                try
                {
                    var tempFileName = Path.ChangeExtension(Path.GetTempFileName(), "PDF");
                    File.WriteAllBytes(tempFileName, (byte[])asp["DOCUMENTOS"]);

                    
                    //axAcroPDF1.LoadFile(tempFileName);
                    //axAcroPDF1.setShowToolbar(false);
                    //axAcroPDF1.setZoom(75);
                    //axAcroPDF1.setLayoutMode("SinglePage");
                    //axAcroPDF1.Show();
                }
                catch
                {                              
                    //axAcroPDF1.LoadFile("people.pdf");
                    //axAcroPDF1.Refresh();
                }

                HabilitarBotonesMenu(true, false, true, false);
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(@"Error al cargar detalles del personal: " + ex.Message, "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            CargarPersonal();
        }

        private void LimpiarParametros()
        {
            lblAspirante.Text = "0";
            lblAspirante.Tag = "0";
            txtCedula.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            cbmSexo.SelectedIndex = 0;
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpHoy.Value = DateTime.Now;
            cbEstadoCivil.SelectedIndex = 0;
            cbmInstruccion.SelectedIndex = 0;

            txtEdad.Text = @"0";
            cbmProvincia.SelectedIndex = 0;
            cbmCanton.SelectedIndex = 0;
            cbmParroquia.SelectedIndex = 0;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtMovil.Clear();
            txtEmail.Clear();
            txtObservacion.Clear();
            cbmPara.SelectedIndex = 0;

            btnDocumentos.Tag = 0;
            txtDocumentos.Text = "NO TIENE";

            chkCedula.Checked = false;
            chkVotacion.Checked = false;
            chkMilitar.Checked = false;

            chkDiscapacitado.Checked = false; 
            chkCursoVigilante.Checked = false;
            chkAntecedentes.Checked = false;
            chkCredencial.Checked = false;
            chkNoViolencia.Checked = false;
            chkPiscologico.Checked = false;
            chkCertificadoTrabajo.Checked = false;
            chkRecomendaciones.Checked = false;
            chkBachiller.Checked = false;
            chkPoligrafica.Checked = false;
            chkAfis.Checked = false;
            chkVehiculo.Checked = false;

            txtDiscapacitado.Text = "NO TIENE";
            txtEmisorCursoVigilante.Text = "NO TIENE";
            txtAntecedentes.Text = "NO TIENE";
            txtCredencial.Text = "NO TIENE";
            txtNoViolencia.Text = "NO TIENE";
            txtPiscologico.Text = "NO TIENE";
            txtCertificadoTrabajo.Text = "NO TIENE";
            txtRecomendaciones.Text = "NO TIENE";
            txtBachiller.Text = "NO TIENE";
            txtPoligrafica.Text = "NO TIENE";
            txtAfis.Text = "NO TIENE";
            txtVehiculo.Text = "NO TIENE";
        }

        private void txtCedula_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCedula.Text.Trim().Length == 10) ValidarCedula();
        }

        private void ValidarCedula()
        {
            var r = _objAspirante.BuscarCedulaExistente(TipoCon, txtCedula.Text.Trim());
            if (r > 0)
            {
                lblValCed.Image = Resources.erri;
                ButtonGuardar.Enabled = false;
                KryptonMessageBox.Show(@"El número de cédula ingresado ya se encuentra registrado como aspirante!",
                   @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            else
            {
                var dl = _objPersonal.BuscarLegalExistente(TipoCon, txtCedula.Text.Trim());
                if (dl.Rows.Count > 0)
                {
                    _frmNotificacion = new FrmNotificarNovedades(TipoConexion.Cisepro, Usuario,
                        "ALETA!!! Existen novedades relacionados con la C.I. que ingresó. Por favor, comuniquese con administración!", 0) { DataNotificacion = dl };
                    _frmNotificacion.ShowDialog();
                }

                var data = _objPersonal.SeleccionarTodosRegistrosPersonalFiltroFull(TipoCon, txtCedula.Text.Trim());
                if (data.Rows.Count > 0)
                {
                    txtCedula.Text = data.Rows[0]["CEDULA"].ToString();
                    chkCedula.Checked = true;
                    cbmSexo.Text = data.Rows[0]["SEXO"].ToString();
                    dtpFechaNacimiento.Text = data.Rows[0]["FECHA_NACIMIENTO"].ToString();
                    txtEdad.Text = data.Rows[0]["EDAD"].ToString();
                    txtNombres.Text = data.Rows[0]["NOMBRES"].ToString();
                    txtApellidos.Text = data.Rows[0]["APELLIDOS"].ToString();
                    cbEstadoCivil.Text = data.Rows[0]["ESTADO_CIVIL"].ToString();
                    cbmInstruccion.Text = data.Rows[0]["INSTRUCCION"].ToString();
                    cbmProvincia.Text = data.Rows[0]["PROVINCIA"].ToString();
                    cbmCanton.Text = data.Rows[0]["CIUDAD"].ToString();
                    cbmParroquia.Text = data.Rows[0]["PARROQUIA"].ToString();
                    txtDireccion.Text = data.Rows[0]["DIRECCION"].ToString();

                    txtMovil.Text = data.Rows[0]["MOVIL"].ToString();
                    txtTelefono.Text = data.Rows[0]["TELEFONO"].ToString();
                    txtEmail.Text = data.Rows[0]["EMAIL"].ToString();
                }

                dtpFechaNacimiento_ValueChanged(null, null);

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
            txtDiscapacitado.Enabled = chkDiscapacitado.Checked;
            txtDiscapacitado.Text = chkDiscapacitado.Checked ? "SIN DETALLE" : "NO TIENE";
            txtDiscapacitado.Focus();
        }

        private void chkCursoVigilante_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtEmisorCursoVigilante.Enabled = chkCursoVigilante.Checked;
            txtEmisorCursoVigilante.Text = chkCursoVigilante.Checked ? "SIN DETALLE" : "NO TIENE";
            txtEmisorCursoVigilante.Focus();
        }

        private void chkCredencial_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtCredencial.Enabled = chkCredencial.Checked;
            txtCredencial.Text = chkCredencial.Checked ? "SIN DETALLE" : "NO TIENE";
            txtCredencial.Focus();
        }

        private void chkAntecedentes_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtAntecedentes.Enabled = chkAntecedentes.Checked;
            txtAntecedentes.Text = chkAntecedentes.Checked ? "SIN DETALLE" : "NO TIENE";
            txtAntecedentes.Focus();
        }

        private void chkNoViolencia_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtNoViolencia.Enabled = chkNoViolencia.Checked;
            txtNoViolencia.Text = chkNoViolencia.Checked ? "SIN DETALLE" : "NO TIENE";
            txtNoViolencia.Focus();
        }

        private void chkPiscologico_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtPiscologico.Enabled = chkPiscologico.Checked;
            txtPiscologico.Text = chkPiscologico.Checked ? "SIN DETALLE" : "NO TIENE";
            txtPiscologico.Focus();
        }

        private void chkCertificadoTrabajo_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtCertificadoTrabajo.Enabled = chkCertificadoTrabajo.Checked;
            txtCertificadoTrabajo.Text = chkCertificadoTrabajo.Checked ? "SIN DETALLE" : "NO TIENE";
            txtCertificadoTrabajo.Focus();
        }

        private void chkRecomendaciones_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtRecomendaciones.Enabled = chkRecomendaciones.Checked;
            txtRecomendaciones.Text = chkRecomendaciones.Checked ? "SIN DETALLE" : "NO TIENE";
            txtRecomendaciones.Focus();
        }

        private void chkBachiller_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtBachiller.Enabled = chkBachiller.Checked;
            txtBachiller.Text = chkBachiller.Checked ? "SIN DETALLE" : "NO TIENE";
            txtBachiller.Focus();
        }

        private void chkPoligrafica_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtPoligrafica.Enabled = chkPoligrafica.Checked;
            txtPoligrafica.Text = chkPoligrafica.Checked ? "SIN DETALLE" : "NO TIENE";
            txtPoligrafica.Focus();
        }

        private void chkAfis_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtAfis.Enabled = chkAfis.Checked;
            txtAfis.Text = chkAfis.Checked ? "SIN DETALLE" : "NO TIENE";
            txtAfis.Focus();
        }

        private void chkVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            txtVehiculo.Enabled = chkVehiculo.Checked;
            txtVehiculo.Text = chkVehiculo.Checked ? "SIN DETALLE" : "NO TIENE";
            txtVehiculo.Focus();
        }

        private void ButtonNuevoRegistro_Click(object sender, EventArgs e)
        {
            LimpiarParametros();
            HabilitarRegistro(true);
            HabilitarTxtCheck(false);

            CargarProvincias();
            
            _estado = 1;

            HabilitarBotonesMenu(false, true, false, true);

            txtCedula.Focus();
        }

        private void HabilitarRegistro(bool enable)
        {
            txtCedula.Enabled = enable;
            txtNombres.Enabled = enable;
            txtApellidos.Enabled = enable;
            cbmSexo.Enabled = enable;
            dtpFechaNacimiento.Enabled = enable;
            txtEdad.Enabled = enable;
            cbEstadoCivil.Enabled = enable;
            cbmInstruccion.Enabled = enable;
            cbmProvincia.Enabled = enable;
            cbmCanton.Enabled = enable;
            cbmParroquia.Enabled = enable;
            txtDireccion.Enabled = enable;
            txtTelefono.Enabled = enable;
            txtMovil.Enabled = enable;
            txtEmail.Enabled = enable;
            txtObservacion.Enabled = enable;
            cbmPara.Enabled = enable;
            dtpHoy.Enabled = enable;

            btnDocumentos.Enabled = enable;

            chkCedula.Enabled = enable;
            chkVotacion.Enabled = enable;
            chkMilitar.Enabled = enable;

            chkDiscapacitado.Enabled = enable;
            chkCursoVigilante.Enabled = enable;
            chkAntecedentes.Enabled = enable;
            chkCredencial.Enabled = enable;
            chkNoViolencia.Enabled = enable;
            chkPiscologico.Enabled = enable;
            chkCertificadoTrabajo.Enabled = enable;
            chkRecomendaciones.Enabled = enable;
            chkBachiller.Enabled = enable;
            chkPoligrafica.Enabled = enable;
            chkAfis.Enabled = enable;
            chkVehiculo.Enabled = enable;           
        }
         
        private void HabilitarTxtCheck(bool enable)
        { 
            txtDiscapacitado.Enabled = enable;
            txtEmisorCursoVigilante.Enabled = enable;
            txtAntecedentes.Enabled = enable;
            txtCredencial.Enabled = enable;
            txtNoViolencia.Enabled = enable;
            txtPiscologico.Enabled = enable;
            txtCertificadoTrabajo.Enabled = enable;
            txtRecomendaciones.Enabled = enable;
            txtBachiller.Enabled = enable;
            txtPoligrafica.Enabled = enable;
            txtAfis.Enabled = enable;
            txtVehiculo.Enabled = enable;
        }

        private void HabilitarBotonesMenu(bool botonNuevo, bool botonGuardar, bool botonModificar, bool botonCancelar)
        {
            ButtonNuevoRegistro.Enabled = botonNuevo;
            ButtonGuardar.Enabled = botonGuardar;
            ButtonModificarRegistro.Enabled = botonModificar;
            ButtonCancelar.Enabled = botonCancelar;
        }

        private void ButtonModificarRegistro_Click(object sender, EventArgs e)
        {
            if (lblAspirante.Text.Trim().Length < 1)
            {
                KryptonMessageBox.Show(@"Debe seleccionar un registro para modificar datos!",
                    "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            HabilitarRegistro(true);
            
            txtDiscapacitado.Enabled = chkDiscapacitado.Checked;
            txtEmisorCursoVigilante.Enabled = chkCursoVigilante.Checked;
            txtAntecedentes.Enabled = chkAntecedentes.Checked;
            txtCredencial.Enabled = chkCredencial.Checked;
            txtNoViolencia.Enabled = chkNoViolencia.Checked;
            txtPiscologico.Enabled = chkPiscologico.Checked;
            txtCertificadoTrabajo.Enabled = chkCertificadoTrabajo.Checked;
            txtRecomendaciones.Enabled = chkRecomendaciones.Checked;
            txtBachiller.Enabled = chkBachiller.Checked;
            txtPoligrafica.Enabled = chkPoligrafica.Checked;
            txtAfis.Enabled = chkAfis.Checked;
            txtVehiculo.Enabled = chkVehiculo.Checked;

            _estado = 2;

            HabilitarBotonesMenu(false, true, false, true);
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {           
            LimpiarParametros();
            HabilitarRegistro(false);

            _estado = 0;
            HabilitarBotonesMenu(true, false, false, false);
            dgvPersonal_SelectionChanged(null, null);
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(@"Desea guardar el registro actual?",
                   "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
               DialogResult.Yes) return;

            txtTelefono.Text = txtTelefono.Text.Trim().Length == 0 ? @"NO TIENE" : txtTelefono.Text.Trim();
            txtMovil.Text = txtMovil.Text.Trim().Length == 0 ? @"NO TIENE" : txtMovil.Text.Trim();
            txtEmail.Text = txtEmail.Text.Trim().Length == 0 ? @"NO TIENE" : txtEmail.Text.Trim();

            _sqlCommands.Clear();

            if (_estado == 1) GuardarRegistroNuevoAspirante(false);
            else GuardarRegistroNuevoAspirante(true);

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "REGISTRAR PERSONAL");

            if ((bool)res[0])
            {
                lblAspirante.Text = _objAspirante.IdAspirante + "";                
                documento = null;
                _estado = 0;

                HabilitarRegistro(false);
                HabilitarTxtCheck(false);
                
                HabilitarBotonesMenu(true, false, true, false);

                CargarPersonal();
                dgvPersonal_SelectionChanged(null, null);
            }
            KryptonMessageBox.Show((string)res[1], "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void GuardarRegistroNuevoAspirante(bool esActualizar)
        {
            _objAspirante.IdAspirante = esActualizar ? Convert.ToInt32(lblAspirante.Text.Trim()) : _objAspirante.BuscarMayorId(TipoCon) + 1;
            _objAspirante.CedulaAspirante = txtCedula.Text.Trim();
            _objAspirante.SexoAspirante = cbmSexo.Text.Trim();
            _objAspirante.FechaNacimientoAspirante = dtpFechaNacimiento.Value;
            _objAspirante.EdadAspirante = Convert.ToInt32(txtEdad.Text);
            _objAspirante.NombresAspirante = txtNombres.Text.Trim();
            _objAspirante.ApellidosAspirante = txtApellidos.Text.Trim();
            _objAspirante.EstadoCivilAspirante = cbEstadoCivil.Text;
            _objAspirante.InstruccionAspirante = cbmInstruccion.Text.Trim();
            _objAspirante.TelefonoAspirante = txtTelefono.Text;
            _objAspirante.MovilAspirante = txtMovil.Text;
            _objAspirante.EmailAspirante = txtEmail.Text;
            _objAspirante.ProvinciaAspirante = cbmProvincia.Text;
            _objAspirante.CiudadAspirante = cbmCanton.Text;
            _objAspirante.ParroquiaAspirante = cbmParroquia.Text;
            _objAspirante.DireccionAspirante = txtDireccion.Text.Trim();
            _objAspirante.ObservacionAspirante = txtObservacion.Text.Trim();
            _objAspirante.AptoParaAspirante = cbmPara.Text.Trim();
            
            _objAspirante.TieneCedula = chkCedula.Checked ? 1 : 0;
            _objAspirante.TieneVotacion = chkVotacion.Checked ? 1 : 0;
            _objAspirante.TieneMilitar = chkMilitar.Checked ? 1 : 0;

            _objAspirante.TieneDiscapacidad = chkDiscapacitado.Checked ? 1 : 0;
            _objAspirante.TipoDiscapacidad = txtDiscapacitado.Text.Trim();

            _objAspirante.PruebaAntidroga = "NEGATIVO";

            _objAspirante.TieneCurso = chkCursoVigilante.Checked ? 1 : 0;
            _objAspirante.EntidadCurso = txtEmisorCursoVigilante.Text.Trim();

            _objAspirante.TieneCredencial = chkCredencial.Checked ? 1 : 0;
            _objAspirante.EntidadCredencial = txtCredencial.Text.Trim();

            _objAspirante.TieneAntecedentes = chkAntecedentes.Checked ? 1 : 0;
            _objAspirante.DetalleAntecedentes = txtAntecedentes.Text.Trim();

            _objAspirante.TieneNoViolencia = chkNoViolencia.Checked ? 1 : 0;
            _objAspirante.DetalleNoViolencia = txtNoViolencia.Text.Trim();

            _objAspirante.TienePsicologico = chkPiscologico.Checked ? 1 : 0;
            _objAspirante.DetallePsicologico = txtPiscologico.Text.Trim();

            _objAspirante.TieneCertTrabajo = chkCertificadoTrabajo.Checked ? 1 : 0;
            _objAspirante.DetalleCertTrabajo = txtCertificadoTrabajo.Text.Trim();

            _objAspirante.TieneRecomendacion = chkRecomendaciones.Checked ? 1 : 0;
            _objAspirante.DetalleRecomendacion = txtRecomendaciones.Text.Trim();

            _objAspirante.TieneBachiller = chkBachiller.Checked ? 1 : 0;
            _objAspirante.DetalleBachiller = txtBachiller.Text.Trim();


            _objAspirante.TienePoligrafica = chkPoligrafica.Checked ? 1 : 0;
            _objAspirante.DetallePoligrafica = txtPoligrafica.Text.Trim();

            _objAspirante.TieneAfis = chkAfis.Checked ? 1 : 0;
            _objAspirante.DetalleAfis = txtAfis.Text.Trim();

            _objAspirante.TieneVehiculo = chkVehiculo.Checked ? 1 : 0;
            _objAspirante.DetalleVehiculo = txtVehiculo.Text.Trim();

            _objAspirante.FechaRegistroAspirante = dtpHoy.Value;

            if (documento != null) _objAspirante.Documentos = (byte[])documento;
             
            _sqlCommands.Add(_objAspirante.SaveAspiranteCommand(esActualizar));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            CargarPersonal();
        }
 
        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_estado != 0) return;
            CargarPersonal();
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                Console.Write(new FileInfo(openFileDialog1.FileName).Length);

                if (openFileDialog1.FileName.Length > 1729300)
                {
                    txtDocumentos.Text = "ERROR AL CARGAR, LÍMITE MÁXIMO 1.6MB";
                    return;
                }

                txtDocumentos.Text = "DOCUMENTO CARGADO CORRECTAMENTE";
                btnDocumentos.Tag = 1;
                documento = File.ReadAllBytes(openFileDialog1.FileName);
            }
            catch 
            {
                txtDocumentos.Text = "ERROR AL CARGAR";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {

                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "ASPIRANTES";

                var l = -1;
                for (var i = 0; i <= dgvPersonal.Columns.Count - 1; i++) if (dgvPersonal.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l);

                var rc = dgvPersonal.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - ASPIRANTES";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = "REGISTRO DE ASPIRANTES                 Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;
                var x = 1;
                for (var i = 0; i <= dgvPersonal.Columns.Count - 1; i++)
                {
                    if (!dgvPersonal.Columns[i].Visible) continue;

                    worksheet.Cells[head, x] = dgvPersonal.Columns[i].HeaderText;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (DataGridViewRow row in dgvPersonal.Rows)
                {
                    var y = 1;
                    for (var j = 0; j <= dgvPersonal.Columns.Count - 1; j++)
                    {
                        if (!dgvPersonal.Columns[j].Visible) continue;

                        worksheet.Cells[head, y] = row.Cells[j].Value;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                        y++;
                    }

                    head++;
                }

                head += 3;

                worksheet.Range["A" + head + ":F" + head].Merge();
                worksheet.Range["A" + head + ":F" + head].Value = "";//Label1.Text;
                worksheet.Range["A" + head + ":F" + head].Font.Bold = true;
                worksheet.Range["A" + head + ":F" + head].Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                worksheet.Range["A" + head + ":F" + head].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A" + head + ":F" + head].Font.Color = Color.White;
                worksheet.Range["A" + head + ":F" + head].Font.Size = 12;


                var position = (Range)worksheet.Cells[2, 6];
                Clipboard.SetImage(ValidationForms.Logo(TipoCon));
                worksheet.Paste(position);

                worksheet.Range["A1:" + ic + rc].Columns.AutoFit();
                app.DisplayAlerts = false;
                app.Visible = true;
                app.DisplayAlerts = true;
                KryptonMessageBox.Show(@"ARCHIVO generado correctamente!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
    }
}
