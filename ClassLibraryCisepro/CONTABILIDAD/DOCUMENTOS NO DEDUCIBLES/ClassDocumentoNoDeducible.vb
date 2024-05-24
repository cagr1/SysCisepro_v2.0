Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.DOCUMENTOS_NO_DEDUCIBLES
    Public Class ClassDocumentoNoDeducible
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdDocumentoNo As Int64
        Public NumeroDocumentoNo As Int64
        Public FechaDocumentoNo As Date
        Public DescripcionDocumentoNo As String
        Public ValorDocumentoNo As Decimal
        Public EstadoDocumentoNo As Integer
        Public Idparametro As Integer
        Public IdSolicitudFondo As Int64
        Public IdSolicitudCaja As Int64

        Public Function ExisteNumDocumentoNoDeducible(ByVal tipoCon As TipoConexion, ByVal parametroBusqueda As Integer) As Boolean
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"NUM", SqlDbType.BigInt, parametroBusqueda})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from documento_nodeducible where numero_documento_nodeducible = @NUM and estado_documento_nodeducible=1;", False, pars)
            Return data.Rows.Count <> 0 AndAlso Not IsDBNull(data.Rows(0)(0))
        End Function

        Public Function BuscarMayorIdDocumentoNoDeducible(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdDocumentoNoDeducible", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function ActualizarEstadoDetalleDocumentoByIdDocumento() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "update DOCUMENTO_NODEDUCIBLE set ESTADO_DOCUMENTO_NODEDUCIBLE=@ESTADO_DOCUMENTO_NODEDUCIBLE where ID_DOCUMENTO_NODEDUCIBLE=@ID_DOCUMENTO_NODEDUCIBLE;"
                .Parameters.AddWithValue("@ID_DOCUMENTO_NODEDUCIBLE", SqlDbType.BigInt).Value = IdDocumentoNo
                .Parameters.AddWithValue("@ESTADO_DOCUMENTO_NODEDUCIBLE", SqlDbType.Int).Value = EstadoDocumentoNo
            End With
            Return comando
        End Function

        Public Function NuevoRegistroDocumentoNoDeducibleCommand() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroDocumentoNoDeducible"
                .Parameters.AddWithValue("@ID_DOCUMENTO_NODEDUCIBLE", SqlDbType.BigInt).Value = IdDocumentoNo
                .Parameters.AddWithValue("@NUMERO_DOCUMENTO_NODEDUCIBLE", SqlDbType.NVarChar).Value = NumeroDocumentoNo
                .Parameters.AddWithValue("@FECHA_DOCUMENTO_NODEDUCIBLE", SqlDbType.DateTime).Value = FechaDocumentoNo
                .Parameters.AddWithValue("@DESCRIPCION_DOCUMENTO_NODEDUCIBLE", SqlDbType.NVarChar).Value = DescripcionDocumentoNo
                .Parameters.AddWithValue("@VALOR_DOCUMENTO_NODEDUCIBLE", SqlDbType.Decimal).Value = ValorDocumentoNo
                .Parameters.AddWithValue("@ESTADO_DOCUMENTO_NODEDUCIBLE", SqlDbType.Int).Value = EstadoDocumentoNo
                .Parameters.AddWithValue("@ID_PARAMETRO_DOCUMENTOS", SqlDbType.Int).Value = Idparametro
                .Parameters.AddWithValue("@ID_SOLICITUD_FR", SqlDbType.BigInt).Value = IdSolicitudFondo
                .Parameters.AddWithValue("@ID_SOLICITUD_CCH", SqlDbType.BigInt).Value = IdSolicitudCaja
            End With
            Return comando
        End Function

    End Class
End Namespace

