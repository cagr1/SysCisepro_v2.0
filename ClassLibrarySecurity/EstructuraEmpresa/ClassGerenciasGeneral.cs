using System;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.ProcesosSql;
using System.Collections.Generic;
using ClassLibraryCisepro3.Enums;

namespace ClassLibraryCisepro3.EstructuraEmpresa
{
    public class ClassGerenciasGeneral
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int GerenciasId { get; set; }
        public string GerenciasCodigo { get; set; }
        public string GerenciasNombre { get; set; }
        public int GerenciasEstado { get; set; }
        public int GerenciasIdGerencia { get; set; }

        public DataTable SeleccionarTodosLosRegistrosGerenciasGeneral(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon,"seleccionarTodosLosRegistrosGerenciasGeneral", true);
        }

        public int BuscarMayorIdGerencias(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon,"BuscarMayorIdGerencias", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public string GenerarCodigoSiguienteGerenciasPorIdGerencias(TipoConexion tipoCon, int idg)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_GERENCIA", SqlDbType.Int, idg }  
            };
            var data =  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "generarCodigoSiguienteGerenciasPorIdGerencias", true, pars) ;
            return data.Rows.Count == 0 ? string.Empty :  data.Rows[0]["CODIGO"].ToString();
        }

        public SqlCommand NuevaGerencias()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "nuevaGerencias"
            };
            cmd.Parameters.AddWithValue("@ID_GERENCIAS_GENERAL", SqlDbType.Int).Value = GerenciasId;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = GerenciasCodigo;
            cmd.Parameters.AddWithValue("@NOMBRE_GERENCIAS", SqlDbType.NVarChar).Value = GerenciasNombre;
            cmd.Parameters.AddWithValue("@ESTADO_GERENCIAS", SqlDbType.Int).Value = GerenciasEstado;
            cmd.Parameters.AddWithValue("@ID_GERENCIA", SqlDbType.Int).Value = GerenciasIdGerencia;
            return cmd;
        }

        public SqlCommand ModificarGerencias()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "modificarGerencias"
            };
            cmd.Parameters.AddWithValue("@ID_GERENCIAS_GENERAL", SqlDbType.Int).Value = GerenciasId;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = GerenciasCodigo;
            cmd.Parameters.AddWithValue("@NOMBRE_GERENCIAS", SqlDbType.NVarChar).Value = GerenciasNombre;
            cmd.Parameters.AddWithValue("@ESTADO_GERENCIAS", SqlDbType.Int).Value = GerenciasEstado;
            cmd.Parameters.AddWithValue("@ID_GERENCIA", SqlDbType.Int).Value = GerenciasIdGerencia;
            return cmd;
        } 
    }
}
