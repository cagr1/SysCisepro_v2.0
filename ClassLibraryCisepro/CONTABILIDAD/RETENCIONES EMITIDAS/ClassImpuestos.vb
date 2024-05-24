Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.RETENCIONES_EMITIDAS
    Public Class ClassImpuestos
         
        Public Function SeleccionarRegistrosImpuestos(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosImpuestos", True) 
        End Function
         
    End Class
End Namespace

