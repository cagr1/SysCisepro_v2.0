using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Interop;
using DataTable = System.Data.DataTable;
using SysCisepro3.Properties;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmNotificarNovedades : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para registrar detalles, denuncias o notificaciones del personal
        /// </summary>
        private static TipoConexion TipoCon { get; set; }
        private static ClassUsuarioGeneral Usuario { get; set; }
        private readonly int _tipoForm;

        public DataTable DataNotificacion { get; set; }
        public DataTable DataVacaciones { get; set; }
        public DataTable Data3Meses { get; set; }

        public FrmNotificarNovedades(TipoConexion tipcon, ClassUsuarioGeneral user, string lbl, int tipo)
        {
            InitializeComponent();
            _tipoForm = tipo;
            TipoCon = tipcon;
            Usuario = user;
            label1.Text = lbl;

            dgvNotificacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVacaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv3meses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvNotificacion.RowCount == 0)
            {
                MessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", @"MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];

                worksheet.Name = @"DETALLES DE NOTIFICACIÓN";

                var l = -1;
                for (var i = 0; i <= dgvNotificacion.Columns.Count - 1; i++) if (dgvNotificacion.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l); // PARA FIRMA Y HUELLA

                var rc = dgvNotificacion.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - DETALLES DE NOTIFICACIÓN" + "               Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = label1.Text;
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;

                var x = 1;
                for (var i = 0; i <= dgvNotificacion.Columns.Count - 1; i++)
                {
                    if (!dgvNotificacion.Columns[i].Visible) continue;

                    worksheet.Cells[head, x] = dgvNotificacion.Columns[i].HeaderText;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (DataGridViewRow row in dgvNotificacion.Rows)
                {
                    var y = 1;
                    for (var j = 0; j <= dgvNotificacion.Columns.Count - 1; j++)
                    {
                        if (!dgvNotificacion.Columns[j].Visible) continue;
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
                MessageBox.Show(@"PERSONAL generado correctamente!", @"MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR!", @"MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_tipoForm == 0) DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmNotificarNovedades_Load(object sender, EventArgs e)
        {
            dgvNotificacion.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvVacaciones.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgv3meses.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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

            dgvNotificacion.DataSource = DataNotificacion;
            dgvVacaciones.DataSource = DataVacaciones;
            dgv3meses.DataSource = Data3Meses;

            try
            {
                switch (_tipoForm)
                {
                    case 0: // personal con detalles notificaciones legales
                        dgvNotificacion.AutoResizeRows();
                        dgvNotificacion.Visible = true;
                        panelNotificacion.Visible = false;
                        button1.Visible = true;
                        break;

                    case 1: // clientes por facturar
                        dgvNotificacion.Columns[0].Width = 500;
                        dgvNotificacion.AutoResizeRows();
                        dgvNotificacion.Visible = true;
                        panelNotificacion.Visible = false;
                        button1.Visible = true;
                        break;
                    case 2: // personal vacaciones pendiente operativo
                        dgvNotificacion.Columns[0].Width = 40;
                        dgvNotificacion.Columns[1].Width = 80;
                        dgvNotificacion.Columns[4].Visible = false;
                        dgvNotificacion.Columns[5].Visible = false;
                        dgvNotificacion.Columns[6].Width = 80;
                        dgvNotificacion.Columns[7].Width = 50;
                        dgvNotificacion.AutoResizeRows();
                        dgvNotificacion.Visible = true;
                        panelNotificacion.Visible = false;
                        button1.Visible = true;
                        break;
                    case 3: // personal por culminar proyecto (15 dias anticipacion) 
                        dgvNotificacion.Visible = false;
                        panelNotificacion.Visible = true;
                        dgvNotificacion.DataSource = null;

                        dgvVacaciones.DataSource = DataNotificacion;
                        tabPage1.Text = "POR CULMINAR PROYECTO";
                        dgvVacaciones.Columns[0].Width = 40;
                        dgvVacaciones.Columns[1].Width = 80;
                        dgvVacaciones.Columns[1].DefaultCellStyle.Format = "d";
                        dgvVacaciones.Columns[2].Width = 80;
                        dgvVacaciones.Columns[3].Width = 150;
                        dgvVacaciones.Columns[4].Width = 150;
                        dgvVacaciones.Columns[5].HeaderText = @"PROYECTO";
                        dgvVacaciones.Columns[5].Width = 80;
                        dgvVacaciones.Columns[6].Width = 90;
                        dgvVacaciones.Columns[6].DefaultCellStyle.Format = "d";
                        dgvVacaciones.Columns[7].Width = 90;
                        dgvVacaciones.Columns[7].DefaultCellStyle.Format = "d";
                        dgvVacaciones.Columns[8].Width = 100;
                        dgvVacaciones.Columns[8].HeaderText = "QUEDAN (DÍAS)";

                        dgv3meses.DataSource = DataVacaciones;
                        tabPage2.Text = "POR CULMINAR 3 MESE PRUEBA";
                        dgv3meses.Columns[0].Width = 40;
                        dgv3meses.Columns[1].Width = 80;
                        dgv3meses.Columns[1].DefaultCellStyle.Format = "d";
                        dgv3meses.Columns[2].Width = 80;
                        dgv3meses.Columns[3].Width = 150;
                        dgv3meses.Columns[4].Width = 250;
                        dgv3meses.Columns[5].Width = 250;

                        button1.Visible = true;
                        break;
                    case 4: // personal vacaciones pendiente operativo tipo empresa
                        dgvVacaciones.Columns[0].Width = 60;
                        dgvVacaciones.Columns[1].Width = 40;
                        dgvVacaciones.Columns[2].Width = 80;
                        dgvVacaciones.Columns[5].Visible = false;
                        dgvVacaciones.Columns[6].Visible = false;
                        dgvVacaciones.Columns[7].Width = 80;
                        dgvVacaciones.Columns[8].Width = 50;
                        dgvVacaciones.AutoResizeRows();

                        dgv3meses.Columns[0].Width = 60;
                        dgv3meses.Columns[1].Width = 40;
                        dgv3meses.Columns[2].Width = 80;
                        dgv3meses.Columns[2].DefaultCellStyle.Format = "d";
                        dgv3meses.Columns[3].Width = 80;
                        dgv3meses.Columns[4].Width = 150;
                        dgv3meses.Columns[5].Width = 150;
                        dgv3meses.Columns[6].HeaderText = @"7 MESES";
                        dgv3meses.Columns[6].Width = 80;
                        dgv3meses.Columns[6].DefaultCellStyle.Format = "d";
                        dgv3meses.Columns[7].Width = 250;

                        dgv3meses.AutoResizeRows();

                        dgvNotificacion.Visible = false;
                        panelNotificacion.Visible = true;
                        button1.Visible = false;
                        break;
                    case 5: // lista de registros que no suma en los balances (codigo cambiado por nombre de cuenta)
                        dgvNotificacion.Columns[0].Width = 40;
                        dgvNotificacion.Columns[1].Width = 80;
                        dgvNotificacion.Columns[1].DefaultCellStyle.Format = "d";
                        dgvNotificacion.Columns[2].Width = 80;
                        dgvNotificacion.Columns[3].Width = 300;
                        dgvNotificacion.Columns[4].Visible = false;
                        dgvNotificacion.Columns[5].Width = 300;
                        dgvNotificacion.Columns[6].Visible = false;
                        dgvNotificacion.Columns[7].Visible = false;
                        dgvNotificacion.Columns[8].Visible = false;
                        dgvNotificacion.Columns[9].Visible = false;
                        dgvNotificacion.Columns[10].Width = 80;
                        dgvNotificacion.Columns[11].Width = 80;
                        dgvNotificacion.Columns[12].Width = 80;
                        dgvNotificacion.Columns[13].Visible = false;
                        dgvNotificacion.Columns[14].Visible = false;
                        dgvNotificacion.Columns[15].Visible = false;
                        dgvNotificacion.Columns[16].Visible = false;
                        dgvNotificacion.Columns[17].Visible = false;

                        dgvNotificacion.AutoResizeRows();
                        dgvNotificacion.Visible = true;
                        panelNotificacion.Visible = false;
                        button1.Visible = true;
                        break;
                    case 6: // lista de personal minimo 2 meses que no tiene documentacion

                        var dx = string.Empty;
                        foreach (DataGridViewRow row in dgvNotificacion.Rows)
                        {
                            dx = row.Cells[6].Value.ToString().Trim().Substring(3);
                            if (dx.Contains(";"))
                            {
                                var docs = dx.Split(';');
                                row.Cells[16].Value = string.Empty;
                                foreach (var dc in docs)
                                {
                                    switch (dc.Trim())
                                    {
                                        case "CV":
                                            row.Cells[16].Value += row.Cells[16].Value.ToString().Trim().Length == 0 ? "CURRÍCULUM VITAE" : " - CURRÍCULUM VITAE";
                                            break;
                                        case "CI":
                                            row.Cells[16].Value += row.Cells[16].Value.ToString().Trim().Length == 0 ? "CÉDULA DE IDENTIDAD Y CERT. DE VOTACIÓN" : " - CÉDULA DE IDENTIDAD Y CERT. DE VOTACIÓN";
                                            break;
                                        case "LM":
                                            row.Cells[16].Value += row.Cells[16].Value.ToString().Trim().Length == 0 ? "LIBRETA MILITAR" : " - LIBRETA MILITAR";
                                            break;
                                        case "SE":
                                            row.Cells[16].Value += row.Cells[16].Value.ToString().Trim().Length == 0 ? "SOLICITUD DE EMPLEO" : " - SOLICITUD DE EMPLEO";
                                            break;
                                        case "TS":
                                            row.Cells[16].Value += row.Cells[16].Value.ToString().Trim().Length == 0 ? "TÍTULO REGISTRO SENESCYT" : " - TÍTULO REGISTRO SENESCYT";
                                            break;
                                        case "VS":
                                            row.Cells[16].Value += row.Cells[16].Value.ToString().Trim().Length == 0 ? "CERT. 120H VIGILANTE DE SEGURIDAD" : " - CERT. 120H VIGILANTE DE SEGURIDAD";
                                            break;
                                        case "ES":
                                            row.Cells[16].Value += row.Cells[16].Value.ToString().Trim().Length == 0 ? "EXÁMEN PSICOLÓGICO" : " - EXÁMEN PSICOLÓGICO";
                                            break;
                                        case "AM":
                                            row.Cells[16].Value += row.Cells[16].Value.ToString().Trim().Length == 0 ? "ACTA MATRIMONIO / UNIÓN LIBRE" : " - ACTA MATRIMONIO / UNIÓN LIBRE";
                                            break;
                                        case "PN":
                                            row.Cells[16].Value += row.Cells[16].Value.ToString().Trim().Length == 0 ? "PART. NACIMIENTO HIJOS" : " - PART. NACIMIENTO HIJOS";
                                            break;
                                        case "AF":
                                            row.Cells[16].Value += row.Cells[16].Value.ToString().Trim().Length == 0 ? "AFIS (REG. IDENTIFICACIÓN FÍSICA)" : " - AFIS (REG. IDENTIFICACIÓN FÍSICA)";
                                            break;
                                        case "EM":
                                            row.Cells[16].Value += row.Cells[16].Value.ToString().Trim().Length == 0 ? "CERT. EXÁMENES MÉDICOS" : " - CERT. EXÁMENES MÉDICOS";
                                            break;
                                        case "AL":
                                            row.Cells[16].Value += row.Cells[16].Value.ToString().Trim().Length == 0 ? "CERT. APTITUD OCUPACIONAL" : " - CERT. APTITUD OCUPACIONAL";
                                            break;
                                    }
                                }
                            }
                            else row.Cells[6].Value = "NO SE HA REGISTADO LA DOCUMENTACIÓN";
                        }

                        dgvNotificacion.Columns[0].Width = 40;
                        dgvNotificacion.Columns[1].Width = 80;
                        dgvNotificacion.Columns[1].DefaultCellStyle.Format = "d";
                        dgvNotificacion.Columns[2].Width = 80;
                        dgvNotificacion.Columns[3].Width = 250;
                        dgvNotificacion.Columns[4].Width = 250;
                        dgvNotificacion.Columns[5].Width = 300;
                        dgvNotificacion.Columns[6].Width = 300;

                        dgvNotificacion.AutoResizeRows();
                        dgvNotificacion.Visible = true;
                        panelNotificacion.Visible = false;
                        button1.Visible = true;
                        break;
                    case 7 :
                                                
                         dgvNotificacion.Columns[0].Width = 40;
                        dgvNotificacion.Columns[1].Width = 40;
                        dgvNotificacion.Columns[2].Width = 80;
                        dgvNotificacion.Columns[3].Width = 80;
                        dgvNotificacion.Columns[4].Width = 40;
                        dgvNotificacion.Columns[5].Width = 40;
                        dgvNotificacion.Columns[6].Width = 80;
                        dgvNotificacion.Columns[7].Width = 40;
                        dgvNotificacion.Columns[7].HeaderText = @"ANIO";
                        dgvNotificacion.Columns[8].Width = 80;
                        dgvNotificacion.Columns[8].DefaultCellStyle.Format = "d";
                        

                        dgvNotificacion.AutoResizeRows();
                         dgvNotificacion.Visible = true;
                        panelNotificacion.Visible = false;
                        button1.Visible = true;
                        
                        break;
                }
                label2.Text = (dgvNotificacion.Rows.Count + dgvVacaciones.Rows.Count + dgv3meses.Rows.Count) + @" registros en total";
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void dgvVacaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
