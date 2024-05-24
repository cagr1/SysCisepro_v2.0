using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryCisepro3.Contabilidad.LibroDiario
{
    public class ClassPorcentajesRetencion
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdConceptoPago { get; set; }
        public string CodigoPorcentajesRetencion { get; set; }
        public string ConceptoPorcentajesRetencion { get; set; }
        public int AnioPorcentajesRetencion { get; set; }
        public int EstadoPorcentajesRetencion { get; set; }

        public int IdPorcentajesRetencion { get; set; }
        public double CantidadPorcentajesRetencion { get; set; }
        public int TipoImpuestoPorcentajesRetencion { get; set; } 
        public int TipoContribuyentePorcentajesRetencion { get; set; }

        public string CuentaCompraPorcentajesRetencion { get; set; }
        public string CuentaVentaPorcentajesRetencion { get; set; }

        public int TipoBienServicio { get; set; } // 0 BIEN - 1 SERVICIO

        public int BuscarMayorIdConceptoPago(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT ID_CONCEPTO_PAGO=MAX(ID_CONCEPTO_PAGO) FROM dbo.CONCEPTO_PAGO", false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }
        public int BuscarMayorIdPorcentajesRetencion(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT ID_PORCENTAJE_RETENCION=MAX(ID_PORCENTAJE_RETENCION) FROM dbo.PORCENTAJE_RETENCION", false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }
        public DataTable SeleccionarConceptoPagoPorCod(TipoConexion tipoCon, string cod)
        {
            var pars = new List<object[]>
            {
                new object[] { "COD", SqlDbType.VarChar, cod } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from CONCEPTO_PAGO where CODIGO_CONCEPTO_PAGO = @COD;", false, pars);
        }
        public DataTable SeleccionarConceptoPagoPorIdCod(TipoConexion tipoCon, string idp, string cod)
        {
            var pars = new List<object[]>
            {
                new object[] { "IDP", SqlDbType.VarChar, idp } ,
                new object[] { "COD", SqlDbType.VarChar, cod } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from CONCEPTO_PAGO where ID_CONCEPTO_PAGO <>@IDP and CODIGO_CONCEPTO_PAGO = @COD;", false, pars);
        }        
        public DataTable SeleccionarRegistrosPorcentajesRetencionRentaGrupo(TipoConexion tipoCon, string filtro)
        {
            var pars = new List<object[]>
            {
                new object[] { "FIL", SqlDbType.VarChar,  string.Concat("%", filtro, "%") } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select c.DESCRIPCION_CONCEPTO_PAGO from PORCENTAJE_RETENCION p join IMPUESTO_RETENIDO i on p.ID_IMPUESTO_RETENIDO=i.ID_IMPUESTO_RETENIDO join CONCEPTO_PAGO c on p.ID_CONCEPTO_PAGO=c.ID_CONCEPTO_PAGO join CONTRIBUYENTE_RETENIDO r on p.ID_CONTRIBUYENTE_RETENIDO=r.ID_CONTRIBUYENTE_RETENIDO WHERE c.ESTADO_CONCEPTO_PAGO = 1 and i.DESCRIPCION_IMPUESTO_RETENIDO = 'RENTA' AND c.DESCRIPCION_CONCEPTO_PAGO LIKE @FIL group by c.DESCRIPCION_CONCEPTO_PAGO order by c.DESCRIPCION_CONCEPTO_PAGO;", false, pars);
        }
        public DataTable SeleccionarRegistrosPorcentajesRetencionRentaDatos(TipoConexion tipoCon, string filtro)
        {
            var pars = new List<object[]>
            {
                new object[] { "FIL", SqlDbType.VarChar,  string.Concat("%", filtro, "%") } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select p.ID_PORCENTAJE_RETENCION, c.DESCRIPCION_CONCEPTO_PAGO, r.TIPO_CONTRIBUYENTE_RETENIDO, p.CANTIDAD_PORCENTAJE_RETENCION, i.DESCRIPCION_IMPUESTO_RETENIDO, p.ID_CONCEPTO_PAGO from PORCENTAJE_RETENCION p join IMPUESTO_RETENIDO i on p.ID_IMPUESTO_RETENIDO=i.ID_IMPUESTO_RETENIDO join CONCEPTO_PAGO c on p.ID_CONCEPTO_PAGO=c.ID_CONCEPTO_PAGO join CONTRIBUYENTE_RETENIDO r on p.ID_CONTRIBUYENTE_RETENIDO=r.ID_CONTRIBUYENTE_RETENIDO WHERE c.ESTADO_CONCEPTO_PAGO = 1 and i.DESCRIPCION_IMPUESTO_RETENIDO = 'RENTA' AND c.DESCRIPCION_CONCEPTO_PAGO LIKE @FIL order by i.DESCRIPCION_IMPUESTO_RETENIDO, c.DESCRIPCION_CONCEPTO_PAGO, r.TIPO_CONTRIBUYENTE_RETENIDO, p.CANTIDAD_PORCENTAJE_RETENCION;", false, pars);
        }
        public DataTable SeleccionarRegistrosDePorcentajesRetencionRenta(TipoConexion tipoCon, string codigo)
        {
            var pars = new List<object[]>
            {
                new object[] { "CODIGO", SqlDbType.VarChar,  codigo }
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select c.ID_CONCEPTO_PAGO, p.ID_PORCENTAJE_RETENCION, r.TIPO_CONTRIBUYENTE_RETENIDO, p.CANTIDAD_PORCENTAJE_RETENCION, p.cuenta_compra, p.cuenta_venta, cc.detalle compra, cv.detalle venta from PORCENTAJE_RETENCION p join IMPUESTO_RETENIDO i on p.ID_IMPUESTO_RETENIDO=i.ID_IMPUESTO_RETENIDO join CONCEPTO_PAGO c on p.ID_CONCEPTO_PAGO=c.ID_CONCEPTO_PAGO join CONTRIBUYENTE_RETENIDO r on p.ID_CONTRIBUYENTE_RETENIDO=r.ID_CONTRIBUYENTE_RETENIDO left join PLAN_CUENTAS_GENERAL cc on p.cuenta_compra=cc.codigo left join PLAN_CUENTAS_GENERAL cv on p.cuenta_venta=cv.codigo WHERE i.DESCRIPCION_IMPUESTO_RETENIDO = 'RENTA' and c.codigo_CONCEPTO_PAGO =@CODIGO", false, pars);
        }
        public SqlCommand RegistrarNuevoCodigoConceptoPorcentajeRetencionCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into CONCEPTO_PAGO values (@idcp, @cod, @des, @anio, @est);"
            };
            cmd.Parameters.AddWithValue("@idcp", SqlDbType.Int).Value = IdConceptoPago;
            cmd.Parameters.AddWithValue("@cod", SqlDbType.VarChar).Value = CodigoPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@des", SqlDbType.VarChar).Value = ConceptoPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@anio", SqlDbType.Int).Value = AnioPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@est", SqlDbType.Int).Value = EstadoPorcentajesRetencion;
            return cmd;
        }

        public SqlCommand ModificarCodigoConceptoPorcentajeRetencionCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update CONCEPTO_PAGO set CODIGO_CONCEPTO_PAGO=@cod, DESCRIPCION_CONCEPTO_PAGO=@des, EJERCICIO_FISCAL_CONCEPTO_PAGO=@anio where ID_CONCEPTO_PAGO=@idcp;"
            };
            cmd.Parameters.AddWithValue("@idcp", SqlDbType.Int).Value = IdConceptoPago;
            cmd.Parameters.AddWithValue("@cod", SqlDbType.VarChar).Value = CodigoPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@des", SqlDbType.VarChar).Value = ConceptoPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@anio", SqlDbType.Int).Value = AnioPorcentajesRetencion;
            return cmd;
        }
        public SqlCommand RegistrarNuevoPorcentajeRetencionCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into PORCENTAJE_RETENCION values (@ID_PORCENTAJE_RETENCION, @CANTIDAD_PORCENTAJE_RETENCION, @ID_IMPUESTO_RETENIDO, @ID_CONCEPTO_PAGO, @ID_CONTRIBUYENTE_RETENIDO, @CUENTA_COMPRA, @CUENTA_VENTA, @TIPO_B_S);"
            };
            cmd.Parameters.AddWithValue("@ID_PORCENTAJE_RETENCION", SqlDbType.Int).Value = IdPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@CANTIDAD_PORCENTAJE_RETENCION", SqlDbType.Decimal).Value = CantidadPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@ID_IMPUESTO_RETENIDO", SqlDbType.Int).Value = TipoImpuestoPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@ID_CONCEPTO_PAGO", SqlDbType.Int).Value = IdConceptoPago;
            cmd.Parameters.AddWithValue("@ID_CONTRIBUYENTE_RETENIDO", SqlDbType.Int).Value = TipoContribuyentePorcentajesRetencion;
            cmd.Parameters.AddWithValue("@CUENTA_COMPRA", SqlDbType.VarChar).Value = CuentaCompraPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@CUENTA_VENTA", SqlDbType.VarChar).Value = CuentaVentaPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@TIPO_B_S", SqlDbType.Int).Value = TipoBienServicio;
            return cmd;
        }

        public SqlCommand ActualizarNuevoPorcentajeRetencionCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update PORCENTAJE_RETENCION set CANTIDAD_PORCENTAJE_RETENCION=@CANTIDAD_PORCENTAJE_RETENCION, ID_IMPUESTO_RETENIDO=@ID_IMPUESTO_RETENIDO, ID_CONCEPTO_PAGO=@ID_CONCEPTO_PAGO, ID_CONTRIBUYENTE_RETENIDO=@ID_CONTRIBUYENTE_RETENIDO,  CUENTA_COMPRA=@CUENTA_COMPRA, CUENTA_VENTA=@CUENTA_VENTA where ID_PORCENTAJE_RETENCION=@ID_PORCENTAJE_RETENCION;"
            };
            cmd.Parameters.AddWithValue("@ID_PORCENTAJE_RETENCION", SqlDbType.Int).Value = IdPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@CANTIDAD_PORCENTAJE_RETENCION", SqlDbType.Decimal).Value = CantidadPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@ID_IMPUESTO_RETENIDO", SqlDbType.Int).Value = TipoImpuestoPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@ID_CONCEPTO_PAGO", SqlDbType.Int).Value = IdConceptoPago;
            cmd.Parameters.AddWithValue("@ID_CONTRIBUYENTE_RETENIDO", SqlDbType.Int).Value = TipoContribuyentePorcentajesRetencion;
            cmd.Parameters.AddWithValue("@CUENTA_COMPRA", SqlDbType.VarChar).Value = CuentaCompraPorcentajesRetencion;
            cmd.Parameters.AddWithValue("@CUENTA_VENTA", SqlDbType.VarChar).Value = CuentaVentaPorcentajesRetencion;
            return cmd;
        }
        public SqlCommand AnularCodigoConceptoPorcentajeRetencionCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update CONCEPTO_PAGO set ESTADO_CONCEPTO_PAGO=0 where ID_CONCEPTO_PAGO=@idcp;"
            };
            cmd.Parameters.AddWithValue("@idcp", SqlDbType.Int).Value = IdConceptoPago;
            return cmd;
        }
        public SqlCommand EliminarPorcentajeRetencionCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "delete from PORCENTAJE_RETENCION where ID_CONCEPTO_PAGO = @idcp;"
            };
            cmd.Parameters.AddWithValue("@idcp", SqlDbType.Int).Value = IdConceptoPago;
            return cmd;
        }



























        public DataTable SeleccionarRegistrosPorcentajesRetencionIvaGrupo(TipoConexion tipoCon, string filtro)
        {
            var pars = new List<object[]>
            {
                new object[] { "FIL", SqlDbType.VarChar,  string.Concat("%", filtro, "%") } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT T.DESCRIPCION_CONCEPTO_PAGO FROM (select 'RETENCIÓN DE IMPUESTO AL VALOR AGREGADO' + (CASE P.TIPO_B_S WHEN 0 THEN ' - BIENES' ELSE ' - SERVICIOS' END) DESCRIPCION_CONCEPTO_PAGO from PORCENTAJE_RETENCION p join IMPUESTO_RETENIDO i on p.ID_IMPUESTO_RETENIDO=i.ID_IMPUESTO_RETENIDO join CONTRIBUYENTE_RETENIDO r on p.ID_CONTRIBUYENTE_RETENIDO=r.ID_CONTRIBUYENTE_RETENIDO WHERE i.DESCRIPCION_IMPUESTO_RETENIDO = 'IVA' AND (r.TIPO_CONTRIBUYENTE_RETENIDO LIKE @FIL OR p.CANTIDAD_PORCENTAJE_RETENCION LIKE @FIL )) AS T GROUP BY T.DESCRIPCION_CONCEPTO_PAGO;", false, pars);
        }
        public DataTable SeleccionarRegistrosPorcentajesRetencionIvaDatos(TipoConexion tipoCon, string filtro)
        {
            var pars = new List<object[]>
            {
                new object[] { "FIL", SqlDbType.VarChar,  string.Concat("%", filtro, "%") } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select p.ID_PORCENTAJE_RETENCION, 'RETENCIÓN DE IMPUESTO AL VALOR AGREGADO' + (CASE P.TIPO_B_S WHEN 0 THEN ' - BIENES' ELSE ' - SERVICIOS' END) DESCRIPCION_CONCEPTO_PAGO, r.TIPO_CONTRIBUYENTE_RETENIDO, p.CANTIDAD_PORCENTAJE_RETENCION, i.DESCRIPCION_IMPUESTO_RETENIDO, P.TIPO_B_S from PORCENTAJE_RETENCION p join IMPUESTO_RETENIDO i on p.ID_IMPUESTO_RETENIDO=i.ID_IMPUESTO_RETENIDO join CONTRIBUYENTE_RETENIDO r on p.ID_CONTRIBUYENTE_RETENIDO=r.ID_CONTRIBUYENTE_RETENIDO WHERE i.DESCRIPCION_IMPUESTO_RETENIDO = 'IVA' AND (r.TIPO_CONTRIBUYENTE_RETENIDO LIKE @FIL OR p.CANTIDAD_PORCENTAJE_RETENCION LIKE @FIL ) order by r.TIPO_CONTRIBUYENTE_RETENIDO, p.CANTIDAD_PORCENTAJE_RETENCION;", false, pars);
        }
        public DataTable SeleccionarRegistrosDePorcentajesRetencionIvaBien(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select p.TIPO_B_S, p.ID_PORCENTAJE_RETENCION, r.TIPO_CONTRIBUYENTE_RETENIDO, p.CANTIDAD_PORCENTAJE_RETENCION, p.cuenta_compra, p.cuenta_venta, cc.detalle compra, cv.detalle venta from PORCENTAJE_RETENCION p join IMPUESTO_RETENIDO i on p.ID_IMPUESTO_RETENIDO=i.ID_IMPUESTO_RETENIDO join CONTRIBUYENTE_RETENIDO r on p.ID_CONTRIBUYENTE_RETENIDO=r.ID_CONTRIBUYENTE_RETENIDO left join PLAN_CUENTAS_GENERAL cc on p.cuenta_compra=cc.codigo left join PLAN_CUENTAS_GENERAL cv on p.cuenta_venta=cv.codigo WHERE i.DESCRIPCION_IMPUESTO_RETENIDO = 'IVA' and p.TIPO_B_S = 0 order by  r.ID_CONTRIBUYENTE_RETENIDO;", false);
        }
        public DataTable SeleccionarRegistrosDePorcentajesRetencionIvaServicio(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select p.TIPO_B_S, p.ID_PORCENTAJE_RETENCION, r.TIPO_CONTRIBUYENTE_RETENIDO, p.CANTIDAD_PORCENTAJE_RETENCION, p.cuenta_compra, p.cuenta_venta, cc.detalle compra, cv.detalle venta from PORCENTAJE_RETENCION p join IMPUESTO_RETENIDO i on p.ID_IMPUESTO_RETENIDO=i.ID_IMPUESTO_RETENIDO join CONTRIBUYENTE_RETENIDO r on p.ID_CONTRIBUYENTE_RETENIDO=r.ID_CONTRIBUYENTE_RETENIDO left join PLAN_CUENTAS_GENERAL cc on p.cuenta_compra=cc.codigo left join PLAN_CUENTAS_GENERAL cv on p.cuenta_venta=cv.codigo WHERE i.DESCRIPCION_IMPUESTO_RETENIDO = 'IVA' and p.TIPO_B_S = 1 order by  r.ID_CONTRIBUYENTE_RETENIDO;", false);
        }
    }
}
