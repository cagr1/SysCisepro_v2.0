using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.DivisionGeografica;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using ClassLibraryCisepro3.TalentoHumano;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmBuscarAspirante : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// BUSCAR PUESTOS DE TRABAJO
        /// </summary>
        private readonly ClassAspirante _objAspirante;
        public TipoConexion TipoCon { private get; set; }

        public FrmBuscarAspirante()
        {
            InitializeComponent();
            _objAspirante = new ClassAspirante();
        }

        private void FrmBuscarAspirante_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label1.ForeColor = Color.White;
            Label2.ForeColor = Color.White;
            Label3.ForeColor = Color.White;
            dgvAspirante.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
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
                dgvAspirante.DataSource = _objAspirante.SeleccionarTodosRegistrosAspiranteFiltro(TipoCon, 1, txtParametrobusqueda.Text.Trim());
                if (dgvAspirante.RowCount == 0) return;

                dgvAspirante.Columns[0].Width = 40;
                dgvAspirante.Columns[1].Width = 80;
                dgvAspirante.Columns[2].Width = 250;
                dgvAspirante.Columns[3].Width = 100;
                dgvAspirante.Columns[4].Width = 300;
                dgvAspirante.Columns[5].Width = 300;
                dgvAspirante.Columns[6].Width = 80;
                dgvAspirante.Columns[7].Width = 80;
                dgvAspirante.Columns[8].Width = 300;
                dgvAspirante.Columns[9].Width = 120;
                dgvAspirante.Columns[9].DefaultCellStyle.Format = "g";
                dgvAspirante.AutoResizeRows();
                     
            }
            catch (Exception ex)
            {
                label4.Text = @"ERROR AL CARGAR DATOS: " + ex.Message;
                label4.Visible = true;
                dgvAspirante.DataSource = null;
            }
        }

        private void dgvAspirante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAspirante.RowCount == 0) return;
            if (dgvAspirante.CurrentRow == null) return;
            DialogResult = DialogResult.OK;
        }  
    }
}
