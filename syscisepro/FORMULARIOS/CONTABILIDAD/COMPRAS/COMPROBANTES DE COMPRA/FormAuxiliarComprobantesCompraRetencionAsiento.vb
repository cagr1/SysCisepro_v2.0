Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS
Imports Microsoft.Office.Interop

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAuxiliarComprobantesCompraRetencionAsiento
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
     
        Dim objetoComprobantesCompra As New ClassComprobantesCompra
        Dim objetoComprobanteRetencion As New ClassComprobantesRetencion
        Dim objetoDetalleComprobantesRetencion As New ClassDetalleComprobantesRetencion
        Dim objetoNumeroRegistroAsientoCompCompra As New ClassNumeroRegistroAsientoComprobanteCompra
        Dim objetoAjustarAsientos As New ClassAjustarAsientosLibroDiario
 
        Public Sub cargarComprobantesCompra()
            Try
                Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
                Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

                dgvComprobantesCompra.DataSource = objetoComprobantesCompra.SeleccionarComrpobantesCompraXRangoFechas(_tipoCon, fechaDesde, fechaHasta)
               
                dgvComprobantesCompra.Columns(0).HeaderText = "ID"
                dgvComprobantesCompra.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(1).HeaderText = "PROVEEDOR"
                dgvComprobantesCompra.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(2).HeaderText = "TIPO"
                dgvComprobantesCompra.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(3).HeaderText = "NÚMERO"
                dgvComprobantesCompra.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(4).HeaderText = "FECHA EMISIÓN"
                dgvComprobantesCompra.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(5).HeaderText = "SUBTOTAL 12%"
                dgvComprobantesCompra.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(6).HeaderText = "SUBTOTAL  0%"
                dgvComprobantesCompra.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(7).HeaderText = "DESCUENTO   "
                dgvComprobantesCompra.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(8).HeaderText = "SUBTOTAL    "
                dgvComprobantesCompra.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(9).HeaderText = "IVA (12%)   "
                dgvComprobantesCompra.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(10).HeaderText = "TOTAL"
                dgvComprobantesCompra.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(11).HeaderText = "CODIGO"
                dgvComprobantesCompra.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(12).HeaderText = "% FUENTE"
                dgvComprobantesCompra.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(13).HeaderText = "$ FUENTE"
                dgvComprobantesCompra.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(14).HeaderText = "% IVA"
                dgvComprobantesCompra.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(15).HeaderText = "$ IVA"
                dgvComprobantesCompra.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(16).HeaderText = "TOTAL RET."
                dgvComprobantesCompra.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(17).HeaderText = "TOTAL PAGAR"
                dgvComprobantesCompra.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(18).HeaderText = "EST"
                dgvComprobantesCompra.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.ReadOnly = True
                dgvComprobantesCompra.EditMode = DataGridViewEditMode.EditProgrammatically
                dgvComprobantesCompra.AutoResizeColumns()
                dgvComprobantesCompra.AutoResizeRows()
                dgvComprobantesCompra.Columns(1).Width = 400 : dgvComprobantesCompra.Columns(2).Width = 90 : dgvComprobantesCompra.Columns(4).Width = 90
                dgvComprobantesCompra.Columns(5).Width = 70 : dgvComprobantesCompra.Columns(6).Width = 70 : dgvComprobantesCompra.Columns(7).Width = 70
                dgvComprobantesCompra.Columns(8).Width = 70 : dgvComprobantesCompra.Columns(9).Width = 70 : dgvComprobantesCompra.Columns(10).Width = 70
            Catch
                dgvComprobantesCompra.DataSource = Nothing
            End Try

        End Sub
        Public Sub cargarComprobanteRetencion()
            Try
                dgvComprobanteRetencion.DataSource = objetoComprobanteRetencion.SeleccionarComrpobantesRetencionXIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
                'cantidadRegistrosComprobanteRetencion = objetoComprobanteRetencion.SeleccionarComrpobantesRetencionXIdComprobanteCompra(lblIdComprobanteCompra.Text).Rows.Count
                dgvComprobanteRetencion.AutoResizeColumns()
                dgvComprobanteRetencion.AutoResizeRows()
                'calcularTotalRetencion()
                dgvComprobanteRetencion.ReadOnly = True
                dgvComprobanteRetencion.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                dgvComprobanteRetencion.DataSource = Nothing
                MsgBox("METODO CARGAR COMPROBANTE DE RETENCIÓN" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Public Sub cargarDetalleComprobanteRetencion()
            Try
                dgvDetalleComprobanteRetencion.DataSource = objetoDetalleComprobantesRetencion.SeleccionarRegistrosDetallesComprobanteRetencionCompraXIdComprobanteRetencion(_tipoCon, lblIdComprobanteRetencion.Text)
                dgvDetalleComprobanteRetencion.AutoResizeColumns()
                dgvDetalleComprobanteRetencion.AutoResizeRows()
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
                dgvDetalleComprobanteRetencion.Columns(9).HeaderText = "ID CC"
                dgvDetalleComprobanteRetencion.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(9).ReadOnly = True
                dgvDetalleComprobanteRetencion.AutoResizeColumns()
                dgvDetalleComprobanteRetencion.AutoResizeRows()
                dgvDetalleComprobanteRetencion.ReadOnly = False
                dgvDetalleComprobanteRetencion.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                MsgBox("METODO CARGAR DETALLE COMPROBANTE DE RETENCIÓN" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
 
        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click 
            cargarComprobantesCompra() 
        End Sub
         

        Private Sub FormAuxiliarComprobantesCompraRetencionAsiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientoDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientoDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientoDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvComprobantesCompra.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
        End Sub

        Private Sub dgvComprobantesCompra_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobantesCompra.SelectionChanged

            'Try
            ' VARIABLES PARA CARGAR Y MODIFICAR EL COMPROBANTE DE RETENCION
            'numAutoSRI = ""
            'fechaAutoSRI = ""
            'tipoCompVenta = ""
            'estadoCompRet = 0
            If dgvComprobantesCompra.RowCount = 0 Then Return
            If dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdComprobanteCompra.Text = "..."
            Else
                lblIdComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value
                lblTipoComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(2).Value
                If dgvComprobantesCompra.CurrentRow.Cells.Item(16).Value = 1 Then
                    lblEstadoComprobanteCompra.Text = "POR PAGAR"
                ElseIf dgvComprobantesCompra.CurrentRow.Cells.Item(16).Value = 2 Then
                    lblEstadoComprobanteCompra.Text = "CANCELADO"
                End If

                cargarComprobanteRetencion()
                If dgvComprobanteRetencion.RowCount > 0 Then
                    lblIdComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(0).Value
                    lblNumeroComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(1).Value
                    'estadoCompRet = dgvComprobanteRetencion.Rows(0).Cells.Item(9).Value
                    cargarDetalleComprobanteRetencion()
                    'calcularTotalRetencion()
                Else
                    'idComprobanteRetencion = 0
                    lblIdComprobanteRetencion.Text = "..."
                    lblNumeroComprobanteRetencion.Text = ""
                    dgvComprobanteRetencion.DataSource = Nothing
                    dgvDetalleComprobanteRetencion.DataSource = Nothing
                End If

                lblIdComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value
                Dim n = objetoNumeroRegistroAsientoCompCompra.BuscarNumeroRegistroAsientoPorIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
                If n <> Nothing Then
                    lblNumeroRegistro.Text = n
                    dgvAsientoDiario.DataSource = objetoAjustarAsientos.BuscarAsientosLibroDiarioResumidoXNumeroRegistro(_tipoCon, lblNumeroRegistro.Text)
                    dgvAsientoDiario.AutoResizeColumns()
                    dgvAsientoDiario.AutoResizeRows()
                Else
                    lblNumeroRegistro.Text = "0"
                    dgvAsientoDiario.DataSource = Nothing
                End If

            End If
            'Catch ex As Exception
            '    MsgBox(ex.Message.ToString)
            'End Try

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            If dgvComprobantesCompra.Rows.Count = 0 Then
                MsgBox("NO HAY DATOS QUE EXPORTAR! PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If
            ExportarDatosExcel(dgvComprobantesCompra, "FACTURAS DE COMPRA", "FACTURAS_COMPRA")
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            If dgvDetalleComprobanteRetencion.Rows.Count = 0 Then
                MsgBox("NO HAY DATOS QUE EXPORTAR! PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If
            ExportarDatosExcel(dgvDetalleComprobanteRetencion, "RETENCIÓN EN COMPRA", "RETENCION_COMPRA")
        End Sub

        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem3.Click
            If dgvAsientoDiario.Rows.Count = 0 Then
                MsgBox("NO HAY DATOS QUE EXPORTAR! PRIMERO REALICE UNA BUSQUEDA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If
            ExportarDatosExcel(dgvAsientoDiario, "ASIENTOS DIARIO DE COMRPA", "LIBRO_DARIO")
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