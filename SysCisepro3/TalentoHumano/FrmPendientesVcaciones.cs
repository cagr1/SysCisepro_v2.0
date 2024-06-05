using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using Microsoft.Office.Interop.Excel;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using Office = Microsoft.Office.Interop;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmPendientesVcaciones : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para registrar detalles de vacaciones del personal
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }
        private readonly ClassDetalleVacaciones _objDetalleVacaciones;

        private static FrmPendientesVcaciones _instance;
        public static FrmPendientesVcaciones Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmPendientesVcaciones();
                return _instance;
            }
        }

        public FrmPendientesVcaciones(TipoConexion tipoCon, ClassUsuarioGeneral usuario)
        {
            InitializeComponent();
            TipoCon = tipoCon;
            Usuario = usuario;

            _anios = new List<int>();
            _objDetalleVacaciones = new ClassDetalleVacaciones();
        }

        private readonly List<int> _anios;
        private FrmPendientesVcaciones()
        {
            InitializeComponent();
            _anios = new List<int>();
            _objDetalleVacaciones = new ClassDetalleVacaciones();
        }

        private void FrmReporteVacaciones_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            Label1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label1.ForeColor = Color.White;
            label6.BackColor = ValidationForms.GetColorSistema(TipoCon);
            label6.ForeColor = Color.White;
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
            dataGridView1.Font = new System.Drawing.Font("Roboto",8, FontStyle.Regular);
            cbxTipo.SelectedIndex = 0;
            cbxEstado.SelectedIndex = 1; 
            LlenarPeriodos();
            txtFiltro.Focus();
        }

        private void LlenarPeriodos()
        {
            try
            {
                cbxDesde.DataSource = ValidationForms.GenerarPeriodos(TipoCon, 2017);
                cbxDesde.DisplayMember = "PERIODO";
                cbxDesde.ValueMember = "VAL";

                cbxHasta.DataSource = ValidationForms.GenerarPeriodos(TipoCon, 2017);
                cbxHasta.DisplayMember = "PERIODO";
                cbxHasta.ValueMember = "VAL";

                cbxDesde.SelectedIndex = 0;
                cbxHasta.SelectedIndex = 0;
            }
            catch
            {
                cbxDesde.DataSource = null;
                cbxHasta.DataSource = null;
            }
        }

        private void LlenarDetalleVacaciones(string fil)
        {
            try
            {
                if (cbxDesde.SelectedValue == null || cbxHasta.SelectedValue == null) return;

                _anios.Clear();
                var ini = Convert.ToInt32(cbxDesde.SelectedValue);
                var fin = Convert.ToInt32(cbxHasta.SelectedValue);
                var tipo = cbxTipo.SelectedIndex; // 0 - oper, 1 - admin
                var estado = cbxEstado.SelectedIndex;// 0 - inac, 1 - activ, 2 - todos

                for (var i = 0; i <= (fin - ini); i++) _anios.Add(ini + i);

                var data = _objDetalleVacaciones.SeleccionarRegistroPendientesVacacionesPorPeriodo(TipoCon, fil, _anios, tipo, estado);

                if (tipo == 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        var fe = Convert.ToDateTime(row[4]);
                        var fx = new DateTime(int.Parse(row[6].ToString().Split('-')[1].Trim()), fe.Month, fe.Day, fe.Hour, fe.Minute, fe.Second);
                        if (fe >= fx) row.Delete();
                    }

                    dataGridView1.DataSource = data;
                }
                else
                {
                    foreach (DataRow row in data.Rows)
                    {
                        var fe = Convert.ToDateTime(row[4]);
                        var fx = new DateTime(int.Parse(row[6].ToString().Split('-')[1].Trim()), fe.Month, fe.Day, fe.Hour, fe.Minute, fe.Second);
                        if (fe >= fx) row.Delete();
                    }
                    dataGridView1.DataSource = data;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        var fe = Convert.ToDateTime(row.Cells[4].Value);
                        var fx = new DateTime(int.Parse(row.Cells[6].Value.ToString().Split('-')[1].Trim()), fe.Month, fe.Day, fe.Hour, fe.Minute, fe.Second);
                        var fd = fx - fe;
                        var x = Convert.ToInt64(fd.TotalDays) / 365; // dif de años
                        row.Cells[8].Value = x;
                        row.Cells[9].Value = x > 5 ? 15 + (x - 5) : 15; // dias de vacaciones del periodo

                        var p = Convert.ToInt32(row.Cells[9].Value) - Convert.ToInt32(row.Cells[10].Value);
                        row.Cells[11].Value = p < 0 ? 0 : p;
                    }

                }
                                
                dataGridView1.AutoResizeColumns();
                
                dataGridView1.Columns[4].DefaultCellStyle.Format = "d";
                if (cbxEstado.SelectedIndex == 0) dataGridView1.Columns[9].DefaultCellStyle.Format = "d";

                Label1.Text = dataGridView1.RowCount + @" REGISTRO(S)";
                label6.Text = @"NOTA: 15 días obligatorio para VIGILANTES DE SEGURIDAD***";
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                dataGridView1.DataSource = null;
            }
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            LlenarDetalleVacaciones(txtFiltro.Text.Trim());
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbxHasta.SelectedValue) < Convert.ToInt32(cbxDesde.SelectedValue))
            {
                MessageBox.Show(@"EL RANGO DE PERÍODOS SELEECIONADO NO ES VÁLIDO!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LlenarDetalleVacaciones(txtFiltro.Text.Trim());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var fec = DateTime.Now;

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
                worksheet.Range["A3:" + ic + "3"].Value = "PENDIENTES DE VACACIONES DEL " + cbxDesde.Text + " AL " + cbxHasta.Text + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
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
                MessageBox.Show(@"ARCHIVO generado correctamente!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
    }
}
