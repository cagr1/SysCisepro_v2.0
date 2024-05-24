Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace REPORTES
    Public Class ClassReporteCodigoActivos
        Public Function CodigosActivos(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM CODIGOS_ACTIVOS ORDER BY ID_CATEGORIA", False) 
        End Function
    End Class
End Namespace

