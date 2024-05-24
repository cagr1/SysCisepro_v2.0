using System;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.EstructuraEmpresa
{
    public class ClassGrupoocupacional
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int GrupoOcupacionalId { get; set; }
        public string GrupoOcupacionalDescripcion { get; set; }
        public int GrupoOcupacionalEstado { get; set; }

        public int BuscarMayorIdGrupoOcupacional(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon,"BuscarMayorIdGrupoOcupacional", true)  ;
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable CargarDatosGrupoOcupacional(TipoConexion tipoCon)
        {
            return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosGrupoOcupacional", true) ;
        }

        public SqlCommand NuevoGrupoOcupacional()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "NuevoGrupoOcupacional"
            };
            cmd.Parameters.AddWithValue("@ID_GRUPO_OCUPACIONAL", SqlDbType.Int).Value = GrupoOcupacionalId;
            cmd.Parameters.AddWithValue("@DESCRIPCION", SqlDbType.Int).Value = GrupoOcupacionalDescripcion;
            cmd.Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = GrupoOcupacionalEstado;
            return cmd;
        }

        public SqlCommand ModificarGrupoOcupacional()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "modificarGrupoOcupacional"
            };
            cmd.Parameters.AddWithValue("@ID_GRUPO_OCUPACIONAL", SqlDbType.Int).Value = GrupoOcupacionalId;
            cmd.Parameters.AddWithValue("@DESCRIPCION", SqlDbType.Int).Value = GrupoOcupacionalDescripcion;
            cmd.Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = GrupoOcupacionalEstado;
            return cmd;
        }
    }
}
