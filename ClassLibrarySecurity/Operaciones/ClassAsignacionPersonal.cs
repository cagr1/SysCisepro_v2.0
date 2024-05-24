using System;
using System.Collections.Generic;
using System.Data;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.Operaciones
{
    public class ClassAsignacionPersonal
    {
        public DataTable SeleccionarFechaEntradaSalidaByIdPersonal(TipoConexion tipoCon, int idp)
        {
            var pars = new List<object[]>
            {
                new object[] { "idp", SqlDbType.Int, idp } 
            };
            return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon,"select fecha_entrada, fecha_salida from personal where id_personal =@idp", false, pars);
        }

        public DataTable SeleccionarRegistroAsistenciaDetallesByGuardia(TipoConexion tipoCon, bool libre, int idp, DateTime desde, DateTime hasta, DateTime ingreso, DateTime sale)
        {
            var pars = new List<object[]>
            {
                new object[] { "DESDE", SqlDbType.DateTime, desde } ,
                 new object[] { "HASTA", SqlDbType.DateTime, hasta } ,
                 new object[] { "idp", SqlDbType.Int, idp } 
            };

            if (libre)
            {
                pars.Add(new object[] { "fechap", SqlDbType.Int, ingreso });
                pars.Add(new object[] { "fechas", SqlDbType.Int, sale });
            }

            var sql = "(select * from (select ap.id_puesto, ap.fecha, (select si.nombre_sitio_trabajo from sitios_trabajo si where si.id_sitio_trabajo = ap.id_puesto) puesto, ap.tipo,(select '$'+cast(sum(valor) as varchar) + ' - DESCUENTO MULTAS / ATRASOS' from descuentos_rol where id_personal = @idp and tipo = 10 and fecha = ap.fecha) observacion from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal  where pe.id_personal = @idp and ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE and @HASTA) as data group by id_puesto, fecha, puesto, tipo, observacion) " +
                (libre ? "union select * from (SELECT 0 id_puesto, IndividualDate fecha, 'SIN DATOS DEL PUESTO' puesto, 'LIBRE' tipo, 'SIN NOVEDADES' observacion FROM DatesInRange('d', @fechap, @fechas) where IndividualDate not in (select ap.fecha from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal where pe.id_personal = @idp and ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE and @HASTA)) as data order by fecha" : string.Empty);

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        }

        public DataTable SeleccionarRegistroAsistenciaDetallesByGuardias(TipoConexion tipoCon, bool libre, int idp, DateTime desde, DateTime hasta, DateTime ingreso, DateTime sale)
        {
            var pars = new List<object[]>
            {
                new object[] { "DESDE", SqlDbType.DateTime, desde } ,
                 new object[] { "HASTA", SqlDbType.DateTime, hasta } ,
                 new object[] { "idp", SqlDbType.Int, idp } 
            };

            if (libre)
            {
                pars.Add(new object[] { "fechap", SqlDbType.Int, ingreso });
                pars.Add(new object[] { "fechas", SqlDbType.Int, sale });
            }
             
            var sql = "select dias.fecha from ((select * from (select ap.id_puesto, ap.fecha, (select si.nombre_sitio_trabajo from sitios_trabajo si where si.id_sitio_trabajo = ap.id_puesto) puesto, ap.tipo,(select cast(cast(sum(valor)/2 as integer) as varchar) + ' - MULTA - NO CONTESTAR RADIO ' from descuentos_rol where id_personal = @idp and tipo = 10 and fecha between @fechap and @fechas) observacion from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal  where pe.id_personal = @idp and ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE and @HASTA) as data group by id_puesto, fecha, puesto, tipo, observacion) " +
                (libre ? "union select * from (SELECT 0 id_puesto, IndividualDate fecha, 'SIN DATOS DEL PUESTO' puesto, 'LIBRE' tipo, 'SIN NOVEDADES' observacion FROM DatesInRange('d', @fechap, @fechas) where IndividualDate not in (select ap.fecha from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal where pe.id_personal = @idp and ap.tipo <> 'PENDIENTE' and ap.fecha between @DESDE and @HASTA)) as data) as dias group by dias.fecha" : string.Empty);

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        }
    }
}
