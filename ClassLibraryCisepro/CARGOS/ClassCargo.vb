Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CARGOS

    Public Class ClassCargo
        Public Function SeleccionarTodosLosRegistrosCargos(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarTodosLosRegistrosCargos", True)
        End Function

    End Class
End Namespace
