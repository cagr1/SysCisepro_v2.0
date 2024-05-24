Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.BANCOS

    Public Class ClassDetallePlanillaCobrosPagos
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdPlanilla As Integer
        Public IdDetallePlanilla As Integer
        Public TipoDocum As String
        Public CiRuc As String
        Public Ordenante As String
        Public Contrato As String
        Public FormaPago As String
        Public Banco As String
        Public TipoCuenta As String
        Public NumCuenta As String
        Public Valor As Decimal
        Public Submotivo As String
        Public Procesado As Integer
        Public Proces As String
        Public FechaProceso As DateTime
        Public Idfactura As String
        Public Numfactura As String
        Public Idcliente As String
        Public Cliente As String

        Public Function BuscarMayorIdDetallePlanilla(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetallePlanillaCobrosPagos", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroDetallePlanillaCobrosPagos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO DETALLE_PLANILLA_COBROS_PAGOS VALUES (@ID_PLANILLA, @TIPO_DOC, @CI_RUC, @ORDENANTE, @CONTRATO, @FORMA_PAGO, @BANCO, @TIPO_CUENTA, @NUM_CUENTA, @VALOR, @SUBMOTIVO, 0,0,0,0, 0, '', @DETA, null, @IDF, @NUF, @IDC, @CLI)"
                .Parameters.AddWithValue("@ID_PLANILLA", SqlDbType.Int).Value = IdPlanilla
                .Parameters.AddWithValue("@TIPO_DOC", SqlDbType.NVarChar).Value = TipoDocum
                .Parameters.AddWithValue("@CI_RUC", SqlDbType.NVarChar).Value = CiRuc
                .Parameters.AddWithValue("@ORDENANTE", SqlDbType.NVarChar).Value = Ordenante
                .Parameters.AddWithValue("@CONTRATO", SqlDbType.NVarChar).Value = Contrato
                .Parameters.AddWithValue("@FORMA_PAGO", SqlDbType.NVarChar).Value = FormaPago
                .Parameters.AddWithValue("@BANCO", SqlDbType.NVarChar).Value = Banco
                .Parameters.AddWithValue("@TIPO_CUENTA", SqlDbType.NVarChar).Value = TipoCuenta
                .Parameters.AddWithValue("@NUM_CUENTA", SqlDbType.NVarChar).Value = NumCuenta
                .Parameters.AddWithValue("@VALOR", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@SUBMOTIVO", SqlDbType.NVarChar).Value = Submotivo
                .Parameters.AddWithValue("@DETA", SqlDbType.Int).Value = IdDetallePlanilla
                .Parameters.AddWithValue("@IDF", SqlDbType.NVarChar).Value = Idfactura
                .Parameters.AddWithValue("@NUF", SqlDbType.NVarChar).Value = Numfactura
                .Parameters.AddWithValue("@IDC", SqlDbType.NVarChar).Value = Idcliente
                .Parameters.AddWithValue("@CLI", SqlDbType.NVarChar).Value = Cliente
            End With
            Return comando
        End Function

        Public Function NuevoRegistroDetallePlanillaCobrosPagos(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO DETALLE_PLANILLA_COBROS_PAGOS VALUES (@ID_PLANILLA, @TIPO_DOC, @CI_RUC, @ORDENANTE, @CONTRATO, @FORMA_PAGO, @BANCO, @TIPO_CUENTA, @NUM_CUENTA, @VALOR, @SUBMOTIVO, 0,0,0,0, 0, '', @DETA, null, @IDF, @NUF, @IDC, @CLI)"
                .Parameters.AddWithValue("@ID_PLANILLA", SqlDbType.Int).Value = IdPlanilla
                .Parameters.AddWithValue("@TIPO_DOC", SqlDbType.NVarChar).Value = TipoDocum
                .Parameters.AddWithValue("@CI_RUC", SqlDbType.NVarChar).Value = CiRuc
                .Parameters.AddWithValue("@ORDENANTE", SqlDbType.NVarChar).Value = Ordenante
                .Parameters.AddWithValue("@CONTRATO", SqlDbType.NVarChar).Value = Contrato
                .Parameters.AddWithValue("@FORMA_PAGO", SqlDbType.NVarChar).Value = FormaPago
                .Parameters.AddWithValue("@BANCO", SqlDbType.NVarChar).Value = Banco
                .Parameters.AddWithValue("@TIPO_CUENTA", SqlDbType.NVarChar).Value = TipoCuenta
                .Parameters.AddWithValue("@NUM_CUENTA", SqlDbType.NVarChar).Value = NumCuenta
                .Parameters.AddWithValue("@VALOR", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@SUBMOTIVO", SqlDbType.NVarChar).Value = Submotivo
                .Parameters.AddWithValue("@DETA", SqlDbType.Int).Value = IdDetallePlanilla
                .Parameters.AddWithValue("@IDF", SqlDbType.NVarChar).Value = Idfactura
                .Parameters.AddWithValue("@NUF", SqlDbType.NVarChar).Value = Numfactura
                .Parameters.AddWithValue("@IDC", SqlDbType.NVarChar).Value = Idcliente
                .Parameters.AddWithValue("@CLI", SqlDbType.NVarChar).Value = Cliente
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ProcesarRegistroDetallePlanillaCobrosPagos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE DETALLE_PLANILLA_COBROS_PAGOS SET PROCESADO=@PROCESADO, PROCES=@PROCES, FECHA_PROCESO=@FECHA_PROCESO WHERE ID_PLANILLA=@ID_PLANILLA AND ID_DETALLE=@DETA"
                .Parameters.AddWithValue("@ID_PLANILLA", SqlDbType.Int).Value = IdPlanilla
                .Parameters.AddWithValue("@DETA", SqlDbType.Int).Value = IdDetallePlanilla
                .Parameters.AddWithValue("@PROCESADO", SqlDbType.Int).Value = Procesado
                .Parameters.AddWithValue("@PROCES", SqlDbType.NVarChar).Value = Proces
                .Parameters.AddWithValue("@FECHA_PROCESO", SqlDbType.DateTime).Value = FechaProceso
            End With
            Return comando
        End Function

        Public Function ProcesarRegistroDetallePlanillaCobrosPagos(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE DETALLE_PLANILLA_COBROS_PAGOS SET PROCESADO=@PROCESADO, PROCES=@PROCES, FECHA_PROCESO=@FECHA_PROCESO WHERE ID_PLANILLA=@ID_PLANILLA AND ID_DETALLE=@DETA"
                .Parameters.AddWithValue("@ID_PLANILLA", SqlDbType.Int).Value = IdPlanilla
                .Parameters.AddWithValue("@DETA", SqlDbType.Int).Value = IdDetallePlanilla
                .Parameters.AddWithValue("@PROCESADO", SqlDbType.Int).Value = Procesado
                .Parameters.AddWithValue("@PROCES", SqlDbType.NVarChar).Value = Proces
                .Parameters.AddWithValue("@FECHA_PROCESO", SqlDbType.DateTime).Value = FechaProceso
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function SeleccionarDetallesComprobantesPlanillaCobrosPagosPorId(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_COMPROBANTE", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarDetallesComprobantesPlanillaCobrosPagosPorId", True, pars)
        End Function


        Public Function EliminarRegistroDetallePlanillaCobrosPagos() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "DELETE FROM DETALLE_PLANILLA_COBROS_PAGOS WHERE ID_PLANILLA=@ID_PLANILLA"
                .Parameters.AddWithValue("@ID_PLANILLA", SqlDbType.Int).Value = IdPlanilla
            End With
            Return comando
        End Function
    End Class
End Namespace