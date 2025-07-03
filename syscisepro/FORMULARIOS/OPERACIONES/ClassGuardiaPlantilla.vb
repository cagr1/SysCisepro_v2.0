
Imports ClosedXML.Excel
Imports System.Data
Imports Krypton.Toolkit

Namespace FORMULARIOS.OPERACIONES
    Public Class ClassGuardiaPlantilla
        Public Property Cedula As String
        Public Property IdHorario As Integer
        Public Property Sitio As String
        Public Property River As String
        Public Property EsValido As Boolean
        Public Property MensajeError As String


        Public Function LeerExcel(ruta As String) As List(Of ClassGuardiaPlantilla)
            Dim lista As New List(Of ClassGuardiaPlantilla)
            Try
                Using workbook As New XLWorkbook(ruta)
                    Dim worksheet = workbook.Worksheet(1)
                    Dim lastRow = worksheet.LastRowUsed().RowNumber()

                    For i As Integer = 2 To lastRow
                        ' Leer la cédula como texto para preservar el cero inicial
                        Dim cedulaTexto As String = worksheet.Cell(i, 1).Value.ToString().Trim()

                        ' Si la cédula es un número, asegurarse de que tenga 10 dígitos
                        If IsNumeric(cedulaTexto) AndAlso cedulaTexto.Length < 10 Then
                            cedulaTexto = cedulaTexto.PadLeft(10, "0"c)
                        End If

                        ' Leer River como texto también por si tiene formato especial
                        Dim riverTexto As String = worksheet.Cell(i, 4).GetString().Trim()

                        Dim item As New ClassGuardiaPlantilla With {
                            .Cedula = cedulaTexto,
                            .IdHorario = worksheet.Cell(i, 2).GetValue(Of Integer)(),
                            .Sitio = worksheet.Cell(i, 3).GetText().Trim(),
                            .River = riverTexto,
                            .EsValido = True,
                            .MensajeError = ""
                        }
                        lista.Add(item)
                    Next
                End Using
            Catch ex As Exception
                KryptonMessageBox.Show("Error al leer el archivo de excel: " & ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
            Return lista
        End Function

        Public Function ValidarDuplicados(lista As List(Of ClassGuardiaPlantilla)) As List(Of ClassGuardiaPlantilla)
            For i As Integer = 0 To lista.Count - 1
                Dim itemActual = lista(i)

                ' Buscar duplicados (misma cedula, sitio y river pero diferente horario)
                Dim duplicados As List(Of ClassGuardiaPlantilla) = lista.Where(Function(x) x.Cedula = itemActual.Cedula AndAlso x.Sitio = itemActual.Sitio AndAlso x.River = itemActual.River AndAlso x.IdHorario <> itemActual.IdHorario).ToList()

                If duplicados.Count > 0 Then
                    itemActual.EsValido = False
                    itemActual.MensajeError = String.Format("Usuario {0} tiene múltiples horarios para {1} - {2}", itemActual.Cedula, itemActual.Sitio, itemActual.River)
                End If
            Next

            Return lista

        End Function

        Public Function ConvertirADataTable(lista As List(Of ClassGuardiaPlantilla)) As DataTable
            Dim dt As New DataTable()

            dt.Columns.Add("Cedula", GetType(String))
            dt.Columns.Add("IdHorario", GetType(Integer))
            dt.Columns.Add("Sitio", GetType(String))
            dt.Columns.Add("River", GetType(String))
            dt.Columns.Add("EsValido", GetType(Boolean))
            dt.Columns.Add("MensajeError", GetType(String))

            For Each item In lista
                dt.Rows.Add(item.Cedula, item.IdHorario, item.Sitio, item.River, item.EsValido, item.MensajeError)
            Next

            Return dt
        End Function


    End Class
End Namespace
