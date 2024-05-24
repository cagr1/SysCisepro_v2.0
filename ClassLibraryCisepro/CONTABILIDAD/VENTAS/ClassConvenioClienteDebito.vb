Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.VENTAS
     
    Public Class ClassConvenioClienteDebito
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdConvenio As Int64
        Public IdClienteGeneral As Int64
        Public Banco As String
        Public TipoCenta As String
        Public TipoDoc As String
        Public NumCtaTrj As String
        Public Titular As String
        Public CedRuc As String
        Public Valor As Decimal
        Public Observacion As String

        Public Function BuscarMayorIdConvenio(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select max(ID_CONVENIO) ID_CONVENIO from CONVENIO_CLIENTE_BANCO_DEBITO;", False)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0)) + 1))
        End Function

        Public Function NuevoRegistroConvenioClienteGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO CONVENIO_CLIENTE_BANCO_DEBITO VALUES (@ID_CONVENIO, @ID_CLIENTE_GENERAL, @BANCO_CONVENIO, @TIPO_CUENTA, @TIPO_DOC, @NUM_CUENTA_TARJ, @NUM_CI_RUC, @TITULAR_CUENTA, @VALOR, @ESTADO, @OBSERVACION);"
                .Parameters.AddWithValue("@ID_CONVENIO", SqlDbType.Int).Value = IdConvenio
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.Int).Value = IdClienteGeneral
                .Parameters.AddWithValue("@BANCO_CONVENIO", SqlDbType.NVarChar).Value = Banco
                .Parameters.AddWithValue("@TIPO_CUENTA", SqlDbType.NVarChar).Value = TipoCenta
                .Parameters.AddWithValue("@TIPO_DOC", SqlDbType.NVarChar).Value = TipoDoc
                .Parameters.AddWithValue("@NUM_CUENTA_TARJ", SqlDbType.NVarChar).Value = NumCtaTrj
                .Parameters.AddWithValue("@NUM_CI_RUC", SqlDbType.NVarChar).Value = CedRuc
                .Parameters.AddWithValue("@TITULAR_CUENTA", SqlDbType.NVarChar).Value = Titular
                .Parameters.AddWithValue("@VALOR", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = 1
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.VarChar).Value = Observacion
            End With
            Return comando
        End Function
        
        Public Function ActualizarRegistroConvenioClienteGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update CONVENIO_CLIENTE_BANCO_DEBITO set BANCO_CONVENIO=@BANCO_CONVENIO, TIPO_CUENTA=@TIPO_CUENTA, TIPO_DOC=@TIPO_DOC, NUM_CUENTA_TARJ=@NUM_CUENTA_TARJ, NUM_CI_RUC=@NUM_CI_RUC, TITULAR_CUENTA=@TITULAR_CUENTA, VALOR=@VALOR, OBSERVACION=@OBSERVACION where ID_CONVENIO=@ID_CONVENIO;"
                .Parameters.AddWithValue("@ID_CONVENIO", SqlDbType.Int).Value = IdConvenio
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.Int).Value = IdClienteGeneral
                .Parameters.AddWithValue("@BANCO_CONVENIO", SqlDbType.NVarChar).Value = Banco
                .Parameters.AddWithValue("@TIPO_CUENTA", SqlDbType.NVarChar).Value = TipoCenta
                .Parameters.AddWithValue("@TIPO_DOC", SqlDbType.NVarChar).Value = TipoDoc
                .Parameters.AddWithValue("@NUM_CUENTA_TARJ", SqlDbType.NVarChar).Value = NumCtaTrj
                .Parameters.AddWithValue("@NUM_CI_RUC", SqlDbType.NVarChar).Value = CedRuc
                .Parameters.AddWithValue("@TITULAR_CUENTA", SqlDbType.NVarChar).Value = Titular
                .Parameters.AddWithValue("@VALOR", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = 1
                .Parameters.AddWithValue("@OBSERVACION", SqlDbType.VarChar).Value = Observacion
            End With
            Return comando
        End Function
      
        Public Function BuscarConvenioClienteGeneralXId(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM CONVENIO_CLIENTE_BANCO_DEBITO WHERE ID_CLIENTE_GENERAL=@ID_CLIENTE_GENERAL and ESTADO=1", False, pars)
        End Function
 
        Public Function QuitarRegistroConvenioClienteGeneral(ByVal tipoCon As TipoConexion, ByVal idcon As Integer) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE CONVENIO_CLIENTE_BANCO_DEBITO SET ESTADO=0 WHERE ID_CONVENIO=@ID_CONVENIO;"
                .Parameters.AddWithValue("@ID_CONVENIO", SqlDbType.Int).Value = idcon 
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace