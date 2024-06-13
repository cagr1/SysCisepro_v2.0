using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.DivisionGeografica;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using Krypton.Toolkit;

namespace SysCisepro3.Operaciones
{
    public partial class FrmBuscarPuestoTrabajo : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// BUSCAR PUESTOS DE TRABAJO
        /// </summary>
        private readonly ClassSitiosTrabajo _objSitiosTrabajo;
        public TipoConexion TipoCon { private get; set; }

        public FrmBuscarPuestoTrabajo()
        {
            InitializeComponent();
            _objSitiosTrabajo = new ClassSitiosTrabajo();
        }

        private void FrmBuscarPuestoTrabajo_Load(object sender, EventArgs e)
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
                var grupos = _objSitiosTrabajo.SeleccionarSitiosTrabajoGrupos(TipoCon, fil);
                var sitios = _objSitiosTrabajo.SeleccionarSitiosTrabajoDatos(TipoCon, fil);

                ListView1.Items.Clear();
                ListView1.Groups.Clear();

                foreach (DataRow g in grupos.Rows) ListView1.Groups.Add(new ListViewGroup(g[0].ToString()));

                foreach (DataRow s in sitios.Rows)
                {
                    var li = new ListViewItem(s[0].ToString(), GetListViewGroup(s[18].ToString()));
                    for (var i = 1; i < sitios.Columns.Count - 1; i++) li.SubItems.Add(s[i].ToString());
                    ListView1.Items.Add(li);
                }

                foreach (var col in ListView1.Columns.Cast<ColumnHeader>().Where(col => col.Width > 5)) col.Width = -2;

                label4.Visible = false;
            }
            catch (Exception ex)
            {
                label4.Text = @"ERROR AL CARGAR DATOS: " + ex.Message;
                label4.Visible = true;
                ListView1.Clear();
            }
        }

        private ListViewGroup GetListViewGroup(string gname)
        {
            var g = new ListViewGroup();
            foreach (var @group in ListView1.Groups.Cast<ListViewGroup>().Where(@group => @group.Header.Equals(gname)))
            {
                g = @group;
            }
            return g;
        }

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListView1.Items.Count == 0) return;
            if (ListView1.SelectedItems.Count == 0) return;
            DialogResult = DialogResult.OK;
        }
    }
}
