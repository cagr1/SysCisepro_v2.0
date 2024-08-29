using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;



namespace ClassLibraryCisepro3.TalentoHumano
{
  
    public class ClassRolesFirmados
    {
        public int idrol { get; set; }
        public int idpersonal { get; set; }
        public int mes { get; set; }
        public int anio { get; set; }
        public DateTime fecha { get; set; }
        public int estado { get; set; }

        public int BuscarMayorId(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_buscarMayorIdRolFirmado", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);

        }

        public DataTable BuscarPersonalFiltro(TipoConexion tipoCon, string fil)
        {
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, string.Concat("%", fil, "%") }
            };

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_BuscarPersonalRolFirmado", true, pars);
        }

        public SqlCommand RegistrarNuevoRolFirmadoCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sp_nuevoRolFirmado"
            };
            
            cmd.Parameters.AddWithValue("@idrol", SqlDbType.Int).Value = idrol;
            cmd.Parameters.AddWithValue("@idpersonal", SqlDbType.Int).Value = idpersonal;
            cmd.Parameters.AddWithValue("@mes", SqlDbType.Int).Value = mes;
            cmd.Parameters.AddWithValue("@anio", SqlDbType.Int).Value = anio;
            cmd.Parameters.AddWithValue("@fecha", SqlDbType.DateTime).Value = fecha;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = estado;
            return cmd;
        }

        public DataTable BuscarPersonalFirmadoFiltro(TipoConexion tipoCon, string fil, int anio)
        {
            var pars = new List<object[]>
            {
                new object[] { "filtro", SqlDbType.NVarChar, fil },
                new object[] { "year", SqlDbType.Int, anio }
            };

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_buscarPersonalRolesFirmados", true, pars);
        }

        public DataTable buscarFirmaRepetida(TipoConexion tipoCon, int code, int mes, int anio)
        {
            var pars = new List<object[]>
            {
                new object[] { "@code", SqlDbType.Int, code },
                new object[] { "@fecha", SqlDbType.Int, mes },
                new object[] { "@anio", SqlDbType.Int, anio }
            };

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_buscarPersonalFirmadoRepetido", true, pars);
        }   
    }
}
