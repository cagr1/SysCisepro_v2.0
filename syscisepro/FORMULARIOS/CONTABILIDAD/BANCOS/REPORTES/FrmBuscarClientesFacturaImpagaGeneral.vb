
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmBuscarClientesFacturaImpagaGeneral
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

        ReadOnly _objCliente As New ClassClienteGeneral

        Private Sub CargarClienteGeneral(ByVal parametroBusqueda As String)
            Try
                dgvDebitos.Rows.Clear()
                'Dim fechaDesde = dtpFechaDesde.Value.Year.ToString & "/" & dtpFechaDesde.Value.Month.ToString & "/" & dtpFechaDesde.Value.Day.ToString & " 00:00:00"
                'Dim fechaHasta = dtpFechaHasta.Value.Year.ToString & "/" & dtpFechaHasta.Value.Month.ToString & "/" & dtpFechaHasta.Value.Day.ToString & " 23:59:59"

                Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00"
                Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59"

                Dim datos As DataTable = _objCliente.CargarClienteGeneralFacturasPorCobrar(_tipoCon, parametroBusqueda, fechaDesde, fechaHasta)

                For Each row As DataRow In datos.Rows

                    Dim tc = If(row(10).ToString.Contains("TARJETA"), "TJ TARJETA DE CRÉDITO",
                                If(row(11).ToString.Trim.Contains("025 BANCO DE MACHALA"),
                                   "CU CUENTA PROPIA", "CO COBRO O PAGOS INTERBANCARIOS"))

                    dgvDebitos.Rows.Add(
                                    row(0).ToString.Trim,
                                    row(2).ToString.Trim,
                                    row(15).ToString.Trim,
                                    row(13).ToString.Trim,
                                    row(14).ToString.Trim,
                                    ("FAC " + row(16).ToString + " " + row(8).ToString + "-" + row(9).ToString),
                                    tc,
                                    row(11).ToString.Trim,
                                    row(10).ToString.Trim,
                                    row(12).ToString.Trim,
                                    "COM PAGO POR CONCEPTO DE COMISIONES",
                                    row(4).ToString,
                                    row(16).ToString,
                                    Math.Round(CDec(row(6).ToString), 2),
                                    Math.Round(CDec(row(7).ToString), 2),
                                    Math.Round(CDec(row(17).ToString), 2))
                Next

                dgvDebitos.AutoResizeRows()

            Catch ex As Exception
                dgvDebitos.DataSource = Nothing
            End Try
        End Sub

        Private Sub txtParametrobusqueda_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtParametrobusqueda.KeyUp
            CargarClienteGeneral(txtParametrobusqueda.Text.Trim)
        End Sub

        Private Sub dtpFechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dtpFechaDesde.ValueChanged
            cargarClienteGeneral(txtParametrobusqueda.Text.Trim)
        End Sub

        Private Sub dtpFechaHasta_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dtpFechaHasta.ValueChanged
            cargarClienteGeneral(txtParametrobusqueda.Text.Trim)
        End Sub

        Private Sub FrmBuscarClientesFacturaImpagaGeneral_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a

                    dgvDebitos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s

                    dgvDebitos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c

                    dgvDebitos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            dtpFechaDesde.Value = DateTime.Now.AddDays(-31)
        End Sub

        Private Sub dgvDebitos_DataError(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDebitos.DataError
            'nothing
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
            DialogResult = DialogResult.OK
        End Sub
    End Class
End Namespace