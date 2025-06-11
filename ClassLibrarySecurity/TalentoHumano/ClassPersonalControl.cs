using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using syscisepro;


namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassPersonalControl
    {
        public TipoConexion TipoCon { get; set; }

        public int idControl { get; set; }
        public DateTime FechaPrueba { get; set; }
        public int IdPersonal { get; set; }
        public int Idresponsable { get; set; }
        public string Nombres { get; set; }
        public string Cargo { get; set; }
        public string Area { get; set; }
        public string Observaciones { get; set; }

        public int BuscarMayorId(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_buscarMayorIdControlAntidroga", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public SqlCommand RegistrarNuevoPersonalAntidrogaCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "NuevoPersonalControl"
            };
            cmd.Parameters.AddWithValue("@ID_CONTROL", SqlDbType.Int).Value = idControl;
            cmd.Parameters.AddWithValue("@FECHA_PRUEBA", SqlDbType.DateTime).Value = FechaPrueba;
            cmd.Parameters.AddWithValue("@OBSERVACIONES", SqlDbType.VarChar).Value = Observaciones;
            cmd.Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonal;
            cmd.Parameters.AddWithValue("@ID_RESPONSABLE", SqlDbType.Int).Value = Idresponsable;
            cmd.Parameters.AddWithValue("@NOMBRES", SqlDbType.VarChar).Value = Nombres;
            cmd.Parameters.AddWithValue("@AREA", SqlDbType.VarChar).Value = Area;
            cmd.Parameters.AddWithValue("@CARGO", SqlDbType.VarChar).Value = Cargo;
            
            
            
            return cmd;
        }

    }
}
