using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace ClassLibraryCisepro.ACTIVOS_FIJOS.DEPRECIACIONES
{
    public class ClassDetalleDepreciaciones
    {
        /// <summary>
        /// ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        /// SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        /// CON EL MISMO TIPO DE DATO
        /// TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        public int IdDetalle;
        public DateTime Fecha;
        public int NumeroDepreciacion;
        public decimal ValorDepreciacion;
        public decimal ValorResidualDepreciacion;
        public int Estado;
        public int IdDetalleGeneral;




        public int BuscarMayorIdDetalleDepreciacion(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            var data = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetalleDepreciacion", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] is DBNull ? 0 : Conversions.ToInteger(data.Rows[0][0]);
        }

        // Public Function BuscarMayorIdDetalleDepreciacion(ByVal tipoCon As TipoConexion) As Integer
        // Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT ID_DEPRECIACION = MAX(ID_DEPRECIACION) FROM DETALLE_DEPRECIACION", False)
        // Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("ID_DEPRECIACION")))
        // End Function

        public int BuscarIdDetalleDepreciacionRepetido(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, int id)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "iddepre", SqlDbType.Int, id });
            var data = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_BuscarIdDetalleDepreciacionRepetido", true, pars);
            return Conversions.ToInteger(data.Rows.Count == 0 ? 0 : data.Rows[0][0] is DBNull ? string.Empty : Conversions.ToString(data.Rows[0][0]));
        }

        public SqlCommand NuevaDetalleDepreciacion()
        {
            var comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "nuevaDetalleDepreciacion";
            comando.Parameters.AddWithValue("@ID_DEPRECIACION", SqlDbType.Int).Value = IdDetalle;
            comando.Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha;
            comando.Parameters.AddWithValue("@NUM_DEPRECIACION", SqlDbType.Decimal).Value = NumeroDepreciacion;
            comando.Parameters.AddWithValue("@VALOR_DEPRECIACION", SqlDbType.Decimal).Value = ValorDepreciacion;
            comando.Parameters.AddWithValue("@VALOR_RESIDUAL_DEPRECIACION", SqlDbType.Decimal).Value = ValorResidualDepreciacion;
            comando.Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado;
            comando.Parameters.AddWithValue("@ID_DEPRECIACION_GENERAL", SqlDbType.Int).Value = IdDetalleGeneral;
            return comando;
        }

        public DataTable SeleccionarDetallesDepreciacionPorIdDepreciacion(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, List<string> ids)
        {

            string lids = ids.Aggregate("(", (current, id) => current + id + ",");
            lids = lids.EndsWith(",") ? lids.Substring(0, lids.Length - 1) + ")" : lids + ")";

            // Dim pars = New List(Of Object())
            // pars.Add(New Object() {"ID_DEPRECIACION", SqlDbType.VarChar, id})
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM dbo.DETALLE_DEPRECIACION WHERE ESTADO=1 and ID_DEPRECIACION_GENERAL IN " + lids + " ORDER BY ID_DEPRECIACION_GENERAL", false);
            // Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarDetallesDepreciacionPorIdDepreciacion", True, pars)
        }

    }
}