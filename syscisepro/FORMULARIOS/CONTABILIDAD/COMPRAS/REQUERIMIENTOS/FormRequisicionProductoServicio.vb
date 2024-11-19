Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.REQUISICIONES
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.ITEMS
Imports ClassLibraryCisepro.ProcesosSql
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.VisualBasic.ApplicationServices

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.REQUERIMIENTOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormRequisicionProductoServicio
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
        Dim _sqlCommands As List(Of SqlCommand)

        ReadOnly _objVal As New ClassNumerico
        ReadOnly _objetoSecuencialItem As New ClassSecuencialItem
        ReadOnly _objetoRequisicionProductoServicio As New ClassRequisicionProductoServicio
        ReadOnly _objetoDetalleRequisicionProductoServicio As New ClassDetalleRequisicionProductoServicio

        Private Sub FormRequisicionProductoServicio_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    panelDetalle.ForeColor = Color.White
                    panelDetalle.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleRequisicionPS.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    panelDetalle.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    panelDetalle.ForeColor = Color.White
                    dgvDetalleRequisicionPS.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    panelDetalle.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    panelDetalle.ForeColor = Color.White
                    dgvDetalleRequisicionPS.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvDetalleRequisicionPS.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            DeshabilitadoInicio()
        End Sub
        Public Sub DeshabilitadoInicio()
            txtIdRequisicionProductoServicio.Enabled = False
            txtFechaRequisicionProducto.Enabled = False
            txtNombrePersonal.Enabled = False
            btnBuscarPersonal.Enabled = False
            rbEntregaUrgente.Enabled = False
            rbEntregaNormal.Enabled = False
            txtEntregaNumeroDias.Enabled = False

            dgvDetalleRequisicionPS.ReadOnly = True

            btnEliminar.Enabled = False
            btnNuevo.Enabled = True
            btnCancelar.Enabled = False
            btnGuardar.Enabled = False
        End Sub
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            LimpiarParametros()
            HabilitadoNuevo()
            txtEntregaNumeroDias.Text = "1"
            txtFechaRequisicionProducto.Text = ValidationForms.FechaActual(_tipoCon)
        End Sub
        Public Sub HabilitadoNuevo()
            btnBuscarPersonal.Enabled = True
            rbEntregaUrgente.Enabled = True
            rbEntregaNormal.Enabled = True
            txtEntregaNumeroDias.Enabled = True

            dgvDetalleRequisicionPS.ReadOnly = False

            btnEliminar.Enabled = True
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            DeshabilitadoInicio()
            LimpiarParametros()
        End Sub
        Public Sub LimpiarParametros()
            rbEntregaUrgente.Checked = False
            rbEntregaNormal.Checked = True
            txtEntregaNumeroDias.Clear()
            txtIdRequisicionProductoServicio.Clear()
            txtNombrePersonal.Clear()
            txtFechaRequisicionProducto.Clear()
            lblIdPersonal.Text = ""
            dgvDetalleRequisicionPS.Rows.Clear()
        End Sub
        Public Function ValidarParametros() As Boolean
            Return lblIdPersonal.Text.Trim.Length > 0 And txtFechaRequisicionProducto.Text.Trim.Length > 0 And txtNombrePersonal.Text.Trim.Length > 0 And txtEntregaNumeroDias.Text.Trim.Length > 0
        End Function
        Private Sub dgvDetalleRequisicionPS_CellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleRequisicionPS.CellEndEdit
            BuscarItemRepetidoDatagridview()
        End Sub
        Public Sub BuscarItemRepetidoDatagridview()
            Try
                If dgvDetalleRequisicionPS.CurrentRow.Cells(1).Value <> "" And dgvDetalleRequisicionPS.CurrentCell.ColumnIndex = 1 Then
                    For indice = 0 To dgvDetalleRequisicionPS.RowCount - 2
                        If indice <> dgvDetalleRequisicionPS.CurrentRow.Index Then
                            If dgvDetalleRequisicionPS.Rows(indice).Cells(1).Value.ToString <> dgvDetalleRequisicionPS.CurrentRow.Cells(1).Value.ToString Then
                                Dim tab = _objetoSecuencialItem.SeleccionarSecuencialItemsXNombre(_tipoCon, dgvDetalleRequisicionPS.CurrentRow.Cells(1).Value.ToString)
                                If tab.Rows.Count = 0 Then
                                    dgvDetalleRequisicionPS.CurrentRow.Cells(0).Value = ""
                                    dgvDetalleRequisicionPS.CurrentRow.Cells(1).Value = ""
                                    dgvDetalleRequisicionPS.CurrentRow.Cells(2).Value = ""
                                    dgvDetalleRequisicionPS.CurrentRow.Cells(3).Value = ""
                                    dgvDetalleRequisicionPS.CurrentRow.Cells(4).Value = ""
                                    dgvDetalleRequisicionPS.CurrentRow.Cells(5).Value = ""
                                    MsgBox("EL ITEM INGRESADO NO SE ENCUENTRA EN LA BASE DE DATOS. POR FAVOR REGISTRELO ANTES DE INGRESARLO EN LA REQUISICIÓN", MsgBoxStyle.Exclamation, "Mensaje de validación")
                                    Return
                                End If
                                dgvDetalleRequisicionPS.CurrentRow.Cells(0).Value = tab.Rows(0)(0).ToString
                                dgvDetalleRequisicionPS.CurrentRow.Cells(1).Value = tab.Rows(0)(2).ToString
                                dgvDetalleRequisicionPS.CurrentRow.Cells(2).Value = tab.Rows(0)(18).ToString
                                dgvDetalleRequisicionPS.CurrentRow.Cells(3).Value = 1
                            Else
                                MsgBox("EL ITEM SELECCIONADO YA ESTA AGREGADO A LA REQUISICION.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                                dgvDetalleRequisicionPS.CurrentRow.Cells(1).Value = ""
                                dgvDetalleRequisicionPS.Rows.RemoveAt(dgvDetalleRequisicionPS.CurrentRow.Index)
                                Exit For
                            End If
                        Else
                            Dim tab = _objetoSecuencialItem.SeleccionarSecuencialItemsXNombre(_tipoCon, dgvDetalleRequisicionPS.CurrentRow.Cells(1).Value.ToString)
                            If tab.Rows.Count = 0 Then
                                dgvDetalleRequisicionPS.CurrentRow.Cells(0).Value = ""
                                dgvDetalleRequisicionPS.CurrentRow.Cells(1).Value = ""
                                dgvDetalleRequisicionPS.CurrentRow.Cells(2).Value = ""
                                dgvDetalleRequisicionPS.CurrentRow.Cells(3).Value = ""
                                dgvDetalleRequisicionPS.CurrentRow.Cells(4).Value = ""
                                dgvDetalleRequisicionPS.CurrentRow.Cells(5).Value = ""
                                MsgBox("EL ITEM INGRESADO NO SE ENCUENTRA EN LA BASE DE DATOS. POR FAVOR REGISTRELO ANTES DE INGRESARLO EN LA REQUISICIÓN", MsgBoxStyle.Exclamation, "Mensaje de validación")
                                Return
                            End If
                            dgvDetalleRequisicionPS.CurrentRow.Cells(0).Value = tab.Rows(0)(0).ToString
                            dgvDetalleRequisicionPS.CurrentRow.Cells(1).Value = tab.Rows(0)(2).ToString
                            dgvDetalleRequisicionPS.CurrentRow.Cells(2).Value = tab.Rows(0)(18).ToString
                            dgvDetalleRequisicionPS.CurrentRow.Cells(3).Value = 1
                        End If
                    Next
                End If
            Catch ex As Exception
                MsgBox("BUSCAR ID DE ITEM." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
            End Try
        End Sub
        Private Sub btnBuscarPersonal_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarPersonal.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.TipoCox = TipoCox
            frm.Todos = True
            frm.rbtProveedor.Visible = False
            frm.rbtPersonal.Checked = True
            frm.rbtCliente.Visible = False
            frm.txtParametrobusqueda.Width = frm.txtParametrobusqueda.Width + frm.rbtProveedor.Width + frm.rbtPersonal.Width
            frm.rbtPersonal.Location = New Point(frm.txtParametrobusqueda.Width + frm.Label1.Width + 10, 4)
            Try
                If frm.ShowDialog = vbOK Then
                    If frm.rbtPersonal.Checked Then
                        lblIdPersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        txtNombrePersonal.Text = frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                    End If
                End If
            Catch ex As Exception
                lblIdPersonal.Text = ""
                txtNombrePersonal.Clear()
            End Try
        End Sub
        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click
            If dgvDetalleRequisicionPS.RowCount < 2 Then Return
            If dgvDetalleRequisicionPS.CurrentRow.Index = dgvDetalleRequisicionPS.RowCount - 1 Then Return
            dgvDetalleRequisicionPS.Rows.RemoveAt(dgvDetalleRequisicionPS.CurrentRow.Index)
        End Sub
        Private Sub dgvDetalleRequisicionPS_EditingControlShowing(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDetalleRequisicionPS.EditingControlShowing
            Dim itemName = TryCast(e.Control, TextBox)
            If itemName Is Nothing Then Return
            itemName.CharacterCasing = CharacterCasing.Upper
            itemName.AutoCompleteMode = AutoCompleteMode.None
            RemoveHandler itemName.KeyPress, AddressOf ItemQuantity_KeyPress 'cambio
            If dgvDetalleRequisicionPS.CurrentCell.ColumnIndex = 1 Then
                itemName.AutoCompleteCustomSource = _objetoSecuencialItem.Autocompletar(_tipoCon)
                itemName.AutoCompleteMode = AutoCompleteMode.Suggest
                itemName.AutoCompleteSource = AutoCompleteSource.CustomSource
            End If
            If dgvDetalleRequisicionPS.CurrentCell.ColumnIndex = 3 Then AddHandler itemName.KeyPress, AddressOf ItemQuantity_KeyPress
        End Sub
        Private Sub ItemQuantity_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles dgvDetalleRequisicionPS.KeyPress
            e.Handled = Not _objVal.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtEntregaNumeroDias_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntregaNumeroDias.KeyPress
            e.Handled = Not _objVal.EsNumero(e.KeyChar)
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If dgvDetalleRequisicionPS.RowCount > 0 Then
                If ValidarParametros() Then

                    If MessageBox.Show("¿ESTA SEGUR@ QUE DESEA GUARDAR?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                    _sqlCommands.Clear()

                    GuardarRegistroRequisicionProductoServicio()
                    GuardarRegistroDetalleRequisicionProductoServicio()

                    Dim nombreU As String = "Requisicion Producto Servicio: " & UserName
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                    If res(0) Then
                        DeshabilitadoInicio()
                    End If
                    MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
                Else
                    MsgBox("No se puede guardar." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                End If
            Else
                MsgBox("No se puede guardar." & vbNewLine & "NO HA AGREGADO NINGÚN ITEM A LA REQUISICIÓN.", MsgBoxStyle.Exclamation, "Mensaje de validación")
            End If
        End Sub 
        Public Sub GuardarRegistroRequisicionProductoServicio()
            txtIdRequisicionProductoServicio.Text = _objetoRequisicionProductoServicio.BuscarMayorIdRequisicionProductoServicio(_tipoCon) + 1
            With _objetoRequisicionProductoServicio
                .IdRequisicionPs = CInt(txtIdRequisicionProductoServicio.Text)
                .FechaRequisicionPs = txtFechaRequisicionProducto.Text
                .IdPersonal = lblIdPersonal.Text
                If rbEntregaUrgente.Checked Then
                    .PrioridadEntregaRequisicionPs = rbEntregaUrgente.Text
                ElseIf rbEntregaNormal.Checked Then
                    .PrioridadEntregaRequisicionPs = rbEntregaNormal.Text
                End If
                .TiempoEntregaRequisicionPs = txtEntregaNumeroDias.Text + " DÍAS"
                .EstadoRequisicionPs = 1 'Se encuentra solo activa
            End With
            _sqlCommands.Add(_objetoRequisicionProductoServicio.NuevoRegistroRequisicionProductoServicio)
        End Sub
        Public Sub GuardarRegistroDetalleRequisicionProductoServicio()
            Dim id = _objetoDetalleRequisicionProductoServicio.BuscarMayorIdDetalleRequisicionProductoServicio(_tipoCon) + 1
            For indice = 0 To dgvDetalleRequisicionPS.RowCount - 1
                If (dgvDetalleRequisicionPS.Rows(indice).Cells(0).Value & "").ToString.Trim.Length = 0 Then Continue For
                With _objetoDetalleRequisicionProductoServicio
                    .IdDetalleRequisicioPs = id
                    .IdSecuencialItem = dgvDetalleRequisicionPS.Rows(indice).Cells(0).Value
                    .UmedidaDetalleRequisicioPs = dgvDetalleRequisicionPS.Rows(indice).Cells(2).Value
                    .CantidadDetalleRequisicioPs = dgvDetalleRequisicionPS.Rows(indice).Cells(3).Value
                    '.EspecificacionesDetalleRequisicioPs = dgvDetalleRequisicionPS.Rows(indice).Cells(4).Value.ToString.ToUpper
                    '.ObservaionesDetalleRequisicioPs = dgvDetalleRequisicionPS.Rows(indice).Cells(5).Value.ToString.ToUpper
                    .EspecificacionesDetalleRequisicioPs = If(String.IsNullOrEmpty(dgvDetalleRequisicionPS.Rows(indice).Cells(4).Value?.ToString()), "-", dgvDetalleRequisicionPS.Rows(indice).Cells(4).Value.ToString().ToUpper())
                    .ObservaionesDetalleRequisicioPs = If(String.IsNullOrEmpty(dgvDetalleRequisicionPS.Rows(indice).Cells(5).Value?.ToString()), "-", dgvDetalleRequisicionPS.Rows(indice).Cells(5).Value.ToString().ToUpper())
                    .EstadoDetalleRequisicioPs = 1
                    .IdRequisicioPs = txtIdRequisicionProductoServicio.Text
                End With
                _sqlCommands.Add(_objetoDetalleRequisicionProductoServicio.NuevoRegistroDetalleRequisicionProductoServicio)
                id += 1
            Next
        End Sub         

        Private Sub dgvDetalleRequisicionPS_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleRequisicionPS.CellContentClick

        End Sub
    End Class
End Namespace