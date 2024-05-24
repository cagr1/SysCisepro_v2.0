Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ACTIVOS_FIJOS.DEPRECIACIONES
    Public Class ClassDepreciaciones
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Integer
        Public IdActivoFijo As Integer
        Public Porcentaje As Decimal
        Public CuentaContable As String
        Public Tope As Integer
        Public Estado As Integer

        Public Function NuevaDepreciacionGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaDepreciacionGeneral"
                .Parameters.AddWithValue("@ID_DEPRECIACION", SqlDbType.Int).Value = Id
                .Parameters.AddWithValue("@ID_ACTIVO_FIJO", SqlDbType.Int).Value = IdActivoFijo
                .Parameters.AddWithValue("@PORCENTAJE", SqlDbType.Decimal).Value = Porcentaje
                .Parameters.AddWithValue("@CUENTA_CONTABLE", SqlDbType.NVarChar).Value = CuentaContable
                .Parameters.AddWithValue("@TOPE_DEPRECIACIONES", SqlDbType.Int).Value = Tope
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function

        Public Function BuscarMayorIdDepreciacion(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDepreciacion", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        'Public Function BuscarActivoFijoPorIdActivoEnDepreciacionGeneral(ByVal tipoCon As TipoConexion, ByVal ida As Integer) As DataTable
        '    Dim pars = New List(Of Object())
        '    pars.Add(New Object() {"ID_ACTIVO_FIJO", SqlDbType.BigInt, ida})
        '    Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarActivoFijoPorIdActivoEnDepreciacionGeneral", True, pars)
        'End Function

        Public Function BuscarActivoFijoPorIdActivoEnDepreciacionGeneral(ByVal tipoCon As TipoConexion, ByVal filtro As String, ByVal Desde As DateTime, ByVal Hasta As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"filtro", SqlDbType.VarChar, filtro})
            pars.Add(New Object() {"desde", SqlDbType.DateTime, Desde})
            pars.Add(New Object() {"hasta", SqlDbType.DateTime, Hasta})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_SeleccionDepreciacionGeneralxFiltro", True, pars)
        End Function


        Public Function BuscarDepreciacionPorIdActivo(ByVal tipoCon As TipoConexion, ByVal idActivo As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_ACTIVO_FIJO", SqlDbType.BigInt, idActivo})
            Dim depr = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "buscarDepreciacionPorIdActivo", True, pars)
            Dim dede = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_DEPRECIACION WHERE ESTADO=1", False)
            Dim acfi = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ACTIVO_FIJO_GENERAL WHERE ESTADO=1", False)

            Dim ds = New DataSet()
            depr.Fill(ds, "DEPRECIACIONES_GENERAL")
            dede.Fill(ds, "DETALLE_DEPRECIACION")
            acfi.Fill(ds, "ACTIVO_FIJO_GENERAL")
            Return ds
        End Function

        Public Function SeleccionarTodasLosRegistrosDepreciaciones(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "seleccionarTodasLosRegistrosDepreciaciones", True)
        End Function
    End Class
End Namespace