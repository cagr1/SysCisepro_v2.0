using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassRegistroPermisoPersonal
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdRegistro { get; set; }
        public int IdPersonal { get; set; }
        public int IdSancion { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public int Estado { get; set; }
        public string Observacionx { get; set; }
        public DateTime FechaReg { get; set; }
        public int IdSitio { get; set; }
        public int NumDoc { get; set; }
        public byte[] Certificado { get; set; }

        public int BuscarMayorIdRegistroPermiso(TipoConexion tipoCon)
        {
            var data =  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_registro=CASE WHEN MAX(id_registro) IS NULL THEN 0 ELSE MAX(id_registro) End FROM REGISTRO_PERMISOS_PERSONAL;", false) ;
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public int BuscarMayorIdDoc(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT MAX(ndoc) FROM REGISTRO_PERMISOS_PERSONAL where estado = 1;", false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable SeleccionarTiposPermisos(TipoConexion tipoCon)
        {
            return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select id_sancion, detalle from sanciones_personal where san_per = 1 order by id_sancion;", false) ;
        }

        public DataTable SeleccionarTiposPermisosFiltro(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT 0 id_sancion, '-- TODOS LOS TIPOS --' detalle UNION (select id_sancion, detalle from sanciones_personal where san_per = 1) order by id_sancion", false) ;
        }

        public DataTable SeleccionarRegistroPermisosGrupos(TipoConexion tipoCon, string filtro, DateTime desde, DateTime hasta)
        {
            var pars = new List<object[]>
            {
                new object[] { "DESDE", SqlDbType.DateTime, desde } ,
                new object[] { "HASTA", SqlDbType.DateTime, hasta } ,
                new object[] { "FILTRO", SqlDbType.VarChar, filtro }  
            };
            return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select n.detalle sancion from REGISTRO_PERMISOS_PERSONAL r join sanciones_personal n on r.id_sancion = n.id_sancion join personal e on r.id_personal = e.id_personal where r.estado = 1 and r.fecha_registro between @DESDE and @HASTA and (n.detalle like ('%'+@FILTRO+'%') or e.cedula like ('%'+@FILTRO+'%') or e.apellidos like ('%'+@FILTRO+'%') or e.nombres like ('%'+@FILTRO+'%')) group by n.detalle order by n.detalle;", false, pars) ;
        }

        public DataTable SeleccionarPermisosDatos(TipoConexion tipoCon, string filtro, DateTime desde, DateTime hasta, string tipo)
        {
            tipo = tipo.Contains("TODOS LOS TIPOS") ? string.Empty : tipo;
            var pars = new List<object[]>
            {
                new object[] { "DESDE", SqlDbType.DateTime, desde } ,
                new object[] { "HASTA", SqlDbType.DateTime, hasta } ,
                new object[] { "FILTRO", SqlDbType.VarChar, filtro } ,
                new object[] { "TIPO", SqlDbType.VarChar, tipo }  
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select r.id_registro, n.detalle sancion, n.id_sancion, r.fecha_registro, e.apellidos+' '+e.nombres personal, r.desde,r.hasta, r.id_personal, c.descripcion, a.nombre_area, r.observacion, s.id_sitio_trabajo, s.nombre_sitio_trabajo + ' (' + l.nompre_razon_social_cliente_general + ')', r.ndoc from REGISTRO_PERMISOS_PERSONAL r join personal e on r.id_personal= e.id_personal join cargo_ocupacional c on e.id_cargo_ocupacional = c.id_cargo_ocupacional join area_general a on e.id_area = a.id_area_general join sanciones_personal n on r.id_sancion = n.id_sancion join sitios_trabajo s on r.id_sitio=s.id_sitio_trabajo join cliente_general l on s.id_cliente_general = l.id_cliente_general where r.estado = 1 and r.fecha_registro between @DESDE and @HASTA and n.detalle like ('%'+@TIPO+'%') and (e.cedula like ('%'+@FILTRO+'%') or e.apellidos like ('%'+@FILTRO+'%') or e.nombres like ('%'+@FILTRO+'%'));", false, pars) ;
        }

        public SqlCommand NuevoRegistroPermisoCommands()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into REGISTRO_PERMISOS_PERSONAL (id_registro, id_personal, id_sancion, desde, hasta, estado, observacion, id_sitio, fecha_registro, ndoc, certificado) values (@id_registro, @id_personal, @id_sancion, @desde, @hasta, @estado, @observacion, @idsitio, @fecha_registro, @ndoc, @certificado);"
            };
            cmd.Parameters.AddWithValue("@id_registro", SqlDbType.Int).Value = IdRegistro;
            cmd.Parameters.AddWithValue("@id_personal", SqlDbType.Int).Value = IdPersonal;
            cmd.Parameters.AddWithValue("@id_sancion", SqlDbType.Int).Value = IdSancion;
            cmd.Parameters.AddWithValue("@desde", SqlDbType.Date).Value = Desde;
            cmd.Parameters.AddWithValue("@hasta", SqlDbType.Date).Value = Hasta;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado;
            cmd.Parameters.AddWithValue("@observacion", SqlDbType.VarChar).Value = Observacionx;
            cmd.Parameters.AddWithValue("@idsitio", SqlDbType.Int).Value = IdSitio;
            cmd.Parameters.AddWithValue("@fecha_registro", SqlDbType.DateTime).Value = FechaReg;
            cmd.Parameters.AddWithValue("@ndoc", SqlDbType.Int).Value = NumDoc;
            cmd.Parameters.AddWithValue("@certificado", SqlDbType.VarBinary).Value = Certificado;
            return cmd;
        }

        public SqlCommand AnularRegistroPermisoCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update REGISTRO_PERMISOS_PERSONAL set estado=@estado where id_registro=@id_registro;"
            };
            cmd.Parameters.AddWithValue("@id_registro", SqlDbType.Int).Value = IdRegistro;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado;
            return cmd;
        }

        public string BuscarSancion(TipoConexion tipoCon, int id)
        {
            var pars = new List<object[]>
            {
                new object[] { "id_sancion", SqlDbType.Int, id } 
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT tipo_sancion FROM dbo.SANCIONES_PERSONAL WHERE   id_sancion=@id_sancion;", false, pars);
            return data.Rows.Count == 0 ? string.Empty : data.Rows[0]["SANCION"].ToString();
        }

        public DataTable BuscarIdRegistroPermiso(TipoConexion tipoCon, int id)
        {
            var pars = new List<object[]>
            {
                new object[] { "id_registro", SqlDbType.Int, id }
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT certificado FROM REGISTRO_PERMISOS_PERSONAL WHERE id_registro=@id_registro;", false, pars);
        }
    }
}
