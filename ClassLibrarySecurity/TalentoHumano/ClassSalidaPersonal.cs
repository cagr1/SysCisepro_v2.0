using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassSalidaPersonal
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/


        public int IdSalida { get; set; }
        public int IdPersonal { get; set; }
        public int Certificado { get; set; }
        public int Uniformes { get; set; }
        public int Roles { get; set; }
        public int Credencial { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaSalida { get; set; }
        public int Estado { get; set; }

        public int BuscarMayorId(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_buscarMayorIdSalida", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable BuscarPersonalFiltro(TipoConexion tipoCon, string fil)
        {
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, string.Concat("%", fil, "%") } 
            };

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_BuscarPersonalSalida", true, pars);
        }

        public SqlCommand RegistrarNuevoPersonalSalida()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sp_RegistrarNuevoSalidaPersonal"
            };

            cmd.Parameters.AddWithValue("@ID_SALIDA", SqlDbType.Int).Value = IdSalida;
            cmd.Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal;
            cmd.Parameters.AddWithValue("@CERTIFICADO", SqlDbType.Int).Value = Certificado;
            cmd.Parameters.AddWithValue("@UNIFORMES", SqlDbType.NVarChar).Value = Uniformes;
            cmd.Parameters.AddWithValue("@ROLES", SqlDbType.NVarChar).Value = Roles;
            cmd.Parameters.AddWithValue("@CREDENCIAL", SqlDbType.NVarChar).Value = Credencial;
            cmd.Parameters.AddWithValue("@FECHA_SALIDA", SqlDbType.DateTime).Value = FechaSalida;
            cmd.Parameters.AddWithValue("@OBSERVACIONES", SqlDbType.NVarChar).Value = Observaciones;
            cmd.Parameters.AddWithValue("@ESTADO", SqlDbType.NVarChar).Value = Estado;

            return cmd;
        }



        public SqlCommand ModificarPersonalSalida()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sp_ModificarSalidaPersonal"
            };
            
            
            cmd.Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal;
            cmd.Parameters.AddWithValue("@CERTIFICADO", SqlDbType.Int).Value = Certificado;
            cmd.Parameters.AddWithValue("@UNIFORMES", SqlDbType.NVarChar).Value = Uniformes;
            cmd.Parameters.AddWithValue("@ROLES", SqlDbType.NVarChar).Value = Roles;
            cmd.Parameters.AddWithValue("@CREDENCIAL", SqlDbType.NVarChar).Value = Credencial;
            cmd.Parameters.AddWithValue("@FECHA_SALIDA", SqlDbType.DateTime).Value = FechaSalida;
            cmd.Parameters.AddWithValue("@OBSERVACIONES", SqlDbType.NVarChar).Value = Observaciones;
            cmd.Parameters.AddWithValue("@ESTADO", SqlDbType.NVarChar).Value = Estado;
            
            return cmd;
        }

        public int BuscarIdSalida(TipoConexion tipoCon, int id)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_PERSONAL", SqlDbType.Int, id } 
            };

            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_buscarIdPersonalSalida", true, pars);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable BuscarPersonalSalida(TipoConexion tipoCon, int id)
        {
            var pars = new List<object[]>
            {
                new object[] { "@id", SqlDbType.Int, id }
            };

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_BuscarPersonalSalidaReingreso", true, pars);
        }
    }
}
