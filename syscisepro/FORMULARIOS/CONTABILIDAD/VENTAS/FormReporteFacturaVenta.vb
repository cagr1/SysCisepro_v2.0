
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteFacturaVenta
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
        
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _crFacturaVenta As New CrystalReportFacturaVenta

        Private Sub ConectarReporte()
            _crFacturaVenta.SetDataSource(_objetoFacturaVenta.SeleccionarRegistrosFacturaVentaReporte(_tipoCon, CType(lblIdFacturaVenta.Text, Integer)))
            crvFacturaVenta.ReportSource = _crFacturaVenta
            crvFacturaVenta.Zoom(75)
            crvFacturaVenta.Refresh()
        End Sub

        Private Sub CargarFacturasVentaXNroFactura()
            Try
                If txtNumeroFacturaBuscar.Text.Trim().Length = 0 Then Return
                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturaVentaXNumeroFactura(_tipoCon, txtNumeroFacturaBuscar.Text)
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
                dgvFacturaVenta.Columns(0).HeaderText = "ID"
                dgvFacturaVenta.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(1).HeaderText = "ID E"
                dgvFacturaVenta.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(2).HeaderText = "NÚMERO"
                dgvFacturaVenta.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(3).HeaderText = "FECHA EMISIÓN"
                dgvFacturaVenta.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(4).HeaderText = "GUIA REMISIÓN"
                dgvFacturaVenta.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(5).HeaderText = "ID CLI"
                dgvFacturaVenta.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(6).HeaderText = "TIPO PAGO"
                dgvFacturaVenta.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(7).HeaderText = "OBSERVACIONES"
                dgvFacturaVenta.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.Columns(8).HeaderText = "SUBTOTAL 12%"
                dgvFacturaVenta.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(9).HeaderText = "SUBTOTAL  0%"
                dgvFacturaVenta.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(10).HeaderText = "DESCUENTO   "
                dgvFacturaVenta.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(11).HeaderText = "SUBTOTAL    "
                dgvFacturaVenta.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(12).HeaderText = "IVA (12%)   "
                dgvFacturaVenta.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(13).HeaderText = "TOTAL"
                dgvFacturaVenta.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                dgvFacturaVenta.Columns(14).HeaderText = "EST"
                dgvFacturaVenta.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.AutoResizeRows()
                dgvFacturaVenta.ReadOnly = False
                dgvFacturaVenta.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                MsgBox("METODO CARGAR FACTURA VENTA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub

        Private Sub CargarValores()
            Try
                lblIdFacturaVenta.Text = dgvFacturaVenta.Rows(0).Cells.Item(0).Value
                lblNumeroFacturaVenta.Text = dgvFacturaVenta.Rows(0).Cells.Item(2).Value
                lblFechaEmisionFacturaVenta.Text = Format(dgvFacturaVenta.Rows(0).Cells.Item(3).Value, "dd/MM/yyyy")
                txtSubtotal12.Text = dgvFacturaVenta.Rows(0).Cells.Item(8).Value
                txtSubtotal0.Text = dgvFacturaVenta.Rows(0).Cells.Item(9).Value
                txtDescuento.Text = dgvFacturaVenta.Rows(0).Cells.Item(10).Value
                txtSubtotal.Text = dgvFacturaVenta.Rows(0).Cells.Item(11).Value
                txtIva.Text = dgvFacturaVenta.Rows(0).Cells.Item(12).Value
                txtTotal.Text = dgvFacturaVenta.Rows(0).Cells.Item(13).Value
                dgvFacturaVenta.ClearSelection()
                dgvFacturaVenta.Rows(0).Selected = True
            Catch ex As Exception
                MsgBox("METODO MOVER REGISTRO." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub
      

        Private Sub btnBuscarAsiento_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarAsiento.Click
            cargarFacturasVentaXNroFactura()
            If dgvFacturaVenta.RowCount > 0 Then
                cargarValores()
                conectarReporte()
            Else
                MsgBox("NO SAE HA ENCONTRADO LA FACTURA INGRESADA." & vbNewLine & "POR FAVOR REVISE EL NÚMERO DE LA FACTURA", MsgBoxStyle.Information, "Mensaje de información")
            End If

        End Sub

        Private Sub txtNumeroFacturaBuscar_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNumeroFacturaBuscar.KeyDown
            If e.KeyCode = Keys.Enter Then
                cargarFacturasVentaXNroFactura()
                If dgvFacturaVenta.RowCount > 0 Then
                    cargarValores()
                    conectarReporte()
                Else
                    MsgBox("NO SAE HA ENCONTRADO LA FACTURA INGRESADA." & vbNewLine & "POR FAVOR REVISE EL NÚMERO DE LA FACTURA", MsgBoxStyle.Information, "Mensaje de información")
                End If
            End If
        End Sub

        Private Sub FormReporteFacturaVenta_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            txtNumeroFacturaBuscar.Focus()
        End Sub
    End Class
End Namespace