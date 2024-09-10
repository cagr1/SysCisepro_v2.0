using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SysCisepro3.Datos;
using SysCisepro3.Operaciones;
using SysCisepro3.Properties;
using SysCisepro3.Reportes;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.EstructuraEmpresa;
using ClassLibraryCisepro3.Operaciones;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using ClassLibraryCisepro3.ProcesosSql;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using DataTable = System.Data.DataTable;
using Font = System.Drawing.Font;
using CrystalDecisions.CrystalReports.Engine;
using SysCisepro3.Main;
using Microsoft.Office.Interop.Excel;
using Krypton.Toolkit;
using Microsoft.Office.Interop.Word;
using iText.Kernel.Geom;


namespace SysCisepro3.TalentoHumano
{
    public partial class FrmSalidaPersonal : KryptonForm
    {
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private readonly ClassPersonal _objPersonal;
        private readonly ClassSalidaPersonal _objSalidaPersonal;
        private readonly ClassRolesFirmados _objRolesFirmados;
        private readonly ClassHistorialLaboral _objHistorialLaboral;
        private readonly rptSalidaPersonal _rptSalidaPersonal;
        
        private static FrmSalidaPersonal _instance;
        public static FrmSalidaPersonal Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmSalidaPersonal();
                return _instance;
            }
        }

        private int _estado;
        public string NombreUsuario { get; set; }
        private readonly List<SqlCommand> _sqlCommands;

        private FrmSalidaPersonal()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();
            _objPersonal = new ClassPersonal();
            _objSalidaPersonal = new ClassSalidaPersonal();
            _objHistorialLaboral = new ClassHistorialLaboral();
            _rptSalidaPersonal = new rptSalidaPersonal();
            _objRolesFirmados = new ClassRolesFirmados();

        }


        private void FrmSalidaPersonal_Load(object sender, EventArgs e)
        {
            //toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;

            
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
            dgvPersonal.Font = new Font("Roboto", 8, FontStyle.Regular);
            dgvFirmado.Font = new Font("Roboto", 8, FontStyle.Regular);
            ValidationForms.SetPlaceholder(txtFiltro, "Buscar ...");
            ValidationForms.SetPlaceholder(txtBusquedaFirmado, "Buscar ...");


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            CargarPersonal(txtFiltro.Text.Trim());
        }

        private void CargarPersonal(string filtro)
        {
            try 
            {
                dgvPersonal.Columns.Clear();
                dgvPersonal.DataSource = _objSalidaPersonal.BuscarPersonalFiltro(TipoCon, filtro);
                if (dgvPersonal.RowCount == 0) return;
                     
                dgvPersonal.Columns["ID"].Width = 40;
                dgvPersonal.Columns["CEDULA"].Width = 80;
                dgvPersonal.Columns["NOMBRES"].Width = 120;
                dgvPersonal.Columns["APELLIDOS"].Width = 120;
                dgvPersonal.Columns["INGRESO"].Width = 80;
                dgvPersonal.Columns["SALIDA"].Width = 80;
                dgvPersonal.Columns["CERTIFICADO_MEDICO"].Width = 80;
                dgvPersonal.Columns["UNIFORMES"].Width = 80;
                dgvPersonal.Columns["ROLES"].Width = 80;
                dgvPersonal.Columns["CREDENCIAL"].Width = 80;
                dgvPersonal.Columns["ESTADO"].Width = 80;
                dgvPersonal.Columns["PERSONAL"].Visible = false;
                dgvPersonal.Columns["ID_SALIDA"].Visible = false;
                dgvPersonal.Columns["NOMBRE_AREA"].Visible = false;
                dgvPersonal.Columns["CARGO"].Visible = false;
                //foreach (var row in dgvPersonal.Rows.Cast<DataGridViewRow>().Where(row => Convert.ToInt32(row.Cells[11].Value) != 2))
                //    row.DefaultCellStyle.BackColor = Color.Coral;

                foreach (DataGridViewRow row in dgvPersonal.Rows)
                {
                    if (row.Cells["ESTADO"].Value != null && Convert.ToInt32(row.Cells["ESTADO"].Value) !=2 )
                    {
                          row.DefaultCellStyle.BackColor = Color.Coral;
                                         
                    }
                }


                dgvPersonal.AutoResizeRows();


            }
            catch
            {
                dgvPersonal.DataSource = null;                            
            }
        
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarPersonal(txtFiltro.Text.Trim());
        }

        private void dgvPersonal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void dgvPersonal_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void dgvPersonal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonal.CurrentRow == null) return;

            try 
            {
                var row = dgvPersonal.CurrentRow;
                txtIdPersonal.Text = row.Cells["ID"].Value.ToString();
                txtCedula.Text = row.Cells["CEDULA"].Value.ToString();
                txtNombres.Text = row.Cells["NOMBRES"].Value.ToString();
                txtApellidos.Text = row.Cells["APELLIDOS"].Value.ToString();
                dtpIngreso.Value = Convert.ToDateTime(row.Cells["INGRESO"].Value);
                dtpSalida.Value = Convert.ToDateTime(row.Cells["SALIDA"].Value);
                if (Convert.ToInt32(row.Cells["PERSONAL"].Value) == 1 )
                {
                    lblEstado.ForeColor = Color.Black;
                    lblEstado.Text = "EN FUNCIONES";
                }
                else
                {
                    lblEstado.ForeColor = Color.Black;
                    lblEstado.Text = "RETIRADO";
                }
                chkbxFichaMedica.Checked = row.Cells["CERTIFICADO_MEDICO"].Value.ToString().Equals("SI");
                chkbxUniformes.Checked = row.Cells["UNIFORMES"].Value.ToString().Equals("SI");
                chkbxRoles.Checked = row.Cells["ROLES"].Value.ToString().Equals("SI");
                chkbxCredencial.Checked = row.Cells["CREDENCIAL"].Value.ToString().Equals("SI");
                txtObservaciones.Text = row.Cells["OBSERVACIONES"].Value.ToString();

                if (chkbxFichaMedica.Checked && chkbxUniformes.Checked && chkbxRoles.Checked && chkbxCredencial.Checked && dtpSalida.Value < DateTime.Now && Convert.ToInt32(row.Cells["PERSONAL"].Value.ToString())==0)
                {
                    lblEstado.ForeColor = Color.Green;
                    lblEstado.Text = "LISTO!!";
                   
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error al cargar detalles del personal: " + ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarParametros();
            HabilitarRegistro(false);
        }

          
         private void LimpiarParametros()
        {
            
            txtIdPersonal.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCedula.Clear();
            txtFiltro.Clear();
            chkbxFichaMedica.Checked = false;
            chkbxUniformes.Checked = false;
            chkbxRoles.Checked = false;
            chkbxCredencial.Checked = false;
            txtObservaciones.Clear();
            dtpIngreso.Value = DateTime.Now;
            dtpSalida.Value = DateTime.Now;
            lblEstado.Text = string.Empty;
            dgvPersonal.DataSource = null;
             
          
        }

         private void HabilitarRegistro(bool enable)
         {

             txtObservaciones.Enabled = enable;

             if (Usuario.TipoUsuario == "RR.HH" && Usuario.Datos.Equals("VIVIANA") )
             { chkbxFichaMedica.Enabled = enable; }
             if (Usuario.TipoUsuario == "RR.HH" )
             {
                chkbxRoles.Enabled = enable;              
             }
             if (Usuario.TipoUsuario.Trim().Contains("ADMINISTRADOR") && Usuario.Datos.Equals("ERIKA GIRON CORO"))
             {
                 chkbxUniformes.Enabled = enable;
             }
             if (Usuario.TipoUsuario.Trim().Contains("ADMINISTRADOR") && Usuario.Datos.Equals("GALLARDO ROMERO CARLOS ALBERTO"))
             {
                 chkbxFichaMedica.Enabled = enable;
                 chkbxRoles.Enabled = enable;
                 chkbxUniformes.Enabled = enable;
             }
             dtpSalida.Enabled = enable;
             
         }

         private void btnModificar_Click(object sender, EventArgs e)
         {
             HabilitarRegistro(true);
             if (_objSalidaPersonal.BuscarIdSalida(TipoCon, Convert.ToInt32(txtIdPersonal.Text)) == 1)
             _estado = 2;
             else 
             _estado = 1;
         }

         private void btnGuardar_Click(object sender, EventArgs e)
         {
             if (ValidacionParametros())
             {
                 _sqlCommands.Clear();

                 var row = dgvPersonal.CurrentRow;
                 var fechaDesde = dtpSalida.Value.Day + "-" + dtpSalida.Value.Month + "-" + dtpSalida.Value.Year + " 00:00:00";
                 var fechaHasta = dtpSalida.Value.Day + "-" + dtpSalida.Value.Month + "-" + dtpSalida.Value.Year + " 23:59:59";

                 if (chkbxFichaMedica.Checked && chkbxUniformes.Checked && chkbxRoles.Checked &&
                   chkbxCredencial.Checked && dtpSalida.Value < DateTime.Now &&
                   Convert.ToInt32(row.Cells["PERSONAL"].Value.ToString()) == 0 &&
                   _objSalidaPersonal.Estado == 2)
                 {
                     try
                     {
                         _objHistorialLaboral.DeleteIdHistoriaLaboral(Convert.ToInt32(txtIdPersonal.Text.Trim()),Convert.ToDateTime(fechaDesde),Convert.ToDateTime(fechaHasta));
                         GuardarHistorial(Convert.ToInt32(txtIdPersonal.Text.Trim()));
                     }
                     catch (Exception ex)
                     {
                         Console.WriteLine("Error deleting record: " + ex.Message);
                     }

                     //_objHistorialLaboral.DeleteIdHistoriaLaboral(TipoCon, Convert.ToInt32(txtIdPersonal.Text.Trim()));
                     // GuardarHistorial(Convert.ToInt32(txtIdPersonal.Text.Trim()));
                 }
                     switch (_estado)
                 {
                     case 1:
                         GuardarNuevoRegistroSalidaPersonal();
                         break;
                     case 2:
                         GuardarRegistroModificadoSalidaPersonal();
                         break;
                  
                 }

                string user = Usuario.Datos.ToString();
                string nombreU = "";

                if (_estado == 1)
                    nombreU = $"REGISTRO SALIDA: {user}";
                else if (_estado == 2)
                    nombreU = $"MODIFICACION SALIDA: {user}";

                var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombreU);
                     if ((bool)res[0])
                     {
                         _estado = 0;
                         HabilitarRegistro(false);
                         CargarPersonal(txtFiltro.Text.Trim());
                         dgvPersonal_SelectionChanged(null, null);
                     }
                     //MessageBox.Show((string)res[1], "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KryptonMessageBox.Show((string)res[1], "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);


            }
             else 
                 
               // MessageBox.Show(@"No se puede guardar debido a que no ha llenado todos los campos necesarios!","MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KryptonMessageBox.Show(@"No se puede guardar debido a que no ha llenado todos los campos necesarios!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);


        }

         private void GuardarNuevoRegistroSalidaPersonal()
         {
             
             _objSalidaPersonal.IdSalida = _objSalidaPersonal.BuscarMayorId(TipoCon) + 1;
             _objSalidaPersonal.IdPersonal = Convert.ToInt32(txtIdPersonal.Text.Trim());
             _objSalidaPersonal.Certificado = chkbxFichaMedica.Checked ? 1 : 0;
             _objSalidaPersonal.Uniformes = chkbxUniformes.Checked ? 1 : 0;
             _objSalidaPersonal.Roles = chkbxRoles.Checked ? 1 : 0;
             _objSalidaPersonal.Credencial = chkbxCredencial.Checked ? 1 : 0;
             _objSalidaPersonal.Observaciones = txtObservaciones.Text.Trim();
             _objSalidaPersonal.FechaSalida = dtpSalida.Value;
             _sqlCommands.Add(_objSalidaPersonal.RegistrarNuevoPersonalSalida());
         }


         private void  GuardarRegistroModificadoSalidaPersonal()
         {
            
             var row = dgvPersonal.CurrentRow;
          _objSalidaPersonal.IdPersonal = Convert.ToInt32(txtIdPersonal.Text.Trim());
          _objSalidaPersonal.Certificado = chkbxFichaMedica.Checked ? 1 : 0;
          _objSalidaPersonal.Uniformes = chkbxUniformes.Checked ? 1 : 0;
          _objSalidaPersonal.Roles = chkbxRoles.Checked ? 1 : 0;
          _objSalidaPersonal.Credencial = chkbxCredencial.Checked ? 1 : 0;
          _objSalidaPersonal.Observaciones = txtObservaciones.Text.Trim();
          _objSalidaPersonal.FechaSalida = dtpSalida.Value;
          _objSalidaPersonal.Estado = (chkbxFichaMedica.Checked && chkbxUniformes.Checked && chkbxRoles.Checked && chkbxCredencial.Checked) ? 2 : 1;
          //_objSalidaPersonal.Estado = ShouldRecordHistoricalEntry() ? 2 : 1;
          _sqlCommands.Add(_objSalidaPersonal.ModificarPersonalSalida());


            

         }

         //private bool ShouldRecordHistoricalEntry()
         //{
         //    var row = dgvPersonal.CurrentRow;
         //    return chkbxFichaMedica.Checked && chkbxUniformes.Checked && chkbxRoles.Checked &&
         //           chkbxCredencial.Checked && dtpSalida.Value < DateTime.Now &&
         //           Convert.ToInt32(row.Cells["PERSONAL"].Value.ToString()) == 0 &&
         //           _objSalidaPersonal.Estado == 2;
         //}

         private bool ValidacionParametros()
         {
             return (txtCedula.Text.Trim().Length > 0 && txtNombres.Text.Trim().Length > 0 && txtApellidos.Text.Trim().Length > 0 &&
                 txtIdPersonal.Text.Trim().Length > 0 );
         }

         private void GuardarHistorial(int id)
         {
             try
             {
                
                                 
                 _objHistorialLaboral.IdHistoriaLaboral = _objHistorialLaboral.BuscarMayorIdHistoriaLaboral(TipoCon) + 1;
                 _objHistorialLaboral.FechaHistoriaLaboral = dtpSalida.Value;
                 _objHistorialLaboral.DetalleHistoriaLaboral = "COBRA LIQUIDACION EN EMPRESA CON FECHA " + dtpSalida.Value;
                 _objHistorialLaboral.EstadoHistoriaLaboral = 1;
                 _objHistorialLaboral.IdPersonalHistoriaLaboral = Convert.ToInt32(txtIdPersonal.Text.Trim());
                 _objHistorialLaboral.IdSitioHistoriaLaboral = "1";
                 _objHistorialLaboral.IdSitioAuxHistoriaLaboral = 1234567;
                 _sqlCommands.Add(_objHistorialLaboral.RegistrarNuevoHistorialLaboralCommand());
             }
             catch (Exception ex)
             {
                 MessageBox.Show(@"No se puede guardar historial debido a:" + ex.Message ,
                     "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         }

         private void btnExportar_Click(object sender, EventArgs e)
         {
             try
             {
                 if (dgvPersonal.CurrentRow == null) return;


                 var row = dgvPersonal.CurrentRow;
                
                 string empre = Validaciones.NombreCompany(TipoCon);

                 object idSolicitudValue = row.Cells["ID_SALIDA"].Value;

                 if (idSolicitudValue != null)
                 {
                     _rptSalidaPersonal.SetParameterValue("idsolicitud", idSolicitudValue);
                 }
                 else
                 {

                     _rptSalidaPersonal.SetParameterValue("idsolicitud", DBNull.Value);
                 }

                 _rptSalidaPersonal.SetParameterValue("empre", empre);
                 _rptSalidaPersonal.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, System.Windows.Forms.Application.StartupPath));
                 _rptSalidaPersonal.SetParameterValue("fecha", Convert.ToDateTime(DateTime.Now).ToShortDateString());
                 _rptSalidaPersonal.SetParameterValue("nombre", row.Cells["NOMBRES"].Value + " " + row.Cells["APELLIDOS"].Value);
                 if (Convert.ToInt32(row.Cells["ID_SALIDA"].Value) == 0 ) _rptSalidaPersonal.SetParameterValue("idsolicitud", "SIN NUM");
                 else  _rptSalidaPersonal.SetParameterValue("idsolicitud", row.Cells["ID_SALIDA"].Value);
                 _rptSalidaPersonal.SetParameterValue("cedula", row.Cells["CEDULA"].Value);
                 _rptSalidaPersonal.SetParameterValue("cargo", row.Cells["NOMBRE_AREA"].Value);
                 _rptSalidaPersonal.SetParameterValue("puesto", row.Cells["CARGO"].Value);
                 _rptSalidaPersonal.SetParameterValue("ingreso", Convert.ToDateTime(row.Cells["INGRESO"].Value));
                 if (chkbxFichaMedica.Checked)  _rptSalidaPersonal.SetParameterValue("certificado", "X");
                 else _rptSalidaPersonal.SetParameterValue("certificado", "");
                 if (chkbxUniformes.Checked) _rptSalidaPersonal.SetParameterValue("uniformes", "X");
                 else _rptSalidaPersonal.SetParameterValue("uniformes", "");
                 if (chkbxRoles.Checked) _rptSalidaPersonal.SetParameterValue("roles", "X");
                 else _rptSalidaPersonal.SetParameterValue("roles", "");
                 if (chkbxCredencial.Checked) _rptSalidaPersonal.SetParameterValue("credencial", "X");
                 else _rptSalidaPersonal.SetParameterValue("credencial", "");
                 crvSalida.ReportSource = _rptSalidaPersonal;
                 crvSalida.Zoom(2);
                 crvSalida.Refresh();

                //Nuevo Reporte con PDF

                


            }
             catch (Exception)
             {
                 MessageBox.Show(@"Error al generar solicitud. Por favor, contácte al administrador!",
                     "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
         }

        private void AutocompletarNombre()
        {
            txtNombreFirmado.AutoCompleteCustomSource = _objPersonal.AutocompletarApellidos(TipoCon, true);
            txtNombreFirmado.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombreFirmado.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnNuevoFirmado_Click(object sender, EventArgs e)
        {
            HabilitarIngresos(true);
            AutocompletarNombre();
        }

        private void HabilitarIngresos(bool valor)
        {
            txtNombreFirmado.Enabled = valor;
            dtpFechaFirmado.Enabled = valor;
            
            
        }
                     

        private void txtNombreFirmado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string fullName = txtNombreFirmado.Text.Trim();
                string[] names = fullName.Split(' ');

                string lastName = names[0] + " " + names[1];
                string firstName = names[2] + " " + names[3];



                if (names.Length == 4)
                {
                    var dt = _objPersonal.BuscarPersonalFirmado(TipoCon, lastName, firstName);
                    if (dt.Rows.Count == 0)
                    {
                        KryptonMessageBox.Show(@"No se encontró el personal firmado. Por favor, verifique los datos ingresados!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    }
                    else
                    {
                        //dgvFirmado.DataSource = _objPersonal.BuscarPersonalFirmado(TipoCon, lastName, firstName);
                        txtCedulaFirmado.Text = dt.Rows[0]["CEDULA"].ToString();
                        txtIdPersonalFirmado.Text = dt.Rows[0]["ID_PERSONAL"].ToString();
                    }
                }
            }
            
        }

        private void btnCancelarFirmado_Click(object sender, EventArgs e)
        {
            HabilitarIngresos(false);
            txtIdPersonalFirmado.Clear();
            txtNombreFirmado.Clear();
            txtCedulaFirmado.Clear();
        }

        private void btnGuardarFirmado_Click(object sender, EventArgs e)
        {
            try
            {
                _sqlCommands.Clear();
                var mes = Convert.ToInt32(dtpFechaFirmado.Value.Month);
                var anio = Convert.ToInt32(dtpFechaFirmado.Value.Year);
                var codigo = Convert.ToInt32(txtIdPersonalFirmado.Text.Trim());
                var data = _objRolesFirmados.buscarFirmaRepetida(TipoCon, codigo, mes, anio);
                if (data.Rows.Count > 0)
                {
                    KryptonMessageBox.Show(@"Ya existe un registro de personal firmado para el mes y año seleccionado!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    return;
                }

                if (txtIdPersonalFirmado.Text.Trim().Length == 0 || txtNombreFirmado.Text.Trim().Length == 0 || txtCedulaFirmado.Text.Trim().Length == 0)
                {
                KryptonMessageBox.Show(@"No se puede guardar debido a que no ha llenado todos los campos necesarios!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                
                }
               
                else
                {
                    
                    _objRolesFirmados.idrol = _objRolesFirmados.BuscarMayorId(TipoCon) + 1;
                    _objRolesFirmados.idpersonal = Convert.ToInt32(txtIdPersonalFirmado.Text.Trim());
                    _objRolesFirmados.fecha = dtpFechaFirmado.Value;
                    _objRolesFirmados.mes = dtpFechaFirmado.Value.Month;
                    _objRolesFirmados.anio = dtpFechaFirmado.Value.Year;
                    _objRolesFirmados.estado = 1;
                    _sqlCommands.Add(_objRolesFirmados.RegistrarNuevoRolFirmadoCommand());

                    string user = Usuario.Datos.ToString();
                    string nombreU = $"Registro de Personal firmado: {user} ";
                    var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombreU);
                if ((bool)res[0])
                    {
                        txtIdPersonalFirmado.Clear();
                        txtNombreFirmado.Clear();
                        txtCedulaFirmado.Clear();
                        HabilitarIngresos(false);
                    }
                    KryptonMessageBox.Show((string)res[1], "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    dgvFirmado.DataSource = null;
                }
            
            }
            catch (Exception ex)
                {
                KryptonMessageBox.Show(@"Error al guardar registro de personal firmado: " + ex.Message, "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void txtBusquedaFirmado_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgvFirmado.Columns.Clear();
                dgvFirmado.Rows.Clear();
                var data  = _objRolesFirmados.BuscarPersonalFirmadoFiltro(TipoCon, txtBusquedaFirmado.Text, Convert.ToInt32(dtpAnio.Value.Year));
                
                if (data == null || data.Rows.Count == 0)
                { 
                dgvFirmado.DataSource = null;
                    return;

                }


                foreach (DataColumn column in data.Columns)
                {
                   

                    if (column.ColumnName == "ENE" || column.ColumnName == "FEB" || column.ColumnName == "MAR" || column.ColumnName == "ABR" ||
                        column.ColumnName == "MAY" || column.ColumnName == "JUN" || column.ColumnName == "JUL" || column.ColumnName == "AGO" ||
                        column.ColumnName == "SEPT" || column.ColumnName == "OCT" || column.ColumnName == "NOV" || column.ColumnName == "DIC")
                    {
                        DataGridViewCheckBoxColumn colCheck = new DataGridViewCheckBoxColumn();
                        colCheck.Name = column.ColumnName;
                        colCheck.HeaderText = column.ColumnName;
                        colCheck.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        colCheck.Width = 50;
                        colCheck.TrueValue = 1;
                        colCheck.FalseValue = 0;
                        dgvFirmado.Columns.Add(colCheck);

                    }
                    else
                    {
                        DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                        col.Name = column.ColumnName;
                        col.HeaderText = column.ColumnName;
                        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        if (col.Name == "Apellidos" || col.Name == "Nombres")
                        {
                            col.Width = 140;
                        }
                        if (col.Name == "Fecha")
                        {
                            col.Width = 60;
                        }
                        dgvFirmado.Columns.Add(col);
                    }
                    

                    
                }


                foreach (DataRow row in data.Rows)
                {
                    int index = dgvFirmado.Rows.Add();
                    DataGridViewRow dgvRow = dgvFirmado.Rows[index];

                    // Set the checkbox cells
                    dgvRow.Cells["ENE"].Value = Convert.ToInt32(row["ENE"]) == 1;
                    dgvRow.Cells["FEB"].Value = Convert.ToInt32(row["FEB"]) == 1;
                    dgvRow.Cells["MAR"].Value = Convert.ToInt32(row["MAR"]) == 1;
                    dgvRow.Cells["ABR"].Value = Convert.ToInt32(row["ABR"]) == 1;
                    dgvRow.Cells["MAY"].Value = Convert.ToInt32(row["MAY"]) == 1;
                    dgvRow.Cells["JUN"].Value = Convert.ToInt32(row["JUN"]) == 1;
                    dgvRow.Cells["JUL"].Value = Convert.ToInt32(row["JUL"]) == 1;
                    dgvRow.Cells["AGO"].Value = Convert.ToInt32(row["AGO"]) == 1;
                    dgvRow.Cells["SEPT"].Value = Convert.ToInt32(row["SEPT"]) == 1;
                    dgvRow.Cells["OCT"].Value = Convert.ToInt32(row["OCT"]) == 1;
                    dgvRow.Cells["NOV"].Value = Convert.ToInt32(row["NOV"]) == 1;
                    dgvRow.Cells["DIC"].Value = Convert.ToInt32(row["DIC"]) == 1;

                    // Set the rest of the text cells
                    //dgvRow.Cells["Nomina"].Value = row["Nomina"].ToString();
                    dgvRow.Cells["Fecha"].Value = row["Fecha"].ToString();
                    dgvRow.Cells["Apellidos"].Value = row["Apellidos"].ToString();
                    dgvRow.Cells["Nombres"].Value = row["Nombres"].ToString();
                }





                //dgvFirmado.AutoResizeRows();
            }
            catch(Exception ex)
            {
                KryptonMessageBox.Show(@"Error al buscar personal firmado: " + ex.Message, "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                dgvFirmado.DataSource = null;
            }
        }

        private void btnExportarFirmas_Click(object sender, EventArgs e)
        {
            if (dgvFirmado.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "MENSAJE DELL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Microsoft.Office.Interop.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
                worksheet.Name = "REPORTE DE PERSONAL FIRMADO";



                var l = -1;
                for (var i = 0; i <= dgvFirmado.Columns.Count - 1; i++) if (dgvFirmado.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l); // PARA FIRMA Y HUELLA

                var rc = dgvFirmado.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A2:" + ic + "2"].Merge();
                worksheet.Range["A2:" + ic + "2"].Value = "PERÍODO: " + dtpAnio.Value.ToLongDateString();
                worksheet.Range["A2:" + ic + "2"].Font.Size = 12;

                
                var head = 5;

                var x = 1;
                for (var i = 0; i <= dgvFirmado.Columns.Count - 1; i++)
                {
                    if (!dgvFirmado.Columns[i].Visible) continue;

                    worksheet.Cells[head, x] = dgvFirmado.Columns[i].HeaderText;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (DataGridViewRow row in dgvFirmado.Rows)
                {
                    var y = 1;
                    for (var j = 0; j <= dgvFirmado.Columns.Count - 1; j++)
                    {
                        if (!dgvFirmado.Columns[j].Visible) continue;
                        var cellValue = row.Cells[j].Value;
                        if (cellValue is bool booleanValue)
                        {
                            worksheet.Cells[head, y] = booleanValue ? "X" : "";
                        }
                        else
                        {
                            worksheet.Cells[head, y] = cellValue;
                        }
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
                
                KryptonMessageBox.Show(@"REPORTE  generado correctamente!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!" + "\n" + ex.Message, @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
    }
}
