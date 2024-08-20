using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.EstructuraEmpresa;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using Microsoft.Office.Interop.Excel;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using DataTable = System.Data.DataTable;
using Office = Microsoft.Office.Interop;
using Krypton.Toolkit;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmCuentasBancarias : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para administrar cuentas bancarias del personal
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmCuentasBancarias _instance;
        public static FrmCuentasBancarias Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmCuentasBancarias();
                return _instance;
            }
        }

        private readonly ClassBancos _objBancos;
        private readonly ClassCuentaPersonal _objCuentaPersonal;
        private FrmBuscarPersonal _frmBuscarPersonal;
        private readonly List<SqlCommand> _sqlCommands; 
        private int _estado;

        private FrmCuentasBancarias()
        {
            InitializeComponent();
            _estado = 0; 

            _sqlCommands = new List<SqlCommand>(); 
            _objBancos = new ClassBancos();
            _objCuentaPersonal = new ClassCuentaPersonal();
        }

        private void FrmCuentasBancarias_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            //toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            Label1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label24.BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label1.ForeColor = Color.White;
            Label24.ForeColor = Color.White;
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

            CargarBancosFiltro();
            CargarBancos();
        }
      
        private void CargarBancos()
        {
            try
            {
                cbxBanco.DataSource = _objBancos.SeleccionarRegistrosBancosRoles(TipoCon);
                cbxBanco.DisplayMember = "BANCO";
                cbxBanco.ValueMember = "ID_BANCO";
                if (((DataTable)cbxBanco.DataSource).Rows.Count > 0) cbxBanco.SelectedIndex = 0;
            }
            catch
            {
                cbxBanco.DataSource = null;
            }
        }

        private void CargarBancosFiltro()
        {
            try
            { 
                cbxFiltro.DataSource = _objBancos.SeleccionarRegistrosBancosRoles(TipoCon);
                cbxFiltro.DisplayMember = "BANCO";
                cbxFiltro.ValueMember = "ID_BANCO";
                if (((DataTable)cbxFiltro.DataSource).Rows.Count > 0) cbxFiltro.SelectedIndex = 0;
            }
            catch
            {
                cbxFiltro.DataSource = null;
            }

        }

        private void btnPersonalEntra_Click(object sender, EventArgs e)
        {
            _frmBuscarPersonal = new FrmBuscarPersonal { TipoCon = TipoCon, SoloActivos = true, Tipo = 0 };
            try
            {
                if (_frmBuscarPersonal.ShowDialog() != DialogResult.OK) return;
                if (_frmBuscarPersonal.dataGridView1.CurrentRow == null) return;

                txtIdPersonal.Text = _frmBuscarPersonal.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPersonal.Text = _frmBuscarPersonal.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtCargo.Text = _frmBuscarPersonal.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtArea.Text = _frmBuscarPersonal.dataGridView1.CurrentRow.Cells["NOMBRE_AREA"].Value.ToString();
            }
            catch
            {
                txtPersonal.Text = @"NO DEFINIDO";
                txtIdPersonal.Clear();
                txtCargo.Clear();
                txtArea.Clear();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            CargarAsignaciones(txtFiltro.Text.Trim(), 0);
        }

        private void CargarAsignaciones(string filtro, int selId)
        {
            try
            {
                var grupos = _objBancos.SeleccionarRegistrosBancosCuentasPersonal(TipoCon);
                var datos = _objBancos.SeleccionarRegistrosBancosCuentasPersonalFull(TipoCon, cbxFiltro.Text.Trim(), filtro);

                ListView1.Items.Clear();
                ListView1.Groups.Clear();

                foreach (var @group in from DataRow row in grupos.Rows select new ListViewGroup(row[1].ToString().Trim()))
                {
                    ListView1.Groups.Add(@group);
                }

                foreach (DataRow row in datos.Rows)
                {
                    var lst = new ListViewItem(row[0] != null ? row[0].ToString() : string.Empty, GetListViewGroup(row[6].ToString().Trim()));
                    for (var i = 1; i <= datos.Columns.Count - 1; i++) lst.SubItems.Add(row[i] != null ? row[i].ToString() : string.Empty);
                    ListView1.Items.Add(lst);
                }

                foreach (ColumnHeader column in ListView1.Columns) column.Width = -2;

                ListView1.Columns[0].Width = 0;
                ListView1.Columns[4].Width = 0;
                ListView1.Columns[5].Width = 0;
                ListView1.Columns[6].Width = 0;
                Label1.Text = (datos.Rows.Count + @" REGISTRO(S)");

                if (selId == 0) return;

                foreach (var row in ListView1.Items.Cast<ListViewItem>().Where(row => row.SubItems[0].Text.Trim().Equals(selId.ToString().Trim())))
                {
                    row.EnsureVisible();
                    ListView1.Items[row.Index].Selected = true;
                    ListView1.Select();
                    break;
                }

                btnModificar.Enabled = ListView1.Items.Count > 0 && ListView1.SelectedItems.Count > 0;
            }
            catch (Exception ex)
            {
                ListView1.Items.Clear();
                KryptonMessageBox.Show(@"Error al cargar detalles: " + ex.Message, "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private ListViewGroup GetListViewGroup(string name)
        {
            return ListView1.Groups.Cast<ListViewGroup>().FirstOrDefault(grupo => grupo.ToString().Trim().Equals(name.Trim()));
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            CargarAsignaciones(txtFiltro.Text.Trim(), 0);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CargarBancos();

            btnPersonalEntra.Enabled = true;

            txtIdPersonal.Clear();
            txtPersonal.Clear();
            txtCargo.Clear();
            txtArea.Clear();

            cbxBanco.Enabled = true;
            cbxBanco.SelectedIndex = 0;
            txtNumCuenta.Clear();
            cbxTipoCuenta.SelectedIndex = 0;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnAnular.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            _estado = 1;
        }

        private void cbxBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_estado == 0) return;
            if (cbxBanco.DataSource == null) return;
            if (cbxBanco.SelectedValue is DataRowView) return;
            if (cbxBanco.SelectedValue == null) return;
            txtNumCuenta.Clear();
            txtNumCuenta.Enabled = cbxBanco.SelectedIndex > 0;
            cbxTipoCuenta.Enabled = cbxBanco.SelectedIndex > 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnPersonalEntra.Enabled = false;

            txtIdPersonal.Clear();
            txtPersonal.Clear();
            txtCargo.Clear();
            txtArea.Clear();

            cbxBanco.Enabled = false;
            cbxBanco.SelectedIndex = 0;
            txtNumCuenta.Enabled = false;
            cbxTipoCuenta.Enabled = false;
            cbxTipoCuenta.SelectedIndex = 0;

            _estado = 0;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            CargarAsignaciones(txtFiltro.Text.Trim(), 0);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdPersonal.Text.Trim().Length == 0 || (int)cbxBanco.SelectedValue == 0 || string.IsNullOrEmpty(txtNumCuenta.Text))
            {
                KryptonMessageBox.Show(@"Debe definir los datos y tipo de cuenta para guardar!",
                    "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            if (KryptonMessageBox.Show(@"Desea guardar la cuenta actual?",
                   "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
               DialogResult.Yes) return;

            _sqlCommands.Clear();

            //if (_estado == 1)
            //{
            //    var data = _objBancos.SeleccionarRegistroBancoPorIdPersonal(TipoCon, Convert.ToInt32(txtIdPersonal.Text.Trim()));
            //    if (data.Rows.Count > 0)
            //    {
            //        KryptonMessageBox.Show(txtPersonal.Text + @" ya tiene una cuenta registrada en " + data.Rows[0][6] + @" (" + data.Rows[0][2] + @")", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}
            //else
            //{
            //    var data = _objBancos.SeleccionarRegistroBancoPorNumCuenta(TipoCon, txtNumCuenta.Text.Trim());
            //    if (data.Rows.Count > 0)
            //    {
            //        KryptonMessageBox.Show(@"La cuenta " + txtNumCuenta.Text + @" ya se encuentra registrada para " + data.Rows[0][13] + @" " + data.Rows[0][14] + @", en " + data.Rows[0][6], "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}

            if (_estado != 1)
            {
                var data = _objBancos.SeleccionarRegistroBancoPorNumCuenta(TipoCon, txtNumCuenta.Text.Trim());
                if (data.Rows.Count > 0)
                {
                    KryptonMessageBox.Show(@"La cuenta " + txtNumCuenta.Text + @" ya se encuentra registrada para " + data.Rows[0][13] + @" " + data.Rows[0][14] + @", en " + data.Rows[0][6], "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
                    return;
                }
            }

            _objCuentaPersonal.IdBanco = Convert.ToInt32(cbxBanco.SelectedValue);
            _objCuentaPersonal.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
            _objCuentaPersonal.NumCuenta = txtNumCuenta.Text;
            _objCuentaPersonal.Tipo = cbxTipoCuenta.Text;
            _sqlCommands.Add(_objCuentaPersonal.RegistrarNuevoCuentaBancoPersonalCommand());

            var user = Usuario.Datos.ToString();
            var nombre = "";
            if (_estado == 1)
                nombre = $"Nueva Cuenta Bancaria por: {user} - para usuario: {txtPersonal.Text.Trim()}";
            else if (_estado == 2)
                nombre = $"Modificacion de Cuenta Bancaria por: {user} - para usuario: {txtPersonal.Text.Trim()}";

            
            
            var res =  ComandosSql.ProcesarTransacciones(TipoCon,_sqlCommands, nombre) ;

            if ((bool)res[0])
            {
                btnPersonalEntra.Enabled = false;

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = true;
                btnCancelar.Enabled = false;

                cbxBanco.Enabled = false;
                txtNumCuenta.Enabled = false;
                cbxTipoCuenta.Enabled = false;

                txtFiltro.Clear();
                _estado = 0;

                CargarAsignaciones(string.Empty, Convert.ToInt32(txtIdPersonal.Text.Trim()));
            }
            KryptonMessageBox.Show((string)res[1], "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (ListView1.Items.Count == 0) return;
            if (ListView1.SelectedItems.Count == 0) return;

            if (KryptonMessageBox.Show(@"Desea quitar la cuenta actual?",
                   "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
               DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objCuentaPersonal.IdBanco = 0;
            _objCuentaPersonal.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
            _objCuentaPersonal.NumCuenta = "";
            _objCuentaPersonal.Tipo = "AHO";
            _sqlCommands.Add(_objCuentaPersonal.RegistrarNuevoCuentaBancoPersonalCommand());

            var user = Usuario.Datos.ToString();
            var nombre = $"CUENTA-BANCO ANULADA: {user}";
            var res =  ComandosSql.ProcesarTransacciones(TipoCon,_sqlCommands, nombre) ;

            if ((bool)res[0])
            {
                btnPersonalEntra.Enabled = false;

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = true;
                btnCancelar.Enabled = false;

                cbxBanco.Enabled = false;
                cbxBanco.SelectedIndex = 0;
                txtNumCuenta.Clear();
                txtNumCuenta.Enabled = false;
                cbxTipoCuenta.Enabled = false;
                cbxTipoCuenta.SelectedIndex = 0;

                txtFiltro.Clear();
                _estado = 0;

                CargarAsignaciones(string.Empty, Convert.ToInt32(txtIdPersonal.Text.Trim()));
            }
            KryptonMessageBox.Show((string)res[1], "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnPersonalEntra.Enabled = false;

            cbxBanco.Enabled = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnAnular.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            _estado = 2;
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_estado != 0) return;
            if (ListView1.Items.Count == 0) return;
            if (ListView1.SelectedItems.Count == 0) return;

            txtIdPersonal.Text = ListView1.SelectedItems[0].SubItems[0].Text;
            txtPersonal.Text = ListView1.SelectedItems[0].SubItems[2].Text;
            txtCargo.Text = ListView1.SelectedItems[0].SubItems[3].Text;
            txtArea.Text = ListView1.SelectedItems[0].SubItems[4].Text;

            cbxBanco.SelectedValue = ListView1.SelectedItems[0].SubItems[5].Text;
            txtNumCuenta.Text = ListView1.SelectedItems[0].SubItems[7].Text;
            cbxTipoCuenta.SelectedItem = ListView1.SelectedItems[0].SubItems[8].Text.Trim();
             
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (ListView1.Items.Count == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            { 
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "DESCUETNOS";

                var l = -1;
                for (var i = 0; i <= ListView1.Columns.Count - 1; i++) if (i == 1 || ListView1.Columns[i].Width > 1) l++;
                var ic = ValidationForms.NumToCharExcel(l);

                var rc = ListView1.Items.Count + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + "  -  DESCUETNOS";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = cbxFiltro.Text + "                 Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;
                var x = 1;
                for (var i = 0; i <= ListView1.Columns.Count - 1; i++)
                {
                    if (i != 1 && ListView1.Columns[i].Width < 1) continue;

                    worksheet.Cells[head, x] = ListView1.Columns[i].Text;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (ListViewItem row in ListView1.Items)
                {
                    var y = 1;
                    for (var j = 0; j <= ListView1.Columns.Count - 1; j++)
                    {
                        if (j != 1 && ListView1.Columns[j].Width < 1) continue;
                        worksheet.Cells[head, y] = row.SubItems[j].Text;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
                        worksheet.Cells[head, y].Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlContinuous;
                        y++;
                    }

                    head++;
                }

                head += 3;

                worksheet.Range["A" + head + ":F" + head].Merge();
                worksheet.Range["A" + head + ":F" + head].Value = Label1.Text;
                worksheet.Range["A" + head + ":F" + head].Font.Bold = true;
                worksheet.Range["A" + head + ":F" + head].Cells.HorizontalAlignment = XlHAlign.xlHAlignRight;
                worksheet.Range["A" + head + ":F" + head].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A" + head + ":F" + head].Font.Color = Color.White;
                worksheet.Range["A" + head + ":F" + head].Font.Size = 12;


                var position = (Range)worksheet.Cells[2, 7];
                Clipboard.SetImage(ValidationForms.Logo(TipoCon));
                worksheet.Paste(position);

                worksheet.Range["A1:" + ic + rc].Columns.AutoFit();
                app.DisplayAlerts = false;
                app.Visible = true;
                app.DisplayAlerts = true;
                KryptonMessageBox.Show(@"ARCHIVO generado correctamente!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarAsignaciones(txtFiltro.Text.Trim(), 0);
        }
    }
}