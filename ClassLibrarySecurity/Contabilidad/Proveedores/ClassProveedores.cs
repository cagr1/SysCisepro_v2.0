using System.Collections.Generic;
using System.Data;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.Contabilidad.Proveedores
{
    public class ClassProveedores
    {
        public DataTable SeleccionarProveedores(TipoConexion tipoCon, string fil)
        {
            var pars = new List<object[]>
            {
                new object[] { "FIL", SqlDbType.VarChar,  string.Concat("%", fil, "%") } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon,"select * from proveedor_general where ESTADO_PROVEEDOR_GENERAL = 1 and (ruc_ci_proveedor_general LIKE @FIL or RAZON_SOCIAL_PROVEEDOR_GENERAL LIKE @FIL or nombre_comercial_proveedor_general LIKE @FIL);", false, pars);
        }
    }
}
