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
    }
}
