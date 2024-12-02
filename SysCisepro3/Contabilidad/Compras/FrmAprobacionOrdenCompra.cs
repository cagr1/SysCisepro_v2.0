using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryCisepro3.Contabilidad.Compras.OrdenDeCompra;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using Krypton.Toolkit;

namespace SysCisepro3.Contabilidad.Compras
{
    /// <summary>
    /// CISEPRO 2019
    /// Para aprobar ORDENES DE COMPRA
    /// </summary>
    public partial class FrmAprobacionOrdenCompra : KryptonForm
    {
        public static TipoConexion TipoCon { private get; set; }

        public static ClassUsuarioGeneral Usuario { get; set; }

        private static FrmAprobacionOrdenCompra _instance;
        public static FrmAprobacionOrdenCompra Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmAprobacionOrdenCompra();
                return _instance;
            }
        }

        private readonly ClassOrdenCompra _objOrdenCompra;
        private readonly ClassDetalleOrdenCompra _objDetalleOrdenCompra;

        private readonly List<SqlCommand> _sqlCommands;

        private FrmAprobacionOrdenCompra()
        {
            InitializeComponent();

            _sqlCommands = new List<SqlCommand>();
            _objOrdenCompra = new ClassOrdenCompra();
            _objDetalleOrdenCompra = new ClassDetalleOrdenCompra();
        }

        private void FrmAprobacionOrdenCompra_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 

            //toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            dgvOrdenCompra.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            dgvDetalleOrdenCompra.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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
            dgvOrdenCompra.Font = new Font("Roboto", 9, FontStyle.Regular);
            dgvDetalleOrdenCompra.Font = new Font("Roboto", 9, FontStyle.Regular);
        }

        private void LimpiarParametros()
        {
            txtIdOrdenCompra.Clear();
            txtFechaOrdenCompra.Clear();
            txtRucProveedor.Clear();
            txtRucProveedor.Clear();
            txtTipoPagoOrdenCompra.Clear();
            txtFormaPagoOrdenCompra.Clear();
            txtSubtotal0OrdenCompra.Clear();
            txtSubtotal12OrdenCompra.Clear();
            txtDescuentoOrdenCompra.Clear();
            txtIvaOrdenCompra.Clear();
            txtTotalOrdenCompra.Clear();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            LimpiarParametros();
            CargarOrdenesCompra();
            btnAprobarLiquidacion.Enabled = dgvOrdenCompra.Rows.Count > 0 && dgvDetalleOrdenCompra.RowCount > 0;
            toolStripButton1.Enabled = dgvOrdenCompra.Rows.Count > 0 && dgvDetalleOrdenCompra.RowCount > 0;
        }

        private void CargarOrdenesCompra()
        {
            try
            {
                var data = _objOrdenCompra.SeleccionarRegistrosOrdenCompra(TipoCon);
                if (data == null || data.Rows.Count == 0)
                {
                    dgvOrdenCompra.DataSource = null;
                    return;
                }

                dgvOrdenCompra.DataSource = data;

                dgvOrdenCompra.Columns[0].HeaderText = @"ID";
                //dgvOrdenCompra.Columns[0].Width = 50;
                dgvOrdenCompra.Columns[1].HeaderText = @"FECHA";
                //dgvOrdenCompra.Columns[1].Width = 150;
                dgvOrdenCompra.Columns[2].HeaderText = @"RUC";
                //dgvOrdenCompra.Columns[2].Width = 100;
                dgvOrdenCompra.Columns[3].HeaderText = @"NOMBRE COMERCIAL";
                //dgvOrdenCompra.Columns[3].Width = 200;
                dgvOrdenCompra.Columns[4].HeaderText = @"DIRECCIÓN";
                //dgvOrdenCompra.Columns[4].Width = 200;
                dgvOrdenCompra.Columns[5].HeaderText = @"CIUDAD";
                //dgvOrdenCompra.Columns[5].Width = 120;
                dgvOrdenCompra.Columns[6].HeaderText = @"FORMA PAGO";
                //dgvOrdenCompra.Columns[6].Width = 80;
                dgvOrdenCompra.Columns[7].HeaderText = @"TIPO PAGO";
                //dgvOrdenCompra.Columns[7].Width = 80;
                dgvOrdenCompra.Columns[8].HeaderText = @"OBSERVACIONES";
                //dgvOrdenCompra.Columns[8].Width = 300;
                dgvOrdenCompra.Columns[9].HeaderText = @"SUBTOTAL 12";
                //dgvOrdenCompra.Columns[9].Width = 80;
                dgvOrdenCompra.Columns[10].HeaderText = @"SUBTOTAL 0";
                //dgvOrdenCompra.Columns[10].Width = 80;
                dgvOrdenCompra.Columns[11].HeaderText = @"DESCUENTO";
                //dgvOrdenCompra.Columns[11].Width = 80;
                dgvOrdenCompra.Columns[12].HeaderText = @"IVA (12%)";
                //dgvOrdenCompra.Columns[12].Width = 80;
                dgvOrdenCompra.Columns[13].HeaderText = @"TOTAL";
                //dgvOrdenCompra.Columns[13].Width = 80;
                dgvOrdenCompra.Columns[14].Visible = false;
                dgvOrdenCompra.AutoResizeColumns();
                dgvOrdenCompra.AutoResizeRows();
            }
            catch (Exception ex)
            {
                dgvOrdenCompra.DataSource = null;
                dgvDetalleOrdenCompra.DataSource = null;
                MessageBox.Show(@"Error al cargar órdenes de compra: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvOrdenCompra_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrdenCompra.RowCount == 0 || dgvOrdenCompra.CurrentRow == null) return;

            txtIdOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells[0].Value.ToString();
            txtFechaOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells[1].Value.ToString();
            txtRucProveedor.Text = dgvOrdenCompra.CurrentRow.Cells[2].Value.ToString();
            txtNombreProveedor.Text = dgvOrdenCompra.CurrentRow.Cells[3].Value.ToString();
            txtFormaPagoOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells[6].Value.ToString();
            txtTipoPagoOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells[7].Value.ToString();
            txtSubtotal12OrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells[9].Value.ToString();
            txtSubtotal0OrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells[10].Value.ToString();
            txtDescuentoOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells[11].Value.ToString();
            txtIvaOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells[12].Value.ToString();
            txtTotalOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells[13].Value.ToString();

            CargarDetallesCompra(Convert.ToInt32(txtIdOrdenCompra.Text));
        }
        private void CargarDetallesCompra(int idcom)
        {
            try
            {
                // CARGA SOLICITUDES FONDO ROTATIVO x ID LIQUIDACION SEGUN SISTEMA
                var data = _objDetalleOrdenCompra.SeleccionarDetalleOrdenCompraXIdOrdenCompra(TipoCon, idcom);
                if (data == null || data.Rows.Count == 0)
                {
                    dgvDetalleOrdenCompra.DataSource = null;
                    return;
                }

                dgvDetalleOrdenCompra.DataSource = data;

                dgvDetalleOrdenCompra.Columns[0].HeaderText = @"ID";
                //dgvDetalleOrdenCompra.Columns[0].Width = 40;
                dgvDetalleOrdenCompra.Columns[1].HeaderText = @"ITEM";
                //dgvDetalleOrdenCompra.Columns[1].Width = 665;
                dgvDetalleOrdenCompra.Columns[2].HeaderText = @"UM";
                //dgvDetalleOrdenCompra.Columns[2].Width = 60;
                dgvDetalleOrdenCompra.Columns[3].HeaderText = @"CANT";
                //dgvDetalleOrdenCompra.Columns[3].Width = 60;
                dgvDetalleOrdenCompra.Columns[4].HeaderText = @"V. UNITARIO";
                //dgvDetalleOrdenCompra.Columns[4].Width = 80;
                dgvDetalleOrdenCompra.Columns[5].HeaderText = @"V. TOTAL";
                //dgvDetalleOrdenCompra.Columns[5].Width = 80;

                dgvDetalleOrdenCompra.Columns[6].Visible = false;
                dgvDetalleOrdenCompra.Columns[7].Visible = false;

                dgvDetalleOrdenCompra.AutoResizeColumns();
                dgvDetalleOrdenCompra.AutoResizeRows();
            }
            catch (Exception ex)
            {
                dgvDetalleOrdenCompra.DataSource = null;
                MessageBox.Show(@"Error al cargar detalles de la compra: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvOrdenCompra_Sorted(object sender, EventArgs e)
        {
            dgvOrdenCompra.AutoResizeRows();
        }

        private void dgvDetalleOrdenCompra_Sorted(object sender, EventArgs e)
        {
            dgvDetalleOrdenCompra.AutoResizeRows();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvOrdenCompra.Rows.Count == 0)
            {
                MessageBox.Show(@"No se ha seleccionado una órden de compra pendiente!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvDetalleOrdenCompra.RowCount == 0)
            {
                MessageBox.Show(@"No se han cargado los detalles de la órden de compra, no se puede finalizar la revisión!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(
                    @"Está seguro que desea rechazar la órden de compra? Una vez aprobado no se puede realizar cambios",
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objOrdenCompra.IdOrdenCompraGeneral = Convert.ToInt64(txtIdOrdenCompra.Text);
            _objOrdenCompra.EstadoOrdencompraGeneral = 0;
            _sqlCommands.Add(_objOrdenCompra.ActualizarEstadoOrdenCompra());

            var user = Usuario.Datos.ToString();
            var nombre = $"Orden de Compra rechazada por: {user}";
            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombre);

            if ((bool)res[0]) btnRecargar.PerformClick();
            MessageBox.Show((string)res[1], "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAprobarLiquidacion_Click(object sender, EventArgs e)
        {
            if (dgvOrdenCompra.Rows.Count == 0)
            {
                MessageBox.Show(@"No se ha seleccionado una órden de compra pendiente!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvDetalleOrdenCompra.RowCount == 0)
            {
                MessageBox.Show(@"No se han cargado los detalles de la órden de compra, no se puede finalizar la revisión!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(
                    @"Está seguro que desea aprobar la órden de compra? Una vez aprobado no se puede realizar cambios",
                    "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objOrdenCompra.IdOrdenCompraGeneral = Convert.ToInt64(txtIdOrdenCompra.Text);
            _objOrdenCompra.EstadoOrdencompraGeneral = 2;
            _objOrdenCompra.ActualizarEstadoOrdenCompra();
            _sqlCommands.Add(_objOrdenCompra.ActualizarEstadoOrdenCompra());

            var user = Usuario.Datos.ToString();
            var nombre = $"Oroden de Compra aprobada por: {user}";
            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombre);

            if ((bool)res[0]) btnRecargar.PerformClick();
            MessageBox.Show((string)res[1], "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSubtotal12OrdenCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = (TextBox) sender;
            e.Handled = !Validaciones.IsNumeroDecimal(e.KeyChar, txt.Text);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
