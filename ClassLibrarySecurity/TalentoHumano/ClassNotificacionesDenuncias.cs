using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassNotificacionesDenuncias
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int NumDocumento { get; set; }
        public DateTime FechaNotificacion { get; set; }
        public string CedulaRuc { get; set; }
        public string ApellidosNombres { get; set; }
        public string Detalle { get; set; }
        public int Estado { get; set; }

        public int BuscarMayorIdNotificacion(TipoConexion tipoCon)
        {
            var data =  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_notificacion=CASE WHEN MAX(id_notificacion) IS NULL THEN 0 ELSE MAX(id_notificacion) End FROM NOTIFICACIONES_DENUNCIAS;", false) ;
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable SeleccionarRegistroNotificaciones(TipoConexion tipoCon, string desde, string hasta, string filtro)
        {
            var pars = new List<object[]>
            {
                new object[] { "DESDE", SqlDbType.DateTime, desde } ,
                new object[] { "HASTA", SqlDbType.DateTime, hasta } ,
                new object[] { "FILTRO", SqlDbType.VarChar, filtro }  
            };
            return   ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select r.* from NOTIFICACIONES_DENUNCIAS r where r.estado = 1 and r.fecha_notificacion between @DESDE and @HASTA and (r.detalle_notificacion like ('%'+@FILTRO+'%') or r.cedularuc like ('%'+@FILTRO+'%') or r.apellidos_nombres like ('%'+@FILTRO+'%')) order by r.fecha_notificacion;", false, pars) ;
        }

        public SqlCommand NuevoRegistroNotificacionCommands()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into NOTIFICACIONES_DENUNCIAS (id_notificacion, num_notificacion, fecha_registro, fecha_notificacion, cedularuc, apellidos_nombres, detalle_notificacion, estado) values " +
                              "(@id_notificacion, @num_notificacion, @fecha_registro, @fecha_notificacion, @cedularuc, @apellidos_nombres, @detalle_notificacion, @estado);"
            };
            cmd.Parameters.AddWithValue("@id_notificacion", SqlDbType.Int).Value = IdRegistro;
            cmd.Parameters.AddWithValue("@num_notificacion", SqlDbType.Int).Value = NumDocumento;
            cmd.Parameters.AddWithValue("@fecha_registro", SqlDbType.Date).Value = FechaRegistro;
            cmd.Parameters.AddWithValue("@fecha_notificacion", SqlDbType.Date).Value = FechaNotificacion;
            cmd.Parameters.AddWithValue("@cedularuc", SqlDbType.VarChar).Value = CedulaRuc;
            cmd.Parameters.AddWithValue("@apellidos_nombres", SqlDbType.VarChar).Value = ApellidosNombres;
            cmd.Parameters.AddWithValue("@detalle_notificacion", SqlDbType.VarChar).Value = Detalle;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado;
            return cmd;
        }

        public SqlCommand AnularRegistroNotificacion()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update NOTIFICACIONES_DENUNCIAS set estado=@estado where id_notificacion=@id_notificacion;"
            };
            cmd.Parameters.AddWithValue("@id_notificacion", SqlDbType.Int).Value = IdRegistro;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado;
            return cmd;
        } 
    }
}
