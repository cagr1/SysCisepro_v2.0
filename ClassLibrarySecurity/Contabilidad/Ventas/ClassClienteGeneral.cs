using System;
using System.Collections.Generic;
using System.Data;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.Contabilidad.Ventas
{
    public class ClassClienteGeneral
    {
        public DataTable BuscarClientesSinFacturarXRangoFecha(TipoConexion tipoCon, DateTime fini, DateTime ffin, DateTime finia, DateTime ffina)
        {
            var pars = new List<object[]>
            {
                new object[] { "FECHA_INICIAL", SqlDbType.DateTime, fini },
                new object[] { "FECHA_FINAL", SqlDbType.DateTime, ffin },
                new object[] { "FECHA_INICIAL_ANTE", SqlDbType.DateTime, finia },
                new object[] { "FECHA_FINAL_ANTE", SqlDbType.DateTime, ffina }
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon,"BuscarClientesSinFacturarXRangoFecha", true, pars); 
        }
    }
}
