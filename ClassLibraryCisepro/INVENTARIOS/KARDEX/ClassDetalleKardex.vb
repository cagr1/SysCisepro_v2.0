Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace INVENTARIOS.KARDEX
    Public Class ClassDetalleKardex
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public Id As Int64
        Public IdActividad As Integer
        Public IdConcepto As Integer
        Public CantidadIngreso As Integer
        Public ValorUnitarioIngreso As Decimal
        Public ValorTotalIngreso As Decimal
        Public CantidadEgreso As Integer
        Public ValorUnitarioEgreso As Decimal
        Public ValorTotalEgreso As Decimal
        Public CantidadSaldo As Integer
        Public ValorUnitarioSaldo As Decimal
        Public ValorTotalSaldo As Decimal
        Public Fecha As DateTime
        Public IdKardex As Int64 
        Public Estado As Integer
        Public NroComprobante As String

        Public Function SeleccionarDetallesKardexCreados(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As String) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_KARDEX", SqlDbType.VarChar, parametroBusqueda})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "seleccionarDetallesKardexCreados", True, pars) 
        End Function

        Public Function BuscarMayorIdDetalleKardexxIdKardex(ByVal tipoCon As TipoConexion, ByVal idKardex As Int64) As Integer
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_KARDEX", SqlDbType.Int, idKardex})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarMayorIdDetalleKardexxIdKardex", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarMayorIdDetalleKardex(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDetalleKardex", True) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function
         
        Public Function NuevoRegistroDetalleKardexCommand() As SqlCommand
            Dim comando As New SqlCommand()
            Try
                With comando
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "NuevoRegistroDetalleKardex"
                    .Parameters.AddWithValue("@ID_DETALLE", SqlDbType.BigInt).Value = id
                    .Parameters.AddWithValue("@ID_ACTIVIDAD", SqlDbType.Int).Value = idActividad
                    .Parameters.AddWithValue("@ID_CONCEPTO", SqlDbType.Int).Value = idConcepto
                    .Parameters.AddWithValue("@CANTIDAD_INGRESO", SqlDbType.Int).Value = cantidadIngreso
                    .Parameters.AddWithValue("@VALOR_UNITARIO_INGRESO", SqlDbType.Decimal).Value = valorUnitarioIngreso
                    .Parameters.AddWithValue("@VALOR_TOTAL_INGRESO", SqlDbType.Decimal).Value = valorTotalIngreso
                    .Parameters.AddWithValue("@CANTIDAD_EGRESO", SqlDbType.Int).Value = cantidadEgreso
                    .Parameters.AddWithValue("@VALOR_UNITARIO_EGRESO", SqlDbType.Decimal).Value = valorUnitarioEgreso
                    .Parameters.AddWithValue("@VALOR_TOTAL_EGRESO", SqlDbType.Decimal).Value = valorTotalEgreso
                    .Parameters.AddWithValue("@CANTIDAD_SALDO", SqlDbType.Int).Value = cantidadSaldo
                    .Parameters.AddWithValue("@VALOR_UNITARIO_SALDO", SqlDbType.Decimal).Value = valorUnitarioSaldo
                    .Parameters.AddWithValue("@VALOR_TOTAL_SALDO", SqlDbType.Decimal).Value = valorTotalSaldo
                    .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = fecha
                    .Parameters.AddWithValue("@ID_KARDEX", SqlDbType.BigInt).Value = idKardex
                    .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = estado
                    .Parameters.AddWithValue("@NRO_COMPROBANTE", SqlDbType.NVarChar).Value = nroComprobante
                End With
            Catch
                comando = Nothing
            End Try
            Return comando
        End Function


        Public Function ModificarDetalleKardexCommand() As SqlCommand
            Dim comando As New SqlCommand()
            Try
                With comando
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "ModificarDetalleKardex"
                    .Parameters.AddWithValue("@ID_DETALLE", SqlDbType.BigInt).Value = Id
                    .Parameters.AddWithValue("@ID_ACTIVIDAD", SqlDbType.Int).Value = IdActividad
                    .Parameters.AddWithValue("@ID_CONCEPTO", SqlDbType.Int).Value = IdConcepto
                    .Parameters.AddWithValue("@CANTIDAD_INGRESO", SqlDbType.Int).Value = CantidadIngreso
                    .Parameters.AddWithValue("@VALOR_UNITARIO_INGRESO", SqlDbType.Decimal).Value = ValorUnitarioIngreso
                    .Parameters.AddWithValue("@VALOR_TOTAL_INGRESO", SqlDbType.Decimal).Value = ValorTotalIngreso
                    .Parameters.AddWithValue("@CANTIDAD_EGRESO", SqlDbType.Int).Value = CantidadEgreso
                    .Parameters.AddWithValue("@VALOR_UNITARIO_EGRESO", SqlDbType.Decimal).Value = ValorUnitarioEgreso
                    .Parameters.AddWithValue("@VALOR_TOTAL_EGRESO", SqlDbType.Decimal).Value = ValorTotalEgreso
                    .Parameters.AddWithValue("@CANTIDAD_SALDO", SqlDbType.Int).Value = CantidadSaldo
                    .Parameters.AddWithValue("@VALOR_UNITARIO_SALDO", SqlDbType.Decimal).Value = ValorUnitarioSaldo
                    .Parameters.AddWithValue("@VALOR_TOTAL_SALDO", SqlDbType.Decimal).Value = ValorTotalSaldo
                    .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
                    .Parameters.AddWithValue("@ID_KARDEX", SqlDbType.BigInt).Value = IdKardex
                    .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                    .Parameters.AddWithValue("@NRO_COMPROBANTE", SqlDbType.NVarChar).Value = NroComprobante
                End With
            Catch
                comando = Nothing
            End Try
            Return comando
        End Function


        'Public Function NuevoRegistroDetalleKardex() As SqlCommand
        '    Dim comando = New SqlCommand
        '    With comando 
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "NuevoRegistroDetalleKardex"
        '        .Parameters.AddWithValue("@ID_DETALLE", SqlDbType.BigInt).Value = Id
        '        .Parameters.AddWithValue("@ID_ACTIVIDAD", SqlDbType.Int).Value = IdActividad
        '        .Parameters.AddWithValue("@ID_CONCEPTO", SqlDbType.Int).Value = IdConcepto
        '        .Parameters.AddWithValue("@CANTIDAD_INGRESO", SqlDbType.Int).Value = CantidadIngreso
        '        .Parameters.AddWithValue("@VALOR_UNITARIO_INGRESO", SqlDbType.Decimal).Value = ValorUnitarioIngreso
        '        .Parameters.AddWithValue("@VALOR_TOTAL_INGRESO", SqlDbType.Decimal).Value = ValorTotalIngreso
        '        .Parameters.AddWithValue("@CANTIDAD_EGRESO", SqlDbType.Int).Value = CantidadEgreso
        '        .Parameters.AddWithValue("@VALOR_UNITARIO_EGRESO", SqlDbType.Decimal).Value = ValorUnitarioEgreso
        '        .Parameters.AddWithValue("@VALOR_TOTAL_EGRESO", SqlDbType.Decimal).Value = ValorTotalEgreso
        '        .Parameters.AddWithValue("@CANTIDAD_SALDO", SqlDbType.Int).Value = CantidadSaldo
        '        .Parameters.AddWithValue("@VALOR_UNITARIO_SALDO", SqlDbType.Decimal).Value = ValorUnitarioSaldo
        '        .Parameters.AddWithValue("@VALOR_TOTAL_SALDO", SqlDbType.Decimal).Value = ValorTotalSaldo
        '        .Parameters.AddWithValue("@FECHA", SqlDbType.DateTime).Value = Fecha
        '        .Parameters.AddWithValue("@ID_KARDEX", SqlDbType.BigInt).Value = IdKardex
        '        .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
        '        .Parameters.AddWithValue("@NRO_COMPROBANTE", SqlDbType.NVarChar).Value = NroComprobante
        '    End With
        '    Return comando
        'End Function
          
    End Class
End Namespace