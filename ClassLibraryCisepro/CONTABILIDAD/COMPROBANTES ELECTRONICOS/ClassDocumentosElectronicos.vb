Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPROBANTES_ELECTRONICOS
    Public Class ClassDocumentosElectronicos
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdComprobante As Int64
        Public IdDocumento As Int64
        Public Tipo As String
        Public Documento As String
        Public FechaEmision As DateTime
        Public NumDocumento As String

        Public Function BuscarMayorIdComprobanteElectronico(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT	ID_ARC	=	MAX(ID_ARC) FROM	dbo.DOCUMENTOS_ELECTRONICOS", False)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function GuardarComprobanteElectronico(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into documentos_electronicos values (@ID_ARC, @ID_DOC, @TIPO, @DOCUMENTO, @FECHA_GENERADO, @NUMDOC)"
                .Parameters.AddWithValue("@ID_ARC", SqlDbType.BigInt).Value = IdComprobante
                .Parameters.AddWithValue("@ID_DOC", SqlDbType.Int).Value = IdDocumento
                .Parameters.AddWithValue("@TIPO", SqlDbType.VarChar).Value = Tipo
                .Parameters.AddWithValue("@DOCUMENTO", SqlDbType.NVarChar).Value = Documento
                .Parameters.AddWithValue("@FECHA_GENERADO", SqlDbType.DateTime).Value = FechaEmision
                .Parameters.AddWithValue("@NUMDOC", SqlDbType.VarChar).Value = NumDocumento
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

        Public Function BuscarComprobanteElectronicoByIdComprobanteTipo(ByVal tipoCon As TipoConexion, ByVal tip As String, ByVal idC As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"TIPO", SqlDbType.VarChar, tip})
            pars.Add(New Object() {"ID_DOC", SqlDbType.Int, idC})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from documentos_electronicos where TIPO=@TIPO and ID_DOC=@ID_DOC;", False, pars)
        End Function

    End Class
End Namespace