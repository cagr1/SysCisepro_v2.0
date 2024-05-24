Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.LIBRO_DIARIO
    Public Class ClassAsientosLibroDiario
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdAsiento As Int64
        Public FechaAsiento As DateTime
        Public CodigoCuentaAsiento As String
        Public NombreCuentaAsiento As String
        Public ConceptoAsiento As String
        Public DetalleTransaccionAsiento As String
        Public ProvinciaAsiento As String
        Public CiudadAsiento As String
        Public ParroquiaAsiento As String
        Public CentroCostoAsiento As String
        Public ValorDebeAsiento As Decimal
        Public ValorHaberAsiento As Decimal
        Public NumeroRegistroAsiento As Int64
        Public DebeHaberAsiento As Integer
        Public ConciliarAsiento As Integer
        Public EstadoAsiento As Integer
        Public IdLibroDiario As Int64
        Public EstadoMayorAsiento As Integer

        Public Function SeleccionarNumeroRegistroAsientosLibroDiario(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarNumeroRegistroAsientosLibroDiario", True) 
        End Function

        Public Function SeleccionarAsientosLibroDiarioXIdLibro(ByVal tipoCon As TipoConexion, ByVal idLibroD As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_LIBRO_DIARIO", SqlDbType.Int, idLibroD})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarAsientosLibroDiarioXIdLibro", True, pars) 
        End Function

        Public Function BuscarAsientosLibroDiarioXNumeroRegistro(ByVal tipoCon As TipoConexion, ByVal idLibroD As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_REGISTRO_ASIENTO", SqlDbType.Int, idLibroD})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarAsientosLibroDiarioXNumeroRegistro", True, pars) 
        End Function

        Public Function BuscarAsientosLibroDiarioXNumeroRegistroAuxiliaresLiquidacion(ByVal tipoCon As TipoConexion, ByVal idLibroD As Int64) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUMERO_REGISTRO_ASIENTO", SqlDbType.Int, idLibroD})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarAsientosLibroDiarioXNumeroRegistroAuxiliaresLiquidacion", True, pars) 
        End Function

        Public Function BuscarNumeroRegistroAsientoXConceptoAsientoLibroDiario(ByVal tipoCon As TipoConexion, ByVal concepto As String) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CONCEPTO_ASIENTO", SqlDbType.VarChar, concepto})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT max(NUMERO_REGISTRO_ASIENTO) as NUMERO_REGISTRO_ASIENTO FROM dbo.ASIENTOS_LIBRO_DIARIO WHERE CONCEPTO_ASIENTO = @CONCEPTO_ASIENTO and ESTADO_ASIENTO <> 0;", False, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorIdAsientoLibroDiario(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdAsientoLibroDiario", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNuneroRegistroAsientoLibroDiario(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorNuneroRegistroAsientoLibroDiario", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNuneroRegistroAsientoInicialLibroDiarioXFecha(ByVal tipoCon As TipoConexion, ByVal fechaInicial As DateTime, ByVal fechaFinal As DateTime) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"FECHA_INICIAL", SqlDbType.DateTime, fechaInicial})
            pars.Add(New Object() {"FECHA_FINAL", SqlDbType.DateTime, fechaFinal})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscaBuscarMayorNuneroRegistroAsientoInicialLibroDiarioXFecharMayorNuneroRegistroAsientoInicialLibroDiarioXFecha", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorNuneroRegistroAsientoInicialLibroDiario(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorNuneroRegistroAsientoInicialLibroDiario", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroAsientoLibroDiarioCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroAsientoLibroDiario"
                .Parameters.AddWithValue("@ID_ASIENTO", SqlDbType.BigInt).Value = idAsiento
                .Parameters.AddWithValue("@FECHA_ASIENTO", SqlDbType.DateTime).Value = fechaAsiento
                .Parameters.AddWithValue("@CODIGO_CUENTA_ASIENTO", SqlDbType.NVarChar).Value = CodigoCuentaAsiento.Trim
                .Parameters.AddWithValue("@NOMBRE_CUENTA_ASIENTO", SqlDbType.NVarChar).Value = NombreCuentaAsiento.Trim
                .Parameters.AddWithValue("@CONCEPTO_ASIENTO", SqlDbType.NVarChar).Value = ConceptoAsiento
                .Parameters.AddWithValue("@DETALLE_TRANSACCION_ASIENTO", SqlDbType.NVarChar).Value = detalleTransaccionAsiento
                .Parameters.AddWithValue("@PROVINCIA_ASIENTO", SqlDbType.NVarChar).Value = provinciaAsiento
                .Parameters.AddWithValue("@CIUDAD_ASIENTO", SqlDbType.NVarChar).Value = ciudadAsiento
                .Parameters.AddWithValue("@PARROQUIA_ASIENTO", SqlDbType.NVarChar).Value = parroquiaAsiento
                .Parameters.AddWithValue("@CENTRO_COSTO_ASIENTO", SqlDbType.NVarChar).Value = centroCostoAsiento
                .Parameters.AddWithValue("@VALOR_DEBE_ASIENTO", SqlDbType.Decimal).Value = valorDebeAsiento
                .Parameters.AddWithValue("@VALOR_HABER_ASIENTO", SqlDbType.Decimal).Value = valorHaberAsiento
                .Parameters.AddWithValue("@NUMERO_REGISTRO_ASIENTO", SqlDbType.BigInt).Value = numeroRegistroAsiento
                .Parameters.AddWithValue("@DEBE_HABER", SqlDbType.Int).Value = debeHaberAsiento
                .Parameters.AddWithValue("@CONCILIAR_ASIENTO", SqlDbType.Int).Value = conciliarAsiento
                .Parameters.AddWithValue("@ESTADO_ASIENTO", SqlDbType.Int).Value = estadoAsiento
                .Parameters.AddWithValue("@ID_LIBRO_DIARIO", SqlDbType.BigInt).Value = idLibroDiario
                .Parameters.AddWithValue("@ESTADO_MAYOR", SqlDbType.Int).Value = estadoMayorAsiento
            End With
            Return comando
        End Function

        Public Function NuevoRegistroAsientoLibroDiario(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroAsientoLibroDiario"
                .Parameters.AddWithValue("@ID_ASIENTO", SqlDbType.BigInt).Value = idAsiento
                .Parameters.AddWithValue("@FECHA_ASIENTO", SqlDbType.DateTime).Value = fechaAsiento
                .Parameters.AddWithValue("@CODIGO_CUENTA_ASIENTO", SqlDbType.NVarChar).Value = codigoCuentaAsiento.Trim
                .Parameters.AddWithValue("@NOMBRE_CUENTA_ASIENTO", SqlDbType.NVarChar).Value = nombreCuentaAsiento.Trim
                .Parameters.AddWithValue("@CONCEPTO_ASIENTO", SqlDbType.NVarChar).Value = ConceptoAsiento
                .Parameters.AddWithValue("@DETALLE_TRANSACCION_ASIENTO", SqlDbType.NVarChar).Value = detalleTransaccionAsiento
                .Parameters.AddWithValue("@PROVINCIA_ASIENTO", SqlDbType.NVarChar).Value = provinciaAsiento
                .Parameters.AddWithValue("@CIUDAD_ASIENTO", SqlDbType.NVarChar).Value = ciudadAsiento
                .Parameters.AddWithValue("@PARROQUIA_ASIENTO", SqlDbType.NVarChar).Value = parroquiaAsiento
                .Parameters.AddWithValue("@CENTRO_COSTO_ASIENTO", SqlDbType.NVarChar).Value = centroCostoAsiento
                .Parameters.AddWithValue("@VALOR_DEBE_ASIENTO", SqlDbType.Decimal).Value = valorDebeAsiento
                .Parameters.AddWithValue("@VALOR_HABER_ASIENTO", SqlDbType.Decimal).Value = valorHaberAsiento
                .Parameters.AddWithValue("@NUMERO_REGISTRO_ASIENTO", SqlDbType.BigInt).Value = numeroRegistroAsiento
                .Parameters.AddWithValue("@DEBE_HABER", SqlDbType.Int).Value = debeHaberAsiento
                .Parameters.AddWithValue("@CONCILIAR_ASIENTO", SqlDbType.Int).Value = conciliarAsiento
                .Parameters.AddWithValue("@ESTADO_ASIENTO", SqlDbType.Int).Value = estadoAsiento
                .Parameters.AddWithValue("@ID_LIBRO_DIARIO", SqlDbType.BigInt).Value = idLibroDiario
                .Parameters.AddWithValue("@ESTADO_MAYOR", SqlDbType.Int).Value = estadoMayorAsiento
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function ActualizarRegistroAsientoLibroDiario() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ActualizarRegistroAsientoLibroDiario"
                .Parameters.AddWithValue("@ID_ASIENTO", SqlDbType.BigInt).Value = idAsiento
                .Parameters.AddWithValue("@VALOR_DEBE_ASIENTO", SqlDbType.Decimal).Value = valorDebeAsiento
                .Parameters.AddWithValue("@VALOR_HABER_ASIENTO", SqlDbType.Decimal).Value = valorHaberAsiento
                .Parameters.AddWithValue("@DEBE_HABER", SqlDbType.Int).Value = debeHaberAsiento
                .Parameters.AddWithValue("@ESTADO_ASIENTO", SqlDbType.Int).Value = estadoAsiento
                .Parameters.AddWithValue("@ID_LIBRO_DIARIO", SqlDbType.BigInt).Value = idLibroDiario
            End With
            Return comando
        End Function
     
        Public Function AnularAsientoLibroDiarioXNumeroRegistro() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "AnularAsientoLibroDiarioXNumeroRegistro"
                .Parameters.AddWithValue("@NUMERO_REGISTRO_ASIENTO", SqlDbType.BigInt).Value = numeroRegistroAsiento
            End With
            Return comando
        End Function

        Public Function SumarHaberRetencionAsientoLibroDiarioXIdRegistro() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update ASIENTOS_LIBRO_DIARIO set VALOR_HABER_ASIENTO = @VALOR where id_asiento = @ID;"
                .Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = IdAsiento
                .Parameters.AddWithValue("@VALOR", SqlDbType.Decimal).Value = ValorHaberAsiento
            End With
            Return comando
        End Function

        Public Function SumarDebeRetencionAsientoLibroDiarioXIdRegistro() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update ASIENTOS_LIBRO_DIARIO set VALOR_DEBE_ASIENTO = @VALOR where id_asiento = @ID;"
                .Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = IdAsiento
                .Parameters.AddWithValue("@VALOR", SqlDbType.Decimal).Value = ValorDebeAsiento
            End With
            Return comando
        End Function

        Public Function AnularAsientoLibroDiarioXIdRegistro() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update ASIENTOS_LIBRO_DIARIO set ESTADO_ASIENTO = 0 where id_asiento = @ID "
                .Parameters.AddWithValue("@ID", SqlDbType.BigInt).Value = IdAsiento
            End With
            Return comando
        End Function

        Public Function ModificarRegistroAsientoLibroDiarioCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ModificarRegistroAsientoLibroDiario"
                .Parameters.AddWithValue("@ID_ASIENTO", SqlDbType.BigInt).Value = idAsiento
                .Parameters.AddWithValue("@FECHA_ASIENTO", SqlDbType.DateTime).Value = fechaAsiento
                .Parameters.AddWithValue("@CODIGO_CUENTA_ASIENTO", SqlDbType.NVarChar).Value = CodigoCuentaAsiento.Trim
                .Parameters.AddWithValue("@NOMBRE_CUENTA_ASIENTO", SqlDbType.NVarChar).Value = NombreCuentaAsiento.Trim
                .Parameters.AddWithValue("@CONCEPTO_ASIENTO", SqlDbType.NVarChar).Value = ConceptoAsiento
                .Parameters.AddWithValue("@DETALLE_TRANSACCION_ASIENTO", SqlDbType.NVarChar).Value = detalleTransaccionAsiento
                .Parameters.AddWithValue("@VALOR_DEBE_ASIENTO", SqlDbType.Decimal).Value = valorDebeAsiento
                .Parameters.AddWithValue("@VALOR_HABER_ASIENTO", SqlDbType.Decimal).Value = valorHaberAsiento
                .Parameters.AddWithValue("@NUMERO_REGISTRO_ASIENTO", SqlDbType.BigInt).Value = numeroRegistroAsiento
                .Parameters.AddWithValue("@DEBE_HABER", SqlDbType.Int).Value = debeHaberAsiento
                .Parameters.AddWithValue("@CONCILIAR_ASIENTO", SqlDbType.Int).Value = conciliarAsiento
                .Parameters.AddWithValue("@ESTADO_ASIENTO", SqlDbType.Int).Value = estadoAsiento
                .Parameters.AddWithValue("@ID_LIBRO_DIARIO", SqlDbType.BigInt).Value = idLibroDiario
            End With
            Return comando
        End Function
    
    End Class
End Namespace

