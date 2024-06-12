
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.UNIFORMES
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.INVENTARIOS.PROCESO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormControlUniformes
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

        '==============================================================================================================================================================================
        ReadOnly _objPersonal As New ClassPersonal
        ReadOnly _objControl As New ClassControlUniformes

        Private Sub CargarCustodios(ByVal parametroBusqueda As String)
            dgvCustodios.DataSource = _objPersonal.BuscarPorCedulaNombreApellidoElPersonalUni(_tipoCon, parametroBusqueda)
            dgvCustodios.Columns(0).Width = 40
            dgvCustodios.Columns(1).Width = 70
            dgvCustodios.Columns(2).Width = 200
            dgvCustodios.Columns(3).Width = 300
            dgvCustodios.Columns(4).Width = 80
            dgvCustodios.Columns(5).Visible = False
            dgvCustodios.Columns(6).Width = 150
            dgvCustodios.Columns(7).Visible = False 
        End Sub

        Private Sub CargarItems(ByVal parametroBusqueda As String)
            dgvCustodios.DataSource = _objControl.BuscarItemsKardexReporte(_tipoCon, parametroBusqueda)
            dgvCustodios.Columns(0).HeaderText = "KARDEX"
            dgvCustodios.Columns(0).Width = 50
            dgvCustodios.Columns(1).HeaderText = "ITEM"
            dgvCustodios.Columns(1).Width = 50
            dgvCustodios.Columns(2).HeaderText = "DETALLE"
            dgvCustodios.Columns(2).Width = 300
            dgvCustodios.Columns(3).HeaderText = "DESCRIPCIÓN"
            dgvCustodios.Columns(3).Width = 300 
        End Sub

        Private Sub txtParametrobusqueda_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtParametrobusqueda.KeyUp
            If e.KeyCode = Keys.Enter Then
                If chkCustodio.Checked Then CargarCustodios(txtParametrobusqueda.Text) Else CargarItems(txtParametrobusqueda.Text)
            End If
        End Sub

        Private Sub btnExportarComprobantes_Click(ByVal sender As System.Object, ByVal e As EventArgs)
            ExportarDatosExcel(Me.dgvControl, "CONTROL DE BODEGA")
        End Sub

        Private Sub FormControlUniformes_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvControl.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvTotales.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    pbFoto.Image = My.Resources.Cisepro_Wall
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    msKardex.ForeColor = Color.White
                    pbFoto.Image = My.Resources.SeportPac_Wall
                    dgvControl.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvTotales.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    msKardex.ForeColor = Color.White
                    pbFoto.Image = My.Resources.Cisepro_Wall
                    dgvControl.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvTotales.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvControl.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvTotales.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvCustodios.Font = New Font("Roboto", 8, FontStyle.Regular)
            dtpDesde.Value = ValidationForms.FechaActual(_tipoCon)
            dtpHasta.Value = dtpDesde.Value

            dgvControl.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvTotales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgvCustodios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End Sub

        Private Sub dgvCustodios_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvCustodios.SelectionChanged
            dgvTotales.Rows.Clear()

            If dgvCustodios.Rows.Count = 0 Or dgvCustodios.CurrentRow Is Nothing Then Return

            Dim fechaDesde = dtpDesde.Value.Year.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Day.ToString & " 00:00:00"
            Dim fechaHasta = dtpHasta.Value.Year.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Day.ToString & " 23:59:59"

            If chkCustodio.Checked Then
                dgvControl.DataSource = _objControl.SeleccionarMovimientosKardexByIdPersonal(_tipoCon, dgvCustodios.CurrentRow.Cells(0).Value, fechaDesde, fechaHasta)
                dgvControl.Columns(5).Visible = False
                dgvControl.Columns(7).Visible = True
            Else
                dgvControl.DataSource = _objControl.SeleccionarMovimientosKardexByIdKardex(_tipoCon, dgvCustodios.CurrentRow.Cells(0).Value, fechaDesde, fechaHasta)
                dgvControl.Columns(5).Visible = True
                dgvControl.Columns(7).Visible = False
            End If

            dgvControl.Columns(0).HeaderText = "ID CON."
            dgvControl.Columns(0).Width = 50
            dgvControl.Columns(1).HeaderText = "N° COMP."
            dgvControl.Columns(1).Width = 80
            dgvControl.Columns(2).Width = 60
            dgvControl.Columns(3).Width = 60
            dgvControl.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvControl.Columns(4).Width = 100
            dgvControl.Columns(5).HeaderText = "CUSTODIO"
            dgvControl.Columns(5).Width = 150
            dgvControl.Columns(6).Visible = False
            dgvControl.Columns(7).Width = 300
            dgvControl.Columns(8).Width = 50
            dgvControl.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvControl.Columns(9).Width = 300
        End Sub
          
        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnProcesar.Click
            Dim cuantos As Integer = 0
            Try
                For indice = 0 To dgvControl.RowCount - 1 
                    For indiceOrden = 0 To dgvControl.RowCount - 1
                        If dgvControl.Rows(indice).Cells("KARDEX").Value = dgvControl.Rows(indiceOrden).Cells("KARDEX").Value Then
                            If Me.dgvControl.Rows(indiceOrden).Cells("ACTIVIDAD").Value = "INGRESO" Then
                                cuantos += CInt(dgvControl.Rows(indiceOrden).Cells("CANTIDAD").Value)
                            ElseIf Me.dgvControl.Rows(indiceOrden).Cells("ACTIVIDAD").Value = "EGRESO" Then
                                cuantos -= CInt(dgvControl.Rows(indiceOrden).Cells("CANTIDAD").Value)
                            End If
                        End If
                    Next

                    If ValidarKardexRepetidos(dgvControl.Rows(indice).Cells("KARDEX").Value) = False Then
                        Dim fila As String() = {dgvControl.Rows(indice).Cells("ITEM").Value, cuantos, dgvControl.Rows(indice).Cells("KARDEX").Value}
                        dgvTotales.Rows.Add(fila)
                        dgvTotales.AutoResizeColumns()
                        dgvTotales.AutoResizeRows()
                    End If
                    cuantos = 0 
                Next 
            Catch ex As Exception
                MsgBox("NO SE PUEDE PROCESAR" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Function ValidarKardexRepetidos(ByVal kardex As String) As Boolean
            Dim contarRepetidos = 0
            Try
                For indice = 0 To dgvTotales.RowCount - 1 Step 1
                    If dgvTotales.Rows.Item(indice).Cells("KARDEX").Value = kardex Then
                        contarRepetidos += 1
                    End If
                Next
                If contarRepetidos > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function

        Private Sub chkCustodio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCustodio.CheckedChanged
            txtParametrobusqueda.Clear()
            txtParametrobusqueda.Focus()
        End Sub

        Private Sub chkItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItem.CheckedChanged
            txtParametrobusqueda.Clear()
            txtParametrobusqueda.Focus()
        End Sub

        Public Sub ExportarDatosExcel(ByVal DataGridViewExp As DataGridView, ByVal titulo As String)
            If DataGridViewExp.Rows.Count = 0 Then
                MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If

            Dim fec = ValidationForms.FechaActual(_tipoCon)

            Dim app = New Microsoft.Office.Interop.Excel.Application()
            Dim workbook = app.Workbooks.Add(Type.Missing)
            Dim worksheet = workbook.Worksheets(1)
            worksheet.Name = If(chkCustodio.Checked, "CUSTODIO", "KARDEX")

            Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(DataGridViewExp)
            worksheet.Range("A1:" & ic & (DataGridViewExp.RowCount + 50)).Font.Size = 10

            worksheet.Range("A1:" & ic & "1").Merge()
            worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  " & titulo
            worksheet.Range("A1:" & ic & "1").Font.Bold = True
            worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
            worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
            worksheet.Range("A1:" & ic & "1").Font.Size = 12
            'Copete  
            worksheet.Range("A2:" & ic & "2").Merge()
            worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpDesde.Value.ToLongDateString() & "  AL " & dtpHasta.Value.ToLongDateString()
            worksheet.Range("A2:" & ic & "2").Font.Size = 12
            'Fecha  
            worksheet.Range("A3:" & ic & "3").Merge()
            worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
            worksheet.Range("A3:" & ic & "3").Font.Size = 12

            'Aca se ingresa las columnas
            Dim indc = 1
            Dim headin = 5
            For i = 0 To DataGridViewExp.Columns.Count - 1
                If Not DataGridViewExp.Columns(i).Visible Then Continue For
                worksheet.Cells(headin, indc) = DataGridViewExp.Columns(i).HeaderText
                worksheet.Cells(headin, indc).Font.Bold = True
                worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Cells(headin, indc).Font.Color = Color.White
                indc += 1
            Next

            'Aca se ingresa el detalle recorrera la tabla celda por celda
            Dim c = 0
            For o = 0 To DataGridViewExp.Rows.Count - 1
                If Not DataGridViewExp.Rows(o).Visible Then Continue For
                indc = 1
                For j = 0 To DataGridViewExp.Columns.Count - 1
                    If Not DataGridViewExp.Columns(j).Visible Then Continue For
                    worksheet.Cells(c + 1 + headin, indc) = DataGridViewExp.Rows(o).Cells(j).Value
                    worksheet.Cells(c + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(c + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                    indc += 1
                Next
                c += 1
            Next
            worksheet.Range("A" & (c + headin) & ":" & ic & indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

            app.DisplayAlerts = False
            app.Visible = True
            app.DisplayAlerts = True
        End Sub

    
        Private Sub btnExportarComprobantes_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarComprobantes.Click
            Try
                ExportarDatosExcel(dgvCustodios, If(chkCustodio.Checked, "REPORTE POR CUSTODIO", "REPORTE DE ITEM / KARDEX"))
            Catch ex As Exception
                MsgBox("NO SE PUEDE PROCESAR" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
            Try
                ExportarDatosExcel(dgvControl, If(chkCustodio.Checked, "CUSTODIO: " & dgvCustodios.CurrentRow.Cells(2).Value, "REPORTE DE ITEM / KARDEX"))
            Catch ex As Exception
                MsgBox("NO SE PUEDE PROCESAR" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub txtParametrobusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtParametrobusqueda.TextChanged

        End Sub
    End Class
End Namespace