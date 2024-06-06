Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.DEPRECIACIONES
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports syscisepro.FORMULARIOS.ACTIVOS_FIJOS.REPORTES

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormDepreciaciones
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

        ReadOnly _objActivoFijo As New ClassActivoFijo
        ReadOnly _objDepreciacion As New ClassDepreciaciones
        ReadOnly _objDetalleDepreciacion As New ClassDetalleDepreciaciones
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral

        Private Sub Auditoria()
            _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
            _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
            _objAuditoria.FormularioAuditoria = Text.Trim
            _objAuditoria.EstadoAuditoria = 1
            _objAuditoria.IdUsuarioAuditoria = IdUsuario
            _objAuditoria.AccionAuditoria = "REALIZO UNA DEPRECIACION DE ACTIVO FIJO CON N° DE REGISTRO:" + lblIdDepreciacion.Text + " CON ULTIMO VALOR EN EL MERCADO DE: " + lblDepreciacion.Text
            _sqlCommands.Add(_objAuditoria.NuevaAuditoria) 
        End Sub
        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            Try
                Dim _fechaDesde = dtpDesde.Value.Day.ToString & "-" & dtpDesde.Value.Month.ToString & "-" & dtpDesde.Value.Year.ToString & " 00:00:00"
                Dim _fechaHasta = dtpHasta.Value.Day.ToString & "-" & dtpHasta.Value.Month.ToString & "-" & dtpHasta.Value.Year.ToString & " 23:59:59"

                LimpiarParametros()
                'Dim id = _objActivoFijo.BuscarIdActivoFijoCodigo(_tipoCon, txtCodigoActivo.Text)
                dgvActivoFijo.DataSource = _objDepreciacion.BuscarActivoFijoPorIdActivoEnDepreciacionGeneral(_tipoCon, txtCodigoActivo.Text, _fechaDesde, _fechaHasta)
                dgvActivoFijo.Columns("ID_DEPRECIACION").DefaultCellStyle.BackColor = Color.Azure
                dgvActivoFijo.Columns("ID_DEPRECIACION").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns("ID_ACTIVO_FIJO").DefaultCellStyle.BackColor = Color.Lavender
                dgvActivoFijo.Columns("ID_ACTIVO_FIJO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                dgvActivoFijo.AutoResizeColumns()
                dgvActivoFijo.AutoResizeRows()
                dgvActivoFijo.ReadOnly = False
                dgvActivoFijo.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch
                dgvActivoFijo.DataSource = Nothing
            End Try
        End Sub

        Private Sub LimpiarParametros()
            txtIdDepreciacion.Clear()
            txtFecha.Clear()
            txtNroDepreciacion.Clear()
            txtValorDepreciacion.Clear()
            txtValorResidual.Clear()
            txtTope.Clear()
            lblIdDepreciacion.Text = String.Empty
            lblFecha.Text = String.Empty
            lblNro.Text = String.Empty
            lblDepreciacion.Text = String.Empty
            lblValorResidual.Text = String.Empty
            lblTope.Text = String.Empty
            dgvMantenimientoDepreciaciones.Rows.Clear()

        End Sub


        Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click
            Try
                Dim ids As New List(Of String)()

                For Each row As DataGridViewRow In dgvActivoFijo.Rows
                    Dim id As String = row.Cells(0).Value.ToString()
                    ids.Add(id)
                Next

                dgvMantenimientoDepreciaciones.DataSource = _objDetalleDepreciacion.SeleccionarDetallesDepreciacionPorIdDepreciacion(_tipoCon, ids)
                dgvMantenimientoDepreciaciones.AutoResizeColumns()
                dgvMantenimientoDepreciaciones.AutoResizeRows()
                dgvMantenimientoDepreciaciones.ReadOnly = False
                dgvMantenimientoDepreciaciones.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch
                dgvMantenimientoDepreciaciones.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvMantenimientoDepreciaciones_CellClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvMantenimientoDepreciaciones.CellClick
            If dgvMantenimientoDepreciaciones.RowCount = 0 Or dgvMantenimientoDepreciaciones.CurrentRow Is Nothing Then Return
            txtIdDepreciacion.Text = dgvMantenimientoDepreciaciones.CurrentRow.Cells.Item(0).Value.ToString()
            txtFecha.Text = dgvMantenimientoDepreciaciones.CurrentRow.Cells.Item(1).Value.ToString()
            txtNroDepreciacion.Text = dgvMantenimientoDepreciaciones.CurrentRow.Cells.Item(2).Value.ToString()
            txtValorDepreciacion.Text = dgvMantenimientoDepreciaciones.CurrentRow.Cells.Item(3).Value.ToString()
            txtValorResidual.Text = dgvMantenimientoDepreciaciones.CurrentRow.Cells.Item(4).Value.ToString()
            txtTope.Text = dgvActivoFijo.CurrentRow.Cells.Item(4).Value.ToString()
        End Sub
        Private Sub btnDepreciar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnDepreciar.Click
            Try
                Dim Valor As Decimal = Convert.ToDecimal(dgvActivoFijo.CurrentRow.Cells.Item(6).Value) 'Valor de Factura
                Dim Porcentaje As Decimal = Convert.ToDecimal(dgvActivoFijo.CurrentRow.Cells.Item(2).Value)

                If dgvActivoFijo.CurrentRow.Cells.Item(6).Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(dgvActivoFijo.CurrentRow.Cells.Item(6).Value.ToString()) Then
                    Valor = Convert.ToDecimal(dgvActivoFijo.CurrentRow.Cells.Item(6).Value)
                Else
                    MsgBox("El valor de factura no puede estar vacío.", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                    Return
                End If

                If dgvActivoFijo.CurrentRow.Cells.Item(2).Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(dgvActivoFijo.CurrentRow.Cells.Item(2).Value.ToString()) Then
                    Porcentaje = Convert.ToDecimal(dgvActivoFijo.CurrentRow.Cells.Item(2).Value)
                Else
                    MsgBox("El porcentaje no puede estar vacío.", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
                    Return
                End If

                lblIdDepreciacion.Text = dgvActivoFijo.CurrentRow.Cells.Item(0).Value.ToString()
                lblFecha.Text = dgvActivoFijo.CurrentRow.Cells.Item(7).Value.ToString()
                lblNro.Text = dgvMantenimientoDepreciaciones.CurrentRow.Cells.Item(2).Value.ToString() + 1
                lblDepreciacion.Text = (Valor * Porcentaje)
                lblValorResidual.Text = Decimal.Round((Valor * Porcentaje), 3).ToString()
                lblTope.Text = dgvActivoFijo.CurrentRow.Cells.Item(4).Value.ToString()
            Catch
                MsgBox("Por favor cargue el detalle de Depreciacion anterior", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            End Try

        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If txtIdDepreciacion.Text <> "" Then

                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()
                Dim id = Convert.ToInt32(dgvActivoFijo.CurrentRow.Cells.Item(0).Value)
                Dim Idrepe = _objDetalleDepreciacion.BuscarIdDetalleDepreciacionRepetido(_tipoCon, id)

                If (Idrepe = id) Then
                    MessageBox.Show("LA DEPRECIACION YA SE REALIZO!!", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                Dim idde = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + 1
                Dim Valor As Decimal = Convert.ToDecimal(dgvActivoFijo.CurrentRow.Cells.Item(6).Value) 'Valor de Factura
                Dim Porcentaje As Decimal = Convert.ToDecimal(lblValorResidual.Text.ToString())
                Dim Fech As String = lblFecha.Text
                Dim fecha As DateTime = DateTime.Parse(Fech)

                _objDetalleDepreciacion.ValorResidualDepreciacion = Valor
                _objDetalleDepreciacion.ValorDepreciacion = 0.0


                For i = 1 To Convert.ToInt32(lblTope.Text)

                    With _objDetalleDepreciacion
                        .IdDetalle = idde
                        .Fecha = fecha
                        .NumeroDepreciacion = i
                        .ValorDepreciacion += Porcentaje
                        .ValorResidualDepreciacion -= Porcentaje
                        .Estado = 1
                        .IdDetalleGeneral = dgvActivoFijo.CurrentRow.Cells.Item(0).Value.ToString()
                        _sqlCommands.Add(_objDetalleDepreciacion.NuevaDetalleDepreciacion())
                    End With
                    fecha = fecha.AddYears(1)
                    idde += 1

                Next
                Auditoria()
                'With _objDetalleDepreciacion
                '    .IdDetalle = lblIdDepreciacion.Text
                '    .Fecha = Date.Now
                '    .NumeroDepreciacion = lblNro.Text
                '    .ValorResidualDepreciacion = CDec(lblValorResidual.Text)
                '    .ValorDepreciacion = CDec(lblDepreciacion.Text)
                '    .Estado = 1
                'End With
                '_sqlCommands.Add(_objDetalleDepreciacion.NuevaDetalleDepreciacion)


                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then btnCargar_Click(Nothing, Nothing)
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("No se puede guardar si no tiene un identificador de Depreciación", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            End If
        End Sub
        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            Dim formReporteDepreciacion As New FormReporteDepreciaciones
            formReporteDepreciacion.TipoCox = TipoCox
            formReporteDepreciacion.lblIdDepreciacion.Text = txtIdDepreciacion.Text
            formReporteDepreciacion.ShowDialog()
        End Sub
        Private Sub FormDepreciaciones_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvActivoFijo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvMantenimientoDepreciaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvActivoFijo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvMantenimientoDepreciaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvActivoFijo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvMantenimientoDepreciaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvActivoFijo.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvMantenimientoDepreciaciones.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
        End Sub
    End Class
End Namespace