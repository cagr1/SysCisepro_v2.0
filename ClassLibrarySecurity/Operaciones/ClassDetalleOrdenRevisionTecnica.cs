using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibraryCisepro3.Operaciones
{
    public class ClassDetalleOrdenRevisionTecnica
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdOrden { get; set; }
        public int IdDetalle { get; set; }
        public string Detalle { get; set; }
        public int Ok { get; set; }
        public string Observacion { get; set; }


        public int BuscarMayorIdDetalleOrdenTecnica(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_detalle=CASE WHEN MAX(id_detalle) IS NULL THEN 0 ELSE MAX(id_detalle) End FROM DETALLE_ORDEN_TECNICA_SUPERVISION;", false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable SeleccionarRegistroDetalle(TipoConexion tipoCon, int idorden)
        {
            var pars = new List<object[]>
            {
                new object[] { "IDORDEN", SqlDbType.Int, idorden } , 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from DETALLE_ORDEN_TECNICA_SUPERVISION where ID_ORDEN=@IDORDEN;", false, pars);
        }

        public SqlCommand NuevoRegistroDetalleOrdenCommands()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into DETALLE_ORDEN_TECNICA_SUPERVISION (id_orden, id_detalle, detalle, ok, observacion) values " +
                              "(@id_orden, @id_detalle, @detalle, @ok, @observacion);"
            };

            cmd.Parameters.AddWithValue("@id_orden", SqlDbType.Int).Value = IdOrden;
            cmd.Parameters.AddWithValue("@id_detalle", SqlDbType.Int).Value = IdDetalle;
            cmd.Parameters.AddWithValue("@detalle", SqlDbType.VarChar).Value = Detalle;
            cmd.Parameters.AddWithValue("@ok", SqlDbType.Int).Value = Ok;
            cmd.Parameters.AddWithValue("@observacion", SqlDbType.VarChar).Value = Observacion; 
            return cmd;
        } 
    }
}
