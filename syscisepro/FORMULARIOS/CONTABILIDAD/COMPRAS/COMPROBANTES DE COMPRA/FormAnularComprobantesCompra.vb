Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.COMPROBANTES_RETENCION
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.USUARIOS_DEL_SISTEMA
Imports Krypton.Toolkit

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.COMPROBANTES_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAnularComprobantesCompra
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
        Dim _notSelect As List(Of Integer)

        ReadOnly _objetoComprobantesCompra As New ClassComprobantesCompra
        ReadOnly _objetoPagosComprobantesCompra As New ClassPagosComprobantesCompra
        ReadOnly _objetoComprobanteRetencion As New ClassComprobantesRetencion
        ReadOnly _objetoDetalleComprobantesRetencion As New ClassDetalleComprobantesRetencion
        ReadOnly _objetoProveedorGeneral As New ClassProveedores
        ReadOnly _objetoNumeroRegistroAsientoComprobanteCompra As New ClassNumeroRegistroAsientoComprobanteCompra
        ReadOnly _objetoAts As New ClassAnexoTransaccional
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objUser As New ClassUsuarioGeneral

        Dim _sqlCommands As List(Of SqlCommand)

        Private Sub FormAnularComprobantesCompra_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvComprobantesCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvComprobantesCompra.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            _notSelect = New List(Of Integer)

            AutocompletarNombreProveedor()
        End Sub

        Private Sub AutocompletarNombreProveedor()
            Try
                txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = _objetoProveedorGeneral.Autocompletar(_tipoCon)
                txtNombreComercialProveedorGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialProveedorGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub txtNombreComercialProveedorGeneral_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialProveedorGeneral.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            lblIdProveedorGeneral.Text = _objetoProveedorGeneral.BuscarIdProveedorXRazonSocialProveedor(_tipoCon, txtNombreComercialProveedorGeneral.Text)
            CargarComprobantesCompra()
        End Sub
        Private Sub CargarComprobantesCompra()
            Try
                Dim fechaDesde = dtpAsientoDesde.Value.Day.ToString & "-" & dtpAsientoDesde.Value.Month.ToString & "-" & dtpAsientoDesde.Value.Year.ToString & " 00:00:00"
                Dim fechaHasta = dtpAsientoHasta.Value.Day.ToString & "-" & dtpAsientoHasta.Value.Month.ToString & "-" & dtpAsientoHasta.Value.Year.ToString & " 23:59:59"

                dgvComprobantesCompra.DataSource = _objetoComprobantesCompra.SeleccionarComrpobantesCompraActiosXIdProveedorRangoFechaComprobante(_tipoCon, lblIdProveedorGeneral.Text, fechaDesde, fechaHasta)
                dgvComprobantesCompra.Columns(1).HeaderText = "ID"
                'dgvComprobantesCompra.Columns(1).Width = 60
                dgvComprobantesCompra.Columns(2).Visible = False
                dgvComprobantesCompra.Columns(3).HeaderText = "TIPO"
                'dgvComprobantesCompra.Columns(3).Width = 120
                dgvComprobantesCompra.Columns(4).HeaderText = "NUM."
                'dgvComprobantesCompra.Columns(4).Width = 150
                dgvComprobantesCompra.Columns(5).HeaderText = "AUTORIZACIÓN"
                'dgvComprobantesCompra.Columns(5).Width = 300
                dgvComprobantesCompra.Columns(6).HeaderText = "F. AUTORIZACIÓN"
                'dgvComprobantesCompra.Columns(6).Width = 120
                dgvComprobantesCompra.Columns(6).DefaultCellStyle.Format = "d"
                dgvComprobantesCompra.Columns(7).HeaderText = "F. EMISIÓN"
                'dgvComprobantesCompra.Columns(7).Width = 120
                dgvComprobantesCompra.Columns(7).DefaultCellStyle.Format = "d"
                dgvComprobantesCompra.Columns(8).Visible = False
                dgvComprobantesCompra.Columns(9).Visible = False
                dgvComprobantesCompra.Columns(10).HeaderText = "RAZÓN"
                'dgvComprobantesCompra.Columns(10).Width = 300
                dgvComprobantesCompra.Columns(11).HeaderText = "OBSERVACIÓN"
                'dgvComprobantesCompra.Columns(11).Width = 300

                dgvComprobantesCompra.Columns(12).HeaderText = "SUBTOTAL 12"
                dgvComprobantesCompra.Columns(13).HeaderText = "SUBTOTAL 0"
                dgvComprobantesCompra.Columns(14).HeaderText = "DESCUENTO"
                dgvComprobantesCompra.Columns(15).HeaderText = "SUBTOTAL"
                dgvComprobantesCompra.Columns(16).HeaderText = "% IVA"
                dgvComprobantesCompra.Columns(17).HeaderText = "IVA"
                dgvComprobantesCompra.Columns(18).HeaderText = "TOTAL"
                dgvComprobantesCompra.Columns(19).Visible = False

                dgvComprobantesCompra.AutoResizeColumns()
                dgvComprobantesCompra.AutoResizeRows()
                'indexNoAnular.Clear()

            Catch ex As Exception
                dgvComprobantesCompra.DataSource = Nothing
                'MsgBox("METODO CARGAR COMPROBANTES DE COMPRA" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Metodo cargar comprobantes de compra" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        
        Private Sub dgvComprobantesCompra_CellContentClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvComprobantesCompra.CellContentClick
            If e.ColumnIndex = chk.Index Then
                If CBool(dgvComprobantesCompra.CurrentCell.EditedFormattedValue) Then
                    Dim fechaComprobante = dgvComprobantesCompra.Rows(dgvComprobantesCompra.CurrentRow.Index).Cells(7).Value ' recibe la fecha del comprobante
                    If _objetoAts.ValidarCompraConDeclaracion(_tipoCon, fechaComprobante) Then ' si el comprobante fue declarado
                        If Not _notSelect.Contains(dgvComprobantesCompra.CurrentCell.RowIndex) Then _notSelect.Add(dgvComprobantesCompra.CurrentCell.RowIndex)
                        'MsgBox("EL ATS DEL MES " & fechaComprobante.Month.ToString & " DEL AÑO " & fechaComprobante.Year.ToString & " YA FUE GENERADO." & vbNewLine & " SI NECESITA ELIMINAR ESTE COMPROBANTE SOLICITE UNA SUSTUTIVA A LA CONTADORA Y HAGA UNA REQUISICIÓN AL DEPARTAMENTO DE SISTEMAS.", MsgBoxStyle.Information, "Mensaje de validación")
                        KryptonMessageBox.Show("El ATS del mes " & fechaComprobante.Month.ToString & " del año " & fechaComprobante.Year.ToString & " ya fue generado." & vbNewLine & "Si necesita eliminar este comprobante solicite una sustutiva a la contadora y haga una requisición al departamento de sistemas.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Else
                        If _objetoPagosComprobantesCompra.BuscarMayorSaldoPagosComprobantesCompraXIdComprobante(_tipoCon, dgvComprobantesCompra.CurrentRow.Cells(1).Value) = 0 Then
                            If Not _notSelect.Contains(dgvComprobantesCompra.CurrentCell.RowIndex) Then _notSelect.Add(dgvComprobantesCompra.CurrentCell.RowIndex)
                            'MsgBox("ESTA FACTURA YA FUE CANCELADA POR LO TANTO NO SERÁ ANULADA!", MsgBoxStyle.Information, "Mensaje de validación")
                            KryptonMessageBox.Show("Esta factura ya fue cancelada por lo tanto no será anulada!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                        Else
                            Dim si = _objetoComprobantesCompra.SeleccionarPagosActivoXIdComprobante(_tipoCon, CLng(dgvComprobantesCompra.CurrentRow.Cells(1).Value))
                            If si.Rows.Count > 1 Or si.Rows(0)(2) > 1 Then
                                If Not _notSelect.Contains(dgvComprobantesCompra.CurrentCell.RowIndex) Then _notSelect.Add(dgvComprobantesCompra.CurrentCell.RowIndex)
                                'MsgBox("ESTA FACTURA YA REGISTRA PAGOS. ANULE PRIMERO LOS PAGOS CORRESPONDIENTES O LA FACTURA NO SERÁ ANULADA!", MsgBoxStyle.Information, "Mensaje de validación")
                                KryptonMessageBox.Show("Esta factura ya registra pagos. Anule primero los pagos correspondientes o la factura no será anulada!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                            End If
                        End If
                    End If
                End If
            End If
            dgvComprobantesCompra.EndEdit()
        End Sub

        Private Sub dgvComprobantesCompra_CellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvComprobantesCompra.CellEndEdit
            For Each row As DataGridViewRow In From row1 As DataGridViewRow In dgvComprobantesCompra.Rows Where _notSelect.Contains(row1.Index)
                row.Cells(0).Value = False
            Next
            _notSelect.Clear()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnular.Click
            If dgvComprobantesCompra.RowCount > 0 Then
                If dgvComprobantesCompra.CurrentRow Is Nothing Then Return
                _sqlCommands.Clear()

                ActualizarEstadoComprobanteCompra()


                Dim nombreU As String = "Comprobante Compra anulado por: " & UserName
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                If res(0) Then
                    CargarComprobantesCompra()
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If



            Else
                'MsgBox("NO HAY RESULTADOS DE BUSQUEDA No se puede guardar CAMBIOS.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("No hay resultados de busqueda No se puede guardar cambios.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Sub ActualizarEstadoComprobanteCompra()
            For indiceCompCompra = 0 To dgvComprobantesCompra.RowCount - 1
                If CBool(dgvComprobantesCompra.Rows(indiceCompCompra).Cells(0).EditedFormattedValue) Then ' Si la fila de la grilla esta checkeada 

                    Dim fechaComprobante = dgvComprobantesCompra.Rows(indiceCompCompra).Cells(7).Value ' recibe la fecha del comprobante
                    If _objetoAts.ValidarCompraConDeclaracion(_tipoCon, fechaComprobante) Then ' si el comprobante fue declarado
                        'MsgBox("EL ATS DEL MES " & fechaComprobante.Month.ToString & " DEL AÑO " & fechaComprobante.Year.ToString & " YA FUE GENERADO." & vbNewLine & " SI NECESITA ELIMINAR ESTE COMPROBANTE SOLICITE UNA SUSTUTIVA A LA CONTADORA Y HAGA UNA REQUISICIÓN AL DEPARTAMENTO DE SISTEMAS.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                        KryptonMessageBox.Show("El ATS del mes " & fechaComprobante.Month.ToString & " del año " & fechaComprobante.Year.ToString & " ya fue generado." & vbNewLine & "Si necesita eliminar este comprobante solicite una sustutiva a la contadora y haga una requisición al departamento de sistemas.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                    Else

                        With _objetoComprobantesCompra
                            .IdComprobante = dgvComprobantesCompra.Rows(indiceCompCompra).Cells(1).Value
                            .EstadoComprobante = 0
                            '.ActualizarEstadoComprobanteCompra(_tipoCon)
                        End With
                        _sqlCommands.Add(_objetoComprobantesCompra.ActualizarEstadoComprobanteCompras)

                        'ANULAR PAGOS
                        With _objetoComprobantesCompra
                            .IdComprobante = dgvComprobantesCompra.Rows(indiceCompCompra).Cells(1).Value
                            .EstadoComprobante = 0
                            '.ActualizarEstadoPagosComprobanteCompra(_tipoCon)
                        End With
                        _sqlCommands.Add(_objetoComprobantesCompra.ActualizarEstadoPagosComprobanteCompras)

                        'CARGAR COMPROBANTE RETENCIÓN
                        Dim ret = _objetoComprobanteRetencion.SeleccionarComrpobantesRetencionXIdComprobanteCompra(_tipoCon, dgvComprobantesCompra.Rows(indiceCompCompra).Cells(1).Value)
                        If ret.Rows.Count > 0 Then ' si hay retención
                            With _objetoComprobanteRetencion
                                .IdComprobanteRetencion = ret.Rows(0)(0)
                                .EstadoComprobanteRetencion = 0
                                '.ActualizarEstadoComprobanteRetencionCompra(_tipoCon)
                            End With
                            _sqlCommands.Add(_objetoComprobanteRetencion.ActualizarEstadoComprobanteRetencionCompra)

                            'CARGAR DETALLE COMPROBANTE RETENCIÓN
                            Dim dret = _objetoDetalleComprobantesRetencion.SeleccionarRegistrosDetallesComprobanteRetencionCompraXIdComprobanteRetencion(_tipoCon, ret.Rows(0)(0))
                            If dret.Rows.Count > 0 Then
                                For indiceDetCompRet = 0 To dret.Rows.Count - 1
                                    With _objetoDetalleComprobantesRetencion
                                        .IdDetalleComprobanteRetencion = dret.Rows(indiceDetCompRet)(0)
                                        .EstadoDetalleComprobanteRetencion = 0
                                        '.ActualizarEstadoDetalleComprobanteRetencionCompra(_tipoCon)
                                    End With
                                    _sqlCommands.Add(_objetoDetalleComprobantesRetencion.ActualizarEstadoDetalleComprobanteRetencionCompra)
                                Next
                            End If
                        End If
                         

                        AnularAsientoLibroDiarioXNumeroRegistro()

                    End If
                End If
            Next
        End Sub
        Private Sub AnularAsientoLibroDiarioXNumeroRegistro()
            For i = 0 To dgvComprobantesCompra.RowCount - 1
                If CBool(dgvComprobantesCompra.Rows(i).Cells(0).EditedFormattedValue) Then ' Si la fila de la grilla esta checkeada 
                    With _objetoAsientoLibroDiario
                        .NumeroRegistroAsiento = _objetoNumeroRegistroAsientoComprobanteCompra.BuscarNumeroRegistroAsientoPorIdComprobanteCompra(_tipoCon, dgvComprobantesCompra.Rows(i).Cells(1).Value)
                        '.AnularAsientoLibroDiarioXNumeroRegistro()
                    End With
                    _sqlCommands.Add(_objetoAsientoLibroDiario.AnularAsientoLibroDiarioXNumeroRegistro)
                End If
            Next
        End Sub

        Private Sub dtpAsientoDesde_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dtpAsientoHasta.ValueChanged, dtpAsientoDesde.ValueChanged
            If lblIdProveedorGeneral.Text.Trim().Length = 0 Or lblIdProveedorGeneral.Text.Trim() = "..." Then Return
            CargarComprobantesCompra()
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            If lblIdProveedorGeneral.Text.Trim().Length = 0 Or lblIdProveedorGeneral.Text.Trim() = "..." Then Return
            CargarComprobantesCompra()
        End Sub 
    End Class
End Namespace