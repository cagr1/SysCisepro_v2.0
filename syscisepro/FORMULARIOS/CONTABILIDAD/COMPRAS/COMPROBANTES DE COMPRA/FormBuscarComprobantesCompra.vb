Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA.REPORTES
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_ELECTRONICOS
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports System.Xml
Imports System.Text
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports CrystalDecisions.Shared.Json
Imports iTextSharp.awt.geom.Point2D
Imports System.Windows.Forms.VisualStyles
Imports Krypton.Toolkit

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormBuscarComprobantesCompra
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
        Public IdUsuario As Integer
        Dim _sqlCommands As List(Of SqlCommand)
        ReadOnly _objetoEmpresa As New ClassEmpresa

        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoComprobantesRetencionCompra As New ClassComprobantesRetencion
        ReadOnly _objetoDetalleComprobantesRetencionCompra As New ClassDetalleComprobantesRetencion
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas

        Dim _Detalle As New List(Of ClassDetalleLiquidacionCompra)
        Dim _Impuesto As New List(Of ClassDetalleImpuestos)

        ReadOnly _objetoNumeroRegistroAsientoCompCompra As New ClassNumeroRegistroAsientoComprobanteCompra
        ReadOnly _objetoProveedorGeneral As New ClassProveedores

        ReadOnly _objetoComprobantesElectronicos As New ClassDocumentosElectronicos

        ReadOnly _objetoFormasPago As New ClassFormasPago

        Dim _estadoCompras As Integer = 0
        Dim _fechaDesde As String = ""
        Dim _fechaHasta As String = ""

        Private Sub AutocompletarNombreProveedor()
            Try
                txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = _objetoProveedorGeneral.Autocompletar(_tipoCon)
                txtNombreComercialProveedorGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialProveedorGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = Nothing
            End Try
        End Sub

        Private Sub CargarComprobantesCompra()
            Try
                dgvComprobantesCompra.DataSource = _objetoComprobantesCompra.SeleccionarComrpobantesCompraXParametrosNew(_tipoCon, lblIdProveedorGeneral.Text, _fechaDesde, _fechaHasta, _estadoCompras)

                dgvComprobantesCompra.AutoResizeColumns()


                dgvComprobantesCompra.Columns(1).Width = 350
                dgvComprobantesCompra.Columns(2).Width = 90
                dgvComprobantesCompra.Columns(4).DefaultCellStyle.Format = "g"
                dgvComprobantesCompra.Columns(4).Width = 100
                dgvComprobantesCompra.Columns(5).Width = 70
                dgvComprobantesCompra.Columns(6).Width = 70
                dgvComprobantesCompra.Columns(7).Width = 70

                dgvComprobantesCompra.Columns(8).Width = 50
                dgvComprobantesCompra.Columns(8).HeaderText = "DESC."
                dgvComprobantesCompra.Columns(9).Width = 70
                dgvComprobantesCompra.Columns(10).Width = 60
                dgvComprobantesCompra.Columns(11).Width = 60
                dgvComprobantesCompra.Columns(12).Width = 70
                dgvComprobantesCompra.Columns(13).Width = 70

                dgvComprobantesCompra.Columns(3).Frozen = True

                dgvComprobantesCompra.AutoResizeRows()
            Catch ex As Exception
                dgvComprobantesCompra.DataSource = Nothing
                'MsgBox("METODO CARGAR COMPROBANTES DE COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Metodo cargar comprobantes de compra" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub SumarTotalesResumen()
            Dim anterior = 0

            Dim subtotalCompras As Decimal = 0
            Dim ivaCompras As Decimal = 0
            Dim iva5Compras As Decimal = 0
            Dim totalCompras As Decimal = 0
            Dim totalRetencion As Decimal = 0
            Dim totalPagar As Decimal = 0

            For indiceSuma = 0 To dgvComprobantesCompra.RowCount - 1
                If dgvComprobantesCompra.Rows(indiceSuma).Cells(0).Value = anterior Then Continue For

                ' LAS NOTAS DE CRÉDITO NO SE SUMAN
                If (dgvComprobantesCompra.Rows(indiceSuma).Cells(2).Value & "").ToString.Trim.Equals("NOTA DE CREDITO") Then Continue For

                subtotalCompras += CDec(dgvComprobantesCompra.Rows(indiceSuma).Cells(9).Value)
                ivaCompras += CDec(dgvComprobantesCompra.Rows(indiceSuma).Cells(10).Value)
                If Convert.IsDBNull(dgvComprobantesCompra.Rows(indiceSuma).Cells(11).Value) Then
                    iva5Compras += 0
                Else
                    iva5Compras += CDec(dgvComprobantesCompra.Rows(indiceSuma).Cells(11).Value)
                End If

                totalCompras += CDec(dgvComprobantesCompra.Rows(indiceSuma).Cells(12).Value)
                totalRetencion += CDec(dgvComprobantesCompra.Rows(indiceSuma).Cells(18).Value)
                totalPagar += CDec(dgvComprobantesCompra.Rows(indiceSuma).Cells(19).Value)
                anterior = dgvComprobantesCompra.Rows(indiceSuma).Cells(0).Value
            Next

            txtSubTotalCompras.Text = subtotalCompras
            txtIvaCompras.Text = ivaCompras
            txtTotalCompras.Text = totalCompras
            txtTotalRetencion.Text = totalRetencion
            txtTotalAPagar.Text = totalPagar
        End Sub

        Private Sub FormBuscarComprobantesCompra_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvComprobantesCompra.Font = New Drawing.Font("Roboto", 7, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            AutocompletarNombreProveedor()

            Dim txtFilePathRetencion As String = Path.Combine(Application.StartupPath & "\Leer XML Temp\pathRetencion.txt")
            If File.Exists(txtFilePathRetencion) Then
                Dim selectedFolderPath1 As String = File.ReadAllText(txtFilePathRetencion)
                txtRetencionPath.Text = selectedFolderPath1
            Else
                txtRetencionPath.Text = "No existe ruta"
            End If

            Dim txtFilePathLiquidacion As String = Path.Combine(Application.StartupPath & "\Leer XML Temp\pathLiquidacion.txt")
            If File.Exists(txtFilePathLiquidacion) Then
                Dim selectedFolderPath2 As String = File.ReadAllText(txtFilePathLiquidacion)
                txtLiquidacionPath.Text = selectedFolderPath2
            Else
                txtLiquidacionPath.Text = "No existe ruta"
            End If

        End Sub

        Private Sub txtNombreComercialProveedorGeneral_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles txtNombreComercialProveedorGeneral.KeyDown
            If e.KeyCode <> Keys.Enter Then Return
            lblIdProveedorGeneral.Text = _objetoProveedorGeneral.BuscarIdProveedorXRazonSocialProveedor(_tipoCon, txtNombreComercialProveedorGeneral.Text)
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            _fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
            _fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

            CargarComprobantesCompra()

            SumarTotalesResumen()

            VerficarRepetidos()
        End Sub

        Private Sub VerficarRepetidos()
            Dim anterior = 0
            Dim def = SystemColors.Window
            Dim alt = Color.FromArgb(224, 224, 224)

            For i = 0 To dgvComprobantesCompra.RowCount - 1
                If dgvComprobantesCompra.Rows(i).Cells(0).Value = anterior Then
                    dgvComprobantesCompra.Rows(i).Cells(0).Style.ForeColor = If(i Mod 2 = 0, def, alt)
                    dgvComprobantesCompra.Rows(i).Cells(1).Style.ForeColor = If(i Mod 2 = 0, def, alt)
                    dgvComprobantesCompra.Rows(i).Cells(2).Style.ForeColor = If(i Mod 2 = 0, def, alt)
                    dgvComprobantesCompra.Rows(i).Cells(3).Style.ForeColor = If(i Mod 2 = 0, def, alt)
                    dgvComprobantesCompra.Rows(i).Cells(4).Style.ForeColor = If(i Mod 2 = 0, def, alt)
                    dgvComprobantesCompra.Rows(i).Cells(5).Style.ForeColor = If(i Mod 2 = 0, def, alt)
                    dgvComprobantesCompra.Rows(i).Cells(6).Style.ForeColor = If(i Mod 2 = 0, def, alt)
                    dgvComprobantesCompra.Rows(i).Cells(7).Style.ForeColor = If(i Mod 2 = 0, def, alt)
                    dgvComprobantesCompra.Rows(i).Cells(8).Style.ForeColor = If(i Mod 2 = 0, def, alt)
                    dgvComprobantesCompra.Rows(i).Cells(9).Style.ForeColor = If(i Mod 2 = 0, def, alt)
                    dgvComprobantesCompra.Rows(i).Cells(10).Style.ForeColor = If(i Mod 2 = 0, def, alt)

                    dgvComprobantesCompra.Rows(i).Cells(0).Value = 0
                    dgvComprobantesCompra.Rows(i).Cells(1).Value = String.Empty
                    dgvComprobantesCompra.Rows(i).Cells(2).Value = String.Empty
                    dgvComprobantesCompra.Rows(i).Cells(3).Value = String.Empty
                    dgvComprobantesCompra.Rows(i).Cells(4).Value = String.Empty
                    dgvComprobantesCompra.Rows(i).Cells(5).Value = "0.00"
                    dgvComprobantesCompra.Rows(i).Cells(6).Value = "0.00"
                    dgvComprobantesCompra.Rows(i).Cells(7).Value = "0.00"
                    dgvComprobantesCompra.Rows(i).Cells(8).Value = "0.00"
                    dgvComprobantesCompra.Rows(i).Cells(9).Value = "0.00"
                    dgvComprobantesCompra.Rows(i).Cells(10).Value = "0.00"
                    dgvComprobantesCompra.Rows(i).Cells(11).Value = "0.00"
                    dgvComprobantesCompra.Rows(i).Cells(12).Value = "0.00"
                    dgvComprobantesCompra.Rows(i).Cells(18).Value = "0.00"
                    dgvComprobantesCompra.Rows(i).Cells(19).Value = "0.00"
                    dgvComprobantesCompra.Rows(i).Cells(20).Value = "0.00"
                    dgvComprobantesCompra.Rows(i).Cells(21).Value = "0"
                    dgvComprobantesCompra.Rows(i).Cells(22).Value = "0"

                    'dgvComprobantesCompra.Rows(i).Cells(16).Value = "0.00"
                    'dgvComprobantesCompra.Rows(i).Cells(17).Value = "0.00"
                    'dgvComprobantesCompra.Rows(i).Cells(18).Value = "0"
                    'dgvComprobantesCompra.Rows(i).Cells(19).Value = "0"
                    Continue For
                End If
                anterior = dgvComprobantesCompra.Rows(i).Cells(0).Value
            Next
        End Sub

        Private Sub rbFondoRotativo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbFondoRotativo.CheckedChanged
            If rbFondoRotativo.Checked Then
                _estadoCompras = 10
            Else
                _estadoCompras = 0
            End If
        End Sub

        Private Sub rbCajaChica_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbCajaChica.CheckedChanged
            If rbCajaChica.Checked Then
                _estadoCompras = 11
            Else
                _estadoCompras = 0
            End If
        End Sub

        Private Sub rbCompras_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbCompras.CheckedChanged
            If rbCompras.Checked Then
                _estadoCompras = 1
            Else
                _estadoCompras = 0
            End If
        End Sub

        Private Sub rbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTodos.CheckedChanged
            If rbCompras.Checked Then
                _estadoCompras = 0
            End If
        End Sub

        Private Sub chkProveedorGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkProveedorGeneral.CheckedChanged
            If chkProveedorGeneral.Checked = True Then
                lblIdProveedorGeneral.Text = 0
                txtNombreComercialProveedorGeneral.Enabled = False
                txtNombreComercialProveedorGeneral.Text = ""
            Else
                txtNombreComercialProveedorGeneral.Enabled = True
            End If
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            If dgvComprobantesCompra.Rows.Count = 0 Then Return
            Try
                If dgvComprobantesCompra.Rows.Count = 0 Then
                    'MsgBox("No hay datos que exportar!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("No hay datos que exportar!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "COMPROBANTES_COMPRA"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvComprobantesCompra)
                worksheet.Range("A1:" & ic & (dgvComprobantesCompra.RowCount + 50)).Font.Size = 10

                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  COMPROBANTES DE COMPRA"
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
                For i = 0 To dgvComprobantesCompra.Columns.Count - 1
                    If Not dgvComprobantesCompra.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvComprobantesCompra.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvComprobantesCompra.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvComprobantesCompra.Columns.Count - 1

                        If Not dgvComprobantesCompra.Columns(j).Visible Then Continue For

                        ' asigna valor a celda
                        worksheet.Cells(i + 1 + headin, indc) = dgvComprobantesCompra.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvComprobantesCompra.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                worksheet.Range("A1:" & ic & dgvComprobantesCompra.RowCount + 50).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Catch ex As Exception
                'MessageBox.Show("Hubo un problema al exportar datos!" & vbNewLine & ex.Message, "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                KryptonMessageBox.Show("Hubo un problema al exportar datos!" & vbNewLine & ex.Message, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub dgvComprobantesCompra_CellDoubleClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles dgvComprobantesCompra.CellDoubleClick
            If dgvComprobantesCompra.RowCount = 0 Then Return
            If dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdComprobanteCompra.Text = "..."
            Else
                Dim formAsientoDiario As New FormBuscarAsientoDiario
                formAsientoDiario.TipoCox = TipoCox
                lblIdComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value
                formAsientoDiario.NumeroRegsitroBusqueda = _objetoNumeroRegistroAsientoCompCompra.BuscarNumeroRegistroAsientoPorIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
                formAsientoDiario.ShowDialog()
            End If
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            If lblIdComprobanteCompra.Text = "..." Then Return

            If lblIdComprobanteCompra.Text <> 0 Then
                If lblEstadoComprobanteCompra.Text = "COMPRAS" Then
                    Dim numeroRegistro = _objetoNumeroRegistroAsientoCompCompra.BuscarNumeroRegistroAsientoPorIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
                    Dim ds As DataSet = _objetoComprobantesCompra.BuscarReporteComprobanteCompraXIdComprobanteNumeroRegistro(_tipoCon, Convert.ToInt32(lblIdComprobanteCompra.Text), numeroRegistro)

                    Dim iva5 As DataTable = _objetoComprobantesCompra.IvaComprobanteTabla(_tipoCon, CType(lblIdComprobanteCompra.Text, Int64))

                    Dim subtotal5Value As String = "0"
                    Dim iva5Value As String = "0"
                    If iva5.Rows.Count > 0 Then

                        subtotal5Value = If(iva5.Rows(0)("SUBTOTAL_5_COMPROBANTE_COMPRA") IsNot DBNull.Value, iva5.Rows(0)("SUBTOTAL_5_COMPROBANTE_COMPRA").ToString(), "0,00")
                        iva5Value = If(iva5.Rows(0)("IVA5_COMPROBANTE_COMPRA") IsNot DBNull.Value, iva5.Rows(0)("IVA5_COMPROBANTE_COMPRA").ToString(), "0,00")
                    End If

                    Dim pdfStream As New MemoryStream()

                    Dim ruta As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "ComprobanteCompra.pdf")
                    PdfViewer1.Document?.Dispose()
                    PdfViewer1.Document = Nothing

                    'Using fs As New FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None)
                    Dim document As New iTextSharp.text.Document()
                    Dim writer As PdfWriter = PdfWriter.GetInstance(document, pdfStream)
                    writer.CloseStream = False
                    document.Open()

                    Dim baseFont As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED)
                    Dim fuente12 As iTextSharp.text.Font = New Font(baseFont, 12, iTextSharp.text.Font.BOLD)
                    Dim fuente10Bold As iTextSharp.text.Font = New Font(baseFont, 10, iTextSharp.text.Font.BOLD)
                    Dim fuente10 As iTextSharp.text.Font = New Font(baseFont, 10)
                    Dim fuente8 As iTextSharp.text.Font = New Font(baseFont, 8)
                    Dim fuente8Bold As iTextSharp.text.Font = New Font(baseFont, 8, iTextSharp.text.Font.BOLD)

                    Dim rutaImagen As String = ValidationForms.NombreLogoNuevo(_tipoCon, Application.StartupPath)
                    Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(rutaImagen)
                    logo.ScaleToFit(35, 35)



                    Dim headerTable As PdfPTable = New PdfPTable(3)
                    headerTable.TotalWidth = 500

                    Dim ColumnWidhts As Single() = New Single() {150, 250, 100}
                    headerTable.SetWidths(ColumnWidhts)



                    Dim idContent As New Phrase()
                    idContent.Add(New Chunk("Id    ", fuente8Bold))
                    idContent.Add(New Chunk("   " & lblIdComprobanteCompra.Text, fuente8))
                    idContent.Add(New Chunk(vbLf, fuente10))
                    idContent.Add(New Chunk(vbLf & "Tipo    ", fuente8Bold))
                    idContent.Add(New Chunk(dgvComprobantesCompra.CurrentRow.Cells.Item(2).Value.ToString(), fuente8))



                    Dim idCell As New PdfPCell(idContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }
                    headerTable.AddCell(idCell)

                    Dim tituloCell As New PdfPCell(New Phrase("COMPROBANTE DE COMPRA", fuente12)) With {
                                    .HorizontalAlignment = Element.ALIGN_CENTER,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }
                    headerTable.AddCell(tituloCell)

                    Dim logoCell As New PdfPCell(logo) With {
                                    .HorizontalAlignment = Element.ALIGN_CENTER,
                                    .VerticalAlignment = Element.ALIGN_CENTER,
                                    .Border = PdfPCell.NO_BORDER
                                }
                    headerTable.AddCell(logoCell)
                    headerTable.WriteSelectedRows(0, -1, 50, 820, writer.DirectContent)

                    Dim rectTabla1 As PdfContentByte = writer.DirectContent
                    rectTabla1.RoundRectangle(40.0F, 775.0F, 525.0F, 50.0F, 10.0F)
                    rectTabla1.Stroke()



                    Dim tabla1 As PdfPTable = New PdfPTable(2)
                    tabla1.TotalWidth = 500

                    Dim ColumnWidhts1 As Single() = New Single() {300, 200}
                    tabla1.SetWidths(ColumnWidhts1)

                    Dim proveedorContent As New Phrase()
                    proveedorContent.Add(New Chunk("Proveedor   ", fuente8Bold))
                    proveedorContent.Add(New Chunk(dgvComprobantesCompra.CurrentRow.Cells.Item("PROVEEDOR").Value.ToString(), fuente8))

                    Dim proveedorCell As New PdfPCell(proveedorContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }
                    tabla1.AddCell(proveedorCell)

                    Dim fechaContent As New Phrase()
                    fechaContent.Add(New Chunk("Fecha   ", fuente8Bold))
                    fechaContent.Add(New Chunk(dgvComprobantesCompra.CurrentRow.Cells.Item("FECHA EMISION").Value.ToString(), fuente8))

                    Dim fechaCell As New PdfPCell(fechaContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }
                    tabla1.AddCell(fechaCell)

                    Dim emptyCell As New PdfPCell(New Phrase("")) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }
                    Dim emptyCell2 As New PdfPCell(New Phrase("")) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER,
                                    .Colspan = 2
                                 }


                    Dim separatorCell As New PdfPCell() With {
                                    .Colspan = 2,
                                    .BorderWidthTop = 0.5F,
                                    .BorderWidthLeft = 0,
                                    .BorderWidthRight = 0,
                                    .BorderWidthBottom = 0
                                }



                    'tabla1.AddCell(emptyCell)

                    Dim NroComprobanteContent As New Phrase()
                    NroComprobanteContent.Add(New Chunk("Nro. Comprobante   ", fuente8Bold))
                    NroComprobanteContent.Add(New Chunk(dgvComprobantesCompra.CurrentRow.Cells.Item("NUMERO").Value.ToString(), fuente8))

                    Dim NroComprobanteCell As New PdfPCell(NroComprobanteContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

                    tabla1.AddCell(NroComprobanteCell)

                    Dim comproTable As DataTable = ds.Tables("COMPROBANTES_COMPRA")
                    Dim DocModComprobanteContent As New Phrase()
                    DocModComprobanteContent.Add(New Chunk("Doc Modf   ", fuente8Bold))
                    DocModComprobanteContent.Add(New Chunk(comproTable.Rows(0)("DOC_MOD_COMPROBANTE_COMPRA").ToString(), fuente8))

                    Dim DocNroComprobanteCell As New PdfPCell(DocModComprobanteContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

                    tabla1.AddCell(DocNroComprobanteCell)
                    tabla1.AddCell(emptyCell2)
                    'tabla1.AddCell(separatorCell)


                    Dim numAutorizacionContent As New Phrase()
                    numAutorizacionContent.Add(New Chunk("Nro. Autorización SRI ", fuente8Bold))
                    numAutorizacionContent.Add(New Chunk(comproTable.Rows(0)("NUM_AUTO_SRI_COMPROBANTE_COMPRA").ToString(), fuente8))

                    Dim numAutorizacionCell As New PdfPCell(numAutorizacionContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER,
                                    .Colspan = 2
                                }

                    tabla1.AddCell(numAutorizacionCell)

                    Dim fechaAutorizacion As New Phrase()
                    fechaAutorizacion.Add(New Chunk("Fecha Autorización SRI ", fuente8Bold))
                    fechaAutorizacion.Add(New Chunk(comproTable.Rows(0)("FECHA_AUTO_SRI_COMPROBANTE_COMPRA").ToString(), fuente8))

                    Dim fechaAutorizacionCell As New PdfPCell(fechaAutorizacion) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER,
                                    .Colspan = 2
                                }

                    tabla1.AddCell(fechaAutorizacionCell)
                    tabla1.AddCell(emptyCell2)

                    Dim ObservacionContent As New Phrase()
                    ObservacionContent.Add(New Chunk("Observación   ", fuente8Bold))
                    ObservacionContent.Add(New Chunk(comproTable.Rows(0)("OBSERVACION_COMPROBANTE_COMPRA").ToString(), fuente8))

                    Dim ObservacionCell As New PdfPCell(ObservacionContent) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

                    tabla1.AddCell(ObservacionCell)

                    Dim table2 As PdfPTable = New PdfPTable(2)
                    table2.TotalWidth = 200
                    table2.HorizontalAlignment = Element.ALIGN_CENTER
                    'Dim columnWidthsTable5() As Single = {150, 50}


                    Dim cell1Row1 As New PdfPCell(New Phrase("Subtotal " & lblPorcentaje.Text & "%", fuente8Bold))
                    Dim cell2Row1 As New PdfPCell(New Phrase(comproTable.Rows(0)("SUBTOTAL_12_COMPROBANTE_COMPRA").ToString(), fuente8))
                    cell2Row1.HorizontalAlignment = Element.ALIGN_RIGHT
                    table2.AddCell(cell1Row1)
                    table2.AddCell(cell2Row1)

                    Dim cell1Row2 As New PdfPCell(New Phrase("Subtotal 5%", fuente8Bold))
                    Dim cell2Row2 As New PdfPCell(New Phrase(subtotal5Value, fuente8))
                    cell2Row2.HorizontalAlignment = Element.ALIGN_RIGHT
                    table2.AddCell(cell1Row2)
                    table2.AddCell(cell2Row2)

                    Dim cell1Row3 As New PdfPCell(New Phrase("Subtotal 0%", fuente8Bold))
                    Dim cell2Row3 As New PdfPCell(New Phrase(comproTable.Rows(0)("SUBTOTAL_12_COMPROBANTE_COMPRA").ToString(), fuente8))
                    cell2Row3.HorizontalAlignment = Element.ALIGN_RIGHT
                    table2.AddCell(cell1Row3)
                    table2.AddCell(cell2Row3)

                    Dim cell1Row4 As New PdfPCell(New Phrase("Descuento", fuente8Bold))
                    Dim cell2Row4 As New PdfPCell(New Phrase(comproTable.Rows(0)("DESCUENTO_COMPROBANTE_COMPRA").ToString(), fuente8))
                    cell2Row4.HorizontalAlignment = Element.ALIGN_RIGHT
                    table2.AddCell(cell1Row4)
                    table2.AddCell(cell2Row4)

                    Dim cell1Row5 As New PdfPCell(New Phrase("Subtotal", fuente8Bold))
                    Dim cell2Row5 As New PdfPCell(New Phrase(comproTable.Rows(0)("SUBTOTAL_COMPROBANTE_COMPRA").ToString(), fuente8))
                    cell2Row5.HorizontalAlignment = Element.ALIGN_RIGHT
                    table2.AddCell(cell1Row5)
                    table2.AddCell(cell2Row5)

                    Dim cell1Row6 As New PdfPCell(New Phrase("IVA 5%", fuente8Bold))
                    Dim cell2Row6 As New PdfPCell(New Phrase(iva5Value, fuente8))
                    cell2Row6.HorizontalAlignment = Element.ALIGN_RIGHT
                    table2.AddCell(cell1Row6)
                    table2.AddCell(cell2Row6)

                    Dim cell1Row7 As New PdfPCell(New Phrase("IVA " & lblPorcentaje.Text & "%", fuente8Bold))
                    Dim cell2Row7 As New PdfPCell(New Phrase(comproTable.Rows(0)("IVA_COMPROBANTE_COMPRA").ToString(), fuente8))
                    cell2Row7.HorizontalAlignment = Element.ALIGN_RIGHT
                    table2.AddCell(cell1Row7)
                    table2.AddCell(cell2Row7)

                    Dim cell1Row8 As New PdfPCell(New Phrase("TOTAL ", fuente8Bold))
                    Dim cell2Row8 As New PdfPCell(New Phrase(comproTable.Rows(0)("TOTAL_COMPROBANTE_COMPRA").ToString(), fuente8))
                    cell2Row8.HorizontalAlignment = Element.ALIGN_RIGHT
                    table2.AddCell(cell1Row8)
                    table2.AddCell(cell2Row8)

                    Dim nestedTableCell As New PdfPCell(table2) With {
                                        .Border = PdfPCell.NO_BORDER,
                                        .HorizontalAlignment = Element.ALIGN_RIGHT,
                                        .VerticalAlignment = Element.ALIGN_TOP}
                    tabla1.AddCell(nestedTableCell)
                    tabla1.WriteSelectedRows(0, -1, 50, 775, writer.DirectContent)


                    Dim tabla3 As PdfPTable = New PdfPTable(2)
                    tabla3.TotalWidth = 500

                    Dim ColumnWidhts3 As Single() = New Single() {250, 250}
                    tabla3.SetWidths(ColumnWidhts3)

                    Dim TituloTabla3 As New PdfPCell(New Phrase("COMPROBANTE DE RETENCIÓN", fuente10Bold)) With {
                                    .HorizontalAlignment = Element.ALIGN_CENTER,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.BOTTOM_BORDER,
                                    .Colspan = 2
                                }

                    tabla3.AddCell(TituloTabla3)

                    Dim emptyCellTable3 As New PdfPCell(New Phrase(" ")) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER,
                                    .Colspan = 2
                                 }

                    tabla3.AddCell(emptyCellTable3)
                    Dim retencionTable As DataTable = ds.Tables("COMPROBANTE_RETENCION_COMPRA")


                    Dim IdRetencion As New Phrase()
                    IdRetencion.Add(New Chunk("ID   ", fuente8Bold))
                    IdRetencion.Add(New Chunk(retencionTable.Rows(0)("ID_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))



                    Dim IdRetencionCell As New PdfPCell(IdRetencion) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                                                    }

                    tabla3.AddCell(IdRetencionCell)

                    Dim TipoComprobante As New Phrase()
                    TipoComprobante.Add(New Chunk("Tipo Comprobante   ", fuente8Bold))
                    TipoComprobante.Add(New Chunk(retencionTable.Rows(0)("TIPO_COMP_VENTA_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))

                    Dim TipoComprobanteCell As New PdfPCell(TipoComprobante) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

                    tabla3.AddCell(TipoComprobanteCell)

                    Dim NroComprobanteRetencion As New Phrase()
                    NroComprobanteRetencion.Add(New Chunk("Nro. Retencion   ", fuente8Bold))
                    NroComprobanteRetencion.Add(New Chunk(retencionTable.Rows(0)("NUMERO_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))

                    Dim NroComprobanteRetencionCell As New PdfPCell(NroComprobanteRetencion) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

                    tabla3.AddCell(NroComprobanteRetencionCell)

                    Dim FechaEmision As New Phrase()
                    FechaEmision.Add(New Chunk("Fecha Emisión   ", fuente8Bold))
                    FechaEmision.Add(New Chunk(retencionTable.Rows(0)("FECHA_EMISION_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))

                    Dim FechaEmisionCell As New PdfPCell(FechaEmision) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

                    tabla3.AddCell(FechaEmisionCell)

                    Dim NroAutorizacion As New Phrase()
                    NroAutorizacion.Add(New Chunk("Nro. Autorización SRI   ", fuente8Bold))
                    NroAutorizacion.Add(New Chunk(retencionTable.Rows(0)("NUM_AUTO_SRI_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))

                    Dim NroAutorizacionCell As New PdfPCell(NroAutorizacion) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

                    tabla3.AddCell(NroAutorizacionCell)

                    Dim FechaAutorizacionSRI As New Phrase()
                    FechaAutorizacionSRI.Add(New Chunk("Fecha Autorización SRI   ", fuente8Bold))
                    FechaAutorizacionSRI.Add(New Chunk(retencionTable.Rows(0)("FECHA_AUTO_SRI_COMPROBANTE_RETENCION_COMPA").ToString(), fuente8))

                    Dim FechaAutorizacionSRICell As New PdfPCell(FechaAutorizacionSRI) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

                    tabla3.AddCell(FechaAutorizacionSRICell)

                    tabla3.WriteSelectedRows(0, -1, 50, 600, writer.DirectContent)

                    Dim table4 As New PdfPTable(6)
                    table4.TotalWidth = 500

                    Dim detalleRetencionTable As DataTable = ds.Tables("DETALLE_COMPROBANTE_RETENCION_COMPRA")
                    Dim columnWidthsTable4() As Single = {80, 80, 80, 100, 80, 80}
                    table4.SetWidths(columnWidthsTable4)

                    ' First row (header)
                    table4.AddCell(New Phrase("Ejercicio Fiscal", fuente8Bold))
                    table4.AddCell(New Phrase("Codigo", fuente8Bold))
                    table4.AddCell(New Phrase("Base Imponible", fuente8Bold))
                    table4.AddCell(New Phrase("Impuesto", fuente8Bold))
                    table4.AddCell(New Phrase("Porcentaje", fuente8Bold))
                    table4.AddCell(New Phrase("Valor", fuente8Bold))

                    table4.AddCell(New Phrase(detalleRetencionTable.Rows(0)("EJ_FISCAL_DETALLE_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))
                    table4.AddCell(New Phrase(detalleRetencionTable.Rows(0)("CODIGO_DETALLE_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))
                    table4.AddCell(New Phrase(detalleRetencionTable.Rows(0)("BASE_IMPONIBLE_DETALLE_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))
                    table4.AddCell(New Phrase(detalleRetencionTable.Rows(0)("IMPUESTO_DETALLE_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))
                    table4.AddCell(New Phrase(detalleRetencionTable.Rows(0)("PORCENTAJE_DETALLE_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))
                    table4.AddCell(New Phrase(detalleRetencionTable.Rows(0)("VALOR_DETALLE_COMPROBANTE_RETENCION_COMPRA").ToString(), fuente8))

                    table4.WriteSelectedRows(0, -1, 50, 520, writer.DirectContent)


                    Dim asientoTable As DataTable = ds.Tables("ASIENTOS_LIBRO_DIARIO")
                    Dim table5 As New PdfPTable(4)
                    table5.TotalWidth = 500

                    Dim columnWidthsTable5() As Single = {80, 270, 75, 75}
                    table5.SetWidths(columnWidthsTable5)

                    Dim TituloTabla5 As New PdfPCell(New Phrase("ASIENTO DE DIARIO", fuente10Bold)) With {
                                    .HorizontalAlignment = Element.ALIGN_CENTER,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.BOTTOM_BORDER,
                                    .Colspan = 4
                                }
                    table5.AddCell(TituloTabla5)

                    Dim emptyCell4Table5 As New PdfPCell(New Phrase(" ")) With {
                                    .HorizontalAlignment = Element.ALIGN_LEFT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER,
                                    .Colspan = 4,
                                    .PaddingTop = 10
                                 }

                    table5.AddCell(emptyCell4Table5)

                    table5.AddCell(New Phrase("Codigo", fuente8Bold))
                    table5.AddCell(New Phrase("Cuenta", fuente8Bold))
                    table5.AddCell(New Phrase("Debe", fuente8Bold))
                    table5.AddCell(New Phrase("Haber", fuente8Bold))

                    Dim valorDebe As Decimal = 0
                    Dim valorHaber As Decimal = 0
                    For Each row As DataRow In asientoTable.Rows
                        table5.AddCell(New Phrase(row("CODIGO_CUENTA_ASIENTO").ToString(), fuente8))
                        table5.AddCell(New Phrase(row("NOMBRE_CUENTA_ASIENTO").ToString(), fuente8))
                        table5.AddCell(New Phrase(row("VALOR_DEBE_ASIENTO").ToString(), fuente8))
                        table5.AddCell(New Phrase(row("VALOR_HABER_ASIENTO").ToString(), fuente8))
                        valorDebe += Convert.ToDecimal(row("VALOR_DEBE_ASIENTO"))
                        valorHaber += Convert.ToDecimal(row("VALOR_HABER_ASIENTO"))
                    Next

                    table5.WriteSelectedRows(0, -1, 50, 450, writer.DirectContent)

                    Dim table6 As New PdfPTable(2)
                    table6.TotalWidth = 150

                    Dim table5Height As Single = table5.TotalHeight
                    table6.AddCell(New Phrase(valorDebe.ToString(), fuente8Bold))
                    table6.AddCell(New Phrase(valorHaber.ToString(), fuente8Bold))

                    table6.WriteSelectedRows(0, -1, 400, 450 - table5Height, writer.DirectContent)



                    'add the actual date in the document footer
                    Dim footerTable As PdfPTable = New PdfPTable(1)
                    footerTable.TotalWidth = 500
                    Dim footerCell As New PdfPCell(New Phrase("Fecha de Reporte: " & DateAndTime.DateString() & " " & DateAndTime.TimeString(), fuente8)) With {
                                    .HorizontalAlignment = Element.ALIGN_RIGHT,
                                    .VerticalAlignment = Element.ALIGN_MIDDLE,
                                    .Border = PdfPCell.NO_BORDER
                                }

                    footerTable.AddCell(footerCell)
                    footerTable.WriteSelectedRows(0, -1, 50, 50, writer.DirectContent)

                    document.Close()
                    writer.Close()

                    pdfStream.Seek(0, SeekOrigin.Begin)
                    PdfViewer1.Document = PdfiumViewer.PdfDocument.Load(pdfStream)
                    PdfViewer1.ZoomMode = 1



                    KryptonNavigator1.SelectedPage = KryptonPage3


                    'Dim f = New FormReporteComprobanteCompra
                    'f.TipoCox = TipoCox
                    'f.lblIdComprobanteCompra.Text = lblIdComprobanteCompra.Text
                    'f._porcentaje = Convert.ToString(lblPorcentaje.Text)
                    'f.ShowDialog()
                Else
                    'MsgBox("LOS COMPROBANTES DE FONDO Y CAJA SE IMPRIMEN EN SUS RESPECTIVAS LIQUIDACIONES", MsgBoxStyle.Information, "Mensaje de información")
                    KryptonMessageBox.Show("Los comprobantes de fondo y caja se imprimen en sus respectivas liquidaciones", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                End If
            Else
                'sgBox("POR FAVOR SELECCIONE UN COMPROBANTE DE COMPRA", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Por favor seleccione un comprobante de compra", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub dgvComprobantesCompra_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobantesCompra.SelectionChanged
            If dgvComprobantesCompra.RowCount = 0 Or dgvComprobantesCompra.CurrentRow Is Nothing Then Return
            If dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdComprobanteCompra.Text = "..."
                lblPorcentaje.Text = "..."
            Else
                lblIdComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value
                Select Case dgvComprobantesCompra.CurrentRow.Cells.Item(20).Value
                    Case 1 : lblEstadoComprobanteCompra.Text = "COMPRAS"
                    Case 10 : lblEstadoComprobanteCompra.Text = "FONDO ROTATIVO"
                    Case 11 : lblEstadoComprobanteCompra.Text = "COMPRAS"
                End Select
                lblPorcentaje.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(22).Value
                txtNombreComercialProveedorGeneral.Text = dgvComprobantesCompra.CurrentRow.Cells.Item("PROVEEDOR").Value
            End If
        End Sub

        Public RutaDocsElec As String

        Dim _estadoCompRet As String
        Dim _tipoAmbiente As String
        Dim _tipoEmision As String
        Dim _fechaRetencion As Date
        Dim _rucEmpresa As String
        Dim _razonSocialEmpresa As String
        Dim _nombreComercialEmpresa As String
        Dim _direccionEmpresa As String
        Dim _numAutoContEspecial As String
        Dim _establecimientoRetencion As String
        Dim _ptoEmisionRetencion As String
        Dim _secuencialRetencion As String
        Dim _tipoIdentificacionCliente As String
        Dim _lblRucProveedorGeneral As String
        Dim _claveAcceso As String
        Private Sub XMLRETENCIÓNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles XMLRETENCIÓNToolStripMenuItem.Click
            If dgvComprobantesCompra.CurrentRow Is Nothing Then Return

            If lblIdComprobanteCompra.Text <> "..." Then

                Dim rete = _objetoComprobantesRetencionCompra.SeleccionarComrpobantesRetencionXIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
                Dim prove = _objetoProveedorGeneral.BuscarProveedorGeneralXId(_tipoCon, rete.Rows(0)(5))

                _estadoCompRet = rete.Rows(0)(9)

                If CInt(_estadoCompRet) > 12 Then ' pregunta si es retención electrónica
                    If KryptonMessageBox.Show("Desea generar el XML de la retención?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                    'If MessageBox.Show("DESEA GENERAR EL XML DE LA RETENCIÓN?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

                    'ruc 01 / cedula 05
                    _lblRucProveedorGeneral = prove.Rows(0)(2)
                    Select Case _lblRucProveedorGeneral.Length
                        Case 10 : _tipoIdentificacionCliente = "05"
                        Case 13 : _tipoIdentificacionCliente = "04"
                        Case Else
                            If _lblRucProveedorGeneral = "9999999999999" Then _tipoIdentificacionCliente = "07"
                    End Select

                    _tipoAmbiente = "2" ' 1] pruebas ; 2] produccion
                    _tipoEmision = "1" ' 1] normal ; 2] indisponibilidad del sistema

                    CargarDatosEmpresa()

                    If rete.Rows(0)(1) <> "000000000000000" Then
                        _establecimientoRetencion = ""
                        _ptoEmisionRetencion = ""
                        _secuencialRetencion = ""
                        For indiceCadena = 1 To rete.Rows(0)(1).Length
                            If indiceCadena < 4 Then
                                _establecimientoRetencion = _establecimientoRetencion + Mid(rete.Rows(0)(1), indiceCadena, 1).ToString
                            ElseIf indiceCadena > 3 And indiceCadena < 7 Then
                                _ptoEmisionRetencion = _ptoEmisionRetencion + Mid(rete.Rows(0)(1), indiceCadena, 1).ToString
                            ElseIf indiceCadena > 6 Then
                                _secuencialRetencion = _secuencialRetencion + Mid(rete.Rows(0)(1), indiceCadena, 1).ToString
                            End If
                        Next

                        'FACTURA 01, NOTA DE CRÉDITO 04, NOTA DE DÉBITO 05, GUÍA DE REMISIÓN 06, COMPROBANTE DE RETENCIÓN 07
                        _fechaRetencion = CDate(rete.Rows(0)(4))
                        _claveAcceso = ValidationForms.GenerarClaveAccesoComprobantesElectronicos("07", _fechaRetencion, _rucEmpresa, _tipoAmbiente, _establecimientoRetencion, _ptoEmisionRetencion, _secuencialRetencion, _tipoEmision)

                        If _claveAcceso.ToString.Length = 49 Then
                            ExportarXmlRetencion() ' exporta el comprobante de retención electónico a formato XML 
                        Else

                            KryptonMessageBox.Show("Clave de acceso inválida", "Mensaje de validación")
                        End If
                    Else

                        KryptonMessageBox.Show("El número de comprobante 000000000000000 no es válido para generar XML", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If
                Else

                    KryptonMessageBox.Show("El comprobante seleccionado no tiene retención electrónica para generar XML", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                End If
            Else

                KryptonMessageBox.Show("Seleccione un comprobante de compra con retención para generar XML", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Sub CargarDatosEmpresa()
            Try
                Dim empre = _objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)
                If empre.Rows.Count > 0 Then
                    _rucEmpresa = empre.Rows(0)(2)
                    _razonSocialEmpresa = empre.Rows(0)(3)
                    _nombreComercialEmpresa = empre.Rows(0)(4)
                    _direccionEmpresa = empre.Rows(0)(5)
                    _numAutoContEspecial = empre.Rows(0)(6)
                    _establecimientoRetencion = empre.Rows(0)(17)
                    _ptoEmisionRetencion = "002"
                    _secuencialRetencion = empre.Rows(0)(19)

                    _porcentajeIva = CInt(empre.Rows(0)(21).ToString())
                End If
            Catch ex As Exception

                KryptonMessageBox.Show("Cargar datos empresa." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub ExportarXmlRetencion()
            Try
                Dim numeroRetencion = _establecimientoRetencion.ToString + "-" + _ptoEmisionRetencion.ToString + "-" + _secuencialRetencion.ToString
                Dim ruta As String
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\RETENCIONES COMPRAS - CAJA\RETENCION " & numeroRetencion & ".xml"
                    Case TipoConexion.Seportpac
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\COMPRAS\RETENCION " & numeroRetencion & ".xml"
                    Case Else
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\RETENCIONES COMPRAS - CAJA\RETENCION " & numeroRetencion & ".xml"
                End Select
                 
                Dim xml = String.Empty
                xml += "<?xml version='1.0' encoding='UTF-8'?>" & vbNewLine
                xml += "<comprobanteRetencion id='comprobante' version='1.0.0'>" & vbNewLine
                xml += "<infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA EMPRESA =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<ambiente>" & _tipoAmbiente & "</ambiente>" & vbNewLine
                xml += "<tipoEmision>" & _tipoEmision & "</tipoEmision>" & vbNewLine
                xml += "<razonSocial>" & _razonSocialEmpresa & "</razonSocial>" & vbNewLine
                xml += "<nombreComercial>" & _nombreComercialEmpresa & "</nombreComercial>" & vbNewLine
                xml += "<ruc>" & _rucEmpresa & "</ruc>" & vbNewLine
                xml += "<claveAcceso>" & _claveAcceso & "</claveAcceso>" & vbNewLine ' Pendiente..
                xml += "<codDoc>07</codDoc>" & vbNewLine ' FACTURA => 01 / NOTA DE CRÉDITO => 04 / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
                xml += "<estab>" & _establecimientoRetencion & "</estab>" & vbNewLine
                xml += "<ptoEmi>" & _ptoEmisionRetencion & "</ptoEmi>" & vbNewLine
                xml += "<secuencial>" & _secuencialRetencion & "</secuencial>" & vbNewLine
                xml += "<dirMatriz>" & _direccionEmpresa & "</dirMatriz>" & vbNewLine
                xml += "<agenteRetencion>00000001</agenteRetencion>" & vbNewLine
                xml += "</infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoCompRetencion>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA RETENCION =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<fechaEmision>" & Format(_fechaRetencion, "dd/MM/yyyy") & "</fechaEmision>" & vbNewLine
                xml += "<dirEstablecimiento>" & _direccionEmpresa & "</dirEstablecimiento>" & vbNewLine
                'xml += "<contribuyenteEspecial>" & _numAutoContEspecial & "</contribuyenteEspecial>" & vbNewLine
                xml += "<obligadoContabilidad>SI</obligadoContabilidad>" & vbNewLine
                xml += "<tipoIdentificacionSujetoRetenido>" & _tipoIdentificacionCliente & "</tipoIdentificacionSujetoRetenido>" & vbNewLine
                xml += "<razonSocialSujetoRetenido>" & txtNombreComercialProveedorGeneral.Text.Replace("Ñ", "N").Trim() & "</razonSocialSujetoRetenido>" & vbNewLine
                xml += "<identificacionSujetoRetenido>" & _lblRucProveedorGeneral & "</identificacionSujetoRetenido>" & vbNewLine
                Dim mesPeriodoFiscal = If(_fechaRetencion.Month < 10, "0" & _fechaRetencion.Month, _fechaRetencion.Month.ToString)
                Dim periodoFiscal = mesPeriodoFiscal.ToString + "/" + _fechaRetencion.Year.ToString
                xml += "<periodoFiscal>" & periodoFiscal & "</periodoFiscal>" & vbNewLine
                xml += "</infoCompRetencion>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                Dim dgvDetalleComprobanteRetencion = _objetoDetalleComprobantesRetencionCompra.SeleccionarRegistrosDetallesComprobanteRetencionCompraXIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
                If dgvDetalleComprobanteRetencion.Rows.Count > 0 Then
                    xml += "<impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                    For indiceDetalle = 0 To dgvDetalleComprobanteRetencion.Rows.Count - 1
                        xml += "<impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                        If dgvDetalleComprobanteRetencion.Rows(indiceDetalle)(4).ToString = "RENTA" Then
                            xml += "<codigo>1</codigo>" & vbNewLine ' RENTA => 1 IVA => 2 / ISD => 6
                            xml += "<codigoRetencion>" & dgvDetalleComprobanteRetencion.Rows(indiceDetalle)(2).ToString & "</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION RENTA
                        ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle)(4).ToString = "IVA" Then
                            xml += "<codigo>2</codigo>" & vbNewLine ' RENTA => 1 IVA => 2 / ISD => 6
                            If dgvDetalleComprobanteRetencion.Rows(indiceDetalle)(5) = 10 Then
                                xml += "<codigoRetencion>9</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION ENTRE CONT. ESP.
                            ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle)(5) = 20 Then
                                xml += "<codigoRetencion>10</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION ENTRE CONT. ESP.
                            ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle)(5) = 30 Then
                                xml += "<codigoRetencion>1</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA BIENES
                            ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle)(5) = 70 Then
                                xml += "<codigoRetencion>2</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA SERVICIOS
                            ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle)(5) = 100 Then
                                xml += "<codigoRetencion>3</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA 100%
                            Else
                                xml += "<codigoRetencion>1</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA BIENES
                            End If
                        End If
                        xml += "<baseImponible>" & dgvDetalleComprobanteRetencion.Rows(indiceDetalle)(3) & "</baseImponible>" & vbNewLine
                        xml += "<porcentajeRetener>" & dgvDetalleComprobanteRetencion.Rows(indiceDetalle)(5) & "</porcentajeRetener>" & vbNewLine
                        xml += "<valorRetenido>" & Math.Round(CDec(dgvDetalleComprobanteRetencion.Rows(indiceDetalle)(6)), 2, MidpointRounding.ToEven) & "</valorRetenido>" & vbNewLine
                        xml += "<codDocSustento>01</codDocSustento>" & vbNewLine
                        xml += "<numDocSustento>" & dgvComprobantesCompra.CurrentRow.Cells(3).Value & "</numDocSustento>" & vbNewLine
                        xml += "<fechaEmisionDocSustento>" & Format(dgvComprobantesCompra.CurrentRow.Cells(4).Value, "dd/MM/yyyy") & "</fechaEmisionDocSustento>" & vbNewLine
                        xml += "</impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                    Next
                    xml += "</impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                End If
                 
                xml += "<infoAdicional>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON ADICIONAL DEL SERVICIO PRESTADO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<campoAdicional nombre='Informacion'>Agente de retencion segun resolucion N. " & _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon) & ". </campoAdicional>" & vbNewLine
                xml += "</infoAdicional>" & vbNewLine
                xml += "</comprobanteRetencion>" & vbNewLine


                Dim writer As XmlTextWriter

                writer = New XmlTextWriter(ruta, Encoding.UTF8)
                writer.Formatting = Formatting.Indented
                Dim output As String = xml.Replace("&", "&amp;")

                'modificacion output & a &amp;
                'writer.WriteRaw(xml)
                writer.WriteRaw(output)
                writer.Flush()
                writer.Close()


                KryptonMessageBox.Show("Retención electrónica" & vbNewLine & "XML generado correctamente", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Catch ex As Exception
                'MsgBox("ERROR AL GENERAR RETENCIÓN ELECTRÓNICA" & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de información.")
                KryptonMessageBox.Show("Error al generar retención electrónica" & vbNewLine & ex.Message, "Mensaje de información.", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        ReadOnly _objetoInformacionTributaria As New ClassInformacionTributaria
        Dim _claveAccesoLiqCompra As String
        Private _ptoEmisionLiqCompra As String = ""
        Private _secuencialLiqCompra As String = 0
        Private _establecimientoLiqCompra As String = ""
        Private _fechaEmisionCompra As Date
        Private _porcentajeIva As Integer
        Private _tipoIdentificacionProveedor As String  ' tipo de identificacion del cliente RUC => 04 / CEDULA => 05 / CONSUMIDOR FINAL => 07
        Private _dirProveedor As String
        Private _obligaContProveedor As String
        Private _razonSocialProveedor As String

        Private Sub XMLNOTACRÉDITOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles XMLNOTACRÉDITOToolStripMenuItem.Click
            If dgvComprobantesCompra.CurrentRow Is Nothing Then Return

            If lblIdComprobanteCompra.Text <> "..." And dgvComprobantesCompra.CurrentRow.Cells(2).Value.ToString().StartsWith("LIQUIDACION DE COMPRA") Then

                Dim prove = _objetoProveedorGeneral.BuscarProveedorGeneralXNombre(_tipoCon, dgvComprobantesCompra.CurrentRow.Cells(1).Value)

                If MessageBox.Show("DESEA GENERAR EL XML DE LA RETENCIÓN?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

                _establecimientoLiqCompra = dgvComprobantesCompra.CurrentRow.Cells(3).Value.ToString().Substring(0, 3)
                _ptoEmisionLiqCompra = dgvComprobantesCompra.CurrentRow.Cells(3).Value.ToString().Substring(3, 3)
                _secuencialLiqCompra = dgvComprobantesCompra.CurrentRow.Cells(3).Value.ToString().Substring(6)
                _fechaEmisionCompra = CDate(dgvComprobantesCompra.CurrentRow.Cells(4).Value)

                ' tipo de identificacion del cliente RUC => 04 / CEDULA => 05 / CONSUMIDOR FINAL => 07
                If prove.Rows(0)(2).ToString().Equals("9999999999999") Then
                    _tipoIdentificacionProveedor = "07"
                Else
                    Select Case prove.Rows(0)(2).ToString.Length
                        Case 10
                            _tipoIdentificacionProveedor = "05"
                        Case 13
                            _tipoIdentificacionProveedor = "04"
                    End Select
                End If
                _lblRucProveedorGeneral = prove.Rows(0)(2)
                _dirProveedor = prove.Rows(0)(8)
                _obligaContProveedor = prove.Rows(0)(6)
                _razonSocialProveedor = prove.Rows(0)(3)

                CargarDatosEmpresa()

                _claveAccesoLiqCompra = ValidationForms.GenerarClaveAccesoComprobantesElectronicos("03", CDate(dgvComprobantesCompra.CurrentRow.Cells(4).Value), _rucEmpresa, 2, _establecimientoLiqCompra, _ptoEmisionLiqCompra, _secuencialLiqCompra, 1)

                If _claveAccesoLiqCompra.ToString.Length = 49 Then
                    ExportarXmlLiquidacionCompra() ' exporta el comprobante de liqudacion electónico a formato XML 
                Else
                    'MsgBox("CLAVE DE ACCESO INVALIDA")
                    KryptonMessageBox.Show("Clave de acceso inválida", "Mensaje de validación")
                End If

            Else
                'MsgBox("SELECCIONE UN COMPROBANTE DE COMPRA CON RETENCIÓN PARA GENERAR XML", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Seleccione un comprobante de compra con retención para generar XML", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub ExportarXmlLiquidacionCompra()
            Try
                Dim baseImponibles As Decimal

                Dim nres = _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon)
                Dim numeroFactura = _establecimientoLiqCompra & "-" & _ptoEmisionLiqCompra & "-" & _secuencialLiqCompra

                Dim ruta As String
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\LIQUIDACION COMPRA\LIQUIDACION COMPRA " & numeroFactura & ".xml"
                    Case TipoConexion.Seportpac
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\LIQUIDACION COMPRA\LIQUIDACION COMPRA " & numeroFactura & ".xml"
                    Case Else
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\LIQUIDACION COMPRA\LIQUIDACION COMPRA " & numeroFactura & ".xml"
                End Select

                Dim xml = String.Empty
                xml += "<?xml version='1.0' encoding='UTF-8'?>" & vbNewLine
                xml += "<liquidacionCompra id='comprobante' version='1.0.0'>" & vbNewLine
                xml += "<infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA EMPRESA =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<ambiente>2</ambiente>" & vbNewLine
                xml += "<tipoEmision>1</tipoEmision>" & vbNewLine
                xml += "<razonSocial>" & _razonSocialEmpresa & "</razonSocial>" & vbNewLine
                xml += "<nombreComercial>" & _nombreComercialEmpresa & "</nombreComercial>" & vbNewLine
                xml += "<ruc>" & _rucEmpresa & "</ruc>" & vbNewLine
                xml += "<claveAcceso>" & _claveAccesoLiqCompra & "</claveAcceso>" & vbNewLine
                xml += "<codDoc>03</codDoc>" & vbNewLine ' FACTURA => 01 / NOTA DE CRÉDITO => 04 /  LIQUIDACION DE COMPRA =>  03  / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
                xml += "<estab>" & _establecimientoLiqCompra & "</estab>" & vbNewLine
                xml += "<ptoEmi>" & _ptoEmisionLiqCompra & "</ptoEmi>" & vbNewLine
                xml += "<secuencial>" & _secuencialLiqCompra & "</secuencial>" & vbNewLine
                xml += "<dirMatriz>" & _direccionEmpresa & "</dirMatriz>" & vbNewLine
                xml += "<agenteRetencion>00000001</agenteRetencion>" & vbNewLine
                xml += "</infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoLiquidacionCompra>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA FACTURA =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<fechaEmision>" & Format(_fechaEmisionCompra, "dd/MM/yyyy") & "</fechaEmision>" & vbNewLine
                xml += "<dirEstablecimiento>" & _dirProveedor & "</dirEstablecimiento>" & vbNewLine
                'xml += "<contribuyenteEspecial>00000</contribuyenteEspecial>" & vbNewLine
                xml += "<obligadoContabilidad>" & _obligaContProveedor & "</obligadoContabilidad>" & vbNewLine
                xml += "<tipoIdentificacionProveedor>" & _tipoIdentificacionProveedor & "</tipoIdentificacionProveedor>" & vbNewLine
                xml += "<razonSocialProveedor>" & _razonSocialProveedor & "</razonSocialProveedor>" & vbNewLine
                xml += "<identificacionProveedor>" & _lblRucProveedorGeneral & "</identificacionProveedor>" & vbNewLine
                xml += "<direccionProveedor>" & _dirProveedor & "</direccionProveedor>" & vbNewLine ' ficha tecnica diciembre 2019; implementado 16/12/2019
                xml += "<totalSinImpuestos>" & Math.Round(CDec(dgvComprobantesCompra.CurrentRow.Cells(5).Value), 2, MidpointRounding.ToEven) & "</totalSinImpuestos>" & vbNewLine
                xml += "<totalDescuento>0.00</totalDescuento>" & vbNewLine
                xml += "<codDocReembolso>00</codDocReembolso>" & vbNewLine
                xml += "<totalComprobantesReembolso>00</totalComprobantesReembolso>" & vbNewLine
                xml += "<totalBaseImponibleReembolso>00</totalBaseImponibleReembolso>" & vbNewLine
                xml += "<totalImpuestoReembolso>00</totalImpuestoReembolso>" & vbNewLine
                xml += "<totalConImpuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<totalImpuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<codigo>2</codigo>" & vbNewLine ' IVA => 2 / ICE => 3 / IRBPNR => 5

                If _porcentajeIva = 15 Then xml += "<codigoPorcentaje>4</codigoPorcentaje>" & vbNewLine
                If _porcentajeIva = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine ' IVA: 0% => 0 / 12% => 2/ 14% => 3 / NO OBJETO DE IMPUESTO => 6 / EXCENTO DE IVA => 7
                If _porcentajeIva = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                If _porcentajeIva = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine

                baseImponibles = Math.Round(CDec(dgvComprobantesCompra.CurrentRow.Cells(5).Value), 2, MidpointRounding.ToEven)
                'xml += "<descuentoAdicional>0.00</descuentoAdicional>" & vbNewLine
                xml += "<baseImponible>" & baseImponibles & "</baseImponible>" & vbNewLine
                'xml += "<tarifa>" & _porcentajeIva & "</tarifa>" & vbNewLine
                xml += "<valor>" & Math.Round(CDec(dgvComprobantesCompra.CurrentRow.Cells(10).Value), 2, MidpointRounding.ToEven) & "</valor>" & vbNewLine
                xml += "</totalImpuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "</totalConImpuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<importeTotal>" & dgvComprobantesCompra.CurrentRow.Cells(12).Value & "</importeTotal>" & vbNewLine
                xml += "<moneda>DOLAR</moneda>" & vbNewLine
                '' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= ficha tecnica julio 2016; publicado 0/0/2016; implementado 08/09/2016
                xml += "<pagos>" & vbNewLine
                xml += "<pago>" & vbNewLine
                xml += "<formaPago>01</formaPago>" & vbNewLine
                xml += "<total>" & dgvComprobantesCompra.CurrentRow.Cells(12).Value & "</total>" & vbNewLine
                xml += "<plazo>30</plazo>" & vbNewLine
                xml += "<unidadTiempo>dias</unidadTiempo>" & vbNewLine
                xml += "</pago>" & vbNewLine
                xml += "</pagos>" & vbNewLine
                xml += "</infoLiquidacionCompra>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<detalles>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS DETALLES DE LA FACTURA =-=-=-=-=-=-=-=-=-=-=-=-=

                xml += "<detalle>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA ITEM =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<codigoPrincipal>52040114</codigoPrincipal>" & vbNewLine
                xml += "<descripcion>" & _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, "52040114") & "</descripcion>" & vbNewLine
                xml += "<unidadMedida>UNIDAD</unidadMedida>" & vbNewLine
                xml += "<cantidad>1</cantidad>" & vbNewLine
                xml += "<precioUnitario>" & Math.Round(CDec(baseImponibles), 2, MidpointRounding.ToEven) & "</precioUnitario>" & vbNewLine
                xml += "<descuento>0</descuento>" & vbNewLine
                xml += "<precioTotalSinImpuesto>" & Math.Round(CDec(baseImponibles), 2, MidpointRounding.ToEven) & "</precioTotalSinImpuesto>" & vbNewLine
                xml += "<impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<codigo>2</codigo>" & vbNewLine ' IVA => 2 / ICE => 3 / IRBPNR => 5
                If CDec(dgvComprobantesCompra.CurrentRow.Cells(10).Value) > 0 Then

                    If _porcentajeIva = 15 Then xml += "<codigoPorcentaje>4</codigoPorcentaje>" & vbNewLine
                    If _porcentajeIva = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine
                    If _porcentajeIva = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                    If _porcentajeIva = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine

                    xml += "<tarifa>" & _porcentajeIva & "</tarifa>" & vbNewLine
                    xml += "<baseImponible>" & baseImponibles & "</baseImponible>" & vbNewLine
                    Dim valorIvaDetalle = (CDec(baseImponibles) * _porcentajeIva) / 100
                    xml += "<valor>" & Math.Round(valorIvaDetalle, 2, MidpointRounding.ToEven) & "</valor>" & vbNewLine
                Else
                    xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine ' IVA: 0% => 0 / 12% => 2/ 14% => 3 / NO OBJETO DE IMPUESTO => 6 / EXCENTO DE IVA => 7
                    xml += "<tarifa>0</tarifa>" & vbNewLine
                    xml += "<baseImponible>" & baseImponibles & "</baseImponible>" & vbNewLine
                    xml += "<valor>0</valor>" & vbNewLine
                End If
                xml += "</impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "</impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "</detalle>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                xml += "</detalles>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoAdicional>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON ADICIONAL DEL SERVICIO PRESTADO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<campoAdicional nombre='Informacion'>Agente de retencion segun resolucion N. " & nres & ". </campoAdicional>" & vbNewLine
                If _tipoCon = TipoConexion.Seportpac Then
                    xml += "<campoAdicional nombre='Liquidacion de Compra'>Por favor remitir su retencion en el plazo estipulado por la ley a nuestras direcciones. Correo: seportpac@hotmail.com;</campoAdicional>" & vbNewLine
                Else
                    xml += "<campoAdicional nombre='Liquidacion de Compra'>Por favor remitir su retencion en el plazo estipulado por la ley a nuestras direcciones: Avda. Alejandro Castro Benitez; correo:cisepro@yahoo.es; Telf: 072790424</campoAdicional>" & vbNewLine
                End If
                xml += "</infoAdicional>" & vbNewLine
                xml += "</liquidacionCompra>" & vbNewLine

                Dim writer As XmlTextWriter
                writer = New XmlTextWriter(ruta, Encoding.UTF8)
                writer.Formatting = Formatting.Indented
                writer.WriteRaw(xml)
                writer.Flush()
                writer.Close()

                'MsgBox("LIQUIDACIÓN DE COMPRA DE BIENES Y PRESTACIÓN DE SERVICIOS " & vbNewLine & "XML GENERADO CORRECTAMENTE", MsgBoxStyle.Information, "Mensaje de información.")
                KryptonMessageBox.Show("Liquidación de compra de bienes y prestación de servicios" & vbNewLine & "XML generado correctamente", "Mensaje de información")
            Catch ex As Exception
                'MsgBox("ERROR A GENERAR LIQUIDACIÓN DE COMPRAS " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de información.")
                KryptonMessageBox.Show("Error al generar liquidación de compras" & vbNewLine & ex.Message, "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try
        End Sub
      
        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        End Sub

        Private Sub PDFLIQUIDACIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDFLIQUIDACIONToolStripMenuItem.Click
            Dim ruta As String
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA "
                Case TipoConexion.Seportpac
                    ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\VENTAS\FACTURA "
                Case Else
                    ruta = RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO "
            End Select
            'D:\COMPROBANTES ELECTRONICOS CISEPRO CIA LTDA\

            ofdSeleccionarArchivo.InitialDirectory = ruta
            ofdSeleccionarArchivo.Filter = "ARCHIVO DE FACTURA ELECTRÓNICA (*.xml)|*.xml"
            ofdSeleccionarArchivo.Title = "Seleccione el archivo de factura electrónica"
            If ofdSeleccionarArchivo.ShowDialog() <> Windows.Forms.DialogResult.OK Then Return

            Dim archivo = ofdSeleccionarArchivo.OpenFile


            LeerXml(archivo)
            archivo.Close()
        End Sub


        Private Sub LeerXml(ByVal s As System.IO.Stream)

            'infoTributaria
            Dim numeroAutorizacion As String = ""
            Dim fechaAutorizacion As String = ""
            Dim ambiente As String = ""
            Dim tipoEmision As String = ""
            Dim razonSocial As String = ""
            Dim nombreComercial As String = ""
            Dim ruc As String = ""
            Dim claveAcceso As String = ""
            Dim codDoc As String = ""
            Dim estab As String = ""
            Dim ptoEmi As String = ""
            Dim secuencial As String = ""
            Dim dirMatriz As String = ""
            Dim agenteRetencion As String = ""

            'infoFactura
            Dim fechaEmision As String = ""
            Dim dirEstablecimiento As String = ""
            Dim obligadoContabilidad As String = ""
            Dim tipoIdentificacionProveedor As String = ""
            Dim razonSocialProveedor As String = ""
            Dim identificacionProveedor As String = ""
            Dim direccionProveedor As String = ""
            Dim totalSinImpuestos As String = ""
            Dim totalDescuento As String = ""

            'totalConImpuestos
            Dim codigoPorcentaje As String = ""
            Dim baseImponibleFactura As String = ""
            Dim tarifa As String = ""
            Dim valorImpuesto As String = ""


            Dim importeTotal As String = ""

            'Pagos
            Dim formaPago As String = ""
            Dim total As String = ""
            Dim plazo As String = ""
            Dim unidadTiempo As String = ""
            '</infoFactura> 

            'Detalles Valores
            Dim codigoPrincipal As String = ""
            Dim descripcion As String = ""
            Dim cantidad As String = ""
            Dim precioUnitario As String = ""
            Dim descuentoDetalle As String = ""
            Dim precioTotalSinImpuesto As String = ""
            Dim codigoDetalleImpuesto As String = ""
            Dim baseImponibleDetalles As String = ""
            Dim valorDetalleImpuesto As String = ""
            Dim subtotal15 As Decimal = 0.0
            Dim subtotal0 As Decimal = 0.0
            Dim subtotalNoObjetoIva As Decimal = 0.0
            Dim subtotalExentoIva As Decimal = 0.0
            Dim ice As Decimal = 0.0
            Dim iva15 As Decimal = 0.0
            Dim totalDevolucionIva As Decimal = 0.0
            Dim irbpnr As Decimal = 0.0

            'infoAdicional
            Dim informacion As String = ""
            Dim retencion As String = ""


            Try

                Dim reader As New XmlTextReader(s)
                Dim cadenaXml = ""
                Dim nombreNodo = ""
                Dim xmlFileName As String = Path.GetFileNameWithoutExtension(CType(s, FileStream).Name)



                Dim txtFilePath As String = Path.Combine(Application.StartupPath & "\Leer XML Temp\pathLiquidacion.txt")

                Dim selectedFolderPath As String = ""
                If File.Exists(txtFilePath) Then
                    selectedFolderPath = File.ReadAllText(txtFilePath)
                End If


                Dim pdfFilePath As String = Path.Combine(selectedFolderPath, xmlFileName & ".pdf")



                reader.WhitespaceHandling = WhitespaceHandling.None

                While reader.Read()
                    Select Case reader.NodeType
                        Case XmlNodeType.Element
                            If reader.Name <> "" Then nombreNodo = reader.Name
                        Case XmlNodeType.Text
                            Dim valorNodo = reader.Value
                            If nombreNodo = "numeroAutorizacion" Then
                                numeroAutorizacion = Convert.ToString(valorNodo)
                            ElseIf nombreNodo = "fechaAutorizacion" Then
                                fechaAutorizacion = Convert.ToString(valorNodo)
                            ElseIf nombreNodo = "comprobante" Then

                            End If
                        Case XmlNodeType.CDATA
                            cadenaXml = reader.Value
                    End Select
                End While


                Dim nuevoXml As New XmlDocument
                nuevoXml.LoadXml(Trim(cadenaXml))
                nuevoXml.Save((Application.StartupPath & "\Leer XML Temp\lectorTempFact.xml"))
                reader.Close()

                Dim xmlDoc As New XmlDocument()
                Dim ruta As String = Convert.ToString(Application.StartupPath & "\Leer XML Temp\lectorTempFact.xml")
                xmlDoc.Load(ruta)


                Dim nodoRaiz As XmlNode = xmlDoc.DocumentElement
                Dim nodosMain As XmlNodeList = nodoRaiz.ChildNodes


                For Each nodoLiquidacion As XmlNode In nodosMain
                    Dim nuevoNodos As String = nodoLiquidacion.Name
                    Dim valoresNodo = nodoLiquidacion.InnerText

                    Select Case nuevoNodos
                        Case "infoTributaria"

                            For Each nodoInfo As XmlNode In nodoLiquidacion.ChildNodes

                                Select Case nodoInfo.Name

                                    Case "ambiente"
                                        If Convert.ToInt32(nodoInfo.InnerText) = 2 Then
                                            ambiente = "PRODUCCION"
                                        Else
                                            ambiente = "PRUEBAS"
                                        End If

                                    Case "tipoEmision"
                                        If Convert.ToInt32(nodoInfo.InnerText) = 1 Then
                                            tipoEmision = "NORMAL"
                                        Else
                                            tipoEmision = "INDISP DEL SISTEMA"
                                        End If

                                    Case "razonSocial"
                                        razonSocial = nodoInfo.InnerText
                                    Case "nombreComercial"
                                        nombreComercial = nodoInfo.InnerText
                                    Case "ruc"
                                        ruc = Convert.ToString(nodoInfo.InnerText)
                                    Case "claveAcceso"
                                        claveAcceso = nodoInfo.InnerText
                                    Case "codDoc"
                                        codDoc = nodoInfo.InnerText
                                    Case "estab"
                                        estab = nodoInfo.InnerText
                                    Case "ptoEmi"
                                        ptoEmi = nodoInfo.InnerText
                                    Case "secuencial"
                                        secuencial = nodoInfo.InnerText
                                    Case "dirMatriz"
                                        dirMatriz = nodoInfo.InnerText
                                    Case "agenteRetencion"
                                        agenteRetencion = nodoInfo.InnerText
                                End Select
                            Next
                        Case "infoLiquidacionCompra"

                            For Each nodoInfoLiquidacion As XmlNode In nodoLiquidacion.ChildNodes

                                Select Case nodoInfoLiquidacion.Name

                                    Case "fechaEmision"
                                        fechaEmision = nodoInfoLiquidacion.InnerText
                                    Case "dirEstablecimiento"
                                        dirEstablecimiento = nodoInfoLiquidacion.InnerText
                                    Case "obligadoContabilidad"
                                        obligadoContabilidad = nodoInfoLiquidacion.InnerText
                                    Case "tipoIdentificacionProveedor"
                                        tipoIdentificacionProveedor = nodoInfoLiquidacion.InnerText
                                    Case "razonSocialProveedor"
                                        razonSocialProveedor = nodoInfoLiquidacion.InnerText
                                    Case "identificacionProveedor"
                                        identificacionProveedor = nodoInfoLiquidacion.InnerText
                                    Case "direccionProveedor"
                                        direccionProveedor = nodoInfoLiquidacion.InnerText
                                    Case "totalSinImpuestos"
                                        totalSinImpuestos = nodoInfoLiquidacion.InnerText
                                    Case "totalDescuento"
                                        totalDescuento = nodoInfoLiquidacion.InnerText
                                        '<totalConImpuesto>
                                    Case "totalConImpuestos"
                                        For Each nodoTotalImpuesto As XmlNode In nodoInfoLiquidacion.ChildNodes
                                            Select Case nodoTotalImpuesto.Name
                                                Case "totalImpuesto"
                                                    For Each nodoImpuesto As XmlNode In nodoTotalImpuesto.ChildNodes
                                                        Select Case nodoImpuesto.Name
                                                            Case "codigo"
                                                                codigoPorcentaje = nodoImpuesto.InnerText
                                                            Case "codigoPorcentaje"
                                                                codigoPorcentaje = nodoImpuesto.InnerText
                                                            Case "baseImponible"
                                                                baseImponibleFactura = nodoImpuesto.InnerText
                                                            Case "tarifa"
                                                                tarifa = nodoImpuesto.InnerText
                                                            Case "valor"
                                                                valorImpuesto = nodoImpuesto.InnerText
                                                        End Select
                                                    Next
                                            End Select
                                        Next


                                        '</totalConImpuesto>


                                    Case "importeTotal"
                                        importeTotal = nodoInfoLiquidacion.InnerText
                                        ' <pagos>
                                    Case "pagos"
                                        For Each nodoPagos As XmlNode In nodoInfoLiquidacion.ChildNodes
                                            Select Case nodoPagos.Name
                                                Case "pago"
                                                    For Each nodoPago As XmlNode In nodoPagos.ChildNodes
                                                        Select Case nodoPago.Name
                                                            Case "formaPago"
                                                                formaPago = nodoPago.InnerText
                                                            Case ("total")
                                                                total = nodoPago.InnerText
                                                            Case "plazo"
                                                                plazo = nodoPago.InnerText
                                                            Case "unidadTiempo"
                                                                unidadTiempo = nodoPago.InnerText
                                                        End Select
                                                    Next
                                            End Select
                                        Next


                                        '</pagos>
                                        '<infFactura>
                                End Select

                            Next
                        Case "detalles"

                            For Each nodoDetalles As XmlNode In nodoLiquidacion.ChildNodes
                                Select Case nodoDetalles.Name
                                    Case "detalle"
                                        Dim _objDetalle As New ClassDetalleLiquidacionCompra
                                        For Each nodoDetalle As XmlNode In nodoDetalles.ChildNodes
                                            Select Case nodoDetalle.Name
                                                Case "codigoPrincipal"
                                                    _objDetalle.CodigoPrincipal = nodoDetalle.InnerText
                                                Case "descripcion"
                                                    _objDetalle.Descripcion = nodoDetalle.InnerText
                                                Case "cantidad"
                                                    _objDetalle.Cantidad = Decimal.Parse(nodoDetalle.InnerText)
                                                Case "precioUnitario"
                                                    _objDetalle.PrecioUnitario = Decimal.Parse(nodoDetalle.InnerText)
                                                Case "descuento"
                                                    _objDetalle.Descuento = Decimal.Parse(nodoDetalle.InnerText)
                                                Case "precioTotalSinImpuesto"
                                                    _objDetalle.PrecioTotalSinImpuesto = Decimal.Parse(nodoDetalle.InnerText)
                                                Case "impuestos"
                                                    For Each nodoImpuesto As XmlNode In nodoDetalle.ChildNodes
                                                        Select Case nodoImpuesto.Name
                                                            Case "impuesto"
                                                                For Each nodoImpuestoDetalle As XmlNode In nodoImpuesto.ChildNodes
                                                                    Select Case nodoImpuestoDetalle.Name
                                                                        Case "codigo"
                                                                            codigoDetalleImpuesto = nodoImpuestoDetalle.InnerText
                                                                        Case "baseImponible"
                                                                            baseImponibleDetalles = nodoImpuestoDetalle.InnerText
                                                                        Case "valor"
                                                                            valorDetalleImpuesto = nodoImpuestoDetalle.InnerText
                                                                    End Select
                                                                Next
                                                        End Select
                                                    Next

                                            End Select
                                        Next
                                        _Detalle.Add(_objDetalle)
                                End Select
                            Next
                        Case "infoAdicional"
                            For Each nodoInfoAdicional As XmlNode In nodoLiquidacion.ChildNodes
                                If nodoInfoAdicional.Name = "campoAdicional" Then
                                    Dim nombreCampo As String = nodoInfoAdicional.Attributes("nombre").Value
                                    Dim valorCampo As String = nodoInfoAdicional.InnerText

                                    Select Case nombreCampo
                                        Case "Informacion"
                                            informacion = valorCampo

                                        Case "Liquidacion de Compra"
                                            retencion = valorCampo



                                    End Select
                                End If
                            Next
                    End Select
                Next


                Dim document As New Document()
                Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(pdfFilePath, FileMode.Create))
                document.Open()

                Dim FormaPagoTable As DataTable = _objetoFormasPago.BuscarDetalleFormaPago(_tipoCon, Convert.ToInt32(formaPago))
                formaPago = Convert.ToString(FormaPagoTable.Rows(0)("DETALLE_FORMA_PAGO"))
                Dim baseFont As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED)
                Dim fuente10 As Font = New Font(baseFont, 10, Font.Bold)
                Dim fuente8 As Font = New Font(baseFont, 8)

                Dim logo As String = ValidationForms.NombreLogoNuevo(_tipoCon, Application.StartupPath)
                Dim imageLogo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(logo)
                imageLogo.ScaleToFit(130, 130)
                imageLogo.SetAbsolutePosition(110, 690)
                document.Add(imageLogo)



                Dim table1 As PdfPTable = New PdfPTable(1)
                table1.TotalWidth = 250
                table1.HorizontalAlignment = Element.ALIGN_CENTER
                table1.DefaultCell.BorderColor = iTextSharp.text.BaseColor.WHITE


                table1.AddCell(New Phrase("R.U.C.: " & ruc, fuente10))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("LIQUIDACIÓN DE COMPRA DE BIENES Y PRESTACIÓN DE SERVICIOS", fuente10))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("No: " & estab & " - " & ptoEmi & " - " & secuencial, fuente8))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("NUMERO DE AUTORIZACIÓN ", fuente8))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase(numeroAutorizacion, fuente8))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("FECHA Y HORA DE AUTORIZACIÓN: " & fechaAutorizacion, fuente8))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("AMBIENTE: " & ambiente, fuente8))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("EMISIÓN: " & tipoEmision, fuente8))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("CLAVE DE ACCESO ", fuente8))
                table1.AddCell(New Phrase("   ", fuente8))

                Dim noBorderCell As New PdfPCell(New Phrase(" "))
                noBorderCell.BorderWidthTop = 0
                noBorderCell.BorderWidthBottom = 0
                noBorderCell.BorderWidthLeft = 0
                noBorderCell.BorderWidthRight = 0

                table1.AddCell(noBorderCell)

                Dim barcode As Barcode128 = New Barcode128()
                barcode.Code = numeroAutorizacion
                barcode.CodeType = iTextSharp.text.pdf.Barcode.CODE128_UCC
                barcode.Extended = True
                Dim cb As PdfContentByte = writer.DirectContent
                Dim imgBar As iTextSharp.text.Image = barcode.CreateImageWithBarcode(cb, BaseColor.BLACK, BaseColor.BLACK)
                imgBar.ScalePercent(87)

                Dim emptyParrafo As New Paragraph()
                emptyParrafo.Add(New Chunk(" "))
                emptyParrafo.Leading = 10

                Dim barcodeCell As PdfPCell = New PdfPCell(imgBar)
                barcodeCell.AddElement(emptyParrafo)
                barcodeCell.AddElement(imgBar)
                barcodeCell.AddElement(emptyParrafo)
                barcodeCell.BorderColor = iTextSharp.text.BaseColor.WHITE


                table1.AddCell(barcodeCell)

                Dim xPositionTable1 As Single = 330
                Dim yPositonTable1 As Single = 820

                table1.WriteSelectedRows(0, -1, xPositionTable1, yPositonTable1, writer.DirectContent)

                Dim rectTabla1 As PdfContentByte = writer.DirectContent
                rectTabla1.RoundRectangle(320.0F, 520.0F, 250.0F, 305.0F, 15.0F)
                rectTabla1.Stroke()


                Dim table2 As PdfPTable = New PdfPTable(1)
                table2.TotalWidth = 250
                table2.HorizontalAlignment = Element.ALIGN_CENTER
                table2.DefaultCell.BorderColor = iTextSharp.text.BaseColor.WHITE

                table2.AddCell(New Phrase(razonSocial, fuente10))
                table2.AddCell(New Phrase("   ", fuente8))
                table2.AddCell(New Phrase(nombreComercial, fuente8))
                table2.AddCell(New Phrase("   ", fuente8))
                table2.AddCell(New Phrase("Dirección Matriz: " & dirMatriz, fuente8))
                table2.AddCell(New Phrase("   ", fuente8))
                table2.AddCell(New Phrase("Dirección Sucursal: " & dirEstablecimiento, fuente8))
                table2.AddCell(New Phrase("   ", fuente8))
                table2.AddCell(New Phrase("OBLIGADO A LLEVAR CONTABILIDAD: " & obligadoContabilidad, fuente8))
                table2.AddCell(New Phrase("   ", fuente8))
                table2.AddCell(New Phrase("Agente de Rentención Resolución No. : " & agenteRetencion, fuente8))

                Dim xPositionTable2 As Single = 25
                Dim yPositonTable2 As Single = 670

                table2.WriteSelectedRows(0, -1, xPositionTable2, yPositonTable2, writer.DirectContent)

                Dim rectTabla2 As PdfContentByte = writer.DirectContent
                rectTabla2.RoundRectangle(20.0F, 520.0F, 290.0F, 160.0F, 15.0F)
                rectTabla2.Stroke()


                Dim table3 As PdfPTable = New PdfPTable(1)
                table3.TotalWidth = 500
                table3.HorizontalAlignment = Element.ALIGN_CENTER
                table3.DefaultCell.BorderColor = iTextSharp.text.BaseColor.WHITE

                table3.AddCell(New Phrase("Nombres y Apellidos: " & "    " & razonSocialProveedor, fuente8))
                table3.AddCell(New Phrase("   ", fuente8))
                table3.AddCell(New Phrase("Identificación: " & identificacionProveedor, fuente8))
                table3.AddCell(New Phrase("Fecha: " & "    " & fechaEmision & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "Placa/Matricula: " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "Guia:", fuente8))
                table3.AddCell(New Phrase("   ", fuente8))
                table3.AddCell(New Phrase("Dirección: " & direccionProveedor, fuente8))


                Dim xPositionTable3 As Single = 25
                Dim yPositonTable3 As Single = 500

                table3.WriteSelectedRows(0, -1, xPositionTable3, yPositonTable3, writer.DirectContent)

                Dim rectTabla3 As PdfContentByte = writer.DirectContent
                rectTabla3.Rectangle(20.0F, 410.0F, 550.0F, 100.0F)
                rectTabla3.Stroke()

                Dim tableData As New DataTable()

                tableData.Columns.Add("Cod. Principal", GetType(String))
                tableData.Columns.Add("Cod. Auxiliar", GetType(String))
                tableData.Columns.Add("Cantidad", GetType(Decimal))
                tableData.Columns.Add("Descripcion", GetType(String))
                tableData.Columns.Add("Detalle Adicional", GetType(String))
                tableData.Columns.Add("Precio Unitario", GetType(Decimal))
                tableData.Columns.Add("Subsidio", GetType(Decimal))
                tableData.Columns.Add("Descuento", GetType(Decimal))
                tableData.Columns.Add("Precio Total", GetType(Decimal))

                For Each detalle As ClassDetalleLiquidacionCompra In _Detalle
                    Dim row As DataRow = tableData.NewRow()
                    row("cod. principal") = detalle.CodigoPrincipal
                    row("cod. auxiliar") = detalle.CodigoAuxiliar
                    row("cantidad") = detalle.Cantidad
                    row("descripcion") = detalle.Descripcion
                    row("detalle adicional") = detalle.DetalleAdicional
                    row("precio unitario") = detalle.PrecioUnitario
                    row("subsidio") = detalle.Subsidio
                    row("descuento") = detalle.Descuento
                    row("precio total") = detalle.PrecioTotalSinImpuesto
                    tableData.Rows.Add(row)
                Next

                Dim table4 As New PdfPTable(tableData.Columns.Count)
                table4.TotalWidth = 550

                Dim columnWidthsTable4() As Single = {70, 70, 70, 150, 70, 70, 70, 70, 70}

                For Each col As DataColumn In tableData.Columns
                    Dim headerCell As New PdfPCell(New Phrase(col.ColumnName, fuente8))
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER
                    headerCell.BorderWidth = 1
                    table4.AddCell(headerCell)
                Next

                Dim descripcionColumnWidth As Single = table4.TotalWidth / tableData.Columns.Count

                For Each row As DataRow In tableData.Rows
                    For colIndex As Integer = 0 To tableData.Columns.Count - 1
                        Dim cellValue As String = row(colIndex).ToString()
                        Dim cell As New PdfPCell(New Phrase(cellValue, fuente8))
                        cell.BorderWidth = 1
                        If colIndex >= 5 AndAlso colIndex <= 8 Then
                            cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        Else
                            cell.HorizontalAlignment = Element.ALIGN_CENTER
                        End If

                        table4.AddCell(cell)
                    Next
                Next


                table4.SetWidths(columnWidthsTable4)

                Dim DynamicTable4Height As Single = table4.TotalHeight
                Dim yPositionTable4 As Single = 430
                Dim xPositionTable4 As Single = 20
                Dim newYPositionTable4 As Single = yPositionTable4 - DynamicTable4Height

                table4.WriteSelectedRows(0, -1, xPositionTable4, newYPositionTable4, writer.DirectContent)


                Dim table5 As PdfPTable = New PdfPTable(2)
                table5.TotalWidth = 217
                table5.HorizontalAlignment = Element.ALIGN_CENTER
                Dim columnWidthsTable5() As Single = {165, 55}


                Dim cell1Row1 As New PdfPCell(New Phrase("SUBTOTAL 15%", fuente8))
                Dim cell2Row1 As New PdfPCell(New Phrase(baseImponibleDetalles, fuente8))
                cell2Row1.HorizontalAlignment = Element.ALIGN_RIGHT
                table5.AddCell(cell1Row1)
                table5.AddCell(cell2Row1)

                Dim cell1Row2 As New PdfPCell(New Phrase("SUBTOTAL 0%", fuente8))
                Dim cell2Row2 As New PdfPCell(New Phrase("0.00", fuente8))
                cell2Row2.HorizontalAlignment = Element.ALIGN_RIGHT
                table5.AddCell(cell1Row2)
                table5.AddCell(cell2Row2)

                Dim cell1Row3 As New PdfPCell(New Phrase("SUBTOTAL NO OBJETO DE IVA %", fuente8))
                Dim cell2Row3 As New PdfPCell(New Phrase("0.00", fuente8))
                cell2Row3.HorizontalAlignment = Element.ALIGN_RIGHT
                table5.AddCell(cell1Row3)
                table5.AddCell(cell2Row3)

                Dim cell1Row4 As New PdfPCell(New Phrase("SUBTOTAL EXENTO DE IVA %", fuente8))
                Dim cell2Row4 As New PdfPCell(New Phrase("0.00", fuente8))
                cell2Row4.HorizontalAlignment = Element.ALIGN_RIGHT
                table5.AddCell(cell1Row4)
                table5.AddCell(cell2Row4)

                Dim cell1Row5 As New PdfPCell(New Phrase("SUBTOTAL SIN IMPUESTO", fuente8))
                Dim cell2Row5 As New PdfPCell(New Phrase(baseImponibleDetalles, fuente8))
                cell2Row5.HorizontalAlignment = Element.ALIGN_RIGHT
                table5.AddCell(cell1Row5)
                table5.AddCell(cell2Row5)

                Dim cell1Row6 As New PdfPCell(New Phrase("ICE %", fuente8))
                Dim cell2Row6 As New PdfPCell(New Phrase("0.00", fuente8))
                cell2Row6.HorizontalAlignment = Element.ALIGN_RIGHT
                table5.AddCell(cell1Row6)
                table5.AddCell(cell2Row6)

                Dim cell1Row7 As New PdfPCell(New Phrase("IVA 15%", fuente8))
                Dim cell2Row7 As New PdfPCell(New Phrase(valorDetalleImpuesto, fuente8))
                cell2Row7.HorizontalAlignment = Element.ALIGN_RIGHT
                table5.AddCell(cell1Row7)
                table5.AddCell(cell2Row7)

                Dim cell1Row8 As New PdfPCell(New Phrase("TOTAL DEVOLUCION IVA %", fuente8))
                Dim cell2Row8 As New PdfPCell(New Phrase("0.00", fuente8))
                cell2Row8.HorizontalAlignment = Element.ALIGN_RIGHT
                table5.AddCell(cell1Row8)
                table5.AddCell(cell2Row8)

                Dim cell1Row9 As New PdfPCell(New Phrase("IRBPNR", fuente8))
                Dim cell2Row9 As New PdfPCell(New Phrase("0.00", fuente8))
                cell2Row9.HorizontalAlignment = Element.ALIGN_RIGHT
                table5.AddCell(cell1Row9)
                table5.AddCell(cell2Row9)

                Dim cell1Row10 As New PdfPCell(New Phrase("PROPINA", fuente8))
                Dim cell2Row10 As New PdfPCell(New Phrase("0.00", fuente8))
                cell2Row10.HorizontalAlignment = Element.ALIGN_RIGHT
                table5.AddCell(cell1Row10)
                table5.AddCell(cell2Row10)

                Dim cell1Row11 As New PdfPCell(New Phrase("VALOR TOTAL", fuente8))
                Dim cell2Row11 As New PdfPCell(New Phrase(importeTotal, fuente8))
                cell2Row11.HorizontalAlignment = Element.ALIGN_RIGHT
                table5.AddCell(cell1Row11)
                table5.AddCell(cell2Row11)


                For Each row As PdfPRow In table5.Rows
                    For Each cell As PdfPCell In row.GetCells()
                        cell.BorderWidth = 1
                    Next
                Next

                table5.SetWidths(columnWidthsTable5)

                Dim xPositionTable5 As Single = 353
                Dim yPositonTable5 As Single = newYPositionTable4 - DynamicTable4Height

                table5.WriteSelectedRows(0, -1, xPositionTable5, yPositonTable5, writer.DirectContent)


                Dim table6 As PdfPTable = New PdfPTable(2)
                table6.TotalWidth = 320
                Dim columnWidthsTable6() As Single = {100, 220}

                Dim Encabezado As New PdfPCell(New Phrase("Informacion Adicional", fuente10))
                Encabezado.Colspan = 2
                Encabezado.HorizontalAlignment = Element.ALIGN_CENTER
                Encabezado.HorizontalAlignment = Element.ALIGN_MIDDLE
                Encabezado.BorderWidth = 1
                table6.AddCell(Encabezado)

                Dim textInformacionTable6 As New PdfPCell(New Phrase("Informacion", fuente8))
                textInformacionTable6.BorderWidthLeft = 1
                textInformacionTable6.BorderWidthRight = 0
                textInformacionTable6.BorderWidthTop = 0
                textInformacionTable6.BorderWidthBottom = 0
                Dim informacionTable6 As New PdfPCell(New Phrase(informacion, fuente8))
                informacionTable6.BorderWidthLeft = 0
                informacionTable6.BorderWidthRight = 1
                informacionTable6.BorderWidthTop = 0
                informacionTable6.BorderWidthBottom = 0
                table6.AddCell(textInformacionTable6)
                table6.AddCell(informacionTable6)

                Dim textRetencionTable6 As New PdfPCell(New Phrase("Retencion", fuente8))
                textRetencionTable6.BorderWidthLeft = 1
                textRetencionTable6.BorderWidthRight = 0
                textRetencionTable6.BorderWidthTop = 0
                textRetencionTable6.BorderWidthBottom = 1
                Dim retencionTable6 As New PdfPCell(New Phrase(retencion, fuente8))
                retencionTable6.BorderWidthLeft = 0
                retencionTable6.BorderWidthRight = 1
                retencionTable6.BorderWidthTop = 0
                retencionTable6.BorderWidthBottom = 1
                table6.AddCell(textRetencionTable6)
                table6.AddCell(retencionTable6)



                table6.SetWidths(columnWidthsTable6)

                Dim xPositionTable6 As Single = 20
                Dim yTable6Height As Single = table6.TotalHeight
                Dim yPositonTable6 As Single = newYPositionTable4 - DynamicTable4Height - 5

                table6.WriteSelectedRows(0, -1, xPositionTable6, yPositonTable6, writer.DirectContent)


                Dim table7 As PdfPTable = New PdfPTable(2)
                table7.TotalWidth = 220
                Dim columnWidthsTable7() As Single = {170, 50}

                Dim FormaP As New PdfPCell(New Phrase("Forma de Pago", fuente10))
                FormaP.HorizontalAlignment = Element.ALIGN_CENTER
                FormaP.BorderWidth = 1
                table7.AddCell(FormaP)

                Dim TextValorP As New PdfPCell(New Phrase("Valor", fuente10))
                TextValorP.HorizontalAlignment = Element.ALIGN_CENTER
                TextValorP.BorderWidth = 1
                table7.AddCell(TextValorP)

                Dim valorFormaP As New PdfPCell(New Phrase(formaPago, fuente8))
                valorFormaP.HorizontalAlignment = Element.ALIGN_LEFT
                valorFormaP.BorderWidth = 1
                table7.AddCell(valorFormaP)

                Dim valorP As New PdfPCell(New Phrase(importeTotal, fuente8))
                valorP.HorizontalAlignment = Element.ALIGN_RIGHT
                valorP.BorderWidth = 1
                table7.AddCell(valorP)

                table7.SetWidths(columnWidthsTable7)

                Dim xPositionTable7 As Single = 20
                Dim yPositonTable7 As Single = yPositonTable6 - yTable6Height - 5

                table7.WriteSelectedRows(0, -1, xPositionTable7, yPositonTable7, writer.DirectContent)


                _Detalle.Clear()
                document.Close()
                xmlDoc = Nothing
                File.Delete(ruta)
                writer.Close()
                'MsgBox("LIQUIDACION DE COMPRA CREADA CORRECTAMENTE!", MsgBoxStyle.Information, "Mensaje de validación")
                KryptonMessageBox.Show("Liquidacion de compra creada correctamente!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)

            Catch ex As Exception
                'MsgBox("HUBO UN PROBLEMA AL CARGAR EL XML! " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Hubo un problema al cargar el XML! " & vbNewLine & ex.Message, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try

        End Sub

        Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub btnRetencionPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetencionPath.Click

            Dim rutaRetencion As String

            Select Case _tipoCon
                Case TipoConexion.Asenava
                    rutaRetencion = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA "
                Case TipoConexion.Seportpac
                    rutaRetencion = RutaDocsElec & "\COMPROBANTES GENERADOS\VENTAS\FACTURA "
                Case Else
                    rutaRetencion = RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO "
            End Select

            Dim folderBrowser As New FolderBrowserDialog()
            folderBrowser.Description = "Seleccione Ruta de Retencion"
            folderBrowser.SelectedPath = rutaRetencion

            If folderBrowser.ShowDialog() = DialogResult.OK Then
                Dim pathRetencion As String = folderBrowser.SelectedPath
                Dim txtFilePath As String = Path.Combine(Application.StartupPath & "\Leer XML Temp\pathRetencion.txt")
                File.WriteAllText(txtFilePath, pathRetencion)
                txtRetencionPath.Text = pathRetencion

            End If



           

        End Sub

        Private Sub btnLiquidacionPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiquidacionPath.Click
            Dim rutaRetencion As String

            Select Case _tipoCon
                Case TipoConexion.Asenava
                    rutaRetencion = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA "
                Case TipoConexion.Seportpac
                    rutaRetencion = RutaDocsElec & "\COMPROBANTES GENERADOS\VENTAS\FACTURA "
                Case Else
                    rutaRetencion = RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO "
            End Select

            Dim folderBrowser As New FolderBrowserDialog()
            folderBrowser.Description = "Seleccione Ruta de Retencion"
            folderBrowser.SelectedPath = rutaRetencion

            If folderBrowser.ShowDialog() = DialogResult.OK Then
                Dim pathLiquidacion As String = folderBrowser.SelectedPath
                Dim txtFilePath As String = Path.Combine(Application.StartupPath & "\Leer XML Temp\pathLiquidacion.txt")
                File.WriteAllText(txtFilePath, pathLiquidacion)
                txtLiquidacionPath.Text = pathLiquidacion

            End If


        End Sub

        Private Sub PDFRETENCIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PDFRETENCIONToolStripMenuItem.Click
            Dim ruta As String
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA "
                Case TipoConexion.Seportpac
                    ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\VENTAS\FACTURA "
                Case Else
                    ruta = RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO "
            End Select


            ofdSeleccionarArchivo.InitialDirectory = ruta
            ofdSeleccionarArchivo.Filter = "ARCHIVO DE FACTURA ELECTRÓNICA (*.xml)|*.xml"
            ofdSeleccionarArchivo.Title = "Seleccione el archivo de factura electrónica"
            If ofdSeleccionarArchivo.ShowDialog() <> Windows.Forms.DialogResult.OK Then Return

            Dim archivo = ofdSeleccionarArchivo.OpenFile


            LeerXmlRetencion(archivo)
            archivo.Close()
        End Sub

        Private Sub LeerXmlRetencion(ByVal s As System.IO.Stream)

            'infoTributaria
            Dim numeroAutorizacion As String = ""
            Dim fechaAutorizacion As String = ""
            Dim ambiente As String = ""
            Dim tipoEmision As String = ""
            Dim razonSocial As String = ""
            Dim nombreComercial As String = ""
            Dim ruc As String = ""
            Dim claveAcceso As String = ""
            Dim codDoc As String = ""
            Dim estab As String = ""
            Dim ptoEmi As String = ""
            Dim secuencial As String = ""
            Dim dirMatriz As String = ""
            Dim agenteRetencion As String = ""

            'infoFactura
            Dim fechaEmision As String = ""
            Dim dirEstablecimiento As String = ""
            Dim obligadoContabilidad As String = ""
            Dim tipoIdentificacionSujetoRetenido As String = ""
            Dim razonSocialSujetoRetenido As String = ""
            Dim identificacionSujetoRetenido As String = ""
            Dim periodoFiscal As String = ""


            'Impuestos
            Dim codigo As String = ""
            Dim codigoRetencion As String = ""
            Dim bseImponible As String = ""
            Dim valorRetenido As String = ""
            Dim codDocSustento As String = ""
            Dim numDocSustento As String = ""
            Dim fechaEmisionDocSustento As String = ""

            'infoAdicional
            Dim informacion As String = ""


            Try

                Dim reader As New XmlTextReader(s)
                Dim cadenaXml = ""
                Dim nombreNodo = ""
                Dim xmlFileName As String = Path.GetFileNameWithoutExtension(CType(s, FileStream).Name)

                Dim txtFilePath As String = Path.Combine(Application.StartupPath & "\Leer XML Temp\pathRetencion.txt")
                Dim selectedFolderPath As String = ""
                If File.Exists(txtFilePath) Then
                    selectedFolderPath = File.ReadAllText(txtFilePath)
                End If


                Dim pdfFilePath As String = Path.Combine(selectedFolderPath, xmlFileName & ".pdf")



                reader.WhitespaceHandling = WhitespaceHandling.None

                While reader.Read()
                    Select Case reader.NodeType
                        Case XmlNodeType.Element
                            If reader.Name <> "" Then nombreNodo = reader.Name
                        Case XmlNodeType.Text
                            Dim valorNodo = reader.Value
                            If nombreNodo = "numeroAutorizacion" Then
                                numeroAutorizacion = Convert.ToString(valorNodo)
                            ElseIf nombreNodo = "fechaAutorizacion" Then
                                fechaAutorizacion = Convert.ToString(valorNodo)
                            ElseIf nombreNodo = "comprobante" Then

                            End If
                        Case XmlNodeType.CDATA
                            cadenaXml = reader.Value
                    End Select
                End While


                Dim nuevoXml As New XmlDocument
                nuevoXml.LoadXml(Trim(cadenaXml))
                nuevoXml.Save((Application.StartupPath & "\Leer XML Temp\lectorTempFact.xml"))
                reader.Close()

                Dim xmlDoc As New XmlDocument()
                Dim ruta As String = Convert.ToString(Application.StartupPath & "\Leer XML Temp\lectorTempFact.xml")
                xmlDoc.Load(ruta)


                Dim nodoRaiz As XmlNode = xmlDoc.DocumentElement
                Dim nodosMain As XmlNodeList = nodoRaiz.ChildNodes


                For Each nodoRetencion As XmlNode In nodosMain
                    Dim nuevoNodos As String = nodoRetencion.Name
                    Dim valoresNodo = nodoRetencion.InnerText

                    Select Case nuevoNodos
                        Case "infoTributaria"

                            For Each nodoInfo As XmlNode In nodoRetencion.ChildNodes

                                Select Case nodoInfo.Name

                                    Case "ambiente"
                                        If Convert.ToInt32(nodoInfo.InnerText) = 2 Then
                                            ambiente = "PRODUCCION"
                                        Else
                                            ambiente = "PRUEBAS"
                                        End If
                                    Case "tipoEmision"
                                        If Convert.ToInt32(nodoInfo.InnerText) = 1 Then
                                            tipoEmision = "NORMAL"
                                        Else
                                            tipoEmision = "INDISP DEL SISTEMA"
                                        End If
                                    Case "razonSocial"
                                        razonSocial = nodoInfo.InnerText
                                    Case "nombreComercial"
                                        nombreComercial = nodoInfo.InnerText
                                    Case "ruc"
                                        ruc = Convert.ToString(nodoInfo.InnerText)
                                    Case "claveAcceso"
                                        claveAcceso = nodoInfo.InnerText
                                    Case "codDoc"  ' FACTURA => 01 / NOTA DE CRÉDITO => 04 /  LIQUIDACION DE COMPRA =>  03  / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
                                        codDoc = nodoInfo.InnerText
                                    Case "estab"
                                        estab = nodoInfo.InnerText
                                    Case "ptoEmi"
                                        ptoEmi = nodoInfo.InnerText
                                    Case "secuencial"
                                        secuencial = nodoInfo.InnerText
                                    Case "dirMatriz"
                                        dirMatriz = nodoInfo.InnerText
                                    Case "agenteRetencion"
                                        agenteRetencion = nodoInfo.InnerText
                                End Select
                            Next
                        Case "infoCompRetencion"

                            For Each nodoInfoCompRetencion As XmlNode In nodoRetencion.ChildNodes

                                Select Case nodoInfoCompRetencion.Name

                                    Case "fechaEmision"
                                        fechaEmision = nodoInfoCompRetencion.InnerText
                                    Case "dirEstablecimiento"
                                        dirEstablecimiento = nodoInfoCompRetencion.InnerText
                                    Case "obligadoContabilidad"
                                        obligadoContabilidad = nodoInfoCompRetencion.InnerText
                                    Case "tipoIdentificacionSujetoRetenido"
                                        tipoIdentificacionSujetoRetenido = nodoInfoCompRetencion.InnerText
                                    Case "razonSocialSujetoRetenido"
                                        razonSocialSujetoRetenido = nodoInfoCompRetencion.InnerText
                                    Case "identificacionSujetoRetenido"
                                        identificacionSujetoRetenido = nodoInfoCompRetencion.InnerText
                                    Case "periodoFiscal"
                                        periodoFiscal = nodoInfoCompRetencion.InnerText


                                End Select

                            Next
                        Case "impuestos"

                            For Each nodoImpuesto As XmlNode In nodoRetencion.ChildNodes
                                Select Case nodoImpuesto.Name
                                    Case "impuesto"
                                        Dim _objImpuesto As New ClassDetalleImpuestos
                                        For Each nodoDetalle As XmlNode In nodoImpuesto.ChildNodes
                                            Select Case nodoDetalle.Name
                                                Case "codigo" ' RENTA => 1 IVA => 2 / ISD => 6
                                                    Select Case nodoDetalle.InnerText
                                                        Case "1"
                                                            _objImpuesto.Codigo = "RENTA"
                                                        Case "2"
                                                            _objImpuesto.Codigo = "IVA"
                                                        Case "6"
                                                            _objImpuesto.Codigo = "ISD"
                                                    End Select

                                                Case "codigoRetencion"
                                                    _objImpuesto.CodigoRetencion = nodoDetalle.InnerText
                                                Case "baseImponible"
                                                    _objImpuesto.BaseImponible = Decimal.Parse(nodoDetalle.InnerText)
                                                Case "porcentajeRetener"
                                                    _objImpuesto.PorcentajeRetener = Decimal.Parse(nodoDetalle.InnerText)
                                                Case "valorRetenido"
                                                    _objImpuesto.ValorRetenido = Decimal.Parse(nodoDetalle.InnerText)
                                                Case "codDocSustento"  ' FACTURA => 01 / NOTA DE CRÉDITO => 04 /  LIQUIDACION DE COMPRA =>  03  / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
                                                    Select Case nodoDetalle.InnerText
                                                        Case "01"
                                                            _objImpuesto.CodDocSustento = "FACTURA"
                                                        Case "03"
                                                            _objImpuesto.CodDocSustento = "LIQUIDACION DE COMPRA"
                                                        Case "04"
                                                            _objImpuesto.CodDocSustento = "NOTA DE CREDITO"
                                                        Case "05"
                                                            _objImpuesto.CodDocSustento = "NOTA DE DEBITO"
                                                        Case "06"
                                                            _objImpuesto.CodDocSustento = "COMPROBANTE DE RETENCION"
                                                    End Select

                                                Case "numDocSustento"
                                                    _objImpuesto.NumDocSustento = nodoDetalle.InnerText
                                                Case "fechaEmisionDocSustento"
                                                    _objImpuesto.FechaEmisionDocSustento = nodoDetalle.InnerText
                                                    _objImpuesto.PeriodoFiscal = periodoFiscal
                                            End Select
                                        Next
                                        _Impuesto.Add(_objImpuesto)
                                End Select
                            Next
                        Case "infoAdicional"
                            For Each nodoInfoAdicional As XmlNode In nodoRetencion.ChildNodes
                                If nodoInfoAdicional.Name = "campoAdicional" Then
                                    Dim nombreCampo As String = nodoInfoAdicional.Attributes("nombre").Value
                                    Dim valorCampo As String = nodoInfoAdicional.InnerText

                                    Select Case nombreCampo
                                        Case "Informacion"
                                            informacion = valorCampo

                                    End Select
                                End If
                            Next
                    End Select
                Next


                Dim document As New Document()
                Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(pdfFilePath, FileMode.Create))
                document.Open()


                Dim baseFont As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED)
                Dim fuente10 As Font = New Font(baseFont, 10, Font.Bold)
                Dim fuente8 As Font = New Font(baseFont, 8)

                Dim logo As String = ValidationForms.NombreLogoNuevo(_tipoCon, Application.StartupPath)
                Dim imageLogo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(logo)
                imageLogo.ScaleToFit(130, 130)
                imageLogo.SetAbsolutePosition(110, 690)
                document.Add(imageLogo)



                Dim table1 As PdfPTable = New PdfPTable(1)
                table1.TotalWidth = 250
                table1.HorizontalAlignment = Element.ALIGN_CENTER
                table1.DefaultCell.BorderColor = iTextSharp.text.BaseColor.WHITE


                table1.AddCell(New Phrase("R.U.C.: " & ruc, fuente10))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("COMPROBANTE DE RETENCIÓN", fuente10))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("No: " & estab & " - " & ptoEmi & " - " & secuencial, fuente8))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("NÚMERO DE AUTORIZACIÓN ", fuente8))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase(numeroAutorizacion, fuente8))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("FECHA Y HORA DE AUTORIZACIÓN: " & fechaAutorizacion, fuente8))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("AMBIENTE: " & ambiente, fuente8))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("EMISIÓN: " & tipoEmision, fuente8))
                table1.AddCell(New Phrase("   ", fuente8))
                table1.AddCell(New Phrase("CLAVE DE ACCESO ", fuente8))
                table1.AddCell(New Phrase("   ", fuente8))

                Dim noBorderCell As New PdfPCell(New Phrase(" "))
                noBorderCell.BorderWidthTop = 0
                noBorderCell.BorderWidthBottom = 0
                noBorderCell.BorderWidthLeft = 0
                noBorderCell.BorderWidthRight = 0

                table1.AddCell(noBorderCell)

                Dim barcode As Barcode128 = New Barcode128()
                barcode.Code = numeroAutorizacion
                barcode.CodeType = iTextSharp.text.pdf.Barcode.CODE128_UCC
                barcode.Extended = True
                Dim cb As PdfContentByte = writer.DirectContent
                Dim imgBar As iTextSharp.text.Image = barcode.CreateImageWithBarcode(cb, BaseColor.BLACK, BaseColor.BLACK)
                imgBar.ScalePercent(87)

                Dim emptyParrafo As New Paragraph()
                emptyParrafo.Add(New Chunk(" "))
                emptyParrafo.Leading = 10

                Dim barcodeCell As PdfPCell = New PdfPCell(imgBar)
                barcodeCell.AddElement(emptyParrafo)
                barcodeCell.AddElement(imgBar)
                barcodeCell.AddElement(emptyParrafo)
                barcodeCell.BorderColor = iTextSharp.text.BaseColor.WHITE


                table1.AddCell(barcodeCell)

                Dim xPositionTable1 As Single = 330
                Dim yPositonTable1 As Single = 820

                table1.WriteSelectedRows(0, -1, xPositionTable1, yPositonTable1, writer.DirectContent)

                Dim rectTabla1 As PdfContentByte = writer.DirectContent
                rectTabla1.RoundRectangle(320.0F, 520.0F, 250.0F, 305.0F, 15.0F)
                rectTabla1.Stroke()


                Dim table2 As PdfPTable = New PdfPTable(1)
                table2.TotalWidth = 250
                table2.HorizontalAlignment = Element.ALIGN_CENTER
                table2.DefaultCell.BorderColor = iTextSharp.text.BaseColor.WHITE

                table2.AddCell(New Phrase(razonSocial, fuente10))
                table2.AddCell(New Phrase("   ", fuente8))
                table2.AddCell(New Phrase(nombreComercial, fuente8))
                table2.AddCell(New Phrase("   ", fuente8))
                table2.AddCell(New Phrase("Dirección Matriz: " & dirMatriz, fuente8))
                table2.AddCell(New Phrase("   ", fuente8))
                table2.AddCell(New Phrase("Dirección Sucursal: " & dirEstablecimiento, fuente8))
                table2.AddCell(New Phrase("   ", fuente8))
                table2.AddCell(New Phrase("OBLIGADO A LLEVAR CONTABILIDAD: " & obligadoContabilidad, fuente8))
                table2.AddCell(New Phrase("   ", fuente8))
                table2.AddCell(New Phrase("Agente de Rentención Resolución No. : " & agenteRetencion, fuente8))
                table2.AddCell(New Phrase("   ", fuente8))

                Dim xPositionTable2 As Single = 25
                Dim yPositonTable2 As Single = 680
                Dim yTable2Height As Single = table2.TotalHeight

                table2.WriteSelectedRows(0, -1, xPositionTable2, yPositonTable2, writer.DirectContent)

                Dim rectTabla2 As PdfContentByte = writer.DirectContent
                rectTabla2.RoundRectangle(20.0F, 520.0F, 290.0F, 160.0F, 15.0F)
                rectTabla2.Stroke()


                Dim table3 As PdfPTable = New PdfPTable(1)
                table3.TotalWidth = 500
                table3.HorizontalAlignment = Element.ALIGN_CENTER
                table3.DefaultCell.BorderColor = iTextSharp.text.BaseColor.WHITE

                table3.AddCell(New Phrase("Razón Social / Nombres y Apellidos: " & "    " & razonSocialSujetoRetenido, fuente8))
                table3.AddCell(New Phrase("   ", fuente8))
                table3.AddCell(New Phrase("Identificación: " & identificacionSujetoRetenido, fuente8))
                table3.AddCell(New Phrase("Fecha de Emisión: " & "    " & fechaEmision, fuente8))
                table3.AddCell(New Phrase("   ", fuente8))



                Dim xPositionTable3 As Single = 25
                Dim yPositonTable3 As Single = 500
                Dim YTable3Height As Single = table3.TotalHeight

                table3.WriteSelectedRows(0, -1, xPositionTable3, yPositonTable3, writer.DirectContent)

                Dim rectTabla3 As PdfContentByte = writer.DirectContent
                rectTabla3.Rectangle(20.0F, 440.0F, 550.0F, 70.0F)
                rectTabla3.Stroke()

                Dim tableData As New DataTable()

                tableData.Columns.Add("Comprobante", GetType(String))
                tableData.Columns.Add("Número", GetType(String))
                tableData.Columns.Add("Fecha Emisión", GetType(String))
                tableData.Columns.Add("Ejercicio Fiscal", GetType(String))
                tableData.Columns.Add("Base Imponible para la Retención", GetType(Decimal))
                tableData.Columns.Add("IMPUESTO", GetType(String))
                tableData.Columns.Add("Porcentaje Retención", GetType(Decimal))
                tableData.Columns.Add("Valor Retenido", GetType(Decimal))


                For Each impuesto As ClassDetalleImpuestos In _Impuesto
                    Dim row As DataRow = tableData.NewRow()
                    row("comprobante") = impuesto.CodDocSustento
                    row("número") = impuesto.NumDocSustento
                    row("fecha emisión") = impuesto.FechaEmisionDocSustento
                    row("ejercicio fiscal") = impuesto.PeriodoFiscal
                    row("Base imponible para la retención") = impuesto.BaseImponible
                    row("impuesto") = impuesto.Codigo
                    row("porcentaje retención") = impuesto.PorcentajeRetener
                    row("valor retenido") = impuesto.ValorRetenido
                    tableData.Rows.Add(row)
                Next

                Dim table4 As New PdfPTable(tableData.Columns.Count)
                table4.TotalWidth = 550

                Dim columnWidthsTable4() As Single = {70, 80, 70, 70, 70, 70, 70, 70}

                For Each col As DataColumn In tableData.Columns
                    Dim headerCell As New PdfPCell(New Phrase(col.ColumnName, fuente8))
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER
                    headerCell.BorderWidth = 1
                    table4.AddCell(headerCell)
                Next


                For Each row As DataRow In tableData.Rows
                    For colIndex As Integer = 0 To tableData.Columns.Count - 1
                        Dim cellValue As String = row(colIndex).ToString()
                        Dim cell As New PdfPCell(New Phrase(cellValue, fuente8))
                        cell.BorderWidth = 1
                        If colIndex >= 6 AndAlso colIndex <= 7 Then
                            cell.HorizontalAlignment = Element.ALIGN_RIGHT
                        Else
                            cell.HorizontalAlignment = Element.ALIGN_CENTER
                        End If

                        table4.AddCell(cell)
                    Next
                Next


                table4.SetWidths(columnWidthsTable4)

                Dim DynamicTable4Height As Single = table4.TotalHeight
                Dim yPositionTable4 As Single = 430
                Dim xPositionTable4 As Single = 20
                Dim newYPositionTable4 As Single = yPositonTable3 - YTable3Height - 10

                table4.WriteSelectedRows(0, -1, xPositionTable4, newYPositionTable4, writer.DirectContent)





                Dim table6 As PdfPTable = New PdfPTable(2)
                table6.TotalWidth = 320
                Dim columnWidthsTable6() As Single = {100, 220}

                Dim Encabezado As New PdfPCell(New Phrase("Informacion Adicional", fuente10))
                Encabezado.Colspan = 2
                Encabezado.HorizontalAlignment = Element.ALIGN_CENTER
                Encabezado.HorizontalAlignment = Element.ALIGN_MIDDLE
                Encabezado.BorderWidth = 1
                table6.AddCell(Encabezado)

                Dim textInformacionTable6 As New PdfPCell(New Phrase("Informacion", fuente8))
                textInformacionTable6.BorderWidthLeft = 1
                textInformacionTable6.BorderWidthRight = 0
                textInformacionTable6.BorderWidthTop = 0
                textInformacionTable6.BorderWidthBottom = 0
                Dim informacionTable6 As New PdfPCell(New Phrase(informacion, fuente8))
                informacionTable6.BorderWidthLeft = 0
                informacionTable6.BorderWidthRight = 1
                informacionTable6.BorderWidthTop = 0
                informacionTable6.BorderWidthBottom = 0
                table6.AddCell(textInformacionTable6)
                table6.AddCell(informacionTable6)
                Dim vacioTable6 As New PdfPCell(New Phrase(" ", fuente8))
                vacioTable6.Colspan = 2
                vacioTable6.BorderWidthLeft = 1
                vacioTable6.BorderWidthRight = 1
                vacioTable6.BorderWidthTop = 0
                vacioTable6.BorderWidthBottom = 1
                table6.AddCell(vacioTable6)




                table6.SetWidths(columnWidthsTable6)

                Dim xPositionTable6 As Single = 20
                Dim yTable6Height As Single = table6.TotalHeight
                Dim yPositonTable6 As Single = newYPositionTable4 - DynamicTable4Height - 5

                table6.WriteSelectedRows(0, -1, xPositionTable6, yPositonTable6, writer.DirectContent)




                _Impuesto.Clear()
                document.Close()
                xmlDoc = Nothing
                File.Delete(ruta)
                writer.Close()
                'MsgBox("COMPROBANTE DE RENTENCION CREADO CORRECTAMENTE!", MsgBoxStyle.Information, "Mensaje de validación")
                KryptonMessageBox.Show("Comprobante de retención creado correctamente!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)

            Catch ex As Exception
                'MsgBox("HUBO UN PROBLEMA AL CARGAR EL XML! " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Hubo un problema al cargar el XML! " & vbNewLine & ex.Message, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try

        End Sub

        Private Sub GENERARCOMPROBANTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GENERARCOMPROBANTEToolStripMenuItem.Click

        End Sub

        Private Sub dgvComprobantesCompra_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvComprobantesCompra.DataError
            e.ThrowException = False
        End Sub
    End Class
End Namespace