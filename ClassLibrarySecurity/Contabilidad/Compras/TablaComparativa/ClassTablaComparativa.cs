using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using System.Data.SqlClient;

namespace ClassLibraryCisepro3.Contabilidad.Compras.TablaComparativa
{
    public class ClassTablaComparativa
    {
        public int IdTablaComparativa { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha { get; set; }
        public int estado { get; set; }

        public int BuscarMayorIdTablaComparativa(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_buscarMayorIdTablaComparativa", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public SqlCommand InsertarTablaComparativaCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sp_nuevaTablaComparativa"
            };

            cmd.Parameters.Add(new SqlParameter("@IDTABLA", SqlDbType.Int)).Value = IdTablaComparativa;
            cmd.Parameters.Add(new SqlParameter("OBSERVACION", SqlDbType.NVarChar)).Value = Observacion;
            cmd.Parameters.Add(new SqlParameter("FECHA", SqlDbType.DateTime)).Value = Fecha;
            cmd.Parameters.Add(new SqlParameter("ESTADO", SqlDbType.Int)).Value = estado;

            return cmd;
        }

    }
}
