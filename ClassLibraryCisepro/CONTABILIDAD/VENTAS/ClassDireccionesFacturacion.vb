Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.VENTAS
    Public Class ClassDireccionesFacturacion
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdDireccion As Int64
        Public IdCliente As String
        Public Direccion As String

        Public Function BuscarMayorIdDireccionFacturacion(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT ID_DIRECCION=CASE WHEN MAX(ID_DIRECCION) IS NULL THEN 0 ELSE MAX(ID_DIRECCION) End FROM DIRECCIONES_FACTURACION_CLIENTE;", False)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarDireccionesFacturacionClienteXIdCliente(ByVal tipoCon As TipoConexion, ByVal idCliente As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.VarChar, idCliente})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from DIRECCIONES_FACTURACION_CLIENTE where ID_CLIENTE_GENERAL=@ID_CLIENTE_GENERAL;", False, pars)
        End Function

        Public Function BuscarDireccionesFacturacionClienteXIdClienteEnVentas(ByVal tipoCon As TipoConexion, ByVal idCliente As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.VarChar, idCliente})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select tab.* from ((select DIRECCION_FACTURACION_CLIENTE_GENERAL AS 'DIRECCION_FACTURACION' from CLIENTE_GENERAL WHERE ID_CLIENTE_GENERAL = @ID_CLIENTE_GENERAL) UNION (SELECT DIRECCION_FACTURACION FROM DIRECCIONES_FACTURACION_CLIENTE WHERE ID_CLIENTE_GENERAL=@ID_CLIENTE_GENERAL)) as tab group by tab.DIRECCION_FACTURACION;", False, pars)
        End Function

        Public Function NuevoRegistroDireccionCliente() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into DIRECCIONES_FACTURACION_CLIENTE values (@ID_DIRECCION, @ID_CLIENTE_GENERAL, @DIRECCION_FACTURACION);"
                .Parameters.AddWithValue("@ID_DIRECCION", SqlDbType.Int).Value = IdDireccion
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.Int).Value = IdCliente
                .Parameters.AddWithValue("@DIRECCION_FACTURACION", SqlDbType.VarChar).Value = Direccion
            End With
            Return comando
        End Function

        Public Function UpdateRegistroDireccionCliente() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update DIRECCIONES_FACTURACION_CLIENTE set  ID_CLIENTE_GENERAL=@ID_CLIENTE_GENERAL, DIRECCION_FACTURACION=@DIRECCION_FACTURACION where ID_DIRECCION=@ID_DIRECCION;"
                .Parameters.AddWithValue("@ID_DIRECCION", SqlDbType.Int).Value = IdDireccion
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.Int).Value = IdCliente
                .Parameters.AddWithValue("@DIRECCION_FACTURACION", SqlDbType.VarChar).Value = Direccion
            End With
            Return comando
        End Function
    End Class
End Namespace

