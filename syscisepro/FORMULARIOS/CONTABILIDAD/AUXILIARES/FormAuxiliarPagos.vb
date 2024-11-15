Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
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
    Public Class FormAuxiliarPagos
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

        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoPagosComprobantesCompra As New ClassPagosComprobantesCompra
        ReadOnly _objetoComprobanteRetencion As New ClassComprobantesRetencion
        ReadOnly _objetoDetalleComprobantesRetencion As New ClassDetalleComprobantesRetencion
        ReadOnly _objetoNumeroRegistroAsientoCompCompra As New ClassNumeroRegistroAsientoComprobanteCompra
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoAjustarAsientos As New ClassAjustarAsientosLibroDiario
        ReadOnly _objetoProveedorGeneral As New ClassProveedores
        ReadOnly _objetoComprobanteEgreso As New ClassComprobanteEgresoBanco
        ReadOnly _objetoNumeroRegistroAsientoCompEgreso As New ClassNumeroRegistroAsientoComprobanteEgreso
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoNumeroRegistroAsientoFacturaVenta As New ClassNumeroRegistroAsientoFacturaVenta
        ReadOnly _objetoComprobanteRetencionCompraVenta As New ClassComprobantesRetencionCompraVenta
        ReadOnly _objetoDetalleComprobantesRetencionVenta As New ClassDetalleComprobantesRetencionVenta
        ReadOnly _objetoPagosFacturaVenta As New ClassPagosFacturaVenta
        ReadOnly _objetoNumeroRegistroAsientoNotaCredito As New ClassNumeroRegistroAsientoNotaCreditoVenta
        ReadOnly _objetoComprobanteIngreso As New ClassComprobanteIngresoBanco
        ReadOnly _objetoNumeroRegistroAsientoComprobanteIngreso As New ClassNumeroRegistroAsientoComprobanteIngreso

        Dim _fechaDesde As DateTime
        Dim _fechaHasta As DateTime
        Dim _tipoBusquedaC As Integer = 0
        Dim _tipoBusquedaV As Integer = 0

        Private Sub FormAuxiliarPagos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientoDiarioCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvPagosComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientoDiarioEgreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava

                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientoDiarioVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleRetencionVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvPagosFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientoDiarioIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientoDiarioCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvPagosComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientoDiarioEgreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac

                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientoDiarioVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleRetencionVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvPagosFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobanteIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientoDiarioIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientoDiarioCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvPagosComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientoDiarioEgreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro

                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientoDiarioVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleRetencionVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvPagosFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobanteIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientoDiarioIngreso.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvComprobantesCompra.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvAsientoDiarioCompra.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvPagosComprobantesCompra.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprobanteEgresoBancos.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvAsientoDiarioEgreso.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvAsientoDiarioVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleRetencionVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvPagosFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprobanteIngreso.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvAsientoDiarioIngreso.Font = New Font("Roboto", 8, FontStyle.Regular)

            AutocompletarNombreProveedor()
            AutocompletarNombreCliente()
        End Sub
        Private Sub AutocompletarNombreProveedor()
            Try
                txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = _objetoProveedorGeneral.Autocompletar(_tipoCon)
                txtNombreComercialProveedorGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialProveedorGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = Nothing
            End Try
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
        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            CargarComprobantesCompra() 
            SumarAsientosDiario()
             
            ValidarPagosCompras()
        End Sub
        Private Sub rbPorProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPorProveedor.CheckedChanged
            If rbPorProveedor.Checked Then
                gbNombreComercialProveedor.Enabled = True
                gbRangoFechas.Enabled = True
                '_tipoBusqueda = 1
                _tipoBusquedaC = 1
                lblIdProveedorGeneral.Text = "0"
                txtNombreComercialProveedorGeneral.Text = ""
            End If
        End Sub
        Private Sub rbTodoCompras_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTodoCompras.CheckedChanged
            If rbTodoCompras.Checked Then
                gbNombreComercialProveedor.Enabled = False
                gbRangoFechas.Enabled = True
                '_tipoBusqueda = 3
                _tipoBusquedaC = 3
            End If
        End Sub
        Private Sub CargarComprobantesCompra()
            Try
                dgvComprobantesCompra.DataSource = Nothing

                _fechaDesde = dtpDesde.Value.Day.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Year.ToString & " 00:00:00.001"
                _fechaHasta = dtpHasta.Value.Day.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Year.ToString & " 23:59:59.000"

                If _tipoBusquedaC = 1 Then
                    dgvComprobantesCompra.DataSource = _objetoComprobantesCompra.SeleccionarComrpobantesCompraXIdProveedorYRangoFechas(_tipoCon, lblIdProveedorGeneral.Text, _fechaDesde, _fechaHasta)
                ElseIf _tipoBusquedaC = 2 Then
                    'MsgBox("CONSULTA POR NÚMERO DE FACTURA EN DESARROLLO")
                    KryptonMessageBox.Show("CONSULTA POR NÚMERO DE FACTURA EN DESARROLLO", "MENSAJE DE INFORMACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                ElseIf _tipoBusquedaC = 3 Then
                    dgvComprobantesCompra.DataSource = _objetoComprobantesCompra.SeleccionarComrpobantesCompraXEstadoYRangoFechas(_tipoCon, _fechaDesde, _fechaHasta, 1)
                End If

                dgvComprobantesCompra.AutoResizeColumns()
                dgvComprobantesCompra.AutoResizeRows()
                dgvComprobantesCompra.ReadOnly = True

                dgvComprobantesCompra.Columns(1).Width = 400
                dgvComprobantesCompra.Columns(2).Width = 90
                dgvComprobantesCompra.Columns(4).Width = 90
                dgvComprobantesCompra.Columns(5).Width = 70
                dgvComprobantesCompra.Columns(6).Width = 70
                dgvComprobantesCompra.Columns(7).Width = 70
                dgvComprobantesCompra.Columns(8).Width = 70
                dgvComprobantesCompra.Columns(9).Width = 70
                dgvComprobantesCompra.Columns(10).Width = 70

            Catch ex As Exception
                dgvComprobantesCompra.DataSource = Nothing
                LimpiarGridsCompra(False, True, True, True, True, True, True)
                'MsgBox("METODO CARGAR COMPROBANTES DE COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
                KryptonMessageBox.Show("METODO CARGAR COMPROBANTES DE COMPRA" & vbNewLine & ex.Message.ToString, "MENSAJE DE EXCEPCIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        
        '        For indicePago = 0 To dgvPagosComprobantesCompra.Rows.Count - 1
        '            ' calcula el saldo de los pagos realizados
        '            'If dgvPagosComprobantesCompra.Rows(indicePago).Cells("MONTO").Value > 0 Then
        '            '    saldo -= dgvPagosComprobantesCompra.Rows(indicePago).Cells("MONTO").Value
        '            '    If saldo <> CDec(dgvPagosComprobantesCompra.Rows(indicePago).Cells("SALDO").Value) Then
        '            '        dgvComprobantesCompra.Rows(indiceCompras).Cells("ID").Style.BackColor = Color.Red
        '            '    End If
        '            '    'Else
        '            '    '    saldo = dgvPagosComprobantesCompra.Rows(indicePago).Cells("SALDO").Value
        '            'End If

        '            '' verifica el pago en el diario
        '            'lblIdComprobanteEgreso.Text = dgvPagosComprobantesCompra.Rows(indicePago).Cells(8).Value
        '            'cargarAsientoEgreso()
        '            'If dgvAsientoDiarioEgreso.Rows.Count > 0 Then
        '            '    For indiceAsientoEgreso = 0 To dgvAsientoDiarioEgreso.Rows.Count - 1
        '            '        If dgvAsientoDiarioEgreso.Rows(indiceAsientoEgreso).Cells("CUENTA").Value = "LOCALES" Then
        '            '            If dgvAsientoDiarioEgreso.Rows(indiceAsientoEgreso).Cells("DEBE").Value <> dgvPagosComprobantesCompra.Rows(indicePago).Cells("MONTO").Value Then
        '            '                dgvComprobantesCompra.Rows(indiceCompras).Cells("TIPO").Style.BackColor = Color.Red
        '            '            End If
        '            '        End If
        '            '    Next
        '            'End If
        '        Next

        '        'lblNumeroRegistroCompra.Text = _objetoNumeroRegistroAsientoCompCompra.BuscarNumeroRegistroAsientoPorIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
        '        'CargarAsientoLibroDiario()
        '        'For indiceAsientoCompras = 0 To dgvAsientoDiarioCompra.Rows.Count - 1
        '        '    If dgvAsientoDiarioCompra.Rows(indiceAsientoCompras).Cells("CUENTA").Value = "LOCALES" Then
        '        '        If dgvAsientoDiarioCompra.Rows(indiceAsientoCompras).Cells("HABER").Value <> dgvComprobantesCompra.Rows(indiceCompras).Cells("TOTAL A PAGAR").Value Then
        '        '            dgvComprobantesCompra.Rows(indiceCompras).Cells("NUMERO").Style.BackColor = Color.Red
        '        '        End If
        '        '    End If
        '        'Next
        '    Next
         
        Private Sub LimpiarGridsCompra(ByVal comp As Boolean, ByVal asie As Boolean, ByVal rete As Boolean, ByVal dret As Boolean, ByVal pago As Boolean, ByVal egre As Boolean, ByVal aseg As Boolean)
            If comp Then
                dgvComprobantesCompra.DataSource = Nothing
                lblFactura.Text = "..."
                lblNumeroRegistroCompra.Text = "..."
                lblIdComprobanteCompra.Text = "..."
                lblIdComprobanteEgreso.Text = "..."
            End If
            If asie Then dgvAsientoDiarioCompra.DataSource = Nothing
            If rete Then dgvComprobanteRetencion.DataSource = Nothing
            If dret Then dgvDetalleComprobanteRetencion.DataSource = Nothing
            If pago Then
                dgvPagosComprobantesCompra.DataSource = Nothing
                lblIdComprobanteEgreso.Text = "..."
            End If
            If egre Then
                dgvComprobanteEgresoBancos.DataSource = Nothing
                lblIdComprobanteEgreso.Text = "..."
            End If
            If aseg Then dgvAsientoDiarioEgreso.DataSource = Nothing
        End Sub
        Private Sub LimpiarGridsVenta(ByVal comp As Boolean, ByVal asie As Boolean, ByVal rete As Boolean, ByVal dret As Boolean, ByVal pago As Boolean, ByVal egre As Boolean, ByVal aseg As Boolean)
            If comp Then
                dgvFacturaVenta.DataSource = Nothing
                lblIdFacturaVenta.Text = "..."
                lblNumeroFactura.Text = "..."
                lblNumeroRegistroVenta.Text = "..."
                lblIdComprobanteIngresoBanco.Text = "..."
            End If
            If asie Then dgvAsientoDiarioVenta.DataSource = Nothing
            If rete Then dgvComprobanteRetencionVenta.DataSource = Nothing
            If dret Then dgvDetalleRetencionVenta.DataSource = Nothing
            If pago Then
                dgvPagosFacturaVenta.DataSource = Nothing
                lblIdComprobanteIngresoBanco.Text = "..."
            End If
            If egre Then
                dgvComprobanteIngreso.DataSource = Nothing
                lblIdComprobanteIngresoBanco.Text = "..."
            End If
            If aseg Then dgvAsientoDiarioIngreso.DataSource = Nothing
        End Sub
        Private Sub CargarPagosComprobantesCompra()
            Try
                dgvPagosComprobantesCompra.DataSource = _objetoPagosComprobantesCompra.SeleccionarPagosComrpobantesCompraXIdComprobante(_tipoCon, lblIdComprobanteCompra.Text)
                dgvPagosComprobantesCompra.AutoResizeColumns()
                dgvPagosComprobantesCompra.AutoResizeRows()
                dgvPagosComprobantesCompra.ReadOnly = True

                dgvPagosComprobantesCompra.Columns(1).Width = 150
                dgvPagosComprobantesCompra.Columns(1).DefaultCellStyle.Format = "g"
                dgvPagosComprobantesCompra.Columns(6).Visible = False
            Catch ex As Exception
                dgvPagosComprobantesCompra.DataSource = Nothing
                'MsgBox("METODO CARGAR PAGOS COMPROBANTES DE COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
                KryptonMessageBox.Show("METODO CARGAR PAGOS COMPROBANTES DE COMPRA" & vbNewLine & ex.Message.ToString, "MENSAJE DE EXCEPCIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub dgvComprobantesCompra_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobantesCompra.SelectionChanged
            If dgvComprobantesCompra.RowCount = 0 Or dgvComprobantesCompra.CurrentRow Is Nothing Then
                LimpiarGridsCompra(False, True, True, True, True, True, True)
                Return
            End If
            lblIdComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells(0).Value
            lblFactura.Text = dgvComprobantesCompra.CurrentRow.Cells(3).Value

            lblNumeroRegistroCompra.Text = _objetoNumeroRegistroAsientoCompCompra.BuscarNumeroRegistroAsientoPorIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
            CargarAsientoLibroDiario()



            CargarComprobanteRetencion()
            CargarDetalleComprobanteRetencion()

            CargarPagosComprobantesCompra()

            SumarAsientosDiario()

            ValidarPagosCompras()
        End Sub
        Private Sub CargarComprobanteRetencion()
            Try
                dgvComprobanteRetencion.DataSource = _objetoComprobanteRetencion.SeleccionarComrpobantesRetencionXIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
                dgvComprobanteRetencion.AutoResizeColumns()
                dgvComprobanteRetencion.AutoResizeRows()
                dgvComprobanteRetencion.ReadOnly = True
                If dgvComprobanteRetencion.RowCount > 0 Then
                    lblIdComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(0).Value
                    lblNumeroComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(1).Value
                    lblFechaComprobanteRetencion.Text = Format(dgvComprobanteRetencion.Rows(0).Cells.Item(4).Value, "dd/MM/yyyy")
                    txtTotalComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(8).Value
                Else
                    lblIdComprobanteRetencion.Text = "0"
                    lblNumeroComprobanteRetencion.Text = "0"
                    lblFechaComprobanteRetencion.Text = "00/00/0000"
                    txtTotalComprobanteRetencion.Text = "0.00"
                End If
            Catch ex As Exception
                dgvComprobanteRetencion.DataSource = Nothing
                'MsgBox("METODO CARGAR COMPROBANTE DE RETENCIÓN" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
                KryptonMessageBox.Show("METODO CARGAR COMPROBANTE DE RETENCIÓN" & vbNewLine & ex.Message.ToString, "MENSAJE DE EXCEPCIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub CargarDetalleComprobanteRetencion()
            Try
                dgvDetalleComprobanteRetencion.DataSource = _objetoDetalleComprobantesRetencion.SeleccionarRegistrosDetallesComprobanteRetencionCompraXIdComprobanteRetencion(_tipoCon, lblIdComprobanteRetencion.Text)
                dgvDetalleComprobanteRetencion.Columns(0).HeaderText = "ID"
                dgvDetalleComprobanteRetencion.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(1).HeaderText = "EJERCICIO FISCAL"
                dgvDetalleComprobanteRetencion.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(2).HeaderText = "CODIGO"
                dgvDetalleComprobanteRetencion.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(3).HeaderText = "BASE IMPONIBLE"
                dgvDetalleComprobanteRetencion.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvDetalleComprobanteRetencion.Columns(4).HeaderText = "IMPUESTO"
                dgvDetalleComprobanteRetencion.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(5).HeaderText = "% DE RETENCIÓN"
                dgvDetalleComprobanteRetencion.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(6).HeaderText = "VALOR RETENIDO"
                dgvDetalleComprobanteRetencion.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvDetalleComprobanteRetencion.Columns(7).HeaderText = "EST"
                dgvDetalleComprobanteRetencion.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(8).HeaderText = "ID CR"
                dgvDetalleComprobanteRetencion.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.Columns(9).HeaderText = "ID CC"
                dgvDetalleComprobanteRetencion.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleComprobanteRetencion.AutoResizeColumns()
                dgvDetalleComprobanteRetencion.AutoResizeRows()
                dgvDetalleComprobanteRetencion.ReadOnly = True

                dgvDetalleComprobanteRetencion.Columns(1).Width = 90
                dgvDetalleComprobanteRetencion.Columns(3).Width = 90
                dgvDetalleComprobanteRetencion.Columns(9).Visible = False
            Catch ex As Exception
                dgvDetalleComprobanteRetencion.DataSource = Nothing

                KryptonMessageBox.Show("METODO CARGAR DETALLE COMPROBANTE DE RETENCIÓN" & vbNewLine & ex.Message.ToString, "MENSAJE DE EXCEPCIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub ValidarPagosCompras()
            'If dgvComprobantesCompra.RowCount = 0 Or dgvComprobantesCompra.CurrentRow Is Nothing Then Return
            'If dgvComprobantesCompra.CurrentRow.Cells(0).Value Is DBNull.Value Then Return

            'Dim retencion = dgvComprobantesCompra.CurrentRow.Cells("RETENCION").Value
            'Dim reten As Decimal = dgvDetalleComprobanteRetencion.Rows.Cast(Of DataGridViewRow)().Sum(Function(row) CDec(row.Cells(6).Value))
            'dgvComprobantesCompra.CurrentRow.Cells("RETENCION").Style.BackColor = If(reten = retencion, Color.Cyan, Color.Red)

            'Dim totalpagar = dgvComprobantesCompra.CurrentRow.Cells("TOTAL A PAGAR").Value
            'Dim totpag As Decimal = dgvPagosComprobantesCompra.Rows.Cast(Of DataGridViewRow)().Sum(Function(row) CDec(row.Cells(3).Value))
            'dgvComprobantesCompra.CurrentRow.Cells("TIPO").Style.BackColor = If(totpag = totalpagar, Color.Cyan, Color.Red)
            'dgvComprobantesCompra.CurrentRow.Cells("TOTAL A PAGAR").Style.BackColor = If(totpag = totalpagar, Color.Cyan, Color.Red)
        End Sub
        Private Sub CargarAsientoEgreso()
            Try
                lblNumeroRegistroEgreso.Text = _objetoNumeroRegistroAsientoCompEgreso.BuscarNumeroRegistroAsientoPorIdComprobanteEgreso(_tipoCon, lblIdComprobanteEgreso.Text)
                dgvAsientoDiarioEgreso.DataSource = _objetoAsientoLibroDiario.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, lblNumeroRegistroEgreso.Text)

                dgvAsientoDiarioEgreso.AutoResizeColumns()
                dgvAsientoDiarioEgreso.AutoResizeRows()
                dgvAsientoDiarioEgreso.ReadOnly = True

                dgvAsientoDiarioEgreso.Columns(0).Width = 60
                dgvAsientoDiarioEgreso.Columns(1).Width = 150
                dgvAsientoDiarioEgreso.Columns(1).DefaultCellStyle.Format = "g"
                dgvAsientoDiarioEgreso.Columns(9).Visible = False
                dgvAsientoDiarioEgreso.Columns(10).Visible = False
                dgvAsientoDiarioEgreso.Columns(11).Visible = False
            Catch
                dgvAsientoDiarioEgreso.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarAsientoLibroDiario()
            Try
                dgvAsientoDiarioCompra.DataSource = _objetoAjustarAsientos.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, lblNumeroRegistroCompra.Text)
                dgvAsientoDiarioCompra.AutoResizeColumns()
                dgvAsientoDiarioCompra.AutoResizeRows()
                dgvAsientoDiarioCompra.ReadOnly = True


                dgvAsientoDiarioCompra.Columns(0).Width = 60
                dgvAsientoDiarioCompra.Columns(1).Width = 150
                dgvAsientoDiarioCompra.Columns(1).DefaultCellStyle.Format = "g"
                dgvAsientoDiarioCompra.Columns(9).Visible = False
                dgvAsientoDiarioCompra.Columns(10).Visible = False
                dgvAsientoDiarioCompra.Columns(11).Visible = False
            Catch ex As Exception
                dgvAsientoDiarioCompra.DataSource = Nothing

                KryptonMessageBox.Show("CARGAR ASIENTOS DIARIO BUSQUEDA" & vbNewLine & ex.ToString, "MENSAJE DE EXCEPCIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub SumarAsientosDiario()
            Try
                ' suma asiento compras
                txtTotalDebeCompra.Text = "0.00"
                txtTotalHaberCompra.Text = "0.00"
                For indiceCompra = 0 To dgvAsientoDiarioCompra.Rows.Count - 1
                    txtTotalDebeCompra.Text = CDec(txtTotalDebeCompra.Text) + CDec(dgvAsientoDiarioCompra.Rows(indiceCompra).Cells(6).Value)
                    txtTotalHaberCompra.Text = CDec(txtTotalHaberCompra.Text) + CDec(dgvAsientoDiarioCompra.Rows(indiceCompra).Cells(7).Value)
                Next
                ' suma asiento egreso
                txtTotalDebeEgreso.Text = "0.00"
                txtTotalHaberEgreso.Text = "0.00"
                For indiceEgreso = 0 To dgvAsientoDiarioEgreso.Rows.Count - 1
                    txtTotalDebeEgreso.Text = CDec(txtTotalDebeEgreso.Text) + CDec(dgvAsientoDiarioEgreso.Rows(indiceEgreso).Cells(6).Value)
                    txtTotalHaberEgreso.Text = CDec(txtTotalHaberEgreso.Text) + CDec(dgvAsientoDiarioEgreso.Rows(indiceEgreso).Cells(7).Value)
                Next
            Catch
                txtTotalDebeCompra.Text = "0.00"
                txtTotalHaberCompra.Text = "0.00"

                txtTotalDebeEgreso.Text = "0.00"
                txtTotalHaberEgreso.Text = "0.00"
            End Try

            Try
                ' suma asiento venta
                txtTotalDebeVenta.Text = "0.00"
                txtTotalHaberVenta.Text = "0.00"
                For indiceVenta = 0 To dgvAsientoDiarioVenta.Rows.Count - 1
                    txtTotalDebeVenta.Text = CDec(txtTotalDebeVenta.Text) + CDec(dgvAsientoDiarioVenta.Rows(indiceVenta).Cells(6).Value)
                    txtTotalHaberVenta.Text = CDec(txtTotalHaberVenta.Text) + CDec(dgvAsientoDiarioVenta.Rows(indiceVenta).Cells(7).Value)
                Next
                ' suma asiento ingreso
                txtTotalDebeIngreso.Text = "0.00"
                txtTotalHaberIngreso.Text = "0.00"
                For indiceIngreso = 0 To dgvAsientoDiarioIngreso.Rows.Count - 1
                    txtTotalDebeIngreso.Text = CDec(txtTotalDebeIngreso.Text) + CDec(dgvAsientoDiarioIngreso.Rows(indiceIngreso).Cells(6).Value)
                    txtTotalHaberIngreso.Text = CDec(txtTotalHaberIngreso.Text) + CDec(dgvAsientoDiarioIngreso.Rows(indiceIngreso).Cells(7).Value)
                Next
            Catch
                txtTotalDebeVenta.Text = "0.00"
                txtTotalHaberVenta.Text = "0.00"

                txtTotalDebeIngreso.Text = "0.00"
                txtTotalHaberIngreso.Text = "0.00"
            End Try
        End Sub
        Private Sub dgvPagosComprobantesCompra_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvPagosComprobantesCompra.SelectionChanged
            If dgvPagosComprobantesCompra.RowCount = 0 Or dgvPagosComprobantesCompra.CurrentRow Is Nothing Then
                LimpiarGridsCompra(False, False, False, True, True, True, True)
                Return
            End If

            lblIdComprobanteEgreso.Text = dgvPagosComprobantesCompra.CurrentRow.Cells.Item(8).Value
            CargarComprobanteEgresoBancos()
            CargarAsientoEgreso()

            SumarAsientosDiario()
            ValidarPagosCompras()
        End Sub
        Private Sub CargarComprobanteEgresoBancos()
            Try
                dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.BuscarComprobantesEgresoBancoXIdComprobanteEgreso(_tipoCon, lblIdComprobanteEgreso.Text)
                dgvComprobanteEgresoBancos.AutoResizeColumns()
                dgvComprobanteEgresoBancos.AutoResizeRows()
                dgvComprobanteEgresoBancos.Columns(0).HeaderText = "ID"
                dgvComprobanteEgresoBancos.Columns(1).HeaderText = "N°"
                dgvComprobanteEgresoBancos.Columns(2).HeaderText = "FECHA"
                dgvComprobanteEgresoBancos.Columns(2).DefaultCellStyle.Format = "g"
                dgvComprobanteEgresoBancos.Columns(3).HeaderText = "N° FAC."
                dgvComprobanteEgresoBancos.Columns(4).HeaderText = "RUC"
                dgvComprobanteEgresoBancos.Columns(5).HeaderText = "PROVEEDOR"
                dgvComprobanteEgresoBancos.Columns(8).HeaderText = "TIPO PAGO"
                dgvComprobanteEgresoBancos.Columns(9).HeaderText = "VALOR"
                dgvComprobanteEgresoBancos.Columns(10).HeaderText = "CHEQUE"
                dgvComprobanteEgresoBancos.Columns(11).HeaderText = "N° CHEQUE"
                dgvComprobanteEgresoBancos.Columns(12).HeaderText = "ESTADO"

                dgvComprobanteEgresoBancos.Columns(0).Width = 50
                dgvComprobanteEgresoBancos.Columns(1).Width = 80
                dgvComprobanteEgresoBancos.Columns(2).Width = 150
                dgvComprobanteEgresoBancos.Columns(5).Width = 300
                dgvComprobanteEgresoBancos.Columns(8).Width = 100

                dgvComprobanteEgresoBancos.Columns(13).Visible = False
                dgvComprobanteEgresoBancos.Columns(14).Visible = False
                dgvComprobanteEgresoBancos.Columns(15).Visible = False
                dgvComprobanteEgresoBancos.Columns(16).Visible = False
                dgvComprobanteEgresoBancos.Columns(17).Visible = False
                dgvComprobanteEgresoBancos.Columns(18).Visible = False
                dgvComprobanteEgresoBancos.ReadOnly = True
            Catch
                dgvComprobanteEgresoBancos.DataSource = Nothing
            End Try
        End Sub
        Private Sub txtNombreComercialProveedorGeneral_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialProveedorGeneral.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            lblIdProveedorGeneral.Text = _objetoProveedorGeneral.BuscarIdProveedorXRazonSocialProveedor(_tipoCon, txtNombreComercialProveedorGeneral.Text)
            lblRucProveedorGeneral.Text = _objetoProveedorGeneral.BuscarRucProveedorXIdProveedor(_tipoCon, lblIdProveedorGeneral.Text)
        End Sub
        Private Sub rbPorCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbPorCliente.CheckedChanged
            If rbPorCliente.Checked Then
                gbClienteGeneral.Enabled = True
                gbClienteGeneral.Text = "CLIENTE"
                gbRangoFechas.Enabled = True
                _tipoBusquedaV = 1
                AutocompletarNombreCliente()
            End If
        End Sub
        Private Sub rbConsorcio_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbConsorcio.CheckedChanged
            If rbConsorcio.Checked Then
                gbClienteGeneral.Enabled = True
                gbClienteGeneral.Text = "CONSORCIO/ GRUPO"
                gbRangoFechas.Enabled = True
                _tipoBusquedaV = 2
                AutocompletarConsorcioCliente()
            End If
        End Sub
        Private Sub rbNroFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNroFactura.CheckedChanged
            If rbNroFactura.Checked Then
                gbClienteGeneral.Enabled = True
                gbClienteGeneral.Text = "NUMERO FACTURA"
                gbRangoFechas.Enabled = False
                _tipoBusquedaV = 3
            End If
        End Sub
        Private Sub rbTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbTodo.CheckedChanged
            If rbTodo.Checked Then
                gbClienteGeneral.Enabled = False
                gbRangoFechas.Enabled = True
                lblIdClienteGeneral.Text = 0
                txtClienteGeneral.Text = ""
                _tipoBusquedaV = 4
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
        Private Sub txtClienteGeneral_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtClienteGeneral.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            lblIdClienteGeneral.Text = _objetoClienteGeneral.BuscarIdClienteXRazonSocial(_tipoCon, txtClienteGeneral.Text)
        End Sub
        Private Sub btnBuscarVenta_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarVenta.Click
            CargarFacturasVenta()
            SumarTotalFacturas()
             
            SumarAsientosDiario()

            ValidarPagosVentasGeneral()
        End Sub
        Private Sub CargarFacturasVenta()
            Try
                _fechaDesde = dtpDesdeVenta.Value.Day.ToString & "-" & dtpDesdeVenta.Value.Month.ToString & "-" & dtpDesdeVenta.Value.Year.ToString & " 00:00:00.001"
                _fechaHasta = dtpHastaVenta.Value.Day.ToString & "-" & dtpHastaVenta.Value.Month.ToString & "-" & dtpHastaVenta.Value.Year.ToString & " 23:59:59.000"


                If _tipoBusquedaV = 1 Then
                    dgvFacturaVenta.DataSource = _objetoFacturaVenta.BuscarFacturaVentaXIdClienteRangoFecha(_tipoCon, lblIdClienteGeneral.Text, _fechaDesde, _fechaHasta)
                ElseIf _tipoBusquedaV = 2 Then
                    dgvFacturaVenta.DataSource = _objetoFacturaVenta.BuscarFacturaVentaXConsorcioRangoFecha(_tipoCon, txtClienteGeneral.Text, _fechaDesde, _fechaHasta)
                ElseIf _tipoBusquedaV = 3 Then
                    dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaXNumeroFactura(_tipoCon, txtClienteGeneral.Text)
                Else
                    dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturasVentaXParametros(_tipoCon, lblIdClienteGeneral.Text, _fechaDesde, _fechaHasta, 1)
                End If

                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
                dgvFacturaVenta.Columns("FECHA").Width = 150
                dgvFacturaVenta.Columns("FECHA").DefaultCellStyle.Format = "g"
                dgvFacturaVenta.Columns("CLIENTE").Width = 325
                dgvFacturaVenta.Columns("OBSERVACIONES").Width = 300
                dgvFacturaVenta.Columns(22).Visible = False
                dgvFacturaVenta.ReadOnly = True
            Catch ex As Exception
                dgvFacturaVenta.DataSource = Nothing
                LimpiarGridsVenta(False, True, True, True, True, True, True)
                'MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
                KryptonMessageBox.Show("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, "MENSAJE DE EXCEPCIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub SumarTotalFacturas()
            Dim totalACobrar As Decimal = 0
            Dim totalNotaCredito As Decimal = 0
            Dim totalRetencion As Decimal = 0
            Dim totalSubtotal As Decimal = 0
            Dim totalIva As Decimal = 0
            Dim totalFacturacion As Decimal = 0
            For indiceSuma = 0 To dgvFacturaVenta.RowCount - 1
                totalACobrar += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells(19).Value)
                totalNotaCredito += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells(18).Value)
                totalRetencion += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells(17).Value)
                totalSubtotal += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells(8).Value)
                totalIva += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells(10).Value)
                totalFacturacion += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells(11).Value)
            Next
            txtTotalACobrar.Text = totalACobrar
            txtTotalNotaCredito.Text = totalNotaCredito
            txtTotalRetencion.Text = totalRetencion
            txtTotalSubtotal.Text = totalSubtotal
            txtTotalIVA.Text = totalIva
            txtTotalFacturas.Text = totalFacturacion
        End Sub
        Private Sub ValidarPagosVentasGeneral()
            'Dim saldo As Decimal
            'For indiceVentas = 0 To dgvFacturaVenta.Rows.Count - 1
            '    lblIdFacturaVenta.Text = dgvFacturaVenta.Rows(indiceVentas).Cells("ID").Value
            '    cargarPagosFacturaVenta()

            '    saldo = 0
            '    For indicePago = 0 To dgvPagosFacturaVenta.Rows.Count - 1
            '        ' calcula el saldo de los pagos realizados
            '        If dgvPagosFacturaVenta.Rows(indicePago).Cells("MONTO").Value > 0 Then
            '            saldo = saldo - dgvPagosFacturaVenta.Rows(indicePago).Cells("MONTO").Value
            '            If saldo = CDec(dgvPagosFacturaVenta.Rows(indicePago).Cells("SALDO").Value) Then
            '                dgvFacturaVenta.Rows(indiceVentas).Cells("ID").Style.BackColor = Color.Cyan
            '            Else
            '                dgvFacturaVenta.Rows(indiceVentas).Cells("ID").Style.BackColor = Color.Red
            '            End If
            '        Else
            '            saldo = dgvPagosFacturaVenta.Rows(indicePago).Cells("SALDO").Value
            '        End If

            '        ' verifica el pago en el diario
            '        lblIdComprobanteIngresoBanco.Text = dgvPagosFacturaVenta.Rows(indicePago).Cells("ID INGRESO").Value
            '        cargarAsientoIngreso()
            '        If dgvAsientoDiarioIngreso.Rows.Count > 0 Then
            '            For indiceAsientoEgreso = 0 To dgvAsientoDiarioIngreso.Rows.Count - 1
            '                If dgvAsientoDiarioIngreso.Rows(indiceAsientoEgreso).Cells("CODIGO").Value = "1010205" Then
            '                    If CDec(dgvAsientoDiarioIngreso.Rows(indiceAsientoEgreso).Cells("HABER").Value) = CDec(dgvPagosFacturaVenta.Rows(indicePago).Cells("MONTO").Value) Then
            '                        dgvFacturaVenta.Rows(indiceVentas).Cells("FACTURA").Style.BackColor = Color.Cyan
            '                        Exit For
            '                    Else
            '                        If dgvPagosFacturaVenta.Rows(indicePago).Cells("FORMA PAGO").Value <> "RETENCIÓN" Then
            '                            If dgvPagosFacturaVenta.Rows(indicePago).Cells("FORMA PAGO").Value <> "NOTA DE CRÉDITO" Then
            '                                dgvFacturaVenta.Rows(indiceVentas).Cells("FACTURA").Style.BackColor = Color.Red
            '                            End If
            '                        End If
            '                    End If
            '                End If
            '            Next
            '        End If
            '    Next

            '    lblNumeroRegistroVenta.Text = _objetoNumeroRegistroAsientoFacturaVenta.BuscarNumeroRegistroAsientoPorIdFactura(_tipoCon, lblIdFacturaVenta.Text)
            '    cargarAsientoVenta()
            '    For indiceAsientoVentas = 0 To dgvAsientoDiarioVenta.Rows.Count - 1
            '        If dgvAsientoDiarioVenta.Rows(indiceAsientoVentas).Cells("CODIGO").Value = "1010205" Then
            '            If dgvAsientoDiarioVenta.Rows(indiceAsientoVentas).Cells("DEBE").Value <> dgvFacturaVenta.Rows(indiceVentas).Cells("TOTAL").Value Then
            '                dgvFacturaVenta.Rows(indiceVentas).Cells("FECHA").Style.BackColor = Color.Red
            '            End If
            '        End If
            '    Next
            'Next
        End Sub
        Private Sub CargarPagosFacturaVenta()
            Try
                dgvPagosFacturaVenta.DataSource = _objetoPagosFacturaVenta.SeleccionarPagosFacturaVentaXIdFactura(_tipoCon, lblIdFacturaVenta.Text)
                dgvPagosFacturaVenta.AutoResizeColumns()
                dgvPagosFacturaVenta.AutoResizeRows()
                dgvPagosFacturaVenta.ReadOnly = True
                dgvPagosFacturaVenta.Columns(1).Width = 150
                dgvPagosFacturaVenta.Columns(1).DefaultCellStyle.Format = "g"
                dgvPagosFacturaVenta.Columns(7).Visible = False
                dgvPagosFacturaVenta.Columns(8).Visible = False
            Catch ex As Exception
                dgvPagosFacturaVenta.DataSource = Nothing

                KryptonMessageBox.Show("METODO CARGAR PAGOS FACTURA VENTA" & vbNewLine & ex.Message.ToString, "MENSAJE DE EXCEPCIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub CargarAsientoIngreso()
            Try
                lblNumeroRegistroIngreso.Text = _objetoNumeroRegistroAsientoComprobanteIngreso.BuscarNumeroRegistroAsientoPorIdComprobanteIngreso(_tipoCon, lblIdComprobanteIngresoBanco.Text)
                dgvAsientoDiarioIngreso.DataSource = _objetoAsientoLibroDiario.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, lblNumeroRegistroIngreso.Text)
                dgvAsientoDiarioIngreso.AutoResizeColumns()
                dgvAsientoDiarioIngreso.AutoResizeRows()
                dgvPagosFacturaVenta.ReadOnly = True
                dgvPagosFacturaVenta.Columns(1).Width = 150
                dgvPagosFacturaVenta.Columns(1).DefaultCellStyle.Format = "g"
                dgvAsientoDiarioIngreso.Columns(9).Visible = False
                dgvAsientoDiarioIngreso.Columns(10).Visible = False
                dgvAsientoDiarioIngreso.Columns(11).Visible = False
            Catch
                dgvAsientoDiarioIngreso.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarAsientoVenta()
            Try
                dgvAsientoDiarioVenta.DataSource = _objetoAjustarAsientos.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, lblNumeroRegistroVenta.Text)
                dgvAsientoDiarioVenta.AutoResizeColumns()
                dgvAsientoDiarioVenta.AutoResizeRows()
                dgvAsientoDiarioVenta.Columns(9).Visible = False
                dgvAsientoDiarioVenta.Columns(10).Visible = False
                dgvAsientoDiarioVenta.Columns(11).Visible = False
            Catch
                dgvAsientoDiarioVenta.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvFacturaVenta_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturaVenta.SelectionChanged
            If dgvFacturaVenta.RowCount = 0 Or dgvFacturaVenta.CurrentRow Is Nothing Then
                LimpiarGridsVenta(False, True, True, True, True, True, True)
                Return
            End If

            lblIdFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item("ID").Value
            lblNumeroFactura.Text = dgvFacturaVenta.CurrentRow.Cells.Item("FACTURA").Value
            CargarComprobanteRetencionVenta()
            CargarDetalleComprobanteRetencionVenta()


            lblNumeroRegistroVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item("ASIENTO").Value
            CargarAsientoVenta()

            CargarPagosFacturaVenta()
           
            SumarAsientosDiario()
            ValidarPagosVentasGeneral()
        End Sub
        Private Sub CargarComprobanteRetencionVenta()
            Try
                dgvComprobanteRetencionVenta.DataSource = _objetoComprobanteRetencionCompraVenta.SeleccionarComrpobantesRetencionVentaXIdFacturaVenta(_tipoCon, lblIdFacturaVenta.Text)
                dgvComprobanteRetencionVenta.ReadOnly = True
                If dgvComprobanteRetencionVenta.RowCount > 0 Then
                    lblIdComprobanteRetencionVenta.Text = dgvComprobanteRetencionVenta.Rows(0).Cells.Item(0).Value
                    lblNumeroComprobanteRetencionVenta.Text = dgvComprobanteRetencionVenta.Rows(0).Cells.Item(2).Value
                    lblFechaComprobanteRetencionVenta.Text = Format(dgvComprobanteRetencionVenta.Rows(0).Cells.Item(4).Value, "dd/MM/yyyy")
                    txtTotalComprobanteRetencionVenta.Text = dgvComprobanteRetencionVenta.Rows(0).Cells.Item(7).Value
                Else
                    lblIdComprobanteRetencionVenta.Text = "0"
                    lblNumeroComprobanteRetencionVenta.Text = "0"
                    lblFechaComprobanteRetencionVenta.Text = "00/00/0000"
                    txtTotalComprobanteRetencionVenta.Text = "0.00"
                End If
            Catch ex As Exception
                dgvComprobanteRetencionVenta.DataSource = Nothing
                LimpiarGridsVenta(False, False, False, True, True, True, True)

                KryptonMessageBox.Show("METODO CARGAR COMPROBANTE DE RETENCIÓN VENTA" & vbNewLine & ex.Message.ToString, "MENSAJE DE EXCEPCIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub CargarDetalleComprobanteRetencionVenta()
            Try
                dgvDetalleRetencionVenta.DataSource = _objetoDetalleComprobantesRetencionVenta.SeleccionarRegistrosDetalleComprobanteRetencionVentaXIdComprobanteRetencion(_tipoCon, lblIdComprobanteRetencionVenta.Text)
                dgvDetalleRetencionVenta.Columns(0).HeaderText = "ID"
                dgvDetalleRetencionVenta.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRetencionVenta.Columns(1).HeaderText = "EJERCICIO FISCAL"
                dgvDetalleRetencionVenta.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRetencionVenta.Columns(2).HeaderText = "CODIGO"
                dgvDetalleRetencionVenta.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRetencionVenta.Columns(3).HeaderText = "BASE IMPONIBLE"
                dgvDetalleRetencionVenta.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRetencionVenta.Columns(4).HeaderText = "IMPUESTO"
                dgvDetalleRetencionVenta.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRetencionVenta.Columns(5).HeaderText = "% DE RETENCIÓN"
                dgvDetalleRetencionVenta.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRetencionVenta.Columns(6).HeaderText = "VALOR RETENIDO"
                dgvDetalleRetencionVenta.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRetencionVenta.Columns(7).HeaderText = "EST"
                dgvDetalleRetencionVenta.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRetencionVenta.Columns(8).HeaderText = "ID CR"
                dgvDetalleRetencionVenta.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRetencionVenta.Columns(9).Visible = False
                dgvDetalleRetencionVenta.AutoResizeColumns()
                dgvDetalleRetencionVenta.AutoResizeRows()

            Catch ex As Exception
                dgvDetalleRetencionVenta.DataSource = Nothing

                KryptonMessageBox.Show("METODO CARGAR DETALLE COMPROBANTE DE RETENCIÓN" & vbNewLine & ex.Message.ToString, "MENSAJE DE EXCEPCIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub ValidarPagos()
            'Dim saldo As Decimal = 0
            'For indicePago = 0 To dgvPagosFacturaVenta.Rows.Count - 1
            '    If dgvPagosFacturaVenta.Rows(indicePago).Cells("MONTO").Value > 0 Then
            '        saldo = saldo - dgvPagosFacturaVenta.Rows(indicePago).Cells("MONTO").Value
            '        If saldo = CDec(dgvPagosFacturaVenta.Rows(indicePago).Cells("SALDO").Value) Then
            '            dgvPagosFacturaVenta.Rows(indicePago).Cells("SALDO").Style.BackColor = Color.Cyan
            '        Else
            '            dgvPagosFacturaVenta.Rows(indicePago).Cells("SALDO").Style.BackColor = Color.Red
            '        End If
            '    Else
            '        saldo = dgvPagosFacturaVenta.Rows(indicePago).Cells("SALDO").Value
            '    End If
            'Next
        End Sub
        Private Sub dgvPagosFacturaVenta_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvPagosFacturaVenta.SelectionChanged
            If dgvPagosFacturaVenta.RowCount = 0 Or dgvPagosFacturaVenta.CurrentRow Is Nothing Then
                LimpiarGridsVenta(False, False, False, True, True, True, True)
                Return
            End If

            lblIdComprobanteIngresoBanco.Text = dgvPagosFacturaVenta.CurrentRow.Cells.Item(9).Value.ToString
            If dgvPagosFacturaVenta.CurrentRow.Cells.Item(3).Value = "NOTA DE CRÉDITO" Then
                dgvAsientoDiarioIngreso.DataSource = _objetoAsientoLibroDiario.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, _objetoNumeroRegistroAsientoNotaCredito.BuscarNumeroRegistroAsientoPorIdNotaCredito(_tipoCon, lblIdComprobanteIngresoBanco.Text))
            Else
                CargarComprobanteIngresoBancos()
                CargarAsientoIngreso()
            End If

            SumarAsientosDiario()
            ValidarPagosVentasGeneral()
        End Sub
        Private Sub CargarComprobanteIngresoBancos()
            Try
                dgvComprobanteIngreso.DataSource = _objetoComprobanteIngreso.BuscarComprobantesIngresoXIComprobanteIngreso(_tipoCon, lblIdComprobanteIngresoBanco.Text)

                dgvComprobanteIngreso.AutoResizeColumns()
                dgvComprobanteIngreso.AutoResizeRows()
                dgvComprobanteIngreso.ReadOnly = True
            Catch
                dgvComprobanteIngreso.DataSource = Nothing
            End Try
        End Sub

        Private Sub btnExportarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarPago.Click
            Try
                If dgvPagosFacturaVenta.RowCount > 0 Then
                    ExportarDatosExcel(dgvPagosFacturaVenta, "AUXILIAR DE PAGO")
                Else
                    'MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    KryptonMessageBox.Show("NO HAY DATOS QUE EXPORTAR!", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If
            Catch ex As Exception

            End Try



        End Sub

        Private Sub ExportarDatosExcel(ByVal dgvPagosFacturaVenta As DataGridView, ByVal titulo As String)
            Try
               


                'If dgvPagosFacturaVenta.Rows.Count = 0 Then
                '    MsgBox("NO HAY DATOS QUE EXPORTAR!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                '    Return
                'End If

                Dim fec = ValidationForms.FechaActual(_tipoCon)

                Dim app = New Microsoft.Office.Interop.Excel.Application()
                Dim workbook = app.Workbooks.Add(Type.Missing)
                Dim worksheet = workbook.Worksheets(1)
                worksheet.Name = "AUXILIAR_PAGO"

                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvPagosFacturaVenta)
                worksheet.Range("A1:" & ic & (dgvPagosFacturaVenta.RowCount + 50)).Font.Size = 10


                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  AUXILIAR DE PAGO "
                worksheet.Range("A1:" & ic & "1").Font.Bold = True
                worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                worksheet.Range("A1:" & ic & "1").Font.Size = 12
                'Copete  
                worksheet.Range("A2:" & ic & "2").Merge()
                worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: " & dtpDesdeVenta.Value.ToLongDateString() & "  AL " & dtpHastaVenta.Value.ToLongDateString()
                worksheet.Range("A2:" & ic & "2").Font.Size = 12
                'Fecha  
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                worksheet.Range("A3:" & ic & "3").Font.Size = 12

                'Aca se ingresa las columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvPagosFacturaVenta.Columns.Count - 1
                    If Not dgvPagosFacturaVenta.Columns(i).Visible Then Continue For
                    worksheet.Cells(headin, indc) = dgvPagosFacturaVenta.Columns(i).HeaderText
                    worksheet.Cells(headin, indc).Font.Bold = True
                    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                    worksheet.Cells(headin, indc).Font.Color = Color.White
                    indc += 1
                Next

                'Aca se ingresa el detalle recorrera la tabla celda por celda
                For i = 0 To dgvPagosFacturaVenta.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvPagosFacturaVenta.Columns.Count - 1

                        If Not dgvPagosFacturaVenta.Columns(j).Visible Then Continue For

                        ' asigna valor a celda
                        worksheet.Cells(i + 1 + headin, indc) = dgvPagosFacturaVenta.Rows(i).Cells(j).Value

                        ' definir bordes
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                        If i = dgvPagosFacturaVenta.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                        indc += 1
                    Next
                Next

                'Dim position = CType(worksheet.Cells(2, 7), Range)
                'Clipboard.SetImage(ValidationForms.Logo(_tipoCon))
                'worksheet.Paste(position)

                Dim position As Excel.Range = CType(worksheet.Cells(2, 10), Excel.Range)
                Clipboard.SetImage(ValidationForms.Logo(_tipoCon))
                worksheet.Paste(position)

                worksheet.Range("A1:" & ic & dgvPagosFacturaVenta.RowCount + 50).Columns.AutoFit()

                app.DisplayAlerts = False
                app.Visible = True
                app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
                MessageBox.Show("ARCHIVO generado correctamente!", "MENSAJE DELL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

        Private Sub KryptonPage1_Click(sender As Object, e As EventArgs) Handles KryptonPage1.Click

        End Sub

        Private Sub lblIdComprobanteCompra_Click(sender As Object, e As EventArgs) Handles lblIdComprobanteCompra.Click

        End Sub
    End Class
End Namespace