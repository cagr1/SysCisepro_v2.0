using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.EstructuraEmpresa
{
    public class ClassCargo
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int CargoId { get; set; }
        public string CargoCodigo { get; set; }
        public string CargoDescripcion { get; set; }
        public int CargoEstado { get; set; }
        public int CargoIdSerie { get; set; }
        public decimal CargoSueldoBasico { get; set; }


        public int BuscarMayorIdCargoOcupacional(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon,"BuscarMayorIdCargoOcupacional", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public int BuscarIdGrupoPorIdSerie(TipoConexion tipoCon, int ids)
        {
            var pars = new List<object[]>
            {
                new object[] { "ids", SqlDbType.Int, ids } 
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select id_grupo_ocupacional from serie_ocupacional where id_serie_ocupacional = @ids", false, pars);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public int ContarMayorPorIdSerieOcupacional(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon,"contarMayorPorIdSerieOcupacional", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable SeleccionarTodosLosRegistrosCargos(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosCargos", true);
        } 
        public SqlCommand NuevaCargoOcupacional()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "nuevaCargoOcupacional"
            };
            cmd.Parameters.AddWithValue("@ID_CARGO_OCUPACIONAL", SqlDbType.Int).Value = CargoId;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.Int).Value = CargoCodigo;
            cmd.Parameters.AddWithValue("@DESCRIPCION", SqlDbType.NVarChar).Value = CargoDescripcion;
            cmd.Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = CargoEstado;
            cmd.Parameters.AddWithValue("@ID_SERIE_OCUPACIONAL", SqlDbType.Int).Value = CargoIdSerie;
            cmd.Parameters.AddWithValue("@SUELDO_BASICO", SqlDbType.Decimal).Value = CargoSueldoBasico;
            return cmd;
        }

        public SqlCommand ModificarCargoOcupacional()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "modificarCargoOcupacional"
            };
            cmd.Parameters.AddWithValue("@ID_CARGO_OCUPACIONAL", SqlDbType.Int).Value = CargoId;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.Int).Value = CargoCodigo;
            cmd.Parameters.AddWithValue("@DESCRIPCION", SqlDbType.NVarChar).Value = CargoDescripcion;
            cmd.Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = CargoEstado;
            cmd.Parameters.AddWithValue("@ID_SERIE_OCUPACIONAL", SqlDbType.Int).Value = CargoIdSerie;
            cmd.Parameters.AddWithValue("@SUELDO_BASICO", SqlDbType.Decimal).Value = CargoSueldoBasico;
            return cmd;
        }
    }
}
