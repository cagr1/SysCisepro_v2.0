using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Properties;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmPeriodoVacaciones : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para seleccionar periodo de vacaciones del personal
        /// </summary>
        public TipoConexion TipoCon { private get; set; }
        public string Nombre { private get; set; }
        public string Observacion { get; set; }

        public FrmPeriodoVacaciones()
        {
            InitializeComponent();
        }

        private void FrmPeriodoVacaciones_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
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
            lblNombre.Text = Nombre;
            txtObservacion.Text = Observacion;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show(@"El período seleccionado NO ES VÁLIDO!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Observacion = txtObservacion.Text;
            DialogResult = DialogResult.OK;
        }
    }
}