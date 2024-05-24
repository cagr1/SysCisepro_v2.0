using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.Contabilidad.Compras.OrdenDeCompra
{
    public class ClassOrdenCompra
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/         
        public long IdOrdenCompraGeneral { get; set; } 
        public int EstadoOrdencompraGeneral { get; set; }

        public DataTable SeleccionarRegistrosOrdenCompra(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosOrdenCompra", true); 
        }

        public SqlCommand ActualizarEstadoOrdenCompra()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "actualizarEstadoOrdenCompra"
            };
            cmd.Parameters.AddWithValue("@ID_ORDEN_COMPRA", SqlDbType.BigInt).Value = IdOrdenCompraGeneral;
            cmd.Parameters.AddWithValue("@ESTADO_ORDEN_COMPRA", SqlDbType.Int).Value = EstadoOrdencompraGeneral;
            return cmd;
        }
    }
}
