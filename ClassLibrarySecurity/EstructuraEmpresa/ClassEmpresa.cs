using System.Data;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.EstructuraEmpresa
{ 
    public class ClassEmpresa
    {
        public DataTable SeleccionarTodosLosRegistrosEmpresa(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "seleccionarTodosLosRegistrosEmpresa", true);
        } 
    }
}
