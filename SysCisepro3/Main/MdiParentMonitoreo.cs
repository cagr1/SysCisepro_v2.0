using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Properties;
using SysCisepro3.TalentoHumano;
using SysCisepro3.Operaciones;
using syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.REQUERIMIENTOS;
using Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace SysCisepro3.Main
{
    public partial class MdiParentMonitoreo : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// INTERFAZ PARA MONITOREO Y JEFE DE OPERACIONES
        /// </summary>
        public ClassUsuarioGeneral ObjUsuario { private get; set; }
        public int TiempoNotificacion { private get; set; }
        private readonly ClassDetalleVacaciones _objDetalleVacaciones;
        private readonly ClassPersonal _objPersonal;

        private readonly Dictionary<string, Form> _formularios;
        private FrmNotificarNovedades _frmNotificacion;
        public TipoConexion TipoCon { private get; set; }
        private string _tag;
        private DataTable _data;
        private readonly DataTable _datapersonal;
        private readonly DataTable _datavacaciones;

        private readonly List<int> _anios;

        public MdiParentMonitoreo()
        {
            InitializeComponent();
            _data = new DataTable();

            _datapersonal = new DataTable();
            _datapersonal.Columns.Add("CÍA");
            _datapersonal.Columns.Add("ID");
            _datapersonal.Columns.Add("INGRESO");
            _datapersonal.Columns.Add("CI");
            _datapersonal.Columns.Add("NOMBRES");
            _datapersonal.Columns.Add("PUESTO");
            _datapersonal.Columns.Add("7 MESES");
            _datapersonal.Columns.Add("CLIENTE");

            _datavacaciones = new DataTable();
            _datavacaciones.Columns.Add("CÍA");
            _datavacaciones.Columns.Add("ID");
            _datavacaciones.Columns.Add("CÉDULA");
            _datavacaciones.Columns.Add("APELLIDOS");
            _datavacaciones.Columns.Add("NOMBRES");
            _datavacaciones.Columns.Add("INGRESO");
            _datavacaciones.Columns.Add("MES");
            _datavacaciones.Columns.Add("PERÍODO");
            _datavacaciones.Columns.Add("DÍAS");
            _datavacaciones.Columns.Add("GRUPO");

            _anios = new List<int>();
            _objPersonal = new ClassPersonal();
            _objDetalleVacaciones = new ClassDetalleVacaciones();
            _formularios = new Dictionary<string, Form>();
        }


        private int TipoCox
        {
            get
            {
                switch (TipoCon)
                {
                    case TipoConexion.Asenava:
                        return 2;
                    case TipoConexion.Seportpac:
                        return 1;
                    default:
                        return 0;
                }
            }
        }

        private void DefinirTipoSistema()
        {
            lblUsuario.Text = ObjUsuario.ObtenerNombrePersonalXIdUser(0, ObjUsuario.IdPersonal + "") + @"            ";
            lblFecha.Text = ObjUsuario.Now(0).ToLongDateString();

            notifyIcon1.BalloonTipTitle = @"Notificación para: " + Settings.Default.Usuario;
            notifyIcon1.Icon = Icon;
            notifyIcon1.Text = @"CISEPRO / SEPORTPAC";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
        }

        private void MdiParentMain_Load(object sender, EventArgs e)
        {
          // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA
          DefinirTipoSistema();
          timer1.Start(); 
        }

        private void MdiParentMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (KryptonMessageBox.Show(@"Está seguro que desea salir del sistema?", @"MENSAJE DELL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
                DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            ObjUsuario.SalirSistema(0);

            Dispose();
            GC.SuppressFinalize(this);
            Application.Exit();
        }

        private bool ExisteForm(string tag)
        { 
            return _formularios.ContainsKey(tag);
        }
        private Form GetForm(string tag)
        {
            return _formularios[tag];
        }

        private void FormOnFormClosing(object sender, FormClosingEventArgs formClosingEventArgs)
        {
            var f = (Form)sender;
            _formularios.Remove(f.Tag.ToString());
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            _tag = "SITIO_TRABAJO_C";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new syscisepro.FORMULARIOS.DIVISION_GEOGRÁFICA.FormSitiosTrabajo { Tag = _tag, TipoCox = 0  };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            } 
        } 

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            _tag = "PROGRMACION_C";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new syscisepro.FORMULARIOS.OPERACIONES.FrmProgramacionGeneral { Tag = _tag, TipoCox = 0, IdUsuario = ObjUsuario.IdUsuario };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            } 
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            _tag = "ASISTENCIA_C";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new syscisepro.FORMULARIOS.OPERACIONES.FrmReporteAsistencia { Tag = _tag, TipoCox = 0, IdUsuario = ObjUsuario.IdUsuario, Usuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }
        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {
            _tag = "REGISTRO_SANCION_C";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new syscisepro.FORMULARIOS.OPERACIONES.FrmRegistrarSancionPersonal { Tag = _tag, TipoCox = 0, IdUsuario = ObjUsuario.IdUsuario };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            } 
        }

        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {
            _tag = "HORARIOS_C";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new syscisepro.FORMULARIOS.OPERACIONES.FrmProgramacionHorarios { Tag = _tag, TipoCox = 0, IdUsuario = ObjUsuario.IdUsuario };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }  
        }
        private void toolStripDropDownButton7_Click(object sender, EventArgs e)
        {
            _tag = "REVISION_TECNICA_C";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new FrmOrdenRevisionTecnica { Tag = _tag }; 
                FrmOrdenRevisionTecnica.TipoCon = TipoConexion.Cisepro;
                FrmOrdenRevisionTecnica.Usuario = ObjUsuario;
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show(); 
            }
        }
        private void toolStripDropDownButton6_Click(object sender, EventArgs e)
        {
            _tag = "REGISTRO_SANCION_C";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new syscisepro.FORMULARIOS.TALENTO_HUMANO.FrmSancionesPersonal { Tag = _tag, TipoCox = 0, IdUsuario = ObjUsuario.IdUsuario };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }  
        } 
        private void iNGRESOSSALIDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tag = "REPORTE_C";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new FrmReportePersonalGeneral(0, ObjUsuario) { Tag = _tag, Text = @"REPORTE DE INGRESOS Y SALIDAS" };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }
        } 
        private void toolStripDropDownButton8_Click(object sender, EventArgs e)
        {
            _tag = "SITIO_TRABAJO_S";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new syscisepro.FORMULARIOS.DIVISION_GEOGRÁFICA.FormSitiosTrabajo { Tag = _tag, TipoCox = 1  };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            } 
        }

        private void toolStripDropDownButton9_Click(object sender, EventArgs e)
        {
            _tag = "PROGRMACION_S";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new syscisepro.FORMULARIOS.OPERACIONES.FrmProgramacionGeneral { Tag = _tag, TipoCox = 1, IdUsuario = ObjUsuario.IdUsuario };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }
        }

        private void toolStripDropDownButton10_Click(object sender, EventArgs e)
        {
            _tag = "ASISTENCIA_S";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new syscisepro.FORMULARIOS.OPERACIONES.FrmReporteAsistencia { Tag = _tag, TipoCox = 1, IdUsuario = ObjUsuario.IdUsuario, Usuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }
        }

        private void toolStripDropDownButton11_Click(object sender, EventArgs e)
        {
            _tag = "REGISTRO_SANCION_S";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new syscisepro.FORMULARIOS.OPERACIONES.FrmRegistrarSancionPersonal { Tag = _tag, TipoCox = 1, IdUsuario = ObjUsuario.IdUsuario };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }
        }

        private void toolStripDropDownButton12_Click(object sender, EventArgs e)
        {
            _tag = "HORARIOS_S";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new syscisepro.FORMULARIOS.OPERACIONES.FrmProgramacionHorarios { Tag = _tag, TipoCox = 1, IdUsuario = ObjUsuario.IdUsuario };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            } 
        }
        private void toolStripDropDownButton14_Click(object sender, EventArgs e)
        {
            _tag = "REVISION_TECNICA_S";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new FrmOrdenRevisionTecnica { Tag = _tag };
                FrmOrdenRevisionTecnica.TipoCon = TipoConexion.Seportpac;
                FrmOrdenRevisionTecnica.Usuario = ObjUsuario;
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show(); 
            }
        }
        private void toolStripDropDownButton13_Click(object sender, EventArgs e)
        {
            _tag = "REGISTRO_SANCION_S";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new syscisepro.FORMULARIOS.TALENTO_HUMANO.FrmSancionesPersonal { Tag = _tag, TipoCox = 1, IdUsuario = ObjUsuario.IdUsuario };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            } 
        }
        private void iNGRESOSSALIDASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _tag = "REPORTE_S";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new FrmReportePersonalGeneral((TipoConexion)1, ObjUsuario) { Tag = _tag, Text = @"REPORTE DE INGRESOS Y SALIDAS" };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }
        }
        private void pENDIENTESDEVACACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tag = "VACACIONES_C";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new FrmPendientesVcaciones(0, ObjUsuario) { Tag = _tag, Text = @"REPORTE DE PERSONAL PENDIENTE DE VACACIONES" };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }
        }
        private void pENDIENTESVACACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tag = "VACACIONES_S";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new FrmPendientesVcaciones((TipoConexion)1, ObjUsuario) { Tag = _tag, Text = @"REPORTE DE PERSONAL PENDIENTE DE VACACIONES" };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }
        }
        private void MdiParentMonitoreo_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) return;
            WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var hoy = ObjUsuario.Now(TipoConexion.Cisepro);
                if (hoy.Minute % TiempoNotificacion != 0) return;
                _datapersonal.Rows.Clear();
                _datavacaciones.Rows.Clear();
                _data.Rows.Clear();

                try
                {
                    _anios.Clear();
                    for (var i = 0; i <= (DateTime.Now.Year - 2018); i++) _anios.Add(2018 + i);

                    _data = _objDetalleVacaciones.SeleccionarRegistroPendientesVacacionesPorPeriodo(TipoConexion.Cisepro, string.Empty, _anios, 0, 1);
                    foreach (DataRow row in _data.Rows)
                    {
                        var fe = Convert.ToDateTime(row[4]);
                        var fx = new DateTime(int.Parse(row[6].ToString().Split('-')[1].Trim()), fe.Month, fe.Day, fe.Hour, fe.Minute, fe.Second);
                        if (fe >= fx) row.Delete();
                        else _datavacaciones.Rows.Add("CISEPRO", row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
                    }

                    _data = _objDetalleVacaciones.SeleccionarRegistroPendientesVacacionesPorPeriodo(TipoConexion.Seportpac, string.Empty, _anios, 0, 1);
                    foreach (DataRow row in _data.Rows)
                    {
                        var fe = Convert.ToDateTime(row[4]);
                        var fx = new DateTime(int.Parse(row[6].ToString().Split('-')[1].Trim()), fe.Month, fe.Day, fe.Hour, fe.Minute, fe.Second);
                        if (fe >= fx) row.Delete();
                        else _datavacaciones.Rows.Add("SEPORTPAC", row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    _data = _objPersonal.SeleccionarPersonalPorCulminarProyecto(TipoConexion.Cisepro);

                    foreach (DataRow row in _data.Rows) _datapersonal.Rows.Add("CISEPRO", row[0], row[1], row[2], row[3], row[4], row[5], row[6]);

                    _data = _objPersonal.SeleccionarPersonalPorCulminarProyecto(TipoConexion.Seportpac);
                    foreach (DataRow row in _data.Rows) _datapersonal.Rows.Add("SEPORTPAC", row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                notifyIcon1.BalloonTipText = @"ALERTA!!! Existe personal que está por culminar el contrato según el proycto registardo!. Por favor, coordine con OPERACIONES para procesar la salida / reubicación correspondiente.";
                if (_datavacaciones.Rows.Count > 0 || _datapersonal.Rows.Count > 0) notifyIcon1.ShowBalloonTip(15000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"Error recordatorio facturar: " + ex.Message);
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (_datapersonal.Rows.Count == 0 && _datavacaciones.Rows.Count == 0) return;
            _frmNotificacion = new FrmNotificarNovedades(TipoConexion.Cisepro, ObjUsuario, @"ALERTA!!! Existe personal de guardias que tiene días pendientes de vacaciones o ha sobrepasado el período de prueba 3 - 6 meses! Por favor, coordine con OPERACIONES para procesar la salida correspondiente.",
                4) { DataVacaciones = _datavacaciones, Data3Meses = _datapersonal};
            _frmNotificacion.Show();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            if (_datapersonal.Rows.Count == 0 && _datavacaciones.Rows.Count == 0) return;
            _frmNotificacion = new FrmNotificarNovedades(TipoConexion.Cisepro, ObjUsuario, @"ALERTA!!! Existe personal de guardias que tiene días pendientes de vacaciones o ha sobrepasado el período de prueba 3 - 6 meses! Por favor, coordine con OPERACIONES para procesar la salida correspondiente.",
               4) { DataVacaciones = _datavacaciones, Data3Meses = _datapersonal };
            _frmNotificacion.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void rEPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmReportePersonalGeneral.Instancia.MdiParent = this;
            FrmReportePersonalGeneral.TipoCon = TipoCon;
            FrmReportePersonalGeneral.Usuario = ObjUsuario;
            FrmReportePersonalGeneral.Instancia.Show();
            FrmReportePersonalGeneral.Instancia.BringToFront();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
           


            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _tag = "REQUERIMIENTOS_C";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {

                Form f = new FormRequisicionProductoServicio { Tag = _tag, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }
        }

        private void pERMISOSPERSONALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tag = "Permisos_C";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new FrmPermisos((TipoConexion)0, ObjUsuario) { Tag = _tag, Text = @"Permisos Personal" };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }

        }

        private void pERMISOSPERSONALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _tag = "Permisos_S";
            if (ExisteForm(_tag)) GetForm(_tag).BringToFront();
            else
            {
                var f = new FrmPermisos((TipoConexion)1, ObjUsuario) { Tag = _tag, Text = @"Permisos Personal" };
                _formularios.Add(_tag, f);
                f.FormClosing += FormOnFormClosing;
                f.Show();
            }
        }
    }
}