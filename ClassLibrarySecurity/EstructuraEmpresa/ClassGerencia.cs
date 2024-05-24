using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.EstructuraEmpresa
{
    public class ClassGerencia
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdGerencia { get; set; }
        public string CodigoGerencia { get; set; }
        public string DescripcionGerencia { get; set; }
        public int EstadoGerencia { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }

        public DataTable SeleccionarTodosLosRegistrosGerencia(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon,"SeleccionarTodosLosRegistrosGerencia", true);
        }

        public int BuscarMayorIdGerencia(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon,"BuscarMayorIdGerencia", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public int ContarMayorGerenciaPorIdEmpresa(TipoConexion tipoCon, int ide, int ids)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_EMPRESA", SqlDbType.Int, ide },
                new object[] { "ID_SUCURSAL", SqlDbType.Int, ids } 
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon,"contarMayorGerenciaPorIdEmpresa", true, pars);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public SqlCommand NuevaGerencia()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "nuevaGerencia"
            };
            cmd.Parameters.AddWithValue("@ID_GERENCIA", SqlDbType.Int).Value = IdGerencia;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = CodigoGerencia;
            cmd.Parameters.AddWithValue("@DESCRIPCION", SqlDbType.NVarChar).Value = DescripcionGerencia;
            cmd.Parameters.AddWithValue("@ESTADO_GERENCIA", SqlDbType.Int).Value = EstadoGerencia;
            cmd.Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = IdEmpresa;
            cmd.Parameters.AddWithValue("@ID_SUCURSAL", SqlDbType.Int).Value = IdSucursal;
            return cmd;
        }

        public SqlCommand ModificarGerencia()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "modificarGerencia"
            };
            cmd.Parameters.AddWithValue("@ID_GERENCIA", SqlDbType.Int).Value = IdGerencia;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = CodigoGerencia;
            cmd.Parameters.AddWithValue("@DESCRIPCION", SqlDbType.NVarChar).Value = DescripcionGerencia;
            cmd.Parameters.AddWithValue("@ESTADO_GERENCIA", SqlDbType.Int).Value = EstadoGerencia;
            cmd.Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = IdEmpresa;
            cmd.Parameters.AddWithValue("@ID_SUCURSAL", SqlDbType.Int).Value = IdSucursal;
            return cmd;
        } 
    }
}
