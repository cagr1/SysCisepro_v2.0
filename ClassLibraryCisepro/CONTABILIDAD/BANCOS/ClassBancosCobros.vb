Imports System.Data 
Imports System.Windows.Forms
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.BANCOS
    Public Class ClassBancosCobros
        Private Function BuscarNombresBancosCobros(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarNombresBancosCobros", True) 
        End Function

        Public Function Autocompletar(ByVal tipoCon As TipoConexion) As AutoCompleteStringCollection
            Dim dt As DataTable = BuscarNombresBancosCobros(tipoCon)
            Dim coleccion As New AutoCompleteStringCollection()
            For Each row As DataRow In dt.Rows
                coleccion.Add(Convert.ToString(row("NOMBRE_BANCO_COBROS")))
            Next
            Return coleccion
        End Function
    End Class
End Namespace
