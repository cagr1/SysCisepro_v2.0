using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassHistorialLaboral
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdHistoriaLaboral { get; set; }
        public DateTime FechaHistoriaLaboral { get; set; }
        public string DetalleHistoriaLaboral { get; set; }
        public int EstadoHistoriaLaboral { get; set; }
        public int IdPersonalHistoriaLaboral { get; set; }
        public string IdSitioHistoriaLaboral { get; set; }
        public int IdSitioAuxHistoriaLaboral { get; set; }

        public int BuscarMayorIdHistoriaLaboral(TipoConexion tipoCon)
        {
            var data =  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdHistoriaLaboral", true)  ;
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public SqlCommand RegistrarNuevoHistorialLaboralCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "nuevaHistoriaLaboral"
            };
            cmd.Parameters.AddWithValue("@ID_HISTORIA_LABORAL", SqlDbType.BigInt).Value = IdHistoriaLaboral;
            cmd.Parameters.AddWithValue("@FECHA_HISTORIA_LABORAL", SqlDbType.DateTime).Value = FechaHistoriaLaboral;
            cmd.Parameters.AddWithValue("@DETALLE_HISTORIA_LABORAL", SqlDbType.Text).Value = DetalleHistoriaLaboral;
            cmd.Parameters.AddWithValue("@ESTADO_HISTORIA_LABORAL", SqlDbType.Int).Value = EstadoHistoriaLaboral;
            cmd.Parameters.AddWithValue("@ID_PERSONAL_HISTORIA_LABORAL", SqlDbType.BigInt).Value = IdPersonalHistoriaLaboral;
            cmd.Parameters.AddWithValue("@ID_SITIO_PUESTO", SqlDbType.NVarChar).Value = IdSitioHistoriaLaboral;
            cmd.Parameters.AddWithValue("@ID_AUX", SqlDbType.BigInt).Value = IdSitioAuxHistoriaLaboral;
            return cmd;
        }

        public DataTable SeleccionarTodosRegistrosHistorialPersonal(TipoConexion tipoCon, string id)
        {
            var pars = new List<object[]>
            {
                new object[] {"id_personal", SqlDbType.Int, id}
            };
            return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon,"select h.id_historia_laboral ID, h.fecha_historia_laboral FECHA, h.detalle_historia_laboral DETALLE from historia_laboral h where h.ID_PERSONAL_HISTORIA_LABORAL = @id_personal order by h.fecha_historia_laboral;", false, pars);
        }


        public SqlCommand DeleteIdHistoriaLaboral(int id, DateTime desde, DateTime hasta )
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "delete From HISTORIA_LABORAL	where HISTORIA_LABORAL.ID_PERSONAL_HISTORIA_LABORAL = @ID and HISTORIA_LABORAL.ID_AUX = 1234567 AND HISTORIA_LABORAL.FECHA_HISTORIA_LABORAL BETWEEN @DESDE AND @HASTA"
            };
            cmd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = id;
            cmd.Parameters.AddWithValue("@DESDE", SqlDbType.DateTime).Value = desde;
            cmd.Parameters.AddWithValue("@HASTA", SqlDbType.Date).Value = hasta;
            
            return cmd;
        }

        
    }
}
