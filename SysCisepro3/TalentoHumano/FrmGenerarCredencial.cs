using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.TalentoHumano;
using syscisepro.FORMULARIOS.TALENTO_HUMANO;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using SysCisepro3.Reportes;
using ClassLibraryCisepro3.UsuarioGeneral;
using System.Data.SqlClient;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.Estaticas;
using syscisepro;


namespace SysCisepro3.TalentoHumano
{
    public partial class FrmGenerarCredencial : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para visualizar documentos importantes del personal
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private int TipoCox
        {
            get
            {
                switch (TipoCon)
                {
                    case TipoConexion.Asenava:
                        return 2;
                    case TipoConexion.Seportpac:
                        return 1;
                    default:
                        return 0;
                }
            }
        }

        private static FrmGenerarCredencial _instance;
        public static FrmGenerarCredencial Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmGenerarCredencial();
                return _instance;
            }
        }

        private readonly ClassPersonal _objetoPersonal;
        private readonly ClassContratos _objContratos;
        private readonly ClassDocumentosContrato _objDocumentos;

        private readonly syscisepro.crVisitante _crVisitanteCisepro;
        private readonly syscisepro.crVisitanteSeportpac _crVisitanteSeportpac;

        private readonly syscisepro.crFarmacia _crFarmaciaCisepro;
        private readonly syscisepro.crFarmaciaSeportpac _crFarmaciaSeportpac;
        private readonly syscisepro.crComecsa _crComecsaCisepro;
        private readonly syscisepro.crComecsaSeportpac _crComecsaSeportpac;
        private readonly syscisepro.crAnticipoEmergente _crAnticipoEmergenteCisepro;
        private readonly syscisepro.crAnticipoEmergenteSeportpac _crAnticipoEmergenteSeportpac;
        private readonly syscisepro.crComisiariato _crComisariato;
        private readonly syscisepro.crComisariatoSeportpac _crComisariatoSeportpac;

        private readonly crCredencial2 _crCredencialProyecto;
        //private readonly syscisepro.crCredencial _crCredencialCisepro;
        private readonly crCredencialExport2 _crvCredencialExportCisepro;
        
        private readonly syscisepro.crCredencialSeportpac _crCredencialSeportpac;

        private readonly crCredencialSeportpac2 _crCredencialSeportpac2;
        //private readonly syscisepro.crCredencialExport _crCredencialExportCisepro;
        private readonly syscisepro.crCredencialExportSeportpac _crCredencialExportSeportpac;

        //private readonly cr
             
        private readonly List<SqlCommand> _sqlCommands;
        private readonly ClassTicketsFarmaciaComecsa _objTicketsFarmaciaComecsa;

        private FrmGenerarCredencial()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();

            _objetoPersonal = new ClassPersonal();
            _objContratos = new ClassContratos();
            _objDocumentos = new ClassDocumentosContrato();
            _objTicketsFarmaciaComecsa = new ClassTicketsFarmaciaComecsa();
            _crVisitanteCisepro = new syscisepro.crVisitante();
            _crVisitanteSeportpac = new syscisepro.crVisitanteSeportpac();

            _crFarmaciaCisepro = new syscisepro.crFarmacia();
            _crFarmaciaSeportpac = new syscisepro.crFarmaciaSeportpac();
            _crComecsaCisepro = new syscisepro.crComecsa();
            _crComecsaSeportpac = new syscisepro.crComecsaSeportpac();


            _crCredencialProyecto = new crCredencial2();
            _crvCredencialExportCisepro = new crCredencialExport2();
            _crCredencialSeportpac = new syscisepro.crCredencialSeportpac();

            //_crCredencialExportCisepro = new syscisepro.crCredencialExport();
            _crCredencialExportSeportpac = new syscisepro.crCredencialExportSeportpac();
            _crCredencialSeportpac2 = new crCredencialSeportpac2();

            _crAnticipoEmergenteCisepro = new syscisepro.crAnticipoEmergente();
            _crAnticipoEmergenteSeportpac = new syscisepro.crAnticipoEmergenteSeportpac();

            _crComisariato = new syscisepro.crComisiariato();
            _crComisariatoSeportpac = new syscisepro.crComisariatoSeportpac();
        }

        private void FrmGenerarCredencial_Load(object sender, EventArgs e)
        {
            toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            dgvBusquedaPersonal.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            DataGridView1.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);

            cREDENCIALCISSEPToolStripMenuItem.Visible = Usuario.TipoUsuario.Trim().Contains("ADMINISTRADOR");

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
            crvCredenciales.Visible = true;
            //axAcroPDF1.Visible = false;
        }

        private void txtParametroBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            //axAcroPDF1.Visible = false;
            var data = _objetoPersonal.SeleccionarTodosRegistrosPersonalFiltroMini(TipoCon, txtParametroBusqueda.Text);
            dgvBusquedaPersonal.DataSource = data;
            dgvBusquedaPersonal.Columns[0].HeaderText = @"ID";
            dgvBusquedaPersonal.Columns[0].Width = 50;
            dgvBusquedaPersonal.Columns[1].HeaderText = @"CÉDULA";
            dgvBusquedaPersonal.Columns[1].Width = 80;
            dgvBusquedaPersonal.Columns[2].HeaderText = @"NOMBRES";
            dgvBusquedaPersonal.Columns[2].Width = 240;
            dgvBusquedaPersonal.Columns[3].Visible = false;
            dgvBusquedaPersonal.Columns[4].Visible = false;
            dgvBusquedaPersonal.Columns[5].Visible = false;
            dgvBusquedaPersonal.Columns[6].Visible = false;
            dgvBusquedaPersonal.Columns[7].Visible = false;
        }

        private void dgvBusquedaPersonal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBusquedaPersonal.CurrentRow == null) return;
            txtCodigo.Text = dgvBusquedaPersonal.CurrentRow.Cells[0].Value.ToString();
            if (dgvBusquedaPersonal.CurrentRow.Cells[0].Value == null) PictureBox1.Image = Resources._default;
            try
            {
                var contrato = _objContratos.SeleccionarContratosPorIdPersonalGeneral1(TipoCon, txtCodigo.Text.Trim());
                txtContrato.Text = contrato.Rows[0][1].ToString();
                txtContrato.Tag = contrato.Rows[0][0].ToString();
                dtpFechaEmision.Value = Convert.ToDateTime(contrato.Rows[0][5]);
                PictureBox1.Image = ValidationForms.BytesToImage((byte[])dgvBusquedaPersonal.CurrentRow.Cells["FOTO"].Value);

                CargarDocumentos(txtContrato.Tag.ToString());
            }
            catch
            {
                txtContrato.Text = @"NO TIENE";
                txtContrato.Tag = null;
                PictureBox1.Image = Resources._default;
            }
        }

        private void CargarDocumentos(string idc)
        {
            try
            {
                DataGridView1.DataSource = _objDocumentos.SeleccionarDocumentoXContratoId(TipoCon, idc);
                DataGridView1.Columns[0].Width = 350;
                DataGridView1.Columns[1].Visible = false;

                foreach (DataGridViewRow row in DataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals("CV")) row.Cells[0].Value = "CURRÍCULUM VITAE";
                    if (row.Cells[0].Value.ToString().Equals("CI")) row.Cells[0].Value = "CÉDULA Y CERT. DE VOTACIÓN";
                    if (row.Cells[0].Value.ToString().Equals("CR")) row.Cells[0].Value = "REENTRENAMIENTO VIGENTE";
                    if (row.Cells[0].Value.ToString().Equals("SE")) row.Cells[0].Value = "SOLICITUD DE EMPLEO COMPLETAMENTE LLENA";
                    if (row.Cells[0].Value.ToString().Equals("TS")) row.Cells[0].Value = "TÍTULO REGISTRO SENESCYT";
                    if (row.Cells[0].Value.ToString().Equals("VS")) row.Cells[0].Value = "CERT. 120H VIGILANTE DE SEGURIDAD";
                    if (row.Cells[0].Value.ToString().Equals("ES")) row.Cells[0].Value = "EXÁMEN PSICOLÓGICO M.S.P";
                    if (row.Cells[0].Value.ToString().Equals("AM")) row.Cells[0].Value = "ACTA MATRIMONIO O UNIÓN LIBRE";
                    if (row.Cells[0].Value.ToString().Equals("PN")) row.Cells[0].Value = "PARTIDA NACIMIENTO HIJOS";
                    if (row.Cells[0].Value.ToString().Equals("AF")) row.Cells[0].Value = "AFIS (REGISTRO DE IDENTIFICACIÓN FÍSICA HUMANA)";
                    if (row.Cells[0].Value.ToString().Equals("EM")) row.Cells[0].Value = "EXÁMENES MÉDICOS SOLICITADOS POR LA CÍA.";
                    if (row.Cells[0].Value.ToString().Equals("AL")) row.Cells[0].Value = "CERT. MÉDICO APTITUD PREOCUPACIONAL";
                }
            }
            catch
            {
                DataGridView1.DataSource = null;
            }

        }

        private void pARAVISITANTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (TipoCon)
            {
                case TipoConexion.Seportpac:
                    crvCredenciales.ReportSource = _crVisitanteSeportpac;
                    break;
                case TipoConexion.Asenava:
                    crvCredenciales.ReportSource = null;
                    break;
                default:
                    crvCredenciales.ReportSource = _crVisitanteCisepro;
                    break;
            }

            crvCredenciales.Zoom(100);
            crvCredenciales.Refresh();

            crvCredenciales.Visible = true;
            axAcroPDF1.Visible = false;
        }

        private void pARAPERSONALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBusquedaPersonal.RowCount == 0 || txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"Debe seleccionar un registro para generar documentos!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                switch (TipoCon)
                {
                    case TipoConexion.Seportpac:
                        _crCredencialSeportpac2.SetDataSource(_objetoPersonal.BuscarPersonalPorIdPersonal(TipoCon, txtCodigo.Text));
                        crvCredenciales.ReportSource = _crCredencialSeportpac2;
                        break;
                    case TipoConexion.Asenava:
                        break;
                    default:
                        _crCredencialProyecto.SetDataSource(_objetoPersonal.BuscarPersonalPorIdPersonal(TipoCon, txtCodigo.Text));
                        crvCredenciales.ReportSource = _crCredencialProyecto;
                        break;
                }

                crvCredenciales.Zoom(100);
                crvCredenciales.Refresh();

                crvCredenciales.Visible = true;
                //axAcroPDF1.Visible = false;
            }
            catch
            {
                MessageBox.Show(@"Error al generar documento!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pARALICITACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBusquedaPersonal.RowCount == 0 || txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"Debe seleccionar un registro para generar documentos!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                switch (TipoCon)
                {
                    case TipoConexion.Seportpac:
                        _crCredencialExportSeportpac.SetDataSource(_objetoPersonal.BuscarPersonalPorIdPersonal(TipoCon, txtCodigo.Text));
                        crvCredenciales.ReportSource = _crCredencialExportSeportpac;
                        break;
                    case TipoConexion.Asenava:
                        break;
                    default:
                        _crvCredencialExportCisepro.SetDataSource(_objetoPersonal.BuscarPersonalPorIdPersonal(TipoCon, txtCodigo.Text));
                        crvCredenciales.ReportSource = _crvCredencialExportCisepro;
                        break;
                }

                crvCredenciales.Zoom(100);
                crvCredenciales.Refresh();

                crvCredenciales.Visible = true;
                axAcroPDF1.Visible = false;
            }
            catch
            {
                MessageBox.Show(@"Error al generar documento!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.RowCount == 0) return;
            if (DataGridView1[1, e.RowIndex].Value == DBNull.Value || DataGridView1[e.ColumnIndex, e.RowIndex].Value == null)
            {
                MessageBox.Show(@"Error al visualizar documento 'NULL'!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var bytes = (byte[])DataGridView1[1, e.RowIndex].Value;
                var tempFileName = Path.ChangeExtension(Path.GetTempFileName(), "PDF");
                File.WriteAllBytes(tempFileName, bytes);

                axAcroPDF1.LoadFile(tempFileName);
                axAcroPDF1.src = tempFileName;
                axAcroPDF1.setShowToolbar(false);
                axAcroPDF1.setZoom(75);
                axAcroPDF1.setLayoutMode("SinglePage");
                axAcroPDF1.Show();

                crvCredenciales.Visible = false;
                axAcroPDF1.Visible = true;
            }
            catch (Exception ex)
            {
                crvCredenciales.Visible = true;
                axAcroPDF1.Visible = false;
                MessageBox.Show(@"Error al visualizar documento: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmGenerarCredencial_FormClosing(object sender, FormClosingEventArgs e)
        {
            //axAcroPDF1.Dispose();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //    crvCredenciales.Visible = false;
            //    axAcroPDF1.Visible = false;
            //    webBrowser1.Visible = true;
            //    try
            //    {
            //        string url = "http://certificados.ministeriodegobierno.gob.ec/gestorcertificados/antecedentes/data.php";
            //        //byte[] byteArray = Encoding.UTF8.GetBytes("hostname=Nadav" + "&" + "ip=10.0.0.4" + "&" + "os=Windows 10 x64");

            //        //HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            //        //webRequest.Method = "POST";
            //        //webRequest.ContentType = "application/x-www-form-urlencoded";
            //        //webRequest.ContentLength = byteArray.Length;
            //        //using (Stream webpageStream = webRequest.GetRequestStream())
            //        //{
            //        //    webpageStream.Write(byteArray, 0, byteArray.Length);
            //        //}

            //        //using (var client = new WebClient())
            //        //{
            //        //    var values = new NameValueCollection();
            //        //    values["ci"] = "0705544252";
            //        //    values["tp"] = "C";
            //        //    values["ise"] = "SI";
            //        //    values["cmdid"] = "";
            //        //    var response = client.UploadValues(url, values);
            //        //    var responseString = Encoding.Default.GetString(response);
            //        //    Console.WriteLine(responseString);
            //        //}

            //        //Our postvars
            //        byte[] buffer = Encoding.UTF8.GetBytes("ci=0705544252" + "&" + "tp=C" + "&" + "ise=SI");
            //        //Initialisation, we use localhost, change if appliable
            //        HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(url);
            //        //Our method is post, otherwise the buffer (postvars) would be useless
            //        WebReq.Method = "POST";
            //        //We use form contentType, for the postvars.
            //        WebReq.ContentType = "application/x-www-form-urlencoded";
            //        //The length of the buffer (postvars) is used as contentlength.
            //        WebReq.ContentLength = buffer.Length;
            //        //We open a stream for writing the postvars
            //        Stream PostData = WebReq.GetRequestStream();
            //        //Now we write, and afterwards, we close. Closing is always important!
            //        PostData.Write(buffer, 0, buffer.Length);
            //        PostData.Close();
            //        //Get the response handle, we have no true response yet!
            //        HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();
            //        //Let's show some information about the response
            //        Console.WriteLine(WebResp.StatusCode);
            //        Console.WriteLine(WebResp.Server);

            //        //Now, we read the response (the string), and output it.
            //        Stream Answer = WebResp.GetResponseStream();
            //        StreamReader _Answer = new StreamReader(Answer);
            //        var vystup = _Answer.ReadToEnd();
            //        Console.WriteLine(vystup);

            //        //webBrowser1.Navigate("http://certificados.ministeriodegobierno.gob.ec/gestorcertificados/antecedentes/");               
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(@"Error al visualizar documento: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    } 
        }

        private void cREDENCIALCISSEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBusquedaPersonal.RowCount == 0 || txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"Debe seleccionar un registro para generar documentos!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                switch (TipoCon)
                {
                    case TipoConexion.Seportpac:
                        _crCredencialSeportpac.SetDataSource(_objetoPersonal.BuscarPersonalPorIdPersonal(TipoCon, txtCodigo.Text));
                        crvCredenciales.ReportSource = _crCredencialSeportpac;
                        
                        break;
                    case TipoConexion.Asenava:
                        break;
                    default:
                        _crCredencialProyecto.SetDataSource(_objetoPersonal.BuscarPersonalPorIdPersonal(TipoCon, txtCodigo.Text));
                        crvCredenciales.ReportSource = _crCredencialProyecto;
                        break;
                }

                crvCredenciales.Zoom(100);
                crvCredenciales.Refresh();

                crvCredenciales.Visible = true;
                axAcroPDF1.Visible = false;
            }
            catch
            {
                MessageBox.Show(@"Error al generar documento!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ticComecsa_Click(object sender, EventArgs e)
        {
            if (dgvBusquedaPersonal.RowCount == 0 || txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"Debe seleccionar un registro para generar documentos!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _sqlCommands.Clear();


            var valorD = new FrmValor();

            if (valorD.ShowDialog() != DialogResult.OK) return;



            _objTicketsFarmaciaComecsa.IdRegistro = _objTicketsFarmaciaComecsa.BuscarMayorIdTicket(TipoCon) + 1;
            _objTicketsFarmaciaComecsa.FechaRegistro = Usuario.Now(TipoCon);
            _objTicketsFarmaciaComecsa.NumDocumento = _objContratos.BuscarMayorNumTicketComecsa(TipoCon) + 1;
            _objTicketsFarmaciaComecsa.CedulaRuc = dgvBusquedaPersonal.CurrentRow.Cells[1].Value.ToString();
            _objTicketsFarmaciaComecsa.Estado = 1;
            _objTicketsFarmaciaComecsa.ApellidosNombres = dgvBusquedaPersonal.CurrentRow.Cells[2].Value.ToString();
            _objTicketsFarmaciaComecsa.Detalle = "TICKET PARA CRÉDITO EN COMECSA POR UN VALOR DE $" + valorD.Valor;
            _objTicketsFarmaciaComecsa.Tipo = 1;

            _sqlCommands.Add(_objTicketsFarmaciaComecsa.NuevoRegistroNotificacionCommands());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR TICKET");


            if ((bool)res[0])
            {
                switch (TipoCon)
                {
                    case TipoConexion.Seportpac:
                        _crComecsaSeportpac.SetParameterValue("num1", _objTicketsFarmaciaComecsa.NumDocumento);
                        _crComecsaSeportpac.SetParameterValue("nombres", _objTicketsFarmaciaComecsa.ApellidosNombres);
                        _crComecsaSeportpac.SetParameterValue("ci", _objTicketsFarmaciaComecsa.CedulaRuc);
                        _crComecsaSeportpac.SetParameterValue("valor", valorD.Valor.ToString("N"));
                        _crComecsaSeportpac.SetParameterValue("fecha", _objTicketsFarmaciaComecsa.FechaRegistro); 
                        crvCredenciales.ReportSource = _crComecsaSeportpac;
                        break;
                    case TipoConexion.Asenava:
                        crvCredenciales.ReportSource = null;
                        break;
                    default:
                        _crComecsaCisepro.SetParameterValue("num1", _objTicketsFarmaciaComecsa.NumDocumento);
                        _crComecsaCisepro.SetParameterValue("nombres", _objTicketsFarmaciaComecsa.ApellidosNombres);
                        _crComecsaCisepro.SetParameterValue("ci", _objTicketsFarmaciaComecsa.CedulaRuc);
                        _crComecsaCisepro.SetParameterValue("valor", valorD.Valor.ToString("N"));
                        _crComecsaCisepro.SetParameterValue("fecha", _objTicketsFarmaciaComecsa.FechaRegistro); 
                        crvCredenciales.ReportSource = _crComecsaCisepro;
                        break;
                }

                crvCredenciales.Zoom(100);
                crvCredenciales.Refresh();

                crvCredenciales.Visible = true;
                axAcroPDF1.Visible = false;
            }
            MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); 
          
        }

        private void ticFarmacia_Click(object sender, EventArgs e)
        {
            if (dgvBusquedaPersonal.RowCount == 0 || txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"Debe seleccionar un registro para generar documentos!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _sqlCommands.Clear();

            var valorD = new FrmValor();

            if (valorD.ShowDialog() != DialogResult.OK) return;

            _objTicketsFarmaciaComecsa.IdRegistro = _objTicketsFarmaciaComecsa.BuscarMayorIdTicket(TipoCon) + 1;
            _objTicketsFarmaciaComecsa.FechaRegistro = Usuario.Now(TipoCon);
            _objTicketsFarmaciaComecsa.NumDocumento = _objContratos.BuscarMayorNumTicketFarmacia(TipoCon) + 1;
            _objTicketsFarmaciaComecsa.CedulaRuc = dgvBusquedaPersonal.CurrentRow.Cells[1].Value.ToString();
            _objTicketsFarmaciaComecsa.Estado = 1;
            _objTicketsFarmaciaComecsa.ApellidosNombres = dgvBusquedaPersonal.CurrentRow.Cells[2].Value.ToString();
            _objTicketsFarmaciaComecsa.Detalle = "TICKET PARA FARMACIA POR UN VALOR DE $" + valorD.Valor;
            _objTicketsFarmaciaComecsa.Tipo = 0;

            _sqlCommands.Add(_objTicketsFarmaciaComecsa.NuevoRegistroNotificacionCommands());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR TICKET");


            if ((bool)res[0])
            {
                switch (TipoCon)
                {
                    case TipoConexion.Seportpac:
                        _crFarmaciaSeportpac.SetParameterValue("num1", _objTicketsFarmaciaComecsa.NumDocumento);
                        _crFarmaciaSeportpac.SetParameterValue("nombres", _objTicketsFarmaciaComecsa.ApellidosNombres);
                        _crFarmaciaSeportpac.SetParameterValue("ci", _objTicketsFarmaciaComecsa.CedulaRuc);
                        _crFarmaciaSeportpac.SetParameterValue("fecha", _objTicketsFarmaciaComecsa.FechaRegistro);
                        _crFarmaciaSeportpac.SetParameterValue("valor", valorD.Valor.ToString("N"));
                        crvCredenciales.ReportSource = _crFarmaciaSeportpac;
                        break;
                    case TipoConexion.Asenava:
                        crvCredenciales.ReportSource = null;
                        break;
                    default:
                        _crFarmaciaCisepro.SetParameterValue("num1", _objTicketsFarmaciaComecsa.NumDocumento);
                        _crFarmaciaCisepro.SetParameterValue("nombres", _objTicketsFarmaciaComecsa.ApellidosNombres);
                        _crFarmaciaCisepro.SetParameterValue("ci", _objTicketsFarmaciaComecsa.CedulaRuc);
                        _crFarmaciaCisepro.SetParameterValue("fecha", _objTicketsFarmaciaComecsa.FechaRegistro);
                        _crFarmaciaCisepro.SetParameterValue("valor", valorD.Valor.ToString("N"));
                        crvCredenciales.ReportSource = _crFarmaciaCisepro;
                        break;
                }

                crvCredenciales.Zoom(100);
                crvCredenciales.Refresh();

                crvCredenciales.Visible = true;
                axAcroPDF1.Visible = false;
            }
            MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvBusquedaPersonal.RowCount == 0 || txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"Debe seleccionar un registro para generar documentos!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _sqlCommands.Clear();


            var valorD = new FrmValor();
            if (valorD.ShowDialog() != DialogResult.OK) return;


            _objTicketsFarmaciaComecsa.IdRegistro = _objTicketsFarmaciaComecsa.BuscarMayorIdTicket(TipoCon) + 1;
            _objTicketsFarmaciaComecsa.FechaRegistro = Usuario.Now(TipoCon);
            _objTicketsFarmaciaComecsa.NumDocumento = _objContratos.BuscarMayorNumTicketComecsa(TipoCon) + 1;
            _objTicketsFarmaciaComecsa.CedulaRuc = dgvBusquedaPersonal.CurrentRow.Cells[1].Value.ToString();
            _objTicketsFarmaciaComecsa.Estado = 1;
            _objTicketsFarmaciaComecsa.ApellidosNombres = dgvBusquedaPersonal.CurrentRow.Cells[2].Value.ToString();
            _objTicketsFarmaciaComecsa.Detalle = "SOLICITUD DE ANTICIPO POR UN VALOR DE $" + valorD.Valor;
            _objTicketsFarmaciaComecsa.Tipo = 2;

            _sqlCommands.Add(_objTicketsFarmaciaComecsa.NuevoRegistroNotificacionCommands());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR TICKET");
            //string empre = Validaciones.NombreCompany(TipoCon) + " CÍA. LTDA.";
            string empre = Validaciones.NombreCompany(TipoCon); 
            if ((bool)res[0])
            {
                switch (TipoCon)
                {
                    case TipoConexion.Seportpac:
                        _crAnticipoEmergenteSeportpac.SetParameterValue("idsolicitud", _objTicketsFarmaciaComecsa.IdRegistro);
                        _crAnticipoEmergenteSeportpac.SetParameterValue("numdoc", _objTicketsFarmaciaComecsa.NumDocumento);
                        _crAnticipoEmergenteSeportpac.SetParameterValue("fecha", _objTicketsFarmaciaComecsa.FechaRegistro);
                        _crAnticipoEmergenteSeportpac.SetParameterValue("empre", empre);
                        _crAnticipoEmergenteSeportpac.SetParameterValue("nombre", _objTicketsFarmaciaComecsa.ApellidosNombres);
                        _crAnticipoEmergenteSeportpac.SetParameterValue("cedula", _objTicketsFarmaciaComecsa.CedulaRuc);
                        _crAnticipoEmergenteSeportpac.SetParameterValue("ingreso", dgvBusquedaPersonal.CurrentRow.Cells[4].Value.ToString());
                        _crAnticipoEmergenteSeportpac.SetParameterValue("cargo", dgvBusquedaPersonal.CurrentRow.Cells[5].Value.ToString());
                        _crAnticipoEmergenteSeportpac.SetParameterValue("puesto", Convert.ToInt32(dgvBusquedaPersonal.CurrentRow.Cells[6].Value) == 1 ? empre : dgvBusquedaPersonal.CurrentRow.Cells[7].Value.ToString());
                        _crAnticipoEmergenteSeportpac.SetParameterValue("valor", valorD.Valor.ToString("N"));
                        
                        crvCredenciales.ReportSource = _crAnticipoEmergenteSeportpac;
                        break;
                    case TipoConexion.Asenava:
                        crvCredenciales.ReportSource = null;
                        break;
                    default:
                        _crAnticipoEmergenteCisepro.SetParameterValue("idsolicitud", _objTicketsFarmaciaComecsa.IdRegistro);
                        _crAnticipoEmergenteCisepro.SetParameterValue("numdoc", _objTicketsFarmaciaComecsa.NumDocumento);
                        _crAnticipoEmergenteCisepro.SetParameterValue("fecha", _objTicketsFarmaciaComecsa.FechaRegistro);
                        _crAnticipoEmergenteCisepro.SetParameterValue("empre", empre);
                        _crAnticipoEmergenteCisepro.SetParameterValue("nombre", _objTicketsFarmaciaComecsa.ApellidosNombres);
                        _crAnticipoEmergenteCisepro.SetParameterValue("cedula", _objTicketsFarmaciaComecsa.CedulaRuc);
                        _crAnticipoEmergenteCisepro.SetParameterValue("ingreso", dgvBusquedaPersonal.CurrentRow.Cells[4].Value.ToString());
                        _crAnticipoEmergenteCisepro.SetParameterValue("cargo", dgvBusquedaPersonal.CurrentRow.Cells[5].Value.ToString());
                        _crAnticipoEmergenteCisepro.SetParameterValue("puesto", Convert.ToInt32(dgvBusquedaPersonal.CurrentRow.Cells[6].Value) == 1 ? empre : dgvBusquedaPersonal.CurrentRow.Cells[7].Value.ToString());
                        _crAnticipoEmergenteCisepro.SetParameterValue("valor", valorD.Valor.ToString("N"));
                        crvCredenciales.ReportSource = _crAnticipoEmergenteCisepro;
                        break;
                }

                crvCredenciales.Zoom(100);
                crvCredenciales.Refresh();

                crvCredenciales.Visible = true;
                axAcroPDF1.Visible = false;
            }
            MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void dgvBusquedaPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtParametroBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void TicComisariato_Click(object sender, EventArgs e)
        {
            if (dgvBusquedaPersonal.RowCount == 0 || txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"Debe seleccionar un registro para generar documentos!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _sqlCommands.Clear();

            var valorD = new FrmValor();

            if (valorD.ShowDialog() != DialogResult.OK) return;



            _objTicketsFarmaciaComecsa.IdRegistro = _objTicketsFarmaciaComecsa.BuscarMayorIdTicket(TipoCon) + 1;
            _objTicketsFarmaciaComecsa.FechaRegistro = Usuario.Now(TipoCon);
            _objTicketsFarmaciaComecsa.NumDocumento = _objContratos.BuscarMayorNumTicketComisariato(TipoCon) + 1;
            _objTicketsFarmaciaComecsa.CedulaRuc = dgvBusquedaPersonal.CurrentRow.Cells[1].Value.ToString();
            _objTicketsFarmaciaComecsa.Estado = 1;
            _objTicketsFarmaciaComecsa.ApellidosNombres = dgvBusquedaPersonal.CurrentRow.Cells[2].Value.ToString();
            _objTicketsFarmaciaComecsa.Detalle = "TICKET PARA COMISARIATO POR UN VALOR DE $" + valorD.Valor;
            _objTicketsFarmaciaComecsa.Tipo = 3;

            _sqlCommands.Add(_objTicketsFarmaciaComecsa.NuevoRegistroNotificacionCommands());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR TICKET");


            if ((bool)res[0])
            {
                switch (TipoCon)
                {
                    case TipoConexion.Seportpac:
                        _crComisariatoSeportpac.SetParameterValue("num1", _objTicketsFarmaciaComecsa.NumDocumento);
                        _crComisariatoSeportpac.SetParameterValue("nombres", _objTicketsFarmaciaComecsa.ApellidosNombres);
                        _crComisariatoSeportpac.SetParameterValue("ci", _objTicketsFarmaciaComecsa.CedulaRuc);
                        _crComisariatoSeportpac.SetParameterValue("fecha", _objTicketsFarmaciaComecsa.FechaRegistro);
                        _crComisariatoSeportpac.SetParameterValue("valor", valorD.Valor.ToString("N"));
                        crvCredenciales.ReportSource = _crComisariatoSeportpac;
                        break;
                    case TipoConexion.Asenava:
                        crvCredenciales.ReportSource = null;
                        break;
                    default:
                        _crComisariato.SetParameterValue("num1", _objTicketsFarmaciaComecsa.NumDocumento);
                        _crComisariato.SetParameterValue("nombres", _objTicketsFarmaciaComecsa.ApellidosNombres);
                        _crComisariato.SetParameterValue("ci", _objTicketsFarmaciaComecsa.CedulaRuc);
                        _crComisariato.SetParameterValue("fecha", _objTicketsFarmaciaComecsa.FechaRegistro);
                        _crComisariato.SetParameterValue("valor", valorD.Valor.ToString("N"));
                        crvCredenciales.ReportSource = _crComisariato;
                        break;
                }

                crvCredenciales.Zoom(100);
                crvCredenciales.Refresh();

                crvCredenciales.Visible = true;
                axAcroPDF1.Visible = false;
            }
            MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}