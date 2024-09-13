using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;


namespace ClassLibraryCisepro3.Invetarios
{
    public class ClassSecuencialItem
    {

        

        public DataTable buscarNombresSecuencial(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarNombreSecuencialItem", true);
        }

        public AutoCompleteStringCollection AutoCompletarSecuencial(TipoConexion tipoCon)
        {
            DataTable dt = buscarNombresSecuencial(tipoCon);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(row["NOMBRE_SECUENCIAL_ITEM"].ToString());
            }
            return coleccion;
        }

        public DataTable SeleccionarSecuencialItemsXNombre(TipoConexion tipoCon, string filtro)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "FILTRO", SqlDbType.NVarChar, filtro });

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon,"SELECT * FROM SECUENCIAL_ITEM  WHERE NOMBRE_SECUENCIAL_ITEM = @FILTRO;",false, pars);
        }



    }
}
