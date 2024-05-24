Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.BANCOS
    Public Class ClassBancos
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdBancos As Integer
        Public Codigo As String
        Public Nombre As String
        Public Direccion As String
        Public OficialCredito As String
        Public Telefono As String
        Public Fax As String
        Public Email As String
        Public Estado As Integer


        Public Function SeleccionarRegistrosBancos(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosBancos", True)
        End Function

        Public Function SeleccionarOrdenadosRegistrosBancos(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarOrdenadosRegistrosBancos", True)
        End Function

        Public Function BuscarMayorIdBancos(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdBancos", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdBancoXNombreBanco(ByVal tipoCon As TipoConexion, ByVal nombreBancoBuscado As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_BANCO", SqlDbType.NVarChar, nombreBancoBuscado})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdBancoXNombreBanco", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarCodigoBancoXNombreBanco(ByVal tipoCon As TipoConexion, ByVal nombreBancoBuscado As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NOMBRE_BANCO", SqlDbType.NVarChar, nombreBancoBuscado})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCodigoBancoXNombreBanco", True, pars)
            Return If(data.Rows.Count = 0, String.Empty, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroBancos(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroBancos"
                .Parameters.AddWithValue("@ID_BANCO", SqlDbType.Int).Value = IdBancos
                .Parameters.AddWithValue("@CODIGO_BANCO", SqlDbType.NVarChar).Value = Codigo
                .Parameters.AddWithValue("@NOMBRE_BANCO", SqlDbType.NVarChar).Value = Nombre
                .Parameters.AddWithValue("@DIRECCION_BANCO", SqlDbType.NVarChar).Value = Direccion
                .Parameters.AddWithValue("@OFICIAL_CREDITO_BANCO", SqlDbType.NVarChar).Value = OficialCredito
                .Parameters.AddWithValue("@TELEFONO_BANCO", SqlDbType.NVarChar).Value = Telefono
                .Parameters.AddWithValue("@FAX_BANCO", SqlDbType.NVarChar).Value = Fax
                .Parameters.AddWithValue("@EMAIL_BANCO", SqlDbType.NVarChar).Value = Email
                .Parameters.AddWithValue("@ESTADO_BANCO", SqlDbType.Int).Value = Estado
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ModificarRegistroBancos(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "modificarRegistroBancos"
                .Parameters.AddWithValue("@ID_BANCO", SqlDbType.Int).Value = IdBancos
                .Parameters.AddWithValue("@NOMBRE_BANCO", SqlDbType.NVarChar).Value = Nombre
                .Parameters.AddWithValue("@DIRECCION_BANCO", SqlDbType.NVarChar).Value = Direccion
                .Parameters.AddWithValue("@OFICIAL_CREDITO_BANCO", SqlDbType.NVarChar).Value = OficialCredito
                .Parameters.AddWithValue("@TELEFONO_BANCO", SqlDbType.NVarChar).Value = Telefono
                .Parameters.AddWithValue("@FAX_BANCO", SqlDbType.NVarChar).Value = Fax
                .Parameters.AddWithValue("@EMAIL_BANCO", SqlDbType.NVarChar).Value = Email
                .Parameters.AddWithValue("@ESTADO_BANCO", SqlDbType.Int).Value = Estado
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace

