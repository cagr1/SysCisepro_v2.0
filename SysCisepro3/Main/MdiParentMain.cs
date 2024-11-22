using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Shell32;
using ClassLibraryCisepro3.Contabilidad.LibroDiario;
using ClassLibraryCisepro3.Contabilidad.Ventas;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Estaticas;
using ClassLibraryCisepro3.ProcesosSql;
using ClassLibraryCisepro3.TalentoHumano;
using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Administracion;
using SysCisepro3.Contabilidad.Compras;
using SysCisepro3.Datos;
using SysCisepro3.Inventarios;
using SysCisepro3.Operaciones;
using SysCisepro3.Properties;
using SysCisepro3.Reportes;
using SysCisepro3.TalentoHumano;
using SysCisepro3.Bodega;
using ClassLibraryCisepro3.ActivoFijo;
//using ComponentFactory.Krypton.Toolkit;
using Krypton.Toolkit;
using System.IO;
using System.Drawing.Text;








namespace SysCisepro3.Main
{
    public partial class MdiParentMain : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// INTERFAZ PRINCIPAL DEL SISTEMA (COMPRAS, VENTAS, RRHH, CONTABILIDAD)
        /// </summary>
        /// 
        
        public ClassUsuarioGeneral ObjUsuario { private get; set; }
        public int TiempoNotificacion { private get; set; }
        public TipoConexion TipoCon { private get; set; }
        public ClassPermisosUsuario ObjPermiso { private get; set; }
        private bool IsAdmin { get; set; }

        public FrmLogin _frmLogin { private get; set; }
        public FrmNewLogin2 _frmNewLogin { private get; set; }

        private PrivateFontCollection _pfc = new PrivateFontCollection();

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

        private readonly ClassLibroDiario _objLibroDiario;
        private readonly ClassClienteGeneral _objClienteGeneral;
        private readonly ClassDetalleVacaciones _objDetalleVacaciones;
        private readonly ClassPersonal _objPersonal;
        private readonly ClassChaleco _objChaleco;
        
        
        private FrmNotificarNovedades _frmNotificacion;

        private DateTime _fechaInicialMesActual;
        private DateTime _fechaFinalMesActual;

        private DateTime _fechaInicialMesAnterior;
        private DateTime _fechaFinalMesAnterior;

        private readonly List<int> _anios;
        private DataTable _data, _data2;
        private int _tipoNoficicacion;
        string[] menuUno = new string[] { "1", "2", "3", "4", "5", "6", "7" };

        int[] menuDos = Enumerable.Range(1, 58).ToArray();
        int[] menuTres = Enumerable.Range(1, 130).ToArray();
        

        public MdiParentMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
            _anios = new List<int>();
            _data = new DataTable();
            _data2 = new DataTable();
            _tipoNoficicacion = 0; 
            _objPersonal = new ClassPersonal();
            _objLibroDiario = new ClassLibroDiario();
            _objClienteGeneral = new ClassClienteGeneral();
            _objDetalleVacaciones = new ClassDetalleVacaciones();
            _objChaleco = new ClassChaleco();
            ObjPermiso = new ClassPermisosUsuario();
            
        }

        private void DefinirTipoSistema()
        {

            
            // DEFINR TIPO DE SISTEMA
            foreach (var t in from ToolStripItem t in toolStrip1.Items where t != null select t) t.ForeColor = Color.White;
            toolStripButtonCalc.ForeColor = Color.White;
            toolStripButtonNote.ForeColor = ValidationForms.GetColorSistema(TipoCon);
            
            //this.StateCommon.Border.Color1 = ValidationForms.GetColorSistema(TipoCon);
            toolStripStatusLabel1.ForeColor = Color.White;
            lblVersion.ForeColor = Color.White;
            toolStripStatusLabel4.ForeColor = Color.White;
            lblUsuario.ForeColor = Color.White;
            toolStripStatusLabel6.ForeColor = Color.White;
            lblFecha.ForeColor = Color.White;
            toolStrip1.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStripStatusLabel1.ForeColor = ValidationForms.GetColorSistema(TipoCon);
            lblVersion.ForeColor = ValidationForms.GetColorSistema(TipoCon);
            lblVersion.Text = Validaciones.NombreCompany(TipoCon);
            toolStripStatusLabel4.ForeColor = ValidationForms.GetColorSistema(TipoCon);
            lblUsuario.ForeColor = ValidationForms.GetColorSistema(TipoCon);
            toolStripStatusLabel6.ForeColor = ValidationForms.GetColorSistema(TipoCon);
            lblFecha.ForeColor = ValidationForms.GetColorSistema(TipoCon);
            Text = Validaciones.NombreCompany(TipoCon) + @" - MENÚ PRINICIPAL";
            statusStrip.BackColor = ValidationForms.GetColorSistema(TipoCon);
            toolStripStatusLabel1.ForeColor = Color.White;
            lblVersion.ForeColor = Color.White;
            toolStripStatusLabel4.ForeColor = Color.White;
            lblUsuario.ForeColor = Color.White;
            toolStripStatusLabel6.ForeColor = Color.White;
            lblFecha.ForeColor = Color.White;

            //var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            switch (TipoCon)
            {
                case TipoConexion.Seportpac:
                    Icon = Resources.logo_s;
                    tslLogo.BackgroundImage = Resources.SeportPac_Wall;
                    this.BackgroundImage = Resources.Seport_wall;
                    this.BackgroundImageLayout = ImageLayout.Stretch;



                    toolStrip1.BackColor = Color.FromArgb(66, 66, 66);   //ValidationForms.GetColorSistema(TipoCon);
                    statusStrip.BackColor = Color.FromArgb(66, 66, 66);// ValidationForms.GetColorSistema(TipoCon);

                    //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                    //Primary.Grey800, Primary.Grey800, Primary.Grey600,
                    //Accent.Indigo700, TextShade.WHITE);
                                       


                    break;

                case TipoConexion.Asenava:
                    Icon = Resources.logo_a;
                    tslLogo.BackgroundImage = Resources.Cisepro_Wall;
                    break;
                default: // CISEPRO
                    Icon = Resources.logo_c;
                    tslLogo.BackgroundImage = Resources.Cisepro_Wall;
                    this.BackgroundImage = Resources.Your_paragraph_text;
                    this.BackgroundImageLayout = ImageLayout.Stretch;


                    

                    toolStrip1.BackColor = Color.FromArgb(21, 101, 192);   //ValidationForms.GetColorSistema(TipoCon);
                    statusStrip.BackColor = Color.FromArgb(21, 101, 192); // ValidationForms.GetColorSistema(TipoCon);
                    //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                    //Primary.Blue800, Primary.Blue800, Primary.Blue600,
                    //Accent.LightBlue200, TextShade.WHITE);

                    

                    
                    
                    



                    break;

            }


            notifyIcon1.BalloonTipTitle = @"Notificación para: " + Settings.Default.Usuario;
            notifyIcon1.Icon = Icon;
            notifyIcon1.Text = Validaciones.NombreCompany(TipoCon);
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;

            lblFecha.Text = ObjUsuario.Now(TipoCon).ToLongDateString();
            lblUsuario.Text = ObjUsuario.ObtenerNombrePersonalXIdUser(TipoCon, ObjUsuario.IdPersonal + "") + @"    ";

            OcultarOpcionesSegunUsuario();
            SecuencialContrato();

            LoadPrincipal();
            ValidarFechas();
        }

       
        private void SecuencialContrato()
        {
            bool res = true;
            var hoy = ObjUsuario.ObtenerFechaSola(TipoCon);
            var secucon = _objPersonal.SeleccionarContadorSecuencial(TipoCon);
            if (secucon.Rows.Count == 0) {
                res = ComandosSql.ProcesarComando(TipoCon, _objPersonal.NuevoContadorSecuencial(1, 1, hoy.Year));
            }
            else {
                if (Convert.ToInt32(secucon.Rows[0][2]) < hoy.Year) res = ComandosSql.ProcesarComando(TipoCon, _objPersonal.NuevoContadorSecuencial(Convert.ToInt32(secucon.Rows[0][0]) + 1, 1, hoy.Year));
            }

            if (res) return;
            KryptonMessageBox.Show(@"Error al generar SECUENCIAL DE CONTRATOS!. Por favor, contácte al administrador!", @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK , KryptonMessageBoxIcon.Information );
            Close();
        }
            
        private void OcultarOpcionesSegunUsuario()
        {
            if (ObjUsuario == null) return;
            if (ObjUsuario.TipoUsuario == null) return;

            List<string> menuUnoList = new List<string>(menuUno);
            // ADMINISTRADOR
            // CONTABILIDAD 
            // OPERACIONES
            // MONIOREO
            // RRHH
              
                       
            if (ObjUsuario.TipoUsuario.Trim().Contains("ADMINISTRADOR"))
            {
                btnChange.Visible = ObjUsuario.Datos.Equals("JORGE AGUIRRE VEGA") || ObjUsuario.Datos.Equals("GALLARDO ROMERO CARLOS ALBERTO") || ObjUsuario.Datos.Equals("ELENA ARTEAGA CORO"); //|| ObjUsuario.Datos.Equals("JONAS BONILLA RUIZ");
                IsAdmin = true;
                tsRecursoHumano.DropDownItems["dESCUENTOSPERSONALToolStripMenuItem"].Visible = ObjUsuario.Datos.Equals("JORGE AGUIRRE VEGA") || ObjUsuario.Datos.Equals("GALLARDO ROMERO CARLOS ALBERTO") || ObjUsuario.Datos.Equals("NATALIA VIVAS");
                sITIOSDETRABAJOTOLSTRPIMENUITEM.Visible = true;
            }
            #region Menu

            #region Menu 1 Administracion
            // Menu 1 Administracion 
            tsAdministracion.Visible = ObjPermiso.BuscarMenuUnoUsuario(TipoCon, ObjUsuario.IdRol,1);
            
            eSTRUCTURAADMINISTRATIVAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,1,1);
            SetTool(eSTRUCTURAADMINISTRATIVAToolStripMenuItem, "Roboto", 9);
            mODIFICARESTRUCTURAADMINISTRATIVAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,1,1,1);
            SetTool(mODIFICARESTRUCTURAADMINISTRATIVAToolStripMenuItem, "Roboto", 9);
            rEGISTRARCARGOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,1,1,2);
            SetTool(rEGISTRARCARGOSToolStripMenuItem, "Roboto", 9);
            aPROBACIÓNDEORDENDECOMPRAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,1,2);
            SetTool(aPROBACIÓNDEORDENDECOMPRAToolStripMenuItem, "Roboto", 9);
            aPROBACIÓNDECOMPROBANTESEGRESOBANCOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,1,3);
            SetTool(aPROBACIÓNDECOMPROBANTESEGRESOBANCOSToolStripMenuItem, "Roboto", 9);
            rEVISIÓNDELIQUIDACIONESToolStripMenuItem1.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,1,4);
            SetTool(rEVISIÓNDELIQUIDACIONESToolStripMenuItem1, "Roboto", 9);
            lIQUIDACIÓNCAJACHICAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,1,4,3);
            SetTool(lIQUIDACIÓNCAJACHICAToolStripMenuItem, "Roboto", 9);
            lIQUIDACIONFONDOROTATIVOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,1,4,4);
            SetTool(lIQUIDACIONFONDOROTATIVOToolStripMenuItem, "Roboto", 9);
            rEVISIÓNDEFACTURACIÓNToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,1,5);
            SetTool(rEVISIÓNDEFACTURACIÓNToolStripMenuItem, "Roboto", 9);
            rEVISARFACTURASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,1,5,5);
            SetTool(rEVISARFACTURASToolStripMenuItem, "Roboto", 9);
            rEVISARSECUENCIALESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,1,5,6);
            SetTool(rEVISARSECUENCIALESToolStripMenuItem, "Roboto", 9);
            cONFIGURACIÓNToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,1,6);
            SetTool(cONFIGURACIÓNToolStripMenuItem, "Roboto", 9);
            uSUARIOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,1,6,7);
            SetTool(uSUARIOSToolStripMenuItem, "Roboto", 9);
            pARÁMETROSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,1,6,8);
            SetTool(pARÁMETROSToolStripMenuItem, "Roboto", 9);
            rOLESYPERMISOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,1,6,9);
            SetTool(rOLESYPERMISOSToolStripMenuItem, "Roboto", 9);
            #endregion

            #region Menu Activos Fijos
            // Menu 2  Activos Fijos  
            tsActivosFijos.Visible = ObjPermiso.BuscarMenuUnoUsuario(TipoCon, ObjUsuario.IdRol,2);
            iNGRESOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,2,7);
            SetTool(iNGRESOToolStripMenuItem, "Roboto", 9);
            iNGRESODEACTIVOSFIJOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,7,10);
            SetTool(iNGRESODEACTIVOSFIJOSToolStripMenuItem, "Roboto", 9);
            iNGRESODEVEHICULOSDIRECTIVOSYSUPERVICIONESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,7,11);
            SetTool(iNGRESODEVEHICULOSDIRECTIVOSYSUPERVICIONESToolStripMenuItem, "Roboto", 9);
            iNGRESODECODIGOSDEACTIVOSFIJOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,7,12);
            SetTool(iNGRESODECODIGOSDEACTIVOSFIJOSToolStripMenuItem, "Roboto", 9);
            aCTUALIZACIÓNToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,2,8);
            SetTool(aCTUALIZACIÓNToolStripMenuItem, "Roboto", 9);
            aCTUALIZACIONDECOSTOSDEMANTENIMIENTOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,8,13);
            SetTool(aCTUALIZACIONDECOSTOSDEMANTENIMIENTOSToolStripMenuItem, "Roboto", 9);
            aCTUALIZACIONDESEGUROSYDISPOSITIVOSDESEGURIDADENVEHÍCULOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,8,14);
            SetTool(aCTUALIZACIONDESEGUROSYDISPOSITIVOSDESEGURIDADENVEHÍCULOSToolStripMenuItem, "Roboto", 9);
            mANTENIMIENTODEPARÁMETROSDEACTIVOSFIJOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,8,15);
            SetTool(mANTENIMIENTODEPARÁMETROSDEACTIVOSFIJOSToolStripMenuItem, "Roboto", 9);
            tRANSFERENCIASDEACTIVOSFIJOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,2,9);
            SetTool(tRANSFERENCIASDEACTIVOSFIJOSToolStripMenuItem, "Roboto", 9);
            bAJASDEACTIVOSFIJOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,2,10);
            SetTool(bAJASDEACTIVOSFIJOSToolStripMenuItem, "Roboto", 9);
            dEPRECIACIONESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,2,11);
            SetTool(dEPRECIACIONESToolStripMenuItem, "Roboto", 9);
            rOTACIONDEVEHICULOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,2,12);
            SetTool(rOTACIONDEVEHICULOSToolStripMenuItem, "Roboto", 9);
            gENERARSTICKERSCONCODIGOSDEACTIVOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,2,13);
            SetTool(gENERARSTICKERSCONCODIGOSDEACTIVOSToolStripMenuItem, "Roboto", 9);
            cONSULTASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,2,14);
            SetTool(cONSULTASToolStripMenuItem, "Roboto", 9);
            cONSULTADEACTIVOSFIJOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,14,16);
            SetTool(cONSULTADEACTIVOSFIJOSToolStripMenuItem, "Roboto", 9);
            cONSULTADETRANSFERENCIASDEACTIVOSFIJOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,14,17);
            SetTool(cONSULTADETRANSFERENCIASDEACTIVOSFIJOSToolStripMenuItem, "Roboto", 9);
            cONSULTARDEMANTENIMIENTOSDEACTIVOSFIJOSPRÓXIMOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,14,18);
            SetTool(cONSULTARDEMANTENIMIENTOSDEACTIVOSFIJOSPRÓXIMOSToolStripMenuItem, "Roboto", 9);
            cOSULTADEMANTENIMIENTOSDEACTIVOSFIJOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,14,19);
            SetTool(cOSULTADEMANTENIMIENTOSDEACTIVOSFIJOSToolStripMenuItem, "Roboto", 9);
            cONSULTADEBAJASREALIZADASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,14,20);
            SetTool(cONSULTADEBAJASREALIZADASToolStripMenuItem, "Roboto", 9);
            cONSULTADEDEPRECIACIONESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,14,21);
            SetTool(cONSULTADEDEPRECIACIONESToolStripMenuItem, "Roboto", 9);
            cONSULTADEROTACIONESDEVEHICULOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,14,22);
            SetTool(cONSULTADEROTACIONESDEVEHICULOSToolStripMenuItem, "Roboto", 9);
            cONSULTARSOATPROXIMOSAVENCERToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,14,23);
            SetTool(cONSULTARSOATPROXIMOSAVENCERToolStripMenuItem, "Roboto", 9);
            cONSULTARSEGUROSYDISPOSITIVOSPROXIMOSAVENCERToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,14,24);
            SetTool(cONSULTARSEGUROSYDISPOSITIVOSPROXIMOSAVENCERToolStripMenuItem, "Roboto", 9);
            cONSULTARHISTORIALDESEGUROSDEVEHICULOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,14,25);
            SetTool(cONSULTARHISTORIALDESEGUROSDEVEHICULOSToolStripMenuItem, "Roboto", 9);
            aUXILIARESMANTENIMIENTOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,14,26);
            SetTool(aUXILIARESMANTENIMIENTOSToolStripMenuItem, "Roboto", 9);
            rEPORTESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,2,15);
            SetTool(rEPORTESToolStripMenuItem, "Roboto", 9);
            rEPORTEDECODIGOSDEACTIVOSFIJOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,15,27);
            SetTool(rEPORTEDECODIGOSDEACTIVOSFIJOSToolStripMenuItem, "Roboto", 9);
            rEPORTEDEACTIVOFIJOPORCUSTODIOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,15,28);
            SetTool(rEPORTEDEACTIVOFIJOPORCUSTODIOToolStripMenuItem, "Roboto", 9);
            rEPORTEDETRANSFERENCIAREALIZADASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,15,29);
            SetTool(rEPORTEDETRANSFERENCIAREALIZADASToolStripMenuItem, "Roboto", 9);
            rEPORTEDEMANTENIMIENTOSREALIZADOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,15,30);
            SetTool(rEPORTEDEMANTENIMIENTOSREALIZADOSToolStripMenuItem, "Roboto", 9);
            rEPORTEDEDEPRECIACIONESREALIZADASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,15,31);
            SetTool(rEPORTEDEDEPRECIACIONESREALIZADASToolStripMenuItem, "Roboto", 9);
            rEPORTEDEACTIVOSFIJOSINGRESADOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,15,32);
            SetTool(rEPORTEDEACTIVOSFIJOSINGRESADOSToolStripMenuItem, "Roboto", 9);
            rEPORTEDEBAJASREALIZADASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,2,15,33);
            SetTool(rEPORTEDEBAJASREALIZADASToolStripMenuItem, "Roboto", 9);
            #endregion

            #region Menu 3 Fondos
            // Menu 3 Fondos
            tsFondos.Visible = ObjPermiso.BuscarMenuUnoUsuario(TipoCon, ObjUsuario.IdRol,3);
            fONDODECAJACHICAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,3,16);
            SetTool(fONDODECAJACHICAToolStripMenuItem, "Roboto", 9);
            sOLICITUDDEGASTOCAJACHICAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,3,16,34);
            SetTool(sOLICITUDDEGASTOCAJACHICAToolStripMenuItem, "Roboto", 9);
            lIQUIDACIÓNCAJACHICAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,3,16,35);
            SetTool(lIQUIDACIÓNCAJACHICAToolStripMenuItem, "Roboto", 9);
            sOLICITUDDEFONDOROTATIVOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,3,16,36); // Establecer Caja Chica
            SetTool(sOLICITUDDEFONDOROTATIVOToolStripMenuItem, "Roboto", 9);
            pARÁMETROSDEACTIVIDADYCONCEPTOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,3,16,37);
            SetTool(pARÁMETROSDEACTIVIDADYCONCEPTOToolStripMenuItem, "Roboto", 9);
            pARÁMETROSDEAUTORIZACIONESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,3,16,38);
            SetTool(pARÁMETROSDEAUTORIZACIONESToolStripMenuItem, "Roboto", 9);
            fONDOROTATIVOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,3,17);
            SetTool(fONDOROTATIVOToolStripMenuItem, "Roboto", 9);
            sOLICITUDDEFONDOROTATIVOToolStripMenuItem1.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,3,17,39);// Solicitud de Fondo Rotativo
            SetTool(sOLICITUDDEFONDOROTATIVOToolStripMenuItem1, "Roboto", 9);
            lIQUIDACIONFONDOROTATIVOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 3, 17, 40);
            SetTool(lIQUIDACIONFONDOROTATIVOToolStripMenuItem, "Roboto", 9);
            dEFINIRFONDOROTATIVOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,3,17,41);
            SetTool(dEFINIRFONDOROTATIVOToolStripMenuItem, "Roboto", 9);
            dEFINIRCONCEPTOSFONDOROTATIVOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,3,17,42);
            SetTool(dEFINIRCONCEPTOSFONDOROTATIVOToolStripMenuItem, "Roboto", 9);
            dEFINIRRESPONSABLESAUTORIZACIONToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,3,17,43);
            SetTool(dEFINIRRESPONSABLESAUTORIZACIONToolStripMenuItem, "Roboto", 9);
            rEPORTELIQUIDACIONFONDOROTATIVOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,3,17,44);
            SetTool(rEPORTELIQUIDACIONFONDOROTATIVOToolStripMenuItem, "Roboto", 9);
            rEPORTESOLICITUDESFONDOROTATIVOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,3,17,45);
            SetTool(rEPORTESOLICITUDESFONDOROTATIVOToolStripMenuItem, "Roboto", 9);
            rEPORTECONTROLCOMBUSTIBLEToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,3,17,46);
            SetTool(rEPORTECONTROLCOMBUSTIBLEToolStripMenuItem, "Roboto", 9);
            #endregion

            #region Menu 4 Contabilidad
            //Menu 4 Contabilidad
            tsContabilidad.Visible = ObjPermiso.BuscarMenuUnoUsuario(TipoCon, ObjUsuario.IdRol, 4);
            lIBRODIARIOGENERALToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,4,18);
            SetTool(lIBRODIARIOGENERALToolStripMenuItem, "Roboto", 9);
            vERLIBRODIARIOGENERALToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,4,18,47);
            SetTool(vERLIBRODIARIOGENERALToolStripMenuItem, "Roboto", 9);
            nUEVOAJUSTEASIENTODEDIARIOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,4,18,48);
            SetTool(nUEVOAJUSTEASIENTODEDIARIOToolStripMenuItem, "Roboto", 9);
            mANTENIMIENTODEPLANDECUENTASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,4,18,49);
            SetTool(mANTENIMIENTODEPLANDECUENTASToolStripMenuItem, "Roboto", 9);
            rEPORTEDEPLANDECUENTASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,4,18,50);
            SetTool(rEPORTEDEPLANDECUENTASToolStripMenuItem, "Roboto", 9);
            cENTROCOSTOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,4,19);
            SetTool(cENTROCOSTOToolStripMenuItem, "Roboto", 9);
            dEFINIRCENTROCOSTOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,4,19,51);
            SetTool(dEFINIRCENTROCOSTOToolStripMenuItem, "Roboto", 9);
            rEVISIONDELIQUIDACIONESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,4,20);
            SetTool(rEVISIONDELIQUIDACIONESToolStripMenuItem, "Roboto", 9);
            lIQUIDACIONESFONDOCAJACHICAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,4,20,52);
            SetTool(lIQUIDACIONESFONDOCAJACHICAToolStripMenuItem, "Roboto", 9);
            lIQUIDACIONESFONDOROTATIVOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,4,20,53);
            SetTool(lIQUIDACIONESFONDOROTATIVOToolStripMenuItem, "Roboto", 9);
            bANCOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol,4,21);
            SetTool(bANCOSToolStripMenuItem, "Roboto", 9);
            cOMPROBANTEDEEGRESOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,4,21,54);
            SetTool(cOMPROBANTEDEEGRESOToolStripMenuItem, "Roboto", 9);
            cOMPROBANTEDEINGRESOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,4,21,55);
            SetTool(cOMPROBANTEDEINGRESOToolStripMenuItem, "Roboto", 9);
            rEVISIÓNCHEQUESEMITIDOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,4,21,56);
            SetTool(rEVISIÓNCHEQUESEMITIDOSToolStripMenuItem, "Roboto", 9);
            rEVISIÓNDÉBITOSBANCARIOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,4,21,57);
            SetTool(rEVISIÓNDÉBITOSBANCARIOSToolStripMenuItem, "Roboto", 9);
            dEFINIRBANCOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol,4,21,58);
            SetTool(dEFINICIÓNDEHORARIOSHORASEXTRAToolStripMenuItem, "Roboto", 9);
            aSIGNARCUENTASBANCOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 21, 59);
            SetTool(aSIGNARCUENTASBANCOSToolStripMenuItem, "Roboto", 9);
            bUSCARCOMPROBANTEEGRESOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 21, 60);
            SetTool(bUSCARCOMPROBANTEEGRESOToolStripMenuItem, "Roboto", 9);
            bUSCARCOMPROBANTEINGRESOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 21, 61);
            SetTool(bUSCARCOMPROBANTEINGRESOToolStripMenuItem, "Roboto", 9);
            aNULARCOMPROBANTESDEEGRESOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 21, 62);
            SetTool(aNULARCOMPROBANTESDEEGRESOToolStripMenuItem, "Roboto", 9);
            aNULARCOMPROBANTESDEINGRESOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 21, 63);
            SetTool(aNULARCOMPROBANTESDEINGRESOToolStripMenuItem, "Roboto", 9);
            cARGARCOMPROBANTESDEEGRESOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 21, 64);
            SetTool(cARGARCOMPROBANTESDEEGRESOToolStripMenuItem, "Roboto", 9);
            cARGARCOMPROBANTESDEINGRESOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 21, 65);
            SetTool(cARGARCOMPROBANTESDEINGRESOToolStripMenuItem, "Roboto", 9);
            cRUCEDECUENTASBANCOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 21, 66);
            SetTool(cRUCEDECUENTASBANCOSToolStripMenuItem, "Roboto", 9);
            rEPORTEDEBANCOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 21, 67);
            SetTool(rEPORTEDEBANCOSToolStripMenuItem, "Roboto", 9);
            cOMPRASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 4, 22);
            SetTool(cOMPRASToolStripMenuItem, "Roboto", 9);
            rEQUISICIÓNDEPRODUCTOSSERVICIOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 68);
            SetTool(rEQUISICIÓNDEPRODUCTOSSERVICIOSToolStripMenuItem, "Roboto", 9);
            aPROBACIÓNDEREQUISICIÓNDEPRODUCTOSERVICIOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 69);
            SetTool(aPROBACIÓNDEREQUISICIÓNDEPRODUCTOSERVICIOToolStripMenuItem, "Roboto", 9);
            nUEVAORDENDECOMPRAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 70);
            SetTool(nUEVAORDENDECOMPRAToolStripMenuItem, "Roboto", 9);
            bUSCARORDENDECOMPRAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 71);
            SetTool(bUSCARORDENDECOMPRAToolStripMenuItem, "Roboto", 9);
            rEGISTRODECOMPROBANTESDECOMPRAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 72);
            SetTool(rEGISTRODECOMPROBANTESDECOMPRAToolStripMenuItem, "Roboto", 9);
            bUSCARCOMPROBANTESDECOMPRAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 73);
            SetTool(bUSCARCOMPROBANTESDECOMPRAToolStripMenuItem, "Roboto", 9);
            aJUSTARCOMPROBANTESCOMPRAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 74);
            SetTool(aJUSTARCOMPROBANTESCOMPRAToolStripMenuItem, "Roboto", 9);
            aNULARCOMPROBANTESDECOMPRAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 75);
            SetTool(aNULARCOMPROBANTESDECOMPRAToolStripMenuItem, "Roboto", 9);
            rEGISTROCOMPORBANTESDERETENCIONtoolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 76);
            SetTool(rEGISTROCOMPORBANTESDERETENCIONtoolStripMenuItem, "Roboto", 9);
            aJUSTARCOMPROBANTESDERETENCIÓNToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 77);
            SetTool(aJUSTARCOMPROBANTESDERETENCIÓNToolStripMenuItem, "Roboto", 9);
            rEGISTRODEPAGOSACOMPROBANTESDECOMPRAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 78);
            SetTool(rEGISTRODEPAGOSACOMPROBANTESDECOMPRAToolStripMenuItem, "Roboto", 9);
            mANTENIMINETOPROVEEDORESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 79);
            SetTool(mANTENIMINETOPROVEEDORESToolStripMenuItem, "Roboto", 9);
            rEGISTRODEDATOSPROVEEDORESCALIFICADOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 80);
            SetTool(rEGISTRODEDATOSPROVEEDORESCALIFICADOSToolStripMenuItem, "Roboto", 9);
            eVALUACIONPROVEEDORESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 81);
            SetTool(eVALUACIONPROVEEDORESToolStripMenuItem, "Roboto", 9);
            bUSCAREVALUACIONPROVEEDORESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 22, 82);
            SetTool(bUSCAREVALUACIONPROVEEDORESToolStripMenuItem, "Roboto", 9);
            cLIENTESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 4, 23);
            SetTool(cLIENTESToolStripMenuItem, "Roboto", 9);
            mANTENIMIENTOSDECLIENTESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 23, 83);
            SetTool(mANTENIMIENTOSDECLIENTESToolStripMenuItem, "Roboto", 9);
            gENERARFACTURAELECTRONICAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 23, 84);
            SetTool(gENERARFACTURAELECTRONICAToolStripMenuItem, "Roboto", 9);
            TOTALFACTURADOtoolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 23, 85);
            SetTool(TOTALFACTURADOtoolStripMenuItem, "Roboto", 9);
            vENTASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 4, 24);
            SetTool(vENTASToolStripMenuItem, "Roboto", 9);
            fACTURACIONToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 24, 86);
            SetTool(fACTURACIONToolStripMenuItem, "Roboto", 9);
            aJUSTARFACTURASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 24, 87);
            SetTool(aJUSTARFACTURASToolStripMenuItem, "Roboto", 9);
            aNULARFACTURASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 24, 88);
            SetTool(aNULARFACTURASToolStripMenuItem, "Roboto", 9);
            rEGISTRORETENCIONESDEFACTURASEMITIDASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 24, 89);
            SetTool(rEGISTRORETENCIONESDEFACTURASEMITIDASToolStripMenuItem, "Roboto", 9);
            aJUSTARRETENCIONESDEFACTURASEMITIDASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 24, 90);
            SetTool(aJUSTARRETENCIONESDEFACTURASEMITIDASToolStripMenuItem, "Roboto", 9);
            cONSULTADEFACTURASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 24, 91);
            SetTool(cONSULTADEFACTURASToolStripMenuItem, "Roboto", 9);
            iMPRIMIRFACTURAVENTAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 24, 92);
            SetTool(iMPRIMIRFACTURAVENTAToolStripMenuItem, "Roboto", 9);
            nOTADECRÉDITOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 24, 93);
            SetTool(nOTADECRÉDITOToolStripMenuItem, "Roboto", 9);
            aNULARNOTADECRÉDITOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 24, 94);
            SetTool(aNULARNOTADECRÉDITOToolStripMenuItem, "Roboto", 9);
            cONSULTADENOTASDECRÉDITOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 24, 95);
            SetTool(cONSULTADENOTASDECRÉDITOToolStripMenuItem, "Roboto", 9);
            sRIToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 4, 25);
            SetTool(sRIToolStripMenuItem, "Roboto", 9);
            iNFORMACIONDELAEMPRESAToolStripMenuItem1.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 25, 96);
            SetTool(iNFORMACIONDELAEMPRESAToolStripMenuItem1, "Roboto", 9);
            pORCENTAJERETENCIONRENTAtoolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 25, 97);
            SetTool(pORCENTAJERETENCIONRENTAtoolStripMenuItem, "Roboto", 9);
            pORCENTAJERETENCIONIVAtoolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 25, 98);
            SetTool(pORCENTAJERETENCIONIVAtoolStripMenuItem, "Roboto", 9);
            aTSSIMPLIFICADOToolStripMenuItem1.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 25, 99);
            SetTool(aTSSIMPLIFICADOToolStripMenuItem1, "Roboto", 9);
            cUENTASPORPAGARToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 4, 26);
            SetTool(cUENTASPORPAGARToolStripMenuItem, "Roboto", 9);
            cONSULTADECUENTASPORPAGARToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 26, 100);
            SetTool(cONSULTADECUENTASPORPAGARToolStripMenuItem, "Roboto", 9);
            dETALLEDECUENTASPORPAGARToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 26, 101);
            SetTool(dETALLEDECUENTASPORPAGARToolStripMenuItem, "Roboto", 9);
            cUENTASPORCOBRARToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 4, 27);
            SetTool(cUENTASPORCOBRARToolStripMenuItem, "Roboto", 9);
            cONSULTADECUENTASPORCOBRARToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 27, 102);
            SetTool(cONSULTADECUENTASPORCOBRARToolStripMenuItem, "Roboto", 9);
            dETALLEDECUENTASPORCOBRARToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 27, 103);
            SetTool(dETALLEDECUENTASPORCOBRARToolStripMenuItem, "Roboto", 9);
            dETALLEDECUENTASCLIENTESINCONVENIOtoolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 27, 104);
            SetTool(dETALLEDECUENTASCLIENTESINCONVENIOtoolStripMenuItem, "Roboto", 9);
            dETALLEDECUENTASCLIENTECONVENIOtoolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 27, 105);
            SetTool(dETALLEDECUENTASCLIENTECONVENIOtoolStripMenuItem, "Roboto", 9);
            aUXILIARESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 4, 28);
            SetTool(aUXILIARESToolStripMenuItem, "Roboto", 9);
            aUXILIARESCOMPRASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 28, 106);
            SetTool(aUXILIARESCOMPRASToolStripMenuItem, "Roboto", 9);
            aUXILIARESDIARIOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 28, 107);
            SetTool(aUXILIARESDIARIOSToolStripMenuItem, "Roboto", 9);
            aUXILIARESMAYORESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 28, 108);
            SetTool(aUXILIARESMAYORESToolStripMenuItem, "Roboto", 9);
            aUXILIARESLIQUIDACIONESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 28, 109);
            SetTool(aUXILIARESLIQUIDACIONESToolStripMenuItem, "Roboto", 9);
            aUXILIARESPAGOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 28, 110);
            SetTool(aUXILIARESPAGOSToolStripMenuItem, "Roboto", 9);
            eSTABLECERSALDOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 4, 29);
            SetTool(eSTABLECERSALDOSToolStripMenuItem, "Roboto", 9);
            rEPORTESCONTABLESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 4, 30);
            SetTool(rEPORTESCONTABLESToolStripMenuItem, "Roboto", 9);
            mAYORIZACIÓNToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 30, 111);
            SetTool(mAYORIZACIÓNToolStripMenuItem, "Roboto", 9);
            bALANCEDECOMPROBACIÓNToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 30, 112);
            SetTool(bALANCEDECOMPROBACIÓNToolStripMenuItem, "Roboto", 9);
            eSTADODEPÉRDIDASYGANANCIASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 30, 113);
            SetTool(eSTADODEPÉRDIDASYGANANCIASToolStripMenuItem, "Roboto", 9);
            bALANCEFINALToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 4, 30, 114);
            SetTool(bALANCEFINALToolStripMenuItem, "Roboto", 9);

            #endregion

            #region Menu 5 RRHH

            //Menu 5 RRHH

            tsRecursoHumano.Visible = ObjPermiso.BuscarMenuUnoUsuario(TipoCon, ObjUsuario.IdRol, 5);
            rEGISTROPROYECTOCONTRATACIONtoolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 5, 31);
            SetTool(rEGISTROPROYECTOCONTRATACIONtoolStripMenuItem, "Roboto", 9);
            rEGISTRODEASPIRANTESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 5, 32);
            SetTool(rEGISTRODEASPIRANTESToolStripMenuItem, "Roboto", 9);
            rEGISTRODEPERSONALToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 5, 33);
            SetTool(rEGISTRODEPERSONALToolStripMenuItem, "Roboto", 9);
            aDMINISTRARCUENTASBANCARIASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 5, 34);
            SetTool(aDMINISTRARCUENTASBANCARIASToolStripMenuItem, "Roboto", 9);
            vACACIONESPERMISOSDESCMÉDToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 5, 35);
            SetTool(vACACIONESPERMISOSDESCMÉDToolStripMenuItem, "Roboto", 9);
            rEGISTRARPERMISOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 5, 35, 115);
            SetTool(rEGISTRARPERMISOSToolStripMenuItem, "Roboto", 9);
            rEGISTARVACACIONESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 5, 35, 116);
            SetTool(rEGISTARVACACIONESToolStripMenuItem, "Roboto", 9);
            gENEARTICKETDEFARMACIAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 5, 35, 117);
            SetTool(gENEARTICKETDEFARMACIAToolStripMenuItem, "Roboto", 9);
            pENDIENTESDEVACACIONESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 5, 35, 118);
            SetTool(pENDIENTESDEVACACIONESToolStripMenuItem, "Roboto", 9);
            rEPORTEDEVACACIONESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 5, 35, 119);
            SetTool(rEPORTEDEVACACIONESToolStripMenuItem, "Roboto", 9);
            rEGISTRONOTIFICACIONDOCLEGALtoolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 5, 35, 120);
            SetTool(rEGISTRONOTIFICACIONDOCLEGALtoolStripMenuItem, "Roboto", 9);
            cREDENCIALDOCUMENTOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 5, 36);
            SetTool(cREDENCIALDOCUMENTOSToolStripMenuItem, "Roboto", 9);
            dESCUENTOSPERSONALToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 5, 37);
            SetTool(dESCUENTOSPERSONALToolStripMenuItem, "Roboto", 9);
            rOLDEPAGOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 5, 38);
            SetTool(rOLDEPAGOSToolStripMenuItem, "Roboto", 9);
            salidaPersonaltoolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 5, 39);
            SetTool(salidaPersonaltoolStripMenuItem, "Roboto", 9);
            iNFORMEDEPAGOtoolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 5, 40);
            SetTool(iNFORMEDEPAGOtoolStripMenuItem, "Roboto", 9);
            rEPORTESToolStripMenuItem1.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 5, 41);
            SetTool(rEPORTESToolStripMenuItem1, "Roboto", 9);
            rEPORTEGENERALDEPERSONALToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 5, 41, 121);
            SetTool(rEPORTEGENERALDEPERSONALToolStripMenuItem, "Roboto", 9);
            aSISTENCIAOPERATIVOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 5, 41, 122);
            SetTool(aSISTENCIAOPERATIVOSToolStripMenuItem, "Roboto", 9);
            rESÚMENPAGOSNÓMINAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 5, 41, 123);
            SetTool(rESÚMENPAGOSNÓMINAToolStripMenuItem, "Roboto", 9);
            cUMPLEAÑEROSToolStripMenuItem1.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 5, 41, 124); 
            SetTool(cUMPLEAÑEROSToolStripMenuItem1, "Roboto", 9);

            #endregion

            #region Menu 6 Operaciones
            // Menu 6 Operaciones

            tsOperaciones.Visible = ObjPermiso.BuscarMenuUnoUsuario(TipoCon, ObjUsuario.IdRol, 6);
            dIVISIÓNPOLÍTICADELPAISToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 6, 42);
            SetTool(dIVISIÓNPOLÍTICADELPAISToolStripMenuItem, "Roboto", 9);
            sITIOSDETRABAJOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 6, 43);
            SetTool(sITIOSDETRABAJOToolStripMenuItem, "Roboto", 9);
            pROGRAMACIÓNGENERALToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 6, 44);
            SetTool(pROGRAMACIÓNGENERALToolStripMenuItem, "Roboto", 9);
            rEPORTEASISTENCIAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 6, 45);
            SetTool(rEPORTEASISTENCIAToolStripMenuItem, "Roboto", 9);
            rEGISTRARSANCIÓNMULTAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 6, 46);
            SetTool(rEGISTRARSANCIÓNMULTAToolStripMenuItem, "Roboto", 9);
            oRDENREVISIÓNTÉCNICAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 6, 47);
            SetTool(oRDENREVISIÓNTÉCNICAToolStripMenuItem, "Roboto", 9);
            dEFINICIÓNDEHORARIOSHORASEXTRAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 6, 48);
            SetTool(dEFINICIÓNDEHORARIOSHORASEXTRAToolStripMenuItem, "Roboto", 9);
            dEFINICIÓNDESANCIONESYOMULTASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 6, 49);
            SetTool(dEFINICIÓNDESANCIONESYOMULTASToolStripMenuItem, "Roboto", 9);
            iNGRESOSSALIDASDELPERSONALToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 6, 50);
            SetTool(iNGRESOSSALIDASDELPERSONALToolStripMenuItem, "Roboto", 9);
            iNGRESOSSALIDASDELPERSONALToolStripMenuItem1.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 6, 50, 125); 
            SetTool(iNGRESOSSALIDASDELPERSONALToolStripMenuItem1, "Roboto", 9);

            #endregion

            #region Menu 7 Bodega
            // Menu 7 Bodega

            tsBodega.Visible = ObjPermiso.BuscarMenuUnoUsuario(TipoCon, ObjUsuario.IdRol, 7);
            bODEGASToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 7, 51);
            SetTool(bODEGASToolStripMenuItem, "Roboto", 9);
            cATEGORÍASGRUPOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 7, 52);
            SetTool(cATEGORÍASGRUPOSToolStripMenuItem, "Roboto", 9);
            uBICACIONESENBODEGAToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 7, 53);
            SetTool(uBICACIONESENBODEGAToolStripMenuItem, "Roboto", 9);
            aRTÍCULOSPRODUCTOSToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 7, 54);
            SetTool(aRTÍCULOSPRODUCTOSToolStripMenuItem, "Roboto", 9);
            kARDEXToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 7, 55);
            SetTool(kARDEXToolStripMenuItem, "Roboto", 9);
            aSIGNARPROVEEDORAITEMToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 7, 56);
            SetTool(aSIGNARPROVEEDORAITEMToolStripMenuItem, "Roboto", 9);
            cOMPROBANTESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 7, 57);
            SetTool(cOMPROBANTESToolStripMenuItem, "Roboto", 9);
            cOMPROBANTEDEEGRESOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 7, 57, 126);
            SetTool(cOMPROBANTEDEEGRESOToolStripMenuItem, "Roboto", 9);
            cOMPROBANTEDEINGRESOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 7, 57, 127);
            SetTool(cOMPROBANTEDEINGRESOToolStripMenuItem, "Roboto", 9);
            eNTREGADEUNIFORMESToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 7, 57, 128);
            SetTool(eNTREGADEUNIFORMESToolStripMenuItem, "Roboto", 9);
            rEPORTESToolStripMenuItem2.Visible = ObjPermiso.BuscarMenuDosUsuario(TipoCon, ObjUsuario.IdRol, 7, 58);
            SetTool(rEPORTESToolStripMenuItem2, "Roboto", 9);
            cONTROLPORPERSONALToolStripMenuItem1.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 7, 58, 129);
            SetTool(cONTROLPORPERSONALToolStripMenuItem1, "Roboto", 9);
            rEPORTESITIOTRABAJOToolStripMenuItem.Visible = ObjPermiso.BuscarMenuTresUsuario(TipoCon, ObjUsuario.IdRol, 7, 58, 130);
            SetTool(rEPORTESITIOTRABAJOToolStripMenuItem, "Roboto", 9);

            #endregion

            #endregion Menu


            //if (Convert.ToInt32(ObjUsuario.IdRol) == 2) 


            if (ObjUsuario.TipoUsuario.Trim().Contains("CONTABILIDAD"))
            {
            //    tsAdministracion.Visible = false;
            //    tsRecursoHumano.Visible = true;
            //    toolStripMenuItem2.Visible = true; //SITIOSDETRABAJO
            //    tsOperaciones.Visible = false;
            //    tsBodega.Visible = false;
                btnChange.Visible = false;
            //    aNULARCOMPROBANTESDECOMPRAToolStripMenuItem.Visible = false;
            //    aNULARFACTURASToolStripMenuItem.Visible = false;
            //    aNULARNOTADECRÉDITOToolStripMenuItem.Visible = false;
            }
            if (ObjUsuario.TipoUsuario.Trim().Contains("RR.HH"))
            {
            //    tsAdministracion.Visible = false;
            //    toolStripMenuItem2.Visible = true;
            //    tsActivosFijos.Visible = false;
            //    tsFondos.Visible = false;
            //    tsContabilidad.Visible = true;
            //    tsOperaciones.Visible = false;
            //    tsBodega.Visible = true;
                if (ObjUsuario.Datos.Equals("ELENA ARTEAGA CORO"))
                    btnChange.Visible = true;
                else
                btnChange.Visible = false;
               tsRecursoHumano.DropDownItems["dESCUENTOSPERSONALToolStripMenuItem"].Visible = ObjUsuario.Datos.Equals("MONICA ARMIJOS") || ObjUsuario.Datos.Equals("MARJORIE LOOR") || ObjUsuario.Datos.Equals("NATALIA") || ObjUsuario.Datos.Equals("ELENA ARTEAGA CORO");
            }

            if (ObjUsuario.TipoUsuario.Trim().Contains("OPERACIONES"))
            {
            //    tsAdministracion.Visible = false;
            //    tsActivosFijos.Visible = false;
            //    tsFondos.Visible = false;
            //    tsContabilidad.Visible = false;
            //    tsRecursoHumano.Visible = false;
            //    tsBodega.Visible = false;
                btnChange.Visible = false;
            }
            if (ObjUsuario.TipoUsuario.Trim().Contains("MONITOREO"))
            {
            //    tsOperaciones.Text = @"MONITOREO";
            //    tsAdministracion.Visible = false;
            //    tsActivosFijos.Visible = false;
            //    tsFondos.Visible = false;
            //    tsContabilidad.Visible = false;
            //    tsRecursoHumano.Visible = false;
            //    tsBodega.Visible = false;
            //    dIVISIÓNPOLÍTICADELPAISToolStripMenuItem.Visible = false;
            //    toolStripSeparator28.Visible = false;
                btnChange.Visible = false;
            //    iNGRESOSSALIDASDELPERSONALToolStripMenuItem.Visible = false;
            }
        }

        private void MdiParentMain_Load(object sender, EventArgs e)
        {
            // CARGAR ICONO Y DESIEÑO SEGUN SISTEMA
            DefinirTipoSistema();             
            timer1.Start();

            //Image image = Resources.Your_paragraph_text__2_;
            // AdjustImageToFit(pictureBox1, image);

            
            

        }

        private void SetTool(ToolStripMenuItem toolstripMenu, string fontName, float fontSize)
        {
           Font font = new Font(fontName, fontSize);
            toolstripMenu.Font = font;

        }

        private void MdiParentMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (KryptonMessageBox.Show(@"Está seguro que desea salir del sistema?", @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) !=
                DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            timer1.Stop();

            ObjUsuario.SalirSistema(TipoCon);

            Dispose();
            GC.SuppressFinalize(this);
            Application.Exit();
        }

        private void ValidarFechas()
        {
            var hoy = ObjUsuario.ObtenerFechaSola(TipoCon);

            _fechaInicialMesActual = new DateTime(hoy.Year, hoy.Month, 1);
            _fechaFinalMesActual = _fechaInicialMesActual.AddMonths(1).AddDays(-1);

            var ant = _fechaInicialMesActual.AddMonths(-1);
            _fechaInicialMesAnterior = new DateTime(ant.Year, ant.Month, 1);
            _fechaFinalMesAnterior = _fechaInicialMesAnterior.AddMonths(1).AddDays(-1);
        }

        private void LoadPrincipal()
        {
            var r = ObjUsuario.ObtenerRutasDocsEltectronicos(TipoCon);
            var rs = r.Split('~');
            Settings.Default.RutaAts = rs[0];
            Settings.Default.RutaDocsElec = rs[1];
            Settings.Default.RutaFirmElec = rs[2];
            Settings.Default.Save();

            
            if (string.IsNullOrEmpty(r)) // CLAVE DEBE COINCIDER EN MAYÚSCULAS Y/O MINÚSCULAS
            {
                KryptonMessageBox.Show(@"Error al cargar rutas del sistema!", @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                Close();
            }

             //.Office2010Blue;
            var mayorIdLibro = _objLibroDiario.BuscarMayorIdLibroDiario(TipoCon) + 1;
            var fechaUltimoLibro = _objLibroDiario.BuscarFechaLibroDiarioXIdLibroDiario(TipoCon, mayorIdLibro - 1);
            var hoy = ObjUsuario.ObtenerFechaSola(TipoCon);

            if (fechaUltimoLibro == DateTime.MinValue)
            {
                KryptonMessageBox.Show(@"Error al generar LIBRO DIARIO  de hoy. Por favor, contácte al administrador!", @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                Close();
            }

            if (fechaUltimoLibro >= hoy) return;

            _objLibroDiario.IdLibroDiarioGeneral = mayorIdLibro;
            _objLibroDiario.FechaLibroDiarioGeneral = hoy;
            _objLibroDiario.TotalDebeLibrodiarioGeneral = 0;
            _objLibroDiario.TotalHaberLibroDiarioGeneral = 0;
            _objLibroDiario.EstadoLibroDiarioGeneral = 1;

            var res = ComandosSql.ProcesarComando(TipoCon, _objLibroDiario.NuevoRegistroLibroDiario());

            if (res) return;
            KryptonMessageBox.Show(@"Error al generar LIBRO DIARIO  de hoy. Por favor, contácte al administrador!", @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            Close();
        }

        #region ADMINISTRACION
        private void mODIFICARESTRUCTURAADMINISTRATIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmEstructuraAdministrativa.Instancia.MdiParent = this;
            FrmEstructuraAdministrativa.TipoCon = TipoCon;
            FrmEstructuraAdministrativa.Usuario = ObjUsuario;
            FrmEstructuraAdministrativa.Instancia.Show();
            FrmEstructuraAdministrativa.Instancia.BringToFront();
        }
        private void rEGISTRARCARGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargo.Instancia.MdiParent = this;
            FrmCargo.TipoCon = TipoCon;
            FrmCargo.Usuario = ObjUsuario;
            FrmCargo.Instancia.Show();
            FrmCargo.Instancia.BringToFront();
        }
        private void aPROBACIÓNDEORDENDECOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAprobacionOrdenCompra.Instancia.MdiParent = this;
            FrmAprobacionOrdenCompra.TipoCon = TipoCon;
            FrmAprobacionOrdenCompra.Usuario = ObjUsuario;
            FrmAprobacionOrdenCompra.Instancia.Show();
            FrmAprobacionOrdenCompra.Instancia.BringToFront();
        }
        private void aPROBACIÓNDECOMPROBANTESEGRESOBANCOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormAprobacionComprobantesEgresoBancos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
         
            f.Show();
        }
        private void lIQUIDACIÓNFONDOROTATIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.LIQUIDACIONES.FormRevisionLiquidaciones { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void lIQUIDACIÓNCAJACHICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.LIQUIDACIONES.FormRevisionLiquidacionesCajaChica { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEVISARFACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormrRevisionFacturacionVentas { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEVISARSECUENCIALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormGenerarSecuencialesFacturacion { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ESTRUCTURA_ADMINISTRATIVA.FormMantenimientoUsuario { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, User = ObjUsuario.Datos, Isadm = ObjUsuario.TipoUsuario.Equals("ADMINISTRADOR") };
            f.Show();
        }
        private void cALCULOSRUBROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.RUBROS_Y_PARAMETROS.FormRubros { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void tIPODOCUMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.RUBROS_Y_PARAMETROS.FormParametrosDocumentos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void uNIDADMEDIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.RUBROS_Y_PARAMETROS.FormUnidadMedida { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        #endregion

        #region ACTIVOS FIJOS
        private void iNGRESODEACTIVOSFIJOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormIngresoActivosFijos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void iNGRESODEVEHICULOSDIRECTIVOSYSUPERVICIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormVehiculosOtros { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void iNGRESODECODIGOSDEACTIVOSFIJOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormAgregarCategoria { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void aCTUALIZACIONDECOSTOSDEMANTENIMIENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormActualizarCostosSolicitudesMantenimientos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void aCTUALIZACIONDESEGUROSYDISPOSITIVOSDESEGURIDADENVEHÍCULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormActualizacionSegurosVehiculos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void mANTENIMIENTODEPARÁMETROSDEACTIVOSFIJOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormMantenimientoMarcasMaterialesColores { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cONSULTADEACTIVOSFIJOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS.FormConsultaActivosFijos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cONSULTADETRANSFERENCIASDEACTIVOSFIJOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS.FormConsultaTransferencias { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cOSULTADEMANTENIMIENTOSDEACTIVOSFIJOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS.FormConsultaMantenimientos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cONSULTARDEMANTENIMIENTOSDEACTIVOSFIJOSPRÓXIMOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS.FormConsultaMantenimientosProximos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cONSULTADEBAJASREALIZADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS.FormConsultaBajas { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cONSULTADEDEPRECIACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS.FormConsultaDepreciaciones { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cONSULTADEROTACIONESDEVEHICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS.FormConsultaRotaciones { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cONSULTARSOATPROXIMOSAVENCERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormSoat { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cONSULTARSEGUROSYDISPOSITIVOSPROXIMOSAVENCERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS.FormConsultarProximosSegurosVencidos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cONSULTARHISTORIALDESEGUROSDEVEHICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormHistorialSegurosVehiculos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void aUXILIARESMANTENIMIENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormAuxiliarMantenimientos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEPORTEDECODIGOSDEACTIVOSFIJOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.REPORTES.FormReporteCodigosActivos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEPORTEDEACTIVOFIJOPORCUSTODIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.REPORTES.FormReporteActivoFijoPorCustodio { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEPORTEDETRANSFERENCIAREALIZADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ib = new FrmInputBox { TipoCon = TipoCon, Titulo = "BUSCAR MANTENIMIENTO REALIZADO", Mensaje = "INGRESE EL N° DE TRANSFERENCIA" };
            if (ib.ShowDialog() != DialogResult.OK) return;
            if (ib.textBox1.Text.Trim().Length == 0)
            {
                KryptonMessageBox.Show(@"Debe ingresar el n° de transferencia para consultar!",
                    @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.REPORTES.FormReporteTransferenciasActivosFijos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, IdTransferencia = ib.textBox1.Text.Trim() };
            f.Show();
        }
        private void rEPORTEDEMANTENIMIENTOSREALIZADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ib = new FrmInputBox { TipoCon = TipoCon, Titulo = "BUSCAR MANTENIMIENTO REALIZADO", Mensaje = "INGRESE EL N° DE MANTENIMIENTO" };
            if (ib.ShowDialog() != DialogResult.OK) return;
            if (ib.textBox1.Text.Trim().Length == 0)
            {
                KryptonMessageBox.Show(@"Debe ingresar el n° de transferncia para consultar!",
                    @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.REPORTES.FormReporteMantenimientosActivosFijos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, LblId = ib.textBox1.Text.Trim() };
            f.Show();
        }
        private void rEPORTEDEDEPRECIACIONESREALIZADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ib = new FrmInputBox { TipoCon = TipoCon, Titulo = "BUSCAR DEPRECIACIÓN REALIZADA", Mensaje = "INGRESE EL N° DE DEPRECIACIÓN" };
            if (ib.ShowDialog() != DialogResult.OK) return;
            if (ib.textBox1.Text.Trim().Length == 0)
            {
                KryptonMessageBox.Show(@"Debe ingresar el n° de transferncia para consultar!",
                    @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.REPORTES.FormReporteDepreciaciones { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, Id = ib.textBox1.Text.Trim() };
            f.Show();
        }
        private void rEPORTEDEACTIVOSFIJOSINGRESADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.REPORTES.FormReporteIngresosActivosFijos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEPORTEDEBAJASREALIZADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ib = new FrmInputBox { TipoCon = TipoCon, Titulo = "BUSCAR BAJA REALIZADA", Mensaje = "INGRESE EL N° DE BAJA" };
            if (ib.ShowDialog() != DialogResult.OK) return;
            if (ib.textBox1.Text.Trim().Length == 0)
            {
                KryptonMessageBox.Show(@"Debe ingresar el n° de transferncia para consultar!",
                    @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                return;
            }

            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.REPORTES.FormReporteBajas { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, Id = ib.textBox1.Text.Trim() };
            f.Show();
        }
        private void tRANSFERENCIASDEACTIVOSFIJOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormTransferenciasActivosFijos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void bAJASDEACTIVOSFIJOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormBajasActivosFijos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void dEPRECIACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormDepreciaciones { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rOTACIONDEVEHICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.PROCESOS.FormRotacionVehiculos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void gENERARSTICKERSCONCODIGOSDEACTIVOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ACTIVOS_FIJOS.REPORTES.FormReporteActivosFijosImprimirCodigos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        #endregion

        #region FONDOS
        private void sOLICITUDDEGASTOCAJACHICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_CAJA_CHICA.FormSolicitudGastoCajaChica { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, RutaDocsElec = Settings.Default.RutaDocsElec, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void lIQUIDACIÓNDECAJACHICAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_CAJA_CHICA.FormLiquidacionCajasChicas { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos  };
            f.Show();
        }
        private void sOLICITUDDEFONDOROTATIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_CAJA_CHICA.FormEstablecerCajasChicas { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void pARÁMETROSDEACTIVIDADYCONCEPTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_CAJA_CHICA.FormParametrosActividadYConcepto { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void pARÁMETROSDEAUTORIZACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_CAJA_CHICA.FormParametrosAutorizacionesCajaChica { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void sOLICITUDDEFONDOROTATIVOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_ROTATIVO.FormSolicitudFondoRotativo { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, RutaDocsElec = Settings.Default.RutaDocsElec, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void lIQUIDACIONFONDOROTATIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_ROTATIVO.FormLiquidacionFondoRotativo { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void dEFINIRFONDOROTATIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_ROTATIVO.FormFondoRotativo { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void dEFINIRCONCEPTOSFONDOROTATIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_ROTATIVO.FormGastosFondoRotativo { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void dEFINIRRESPONSABLESAUTORIZACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_ROTATIVO.FormResponsableAutorizacionFondoRotativo { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEPORTESOLICITUDESFONDOROTATIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES.FormReporteSolicitudFondoRotativo { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void rEPORTECONTROLCOMBUSTIBLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES.FormBuscarReporteControlCombustibleGeneral { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEPORTELIQUIDACIONFONDOROTATIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.FONDOS.FONDO_ROTATIVO.FormBuscarLiquidacionFondoRotativo { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        #endregion

        #region CONTABILIDAD
        private void vERLIBRODIARIOGENERALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO.FormAsientosLibroDiario { MdiParent = this, TipoCox = TipoCox, IsAdmin = IsAdmin, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void nUEVOAJUSTEASIENTODEDIARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO.FormAjustarAsientosLibroDiario { MdiParent = this, TipoCox = TipoCox, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void mANTENIMIENTODEPLANDECUENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ESTRUCTURA_ADMINISTRATIVA.FormIngresoPlanCuentas { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEPORTEDEPLANDECUENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.ESTRUCTURA_ADMINISTRATIVA.REPORTES.FormReportePlanDeCuentas { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void dEFINIRCENTROCOSTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.CENTRO_COSTO.FormCentroCosto { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void lIQUIDACIONESFONDOROTATIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.LIQUIDACIONES.FormRevisionLiquidaciones { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void lIQUIDACIONESFONDOCAJACHICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.LIQUIDACIONES.FormRevisionLiquidacionesCajaChica { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void cOMPROBANTEDEEGRESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormComprobanteEgresoBanco { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void cOMPROBANTEDEINGRESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormComprobanteIngresoBanco { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void rEVISIÓNCHEQUESEMITIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormRevisionChequesEmitidos { MdiParent = this, TipoCox = TipoCox, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void rEVISIÓNDÉBITOSBANCARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FrmGenerarDebitoBancarioClientes { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void dEFINIRBANCOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormRegistroBancos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void aSIGNARCUENTASBANCOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormCuentasBancos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void bUSCARCOMPROBANTEEGRESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormBuscarComprobanteEgresoBancos { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void bUSCARCOMPROBANTEINGRESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormBuscarComprobanteIngresoBaNcos { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void aNULARCOMPROBANTESDEEGRESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormAnularComprobanteEgresoBancos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void aNULARCOMPROBANTESDEINGRESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormAnularComprobanteIngresoBancos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void cARGARCOMPROBANTESDEEGRESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormCargarComprobantesEgresoBanco { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void cARGARCOMPROBANTESDEINGRESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormCargarComprobantesIngresoBanco { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void cRUCEDECUENTASBANCOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormCruzeCuentasEgresoIngreso { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void rEPORTEDEBANCOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.FormLibroBancos { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEQUISICIÓNDEPRODUCTOSSERVICIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.REQUERIMIENTOS.FormRequisicionProductoServicio { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void aPROBACIÓNDEREQUISICIÓNDEPRODUCTOSERVICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.REQUERIMIENTOS.FormAprovacionRequisicion { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void nUEVAORDENDECOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA.FormOrdenCompra { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void bUSCARORDENDECOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA.FormBuscarOrdenCompra { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEGISTRODECOMPROBANTESDECOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.FormRegistroComprobanteCompra { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, RutaDocsElec = Settings.Default.RutaDocsElec, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void aJUSTARCOMPROBANTESCOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.FormAjustarComprobantesCompra { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void bUSCARCOMPROBANTESDECOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.FormBuscarComprobantesCompra { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, RutaDocsElec = Settings.Default.RutaDocsElec };
            f.Show();
        }
        private void aNULARCOMPROBANTESDECOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.FormAnularComprobantesCompra { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        } 
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.FormComprobantesRetencionCompras { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, RutaDocsElec = Settings.Default.RutaDocsElec, UserName = ObjUsuario.Datos };
            f.Show();
        } 
        private void aJUSTARCOMPROBANTESDERETENCIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.FormAjustarComprobantesRetencionCompras { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };            
            f.Show();
        }
        private void rEGISTRODEPAGOSACOMPROBANTESDECOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.FormPagoComprobantesCompra { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void mANTENIMINETOPROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES.FormMantenimientoProveedores { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEGISTRODEDATOSPROVEEDORESCALIFICADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES.FormMantenimientoProveedorCalificado { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void eVALUACIONPROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES.FormEvaluacionProveedores { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void bUSCAREVALUACIONPROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES.FormBuscarEvaluacionProveedor { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void mANTENIMIENTOSDECLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormMantenimientoClientes { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void gENERARFACTURAELECTRONICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormGenerarFacturasElectronicas { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, RutaDocsElec = Settings.Default.RutaDocsElec, RutaFirmElec = Settings.Default.RutaFirmElec };
            f.Show();
        }
        private void TOTALFACTURADOtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FrmFacturadoPorClienteAnual { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void fACTURACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormFacturaVenta { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, RutaDocsElec = Settings.Default.RutaDocsElec, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void aJUSTARFACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormAjustarFacturasVenta { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void aNULARFACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormAnularFacturas { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void rEGISTRORETENCIONESDEFACTURASEMITIDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormRegistroComprobanteRetencionVenta { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void aJUSTARRETENCIONESDEFACTURASEMITIDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormAjustarComprobantesRetencionVentas { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void cONSULTADEFACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormConsultaFacturasVenta { MdiParent = this, TipoCox = TipoCox, RutaDocsElec = Settings.Default.RutaDocsElec };
            f.Show();
        }
        private void iMPRIMIRFACTURAVENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormReporteFacturaVenta { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void nOTADECRÉDITOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormNotaCredito { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, RutaDocsElec = Settings.Default.RutaDocsElec, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void aNULARNOTADECRÉDITOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormAnularNotaCredito { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void cONSULTADENOTASDECRÉDITOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.VENTAS.FormConsultaNotasCredito { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, RutaDocsElec = Settings.Default.RutaDocsElec};
            f.Show();
        }
        private void iNFORMACIONDELAEMPRESAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.SRI.FormInformacionTributaria { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmPorcentajesRetencion.Instancia.MdiParent = this;
            FrmPorcentajesRetencion.TipoCon = TipoCon;
            FrmPorcentajesRetencion.Usuario = ObjUsuario;
            FrmPorcentajesRetencion.Instancia.Show();
            FrmPorcentajesRetencion.Instancia.BringToFront();
        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmPorcentajesRetencionIva.Instancia.MdiParent = this;
            FrmPorcentajesRetencionIva.TipoCon = TipoCon;
            FrmPorcentajesRetencionIva.Usuario = ObjUsuario;
            FrmPorcentajesRetencionIva.Instancia.Show();
            FrmPorcentajesRetencionIva.Instancia.BringToFront();
        }  
        private void aNEXOTRANSACCIONALATSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.SRI.FormAnexoTransaccional { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void aTSSIMPLIFICADOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.SRI.FormAtsSimplificado { MdiParent = this, TipoCox = TipoCox, RutaAts = Settings.Default.RutaAts };
            f.Show();
        }       
        private void cONSULTADECUENTASPORPAGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.CUENTAS_POR_PAGAR.FrmCuentasPorPagarMin { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void dETALLEDECUENTASPORPAGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.CUENTAS_POR_PAGAR.FormCuentasPorPagar { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cONSULTADECUENTASPORCOBRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.CUENTAS_POR_COBRAR.FrmCuentasCobrarGeneralMin { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void dETALLEDECUENTASPORCOBRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.CUENTAS_POR_COBRAR.FormCuentasPorCobrarGeneral { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cONSULTACOMPRASASIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.AUXILIARES.FormAuxiliaresVentas { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void aUXILIARCOMPRASRETENCIONASIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.FormAuxiliarComprobantesCompraRetencionAsiento { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void aUXILIARESDIARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.AUXILIARES.FormAuxiliaresDiario { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void aUXILIARESMAYORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.AUXILIARES.FormAuxiliares { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void aUXILIARESLIQUIDACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.AUXILIARES.FormAuxiliaresLiquidaciones { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void aUXILIARESPAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.AUXILIARES.FormAuxiliarPagos { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void eSTADODESITUACIONINICIALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BALANCE.FormEstadoSituacionInicial { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void mAYORIZACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.MAYORIZACION.FormMayorizacion { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void bALANCEDECOMPROBACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BALANCE.FormBalanceComprobacion { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void gENERALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.PERDIDAS_Y_GANANCIAS.FormEstadoPerdidasYGanancias { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void dETALLADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.PERDIDAS_Y_GANANCIAS.FrmBalancePerdidasYGananciasComparativo { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void bALANCEFINALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.BALANCE.FormBalanceFinal { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }
        private void eSTABLECERSALDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.MAYORIZACION.FormSaldosMayores { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        #endregion

        #region TALENTO HUMANO
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmPoryectoContratacion.Instancia.MdiParent = this;
            FrmPoryectoContratacion.TipoCon = TipoCon;
            FrmPoryectoContratacion.Usuario = ObjUsuario;
            FrmPoryectoContratacion.Instancia.Show();
            FrmPoryectoContratacion.Instancia.BringToFront();
        }
        private void rEGISTRODEPERSONALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonal.Instancia.MdiParent = this;
            FrmPersonal.TipoCon = TipoCon;
            FrmPersonal.Usuario = ObjUsuario;
            FrmPersonal.Instancia.Show();
            FrmPersonal.Instancia.BringToFront();
        }
        private void aDMINISTRARCUENTASBANCARIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuentasBancarias.Instancia.MdiParent = this;
            FrmCuentasBancarias.TipoCon = TipoCon;
            FrmCuentasBancarias.Usuario = ObjUsuario;
            FrmCuentasBancarias.Instancia.Show();
            FrmCuentasBancarias.Instancia.BringToFront();
        }
        private void cREDENCIALDOCUMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerarCredencial.Instancia.MdiParent = this;
            FrmGenerarCredencial.Usuario = ObjUsuario;
            FrmGenerarCredencial.TipoCon = TipoCon;
            FrmGenerarCredencial.Instancia.Show();
            FrmGenerarCredencial.Instancia.BringToFront();
        }
        private void rEGISTRARPERMISOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPermisos.Instancia.MdiParent = this;
            FrmPermisos.TipoCon = TipoCon;
            FrmPermisos.Usuario = ObjUsuario;
            FrmPermisos.Instancia.Show();
            FrmPermisos.Instancia.BringToFront();
        }
        private void rEGISTRODEVACACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVacaciones.Instancia.MdiParent = this;
            FrmVacaciones.TipoCon = TipoCon;
            FrmVacaciones.Usuario = ObjUsuario;
            FrmVacaciones.Instancia.Show();
            FrmVacaciones.Instancia.BringToFront();
        }
        private void rEPORTEDEVACACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteVacaciones.Instancia.MdiParent = this;
            FrmReporteVacaciones.TipoCon = TipoCon;
            FrmReporteVacaciones.Usuario = ObjUsuario;
            FrmReporteVacaciones.Instancia.Show();
            FrmReporteVacaciones.Instancia.BringToFront();
        }
        private void pENDIENTESDEVACACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPendientesVcaciones.Instancia.MdiParent = this;
            FrmPendientesVcaciones.TipoCon = TipoCon;
            FrmPendientesVcaciones.Usuario = ObjUsuario;
            FrmPendientesVcaciones.Instancia.Show();
            FrmPendientesVcaciones.Instancia.BringToFront();
        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmNotificaciones.Instancia.MdiParent = this;
            FrmNotificaciones.TipoCon = TipoCon;
            FrmNotificaciones.Usuario = ObjUsuario;
            FrmNotificaciones.Instancia.Show();
            FrmNotificaciones.Instancia.BringToFront();
        }   
        private void dESCUENTOSPERSONALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDescuentos.Instancia.MdiParent = this;
            FrmDescuentos.TipoCon = TipoCon;
            FrmDescuentos.Usuario = ObjUsuario;
            FrmDescuentos.Instancia.Show();
            FrmDescuentos.Instancia.BringToFront();
        }
        private void rOLDEPAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            FrmRolPago.Instancia.MdiParent = this;
            FrmRolPago.TipoCon = TipoCon;
            FrmRolPago.Usuario = ObjUsuario;
            FrmRolPago.Instancia.Show();
            FrmRolPago.Instancia.BringToFront();


        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmInformesPago.Instancia.MdiParent = this;
            FrmInformesPago.TipoCon = TipoCon;
            FrmInformesPago.Usuario = ObjUsuario;
            FrmInformesPago.Instancia.Show();
            FrmInformesPago.Instancia.BringToFront();
        }
        private void cUMPLEAÑEROSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCumpleanosPersonal.Instancia.MdiParent = this;
            FrmCumpleanosPersonal.TipoCon = TipoCon;
            FrmCumpleanosPersonal.Usuario = ObjUsuario;
            FrmCumpleanosPersonal.Instancia.Show();
            FrmCumpleanosPersonal.Instancia.BringToFront();
        }
        private void rEPORTEGENERALDEPERSONALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportePersonalGeneral.Instancia.MdiParent = this;
            FrmReportePersonalGeneral.TipoCon = TipoCon;
            FrmReportePersonalGeneral.Usuario = ObjUsuario;
            FrmReportePersonalGeneral.Instancia.Show();
            FrmReportePersonalGeneral.Instancia.BringToFront();
        }
        private void rESÚMENPAGOSNÓMINAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteGeneralNomina.Instancia.MdiParent = this;
            FrmReporteGeneralNomina.TipoCon = TipoCon;
            FrmReporteGeneralNomina.Usuario = ObjUsuario;
            FrmReporteGeneralNomina.Instancia.Show();
            FrmReporteGeneralNomina.Instancia.BringToFront();
        }
        private void aSISTENCIAOPERATIVOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.OPERACIONES.FrmAsistenciaRrhh { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }

        #endregion

        #region OPERACIONES
        private void dIVISIÓNPOLÍTICADELPAISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDivisionGeografica.Instancia.MdiParent = this;
            FrmDivisionGeografica.TipoCon = TipoCon;
            FrmDivisionGeografica.Usuario = ObjUsuario;
            FrmDivisionGeografica.Instancia.Show();
            FrmDivisionGeografica.Instancia.BringToFront();
        }
        private void sITIOSDETRABAJOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.DIVISION_GEOGRÁFICA.FormSitiosTrabajo { MdiParent = this, TipoCox = TipoCox }; 
            f.Show();
        }
        private void pROGRAMACIÓNGENERALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.OPERACIONES.FrmProgramacionGeneral { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void rEPORTEASISTENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.OPERACIONES.FrmReporteAsistencia { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, Admin = IsAdmin, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void rEGISTRARSANCIÓNMULTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.OPERACIONES.FrmRegistrarSancionPersonal { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void dEFINICIÓNDEHORARIOSHORASEXTRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.OPERACIONES.FrmProgramacionHorarios { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void dEFINICIÓNDESANCIONESYOMULTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.TALENTO_HUMANO.FrmSancionesPersonal { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void iNGRESOSSALIDASDELPERSONALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReportePersonalGeneral.Instancia.MdiParent = this;
            FrmReportePersonalGeneral.TipoCon = TipoCon;
            FrmReportePersonalGeneral.Usuario = ObjUsuario;
            FrmReportePersonalGeneral.Instancia.Show();
            FrmReportePersonalGeneral.Instancia.BringToFront();
        }  
        #endregion

        #region BODEGA
        private void bODEGASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBodega.Instancia.MdiParent = this;
            FrmBodega.TipoCon = TipoCon;
            FrmBodega.Usuario = ObjUsuario;
            FrmBodega.Instancia.Show();
            FrmBodega.Instancia.BringToFront();
        }
        private void cATEGORÍASGRUPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.INVENTARIOS.PROCESO.FormItemsBodega { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void uBICACIONESENBODEGAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.INVENTARIOS.PROCESO.FormUbicacionesBodega { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void aRTÍCULOSPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.INVENTARIOS.PROCESO.FormProductosBodega { MdiParent = this, TipoCox = TipoCox, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void kARDEXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.INVENTARIOS.PROCESO.FormKardex { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void aSIGNARPROVEEDORAITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.INVENTARIOS.PROCESO.FormAsignarProveedorAItem { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void eGRESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.INVENTARIOS.COMPROBANTES.FormComprobanteEgresoBodega { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
        }
        private void iNGRESOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.INVENTARIOS.COMPROBANTES.FormComprobanteIngresoBodega { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario, UserName = ObjUsuario.Datos };
            f.Show();
            f.BringToFront();
        }
        private void eNTREGADEUNIFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.INVENTARIOS.COMPROBANTES.FormEntregaUniformes { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }
        private void cONTROLPORPERSONALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.INVENTARIOS.PROCESO.FormControlUniformes { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }

        private void rEPORTESITIOTRABAJOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            FrmReporteSitioBodega.Instancia.MdiParent = this;
            FrmReporteSitioBodega.TipoCon = TipoCon;
            FrmReporteSitioBodega.Usuario = ObjUsuario;
            FrmReporteSitioBodega.Instancia.Show();
            FrmReporteSitioBodega.Instancia.BringToFront();

            
        }   
        #endregion

        #region UTILIDADES
        private void toolStripButtonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calc.exe");
            }
            catch
            {
                KryptonMessageBox.Show(@"Hubo un problema al iniciar CALCULADORA!", @"MENSAJE DEL SISTEMA",
                     KryptonMessageBoxButtons.OK , KryptonMessageBoxIcon.Exclamation);
            }
        }
        private void toolStripButtonNote_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe");
            }
            catch
            {
                KryptonMessageBox.Show(@"Hubo un problema al iniciar BLOC DE NOTAS!", @"MENSAJE DEL SISTEMA",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation);
            }
        }
        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var shellObject = new Shell();
            shellObject.ToggleDesktop();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(@"ESTÁ SEGURO QUE DESEA CAMBIAR EL ENTORNO DE TRABAJO?", @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes) return;
            switch (TipoCon)
            {
                case TipoConexion.Cisepro:
                    TipoCon = TipoConexion.Seportpac;
                    break;
                case TipoConexion.Seportpac:
                    TipoCon = TipoConexion.Asenava;
                    break;
                case TipoConexion.Asenava:
                    TipoCon = TipoConexion.Cisepro;
                    break;
                default:
                    
                    TipoCon = TipoConexion.Seportpac;
                    break;
            }
            DisposeAllButThis();
            DefinirTipoSistema();
        }

        private void toolStripButtonUser_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(@"ESTÁ SEGURO QUE DESEA CAMBIAR DE USUARIO?", @"MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) != DialogResult.Yes) return;

            DisposeAllButThis();            

            timer1.Stop();

            ObjUsuario.SalirSistema(TipoCon);

            Dispose();
            GC.SuppressFinalize(this);

            _frmNewLogin.TipoCon = TipoCon;
            _frmNewLogin.txtPassword.Clear();
            _frmNewLogin.CargarSisitema();
            _frmNewLogin.Show();
        } 

        private void DisposeAllButThis()
        {
            foreach (var frm in MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.DIVISION_GEOGRÁFICA.FormSitiosTrabajo { MdiParent = this, TipoCox = TipoCox };
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                var hoy = ObjUsuario.Now(TipoCon);
                if (hoy.Minute % TiempoNotificacion != 0) return;

                if (ObjUsuario.TipoUsuario.Contains("ADMINISTRADOR"))
                {  
                    _data = _objLibroDiario.SeleccionarRegistrosCodigoCuentaCambiadaLibroDiario(TipoCon);
                    _tipoNoficicacion = 5;
                    notifyIcon1.BalloonTipText = @"ALERTA!!! Existen alteraciones de codigo y cuentas en el libro diario!"; 
                }

                if (ObjUsuario.TipoUsuario.Contains("CONTABILIDAD") && Settings.Default.Usuario.Equals("MABEL"))
                {
                    _data = _objClienteGeneral.BuscarClientesSinFacturarXRangoFecha(TipoCon, _fechaInicialMesActual, _fechaFinalMesActual, _fechaInicialMesAnterior, _fechaFinalMesAnterior);
                    _tipoNoficicacion = 1;
                    notifyIcon1.BalloonTipText = @"ALERTA!!! Existen clientes a los que aún no les ha hecho la facturación correspondiente!"; 
                }

                if (ObjUsuario.TipoUsuario == "RR.HH" && Settings.Default.Usuario.Equals("MARMIJOS"))
                {
                    try
                    {
                        _anios.Clear();
                        for (var i = 0; i <= (DateTime.Now.Year - 2018); i++) _anios.Add(2018 + i);
                        _data = _objDetalleVacaciones.SeleccionarRegistroPendientesVacacionesPorPeriodo(TipoCon, string.Empty, _anios, 0, 1);

                        foreach (DataRow row in _data.Rows)
                        {
                            var fe = Convert.ToDateTime(row[4]);
                            var fx = new DateTime(int.Parse(row[6].ToString().Split('-')[1].Trim()), fe.Month, fe.Day, fe.Hour, fe.Minute, fe.Second);
                            if (fe >= fx) row.Delete();
                        }

                        _tipoNoficicacion = 2;
                        notifyIcon1.BalloonTipText = @"ALERTA!!! Existe personal de guardias que tiene días pendientes de vacaciones! Por favor, coordine con OPERACIONES para procesar la salida correspondiente.";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                if (ObjUsuario.TipoUsuario == "RR.HH" && Settings.Default.Usuario.Equals("ELENA"))
                {
                    try
                    {
                        _data = _objPersonal.SeleccionarPersonalPorCulminarProyecto(TipoCon);
                        _data2 = _objPersonal.SeleccionarPersonalPorCulminar3mesesPrueba(TipoCon);

                        _tipoNoficicacion = 3;
                        notifyIcon1.BalloonTipText = @"ALERTA!!! Existe personal que está por culminar el contrato según el proycto registardo o tiene más de 3 meses (período de prueba)!. Por favor, coordine con OPERACIONES para procesar la salida / reubicación correspondiente.";

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                if (ObjUsuario.TipoUsuario == "RR.HH" && Settings.Default.Usuario.Equals("WILLIAM"))
                {
                    try
                    {
                        _data = _objPersonal.SeleccionarPersonalPor2MesesDocumentacion(TipoCon);
                        _tipoNoficicacion = 6;
                        notifyIcon1.BalloonTipText = @"ALERTA!!! Existe personal que tiene al menos 2 meses desde su ingreso y no ha presentado su documentación!. Por favor, verifique la información correspondiente.";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                if (Settings.Default.Usuario.Equals("NATALIA") || Settings.Default.Usuario.Equals("MAGDALENA") || Settings.Default.Usuario.Equals("MARMIJOS") || Settings.Default.Usuario.Equals("ERIKA"))
                {
                    _data = _objChaleco.SeleccionarChalecosxCaducar(TipoCon);
                    _tipoNoficicacion = 7;
                    notifyIcon1.BalloonTipText = @"ALERTA!!! Aviso por chalecos que estan a punto de expirar su permiso. Por favor, verifique la información correspondiente.";
                }

               



                if (_data.Rows.Count > 0) notifyIcon1.ShowBalloonTip(10000);
            }
            catch (Exception ex)

            {
                Console.WriteLine(@"Error recordatorio facturar: " + ex.Message);
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (_data.Rows.Count == 0) return;
            _frmNotificacion = new FrmNotificarNovedades(TipoCon, ObjUsuario, notifyIcon1.BalloonTipText, _tipoNoficicacion) { DataNotificacion = _data, DataVacaciones = _data2 };
            _frmNotificacion.Show();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            if (_data.Rows.Count == 0) return;
            _frmNotificacion = new FrmNotificarNovedades(TipoCon, ObjUsuario, notifyIcon1.BalloonTipText, _tipoNoficicacion) { DataNotificacion = _data, DataVacaciones = _data2 };
            _frmNotificacion.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.CUENTAS_POR_COBRAR.FrmCuentasPorCobrarGeneralClienteConvenio { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Form f = new syscisepro.FORMULARIOS.CONTABILIDAD.CUENTAS_POR_COBRAR.FrmCuentasPorCobrarGeneralClienteNoConvenio { MdiParent = this, TipoCox = TipoCox, IdUsuario = ObjUsuario.IdUsuario };
            f.Show();
        }

        private void gENEARTICKETDEFARMACIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTicketsFamaciaComecsa.Instancia.MdiParent = this;
            FrmTicketsFamaciaComecsa.TipoCon = TipoCon;
            FrmTicketsFamaciaComecsa.Usuario = ObjUsuario;
            FrmTicketsFamaciaComecsa.Instancia.Show();
            FrmTicketsFamaciaComecsa.Instancia.BringToFront();
        }

        private void oRDENREVISIÓNTÉCNICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenRevisionTecnica.Instancia.MdiParent = this;
            FrmOrdenRevisionTecnica.TipoCon = TipoCon;
            FrmOrdenRevisionTecnica.Usuario = ObjUsuario;
            FrmOrdenRevisionTecnica.Instancia.Show();
            FrmOrdenRevisionTecnica.Instancia.BringToFront();
        }

        private void rEGISTRODEASPIRANTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAspirantes.Instancia.MdiParent = this;
            FrmAspirantes.TipoCon = TipoCon;
            FrmAspirantes.Usuario = ObjUsuario;
            FrmAspirantes.Instancia.Show();
            FrmAspirantes.Instancia.BringToFront();
        }

        private void tsAdministracion_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSalidaPersonal.Instancia.MdiParent = this;
            FrmSalidaPersonal.TipoCon = TipoCon;
            FrmSalidaPersonal.Usuario = ObjUsuario;
            FrmSalidaPersonal.Instancia.Show();
            FrmSalidaPersonal.Instancia.BringToFront();

        }

        private void eSTRUCTURAADMINISTRATIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsActivosFijos_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonPalette1_PalettePaint(object sender, ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs e)
        {

        }

        private void rOLESYPERMISOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRoles.Instancia.MdiParent = this;
            FrmRoles.TipoCon = TipoCon;
            FrmRoles.Usuario = ObjUsuario;
            FrmRoles.Instancia.Show();
            FrmRoles.Instancia.BringToFront();
        }

        private void tsAdministracion_MouseHover(object sender, EventArgs e)
        {
            tsAdministracion.ForeColor = Color.Black;
            tsAdministracion.Image = Resources.manage_accounts_24dp_FILL0_wght400_GRAD0_opsz24__5_;
            
        }
        private void tsAdministracion_MouseLeave(object sender, EventArgs e)
        {
            tsAdministracion.ForeColor = Color.White;
            tsAdministracion.Image = Resources.manage_accounts_24dp_FILL0_wght400_GRAD0_opsz24__1_;
        }

        private void tsActivosFijos_MouseHover(object sender, EventArgs e)
        {
            tsActivosFijos.ForeColor = Color.Black;
            tsActivosFijos.Image = Resources.wallet_20dp_FILL0_wght400_GRAD0_opsz24;
            
        }

        private void tsActivosFijos_MouseLeave(object sender, EventArgs e)
        {
            tsActivosFijos.ForeColor = Color.White;
            tsActivosFijos.Image = Resources.wallet_20dp_FILL0_wght400_GRAD0_opsz20;
        }

        private void tsFondos_MouseHover(object sender, EventArgs e)
        {
            tsFondos.ForeColor = Color.Black;
            tsFondos.Image = Resources.payments_24dp_FILL0_wght400_GRAD0_opsz24__2_;
        }

        private void tsFondos_MouseLeave(object sender, EventArgs e)
        {
            tsFondos.ForeColor = Color.White;
            tsFondos.Image = Resources.payments_24dp_FILL0_wght400_GRAD0_opsz24__1_;
        }

        private void tsContabilidad_MouseHover(object sender, EventArgs e)
        {
            tsContabilidad.ForeColor = Color.Black;
            tsContabilidad.Image = Resources.account_balance_24dp_FILL0_wght400_GRAD0_opsz24;
            
        }

        private void tsContabilidad_MouseLeave(object sender, EventArgs e)
        {
            tsContabilidad.ForeColor = Color.White;
            tsContabilidad.Image = Resources.account_balance_24dp_FILL0_wght400_GRAD0_opsz24__1_;
        }

        private void tsRecursoHumano_MouseHover(object sender, EventArgs e)
        {
            tsRecursoHumano.ForeColor = Color.Black;
            tsRecursoHumano.Image = Resources.groups_24dp_FILL0_wght400_GRAD0_opsz24__1_;
                
        }

        private void tsRecursoHumano_MouseLeave(object sender, EventArgs e)
        {
            tsRecursoHumano.ForeColor = Color.White;
            tsRecursoHumano.Image = Resources.groups_24dp_FILL0_wght400_GRAD0_opsz24;
        }

        private void tsOperaciones_MouseHover(object sender, EventArgs e)
        {
            tsOperaciones.ForeColor = Color.Black;
            tsOperaciones.Image = Resources.security_24dp_FILL0_wght400_GRAD0_opsz24;
        }

        private void tsOperaciones_MouseLeave(object sender, EventArgs e)
        {
            tsOperaciones.ForeColor = Color.White;
            tsOperaciones.Image = Resources.security_24dp_FILL0_wght400_GRAD0_opsz24__1_;
        }

        private void tsBodega_MouseHover(object sender, EventArgs e)
        {
            tsBodega.ForeColor = Color.Black;
            tsBodega.Image = Resources.storefront_20dp_FILL0_wght400_GRAD0_opsz20__2_;
        }

        private void tsBodega_MouseLeave(object sender, EventArgs e)
        {
            tsBodega.ForeColor = Color.White;
            tsBodega.Image = Resources.storefront_20dp_FILL0_wght400_GRAD0_opsz20__1_;
        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BringToFront();
            FrmTablaComparacionCompra.Instancia.MdiParent = this;
            FrmTablaComparacionCompra.TipoCon = TipoCon;
            FrmTablaComparacionCompra.Usuario = ObjUsuario;
            FrmTablaComparacionCompra.Instancia.Show();
            FrmTablaComparacionCompra.Instancia.BringToFront();

        }

        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void aSIENTOSDEROLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AdjustImageToFit(PictureBox pbx, Image image)
        {
            pbx.BackgroundImageLayout = ImageLayout.None;
            pbx.Paint += (sender, e) =>
            {
                PictureBox pb = sender as PictureBox;
                e.Graphics.Clear(pb.BackColor);
                if (image != null)
                {
                    // Calculate the aspect ratio
                    float aspectRatio = (float)image.Width / image.Height;
                    int newWidth, newHeight;

                    // Determine new dimensions based on aspect ratio
                    if (pb.Width / (float)pb.Height > aspectRatio)
                    {
                        newWidth = (int)(pb.Height * aspectRatio);
                        newHeight = pb.Height;
                    }
                    else
                    {
                        newWidth = pb.Width;
                        newHeight = (int)(pb.Width / aspectRatio);
                    }

                    // Calculate position to center the image
                    int posX = (pb.Width - newWidth) / 2;
                    int posY = (pb.Height - newHeight) / 2;

                    e.Graphics.DrawImage(image, new Rectangle(posX, posY, newWidth, newHeight));
                }
            };
        }



    }
}