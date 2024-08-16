Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports Krypton.Toolkit
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAprobacionComprobantesEgresoBancos

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
        Public UserName As String

        ReadOnly _objetoComprobanteEgreso As New ClassComprobanteEgresoBanco
        ReadOnly _objetoChequesEmitidos As New ClassChequesEmitidosCxp
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoNumeroRegistroAsientoCompEgreso As New ClassNumeroRegistroAsientoComprobanteEgreso

        Private Sub CargarComprobanteEgresoBancos()
            Try
                Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
                Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

                dgvComprobanteEgresoBancos.DataSource = _objetoComprobanteEgreso.SeleccionarComprobanteEgresoBancosPorFecha(_tipoCon, fechaDesde, fechaHasta)
                dgvComprobanteEgresoBancos.AutoResizeColumns()
                dgvComprobanteEgresoBancos.AutoResizeRows()

                If dgvComprobanteEgresoBancos.RowCount = 0 Then Return
                dgvComprobanteEgresoBancos.Columns(3).Width = 500
                dgvComprobanteEgresoBancos.Columns(7).Width = 500

            Catch
                dgvComprobanteEgresoBancos.DataSource = Nothing
            End Try
        End Sub

        Private Sub AprobarComprobanteEgresoBancos()
            With _objetoComprobanteEgreso
                .Id = txtNumeroComprobanteEgreso.Text
                .Estado = 2
            End With
            _sqlCommands.Add(_objetoComprobanteEgreso.ActualizarConceptoComprobanteEgresoBancos())

            _objAuditoria.AccionAuditoria = "COMPROBANTE DE EGRESO DE BANCOS. Nº: CE-" & txtNumeroComprobanteEgreso.Text & " APROBADO. FECHA DE APROBACIÓN: " & Date.Now
            _sqlCommands.Add(_objAuditoria.RegistrarNuevoAuditoriaCommand())
        End Sub

        Private Sub AprobarChequeEmitido()
            With _objetoChequesEmitidos
                .EstadoCheque = 2 ' 1 = generado ; 2 = aprobado ; 3 = cobrado ; 4 = caducado
                .IdComprobante = txtNumeroComprobanteEgreso.Text
                .ActualizarEstadoChequesEmitidosXIdComprobanteEgreso(_tipoCon)
            End With
        End Sub

        Private Sub RechazarComprobanteEgresoBancos()
            With _objetoComprobanteEgreso
                .Id = txtNumeroComprobanteEgreso.Text
                .Estado = 0
            End With
            _sqlCommands.Add(_objetoComprobanteEgreso.ActualizarEstadoComprobanteEgresoBancos())

            _objAuditoria.AccionAuditoria = "COMPROBANTE DE EGRESO DE BANCOS. Nº: CE-" & txtNumeroComprobanteEgreso.Text & " APROBADO. FECHA DE APROBACIÓN: " + Date.Now
            _sqlCommands.Add(_objAuditoria.RegistrarNuevoAuditoriaCommand())
        End Sub

        Private Sub RechazarChequeEmitido()
            With _objetoChequesEmitidos
                .EstadoCheque = 0
                .IdComprobante = txtNumeroComprobanteEgreso.Text
            End With
            _sqlCommands.Add(_objetoChequesEmitidos.ActualizarEstadoChequesEmitidosXIdComprobanteEgreso())
        End Sub

        Private Sub FormAprobacionComprobantesEgresoBancos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobanteEgresoBancos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            _sqlCommands = New List(Of SqlCommand)
            Dim f = _objAuditoria.FechaExactaAuditoria(_tipoCon)
            dtpFechaDesde.Value = New DateTime(f.Year, f.Month, 1, 0, 0, 0)
            dtpFechaHasta.Value = dtpFechaDesde.Value.AddMonths(1).AddDays(-1)
        End Sub

        Private Sub dgvComprobanteEgresoBancos_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvComprobanteEgresoBancos.CellDoubleClick
            If dgvComprobanteEgresoBancos.Rows.Count = 0 Or dgvComprobanteEgresoBancos.CurrentRow Is Nothing Then Return
            Try
                Dim formAsientoDiario As New FormBuscarAsientoDiarioResumido
                formAsientoDiario.TipoCox = TipoCox
                If dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    txtNumeroComprobanteEgreso.Text = ""
                Else
                    txtNumeroComprobanteEgreso.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(0).Value
                    formAsientoDiario.NumeroRegsitroBusqueda = _objetoNumeroRegistroAsientoCompEgreso.BuscarNumeroRegistroAsientoPorIdComprobanteEgreso(_tipoCon, txtNumeroComprobanteEgreso.Text)
                    DialogResult = formAsientoDiario.ShowDialog
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAprovar.Click
            If dgvComprobanteEgresoBancos.Rows.Count = 0 Or dgvComprobanteEgresoBancos.CurrentRow Is Nothing Then Return

            If MessageBox.Show("¿ESTA SEGURO QUE DESEA APROBAR EL COMPROBANTE DE EGRESO?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            _sqlCommands.Clear()

            _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
            _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
            _objAuditoria.FormularioAuditoria = Text.Trim
            _objAuditoria.EstadoAuditoria = 1
            _objAuditoria.IdUsuarioAuditoria = IdUsuario

            AprobarComprobanteEgresoBancos()
            AprobarChequeEmitido()

            Dim nombreU As String = "Comprobante de Egreso aprobado por: " & UserName
            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
            If res(0) Then CargarComprobanteEgresoBancos()
            Dim messageIcon As KryptonMessageBoxIcon
            If res(0) Then
                messageIcon = KryptonMessageBoxIcon.Information
            Else
                messageIcon = KryptonMessageBoxIcon.Exclamation
            End If
            KryptonMessageBox.Show(res(1), "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, messageIcon)
            'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
        End Sub

        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRechazar.Click
            If dgvComprobanteEgresoBancos.Rows.Count = 0 Or dgvComprobanteEgresoBancos.CurrentRow Is Nothing Then
                Return
            End If

            If MessageBox.Show("¿ESTA SEGURO QUE DESEA RECHAZAR EL COMPROBANTE DE EGRESO?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            _sqlCommands.Clear()

            _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
            _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
            _objAuditoria.FormularioAuditoria = Text.Trim
            _objAuditoria.EstadoAuditoria = 1
            _objAuditoria.IdUsuarioAuditoria = IdUsuario

            RechazarComprobanteEgresoBancos()
            RechazarChequeEmitido()

            Dim User As String = "Comprobante de Egreso rechazado por: " & UserName
            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, User)

            If res(0) Then CargarComprobanteEgresoBancos()
            Dim messageIcon As KryptonMessageBoxIcon
            If res(0) Then
                messageIcon = KryptonMessageBoxIcon.Information
            Else
                messageIcon = KryptonMessageBoxIcon.Exclamation
            End If
            KryptonMessageBox.Show(res(1), "MENSAJE DEL SISTEMA", KryptonMessageBoxButtons.OK, messageIcon)
            'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

        End Sub

        Private Sub dgvComprobanteEgresoBancos_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvComprobanteEgresoBancos.SelectionChanged
            If dgvComprobanteEgresoBancos.Rows.Count = 0 Or dgvComprobanteEgresoBancos.CurrentRow Is Nothing Then Return
            If dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then Return

            txtNumeroComprobanteEgreso.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(1).Value
            txtFechaComprobanteEgreso.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(2).Value
            txtNumeroFactura.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(3).Value
            txtRucCi.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(4).Value
            txtPagadoA.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(5).Value
            txtActividad.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(6).Value
            txtConcepto.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(7).Value
            txtRazon.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(7).Value
            txtTipoPago.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(8).Value
            txtValorComprobante.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(9).Value
            txtNumeroCheque.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(10).Value
            txtBanco.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(11).Value
            txtCuenta.Text = dgvComprobanteEgresoBancos.CurrentRow.Cells.Item(12).Value
        End Sub

        Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
            CargarComprobanteEgresoBancos()
        End Sub
    End Class
End Namespace