Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS
Imports Microsoft.Office.Interop
Imports Krypton.Toolkit

Namespace FORMULARIOS.CONTABILIDAD.AUXILIARES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAuxiliaresVentas
        Private _tipoCon As TipoConexion
        Property TipoCox As Integer
            Private Get
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

        ReadOnly _objFact As New ClassFacturaVenta
        ReadOnly _objetoNumeroRegistroAsientoCompCompra As New ClassNumeroRegistroAsientoFacturaVenta
        ReadOnly _objetoAjustarAsientos As New ClassAjustarAsientosLibroDiario

        '===============================================================================================================================================================================================================
        Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
            '=========================================================================================================================================================================
            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            Dim fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00.001"
            Dim fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59.000"
            dgvFacturas.DataSource = _objFact.SeleccionarVentasXFechaAuxiliar(_tipoCon, fechaDesde, fechaHasta)
            dgvFacturas.AutoResizeColumns()
            dgvFacturas.AutoResizeRows()
            dgvFacturas.ReadOnly = True
        End Sub

        Private Sub FormAuxiliaresVentas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFacturas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvFacturas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvFacturas.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvFacturas.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvAsientoDiario.Font = New Font("Roboto", 8, FontStyle.Regular)
        End Sub

        Private Sub dgvFacturas_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturas.SelectionChanged
            If dgvFacturas.RowCount = 0 Or dgvFacturas.CurrentRow Is Nothing Then Return

            Try
                cargarComprobanteRetencion()
                If dgvComprobanteRetencion.RowCount > 0 Then
                    lblIdComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(0).Value
                    lblNumeroComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(1).Value
                    cargarDetalleComprobanteRetencion()
                Else
                    lblIdComprobanteRetencion.Text = "..."
                    lblNumeroComprobanteRetencion.Text = ""
                    dgvComprobanteRetencion.DataSource = Nothing
                    dgvDetalleComprobanteRetencion.DataSource = Nothing
                End If

                Dim n = _objetoNumeroRegistroAsientoCompCompra.BuscarNumeroRegistroAsientoPorIdFactura(_tipoCon, dgvFacturas.CurrentRow.Cells.Item(0).Value)
                If n <> Nothing Then
                    lblNumeroRegistro.Text = n
                    dgvAsientoDiario.DataSource = _objetoAjustarAsientos.BuscarAsientosLibroDiarioResumidoXNumeroRegistro(_tipoCon, lblNumeroRegistro.Text)
                    dgvAsientoDiario.AutoResizeColumns()
                    dgvAsientoDiario.AutoResizeRows()
                Else
                    lblNumeroRegistro.Text = "0"
                    dgvAsientoDiario.DataSource = Nothing
                End If
            Catch
                dgvDetalleComprobanteRetencion.DataSource = Nothing
                dgvAsientoDiario.DataSource = Nothing
            End Try
        End Sub

        Public Sub cargarComprobanteRetencion()
            Try
                dgvComprobanteRetencion.DataSource = _objFact.SeleccionarComrpobantesRetencionXIdFacturaVenta(_tipoCon, dgvFacturas.CurrentRow.Cells.Item(0).Value)
                dgvComprobanteRetencion.AutoResizeColumns()
                dgvComprobanteRetencion.AutoResizeRows()
                dgvComprobanteRetencion.ReadOnly = True
            Catch ex As Exception
                dgvComprobanteRetencion.DataSource = Nothing

                KryptonMessageBox.Show("Metodo cargar comprobante de retención" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub cargarDetalleComprobanteRetencion()
            Try
                dgvDetalleComprobanteRetencion.DataSource = _objFact.SeleccionarRegistrosDetalleComprobanteRetencionCompraXIdFacturaVenta(_tipoCon, dgvFacturas.CurrentRow.Cells.Item(0).Value)
                dgvDetalleComprobanteRetencion.Columns(0).HeaderText = "ID"
                dgvDetalleComprobanteRetencion.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(0).ReadOnly = True
                dgvDetalleComprobanteRetencion.Columns(1).HeaderText = "EJERCICIO FISCAL"
                dgvDetalleComprobanteRetencion.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(1).ReadOnly = True
                dgvDetalleComprobanteRetencion.Columns(2).HeaderText = "CODIGO"
                dgvDetalleComprobanteRetencion.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(2).ReadOnly = True
                dgvDetalleComprobanteRetencion.Columns(3).HeaderText = "BASE IMPONIBLE"
                dgvDetalleComprobanteRetencion.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvDetalleComprobanteRetencion.Columns(3).ReadOnly = True
                dgvDetalleComprobanteRetencion.Columns(4).HeaderText = "IMPUESTO"
                dgvDetalleComprobanteRetencion.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(4).ReadOnly = True
                dgvDetalleComprobanteRetencion.Columns(5).HeaderText = "% DE RETENCIÓN"
                dgvDetalleComprobanteRetencion.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(5).ReadOnly = True
                dgvDetalleComprobanteRetencion.Columns(6).HeaderText = "VALOR RETENIDO"
                dgvDetalleComprobanteRetencion.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvDetalleComprobanteRetencion.Columns(6).ReadOnly = True
                dgvDetalleComprobanteRetencion.Columns(7).HeaderText = "EST"
                dgvDetalleComprobanteRetencion.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(7).ReadOnly = True
                dgvDetalleComprobanteRetencion.Columns(8).HeaderText = "ID CR"
                dgvDetalleComprobanteRetencion.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(8).ReadOnly = True
                dgvDetalleComprobanteRetencion.Columns(9).HeaderText = "ID FV"
                dgvDetalleComprobanteRetencion.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.AutoResizeColumns()
                dgvDetalleComprobanteRetencion.AutoResizeRows()
                dgvDetalleComprobanteRetencion.ReadOnly = True
            Catch ex As Exception

                KryptonMessageBox.Show("Metodo cargar detalle comprobante de retención" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            If dgvFacturas.Rows.Count = 0 Then

                KryptonMessageBox.Show("No hay datos que exportar! Primero realice una busqueda", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If
            ExportarDatosExcel(dgvFacturas, "FACTURAS DE VENTA", "FACTURAS_VENTA")
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            If dgvDetalleComprobanteRetencion.Rows.Count = 0 Then

                KryptonMessageBox.Show("No hay datos que exportar! Primero realice una busqueda", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If
            ExportarDatosExcel(dgvDetalleComprobanteRetencion, "RETENCIÓN EN VENTA", "RETENCION_VENTA")
        End Sub

        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            If dgvAsientoDiario.Rows.Count = 0 Then

                KryptonMessageBox.Show("No hay datos que exportar! Primero realice una busqueda", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If
            ExportarDatosExcel(dgvAsientoDiario, "ASIENTOS DIARIO DE VENTA", "LIBRO_DARIO")
        End Sub

        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String, ByVal sname As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then

                    KryptonMessageBox.Show("No hay datos que exportar!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)
                
                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = sname

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  " & titulo
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpInicio.Value.ToLongDateString() & "  AL " & dtpFinal.Value.ToLongDateString()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvAsientosDiario.Columns.Count - 1
                    If Not dgvAsientosDiario.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvAsientosDiario.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvAsientosDiario.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvAsientosDiario.Columns.Count - 1

                        If Not dgvAsientosDiario.Columns(j).Visible Then Continue For

                        ' asigna valor a celda
                        worksheet.Cells(i + 1 + headin, indc) = dgvAsientosDiario.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvAsientosDiario.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next
                 
                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception

                KryptonMessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace