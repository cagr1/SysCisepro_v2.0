Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmBuscarComprobanteCompraNotaCredito
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

        Public IdProveedor As Integer

        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoProveedorGeneral As New ClassProveedores

        Private Sub CargarClienteGeneral()
            Try
                Dim fechaDesde = dtpMes.Value.Day.ToString & "-" & dtpMes.Value.Month.ToString & "-" & dtpMes.Value.Year.ToString & " 00:00:00.001"
                Dim fechaHasta = DateTimePicker1.Value.Day.ToString & "-" & DateTimePicker1.Value.Month.ToString & "-" & DateTimePicker1.Value.Year.ToString & " 23:59:59.000"

                If IdProveedor <> 0 Then
                    dgvCustodios.DataSource = _objetoComprobantesCompra.SeleccionarComrpobantesCompraXRangoFechasIdProveedor(_tipoCon, IdProveedor, fechaDesde, fechaHasta)
                Else
                    dgvCustodios.DataSource = _objetoComprobantesCompra.SeleccionarComrpobantesCompraXRangoFechas(_tipoCon, fechaDesde, fechaHasta)
                End If

                For Each col As DataGridViewColumn In From col1 As DataGridViewColumn In dgvCustodios.Columns Where col1.Index > 4
                    col.Visible = False
                Next

                dgvCustodios.Columns(1).Width = 250
                dgvCustodios.Columns(2).Width = 120
                dgvCustodios.Columns(4).DefaultCellStyle.Format = "g"
                dgvCustodios.Columns(4).Width = 120
                dgvCustodios.Columns(10).Visible = True
                dgvCustodios.Columns(17).Visible = True
                dgvCustodios.Columns(20).Visible = True
                dgvCustodios.Columns(10).HeaderText = "TOTAL FACTURA"
                dgvCustodios.Columns(17).HeaderText = "TOTAL PAGAR"
                dgvCustodios.Columns(20).HeaderText = "NUM. AUTORIZACIÓN"

                dgvCustodios.AutoResizeColumns()
                dgvCustodios.AutoResizeRows()
            Catch ex As Exception
                dgvCustodios.DataSource = Nothing
            End Try
        End Sub

        Private Sub dgvCustodios_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustodios.CellDoubleClick
            If dgvCustodios.RowCount = 0 Then Return
            If e.RowIndex > -1 Then
                DialogResult = DialogResult.OK
            End If
        End Sub
       
        Private Sub FrmBuscarProgramacion_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    'Label1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'Label1.ForeColor = Color.White
                    'Label2.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    'Label2.ForeColor = Color.White
                    BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'Label1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'Label1.ForeColor = Color.White
                    'Label2.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    'Label2.ForeColor = Color.White
                    BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'Label1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'Label1.ForeColor = Color.White
                    'Label2.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'Label2.ForeColor = Color.White
                    BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
           
            dtpMes.Value = ValidationForms.FechaActual(_tipoCon)
            DateTimePicker1.Value = dtpMes.Value
            CargarClienteGeneral()
        End Sub

        Private Sub dtpMes_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dtpMes.ValueChanged, DateTimePicker1.ValueChanged
            CargarClienteGeneral()
        End Sub

    End Class
End Namespace