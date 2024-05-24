Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.VENTAS
    Public Class ClassContratoCliente
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdContrato As Int64
        Public IdClienteGeneral As Int64
        Public Valor As Decimal
        Public Anio As Integer
        Public Fecha As DateTime
        Public Estado As Integer

        Public Function BuscarAniosContratoActivoClienteGeneral(ByVal tipoCon As TipoConexion) As DataTable
            Dim pars = New List(Of Object())
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT ANIO FROM CONTRATO_CLIENTE WHERE ESTADO = 1 GROUP BY ANIO ORDER BY ANIO DESC;", False)
        End Function

        Public Function BuscarContratoActivoXIdClienteAnio(ByVal tipoCon As TipoConexion, ByVal idcli As Integer, ByVal anio As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CLIENTE_GENERAL", SqlDbType.Int, idcli})
            pars.Add(New Object() {"ANIO", SqlDbType.Int, anio})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM CONTRATO_CLIENTE WHERE ESTADO = 1 and ID_CLIENTE_GENERAL = @ID_CLIENTE_GENERAL AND ANIO = @ANIO", False, pars)
        End Function

        Public Function BuscarContratoActivoClienteGeneralXId(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CONTRATO", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM CONTRATO_CLIENTE WHERE ID_CONTRATO=@ID_CONTRATO", False, pars)
        End Function


        Public Function BuscarMayorIdContrato(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select max(ID_CONTRATO) ID_CONTRATO from CONTRATO_CLIENTE;", False)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0)) + 1))
        End Function

        Public Function NuevoRegistroContratoClienteGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO CONTRATO_CLIENTE VALUES (@ID_CONTRATO, @ID_CLIENTE_GENERAL, @VALOR, @ANIO, @FECHA, @ESTADO);"
                .Parameters.AddWithValue("@ID_CONTRATO", SqlDbType.BigInt).Value = IdContrato
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdClienteGeneral
                .Parameters.AddWithValue("@VALOR", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@ANIO", SqlDbType.Int).Value = Anio
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function

        Public Function ModificarRegistroContratoClienteGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE CONTRATO_CLIENTE SET ID_CLIENTE_GENERAL=@ID_CLIENTE_GENERAL, VALOR=@VALOR, ANIO=@ANIO, FECHA=@FECHA, ESTADO=@ESTADO WHERE ID_CONTRATO=@ID_CONTRATO;"
                .Parameters.AddWithValue("@ID_CONTRATO", SqlDbType.BigInt).Value = IdContrato
                .Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdClienteGeneral
                .Parameters.AddWithValue("@VALOR", SqlDbType.Decimal).Value = Valor
                .Parameters.AddWithValue("@ANIO", SqlDbType.Int).Value = Anio
                .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
            End With
            Return comando
        End Function
    End Class
End Namespace