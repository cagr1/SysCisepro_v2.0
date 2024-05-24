using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassSecuencialContratos
    { 
        public int BuscarMayorSecuencialXAnio(TipoConexion tipoCon, int year)
        {
            var pars = new List<object[]>
            {
                new object[] { "anio", SqlDbType.Int, year } 
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select digit from SECUENCIALES_CONTRATOS where anio = @anio;", false, pars) ;
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public SqlCommand ActualizarSecuencialContrato(int anio)
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update SECUENCIALES_CONTRATOS set digit = digit + 1 where anio = " + anio + ";"
            };
            return cmd;
        }
    }
}
