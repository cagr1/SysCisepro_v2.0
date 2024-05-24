Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace ESTRUCTURA_EMPRESA
    Public Class ClassSucursal 
        Public Function SeleccionarTodosLosRegistrosSucursal(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "seleccionarTodosLosRegistrosSucursal", True) 
        End Function

        Public Function BuscarNombrePorIdSucursal(ByVal tipoCon As TipoConexion, ByVal idSucursal As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_SUCURSAL", SqlDbType.Int, idSucursal})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNombrePorIdSucursal", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdSucursalPorNombre(ByVal tipoCon As TipoConexion, ByVal nombreSucursal As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_SUCURSAL", SqlDbType.NVarChar, nombreSucursal})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdSucursalPorNombre", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

    End Class
End Namespace


