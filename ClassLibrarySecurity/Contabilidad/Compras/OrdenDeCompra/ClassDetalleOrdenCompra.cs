using System.Collections.Generic;
using System.Data;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.Contabilidad.Compras.OrdenDeCompra
{    
    public class ClassDetalleOrdenCompra
    {
        public DataTable SeleccionarDetalleOrdenCompraXIdOrdenCompra(TipoConexion tipoCon, int idoc)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_ORDEN_COMPRA", SqlDbType.BigInt, idoc } 
            };
            return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarDetalleOrdenCompraXIdOrdenCompra",true, pars);
        }
    }
}
