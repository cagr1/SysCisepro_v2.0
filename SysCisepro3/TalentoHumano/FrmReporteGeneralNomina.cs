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
using ClassLibraryCisepro3.TalentoHumano;

using Office = Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using ClassLibraryCisepro3.Estaticas;
using Krypton.Toolkit;
namespace SysCisepro3.TalentoHumano
{
    public partial class FrmReporteGeneralNomina : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para visualizar detalles en la asistencia del personal
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }
        private readonly ClassPersonal _objPersonal;

        private static FrmReporteGeneralNomina _instance;
        public static FrmReporteGeneralNomina Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmReporteGeneralNomina();
                return _instance;
            }
        }

        public FrmReporteGeneralNomina()
        {
            InitializeComponent();
            _objPersonal = new ClassPersonal();
        }

        private void FrmReporteGeneralNomina_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            toolStripLabel1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStripLabel1.ForeColor = Color.White;
            dgvPersonal.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvPersonal.Font = new System.Drawing.Font("Roboto", 8,FontStyle.Regular);
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
            ValidationForms.SetPlaceholder(txtFiltro,"BUSCAR POR NOMBRE..");
            var f = Usuario.ObtenerFechaSola(TipoCon);
            dtpAnio.Value = new DateTime(f.Year, 1, 1);
        }

        private void dtpAnio_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = new DateTime(dtpAnio.Value.Year, 1, 1);
            dtpFechaHasta.Value = new DateTime(dtpAnio.Value.Year, 12, 31);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            LlenarReporte();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            LlenarReporte();
        }

        private void LlenarReporte()
        {
            try
            {
                dgvPersonal.Rows.Clear();
                var filtro = txtFiltro.Text;
                var fechaDesde = dtpFechaDesde.Value.Year + "-" + dtpFechaDesde.Value.Month + "-" + dtpFechaDesde.Value.Day + " 00:00:00";
                var fechaHasta = dtpFechaHasta.Value.Year + "-" + dtpFechaHasta.Value.Month + "-" + dtpFechaHasta.Value.Day + " 23:59:59";

                var auxNomina = string.Empty;
                var auxCI = string.Empty;

                var admin = new double[16];
                var tadmin = new double[16];

                var oper = new double[16];
                var toper = new double[16];

                // administrativo
                var dataAdmin = _objPersonal.SeleccionarDatosPagosNominaGenral(TipoCon, true, fechaDesde, fechaHasta, filtro);
                if (dataAdmin.Rows.Count > 0)
                {
                    auxNomina = dataAdmin.Rows[0][2].ToString();
                    auxCI = dataAdmin.Rows[0][3].ToString();

                    dgvPersonal.Rows.Add("ADMINISTRATIVO", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                        string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                    dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);
                    dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.BackColor = ValidationForms.GetColorSistema(TipoCon);
                    dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.ForeColor = Color.WhiteSmoke;

                    foreach (DataRow row in dataAdmin.Rows)
                    {
                        if (!auxNomina.Equals(row[2].ToString()))
                        {
                            tadmin[0] += admin[0];
                            tadmin[1] += admin[1];
                            tadmin[2] += admin[2];
                            tadmin[3] += admin[3];
                            tadmin[4] += admin[4];
                            tadmin[5] += admin[5];
                            tadmin[6] += admin[6];
                            tadmin[7] += admin[7];
                            tadmin[8] += admin[8];
                            tadmin[9] += admin[9];
                            tadmin[10] += admin[10];
                            tadmin[11] += admin[11];
                            tadmin[12] += admin[12];
                            tadmin[13] += admin[13];
                            tadmin[14] += admin[14];
                            tadmin[15] += admin[15];

                            dgvPersonal.Rows.Add(string.Empty, "TOTAL", auxNomina, auxCI,
                                admin[0], admin[1], admin[2], admin[3], admin[4], admin[5], admin[6], admin[7], admin[8], admin[9], admin[10], admin[11], admin[12], admin[13], admin[14], admin[15]);
                            dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);
                            dgvPersonal.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);

                            admin[0] = 0;
                            admin[1] = 0;
                            admin[2] = 0;
                            admin[3] = 0;
                            admin[4] = 0;
                            admin[5] = 0;
                            admin[6] = 0;
                            admin[7] = 0;
                            admin[8] = 0;
                            admin[9] = 0;
                            admin[10] = 0;
                            admin[11] = 0;
                            admin[12] = 0;
                            admin[13] = 0;
                            admin[14] = 0;
                            admin[15] = 0;
                        }

                        dgvPersonal.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19]);
                        admin[0] += Math.Round(Convert.ToDouble(row[4]), 2);
                        admin[1] += Math.Round(Convert.ToDouble(row[5]), 2);
                        admin[2] += Math.Round(Convert.ToDouble(row[6]), 2);
                        admin[3] += Math.Round(Convert.ToDouble(row[7]), 2);
                        admin[4] += Math.Round(Convert.ToDouble(row[8]), 2);
                        admin[5] += Math.Round(Convert.ToDouble(row[9]), 2);
                        admin[6] += Math.Round(Convert.ToDouble(row[10]), 2);
                        admin[7] += Math.Round(Convert.ToDouble(row[11]), 2);
                        admin[8] += Math.Round(Convert.ToDouble(row[12]), 2);
                        admin[9] += Math.Round(Convert.ToDouble(row[13]), 2);
                        admin[10] += Math.Round(Convert.ToDouble(row[14]), 2);
                        admin[11] += Math.Round(Convert.ToDouble(row[15]), 2);
                        admin[12] += Math.Round(Convert.ToDouble(row[16]), 2);
                        admin[13] += Math.Round(Convert.ToDouble(row[17]), 2);
                        admin[14] += Math.Round(Convert.ToDouble(row[18]), 2);
                        admin[15] += Math.Round(Convert.ToDouble(row[19]), 2);

                        auxNomina = row[2].ToString();
                        auxCI = row[3].ToString();

                        if (row.Equals(dataAdmin.Rows[dataAdmin.Rows.Count - 1]))
                        {
                            tadmin[0] += admin[0];
                            tadmin[1] += admin[1];
                            tadmin[2] += admin[2];
                            tadmin[3] += admin[3];
                            tadmin[4] += admin[4];
                            tadmin[5] += admin[5];
                            tadmin[6] += admin[6];
                            tadmin[7] += admin[7];
                            tadmin[8] += admin[8];
                            tadmin[9] += admin[9];
                            tadmin[10] += admin[10];
                            tadmin[11] += admin[11];
                            tadmin[12] += admin[12];
                            tadmin[13] += admin[13];
                            tadmin[14] += admin[14];
                            tadmin[15] += admin[15];

                            dgvPersonal.Rows.Add(string.Empty, "TOTAL", auxNomina, auxCI,
                                admin[0], admin[1], admin[2], admin[3], admin[4], admin[5], admin[6], admin[7], admin[8], admin[9], admin[10], admin[11], admin[12], admin[13], admin[14], admin[15]);
                            dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);
                            dgvPersonal.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                        }
                    }

                    dgvPersonal.Rows.Add("TOTAL ADMINISTRATIVO", string.Empty, string.Empty, string.Empty, tadmin[0], tadmin[1], tadmin[2], tadmin[3], tadmin[4], tadmin[5], tadmin[6], tadmin[7], tadmin[8], tadmin[9], tadmin[10], tadmin[11], tadmin[12], tadmin[13], tadmin[14], tadmin[15]);
                    dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);
                    dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.BackColor = ValidationForms.GetColorSistema(TipoCon);
                    dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.ForeColor = Color.WhiteSmoke;

                    dgvPersonal.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                }

                tadmin[0] = 0;
                tadmin[1] = 0;
                tadmin[2] = 0;
                tadmin[3] = 0;
                tadmin[4] = 0;
                tadmin[5] = 0;
                tadmin[6] = 0;
                tadmin[7] = 0;
                tadmin[8] = 0;
                tadmin[9] = 0;
                tadmin[10] = 0;
                tadmin[11] = 0;
                tadmin[12] = 0;
                tadmin[13] = 0;
                tadmin[14] = 0;
                tadmin[15] = 0;

                // operativo
                var dataOper = _objPersonal.SeleccionarDatosPagosNominaGenral(TipoCon, false, fechaDesde, fechaHasta, filtro);
                if (dataOper.Rows.Count > 0)
                {
                    auxNomina = dataOper.Rows[0][2].ToString();
                    auxCI = dataOper.Rows[0][3].ToString();

                    dgvPersonal.Rows.Add("OPERATIVO", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                        string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                    dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);
                    dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.BackColor = ValidationForms.GetColorSistema(TipoCon);
                    dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.ForeColor = Color.WhiteSmoke;

                    foreach (DataRow row in dataOper.Rows)
                    {
                        if (!auxNomina.Equals(row[2].ToString()))
                        {
                            toper[0] += oper[0];
                            toper[1] += oper[1];
                            toper[2] += oper[2];
                            toper[3] += oper[3];
                            toper[4] += oper[4];
                            toper[5] += oper[5];
                            toper[6] += oper[6];
                            toper[7] += oper[7];
                            toper[8] += oper[8];
                            toper[9] += oper[9];
                            toper[10] += oper[10];
                            toper[11] += oper[11];
                            toper[12] += oper[12];
                            toper[13] += oper[13];
                            toper[14] += oper[14];
                            toper[15] += oper[15];

                            dgvPersonal.Rows.Add(string.Empty, "TOTAL", auxNomina, auxCI,
                                oper[0], oper[1], oper[2], oper[3], oper[4], oper[5], oper[6], oper[7], oper[8], oper[9], oper[10], oper[11], oper[12], oper[13], oper[14], oper[15]);
                            dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);
                            dgvPersonal.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);

                            oper[0] = 0;
                            oper[1] = 0;
                            oper[2] = 0;
                            oper[3] = 0;
                            oper[4] = 0;
                            oper[5] = 0;
                            oper[6] = 0;
                            oper[7] = 0;
                            oper[8] = 0;
                            oper[9] = 0;
                            oper[10] = 0;
                            oper[11] = 0;
                            oper[12] = 0;
                            oper[13] = 0;
                            oper[14] = 0;
                            oper[15] = 0;
                        }

                        dgvPersonal.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19]);
                        oper[0] += Math.Round(Convert.ToDouble(row[4]), 2);
                        oper[1] += Math.Round(Convert.ToDouble(row[5]), 2);
                        oper[2] += Math.Round(Convert.ToDouble(row[6]), 2);
                        oper[3] += Math.Round(Convert.ToDouble(row[7]), 2);
                        oper[4] += Math.Round(Convert.ToDouble(row[8]), 2);
                        oper[5] += Math.Round(Convert.ToDouble(row[9]), 2);
                        oper[6] += Math.Round(Convert.ToDouble(row[10]), 2);
                        oper[7] += Math.Round(Convert.ToDouble(row[11]), 2);
                        oper[8] += Math.Round(Convert.ToDouble(row[12]), 2);
                        oper[9] += Math.Round(Convert.ToDouble(row[13]), 2);
                        oper[10] += Math.Round(Convert.ToDouble(row[14]), 2);
                        oper[11] += Math.Round(Convert.ToDouble(row[15]), 2);
                        oper[12] += Math.Round(Convert.ToDouble(row[16]), 2);
                        oper[13] += Math.Round(Convert.ToDouble(row[17]), 2);
                        oper[14] += Math.Round(Convert.ToDouble(row[18]), 2);
                        oper[15] += Math.Round(Convert.ToDouble(row[19]), 2);

                        auxNomina = row[2].ToString();
                        auxCI = row[3].ToString();

                        if (row.Equals(dataOper.Rows[dataOper.Rows.Count - 1]))
                        {
                            toper[0] += oper[0];
                            toper[1] += oper[1];
                            toper[2] += oper[2];
                            toper[3] += oper[3];
                            toper[4] += oper[4];
                            toper[5] += oper[5];
                            toper[6] += oper[6];
                            toper[7] += oper[7];
                            toper[8] += oper[8];
                            toper[9] += oper[9];
                            toper[10] += oper[10];
                            toper[11] += oper[11];
                            toper[12] += oper[12];
                            toper[13] += oper[13];
                            toper[14] += oper[14];
                            toper[15] += oper[15];

                            dgvPersonal.Rows.Add(string.Empty, "TOTAL", auxNomina, auxCI,
                                oper[0], oper[1], oper[2], oper[3], oper[4], oper[5], oper[6], oper[7], oper[8], oper[9], oper[10], oper[11], oper[12], oper[13], oper[14], oper[15]);
                            dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);
                            dgvPersonal.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                        }
                    }

                    dgvPersonal.Rows.Add("TOTAL OPERATIVO", string.Empty, string.Empty, string.Empty, toper[0], toper[1], toper[2], toper[3], toper[4], toper[5], toper[6], toper[7], toper[8], toper[9], toper[10], toper[11], toper[12], toper[13], toper[14], toper[15]);
                    dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8, FontStyle.Bold);
                    dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.BackColor = ValidationForms.GetColorSistema(TipoCon);
                    dgvPersonal.Rows[(dgvPersonal.RowCount - 1)].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                }

                dgvPersonal.AutoResizeRows();
                toolStripLabel2.Text = (dataAdmin.Rows.Count + dataOper.Rows.Count) + @" REGISTRO(S) EN TOTAL";
            }
            catch
            {
                dgvPersonal.Rows.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.RowCount == 0)
            {
                MessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];

                worksheet.Name = "REPORTE";

                var l = -1;
                for (var i = 0; i <= dgvPersonal.Columns.Count - 1; i++) if (dgvPersonal.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l); // PARA FIRMA Y HUELLA

                var rc = dgvPersonal.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - REPORTE NÓMINA";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = "REPORTE DE NÓMINA GENERAL DEL " + dtpAnio.Value.Year + "               Fecha de Impresión: " + Usuario.Now(TipoCon);
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
                        //if ((row.Tag + "").Equals("2") || (row.Tag + "").Equals("3")) worksheet.Cells[head, y].Font.Bold = true;
                        //worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                        //worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                        //worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
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
                app.DisplayAlerts = true;

                MessageBox.Show(@"REPORTE DE NÓMINA GENERAL DEL " + dtpAnio.Value + " generado correctamente!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}