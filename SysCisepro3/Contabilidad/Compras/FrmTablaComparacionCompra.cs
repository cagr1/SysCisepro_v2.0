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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Controls;
using ComponentFactory.Krypton.Docking;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using PdfiumViewer;






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
        //private PdfViewer pdfViewer1;

        int facturaWidth = 0;
        int creditoWidth = 0;
        int diasWidth = 0;
        int itemsWidth = 0;

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

            if (dgvIngresoTabla.CurrentCell.OwningColumn.Name.StartsWith("Precio_"))
            {
                // Permitimos solo números decimales
                itemName.KeyPress += Item_KeyPressDecimal;
            }
            // Verificamos si es una columna de "Tiempo" o "Días" (solo números enteros permitidos)
            else if (dgvIngresoTabla.CurrentCell.OwningColumn.Name.StartsWith("Tiempo_"))
            {
                // Permitimos solo números enteros
                itemName.KeyPress += Item_KeyPressInteger;
            }

        }

        private void Item_KeyPressDecimal(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            var textBox = sender as System.Windows.Forms.TextBox;

            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
            
                if (e.KeyChar == '.' && textBox.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Item_KeyPressInteger(object sender, KeyPressEventArgs e)
        {
            // Permitimos solo dígitos y teclas de control
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Si no es un dígito, cancelamos la entrada
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
                
                
                foreach (DataGridViewRow row in dgvIngresoTabla.Rows)
                {
                    if (row.IsNewRow) continue;

                    

                    if (row.Cells[0].Value == null || row.Cells[1].Value == null )
                        continue;


                    foreach (DataGridViewColumn column in dgvIngresoTabla.Columns)
                    {
                        if (column.Name.StartsWith("Precio_") || column.Name.StartsWith("Tiempo_") )
                        {
                            string nombreProveedor = column.HeaderText;

                            if (nombreProveedor.StartsWith("Precio (") || nombreProveedor.StartsWith("Entrega ("))
                            {
                                nombreProveedor = nombreProveedor.Substring(nombreProveedor.IndexOf('(') + 1);
                                nombreProveedor = nombreProveedor.TrimEnd(')');
                            }

                            var dt = _objProveedores.SeleccionarProveedorGeneralXNombre(TipoCon, nombreProveedor);
                            if (dt.Rows.Count > 0)
                            {
                               _objDetalleTablaComparativa.IdProveedor = Convert.ToInt32(dt.Rows[0][0]);
                               _objDetalleTablaComparativa.Precio = Convert.ToDecimal(row.Cells[column.Index].Value.ToString());
                                int diasColumn = column.Index + 1;
                                if (diasColumn < dgvIngresoTabla.Columns.Count && dgvIngresoTabla.Columns[diasColumn].Name.StartsWith("Tiempo_"))
                                {
                                    _objDetalleTablaComparativa.Dias = Convert.ToInt32(row.Cells[diasColumn].Value); //corregir posicion dias dinamico
                                }
                                _objDetalleTablaComparativa.Credito = 30;
                                _objDetalleTablaComparativa.IdDetalleTablaComparativa = iddeta;
                                _objDetalleTablaComparativa.IdSecuencial = Convert.ToInt32(row.Cells[0].Value);
                                _objDetalleTablaComparativa.IdTablaComparativa = _objTablaComparativa.IdTablaComparativa;
                                _objDetalleTablaComparativa.Estado = 1;

                                _sqlCommands.Add(_objDetalleTablaComparativa.InsertarDetalleTablaComparativaCommand());
                                iddeta++;
                            }
                            else
                            {
                                KryptonMessageBox.Show("Proveedor no encontrado, asegúrese de que el nombre es correcto.", "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                                return;
                            }
                        }                  

                    }                    
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

            
            string proveedor = txtProveedor.Text;
           

            string precioColumnName = "Precio_" + txtProveedor.Text;
            string tiempoColumnName = "Tiempo_" + txtProveedor.Text;


            if (dgvIngresoTabla.Columns.Contains(precioColumnName) || dgvIngresoTabla.Columns.Contains(tiempoColumnName))
            {
             
                KryptonMessageBox.Show("El proveedor '" + proveedor + "' ya ha sido agregado.", "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return; 
            }


            if (!dgvIngresoTabla.Columns.Contains(precioColumnName) && !dgvIngresoTabla.Columns.Contains(tiempoColumnName))
            {
                
                DataGridViewTextBoxColumn precioColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Precio (" + proveedor + ")",
                    Name = precioColumnName,
                    Width = 100,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight }
                };

                
                DataGridViewTextBoxColumn diasColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Entrega (" + proveedor + ")",
                    Name = tiempoColumnName,
                    Width = 100,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight }
                };

                
                dgvIngresoTabla.Columns.Add(precioColumn);
                dgvIngresoTabla.Columns.Add(diasColumn);
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
                

                DataTable dt = _objDetalleTablaComparativa.buscarDetalleTablaComparativa(TipoCon, id);
                DataTable dtPivot = new DataTable();
                dtPivot.Columns.Add("ITEMS", typeof(string));                             
                var proveedores = dt.AsEnumerable().Select(row => row["Proveedor"].ToString().Trim()).Distinct().ToList();

                foreach (var proveedor in proveedores)
                {
                    dtPivot.Columns.Add($"{proveedor} (Precio)", typeof(string));                    
                }

                foreach (var proveedor in proveedores)
                {                    
                    dtPivot.Columns.Add($"{proveedor} (Crédito)", typeof(string));                 
                }

                foreach (var proveedor in proveedores)
                {                 
                    dtPivot.Columns.Add($"{proveedor} (Días)", typeof(string));                   
                }

               
                var items = dt.AsEnumerable().Select(row => row["Producto/Servicio"].ToString().Trim()).Distinct().ToList();

                foreach (var item in items)
                {
                    DataRow newRow = dtPivot.NewRow();
                    newRow["ITEMS"] = item;

                    foreach (var proveedor in proveedores)
                    {                        
                        var data = dt.AsEnumerable()
                            .Where(row => row["Producto/Servicio"].ToString().Trim().Equals(item.Trim(), StringComparison.OrdinalIgnoreCase) &&
                                    row["Proveedor"].ToString().Trim().Equals(proveedor.Trim(), StringComparison.OrdinalIgnoreCase))
                                .FirstOrDefault();

                        

                        if (data != null )
                        {
                            //Precio
                            newRow[$"{proveedor} (Precio)"] = !string.IsNullOrEmpty(data["Precio"].ToString()) ? data["Precio"].ToString() : "0";
                            // Crédito
                            newRow[$"{proveedor} (Crédito)"] = !string.IsNullOrEmpty(data["Credito"].ToString()) ? data["Credito"].ToString() : "0";
                            // Días
                            newRow[$"{proveedor} (Días)"] = !string.IsNullOrEmpty(data["Dias"].ToString()) ? data["Dias"].ToString() : "0";                                             
                        }
                    }
                    dtPivot.Rows.Add(newRow);
                }
                dgvDetalleTablaComparativa.DataSource = dtPivot;             
                dgvDetalleTablaComparativa.AutoResizeColumns();

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
          
            
            string ruta = System.IO.Path.Combine(Path.GetTempPath(), "Temp.pdf");
            string rutaFacturaChart = Path.Combine(Path.GetTempPath(), "FacturaChart.png");
            string rutaCreditoChart = Path.Combine(Path.GetTempPath(), "CreditoChart.png");
            string rutaTiempoChart = Path.Combine(Path.GetTempPath(), "TiempoChart.png");

            CreateFacturaChart(rutaFacturaChart);
            CreateCreditoChart(rutaCreditoChart);
            CreateTiempoChart(rutaTiempoChart);

            pdfViewer1.Document?.Dispose();
            pdfViewer1.Document = null;

            
            try
            {
                var pdfstream = new MemoryStream();
                
                    using (var document = new Document(new iTextSharp.text.Rectangle(1000, 700)))
                    {
                        PdfWriter writer = PdfWriter.GetInstance(document, pdfstream);
                        writer.CloseStream = false;

                        document.Open();

                          

                            #region Estilos
                            string rutaImagen = Validaciones.NombreLogoNuevo(TipoCon, Application.StartupPath);
                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaImagen);
                            logo.ScaleToFit(60, 60);
                            iTextSharp.text.Font fuente12 = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK);
                            iTextSharp.text.Font fuente10 = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
                            iTextSharp.text.Font fuente8 = FontFactory.GetFont(FontFactory.HELVETICA, 8, BaseColor.BLACK);

                            foreach (DataGridViewColumn column in dgvDetalleTablaComparativa.Columns)
                            {
                                int columnWidth = dgvDetalleTablaComparativa.Columns[column.Index].GetPreferredWidth(DataGridViewAutoSizeColumnMode.DisplayedCells, true);
                                if (column.HeaderText == "ITEMS")
                                    itemsWidth = columnWidth;
                                else if (column.HeaderText.Contains("Precio"))
                                {
                                    facturaWidth = columnWidth;
                                }
                                else if (column.HeaderText.Contains("Crédito"))
                                    creditoWidth = columnWidth;
                                else if (column.HeaderText.Contains("Días"))
                                    diasWidth = columnWidth;
                            }

                            float totalWidth = (facturaWidth + creditoWidth + diasWidth + itemsWidth) - 40;
                            float tituloWidth = Convert.ToInt64((facturaWidth + creditoWidth + diasWidth) * 0.7);
                            float codigoWidth = Convert.ToInt64((facturaWidth + creditoWidth + diasWidth) * 0.3);

                            //Creacion de tabla encabezado
                            float headerHeight = 70;
                            PdfPTable headerTable = new PdfPTable(3);
                            headerTable.TotalWidth = totalWidth;


                            float[] columnWidthTabla0 = new float[] { itemsWidth, tituloWidth, codigoWidth };
                            headerTable.SetWidths(columnWidthTabla0);
                            headerTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            PdfPCell logoCell = new PdfPCell(logo) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE };
                            headerTable.AddCell(logoCell);

                            PdfPCell tituloCell = new PdfPCell(new Phrase("TABLA COMPARATIVA DE PRECIOS", fuente12)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE };
                            headerTable.AddCell(tituloCell);

                            PdfPCell rightCell = new PdfPCell() { HorizontalAlignment = Element.ALIGN_CENTER, FixedHeight = headerHeight, Border = PdfPCell.BOX };

                            rightCell.AddElement(new Phrase("Código: RE 3.6.1-3", fuente8));
                            rightCell.AddElement(new Phrase("Versión: 002", fuente8));
                            rightCell.AddElement(new Phrase("Página: 1 de 1", fuente8));
                            rightCell.AddElement(new Phrase("Fecha de Realización: 03/04/2013", fuente8));

                            headerTable.AddCell(rightCell);
                            headerTable.WriteSelectedRows(0, -1, 10, 690, writer.DirectContent);

                            //Creacion de tabla subencabezado

                            int subHeaderHeight = 20;
                            float subHeaderWidth = totalWidth - itemsWidth + 40;
                            float subHeaderColumnWidth = subHeaderWidth / 3;
                            PdfPTable SubHeader = new PdfPTable(4);
                            float[] columnWidthSubheader = new float[4];
                            columnWidthSubheader[0] = itemsWidth;
                            columnWidthSubheader[1] = subHeaderColumnWidth;
                            columnWidthSubheader[2] = subHeaderColumnWidth;
                            columnWidthSubheader[3] = subHeaderColumnWidth;

                            SubHeader.TotalWidth = totalWidth;
                            SubHeader.SetWidths(columnWidthSubheader);

                            PdfPCell SubHeaderCell1 = new PdfPCell(new Phrase("", fuente10)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, BackgroundColor = BaseColor.LIGHT_GRAY, FixedHeight = subHeaderHeight };
                            SubHeaderCell1.BorderWidthBottom = 0;
                            PdfPCell SubHeaderCell2 = new PdfPCell(new Phrase("FACTURACION", fuente10)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, BackgroundColor = BaseColor.LIGHT_GRAY, FixedHeight = subHeaderHeight };
                            PdfPCell SubHeaderCell3 = new PdfPCell(new Phrase("CRÉDITO DIAS", fuente10)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, BackgroundColor = BaseColor.LIGHT_GRAY, FixedHeight = subHeaderHeight };
                            PdfPCell SubHeaderCell4 = new PdfPCell(new Phrase("TIEMPO DE ENTREGA", fuente10)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, BackgroundColor = BaseColor.LIGHT_GRAY, FixedHeight = subHeaderHeight };

                            SubHeader.AddCell(SubHeaderCell1);
                            SubHeader.AddCell(SubHeaderCell2);
                            SubHeader.AddCell(SubHeaderCell3);
                            SubHeader.AddCell(SubHeaderCell4);

                            SubHeader.WriteSelectedRows(0, -1, 10, 620, writer.DirectContent);


                            //Creacion de tabla de datos
                            int numProveedores = (dgvDetalleTablaComparativa.ColumnCount - 1) / 3;
                            float totalProveedorWidth = totalWidth - itemsWidth;
                            float proveedorPrecioWidth = facturaWidth / numProveedores;
                            float proveedorCreditoWidth = creditoWidth / numProveedores;
                            float proveedorDiasWidth = diasWidth / numProveedores;



                            PdfPTable tabla2 = new PdfPTable(dgvDetalleTablaComparativa.ColumnCount); // table dgv;
                            float[] columns1WidthTabla2 = new float[dgvDetalleTablaComparativa.ColumnCount];
                            columns1WidthTabla2[0] = itemsWidth;

                            for (int i = 1; i < dgvDetalleTablaComparativa.ColumnCount; i++)
                            {
                                if (i % 3 == 1)
                                {
                                    columns1WidthTabla2[i] = proveedorPrecioWidth;
                                }
                                else if (i % 3 == 2)
                                {
                                    columns1WidthTabla2[i] = proveedorCreditoWidth;
                                }
                                else
                                {
                                    columns1WidthTabla2[i] = proveedorDiasWidth;
                                }

                            }

                            tabla2.SetWidths(columns1WidthTabla2);
                            tabla2.TotalWidth = totalWidth;
                            tabla2.HorizontalAlignment = Element.ALIGN_CENTER;

                            for (int i = 0; i < dgvDetalleTablaComparativa.ColumnCount; i++)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(dgvDetalleTablaComparativa.Columns[i].HeaderText, fuente10));
                                cell.BackgroundColor = BaseColor.WHITE;
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;

                                if (i == 0)
                                {
                                    cell.BorderWidthTop = 0;
                                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                                }

                                tabla2.AddCell(cell);
                            }


                            for (int row = 0; row < dgvDetalleTablaComparativa.Rows.Count; row++)
                            {
                                for (int col = 0; col < dgvDetalleTablaComparativa.ColumnCount; col++)
                                {
                                    if (dgvDetalleTablaComparativa[col, row].Value != null)
                                    {
                                        PdfPCell cell = new PdfPCell(new Phrase(dgvDetalleTablaComparativa[col, row].Value.ToString(), fuente8))
                                        {
                                            HorizontalAlignment = Element.ALIGN_LEFT,
                                            BackgroundColor = BaseColor.WHITE
                                        };
                                        tabla2.AddCell(cell);
                                    }
                                }
                            }

                            tabla2.WriteSelectedRows(0, -1, 10, 600, writer.DirectContent);

                            PdfPTable ObservacionesTable = new PdfPTable(2);

                            float[] columnWidthObservaciones = new float[2];
                            columnWidthObservaciones[0] = itemsWidth;
                            columnWidthObservaciones[1] = (facturaWidth + creditoWidth + diasWidth);
                            ObservacionesTable.SetWidths(columnWidthObservaciones);
                            ObservacionesTable.TotalWidth = totalWidth;

                            PdfPCell ObservacionesCell1 = new PdfPCell(new Phrase("Justificacion de Seleccion de Proveedor", fuente10)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, BackgroundColor = BaseColor.LIGHT_GRAY, FixedHeight = 20 };
                            PdfPCell ObservacionesCell2 = new PdfPCell(new Phrase(dgvTablaComparativa.CurrentRow.Cells[1].Value.ToString(), fuente10)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, FixedHeight = 20 };
                            ObservacionesTable.AddCell(ObservacionesCell1);
                            ObservacionesTable.AddCell(ObservacionesCell2);
                            float yTable2 = 600 - tabla2.TotalHeight;

                            ObservacionesTable.WriteSelectedRows(0, -1, 10, yTable2 - 5, writer.DirectContent);

                            float yObservacionesTable = yTable2 - 5 - ObservacionesTable.TotalHeight;

                            PdfPTable FooterTable = new PdfPTable(1);
                            float[] columnWidhtFooter = new float[1];
                            columnWidhtFooter[0] = itemsWidth;

                            FooterTable.SetWidths(columnWidhtFooter);
                            FooterTable.TotalWidth = totalWidth;

                            PdfPCell FooterCell1 = new PdfPCell(new Phrase("Realizado por: ", fuente10)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, FixedHeight = 20 };
                            FooterTable.AddCell(FooterCell1);
                            PdfPCell FooterCell2 = new PdfPCell(new Phrase("Ing. Karen Navarrete ", fuente10)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, FixedHeight = 20 };
                            FooterTable.AddCell(FooterCell2);


                            if (yObservacionesTable < 350)
                            {

                                document.NewPage();
                                iTextSharp.text.Image facturaImage = iTextSharp.text.Image.GetInstance(rutaFacturaChart);
                                facturaImage.ScaleToFit(275, 275);
                                facturaImage.SetAbsolutePosition(10, 100);
                                document.Add(facturaImage);

                                iTextSharp.text.Image creditoImage = iTextSharp.text.Image.GetInstance(rutaCreditoChart);
                                creditoImage.ScaleToFit(275, 275);
                                creditoImage.SetAbsolutePosition(310, 100);
                                document.Add(creditoImage);

                                iTextSharp.text.Image tiempoImage = iTextSharp.text.Image.GetInstance(rutaTiempoChart);
                                tiempoImage.ScaleToFit(275, 275);
                                tiempoImage.SetAbsolutePosition(610, 100);
                                document.Add(tiempoImage);

                                //float chartY = 100;

                                //AddChartToDocument(rutaFacturaChart, document, chartY);
                                //AddChartToDocument(rutaCreditoChart, document, chartY);
                                //AddChartToDocument(rutaTiempoChart, document, chartY);

                            }

                            else
                            {

                                //float chartYPosition = yObservacionesTable - 10; // 10 es un pequeño margen
                                //    AddChartToDocument(rutaFacturaChart, document, chartYPosition);
                                //    AddChartToDocument(rutaCreditoChart, document, chartYPosition + 300);
                                //    AddChartToDocument(rutaTiempoChart, document, chartYPosition + 600);                    

                                iTextSharp.text.Image facturaImage = iTextSharp.text.Image.GetInstance(rutaFacturaChart);
                                facturaImage.ScaleToFit(275, 275);
                                facturaImage.SetAbsolutePosition(10, 100);
                                document.Add(facturaImage);

                                iTextSharp.text.Image creditoImage = iTextSharp.text.Image.GetInstance(rutaCreditoChart);
                                creditoImage.ScaleToFit(275, 275);
                                creditoImage.SetAbsolutePosition(310, 100);
                                document.Add(creditoImage);

                                iTextSharp.text.Image tiempoImage = iTextSharp.text.Image.GetInstance(rutaTiempoChart);
                                tiempoImage.ScaleToFit(275, 275);
                                tiempoImage.SetAbsolutePosition(610, 100);
                                document.Add(tiempoImage);

                                

                            }

                        #endregion Estilos

                        document.Close();



                    }

                    
                    pdfstream.Seek(0, SeekOrigin.Begin);
                                        
                    pdfViewer1.Document = PdfiumViewer.PdfDocument.Load(pdfstream);
                    pdfViewer1.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
                    


            }

            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
          

            

        }

      


        private void AddChartToDocument(string chartPath, Document document, float yPosition)
        {
            iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(chartPath);
            chartImage.ScaleToFit(300, 300);
            chartImage.SetAbsolutePosition(10, yPosition);
            document.Add(chartImage);
        }

        private void CreateFacturaChart(string filePath)
        {

            DataTable dt = _objDetalleTablaComparativa.buscarDetalleTablaComparativa(TipoCon, Convert.ToInt32(dgvTablaComparativa.CurrentRow.Cells[0].Value.ToString()));
            DataTable dtPivot = new DataTable();
            dtPivot.Columns.Add("Proveedor", typeof(string)); // Providers on X-Axis

            // Get unique product/service names for series
            var productos = dt.AsEnumerable().Select(row => row["Producto/Servicio"].ToString().Trim()).Distinct().ToList();
            foreach (var producto in productos)
            {
                dtPivot.Columns.Add(producto, typeof(decimal)); // One series per product
            }

            var proveedores = dt.AsEnumerable().Select(row => row["Proveedor"].ToString().Trim()).Distinct().ToList();
            foreach (var proveedor in proveedores)
            {
                DataRow newRow = dtPivot.NewRow();
                newRow["Proveedor"] = proveedor; // X-axis label

                foreach (var producto in productos)
                {
                    var data = dt.AsEnumerable()
                        .FirstOrDefault(row => row["Producto/Servicio"].ToString().Trim().Equals(producto.Trim(), StringComparison.OrdinalIgnoreCase) &&
                                               row["Proveedor"].ToString().Trim().Equals(proveedor.Trim(), StringComparison.OrdinalIgnoreCase));

                    newRow[producto] = data != null ? Convert.ToDecimal(data["Precio"]) : 0;
                }
                dtPivot.Rows.Add(newRow);
            }

            
            var chart = new Chart
            {
                Width = 800,
                Height = 600
            };

            var chartArea = new ChartArea
            {
               AxisX = {  Interval = 1, LabelStyle = { Angle = -45 } }, // Providers on the X-axis
                AxisY = { Title = "Precio" }  // Y-axis for pricing
            };
            chart.ChartAreas.Add(chartArea);

            Dictionary<string, Color> proveedorColors = new Dictionary<string, Color>();
            Random rand = new Random();

            foreach (var proveedor in proveedores)
            {
                // Assign a random unique color to each supplier
                proveedorColors[proveedor] = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            }

            foreach (var proveedor in proveedores)
            {
                var series = new Series
                {
                    Name = proveedor, // Series name is the supplier
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column,
                    Color = proveedorColors[proveedor] // Assign supplier's unique color
                };

                foreach (var producto in productos)
                {
                    var dataPoint = new DataPoint
                    {
                        AxisLabel = $"{producto}", // Display only the product name on the column
                        YValues = new[] { Convert.ToDouble(dtPivot.Rows[proveedores.IndexOf(proveedor)][producto]) },
                        
                    };
                    series.Points.Add(dataPoint);
                }

                chart.Series.Add(series);
            }
            
            var legend = new Legend
            {
                Title = "Proveedores", // Title for the legend
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center,
                IsTextAutoFit = true
            };
            chart.Legends.Add(legend);


            chart.SaveImage(filePath, ChartImageFormat.Png);

        }

        private void CreateCreditoChart(string filePath)
        {

            DataTable dt = _objDetalleTablaComparativa.buscarDetalleTablaComparativa(TipoCon, Convert.ToInt32(dgvTablaComparativa.CurrentRow.Cells[0].Value.ToString()));
            DataTable dtPivot = new DataTable();
            dtPivot.Columns.Add("Proveedor", typeof(string)); // Providers on X-Axis

            // Get unique product/service names for series
            var productos = dt.AsEnumerable().Select(row => row["Producto/Servicio"].ToString().Trim()).Distinct().ToList();
            foreach (var producto in productos)
            {
                dtPivot.Columns.Add(producto, typeof(decimal)); // One series per product
            }

            var proveedores = dt.AsEnumerable().Select(row => row["Proveedor"].ToString().Trim()).Distinct().ToList();
            foreach (var proveedor in proveedores)
            {
                DataRow newRow = dtPivot.NewRow();
                newRow["Proveedor"] = proveedor; // X-axis label

                foreach (var producto in productos)
                {
                    var data = dt.AsEnumerable()
                        .FirstOrDefault(row => row["Producto/Servicio"].ToString().Trim().Equals(producto.Trim(), StringComparison.OrdinalIgnoreCase) &&
                                               row["Proveedor"].ToString().Trim().Equals(proveedor.Trim(), StringComparison.OrdinalIgnoreCase));

                    newRow[producto] = data != null ? Convert.ToDecimal(data["Credito"]) : 0;
                }
                dtPivot.Rows.Add(newRow);
            }


            var chart = new Chart
            {
                Width = 800,
                Height = 600
            };

            var chartArea = new ChartArea
            {
                AxisX = { Interval = 1, LabelStyle = { Angle = -45 } }, // Providers on the X-axis
                AxisY = { Title = "Credito" }  // Y-axis for pricing
            };
            chart.ChartAreas.Add(chartArea);

            Dictionary<string, Color> proveedorColors = new Dictionary<string, Color>();
            Random rand = new Random();

            foreach (var proveedor in proveedores)
            {
                // Assign a random unique color to each supplier
                proveedorColors[proveedor] = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            }

            foreach (var proveedor in proveedores)
            {
                var series = new Series
                {
                    Name = proveedor, // Series name is the supplier
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column,
                    Color = proveedorColors[proveedor] // Assign supplier's unique color
                };

                foreach (var producto in productos)
                {
                    var dataPoint = new DataPoint
                    {
                        AxisLabel = $"{producto}", // Display only the product name on the column
                        YValues = new[] { Convert.ToDouble(dtPivot.Rows[proveedores.IndexOf(proveedor)][producto]) },

                    };
                    series.Points.Add(dataPoint);
                }

                chart.Series.Add(series);
            }

            var legend = new Legend
            {
                Title = "Proveedores", // Title for the legend
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center,
                IsTextAutoFit = true
            };
            chart.Legends.Add(legend);


            chart.SaveImage(filePath, ChartImageFormat.Png);
        }


        private void CreateTiempoChart(string filePath)
        {
            DataTable dt = _objDetalleTablaComparativa.buscarDetalleTablaComparativa(TipoCon, Convert.ToInt32(dgvTablaComparativa.CurrentRow.Cells[0].Value.ToString()));
            DataTable dtPivot = new DataTable();
            dtPivot.Columns.Add("Proveedor", typeof(string)); // Providers on X-Axis

            // Get unique product/service names for series
            var productos = dt.AsEnumerable().Select(row => row["Producto/Servicio"].ToString().Trim()).Distinct().ToList();
            foreach (var producto in productos)
            {
                dtPivot.Columns.Add(producto, typeof(decimal)); // One series per product
            }

            var proveedores = dt.AsEnumerable().Select(row => row["Proveedor"].ToString().Trim()).Distinct().ToList();
            foreach (var proveedor in proveedores)
            {
                DataRow newRow = dtPivot.NewRow();
                newRow["Proveedor"] = proveedor; // X-axis label

                foreach (var producto in productos)
                {
                    var data = dt.AsEnumerable()
                        .FirstOrDefault(row => row["Producto/Servicio"].ToString().Trim().Equals(producto.Trim(), StringComparison.OrdinalIgnoreCase) &&
                                                                       row["Proveedor"].ToString().Trim().Equals(proveedor.Trim(), StringComparison.OrdinalIgnoreCase));

                    newRow[producto] = data != null ? Convert.ToDecimal(data["Dias"]) : 0;
                }
                dtPivot.Rows.Add(newRow);
            }

            var chart = new Chart
            {
                Width = 800,
                Height = 600
            };

            var chartArea = new ChartArea
            {
                AxisX = { Interval = 1, LabelStyle = { Angle = -45 } }, // Providers on the X-axis
                AxisY = { Title = "Dias de Entrega" }  // Y-axis for pricing
            };
            chart.ChartAreas.Add(chartArea);

            Dictionary<string, Color> proveedorColors = new Dictionary<string, Color>();
            Random rand = new Random();

            foreach (var proveedor in proveedores)
            {
                // Assign a random unique color to each supplier
                proveedorColors[proveedor] = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            }

            foreach (var proveedor in proveedores)
            {
                var series = new Series
                {
                    Name = proveedor, // Series name is the supplier
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column,
                    Color = proveedorColors[proveedor] // Assign supplier's unique color
                };

                foreach (var producto in productos)
                {
                    var dataPoint = new DataPoint
                    {
                        AxisLabel = $"{producto}", // Display only the product name on the column
                        YValues = new[] { Convert.ToDouble(dtPivot.Rows[proveedores.IndexOf(proveedor)][producto]) },

                    };
                    series.Points.Add(dataPoint);
                }

                chart.Series.Add(series);
            }

            var legend = new Legend
            {
                Title = "Proveedores", // Title for the legend
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center,
                IsTextAutoFit = true
            };
            chart.Legends.Add(legend);


            chart.SaveImage(filePath, ChartImageFormat.Png);


        }

        private void FrmTablaComparacionCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
