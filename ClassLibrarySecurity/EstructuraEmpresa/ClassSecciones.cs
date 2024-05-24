using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.EstructuraEmpresa
{
    public class ClassSecciones
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int SeccionId { get; set; }
        public string SeccionCodigo { get; set; }
        public string SeccionNombre { get; set; }
        public int SeccionEstado { get; set; }
        public int SeccionIdArea { get; set; }

        public DataTable SeleccionarTodosLosRegistrosSeccion(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon,"SeleccionarTodosLosRegistrosSeccion", true) ;
        }

        public int BuscarMayorIdSeccion(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdSeccion", true)  ;
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public string GenerarCodigoSiguienteSeccionPorIdArea(TipoConexion tipoCon, int ida)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_AREA_GENERAL", SqlDbType.Int, ida }  
            };
            var data =  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "generarCodigoSiguienteSeccionPorIdArea", true, pars)  ;
            return data.Rows.Count == 0 ? string.Empty : data.Rows[0]["CODIGO"].ToString();
        }

        public SqlCommand NuevaSeccion()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "nuevaSeccion"
            };
            cmd.Parameters.AddWithValue("@ID_SECCION", SqlDbType.Int).Value = SeccionId;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = SeccionCodigo;
            cmd.Parameters.AddWithValue("@NOMBRE_SECCION", SqlDbType.NVarChar).Value = SeccionNombre;
            cmd.Parameters.AddWithValue("@ESTADO_SECCION", SqlDbType.Int).Value = SeccionEstado;
            cmd.Parameters.AddWithValue("@ID_AREA_GENERAL", SqlDbType.Int).Value = SeccionIdArea;
            return cmd;
        }

        public SqlCommand ModificarSeccion()
        { 
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "modificarSeccion"
            };
            cmd.Parameters.AddWithValue("@ID_SECCION", SqlDbType.Int).Value = SeccionId;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = SeccionCodigo;
            cmd.Parameters.AddWithValue("@NOMBRE_SECCION", SqlDbType.NVarChar).Value = SeccionNombre;
            cmd.Parameters.AddWithValue("@ESTADO_SECCION", SqlDbType.Int).Value = SeccionEstado;
            cmd.Parameters.AddWithValue("@ID_AREA_GENERAL", SqlDbType.Int).Value = SeccionIdArea;
            return cmd;
        } 
    }
}
