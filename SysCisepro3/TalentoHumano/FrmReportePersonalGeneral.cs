using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using SysCisepro3.Reportes;
using System.Data; 
using Microsoft.Office;
using System.IO;
using Krypton.Toolkit;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmReportePersonalGeneral : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para visualizar detalles en la asistencia del personal
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }
        
        
        private static FrmReportePersonalGeneral _instance;
        public static FrmReportePersonalGeneral Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmReportePersonalGeneral();
                return _instance;
            }
        }

        private readonly ClassPersonal _objPersonal;
        private readonly syscisepro.crCredencialExport _crCredencialExportCisepro;
        private readonly syscisepro.crCredencialExportSeportpac _crCredencialExportSeportpac;
        private readonly syscisepro.crFichaPersonal _crFichaPersonal;
        private readonly syscisepro.crFichaPersonalSeportpac _crFichaPersonalSeportpac;
        private readonly syscisepro.dsOperaciones _dsOperaciones;
        private string _apellidop;
        private string _apellidom;
        //private string _nombres;

        private readonly crCredencialExport2 _crCredencialProyecto;

        public FrmReportePersonalGeneral(TipoConexion tipoCon, ClassUsuarioGeneral usuario)
        {
            InitializeComponent();
            TipoCon = tipoCon;
            Usuario = usuario;

            _objPersonal = new ClassPersonal();
            _dsOperaciones = new syscisepro.dsOperaciones();
            _crFichaPersonal = new syscisepro.crFichaPersonal();
            _crCredencialExportCisepro = new syscisepro.crCredencialExport();
            _crCredencialExportSeportpac = new syscisepro.crCredencialExportSeportpac();
            _crCredencialProyecto = new crCredencialExport2();
        }

        private FrmReportePersonalGeneral()
        {
            InitializeComponent();

            _objPersonal = new ClassPersonal();
            _dsOperaciones = new syscisepro.dsOperaciones();
            _crFichaPersonal = new syscisepro.crFichaPersonal();
            _crFichaPersonalSeportpac = new syscisepro.crFichaPersonalSeportpac();
            _crCredencialExportCisepro = new syscisepro.crCredencialExport();
            _crCredencialExportSeportpac = new syscisepro.crCredencialExportSeportpac();
            _crCredencialProyecto = new crCredencialExport2();
        }

        private void FormReportePersonalGeneral_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            toolStripLabel1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStripLabel1.ForeColor = Color.White;
            dgvPersonal.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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
            ValidationForms.SetPlaceholder(txtFiltro, "BUSCAR ....");
            var f = Usuario.ObtenerFechaSola(TipoCon);

            dtpFechaDesde.Value = new DateTime(f.Year, f.Month, 1);
            dtpFechaHasta.Value = dtpFechaDesde.Value.AddMonths(1).AddDays(-1);

            CargaProyectos();

            cbxEstado.SelectedIndex = 2;
            cbxTipo.SelectedIndex = 0;
            cbxOrden.SelectedIndex = 0;

            comboBox2.SelectedIndex = 2;
            comboBox1.SelectedIndex = 0;

            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            var data = Usuario.GetDatosEmpresa(TipoCon);
            lblEmpresa.Text = data.Rows.Count > 0 ? data.Rows[0][4].ToString().Trim() : string.Empty;
            lblRuc.Text = data.Rows.Count > 0 ? data.Rows[0][2].ToString().Trim() : string.Empty;
            
            txtFiltro.Clear();
            TabControl1.SelectedIndex = 0;
            LlenarDetalleReporte(txtFiltro.Text.Trim());
        }

        private void LlenarDetalleReporte(string fil)
        {
            try
            {
                dataGridView1.Rows.Clear();

                var fechaDesde = dtpFechaDesde.Value.Year + "-" + dtpFechaDesde.Value.Month + "-" + dtpFechaDesde.Value.Day + " 00:00:00";
                var fechaHasta = dtpFechaHasta.Value.Year + "-" + dtpFechaHasta.Value.Month + "-" + dtpFechaHasta.Value.Day + " 23:59:59";

                //var data = _objPersonal.SeleccionarTodosRegistrosPersonalPorFiltros(TipoCon, fil, cbxEstado.SelectedIndex.ToString(), fechaDesde, fechaHasta, RadioButton1.Checked, cbxOrden.SelectedIndex, cbxTipo.SelectedIndex, (int)cbxProyecto.SelectedValue);
                var data = _objPersonal.SeleccionarTodosRegistrosPersonalPorFiltros(TipoCon, (int)cbxProyecto.SelectedValue, cbxTipo.SelectedIndex, cbxEstado.SelectedIndex.ToString(), fil, RadioButton1.Checked, cbxOrden.SelectedIndex, fechaDesde, fechaHasta);
                if (data.Rows.Count == 0)
                {
                    dgvPersonal.DataSource = null;
                    toolStripLabel1.Text = @"NO SE ENCONTRARO REGISTROS!";
                    return;
                }

                dgvPersonal.DataSource = data;
                dgvPersonal.AutoResizeColumns();

                dgvPersonal.Columns[0].Width = 45; // id
                dgvPersonal.Columns[1].Width = 75; // cedula
                dgvPersonal.Columns[2].Width = 230; // apellidos y nombres
                dgvPersonal.Columns[3].Width = 45; // sexo
                dgvPersonal.Columns[4].Width = 80; // movil
                dgvPersonal.Columns[5].Width = 80; // fecha nacimiento
                dgvPersonal.Columns[6].Width = 300; // direccion
                dgvPersonal.Columns[7].Width = 80; // fecha ingreso
                dgvPersonal.Columns[8].Width = 70; // estado trabajo
                dgvPersonal.Columns[9].Width = 90; // fecha salida
                dgvPersonal.Columns[10].Width = 250; // puesto contrato
                dgvPersonal.Columns[11].Width = 200; // cargo
                dgvPersonal.Columns[12].Visible = false; // area
                dgvPersonal.Columns[13].Width = 300; // puesto programacion
                dgvPersonal.Columns[14].Width = 300; // observacion
                dgvPersonal.Columns[15].Visible = false; // foto
                dgvPersonal.Columns[16].Width = 400; // documentos
                dgvPersonal.Columns[17].Visible = false; // apellidos
                dgvPersonal.Columns[18].Visible = false; // nombres
                dgvPersonal.Columns[19].HeaderText= "COD CARGO";  // codcargo sectorial
                dgvPersonal.Columns[20].HeaderText = "SUELDO"; // SUELDO
                dgvPersonal.Columns[21].HeaderText = "ÚLT. ROL P.";  // total ganado
                dgvPersonal.Columns[22].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;// edad
                dgvPersonal.Columns[23].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;// estatura
                dgvPersonal.Columns[24].HeaderText = "ESTADO CIVIL"; // ESTADO CIVIL
                dgvPersonal.Columns[24].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                // EMAIL
                // proyecto
                dgvPersonal.Columns[27].Visible = false; // id proyecto

                dgvPersonal.AutoResizeRows();
                toolStripLabel1.Text = dgvPersonal.RowCount + @" REGISTROS EN TOTAL";

                try
                {                    
                   // if (dataGridView1.Columns[3] != null) dataGridView1.Columns[3].DefaultCellStyle.Format = "g";

                    var dx = string.Empty;
                    foreach (DataGridViewRow row in dgvPersonal.Rows)
                    {
                        // verificar documentos
                        dx = row.Cells[16].Value.ToString().Trim().Substring(3);
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
                        else row.Cells[16].Value = "NO SE HA REGISTADO LA DOCUMENTACIÓN"; 
                        
                        // datos seguro
                        dataGridView1.Rows.Add(
                            row.Cells[0].Value.ToString().Trim(),//id
                            row.Cells[1].Value.ToString().Trim(),//cedula
                            row.Cells[2].Value.ToString().Trim(),//nombres
                            row.Cells[5].Value.ToString().Trim(),//fnac
                            "ECUATORIANA",
                            row.Cells[7].Value.ToString().Trim(),//fingre
                            row.Cells[11].Value.ToString().Trim());//cargo


                        // datos pichincha
                        dataGridView2.Rows.Add(
                            row.Cells[0].Value.ToString().Trim(),
                            "C",
                            row.Cells[1].Value.ToString().Trim(),
                            row.Cells[2].Value.ToString().Trim(),
                            "ECUATORIANA",
                            row.Cells[5].Value.ToString().Trim(),
                            row.Cells[3].Value.ToString().Trim(),
                            row.Cells[20].Value.ToString().Trim(),
                            row.Cells[21].Value.ToString().Trim(),
                             row.Cells[11].Value.ToString().Trim(),
                             row.Cells[4].Value.ToString().Trim(),
                             "",
                            row.Cells[7].Value.ToString().Trim()); 
                    }
                    dataGridView1.AutoResizeRows();
                    dataGridView2.AutoResizeRows();
                }
                catch (Exception)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();
                }
            }
            catch
            {
                dgvPersonal.DataSource = null;
            }
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            LlenarDetalleReporte(txtFiltro.Text.Trim());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.RowCount == 0) return;
            try
            {
                var ids = (from DataGridViewRow row in dgvPersonal.Rows select row.Cells[0].Value.ToString()).ToList();
               
                
                switch (TipoCon)
                {
                    case TipoConexion.Seportpac:
                        _crCredencialExportSeportpac.SetDataSource(_objPersonal.BuscarPersonalPorIdsInPersonal(TipoCon, ids));
                        crvCredenciales.ReportSource = _crCredencialExportSeportpac;
                        break;
                    case TipoConexion.Asenava:
                        break;
                    default:
                        //_crCredencialExportCisepro.SetDataSource(_objPersonal.BuscarPersonalPorIdsInPersonal(TipoCon, ids));
                        _crCredencialProyecto.SetDataSource(_objPersonal.BuscarPersonalPorIdsInPersonalProyecto(TipoCon, ids));
                        //crvCredenciales.ReportSource = _crCredencialExportCisepro;
                        crvCredenciales.ReportSource = _crCredencialProyecto;
                        break;
                }

                crvCredenciales.Zoom(2);
                crvCredenciales.Refresh();
            }
            catch
            {
                crvCredenciales.ReportSource = null;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            { 
                var app = new Microsoft.Office.Interop.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

                worksheet.Name = (RadioButton1.Checked ? "INGRESOS" : "SALIDAS") + "_PERSONAL";

                var l = -1;
                for (var i = 0; i <= dgvPersonal.Columns.Count - 1; i++) if (dgvPersonal.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l); // PARA FIRMA Y HUELLA

                var rc = dgvPersonal.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - INGRESOS / SALIDAS";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = "CONTROL " + (RadioButton1.Checked ? "INGRESOS" : "SALIDAS") + " DEL PERSONAL               Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;

                var x = 1;
                for (var i = 0; i <= dgvPersonal.Columns.Count - 1; i++)
                {
                    if (!dgvPersonal.Columns[i].Visible) continue;

                    worksheet.Cells[head, x] = dgvPersonal.Columns[i].HeaderText;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
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
                        if ((row.Tag + "").Equals("2") || (row.Tag + "").Equals("3")) worksheet.Cells[head, y].Font.Bold = true;
                        worksheet.Cells[head, y].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        y++;
                    }
                    head++;
                }

                var position = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[2, 7];
                Clipboard.SetImage(ValidationForms.Logo(TipoCon));
                worksheet.Paste(position);

                worksheet.Range["A1:" + ic + rc].Columns.AutoFit();
                app.DisplayAlerts = false;
                app.Visible = true;
                app.DisplayAlerts = true;
                //workbook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                KryptonMessageBox.Show(@"CONTROL DE " + (RadioButton1.Checked ? "INGRESOS" : "SALIDAS") + @" DEL PERSONAL generado correctamente!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!" + "\n" + ex.Message, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Microsoft.Office.Interop.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

                worksheet.Name = "DATOS_SEGURO";

                var l = -1;
                for (var i = 0; i <= dataGridView1.Columns.Count - 1; i++) if (dataGridView1.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l); // PARA FIRMA Y HUELLA

                var rc = dataGridView1.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - DATOS SEGURO";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = "DATOS SEGURO DEL PERSONAL               Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;

                var x = 1;
                for (var i = 0; i <= dataGridView1.Columns.Count - 1; i++)
                {
                    if (!dataGridView1.Columns[i].Visible) continue;

                    worksheet.Cells[head, x] = dataGridView1.Columns[i].HeaderText;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
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
                        //if (j == 3 || j == 5)
                        //{
                        //    var f = Convert.ToDateTime(row.Cells[j].Value);
                        //    worksheet.Cells[head, y] = ((f.Day < 10) ? "0" + f.Day : "" + f.Day) + "/" + ((f.Month < 10) ? "0" + f.Month : "" + f.Month) + "/" + f.Year;
                        //}
                        //else 
                       



                        worksheet.Cells[head, y] = row.Cells[j].Value.ToString();


                        worksheet.Cells[head, y].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        y++;
                    }
                    head++;
                }

                var position = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[2, 7];
                Clipboard.SetImage(ValidationForms.Logo(TipoCon));
                worksheet.Paste(position);

                worksheet.Range["A1:" + ic + rc].Columns.AutoFit();
                app.DisplayAlerts = false;
                app.Visible = true;
                app.DisplayAlerts = true;
                KryptonMessageBox.Show(@"DATOS DEL PERSONAL generado correctamente!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvPersonal.RowCount == 0) return;
            try
            {
                foreach (DataGridViewRow row in dgvPersonal.Rows)
                {
                    _dsOperaciones.Tables["ReporteFichas"].Rows.Add(
                        row.Cells[0].Value.ToString(), // ID
                        row.Cells[1].Value.ToString(), // CEDULA
                        row.Cells[2].Value.ToString(), // NOMINA
                        row.Cells[3].Value.ToString(), // SEXO
                        row.Cells[4].Value.ToString(), // movil
                        string.Format("{0:dd/MM//yyyy}", Convert.ToDateTime(row.Cells[5].Value)), // fnac                        
                        row.Cells[6].Value.ToString(), // direc
                        string.Format("{0:dd/MM//yyyy}", Convert.ToDateTime(row.Cells[7].Value)), // fingre
                        row.Cells[8].Value.ToString(), // estado
                        row.Cells[9].Value.ToString().Trim().Length == 0 ? "---" : string.Format("{0:dd/MM//yyyy}", Convert.ToDateTime(row.Cells[9].Value)),// fsal
                        row.Cells[11].Value.ToString(), // cargo
                        row.Cells[12].Value.ToString(), // area 
                        row.Cells[13].Value.ToString().Trim().Length == 0 ? row.Cells[10].Value.ToString() : row.Cells[13].Value.ToString(), // puesto
                        row.Cells[14].Value.ToString(), // observ
                        (byte[])row.Cells[15].Value // foto
                        );
                }

                var tit = "PERSONAL DE LA COMPAÑÍA, DEL " + dtpFechaDesde.Value.ToShortDateString() + " AL " + dtpFechaHasta.Value.ToShortDateString();

                switch (TipoCon)
                {
                    case TipoConexion.Seportpac:
                        _crFichaPersonalSeportpac.SetDataSource(_dsOperaciones.Tables["ReporteFichas"]);
                        _crFichaPersonalSeportpac.SetParameterValue("tit",tit);
                        crvFichas.ReportSource = _crFichaPersonalSeportpac;
                        break;
                    case TipoConexion.Asenava:
                        break;
                    default:
                        _crFichaPersonal.SetDataSource(_dsOperaciones.Tables["ReporteFichas"]);
                        _crFichaPersonal.SetParameterValue("tit", tit);
                        crvFichas.ReportSource = _crFichaPersonal;
                        break;
                }

                crvFichas.Zoom(2);
                crvFichas.Refresh();
            }
            catch
            {
                crvFichas.ReportSource = null;
            }
        }

        private void CargaProyectos()
        {
            try
            {
                cbxProyecto.DataSource = _objPersonal.SeleccionarProyectosContratoReporte(TipoCon);
                cbxProyecto.DisplayMember = "PROYECTO";
                cbxProyecto.ValueMember = "ID";
                if (((System.Data.DataTable)cbxProyecto.DataSource).Rows.Count > 0) cbxProyecto.SelectedIndex = 0;
            }
            catch
            {
                cbxProyecto.DataSource = null;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            TabControl1.SelectedIndex = 1;
            LlenarDetalleReporteCne(textBox1.Text.Trim());
        }

        private void LlenarDetalleReporteCne(string fil)
        {
            try
            {
                dataGridView3.DataSource = null;

                var data = _objPersonal.SeleccionarTodosRegistrosPersonalCne(TipoCon, fil, comboBox2.SelectedIndex, comboBox1.SelectedIndex);
                if (data.Rows.Count == 0)
                {
                    dataGridView3.DataSource = null;
                    toolStripLabel1.Text = @"NO SE ENCONTRARO REGISTROS!";
                    return;
                }

                dataGridView3.DataSource = data;
                dataGridView3.AutoResizeColumns();

                dataGridView3.Columns[0].HeaderText = "ID";
                dataGridView3.Columns[1].HeaderText = "CÉDULA";
                dataGridView3.Columns[2].HeaderText = "APELLIDOS Y NOMBRES";
                dataGridView3.Columns[3].HeaderText = "INSTRUCCIÓN";
                dataGridView3.Columns[4].HeaderText = "DIRECCIÓN COMPLETA DEL DOMICILIO (CALLES PRINCIPAL)";
                dataGridView3.Columns[5].HeaderText = "NÚMERO  DOMICILIO";
                dataGridView3.Columns[6].HeaderText = "DIRECCIÓN COMPLETA DEL DOMICILIO (CALLE SECUNDARIA)";
                dataGridView3.Columns[7].HeaderText = "REFERENCIA";
                dataGridView3.Columns[8].HeaderText = "CANTÓN DOMICILIO";
                dataGridView3.Columns[9].HeaderText = "PARROQUIA DOMICILIO";
                dataGridView3.Columns[10].HeaderText = "BARRIO O CIUDADELA";
                dataGridView3.Columns[11].HeaderText = "SECTOR";
                dataGridView3.Columns[12].HeaderText = "TELÉFONO CONVENCIONAL";
                dataGridView3.Columns[13].HeaderText = "TELÉFONO CELULAR";
                dataGridView3.Columns[14].HeaderText = "CORREO ELECTRÓNICO";
                dataGridView3.Columns[15].HeaderText = "CORREO ELECTRÓNICO INSTITUCIONAL";
                dataGridView3.Columns[16].HeaderText = "SUCURSAL/DEPARTAMENTO";
                dataGridView3.Columns[17].HeaderText = "CÓDIGO POSTAL DIRECCIÓN";

                dataGridView3.AutoResizeRows();
                toolStripLabel1.Text = dataGridView3.RowCount + @" REGISTROS EN TOTAL";           
            }
            catch
            {
                dataGridView3.DataSource = null;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView3.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Microsoft.Office.Interop.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

                worksheet.Name = "REPORTE CNE";

                var l = -1;
                for (var i = 0; i <= dataGridView3.Columns.Count - 1; i++) if (dataGridView3.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l); // PARA FIRMA Y HUELLA

                var rc = dataGridView3.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = "REPORTE DEL PERSONAL               Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;

                var x = 1;
                for (var i = 0; i <= dataGridView3.Columns.Count - 1; i++)
                {
                    if (!dataGridView3.Columns[i].Visible) continue;

                    worksheet.Cells[head, x] = dataGridView3.Columns[i].HeaderText;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    var y = 1;
                    for (var j = 0; j <= dataGridView3.Columns.Count - 1; j++)
                    {
                        if (!dataGridView3.Columns[j].Visible) continue;
                        worksheet.Cells[head, y] = row.Cells[j].Value;
                        if ((row.Tag + "").Equals("2") || (row.Tag + "").Equals("3")) worksheet.Cells[head, y].Font.Bold = true;
                        worksheet.Cells[head, y].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        y++;
                    }
                    head++;
                }

                var position = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[2, 7];
                Clipboard.SetImage(ValidationForms.Logo(TipoCon));
                worksheet.Paste(position);

                worksheet.Range["A1:" + ic + rc].Columns.AutoFit();
                app.DisplayAlerts = false;
                app.Visible = true;
                app.DisplayAlerts = true;
                KryptonMessageBox.Show(@"REPORTE DEL PERSONAL generado correctamente!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!" + "\n" + ex.Message, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            LlenarDetalleReporteCne(textBox1.Text.Trim());
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            var _anio = dtpFechaDesde.Value.Year;
            var _mes = dtpFechaDesde.Value.Month;
            var _dia = dtpFechaDesde.Value.Day;
            
            if (dgvPersonal.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
            
            if (cbxEstado.SelectedItem.ToString() != "ACTIVO" )
            {
                KryptonMessageBox.Show(@"ELIJA EL PERSONAL ACTIVO!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

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
                    FileName = ("NOVEN" + fec.Year + fec.Month + fec.Day + "_" + fec.Hour + fec.Minute + ".txt"),
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;
                if (!sfd.FileName.EndsWith(".txt")) sfd.FileName += ".txt";
                if (File.Exists(sfd.FileName) == false) File.Create(sfd.FileName).Dispose();

                var objWriter = new StreamWriter(sfd.FileName, true);

                foreach (DataGridViewRow row in dgvPersonal.Rows)
                {
                    if ((row.Cells[0].Value + "").Trim().Length == 0 ) continue;

                    objWriter.WriteLine(
                        ruc + ";" +                                                                     // RUC de la empresa (13 dígitos)
                        suc + ";" +                                                                     // Código de la sucursal (4 dígitos)
                        _anio + ";" +                                                                   // Año actual (4 dígitos formato YYYY)
                        (_mes < 10 ? "0" + _mes : _mes + "") + ";" +                                    // Mes actual (2 dígitos formato MM)
                        "ENT;" +                                                                        // Tipo de movimiento (prefijado como INS)
                        row.Cells[1].Value.ToString().Trim() + ";" +                                    // Cédula de identidad del afiliado afectado (10 dígitos)
                        _anio + (_mes < 10 ? "0" + _mes : _mes + "") + _dia + ";" +                     // Fecha de Ingreso en la empresa (8 digitos formato YYYYMMDD)
                        _anio + (_mes < 10 ? "0" + _mes : _mes + "") + _dia + ";" +                     // Fecha de Ingreso en el sistema  (8 digitos formato YYYYMMDD)
                        "1" + ";" +                                                                     // Jornada 
                        "R" + ";" +                                                                     // Codigo de seguro social
                        "2" + ";" +                                                                     // Codigo del tipo de empleador
                        "06" + ";" +                                                                    // Relacion de trabajo (2 digitos)
                        CompletarConEspacio(row.Cells[11].Value.ToString().Trim(), 64, true) + ";" +    // Denominacion de cargo (maximo 64 digitos)
                        CompletarConEspacio(row.Cells[19].Value.ToString().Trim(), 13, true) + ";" +    // Codigo de Actividad Sectorial (maximo 13 digitos)
                        CompletarConEspacio(row.Cells[20].Value.ToString().Trim(), 14, true) + ";" +    // Sueldo (maximo 14 digitos)
                         "P");
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

        private void btnSalida_Click(object sender, EventArgs e)
        {
            var _anio = dtpFechaDesde.Value.Year;
            var _mes = dtpFechaDesde.Value.Month;
            var _dia = dtpFechaDesde.Value.Day;

            if (dgvPersonal.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            if (cbxEstado.SelectedItem.ToString() != "INACTIVO" || !RadioButton2.Checked  )
            {
                KryptonMessageBox.Show(@"ELIJA EL PERSONAL INACTIVO Y FECHA DE SALIDA !", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

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
                    FileName = ("NOVSA" + fec.Year + fec.Month + fec.Day + "_" + fec.Hour + fec.Minute + ".txt"),
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;
                if (!sfd.FileName.EndsWith(".txt")) sfd.FileName += ".txt";
                if (File.Exists(sfd.FileName) == false) File.Create(sfd.FileName).Dispose();

                var objWriter = new StreamWriter(sfd.FileName, true);

                foreach (DataGridViewRow row in dgvPersonal.Rows)
                {
                    if ((row.Cells[0].Value + "").Trim().Length == 0) continue;

                    objWriter.WriteLine(
                        ruc + ";" +                                                                     // RUC de la empresa (13 dígitos)
                        suc + ";" +                                                                     // Código de la sucursal (4 dígitos)
                        _anio + ";" +                                                                   // Año actual (4 dígitos formato YYYY)
                        (_mes < 10 ? "0" + _mes : _mes + "") + ";" +                                    // Mes actual (2 dígitos formato MM)
                        "SAL;" +                                                                        // Tipo de movimiento (prefijado como INS)
                        row.Cells[1].Value.ToString().Trim() + ";" +                                    // Cédula de identidad del afiliado afectado (10 dígitos)
                        Convert.ToDateTime(row.Cells[9].Value).ToString("yyyyMMdd") + ";" +             // Fecha de Salida (8 digitos formatao YYYYMMDD)

                        //_anio + (_mes < 10 ? "0" + _mes : _mes + "") + _dia + ";" +                     // Fecha de Ingreso en la empresa (8 digitos formato YYYYMMDD)
                        //_anio + (_mes < 10 ? "0" + _mes : _mes + "") + _dia + ";" +                     // Fecha de Ingreso en el sistema  (8 digitos formato YYYYMMDD)
                        //"1" + ";" +                                                                     // Jornada 
                        "A" + ";" +                                                                     // Codigo de seguro social
                        "00000000"                     
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}