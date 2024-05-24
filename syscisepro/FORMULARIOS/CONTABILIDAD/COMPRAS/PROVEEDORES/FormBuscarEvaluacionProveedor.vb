
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormBuscarEvaluacionProveedor
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
        Public IdUsuario As Integer

        Dim objetoProveedorGeneral As New ClassProveedores
        Dim objetoEvaluacionServicios As New ClassEvaluacionProveedoreServicios
        Dim objetoEvaluacionMateriales As New ClassEvaluacionProveedorMateriales

        Dim fechaDesde As String = ""
        Dim fechaHasta As String = ""
        Dim tipoBusqueda As Integer = 0
        Dim tipoProveedor As String = ""

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
                worksheet.Name = "EVALUACION"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  " & titulo
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = color.White
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
        Public Sub autocompletarNombreProveedor()
            Try
                txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = objetoProveedorGeneral.Autocompletar(_tipoCon)
                txtNombreComercialProveedorGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialProveedorGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
            End Try
        End Sub

        Public Sub cargarEvaluacionProveedor()
            If tipoBusqueda = 1 Then
                dgvEvaluacionProveedor.DataSource = objetoEvaluacionMateriales.BuscarEvaluacionProveedorMaterialesXRangoFechas(_tipoCon, fechaDesde, fechaHasta)
            ElseIf tipoBusqueda = 2 Then
                dgvEvaluacionProveedor.DataSource = objetoEvaluacionServicios.BuscarEvaluacionProveedorServiciosXRangoFechas(_tipoCon, fechaDesde, fechaHasta)
            ElseIf tipoBusqueda = 3 Then
                dgvEvaluacionProveedor.DataSource = objetoEvaluacionMateriales.BuscarEvaluacionProveedorXIdProveedorYRangoFechas(_tipoCon, lblIdProveedorGeneral.Text, fechaDesde, fechaHasta)
            ElseIf tipoBusqueda = 4 Then
                dgvEvaluacionProveedor.DataSource = objetoEvaluacionMateriales.BuscarEvaluacionProveedorTodoXRangoFechas(_tipoCon, fechaDesde, fechaHasta)
            End If
            dgvEvaluacionProveedor.AutoResizeRows()
            dgvEvaluacionProveedor.AutoResizeColumns()
            dgvEvaluacionProveedor.Columns(1).Width = 393
        End Sub

        Private Sub FormBuscarEvaluacionProveedor_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvEvaluacionProveedor.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvEvaluacionProveedor.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvEvaluacionProveedor.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            autocompletarNombreProveedor()
            gbNombreComercialProveedor.Enabled = False
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click 
            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
            fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"
            If tipoBusqueda <> 0 Then
                cargarEvaluacionProveedor()
            Else
                MsgBox("NO HA SELECCIONADO TIPO DE BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            If lblIdEvaluacionProveedor.Text <> 0 Then 
                Dim f = New FormReporteEvaluacionProveedores
                f.TipoCox = TipoCox
                f.lblIdEvaluacionProveedor.Text = lblIdEvaluacionProveedor.Text
                f.lblTipoProveedor.Text = tipoProveedor
                f.Show()
            Else
                MsgBox("POR FAVOR SELECCIONE UN COMPROBANTE DE EGRESO", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarProveedorGeneral.Click
            ExportarDatosExcel(dgvEvaluacionProveedor, "EVALUACIÓN DE PROVEEDORES")
        End Sub
         
        Private Sub txtNombreComercialProveedorGeneral_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombreComercialProveedorGeneral.KeyDown
            If e.KeyCode = Keys.Enter Then

                lblIdProveedorGeneral.Text = objetoProveedorGeneral.BuscarIdProveedorXRazonSocialProveedor(_tipoCon, txtNombreComercialProveedorGeneral.Text)
            End If
        End Sub

        Private Sub rbProductos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbProductos.CheckedChanged
            If rbProductos.Checked = True Then
                tipoBusqueda = 1
                gbNombreComercialProveedor.Enabled = False
            End If
        End Sub

        Private Sub rbServicios_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbServicios.CheckedChanged
            If rbServicios.Checked = True Then
                tipoBusqueda = 2
                gbNombreComercialProveedor.Enabled = False
            End If
        End Sub

        Private Sub rbProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbProveedor.CheckedChanged
            If rbProveedor.Checked = True Then
                tipoBusqueda = 3
                gbNombreComercialProveedor.Enabled = True
                txtNombreComercialProveedorGeneral.Focus()
            End If
        End Sub

        Private Sub rbTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTodo.CheckedChanged
            If rbTodo.Checked = True Then
                tipoBusqueda = 4
                gbNombreComercialProveedor.Enabled = False
            End If
        End Sub
 
        Private Sub dgvEvaluacionProveedor_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvEvaluacionProveedor.SelectionChanged
            If dgvEvaluacionProveedor.RowCount = 0 Or dgvEvaluacionProveedor.CurrentRow Is Nothing Then Return
            If dgvEvaluacionProveedor.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdEvaluacionProveedor.Text = "..."
                tipoProveedor = ""
            Else
                lblIdEvaluacionProveedor.Text = dgvEvaluacionProveedor.CurrentRow.Cells.Item(0).Value
                tipoProveedor = dgvEvaluacionProveedor.CurrentRow.Cells.Item(3).Value
            End If 
        End Sub
    End Class
End Namespace