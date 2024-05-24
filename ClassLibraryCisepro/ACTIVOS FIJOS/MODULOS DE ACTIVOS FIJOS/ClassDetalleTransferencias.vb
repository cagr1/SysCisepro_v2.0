Imports System.Data
Imports System.Data.SqlClient 

Namespace ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
    Public Class ClassDetalleTransferencias
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdDetalle As Int64
        Public CodigoActivo As String
        Public NombreActivo As String
        Public IdEmpresa As Integer
        Public IdSucursal As Integer
        Public IdGerencias As Integer
        Public IdArea As Integer
        Public Estado As Integer
        Public EstadoTransferencia As String


        Public Function NuevoDetalleTransferencia() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoDetalleTransferencia"
                .Parameters.AddWithValue("@ID_TRANSFERENCIA", SqlDbType.BigInt).Value = IdDetalle
                .Parameters.AddWithValue("@CODIGO_ACTIVO", SqlDbType.NVarChar).Value = CodigoActivo
                .Parameters.AddWithValue("@NOMBRE_ACTIVO", SqlDbType.NVarChar).Value = NombreActivo
                .Parameters.AddWithValue("@ID_EMPRESA", SqlDbType.Int).Value = IdEmpresa
                .Parameters.AddWithValue("@ID_SUCURSAL", SqlDbType.Int).Value = IdSucursal
                .Parameters.AddWithValue("@ID_GERENCIAS", SqlDbType.Int).Value = IdGerencias
                .Parameters.AddWithValue("@ID_AREA", SqlDbType.Int).Value = IdArea
                .Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = Estado
                .Parameters.AddWithValue("@ESTADO_TRANSFERENCIA", SqlDbType.NVarChar).Value = EstadoTransferencia
            End With
            Return comando
        End Function

    End Class
End Namespace

