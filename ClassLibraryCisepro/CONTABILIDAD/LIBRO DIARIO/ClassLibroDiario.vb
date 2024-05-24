Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.LIBRO_DIARIO
    Public Class ClassLibroDiario
        Public IdLibroDiario As Int64

        Public Function SeleccionarLibroDiario(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarLibroDiario", True) 
        End Function

        Public Function SeleccionarOrdenadoLibroDiarioRangoFecha(ByVal tipoCon As TipoConexion, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.VarChar, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.VarChar, fechaFinal})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarLibroDiarioRangoFecha", True, pars)
        End Function
         
        Public Function BuscarMayorIdLibroDiario(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdLibroDiario", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function
         
        Public Function SeleccionarLibroDiarioXIdLibroDiario(ByVal tipoCon As TipoConexion, ByVal idLibroD As Integer) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LIBRO_DIARIO", SqlDbType.BigInt, idLibroD})
            Dim acts = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "SeleccionarLibroDiarioXIdLibroDiario", True, pars) 

            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.ASIENTOS_LIBRO_DIARIO WHERE ESTADO_ASIENTO=1", False) 

            Dim ds = New DataSet()
            acts.Fill(ds, "LIBRO_DIARIO_GENERAL")
            empr.Fill(ds, "ASIENTOS_LIBRO_DIARIO")
            Return ds
        End Function
         
        Public Function SumarRegistrosDeDiarioxIdDiario(ByVal tipoCon As TipoConexion, ByVal idLibroD As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LIBRO_DIARIO", SqlDbType.Int, idLibroD})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sumarRegistrosDeDiarioxIdDiario", True, pars) 
        End Function
       
    End Class
End Namespace
