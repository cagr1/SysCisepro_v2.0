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
using Office = Microsoft.Office.Interop;
using Krypton.Toolkit;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmNotificaciones : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para registrar detalles, denuncias o notificaciones del personal
        /// </summary>
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }

        private static FrmNotificaciones _instance;
        public static FrmNotificaciones Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmNotificaciones();
                return _instance;
            }
        }

        private readonly ClassNotificacionesDenuncias _objNotificacionesDenuncias;
        private readonly ClassPersonal _objPersonal;

        private readonly List<SqlCommand> _sqlCommands;

        private int _estado;

        private FrmNotificaciones()
        {
            InitializeComponent();
            _estado = 0;
            _sqlCommands = new List<SqlCommand>();
            _objNotificacionesDenuncias = new ClassNotificacionesDenuncias();
            _objPersonal = new ClassPersonal();
        }

        private void FrmNotificaciones_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA 
            //toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStrip1.ForeColor = Color.White;
            
            
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
            dataGridView1.Font = new System.Drawing.Font("Roboto",8,FontStyle.Regular);
            dtpFechaRegistro.Value = Usuario.Now(TipoCon);
            dtpFechaDesde.Value = new DateTime(dtpFechaRegistro.Value.Year, dtpFechaRegistro.Value.Month, 1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtNumDoc.Clear();
            txtCiRuc.Clear();
            txtNombreDenunciante.Clear();
            txtDetallesNotificacion.Clear();

            dtpFechaRegistro.Value = Usuario.Now(TipoCon);
            dtpFechaNotificacion.Value = dtpFechaRegistro.Value;

            dtpFechaRegistro.Tag = null;
            txtNumDoc.Enabled = true;
            txtCiRuc.Enabled = true;
            txtNombreDenunciante.Enabled = true;
            txtDetallesNotificacion.Enabled = true;
            dtpFechaNotificacion.Enabled = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnAnular.Enabled = false;
            btnCancelar.Enabled = true;
            _estado = 1;

            txtNumDoc.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(@"Desea guardar el registro actual?",
                   "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
               DialogResult.Yes) return;

            if (txtNumDoc.Text.Trim().Length == 0 || txtCiRuc.Text.Trim().Length == 0 || txtDetallesNotificacion.Text.Trim().Length == 0)
            {
                KryptonMessageBox.Show(@"Debe definir los datos de a notificación para guardar!",
                    "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            _sqlCommands.Clear();

            _objNotificacionesDenuncias.IdRegistro = _objNotificacionesDenuncias.BuscarMayorIdNotificacion(TipoCon) + 1;
            _objNotificacionesDenuncias.FechaRegistro = dtpFechaRegistro.Value;
            _objNotificacionesDenuncias.NumDocumento = Convert.ToInt32(txtNumDoc.Text.Trim());
            _objNotificacionesDenuncias.FechaNotificacion = dtpFechaNotificacion.Value;
            _objNotificacionesDenuncias.CedulaRuc = txtCiRuc.Text.Trim();
            _objNotificacionesDenuncias.Estado = 1;
            _objNotificacionesDenuncias.ApellidosNombres = txtNombreDenunciante.Text.Trim();
            _objNotificacionesDenuncias.Detalle = txtDetallesNotificacion.Text.Trim();

            _sqlCommands.Add(_objNotificacionesDenuncias.NuevoRegistroNotificacionCommands());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR NOTIFICACION");

            if ((bool)res[0])
            {
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = true;
                btnCancelar.Enabled = false;

                dtpFechaNotificacion.Tag = _objNotificacionesDenuncias.IdRegistro;
                dtpFechaNotificacion.Enabled = false;
                txtNumDoc.Enabled = false;
                txtCiRuc.Enabled = false;
                txtNombreDenunciante.Enabled = false;
                txtDetallesNotificacion.Enabled = false;

                txtFiltro.Clear();
                _estado = 0;

                CargarAsignaciones(_objNotificacionesDenuncias.IdRegistro);
            }
            KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0 || dtpFechaRegistro.Tag == null) return;

            if (KryptonMessageBox.Show(@"Desea anular el registro seleccioando?", "Mensaje del Sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes) return;

            _sqlCommands.Clear();

            _objNotificacionesDenuncias.IdRegistro = Convert.ToInt32(dtpFechaRegistro.Tag);
            _objNotificacionesDenuncias.Estado = 0;
            _sqlCommands.Add(_objNotificacionesDenuncias.AnularRegistroNotificacion());

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "ANULAR NOTIFICACION");

            if ((bool)res[0])
            {
                dtpFechaNotificacion.Enabled = false;
                txtNumDoc.Enabled = false;
                txtCiRuc.Enabled = false;
                txtNombreDenunciante.Enabled = false;
                txtDetallesNotificacion.Enabled = false;

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = false;
                btnCancelar.Enabled = false;
                txtNumDoc.Enabled = false;

                _estado = 0;
                txtFiltro.Clear();
                CargarAsignaciones(0);
            }
            KryptonMessageBox.Show((string)res[1], "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtpFechaNotificacion.Enabled = false;
            txtNumDoc.Enabled = false;
            txtCiRuc.Enabled = false;
            txtNombreDenunciante.Enabled = false;
            txtDetallesNotificacion.Enabled = false;

            dtpFechaNotificacion.Tag = null;
            txtNumDoc.Clear();
            txtCiRuc.Clear();
            txtNombreDenunciante.Clear();
            txtDetallesNotificacion.Clear();

            _estado = 0;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = false;
            btnCancelar.Enabled = false;

            CargarAsignaciones(0);
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            CargarAsignaciones(0);
        }

        private void CargarAsignaciones(int idsel)
        {
            try
            {
                dataGridView1.Rows.Clear();

                var fechaDesde = dtpFechaDesde.Value.Year + "-" + dtpFechaDesde.Value.Month + "-" + dtpFechaDesde.Value.Day + " 00:00:00";
                var fechaHasta = dtpFechaHasta.Value.Year + "-" + dtpFechaHasta.Value.Month + "-" + dtpFechaHasta.Value.Day + " 23:59:59";

                var data = _objNotificacionesDenuncias.SeleccionarRegistroNotificaciones(TipoCon, fechaDesde, fechaHasta, txtFiltro.Text.Trim());

                foreach (DataRow row in data.Rows) dataGridView1.Rows.Add(row[0], row[2], row[3], row[1], row[4], row[5], row[6]);

                dataGridView1.AutoResizeRows();
                Label1.Text = dataGridView1.RowCount + @" REGISTRO(S)";

                foreach (var row in dataGridView1.Rows.Cast<DataGridViewRow>().Where(row => row.Cells[0].Value.ToString().Equals(idsel + "")))
                {
                    row.Cells[0].Selected = true;
                    break;
                }
                btnAnular.Enabled = dataGridView1.RowCount > 0 && dataGridView1.CurrentRow != null;
            }
            catch (Exception ex)
            {
                dataGridView1.Rows.Clear();
                KryptonMessageBox.Show(@"Error al cargar detalles: " + ex.Message, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            CargarAsignaciones(0);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_estado != 0) return;
            if (dataGridView1.RowCount == 0) return;
            if (dataGridView1.CurrentRow == null) return;

            dtpFechaRegistro.Tag = dataGridView1.CurrentRow.Cells[0].Value;
            dtpFechaRegistro.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value);

            dtpFechaNotificacion.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
            txtNumDoc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCiRuc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtNombreDenunciante.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtDetallesNotificacion.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnAnular.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Validaciones.IsNumeroEntero(e.KeyChar);
        }

        private void txtCiRuc_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCiRuc.Text.Trim().Length < 10) return;
            txtNombreDenunciante.Text = _objPersonal.BuscarNombresPersonalXCedula(TipoCon, txtCiRuc.Text.Trim());
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                KryptonMessageBox.Show(@"NO HAY DATOS PARA EXPORTAR!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            try
            {
                var app = new Office.Excel.Application();
                var workbook = app.Workbooks.Add(Type.Missing);

                var worksheet = (Worksheet)workbook.Worksheets[1];
                worksheet.Name = "NOTIFICACIONES";

                var l = -1;
                for (var i = 0; i <= dataGridView1.Columns.Count - 1; i++) if (dataGridView1.Columns[i].Visible) l++;
                var ic = ValidationForms.NumToCharExcel(l);

                var rc = dataGridView1.RowCount + 20;

                worksheet.Range["A1:" + ic + rc].Font.Size = 10;

                worksheet.Range["A1:" + ic + "1"].Merge();
                worksheet.Range["A1:" + ic + "1"].Value = Validaciones.NombreCompany(TipoCon) + " - DEMANDAS REGISTRADAS";
                worksheet.Range["A1:" + ic + "1"].Font.Bold = true;
                worksheet.Range["A1:" + ic + "1"].Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                worksheet.Range["A1:" + ic + "1"].Interior.Color = ValidationForms.GetColorSistema(TipoCon);
                worksheet.Range["A1:" + ic + "1"].Font.Color = Color.White;
                worksheet.Range["A1:" + ic + "1"].Font.Size = 12;

                worksheet.Range["A3:" + ic + "3"].Merge();
                worksheet.Range["A3:" + ic + "3"].Value = "NOTIFICACIONES DEL " + dtpFechaDesde.Value.ToShortDateString() + " AL " + dtpFechaHasta.Value.ToShortDateString() + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
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
                KryptonMessageBox.Show(@"ARCHIVO generado correctamente!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch
            {
                KryptonMessageBox.Show(@"HUBO UN PROBLEMA AL EXPORTAR DATOS!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
    }
}
