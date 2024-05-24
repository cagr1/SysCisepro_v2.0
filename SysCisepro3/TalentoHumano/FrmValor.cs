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
    public partial class FrmValor : Form
    {

        /// <summary>
        /// CISEPRO 2019
        /// Para ingresar un valor decimal como INPUTBOX
        /// </summary>
        public TipoConexion TipoCon { private get; set; }
        public decimal Valor { get; set; }

        public FrmValor()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Valor = numericUpDown1.Value;
            }
            catch
            {
                Valor = 0;
            }
             
            DialogResult = DialogResult.OK;
        }

        private void FrmValor_Load(object sender, EventArgs e)
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
            numericUpDown1.Focus();
        }
    }
}
