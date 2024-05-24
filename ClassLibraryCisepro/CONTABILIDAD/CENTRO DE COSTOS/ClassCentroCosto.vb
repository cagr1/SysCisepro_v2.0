Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.CENTRO_DE_COSTOS
    Public Class ClassCentroCosto
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdCentroC As Integer
        Public DetalleCentroC As String
        Public CodigoCentroC As String
        Public EstadoCentroC As Integer

        Public Function SeleccionarCentroCosto(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select * from CENTRO_COSTO where ESTADO_CENTRO_COSTO=1;", False)
        End Function

        Public Function SeleccionarOrdenadosCentroCosto(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarOrdenadosCentroCosto", True)
        End Function

        Public Function BuscarMayorIdCentroCosto(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdCentroCosto", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarDetalleCentroCostoXIdCentroCosto(ByVal tipoCon As TipoConexion, ByVal idCentroCosto As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CENTRO_COSTO", SqlDbType.Int, idCentroCosto})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarDetalleCentroCostoXIdCentroCosto", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroCentroCosto(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroCentroCosto"
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentroC
                .Parameters.AddWithValue("@DETALLE_CENTRO_COSTO", SqlDbType.NVarChar).Value = DetalleCentroC
                .Parameters.AddWithValue("@CODIGO_CENTRO_COSTO", SqlDbType.NVarChar).Value = CodigoCentroC
                .Parameters.AddWithValue("@ESTADO_CENTRO_COSTO", SqlDbType.Int).Value = EstadoCentroC

            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ModificarRegistroCentroCosto(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarRegistroCentroCosto"
                .Parameters.AddWithValue("@ID_CENTRO_COSTO", SqlDbType.Int).Value = IdCentroC
                .Parameters.AddWithValue("@DETALLE_CENTRO_COSTO", SqlDbType.NVarChar).Value = DetalleCentroC
                .Parameters.AddWithValue("@CODIGO_CENTRO_COSTO", SqlDbType.NVarChar).Value = CodigoCentroC
                .Parameters.AddWithValue("@ESTADO_CENTRO_COSTO", SqlDbType.Int).Value = EstadoCentroC

            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace