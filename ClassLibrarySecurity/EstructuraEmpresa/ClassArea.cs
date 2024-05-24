using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.EstructuraEmpresa
{
    public class ClassArea
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int AreaId { get; set; }
        public string AreaCodigo { get; set; }
        public string AreaNombre { get; set; }
        public int AreaEstado { get; set; }
        public int AreaIdGerenciaGeneral { get; set; }

        public DataTable SeleccionarTodosLosRegistrosArea(TipoConexion tipoCon)
        { 
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosArea", true);
        }

        public string SeleccionarTipoAreaRegistrosRh(TipoConexion tipoCon, string area)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select ID_GERENCIAS_GENERAL from AREA_GENERAL where NOMBRE_AREA = '" + area + "'", false);
            return data == null || data.Rows.Count == 0 ? "2" : data.Rows[0][0].ToString();
        }

        public DataTable SeleccionarTodosLosRegistrosAreaRh(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosAreaRh", true);
        }

        public string BuscarNombreAreaGeneralPorIdAreaGeneral(TipoConexion tipoCon,  string id)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_AREA_GENERAL", SqlDbType.Int, id } 
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNombreAreaGeneralPorIdAreaGeneral", true, pars);
            return data.Rows.Count == 0 ? string.Empty : data.Rows[0]["NOMBRE_AREA"].ToString();
        }

        public int BuscarIdAreaGeneralPorNombreAreaGeneral(TipoConexion tipoCon, string nombreArea)
        {
            var pars = new List<object[]>
            {
                new object[] { "NOMBRE_AREA", SqlDbType.VarChar, nombreArea } 
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdAreaGeneralPorNombreAreaGeneral", true, pars);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public int BuscarMayorIdArea(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdArea", true) ;
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public string GenerarCodigoSiguienteAreaPorIdGerencias(TipoConexion tipoCon, int idg)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_GERENCIAS_GENERAL", SqlDbType.Int, idg }  
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "generarCodigoSiguienteAreaPorIdGerencias", true, pars) ;
            return data.Rows.Count == 0 ? string.Empty : data.Rows[0]["CODIGO"].ToString();
        }

        public SqlCommand NuevaAreas()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "nuevaAreas"
            };
            cmd.Parameters.AddWithValue("@ID_AREA_GENERAL", SqlDbType.Int).Value = AreaId;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = AreaCodigo;
            cmd.Parameters.AddWithValue("@NOMBRE_AREA", SqlDbType.NVarChar).Value = AreaNombre;
            cmd.Parameters.AddWithValue("@ESTADO_AREA", SqlDbType.Int).Value = AreaEstado;
            cmd.Parameters.AddWithValue("@ID_GERENCIAS_GENERAL", SqlDbType.Int).Value = AreaIdGerenciaGeneral;
            return cmd;
        }

        public SqlCommand ModificarAreas()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "modificarAreas"
            };
            cmd.Parameters.AddWithValue("@ID_AREA_GENERAL", SqlDbType.Int).Value = AreaId;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = AreaCodigo;
            cmd.Parameters.AddWithValue("@NOMBRE_AREA", SqlDbType.NVarChar).Value = AreaNombre;
            cmd.Parameters.AddWithValue("@ESTADO_AREA", SqlDbType.Int).Value = AreaEstado;
            cmd.Parameters.AddWithValue("@ID_GERENCIAS_GENERAL", SqlDbType.Int).Value = AreaIdGerenciaGeneral;
            return cmd;
        } 
    }
}
