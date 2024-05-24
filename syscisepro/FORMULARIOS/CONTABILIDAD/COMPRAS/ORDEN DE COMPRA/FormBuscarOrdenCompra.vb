Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormBuscarOrdenCompra
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

        ReadOnly _objetoOrdenCompra As New ClassOrdenCompra
        ReadOnly _objetoDetalleOrdenCompra As New ClassDetalleOrdenCompra
        ReadOnly _objetoProveedorGeneral As New ClassProveedores
         
        Public Sub CargarOrdenCompra()
            Try
                dgvOrdenCompra.DataSource = _objetoOrdenCompra.SeleccionarRegistrosOrdenCompraAprobacion(_tipoCon)
                dgvOrdenCompra.Columns(0).HeaderText = "N°"
                dgvOrdenCompra.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(1).HeaderText = "FECHA"
                dgvOrdenCompra.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(2).HeaderText = "ID PROVEEDOR"
                dgvOrdenCompra.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(3).HeaderText = "FORMA PAGO"
                dgvOrdenCompra.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(4).HeaderText = "TIPO PAGO"
                dgvOrdenCompra.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(5).HeaderText = "OBSERVACIONES"
                dgvOrdenCompra.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(6).HeaderText = "SUBTOTAL 12"
                dgvOrdenCompra.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(7).HeaderText = "SUBTOTAL 0"
                dgvOrdenCompra.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(8).HeaderText = "DESCUENTO"
                dgvOrdenCompra.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(9).HeaderText = "IVA (12%)"
                dgvOrdenCompra.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.Columns(10).HeaderText = "TOTAL"
                dgvOrdenCompra.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvOrdenCompra.AutoResizeColumns()
                dgvOrdenCompra.AutoResizeRows()
                dgvOrdenCompra.ReadOnly = True
                dgvOrdenCompra.EditMode = DataGridViewEditMode.EditProgrammatically 
            Catch ex As Exception
                MsgBox("METODO CARGAR ORDEN DE COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
        Public Sub CargarDetalleOrdenCompra()
            Try
                dgvDetalleOrdenCompra.DataSource = _objetoDetalleOrdenCompra.SeleccionarDetalleOrdenCompraXIdOrden(_tipoCon, CLng(txtIdOrdenCompra.Text))
                dgvDetalleOrdenCompra.AutoResizeColumns()
                dgvDetalleOrdenCompra.AutoResizeRows()
                dgvDetalleOrdenCompra.Columns(0).HeaderText = "ID"
                dgvDetalleOrdenCompra.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(0).Width = 40
                dgvDetalleOrdenCompra.Columns(1).HeaderText = "ITEM"
                dgvDetalleOrdenCompra.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(1).Width = 600
                dgvDetalleOrdenCompra.Columns(2).HeaderText = "UM"
                dgvDetalleOrdenCompra.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(2).Width = 60
                dgvDetalleOrdenCompra.Columns(3).HeaderText = "CANT"
                dgvDetalleOrdenCompra.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(3).Width = 60
                dgvDetalleOrdenCompra.Columns(4).HeaderText = "V. UNITARIO"
                dgvDetalleOrdenCompra.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(4).Width = 60
                dgvDetalleOrdenCompra.Columns(5).HeaderText = "V. TOTAL"
                dgvDetalleOrdenCompra.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(5).Width = 50
                dgvDetalleOrdenCompra.Columns(6).HeaderText = "EST"
                dgvDetalleOrdenCompra.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(6).Width = 50
                dgvDetalleOrdenCompra.Columns(7).HeaderText = "ID-OC"
                dgvDetalleOrdenCompra.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleOrdenCompra.Columns(7).Width = 50

                dgvDetalleOrdenCompra.Columns(8).Visible = False
                dgvDetalleOrdenCompra.Columns(9).Visible = False
                dgvDetalleOrdenCompra.Columns(10).Visible = False
                dgvDetalleOrdenCompra.Columns(11).Visible = False
                dgvDetalleOrdenCompra.Columns(12).Visible = False

                dgvDetalleOrdenCompra.ReadOnly = True
            Catch ex As Exception
                MsgBox("METODO CARGAR DETALLE ORDEN COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub FormBuscarOrdenCompra_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    MenuStrip1.ForeColor = Color.White
                    dgvDetalleOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvDetalleOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvDetalleOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select           
        End Sub
 
        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            If txtIdOrdenCompra.Text = "..." Then Return
            Dim f = New FormReporteOrdenCompra
            f.TipoCox = TipoCox
            f.lblIdOrdenCompra.Text = txtIdOrdenCompra.Text
            f.ShowDialog()
        End Sub

        Private Sub dgvOrdenCompra_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvOrdenCompra.SelectionChanged
            If dgvOrdenCompra.RowCount = 0 Then Return
            If dgvOrdenCompra.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                txtIdOrdenCompra.Text = ""
            Else
                txtIdOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(0).Value
                txtFechaOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(1).Value
                txtNombreProveedor.Text = _objetoProveedorGeneral.BuscarNombreComercialProveedorXIdProveedor(_tipoCon, dgvOrdenCompra.CurrentRow.Cells.Item(2).Value)
                txtRucProveedor.Text = _objetoProveedorGeneral.BuscarRucProveedorXIdProveedor(_tipoCon, dgvOrdenCompra.CurrentRow.Cells.Item(2).Value)
                txtFormaPagoOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(3).Value.ToString
                txtTipoPagoOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(4).Value.ToString
                txtSubtotal12OrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(6).Value.ToString
                txtSubtotal0OrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(7).Value.ToString
                txtDescuentoOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(8).Value.ToString
                txtIvaOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(9).Value.ToString
                txtTotalOrdenCompra.Text = dgvOrdenCompra.CurrentRow.Cells.Item(10).Value.ToString
                CargarDetalleOrdenCompra()
            End If
        End Sub

        Private Sub btnRecargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecargar.Click
            CargarOrdenCompra()
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            If dgvOrdenCompra.RowCount = 0 Then DialogResult = Windows.Forms.DialogResult.Cancel
            If dgvOrdenCompra.CurrentRow Is Nothing Then DialogResult = Windows.Forms.DialogResult.Cancel
            DialogResult = Windows.Forms.DialogResult.OK
        End Sub
    End Class
End Namespace