Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace VALIDACIONES
    Public Class ClassFoto
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdFoto As Int64
        Public Aux As String
        Public Imagen As Byte()
        Public IdAux As Int64

        Public Function BuscarMayorIdFoto(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_foto=CASE WHEN MAX(id_foto) IS NULL THEN 0 ELSE MAX(id_foto) End FROM FOTO;", False)
            Return If(data.Rows.Count = 0, 0, CInt(data.Rows(0)("id_foto")))
        End Function

        Public Function NuevoRegistroFotoCommands() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.Text
                .CommandText = "insert into FOTO (id_foto, foto, aux, idaux) values (@id_foto, @pic, @aux, @idx);"
                .Parameters.AddWithValue("@id_foto", SqlDbType.Int).Value = IdFoto
                .Parameters.AddWithValue("@pic", SqlDbType.Image).Value = Imagen
                .Parameters.AddWithValue("@aux", SqlDbType.VarChar).Value = Aux
                .Parameters.AddWithValue("@idx", SqlDbType.Int).Value = IdAux
            End With
            Return comando
        End Function

        Public Function BuscarRegistroFoto(ByVal tipoCon As TipoConexion, ByVal aux As String, ByVal idaux As Integer) As DataTable
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"aux", SqlDbType.VarChar, aux})
            pars.Add(New Object() {"idx", SqlDbType.Int, idaux})
            Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from FOTO where aux = @aux and idaux = @idx;", False, pars)
        End Function

    End Class
End Namespace

