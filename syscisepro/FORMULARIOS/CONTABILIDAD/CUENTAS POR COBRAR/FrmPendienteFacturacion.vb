Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ENUMS
Imports ClosedXML.Excel
Imports Krypton.Toolkit
Imports syscisepro.DATOS
Imports System.IO
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS

Public Class FrmPendienteFacturacion

    Private _tipoCon As TipoConexion
    ReadOnly _objCliente As New ClassClienteGeneral
    Property TipoCox As Integer
        Get
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Return 2
                Case TipoConexion.Seportpac
                    Return 1
                Case Else
                    Return 0
            End Select
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case 2
                    _tipoCon = TipoConexion.Asenava
                Case 1
                    _tipoCon = TipoConexion.Seportpac
                Case Else
                    _tipoCon = TipoConexion.Cisepro
            End Select
        End Set
    End Property
    Dim _sqlCommands As List(Of SqlCommand)
    Public IdUsuario As Integer
    Private Sub FrmPendienteFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case _tipoCon
            Case TipoConexion.Asenava
                Icon = My.Resources.logo_a
                dgvPendiente.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
            Case TipoConexion.Seportpac
                Icon = My.Resources.logo_s
                dgvPendiente.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
            Case Else
                Icon = My.Resources.logo_c
                dgvPendiente.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
        End Select
        dgvPendiente.Font = New Font("Roboto", 8, FontStyle.Regular)

        llenarPendientes()
    End Sub

    Private Sub dgvPendiente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPendiente.CellContentClick

    End Sub

    Private Sub llenarPendientes()
        Try
            Dim fecha As Date = dtpFecha.Value
            Dim ultimodiames As Integer = Date.DaysInMonth(fecha.Year, fecha.Month)
            Dim FechaDesde = New Date(fecha.Year, fecha.Month, fecha.Day, 0, 0, 0)
            Dim FechaHasta = New Date(fecha.Year, fecha.Month, ultimodiames, 23, 59, 59)
            Dim data = _objCliente.CargarClienteGeneralSinFacturasPorRangoFecha(_tipoCon, FechaDesde, FechaHasta)
            dgvPendiente.DataSource = Nothing
            dgvPendiente.DataSource = data
            dgvPendiente.Columns(0).HeaderText = "Clientes"
            dgvPendiente.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvPendiente.DefaultCellStyle.SelectionForeColor = Color.White
            dgvPendiente.AutoResizeColumns()
        Catch ex As Exception
            KryptonMessageBox.Show("Error al cargar los datos", "Mensaje de error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If dgvPendiente.Rows.Count = 0 Then
                KryptonMessageBox.Show("No hay datos que exportar!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If


            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
            saveFileDialog.Title = "Guardar archivo Excel"
            saveFileDialog.FileName = $"PendienteFactura_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"


            If saveFileDialog.ShowDialog() <> DialogResult.OK Then
                Exit Sub
            End If



            Dim fec = ValidationForms.FechaActual(_tipoCon)
            Dim tituloReporte = ValidationForms.NombreCompany(_tipoCon) & " - " & "Pendiente Facturas"

            ' Crear workbook y worksheet
            Dim workbook As New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add("Pendientes")
            Dim colorSistema As System.Drawing.Color = ValidationForms.GetColorSistema(_tipoCon)
            Dim xlColor As XLColor = XLColor.FromColor(colorSistema)
            ' Definir rango para el título
            Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvPendiente)
            worksheet.Range("A1:" & ic & "1").Merge()
            worksheet.Cell(1, 1).Value = tituloReporte.ToString()
            worksheet.Cell(1, 1).Style.Font.SetBold(True)
            worksheet.Cell(1, 1).Style.Font.SetFontSize(12)
            worksheet.Cell(1, 1).Style.Font.SetFontColor(XLColor.White)
            worksheet.Cell(1, 1).Style.Fill.SetBackgroundColor(xlColor)
            worksheet.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)

            ' Copete
            worksheet.Range("A2:" & ic & "2").Merge()
            'worksheet.Cell(2, 1).Value = $"{cmbBancos.Text} CTA: {cmbCuentaBancos.Text}, PERÍODO: {dtpDesde.Value.ToLongDateString()} AL {dtpHasta.Value.ToLongDateString()}"
            worksheet.Cell(2, 1).Value = $"PERÍODO: AL {fec.ToLongDateString()}"
            worksheet.Cell(2, 1).Style.Font.SetFontSize(12)

            ' Fecha
            worksheet.Range("A3:" & ic & "3").Merge()
            worksheet.Cell(3, 1).Value = $"Fecha de Reporte: {fec.ToLongDateString()} {fec.ToLongTimeString()}"
            worksheet.Cell(3, 1).Style.Font.SetFontSize(12)

            ' Encabezados de columnas
            Dim indc = 1
            Dim headin = 5
            For i = 0 To dgvPendiente.Columns.Count - 1
                If Not dgvPendiente.Columns(i).Visible Then Continue For
                worksheet.Cell(headin, indc).Value = dgvPendiente.Columns(i).HeaderText
                worksheet.Cell(headin, indc).Style.Font.SetBold(True)
                worksheet.Cell(headin, indc).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                worksheet.Cell(headin, indc).Style.Fill.SetBackgroundColor(xlColor)
                worksheet.Cell(headin, indc).Style.Font.SetFontColor(XLColor.White)
                worksheet.Cell(headin, indc).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                indc += 1
            Next

            ' Detalle de datos
            For i = 0 To dgvPendiente.Rows.Count - 1
                indc = 1
                For j = 0 To dgvPendiente.Columns.Count - 1
                    If Not dgvPendiente.Columns(j).Visible Then Continue For

                    ' Asignar valor a la celda
                    Dim cellValue = dgvPendiente.Rows(i).Cells(j).Value
                    ' Establecer bordes
                    Dim cell = worksheet.Cell(i + 1 + headin, indc)

                    If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) Then
                        cell.Value = CDbl(cellValue)

                    Else
                        cell.Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)
                    End If


                    cell.Style.Border.SetLeftBorder(XLBorderStyleValues.Thin)
                    cell.Style.Border.SetRightBorder(XLBorderStyleValues.Thin)

                    If i = dgvPendiente.RowCount - 1 Then
                        cell.Style.Border.SetBottomBorder(XLBorderStyleValues.Thin)
                    End If

                    indc += 1
                Next
            Next

            ' Ajustar columnas automáticamente
            worksheet.Columns("A:" & ic).AdjustToContents()

            ' Guardar el archivo en una ubicación temporal y abrirlo
            Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), saveFileDialog.FileName)
            ' Guardar el archivo en una ubicación temporal
            workbook.SaveAs(saveFileDialog.FileName)

            ' Abrir el archivo Excel automáticamente
            Process.Start(tempFilePath)

            KryptonMessageBox.Show("Datos exportados correctamente", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)



        Catch ex As Exception
            KryptonMessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click

        Me.Close()
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        llenarPendientes()
    End Sub
End Class