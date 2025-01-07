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
using System.Data.SqlClient;
using ClassLibraryCisepro3.Contabilidad.LibroDiario;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.Estaticas;
using Krypton.Toolkit;
namespace SysCisepro3.Contabilidad.Compras
{
    public partial class FrmPorcentajesRetencion : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para PORCENTAJES DE RETENCION EN LA RENTA
        /// DEBE EXISTIR EL CODIGO, PORCENTAJE Y CUENTA A LA QUE VA DIRIGIDO
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private readonly List<SqlCommand> _sqlCommands;
        private FrmBuscarPlanCuentas _frmPlan;
        private int _estado;
        
        private static FrmPorcentajesRetencion _instance;
        public static FrmPorcentajesRetencion Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmPorcentajesRetencion();
                return _instance;
            }
        }

        private readonly ClassPorcentajesRetencion _objPorcentajesRetencion;

        private FrmPorcentajesRetencion()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();
            _objPorcentajesRetencion = new ClassPorcentajesRetencion();
        }

        private void FrmPorcentajesRetencion_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            //toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            //toolStrip1.ForeColor = Color.White;
            //Label1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            //Label24.BackColor = ValidationForms.GetColorSistema(TipoCon);
            //Label1.ForeColor = Color.White;
            //Label24.ForeColor = Color.White;
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
            btnModificar.Visible =  Usuario.TipoUsuario.Trim().Equals("ADMINISTRADOR");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            CargarPorcentajes(txtFiltro.Text.Trim(), 0);
        }

        private void CargarPorcentajes(string filtro, int selId)
        {
            try
            {
                var grupo = _objPorcentajesRetencion.SeleccionarRegistrosPorcentajesRetencionRentaGrupo(TipoCon, filtro);
                var datos = _objPorcentajesRetencion.SeleccionarRegistrosPorcentajesRetencionRentaDatos(TipoCon, filtro);

                ListView1.Items.Clear();
                ListView1.Groups.Clear();

                foreach (DataRow row in grupo.Rows) ListView1.Groups.Add(new ListViewGroup(row[0].ToString().Trim()));

                foreach (DataRow row in datos.Rows)
                {
                    var lst = new ListViewItem(row[0] != null ? row[0].ToString() : string.Empty, GetListViewGroup(row[1].ToString().Trim()));
                    for (var i = 1; i <= datos.Columns.Count - 1; i++) lst.SubItems.Add(row[i] != null ? row[i].ToString() : string.Empty);
                    ListView1.Items.Add(lst);
                }

                Label1.Text = (datos.Rows.Count + @" REGISTRO(S)");

                if (selId == 0) return;

                foreach (var row in ListView1.Items.Cast<ListViewItem>().Where(row => row.SubItems[0].Text.Trim().Equals(selId.ToString().Trim())))
                {
                    row.EnsureVisible();
                    ListView1.Items[row.Index].Selected = true;
                    ListView1.Select();
                    break;
                }

                btnModificar.Enabled = ListView1.Items.Count > 0 && ListView1.SelectedItems.Count > 0;
            }
            catch (Exception ex)
            {
                ListView1.Items.Clear();
                //MessageBox.Show(@"Error al cargar detalles: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KryptonMessageBox.Show(@"Error al cargar detalles: " + ex.Message, @"Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private ListViewGroup GetListViewGroup(string name)
        {
            return ListView1.Groups.Cast<ListViewGroup>().FirstOrDefault(grupo => grupo.ToString().Trim().Equals(name.Trim()));
        }

        private void LimpiarNuevo()
        {
            txtIdConcepto.Clear();
            txtCodigo.Clear();
            txtConcepto.Clear();

            txtCompraRentaSoc.Clear();
            txtCompraRentaPcon.Clear();
            txtCompraRentaPsin.Clear();
            txtCompraRentaExp.Clear();
            txtCompraRentaEsp.Clear();
            txtVentaRentaSoc.Clear();
            txtVentaRentaPcon.Clear();
            txtVentaRentaPsin.Clear();
            txtVentaRentaExp.Clear();
            txtVentaRentaEsp.Clear();

            txtRentaSoc.Tag = 0;
            txtRentaPcon.Tag = 0;
            txtRentaPsin.Tag = 0;
            txtRentaExp.Tag = 0;
            txtRentaEsp.Tag = 0;
            txtRentaSoc.Text = "0.00";
            txtRentaPcon.Text = "0.00";
            txtRentaPsin.Text = "0.00";
            txtRentaExp.Text = "0.00";
            txtRentaEsp.Text = "0.00";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarNuevo();

            txtCodigo.Enabled = true;
            txtConcepto.Enabled = true;
            
            btnCompraRentaSoc.Enabled = true;
            btnCompraRentaPcon.Enabled = true;
            btnCompraRentaPsin.Enabled = true;
            btnCompraRentaExp.Enabled = true;
            btnCompraRentaEsp.Enabled = true;

            btnVentaRentaSoc.Enabled = true;
            btnVentaRentaPcon.Enabled = true;
            btnVentaRentaPsin.Enabled = true;
            btnVentaRentaExp.Enabled = true;
            btnVentaRentaEsp.Enabled = true;
            
            txtRentaSoc.Enabled = true;
            txtRentaPcon.Enabled = true;
            txtRentaPsin.Enabled = true;
            txtRentaExp.Enabled = true;
            txtRentaEsp.Enabled = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnAnular.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;

            _estado = 1;
            txtCodigo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) || string.IsNullOrEmpty(txtConcepto.Text.Trim()))
            {
               //MessageBox.Show(@"Debe llenar código y concepto para guardar!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                KryptonMessageBox.Show(@"Debe llenar código y concepto para guardar!", @"Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtRentaSoc.Text.Trim()) || string.IsNullOrEmpty(txtRentaPcon.Text.Trim()) || string.IsNullOrEmpty(txtRentaPsin.Text.Trim()) || string.IsNullOrEmpty(txtRentaExp.Text.Trim()) || string.IsNullOrEmpty(txtRentaEsp.Text.Trim()))
            {
                //MessageBox.Show(@"Debe llenar todos los porcentajes para guardar!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                KryptonMessageBox.Show(@"Debe llenar todos los porcentajes para guardar!", @"Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtCompraRentaSoc.Text.Trim()) && string.IsNullOrEmpty(txtCompraRentaPcon.Text.Trim()) &&
                string.IsNullOrEmpty(txtCompraRentaPsin.Text.Trim()) && string.IsNullOrEmpty(txtCompraRentaExp.Text.Trim()) &&
                string.IsNullOrEmpty(txtCompraRentaEsp.Text.Trim()) && string.IsNullOrEmpty(txtVentaRentaSoc.Text.Trim()) &&
                string.IsNullOrEmpty(txtVentaRentaPcon.Text.Trim()) && string.IsNullOrEmpty(txtVentaRentaPsin.Text.Trim()) &&
                string.IsNullOrEmpty(txtVentaRentaExp.Text.Trim()) && string.IsNullOrEmpty(txtVentaRentaEsp.Text.Trim()))
            {
                //MessageBox.Show(@"Debe llenar todos los datos para guardar!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                KryptonMessageBox.Show(@"Debe llenar todos los datos para guardar!", @"Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            var data = _estado == 1 ? _objPorcentajesRetencion.SeleccionarConceptoPagoPorCod(TipoCon, txtCodigo.Text) : 
                _objPorcentajesRetencion.SeleccionarConceptoPagoPorIdCod(TipoCon, txtIdConcepto.Text.Trim(), txtCodigo.Text);

            if (data.Rows.Count > 0)
            {
                if (data.Rows[0][4].ToString().Trim().Equals("1"))
                {
                    //MessageBox.Show(@"El código que intenta registrar ya existe! " + @"(" + data.Rows[0][2] + @")", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    KryptonMessageBox.Show(@"El código que intenta registrar ya existe! " + @"(" + data.Rows[0][2] + @")", @"Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
                    return;
                }
            }

            //if (MessageBox.Show(@"Desea guardar el código de retención actual?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (KryptonMessageBox.Show(@"Desea guardar el código de retención actual?", @"Mensaje del sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes) return;

            _sqlCommands.Clear();

            // guardar codigo retencion renta
            _objPorcentajesRetencion.IdConceptoPago = _estado == 1 ? _objPorcentajesRetencion.BuscarMayorIdConceptoPago(TipoCon) + 1: Convert.ToInt32(txtIdConcepto.Text.Trim());
            _objPorcentajesRetencion.CodigoPorcentajesRetencion = txtCodigo.Text.Trim();
            _objPorcentajesRetencion.ConceptoPorcentajesRetencion = txtCodigo.Text.Trim() + " - " + txtConcepto.Text.Trim();
            _objPorcentajesRetencion.AnioPorcentajesRetencion = DateTime.Now.Year;
            _objPorcentajesRetencion.EstadoPorcentajesRetencion = 1;
            _sqlCommands.Add(_estado == 1 ? _objPorcentajesRetencion.RegistrarNuevoCodigoConceptoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ModificarCodigoConceptoPorcentajeRetencionCommand());

            // para crear los porcentajes correspondientes a cada tipo de contribuyente según codigo renta
            var idp = _objPorcentajesRetencion.BuscarMayorIdPorcentajesRetencion(TipoCon) + 1;

            _objPorcentajesRetencion.TipoImpuestoPorcentajesRetencion = 1; // RENTA (IMPUESTO_RETENIDO)

            // sociedad
            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtRentaSoc.Tag + "").Trim().Equals("0") ? idp : Convert.ToInt32(txtRentaSoc.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtRentaSoc.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 1;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraRentaSoc.Text.Trim().Length == 0 ? string.Empty : txtCompraRentaSoc.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaRentaSoc.Text.Trim().Length == 0 ? string.Empty : txtVentaRentaSoc.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 1;
            _sqlCommands.Add((txtRentaSoc.Tag + "").Trim().Equals("0")?_objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand():_objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());


            // persona natutral con contabilidad
            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtRentaPcon.Tag + "").Trim().Equals("0") ? idp + 1 : Convert.ToInt32(txtRentaPcon.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtRentaPcon.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 2;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraRentaPcon.Text.Trim().Length == 0 ? string.Empty : txtCompraRentaPcon.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaRentaPcon.Text.Trim().Length == 0 ? string.Empty : txtVentaRentaPcon.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 1;
            _sqlCommands.Add((txtRentaPcon.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());


            // persona natutral sin contabilidad
            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtRentaPsin.Tag + "").Trim().Equals("0") ? idp + 2 : Convert.ToInt32(txtRentaPsin.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtRentaPsin.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 3;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraRentaPsin.Text.Trim().Length == 0 ? string.Empty : txtCompraRentaPsin.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaRentaPsin.Text.Trim().Length == 0 ? string.Empty : txtVentaRentaPsin.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 1;
            _sqlCommands.Add((txtRentaPsin.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());


            // exportadora
            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtRentaExp.Tag + "").Trim().Equals("0") ? idp + 3 : Convert.ToInt32(txtRentaExp.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtRentaExp.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 4;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraRentaExp.Text.Trim().Length == 0 ? string.Empty : txtCompraRentaExp.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaRentaExp.Text.Trim().Length == 0 ? string.Empty : txtVentaRentaExp.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 1;
            _sqlCommands.Add((txtRentaExp.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());


            // contribuyente especial
            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtRentaEsp.Tag + "").Trim().Equals("0") ? idp + 4 : Convert.ToInt32(txtRentaEsp.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtRentaEsp.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 5;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraRentaEsp.Text.Trim().Length == 0 ? string.Empty : txtCompraRentaEsp.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaRentaEsp.Text.Trim().Length == 0 ? string.Empty : txtVentaRentaEsp.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 1;
            _sqlCommands.Add((txtRentaEsp.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());

            string user = Usuario.Datos.ToString();
            string nombreU = "Nuevo Porcentaje retencion por: " + user;
            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombreU);

            if ((bool)res[0])
            {
                txtCodigo.Enabled = false;
                txtConcepto.Enabled = false;

                btnCompraRentaSoc.Enabled = false;
                btnCompraRentaPcon.Enabled = false;
                btnCompraRentaPsin.Enabled = false;
                btnCompraRentaExp.Enabled = false;
                btnCompraRentaEsp.Enabled = false;

                btnVentaRentaSoc.Enabled = false;
                btnVentaRentaPcon.Enabled = false;
                btnVentaRentaPsin.Enabled = false;
                btnVentaRentaExp.Enabled = false;
                btnVentaRentaEsp.Enabled = false;
                
                txtRentaSoc.Enabled = false;
                txtRentaPcon.Enabled = false;
                txtRentaPsin.Enabled = false;
                txtRentaExp.Enabled = false;
                txtRentaEsp.Enabled = false;

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = true;
                btnCancelar.Enabled = false; 

                txtFiltro.Clear();
                _estado = 0;

                btnBuscar_Click(null, null);
                KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            else
            {
                KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            //KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

            //MessageBox.Show((string)res[1], "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtConcepto.Enabled = true;

            btnCompraRentaSoc.Enabled = true;
            btnCompraRentaPcon.Enabled = true;
            btnCompraRentaPsin.Enabled = true;
            btnCompraRentaExp.Enabled = true;
            btnCompraRentaEsp.Enabled = true;

            btnVentaRentaSoc.Enabled = true;
            btnVentaRentaPcon.Enabled = true;
            btnVentaRentaPsin.Enabled = true;
            btnVentaRentaExp.Enabled = true;
            btnVentaRentaEsp.Enabled = true;

            txtRentaSoc.Enabled = true;
            txtRentaPcon.Enabled = true;
            txtRentaPsin.Enabled = true;
            txtRentaExp.Enabled = true;
            txtRentaEsp.Enabled = true;
            
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnAnular.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;

            _estado = 2;
            txtCodigo.Focus();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (ListView1.Items.Count == 0) return;
            if (ListView1.SelectedItems.Count == 0) return;

            //if (MessageBox.Show(@"Desea quitar el porcentaje de retención: " + txtCodigo.Text.Trim() + " - " + txtConcepto.Text.Trim() + "?",
            //       "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
            //   DialogResult.Yes) return;

            if (KryptonMessageBox.Show(@"Desea quitar el porcentaje de retención: " + txtCodigo.Text.Trim() + " - " + txtConcepto.Text.Trim() + "?",
                                  "Mensaje del sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
                                                DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objPorcentajesRetencion.IdConceptoPago = Convert.ToInt32(txtIdConcepto.Text.Trim());

            _sqlCommands.Add(_objPorcentajesRetencion.AnularCodigoConceptoPorcentajeRetencionCommand());

            _sqlCommands.Add(_objPorcentajesRetencion.EliminarPorcentajeRetencionCommand());

            string user = Usuario.Datos.ToString();
            string nombreU = "Anulacion Porcentaje retencion por: " + user;
            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombreU);

            if ((bool)res[0])
            {
                LimpiarNuevo();

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;
                
                _estado = 0;

                txtFiltro.Clear();
                btnBuscar_Click(null, null);
                KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            else
            {
                KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }
            //MessageBox.Show((string)res[1], "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarNuevo();

            txtCodigo.Enabled = false;
            txtConcepto.Enabled = false;

            btnCompraRentaSoc.Enabled = false;
            btnCompraRentaPcon.Enabled = false;
            btnCompraRentaPsin.Enabled = false;
            btnCompraRentaExp.Enabled = false;
            btnCompraRentaEsp.Enabled = false;

            btnVentaRentaSoc.Enabled = false;
            btnVentaRentaPcon.Enabled = false;
            btnVentaRentaPsin.Enabled = false;
            btnVentaRentaExp.Enabled = false;
            btnVentaRentaEsp.Enabled = false;

            txtRentaSoc.Enabled = false;
            txtRentaPcon.Enabled = false;
            txtRentaPsin.Enabled = false;
            txtRentaExp.Enabled = false;
            txtRentaEsp.Enabled = false;
             
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;

            _estado = 0;
            btnBuscar_Click(null, null);
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            CargarPorcentajes(txtFiltro.Text.Trim(), 0);
        }
         
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_estado != 0) return;
            if (ListView1.Items.Count == 0) return;
            if (ListView1.SelectedItems.Count == 0) return;

            try
            {
                txtIdConcepto.Text = ListView1.SelectedItems[0].SubItems[5].Text;

                var cc = ListView1.SelectedItems[0].SubItems[1].Text.Trim().Split('-');
                txtCodigo.Text = cc[0].Trim();      // COD
                txtConcepto.Text = cc[1].Trim();    // CONCEPTO

                txtRentaSoc.Tag = 0;
                txtRentaPcon.Tag = 0;
                txtRentaPsin.Tag = 0;
                txtRentaExp.Tag = 0;
                txtRentaEsp.Tag = 0;

                txtRentaSoc.Text = "0.00";
                txtRentaPcon.Text = "0.00";
                txtRentaPsin.Text = "0.00";
                txtRentaExp.Text = "0.00";
                txtRentaEsp.Text = "0.00";
                
                txtCompraRentaSoc.Clear();
                txtCompraRentaPcon.Clear();
                txtCompraRentaPsin.Clear();
                txtCompraRentaExp.Clear();
                txtCompraRentaEsp.Clear();
                txtVentaRentaSoc.Clear();
                txtVentaRentaPcon.Clear();
                txtVentaRentaPsin.Clear();
                txtVentaRentaExp.Clear();
                txtVentaRentaEsp.Clear();
                                 
                var codrenta = _objPorcentajesRetencion.SeleccionarRegistrosDePorcentajesRetencionRenta(TipoCon, txtCodigo.Text.Trim());

                foreach (DataRow row in codrenta.Rows)
                {
                    if (row[2].ToString().Equals("EXPORTADORA"))
                    {
                        txtRentaExp.Tag = row[1].ToString();
                        txtRentaExp.Text = row[3].ToString();
                        txtCompraRentaExp.Text = row[4] + " - " + row[6];
                        txtVentaRentaExp.Text = row[5] + " - " + row[7];
                    }
                    if (row[2].ToString().Equals("PERSONA NATURAL CON CONTABILIDAD"))
                    {
                        txtRentaPcon.Tag = row[1].ToString();
                        txtRentaPcon.Text = row[3].ToString();
                        txtCompraRentaPcon.Text = row[4] + " - " + row[6];
                        txtVentaRentaPcon.Text = row[5] + " - " + row[7];
                    }
                    if (row[2].ToString().Equals("PERSONA NATURAL SIN CONTABILIDAD"))
                    {
                        txtRentaPsin.Tag = row[1].ToString();
                        txtRentaPsin.Text = row[3].ToString();
                        txtCompraRentaPsin.Text = row[4] + " - " + row[6];
                        txtVentaRentaPsin.Text = row[5] + " - " + row[7];
                    }
                    if (row[2].ToString().Equals("SOCIEDAD"))
                    {
                        txtRentaSoc.Tag = row[1].ToString();
                        txtRentaSoc.Text = row[3].ToString();
                        txtCompraRentaSoc.Text = row[4] + " - " + row[6];
                        txtVentaRentaSoc.Text = row[5] + " - " + row[7];
                    }
                    if (row[2].ToString().Equals("CONTRIBUYENTE ESPECIAL"))
                    {
                        txtRentaEsp.Tag = row[1].ToString();
                        txtRentaEsp.Text = row[3].ToString();
                        txtCompraRentaEsp.Text = row[4] + " - " + row[6];
                        txtVentaRentaEsp.Text = row[5] + " - " + row[7];
                    }
                }

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = true;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERROR AL CARGAR DATOS!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                KryptonMessageBox.Show("Error al cargar datos! " + ex.Message.ToString() , "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
                return;
            }
        }
         
        private void btnCompraRentaSoc_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070101";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraRentaSoc.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraRentaSoc.Clear();
            }
        }

        private void btnCompraRentaPcon_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070101";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraRentaPcon.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraRentaPcon.Clear();
            }
        }

        private void btnCompraRentaPsin_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070101";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraRentaPsin.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraRentaPsin.Clear();
            }
        }

        private void btnCompraRentaExp_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070101";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraRentaExp.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraRentaExp.Clear();
            }
        }

        private void btnCompraRentaEsp_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070101";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraRentaEsp.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraRentaEsp.Clear();
            }
        }

        private void btnVentaRentaSoc_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 1 };
            _frmPlan.txtParametrobusqueda.Text = "1010502";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaRentaSoc.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaRentaSoc.Clear();
            }
        }

        private void btnVentaRentaPcon_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 1 };
            _frmPlan.txtParametrobusqueda.Text = "1010502";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaRentaPcon.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaRentaPcon.Clear();
            }
        }

        private void btnVentaRentaPsin_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 1 };
            _frmPlan.txtParametrobusqueda.Text = "1010502";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaRentaPsin.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaRentaPsin.Clear();
            }
        }

        private void btnVentaRentaExp_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 1 };
            _frmPlan.txtParametrobusqueda.Text = "1010502";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaRentaExp.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaRentaExp.Clear();
            }
        }

        private void btnVentaRentaEsp_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 1 };
            _frmPlan.txtParametrobusqueda.Text = "1010502";           
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaRentaEsp.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaRentaEsp.Clear();
            }
        }

        private void txtRentaEsp_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            e.Handled = !Validaciones.IsNumeroDecimal(e.KeyChar, txt.Text);
        }
    }
}



