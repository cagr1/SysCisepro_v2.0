Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports syscisepro.FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES

Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormBuscarLiquidacionFondoRotativo

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

        Private _idLiquidacionReporte As Integer

        ReadOnly _objetoLiquidacionFondoRotativo As New ClassLiquidacionFondoRotativo

        Private Sub CargarLiquidacionFondoRotativo()
            Try
                Dim fechaDesde = DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day & " 00:00:00"
                Dim fechaHasta = DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day & " 23:59:59"

                dgvLiquidacionFondoRotativo.DataSource = _objetoLiquidacionFondoRotativo.SeleccionarLiquidacionFondoRotativo(_tipoCon, fechaDesde, fechaHasta)
                dgvLiquidacionFondoRotativo.Font = New Font("Roboto", 9, FontStyle.Regular)
                dgvLiquidacionFondoRotativo.Columns(0).HeaderText = "ID LIQ"
                dgvLiquidacionFondoRotativo.Columns(1).HeaderText = "FECHA"
                dgvLiquidacionFondoRotativo.Columns(2).HeaderText = "TOTAL"
                dgvLiquidacionFondoRotativo.Columns(3).HeaderText = "FONDO"
                dgvLiquidacionFondoRotativo.Columns(4).HeaderText = "GASTO"
                dgvLiquidacionFondoRotativo.Columns(5).HeaderText = "SALDO"
                dgvLiquidacionFondoRotativo.Columns(6).HeaderText = "REPOSICION"
                dgvLiquidacionFondoRotativo.Columns(7).HeaderText = "EST"
                dgvLiquidacionFondoRotativo.Columns(8).HeaderText = "ID PROV"
                dgvLiquidacionFondoRotativo.Columns(9).HeaderText = "ID CIU"
                dgvLiquidacionFondoRotativo.Columns(10).HeaderText = "ID PAR"

                dgvLiquidacionFondoRotativo.AutoResizeColumns()
                dgvLiquidacionFondoRotativo.AutoResizeRows()
                dgvLiquidacionFondoRotativo.ReadOnly = True
            Catch
                dgvLiquidacionFondoRotativo.DataSource = Nothing
            End Try
        End Sub
         
        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
            Dim f = New FormReporteLiquidacionFondoRotativo
            f.IdFondo = _idLiquidacionReporte
            f.Fecha = If(txtFechaLiquidacion.Text.Trim().Length = 0, DateTime.Now, CDate(txtFechaLiquidacion.Text))
            f.Fondo = If(txtFondoLiquidacion.Text.Trim().Length = 0, 0, CDec(txtFondoLiquidacion.Text))
            f.Saldo = If(txtSaldoLiquidacion.Text.Trim().Length = 0, 0, CDec(txtSaldoLiquidacion.Text))
            f.Reposicion = If(txtReposicionLiquidacion.Text.Trim().Length = 0, 0, CDec(txtReposicionLiquidacion.Text))
            f.Total = If(txtTotalLiquidacion.Text.Trim().Length = 0, 0, CDec(txtTotalLiquidacion.Text))
            f.TipoCox = TipoCox 
            f.ShowDialog()
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            CargarLiquidacionFondoRotativo()
        End Sub

        Private Sub FormBuscarLiquidacionFondoRotativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label1.ForeColor = Color.White
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label2.ForeColor = Color.White
                    Label2.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvLiquidacionFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    Label1.ForeColor = Color.White
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    Label2.ForeColor = Color.White
                    Label2.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvLiquidacionFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    Label1.ForeColor = Color.White
                    Label1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    Label2.ForeColor = Color.White
                    Label2.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvLiquidacionFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
        End Sub

        Private Sub dgvLiquidacionFondoRotativo_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvLiquidacionFondoRotativo.SelectionChanged
            If dgvLiquidacionFondoRotativo.RowCount > 0 And Not dgvLiquidacionFondoRotativo.CurrentRow Is Nothing Then
                If dgvLiquidacionFondoRotativo.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    txtIdLiquidacion.Text = ""
                Else
                    txtIdLiquidacion.Text = dgvLiquidacionFondoRotativo.CurrentRow.Cells.Item(0).Value
                    _idLiquidacionReporte = txtIdLiquidacion.Text
                    txtFechaLiquidacion.Text = CDate(dgvLiquidacionFondoRotativo.CurrentRow.Cells.Item(1).Value).ToLongDateString()
                    txtTotalLiquidacion.Text = dgvLiquidacionFondoRotativo.CurrentRow.Cells.Item(2).Value.ToString
                    txtFondoLiquidacion.Text = dgvLiquidacionFondoRotativo.CurrentRow.Cells.Item(3).Value.ToString
                    txtGastosLiquidacion.Text = dgvLiquidacionFondoRotativo.CurrentRow.Cells.Item(4).Value.ToString
                    txtSaldoLiquidacion.Text = dgvLiquidacionFondoRotativo.CurrentRow.Cells.Item(5).Value.ToString
                    txtReposicionLiquidacion.Text = dgvLiquidacionFondoRotativo.CurrentRow.Cells.Item(6).Value.ToString
                    dgvLiquidacionFondoRotativo.Rows(dgvLiquidacionFondoRotativo.CurrentCell.RowIndex.ToString()).Selected = True
                End If
            End If
        End Sub
    End Class
End Namespace