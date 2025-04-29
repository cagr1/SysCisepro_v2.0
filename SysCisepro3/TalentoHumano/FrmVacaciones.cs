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
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using SysCisepro3.Operaciones;
using SysCisepro3.Properties;
using Krypton.Toolkit;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmVacaciones : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para registrar las salidas de vacaciones del personal
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmVacaciones _instance;
        public static FrmVacaciones Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmVacaciones();
                return _instance;
            }
        }

        private readonly ClassSitiosTrabajo _objSitiosTrabajo;
        private readonly ClassDetalleVacaciones _objDetalleVacaciones;
        private readonly ClassRegistroPermisoPersonal _objRegistroPermisoPersonal;
        private readonly ClassHistorialLaboral _objHistorialLaboral;

        private FrmBuscarPersonal _frmBuscarPersonal;
        private FrmBuscarPuestoTrabajo _femBuscarPuestoTrabajo;

        private int _estado;

        private int _tiempoLaborDias;

        private readonly List<SqlCommand> _sqlCommands;

        private FrmVacaciones()
        {
            InitializeComponent();
            _estado = 0;
            _tiempoLaborDias = 0;
            _sqlCommands = new List<SqlCommand>();
            _objSitiosTrabajo = new ClassSitiosTrabajo();
            _objDetalleVacaciones = new ClassDetalleVacaciones();
            _objRegistroPermisoPersonal = new ClassRegistroPermisoPersonal();
            _objHistorialLaboral = new ClassHistorialLaboral();
        }

        private void FrmVacaciones_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            //toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dataGridView2.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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
            dataGridView2.Font = new Font("Roboto", 8, FontStyle.Regular);
            dtpFecha.Value = Usuario.Now(TipoCon);
            dtpDesde.Value = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, 1, 0, 0, 0);
            dtpHasta.Value = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, 1, 0, 0, 0);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnPersonalEntra.Enabled = true;
            txtIdPersonal.Clear();
            txtPersonal.Clear();
            txtCargo.Clear();
            txtArea.Clear();
            txtArea.Tag = null;

            txtNumDoc.Clear();
            txtNumDoc.Enabled = false;
            txtNumDoc.Text = (_objRegistroPermisoPersonal.BuscarMayorIdDoc(TipoCon) + 1).ToString();

            dtpFecha.Value = Usuario.Now(TipoCon);
            bntPuesto.Enabled = false;
            txtSitio.Clear();
            txtSitio.Tag = null;
            dtpFecha.Enabled = false;
            dtpFecha.Tag = null;
            chkCobro.Checked = false;
            chkCobro.Enabled = false;

            dtpDesde.Value = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, 1, 0, 0, 0);
            dtpHasta.Value = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, 1, 0, 0, 0);

            txtDias.Clear();
            txtPendientes.Clear();
            txtObservacion.Enabled = false;
            txtObservacion.Clear();
            txtDias.Enabled = false;
            txtPendientes.Enabled = false;
            btnAgregar.Enabled = false;
            btnRemover.Enabled = false;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            _tiempoLaborDias = 0;

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            cbxPeriodo.Enabled = false;
            cbxPeriodo.DataSource = null;
            _estado = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(@"Desea guardar el registro actual?",
                   "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
               DialogResult.Yes) return;

            if (dataGridView2.RowCount == 0)
            {
                KryptonMessageBox.Show(@"Debe definir los detalles y días de vacaciones para guardar!",
                    "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            if (txtIdPersonal.Text.Trim().Length == 0 || txtSitio.Text.Trim().Length == 0 || txtDias.Text.Trim().Length == 0)
            {
                KryptonMessageBox.Show(@"Debe definir los datos y días de vacaciones para guardar!",
                    "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            if (dtpDesde.Value > dtpHasta.Value)
            {
                KryptonMessageBox.Show(@"La fecha SALIDA no puede ser mayor que la fecha de ENTRADA!",
                    "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            _sqlCommands.Clear();

            var fechaDesde = dtpDesde.Value.Year + "-" + dtpDesde.Value.Month + "-" + dtpDesde.Value.Day + " 00:00:00";
            var fechaHasta = dtpHasta.Value.AddDays(-1).Year + "-" + dtpHasta.Value.AddDays(-1).Month + "-" + dtpHasta.Value.AddDays(-1).Day + " 23:59:59";

            _objRegistroPermisoPersonal.IdRegistro = _objRegistroPermisoPersonal.BuscarMayorIdRegistroPermiso(TipoCon) + 1;
            _objRegistroPermisoPersonal.IdPersonal = Convert.ToInt32(txtIdPersonal.Text.Trim());
            _objRegistroPermisoPersonal.IdSancion = 34; // VACACIONES
            _objRegistroPermisoPersonal.Desde = Convert.ToDateTime(fechaDesde);
            _objRegistroPermisoPersonal.Hasta = Convert.ToDateTime(fechaHasta);
            _objRegistroPermisoPersonal.Estado = 1;
            _objRegistroPermisoPersonal.Observacionx = "VACACIONES SEGÚN OFIC. N° " + txtNumDoc.Text.Trim();
            _objRegistroPermisoPersonal.IdSitio = Convert.ToInt32(txtSitio.Tag);
            _objRegistroPermisoPersonal.FechaReg = dtpFecha.Value;
            _objRegistroPermisoPersonal.NumDoc = txtNumDoc.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtNumDoc.Text.Trim());
            _objRegistroPermisoPersonal.Certificado = new byte[0];
            _sqlCommands.Add(_objRegistroPermisoPersonal.NuevoRegistroPermisoCommands());

            _objHistorialLaboral.IdHistoriaLaboral = _objHistorialLaboral.BuscarMayorIdHistoriaLaboral(TipoCon) + 1;
            _objHistorialLaboral.FechaHistoriaLaboral = dtpFecha.Value;
            _objHistorialLaboral.DetalleHistoriaLaboral = "VACACIONES SEGÚN OFIC. N° " + txtNumDoc.Text.Trim();
            _objHistorialLaboral.EstadoHistoriaLaboral = 1;
            _objHistorialLaboral.IdPersonalHistoriaLaboral = Convert.ToInt32(txtIdPersonal.Text.Trim());
            _objHistorialLaboral.IdSitioHistoriaLaboral = "1";
            _objHistorialLaboral.IdSitioAuxHistoriaLaboral = 0;
            _sqlCommands.Add(_objHistorialLaboral.RegistrarNuevoHistorialLaboralCommand());

            var i = _objDetalleVacaciones.BuscarMayorIdDetalleVacaciones(TipoCon) + 1;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                _objDetalleVacaciones.IdDetalle = i;
                _objDetalleVacaciones.NumDoc = _objRegistroPermisoPersonal.NumDoc;
                _objDetalleVacaciones.IdPersonal = _objRegistroPermisoPersonal.IdPersonal;
                _objDetalleVacaciones.FechaRegistro = _objRegistroPermisoPersonal.FechaReg;
                _objDetalleVacaciones.FechaSalida = Convert.ToDateTime(row.Cells[1].Value);
                _objDetalleVacaciones.FechaEntrada = Convert.ToDateTime(row.Cells[2].Value);
                _objDetalleVacaciones.DiasVac = Convert.ToInt32(row.Cells[3].Value);
                _objDetalleVacaciones.DiasPen = Convert.ToInt32(row.Cells[4].Value);
                _objDetalleVacaciones.Periodo = row.Cells[5].Value.ToString();
                _objDetalleVacaciones.FechaFirma = _objRegistroPermisoPersonal.FechaReg;
                _objDetalleVacaciones.IdPermiso = _objRegistroPermisoPersonal.IdRegistro;
                _objDetalleVacaciones.Observacion = row.Cells[6].Value.ToString();
                _objDetalleVacaciones.ValorCobro = Convert.ToDecimal(row.Cells[7].Value);
                _sqlCommands.Add(_objDetalleVacaciones.RegistrarNuevoDetalleVacacionesCommand());
                i++;
            }

            var user = Usuario.Datos.ToString();
            var nombre = $"Registro de Vacaciones por: {user}";
            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombre);

            if ((bool)res[0])
            {
                _estado = 0;

                btnPersonalEntra.Enabled = false;
                bntPuesto.Enabled = false;
                dtpFecha.Enabled = false;
                txtObservacion.Enabled = false;
                txtNumDoc.Enabled = false;
                cbxPeriodo.Enabled = false;

                chkCobro.Enabled = false;

                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;

                btnAgregar.Enabled = false;
                btnRemover.Enabled = false;

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;

                LlenarDetalleVacaciones(Convert.ToInt32(txtIdPersonal.Text.Trim()));
            }
            KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = 0;
            btnPersonalEntra.Enabled = false;
            txtIdPersonal.Clear();
            txtPersonal.Clear();
            txtCargo.Clear();
            txtArea.Clear();
            txtArea.Tag = null;

            txtNumDoc.Clear();
            txtNumDoc.Enabled = false;
            dtpFecha.Value = Usuario.Now(TipoCon);
            bntPuesto.Enabled = false;
            txtSitio.Clear();
            txtSitio.Tag = null;
            dtpFecha.Enabled = false;
            dtpFecha.Tag = null;
            chkCobro.Checked = false;
            chkCobro.Enabled = false;

            dtpDesde.Value = dtpFecha.Value;
            dtpHasta.Value = dtpFecha.Value;
            txtDias.Clear();
            txtPendientes.Clear();
            txtObservacion.Enabled = false;
            txtObservacion.Clear();
            txtDias.Enabled = false;
            txtPendientes.Enabled = false;
            btnAgregar.Enabled = false;
            btnRemover.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            _tiempoLaborDias = 0;

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            cbxPeriodo.Enabled = false;
            cbxPeriodo.DataSource = null;
        }

        private void LlenarPeriodosValidos()
        {
            cbxPeriodo.DataSource = null;

            var fe = dtpFechaEntrada.Value;

            var a = Convert.ToDecimal(Usuario.Now(TipoCon).AddMonths(1).Subtract(fe).Days / 365);

            var b = Math.Floor(a);
            if (a.ToString("N").Contains(".")) a = b + 1;


            var data = new DataTable();
            data.Columns.Add("PERIODO");
            data.Columns.Add("DIAS");

            for (var i = 1; i <= a; i++)
            {
                var p = fe.Day + "/" + fe.Month + "/" + fe.Year + " - " + fe.AddYears(1).Day + "/" + fe.AddYears(1).Month + "/" + fe.AddYears(1).Year;
                var x = (from DataGridViewRow row in dataGridView1.Rows
                         where row.Cells[7].Value.ToString().Equals(p.Trim())
                         select Convert.ToInt32(row.Cells[5].Value)).Sum();

                if (txtArea.Tag != null && (bool)txtArea.Tag)
                {
                    if (i > 20) x = 30 - x < 0 ? 0 : 30 - x;
                    else
                    {
                        if (i < 5) x = 15 - x < 0 ? 0 : 15 - x;
                        else x = (10 + i) - x < 0 ? 0 : (10 + i) - x;
                    }
                }
                else x = 15 - x < 0 ? 0 : 15 - x;

                if (fe.Year > 2016) data.Rows.Add(p, x);
                fe = fe.AddYears(1);
            }
            cbxPeriodo.DataSource = data;
            cbxPeriodo.DisplayMember = "PERIODO";
            cbxPeriodo.ValueMember = "DIAS";
            cbxPeriodo.SelectedIndex = 0;
        }

        private void cbxPeriodo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxPeriodo.DataSource == null) return;
                if (cbxPeriodo.SelectedValue == null) return;
                if (Convert.ToInt32(cbxPeriodo.SelectedValue) == 0)
                {
                    txtDisponibles.Text = @"0";
                    btnAgregar.Enabled = false;
                    dtpDesde.Enabled = false;
                    dtpHasta.Enabled = false;
                    return;
                }
                if (_estado != 0) txtDisponibles.Text = cbxPeriodo.SelectedValue.ToString();
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;
                dtpDesde_ValueChanged(null, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LlenarDetalleVacaciones(int idp)
        {
            try
            {
                dataGridView1.Rows.Clear();
                var data = _objDetalleVacaciones.SeleccionarRegistroVacacionesIdPersonal(TipoCon, idp);

                var i = 0;
                foreach (DataRow row in data.Rows)
                {
                    dataGridView1.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
                    i++;
                }

                dataGridView1.Columns[3].DefaultCellStyle.Format = "d";
                dataGridView1.Columns[4].DefaultCellStyle.Format = "d";

                dataGridView1.AutoResizeRows();
            }
            catch
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void btnPersonalEntra_Click(object sender, EventArgs e)
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

                var admin = _frmBuscarPersonal.dataGridView1.CurrentRow.Cells["ID_GERENCIAS_GENERAL"].Value.ToString().Equals("1");
                txtArea.Tag = admin;

                dtpFechaEntrada.Value = Convert.ToDateTime(_frmBuscarPersonal.dataGridView1.CurrentRow.Cells["FECHA_ENTRADA"].Value);

                var sit = _objSitiosTrabajo.BuscarUltimoPuestoPorIdPersonal(TipoCon, Convert.ToInt32(txtIdPersonal.Text.Trim()), admin);
                if (sit.Rows.Count > 0)
                {
                    if (admin)
                    {
                        txtSitio.Tag = sit.Rows[0][0].ToString();
                        txtSitio.Text = sit.Rows[0][6] + @" (" + sit.Rows[0][29] + @")";
                    }
                    else
                    {
                        txtSitio.Tag = sit.Rows[0][2].ToString();
                        txtSitio.Text = sit.Rows[0][15] + @" (" + sit.Rows[0][37] + @")";
                    }
                }

                _tiempoLaborDias = Usuario.Now(TipoCon).Subtract(dtpFechaEntrada.Value).Days;

                //if (_tiempoLaborDias > 365) // debe tener más del AÑO
                //{
                    bntPuesto.Enabled = true;
                    dtpFecha.Enabled = true;

                    txtObservacion.Enabled = true;
                    //txtNumDoc.Enabled = true;
                    txtDias.Enabled = false;
                    txtPendientes.Enabled = false;
                    cbxPeriodo.Enabled = true;
                    chkCobro.Enabled = true;

                    LlenarDetalleVacaciones(Convert.ToInt32(txtIdPersonal.Text.Trim()));

                    LlenarPeriodosValidos();

                    txtNumDoc.Focus();
                //}
                //else KryptonMessageBox.Show(@"Aún no se ha cumplido el tiempo mínimo para aplicar VACACIONES!!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
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
                txtSitio.Tag = _femBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[0].Text.Trim();
                txtSitio.Text = _femBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[2].Text + @" (" +
                    _femBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[18].Text.Trim() + @")";
            }
            catch
            {
                txtSitio.Text = @"AUN NO SE ESPECIFICA";
                txtSitio.Tag = 0;
            }
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validaciones.IsNumeroEntero(e.KeyChar);
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            if (dtpDesde.Value > dtpHasta.Value)
            {
                txtDias.Text = @"0";
                txtPendientes.Text = @"0";
                btnAgregar.Enabled = false;
                KryptonMessageBox.Show(@"La fecha SALIDA no puede ser mayor que la fecha de ENTRADA!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            if (dtpHasta.Value.Subtract(dtpDesde.Value).Days > Convert.ToInt32(txtDisponibles.Text.Trim()))
            {
                txtDias.Text = @"0";
                txtPendientes.Text = @"0";
                btnAgregar.Enabled = false;
                KryptonMessageBox.Show(@"El número de días no debe ser mayor a los días pendientes para el período seleccionado!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            int diasVaciones = (dtpHasta.Value.Date - dtpDesde.Value.Date).Days + 1;
            txtDias.Text = diasVaciones.ToString();
            //txtDias.Text = dtpHasta.Value.Subtract(dtpDesde.Value).Days + "";

            var d = (from DataGridViewRow row in dataGridView2.Rows
                     where row.Cells[5].Value.ToString().Equals(cbxPeriodo.Text.Trim())
                     select Convert.ToInt32(row.Cells[3].Value)).Sum();
            int diasDisponibles = Convert.ToInt32(cbxPeriodo.SelectedValue) - d;
            //txtDisponibles.Text = (Convert.ToInt32(cbxPeriodo.SelectedValue) - d) + "";
            txtDisponibles.Text = diasDisponibles.ToString();
            //txtPendientes.Text = (Convert.ToInt32(txtDisponibles.Text.Trim()) - dtpHasta.Value.Subtract(dtpDesde.Value).Days) + "";
            int pendientes = diasDisponibles - diasVaciones;
            //txtPendientes.Text = Convert.ToInt32(txtDisponibles.Text.Trim()) - diasVaciones;
            txtPendientes.Text = pendientes.ToString();
            btnAgregar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var ex = dataGridView2.Rows.Cast<DataGridViewRow>().Any(row =>
                row.Cells[1].Value.ToString().Equals(dtpDesde.Value.ToShortDateString()) ||
                row.Cells[2].Value.ToString().Equals(dtpHasta.Value.ToShortDateString()));

            if (ex)
            {
                KryptonMessageBox.Show(@"El detalle ya fue agregado a la lista!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            //if (dtpDesde.Value == dtpHasta.Value)
            //{
            //    KryptonMessageBox.Show(@"Verifique la fecha de SALIDA - ENTRADA!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            //    return;
            //}

            var valor = chkCobro.Checked ? txtValorCobro.Text.Trim().Length > 0 ? Convert.ToDecimal(txtValorCobro.Text.Trim()) : 0 : 0;

            dataGridView2.Rows.Add(dataGridView2.RowCount + 1, dtpDesde.Value.ToShortDateString(), dtpHasta.Value.ToShortDateString(), txtDias.Text.Trim(), txtPendientes.Text.Trim(), cbxPeriodo.Text.Trim(), txtObservacion.Text.Trim(), valor.ToString("N"));
            btnRemover.Enabled = true;

            var d = (from DataGridViewRow row in dataGridView2.Rows
                     where row.Cells[5].Value.ToString().Equals(cbxPeriodo.Text.Trim())
                     select Convert.ToInt32(row.Cells[3].Value)).Sum();
            txtDisponibles.Text = (Convert.ToInt32(cbxPeriodo.SelectedValue) - d) + "";

            txtObservacion.Clear();
            txtValorCobro.Clear();
            chkCobro.Checked = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount == 0) return;
            if (dataGridView2.CurrentRow == null) return;
            dataGridView2.Rows[dataGridView2.Rows.Count - 1].Selected = true;
            dataGridView2.Rows.RemoveAt(dataGridView2.Rows.Count - 1);
            var d = (from DataGridViewRow row in dataGridView2.Rows
                     where row.Cells[5].Value.ToString().Equals(cbxPeriodo.Text.Trim())
                     select Convert.ToInt32(row.Cells[3].Value)).Sum();
            txtDisponibles.Text = (Convert.ToInt32(cbxPeriodo.SelectedValue) - d) + "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCobro.Checked && txtArea.Tag == null)
            {
                dtpDesde.Value = new DateTime(dtpFecha.Value.Year, dtpFechaEntrada.Value.Month, dtpFechaEntrada.Value.Day);
                dtpHasta.Value = dtpDesde.Value.AddDays(15);
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
            }

            txtValorCobro.Enabled = chkCobro.Checked;
            txtValorCobro.Clear();

            TextoCobro();
        }

        private void TextoCobro()
        {
            if (chkCobro.Checked) txtObservacion.Text = @"VACACIONES COBRADAS SOLICITUD N° " + txtNumDoc.Text.Trim() + @", PERÍODO: " + cbxPeriodo.Text + @", " + txtDias.Text.Trim() + @" ==> $ " + txtValorCobro.Text.Trim();
            else txtObservacion.Clear();
        }

        private void txtValorCobro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validaciones.IsNumeroDecimal(e.KeyChar, txtValorCobro.Text.Trim());
        }

        private void txtValorCobro_KeyUp(object sender, KeyEventArgs e)
        {
            TextoCobro();
        }
    }
}
