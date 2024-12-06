Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.USUARIOS_DEL_SISTEMA
Imports Krypton.Toolkit

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAjustarComprobantesCompra
        Private _tipoCon As TipoConexion
        Public UserName As String
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

        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoProveedorGeneral As New ClassProveedores
        ReadOnly _objUser As New ClassUsuarioGeneral

        Dim _sqlCommands As List(Of SqlCommand)

        Private Sub FormAjustarComprobantesCompra_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            _sqlCommands = New List(Of SqlCommand)
            dgvComprobantesCompra.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            AutocompletarNombreProveedor()
            DeshabilitadoInicio()
        End Sub 
        Private Sub DeshabilitadoInicio()

            'gbNombreComercialProveedor.Enabled = True
            txtNombreComercialProveedorGeneral.Enabled = True

            'gbDatosComprobanteCompra.Enabled = False
            txtNumeroComprobanteCompra.Enabled = False
            txtNumAutoSRIComprobanteCompra.Enabled = False
            dtpFechaAutoSRIComprobanteCompra.Enabled = False
            dtpFechaEmisionComprobanteCompra.Enabled = False

            'gbValoresComprobanteCompra.Enabled = False
            txtSubtotal12FacturaCompra.Enabled = False
            txtSubtotal0FacturaCompra.Enabled = False
            txtDescuentoFacturaCompra.Enabled = False
            txtSubTotalComprobanteCompra.Enabled = False
            txtIvaComprobanteCompra.Enabled = False
            txtTotalComprobanteCompra.Enabled = False

            txtGuiaRemisionComprobanteCompra.Enabled = False
            txtDocModComprobanteCompra.Enabled = False
            txtRazModComprobanteCompra.Enabled = False
            txtObservacionesComprobantesCompra.Enabled = False
        End Sub

        Private Sub txtNombreComercialProveedorGeneral_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialProveedorGeneral.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            lblIdProveedorGeneral.Text = _objetoProveedorGeneral.BuscarIdProveedorXRazonSocialProveedor(_tipoCon, txtNombreComercialProveedorGeneral.Text)
            CargarComprobantesCompra()
        End Sub
        Private Sub CargarComprobantesCompra()
            Try
                dgvComprobantesCompra.DataSource = _objetoComprobantesCompra.SeleccionarComrpobantesCompraXIdProveedor(_tipoCon, lblIdProveedorGeneral.Text)
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
                dgvComprobantesCompra.Columns(10).HeaderText = "OBSERVACIONES"
                dgvComprobantesCompra.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(11).HeaderText = "SUBTOTAL 12%"
                dgvComprobantesCompra.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(12).HeaderText = "SUBTOTAL  0%"
                dgvComprobantesCompra.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(13).HeaderText = "DESCUENTO   "
                dgvComprobantesCompra.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(14).HeaderText = "SUBTOTAL    "
                dgvComprobantesCompra.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(15).HeaderText = "% IVA"
                dgvComprobantesCompra.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(16).HeaderText = "VALOR IVA"
                dgvComprobantesCompra.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(17).HeaderText = "TOTAL"
                dgvComprobantesCompra.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.Columns(18).HeaderText = "EST"
                dgvComprobantesCompra.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobantesCompra.AutoResizeColumns()
                dgvComprobantesCompra.AutoResizeRows()
                dgvComprobantesCompra.ReadOnly = False
                dgvComprobantesCompra.EditMode = DataGridViewEditMode.EditProgrammatically

                btnModificar.Enabled = dgvComprobantesCompra.RowCount > 0 And dgvComprobantesCompra.CurrentRow IsNot Nothing
            Catch ex As Exception
                dgvComprobantesCompra.DataSource = Nothing
                'MsgBox("METODO CARGAR COMPROBANTES DE COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Metodo cargar comprobantes de compra" & vbNewLine & ex.Message.ToString, "Mensaje de excepción")
            End Try
        End Sub
        Private Sub dgvComprobantesCompra_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobantesCompra.SelectionChanged
            If dgvComprobantesCompra.RowCount = 0 Then Return
            If dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdComprobanteCompra.Text = "..."
            Else
                lblIdComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(0).Value
                txtTipoComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(2).Value
                txtNumeroComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(3).Value
                txtNumAutoSRIComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(4).Value
                dtpFechaAutoSRIComprobanteCompra.Value = dgvComprobantesCompra.CurrentRow.Cells.Item(5).Value
                dtpFechaEmisionComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(6).Value
                txtGuiaRemisionComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(7).Value
                txtDocModComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(8).Value
                txtRazModComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(9).Value
                txtObservacionesComprobantesCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(10).Value
                txtSubtotal12FacturaCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(11).Value
                txtSubtotal0FacturaCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(12).Value
                txtDescuentoFacturaCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(13).Value
                txtSubTotalComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(14).Value
                lblPorcentajeIVA.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(15).Value
                txtIvaComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(16).Value
                txtTotalComprobanteCompra.Text = dgvComprobantesCompra.CurrentRow.Cells.Item(17).Value
                If dgvComprobantesCompra.CurrentRow.Cells.Item(18).Value = 1 Then
                    lblEstadoComprobanteCompra.Text = "POR PAGAR"
                ElseIf dgvComprobantesCompra.CurrentRow.Cells.Item(18).Value = 2 Then
                    lblEstadoComprobanteCompra.Text = "CANCELADO"
                ElseIf dgvComprobantesCompra.CurrentRow.Cells.Item(18).Value = 10 Then
                    lblEstadoComprobanteCompra.Text = "FONDO ROTATIVO"
                ElseIf dgvComprobantesCompra.CurrentRow.Cells.Item(18).Value = 11 Then
                    lblEstadoComprobanteCompra.Text = "CAJA CHICA"
                End If

            End If
        End Sub
       
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificar.Click
            HabilitadoNuevo()
        End Sub
        Private Sub HabilitadoNuevo()
            'gbNombreComercialProveedor.Enabled = True
            txtNombreComercialProveedorGeneral.Enabled = True
            'gbDatosComprobanteCompra.Enabled = True
            txtNumeroComprobanteCompra.Enabled = True
            txtNumAutoSRIComprobanteCompra.Enabled = True
            dtpFechaAutoSRIComprobanteCompra.Enabled = True
            dtpFechaEmisionComprobanteCompra.Enabled = True

            txtGuiaRemisionComprobanteCompra.Enabled = True
            txtDocModComprobanteCompra.Enabled = True
            txtRazModComprobanteCompra.Enabled = True
            txtObservacionesComprobantesCompra.Enabled = True
            txtTipoComprobanteCompra.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True 
        End Sub
        Private Sub LimpiarParametrosGeneral()
            lblIdComprobanteCompra.Text = "..."
            txtGuiaRemisionComprobanteCompra.Text = "000"
            txtDocModComprobanteCompra.Text = "000"
            txtRazModComprobanteCompra.Text = "..."
            txtNumeroComprobanteCompra.Text = ""
            txtNumAutoSRIComprobanteCompra.Text = ""
            txtSubtotal12FacturaCompra.Text = "0.00"
            txtSubtotal0FacturaCompra.Text = "0.00"
            txtDescuentoFacturaCompra.Text = "0.00"
            txtSubTotalComprobanteCompra.Text = "0.00"
            txtIvaComprobanteCompra.Text = "0.00"
            txtTotalComprobanteCompra.Text = "0.00"
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
        Private Function ValidacionParametros() As Boolean
            Return txtNombreComercialProveedorGeneral.Text <> "" And txtNumeroComprobanteCompra.Text <> "" And txtNumAutoSRIComprobanteCompra.Text <> "" _
               And txtSubtotal12FacturaCompra.Text <> "" And txtSubtotal0FacturaCompra.Text <> "" And txtDescuentoFacturaCompra.Text <> "" _
               And txtIvaComprobanteCompra.Text <> "" And txtSubTotalComprobanteCompra.Text <> "" And txtTotalComprobanteCompra.Text <> ""
        End Function
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            limpiarParametrosGeneral()
            deshabilitadoInicio()
            lblIdProveedorGeneral.Text = "..."
            txtNombreComercialProveedorGeneral.Text = ""
            dgvComprobantesCompra.DataSource = Nothing
            btnModificar.Enabled = True
            btnCancelar.Enabled = False
            btnGuardar.Enabled = False
        End Sub
        Private Function ValidarFecha()
            Dim fechaActual As DateTime = Date.Now
            Dim fechaCompra = New Date(dtpFechaEmisionComprobanteCompra.Value.Year, dtpFechaEmisionComprobanteCompra.Value.Month, dtpFechaEmisionComprobanteCompra.Value.Day) ' establece la fecha actual de ingreso (año,mes,dia)
            Dim mesFechaMaxima As Integer
            Dim mesFechaCompra As Integer

            If dtpFechaEmisionComprobanteCompra.Value.Month = 12 Then
                mesFechaMaxima = 1
                mesFechaCompra = 0
            Else
                mesFechaMaxima = CInt(dtpFechaEmisionComprobanteCompra.Value.Month) + 1
                mesFechaCompra = fechaCompra.Month
            End If

            Dim fechaMaximaIngreso = New Date(Date.Now.Year, mesFechaMaxima, 25) ' establece la fecha maxima de ingreso (año,mes,dia)
            If fechaActual > fechaMaximaIngreso And mesFechaCompra < mesFechaMaxima Then
                'MsgBox("¯\_(ツ)_/¯ despues del 25 no se aceptan facturas del mes anterior")
                KryptonMessageBox.Show("Despues del 25 no se aceptan facturas del mes anterior", "Mensaje de validación")
                Return False
            ElseIf fechaCompra > fechaActual Then
                'MsgBox("¯\_(ツ)_/¯ no es la maquina del tiempo no puede ingresar fechas futuras")
                KryptonMessageBox.Show("No puede ingresar fechas futuras", "Mensaje de validación")
                Return False
            Else
                Return True
            End If
        End Function
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If ValidarFecha() Then
                If ValidacionParametros() Then

                    'If MessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR EL COMPROBANTE?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                    If KryptonMessageBox.Show("¿Esta segura que desea guardar el comprobante?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                    _sqlCommands.Clear()

                    ModificarComprobanteCompra()


                    Dim nombreU As String = "AJUSTAR COMPROBANTE COMPRA " & UserName
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                    If res(0) Then

                        btnModificar.Enabled = True
                        btnCancelar.Enabled = False
                        btnGuardar.Enabled = False

                        LimpiarParametrosGeneral()
                        DeshabilitadoInicio()
                        CargarComprobantesCompra()
                        KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)

                    Else
                        KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If


                Else
                    'MsgBox("NO SE PUEDE MODIFICAR. NO HA LLENADO TODOS LOS PARAMETROS NECESARIOS", MsgBoxStyle.Information, "Mensaje de validación")
                    KryptonMessageBox.Show("No se puede modificar. No ha llenado todos los parametros necesarios", "Mensaje de validación")
                End If
            End If
        End Sub
        Private Sub ModificarComprobanteCompra()
            With _objetoComprobantesCompra
                .IdComprobante = lblIdComprobanteCompra.Text
                .IdProveedorGeneral = lblIdProveedorGeneral.Text
                .TipoComprobante = txtTipoComprobanteCompra.Text
                .NumeroComprobante = txtNumeroComprobanteCompra.Text
                .NumAutoSriComprobante = txtNumAutoSRIComprobanteCompra.Text
                .FechaAutoSriComprobante = dtpFechaAutoSRIComprobanteCompra.Value
                .FechaEmisionComprobante = dtpFechaEmisionComprobanteCompra.Value
                .GuiaRemisionComprobante = txtGuiaRemisionComprobanteCompra.Text
                .DocModComprobante = txtDocModComprobanteCompra.Text
                .RazModComprobante = txtRazModComprobanteCompra.Text
                .ObservacionComprobante = txtObservacionesComprobantesCompra.Text
                .Subtotal12Comprobante = txtSubtotal12FacturaCompra.Text
                .Subtotal0Comprobante = txtSubtotal0FacturaCompra.Text
                .DescuentoComprobante = txtDescuentoFacturaCompra.Text
                .SubtotalComprobante = txtSubTotalComprobanteCompra.Text
                .PorcentajeIvaComprobante = lblPorcentajeIVA.Text
                .IvaComprobante = txtIvaComprobanteCompra.Text
                .TotalComprobante = txtTotalComprobanteCompra.Text
                If lblEstadoComprobanteCompra.Text = "POR PAGAR" Then
                    .EstadoComprobante = 1
                ElseIf lblEstadoComprobanteCompra.Text = "CANCELADO" Then
                    .EstadoComprobante = 2
                ElseIf lblEstadoComprobanteCompra.Text = "FONDO ROTATIVO" Then
                    .EstadoComprobante = 10
                ElseIf lblEstadoComprobanteCompra.Text = "CAJA CHICA" Then
                    .EstadoComprobante = 11
                Else
                    .EstadoComprobante = 1
                End If
            End With
            _sqlCommands.Add(_objetoComprobantesCompra.ModificarRegistroComprobanteCompra)
        End Sub
        
        Private Sub txtNombreComercialProveedorGeneral_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreComercialProveedorGeneral.TextChanged

        End Sub

        Private Sub txtIvaComprobanteCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIvaComprobanteCompra.TextChanged

        End Sub

        Private Sub txtTotalComprobanteCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalComprobanteCompra.TextChanged

        End Sub
    End Class
End Namespace
