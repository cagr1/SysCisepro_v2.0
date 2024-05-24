Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.PERDIDAS_Y_GANANCIAS
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.PERDIDAS_Y_GANANCIAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmBalancePerdidasYGananciasComparativo
        Private _tipoCon As TipoConexion
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

        Dim objEstado As New ClassPerdidasYGanancia
        Dim fechaDesde As String
        Dim fechaHasta As String

        Private Sub btnBuscarMensual_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarMensual.Click
            btnBuscarMensual.Enabled = False
            Button1.Enabled = False
            dtpFechaHasta.Enabled = False

            fechaDesde = Convert.ToDateTime(dtpFechaHasta.Value.Year & "/1/1").ToShortDateString & " 00:00:00"
            fechaHasta = Convert.ToDateTime(dtpFechaHasta.Value.Year & "/" & dtpFechaHasta.Value.Month & "/1").AddMonths(1).AddDays(-1).ToShortDateString & " 23:59:59"

            PictureBox1.Visible = True
            PictureBox1.BackColor = Color.FromArgb(30, Color.White)
            BackgroundWorker1.RunWorkerAsync()

        End Sub
        
        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
            If dgvIngresos.RowCount = 0 Or dgvEgresos.RowCount = 0 Then
                MessageBox.Show("En Ingresos o Egresos no hay datos que exportar!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            ExportarDatosExcelDobleGrid(dgvIngresos, dgvEgresos, "ESTADO DE PERDIDAS Y GANANCIAS")
        End Sub

        Public Sub ExportarDatosExcelDobleGrid(ByVal dgvIngresos As DataGridView, ByVal dgvEgresos As DataGridView, ByVal titulo As String)
            Try
                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "BALANCE_PYG"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvIngresos)
                worksheet.Range("A1:" & ic & (dgvIngresos.RowCount + dgvEgresos.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  " & titulo
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpFechaDesde.Value.ToLongDateString() & "  AL " & dtpFechaHasta.Value.ToLongDateString()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvIngresos.Columns.Count - 1
                    If Not dgvIngresos.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvIngresos.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvIngresos.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvIngresos.Columns.Count - 1

                        If Not dgvIngresos.Columns(j).Visible Then Continue For

                        ' asigna valor a celda
                        worksheet.Cells(i + 1 + headin, indc) = dgvIngresos.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvIngresos.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next


                'Aca se ingresa las columnas
                indc = 1
                headin = dgvIngresos.RowCount + 10
                For i = 0 To dgvEgresos.Columns.Count - 1
                    If Not dgvEgresos.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvEgresos.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvEgresos.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvEgresos.Columns.Count - 1

                        If Not dgvEgresos.Columns(j).Visible Then Continue For

                        ' asigna valor a celda
                        worksheet.Cells(i + 1 + headin, indc) = dgvEgresos.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvEgresos.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                worksheet.Range("A1:" & ic & (dgvIngresos.RowCount + dgvEgresos.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Function LetraColumna(ByVal c As Integer) As String
            Dim letters = New String() {"0", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R"}
            Return letters(c)
        End Function

        Private Sub FrmBalancePerdidasYGananciasComparativo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label2.ForeColor = Color.White
                    Label2.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label3.ForeColor = Color.White
                    Label3.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvEgresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvIngresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    Label2.ForeColor = Color.White
                    Label2.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label3.ForeColor = Color.White
                    Label3.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvEgresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvIngresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    Label2.ForeColor = Color.White
                    Label2.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label3.ForeColor = Color.White
                    Label3.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvEgresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvIngresos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dtpFechaHasta.Value = Convert.ToDateTime(dtpFechaHasta.Value.Year & "/" & dtpFechaHasta.Value.Month & "/1")
        End Sub

        Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
            Dim ingresos = objEstado.SeleccionarEstadoPerdidasGananciasComparativaPorMesesIngresos(_tipoCon, fechaDesde, fechaHasta)
            Dim egresos = objEstado.SeleccionarEstadoPerdidasGananciasComparativaPorMesesEgresos(_tipoCon, fechaDesde, fechaHasta)

            Dim datos As New List(Of DataTable)
            datos.Add(ingresos)
            datos.Add(egresos)
            e.Result = datos
        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
            If e.Result Is Nothing Then
                MessageBox.Show("Error al generar!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Dim datos = CType(e.Result, List(Of DataTable))
            Dim auxData As DataTable
            Try
                dgvIngresos.DataSource = datos(0)
                dgvIngresos.AutoResizeColumns()
                dgvIngresos.Columns("PADRE").Visible = False
                dgvIngresos.Columns("NIVEL").Visible = False

                For Each row As DataGridViewRow In dgvIngresos.Rows
                    If row.Cells("CODIGO").Value Is DBNull.Value Then
                        Continue For
                    End If
                    Dim col = 0.0
                    For i = 4 To dgvIngresos.Columns.Count - 1
                        col = col + Convert.ToDouble(row.Cells(i).Value)
                    Next
                    row.Cells("TOTAL").Value = col
                Next

                auxData = CType(dgvIngresos.DataSource, DataTable)
                For i = 7 To 1 Step -1
                    For Each row As DataGridViewRow In dgvIngresos.Rows
                        For Each drow As DataRow In auxData.Rows
                            If row.Cells("CODIGO").Value = drow("PADRE") And drow("NIVEL") = i Then
                                row.Cells("ENERO").Value = Math.Round((CType(row.Cells("ENERO").Value, Double) + CType(drow("ENERO"), Double)), 2)
                                Try
                                    row.Cells("FEBRERO").Value = Math.Round((CType(row.Cells("FEBRERO").Value, Double) + CType(drow("FEBRERO"), Double)), 2)
                                    row.Cells("MARZO").Value = Math.Round((CType(row.Cells("MARZO").Value, Double) + CType(drow("MARZO"), Double)), 2)
                                    row.Cells("ABRIL").Value = Math.Round((CType(row.Cells("ABRIL").Value, Double) + CType(drow("ABRIL"), Double)), 2)
                                    row.Cells("MAYO").Value = Math.Round((CType(row.Cells("MAYO").Value, Double) + CType(drow("MAYO"), Double)), 2)
                                    row.Cells("JUNIO").Value = Math.Round((CType(row.Cells("JUNIO").Value, Double) + CType(drow("JUNIO"), Double)), 2)
                                    row.Cells("JULIO").Value = Math.Round((CType(row.Cells("JULIO").Value, Double) + CType(drow("JULIO"), Double)), 2)
                                    row.Cells("AGOSTO").Value = Math.Round((CType(row.Cells("AGOSTO").Value, Double) + CType(drow("AGOSTO"), Double)), 2)
                                    row.Cells("SEPTIEMBRE").Value = Math.Round((CType(row.Cells("SEPTIEMBRE").Value, Double) + CType(drow("SEPTIEMBRE"), Double)), 2)
                                    row.Cells("OCTUBRE").Value = Math.Round((CType(row.Cells("OCTUBRE").Value, Double) + CType(drow("OCTUBRE"), Double)), 2)
                                    row.Cells("NOVIEMBRE").Value = Math.Round((CType(row.Cells("NOVIEMBRE").Value, Double) + CType(drow("NOVIEMBRE"), Double)), 2)
                                    row.Cells("DICIEMBRE").Value = Math.Round((CType(row.Cells("DICIEMBRE").Value, Double) + CType(drow("DICIEMBRE"), Double)), 2)
                                Catch
                                End Try
                                row.Cells("TOTAL").Value = Math.Round((CType(row.Cells("TOTAL").Value, Double) + CType(drow("TOTAL"), Double)), 2)
                            End If
                        Next
                    Next
                    auxData = CType(dgvIngresos.DataSource, DataTable)
                Next


                dgvIngresos.FirstDisplayedScrollingRowIndex = dgvIngresos.RowCount - 1
                dgvIngresos.Rows(dgvIngresos.RowCount - 1).Selected = True

            Catch ex As Exception
                MessageBox.Show("Error al generar reporte ingresos: " & ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            Try
                dgvEgresos.DataSource = datos(1)
                dgvEgresos.AutoResizeColumns()
                dgvEgresos.Columns("PADRE").Visible = False
                dgvEgresos.Columns("NIVEL").Visible = False

                For Each row As DataGridViewRow In dgvEgresos.Rows
                    If row.Cells("CODIGO").Value Is DBNull.Value Then
                        Continue For
                    End If
                    Dim col = 0.0
                    For i = 4 To dgvEgresos.Columns.Count - 1
                        col = col + Convert.ToDouble(row.Cells(i).Value)
                    Next
                    row.Cells("TOTAL").Value = col
                Next

                auxData = CType(dgvEgresos.DataSource, DataTable)
                For i = 7 To 1 Step -1
                    For Each row As DataGridViewRow In dgvEgresos.Rows
                        For Each drow As DataRow In auxData.Rows
                            If row.Cells("CODIGO").Value = drow("PADRE") And drow("NIVEL") = i Then
                                row.Cells("ENERO").Value = Math.Round((CType(row.Cells("ENERO").Value, Double) + CType(drow("ENERO"), Double)), 2)
                                Try
                                    row.Cells("FEBRERO").Value = Math.Round((CType(row.Cells("FEBRERO").Value, Double) + CType(drow("FEBRERO"), Double)), 2)
                                    row.Cells("MARZO").Value = Math.Round((CType(row.Cells("MARZO").Value, Double) + CType(drow("MARZO"), Double)), 2)
                                    row.Cells("ABRIL").Value = Math.Round((CType(row.Cells("ABRIL").Value, Double) + CType(drow("ABRIL"), Double)), 2)
                                    row.Cells("MAYO").Value = Math.Round((CType(row.Cells("MAYO").Value, Double) + CType(drow("MAYO"), Double)), 2)
                                    row.Cells("JUNIO").Value = Math.Round((CType(row.Cells("JUNIO").Value, Double) + CType(drow("JUNIO"), Double)), 2)
                                    row.Cells("JULIO").Value = Math.Round((CType(row.Cells("JULIO").Value, Double) + CType(drow("JULIO"), Double)), 2)
                                    row.Cells("AGOSTO").Value = Math.Round((CType(row.Cells("AGOSTO").Value, Double) + CType(drow("AGOSTO"), Double)), 2)
                                    row.Cells("SEPTIEMBRE").Value = Math.Round((CType(row.Cells("SEPTIEMBRE").Value, Double) + CType(drow("SEPTIEMBRE"), Double)), 2)
                                    row.Cells("OCTUBRE").Value = Math.Round((CType(row.Cells("OCTUBRE").Value, Double) + CType(drow("OCTUBRE"), Double)), 2)
                                    row.Cells("NOVIEMBRE").Value = Math.Round((CType(row.Cells("NOVIEMBRE").Value, Double) + CType(drow("NOVIEMBRE"), Double)), 2)
                                    row.Cells("DICIEMBRE").Value = Math.Round((CType(row.Cells("DICIEMBRE").Value, Double) + CType(drow("DICIEMBRE"), Double)), 2)
                                Catch
                                End Try
                                row.Cells("TOTAL").Value = Math.Round((CType(row.Cells("TOTAL").Value, Double) + CType(drow("TOTAL"), Double)), 2)
                            End If
                        Next
                    Next
                    auxData = CType(dgvEgresos.DataSource, DataTable)
                Next

                dgvEgresos.FirstDisplayedScrollingRowIndex = dgvEgresos.RowCount - 1
                dgvEgresos.Rows(dgvEgresos.RowCount - 1).Selected = True

            Catch ex As Exception
                MessageBox.Show("Error al generar reporte egresos: " & ex.Message, "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            PictureBox1.Visible = False
            btnBuscarMensual.Enabled = True
            Button1.Enabled = True
            dtpFechaHasta.Enabled = True
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
            If dgvIngresos.RowCount = 0 Then
                MessageBox.Show("No hay datos que exportar!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            ExportarDatosExcel(dgvIngresos, "INGRESOS")
        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button3.Click
            If dgvEgresos.RowCount = 0 Then
                MessageBox.Show("No hay datos que exportar!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            ExportarDatosExcel(dgvEgresos, "EGRESOS")
        End Sub

        Public Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then
                    MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "BALANCE_PYG"

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
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpFechaDesde.Value.ToLongDateString() & "  AL " & dtpFechaHasta.Value.ToLongDateString()
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
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace