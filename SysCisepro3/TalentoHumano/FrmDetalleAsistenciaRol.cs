using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Operaciones;
using ClassLibraryCisepro3.TalentoHumano;
using SysCisepro3.Properties;
using ClassLibraryCisepro3.Estaticas;
using Office = Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using SysCisepro3.Datos;
using SysCisepro3.Reportes;
using ClassLibraryCisepro3.UsuarioGeneral;
using CrystalDecisions.CrystalReports.Engine;
using Krypton.Toolkit;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmDetalleAsistenciaRol : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para visualizar el detalle de asistencia del personal
        /// </summary>
        public bool Admin { private get; set; }
        public string IdRol { private get; set; }
        public string Hoy { private get; set; }

        public string Anio { private get; set; }
        public string Mes1 { private get; set; }

        public DataGridViewRow Fila { private get; set; }
        
        public TipoConexion TipoCon { private get; set; }
        private readonly ClassPersonal _objetoPersonal;
        private readonly ClassAsignacionPersonal _objAsignacionPersonal;
        private readonly FrmBuscarRolPago _objBuscarRolPago;
        public FrmDetalleAsistenciaRol()
        {
            InitializeComponent();
            _objetoPersonal = new ClassPersonal();
            _objAsignacionPersonal = new ClassAsignacionPersonal();
        }

        private void FrmDetalleAsistenciaRol_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            

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
            CargarDetalles();
            
        }

        private void CargarDetalles()
        {
            try
            {
                ListView3.Items.Clear();
                ListView3.Groups.Clear();

                var per = _objetoPersonal.SeleccionarRegistroPersonalPorId(TipoCon, Convert.ToInt32(textBox1.Tag));
               
                var fechaDesde = DateTimePicker7.Value.Day + "-" + DateTimePicker7.Value.Month + "-" +
                                 DateTimePicker7.Value.Year + " 00:00:00";
                var fechaHasta = DateTimePicker6.Value.Day + "-" + DateTimePicker6.Value.Month + "-" +
                                 DateTimePicker6.Value.Year + " 23:59:59";

                var x = Convert.ToDateTime(per.Rows[0][16]);
                var fechain = x.Day + "-" + x.Month + "-" + x.Year + " 00:00:00";
                var fechaIngreso = Convert.ToDateTime(fechaDesde) > Convert.ToDateTime(fechain) ? Convert.ToDateTime(fechaDesde) : Convert.ToDateTime(fechain);

                var s = Convert.ToDateTime(per.Rows[0][17]);
                var fechaou = s.Day + "-" + s.Month + "-" + s.Year + " 00:00:00";
                var fechaSalida = Convert.ToDateTime(fechaou) < Convert.ToDateTime(fechain) ? Convert.ToDateTime(fechaHasta) : Convert.ToDateTime(fechaHasta) > Convert.ToDateTime(fechaou) ? Convert.ToDateTime(fechaou) : Convert.ToDateTime(fechaHasta);

                var group = new ListViewGroup("DETALLE DE ASISTENCIA");
                ListView3.Groups.Add(group);

                if (Admin)
                {
                    var lst = new ListViewItem("0", group)
                    {
                        UseItemStyleForSubItems = false
                    };

                    lst.SubItems.Add(DateTimePicker7.Value.ToShortDateString());
                    lst.SubItems.Add(Validaciones.NombreCompany(TipoCon));
                    lst.SubItems.Add("ASISTENCIA");
                    lst.SubItems.Add("DEL: " + DateTimePicker7.Value.ToShortDateString() + " - AL: " + DateTimePicker6.Value.ToShortDateString());
                    lst.SubItems[3].BackColor = Color.FromArgb(255, 34, 139, 34);
                    lst.SubItems[3].ForeColor = Color.Black;

                    ListView3.Items.Add(lst);

                }else{
                    var vigia = _objAsignacionPersonal.SeleccionarRegistroAsistenciaDetallesByGuardia(TipoCon, true,
                                       Convert.ToInt32(textBox1.Tag), Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta), fechaIngreso, fechaSalida);

                    foreach (DataRow row in vigia.Rows)
                    {
                        var lst = new ListViewItem(row[0] != null ? row[0] + "" : string.Empty, group)
                        {
                            UseItemStyleForSubItems = false
                        };

                        for (var i = 1; i < vigia.Columns.Count; i++)
                        {
                            if (i == 1) lst.SubItems.Add((row[i] + "").Split(' ')[0].Trim());
                            else if (i == 3)
                            {
                                if ((row[3] + "").Equals("31") || (row[3] + "").Equals("31")) row[i] = "PERMISO MÉDICO";
                                else if ((row[3] + "").Equals("32")) row[i] = "CALAMIDAD DOMÉSTICA";
                                else if ((row[3] + "").Equals("34")) row[i] = "VACACIONES";

                                lst.SubItems.Add(row[i] != null ? row[i] + "" : string.Empty);

                                if ((row[i] + "").Equals("ASISTENCIA")) lst.SubItems[3].BackColor = Color.FromArgb(255, 34, 139, 34);
                                if ((row[i] + "").Equals("LIBRE")) lst.SubItems[3].BackColor = Color.FromArgb(255, 135, 206, 250);
                                if ((row[i] + "").Equals("INASISTENCIA")) lst.SubItems[3].BackColor = Color.FromArgb(255, 240, 128, 128);
                                if ((row[i] + "").Equals("DOBLADA")) lst.SubItems[3].BackColor = Color.FromArgb(255, 240, 128, 128);
                                if ((row[i] + "").Equals("ATRASO")) lst.SubItems[3].BackColor = Color.FromArgb(255, 255, 218, 155);
                                if ((row[i] + "").Equals("VACACIONES")) lst.SubItems[3].BackColor = Color.FromArgb(255, 135, 206, 235);
                                if ((row[i] + "").Equals("PERMISO MÉDICO")) lst.SubItems[3].BackColor = Color.FromArgb(255, 255, 218, 155);
                                if ((row[i] + "").Equals("CALAMIDAD DOMÉSTICA")) lst.SubItems[3].BackColor = Color.FromArgb(255, 255, 218, 155);

                                lst.SubItems[3].ForeColor = Color.Black;
                            }
                            else lst.SubItems.Add(row[i] != null ? row[i] + "" : string.Empty);
                        }
                        ListView3.Items.Add(lst);
                    } 
                }  
            }
            catch 
            {
                ListView3.Items.Clear();
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL MOSTRAR DETALLE DE ASISTENCIA!!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
            }
        }

        private void btnCargarPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fila == null) return;

                var ds = new DsSysSecurity();

                foreach (ListViewItem item in ListView3.Items)
                {
                    ds.Tables["dtDetallePuestoRol"].Rows.Add(
                        Convert.ToDateTime(item.SubItems[1].Text).ToShortDateString(),
                        item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text);
                }

                //string empre = Validaciones.NombreCompany(TipoCon) + " CÍA. LTDA.";
                string empre = Validaciones.NombreCompany(TipoCon);
                var rpt = new rptPlanillaPago();
                rpt.SetDataSource(ds.Tables["dtDetallePuestoRol"]);

                rpt.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, System.Windows.Forms.Application.StartupPath));
                rpt.SetParameterValue("idsolicitud", IdRol);
                rpt.SetParameterValue("numdoc", Fila.Cells[2].Value.ToString());
                rpt.SetParameterValue("fecha", Hoy);

                rpt.SetParameterValue("empre", empre);
                rpt.SetParameterValue("nombre", Fila.Cells[5].Value);
                rpt.SetParameterValue("cedula", Fila.Cells[6].Value);
                rpt.SetParameterValue("cargo", Fila.Cells[10].Value);
                rpt.SetParameterValue("puesto", Fila.Cells[4].Value);
                rpt.SetParameterValue("ingreso", Fila.Cells[9].Value);

                rpt.SetParameterValue("diast", Fila.Cells[13].Value);
                rpt.SetParameterValue("diasd", Fila.Cells[15].Value);

                rpt.SetParameterValue("sueldo", Convert.ToDouble(Fila.Cells[17].Value).ToString("N"));
                rpt.SetParameterValue("recargon", 0.ToString("N"));
                rpt.SetParameterValue("adicional", Convert.ToDouble(Fila.Cells[31].Value).ToString("N"));
                rpt.SetParameterValue("otrosing", Convert.ToDouble(Fila.Cells[32].Value).ToString("N"));
                rpt.SetParameterValue("extra", (Convert.ToDouble(Fila.Cells[33].Value) - Convert.ToDouble(Fila.Cells[31].Value)).ToString("N"));
                rpt.SetParameterValue("xiii", (Convert.ToDouble(Fila.Cells[35].Value) + Convert.ToDouble(Fila.Cells[36].Value)).ToString("N"));
                rpt.SetParameterValue("xiv", (Convert.ToDouble(Fila.Cells[37].Value) + Convert.ToDouble(Fila.Cells[38].Value)).ToString("N"));
                rpt.SetParameterValue("fondores", (Convert.ToDouble(Fila.Cells[39].Value) + Convert.ToDouble(Fila.Cells[40].Value)).ToString("N"));

                rpt.SetParameterValue("tingresos", Convert.ToDouble(Fila.Cells[42].Value).ToString("N"));

                rpt.SetParameterValue("desiess", Convert.ToDouble(Fila.Cells[44].Value).ToString("N"));
                rpt.SetParameterValue("desquince", Convert.ToDouble(Fila.Cells[45].Value).ToString("N"));
                rpt.SetParameterValue("desquiro", Convert.ToDouble(Fila.Cells[46].Value).ToString("N"));
                rpt.SetParameterValue("deshipo", Convert.ToDouble(Fila.Cells[47].Value).ToString("N"));
                rpt.SetParameterValue("desextsal", Convert.ToDouble(Fila.Cells[48].Value).ToString("N"));
                rpt.SetParameterValue("desantiem", Convert.ToDouble(Fila.Cells[49].Value).ToString("N"));
                rpt.SetParameterValue("descapaseg", Convert.ToDouble(Fila.Cells[50].Value).ToString("N"));
                rpt.SetParameterValue("desimprent", Convert.ToDouble(Fila.Cells[51].Value).ToString("N"));
                rpt.SetParameterValue("desprestamo", Convert.ToDouble(Fila.Cells[52].Value).ToString("N"));
                rpt.SetParameterValue("descomecsa", Convert.ToDouble(Fila.Cells[53].Value).ToString("N"));
                rpt.SetParameterValue("descomisariato", Convert.ToDouble(Fila.Cells[54].Value).ToString("N"));
                rpt.SetParameterValue("desseguridad", Convert.ToDouble(Fila.Cells[55].Value).ToString("N"));
                rpt.SetParameterValue("desalmuerzo", Convert.ToDouble(Fila.Cells[56].Value).ToString("N"));
                rpt.SetParameterValue("des10mopens", Convert.ToDouble(Fila.Cells[57].Value).ToString("N"));
                rpt.SetParameterValue("despension", Convert.ToDouble(Fila.Cells[58].Value).ToString("N"));
                rpt.SetParameterValue("desmulta", Convert.ToDouble(Fila.Cells[59].Value).ToString("N"));

                rpt.SetParameterValue("diasnolabsegpriv", Convert.ToDouble(Fila.Cells[60].Value).ToString("N"));
                var txtReportHeader = rpt.ReportDefinition.ReportObjects["Text64"] as TextObject;
                txtReportHeader.Text = Admin ? "DESC. DIF. DEC. EXT:" : "DES. DIA NO LAB:";
                
                rpt.SetParameterValue("descdiffdec", Convert.ToDouble(Fila.Cells[61].Value).ToString("N"));
                rpt.SetParameterValue("desodescuentos", Convert.ToDouble(Fila.Cells[62].Value).ToString("N"));
                rpt.SetParameterValue("tdescuentos", Convert.ToDouble(Fila.Cells[63].Value).ToString("N"));

                rpt.SetParameterValue("neto", Convert.ToDouble(Fila.Cells[64].Value).ToString("N"));
                rpt.SetParameterValue("banco", Fila.Cells[72].Value.ToString().Trim().Equals("0") ? "SIN BANCO - PAGADO EN CHEQUE" : Fila.Cells[73].Value + " - " + Fila.Cells[74].Value + " (" + Fila.Cells[75].Value+")");
                 
                var view = new FrmVisualizadorReportes { TipoCon = TipoCon, Titulo = "PLANILLA DE PAGO", crystalReportViewer1 = { ReportSource = rpt } };
                view.ShowDialog();
                view.Dispose();
            }
            catch (Exception)
            {
                KryptonMessageBox.Show(@"Error al generar solicitud. Por favor, contácte al administrador!",
                    "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void btnCargaBasica_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fila == null) return;

                var ds = new DsSysSecurity();

                foreach (ListViewItem item in ListView3.Items)
                {
                    ds.Tables["dtDetallePuestoRol"].Rows.Add(
                        Convert.ToDateTime(item.SubItems[1].Text).ToShortDateString(),
                        item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text);
                }

                //string empre = Validaciones.NombreCompany(TipoCon) + " CÍA. LTDA.";
                string empre = Validaciones.NombreCompany(TipoCon);
                var rpt = new rptPlanillaPagoBasico();
                rpt.SetDataSource(ds.Tables["dtDetallePuestoRol"]);

                rpt.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, System.Windows.Forms.Application.StartupPath));
                rpt.SetParameterValue("idsolicitud", IdRol);
                rpt.SetParameterValue("numdoc", Fila.Cells[2].Value.ToString());
                rpt.SetParameterValue("fecha", Hoy);

                rpt.SetParameterValue("empre", empre);
                rpt.SetParameterValue("nombre", Fila.Cells[5].Value);
                rpt.SetParameterValue("cedula", Fila.Cells[6].Value);
                rpt.SetParameterValue("cargo", Fila.Cells[10].Value);
                rpt.SetParameterValue("puesto", Fila.Cells[4].Value);
                rpt.SetParameterValue("ingreso", Fila.Cells[9].Value);

                rpt.SetParameterValue("diast", Fila.Cells[13].Value);
                rpt.SetParameterValue("diasd", Fila.Cells[15].Value);
                rpt.SetParameterValue("mes", Mes1); 
                rpt.SetParameterValue("anio", Anio);

                rpt.SetParameterValue("sueldo", Convert.ToDouble(Fila.Cells[17].Value).ToString("N"));
                rpt.SetParameterValue("recargon", 0.ToString("N"));
                rpt.SetParameterValue("adicional", Convert.ToDouble(Fila.Cells[31].Value).ToString("N"));
                rpt.SetParameterValue("otrosing", Convert.ToDouble(Fila.Cells[32].Value).ToString("N"));
                rpt.SetParameterValue("extra", (Convert.ToDouble(Fila.Cells[33].Value) - Convert.ToDouble(Fila.Cells[31].Value)).ToString("N"));
                rpt.SetParameterValue("xiii", (Convert.ToDouble(Fila.Cells[35].Value) + Convert.ToDouble(Fila.Cells[36].Value)).ToString("N"));
                rpt.SetParameterValue("xiv", (Convert.ToDouble(Fila.Cells[37].Value) + Convert.ToDouble(Fila.Cells[38].Value)).ToString("N"));
                rpt.SetParameterValue("fondores", (Convert.ToDouble(Fila.Cells[39].Value) + Convert.ToDouble(Fila.Cells[40].Value)).ToString("N"));

                rpt.SetParameterValue("tingresos", Convert.ToDouble(Fila.Cells[42].Value).ToString("N"));

                rpt.SetParameterValue("desiess", Convert.ToDouble(Fila.Cells[44].Value).ToString("N"));
                rpt.SetParameterValue("desquince", Convert.ToDouble(Fila.Cells[45].Value).ToString("N"));
                rpt.SetParameterValue("desquiro", Convert.ToDouble(Fila.Cells[46].Value).ToString("N"));
                rpt.SetParameterValue("deshipo", Convert.ToDouble(Fila.Cells[47].Value).ToString("N"));
                rpt.SetParameterValue("desextsal", Convert.ToDouble(Fila.Cells[48].Value).ToString("N"));
                rpt.SetParameterValue("desantiem", Convert.ToDouble(Fila.Cells[49].Value).ToString("N"));
                rpt.SetParameterValue("descapaseg", Convert.ToDouble(Fila.Cells[50].Value).ToString("N"));
                rpt.SetParameterValue("desimprent", Convert.ToDouble(Fila.Cells[51].Value).ToString("N"));
                rpt.SetParameterValue("desprestamo", Convert.ToDouble(Fila.Cells[52].Value).ToString("N"));
                rpt.SetParameterValue("descomecsa", Convert.ToDouble(Fila.Cells[53].Value).ToString("N"));
                rpt.SetParameterValue("descomisariato", Convert.ToDouble(Fila.Cells[54].Value).ToString("N"));
                rpt.SetParameterValue("desseguridad", Convert.ToDouble(Fila.Cells[55].Value).ToString("N"));
                rpt.SetParameterValue("desalmuerzo", Convert.ToDouble(Fila.Cells[56].Value).ToString("N"));
                rpt.SetParameterValue("des10mopens", Convert.ToDouble(Fila.Cells[57].Value).ToString("N"));
                rpt.SetParameterValue("despension", Convert.ToDouble(Fila.Cells[58].Value).ToString("N"));
                rpt.SetParameterValue("desmulta", Convert.ToDouble(Fila.Cells[59].Value).ToString("N"));

                rpt.SetParameterValue("diasnolabsegpriv", Convert.ToDouble(Fila.Cells[60].Value).ToString("N"));
                var txtReportHeader = rpt.ReportDefinition.ReportObjects["Text64"] as TextObject;
                txtReportHeader.Text = Admin ? "DESC. DIF. DEC. EXT:" : "DES. DIA NO LAB:";

                rpt.SetParameterValue("descdiffdec", Convert.ToDouble(Fila.Cells[61].Value).ToString("N"));
                rpt.SetParameterValue("desodescuentos", Convert.ToDouble(Fila.Cells[62].Value).ToString("N"));
                rpt.SetParameterValue("tdescuentos", Convert.ToDouble(Fila.Cells[63].Value).ToString("N"));

                rpt.SetParameterValue("neto", Convert.ToDouble(Fila.Cells[64].Value).ToString("N"));
                rpt.SetParameterValue("banco", Fila.Cells[72].Value.ToString().Trim().Equals("0") ? "SIN BANCO - PAGADO EN CHEQUE" : Fila.Cells[73].Value + " - " + Fila.Cells[74].Value + " (" + Fila.Cells[75].Value + ")");

                if (empre == "CISEPRO C. LTDA.")
                {
                    rpt.SetParameterValue("asistente", "Jessica Mite");
                }
                else 
                {                    
                    rpt.SetParameterValue("asistente", "Priscila Avila");
                }

                

                var view = new FrmVisualizadorReportes { TipoCon = TipoCon, Titulo = "PLANILLA DE PAGO", crystalReportViewer1 = { ReportSource = rpt } };
                view.ShowDialog();
                view.Dispose();
            }
            catch (Exception)
            {
                KryptonMessageBox.Show(@"Error al generar solicitud. Por favor, contácte al administrador!",
                    "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }
    
    }
}
