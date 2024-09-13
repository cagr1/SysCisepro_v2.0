using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using System.Data.SqlClient;

namespace ClassLibraryCisepro3.Contabilidad.Compras.TablaComparativa
{
    public class ClassDetalleTablaComparativa
    {
        public int IdDetalleTablaComparativa { get; set; }
        public int IdSecuencial { get; set; }
        public int IdProveedor { get; set; }
        public int IdTablaComparativa { get; set; }
        public decimal Precio { get; set; }
        public int Credito { get; set; }
        public int Dias { get; set; }
        public int Estado { get; set; }

        public int BuscarMayorIdDetalleTablaComparativa(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_buscarMayorIdDetalleTablaComparativa", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public SqlCommand InsertarDetalleTablaComparativaCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sp_nuevoDetalleTablaComparativa"
            };

            cmd.Parameters.Add(new SqlParameter("@IDDETALLE", SqlDbType.Int)).Value = IdDetalleTablaComparativa;
            cmd.Parameters.Add(new SqlParameter("@IDSECUENCIAL", SqlDbType.Int)).Value = IdSecuencial;
            cmd.Parameters.Add(new SqlParameter("@IDPROVEEDOR", SqlDbType.Int)).Value = IdProveedor;
            cmd.Parameters.Add(new SqlParameter("@IDTABLA", SqlDbType.Int)).Value = IdTablaComparativa;
            cmd.Parameters.Add(new SqlParameter("@PRECIO", SqlDbType.Decimal)).Value = Precio;
            cmd.Parameters.Add(new SqlParameter("@CREDITO", SqlDbType.Int)).Value = Credito;
            cmd.Parameters.Add(new SqlParameter("@DIAS", SqlDbType.Int)).Value = Dias;
            cmd.Parameters.Add(new SqlParameter("@ESTADO", SqlDbType.Int)).Value = Estado;

            return cmd;
        }

    }
}
