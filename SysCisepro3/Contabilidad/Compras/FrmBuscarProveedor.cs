using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryCisepro3.Contabilidad.Proveedores;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using Krypton.Toolkit;
namespace SysCisepro3.Contabilidad.Compras
{
    public partial class FrmBuscarProveedor : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para buscar PROVEEDORES
        /// </summary>
        private readonly ClassProveedores _objProveedores;
        public TipoConexion TipoCon { get; set; }

        public FrmBuscarProveedor()
        {
            InitializeComponent();
            _objProveedores = new ClassProveedores();
        }

        private void FrmBuscarProveedor_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label1.ForeColor = Color.White;
            Label2.ForeColor = Color.White;
            Label3.ForeColor = Color.White;
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
            dataGridView1.Font = new Font("Roboto", 8, FontStyle.Regular);
            txtParametrobusqueda.Focus();
        }

        private void txtParametrobusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            CargarSitios(txtParametrobusqueda.Text.Trim());
        }

        private void CargarSitios(string fil)
        {
            try
            {
                dataGridView1.DataSource = _objProveedores.SeleccionarProveedores(TipoCon, fil);

                dataGridView1.Columns[0].HeaderText = @"ID";
                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[0].Tag = 1;

                dataGridView1.Columns[2].HeaderText = @"RUC";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].Tag = 1;

                dataGridView1.Columns[3].HeaderText = @"RAZÓN SOCIAL";
                dataGridView1.Columns[3].Width = 250;
                dataGridView1.Columns[3].Tag = 1;

                dataGridView1.Columns[4].HeaderText = @"NOMBRE COMERCIAL";
                dataGridView1.Columns[4].Width = 250;
                dataGridView1.Columns[4].Tag = 1;

                dataGridView1.Columns[8].HeaderText = @"DIRECCIÓN";
                dataGridView1.Columns[8].Width = 250;
                dataGridView1.Columns[8].Tag = 1;

                dataGridView1.Columns[10].HeaderText = @"TELÉFONO";
                dataGridView1.Columns[10].Width = 90;
                dataGridView1.Columns[10].Tag = 1;

                dataGridView1.Columns[12].HeaderText = @"EMAIL";
                dataGridView1.Columns[12].Width = 180;
                dataGridView1.Columns[12].Tag = 1;

                foreach (DataGridViewColumn col in dataGridView1.Columns) col.Visible = col.Tag != null;

                dataGridView1.AutoResizeRows();
            }
            catch (Exception ex)
            {
                label4.Text = @"ERROR AL CARGAR DATOS: " + ex.Message;
                label4.Visible = true;
                dataGridView1.Rows.Clear();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (dataGridView1.CurrentRow == null) return;
            DialogResult = DialogResult.OK;
        }
    }
}
