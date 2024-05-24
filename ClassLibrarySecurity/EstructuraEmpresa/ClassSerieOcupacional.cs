using System.Data;
using ClassLibraryCisepro3.ProcesosSql;
using System;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;

namespace ClassLibraryCisepro3.EstructuraEmpresa
{
    public class ClassSerieOcupacional
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int SerieOcupacionalId { get; set; }
        public string SerieOcupacionalDescripcion { get; set; }
        public string SerieOcupacionalEstado { get; set; }
        public int SerieOcupacionaIdGrupoOcupacional { get; set; }

        public int BuscarMayorIdSerieOcupacional(TipoConexion tipoCon)
        {
            var data =  ComandosSql.SeleccionarQueryToDataTable(tipoCon,"BuscarMayorIdSerieOcupacional", true) ;
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable CargarDatosSerieOcupacional(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon,"SeleccionarTodosRegistrosSerieocupacional", true) ;
        }

        public SqlCommand NuevaSerieOcupacional()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "nuevaSerieOcupacional"
            };
            cmd.Parameters.AddWithValue("@ID_SERIE_OCUPACIONAL", SqlDbType.Int).Value = SerieOcupacionalId;
            cmd.Parameters.AddWithValue("@DESCRIPCION", SqlDbType.NVarChar).Value = SerieOcupacionalDescripcion;
            cmd.Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = SerieOcupacionalEstado;
            cmd.Parameters.AddWithValue("@ID_GRUPO_OCUPACIONAL", SqlDbType.Int).Value = SerieOcupacionaIdGrupoOcupacional;
            return cmd;
        }

        public SqlCommand ModificarSerieOcupacional()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "modificarSerieOcupacional"
            };
            cmd.Parameters.AddWithValue("@ID_SERIE_OCUPACIONAL", SqlDbType.Int).Value = SerieOcupacionalId;
            cmd.Parameters.AddWithValue("@DESCRIPCION", SqlDbType.NVarChar).Value = SerieOcupacionalDescripcion;
            cmd.Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = SerieOcupacionalEstado;
            cmd.Parameters.AddWithValue("@ID_GRUPO_OCUPACIONAL", SqlDbType.Int).Value = SerieOcupacionaIdGrupoOcupacional;
            return cmd;
        }
    }
}
