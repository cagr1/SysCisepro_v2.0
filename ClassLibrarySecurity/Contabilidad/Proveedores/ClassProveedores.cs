using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
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

        public DataTable buscarNombresProveedorGeneral(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarNombresProveedorGeneral", true);
        }

        public AutoCompleteStringCollection AutoCompletarProveedor(TipoConexion tipoCon)
        {
            DataTable dt = buscarNombresProveedorGeneral(tipoCon);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(row["RAZON_SOCIAL_PROVEEDOR_GENERAL"].ToString());
            }
            return coleccion;
        }

        public DataTable SeleccionarProveedorGeneralXNombre(TipoConexion tipoCon, string filtro)
        {
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.NVarChar, filtro }
            };

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM PROVEEDOR_GENERAL WHERE RAZON_SOCIAL_PROVEEDOR_GENERAL = @FILTRO;", false, pars);
        }
    }
}
