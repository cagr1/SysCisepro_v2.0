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
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports Krypton.Toolkit


Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAjustarComprobantesRetencionCompras

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
        Dim _sqlCommands As List(Of SqlCommand)

        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoPagosComprobantesCompra As New ClassPagosComprobantesCompra
        ReadOnly _objetoNumeroRegistroAsientoCompCompra As New ClassNumeroRegistroAsientoComprobanteCompra
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoAjustarAsientos As New ClassAjustarAsientosLibroDiario
        ReadOnly _objetoComprobanteRetencion As New ClassComprobantesRetencion
        ReadOnly _objetoDetalleComprobantesRetencion As New ClassDetalleComprobantesRetencion
        ReadOnly _objetoProveedorGeneral As New ClassProveedores

        ReadOnly _objetoImpuestos As New ClassImpuestos
        ReadOnly _objetoConceptos As New ClassConceptosPago
        ReadOnly _objetoPorcentajes As New ClassPorcentajes
        ReadOnly _objetoContribuyente As New ClassContribuyenteRetenido


        Private Sub FormAjustarComprobantesRetencionCompras_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
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
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobanteRetencion.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvComprobantesCompra.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvComprobanteRetencion.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)

            dtpMes.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
             
            AutocompletarNombreProveedor()
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
            Try
                lblIdProveedorGeneral.Text = _objetoProveedorGeneral.BuscarIdProveedorXRazonSocialProveedor(_tipoCon, txtNombreComercialProveedorGeneral.Text)
                lblRucProveedorGeneral.Text = _objetoProveedorGeneral.BuscarRucProveedorXIdProveedor(_tipoCon, lblIdProveedorGeneral.Text)
                EsContrbuyenteEspecial.Text = _objetoProveedorGeneral.BuscarSiContribuyenteEspecialXIdProveedor(_tipoCon, lblIdProveedorGeneral.Text)
                  
                CargarComprobantesCompra()
            Catch 
                lblIdProveedorGeneral.Text = "..."
                lblRucProveedorGeneral.Text = "..."
                EsContrbuyenteEspecial.Text = "..." 
            End Try 
        End Sub
        Private Sub CargarComprobantesCompra()
            LimpiarParametrosRetencion()
            dgvPagosFacturaCompra.DataSource = Nothing
            dgvAsientoDiarioCompra.DataSource = Nothing

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
            Catch ex As Exception
                dgvComprobantesCompra.DataSource = Nothing
                dgvComprobanteRetencion.DataSource = Nothing
                dgvDetalleComprobanteRetencion.DataSource = Nothing
                dgvPagosFacturaCompra.DataSource = Nothing
                dgvAsientoDiarioCompra.DataSource = Nothing
            End Try
        End Sub
        Private Sub LimpiarParametrosRetencion()
            lblIdComprobanteRetencion.Text = "..."
            txtNumeroComprobanteRetencion.Text = ""
            txtNumAutoSRIComprobanteRetencion.Text = "" 
            txtTotalComprobanteRetencion.Text = "0.00"
            dgvComprobanteRetencion.DataSource = Nothing
            dgvDetalleComprobanteRetencion.DataSource = Nothing
        End Sub
        Private Sub dtpMes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpMes.ValueChanged
            CargarComprobantesCompra()
        End Sub
        Private Sub dgvComprobantesCompra_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvComprobantesCompra.CellDoubleClick
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
        Private Sub dgvComprobantesCompra_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobantesCompra.SelectionChanged
            LimpiarParametrosRetencion()
            dgvPagosFacturaCompra.DataSource = Nothing
            dgvAsientoDiarioCompra.DataSource = Nothing

            Try 
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

                CargarPagosComprobanteCompra()
                CargarComprobanteRetencion()

                Dim nr = _objetoNumeroRegistroAsientoCompCompra.BuscarNumeroRegistroAsientoPorIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
                If nr = 0 Then
                    nr = _objetoNumeroRegistroAsientoCompCompra.BuscarNumeroRegistroAsientoPorNoComprobanteCompra(_tipoCon, lblNumeroComprobanteCompra.Text)
                End If
                lblNumeroRegistroVenta.Text = nr
                dgvAsientoDiarioCompra.DataSource = _objetoAjustarAsientos.BuscarAsientosLibroDiarioXNumeroRegistro(_tipoCon, lblNumeroRegistroVenta.Text)
            Catch 
                lblIdComprobanteCompra.Text = "..."
                lblTipoComprobanteCompra.Text = "..."
                lblNumeroComprobanteCompra.Text = "0"
                lblFechaComprobanteCompra.Text = "00/00/0000"
                dtpFechaEmisionComprobanteCompra.Value = DateTime.Now
                txtSubtotal12.Text = "0.00"
                txtSubtotal0.Text = "0.00"
                txtDescuento.Text = "0.00"
                txtSubtotalComprobanteCompra.Text = "0.00"
                txtIvaComprobanteCompra.Text = "0.00"
                txtTotalComprobanteCompra.Text = "0.00"
                lblEstadoComprobanteCompra.Text = "0"

                LimpiarParametrosRetencion()
                dgvPagosFacturaCompra.DataSource = Nothing
                dgvAsientoDiarioCompra.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarPagosComprobanteCompra()
            Try
                dgvPagosFacturaCompra.DataSource = _objetoPagosComprobantesCompra.SeleccionarPagosComrpobantesCompraXIdComprobante(_tipoCon, lblIdComprobanteCompra.Text)
            Catch
                dgvPagosFacturaCompra.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarComprobanteRetencion()
            LimpiarParametrosRetencion()
            Try
                dgvComprobanteRetencion.DataSource = _objetoComprobanteRetencion.SeleccionarComrpobantesRetencionXIdComprobanteCompra(_tipoCon, lblIdComprobanteCompra.Text)
                dgvComprobanteRetencion.Columns(0).HeaderText = "ID"
                dgvComprobanteRetencion.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(1).HeaderText = "ID CLI"
                dgvComprobanteRetencion.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(2).HeaderText = "NRO"
                dgvComprobanteRetencion.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(3).HeaderText = "NRO AUTO SRI"
                dgvComprobanteRetencion.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(4).HeaderText = "FECHA"
                dgvComprobanteRetencion.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(5).HeaderText = "TIPO COMP"
                dgvComprobanteRetencion.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(6).HeaderText = "NRO COMP"
                dgvComprobanteRetencion.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(7).HeaderText = "VALOR"
                dgvComprobanteRetencion.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(8).HeaderText = "EST"
                dgvComprobanteRetencion.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.Columns(9).HeaderText = "ID FAC"
                dgvComprobanteRetencion.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvComprobanteRetencion.ReadOnly = True
                dgvComprobanteRetencion.AutoResizeColumns()
                dgvComprobanteRetencion.AutoResizeRows()
                dgvComprobanteRetencion.Columns(1).Visible = False
                dgvComprobanteRetencion.Columns(3).Width = 175
                dgvComprobanteRetencion.Columns(4).Width = 125       
            Catch
                LimpiarParametrosRetencion()
            End Try
        End Sub
        Private Sub dgvComprobanteRetencion_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvComprobanteRetencion.SelectionChanged
            Try
                lblIdComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(0).Value
                txtNumeroComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(1).Value
                txtNumAutoSRIComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(2).Value
                dtpComprobanteRetencion.Value = (Format(dgvComprobanteRetencion.Rows(0).Cells.Item(4).Value, "dd/MM/yyyy")) 

                txtTotalComprobanteRetencion.Text = dgvComprobanteRetencion.Rows(0).Cells.Item(8).Value

                CargarDetalleComprobanteRetencion()
                CalcularTotalRetencion()
            Catch
                LimpiarParametrosRetencion()
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
                dgvDetalleComprobanteRetencion.Columns(7).Visible = False
                dgvDetalleComprobanteRetencion.Columns(8).Visible = False
                dgvDetalleComprobanteRetencion.Columns(9).Visible = False
                dgvDetalleComprobanteRetencion.AutoResizeColumns()
                dgvDetalleComprobanteRetencion.AutoResizeRows()
                dgvDetalleComprobanteRetencion.ReadOnly = True
            Catch ex As Exception
                dgvDetalleComprobanteRetencion.DataSource = Nothing
            End Try
        End Sub 
        Private Sub CalcularTotalRetencion()
            Dim acumulador = 0.0
            Try
                For indice = 0 To dgvDetalleComprobanteRetencion.RowCount - 1
                    acumulador += Math.Round(CDec(dgvDetalleComprobanteRetencion.Rows(indice).Cells(6).Value), 2, MidpointRounding.AwayFromZero)
                Next
                txtTotalComprobanteRetencion.Text = Math.Round(acumulador, 2, MidpointRounding.AwayFromZero)
            Catch
                txtTotalComprobanteRetencion.Text = acumulador
            End Try
        End Sub
        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
            If dgvComprobantesCompra.RowCount = 0 Then
                'MessageBox.Show("DEBE ESCOGER UNA FACTURA!", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                KryptonMessageBox.Show("Debe escoger una factura!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            If lblIdComprobanteCompra.Text <> "..." And lblIdComprobanteRetencion.Text <> "..." Then
                'If MessageBox.Show("SI ANULA LA RETENCIÓN DE ESTA FACTRURA SE MODIFICARÁ EL ASIENTO Y LOS PAGOS CORRESPONDIETNES, DESEA ANULARLA?", "REGISTRAR RETENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If KryptonMessageBox.Show("Si anula la retención de esta factrura se modificará el asiento y los pagos correspondientes", "Mensaje del sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) = DialogResult.No Then
                    Return
                End If
                _sqlCommands.Clear()

                Dim idasientoCuenta = 0
                Dim valorCuenta = 0.0
                For Each row As DataGridViewRow In dgvAsientoDiarioCompra.Rows
                    If (row.Cells(2).Value.ToString().StartsWith("20103") And CDec(row.Cells(7).Value) > 0) Then
                        idasientoCuenta = row.Cells(0).Value.ToString()
                        valorCuenta = CDec(row.Cells(7).Value)
                    End If
                    If (row.Cells(2).Value.ToString().StartsWith("201070101") Or
                        row.Cells(2).Value.ToString().StartsWith("201070102")) And row.Cells(3).Value.ToString().Contains("RETEN") Then
                        With _objetoAsientoLibroDiario
                            .IdAsiento = row.Cells(0).Value.ToString().Trim()
                        End With
                        _sqlCommands.Add(_objetoAsientoLibroDiario.AnularAsientoLibroDiarioXIdRegistro)
                    End If
                Next

                ' sumar a la cuenta por cobrar
                With _objetoAsientoLibroDiario
                    .IdAsiento = idasientoCuenta
                    .ValorHaberAsiento = valorCuenta + CDec(txtTotalComprobanteRetencion.Text.Trim())
                End With
                _sqlCommands.Add(_objetoAsientoLibroDiario.SumarHaberRetencionAsientoLibroDiarioXIdRegistro)


                ' anular retencion
                With _objetoComprobanteRetencion
                    .IdComprobanteCompra = lblIdComprobanteCompra.Text
                End With
                _sqlCommands.Add(_objetoComprobanteRetencion.AnularComprobanteRetencionVentaByIdCompra)

                '        ' anular detalle retencion
                With _objetoDetalleComprobantesRetencion
                    .IdComprobanteCompra = lblIdComprobanteCompra.Text
                End With
                _sqlCommands.Add(_objetoDetalleComprobantesRetencion.AnularDetalleComprobanteRetencionVentaByIdCompra)

                ' anular pago retencion
                If dgvPagosFacturaCompra.RowCount > 0 Then
                    If dgvPagosFacturaCompra.RowCount = 1 Then
                        With _objetoPagosComprobantesCompra
                            .IdComprobante = lblIdComprobanteCompra.Text
                            .SaldoPagosComprobantes = CDec(txtTotalComprobanteCompra.Text)
                        End With
                        _sqlCommands.Add(_objetoPagosComprobantesCompra.RestarPagoRetencionFacturaCompraByIdComprobanteCompra)
                    Else
                        Dim idpago = 0
                        For Each row As DataGridViewRow In dgvPagosFacturaCompra.Rows
                            If CDec(row.Cells(3).Value) = CDec(txtTotalComprobanteRetencion.Text) And CDec(row.Cells(8).Value) = 0 Then
                                idpago = row.Cells(0).Value.ToString()
                            End If
                        Next
                        With _objetoPagosComprobantesCompra
                            .IdComprobante = lblIdComprobanteCompra.Text
                        End With
                        _sqlCommands.Add(_objetoPagosComprobantesCompra.AnularPagoRetencionFacturaCompraByIdComprobanteCompra)
                    End If
                End If


                Dim nombreU As String = "ANULAR COMPROBANTE RETENCION COMPRA " & UserName
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    LimpiarParametrosRetencion()
                    dgvComprobantesCompra_SelectionChanged(Nothing, Nothing)
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If

            Else


                KryptonMessageBox.Show("La factura seleccionada no tiene registrado un comprobante de retención!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub lblIdComprobanteRetencion_Click(sender As Object, e As EventArgs) Handles lblIdComprobanteRetencion.Click

        End Sub
    End Class
End Namespace