Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports ClassLibraryCisepro.INVENTARIOS.ITEMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports System.Xml
Imports System.Text
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Krypton.Toolkit

Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormConsultaNotasCredito
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
        Dim _sqlCommands As List(Of SqlCommand)
        Public IdUsuario As Integer

        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoSecuencialItem As New ClassSecuencialItem
        ReadOnly _objetoDetalleFacturaVenta As New ClassDetalleFacturaVenta
        ReadOnly _objetoNotaCredito As New ClassNotaCredito
        ReadOnly _objetoNumeroRegistroAsientoNotaCredito As New ClassNumeroRegistroAsientoNotaCreditoVenta
        ReadOnly _objetoEmpresa As New ClassEmpresa
        ReadOnly _objetoAsientoDiario As New ClassAjustarAsientosLibroDiario
        ReadOnly _objetoInformacionTributaria As New ClassInformacionTributaria

        Dim _Detalle As New List(Of ClassDetalle)

        Dim _estadoNotaCredito As Integer
        Dim _fechaDesde As String = ""
        Dim _fechaHasta As String = ""
        Dim _tipoBusqueda As Integer = 0

        Dim _numeroFacturaVenta As String = ""

        Dim _rucCliente As String = ""
        Dim _razonSocialCliente As String = ""
        Dim _tipoAmbiente As Integer = 0 ' tipo de ambiente para facturación electrónica: 1 => PRUEBAS / 2 => PRODUCCIÓN
        Dim _tipoEmision As Integer = 0 ' tipo de emisión para facturación electrónica: 1 => NORMAL / 2 => INDISPONIBILIDAD DEL SISTEMA
        Dim _rucEmpresa As String = ""
        Dim _razonSocialEmpresa As String = "" ' razon social de la empresa emisora de la factura electrónica
        Dim _nombreComercialEmpresa As String = ""
        Dim _direccionEmpresa As String = ""
        Dim _numAutoContEspecial As String = ""
        Dim _fechaEmisionNotaCredito As DateTime = Nothing
        Dim _establecimientoNotaCredito As String = ""
        Dim _ptoEmisionNotaCredito As String = ""
        Dim _secuencialNotaCredito As String = "" 'Dim numeroRetencion As String = ""
        Dim _porcentajeIva As Integer = 0
        Dim _claveAcceso As String = "" ' clave de acceso para envio de la factura electrónica
        Dim _tipoIdentificacionCliente As String = "" ' tipo de identificacion del cliente RUC => 01 / CEDULA => 05 / PASAPORTE => 06 / CONSUMIDOR FINAL => 07

        Private Sub FormConsultaNotasCredito_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing
                    'MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvNotaCredito.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'dgvNotaCredito.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvNotaCredito.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            dgvNotaCredito.Font = New Drawing.Font("Roboto", 8, FontStyle.Regular)
            Dim txtFilePathNotaCredito As String = Path.Combine(Application.StartupPath & "\Leer XML Temp\pathRetencion.txt")
            If File.Exists(txtFilePathNotaCredito) Then
                Dim selectedFolderPath1 As String = File.ReadAllText(txtFilePathNotaCredito)
                txtNotaCreditoPath.Text = selectedFolderPath1
            Else
                txtNotaCreditoPath.Text = "No existe ruta"
            End If

            CargarDatosEmpresa()
            lblSubtotalIva.Text = "Subtotal " + _porcentajeIva.ToString + ":"
            lblIva.Text = "IVA (" + _porcentajeIva.ToString + "):"
        End Sub
        Private Sub CargarDatosEmpresa()
            Try
                Dim epr = _objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)
                If epr.Rows.Count > 0 Then
                    _rucEmpresa = epr.Rows(0)(2)
                    _razonSocialEmpresa = epr.Rows(0)(3)
                    _nombreComercialEmpresa = epr.Rows(0)(4)
                    _direccionEmpresa = epr.Rows(0)(5)
                    _numAutoContEspecial = epr.Rows(0)(6)
                    _establecimientoNotaCredito = epr.Rows(0)(13)
                    _ptoEmisionNotaCredito = epr.Rows(0)(14)
                    _porcentajeIva = epr.Rows(0)(21)
                End If
            Catch ex As Exception
                'MsgBox("CARGAR DATOS EMPRESA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Cargar datos empresa." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub rbPorCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPorCliente.CheckedChanged
            If rbPorCliente.Checked Then
                'gbClienteGeneral.Enabled = True
                'gbEstadoFactura.Enabled = True
                rbActivas.Enabled = True
                rbAnuladas.Enabled = True
                rbTodas.Enabled = True
                'gbRangoFechas.Enabled = True
                dtpFechaDesde.Enabled = True
                dtpFechaHasta.Enabled = True
                'gbNumeroFactura.Enabled = False
                txtNumeroFacturaBuscar.Enabled = False
                txtNumeroFacturaBuscar.Clear()
                txtClienteGeneral.Clear()
                txtClienteGeneral.Enabled = True
                lblIdClienteGeneral.Text = "0"
                _tipoBusqueda = 1
                AutocompletarNombreCliente()
                txtClienteGeneral.Focus()
            End If
        End Sub
        Private Sub AutocompletarNombreCliente()
            Try
                txtClienteGeneral.AutoCompleteCustomSource = _objetoClienteGeneral.Autocompletar(_tipoCon)
                txtClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtClienteGeneral.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub rbConsorcio_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbConsorcio.CheckedChanged
            If rbConsorcio.Checked = True Then
                'gbClienteGeneral.Enabled = True
                'gbEstadoFactura.Enabled = True
                rbActivas.Enabled = True
                rbAnuladas.Enabled = True
                rbTodas.Enabled = True
                'gbRangoFechas.Enabled = True
                dtpFechaDesde.Enabled = True
                dtpFechaHasta.Enabled = True
                'gbNumeroFactura.Enabled = False
                txtNumeroFacturaBuscar.Enabled = False
                txtNumeroFacturaBuscar.Clear()
                txtClienteGeneral.Clear()
                txtClienteGeneral.Enabled = True
                lblIdClienteGeneral.Text = "0"
                _tipoBusqueda = 2
                AutocompletarConsorcioCliente()
                txtClienteGeneral.Focus()
            End If
        End Sub
        Private Sub AutocompletarConsorcioCliente()
            Try
                txtClienteGeneral.AutoCompleteCustomSource = _objetoClienteGeneral.AutocompletarConsorcio(_tipoCon)
                txtClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtClienteGeneral.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub rbNroNotaCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNroNotaCredito.CheckedChanged
            If rbNroNotaCredito.Checked Then
                'gbClienteGeneral.Enabled = False
                'gbEstadoFactura.Enabled = False
                rbActivas.Enabled = False
                rbAnuladas.Enabled = False
                rbTodas.Enabled = False
                'gbRangoFechas.Enabled = False
                dtpFechaDesde.Enabled = False
                dtpFechaHasta.Enabled = False
                'gbNumeroFactura.Enabled = True
                txtNumeroFacturaBuscar.Enabled = True
                txtNumeroFacturaBuscar.Clear()
                txtClienteGeneral.Enabled = False
                lblIdClienteGeneral.Text = "0"
                txtClienteGeneral.Clear()
                _tipoBusqueda = 3
                txtNumeroFacturaBuscar.Focus()
            End If
        End Sub
        Private Sub rbTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTodo.CheckedChanged
            If rbTodo.Checked Then
                'gbClienteGeneral.Enabled = False
                'gbEstadoFactura.Enabled = True
                rbActivas.Enabled = True
                rbAnuladas.Enabled = True
                rbTodas.Enabled = True
                'gbRangoFechas.Enabled = True
                dtpFechaDesde.Enabled = True
                dtpFechaHasta.Enabled = True
                'gbNumeroFactura.Enabled = False
                txtNumeroFacturaBuscar.Enabled = False
                txtNumeroFacturaBuscar.Clear()
                txtClienteGeneral.Enabled = False
                lblIdClienteGeneral.Text = "0"
                txtClienteGeneral.Clear()
                _tipoBusqueda = 4
            End If
        End Sub
        Private Sub txtClienteGeneral_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtClienteGeneral.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Try
                lblIdClienteGeneral.Text = _objetoClienteGeneral.BuscarIdClienteXRazonSocial(_tipoCon, txtClienteGeneral.Text)
            Catch
                lblIdClienteGeneral.Text = "0"
            End Try
        End Sub
        Private Sub txtNumeroFacturaBuscar_KeyKeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumeroFacturaBuscar.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            If txtNumeroFacturaBuscar.Text.Trim().Length = 0 Then Return
            CargarNotasCreditoVenta()
        End Sub
        Private Sub CargarNotasCreditoVenta()
            Try
                ' se da formato a la fecha para que el rango coja desde el comienzo del día inicial hasta que termina el día final
                _fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
                _fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

                If _tipoBusqueda = 2 Then
                    dgvNotaCredito.DataSource = _objetoNotaCredito.BuscarNotaCreditoVentaXConsorcioRangoFecha(_tipoCon, txtClienteGeneral.Text, _fechaDesde, _fechaHasta)
                ElseIf _tipoBusqueda = 3 Then
                    dgvNotaCredito.DataSource = _objetoNotaCredito.SeleccionarNotaCreditoVentaXNumeroNotaCredito(_tipoCon, txtNumeroFacturaBuscar.Text)
                Else
                    dgvNotaCredito.DataSource = _objetoNotaCredito.SeleccionarNotaCreditoVentaXParametros(_tipoCon, lblIdClienteGeneral.Text, _fechaDesde, _fechaHasta, _estadoNotaCredito)
                End If

                dgvNotaCredito.Columns(0).HeaderText = "ID"
                dgvNotaCredito.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotaCredito.Columns(1).HeaderText = "NUMERO"
                dgvNotaCredito.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotaCredito.Columns(2).HeaderText = "FECHA"
                dgvNotaCredito.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotaCredito.Columns(3).HeaderText = "RUC"
                dgvNotaCredito.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotaCredito.Columns(4).HeaderText = "CLIENTE"
                dgvNotaCredito.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotaCredito.Columns(5).HeaderText = "NRO DOC MOIF"
                dgvNotaCredito.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotaCredito.Columns(6).HeaderText = "RAZON MODIFICACION"
                dgvNotaCredito.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotaCredito.Columns(7).HeaderText = "SUBTOTAL " + _porcentajeIva.ToString + "%"
                dgvNotaCredito.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvNotaCredito.Columns(8).HeaderText = "SUBTOTAL  0%"
                dgvNotaCredito.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvNotaCredito.Columns(9).HeaderText = "SUBTOTAL    "
                dgvNotaCredito.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvNotaCredito.Columns(10).HeaderText = "IVA (" + _porcentajeIva.ToString + "%)   "
                dgvNotaCredito.Columns(10).Width = 70
                dgvNotaCredito.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvNotaCredito.Columns(11).HeaderText = "TOTAL"
                dgvNotaCredito.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvNotaCredito.Columns(12).HeaderText = "EST"
                dgvNotaCredito.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvNotaCredito.AutoResizeColumns()
                dgvNotaCredito.AutoResizeRows()
                dgvNotaCredito.Columns(2).Width = 80
                dgvNotaCredito.Columns(4).Width = 270
                dgvNotaCredito.Columns(6).Width = 145
                dgvNotaCredito.Columns(7).Width = 70
                dgvNotaCredito.Columns(8).Width = 70
                dgvNotaCredito.Columns(9).Width = 70
                dgvNotaCredito.Columns(10).Width = 70
                dgvNotaCredito.ReadOnly = True
                SumarTotalFacturas()
            Catch ex As Exception
                'MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Metodo cargar factura venta" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub SumarTotalFacturas()
            Dim totalSubtotal As Decimal
            Dim totalIva As Decimal
            Dim totalFacturacion As Decimal
            Try
                For i = 0 To dgvNotaCredito.RowCount - 1
                    totalSubtotal += CDec(dgvNotaCredito.Rows(i).Cells(9).Value)
                    totalIva += CDec(dgvNotaCredito.Rows(i).Cells(10).Value)
                    totalFacturacion += CDec(dgvNotaCredito.Rows(i).Cells(11).Value)
                Next
            Catch
                totalSubtotal = 0
                totalIva = 0
                totalFacturacion = 0
            End Try
            txtTotalSubtotal.Text = totalSubtotal
            txtTotalIVA.Text = totalIva
            txtTotalFacturas.Text = totalFacturacion
        End Sub
        Private Sub rbActivas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbActivas.CheckedChanged
            _estadoNotaCredito = If(rbActivas.Checked, 1, 3)
        End Sub
        Private Sub rbAnuladas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbAnuladas.CheckedChanged
            _estadoNotaCredito = If(rbAnuladas.Checked, 0, 3)
        End Sub
        Private Sub rbTodas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTodas.CheckedChanged
            If rbTodas.Checked Then _estadoNotaCredito = 3
        End Sub
        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            Try
                _fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
                _fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

                CargarNotasCreditoVenta()
                ValidarValorAsiento()
            Catch ex As Exception
                'MsgBox("CARGAR DATOS" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Cargar datos" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
            SumarTotalFacturas()
        End Sub
        Private Sub ValidarValorAsiento()
            If dgvNotaCredito.RowCount = 0 Then Return
            For i = 0 To dgvNotaCredito.Rows.Count - 1
                dgvNotaCredito.Rows(i).Cells("VALOR_ASIENTO").Value = _objetoAsientoDiario.BuscarValorHaberCuentaXNumeroRegistroCuenta(_tipoCon, dgvNotaCredito.Rows(i).Cells("ASIENTO").Value, "1010205")
                If dgvNotaCredito.Rows(i).Cells(11).Value = dgvNotaCredito.Rows(i).Cells("VALOR_ASIENTO").Value Then
                    dgvNotaCredito.Rows(i).Cells("VALOR_ASIENTO").Style.BackColor = Color.LightGreen
                Else
                    dgvNotaCredito.Rows(i).Cells("VALOR_ASIENTO").Style.BackColor = Color.LightSalmon
                End If
            Next
        End Sub
        Private Sub dgvFacturaVenta_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvNotaCredito.CellDoubleClick
            Try
                Dim formAsientoDiario As New FormBuscarAsientoDiario
                formAsientoDiario.TipoCox = TipoCox
                If dgvNotaCredito.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    lblIdFacturaVenta.Text = "..."
                Else
                    lblIdFacturaVenta.Text = dgvNotaCredito.CurrentRow.Cells.Item(0).Value
                    formAsientoDiario.NumeroRegsitroBusqueda = _objetoNumeroRegistroAsientoNotaCredito.BuscarNumeroRegistroAsientoPorIdNotaCredito(_tipoCon, lblIdFacturaVenta.Text)
                    formAsientoDiario.ShowDialog()
                End If
            Catch ex As Exception
                'MsgBox("ERROR AL CARGAR ASIENTO" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Error al cargar asiento" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub dgvNotaCredito_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvNotaCredito.SelectionChanged
            If dgvNotaCredito.RowCount = 0 Then Return
            If dgvNotaCredito.CurrentRow Is Nothing Then Return
            If dgvNotaCredito.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdFacturaVenta.Text = "..."
            Else
                lblIdFacturaVenta.Text = dgvNotaCredito.CurrentRow.Cells.Item(0).Value
            End If
        End Sub
        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            If dgvNotaCredito.Rows.Count > 0 Then
                ExportarDatosExcel(dgvNotaCredito, "NOTAS DE CREDITO")
            Else
                'MsgBox("PRIMERO REALICE UNA CONSULTA", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Primero realice una consulta", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then
                    'MsgBox("No hay datos que exportar!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("No hay datos que exportar", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "NOTAS_CREDITO"

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
                'MessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                KryptonMessageBox.Show("Hubo un problema al exportar datos", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnSalir.Click

            If dgvNotaCredito.CurrentRow Is Nothing Then Return

            _tipoAmbiente = "2"
            _tipoEmision = "1"
            _numeroFacturaVenta = ""
            _secuencialNotaCredito = ""



            _fechaEmisionNotaCredito = dgvNotaCredito.CurrentRow.Cells(2).Value
            _razonSocialCliente = dgvNotaCredito.CurrentRow.Cells(4).Value
            CargarDatosCliente()

            Dim cadendaNroFactura = dgvNotaCredito.CurrentRow.Cells(5).Value.ToString.Length
            For i = 1 To cadendaNroFactura
                If i > 8 Then
                    _numeroFacturaVenta = _numeroFacturaVenta + Mid(dgvNotaCredito.CurrentRow.Cells(5).Value.ToString, i, 1).ToString
                End If
            Next

            Dim cadenaNroNotaCredito = dgvNotaCredito.CurrentRow.Cells(1).Value.ToString.Length
            For i = 1 To cadenaNroNotaCredito
                If i > 6 Then
                    _secuencialNotaCredito = _secuencialNotaCredito + Mid(dgvNotaCredito.CurrentRow.Cells(1).Value.ToString, i, 1).ToString
                End If
            Next
            CargarFacturasVenta()
            CargarDetalleFactura()

            'FACTURA 01, NOTA DE CRÉDITO 04, NOTA DE DÉBITO 05, GUÍA DE REMISIÓN 06, COMPROBANTE DE RETENCIÓN 07
            _claveAcceso = ValidationForms.GenerarClaveAccesoComprobantesElectronicos("04", _fechaEmisionNotaCredito, _rucEmpresa, _tipoAmbiente, _establecimientoNotaCredito, _ptoEmisionNotaCredito, _secuencialNotaCredito, _tipoEmision)
            If _claveAcceso.ToString.Length = 49 Then
                ExportarXml()
            Else
                'MsgBox("CLAVE DE ACCESO INVALIDA")
                KryptonMessageBox.Show("Clave de acceso invalida", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End If

        End Sub
        Private Sub CargarDatosCliente()
            Try
                dgvCliente.DataSource = _objetoClienteGeneral.BuscarClienteGeneralXRazonSocial(_tipoCon, _razonSocialCliente)
                If dgvCliente.RowCount > 0 Then
                    If dgvCliente.Rows(0).Cells(3).Value = "9999999999999" Then
                        _tipoIdentificacionCliente = "07"
                    Else
                        Select Case dgvCliente.Rows(0).Cells(2).Value.ToString
                            Case "RUC"
                                _tipoIdentificacionCliente = "04"
                            Case "CEDULA"
                                _tipoIdentificacionCliente = "05"
                            Case "PASAPORTE"
                                _tipoIdentificacionCliente = "06"
                            Case "IDENTIFICACION DEL EXTERIOR"
                                _tipoIdentificacionCliente = "08"
                        End Select
                    End If
                    _rucCliente = dgvCliente.Rows(0).Cells(3).Value
                End If
            Catch ex As Exception
                'MsgBox("CARGAR DATOS CLIENTE." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Cargar datos cliente." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub CargarFacturasVenta()
            Try
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaXNumeroFactura(_tipoCon, _numeroFacturaVenta)
            Catch
                dgvFacturaVenta.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarDetalleFactura()
            Try
                dgvDetalleFacturaVenta.DataSource = _objetoDetalleFacturaVenta.SeleccionarDetalleFacturaVentaXIdFacturaVenta(_tipoCon, dgvFacturaVenta.Rows(0).Cells(0).Value)
            Catch
                dgvDetalleFacturaVenta.DataSource = Nothing
            End Try
        End Sub

        Public RutaDocsElec As String
        Private Sub ExportarXml()
            Try
                Dim numeroNotaCreditoVenta = _establecimientoNotaCredito.ToString + _ptoEmisionNotaCredito.ToString + _secuencialNotaCredito.ToString
                Dim ruta As String
                Select Case _tipoCon
                    Case TipoConexion.Asenava
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\NOTA CREDITO " & numeroNotaCreditoVenta & ".xml"
                    Case TipoConexion.Seportpac
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\VENTAS\NOTA CREDITO " & numeroNotaCreditoVenta & ".xml"
                    Case Else
                        ruta = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\NOTA CREDITO " & numeroNotaCreditoVenta & ".xml"
                End Select

                Dim xml = String.Empty
                xml += "<?xml version='1.0' encoding='UTF-8'?>" & vbNewLine
                xml += "<notaCredito id='comprobante' version='1.0.0'>" & vbNewLine
                xml += "<infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA EMPRESA =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<ambiente>" & _tipoAmbiente & "</ambiente>" & vbNewLine
                xml += "<tipoEmision>" & _tipoEmision & "</tipoEmision>" & vbNewLine
                xml += "<razonSocial>" & _razonSocialEmpresa & "</razonSocial>" & vbNewLine
                xml += "<nombreComercial>" & _nombreComercialEmpresa & "</nombreComercial>" & vbNewLine
                xml += "<ruc>" & _rucEmpresa & "</ruc>" & vbNewLine
                xml += "<claveAcceso>" & _claveAcceso & "</claveAcceso>" & vbNewLine
                xml += "<codDoc>04</codDoc>" & vbNewLine ' FACTURA => 01 / NOTA DE CRÉDITO => 04 / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
                xml += "<estab>" & _establecimientoNotaCredito & "</estab>" & vbNewLine
                xml += "<ptoEmi>" & _ptoEmisionNotaCredito & "</ptoEmi>" & vbNewLine
                xml += "<secuencial>" & _secuencialNotaCredito & "</secuencial>" & vbNewLine
                xml += "<dirMatriz>" & _direccionEmpresa & "</dirMatriz>" & vbNewLine
                xml += "<agenteRetencion>00000001</agenteRetencion>" & vbNewLine
                xml += "</infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoNotaCredito>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA NOTA DE CREDITO -=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<fechaEmision>" & Format(_fechaEmisionNotaCredito, "dd/MM/yyyy") & "</fechaEmision>" & vbNewLine
                xml += "<dirEstablecimiento>" & _direccionEmpresa & "</dirEstablecimiento>" & vbNewLine
                xml += "<tipoIdentificacionComprador>" & _tipoIdentificacionCliente & "</tipoIdentificacionComprador>" & vbNewLine
                xml += "<razonSocialComprador>" & _razonSocialCliente & "</razonSocialComprador>" & vbNewLine
                xml += "<identificacionComprador>" & _rucCliente & "</identificacionComprador>" & vbNewLine
                'xml += "<contribuyenteEspecial>" & _numAutoContEspecial & "</contribuyenteEspecial>" & vbNewLine
                xml += "<obligadoContabilidad>SI</obligadoContabilidad>" & vbNewLine
                xml += "<codDocModificado>01</codDocModificado>" & vbNewLine
                'cambio 2025 ??? 
                xml += "<numDocModificado>" & dgvNotaCredito.CurrentRow.Cells(5).Value.ToString & "</numDocModificado>" & vbNewLine
                xml += "<fechaEmisionDocSustento>" & Format(dgvFacturaVenta.Rows(0).Cells(2).Value, "dd/MM/yyyy") & "</fechaEmisionDocSustento>" & vbNewLine
                xml += "<totalSinImpuestos>" & Math.Round(CDec(dgvNotaCredito.CurrentRow.Cells(7).Value), 2, MidpointRounding.ToEven) & "</totalSinImpuestos>" & vbNewLine
                xml += "<valorModificacion>" & Math.Round(CDec(dgvNotaCredito.CurrentRow.Cells(11).Value), 2, MidpointRounding.ToEven) & "</valorModificacion>" & vbNewLine
                xml += "<moneda>DOLAR</moneda>" & vbNewLine
                xml += "<totalConImpuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<totalImpuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<codigo>2</codigo>" & vbNewLine ' IVA => 2 / ICE => 3 / IRBPNR => 5

                If _porcentajeIva = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine
                If _porcentajeIva = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                If _porcentajeIva = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine
                If _porcentajeIva = 15 Then xml += "<codigoPorcentaje>4</codigoPorcentaje>" & vbNewLine

                xml += "<baseImponible>" & Math.Round(CDec(dgvNotaCredito.CurrentRow.Cells(7).Value), 2, MidpointRounding.ToEven) & "</baseImponible>" & vbNewLine
                xml += "<valor>" & Math.Round(CDec(dgvNotaCredito.CurrentRow.Cells(10).Value), 2, MidpointRounding.ToEven) & "</valor>" & vbNewLine
                xml += "</totalImpuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "</totalConImpuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<motivo>" & dgvNotaCredito.CurrentRow.Cells(6).Value.ToString.TrimEnd & "</motivo>" & vbNewLine
                xml += "</infoNotaCredito>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<detalles>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS DETALLES DE LA FACTURA =-=-=-=-=-=-=-=-=-=-=-=-=
                If dgvDetalleFacturaVenta.Rows.Count > 0 Then
                    xml += "<detalle>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA ITEM =-=-=-=-=-=-=-=-=-=-=-=-=
                    xml += "<codigoInterno>" & dgvDetalleFacturaVenta.Rows(0).Cells(1).Value & "</codigoInterno>" & vbNewLine
                    xml += "<descripcion>" & _objetoSecuencialItem.BuscarNombreSecuencialItemXIdSecuencialItem(_tipoCon, dgvDetalleFacturaVenta.Rows(0).Cells(1).Value) & "</descripcion>" & vbNewLine
                    xml += "<cantidad>1</cantidad>" & vbNewLine
                    xml += "<precioUnitario>" & Math.Round(CDec(dgvNotaCredito.CurrentRow.Cells(7).Value), 2, MidpointRounding.ToEven) & "</precioUnitario>" & vbNewLine
                    xml += "<descuento>0.00</descuento>" & vbNewLine
                    xml += "<precioTotalSinImpuesto>" & Math.Round(CDec(dgvNotaCredito.CurrentRow.Cells(7).Value), 2, MidpointRounding.ToEven) & "</precioTotalSinImpuesto>" & vbNewLine
                    xml += "<impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                    xml += "<impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                    xml += "<codigo>2</codigo>" & vbNewLine ' IVA => 2 / ICE => 3 / IRBPNR => 5

                    If _porcentajeIva = 14 Then xml += "<codigoPorcentaje>3</codigoPorcentaje>" & vbNewLine
                    If _porcentajeIva = 12 Then xml += "<codigoPorcentaje>2</codigoPorcentaje>" & vbNewLine
                    If _porcentajeIva = 0 Then xml += "<codigoPorcentaje>0</codigoPorcentaje>" & vbNewLine
                    If _porcentajeIva = 15 Then xml += "<codigoPorcentaje>4</codigoPorcentaje>" & vbNewLine

                    xml += "<tarifa>" & _porcentajeIva & "</tarifa>" & vbNewLine
                    xml += "<baseImponible>" & Math.Round(CDec(dgvNotaCredito.CurrentRow.Cells(7).Value), 2, MidpointRounding.ToEven) & "</baseImponible>" & vbNewLine
                    Dim valorIvaDetalle As Decimal = 0
                    valorIvaDetalle = (Math.Round(CDec(dgvNotaCredito.CurrentRow.Cells(7).Value), 2, MidpointRounding.ToEven) * _porcentajeIva) / 100
                    xml += "<valor>" & Math.Round(valorIvaDetalle, 2, MidpointRounding.ToEven) & "</valor>" & vbNewLine
                    xml += "</impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                    xml += "</impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                    xml += "</detalle>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                End If

                xml += "</detalles>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                xml += "<infoAdicional>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON ADICIONAL DEL SERVICIO PRESTADO =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<campoAdicional nombre='Informacion'>Agente de retencion segun resolucion N. " & _objetoInformacionTributaria.SeleccionarNroResolucionAgenteRetencion(_tipoCon) & ". </campoAdicional>" & vbNewLine
                xml += "</infoAdicional>" & vbNewLine
                xml += "</notaCredito>" & vbNewLine

                Dim writer As XmlTextWriter
                writer = New XmlTextWriter(ruta, Encoding.UTF8)
                writer.Formatting = Formatting.Indented
                writer.WriteRaw(xml)
                writer.Flush()
                writer.Close()

                'MsgBox("NOTA DE CRÉDITO ELECTRÓNICA" & vbNewLine & "XML GENERADO CORRECTAMENTE", MsgBoxStyle.Information, "Mensaje de información.")
                KryptonMessageBox.Show("Nota de crédito electrónica" & vbNewLine & "XML generado correctamente", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Catch ex As Exception
                'MsgBox("ERROR AL GENERAR NOTA DE CRÉDITO ELECTRÓNICA" & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de información.")
                KryptonMessageBox.Show("Error al generar nota de crédito electrónica" & vbNewLine & ex.Message, "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub GENERARRIDEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GENERARRIDEToolStripMenuItem.Click
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

            'infoNotaCredito
            Dim fechaEmision As String = ""
            Dim dirEstablecimiento As String = ""
            Dim tipoIdentificacionComprador As String = ""
            Dim razonSocialComprador As String = ""
            Dim identificacionComprador As String = ""
            Dim obligadoContabilidad As String = ""
            Dim codDocModificado As String = ""
            Dim numDocModificado As String = ""
            Dim fechaEmisionDocSustento As String = ""
            Dim totalSinImpuestos As String = ""
            Dim valorModificacion As String = ""

            'totalConImpuestos
            Dim codigoImpuesto As String = ""
            Dim codigoPorcentaje As String = ""
            Dim baseImponibleNotaCredito As String = ""
            Dim valorNotaCredito As String = ""

            Dim motivo As String = ""
            '</infoNotaCredito> 

            'Detalles Valores
            Dim codigoPrincipal As String = ""
            Dim descripcion As String = ""
            Dim cantidad As String = ""
            Dim precioUnitario As String = ""
            Dim descuentoDetalle As String = ""
            Dim precioTotalSinImpuesto As String = ""

            'Detalle/Impuesto
            Dim codigoDetalleImpuesto As String = ""
            Dim codigoPorcentajeDetalle As String = ""
            Dim tarifa As String = ""
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



            Try

                Dim reader As New XmlTextReader(s)
                Dim cadenaXml = ""
                Dim nombreNodo = ""
                Dim xmlFileName As String = Path.GetFileNameWithoutExtension(CType(s, FileStream).Name)



                Dim txtFilePath As String = Path.Combine(Application.StartupPath & "\Leer XML Temp\pathNotaCredito.txt")

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


                For Each nodoCredito As XmlNode In nodosMain
                    Dim nuevoNodos As String = nodoCredito.Name
                    Dim valoresNodo = nodoCredito.InnerText

                    Select Case nuevoNodos
                        Case "infoTributaria"

                            For Each nodoInfo As XmlNode In nodoCredito.ChildNodes

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
                        Case "infoNotaCredito"

                            For Each nodoInfoNota As XmlNode In nodoCredito.ChildNodes

                                Select Case nodoInfoNota.Name

                                    Case "fechaEmision"
                                        fechaEmision = nodoInfoNota.InnerText
                                    Case "dirEstablecimiento"
                                        dirEstablecimiento = nodoInfoNota.InnerText
                                    Case "identificacionComprador"
                                        identificacionComprador = nodoInfoNota.InnerText
                                    Case "razonSocialComprador"
                                        razonSocialComprador = nodoInfoNota.InnerText
                                    Case "tipoIdentificacionComprador"
                                        tipoIdentificacionComprador = nodoInfoNota.InnerText
                                    Case "obligadoContabilidad"
                                        obligadoContabilidad = nodoInfoNota.InnerText
                                    Case "codDocModificado"

                                        Select Case nodoInfoNota.InnerText
                                            Case "01"
                                                codDocModificado = "FACTURA"
                                            Case "03"
                                                codDocModificado = "LIQUIDACION DE COMPRA"
                                            Case "04"
                                                codDocModificado = "NOTA DE CREDITO"
                                            Case "05"
                                                codDocModificado = "NOTA DE DEBITO"
                                            Case "06"
                                                codDocModificado = "COMPROBANTE DE RETENCION"
                                        End Select


                                    Case "numDocModificado"
                                        numDocModificado = nodoInfoNota.InnerText
                                    Case "fechaEmisionDocSustento"
                                        fechaEmisionDocSustento = nodoInfoNota.InnerText
                                    Case "totalSinImpuestos"
                                        totalSinImpuestos = nodoInfoNota.InnerText
                                    Case "valorModificacion"
                                        valorModificacion = nodoInfoNota.InnerText
                                        '<totalConImpuesto>
                                    Case "totalConImpuestos"
                                        For Each nodoTotalImpuesto As XmlNode In nodoCredito.ChildNodes
                                            Select Case nodoTotalImpuesto.Name
                                                Case "totalImpuesto"
                                                    For Each nodoImpuesto As XmlNode In nodoTotalImpuesto.ChildNodes
                                                        Select Case nodoImpuesto.Name
                                                            Case "codigo"
                                                                codigoImpuesto = nodoImpuesto.InnerText
                                                            Case "codigoPorcentaje"
                                                                codigoPorcentaje = nodoImpuesto.InnerText
                                                            Case "baseImponible"
                                                                baseImponibleNotaCredito = nodoImpuesto.InnerText
                                                            Case "valor"
                                                                valorNotaCredito = nodoImpuesto.InnerText
                                                        End Select
                                                    Next
                                            End Select
                                        Next

                                        '</totalConImpuesto>

                                    Case "motivo"
                                        motivo = nodoInfoNota.InnerText
                                        '</infNotaCredito>
                                End Select


                            Next
                        Case "detalles"

                            For Each nodoDetalles As XmlNode In nodoCredito.ChildNodes
                                Select Case nodoDetalles.Name
                                    Case "detalle"
                                        Dim _objDetalle As New ClassDetalle
                                        For Each nodoDetalle As XmlNode In nodoDetalles.ChildNodes
                                            Select Case nodoDetalle.Name
                                                Case "codigoInterno"
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
                            For Each nodoInfoAdicional As XmlNode In nodoCredito.ChildNodes
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
                table1.AddCell(New Phrase("NOTA DE CREDITO", fuente10))
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
                Dim yPositonTable2 As Single = 675

                table2.WriteSelectedRows(0, -1, xPositionTable2, yPositonTable2, writer.DirectContent)

                Dim rectTabla2 As PdfContentByte = writer.DirectContent
                rectTabla2.RoundRectangle(20.0F, 520.0F, 290.0F, 160.0F, 15.0F)
                rectTabla2.Stroke()


                Dim table3 As PdfPTable = New PdfPTable(1)
                table3.TotalWidth = 500
                table3.HorizontalAlignment = Element.ALIGN_CENTER
                table3.DefaultCell.BorderColor = iTextSharp.text.BaseColor.WHITE

                table3.AddCell(New Phrase("Rázon Social / Nombres y Apellidos: " & "    " & razonSocialComprador, fuente8))
                table3.AddCell(New Phrase("   ", fuente8))
                table3.AddCell(New Phrase("Fecha de emisión: " & "    " & fechaEmision & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "Identificación: " & identificacionComprador, fuente8))
                table3.AddCell(New Phrase("   ", fuente8))
                Dim line As PdfContentByte = writer.DirectContent
                line.SetLineWidth(1.0F)
                line.SetRGBColorStroke(0, 0, 0)
                line.MoveTo(50, 455)
                line.LineTo(520, 455)
                line.Stroke()
                table3.AddCell(New Phrase("Comprobante que se modifica:" & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & codDocModificado & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & numDocModificado, fuente8))
                table3.AddCell(New Phrase("   ", fuente8))
                table3.AddCell(New Phrase("Fecha de Emisión(Comprobante a modificar) " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & fechaEmisionDocSustento, fuente8))
                table3.AddCell(New Phrase("   ", fuente8))
                table3.AddCell(New Phrase("Rázon de Modificación:" & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & "    " & motivo, fuente8))
                Dim DynamicTable3Height As Single = table3.TotalHeight
                Dim xPositionTable3 As Single = 25
                Dim yPositonTable3 As Single = 500

                table3.WriteSelectedRows(0, -1, xPositionTable3, yPositonTable3, writer.DirectContent)

                Dim rectTabla3 As PdfContentByte = writer.DirectContent
                rectTabla3.Rectangle(20.0F, 380.0F, 550.0F, DynamicTable3Height + 20)
                rectTabla3.Stroke()

                Dim tableData As New DataTable()

                tableData.Columns.Add("Codigo", GetType(String))
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
                    row("codigo") = detalle.CodigoPrincipal
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
                Dim yPositionTable4 As Single = 400
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
                Dim cell2Row11 As New PdfPCell(New Phrase(valorModificacion, fuente8))
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
                Dim yPositonTable5 As Single = newYPositionTable4 - DynamicTable4Height - 10

                table5.WriteSelectedRows(0, -1, xPositionTable5, yPositonTable5, writer.DirectContent)


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

                Dim emptyTable61 As New PdfPCell(New Phrase("", fuente8))
                emptyTable61.BorderWidthLeft = 1
                emptyTable61.BorderWidthRight = 0
                emptyTable61.BorderWidthTop = 0
                emptyTable61.BorderWidthBottom = 1
                Dim emptyTable62 As New PdfPCell(New Phrase("", fuente8))
                emptyTable62.BorderWidthLeft = 0
                emptyTable62.BorderWidthRight = 1
                emptyTable62.BorderWidthTop = 0
                emptyTable62.BorderWidthBottom = 1
                table6.AddCell(emptyTable61)
                table6.AddCell(emptyTable62)



                table6.SetWidths(columnWidthsTable6)

                Dim xPositionTable6 As Single = 20
                Dim yTable6Height As Single = table6.TotalHeight
                Dim yPositonTable6 As Single = newYPositionTable4 - DynamicTable4Height - 10

                table6.WriteSelectedRows(0, -1, xPositionTable6, yPositonTable6, writer.DirectContent)




                _Detalle.Clear()
                document.Close()
                xmlDoc = Nothing
                File.Delete(ruta)
                writer.Close()
                'MsgBox("LIQUIDACION DE COMPRA CREADA CORRECTAMENTE!", MsgBoxStyle.Information, "Mensaje de validación")
                KryptonMessageBox.Show("Liquidación de compra creada correctamente", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)

            Catch ex As Exception
                'MsgBox("HUBO UN PROBLEMA AL CARGAR EL XML! " & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Hubo un problema al cargar el XML" & vbNewLine & ex.Message, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try

        End Sub



        Private Sub btnNotaCreditoPath_Click(sender As Object, e As EventArgs) Handles btnNotaCreditoPath.Click
            Dim rutaNotaCredito As String

            Select Case _tipoCon
                Case TipoConexion.Asenava
                    rutaNotaCredito = RutaDocsElec & "\COMPROBANTES GENERADOS\FACTURAS - RETENCIONES FONDO\FACTURA "
                Case TipoConexion.Seportpac
                    rutaNotaCredito = RutaDocsElec & "\COMPROBANTES GENERADOS\VENTAS\FACTURA "
                Case Else
                    rutaNotaCredito = RutaDocsElec & "\COMPROBANTES AUTORIZADOS\FACTURAS - RETENCIONES FONDO "
            End Select

            Dim folderBrowser As New FolderBrowserDialog()
            folderBrowser.Description = "Seleccione Ruta de Retencion"
            folderBrowser.SelectedPath = rutaNotaCredito

            If folderBrowser.ShowDialog() = DialogResult.OK Then
                Dim pathNotaCredito As String = folderBrowser.SelectedPath
                Dim txtFilePath As String = Path.Combine(Application.StartupPath & "\Leer XML Temp\pathNotaCredito.txt")
                File.WriteAllText(txtFilePath, pathNotaCredito)
                txtNotaCreditoPath.Text = pathNotaCredito

            End If
        End Sub
    End Class
End Namespace