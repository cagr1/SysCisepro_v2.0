Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS

Namespace ProcesosSql

    Public Class Conexion
        ''' <summary>
        ''' UNA COMEXION PARA CADA TIPO DE SISTEMA (cada empresa)
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary> 
        Private ReadOnly _connCisepro As SqlConnection
        Private ReadOnly _connSeportpac As SqlConnection
        Private ReadOnly _connAsenava As SqlConnection

        Sub New()
            _connCisepro = New SqlConnection(My.MySettings.Default.SysCiseproConnectionString)
            _connSeportpac = New SqlConnection(My.MySettings.Default.SysSeportpacConnectionString)
            _connAsenava = New SqlConnection(My.MySettings.Default.SysAsenavaConnectionString) 
        End Sub

        Public Function AbrirConexion(ByVal tip As TipoConexion) As SqlConnection
            Dim con As SqlConnection
            Try
                Select Case tip
                    Case TipoConexion.Seportpac
                        con = _connSeportpac
                    Case TipoConexion.Asenava
                        con = _connAsenava
                    Case Else ' CISEPRO
                        con = _connCisepro
                End Select
                If con.State = ConnectionState.Closed Then con.Open()
            Catch ex As Exception
                con = Nothing
                Console.WriteLine(ex.Message)
            End Try
            Return con
        End Function
         
        Public Sub CerrarConexion(ByVal tip As TipoConexion)
            Try 
                Select Case tip
                    Case TipoConexion.Seportpac
                        If Not _connSeportpac Is Nothing And _connSeportpac.State = ConnectionState.Open Then _connSeportpac.Close()
                    Case TipoConexion.Asenava
                        If Not _connAsenava Is Nothing And _connAsenava.State = ConnectionState.Open Then _connAsenava.Close()
                    Case Else ' CISEPRO
                        If Not _connCisepro Is Nothing And _connCisepro.State = ConnectionState.Open Then _connCisepro.Close()
                End Select
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
         
    End Class
End Namespace