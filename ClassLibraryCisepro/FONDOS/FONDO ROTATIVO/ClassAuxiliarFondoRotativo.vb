Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.FONDO_ROTATIVO
    Public Class ClassAuxiliarFondoRotativo
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdFondo As Integer
        Public MontoFondo As Decimal
        Public MontoAnteriorFondo As Decimal

        Public Function BuscarMontoAuxiliarFondoRotativo(ByVal tipoCon As TipoConexion) As Decimal
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMontoAuxiliarFondoRotativo", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CDec(data.Rows(0)(0))))
        End Function

        Public Function ActualizarMontoAuxiliarFondoRotativoCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "ActualizarMontoFondoRotativo"
                .Parameters.AddWithValue("@ID_FONDO_ROTATIVO", SqlDbType.Int).Value = IdFondo
                .Parameters.AddWithValue("@MONTO_FONDO_ROTATIVO", SqlDbType.Decimal).Value = MontoFondo
                .Parameters.AddWithValue("@MONTO_ANTERIOR", SqlDbType.Decimal).Value = MontoAnteriorFondo
            End With
            Return comando
        End Function

        Public Function ActualizarMontoAuxiliarFondoRotativoCommand2() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "UPDATE AUXILIAR_FONDO_ROTATIVO SET MONTO_FONDO_ROTATIVO=MONTO_FONDO_ROTATIVO+@MONTO_FONDO_ROTATIVO, MONTO_ANTERIOR=MONTO_FONDO_ROTATIVO WHERE ID_FONDO_ROTATIVO=@ID_FONDO_ROTATIVO;"
                .Parameters.AddWithValue("@ID_FONDO_ROTATIVO", SqlDbType.Int).Value = IdFondo
                .Parameters.AddWithValue("@MONTO_FONDO_ROTATIVO", SqlDbType.Decimal).Value = MontoFondo
            End With
            Return comando
        End Function

    End Class
End Namespace

