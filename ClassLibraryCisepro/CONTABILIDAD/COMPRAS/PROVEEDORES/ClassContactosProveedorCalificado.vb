Imports System.Data
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace CONTABILIDAD.COMPRAS.PROVEEDORES
    Public Class ClassContactosProveedorCalificado
        ''' <summary>
        ''' ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        ''' SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        ''' CON EL MISMO TIPO DE DATO
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        Public IdContactoProveedorCalificado As Integer
        Public NombresContactoProveedorCalificado As String
        Public ApellidosContactoProveedorCalificado As String
        Public CargoContactoProveedorCalificado As String
        Public TelefonoContactoProveedorCalificado As String
        Public CelularContactoProveedorCalificado As String
        Public EmailContactoProveedorCalificado As String
        Public EstadoContactoProveedorCalificado As Integer
        Public IdProveedorGeneral As Integer

        Public Function BuscarMayorIdContactoProveedorCalificado(ByVal tipoCon As TipoConexion) As Integer
            Dim data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdContactoProveedorCalificado", True)
            Return If(data.Rows.Count = 0, 0, If(IsDBNull(data.Rows(0)(0)), 0, CInt(data.Rows(0)(0))))
        End Function

        Public Function NuevoRegistroContactoProveedorCalificado(ByVal tipoCon As TipoConexion) As Boolean
            Dim comando = New SqlCommand
            With comando
                .CommandType = CommandType.StoredProcedure
                .CommandText = "nuevoRegistroContactoProveedorCalificado"
                .Parameters.AddWithValue("@ID_CONTACTO_PROVEEDOR_CALIFICADO", SqlDbType.Int).Value = IdContactoProveedorCalificado
                .Parameters.AddWithValue("@NOMBRES_CONTACTO_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = NombresContactoProveedorCalificado
                .Parameters.AddWithValue("@APELLIDOS_CONTACTO_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = ApellidosContactoProveedorCalificado
                .Parameters.AddWithValue("@CARGO_CONTACTO_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = CargoContactoProveedorCalificado
                .Parameters.AddWithValue("@TELEFONO_CONTACTO_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = TelefonoContactoProveedorCalificado
                .Parameters.AddWithValue("@CELULAR_CONTACTO_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = CelularContactoProveedorCalificado
                .Parameters.AddWithValue("@EMAIL_CONTACTO_PROVEEDOR_CALIFICADO", SqlDbType.NVarChar).Value = EmailContactoProveedorCalificado
                .Parameters.AddWithValue("@ESTADO_CONTACTO_PROVEEDOR_CALIFICADO", SqlDbType.Int).Value = EstadoContactoProveedorCalificado
                .Parameters.AddWithValue("@ID_PROVEEDOR_GENERAL", SqlDbType.Int).Value = IdProveedorGeneral
            End With
            Return ComandosSql.ProcesarComandoCisepro(tipoCon, comando)
        End Function

    End Class
End Namespace

