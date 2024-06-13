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
using System.Data.SqlClient;
using ClassLibraryCisepro3.Contabilidad.LibroDiario;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.ProcesosSql;
using Krypton.Toolkit;

namespace SysCisepro3.Contabilidad.Compras
{
    public partial class FrmPorcentajesRetencionIva : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para PORCENTAJES DE RETENCION IVA
        /// DEBE EXISTIR EL CODIGO, PORCENTAJE Y CUENTA A LA QUE VA DIRIGIDO
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private readonly List<SqlCommand> _sqlCommands;
        private FrmBuscarPlanCuentas _frmPlan;
        private int _estado;

        private static FrmPorcentajesRetencionIva _instance;
        public static FrmPorcentajesRetencionIva Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmPorcentajesRetencionIva();
                return _instance;
            }
        }

        private readonly ClassPorcentajesRetencion _objPorcentajesRetencion;

        private FrmPorcentajesRetencionIva()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();
            _objPorcentajesRetencion = new ClassPorcentajesRetencion();
        }

        private void FrmPorcentajesRetencionIva_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            //toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            Label1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label24.BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label1.ForeColor = Color.White;
            Label24.ForeColor = Color.White;
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
            btnModificar.Visible = Usuario.TipoUsuario.Trim().Equals("ADMINISTRADOR");
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
                var grupo = _objPorcentajesRetencion.SeleccionarRegistrosPorcentajesRetencionIvaGrupo(TipoCon, filtro);
                var datos = _objPorcentajesRetencion.SeleccionarRegistrosPorcentajesRetencionIvaDatos(TipoCon, filtro);

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
                MessageBox.Show(@"Error al cargar detalles: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private ListViewGroup GetListViewGroup(string name)
        {
            return ListView1.Groups.Cast<ListViewGroup>().FirstOrDefault(grupo => grupo.ToString().Trim().Equals(name.Trim()));
        }
        private void LimpiarNuevo()
        {
            txtCompraBienSoc.Clear();
            txtCompraBienPcon.Clear();
            txtCompraBienPsin.Clear();
            txtCompraBienExp.Clear();
            txtCompraBienEsp.Clear();
            txtVentaBienSoc.Clear();
            txtVentaBienPcon.Clear();
            txtVentaBienPsin.Clear();
            txtVentaBienExp.Clear();
            txtVentaBienEsp.Clear();

            txtCompraServiSoc.Clear();
            txtCompraServiPcon.Clear();
            txtCompraServiPsin.Clear();
            txtCompraServiExp.Clear();
            txtCompraServiEsp.Clear();
            txtVentaServiSoc.Clear();
            txtVentaServiPcon.Clear();
            txtVentaServiPsin.Clear();
            txtVentaServiExp.Clear();
            txtVentaServiEsp.Clear();

            txtBienSoc.Tag = 0;
            txtBienPcon.Tag = 0;
            txtBienPsin.Tag = 0;
            txtBienExp.Tag = 0;
            txtBienEsp.Tag = 0;

            txtServiSoc.Tag = 0;
            txtServiPcon.Tag = 0;
            txtServiPsin.Tag = 0;
            txtServiExp.Tag = 0;
            txtServiEsp.Tag = 0;

            txtBienSoc.Text = "0.00";
            txtBienPcon.Text = "0.00";
            txtBienPsin.Text = "0.00";
            txtBienExp.Text = "0.00";
            txtBienEsp.Text = "0.00";

            txtServiSoc.Text = "0.00";
            txtServiPcon.Text = "0.00";
            txtServiPsin.Text = "0.00";
            txtServiExp.Text = "0.00";
            txtServiEsp.Text = "0.00";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarNuevo();

            btnCompraBienSoc.Enabled = true;
            btnCompraBienPcon.Enabled = true;
            btnCompraBienPsin.Enabled = true;
            btnCompraBienExp.Enabled = true;
            btnCompraBienEsp.Enabled = true;

            btnVentaBienSoc.Enabled = true;
            btnVentaBienPcon.Enabled = true;
            btnVentaBienPsin.Enabled = true;
            btnVentaBienExp.Enabled = true;
            btnVentaBienEsp.Enabled = true;


            btnCompraServiSoc.Enabled = true;
            btnCompraServiPcon.Enabled = true;
            btnCompraServiPsin.Enabled = true;
            btnCompraServiExp.Enabled = true;
            btnCompraServiEsp.Enabled = true;

            btnVentaServiSoc.Enabled = true;
            btnVentaServiPcon.Enabled = true;
            btnVentaServiPsin.Enabled = true;
            btnVentaServiExp.Enabled = true;
            btnVentaServiEsp.Enabled = true;


            txtBienSoc.Enabled = true;
            txtBienPcon.Enabled = true;
            txtBienPsin.Enabled = true;
            txtBienExp.Enabled = true;
            txtBienEsp.Enabled = true;

            txtServiSoc.Enabled = true;
            txtServiPcon.Enabled = true;
            txtServiPsin.Enabled = true;
            txtServiExp.Enabled = true;
            txtServiEsp.Enabled = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;

            _estado = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBienSoc.Text.Trim()) || string.IsNullOrEmpty(txtBienPcon.Text.Trim()) ||
                string.IsNullOrEmpty(txtBienPsin.Text.Trim()) || string.IsNullOrEmpty(txtBienExp.Text.Trim()) ||
                string.IsNullOrEmpty(txtBienEsp.Text.Trim()) || string.IsNullOrEmpty(txtServiSoc.Text.Trim()) ||
                 string.IsNullOrEmpty(txtServiPcon.Text.Trim()) || string.IsNullOrEmpty(txtServiPsin.Text.Trim()) ||
                 string.IsNullOrEmpty(txtServiExp.Text.Trim()) || string.IsNullOrEmpty(txtServiEsp.Text.Trim()))
            {
                MessageBox.Show(@"Debe llenar todos los porcentajes para guardar!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtCompraBienSoc.Text.Trim()) && string.IsNullOrEmpty(txtCompraBienPcon.Text.Trim()) &&
                string.IsNullOrEmpty(txtCompraBienPsin.Text.Trim()) && string.IsNullOrEmpty(txtCompraBienExp.Text.Trim()) &&
                string.IsNullOrEmpty(txtCompraBienEsp.Text.Trim()) && string.IsNullOrEmpty(txtCompraServiSoc.Text.Trim()) &&
                 string.IsNullOrEmpty(txtCompraServiPcon.Text.Trim()) && string.IsNullOrEmpty(txtCompraServiPsin.Text.Trim()) &&
                 string.IsNullOrEmpty(txtCompraServiExp.Text.Trim()) && string.IsNullOrEmpty(txtCompraServiEsp.Text.Trim()) &&
                 string.IsNullOrEmpty(txtVentaBienSoc.Text.Trim()) && string.IsNullOrEmpty(txtVentaBienPcon.Text.Trim()) &&
                string.IsNullOrEmpty(txtVentaBienPsin.Text.Trim()) && string.IsNullOrEmpty(txtVentaBienExp.Text.Trim()) &&
                string.IsNullOrEmpty(txtVentaBienEsp.Text.Trim()) && string.IsNullOrEmpty(txtVentaServiSoc.Text.Trim()) &&
                string.IsNullOrEmpty(txtVentaServiPcon.Text.Trim()) && string.IsNullOrEmpty(txtVentaServiPsin.Text.Trim()) &&
                string.IsNullOrEmpty(txtVentaServiExp.Text.Trim()) && string.IsNullOrEmpty(txtVentaServiEsp.Text.Trim()))
            {
                MessageBox.Show(@"Debe llenar todos los datos para guardar!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(@"Desea guardar los porcentajes de retención actuales?", "MENSAJE DELL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            _sqlCommands.Clear();

            // para crear los porcentajes correspondientes a cada tipo de contribuyente según codigo renta
            var idp = _objPorcentajesRetencion.BuscarMayorIdPorcentajesRetencion(TipoCon) + 1;

            _objPorcentajesRetencion.TipoImpuestoPorcentajesRetencion = 2; // RENTA (IMPUESTO_RETENIDO)

            // sociedad
            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtBienSoc.Tag + "").Trim().Equals("0") ? idp : Convert.ToInt32(txtBienSoc.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtBienSoc.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 1;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraBienSoc.Text.Trim().Length == 0 ? string.Empty : txtCompraBienSoc.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaBienSoc.Text.Trim().Length == 0 ? string.Empty : txtVentaBienSoc.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 0; // bien
            _sqlCommands.Add((txtBienSoc.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());

            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtServiSoc.Tag + "").Trim().Equals("0") ? idp + 1 : Convert.ToInt32(txtServiSoc.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtServiSoc.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 1;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraServiSoc.Text.Trim().Length == 0 ? string.Empty : txtCompraServiSoc.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaServiSoc.Text.Trim().Length == 0 ? string.Empty : txtVentaServiSoc.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 1; // servicio
            _sqlCommands.Add((txtServiSoc.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());

             
            // persona natutral con contabilidad
            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtBienPcon.Tag + "").Trim().Equals("0") ? idp + 2 : Convert.ToInt32(txtBienPcon.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtBienPcon.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 2;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraBienPcon.Text.Trim().Length == 0 ? string.Empty : txtCompraBienPcon.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaBienPcon.Text.Trim().Length == 0 ? string.Empty : txtVentaBienPcon.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 0; // bien
            _sqlCommands.Add((txtBienPcon.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());

            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtServiPcon.Tag + "").Trim().Equals("0") ? idp + 3 : Convert.ToInt32(txtServiPcon.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtServiPcon.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 2;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraServiPcon.Text.Trim().Length == 0 ? string.Empty : txtCompraServiPcon.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaServiPcon.Text.Trim().Length == 0 ? string.Empty : txtVentaServiPcon.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 1; // servicio
            _sqlCommands.Add((txtServiPcon.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());
             

            // persona natutral sin contabilidad
            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtBienPsin.Tag + "").Trim().Equals("0") ? idp + 4 : Convert.ToInt32(txtBienPsin.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtBienPsin.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 3;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraBienPsin.Text.Trim().Length == 0 ? string.Empty : txtCompraBienPsin.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaBienPsin.Text.Trim().Length == 0 ? string.Empty : txtVentaBienPsin.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 0; // bien
            _sqlCommands.Add((txtBienPsin.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());

            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtServiPsin.Tag + "").Trim().Equals("0") ? idp + 5 : Convert.ToInt32(txtServiPsin.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtServiPsin.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 3;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraServiPsin.Text.Trim().Length == 0 ? string.Empty : txtCompraServiPsin.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaServiPsin.Text.Trim().Length == 0 ? string.Empty : txtVentaServiPsin.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 1; // servicio
            _sqlCommands.Add((txtServiPsin.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());

            
            // exportadora
            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtBienExp.Tag + "").Trim().Equals("0") ? idp + 6 : Convert.ToInt32(txtBienExp.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtBienExp.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 4;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraBienExp.Text.Trim().Length == 0 ? string.Empty : txtCompraBienExp.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaBienExp.Text.Trim().Length == 0 ? string.Empty : txtVentaBienExp.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 0; // bien
            _sqlCommands.Add((txtBienExp.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());

            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtServiExp.Tag + "").Trim().Equals("0") ? idp + 7 : Convert.ToInt32(txtServiExp.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtServiExp.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 4;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraServiExp.Text.Trim().Length == 0 ? string.Empty : txtCompraServiExp.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaServiExp.Text.Trim().Length == 0 ? string.Empty : txtVentaServiExp.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 1; // servicio
            _sqlCommands.Add((txtServiExp.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());

            
            // contribuyente especial
            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtBienEsp.Tag + "").Trim().Equals("0") ? idp + 8 : Convert.ToInt32(txtBienEsp.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtBienEsp.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 5;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraBienEsp.Text.Trim().Length == 0 ? string.Empty : txtCompraBienEsp.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaBienEsp.Text.Trim().Length == 0 ? string.Empty : txtVentaBienEsp.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 0; // bien
            _sqlCommands.Add((txtBienEsp.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());

            _objPorcentajesRetencion.IdPorcentajesRetencion = (txtServiEsp.Tag + "").Trim().Equals("0") ? idp + 9 : Convert.ToInt32(txtServiEsp.Tag.ToString().Trim());
            _objPorcentajesRetencion.CantidadPorcentajesRetencion = Convert.ToDouble(txtServiEsp.Text);
            _objPorcentajesRetencion.TipoContribuyentePorcentajesRetencion = 5;
            _objPorcentajesRetencion.CuentaCompraPorcentajesRetencion = txtCompraServiEsp.Text.Trim().Length == 0 ? string.Empty : txtCompraServiEsp.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.CuentaVentaPorcentajesRetencion = txtVentaServiEsp.Text.Trim().Length == 0 ? string.Empty : txtVentaServiEsp.Text.Trim().Split('-')[0].Trim();
            _objPorcentajesRetencion.TipoBienServicio = 1; // servicio
            _sqlCommands.Add((txtServiEsp.Tag + "").Trim().Equals("0") ? _objPorcentajesRetencion.RegistrarNuevoPorcentajeRetencionCommand() : _objPorcentajesRetencion.ActualizarNuevoPorcentajeRetencionCommand());


            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR PORCENTAJE RETENCIÓN");

            if ((bool)res[0])
            {
                btnCompraBienSoc.Enabled = false;
                btnCompraBienPcon.Enabled = false;
                btnCompraBienPsin.Enabled = false;
                btnCompraBienExp.Enabled = false;
                btnCompraBienEsp.Enabled = false;

                btnVentaBienSoc.Enabled = false;
                btnVentaBienPcon.Enabled = false;
                btnVentaBienPsin.Enabled = false;
                btnVentaBienExp.Enabled = false;
                btnVentaBienEsp.Enabled = false;

                btnCompraServiSoc.Enabled = false;
                btnCompraServiPcon.Enabled = false;
                btnCompraServiPsin.Enabled = false;
                btnCompraServiExp.Enabled = false;
                btnCompraServiEsp.Enabled = false;

                btnVentaServiSoc.Enabled = false;
                btnVentaServiPcon.Enabled = false;
                btnVentaServiPsin.Enabled = false;
                btnVentaServiExp.Enabled = false;
                btnVentaServiEsp.Enabled = false;

                txtBienSoc.Enabled = false;
                txtBienPcon.Enabled = false;
                txtBienPsin.Enabled = false;
                txtBienExp.Enabled = false;
                txtBienEsp.Enabled = false;

                txtServiSoc.Enabled = false;
                txtServiPcon.Enabled = false;
                txtServiPsin.Enabled = false;
                txtServiExp.Enabled = false;
                txtServiEsp.Enabled = false;

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;

                txtFiltro.Clear();
                _estado = 0;

                btnBuscar_Click(null, null);
            }
            MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnCompraBienSoc.Enabled = true;
            btnCompraBienPcon.Enabled = true;
            btnCompraBienPsin.Enabled = true;
            btnCompraBienExp.Enabled = true;
            btnCompraBienEsp.Enabled = true;

            btnVentaBienSoc.Enabled = true;
            btnVentaBienPcon.Enabled = true;
            btnVentaBienPsin.Enabled = true;
            btnVentaBienExp.Enabled = true;
            btnVentaBienEsp.Enabled = true;

            btnCompraServiSoc.Enabled = true;
            btnCompraServiPcon.Enabled = true;
            btnCompraServiPsin.Enabled = true;
            btnCompraServiExp.Enabled = true;
            btnCompraServiEsp.Enabled = true;

            btnVentaServiSoc.Enabled = true;
            btnVentaServiPcon.Enabled = true;
            btnVentaServiPsin.Enabled = true;
            btnVentaServiExp.Enabled = true;
            btnVentaServiEsp.Enabled = true;

            txtBienSoc.Enabled = true;
            txtBienPcon.Enabled = true;
            txtBienPsin.Enabled = true;
            txtBienExp.Enabled = true;
            txtBienEsp.Enabled = true;

            txtServiSoc.Enabled = true;
            txtServiPcon.Enabled = true;
            txtServiPsin.Enabled = true;
            txtServiExp.Enabled = true;
            txtServiEsp.Enabled = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;

            _estado = 2;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarNuevo();

            btnCompraBienSoc.Enabled = false;
            btnCompraBienPcon.Enabled = false;
            btnCompraBienPsin.Enabled = false;
            btnCompraBienExp.Enabled = false;
            btnCompraBienEsp.Enabled = false;

            btnVentaBienSoc.Enabled = false;
            btnVentaBienPcon.Enabled = false;
            btnVentaBienPsin.Enabled = false;
            btnVentaBienExp.Enabled = false;
            btnVentaBienEsp.Enabled = false;

            btnCompraServiSoc.Enabled = false;
            btnCompraServiPcon.Enabled = false;
            btnCompraServiPsin.Enabled = false;
            btnCompraServiExp.Enabled = false;
            btnCompraServiEsp.Enabled = false;

            btnVentaServiSoc.Enabled = false;
            btnVentaServiPcon.Enabled = false;
            btnVentaServiPsin.Enabled = false;
            btnVentaServiExp.Enabled = false;
            btnVentaServiEsp.Enabled = false;

            txtBienSoc.Enabled = false;
            txtBienPcon.Enabled = false;
            txtBienPsin.Enabled = false;
            txtBienExp.Enabled = false;
            txtBienEsp.Enabled = false;

            txtServiSoc.Enabled = false;
            txtServiPcon.Enabled = false;
            txtServiPsin.Enabled = false;
            txtServiExp.Enabled = false;
            txtServiEsp.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
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
                txtBienSoc.Tag = 0;
                txtBienPcon.Tag = 0;
                txtBienPsin.Tag = 0;
                txtBienExp.Tag = 0;
                txtBienEsp.Tag = 0;

                txtServiSoc.Tag = 0;
                txtServiPcon.Tag = 0;
                txtServiPsin.Tag = 0;
                txtServiExp.Tag = 0;
                txtServiEsp.Tag = 0;

                txtBienSoc.Text = "0.00";
                txtBienPcon.Text = "0.00";
                txtBienPsin.Text = "0.00";
                txtBienExp.Text = "0.00";
                txtBienEsp.Text = "0.00";

                txtServiSoc.Text = "0.00";
                txtServiPcon.Text = "0.00";
                txtServiPsin.Text = "0.00";
                txtServiExp.Text = "0.00";
                txtServiEsp.Text = "0.00";

                txtCompraBienSoc.Clear();
                txtCompraBienPcon.Clear();
                txtCompraBienPsin.Clear();
                txtCompraBienExp.Clear();
                txtCompraBienEsp.Clear();
                txtVentaBienSoc.Clear();
                txtVentaBienPcon.Clear();
                txtVentaBienPsin.Clear();
                txtVentaBienExp.Clear();
                txtVentaBienEsp.Clear();

                txtCompraServiSoc.Clear();
                txtCompraServiPcon.Clear();
                txtCompraServiPsin.Clear();
                txtCompraServiExp.Clear();
                txtCompraServiEsp.Clear();
                txtVentaServiSoc.Clear();
                txtVentaServiPcon.Clear();
                txtVentaServiPsin.Clear();
                txtVentaServiExp.Clear();
                txtVentaServiEsp.Clear();

                var ivaBien = _objPorcentajesRetencion.SeleccionarRegistrosDePorcentajesRetencionIvaBien(TipoCon);
                foreach (DataRow row in ivaBien.Rows)
                {
                    if (row[2].ToString().Equals("EXPORTADORA"))
                    {
                        txtBienExp.Tag = row[1].ToString();
                        txtBienExp.Text = row[3].ToString();
                        txtCompraBienExp.Text = row[4] + " - " + row[6];
                        txtVentaBienExp.Text = row[5] + " - " + row[7];
                    }
                    if (row[2].ToString().Equals("PERSONA NATURAL CON CONTABILIDAD"))
                    {
                        txtBienPcon.Tag = row[1].ToString();
                        txtBienPcon.Text = row[3].ToString();
                        txtCompraBienPcon.Text = row[4] + " - " + row[6];
                        txtVentaBienPcon.Text = row[5] + " - " + row[7];
                    }
                    if (row[2].ToString().Equals("PERSONA NATURAL SIN CONTABILIDAD"))
                    {
                        txtBienPsin.Tag = row[1].ToString();
                        txtBienPsin.Text = row[3].ToString();
                        txtCompraBienPsin.Text = row[4] + " - " + row[6];
                        txtVentaBienPsin.Text = row[5] + " - " + row[7];
                    }
                    if (row[2].ToString().Equals("SOCIEDAD"))
                    {
                        txtBienSoc.Tag = row[1].ToString();
                        txtBienSoc.Text = row[3].ToString();
                        txtCompraBienSoc.Text = row[4] + " - " + row[6];
                        txtVentaBienSoc.Text = row[5] + " - " + row[7];
                    }
                    if (row[2].ToString().Equals("CONTRIBUYENTE ESPECIAL"))
                    {
                        txtBienEsp.Tag = row[1].ToString();
                        txtBienEsp.Text = row[3].ToString();
                        txtCompraBienEsp.Text = row[4] + " - " + row[6];
                        txtVentaBienEsp.Text = row[5] + " - " + row[7];
                    }
                }

                var ivaServicio = _objPorcentajesRetencion.SeleccionarRegistrosDePorcentajesRetencionIvaServicio(TipoCon);
                foreach (DataRow row in ivaServicio.Rows)
                {
                    if (row[2].ToString().Equals("EXPORTADORA"))
                    {
                        txtServiExp.Tag = row[1].ToString();
                        txtServiExp.Text = row[3].ToString();
                        txtCompraServiExp.Text = row[4] + " - " + row[6];
                        txtVentaServiExp.Text = row[5] + " - " + row[7];
                    }
                    if (row[2].ToString().Equals("PERSONA NATURAL CON CONTABILIDAD"))
                    {
                        txtServiPcon.Tag = row[1].ToString();
                        txtServiPcon.Text = row[3].ToString();
                        txtCompraServiPcon.Text = row[4] + " - " + row[6];
                        txtVentaServiPcon.Text = row[5] + " - " + row[7];
                    }
                    if (row[2].ToString().Equals("PERSONA NATURAL SIN CONTABILIDAD"))
                    {
                        txtServiPsin.Tag = row[1].ToString();
                        txtServiPsin.Text = row[3].ToString();
                        txtCompraServiPsin.Text = row[4] + " - " + row[6];
                        txtVentaServiPsin.Text = row[5] + " - " + row[7];
                    }
                    if (row[2].ToString().Equals("SOCIEDAD"))
                    {
                        txtServiSoc.Tag = row[1].ToString();
                        txtServiSoc.Text = row[3].ToString();
                        txtCompraServiSoc.Text = row[4] + " - " + row[6];
                        txtVentaServiSoc.Text = row[5] + " - " + row[7];
                    }
                    if (row[2].ToString().Equals("CONTRIBUYENTE ESPECIAL"))
                    {
                        txtServiEsp.Tag = row[1].ToString();
                        txtServiEsp.Text = row[3].ToString();
                        txtCompraServiEsp.Text = row[4] + " - " + row[6];
                        txtVentaServiEsp.Text = row[5] + " - " + row[7];
                    }
                }

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = false;
            }
            catch
            {
                MessageBox.Show("ERROR AL CARGAR DATOS!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtRentaEsp_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            e.Handled = !Validaciones.IsNumeroDecimal(e.KeyChar, txt.Text);
        }

        private void btnCompraBienSoc_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070102";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraBienSoc.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraBienSoc.Clear();
            }
        }

        private void btnCompraBienPcon_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070102";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraBienPcon.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraBienPcon.Clear();
            }
        }

        private void btnCompraBienPsin_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070102";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraBienPsin.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraBienPsin.Clear();
            }
        }

        private void btnCompraBienExp_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070102";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraBienExp.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraBienExp.Clear();
            }
        }

        private void btnCompraBienEsp_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070102";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraBienEsp.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraBienEsp.Clear();
            }
        }

        private void btnCompraServiSoc_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070102";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraServiSoc.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraServiSoc.Clear();
            }
        }

        private void btnCompraServiPcon_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070102";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraServiPcon.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraServiPcon.Clear();
            }
        }

        private void btnCompraServiPsin_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070102";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraServiPsin.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraServiPsin.Clear();
            }
        }

        private void btnCompraServiExp_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070102";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraServiExp.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraServiExp.Clear();
            }
        }

        private void btnCompraServiEsp_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "201070102";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtCompraServiEsp.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtCompraServiEsp.Clear();
            }
        }

        private void btnVentaBienSoc_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "1010501";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaBienSoc.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaBienSoc.Clear();
            }
        }

        private void btnVentaBienPcon_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "1010501";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaBienPcon.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaBienPcon.Clear();
            }
        }

        private void btnVentaBienPsin_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "1010501";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaBienPsin.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaBienPsin.Clear();
            }
        }

        private void btnVentaBienExp_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "1010501";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaBienExp.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaBienExp.Clear();
            }
        }

        private void btnVentaBienEsp_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "1010501";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaBienEsp.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaBienEsp.Clear();
            }
        }

        private void btnVentaServiSoc_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "1010501";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaServiSoc.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaServiSoc.Clear();
            }
        }

        private void btnVentaServiPcon_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "1010501";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaServiPcon.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaServiPcon.Clear();
            }
        }

        private void btnVentaServiPsin_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "1010501";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaServiPsin.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaServiPsin.Clear();
            }
        }

        private void btnVentaServiExp_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "1010501";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaServiExp.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaServiExp.Clear();
            }
        }

        private void btnVentaServiEsp_Click(object sender, EventArgs e)
        {
            _frmPlan = new FrmBuscarPlanCuentas { TipoCon = TipoCon, Tipo = 2 };
            _frmPlan.txtParametrobusqueda.Text = "1010501";
            _frmPlan.cbxTipoCuenta.Enabled = false;
            _frmPlan.txtParametrobusqueda.Enabled = false;
            try
            {
                if (_frmPlan.ShowDialog() != DialogResult.OK) return;
                if (_frmPlan.listView1.SelectedItems.Count == 0) return;
                txtVentaServiEsp.Text = _frmPlan.listView1.SelectedItems[0].SubItems[1].Text.Trim() + " - " + _frmPlan.listView1.SelectedItems[0].SubItems[2].Text.Trim();
            }
            catch
            {
                txtVentaServiEsp.Clear();
            }
        }
    }
}
