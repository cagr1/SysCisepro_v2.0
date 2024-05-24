using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassDetalleVacaciones
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdDetalle { get; set; }
        public int NumDoc { get; set; }
        public int IdPersonal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int DiasVac { get; set; }
        public int DiasPen { get; set; }
        public string Periodo { get; set; }
        public DateTime FechaFirma { get; set; }
        public int IdPermiso { get; set; }
        public string Observacion { get; set; }
        public int Estado { get; set; }
        public decimal ValorCobro { get; set; }

        public int BuscarMayorIdDetalleVacaciones(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select case when max(id_detalle) is null then 0 else max(id_detalle) end id_dealle from detalle_vacaciones;", false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable SeleccionarRegistroVacacionesIdPersonal(TipoConexion tipoCon, int idp)
        {
            var pars = new List<object[]>
            {
                new object[] { "idp", SqlDbType.Int, idp }
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select id_detalle, num, fecha_salida, fecha_entrada, ndiasv, ndiasp, periodo, obs, valor_cobro from detalle_vacaciones where estado = 1 and id_personal=@idp order by id_detalle;", false, pars) ;
        }

        public DataTable SeleccionarRegistroPendientesVacacionesPorPeriodo(TipoConexion tipoCon, string fil, List<int> periodos, int tipo, int estado)
        {
            //var state = (estado == 0 || estado == 1) ? "and estado_personal = " + estado + " and p.fecha_entrada > '2017-01-01 00:00:00' and p.fecha_salida > p.fecha_entrada and" : "and";
            var state = estado == 0
                ? "and estado_personal = " + estado +
                  " and p.fecha_entrada > '2017-01-01 00:00:00' and p.fecha_salida > p.fecha_entrada and"
                : estado == 1 ? "and estado_personal = " + estado + " and " : "and";

            var sal = estado == 0 ? ", p.fecha_salida SALIDA" : string.Empty;

             var sql =  string.Empty;

            if (tipo == 0) // oper
            {
                sql = periodos.Aggregate(string.Empty, (current, peri) => current + (
                "(select p.id_personal ID, p.cedula CEDULA, p.apellidos APELLIDOS, p.nombres NOMBRES, p.fecha_entrada INGRESO, dbo.MesEnLetrasPorNumero(datepart(mm,p.fecha_entrada)) MES, " +
                "'" + (peri - 1) + " - " + peri + "' PERIODO, 15 DIAS, (select top 1 dr.grupo from detalles_rol dr join rol_pago rp on dr.id_rol = rp.id_rol where rp.estado > 0 and dr.id_personal = p.id_personal order by rp.fecha_elab desc) GRUPO" + sal +
                " from personal p join area_general a on p.ID_AREA=a.ID_AREA_GENERAL join GERENCIAS_GENERAL g on a.id_GERENCIAS_GENERAL = g.ID_GERENCIAS_GENERAL " +
                "where g.ID_GERENCIAS_GENERAL = 2 " + state + " DATEDIFF(month, fecha_entrada, getdate()) >= 12 and id_personal not in " +
                "(select id_personal from DETALLE_VACACIONES where periodo like '%" + (peri - 1) + "%" + peri + "%')) union all "));
            }
            else // admi
            {
                //DATEDIFF(year, fecha_entrada, getdate()) >= 1
                sql = periodos.Aggregate(string.Empty, (current, peri) => current + (
               "(select p.id_personal ID, p.cedula CEDULA, p.apellidos APELLIDOS, p.nombres NOMBRES, p.fecha_entrada INGRESO, dbo.MesEnLetrasPorNumero(datepart(mm,p.fecha_entrada)) MES, " +
               "'" + (peri - 1) + " - " + peri + "' PERIODO, (select top 1 dr.grupo from detalles_rol dr join rol_pago rp on dr.id_rol = rp.id_rol where rp.estado > 0 and dr.id_personal = p.id_personal order by rp.fecha_elab desc) GRUPO," +
               "DATEDIFF(year, p.fecha_entrada, getdate()) ANIOS, 15 DIAS," +
               "(select coalesce(sum(ndiasv),0) dias from detalle_vacaciones where id_personal = p.id_personal and estado = 1 and periodo like '%" + (peri - 1) + "%" + peri + "%') TOMADOS " +
               "from personal p join area_general a on p.ID_AREA=a.ID_AREA_GENERAL join GERENCIAS_GENERAL g on a.id_GERENCIAS_GENERAL = g.ID_GERENCIAS_GENERAL " +
               "where g.ID_GERENCIAS_GENERAL = 1 " + state + " DATEDIFF(month, fecha_entrada, getdate()) >= 12) union all "));

            }

            if (sql.EndsWith(" union all ")) sql = sql.Substring(0, sql.Length - 11);

            var ssql = tipo == 0
                ? "select * from (" + sql + ") as tab where (tab.apellidos like '%" + fil + "%' or tab.nombres  like '%" +
                  fil + "%') order by tab.periodo, tab.apellidos, tab.nombres"
                : "select tab.ID, tab.CEDULA, tab.APELLIDOS, tab.NOMBRES, tab.INGRESO, tab.MES, tab.PERIODO, tab.GRUPO, tab.ANIOS, tab.DIAS, tab.TOMADOS, 0 PENDIENTES " +
                  "from (" + sql + ") as tab where (tab.apellidos like '%" + fil + "%' or tab.nombres  like '%" + fil + "%') " +
                  "order by tab.periodo, tab.apellidos, tab.nombres";

            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, ssql, false);
        }

        public DataTable SeleccionarRegistroVacacionesPorPeriodo(TipoConexion tipoCon, string peri, string perf, string fil)
        {
            var pars = new List<object[]>
            { 
                new object[] { "FILTRO", SqlDbType.VarChar, fil }
            };

            var sql = "select dv.id_detalle, dv.num, pe.apellidos + ' ' + pe.nombres nomina, cr.descripcion, dv.fecha_salida, dv.fecha_entrada, dv.ndiasv, dv.ndiasp, dv.periodo, dv.obs, dv.id_permiso, dv.fecha_registro, pe.cedula, si.nombre_sitio_trabajo + ' ('+cg.nompre_razon_social_cliente_general+')' puesto, pe.fecha_entrada, dv.valor_cobro, (select s.grupo from registro_permisos_personal r join sitios_trabajo s on r.id_sitio=s.id_sitio_trabajo where r.id_registro =dv.id_permiso) GRUPO from detalle_vacaciones dv join personal pe on dv.id_personal = pe.id_personal join cargo_ocupacional cr on pe.id_cargo_ocupacional=cr.id_cargo_ocupacional  join registro_permisos_personal rg on dv.id_permiso = rg.id_registro join sitios_trabajo si on rg.id_sitio=si.id_sitio_trabajo join cliente_general cg on si.id_cliente_general=cg.id_cliente_general " +
                      "where dv.estado = 1 and (dv.periodo like '%/" + peri + " -%' and dv.periodo like '%/" + perf + "' ) and (pe.apellidos like ('%'+@FILTRO+'%') or pe.nombres like ('%'+@FILTRO+'%')) " +
                      "order by dv.id_detalle;";
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        }

        public DataTable SeleccionarRegistroVacaciones(TipoConexion tipoCon, string desde, string hasta, string fil, bool reg)
        {
            var pars = new List<object[]>
            {
                new object[] { "DESDE", SqlDbType.VarChar, desde },
                new object[] { "HASTA", SqlDbType.VarChar, hasta },
                new object[] { "FILTRO", SqlDbType.VarChar, fil }
            };
            var f = reg ? "dv.fecha_registro" : "dv.fecha_salida";

            var sql = "select dv.id_detalle, dv.num, pe.apellidos + ' ' + pe.nombres nomina, cr.descripcion, dv.fecha_salida, dv.fecha_entrada, dv.ndiasv, dv.ndiasp, dv.periodo, dv.obs, dv.id_permiso, dv.fecha_registro, pe.cedula, si.nombre_sitio_trabajo + ' ('+cg.nompre_razon_social_cliente_general+')' puesto, pe.fecha_entrada, dv.valor_cobro, (select s.grupo from registro_permisos_personal r join sitios_trabajo s on r.id_sitio=s.id_sitio_trabajo where r.id_registro =dv.id_permiso) GRUPO from detalle_vacaciones dv join personal pe on dv.id_personal = pe.id_personal join cargo_ocupacional cr on pe.id_cargo_ocupacional=cr.id_cargo_ocupacional  join registro_permisos_personal rg on dv.id_permiso = rg.id_registro join sitios_trabajo si on rg.id_sitio=si.id_sitio_trabajo join cliente_general cg on si.id_cliente_general=cg.id_cliente_general " +
                      "where dv.estado = 1 and (" + f + " between @DESDE and @HASTA) and (pe.apellidos like ('%'+@FILTRO+'%') or pe.nombres like ('%'+@FILTRO+'%')) " +
                      "order by dv.id_detalle;";
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        }

        public SqlCommand RegistrarNuevoDetalleVacacionesCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into detalle_vacaciones values(@id_detalle, @num, @id_personal, @fecha_registro, @fecha_salida, @fecha_entrada, @ndiasv, " +
                              "@ndiasp, @periodo, @fecha_firma, @id_permiso, @obs, @estado, @valor);"
            };
            cmd.Parameters.AddWithValue("@id_detalle", SqlDbType.Int).Value = IdDetalle;
            cmd.Parameters.AddWithValue("@num", SqlDbType.Int).Value = NumDoc;
            cmd.Parameters.AddWithValue("@id_personal", SqlDbType.Int).Value = IdPersonal;
            cmd.Parameters.AddWithValue("@fecha_registro", SqlDbType.DateTime).Value = FechaRegistro;
            cmd.Parameters.AddWithValue("@fecha_salida", SqlDbType.Date).Value = FechaSalida;
            cmd.Parameters.AddWithValue("@fecha_entrada", SqlDbType.DateTime).Value = FechaEntrada;
            cmd.Parameters.AddWithValue("@ndiasv", SqlDbType.Int).Value = DiasVac;
            cmd.Parameters.AddWithValue("@ndiasp", SqlDbType.Int).Value = DiasPen;
            cmd.Parameters.AddWithValue("@periodo", SqlDbType.VarChar).Value = Periodo;
            cmd.Parameters.AddWithValue("@fecha_firma", SqlDbType.DateTime).Value = FechaFirma;
            cmd.Parameters.AddWithValue("@id_permiso", SqlDbType.Int).Value = IdPermiso;
            cmd.Parameters.AddWithValue("@obs", SqlDbType.VarChar).Value = Observacion;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.VarChar).Value = 1;
            cmd.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = ValorCobro;
            return cmd;
        }

        public SqlCommand AnularRegistroDetalleVacacionesCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                //CommandText = "update detalle_vacaciones set estado=@estado where id_permiso=@id_permiso;"
                CommandText = "delete detalle_vacaciones where id_permiso=@id_permiso;"
            };
            cmd.Parameters.AddWithValue("@id_permiso", SqlDbType.Int).Value = IdPermiso;
            //cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado;
            return cmd;
        }

        public SqlCommand CambiarPeriodoDetalleVacacionesCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update detalle_vacaciones set periodo=@periodo, obs=@obs where id_detalle=@id_detalle;"
            };
            cmd.Parameters.AddWithValue("@id_detalle", SqlDbType.Int).Value = IdDetalle;
            cmd.Parameters.AddWithValue("@periodo", SqlDbType.VarChar).Value = Periodo;
            cmd.Parameters.AddWithValue("@obs", SqlDbType.VarChar).Value = Observacion;
            return cmd;
        }
    }
}
