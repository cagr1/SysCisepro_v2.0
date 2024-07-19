Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.UNIFORMES
    Public Class ClassEntregaUniformes
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Int64
        Public Codigo As String
        Public Version As String
        Public Fecha As DateTime
        Public Nombre As String
        Public Cedula As String
        Public Cliente As String
        Public FechaIngreso As DateTime
        Public Realizado As String
        Public Revisado As String
        Public Aprobado As String
        Public Registrado As String
        Public Estado As Integer
        Public Observacion As String
         
        Public Function BuscarMayorIdEntregaUniforme(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdEntregaUniformes", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroEntregaUniformesCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroEntregaUniformes"
                .Parameters.AddWithValue("@ID_UNIFORMES", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@CODIGO_UNIFORMES", SqlDbType.NVarChar).Value = Codigo
                .Parameters.AddWithValue("@VERSION_UNIFORMES", SqlDbType.NVarChar).Value = Version
                .Parameters.AddWithValue("@FECHA_UNIFORMES", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@NOMBRE_UNIFORMES", SqlDbType.NVarChar).Value = Nombre
                .Parameters.AddWithValue("@CEDULA_UNIFORMES", SqlDbType.NVarChar).Value = Cedula
                .Parameters.AddWithValue("@CLIENTE_UNIFORMES", SqlDbType.NVarChar).Value = Cliente
                .Parameters.AddWithValue("@FECHA_INGRESO_UNIFORMES", SqlDbType.DateTime).Value = FechaIngreso
                .Parameters.AddWithValue("@REALIZADO_UNIFORMES", SqlDbType.NVarChar).Value = Realizado
                .Parameters.AddWithValue("@REVISADO_UNIFORMES", SqlDbType.NVarChar).Value = Revisado
                .Parameters.AddWithValue("@APROBADO_UNIFORMES", SqlDbType.NVarChar).Value = Aprobado
                .Parameters.AddWithValue("@REGISTRADO_UNIFORMES", SqlDbType.NVarChar).Value = Registrado
                .Parameters.AddWithValue("@ESTADO_UNIFORMES", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@OBSERVACION_UNIFORMES", SqlDbType.NVarChar).Value = Observacion
            End With
            Return comando
        End Function

        Public Function ActualizarRegistroEntregaUniformesCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ActualizarRegistroEntregaUniformes"
                .Parameters.AddWithValue("@ID_UNIFORMES", SqlDbType.BigInt).Value = Id
                .Parameters.AddWithValue("@CODIGO_UNIFORMES", SqlDbType.NVarChar).Value = Codigo
                .Parameters.AddWithValue("@VERSION_UNIFORMES", SqlDbType.NVarChar).Value = Version
                .Parameters.AddWithValue("@FECHA_UNIFORMES", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@NOMBRE_UNIFORMES", SqlDbType.NVarChar).Value = Nombre
                .Parameters.AddWithValue("@CEDULA_UNIFORMES", SqlDbType.NVarChar).Value = Cedula
                .Parameters.AddWithValue("@CLIENTE_UNIFORMES", SqlDbType.NVarChar).Value = Cliente
                .Parameters.AddWithValue("@FECHA_INGRESO_UNIFORMES", SqlDbType.DateTime).Value = FechaIngreso
                .Parameters.AddWithValue("@REALIZADO_UNIFORMES", SqlDbType.NVarChar).Value = Realizado
                .Parameters.AddWithValue("@REVISADO_UNIFORMES", SqlDbType.NVarChar).Value = Revisado
                .Parameters.AddWithValue("@APROBADO_UNIFORMES", SqlDbType.NVarChar).Value = Aprobado
                .Parameters.AddWithValue("@REGISTRADO_UNIFORMES", SqlDbType.NVarChar).Value = Registrado
                .Parameters.AddWithValue("@ESTADO_UNIFORMES", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@OBSERVACION_UNIFORMES", SqlDbType.NVarChar).Value = Observacion
            End With
            Return comando
        End Function

        Public Function BuscarRegistroEntregaUniformesXid(ByVal tipoCon As TipoConexion, ByVal idl As Int64) As DataSet
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_UNIFORMES", SqlDbType.Int, idl})
            Dim liqi = ComandosSql.SeleccionarQueryWithParamsToDataAdapter(tipoCon, "BuscarRegistroEntregaUniformesXid", True, pars)
            Dim acti = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.DETALLE_UNIFORMES where ESTADO_DETALLE_UNIFORMES = 1", False)
            Dim empr = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.KARDEX", False) 
            Dim pers = ComandosSql.SeleccionarQueryToDataAdapter(tipoCon, "SELECT * FROM dbo.SECUENCIAL_ITEM", False) 

            Dim ds = New DataSet()
            liqi.Fill(ds, "ENTREGA_UNIFORMES")
            acti.Fill(ds, "DETALLE_UNIFORMES")
            empr.Fill(ds, "KARDEX")
            pers.Fill(ds, "SECUENCIAL_ITEM")
            Return ds
        End Function

    End Class
End Namespace
