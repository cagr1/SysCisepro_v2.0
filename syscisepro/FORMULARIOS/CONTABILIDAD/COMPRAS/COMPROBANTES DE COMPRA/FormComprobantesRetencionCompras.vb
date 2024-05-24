Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports ClassLibraryCisepro.ProcesosSql
Imports syscisepro.DATOS
Imports ClassLibraryCisepro.CONTABILIDAD.RETENCIONES_EMITIDAS
Imports ClassLibraryCisepro.VALIDACIONES
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports System.Xml
Imports System.Text
Imports syscisepro.FORMULARIOS.CONTABILIDAD.PORCENTAJES_RETENCION

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormComprobantesRetencionCompras

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

        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoComprobanteRetencion As New ClassComprobantesRetencion
        ReadOnly _objetoDetalleComprobantesRetencion As New ClassDetalleComprobantesRetencion
        ReadOnly _objetoComprobantesRetencion As New ClassComprobantesRetencion
        ReadOnly _objetoDetalleRetencionPlanCuentas As New ClassDetalleRetencionPlanCuentas
        ReadOnly _objetoProveedorGeneral As New ClassProveedores
        ReadOnly _objetoImpuestos As New ClassImpuestos
        ReadOnly _objetoConceptos As New ClassConceptosPago
        ReadOnly _objetoPorcentajes As New ClassPorcentajes
        ReadOnly _objetoContribuyente As New ClassContribuyenteRetenido
        ReadOnly _validacionesNumeros As New ClassNumerico
        ReadOnly _validacionesDecimal As New ClassDecimal
        ReadOnly _objetoEmpresa As New ClassEmpresa
        ReadOnly _objetoAts As New ClassAnexoTransaccional
        ReadOnly _objetoInformacionTributaria As New ClassInformacionTributaria
        ReadOnly _objetoPagosComprobantesCompra As New ClassPagosComprobantesCompra
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoComprobanteRetencionCompraVenta As New ClassComprobantesRetencionCompraVenta
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objetoCentroCosto As New ClassCentroCosto


        Dim _idld = 0
        Dim _numAutoSri As String = ""
        Dim _fechaAutoSri As String = ""
        Dim _tipoCompVenta As String = ""
        Dim _estadoCompRet As Integer = 0

        Dim _tipoAmbiente As Integer = 0 ' tipo de ambiente para facturación electrónica: 1 => PRUEBAS / 2 => PRODUCCIÓN
        Dim _tipoEmision As Integer = 0 ' tipo de emisión para facturación electrónica: 1 => NORMAL / 2 => INDISPONIBILIDAD DEL SISTEMA

        Dim _idEmpresa As String = ""
        Dim _rucEmpresa As String = ""
        Dim _razonSocialEmpresa As String = "" ' razon social de la empresa emisora de la factura electrónica
        Dim _nombreComercialEmpresa As String = ""
        Dim _direccionEmpresa As String = ""
        Dim _numAutoContEspecial As String = ""
        Dim _establecimientoRetencion As String = ""
        Dim _ptoEmisionRetencion As String = ""
        Dim _secuencialRetencion As String = 0
        Dim _tipoIdentificacionCliente As String = "" ' tipo de identificacion del cliente RUC => 04 / CEDULA => 05 / PASAPORTE => 06 / CONSUMIDOR FINAL => 07
        Dim _claveAcceso As String = "" ' clave de acceso para envio de la factura electrónica

        Dim _state As Integer = 0

        Private Sub FormComprobantesRetencionCompras_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            _sqlCommands = New List(Of SqlCommand)
            cmbBienServicio.SelectedIndex = 0
            dtpMes.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)

            LlenarComboImpuesto()
            LlenarComboConcepto()
            LlenarComboContribuyente()

            AutocompletarNombreProveedor()
        End Sub
        Private Sub LlenarComboImpuesto()
            Try
                Dim data = _objetoImpuestos.SeleccionarRegistrosImpuestos(_tipoCon)
                cmbImpuesto.DataSource = data
                cmbImpuesto.DisplayMember = data.Columns(1).ToString
                cmbImpuesto.ValueMember = data.Columns(0).ToString
                cmbImpuesto.SelectedIndex = 0
            Catch
                cmbImpuesto.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarComboConcepto()
            Try
                Dim data = _objetoConceptos.SeleccionarRegistrosConceptosOrdenado(_tipoCon)
                cmbConcepto.DataSource = data
                cmbConcepto.DisplayMember = data.Columns(2).ToString
                cmbConcepto.ValueMember = data.Columns(0).ToString
                cmbConcepto.SelectedIndex = 0
            Catch
                cmbConcepto.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarComboContribuyente()
            Try
                Dim data = _objetoContribuyente.SeleccionarRegistrosContribuyentes(_tipoCon)
                cmbContribuyente.DataSource = data
                cmbContribuyente.DisplayMember = data.Columns(1).ToString
                cmbContribuyente.ValueMember = data.Columns(0).ToString
                cmbContribuyente.SelectedIndex = 0
            Catch
                cmbContribuyente.DataSource = Nothing
            End Try
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
        Private Sub txtNombreComercialProveedorGeneral_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialProveedorGeneral.KeyUp
            If e.KeyCode <> Keys.Enter Then Return

            lblIdProveedorGeneral.Text = _objetoProveedorGeneral.BuscarIdProveedorXRazonSocialProveedor(_tipoCon, txtNombreComercialProveedorGeneral.Text)
            lblRucProveedorGeneral.Text = _objetoProveedorGeneral.BuscarRucProveedorXIdProveedor(_tipoCon, lblIdProveedorGeneral.Text)
            EsContrbuyenteEspecial.Text = _objetoProveedorGeneral.BuscarSiContribuyenteEspecialXIdProveedor(_tipoCon, lblIdProveedorGeneral.Text)

            LimpiarParametrosRetencion()
            CargarComprobantesCompra()
        End Sub
        Private Sub dtpMes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpMes.ValueChanged
            CargarComprobantesCompra()
        End Sub
        Private Sub CargarComprobantesCompra()
            Try
                Dim fechaDesde = dtpMes.Value.Day.ToString & "-" & dtpMes.Value.Month.ToString & "-" & dtpMes.Value.Year.ToString & " 00:00:00.001"
                Dim fechaHasta = dtpMes.Value.AddMonths(1).AddDays(-1).Day.ToString & "-" & dtpMes.Value.Month.ToString & "-" & dtpMes.Value.Year.ToString & " 23:59:59.000"

                dgvComprobantesCompra.DataSource = _objetoComprobantesCompra.SeleccionarComrpobantesCompraXIdProveedorFecha(_tipoCon, lblIdProveedorGeneral.Text, fechaDesde, fechaHasta)
                dgvComprobantesCompra.Columns(0).HeaderText = "ID"
                dgvComprobantesCompra.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(1).HeaderText = "ID P"
                dgvComprobantesCompra.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(2).HeaderText = "TIPO"
                dgvComprobantesCompra.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(3).HeaderText = "NÚMERO"
                dgvComprobantesCompra.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(4).HeaderText = "NRO AUTO SRI"
                dgvComprobantesCompra.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(5).HeaderText = "FECHA AUTO SRI"
                dgvComprobantesCompra.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(6).HeaderText = "FECHA EMISIÓN"
                dgvComprobantesCompra.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(7).HeaderText = "GUIA REMISIÓN"
                dgvComprobantesCompra.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(8).HeaderText = "DOC MODIFICA"
                dgvComprobantesCompra.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(9).HeaderText = "RAZÓN MODIFICA"
                dgvComprobantesCompra.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(10).HeaderText = "OBSERVACIÓN"
                dgvComprobantesCompra.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(11).HeaderText = "SUBTOTAL 12%"
                dgvComprobantesCompra.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(12).HeaderText = "SUBTOTAL  0%"
                dgvComprobantesCompra.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(13).HeaderText = "DESCUENTO   "
                dgvComprobantesCompra.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(14).HeaderText = "SUBTOTAL    "
                dgvComprobantesCompra.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(15).HeaderText = "IVA (12%)   "
                dgvComprobantesCompra.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(16).HeaderText = "TOTAL"
                dgvComprobantesCompra.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvComprobantesCompra.Columns(17).HeaderText = "EST"
                dgvComprobantesCompra.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.AutoResizeColumns()
                dgvComprobantesCompra.AutoResizeRows()
                dgvComprobantesCompra.ReadOnly = True
            Catch
                dgvComprobantesCompra.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvComprobantesCompra_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobantesCompra.SelectionChanged
            If dgvComprobantesCompra.RowCount = 0 Or dgvComprobantesCompra.CurrentRow Is Nothing Then Return

            If dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdComprobanteCompra.Text = "..."
            Else
                lblIdComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value
                lblTipoComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(2).Value
                lblNumeroComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(3).Value
                lblFechaComprobanteCompra.Text = Format(dgvComprobantesCompra.CurrentRow.Cells.Item(6).Value, "dd/MM/yyyy")
                dtpFechaEmisionComprobanteCompra.Value = dgvComprobantesCompra.CurrentRow.Cells.Item(6).Value
                txtSubtotal12.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(11).Value
                txtSubtotal0.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(12).Value
                txtDescuento.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(13).Value
                txtSubtotalComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(14).Value
                txtIvaComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(16).Value
                txtTotalComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(17).Value

                lblEstadoComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(18).Value
                If lblEstadoComprobanteCompra.Text.Trim.Equals("10") Then
                    rbFondoRotativo.Checked = True
                ElseIf lblEstadoComprobanteCompra.Text.Trim.Equals("11") Then
                    rbCajaChica.Checked = True
                Else
                    rbCompras.Checked = True
                End If

                LimpiarParametrosRetencion()
                CargarPagosComprobanteCompra()
                CargarAsientoComprobanteCompra()
                CargarComprobanteRetencion()
            End If
        End Sub
        Private Sub CargarPagosComprobanteCompra()
            Try
                dgvPagosComprobanteCompra.DataSource = _objetoComprobantesCompra.SeleccionarPagosActivoXIdComprobante(_tipoCon, lblIdComprobanteCompra.Text)
                dgvPagosComprobanteCompra.AutoResizeColumns()
                dgvPagosComprobanteCompra.AutoResizeRows()
            Catch
                dgvPagosComprobanteCompra.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarAsientoComprobanteCompra()
            Try
                dgvAsientoComprobanteCompra.DataSource = _objetoComprobantesCompra.SeleccionarAsientoXIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
                dgvAsientoComprobanteCompra.AutoResizeColumns()
                dgvAsientoComprobanteCompra.AutoResizeRows()
            Catch
                dgvAsientoComprobanteCompra.DataSource = Nothing
            End Try
        End Sub
        Private Sub LimpiarParametrosRetencion()
            dgvComprobanteRetencion.DataSource = Nothing
            dgvDetalleComprobanteRetencion.Rows.Clear()

            lblIdComprobanteRetencion.Text = "..."
            _idld = 0
            cmbBienServicio.SelectedIndex = 0
            txtNumeroComprobanteRetencion.Text = ""
            txtNumAutoSRIComprobanteRetencion.Text = ""
            txtPorcentajeRetencion.Text = "0.00"
            txtBaseImponible.Text = "0.00"
            txtTotalComprobanteRetencion.Text = "0.00"
            txtNumAutoSRIComprobanteRetencion.Text = "1113541356"
        End Sub
        Private Sub CargarComprobanteRetencion()
            Try
                dgvComprobanteRetencion.DataSource = _objetoComprobanteRetencion.SeleccionarComrpobantesRetencionXIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
                dgvComprobanteRetencion.AutoResizeColumns()
                dgvComprobanteRetencion.AutoResizeRows()

                If dgvComprobanteRetencion.RowCount > 0 Then
                    lblIdComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(0).Value
                    txtNumeroComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(1).Value

                    If txtNumeroComprobanteRetencion.Text.Trim().Substring(3, 3).Trim.Equals("001") Then
                        rbPtoEmision001.Checked = True
                    Else
                        rbPtoEmision002.Checked = True
                    End If

                    txtNumAutoSRIComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(2).Value
                    dtpComprobanteRetencion.Value = (Format(dgvComprobanteRetencion.Rows(0).Cells.Item(4).Value, "dd/MM/yyyy"))

                    txtTotalComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(8).Value

                    CargarDetalleComprobanteRetencion()
                Else
                    txtTotalComprobanteRetencion.Text = "0.00"
                    LimpiarParametrosRetencion()
                End If
            Catch
                LimpiarParametrosRetencion()
            End Try
        End Sub
        Private Sub CalcularTotalRetencion()
            Dim acumulador = 0.0
            Try
                For indice = 0 To dgvDetalleComprobanteRetencion.RowCount - 1
                    acumulador += Math.Round(CDec(dgvDetalleComprobanteRetencion.Rows(indice).Cells(5).Value), 2, MidpointRounding.AwayFromZero)
                Next
                txtTotalComprobanteRetencion.Text = Math.Round(acumulador, 2, MidpointRounding.AwayFromZero)
            Catch
                txtTotalComprobanteRetencion.Text = acumulador
            End Try
        End Sub
        Private Sub CargarDetalleComprobanteRetencion()
            Try
                Dim data = _objetoDetalleComprobantesRetencion.SeleccionarRegistrosDetallesComprobanteRetencionCompraXIdComprobanteRetencion(_tipoCon, lblIdComprobanteRetencion.Text)
                For Each row As DataRow In data.Rows
                    dgvDetalleComprobanteRetencion.Rows.Add(row(1), row(2), row(3), row(4), row(5), row(6), row(10), row(11))
                Next
            Catch
                dgvDetalleComprobanteRetencion.Rows.Clear()
            End Try
        End Sub
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            If dgvPagosComprobanteCompra.RowCount > 0 Then
                If CDec(dgvPagosComprobanteCompra.Rows(0).Cells(4).Value) = 0 Then
                    MsgBox("LA FACTURA YA HA SIDO PAGADA EN TOTALIDAD!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    Return
                End If
            End If

            If lblIdComprobanteCompra.Text = "..." Then
                MsgBox("DEBE SELECCIONAR UNA COMPRA PARA GENERAR LA RETENCIÓN CORRESPONDIENTE!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If

            If lblIdComprobanteRetencion.Text <> "..." Then
                MsgBox("YA EXISTE UNA RETENCIÓN REGISTRADA PARA ESTA COMPRA!", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If

            If _objetoAts.ValidarCompraConDeclaracion(_tipoCon, dtpFechaEmisionComprobanteCompra.Value) Then
                MsgBox("EL ATS DEL MES " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString & " DEL AÑO " & dtpFechaEmisionComprobanteCompra.Value.Year.ToString & " YA FUE GENERADO." & vbNewLine & " SI NECESITA MODIFICAR ESTE COMPROBANTE SOLICITE UNA SUSTUTIVA A LA CONTADORA Y HAGA UNA REQUISICIÓN AL DEPARTAMENTO DE SISTEMAS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If
            _state = 1

            LimpiarParametrosRetencion()

            gbNombreComercialProveedor.Enabled = False
            dgvComprobantesCompra.Enabled = False
            rbPtoEmision001.Enabled = True
            rbPtoEmision002.Enabled = True
            rbPtoEmision002.Checked = True

            gbRetencion.Enabled = True
            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            btnGenerarXML.Enabled = False

            VerificarNumeroSecuencialRetencion()
        End Sub
        Private Sub VerificarNumeroSecuencialRetencion()
            Try
                Dim empre = _objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)
                If empre.Rows.Count > 0 Then _establecimientoRetencion = empre.Rows(0)(17)
                If rbPtoEmision002.Checked Then
                    _secuencialRetencion = _objetoComprobantesRetencion.BuscarMayorNumeroComprobanteRetencionCompra(_tipoCon) + 1
                    Select Case _secuencialRetencion.Length
                        Case 1 : _secuencialRetencion = "00000000" & _secuencialRetencion
                        Case 2 : _secuencialRetencion = "0000000" & _secuencialRetencion
                        Case 3 : _secuencialRetencion = "000000" & _secuencialRetencion
                        Case 4 : _secuencialRetencion = "00000" & _secuencialRetencion
                        Case 5 : _secuencialRetencion = "0000" & _secuencialRetencion
                        Case 6 : _secuencialRetencion = "000" & _secuencialRetencion
                        Case 7 : _secuencialRetencion = "00" & _secuencialRetencion
                        Case 8 : _secuencialRetencion = "0" & _secuencialRetencion
                        Case 9 : _secuencialRetencion = _secuencialRetencion
                    End Select
                    txtNumeroComprobanteRetencion.Text = _establecimientoRetencion.ToString & "002" & _secuencialRetencion.ToString
                Else
                    txtNumeroComprobanteRetencion.Text = "001001000000001"
                End If

            Catch
                txtNumeroComprobanteRetencion.Text = "001001000000001"
            End Try
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            _state = 0
            LimpiarParametrosGeneral()
            LimpiarParametrosRetencion()

            gbNombreComercialProveedor.Enabled = True
            dgvComprobantesCompra.Enabled = True
            rbPtoEmision001.Enabled = False
            rbPtoEmision002.Enabled = False
            rbPtoEmision002.Checked = True

            gbRetencion.Enabled = False
            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
            btnGenerarXML.Enabled = True
        End Sub
        Private Sub LimpiarParametrosGeneral()
            dgvComprobantesCompra.DataSource = Nothing
            dgvComprobanteRetencion.DataSource = Nothing
            dgvPagosComprobanteCompra.DataSource = Nothing
            dgvDetalleComprobanteRetencion.Rows.Clear()

            lblIdProveedorGeneral.Text = "..."
            lblIdComprobanteCompra.Text = "..."
            lblRucProveedorGeneral.Text = "..."
            EsContrbuyenteEspecial.Text = "..."

            lblEstadoComprobanteCompra.Text = "..."
            lblNumeroComprobanteCompra.Text = "0"
            lblFechaComprobanteCompra.Text = ""
            lblTipoComprobanteCompra.Text = "..."
            txtSubtotal0.Text = "0.00"
            txtSubtotal12.Text = "0.00"
            txtSubtotalComprobanteCompra.Text = "0.00"
            txtIvaComprobanteCompra.Text = "0.00"
            txtTotalComprobanteCompra.Text = "0.00"
            txtNombreComercialProveedorGeneral.Text = ""
            txtNumAutoSRIComprobanteRetencion.Text = "1113541356"
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            dgvDetalleComprobanteRetencion.EndEdit()

            If txtNumeroComprobanteRetencion.TextLength <> 15 Then
                MsgBox("EL NÚMERO DE DE COMPROBANTE DE RETENCIÓN NO PUEDE TENER MENOS DE 15 DÍGITOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return
            End If

            If _objetoAts.ValidarCompraConDeclaracion(_tipoCon, dtpFechaEmisionComprobanteCompra.Value) Then ' si el ats del mes del comprobante ya fue generado
                MsgBox("EL ATS DEL MES " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString & " DEL AÑO " & dtpFechaEmisionComprobanteCompra.Value.Year.ToString & " YA FUE GENERADO." & vbNewLine & " SI NECESITA MODIFICAR ESTE COMPROBANTE SOLICITE UNA SUSTUTIVA A LA CONTADORA Y HAGA UNA REQUISICIÓN AL DEPARTAMENTO DE SISTEMAS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            Else
                If dtpComprobanteRetencion.Value < dtpFechaEmisionComprobanteCompra.Value Then ' si la fecha de la retención es menor a la de la compra
                    MsgBox("LA FECHA DE LA RETENCIÓN NO PUEDE SER MENOR A LA DE LA COMPRA.", MsgBoxStyle.Critical, "MENSAJE DE VALICACIÓN")
                Else
                    If MessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR GENERAR ESTA RETENCIÓN?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                    _sqlCommands.Clear()

                    GuardarComprobanteRetencion()
                    GuardarDetalleComprobanteRetencion()

                    If rbPtoEmision002.Checked Then ActualizarSecuencial()

                    If lblEstadoComprobanteCompra.Text.Trim.Equals("1") Then
                        GuardarPagosComprobantesRetencionCompra()

                        ' restamos valor retencion
                        Dim idasientoCuenta = 0
                        Dim numasientoCuenta = ""
                        Dim numLibro = ""
                        Dim valorCuenta = 0.0
                        For Each row As DataGridViewRow In dgvAsientoComprobanteCompra.Rows
                            numasientoCuenta = row.Cells(12).Value.ToString
                            numLibro = row.Cells(16).Value.ToString
                            If (row.Cells(2).Value.ToString().StartsWith("201030") And CDec(row.Cells(11).Value) > 0) Then
                                idasientoCuenta = row.Cells(0).Value.ToString()
                                valorCuenta = CDec(row.Cells(11).Value)
                            End If
                        Next
                        With _objetoAsientoLibroDiario
                            .IdAsiento = idasientoCuenta
                            .ValorHaberAsiento = valorCuenta - CDec(txtTotalComprobanteRetencion.Text.Trim())
                        End With
                        _sqlCommands.Add(_objetoAsientoLibroDiario.SumarHaberRetencionAsientoLibroDiarioXIdRegistro)

                        NuevoRegistroAsientoDiarioRetencion(numasientoCuenta, numLibro)
                        If (_objetoAsientoLibroDiario.CodigoCuentaAsiento + "").Trim().Length = 0 Then
                            MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "LA CUENTA PARA EL CÓDIGO DE RETENCIÓN ESCOGIDO NO HA SIDO DEFINIDA EN LA BD!", MsgBoxStyle.Exclamation, "MENSAJE DE VALICACIÓN")
                            Return
                        End If
                    End If

                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                    If res(0) Then
                        LimpiarParametrosRetencion()

                        gbNombreComercialProveedor.Enabled = True
                        dgvComprobantesCompra.Enabled = True

                        rbPtoEmision001.Enabled = False
                        rbPtoEmision002.Enabled = False

                        gbRetencion.Enabled = False
                        btnNuevo.Enabled = True
                        btnGuardar.Enabled = False
                        btnCancelar.Enabled = False
                        btnGenerarXML.Enabled = True

                        _state = 1
                        dgvComprobantesCompra_SelectionChanged(Nothing, Nothing)

                    End If
                    MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
                End If
            End If
        End Sub
        Private Sub btnAgregarImpuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarImpuesto.Click
            If CDbl(txtTotalComprobanteCompra.Text) > 0.01 Then
                If CInt(cmbImpuesto.SelectedValue) <> 0 And CInt(cmbConcepto.SelectedValue) <> 0 And CInt(cmbContribuyente.SelectedValue) <> 0 And txtNumeroComprobanteRetencion.Text.Trim().Length <> 0 Then

                    If CInt(cmbImpuesto.SelectedValue) = 1 Then '-=-=-=-=-= SI ES RENTA =-=-=-=-=-                        
                        Dim porret = _objetoPorcentajes.BuscarCantidadPorcentajesRenta(_tipoCon, CInt(cmbConcepto.SelectedValue), CInt(cmbContribuyente.SelectedValue), True)
                        Dim porcent = 0.0
                        Dim cod = ""
                        Dim cue = ""
                        If porret.Rows.Count > 0 Then
                            porcent = CDec(porret.Rows(0)(0))
                            cod = porret.Rows(0)(1)
                            cue = porret.Rows(0)(2)
                        End If

                        Dim response = CDec(txtBaseImponible.Text.Trim)
                        If IsNumeric(response) Then
                            Dim valrenta = Math.Round((CDec(response) * porcent) / 100, 2, MidpointRounding.AwayFromZero)
                            dgvDetalleComprobanteRetencion.Rows.Add(dtpComprobanteRetencion.Value.Year, _objetoConceptos.BuscarCodigoConceptoXIdConcepto(_tipoCon, CInt(cmbConcepto.SelectedValue)), CDec(response), cmbImpuesto.Text, porcent, Math.Round(valrenta, 3, MidpointRounding.AwayFromZero), cod, cue)
                        Else
                            MsgBox("POR FAVOR INGRESE SOLO NÚMEROS" & vbNewLine & "EL SEPARADOR DECIMAL ES EL '.'", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                        End If
                    ElseIf CInt(cmbImpuesto.SelectedValue) = 2 Then  '-=-=-=-=-= SI ES IVA =-=-=-=-=- 
                        Dim porret As DataTable
                        If EsContrbuyenteEspecial.Text.Equals("SI") And CInt(cmbContribuyente.SelectedValue) <> 4 Then
                            porret = _objetoPorcentajes.BuscarCantidadPorcentajesIva(_tipoCon, 5, cmbBienServicio.SelectedIndex, True)
                        Else
                            porret = _objetoPorcentajes.BuscarCantidadPorcentajesIva(_tipoCon, CInt(cmbContribuyente.SelectedValue), cmbBienServicio.SelectedIndex, True)
                        End If
                        Dim porcent = 0.0
                        Dim cod = ""
                        Dim cue = ""
                        If porret.Rows.Count > 0 Then
                            porcent = CDec(porret.Rows(0)(0))
                            cod = porret.Rows(0)(1)
                            cue = porret.Rows(0)(2)
                        End If

                        Dim response = CDec(txtBaseImponible.Text.Trim)
                        If IsNumeric(response) Then
                            Dim valiva = Math.Round((CDbl(response) * porcent) / 100, 2, MidpointRounding.AwayFromZero)
                            dgvDetalleComprobanteRetencion.Rows.Add(dtpComprobanteRetencion.Value.Year, _objetoConceptos.BuscarCodigoConceptoXIdConcepto(_tipoCon, CInt(cmbConcepto.SelectedValue)), CDec(response), cmbImpuesto.Text, porcent, Math.Round(valiva, 2, MidpointRounding.AwayFromZero), cod, cue)
                        Else
                            MsgBox("POR FAVOR INGRESE SOLO NÚMEROS" & vbNewLine & "EL SEPARADOR DECIMAL ES EL '.'", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                        End If
                    End If

                    CalcularTotalRetencion()
                Else
                    MsgBox("SELECCIONE LOS PARAMETROS NECESARIOS: IMPUESTO, CONCEPTO, CONTRIBUYENTE.", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                End If
            Else
                MsgBox("NO HA INGRESADO DATOS DE FACTURA.", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            End If
        End Sub
        Private Sub btnEliminarImpuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarImpuesto.Click
            If dgvDetalleComprobanteRetencion.RowCount = 0 Then Return
            dgvDetalleComprobanteRetencion.Rows.RemoveAt(dgvDetalleComprobanteRetencion.CurrentRow.Index)
            CalcularTotalRetencion()
        End Sub
        Private Sub txtNumeroComprobanteRetencion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroComprobanteRetencion.KeyPress, txtNumAutoSRIComprobanteRetencion.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtBaseImponible_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBaseImponible.KeyPress
            Dim txt = CType(txtBaseImponible, TextBox)
            e.Handled = Not _validacionesDecimal.EsDecimal(e.KeyChar, txt.Text.Trim)
        End Sub
        Private Sub txtBaseImponible_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBaseImponible.KeyUp
            Try
                txtValorRetencion.Text = CDec(txtBaseImponible.Text) * (CDec(txtPorcentajeRetencion.Text) / 100)
            Catch
                txtValorRetencion.Text = "0.00"
            End Try
        End Sub
        Private Sub cmbContribuyente_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbImpuesto.SelectedValueChanged, cmbContribuyente.SelectedValueChanged, cmbConcepto.SelectedValueChanged
            Dim cbm = CType(sender, ComboBox)
            If cbm.SelectedValue Is Nothing Or TypeOf cbm.SelectedValue Is DataRowView Then Return

            Try
                Dim porret As DataTable
                If cmbImpuesto.SelectedValue = 2 Then
                    If EsContrbuyenteEspecial.Text.Equals("SI") And CInt(cmbContribuyente.SelectedValue) <> 4 Then
                        porret = _objetoPorcentajes.BuscarCantidadPorcentajesIva(_tipoCon, 5, cmbBienServicio.SelectedIndex, True)
                    Else
                        porret = _objetoPorcentajes.BuscarCantidadPorcentajesIva(_tipoCon, CInt(cmbContribuyente.SelectedValue), cmbBienServicio.SelectedIndex, True)
                    End If
                Else
                    porret = _objetoPorcentajes.BuscarCantidadPorcentajesRenta(_tipoCon, CInt(cmbConcepto.SelectedValue), CInt(cmbContribuyente.SelectedValue), True)
                End If
                Dim porcent = 0.0
                Dim cod = ""
                Dim cue = ""
                If porret.Rows.Count > 0 Then
                    porcent = CDec(porret.Rows(0)(0))
                    cod = porret.Rows(0)(1)
                    cue = porret.Rows(0)(2)
                End If
                txtPorcentajeRetencion.Text = porcent
                txtValorRetencion.Text = CDec(txtBaseImponible.Text) * (CDec(txtPorcentajeRetencion.Text) / 100)
            Catch
                txtPorcentajeRetencion.Text = "0"
            End Try
        End Sub
        Private Sub rbPtoEmision001_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPtoEmision002.CheckedChanged, rbPtoEmision001.CheckedChanged
            If _state = 0 Then Return
            VerificarNumeroSecuencialRetencion()
        End Sub
        Private Sub GuardarComprobanteRetencion()
            With _objetoComprobantesRetencion
                .IdComprobanteRetencion = .BuscarMayorIdComprobanteRetencionCompra(_tipoCon) + 1
                .NumeroComprobanteRetencion = txtNumeroComprobanteRetencion.Text
                .NumAutoSriComprobanteRetencion = "1113541356"
                .FechaAutoSriComprobanteRetencion = dtpComprobanteRetencion.Value
                .FechaEmisionComprobanteRetencion = dtpComprobanteRetencion.Value
                .IdProveedor = lblIdProveedorGeneral.Text
                .TipoCompVentaComprobanteRetencion = lblTipoComprobanteCompra.Text
                .NumCompVentaComprobanteRetencion = lblNumeroComprobanteCompra.Text
                .TotalComprobanteRetencion = txtTotalComprobanteRetencion.Text
                If rbCompras.Checked = True Then
                    .EstadoComprobanteRetencion = 1
                ElseIf rbFondoRotativo.Checked = True Then
                    .EstadoComprobanteRetencion = 10
                ElseIf rbCajaChica.Checked = True Then
                    .EstadoComprobanteRetencion = 11
                End If
                .IdComprobanteCompra = lblIdComprobanteCompra.Text
            End With
            _sqlCommands.Add(_objetoComprobantesRetencion.NuevoRegistroComprobanteRetencionCompra)
            lblIdComprobanteRetencion.Text = _objetoComprobantesRetencion.IdComprobanteRetencion
        End Sub
        Private Sub GuardarDetalleComprobanteRetencion()
            Dim x = _objetoDetalleComprobantesRetencion.BuscarMayorIdDetalleComprobanteRetencionCompra(_tipoCon) + 1
            Dim idr = _objetoDetalleRetencionPlanCuentas.BuscarMayorIdRegistroDetalleRetencionPlanCuenta(_tipoCon) + 1

            For indice = 0 To dgvDetalleComprobanteRetencion.RowCount - 1
                With _objetoDetalleComprobantesRetencion
                    .IdDetalleComprobanteRetencion = x
                    .EjFiscalDetalleComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(0).Value
                    .CodigoDetalleComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(1).Value
                    .BaseImponibleDetalleComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(2).Value
                    .ImpuestoDetalleComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(3).Value
                    .PorcentajeComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(4).Value
                    .ValorDetalleComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(5).Value
                    If rbCompras.Checked Then
                        .EstadoDetalleComprobanteRetencion = 1
                    ElseIf rbFondoRotativo.Checked Then
                        .EstadoDetalleComprobanteRetencion = 10
                    ElseIf rbCajaChica.Checked Then
                        .EstadoDetalleComprobanteRetencion = 11
                    End If
                    .IdComprobanteRetencion = lblIdComprobanteRetencion.Text
                    .IdComprobanteCompra = lblIdComprobanteCompra.Text
                End With
                _sqlCommands.Add(_objetoDetalleComprobantesRetencion.NuevoRegistroDetalleComprobanteRetencionCompraCommand())

                ' DETALLE RETENCION PLAN CUENTA
                With _objetoDetalleRetencionPlanCuentas
                    .IdDetalleRetencionPlanCuenta = idr
                    .IdFacturaVenta = 0
                    .IdComprobanteCompra = lblIdComprobanteCompra.Text
                    .IdDetalleComprobanteRetencionVenta = 0
                    .IdDetalleComprobanteRetencionCompra = x
                    .Codigo = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(6).Value
                    .Cuenta = dgvDetalleComprobanteRetencion.Rows(+indice).Cells(7).Value
                End With
                _sqlCommands.Add(_objetoDetalleRetencionPlanCuentas.NuevoRegistroDetalleRetencionPlanCuenta)

                x += 1
                idr += 1
            Next
        End Sub
        Private Sub ActualizarSecuencial()
            Dim empre = _objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)
            If empre.Rows.Count > 0 Then

                Select Case _secuencialRetencion.Length
                    Case 1 : _secuencialRetencion = "00000000" & _secuencialRetencion
                    Case 2 : _secuencialRetencion = "0000000" & _secuencialRetencion
                    Case 3 : _secuencialRetencion = "000000" & _secuencialRetencion
                    Case 4 : _secuencialRetencion = "00000" & _secuencialRetencion
                    Case 5 : _secuencialRetencion = "0000" & _secuencialRetencion
                    Case 6 : _secuencialRetencion = "000" & _secuencialRetencion
                    Case 7 : _secuencialRetencion = "00" & _secuencialRetencion
                    Case 8 : _secuencialRetencion = "0" & _secuencialRetencion
                    Case 9 : _secuencialRetencion = _secuencialRetencion
                End Select

                With _objetoInformacionTributaria
                    .Id = CInt(empre.Rows(0)(0))
                    .SecuencialComprobanteRetencion = _secuencialRetencion
                End With
            End If
            _sqlCommands.Add(_objetoInformacionTributaria.ActualizarSecuencialComprobanteRetencionInformacionTributariaCommand())
        End Sub
        Private Sub GuardarPagosComprobantesRetencionCompra()
            Dim p = If(dgvPagosComprobanteCompra.RowCount = 0, 1, CInt(dgvPagosComprobanteCompra.Rows(0).Cells(2).Value) + 1)
            Dim s = If(dgvPagosComprobanteCompra.RowCount > 0, CDec(dgvPagosComprobanteCompra.Rows(0).Cells(4).Value), 0)
            With _objetoPagosComprobantesCompra
                .IdPagosComprobantes = .BuscarMayorIdPagosComprobantesCompra(_tipoCon) + 1
                .FechaPagosComprobantes = dtpFechaEmisionComprobanteCompra.Value
                .NumeroPagosComprobantes = p
                .MontoPagosComprobantes = CDbl(txtTotalComprobanteRetencion.Text)
                .SaldoPagosComprobantes = s - .MontoPagosComprobantes
                .EstadoPagosComprobantes = 1
                .IdComprobante = lblIdComprobanteCompra.Text.Trim
                .IdProveedorGeneral = lblIdProveedorGeneral.Text
                .IdComprobanteEgreso = 0
            End With
            _sqlCommands.Add(_objetoPagosComprobantesCompra.NuevoRegistroPagosComprobantesCompraCommand())
        End Sub

        Private Sub NuevoRegistroAsientoDiarioRetencion(ByVal numasiento As String, ByVal numlibro As String)
            _idld = _objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1

            'Dim codigoCuenta = "0"
            For indiceRetencion = 0 To dgvDetalleComprobanteRetencion.RowCount - 1
                _objetoAsientoLibroDiario.CodigoCuentaAsiento = "" ' LIMPIAR AUX

                Dim codigo = dgvDetalleComprobanteRetencion.Rows(indiceRetencion).Cells.Item(6).Value.ToString().Trim()
                Dim cuenta = dgvDetalleComprobanteRetencion.Rows(indiceRetencion).Cells.Item(7).Value.ToString().Trim()
                If codigo.Trim().Length = 0 Or cuenta.Trim().Length = 0 Then Exit Sub

                With _objetoAsientoLibroDiario
                    .IdAsiento = _idld
                    .FechaAsiento = dtpFechaEmisionComprobanteCompra.Value
                    .CodigoCuentaAsiento = codigo.Trim
                    .NombreCuentaAsiento = cuenta.Trim
                    .ConceptoAsiento = "OBLIGACIONES CON LA ADMINISTRACIÓN TRIBUTARIA"
                    .DetalleTransaccionAsiento = "ID CC: " & lblIdComprobanteCompra.Text & " PROVEEDOR: " & _
                        txtNombreComercialProveedorGeneral.Text.ToString & " " & lblTipoComprobanteCompra.Text.Trim & " NRO: " & lblNumeroComprobanteCompra.Text.ToString & " MES: " & dtpFechaEmisionComprobanteCompra.Value.Month.ToString
                    .ProvinciaAsiento = "EL ORO"
                    .CiudadAsiento = "MACHALA"
                    .ParroquiaAsiento = "MACHALA"
                    .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                    .ValorDebeAsiento = 0
                    .ValorHaberAsiento = CDec(dgvDetalleComprobanteRetencion.Rows(indiceRetencion).Cells.Item(5).Value)
                    .NumeroRegistroAsiento = numasiento
                    .DebeHaberAsiento = 2  ' DEBE=1 / HABER=2 
                    .ConciliarAsiento = 1
                    .EstadoAsiento = 1
                    .IdLibroDiario = numlibro
                    .EstadoMayorAsiento = 0
                End With
                _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                _idld += 1
            Next
        End Sub


        Public RutaDocsElec As String
        Private Sub ModificarComprobanteRetencionCompras()
            With _objetoComprobanteRetencion
                .IdComprobanteRetencion = lblIdComprobanteRetencion.Text
                .NumeroComprobanteRetencion = txtNumeroComprobanteRetencion.Text
                .NumAutoSriComprobanteRetencion = _numAutoSri
                .FechaAutoSriComprobanteRetencion = _fechaAutoSri
                .FechaEmisionComprobanteRetencion = dtpComprobanteRetencion.Value
                .IdProveedor = lblIdProveedorGeneral.Text
                .TipoCompVentaComprobanteRetencion = _tipoCompVenta
                .NumCompVentaComprobanteRetencion = lblNumeroComprobanteCompra.Text
                .TotalComprobanteRetencion = txtTotalComprobanteRetencion.Text
                .EstadoComprobanteRetencion = _estadoCompRet
                .IdComprobanteCompra = lblIdComprobanteCompra.Text
            End With
            _sqlCommands.Add(_objetoComprobanteRetencion.ModificarRegistroComprobanteRetencionCompra)
        End Sub
        Private Sub CargarDatosEmpresa()
            Dim empre = _objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)
            If empre.Rows.Count > 0 Then
                _idEmpresa = empre.Rows(0)(0)
                _rucEmpresa = empre.Rows(0)(2)
                _razonSocialEmpresa = empre.Rows(0)(3)
                _nombreComercialEmpresa = empre.Rows(0)(4)
                _direccionEmpresa = empre.Rows(0)(5)
                _numAutoContEspecial = empre.Rows(0)(6)
                _establecimientoRetencion = empre.Rows(0)(17)
                _ptoEmisionRetencion = "002"
                _secuencialRetencion = empre.Rows(0)(19)
            End If
        End Sub
        Private Sub btnGenerarXML_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGenerarXML.Click
            Try

                ' REVISAR REGENERAR XML

                If lblIdComprobanteCompra.Text <> "..." And lblIdComprobanteRetencion.Text <> "..." Then
                    _numAutoSri = dgvComprobanteRetencion.Rows(0).Cells.Item(2).Value
                    _fechaAutoSri = dgvComprobanteRetencion.Rows(0).Cells.Item(3).Value
                    _tipoCompVenta = dgvComprobanteRetencion.Rows(0).Cells.Item(6).Value
                    _estadoCompRet = dgvComprobanteRetencion.Rows(0).Cells.Item(9).Value

                    ' RUC => 04 / CEDULA => 05 / PASAPORTE => 06 / CONSUMIDOR FINAL => 07
                    Dim idp = _objetoProveedorGeneral.BuscarTipoProveedorXIdProveedor(_tipoCon, lblIdProveedorGeneral.Text)
                    Select Case idp.Trim()
                        Case "RUC" : _tipoIdentificacionCliente = "04"
                        Case "CED" : _tipoIdentificacionCliente = "05"
                        Case "PAS" : _tipoIdentificacionCliente = "06"
                        Case Else
                            If lblRucProveedorGeneral.Text = "9999999999999" Then _tipoIdentificacionCliente = "07"
                    End Select

                    If CInt(_estadoCompRet) > 12 Then ' pregunta si es retención electrónica
                        If MessageBox.Show("¿ESTA SEGURA QUE DESEA GENERAR UN XML DE LA RETENCIÓN?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                        _sqlCommands.Clear()

                        _tipoAmbiente = "2" ' produccion
                        _tipoEmision = "1" ' 1 - normal

                        CargarDatosEmpresa()

                        If txtNumeroComprobanteRetencion.Text <> "000000000000000" Then

                            _establecimientoRetencion = ""
                            _ptoEmisionRetencion = ""
                            _secuencialRetencion = ""
                            For indiceCadena = 1 To txtNumeroComprobanteRetencion.Text.Length
                                If indiceCadena < 4 Then
                                    _establecimientoRetencion = _establecimientoRetencion + Mid(txtNumeroComprobanteRetencion.Text.ToString, indiceCadena, 1).ToString
                                ElseIf indiceCadena > 3 And indiceCadena < 7 Then
                                    _ptoEmisionRetencion = _ptoEmisionRetencion + Mid(txtNumeroComprobanteRetencion.Text.ToString, indiceCadena, 1).ToString
                                ElseIf indiceCadena > 6 Then
                                    _secuencialRetencion = _secuencialRetencion + Mid(txtNumeroComprobanteRetencion.Text.ToString, indiceCadena, 1).ToString
                                End If
                            Next

                            'FACTURA 01, NOTA DE CRÉDITO 04, NOTA DE DÉBITO 05, GUÍA DE REMISIÓN 06, COMPROBANTE DE RETENCIÓN 07
                            _claveAcceso = ValidationForms.GenerarClaveAccesoComprobantesElectronicos("07", dtpComprobanteRetencion.Value, _rucEmpresa, _tipoAmbiente, _establecimientoRetencion, _ptoEmisionRetencion, _secuencialRetencion, _tipoEmision)

                            If _claveAcceso.ToString.Length = 49 Then

                                ModificarComprobanteRetencionCompras() ' modifica el comprobante de retencion
                                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                                If res(0) Then
                                    ExportarXml() ' exporta el comprobante de retención electónico a formato XML
                                Else
                                    MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
                                End If

                            Else
                                MsgBox("CLAVE DE ACCESO NO ES VÁLIDA!")
                            End If
                        Else
                            MsgBox("EL NUMERO DE COMPROBANTE 000000000000000 NO ES VALIDO PARA GENERAR XML", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                        End If
                    Else
                        MsgBox("EL COMPROBANTE SELECCIONADO NO TIENE RETENCION ELECTRÓNICA PARA GENERAR XML", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    End If
                Else
                    MsgBox("SELECCIONE UN COMPROBANTE DE COMPRA CON RETENCIÓN PARA GENERAR XML", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                End If
            Catch ex As Exception
                MsgBox("HUBO UN PROBLEMA AL GENERAR XML!" & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End Try
        End Sub
        Private Sub ExportarXml()
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
                xml += "<claveAcceso>" & _claveAcceso & "</claveAcceso>" & vbNewLine ' Pendiente...
                xml += "<codDoc>07</codDoc>" & vbNewLine ' FACTURA => 01 / NOTA DE CRÉDITO => 04 / NOTA DE DEBITO => 05 / COMPROBANTE DE RETENCIÓN => 07
                xml += "<estab>" & _establecimientoRetencion & "</estab>" & vbNewLine
                xml += "<ptoEmi>" & _ptoEmisionRetencion & "</ptoEmi>" & vbNewLine
                xml += "<secuencial>" & _secuencialRetencion & "</secuencial>" & vbNewLine
                xml += "<dirMatriz>" & _direccionEmpresa & "</dirMatriz>" & vbNewLine
                xml += "<agenteRetencion>00000001</agenteRetencion>" & vbNewLine
                xml += "</infoTributaria>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<infoCompRetencion>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LA RETENCION =-=-=-=-=-=-=-=-=-=-=-=-=
                xml += "<fechaEmision>" & Format(dtpComprobanteRetencion.Value, "dd/MM/yyyy") & "</fechaEmision>" & vbNewLine
                xml += "<dirEstablecimiento>" & _direccionEmpresa & "</dirEstablecimiento>" & vbNewLine
                'xml += "<contribuyenteEspecial>" & _numAutoContEspecial & "</contribuyenteEspecial>" & vbNewLine
                xml += "<obligadoContabilidad>SI</obligadoContabilidad>" & vbNewLine
                xml += "<tipoIdentificacionSujetoRetenido>" & _tipoIdentificacionCliente & "</tipoIdentificacionSujetoRetenido>" & vbNewLine
                xml += "<razonSocialSujetoRetenido>" & txtNombreComercialProveedorGeneral.Text.Replace("Ñ", "N").Trim() & "</razonSocialSujetoRetenido>" & vbNewLine
                xml += "<identificacionSujetoRetenido>" & lblRucProveedorGeneral.Text & "</identificacionSujetoRetenido>" & vbNewLine
                ' sacar el perio fiscal de la retencion [mm/aaaa]
                Dim mesPeriodoFiscal = If(dtpComprobanteRetencion.Value.Month < 10, "0" & dtpComprobanteRetencion.Value.Month, dtpComprobanteRetencion.Value.Month.ToString)
                Dim periodoFiscal = mesPeriodoFiscal.ToString + "/" + dtpComprobanteRetencion.Value.Year.ToString
                xml += "<periodoFiscal>" & periodoFiscal & "</periodoFiscal>" & vbNewLine
                xml += "</infoCompRetencion>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                If dgvDetalleComprobanteRetencion.Rows.Count > 0 Then
                    xml += "<impuestos>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- INFORMACÍON DE LOS IMPUESTO QUE APLICAN =-=-=-=-=-=-=-=-=-=-=-=-=
                    For indiceDetalle = 0 To dgvDetalleComprobanteRetencion.Rows.Count - 1
                        xml += "<impuesto>" & vbNewLine ' =-=-=-=-=-=-=-=-=-=- DETALLE DE CADA IMPUESTO =-=-=-=-=-=-=-=-=-=-=-=-=
                        If dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(3).Value.ToString = "RENTA" Then
                            xml += "<codigo>1</codigo>" & vbNewLine ' RENTA => 1 IVA => 2 / ISD => 6
                            xml += "<codigoRetencion>" & dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(1).Value.ToString & "</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION RENTA
                        ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(3).Value.ToString = "IVA" Then
                            xml += "<codigo>2</codigo>" & vbNewLine ' RENTA => 1 IVA => 2 / ISD => 6
                            If dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(4).Value = 10 Then
                                xml += "<codigoRetencion>9</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION ENTRE CONT. ESP.
                            ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(4).Value = 20 Then
                                xml += "<codigoRetencion>10</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION ENTRE CONT. ESP.
                            ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(4).Value = 30 Then
                                xml += "<codigoRetencion>1</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA BIENES
                            ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(4).Value = 70 Then
                                xml += "<codigoRetencion>2</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA SERVICIOS
                            ElseIf dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(4).Value = 100 Then
                                xml += "<codigoRetencion>3</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA 100%
                            Else
                                xml += "<codigoRetencion>1</codigoRetencion>" & vbNewLine ' CODIGO DE RETENCION IVA BIENES
                            End If
                        End If
                        xml += "<baseImponible>" & dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(2).Value & "</baseImponible>" & vbNewLine
                        xml += "<porcentajeRetener>" & dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(4).Value & "</porcentajeRetener>" & vbNewLine
                        xml += "<valorRetenido>" & Math.Round(CDec(dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells(5).Value), 2, MidpointRounding.ToEven) & "</valorRetenido>" & vbNewLine
                        xml += "<codDocSustento>01</codDocSustento>" & vbNewLine
                        xml += "<numDocSustento>" & lblNumeroComprobanteCompra.Text & "</numDocSustento>" & vbNewLine
                        xml += "<fechaEmisionDocSustento>" & Format(dtpFechaEmisionComprobanteCompra.Value, "dd/MM/yyyy") & "</fechaEmisionDocSustento>" & vbNewLine
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
                writer.WriteRaw(xml)
                writer.Flush()
                writer.Close()

                MsgBox("RETENCIÓN ELECTRÓNICA" & vbNewLine & "XML GENERADO CORRECTAMENTE", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN.")
            Catch ex As Exception
                MsgBox("ERROR AL GENERAR RETENCIÓN ELECTRÓNICA" & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "MENSAJE DE INFORMACIÓN.")
            End Try
        End Sub

        Private Sub dgvDetalleComprobanteRetencion_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvDetalleComprobanteRetencion.CellBeginEdit
            ' SOLO MOIDIFCAR PORCENTAJE DE IVA
            If dgvDetalleComprobanteRetencion.CurrentRow.Cells(3).Value <> "IVA" Then e.Cancel = True
        End Sub

        Private Sub dgvDetalleComprobanteRetencion_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleComprobanteRetencion.CellEndEdit
            Try
                ' dialogo escoger cuenta (cod, cue)
                Dim _frmPlan = New FrmBuscarPlanCuentas()
                _frmPlan.TipoCox = _tipoCon
                _frmPlan.Tipo = 2
                _frmPlan.cbxTipoCuenta.Enabled = False
                _frmPlan.txtParametrobusqueda.Enabled = False


                If dgvDetalleComprobanteRetencion(3, e.RowIndex).Value = "IVA" Then
                    _frmPlan.txtParametrobusqueda.Text = "201070102"
                Else
                    _frmPlan.txtParametrobusqueda.Text = "201070101"
                End If

                If _frmPlan.ShowDialog = DialogResult.OK Then
                    dgvDetalleComprobanteRetencion(6, e.RowIndex).Value = _frmPlan.listView1.SelectedItems(0).SubItems(1).Text.Trim()
                    dgvDetalleComprobanteRetencion(7, e.RowIndex).Value = _frmPlan.listView1.SelectedItems(0).SubItems(2).Text.Trim()
                Else
                    dgvDetalleComprobanteRetencion(6, e.RowIndex).Value = String.Empty
                    dgvDetalleComprobanteRetencion(7, e.RowIndex).Value = String.Empty
                End If


                Dim bi = dgvDetalleComprobanteRetencion.CurrentRow.Cells(2).Value
                Dim pr = dgvDetalleComprobanteRetencion.CurrentRow.Cells(4).Value
                dgvDetalleComprobanteRetencion.CurrentRow.Cells(5).Value = (CDec(bi) * (CDec(pr) / 100))
            Catch
                dgvDetalleComprobanteRetencion(4, e.RowIndex).Value = String.Empty
                dgvDetalleComprobanteRetencion(5, e.RowIndex).Value = 0
                dgvDetalleComprobanteRetencion(6, e.RowIndex).Value = String.Empty
                dgvDetalleComprobanteRetencion(7, e.RowIndex).Value = String.Empty
                MsgBox("HUBO UN PROBLEMA AL CALCULAR VALOR RETENIDO, INTENTE DE NUEVO.", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            End Try
            CalcularTotalRetencion()
        End Sub

    End Class
End Namespace