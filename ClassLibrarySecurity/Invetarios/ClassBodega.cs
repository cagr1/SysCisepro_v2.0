using System;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.Invetarios
{
    public class ClassBodega
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public long IdBodega { get; set; }
        public string NombreBodega { get; set; }
        public string TelefonoBodega { get; set; }
        public string Observaci { get; set; } 
        public DateTime FechaBodega { get; set; }
        public int IdPersonalBodega { get; set; }
        public int IdSitioBodega { get; set; }
        public int EstadoBodega { get; set; }

        public long BuscarMayorIdBodega(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdBodega", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable SeleccionarBodegasActivas(TipoConexion tipoCon)
        {
            return  ComandosSql.SeleccionarQueryToDataTable(tipoCon,"SeleccionarBodegasActivas", true);
        }

        public SqlCommand NuevaBodega()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "nuevaBodega"
            };
            cmd.Parameters.AddWithValue("@ID_BODEGA", SqlDbType.BigInt).Value = IdBodega;
            cmd.Parameters.AddWithValue("@NOMBRE_BODEGA", SqlDbType.NVarChar).Value = NombreBodega;
            cmd.Parameters.AddWithValue("@TELEFONO_BODEGA", SqlDbType.NVarChar).Value = TelefonoBodega;
            cmd.Parameters.AddWithValue("@OBSERVACION_BODEGA", SqlDbType.NVarChar).Value = Observaci;
            cmd.Parameters.AddWithValue("@FECHA_CREACION_BODEGA", SqlDbType.DateTime).Value = FechaBodega;
            cmd.Parameters.AddWithValue("@ID_PERSONAL_BODEGA", SqlDbType.Int).Value = IdPersonalBodega;
            cmd.Parameters.AddWithValue("@ID_SITIO_TRABAJO_BODEGA", SqlDbType.Int).Value = IdSitioBodega;
            cmd.Parameters.AddWithValue("@ESTADO_BODEGA", SqlDbType.Int).Value = EstadoBodega;
            return cmd;
        }

        public SqlCommand ModificarBodegas()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "modificarBodegas"
            };
            cmd.Parameters.AddWithValue("@ID_BODEGA", SqlDbType.BigInt).Value = IdBodega;
            cmd.Parameters.AddWithValue("@NOMBRE_BODEGA", SqlDbType.NVarChar).Value = NombreBodega;
            cmd.Parameters.AddWithValue("@TELEFONO_BODEGA", SqlDbType.NVarChar).Value = TelefonoBodega;
            cmd.Parameters.AddWithValue("@OBSERVACION_BODEGA", SqlDbType.NVarChar).Value = Observaci;
            cmd.Parameters.AddWithValue("@FECHA_CREACION_BODEGA", SqlDbType.DateTime).Value = FechaBodega;
            cmd.Parameters.AddWithValue("@ID_PERSONAL_BODEGA", SqlDbType.Int).Value = IdPersonalBodega;
            cmd.Parameters.AddWithValue("@ID_SITIO_TRABAJO_BODEGA", SqlDbType.Int).Value = IdSitioBodega;
            cmd.Parameters.AddWithValue("@ESTADO_BODEGA", SqlDbType.Int).Value = EstadoBodega;
            return cmd;
        } 
    }
}
