Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports Krypton.Toolkit
Imports syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormComprobanteIngresoBanco
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
        Public UserName As String
        ReadOnly _objetoComprobanteIngresoBancos As New ClassComprobanteIngresoBanco
        ReadOnly _objetoConceptosComprobanteIngresoBancos As New ClassConceptosComprobanteIngresoBancos
        ReadOnly _objetoCentroCosto As New ClassCentroCosto
        ReadOnly _objetoBancosCobros As New ClassBancosCobros
        ReadOnly _objetoBancos As New ClassBancos
        ReadOnly _objetoCuentaBancos As New ClassCuentasBancos
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoLibroDiario As New ClassLibroDiario
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoNumeroRegistro As New ClassNumeroRegistroAsiento
        ReadOnly _objetoNumeroRegistroAsientoComprobanteIngreso As New ClassNumeroRegistroAsientoComprobanteIngreso
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoPagosFacturaVenta As New ClassPagosFacturaVenta
        ReadOnly _objetoChequesRecibidos As New ClassChequesRecibidosCxc
        ReadOnly _validacionesNumeros As New ClassNumerico
        ReadOnly _validacionesDecimales As New ClassDecimal
        Dim _sqlCommands As List(Of SqlCommand)
        Dim _dataPagos As Dictionary(Of String, String)

        Dim _numerosFacturas() As String ' Array que acumula las facturas seleccionadas de distintos clientes
        Dim _cantidadFacturas As Integer ' Cotador para tener cuantas facturas se selecciono y redimensionar el array
        Dim _nroFilasEgreso = 0

        Private Sub FormComprobanteIngresoBanco_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteIngresoBanco.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvPagosFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobanteIngresoBanco.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvPagosFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobanteIngresoBanco.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvPagosFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvComprobanteIngresoBanco.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvPagosFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)

            _sqlCommands = New List(Of SqlCommand)
            _dataPagos = New Dictionary(Of String, String)

            lblValorCuentaBanco.Text = String.Empty

            LlenarConcepto()
            LlenarCuentasContables()
            LlenarComboCentroCosto()
            LlenarComboBancos()

            CargarGrillaComprobanteIngresoBancos()
            DeshabilitadoInicio(False)

            AutocompletarNombreCliente()
            AutocompletarNombreBancoCobros()
            dgvComprobanteIngresoBanco.ContextMenuStrip = ContextMenuStripClicDerecho
        End Sub
        Private Sub LlenarComboCentroCosto()
            Try
                Dim data = _objetoCentroCosto.SeleccionarCentroCosto(_tipoCon)
                cmbCentroCosto.DataSource = data
                cmbCentroCosto.DisplayMember = data.Columns(1).ToString
                cmbCentroCosto.ValueMember = data.Columns(0).ToString
            Catch
                cmbCentroCosto.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarComboBancos()
            Try
                Dim data = _objetoBancos.SeleccionarRegistrosBancos(_tipoCon)
                cmbBancos.DataSource = data
                cmbBancos.DisplayMember = data.Columns(2).ToString
                cmbBancos.ValueMember = data.Columns(0).ToString
                If (CType(cmbBancos.DataSource, DataTable).Rows.Count > 0) Then cmbBancos.SelectedIndex = 0
            Catch
                cmbBancos.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbBancos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbBancos.SelectedValueChanged
            If cmbBancos.SelectedValue Is Nothing Or TypeOf cmbBancos.SelectedValue Is DataRowView Then Return
            LlenarComboCuentasBancos()
        End Sub
        Private Sub LlenarComboCuentasBancos()
            Try
                Dim data = _objetoCuentaBancos.BuscarNumeroCuentaXIdBanco(_tipoCon, CInt(cmbBancos.SelectedValue))
                cmbCuentaBancos.DataSource = data
                cmbCuentaBancos.DisplayMember = data.Columns(1).ToString
                cmbCuentaBancos.ValueMember = data.Columns(0).ToString
            Catch
                cmbCuentaBancos.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarConcepto()
            Try
                Dim data = _objetoConceptosComprobanteIngresoBancos.SeleccionarRegistrosConceptosComprobanteIngresoBancos(_tipoCon)
                cmbConcepto.DataSource = data
                cmbConcepto.DisplayMember = data.Columns(1).ToString
                cmbConcepto.ValueMember = data.Columns(0).ToString
            Catch
                cmbConcepto.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarCuentasContables()
            Try
                Dim data = _objetoPlanCuentas.SeleccionarCuentasYDetallePlanDeCuentas(_tipoCon)
                cmbCuentasContables.DataSource = data
                cmbCuentasContables.DisplayMember = data.Columns(0).ToString
                cmbCuentasContables.ValueMember = data.Columns(1).ToString
            Catch
                cmbCuentasContables.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarGrillaComprobanteIngresoBancos()
            dgvComprobanteIngresoBanco.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvComprobanteIngresoBanco.Columns("CUENTA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvComprobanteIngresoBanco.Columns("CONCEPTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvComprobanteIngresoBanco.Columns("DETALLE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvComprobanteIngresoBanco.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvComprobanteIngresoBanco.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvComprobanteIngresoBanco.Columns("ID_CC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft

            dgvComprobanteIngresoBanco.Columns("CODIGO").ReadOnly = True
            dgvComprobanteIngresoBanco.Columns("CUENTA").ReadOnly = True
            dgvComprobanteIngresoBanco.Columns("CONCEPTO").ReadOnly = True
            dgvComprobanteIngresoBanco.Columns("DETALLE").ReadOnly = True
            dgvComprobanteIngresoBanco.Columns("DEBE").ReadOnly = True
            dgvComprobanteIngresoBanco.Columns("HABER").ReadOnly = True
            dgvComprobanteIngresoBanco.Columns("ID_CC").ReadOnly = True
        End Sub
        Private Sub DeshabilitadoInicio(ByVal enable As Boolean)
            btnNuevo.Enabled = True
            btnGuardar.Enabled = enable
            btnCancelar.Enabled = enable
            btnReporte.Enabled = enable

            'gbCabeceraComprobante.Enabled = False

            dtpFechaEmisionComprobanteIngreso.Enabled = enable

            'pCentroCosto.Enabled = enable
            cmbConcepto.Enabled = enable
            cmbCentroCosto.Enabled = enable
            gbFormaPago.Enabled = enable
            gbAcreditado.Enabled = enable
            'gbCtaContable.Enabled = enable
            cmbCuentasContables.Enabled = enable
            'gbFacturasAPagar.Enabled = enable
            txtFacturasAPagar.Enabled = enable
            gbCheque.Enabled = enable
            'gbObservaciones.Enabled = enable
            txtObservacionesComprobanteIngreso.Enabled = enable
            'gbValorComprobanteIngreso.Enabled = enable
            txtValorComprobaneIngreso.Enabled = enable
            'gbBanco.Enabled = enable
            cmbBancos.Enabled = enable
            cmbCuentaBancos.Enabled = enable
            gbTotalDebeTotalHaber.Enabled = enable
            'gbClienteGeneral.Enabled = enable
            txtNombreComercialClienteGeneral.Enabled = enable
            gbFacturaVenta.Enabled = enable
            gbPagosFacturaVenta.Enabled = enable
        End Sub
        Private Sub AutocompletarNombreCliente()
            Try
                txtNombreComercialClienteGeneral.AutoCompleteCustomSource = _objetoClienteGeneral.Autocompletar(_tipoCon)
                txtNombreComercialClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialClienteGeneral.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub AutocompletarNombreBancoCobros()
            Try
                txtBancoCheque.AutoCompleteCustomSource = _objetoBancosCobros.Autocompletar(_tipoCon)
                txtBancoCheque.AutoCompleteMode = AutoCompleteMode.Suggest
                txtBancoCheque.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtBancoCheque.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub rbAcreditadoBancos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAcreditadoBancos.CheckedChanged, RadioButton1.CheckedChanged, RadioButton9.CheckedChanged, RadioButton12.CheckedChanged
            If rbAcreditadoBancos.Checked Then
                'gbCtaContable.Enabled = False
                cmbCuentasContables.Enabled = False
                'gbBanco.Enabled = True
                cmbBancos.Enabled = True
                cmbCuentaBancos.Enabled = True
            End If
        End Sub
        Private Sub rbAcreditadoCaja_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbAcreditadoCaja.CheckedChanged, RadioButton2.CheckedChanged, RadioButton13.CheckedChanged, RadioButton10.CheckedChanged
            If rbAcreditadoCaja.Checked Then
                'gbCtaContable.Enabled = True
                cmbCuentasContables.Enabled = True
                'gbBanco.Enabled = False
                cmbBancos.Enabled = False
                cmbCuentaBancos.Enabled = False
            End If
        End Sub
        Private Sub rbAcreditadoCruceCtas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbAcreditadoCruceCtas.CheckedChanged, RadioButton3.CheckedChanged, RadioButton14.CheckedChanged, RadioButton11.CheckedChanged
            If rbAcreditadoCruceCtas.Checked Then
                'gbCtaContable.Enabled = True
                cmbCuentasContables.Enabled = True
                'gbBanco.Enabled = False
                cmbBancos.Enabled = False
                cmbCuentaBancos.Enabled = False
            End If
        End Sub
        Private Sub rbCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If rbCheque.Checked Then
                If txtNombreComercialClienteGeneral.Text <> "" And lblIdClienteGeneral.Text <> "..." Then
                    gbCheque.Enabled = True
                    txtTitularCheque.Text = txtNombreComercialClienteGeneral.Text
                Else
                    'MsgBox("PRIMERO CARGUE UN CLIENTE", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    KryptonMessageBox.Show("Primero cargue un cliente", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    rbEfectivo.Checked = True
                End If
            Else
                gbCheque.Enabled = False
                txtTitularCheque.Text = ""
            End If
        End Sub
        Private Sub cmbCuentasContables_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbCuentasContables.SelectedValueChanged
            If cmbCuentasContables.SelectedValue Is Nothing Or TypeOf cmbCuentasContables.SelectedValue Is DataRowView Then Return
            lblCodigoCuentaContable.Text = cmbCuentasContables.SelectedValue
        End Sub
        Private Sub HabilitadoNuevo(ByVal enable As Boolean)
            btnNuevo.Enabled = False
            btnReporte.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True


            'gbCabeceraComprobante.Enabled = True
            dtpFechaEmisionComprobanteIngreso.Enabled = enable
            txtNumeroComprobanteIngreso.Enabled = False
            'pCentroCosto.Enabled = True
            cmbConcepto.Enabled = enable
            cmbCentroCosto.Enabled = enable
            gbAcreditado.Enabled = enable
            'gbCtaContable.Enabled = True
            cmbCuentasContables.Enabled = enable
            btnAgregarConceptoComprobante.Enabled = enable
            gbFormaPago.Enabled = enable
            'bFacturasAPagar.Enabled = enable
            txtFacturasAPagar.Enabled = enable
            gbCheque.Enabled = False
            'gbObservaciones.Enabled = True
            txtObservacionesComprobanteIngreso.Enabled = enable
            'gbValorComprobanteIngreso.Enabled = True

            txtValorComprobaneIngreso.Enabled = enable
            'gbBanco.Enabled = True
            cmbBancos.Enabled = enable
            cmbCuentaBancos.Enabled = enable
            gbTotalDebeTotalHaber.Enabled = False
            'gbClienteGeneral.Enabled = True
            txtNombreComercialClienteGeneral.Enabled = enable
            gbFacturaVenta.Enabled = True
            gbPagosFacturaVenta.Enabled = True
        End Sub
        Private Sub LimpiarParametros()
            txtNumeroComprobanteIngreso.Text = ""

            lblValorCuentaBanco.Text = String.Empty

            cmbCuentasContables.Text = ""
            cmbCentroCosto.Text = ""
            lblCodigoCuentaContable.Text = "..."
            txtFacturasAPagar.Text = ""
            txtObservacionesComprobanteIngreso.Text = "..."
            txtValorComprobaneIngreso.Text = "0.00"
            txtTitularCheque.Text = ""
            txtBancoCheque.Text = ""
            txtCtaCteCheque.Text = ""
            txtNumeroCheque.Text = ""
            txtTotalDebe.Text = "0.00"
            txtTotalHaber.Text = "0.00"
            lblIdClienteGeneral.Text = "..."
            txtNombreComercialClienteGeneral.Text = "..."
            rbAcreditadoBancos.Checked = False
            rbAcreditadoCruceCtas.Checked = False
            rbAcreditadoCaja.Checked = False
            dgvComprobanteIngresoBanco.Rows.Clear()

            dgvFacturaVenta.DataSource = Nothing
            dgvPagosFacturaVenta.DataSource = Nothing
        End Sub
        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            If CInt(lblIdComprobanteIngresoBancos.Text) <> 0 Then
                Dim f = New FormReporteComprobanteIngresoBancos
                f.TipoCox = TipoCox
                f.lblIdComprobanteIngreso.Text = CInt(lblIdComprobanteIngresoBancos.Text)
                f.ShowDialog()
                btnNuevo.Enabled = True
                btnReporte.Enabled = False
            Else
                'MsgBox("POR FAVOR SELECCIONE UN COMPROBANTE DE INGRESO", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                KryptonMessageBox.Show("Por favor seleccione un comprobante de ingreso", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            lblValorCuentaBanco.Text = String.Empty

            rbEfectivo.Checked = True
            HabilitadoNuevo(True)
            txtNombreComercialClienteGeneral.Enabled = True
            LlenarConcepto()
            LlenarCuentasContables()
            LlenarComboCentroCosto()
            LlenarComboBancos()

            _cantidadFacturas = 0
            ReDim _numerosFacturas(_cantidadFacturas)
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            LimpiarParametros()
            DeshabilitadoInicio(False)
        End Sub
        Private Function ValidarFacturasSeleccionadas(ByVal idFacturaSeleciconada) As Boolean
            Dim facturaValida = 1 ' asigna el valor de factura valida
            For indiceAsiento = 0 To dgvComprobanteIngresoBanco.Rows.Count - 1
                If idFacturaSeleciconada = dgvComprobanteIngresoBanco.Rows(indiceAsiento).Cells(6).Value Then ' si la factura ya esta agregada
                    facturaValida = 0 ' factura invalida
                End If
            Next
            Return facturaValida = 1
        End Function
        Private Function ValidarParametros()
            If txtFacturasAPagar.Text <> "" And lblIdClienteGeneral.Text <> "..." And txtValorComprobaneIngreso.Text <> "0.00" And txtTotalDebe.Text <> "0.00" And txtTotalHaber.Text <> "0.00" Then
                If rbCheque.Checked Then
                    If txtTitularCheque.Text <> "" And txtBancoCheque.Text <> "" And txtCtaCteCheque.Text <> "" And txtNumeroCheque.Text <> "" Then
                        Return True
                    Else
                        KryptonMessageBox.Show("Escogio forma de pago cheque." & vbNewLine & "No ha llenado todos los campos del cheque.", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        Return False
                    End If
                Else
                    Return True
                End If
            Else

                KryptonMessageBox.Show("Revise el comprobante de ingreso." & vbNewLine & "No ha llenado todos los campos del comprobante.", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return False
            End If
        End Function
        Private Sub ValidarPagosAnteriores()
            Dim saldo As Decimal = 0
            For indicePago = 0 To dgvPagosFacturaVenta.Rows.Count - 1
                If dgvPagosFacturaVenta.Rows(indicePago).Cells("MONTO").Value > 0 Then
                    saldo = saldo - dgvPagosFacturaVenta.Rows(indicePago).Cells("MONTO").Value
                    If saldo = CDec(dgvPagosFacturaVenta.Rows(indicePago).Cells("SALDO").Value) Then
                        dgvPagosFacturaVenta.Rows(indicePago).Cells("SALDO").Style.BackColor = Color.Cyan
                    Else
                        dgvPagosFacturaVenta.Rows(indicePago).Cells("SALDO").Style.BackColor = Color.Red
                    End If
                Else
                    saldo = dgvPagosFacturaVenta.Rows(indicePago).Cells("SALDO").Value
                End If
            Next
        End Sub
        Private Function ValidarPagosIngresados()
            Dim bandera = 0 ' 0 VALIDO ; 1 INVALIDO
            For indiceAsiento = 0 To dgvComprobanteIngresoBanco.Rows.Count - 1
                If dgvComprobanteIngresoBanco.Rows(indiceAsiento).Cells("ID_CC").Value <> 0 Then
                    If dgvComprobanteIngresoBanco.Rows(indiceAsiento).Cells("HABER").Value > _objetoPagosFacturaVenta.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, dgvComprobanteIngresoBanco.Rows(indiceAsiento).Cells("ID_CC").Value) Then
                        dgvComprobanteIngresoBanco.Rows(indiceAsiento).Cells("DEBE").Style.BackColor = Color.LightSalmon
                        dgvComprobanteIngresoBanco.Rows(indiceAsiento).Cells("HABER").Style.BackColor = Color.LightSalmon

                        KryptonMessageBox.Show("SALDO NEGATIVO EN LA FACTURA: " + _objetoFacturaVenta.BuscarNumeroFacturaVentaXIdFacturaVenta(_tipoCon, dgvComprobanteIngresoBanco.Rows(indiceAsiento).Cells("ID_CC").Value).ToString, "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        bandera = 1
                    End If
                End If
            Next
            Return bandera
        End Function
        Private Function ValidarFechasFacturas()
            Dim fechaValida = 0 ' 0 VALIDO ; 1 INVALIDO
            For indiceFacturas = 0 To dgvFacturaVenta.Rows.Count - 1
                If dgvFacturaVenta.Rows(indiceFacturas).Cells("CHK").Value Then
                    If dgvFacturaVenta.Rows(indiceFacturas).Cells("FECHA").Value > dtpFechaEmisionComprobanteIngreso.Value Then
                        fechaValida = 1

                        KryptonMessageBox.Show("Fecha Invalida." & vbNewLine & "LA FECHA DE LA FACTURA: " + dgvFacturaVenta.Rows(indiceFacturas).Cells("NUMERO").Value + "es posterior a la fecha de comprobante de ingreso", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If
                End If
            Next
            Return fechaValida
        End Function
        Private Sub CargarFacturasVenta()
            Try
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaImpagasXIdCliente(_tipoCon, lblIdClienteGeneral.Text)
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
            Catch
                dgvFacturaVenta.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarPagosFacturaVenta()
            Try
                dgvPagosFacturaVenta.DataSource = _objetoPagosFacturaVenta.SeleccionarPagosFacturaVentaXIdFactura(_tipoCon, lblIdFacturaVenta.Text)
                dgvPagosFacturaVenta.AutoResizeColumns()
                dgvPagosFacturaVenta.AutoResizeRows()
                dgvPagosFacturaVenta.Columns("FECHA").Width = 65
                dgvPagosFacturaVenta.Columns("NUMERO").Width = 50
                dgvPagosFacturaVenta.Columns("FORMA PAGO").Width = 65
                dgvPagosFacturaVenta.ReadOnly = False
                dgvPagosFacturaVenta.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception

                KryptonMessageBox.Show("METODO CARGAR PAGOS FACTURA VENTA" & vbNewLine & ex.Message.ToString, "MENSAJE DE EXCEPCIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub SumarTotalDebeHaber()
            Dim totalDebe As Decimal = 0
            Dim totalHaber As Decimal = 0
            For indice = 0 To dgvComprobanteIngresoBanco.RowCount - 1
                totalDebe += CDec(dgvComprobanteIngresoBanco.Rows(indice).Cells(4).Value)
                totalHaber += CDec(dgvComprobanteIngresoBanco.Rows(indice).Cells(5).Value)
            Next
            txtValorComprobaneIngreso.Text = totalHaber
            txtTotalDebe.Text = totalDebe
            txtTotalHaber.Text = totalHaber
        End Sub
        Private Sub txtNombreComercialClienteGeneral_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialClienteGeneral.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Try
                lblIdClienteGeneral.Text = _objetoClienteGeneral.BuscarIdClienteXRazonSocial(_tipoCon, txtNombreComercialClienteGeneral.Text)
            Catch
                lblIdClienteGeneral.Text = String.Empty
            End Try
            CargarFacturasVenta()
        End Sub
        Private Sub btnAgregarConceptoComprobante_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarConceptoComprobante.Click
            Try
                Dim nroFilaIngreso = dgvComprobanteIngresoBanco.RowCount

                If rbAcreditadoCaja.Checked Or rbAcreditadoCruceCtas.Checked Then 'PREGUNTO VA A SER ACREDITADO EL INGRESO A CAJA O CRUCE DE CTAS
                    If lblCodigoCuentaContable.Text <> "..." Then 'verifica que se haya seleccionado una cuenta contable
                        dgvComprobanteIngresoBanco.Rows.Add()
                        ' ingresa los valores de codigo y nombre de la cuenta contable seleccionada
                        dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(0).Value = lblCodigoCuentaContable.Text
                        dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(1).Value = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, lblCodigoCuentaContable.Text.Trim())

                        ' ingresa el concepto
                        dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(2).Value = "COMPROBANTE DE INGRESO"

                        ' se detalla la transacción según la forma de pago
                        If rbCheque.Checked Then
                            dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + txtFacturasAPagar.Text + " BANCO: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: CHEQUE BANCO " + txtBancoCheque.Text + " NRO " + txtNumeroCheque.Text
                        ElseIf rbEfectivo.Checked Then
                            dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + txtFacturasAPagar.Text + " BANCO: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: EFECTIVO"
                        ElseIf rbTarjetaCredido.Checked Then
                            dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + txtFacturasAPagar.Text + " BANCO: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: TARJETA DE CRÉDITO"
                        ElseIf rbTransaccion.Checked Then
                            dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + txtFacturasAPagar.Text + " BANCO: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: TRANSACCIÓN"
                        ElseIf rbNotaCredito.Checked Then
                            dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + txtFacturasAPagar.Text + " BANCO: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: TRANSACCIÓN"
                        End If

                        lblValorCuentaBanco.Text = txtValorComprobaneIngreso.Text

                        dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(4).Value = txtValorComprobaneIngreso.Text 'se ingresa el valor del debe
                        dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(5).Value = "0.00" 'se ingresa el valor del haber
                        dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(6).Value = "0" ' el id de la factura
                    Else

                        KryptonMessageBox.Show("SELECCIONE UNA CUENTA CONTABLE.", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If
                ElseIf rbAcreditadoBancos.Checked Then 'PREGUNTO VA A SER ACREDITADO EL INGRESO A BANCOS
                    If CInt(cmbBancos.SelectedValue) <> "0" And CInt(cmbCuentaBancos.SelectedValue) <> "0" Then ' verifica que se haya seleccionado un banco y una cuenta
                        dgvComprobanteIngresoBanco.Rows.Add()

                        ' ingreso los valores de codigo y nombre de la cuenta de banco seleccionada
                        Dim cod = _objetoCuentaBancos.BuscarCodigoPlanXIdCuenta(_tipoCon, CInt(cmbCuentaBancos.SelectedValue))
                        dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(0).Value = cod
                        dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(1).Value = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, cod)

                        ' ingresa el concepto
                        dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(2).Value = "COMPROBANTE DE INGRESO"

                        'se obtiene el ruc del cliente y segun el tipo de pago seleccionado se ingresa el valor del detalle
                        If rbCheque.Checked Then
                            dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + txtFacturasAPagar.Text + " BANCO: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: CHEQUE BANCO " + txtBancoCheque.Text + " NRO " + txtNumeroCheque.Text
                        ElseIf rbEfectivo.Checked Then
                            dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + txtFacturasAPagar.Text + " BANCO: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: EFECTIVO"
                        ElseIf rbTarjetaCredido.Checked Then
                            dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + txtFacturasAPagar.Text + " BANCO: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: TARJETA DE CRÉDITO"
                        ElseIf rbTransaccion.Checked Then
                            dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + txtFacturasAPagar.Text + " BANCO: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: TRANSACCIÓN"
                        ElseIf rbNotaCredito.Checked Then
                            dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + txtFacturasAPagar.Text + " BANCO: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: TRANSACCIÓN"
                        End If

                        lblValorCuentaBanco.Text = txtValorComprobaneIngreso.Text

                        dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(4).Value = txtValorComprobaneIngreso.Text 'se ingresa el valor del debe
                        dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(5).Value = "0.00" 'se ingresa el valor del haber
                        dgvComprobanteIngresoBanco.Rows(nroFilaIngreso).Cells(6).Value = "0" ' el id de la factura
                    Else

                        KryptonMessageBox.Show("SELECCIONE UN BANCO Y UNA CUENTA.", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If
                Else

                    KryptonMessageBox.Show("SELECCIONE A DONDE VA A ACREDITAR.", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                End If
                SumarTotalDebeHaber()
                btnEditarValores.Enabled = True
            Catch ex As Exception

                KryptonMessageBox.Show("CARGAR COMPROBANTE INGRESO: BANCOS" & vbNewLine & ex.Message.ToString, "MENSAJE DE EXCEPCIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub dgvFacturaVenta_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturaVenta.SelectionChanged
            If dgvFacturaVenta.RowCount = 0 Then Return
            If dgvFacturaVenta.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdFacturaVenta.Text = "..."
            Else
                lblIdFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(1).Value ' obtiene el id de la factura seleccionada
            End If
            CargarPagosFacturaVenta() ' carga los pagos realizados a la factura seleccionada
            ValidarPagosAnteriores()
        End Sub
        Private Sub dgvFacturaVenta_CellContentClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturaVenta.CellContentClick
            If e.ColumnIndex = chk.Index Then
                Dim value = CBool(dgvFacturaVenta.CurrentCell.EditedFormattedValue)

                If value Then ' CheckBox Marcado

                    If ValidarFacturasSeleccionadas(dgvFacturaVenta.CurrentRow.Cells(1).Value) = True Then ' si la factura no esta ya agregada

                        ' busca el saldo de la factgura
                        If _objetoPagosFacturaVenta.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, dgvFacturaVenta.CurrentRow.Cells(1).Value) <> 0 Then ' si tiene saldo

                            _numerosFacturas(_cantidadFacturas) = txtNombreComercialClienteGeneral.Text.Trim & "/" & dgvFacturaVenta.CurrentRow.Cells(2).Value.ToString ' numero y cliente

                            Dim cadena = ""
                            For indiceArray = 0 To _cantidadFacturas ' carga los numeros de las factura seleccionados
                                cadena = cadena + _numerosFacturas(indiceArray).Split("/")(0).Trim + ", FAC: " + _numerosFacturas(indiceArray).Split("/")(1).Trim + ";" & vbCrLf
                            Next
                            _cantidadFacturas = _cantidadFacturas + 1 ' aumenta el numero de comprobantes seleccionados
                            ReDim Preserve _numerosFacturas(_cantidadFacturas) ' redimensiona el array a la cantidad de facturas actual

                            ' carga las facturas a pagar
                            txtFacturasAPagar.Text = cadena

                            '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= CARGA EL DIARIO DEL COMPROBANTE DE INGRESO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                            dgvComprobanteIngresoBanco.Rows.Add()
                            _nroFilasEgreso = dgvComprobanteIngresoBanco.Rows.Count - 1

                            ' obtiene el numero de la cta seleccionada
                            dgvComprobanteIngresoBanco.Rows(_nroFilasEgreso).Cells(0).Value = _objetoConceptosComprobanteIngresoBancos.BuscarCuentaConceptosComprobanteIngresoBancosPorNombre(_tipoCon, cmbConcepto.Text)
                            dgvComprobanteIngresoBanco.Rows(_nroFilasEgreso).Cells(1).Value = cmbConcepto.Text
                            dgvComprobanteIngresoBanco.Rows(_nroFilasEgreso).Cells(2).Value = "COMPROBANTE DE INGRESO"

                            ' se detalla la transacción según la forma de pago
                            If rbCheque.Checked Then
                                dgvComprobanteIngresoBanco.Rows(_nroFilasEgreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + dgvFacturaVenta.CurrentRow.Cells(2).Value + " FORMA PAGO: CHEQUE BANCO " + txtBancoCheque.Text + " NRO " + txtNumeroCheque.Text
                            ElseIf rbEfectivo.Checked Then
                                dgvComprobanteIngresoBanco.Rows(_nroFilasEgreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + dgvFacturaVenta.CurrentRow.Cells(2).Value + " FORMA PAGO: EFECTIVO"
                            ElseIf rbTarjetaCredido.Checked Then
                                dgvComprobanteIngresoBanco.Rows(_nroFilasEgreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + dgvFacturaVenta.CurrentRow.Cells(2).Value + " FORMA PAGO: TARJETA DE CRÉDITO"
                            ElseIf rbTransaccion.Checked Then
                                dgvComprobanteIngresoBanco.Rows(_nroFilasEgreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + dgvFacturaVenta.CurrentRow.Cells(2).Value + " FORMA PAGO: TRANSACCIÓN"
                            Else
                                dgvComprobanteIngresoBanco.Rows(_nroFilasEgreso).Cells(3).Value = "ID: " + txtNumeroComprobanteIngreso.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + dgvFacturaVenta.CurrentRow.Cells(2).Value + " FORMA PAGO: NOTA CRÉDITO"
                            End If

                            dgvComprobanteIngresoBanco.Rows(_nroFilasEgreso).Cells(4).Value = "0.00" ' se ingresa el valor del debe

                            ' se busca el saldo de la factura seleccionada
                            dgvComprobanteIngresoBanco.Rows(_nroFilasEgreso).Cells(5).Value = _objetoPagosFacturaVenta.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, dgvFacturaVenta.CurrentRow.Cells(1).Value) ' se ingresa el valor del haber
                            dgvComprobanteIngresoBanco.Rows(_nroFilasEgreso).Cells(6).Value = dgvFacturaVenta.CurrentRow.Cells(1).Value.ToString ' el id de la factura

                            SumarTotalDebeHaber() ' suma los totales del comprobante de ingreso (Debe-Haber)
                        Else

                            KryptonMessageBox.Show("ESTA FACTURA YA FUE CANCELADA", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        End If
                    Else '  caso contrario si la factura ya ha sido agregada

                        KryptonMessageBox.Show("ESTA FACTURA YA ESTA AGREGADA", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If
                Else ' CheckBox Desmarcado"
                    For indiceArray = 0 To _cantidadFacturas - 1
                        If _numerosFacturas(indiceArray) = dgvFacturaVenta.CurrentRow.Cells(3).Value.ToString Then
                            _numerosFacturas(indiceArray) = ""
                        End If
                    Next
                    For indiceArray = 0 To _cantidadFacturas - 1
                        If indiceArray <> _cantidadFacturas - 1 Then
                            If _numerosFacturas(indiceArray) = "" And _numerosFacturas(indiceArray + 1) <> "" Then
                                _numerosFacturas(indiceArray) = _numerosFacturas(indiceArray + 1)
                                _numerosFacturas(indiceArray + 1) = ""
                            End If
                        End If
                    Next

                    For indiceCompEgreso = 0 To dgvComprobanteIngresoBanco.Rows.Count - 1
                        If dgvComprobanteIngresoBanco.Rows(indiceCompEgreso).Cells(6).Value.ToString = dgvFacturaVenta.CurrentRow.Cells(1).Value.ToString Then
                            dgvComprobanteIngresoBanco.Rows.RemoveAt(dgvComprobanteIngresoBanco.Rows(indiceCompEgreso).Index)
                            Exit For
                        End If
                    Next

                    ' validar que el valor del indice no sea negativo
                    If _cantidadFacturas > 0 Then
                        _cantidadFacturas = _cantidadFacturas - 1
                    Else
                        _cantidadFacturas = 0
                    End If

                    ReDim Preserve _numerosFacturas(_cantidadFacturas) ' redimensiona el array a la cantidad de facturas actual

                    ' carga las facturas a pagar
                    Dim cadena = ""
                    For indiceArray = 0 To _cantidadFacturas - 1
                        cadena = cadena + _numerosFacturas(indiceArray).Split("/")(0).Trim + ", FAC: " + _numerosFacturas(indiceArray).Split("/")(1).Trim + ";" & vbCrLf
                    Next
                    txtFacturasAPagar.Text = cadena

                    SumarTotalDebeHaber()
                End If
            End If
        End Sub
        Private Sub btnEditarValores_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEditarValores.Click
            If dgvComprobanteIngresoBanco.RowCount > 0 Then
                dgvComprobanteIngresoBanco.Columns("DEBE").ReadOnly = False
                dgvComprobanteIngresoBanco.Columns("HABER").ReadOnly = False
                dgvComprobanteIngresoBanco.Rows(0).Cells(4).Selected = True
            End If
        End Sub
        Private Sub dgvComprobanteIngresoBanco_CellValidated(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvComprobanteIngresoBanco.CellValidated
            SumarTotalDebeHaber()
        End Sub
        Private Sub dgvComprobanteIngresoBanco_EditingControlShowing(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvComprobanteIngresoBanco.EditingControlShowing
            Dim itemType = TryCast(e.Control, TextBox)
            If itemType IsNot Nothing Then AddHandler itemType.KeyPress, AddressOf ItemType_KeyPress
        End Sub
        Private Sub ItemType_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles dgvComprobanteIngresoBanco.KeyPress
            Select Case dgvComprobanteIngresoBanco.CurrentCell.ColumnIndex
                Case 0
                    e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
                Case 4
                    e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
                Case 5
                    e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
            End Select
        End Sub
        Private Sub ToolStripMenuItemEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItemEliminar.Click
            Dim lSeleccionados As DataGridViewSelectedRowCollection = dgvComprobanteIngresoBanco.SelectedRows
            Select Case lSeleccionados.Count
                Case 0
                    KryptonMessageBox.Show("Debe seleccionar alguna fila", "", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Return
                Case Is > 1
                    KryptonMessageBox.Show("Demasiadas filas seleccionadas", "", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Return
            End Select

            Dim loFila As DataGridViewRow = Me.dgvComprobanteIngresoBanco.CurrentRow()
            Dim lsMensage As String = "¿Esta seguro de querer eliminar este Registro" & vbCrLf & loFila.Cells(2).Value.ToString()
            If KryptonMessageBox.Show(lsMensage, "", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then Return

            Try
                dgvComprobanteIngresoBanco.Rows.RemoveAt(dgvComprobanteIngresoBanco.CurrentRow.Index)
                SumarTotalDebeHaber()
            Catch ex As Exception
                KryptonMessageBox.Show(ex.Message, "", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End Try
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If CDec(txtTotalDebe.Text) = CDec(txtTotalHaber.Text) Then

                If CDec(lblValorCuentaBanco.Text) = CDec(txtValorComprobaneIngreso.Text) Then

                    If ValidarParametros() Then ' valida que todos los campos esten llenos

                        If ValidarPagosIngresados() = 0 Then ' valida que los pagos no generen saldos negativos

                            If ValidarFechasFacturas() = 0 Then ' valida que las fechas de las facturas no sean posteriores al comprobante de ingreso

                                If KryptonMessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR EL COMPROBANTE?", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                                _sqlCommands.Clear()

                                _objetoComprobanteIngresoBancos.Id = _objetoComprobanteIngresoBancos.BuscarMayorIdComprobanteIngresoBancos(_tipoCon) + 1

                                _objetoLibroDiario.IdLibroDiario = _objetoLibroDiario.BuscarMayorIdLibroDiario(_tipoCon)

                                With _objetoNumeroRegistro
                                    .NumeroRegistro = .BuscarMayorNumeroRegistro(_tipoCon) + 1
                                    .NumeroAnterior = .BuscarMayorNumeroAnterior(_tipoCon) + 1
                                End With
                                _sqlCommands.Add(_objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand())

                                ' GUARDA EL COMPROBANTE DE Ingreso
                                GuardarRegistroComprobanteIngresoBancos()

                                ' GUARDA EL PAGO FACTURAS DE VENTA A CLIENTE EN CASO DE QUE HUBIESE
                                GuardarRegistroPagosFacturaVenta()

                                ' ACTUALIZA EL MONTO DE LA CUENTA DE LA QUE INGRESO EL PAGO
                                ActualizarMontoCuentaBancos()

                                ' GUARDA LOS ASIENTOS DEL LIBRO DIARIO
                                NuevoRegistroAsientoDiarioComprobanteIngresoBancos()

                                ' GUARDA LOS LOS REGISTROS PARA ENLAZAR EL COMPROBANTE DE INGRESO CON EL DIARIO
                                GuardarNumeroRegistroAsientoComprobanteIngreso()

                                ' GUARDA EL CHEQUE DE PAGO EN CASO DE QUE HUBIESE
                                If rbCheque.Checked Then GuardarRegistroChequesRecibidos()

                                If CDec(_objetoComprobanteIngresoBancos.ValorComprobanteIngreso) < 0.01 Then
                                    If rbAcreditadoCruceCtas.Checked Then
                                        If dgvComprobanteIngresoBanco.RowCount = 2 Then
                                            _objetoComprobanteIngresoBancos.ValorComprobanteIngreso = CDec(txtTotalDebe.Text.Trim)
                                        Else
                                            Dim response = InputBox("INGRESE EL VALOR DEL COMPROBANTE PARA CRUCE DE CUENTAS", "VALOR COMPROBANTE INGRESO", 0, , )
                                            If IsNumeric(response) Then
                                                _objetoComprobanteIngresoBancos.ValorComprobanteIngreso = CDec(response)
                                            Else

                                                KryptonMessageBox.Show("No se ha especificado el valor para comprobante de ingreso!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                                                Return
                                            End If
                                        End If
                                    Else

                                        KryptonMessageBox.Show("No se ha especificado el valor para comprobante de ingreso!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                                        Return
                                    End If
                                End If

                                Dim nombreU As String = "Comprobante Ingreso Banco por: " & UserName
                                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                                If res(0) Then

                                    ' DEJA EL FORMULARIO EN SU ESTADO INICIAL
                                    LimpiarParametros()
                                    DeshabilitadoInicio(False)

                                    lblIdComprobanteIngresoBancos.Text = _objetoComprobanteIngresoBancos.Id
                                    btnReporte.Enabled = True
                                End If
                                Dim messageIcon As KryptonMessageBoxIcon
                                If res(0) Then
                                    messageIcon = KryptonMessageBoxIcon.Information
                                Else
                                    messageIcon = KryptonMessageBoxIcon.Exclamation
                                End If
                                KryptonMessageBox.Show(res(1), "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, messageIcon)


                            Else

                                KryptonMessageBox.Show("NO SE PUEDE GUARDAR." & vbNewLine & "LAS FECHAS DE LAS FACTURAS SON POSTERIORES AL INGRESO .", "MENSAJE DE VALIDACION", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                            End If
                        Else

                            KryptonMessageBox.Show("NO SE PUEDE GUARDAR." & vbNewLine & "LOS VALORES DE LOS PAGOS GENERAN SALDOS NEGATIVOS .", "MENSAJE DE VALIDACION", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        End If
                    Else

                        KryptonMessageBox.Show("NO SE PUEDE GUARDAR." & vbNewLine & "NO HA LLENADO TODOS LOS CAMPOS NECESARIOS .", "MENSAJE DE VALIDACION", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If

                Else

                    KryptonMessageBox.Show("NO SE PUEDE GUARDAR." & vbNewLine & "LOS VALORES DE EL DEBE Y EL HABER NO COINCIDEN POR FAVOR REVISE LAS TRANSACCIONES.", "MENSAJE DE VALIDACION", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                End If

            Else

                KryptonMessageBox.Show("NO SE PUEDE GUARDAR." & vbNewLine & "LOS VALORES DE EL DEBE Y EL HABER NO COINCIDEN POR FAVOR REVISE LAS TRANSACCIONES.", "MENSAJE DE VALIDACION", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Sub GuardarRegistroComprobanteIngresoBancos()
            With _objetoComprobanteIngresoBancos
                .FechaComprobanteIngreso = dtpFechaEmisionComprobanteIngreso.Value
                .NumeroFactura = txtFacturasAPagar.Text
                .IdCliente = CInt(lblIdClienteGeneral.Text)
                .ActividadComprobanteIngreso = txtActividad.Text
                If rbAcreditadoCruceCtas.Checked Then
                    .ConceptoComprobanteIngreso = "CRUCE INTERNO DE CUENTAS"
                Else
                    .ConceptoComprobanteIngreso = cmbConcepto.Text
                End If
                If rbCheque.Checked Then
                    .FormaPagoComprobanteIngreso = "CHEQUE"
                ElseIf rbEfectivo.Checked Then
                    .FormaPagoComprobanteIngreso = "EFECTIVO"
                ElseIf rbTarjetaCredido.Checked Then
                    .FormaPagoComprobanteIngreso = "TARJETA DE CREDITO"
                ElseIf rbTransaccion.Checked Then
                    .FormaPagoComprobanteIngreso = "TRANSACCION"
                ElseIf rbNotaCredito.Checked Then
                    .FormaPagoComprobanteIngreso = "NOTA DE CREDITO"
                Else
                    .FormaPagoComprobanteIngreso = "EFECTIVO"
                End If
                .ObservacionesComprobanteIngreso = txtObservacionesComprobanteIngreso.Text

                .ValorComprobanteIngreso = lblValorCuentaBanco.Text

                .NumeroDepositoComprobanteIngreso = "0"
                .EstadoComprobanteIngreso = 1
                .IdProvincias = "7"
                .IdCiudad = "58"
                .IdParroquias = "287"
                .IdCentro = CInt(cmbCentroCosto.SelectedValue)
                .IdBancos = CInt(cmbBancos.SelectedValue)
                .IdCuentaBancos = CInt(cmbCuentaBancos.SelectedValue)
            End With
            _sqlCommands.Add(_objetoComprobanteIngresoBancos.NuevoRegistroComprobanteIngresoBancos)
        End Sub
        Private Sub GuardarRegistroPagosFacturaVenta()
            Dim idc As String
            Dim ip = _objetoPagosFacturaVenta.BuscarMayorIdPagoFacturaVenta(_tipoCon) + 1
            _dataPagos.Clear()

            For indice = 0 To dgvComprobanteIngresoBanco.RowCount - 1
                idc = dgvComprobanteIngresoBanco.Rows(indice).Cells(6).Value.ToString().Trim()
                If idc <> 0 Then

                    If _dataPagos.ContainsKey(idc) Then
                        Dim vars = _dataPagos(idc).Split("-")
                        Dim n = CInt(vars(0).Trim()) + 1
                        Dim v = CDec(vars(1).Trim()) - CDec(dgvComprobanteIngresoBanco.Rows(indice).Cells(5).Value)

                        With _objetoPagosFacturaVenta
                            .IdPagoFactura = ip
                            .FechaPagoFactura = dtpFechaEmisionComprobanteIngreso.Value
                            .NumeroPagoFactura = n
                            If rbCheque.Checked Then
                                .FormaPagoFactura = "CHEQUE"
                            ElseIf rbEfectivo.Checked Then
                                .FormaPagoFactura = "EFECTIVO"
                            ElseIf rbTarjetaCredido.Checked Then
                                .FormaPagoFactura = "TARJETA DE CREDITO"
                            ElseIf rbTransaccion.Checked Then
                                .FormaPagoFactura = "TRANSACCION"
                            ElseIf rbNotaCredito.Checked Then
                                .FormaPagoFactura = "NOTA DE CREDITO"
                            Else
                                .FormaPagoFactura = "EFECTIVO"
                            End If
                            .MontoPagoFactura = dgvComprobanteIngresoBanco.Rows(indice).Cells(5).Value
                            .SaldoPagoFactura = v
                            .EstadoPagoFactura = 1
                            .IdFactura = dgvComprobanteIngresoBanco.Rows(indice).Cells(6).Value
                            .IdCliente = _objetoFacturaVenta.BuscarIdClienteXIdFacturaVenta(_tipoCon, dgvComprobanteIngresoBanco.Rows(indice).Cells(6).Value)
                            .IdComprobanteIngreso = _objetoComprobanteIngresoBancos.Id
                        End With
                        _dataPagos(idc) = n & "-" & v
                    Else
                        With _objetoPagosFacturaVenta
                            .IdPagoFactura = ip
                            .FechaPagoFactura = dtpFechaEmisionComprobanteIngreso.Value
                            .NumeroPagoFactura = .BuscarMayorNumeroPagoFcturaVentaXIdFactura(_tipoCon, dgvComprobanteIngresoBanco.Rows(indice).Cells(6).Value) + 1
                            If rbCheque.Checked Then
                                .FormaPagoFactura = "CHEQUE"
                            ElseIf rbEfectivo.Checked Then
                                .FormaPagoFactura = "EFECTIVO"
                            ElseIf rbTarjetaCredido.Checked Then
                                .FormaPagoFactura = "TARJETA DE CREDITO"
                            ElseIf rbTransaccion.Checked Then
                                .FormaPagoFactura = "TRANSACCION"
                            ElseIf rbNotaCredito.Checked Then
                                .FormaPagoFactura = "NOTA DE CREDITO"
                            Else
                                .FormaPagoFactura = "EFECTIVO"
                            End If
                            .MontoPagoFactura = dgvComprobanteIngresoBanco.Rows(indice).Cells(5).Value
                            .SaldoPagoFactura = CDec(.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, dgvComprobanteIngresoBanco.Rows(indice).Cells(6).Value)) - CDec(dgvComprobanteIngresoBanco.Rows(indice).Cells(5).Value)
                            .EstadoPagoFactura = 1
                            .IdFactura = dgvComprobanteIngresoBanco.Rows(indice).Cells(6).Value
                            .IdCliente = _objetoFacturaVenta.BuscarIdClienteXIdFacturaVenta(_tipoCon, dgvComprobanteIngresoBanco.Rows(indice).Cells(6).Value)
                            .IdComprobanteIngreso = _objetoComprobanteIngresoBancos.Id
                        End With
                        _dataPagos.Add(idc, _objetoPagosFacturaVenta.NumeroPagoFactura & "-" & _objetoPagosFacturaVenta.SaldoPagoFactura)
                    End If

                    _sqlCommands.Add(_objetoPagosFacturaVenta.NuevoRegistroPagosFacturaVenta)
                    ip += 1
                End If
            Next
        End Sub
        Private Sub ActualizarMontoCuentaBancos()
            With _objetoCuentaBancos
                .IdCuentaBancos = CInt(cmbCuentaBancos.SelectedValue)
                .NumeroCuentaBancos = cmbCuentaBancos.SelectedValue
                .MontoCuentaBancos = CDec(lblValorCuentaBanco.Text)
            End With
            _sqlCommands.Add(_objetoCuentaBancos.ActualizarSumarMontoCuentasBancos)
        End Sub
        Private Sub NuevoRegistroAsientoDiarioComprobanteIngresoBancos()
            Dim numeroFactura As String
            Dim il = _objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1
            For indice = 0 To dgvComprobanteIngresoBanco.RowCount - 1
                With _objetoAsientoLibroDiario
                    .IdAsiento = il
                    .FechaAsiento = dtpFechaEmisionComprobanteIngreso.Value
                    .CodigoCuentaAsiento = dgvComprobanteIngresoBanco.Rows(indice).Cells(0).Value.ToString.Trim
                    .NombreCuentaAsiento = dgvComprobanteIngresoBanco.Rows(indice).Cells(1).Value.ToString.Trim
                    .ConceptoAsiento = dgvComprobanteIngresoBanco.Rows(indice).Cells(2).Value
                    If dgvComprobanteIngresoBanco.Rows(indice).Cells(6).Value <> 0 Then 'si es factura obtiene el numero para registrarlo
                        numeroFactura = _objetoFacturaVenta.BuscarNumeroFacturaVentaXIdFacturaVenta(_tipoCon, dgvComprobanteIngresoBanco.Rows(indice).Cells(6).Value)
                    Else
                        numeroFactura = txtFacturasAPagar.Text
                    End If
                    ' se detalla la transacción según la forma de pago
                    If rbCheque.Checked Then
                        .DetalleTransaccionAsiento = "ID CI: " + _objetoComprobanteIngresoBancos.Id.ToString + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA(S) NRO: " + numeroFactura.ToString + " ACREDITADO A: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: CHEQUE BANCO " + txtBancoCheque.Text + " NRO " + txtNumeroCheque.Text
                    ElseIf rbEfectivo.Checked Then
                        .DetalleTransaccionAsiento = "ID CI: " + _objetoComprobanteIngresoBancos.Id.ToString + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA(S) NRO: " + numeroFactura.ToString + " ACREDITADO A: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: EFECTIVO"
                    ElseIf rbTarjetaCredido.Checked Then
                        .DetalleTransaccionAsiento = "ID CI: " + _objetoComprobanteIngresoBancos.Id.ToString + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA(S) NRO: " + numeroFactura.ToString + " ACREDITADO A: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: TARJETA DE CRÉDITO"
                    ElseIf rbTransaccion.Checked Then
                        .DetalleTransaccionAsiento = "ID CI: " + _objetoComprobanteIngresoBancos.Id.ToString + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA(S) NRO: " + numeroFactura.ToString + " ACREDITADO A: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: TRANSACCIÓN"
                    ElseIf rbNotaCredito.Checked Then
                        .DetalleTransaccionAsiento = "ID CI: " + _objetoComprobanteIngresoBancos.Id.ToString + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA(S) NRO: " + numeroFactura.ToString + " ACREDITADO A: " + cmbBancos.SelectedValue.ToString + " CTA: " + cmbCuentaBancos.SelectedValue.ToString + " FORMA PAGO: TRANSACCIÓN"
                    End If
                    .ProvinciaAsiento = "EL ORO"
                    .CiudadAsiento = "MACHALA"
                    .ParroquiaAsiento = "MACHALA"
                    .CentroCostoAsiento = cmbCentroCosto.Text
                    .ValorDebeAsiento = dgvComprobanteIngresoBanco.Rows(indice).Cells(4).Value
                    .ValorHaberAsiento = dgvComprobanteIngresoBanco.Rows(indice).Cells(5).Value
                    .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                    If dgvComprobanteIngresoBanco.Rows(indice).Cells(4).Value > dgvComprobanteIngresoBanco.Rows(indice).Cells(5).Value Then
                        .DebeHaberAsiento = 1   ' DEBE=1 / HABER=2 
                    ElseIf dgvComprobanteIngresoBanco.Rows(indice).Cells(4).Value < dgvComprobanteIngresoBanco.Rows(indice).Cells(5).Value Then
                        .DebeHaberAsiento = 2   ' DEBE=1 / HABER=2 
                    End If
                    .ConciliarAsiento = 1
                    .EstadoAsiento = 1
                    .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                    .EstadoMayorAsiento = 0
                End With
                _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                il += 1
            Next
        End Sub
        Private Sub GuardarNumeroRegistroAsientoComprobanteIngreso() 'Tabla intermedia para enlazar en el diario los Comprobantes de ingreso
            With _objetoNumeroRegistroAsientoComprobanteIngreso
                .IdComprobanteIngreso = _objetoComprobanteIngresoBancos.Id
                .IdLibro = _objetoLibroDiario.IdLibroDiario
                .IdAsiento = _objetoAsientoLibroDiario.IdAsiento
                .NumeroRegistro = _objetoNumeroRegistro.NumeroRegistro
            End With
            _sqlCommands.Add(_objetoNumeroRegistroAsientoComprobanteIngreso.NuevoRegistroNumeroRegistroAsientoComprobanteIngreso)
        End Sub
        Private Sub GuardarRegistroChequesRecibidos()
            With _objetoChequesRecibidos
                .IdCheque = .BuscarMayorIdChequeRecibidoCxc(_tipoCon) + 1
                .FechaEmision = dtpFechaEmisionCheque.Value
                .Titular = txtTitularCheque.Text
                .Banco = txtBancoCheque.Text
                .CtaCteCheque = txtCtaCteCheque.Text
                .NumeroCheque = txtNumeroCheque.Text
                .Valor = lblValorCuentaBanco.Text
                .Estado = 1
                .IdComprobanteIngreso = _objetoComprobanteIngresoBancos.Id
                .IdClienteGeneral = lblIdClienteGeneral.Text
            End With
            _sqlCommands.Add(_objetoChequesRecibidos.NuevoRegistroChequeRecibidoCxc)
        End Sub

        Private Sub KryptonLabel11_Paint(sender As Object, e As PaintEventArgs) Handles KryptonLabel11.Paint

        End Sub

        Private Sub rbCheque_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbCheque.CheckedChanged, RadioButton5.CheckedChanged
            If rbCheque.Checked Then
                If txtNombreComercialClienteGeneral.Text <> "" And lblIdClienteGeneral.Text <> "..." Then
                    gbCheque.Enabled = True
                    txtTitularCheque.Text = txtNombreComercialClienteGeneral.Text
                Else

                    KryptonMessageBox.Show("Primero cargue un cliente", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    rbEfectivo.Checked = True
                End If
            Else
                gbCheque.Enabled = False
                txtTitularCheque.Text = ""
            End If
        End Sub
    End Class
End Namespace