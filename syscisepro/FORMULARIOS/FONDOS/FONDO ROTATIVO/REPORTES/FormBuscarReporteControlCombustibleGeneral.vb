Imports ClassLibraryCisepro
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO

Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormBuscarReporteControlCombustibleGeneral
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
        Private _idControlCombustible As Integer

        ReadOnly _objetoControlCombustible As New ClassControlCombustible
        ReadOnly _objetoRubro As New ClassRubrosFondoRotativo
        ReadOnly _objetoSalidaVehiculo As New ClassSalidaVehiculoControlCombustible
        ReadOnly _objetoLlegadaVehiculo As New ClassLlegadaVehiculosControlCombustible
        ReadOnly _objetoActivoFijo As New ClassActivoFijo

        Private Sub CargarControlCombustible()
            Try
                Dim fechaDesde = dtpAsientoDesde.Value.Day.ToString & "-" & dtpAsientoDesde.Value.Month.ToString & "-" & dtpAsientoDesde.Value.Year.ToString & " 00:00:00"
                Dim fechaHasta = dtpAsientoHasta.Value.Day.ToString & "-" & dtpAsientoHasta.Value.Month.ToString & "-" & dtpAsientoHasta.Value.Year.ToString & " 23:59:59"


                dgvControlCombustible.DataSource = _objetoControlCombustible.SeleccionarRegistrosControlCombustiblePorFecha(_tipoCon, fechaDesde, fechaHasta)

                dgvControlCombustible.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(0).HeaderText = "ID"
                dgvControlCombustible.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(1).HeaderText = "FECHA"
                dgvControlCombustible.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(2).HeaderText = "VALOR"
                dgvControlCombustible.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(3).HeaderText = "DESTINO"
                dgvControlCombustible.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(4).HeaderText = "TOTAL KM'S"
                dgvControlCombustible.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(5).HeaderText = "EST"
                dgvControlCombustible.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(6).HeaderText = "MOTIVO"
                dgvControlCombustible.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(7).HeaderText = "ID SFR"
                dgvControlCombustible.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(8).HeaderText = "ID SCC"
                dgvControlCombustible.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(9).HeaderText = "ID ACF"
                dgvControlCombustible.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(10).HeaderText = "ID GFR"
                dgvControlCombustible.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(11).HeaderText = "ID RAFR"
                dgvControlCombustible.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(12).HeaderText = "ID PER"
                dgvControlCombustible.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(13).HeaderText = "ID RBR"
                dgvControlCombustible.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(14).HeaderText = "ID SAV"
                dgvControlCombustible.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvControlCombustible.Columns(15).HeaderText = "ID LLV"
                dgvControlCombustible.AutoResizeColumns()
                dgvControlCombustible.AutoResizeRows()
                dgvControlCombustible.ReadOnly = True
            Catch ex As Exception
                dgvControlCombustible.DataSource = Nothing
            End Try
        End Sub

        Private Sub FormBuscarReporteControlCombustibleGeneral_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvControlCombustible.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvControlCombustible.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvControlCombustible.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select 
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            Dim f = New FormReporteControlCombustible
            f.TipoCox = TipoCox
            f.lblIdControlCombustible.Text = _idControlCombustible
            f.ShowDialog()
        End Sub

        Private Sub dgvControlCombustible_CellClick(ByVal sender As Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvControlCombustible.CellClick
            Try
                If dgvControlCombustible.CurrentRow Is Nothing Then Return
                If dgvControlCombustible.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    txtIdControlC.Text = ""
                Else
                    _idControlCombustible = dgvControlCombustible.CurrentRow.Cells.Item(0).Value
                    txtIdControlC.Text = dgvControlCombustible.CurrentRow.Cells.Item(0).Value
                    txtFechaControlC.Text = dgvControlCombustible.CurrentRow.Cells.Item(1).Value
                    txtValorControlC.Text = dgvControlCombustible.CurrentRow.Cells.Item(2).Value
                    txtDestinoControlC.Text = dgvControlCombustible.CurrentRow.Cells.Item(3).Value.ToString
                    txtTotalKmsControlC.Text = dgvControlCombustible.CurrentRow.Cells.Item(4).Value.ToString
                    txtMotivoControlC.Text = dgvControlCombustible.CurrentRow.Cells.Item(6).Value.ToString
                    lblIdVehiculo.Text = dgvControlCombustible.CurrentRow.Cells.Item(9).Value.ToString

                    txtVehiculo.Text = _objetoActivoFijo.BuscarNombreActivoFijoXIdActivoFijo(_tipoCon, CType(lblIdVehiculo.Text, Integer))

                    lblIdRubro.Text = dgvControlCombustible.CurrentRow.Cells.Item(13).Value.ToString
                    _objetoRubro.BuscarNombreRubrosXIdRubro(_tipoCon, CType(lblIdRubro.Text, Integer))
                    txtRubro.Text = _objetoRubro.NombreRubro

                    lblIdSalidaVehiculo.Text = dgvControlCombustible.CurrentRow.Cells.Item(14).Value.ToString

                    _objetoSalidaVehiculo.BuscarFechaSalidaVehiculoXIdSalidaVehiculo(_tipoCon, CType(lblIdSalidaVehiculo.Text, Integer))
                    txtFechaSalidaVehiculo.Text = _objetoSalidaVehiculo.FechaSalidaVehiculo
                    _objetoSalidaVehiculo.BuscarKmSalidaVehiculoXIdSalidaVehiculo(_tipoCon, CType(lblIdSalidaVehiculo.Text, Integer))
                    txtKmSalidaVehiculo.Text = _objetoSalidaVehiculo.KmSalidaVehiculo

                    lblIdLlegadaVehiculo.Text = dgvControlCombustible.CurrentRow.Cells.Item(15).Value.ToString

                    _objetoLlegadaVehiculo.BuscarFechaLlegadaVehiculoXIdLlegadaVehiculo(_tipoCon, CType(lblIdLlegadaVehiculo.Text, Integer))
                    txtFechaLlegadaVehiculo.Text = _objetoLlegadaVehiculo.FechaLlegadaVehiculo
                    _objetoLlegadaVehiculo.BuscarKmLlegadaVehiculoXIdLlegadaVehiculo(_tipoCon, CType(lblIdLlegadaVehiculo.Text, Integer))
                    txtKmLlegadaVehiculo.Text = _objetoLlegadaVehiculo.KmLlegadaVehiculo

                End If
            Catch ex As Exception
                MsgBox("DGV CELL CLICK." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
         
        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            CargarControlCombustible()
        End Sub

    End Class
End Namespace