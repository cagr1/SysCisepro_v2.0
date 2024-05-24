Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.RETENCIONES_EMITIDAS
    Public Class ClassContribuyenteRetenido

        Public Function SeleccionarRegistrosContribuyentes(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosContribuyentes", True) 
        End Function
         
    End Class
End Namespace