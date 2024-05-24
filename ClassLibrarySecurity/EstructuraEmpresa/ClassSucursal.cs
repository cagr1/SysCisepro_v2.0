using System.Data;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.EstructuraEmpresa
{
    public class ClassSucursal
    {
        public DataTable SeleccionarTodosLosRegistrosSucursal(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon,"seleccionarTodosLosRegistrosSucursal", true);
        }  
    }
}
