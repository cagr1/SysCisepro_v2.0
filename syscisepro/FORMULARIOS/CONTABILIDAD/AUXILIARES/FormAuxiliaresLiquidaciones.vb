Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.CAJA_CHICA
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.AUXILIARES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAuxiliaresLiquidaciones

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
      
        ReadOnly _objLiqC As New ClassLiquidacionCajaChica
        ReadOnly _objLiqF As New ClassLiquidacionFondoRotativo
        ReadOnly _objSolC As New ClassSolicitudCajaChica
        ReadOnly _objSolF As New ClassSolicitudFondoRotativo
        ReadOnly _objAsi As New ClassAsientosLibroDiario


        Private Sub CargarSolicitudesXidLiquidacionC(ByVal idLiquidacion As Integer)
            Try
                dgvSolicitudes.DataSource = _objSolC.SeleccionarSolicitudesXIdLiquidacion(_tipoCon, idLiquidacion)
                dgvSolicitudes.AutoResizeColumns()
                dgvSolicitudes.AutoResizeRows()
            Catch
                dgvSolicitudes.DataSource = Nothing
            End Try

        End Sub

        Private Sub CargarSolicitudesXidLiquidacionF(ByVal idLiquidacion As Integer)
            Try
                dgvSolicitudes.DataSource = _objSolF.SeleccionarSolicitudesFrXIdLiquidacion(_tipoCon, idLiquidacion)
                dgvSolicitudes.AutoResizeColumns()
                dgvSolicitudes.AutoResizeRows()
            Catch
                dgvSolicitudes.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarAsientoxNroAsiento(ByVal nroAsiento As Int64)
            Try
                dgvAsiento.DataSource = _objAsi.BuscarAsientosLibroDiarioXNumeroRegistroAuxiliaresLiquidacion(_tipoCon, nroAsiento)
                dgvAsiento.AutoResizeColumns()
                dgvAsiento.AutoResizeRows()
            Catch
                dgvAsiento.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarLiquidacionesC()
            Try
                Dim fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00.001"
                Dim fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59.000"

                dgvLiquidaciones.DataSource = _objLiqC.SeleccionarLiquidacionesCajaChicaTodasRangoFecha(_tipoCon, fechaDesde, fechaHasta)
                dgvLiquidaciones.AutoResizeRows()
                dgvLiquidaciones.AutoResizeColumns()
            Catch
                dgvLiquidaciones.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarLiquidacionesF()
            Try
                Dim fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00.001"
                Dim fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59.000"

                dgvLiquidaciones.DataSource = _objLiqF.SeleccionarLiquidacionesFondoRotativoTodasRangoFecha(_tipoCon, fechaDesde, fechaHasta)
                dgvLiquidaciones.AutoResizeRows()
                dgvLiquidaciones.AutoResizeColumns()
            Catch
                dgvLiquidaciones.DataSource = Nothing
            End Try
        End Sub

        Private Sub rbCaja_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbCaja.CheckedChanged
            If rbCaja.Checked Then cargarLiquidacionesC()
        End Sub

        Private Sub rbFondo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbFondo.CheckedChanged
            If rbFondo.Checked Then CargarLiquidacionesF() 
        End Sub
      
        Private Sub FormAuxiliaresLiquidaciones_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsiento.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSolicitudes.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvLiquidaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsiento.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSolicitudes.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvLiquidaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsiento.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSolicitudes.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvLiquidaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvAsiento.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvSolicitudes.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvLiquidaciones.Font = New Font("Roboto", 8, FontStyle.Regular)
        End Sub

        Private Sub dgvLiquidaciones_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvLiquidaciones.SelectionChanged
            If dgvLiquidaciones.RowCount = 0 Then Return
            If dgvLiquidaciones.CurrentRow Is Nothing Then Return
            If rbCaja.Checked Then
                CargarSolicitudesXidLiquidacionC(dgvLiquidaciones.CurrentRow.Cells.Item(0).Value)
                CargarAsientoxNroAsiento(dgvLiquidaciones.CurrentRow.Cells.Item("NRO").Value)
            End If

            If rbFondo.Checked Then
                CargarSolicitudesXidLiquidacionF(dgvLiquidaciones.CurrentRow.Cells.Item(0).Value)
                CargarAsientoxNroAsiento(dgvLiquidaciones.CurrentRow.Cells.Item("NRO").Value) 
            End If

            Dim debe As Decimal = 0.0
            Dim haber As Decimal = 0.0
            Try
                For indice = 0 To dgvAsiento.Rows.Count - 1 Step 1
                    debe += CDec(dgvAsiento.Rows(indice).Cells(10).Value)
                    haber += CDec(dgvAsiento.Rows(indice).Cells(11).Value)
                Next
            Catch
                debe = 0
                haber = 0
            End Try
            txtDebe.Text = debe
            txtHaber.Text = haber

            Dim suma As Decimal
            Try
                For indice = 0 To dgvSolicitudes.Rows.Count - 1 Step 1
                    suma = suma + Convert.ToDecimal(dgvSolicitudes.Rows(indice).Cells(4).Value)
                Next
            Catch
                suma = 0
            End Try
            txtTotal.Text = suma
            txtCantidad.Text = dgvSolicitudes.Rows.Count
        End Sub

        Private Sub btnCuadrar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCuadrar.Click
            If rbCaja.Checked Then
                cargarLiquidacionesC()
            ElseIf rbFondo.Checked Then
                cargarLiquidacionesF()
            End If 
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            If dgvLiquidaciones.Rows.Count = 0 Then
                MsgBox("NO HAY DATOS QUE EXPORTAR! PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If
            ExportarDatosExcel(dgvLiquidaciones, "LIQUIDACIONES" & (If(rbCaja.Checked, " CAJA", " FONDO")), "LIQUIDACIONES" & (If(rbCaja.Checked, "_CAJA", "_FONDO")))
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            If dgvAsiento.Rows.Count = 0 Then
                MsgBox("NO HAY DATOS QUE EXPORTAR! PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If
            ExportarDatosExcel(dgvAsiento, "ASIENTOS DIARIO", "LIBRO_DARIO")
        End Sub

        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem3.Click
            If dgvSolicitudes.Rows.Count = 0 Then
                MsgBox("NO HAY DATOS QUE EXPORTAR! PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If
            ExportarDatosExcel(dgvSolicitudes, "SOLICITUDES FONDO" & (If(rbCaja.Checked, " CAJA", " ROTATIVO")), "SOLICITUDES" & (If(rbCaja.Checked, "_CAJA", "_FONDO")))
        End Sub

        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String, ByVal sname As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then
                    MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
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

                If sname.Equals("LIBRO_DARIO") Then
                    ' TOTALES, ETC
                    Dim foot = headin + dgvAsientosDiario.RowCount + 3
                    worksheet.Cells(foot, 7).Value = "TOTAL DEBE"
                    worksheet.Cells(foot, 7).Font.Bold = True
                    worksheet.Cells(foot, 8).Value = txtDebe.Text

                    worksheet.Cells(foot + 1, 7).Value = "TOTAL HABER"
                    worksheet.Cells(foot + 1, 7).Font.Bold = True
                    worksheet.Cells(foot + 1, 8).Value = txtHaber.Text
                End If

                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace