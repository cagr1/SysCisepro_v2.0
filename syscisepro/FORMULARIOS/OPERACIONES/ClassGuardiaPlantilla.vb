
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
            Dim grupos = lista.
            GroupBy(Function(x) New With {
                x.Cedula,
                x.Sitio,
                x.River,
                x.IdHorario
            }).
            Where(Function(g) g.Count() > 1).  ' Solo grupos con duplicados
            ToList()

            ' Marcar los duplicados como inválidos
            For Each grupo In grupos
                For Each item In grupo
                    item.EsValido = False
                    item.MensajeError = $"Error: {item.Cedula} ya está asignado al horario {item.IdHorario} en {item.Sitio} (River {item.River})"
                Next

            Next

            Return lista

        End Function

        Public Function ValidarEstructuraDatos(lista As List(Of ClassGuardiaPlantilla)) As Boolean
            For Each item In lista
                If String.IsNullOrWhiteSpace(item.Cedula) OrElse
           item.IdHorario <= 0 OrElse
           String.IsNullOrWhiteSpace(item.Sitio) Then
                    Return False
                End If
            Next
            Return True
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
