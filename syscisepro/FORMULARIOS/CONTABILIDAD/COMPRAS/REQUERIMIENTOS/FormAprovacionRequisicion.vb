Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.REQUISICIONES
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports syscisepro.DATOS
Imports Krypton.Toolkit



Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.REQUERIMIENTOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAprovacionRequisicion
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
        Public UserName As String

        ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoRequisicionProductoServicio As New ClassRequisicionProductoServicio
        ReadOnly _objetoDetalleRequisicionProductoServicio As New ClassDetalleRequisicionProductoServicio
        ReadOnly _validacionesNumeros As New ClassNumerico

        Dim _sqlCommands As List(Of SqlCommand)

        Private Sub FormAprovacionRequisicion_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleRequisicionProductoServicio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvRequisicionProductoServicio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvRequisicionProductoServicio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleRequisicionProductoServicio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvRequisicionProductoServicio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleRequisicionProductoServicio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            _sqlCommands = New List(Of SqlCommand)
            dgvRequisicionProductoServicio.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleRequisicionProductoServicio.Font = New Font("Roboto", 8, FontStyle.Regular)
            DeshabilitadoInicio()
            cargarRequisicionProductoServicio()
        End Sub
        Public Sub DeshabilitadoInicio()
            btnAprovar.Enabled = True
            btnRechazar.Enabled = True
            btnModificar.Enabled = True
            btnCancelar.Enabled = False
            btnGuardar.Enabled = False
            dgvDetalleRequisicionProductoServicio.ReadOnly = True
        End Sub
        Public Sub CargarRequisicionProductoServicio()
            Try
                dgvRequisicionProductoServicio.DataSource = _objetoRequisicionProductoServicio.SeleccionarRegistrosRequisicionProductoServicio(_tipoCon)
                dgvRequisicionProductoServicio.Columns(0).HeaderText = "N°"
                dgvRequisicionProductoServicio.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvRequisicionProductoServicio.Columns(1).HeaderText = "FECHA"
                dgvRequisicionProductoServicio.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvRequisicionProductoServicio.Columns(2).HeaderText = "NOMBRES"
                dgvRequisicionProductoServicio.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvRequisicionProductoServicio.Columns(3).HeaderText = "APELLIDOS"
                dgvRequisicionProductoServicio.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvRequisicionProductoServicio.Columns(4).HeaderText = "PRIORIDAD"
                dgvRequisicionProductoServicio.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvRequisicionProductoServicio.Columns(5).HeaderText = "TIEMPO"
                dgvRequisicionProductoServicio.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvRequisicionProductoServicio.Columns(6).HeaderText = "EST"
                dgvRequisicionProductoServicio.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvRequisicionProductoServicio.AutoResizeColumns()
                dgvRequisicionProductoServicio.AutoResizeRows()
                dgvRequisicionProductoServicio.ReadOnly = True 
            Catch ex As Exception
                'MsgBox("METODO CARGAR REQUISICIONES PRODUCTO/SERVICIO" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Metodo cargar requisiciones producto/servicio" & vbNewLine & ex.Message.ToString, "Mensaje de excepción")
            End Try
        End Sub
        Private Sub dgvRequisicionProductoServicio_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvRequisicionProductoServicio.SelectionChanged
            If dgvRequisicionProductoServicio.RowCount = 0 Then Return
            If dgvRequisicionProductoServicio.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                txtIdRequisicionProductoServicio.Text = ""
            Else
                txtIdRequisicionProductoServicio.Text = dgvRequisicionProductoServicio.CurrentRow.Cells.Item(0).Value
                txtFechaRequisicionProducto.Text = dgvRequisicionProductoServicio.CurrentRow.Cells.Item(1).Value
                txtNombrePersonal.Text = dgvRequisicionProductoServicio.CurrentRow.Cells.Item(2).Value.ToString + " " + dgvRequisicionProductoServicio.CurrentRow.Cells.Item(3).Value.ToString
                txtPrioridadEntregaRequisicion.Text = dgvRequisicionProductoServicio.CurrentRow.Cells.Item(4).Value.ToString
                txtTiempoEntregaRequisicion.Text = dgvRequisicionProductoServicio.CurrentRow.Cells.Item(5).Value.ToString
                dgvRequisicionProductoServicio.Rows(dgvRequisicionProductoServicio.CurrentCell.RowIndex.ToString()).Selected = True
                cargarDetalleRequisicionProductoServicio()
            End If
        End Sub
        Public Sub CargarDetalleRequisicionProductoServicio()
            Try
                dgvDetalleRequisicionProductoServicio.DataSource = _objetoDetalleRequisicionProductoServicio.SeleccionarDetalleRequisicionProductoServicioXIdRequisicion(_tipoCon, CType(txtIdRequisicionProductoServicio.Text, Int64))
                dgvDetalleRequisicionProductoServicio.AutoResizeColumns()
                dgvDetalleRequisicionProductoServicio.AutoResizeRows()
                dgvDetalleRequisicionProductoServicio.Columns(0).HeaderText = "ID"
                dgvDetalleRequisicionProductoServicio.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRequisicionProductoServicio.Columns(0).Width = 35
                dgvDetalleRequisicionProductoServicio.Columns(1).HeaderText = "ITEM"
                dgvDetalleRequisicionProductoServicio.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRequisicionProductoServicio.Columns(1).Width = 250
                dgvDetalleRequisicionProductoServicio.Columns(2).HeaderText = "UM"
                dgvDetalleRequisicionProductoServicio.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRequisicionProductoServicio.Columns(2).Width = 35
                dgvDetalleRequisicionProductoServicio.Columns(3).HeaderText = "CANT"
                dgvDetalleRequisicionProductoServicio.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRequisicionProductoServicio.Columns(3).Width = 40
                dgvDetalleRequisicionProductoServicio.Columns(4).HeaderText = "ESPECIFICACIONES"
                dgvDetalleRequisicionProductoServicio.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRequisicionProductoServicio.Columns(4).Width = 300
                dgvDetalleRequisicionProductoServicio.Columns(5).HeaderText = "OBSERVACIONES"
                dgvDetalleRequisicionProductoServicio.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRequisicionProductoServicio.Columns(5).Width = 300
                dgvDetalleRequisicionProductoServicio.Columns(6).HeaderText = "EST"
                dgvDetalleRequisicionProductoServicio.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRequisicionProductoServicio.Columns(6).Width = 40
                dgvDetalleRequisicionProductoServicio.Columns(7).HeaderText = "ID-REQ"
                dgvDetalleRequisicionProductoServicio.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvDetalleRequisicionProductoServicio.ReadOnly = True
                dgvDetalleRequisicionProductoServicio.Columns(6).Visible = False
                dgvDetalleRequisicionProductoServicio.Columns(7).Visible = False
                dgvDetalleRequisicionProductoServicio.Columns(8).Visible = False
            Catch ex As Exception
                'MsgBox("METODO CARGAR DETALLE REQUISICIONES PRODUCTO/SERVICIO" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Metodo cargar detalle requisiciones producto/servicio" & vbNewLine & ex.Message.ToString, "Mensaje de excepción")
            End Try
        End Sub
        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificar.Click
            If dgvRequisicionProductoServicio.RowCount = 0 Then
                'MsgBox("DEBE SELECCIONAR UN REGISTRO!", MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Debe seleccionar un registro", "Mensaje de excepción")
                Return
            End If
            HabilitadoModificar()
        End Sub
        Public Sub HabilitadoModificar()
            btnAprovar.Enabled = False
            btnRechazar.Enabled = False
            btnModificar.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            If dgvDetalleRequisicionProductoServicio.RowCount = 0 Then Return
            dgvDetalleRequisicionProductoServicio.ReadOnly = False
            dgvDetalleRequisicionProductoServicio.Columns(0).ReadOnly = True
            dgvDetalleRequisicionProductoServicio.Columns(1).ReadOnly = True
            dgvDetalleRequisicionProductoServicio.Columns(2).ReadOnly = True
            dgvDetalleRequisicionProductoServicio.Columns(4).ReadOnly = True
            dgvDetalleRequisicionProductoServicio.Columns(5).ReadOnly = True
            dgvDetalleRequisicionProductoServicio.Columns(7).ReadOnly = True
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            'LimpiarParametros()
            DeshabilitadoInicio()
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If dgvDetalleRequisicionProductoServicio.RowCount = 0 Then Return
            Try
                If KryptonMessageBox.Show("¿Esta segura que desea guardar los cambios?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                'If MessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR LOS CAMBIOS?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

                _sqlCommands.Clear()

                ModificarDetalleSolicitudMensualSuministros()

                Dim nombreU As String = "Aprobacion Requisicion de Producto por: " & UserName
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                If res(0) Then
                    DeshabilitadoInicio()
                    CargarDetalleRequisicionProductoServicio()
                End If

                Dim messageIcon As KryptonMessageBoxIcon
                If res(0) Then
                    messageIcon = KryptonMessageBoxIcon.Information
                Else
                    messageIcon = KryptonMessageBoxIcon.Exclamation
                End If
                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, messageIcon)

                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            Catch ex As Exception
                'MsgBox("HUBO UN PROBLEMA AL GUARDAR CAMBIOS. POR FAVOR, CONTÁCTE AL ADMINISTRADOR!" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Hubo un problema al guardar cambios. Por favor, contácte al administrador!" & vbNewLine & ex.Message.ToString, "Mensaje de excepción")
            End Try
        End Sub
        Public Sub ModificarDetalleSolicitudMensualSuministros()
            For indice = 0 To dgvDetalleRequisicionProductoServicio.RowCount - 1
                With _objetoDetalleRequisicionProductoServicio
                    .IdDetalleRequisicioPs = dgvDetalleRequisicionProductoServicio.Rows(indice).Cells(0).Value
                    .CantidadDetalleRequisicioPs = dgvDetalleRequisicionProductoServicio.Rows(indice).Cells(3).Value
                    .EstadoDetalleRequisicioPs = dgvDetalleRequisicionProductoServicio.Rows(indice).Cells(6).Value
                End With
                _sqlCommands.Add(_objetoDetalleRequisicionProductoServicio.ModificarDetalleRequisicionProductoServicio)
            Next
        End Sub
        Private Sub btnRechazar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRechazar.Click
            If dgvRequisicionProductoServicio.RowCount > 0 And dgvDetalleRequisicionProductoServicio.RowCount > 0 And txtIdRequisicionProductoServicio.Text <> "" Then
                Try
                    If KryptonMessageBox.Show("¿Esta segura que desea rechazar?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                    'If MessageBox.Show("¿ESTA SEGURA QUE DESEA RECHAZAR?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

                    _sqlCommands.Clear()

                    rechazarRequisicionProductoServicio()

                    Dim nombreU As String = "Rechazar adquisicion por: " & UserName
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                    If res(0) Then
                        LimpiarParametros()
                        CargarRequisicionProductoServicio()
                        CargarDetalleRequisicionProductoServicio()
                    End If

                    Dim messageIcon As KryptonMessageBoxIcon
                    If res(0) Then
                        messageIcon = KryptonMessageBoxIcon.Information
                    Else
                        messageIcon = KryptonMessageBoxIcon.Exclamation
                    End If
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, messageIcon)

                    'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

                Catch ex As Exception
                    'MsgBox("HUBO UN PROBLEMA AL RECHAZAR. POR FAVOR, CONTÁCTE AL ADMINISTRADOR!" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                    KryptonMessageBox.Show("Hubo un problema al rechazar. Por favor, contácte al administrador!" & vbNewLine & ex.Message.ToString, "Mensaje de excepción")
                End Try
            Else
                'MsgBox("SELECCIONE UNA REQUISICIÓN PARA PODER RECHAZAR", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Seleccione una requisición para poder rechazar", "Mensaje de validación")
            End If
        End Sub
        Public Sub RechazarRequisicionProductoServicio()
            With _objetoRequisicionProductoServicio
                .IdRequisicionPs = txtIdRequisicionProductoServicio.Text
                .EstadoRequisicionPs = 0
            End With
            _sqlCommands.Add(_objetoRequisicionProductoServicio.ActualizarEstadoRequisicionProductoServicio())
        End Sub
        Public Sub LimpiarParametros()
            txtIdRequisicionProductoServicio.Text = ""
            txtFechaRequisicionProducto.Text = ""
            txtNombrePersonal.Text = ""
            txtPrioridadEntregaRequisicion.Text = ""
            txtTiempoEntregaRequisicion.Text = ""
            dgvRequisicionProductoServicio.DataSource = Nothing
            dgvDetalleRequisicionProductoServicio.DataSource = Nothing
        End Sub
        Private Sub btnAprovar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAprovar.Click
            If dgvRequisicionProductoServicio.RowCount > 0 And dgvDetalleRequisicionProductoServicio.RowCount > 0 And txtIdRequisicionProductoServicio.Text <> "" Then
                Try
                    If KryptonMessageBox.Show("¿Esta segura que desea aprobar?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                    'If MessageBox.Show("¿ESTA SEGURA QUE DESEA APROBAR?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

                    _sqlCommands.Clear()

                    aprovarRequisicionProductoServicio()
                    aprobarDetalleRequisicionProductoServicio()

                    Dim nombreU As String = "Aprobacion Adquisicion de Producto por: " & UserName
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                    If res(0) Then
                        limpiarParametros()
                        CargarRequisicionProductoServicio()
                    End If

                    Dim messageIcon As KryptonMessageBoxIcon
                    If res(0) Then
                        messageIcon = KryptonMessageBoxIcon.Information
                    Else
                        messageIcon = KryptonMessageBoxIcon.Exclamation
                    End If
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, messageIcon)

                    'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

                Catch ex As Exception
                    'MsgBox("HUBO UN PROBLEMA AL APROBAR. POR FAVOR, CONTÁCTE AL ADMINISTRADOR!" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                    KryptonMessageBox.Show("Hubo un problema al aprobar. Por favor, contácte al administrador!" & vbNewLine & ex.Message.ToString, "Mensaje de excepción")
                End Try 
            Else
                MsgBox("SELECCIONE UNA REQUISICIÓN PARA PODER APROBAR", MsgBoxStyle.Exclamation, "Mensaje de validación")
            End If
        End Sub
        Public Sub AprovarRequisicionProductoServicio()
            With _objetoRequisicionProductoServicio
                .IdRequisicionPs = txtIdRequisicionProductoServicio.Text
                .EstadoRequisicionPs = 2 'Esta lista para su revision
            End With
            _sqlCommands.Add(_objetoRequisicionProductoServicio.ActualizarEstadoRequisicionProductoServicio)

            _objAuditoria.AccionAuditoria = "REQUISICIÓN DE PRODUCTO/SERVICIO. Nº: RPS-" + CStr(txtIdRequisicionProductoServicio.Text) _
                                           + " APROBADA. FECHA DE APROBACIÓN: " + ValidationForms.FechaActual(_tipoCon)
            _objAuditoria.FormularioAuditoria = Text.ToUpper
            auditoria()
        End Sub
        Public Sub Auditoria()
            With _objAuditoria
                .IdAuditoria = Convert.ToInt64(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                .IdUsuarioAuditoria = IdUsuario
                .EstadoAuditoria = 1
                .FechaAuditoria = ValidationForms.FechaActual(_tipoCon)
            End With
            _sqlCommands.Add(_objAuditoria.NuevaAuditoria)
        End Sub
        Public Sub AprobarDetalleRequisicionProductoServicio()
            For indice = 0 To dgvDetalleRequisicionProductoServicio.RowCount - 1
                If dgvDetalleRequisicionProductoServicio.Rows(indice).Cells(6).Value.ToString <> 0 Then
                    With _objetoDetalleRequisicionProductoServicio
                        .IdDetalleRequisicioPs = dgvDetalleRequisicionProductoServicio.Rows(indice).Cells(0).Value
                        .CantidadDetalleRequisicioPs = dgvDetalleRequisicionProductoServicio.Rows(indice).Cells(3).Value
                        .EstadoDetalleRequisicioPs = 2
                    End With
                    _sqlCommands.Add(_objetoDetalleRequisicionProductoServicio.ModificarDetalleRequisicionProductoServicio)
                End If
            Next
        End Sub
        Private Sub dgvDetalleRequisicionProductoServicio_EditingControlShowing(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDetalleRequisicionProductoServicio.EditingControlShowing
            Dim itemQuantity = TryCast(e.Control, TextBox)
            If itemQuantity IsNot Nothing Then
                itemQuantity.CharacterCasing = CharacterCasing.Upper
                AddHandler itemQuantity.KeyPress, AddressOf ItemQuantity_KeyPress
            End If
        End Sub
        Private Sub ItemQuantity_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles dgvDetalleRequisicionProductoServicio.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
         
        Private Sub btnRecargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecargar.Click
            CargarRequisicionProductoServicio()
        End Sub
    End Class
End Namespace