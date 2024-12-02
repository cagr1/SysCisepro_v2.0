using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using syscisepro;
using SysCisepro3.Datos;
using SysCisepro3.Properties;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmCumpleanosPersonal : Form
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para visualizar reporte de cumpleañeros de la compañia
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmCumpleanosPersonal _instance;
        public static FrmCumpleanosPersonal Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmCumpleanosPersonal();
                return _instance;
            }
        }

        private readonly ClassPersonal _objPersonal;
        private readonly crCumpleaños _crCumpleaneros;

        private FrmCumpleanosPersonal()
        {
            InitializeComponent();
            _objPersonal = new ClassPersonal();
            _crCumpleaneros = new crCumpleaños();
        }

        private void FrmCumpleanosPersonal_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            MenuStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            MenuStrip1.ForeColor = Color.White;
            Label1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label1.ForeColor = Color.White;
            Label2.BackColor = ValidationForms.GetColorSistema(TipoCon);
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

            dtpFechaInicial.Value = Usuario.Now(TipoCon);
            dtpFechaFinal.Value = dtpFechaInicial.Value.AddMonths(1).AddDays(-1);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _objPersonal.SeleccionarCumpleaneros(TipoCon, dtpFechaInicial.Value.Month, dtpFechaFinal.Value.Month);
                if (dataGridView1.RowCount == 0) return;

                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[1].Width = 130;
                dataGridView1.Columns[2].Width = 130;
                dataGridView1.Columns[3].Width = 350;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                dataGridView1.DataSource = null;
                MessageBox.Show(@"Error al cargar detalles: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                _crCumpleaneros.SetDataSource(_objPersonal.SeleccionarCumpleaneros(TipoCon, dtpFechaInicial.Value.Month, dtpFechaFinal.Value.Month));
                _crCumpleaneros.SetParameterValue("img", Validaciones.NombreLogo(TipoCon, Application.StartupPath));
                crvCumpleañeros.ReportSource = _crCumpleaneros;
                crvCumpleañeros.Zoom(75);
                crvCumpleañeros.Refresh();
                TabPage1.TabIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error al cargar detalles: " + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0 || dataGridView1.CurrentRow == null) return;
            try
            {
                PictureBox1.Image = ValidationForms.BytesToImage((byte[])dataGridView1.CurrentRow.Cells[5].Value);
                lblEdad.Text = (DateTime.Now.Year - Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value).Year) + "";
            }
            catch
            {
                lblEdad.Text = @"0";
                PictureBox1.Image = Resources._default;
            }
        }
    }
}
