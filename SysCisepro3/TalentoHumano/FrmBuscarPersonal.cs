using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.TalentoHumano;
using SysCisepro3.Datos;
using SysCisepro3.Properties;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmBuscarPersonal : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para buscar datos de personal
        /// </summary>
        private readonly ClassPersonal _objPersonal;
        public TipoConexion TipoCon { get; set; }
        public bool SoloActivos { get; set; } // SI (ACTIVOS) - NO (TODOS)
        public int Tipo { get; set; } // 0 TODOS - 1 ADMIN - 2 OPER

        public FrmBuscarPersonal()
        {
            InitializeComponent();
            _objPersonal = new ClassPersonal();
        }

        private void FrmBuscarProveedor_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label1.ForeColor = Color.White;
            Label2.ForeColor = Color.White;
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

            txtParametrobusqueda.Focus();
        }

        private void txtParametrobusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            CargarPersonal(txtParametrobusqueda.Text.Trim());
        }

        private void CargarPersonal(string fil)
        {
            try
            {
                dataGridView1.DataSource = _objPersonal.SeleccionarPersonal(TipoCon, fil, SoloActivos, Tipo);

                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[0].Tag = 1;

                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].Tag = 1;

                dataGridView1.Columns[2].Width = 250;
                dataGridView1.Columns[2].Tag = 1;

                dataGridView1.Columns[3].HeaderText = @"CARGO";
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[3].Tag = 1;

                dataGridView1.Columns[9].HeaderText = @"DIRECCIÓN";
                dataGridView1.Columns[9].Width = 250;
                dataGridView1.Columns[9].Tag = 1;

                dataGridView1.Columns[28].HeaderText = @"MÓVIL";
                dataGridView1.Columns[28].Width = 90;
                dataGridView1.Columns[28].Tag = 1;

                foreach (DataGridViewColumn col in dataGridView1.Columns) col.Visible = col.Tag != null;

                dataGridView1.AutoResizeRows();
                Label2.Text = dataGridView1.RowCount + @" REGISTROS ENCONTRADOS";
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

        private void txtParametrobusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
