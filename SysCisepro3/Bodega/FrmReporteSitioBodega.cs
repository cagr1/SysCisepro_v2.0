using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using syscisepro;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.UsuarioGeneral;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.DivisionGeografica;
using SysCisepro3.Main;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using Krypton.Toolkit;




namespace SysCisepro3.Bodega
{
    public partial class FrmReporteSitioBodega : KryptonForm
    {
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }
        private readonly ClassSitiosTrabajo _objetoSitio;

        private static FrmReporteSitioBodega _instance;
        public static FrmReporteSitioBodega Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmReporteSitioBodega();
                return _instance;
            }
        }

        

        public FrmReporteSitioBodega(TipoConexion tipoCon, ClassUsuarioGeneral usuario)
        {
            InitializeComponent();
            TipoCon = tipoCon;
            Usuario = usuario;

        }

        private FrmReporteSitioBodega()
        {

            InitializeComponent();
            _objetoSitio = new ClassSitiosTrabajo();
        
        }

        private void FrmReporteSitioBodega_Load(object sender, EventArgs e)
        {
            toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            toolStripLabel1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStripLabel1.ForeColor = Color.White;
            dgvsitios.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            

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
            dgvsitios.Font = new Font("Roboto", 8, FontStyle.Regular);
            var f = Usuario.ObtenerFechaSola(TipoCon);


            LlenarComboGrupos();
        

            
        }

        private void LlenarComboGrupos()
        {
            
            var data = _objetoSitio.SeleccionarGruposSitios(TipoCon, false, false, false);
            foreach (var row in data.Rows.Cast<DataRow>().Where(row => !cbxGrupo.Items.Contains(row[0])))
                cbxGrupo.Items.Add(row[0]);

            if (cbxGrupo.Items.Count > 0) cbxGrupo.SelectedIndex = 0;
            
            cbxGrupo.DisplayMember = "grupo";
            cbxGrupo.DropDownWidth = 180;
        }


     
        private void LlenarSitio()
        {
            try
            {
                cbxSitio.Items.Clear();
                var cius = _objetoSitio.SeleccionarSitiosConGrupos(TipoCon, cbxGrupo.Text);
                cbxSitio.Items.Add("TODOS LOS SITIOS");
               
                cbxSitio.DisplayMember = "SITIO_RIVER";
                cbxSitio.ValueMember = "ID_SITIO_TRABAJO";
                
                foreach (DataRow row in cius.Rows)
                {
                    cbxSitio.Items.Add(row["SITIO_RIVER"].ToString());
                }
                if (cbxSitio.Items.Count > 0) cbxSitio.SelectedIndex = 0;

                cbxSitio.DropDownWidth = 180;
                cbxSitio.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                cbxSitio.DataSource = null;
            }
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CargarItemsSitio(int idSitio)
        {
           

            try
            {
                var fechaDesde = dtpDesde.Value.Year + "-" + dtpDesde.Value.Month + "-" + dtpDesde.Value.Day + " 00:00:00";
                var fechaHasta = dtpHasta.Value.Year + "-" + dtpHasta.Value.Month + "-" + dtpHasta.Value.Day + " 23:59:59";

                dgvsitios.Rows.Clear();
                //var selectGrupo = cbxGrupo.SelectedItem.ToString();  //.SelectedItem.ToString();
                var data = _objetoSitio.SeleccionarItemsByIdSitio(TipoCon, idSitio, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta), cbxGrupo.Text);
                if (data.Rows.Count == 0)
                {
                    dgvsitios.DataSource = null;
                    return;
                }

                if (idSitio == 0)
                {
                    dgvsitios.DataSource = data;
                    dgvsitios.AutoResizeColumns();
                    
                    dgvsitios.Columns[0].HeaderText = "ID COMPROBANTE";
                    dgvsitios.Columns[0].Width = 70;
                    dgvsitios.Columns[1].HeaderText = "FECHA";
                    dgvsitios.Columns[1].Width = 90;
                    dgvsitios.Columns[1].DefaultCellStyle.Format = "d";
                    dgvsitios.Columns[2].HeaderText = "CANTIDAD";
                    dgvsitios.Columns[2].Width = 50;
                    dgvsitios.Columns[3].HeaderText = "TIPO";
                    dgvsitios.Columns[3].Width = 40;
                    dgvsitios.Columns[4].HeaderText = "ID KARDEX";
                    dgvsitios.Columns[4].Width = 70;
                    dgvsitios.Columns[5].HeaderText = "SERIE";
                    dgvsitios.Columns[5].Width = 200;
                    dgvsitios.Columns[6].HeaderText = "DESCRIPCION";
                    dgvsitios.Columns[6].Width = 200;
                    dgvsitios.Columns[7].HeaderText = "RAZON";
                    dgvsitios.Columns[7].Width = 400;
                    dgvsitios.Columns[8].HeaderText = "SITIO";
                    dgvsitios.Columns[8].Width = 400;
                    
                    dgvsitios.AutoResizeRows();
                }
                else
                {

                    dgvsitios.DataSource = data;
                    dgvsitios.AutoResizeColumns();

                    dgvsitios.Columns[0].HeaderText = "ID COMPROBANTE";
                    dgvsitios.Columns[0].Width = 70;
                    dgvsitios.Columns[1].HeaderText = "FECHA";
                    dgvsitios.Columns[1].Width = 90;
                    dgvsitios.Columns[1].DefaultCellStyle.Format = "d";
                    dgvsitios.Columns[2].HeaderText = "CANTIDAD";
                    dgvsitios.Columns[2].Width = 50;
                    dgvsitios.Columns[3].HeaderText = "TIPO";
                    dgvsitios.Columns[3].Width = 40;
                    dgvsitios.Columns[4].HeaderText = "ID KARDEX";
                    dgvsitios.Columns[4].Width = 70;
                    dgvsitios.Columns[5].HeaderText = "SERIE";
                    dgvsitios.Columns[5].Width = 200;
                    dgvsitios.Columns[6].HeaderText = "DESCRIPCION";
                    dgvsitios.Columns[6].Width = 200;
                    dgvsitios.Columns[7].HeaderText = "RAZON";
                    dgvsitios.Columns[7].Width = 400;

                    dgvsitios.AutoResizeRows();
                
                
                }
               
            }
            catch
            {
                dgvsitios.DataSource = null;
            }
        }


        private void btnReload_Click(object sender, EventArgs e)
        {

            try
            {               
                CargarItemsSitio(Convert.ToInt32(lblsitio.Text));
            }

            catch (Exception ex)
            {
                dgvsitios.DataSource = null;
            }
 

       }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbxSitio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var idsi = _objetoSitio.BuscarSitioId(TipoCon, cbxSitio.Text.Split('-')[0].Trim());
            if (idsi >= 0)
            {
                lblsitio.Text = idsi.ToString();
            }
            else
            {                
                lblsitio.Text = "TODOS";
            }
           
        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {           
            LlenarSitio();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (dgvsitios.RowCount == 0)
            {
                MessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Microsoft.Office.Interop.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
                worksheet.Name = "REPORTE DE BODEGA POR SITIOS";



                var l = -1;
                for (var i = 0; i <= dgvsitios.Columns.Count - 1; i++) if (dgvsitios.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l); // PARA FIRMA Y HUELLA

                var rc = dgvsitios.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A2:" + ic + "2"].Merge();
                worksheet.Range["A2:" + ic + "2"].Value = "PERÍODO: " + dtpDesde.Value.ToLongDateString() + "  AL " + dtpHasta.Value.ToLongDateString();
                worksheet.Range["A2:" + ic + "2"].Font.Size = 12;

                //worksheet.Range["A3:" + ic + "3"].Merge();
                //worksheet.Range["A3:" + ic + "3"].Value = "Fecha de Reporte: " + .ToLongDateString() + " " + fec.ToLongTimeString();
                //worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;

                var x = 1;
                for (var i = 0; i <= dgvsitios.Columns.Count - 1; i++)
                {
                    if (!dgvsitios.Columns[i].Visible) continue;

                    worksheet.Cells[head, x] = dgvsitios.Columns[i].HeaderText;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (DataGridViewRow row in dgvsitios.Rows)
                {
                    var y = 1;
                    for (var j = 0; j <= dgvsitios.Columns.Count - 1; j++)
                    {
                        if (!dgvsitios.Columns[j].Visible) continue;
                        worksheet.Cells[head, y] = row.Cells[j].Value;
                        if ((row.Tag + "").Equals("2") || (row.Tag + "").Equals("3")) worksheet.Cells[head, y].Font.Bold = true;
                        worksheet.Cells[head, y].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        y++;
                    }
                    head++;
                }

                var position = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[2, 7];
                Clipboard.SetImage(ValidationForms.Logo(TipoCon));
                worksheet.Paste(position);

                worksheet.Range["A1:" + ic + rc].Columns.AutoFit();
                app.DisplayAlerts = false;
                app.Visible = true;
                app.DisplayAlerts = true;
                //workbook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show(@"REPORTE DE SITIOS DE BODEGA generado correctamente!", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!" + "\n" + ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!" + "\n" + ex.Message, @"Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxActivar.Checked)
            {
                cbxGrupo.Enabled = true;
                cbxSitio.Enabled = true;
                txtFiltro.Enabled = false;

            }

            else
            {
                cbxGrupo.Enabled = false;
                cbxSitio.Enabled = false;
                txtFiltro.Enabled = true;

            }
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            CargarSitioTodo(txtFiltro.Text.Trim());
           
        }


        private void CargarSitioTodo(string text) 
        {
            try
            {
                var fechaDesde = dtpDesde.Value.Year + "-" + dtpDesde.Value.Month + "-" + dtpDesde.Value.Day + " 00:00:00";
                var fechaHasta = dtpHasta.Value.Year + "-" + dtpHasta.Value.Month + "-" + dtpHasta.Value.Day + " 23:59:59";

                dgvsitios.Rows.Clear();
                var data = _objetoSitio.SeleccionarItemsByTodo(TipoCon, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta), text);
                if (data.Rows.Count == 0)
                {
                    dgvsitios.DataSource = null;
                    return;
                }

                dgvsitios.DataSource = data;
                dgvsitios.AutoResizeColumns();
                dgvsitios.AutoResizeRows();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                dgvsitios.DataSource = null;
            }
        }
        
        
    }
}
