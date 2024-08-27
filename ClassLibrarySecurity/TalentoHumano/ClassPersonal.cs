using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassPersonal
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdPersonal { get; set; }
        public string CedulaPersonal { get; set; }
        public string NombresPersonal { get; set; }
        public string ApellidosPersonal { get; set; }
        public string ProvinciaPersonal { get; set; }
        public string DireccionPersonal { get; set; }
        public DateTime FechaNacimientoPersonal { get; set; }
        public string SexoPersonal { get; set; }
        public string CiudadPersonal { get; set; }
        public decimal SueldoPersonal { get; set; }
        public string LibretaMilitarPersonal { get; set; }
        public string TipoSangrePersonal { get; set; }
        public string PasaportePersonal { get; set; }
        public decimal PesoPersonal { get; set; }
        public int EdadPersonal { get; set; }
        public string PruebaAntidrogaPersona{ get; set; }
        public DateTime FechaEntradaPersonal { get; set; }
        public DateTime FechaSalidaPersonal { get; set; }
        public int EstadoPersonal { get; set; }
        public int IdAreaPersonal { get; set; }
        public int IdCargoPersonal { get; set; }
        public string UbicacionPersonal { get; set; }
        public string EstadoCivilPersonal { get; set; }
        public string InstruccionPersonal { get; set; } 
        public string MovilPersonal { get; set; }
        public string TelefonoPersonal { get; set; }
        public string EmailPersonal { get; set; }
        public int CantidadHijosPersonal { get; set; }
        public string HistoriaClinicaPersonal { get; set; }
        public string ParroquiaPersonal { get; set; }
        public decimal EstaturaPersonal { get; set; }
        public string DiscapacidadPersonal { get; set; }
        public string ExamenPsicologicoPersonal { get; set; }
        public string LugarExamenPsicologicoPersonal { get; set; }
        public string CursoVigilante { get; set; }
        public string EmisorCursoVigilante { get; set; }
        public string CarnetConadisPersonal { get; set; }
        public string DatosHijosPersonal { get; set; }
        public string DatosEsposaPersonal { get; set; }
        public string CasaPersonal { get; set; }
        public string ArriendoPersonal { get; set; }
        public string DeudorPersonal { get; set; }
        public decimal CantidadDeudaPersonal { get; set; }
        public string AQuienAdeudaPersonal { get; set; }
        public string TrabajoAnteriormentePersonal { get; set; }
        public string AnteriorTrabajoPersonal { get; set; }
        public string CargoAnteriorTrabajoPersonal { get; set; }
        public string MotivoSalidaTrabajoPersonal { get; set; }
        public DateTime EntradaAnteriorPersonal { get; set; }
        public DateTime SalidaAnteriorPersonal { get; set; }
        public string NombresPatronoAnteriorPersonal { get; set; }
        public string TelefonoPatronoAnteriorPersonal { get; set; }
        public string RecomendacionesPersonal { get; set; }
        public string DatosFamiliaresPersonal { get; set; }
        public string DatosEmergenciaPersonal { get; set; }
        public byte[] FotoPersonal { get; set; }
        public byte[] PerfilPersonal { get; set; }
        public string Observacion { get; set; }
        public int Credencial { get; set; }

        public int BuscarMayorId(TipoConexion tipoCon)
        {
            var data =  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorId", true)  ;
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public string BuscarNombresPersonalXIdPersonal(TipoConexion tipoCon, int id)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_PERSONAL", SqlDbType.Int, id } 
            };
            var data =  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT NOMBRES FROM dbo.PERSONAL WHERE   @ID_PERSONAL=ID_PERSONAL;", false, pars);
            return data.Rows.Count == 0 ? string.Empty : data.Rows[0]["NOMBRES"].ToString();
        }

        public string BuscarNombresPersonalXCedula(TipoConexion tipoCon, string ced)
        {
            var pars = new List<object[]>
            {
                new object[] { "CEDULA", SqlDbType.VarChar, ced } 
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT apellidos + ' ' + NOMBRES datos FROM PERSONAL WHERE CEDULA=@CEDULA;", false, pars) ;
            return data.Rows.Count == 0 ? string.Empty : data.Rows[0]["datos"].ToString();
        }

        //public DataTable SeleccionarCumpleaneros(TipoConexion tipoCon, int mi, int mf)
        //{
        //    var sql = "SELECT pe.id_personal as 'ID', pe.APELLIDOS 'APELLIDO', pe.NOMBRES as 'NOMBRES',  si.nombre_sitio_trabajo PUESTO, pe.FECHA_NACIMIENTO 'FECHA', pe.foto FROM PERSONAL pe join sitios_trabajo si on pe.ubicacion=si.id_sitio_trabajo  join area_general ar on pe.id_area = ar.id_area_general where pe.estado_personal = 1 and ar.id_gerencias_general = 1  and MONTH(PE.FECHA_NACIMIENTO) BETWEEN " + mi + " AND " + mf + " order by pe.FECHA_NACIMIENTO";
        //    return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, false) ;
        //}

        //           var pars = new List<object[]>
        //    {
        //        new object[] { "proy", SqlDbType.Int,  proy },
        //        new object[] { "TipoPers", SqlDbType.Int,  tipoPers },
        //        new object[] { "estado", SqlDbType.VarChar,  estado },
        //        new object[] { "FILTRO", SqlDbType.VarChar,  filtro },
        //        new object[] { "ingre", SqlDbType.Bit,  ingre },
        //        new object[] { "orden", SqlDbType.Int,  orden },
        //        new object[] { "desde", SqlDbType.DateTime, desde } ,
        //        new object[] { "hasta", SqlDbType.DateTime, hasta },
            
        //    };
        //    return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarTodosRegistrosPersonalPorFiltros", true, pars);
        //}


        public DataTable SeleccionarCumpleaneros(TipoConexion tipoCon, int mi, int mf)
        {
            var pars = new List<object[]>
                    {
                new object[] { "mi", SqlDbType.Int,  mi },
                new object[] { "mf", SqlDbType.Int, mf },
                    };
            
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_seleccionarCumpleaneros", true, pars);
        }
         
        public DataTable SeleccionarPersonalPorCulminarProyecto(TipoConexion tipoCon)
        { 
            var sql = "select p.id_personal ID, p.fecha_entrada INGRESO, p.cedula CI, p.apellidos + ' ' + p.nombres NOMBRES, s.nombre_sitio_trabajo PUESTO, t.NOMBRE_PROYECTO, t.FECHA_INICIO, t.FECHA_FIN, DATEDIFF(DAY, GETDATE(), t.FECHA_FIN) DIAS from personal p join contrato c on p.id_personal = c.id_personal join CONTRATO_PROYECTO t on c.ID_PROYECTO=t.ID_PROYECTO join sitios_trabajo s on p.ubicacion=s.id_sitio_trabajo join cliente_general g on s.id_cliente_general=g.id_cliente_general where (p.estado_personal = 1 and c.estado_contrato='VIGENTE' and t.ID_PROYECTO > 1) and DATEDIFF(DAY, GETDATE(), t.FECHA_FIN) < 15;";
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, false);
        }

        public DataTable SeleccionarPersonalPorCulminar3mesesPrueba(TipoConexion tipoCon)
        {
            var sql = "select p.id_personal ID, p.fecha_entrada INGRESO, p.cedula CI, p.apellidos + ' ' + p.nombres NOMBRES, s.nombre_sitio_trabajo PUESTO, g.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL CLIENTE from personal p join contrato c on p.id_personal = c.id_personal join sitios_trabajo s on p.ubicacion=s.id_sitio_trabajo join cliente_general g on s.id_cliente_general=g.id_cliente_general where (p.estado_personal = 1 and c.estado_contrato='VIGENTE' and c.TIPO_CONTRATO = 1) and p.fecha_entrada > '2021-01-01 00:00:00' and DATEDIFF(DAY,  c.FECHA_INICIAL_CONTRATO,GETDATE()) > 90;";
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, false);
        }

        public DataTable SeleccionarPersonalPor2MesesDocumentacion(TipoConexion tipoCon)
        {
            var sql = "select p.id_personal ID, p.fecha_entrada INGRESO, p.cedula CI, p.apellidos + ' ' + p.nombres NOMBRES, s.nombre_sitio_trabajo PUESTO, t.NOMBRE_PROYECTO, P.EXAMEN_PSICOLOGICO from personal p join contrato c on p.id_personal = c.id_personal join CONTRATO_PROYECTO t on c.ID_PROYECTO=t.ID_PROYECTO join sitios_trabajo s on p.ubicacion=s.id_sitio_trabajo join cliente_general g on s.id_cliente_general=g.id_cliente_general where C.FECHA_INICIAL_CONTRATO > '2021-07-01 00:00:00' AND (p.estado_personal = 1 and c.estado_contrato='VIGENTE' and c.tipo_contrato=1) and DATEDIFF(DAY,C.FECHA_INICIAL_CONTRATO, GETDATE()) > 45;";
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, false);
        }

        public DataTable SeleccionarRegistroPersonalPorId(TipoConexion tipoCon, int idp)
        {
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.Int,  idp } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select top 1 * from personal where id_personal = @FILTRO;", false, pars);
        }

        public DataTable SeleccionarContadorSecuencial(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select top 1 * from SECUENCIALES_CONTRATOS order by id_secuencia desc", false);
        }

        public DataTable SeleccionarFotoPersonalPorId(TipoConexion tipoCon, int idp)
        { 
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.Int,  idp } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select top 1 foto from personal where id_personal = @FILTRO;", false, pars) ;
        }

        public DataTable SeleccionarPersonal(TipoConexion tipoCon, string fil, bool soloActivos, int tipo)
        {
            var est = soloActivos ? "P.ESTADO_PERSONAL = 1 AND " : string.Empty;
            var tip = tipo == 0 ? string.Empty : tipo == 1 ? "A.id_gerencias_general = 1 AND " : "A.id_gerencias_general = 2 AND ";

            var pars = new List<object[]>
            {
                new object[] { "FIL", SqlDbType.VarChar,  string.Concat("%", fil, "%") } 
            };
            return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select P.ID_PERSONAL, P.CEDULA, P.APELLIDOS + ' ' + P.NOMBRES NOMINA, C.DESCRIPCION, p.*, c.id_cargo_ocupacional, a.nombre_area, a.id_gerencias_general from PERSONAL P  JOIN CARGO_OCUPACIONAL C ON P.ID_CARGO_OCUPACIONAL=C.ID_CARGO_OCUPACIONAL  join area_general a on p.id_area = a.id_area_general WHERE " + est + tip + " (P.CEDULA LIKE @FIL OR P.APELLIDOS LIKE @FIL OR P.NOMBRES LIKE @FIL);", false, pars) ;
        }

        public int BuscarCedulaExistente(TipoConexion tipoCon, string cedula)
        {
            var pars = new List<object[]>
            {
                new object[] { "CEDULA", SqlDbType.VarChar, cedula } 
            };
            var data =   ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCedulaExistente", true, pars)  ;
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable BuscarLegalExistente(TipoConexion tipoCon, string cedula)
        {
            var pars = new List<object[]>
            {
                new object[] { "CEDULA", SqlDbType.VarChar, string.Concat("%", cedula, "%") } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select id_notificacion ID, num_notificacion NUM_DOC, fecha_notificacion FECHA, cedularuc CI_RUC, apellidos_nombres NOMBRE, detalle_notificacion DETALLE  from notificaciones_denuncias where cedularuc like @cedula and estado=1;", false, pars);
        }

        //public DataTable SeleccionarTodosRegistrosPersonalPorFiltros(TipoConexion tipoCon, string filtro, string estado, string desde, string hasta, bool ingre, int orden, int tipoPers, int proy)
        //{


            
        //    var proye = proy == 0 ? string.Empty : " where tab.ID_PROYECTO=" + proy;
        //    var tipoPer = tipoPers == 0 ? string.Empty : "a.ID_GERENCIAS_GENERAL=" + tipoPers + " and ";
        //    var f = ingre ? "p.fecha_entrada" : "p.fecha_salida";
        //    var o = orden == 0 ? "tab.APELLIDOS, tab.NOMBRES" : orden == 1 ? "tab.fecha_entrada" : "tab.salida";
        //    string sql;

        //    if (estado.Equals("2"))
               
        //    {
        //        o = orden == 0 ? "tab.APELLIDOS, tab.NOMBRES" : orden == 1 ? "tab.FECHA_INICIAL_CONTRATO" : "tab.FECHA_VENCIMIENTO_CONTRATO";
        //        sql =
        //        "select tab.id_personal ID, tab.cedula CEDULA, tab.apellidos + ' '+ tab.nombres 'APELLIDOS Y NOMRES', tab.sexo SEXO, tab.movil MOVIL, " +
        //        "tab.fecha_nacimiento 'FEC. NACIM.', tab.direccion 'DIRECCIÓN DOMICILIARIA', tab.FECHA_INICIAL_CONTRATO 'F. INGRESO', tab.estado ESTADO, tab.salida SALIDA, " +
        //        "tab.SITIO_ACTUAL 'PUESTO DE TRABAJO SEGÚN CONTRATO', tab.descripcion CARGO, tab.nombre_area AREA, tab.ultima_asignacion 'ÚLTIMO PUESTO SEGÚN PROGRAMACIÓN', " +
        //        "tab.OBSERVACION, tab.foto, tab.DOCUMENTOS, tab.apellidos, tab.nombres, (select c.codigo_ocupacional from CODIGO_CARGO_OCUPACIONAL c where c.ID_CARGO_OCUPACIONAL=tab.ID_CARGO_OCUPACIONAL) codcargo,  " +
        //        "TAB.SUELDO, coalesce((select top 1 neto_rol from DETALLES_ROL dr join ROL_PAGO rp on dr.id_rol = rp.id_rol " +
        //        "where dr.id_personal = tab.id_personal and rp.quincena = 1 and rp.ESTADO > 0 order by rp.anio_rol desc, rp.mes_rol desc),0) totalganado, tab.EDA EDAD, " +
        //        "tab.ESTATURA, tab.CIVIL, TAB.EMAIL, tab.PROYECTO, tab.ID_PROYECTO from (SELECT p.ID_PERSONAL, p.cedula, p.apellidos, p.nombres, " +
        //        "case p.sexo when 'MASCULINO' then 'M' else 'F' end SEXO, p.movil MOVIL, p.fecha_nacimiento, x.FECHA_INICIAL_CONTRATO, x.ESTADO_CONTRATO ESTADO, " +
        //        "case x.ESTADO_CONTRATO when 'VIGENTE' then null else x.FECHA_VENCIMIENTO_CONTRATO end SALIDA, s.nombre_sitio_trabajo + ' ('+l.nompre_razon_social_cliente_general+')' SITIO_ACTUAL, c.descripcion, a.nombre_area, " +
        //        "p.direccion, (select top 1 si.nombre_sitio_trabajo+ '(' + cl.nompre_razon_social_cliente_general  + ')' + '      DEL ' + convert(varchar(10), dp.fecha_desde, 103) + '      AL ' + convert(varchar(10), dp.fecha_hasta, 103) " +
        //        "from detalle_programacion dp  join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo join cliente_general cl on si.id_cliente_general=cl.id_cliente_general " +
        //        "where dp.id_personal = p.ID_PERSONAL order by dp.id_programacion desc, dp.fecha_desde desc) ultima_asignacion, p.OBSERVACION, p.foto, p.examen_psicologico DOCUMENTOS, " +
        //        "p.id_cargo_ocupacional, p.EDAD, p.ESTATURA, DATEDIFF(YEAR,p.FECHA_NACIMIENTO,GETDATE())-(CASE WHEN DATEADD(YY,DATEDIFF(YEAR,p.FECHA_NACIMIENTO,GETDATE()),p.FECHA_NACIMIENTO)>GETDATE() THEN 1 ELSE 0 END) EDA, " +
        //        "p.ESTADO_CIVIL civil, P.EMAIL, P.SUELDO, Y.NOMBRE_PROYECTO + '  - DEL ' + convert(varchar(10), Y.FECHA_INICIO, 103) +  ' AL ' + convert(varchar(10), Y.FECHA_FIN, 103) PROYECTO, y.ID_PROYECTO " +
        //        "FROM contrato x join CONTRATO_PROYECTO y on x.ID_PROYECTO = y.ID_PROYECTO join PERSONAL p on x.id_personal = p.id_personal join area_general a on p.id_area = a.id_area_general join cargo_ocupacional c on p.id_cargo_ocupacional = c.id_cargo_ocupacional " +
        //        "join sitios_trabajo s on p.ubicacion = s.id_sitio_trabajo  join cliente_general l on s.id_cliente_general=l.id_cliente_general WHERE " + tipoPer + " (p.APELLIDOS like @FILTRO OR p.NOMBRES like @FILTRO OR p.CEDULA like @FILTRO) and (x.FECHA_INICIAL_CONTRATO between @desde and @hasta)) " +
        //        "as tab " + proye + " ORDER BY " + o;
        //    }
        //    else
        //    {
        //        estado = "p.ESTADO_PERSONAL= " + estado + " and ";
        //        //estado = "p.ESTADO_PERSONAL=" + estado + " and ";

        //        sql =
        //        "select tab.id_personal ID, tab.cedula CEDULA, tab.apellidos + ' '+ tab.nombres 'APELLIDOS Y NOMRES', tab.sexo SEXO," +
        //        " tab.movil MOVIL, tab.fecha_nacimiento 'FEC. NACIM.', tab.direccion 'DIRECCIÓN DOMICILIARIA', tab.fecha_entrada 'F. INGRESO'," +
        //        " tab. estado ESTADO, tab.salida SALIDA, tab.sitio 'PUESTO DE TRABAJO SEGÚN CONTRATO', tab.descripcion CARGO, tab.nombre_area AREA," +
        //        " tab.ultima_asignacion 'ÚLTIMO PUESTO SEGÚN PROGRAMACIÓN', tab.OBSERVACION, tab.foto, tab.DOCUMENTOS, tab.apellidos, tab.nombres, (select c.codigo_ocupacional from CODIGO_CARGO_OCUPACIONAL c where c.ID_CARGO_OCUPACIONAL=tab.ID_CARGO_OCUPACIONAL) codcargo,  TAB.SUELDO, coalesce((select top 1 neto_rol from DETALLES_ROL dr join ROL_PAGO rp on dr.id_rol = rp.id_rol where dr.id_personal = tab.id_personal and rp.quincena = 1 and rp.ESTADO > 0 order by rp.anio_rol desc, rp.mes_rol desc),0) totalganado, tab.EDA EDAD, tab.ESTATURA, tab.CIVIL, TAB.EMAIL, tab.PROYECTO, tab.ID_PROYECTO from (SELECT p.ID_PERSONAL, p.cedula, p.apellidos, p.nombres, " +
        //        "case p.sexo when 'MASCULINO' then 'M' else 'F' end SEXO, p.movil MOVIL, p.fecha_nacimiento, p.fecha_entrada, case p.estado_personal " +
        //        "when 1 then 'ACTIVO' else 'INACTIVO' end ESTADO, case p.estado_personal when 1 then null else p.fecha_salida end SALIDA, " +
        //        "s.nombre_sitio_trabajo + ' ('+l.nompre_razon_social_cliente_general+')' SITIO, c.descripcion, a.nombre_area, p.direccion, " +
        //        "(select top 1 si.nombre_sitio_trabajo+ '(' + cl.nompre_razon_social_cliente_general  + ')' + '      DEL ' + convert(varchar(10), " +
        //        "dp.fecha_desde, 103) + '      AL ' + convert(varchar(10), dp.fecha_hasta, 103) from detalle_programacion dp  join sitios_trabajo " +
        //        "si on dp.id_puesto=si.id_sitio_trabajo join cliente_general cl on si.id_cliente_general=cl.id_cliente_general" +
        //        " where dp.id_personal = p.ID_PERSONAL order by dp.id_programacion desc, dp.fecha_desde desc) ultima_asignacion, p.OBSERVACION, p.foto, p.examen_psicologico DOCUMENTOS, p.id_cargo_ocupacional, p.EDAD, p.ESTATURA, DATEDIFF(YEAR,p.FECHA_NACIMIENTO,GETDATE())-(CASE WHEN DATEADD(YY,DATEDIFF(YEAR,p.FECHA_NACIMIENTO,GETDATE()),p.FECHA_NACIMIENTO)>GETDATE() THEN 1 ELSE 0 END) EDA, p.ESTADO_CIVIL civil, P.EMAIL, P.SUELDO, (SELECT (Y.NOMBRE_PROYECTO + '  - DEL ' + convert(varchar(10), Y.FECHA_INICIO, 103) +  ' AL ' + convert(varchar(10), Y.FECHA_FIN, 103)) PROPYECTO FROM CONTRATO_PROYECTO Y JOIN CONTRATO X ON Y.ID_PROYECTO=X.ID_PROYECTO WHERE X.ID_PERSONAL = p.id_personal AND X.ESTADO_CONTRATO = 'VIGENTE') PROYECTO, (SELECT Y.ID_PROYECTO FROM CONTRATO_PROYECTO Y JOIN CONTRATO X ON Y.ID_PROYECTO=X.ID_PROYECTO WHERE X.ID_PERSONAL = p.id_personal AND X.ESTADO_CONTRATO = 'VIGENTE') ID_PROYECTO FROM dbo.PERSONAL p " +
        //        "join area_general a on p.id_area = a.id_area_general join cargo_ocupacional c on p.id_cargo_ocupacional = c.id_cargo_ocupacional " +
        //        "join sitios_trabajo s on p.ubicacion = s.id_sitio_trabajo join cliente_general l on s.id_cliente_general=l.id_cliente_general " +
        //        "WHERE " + estado + tipoPer + " (p.APELLIDOS like @FILTRO OR p.NOMBRES like @FILTRO OR p.CEDULA like @FILTRO) and (" + f +
        //        " between @desde and @hasta)) as tab " + proye + " ORDER BY " + o;
        //    }
              
        //    var pars = new List<object[]>
        //    {
        //        new object[] { "FILTRO", SqlDbType.VarChar, string.Concat("%", filtro, "%") },
        //        new object[] { "desde", SqlDbType.DateTime, desde } ,
        //        new object[] { "hasta", SqlDbType.DateTime, hasta },
        //       // new object[] { "proy", SqlDbType.Int, proy },
        //        //new object[] { "tipoPers", SqlDbType.Int, tipoPers },
        //        //new object[] { "estado", SqlDbType.VarChar, estado }
    
        //    };
        //    return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        //}

        
        public DataTable SeleccionarTodosRegistrosPersonalPorFiltros(TipoConexion tipoCon, int proy, int tipoPers, string estado, string filtro, bool ingre, int orden,  string desde, string hasta )
        {


                       

            var pars = new List<object[]>
            {
                new object[] { "proy", SqlDbType.Int,  proy },
                new object[] { "TipoPers", SqlDbType.Int,  tipoPers },
                new object[] { "estado", SqlDbType.VarChar,  estado },
                new object[] { "FILTRO", SqlDbType.VarChar,  filtro },
                new object[] { "ingre", SqlDbType.Bit,  ingre },
                new object[] { "orden", SqlDbType.Int,  orden },
                new object[] { "desde", SqlDbType.DateTime, desde } ,
                new object[] { "hasta", SqlDbType.DateTime, hasta },
            
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarTodosRegistrosPersonalPorFiltros", true, pars);
        }

        public DataTable SeleccionarDatosPagosNominaGenral(TipoConexion tipoCon, bool admin, string desde, string hasta, string filtro)
        {
            var pars = new List<object[]>
            {
                new object[] { "desde", SqlDbType.DateTime, desde } ,
                new object[] { "hasta", SqlDbType.DateTime, hasta } ,
                new object[] { "filtro", SqlDbType.VarChar, string.Concat("%", filtro, "%") }
            };
            var sql = string.Empty;
            if (admin)
            {
                sql = "select dr.grupo, (rtrim(ltrim(str(rp.anio_rol))) + '-' + rtrim(ltrim(str(rp.mes_rol)))) mes, dr.nomina, dr.cedula, dr.sueldodtdm ingresos,  dr.tot_ext extra, (dr.xiii+dr.xiii_pension) xiii, (dr.xiv+dr.xiv_pension) xiv, (dr.fon_res + dr.fon_res_ant) fondore, dr.val_acum_fon_res fondoac, dr.desc_iess iess, dr.quin_ante quincena,  dr.desc_capa capaseg, dr.desc_comc comecsa, dr.desc_multas multas, dr.desc_quir quirografario, dr.desc_hip hipotecario, dr.desc_exsc extension, (dr.ant_eme+dr.ant_vari+dr.desc_prem+dr.desc_comi+dr.desc_equip+dr.desc_pension+dr.desc_vivi+dr.ot_desc+dr.desc_almuerzo) descuentos, dr.neto_rol neto  from DETALLES_ROL dr join ROL_PAGO rp on dr.id_rol=rp.id_rol where rp.estado <> 0 and dr.nomina <> '' and rp.quincena = 1 and rp.grupo = 'ADMINISTRATIVO' and (rp.desde >= @desde and rp.hasta <= @hasta) and dr.nomina like @filtro order by dr.nomina, rp.anio_rol, rp.mes_rol;";
            }
            else
            {
                sql = "select dr.grupo, (rtrim(ltrim(str(rp.anio_rol))) + '-' + rtrim(ltrim(str(rp.mes_rol)))) mes, dr.nomina, dr.cedula, dr.sueldodtdm ingresos,  dr.tot_ext extra, (dr.xiii+dr.xiii_pension) xiii, (dr.xiv+dr.xiv_pension) xiv, (dr.fon_res + dr.fon_res_ant) fondore, dr.val_acum_fon_res fondoac, dr.desc_iess iess, dr.quin_ante quincena,  dr.desc_capa capaseg, dr.desc_comc comecsa, dr.desc_multas multas, dr.desc_quir quirografario, dr.desc_hip hipotecario, dr.desc_exsc extension, (dr.ant_eme+dr.ant_vari+dr.desc_prem+dr.desc_comi+dr.desc_equip+dr.desc_pension+dr.desc_vivi+dr.ot_desc+dr.desc_almuerzo) descuentos, dr.neto_rol neto  from DETALLES_ROL dr join ROL_PAGO rp on dr.id_rol=rp.id_rol where rp.estado <> 0 and dr.nomina <> '' and rp.quincena = 1 and (rp.grupo <> '' AND  rp.grupo <> 'ADMINISTRATIVO') and (rp.desde >= @desde and rp.hasta <= @hasta) and dr.nomina like @filtro order by dr.nomina, rp.anio_rol, rp.mes_rol;";
            }

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        }

        public DataTable SeleccionarTodosRegistrosPersonalFiltroTodos(TipoConexion tipoCon, string fil)
        {
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, fil } 
            };
            return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarTodosRegistrosPersonalFiltroTodos", true, pars) ; 
        }
         
        public DataTable SeleccionarTodosRegistrosPersonalFiltroFull(TipoConexion tipoCon, string fil)
        {
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, fil } 
            };
            return   ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from PERSONAL where cedula = @FILTRO;", false, pars)  ;
        }

        public DataSet BuscarPersonalPorIdsInPersonal(TipoConexion tipoCon, List<string> ids)
        
        {
            var lids = ids.Aggregate("(", (current, id) => current + (id + ","));
            lids = lids.EndsWith(",") ? lids.Substring(0, lids.Length - 1)+")" : lids+")";

            

            var per =  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM dbo.PERSONAL WHERE ESTADO_PERSONAL=1 AND ID_PERSONAL in " + lids, false);
            per.TableName = "PERSONAL";

            var are =  ComandosSql.SeleccionarQueryToDataTable( tipoCon,"SELECT * FROM dbo.AREA_GENERAL WHERE  ESTADO_AREA=1", false) ;
            are.TableName = "AREA_GENERAL";

            var car =  ComandosSql.SeleccionarQueryToDataTable( tipoCon,"SELECT * FROM dbo.CARGO_OCUPACIONAL WHERE  ESTADO=1", false) ;
            car.TableName = "CARGO_OCUPACIONAL";

            var ds = new DataSet();
            ds.Tables.Add(per);
            ds.Tables.Add(are);
            ds.Tables.Add(car);
            return ds;
        }

        public DataSet BuscarPersonalPorIdsInPersonalProyecto(TipoConexion tipoCon, List<string> ids)
        
        {

            var lids = ids.Aggregate("(", (current, id) => current + (id + ","));
            lids = lids.EndsWith(",") ? lids.Substring(0, lids.Length - 1) + ")" : lids + ")";



            var per = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM dbo.PERSONAL WHERE ESTADO_PERSONAL=1 AND ID_PERSONAL in " + lids, false);
            per.TableName = "PERSONAL";

            var car = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM dbo.CARGO_OCUPACIONAL WHERE  ESTADO=1", false);
            car.TableName = "CARGO_OCUPACIONAL";

            //var con = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM dbo.CONTRATO WHERE CONTRATO.ESTADO_CONTRATO = 'VIGENTE'", false);
            var con = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM CONTRATO WHERE  CONTRATO.ESTADO_CONTRATO = 'VIGENTE'", false);
            con.TableName = "CONTRATO";

            var conpro = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM CONTRATO_PROYECTO WHERE  CONTRATO_PROYECTO.ESTADO = 1", false);
            conpro.TableName = "CONTRATO_PROYECTO";

            var ds = new DataSet();
            ds.Tables.Add(per);
            ds.Tables.Add(car);
            ds.Tables.Add(con);
            ds.Tables.Add(conpro);
            return ds;
        }


        public DataSet BuscarPersonalPorIdPersonal(TipoConexion tipoCon, string idp)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_PERSONAL", SqlDbType.Int, idp } 
            };
            var per =  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarPersonalPorIdPersonal", true, pars) ;
            per.TableName = "PERSONAL";

            //var are =  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM dbo.AREA_GENERAL WHERE  ESTADO_AREA=1", false, pars)  ;
            //are.TableName = "AREA_GENERAL";

            var car =  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM dbo.CARGO_OCUPACIONAL WHERE  ESTADO=1", false, pars)  ;
            car.TableName = "CARGO_OCUPACIONAL";

            //var con = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT CASE WHEN CONTRATO.FECHA_VENCIMIENTO_CONTRATO = '1990-01-01 00:00:00.000' THEN 'SIN FECHA DE VENCIMIENTO' ELSE CONVERT(VARCHAR, CONTRATO.FECHA_VENCIMIENTO_CONTRATO, 120) END AS FECHA_VENCIMIENTO FROM CONTRATO WHERE  CONTRATO.ESTADO_CONTRATO = 'VIGENTE'", false, pars);
            var con = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT *  FROM CONTRATO WHERE CONTRATO.ESTADO_CONTRATO = 'VIGENTE'", false, pars);
            con.TableName = "CONTRATO";

            var conpro = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM CONTRATO_PROYECTO WHERE  CONTRATO_PROYECTO.ESTADO = 1 ", false, pars);
            conpro.TableName = "CONTRATO_PROYECTO";

            var ds = new DataSet();
            ds.Tables.Add(per);
            ds.Tables.Add(car);
            ds.Tables.Add(con);
            ds.Tables.Add(conpro);
            //ds.Tables.Add(con);
            return ds;
        }

        public DataTable SeleccionarTodosRegistrosPersonalFiltroMini(TipoConexion tipoCon, string fil)
        {
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, string.Concat("%", fil, "%") } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select p.id_personal ID, p.CEDULA, p.APELLIDOS + ' ' + p.NOMBRES NOMBRES, p.FOTO, p.FECHA_ENTRADA, c.DESCRIPCION, g.ID_GERENCIAS_GENERAL, (select top 1 si.nombre_sitio_trabajo+ ' (' + cl.nompre_razon_social_cliente_general  + ')' from detalle_programacion dp  join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo join cliente_general cl on si.id_cliente_general=cl.id_cliente_general where dp.id_personal = p.id_personal order by dp.id_programacion desc, dp.fecha_desde desc) puesto from personal p join CARGO_OCUPACIONAL c on p.ID_CARGO_OCUPACIONAL = c.ID_CARGO_OCUPACIONAL join AREA_GENERAL a on p.ID_AREA = a.ID_AREA_GENERAL join GERENCIAS_GENERAL g on a.ID_GERENCIAS_GENERAL = g.ID_GERENCIAS_GENERAL where p.estado_personal = 1 and (p.cedula like @FILTRO or p.nombres like @FILTRO or p.apellidos like @FILTRO);", false, pars);
        }

        public SqlCommand NuevoContadorSecuencial(int idSec, int digit, int anio)
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into SECUENCIALES_CONTRATOS (id_secuencia, digit, anio) values (@id_secuencia, @digit, @anio);"
            };
            cmd.Parameters.AddWithValue("@id_secuencia", SqlDbType.BigInt).Value = idSec;
            cmd.Parameters.AddWithValue("@digit", SqlDbType.BigInt).Value = digit;
            cmd.Parameters.AddWithValue("@anio", SqlDbType.BigInt).Value = anio; 
            return cmd;
        }

        public SqlCommand RegistrarNuevoPersonalCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "NuevoPersonalCompleto"
            };
            cmd.Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal;
            cmd.Parameters.AddWithValue("@CEDULA", SqlDbType.NVarChar).Value = CedulaPersonal;
            cmd.Parameters.AddWithValue("@NOMBRES", SqlDbType.NVarChar).Value = NombresPersonal;
            cmd.Parameters.AddWithValue("@APELLIDOS", SqlDbType.NVarChar).Value = ApellidosPersonal;
            cmd.Parameters.AddWithValue("@PROVINCIA", SqlDbType.NVarChar).Value = ProvinciaPersonal;
            cmd.Parameters.AddWithValue("@DIRECCION", SqlDbType.NVarChar).Value = DireccionPersonal;
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", SqlDbType.DateTime).Value = FechaNacimientoPersonal;
            cmd.Parameters.AddWithValue("@SEXO", SqlDbType.NVarChar).Value = SexoPersonal;
            cmd.Parameters.AddWithValue("@CIUDAD", SqlDbType.NVarChar).Value = CiudadPersonal;
            cmd.Parameters.AddWithValue("@SUELDO", SqlDbType.Decimal).Value = SueldoPersonal;
            cmd.Parameters.AddWithValue("@LIBRETA_MILITAR", SqlDbType.NVarChar).Value = LibretaMilitarPersonal;
            cmd.Parameters.AddWithValue("@TIPO_SANGRE", SqlDbType.NVarChar).Value = TipoSangrePersonal;
            cmd.Parameters.AddWithValue("@PASAPORTE", SqlDbType.NVarChar).Value = PasaportePersonal;
            cmd.Parameters.AddWithValue("@PESO", SqlDbType.Decimal).Value = PesoPersonal;
            cmd.Parameters.AddWithValue("@EDAD", SqlDbType.Int).Value = EdadPersonal;
            cmd.Parameters.AddWithValue("@PRUEBA_ANTIDROGA", SqlDbType.NVarChar).Value = PruebaAntidrogaPersona;
            cmd.Parameters.AddWithValue("@FECHA_ENTRADA", SqlDbType.DateTime).Value = FechaEntradaPersonal;
            cmd.Parameters.AddWithValue("@FECHA_SALIDA", SqlDbType.DateTime).Value = FechaSalidaPersonal;
            cmd.Parameters.AddWithValue("@ESTADO_PERSONAL", SqlDbType.Int).Value = EstadoPersonal;
            cmd.Parameters.AddWithValue("@ID_AREA", SqlDbType.Int).Value = IdAreaPersonal;
            cmd.Parameters.AddWithValue("@ID_CARGO_OCUPACIONAL", SqlDbType.Int).Value = IdCargoPersonal;
            cmd.Parameters.AddWithValue("@UBICACION", SqlDbType.NVarChar).Value = UbicacionPersonal;
            cmd.Parameters.AddWithValue("@INSTRUCCION", SqlDbType.NVarChar).Value = InstruccionPersonal;
            cmd.Parameters.AddWithValue("@ESTADO_CIVIL", SqlDbType.NVarChar).Value = EstadoCivilPersonal;
            cmd.Parameters.AddWithValue("@MOVIL", SqlDbType.NVarChar).Value = MovilPersonal;
            cmd.Parameters.AddWithValue("@TELEFONO", SqlDbType.NVarChar).Value = TelefonoPersonal;
            cmd.Parameters.AddWithValue("@CANTIDAD_HIJOS", SqlDbType.Int).Value = CantidadHijosPersonal;
            cmd.Parameters.AddWithValue("@HISTORIA_CLINICA", SqlDbType.NVarChar).Value = HistoriaClinicaPersonal;
            cmd.Parameters.AddWithValue("@PARROQUIA", SqlDbType.NVarChar).Value = ParroquiaPersonal;
            cmd.Parameters.AddWithValue("@ESTATURA", SqlDbType.Decimal).Value = EstaturaPersonal;
            cmd.Parameters.AddWithValue("@DISCAPACIDAD", SqlDbType.NVarChar).Value = DiscapacidadPersonal;
            cmd.Parameters.AddWithValue("@EXAMEN_PSICOLOGICO", SqlDbType.NVarChar).Value = ExamenPsicologicoPersonal;
            cmd.Parameters.AddWithValue("@LUGAR_EXAMEN_PSICOLOGICO", SqlDbType.NVarChar).Value = LugarExamenPsicologicoPersonal;
            cmd.Parameters.AddWithValue("@CURSO_VIGILANTE", SqlDbType.NVarChar).Value = CursoVigilante;
            cmd.Parameters.AddWithValue("@EMISOR_CURSO_VIGILANTE", SqlDbType.NVarChar).Value = EmisorCursoVigilante;
            cmd.Parameters.AddWithValue("@CARNET_CONADIS", SqlDbType.NVarChar).Value = CarnetConadisPersonal;
            cmd.Parameters.AddWithValue("@DATOS_HIJOS", SqlDbType.NVarChar).Value = DatosHijosPersonal;
            cmd.Parameters.AddWithValue("@DATOS_ESPOSA", SqlDbType.Text).Value = DatosEsposaPersonal;
            cmd.Parameters.AddWithValue("@CASA", SqlDbType.NVarChar).Value = CasaPersonal;
            cmd.Parameters.AddWithValue("@ARRIENDO", SqlDbType.NVarChar).Value = ArriendoPersonal;
            cmd.Parameters.AddWithValue("@DEUDOR_GARANTE", SqlDbType.NVarChar).Value = DeudorPersonal;
            cmd.Parameters.AddWithValue("@CANTIDAD_DEUDA", SqlDbType.Decimal).Value = CantidadDeudaPersonal;
            cmd.Parameters.AddWithValue("@A_QUIEN_ADEUDA", SqlDbType.NVarChar).Value = AQuienAdeudaPersonal;
            cmd.Parameters.AddWithValue("@TRABAJO_ATERIORMENTE", SqlDbType.NVarChar).Value = TrabajoAnteriormentePersonal;
            cmd.Parameters.AddWithValue("@ANTERIOR_TRABAJO", SqlDbType.NVarChar).Value = AnteriorTrabajoPersonal;
            cmd.Parameters.AddWithValue("@CARGO_ANTERIOR_TRABAJO", SqlDbType.NVarChar).Value = CargoAnteriorTrabajoPersonal;
            cmd.Parameters.AddWithValue("@MOTIVO_SALIDA_TRABAJO", SqlDbType.NVarChar).Value = MotivoSalidaTrabajoPersonal;
            cmd.Parameters.AddWithValue("@ENTRADA_ANTERIOR", SqlDbType.DateTime).Value = EntradaAnteriorPersonal;
            cmd.Parameters.AddWithValue("@SALIDA_ANTERIOR ", SqlDbType.DateTime).Value = SalidaAnteriorPersonal;
            cmd.Parameters.AddWithValue("@NOMBRES_PATRONO_ANTERIOR", SqlDbType.NVarChar).Value = NombresPatronoAnteriorPersonal;
            cmd.Parameters.AddWithValue("@TELEFONO_PATRONO_ANTERIOR", SqlDbType.NVarChar).Value = TelefonoPatronoAnteriorPersonal;
            cmd.Parameters.AddWithValue("@RECOMENDACIONES", SqlDbType.Text).Value = RecomendacionesPersonal;
            cmd.Parameters.AddWithValue("@DATOS_FAMILIARES", SqlDbType.Text).Value = DatosFamiliaresPersonal;
            cmd.Parameters.AddWithValue("@DATOS_EMERGENCIA", SqlDbType.Text).Value = DatosEmergenciaPersonal;
            cmd.Parameters.AddWithValue("@FOTO", SqlDbType.Image).Value = FotoPersonal;
            cmd.Parameters.AddWithValue("@PERFIL", SqlDbType.Image).Value = PerfilPersonal;
            cmd.Parameters.AddWithValue("@EMAIL", SqlDbType.NVarChar).Value = EmailPersonal;
            cmd.Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = Observacion;
            cmd.Parameters.AddWithValue("@CREDENCIAL", SqlDbType.Int).Value = Credencial;
            return cmd;
        }

        public SqlCommand ModificarPersonalCompletoCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "modificarPersonalCompleto"
            };
            cmd.Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal;
            cmd.Parameters.AddWithValue("@CEDULA", SqlDbType.NVarChar).Value = CedulaPersonal;
            cmd.Parameters.AddWithValue("@NOMBRES", SqlDbType.NVarChar).Value = NombresPersonal;
            cmd.Parameters.AddWithValue("@APELLIDOS", SqlDbType.NVarChar).Value = ApellidosPersonal;
            cmd.Parameters.AddWithValue("@PROVINCIA", SqlDbType.NVarChar).Value = ProvinciaPersonal;
            cmd.Parameters.AddWithValue("@DIRECCION", SqlDbType.NVarChar).Value = DireccionPersonal;
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", SqlDbType.DateTime).Value = FechaNacimientoPersonal;
            cmd.Parameters.AddWithValue("@SEXO", SqlDbType.NVarChar).Value = SexoPersonal;
            cmd.Parameters.AddWithValue("@CIUDAD", SqlDbType.NVarChar).Value = CiudadPersonal;
            cmd.Parameters.AddWithValue("@SUELDO", SqlDbType.Decimal).Value = SueldoPersonal;
            cmd.Parameters.AddWithValue("@LIBRETA_MILITAR", SqlDbType.NVarChar).Value = LibretaMilitarPersonal;
            cmd.Parameters.AddWithValue("@TIPO_SANGRE", SqlDbType.NVarChar).Value = TipoSangrePersonal;
            cmd.Parameters.AddWithValue("@PASAPORTE", SqlDbType.NVarChar).Value = PasaportePersonal;
            cmd.Parameters.AddWithValue("@PESO", SqlDbType.Decimal).Value = PesoPersonal;
            cmd.Parameters.AddWithValue("@EDAD", SqlDbType.Int).Value = EdadPersonal;
            cmd.Parameters.AddWithValue("@PRUEBA_ANTIDROGA", SqlDbType.NVarChar).Value = PruebaAntidrogaPersona;
            cmd.Parameters.AddWithValue("@FECHA_ENTRADA", SqlDbType.DateTime).Value = FechaEntradaPersonal;
            cmd.Parameters.AddWithValue("@FECHA_SALIDA", SqlDbType.DateTime).Value = FechaSalidaPersonal;
            cmd.Parameters.AddWithValue("@ESTADO_PERSONAL", SqlDbType.Int).Value = EstadoPersonal;
            cmd.Parameters.AddWithValue("@ID_AREA", SqlDbType.Int).Value = IdAreaPersonal;
            cmd.Parameters.AddWithValue("@ID_CARGO_OCUPACIONAL", SqlDbType.Int).Value = IdCargoPersonal;
            cmd.Parameters.AddWithValue("@UBICACION", SqlDbType.NVarChar).Value = UbicacionPersonal;
            cmd.Parameters.AddWithValue("@INSTRUCCION", SqlDbType.NVarChar).Value = InstruccionPersonal;
            cmd.Parameters.AddWithValue("@ESTADO_CIVIL", SqlDbType.NVarChar).Value = EstadoCivilPersonal;
            cmd.Parameters.AddWithValue("@MOVIL", SqlDbType.NVarChar).Value = MovilPersonal;
            cmd.Parameters.AddWithValue("@TELEFONO", SqlDbType.NVarChar).Value = TelefonoPersonal;
            cmd.Parameters.AddWithValue("@CANTIDAD_HIJOS", SqlDbType.Int).Value = CantidadHijosPersonal;
            cmd.Parameters.AddWithValue("@HISTORIA_CLINICA", SqlDbType.NVarChar).Value = HistoriaClinicaPersonal;
            cmd.Parameters.AddWithValue("@PARROQUIA", SqlDbType.NVarChar).Value = ParroquiaPersonal;
            cmd.Parameters.AddWithValue("@ESTATURA", SqlDbType.Decimal).Value = EstaturaPersonal;
            cmd.Parameters.AddWithValue("@DISCAPACIDAD", SqlDbType.NVarChar).Value = DiscapacidadPersonal;
            cmd.Parameters.AddWithValue("@EXAMEN_PSICOLOGICO", SqlDbType.NVarChar).Value = ExamenPsicologicoPersonal;
            cmd.Parameters.AddWithValue("@LUGAR_EXAMEN_PSICOLOGICO", SqlDbType.NVarChar).Value = LugarExamenPsicologicoPersonal;
            cmd.Parameters.AddWithValue("@CURSO_VIGILANTE", SqlDbType.NVarChar).Value = CursoVigilante;
            cmd.Parameters.AddWithValue("@EMISOR_CURSO_VIGILANTE", SqlDbType.NVarChar).Value = EmisorCursoVigilante;
            cmd.Parameters.AddWithValue("@CARNET_CONADIS", SqlDbType.NVarChar).Value = CarnetConadisPersonal;
            cmd.Parameters.AddWithValue("@DATOS_HIJOS", SqlDbType.NVarChar).Value = DatosHijosPersonal;
            cmd.Parameters.AddWithValue("@DATOS_ESPOSA", SqlDbType.Text).Value = DatosEsposaPersonal;
            cmd.Parameters.AddWithValue("@CASA", SqlDbType.NVarChar).Value = CasaPersonal;
            cmd.Parameters.AddWithValue("@ARRIENDO", SqlDbType.NVarChar).Value = ArriendoPersonal;
            cmd.Parameters.AddWithValue("@DEUDOR_GARANTE", SqlDbType.NVarChar).Value = DeudorPersonal;
            cmd.Parameters.AddWithValue("@CANTIDAD_DEUDA", SqlDbType.Decimal).Value = CantidadDeudaPersonal;
            cmd.Parameters.AddWithValue("@A_QUIEN_ADEUDA", SqlDbType.NVarChar).Value = AQuienAdeudaPersonal;
            cmd.Parameters.AddWithValue("@TRABAJO_ATERIORMENTE", SqlDbType.NVarChar).Value = TrabajoAnteriormentePersonal;
            cmd.Parameters.AddWithValue("@ANTERIOR_TRABAJO", SqlDbType.NVarChar).Value = AnteriorTrabajoPersonal;
            cmd.Parameters.AddWithValue("@CARGO_ANTERIOR_TRABAJO", SqlDbType.NVarChar).Value = CargoAnteriorTrabajoPersonal;
            cmd.Parameters.AddWithValue("@MOTIVO_SALIDA_TRABAJO", SqlDbType.NVarChar).Value = MotivoSalidaTrabajoPersonal;
            cmd.Parameters.AddWithValue("@ENTRADA_ANTERIOR", SqlDbType.DateTime).Value = EntradaAnteriorPersonal;
            cmd.Parameters.AddWithValue("@SALIDA_ANTERIOR ", SqlDbType.DateTime).Value = SalidaAnteriorPersonal;
            cmd.Parameters.AddWithValue("@NOMBRES_PATRONO_ANTERIOR", SqlDbType.NVarChar).Value = NombresPatronoAnteriorPersonal;
            cmd.Parameters.AddWithValue("@TELEFONO_PATRONO_ANTERIOR", SqlDbType.NVarChar).Value = TelefonoPatronoAnteriorPersonal;
            cmd.Parameters.AddWithValue("@RECOMENDACIONES", SqlDbType.Text).Value = RecomendacionesPersonal;
            cmd.Parameters.AddWithValue("@DATOS_FAMILIARES", SqlDbType.Text).Value = DatosFamiliaresPersonal;
            cmd.Parameters.AddWithValue("@DATOS_EMERGENCIA", SqlDbType.Text).Value = DatosEmergenciaPersonal;
            cmd.Parameters.AddWithValue("@FOTO", SqlDbType.Image).Value = FotoPersonal;
            cmd.Parameters.AddWithValue("@PERFIL", SqlDbType.Image).Value = PerfilPersonal;
            cmd.Parameters.AddWithValue("@EMAIL", SqlDbType.NVarChar).Value = EmailPersonal;
            cmd.Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = Observacion;
            cmd.Parameters.AddWithValue("@CREDENCIAL", SqlDbType.Int).Value = Credencial;
            return cmd;
        }

        public SqlCommand RegistrarFinContratoCommand(DateTime fechaSalida, bool noSePresento)
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = noSePresento ? "update personal set estado_personal = 0, fecha_entrada = @fsa, fecha_salida = @fsa where ID_PERSONAL= @ID_PERSONAL;" :
                "update personal set estado_personal = 0, fecha_salida = @fsa where ID_PERSONAL= @ID_PERSONAL;"
            };
            cmd.Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal;
            cmd.Parameters.AddWithValue("@fsa", SqlDbType.DateTime).Value = fechaSalida; 
            return cmd;
        }


        public DataTable SeleccionarProyectosContratoReporte(TipoConexion tipoCon)
        {
            var emp = tipoCon == TipoConexion.Cisepro ? "CISEPRO CÍA. LTDA. (SEGURIDAD Y PROTECCION CISEPRO CIA LTDA)" :
                tipoCon == TipoConexion.Seportpac ? "SEPORTPAC CÍA. LTDA. (SEGURIDAD PORTUARIA DEL PACIFICO SEPORTPAC CIA. LTDA.)" : "ASERNAVA CÍA. LTDA. (----------)";
            var sql = "(SELECT '0' ID,  '-- TODOS LOS PROYECTOS REGISTRADOS --' PROYECTO) UNION (SELECT '1' ID,  '" + emp + "' PROYECTO) UNION (SELECT P.ID_PROYECTO ID, (P.NOMBRE_PROYECTO + ' - '+ P.CODIGO + ' DEL ' + convert(varchar, P.FECHA_INICIO, 103) + ' AL ' + convert(varchar, P.FECHA_FIN, 103) + ' (' + C.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL +')') PROYECTO FROM CONTRATO_PROYECTO P LEFT JOIN CLIENTE_GENERAL C ON P.ID_CLIENTE=C.ID_CLIENTE_GENERAL WHERE P.ID_PROYECTO> 1  );";

            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, false);
        }


        public DataTable SeleccionarTodosRegistrosPersonalCne(TipoConexion tipoCon, string filtro, int estado, int tipo)
        {
            var t = "";
            if (estado != 2) t += " p.estado_personal = " + estado + " and ";
            if (tipo != 0) t += " a.id_gerencias_general = " + tipo + " and ";
             
            var sql = "select p.id_personal, p.cedula, (p.apellidos + ' ' +p.nombres) nomina, p.instruccion, p.direccion direccion1, 'S/N' numero, '' direccion2, '' referencia, p.ciudad, p.parroquia, '' ciudadela, '' sector, p.telefono, p.movil, p.email, '' correoins, a.nombre_area, '' postal, g.nombre_gerencias from personal p join area_general a on p.id_area = a.id_area_general join gerencias_general g on a.id_gerencias_general = g.id_gerencias_general where " + t + " (p.cedula like @FILTRO or p.apellidos like @FILTRO or p.nombres like @FILTRO) order by p.apellidos, p.nombres";

            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, string.Concat("%", filtro, "%") }  
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        }

        private DataTable SeleccionarApellidosNombresYIdPersonal(TipoConexion tipoCon, bool todos)
        {
            string sql = todos ?
                "SELECT APELLIDOS + ' ' + NOMBRES   AS DATOS, ID_PERSONAL AS CODIGO, CEDULA  FROM dbo.PERSONAL ORDER BY ID_PERSONAL"
                : "SeleccionarApellidosNombresYIdPersonal";

            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, false);
        }

        public AutoCompleteStringCollection AutocompletarApellidos(TipoConexion tipoCon, bool todos)
        {
            DataTable dt = SeleccionarApellidosNombresYIdPersonal(tipoCon, todos);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["DATOS"]));
            }

            return coleccion;
        }


    }
}
