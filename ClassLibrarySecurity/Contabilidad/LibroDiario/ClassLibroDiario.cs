using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.Contabilidad.LibroDiario
{
    public class ClassLibroDiario
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdLibroDiarioGeneral { get; set; }
        public DateTime FechaLibroDiarioGeneral { get; set; }
        public decimal TotalDebeLibrodiarioGeneral { get; set; }
        public decimal TotalHaberLibroDiarioGeneral { get; set; }
        public int EstadoLibroDiarioGeneral { get; set; }

        public int BuscarMayorIdLibroDiario(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdLibroDiario", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable SeleccionarRegistrosCodigoCuentaCambiadaLibroDiario(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select * from ASIENTOS_LIBRO_DIARIO where FECHA_ASIENTO > '2018-01-01 00:00:00' and ESTADO_ASIENTO = 1 and CODIGO_CUENTA_ASIENTO like '%[A-Z]%';", false);
        } 

        public DateTime BuscarFechaLibroDiarioXIdLibroDiario(TipoConexion tipoCon, int idl)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_LIBRO_DIARIO", SqlDbType.BigInt, idl } 
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarFechaLibroDiarioXIdLibroDiario", true, pars);
            return data.Rows.Count == 0 ? DateTime.MinValue : data.Rows[0][0] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(data.Rows[0]["FECHA_LIBRO_DIARIO"]);
        }

        public SqlCommand NuevoRegistroLibroDiario()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "NuevoRegistroLibroDiario"
            };
            cmd.Parameters.AddWithValue("@ID_LIBRO_DIARIO", SqlDbType.BigInt).Value = IdLibroDiarioGeneral;
            cmd.Parameters.AddWithValue("@FECHA_LIBRO_DIARIO", SqlDbType.DateTime).Value = FechaLibroDiarioGeneral;
            cmd.Parameters.AddWithValue("@TOTAL_DEBE_LIBRO_DIARIO", SqlDbType.Decimal).Value =
                TotalDebeLibrodiarioGeneral;
            cmd.Parameters.AddWithValue("@TOTAL_HABER_LIBRO_DIARIO", SqlDbType.Decimal).Value =
                TotalHaberLibroDiarioGeneral;
                    cmd.Parameters.AddWithValue("@ESTADO_LIBRO_DIARIO", SqlDbType.Int).Value = EstadoLibroDiarioGeneral;
            return cmd;
        }
    }
}
