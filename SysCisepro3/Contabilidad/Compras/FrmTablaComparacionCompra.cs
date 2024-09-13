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
        public FrmTablaComparacionCompra()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();
            _objProveedores = new ClassProveedores();
            _objSecuencialItem = new ClassSecuencialItem();

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
    }
}
