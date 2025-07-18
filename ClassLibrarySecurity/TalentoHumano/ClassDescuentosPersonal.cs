using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassDescuentosPersonal
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public long IdRegistro { get; set; }
        public long IdPersonal { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaRegistro { get; set; }
        public long Estado { get; set; }
        public long Procesado { get; set; }
        public long Mes { get; set; }
        public long Anio { get; set; }
        public long IdRol { get; set; }
        public string Observacion { get; set; }
        public long Tipo { get; set; }
        public double Valor { get; set; }
        public string Tipot { get; set; }
        public long Idprog { get; set; }
        public string Anual { get; set; }
        public int IdDetallePrestamo { get; set; }
        public int plazo { get; set; }
        public double cuota { get; set; }
        public double monto { get; set; }
        public double capital_pagado { get; set; }
        public double capital_restante { get; set; }
        public int IdPrestamo { get; set; }
        public int periodo { get; set; }
        



        public long BuscarMayorIdRegistroDescuento(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon,
                "SELECT id_registro=CASE WHEN MAX(id_registro) IS NULL THEN 0 ELSE MAX(id_registro) End FROM DESCUENTOS_ROL;",
                false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt64(data.Rows[0][0]);
        }

        public DataTable SeleccionarDescuentosDatos1(TipoConexion tipoCon, string filtro, string desde, string hasta)
        {
            
            var pars = new List<object[]>
            {
                new object[] { "@FILTRO", SqlDbType.NVarChar, filtro }, 
                new object[] { "@DESDE", SqlDbType.DateTime, desde },
                new object[] { "@HASTA", SqlDbType.DateTime, hasta },
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_seleccionarRegsitroDescuentoResumen", true, pars);
        }

        public DataTable SeleccionarRegistroMultasAgrupados(TipoConexion tipoCon, String filtro, DateTime desde, DateTime hasta)
        { 
            var pars = new List<Object[]>
            {
                new Object[] { "FILTRO", SqlDbType.VarChar, filtro },
                new Object[] { "DESDE", SqlDbType.DateTime, desde },
                new Object[] { "HASTA", SqlDbType.DateTime, hasta }
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_SeleccionarRegistroDescuentoAgrupados", true, pars);
        }  
        


        public DataTable SeleccionarDescuentosDatos(TipoConexion tipoCon, string filtro, DateTime desde, DateTime hasta, string tipo)
        {

            //tipo = tipo.Contains("TODOS LOS DESCUENTOS") ? string.Empty : tipo;

            

            var pars = new List<object[]>
            {
                new object[] { "@FILTRO", SqlDbType.NVarChar, filtro }, 
                new object[] { "@DESDE", SqlDbType.DateTime, desde },
                new object[] { "@HASTA", SqlDbType.DateTime, hasta },
                new object[] { "@TIPO", SqlDbType.NVarChar, tipo }
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_seleccionarDescuentosDatos", true, pars);
        }

        public SqlCommand NuevoRegistroDescuentoCommands()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into DESCUENTOS_ROL (id_registro, id_personal, fecha, estado, procesado, mes_rol, anio_rol, id_rol, tipo, observacion, valor, tipox, id_prog, anual) " +
                        "values (@id_registro, @id_personal, @fecha, @estado, @procesado, @mes_rol, @anio_rol, @id_rol, @tipo, @observacion, @valor, @tipox, @idprog, @anual);"
            };
            cmd.Parameters.AddWithValue("@id_registro", SqlDbType.Int).Value = IdRegistro;
            cmd.Parameters.AddWithValue("@id_personal", SqlDbType.Int).Value = IdPersonal;
            cmd.Parameters.AddWithValue("@fecha", SqlDbType.Date).Value = Fecha;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado;
            cmd.Parameters.AddWithValue("@procesado", SqlDbType.Int).Value = Procesado;
            cmd.Parameters.AddWithValue("@mes_rol", SqlDbType.Int).Value = Mes;
            cmd.Parameters.AddWithValue("@anio_rol", SqlDbType.Int).Value = Anio;
            cmd.Parameters.AddWithValue("@id_rol", SqlDbType.Int).Value = IdRol;
            cmd.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = Tipo;
            cmd.Parameters.AddWithValue("@observacion", SqlDbType.VarChar).Value = Observacion;
            cmd.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = Valor;
            cmd.Parameters.AddWithValue("@tipox", SqlDbType.VarChar).Value = Tipot;
            cmd.Parameters.AddWithValue("@idprog", SqlDbType.Int).Value = Idprog;
            cmd.Parameters.AddWithValue("@anual", SqlDbType.VarChar).Value = Anual;
            return cmd;
        } 

        public SqlCommand AnularRegistroDescuentoCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update DESCUENTOS_ROL set estado=0 where id_registro=@id_registro;"
            };
            cmd.Parameters.AddWithValue("@id_registro", SqlDbType.Int).Value = IdRegistro; 
            return cmd;
        }

        public SqlCommand AnularRegistroDescuentoCommandByAnual()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update DESCUENTOS_ROL set estado=0 where anual=@anual;"
            };
            cmd.Parameters.AddWithValue("@anual", SqlDbType.VarChar).Value = Anual;
            return cmd;
        }

        public DataTable SeleccionarPersonalNoRolDescuentos(TipoConexion tipoCon, int mes, int anio)
        { 
            var pars = new List<object[]>
            {
                new object[] { "MES", SqlDbType.Int, mes }, 
                new object[] { "ANIO", SqlDbType.Int, anio } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select dr.id_personal, pp.APELLIDOS + ' ' + pp.nombres nomina, dr.fecha_registro, pp.fecha_salida, dr.observacion from DESCUENTOS_ROL dr join PERSONAL pp on dr.id_personal = pp.id_personal where dr.tipo = 9 and dr.estado > 0 and dr.mes_rol= @MES and dr.anio_rol = @ANIO and dr.id_personal not in (select id_personal from DETALLES_ROL dt join ROL_PAGO rp on dt.id_rol = dt.id_rol where dt.id_personal > 0 and rp.mes_rol = @MES and rp.anio_rol = @ANIO)", false, pars);
        }

        public int BuscarMayorIdPrestamo(TipoConexion tipoCon) 
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_buscar_mayor_id_prestamo", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public int BuscarMayorIdDetallePrestamo(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_buscar_mayor_id_detalle_prestamo", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }
         
        public DataTable SeleccionarDescuentosGrupos(TipoConexion tipoCon, string filtro, string desde, string hasta)
        {
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, filtro }, 
                new object[] { "DESDE", SqlDbType.DateTime, desde },
                new object[] { "HASTA", SqlDbType.DateTime, hasta } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select tab.* from (select CONVERT(varchar(10), r.id_registro) + ' - ' + convert(varchar, r.fecha, 103) + ' - ' + e.CEDULA + ' - '  + e.apellidos + ' ' + e.nombres + ' - ' + CONVERT(varchar(10), r.valor) + ' - ' + u.OBSERVACION_UNIFORMES DETALLE from DESCUENTOS_ROL r join personal e on r.id_personal= e.id_personal join cargo_ocupacional c on e.id_cargo_ocupacional = c.id_cargo_ocupacional left join sitios_trabajo s on e.ubicacion = s.id_sitio_trabajo left join cliente_general l on s.id_cliente_general = l.id_cliente_general join area_general a on e.id_area = a.id_area_general join entrega_uniformes u on (r.fecha=u.FECHA_UNIFORMES and u.ESTADO_UNIFORMES = 1) join detalle_uniformes du on u.id_uniformes = du.id_uniformes join DETALLE_KARDEX dk on du.ID_DETALLE_KARDEX_DETALLE_UNIFORMES = dk.ID_DETALLE join KARDEX ka on dk.ID_KARDEX = ka.ID_KARDEX join SECUENCIAL_ITEM sc on ka.ID_SECUENCIAL_ITEM=sc.ID_SECUENCIAL_ITEM where (r.fecha between @DESDE and @HASTA) and r.estado = 1  and r.tipo = 9 and (e.cedula like ('%' + @FILTRO + '%') or e.apellidos like ('%' + @FILTRO + '%') or e.nombres like ('%' + @FILTRO + '%') or sc.NOMBRE_SECUENCIAL_ITEM like ('%' + @FILTRO + '%'))) as tab group by tab.detalle order by tab.detalle;", false, pars);
        }

        public DataTable SeleccionarDescuentosDatos(TipoConexion tipoCon, string filtro, string desde, string hasta)
        { 
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, filtro }, 
                new object[] { "DESDE", SqlDbType.DateTime, desde },
                new object[] { "HASTA", SqlDbType.DateTime, hasta } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select CONVERT(varchar(10), r.id_registro) + ' - ' + convert(varchar, r.fecha, 103) + ' - ' + e.CEDULA + ' - '  + e.apellidos + ' ' + e.nombres + ' - ' + CONVERT(varchar(10), r.valor) + ' - ' + u.OBSERVACION_UNIFORMES DETALLE, sc.NOMBRE_SECUENCIAL_ITEM, du.CANTIDAD_DETALLE_UNIFORMES,SC.COSTO, dk.VALOR_UNITARIO_EGRESO, dk.VALOR_TOTAL_EGRESO, ((du.CANTIDAD_DETALLE_UNIFORMES*dk.VALOR_UNITARIO_EGRESO) - (du.CANTIDAD_DETALLE_UNIFORMES*SC.COSTO)) UTILIDAD from DESCUENTOS_ROL r join personal e on r.id_personal= e.id_personal join cargo_ocupacional c on e.id_cargo_ocupacional = c.id_cargo_ocupacional left join sitios_trabajo s on e.ubicacion = s.id_sitio_trabajo left join cliente_general l on s.id_cliente_general = l.id_cliente_general join area_general a on e.id_area = a.id_area_general join entrega_uniformes u on (r.fecha=u.FECHA_UNIFORMES and u.ESTADO_UNIFORMES = 1) join detalle_uniformes du on u.id_uniformes = du.id_uniformes join DETALLE_KARDEX dk on du.ID_DETALLE_KARDEX_DETALLE_UNIFORMES = dk.ID_DETALLE join KARDEX ka on dk.ID_KARDEX = ka.ID_KARDEX join SECUENCIAL_ITEM sc on ka.ID_SECUENCIAL_ITEM=sc.ID_SECUENCIAL_ITEM where (r.fecha between @DESDE and @HASTA) and r.estado = 1 and r.tipo = 9 and (e.cedula like ('%' + @FILTRO + '%') or e.apellidos like ('%' + @FILTRO + '%') or e.nombres like ('%' + @FILTRO + '%') or sc.NOMBRE_SECUENCIAL_ITEM like ('%' + @FILTRO + '%') ) order by  r.fecha, r.id_personal;", false, pars);
        }
         
        public bool IdDescuentoInDescuentosRol(TipoConexion tipoCon, string idDescuento, DateTime desde, DateTime hasta)
        {
            var pars = new List<object[]>
            {
                new object[] { "IDREGISTRO", SqlDbType.Int, idDescuento },
                new object[] { "DESDE", SqlDbType.DateTime, desde },
                new object[] { "HASTA", SqlDbType.DateTime, hasta },
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM DESCUENTOS_ROL D WHERE  D.id_registro = @IDREGISTRO AND D.id_registro IN (select R.id_registro from DESCUENTOS_ROL r join personal e on r.id_personal= e.id_personal join entrega_uniformes u on (r.fecha=u.FECHA_UNIFORMES and u.ESTADO_UNIFORMES = 1) join detalle_uniformes du on u.id_uniformes = du.id_uniformes join DETALLE_KARDEX dk on du.ID_DETALLE_KARDEX_DETALLE_UNIFORMES = dk.ID_DETALLE where (r.fecha between @DESDE AND @HASTA) and r.estado = 1 and r.tipo = 9);", false, pars);
            return data.Rows.Count > 0;
        }

        public SqlCommand NuevoDetallePrestamo()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sp_nuevo_registro_detalle_prestamo"
            };
            cmd.Parameters.AddWithValue("@id_detalle_prestamo", SqlDbType.Int).Value = IdDetallePrestamo;
            cmd.Parameters.AddWithValue("@periodo", SqlDbType.Int).Value = periodo;
            cmd.Parameters.AddWithValue("@fecha", SqlDbType.Date).Value = Fecha;
            cmd.Parameters.AddWithValue("@cuota", SqlDbType.Decimal).Value = cuota;
            cmd.Parameters.AddWithValue("@capital_pagado", SqlDbType.Decimal).Value = capital_pagado;
            cmd.Parameters.AddWithValue("@capital_restante", SqlDbType.Decimal).Value = capital_restante;
            cmd.Parameters.AddWithValue("@id_personal", SqlDbType.Int).Value = IdPersonal;
            cmd.Parameters.AddWithValue("@id_prestamo", SqlDbType.Int).Value = IdPrestamo;
            
            return cmd;
        }

        public SqlCommand NuevoPrestamo()
        {
            var cmd = new SqlCommand
        {
            CommandType = CommandType.StoredProcedure,
            CommandText = "sp_nuevo_registro_prestamo"
        };

            cmd.Parameters.AddWithValue("@id_prestamo", SqlDbType.Int).Value = IdPrestamo;
            cmd.Parameters.AddWithValue("@fecha", SqlDbType.Int).Value = Fecha;
            cmd.Parameters.AddWithValue("@plazo", SqlDbType.Date).Value = plazo;
            cmd.Parameters.AddWithValue("@cuota", SqlDbType.Decimal).Value = cuota;
            cmd.Parameters.AddWithValue("@monto_prestamo", SqlDbType.Decimal).Value = monto;
            cmd.Parameters.AddWithValue("@id_personal", SqlDbType.Int).Value = IdPersonal;


        return cmd;
        }
    }
}