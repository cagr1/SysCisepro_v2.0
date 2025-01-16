using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using Microsoft.Office.Interop.Excel;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using SysCisepro3.Reportes;
using DataTable = System.Data.DataTable;
using Office = Microsoft.Office.Interop;
using System.Text.RegularExpressions;
using Krypton.Toolkit;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmReporteVacaciones : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para visualizar detalles en las vacaciones del personal
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmReporteVacaciones _instance;
        public static FrmReporteVacaciones Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmReporteVacaciones();
                return _instance;
            }
        }

        private readonly ClassRegistroPermisoPersonal _objRegistroPermisoPersonal;
        private readonly ClassDetalleVacaciones _objDetalleVacaciones;
        private FrmPeriodoVacaciones _objFrmPeriodoVacaciones;

        private readonly List<SqlCommand> _sqlCommands;

        private FrmReporteVacaciones()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();
            _objRegistroPermisoPersonal = new ClassRegistroPermisoPersonal();
            _objDetalleVacaciones = new ClassDetalleVacaciones();
        }

        private void FrmReporteVacaciones_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            
            
            dataGridView1.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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
            dataGridView1.Font = new System.Drawing.Font("Roboto", 8, FontStyle.Regular);
            LlenarPeriodosValidos();

            var f = Usuario.Now(TipoCon);
            dtpFechaDesde.Value = new DateTime(f.Year, f.Month, 1,0,0,0);
            dtpFechaHasta.Value = dtpFechaDesde.Value.AddMonths(1).AddDays(-1);
        }

        private void LlenarPeriodosValidos()
        {
            cbxPeriodo.Items.Clear();

            var fe = new DateTime(2017, 1, 1, 0, 0, 0);
            var a = Usuario.Now(TipoCon).Year - 2017;

            for (var i = 1; i <= a; i++)
            {
                var p = fe.Year + " - " + (fe.Year + 1);
                cbxPeriodo.Items.Add(p);
                fe = fe.AddYears(1);
            }
            if (cbxPeriodo.Items.Count > 0) cbxPeriodo.SelectedIndex = cbxPeriodo.Items.Count - 1;
        }

        private void LlenarDetalleVacaciones(string fil)
        {
            try
            {
                dataGridView1.Rows.Clear();
                DataTable data;

                if (chkDetalle.Checked)
                {
                    var fechad = dtpFechaDesde.Value.Year + "-" + dtpFechaDesde.Value.Month + "-" +
                                 dtpFechaDesde.Value.Day + " 00:00:00";
                    var fechah = dtpFechaHasta.Value.Year + "-" + dtpFechaHasta.Value.Month + "-" +
                                 dtpFechaHasta.Value.Day + " 23:59:59";

                    data = _objDetalleVacaciones.SeleccionarRegistroVacaciones(TipoCon, fechad, fechah, fil, radioButton1.Checked);
                }
                else
                {
                    var p = cbxPeriodo.Text.Split('-');
                    data = _objDetalleVacaciones.SeleccionarRegistroVacacionesPorPeriodo(TipoCon, p[0].Trim(), p[1].Trim(), fil);
                }

                var i = 0;
                foreach (DataRow row in data.Rows)
                {
                    dataGridView1.Rows.Add(i, row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8],
                        row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16]);
                    i++;
                }

                dataGridView1.Columns[5].DefaultCellStyle.Format = "d";
                dataGridView1.Columns[6].DefaultCellStyle.Format = "d";


                dataGridView1.AutoResizeRows();
                Label1.Text = dataGridView1.RowCount + @" REGISTRO(S)";
            }
            catch
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            LlenarDetalleVacaciones(txtFiltro.Text.Trim());
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            LlenarDetalleVacaciones(txtFiltro.Text.Trim());
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            LlenarDetalleVacaciones(txtFiltro.Text.Trim());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;
                var data = dataGridView1.CurrentRow;

                if (KryptonMessageBox.Show(@"El registro selecconado corresponde a la solicitud n° " + data.Cells[2].Value + @" de vacaciones. Desea IMPRIMIR la solicitud correspondiente?",
                   "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
               DialogResult.Yes) return;

                var ds = new DsSysSecurity();

                foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>().Where(row => row.Cells[11].Value.ToString().Equals(data.Cells[11].Value.ToString())))
                {
                    ds.Tables["dtDetalleVacaciones"].Rows.Add(
                        Convert.ToDateTime(row.Cells[5].Value).ToShortDateString(),
                        Convert.ToDateTime(row.Cells[6].Value).ToShortDateString(),
                        row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString());
                }

                string empre = Validaciones.NombreCompany(TipoCon) + " CÍA. LTDA."; 

                var rpt = new rptSolicitudVacaciones();
                rpt.SetDataSource(ds.Tables["dtDetalleVacaciones"]);
                rpt.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, System.Windows.Forms.Application.StartupPath));
                rpt.SetParameterValue("idsolicitud", data.Cells[11].Value.ToString());
                rpt.SetParameterValue("numdoc", data.Cells[2].Value.ToString());
                rpt.SetParameterValue("fecha", data.Cells[12].Value.ToString());

                rpt.SetParameterValue("empre", empre);
                rpt.SetParameterValue("nombre", data.Cells[3].Value.ToString());
                rpt.SetParameterValue("cedula", data.Cells[13].Value.ToString());

                rpt.SetParameterValue("realizado", TipoCon == TipoConexion.Cisepro ? "Ing. Karen Navarrete M." : "Ing. María Katherine A.");
                rpt.SetParameterValue("revisado", TipoCon == TipoConexion.Cisepro ? "Isabel Herrera Rodriguez" : "Ing. Magdalena Chato N.");
                rpt.SetParameterValue("aprobado", TipoCon == TipoConexion.Cisepro ? "Ing. Marjorie Loor P." : "Ing. José Navarrete M.");

                rpt.SetParameterValue("cargo", data.Cells[4].Value.ToString());
                rpt.SetParameterValue("puesto", data.Cells[14].Value.ToString());
                rpt.SetParameterValue("ingreso", data.Cells[15].Value.ToString());

                var view = new FrmVisualizadorReportes {TipoCon = TipoCon, Titulo = "SOLICITUDO VACACIONES", crystalReportViewer1 = { ReportSource = rpt } };
                view.ShowDialog();
                view.Dispose();
            }
            catch (Exception)
            {
                KryptonMessageBox.Show(@"Error al generar solicitud. Por favor, contácte al administrador!",
                    "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (dataGridView1.CurrentRow == null) return;
            if (KryptonMessageBox.Show(@"Desea guardar la solicitud seleccionada?",
                   "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
               DialogResult.Yes) return;
            _sqlCommands.Clear();

            _objRegistroPermisoPersonal.IdRegistro = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value);
            _objRegistroPermisoPersonal.Estado = 0;
            _sqlCommands.Add(_objRegistroPermisoPersonal.AnularRegistroPermisoCommand());

            _objDetalleVacaciones.IdPermiso = _objRegistroPermisoPersonal.IdRegistro;
            _sqlCommands.Add(_objDetalleVacaciones.AnularRegistroDetalleVacacionesCommand());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "REGISTRO VACACIONES");

            if ((bool)res[0]) LlenarDetalleVacaciones(txtFiltro.Text.Trim());
            KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            { 

                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "VACACIONES";

                var l = -1;
                for (var i = 0; i <= dataGridView1.Columns.Count - 1; i++) if (dataGridView1.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l);

                var rc = dataGridView1.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - VACACIONES";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = "VACACIONES DEL " + dtpFechaDesde.Value.ToShortDateString() + " AL " + dtpFechaHasta.Value.ToShortDateString() + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;
                var x = 1;
                for (var i = 0; i <= dataGridView1.Columns.Count - 1; i++)
                {
                    if (!dataGridView1.Columns[i].Visible) continue;

                    worksheet.Cells[head, x] = dataGridView1.Columns[i].HeaderText;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var y = 1;
                    for (var j = 0; j <= dataGridView1.Columns.Count - 1; j++)
                    {
                        if (!dataGridView1.Columns[j].Visible) continue;

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
                worksheet.Range["A" + head + ":F" + head].Value = Label1.Text;
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

        private void chkDetalle_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = chkDetalle.Checked;
            radioButton2.Enabled = chkDetalle.Checked;
            dtpFechaDesde.Enabled = chkDetalle.Checked;
            dtpFechaHasta.Enabled = chkDetalle.Checked;
            cbxPeriodo.Enabled = !chkDetalle.Checked;
            chkPeriodo.Checked = !chkDetalle.Checked;
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = !chkPeriodo.Checked;
            radioButton2.Enabled = !chkPeriodo.Checked;
            dtpFechaDesde.Enabled = !chkPeriodo.Checked;
            dtpFechaHasta.Enabled = !chkPeriodo.Checked;
            chkDetalle.Checked = !chkPeriodo.Checked;
            cbxPeriodo.Enabled = chkPeriodo.Checked;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0 || dataGridView1.CurrentRow == null)
            {
                KryptonMessageBox.Show(@"NO SE HA SELECCIONADO NINGÚN DATO!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
                return;
            }
            if (!dataGridView1.CurrentRow.Cells[9].Value.ToString().Trim().Contains('-'))
            {
                KryptonMessageBox.Show(@"ERROR AL SELECCIONAR PERÍODO, CONTÁCTE AL ADMINISTRADOR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
                return;
            }

            if (KryptonMessageBox.Show(@"DESEA CAMBIAR EL PERÍODO CORRESPONDIENTE AL DETALLE DE VACACIONES SELECCIONADO?",
                   "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes) return;
          
            var p = dataGridView1.CurrentRow.Cells[9].Value.ToString().Trim().Split('-');

            _objFrmPeriodoVacaciones = new FrmPeriodoVacaciones { TipoCon = TipoCon, 
                Nombre = dataGridView1.CurrentRow.Cells[3].Value.ToString(), 
                Observacion = dataGridView1.CurrentRow.Cells[10].Value.ToString(),
                dtpDesde = { Value = Convert.ToDateTime(p[0]) }, 
                dtpHasta = { Value = Convert.ToDateTime(p[1]),}
            };

            if (_objFrmPeriodoVacaciones.ShowDialog() != DialogResult.OK) return;

            _sqlCommands.Clear();
            
            _objDetalleVacaciones.IdDetalle = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            _objDetalleVacaciones.Periodo = _objFrmPeriodoVacaciones.dtpDesde.Value.Day + "/" + _objFrmPeriodoVacaciones.dtpDesde.Value.Month + "/" + _objFrmPeriodoVacaciones.dtpDesde.Value.Year + " - " 
                + _objFrmPeriodoVacaciones.dtpHasta.Value.Day + "/" + _objFrmPeriodoVacaciones.dtpHasta.Value.Month + "/" + _objFrmPeriodoVacaciones.dtpHasta.Value.Year;
            _objDetalleVacaciones.Observacion = _objFrmPeriodoVacaciones.Observacion;

            _sqlCommands.Add(_objDetalleVacaciones.CambiarPeriodoDetalleVacacionesCommand());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "REGISTRAR PERSONAL");

            if ((bool)res[0]) LlenarDetalleVacaciones(txtFiltro.Text.Trim());
            KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}