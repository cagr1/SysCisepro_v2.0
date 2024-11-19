Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_ELECTRONICOS
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
Imports System.Xml
Imports System.Text
'Imports CrystalDecisions.CrystalReports.Engine
'Imports System.Drawing
'Imports System.Drawing.Imaging
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
'Imports iTextSharp.text.Image
Imports System.Xml.XPath


Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormConsultaFacturasVenta
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

        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoNumeroRegistroAsientoFacturaVenta As New ClassNumeroRegistroAsientoFacturaVenta

        ReadOnly _objetoAsientoDiario As New ClassAjustarAsientosLibroDiario

        ReadOnly _objetoEmpresa As New ClassEmpresa

        ReadOnly _objetoComprobantesElectronicos As New ClassDocumentosElectronicos
        ReadOnly _objetoFormasPago As New ClassFormasPago
        Dim _Detalle As New List(Of ClassDetalle)


        Private _estadoFactura As Integer
        Dim _fechaDesde As String = ""
        Dim _fechaHasta As String = ""
        Dim _tipoBusqueda As Integer = 0
        '===== OBJETOS PARA VALIDACIONES ========================================================================================
        ReadOnly _validacionesNumeros As New ClassNumerico

        Private Sub AutocompletarNombreCliente()
            Try
                txtClienteGeneral.AutoCompleteCustomSource = _objetoClienteGeneral.Autocompletar(_tipoCon)
                txtClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
            End Try
        End Sub

        Private Sub autocompletarConsorcioCliente()
            Try
                txtClienteGeneral.AutoCompleteCustomSource = _objetoClienteGeneral.AutocompletarConsorcio(_tipoCon)
                txtClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
            End Try
        End Sub

        Private Sub autocompletarConceptoFactura()
            Try
                txtClienteGeneral.AutoCompleteCustomSource = _objetoFacturaVenta.Autocompletar(_tipoCon)
                txtClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
            End Try
        End Sub

        Private Sub validarValorAsiento()
            For indiceAsiento = 0 To dgvFacturaVenta.Rows.Count - 1

                dgvFacturaVenta.Rows(indiceAsiento).Cells("VALOR_ASIENTO").Value = _objetoAsientoDiario.BuscarValorDebeCuentaXNumeroRegistroCuenta(_tipoCon, dgvFacturaVenta.Rows(indiceAsiento).Cells("ASIENTO").Value, "1010205")

                If dgvFacturaVenta.Rows(indiceAsiento).Cells("TOTAL A COBRAR").Value = dgvFacturaVenta.Rows(indiceAsiento).Cells("VALOR_ASIENTO").Value Then
                    dgvFacturaVenta.Rows(indiceAsiento).Cells("VALOR_ASIENTO").Style.BackColor = Color.LightGreen
                Else
                    If dgvFacturaVenta.Rows(indiceAsiento).Cells("NOTA CREDITO").Value > 0 Then
                        dgvFacturaVenta.Rows(indiceAsiento).Cells("VALOR_ASIENTO").Style.BackColor = Color.LightGreen
                    Else
                        dgvFacturaVenta.Rows(indiceAsiento).Cells("VALOR_ASIENTO").Style.BackColor = Color.LightSalmon
                    End If
                End If
            Next
        End Sub

        Private Sub CargarFacturasVenta()
            If _tipoBusqueda = 2 Then
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.BuscarFacturaVentaXConsorcioRangoFecha(_tipoCon, txtClienteGeneral.Text, _fechaDesde, _fechaHasta)
                'lblNroRegistros.Text = objetoFacturaVenta.BuscarFacturaVentaXConsorcioRangoFecha(txtClienteGeneral.Text, fechaDesde, fechaHasta).Rows.Count            
            ElseIf _tipoBusqueda = 3 Then
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaXNumeroFactura(_tipoCon, txtClienteGeneral.Text)
                'lblNroRegistros.Text = objetoFacturaVenta.SeleccionarFacturaVentaXNumeroFactura(txtClienteGeneral.Text).Rows.Count
            ElseIf _tipoBusqueda = 5 Then
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.BuscarFacturaVentasXConceptoRangoFecha(_tipoCon, txtClienteGeneral.Text, _fechaDesde, _fechaHasta)
                'lblNroRegistros.Text = objetoFacturaVenta.BuscarFacturaVentaXConceptoRangoFecha(txtClienteGeneral.Text, fechaDesde, fechaHasta).Rows.Count
            Else
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturasVentaXParametros(_tipoCon, lblIdClienteGeneral.Text, _fechaDesde, _fechaHasta, _estadoFactura)
                'lblNroRegistros.Text = objetoFacturaVenta.SeleccionarFacturasVentaXParametros(lblIdClienteGeneral.Text, fechaDesde, fechaHasta, estadoFactura).Rows.Count
            End If

            lblNroRegistros.Text = dgvFacturaVenta.RowCount

            dgvFacturaVenta.AutoResizeColumns()
            dgvFacturaVenta.AutoResizeRows()

            dgvFacturaVenta.ReadOnly = True
            'dgvFacturaVenta.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvFacturaVenta.Sort(dgvFacturaVenta.Columns("FECHA"), System.ComponentModel.ListSortDirection.Ascending)

            For Each row As DataGridViewRow In dgvFacturaVenta.Rows
                If row.Cells("EST").Value = 0 Then
                    row.DefaultCellStyle.BackColor = Color.LightCoral
                End If
            Next

        End Sub

        Private Sub SumarTotalFacturas()
            Try
                Dim totalACobrar As Decimal = 0
                Dim totalNotaCredito As Decimal = 0
                Dim totalRetencion As Decimal = 0
                Dim totalSubtotal As Decimal = 0
                Dim totalIva As Decimal = 0
                Dim totalFacturacion As Decimal = 0

                For indiceSuma = 0 To dgvFacturaVenta.RowCount - 1
                    If dgvFacturaVenta.Rows(indiceSuma).Cells("EST").Value <> 0 Then
                        totalSubtotal += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells("SUBTOTAL").Value)
                        totalIva += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells("IVA").Value)
                        totalFacturacion += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells("TOTAL").Value)
                        totalRetencion += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells(17).Value)
                        totalNotaCredito += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells(18).Value)
                        totalACobrar += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells(19).Value)
                    End If
                Next

                txtTotalACobrar.Text = totalACobrar
                txtTotalNotaCredito.Text = totalNotaCredito
                txtTotalRetencion.Text = totalRetencion
                txtTotalSubtotal.Text = totalSubtotal
                txtTotalIVA.Text = totalIva
                txtTotalFacturas.Text = totalFacturacion
            Catch ex As Exception
                MsgBox(ex.Message.ToString)

            End Try
        End Sub

        Private Sub ValidarValorRetencion()
            Dim retencion As Decimal = 0
            For indiceValidar = 0 To dgvFacturaVenta.RowCount - 1
                retencion = CDec(dgvFacturaVenta.Rows(indiceValidar).Cells(14).Value) + CDec(dgvFacturaVenta.Rows(indiceValidar).Cells(16).Value)
                If retencion <> dgvFacturaVenta.Rows(indiceValidar).Cells(17).Value Then
                    dgvFacturaVenta.Rows(indiceValidar).Cells(17).Style.BackColor = Color.Red
                End If
            Next
        End Sub

        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then
                    MsgBox("No hay datos que exportar!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "VENTAS"

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
                MessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub CargarDatosEmpresa()
            Try
                dgvEmpresa.DataSource = _objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)

                If dgvEmpresa.RowCount > 0 Then

                End If
            Catch ex As Exception
                MsgBox("CARGAR DATOS EMPRESA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub
        Private Sub FormConsultaFacturasVenta_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvFacturaVenta.Font = New Drawing.Font("Roboto", 7, FontStyle.Regular)
            CargarDatosEmpresa()


            Dim txtFilePathFactura As String = Path.Combine(Application.StartupPath & "\Leer XML Temp\pathFactura.txt")
            If File.Exists(txtFilePathFactura) Then
                Dim selectedFolderPath1 As String = File.ReadAllText(txtFilePathFactura)
                txtFacturaPath.Text = selectedFolderPath1
            Else
                txtFacturaPath.Text = "No existe ruta"
            End If
        End Sub
        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click

            ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
            _fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
            _fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

            CargarFacturasVenta()

            SumarTotalFacturas()
            'validarValorRetencion()
            'validarValorAsiento()
            'Catch ex As Exception
            'End Try
        End Sub
        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            ExportarDatosExcel(dgvFacturaVenta, "FACTURAS")
        End Sub

        Private Sub txtClienteGeneral_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClienteGeneral.KeyDown
            If e.KeyCode = Keys.Enter Then
                If rbPorCliente.Checked = True Then

                    lblIdClienteGeneral.Text = _objetoClienteGeneral.BuscarIdClienteXRazonSocial(_tipoCon, txtClienteGeneral.Text)
                ElseIf rbNroFactura.Checked = True Then
                    If txtClienteGeneral.Text <> "" Then

                        ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
                        _fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
                        _fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"
                        CargarFacturasVenta()
                        SumarTotalFacturas()
                    End If
                End If

            End If
        End Sub

        Private Sub txtClienteGeneral_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtClienteGeneral.KeyPress
            If rbNroFactura.Checked Then
                e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
            End If
        End Sub

        Private Sub rbFacturasActivas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbFacturasActivas.CheckedChanged
            If rbFacturasActivas.Checked = True Then
                _estadoFactura = 1
            Else
                _estadoFactura = 3
            End If
        End Sub

        Private Sub rbFacturasAnuladas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbFacturasAnuladas.CheckedChanged
            If rbFacturasAnuladas.Checked = True Then
                _estadoFactura = 0
            Else
                _estadoFactura = 3
            End If
        End Sub

        Private Sub rbFacturasTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbFacturasTodas.CheckedChanged
            If rbFacturasTodas.Checked = True Then
                _estadoFactura = 3
            End If
        End Sub

        Private Sub dgvFacturaVenta_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturaVenta.CellDoubleClick
            Try
                If dgvFacturaVenta.CurrentRow.Cells("EST").Value = 0 Then Return
                Dim formAsientoDiario As New FormBuscarAsientoDiario
                formAsientoDiario.TipoCox = TipoCox
                If dgvFacturaVenta.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    lblIdFacturaVenta.Text = "..."
                Else
                    lblIdFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(0).Value
                    formAsientoDiario.NumeroRegsitroBusqueda = _objetoNumeroRegistroAsientoFacturaVenta.BuscarNumeroRegistroAsientoPorIdFactura(_tipoCon, lblIdFacturaVenta.Text)
                    DialogResult = formAsientoDiario.ShowDialog
                End If
            Catch ex As Exception
                MessageBox.Show("Error al cargar asiento de venta!")
            End Try
        End Sub

        Private Sub rbPorCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPorCliente.CheckedChanged
            If rbPorCliente.Checked = True Then
                gbClienteGeneral.Enabled = True
                gbClienteGeneral.Text = "INGRESE RAZON SOCIAL DEL CLIENTE"
                lblIdClienteGeneral.Text = 0
                txtClienteGeneral.Text = ""
                gbEstadoFactura.Enabled = True
                gbRangoFechas.Enabled = True
                _tipoBusqueda = 1
                AutocompletarNombreCliente()
            End If
        End Sub

        Private Sub rbConsorcio_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbConsorcio.CheckedChanged
            If rbConsorcio.Checked = True Then
                gbClienteGeneral.Enabled = True
                gbClienteGeneral.Text = "INGRESE CONSORCIO / GRUPO EMPRESARIAL"
                lblIdClienteGeneral.Text = 0
                txtClienteGeneral.Text = ""
                gbEstadoFactura.Enabled = True
                gbRangoFechas.Enabled = True
                _tipoBusqueda = 2
                autocompletarConsorcioCliente()
            End If
        End Sub

        Private Sub rbNroFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNroFactura.CheckedChanged
            If rbNroFactura.Checked = True Then
                gbClienteGeneral.Enabled = True
                gbClienteGeneral.Text = "INGRESE NÚMERO DE FACTURA"
                lblIdClienteGeneral.Text = 0
                txtClienteGeneral.Text = 0
                gbEstadoFactura.Enabled = False
                gbRangoFechas.Enabled = False
                _tipoBusqueda = 3
            End If
        End Sub

        Private Sub rbTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTodo.CheckedChanged
            If rbTodo.Checked = True Then
                gbClienteGeneral.Enabled = False
                gbEstadoFactura.Enabled = True
                gbRangoFechas.Enabled = True
                lblIdClienteGeneral.Text = 0
                txtClienteGeneral.Text = ""
                _tipoBusqueda = 4
            End If
        End Sub

        Private Sub rbConcepto_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbConcepto.CheckedChanged
            If rbConcepto.Checked = True Then
                gbClienteGeneral.Enabled = True
                gbClienteGeneral.Text = "INGRESE CONCEPTO DE VENTA DE FACTURA"
                lblIdClienteGeneral.Text = 0
                txtClienteGeneral.Text = ""
                gbEstadoFactura.Enabled = True
                gbRangoFechas.Enabled = True
                lblIdClienteGeneral.Text = 0
                txtClienteGeneral.Text = ""
                _tipoBusqueda = 5
                autocompletarConceptoFactura()
            End If
        End Sub

        Private Sub btnValidar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnValidar.Click
            ValidarValorRetencion()
            validarValorAsiento()
        End Sub

        Private Sub dgvFacturaVenta_Sorted(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturaVenta.Sorted
            For Each row As DataGridViewRow In dgvFacturaVenta.Rows
                If row.Cells("EST").Value = 0 Then
                    row.DefaultCellStyle.BackColor = Color.LightCoral
                    row.DefaultCellStyle.ForeColor = Color.DarkRed
                End If
            Next
        End Sub

        Private Sub dgvFacturaVenta_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturaVenta.SelectionChanged
            If dgvFacturaVenta.RowCount = 0 Then Return
            If dgvFacturaVenta.CurrentRow Is Nothing Then Return
            If dgvFacturaVenta.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdFacturaVenta.Text = "..."
            Else
                lblIdFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(0).Value
            End If
        End Sub

        Public RutaDocsElec As String
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSalir.Click
            Try
                Dim data = _objetoComprobantesElectronicos.BuscarComprobanteElectronicoByIdComprobanteTipo(_tipoCon, "FACTURA VENTA", lblIdFacturaVenta.Text)
                If data.Rows.Count = 0 Then
                    MsgBox("NO SE ENCONTRÓ COMPROBANTE ELECTRONICO!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    Return
                End If

                Dim numeroFactura = data.Rows(0)(5)
                Dim documento = data.Rows(0)(3)

                Dim ruta As String
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA " & numeroFactura & ".xml"
                    Case TipoConexion.Seportpac
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\VENTAS\FACTURA " & numeroFactura & ".xml"
                    Case Else
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA " & numeroFactura & ".xml"
                End Select
                 
                Dim writer As XmlTextWriter
                writer = New XmlTextWriter(ruta, Encoding.UTF8)
                writer.Formatting = Formatting.Indented
                writer.WriteRaw(documento)
                writer.Flush()
                writer.Close()

                MsgBox("COMPROBANTE ELECTRONICO EXPORTADO CORRECTAMENTE!", MsgBoxStyle.Information, "Mensaje de validación")
            Catch ex As Exception
                MsgBox("HUBO UN PROBLEMA AL CARGAR EL COMPROBANTE ELECTRONICO! " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de validación")
            End Try
        End Sub

        Private Sub ESTADÍSTICOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTADÍSTICOToolStripMenuItem.Click
            If dgvFacturaVenta.Rows.Count > 0 Then

                Dim f = New FormReporteVentas
                f.EsChart = True
                f.TipoCox = TipoCox
                f.lblFechaInicial.Text = _fechaDesde
                f.lblFechaFinal.Text = _fechaHasta
                f.Show()
            Else
                MsgBox("NO HAY FACTURAS QUE CARGAR. Primero realice una busqueda", MsgBoxStyle.Exclamation, "Mensaje de validación")
            End If
        End Sub

        Private Sub REPORTEDEVENTASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTEDEVENTASToolStripMenuItem.Click
            If dgvFacturaVenta.Rows.Count > 0 Then

                Dim f = New FormReporteVentas
                f.EsChart = False

                f.subt = txtTotalSubtotal.Text
                f.iva = txtTotalIVA.Text
                f.tot = txtTotalFacturas.Text
                f.reten = txtTotalRetencion.Text
                f.notac = txtTotalNotaCredito.Text
                f.pagar = txtTotalACobrar.Text

                f.DataGrid = dgvFacturaVenta
                f.TipoCox = TipoCox
                f.lblFechaInicial.Text = _fechaDesde
                f.lblFechaFinal.Text = _fechaHasta
                f.Show()
            Else
                MsgBox("NO HAY FACTURAS QUE CARGAR. Primero realice una busqueda", MsgBoxStyle.Exclamation, "Mensaje de validación")
            End If
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click

        End Sub

        Private Sub GENERARFACTURAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GENERARFACTURAToolStripMenuItem.Click


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
            Dim tipoIdentificacionComprador As String = ""
            Dim razonSocialComprador As String = ""
            Dim identificacionComprador As String = ""
            Dim direccionComprador As String = ""
            Dim totalSinImpuestos As String = ""
            Dim totalDescuento As String = ""

            'totalConImpuestos
            Dim codigoPorcentaje As String = ""
            Dim baseImponibleFactura As String = ""
            Dim tarifa As String = ""
            Dim valorImpuesto As String = ""

            Dim propina As String = ""
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
            Dim Observaciones As String = ""

            Try

                Dim reader As New XmlTextReader(s)
                Dim cadenaXml = ""
                Dim nombreNodo = ""
                Dim xmlFileName As String = Path.GetFileNameWithoutExtension(CType(s, FileStream).Name)


                Dim txtFilePath As String = Path.Combine(Application.StartupPath & "\Leer XML Temp\pathFactura.txt")

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


                For Each nodoFactura As XmlNode In nodosMain
                    Dim nuevoNodos As String = nodoFactura.Name
                    Dim valoresNodo = nodoFactura.InnerText

                    Select Case nuevoNodos
                        Case "infoTributaria"

                            For Each nodoInfo As XmlNode In nodoFactura.ChildNodes

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
                        Case "infoFactura"

                            For Each nodoInfoFactura As XmlNode In nodoFactura.ChildNodes

                                Select Case nodoInfoFactura.Name

                                    Case "fechaEmision"
                                        fechaEmision = nodoInfoFactura.InnerText
                                    Case "dirEstablecimiento"
                                        dirEstablecimiento = nodoInfoFactura.InnerText
                                    Case "obligadoContabilidad"
                                        obligadoContabilidad = nodoInfoFactura.InnerText
                                    Case "tipoIdentificacionComprador"
                                        tipoIdentificacionComprador = nodoInfoFactura.InnerText
                                    Case "razonSocialComprador"
                                        razonSocialComprador = nodoInfoFactura.InnerText
                                    Case "identificacionComprador"
                                        identificacionComprador = nodoInfoFactura.InnerText
                                    Case "direccionComprador"
                                        direccionComprador = nodoInfoFactura.InnerText
                                    Case "totalSinImpuestos"
                                        totalSinImpuestos = nodoInfoFactura.InnerText
                                    Case "totalDescuento"
                                        totalDescuento = nodoInfoFactura.InnerText
                                        '<totalConImpuesto>
                                    Case "totalConImpuestos"
                                        For Each nodoTotalImpuesto As XmlNode In nodoInfoFactura.ChildNodes
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

                                    Case "propina"
                                        propina = nodoInfoFactura.InnerText
                                    Case "importeTotal"
                                        importeTotal = nodoInfoFactura.InnerText
                                        ' <pagos>
                                    Case "pagos"
                                        For Each nodoPagos As XmlNode In nodoInfoFactura.ChildNodes
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

                            For Each nodoDetalles As XmlNode In nodoFactura.ChildNodes
                                Select Case nodoDetalles.Name
                                    Case "detalle"
                                        Dim _objDetalle As New ClassDetalle
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
                            For Each nodoInfoAdicional As XmlNode In nodoFactura.ChildNodes
                                If nodoInfoAdicional.Name = "campoAdicional" Then
                                    Dim nombreCampo As String = nodoInfoAdicional.Attributes("nombre").Value
                                    Dim valorCampo As String = nodoInfoAdicional.InnerText

                                    Select Case nombreCampo
                                        Case "Informacion"
                                            informacion = valorCampo

                                        Case "Retencion"
                                            retencion = valorCampo

                                        Case "Observaciones"
                                            Observaciones = valorCampo

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
                table1.AddCell(New Phrase("FACTURA ", fuente10))
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

                table3.AddCell(New Phrase("Razón Social / Nombres y Apellidos: " & "    " & razonSocialComprador, fuente8))
                table3.AddCell(New Phrase("   ", fuente8))
                table3.AddCell(New Phrase("Identificación: " & identificacionComprador, fuente8))
                table3.AddCell(New Phrase("Fecha: " & "    " & fechaEmision & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "Placa/Matricula: " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "Guia:", fuente8))
                table3.AddCell(New Phrase("   ", fuente8))
                table3.AddCell(New Phrase("Dirección: " & direccionComprador, fuente8))


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
                tableData.Columns.Add("Descripción", GetType(String))
                tableData.Columns.Add("Detalle Adicional", GetType(String))
                tableData.Columns.Add("Precio Unitario", GetType(Decimal))
                tableData.Columns.Add("Subsidio", GetType(Decimal))
                tableData.Columns.Add("Descuento", GetType(Decimal))
                tableData.Columns.Add("Precio Total", GetType(Decimal))

                For Each detalle As ClassDetalle In _Detalle
                    Dim row As DataRow = tableData.NewRow()
                    row("cod. principal") = detalle.CodigoPrincipal
                    row("cod. auxiliar") = detalle.CodigoAuxiliar
                    row("cantidad") = detalle.Cantidad
                    row("descripción") = detalle.Descripcion
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
                Dim yTable5Height As Single = table5.TotalHeight
                Dim yPositonTable5 As Single = newYPositionTable4 - DynamicTable4Height

                table5.WriteSelectedRows(0, -1, xPositionTable5, yPositonTable5, writer.DirectContent)

                Dim table8 As PdfPTable = New PdfPTable(2)
                table8.TotalWidth = 217
                Dim columnWidthsTable8() As Single = {140, 70}

                Dim table811 As New PdfPCell(New Phrase("VALOR TOTAL SIN SUBSIDIO", fuente8))
                table811.HorizontalAlignment = Element.ALIGN_LEFT
                table811.BorderWidthTop = 1
                table811.BorderWidthLeft = 1
                table811.BorderWidthRight = 0
                table811.BorderWidthBottom = 0
                table8.AddCell(table811)

                Dim table812 As New PdfPCell(New Phrase("0.00", fuente8))
                table812.HorizontalAlignment = Element.ALIGN_RIGHT
                table812.BorderWidthTop = 1
                table812.BorderWidthLeft = 0
                table812.BorderWidthRight = 1
                table812.BorderWidthBottom = 0
                table8.AddCell(table812)

                Dim table821 As New PdfPCell(New Phrase("AHORRO POR SUBSIDIO:" & vbCrLf & "Incluye IVA cuando corresponda", fuente8))
                table821.HorizontalAlignment = Element.ALIGN_LEFT
                table821.BorderWidthTop = 0
                table821.BorderWidthLeft = 1
                table821.BorderWidthRight = 0
                table821.BorderWidthBottom = 1
                table8.AddCell(table821)

                Dim table822 As New PdfPCell(New Phrase("0.00", fuente8))
                table822.HorizontalAlignment = Element.ALIGN_RIGHT
                table822.BorderWidthTop = 0
                table822.BorderWidthLeft = 0
                table822.BorderWidthRight = 1
                table822.BorderWidthBottom = 1
                table8.AddCell(table822)

                table8.SetWidths(columnWidthsTable8)

                Dim xPositionTable8 As Single = 353
                Dim yPositonTable8 As Single = yPositonTable5 - yTable5Height - 5

                table8.WriteSelectedRows(0, -1, xPositionTable8, yPositonTable8, writer.DirectContent)





                Dim table6 As PdfPTable = New PdfPTable(2)
                table6.TotalWidth = 320
                Dim columnWidthsTable6() As Single = {100, 220}

                Dim Encabezado As New PdfPCell(New Phrase("Información Adicional", fuente10))
                Encabezado.Colspan = 2
                Encabezado.HorizontalAlignment = Element.ALIGN_CENTER
                Encabezado.HorizontalAlignment = Element.ALIGN_MIDDLE
                Encabezado.BorderWidth = 1
                table6.AddCell(Encabezado)

                Dim textInformacionTable6 As New PdfPCell(New Phrase("Información", fuente8))
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

                Dim textRetencionTable6 As New PdfPCell(New Phrase("Retención", fuente8))
                textRetencionTable6.BorderWidthLeft = 1
                textRetencionTable6.BorderWidthRight = 0
                textRetencionTable6.BorderWidthTop = 0
                textRetencionTable6.BorderWidthBottom = 0
                Dim retencionTable6 As New PdfPCell(New Phrase(retencion, fuente8))
                retencionTable6.BorderWidthLeft = 0
                retencionTable6.BorderWidthRight = 1
                retencionTable6.BorderWidthTop = 0
                retencionTable6.BorderWidthBottom = 0
                table6.AddCell(textRetencionTable6)
                table6.AddCell(retencionTable6)


                Dim textObservacionTable6 As New PdfPCell(New Phrase("Observaciones", fuente8))
                textObservacionTable6.BorderWidthLeft = 1
                textObservacionTable6.BorderWidthRight = 0
                textObservacionTable6.BorderWidthTop = 0
                textObservacionTable6.BorderWidthBottom = 1
                Dim observacionesTable6 As New PdfPCell(New Phrase(Observaciones, fuente8))
                observacionesTable6.BorderWidthLeft = 0
                observacionesTable6.BorderWidthRight = 1
                observacionesTable6.BorderWidthTop = 0
                observacionesTable6.BorderWidthBottom = 1
                table6.AddCell(textObservacionTable6)
                table6.AddCell(observacionesTable6)


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
                MsgBox("FACTURA CREADA CORRECTAMENTE!", MsgBoxStyle.Information, "Mensaje de validación")

            Catch ex As Exception
                MsgBox("HUBO UN PROBLEMA AL CARGAR EL XML! " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de validación")
            End Try

        End Sub



        Private Sub btnFacturaPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturaPath.Click
            Dim rutaFactura As String

            Select Case _tipoCon
                Case TipoConexion.Asenava
                    rutaFactura = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA "
                Case TipoConexion.Seportpac
                    rutaFactura = RutaDocsElec & "\COMPROBANTES GENERADOS\VENTAS\FACTURA "
                Case Else
                    rutaFactura = RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO "
            End Select

            Dim folderBrowser As New FolderBrowserDialog()
            folderBrowser.Description = "Seleccione Ruta de Retencion"
            folderBrowser.SelectedPath = rutaFactura

            If folderBrowser.ShowDialog() = DialogResult.OK Then
                Dim pathFactura As String = folderBrowser.SelectedPath
                Dim txtFilePath As String = Path.Combine(Application.StartupPath & "\Leer XML Temp\pathFactura.txt")
                File.WriteAllText(txtFilePath, pathFactura)
                txtFacturaPath.Text = pathFactura

            End If

        End Sub
    End Class
End Namespace