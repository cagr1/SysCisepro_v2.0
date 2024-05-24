 Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.PROVEEDORES
    Public Class ClassDetalleProveedorItem
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdSecuencial As Int64
        Public IdProveedor As Integer
        Public Fecha As DateTime
        Public Estado As Integer

        Public Function NuevaDetalleProvedorItem() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevaDetalleProvedorItem"
                .Parameters.AddWithValue("@ID_SECUENCIAL_ITEM", SqlDbType.BigInt).Value = IdSecuencial
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedor
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@ESTADO", SqlDbType.NVarChar).Value = Estado
            End With
            Return comando
        End Function
 
        Public Function SeleccionarTodosLosRegistrosDetallesProveedorItem(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_SECUENCIAL_ITEM", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarTodosLosRegistrosDetallesProveedorItem", True, pars) 
        End Function

        Public Function SeleccionarTodosLosRegistrosSecuencialItem(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarSecuencialesNombre", True) 
        End Function

    End Class
End Namespace

