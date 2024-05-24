using System; 
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.DivisionGeografica
{
    public class ClassProvincias
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdProvinciaProvincias { get; set; }
        public string NombreProvinciaProvincias { get; set; }
        public string EstadoProvincias { get; set; }
        public int IdPaisProvincias { get; set; }

        public int BuscarMayorIdProvincia(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdProvincia", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }
         
        public DataTable SeleccionarTodosLosRegistrosProvincias(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosProvincias", true);
        }

        public SqlCommand NuevoProvincia()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "NuevoProvincia"
            };
            cmd.Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvinciaProvincias;
            cmd.Parameters.AddWithValue("@NOMBRE_PROVINCIAS", SqlDbType.Int).Value = NombreProvinciaProvincias;
            return cmd;
        }

        public SqlCommand ActualizarProvincia()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update provincias set NOMBRE_PROVINCIAS = @NOMBRE_PROVINCIAS where id_provinicas=@ID_PROVINCIAS;"
            };
            cmd.Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvinciaProvincias;
            cmd.Parameters.AddWithValue("@NOMBRE_PROVINCIAS", SqlDbType.Int).Value = NombreProvinciaProvincias;
            return cmd;
        } 
    }
}
