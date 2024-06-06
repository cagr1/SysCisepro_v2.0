using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
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
    public partial class FrmDescuentos : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para visualizar descuentos del personal
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmDescuentos _instance;
        public static FrmDescuentos Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmDescuentos();
                return _instance;
            }
        }
        private readonly List<SqlCommand> _sqlCommands;
        private readonly ClassDescuentosPersonal _objRegistroDescuento;
        private readonly ClassHistorialLaboral _objHistorialLaboral;
        private FrmBuscarPersonal _frmBuscarPersonal;

        private int _estadoAccion;

        //private bool _inicio;

        private FrmDescuentos()
        {
            InitializeComponent();
            _estadoAccion = 0;
            _sqlCommands = new List<SqlCommand>();
            _objRegistroDescuento = new ClassDescuentosPersonal();
            _objHistorialLaboral = new ClassHistorialLaboral();
        }

        private void FrmDescuentos_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            
            toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            toolStrip2.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip2.ForeColor = Color.White;
            toolStrip3.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip3.ForeColor = Color.White;
            Label24.BackColor = ValidationForms.GetColorSistema(TipoCon);
            Label24.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = ValidationForms.GetColorSistema(TipoCon);
            switch (TipoCon)
            {
                case TipoConexion.Seportpac:
                    Icon = Resources.logo_s;
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = Settings.Default.ColorSeportpac;
                    break;
                case TipoConexion.Asenava:
                    Icon = Resources.logo_a;
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = Settings.Default.ColorAsenava;
                    break;
                default: // CISEPRO
                    Icon = Resources.logo_c;
                    dgvSecuencial.DefaultCellStyle.SelectionBackColor = Settings.Default.ColorCisepro;
                    break;
            }

            dtpFecha.Value = Usuario.Now(TipoCon);
            dtpFechaDesde.Value = dtpFecha.Value;
            dtpFechaHasta.Value = dtpFecha.Value;

            dateTimePicker1.Value = dtpFecha.Value;
            _estadoAccion = 1;
            CargarFiltro();
            CargarTipos();
            _estadoAccion = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            CargarAsignaciones(0);
        }

        private void AgregarGruposListView()
        {
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO PRÉSTAMO QUIROGRAFARIO"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO PRÉSTAMO HIPOTECARIO"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO EXTENSIÓN SALUD CÓNYUGE"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO ANTICIPO EMERGENTE"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO CAPASEG"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO ANTICIPOS VARIOS (IMP. REN.)"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO PRÉSTAMO EMPRESA"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO COMECSA"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO COMISARIATO"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO EQ. SEG. / BODEGA"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO PENSIÓN ALIMENTOS"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO PROP. PEN. ALIM. (XIII)"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO PROP. PEN. ALIM. (XIV)"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO MULTAS / ATRASOS"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO DIAS NO TRABAJADOS"));
            ListView1.Groups.Add(new ListViewGroup("DESCUENTO ALIMENTACIÓN (ALMUERZOS)"));
            ListView1.Groups.Add(new ListViewGroup("OTROS DESCUENTOS"));

            listView3.Groups.Add(new ListViewGroup("DESCUENTO PRÉSTAMO QUIROGRAFARIO"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO PRÉSTAMO HIPOTECARIO"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO EXTENSIÓN SALUD CÓNYUGE"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO ANTICIPO EMERGENTE"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO CAPASEG"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO ANTICIPOS VARIOS (IMP. REN.)"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO PRÉSTAMO EMPRESA"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO COMECSA"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO COMISARIATO"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO EQ. SEG. / BODEGA"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO PENSIÓN ALIMENTOS"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO PROP. PEN. ALIM. (XIII)"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO PROP. PEN. ALIM. (XIV)"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO MULTAS / ATRASOS"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO DIAS NO TRABAJADOS"));
            listView3.Groups.Add(new ListViewGroup("DESCUENTO ALIMENTACIÓN (ALMUERZOS)"));
            listView3.Groups.Add(new ListViewGroup("OTROS DESCUENTOS"));

            listView4.Groups.Add(new ListViewGroup("DESCUENTO PRÉSTAMO QUIROGRAFARIO"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO PRÉSTAMO HIPOTECARIO"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO EXTENSIÓN SALUD CÓNYUGE"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO ANTICIPO EMERGENTE"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO CAPASEG"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO ANTICIPOS VARIOS (IMP. REN.)"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO PRÉSTAMO EMPRESA"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO COMECSA"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO COMISARIATO"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO EQ. SEG. / BODEGA"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO PENSIÓN ALIMENTOS"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO PROP. PEN. ALIM. (XIII)"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO PROP. PEN. ALIM. (XIV)"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO MULTAS / ATRASOS"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO DIAS NO TRABAJADOS"));
            listView4.Groups.Add(new ListViewGroup("DESCUENTO ALIMENTACIÓN (ALMUERZOS)"));
            listView4.Groups.Add(new ListViewGroup("OTROS DESCUENTOS"));
        }

        private void CargarAsignaciones(long idsel)
        {
            if (_estadoAccion == 1) return;
            try
            {
                var tipo = cbxFiltro.Text;
                var fechaDesde = dtpFechaDesde.Value.Year + "-" + dtpFechaDesde.Value.Month + "-" + dtpFechaDesde.Value.Day + " 00:00:00";
                var fechaHasta = dtpFechaHasta.Value.Year + "-" + dtpFechaHasta.Value.Month + "-" + dtpFechaHasta.Value.Day + " 23:59:59";

                var datos = _objRegistroDescuento.SeleccionarDescuentosDatos(TipoCon, txtFiltro.Text.Trim(), fechaDesde, fechaHasta, string.Empty, tipo);

                ListView1.Items.Clear();
                ListView1.Groups.Clear();

                listView3.Items.Clear();
                listView3.Groups.Clear();

                listView4.Items.Clear();
                listView4.Groups.Clear();

                // grupos  
                AgregarGruposListView();

                double td = 0;
                foreach (DataRow row in datos.Rows)
                {
                    var lst = new ListViewItem(row[0].ToString().Trim(), GetListViewGroup(row[1].ToString().Trim()))
                    {
                        UseItemStyleForSubItems = false
                    };

                    td += Convert.ToDouble(row[6].ToString());

                    for (var i = 1; i <= datos.Columns.Count - 1; i++)
                    {
                        lst.SubItems.Add(row[i].ToString());
                        if (row[i].ToString().Equals("PROCESADO")) lst.SubItems[7].BackColor = Color.FromArgb(255, 34, 139, 34);
                    }
                    ListView1.Items.Add(lst);
                }

                foreach (var column in ListView1.Columns.Cast<ColumnHeader>().Where(column => column.DisplayIndex != 1 && column.DisplayIndex != 4 && column.DisplayIndex != 12))
                {
                    column.Width = -2;
                }

                Label1.Text = datos.Rows.Count + @" REGISTRO(S) - TOTAL DESCUENTOS $ " + td.ToString("N");


                Resumir();


                // descuentos rol-bodega y no descuentos 
                double tb = 0;
                double tn = 0;
                foreach (DataRow row in datos.Rows)
                {
                    if (_objRegistroDescuento.IdDescuentoInDescuentosRol(TipoCon, row[0].ToString().Trim(), fechaDesde, fechaHasta))
                    {
                        var lst = new ListViewItem(row[0].ToString().Trim(), GetListViewGroup3("DESCUENTO EQ. SEG. / BODEGA"))
                        {
                            UseItemStyleForSubItems = false
                        };
                        for (var i = 1; i <= datos.Columns.Count - 1; i++) lst.SubItems.Add(row[i].ToString());

                        tb += Convert.ToDouble(row[6].ToString());
                        listView3.Items.Add(lst);
                    }
                    else
                    {
                        var lst = new ListViewItem(row[0].ToString().Trim(), GetListViewGroup4(row[1].ToString().Trim()))
                        {
                            UseItemStyleForSubItems = false
                        };
                        for (var i = 1; i <= datos.Columns.Count - 1; i++) lst.SubItems.Add(row[i].ToString());

                        tn += Convert.ToDouble(row[6].ToString());
                        listView4.Items.Add(lst);
                    }
                }
                foreach (var column in listView3.Columns.Cast<ColumnHeader>().Where(column => column.DisplayIndex != 1 && column.DisplayIndex != 4 && column.DisplayIndex != 12))
                {
                    column.Width = -2;
                }
                foreach (var column in listView4.Columns.Cast<ColumnHeader>().Where(column => column.DisplayIndex != 1 && column.DisplayIndex != 4 && column.DisplayIndex != 12))
                {
                    column.Width = -2;
                }
                label17.Text = listView3.Items.Count + @" REGISTRO(S) - TOTAL DESCUENTOS $ " + tb.ToString("N");
                label19.Text = listView4.Items.Count + @" REGISTRO(S) - TOTAL DESCUENTOS $ " + tn.ToString("N");


                if (idsel == 0) return;

                foreach (var row in ListView1.Items.Cast<ListViewItem>().Where(row => row.SubItems[0].Text.Trim().Equals(idsel.ToString().Trim())))
                {
                    row.EnsureVisible();
                    ListView1.Items[row.Index].Selected = true;
                    ListView1.Select();
                    break;
                }
            }
            catch (Exception ex)
            {
                ListView1.Items.Clear();
                dataGridView1.Rows.Clear();
                MessageBox.Show(@"Error al cargar detalles: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private ListViewGroup GetListViewGroup(string nameg)
        {
            return ListView1.Groups.Cast<ListViewGroup>().FirstOrDefault(grupo => grupo.ToString().Trim().Equals(nameg.Trim()));
        }

        private ListViewGroup GetListViewGroup2(string nameg)
        {
            return listView2.Groups.Cast<ListViewGroup>().FirstOrDefault(grupo => grupo.ToString().Trim().Equals(nameg.Trim()));
        }

        private ListViewGroup GetListViewGroup3(string nameg)
        {
            return listView3.Groups.Cast<ListViewGroup>().FirstOrDefault(grupo => grupo.ToString().Trim().Equals(nameg.Trim()));
        }

        private ListViewGroup GetListViewGroup4(string nameg)
        {
            return listView4.Groups.Cast<ListViewGroup>().FirstOrDefault(grupo => grupo.ToString().Trim().Equals(nameg.Trim()));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _estadoAccion = 1;
            btnPersonalEntra.Enabled = true;
            txtIdPersonal.Clear();
            txtPersonal.Clear();
            txtCargo.Clear();
            txtArea.Clear();
            txtValor.Clear();
            txtCuota.Clear();
            txtValorPago.Clear();
            txtIdPrestamo.Clear();
            dtpFecha.Value = DateTime.Now;
            txtValor.Enabled = true;
            txtObservacion.Enabled = true;
            dtpFecha.Enabled = true;
            dtpRolPago.Enabled = true;
            cbxEstado.Enabled = false;
            cbxEstado.SelectedIndex = 0;
            cbmMotivo.Enabled = true;
            chkAnual.Enabled = true;
            chkAnual.Tag = null;
            txtCuota.Enabled = true;
            lblCuota.Visible = true;
            chkMensual.Enabled = true;
            //btngenerar.Enabled = true;



            CargarTipos();
            CargarFiltro();

            txtObservacion.Clear();
            chkAnual.Checked = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnAnular.Enabled = false;
            btnCancelar.Enabled = true;

            Label6.Text = @"EN ROL:";
            dtpRolPago.CustomFormat = @"MMMM yyyy";
        }

        private void CargarTipos()
        {
            try
            {
                var data = new DataTable();
                data.Columns.Add("TIPO");
                data.Columns.Add("VAL");

                data.Rows.Add("DESCUENTO PRÉSTAMO QUIROGRAFARIO", 0);
                data.Rows.Add("DESCUENTO PRÉSTAMO HIPOTECARIO", 1);
                data.Rows.Add("DESCUENTO EXTENSIÓN SALUD CÓNYUGE", 2);
                data.Rows.Add("DESCUENTO ANTICIPO EMERGENTE", 3);
                data.Rows.Add("DESCUENTO CAPASEG", 4);
                data.Rows.Add("DESCUENTO ANTICIPOS VARIOS (IMP. REN.)", 5);
                data.Rows.Add("DESCUENTO PRÉSTAMO EMPRESA", 6);
                data.Rows.Add("DESCUENTO COMECSA", 7);
                data.Rows.Add("DESCUENTO COMISARIATO", 8);
                data.Rows.Add("DESCUENTO EQ. SEG. / BODEGA", 9);
                data.Rows.Add("DESCUENTO MULTAS / ATRASOS", 10);
                data.Rows.Add("DESCUENTO DIAS NO TRABAJADOS", 16);
                data.Rows.Add("DESCUENTO PENSIÓN ALIMENTOS", 12);
                data.Rows.Add("DESCUENTO PROP. PEN. ALIM. (XIII)", 13);
                data.Rows.Add("DESCUENTO PROP. PEN. ALIM. (XIV)", 14);
                data.Rows.Add("DESCUENTO ALIMENTACIÓN (ALMUERZOS)", 15);
                data.Rows.Add("OTROS DESCUENTOS", 11);

                cbmMotivo.DataSource = data;
                cbmMotivo.DisplayMember = data.Columns["TIPO"].ToString();
                cbmMotivo.ValueMember = data.Columns["VAL"].ToString();
                cbmMotivo.DropDownWidth = 300;
                cbmMotivo.SelectedIndex = 0;
            }
            catch
            {
                cbmMotivo.DataSource = null;
            }
        }

        private void CargarFiltro()
        {
            try
            {
                var data = new DataTable();
                data.Columns.Add("TIPO");
                data.Columns.Add("VAL");

                data.Rows.Add("-- TODOS LOS DESCUENTOS --", -1);
                data.Rows.Add("DESCUENTO PRÉSTAMO QUIROGRAFARIO", 0);
                data.Rows.Add("DESCUENTO PRÉSTAMO HIPOTECARIO", 1);
                data.Rows.Add("DESCUENTO EXTENSIÓN SALUD CÓNYUGE", 2);
                data.Rows.Add("DESCUENTO ANTICIPO EMERGENTE", 3);
                data.Rows.Add("DESCUENTO CAPASEG", 4);
                data.Rows.Add("DESCUENTO ANTICIPOS VARIOS (IMP. REN.)", 5);
                data.Rows.Add("DESCUENTO PRÉSTAMO EMPRESA", 6);
                data.Rows.Add("DESCUENTO COMECSA", 7);
                data.Rows.Add("DESCUENTO COMISARIATO", 8);
                data.Rows.Add("DESCUENTO EQ. SEG. / BODEGA", 9);
                data.Rows.Add("DESCUENTO MULTAS / ATRASOS", 10);
                data.Rows.Add("DESCUENTO DIAS NO TRABAJADOS", 16);
                data.Rows.Add("DESCUENTO PENSIÓN ALIMENTOS", 12);
                data.Rows.Add("DESCUENTO PROP. PEN. ALIM. (XIII)", 13);
                data.Rows.Add("DESCUENTO PROP. PEN. ALIM. (XIV)", 14);
                data.Rows.Add("DESCUENTO ALIMENTACIÓN (ALMUERZOS)", 15);
                data.Rows.Add("OTROS DESCUENTOS", 11);

                cbxFiltro.DataSource = data;
                cbxFiltro.DisplayMember = data.Columns["TIPO"].ToString();
                cbxFiltro.ValueMember = data.Columns["VAL"].ToString();
                cbxFiltro.DropDownWidth = 300;
                cbxFiltro.SelectedIndex = 0;
            }
            catch
            {
                cbxFiltro.DataSource = null;
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = @"Está seguro que desea anular el registro seleccionado?";
                if (chkAnual.Checked) msg = @"El descuento seleccionado corresponde a un débito anual. Está seguro que desea anular los descuentos registrados?";

                if (MessageBox.Show(msg, @"MENSAJE DEL SISTEMA",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                _sqlCommands.Clear();

                if (chkAnual.Tag != null)
                {
                    _objRegistroDescuento.Anual = chkAnual.Tag.ToString();
                    _sqlCommands.Add(_objRegistroDescuento.AnularRegistroDescuentoCommandByAnual());
                }
                else
                {
                    _objRegistroDescuento.IdRegistro = Convert.ToInt32(dtpFecha.Tag);
                    _sqlCommands.Add(_objRegistroDescuento.AnularRegistroDescuentoCommand());
                }

                var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "ANULAR DESCUENTO");

                if ((bool)res[0])
                {
                    btnPersonalEntra.Enabled = false;
                    txtObservacion.Enabled = false;
                    dtpFecha.Enabled = false;
                    cbxEstado.Enabled = false;
                    dtpRolPago.Enabled = false;
                    txtValor.Enabled = false;
                    cbmMotivo.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnAnular.Enabled = false;
                    btnCancelar.Enabled = false;
                    chkAnual.Enabled = false;
                    chkAnual.Tag = null;
                    txtValorPago.Enabled = false;
                    txtCuota.Enabled = false;
                    chkMensual.Enabled = false;
                    lblCuota.Visible = false;

                    Label6.Text = @"EN ROL:";
                    dtpRolPago.CustomFormat = @"MMMM yyyy";
                    txtFiltro.Clear();

                    _estadoAccion = 0;

                    //CargarAsignaciones(0);
                }
                MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"ERROR AL GUARDAR PERMISO DE TRABAJO: " + ex.Message, @"MENSAJE DE VALIDACIÓN",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnPersonalEntra.Enabled = false;
            txtIdPersonal.Clear();
            txtPersonal.Clear();
            txtCargo.Clear();
            txtArea.Clear();
            txtValor.Clear();
            txtValor.Enabled = false;
            dtpRolPago.Enabled = false;
            dtpFecha.Enabled = false;
            cbxEstado.Enabled = false;
            cbxEstado.SelectedIndex = 0;
            cbmMotivo.Enabled = false;
            cbmMotivo.SelectedIndex = 0;
            txtObservacion.Enabled = false;
            dtpFecha.Tag = null;
            txtObservacion.Clear();
            chkAnual.Checked = false;
            chkAnual.Enabled = false;
            chkAnual.Tag = null;
            txtCuota.Enabled = false;
            lblCuota.Visible = false;
            txtValorPago.Enabled = false;
            chkMensual.Enabled = false;
            chkMensual.Checked = false;
            //btngenerar.Enabled = false;
            txtIdPrestamo.Clear();
            txtValorPago.Clear();
            txtCuota.Clear();

            Label6.Text = @"EN ROL:";
            dtpRolPago.CustomFormat = @"MMMM yyyy";

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = false;
            btnCancelar.Enabled = false;

            _estadoAccion = 0;
            //CargarAsignaciones(0);
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            CargarAsignaciones(0);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validaciones.IsNumeroDecimal(e.KeyChar, txtValor.Text.Trim());
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_estadoAccion != 0) return;
            if (ListView1.Items.Count == 0) return;
            if (ListView1.SelectedItems.Count == 0) return;
            try
            {
                dtpFecha.Tag = ListView1.SelectedItems[0].SubItems[0].Text;
                txtIdPersonal.Text = ListView1.SelectedItems[0].SubItems[4].Text;
                txtPersonal.Text = ListView1.SelectedItems[0].SubItems[3].Text;
                txtCargo.Text = ListView1.SelectedItems[0].SubItems[5].Text;
                txtArea.Text = "";
                cbmMotivo.Text = ListView1.SelectedItems[0].SubItems[1].Text;
                txtObservacion.Text = ListView1.SelectedItems[0].SubItems[8].Text;
                dtpFecha.Value = Convert.ToDateTime(ListView1.SelectedItems[0].SubItems[2].Text);
                txtValor.Text = ListView1.SelectedItems[0].SubItems[6].Text;
                cbxEstado.Text = ListView1.SelectedItems[0].SubItems[7].Text;

                dtpRolPago.Value = new DateTime(Convert.ToInt32(ListView1.SelectedItems[0].SubItems[10].Text), Convert.ToInt32(ListView1.SelectedItems[0].SubItems[9].Text), 1, 0, 0, 0);

                if (ListView1.SelectedItems[0].SubItems[12].Text.StartsWith("1 - "))
                {
                    chkAnual.Checked = true;
                    Label6.Text = @"EN AÑO:";
                    dtpRolPago.CustomFormat = @"yyyy";
                    chkAnual.Tag = ListView1.SelectedItems[0].SubItems[12].Text;
                }
                else
                {
                    chkAnual.Checked = false;
                    Label6.Text = @"EN ROL:";
                    dtpRolPago.CustomFormat = @"MMMM yyyy";
                    chkAnual.Tag = null;
                }


                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = true;
                btnCancelar.Enabled = false;
            }
            catch
            {
                dtpFecha.Tag = null;
                txtIdPersonal.Clear();
                txtPersonal.Clear();
                txtCargo.Clear();
                txtArea.Clear();
                cbmMotivo.SelectedIndex = 0;
                txtObservacion.Clear();
                dtpFecha.Value = DateTime.Now;
                dtpRolPago.Value = DateTime.Now;
                txtValor.Clear();
                cbxEstado.SelectedIndex = 0;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = false;
                btnCancelar.Enabled = false;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var msg = @"Está seguro que desea guardar los cambios realizados?";
            if (chkMensual.Checked) msg = @"El descuento se procesara mensualmente, Está seguro que desea guardar los cambios realizados?";
            if (chkAnual.Checked) msg = @"El descuento se procesará para cada mes del año seleccionado. Está seguro que desea guardar los cambios realizados?";

            if (MessageBox.Show(msg, @"MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (txtIdPersonal.Text.Trim().Length == 0 || string.IsNullOrEmpty(cbmMotivo.Text) || txtValor.Text.Trim().Length == 0 )
            {
                MessageBox.Show(@"Debe definir los datos y tipo de movimiento para guardar!", @"MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //if (int.Parse(txtCuota.Text) < 1 || int.Parse(txtCuota.Text) > 11)
            //{
            //    MessageBox.Show(@"Solo valido hasta 11 meses!", @"MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //if (int.Parse(txtCuota.Text) < 1 || int.Parse(txtCuota.Text) > 24)
            //{
            //    MessageBox.Show(@"Solo valido hasta 24 meses!", @"MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
            _sqlCommands.Clear();

            var fecha = dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day + " 00:00:00";
            var iddesc = _objRegistroDescuento.BuscarMayorIdRegistroDescuento(TipoCon) + 1;

            // variables de detalles de prestamo

            var idpres = _objRegistroDescuento.BuscarMayorIdPrestamo(TipoCon) + 1;
            var iddetapres = _objRegistroDescuento.BuscarMayorIdDetallePrestamo(TipoCon) + 1;



            var fec = dtpFecha.Value;

            if (txtValorPago.Text.Trim().Length == 0 || txtCuota.Text.Trim().Length == 0)
            {
                var ValorPago = 1;
                var Couta = 1;
                txtValorPago.Text = ValorPago.ToString();
                txtCuota.Text = Couta.ToString();
            }


            _objRegistroDescuento.capital_pagado = 0.0;
            _objRegistroDescuento.capital_restante = double.Parse(txtValor.Text);
            _objRegistroDescuento.cuota = double.Parse(txtValorPago.Text);
            
            // variables mensuales 

            if (chkMensual.Checked)
            {
                //var fecha = Convert.ToDateTime(dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day + dtpFecha.Value.Minute);

                var fecha1 = dtpFecha.Value;
                var idi = iddesc;
                

                for (var i = 1; i <= int.Parse(txtCuota.Text); i++)
                {
                    //registro descuento rol 

                    _objRegistroDescuento.IdRegistro = iddesc;
                    _objRegistroDescuento.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
                    _objRegistroDescuento.Fecha = fecha1;
                    _objRegistroDescuento.Estado = 1;
                    _objRegistroDescuento.Procesado = cbxEstado.SelectedIndex;
                    _objRegistroDescuento.Mes = fecha1.Month;
                    _objRegistroDescuento.Anio = fecha1.Year;
                    _objRegistroDescuento.IdRol = 0;
                    _objRegistroDescuento.Tipo = Convert.ToInt32(cbmMotivo.SelectedValue);
                    _objRegistroDescuento.Observacion = txtObservacion.Text.Trim() +@" " + i + @" DE " + txtCuota.Text + @" MESES";
                    _objRegistroDescuento.Valor = Convert.ToDouble(txtValorPago.Text);
                    _objRegistroDescuento.Tipot = cbmMotivo.Text.Trim()  ;
                    _objRegistroDescuento.Idprog = 0;
                    _objRegistroDescuento.Anual = "2 - " + idi;
                    _sqlCommands.Add(_objRegistroDescuento.NuevoRegistroDescuentoCommands());

                    fecha1 = fecha1.AddMonths(1);
                    iddesc += 1;

                    //registro detalles prestamo
                    _objRegistroDescuento.IdDetallePrestamo = iddetapres;
                    _objRegistroDescuento.periodo = i;
                    _objRegistroDescuento.Fecha = fecha1;
                    _objRegistroDescuento.capital_pagado += _objRegistroDescuento.cuota;
                    _objRegistroDescuento.capital_restante -= _objRegistroDescuento.cuota;
                    //_objRegistroDescuento.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
                    _objRegistroDescuento.IdPrestamo = idpres;
                    //fecha1 = fecha1.AddMonths(1);
                    iddetapres += 1;
                    _sqlCommands.Add(_objRegistroDescuento.NuevoDetallePrestamo());

                }

                _objHistorialLaboral.DetalleHistoriaLaboral = "REGISTRA DESCUENTO MENSUAL DE " + txtValor.Text.Trim() + " EN ROL " +
                                                            dtpRolPago.Value.Year + " POR CONCEPTO DE: " + cbmMotivo.Text.Trim() + ", " +
                                                            txtObservacion.Text.Trim();

                
                                
                // registro detalle prestamo
                //idpres = Int32.Parse(txtIdPrestamo.Text);
                txtIdPrestamo.Text = idpres.ToString();
                _objRegistroDescuento.IdPrestamo = idpres;
                _objRegistroDescuento.Fecha = Convert.ToDateTime(fec);
                _objRegistroDescuento.plazo = Convert.ToInt32(txtCuota.Text);
                _objRegistroDescuento.cuota = Convert.ToDouble(txtValorPago.Text);
                _objRegistroDescuento.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
                _objRegistroDescuento.monto = Convert.ToDouble(txtValor.Text);
                _sqlCommands.Add(_objRegistroDescuento.NuevoPrestamo());

            }


            else
            {

                // registro detalles prestamo
                _objRegistroDescuento.IdPrestamo = idpres;
                _objRegistroDescuento.Fecha = Convert.ToDateTime(fec);
                _objRegistroDescuento.plazo = Convert.ToInt32(txtCuota.Text);
                //_objRegistroDescuento.cuota = Convert.ToDouble(txtValorPago.Text);
                _objRegistroDescuento.cuota = 1;
                _objRegistroDescuento.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
                _objRegistroDescuento.monto = Convert.ToDouble(txtValor.Text);
                _sqlCommands.Add(_objRegistroDescuento.NuevoPrestamo());

                // variables anuales

                if (chkAnual.Checked)
                {
                    var fec1 = Convert.ToDateTime(dtpFecha.Value.Year + "-01-" + dtpFecha.Value.Day + " 00:00:00");
                    var idi = iddesc;
                    for (var i = 1; i < 13; i++) // para todo el año
                    {
                        _objRegistroDescuento.IdRegistro = iddesc;
                        _objRegistroDescuento.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
                        _objRegistroDescuento.Fecha = fec1;
                        _objRegistroDescuento.Estado = 1;
                        _objRegistroDescuento.Procesado = cbxEstado.SelectedIndex;
                        _objRegistroDescuento.Mes = i;
                        _objRegistroDescuento.Anio = dtpRolPago.Value.Year;
                        _objRegistroDescuento.IdRol = 0;
                        _objRegistroDescuento.Tipo = Convert.ToInt32(cbmMotivo.SelectedValue);
                        _objRegistroDescuento.Observacion = txtObservacion.Text.Trim();
                        _objRegistroDescuento.Valor = Convert.ToDouble(txtValor.Text);
                        _objRegistroDescuento.Tipot = cbmMotivo.Text.Trim();
                        _objRegistroDescuento.Idprog = 0;
                        _objRegistroDescuento.Anual = "1 - " + idi;
                        _sqlCommands.Add(_objRegistroDescuento.NuevoRegistroDescuentoCommands());

                        fec1 = fec1.AddMonths(1);
                        iddesc += 1;
                    }

                    _objHistorialLaboral.DetalleHistoriaLaboral = "REGISTRA DESCUENTO ANUAL DE " + txtValor.Text.Trim() + " EN ROL " +
                                                                dtpRolPago.Value.Year + " POR CONCEPTO DE: " + cbmMotivo.Text.Trim() + ", " +
                                                                txtObservacion.Text.Trim();
                }

                else
                {
                    _objRegistroDescuento.IdRegistro = iddesc;
                    _objRegistroDescuento.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
                    _objRegistroDescuento.Fecha = Convert.ToDateTime(fecha);
                    _objRegistroDescuento.Estado = 1;
                    _objRegistroDescuento.Procesado = cbxEstado.SelectedIndex;
                    _objRegistroDescuento.Mes = dtpRolPago.Value.Month;
                    _objRegistroDescuento.Anio = dtpRolPago.Value.Year;
                    _objRegistroDescuento.IdRol = 0;
                    _objRegistroDescuento.Tipo = Convert.ToInt32(cbmMotivo.SelectedValue);
                    _objRegistroDescuento.Observacion = txtObservacion.Text.Trim();
                    _objRegistroDescuento.Valor = Convert.ToDouble(txtValor.Text);
                    _objRegistroDescuento.Tipot = cbmMotivo.Text.Trim();
                    _objRegistroDescuento.Idprog = 0;
                    _objRegistroDescuento.Anual = "0";
                    _sqlCommands.Add(_objRegistroDescuento.NuevoRegistroDescuentoCommands());

                    _objHistorialLaboral.DetalleHistoriaLaboral = "REGISTRA DESCUENTO DE " + txtValor.Text.Trim() + " EN ROL " +
                                                              dtpRolPago.Value.Month + "-" + dtpRolPago.Value.Year +
                                                              " POR CONCEPTO DE: " + cbmMotivo.Text.Trim() + ", " +
                                                              txtObservacion.Text.Trim();



                }

            }
            


           

           

            // variables anuales

            _objHistorialLaboral.IdHistoriaLaboral = _objHistorialLaboral.BuscarMayorIdHistoriaLaboral(TipoCon) + 1;
            _objHistorialLaboral.FechaHistoriaLaboral = _objRegistroDescuento.Fecha;
            _objHistorialLaboral.EstadoHistoriaLaboral = 1;
            _objHistorialLaboral.IdPersonalHistoriaLaboral = Convert.ToInt32(txtIdPersonal.Text.Trim());
            _objHistorialLaboral.IdSitioHistoriaLaboral = string.Empty;
            _sqlCommands.Add(_objHistorialLaboral.RegistrarNuevoHistorialLaboralCommand());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR DESCUENTO");

            if ((bool)res[0])
            {
                btnPersonalEntra.Enabled = false;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = true;
                btnCancelar.Enabled = false;
                dtpFecha.Enabled = false;
                txtValor.Enabled = false;
                cbxEstado.Enabled = false;
                dtpRolPago.Enabled = false;
                txtObservacion.Enabled = false;
                cbmMotivo.Enabled = false;
                chkAnual.Enabled = false;
                chkAnual.Tag = null;
                txtCuota.Enabled = false;
                txtValorPago.Enabled = false;
                lblCuota.Visible = false;

                txtFiltro.Clear();

                _estadoAccion = 0;
                //CargarAsignaciones(_objRegistroDescuento.IdRegistro);
            }
            MessageBox.Show((string)res[1], "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPersonalEntra_Click(object sender, EventArgs e)
        {
            _frmBuscarPersonal = new FrmBuscarPersonal { TipoCon = TipoCon, SoloActivos = false, Tipo = 0 };
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

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (ListView1.Items.Count == 0)
            {
                MessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "DESCUENTOS";

                var l = -1;
                for (var i = 0; i <= ListView1.Columns.Count - 1; i++) if (i == 1 || ListView1.Columns[i].Width > 1) l++;
                var ic = ValidationForms.NumToCharExcel(l);

                var rc = ListView1.Items.Count + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - DESCUENTOS GENERAL";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = cbxFiltro.Text + " DEL " + dtpFechaDesde.Value.ToShortDateString() + " AL " + dtpFechaHasta.Value.ToShortDateString() + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
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

                        worksheet.Cells[head, y] = j == 2
                            ? Convert.ToDateTime(row.SubItems[j].Text).ToString("yyyy/MM/dd")
                            : row.SubItems[j].Text;

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
                MessageBox.Show(@"ARCHIVO generado correctamente!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            CargarAsignaciones(0);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var data = _objRegistroDescuento.SeleccionarPersonalNoRolDescuentos(TipoCon, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);

                dgvSecuencial.DataSource = data;
                if (data.Rows.Count == 0) return;

                dgvSecuencial.Columns[0].HeaderText = "ID";
                dgvSecuencial.Columns[0].Width = 50;
                dgvSecuencial.Columns[1].HeaderText = "NÓMINA";
                dgvSecuencial.Columns[1].Width = 250;
                dgvSecuencial.Columns[2].HeaderText = "FECHA REGISTRO";
                dgvSecuencial.Columns[2].Width = 90;
                dgvSecuencial.Columns[2].DefaultCellStyle.Format = "d";
                dgvSecuencial.Columns[3].Visible = false;
                dgvSecuencial.Columns[4].HeaderText = "OBSERVACIÓN";
                dgvSecuencial.Columns[4].Width = 500;

                dgvSecuencial.AutoResizeRows();
            }
            catch
            {
                dgvSecuencial.DataSource = null;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (dgvSecuencial.Rows.Count == 0)
            {
                MessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "DESCUENTOS";

                var l = -1;
                for (var i = 0; i <= dgvSecuencial.Columns.Count - 1; i++) if (dgvSecuencial.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l);

                var rc = ListView1.Items.Count + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - PERSONAL ";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = cbxFiltro.Text + " DEL " + dtpFechaDesde.Value.ToShortDateString() + " AL " + dtpFechaHasta.Value.ToShortDateString() + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
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

                        worksheet.Cells[head, y] = j == 2
                            ? Convert.ToDateTime(row.SubItems[j].Text).ToString("yyyy/MM/dd")
                            : row.SubItems[j].Text;

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
                MessageBox.Show(@"ARCHIVO generado correctamente!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Resumir()
        {
            //if (!_inicio) return;
            try
            {
                var fechaDesde = dtpFechaDesde.Value.Year + "-" + dtpFechaDesde.Value.Month + "-" + dtpFechaDesde.Value.Day + " 00:00:00";
                var fechaHasta = dtpFechaHasta.Value.Year + "-" + dtpFechaHasta.Value.Month + "-" + dtpFechaHasta.Value.Day + " 23:59:59";

                // resumen
                double co, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17;
                double tt, t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0, t6 = 0, t7 = 0, t8 = 0, t9 = 0, t10 = 0, t11 = 0, t12 = 0, t13 = 0, t14 = 0, t15 = 0, t16 = 0, t17 = 0;

                dataGridView1.Rows.Clear();

                var resumen = _objRegistroDescuento.SeleccionarDescuentosDatos1(TipoCon, txtFiltro.Text.Trim(), fechaDesde, fechaHasta);
                foreach (DataRow row in resumen.Rows)
                {
                    d1 = Convert.ToDouble(row[3]);
                    d2 = Convert.ToDouble(row[4]);
                    d3 = Convert.ToDouble(row[5]);
                    d4 = Convert.ToDouble(row[6]);
                    d5 = Convert.ToDouble(row[7]);
                    d6 = Convert.ToDouble(row[8]);
                    d7 = Convert.ToDouble(row[3]);
                    d8 = Convert.ToDouble(row[10]);
                    d9 = Convert.ToDouble(row[11]);
                    d10 = Convert.ToDouble(row[12]);
                    d11 = Convert.ToDouble(row[13]);
                    d12 = Convert.ToDouble(row[14]);
                    d13 = Convert.ToDouble(row[15]);
                    d14 = Convert.ToDouble(row[16]);
                    d15 = Convert.ToDouble(row[17]);
                    d16 = Convert.ToDouble(row[18]);
                    d17 = Convert.ToDouble(row[19]);

                    co = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10 + d11 + d12 + d13 + d14 + d15 + d16 + d17;
                    t1 += d1;
                    t2 += d2;
                    t3 += d3;
                    t4 += d4;
                    t5 += d5;
                    t6 += d6;
                    t7 += d7;
                    t8 += d8;
                    t9 += d9;
                    t10 += d10;
                    t11 += d11;
                    t12 += d12;
                    t13 += d13;
                    t14 += d14;
                    t15 += d15;
                    t16 += d16;
                    t17 += d17;

                    dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7],
                        row[8], row[9], row[10], row[11], row[12], row[13], row[14], row[15], row[16], row[17], row[18], row[19], co.ToString("N"));

                }
                tt = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14 + t15 + t16 + t17;

                dataGridView1.Rows.Add(string.Empty, string.Empty, "TOTAL DE MULTAS", t1.ToString("N"), t2.ToString("N"), t3.ToString("N"), t4.ToString("N"), t5.ToString("N"),
                         t6.ToString("N"), t7.ToString("N"), t8.ToString("N"), t9.ToString("N"), t10.ToString("N"), t11.ToString("N"), t12.ToString("N"), t13.ToString("N"), t14.ToString("N"), t15.ToString("N"), t16.ToString("N"), t17.ToString("N"), tt.ToString("N"));

                dataGridView1.Columns[dataGridView1.ColumnCount - 1].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5f, FontStyle.Bold);
                dataGridView1.Rows[dataGridView1.RowCount - 1].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5f, FontStyle.Bold);

                dataGridView1.AutoResizeRows();
                label8.Text = dataGridView1.RowCount + @" REGISTRO(S)";
            }
            catch (Exception ex)
            {
                ListView1.Items.Clear();
                dataGridView1.Rows.Clear();
                MessageBox.Show(@"Error al cargar resumen: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "DESCUENTOS";

                var l = -1;
                for (var i = 0; i <= dataGridView1.Columns.Count - 1; i++) if (dataGridView1.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l);

                var rc = dataGridView1.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - DESCUENTOS REGISTRADOS";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = "DESCUENTOS DESD EL " + dtpFechaDesde.Value.ToShortDateString() + " AL " + dtpFechaHasta.Value.ToShortDateString() + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;
                var x = 1;
                for (var i = 0; i <= dataGridView1.Columns.Count - 1; i++)
                {
                    if (!dataGridView1.Columns[i].Visible) continue;

                    worksheet.Cells[head, x] = dataGridView1.Columns[i].HeaderText;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var y = 1;
                    for (var j = 0; j <= dataGridView1.Columns.Count - 1; j++)
                    {
                        if (!dataGridView1.Columns[j].Visible) continue;

                        worksheet.Cells[head, y] = row.Cells[j].Value;
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

                var position = (Range)worksheet.Cells[2, 6];
                Clipboard.SetImage(ValidationForms.Logo(TipoCon));
                worksheet.Paste(position);

                worksheet.Range["A1:" + ic + rc].Columns.AutoFit();
                app.DisplayAlerts = false;
                app.Visible = true;
                app.DisplayAlerts = true;
                //workbook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show(@"ARCHIVO generado correctamente!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkAnual_CheckedChanged(object sender, EventArgs e)
        {
            if (_estadoAccion == 0) return;
            if (chkAnual.Checked)
            {
                Label6.Text = @"EN AÑO:";
                dtpRolPago.CustomFormat = @"yyyy";
                txtObservacion.Text = (txtObservacion.Text + @" DESCUENTO ANUAL").Trim();
                chkMensual.Enabled = false;
                txtCuota.Enabled = false;


            }
            else
            {
                Label6.Text = @"EN ROL:";
                dtpRolPago.CustomFormat = @"MMMM yyyy";
                txtObservacion.Text = txtObservacion.Text.Replace("DESCUENTO ANUAL", "").Trim();
                chkMensual.Enabled = true;
                txtCuota.Enabled = true;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            CargarDetalleDescuentos(0);
        }

        private void CargarDetalleDescuentos(long idsel)
        {
            //if (!_inicio) return;
            try
            {
                var fechaDesde = dateTimePicker3.Value.Year + "-" + dateTimePicker3.Value.Month + "-" + dateTimePicker3.Value.Day + " 00:00:00";
                var fechaHasta = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day + " 23:59:59";

                var grupos = _objRegistroDescuento.SeleccionarDescuentosGrupos(TipoCon, textBox1.Text.Trim(), fechaDesde, fechaHasta);
                var datos = _objRegistroDescuento.SeleccionarDescuentosDatos(TipoCon, textBox1.Text.Trim(), fechaDesde, fechaHasta);


                listView2.Items.Clear();
                listView2.Groups.Clear();

                // grupos  
                foreach (DataRow group in grupos.Rows)
                {
                    if (group[0].ToString().Trim().Length == 0) continue;
                    listView2.Groups.Add(new ListViewGroup(group[0].ToString().Trim()));
                }

                double td = 0;
                double tu = 0;
                foreach (DataRow row in datos.Rows)
                {
                    if (row[0].ToString().Trim().Length == 0) continue;

                    var lst = new ListViewItem(row[0].ToString().Trim(), GetListViewGroup2(row[0].ToString().Trim()))
                    {
                        UseItemStyleForSubItems = false
                    };

                    if (Convert.ToDouble(row[6].ToString()) < 0.01) row[6] = "0.00";

                    td += Convert.ToDouble(row[5].ToString());
                    tu += Convert.ToDouble(row[6].ToString());

                    for (var i = 1; i <= datos.Columns.Count - 1; i++) lst.SubItems.Add(row[i].ToString());
                    listView2.Items.Add(lst);
                }

                label16.Text = datos.Rows.Count + @" REGISTRO(S) - TOTAL DESCUENTOS $ " + td.ToString("N") + " - UTILIDAD TOTAL: $ " + tu.ToString("N");

                if (idsel == 0) return;

                foreach (var row in listView2.Items.Cast<ListViewItem>().Where(row => row.SubItems[0].Text.Trim().Equals(idsel.ToString().Trim())))
                {
                    row.EnsureVisible();
                    listView2.Items[row.Index].Selected = true;
                    listView2.Select();
                    break;
                }
            }
            catch (Exception ex)
            {
                listView2.Items.Clear();
                MessageBox.Show(@"Error al cargar detalle descuentos: " + ex.Message, "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            CargarDetalleDescuentos(0);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count == 0)
            {
                MessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "DESCUETNOS";

                var l = -1;
                for (var i = 0; i <= listView2.Columns.Count - 1; i++) if (listView2.Columns[i].Width > 1) l++;

                var ic = ValidationForms.NumToCharExcel(l);

                var rc = listView2.Items.Count + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - DESCUENTOS DE UNIFORMES";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = textBox1.Text + " DEL " + dateTimePicker3.Value.ToShortDateString() + " AL " + dateTimePicker2.Value.ToShortDateString() + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;
                var x = 1;
                for (var i = 0; i <= listView2.Columns.Count - 1; i++)
                {
                    if (listView2.Columns[i].Width < 1) continue;

                    worksheet.Cells[head, x] = listView2.Columns[i].Text;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (ListViewItem row in listView2.Items)
                {
                    var y = 1;
                    for (var j = 0; j <= listView2.Columns.Count - 1; j++)
                    {
                        if (listView2.Columns[j].Width < 1) continue;

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
                worksheet.Range["A" + head + ":F" + head].Value = label16.Text;
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
                MessageBox.Show(@"ARCHIVO generado correctamente!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (listView3.Items.Count == 0)
            {
                MessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "BODEGA";

                var l = -1;
                for (var i = 0; i <= listView3.Columns.Count - 1; i++) if (i == 1 || listView3.Columns[i].Width > 1) l++;
                var ic = ValidationForms.NumToCharExcel(l);

                var rc = listView3.Items.Count + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - DESCUENTOS BODEGA";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = cbxFiltro.Text + " DEL " + dtpFechaDesde.Value.ToShortDateString() + " AL " + dtpFechaHasta.Value.ToShortDateString() + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;
                var x = 1;
                for (var i = 0; i <= listView3.Columns.Count - 1; i++)
                {
                    if (i != 1 && listView3.Columns[i].Width < 1) continue;

                    worksheet.Cells[head, x] = listView3.Columns[i].Text;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (ListViewItem row in listView3.Items)
                {
                    var y = 1;
                    for (var j = 0; j <= listView3.Columns.Count - 1; j++)
                    {
                        if (j != 1 && listView3.Columns[j].Width < 1) continue;

                        worksheet.Cells[head, y] = j == 2
                            ? Convert.ToDateTime(row.SubItems[j].Text).ToString("yyyy/MM/dd")
                            : row.SubItems[j].Text;

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
                MessageBox.Show(@"ARCHIVO generado correctamente!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (listView4.Items.Count == 0)
            {
                MessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "OTROS";

                var l = -1;
                for (var i = 0; i <= listView4.Columns.Count - 1; i++) if (i == 1 || listView4.Columns[i].Width > 1) l++;
                var ic = ValidationForms.NumToCharExcel(l);

                var rc = listView4.Items.Count + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - OTROS DESCUENTOS";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = cbxFiltro.Text + " DEL " + dtpFechaDesde.Value.ToShortDateString() + " AL " + dtpFechaHasta.Value.ToShortDateString() + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range["A3:" + ic + "3"].Font.Size = 12;

                var head = 5;
                var x = 1;
                for (var i = 0; i <= listView4.Columns.Count - 1; i++)
                {
                    if (i != 1 && listView4.Columns[i].Width < 1) continue;

                    worksheet.Cells[head, x] = listView4.Columns[i].Text;
                    worksheet.Cells[head, x].Font.Bold = true;
                    worksheet.Cells[head, x].Borders.LineStyle = XlLineStyle.xlContinuous;
                    worksheet.Cells[head, x].Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    worksheet.Cells[head, x].Font.Color = Color.White;

                    worksheet.Cells[head, x].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                    x++;
                }

                // datos celdas
                head++;
                foreach (ListViewItem row in listView4.Items)
                {
                    var y = 1;
                    for (var j = 0; j <= listView4.Columns.Count - 1; j++)
                    {
                        if (j != 1 && listView4.Columns[j].Width < 1) continue;

                        worksheet.Cells[head, y] = j == 2
                            ? Convert.ToDateTime(row.SubItems[j].Text).ToString("yyyy/MM/dd")
                            : row.SubItems[j].Text;

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
                MessageBox.Show(@"ARCHIVO generado correctamente!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {




        }

        private void btnComplete_MouseHover(object sender, EventArgs e)
        {

            ToolTip tt = new ToolTip();
            tt.ShowAlways = true;
            //tt.SetToolTip(btnComplete, "Llena tabla de prestamos y completa el ID de prestamo");

        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validaciones.IsNumeroDecimal(e.KeyChar, txtValor.Text.Trim());
        }

        private void txtValorPago_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(txtValorPago, "Cantidad a pagar por meses");
        }

        private void txtCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validaciones.IsNumeroDecimal(e.KeyChar, txtCuota.Text.Trim());
        }

        private void txtCuota_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(txtCuota, "Maximo numero de meses 24");
        }



        private void txtCuota_TextChanged(object sender, EventArgs e)
        {


            double total = 0;
            double val1 = 0;
            double val2 = 0;

            if (!string.IsNullOrEmpty(txtValor.Text) && !string.IsNullOrEmpty(txtCuota.Text))
            {


                val1 = double.Parse(txtValor.Text);
                val2 = double.Parse(txtCuota.Text);
                if (val2 != 0)
                {
                    total = val1 / val2;
                    txtValorPago.Text = Math.Round(total, 3).ToString();


                }
            }
        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            //if ( (Int32.Parse(txtValorPago.Text)) > (Int32.Parse(txtValor.Text)) )
            //{
            //    MessageBox.Show(@"Cuota no puede ser mayor a Valor!", @"MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}



        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdPrestamo_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chkMensual_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(chkMensual, "Haga clic si difiere a mas de 2 meses");
        }

        //private void btngenerar_Click(object sender, EventArgs e)
        //{
        //    #region prestamo
        //    var msg = @"Está seguro que desea guardar los cambios realizados?";
        //    if (chkMensual.Checked) msg = @"El descuento se procesará para cada mes del año seleccionado. Está seguro que desea guardar los cambios realizados?";
        //    if (MessageBox.Show(msg, @"MENSAJE DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

        //    if (txtIdPersonal.Text.Trim().Length == 0 || txtValor.Text.Trim().Length == 0 || txtCuota.Text.Trim().Length == 0 || txtValorPago.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show(@"Debe definir los datos y tipo de movimiento para guardar!", @"MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return;
        //    }

        //    if (int.Parse(txtCuota.Text) < 1 || int.Parse(txtCuota.Text) > 11)
        //    {
        //        MessageBox.Show(@"Solo valido hasta 11 meses!", @"MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return;
        //    }
        //    _sqlCommands.Clear();

        //    var idpres = _objRegistroDescuento.BuscarMayorIdPrestamo(TipoCon) + 1;
        //    var iddetapres = _objRegistroDescuento.BuscarMayorIdDetallePrestamo(TipoCon) + 1;



        //    var fec = dtpFecha.Value;
            
            
        //    _objRegistroDescuento.capital_pagado = 0.0;
        //    _objRegistroDescuento.capital_restante = double.Parse(txtValor.Text);
        //    _objRegistroDescuento.cuota = double.Parse(txtValorPago.Text);

        //    if (chkMensual.Checked)
        //    {
        //        //var fecha = Convert.ToDateTime(dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day + dtpFecha.Value.Minute);

        //        var fecha = dtpFecha.Value;
                

        //        for (var i = 1; i <= int.Parse(txtCuota.Text); i++)
        //        {
                    
        //            _objRegistroDescuento.IdDetallePrestamo = iddetapres;
        //            _objRegistroDescuento.periodo = i;
        //            _objRegistroDescuento.Fecha = fecha;
        //            _objRegistroDescuento.capital_pagado += _objRegistroDescuento.cuota;
        //            _objRegistroDescuento.capital_restante -= _objRegistroDescuento.cuota;
        //            _objRegistroDescuento.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
        //            _objRegistroDescuento.IdPrestamo = idpres;
        //            fecha = fecha.AddMonths(1);
        //            iddetapres += 1;
        //            _sqlCommands.Add(_objRegistroDescuento.NuevoDetallePrestamo());

        //         }

        //        //idpres = Int32.Parse(txtIdPrestamo.Text);
        //        txtIdPrestamo.Text = idpres.ToString();
        //        _objRegistroDescuento.IdPrestamo = idpres;
        //        _objRegistroDescuento.Fecha = Convert.ToDateTime(fec);
        //        _objRegistroDescuento.plazo = Convert.ToInt32(txtCuota.Text);
        //        _objRegistroDescuento.cuota = Convert.ToDouble(txtValorPago.Text);
        //        _objRegistroDescuento.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
        //        _objRegistroDescuento.monto = Convert.ToDouble(txtValor.Text);
        //        _sqlCommands.Add(_objRegistroDescuento.NuevoPrestamo());
                
        //    }

        //    else
        //    {
        //        _objRegistroDescuento.IdPrestamo = idpres;
        //        _objRegistroDescuento.Fecha = Convert.ToDateTime(fec);
        //        _objRegistroDescuento.plazo = Convert.ToInt32(txtCuota.Text);
        //        _objRegistroDescuento.cuota = Convert.ToDouble(txtValorPago.Text);
        //        _objRegistroDescuento.IdPersonal = Convert.ToInt32(txtIdPersonal.Text);
        //        _objRegistroDescuento.monto = Convert.ToDouble(txtValor.Text);
        //        _sqlCommands.Add(_objRegistroDescuento.NuevoPrestamo());
                

                
        //    }


        //    var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR PRESTAMO");

        //    if ((bool)res[0])
        //    {
        //        btnPersonalEntra.Enabled = false;
        //        btnNuevo.Enabled = true;
        //        btnGuardar.Enabled = false;
        //        btnAnular.Enabled = true;
        //        btnCancelar.Enabled = false;
        //        dtpFecha.Enabled = false;
        //        txtValor.Enabled = false;
        //        cbxEstado.Enabled = false;
        //        dtpRolPago.Enabled = false;
        //        txtObservacion.Enabled = false;
        //        cbmMotivo.Enabled = false;
        //        chkAnual.Enabled = false;
        //        chkAnual.Tag = null;
        //        txtCuota.Enabled = false;
        //        txtValorPago.Enabled = false;
        //        lblCuota.Visible = false;
        //        txtValorPago.Clear();
        //        txtCuota.Clear();
        //        txtIdPersonal.Clear();
               

        //        txtFiltro.Clear();

        //        _estadoAccion = 0;
        //        //CargarAsignaciones(_objRegistroDescuento.IdRegistro);
        //    }
        //    MessageBox.Show((string)res[1], "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

        //    #endregion
            
        //}

        private void chkMensual_CheckedChanged(object sender, EventArgs e)
        {
            if (_estadoAccion == 0) return;
            if (chkMensual.Checked)
            {
                chkAnual.Enabled = false;
                dtpRolPago.Enabled = false;
                Label6.Text = @"EN ROL:";
                dtpRolPago.CustomFormat = @"MMMM yyyy";
                txtObservacion.Text = (txtObservacion.Text + @" DESCUENTO MENSUAL ").Trim();
            }
            else
            {
                
                txtObservacion.Clear();
                chkAnual.Enabled = true;
                dtpRolPago.Enabled = true;
            }
        }



    }
}