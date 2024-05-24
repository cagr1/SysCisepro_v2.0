Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.CAJA_CHICA
    Public Class ClassAuxiliarCajaChica
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdCajaChica As Integer
        Public MontoCajaChica As Decimal
        Public MontoAnterior As Decimal 
         
        Public Function BuscarMontoCajaChicaXidCajaChica(ByVal tipoCon As TipoConexion, ByVal idCajaChica As String) As Decimal
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"ID_CAJA_CHICA", SqlDbType.NVarChar, idCajaChica})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarMontoCajaChicaXidCajaChica", True, pars) 
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CDec(data.Rows(0)(0))))
        End Function

        Public Function ActualizarMontosCajaChicaCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "actualizarMontosCajaChica"
                .Parameters.AddWithValue("@ID_CAJA_CHICA", SqlDbType.Int).Value = IdCajaChica
                .Parameters.AddWithValue("@MONTO_CAJA_CHICA", SqlDbType.Decimal).Value = MontoCajaChica
                .Parameters.AddWithValue("@MONTO_ANTERIOR", SqlDbType.NVarChar).Value = MontoAnterior
            End With
            Return comando
        End Function

        Public Function ActualizarMontosCajaChica2Command() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE AUXILIAR_CAJA_CHICA SET MONTO_CAJA_CHICA=MONTO_CAJA_CHICA+@MONTO_CAJA_CHICA, MONTO_ANTERIOR=MONTO_CAJA_CHICA WHERE ID_CAJA_CHICA=@ID_CAJA_CHICA;"
                .Parameters.AddWithValue("@ID_CAJA_CHICA", SqlDbType.Int).Value = IdCajaChica
                .Parameters.AddWithValue("@MONTO_CAJA_CHICA", SqlDbType.Decimal).Value = MontoCajaChica
            End With
            Return comando
        End Function

    End Class
End Namespace

