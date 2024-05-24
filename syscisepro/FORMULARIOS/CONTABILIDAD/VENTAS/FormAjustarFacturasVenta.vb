Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports ClassLibraryCisepro.ProcesosSql

Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAjustarFacturasVenta
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
        Dim _sqlCommands As List(Of SqlCommand)
        Public IdUsuario As Integer

        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoEmpresa As New ClassEmpresa
         
        Dim _porcentajeIva As Integer = 0
        Dim _guiaRemisionFactura As String = ""
        Dim _tipoPagoFactura As String = ""
        Dim _observacionesFactura As String = ""
        Dim _estadoFactura As Integer = 0

        Private Sub DeshabilitadoInicio()
            gbClienteGeneral.Enabled = False 
            gbBuscarFactura.Enabled = False
            gbDatosFacturaVenta.Enabled = False
            btnNuevo.Enabled = True 
            btnCancelar.Enabled = False
            btnGuardar.Enabled = False
        End Sub
        Private Sub HabilitadoNuevo()
            gbClienteGeneral.Enabled = True
            gbBuscarFactura.Enabled = True
            btnNuevo.Enabled = False 
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
        End Sub
        Private Sub LimpiarParametros()
            lblIdClienteGeneral.Text = "..."
            lblRucClienteGenral.Text = ""
            lblLlevaContabilidadClienteGeneral.Text = "..."
            txtNombreComercialCliente.Text = ""

            lblIdFacturaVenta.Text = "..."

            txtSubtotal12.Text = "0.00"
            txtSubtotal0.Text = "0.00"
            txtDescuento.Text = "0.00"
            txtSubtotal.Text = "0.00"
            txtIva.Text = "0.00"
            txtTotal.Text = "0.00"
            dgvFacturaVenta.DataSource = Nothing
        End Sub
        Private Sub CargarDatosEmpresa()
            Try
                dgvEmpresa.DataSource = _objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)

                If dgvEmpresa.RowCount > 0 Then
                    _porcentajeIva = dgvEmpresa.Rows(0).Cells(21).Value

                End If
            Catch ex As Exception
                MsgBox("CARGAR DATOS EMPRESA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub AutocompletarNombreCliente()
            Try
                txtNombreComercialCliente.AutoCompleteCustomSource = _objetoClienteGeneral.Autocompletar(_tipoCon)
                txtNombreComercialCliente.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialCliente.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialCliente.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub CargarDatosCliente()
            Try
                Dim cli = _objetoClienteGeneral.BuscarClienteGeneralXRazonSocial(_tipoCon, txtNombreComercialCliente.Text)

                If cli.Rows.Count > 0 Then
                    lblIdClienteGeneral.Text = cli.Rows(0)(0)
                    lblRucClienteGenral.Text = cli.Rows(0)(3)
                    lblLlevaContabilidadClienteGeneral.Text = cli.Rows(0)(7)
                End If
            Catch ex As Exception
                MsgBox("CARGAR DATOS CLIENTE." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub CargarFacturasVentaXIdCliente()
            Try
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaXIdCliente(_tipoCon, lblIdClienteGeneral.Text)
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
            Catch ex As Exception
                MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub CargarFacturasVentaXNroFactura()
            Try
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaXNumeroFactura(_tipoCon, txtNumeroFacturaBuscar.Text)
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
            Catch ex As Exception
                MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Private Sub FormAjustarFacturasVenta_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
            End Select
            _sqlCommands = New List(Of SqlCommand)

            cargarDatosEmpresa()
            deshabilitadoInicio()
            autocompletarNombreCliente()
        End Sub
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            habilitadoNuevo()
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            limpiarParametros()
            deshabilitadoInicio()
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If lblIdClienteGeneral.Text <> "..." And lblIdFacturaVenta.Text <> "..." Then
                If MessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR LOS CAMBIOS?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                _sqlCommands.Clear()

                ModificarFacturaVenta()

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    LimpiarParametros()
                    DeshabilitadoInicio()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema") 
            End If
        End Sub
        Private Sub dgvFacturaVenta_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvFacturaVenta.SelectionChanged
            _guiaRemisionFactura = ""
            _tipoPagoFactura = ""
            _observacionesFactura = ""
            _estadoFactura = 0
             
            If dgvFacturaVenta.CurrentRow.Cells.Item(1).Value Is DBNull.Value Then
                lblIdFacturaVenta.Text = "..."
            Else
                
                lblIdFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(0).Value
                lblTipoPagoFacturaCompra.Text = dgvFacturaVenta.CurrentRow.Cells.Item(6).Value
                lblNumeroFacturaVenta.Text = dgvFacturaVenta.CurrentRow.Cells.Item(2).Value
                dtpFechaEmisionFacturaVenta.Value = dgvFacturaVenta.CurrentRow.Cells.Item(3).Value
                _guiaRemisionFactura = dgvFacturaVenta.CurrentRow.Cells.Item(4).Value
                _tipoPagoFactura = dgvFacturaVenta.CurrentRow.Cells.Item(6).Value
                _observacionesFactura = dgvFacturaVenta.CurrentRow.Cells.Item(7).Value
                txtSubtotal12.Text = dgvFacturaVenta.CurrentRow.Cells.Item(8).Value
                txtSubtotal0.Text = dgvFacturaVenta.CurrentRow.Cells.Item(9).Value
                txtDescuento.Text = dgvFacturaVenta.CurrentRow.Cells.Item(10).Value
                txtSubtotal.Text = dgvFacturaVenta.CurrentRow.Cells.Item(11).Value
                txtIva.Text = dgvFacturaVenta.CurrentRow.Cells.Item(12).Value
                txtTotal.Text = dgvFacturaVenta.CurrentRow.Cells.Item(13).Value
                _estadoFactura = dgvFacturaVenta.CurrentRow.Cells.Item(14).Value
            End If
        End Sub
        Private Sub txtNombreComercialCliente_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialCliente.KeyDown
            If e.KeyCode <> Keys.Enter Then Return
            CargarDatosCliente()
            CargarFacturasVentaXIdCliente()
            gbBuscarFactura.Enabled = True
        End Sub
        Private Sub btnBuscarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarAsiento.Click
            cargarFacturasVentaXNroFactura()
        End Sub
         
        Private Sub ModificarFacturaVenta()
            With _objetoFacturaVenta
                .IdFactura = lblIdFacturaVenta.Text
                .IdEmpresa = 1
                .NumeroFactura = lblNumeroFacturaVenta.Text
                .FechaEmisionFactura = dtpFechaEmisionFacturaVenta.Value
                .GuiaRemisionFactura = _guiaRemisionFactura
                .IdCliente = lblIdClienteGeneral.Text
                .TipoPagoFactura = _tipoPagoFactura
                .ObservacionesFactura = _observacionesFactura
                .SubTotal12Factura = txtSubtotal12.Text
                .SubTotal0Factura = txtSubtotal0.Text
                .DescuentoFactura = txtDescuento.Text
                .SubTotalFactura = txtSubtotal.Text
                .PorcentajeIvaFactura = _porcentajeIva
                .IvaFactura = txtIva.Text
                .TotalFactura = txtTotal.Text
                .EstadoFactura = _estadoFactura
            End With
            _sqlCommands.Add(_objetoFacturaVenta.ModificarRegistroFacturaVenta)
        End Sub
         
    End Class
End Namespace