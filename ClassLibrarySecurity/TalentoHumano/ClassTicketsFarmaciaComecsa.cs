using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassTicketsFarmaciaComecsa
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
        public string CedulaRuc { get; set; }
        public string ApellidosNombres { get; set; }
        public string Detalle { get; set; }
        public int Tipo { get; set; }
        public int Estado { get; set; }

        public int BuscarMayorIdTicket(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_ticket=CASE WHEN MAX(id_ticket) IS NULL THEN 0 ELSE MAX(id_ticket) End FROM TICKETS_FARMACIA_COMECSA;", false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable SeleccionarRegistroNotificaciones(TipoConexion tipoCon, DateTime desde, DateTime hasta, int tipo, string filtro)
        {
            var pars = new List<object[]>
            {
                new object[] { "@DESDE", SqlDbType.DateTime, desde } ,
                new object[] { "@HASTA", SqlDbType.DateTime, hasta } ,
                new object[] { "@FILTRO", SqlDbType.NVarChar, filtro },
                new object[] { "@TIPO", SqlDbType.Int, tipo}
            };
                 
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_seleccionarRegistrosNotificaciones", true, pars);
        }

        public DataTable SeleccionarRegistroNotificacionesTodo(TipoConexion tipoCon, DateTime desde, DateTime hasta, string filtro)
        {
            var pars = new List<object[]>
            {
                new object[] { "@DESDE", SqlDbType.DateTime, desde } ,
                new object[] { "@HASTA", SqlDbType.DateTime, hasta } ,
                new object[] { "@FILTRO", SqlDbType.NVarChar, filtro },
                
            };

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_seleccionarRegistrosNotificacionesTodos", true, pars);
        }

        public SqlCommand NuevoRegistroNotificacionCommands()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into TICKETS_FARMACIA_COMECSA (id_ticket, num_ticket, fecha_registro, cedularuc, apellidos_nombres, detalle_observacion, tipo_ticket, estado) values " +
                              "(@id_ticket, @num_ticket, @fecha_registro, @cedularuc, @apellidos_nombres, @detalle_observacion, @tipo_ticket, @estado);"
            };
            cmd.Parameters.AddWithValue("@id_ticket", SqlDbType.Int).Value = IdRegistro;
            cmd.Parameters.AddWithValue("@num_ticket", SqlDbType.Int).Value = NumDocumento;
            cmd.Parameters.AddWithValue("@fecha_registro", SqlDbType.Date).Value = FechaRegistro; 
            cmd.Parameters.AddWithValue("@cedularuc", SqlDbType.VarChar).Value = CedulaRuc;
            cmd.Parameters.AddWithValue("@apellidos_nombres", SqlDbType.VarChar).Value = ApellidosNombres;
            cmd.Parameters.AddWithValue("@detalle_observacion", SqlDbType.VarChar).Value = Detalle;
            cmd.Parameters.AddWithValue("@tipo_ticket", SqlDbType.Int).Value = Tipo;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado;
            return cmd;
        }

        public SqlCommand AnularRegistroNotificacion()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update TICKETS_FARMACIA_COMECSA set estado=@estado where id_ticket=@id_ticket;"
            };
            cmd.Parameters.AddWithValue("@id_ticket", SqlDbType.Int).Value = IdRegistro;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado;
            return cmd;
        } 
    }
}
