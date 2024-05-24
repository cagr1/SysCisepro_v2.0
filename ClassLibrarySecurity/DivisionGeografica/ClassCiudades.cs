using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.DivisionGeografica
{
    public class ClassCiudades
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdCiudadCiudades { get; set; }
        public string NombreCiudadesCiudades { get; set; }
        public int IdProvinciaCiudades { get; set; }
        public int EstadoCiudades { get; set; }


        public int BuscarMayorIdCiudades(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon,"buscarMayorIdCiudades", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable BuscarNombreCiudadesXIdProvincia(TipoConexion tipoCon, string idp)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_PROVINCIAS", SqlDbType.Int, idp } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon,"BuscarNombreCiudadesXIdProvincia", true, pars);
        } 

        public SqlCommand NuevoCiudad()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "NuevoCiudad"
            };
            cmd.Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudadCiudades;
            cmd.Parameters.AddWithValue("@NOMBRE_CIUDADES", SqlDbType.NVarChar).Value = NombreCiudadesCiudades;
            cmd.Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvinciaCiudades;
            cmd.Parameters.AddWithValue("@ESTADO_CIUDADES", SqlDbType.Int).Value = EstadoCiudades;
            return cmd;
        }

        public SqlCommand ActualziarCiudad()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update CIUDADES set NOMBRE_CIUDADES = @NOMBRE_CIUDADES where ID_CIUDAD=@ID_CIUDAD;"
            };
            cmd.Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudadCiudades;
            cmd.Parameters.AddWithValue("@NOMBRE_CIUDADES", SqlDbType.NVarChar).Value = NombreCiudadesCiudades;
            return cmd;
        }
    }
}
