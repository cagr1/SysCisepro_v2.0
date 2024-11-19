Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormPagoComprobantesCompra
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

        Dim objetoComprobantesCompra As New ClassComprobantesCompra
        Dim objetoPagosComprobantesCompra As New ClassPagosComprobantesCompra
        Dim objetoComprobanteRetencion As New ClassComprobantesRetencion
        Dim objetoDetalleComprobantesRetencion As New ClassDetalleComprobantesRetencion
        Dim objetoProveedorGeneral As New ClassProveedores
        Dim objAuditoria As New ClassAuditoriaGeneral


        Public idComprobanteRetencion As Int64

        Public nuevoSaldo As Decimal = 0

        Public Sub deshabilitadoInicio()
            gbNuevoPagoComprobanteCompra.Enabled = False
            btnNuevo.Enabled = True
            btnModificar.Enabled = False
            btnCancelar.Enabled = False
            btnGuardar.Enabled = False 
        End Sub
        Public Sub habilitadoNuevo()
            gbNuevoPagoComprobanteCompra.Enabled = True
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True 
        End Sub
        Public Sub limpiarParametrosGeneral()
            lblIdProveedorGeneral.Text = "..."
            lblIdComprobanteCompra.Text = "..."
            lblidPagosComprobantePago.Text = "..."
            lblEstadoComprobanteCompra.Text = "..."
            lblNumeroComprobanteCompra.Text = "0"
            lblFechaComprobanteCompra.Text = ""
            lblTipoComprobanteCompra.Text = "..."
            txtSubtotalComprobanteCompra.Text = "0.00"
            txtIvaComprobanteCompra.Text = "0.00"
            txtTotalComprobanteCompra.Text = "0.00"
            txtNombreComercialProveedorGeneral.Text = ""
            txtNumeroPagosComrptobantesCompra.Text = ""
            txtAnteriorSaldoPagosComprobantesCompra.Text = "0.00"
            txtMontoPagosComprobantesCompra.Text = "0.00"
            txtNuevoSaldoPagosComprobantesCompra.Text = "0.00"
            dgvComprobantesCompra.DataSource = Nothing
            dgvPagosComprobantesCompra.DataSource = Nothing
        End Sub
        Public Sub limpiarParametrosPagos()
            lblEstadoComprobanteCompra.Text = "..."
            txtSubtotalComprobanteCompra.Text = "0.00"
            txtIvaComprobanteCompra.Text = "0.00"
            txtTotalComprobanteCompra.Text = "0.00"
            lblidPagosComprobantePago.Text = "..."
            txtNumeroPagosComrptobantesCompra.Text = ""
            txtAnteriorSaldoPagosComprobantesCompra.Text = "0.00"
            txtMontoPagosComprobantesCompra.Text = "0.00"
            txtNuevoSaldoPagosComprobantesCompra.Text = "0.00"
        End Sub
        Public Function validarParametros() As Boolean
            If lblIdProveedorGeneral.Text <> "..." And lblIdComprobanteCompra.Text <> "..." And txtNumeroPagosComrptobantesCompra.Text <> "" And _
               txtAnteriorSaldoPagosComprobantesCompra.Text <> "" And txtMontoPagosComprobantesCompra.Text <> "" And txtNuevoSaldoPagosComprobantesCompra.Text <> "" Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Sub autocompletarNombreProveedor()
            Try
                txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = objetoProveedorGeneral.Autocompletar(_tipoCon)
                txtNombreComercialProveedorGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialProveedorGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
            End Try
        End Sub
        Public Sub cargarComprobantesCompra()
            Try
                dgvComprobantesCompra.DataSource = objetoComprobantesCompra.SeleccionarComrpobantesCompraXIdProveedor(_tipoCon, lblIdProveedorGeneral.Text)
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
                dgvComprobantesCompra.Columns(10).HeaderText = "SUBTOTAL 12%"
                dgvComprobantesCompra.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(11).HeaderText = "SUBTOTAL  0%"
                dgvComprobantesCompra.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(12).HeaderText = "DESCUENTO   "
                dgvComprobantesCompra.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(13).HeaderText = "SUBTOTAL    "
                dgvComprobantesCompra.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(14).HeaderText = "IVA (12%)   "
                dgvComprobantesCompra.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(15).HeaderText = "TOTAL"
                dgvComprobantesCompra.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(16).HeaderText = "EST"
                dgvComprobantesCompra.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.AutoResizeColumns()
                dgvComprobantesCompra.AutoResizeRows()
                dgvComprobantesCompra.ReadOnly = True
            Catch ex As Exception
                MsgBox("METODO CARGAR COMPROBANTES DE COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub
        Public Sub cargarPagosComprobantesCompra()
            Try
                dgvPagosComprobantesCompra.DataSource = objetoPagosComprobantesCompra.SeleccionarPagosComrpobantesCompraXIdComprobante(_tipoCon, lblIdComprobanteCompra.Text)
                dgvPagosComprobantesCompra.Columns(0).HeaderText = "ID"
                dgvPagosComprobantesCompra.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.Columns(1).HeaderText = "NÚMERO"
                dgvPagosComprobantesCompra.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.Columns(2).HeaderText = "MONTO"
                dgvPagosComprobantesCompra.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.Columns(3).HeaderText = "SALDO"
                dgvPagosComprobantesCompra.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.Columns(4).HeaderText = "EST"
                dgvPagosComprobantesCompra.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.Columns(5).HeaderText = "ID CC"
                dgvPagosComprobantesCompra.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvPagosComprobantesCompra.AutoResizeColumns()
                dgvPagosComprobantesCompra.AutoResizeRows()
                dgvPagosComprobantesCompra.ReadOnly = False
                dgvPagosComprobantesCompra.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                MsgBox("METODO CARGAR PAGOS COMPROBANTES DE COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub
        Public Sub cargarComprobanteRetencion()
            Try
                dgvComprobanteRetencion.DataSource = objetoComprobanteRetencion.SeleccionarComrpobantesRetencionXIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
                'cantidadRegistrosComprobanteRetencion = dgvComprobanteRetencion.Rows.Count
                dgvComprobanteRetencion.AutoResizeColumns()
                dgvComprobanteRetencion.AutoResizeRows()
                dgvComprobanteRetencion.ReadOnly = False
                dgvComprobanteRetencion.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                MsgBox("METODO CARGAR COMPROBANTE DE RETENCIÓN" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub
        Public Sub cargarDetalleComprobanteRetencion()
            Try
                dgvDetalleComprobanteRetencion.DataSource = objetoDetalleComprobantesRetencion.SeleccionarRegistrosDetallesComprobanteRetencionCompraXIdComprobanteRetencion(_tipoCon, idComprobanteRetencion)
                'cantidadRegistrosDetalleComprobanteRetencion = dgvDetalleComprobanteRetencion.Rows.Count
                dgvDetalleComprobanteRetencion.AutoResizeColumns()
                dgvDetalleComprobanteRetencion.AutoResizeRows()
                dgvDetalleComprobanteRetencion.ReadOnly = False
                dgvDetalleComprobanteRetencion.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                MsgBox("METODO CARGAR DETALLE COMPROBANTE DE RETENCIÓN" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub

        Public Sub auditoria()
            Try
                With objAuditoria

                    .IdAuditoria = Convert.ToInt64(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                    .IdUsuarioAuditoria = idUsuario
                    .EstadoAuditoria = 1
                    .FechaAuditoria = Date.Now
                    .NuevaAuditoria(_tipoCon)
                End With
            Catch ex As Exception
            End Try
        End Sub
        Public Sub guardarPagosComprobantesCompra()
            With objetoPagosComprobantesCompra

                .IdPagosComprobantes = .BuscarMayorIdPagosComprobantesCompra(_tipoCon) + 1
                .NumeroPagosComprobantes = txtNumeroPagosComrptobantesCompra.Text
                .MontoPagosComprobantes = txtMontoPagosComprobantesCompra.Text
                .SaldoPagosComprobantes = txtNuevoSaldoPagosComprobantesCompra.Text
                .EstadoPagosComprobantes = 1
                .IdComprobante = lblIdComprobanteCompra.Text
                '.idProveedor = lblIdProveedorGeneral.Text
                .NuevoRegistroPagosComprobantesCompra(_tipoCon)
            End With
        End Sub
        Public Sub actualizarComprobantesCompra()
            With objetoComprobantesCompra
                .IdComprobante = lblIdComprobanteCompra.Text
                .EstadoComprobante = 2
                .ActualizarEstadoComprobanteCompra(_tipoCon)
            End With
        End Sub

        Private Sub FormPagoComprobantesCompra_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvPagosComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvPagosComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvPagosComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvComprobantesCompra.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvPagosComprobantesCompra.Font = New Font("Roboto", 8, FontStyle.Regular)
            autocompletarNombreProveedor()
            deshabilitadoInicio()
        End Sub

        Private Sub dgvComprobantesCompra_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvComprobantesCompra.CellClick
            Try
                If dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    lblIdComprobanteCompra.Text = "..."
                Else
                    lblIdComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value
                    lblTipoComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(2).Value
                    lblNumeroComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(3).Value
                    lblFechaComprobanteCompra.Text = Format(dgvComprobantesCompra.CurrentRow.Cells.Item(6).Value, "dd/MM/yyyy")
                    txtSubtotal12.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(10).Value
                    txtSubtotal0.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(11).Value
                    txtDescuento.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(12).Value
                    txtSubtotalComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(13).Value
                    txtIvaComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(14).Value
                    txtTotalComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(15).Value
                    If dgvComprobantesCompra.CurrentRow.Cells.Item(16).Value = 1 Then
                        lblEstadoComprobanteCompra.Text = "POR PAGAR"
                    ElseIf dgvComprobantesCompra.CurrentRow.Cells.Item(16).Value = 2 Then
                        lblEstadoComprobanteCompra.Text = "CANCELADO"
                    End If
                    dgvComprobantesCompra.Rows(dgvComprobantesCompra.CurrentCell.RowIndex.ToString()).Selected = True
                    cargarComprobanteRetencion()
                    cargarPagosComprobantesCompra()
                    If dgvComprobanteRetencion.RowCount > 0 Then
                        idComprobanteRetencion = dgvComprobanteRetencion.Rows(0).Cells.Item(0).Value
                        lblNumeroComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(1).Value
                        lblFechaComprobanteRetencion.Text = Format(dgvComprobanteRetencion.Rows(0).Cells.Item(4).Value, "dd/MM/yyyy")
                        txtTotalComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(8).Value
                    Else
                        idComprobanteRetencion = 0
                        lblNumeroComprobanteRetencion.Text = "0"
                        lblFechaComprobanteRetencion.Text = "00/00/0000"
                        txtTotalComprobanteRetencion.Text = "0.00"
                    End If
                    cargarDetalleComprobanteRetencion()
                    If dgvDetalleComprobanteRetencion.RowCount > 0 Then
                        For indiceDetalle = 0 To dgvDetalleComprobanteRetencion.RowCount - 1
                            If dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells.Item(4).Value = "RENTA" Then
                                txtValorRetencionFuente.Text = dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells.Item(6).Value
                            End If
                            If dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells.Item(4).Value = "IVA" Then
                                txtValorRetencionIVA.Text = dgvDetalleComprobanteRetencion.Rows(indiceDetalle).Cells.Item(6).Value
                            End If
                        Next
                    Else
                        txtValorRetencionFuente.Text = "0.00"
                        txtValorRetencionIVA.Text = "0.00"
                    End If
                End If
            Catch ex As Exception
            End Try
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            If dgvComprobantesCompra.RowCount > 0 And lblIdComprobanteCompra.Text <> "..." Then
                If dgvComprobantesCompra.CurrentRow.Cells.Item(16).Value = 2 Then
                    MsgBox("ESTE COMPROBANTE DE PAGO YA ESTA CANCELADO." & vbNewLine & "POR FAVOR SELECCIONE OTRO COMPROBANTE", MsgBoxStyle.Exclamation, "Mensaje de validación")
                ElseIf lblEstadoComprobanteCompra.Text = "POR PAGAR" Then
                    habilitadoNuevo()
                    '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= ID DE PAGO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                    lblidPagosComprobantePago.Text = objetoPagosComprobantesCompra.BuscarMayorIdPagosComprobantesCompra(_tipoCon) + 1
                    '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= NUMERO DE PAGO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

                    txtNumeroPagosComrptobantesCompra.Text = objetoPagosComprobantesCompra.BuscarMayorNumeroPagosComprobantesCompra(_tipoCon, lblIdComprobanteCompra.Text) + 1
                    If dgvPagosComprobantesCompra.RowCount = 0 Then
                        txtAnteriorSaldoPagosComprobantesCompra.Text = CDec(txtTotalComprobanteCompra.Text) - CDec(txtTotalComprobanteRetencion.Text)
                    Else
                        txtAnteriorSaldoPagosComprobantesCompra.Text = dgvPagosComprobantesCompra.Rows(dgvPagosComprobantesCompra.RowCount - 1).Cells(3).Value
                    End If
                End If
            Else
                MsgBox("NO HA SELECCIONA UN COMPROBANTE DE COMPRA PARA REVISAR", MsgBoxStyle.Information, "Mensaje de validación")
            End If
        End Sub
    
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            limpiarParametrosGeneral()
            deshabilitadoInicio()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If validarParametros() = True Then
                guardarPagosComprobantesCompra()
                If nuevoSaldo = 0 Then
                    actualizarComprobantesCompra()
                    cargarComprobantesCompra()
                    dgvPagosComprobantesCompra.DataSource = Nothing
                Else
                    cargarComprobantesCompra()
                    cargarPagosComprobantesCompra()
                End If
                deshabilitadoInicio()
                limpiarParametrosPagos()
            Else
                MsgBox("No se puede guardar." & vbNewLine & "NO SE HAN LLENADO TODOS LOS PARAMETROS NECESARIOS", MsgBoxStyle.Exclamation, "Mensaje de validación")
            End If
        End Sub
    
        Private Sub txtNombreComercialProveedorGeneral_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialProveedorGeneral.KeyDown
            If e.KeyCode = Keys.Enter Then

                lblIdProveedorGeneral.Text = objetoProveedorGeneral.BuscarIdProveedorXRazonSocialProveedor(_tipoCon, txtNombreComercialProveedorGeneral.Text)
                cargarComprobantesCompra()
            End If
        End Sub

        Private Sub txtMontoPagosComprobantesCompra_Validated(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtMontoPagosComprobantesCompra.Validated
            Try
                nuevoSaldo = 0
                If CDec(txtMontoPagosComprobantesCompra.Text) <= CDec(txtAnteriorSaldoPagosComprobantesCompra.Text) Then
                    nuevoSaldo = CDec(txtAnteriorSaldoPagosComprobantesCompra.Text) - CDec(txtMontoPagosComprobantesCompra.Text)
                    txtNuevoSaldoPagosComprobantesCompra.Text = nuevoSaldo
                    If nuevoSaldo = 0 Then
                        MsgBox("EL MONTO CUBRE EL TOTAL DEL SALDO." & vbNewLine & " COMPROBANTE CANCELADO", MsgBoxStyle.Information, "Mensaje de información")
                    End If
                Else
                    MsgBox("EL MONTO A PAGAR ES MAYOR QUE EL SALDO.", MsgBoxStyle.Critical, "Mensaje de validación")
                    txtMontoPagosComprobantesCompra.Text = "0,00"
                    txtNuevoSaldoPagosComprobantesCompra.Text = "0,00"
                End If
            Catch ex As Exception
                MsgBox("TXTMONTO VALIDATED." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub
    End Class
End Namespace