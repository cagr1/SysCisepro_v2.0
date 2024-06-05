Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.CONTABILIDAD.RETENCIONES_EMITIDAS

Namespace FORMULARIOS.CONTABILIDAD.LIQUIDACIONES

    Public Class FormRevisionLiquidaciones
        ''' <summary>
        '''  CISEPRO - SEPORTPAC - ASENAVA 2019
        ''' </summary>
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

        ReadOnly _objetoFondoRotativo As New ClassFondoRotativo
        ReadOnly _objetoAuxiliarFondoRotativo As New ClassAuxiliarFondoRotativo
        ReadOnly _objetoLiquidacionFondoRotativo As New ClassLiquidacionFondoRotativo
        ReadOnly _objetoSolicitudFondoRotativo As New ClassSolicitudFondoRotativo
        ReadOnly _objetoGastosFondoRotativo As New ClassGastosFondoRotativo
        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objetoNumeroRegistro As New ClassNumeroRegistroAsiento
        ReadOnly _objetoLibroDiario As New ClassLibroDiario
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoCentroCosto As New ClassCentroCosto
        ReadOnly _objetoProvincias As New ClassProvincias
        ReadOnly _objetoCiudad As New ClassCiudades
        ReadOnly _objetoParroquias As New ClassParroquias
        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoComprobanteRetencionCompra As New ClassComprobantesRetencion
        ReadOnly _objetoDetalleComprobanteRetencionCompra As New ClassDetalleComprobantesRetencion
        ReadOnly _objetoComprobanteRetencionCompraVenta As New ClassComprobantesRetencionCompraVenta
        ReadOnly _objetoPorcentajes As New ClassPorcentajes

        Dim _valDebe As Decimal
        Dim _valHaber As Decimal
        Dim _idald = 0
        Dim _esContribuyenteEspecial = False

        Dim _sqlCommands As List(Of SqlCommand)

        Private Sub FormRevisionLiquidaciones_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvLiquidacionesPendientes.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSolicitudFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSolicitudFonoRotativoNoDeducible.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvLiquidacionesPendientes.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac

                    dgvSolicitudFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSolicitudFonoRotativoNoDeducible.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac

                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvLiquidacionesPendientes.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro

                    dgvSolicitudFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSolicitudFonoRotativoNoDeducible.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro

            End Select
            dgvLiquidacionesPendientes.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvSolicitudFondoRotativo.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvSolicitudFonoRotativoNoDeducible.Font = New Font("Roboto", 8, FontStyle.Regular)

            _sqlCommands = New List(Of SqlCommand)
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRecargar.Click
            LimpiarParametros()
            CargarLiquidacionFondoRotativo()
        End Sub

        Private Sub LimpiarParametros()
            dgvLiquidacionesPendientes.DataSource = Nothing
            dgvSolicitudFondoRotativo.DataSource = Nothing
            dgvSolicitudFonoRotativoNoDeducible.DataSource = Nothing
            dgvComprobanteCompra.DataSource = Nothing
            dgvComprobanteRetencionCompra.DataSource = Nothing
            dgvDetalleComprobanteRetencionCompra.DataSource = Nothing
            chkSeleccionarTodo.Checked = False
            chkSeleccionarTodoNoDeducibles.Checked = False
            txtIdLiquidacion.Text = "..."
            txtFechaLiquidacion.Text = ""
            txtTotalLiquidacion.Text = "0.00"
            txtFondoLiquidacion.Text = "0.00"
            txtGastosLiquidacion.Text = "0.00"
            txtSaldoLiquidacion.Text = "0.00"
            txtReposicionLiquidacion.Text = "0.00"
            '_noDetComp = False
        End Sub

        Private Sub dgvLiquidacionesPendientes_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvLiquidacionesPendientes.SelectionChanged
            If dgvLiquidacionesPendientes.Rows.Count = 0 Or dgvLiquidacionesPendientes.CurrentRow Is Nothing Then Return
            CargarDatos()
        End Sub

        Private Sub LimpiarParametrosLiq()
            txtIdLiquidacion.Text = "..."
            txtFechaLiquidacion.Text = "0.00"
            txtTotalLiquidacion.Text = "0.00"
            txtFondoLiquidacion.Text = "0.00"
            txtGastosLiquidacion.Text = "0.00"
            txtSaldoLiquidacion.Text = "0.00"
            txtReposicionLiquidacion.Text = "0.00"
            dgvSolicitudFondoRotativo.DataSource = Nothing
            dgvSolicitudFonoRotativoNoDeducible.DataSource = Nothing
            chkSeleccionarTodo.Checked = False
            chkSeleccionarTodoNoDeducibles.Checked = False
        End Sub

        Private Sub CargarDatos()
            If dgvLiquidacionesPendientes.CurrentRow Is Nothing Then
                LimpiarParametrosLiq()
                Return
            End If
            If dgvLiquidacionesPendientes.RowCount = 0 Then
                LimpiarParametrosLiq()
                Return
            End If

            txtIdLiquidacion.Text = dgvLiquidacionesPendientes.CurrentRow.Cells.Item(0).Value
            txtFechaLiquidacion.Text = dgvLiquidacionesPendientes.CurrentRow.Cells.Item(1).Value
            txtTotalLiquidacion.Text = dgvLiquidacionesPendientes.CurrentRow.Cells.Item(2).Value.ToString
            txtFondoLiquidacion.Text = dgvLiquidacionesPendientes.CurrentRow.Cells.Item(3).Value.ToString
            txtGastosLiquidacion.Text = dgvLiquidacionesPendientes.CurrentRow.Cells.Item(4).Value.ToString
            txtSaldoLiquidacion.Text = dgvLiquidacionesPendientes.CurrentRow.Cells.Item(5).Value.ToString
            txtReposicionLiquidacion.Text = dgvLiquidacionesPendientes.CurrentRow.Cells.Item(6).Value.ToString

            CargarSolicitudFondoRotativo()
            CargarSolicitudFondoRotativoNoDeducible()
        End Sub

        Private Sub CargarLiquidacionFondoRotativo()
            Try
                dgvLiquidacionesPendientes.DataSource = _objetoLiquidacionFondoRotativo.SeleccionarLiquidacionFondoRotativoFormRevision(_tipoCon)

                dgvLiquidacionesPendientes.Columns(0).HeaderText = "ID"
                dgvLiquidacionesPendientes.Columns(0).Width = 50
                dgvLiquidacionesPendientes.Columns(1).HeaderText = "FECHA"
                dgvLiquidacionesPendientes.Columns(1).Width = 150
                dgvLiquidacionesPendientes.Columns(2).HeaderText = "TOTAL"
                dgvLiquidacionesPendientes.Columns(2).Width = 80
                dgvLiquidacionesPendientes.Columns(3).HeaderText = "FONDO"
                dgvLiquidacionesPendientes.Columns(3).Width = 80
                dgvLiquidacionesPendientes.Columns(4).HeaderText = "GASTOS"
                dgvLiquidacionesPendientes.Columns(4).Width = 80
                dgvLiquidacionesPendientes.Columns(5).HeaderText = "SALDO"
                dgvLiquidacionesPendientes.Columns(5).Width = 80
                dgvLiquidacionesPendientes.Columns(6).HeaderText = "REPOSICIÓN"
                dgvLiquidacionesPendientes.Columns(6).Width = 80
                dgvLiquidacionesPendientes.Columns(7).HeaderText = "ESTADO"
                dgvLiquidacionesPendientes.Columns(7).Width = 80
                dgvLiquidacionesPendientes.Columns(12).HeaderText = "N° ASIENTO"
                dgvLiquidacionesPendientes.Columns(12).Width = 100

                dgvLiquidacionesPendientes.ReadOnly = True
                dgvLiquidacionesPendientes.AutoResizeRows()

                For indice = 0 To dgvLiquidacionesPendientes.Columns.Count - 2
                    dgvLiquidacionesPendientes.Columns(indice).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    If indice < 7 Then Continue For
                    dgvLiquidacionesPendientes.Columns(indice).Visible = False
                Next
            Catch ex As Exception
                dgvLiquidacionesPendientes.DataSource = Nothing
                MsgBox("METODO CARGAR LIQUIDACIÓN." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Exclamation, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub CargarSolicitudFondoRotativo()
            Try
                dgvSolicitudFondoRotativo.DataSource = _objetoSolicitudFondoRotativo.SeleccionarSolicitudFondoRotativoDeducibleXIdLiquidacion(_tipoCon, txtIdLiquidacion.Text.Trim())

                dgvSolicitudFondoRotativo.Columns(0).HeaderText = " CHK "
                dgvSolicitudFondoRotativo.Columns(0).Width = 50
                dgvSolicitudFondoRotativo.Columns(1).HeaderText = "ID"
                dgvSolicitudFondoRotativo.Columns(1).Width = 50
                dgvSolicitudFondoRotativo.Columns(2).HeaderText = "NRO SOL"
                dgvSolicitudFondoRotativo.Columns(2).Width = 60
                dgvSolicitudFondoRotativo.Columns(3).HeaderText = "FECHA"
                dgvSolicitudFondoRotativo.Columns(3).Width = 90
                dgvSolicitudFondoRotativo.Columns(4).HeaderText = "VALOR"
                dgvSolicitudFondoRotativo.Columns(4).Width = 60
                dgvSolicitudFondoRotativo.Columns(5).HeaderText = "DETALLE"
                dgvSolicitudFondoRotativo.Columns(5).Width = 315
                dgvSolicitudFondoRotativo.Columns(6).HeaderText = "COD DEBE"
                dgvSolicitudFondoRotativo.Columns(6).Width = 80
                dgvSolicitudFondoRotativo.Columns(7).HeaderText = "COD HABER"
                dgvSolicitudFondoRotativo.Columns(7).Width = 80
                dgvSolicitudFondoRotativo.Columns(8).HeaderText = "EST"
                dgvSolicitudFondoRotativo.Columns(8).Width = 50
                dgvSolicitudFondoRotativo.Columns(9).HeaderText = "ID FR"
                dgvSolicitudFondoRotativo.Columns(9).Width = 50

                dgvSolicitudFondoRotativo.AutoResizeRows()
                dgvSolicitudFondoRotativo.Columns(0).ReadOnly = False

                For indice = 1 To dgvSolicitudFondoRotativo.Columns.Count - 1
                    dgvSolicitudFondoRotativo.Columns(indice).ReadOnly = True
                    dgvSolicitudFondoRotativo.Columns(indice).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    If indice >= 10 Then dgvSolicitudFondoRotativo.Columns(indice).Visible = False
                Next
            Catch ex As Exception
                dgvSolicitudFondoRotativo.DataSource = Nothing
                MsgBox("METODO CARGAR SOLICITUD LIQUIDACIÓN DEDUCIBLE." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Exclamation, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub CargarSolicitudFondoRotativoNoDeducible()
            Try
                dgvSolicitudFonoRotativoNoDeducible.DataSource = _objetoSolicitudFondoRotativo.SeleccionarSolicitudFondoRotativoNoDeducibleXIdLiquidacion(_tipoCon, txtIdLiquidacion.Text.Trim())

                dgvSolicitudFonoRotativoNoDeducible.Columns(0).HeaderText = " CHK "
                dgvSolicitudFonoRotativoNoDeducible.Columns(0).Width = 50
                dgvSolicitudFonoRotativoNoDeducible.Columns(1).HeaderText = "ID"
                dgvSolicitudFonoRotativoNoDeducible.Columns(1).Width = 50
                dgvSolicitudFonoRotativoNoDeducible.Columns(2).HeaderText = "NRO SOL"
                dgvSolicitudFonoRotativoNoDeducible.Columns(2).Width = 60
                dgvSolicitudFonoRotativoNoDeducible.Columns(3).HeaderText = "FECHA"
                dgvSolicitudFonoRotativoNoDeducible.Columns(3).Width = 90
                dgvSolicitudFonoRotativoNoDeducible.Columns(4).HeaderText = "VALOR"
                dgvSolicitudFonoRotativoNoDeducible.Columns(4).Width = 60
                dgvSolicitudFonoRotativoNoDeducible.Columns(5).HeaderText = "DETALLE"
                dgvSolicitudFonoRotativoNoDeducible.Columns(5).Width = 315
                dgvSolicitudFonoRotativoNoDeducible.Columns(6).HeaderText = "COD DEBE"
                dgvSolicitudFonoRotativoNoDeducible.Columns(6).Width = 80
                dgvSolicitudFonoRotativoNoDeducible.Columns(7).HeaderText = "COD HABER"
                dgvSolicitudFonoRotativoNoDeducible.Columns(7).Width = 80
                dgvSolicitudFonoRotativoNoDeducible.Columns(8).HeaderText = "EST"
                dgvSolicitudFonoRotativoNoDeducible.Columns(8).Width = 50
                dgvSolicitudFonoRotativoNoDeducible.Columns(9).HeaderText = "ID FR"
                dgvSolicitudFonoRotativoNoDeducible.Columns(9).Width = 50

                dgvSolicitudFonoRotativoNoDeducible.Columns(0).ReadOnly = False
                dgvSolicitudFonoRotativoNoDeducible.AutoResizeRows()

                For indice = 1 To dgvSolicitudFonoRotativoNoDeducible.Columns.Count - 1
                    dgvSolicitudFonoRotativoNoDeducible.Columns(indice).ReadOnly = True
                    dgvSolicitudFonoRotativoNoDeducible.Columns(indice).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    If indice >= 10 Then dgvSolicitudFonoRotativoNoDeducible.Columns(indice).Visible = False
                Next

            Catch ex As Exception
                dgvSolicitudFonoRotativoNoDeducible.DataSource = Nothing
                MsgBox("METODO CARGAR SOLICITUD LIQUIDACIÓN NO DEDUCIBLE." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Exclamation, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub btnAgregarDiarioNoDeducibles_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarDiarioNoDeducibles.Click
            CargarSolicitudFondoRotativoNoDeducible()
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarDiarioDeducibles.Click
            CargarSolicitudFondoRotativo()
        End Sub

        Private Function ValidarSeleccion() As Boolean
            Dim d = dgvSolicitudFondoRotativo.Rows.Cast(Of DataGridViewRow)().Any(Function(o) o.Cells(0).Value = True)
            Dim n = dgvSolicitudFonoRotativoNoDeducible.Rows.Cast(Of DataGridViewRow)().Any(Function(o) o.Cells(0).Value = True)
            Return n Or d
        End Function

        Private Sub btnReportes_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnFinRevision.Click
            If dgvSolicitudFondoRotativo.RowCount = 0 And dgvSolicitudFonoRotativoNoDeducible.RowCount = 0 Then
                MsgBox("NO SE CARGARON LAS SOLICITUDES DE FONDO POR FAVOR REVISE LA LIQUIDACIÓN", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            Else

                If Not ValidarSeleccion() Then
                    MsgBox("DEBE SELECCIONAR AL MENOS UNA SOLICITUD PARA REALIZAR LA LIQUIDACIÓN", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                    Return
                End If

                If MsgBox("ESTÁ SEGURO QUE DESEA PROCESAR LA LIQUIDACIÓN ACTUAL?", MsgBoxStyle.YesNo, "MENSAJE DE INFORMACIÓN") <> DialogResult.Yes Then Return
                dgvSolicitudFondoRotativo_CellEndEdit(Nothing, Nothing)
                dgvSolicitudFonoRotativoNoDeducible_CellEndEdit(Nothing, Nothing)

                _valDebe = 0
                _valHaber = 0

                _sqlCommands.Clear()

                _objetoLibroDiario.IdLibroDiario = _objetoLibroDiario.BuscarMayorIdLibroDiario(_tipoCon)

                With _objetoNumeroRegistro
                    .NumeroRegistro = .BuscarMayorNumeroRegistro(_tipoCon) + 1
                    .NumeroAnterior = .BuscarMayorNumeroAnterior(_tipoCon) + 1
                End With
                _sqlCommands.Add(_objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand())

                _idald = _objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1

                If dgvSolicitudFonoRotativoNoDeducible.Rows.Count > 0 Then NuevoRegistroAsientoDiarioAperturaNoDeducibles()
                If dgvSolicitudFondoRotativo.Rows.Count > 0 Then NuevoRegistroAsientoDiarioApertura()

                NuevoRegistroAsientoDiarioCierre()

                ActualizarMontoFondo()
                ActualizarEstadoLiquidacionFondoRotativoAprobado()
                ActualizarEstadoSolicitudFondoRotativo()

                Dim texto = "DEBE: " & _valDebe & "        -        HABER: " & _valHaber
                If Math.Abs(_valDebe - _valHaber) > 0.01 Then
                    MsgBox("NO ES POSBLE PROCESAR LA LIQUIDACIÓN PORQUE LA TRANSACCIÓN GENERADA NO CUADRA!!!" & vbNewLine & texto)
                    Return
                End If

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    LimpiarParametros()
                    CargarLiquidacionFondoRotativo()
                End If
                MsgBox(res(1) & vbNewLine & texto, If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            End If
        End Sub

        Private Sub chkSeleccionarTodoNoDeducibles_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkSeleccionarTodoNoDeducibles.CheckedChanged
            lblNoDeducibles.Text = "..."
            Dim n = 0.0
            For indice = 0 To dgvSolicitudFonoRotativoNoDeducible.RowCount - 1
                n += If(chkSeleccionarTodoNoDeducibles.Checked, CDec(dgvSolicitudFonoRotativoNoDeducible.Rows(indice).Cells(4).Value), 0)
                dgvSolicitudFonoRotativoNoDeducible.Rows(indice).Cells(0).Value = chkSeleccionarTodoNoDeducibles.Checked
            Next
            lblNoDeducibles.Text = "SELECCIONADO: $ " & Math.Round(n, 2)
        End Sub

        Private Sub chkSeleccionarTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkSeleccionarTodo.CheckedChanged
            lblDeducibles.Text = "..."
            Dim n = 0.0
            For indice = 0 To dgvSolicitudFondoRotativo.RowCount - 1
                n += If(chkSeleccionarTodo.Checked, CDec(dgvSolicitudFondoRotativo.Rows(indice).Cells(4).Value), 0)
                dgvSolicitudFondoRotativo.Rows(indice).Cells(0).Value = chkSeleccionarTodo.Checked
            Next
            lblDeducibles.Text = "SELECCIONADO: $ " & Math.Round(n, 2)
        End Sub

        Private Sub CargarComprobantesCompra(ByVal idc As Integer)
            dgvComprobanteCompra.DataSource = _objetoComprobantesCompra.SeleccionarComprobanteCompraXIdComprobante(_tipoCon, idc)
            dgvComprobanteCompra.AutoResizeColumns()
            dgvComprobanteCompra.AutoResizeRows()
        End Sub

        Private Sub CargarComprobanteRetencionCompra(ByVal idc As Integer)
            dgvComprobanteRetencionCompra.DataSource = _objetoComprobanteRetencionCompra.SeleccionarComrpobantesRetencionXIdComprobanteCompra(_tipoCon, idc)
            dgvComprobanteRetencionCompra.AutoResizeColumns()
            dgvComprobanteRetencionCompra.AutoResizeRows()
        End Sub

        Private Sub CargarDetalleComprobanteRetencionCompras(ByVal idc As Integer)
            dgvDetalleComprobanteRetencionCompra.DataSource = _objetoDetalleComprobanteRetencionCompra.SeleccionarRegistrosDetallesComprobanteRetencionCompraXIdComprobanteCompra(_tipoCon, idc)
            dgvDetalleComprobanteRetencionCompra.AutoResizeColumns()
            dgvDetalleComprobanteRetencionCompra.AutoResizeRows()
        End Sub

        Private Sub NuevoRegistroAsientoDiarioAperturaNoDeducibles()
            If dgvSolicitudFonoRotativoNoDeducible.Rows.Count = 0 Then Return
            For i = 0 To dgvSolicitudFonoRotativoNoDeducible.Rows.Count - 1
                If Not CBool(dgvSolicitudFonoRotativoNoDeducible.Rows(i).Cells(0).Value) Then Continue For
                With _objetoAsientoLibroDiario
                    .IdAsiento = _idald
                    .FechaAsiento = txtFechaLiquidacion.Text
                    .CodigoCuentaAsiento = dgvSolicitudFonoRotativoNoDeducible.Rows(i).Cells(6).Value
                    .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento)
                    .ConceptoAsiento = _objetoGastosFondoRotativo.BuscarNombreGastosFrPorIdGastosFr(_tipoCon, dgvSolicitudFonoRotativoNoDeducible.Rows(i).Cells(12).Value)
                    .DetalleTransaccionAsiento = "ID FR: " + txtIdLiquidacion.Text + " DETALLE: " + dgvSolicitudFonoRotativoNoDeducible.Rows(i).Cells(5).Value
                    .ProvinciaAsiento = "EL ORO"
                    .CiudadAsiento = "MACHALA"
                    .ParroquiaAsiento = "MACHALA"
                    .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, dgvSolicitudFonoRotativoNoDeducible.Rows(i).Cells(11).Value)
                    .ValorDebeAsiento = dgvSolicitudFonoRotativoNoDeducible.Rows(i).Cells(4).Value
                    .ValorHaberAsiento = 0
                    .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                    .DebeHaberAsiento = 1 ' DEBE=1 / HABER=2 
                    .ConciliarAsiento = 1
                    .EstadoAsiento = 1
                    .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                    .EstadoMayorAsiento = 0
                End With
                _valDebe += _objetoAsientoLibroDiario.ValorDebeAsiento
                _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                _idald += 1
            Next
        End Sub

        Private Sub NuevoRegistroAsientoDiarioApertura()
            If dgvSolicitudFondoRotativo.Rows.Count = 0 Then Return
            For i = 0 To dgvSolicitudFondoRotativo.Rows.Count - 1
                If Not CBool(dgvSolicitudFondoRotativo.Rows(i).Cells(0).Value) Then Continue For

                CargarComprobantesCompra(dgvSolicitudFondoRotativo.Rows(i).Cells(20).Value)
                CargarComprobanteRetencionCompra(dgvSolicitudFondoRotativo.Rows(i).Cells(20).Value)
                CargarDetalleComprobanteRetencionCompras(dgvSolicitudFondoRotativo.Rows(i).Cells(20).Value)

                _esContribuyenteEspecial = dgvComprobanteCompra.Rows(0).Cells("CONTRIBUYENTE_ESPECIAL_PROVEEDOR_GENERAL").Value.ToString.Trim.Equals("SI")

                With _objetoAsientoLibroDiario 'gasto 
                    .IdAsiento = _idald
                    .FechaAsiento = txtFechaLiquidacion.Text
                    .CodigoCuentaAsiento = dgvSolicitudFondoRotativo.Rows(i).Cells(6).Value
                    .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento)
                    .ConceptoAsiento = _objetoGastosFondoRotativo.BuscarNombreGastosFrPorIdGastosFr(_tipoCon, dgvSolicitudFondoRotativo.Rows(i).Cells(12).Value)
                    .DetalleTransaccionAsiento = "ID FR: " + txtIdLiquidacion.Text + " DETALLE: " + dgvSolicitudFondoRotativo.Rows(i).Cells(5).Value
                    .ProvinciaAsiento = "EL ORO"
                    .CiudadAsiento = "MACHALA"
                    .ParroquiaAsiento = "MACHALA"
                    .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, dgvSolicitudFondoRotativo.Rows(i).Cells(11).Value)
                    .ValorDebeAsiento = dgvComprobanteCompra.Rows(0).Cells(14).Value 'dgvSolicitudFondoRotativo.Rows(i).Cells(4).Value 
                    .ValorHaberAsiento = 0
                    .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                    .DebeHaberAsiento = 1 ' DEBE=1 / HABER=2 
                    .ConciliarAsiento = 1
                    .EstadoAsiento = 1
                    .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                    .EstadoMayorAsiento = 0
                End With
                _valDebe += _objetoAsientoLibroDiario.ValorDebeAsiento
                _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                _idald += 1

                If dgvComprobanteCompra.Rows(0).Cells(16).Value > 0 Then ' si la compra tiene iva
                    With _objetoAsientoLibroDiario 'iva 
                        .IdAsiento = _idald
                        .FechaAsiento = txtFechaLiquidacion.Text
                        .CodigoCuentaAsiento = "1010512"
                        .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento)
                        .ConceptoAsiento = "IVA PAGADO POR COMPRA"
                        .DetalleTransaccionAsiento = "ID FR: " + txtIdLiquidacion.Text + " DETALLE: " + dgvSolicitudFondoRotativo.Rows(i).Cells(5).Value
                        .ProvinciaAsiento = _objetoProvincias.BuscarNombreProvinciaXIdProvincia(_tipoCon, dgvSolicitudFondoRotativo.Rows(i).Cells(14).Value)
                        .CiudadAsiento = _objetoCiudad.BuscarNombreCiudadXIdCiudad(_tipoCon, dgvSolicitudFondoRotativo.Rows(i).Cells(15).Value)
                        .ParroquiaAsiento = _objetoParroquias.BuscarNombreParroquiaXIdParroquia(_tipoCon, dgvSolicitudFondoRotativo.Rows(i).Cells(16).Value)
                        .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, dgvSolicitudFondoRotativo.Rows(i).Cells(11).Value)
                        .ValorDebeAsiento = dgvComprobanteCompra.Rows(0).Cells(16).Value
                        .ValorHaberAsiento = 0
                        .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                        .DebeHaberAsiento = 1 ' DEBE=1 / HABER=2 
                        .ConciliarAsiento = 1
                        .EstadoAsiento = 1
                        .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                        .EstadoMayorAsiento = 0
                    End With
                    _valDebe += _objetoAsientoLibroDiario.ValorDebeAsiento
                    _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                    _idald += 1
                End If

                If dgvComprobanteRetencionCompra.Rows.Count > 0 Then
                    If dgvComprobanteRetencionCompra.Rows(0).Cells(8).Value > 0 Then
                        'Dim codigoCuenta = "0"
                        For r = 0 To dgvDetalleComprobanteRetencionCompra.RowCount - 1
                            'If dgvDetalleComprobanteRetencionCompra.Rows(r).Cells.Item(4).Value = "RENTA" Then 
                            '    codigoCuenta = _objetoPorcentajes.CuentaRetencionRentaCodPorcTipo(TipoCox, dgvDetalleComprobanteRetencionCompra.Rows(r).Cells.Item(2).Value.ToString().Trim(), dgvDetalleComprobanteRetencionCompra.Rows(r).Cells.Item(5).Value.ToString().Trim(), 0)
                            '    If codigoCuenta.Trim().Length = 0 Then
                            '        MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "LA CUENTA PARA EL CÓDIGO DE RETENCIÓN ESCOGIDO EN LA FAC. ID: " & dgvComprobanteCompra.Rows(0).Cells(0).Value & " NO HA SIDO DEFINIDA EN LA BD!", MsgBoxStyle.Exclamation, "MENSAJE DE VALICACIÓN")
                            '        Exit Sub
                            '    End If
                            'End If
                            'If dgvDetalleComprobanteRetencionCompra.Rows(r).Cells.Item(4).Value = "IVA" Then
                            '    codigoCuenta = _objetoPorcentajes.CuentaRetencionIvaPorc(TipoCox, dgvDetalleComprobanteRetencionCompra.Rows(r).Cells.Item(5).Value.ToString().Trim())
                            '    If codigoCuenta.Trim().Length = 0 Then
                            '        MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "LA CUENTA PARA EL CÓDIGO DE RETENCIÓN ESCOGIDO EN LA FAC. ID: " & dgvComprobanteCompra.Rows(0).Cells(0).Value & " NO HA SIDO DEFINIDA EN LA BD!", MsgBoxStyle.Exclamation, "MENSAJE DE VALICACIÓN")
                            '        Exit Sub
                            '    End If
                            'End If

                            If dgvDetalleComprobanteRetencionCompra.Rows(r).Cells.Item(10).Value.ToString().Trim().Length = 0 Or dgvDetalleComprobanteRetencionCompra.Rows(r).Cells.Item(11).Value.ToString().Trim().Length = 0 Then
                                MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "LA CUENTA PARA EL CÓDIGO DE RETENCIÓN ESCOGIDO EN LA FAC. ID: " & dgvComprobanteCompra.Rows(0).Cells(0).Value & " NO HA SIDO DEFINIDA EN LA BD!", MsgBoxStyle.Exclamation, "MENSAJE DE VALICACIÓN")
                                Exit Sub
                            End If

                            With _objetoAsientoLibroDiario ' retencion
                                .IdAsiento = _idald
                                .FechaAsiento = txtFechaLiquidacion.Text
                                .CodigoCuentaAsiento = dgvDetalleComprobanteRetencionCompra.Rows(r).Cells.Item(10).Value.ToString().Trim()
                                .NombreCuentaAsiento = dgvDetalleComprobanteRetencionCompra.Rows(r).Cells.Item(11).Value.ToString().Trim()
                                .ConceptoAsiento = "OBLIGACIONES CON LA ADMINISTRACIÓN TRIBUTARIA"
                                .DetalleTransaccionAsiento = "ID FR: " + txtIdLiquidacion.Text + " DETALLE: " + dgvSolicitudFondoRotativo.Rows(i).Cells(5).Value
                                .ProvinciaAsiento = "EL ORO"
                                .CiudadAsiento = "MACHALA"
                                .ParroquiaAsiento = "MACHALA"
                                .CentroCostoAsiento = _objetoCentroCosto.BuscarDetalleCentroCostoXIdCentroCosto(_tipoCon, 2)
                                .ValorDebeAsiento = 0
                                .ValorHaberAsiento = CDec(dgvDetalleComprobanteRetencionCompra.Rows(r).Cells.Item(6).Value)
                                .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                                .DebeHaberAsiento = 2  ' DEBE=1 / HABER=2 
                                .ConciliarAsiento = 1
                                .EstadoAsiento = 1
                                .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                                .EstadoMayorAsiento = 0
                            End With
                            _valHaber += _objetoAsientoLibroDiario.ValorHaberAsiento
                            _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
                            _idald += 1
                        Next
                    End If
                End If
            Next
        End Sub

        Private Sub NuevoRegistroAsientoDiarioCierre()
            With _objetoAsientoLibroDiario
                .IdAsiento = _idald
                .FechaAsiento = txtFechaLiquidacion.Text
                .CodigoCuentaAsiento = "101010102"
                .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento)
                .ConceptoAsiento = "LIQUIDACIÓN DE FONDO ROTATIVO"
                .DetalleTransaccionAsiento = "ID FR: " + txtIdLiquidacion.Text + " SE LIQUIDO FONDO ROTATIVO, PARA REALIZAR LA REPOSICIÓN."
                .ProvinciaAsiento = "EL ORO"
                .CiudadAsiento = "MACHALA"
                .ParroquiaAsiento = "9 DE MAYO"
                .CentroCostoAsiento = "GERENCIA ADMINISTRATIVA-FINANCIERA"
                .ValorDebeAsiento = 0
                .ValorHaberAsiento = txtGastosLiquidacion.Text
                .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                .DebeHaberAsiento = 2 ' DEBE=1 / HABER=2 
                .ConciliarAsiento = 1
                .EstadoAsiento = 1
                .IdLibroDiario = _objetoLibroDiario.IdLibroDiario
                .EstadoMayorAsiento = 0
            End With
            _valHaber += _objetoAsientoLibroDiario.ValorHaberAsiento
            _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())
            _idald += 1
        End Sub

        Private Sub ActualizarMontoFondo()
            With _objetoAuxiliarFondoRotativo
                .IdFondo = _objetoFondoRotativo.BuscarIdFondoRotativo(_tipoCon)
                .MontoFondo = 700
                .MontoAnteriorFondo = CDec(txtReposicionLiquidacion.Text)
            End With
            _sqlCommands.Add(_objetoAuxiliarFondoRotativo.ActualizarMontoAuxiliarFondoRotativoCommand())
        End Sub

        Private Sub ActualizarEstadoLiquidacionFondoRotativoAprobado()
            With _objetoLiquidacionFondoRotativo
                .IdLiquidacion = txtIdLiquidacion.Text
                .EstadoLiquidacion = 2
                .NroAsiento = _objetoNumeroRegistro.NumeroRegistro
            End With
            _sqlCommands.Add(_objetoLiquidacionFondoRotativo.ModificarEstadoLiquidacionFondoRotativoCommand())
        End Sub

        Private Sub ActualizarEstadoSolicitudFondoRotativo()
            For indice = 0 To dgvSolicitudFondoRotativo.RowCount - 1
                If dgvSolicitudFondoRotativo.Rows(indice).Cells(0).Value = True Then ' Si la fila de la grilla esta checkeada / datagridview deducibles
                    With _objetoSolicitudFondoRotativo
                        .IdSolicitud = dgvSolicitudFondoRotativo.Rows(+indice).Cells(1).Value
                        .EstadoSolicitud = 3
                        .IdLiquidacion = txtIdLiquidacion.Text.Trim()
                    End With
                    _sqlCommands.Add(_objetoSolicitudFondoRotativo.ModificarLiquidacionSolicitudFondoRotativoCommand())
                Else
                    With _objetoSolicitudFondoRotativo
                        .IdSolicitud = dgvSolicitudFondoRotativo.Rows(+indice).Cells(1).Value
                        .EstadoSolicitud = 4
                        .IdLiquidacion = txtIdLiquidacion.Text.Trim()
                    End With
                    _sqlCommands.Add(_objetoSolicitudFondoRotativo.ModificarLiquidacionSolicitudFondoRotativoCommand())
                End If
            Next
            For indice = 0 To dgvSolicitudFonoRotativoNoDeducible.RowCount - 1
                If dgvSolicitudFonoRotativoNoDeducible.Rows(indice).Cells(0).Value = True Then ' Si la fila de la grilla esta checkeada / datagridview no deducibles
                    With _objetoSolicitudFondoRotativo
                        .IdSolicitud = dgvSolicitudFonoRotativoNoDeducible.Rows(indice).Cells(1).Value
                        .EstadoSolicitud = 3
                        .IdLiquidacion = txtIdLiquidacion.Text.Trim()
                    End With
                    _sqlCommands.Add(_objetoSolicitudFondoRotativo.ModificarLiquidacionSolicitudFondoRotativoCommand())
                Else
                    With _objetoSolicitudFondoRotativo
                        .IdSolicitud = dgvSolicitudFonoRotativoNoDeducible.Rows(indice).Cells(1).Value
                        .EstadoSolicitud = 4
                        .IdLiquidacion = txtIdLiquidacion.Text.Trim()
                    End With
                    _sqlCommands.Add(_objetoSolicitudFondoRotativo.ModificarLiquidacionSolicitudFondoRotativoCommand())
                End If
            Next
        End Sub

        Private Sub dgvSolicitudFonoRotativoNoDeducible_CellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvSolicitudFonoRotativoNoDeducible.CellEndEdit
            Dim n = 0.0
            For indice = 0 To dgvSolicitudFonoRotativoNoDeducible.RowCount - 1
                If dgvSolicitudFonoRotativoNoDeducible.Rows(indice).Cells(0).Value = False Then Continue For
                n += CDec(dgvSolicitudFonoRotativoNoDeducible.Rows(indice).Cells(4).Value)
            Next
            lblNoDeducibles.Text = "SELECCIONADO: $ " & Math.Round(n, 2)
        End Sub

        Private Sub dgvSolicitudFondoRotativo_CellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvSolicitudFondoRotativo.CellEndEdit
            Dim n = 0.0
            For indice = 0 To dgvSolicitudFondoRotativo.RowCount - 1
                If dgvSolicitudFondoRotativo.Rows(indice).Cells(0).Value = False Then Continue For
                n += CDec(dgvSolicitudFondoRotativo.Rows(indice).Cells(4).Value)
            Next
            lblDeducibles.Text = "SELECCIONADO: $ " & Math.Round(n, 2)
        End Sub
    End Class
End Namespace