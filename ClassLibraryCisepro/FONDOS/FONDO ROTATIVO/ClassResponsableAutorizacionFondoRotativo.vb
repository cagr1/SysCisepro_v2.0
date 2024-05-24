Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FONDOS.FONDO_ROTATIVO
    Public Class ClassResponsableAutorizacionFondoRotativo
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdResponsableAutorizacion As Integer
        Public CiResponsableAutorizacion As String
        Public NombreResponsableAutorizacion As String
        Public ApellidoResponsableAutorizacion As String
        Public CargoResponsableAutorizacion As String
        Public EstadoResponsableAutorizacion As Integer
        Public IdProvincia As Integer
        Public IdCiudad As Integer
        Public IdParroquia As Integer

        Public Function SeleccionarResponsablesAutorizacionFondoRotativo(ByVal tipoCon As TipoConexion) As DataTable
            Return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarResponsablesAutorizacionFondoRotativo", True)
        End Function

        Public Function BuscarMayorIdResponsablesAutorizacionForndoRotativo(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdResponsablesAutorizacionForndoRotativo", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function BuscarIdResponsablesFondoRotativoXCargo(ByVal tipoCon As TipoConexion, ByVal cargoRespCedula As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CARGO_RESPONSABLE_AUTO_FR", SqlDbType.NVarChar, cargoRespCedula})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT ID_RESPONSABLE_AUTO_FR FROM RESPONSABLE_AUTORIZACION_FONDO_ROTATIVO WHERE CARGO_RESPONSABLE_AUTO_FR = @CARGO_RESPONSABLE_AUTO_FR", False, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarCedulaResponsablesFondoRotativoXCargo(ByVal tipoCon As TipoConexion, ByVal cargoRespCedula As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CARGO_RESPONSABLE_AUTO_FR", SqlDbType.NVarChar, cargoRespCedula})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarCedulaResponsablesFondoRotativoXCargo", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarNombreResponsablesFondoRotativoXCargo(ByVal tipoCon As TipoConexion, ByVal cargoRespNombre As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CARGO_RESPONSABLE_AUTO_FR", SqlDbType.NVarChar, cargoRespNombre})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarNombreResponsablesFondoRotativoXCargo", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function BuscarApellidoResponsablesFondoRotativoXCargo(ByVal tipoCon As TipoConexion, ByVal cargoRespNombre As String) As String
            Dim pars = New List(Of Object())
            pars.Add(New Object() {"CARGO_RESPONSABLE_AUTO_FR", SqlDbType.NVarChar, cargoRespNombre})
            Dim data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarApellidoResponsablesFondoRotativoXCargo", True, pars)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), String.Empty, CStr(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroResponsablesAutorizacionForndoRotativo() As SqlCommand
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "NuevoRegistroResponsablesAutorizacionForndoRotativo"
                .Parameters.AddWithValue("@ID_RESPONSABLE_AUTO_FR", SqlDbType.Int).Value = IdResponsableAutorizacion
                .Parameters.AddWithValue("@CI_RESPONSABLE_AUTO_FR", SqlDbType.NVarChar).Value = CiResponsableAutorizacion
                .Parameters.AddWithValue("@NOMBRE_RESPONSABLE_AUTO_FR", SqlDbType.NVarChar).Value = NombreResponsableAutorizacion
                .Parameters.AddWithValue("@APELLIDO_RESPONSABLE_AUTO_FR", SqlDbType.NVarChar).Value = ApellidoResponsableAutorizacion
                .Parameters.AddWithValue("@CARGO_RESPONSABLE_AUTO_FR", SqlDbType.NVarChar).Value = CargoResponsableAutorizacion
                .Parameters.AddWithValue("@ESTADO_RESPONSABLE_AUTO_FR", SqlDbType.Int).Value = EstadoResponsableAutorizacion
                .Parameters.AddWithValue("@ID_PROVINCIAS", SqlDbType.Int).Value = IdProvincia
                .Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudad
                .Parameters.AddWithValue("@ID_PARROQUIAS", SqlDbType.Int).Value = IdParroquia
            End With
            Return comando
        End Function

    End Class
End Namespace

