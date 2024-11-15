Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS
Imports Microsoft.Office.Interop
Imports Krypton.Toolkit

Namespace FORMULARIOS.CONTABILIDAD.AUXILIARES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAuxiliaresDiario
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

        '=== CLASES ==================================================================================================================================================================
        Dim objLibro As New ClassLibroDiario
        Dim objAsiento As New ClassAjustarAsientosLibroDiario

        '=============================================================================================================================================================================
        Public Sub cargarAsientosxIdLibro(ByVal idLibro As Int64)
            Try
                dgvAsientos.DataSource = objLibro.SumarRegistrosDeDiarioxIdDiario(_tipoCon, idLibro)
                dgvAsientos.Columns(0).HeaderText = "ID"
                dgvAsientos.Columns(0).Width = 50 
            Catch
                dgvAsientos.DataSource = Nothing
            End Try
        End Sub
        Public Sub cargarAsientoxNroAsiento(ByVal nroasiento As Int64)
            Try
                dgvJornalizacion.DataSource = objAsiento.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, nroasiento)
                dgvJornalizacion.AutoResizeRows() 
                dgvJornalizacion.Columns(0).Width = 50 
                dgvJornalizacion.Columns(1).DefaultCellStyle.Format = "g"
                dgvJornalizacion.Columns(1).Width = 120
                dgvJornalizacion.Columns(2).Width = 90
                dgvJornalizacion.Columns(3).Width = 180
                dgvJornalizacion.Columns(4).Width = 300
                dgvJornalizacion.Columns(5).Width = 500
                dgvJornalizacion.Columns(6).Width = 80
                dgvJornalizacion.Columns(7).Width = 80
                dgvJornalizacion.Columns(8).Width = 80
                dgvJornalizacion.Columns(9).Visible = False
                dgvJornalizacion.Columns(10).Visible = False
                dgvJornalizacion.Columns(11).Visible = False
                dgvJornalizacion.Columns(12).Visible = False
            Catch
                dgvJornalizacion.DataSource = Nothing
            End Try
        End Sub
        '==============================================================================================================================================================================
        Public Sub cargarDiarios()
            Try
                Dim fechaDesde = dtpInicio.Value.Day.ToString & "-" & dtpInicio.Value.Month.ToString & "-" & dtpInicio.Value.Year.ToString & " 00:00:00.001"
                Dim fechaHasta = dtpFinal.Value.Day.ToString & "-" & dtpFinal.Value.Month.ToString & "-" & dtpFinal.Value.Year.ToString & " 23:59:59.000"

                dgvDiarios.DataSource = objLibro.SeleccionarOrdenadoLibroDiarioRangoFecha(_tipoCon, fechaDesde, fechaHasta)
                dgvDiarios.Columns(0).HeaderText = "ID LIBRO"
                dgvDiarios.Columns(0).Width = 100
                dgvDiarios.Columns(1).Visible = False
                dgvDiarios.Columns(2).Visible = False
                dgvDiarios.Columns(3).Visible = False
                dgvDiarios.Columns(4).Visible = False
            Catch
                dgvDiarios.DataSource = Nothing
            End Try
        End Sub
        '=============================================================================================================================================================================
        Private Sub FormAuxiliaresDiario_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDiarios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvJornalizacion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDiarios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvJornalizacion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDiarios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvJornalizacion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvAsientos.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDiarios.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvJornalizacion.Font = New Font("Roboto", 8, FontStyle.Regular)

        End Sub

         
        Private Sub btnCuadrar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCuadrar.Click
            cargarDiarios()

            Dim debe As Decimal
            Dim haber As Decimal
            Try
                For indice = 0 To dgvAsientos.Rows.Count - 1 Step 1
                    debe += CDec(dgvAsientos.Rows(indice).Cells.Item(1).Value)
                    haber += CDec(dgvAsientos.Rows(indice).Cells.Item(2).Value)
                Next
            Catch
                debe = 0.0
                haber = 0.0
            End Try
            txtDebeSumaAsientos.Text = debe
            txtHaberSumaAsientos.Text = haber

            Try
                For indice = 0 To dgvJornalizacion.Rows.Count - 1 Step 1
                    debe += CDec(dgvJornalizacion.Rows(indice).Cells.Item(10).Value)
                    haber += CDec(dgvJornalizacion.Rows(indice).Cells.Item(11).Value)
                Next
            Catch
                debe = 0.0
                haber = 0.0
            End Try
            txtDebe.Text = debe
            txtHaber.Text = haber
        End Sub

        Private Sub dgvDiarios_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvDiarios.SelectionChanged
            If dgvDiarios.RowCount = 0 Then Return
            If dgvDiarios.CurrentRow Is Nothing Then Return
            cargarAsientosxIdLibro(dgvDiarios.CurrentRow.Cells.Item(0).Value)
        End Sub

        Private Sub dgvAsientos_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvAsientos.SelectionChanged
            If dgvAsientos.RowCount = 0 Then Return
            If dgvAsientos.CurrentRow Is Nothing Then Return 
            cargarAsientoxNroAsiento(dgvAsientos.CurrentRow.Cells.Item(0).Value)
        End Sub

        Private Sub dgvJornalizacion_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvJornalizacion.SelectionChanged
            If dgvJornalizacion.RowCount = 0 Then Return
            If dgvJornalizacion.CurrentRow Is Nothing Then Return
            lblDetalle.Text = dgvJornalizacion.CurrentRow.Cells.Item(5).Value
            txtCantidad.Text = dgvJornalizacion.CurrentRow.Cells.Item(8).Value
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            If dgvDiarios.Rows.Count = 0 Then
                'MsgBox("NO HAY DATOS QUE EXPORTAR! PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                KryptonMessageBox.Show("NO HAY DATOS QUE EXPORTAR! PRIMERO REALICE UNA BUSQUEDA", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If
            ExportarDatosExcel(dgvDiarios, "LIBRO DIARIO", "LIBRO_DIARIO")
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            If dgvAsientos.Rows.Count = 0 Then
                'MsgBox("NO HAY DATOS QUE EXPORTAR! PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                KryptonMessageBox.Show("NO HAY DATOS QUE EXPORTAR! PRIMERO REALICE UNA BUSQUEDA", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If
            ExportarDatosExcel(dgvAsientos, "ASIENTOS LIBRO DIARIO", "ASIENTOS_DIARIO")
        End Sub

        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem3.Click
            If dgvJornalizacion.Rows.Count = 0 Then
                'MsgBox("NO HAY DATOS QUE EXPORTAR! PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                KryptonMessageBox.Show("NO HAY DATOS QUE EXPORTAR! PRIMERO REALICE UNA BUSQUEDA", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If
            ExportarDatosExcel(dgvJornalizacion, "DETALLE ASIENTO", "LIBRO_DARIO")
        End Sub

        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String, ByVal sname As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then
                    'MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    KryptonMessageBox.Show("No hay Datos que exportar!", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
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
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                'MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                KryptonMessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub KryptonLabel1_Paint(sender As Object, e As PaintEventArgs) Handles KryptonLabel1.Paint

        End Sub
    End Class
End Namespace