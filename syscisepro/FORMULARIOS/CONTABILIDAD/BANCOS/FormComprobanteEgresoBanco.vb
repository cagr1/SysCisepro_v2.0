Imports System.Data.SqlClient
Imports System.Drawing 
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports Krypton.Toolkit
Imports syscisepro.FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormComprobanteEgresoBanco

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

        Dim _dataPagos As Dictionary(Of String, String)
        Public IdUsuario As Integer
        Public UserName As String
        Private _existeNumero As Boolean

        ReadOnly _objetoComprobanteEgresoBancos As New ClassComprobanteEgresoBanco
        ReadOnly _objetoCentroCosto As New ClassCentroCosto
        ReadOnly _objetoBancos As New ClassBancos
        ReadOnly _objetoCuentaBancos As New ClassCuentasBancos
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoComprobanteIngresoBancos As New ClassComprobanteIngresoBanco
        ReadOnly _objetoNumeroRegistroAsientoComprobanteIngreso As New ClassNumeroRegistroAsientoComprobanteIngreso
        ReadOnly _objetoLibroDiario As New ClassLibroDiario
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoNumeroRegistro As New ClassNumeroRegistroAsiento
        ReadOnly _objetoNumeroRegistroAsientoComprobanteEgreso As New ClassNumeroRegistroAsientoComprobanteEgreso
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objetoChequeEmitido As New ClassChequesEmitidosCxp
        ReadOnly _objetoProveedorGeneral As New ClassProveedores
        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoPagosComprobantesCompra As New ClassPagosComprobantesCompra
        ReadOnly _objetoCompEgresoPagosCompCompra As New ClassCompEgresoPagosCompCompra
        ReadOnly _validacionesNumeros As New ClassNumerico
        ReadOnly _validacionesDecimales As New ClassDecimal

        Dim _valorFinalCheque As Decimal = 0

        Dim _numerosFacturas() As String
        Dim _cantidadFacturas As Integer
        Dim _nroFilasEgreso = 0

        Private Sub FormComprobanteEgresoBanco_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava  
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteEgresoBanco.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvPagosComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobanteEgresoBanco.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvPagosComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobanteEgresoBanco.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvPagosComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvComprobantesCompra.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprobanteEgresoBanco.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvPagosComprobantesCompra.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            _dataPagos = New Dictionary(Of String, String)

            CargarGrillaComprobanteEgresoBancos()
            LlenarCuentasContables()
            LlenarComboCentroCosto()
            LlenarComboBancos()
            DeshabilitadoInicio()

            AutocompletarNombreProveedor()

            dgvComprobanteEgresoBanco.ContextMenuStrip = ContextMenuStripClicDerecho 'Asigno a la propiedad contextMenuStrip del dgv el menu creado para el clic derecho
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
        Private Sub CargarGrillaComprobanteEgresoBancos()
            dgvComprobanteEgresoBanco.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvComprobanteEgresoBanco.Columns("CUENTA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvComprobanteEgresoBanco.Columns("CONCEPTO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvComprobanteEgresoBanco.Columns("DETALLE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvComprobanteEgresoBanco.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvComprobanteEgresoBanco.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvComprobanteEgresoBanco.Columns("ID_CC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft

            dgvComprobanteEgresoBanco.Columns("CODIGO").ReadOnly = True
            dgvComprobanteEgresoBanco.Columns("CUENTA").ReadOnly = True
            dgvComprobanteEgresoBanco.Columns("CONCEPTO").ReadOnly = True
            dgvComprobanteEgresoBanco.Columns("DETALLE").ReadOnly = True
            dgvComprobanteEgresoBanco.Columns("DEBE").ReadOnly = True
            dgvComprobanteEgresoBanco.Columns("HABER").ReadOnly = True
            dgvComprobanteEgresoBanco.Columns("ID_CC").ReadOnly = True
        End Sub
        Private Sub DeshabilitadoInicio()
            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
            btnReporte.Enabled = False

            btnBuscarPersonal.Enabled = False
            btnAgregarConceptoComprobante.Enabled = False
            btnAgregarBancosComprobante.Enabled = False
            btnEditarValores.Enabled = False
            txtNumeroComprobanteEgresoBanco.Enabled = False
            dtpFechaComprobanteEgreso.Enabled = False
            txtFacturaReceptor.Enabled = False
            txtRucCi.Enabled = False
            txtPagadoA.Enabled = False
            txtActividad.Enabled = False
            txtConceptoComprobanteEgreso.Enabled = False
            cmbCuentasContables.Enabled = False
            chkTransferenciaInterna.Enabled = False

            dgvComprobanteEgresoBanco.Columns("DEBE").ReadOnly = True
            dgvComprobanteEgresoBanco.Columns("HABER").ReadOnly = True

            cmbCentroCosto.Enabled = False
            cmbTipoPago.Enabled = False
            txtRazonComprobanteEgresoBanco.Enabled = False
            txtValorComprobanteEgresoBancos.Enabled = False
            cmbBancos.Enabled = False
            cmbCuentaBancos.Enabled = False
            txtNumeroCheque.Enabled = False
            txtTotalDebe.Enabled = False
            txtTotalHaber.Enabled = False
            'gbProveedor.Enabled = False
            txtNombreComercialProveedor.Enabled = False
        End Sub
        Private Sub AutocompletarNombreProveedor()
            Try
                Dim data = _objetoProveedorGeneral.Autocompletar(_tipoCon)
                txtNombreComercialProveedor.AutoCompleteCustomSource = data
                txtNombreComercialProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                txtNombreComercialProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource




                txtPagadoA.AutoCompleteCustomSource = data
                txtPagadoA.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                txtPagadoA.AutoCompleteSource = AutoCompleteSource.CustomSource

            Catch
                txtNombreComercialProveedor.AutoCompleteCustomSource = Nothing
                txtPagadoA.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub btnNuevoComprobanteEgresoBancos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            HabilitadoNuevo()
            LimpiarParametros()
            txtFacturaReceptor.Text = "0"

            LlenarComboCentroCosto()
            LlenarComboBancos()
            LlenarComboCuentasBancos()

            'se redimenciona el array vaciandolo y encerando la cantidad de facturas
            _cantidadFacturas = 0
            ReDim _numerosFacturas(_cantidadFacturas)
        End Sub
        Private Sub HabilitadoNuevo()
            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            btnReporte.Enabled = False

            btnBuscarPersonal.Enabled = True
            btnAgregarConceptoComprobante.Enabled = True
            btnAgregarBancosComprobante.Enabled = True

            dtpFechaComprobanteEgreso.Enabled = True
            txtFacturaReceptor.Enabled = True
            txtRucCi.Enabled = True
            txtPagadoA.Enabled = True
            txtActividad.Enabled = False
            txtConceptoComprobanteEgreso.Enabled = True
            cmbCuentasContables.Enabled = True
            chkTransferenciaInterna.Enabled = True

            cmbCentroCosto.Enabled = True
            cmbTipoPago.Enabled = True
            txtRazonComprobanteEgresoBanco.Enabled = True
            txtValorComprobanteEgresoBancos.Enabled = True
            cmbBancos.Enabled = True
            cmbCuentaBancos.Enabled = True
            txtNumeroCheque.Enabled = True
            'gbProveedor.Enabled = True

            txtNombreComercialProveedor.Enabled = False
        End Sub
        Private Sub LimpiarParametros()
            Try
                dgvComprobantesCompra.DataSource = Nothing
                dgvPagosComprobantesCompra.DataSource = Nothing
                dgvComprobanteEgresoBanco.Rows.Clear()
                dgvCompEgresoPagosCompCompra.Rows.Clear()
                lblIdComprobanteEgresoBancos.Text = "..."
                txtNumeroComprobanteEgresoBanco.Text = ""

                txtFacturaReceptor.Text = ""
                txtRucCi.Text = ""
                txtPagadoA.Text = ""
                txtActividad.Text = "1010102"
                txtConceptoComprobanteEgreso.Text = ""

                txtRazonComprobanteEgresoBanco.Text = ""
                txtValorComprobanteEgresoBancos.Text = "0.00"

                txtNumeroCheque.Text = ""
                txtTotalDebe.Text = "0.00"
                txtTotalHaber.Text = "0.00"
                chkActivar.CheckState = CheckState.Unchecked
                chkTransferenciaInterna.CheckState = CheckState.Unchecked
                txtPagadoA.Tag = Nothing
                txtNombreComercialProveedor.Text = ""

                cmbCentroCosto.SelectedIndex = 0
                cmbTipoPago.SelectedIndex = 0
                cmbBancos.SelectedIndex = 0
                cmbCuentaBancos.SelectedIndex = 0
            Catch ex As Exception

                KryptonMessageBox.Show("Error: " & ex.Message.ToString, "MENSAJE DE ERROR", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub chkTransferenciaInterna_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkTransferenciaInterna.CheckedChanged
            txtConceptoComprobanteEgreso.Text = If(chkTransferenciaInterna.Checked, "TRANSFERENCIA INTERNA", String.Empty)
        End Sub
        Private Sub btnAgregarConceptoComprobante_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarConceptoComprobante.Click
            If txtRazonComprobanteEgresoBanco.Text <> "" Then
                AgregarConceptosComprobanteEgreso()
                SumarTotalDebeHaber()
            Else

                KryptonMessageBox.Show("Por favor ingrese una razón de pago", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                txtRazonComprobanteEgresoBanco.Focus()
            End If
        End Sub
        Private Sub AgregarConceptosComprobanteEgreso()

            Dim respuesta = InputBox("Ingrese el valor del comprobante", "Valor comprobante", txtValorComprobanteEgresoBancos.Text)
            If respuesta.Trim().Length = 0 Then Return

            If IsNumeric(respuesta) Then

                dgvComprobanteEgresoBanco.Rows.Add()

                txtValorComprobanteEgresoBancos.Text = CDec(respuesta)

                dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(0).Value = cmbCuentasContables.SelectedValue
                dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(1).Value = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, cmbCuentasContables.SelectedValue)
                dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(2).Value = "COMPROBANTE DE EGRESO"
                dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(3).Value = txtRazonComprobanteEgresoBanco.Text
                dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(4).Value = txtValorComprobanteEgresoBancos.Text
                dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(5).Value = "0.00"
                dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(6).Value = "0"
            Else

                KryptonMessageBox.Show("Por favor ingrese solo números" & vbNewLine & "El separador decimal es el '.'", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End If
        End Sub
        Private Sub SumarTotalDebeHaber()
            Dim totalDebe = 0.0
            Dim totalHaber = 0.0
            _valorFinalCheque = 0
            Try
                For indice = 0 To dgvComprobanteEgresoBanco.RowCount - 1
                    totalDebe += CDec(dgvComprobanteEgresoBanco.Rows(indice).Cells(4).Value)
                    totalHaber += CDec(dgvComprobanteEgresoBanco.Rows(indice).Cells(5).Value)
                    If dgvComprobanteEgresoBanco.Rows(indice).Cells(0).Value = "10101020101" Or dgvComprobanteEgresoBanco.Rows(indice).Cells(0).Value = "10101020201" _
                       Or dgvComprobanteEgresoBanco.Rows(indice).Cells(0).Value = "10101020301" Or dgvComprobanteEgresoBanco.Rows(indice).Cells(0).Value = "10101020401" _
                       Or dgvComprobanteEgresoBanco.Rows(indice).Cells(0).Value = "10101020501" Or dgvComprobanteEgresoBanco.Rows(indice).Cells(0).Value = "10101020601" _
                       Or dgvComprobanteEgresoBanco.Rows(indice).Cells(0).Value = "10101020602" Then
                        _valorFinalCheque += CDec(dgvComprobanteEgresoBanco.Rows(indice).Cells(5).Value)
                    End If
                Next
                If _valorFinalCheque = 0 Then _valorFinalCheque = totalDebe
            Catch
                totalDebe = 0
                totalHaber = 0
                _valorFinalCheque = 0
            End Try
            txtValorComprobanteEgresoBancos.Text = totalDebe
            txtTotalDebe.Text = totalDebe
            txtTotalHaber.Text = totalHaber
        End Sub
        Private Sub btnBuscarPersonal_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarPersonal.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.TipoCox = TipoCox
            frm.IsOperaciones = True
            frm.IsAdmin = False
            frm.Todos = True
            frm.rbtProveedor.Visible = False
            frm.rbtPersonal.Checked = True
            frm.rbtCliente.Visible = False
            frm.txtParametrobusqueda.Width = frm.txtParametrobusqueda.Width + frm.rbtProveedor.Width + frm.rbtPersonal.Width
            frm.rbtPersonal.Location = New Point(frm.txtParametrobusqueda.Width + frm.Label1.Width + 10, 4)
            Try
                If frm.ShowDialog = vbOK Then
                    If frm.rbtPersonal.Checked Then
                        txtPagadoA.Tag = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        txtRucCi.Text = frm.dgvCustodios.CurrentRow.Cells.Item(3).Value
                        txtPagadoA.Text = frm.dgvCustodios.CurrentRow.Cells.Item(4).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(5).Value
                    End If
                End If
            Catch ex As Exception

                KryptonMessageBox.Show("Error: " & ex.Message.ToString, "MENSAJE DE ERROR", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub btnAgregarBancosComprobante_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarBancosComprobante.Click
            If _existeNumero Then

                KryptonMessageBox.Show("El número de cheque emitido ya se encuentra registrado en la bd.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Return
            End If

            Try

                If dgvComprobanteEgresoBanco.RowCount > 0 Then
                    If txtNumeroCheque.Text <> "" Then

                        Dim respuesta = InputBox("Ingrese el valor del comprobante", "VALOR BANCO", txtTotalDebe.Text)
                        If IsNumeric(respuesta) Then
                            dgvComprobanteEgresoBanco.Rows.Add()

                            Dim cp = _objetoCuentaBancos.BuscarCodigoPlanXIdCuenta(_tipoCon, CInt(cmbCuentaBancos.SelectedValue))

                            dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(0).Value = cp.Trim
                            dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(1).Value = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, cp).Trim
                            dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(2).Value = "COMPROBANTE DE EGRESO BANCOS"
                            If chkActivar.Checked Then
                                dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(3).Value = "PAGO A PROVEEDORES " + txtFacturaReceptor.Text
                            Else
                                dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(3).Value = txtRazonComprobanteEgresoBanco.Text
                            End If
                            dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(4).Value = "0.00"
                            dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(5).Value = CDec(respuesta)
                            dgvComprobanteEgresoBanco.Rows(dgvComprobanteEgresoBanco.RowCount - 1).Cells(6).Value = "0"

                            SumarTotalDebeHaber()

                            If cmbTipoPago.Text = "CHEQUE" Then
                                If txtValorComprobanteEgresoBancos.Text <> _valorFinalCheque Then txtValorComprobanteEgresoBancos.Text = _valorFinalCheque
                            End If
                        Else
                            KryptonMessageBox.Show("Por favor ingrese solo números" & vbNewLine & "EL SEPARADOR DECIMAL ES EL '.'", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                        End If

                        btnEditarValores.Enabled = True
                    Else
                        KryptonMessageBox.Show("Seleccione un banco, cuenta e ingrese un número de cheque", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    End If
                Else
                    KryptonMessageBox.Show("Primero cargue un concepto de egreso", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                End If
            Catch ex As Exception
                KryptonMessageBox.Show("Cargar comprobante egreso: bancos" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            End Try
        End Sub
        Private Sub btnEditarValores_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEditarValores.Click
            If dgvComprobanteEgresoBanco.RowCount > 0 Then
                dgvComprobanteEgresoBanco.Columns("DEBE").ReadOnly = False
                dgvComprobanteEgresoBanco.Columns("HABER").ReadOnly = False
                dgvComprobanteEgresoBanco.Rows(0).Cells(4).Selected = True
            End If
        End Sub
        Private Sub btnCancelarComprobanteEgresoBancos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            DeshabilitadoInicio()
            LimpiarParametros()
        End Sub
        Private Sub txtRucCi_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtRucCi.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtValorComprobanteEgresoBancos_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtValorComprobanteEgresoBancos.KeyPress
            e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar, txtValorComprobanteEgresoBancos.Text)
        End Sub
        Private Sub txtNumeroCheque_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNumeroCheque.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtNombreComercialProveedor_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialProveedor.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Try
                lblIdProveedorGeneral.Text = _objetoProveedorGeneral.BuscarIdProveedorXNombreComercialProveedor(_tipoCon, txtNombreComercialProveedor.Text.Trim())
                txtPagadoA.Text = txtNombreComercialProveedor.Text.Trim()
            Catch
                lblIdProveedorGeneral.Text = "..."
                txtPagadoA.Clear()
            End Try

            CargarDatosProveedor()
            CargarComprobantesCompra()
        End Sub
        Private Sub CargarDatosProveedor()
            Try
                Dim pro = _objetoProveedorGeneral.BuscarProveedorGeneralXNombre(_tipoCon, txtNombreComercialProveedor.Text)
                If pro.Rows.Count = 0 Then Return
                lblIdProveedorGeneral.Text = pro.Rows(0)(0)
                txtRucCi.Text = pro.Rows(0)(2)
            Catch ex As Exception
                KryptonMessageBox.Show("Cargar datos proveedor." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End Try
        End Sub
        Private Sub CargarComprobantesCompra()
            Try
                Dim data = _objetoComprobantesCompra.SeleccionarComrpobantesCompraImpagosXIdProveedor(_tipoCon, lblIdProveedorGeneral.Text)

                dgvComprobantesCompra.DataSource = data
                For Each c As DataGridViewColumn In dgvComprobantesCompra.Columns
                    c.ReadOnly = True
                Next
                dgvComprobantesCompra.Columns(0).ReadOnly = False
            Catch ex As Exception
                dgvComprobantesCompra.DataSource = Nothing
                KryptonMessageBox.Show("Metodo cargar comprobantes de compra" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End Try
        End Sub
        Private Sub chkActivar_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkActivar.CheckedChanged
            If cmbCuentasContables.SelectedValue <> 0 Then
                If chkActivar.Checked Then
                    txtNombreComercialProveedor.Enabled = True
                    'gbComprobantesCompra.Enabled = True
                    dgvComprobanteEgresoBanco.Enabled = True
                    'gbPagosComprobanteCompra.Enabled = True
                    dgvPagosComprobantesCompra.Enabled = True
                    txtConceptoComprobanteEgreso.Text = "PAGO A PROVEEDOR"
                Else
                    'gbComprobantesCompra.Enabled = False
                    dgvPagosComprobantesCompra.Enabled = False
                    'gbPagosComprobanteCompra.Enabled = False
                    dgvPagosComprobantesCompra.Enabled = False
                    txtConceptoComprobanteEgreso.Text = ""
                End If
            Else
                chkActivar.Checked = False
                'gbComprobantesCompra.Enabled = False
                'gbPagosComprobanteCompra.Enabled = False
                KryptonMessageBox.Show("Por favor primero escoja una cta. contable", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End If
        End Sub
        Private Sub txtPagadoA_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtPagadoA.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Try
                lblIdProveedorGeneral.Text = _objetoProveedorGeneral.BuscarIdProveedorXNombreComercialProveedor(_tipoCon, txtNombreComercialProveedor.Text.Trim())
                txtNombreComercialProveedor.Enabled = False
                txtPagadoA.Enabled = False
                txtRucCi.Enabled = False
            Catch
                lblIdProveedorGeneral.Text = "..."
            End Try

            CargarDatosProveedor()
            CargarComprobantesCompra()
        End Sub


        Private Sub dgvComprobanteEgresoBanco_CellValidated(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvComprobanteEgresoBanco.CellValidated
            SumarTotalDebeHaber()
        End Sub
        Private Sub dgvComprobanteEgresoBanco_EditingControlShowing(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvComprobanteEgresoBanco.EditingControlShowing
            Dim itemType = TryCast(e.Control, TextBox)
            If itemType IsNot Nothing Then AddHandler itemType.KeyPress, AddressOf ItemType_KeyPress
        End Sub
        Private Sub ItemType_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles dgvComprobanteEgresoBanco.KeyPress
            Select Case dgvComprobanteEgresoBanco.CurrentCell.ColumnIndex
                Case 0
                    e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
                Case 4
                    e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
                Case 5
                    e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
            End Select
        End Sub
        Private Sub ToolStripMenuItemEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItemEliminar.Click
            Try
                Dim lSeleccionados As DataGridViewSelectedRowCollection = dgvComprobanteEgresoBanco.SelectedRows
                Select Case lSeleccionados.Count
                    Case 0
                        'MessageBox.Show("Debe seleccionar alguna fila", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        KryptonMessageBox.Show("Debe seleccionar alguna fila", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                        Return
                    Case Is > 1
                        'MessageBox.Show("Demasiadas filas seleccionadas", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        KryptonMessageBox.Show("Demasiadas filas seleccionadas", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                        Return
                End Select

                Dim loFila As DataGridViewRow = dgvComprobanteEgresoBanco.CurrentRow()
                If KryptonMessageBox.Show("¿Esta seguro de querer eliminar este Registro" & vbCrLf & loFila.Cells(2).Value.ToString(), "", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return


                dgvComprobanteEgresoBanco.Rows.RemoveAt(dgvComprobanteEgresoBanco.CurrentRow.Index)
                SumarTotalDebeHaber()
            Catch ex As Exception
                'MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                KryptonMessageBox.Show("Error: " & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End Try
        End Sub
        Private Sub cmbTipoPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbTipoPago.SelectedIndexChanged
            If cmbTipoPago.Text = "NOTA DE CREDITO" Or cmbTipoPago.Text = "NOTA DE DEBITO" Or cmbTipoPago.Text = "CREDITO A CUENTA" Then
                txtNumeroCheque.Enabled = False
                txtNumeroCheque.Text = 0
            Else
                txtNumeroCheque.Enabled = True
            End If
        End Sub
        Private Sub CargarPagosComprobantesCompra()
            Try
                dgvPagosComprobantesCompra.DataSource = _objetoPagosComprobantesCompra.SeleccionarPagosComrpobantesCompraXIdComprobante(_tipoCon, lblIdComprobanteCompra.Text)
                dgvPagosComprobantesCompra.Columns(0).HeaderText = "ID"
                dgvPagosComprobantesCompra.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.Columns(1).HeaderText = "FECHA"
                dgvPagosComprobantesCompra.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.Columns(2).HeaderText = "NRO P"
                dgvPagosComprobantesCompra.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.Columns(3).HeaderText = "MONTO"
                dgvPagosComprobantesCompra.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.Columns(4).HeaderText = "SALDO"
                dgvPagosComprobantesCompra.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.Columns(5).HeaderText = "EST"
                dgvPagosComprobantesCompra.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.Columns(6).HeaderText = "ID CC"
                dgvPagosComprobantesCompra.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.AutoResizeColumns()
                dgvPagosComprobantesCompra.AutoResizeRows()
                dgvPagosComprobantesCompra.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                KryptonMessageBox.Show("Metodo cargar pagos comprobantes de compra" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End Try
        End Sub
        Private Sub dgvComprobantesCompra_CellContentClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvComprobantesCompra.CellContentClick
            If dgvComprobantesCompra.RowCount = 0 Then Return
            If e.ColumnIndex = chk.Index Then
                If CBool(dgvComprobantesCompra.CurrentCell.EditedFormattedValue) Then ' CheckBox Marcado
                    Dim n = _objetoPagosComprobantesCompra.BuscarMayorSaldoPagosComprobantesCompraXIdComprobante(_tipoCon, dgvComprobantesCompra.CurrentRow.Cells(1).Value)

                    If n <> 0 Then
                        _numerosFacturas(_cantidadFacturas) = dgvComprobantesCompra.CurrentRow.Cells(3).Value
                        Dim cadena = ""
                        For indiceArray = 0 To _cantidadFacturas ' carga los numeros de los comprobantes seleccionados
                            cadena = cadena + "FACT: " + _numerosFacturas(indiceArray) + "; "
                        Next
                        _cantidadFacturas += 1 ' aumenta el numero de comprobantes seleccionados
                        ReDim Preserve _numerosFacturas(_cantidadFacturas) ' redimensiona el array a la cantidad de documentos actual

                        '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= CARGA LAS FACTURAS A PAGAR COMPROBANTE DE EGRESO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                        txtFacturaReceptor.Text = cadena
                        '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= CARGA EL DIARIO DEL COMPROBANTE DE EGRESO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                        dgvComprobanteEgresoBanco.Rows.Add()
                        _nroFilasEgreso = dgvComprobanteEgresoBanco.Rows.Count - 1
                        dgvComprobanteEgresoBanco.Rows(_nroFilasEgreso).Cells(0).Value = "2010301"
                        dgvComprobanteEgresoBanco.Rows(_nroFilasEgreso).Cells(1).Value = "LOCALES"
                        dgvComprobanteEgresoBanco.Rows(_nroFilasEgreso).Cells(2).Value = "PAGO A PROVEEDOR"
                        dgvComprobanteEgresoBanco.Rows(_nroFilasEgreso).Cells(3).Value = "PAGO A: " + txtNombreComercialProveedor.Text + " FACT: " + dgvComprobantesCompra.CurrentRow.Cells(3).Value.ToString
                        dgvComprobanteEgresoBanco.Rows(_nroFilasEgreso).Cells(4).Value = n
                        dgvComprobanteEgresoBanco.Rows(_nroFilasEgreso).Cells(5).Value = "0.00"
                        dgvComprobanteEgresoBanco.Rows(_nroFilasEgreso).Cells(6).Value = dgvComprobantesCompra.CurrentRow.Cells(1).Value.ToString
                    Else
                        KryptonMessageBox.Show("Esta factura ya fue cancelada", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    End If
                Else
                    For indiceArray = 0 To _cantidadFacturas - 1
                        If _numerosFacturas(indiceArray) = dgvComprobantesCompra.CurrentRow.Cells(4).Value.ToString Then _numerosFacturas(indiceArray) = ""
                    Next
                    For indiceArray = 0 To _cantidadFacturas - 1
                        If indiceArray <> _cantidadFacturas - 1 Then
                            If _numerosFacturas(indiceArray) = "" And _numerosFacturas(indiceArray + 1) <> "" Then
                                _numerosFacturas(indiceArray) = _numerosFacturas(indiceArray + 1)
                                _numerosFacturas(indiceArray + 1) = ""
                            End If
                        End If
                    Next
                    _cantidadFacturas -= 1
                    ReDim Preserve _numerosFacturas(_cantidadFacturas)

                    Dim cadena = ""
                    For indiceArray = 0 To _cantidadFacturas - 1
                        cadena = cadena + _numerosFacturas(indiceArray) + " - "
                    Next
                    txtFacturaReceptor.Text = cadena
                    For indiceCompEgreso = 0 To dgvComprobanteEgresoBanco.Rows.Count - 1
                        If dgvComprobanteEgresoBanco.Rows(indiceCompEgreso).Cells(6).Value = dgvComprobantesCompra.CurrentRow.Cells(1).Value.ToString Then
                            dgvComprobanteEgresoBanco.Rows.RemoveAt(dgvComprobanteEgresoBanco.Rows(indiceCompEgreso).Index)
                            Exit For
                        End If
                    Next
                End If
                SumarTotalDebeHaber()
            End If
        End Sub
        Private Sub btnReporteComprobanteEgresoBancos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            If CInt(lblIdComprobanteEgresoBancos.Text) <> 0 Then
                If CInt(cmbBancos.SelectedValue) = 1 And _tipoCon = TipoConexion.Cisepro Then
                    Dim f = New FormReporteComprobanteEgresoBancoMachala
                    f.TipoCox = TipoCox
                    f.lblIdComprobanteEgreso.Text = CInt(lblIdComprobanteEgresoBancos.Text)
                    f.ShowDialog()
                Else
                    Dim f = New FormReporteComprobanteEgresoBancos
                    f.TipoCox = TipoCox
                    f.lblIdComprobanteEgreso.Text = CInt(lblIdComprobanteEgresoBancos.Text)
                    f.ShowDialog()
                End If
            Else

                KryptonMessageBox.Show("Por favor seleccione un comprobante de egreso", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Function ValidarFecha()
            Dim fechaIngresada = New Date(dtpFechaComprobanteEgreso.Value.Year, dtpFechaComprobanteEgreso.Value.Month, dtpFechaComprobanteEgreso.Value.Day)
            Dim fechaMinimaIngreso = New Date(Date.Now.Year, 1, 1)
            If fechaMinimaIngreso > fechaIngresada Then

                KryptonMessageBox.Show("Esta ingresando comprobantes del año " + dtpFechaComprobanteEgreso.Value.Year.ToString + ". Por favor asegúrese de que la información sea correcta y no afecte el balance!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return True
            Else
                Return True
            End If
        End Function
        Private Function ValidacionParametros() As Boolean
            Return txtFacturaReceptor.Text <> "" And txtRucCi.Text <> "" And txtPagadoA.Text <> "" And txtActividad.Text <> "" And txtConceptoComprobanteEgreso.Text <> "" And txtRazonComprobanteEgresoBanco.Text <> "" And txtValorComprobanteEgresoBancos.Text <> "" _
               And txtNumeroCheque.Text <> "" And txtTotalDebe.Text <> "" And txtTotalHaber.Text <> ""
        End Function
        Private Sub btnGuardarComprobanteEgresoBancos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If ValidarFecha() Then
                If ValidacionParametros() Then
                    If txtTotalDebe.Text = txtTotalHaber.Text Then

                        If KryptonMessageBox.Show("¿Esta segura que desea guardar el comprobante?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                        _sqlCommands.Clear()

                        _objetoComprobanteEgresoBancos.Id = _objetoComprobanteEgresoBancos.BuscarMayorIdComprobanteEgresoBancos(_tipoCon) + 1
                        _objetoComprobanteEgresoBancos.NumeroComprobante = _objetoComprobanteEgresoBancos.Id

                        _objetoLibroDiario.IdLibroDiario = _objetoLibroDiario.BuscarMayorIdLibroDiario(_tipoCon)

                        With _objetoNumeroRegistro
                            .NumeroRegistro = .BuscarMayorNumeroRegistro(_tipoCon) + 1
                            .NumeroAnterior = .BuscarMayorNumeroAnterior(_tipoCon) + 1
                        End With
                        _sqlCommands.Add(_objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand())

                        ' GUARDA EL COMPROBANTE DE EGRESO
                        GuardarRegistroComprobanteEgresoBancos()

                        ' GUARDA EL CHEQUE EMITIDO
                        If cmbTipoPago.Text = "CHEQUE" Then GuardarRegistroChequeEmitido()

                        ' GUARDA EL PAGO A  COMPROBONATES DE COMPRA A PROVEEDOR EN CASO DE QUE HUBIESE
                        GuardarRegistroPagosComprobanteCompra()

                        ' GUARDA LOS ASIENTOS DEL LIBRO DIARIO
                        NuevoRegistroAsientoDiarioComprobanteEgresoBancos()

                        ' GUARDA LOS LOS REGISTROS PARA ENLAZAR EL COMPROBANTE DE EGRESO CON EL DIARIO
                        GuardarNumeroRegistroAsientoComprobanteEgreso()

                        ' GUARDA LOS REGISTROS EN LA BASE DE DATOS
                        Dim nombreU As String = "Comprobante egreso Banco por " & UserName
                        Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                        If res(0) Then

                            ' DEJA EL FORMULARIO EN SU ESTADO INICIAL
                            DeshabilitadoInicio()

                            lblIdComprobanteEgresoBancos.Text = _objetoComprobanteEgresoBancos.Id
                            btnReporte.Enabled = True
                        End If
                        Dim messageIcon As KryptonMessageBoxIcon
                        If res(0) Then
                            messageIcon = KryptonMessageBoxIcon.Information
                        Else
                            messageIcon = KryptonMessageBoxIcon.Exclamation
                        End If
                        KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, messageIcon)

                    Else

                        KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "Los valores de el debe y el haber no coinciden por favor revise las transacciones.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If
                Else

                    KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "No se han llenado todos los campos necesarios.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                End If
            End If
        End Sub
        Private Sub GuardarRegistroComprobanteEgresoBancos()
            With _objetoComprobanteEgresoBancos
                .FechaComprobante = dtpFechaComprobanteEgreso.Value
                .NumeroFactura = txtFacturaReceptor.Text
                .RucCiReceptor = txtRucCi.Text.ToUpper
                .NombreReceptor = txtPagadoA.Text.ToUpper
                .Actividad = txtActividad.Text.ToUpper
                .Concepto = txtConceptoComprobanteEgreso.Text.ToUpper
                .TipoPago = cmbTipoPago.SelectedItem.ToString
                .Razon = txtRazonComprobanteEgresoBanco.Text.ToUpper
                .Valor = _valorFinalCheque
                .NumeroCheque = txtNumeroCheque.Text
                .Estado = 2
                .IdCentroCosto = CInt(cmbCentroCosto.SelectedValue)
                .IdProvincias = "7"
                .IdCiudad = "58"
                .IdParroquias = "287"
                If cmbTipoPago.SelectedItem = "CREDITO A CUENTA" Then
                    .IdBancos = 0
                    .IdCuentaBanco = 0
                Else
                    .IdBancos = CInt(cmbBancos.SelectedValue)
                    .IdCuentaBanco = CInt(cmbCuentaBancos.SelectedValue)
                End If
            End With
            _sqlCommands.Add(_objetoComprobanteEgresoBancos.NuevoRegistroComprobanteEgresoBancos)

            With _objAuditoria
                .IdAuditoria = CLng(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                .IdUsuarioAuditoria = IdUsuario
                .FormularioAuditoria = Text.ToUpper
                .AccionAuditoria = "CREO UN NUEVO COMPROBANTE DE EGRESO BANCOS Nº:" & _objetoComprobanteEgresoBancos.Id & " CONCEPTO: " & txtConceptoComprobanteEgreso.Text.ToUpper + " PAGADO A: " + txtPagadoA.Text + " NRO CHEQUE: " + txtNumeroCheque.Text + "FECHA CHEQUE: " & dtpFechaComprobanteEgreso.Value + " CONCEPTO: " + txtConceptoComprobanteEgreso.Text.ToUpper
                .EstadoAuditoria = 1
                .FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
            End With
            _sqlCommands.Add(_objAuditoria.NuevaAuditoria)
        End Sub
        Private Sub GuardarRegistroChequeEmitido()
            With _objetoChequeEmitido
                .IdCheque = .BuscarMayorIdChequeEmitidoCxp(_tipoCon) + 1
                .FechaEmisionCheque = dtpFechaComprobanteEgreso.Value
                .BancoCheque = cmbBancos.Text
                .CtaCteCheque = cmbCuentaBancos.Text
                .NumeroCheque = txtNumeroCheque.Text
                .BeneficiarioCheque = txtPagadoA.Text
                .ValorCheque = _valorFinalCheque
                .EstadoCheque = 1 ' 1 = generado ; 2 = aprobado ; 3 = cobrado ; 4 = caducado
                .FechaCobro = "26-10-1984 05:30:00"
                .IdComprobante = _objetoComprobanteEgresoBancos.Id
            End With
            _sqlCommands.Add(_objetoChequeEmitido.NuevoRegistroChequeEmitidoCxp)
        End Sub
        Private Sub GuardarRegistroPagosComprobanteCompra()
            If dgvComprobanteEgresoBanco.Rows.Count > 0 Then
                Dim idc As String
                Dim ip = _objetoPagosComprobantesCompra.BuscarMayorIdPagosComprobantesCompra(_tipoCon) + 1
                _dataPagos.Clear()

                For indice = 0 To dgvComprobanteEgresoBanco.RowCount - 1
                    idc = dgvComprobanteEgresoBanco.Rows(indice).Cells(6).Value.ToString().Trim()
                    If idc <> 0 Then
                        If _dataPagos.ContainsKey(idc) Then
                            Dim vars = _dataPagos(idc).Split("-")
                            Dim n = CInt(vars(0).Trim()) + 1
                            Dim v = CDec(vars(1).Trim()) - CDec(dgvComprobanteEgresoBanco.Rows(indice).Cells(4).Value)

                            With _objetoPagosComprobantesCompra
                                .IdPagosComprobantes = ip
                                .FechaPagosComprobantes = dtpFechaComprobanteEgreso.Value
                                .NumeroPagosComprobantes = n
                                .MontoPagosComprobantes = dgvComprobanteEgresoBanco.Rows(indice).Cells(4).Value
                                .SaldoPagosComprobantes = v
                                .EstadoPagosComprobantes = 1
                                .IdComprobante = idc
                                .IdProveedorGeneral = _objetoComprobantesCompra.BuscarIdProveedorXIdComprobanteCompra(_tipoCon, CLng(idc))
                                .IdComprobanteEgreso = _objetoComprobanteEgresoBancos.Id
                            End With
                            _dataPagos(idc) = n & "-" & v
                        Else
                            With _objetoPagosComprobantesCompra
                                .IdPagosComprobantes = ip
                                .FechaPagosComprobantes = dtpFechaComprobanteEgreso.Value
                                .NumeroPagosComprobantes = .BuscarMayorNumeroPagosComprobantesCompra(_tipoCon, idc) + 1
                                .MontoPagosComprobantes = dgvComprobanteEgresoBanco.Rows(indice).Cells(4).Value
                                .SaldoPagosComprobantes = CDec(.BuscarMayorSaldoPagosComprobantesCompraXIdComprobante(_tipoCon, idc)) - CDec(dgvComprobanteEgresoBanco.Rows(indice).Cells(4).Value)
                                .EstadoPagosComprobantes = 1
                                .IdComprobante = idc
                                .IdProveedorGeneral = _objetoComprobantesCompra.BuscarIdProveedorXIdComprobanteCompra(_tipoCon, CLng(idc))
                                .IdComprobanteEgreso = _objetoComprobanteEgresoBancos.Id
                            End With
                            _dataPagos.Add(idc, _objetoPagosComprobantesCompra.NumeroPagosComprobantes & "-" & _objetoPagosComprobantesCompra.SaldoPagosComprobantes)
                        End If

                        _sqlCommands.Add(_objetoPagosComprobantesCompra.NuevoRegistroPagosComprobantesCompra)

                        With _objetoCompEgresoPagosCompCompra
                            .Id = _objetoPagosComprobantesCompra.IdComprobante
                            .IdComprobanteCompra = dgvComprobanteEgresoBanco.Rows(indice).Cells(6).Value
                            .IdPagosComprobante = ip
                            .MontoPagos = dgvComprobanteEgresoBanco.Rows(indice).Cells(4).Value
                            .NumeroRegistro = _objetoNumeroRegistro.NumeroRegistro
                        End With
                        _sqlCommands.Add(_objetoCompEgresoPagosCompCompra.NuevoRegistroCompEgresoPagosCompCompra)

                        ip += 1
                    End If
                Next
            End If
        End Sub
        Private Sub NuevoRegistroAsientoDiarioComprobanteEgresoBancos()
            Try
                Dim idc As Integer
                Dim idb As Integer

                Dim ia = _objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1
                For indice = 0 To dgvComprobanteEgresoBanco.RowCount - 1
                    With _objetoAsientoLibroDiario
                        .IdAsiento = ia
                        .FechaAsiento = dtpFechaComprobanteEgreso.Value
                        .CodigoCuentaAsiento = dgvComprobanteEgresoBanco.Rows(indice).Cells(0).Value.ToString.Trim
                        .NombreCuentaAsiento = dgvComprobanteEgresoBanco.Rows(indice).Cells(1).Value.ToString.Trim
                        .ConceptoAsiento = dgvComprobanteEgresoBanco.Rows(indice).Cells(2).Value
                        .DetalleTransaccionAsiento = "ID CE: " & _objetoComprobanteEgresoBancos.Id & " " & dgvComprobanteEgresoBanco.Rows(indice).Cells(3).Value.ToString & " BANCO: " & cmbBancos.SelectedValue.ToString & " CTA: " & cmbCuentaBancos.SelectedValue.ToString & " CHEQUE Nº: " & txtNumeroCheque.Text.ToString
                        .ProvinciaAsiento = "EL ORO"
                        .CiudadAsiento = "MACHALA"
                        .ParroquiaAsiento = "MACHALA"
                        .CentroCostoAsiento = cmbCentroCosto.Text
                        .ValorDebeAsiento = dgvComprobanteEgresoBanco.Rows(indice).Cells(4).Value
                        .ValorHaberAsiento = dgvComprobanteEgresoBanco.Rows(indice).Cells(5).Value
                        .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                        If dgvComprobanteEgresoBanco.Rows(indice).Cells(4).Value > dgvComprobanteEgresoBanco.Rows(indice).Cells(5).Value Then
                            .DebeHaberAsiento = 1   ' DEBE=1 / HABER=2 
                        ElseIf dgvComprobanteEgresoBanco.Rows(indice).Cells(4).Value < dgvComprobanteEgresoBanco.Rows(indice).Cells(5).Value Then
                            .DebeHaberAsiento = 2   ' DEBE=1 / HABER=2 
                        End If
                        .ConciliarAsiento = 1
                        .EstadoAsiento = 1
                        .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                        .EstadoMayorAsiento = 0
                    End With
                    _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                    ia += 1

                    ' GUARDA EL COMPROBANTE DE INGRESO EN CASO DE UNA TRANSFERENCIA DE BANCO A BANCO
                    idc = _objetoCuentaBancos.BuscarIdCuentaXCodigoPlan(_tipoCon, _objetoAsientoLibroDiario.CodigoCuentaAsiento.ToString().Trim())
                    If idc > 0 And _objetoAsientoLibroDiario.ValorDebeAsiento > 0 Then
                        idb = _objetoCuentaBancos.BuscarIdBancoXIdCuenta(_tipoCon, idc)

                        With _objetoComprobanteIngresoBancos
                            .Id = .BuscarMayorIdComprobanteIngresoBancos(_tipoCon) + 1
                            .FechaComprobanteIngreso = _objetoComprobanteEgresoBancos.FechaComprobante
                            .NumeroFactura = "0"
                            .IdCliente = If(_tipoCon = TipoConexion.Cisepro, 399, If(_tipoCon = TipoConexion.Seportpac, 610, 0))
                            .ActividadComprobanteIngreso = "1010106"
                            .ConceptoComprobanteIngreso = "CRUCE INTERNO DE CUENTAS"
                            .FormaPagoComprobanteIngreso = "TRANSACCION"
                            .ObservacionesComprobanteIngreso = "REGISTRO INGRESO BANCO (CRUCE INTERNO): " & txtRazonComprobanteEgresoBanco.Text
                            .ValorComprobanteIngreso = _objetoAsientoLibroDiario.ValorDebeAsiento
                            .NumeroDepositoComprobanteIngreso = "0"
                            .EstadoComprobanteIngreso = 1
                            .IdProvincias = "7"
                            .IdCiudad = "58"
                            .IdParroquias = "287"
                            .IdCentro = CInt(cmbCentroCosto.SelectedValue)
                            .IdBancos = idb
                            .IdCuentaBancos = idc
                        End With
                        _sqlCommands.Add(_objetoComprobanteIngresoBancos.NuevoRegistroComprobanteIngresoBancos)

                        With _objetoNumeroRegistroAsientoComprobanteIngreso
                            .IdComprobanteIngreso = _objetoComprobanteIngresoBancos.Id
                            .IdLibro = _objetoLibroDiario.IdLibroDiario
                            .IdAsiento = _objetoAsientoLibroDiario.IdAsiento
                            .NumeroRegistro = _objetoNumeroRegistro.NumeroRegistro
                        End With
                        _sqlCommands.Add(_objetoNumeroRegistroAsientoComprobanteIngreso.NuevoRegistroNumeroRegistroAsientoComprobanteIngreso)

                    End If

                Next
            Catch ex As Exception
                KryptonMessageBox.Show("No guardo al diario comprobante egreso." & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            End Try
        End Sub
        Private Sub GuardarNumeroRegistroAsientoComprobanteEgreso()
            With _objetoNumeroRegistroAsientoComprobanteEgreso
                .IdComprobanteEgreso = _objetoComprobanteEgresoBancos.Id
                .IdLibro = _objetoLibroDiario.IdLibroDiario
                .IdAsiento = _objetoAsientoLibroDiario.IdAsiento
                .NumeroRegistro = _objetoNumeroRegistro.NumeroRegistro
            End With
            _sqlCommands.Add(_objetoNumeroRegistroAsientoComprobanteEgreso.NuevoRegistroNumeroRegistroAsientoComprobanteEgreso)
        End Sub

        Private Sub dgvComprobantesCompra_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobantesCompra.SelectionChanged
            If dgvComprobantesCompra.RowCount = 0 Then Return
            If dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdComprobanteCompra.Text = "..."
            Else
                lblIdComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(1).Value
            End If
            CargarPagosComprobantesCompra()
        End Sub

        Private Sub txtNumeroCheque_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumeroCheque.KeyUp
            If txtNumeroCheque.Text.Trim.Length = 0 Then
                txtNumeroCheque.ForeColor = Color.Black
                Return
            End If
            Try
                _existeNumero = _objetoChequeEmitido.ExisteNumChequeEmitido(_tipoCon, txtNumeroCheque.Text.Trim, cmbBancos.Text, cmbCuentaBancos.Text)
                If _existeNumero Then
                    txtNumeroCheque.ForeColor = Color.Red
                Else
                    txtNumeroCheque.ForeColor = Color.Black
                End If
            Catch
                txtNumeroCheque.ForeColor = Color.Red
            End Try
        End Sub
    End Class
End Namespace