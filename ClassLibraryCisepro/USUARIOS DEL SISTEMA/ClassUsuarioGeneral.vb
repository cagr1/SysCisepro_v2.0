Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace USUARIOS_DEL_SISTEMA
    Public Class ClassUsuarioGeneral
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdUsuario As Integer
        Public IdEmpresa As Integer
        Public IdSucursal As Integer
        Public IdArea As Integer
        Public DatosUsuario As String
        Public LoginUsuario As String
        Public PasswordUsuario As String
        Public TipoUsuario As String
        Public EstadoUsuario As Integer
        Public IdPersonal As Integer
        Public IdRol As Integer

        Public Function ModificarPasswordUsuarioGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "modificarPasswordUsuarioGeneral"
                .Parameters.AddWithValue("@ID_USUARIO", SqlDbType.Int).Value = IdUsuario
                .Parameters.AddWithValue("@PASSWORD", SqlDbType.NVarChar).Value = PasswordUsuario
                .Parameters.AddWithValue("@ID_ROL", SqlDbType.Int).Value = IdRol
            End With
            Return comando
        End Function

        Public Function NuevoUsuarioGeneral() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoUsuarioGeneral"
                .Parameters.AddWithValue("@ID_USUARIO", SqlDbType.Int).Value = IdUsuario
                .Parameters.AddWithValue("@ID_EMPRESA ", SqlDbType.Int).Value = IdEmpresa
                .Parameters.AddWithValue("@ID_SUCURSAL", SqlDbType.Int).Value = IdSucursal
                .Parameters.AddWithValue("@ID_AREA", SqlDbType.Int).Value = IdArea
                .Parameters.AddWithValue("@DATOS", SqlDbType.NVarChar).Value = DatosUsuario
                .Parameters.AddWithValue("@LOGIN", SqlDbType.NVarChar).Value = LoginUsuario
                .Parameters.AddWithValue("@PASSWORD", SqlDbType.NVarChar).Value = PasswordUsuario
                .Parameters.AddWithValue("@TIPO_USUARIO", SqlDbType.NVarChar).Value = TipoUsuario
                .Parameters.AddWithValue("@ESTADO", SqlDbType.NVarChar).Value = EstadoUsuario
                .Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.NVarChar).Value = IdPersonal
                .Parameters.AddWithValue("@ID_ROL", SqlDbType.Int).Value = IdRol
            End With
            Return comando
        End Function

        Public Function BuscarMayorIdUsuario(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdUsuario", False)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarUsuarioGeneral(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "seleccionarUsuarioGeneral", False)
        End Function

        Public Function BuscarPasswordPorLogin(ByVal tipoCon As TipoConexion, ByVal nombre As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"LOGIN", SqlDbType.NVarChar, nombre})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarPasswordPorLogin", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function SeleccionarRoles(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_seleccionarRoles", False)
        End Function

        Public Function SeleccionarNombreRol(ByVal tipoCon As TipoConexion, ByVal iduser As Integer) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"@iduser", SqlDbType.VarChar, iduser})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_buscarNombreRol", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        

    End Class
End Namespace

