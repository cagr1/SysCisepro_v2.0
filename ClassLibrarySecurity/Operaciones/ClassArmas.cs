using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using System.Security.Cryptography;
using System.Security.Policy;


namespace ClassLibraryCisepro3.Operaciones
{
    public class ClassArmas
    {

        public DataTable buscar(TipoConexion tipoCon, string filtro, DateTime desde, DateTime hasta)
        {
            
            var pars = new List<object[]>
            {
            
                new object[] { "FILTRO", SqlDbType.VarChar, filtro }
                , new object[] { "DESDE", SqlDbType.DateTime, desde }
                , new object[] { "HASTA", SqlDbType.DateTime, hasta }
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon,"sp_buscarArmas", true, pars);
        }


    }
}
