using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.Operaciones;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using ClassLibraryCisepro3.ProcesosSql;
using SysCisepro3.Main;
using Microsoft.Office.Interop.Excel;
using Krypton.Toolkit;

using DataTable = System.Data.DataTable;
using Font = System.Drawing.Font;

using Office = Microsoft.Office.Interop;
using System.IO;
using ClassLibraryCisepro3.DivisionGeografica;
using SysCisepro3.Datos;
using SysCisepro3.Operaciones;
using SysCisepro3.Properties;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.EstructuraEmpresa;
using SysCisepro3.Reportes;
using CrystalDecisions.CrystalReports.Engine;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmRolPago : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para realizar y verificar el rol de pagos correspondiente a cada caso (ADMIN [1-30] - OPER [26-25(1-30)])
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmRolPago _instance;
        public static FrmRolPago Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmRolPago();
                return _instance;
            }
        }

        private readonly ClassSitiosTrabajo _objetoSitio;
        private readonly ClassRolPago _objRolPago;
        private ClassParametrosRol _objRolParametrosRolPago;
        private readonly ClassDetallesRol _objDetaRolPago;
        private readonly ClassContratos _objContratos;
        private readonly ClassBancos _objBancos;
        private readonly ClassAsignacionPersonal _objAsignacionPersonal;

        private int _estado;
        private readonly List<SqlCommand> _sqlCommands;

        private int _diasTrabajados;
        private double _sueldoDiasTrabajados;
        private int _diasDescansoMedico;
        private double _sueldoDescansoMedico;
        private double _sueldoDiasTrabajadoDescansoMedico;
        private double _totalHoras;
        private double _totalHoras50;
        private double _totalHoras100;
        private double _totalHorasFeriado100;
        private double _recargoNocturno;
        private double _adicional;
        private double _otrosIngresos;
        private double _totalExtras;
        private double _sueldoMasExtras;
        
        private double _xiii;
        private double _xiiiPorPension;
        private double _xiv;
        private double _xivPorPension;
         
        private double _descDiferenciaDecimoFondo;

        private double _fordoReserva;
        private double _fordoReservaMesAnte;
        private double _totalBeneficios;
        private double _totalIngresos;

        private double _descuentoIess;
        private double _quincenaAnticipo;
        private double _prestamoQuirografario;
        private double _prestamoHipotecario;
        private double _extensionSalud;
        private double _anticipoEmergente;
        private double _descuentoCapaseg;
        private double _anticiposVarios;
        private double _prestamoEmpresa;
        private double _descuenoComecsaFarm;
        private double _descuentoComisariato;
        private double _descuentoEquipoSeguridad;
        private double _descuentoAlmuerszos;
        private double _descuentoPensionAlimento;
        private double _descuento10moPensionAlimento;
        private double _multasYAtrasos;
        private double _descdiasnolaborados;
        private double _otrosDescuentos;
        private double _totalDescuentos;
        private double _netorecibir;
        private double _acumfonres;

        private int _cantRol;

        private readonly List<int> _indices;
        private FrmBuscarPuestoTrabajo _frmBuscarPuestoTrabajo;
        private FrmAgregarPersonalRolPago _frmAgregarPersonalRol;
        private FrmDetalleAsistenciaRol _frmDetealleAsistenciaRol;
        private List<string> _sitiosNoDiferenciaDecimosExtra;

        private readonly rptPlanillaPagoBasicoTodos _rptPlanilla;
         
        private FrmRolPago()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();
            _indices = new List<int>();

            _objetoSitio = new ClassSitiosTrabajo();
            _objAsignacionPersonal = new ClassAsignacionPersonal();
            _objBancos = new ClassBancos();

            _objRolParametrosRolPago = new ClassParametrosRol();
            _objRolPago = new ClassRolPago();
            _objDetaRolPago = new ClassDetallesRol();
            _objContratos = new ClassContratos();
            _sitiosNoDiferenciaDecimosExtra = new List<string>();
            _rptPlanilla = new rptPlanillaPagoBasicoTodos();
        }

        private void FrmRolPago_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            toolStripLabel1.ForeColor = Color.White;
            lblIdRol.ForeColor = Color.White;
            Label14.BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label14.ForeColor = Color.White;
            dgvDetallesRol.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvInformePago.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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

            dtpFechaElaborado.Value = Usuario.Now(TipoCon);

            cbxQuincena.SelectedIndex = 0;
            cbxTipo.SelectedIndex = 0;

            cbxQuincena.Enabled = false;
            cbxTipo.Enabled = false;
            

            btnAnt.Tag = 0;
            btnSig.Tag = 0;
            btnResumen.Tag = null;

            _cuentas = new List<string>();
            dgvDetallesRol.Font = new Font("Roboto", 8, FontStyle.Regular);
            dgvInformePago.Font = new Font("Roboto", 8, FontStyle.Regular);
            metroTabControl1.SelectedTab = metroTabPage1;

            //Image orginalBcoPichicha = Resources.banco_pichincha_logo;
            //Image resizeBcoPichincha = new Bitmap(orginalBcoPichicha, new Size(btnBizPichincha.Width, btnBizPichincha.Height));
            //btnBizPichincha.Image = resizeBcoPichincha;
            //btnBizPichincha.ImageAlign = ContentAlignment.MiddleCenter;
            metroTabControl1.BackgroundColor = Color.FromArgb(239, 246, 253);
            metroTabPage1.BaseColor = Color.FromArgb(239, 246, 253);
            metroTabPage2.BaseColor = Color.FromArgb(239, 246, 253);
            metroTabPage3.BaseColor = Color.FromArgb(239, 246, 253);
            ComboColumnas(); 
        }

        private void ComboColumnas()
        {
            foreach (DataGridViewColumn col in dgvDetallesRol.Columns)
            {
                if (col.Index < 13 || col.Index == 42 || col.Index == 43 || col.Index > 64) continue;
                var item = new ToolStripButton
                {
                    Text = col.HeaderText.Trim(),
                    Tag = col.Name,
                    CheckOnClick = true,
                    Checked = true,
                    Image = Resources.visible_icon
                };
                item.CheckedChanged += item_CheckedChanged;
                if (col.Index < 43) colIngresos.DropDownItems.Add(item); // INGRESOS
                else colEgresos.DropDownItems.Add(item); // EGRESOS
            }
        }

        private void item_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (ToolStripButton)sender;
            var col = dgvDetallesRol.Columns[cb.Tag.ToString()];
            if (col == null) return;
            col.Visible = cb.Checked;
            cb.Image = cb.Checked ? Resources.visible_icon : Resources.invisible_icon;
        }

        private void Habilitar(bool enable)
        {
            dtpMesAnio.Enabled = enable;
            cbxTipo.Enabled = enable;
            cbxQuincena.Enabled = enable;
            btnCargarPersonal.Enabled = enable;
            txtObservacion.Enabled = enable;
            dtpDesde.Enabled = enable;
            dtpHasta.Enabled = enable;

            btnCargarPersonal.Enabled = enable;
            btnDatos.Enabled = enable;
            btnParams.Enabled = enable;
            btnDescuentos.Enabled = enable;
            btnAgregar.Enabled = enable;
            btnQuitar.Enabled = enable;
            btnCambiar.Enabled = enable;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmBuscarRolPago { TipoCon = TipoCon, Usuario = Usuario };
                if (frm.ShowDialog() != DialogResult.OK) return;
                if (frm.dgvRoles.CurrentRow == null) return;

                Habilitar(false);

                lblIdRol.Text = frm.dgvRoles.CurrentRow.Cells[0].Value.ToString();
                dtpFechaElaborado.Value = Convert.ToDateTime(frm.dgvRoles.CurrentRow.Cells[1].Value);
                dtpMesAnio.Value = new DateTime(Convert.ToInt32(frm.dgvRoles.CurrentRow.Cells[4].Value), Convert.ToInt32(frm.dgvRoles.CurrentRow.Cells[2].Value), 1);
                cbxQuincena.SelectedIndex = Convert.ToInt32(frm.dgvRoles.CurrentRow.Cells[5].Value);
                cbxTipo.SelectedIndex = frm.dgvRoles.CurrentRow.Cells[6].Value.ToString().Equals("ADMINISTRATIVO") ? 1 : 0;

                dtpDesde.Value = Convert.ToDateTime(frm.dgvRoles.CurrentRow.Cells[8].Value);
                dtpHasta.Value = Convert.ToDateTime(frm.dgvRoles.CurrentRow.Cells[9].Value);
                txtObservacion.Text = frm.dgvRoles.CurrentRow.Cells[13].Value.ToString();
                lblEstado.Text = frm.dgvRoles.CurrentRow.Cells[12].Value.ToString();
                btnResumen.Tag = frm.dgvRoles.CurrentRow.Cells[15].Value; // retenidos

                cbxGrupo.Text = frm.dgvRoles.CurrentRow.Cells[16].Value.ToString();

                if (frm.dgvRoles.CurrentRow.Cells[6].Value.ToString().Equals("ADMINISTRATIVO")) dgvDetallesRol.Columns["colDiasNoLaborados"].HeaderText = "DESC. SEG. PRIV";
                else dgvDetallesRol.Columns["colDiasNoLaborados"].HeaderText = "DIAS NO LABOR.";

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;

                btnActualizar.Enabled = Convert.ToInt32(frm.dgvRoles.CurrentRow.Cells[11].Value) == 1;

                btnBuscar.Enabled = true;
                btnCancelar.Enabled = false;

                btnAnular.Enabled = Convert.ToInt32(frm.dgvRoles.CurrentRow.Cells[11].Value) == 1;

                btnValidar.Enabled = Convert.ToInt32(frm.dgvRoles.CurrentRow.Cells[11].Value) == 1;

                _estado = 0;

                dgvDetallesRol.Rows.Clear();
                dgvInformePago.Rows.Clear();

                CargarDetallesRol(Convert.ToInt32(lblIdRol.Text));

                if (Convert.ToInt32(frm.dgvRoles.CurrentRow.Cells[11].Value) == 2)
                    KryptonMessageBox.Show("El ROL DE PAGO seleccionado ya está VALIDADO, no se puede realizar cambios sobre el mismo!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                btnResumen.Enabled = true;
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(@"Ocurrió un problema al seleccionar el ROL DE PAGO! Por favor, contácte al administrador", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void CargarDetallesRol(int idRol)
        {
            try
            {
                _objRolParametrosRolPago = _objRolParametrosRolPago.SeleccionarParametrosRolesByIdRol(TipoCon, idRol);

                if ((_estado == 0))
                {
                    var ret = _objRolPago.SeleccionarPersonalRetenidosRolPago(TipoCon, idRol);
                    if (ret.Rows.Count > 0) btnResumen.Tag = ret.Rows[0][0].ToString();
                }

                

                var data = _objDetaRolPago.SeleccionarDatosRolPago(TipoCon, idRol);
                if (data.Rows.Count == 0) return;

                dgvDetallesRol.Rows.Clear();

                //if (Usuario.TipoUsuario.Equals("ADMINISTRADOR"))
                //{
                //    dgvDetallesRol.Columns["extedit"].Visible = true;
                //}

                if (dgvDetallesRol.Columns["Column6"] != null) dgvDetallesRol.Columns["Column6"].DefaultCellStyle.Format = "d";
                if (dgvDetallesRol.Columns["Column9"] != null) dgvDetallesRol.Columns["Column9"].DefaultCellStyle.Format = "d";

                var ing = 0.0;
                var des = 0.0;
                var tot = 0.0;

                var afra = 0.0;
                var afro = 0.0;

                foreach (DataRow row in data.Rows)
                {
                    if ((row[1] + "").Trim().Equals("0") && (row[2] + "").Trim().Equals("0"))
                    {
                        if ((row[3] + "").Trim().Equals("TOTAL GRUPO " + row[0]))
                        {
                            dgvDetallesRol.Rows.Add(
                                row[0], null, null, row[3], null, null, null, null, null, null, null, null, 
                                Convert.ToDouble(row[10]).ToString("N"),
                                row[11], Convert.ToDouble(row[12]).ToString("N"), // sueldo normal
                                row[13], Convert.ToDouble(row[14]).ToString("N"), // sueldo descanso medico
                                Convert.ToDouble(row[15]).ToString("N"), // sueldo normal - descanso medico

                                Convert.ToDouble(row[16]).ToString("N"), Convert.ToDouble(row[17]).ToString("N"), Convert.ToDouble(row[18]).ToString("N"), // hor
                                Convert.ToDouble(row[19]).ToString("N"), Convert.ToDouble(row[20]).ToString("N"), Convert.ToDouble(row[21]).ToString("N"), // hor50
                                Convert.ToDouble(row[22]).ToString("N"), Convert.ToDouble(row[23]).ToString("N"), Convert.ToDouble(row[24]).ToString("N"), // hor100
                                Convert.ToDouble(row[25]).ToString("N"), Convert.ToDouble(row[26]).ToString("N"), Convert.ToDouble(row[27]).ToString("N"), // horext

                                Convert.ToDouble(row[28]).ToString("N"), Convert.ToDouble(row[29]).ToString("N"), Convert.ToDouble(row[30]).ToString("N"), // rec noc, adic, oting
                                Convert.ToDouble(row[31]).ToString("N"), Convert.ToDouble(row[32]).ToString("N"), // total ex, sueldo + ext
                                Convert.ToDouble(row[33]).ToString("N"), Convert.ToDouble(row[34]).ToString("N"), // xiii pens
                                Convert.ToDouble(row[35]).ToString("N"), Convert.ToDouble(row[36]).ToString("N"), // xiv pens
                                Convert.ToDouble(row[37]).ToString("N"), Convert.ToDouble(row[38]).ToString("N"), // fon res, res ant
                                Convert.ToDouble(row[39]).ToString("N"), Convert.ToDouble(row[40]).ToString("N"), // tot benef, toto ingresos

                                string.Empty, 

                                Convert.ToDouble(row[42]).ToString("N"), Convert.ToDouble(row[43]).ToString("N"), Convert.ToDouble(row[44]).ToString("N"), Convert.ToDouble(row[45]).ToString("N"), 
                                Convert.ToDouble(row[46]).ToString("N"), Convert.ToDouble(row[47]).ToString("N"), Convert.ToDouble(row[48]).ToString("N"), Convert.ToDouble(row[49]).ToString("N"),
                                Convert.ToDouble(row[50]).ToString("N"), Convert.ToDouble(row[51]).ToString("N"), Convert.ToDouble(row[52]).ToString("N"), Convert.ToDouble(row[53]).ToString("N"),
                                Convert.ToDouble(row[79]).ToString("N"), // desc almuerzo
                                Convert.ToDouble(row[54]).ToString("N"), Convert.ToDouble(row[55]).ToString("N"), Convert.ToDouble(row[56]).ToString("N"), Convert.ToDouble(row[81]).ToString("N"), // diasnolab
                                Convert.ToDouble(row[82]).ToString("N"), //DIF DECIMOS FONDO RES
                                Convert.ToDouble(row[57]).ToString("N"), // otros descuentos
                                Convert.ToDouble(row[58]).ToString("N"), Convert.ToDouble(row[59]).ToString("N"), Convert.ToDouble(row[60]).ToString("N"), // tot esc, neto, extradmin


                                row[61].ToString().Equals("1"), row[62].ToString().Equals("1"), row[63].ToString().Equals("1"), row[64].ToString().Equals("1"),
                                row[65].ToString().Equals("1"), row[66].ToString().Equals("1"), // checks params

                                row[68].ToString(), row[69].ToString(), row[70].ToString(), row[71].ToString().Trim(), // banco
                                row[72].ToString(), row[78].ToString(), row[80].ToString().Equals("1"), row[83].ToString().Equals("1"));

                            ing += Convert.ToDouble(dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Cells[42].Value);
                            des += Convert.ToDouble(dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Cells[63].Value);
                            tot += Convert.ToDouble(dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Cells[64].Value);

                            if ((row[0].ToString()).Trim().Equals("ADMINISTRATIVO")) afra += Convert.ToDouble(dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Cells[77].Value);
                            else afro += Convert.ToDouble(dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Cells[77].Value);
                        }
                        else dgvDetallesRol.Rows.Add(row[0], null, null, row[3]);
                    }
                    else
                    {
                        dgvDetallesRol.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[76].ToString().Contains("1900") ? string.Empty : row[76], row[77], row[7], row[8], row[9],
                                Convert.ToDouble(row[10]).ToString("N"),
                                row[11], Convert.ToDouble(row[12]).ToString("N"), // sueldo normal
                                row[13], Convert.ToDouble(row[14]).ToString("N"), // sueldo descanso medico
                                Convert.ToDouble(row[15]).ToString("N"), // sueldo normal - descanso medico

                                Convert.ToDouble(row[16]).ToString("N"), Convert.ToDouble(row[17]).ToString("N"), Convert.ToDouble(row[18]).ToString("N"), // hor
                                Convert.ToDouble(row[19]).ToString("N"), Convert.ToDouble(row[20]).ToString("N"), Convert.ToDouble(row[21]).ToString("N"), // hor50
                                Convert.ToDouble(row[22]).ToString("N"), Convert.ToDouble(row[23]).ToString("N"), Convert.ToDouble(row[24]).ToString("N"), // hor100
                                Convert.ToDouble(row[25]).ToString("N"), Convert.ToDouble(row[26]).ToString("N"), Convert.ToDouble(row[27]).ToString("N"), // horext

                                Convert.ToDouble(row[28]).ToString("N"), Convert.ToDouble(row[29]).ToString("N"), Convert.ToDouble(row[30]).ToString("N"),
                                Convert.ToDouble(row[31]).ToString("N"), Convert.ToDouble(row[32]).ToString("N"), // total ex, sueldo + ext
                                Convert.ToDouble(row[33]).ToString("N"), Convert.ToDouble(row[34]).ToString("N"), // xiii pens
                                Convert.ToDouble(row[35]).ToString("N"), Convert.ToDouble(row[36]).ToString("N"), // xiv pens
                                Convert.ToDouble(row[37]).ToString("N"), Convert.ToDouble(row[38]).ToString("N"), // fon res, res ant
                                Convert.ToDouble(row[39]).ToString("N"), Convert.ToDouble(row[40]).ToString("N"), // tot benef, toto ingresos

                                string.Empty,

                                Convert.ToDouble(row[42]).ToString("N"), Convert.ToDouble(row[43]).ToString("N"), Convert.ToDouble(row[44]).ToString("N"), Convert.ToDouble(row[45]).ToString("N"),
                                Convert.ToDouble(row[46]).ToString("N"), Convert.ToDouble(row[47]).ToString("N"), Convert.ToDouble(row[48]).ToString("N"), Convert.ToDouble(row[49]).ToString("N"),
                                Convert.ToDouble(row[50]).ToString("N"), Convert.ToDouble(row[51]).ToString("N"), Convert.ToDouble(row[52]).ToString("N"), Convert.ToDouble(row[53]).ToString("N"),
                                Convert.ToDouble(row[79]).ToString("N"), // desc almuerzo
                                Convert.ToDouble(row[54]).ToString("N"), Convert.ToDouble(row[55]).ToString("N"), Convert.ToDouble(row[56]).ToString("N"), Convert.ToDouble(row[81]).ToString("N"),  // diasnolab
                                Convert.ToDouble(row[82]).ToString("N"), //DIF DECIMOS FONDO RES
                                Convert.ToDouble(row[57]).ToString("N"), // otros descuentos
                                Convert.ToDouble(row[58]).ToString("N"), Convert.ToDouble(row[59]).ToString("N"), Convert.ToDouble(row[60]).ToString("N"), // tot esc, neto, extradmin

                                row[61].ToString().Equals("1"), row[62].ToString().Equals("1"), row[63].ToString().Equals("1"), row[64].ToString().Equals("1"),
                                row[65].ToString().Equals("1"), row[66].ToString().Equals("1"), // checks params
                                row[68].ToString(), row[69].ToString(), row[70].ToString(), row[71].ToString().Trim(), // banco
                                row[72].ToString(), row[78].ToString(), row[80].ToString().Equals("1"), row[83].ToString().Equals("1"));                        
                    }

                    if ((row[75] + "").Equals("1"))
                    {
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = Color.Black;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.ForeColor = Color.White;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 1;
                    }
                    if ((row[75] + "").Equals("2"))
                    {
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 2;
                    }
                    if ((row[75] + "").Equals("3"))
                    {
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = SystemColors.Control;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 3;
                    }

                    if ((Convert.ToInt32(row[1]) > 0) && row[72].ToString().Equals("0")) dgvDetallesRol.Rows[dgvDetallesRol.RowCount - 1].DefaultCellStyle.BackColor = Color.LightSalmon;
                }

                txtTotIngresos.Text = ing.ToString("N");
                txtTotDescuentos.Text = des.ToString("N");
                txtTotCobrar.Text = tot.ToString("N");

                txtAcfoAd.Text = afra.ToString("N");
                txtAcfoOp.Text = afro.ToString("N");
                txtAcfonRes.Text = (afra + afro).ToString("N");

                dgvDetallesRol.AutoResizeRows();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(@"Ocurrió un problema al cargar los detalles del ROL DE PAGO! Por favor, contácte al administrador", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void dgvDetallesRol_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblIdRol.Text = @"###";
            lblEstado.Text = @"EN PROCESO";

            dtpFechaElaborado.Value = Usuario.Now(TipoCon);

            dtpMesAnio.Value = new DateTime(dtpFechaElaborado.Value.Year, dtpFechaElaborado.Value.Month, 1);

            dtpDesde.Value = new DateTime(dtpFechaElaborado.Value.Year, dtpFechaElaborado.Value.Month, 1);
            dtpHasta.Value = new DateTime(dtpFechaElaborado.Value.Year, dtpFechaElaborado.Value.Month, 1);

            txtObservacion.Clear();

            txtTotIngresos.Text = 0.ToString("N");
            txtTotDescuentos.Text = 0.ToString("N");
            txtTotCobrar.Text = 0.ToString("N");

            txtAcfoAd.Text = 0.ToString("N");
            txtAcfoOp.Text = 0.ToString("N");
            txtAcfonRes.Text = 0.ToString("N");

            Habilitar(true);

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnBuscar.Enabled = false;
            btnCancelar.Enabled = true;
            btnAnular.Enabled = false;
            btnValidar.Enabled = false;
            btnResumen.Tag = null;
            btnResumen.Enabled = false;
            btnRetener.Enabled = false;

            dgvDetallesRol.Rows.Clear();


            var data = _objetoSitio.SeleccionarGruposSitiosAplicaDescuentoDiferencia(TipoCon);
            _sitiosNoDiferenciaDecimosExtra.Clear();
            _sitiosNoDiferenciaDecimosExtra.Add("ADMINISTRATIVO");
            foreach (DataRow sitio in data.Rows) _sitiosNoDiferenciaDecimosExtra.Add(sitio[0].ToString().Trim());

            cbxQuincena.SelectedIndex = 0;
            cbxTipo_SelectedIndexChanged(null, null);
            _estado = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvDetallesRol.RowCount == 0)
            {
                KryptonMessageBox.Show(@"No se generó ningún detalle en el ROL DE PAGO del período seleccionado!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            if (KryptonMessageBox.Show(@"Desea guardar los cambios realizados?",
                    "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
                DialogResult.Yes) return;

            if (cbxQuincena.SelectedIndex == 1 && cbxTipo.SelectedIndex == 0 && cbxGrupo.Text.Trim().Length == 0)
            {
                KryptonMessageBox.Show(@"Por favor, seleccione el grupo al que desea general rol de pago!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            if (lblEstado.Text.Equals("VALIDADO"))
            {
                KryptonMessageBox.Show(@"El ROL DE PAGO seleccionado ya está VALIDADO, no se puede realizar cambios sobre el mismo!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            var fechaDesde = dtpDesde.Value.Day + "-" + dtpDesde.Value.Month + "-" + dtpDesde.Value.Year + " 00:00:00";
            var fechaHasta = dtpHasta.Value.Day + "-" + dtpHasta.Value.Month + "-" + dtpHasta.Value.Year + " 23:59:59";

            _sqlCommands.Clear();

            if (_estado == 1)
            {
                _objRolPago.IdRol = _objRolPago.BuscarMayorIdRolPago(TipoCon) + 1;
                _objRolPago.FechaElaboracion = dtpFechaElaborado.Value;
                _objRolPago.Mes = dtpMesAnio.Value.Month;
                _objRolPago.Anio = dtpMesAnio.Value.Year;
                _objRolPago.Quincena = cbxQuincena.SelectedIndex;
                _objRolPago.Desde = Convert.ToDateTime(fechaDesde);
                _objRolPago.Hasta = Convert.ToDateTime(fechaHasta);
                _objRolPago.Estado = 1;
                _objRolPago.Observacion = txtObservacion.Text.Trim();
                _objRolPago.FechaValidacion = new DateTime(1900, 1, 1, 0, 0, 0);
                _objRolPago.Tipo = cbxTipo.SelectedIndex;
                _objRolPago.CantFil = dgvDetallesRol.RowCount;

                // parametros de ese rol
                _objRolPago.SueldoVigilantes = _objRolParametrosRolPago.SueldoVigilantes;
                _objRolPago.CostoHorasNoral = _objRolParametrosRolPago.CostoHorasNoral;
                _objRolPago.CostoHoras50 = _objRolParametrosRolPago.CostoHoras50;
                _objRolPago.CostoHoras100 = _objRolParametrosRolPago.CostoHoras100;
                _objRolPago.PorcentajePatronalIess = _objRolParametrosRolPago.PorcentajePatronalIess;
                _objRolPago.PorcentajePersonalIess = _objRolParametrosRolPago.PorcentajePersonalIess;
                _objRolPago.PorcentajeFondoReserva = _objRolParametrosRolPago.PorcentajeFondoReserva;
                _objRolPago.SueldoBasico = _objRolParametrosRolPago.SueldoBasico;
                _objRolPago.OtrosDescuentosOperativos = _objRolParametrosRolPago.OtrosDescuentosOperativos;
                _objRolPago.OtrosDescuentosAdmin = _objRolParametrosRolPago.OtrosDescuentosAdmin;
                _objRolPago.AnticipoUtilidad = _objRolParametrosRolPago.AnticipoUtilidad;
                _objRolPago.AnticipoGuardias = _objRolParametrosRolPago.AnticipoGuardias;
                _objRolPago.QuinceAdminEsSueldoMasExtra = _objRolParametrosRolPago.QuinceAdminEsSueldoMasExtra;
                _objRolPago.Grupo = cbxTipo.SelectedIndex == 1 ? cbxTipo.Text : cbxGrupo.Text.Trim();
                _objRolPago.PorcentajeDescansoMedico = _objRolParametrosRolPago.PorcentajeDescansoMedico;
                _objRolPago.PorcentajeExtensionSalud = _objRolParametrosRolPago.PorcentajeExtensionSalud;

                _sqlCommands.Add(_objRolPago.GuardarRolPagoCommand());
            }
            else
            {
                _objRolPago.IdRol = Convert.ToInt32(lblIdRol.Text);
                _objRolPago.Observacion = txtObservacion.Text.Trim();
                _sqlCommands.Add(_objRolPago.ModificarRolPagoCommand(_objRolPago.IdRol));
            }

            // detalles
            _sqlCommands.Add(_objRolPago.DeleteDetallesRolByIdRolPagoCommand(_estado == 1 ? _objRolPago.IdRol : Convert.ToInt32(lblIdRol.Text)));
            var idaux = _objDetaRolPago.BuscarMayorIdDetalleRol(TipoCon) + 1;
            
            foreach (DataGridViewRow row in dgvDetallesRol.Rows)
            {
                //
               // var cellValue = row.Cells[79].Value;

                _objDetaRolPago.Grupo = (row.Cells[0].Value + "");
                _objDetaRolPago.IdPersonal = (row.Cells[1].Value + "").Trim().Length == 0 ? 0 : Convert.ToInt32(row.Cells[1].Value);
                _objDetaRolPago.Num = (row.Cells[2].Value + "").Trim().Length == 0 ? 0 : Convert.ToInt32(row.Cells[2].Value);
                _objDetaRolPago.Cliente = (row.Cells[3].Value + "");
                _objDetaRolPago.Ubicacion = (row.Cells[4].Value + "");
                _objDetaRolPago.Nomina = (row.Cells[5].Value + "");
                _objDetaRolPago.Cedula = (row.Cells[6].Value + "");
                _objDetaRolPago.FechaNacim = (row.Cells[7].Value + "").Trim().Length == 0 ? new DateTime(1990, 1, 1) : Convert.ToDateTime(row.Cells[7].Value);
                _objDetaRolPago.Ciudad = (row.Cells[8].Value + "");
                _objDetaRolPago.Ingreso = (row.Cells[9].Value + "").Trim().Length == 0 ? new DateTime(1990, 1, 1) : Convert.ToDateTime(row.Cells[9].Value);
                _objDetaRolPago.Cargo = (row.Cells[10].Value + "");
                _objDetaRolPago.Area = (row.Cells[11].Value + "");
                _objDetaRolPago.SueldoBase = (row.Cells[12].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[12].Value + "");
                _objDetaRolPago.DiasTrabaja = (row.Cells[13].Value + "").Trim().Length == 0 ? 0 : Convert.ToInt32(row.Cells[13].Value + "");
                _objDetaRolPago.SueldoDiasTrabaja = (row.Cells[14].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[14].Value + "");
                _objDetaRolPago.DiasDescansoMedico = (row.Cells[15].Value + "").Trim().Length == 0 ? 0 : Convert.ToInt32(row.Cells[15].Value + "");
                _objDetaRolPago.SueldoDescansoMedico = (row.Cells[16].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[16].Value + "");
                _objDetaRolPago.SueldoTrabajaMasDesMedico = (row.Cells[17].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[17].Value + "");
                _objDetaRolPago.HorasN = (row.Cells[18].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[18].Value + "");
                _objDetaRolPago.CostoHorasN = (row.Cells[19].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[19].Value + "");
                _objDetaRolPago.TotalHorasN = (row.Cells[20].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[20].Value + "");
                _objDetaRolPago.HorasSup = (row.Cells[21].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[21].Value + "");
                _objDetaRolPago.CostoHorasSup = (row.Cells[22].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[22].Value + "");
                _objDetaRolPago.TotalHorasSup = (row.Cells[23].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[23].Value + "");
                _objDetaRolPago.HorasExt = (row.Cells[24].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[24].Value + "");
                _objDetaRolPago.CostoHorasExt = (row.Cells[25].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[25].Value + "");
                _objDetaRolPago.TotalHorasExt = (row.Cells[26].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[26].Value + "");
                _objDetaRolPago.HorasExtf = (row.Cells[27].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[27].Value + "");
                _objDetaRolPago.CostoHorasExtf = (row.Cells[28].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[28].Value + "");
                _objDetaRolPago.TotalHorasExtf = (row.Cells[29].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[29].Value + "");
                _objDetaRolPago.RecargoNocturno = (row.Cells[30].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[30].Value + "");
                _objDetaRolPago.Adicional = (row.Cells[31].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[31].Value + "");
                _objDetaRolPago.OtroIngreos = (row.Cells[32].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[32].Value + "");
                _objDetaRolPago.TotalExt = (row.Cells[33].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[33].Value + "");
                _objDetaRolPago.IngresosMasExt = (row.Cells[34].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[34].Value + "");
                _objDetaRolPago.Xiii = (row.Cells[35].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[35].Value + "");
                _objDetaRolPago.XiiiPension = (row.Cells[36].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[36].Value + "");
                _objDetaRolPago.Xiv = (row.Cells[37].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[37].Value + "");
                _objDetaRolPago.XivPension = (row.Cells[38].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[38].Value + "");
                _objDetaRolPago.FondoRes = (row.Cells[39].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[39].Value + "");
                _objDetaRolPago.FondoResMesant = (row.Cells[40].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[40].Value + "");
                _objDetaRolPago.TotBenef = (row.Cells[41].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[41].Value + "");
                _objDetaRolPago.TotIngresos = (row.Cells[42].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[42].Value + "");
                // ESPACIO indice 43 en grid
                _objDetaRolPago.DescIess = (row.Cells[44].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[44].Value + "");
                _objDetaRolPago.DescQuiAnt = (row.Cells[45].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[45].Value + "");
                _objDetaRolPago.DescQuiro = (row.Cells[46].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[46].Value + "");
                _objDetaRolPago.DescHipot = (row.Cells[47].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[47].Value + "");
                _objDetaRolPago.DescExtSalCon = (row.Cells[48].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[48].Value + "");
                _objDetaRolPago.DescAntEme = (row.Cells[49].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[49].Value + "");
                _objDetaRolPago.DescCapaSeg = (row.Cells[50].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[50].Value + "");
                _objDetaRolPago.DescAntVar = (row.Cells[51].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[51].Value + "");
                _objDetaRolPago.DescPresEmp = (row.Cells[52].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[52].Value + "");
                _objDetaRolPago.DescComec = (row.Cells[53].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[53].Value + "");
                _objDetaRolPago.DescComis = (row.Cells[54].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[54].Value + "");
                _objDetaRolPago.DesEquipoSegu = (row.Cells[55].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[55].Value + "");
                _objDetaRolPago.DesAlmuerzo = (row.Cells[56].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[56].Value + "");
                _objDetaRolPago.Des10moPension = (row.Cells[57].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[57].Value + "");
                _objDetaRolPago.DesPensionAlim = (row.Cells[58].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[58].Value + "");
                _objDetaRolPago.DesMulta = (row.Cells[59].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[59].Value + "");
                _objDetaRolPago.DescDiasNoLaborados = (row.Cells[60].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[60].Value + "");
                _objDetaRolPago.DescDifDecFon = (row.Cells[61].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[61].Value + "");

                _objDetaRolPago.DescOtros = (row.Cells[62].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[62].Value + "");
                _objDetaRolPago.TotalDescuentos = (row.Cells[63].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[63].Value + "");
                _objDetaRolPago.NetoRecibir = (row.Cells[64].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[64].Value + "");
                _objDetaRolPago.Extra = (row.Cells[65].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[65].Value + "");
                
                _objDetaRolPago.Fonres = Convert.ToBoolean(row.Cells[66].Value) ? 1 : 0;
                _objDetaRolPago.XiiiRol = Convert.ToBoolean(row.Cells[67].Value) ? 1 : 0;
                _objDetaRolPago.XivRol = Convert.ToBoolean(row.Cells[68].Value) ? 1 : 0;
                _objDetaRolPago.Acufor = Convert.ToBoolean(row.Cells[69].Value) ? 1 : 0;
                _objDetaRolPago.Deseg = Convert.ToBoolean(row.Cells[70].Value) ? 1 : 0;
                _objDetaRolPago.XiiiSe = Convert.ToBoolean(row.Cells[71].Value) ? 1 : 0;

                _objDetaRolPago.Idbanco = (row.Cells[72].Value + "").Trim().Length == 0 ? 0 : Convert.ToInt32(row.Cells[72].Value);
                _objDetaRolPago.Banco = row.Cells[73].Value + "";
                _objDetaRolPago.Cuenta = row.Cells[74].Value + "";
                _objDetaRolPago.Tipban = row.Cells[75].Value + "";
                _objDetaRolPago.Esta = (row.Cells[76].Value + "").Trim().Length == 0 ? 0 : Convert.ToInt32(row.Cells[76].Value);
                _objDetaRolPago.ValorAcumuladoFonRes = (row.Cells[77].Value + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row.Cells[77].Value);
                _objDetaRolPago.ExtSal = Convert.ToBoolean(row.Cells[78].Value) ? 1 : 0;
                //_objDetaRolPago.ExtEdit = Convert.ToBoolean(row.Cells[79].Value) ? 1 : 0;
                 //_objDetaRolPago.ExtEdit = (bool)row.Cells[79].Value ? 1 : 0;
                //_objDetaRolPago.ExtEdit = row.Cells[79].Value != DBNull.Value && Convert.ToBoolean(row.Cells[79].Value) ? 1 : 0;
                _objDetaRolPago.IdRol = _estado == 1 ? _objRolPago.IdRol : Convert.ToInt32(lblIdRol.Text.Trim());
                _objDetaRolPago.IdDetaRol = idaux;
                _objDetaRolPago.TipoFila = (row.Tag + "").Trim().Length == 0 ? 0 : Convert.ToInt32(row.Tag);
                
                _sqlCommands.Add(_objDetaRolPago.GuardarDetalleRolPagoCommand());
                idaux++;

                // parametros fondo
                if (_objDetaRolPago.Grupo.Trim().Equals("RETIRADOS") || _objDetaRolPago.IdPersonal == 0) continue;
                _objContratos.IdPersonalContrato = _objDetaRolPago.IdPersonal;
                _objContratos.AplicaFondoReservaContrato = _objDetaRolPago.Fonres;
                _objContratos.XiiiEnRolContrato = _objDetaRolPago.XiiiRol;
                _objContratos.XivEnRolContrato = _objDetaRolPago.XivRol;
                _objContratos.AcumulaFondoReservaContrato = _objDetaRolPago.Acufor;
                _objContratos.SeDescuentaSerguro = _objDetaRolPago.Deseg;
                _objContratos.ExtSal = _objDetaRolPago.ExtSal;
                _sqlCommands.Add(_objContratos.ModificarContratoParametrosRolCommand());
            }


            string user = Usuario.Datos.ToString();
            string nombreU = String.Empty;
            if (_estado == 1 )
                nombreU = $"ROL DE PAGO GENERADO: {user}";

            else if (_estado == 2)
                nombreU = $"ROL DE PAGO MODIFICADO: {user}";

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombreU);
            var msg = res[1].ToString();
            if ((bool)res[0])
            {
                Habilitar(false);

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnActualizar.Enabled = true;
                btnBuscar.Enabled = true;
                btnCancelar.Enabled = false;
                btnAnular.Enabled = true;
                btnValidar.Enabled = true;
                _estado = 0;

                lblIdRol.Text = _objRolPago.IdRol + "";

                CargarDetallesRol(Convert.ToInt32(lblIdRol.Text));

                btnResumen.Enabled = true;
                btnRetener.Enabled = true;

                if (cbxQuincena.SelectedIndex == 1) msg = ValidationForms.MesEnLetras(dtpMesAnio.Value.Month) + " DEL " + dtpMesAnio.Value.Year;
                msg = "El ROL DE PAGO " + cbxTipo.Text.Trim() + " de " + msg + " fue generado correctamente";
            }
            KryptonMessageBox.Show(msg, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (_estado == 0 && lblEstado.Text.Equals("VALIDADO"))
            {
                KryptonMessageBox.Show(@"El ROL DE PAGO seleccionado ya está VALIDADO, no se puede realizar cambios sobre el mismo!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            Habilitar(false);

            btnAgregar.Enabled = true;
            btnCambiar.Enabled = true;
            btnQuitar.Enabled = true;
            btnDatos.Enabled = true;
            btnParams.Enabled = true;

            btnDescuentos.Enabled = true;
            txtObservacion.Enabled = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnBuscar.Enabled = false;
            btnCancelar.Enabled = true;
            btnAnular.Enabled = false;
            btnValidar.Enabled = false;

            btnResumen.Enabled = true;
            btnRetener.Enabled = true;

            _estado = 2;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(@"Está seguro que desea validar el ROL DE PAGO actual? Una vez validado ya no podrá hacer cambios en el mismo",
                "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            _sqlCommands.Clear();

            _objRolPago.FechaValidacion = Usuario.Now(TipoCon);
            _sqlCommands.Add(_objRolPago.ValidarByIdRolPagoCommand(Convert.ToInt32(lblIdRol.Text)));

            var user = Usuario.Datos.ToString();
            var nombre = $"ROL VALIDADO: {user}";
            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombre);
            var msg = res[1].ToString();
            if ((bool)res[0])
            {
                Habilitar(false);

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnActualizar.Enabled = false;
                btnBuscar.Enabled = true;
                btnCancelar.Enabled = false;
                btnAnular.Enabled = false;
                btnValidar.Enabled = false;
                _estado = 0;

                btnResumen.Enabled = false;
                btnRetener.Enabled = false;

                lblEstado.Text = @"VALIDADO";

                if (cbxQuincena.SelectedIndex == 1) msg = ValidationForms.MesEnLetras(dtpMesAnio.Value.Month) + " DEL " + dtpMesAnio.Value.Year;
                msg = "El ROL DE PAGO " + cbxTipo.Text.Trim() + " de " + msg + " fue validado correctamente";
            }
            KryptonMessageBox.Show(msg, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(@"Está seguro que desea anular el ROL DE PAGO actual? Tenga en cuenta que esta acción no es reversible",
                "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            _sqlCommands.Clear();

            _objRolPago.FechaValidacion = Usuario.Now(TipoCon);
            _sqlCommands.Add(_objRolPago.AnularByIdRolPagoCommand(Convert.ToInt32(lblIdRol.Text)));

            var user = Usuario.Datos.ToString();
            var nombre = $"ROL ANULADO: {user}";
            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombre);
            var msg = res[1].ToString();
            if ((bool)res[0])
            {
                Habilitar(false);

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnActualizar.Enabled = false;
                btnBuscar.Enabled = true;
                btnCancelar.Enabled = false;
                btnAnular.Enabled = false;
                btnValidar.Enabled = false;
                _estado = 0;

                btnResumen.Enabled = false;
                btnRetener.Enabled = false;

                lblEstado.Text = @"ANULADO";

                if (cbxQuincena.SelectedIndex == 1) msg = ValidationForms.MesEnLetras(dtpMesAnio.Value.Month) + " DEL " + dtpMesAnio.Value.Year;
                msg = "El ROL DE PAGO " + cbxTipo.Text.Trim() + " de " + msg + " fue anulado correctamente";
            }
            KryptonMessageBox.Show(msg, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);

            lblIdRol.Text = "";

            dtpFechaElaborado.Value = Usuario.Now(TipoCon);
            dtpMesAnio.Value = new DateTime(dtpFechaElaborado.Value.Year, dtpFechaElaborado.Value.Month, 1);

            cbxTipo.SelectedIndex = 0;
            cbxQuincena.SelectedIndex = 0;
            txtObservacion.Clear();
            cbxGrupo.Items.Clear();

            dgvDetallesRol.Rows.Clear();

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = false;
            btnBuscar.Enabled = true;
            btnCancelar.Enabled = false;
            btnAnular.Enabled = false;
            btnValidar.Enabled = false;

            btnResumen.Enabled = false;
            btnRetener.Enabled = false;

            txtTotIngresos.Text = 0.ToString("N");
            txtTotDescuentos.Text = 0.ToString("N");
            txtTotCobrar.Text = 0.ToString("N");

            txtAcfoAd.Text = 0.ToString("N");
            txtAcfoOp.Text = 0.ToString("N");
            txtAcfonRes.Text = 0.ToString("N");

            _estado = 0;
        }

        private string CompletarConCero(string cadena, int longitudCadena, bool derecha)
        {
            var newCadena = cadena;
            for (var i = 0; i <= (longitudCadena - cadena.Length) - 1; i++)
            {
                if (derecha) newCadena = ("0" + newCadena);
                else newCadena = (newCadena + "0");
            }
            return newCadena;
        }

        private string CompletarConEspacio(string cadena, int longitudCadena, bool derecha)
        {
            var newCadena = cadena;
            for (var i = 0; i <= (longitudCadena - cadena.Length) - 1; i++)
            {
                if (derecha) newCadena = (" " + newCadena);
                else newCadena = (newCadena + " ");
            }
            return newCadena;
        }

        private void cbxQuincena_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxTipo_SelectedIndexChanged(null, null);
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cbxGrupo.Items.Clear();
            if (cbxQuincena.SelectedIndex == 0) //  quince
            {
                if (cbxTipo.SelectedIndex == 0)
                {
                    dtpDesde.Value = new DateTime(dtpMesAnio.Value.Month == 1 ? (dtpMesAnio.Value.Year - 1) : dtpMesAnio.Value.Year, dtpMesAnio.Value.Month == 1 ? 12 : (dtpMesAnio.Value.Month - 1), 26);
                    dtpHasta.Value = new DateTime(dtpMesAnio.Value.Year, dtpMesAnio.Value.Month, 15);
                    cbxGrupo.Items.Add("");
                }
                else
                {
                    dtpDesde.Value = new DateTime(dtpMesAnio.Value.Year, dtpMesAnio.Value.Month, 1);
                    dtpHasta.Value = new DateTime(dtpMesAnio.Value.Year, dtpMesAnio.Value.Month, 15);
                    cbxGrupo.Items.Add("ADMINISTRATIVO");
                }

                cbxGrupo.SelectedIndex = 0;
                cbxGrupo.Enabled = false;
            }
            else //  mensual
            {
                if (cbxTipo.SelectedIndex == 0) //  oper
                {
                    dtpDesde.Value = new DateTime(dtpMesAnio.Value.Month == 1 ? (dtpMesAnio.Value.Year - 1) : dtpMesAnio.Value.Year, dtpMesAnio.Value.Month == 1 ? 12 : (dtpMesAnio.Value.Month - 1), 26);
                    dtpHasta.Value = dtpDesde.Value.AddMonths(1).AddDays(-1);

                    //  cargar grupos
                    var data = _objetoSitio.SeleccionarGruposSitios(TipoCon, false, false, false);
                    foreach (var row in data.Rows.Cast<DataRow>().Where(row => !cbxGrupo.Items.Contains(row[0])))
                        cbxGrupo.Items.Add(row[0]);

                    if (cbxGrupo.Items.Count > 0) cbxGrupo.SelectedIndex = 0;
                    cbxGrupo.DropDownWidth = 450;
                    cbxGrupo.Enabled = _estado == 1;
                }
                else if ((cbxTipo.SelectedIndex == 1))  //  admin
                {
                    dtpDesde.Value = new DateTime(dtpMesAnio.Value.Year, dtpMesAnio.Value.Month, 1);

                    dtpHasta.Value = dtpDesde.Value.AddMonths(1).AddDays(-1).Day == 31 ?
                        new DateTime(dtpMesAnio.Value.Year, dtpMesAnio.Value.Month, 30) :
                        dtpDesde.Value.AddMonths(1).AddDays(-1);

                    cbxGrupo.Items.Add("");
                    cbxGrupo.SelectedIndex = 0;
                    cbxGrupo.Enabled = false;
                }
            }
        }

        private void dgvDetallesRol_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvDetallesRol.CurrentRow == null) return;
            e.Cancel = _estado == 0 || dgvDetallesRol.CurrentRow.Cells[1].Value == null || string.IsNullOrEmpty(dgvDetallesRol.CurrentRow.Cells[1].Value + "") || dgvDetallesRol.CurrentRow.Cells[1].Value.ToString().Equals("0");


           
            

            
        }

        //AQUI colDesHipo colExtSal colSaludConyu colAntiEmer colDesCapaseg colAntiVario colPrestEmpre colComecsa colComisariato colEquipoSeg colDesAlmuerzo colDesPension colViviana colMultasAtrasos colDiasNoLaborados ColDescDeci colOtrosDes
        private void dgvDetallesRol_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //var cell = dgvDetallesRol.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //int extEditColu = dgvDetallesRol.Columns["extedit"].Index;
            if (dgvDetallesRol.CurrentRow == null) return;
            


           // if (extEditColu >= 0 && !Usuario.IdUsuario.Equals("35"))
           // {
                //bool extEditValue = (bool)dgvDetallesRol.Rows[e.RowIndex].Cells[extEditColu].Value;

                //if (extEditValue)
                //{
                    
                //        dgvDetallesRol.EndEdit();
                //    }
                //    else
                //    {
                //        dgvDetallesRol.CancelEdit();
                //        dgvDetallesRol.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                //        dgvDetallesRol.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                //    }
                
           // }

          //  else
            //{
            //    if (cell.OwningColumn.Name == "colDescQuinan" || cell.OwningColumn.Name == "colDesQuiro" || cell.OwningColumn.Name == "colDesHipo"  || cell.OwningColumn.Name == "colSaludConyu"
            //        || cell.OwningColumn.Name == "colAntiEmer" || cell.OwningColumn.Name == "colDesCapaseg" || cell.OwningColumn.Name == "colAntiVario" || cell.OwningColumn.Name == "colPrestEmpre" || cell.OwningColumn.Name == "colComecsa"
            //        || cell.OwningColumn.Name == "colComisariato" || cell.OwningColumn.Name == "colEquipoSeg" || cell.OwningColumn.Name == "colDesAlmuerzo" || cell.OwningColumn.Name == "colDesPension" || cell.OwningColumn.Name == "colViviana"
            //        || cell.OwningColumn.Name == "colMultasAtrasos" || cell.OwningColumn.Name == "colDiasNoLaborados" || cell.OwningColumn.Name == "ColDescDeci" )
            //    {
            //        if (!Usuario.TipoUsuario.Equals("ADMINISTRADOR"))
            //        {
            //            if (KryptonMessageBox.Show(@"Se solicta permiso de Administrador  ya que no podrá hacer cambios en el mismo",
            //             "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes)
            //            {
            //                dgvDetallesRol.CancelEdit();
            //                dgvDetallesRol.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
            //                dgvDetallesRol.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
            //                return;
            //            }

            //            var frm = new FrmValidar();
            //            if (frm.ShowDialog() != DialogResult.OK)
            //            {
            //                dgvDetallesRol.CancelEdit();
            //                dgvDetallesRol.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
            //                dgvDetallesRol.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
            //                return;

            //            }


            //            else
            //            {


            //                dgvDetallesRol.EndEdit();
            //            }

            //        }
            //    }

              CalcularDatosFilaRol(e.RowIndex);
               SumatoriasRol();
            //}
        }

        private void btnCargarPersonal_Click(object sender, EventArgs e)
        {
            if (cbxQuincena.SelectedIndex == 1 && cbxTipo.SelectedIndex == 0 && cbxGrupo.Text.Trim().Length == 0)
            {
                KryptonMessageBox.Show(@"Por favor, seleccione el grupo al que desea general rol de pago!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            if (dgvDetallesRol.RowCount != 0)
                if (KryptonMessageBox.Show(@"Ya se generó la nómina de personal, si acepta se volverá a cargar con los valores por defecto para dicha nómina, perdiendo los cambios que ha realizado hasta el momento. Quiere cargar de nuevo los datos?",
                        "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
                    DialogResult.Yes) return;

            dtpMesAnio.Enabled = false;
            cbxTipo.Enabled = false;
            cbxQuincena.Enabled = false;
            cbxGrupo.Enabled = false;
            btnCargarPersonal.Enabled = true;
            btnDatos.Enabled = true;
            btnParams.Enabled = true;
            txtObservacion.Enabled = true;
            dtpDesde.Enabled = false;
            dtpHasta.Enabled = false;

            dgvDetallesRol.Rows.Clear();
            if (dgvDetallesRol.Columns["Column6"] != null) dgvDetallesRol.Columns["Column6"].DefaultCellStyle.Format = "d"; // INGRESO
            if (dgvDetallesRol.Columns["Column9"] != null) dgvDetallesRol.Columns["Column9"].DefaultCellStyle.Format = "d"; // NACIMIENTO

            var fechaDesde = dtpDesde.Value.Day + "-" + dtpDesde.Value.Month + "-" + dtpDesde.Value.Year + " 00:00:00";
            var fechaHasta = dtpHasta.Value.Day + "-" + dtpHasta.Value.Month + "-" + dtpHasta.Value.Year + " 23:59:59";
            var fcon = 5 + "-" + dtpHasta.Value.Month + "-" + dtpHasta.Value.Year + " 23:59:59"; // activos (antiguos) y nuevos (hasta el 5 de cada mes)
            //var fcon = 1 + "-" + dtpHasta.Value.Month + "-" + dtpHasta.Value.Year + " 23:59:59"; // activos (antiguos) y nuevos (hasta el 5 de cada mes)
            _objRolParametrosRolPago = _objRolParametrosRolPago.SeleccionarParametrosActualesRoles(TipoCon);

            var i = 0;

            if (cbxQuincena.SelectedIndex == 0) //  ' quincena / anticipo
            {
                #region QUINCENA

                if (cbxTipo.SelectedIndex == 0) // oeprativo
                {
                    dgvDetallesRol.Columns["colDiasNoLaborados"].HeaderText = "DIAS NO LABOR.";

                    #region OPERATIVO
                    i = 1;
                    dgvDetallesRol.Rows.Add("", "", "", "VIGILANTES DE SEGURIDAD");
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = Color.Black;
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.ForeColor = Color.White;
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 1;

                    var grupos = _objetoSitio.SeleccionarGruposSitios(TipoCon, false, false, false);
                    foreach (DataRow grupo in grupos.Rows)
                    {
                        var opots = _objRolPago.SeleccionarDetallesPersonalOperQuinceNuevoRolPago(TipoCon, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta), Convert.ToDateTime(fcon), grupo[0].ToString());
                        dgvDetallesRol.Rows.Add("", "", "", grupo[0]);
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 2;
                        
                        foreach (DataRow noms in opots.Rows)
                        {
                            dgvDetallesRol.Rows.Add(grupo[0], noms[0], i, noms[8], noms[9], noms[1], noms[2], noms[24], noms[25], noms[3], noms[4], noms[5],
                                Convert.ToDouble(noms[6]).ToString("N"), 0, "0.00", // SUELDO NORMAL
                                0, "0.00", Convert.ToDouble(noms[6]).ToString("N"), // SUELDO DESCANSO MEDICO
                                0, Convert.ToDouble(_objRolParametrosRolPago.CostoHorasNoral).ToString("N"), "0.00", // HOAS NOR
                                0, Convert.ToDouble(_objRolParametrosRolPago.CostoHoras50).ToString("N"), "0.00", // HOAS 50
                                0, Convert.ToDouble(_objRolParametrosRolPago.CostoHoras100).ToString("N"), "0.00", // HOAS 100
                                0, Convert.ToDouble(_objRolParametrosRolPago.CostoHoras100).ToString("N"), "0.00", // HOAS EXT
                                "0.00", Convert.ToDouble(_objRolParametrosRolPago.AnticipoGuardias).ToString("N"), // RECNOR, ADIC
                                "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", Convert.ToDouble(_objRolParametrosRolPago.AnticipoGuardias).ToString("N"),

                                 string.Empty,

                                "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00",
                                "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00",// DESCUENTOS

                                Convert.ToDouble(_objRolParametrosRolPago.AnticipoGuardias).ToString("N"), // neto
                                "0.00",

                                noms[11].ToString().Equals("1"), noms[12].ToString().Equals("1"), noms[13].ToString().Equals("1"),
                                noms[15].ToString().Equals("1"), noms[16].ToString().Equals("1"), noms[17].ToString().Equals("1"), // params 

                                noms[19].ToString(), noms[20].ToString(), noms[21].ToString(), noms[22].ToString(), 
                                noms[26].ToString(), "0.00", 0); // EXTSAL


                            if (noms[26].ToString().Equals("0")) dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = Color.LightSalmon;

                            i++;
                        }

                        dgvDetallesRol.Rows.Add(grupo[0], "", "", ("TOTAL GRUPO " + grupo[0]));
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = SystemColors.Control;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 3;
                        dgvDetallesRol.Rows.Add();
                        dgvDetallesRol.Rows.Add();
                    }
                    dgvDetallesRol.Rows.RemoveAt((dgvDetallesRol.RowCount - 1));
                    dgvDetallesRol.Rows.RemoveAt((dgvDetallesRol.RowCount - 1));

                    #endregion
                }
                else // admin
                {
                    dgvDetallesRol.Columns["colDiasNoLaborados"].HeaderText = "DESC. SEG. PRIV";

                    #region ADMIN
                    i = 1;

                    dgvDetallesRol.Rows.Add("", "", "", "PERSONAL ADMINISTRATIVO");
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = Color.Black;
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.ForeColor = Color.White;
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 1;

                    var admin = _objRolPago.SeleccionarDetallesPersonalAdminNuevoRolPago(TipoCon, dtpMesAnio.Value.Month, dtpMesAnio.Value.Year, cbxQuincena.SelectedIndex, false, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));
                    foreach (DataRow row in admin.Rows)
                    {
                        if (row[22].ToString().Equals("0")) continue;

                        var quince = _objRolParametrosRolPago.QuinceAdminEsSueldoMasExtra == 1 ? CalcularMensualPorDias((Convert.ToDouble(row[8]) + Convert.ToDouble(row[12])), 15) :
                            CalcularMensualPorDias(Convert.ToDouble(row[8]), 15);

                        dgvDetallesRol.Rows.Add("ADMINISTRATIVO", row[0], i, row[1], row[2], row[3], row[4], row[22], row[23], row[5], row[6], row[7],
                            Convert.ToDouble(row[8]).ToString("N"), 15, quince.ToString("N"),
                            0, "0.00", quince.ToString("N"),

                            0, "0.00", "0.00",
                            0, "0.00", "0.00",
                            0, "0.00", "0.00",
                            0, "0.00", "0.00",

                            "0.00", "0.00", "0.00", "0.00", quince.ToString("N"), "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", quince.ToString("N"), string.Empty,

                            "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", 
                            "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00", "0.00",
                            quince.ToString("N"), "0.00", 

                            row[9].ToString().Equals("1"), row[10].ToString().Equals("1"), row[11].ToString().Equals("1"), // opciones
                            row[13].ToString().Equals("1"), row[14].ToString().Equals("1"), row[15].ToString().Equals("1"),

                            row[17].ToString(), row[18].ToString(), row[19].ToString(), row[20].ToString(), // banco

                            row[16].ToString(), "0.00", row[24].ToString().Equals("1"));

                        if (row[16].ToString().Equals("0")) dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = Color.LightSalmon;
                        i++;
                    }

                    dgvDetallesRol.Rows.Add("ADMINISTRATIVO", "", "", "TOTAL GRUPO ADMINISTRATIVO");
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = SystemColors.Control;
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 3;

                    #endregion
                }

                #endregion
            }
            else // mensual
            {
                #region MENSUAL

                var descuentos = new double[17];

                if (cbxTipo.SelectedIndex == 0) // operativo
                {
                    dgvDetallesRol.Columns["colDiasNoLaborados"].HeaderText = "DIAS NO LABOR.";

                    #region OPERATIVO
                    i = 1;
                    dgvDetallesRol.Rows.Add("", "", "", "VIGILANTES DE SEGURIDAD");
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = Color.Black;
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.ForeColor = Color.White;
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 1;

                    // GRUPOS OPERATIVOS
                    var grupos = new DataTable();
                    grupos.Columns.Add("grupo");
                    if (cbxGrupo.Text.Trim().Equals("GENERAL"))
                    {
                        grupos.Rows.Add("GENERAL");
                        grupos.Rows.Add("RETIRADOS");
                    }
                    else grupos.Rows.Add(cbxGrupo.Text.Trim());

                    fcon = 1 + "-" + dtpHasta.Value.Month + "-" + dtpHasta.Value.Year + " 00:00:00"; // fecha apra retirados

                    foreach (DataRow row in grupos.Rows)
                    {
                        var opots = _objRolPago.SeleccionarDetallesPersonalOperNuevoRolPagoMes(TipoCon, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta),
                            row[0].ToString(), !row[0].ToString().Equals("RETIRADOS"), dtpMesAnio.Value.Month,
                            dtpMesAnio.Value.Year, cbxQuincena.SelectedIndex, Convert.ToDateTime(fcon));

                        dgvDetallesRol.Rows.Add("", "", "", row[0]);
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 2;

                        foreach (DataRow noms in opots.Rows)
                        {
                            var quince = (noms[27] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[27]); // quincena

                            descuentos[0] = (noms[28] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[28]); // quirogra
                            descuentos[1] = (noms[29] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[29]); // hipote
                            descuentos[2] = (noms[30] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[30]); // saludcon
                            descuentos[3] = (noms[31] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[31]); // antiemerg
                            descuentos[4] = (noms[32] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[32]); // capaseg
                            descuentos[5] = (noms[33] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[33]); // varos
                            descuentos[6] = (noms[34] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[34]); // empresa
                            descuentos[7] = (noms[35] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[35]); // comecsa
                            descuentos[8] = (noms[36] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[36]); // comisa
                            descuentos[9] = (noms[37] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[37]); // bodega
                            descuentos[10] = (noms[38] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[38]); // multas
                            descuentos[11] = (noms[39] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[39]); // otros
                            descuentos[12] = (noms[40] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[40]); // pension
                            descuentos[13] = (noms[47] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[47]); // pensionxiii
                            descuentos[14] = (noms[48] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[48]); // pensionxiv
                            descuentos[15] = (noms[49] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[49]); // almuerzo
                            descuentos[16] = (noms[50] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(noms[50]); // diasnolab

                            var dop = noms[16].ToString().Equals("1") ? Convert.ToDouble(_objRolParametrosRolPago.OtrosDescuentosOperativos) : 0;

                            dgvDetallesRol.Rows.Add(row[0], noms[0], i, noms[8], noms[9], noms[1], noms[2], noms[23], noms[24], noms[3], noms[4], noms[5],
                                Convert.ToDouble(_objRolParametrosRolPago.SueldoVigilantes).ToString("N"), 0, "0.00",
                                0, "0.00", Convert.ToDouble(_objRolParametrosRolPago.SueldoVigilantes).ToString("N"),

                                Convert.ToDouble(noms[41]), Convert.ToDouble(_objRolParametrosRolPago.CostoHorasNoral).ToString("N"), "0.00", // hn
                                Convert.ToDouble(noms[42]), Convert.ToDouble(_objRolParametrosRolPago.CostoHoras50).ToString("N"), "0.00", // h50
                                Convert.ToDouble(noms[43]), Convert.ToDouble(_objRolParametrosRolPago.CostoHoras100).ToString("N"), "0.00", // h100
                                Convert.ToDouble(noms[44]), Convert.ToDouble(_objRolParametrosRolPago.CostoHoras100).ToString("N"), "0.00", // hext
                                Convert.ToDouble(noms[45]), Convert.ToDouble(noms[46]), // noc, adic

                                "0.00", "0.00", "0.00", "0.00", descuentos[13].ToString("N"), "0.00", descuentos[14].ToString("N"), "0.00", "0.00", "0.00", "0.00",

                                string.Empty,
                                "0.00", quince.ToString("N"),

                                descuentos[0].ToString("N"), descuentos[1].ToString("N"), descuentos[2].ToString("N"),
                                descuentos[3].ToString("N"), descuentos[4].ToString("N"), descuentos[5].ToString("N"), descuentos[6].ToString("N"),
                                descuentos[7].ToString("N"), descuentos[8].ToString("N"), descuentos[9].ToString("N"), descuentos[15].ToString("N"),
                                (descuentos[12] + descuentos[13] + descuentos[14]).ToString("N"),
                                "0.00", descuentos[10].ToString("N"), descuentos[16].ToString("N"), "0.00", ((descuentos[11] + dop)).ToString("N"),
                                "0.00", "0.00", noms[14].ToString(),

                                noms[11].ToString().Equals("1"), noms[12].ToString().Equals("1"), noms[13].ToString().Equals("1"),
                                noms[15].ToString().Equals("1"), noms[16].ToString().Equals("1"), noms[17].ToString().Equals("1"),

                                //noms[19].ToString(), noms[20].ToString(), noms[21].ToString(), noms[22].ToString(), 
                                noms[18].ToString().Equals("0") ? "0" : noms[19].ToString(), 
                                noms[18].ToString().Equals("0") ? "SIN BANCO" : noms[20].ToString(),
                                noms[18].ToString().Equals("0") ? "" : noms[21].ToString(),
                                noms[18].ToString().Equals("0") ? "AHO" : noms[22].ToString(), 


                                noms[18].ToString(), "0.00", noms[26].ToString().Equals("1"));

                            if (noms[18].ToString().Equals("0")) dgvDetallesRol.Rows[dgvDetallesRol.RowCount - 1].DefaultCellStyle.BackColor = Color.LightSalmon;
                            i++;
                        }

                        dgvDetallesRol.Rows.Add(row[0], "", "", ("TOTAL GRUPO " + row[0]));
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = SystemColors.Control;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 3;

                        dgvDetallesRol.Rows.Add();
                        dgvDetallesRol.Rows.Add();
                    }

                    dgvDetallesRol.Rows.RemoveAt((dgvDetallesRol.RowCount - 1));
                    dgvDetallesRol.Rows.RemoveAt((dgvDetallesRol.RowCount - 1));
                    #endregion
                }
                if (cbxTipo.SelectedIndex == 1) // admin
                {
                    dgvDetallesRol.Columns["colDiasNoLaborados"].HeaderText = "DESC. SEG. PRIV";

                    #region ADMIN
                    i = 1;
                    //  PERSONAL(ADMINISTRATIVO)
                    dgvDetallesRol.Rows.Add("", "", "", "PERSONAL ADMINISTRATIVO");
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = Color.Black;
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.ForeColor = Color.White;
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 1;

                    var fd = 1 + "-" + dtpMesAnio.Value.Month + "-" + dtpMesAnio.Value.Year + " 00:00:00";
                    var fh = Convert.ToDateTime(fd).AddMonths(1).AddDays(-1).Day + "-" + dtpHasta.Value.Month + "-" +
                             dtpHasta.Value.Year + " 23:59:59";

                    var admin = _objRolPago.SeleccionarDetallesPersonalAdminNuevoRolPago(TipoCon, dtpMesAnio.Value.Month, dtpMesAnio.Value.Year, cbxQuincena.SelectedIndex, true, Convert.ToDateTime(fd), Convert.ToDateTime(fh));

                    foreach (DataRow row in admin.Rows)
                    {
                        var quince = (row[21] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[21]);

                        descuentos[0] = (row[22] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[22]); // quiro
                        descuentos[1] = (row[23] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[23]); // hipo
                        descuentos[2] = (row[24] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[24]); // extsal
                        descuentos[3] = (row[25] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[25]); // emerg
                        descuentos[4] = (row[26] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[26]); // capaseg
                        descuentos[5] = (row[27] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[27]); // varios
                        descuentos[6] = (row[28] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[28]); // empresa
                        descuentos[7] = (row[29] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[29]); // comecsa
                        descuentos[8] = (row[30] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[30]); // comisariato
                        descuentos[9] = (row[31] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[31]); // bodega
                        descuentos[10] = (row[32] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[32]); // multas
                        descuentos[11] = (row[33] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[33]); // otros
                        descuentos[12] = (row[34] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[34]); // pensión
                        descuentos[13] = (row[35] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[35]); // penxiii
                        descuentos[14] = (row[36] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[36]); // penxiv
                        descuentos[15] = (row[37] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[37]); // almuerzo
                        descuentos[16] = (row[38] + "").Trim().Length == 0 ? 0 : Convert.ToDouble(row[38]); // diasnolab

                        dgvDetallesRol.Rows.Add("ADMINISTRATIVO", row[0], i, row[1], row[2], row[3], row[4], row[39], row[40], row[5], row[6], row[7],
                            Convert.ToDouble(row[8]).ToString("N"), 30, Convert.ToDouble(row[8]).ToString("N"), // sueldo
                            0, "0.00", Convert.ToDouble(row[8]).ToString("N"), // sueldo medi

                            0, "0.00", "0.00", // hor nor
                            0, "0.00", "0.00", // hor 50
                            0, "0.00", "0.00", // hor 100
                            0, "0.00", "0.00", // hor ext

                            "0.00", Convert.ToDouble(row[12]).ToString("N"), "0.00", "0.00", "0.00", "0.00", descuentos[13].ToString("N"), "0.00",
                            descuentos[14].ToString("N"), "0.00", "0.00", "0.00", "0.00",

                            string.Empty,

                            "0.00", quince.ToString("N"),

                            descuentos[0].ToString("N"), descuentos[1].ToString("N"), descuentos[2].ToString("N"), descuentos[3].ToString("N"),
                            descuentos[4].ToString("N"), descuentos[5].ToString("N"), descuentos[6].ToString("N"), descuentos[7].ToString("N"),
                            descuentos[8].ToString("N"), descuentos[9].ToString("N"), descuentos[15].ToString("N"),
                            (descuentos[12] + descuentos[13] + descuentos[14]).ToString("N"),
                            "0.00", descuentos[10].ToString("N"), descuentos[16].ToString("N"), "0.00", ((descuentos[11] + Convert.ToDouble(_objRolParametrosRolPago.OtrosDescuentosAdmin))).ToString("N"),
                            "0.00", "0.00", // total, neto
                            row[12], // extadmin

                            row[9].ToString().Equals("1"), row[10].ToString().Equals("1"), row[11].ToString().Equals("1"),
                            row[13].ToString().Equals("1"), row[14].ToString().Equals("1"), row[15].ToString().Equals("1"),

                            row[17].ToString(), row[18].ToString(), row[19].ToString(), row[20].ToString(),
                            row[16].ToString(), "0.00", row[41].ToString().Equals("1")); // extsal

                        if (row[16].ToString().Equals("0")) dgvDetallesRol.Rows[dgvDetallesRol.RowCount - 1].DefaultCellStyle.BackColor = Color.LightSalmon;
                        i++;
                    }

                    dgvDetallesRol.Rows.Add("ADMINISTRATIVO", "", "", "TOTAL GRUPO ADMINISTRATIVO");
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = SystemColors.Control;
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 3;
                    #endregion
                }

                _cantRol = (i - 1);

                Label14.Text = @"DETALLES GENERALES ROL DE PAGO - " + _cantRol + @" REGISTRO(S) EN TOTAL";

                #endregion
            }

            dgvDetallesRol.AutoResizeRows();

            if (cbxQuincena.SelectedIndex == 1) EstablecerDiasTrabajadosRolNuevo(fechaDesde, fechaHasta);

            SumatoriasRol();
        }

        private void EstablecerDiasTrabajadosRolNuevo(string fechaDesde, string fechaHasta)
        {
            if (cbxQuincena.SelectedIndex == 0) return;
            var fechad = dtpDesde.Value.Day + "-" + dtpDesde.Value.Month + "-" + dtpDesde.Value.Year + " 00:00:00";
            var fechah = dtpHasta.Value.Day + "-" + dtpHasta.Value.Month + "-" + dtpHasta.Value.Year + " 23:59:59";

            foreach (DataGridViewRow row in dgvDetallesRol.Rows)
            {
                if ((row.Cells["GRP"].Value + "").Trim().Length == 0) continue;
                if (string.IsNullOrEmpty((row.Cells["colSueldoMes"].Value + "").Trim())) continue;

                var fis = _objAsignacionPersonal.SeleccionarFechaEntradaSalidaByIdPersonal(TipoCon, Convert.ToInt32(row.Cells[1].Value));

                var x = Convert.ToDateTime(fis.Rows[0][0]);
                var fechain = x.Day + "-" + x.Month + "-" + x.Year + " 00:00:00";
                var fechaIngreso = Convert.ToDateTime(fechaDesde) > Convert.ToDateTime(fechain) ? fechaDesde : fechain;

                var s = Convert.ToDateTime(fis.Rows[0][1]);
                var fechaou = s.Day + "-" + s.Month + "-" + s.Year + " 00:00:00";
                var fechaSalida = Convert.ToDateTime(fechaou) < Convert.ToDateTime(fechain) ? fechaHasta : Convert.ToDateTime(fechaHasta) > Convert.ToDateTime(fechaou) ? fechaou : fechaHasta;

                var vigia = _objAsignacionPersonal.SeleccionarRegistroAsistenciaDetallesByGuardias(TipoCon, true,
                    Convert.ToInt32(row.Cells[1].Value), Convert.ToDateTime(fechad), Convert.ToDateTime(fechah),
                    Convert.ToDateTime(fechaIngreso), Convert.ToDateTime(fechaSalida));

                if (vigia.Rows.Count == 0) continue;

                row.Cells["colDiasTrabajo"].Value = vigia.Rows.Count;

                if (row.Cells[2].Value == null || (row.Cells[2].Value + "").Trim().Length == 0) continue;
                CalcularDatosFilaRol(row.Index);
            }
        }

        

        private void CalcularDatosFilaRol(int rowIndex)
        {
            if (rowIndex < 0) return;

            // ingresos
            _diasTrabajados = 0;
            _sueldoDiasTrabajados = 0.0;
            _diasDescansoMedico = 0;
            _sueldoDescansoMedico = 0.0;
            _sueldoDiasTrabajadoDescansoMedico = 0.0;

            _totalHoras = 0.0;
            _totalHoras50 = 0.0;
            _totalHoras100 = 0.0;
            _totalHorasFeriado100 = 0.0;
            _recargoNocturno = 0.0;
            _adicional = 0.0;
            _otrosIngresos = 0.0;
            _totalExtras = 0.0;
            _sueldoMasExtras = 0.0;

            _xiii = 0.0;
            _xiiiPorPension = 0.0;
            _xiv = 0.0;
            _xivPorPension = 0.0;
            _fordoReserva = 0.0;
            _fordoReservaMesAnte = 0.0;
            _totalBeneficios = 0.0;
            _totalIngresos = 0.0;

            //_auXiii = 0.0;
            //_auxFre = 0.0;

            // egresos PILAS 
            _descuentoIess = 0.0;
            _quincenaAnticipo = 0.0;
            _prestamoQuirografario = 0.0;
            _prestamoHipotecario = 0.0;
            _extensionSalud = 0.0;
            _anticipoEmergente = 0.0;
            _descuentoCapaseg = 0.0;
            _anticiposVarios = 0.0;
            _prestamoEmpresa = 0.0;
            _descuenoComecsaFarm = 0.0;
            _descuentoComisariato = 0.0;
            _descuentoEquipoSeguridad = 0.0;
            _descuentoAlmuerszos = 0.0;
            _descuento10moPensionAlimento = 0.0;
            _descuentoPensionAlimento = 0.0;
            _multasYAtrasos = 0.0;
            _descdiasnolaborados = 0.0;
            _descDiferenciaDecimoFondo = 0;
            _otrosDescuentos = 0.0;
            _totalDescuentos = 0.0;

            // neto recibir
            _netorecibir = 0.0;

            // acumulan fondo reserva
            _acumfonres = 0.0;

            var sueldoBase = Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colSueldoMes"].Value);

            // dias trabajados 
            try
            {
                _diasTrabajados = Convert.ToInt32(dgvDetallesRol.Rows[rowIndex].Cells["colDiasTrabajo"].Value);

                if (_diasTrabajados < 0) _diasTrabajados = 0;
                if (_diasTrabajados > 29) _diasTrabajados = 30;

                _sueldoDiasTrabajados = CalcularMensualPorDias(sueldoBase, _diasTrabajados);

                dgvDetallesRol.Rows[rowIndex].Cells["colDiasTrabajo"].Value = _diasTrabajados;
                dgvDetallesRol.Rows[rowIndex].Cells["colSueldoDiasMes"].Value = _sueldoDiasTrabajados.ToString("N");

                dgvDetallesRol.Rows[rowIndex].Cells["colDiasTrabajo"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
                dgvDetallesRol.Rows[rowIndex].Cells["colSueldoDiasMes"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _diasTrabajados = 0;
                _sueldoDiasTrabajados = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colDiasTrabajo"].Value = _diasTrabajados;
                dgvDetallesRol.Rows[rowIndex].Cells["colDiasTrabajo"].Style.BackColor = Color.Red;

                dgvDetallesRol.Rows[rowIndex].Cells["colSueldoDiasMes"].Value = _sueldoDiasTrabajados.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colSueldoDiasMes"].Style.BackColor = Color.Red;
            }

            // dias descanso medico 
            try
            {
                _diasDescansoMedico = Convert.ToInt32(dgvDetallesRol.Rows[rowIndex].Cells["colDiasDescansoMed"].Value);
                _sueldoDescansoMedico = CalcularMensualPorDescansoMedico(sueldoBase, _diasDescansoMedico);

                dgvDetallesRol.Rows[rowIndex].Cells["colDiasDescansoMed"].Value = _diasDescansoMedico;
                dgvDetallesRol.Rows[rowIndex].Cells["colSueldoDiasDescansoMed"].Value = _sueldoDescansoMedico.ToString("N");

                dgvDetallesRol.Rows[rowIndex].Cells["colDiasDescansoMed"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
                dgvDetallesRol.Rows[rowIndex].Cells["colSueldoDiasDescansoMed"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _diasDescansoMedico = 0;
                _sueldoDescansoMedico = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colDiasDescansoMed"].Value = _diasDescansoMedico;
                dgvDetallesRol.Rows[rowIndex].Cells["colDiasDescansoMed"].Style.BackColor = Color.Red;

                dgvDetallesRol.Rows[rowIndex].Cells["colSueldoDiasDescansoMed"].Value = _sueldoDescansoMedico.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colSueldoDiasDescansoMed"].Style.BackColor = Color.Red;
            }

            // suedo normal + descasnso medico
            try
            {
                _sueldoDiasTrabajadoDescansoMedico = _sueldoDiasTrabajados + _sueldoDescansoMedico;
                dgvDetallesRol.Rows[rowIndex].Cells["colSueldoDiasTrabajoDescansoMed"].Value = _sueldoDiasTrabajadoDescansoMedico.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colSueldoDiasTrabajoDescansoMed"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _sueldoDiasTrabajadoDescansoMedico = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colSueldoDiasTrabajoDescansoMed"].Value = _sueldoDiasTrabajadoDescansoMedico.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colSueldoDiasTrabajoDescansoMed"].Style.BackColor = Color.Red;
            }

            //  horas normales  
            try
            {
                if (cbxQuincena.SelectedIndex == 0)
                {
                    _totalHoras = 0;
                    dgvDetallesRol.Rows[rowIndex].Cells["colH"].Value = _totalHoras;
                }
                else
                {
                    _totalHoras = Math.Round((Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colH"].Value) * Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colCh"].Value)), 2);
                }

                dgvDetallesRol.Rows[rowIndex].Cells["colTh"].Value = _totalHoras.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colTh"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _totalHoras = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colTh"].Value = _totalHoras.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colTh"].Style.BackColor = Color.Red;
            }

            //  horas 50% 
            try
            {
                if (cbxQuincena.SelectedIndex == 0)
                {
                    _totalHoras50 = 0;
                    dgvDetallesRol.Rows[rowIndex].Cells["colH50"].Value = _totalHoras50;
                }
                else
                {
                    _totalHoras50 = Math.Round((Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colH50"].Value) * Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colCh50"].Value)), 2);
                }

                dgvDetallesRol.Rows[rowIndex].Cells["colTh50"].Value = _totalHoras50.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colTh50"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _totalHoras50 = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colTh50"].Value = _totalHoras50.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colTh50"].Style.BackColor = Color.Red;
            }

            //  horas 100% 
            try
            {
                if (cbxQuincena.SelectedIndex == 0)
                {
                    _totalHoras100 = 0;
                    dgvDetallesRol.Rows[rowIndex].Cells["colH100"].Value = _totalHoras100;
                }
                else
                {
                    _totalHoras100 = Math.Round((Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colH100"].Value) * Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colCh100"].Value)), 2);
                }

                dgvDetallesRol.Rows[rowIndex].Cells["colTh100"].Value = _totalHoras100.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colTh100"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _totalHoras100 = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colTh100"].Value = _totalHoras100.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colTh100"].Style.BackColor = Color.Red;
            }

            //  horas 100% feriados 
            try
            {
                if (cbxQuincena.SelectedIndex == 0)
                {
                    _totalHorasFeriado100 = 0;
                    dgvDetallesRol.Rows[rowIndex].Cells["colHExt"].Value = _totalHorasFeriado100;
                }
                else
                {
                    _totalHorasFeriado100 = Math.Round((Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colHExt"].Value) * Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colChExt"].Value)), 2);
                }

                dgvDetallesRol.Rows[rowIndex].Cells["colThExt"].Value = _totalHorasFeriado100.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colThExt"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _totalHorasFeriado100 = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colThExt"].Value = _totalHorasFeriado100.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colThExt"].Style.BackColor = Color.Red;
            }

            //  recargo nocturno
            try
            {
                if (cbxQuincena.SelectedIndex == 0)
                {
                    _recargoNocturno = 0;
                    dgvDetallesRol.Rows[rowIndex].Cells["colRecNocturno"].Value = _recargoNocturno;
                }
                else
                {
                    _recargoNocturno = Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colRecNocturno"].Value);
                }

                dgvDetallesRol.Rows[rowIndex].Cells["colRecNocturno"].Value = _recargoNocturno.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colRecNocturno"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _recargoNocturno = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colRecNocturno"].Value = _recargoNocturno.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colRecNocturno"].Style.BackColor = Color.Red;
            }

            //  recargo adicional
            try
            {
                _adicional = Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colAdicional"].Value);
                dgvDetallesRol.Rows[rowIndex].Cells["colAdicional"].Value = _adicional.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colAdicional"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _adicional = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colAdicional"].Value = _adicional.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colAdicional"].Style.BackColor = Color.Red;
            }

            //  otros ingresos 
            try
            {
                _otrosIngresos = Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colOtrosIng"].Value);
                dgvDetallesRol.Rows[rowIndex].Cells["colOtrosIng"].Value = _otrosIngresos.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colOtrosIng"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _otrosIngresos = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colOtrosIng"].Value = _otrosIngresos.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colOtrosIng"].Style.BackColor = Color.Red;
            }

            // ' total extra
            _totalExtras = _totalHoras + _totalHoras50 + _totalHoras100 + _totalHorasFeriado100 + _recargoNocturno + _adicional;
            dgvDetallesRol.Rows[rowIndex].Cells["colHoraExtra"].Value = _totalExtras.ToString("N");

            //  ingresos mas extra
            _sueldoMasExtras = _sueldoDiasTrabajadoDescansoMedico + _totalExtras;
            dgvDetallesRol.Rows[rowIndex].Cells["colIngresoMasExtra"].Value = _sueldoMasExtras.ToString("N");

            //  xiii
            try
            {
                if ((bool)dgvDetallesRol.Rows[rowIndex].Cells["colPagaXiii"].Value)
                {
                    if (cbxQuincena.SelectedIndex == 0) 
                    { 
                        _xiii = 0; 
                        //_auXiii = 0; 
                    }
                    else if ((bool)dgvDetallesRol.Rows[rowIndex].Cells["colXiiSe"].Value)
                    {
                        _xiii = Math.Round(((_sueldoMasExtras / 12) - _xiiiPorPension), 2);
                        //_auXiii = Math.Round(((_sueldoDiasTrabajadoDescansoMedico / 12) - _xiiiPorPension), 2);
                    }
                    else 
                    {
                        //_auXiii = 0;
                        _xiii = Math.Round(((_sueldoDiasTrabajadoDescansoMedico / 12) - _xiiiPorPension), 2);                        
                    }
                }
                else
                { 
                    _xiii = 0; 
                    //_auXiii = 0;
                }

                dgvDetallesRol.Rows[rowIndex].Cells["colXiii"].Value = _xiii.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colXiii"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _xiii = 0;
                //_auXiii = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colXiii"].Value = _xiii.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colXiii"].Style.BackColor = Color.Red;
            }

            //  xiii por pension
            try
            {
                if ((bool)dgvDetallesRol.Rows[rowIndex].Cells["colPagaXiii"].Value)
                {
                    if (cbxQuincena.SelectedIndex == 0)
                    {
                        //_auXiii = 0;
                        _xiiiPorPension = 0;
                    }
                    else
                    {
                        _xiiiPorPension = Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colXiiPension"].Value);
                        if (((bool)dgvDetallesRol.Rows[rowIndex].Cells["colXiiSe"].Value))
                        {
                            _xiii = Math.Round(((_sueldoMasExtras / 12) - _xiiiPorPension), 2);
                            //_auXiii = Math.Round(((_sueldoDiasTrabajadoDescansoMedico / 12) - _xiiiPorPension), 2);
                        }
                        else
                        {
                            //_auXiii = 0;
                            _xiii = Math.Round(((_sueldoDiasTrabajadoDescansoMedico / 12) - _xiiiPorPension), 2);
                        }
                    }
                }
                else 
                {
                    //_auXiii = 0;
                    _xiiiPorPension = 0; 
                }

                dgvDetallesRol.Rows[rowIndex].Cells["colXiii"].Value = _xiii.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colXiii"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
                dgvDetallesRol.Rows[rowIndex].Cells["colXiiPension"].Value = _xiiiPorPension.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colXiiPension"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _xiiiPorPension = 0;
                //_auXiii = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colXiiPension"].Value = _xiiiPorPension.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colXiiPension"].Style.BackColor = Color.Red;
            }

            //  xiv
            try
            {
                if ((bool)dgvDetallesRol.Rows[rowIndex].Cells["colPagaXiv"].Value)
                {
                    if (cbxQuincena.SelectedIndex == 0) _xiv = 0;
                    else
                    {
                        var x4 = ((Convert.ToDouble(_objRolParametrosRolPago.SueldoBasico) / 12 / 30) * (_diasTrabajados + _diasDescansoMedico));
                        _xiv = Math.Round((x4 - _xivPorPension), 2);
                    }
                }
                else _xiv = 0; 

                dgvDetallesRol.Rows[rowIndex].Cells["colXiv"].Value = _xiv.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colXiv"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _xiv = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colXiv"].Value = _xiv.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colXiv"].Style.BackColor = Color.Red;
            }

            //  xiv por pension
            try
            {
                if ((bool)dgvDetallesRol.Rows[rowIndex].Cells["colPagaXiv"].Value)
                {
                    if ((cbxQuincena.SelectedIndex == 0)) _xivPorPension = 0;
                    else
                    {
                        _xivPorPension = Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colXivPension"].Value);
                        var x4 = ((Convert.ToDouble(_objRolParametrosRolPago.SueldoBasico) / 12 / 30) * (_diasTrabajados + _diasDescansoMedico));
                        _xiv = Math.Round((x4 - _xivPorPension), 3);
                    }
                }
                else _xivPorPension = 0; 

                dgvDetallesRol.Rows[rowIndex].Cells["colXiv"].Value = _xiv.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colXiv"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
                dgvDetallesRol.Rows[rowIndex].Cells["colXivPension"].Value = _xivPorPension.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colXivPension"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _xiv = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colXiv"].Value = _xiv.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colXiv"].Style.BackColor = Color.Red;
            }

            //  fondo res
            try
            {
                if (cbxQuincena.SelectedIndex == 0)
                {
                    _fordoReserva = 0;
                    _acumfonres = 0;
                    //_auxFre = 0;
                }
                else if ((bool)dgvDetallesRol.Rows[rowIndex].Cells["colFonRes"].Value)
                {
                    if ((bool)dgvDetallesRol.Rows[rowIndex].Cells["colAcuFor"].Value)
                    {
                        _fordoReserva = 0;
                        //_auxFre = 0;
                        if ((bool)dgvDetallesRol.Rows[rowIndex].Cells["colXiiSe"].Value)
                        {
                            //_auxFre = 0;
                            _acumfonres =
                                   Math.Round(
                                       ((Convert.ToDouble(_objRolParametrosRolPago.PorcentajeFondoReserva) / 100) *
                                        _sueldoMasExtras), 2);
                        }
                        else
                        {
                            //_auxFre = 0;
                            _acumfonres =
                                Math.Round(
                                    ((Convert.ToDouble(_objRolParametrosRolPago.PorcentajeFondoReserva) / 100) *
                                     _sueldoDiasTrabajadoDescansoMedico), 2);
                        }
                    }
                    else
                    {
                        _acumfonres = 0;
                        //_auxFre = 0;
                        if ((bool)dgvDetallesRol.Rows[rowIndex].Cells["colXiiSe"].Value)
                        {
                            //_auxFre = Math.Round(
                            //        ((Convert.ToDouble(_objRolParametrosRolPago.PorcentajeFondoReserva) / 100) *
                            //         _sueldoDiasTrabajadoDescansoMedico), 2);
                            _fordoReserva =
                                   Math.Round(
                                       ((Convert.ToDouble(_objRolParametrosRolPago.PorcentajeFondoReserva) / 100) *
                                        _sueldoMasExtras), 2);
                        }
                        else
                        {
                            //_auxFre = 0;
                            _fordoReserva =
                                   Math.Round(
                                       ((Convert.ToDouble(_objRolParametrosRolPago.PorcentajeFondoReserva) / 100) *
                                        _sueldoDiasTrabajadoDescansoMedico), 2);
                        }
                    }

                }
                else
                {
                    _fordoReserva = 0;
                    _acumfonres = 0;
                    //_auxFre = 0;
                }

                dgvDetallesRol.Rows[rowIndex].Cells["colFondoRes"].Value = _fordoReserva.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colFondoRes"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;

                dgvDetallesRol.Rows[rowIndex].Cells["colAcumFondoRes"].Value = _acumfonres.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colAcumFondoRes"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _fordoReserva = 0;
                _acumfonres = 0;
                //_auxFre = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colFondoRes"].Value = _fordoReserva.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colFondoRes"].Style.BackColor = Color.Red;

                dgvDetallesRol.Rows[rowIndex].Cells["colAcumFondoRes"].Value = _acumfonres.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colAcumFondoRes"].Style.BackColor = Color.Red;
            }

            //  fondo res mes anterior
            try
            {
                _fordoReservaMesAnte = (cbxQuincena.SelectedIndex == 0) ? 0 : Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colFondoResAnt"].Value);

                dgvDetallesRol.Rows[rowIndex].Cells["colFondoResAnt"].Value = _fordoReservaMesAnte.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colFondoResAnt"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _fordoReservaMesAnte = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colFondoResAnt"].Value = _fordoReservaMesAnte.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colFondoResAnt"].Style.BackColor = Color.Red;
            }
          

            //  total beneficios
            _totalBeneficios = _xiii + _xiv + _fordoReserva + _fordoReservaMesAnte + _xiiiPorPension + _xivPorPension;
            dgvDetallesRol.Rows[rowIndex].Cells["colTotBenef"].Value = _totalBeneficios.ToString("N");

            //  total ingresos
            _totalIngresos = _sueldoMasExtras + _totalBeneficios + _otrosIngresos;
            dgvDetallesRol.Rows[rowIndex].Cells["colTotIngresos"].Value = _totalIngresos.ToString("N");
             

            // ' *********************************************** EGRESOSs
            //  descuento iess
            _descuentoIess = cbxQuincena.SelectedIndex == 1 ? Math.Round((_sueldoMasExtras * Convert.ToDouble(_objRolParametrosRolPago.PorcentajePersonalIess)) / 100, 2) : 0;
            dgvDetallesRol.Rows[rowIndex].Cells["colDescIess"].Value = _descuentoIess.ToString("N");

            //  descuento quincena anterior 
            try
            {
                _quincenaAnticipo = (cbxQuincena.SelectedIndex == 0) ? 0 : Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colDescQuinan"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colDescQuinan"].Value = _quincenaAnticipo.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDescQuinan"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _quincenaAnticipo = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colDescQuinan"].Value = _quincenaAnticipo.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDescQuinan"].Style.BackColor = Color.Red;
            }

            //  descuento prestamo quirografario 
            try
            {
                _prestamoQuirografario = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colDesQuiro"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colDesQuiro"].Value = _prestamoQuirografario.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDesQuiro"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _prestamoQuirografario = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colDesQuiro"].Value = _prestamoQuirografario.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDesQuiro"].Style.BackColor = Color.Red;
            }

            //  descuento prestamo hipotecario colDesHipo colExtSal colSaludConyu colAntiEmer colDesCapaseg colAntiVario
            try
            {
                _prestamoHipotecario = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colDesHipo"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colDesHipo"].Value = _prestamoHipotecario.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDesHipo"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _prestamoHipotecario = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colDesHipo"].Value = _prestamoHipotecario.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDesHipo"].Style.BackColor = Color.Red;
            }

            //  descuento salud conyuge 
            try
            { 
                if ((bool)dgvDetallesRol.Rows[rowIndex].Cells["colExtSal"].Value)
                {
                    _extensionSalud = cbxQuincena.SelectedIndex == 0 ? 0 :
                        Math.Round((_sueldoMasExtras * Convert.ToDouble(_objRolParametrosRolPago.PorcentajeExtensionSalud)) / 100, 2);
                }
                else _extensionSalud = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colSaludConyu"].Value = _extensionSalud.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colSaludConyu"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _extensionSalud = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colSaludConyu"].Value = _extensionSalud.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colSaludConyu"].Style.BackColor = Color.Red;
            }

            

            //  descuento anticipo emergente
            try
            {
                _anticipoEmergente = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colAntiEmer"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colAntiEmer"].Value = _anticipoEmergente.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colAntiEmer"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _anticipoEmergente = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colAntiEmer"].Value = _anticipoEmergente.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colAntiEmer"].Style.BackColor = Color.Red;
            }

            //  descuento capaseg
            try
            {
                _descuentoCapaseg = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colDesCapaseg"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colDesCapaseg"].Value = _descuentoCapaseg.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDesCapaseg"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _descuentoCapaseg = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colDesCapaseg"].Value = _descuentoCapaseg.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDesCapaseg"].Style.BackColor = Color.Red;
            }

            //  descuento anticipo varios 
            try
            {
                _anticiposVarios = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colAntiVario"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colAntiVario"].Value = _anticiposVarios.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colAntiVario"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _anticiposVarios = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colAntiVario"].Value = _anticiposVarios.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colAntiVario"].Style.BackColor = Color.Red;
            }

            //  descuento prestamo empresa colPrestEmpre colComecsa colComisariato colEquipoSeg colDesAlmuerzo colDesPension colViviana colMultasAtrasos colDiasNoLaborados ColDescDeci colOtrosDes
            try
            {
                _prestamoEmpresa = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colPrestEmpre"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colPrestEmpre"].Value = _prestamoEmpresa.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colPrestEmpre"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _prestamoEmpresa = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colPrestEmpre"].Value = _prestamoEmpresa.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colPrestEmpre"].Style.BackColor = Color.Red;
            }

            //  descuento comecsa 
            try
            {
                _descuenoComecsaFarm = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colComecsa"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colComecsa"].Value = _descuenoComecsaFarm.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colComecsa"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _descuenoComecsaFarm = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colComecsa"].Value = _descuenoComecsaFarm.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colComecsa"].Style.BackColor = Color.Red;
            }

            //  descuento comisariato 
            try
            {
                _descuentoComisariato = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colComisariato"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colComisariato"].Value = _descuentoComisariato.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colComisariato"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _descuentoComisariato = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colComisariato"].Value = _descuentoComisariato.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colComisariato"].Style.BackColor = Color.Red;
            }

            //  descuento equipo seguridad 
            try
            {
                //_descuentoEquipoSeguridad = (bool)dgvDetallesRol.Rows[rowIndex].Cells["colDesSeg"].Value ?
                //    Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colEquipoSeg"].Value), 2) : 0;
                _descuentoEquipoSeguridad = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colEquipoSeg"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colEquipoSeg"].Value = _descuentoEquipoSeguridad.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colEquipoSeg"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _descuentoEquipoSeguridad = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colEquipoSeg"].Value = _descuentoEquipoSeguridad.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colEquipoSeg"].Style.BackColor = Color.Red;
            }

            //  descuento almuerzos
            try
            {
                _descuentoAlmuerszos = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colDesAlmuerzo"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colDesAlmuerzo"].Value = _descuentoAlmuerszos.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDesAlmuerzo"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _descuentoAlmuerszos = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colDesAlmuerzo"].Value = _descuentoAlmuerszos.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDesAlmuerzo"].Style.BackColor = Color.Red;
            }

            //  descuento pension alimento
            try
            {
                _descuento10moPensionAlimento = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colDesPension"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colDesPension"].Value = _descuento10moPensionAlimento.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDesPension"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _descuento10moPensionAlimento = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colDesPension"].Value = _descuento10moPensionAlimento.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDesPension"].Style.BackColor = Color.Red;
            }

            //  descuento arriendo viviana
            try
            {
                _descuentoPensionAlimento = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colViviana"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colViviana"].Value = _descuentoPensionAlimento.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colViviana"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _descuentoPensionAlimento = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colViviana"].Value = _descuentoPensionAlimento.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colViviana"].Style.BackColor = Color.Red;
            }

            //  descuento multas y atrasos
            try
            {
                _multasYAtrasos = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colMultasAtrasos"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colMultasAtrasos"].Value = _multasYAtrasos.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colMultasAtrasos"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _multasYAtrasos = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colMultasAtrasos"].Value = _multasYAtrasos.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colMultasAtrasos"].Style.BackColor = Color.Red;
            }

            //  descuento dias no laborados
            try
            {
                _descdiasnolaborados = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colDiasNoLaborados"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colDiasNoLaborados"].Value = _descdiasnolaborados.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colDiasNoLaborados"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _descdiasnolaborados = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colMultasAtrasos"].Value = _descdiasnolaborados.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colMultasAtrasos"].Style.BackColor = Color.Red;
            }

            //  descuento dif decim ext fonres - DESC. VARIOS
            try
            {                
                //if (_sitiosNoDiferenciaDecimosExtra.Contains(dgvDetallesRol.Rows[rowIndex].Cells["GRP"].Value.ToString().Trim())) _descDiferenciaDecimoFondo = 0;
                //else
                //{
                //    if ((bool)dgvDetallesRol.Rows[rowIndex].Cells["colXiiSe"].Value)
                //    {
                //        if ((bool)dgvDetallesRol.Rows[rowIndex].Cells["colAcuFor"].Value) _descDiferenciaDecimoFondo = (_xiii - _auXiii);
                //        else _descDiferenciaDecimoFondo = (_xiii - _auXiii) + (_fordoReserva - _auxFre);
                //    }
                //    else _descDiferenciaDecimoFondo = 0;
                //}
                _descDiferenciaDecimoFondo = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["ColDescDeci"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["ColDescDeci"].Value = _descDiferenciaDecimoFondo.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["ColDescDeci"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _descDiferenciaDecimoFondo = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["ColDescDeci"].Value = _descDiferenciaDecimoFondo.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["ColDescDeci"].Style.BackColor = Color.Red;
            }

            //  descuento otros
            try
            {
                _otrosDescuentos = Math.Round(Convert.ToDouble(dgvDetallesRol.Rows[rowIndex].Cells["colOtrosDes"].Value), 2);
                dgvDetallesRol.Rows[rowIndex].Cells["colOtrosDes"].Value = _otrosDescuentos.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colOtrosDes"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _otrosDescuentos = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colOtrosDes"].Value = _otrosDescuentos.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colOtrosDes"].Style.BackColor = Color.Red;
            }

            //  total egresos
            try
            {
                _totalDescuentos = _descuentoIess
                            + _quincenaAnticipo
                            + _prestamoQuirografario
                            + _prestamoHipotecario
                            + _extensionSalud
                            + _anticipoEmergente
                            + _descuentoCapaseg
                            + _anticiposVarios
                            + _prestamoEmpresa
                            + _descuenoComecsaFarm
                            + _descuentoComisariato
                            + _descuentoEquipoSeguridad
                            + _descuentoAlmuerszos
                            + _descuento10moPensionAlimento
                            + _descuentoPensionAlimento
                            + _multasYAtrasos 
                            + _descdiasnolaborados
                            + _otrosDescuentos
                            + _descDiferenciaDecimoFondo;
                dgvDetallesRol.Rows[rowIndex].Cells["colTotalDesc"].Value = _totalDescuentos.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colTotalDesc"].Style.BackColor = dgvDetallesRol.Rows[rowIndex].Cells[0].Style.BackColor;
            }
            catch
            {
                _totalDescuentos = 0;
                dgvDetallesRol.Rows[rowIndex].Cells["colTotalDesc"].Value = _totalDescuentos.ToString("N");
                dgvDetallesRol.Rows[rowIndex].Cells["colTotalDesc"].Style.BackColor = Color.Red;
            }

            _netorecibir = (_totalIngresos - _totalDescuentos);
            dgvDetallesRol.Rows[rowIndex].Cells["colNetoRecibir"].Value = _netorecibir.ToString("N");

        }

        private void SumatoriasRol()
        {
            var grupos = _objetoSitio.SeleccionarGruposSitios(TipoCon, false, true, true);
            var ing = 0.0;
            var des = 0.0;
            var tot = 0.0;

            var afra = 0.0;
            var afro = 0.0;

            foreach (DataRow grupo in grupos.Rows)
            {
                var sbu = 0.0;

                var sbud = 0.0;
                var sbdm = 0.0;
                var stdm = 0.0;

                var sth = 0.0;
                var sth50 = 0.0;
                var sth100 = 0.0;
                var sth100F = 0.0;
                var srecnoc = 0.0;
                var sadicio = 0.0;
                var soting = 0.0;
                var stotex = 0.0;
                var singext = 0.0;
                var sxiii = 0.0;
                var sxiiipen = 0.0;
                var sxiv = 0.0;
                var sxivpen = 0.0;
                var sfonres = 0.0;
                var sfonresa = 0.0;
                var stotben = 0.0;
                var stoting = 0.0;

                var sdesies = 0.0;
                var sdesquince = 0.0;
                var sdesquiro = 0.0;
                var sdeshipo = 0.0;
                var sdesexsal = 0.0;
                var sdesemer = 0.0;
                var sdescapa = 0.0;
                var sdesvario = 0.0;
                var sdesempre = 0.0;
                var sdescomec = 0.0;
                var sdescomis = 0.0;
                var sdesequip = 0.0;
                var sdesalmu = 0.0;
                var sdes10pension = 0.0;
                var sdesPension = 0.0;
                var sdesmultas = 0.0;
                var sdesdiasnolab = 0.0;
                var sdesdifdecf = 0.0;
                var sdesotros = 0.0;
                var sdestotal = 0.0;

                var sneto = 0.0;


                var colAcumFondoRes = 0.0; 
                 
                foreach (DataGridViewRow row in dgvDetallesRol.Rows)
                {
                    if (row.Cells[0].Value == null) continue;

                    if (row.Cells[0].Value.ToString().Trim().Equals(grupo[0].ToString().Trim()))
                    {
                        if ((row.Cells[3].Value + "").Equals("TOTAL GRUPO " + row.Cells[0].Value))
                        {
                            row.Cells[12].Value = sbu.ToString("N");
                            row.Cells[14].Value = sbud.ToString("N");
                            row.Cells[16].Value = sbdm.ToString("N");
                            row.Cells[17].Value = stdm.ToString("N");
                            row.Cells[20].Value = sth.ToString("N");
                            row.Cells[23].Value = sth50.ToString("N");
                            row.Cells[26].Value = sth100.ToString("N");
                            row.Cells[29].Value = sth100F.ToString("N");
                            row.Cells[30].Value = srecnoc.ToString("N");
                            row.Cells[31].Value = sadicio.ToString("N");
                            row.Cells[32].Value = soting.ToString("N");
                            row.Cells[33].Value = stotex.ToString("N");
                            row.Cells[34].Value = singext.ToString("N");
                            row.Cells[35].Value = sxiii.ToString("N");
                            row.Cells[36].Value = sxiiipen.ToString("N");
                            row.Cells[37].Value = sxiv.ToString("N");
                            row.Cells[38].Value = sxivpen.ToString("N");
                            row.Cells[39].Value = sfonres.ToString("N");
                            row.Cells[40].Value = sfonresa.ToString("N");
                            row.Cells[41].Value = stotben.ToString("N");
                            row.Cells[42].Value = stoting.ToString("N");
                            // 43 es espacios
                            row.Cells[44].Value = sdesies.ToString("N");
                            row.Cells[45].Value = sdesquince.ToString("N");
                            row.Cells[46].Value = sdesquiro.ToString("N");
                            row.Cells[47].Value = sdeshipo.ToString("N");
                            row.Cells[48].Value = sdesexsal.ToString("N");
                            row.Cells[49].Value = sdesemer.ToString("N");
                            row.Cells[50].Value = sdescapa.ToString("N");
                            row.Cells[51].Value = sdesvario.ToString("N");
                            row.Cells[52].Value = sdesempre.ToString("N");
                            row.Cells[53].Value = sdescomec.ToString("N");
                            row.Cells[54].Value = sdescomis.ToString("N");
                            row.Cells[55].Value = sdesequip.ToString("N");
                            row.Cells[56].Value = sdesalmu.ToString("N");
                            row.Cells[57].Value = sdes10pension.ToString("N");
                            row.Cells[58].Value = sdesPension.ToString("N");
                            row.Cells[59].Value = sdesmultas.ToString("N");
                            row.Cells[60].Value = sdesdiasnolab.ToString("N");
                            row.Cells[61].Value = sdesdifdecf.ToString("N");
                            row.Cells[62].Value = sdesotros.ToString("N");
                            row.Cells[63].Value = sdestotal.ToString("N");
                            row.Cells[64].Value = sneto.ToString("N");
                            row.Cells[77].Value = colAcumFondoRes.ToString("N");

                            ing += stoting;
                            des += sdestotal;
                            tot += sneto;

                            if ((row.Cells[0].Value + "").Equals("ADMINISTRATIVO")) afra = Convert.ToDouble(row.Cells[77].Value);
                            else afro += Convert.ToDouble(row.Cells[77].Value);

                            break;
                        }

                        sbu += Math.Round(Convert.ToDouble(row.Cells[12].Value), 2);
                        sbud += Math.Round(Convert.ToDouble(row.Cells[14].Value), 2);
                        sbdm += Math.Round(Convert.ToDouble(row.Cells[16].Value), 2);
                        stdm += Math.Round(Convert.ToDouble(row.Cells[17].Value), 2);
                        sth += Math.Round(Convert.ToDouble(row.Cells[20].Value), 2);
                        sth50 += Math.Round(Convert.ToDouble(row.Cells[23].Value), 2);
                        sth100 += Math.Round(Convert.ToDouble(row.Cells[26].Value), 2);
                        sth100F += Math.Round(Convert.ToDouble(row.Cells[29].Value), 2);
                        srecnoc += Math.Round(Convert.ToDouble(row.Cells[30].Value), 2);
                        sadicio += Math.Round(Convert.ToDouble(row.Cells[31].Value), 2);
                        soting += Math.Round(Convert.ToDouble(row.Cells[32].Value), 2);
                        stotex += Math.Round(Convert.ToDouble(row.Cells[33].Value), 2);
                        singext += Math.Round(Convert.ToDouble(row.Cells[34].Value), 2);
                        sxiii += Math.Round(Convert.ToDouble(row.Cells[35].Value), 2);
                        sxiiipen += Math.Round(Convert.ToDouble(row.Cells[36].Value), 2);
                        sxiv += Math.Round(Convert.ToDouble(row.Cells[37].Value), 2);
                        sxivpen += Math.Round(Convert.ToDouble(row.Cells[38].Value), 2);
                        sfonres += Math.Round(Convert.ToDouble(row.Cells[39].Value), 2);
                        sfonresa += Math.Round(Convert.ToDouble(row.Cells[40].Value), 2);
                        stotben += Math.Round(Convert.ToDouble(row.Cells[41].Value), 2);
                        stoting += Math.Round(Convert.ToDouble(row.Cells[42].Value), 2);

                        sdesies += Math.Round(Convert.ToDouble(row.Cells[44].Value), 2);
                        sdesquince += Math.Round(Convert.ToDouble(row.Cells[45].Value), 2);
                        sdesquiro += Math.Round(Convert.ToDouble(row.Cells[46].Value), 2);
                        sdeshipo += Math.Round(Convert.ToDouble(row.Cells[47].Value), 2);
                        sdesexsal += Math.Round(Convert.ToDouble(row.Cells[48].Value), 2);
                        sdesemer += Math.Round(Convert.ToDouble(row.Cells[49].Value), 2);
                        sdescapa += Math.Round(Convert.ToDouble(row.Cells[50].Value), 2);
                        sdesvario += Math.Round(Convert.ToDouble(row.Cells[51].Value), 2);
                        sdesempre += Math.Round(Convert.ToDouble(row.Cells[52].Value), 2);
                        sdescomec += Math.Round(Convert.ToDouble(row.Cells[53].Value), 2);
                        sdescomis += Math.Round(Convert.ToDouble(row.Cells[54].Value), 2);
                        sdesequip += Math.Round(Convert.ToDouble(row.Cells[55].Value), 2);
                        sdesalmu += Math.Round(Convert.ToDouble(row.Cells[56].Value), 2);
                        sdes10pension += Math.Round(Convert.ToDouble(row.Cells[57].Value), 2);
                        sdesPension += Math.Round(Convert.ToDouble(row.Cells[58].Value), 2);
                        sdesmultas += Math.Round(Convert.ToDouble(row.Cells[59].Value), 2);
                        sdesdiasnolab += Math.Round(Convert.ToDouble(row.Cells[60].Value), 2);
                        sdesdifdecf += Math.Round(Convert.ToDouble(row.Cells[61].Value), 2);
                        sdesotros += Math.Round(Convert.ToDouble(row.Cells[62].Value), 2);
                        sdestotal += Math.Round(Convert.ToDouble(row.Cells[63].Value), 2);

                        sneto += Math.Round(Convert.ToDouble(row.Cells[64].Value), 2);
                        colAcumFondoRes += Math.Round(Convert.ToDouble(row.Cells[77].Value), 2); 
                    }
                }
            }

            txtTotIngresos.Text = ing.ToString("N");
            txtTotDescuentos.Text = des.ToString("N");
            txtTotCobrar.Text = tot.ToString("N");

            txtAcfoAd.Text = afra.ToString("N");
            txtAcfoOp.Text = afro.ToString("N");
            txtAcfonRes.Text = (afra + afro).ToString("N");
        }

        private double CalcularMensualPorDias(double sueldo, int dias)
        {
            return Math.Round((sueldo / 30) * dias, 2);
        }

        private double CalcularMensualPorDescansoMedico(double sueldo, int dias)
        {
            return Math.Round(((sueldo / 30) * dias) * _objRolParametrosRolPago.PorcentajeDescansoMedico, 2);
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (TextBox1.Text.Trim().Length == 0)
            {
                _indices.Clear();
                btnAnt.Tag = 0;
                btnSig.Tag = 0;
                if (dgvDetallesRol.RowCount > 0)
                {
                    dgvDetallesRol.Rows[0].Selected = true;
                    dgvDetallesRol.FirstDisplayedScrollingRowIndex = 0;
                }
                Label16.Text = String.Empty;
                return;
            }

            if ((e.KeyCode != Keys.Enter) || (dgvDetallesRol.RowCount == 0)) return;
            _indices.Clear();

            foreach (var row in dgvDetallesRol.Rows.Cast<DataGridViewRow>().Where(row =>
                (row.Cells[3].Value + "").Trim().Contains(TextBox1.Text.Trim()) ||
                (row.Cells[4].Value + "").Trim().Contains(TextBox1.Text.Trim()) ||
                (row.Cells[5].Value + "").Trim().Contains(TextBox1.Text.Trim()) ||
                (row.Cells[6].Value + "").Trim().Contains(TextBox1.Text.Trim())))
            {
                _indices.Add(row.Index);
            }

            if (_indices.Count == 0)
            {
                btnAnt.Tag = 0;
                btnSig.Tag = 0;
                dgvDetallesRol.Rows[0].Selected = true;
                dgvDetallesRol.FirstDisplayedScrollingRowIndex = 0;
                Label16.Text = @"No hay coincidencias...";
            }
            else
            {
                btnAnt.Tag = 0;
                btnSig.Tag = _indices.Count > 0 ? 1 : 0;
                dgvDetallesRol.Rows[_indices[0]].Selected = true;
                dgvDetallesRol.FirstDisplayedScrollingRowIndex = _indices[0];

                Label16.Text = (@"1 de " + _indices.Count + @" resultado(s)...");
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if ((_indices.Count == 0) || dgvDetallesRol.RowCount == 0) return;
            if (Convert.ToInt32(btnAnt.Tag) < 0) return;

            dgvDetallesRol.Rows[_indices[Convert.ToInt32(btnAnt.Tag)]].Selected = true;
            dgvDetallesRol.FirstDisplayedScrollingRowIndex = _indices[Convert.ToInt32(btnAnt.Tag)];

            Label16.Text = (Convert.ToInt32(btnAnt.Tag) + 1) + @"  de " + _indices.Count + @" resultado(s)...";

            btnSig.Tag = Convert.ToInt32(btnAnt.Tag) + 1;
            btnAnt.Tag = Convert.ToInt32(btnAnt.Tag) - 1;
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if ((_indices.Count == 0) || (dgvDetallesRol.RowCount == 0)) return;
            if (Convert.ToInt32(btnSig.Tag) > _indices.Count - 1) return;

            dgvDetallesRol.Rows[_indices[Convert.ToInt32(btnSig.Tag)]].Selected = true;
            dgvDetallesRol.FirstDisplayedScrollingRowIndex = _indices[Convert.ToInt32(btnSig.Tag)];

            Label16.Text = (Convert.ToInt32(btnSig.Tag) + 1) + @"  de " + _indices.Count + @" resultado(s)...";

            if (Convert.ToInt32(btnSig.Tag) >= _indices.Count) return;
            btnAnt.Tag = Convert.ToInt32(btnSig.Tag) - 1;
            btnSig.Tag = (Convert.ToInt32(btnSig.Tag) + 1);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetallesRol.CurrentRow == null) return;
            if (dgvDetallesRol.RowCount == 0 || dgvDetallesRol.SelectedRows.Count == 0) return;

            if (dgvDetallesRol.SelectedRows[0].Cells[1].Value == null || dgvDetallesRol.SelectedRows[0].Cells[1].Value.ToString().Trim().Length == 0) return;
            if (Convert.ToInt32(dgvDetallesRol.SelectedRows[0].Cells[1].Value) == 0) return;

            if (KryptonMessageBox.Show(@"Seguro que desea quitar este registro", "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo,
                    KryptonMessageBoxIcon.Question) != DialogResult.Yes) return;

            var i = dgvDetallesRol.SelectedRows[0].Index;
            var n = Convert.ToInt32(dgvDetallesRol.SelectedRows[0].Cells[2].Value);

            dgvDetallesRol.Rows.RemoveAt(i);

            dgvDetallesRol.Refresh();

            ReajusarIndice(i, n);

            SumatoriasRol();

            _cantRol -= 1;
            Label14.Text = @"DETALLES GENERALES ROL DE PAGO - " + _cantRol + @" REGISTRO(S) EN TOTAL";
        }

        private void ReajusarIndice(int i, int n)
        {
            for (var x = i; x <= dgvDetallesRol.Rows.Count - 1; x++)
            {
                if ((dgvDetallesRol.Rows[x].Cells[2].Value + "").Trim().Length == 0) continue;
                if (Convert.ToInt32(dgvDetallesRol.Rows[x].Cells[2].Value) == 0) continue;
                dgvDetallesRol.Rows[x].Cells[2].Value = n;
                n++;
            }
        }

        private void dgvInformePago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInformePago.CurrentRow == null) return;
            if (_estado == 0 || dgvInformePago.RowCount == 0 || dgvInformePago.SelectedRows.Count == 0) return;
            btnRetener.PerformClick();
        }

        private void btnRetener_Click(object sender, EventArgs e)
        {
            if (dgvInformePago.CurrentRow == null) return;
            var retenidos = string.Empty;

            if ((dgvInformePago.CurrentRow.Cells[5].Tag + "").Trim().Length == 0)
            {
                if ((KryptonMessageBox.Show(@"Seguro que desa marcar a " + dgvInformePago.CurrentRow.Cells[5].Value + @" como retenido?", "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes))
                    return;
                dgvInformePago.CurrentRow.Cells[5].Tag = "R";
                dgvInformePago.CurrentRow.Cells[5].Style.BackColor = Color.DarkOrange;
            }
            else
            {
                if ((KryptonMessageBox.Show(dgvInformePago.CurrentRow.Cells[5].Value + @" consta como retenido, desea marcarlo como habilitado para informe de pago?", "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes))
                    return;
                dgvInformePago.CurrentRow.Cells[5].Style.BackColor = dgvInformePago.CurrentRow.Cells[0].Style.BackColor;
                dgvInformePago.CurrentRow.Cells[5].Tag = null;
            }

            retenidos = dgvInformePago.Rows.Cast<DataGridViewRow>().Where(row => (row.Cells[5].Tag + "").Trim().Length != 0).Aggregate(retenidos, (current, row) => current + (row.Cells[1].Value + ";"));

            _sqlCommands.Clear();
            _objRolPago.IdRol = Convert.ToInt32(lblIdRol.Text.Trim());
            _objRolPago.Retenidos = retenidos;
            _sqlCommands.Add(_objRolPago.GuardarRetenidosRolPagoCommand());

            var user = Usuario.Datos.ToString();
            var nombre = $"ROL DETENIDO: {user}";
            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombre);
            if ((bool)res[0]) return;

            dgvInformePago.CurrentRow.Cells[5].Style.BackColor = dgvInformePago.CurrentRow.Cells[0].Style.BackColor;
            dgvInformePago.CurrentRow.Cells[5].Tag = null;
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            if (cbxQuincena.SelectedIndex == 0)
            {
                KryptonMessageBox.Show(@"INGRESOS / DESCUENTOS no está habilitado en los pagos de quincena!!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            // descuentos
            var ingdes = _objRolPago.SeleccionarDetallesDescuentosPersonalRolPago(TipoCon, dtpMesAnio.Value.Month, dtpMesAnio.Value.Year, cbxTipo.SelectedIndex == 0 ? 2 : 1);
            foreach (DataGridViewRow row in dgvDetallesRol.Rows)
            {
                if ((row.Cells[1].Value + "").Trim().Length == 0) continue;
                if (Convert.ToInt32(row.Cells[1].Value) == 0) continue;

                foreach (DataRow fil in ingdes.Rows)
                {
                    if (Convert.ToInt32(row.Cells[1].Value) == Convert.ToInt32(fil[0]))
                    {
                        row.Cells[46].Value = fil[2]; //  quirografario
                        row.Cells[47].Value = fil[4]; //  hipotecario
                        row.Cells[48].Value = fil[5]; //  saludconyuge
                        row.Cells[49].Value = fil[6]; //  emergente
                        row.Cells[50].Value = fil[7]; //  capaseg
                        row.Cells[51].Value = fil[8]; //  varios
                        row.Cells[52].Value = fil[9]; //  empresa
                        row.Cells[53].Value = fil[10];//  comecsa
                        row.Cells[54].Value = fil[11];//  comisariato
                        row.Cells[55].Value = fil[12];//  bodegaseg
                        row.Cells[56].Value = fil[18];  //  almuerzo
                        row.Cells[57].Value = Convert.ToDouble(fil[16]) + Convert.ToDouble(fil[17]);  //  10mspension xiii + x1v
                        row.Cells[58].Value = fil[15];  //  pension (arriendo vivi) 
                        row.Cells[59].Value = fil[13];  //  multas 
                        row.Cells[60].Value = fil[19];  //  diasnolab   
                        //  difdecfon
                        if (cbxQuincena.SelectedIndex == 1)
                        {
                            row.Cells[62].Value = (cbxTipo.SelectedIndex == 1 ? _objRolParametrosRolPago.OtrosDescuentosAdmin :
                                _objRolParametrosRolPago.OtrosDescuentosOperativos) + Convert.ToDouble(fil[14]); // otros                             
                        }
                        else row.Cells[62].Value = fil[14]; // otros

                        CalcularDatosFilaRol(row.Index);
                    }
                }
            }

            // quincenas
            var quicenas = _objRolPago.SeleccionarDetallesQuincenaPersonalRolPago(TipoCon, dtpMesAnio.Value.Month, dtpMesAnio.Value.Year, cbxTipo.SelectedIndex);
            foreach (DataGridViewRow row in dgvDetallesRol.Rows)
            {
                if ((row.Cells[1].Value + "").Trim().Length == 0) continue;
                if (Convert.ToInt32(row.Cells[1].Value) == 0) continue;

                foreach (DataRow fil in quicenas.Rows)
                {
                    if (Convert.ToInt32(row.Cells[1].Value) == Convert.ToInt32(fil[0]))
                    {
                        row.Cells[45].Value = fil[1]; //  quincena 
                        CalcularDatosFilaRol(row.Index);
                    }
                }
            }

            SumatoriasRol();
        }

        private List<string> _cuentas;
        private bool _rep;
        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (dgvDetallesRol.RowCount == 0) return;

            dgvInformePago.Rows.Clear();
            _cuentas.Clear();
            _rep = false;
             
            // BANCOS
            var bancos = _objBancos.SeleccionarRegistrosBancosRolesDict(TipoCon);
            if (bancos.Count == 0)
            {
                KryptonMessageBox.Show(@"No se ha cargado la información de los bancos. Por favor, contácte al administrador!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow row in dgvDetallesRol.Rows)
            {
                if (((row.Cells[1].Value + "").Trim().Length == 0)) row.Cells[1].Value = 0;
                if ((Convert.ToInt32(row.Cells[1].Value) != 0))
                { 
                    if ((row.Cells[74].Value + "").Trim().Length == 0) continue;
                    if (_cuentas.Contains(row.Cells[74].Value.ToString()))
                    {
                        _cuentas.Add(row.Cells[74].Value + " | " + row.Cells[5].Value);
                        _rep = true;
                    }
                    else _cuentas.Add(row.Cells[74].Value.ToString()); 
                }
                if ((row.Cells[0].Value + "").Trim().Length == 0) row.Cells[0].Value = "";
                if ((row.Cells[3].Value + "").Trim().Length == 0) row.Cells[3].Value = "";
            }

            var grupos = new DataTable();
            grupos.Columns.Add("grupo");

            if (cbxTipo.SelectedIndex == 1)
            {
                grupos.Clear();
                grupos.Rows.Add("ADMINISTRATIVO");
            }
            else
            {
                if (cbxGrupo.Text.Trim().Equals("GENERAL"))
                {
                    grupos.Rows.Add("GENERAL");
                    grupos.Rows.Add("RETIRADOS");
                }
                else grupos.Rows.Add(cbxGrupo.Text.Trim());
            }

            var f = 1;
            var ti = 0.0;

            var tgr = (btnResumen.Tag + "").Trim();
            tgr = tgr.EndsWith(";") ? tgr.Substring(0, tgr.Length - 1) : tgr;

            var tbg = 0;
            var tbm = 0;
            var tbp = 0;
            var tbc = 0;
            var tbret = 0;

            if (dgvInformePago.Columns["DataGridViewTextBoxColumn173"] != null) dgvInformePago.Columns["DataGridViewTextBoxColumn173"].DefaultCellStyle.Format = "d";
            if (dgvInformePago.Columns["Column14"] != null) dgvInformePago.Columns["Column14"].DefaultCellStyle.Format = "d";

            foreach (DataRow grupo in grupos.Rows)
            {
                foreach (DataGridViewRow row in dgvDetallesRol.Rows)
                {
                    if (cbxQuincena.SelectedIndex == 1 && !row.Cells[0].Value.ToString().Trim().Equals(grupo[0].ToString().Trim())) continue;

                    if (Convert.ToInt32(row.Cells[1].Value) != 0)
                    {
                        
                        dgvInformePago.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, f, row.Cells[3].Value, row.Cells[4].Value,
                            row.Cells[5].Value.ToString().Replace("Ñ", "N"), row.Cells[6].Value,
                            Convert.ToDateTime(row.Cells[7].Value).ToShortDateString(), //  row.Cells[8].Value se quita cuidad
                            row.Cells[9].Value, row.Cells[10].Value, row.Cells[11].Value, row.Cells[64].Value, 
                            
                            row.Cells[72].Value, row.Cells[73].Value, row.Cells[74].Value, row.Cells[75].Value, 

                            row.Cells[76].Value, bancos[row.Cells[72].Value.ToString()]);


                        // retenidos
                        if (tgr.Length > 0)
                        {
                            if (tgr.Split(';').Contains((row.Cells[1].Value + "").Trim()))
                            {
                                dgvInformePago.Rows[(dgvInformePago.RowCount - 1)].Cells[5].Style.BackColor = Color.DarkOrange;
                                dgvInformePago.Rows[(dgvInformePago.RowCount - 1)].Cells[5].Tag = "R";
                                tbret++;
                            }
                        }

                        // cheque
                        if (Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[12].Value) == 0 || Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[16].Value) == 0)
                        {
                            if (Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[1].Value) > 0)
                            {
                                if ((dgvInformePago.Rows[(dgvInformePago.RowCount - 1)].Cells[5].Tag + "").Trim().Length == 0)
                                    tbc++;
                            }
                        }

                        // general
                        if (Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[12].Value) == 1 && Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[16].Value) == 1)
                        { 
                            if ((dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[5].Tag + "").Trim().Length == 0) tbm += 1;
                        }

                        // BANCO PICHINCA
                        if (Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[12].Value) == 2 && Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[16].Value) == 1) 
                        {
                            if ((dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[5].Tag + "").Trim().Length == 0) tbp++;
                        }

                        // interbancario
                        if (Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[12].Value) > 2 && Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[16].Value) == 1)
                        {                            
                            if ((dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[5].Tag + "").Trim().Length == 0) tbg += 1;
                        }
                        

                        ti += Convert.ToDouble(row.Cells[64].Value);
                        f++;
                    }

                    if ((row.Cells[71].Value + "").Trim().Length == 0) row.Cells[71].Value = 0;
                }
            }

            dgvInformePago.Rows.Add(string.Empty, string.Empty, string.Empty, "TOTAL INFORME DE PAGO GENERAL", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                string.Empty, string.Empty, ti.ToString("N"), string.Empty, string.Empty, string.Empty, string.Empty);

            dgvInformePago.Rows[(dgvInformePago.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgvInformePago.AutoResizeRows();
            dgvInformePago.ReadOnly = true;

            txtInfCant.Text = (tbg + tbm + tbp + tbc + tbret) + "";
            txtInfGen.Text = tbm + "";

            txtInfPbm.Text = tbg  + "";

            txtInfBp.Text = tbp + "";
            txtInfCh.Text = tbc + "";
            
            txtInfRe.Text = tbret + "";

            txtInfTotal.Text = @"$ " + ti.ToString("N");

            if (_rep)
            { 
                var cad = _cuentas.Where(cuenta => cuenta.Contains("|")).Aggregate(string.Empty, (current, cuenta) => current + (cuenta + "\n"));
                KryptonMessageBox.Show(@"Las siguientes cuentas están repetidas!!\n" + cad, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
            }

            btnRetener.Enabled = true;
            btnInformePago.Enabled = true;
            btnBizPichincha.Enabled = true;
            btnBizGenral.Enabled = true; 
        }

        private void btnBizGenral_Click(object sender, EventArgs e)
        {
            if (_rep)
            {
                KryptonMessageBox.Show(@"NO SE PUEDE EXPORTAR DEBIDO A QUE EXISTEN CUENTAS REPETIDAS! POR FAVOR, REALICE LA VERIFICACIÓN DE LAS CUENTAS", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            if (dgvInformePago.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var fec = DateTime.Now;
                var sfd = new SaveFileDialog
                {
                    Filter = @"All Files (*.*)|*.*",
                    FileName = ("MACH_" + fec.Year + fec.Month + fec.Day + "_" + fec.Hour + fec.Minute + "_" + cbxTipo.Text.Trim() + ".txt"),
                    Tag = ("MACH_" + fec.Year + fec.Month + fec.Day + "_" + fec.Hour + fec.Minute + ".txt")
                };

                if (sfd.ShowDialog() != DialogResult.OK) return;
                if (!sfd.FileName.EndsWith(".txt")) sfd.FileName += ".txt";

                if (File.Exists(sfd.FileName) == false) File.Create(sfd.FileName).Dispose();

                var objWriter = new StreamWriter(sfd.FileName, true);

                foreach (DataGridViewRow row in dgvInformePago.Rows)
                {
                    if ((row.Cells[5].Tag + "").Trim() == "R") continue; // NO A LOS RETENIDOS
                    if ((row.Cells[1].Value + "").Trim().Length == 0) continue; // NO FILAS VACIAS
                    if (Convert.ToInt32(row.Cells[1].Value) == 0) continue;

                    if ((row.Cells[13].Value + "").Trim().Length == 0) continue; // SOLO CON CUENTAS BANCARIAS

                    //if (Convert.ToInt32(row.Cells[13].Value) == 0 || Convert.ToInt32(row.Cells[13].Value) == 2) continue; // A TODOS MENOS BANCO PICHINCHA
                    if (Convert.ToInt32(row.Cells[12].Value) != 1) continue; // SOLO BANCO MACHALA

                    if (Convert.ToInt32(row.Cells[16].Value) == 0) continue; // SOLO ACTIVOS
                   
                    
                    objWriter.WriteLine(
                        "DET" +
                        CompletarConCero(row.Index + "", 7, true) +
                        CompletarConEspacio(row.Cells[6].Value.ToString(), 15, false) +
                        (Convert.ToInt32(row.Cells[12].Value) == 1 ? "CU" : "CO") + // CU - BM; CO - INTERBANCARIO
                        CompletarConEspacio("EC", 3, false) +
                        CompletarConEspacio(row.Cells[17].Value.ToString(), 3, false) +
                        ((row.Cells[16].Value + "").Trim().Equals("AHO") ? "10" : "00") +
                        CompletarConEspacio(row.Cells[14].Value.ToString(), 20, false) +
                        "00" +
                        "00" +
                        CompletarConEspacio(row.Cells[5].Value.ToString().Replace("Ñ", "N"), 40, false) +
                        CompletarConEspacio(row.Cells[6].Value.ToString(), 40, false) +
                        "C" +
                        "00000" +
                        "000000" +
                        "000000" +
                        "00000000" +
                        "0000" +
                        CompletarConCero(row.Cells[11].Value.ToString().Replace(".", ""), 15, true) +
                        "USD" +
                        CompletarConEspacio(row.Cells[5].Value.ToString().Replace("Ñ", "N"), 40, false) +
                        "C" +
                        CompletarConEspacio(row.Cells[6].Value.ToString(), 10, false) +
                        CompletarConEspacio("", 154, false) +
                        (TipoCon == TipoConexion.Cisepro ? "00652" : TipoCon == TipoConexion.Seportpac ? "05839" : string.Empty));


                }
                objWriter.Close();
                KryptonMessageBox.Show(@"Archivo generado correctamente", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void btnBizMachala_Click(object sender, EventArgs e)
        {
            if (_rep)
            {
                KryptonMessageBox.Show(@"NO SE PUEDE EXPORTAR DEBIDO A QUE EXISTEN CUENTAS REPETIDAS! POR FAVOR, REALICE LA VERIFICACIÓN DE LAS CUENTAS", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
            if (dgvInformePago.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var fec = DateTime.Now;
                var sfd = new SaveFileDialog
                {
                    Filter = @"All Files (*.*)|*.*",
                    FileName = ("MACH_" + fec.Year + fec.Month + fec.Day + "_" + fec.Hour + fec.Minute + "_" + cbxTipo.Text.Trim() + ".txt"),
                    Tag = ("MACH_" + fec.Year + fec.Month + fec.Day + "_" + fec.Hour + fec.Minute + ".txt")
                };

                if (sfd.ShowDialog() != DialogResult.OK) return;
                if (!sfd.FileName.EndsWith(".txt")) sfd.FileName += ".txt";
                if (File.Exists(sfd.FileName) == false) File.Create(sfd.FileName).Dispose();

                var objWriter = new StreamWriter(sfd.FileName, true);

                foreach (DataGridViewRow row in dgvInformePago.Rows)
                {
                    if ((row.Cells[5].Tag + "").Trim() == "R") continue;
                    if ((row.Cells[1].Value + "").Trim().Length == 0) continue;
                    if (Convert.ToInt32(row.Cells[1].Value) == 0) continue;
                    if ((row.Cells[13].Value + "").Trim().Length == 0) continue;
                    if (Convert.ToInt32(row.Cells[13].Value) != 1) continue;
                    if (Convert.ToInt32(row.Cells[17].Value) == 0) continue;

                    if (!((row.Cells[0].Value + "").Trim().Equals("BANCO MACHALA"))) continue;

                    objWriter.WriteLine(
                        "DET" +
                        CompletarConCero(row.Index + "", 7, true) +
                        CompletarConEspacio(row.Cells[6].Value.ToString(), 15, false) +
                        "CU" +
                        CompletarConEspacio("EC", 3, false) +
                        CompletarConEspacio(25 + "", 3, false) +
                        ((row.Cells[16].Value + "").Trim().Equals("AHO") ? "10" : "00") +
                        CompletarConEspacio(row.Cells[15].Value.ToString(), 20, false) +
                        "00" +
                        "00" +
                        CompletarConEspacio(row.Cells[5].Value.ToString().Replace("Ñ", "N"), 40, false) +
                        CompletarConEspacio(row.Cells[6].Value.ToString(), 40, false) +
                        "C" +
                        "00000" +
                        "000000" +
                        "000000" +
                        "00000000" +
                        "0000" +
                        CompletarConCero(row.Cells[12].Value.ToString().Replace(".", ""), 15, true) +
                        "USD" +
                        CompletarConEspacio(row.Cells[5].Value.ToString().Replace("Ñ", "N"), 40, false) +
                        "C" +
                        CompletarConEspacio(row.Cells[6].Value.ToString(), 10, false) +
                        CompletarConEspacio("", 154, false) +
                        (TipoCon == TipoConexion.Cisepro ? "00652" : TipoCon == TipoConexion.Seportpac ? "05839" : string.Empty));
                }
                objWriter.Close();
                KryptonMessageBox.Show(@"Archivo generado correctamente", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void btnBizPichincha_Click(object sender, EventArgs e)
        {
            if (_rep)
            {
                KryptonMessageBox.Show(@"NO SE PUEDE EXPORTAR DEBIDO A QUE EXISTEN CUENTAS REPETIDAS! POR FAVOR, REALICE LA VERIFICACIÓN DE LAS CUENTAS", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            if (dgvInformePago.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var fec = DateTime.Now;
                var sfd = new SaveFileDialog
                {
                    Filter = @"All Files (*.*)|*.*",
                    FileName = ("BPIC_" + fec.Year + fec.Month + fec.Day + "_" + fec.Hour + fec.Minute + ".txt"),
                };

                var det = (cbxQuincena.SelectedIndex == 0 ? "1RA" : "2DA") + " QNA " +
                          ValidationForms.MesEnLetras(dtpMesAnio.Value.Month) + " " + dtpMesAnio.Value.Year + " " +
                          (cbxTipo.SelectedIndex == 0 ? "OP" : "AD");

                if (sfd.ShowDialog() != DialogResult.OK) return;

                if (!sfd.FileName.EndsWith(".txt")) sfd.FileName += ".txt";

                if (File.Exists(sfd.FileName) == false) File.Create(sfd.FileName).Dispose();

                var objWriter = new StreamWriter(sfd.FileName, true);

                foreach (DataGridViewRow row in dgvInformePago.Rows)
                {

                    if ((row.Cells[5].Tag + "").Trim() == "R") continue; // NO RETENIDOS
                    if ((row.Cells[1].Value + "").Trim().Length == 0) continue; // NO VACIOS
                    if (Convert.ToInt32(row.Cells[1].Value) == 0) continue;

                    if ((row.Cells[13].Value + "").Trim().Length == 0) continue; // NO SIN BANCO
                    //if (Convert.ToInt32(row.Cells[13].Value) != 2) continue; // SOLO BANCO PICHINCHA
                    if (Convert.ToInt32(row.Cells[12].Value) == 0 || Convert.ToInt32(row.Cells[12].Value) == 1) continue; // A TODOS MENOS BANCO MACHALA

                    if (Convert.ToInt32(row.Cells[16].Value) == 0) continue; // SOLO ACTIVOS

                    objWriter.WriteLine(
                        CompletarConEspacio("PA", 2, false) + "\t" +
                        CompletarConEspacio(row.Cells[6].Value.ToString(), 10, false) + "\t" +
                        CompletarConEspacio("USD", 3, false) + "\t" +
                        CompletarConCero(row.Cells[11].Value.ToString().Replace(".", ""), 5, true) + "\t" +
                        CompletarConEspacio("CTA", 3, false) + "\t" +
                        CompletarConEspacio("AHO", 3, false) + "\t" +
                        CompletarConEspacio(row.Cells[14].Value.ToString(), 10, false) + "\t" +
                        det + "\t" +
                        CompletarConEspacio("C", 1, false) + "\t" +
                        CompletarConEspacio(row.Cells[6].Value.ToString(), 10, false) + "\t" +
                        row.Cells[5].Value + 
                        (!row.Cells[17].Value.ToString().Equals("10") ? "\t"+ CompletarConEspacio(row.Cells[17].Value.ToString(), 3, false):string.Empty)
                        );
                }
                objWriter.Close();
                KryptonMessageBox.Show(@"Archivo generado correctamente", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void bntExportar_Click(object sender, EventArgs e)
        {
            if (dgvDetallesRol.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var fec = DateTime.Now;
                var sfd = new SaveFileDialog
                {
                    Filter = @"Excel Files(.xls)|*.xls|Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm",
                    Title = @"EXPORTAR A EXCEL",
                    FileName = ("ROL_DE_PAGO_" + cbxGrupo.Text + "_" + fec.Year + fec.Month + fec.Day + "_" + fec.Hour + fec.Minute + ".xls")
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;

                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "ROL DE PAGO";

                var l = -1;
                for (var i = 0; i <= dgvDetallesRol.Columns.Count - 1; i++) if (i < 63 && dgvDetallesRol.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l + 1); 

                var rc = dgvDetallesRol.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = Settings.Default.ColorCisepro;
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = "ROL DE PAGO " + cbxGrupo.Text + " : " + ValidationForms.MesEnLetras(dtpMesAnio.Value.Month) + "-" + dtpMesAnio.Value.Year + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;

                var x = 1;
                for (var i = 0; i <= dgvDetallesRol.Columns.Count - 1; i++)
                {
                    if (i == 43 || i > 63 || !dgvDetallesRol.Columns[i].Visible) continue;

                    worksheet.Cells[head, x] = dgvDetallesRol.Columns[i].HeaderText;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;


                    worksheet.Cells[head, x].Interior.Color = Settings.Default.ColorCisepro;
                    if (i > 11) worksheet.Cells[head, x].Orientation = 90;
                    x++;
                }

                worksheet.Cells[head, x] = @"FIRMA";
                worksheet.Cells[head, x].Font.Bold = true;
                worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheet.Cells[head, x].Font.Color = Color.White;
                worksheet.Cells[head, x].Interior.Color = Settings.Default.ColorCisepro;
                worksheet.Cells[head, x].Orientation = 90;
                x++;

                worksheet.Cells[head, x] = @"HUELLA";
                worksheet.Cells[head, x].Font.Bold = true;
                worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheet.Cells[head, x].Font.Color = Color.White;
                worksheet.Cells[head, x].Interior.Color = Settings.Default.ColorCisepro;
                worksheet.Cells[head, x].Orientation = 90;

                // datos celdas
                head++;
                foreach (DataGridViewRow row in dgvDetallesRol.Rows)
                {
                    var y = 1;
                    for (var j = 0; j <= dgvDetallesRol.Columns.Count - 1; j++)
                    {
                        if (j == 43 || j > 65 || !dgvDetallesRol.Columns[j].Visible) continue;

                        worksheet.Cells[head, y] = row.Cells[j].Value;

                        if ((row.Tag + "").Equals("2") || (row.Tag + "").Equals("3")) worksheet.Cells[head, y].Font.Bold = true;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                        y++;
                    }

                    worksheet.Cells[head, x - 1].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x - 1].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x - 1].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;

                    worksheet.Cells[head, x].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;

                    head++;
                }

                var position = (Range)worksheet.Cells[2, 6];
                Clipboard.SetImage(ValidationForms.Logo(TipoCon));
                worksheet.Paste(position);

                worksheet.Range["A1:" + ic + rc].Columns.AutoFit();
                app.DisplayAlerts = false;
                app.Visible = true;
                workbook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                KryptonMessageBox.Show(@"ROL DE PAGO generado correctamente!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void btnInformePago_Click(object sender, EventArgs e)
        {
            if (dgvInformePago.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var fec = DateTime.Now;
                var sfd = new SaveFileDialog
                {
                    Filter = @"Excel Files(.xls)|*.xls|Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm",
                    Title = @"EXPORTAR A EXCEL",
                    FileName = ("INFORME_DE_PAGO_" + cbxGrupo.Text + "_" + fec.Year + fec.Month + fec.Day + "_" + fec.Hour +
                         fec.Minute + ".xls")
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;

                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var ch = 5 - workbook.Sheets.Count;

                if (ch > 0) for (var i = 0; i < ch; i++) workbook.Sheets.Add();

                var worksheetm = (Worksheet)workbook.Worksheets[1];
                worksheetm.Name = "INFORME GENERAL B.M";

                var worksheetpm = (Worksheet)workbook.Worksheets[2];
                worksheetpm.Name = "INFORME INTERBANCARIO";


                var worksheetp = (Worksheet)workbook.Worksheets[3];
                worksheetp.Name = "INFORME GENERAL B.P";


                var worksheetc = (Worksheet)workbook.Worksheets[4];
                worksheetc.Name = "INFORME CHEQUE";


                var worksheetr = (Worksheet)workbook.Worksheets[5];
                worksheetr.Name = "INFORME RETENIDOS";


                var l = -1;
                for (var i = 0; i <= dgvInformePago.Columns.Count - 1; i++) if (dgvInformePago.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l);

                var rc = dgvInformePago.RowCount + 10;

                worksheetm.Range["A1:" + ic + (dgvInformePago.RowCount * 2)].Font.Size = 10;
                worksheetm.Range["A1:" + ic + "1"].Merge();
                worksheetm.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon);
                worksheetm.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheetm.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheetm.Range["A1:" + ic + "1"].Interior.Color = Settings.Default.ColorCisepro;
                worksheetm.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheetm.Range["A1:" + ic + "1"].Font.Size = 12;
                worksheetm.Range["A3:" + ic + "3"].Merge();
                worksheetm.Range["A3:" + ic + "3"].Value = "INFORME DE PAGO GENERAL BANCO MACHALA - ROL DE: " +
                                                           ValidationForms.MesEnLetras(dtpMesAnio.Value.Month) + "-" + dtpMesAnio.Value.Year +
                                                           " GRUPO: " + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheetm.Range["A3:" + ic + "3"].Font.Size = 12;


                worksheetpm.Range["A1:" + ic + (dgvInformePago.RowCount * 2)].Font.Size = 10;
                worksheetpm.Range["A1:" + ic + "1"].Merge();
                worksheetpm.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon);
                worksheetpm.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheetpm.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheetpm.Range["A1:" + ic + "1"].Interior.Color = Settings.Default.ColorCisepro;
                worksheetpm.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheetpm.Range["A1:" + ic + "1"].Font.Size = 12;
                worksheetpm.Range["A3:" + ic + "3"].Merge();
                worksheetpm.Range["A3:" + ic + "3"].Value = "INFORME DE PAGO INTERBANCARIO - ROL DE: " +
                                                            ValidationForms.MesEnLetras(dtpMesAnio.Value.Month) + "-" + dtpMesAnio.Value.Year +
                                                            " GRUPO: " + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheetpm.Range["A3:" + ic + "3"].Font.Size = 12;


                worksheetp.Range["A1:" + ic + (dgvInformePago.RowCount * 2)].Font.Size = 10;
                worksheetp.Range["A1:" + ic + "1"].Merge();
                worksheetp.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon);
                worksheetp.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheetp.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheetp.Range["A1:" + ic + "1"].Interior.Color = Settings.Default.ColorCisepro;
                worksheetp.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheetp.Range["A1:" + ic + "1"].Font.Size = 12;
                worksheetp.Range["A3:" + ic + "3"].Merge();
                worksheetp.Range["A3:" + ic + "3"].Value = "INFORME DE PAGO BANCO PICHINCHA - ROL DE: " +
                                                           ValidationForms.MesEnLetras(dtpMesAnio.Value.Month) + "-" +
                                                           dtpMesAnio.Value.Year + " GRUPO: " + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheetp.Range["A3:" + ic + "3"].Font.Size = 12;


                worksheetc.Range["A1:" + ic + (dgvInformePago.RowCount * 2)].Font.Size = 10;
                worksheetc.Range["A1:" + ic + "1"].Merge();
                worksheetc.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon);
                worksheetc.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheetc.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheetc.Range["A1:" + ic + "1"].Interior.Color = Settings.Default.ColorCisepro;
                worksheetc.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheetc.Range["A1:" + ic + "1"].Font.Size = 12;
                worksheetc.Range["A3:" + ic + "3"].Merge();
                worksheetc.Range["A3:" + ic + "3"].Value = "INFORME DE PAGO CON CHEQUE - ROL DE: " +
                                                           ValidationForms.MesEnLetras(dtpMesAnio.Value.Month) + "-" +
                                                           dtpMesAnio.Value.Year + " GRUPO: " + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheetc.Range["A3:" + ic + "3"].Font.Size = 12;


                worksheetr.Range["A1:" + ic + (dgvInformePago.RowCount * 2)].Font.Size = 10;
                worksheetr.Range["A1:" + ic + "1"].Merge();
                worksheetr.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon);
                worksheetr.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheetr.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheetr.Range["A1:" + ic + "1"].Interior.Color = Settings.Default.ColorCisepro;
                worksheetr.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheetr.Range["A1:" + ic + "1"].Font.Size = 12;
                worksheetr.Range["A3:" + ic + "3"].Merge();
                worksheetr.Range["A3:" + ic + "3"].Value = "INFORME DE PAGO RETENIDOS: " +
                                                           ValidationForms.MesEnLetras(dtpMesAnio.Value.Month) + "-" +
                                                           dtpMesAnio.Value.Year + " GRUPO: " + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheetr.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;

                var x = 1;
                for (var i = 0; i <= dgvInformePago.Columns.Count - 1; i++)
                {
                    if (!dgvInformePago.Columns[i].Visible) continue;

                    worksheetm.Cells[head, x] = dgvInformePago.Columns[i].HeaderText;
                    worksheetm.Cells[head, x].Font.Bold = true;
                    worksheetm.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheetm.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheetm.Cells[head, x].Interior.Color = Settings.Default.ColorCisepro;
                    worksheetm.Cells[head, x].Font.Color = Color.White;

                    worksheetpm.Cells[head, x] = dgvInformePago.Columns[i].HeaderText;
                    worksheetpm.Cells[head, x].Font.Bold = true;
                    worksheetpm.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheetpm.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheetpm.Cells[head, x].Interior.Color = Settings.Default.ColorCisepro;
                    worksheetpm.Cells[head, x].Font.Color = Color.White;

                    worksheetp.Cells[head, x] = dgvInformePago.Columns[i].HeaderText;
                    worksheetp.Cells[head, x].Font.Bold = true;
                    worksheetp.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheetp.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheetp.Cells[head, x].Interior.Color = Settings.Default.ColorCisepro;
                    worksheetp.Cells[head, x].Font.Color = Color.White;

                    worksheetc.Cells[head, x] = dgvInformePago.Columns[i].HeaderText;
                    worksheetc.Cells[head, x].Font.Bold = true;
                    worksheetc.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheetc.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheetc.Cells[head, x].Interior.Color = Settings.Default.ColorCisepro;
                    worksheetc.Cells[head, x].Font.Color = Color.White;

                    worksheetr.Cells[head, x] = dgvInformePago.Columns[i].HeaderText;
                    worksheetr.Cells[head, x].Font.Bold = true;
                    worksheetr.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheetr.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheetr.Cells[head, x].Interior.Color = Settings.Default.ColorCisepro;
                    worksheetr.Cells[head, x].Font.Color = Color.White;

                    x++;
                }

                head = 6;
                int y;
                double tm = 0;
                double tpm = 0;
                double tp = 0;
                double tc = 0;
                double tr = 0;
                foreach (DataGridViewRow row in dgvInformePago.Rows)
                {
                    if ((row.Cells[12].Value + "").Trim().Length == 0) continue;
                    if ((row.Cells[5].Tag + "").Trim() == "R") continue;
                    if (Convert.ToInt32(row.Cells[12].Value) != 1) continue;
                    if (Convert.ToInt32(row.Cells[16].Value) == 0) continue; 

                    tm += Convert.ToDouble(row.Cells[11].Value);
                    y = 1;
                    for (var j = 0; j <= dgvInformePago.Columns.Count - 1; j++)
                    {
                        if (!dgvInformePago.Columns[j].Visible) continue;
                        worksheetm.Cells[head, y] = row.Cells[j].Value;
                        if ((row.Tag + "").Equals("2") || (row.Tag + "").Equals("3")) worksheetm.Cells[head, y].Font.Bold = true;
                        worksheetm.Cells[head, y].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                        worksheetm.Cells[head, y].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                        if (head == dgvInformePago.RowCount + 6) worksheetm.Cells[head, y].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                        y++;
                    }
                    head++;
                }
                worksheetm.Cells[head, 2] = "TOTAL PAGOS CON TRANSFERENCIA B.M.";
                worksheetm.Cells[head, 9] = tm.ToString("N");
                worksheetm.Cells[head, 2].Font.Bold = true;
                worksheetm.Cells[head, 9].Font.Bold = true;

                var hr = head;

                head = 6;
                foreach (DataGridViewRow row in dgvInformePago.Rows)
                {
                    if ((row.Cells[12].Value + "").Trim().Length == 0) continue;
                    if ((row.Cells[5].Tag + "").Trim() == "R") continue;
                    if (Convert.ToInt32(row.Cells[12].Value) < 3) continue;
                    if (Convert.ToInt32(row.Cells[16].Value) == 0) continue;

                    tpm += Convert.ToDouble(row.Cells[11].Value);
                    y = 1;

                    for (var j = 0; j <= dgvInformePago.Columns.Count - 1; j++)
                    {
                        if (!dgvInformePago.Columns[j].Visible) continue;
                        worksheetpm.Cells[head, y] = row.Cells[j].Value;
                        if ((row.Tag + "").Equals("2") || (row.Tag + "").Equals("3")) worksheetpm.Cells[head, y].Font.Bold = true;
                        worksheetpm.Cells[head, y].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                        worksheetpm.Cells[head, y].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                        if (head == dgvInformePago.RowCount + 6) worksheetpm.Cells[head, y].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                        y++;
                    }
                    head++;
                }
                worksheetpm.Cells[head, 2] = "TOTAL PAGOS CON TRANSFERENCIA INTERBANCARIO";
                worksheetpm.Cells[head, 9] = tpm.ToString("N");
                worksheetpm.Cells[head, 2].Font.Bold = true;
                worksheetpm.Cells[head, 9].Font.Bold = true;

                worksheetpm.Range["C" + (head + 3) + ":D" + (head + 3)].Merge();
                worksheetpm.Range["C" + (head + 3) + ":D" + (head + 3)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetpm.Range["C" + (head + 3) + ":D" + (head + 3)].Value = TipoCon == TipoConexion.Cisepro ? "JESSICA MITE" : TipoCon == TipoConexion.Seportpac ? "ING. MA. KATHERINE ALVARADO A." : "";
                worksheetpm.Range["C" + (head + 4) + ":D" + (head + 4)].Merge();
                worksheetpm.Range["C" + (head + 4) + ":D" + (head + 4)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetpm.Range["C" + (head + 4) + ":D" + (head + 4)].Value = "ASISTENTE DE RECURSOS HUMANOS";
                worksheetpm.Range["C" + (head + 5) + ":D" + (head + 5)].Merge();
                worksheetpm.Range["C" + (head + 5) + ":D" + (head + 5)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetpm.Range["C" + (head + 5) + ":D" + (head + 5)].Value = "ELABORADO POR:";
                worksheetpm.Range["C" + (head + 5) + ":D" + (head + 5)].Font.Bold = true;
                worksheetpm.Range["F" + (head + 3) + ":G" + (head + 3)].Merge();
                worksheetpm.Range["F" + (head + 3) + ":G" + (head + 3)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetpm.Range["F" + (head + 3) + ":G" + (head + 3)].Value = "ING. MAGDALENA CHATO N.";
                worksheetpm.Range["F" + (head + 4) + ":G" + (head + 4)].Merge();
                worksheetpm.Range["F" + (head + 4) + ":G" + (head + 4)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetpm.Range["F" + (head + 4) + ":G" + (head + 4)].Value = "CONTADORA";
                worksheetpm.Range["F" + (head + 5) + ":G" + (head + 5)].Merge();
                worksheetpm.Range["F" + (head + 5) + ":G" + (head + 5)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetpm.Range["F" + (head + 5) + ":G" + (head + 5)].Value = "REVISADO POR:";
                worksheetpm.Range["F" + (head + 5) + ":G" + (head + 5)].Font.Bold = true;

                worksheetpm.Range["C" + (head + 10) + ":D" + (head + 10)].Merge();
                worksheetpm.Range["C" + (head + 10) + ":D" + (head + 10)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetpm.Range["C" + (head + 10) + ":D" + (head + 10)].Value = "SRA. BELÉN ARMIJOS C.";
                worksheetpm.Range["C" + (head + 11) + ":D" + (head + 11)].Merge();
                worksheetpm.Range["C" + (head + 11) + ":D" + (head + 11)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetpm.Range["C" + (head + 11) + ":D" + (head + 11)].Value = "GERENTE ADMINISTRATIVO";
                worksheetpm.Range["C" + (head + 11) + ":D" + (head + 11)].Font.Bold = true;
                worksheetpm.Range["F" + (head + 10) + ":G" + (head + 10)].Merge();
                worksheetpm.Range["F" + (head + 10) + ":G" + (head + 10)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetpm.Range["F" + (head + 10) + ":G" + (head + 10)].Value = TipoCon == TipoConexion.Cisepro ? "ING. KAREN NAVARRETE M." : TipoCon == TipoConexion.Seportpac ? "ING. JOSÉ NAVARRETE M." : "";
                worksheetpm.Range["F" + (head + 11) + ":G" + (head + 11)].Merge();
                worksheetpm.Range["F" + (head + 11) + ":G" + (head + 11)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetpm.Range["F" + (head + 11) + ":G" + (head + 11)].Value = "GERENTE DE RRHH";
                worksheetpm.Range["F" + (head + 11) + ":G" + (head + 11)].Font.Bold = true;

                head = 6;
                foreach (DataGridViewRow row in dgvInformePago.Rows)
                {
                    if ((row.Cells[12].Value + "").Trim().Length == 0) continue;
                    if ((row.Cells[5].Tag + "").Trim() == "R") continue;
                    if (Convert.ToInt32(row.Cells[12].Value) != 2) continue;
                    if (Convert.ToInt32(row.Cells[16].Value) == 0) continue; 

                    tp = tp + Convert.ToDouble(row.Cells[11].Value);
                    y = 1;
                    for (var j = 0; j <= dgvInformePago.Columns.Count - 1; j++)
                    {
                        if (!dgvInformePago.Columns[j].Visible) continue;
                        worksheetp.Cells[head, y] = row.Cells[j].Value;
                        if ((row.Tag + "").Equals("2") || (row.Tag + "").Equals("3")) worksheetp.Cells[head, y].Font.Bold = true;
                        worksheetp.Cells[head, y].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                        worksheetp.Cells[head, y].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                        if (head == dgvInformePago.RowCount + 6) worksheetp.Cells[head, y].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                        y++;
                    }
                    head++;
                }
                worksheetp.Cells[head, 2] = "TOTAL PAGOS CON TRANSFERENCIA B.P.";
                worksheetp.Cells[head, 9] = tp.ToString("N");
                worksheetp.Cells[head, 2].Font.Bold = true;
                worksheetp.Cells[head, 9].Font.Bold = true;

                worksheetp.Range["C" + (head + 3) + ":D" + (head + 3)].Merge();
                worksheetp.Range["C" + (head + 3) + ":D" + (head + 3)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetp.Range["C" + (head + 3) + ":D" + (head + 3)].Value = TipoCon == TipoConexion.Cisepro ? "JESSICA MITE" : TipoCon == TipoConexion.Seportpac ? "ING. MA. KATHERINE ALVARADO A." : "";
                worksheetp.Range["C" + (head + 4) + ":D" + (head + 4)].Merge();
                worksheetp.Range["C" + (head + 4) + ":D" + (head + 4)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetp.Range["C" + (head + 4) + ":D" + (head + 4)].Value = "ASISTENTE DE RECURSOS HUMANOS";
                worksheetp.Range["C" + (head + 5) + ":D" + (head + 5)].Merge();
                worksheetp.Range["C" + (head + 5) + ":D" + (head + 5)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetp.Range["C" + (head + 5) + ":D" + (head + 5)].Value = "ELABORADO POR:";
                worksheetp.Range["C" + (head + 5) + ":D" + (head + 5)].Font.Bold = true;

                worksheetp.Range["F" + (head + 3) + ":G" + (head + 3)].Merge();
                worksheetp.Range["F" + (head + 3) + ":G" + (head + 3)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetp.Range["F" + (head + 3) + ":G" + (head + 3)].Value = "ING. MAGDALENA CHATO N.";
                worksheetp.Range["F" + (head + 4) + ":G" + (head + 4)].Merge();
                worksheetp.Range["F" + (head + 4) + ":G" + (head + 4)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetp.Range["F" + (head + 4) + ":G" + (head + 4)].Value = "CONTADORA";
                worksheetp.Range["F" + (head + 5) + ":G" + (head + 5)].Merge();
                worksheetp.Range["F" + (head + 5) + ":G" + (head + 5)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetp.Range["F" + (head + 5) + ":G" + (head + 5)].Value = "REVISADO POR:";
                worksheetp.Range["F" + (head + 5) + ":G" + (head + 5)].Font.Bold = true;

                worksheetp.Range["C" + (head + 10) + ":D" + (head + 10)].Merge();
                worksheetp.Range["C" + (head + 10) + ":D" + (head + 10)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetp.Range["C" + (head + 10) + ":D" + (head + 10)].Value = "SRA. BELÉN ARMIJOS C.";
                worksheetp.Range["C" + (head + 11) + ":D" + (head + 11)].Merge();
                worksheetp.Range["C" + (head + 11) + ":D" + (head + 11)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetp.Range["C" + (head + 11) + ":D" + (head + 11)].Value = "GERENTE ADMINISTRATIVO";
                worksheetp.Range["C" + (head + 11) + ":D" + (head + 11)].Font.Bold = true;

                worksheetp.Range["F" + (head + 10) + ":G" + (head + 10)].Merge();
                worksheetp.Range["F" + (head + 10) + ":G" + (head + 10)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetp.Range["F" + (head + 10) + ":G" + (head + 10)].Value = TipoCon == TipoConexion.Cisepro ? "ING. KAREN NAVARRETE M." : TipoCon == TipoConexion.Seportpac ? "ING. JOSÉ NAVARRETE M." : "";
                worksheetp.Range["F" + (head + 11) + ":G" + (head + 11)].Merge();
                worksheetp.Range["F" + (head + 11) + ":G" + (head + 11)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetp.Range["F" + (head + 11) + ":G" + (head + 11)].Value = "GERENTE DE RRHH";
                worksheetp.Range["F" + (head + 11) + ":G" + (head + 11)].Font.Bold = true;


                head = 6;
                foreach (DataGridViewRow row in dgvInformePago.Rows)
                {
                    if ((row.Cells[12].Value + "").Trim().Length == 0) continue;
                    if ((row.Cells[5].Tag + "").Trim() == "R") continue;
                    if (((row.Cells[3].Value + "")).StartsWith("TOTAL ") && ((row.Cells[5].Value + "").Trim().Length == 0)) continue;

                    if ((Convert.ToInt32(row.Cells[12].Value) == 0) || (Convert.ToInt32(row.Cells[16].Value) == 0))
                    {
                        tc = tc + Convert.ToDouble(row.Cells[11].Value);
                        y = 1;
                        for (var j = 0; j <= dgvInformePago.Columns.Count - 1; j++)
                        {
                            if (!dgvInformePago.Columns[j].Visible) continue;
                            worksheetc.Cells[head, y] = row.Cells[j].Value;
                            if (((row.Tag + "")).Equals("2") || ((row.Tag + "")).Equals("3")) worksheetc.Cells[head, y].Font.Bold = true;
                            worksheetc.Cells[head, y].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                            worksheetc.Cells[head, y].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                            if (head == dgvInformePago.RowCount + 6) worksheetc.Cells[head, y].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                            y++;
                        }
                        head++;
                    }
                }
                worksheetc.Cells[head, 2] = "TOTAL PAGOS CON CHEQUE";
                worksheetc.Cells[head, 9] = tc.ToString("N");
                worksheetc.Cells[head, 2].Font.Bold = true;
                worksheetc.Cells[head, 9].Font.Bold = true;

                worksheetc.Range["C" + (head + 3) + ":D" + (head + 3)].Merge();
                worksheetc.Range["C" + (head + 3) + ":D" + (head + 3)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetc.Range["C" + (head + 3) + ":D" + (head + 3)].Value = TipoCon == TipoConexion.Cisepro ? "JESSICA MITE" : TipoCon == TipoConexion.Seportpac ? "ING. MA. KATHERINE ALVARADO A." : "";
                worksheetc.Range["C" + (head + 4) + ":D" + (head + 4)].Merge();
                worksheetc.Range["C" + (head + 4) + ":D" + (head + 4)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetc.Range["C" + (head + 4) + ":D" + (head + 4)].Value = "ASISTENTE DE RECURSOS HUMANOS";
                worksheetc.Range["C" + (head + 5) + ":D" + (head + 5)].Merge();
                worksheetc.Range["C" + (head + 5) + ":D" + (head + 5)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetc.Range["C" + (head + 5) + ":D" + (head + 5)].Value = "ELABORADO POR:";
                worksheetc.Range["C" + (head + 5) + ":D" + (head + 5)].Font.Bold = true;

                worksheetc.Range["F" + (head + 3) + ":G" + (head + 3)].Merge();
                worksheetc.Range["F" + (head + 3) + ":G" + (head + 3)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetc.Range["F" + (head + 3) + ":G" + (head + 3)].Value = "ING. MAGDALENA CHATO N.";
                worksheetc.Range["F" + (head + 4) + ":G" + (head + 4)].Merge();
                worksheetc.Range["F" + (head + 4) + ":G" + (head + 4)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetc.Range["F" + (head + 4) + ":G" + (head + 4)].Value = "CONTADORA";
                worksheetc.Range["F" + (head + 5) + ":G" + (head + 5)].Merge();
                worksheetc.Range["F" + (head + 5) + ":G" + (head + 5)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetc.Range["F" + (head + 5) + ":G" + (head + 5)].Value = "REVISADO POR:";
                worksheetc.Range["F" + (head + 5) + ":G" + (head + 5)].Font.Bold = true;

                worksheetc.Range["C" + (head + 10) + ":D" + (head + 10)].Merge();
                worksheetc.Range["C" + (head + 10) + ":D" + (head + 10)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetc.Range["C" + (head + 10) + ":D" + (head + 10)].Value = "SRA. BELÉN ARMIJOS C.";
                worksheetc.Range["C" + (head + 11) + ":D" + (head + 11)].Merge();
                worksheetc.Range["C" + (head + 11) + ":D" + (head + 11)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetc.Range["C" + (head + 11) + ":D" + (head + 11)].Value = "GERENTE ADMINISTRATIVO";
                worksheetc.Range["C" + (head + 11) + ":D" + (head + 11)].Font.Bold = true;

                worksheetc.Range["F" + (head + 10) + ":G" + (head + 10)].Merge();
                worksheetc.Range["F" + (head + 10) + ":G" + (head + 10)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetc.Range["F" + (head + 10) + ":G" + (head + 10)].Value = TipoCon == TipoConexion.Cisepro ? "ING. KAREN NAVARRETE M." : TipoCon == TipoConexion.Seportpac ? "ING. JOSÉ NAVARRETE M." : "";
                worksheetc.Range["F" + (head + 11) + ":G" + (head + 11)].Merge();
                worksheetc.Range["F" + (head + 11) + ":G" + (head + 11)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetc.Range["F" + (head + 11) + ":G" + (head + 11)].Value = "GERENTE DE RRHH";
                worksheetc.Range["F" + (head + 11) + ":G" + (head + 11)].Font.Bold = true;


                head = 6;
                foreach (DataGridViewRow row in dgvInformePago.Rows)
                {
                    if (((row.Cells[3].Value + "")).StartsWith("TOTAL ") && ((row.Cells[5].Value + "").Trim().Length == 0)) continue;
                    if ((row.Cells[5].Tag + "").Trim() != "R") continue;

                    tr = tr + Convert.ToDouble(row.Cells[11].Value);
                    y = 1;
                    for (var j = 0; j <= dgvInformePago.Columns.Count - 1; j++)
                    {
                        if (!dgvInformePago.Columns[j].Visible) continue;
                        worksheetr.Cells[head, y] = row.Cells[j].Value;
                        if ((row.Cells[j].Value + "").Trim().Equals("SIN BANCO")) worksheetr.Cells[head, y] = string.Empty;
                        if ((row.Cells[j].Value + "").Trim().Equals("AHO")) worksheetr.Cells[head, y] = string.Empty;
                        if (((row.Tag + "")).Equals("2") || ((row.Tag + "")).Equals("3")) worksheetr.Cells[head, y].Font.Bold = true;
                        worksheetr.Cells[head, y].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                        worksheetr.Cells[head, y].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                        if (head == dgvInformePago.RowCount + 6) worksheetr.Cells[head, y].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                        y++;
                    }
                    head++;
                }

                worksheetr.Cells[head, 2] = "TOTAL PAGOS RETENIDOS";
                worksheetr.Cells[head, 9] = tr.ToString("N");
                worksheetr.Cells[head, 2].Font.Bold = true;
                worksheetr.Cells[head, 9].Font.Bold = true;

                worksheetr.Range["C" + (head + 3) + ":D" + (head + 3)].Merge();
                worksheetr.Range["C" + (head + 3) + ":D" + (head + 3)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetr.Range["C" + (head + 3) + ":D" + (head + 3)].Value = TipoCon == TipoConexion.Cisepro ? "JESSICA MITE" : TipoCon == TipoConexion.Seportpac ? "ING. MA. KATHERINE ALVARADO A." : "";
                worksheetr.Range["C" + (head + 4) + ":D" + (head + 4)].Merge();
                worksheetr.Range["C" + (head + 4) + ":D" + (head + 4)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetr.Range["C" + (head + 4) + ":D" + (head + 4)].Value = "ASISTENTE DE RECURSOS HUMANOS";
                worksheetr.Range["C" + (head + 5) + ":D" + (head + 5)].Merge();
                worksheetr.Range["C" + (head + 5) + ":D" + (head + 5)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetr.Range["C" + (head + 5) + ":D" + (head + 5)].Value = "ELABORADO POR:";
                worksheetr.Range["C" + (head + 5) + ":D" + (head + 5)].Font.Bold = true;

                worksheetr.Range["F" + (head + 3) + ":G" + (head + 3)].Merge();
                worksheetr.Range["F" + (head + 3) + ":G" + (head + 3)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetr.Range["F" + (head + 3) + ":G" + (head + 3)].Value = "ING. MAGDALENA CHATO N.";
                worksheetr.Range["F" + (head + 4) + ":G" + (head + 4)].Merge();
                worksheetr.Range["F" + (head + 4) + ":G" + (head + 4)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetr.Range["F" + (head + 4) + ":G" + (head + 4)].Value = "CONTADORA";
                worksheetr.Range["F" + (head + 5) + ":G" + (head + 5)].Merge();
                worksheetr.Range["F" + (head + 5) + ":G" + (head + 5)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetr.Range["F" + (head + 5) + ":G" + (head + 5)].Value = "REVISADO POR:";
                worksheetr.Range["F" + (head + 5) + ":G" + (head + 5)].Font.Bold = true;

                worksheetr.Range["C" + (head + 10) + ":D" + (head + 10)].Merge();
                worksheetr.Range["C" + (head + 10) + ":D" + (head + 10)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetr.Range["C" + (head + 10) + ":D" + (head + 10)].Value = "SRA. BELÉN ARMIJOS C.";
                worksheetr.Range["C" + (head + 11) + ":D" + (head + 11)].Merge();
                worksheetr.Range["C" + (head + 11) + ":D" + (head + 11)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetr.Range["C" + (head + 11) + ":D" + (head + 11)].Value = "GERENTE ADMINISTRATIVO";
                worksheetr.Range["C" + (head + 11) + ":D" + (head + 11)].Font.Bold = true;

                worksheetr.Range["F" + (head + 10) + ":G" + (head + 10)].Merge();
                worksheetr.Range["F" + (head + 10) + ":G" + (head + 10)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetr.Range["F" + (head + 10) + ":G" + (head + 10)].Value = TipoCon == TipoConexion.Cisepro ? "ING. KAREN NAVARRETE M." : TipoCon == TipoConexion.Seportpac ? "ING. JOSÉ NAVARRETE M." : "";
                worksheetr.Range["F" + (head + 11) + ":G" + (head + 11)].Merge();
                worksheetr.Range["F" + (head + 11) + ":G" + (head + 11)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetr.Range["F" + (head + 11) + ":G" + (head + 11)].Value = "GERENTE DE RRHH";
                worksheetr.Range["F" + (head + 11) + ":G" + (head + 11)].Font.Bold = true;

                worksheetm.Cells[(hr + 5), 2] = "TOTAL PAGOS CON TRANSFERENCIA B.M.";
                worksheetm.Cells[(hr + 5), 2].Font.Bold = true;
                worksheetm.Cells[(hr + 5), 7] = tm.ToString("N");
                worksheetm.Cells[(hr + 5), 7].Font.Bold = true;
                worksheetm.Cells[(hr + 6), 2] = "TOTAL PAGOS CON TRANSFERENCIA INTERBANCARIO";
                worksheetm.Cells[(hr + 6), 2].Font.Bold = true;
                worksheetm.Cells[(hr + 6), 7] = tpm.ToString("N");
                worksheetm.Cells[(hr + 6), 7].Font.Bold = true;
                worksheetm.Cells[(hr + 7), 2] = "TOTAL PAGOS CON TRANSFERENCIA B.P.";
                worksheetm.Cells[(hr + 7), 2].Font.Bold = true;
                worksheetm.Cells[(hr + 7), 7] = tp.ToString("N");
                worksheetm.Cells[(hr + 7), 7].Font.Bold = true;
                worksheetm.Cells[(hr + 8), 2] = "TOTAL PAGOS CON CHEQUE";
                worksheetm.Cells[(hr + 8), 2].Font.Bold = true;
                worksheetm.Cells[(hr + 8), 7] = tc.ToString("N");
                worksheetm.Cells[(hr + 8), 7].Font.Bold = true;
                worksheetm.Cells[(hr + 9), 2] = "TOTAL PAGOS RETENIDOS";
                worksheetm.Cells[(hr + 9), 2].Font.Bold = true;
                worksheetm.Cells[(hr + 9), 2].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                worksheetm.Cells[(hr + 9), 7] = tr.ToString("N");
                worksheetm.Cells[(hr + 9), 7].Font.Bold = true;
                worksheetm.Cells[(hr + 9), 7].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                worksheetm.Cells[(hr + 10), 2] = "TOTAL INFORME DE PAGO";
                worksheetm.Cells[(hr + 10), 2].Font.Bold = true;
                worksheetm.Cells[(hr + 10), 7] = (tm + tpm + tp + tc + tr).ToString("N");
                worksheetm.Cells[(hr + 10), 7].Font.Bold = true;

                worksheetm.Range["C" + (hr + 15) + ":D" + (hr + 15)].Merge();
                worksheetm.Range["C" + (hr + 15) + ":D" + (hr + 15)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetm.Range["C" + (hr + 15) + ":D" + (hr + 15)].Value = TipoCon == TipoConexion.Cisepro ? "JESSICA MITE" : TipoCon == TipoConexion.Seportpac ? "ING. MA. KATHERINE ALVARADO A." : "";
                worksheetm.Range["C" + (hr + 16) + ":D" + (hr + 16)].Merge();
                worksheetm.Range["C" + (hr + 16) + ":D" + (hr + 16)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetm.Range["C" + (hr + 16) + ":D" + (hr + 16)].Value = "ASISTENTE DE RECURSOS HUMANOS";
                worksheetm.Range["C" + (hr + 17) + ":D" + (hr + 17)].Merge();
                worksheetm.Range["C" + (hr + 17) + ":D" + (hr + 17)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetm.Range["C" + (hr + 17) + ":D" + (hr + 17)].Value = "ELABORADO POR:";
                worksheetm.Range["C" + (hr + 17) + ":D" + (hr + 17)].Font.Bold = true;

                worksheetm.Range["F" + (hr + 15) + ":G" + (hr + 15)].Merge();
                worksheetm.Range["F" + (hr + 15) + ":G" + (hr + 15)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetm.Range["F" + (hr + 15) + ":G" + (hr + 15)].Value = "ING. MAGDALENA CHATO N.";
                worksheetm.Range["F" + (hr + 16) + ":G" + (hr + 16)].Merge();
                worksheetm.Range["F" + (hr + 16) + ":G" + (hr + 16)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetm.Range["F" + (hr + 16) + ":G" + (hr + 16)].Value = "CONTADORA";
                worksheetm.Range["F" + (hr + 17) + ":G" + (hr + 17)].Merge();
                worksheetm.Range["F" + (hr + 17) + ":G" + (hr + 17)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetm.Range["F" + (hr + 17) + ":G" + (hr + 17)].Value = "REVISADO POR:";
                worksheetm.Range["F" + (hr + 17) + ":G" + (hr + 17)].Font.Bold = true;

                worksheetm.Range["C" + (hr + 22) + ":D" + (hr + 22)].Merge();
                worksheetm.Range["C" + (hr + 22) + ":D" + (hr + 22)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetm.Range["C" + (hr + 22) + ":D" + (hr + 22)].Value = "SRA. BELÉN ARMIJOS C.";
                worksheetm.Range["C" + (hr + 23) + ":D" + (hr + 23)].Merge();
                worksheetm.Range["C" + (hr + 23) + ":D" + (hr + 23)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetm.Range["C" + (hr + 23) + ":D" + (hr + 23)].Value = "GERENTE ADMINISTRATIVO";
                worksheetm.Range["C" + (hr + 23) + ":D" + (hr + 23)].Font.Bold = true;

                worksheetm.Range["F" + (hr + 22) + ":G" + (hr + 22)].Merge();
                worksheetm.Range["F" + (hr + 22) + ":G" + (hr + 22)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetm.Range["F" + (hr + 22) + ":G" + (hr + 22)].Value = TipoCon == TipoConexion.Cisepro ? "ING. KAREN NAVARRETE M." : TipoCon == TipoConexion.Seportpac ? "ING. JOSÉ NAVARRETE M." : "";
                worksheetm.Range["F" + (hr + 23) + ":G" + (hr + 23)].Merge();
                worksheetm.Range["F" + (hr + 23) + ":G" + (hr + 23)].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                worksheetm.Range["F" + (hr + 23) + ":G" + (hr + 23)].Value = "GERENTE DE RRHH";
                worksheetm.Range["F" + (hr + 23) + ":G" + (hr + 23)].Font.Bold = true;

                worksheetm.Range["A1:" + ic + rc].Columns.AutoFit();
                worksheetpm.Range["A1:" + ic + rc].Columns.AutoFit();
                worksheetp.Range["A1:" + ic + rc].Columns.AutoFit();
                worksheetc.Range["A1:" + ic + rc].Columns.AutoFit();
                worksheetr.Range["A1:" + ic + rc].Columns.AutoFit();

                var position1 = (Range)worksheetm.Cells[2, 6];
                var position2 = (Range)worksheetpm.Cells[2, 6];
                var position3 = (Range)worksheetp.Cells[2, 6];
                var position4 = (Range)worksheetc.Cells[2, 6];
                var position5 = (Range)worksheetr.Cells[2, 6];
                Clipboard.SetImage(ValidationForms.Logo(TipoCon));

                worksheetm.Range["N1:N" + (dgvInformePago.RowCount * 2)].Delete();
                worksheetpm.Range["N1:N" + (dgvInformePago.RowCount * 2)].Delete();
                worksheetp.Range["N1:N" + (dgvInformePago.RowCount * 2)].Delete();
                worksheetr.Range["K1:Z" + (dgvInformePago.RowCount * 2)].Delete();
                worksheetc.Range["K1:Z" + (dgvInformePago.RowCount * 2)].Delete();

                worksheetm.Paste(position1);
                worksheetpm.Paste(position2);
                worksheetp.Paste(position3);
                worksheetc.Paste(position4);
                worksheetr.Paste(position5);

                app.DisplayAlerts = false;
                app.Visible = true;
                workbook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                KryptonMessageBox.Show(@"INFORME DE PAGO generado correctamente!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL GENERAR INFORME DE PAGO!", "Mensaje del Sistema",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void btnParams_Click(object sender, EventArgs e)
        {
            var parms = _objRolPago.SeleccionarDetallesParametrosPersonal(TipoCon);
            foreach (DataGridViewRow row in dgvDetallesRol.Rows)
            {
                if ((row.Cells[1].Value + "").Trim().Length == 0) continue;
                if (Convert.ToInt32(row.Cells[1].Value) == 0) continue;

                foreach (DataRow fil in parms.Rows)
                {
                    if (!row.Cells[1].Value.ToString().Equals(fil[0].ToString())) continue;

                    row.Cells[66].Value = fil[1].ToString().Equals("1"); //  fondo res
                    row.Cells[67].Value = fil[2].ToString().Equals("1"); //  xiii
                    row.Cells[68].Value = fil[3].ToString().Equals("1"); //  xiv
                    row.Cells[69].Value = fil[4].ToString().Equals("1"); //  acum fond
                    row.Cells[70].Value = fil[5].ToString().Equals("1"); //  desc
                    row.Cells[78].Value = fil[16].ToString().Equals("1"); //  EXTSAL
                  
                     
                    CalcularDatosFilaRol(row.Index);
                }
            }
            SumatoriasRol();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (!cbxGrupo.Text.Trim().Equals("GENERAL"))
            {
                KryptonMessageBox.Show(@"ESTA OPCIÓN SÓLO ES VÁLIDA PARA ROL DE PAGOS GENERAL!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                return;
            }
            if (dgvDetallesRol.CurrentRow == null) return;
            if (dgvDetallesRol.RowCount == 0 || dgvDetallesRol.SelectedRows.Count == 0) return;

            if (dgvDetallesRol.SelectedRows[0].Cells[1].Value == null || dgvDetallesRol.SelectedRows[0].Cells[1].Value.ToString().Trim().Length == 0) return;
            if (Convert.ToInt32(dgvDetallesRol.SelectedRows[0].Cells[1].Value) == 0) return;

            if (dgvDetallesRol.SelectedRows[0].Cells[75].Value.ToString().Trim().Equals("0"))
            {
                KryptonMessageBox.Show(@"ESTA OPCIÓN SÓLO ES VÁLIDA PARA REGISTROS DEL PERSONAL ACTIVO!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                return;
            }

            if (KryptonMessageBox.Show(@"Seguro que desea cambiar el puesto para: " + dgvDetallesRol.SelectedRows[0].Cells[5].Value + @"?", "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo,
                    KryptonMessageBoxIcon.Question) != DialogResult.Yes) return;

            _frmBuscarPuestoTrabajo = new FrmBuscarPuestoTrabajo { Label3 = { Text = @"SELECCIONE EL PUESTO CORRESPONDIENTE" }, TipoCon = TipoCon };
            try
            {
                if (_frmBuscarPuestoTrabajo.ShowDialog() != DialogResult.OK) return;
                var row = dgvDetallesRol.CurrentRow;
                dgvDetallesRol.Rows.Remove(dgvDetallesRol.CurrentRow);

                var xx = dgvDetallesRol.Rows.Cast<DataGridViewRow>().TakeWhile(r => !r.Cells[3].Value.ToString().Trim().Equals(_frmBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[18].Text.Trim()) || !r.Cells[4].Value.ToString().Trim().Equals(_frmBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[2].Text.Trim())).Count();

                var indret = (from DataGridViewRow rox in dgvDetallesRol.Rows where (rox.Cells[0].Value + "").Trim().Equals("RETIRADOS") select rox.Index).FirstOrDefault();

                if (xx >= indret) xx = indret - 4;

                row.Cells[3].Value = _frmBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[18].Text;
                row.Cells[4].Value = _frmBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[2].Text.Trim();

                // hora segun puesto
                var pu = _objetoSitio.BuscarDatosSitioxIdSitio(TipoCon, _frmBuscarPuestoTrabajo.ListView1.SelectedItems[0].SubItems[0].Text.Trim());
                try
                {
                    row.Cells[18].Value = pu.Rows[0][17].ToString(); // hnor
                    row.Cells[21].Value = pu.Rows[0][18].ToString(); // h50
                    row.Cells[24].Value = pu.Rows[0][19].ToString(); // h100
                    row.Cells[27].Value = pu.Rows[0][20].ToString(); // hext
                    row.Cells[30].Value = pu.Rows[0][21].ToString(); // recnoc
                    row.Cells[31].Value = pu.Rows[0][22].ToString(); // adic
                }
                catch
                {
                    row.Cells[18].Value = 0; // hnor
                    row.Cells[21].Value = 0; // h50
                    row.Cells[24].Value = 0; // h100
                    row.Cells[27].Value = 0; // hext
                    row.Cells[30].Value = 0; // recnoc
                    row.Cells[31].Value = 0; // adic
                }

                dgvDetallesRol.Rows.Insert(xx, row);

                dgvDetallesRol.Refresh();

                ReajusarIndice(0, 1);

                CalcularDatosFilaRol(xx);

                dgvDetallesRol.Rows[xx].Selected = true;
                dgvDetallesRol.FirstDisplayedScrollingRowIndex = xx;

                SumatoriasRol();
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL CAMBIAR DE PUESTO!", "Mensaje del Sistema",
                      KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDetallesRol.Rows[2].Selected = true;
            if (dgvDetallesRol.CurrentRow == null) return;
            if (dgvDetallesRol.RowCount == 0 || dgvDetallesRol.SelectedRows.Count == 0) return;

            if (dgvDetallesRol.SelectedRows[0].Cells[1].Value == null || dgvDetallesRol.SelectedRows[0].Cells[1].Value.ToString().Length == 0) return;
            if (Convert.ToInt32(dgvDetallesRol.SelectedRows[0].Cells[1].Value) == 0) return;

            _frmAgregarPersonalRol = new FrmAgregarPersonalRolPago { TipoCon = TipoCon };
            try
            {
                if (_frmAgregarPersonalRol.ShowDialog() != DialogResult.OK) return;

                var ex = dgvDetallesRol.Rows.Cast<DataGridViewRow>().Any(row => (row.Cells[1].Value + "").Trim().Equals(_frmAgregarPersonalRol.txtIdPersonal.Text.Trim()));
                if (ex)
                {
                    KryptonMessageBox.Show(_frmAgregarPersonalRol.txtPersonal.Text.Trim() + @" YA SE ENCUENTRA AGREGADO EN EL ROL DE PAGO!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
                    return;
                }

                if (cbxQuincena.SelectedIndex == 0 && _frmAgregarPersonalRol.cbxEstado.SelectedIndex == 1)
                {
                    KryptonMessageBox.Show("NO SE PERMITE 'RETIRADOS' EN ROL QUINCENA, POR FAVOR AGRÉGUELO COMO 'ACTIVO' O CONTACTE AL ADMINISTRADOR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
                    return;
                }
                 
                var dataper = _objRolPago.SeleccionarDetallesPersonalRolPorIdPersonal(TipoCon, Convert.ToInt64(_frmAgregarPersonalRol.txtIdPersonal.Text));
                if (dataper.Rows.Count > 0)
                {
                    var idr = -1;
                    //var r = false;
                    var indret = (from DataGridViewRow rox in dgvDetallesRol.Rows where (rox.Cells[0].Value + "").Trim().Equals("RETIRADOS") select rox.Index).FirstOrDefault();

                    if (_frmAgregarPersonalRol.cbxEstado.SelectedIndex == 0) // activos
                    {
                        foreach (DataGridViewRow row in dgvDetallesRol.Rows)
                        {
                            if ((row.Cells[3].Value + "").Trim().Equals(_frmAgregarPersonalRol.txtCliente.Text.Trim()) && !(row.Cells[0].Value + "").Trim().Equals("") && !(row.Cells[0].Value + "").Trim().Equals("RETIRADOS"))
                            {
                                idr = row.Index;
                                break;
                            }
                        }
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dgvDetallesRol.Rows) // retirados
                        {
                            if ((row.Cells[0].Value + "").Trim().Equals("RETIRADOS") && !(row.Cells[1].Value + "").Trim().Equals("") && !(row.Cells[1].Value + "").Trim().Equals("0"))
                            {
                                idr = row.Index;
                                break;
                            }
                        }
                    }


                    // AGREGAR NUEVO VIGILANTE, AJUSTAR INDICES
                    DataGridViewRow copia = null;
                    if (_frmAgregarPersonalRol.cbxEstado.SelectedIndex == 0)
                    {
                        if (idr == -1)
                        {
                            if (indret > 0) idr = cbxQuincena.SelectedIndex == 0 ? indret - 1 : indret - 4;
                            else idr = dgvDetallesRol.RowCount - 2;
                        }                        
                        copia = (DataGridViewRow)dgvDetallesRol.Rows[idr].Clone();
                    }
                    else
                    {
                        if (idr == -1)
                        {
                            if (indret > 0) idr = indret;
                            else idr = dgvDetallesRol.RowCount - 2;
                        }
                        copia = (DataGridViewRow)dgvDetallesRol.Rows[idr].Clone();
                        //r = true;
                    }

                    if (copia != null)
                    {
                        var n = Convert.ToInt32(dgvDetallesRol.Rows[idr].Cells[2].Value);

                        for (var x = 0; x < dgvDetallesRol.Columns.Count - 1; x++) 
                            copia.Cells[x].Value = dgvDetallesRol.Rows[idr].Cells[x].Value;
                                                

                        copia.Cells[1].Value = dataper.Rows[0][0].ToString();
                        //copia.Cells[2].Value = n;
                        copia.Cells[3].Value = _frmAgregarPersonalRol.txtCliente.Text.Trim();
                        copia.Cells[4].Value = _frmAgregarPersonalRol.txtUbicacionPuesto.Text.Trim();
                        copia.Cells[5].Value = _frmAgregarPersonalRol.txtPersonal.Text.Trim();
                        copia.Cells[6].Value = dataper.Rows[0][1].ToString(); // cedula
                        copia.Cells[7].Value = dataper.Rows[0][6].ToString(); // nacim
                        copia.Cells[8].Value = dataper.Rows[0][8].ToString(); // ciud 
                        copia.Cells[9].Value = Convert.ToDateTime(dataper.Rows[0][16]); // ingreso
                        copia.Cells[10].Value = _frmAgregarPersonalRol.txtCargo.Text.Trim();
                        copia.Cells[11].Value = _frmAgregarPersonalRol.txtArea.Text.Trim();
                        copia.Cells[12].Value = cbxTipo.SelectedIndex == 0 ? _objRolParametrosRolPago.SueldoVigilantes : Convert.ToDouble(dataper.Rows[0][9]);
                        copia.Cells[13].Value = 30;
                        copia.Cells[14].Value = cbxTipo.SelectedIndex == 0 ? _objRolParametrosRolPago.SueldoVigilantes : Convert.ToDouble(dataper.Rows[0][9]);
                        copia.Cells[15].Value = 0;
                        copia.Cells[16].Value = cbxTipo.SelectedIndex == 0 ? _objRolParametrosRolPago.SueldoVigilantes : Convert.ToDouble(dataper.Rows[0][9]);
                        copia.Cells[17].Value = cbxTipo.SelectedIndex == 0 ? _objRolParametrosRolPago.SueldoVigilantes : Convert.ToDouble(dataper.Rows[0][9]);

                        for (var i = 18; i < 66; i++)
                        {
                            if (i == 19 || i == 22 || i == 25 || i == 28 || i == 43 || i == 62) continue;
                            copia.Cells[i].Value = 0;
                        }

                        // pension xiiiv
                        copia.Cells[36].Value = 0; //  pensionxiii
                        copia.Cells[38].Value = 0;  //  pensionxiv

                        // hora segun puesto
                        var pu = _objetoSitio.BuscarDatosSitioxIdSitio(TipoCon, _frmAgregarPersonalRol.txtIdPuesto.Text.Trim());
                        try
                        {
                            copia.Cells[18].Value = pu.Rows[0][17].ToString(); // hnor
                            copia.Cells[21].Value = pu.Rows[0][18].ToString(); // h50
                            copia.Cells[24].Value = pu.Rows[0][19].ToString(); // h100
                            copia.Cells[27].Value = pu.Rows[0][20].ToString(); // hext
                            copia.Cells[30].Value = pu.Rows[0][21].ToString(); // recnoc
                            copia.Cells[31].Value = pu.Rows[0][22].ToString(); // adic
                            copia.Cells[71].Value = pu.Rows[0][23].ToString().Equals("1"); // XIII FON EXT
                        }
                        catch
                        {
                            copia.Cells[18].Value = 0; // hnor
                            copia.Cells[21].Value = 0; // h50
                            copia.Cells[24].Value = 0; // h100
                            copia.Cells[27].Value = 0; // hext
                            copia.Cells[30].Value = 0; // recnoc
                            copia.Cells[31].Value = 0; // adic
                            copia.Cells[71].Value = 0;// XIII FON EXT
                        }
                        //cambio 
                        copia.Cells[65].Value = dataper.Rows[0][74].ToString(); // extra

                        copia.Cells[66].Value = dataper.Rows[0][69].ToString().Equals("1"); // FON RES
                        copia.Cells[67].Value = dataper.Rows[0][70].ToString().Equals("1"); // XIII
                        copia.Cells[68].Value = dataper.Rows[0][71].ToString().Equals("1"); // XIV
                        copia.Cells[69].Value = dataper.Rows[0][74].ToString().Equals("1"); // ACU FRE
                        copia.Cells[70].Value = dataper.Rows[0][75].ToString().Equals("1"); // DESC SEG

                        copia.Cells[72].Value = dataper.Rows[0][86].ToString(); // ID BANCO
                        copia.Cells[73].Value = dataper.Rows[0][91].ToString(); // BANCO
                        copia.Cells[74].Value = dataper.Rows[0][87].ToString(); // CUENTA
                        copia.Cells[75].Value = dataper.Rows[0][88].ToString(); // TIPO
                        copia.Cells[76].Value = _frmAgregarPersonalRol.cbxEstado.SelectedIndex == 0 ? 1 : 0;

                        if (copia.Cells[76].Value.ToString().Equals("0")) copia.DefaultCellStyle.BackColor = Color.LightSalmon;


                        copia.Cells[77].Value = 0;

                        copia.Cells[78].Value = dataper.Rows[0][77].ToString().Equals("1"); // EXT SAL

                        dgvDetallesRol.Rows.Insert(idr, copia);
                        dgvDetallesRol.AutoResizeRows();

                        ReajusarIndice(idr, n);

                        CalcularDatosFilaRol(idr);

                        dgvDetallesRol.Rows[idr].Selected = true;
                        dgvDetallesRol.FirstDisplayedScrollingRowIndex = idr;

                        //agregar descuentos
                        var ingdes = _objRolPago.SeleccionarDetallesDescuentosIdPersonalRolPago(TipoCon, dtpMesAnio.Value.Month, dtpMesAnio.Value.Year, Convert.ToInt32(dgvDetallesRol.Rows[idr].Cells[1].Value));
                        foreach (DataRow fil in ingdes.Rows)
                        {
                            if (Convert.ToInt32(dgvDetallesRol.Rows[idr].Cells[1].Value) == Convert.ToInt32(fil[0]))
                            {
                                dgvDetallesRol.Rows[idr].Cells[45].Value = fil[16] == DBNull.Value ? 0 : fil[16]; //  quincena
                                dgvDetallesRol.Rows[idr].Cells[46].Value = fil[3]; //  quirografario
                                dgvDetallesRol.Rows[idr].Cells[47].Value = fil[4]; //  hipotecario
                                dgvDetallesRol.Rows[idr].Cells[48].Value = fil[5]; //  saludconyuge
                                dgvDetallesRol.Rows[idr].Cells[49].Value = fil[6]; //  emergente
                                dgvDetallesRol.Rows[idr].Cells[50].Value = fil[7]; //  capaseg
                                dgvDetallesRol.Rows[idr].Cells[51].Value = fil[8]; //  varios
                                dgvDetallesRol.Rows[idr].Cells[52].Value = fil[9]; //  empresa
                                dgvDetallesRol.Rows[idr].Cells[53].Value = fil[10];//  comecsa
                                dgvDetallesRol.Rows[idr].Cells[54].Value = fil[11];//  comisariato
                                dgvDetallesRol.Rows[idr].Cells[55].Value = fil[12];//  bodegaseg
                                dgvDetallesRol.Rows[idr].Cells[56].Value = fil[19];//  almuerzo
                                dgvDetallesRol.Rows[idr].Cells[57].Value = Convert.ToDouble(fil[17]) + Convert.ToDouble(fil[18]);//  pension xiii + xiv
                                dgvDetallesRol.Rows[idr].Cells[58].Value = fil[15];//  pensionalim
                                dgvDetallesRol.Rows[idr].Cells[59].Value = fil[13];//  multas
                                dgvDetallesRol.Rows[idr].Cells[60].Value = fil[20];//  diasnolab
                         
                                if (cbxQuincena.SelectedIndex == 1)
                                {
                                    dgvDetallesRol.Rows[idr].Cells[62].Value = (cbxTipo.SelectedIndex == 1 ? _objRolParametrosRolPago.OtrosDescuentosAdmin :
                                        _objRolParametrosRolPago.OtrosDescuentosOperativos) + Convert.ToDouble(fil[14]); // otros                             
                                }
                                else dgvDetallesRol.Rows[idr].Cells[62].Value = fil[14]; // otros

                                CalcularDatosFilaRol(dgvDetallesRol.Rows[idr].Index);
                            }
                        }

                        SumatoriasRol();

                        _cantRol += 1;
                        Label14.Text = @"DETALLES GENERALES ROL DE PAGO - " + _cantRol + @" REGISTRO(S) EN TOTAL";
                    }
                    else KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL AGREGAR FILA!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
                }
                else KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL CARGAR DATOS PERSONALES (CONTRATO / CUENTA BANCARIA)!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL REALIZAR ESTA ACCIÓN!!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
            }
        }

        private void dgvDetallesRol_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDetallesRol.RowCount == 0) return;
            if (dgvDetallesRol.CurrentRow == null) return;
            if (dgvDetallesRol.CurrentRow.Cells[0].Value == DBNull.Value) return;
            if (Convert.ToInt32(dgvDetallesRol.CurrentRow.Cells[1].Value) == 0) return;

           
            try
            {

               
                _frmDetealleAsistenciaRol = new FrmDetalleAsistenciaRol
                {

                  

                textBox1 =
                    {
                        Tag = dgvDetallesRol.CurrentRow.Cells[1].Value.ToString(),//id_personal
                        Text = dgvDetallesRol.CurrentRow.Cells[5].Value.ToString()//nomina
                    },
                    DateTimePicker7 = { Value = dtpDesde.Value },
                    DateTimePicker6 = { Value = dtpHasta.Value },
                    TipoCon = TipoCon,
                    Admin = dgvDetallesRol.CurrentRow.Cells[0].Value.ToString().Equals("ADMINISTRATIVO"),
                    Fila = dgvDetallesRol.CurrentRow,
                    IdRol = lblIdRol.Text,
                    Hoy = Usuario.Now(TipoCon).ToShortDateString(),
                    Mes1 = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpMesAnio.Value.Month).ToUpper(),
                    Anio = dtpMesAnio.Value.Year.ToString(),

            };
                _frmDetealleAsistenciaRol.ShowDialog();
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL MOSTRAR DETALLE DE ASISTENCIA!!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
            }
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            var parms = _objRolPago.SeleccionarDetallesParametrosPersonal(TipoCon);
            foreach (DataGridViewRow row in dgvDetallesRol.Rows)
            {
                if ((row.Cells[1].Value + "").Trim().Length == 0) continue;
                if (Convert.ToInt32(row.Cells[1].Value) == 0) continue;

                foreach (DataRow fil in parms.Rows)
                {
                    if (!row.Cells[1].Value.ToString().Equals(fil[0].ToString())) continue;

                    row.Cells[72].Value = fil[6];  //  idbanco
                    row.Cells[73].Value = fil[7];  //  banco
                    row.Cells[74].Value = fil[8];  //  cuenta
                    row.Cells[75].Value = fil[9];  //  tipo

                    row.Cells[7].Value = fil[14];  //  fecha nacim
                    row.Cells[8].Value = fil[15];  //  ciudad
                    row.Cells[9].Value = fil[10];  //  ingreso
                    row.Cells[10].Value = fil[11];  //  cargo
                    row.Cells[11].Value = fil[12];  //  area
                    row.Cells[12].Value = cbxTipo.SelectedIndex == 0 ? _objRolParametrosRolPago.SueldoVigilantes : fil[13];  //  sueldo

                    CalcularDatosFilaRol(row.Index);
                }
            }
            SumatoriasRol();
        }

        private void dgvDetallesRol_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetallesRol.CurrentRow != null) Console.WriteLine(dgvDetallesRol.CurrentRow.Index);
        }

        private void dgvDetallesRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInformePago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInformePago_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dgvDetallesRol.CurrentRow == null) return;
            if (dgvDetallesRol.CurrentRow.Cells[0].Value == DBNull.Value) return;
            var fila1 = dgvDetallesRol.CurrentRow;

            string empre = Validaciones.NombreCompany(TipoCon);
            var Hoy = Usuario.Now(TipoCon).ToShortDateString();
            var Mes1 = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpMesAnio.Value.Month).ToUpper();
            var Anio = dtpMesAnio.Value.Year.ToString();
            var Admin = dgvDetallesRol.CurrentRow.Cells[0].Value.ToString().Equals("ADMINISTRATIVO");
            var rpt = new rptPlanillaPagoBasicoTodos();
            
            try
            {
                                              
                           var ids = (from DataGridViewRow row in dgvDetallesRol.Rows
                           where row.Cells[1].Value != null && row.Cells[1].Value != DBNull.Value
                           select row.Cells[1].Value.ToString()).ToList();

                _rptPlanilla.SetDataSource(_objDetaRolPago.SeleccionarDetalleRolLista(TipoCon,ids,Convert.ToInt32(lblIdRol.Text)));
                //rpt.SetDataSource(_objDetaRolPago.SeleccionarDetalleRolLista(TipoCon,ids,Convert.ToInt32(lblIdRol.Text)));
                _rptPlanilla.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, System.Windows.Forms.Application.StartupPath));
                _rptPlanilla.SetParameterValue("fecha", Hoy);
                _rptPlanilla.SetParameterValue("empre", empre);
                _rptPlanilla.SetParameterValue("mes", Mes1);
                _rptPlanilla.SetParameterValue("anio", Anio);


                //_rptPlanilla.SetParameterValue("banco", (fila1.Cells[72].Value != null && fila1.Cells[72].Value.ToString().Trim() != "0")
                //? fila1.Cells[73].Value + " - " + fila1.Cells[74].Value + " (" + fila1.Cells[75].Value + ")" : "SIN BANCO - PAGADO EN CHEQUE");
                
                //var txtReportHeader = rpt.ReportDefinition.ReportObjects["Text64"] as TextObject;
                //txtReportHeader.Text = Admin ? "DESC. DIF. DEC. EXT:" : "DES. DIA NO LAB:";


                crvReporteRol.ReportSource = _rptPlanilla;
                crvReporteRol.Zoom(2);
                crvReporteRol.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
                crvReporteRol.ReportSource = null;
            }
        
        }

        private void TabResumenRol_Click(object sender, EventArgs e)
        {

        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {

            if (dgvDetallesRol.CurrentRow == null) return;
            if (dgvDetallesRol.CurrentRow.Cells[0].Value == DBNull.Value) return;
            var fila1 = dgvDetallesRol.CurrentRow;

            string empre = Validaciones.NombreCompany(TipoCon);
            var Hoy = Usuario.Now(TipoCon).ToShortDateString();
            var Mes1 = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpMesAnio.Value.Month).ToUpper();
            var Anio = dtpMesAnio.Value.Year.ToString();
            var Admin = dgvDetallesRol.CurrentRow.Cells[0].Value.ToString().Equals("ADMINISTRATIVO");
            var rpt = new rptPlanillaPagoBasicoTodos();

            try
            {

                var ids = (from DataGridViewRow row in dgvDetallesRol.Rows
                           where row.Cells[1].Value != null && row.Cells[1].Value != DBNull.Value
                           select row.Cells[1].Value.ToString()).ToList();

                _rptPlanilla.SetDataSource(_objDetaRolPago.SeleccionarDetalleRolLista(TipoCon, ids, Convert.ToInt32(lblIdRol.Text)));
                //rpt.SetDataSource(_objDetaRolPago.SeleccionarDetalleRolLista(TipoCon,ids,Convert.ToInt32(lblIdRol.Text)));
                _rptPlanilla.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, System.Windows.Forms.Application.StartupPath));
                _rptPlanilla.SetParameterValue("fecha", Hoy);
                _rptPlanilla.SetParameterValue("empre", empre);
                _rptPlanilla.SetParameterValue("mes", Mes1);
                _rptPlanilla.SetParameterValue("anio", Anio);


                //_rptPlanilla.SetParameterValue("banco", (fila1.Cells[72].Value != null && fila1.Cells[72].Value.ToString().Trim() != "0")
                //? fila1.Cells[73].Value + " - " + fila1.Cells[74].Value + " (" + fila1.Cells[75].Value + ")" : "SIN BANCO - PAGADO EN CHEQUE");

                //var txtReportHeader = rpt.ReportDefinition.ReportObjects["Text64"] as TextObject;
                //txtReportHeader.Text = Admin ? "DESC. DIF. DEC. EXT:" : "DES. DIA NO LAB:";


                crvReporteRol.ReportSource = _rptPlanilla;
                crvReporteRol.Zoom(2);
                crvReporteRol.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
                crvReporteRol.ReportSource = null;
            }

        }
    }
}