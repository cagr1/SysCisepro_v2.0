using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.EstructuraEmpresa;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.UsuarioGeneral;
using syscisepro;
using SysCisepro3.Datos;
using SysCisepro3.Properties;
using SysCisepro3.Reportes;

namespace SysCisepro3.Administracion
{
    public partial class FrmRoles : Form
    {


        private int _modo;
        private int _estadoPermiso;
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }
        private static FrmRoles _instance;
        public static FrmRoles Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmRoles();
                return _instance;
            }
        }


        private readonly ClassPermisosUsuario _objPermisos;
        private readonly List<SqlCommand> _sqlCommands;

        private FrmRoles()
        {
            InitializeComponent();
            _sqlCommands = new List<SqlCommand>();
            _objPermisos = new ClassPermisosUsuario();
        }

        private void FrmRoles_Load_1(object sender, EventArgs e)
        {
            menuStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            menuStrip1.ForeColor = Color.White;
            menuStrip2.BackColor = ValidationForms.GetColorSistema(TipoCon);
            menuStrip2.ForeColor = Color.White;


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

            CargarRoles();
            CargarRolesPermiso();
        }

        private void CargarRoles()
        {
            try
            {
                var data = _objPermisos.CargarRoles(TipoCon);
                if (data == null || data.Rows.Count == 0)
                {
                    dgvRoles.DataSource = null;
                    return;
                }
                dgvRoles.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    dgvRoles.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                    int estado = Convert.ToInt32(row[3]);

                    
                    if (estado == 0)
                    {
                        dgvRoles.Rows[dgvRoles.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Coral;
                    }
                }
                
                dgvRoles.Columns[0].Width = 50;
                dgvRoles.Columns[1].Width = 200;
                dgvRoles.Columns[2].Width = 160;
                dgvRoles.Columns[3].Width = 100;
                dgvRoles.Columns[4].Width = 150;
                
            
                dgvRoles.AutoResizeRows();

            }
            catch (Exception ex)
            {
                dgvRoles.DataSource = null;
            }
        }

        private void CargarRolesPermiso()
        {
            try
            {
                var data = _objPermisos.CargarRolesActivos(TipoCon);
                cbxTipo.DataSource = data;
                cbxTipo.DisplayMember = data.Columns["fld_tipo_rol"].ToString();
                cbxTipo.ValueMember = data.Columns["fld_id_rol"].ToString();
                cbxTipo.DropDownWidth = 200;
                cbxTipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                cbxTipo.DataSource = null;
            }
        }

        private void HabilitarRegistro()
        {
            txtTipoRol.Enabled = true;
            txtDescripcion.Enabled = true;
            chbxEstado.Enabled = true;
        }


        private bool ValidacionParametros()
        {
            return txtTipoRol.Text.Trim().Length != 0;
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HabilitarRegistro();
            HabilitarBotonesMenu(false, false, true, true);
            _modo = 1; 

        }

       

        private void HabilitarBotonesMenu(bool botonNuevo, bool botonModificar, bool botonGuardar, bool botonCancelar)
        {
            nUEVOToolStripMenuItem.Enabled  = botonNuevo;
            aCTUALIZARToolStripMenuItem.Enabled = botonModificar;
            gUARDARToolStripMenuItem.Enabled  = botonGuardar;
            cANCELARToolStripMenuItem.Enabled  = botonCancelar;
        }
        private void gUARDARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ValidacionParametros())
            {
                MessageBox.Show(@"Debe ingresar todos los datos para guardar!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(@"Desea guardar los cambios realizados?",
                    "MENSAJE DELL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes) return;

            _sqlCommands.Clear();

            if (_modo ==2)
            { _objPermisos.idRol = Convert.ToInt32(txtId.Text.Trim()); }
            _objPermisos.tipopRol = txtTipoRol.Text.Trim();
            _objPermisos.descripcion = txtDescripcion.Text.Trim();
            _objPermisos.estado = chbxEstado.Checked;
            _objPermisos.fecha = Usuario.Now(TipoCon);
            _sqlCommands.Add(_modo == 1  ? _objPermisos.NuevoRol() : _objPermisos.ModificarRol() );

            var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR ROLES DE USUARIOS");

            if ((bool)res[0])
            {

                HabilitarCampos(false, false, false);
                HabilitarBotonesMenu(true, true, false, false);
                CargarRoles();
                CargarRolesPermiso();
            }
            MessageBox.Show((string)res[1], "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void cANCELARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarParametros();
            HabilitarCampos(false, false, false);
            HabilitarBotonesMenu(true, true, false, false);
            _modo = 0;
        }

        private void HabilitarCampos(bool tipo, bool descripcion, bool estado)
        {
            txtTipoRol.Enabled = tipo;
            txtDescripcion.Enabled = descripcion;
            chbxEstado.Enabled = estado;
        
        }

        private void LimpiarParametros()
        {
            txtId.Clear();
            txtTipoRol.Clear();
            txtDescripcion.Clear();
        }

        private void vERTODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void aCTUALIZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HabilitarRegistro();
            HabilitarCampos(true,true,true);
            HabilitarBotonesMenu(false, true, true, true);
            _modo = 2;
        }

        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            if (_modo != 0) return;
            if (dgvRoles.CurrentRow == null) return;
            
            try
            {
                txtId.Text = dgvRoles.CurrentRow.Cells[0].Value.ToString();
                txtTipoRol.Text = dgvRoles.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = dgvRoles.CurrentRow.Cells[2].Value.ToString();
                chbxEstado.Checked = Convert.ToBoolean(dgvRoles.CurrentRow.Cells[3].Value);

            }
            catch (Exception ex)
            { 
            
            }
        }

        private void vERTODOSPERMISOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPermisos.DataSource = null;

            try
            {
                DataRowView selectedRow = (DataRowView)cbxTipo.SelectedItem;
                int roleId = Convert.ToInt32(selectedRow["fld_id_rol"]);
                var data = _objPermisos.CargarRolesPorId(TipoCon, roleId);
                if (data == null || data.Rows.Count == 0)
                {
                    dgvRoles.DataSource = null;
                    return;
                }
                dgvPermisos.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    dgvPermisos.Rows.Add(row[0], row[1], row[2], row[3], row[4],row[5],row[6],row[7], row[8] ) ;
                }

                dgvPermisos.Columns[0].Width = 120;
                dgvPermisos.Columns[1].Width = 250;
                dgvPermisos.Columns[2].Width = 250;
                dgvPermisos.Columns[3].Width = 80;
                dgvPermisos.Columns[4].Visible = false;
                dgvPermisos.Columns[5].Visible = false;
                dgvPermisos.Columns[6].Visible = false;
                dgvPermisos.Columns[7].Visible = false;
                dgvPermisos.Columns[8].Visible = false;
                            
                dgvPermisos.AutoResizeRows();
            
            }
            catch
            {
                dgvPermisos.DataSource = null;
            }

        }

        private void aCTUALIZARPERMISOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            HabilitarBotonesMenu2(true, false, true);
            _estadoPermiso = 1;
        }

        private void HabilitarBotonesMenu2(bool botonGuardar, bool botonModificar, bool botonCancelar) 
        {
            gUARDARPERMISOSToolStripMenuItem1.Enabled = botonGuardar;
            aCTUALIZARPERMISOSToolStripMenuItem1.Enabled = botonModificar;
            cANCELARPERMISOSToolStripMenuItem1.Enabled = botonCancelar;
        }

        private void cANCELARPERMISOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HabilitarBotonesMenu2(false, true, false);
            dgvPermisos.DataSource = null;
            _estadoPermiso = 0;
        }

        private void gUARDARPERMISOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Desea guardar los cambios realizados?",
                   "MENSAJE DELL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
               DialogResult.Yes) return;

            _sqlCommands.Clear();
            
            try
            {
                foreach (DataGridViewRow row in dgvPermisos.Rows)
                {
                    bool buscarIdRol = _objPermisos.BuscarIdPermisoRol(TipoCon, Convert.ToInt32(cbxTipo.SelectedValue), Convert.ToInt32(row.Cells[8].Value));


                    if (buscarIdRol)
                    {

                        _objPermisos.idRolUserPermisos = Convert.ToInt32(row.Cells[8].Value);
                        _objPermisos.idRol = Convert.ToInt32(row.Cells[7].Value);
                        _objPermisos.idMenuUno = Convert.ToInt32(row.Cells[4].Value);
                        _objPermisos.idMenuDos = Convert.ToInt32(row.Cells[5].Value);
                        _objPermisos.idMenuTres = row.Cells[6].Value != DBNull.Value ? Convert.ToInt32(row.Cells[6].Value) : 0;
                        //_objPermisos.estado = Convert.ToBoolean(row.Cells["ESTADO"].Value);
                        //_objPermisos.estado = row.Cells[3].Value != null ? Convert.ToBoolean(row.Cells[3].Value) : false;

                        object cellValue = row.Cells[3].Value;
                        if (cellValue != null && (cellValue is bool || cellValue.Equals(1) || cellValue.Equals(0)))
                        {
                            _objPermisos.estado = Convert.ToBoolean(cellValue);
                        }
                        else
                        {
                            // Handle the case where the cell value cannot be interpreted as a boolean
                            // For example, log an error or set a default value
                            _objPermisos.estado = false; // Set a default value
                        }


                        _objPermisos.fecha = Usuario.Now(TipoCon);
                        _sqlCommands.Add(_objPermisos.ModificarPermiso());

                        
                        
                    }

                    else 
                    {

                        _objPermisos.idRol = Convert.ToInt32(cbxTipo.SelectedValue);
                        _objPermisos.idMenuUno = Convert.ToInt32(row.Cells[4].Value);
                        _objPermisos.idMenuDos = Convert.ToInt32(row.Cells[5].Value);
                        _objPermisos.idMenuTres = row.Cells[6].Value != DBNull.Value ? Convert.ToInt32(row.Cells[6].Value) : 0;
                        _objPermisos.estado = Convert.ToBoolean(row.Cells[3].Value);
                        _objPermisos.fecha = Usuario.Now(TipoCon);
                        _sqlCommands.Add(_objPermisos.NuevoPermiso());
                       
                    }
                                                            
                }
                var res = ComandosSql.ProcesarTransacciones(TipoCon, _sqlCommands, "GUARDAR NUEVO PERMISO");

                if ((bool)res[0])
                {
                    
                    _estadoPermiso = 0;
                    CargarRolesPermiso();
                    HabilitarBotonesMenu2(false, true, false);
                    
                }
                MessageBox.Show((string)res[1], "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                dgvPermisos.DataSource = null;
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvPermisos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvPermisos.CurrentRow == null) return;
            e.Cancel = _estadoPermiso == 0 || dgvPermisos.CurrentRow.Cells[1].Value == null;
        }

        private void dgvRoles_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvPermisos.CurrentRow == null) return;
            e.Cancel = _modo == 2 || dgvRoles.CurrentRow.Cells[0].Value != DBNull.Value;
        }

        private void dgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            senderGrid.EndEdit();



            if (senderGrid.Columns[e.ColumnIndex].Name == "ESTADO" && e.RowIndex >= 0)
            {
                var cbxCell = (DataGridViewCheckBoxCell)senderGrid.Rows[e.RowIndex].Cells["ESTADO"];

                
                    bool isChecked = (bool)cbxCell.Value;

                    if (cbxCell.Value is bool || cbxCell.Value.Equals(true) || cbxCell.Value.Equals(false))
                    {
                         isChecked = (bool)cbxCell.Value;
                    }
                

            }

        }


       
    }
}
