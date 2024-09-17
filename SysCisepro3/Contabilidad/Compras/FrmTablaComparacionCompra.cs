using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using SysCisepro3.Datos;
using SysCisepro3.Operaciones;
using SysCisepro3.Properties;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.EstructuraEmpresa;
using ClassLibraryCisepro3.UsuarioGeneral;
using ClassLibraryCisepro3.ProcesosSql;
using SysCisepro3.TalentoHumano;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Contabilidad.Proveedores;
using ClassLibraryCisepro3.Invetarios;
using ClassLibraryCisepro3.Contabilidad.Compras.TablaComparativa;
//using iText.Kernel.Pdf.Canvas.Wmf;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Patagames.Pdf.Net.Wrappers;
using System.Windows.Controls;





namespace SysCisepro3.Contabilidad.Compras
{
    public partial class FrmTablaComparacionCompra : KryptonForm
    {

        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmTablaComparacionCompra _instance;
        public static FrmTablaComparacionCompra Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmTablaComparacionCompra();
                return _instance;
            }
        }

        private readonly List<SqlCommand> _sqlCommands;
        private readonly ClassProveedores _objProveedores;
        private readonly ClassSecuencialItem _objSecuencialItem;
        private readonly ClassTablaComparativa _objTablaComparativa;
        private readonly ClassDetalleTablaComparativa _objDetalleTablaComparativa;
        public FrmTablaComparacionCompra()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();
            _objProveedores = new ClassProveedores();
            _objSecuencialItem = new ClassSecuencialItem();
            _objTablaComparativa = new ClassTablaComparativa();
            _objDetalleTablaComparativa = new ClassDetalleTablaComparativa();

        }

        private void FrmTablaComparacionCompra_Load(object sender, EventArgs e)
        {
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
            ValidationForms.SetPlaceholder(txtProveedor, "Ingrese el Proveedor..");
            ValidationForms.SetPlaceholder(txtObservaciones, "Ingrese Observaciones..");
            ValidationForms.SetPlaceholder(txtBuscar, "Buscar por observaciones..");

         
        }

        private void dgvIngresoTabla_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var itemName = e.Control as System.Windows.Forms.TextBox;
            itemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;

            itemName.KeyPress -= Item_KeyPress;
            if (dgvIngresoTabla.CurrentCell.ColumnIndex == 1)
            {
                itemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                itemName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                itemName.AutoCompleteCustomSource = _objSecuencialItem.AutoCompletarSecuencial(TipoCon);
            }
            
            else
            {
                itemName.AutoCompleteMode = AutoCompleteMode.None;
                itemName.AutoCompleteSource = AutoCompleteSource.None;
            }

            if(dgvIngresoTabla.CurrentCell.ColumnIndex == 2 || dgvIngresoTabla.CurrentCell.ColumnIndex == 3 || dgvIngresoTabla.CurrentCell.ColumnIndex == 4)
            {
                itemName.KeyPress += Item_KeyPress ;
            }           
           
        }

        private void Item_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return; 
            }
            var textBox = sender as System.Windows.Forms.TextBox;
                       
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {             
                if (e.KeyChar == '.')
                {                 
                    if (textBox.Text.Contains("."))
                    {
                        e.Handled = true; 
                    }
                }
            }
            else
            {
                e.Handled = true; 
            }

        }


        private void dgvIngresoTabla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 1 && dgvIngresoTabla.CurrentRow.Cells[1].Value != null)
                {
                    string pro = dgvIngresoTabla.CurrentRow.Cells[1].Value.ToString();
                    var dtp = _objSecuencialItem.SeleccionarSecuencialItemsXNombre(TipoCon, pro);
                    if (dtp.Rows.Count > 0)
                    {
                        dgvIngresoTabla.CurrentRow.Cells[0].Value = dtp.Rows[0][0].ToString();
                    }
                }

               
            }
        }

        private void btnNuevaTabla_Click(object sender, EventArgs e)
        {
            HabilitarRegistro(true);
            Autocompletarproveedor();
        }

        private void HabilitarRegistro(bool estado)
        {
            dgvIngresoTabla.Enabled = estado;
            btnGuardarTabla.Enabled = estado;
            btnCancelar.Enabled = estado;
            txtObservaciones.Enabled = estado;
            dtpFecha.Enabled = estado;
            txtProveedor.Enabled = estado;

        }

        private void btnGuardarTabla_Click(object sender, EventArgs e)
        {
            _sqlCommands.Clear();

            if (dgvIngresoTabla.CurrentRow.Cells.Count < 0)
            {
                KryptonMessageBox.Show("Debe ingresar los datos de la tabla", "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            if (KryptonMessageBox.Show("¿Desea guardar la tabla?", "Aviso", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) == DialogResult.Yes)
            {
                GuardarTabla();
            }
            
            ResetDataGrid();
            string user = Usuario.Datos.ToString();
            string nombreU = "Tabla Comparativa por: " + user;

            

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombreU);
            if ((bool)res[0])
            {                
                HabilitarRegistro(false);
                txtObservaciones.Clear();
                dgvIngresoTabla.Rows.Clear();
                txtProveedor.Clear();
                lblIdProveedor.Text = "";
            }

            KryptonMessageBox.Show((string)res[1], "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

        }

        private void GuardarTabla()
        {
            try
            {
                _objTablaComparativa.IdTablaComparativa = _objTablaComparativa.BuscarMayorIdTablaComparativa(TipoCon) + 1;
                _objTablaComparativa.Observacion = txtObservaciones.Text;
                _objTablaComparativa.Fecha = dtpFecha.Value;
                _objTablaComparativa.estado = 1;
                _sqlCommands.Add(_objTablaComparativa.InsertarTablaComparativaCommand());

                var iddeta = _objDetalleTablaComparativa.BuscarMayorIdDetalleTablaComparativa(TipoCon) + 1;
                bool isAnyChecked = false;
                foreach (DataGridViewRow row in dgvIngresoTabla.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool isRowChecked = false;

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null ||
                        row.Cells[3].Value == null || row.Cells[4].Value == null)
                        continue;


                    foreach (DataGridViewColumn column in dgvIngresoTabla.Columns)
                    {
                        if (column is DataGridViewCheckBoxColumn)
                        {
                            if (Convert.ToBoolean(row.Cells[column.Name].Value))
                            {
                                isRowChecked = true;
                                isAnyChecked = true;
                                string nombreProveedor = column.HeaderText;
                                var dt = _objProveedores.SeleccionarProveedorGeneralXNombre(TipoCon, nombreProveedor);
                                if(dt.Rows.Count > 0)
                                {
                                    _objDetalleTablaComparativa.IdProveedor = Convert.ToInt32(dt.Rows[0][0]);
                                }
                                else
                                {
                                    KryptonMessageBox.Show("Proveedor no encontrado, haga check en la fila vacia del proveedor", "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                                    return;
                                }
                                
                                _objDetalleTablaComparativa.IdDetalleTablaComparativa = iddeta;
                                _objDetalleTablaComparativa.IdSecuencial = Convert.ToInt32(row.Cells[0].Value);
                                _objDetalleTablaComparativa.IdTablaComparativa = _objTablaComparativa.IdTablaComparativa;
                                _objDetalleTablaComparativa.Precio = Convert.ToDecimal(row.Cells[2].Value);
                                _objDetalleTablaComparativa.Credito = Convert.ToInt32(row.Cells[3].Value);
                                _objDetalleTablaComparativa.Dias = Convert.ToInt32(row.Cells[4].Value);
                                _objDetalleTablaComparativa.Estado = 1;
                                _sqlCommands.Add(_objDetalleTablaComparativa.InsertarDetalleTablaComparativaCommand());
                                iddeta++;

                            }
                        }
                    }                    
                }
                if (!isAnyChecked)
                {
                    KryptonMessageBox.Show("Debe seleccionar al menos un proveedor", "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    return;
                }

            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void ResetDataGrid()
        {
            for (int i = dgvIngresoTabla.Columns.Count - 1; i >= 0; i--)
            {
                DataGridViewColumn column = dgvIngresoTabla.Columns[i];
                if (column.Name.StartsWith("Column_")) 
                {
                    dgvIngresoTabla.Columns.RemoveAt(i);
                }
            }
        }

        private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProveedor.Text != "")
                {
                    var dt = _objProveedores.SeleccionarProveedorGeneralXNombre(TipoCon, txtProveedor.Text);

                    if (dt.Rows.Count > 0)
                    {
                        lblIdProveedor.Text = dt.Rows[0][0].ToString();
                    }
                    else
                    {
                        KryptonMessageBox.Show("Proveedor no encontrado", "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProveedor.Text) || string.IsNullOrEmpty(lblIdProveedor.Text))
            {
                KryptonMessageBox.Show("Debe seleccionar un proveedor", "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            
            string columnName = "Column_" + txtProveedor.Text;
            
            if (!dgvIngresoTabla.Columns.Contains(columnName))
            {                
                DataGridViewCheckBoxColumn newColumn = new DataGridViewCheckBoxColumn
                {
                    HeaderText = txtProveedor.Text,
                    Name = columnName,
                    Width = 120,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight }
                };                
                dgvIngresoTabla.Columns.Add(newColumn);
                
            }

            foreach (DataGridViewRow row in dgvIngresoTabla.Rows)
            {            
                if (row.IsNewRow) continue;
                bool isChecked = !string.IsNullOrEmpty(lblIdProveedor.Text); 
                row.Cells[columnName].Value = isChecked;

            }

        }

        private void Autocompletarproveedor()
        {
            txtProveedor.AutoCompleteCustomSource = _objProveedores.AutoCompletarProveedor(TipoCon);
            txtProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarRegistro(false);
            txtObservaciones.Clear();
            dgvIngresoTabla.Rows.Clear();
            dgvIngresoTabla.Columns.Clear();
            txtProveedor.Clear();
            lblIdProveedor.Text = "";
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        

        private void dgvTablaComparativa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTablaComparativa.CurrentRow == null) return;
                      
            CargarDetalleComparativo(Convert.ToInt32(dgvTablaComparativa.CurrentRow.Cells[0].Value.ToString()));
        }

        private void  CargarDetalleComparativo( int id )
        {
            try
            {                
                dgvDetalleTablaComparativa.DataSource = _objDetalleTablaComparativa.buscarDetalleTablaComparativa(TipoCon, id);
                dgvDetalleTablaComparativa.Columns[0].Width = 70;
                dgvDetalleTablaComparativa.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleTablaComparativa.Columns[1].Width = 320;
                dgvDetalleTablaComparativa.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleTablaComparativa.Columns[2].Width = 250;
                dgvDetalleTablaComparativa.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleTablaComparativa.Columns[3].Width = 70;
                dgvDetalleTablaComparativa.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleTablaComparativa.Columns[4].Width = 70;
                dgvDetalleTablaComparativa.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleTablaComparativa.Columns[5].Width = 70;
                dgvDetalleTablaComparativa.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {                        
                var dt = _objTablaComparativa.BuscarTablaComparativa(TipoCon, txtBuscar.Text);

                if (dt.Rows.Count > 0)
                {
                    dgvTablaComparativa.DataSource = dt;                   
                    dgvTablaComparativa.Columns[0].Width = 70;
                    dgvTablaComparativa.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;                    
                    dgvTablaComparativa.Columns[1].Width = 250;
                    dgvTablaComparativa.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;                 
                    dgvTablaComparativa.Columns[2].Width = 120;
                    dgvTablaComparativa.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else
                {
                    KryptonMessageBox.Show("Proveedor no encontrado", "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                }
            
        }

        private void kryptonDropButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
          
          
            string ruta = System.IO.Path.Combine(Application.StartupPath, "Temp.pdf");


            Document document = new Document(PageSize.A4);
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(ruta, FileMode.Create));
                document.Open();
                string rutaImagen = Validaciones.NombreLogoNuevo(TipoCon, Application.StartupPath);
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaImagen);
                logo.ScaleToFit(100, 100);
                document.Add(logo);

                iTextSharp.text.Font fuente12 = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK);
                iTextSharp.text.Font fuente10 = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
                iTextSharp.text.Font fuente8 = FontFactory.GetFont(FontFactory.HELVETICA, 8, BaseColor.BLACK);
                Paragraph title = new Paragraph("TABLA COMPARATIVA DE COMPRAS",fuente12);
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                document.Add(new Paragraph("\n"));

                PdfPTable tabla = new PdfPTable(dgvDetalleTablaComparativa.ColumnCount);

                float[] columnWidthTabla1 = new float[] {0f, 5f,4f,2f,2f,2f};
                tabla.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                for (int i = 0; i < dgvDetalleTablaComparativa.ColumnCount; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dgvDetalleTablaComparativa.Columns[i].HeaderText, fuente10));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    tabla.AddCell(cell);
                }

               
                for (int row = 0; row < dgvDetalleTablaComparativa.Rows.Count; row++)
                {
                    for (int col = 0; col < dgvDetalleTablaComparativa.ColumnCount; col++)
                    {
                        if (dgvDetalleTablaComparativa[col, row].Value != null)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(dgvDetalleTablaComparativa[col, row].Value.ToString(), fuente8));
                            cell.HorizontalAlignment = Element.ALIGN_LEFT;
                            cell.BackgroundColor = BaseColor.WHITE;
                            tabla.AddCell(cell);
                        }
                    }
                }                                  
                tabla.SetWidths(columnWidthTabla1);
                document.Add(tabla);
                document.Close();
                pdfViewer1.LoadDocument(ruta);                                              

            }

            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }

        }
    }
}
