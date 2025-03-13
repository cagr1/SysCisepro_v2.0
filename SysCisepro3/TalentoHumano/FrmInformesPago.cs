using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using Office = Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using Font = System.Drawing.Font;
using ClassLibraryCisepro3.Estaticas;
using System.IO;
using ClassLibraryCisepro3.EstructuraEmpresa;
using Krypton.Toolkit;
using ClosedXML.Excel;
using System.Diagnostics;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmInformesPago : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para visualizar roles e informes de pago del personal
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmInformesPago _instance;
        public static FrmInformesPago Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmInformesPago();
                return _instance;
            }
        }
        private readonly ClassDetallesRol _objDetaRolPago;
        private readonly ClassUsuarioGeneral _objEmpresa;
        private readonly ClassBancos _objBancos;

        private readonly List<int> _indices;
        private bool _varios;
        private double _ing;
        private double _des;
        private double _afra = 0.0;
        private double _afro = 0.0;


        private double _tot;
        private readonly List<string> _grupos;
        private readonly List<string> _cuentas;

        private bool _rep;
        private int _mes;
        private int _anio;

        private FrmInformesPago()
        {
            InitializeComponent();
            _objDetaRolPago = new ClassDetallesRol();
            _objEmpresa = new ClassUsuarioGeneral();
            _objBancos = new ClassBancos();
            _indices = new List<int>();
            _grupos = new List<string>();
            _cuentas = new List<string>();

            if (dgvInformePago.Columns["DataGridViewTextBoxColumn173"] != null) dgvInformePago.Columns["DataGridViewTextBoxColumn173"].DefaultCellStyle.Format = "d";
            if (dgvInformePago.Columns["Column14"] != null) dgvInformePago.Columns["Column14"].DefaultCellStyle.Format = "d";

            if (dgvDetallesRol.Columns["Column6"] != null) dgvDetallesRol.Columns["Column6"].DefaultCellStyle.Format = "d"; // INGRESO
            if (dgvDetallesRol.Columns["Column9"] != null) dgvDetallesRol.Columns["Column9"].DefaultCellStyle.Format = "d"; // NACIMIENTO

            if (dgvHorasExtra.Columns["dataGridViewTextBoxColumn8"] != null) dgvHorasExtra.Columns["dataGridViewTextBoxColumn8"].DefaultCellStyle.Format = "d"; // INGRESO
            if (dgvHorasExtra.Columns["dataGridViewTextBoxColumn10"] != null) dgvHorasExtra.Columns["dataGridViewTextBoxColumn10"].DefaultCellStyle.Format = "d"; // NACIMIENTO 
        }

        private void FrmInformesPago_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            //toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            
            
            dgvDetallesRol.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvInformePago.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvHorasExtra.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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
            dgvDetallesRol.Font = new Font("Roboto", 8, FontStyle.Regular);
            dgvInformePago.Font = new Font("Roboto", 8, FontStyle.Regular);
            dgvHorasExtra.Font = new Font("Roboto", 8, FontStyle.Regular);

            btnAnt.Tag = 0;
            btnSig.Tag = 0;
            btnResumen.Tag = null;

            ValidationForms.SetPlaceholder(TextBox1, "BUSCAR...");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmBuscarRolPago { TipoCon = TipoCon, Usuario = Usuario, MultiSelect = true };
                if (frm.ShowDialog() != DialogResult.OK) return;
                if (frm.dgvRoles.CurrentRow == null) return;

                dgvDetallesRol.Rows.Clear();
                dgvInformePago.Rows.Clear();
                dgvHorasExtra.Rows.Clear();

                _ing = 0.0;
                _des = 0.0;
                _afra = 0.0;
                _afro = 0.0;
                _tot = 0.0;
                _varios = frm.Roles.Count > 1;
                _grupos.Clear();
                _mes = frm.Mes;
                _anio = frm.Anio;

                dtpMesExtra.Value = new DateTime(_anio, _mes, 1);

                foreach (var idrol in frm.Roles) CargarDetallesRol(idrol);
                foreach (var grupo in frm.Grupos) _grupos.Add(grupo);

                txtTotIngresos.Text = _ing.ToString("N");
                txtTotDescuentos.Text = _des.ToString("N");
                txtTotCobrar.Text = _tot.ToString("N");

                txtAcfoAd.Text = _afra.ToString("N");
                txtAcfoOp.Text = _afro.ToString("N");
                txtAcfonRes.Text = (_afra + _afro).ToString("N");

                dgvDetallesRol.AutoResizeRows();
                dgvDetallesRol.ReadOnly = true;

                if (_varios && dgvDetallesRol.RowCount > 0) dgvDetallesRol.Rows.RemoveAt(dgvDetallesRol.RowCount - 1); // quitar fila blanca al final

                btnResumen.Enabled = true;
            }
            catch
            {
                KryptonMessageBox.Show(@"Ocurrió un problema al seleccionar el ROL DE PAGO! Por favor, contácte al administrador", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void CargarDetallesRol(int idRol)
        {
            try
            {
                var data = _objDetaRolPago.SeleccionarDatosRolPago(TipoCon, idRol);
                if (data.Rows.Count == 0) return;

                foreach (DataRow row in data.Rows)
                {
                    if ((row[1] + "").Trim().Equals("0") && (row[2] + "").Trim().Equals("0"))
                    {
                        if ((row[3] + "").Trim().Equals("TOTAL GRUPO " + row[0]))
                        {
                            dgvDetallesRol.Rows.Add(row[0], null, null, row[3], null, null, null, null, null, null, null,
                                null,
                                Convert.ToDouble(row[10]).ToString("N"),
                                row[11],
                                Convert.ToDouble(row[12]).ToString("N"),
                                row[13],
                                Convert.ToDouble(row[14]).ToString("N"),
                                Convert.ToDouble(row[15]).ToString("N"),

                                Convert.ToDouble(row[16]).ToString("N"), Convert.ToDouble(row[17]).ToString("N"),
                                Convert.ToDouble(row[18]).ToString("N"),
                                Convert.ToDouble(row[19]).ToString("N"), Convert.ToDouble(row[20]).ToString("N"),
                                Convert.ToDouble(row[21]).ToString("N"),
                                Convert.ToDouble(row[22]).ToString("N"), Convert.ToDouble(row[23]).ToString("N"),
                                Convert.ToDouble(row[24]).ToString("N"),
                                Convert.ToDouble(row[25]).ToString("N"), Convert.ToDouble(row[26]).ToString("N"),
                                Convert.ToDouble(row[27]).ToString("N"),

                                Convert.ToDouble(row[28]).ToString("N"), Convert.ToDouble(row[29]).ToString("N"),
                                Convert.ToDouble(row[30]).ToString("N"),
                                Convert.ToDouble(row[31]).ToString("N"), Convert.ToDouble(row[32]).ToString("N"),
                                Convert.ToDouble(row[33]).ToString("N"),
                                Convert.ToDouble(row[34]).ToString("N"), Convert.ToDouble(row[35]).ToString("N"),
                                Convert.ToDouble(row[36]).ToString("N"),
                                Convert.ToDouble(row[37]).ToString("N"), Convert.ToDouble(row[38]).ToString("N"),
                                Convert.ToDouble(row[39]).ToString("N"),
                                Convert.ToDouble(row[40]).ToString("N"), string.Empty,

                                Convert.ToDouble(row[42]).ToString("N"), Convert.ToDouble(row[43]).ToString("N"),
                                Convert.ToDouble(row[44]).ToString("N"), Convert.ToDouble(row[45]).ToString("N"),

                                Convert.ToDouble(row[46]).ToString("N"), Convert.ToDouble(row[47]).ToString("N"),
                                Convert.ToDouble(row[48]).ToString("N"), Convert.ToDouble(row[49]).ToString("N"),
                                Convert.ToDouble(row[50]).ToString("N"), Convert.ToDouble(row[51]).ToString("N"),
                                Convert.ToDouble(row[52]).ToString("N"), Convert.ToDouble(row[53]).ToString("N"),

                                Convert.ToDouble(row[79]).ToString("N"),

                                Convert.ToDouble(row[54]).ToString("N"), Convert.ToDouble(row[55]).ToString("N"),
                                Convert.ToDouble(row[56]).ToString("N"),

                                // disd no lab, dif dec fon
                                Convert.ToDouble(row[81]).ToString("N"), Convert.ToDouble(row[82]).ToString("N"),


                                Convert.ToDouble(row[57]).ToString("N"),
                                Convert.ToDouble(row[58]).ToString("N"), Convert.ToDouble(row[59]).ToString("N"),

                                Convert.ToDouble(row[60]).ToString("N"),

                                row[61].ToString().Equals("1"), row[62].ToString().Equals("1"),
                                row[63].ToString().Equals("1"), row[64].ToString().Equals("1"),
                                row[65].ToString().Equals("1"), row[66].ToString().Equals("1"),


                                row[68].ToString(), row[69].ToString(), row[70].ToString(), row[71].ToString().Trim(),
                                row[72].ToString(), row[78].ToString(), row[80].ToString().Equals("1"));

                            _ing += Convert.ToDouble(row[40]);
                            _des += Convert.ToDouble(row[58]);
                            _tot += Convert.ToDouble(row[59]);

                            if ((row[0] + "").Trim().Equals("ADMINISTRATIVO")) _afra += Convert.ToDouble(row[78]);
                            else _afro += Convert.ToDouble(row[78]);
                        }
                        else dgvDetallesRol.Rows.Add(row[0], null, null, row[3]); 
                    }
                    else
                    {
                        dgvDetallesRol.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6],
                            row[76].ToString().Contains("1900") ? string.Empty : row[76], row[77], row[7], row[8],
                            row[9],
                            Convert.ToDouble(row[10]).ToString("N"),
                            row[11],
                            Convert.ToDouble(row[12]).ToString("N"),
                            row[13],
                            Convert.ToDouble(row[14]).ToString("N"),
                            Convert.ToDouble(row[15]).ToString("N"),

                            Convert.ToDouble(row[16]).ToString("N"), Convert.ToDouble(row[17]).ToString("N"),
                                Convert.ToDouble(row[18]).ToString("N"),
                                Convert.ToDouble(row[19]).ToString("N"), Convert.ToDouble(row[20]).ToString("N"),
                                Convert.ToDouble(row[21]).ToString("N"),
                                Convert.ToDouble(row[22]).ToString("N"), Convert.ToDouble(row[23]).ToString("N"),
                                Convert.ToDouble(row[24]).ToString("N"),
                                Convert.ToDouble(row[25]).ToString("N"), Convert.ToDouble(row[26]).ToString("N"),
                                Convert.ToDouble(row[27]).ToString("N"),

                                Convert.ToDouble(row[28]).ToString("N"), Convert.ToDouble(row[29]).ToString("N"),
                                Convert.ToDouble(row[30]).ToString("N"),
                                Convert.ToDouble(row[31]).ToString("N"), Convert.ToDouble(row[32]).ToString("N"),
                                Convert.ToDouble(row[33]).ToString("N"),
                                Convert.ToDouble(row[34]).ToString("N"), Convert.ToDouble(row[35]).ToString("N"),
                                Convert.ToDouble(row[36]).ToString("N"),
                                Convert.ToDouble(row[37]).ToString("N"), Convert.ToDouble(row[38]).ToString("N"),
                                Convert.ToDouble(row[39]).ToString("N"),
                                Convert.ToDouble(row[40]).ToString("N"), string.Empty,

                                Convert.ToDouble(row[42]).ToString("N"), Convert.ToDouble(row[43]).ToString("N"),
                                Convert.ToDouble(row[44]).ToString("N"), Convert.ToDouble(row[45]).ToString("N"),
                                Convert.ToDouble(row[46]).ToString("N"), Convert.ToDouble(row[47]).ToString("N"),
                                Convert.ToDouble(row[48]).ToString("N"), Convert.ToDouble(row[49]).ToString("N"),
                                Convert.ToDouble(row[50]).ToString("N"), Convert.ToDouble(row[51]).ToString("N"),
                                Convert.ToDouble(row[52]).ToString("N"), Convert.ToDouble(row[53]).ToString("N"),
                                Convert.ToDouble(row[79]).ToString("N"),

                                Convert.ToDouble(row[54]).ToString("N"), Convert.ToDouble(row[55]).ToString("N"),
                                Convert.ToDouble(row[56]).ToString("N"),

                                 // disd no lab, dif dec fon
                                Convert.ToDouble(row[81]).ToString("N"), Convert.ToDouble(row[82]).ToString("N"), 

                                Convert.ToDouble(row[57]).ToString("N"),
                                Convert.ToDouble(row[58]).ToString("N"), Convert.ToDouble(row[59]).ToString("N"),

                                Convert.ToDouble(row[60]).ToString("N"),

                                row[61].ToString().Equals("1"), row[62].ToString().Equals("1"),
                                row[63].ToString().Equals("1"), row[64].ToString().Equals("1"),
                                row[65].ToString().Equals("1"), row[66].ToString().Equals("1"),


                                row[68].ToString(), row[69].ToString(), row[70].ToString(), row[71].ToString().Trim(),
                                row[72].ToString(), row[78].ToString(), row[80].ToString().Equals("1"));

                    }

                    if ((row[75] + "").Equals("1"))
                    {
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI",
                            8, FontStyle.Bold);
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor = Color.Black;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.ForeColor = Color.White;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 1;
                    }
                    if ((row[75] + "").Equals("2"))
                    {
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI",
                            8, FontStyle.Bold);
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor =
                            SystemColors.ControlDarkDark;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 2;
                    }
                    if ((row[75] + "").Equals("3"))
                    {
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.BackColor =
                            SystemColors.Control;
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI",
                            8, FontStyle.Bold);
                        dgvDetallesRol.Rows[(dgvDetallesRol.RowCount - 1)].Tag = 3;
                    }

                    if ((Convert.ToInt32(row[1]) > 0) && row[72].ToString().Equals("0")) dgvDetallesRol.Rows[dgvDetallesRol.RowCount - 1].DefaultCellStyle.BackColor = Color.LightSalmon;
                }

                if (_varios) dgvDetallesRol.Rows.Add(); // fila en blanco para separar
            }
            catch
            {
                KryptonMessageBox.Show(@"Ocurrió un problema al cargar los detalles del ROL DE PAGO! Por favor, contácte al administrador", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (dgvDetallesRol.RowCount == 0)
            {
                KryptonMessageBox.Show("PRIMERO DEBE SELECCIONAR LOS ROLES DE PAGO!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
                return;
            }

            // BANCOS
            var bancos = _objBancos.SeleccionarRegistrosBancosRolesDict(TipoCon);
            if (bancos.Count == 0)
            {
                KryptonMessageBox.Show(@"No se ha cargado la información de los bancos. Por favor, contácte al administrador!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            var data = _objEmpresa.GetDatosEmpresa(TipoCon);
            lblEmpresa.Text = data.Rows.Count > 0 ? data.Rows[0][4].ToString().Trim() : string.Empty;
            lblRuc.Text = data.Rows.Count > 0 ? data.Rows[0][2].ToString().Trim() : string.Empty;
            
            dgvInformePago.Rows.Clear();
            dgvHorasExtra.Rows.Clear();
            chkFondos.Checked = true;

            _cuentas.Clear();
            _rep = false;

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
                    continue;
                }
                if ((row.Cells[0].Value + "").Trim().Length == 0) row.Cells[0].Value = "";
                if ((row.Cells[3].Value + "").Trim().Length == 0) row.Cells[3].Value = "";
            }

            var grupos = new DataTable();
            grupos.Columns.Add("grupo");
            foreach (var grupo in _grupos) grupos.Rows.Add(grupo);
            grupos.Rows.Add("RETIRADOS");

            var f = 1;
            var ti = 0.0;

            var tgr = (btnResumen.Tag + "").Trim();
            tgr = tgr.EndsWith(";") ? tgr.Substring(0, tgr.Length - 1) : tgr;

            var tbg = 0;
            var tbm = 0;
            var tbp = 0;
            var tbc = 0;
            var tbr = 0;

            var txt = 0.0;

            if (dgvInformePago.Columns["DataGridViewTextBoxColumn173"] != null) dgvInformePago.Columns["DataGridViewTextBoxColumn173"].DefaultCellStyle.Format = "d";
            if (dgvInformePago.Columns["Column14"] != null) dgvInformePago.Columns["Column14"].DefaultCellStyle.Format = "d";

            foreach (DataRow grupo in grupos.Rows)
            {
                foreach (DataGridViewRow row in dgvDetallesRol.Rows)
                {
                    if (!row.Cells[0].Value.ToString().Trim().Equals(grupo[0].ToString().Trim())) continue;

                    if (Convert.ToInt32(row.Cells[1].Value) != 0)
                    {
                        dgvInformePago.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, f, row.Cells[3].Value, row.Cells[4].Value,
                            row.Cells[5].Value.ToString().Replace("Ñ", "N"), row.Cells[6].Value,
                            Convert.ToDateTime(row.Cells[7].Value).ToShortDateString(), // row.Cells[8].Value + "", se quita cuidad
                            row.Cells[9].Value, row.Cells[10].Value, row.Cells[11].Value, 
                            row.Cells[64].Value, row.Cells[72].Value, row.Cells[73].Value, row.Cells[74].Value,
                            row.Cells[75].Value, row.Cells[76].Value, bancos[row.Cells[72].Value.ToString()]);


                        dgvHorasExtra.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, f, row.Cells[3].Value, row.Cells[4].Value,
                            row.Cells[5].Value.ToString().Replace("Ñ", "N"), row.Cells[6].Value,
                            Convert.ToDateTime(row.Cells[7].Value).ToShortDateString(), row.Cells[8].Value + "",
                            row.Cells[9].Value, row.Cells[10].Value,
                            row.Cells[33].Value, row.Cells[77].Value, true);

                        txt += Convert.ToDouble(row.Cells[33].Value); // suma horas extra
                        if (Convert.ToDouble(row.Cells[77].Value) > 0) dgvHorasExtra.Rows[dgvHorasExtra.RowCount - 1].DefaultCellStyle.BackColor = Color.Aqua;


                        if (tgr.Length > 0)
                        {
                            if (tgr.Split(';').Contains((row.Cells[1].Value + "").Trim()))
                            {
                                dgvInformePago.Rows[(dgvInformePago.RowCount - 1)].Cells[5].Style.BackColor = Color.DarkOrange;
                                dgvInformePago.Rows[(dgvInformePago.RowCount - 1)].Cells[5].Tag = "R";
                                tbr++;
                            }
                        }

                        if (Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[12].Value) == 0 || Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[16].Value) == 0)
                        {
                            if (Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[1].Value) > 0)
                            {
                                if ((dgvInformePago.Rows[(dgvInformePago.RowCount - 1)].Cells[5].Tag + "").Trim().Length == 0)
                                    tbc++;
                            }
                        }

                        if (Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[12].Value) == 1 && Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[16].Value) == 1)
                        {
                            if (dgvInformePago.Rows[(dgvInformePago.RowCount - 1)].Cells[0].Value.ToString().Trim().Equals("BANCO MACHALA"))
                            {
                                if ((dgvInformePago.Rows[(dgvInformePago.RowCount - 1)].Cells[5].Tag + "").Trim().Length == 0) tbm += 1;
                            }
                            else
                            {
                                if ((dgvInformePago.Rows[(dgvInformePago.RowCount - 1)].Cells[5].Tag + "").Trim().Length == 0) tbg += 1;
                            }
                        }

                        if (Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[12].Value) == 2 && Convert.ToInt32(dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[16].Value) == 1) // BANCO PICHINCA
                        {
                            if ((dgvInformePago.Rows[dgvInformePago.RowCount - 1].Cells[5].Tag + "").Trim().Length == 0)
                                tbp++;
                        }

                        ti += Convert.ToDouble(row.Cells[63].Value);
                        f++;
                    } 
                }
            }

            dgvInformePago.Rows.Add(string.Empty, string.Empty, string.Empty, "TOTAL INFORME DE PAGO GENERAL", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, ti.ToString("N"), string.Empty, string.Empty, string.Empty);
            dgvInformePago.Rows[(dgvInformePago.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgvInformePago.AutoResizeRows();
            dgvInformePago.ReadOnly = true;

            dgvHorasExtra.Rows.Add(string.Empty, string.Empty, string.Empty, "TOTAL INFORME HORAS EXTRA", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, txt.ToString("N"));
            dgvHorasExtra.Rows[(dgvHorasExtra.RowCount - 1)].DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgvHorasExtra.AutoResizeRows();

            TextBox2.Text = (tbg + tbm + tbp + tbc + tbr) + "";
            TextBox3.Text = tbg + "";
            TextBox4.Text = tbm + "";
            TextBox5.Text = tbp + "";
            TextBox6.Text = tbc + "";
            TextBox7.Text = tbr + "";

            TextBox8.Text = @"$ " + ti.ToString("N");

            textBox9.Text = @"$ " + txt.ToString("N");

            textBox10.Text = @"" + (dgvHorasExtra.RowCount - 1);

            if (!_rep) return;
            var cad = _cuentas.Where(cuenta => cuenta.Contains("|")).Aggregate(string.Empty, (current, cuenta) => current + (cuenta + "\n"));
            KryptonMessageBox.Show(@"Las siguientes cuentas están repetidas!!\n" + cad, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
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

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (TextBox1.Text.Trim().Length == 0)
            {
                _indices.Clear();
                btnAnt.Tag = 0;
                btnSig.Tag = 0;
                dgvDetallesRol.Rows[0].Selected = true;
                dgvDetallesRol.FirstDisplayedScrollingRowIndex = 0;
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

        private void btnInformePago_Click(object sender, EventArgs e)
        {
            if (dgvInformePago.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var fes = DateTime.Now;
                var sfd = new SaveFileDialog
                {
                    Filter = @"Excel Files(.xls)|*.xls|Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm",
                    Title = @"EXPORTAR A EXCEL",
                    FileName = ("INFORME_DE_PAGO_" + fes.Year + fes.Month + fes.Day + "_" + fes.Hour +
                         fes.Minute + ".xls")
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
                                                           ValidationForms.MesEnLetras(_mes) + "-" + _anio +
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
                                                            ValidationForms.MesEnLetras(_mes) + "-" + _anio +
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
                                                           ValidationForms.MesEnLetras(_mes) + "-" +
                                                           _anio + " GRUPO: " + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
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
                                                           ValidationForms.MesEnLetras(_mes) + "-" +
                                                           _anio + " GRUPO: " + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
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
                                                           ValidationForms.MesEnLetras(_mes) + "-" +
                                                           _anio + " GRUPO: " + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
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
                    if ((row.Cells[13].Value + "").Trim().Length == 0) continue;
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
                    if ((row.Cells[13].Value + "").Trim().Length == 0) continue;
                    if ((row.Cells[5].Tag + "").Trim() == "R") continue;
                    if (Convert.ToInt32(row.Cells[12].Value) <3) continue;
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
                worksheetpm.Range["C" + (head + 3) + ":D" + (head + 3)].Value = TipoCon == TipoConexion.Cisepro ? "ING. MÓNICA ARMIJOS B." : TipoCon == TipoConexion.Seportpac ? "ING. MA. KATHERINE ALVARADO A." : "";
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
                worksheetpm.Range["F" + (head + 10) + ":G" + (head + 10)].Value = "ING. KAREN NAVARRETE M.";
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
                worksheetp.Range["C" + (head + 3) + ":D" + (head + 3)].Value = TipoCon == TipoConexion.Cisepro ? "ING. MÓNICA ARMIJOS B." : TipoCon == TipoConexion.Seportpac ? "ING. MA. KATHERINE ALVARADO A." : "";
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
                worksheetp.Range["F" + (head + 10) + ":G" + (head + 10)].Value = "ING. KAREN NAVARRETE M.";
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
                worksheetc.Range["C" + (head + 3) + ":D" + (head + 3)].Value = TipoCon == TipoConexion.Cisepro ? "ING. MÓNICA ARMIJOS B." : TipoCon == TipoConexion.Seportpac ? "ING. MA. KATHERINE ALVARADO A." : "";
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
                worksheetc.Range["F" + (head + 10) + ":G" + (head + 10)].Value = "ING. KAREN NAVARRETE M.";
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
                worksheetr.Range["C" + (head + 3) + ":D" + (head + 3)].Value = TipoCon == TipoConexion.Cisepro ? "ING. MÓNICA ARMIJOS B." : TipoCon == TipoConexion.Seportpac ? "ING. MA. KATHERINE ALVARADO A." : "";
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
                worksheetr.Range["F" + (head + 10) + ":G" + (head + 10)].Value = "ING. KAREN NAVARRETE M.";
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
                worksheetm.Range["C" + (hr + 15) + ":D" + (hr + 15)].Value = TipoCon == TipoConexion.Cisepro ? "ING. MÓNICA ARMIJOS B." : TipoCon == TipoConexion.Seportpac ? "ING. MA. KATHERINE ALVARADO A." : "";
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
                worksheetm.Range["F" + (hr + 22) + ":G" + (hr + 22)].Value = "ING. KAREN NAVARRETE M.";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvHorasExtra.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "HORAS_EXTRA";

                var l = -1;
                for (var i = 0; i <= dgvHorasExtra.Columns.Count - 1; i++) if (dgvHorasExtra.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l);

                var rc = dgvHorasExtra.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - INFORME DE HORAS EXTRA";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = "INFORME DE HORAS EXTRA DE " + ValidationForms.MesEnLetras(_mes) + " - " + _anio + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;
                var x = 1;
                for (var i = 0; i <= dgvHorasExtra.Columns.Count - 1; i++)
                {
                    if (!dgvHorasExtra.Columns[i].Visible) continue;

                    worksheet.Cells[head, x] = dgvHorasExtra.Columns[i].HeaderText;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (DataGridViewRow row in dgvHorasExtra.Rows)
                {
                    var y = 1;
                    for (var j = 0; j <= dgvHorasExtra.Columns.Count - 1; j++)
                    {
                        if (!dgvHorasExtra.Columns[j].Visible) continue;

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
                worksheet.Range["A" + head + ":F" + head].Value = textBox9.Text;
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
                KryptonMessageBox.Show(@"ARCHIVO generado correctamente!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                    Filter = @"Excel Files(.xlsx)|*.xlsx",
                    Title = @"EXPORTAR A EXCEL",
                    FileName = ("ROLES_DE_PAGO_VARIOS" + "_" + fec.Year + fec.Month + fec.Day + "_" + fec.Hour + fec.Minute + ".xlsx")
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;

                
                var l = -1;
                for (var i = 0; i <= dgvDetallesRol.Columns.Count - 1; i++) if (i < 66 && dgvDetallesRol.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l + 1); // PARA FIRMA Y HUELLA 

                var rc = dgvDetallesRol.RowCount + 20;
                                

                using (var wb = new XLWorkbook())
                {
                    var ws = wb.AddWorksheet("ROL DE PAGO");


                    // Encabezado
                    ws.Cell("A1").Value = Validaciones.NombreCompany(TipoCon);
                    ws.Range("A1:" + ic + "1").Merge();
                    ws.Cell("A1").Style.Font.Bold = true;
                    ws.Cell("A1").Style.Font.FontSize = 12;
                    ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                    ws.Cell("A1").Style.Fill.BackgroundColor = XLColor.FromColor(ValidationForms.GetColorSistema(TipoCon));
                    ws.Cell("A1").Style.Font.FontColor = XLColor.White;

                    ws.Cell("A3").Value = "ROL DE PAGO (VARIOS GRUPOS) : " + ValidationForms.MesEnLetras(_mes) + "-" + _anio + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                    ws.Range("A3:" + ValidationForms.NumToCharExcel(dgvDetallesRol.Columns.Count) + "3").Merge();
                    ws.Cell("A3").Style.Font.FontSize = 12;

                    // Encabezado de columnas
                    var rowIndex = 5; // fila de encabezado
                    var col = 1; // columna de encabezado
                    for (int colIndex = 0; colIndex < dgvDetallesRol.Columns.Count - 1; colIndex++)
                    {
                        if (colIndex == 43 || colIndex > 63 || !dgvDetallesRol.Columns[colIndex].Visible) continue;

                        var headerCell = ws.Cell(rowIndex, col);
                        headerCell.Value = dgvDetallesRol.Columns[colIndex].HeaderText;
                        headerCell.Style.Font.Bold = true;
                        headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        //headerCell.Style.Fill.BackgroundColor = XLColor.FromColor(ValidationForms.GetColorSistema(TipoCon));
                        headerCell.Style.Fill.BackgroundColor = XLColor.FromColor(ValidationForms.GetColorSistema(TipoCon));
                        headerCell.Style.Font.FontColor = XLColor.White;

                        if (colIndex > 11) headerCell.Style.Alignment.TextRotation = 90;
                        col++;
                    }

                    ws.Cell(rowIndex, col).Value = "TOTAL";
                    ws.Cell(rowIndex, col).Style.Font.Bold = true;
                    ws.Cell(rowIndex, col).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    //ws.Cell("A1").Style.Fill.BackgroundColor = XLColor.FromColor(ValidationForms.GetColorSistema(TipoCon));
                    ws.Cell(rowIndex, col).Style.Fill.BackgroundColor = XLColor.FromColor(ValidationForms.GetColorSistema(TipoCon));
                    ws.Cell(rowIndex, col).Style.Font.FontColor = XLColor.White;
                    ws.Cell(rowIndex, col).Style.Alignment.TextRotation = 90;
                    //col++;



                    // Datos de filas
                    rowIndex++; // empezamos después del encabezado
                    foreach (DataGridViewRow row in dgvDetallesRol.Rows)
                    {
                        int colIndex = 1;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.ColumnIndex == 43 || cell.ColumnIndex > 65 || !dgvDetallesRol.Columns[cell.ColumnIndex].Visible) continue;

                            var dataCell = ws.Cell(rowIndex, colIndex);
                            dataCell.Value = XLCellValue.FromObject(cell.Value ?? String.Empty); // Controlamos valores nulos
                            object cellValue = cell.Value ?? string.Empty;

                            string columnheader = dgvDetallesRol.Columns[cell.ColumnIndex].HeaderText;

                            if (columnheader.Contains("ID") || columnheader == "C.I.")
                            {
                                // Tratar los ID como texto para preservar ceros iniciales
                                dataCell.Value = cellValue.ToString();
                            }

                            else if (cellValue is double || cellValue is float || cellValue is decimal)
                            {
                                // Mantener números decimales en formato numérico
                                dataCell.Value = Convert.ToDouble(cellValue);
                                dataCell.Style.NumberFormat.Format = "#,##0.00";
                            }
                            else if (double.TryParse(cellValue.ToString(), out double numValue))
                            {
                                // Si es un número pero viene como string, convertirlo
                                dataCell.Value = numValue;
                            }
                            else
                            {
                                // Cualquier otro caso, tratarlo como texto
                                dataCell.Value = cellValue.ToString();
                            }


                            if ((row.Tag + "").Equals("2") || (row.Tag + "").Equals("3"))
                                dataCell.Style.Font.Bold = true;

                            dataCell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            colIndex++;
                        }
                        rowIndex++;
                    }

                    // Logo en la celda correspondiente
                    var newlogo = Validaciones.NombreLogo(TipoCon, System.Windows.Forms.Application.StartupPath);

                    // Convertir la imagen a un stream de memoria
                    using (var logoImage = Image.FromFile(newlogo))
                    {
                        // Convertir la imagen a un stream de memoria
                        using (MemoryStream ms = new MemoryStream())
                        {
                            // Guardar la imagen en el MemoryStream en formato PNG
                            logoImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            ms.Position = 0; // Asegurarse de que la posición del stream esté al inicio

                            // Insertar la imagen desde el stream en la celda correspondiente
                            ws.AddPicture(ms)
                                .MoveTo(ws.Cell(2, 6)) // Coloca la imagen en la celda correcta (en este caso en la fila 2, columna 6)
                                .WithSize(80, 80);   // Ajusta el tamaño según sea necesario
                        }
                    }

                    // Ajuste automático de columnas
                    ws.Columns().AdjustToContents();

                    // Guardar el archivo en la ruta seleccionada por el usuario
                    wb.SaveAs(sfd.FileName);

                    // Abrimos el archivo
                    Process.Start(sfd.FileName);
                }


                KryptonMessageBox.Show(@"ROL DE PAGO generado correctamente!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {            
            if (dgvHorasExtra.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
            dgvHorasExtra.EndEdit();
            if (lblEmpresa.Text.Trim().Length == 0 || lblRuc.Text.Trim().Length == 0)
            {
                KryptonMessageBox.Show(@"NO SE HAN CARGADO LOS DATOS DE LA EMPRESA!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var ruc = lblRuc.Text.Trim();
                var suc = "0" + ruc.Substring(10, 3);
                var fec = DateTime.Now;
                var sfd = new SaveFileDialog
                {
                    Filter = @"All Files (*.*)|*.*",
                    FileName = ("NOVINS" + fec.Year + fec.Month + fec.Day + "_" + fec.Hour + fec.Minute + ".txt"),
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;
                if (!sfd.FileName.EndsWith(".txt")) sfd.FileName += ".txt";
                if (File.Exists(sfd.FileName) == false) File.Create(sfd.FileName).Dispose();

                var objWriter = new StreamWriter(sfd.FileName, true);

                foreach (DataGridViewRow row in dgvHorasExtra.Rows)
                {
                    if ((row.Cells[0].Value + "").Trim().Length == 0 || !(bool)row.Cells[13].Value) continue;

                    objWriter.WriteLine(
                        ruc + ";" +                                                                     // RUC de la empresa (13 dígitos)
                        suc + ";" +                                                                     // Código de la sucursal (4 dígitos)
                        _anio + ";" +                                                                   // Año actual (4 dígitos formato YYYY)
                        (_mes < 10 ? "0" + _mes : _mes + "") + ";" +                                    // Mes actual (2 dígitos formato MM)
                        "INS;" +                                                                        // Tipo de movimiento (prefijado como INS)
                        row.Cells[6].Value.ToString().Trim() + ";" +                                    // Cédula de identidad del afiliado afectado (10 dígitos)
                        CompletarConEspacio(row.Cells[11].Value.ToString().Trim(), 14, true) + ";" +    // Valores Extras (máximo 14 dígitos)
                        //_anio + "-" + (_mes < 10 ? "0" + _mes : _mes + "") + " " + "A" + " " + _anio + "-" + (_mes < 10 ? "0" + _mes : _mes + "")  + ";" // periodo (YYYY-MM A YYYY-MM 17 digitos)
                        //+ "O");                                                                           // Causa. (1 dígito (codificación ver Anexo))
                          "X");
                }
                objWriter.Close();
                KryptonMessageBox.Show(@"Archivo generado correctamente", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in dgvHorasExtra.Rows)
            {
                if (x.Cells[0].Value.ToString().Trim().Length == 0) continue;
                if (Convert.ToDouble(x.Cells[12].Value) > 0) x.Cells[13].Value = chkFondos.Checked;
            }
            ContarFilas();
        }

        private void dgvHorasExtra_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvHorasExtra.CurrentRow.Cells[0].Value.ToString().Trim().Length == 0) e.Cancel = true;
            ContarFilas();
        }

        private void dgvHorasExtra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHorasExtra.CurrentRow.Cells[0].Value.ToString().Trim().Length == 0) dgvHorasExtra.CurrentRow.Cells[0].Value = false;
            ContarFilas();
        }

        private void ContarFilas()
        {
            var cx = 0;
            var t = 0.0;
            foreach (DataGridViewRow x in dgvHorasExtra.Rows)
            {
                if (x.Cells[13].Value == null) continue; 
                cx += (bool)x.Cells[13].Value ? 1 : 0; 
                t += (bool)x.Cells[13].Value ? Convert.ToDouble(x.Cells[11].Value) : 0;
            }
            textBox10.Text = @"" + cx;
            textBox9.Text = @"$ " + t.ToString("N");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (dgvHorasExtra.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
            dgvHorasExtra.EndEdit();
            if (lblEmpresa.Text.Trim().Length == 0 || lblRuc.Text.Trim().Length == 0)
            {
                KryptonMessageBox.Show(@"NO SE HAN CARGADO LOS DATOS DE LA EMPRESA!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var ruc = lblRuc.Text.Trim();
                var suc = "0" + ruc.Substring(10, 3);
                var fec = DateTime.Now;
                var sfd = new SaveFileDialog
                {
                    Filter = @"All Files (*.*)|*.*",
                    FileName = ("NOVFONRES" + fec.Year + fec.Month + fec.Day + "_" + fec.Hour + fec.Minute + ".txt"),
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;
                if (!sfd.FileName.EndsWith(".txt")) sfd.FileName += ".txt";
                if (File.Exists(sfd.FileName) == false) File.Create(sfd.FileName).Dispose();

                var objWriter = new StreamWriter(sfd.FileName, true);

                foreach (DataGridViewRow row in dgvHorasExtra.Rows)
                {
                    if ((row.Cells[0].Value + "").Trim().Length == 0 || !(bool)row.Cells[13].Value) continue;

                    objWriter.WriteLine(
                        ruc + ";" +                                                                     // RUC de la empresa (13 dígitos)
                        suc + ";" +                                                                     // Código de la sucursal (4 dígitos)
                        _anio + ";" +                                                                   // Año actual (4 dígitos formato YYYY)
                        (_mes < 10 ? "0" + _mes : _mes + "") + ";" +                                    // Mes actual (2 dígitos formato MM)
                        "PFM;" +                                                                        // Tipo de movimiento (prefijado como INS)
                        row.Cells[6].Value.ToString().Trim() + ";" +                                    // Cédula de identidad del afiliado afectado (10 dígitos)
                        CompletarConEspacio(row.Cells[12].Value.ToString().Trim(), 14, true) + ";" +    // Valores Extras (máximo 14 dígitos)
                        _anio + "-" + (_mes < 10 ? "0" + _mes : _mes + "") + " " + "A" + " " + _anio + "-" + (_mes < 10 ? "0" + _mes : _mes + "")  + ";" // periodo (YYYY-MM A YYYY-MM 17 digitos)
                        //+ "O");                                                                           // Causa. (1 dígito (codificación ver Anexo))
                        + "01" + ";" + "G");
                }
                objWriter.Close();
                KryptonMessageBox.Show(@"Archivo generado correctamente", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
    }
}