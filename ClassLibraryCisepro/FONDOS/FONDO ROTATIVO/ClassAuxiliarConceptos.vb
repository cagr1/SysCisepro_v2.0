Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.FONDO_ROTATIVO
    Public Class ClassAuxiliarConceptos
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdConcepto As Integer
        Public NombreConcepto As String
        Public CtaContableConcepto As String
        Public EstadoConcepto As Integer

        Public Function BuscarMayorIdAuxiliarConceptos(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdAuxiliarConceptos", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroAuxiliarConcepto() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroAuxiliarConcepto"
                .Parameters.AddWithValue("@ID_CONCEPTO", SqlDbType.Int).Value = IdConcepto
                .Parameters.AddWithValue("@NOMBRE_CONCEPTO", SqlDbType.NVarChar).Value = NombreConcepto
                .Parameters.AddWithValue("@CTA_CONTABLE_CONCEPTO", SqlDbType.NVarChar).Value = CtaContableConcepto
                .Parameters.AddWithValue("@ESTADO_CONCEPTO", SqlDbType.Int).Value = EstadoConcepto
            End With
            Return comando
        End Function

    End Class
End Namespace
