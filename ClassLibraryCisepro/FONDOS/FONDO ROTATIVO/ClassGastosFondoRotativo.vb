Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.FONDO_ROTATIVO
    Public Class ClassGastosFondoRotativo
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdGastos As Integer
        Public NombreGastos As String
        Public CtaContableGastos As String
        Public EstadoGastos As Integer
        Public IdFondoRotativoGastos As Integer
        Public Idplan As Integer

        Public Function SeleccionarGastosFondoRotativo(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM dbo.GASTOS_FONDO_ROTATIVO WHERE ESTADO_GASTOS_FR=1 order by nombre_gastos_fr;", False)
        End Function

        Public Function SeleccionarOrdenadosGastosFondoRotativo(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarOrdenadosGastosFondoRotativo", True)
        End Function

        Public Function BuscarMayorIdGastosForndoRotativo(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdGastosForndoRotativo", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarCtaContableGastosFondoRotativoXNombre(ByVal tipoCon As TipoConexion, ByVal nombreGastoSolicitud As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_GASTOS_FR", SqlDbType.NVarChar, nombreGastoSolicitud})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarCtaContableGastosFondoRotativoXNombre", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreGastosFrPorIdGastosFr(ByVal tipoCon As TipoConexion, ByVal idGastosSolicitud As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_GASTOS_FR", SqlDbType.Int, idGastosSolicitud})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNombreGastosFRPorIdGastosFR", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroGastosForndoRotativo() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroGastosForndoRotativo"
                .Parameters.AddWithValue("@ID_GASTOS_FR", SqlDbType.Int).Value = IdGastos
                .Parameters.AddWithValue("@NOMBRE_GASTOS_FR", SqlDbType.NVarChar).Value = NombreGastos
                .Parameters.AddWithValue("@CTA_CONTABLE_GASTOS_FR", SqlDbType.NVarChar).Value = CtaContableGastos
                .Parameters.AddWithValue("@ESTADO_GASTOS_FR", SqlDbType.Int).Value = EstadoGastos
                .Parameters.AddWithValue("@ID_FONDO_ROTATIVO", SqlDbType.Int).Value = IdFondoRotativoGastos
                .Parameters.AddWithValue("@ID_PLAN", SqlDbType.Int).Value = Idplan
            End With
            Return comando
        End Function

    End Class
End Namespace

