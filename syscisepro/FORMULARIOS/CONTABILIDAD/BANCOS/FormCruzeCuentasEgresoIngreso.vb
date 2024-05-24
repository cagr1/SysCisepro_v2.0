Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports ClassLibraryCisepro.CONTABILIDAD.CUENTAS_POR_COBRAR
Imports ClassLibraryCisepro.CONTABILIDAD.CUENTAS_POR_PAGAR

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormCruzeCuentasEgresoIngreso
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

        Dim _sqlCommands As List(Of SqlCommand)
        Dim _dataPagosComp As Dictionary(Of String, String)
        Dim _dataPagosVent As Dictionary(Of String, String)

        Dim _cantidadFacturas As Integer ' Cotador para tener cuantas facturas se selecciono y redimensionar el array
        Dim _numerosFacturas() As String ' Array que acumula las facturas seleccionadas de distintos clientes

        Dim _cantidadFacturasEgreso As Integer ' Cotador para tener cuantas facturas se selecciono y redimensionar el array
        Dim _numerosFacturasEgreso() As String ' Array que acumula las facturas seleccionadas de distintos clientes

        Dim _prefijoDetalleAsiento = "" 'establece el prefijo del detalle del asiento segun sea ingreso o egreso (ID CI: / ID CE:)

        ReadOnly _objetoCuentasPorCobrar As New ClassCuentasPorCobrar
        ReadOnly _objetoCuentasPorPagar As New ClassCuentasPorPagar
































        ReadOnly _objetoComprobanteIngresoBancos As New ClassComprobanteIngresoBanco
        ReadOnly _objetoBancosCobros As New ClassBancosCobros
        ReadOnly _objetoBancos As New ClassBancos
        ReadOnly _objetoCuentaBancos As New ClassCuentasBancos
        ReadOnly _objetoLibroDiario As New ClassLibroDiario
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoNumeroRegistro As New ClassNumeroRegistroAsiento
        ReadOnly _objetoNumeroRegistroAsientoComprobanteIngreso As New ClassNumeroRegistroAsientoComprobanteIngreso
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoPagosFacturaVenta As New ClassPagosFacturaVenta
        ReadOnly _validacionesDecimales As New ClassDecimal
        ReadOnly _objetoComprobanteEgresoBancos As New ClassComprobanteEgresoBanco
        ReadOnly _objetoNumeroRegistroAsientoComprobanteEgreso As New ClassNumeroRegistroAsientoComprobanteEgreso
        ReadOnly _objetoChequeEmitido As New ClassChequesEmitidosCxp
        ReadOnly _objetoProveedorGeneral As New ClassProveedores
        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoPagosComprobantesCompra As New ClassPagosComprobantesCompra
        ReadOnly _objetoCompEgresoPagosCompCompra As New ClassCompEgresoPagosCompCompra

        Dim _nroFilasEgreso As Integer = 0

        Private Sub FormCruzeCuentasEgresoIngreso_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvAsientoDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvPagosComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvPagosFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvAsientoDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvPagosComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvPagosFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvAsientoDiario.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvPagosComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvPagosFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            _sqlCommands = New List(Of SqlCommand)
            _dataPagosComp = New Dictionary(Of String, String)
            _dataPagosVent = New Dictionary(Of String, String)

            DeshabilitadoInicio()
            LlenarCuentasContables()
            LlenarComboBancos()

            AutocompletarNombreCliente()
            AutocompletarNombreProveedor()
            AutocompletarNombreBancoCobros()
        End Sub
        Private Sub DeshabilitadoInicio()
            btnNuevo.Enabled = True
            btnCancelar.Enabled = False
            btnGuardar.Enabled = False

            rbtSoloCruce.Enabled = False
            rbComprobanteIngreso.Enabled = False
            rbComprobanteEgreso.Enabled = False
            lblIdComprobanteIngresoBancos.Visible = False
            lblIdComprobanteEgresoBancos.Visible = False

            gbClienteGeneral.Enabled = False
            gbProveedor.Enabled = False

            gbFacturaVenta.Enabled = False
            gbComprobantesCompra.Enabled = False

            gbFacturasTotalCXC.Enabled = False
            gbFacturasTotalCXP.Enabled = False

            gbPagosFacturaVenta.Enabled = False
            gbPagosComprobanteCompra.Enabled = False

            gbCtaContable.Enabled = False
            gbBanco.Enabled = False
            gbFechaComprobante.Enabled = False

            gbFormaPago.Enabled = False
            gbCheque.Enabled = False
            gbValorDebeAjuste.Enabled = False
            gbValorHaberAjuste.Enabled = False

            gbBotonesAgregarEditar.Enabled = False
            gbpAsientoContable.Enabled = False
        End Sub
        Private Sub LlenarCuentasContables()
            Try
                Dim data = _objetoPlanCuentas.SeleccionarCuentasYDetallePlanDeCuentas(_tipoCon)
                cmbCuentasContables.DataSource = data
                cmbCuentasContables.DisplayMember = data.Columns(0).ToString
                cmbCuentasContables.ValueMember = data.Columns(1).ToString
                If (CType(cmbCuentasContables.DataSource, DataTable).Rows.Count > 0) Then cmbCuentasContables.SelectedIndex = 0
            Catch
                cmbCuentasContables.DataSource = Nothing
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
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            rbtSoloCruce.Enabled = True
            rbComprobanteIngreso.Enabled = True
            rbComprobanteEgreso.Enabled = True

            _cantidadFacturas = 0
            ReDim _numerosFacturas(_cantidadFacturas)
            _cantidadFacturasEgreso = 0
            ReDim _numerosFacturasEgreso(_cantidadFacturasEgreso)
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            DeshabilitadoInicio()

            lblIdComprobanteIngresoBancos.Text = "..."
            lblIdComprobanteEgresoBancos.Text = "..."

            lblIdClienteGeneral.Text = "..."
            txtNombreComercialClienteGeneral.Text = ""
            dgvFacturaVenta.DataSource = Nothing

            txtFacturasAPagar.Text = ""
            txtValorComprobaneIngreso.Text = "0.00"
            dgvPagosFacturaVenta.DataSource = Nothing

            lblIdComprobanteEgresoBancos.Text = "..."
            txtNombreComercialProveedor.Text = ""
            dgvComprobantesCompra.DataSource = Nothing

            txtFacturaReceptor.Text = ""
            txtValorComprobanteEgresoBancos.Text = "0.00"
            dgvPagosComprobantesCompra.DataSource = Nothing

            dgvAsientoDiario.Rows.Clear()

            rbtSoloCruce.Checked = False
            rbComprobanteIngreso.Checked = False
            rbComprobanteEgreso.Checked = False
        End Sub
        Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbtSoloCruce.CheckedChanged
            If Not rbtSoloCruce.Checked Then Return

            gbCtaContable.Enabled = False
            gbBanco.Enabled = False
            gbCheque.Enabled = False

            gbValorDebeAjuste.Enabled = True
            gbValorHaberAjuste.Enabled = True

            lblIdComprobanteIngresoBancos.Visible = False
            lblIdComprobanteEgresoBancos.Visible = False

            _prefijoDetalleAsiento = "ID: "

            HabilitadoNuevo()
        End Sub
        Private Sub rbComprobanteIngreso_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbComprobanteIngreso.CheckedChanged
            If rbComprobanteIngreso.Checked Then
                HabilitadoNuevo()
                _prefijoDetalleAsiento = "ID CI: "
                lblIdComprobanteIngresoBancos.Visible = True
            Else
                lblIdComprobanteIngresoBancos.Text = "..."
                lblIdComprobanteIngresoBancos.Visible = False
            End If
        End Sub
        Private Sub rbComprobanteEgreso_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbComprobanteEgreso.CheckedChanged
            If rbComprobanteEgreso.Checked Then
                HabilitadoNuevo()
                _prefijoDetalleAsiento = "ID CE: "
                lblIdComprobanteEgresoBancos.Visible = True
            Else
                lblIdComprobanteEgresoBancos.Text = "..."
                lblIdComprobanteEgresoBancos.Visible = False
            End If
        End Sub
        Private Sub HabilitadoNuevo()
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True

            rbtSoloCruce.Enabled = False
            rbComprobanteIngreso.Enabled = False
            rbComprobanteEgreso.Enabled = False

            lblIdComprobanteIngresoBancos.Text = "..."
            lblIdComprobanteEgresoBancos.Text = "..."

            gbClienteGeneral.Enabled = True
            gbProveedor.Enabled = True

            gbFacturaVenta.Enabled = True
            gbComprobantesCompra.Enabled = True

            gbFacturasTotalCXC.Enabled = True
            gbFacturasTotalCXP.Enabled = True

            gbPagosFacturaVenta.Enabled = True
            gbPagosComprobanteCompra.Enabled = True

            gbCtaContable.Enabled = True
            gbBanco.Enabled = True
            gbFechaComprobante.Enabled = True
            gbFormaPago.Enabled = True
            gbCheque.Enabled = True
            gbValorDebeAjuste.Enabled = True
            gbValorHaberAjuste.Enabled = True

            gbBotonesAgregarEditar.Enabled = True
            gbpAsientoContable.Enabled = True
        End Sub
        Private Sub txtNombreComercialClienteGeneral_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialClienteGeneral.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            _cantidadFacturas = 0
            ReDim _numerosFacturas(_cantidadFacturas)

            txtFacturasAPagar.Text = ""
            txtValorComprobaneIngreso.Text = "0.00"
            dgvPagosFacturaVenta.DataSource = Nothing

            lblIdClienteGeneral.Text = _objetoClienteGeneral.BuscarIdClienteXRazonSocial(_tipoCon, txtNombreComercialClienteGeneral.Text)
            CargarFacturasVenta()
        End Sub
        Private Sub CargarFacturasVenta()
            Try
                'dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaImpagasXIdCliente(_tipoCon, lblIdClienteGeneral.Text)                 
                dgvFacturaVenta.DataSource = _objetoCuentasPorCobrar.BuscarCuentasPorCobrarPorClientePorRangoFecha(_tipoCon, lblIdClienteGeneral.Text, "2013-01-01 00:00:00", "2099-12-31 23:59:59", False)

                dgvFacturaVenta.Columns(1).HeaderText = "ID"
                dgvFacturaVenta.Columns(2).HeaderText = "NUMERO"
                dgvFacturaVenta.Columns(3).HeaderText = "FECHA"
                dgvFacturaVenta.Columns(4).HeaderText = "TOTAL"

                dgvFacturaVenta.Columns(5).Visible = False
                dgvFacturaVenta.Columns(6).Visible = False
                dgvFacturaVenta.Columns(7).Visible = False
                dgvFacturaVenta.Columns(8).Visible = False

                dgvFacturaVenta.Columns(9).HeaderText = "SALDO"

                dgvFacturaVenta.Columns(10).Visible = False

                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
            Catch ex As Exception
                dgvFacturaVenta.DataSource = Nothing
                MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub txtNombreComercialProveedor_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialProveedor.KeyUp
            If e.KeyCode <> Keys.Enter Then Return

            _cantidadFacturasEgreso = 0
            ReDim _numerosFacturasEgreso(_cantidadFacturasEgreso)

            txtFacturaReceptor.Text = ""
            txtValorComprobanteEgresoBancos.Text = "0.00"
            dgvPagosComprobantesCompra.DataSource = Nothing

            CargarDatosProveedor()
            CargarComprobantesCompra()
        End Sub
        Private Sub CargarDatosProveedor()
            Try
                Dim p = _objetoProveedorGeneral.BuscarProveedorGeneralXNombre(_tipoCon, txtNombreComercialProveedor.Text)
                If p.Rows.Count > 0 Then
                    lblIdProveedorGeneral.Text = p.Rows(0)(0).ToString()
                    lblIdProveedorGeneral.Tag = p.Rows(0)(2).ToString
                End If
            Catch ex As Exception
                lblIdProveedorGeneral.Text = String.Empty
                lblIdProveedorGeneral.Tag = Nothing
                MsgBox("CARGAR DATOS PROVEEDOR." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub CargarComprobantesCompra()
            Try
                'dgvComprobantesCompra.DataSource = _objetoComprobantesCompra.SeleccionarComrpobantesCompraImpagosXIdProveedor(_tipoCon, lblIdProveedorGeneral.Text)
                dgvComprobantesCompra.DataSource = _objetoCuentasPorPagar.BuscarCuentasPorPagarXIdProveedorRangoFechaNoCeroMin(_tipoCon, lblIdProveedorGeneral.Text, "2013-01-01 00:00:00", "2099-12-31 23:59:59")

                dgvComprobantesCompra.Columns(0).HeaderText = "ID"
                dgvComprobantesCompra.Columns(4).HeaderText = "FECHA"

                dgvComprobantesCompra.Columns(5).Visible = False
                dgvComprobantesCompra.Columns(6).Visible = False
                dgvComprobantesCompra.Columns(7).Visible = False
                dgvComprobantesCompra.Columns(8).Visible = False
                dgvComprobantesCompra.Columns(9).Visible = False
                dgvComprobantesCompra.Columns(11).Visible = False
                dgvComprobantesCompra.Columns(12).Visible = False
                dgvComprobantesCompra.Columns(13).Visible = False
                dgvComprobantesCompra.Columns(14).Visible = False
                dgvComprobantesCompra.Columns(15).Visible = False

                dgvComprobantesCompra.Columns(16).HeaderText = "SALDO"

                dgvComprobantesCompra.AutoResizeColumns()
                dgvComprobantesCompra.AutoResizeRows()
            Catch ex As Exception
                dgvComprobantesCompra.DataSource = Nothing
                MsgBox("METODO CARGAR COMPROBANTES DE COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub dgvFacturaVenta_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturaVenta.SelectionChanged
            If dgvFacturaVenta.RowCount = 0 Then Return
            If dgvFacturaVenta.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdFacturaVenta.Text = "..."
            Else
                lblIdFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(1).Value ' obtiene el id de la factura seleccionada
                CargarPagosFacturaVenta() ' carga los pagos realizados a la factura seleccionada
            End If
        End Sub
        Private Sub CargarPagosFacturaVenta()
            Try
                dgvPagosFacturaVenta.DataSource = _objetoPagosFacturaVenta.SeleccionarPagosFacturaVentaXIdFactura(_tipoCon, lblIdFacturaVenta.Text)
                dgvPagosFacturaVenta.Columns(0).HeaderText = "ID"
                dgvPagosFacturaVenta.Columns(1).HeaderText = "FECHA"
                dgvPagosFacturaVenta.Columns(1).Visible = False
                dgvPagosFacturaVenta.Columns(2).HeaderText = "NÚMERO"
                dgvPagosFacturaVenta.Columns(3).HeaderText = "FORMA"
                dgvPagosFacturaVenta.Columns(3).Visible = False
                dgvPagosFacturaVenta.Columns(4).HeaderText = "MONTO"
                dgvPagosFacturaVenta.Columns(5).HeaderText = "SALDO"
                dgvPagosFacturaVenta.Columns(6).HeaderText = "EST"
                dgvPagosFacturaVenta.Columns(7).HeaderText = "ID FV"
                dgvPagosFacturaVenta.AutoResizeColumns()
                dgvPagosFacturaVenta.AutoResizeRows()
                dgvPagosFacturaVenta.ReadOnly = False
                dgvPagosFacturaVenta.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                dgvPagosFacturaVenta.DataSource = Nothing
                MsgBox("METODO CARGAR PAGOS FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub dgvComprobantesCompra_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobantesCompra.SelectionChanged
            If dgvComprobantesCompra.RowCount = 0 Then Return
            If dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdComprobanteCompra.Text = "..."
            Else
                lblIdComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(1).Value
                CargarPagosComprobantesCompra()
            End If
        End Sub
        Private Sub CargarPagosComprobantesCompra()
            Try
                dgvPagosComprobantesCompra.DataSource = _objetoPagosComprobantesCompra.SeleccionarPagosComrpobantesCompraXIdComprobante(_tipoCon, lblIdComprobanteCompra.Text)
                dgvPagosComprobantesCompra.Columns(0).HeaderText = "ID"
                dgvPagosComprobantesCompra.Columns(1).HeaderText = "FECHA"
                dgvPagosComprobantesCompra.Columns(1).Visible = False
                dgvPagosComprobantesCompra.Columns(2).HeaderText = "NRO P"
                dgvPagosComprobantesCompra.Columns(3).HeaderText = "MONTO"
                dgvPagosComprobantesCompra.Columns(4).HeaderText = "SALDO"
                dgvPagosComprobantesCompra.Columns(5).HeaderText = "EST"
                dgvPagosComprobantesCompra.Columns(6).HeaderText = "ID CC"
                dgvPagosComprobantesCompra.AutoResizeColumns()
                dgvPagosComprobantesCompra.AutoResizeRows()
                dgvPagosComprobantesCompra.ReadOnly = False
                dgvPagosComprobantesCompra.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                dgvPagosComprobantesCompra.DataSource = Nothing
                MsgBox("METODO CARGAR PAGOS COMPROBANTES DE COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub dgvFacturaVenta_CellContentClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturaVenta.CellContentClick
            If e.ColumnIndex = chk.Index Then
                If CBool(dgvFacturaVenta.CurrentCell.EditedFormattedValue) Then ' CheckBox Marcado
                    'Dim s = _objetoPagosFacturaVenta.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, dgvFacturaVenta.CurrentRow.Cells(1).Value)
                    Dim s = CDec(dgvFacturaVenta.CurrentRow.Cells(9).Value)

                    If s <> 0 Then
                        _numerosFacturas(_cantidadFacturas) = dgvFacturaVenta.CurrentRow.Cells(2).Value.ToString
                        Dim cadena = ""
                        For indiceArray = 0 To _cantidadFacturas ' carga los numeros de las factura seleccionados
                            cadena += "FACT: " & _numerosFacturas(indiceArray) + "; "
                        Next
                        _cantidadFacturas += 1 ' aumenta el numero de comprobantes seleccionados
                        ReDim Preserve _numerosFacturas(_cantidadFacturas) ' redimensiona el array a la cantidad de facturas actual

                        ' carga las facturas a pagar
                        txtFacturasAPagar.Text = cadena

                        '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= CARGA EL DIARIO DEL COMPROBANTE DE INGRESO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                        dgvAsientoDiario.Rows.Add()
                        _nroFilasEgreso = dgvAsientoDiario.Rows.Count - 1

                        ' obtiene el numero de la cta seleccionada
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(0).Value = "1010205"
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(1).Value = "DOCUMENTOS Y CUENTAS POR COBRAR CLIENTES NO RELACIONADOS"
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(2).Value = "CRUCE DE CUENTAS"
                        ' se detalla la transacción según la forma de pago
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(3).Value = _prefijoDetalleAsiento + lblIdComprobanteIngresoBancos.Text + " CLIENTE: " + txtNombreComercialClienteGeneral.Text + " FACTURA NRO: " + dgvFacturaVenta.CurrentRow.Cells(2).Value + " FORMA PAGO: CRUCE DE CUENTAS"
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(4).Value = "0.00" ' se ingresa el valor del haber
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(5).Value = s ' se ingresa el valor del debe
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(6).Value = "0" ' el id del ID_CC
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(7).Value = dgvFacturaVenta.CurrentRow.Cells(1).Value.ToString ' el id de la factura
                        'suma total comprobante
                        txtValorComprobaneIngreso.Text = CDec(txtValorComprobaneIngreso.Text) + s ' se suma el valor del saldo de la factura
                    Else
                        MsgBox("ESTA FACTURA YA FUE CANCELADA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
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

                    For indiceCompEgreso = 0 To dgvAsientoDiario.Rows.Count - 1
                        If dgvAsientoDiario.Rows(indiceCompEgreso).Cells(6).Value.ToString = dgvFacturaVenta.CurrentRow.Cells(1).Value.ToString Then
                            dgvAsientoDiario.Rows.RemoveAt(dgvAsientoDiario.Rows(indiceCompEgreso).Index)
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
                        cadena += "FACT: " & _numerosFacturas(indiceArray) + "; "
                    Next
                    txtFacturasAPagar.Text = cadena

                    'sumar total comprobante
                    txtValorComprobaneIngreso.Text = CDec(txtValorComprobaneIngreso.Text) - _objetoPagosFacturaVenta.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, dgvFacturaVenta.CurrentRow.Cells(1).Value) ' se resta el valor del saldo de la factura
                End If

                SumarTotal()
            End If
        End Sub
        Private Sub dgvComprobantesCompra_CellContentClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvComprobantesCompra.CellContentClick
            If e.ColumnIndex = chk.Index Then
                If CBool(dgvComprobantesCompra.CurrentCell.EditedFormattedValue) Then ' CheckBox Marcado
                    'Dim s = _objetoPagosComprobantesCompra.BuscarMayorSaldoPagosComprobantesCompraXIdComprobante(_tipoCon, dgvComprobantesCompra.CurrentRow.Cells(1).Value)
                    Dim s = CDec(dgvComprobantesCompra.CurrentRow.Cells(16).Value)

                    If s <> 0 Then
                        _numerosFacturasEgreso(_cantidadFacturasEgreso) = dgvComprobantesCompra.CurrentRow.Cells(3).Value
                        Dim cadena = ""
                        For indiceArray = 0 To _cantidadFacturasEgreso ' carga los numeros de los comprobantes seleccionados
                            cadena += "FACT: " & _numerosFacturasEgreso(indiceArray) & "; "
                        Next
                        _cantidadFacturasEgreso += 1 ' aumenta el numero de comprobantes seleccionados
                        ReDim Preserve _numerosFacturasEgreso(_cantidadFacturasEgreso) ' redimensiona el array a la cantidad de documentos actual

                        '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= CARGA LAS FACTURAS A PAGAR COMPROBANTE DE EGRESO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                        txtFacturaReceptor.Text = cadena
                        '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= CARGA EL DIARIO DEL COMPROBANTE DE EGRESO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                        dgvAsientoDiario.Rows.Add()
                        _nroFilasEgreso = dgvAsientoDiario.Rows.Count - 1
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(0).Value = "2010301"
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(1).Value = "LOCALES" 'objetoPlanCuentas.auxiliarDetallePlan
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(2).Value = "CRUCE DE CUENTAS"
                        ' se detalla la transacción según la forma de pago
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(3).Value = _prefijoDetalleAsiento + lblIdComprobanteEgresoBancos.Text + " PROVEEDOR: " + txtNombreComercialProveedor.Text + " FACT: " + dgvComprobantesCompra.CurrentRow.Cells(3).Value.ToString + " FORMA PAGO: CRUCE DE CUENTAS"

                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(4).Value = s ' se ingresa el valor del debe
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(5).Value = "0.00" ' se ingresa el valor del haber
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(6).Value = dgvComprobantesCompra.CurrentRow.Cells(1).Value.ToString ' el id de la compra
                        dgvAsientoDiario.Rows(_nroFilasEgreso).Cells(7).Value = "0" ' se ingresa el id de la factura
                        'suma Total comprobante
                        txtValorComprobanteEgresoBancos.Text = CDec(txtValorComprobanteEgresoBancos.Text) + s
                    Else
                        MsgBox("ESTA COMPRA YA FUE CANCELADA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    End If
                Else ' CheckBox Desmarcado"
                    For indiceArray = 0 To _cantidadFacturasEgreso - 1
                        If _numerosFacturasEgreso(indiceArray) = dgvComprobantesCompra.CurrentRow.Cells(10).Value.ToString Then
                            _numerosFacturasEgreso(indiceArray) = ""
                        End If
                    Next
                    For indiceArray = 0 To _cantidadFacturasEgreso - 1
                        If indiceArray <> _cantidadFacturasEgreso - 1 Then
                            If _numerosFacturasEgreso(indiceArray) = "" And _numerosFacturasEgreso(indiceArray + 1) <> "" Then
                                _numerosFacturasEgreso(indiceArray) = _numerosFacturasEgreso(indiceArray + 1)
                                _numerosFacturasEgreso(indiceArray + 1) = ""
                            End If
                        End If
                    Next
                    _cantidadFacturasEgreso = _cantidadFacturasEgreso - 1
                    ReDim Preserve _numerosFacturasEgreso(_cantidadFacturasEgreso)
                    Dim cadena = ""
                    For indiceArray = 0 To _cantidadFacturasEgreso - 1
                        cadena += _numerosFacturasEgreso(indiceArray) & " - "
                    Next
                    txtFacturaReceptor.Text = cadena
                    For indiceCompEgreso = 0 To dgvAsientoDiario.Rows.Count - 1
                        If dgvAsientoDiario.Rows(indiceCompEgreso).Cells(6).Value = dgvComprobantesCompra.CurrentRow.Cells(1).Value.ToString Then
                            dgvAsientoDiario.Rows.RemoveAt(dgvAsientoDiario.Rows(indiceCompEgreso).Index)
                            Exit For
                        End If
                    Next
                    ' suma Total comprobante
                    txtValorComprobanteEgresoBancos.Text = CDec(txtValorComprobanteEgresoBancos.Text) - _objetoPagosComprobantesCompra.BuscarMayorSaldoPagosComprobantesCompraXIdComprobante(_tipoCon, dgvComprobantesCompra.CurrentRow.Cells(1).Value)
                End If

                SumarTotal()
            End If
        End Sub
        Private Sub SumarTotal()
            Dim acumuladorDebe As Decimal = 0
            Dim acumuladorHaber As Decimal = 0
            Dim valorAjuste As Decimal = 0
            Try
                For indice = 0 To dgvAsientoDiario.RowCount - 1 ' recorre el asiento de diario
                    acumuladorDebe += CDec(dgvAsientoDiario.Rows(indice).Cells(4).Value) ' suma el valor del debe
                    acumuladorHaber += CDec(dgvAsientoDiario.Rows(indice).Cells(5).Value) ' suma el valor de haber
                Next
                txtTotalDebe.Text = acumuladorDebe ' asigna valores a la caja de texto
                txtTotalHaber.Text = acumuladorHaber ' asigna valores a la caja de texto

                If CDec(txtValorComprobaneIngreso.Text) > CDec(txtValorComprobanteEgresoBancos.Text) Then ' pregunta que valor es mayor CXC que CXP para sacar la diferencia
                    valorAjuste = CDec(txtValorComprobaneIngreso.Text) - CDec(txtValorComprobanteEgresoBancos.Text) ' obtiene la diferencia
                    If rbComprobanteIngreso.Checked Then ' si es comprobante de ingreso
                        txtValorDebeAjuste.Text = "0.00"
                        txtValorHaberAjuste.Text = valorAjuste ' el ajuste va al haber
                    Else
                        txtValorDebeAjuste.Text = valorAjuste ' el ajuste va al debe
                        txtValorHaberAjuste.Text = "0.00"
                    End If
                ElseIf CDec(txtValorComprobaneIngreso.Text) < CDec(txtValorComprobanteEgresoBancos.Text) Then 'caso contrario
                    valorAjuste = CDec(txtValorComprobanteEgresoBancos.Text) - CDec(txtValorComprobaneIngreso.Text) ' obtiene la diferencia
                    If rbComprobanteIngreso.Checked Then ' si es comprobante de ingreso
                        txtValorDebeAjuste.Text = valorAjuste ' el ajuste va al debe
                        txtValorHaberAjuste.Text = "0.00"
                    Else
                        txtValorDebeAjuste.Text = "0.00"
                        txtValorHaberAjuste.Text = valorAjuste ' el ajuste va al haber
                    End If
                End If
            Catch ex As Exception
                MsgBox("ERROR. NO SUMO TOTAL DE FACTURAS MARCADAS" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub cmbCuentasContables_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbCuentasContables.SelectedValueChanged
            If cmbCuentasContables.SelectedValue Is Nothing Or TypeOf cmbCuentasContables.SelectedValue Is DataRowView Then Return
            lblCodigoCuentaContable.Text = cmbCuentasContables.SelectedValue
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
        Private Sub AutocompletarNombreCliente()
            Try
                txtNombreComercialClienteGeneral.AutoCompleteCustomSource = _objetoClienteGeneral.Autocompletar(_tipoCon)
                txtNombreComercialClienteGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialClienteGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialClienteGeneral.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub AutocompletarNombreProveedor()
            Try
                txtNombreComercialProveedor.AutoCompleteCustomSource = _objetoProveedorGeneral.Autocompletar(_tipoCon)
                txtNombreComercialProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                txtNombreComercialProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialProveedor.AutoCompleteCustomSource = Nothing
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
        Private Sub rbCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbCheque.CheckedChanged
            If rbCheque.Checked Then
                If txtNombreComercialClienteGeneral.Text <> "" And lblIdClienteGeneral.Text <> "..." Then
                    gbCheque.Enabled = True
                    txtTitularCheque.Text = txtNombreComercialClienteGeneral.Text
                Else
                    MsgBox("PRIMERO CARGUE UN CLIENTE", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                    rbEfectivo.Checked = True
                End If
            Else
                gbCheque.Enabled = False
                txtTitularCheque.Text = ""
            End If
        End Sub
        Private Sub txtValorDebeAjuste_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtValorDebeAjuste.KeyPress
            e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
        End Sub
        Private Sub txtValorHaberAjuste_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtValorHaberAjuste.KeyPress
            e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
        End Sub
        Private Sub dgvAsientoDiario_CellValidated(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvAsientoDiario.CellValidated
            SumarTotal()
        End Sub
        Private Sub btnAgregarConceptoComprobante_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarConceptoComprobante.Click
            Dim nroFilaEgreso = dgvAsientoDiario.RowCount
            If dgvAsientoDiario.RowCount > 0 Then
                If lblCodigoCuentaContable.Text <> "..." And cmbBancos.SelectedValue <> "0" And cmbCuentaBancos.SelectedValue <> "0" And txtNumeroCheque.Text <> "" Then
                    dgvAsientoDiario.Rows.Add()
                    dgvAsientoDiario.Rows(nroFilaEgreso).Cells(0).Value = lblCodigoCuentaContable.Text.Trim
                    dgvAsientoDiario.Rows(nroFilaEgreso).Cells(1).Value = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, lblCodigoCuentaContable.Text.Trim).Trim
                    dgvAsientoDiario.Rows(nroFilaEgreso).Cells(2).Value = "COMPROBANTE DE EGRESO BANCOS"

                    If rbComprobanteIngreso.Checked Then ' si es cruce por comprobante de ingreso
                        dgvAsientoDiario.Rows(nroFilaEgreso).Cells(3).Value = "ID: " + lblIdComprobanteIngresoBancos.Text.ToString
                    Else ' si es cruce por comprobante de egreso
                        dgvAsientoDiario.Rows(nroFilaEgreso).Cells(3).Value = "ID: " + lblIdComprobanteEgresoBancos.Text.ToString
                    End If

                    dgvAsientoDiario.Rows(nroFilaEgreso).Cells(4).Value = txtValorDebeAjuste.Text  ' se ingresa el valor del debe
                    dgvAsientoDiario.Rows(nroFilaEgreso).Cells(5).Value = txtValorHaberAjuste.Text ' se ingresa el valor del haber
                    dgvAsientoDiario.Rows(nroFilaEgreso).Cells(6).Value = "0"
                    SumarTotal()
                    btnEditarValores.Enabled = True
                Else
                    MsgBox("SELECCIONE UN BANCO, CUENTA E INGRESE UN NÚMERO DE CHEQUE", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                End If
            Else
                MsgBox("PRIMERO CARGUE UN CONCEPTO DE EGRESO", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub
        Private Sub ToolStripMenuItemEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItemEliminar.Click
            Dim lSeleccionados As DataGridViewSelectedRowCollection = dgvAsientoDiario.SelectedRows
            Select Case lSeleccionados.Count
                Case 0
                    MessageBox.Show("Debe seleccionar alguna fila", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                Case Is > 1
                    MessageBox.Show("Demasiadas filas seleccionadas", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
            End Select
            Dim loFila As DataGridViewRow = dgvAsientoDiario.CurrentRow()
            Dim lsMensage As String = "¿Esta seguro de querer eliminar este Registro" & vbCrLf & loFila.Cells(2).Value.ToString()
            If MessageBox.Show(lsMensage, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then Return

            Try
                dgvAsientoDiario.Rows.RemoveAt(dgvAsientoDiario.CurrentRow.Index)
                SumarTotal()
                MessageBox.Show("FILA ELIMINADA", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch exp As Exception
                MessageBox.Show(exp.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If CDec(txtTotalDebe.Text) = CDec(txtTotalHaber.Text) Then
                If MessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                _sqlCommands.Clear()

                _objetoComprobanteIngresoBancos.Id = _objetoComprobanteIngresoBancos.BuscarMayorIdComprobanteIngresoBancos(_tipoCon) + 1
                _objetoLibroDiario.IdLibroDiario = _objetoLibroDiario.BuscarMayorIdLibroDiario(_tipoCon)

                With _objetoNumeroRegistro
                    .NumeroRegistro = .BuscarMayorNumeroRegistro(_tipoCon) + 1
                    .NumeroAnterior = .BuscarMayorNumeroAnterior(_tipoCon)
                End With
                _sqlCommands.Add(_objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand())

                If rbComprobanteIngreso.Checked Then
                    GuardarRegistroComprobanteIngresoBancos()
                    GuardarNumeroRegistroAsientoComprobanteIngreso()
                ElseIf rbComprobanteEgreso.Checked Then
                    GuardarRegistroComprobanteEgresoBancos() ' guarda comprobante de egreso
                    If rbCheque.Checked Then GuardarRegistroChequeEmitido() ' guarda el registro del cheque emitido si el pago es con cheque
                    GuardarNumeroRegistroAsientoComprobanteEgreso() ' guarda el numero de asiento y el comprobante de egreso para relacionar
                End If

                GuardarRegistroPagosFacturaVenta() ' guarda el pago de la factura de venta
                GuardarRegistroPagosComprobanteCompra() ' guarda el pago del comprobante de compra
                NuevoRegistroAsientoDiarioComprobanteIngresoBancos() ' guarda el asiento de diario

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    DeshabilitadoInicio()
                    btnCancelar.Enabled = False
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "LOS VALORES DE EL DEBE Y EL HABER NO COINCIDEN POR FAVOR REVISE LAS TRANSACCIONES.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACION")
            End If
        End Sub
        Private Sub GuardarRegistroComprobanteIngresoBancos()
            lblIdComprobanteIngresoBancos.Text = _objetoComprobanteIngresoBancos.BuscarMayorIdComprobanteIngresoBancos(_tipoCon) + 1
            With _objetoComprobanteIngresoBancos
                .Id = lblIdComprobanteIngresoBancos.Text
                .FechaComprobanteIngreso = dtpFechaEmisionComprobante.Value
                .NumeroFactura = txtFacturasAPagar.Text
                .IdCliente = CInt(lblIdClienteGeneral.Text)
                .ActividadComprobanteIngreso = "1010106"
                .ConceptoComprobanteIngreso = "CRUCE DE CUENTAS"
                If rbCheque.Checked Then
                    .FormaPagoComprobanteIngreso = "CHEQUE"
                ElseIf rbEfectivo.Checked Then
                    .FormaPagoComprobanteIngreso = "EFECTIVO"
                ElseIf rbTarjetaCredido.Checked Then
                    .FormaPagoComprobanteIngreso = "TARJETA CRÉDITO"
                ElseIf rbTransaccion.Checked Then
                    .FormaPagoComprobanteIngreso = "TRANSACCIÓN"
                End If
                .ObservacionesComprobanteIngreso = "CRUCE DE CUENTAS DEL CLIENTE " + txtNombreComercialClienteGeneral.Text.ToString + " CON EL PROVEEDOR " + txtNombreComercialProveedor.Text.ToString
                .ValorComprobanteIngreso = txtValorComprobaneIngreso.Text
                .NumeroDepositoComprobanteIngreso = "0"
                .EstadoComprobanteIngreso = 1
                .IdProvincias = "7"
                .IdCiudad = "58"
                .IdParroquias = "287"
                .IdCentro = 1
                .IdBancos = 0
                .IdCuentaBancos = 0
            End With
            _sqlCommands.Add(_objetoComprobanteIngresoBancos.NuevoRegistroComprobanteIngresoBancos)
        End Sub
        Private Sub GuardarNumeroRegistroAsientoComprobanteIngreso() 'Tabla intermedia para enlazar en el diario los Comprobantes de ingreso
            With _objetoNumeroRegistroAsientoComprobanteIngreso
                .IdComprobanteIngreso = lblIdComprobanteIngresoBancos.Text
                .IdLibro = _objetoLibroDiario.IdLibroDiario
                .IdAsiento = _objetoAsientoLibroDiario.IdAsiento
                .NumeroRegistro = _objetoNumeroRegistro.NumeroRegistro
            End With
            _sqlCommands.Add(_objetoNumeroRegistroAsientoComprobanteIngreso.NuevoRegistroNumeroRegistroAsientoComprobanteIngreso)
        End Sub
        Private Sub GuardarRegistroComprobanteEgresoBancos()
            lblIdComprobanteEgresoBancos.Text = _objetoComprobanteEgresoBancos.BuscarMayorNumeroComprobanteEgresoBancos(_tipoCon) + 1
            With _objetoComprobanteEgresoBancos
                .Id = lblIdComprobanteEgresoBancos.Text
                .NumeroComprobante = CLng(lblIdComprobanteEgresoBancos.Text)
                .FechaComprobante = dtpFechaEmisionComprobante.Value
                .NumeroFactura = txtFacturaReceptor.Text
                .RucCiReceptor = lblIdProveedorGeneral.Tag
                .NombreReceptor = txtNombreComercialClienteGeneral.Text.ToUpper
                .Actividad = "1010102"
                .Concepto = "CRUCE DE CUENTAS"
                .TipoPago = "CRUCE DE CUENTAS"
                .Razon = "CRUCE DE CUENTAS DEL CLIENTE " + txtNombreComercialClienteGeneral.Text.ToString + " CON EL PROVEEDOR " + txtNombreComercialProveedor.Text.ToString
                .Valor = txtValorComprobanteEgresoBancos.Text
                .NumeroCheque = txtNumeroCheque.Text
                .Estado = 2
                .IdCentroCosto = 2
                .IdProvincias = "7"
                .IdCiudad = "58"
                .IdParroquias = "287"
                .IdBancos = 0
                .IdCuentaBanco = 0
            End With
            _sqlCommands.Add(_objetoComprobanteEgresoBancos.NuevoRegistroComprobanteEgresoBancos)
        End Sub
        Private Sub GuardarNumeroRegistroAsientoComprobanteEgreso() 'Tabla intermedia para enlazar en el diario los Comprobantes de egreso
            With _objetoNumeroRegistroAsientoComprobanteEgreso
                .IdComprobanteEgreso = lblIdComprobanteIngresoBancos.Text
                .IdLibro = _objetoLibroDiario.IdLibroDiario
                .IdAsiento = _objetoAsientoLibroDiario.IdAsiento
                .NumeroRegistro = _objetoNumeroRegistro.NumeroRegistro
                .NuevoRegistroNumeroRegistroAsientoComprobanteEgreso(_tipoCon)
            End With
            _sqlCommands.Add(_objetoNumeroRegistroAsientoComprobanteEgreso.NuevoRegistroNumeroRegistroAsientoComprobanteEgreso)
        End Sub
        Private Sub GuardarRegistroPagosFacturaVenta()
            Dim idv As String
            Dim ip = _objetoPagosFacturaVenta.BuscarMayorIdPagoFacturaVenta(_tipoCon) + 1
            _dataPagosVent.Clear()

            Dim montoPagoFacturas = 0.0
            For indice = 0 To dgvAsientoDiario.RowCount - 1
                idv = dgvAsientoDiario.Rows(indice).Cells(7).Value.ToString().Trim()

                If idv <> 0 Then
                    If _dataPagosVent.ContainsKey(idv) Then
                        Dim vars = _dataPagosVent(idv).Split("-")
                        Dim n = CInt(vars(0).Trim()) + 1
                        Dim v = CDec(vars(1).Trim()) - CDec(montoPagoFacturas)

                        With _objetoPagosFacturaVenta
                            .IdPagoFactura = ip
                            .FechaPagoFactura = dtpFechaEmisionComprobante.Value
                            .NumeroPagoFactura = n
                            .FormaPagoFactura = "CRUCE DE CUENTAS"
                            If CDec(dgvAsientoDiario.Rows(indice).Cells(5).Value) <> 0 Then
                                montoPagoFacturas = dgvAsientoDiario.Rows(indice).Cells(5).Value
                            ElseIf CDec(dgvAsientoDiario.Rows(indice).Cells(4).Value) <> 0 Then
                                montoPagoFacturas = dgvAsientoDiario.Rows(indice).Cells(4).Value
                            Else
                                montoPagoFacturas = dgvAsientoDiario.Rows(indice).Cells(5).Value
                            End If
                            .MontoPagoFactura = montoPagoFacturas
                            .SaldoPagoFactura = v
                            .EstadoPagoFactura = 1
                            .IdFactura = dgvAsientoDiario.Rows(indice).Cells(7).Value
                            .IdCliente = _objetoFacturaVenta.BuscarIdClienteXIdFacturaVenta(_tipoCon, idv)
                            .IdComprobanteIngreso = lblIdComprobanteIngresoBancos.Text
                        End With

                        _dataPagosVent(idv) = n & "-" & v
                    Else
                        With _objetoPagosFacturaVenta
                            .IdPagoFactura = ip
                            .FechaPagoFactura = dtpFechaEmisionComprobante.Value
                            .NumeroPagoFactura = .BuscarMayorNumeroPagoFcturaVentaXIdFactura(_tipoCon, idv) + 1
                            .FormaPagoFactura = "CRUCE DE CUENTAS"
                            If CDec(dgvAsientoDiario.Rows(indice).Cells(5).Value) <> 0 Then
                                montoPagoFacturas = dgvAsientoDiario.Rows(indice).Cells(5).Value
                            ElseIf CDec(dgvAsientoDiario.Rows(indice).Cells(4).Value) <> 0 Then
                                montoPagoFacturas = dgvAsientoDiario.Rows(indice).Cells(4).Value
                            Else
                                montoPagoFacturas = dgvAsientoDiario.Rows(indice).Cells(5).Value
                            End If
                            .MontoPagoFactura = montoPagoFacturas
                            .SaldoPagoFactura = CDec(.BuscarMayorSaldoPagosFacturaventaXIdFactura(_tipoCon, idv)) - CDec(montoPagoFacturas)
                            .EstadoPagoFactura = 1
                            .IdFactura = dgvAsientoDiario.Rows(indice).Cells(7).Value
                            .IdCliente = _objetoFacturaVenta.BuscarIdClienteXIdFacturaVenta(_tipoCon, idv)
                            .IdComprobanteIngreso = lblIdComprobanteIngresoBancos.Text
                        End With

                        _dataPagosVent.Add(idv, _objetoPagosFacturaVenta.NumeroPagoFactura & "-" & _objetoPagosFacturaVenta.SaldoPagoFactura)
                    End If

                    _sqlCommands.Add(_objetoPagosFacturaVenta.NuevoRegistroPagosFacturaVenta)
                    ip += 1
                End If
            Next
        End Sub

         





























       

        















        
       
        

        

        


        

        

        

        

        Private Sub GuardarRegistroChequeEmitido()
            With _objetoChequeEmitido
                .IdCheque = .BuscarMayorIdChequeEmitidoCxp(_tipoCon) + 1
                .FechaEmisionCheque = dtpFechaEmisionCheque.Value
                .BancoCheque = cmbBancos.SelectedValue
                .CtaCteCheque = cmbCuentaBancos.SelectedValue
                .NumeroCheque = txtNumeroCheque.Text
                .BeneficiarioCheque = txtTitularCheque.Text
                .ValorCheque = txtValorComprobanteEgresoBancos.Text
                .EstadoCheque = 1
                .FechaCobro = "26-10-1984 05:30:00"
                .IdComprobante = lblIdComprobanteEgresoBancos.Text
            End With
            _sqlCommands.Add(_objetoChequeEmitido.NuevoRegistroChequeEmitidoCxp)
        End Sub

        

        

        Private Sub GuardarRegistroPagosComprobanteCompra()
            If dgvAsientoDiario.Rows.Count > 0 Then
                Dim idc As String
                Dim ip = _objetoPagosComprobantesCompra.BuscarMayorIdPagosComprobantesCompra(_tipoCon) + 1
                _dataPagosComp.Clear()

                For indice = 0 To dgvAsientoDiario.RowCount - 1
                    idc = dgvAsientoDiario.Rows(indice).Cells(6).Value.ToString().Trim()
                    If idc <> 0 Then

                        If _dataPagosComp.ContainsKey(idc) Then
                            Dim vars = _dataPagosComp(idc).Split("-")
                            Dim n = CInt(vars(0).Trim()) + 1
                            Dim v = CDec(vars(1).Trim()) - CDec(dgvAsientoDiario.Rows(indice).Cells(5).Value)

                            With _objetoPagosComprobantesCompra
                                .IdPagosComprobantes = ip
                                .FechaPagosComprobantes = dtpFechaEmisionComprobante.Value
                                .NumeroPagosComprobantes = n
                                .MontoPagosComprobantes = CDec(dgvAsientoDiario.Rows(indice).Cells(4).Value) + CDec(dgvAsientoDiario.Rows(indice).Cells(5).Value)
                                .SaldoPagosComprobantes = v
                                .EstadoPagosComprobantes = 1
                                .IdComprobante = idc
                                .IdProveedorGeneral = _objetoComprobantesCompra.BuscarIdProveedorXIdComprobanteCompra(_tipoCon, idc)
                                .IdComprobanteEgreso = 0
                            End With
                            _sqlCommands.Add(_objetoPagosComprobantesCompra.NuevoRegistroPagosComprobantesCompra)

                            With _objetoCompEgresoPagosCompCompra
                                .Id = lblIdComprobanteIngresoBancos.Text
                                .IdComprobanteCompra = idc
                                .IdPagosComprobante = ip
                                .MontoPagos = dgvAsientoDiario.Rows(indice).Cells(4).Value
                                .NumeroRegistro = _objetoNumeroRegistro.NumeroRegistro
                            End With
                            _sqlCommands.Add(_objetoCompEgresoPagosCompCompra.NuevoRegistroCompEgresoPagosCompCompra)

                        Else
                            With _objetoPagosComprobantesCompra
                                .IdPagosComprobantes = ip
                                .FechaPagosComprobantes = dtpFechaEmisionComprobante.Value
                                .NumeroPagosComprobantes = .BuscarMayorNumeroPagosComprobantesCompra(_tipoCon, idc) + 1
                                Dim montoPagoCompras = CDec(dgvAsientoDiario.Rows(indice).Cells(4).Value) + CDec(dgvAsientoDiario.Rows(indice).Cells(5).Value)
                                .MontoPagosComprobantes = montoPagoCompras
                                .SaldoPagosComprobantes = CDec(.BuscarMayorSaldoPagosComprobantesCompraXIdComprobante(_tipoCon, idc)) - CDec(montoPagoCompras)
                                .EstadoPagosComprobantes = 1
                                .IdComprobante = idc
                                .IdProveedorGeneral = _objetoComprobantesCompra.BuscarIdProveedorXIdComprobanteCompra(_tipoCon, idc)
                                .IdComprobanteEgreso = 0
                            End With
                            _sqlCommands.Add(_objetoPagosComprobantesCompra.NuevoRegistroPagosComprobantesCompra)

                            With _objetoCompEgresoPagosCompCompra
                                .Id = lblIdComprobanteIngresoBancos.Text
                                .IdComprobanteCompra = idc
                                .IdPagosComprobante = ip
                                .MontoPagos = dgvAsientoDiario.Rows(indice).Cells(4).Value
                                .NumeroRegistro = _objetoNumeroRegistro.NumeroRegistro
                            End With
                            _sqlCommands.Add(_objetoCompEgresoPagosCompCompra.NuevoRegistroCompEgresoPagosCompCompra)

                            _dataPagosComp.Add(idc, _objetoPagosComprobantesCompra.NumeroPagosComprobantes & "-" & _objetoPagosComprobantesCompra.SaldoPagosComprobantes)
                        End If

                        ip += 1
                    End If
                Next
            End If
        End Sub

        Private Sub NuevoRegistroAsientoDiarioComprobanteIngresoBancos()
            Dim il = _objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1
            For indice = 0 To dgvAsientoDiario.RowCount - 1
                With _objetoAsientoLibroDiario
                    .IdAsiento = il
                    .FechaAsiento = dtpFechaEmisionComprobante.Value

                    .CodigoCuentaAsiento = dgvAsientoDiario.Rows(indice).Cells(0).Value.ToString.Trim
                    .NombreCuentaAsiento = dgvAsientoDiario.Rows(indice).Cells(1).Value.ToString.Trim
                    .ConceptoAsiento = dgvAsientoDiario.Rows(indice).Cells(2).Value
                    .DetalleTransaccionAsiento = dgvAsientoDiario.Rows(indice).Cells(3).Value
                    .ProvinciaAsiento = "EL ORO"
                    .CiudadAsiento = "MACHALA"
                    .ParroquiaAsiento = "MACHALA"
                    .CentroCostoAsiento = "GERENCIA ADMINISTRATIVA-FINANCIERA"
                    .ValorDebeAsiento = dgvAsientoDiario.Rows(indice).Cells(4).Value
                    .ValorHaberAsiento = dgvAsientoDiario.Rows(indice).Cells(5).Value
                    .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                    If dgvAsientoDiario.Rows(indice).Cells(4).Value > dgvAsientoDiario.Rows(indice).Cells(5).Value Then
                        .DebeHaberAsiento = 1   ' DEBE=1 / HABER=2 
                    ElseIf dgvAsientoDiario.Rows(indice).Cells(4).Value < dgvAsientoDiario.Rows(indice).Cells(5).Value Then
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

    End Class
End Namespace