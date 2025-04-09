using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace ClassLibraryCisepro.ACTIVOS_FIJOS.DEPRECIACIONES
{
    public class ClassDepreciaciones
    {
        /// <summary>
        /// ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        /// SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        /// CON EL MISMO TIPO DE DATO
        /// TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        public int Id;
        public int IdActivoFijo;
        public decimal Porcentaje;
        public string CuentaContable;
        public int Tope;
        public int Estado;

        public SqlCommand NuevaDepreciacionGeneral()
        {
            var comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "nuevaDepreciacionGeneral";
            comando.Parameters.AddWithValue("@ID_DEPRECIACION", SqlDbType.Int).Value = Id;
            comando.Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = IdActivoFijo;
            comando.Parameters.AddWithValue("@PORCENTAJE", SqlDbType.Decimal).Value = Porcentaje;
            comando.Parameters.AddWithValue("@CUENTA_CONTABLE", SqlDbType.NVarChar).Value = CuentaContable;
            comando.Parameters.AddWithValue("@TOPE_DEPRECIACIONES", SqlDbType.Int).Value = Tope;
            comando.Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado;
            return comando;
        }

        public int BuscarMayorIdDepreciacion(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            var data = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDepreciacion", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] is DBNull ? 0 : Conversions.ToInteger(data.Rows[0][0]);
        }

        // Public Function BuscarActivoFijoPorIdActivoEnDepreciacionGeneral(ByVal tipoCon As TipoConexion, ByVal ida As Integer) As DataTable
        // Dim pars = New List(Of Object())
        // pars.Add(New Object() {"ID_ACTIVO_FIJO", SqlDbType.BigInt, ida})
        // Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarActivoFijoPorIdActivoEnDepreciacionGeneral", True, pars)
        // End Function

        public DataTable BuscarActivoFijoPorIdActivoEnDepreciacionGeneral(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, string filtro, DateTime Desde, DateTime Hasta)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "filtro", SqlDbType.VarChar, filtro });
            pars.Add(new object[] { "desde", SqlDbType.DateTime, Desde });
            pars.Add(new object[] { "hasta", SqlDbType.DateTime, Hasta });
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_SeleccionDepreciacionGeneralxFiltro", true, pars);
        }


        public DataSet BuscarDepreciacionPorIdActivo(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, int idActivo)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "ID_ACTIVO_FIJO", SqlDbType.BigInt, idActivo });
            var depr = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "buscarDepreciacionPorIdActivo", true, pars);
            var dede = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_DEPRECIACION WHERE ESTADO=1", false);
            var acfi = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ACTIVO_FIJO_GENERAL WHERE ESTADO=1", false);

            var ds = new DataSet();
            depr.Fill(ds, "DEPRECIACIONES_GENERAL");
            dede.Fill(ds, "DETALLE_DEPRECIACION");
            acfi.Fill(ds, "ACTIVO_FIJO_GENERAL");
            return ds;
        }

        public DataTable SeleccionarTodasLosRegistrosDepreciaciones(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryToDataTable(tipoCon, "seleccionarTodasLosRegistrosDepreciaciones", true);
        }
    }
}