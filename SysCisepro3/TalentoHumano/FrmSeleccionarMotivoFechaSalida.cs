using System;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Properties;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmSeleccionarMotivoFechaSalida : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para registar el motivo de salida y la fecha de salida del personal
        /// </summary>
        public TipoConexion TipoCon { private get; set; }
        public FrmSeleccionarMotivoFechaSalida()
        {
            InitializeComponent();
        }

        private void FrmSeleccionarMotivoFechaSalida_Load(object sender, EventArgs e)
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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DateTimePicker1.Value = new DateTime(1990, 1, 1, 0, 0, 0);
                DateTimePicker1.Enabled = false;
            }
            else
            {
                DateTimePicker1.Value = DateTime.Now;
                DateTimePicker1.Enabled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
