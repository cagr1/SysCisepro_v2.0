using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.Contabilidad.PlanDeCuentas;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using Krypton.Toolkit;

namespace SysCisepro3.Contabilidad
{
    public partial class FrmBuscarPlanCuentas : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para buscar cuentas en PLAN DE CUENTAS
        /// </summary>
        private readonly ClassPlanDeCuentas _objpLClassPlanDeCuentas;
        public TipoConexion TipoCon { get; set; }
        public int Tipo { get; set; }

        public FrmBuscarPlanCuentas()
        {
            InitializeComponent();
            _objpLClassPlanDeCuentas = new ClassPlanDeCuentas();
        }

        private void FrmBuscarPlanCuentas_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 

            BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
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

            cbxTipoCuenta.SelectedIndex = 0;
            txtParametrobusqueda.Focus();
        }

        private void txtParametrobusqueda_KeyUp(object sender, KeyEventArgs e)
        { 
            if (txtParametrobusqueda.Text.Trim().Length == 0) return;
            CargarCuentas(txtParametrobusqueda.Text.Trim());
        }

        private void CargarCuentas(string fil)
        {
            try
            {
                DataTable data;
                listView1.Items.Clear();
                listView1.Groups.Clear();
                
                switch (Tipo)
                {
                    case 1: listView1.Groups.Add(new ListViewGroup("ACTIVOS"));
                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(TipoCon, false, 1, fil);
                        break;
                    case 2: listView1.Groups.Add(new ListViewGroup("PASIVOS"));
                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(TipoCon, false, 2, fil);
                        break;
                    case 3: listView1.Groups.Add(new ListViewGroup("PATRIMONIO"));
                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(TipoCon, false, 3, fil);
                        break;
                    case 4: listView1.Groups.Add(new ListViewGroup("INGRESOS"));
                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(TipoCon, false, 4, fil);
                        break;
                    case 5: listView1.Groups.Add(new ListViewGroup("GASTOS"));
                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(TipoCon, false, 5, fil);
                        break;
                    case 6: listView1.Groups.Add(new ListViewGroup("GANANCIAS"));
                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(TipoCon, false, 6, fil);
                        break;
                    default:
                        listView1.Groups.Add(new ListViewGroup("ACTIVOS"));
                        listView1.Groups.Add(new ListViewGroup("PASIVOS"));
                        listView1.Groups.Add(new ListViewGroup("PATRIMONIO"));
                        listView1.Groups.Add(new ListViewGroup("INGRESOS"));
                        listView1.Groups.Add(new ListViewGroup("GASTOS"));
                        listView1.Groups.Add(new ListViewGroup("GANANCIAS"));

                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(TipoCon, true, 0, fil);
                        break;
                }

                foreach (DataRow s in data.Rows)
                {
                    var li = new ListViewItem(s[0].ToString(), GetListViewGroup(s[7].ToString().Trim()));
                    for (var i = 1; i < data.Columns.Count - 1; i++) li.SubItems.Add(s[i].ToString());
                    listView1.Items.Add(li);
                }

                foreach (var col in listView1.Columns.Cast<ColumnHeader>().Where(col => col.Width > 5)) col.Width = -2;

                label4.Visible = false;
            }
            catch (Exception ex)
            {
                label4.Text = @"ERROR AL CARGAR DATOS: " + ex.Message;
                label4.Visible = true;
                listView1.Clear();
            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0) return;
            if (listView1.SelectedItems.Count == 0) return;

            DialogResult = DialogResult.OK;
        }

        private ListViewGroup GetListViewGroup(string gname)
        {
            var g = new ListViewGroup();
            foreach (var @group in listView1.Groups.Cast<ListViewGroup>().Where(@group => @group.Header.Equals(gname)))
            {
                g = @group;
            }
            return g;
        }

        private void cbxTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tipo = cbxTipoCuenta.SelectedIndex;
            CargarCuentas(txtParametrobusqueda.Text.Trim());
        }
    }
}