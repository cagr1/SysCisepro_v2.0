Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS

Namespace ProcesosSql

    Public Class ComandosSql
        ''' <summary>
        ''' ESTA CLASE ES ESPECIALMENTE DISEÑADA PARA PROCESAR TODAS LAS SENTENCIAS SQL DE CUALQUIER FORMULARIO, DE TAL MANERA QUE SE CUMPLA
        ''' LA INTEGRIDAD DE LA INFORMACIÓN. ES DECIR, SE PROCESAN TODAS LAS TRANSACCIONES O NO SE PROCESA NINGUNA, ASÍ EVITAMOS DESCUADRES DE LA BASE DE DATOS
        ''' Y LAS TABLAS QUE ESTAN RELACIONADAS
        ''' TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary> 
        Private Shared ReadOnly Conexion As New Conexion

        Public Shared Sub Salir(ByVal tip As TipoConexion)
            Conexion.CerrarConexion(tip)
        End Sub

        Public Shared Function SeleccionarQueryToDataAdapter(ByVal tip As TipoConexion, ByVal query As String, ByVal esProcesoAlmacenado As Boolean) As SqlDataAdapter
            Dim adapter = New SqlDataAdapter()
            Try
                Using cmd = New SqlCommand(query, Conexion.AbrirConexion(tip))
                    cmd.CommandType = If(esProcesoAlmacenado, CommandType.StoredProcedure, CommandType.Text)
                    adapter = New SqlDataAdapter(cmd)
                End Using
            Catch ex As Exception
                Console.Write(ex.Message)
            End Try
            Return adapter
        End Function

        Public Shared Function SeleccionarQueryToDataTable(ByVal tip As TipoConexion, ByVal query As String, ByVal esProcesoAlmacenado As Boolean) As DataTable
            Dim table = New DataTable
            Try
                Using cmd = New SqlCommand(query, Conexion.AbrirConexion(tip))
                    cmd.CommandType = If(esProcesoAlmacenado, CommandType.StoredProcedure, CommandType.Text)
                    Using adapter = New SqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using
                End Using
            Catch ex As Exception
                Console.Write(ex.Message)
            End Try
            Return table
        End Function

        Public Shared Function SeleccionarQueryWithParamsToDataAdapter(ByVal tip As TipoConexion, ByVal query As String, ByVal esProcesoAlmacenado As Boolean, ByVal pars As List(Of Object())) As SqlDataAdapter
            Dim adapter = New SqlDataAdapter()
            Try
                Using cmd = New SqlCommand(query, Conexion.AbrirConexion(tip))
                    cmd.CommandType = If(esProcesoAlmacenado, CommandType.StoredProcedure, CommandType.Text)
                    If pars.Count > 0 Then
                        For Each par As Object In pars
                            cmd.Parameters.AddWithValue(CType(par(0), String), CType(par(1), SqlDbType)).Value = par(2)
                        Next
                    End If
                    adapter = New SqlDataAdapter(cmd)
                End Using
            Catch ex As Exception
                Console.Write(ex.Message)
            End Try
            Return adapter
        End Function

        Public Shared Function SeleccionarQueryWithParamsToDataTable(ByVal tip As TipoConexion, ByVal query As String, ByVal esProcesoAlmacenado As Boolean, ByVal pars As List(Of Object())) As DataTable
            Dim table = New DataTable
            Try
                Using cmd = New SqlCommand(query, Conexion.AbrirConexion(tip))
                    cmd.CommandType = If(esProcesoAlmacenado, CommandType.StoredProcedure, CommandType.Text)
                    If pars.Count > 0 Then
                        For Each par As Object In pars
                            cmd.Parameters.AddWithValue(CType(par(0), String), CType(par(1), SqlDbType)).Value = par(2)
                        Next
                    End If

                    Using adapter = New SqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using
                End Using
            Catch ex As Exception
                Console.Write(ex.Message)
            End Try
            Return table
        End Function

        Public Shared Function ProcesarComandoCisepro(ByVal tip As TipoConexion, ByVal command As SqlCommand) As Boolean
            Dim result = False
            Try
                Dim con = Conexion.AbrirConexion(tip)
                command.Connection = con
                command.ExecuteNonQuery()
                result = True
            Catch ex As Exception
                Console.WriteLine("Error al procesar comando simple: " + ex.Message)
            End Try
            Return result
        End Function


        Public Shared Function ProcesarTransacciones(ByVal tip As TipoConexion, ByVal querys As List(Of SqlCommand), ByVal tag As String) As Object()
            Dim res() As Object = {False, ""}
            Dim trans As SqlTransaction = Nothing
            Dim qr = String.Empty
            Const max As Integer = 3000
            Try
                Dim con = Conexion.AbrirConexion(tip)
                trans = con.BeginTransaction()

                ' LOG (GUARDA LAS SENTENCIAS EJECUTADAS EN CADA PROCESO, PARA MANTENIMIENTO)
                Dim query As String
                Dim r = String.Empty
                For Each sql As SqlCommand In querys
                    If sql.CommandText.Contains("@") Then
                        query = sql.Parameters.Cast(Of Object)().Aggregate(sql.CommandText, Function(current, par) current.Replace(par.ParameterName, String.Concat("'", par.Value, "'")))
                        r += query + ";"
                    Else
                        r += sql.CommandText + ";"
                    End If

                    If r.Length > max Then
                        r = r.Substring(0, max)
                        Exit For ' Stop further additions once truncated
                    End If

                Next
                r = r.Replace("'", "")

                Dim c = New SqlCommand()
                c.CommandType = CommandType.Text
                c.CommandText = "INSERT INTO LOGSQL VALUES(dbo.MaxIdLog(), '" + tag + "', '" + r + "', getDate());"
                querys.Add(c)

                For Each sql As SqlCommand In querys
                    qr = sql.CommandText
                    sql.Connection = con
                    sql.Transaction = trans
                    sql.ExecuteNonQuery()
                Next

                trans.Commit()
                res(0) = True
                res(1) = "Transacción procesada correctamente!"
            Catch ext As SqlException
                Console.WriteLine("SqlException: " & qr)
                res(0) = False
                res(1) = "Error al procesar la transacción: " & ext.Message
                If Not trans Is Nothing Then trans.Rollback()
            Catch exr As Exception
                Console.WriteLine("Exception: " & qr)
                res(0) = False
                res(1) = "Error al procesar la transacción: " & exr.Message
                If Not trans Is Nothing Then trans.Rollback()
            End Try
            Return res
        End Function

    End Class
End Namespace