using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.DivisionGeografica
{
    public class ClassParroquias
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdParroquiaParroquias { get; set; }
        public string NombreParroquiaParroquias { get; set; }
        public int EstadoParroquias { get; set; }
        public int IdCiudadParroquias { get; set; }

        public int BuscarMayorIdParroquias(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon,"BuscarMayorIdParroquias", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable BuscarNombreParroquiaXIdCiudades(TipoConexion tipoCon, string idc)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_CIUDAD", SqlDbType.Int, idc } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarNombreParroquiaXIdCiudades", true, pars);
        }

        public SqlCommand NuevoParroquia()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "NuevoParroquia"
            };
            cmd.Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquiaParroquias;
            cmd.Parameters.AddWithValue("@NOMBRE_PARROQUIAS", SqlDbType.NVarChar).Value = NombreParroquiaParroquias;
            cmd.Parameters.AddWithValue("@ESTADO_PARROQUIAS", SqlDbType.Int).Value = EstadoParroquias;
            cmd.Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudadParroquias;
            return cmd;
        }

        public SqlCommand ActualizarParroquia()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update PARROQUIAS set NOMBRE_PARROQUIAS = @NOMBRE_PARROQUIAS where ID_PARROQUIAS=@ID_PARROQUIAS;"
            };
            cmd.Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquiaParroquias;
            cmd.Parameters.AddWithValue("@NOMBRE_PARROQUIAS", SqlDbType.NVarChar).Value = NombreParroquiaParroquias;
            return cmd;
        }
    }
}
