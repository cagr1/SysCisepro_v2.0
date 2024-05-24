using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.EstructuraEmpresa
{
    public class ClassSubSeccion
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int SubSeccionId { get; set; }
        public string SubSeccionCodigo { get; set; }
        public string SubSeccionNombre { get; set; }
        public int SubSeccionEstado { get; set; }
        public int SubSeccionidSeccion { get; set; }

        public DataTable SeleccionarTodosLosRegistrosSubSeccion(TipoConexion tipoCon)
        {
            return   ComandosSql.SeleccionarQueryToDataTable(tipoCon,"SeleccionarTodosLosRegistrosSubSeccion", true) ;
        }
        public int BuscarMayorIdSubSeccion(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdSubSeccion", true)  ;
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public string GenerarCodigoSiguienteSubSeccionPorIdSubSeccion(TipoConexion tipoCon, int ida)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_SECCION", SqlDbType.Int, ida }  
            };
            var data =   ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "generarCodigoSiguienteSubSeccionPorIdSubSeccion", true, pars) ;
            return data.Rows.Count == 0 ? string.Empty : data.Rows[0]["CODIGO"].ToString();
        }

        public SqlCommand NuevaSubSeccion()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "nuevaSubSeccion"
            };
            cmd.Parameters.AddWithValue("@ID_SUB_SECCION", SqlDbType.Int).Value = SubSeccionId;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = SubSeccionCodigo;
            cmd.Parameters.AddWithValue("@NOMBRE_SUB_SECCION", SqlDbType.NVarChar).Value = SubSeccionNombre;
            cmd.Parameters.AddWithValue("@ESTADO_SUB_SECCION", SqlDbType.Int).Value = SubSeccionEstado;
            cmd.Parameters.AddWithValue("@ID_SECCION", SqlDbType.Int).Value = SubSeccionidSeccion;
            return cmd;
        }

        public SqlCommand ModificarSubSeccion()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "modificarSubSeccion"
            };
            cmd.Parameters.AddWithValue("@ID_SUB_SECCION", SqlDbType.Int).Value = SubSeccionId;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = SubSeccionCodigo;
            cmd.Parameters.AddWithValue("@NOMBRE_SUB_SECCION", SqlDbType.NVarChar).Value = SubSeccionNombre;
            cmd.Parameters.AddWithValue("@ESTADO_SUB_SECCION", SqlDbType.Int).Value = SubSeccionEstado;
            cmd.Parameters.AddWithValue("@ID_SECCION", SqlDbType.Int).Value = SubSeccionidSeccion;
            return cmd;
        } 
    }
}
