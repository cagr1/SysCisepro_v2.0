using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using iText.Kernel.Pdf.Canvas.Wmf;


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
            
        }

        private void dgvIngresoTabla_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var itemName = e.Control as TextBox;
            itemName.CharacterCasing = CharacterCasing.Upper;

            itemName.KeyPress -= Item_KeyPress;
            if (dgvIngresoTabla.CurrentCell.ColumnIndex == 1)
            {
                itemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                itemName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                itemName.AutoCompleteCustomSource = _objSecuencialItem.AutoCompletarSecuencial(TipoCon);
            }
            else if (dgvIngresoTabla.CurrentCell.ColumnIndex == 3)
            {
                itemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                itemName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                itemName.AutoCompleteCustomSource = _objProveedores.AutoCompletarProveedor(TipoCon);
            }
            else
            {
                itemName.AutoCompleteMode = AutoCompleteMode.None;
                itemName.AutoCompleteSource = AutoCompleteSource.None;
            }

            if(dgvIngresoTabla.CurrentCell.ColumnIndex == 4 || dgvIngresoTabla.CurrentCell.ColumnIndex == 5 || dgvIngresoTabla.CurrentCell.ColumnIndex == 6)
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
            var textBox = sender as TextBox;
                       
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

                if (e.ColumnIndex == 3 && dgvIngresoTabla.CurrentRow.Cells[3].Value != null)
                {
                    string se = dgvIngresoTabla.CurrentRow.Cells[3].Value.ToString();
                    var dts = _objProveedores.SeleccionarProveedorGeneralXNombre(TipoCon, se);
                    if (dts.Rows.Count > 0)
                    {
                        dgvIngresoTabla.CurrentRow.Cells[2].Value = dts.Rows[0][0].ToString();
                    }
                }
            }
        }

        private void btnNuevaTabla_Click(object sender, EventArgs e)
        {
            HabilitarRegistro(true);
        }

        private void HabilitarRegistro(bool estado)
        {
            dgvIngresoTabla.Enabled = estado;
            btnGuardarTabla.Enabled = estado;
            btnCancelar.Enabled = estado;
            txtObservaciones.Enabled = estado;
            dtpFecha.Enabled = estado;

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
            

            string user = Usuario.Datos.ToString();
            string nombreU = "Tabla Comparativa por: " + user;

            

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, nombreU);
            if ((bool)res[0])
            {                
                HabilitarRegistro(false);
                txtObservaciones.Clear();
                dgvIngresoTabla.Rows.Clear();
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

                    if (row.Cells[0].Value == null || row.Cells[2].Value == null || row.Cells[4].Value == null ||
                        row.Cells[5].Value == null || row.Cells[6].Value == null)
                        continue;

                    _objDetalleTablaComparativa.IdDetalleTablaComparativa = iddeta;
                    _objDetalleTablaComparativa.IdSecuencial = Convert.ToInt32(row.Cells[0].Value);
                    _objDetalleTablaComparativa.IdProveedor = Convert.ToInt32(row.Cells[2].Value);
                    _objDetalleTablaComparativa.IdTablaComparativa = _objTablaComparativa.IdTablaComparativa;
                    _objDetalleTablaComparativa.Precio = Convert.ToDecimal(row.Cells[4].Value);
                    _objDetalleTablaComparativa.Credito = Convert.ToInt32(row.Cells[5].Value);
                    _objDetalleTablaComparativa.Dias = Convert.ToInt32(row.Cells[6].Value);
                    _objDetalleTablaComparativa.Estado = 1;
                    _sqlCommands.Add(_objDetalleTablaComparativa.InsertarDetalleTablaComparativaCommand());
                    iddeta++;
                }

            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message, "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
    }
}
