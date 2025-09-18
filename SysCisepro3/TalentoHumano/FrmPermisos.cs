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
using Microsoft.Office.Interop.Excel;
using SysCisepro3.Datos;
using SysCisepro3.Operaciones;
using SysCisepro3.Reportes;
using SysCisepro3.Properties;
using Office = Microsoft.Office.Interop;
using CrystalDecisions.CrystalReports.Engine;
using Krypton.Toolkit;
using System.IO;
using System.Drawing.Text;
using PdfiumViewer;


namespace SysCisepro3.TalentoHumano
{
    public partial class FrmPermisos : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para registrar permisos del personal
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmPermisos _instance;
        public static FrmPermisos Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmPermisos(TipoCon,Usuario);
                return _instance;
            }
        }

        private readonly ClassRegistroPermisoPersonal _objRegistroPermisoPersonal;
        private readonly ClassHistorialLaboral _objHistorialLaboral;
        private readonly ClassSitiosTrabajo _objSitiosTrabajo;
        private readonly ClassPersonal _objPersonal;

        private FrmBuscarPersonal _frmBuscarPersonal;
        private FrmBuscarPuestoTrabajo _femBuscarPuestoTrabajo;

        public DataGridViewRow Fila { private get; set; }

        private readonly List<SqlCommand> _sqlCommands;
        private MemoryStream _ms;

        private int _estado;

        public byte[] _cm;



        //public FrmPermisos(TipoConexion tipoCon, ClassUsuarioGeneral usuario)
        //{
        //    InitializeComponent();
        //    _estado = 0;
        //    TipoCon = tipoCon;
        //    Usuario = usuario;
        //    _sqlCommands = new List<SqlCommand>();
        //    _objRegistroPermisoPersonal = new ClassRegistroPermisoPersonal();
        //    _objHistorialLaboral = new ClassHistorialLaboral();
        //    _objSitiosTrabajo = new ClassSitiosTrabajo();
        //    _objPersonal = new ClassPersonal();


        //    openFileDialog1 = new OpenFileDialog()
        //    {
        //        InitialDirectory = @"C:\",
        //        Title = "SELECCIONAR DOCUMENTO",
        //        CheckFileExists = true,
        //        CheckPathExists = true,
        //        DefaultExt = "pdf",
        //        Filter = "Archivos PDF (*.pdf)|*.pdf",
        //        FilterIndex = 2,
        //        RestoreDirectory = true,
        //        ReadOnlyChecked = true,
        //        ShowReadOnly = true
        //    };


        //}

        public FrmPermisos(TipoConexion tipoCon, ClassUsuarioGeneral usuario)
        {
            InitializeComponent();
            _estado = 0;
            TipoCon = tipoCon;
            Usuario = usuario;
            _sqlCommands = new List<SqlCommand>();
            _objRegistroPermisoPersonal = new ClassRegistroPermisoPersonal();
            _objHistorialLaboral = new ClassHistorialLaboral();
            _objSitiosTrabajo = new ClassSitiosTrabajo();
            _objPersonal = new ClassPersonal();


            openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "SELECCIONAR DOCUMENTO",
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
            private void FrmPermisos_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            //toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            //toolStrip1.ForeColor = Color.White;
            
            
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


            dtpFecha.Value = Usuario.Now(TipoCon);
            dtpFechaDesde.Value = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, 1);

            LlenarMotivoPermisosFiltro();
            LlenarMotivoPermisos();
            AutorizacionPermisos();
        }

        private void AutorizacionPermisos()
        {
            if( Usuario.TipoUsuario == "MONITOREO" || Usuario.TipoUsuario == "JEFE DE OPERACIONES")
            {
                btnGuardar.Visible = false;
                btnAnular.Visible = false;
                btnNuevo.Visible = false;

            }


        }

        private void LlenarMotivoPermisos()
        {
            try
            {
                var data = _objRegistroPermisoPersonal.SeleccionarTiposPermisos(TipoCon);
                cbmMotivo.DataSource = data;
                cbmMotivo.DisplayMember = "detalle";
                cbmMotivo.ValueMember = "id_sancion";
                cbmMotivo.DropDownWidth = 250;
                cbmMotivo.SelectedIndex = 0;
            }
            catch
            {
                cbmMotivo.DataSource = null;
            }
        }

        private void LlenarMotivoPermisosFiltro()
        {
            try
            {
                var data = _objRegistroPermisoPersonal.SeleccionarTiposPermisosFiltro(TipoCon);
                cbxFiltro.DataSource = data;
                cbxFiltro.DisplayMember = "detalle";
                cbxFiltro.ValueMember = "id_sancion";
                cbxFiltro.DropDownWidth = 250;
                cbxFiltro.SelectedIndex = 0;
            }
            catch
            {
                cbxFiltro.DataSource = null;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LlenarMotivoPermisos();

            
            btnBuscarPersonal.Enabled = true;
            btnBuscarPuesto.Enabled = true;
            btnBuscarTipo.Enabled = true;
            txtIdPersonal.Clear();
            txtPersonal.Clear();
            txtCargo.Clear();
            txtArea.Clear();
            txtNumDoc.Clear();

            dtpFecha.Value = Usuario.Now(TipoCon);
            dtpDesde.Value = dtpFecha.Value;
            dtpHasta.Value = dtpFecha.Value;
            txtObservacion.Enabled = true;
            //txtNumDoc.Enabled = true;
            txtNumDoc.Text = (_objRegistroPermisoPersonal.BuscarMayorIdDoc(TipoCon) + 1).ToString();
            dtpFecha.Enabled = true;
            dtpFecha.Tag = null;
            dtpDesde.Enabled = true;
            dtpHasta.Enabled = true;
            cbmMotivo.Enabled = true;
            txtObservacion.Clear();
            txtSitio.Clear();
            txtSitio.Tag = null;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnAnular.Enabled = false;
            btnCancelar.Enabled = true;
            _estado = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(@"Desea guardar el registro actual?",
                   "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
               DialogResult.Yes) return;

            if (txtIdPersonal.Text.Trim().Length == 0 || txtSitio.Text.Trim().Length == 0 || txtObservacion.Text.Trim().Length == 0 ||
                string.IsNullOrEmpty(cbmMotivo.Text))
            {
                KryptonMessageBox.Show(@"Debe definir los datos y tipo de permiso para guardar!",
                    "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            if (dtpDesde.Value > dtpHasta.Value)
            {
                KryptonMessageBox.Show(@"La fecha de inicio debe ser mayor o igual a la fecha fin!",
                    "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
            if (Convert.ToInt32(cbmMotivo.SelectedValue) == 33 && txtCertificado.Text.Trim().Length == 0)
            {
                KryptonMessageBox.Show(@"Seleccione el documento PDF",
                    "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            _sqlCommands.Clear();

            //var fechaDesde = dtpDesde.Value.Year + "-" + dtpDesde.Value.Month + "-" + dtpDesde.Value.Day + " 00:00:00";
            //var fechaHasta = dtpHasta.Value.Year + "-" + dtpHasta.Value.Month + "-" + dtpHasta.Value.Day + " 23:59:59";

            var fechaDesde = dtpDesde.Value;
            var fechaHasta = dtpHasta.Value;
            try
            {
                _objRegistroPermisoPersonal.IdRegistro = _objRegistroPermisoPersonal.BuscarMayorIdRegistroPermiso(TipoCon) + 1;
                _objRegistroPermisoPersonal.IdPersonal = Convert.ToInt32(txtIdPersonal.Text.Trim());
                _objRegistroPermisoPersonal.IdSancion = Convert.ToInt32(cbmMotivo.SelectedValue);
                _objRegistroPermisoPersonal.Desde = fechaDesde;
                _objRegistroPermisoPersonal.Hasta = fechaHasta;
                _objRegistroPermisoPersonal.Estado = 1;
                _objRegistroPermisoPersonal.Observacionx = txtObservacion.Text.Trim();
                _objRegistroPermisoPersonal.IdSitio = Convert.ToInt32(txtSitio.Tag);
                _objRegistroPermisoPersonal.FechaReg = dtpFecha.Value;
                _objRegistroPermisoPersonal.NumDoc = Convert.ToInt32(txtNumDoc.Text.Trim()); //txtNumDoc.Text.Trim().Length == 0 ? 0 : Convert.ToInt32(txtNumDoc.Text.Trim());
                _objRegistroPermisoPersonal.Certificado = _cm ?? new byte[0];
                _sqlCommands.Add(_objRegistroPermisoPersonal.NuevoRegistroPermisoCommands());

                _objHistorialLaboral.IdHistoriaLaboral = _objHistorialLaboral.BuscarMayorIdHistoriaLaboral(TipoCon) + 1;
                _objHistorialLaboral.FechaHistoriaLaboral = dtpFecha.Value;
                _objHistorialLaboral.DetalleHistoriaLaboral = "REGISTRA PERMISO POR CONCEPTO DE: " + cbmMotivo.Text.Trim() + ", " + txtObservacion.Text.Trim();
                _objHistorialLaboral.EstadoHistoriaLaboral = 1;
                _objHistorialLaboral.IdPersonalHistoriaLaboral = Convert.ToInt32(txtIdPersonal.Text.Trim());
                _objHistorialLaboral.IdSitioHistoriaLaboral = "1";
                _objHistorialLaboral.IdSitioAuxHistoriaLaboral = 0;
                _sqlCommands.Add(_objHistorialLaboral.RegistrarNuevoHistorialLaboralCommand());

            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(@"Error al procesar datos: " + ex.Message, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
            var user = Usuario.Datos.ToString();
            var nombre = $"Registro de Permiso por: {user}";
            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombre);

            if ((bool)res[0])
            {
                
                btnBuscarPuesto.Enabled = false;
                btnBuscarPersonal.Enabled = false;
                btnBuscarTipo.Enabled = false;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = true;
                btnCancelar.Enabled = false;
                dtpFecha.Enabled = false;
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
                txtObservacion.Enabled = false;
                cbmMotivo.Enabled = false;
                txtNumDoc.Enabled = false;
                txtFiltro.Clear();
                _cm = null;
                _estado = 0;

                CargarAsignaciones(string.Empty, _objRegistroPermisoPersonal.IdRegistro);
            }
            KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count == 0 || dtpFecha.Tag == null) return;

            if (KryptonMessageBox.Show(@"Desea anular el registro seleccioando?", "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objRegistroPermisoPersonal.IdRegistro = Convert.ToInt32(dtpFecha.Tag);
            _objRegistroPermisoPersonal.Estado = 0;
            _sqlCommands.Add(_objRegistroPermisoPersonal.AnularRegistroPermisoCommand());

            var user = Usuario.Datos.ToString();
            var nombre = $"Permiso anulado por: {user}";
            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombre);

            if ((bool)res[0])
            {
                
                btnBuscarPersonal.Enabled = false;
                btnBuscarPuesto.Enabled = false;
                btnBuscarTipo.Enabled = false;
                txtObservacion.Enabled = false;
                dtpFecha.Enabled = false;
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
                cbmMotivo.Enabled = false;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = false;
                btnCancelar.Enabled = false;
                txtNumDoc.Enabled = false;

                _estado = 0;
                txtFiltro.Clear();
                txtCertificado.Clear();
                CargarAsignaciones(string.Empty, 0);
            }
            KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            btnBuscarPersonal.Enabled = false;
            btnBuscarPuesto.Enabled = false;
            btnBuscarTipo.Enabled = false;
            txtIdPersonal.Clear();
            txtPersonal.Clear();
            txtCargo.Clear();
            txtArea.Clear();
            txtNumDoc.Clear();
            txtNumDoc.Enabled = false;
            dtpFecha.Enabled = false;
            dtpFecha.Tag = null;
            dtpDesde.Enabled = false;
            dtpHasta.Enabled = false;
            cbmMotivo.Enabled = false;
            txtObservacion.Enabled = false;
            txtObservacion.Clear();
            _estado = 0;
            txtSitio.Clear();
            txtSitio.Tag = null;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = false;
            btnCancelar.Enabled = false;
            _cm = null;
            txtCertificado.Clear();
            Label1.Text = @"0 REGISTRO(S)";
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            CargarAsignaciones(txtFiltro.Text.Trim(), 0);
        }

        private void CargarAsignaciones(string filtro, int selId)
        {
            try
            {
                var tipo = cbxFiltro.Text;
                var fechaDesde = dtpFechaDesde.Value.Day + "-" + dtpFechaDesde.Value.Month + "-" + dtpFechaDesde.Value.Year + " 00:00:00";
                var fechaHasta = dtpFechaHasta.Value.Day + "-" + dtpFechaHasta.Value.Month + "-" + dtpFechaHasta.Value.Year + " 23:59:59";

                var grupos = _objRegistroPermisoPersonal.SeleccionarRegistroPermisosGrupos(TipoCon, filtro, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));
                var datos = _objRegistroPermisoPersonal.SeleccionarPermisosDatos(TipoCon, filtro, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta), tipo);
                //var reporte = _objRegistroPermisoPersonal.SeleccionarPermisosDatos(TipoCon, filtro, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta), tipo);
                listView2.Items.Clear();
                listView2.Groups.Clear();               
               

                foreach (DataRow row in grupos.Rows)
                {
                    var group = new ListViewGroup(row[0].ToString().Trim());
                    listView2.Groups.Add(group);
                }

                foreach (DataRow row in datos.Rows)
                {
                    var lst = new ListViewItem(row[0] != null ? row[0].ToString() : string.Empty, GetListViewGroup(row[1].ToString().Trim()));
                    for (var i = 1; i <= datos.Columns.Count - 1; i++)
                    {
                        if (i == 5 || i == 6) lst.SubItems.Add(Convert.ToDateTime(row[i]).ToString("dd/MM/yyyy HH:mm:ss"));
                        else lst.SubItems.Add(row[i] != null ? row[i].ToString() : string.Empty);
                    }
                    listView2.Items.Add(lst);
                }

                foreach (ColumnHeader column in listView2.Columns) column.Width = -2;

                listView2.Columns[0].Width = 0;
                listView2.Columns[1].Width = 0;
                listView2.Columns[2].Width = 0;
                listView2.Columns[7].Width = 0;
                listView2.Columns[9].Width = 0;
                listView2.Columns[11].Width = 0;
                Label1.Text = (datos.Rows.Count + @" REGISTRO(S)");

               

               

                if (selId == 0) return;

                foreach (var row in listView2.Items.Cast<ListViewItem>().Where(row => row.SubItems[0].Text.Trim().Equals(selId.ToString().Trim())))
                {
                    row.EnsureVisible();
                    listView2.Items[row.Index].Selected = true;
                    listView2.Select();
                    break;
                }

               
              


            }
            catch (Exception ex)
            {
                listView2.Items.Clear();
                KryptonMessageBox.Show(@"Error al cargar detalles: " + ex.Message, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private ListViewGroup GetListViewGroup(string name)
        {
            return listView2.Groups.Cast<ListViewGroup>().FirstOrDefault(grupo => grupo.ToString().Trim().Equals(name.Trim()));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            CargarAsignaciones(txtFiltro.Text.Trim(), 0);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_estado != 0) return;
            if (listView2.Items.Count == 0) return;
            if (listView2.SelectedItems.Count == 0) return;

            dtpFecha.Tag = listView2.SelectedItems[0].SubItems[0].Text;
            txtIdPersonal.Text = listView2.SelectedItems[0].SubItems[7].Text;
            txtPersonal.Text = listView2.SelectedItems[0].SubItems[4].Text;
            txtCargo.Text = listView2.SelectedItems[0].SubItems[8].Text;
            txtArea.Text = listView2.SelectedItems[0].SubItems[9].Text;
            cbmMotivo.SelectedValue = listView2.SelectedItems[0].SubItems[2].Text;
            txtObservacion.Text = listView2.SelectedItems[0].SubItems[10].Text;

            txtNumDoc.Text = listView2.SelectedItems[0].SubItems[13].Text;

            dtpDesde.Value = Convert.ToDateTime(listView2.SelectedItems[0].SubItems[5].Text);
            dtpHasta.Value = Convert.ToDateTime(listView2.SelectedItems[0].SubItems[6].Text);

           


            txtSitio.Text = listView2.SelectedItems[0].SubItems[12].Text;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = true;
            btnCancelar.Enabled = false;
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

                try
                {
                    var data = _objPersonal.SeleccionarTodosRegistrosPersonalFiltroFull(TipoCon, _frmBuscarPersonal.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    dateTimePicker1.Text = data.Rows[0]["FECHA_NACIMIENTO"].ToString();
                    textBox1.Text = data.Rows[0]["EDAD"].ToString();
                }
                catch
                {
                    dateTimePicker1.Value = DateTime.MinValue;
                    textBox1.Text = @"0";
                }

                var sit = _objSitiosTrabajo.BuscarUltimoPuestoPorIdPersonal(TipoCon, Convert.ToInt32(txtIdPersonal.Text.Trim()), admin);
                if (sit.Rows.Count == 0) return;
                if (admin)
                {
                    txtSitio.Tag = sit.Rows[0][0].ToString();
                    txtSitio.Text = sit.Rows[0][6] + @" (" + sit.Rows[0][20] + @")";
                }
                else
                {
                    txtSitio.Tag = sit.Rows[0][2].ToString();
                    txtSitio.Text = sit.Rows[0][15] + @" (" + sit.Rows[0][29] + @")";
                }
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

        private void cbmMotivo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbmMotivo.DataSource == null) return;
            if (cbmMotivo.SelectedValue == null) return;
            if (_estado == 0) return;
            if (!cbmMotivo.SelectedValue.ToString().Equals("34")) return; // SOLO PARA EL CASO DE VACACIONES

            _estado = 0;
            
            btnBuscarPersonal.Enabled = false;
            btnBuscarPuesto.Enabled = false;
            txtIdPersonal.Clear();
            txtPersonal.Clear();
            txtCargo.Clear();
            txtArea.Clear();
            dtpFecha.Tag = null;
            dtpFecha.Enabled = false;
            dtpDesde.Enabled = false;
            dtpHasta.Enabled = false;
            cbmMotivo.Enabled = false;
            txtObservacion.Enabled = false;
            txtNumDoc.Clear();
            txtNumDoc.Enabled = false;
            txtObservacion.Clear();
            txtSitio.Clear();
            txtSitio.Tag = null;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = false;
            btnCancelar.Enabled = false;
            cbmMotivo.SelectedIndex = 0;
            Label1.Text = @"0 REGISTRO(S)";
            KryptonMessageBox.Show(@"Para registrar detalle de VACACONES utlize la opción correspondiente del sistema!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validaciones.IsNumeroEntero(e.KeyChar);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (listView2.Items.Count == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var fec = DateTime.Now;
           
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "PERMISOS";

                var l = -1;
                for (var i = 0; i <= listView2.Columns.Count - 1; i++) if (i == 1 || listView2.Columns[i].Width > 1) l++;
                var ic = ValidationForms.NumToCharExcel(l);

                var rc = listView2.Items.Count + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - PERMISOS";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = cbxFiltro.Text + " DEL " + dtpFechaDesde.Value.ToShortDateString() + " AL " + dtpFechaHasta.Value.ToShortDateString() + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;
                var x = 1;
                for (var i = 0; i <= listView2.Columns.Count - 1; i++)
                {
                    if (i != 1 && listView2.Columns[i].Width < 1) continue;

                    //if (i == 3 || i == 5 || i == 6)
                    //    worksheet.Cells[head, x] =Convert.ToDateTime(listView2.Columns[i].Text);
                    //else
                    worksheet.Cells[head, x] = listView2.Columns[i].Text;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (ListViewItem row in listView2.Items)
                {
                    var y = 1;
                    for (var j = 0; j <= listView2.Columns.Count - 1; j++)
                    {
                        if (j != 1 && listView2.Columns[j].Width < 1) continue;

                        if (j == 3 || j == 5 || j == 6)
                            worksheet.Cells[head, y] = Convert.ToDateTime(row.SubItems[j].Text);
                        else
                            worksheet.Cells[head, y] = row.SubItems[j].Text;

                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                        y++;
                    }

                    head++;
                }

                head += 3;

                worksheet.Range["A" + head + ":F" + head].Merge();
                worksheet.Range["A" + head + ":F" + head].Value = Label1.Text;
                worksheet.Range["A" + head + ":F" + head].Font.Bold = true;
                worksheet.Range["A" + head + ":F" + head].Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                worksheet.Range["A" + head + ":F" + head].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A" + head + ":F" + head].Font.Color = Color.White;
                worksheet.Range["A" + head + ":F" + head].Font.Size = 12;


                var position = (Range)worksheet.Cells[2, 7];
                Clipboard.SetImage(ValidationForms.Logo(TipoCon));
                worksheet.Paste(position);

                worksheet.Range["A1:" + ic + rc].Columns.AutoFit();
                app.DisplayAlerts = false;
                app.Visible = true;
                app.DisplayAlerts = true;
                //workbook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                KryptonMessageBox.Show(@"ARCHIVO generado correctamente!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            CargarAsignaciones(txtFiltro.Text.Trim(), 0);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            
            if (listView2.SelectedItems.Count == 0) return;
            
            ListViewItem data = listView2.SelectedItems[0];
            
            if (KryptonMessageBox.Show(@"El registro seleccionado corresponde a la solicitud n° " + data.SubItems[0].Text.ToString() + @" de permisos. Desea IMPRIMIR la solicitud correspondiente?",
                   "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
               DialogResult.Yes) return;
            if (data == null) return;
            
            try
            {
                var ds = new dsPermisos();
                
                
                

                foreach (ListViewItem item in listView2.Items)
                {

                    //int idsancion = Convert.ToInt32(item.SubItems[2].Text);
                    //string tipoSancion = _objRegistroPermisoPersonal.BuscarSancion(TipoCon, idsancion);  
                    
                    ds.Tables["dtregistroPermisoPersonal"].Rows.Add(
                        
                        Convert.ToInt32(item.SubItems[2].Text),
                        Convert.ToDateTime(item.SubItems[5].Text).ToShortDateString(),
                        Convert.ToDateTime(item.SubItems[6].Text).ToShortDateString(),
                        item.SubItems[10].Text,
                        item.SubItems[13].Text
                        );
                }




                var row = listView2.SelectedItems[0];
                string empre = Validaciones.NombreCompany(TipoCon);
                var rpt = new rptSolicitudPermisoMedico();
                var fecha = dtpFecha.Value.ToShortDateString();

                rpt.SetDataSource(ds.Tables["dtregistroPermisoPersonal"]);
                rpt.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, System.Windows.Forms.Application.StartupPath));
                rpt.SetParameterValue("empre", empre);
                rpt.SetParameterValue("idsoli", row.SubItems[0].Text);
                rpt.SetParameterValue("tiposancion", row.SubItems[1].Text);
                rpt.SetParameterValue("nombre", row.SubItems[4].Text);
                rpt.SetParameterValue("revisado", TipoCon == TipoConexion.Cisepro ? "Isabel Herrera Rodriguez" : "Ing. Magdalena Chato N.");
                rpt.SetParameterValue("aprobado", TipoCon == TipoConexion.Cisepro ? "Ing. Marjorie Loor P." : "Ing. José Navarrete M.");
                rpt.SetParameterValue("fecha", fecha);
                rpt.SetParameterValue("cargo", row.SubItems[8].Text);
                rpt.SetParameterValue("puesto", row.SubItems[12].Text);
                rpt.SetParameterValue("realizado", Usuario.Datos.ToString());
                rpt.SetParameterValue("ndoc", row.SubItems[13].Equals("0") ? "S/N" : row.SubItems[13].Text);
                rpt.SetParameterValue("desde", row.SubItems[5].Text);
                rpt.SetParameterValue("hasta", row.SubItems[6].Text);
                rpt.SetParameterValue("observacion", row.SubItems[10].Text);



                var view = new FrmVisualizadorReportes { TipoCon = TipoCon, Titulo = "SOLICITUD PERMISOS", crystalReportViewer1 = { ReportSource = rpt } };
                view.ShowDialog();
                view.Dispose();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(@"Error al generar solicitud. Por favor, contácte al administrador!",
                    "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }

            //try
            //{
            //    if (dgvPersonal.CurrentRow == null) return;


            //    var row = dgvPersonal.CurrentRow;

            //    string empre = Validaciones.NombreCompany(TipoCon);

            //    object idSolicitudValue = row.Cells["ID_SALIDA"].Value;

            //    if (idSolicitudValue != null)
            //    {
            //        _rptSalidaPersonal.SetParameterValue("idsolicitud", idSolicitudValue);
            //    }
            //    else
            //    {

            //        _rptSalidaPersonal.SetParameterValue("idsolicitud", DBNull.Value);
            //    }

            //    _rptSalidaPersonal.SetParameterValue("empre", empre);
            //    _rptSalidaPersonal.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, System.Windows.Forms.Application.StartupPath));
            //    _rptSalidaPersonal.SetParameterValue("fecha", Convert.ToDateTime(DateTime.Now).ToShortDateString());
            //    _rptSalidaPersonal.SetParameterValue("nombre", row.Cells["NOMBRES"].Value + " " + row.Cells["APELLIDOS"].Value);
            //    if (Convert.ToInt32(row.Cells["ID_SALIDA"].Value) == 0) _rptSalidaPersonal.SetParameterValue("idsolicitud", "SIN NUM");
            //    else _rptSalidaPersonal.SetParameterValue("idsolicitud", row.Cells["ID_SALIDA"].Value);
            //    _rptSalidaPersonal.SetParameterValue("cedula", row.Cells["CEDULA"].Value);
            //    _rptSalidaPersonal.SetParameterValue("cargo", row.Cells["NOMBRE_AREA"].Value);
            //    _rptSalidaPersonal.SetParameterValue("puesto", row.Cells["CARGO"].Value);
            //    _rptSalidaPersonal.SetParameterValue("ingreso", Convert.ToDateTime(row.Cells["INGRESO"].Value));
            //    if (chkbxFichaMedica.Checked) _rptSalidaPersonal.SetParameterValue("certificado", "X");
            //    else _rptSalidaPersonal.SetParameterValue("certificado", "");
            //    if (chkbxUniformes.Checked) _rptSalidaPersonal.SetParameterValue("uniformes", "X");
            //    else _rptSalidaPersonal.SetParameterValue("uniformes", "");
            //    if (chkbxRoles.Checked) _rptSalidaPersonal.SetParameterValue("roles", "X");
            //    else _rptSalidaPersonal.SetParameterValue("roles", "");
            //    if (chkbxCredencial.Checked) _rptSalidaPersonal.SetParameterValue("credencial", "X");
            //    else _rptSalidaPersonal.SetParameterValue("credencial", "");
            //    crvSalida.ReportSource = _rptSalidaPersonal;
            //    crvSalida.Zoom(2);
            //    crvSalida.Refresh();


            //}
            //catch (Exception)
            //{
            //    KryptonMessageBox.Show(@"Error al generar solicitud. Por favor, contácte al administrador!",
            //        "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            //}



        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
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

                try
                {
                    var data = _objPersonal.SeleccionarTodosRegistrosPersonalFiltroFull(TipoCon, _frmBuscarPersonal.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    dateTimePicker1.Text = data.Rows[0]["FECHA_NACIMIENTO"].ToString();
                    textBox1.Text = data.Rows[0]["EDAD"].ToString();
                }
                catch
                {
                    dateTimePicker1.Value = DateTime.MinValue;
                    textBox1.Text = @"0";
                }

                var sit = _objSitiosTrabajo.BuscarUltimoPuestoPorIdPersonal(TipoCon, Convert.ToInt32(txtIdPersonal.Text.Trim()), admin);
                if (sit.Rows.Count == 0) return;
                if (admin)
                {
                    txtSitio.Tag = sit.Rows[0][0].ToString();
                    txtSitio.Text = sit.Rows[0][6] + @" (" + sit.Rows[0][20] + @")";
                }
                else
                {
                    txtSitio.Tag = sit.Rows[0][2].ToString();
                    txtSitio.Text = sit.Rows[0][15] + @" (" + sit.Rows[0][29] + @")";
                }
            }
            catch
            {
                txtPersonal.Text = @"NO DEFINIDO";
                txtIdPersonal.Clear();
                txtCargo.Clear();
                txtArea.Clear();
            }
        }

        private void btnBuscarPuesto_Click(object sender, EventArgs e)
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

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
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

                try
                {
                    var data = _objPersonal.SeleccionarTodosRegistrosPersonalFiltroFull(TipoCon, _frmBuscarPersonal.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    dateTimePicker1.Text = data.Rows[0]["FECHA_NACIMIENTO"].ToString();
                    textBox1.Text = data.Rows[0]["EDAD"].ToString();
                }
                catch
                {
                    dateTimePicker1.Value = DateTime.MinValue;
                    textBox1.Text = @"0";
                }

                var sit = _objSitiosTrabajo.BuscarUltimoPuestoPorIdPersonal(TipoCon, Convert.ToInt32(txtIdPersonal.Text.Trim()), admin);
                if (sit.Rows.Count == 0) return;
                if (admin)
                {
                    txtSitio.Tag = sit.Rows[0][0].ToString();
                    txtSitio.Text = sit.Rows[0][6] + @" (" + sit.Rows[0][20] + @")";
                }
                else
                {
                    txtSitio.Tag = sit.Rows[0][2].ToString();
                    txtSitio.Text = sit.Rows[0][15] + @" (" + sit.Rows[0][29] + @")";
                }
            }
            catch
            {
                txtPersonal.Text = @"NO DEFINIDO";
                txtIdPersonal.Clear();
                txtCargo.Clear();
                txtArea.Clear();
            }
        }

        private void kryptonButton2_Click_1(object sender, EventArgs e)
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

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Path = openFileDialog1.FileName;
                txtCertificado.Text = Path;
                _cm = File.ReadAllBytes(Path);
            }
        }

        private void btnCertificado_Click(object sender, EventArgs e)
        {
            try
            {
              var id = listView2.SelectedItems[0].SubItems[0].Text;

                var data = _objRegistroPermisoPersonal.BuscarIdRegistroPermiso(TipoCon, Convert.ToInt32(id));
                if (data.Rows.Count == 0)
                {
                    KryptonMessageBox.Show(@"NO SE ENCUENTRA CERTIFICADO PARA EL REGISTRO SELECCIONADO!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    return;
                }

                var cm = (byte[])data.Rows[0][0];
                //string temp = Path.Combine(Path.GetTempPath(), "Temp.pdf");
                //File.WriteAllBytes(temp, cm);
               
                _ms?.Dispose();
                _ms = new MemoryStream(cm);
                pdfViewer1.Document = PdfiumViewer.PdfDocument.Load(_ms);


                //pdfViewer1.Load(stream);



            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(@"Error al buscar certificado " + ex.Message, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void FrmPermisos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ms?.Dispose();
            _ms = null;
        }
    }
}


