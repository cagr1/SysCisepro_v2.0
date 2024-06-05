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
using SysCisepro3.Properties;
using SysCisepro3.Datos;
using syscisepro.FORMULARIOS.INVENTARIOS.PROCESO;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.TalentoHumano;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmPoryectoContratacion : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para registrar nombres de proyectos contratos de la cia con otras empresas, para licitacion
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmPoryectoContratacion _instance;
        public static FrmPoryectoContratacion Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmPoryectoContratacion();
                return _instance;
            }
        }
        private readonly ClassContratos _objContratos;
        private FrmBuscarProveedorCliente frmBuscarCliente;
        private readonly List<SqlCommand> _sqlCommands;
        private int _estado;

        public FrmPoryectoContratacion()
        {
            InitializeComponent();
            _estado = 0;
            _sqlCommands = new List<SqlCommand>();
            _objContratos = new ClassContratos();
        }

        private void FrmPoryectoContratacion_Load(object sender, EventArgs e)
        { 
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
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
            dgvPoryectos.Font = new Font("Roboto", 8, FontStyle.Regular);
        }

        private void btnPersonalEntra_Click(object sender, EventArgs e)
        {
            frmBuscarCliente = new FrmBuscarProveedorCliente();
            frmBuscarCliente.TipoCox = (int)TipoCon;
            frmBuscarCliente.rbtCliente.Checked = true;
            frmBuscarCliente.rbtPersonal.Visible = false;
            frmBuscarCliente.rbtProveedor.Visible = false;
            frmBuscarCliente.Todos = false;
            frmBuscarCliente.txtParametrobusqueda.Width = frmBuscarCliente.txtParametrobusqueda.Width + frmBuscarCliente.rbtProveedor.Width + frmBuscarCliente.rbtPersonal.Width;
            if (frmBuscarCliente.ShowDialog() != DialogResult.OK) return;
            try
            {
                if (frmBuscarCliente.rbtCliente.Checked)
                {
                    txtCliente.Tag = frmBuscarCliente.dgvCustodios.CurrentRow.Cells[0].Value.ToString();
                    txtCliente.Text = frmBuscarCliente.dgvCustodios.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch
            {
                txtCliente.Tag = null;
                txtCliente.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            CargarAsignaciones(txtFiltro.Text.Trim());
        }

        private void CargarAsignaciones(string filtro)
        {
            try
            {
                dgvPoryectos.DataSource = _objContratos.SeleccionarProyectosContratoFiltro(TipoCon, filtro);
                dgvPoryectos.Columns[3].DefaultCellStyle.Format = "d";
                dgvPoryectos.Columns[4].DefaultCellStyle.Format = "d";

                dgvPoryectos.AutoResizeColumns();
                dgvPoryectos.AutoResizeRows();

                Label1.Text = dgvPoryectos.RowCount + " REGISTRO(S)";
            } 
            catch (Exception ex)
            {
                Label1.Text = @"0 REGISTRO(S)";
                MessageBox.Show(@"Error al cargar detalles: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            CargarAsignaciones(txtFiltro.Text.Trim());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnCliente.Enabled = true;
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            chkEstado.Enabled = false;
            
            txtIdProyecto.Clear();
            txtCodigo.Text = "S/N";
            txtCliente.Clear();
            txtCliente.Tag = null;
            txtNombre.Clear();
            chkEstado.Checked = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            _estado = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCliente.Enabled = false;
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            chkEstado.Enabled = false;
            
            txtIdProyecto.Clear();
            txtCodigo.Clear();
            txtCliente.Clear();
            txtCliente.Tag = null;
            txtNombre.Clear();
            chkEstado.Checked = false;

            _estado = 0;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            CargarAsignaciones(txtFiltro.Text.Trim());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"Debe definir los datos del proyecto para guardar!",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(@"Desea guardar el proyecto actual?",
                   "MENSAJE DELL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
               DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objContratos.IdProyecto =_estado == 1? _objContratos.BuscarMayorIdProyecto(TipoCon) + 1:Convert.ToInt32(txtIdProyecto.Text);
            _objContratos.NombreProyecto = txtNombre.Text.Trim();
            _objContratos.FechaInicio = dateTimePicker1.Value;
            _objContratos.FechaFin = dateTimePicker2.Value;
            _objContratos.IdCliente = txtCliente.Tag == null ? 0 : Convert.ToInt32(txtCliente.Tag);
            _objContratos.EstadoProyecto = chkEstado.Checked ? 1 : 0;
            _objContratos.CodigoProyecto = txtCodigo.Text;

            if (_estado == 1) _sqlCommands.Add(_objContratos.RegistrarNuevoProyectoCommand());
            else _sqlCommands.Add(_objContratos.ModificarNuevoProyectoCommand());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, _estado == 1 ? "GUARDAR PROYECTO" : "ACTUALIZAR PROYECTO");

            if ((bool)res[0])
            {
                btnCliente.Enabled = false;
                txtCodigo.Enabled = false;
                txtNombre.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                chkEstado.Enabled = false;


                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;

                txtFiltro.Clear();
                _estado = 0;

                CargarAsignaciones(string.Empty);
            }
            MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnCliente.Enabled = true;
             
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            chkEstado.Enabled = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            _estado = 2;
        }

        private void dgvPoryectos_SelectionChanged(object sender, EventArgs e)
        {
            if (_estado != 0) return;
            if (dgvPoryectos.DataSource == null) return;
            if (dgvPoryectos.CurrentRow == null) return;

            txtIdProyecto.Text = dgvPoryectos.CurrentRow.Cells[0].Value.ToString();
            txtCodigo.Text = dgvPoryectos.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvPoryectos.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgvPoryectos.CurrentRow.Cells[3].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dgvPoryectos.CurrentRow.Cells[4].Value);
            txtCliente.Tag = dgvPoryectos.CurrentRow.Cells[5].Value.ToString().Equals("0") ? null : dgvPoryectos.CurrentRow.Cells[5].Value.ToString();
            txtCliente.Text = dgvPoryectos.CurrentRow.Cells[6].Value.ToString();
            chkEstado.Checked = dgvPoryectos.CurrentRow.Cells[7].Value.ToString().Equals("1");
             
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
        }
    }
}