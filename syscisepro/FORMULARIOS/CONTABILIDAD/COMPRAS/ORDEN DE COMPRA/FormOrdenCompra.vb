Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.REQUISICIONES
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports ClassLibraryCisepro.INVENTARIOS.ITEMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports Krypton.Toolkit
Imports Microsoft.VisualBasic.ApplicationServices
Imports syscisepro.DATOS


Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.ORDEN_DE_COMPRA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormOrdenCompra

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

        ReadOnly _objetoOrdenCompra As New ClassOrdenCompra
        ReadOnly _objetoDetalleOrdenCompra As New ClassDetalleOrdenCompra

        ReadOnly _objetoRequisicionProductoServicio As New ClassRequisicionProductoServicio
        ReadOnly _objetoDetalleRequisicion As New ClassDetalleRequisicionProductoServicio

        ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoProveedorGeneral As New ClassProveedores
        ReadOnly _objetoCiudad As New ClassCiudades
        ReadOnly _objetoSecuencialItem As New ClassSecuencialItem
        ReadOnly _validacionesNumeros As New ClassNumerico
        ReadOnly _validacionesAlfabetica As New ClassAlfabetico
        ReadOnly _validacionesDecimales As New ClassDecimal
        ReadOnly _validacionesConversion As New ClassConversion

        Private Sub FormOrdenCompra_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    MenuStrip1.ForeColor = Color.White
                    dgvDetalleOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvRequisicionProductoServicio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetalleRequisicionProductoServicio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvDetalleOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvRequisicionProductoServicio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetalleRequisicionProductoServicio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvDetalleOrdenCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvRequisicionProductoServicio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetalleRequisicionProductoServicio.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            _sqlCommands = New List(Of SqlCommand)
            dgvDetalleOrdenCompra.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvRequisicionProductoServicio.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvDetalleRequisicionProductoServicio.Font = New Font("Roboto", 8, FontStyle.Regular)
            AddHandler dgvDetalleOrdenCompra.CellValueChanged, AddressOf dgvDetalleOrdenCompra_CellValueChanged
            AutocompletarNombreProveedor()
            DeshabilitadoInicio()
        End Sub
        Public Sub DeshabilitadoInicio()
            chkReq.Enabled = False
            txtIdOrdenCompra.Enabled = False
            txtFechaOrdenCompra.Enabled = False
            txtRucCiProveedorGeneral.Enabled = False
            txtNombreComercialProveedorGeneral.Enabled = False
            txtLlevaContabilidadProveedorGeneral.Enabled = False
            txtContribuyenteEspecialProveedorGeneral.Enabled = False
            txtDireccionProveedorGeneral.Enabled = False
            txtNombreCiudad.Enabled = False
            txtTelefono1ProveedorGeneral.Enabled = False
            txtEmailProveedorGeneral.Enabled = False
            txtSon.Enabled = False
            cmbFormaPagoOrdenCompra.Enabled = False
            cmbTipoPagoOrdenCompra.Enabled = False
            txtObservacionesOrdenCompra.Enabled = False
            txtSubtotal12OrdenCompra.Enabled = False
            txtSubtotal0OrdenCompra.Enabled = False
            txtDescuentoOrdenCompra.Enabled = False
            txtIvaOrdenCompra.Enabled = False
            txtTotalOrdenCompra.Enabled = False
            btnEliminar.Enabled = False
            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False
            dgvDetalleOrdenCompra.ReadOnly = True
            'dgvRequisicionProductoServicio.Enabled = False
            dgvDetalleRequisicionProductoServicio.Enabled = False
        End Sub
        Public Sub HabilitadoNuevo()
            chkReq.Enabled = True
            txtIdOrdenCompra.Enabled = False
            txtFechaOrdenCompra.Enabled = False
            txtRucCiProveedorGeneral.Enabled = False
            txtNombreComercialProveedorGeneral.Enabled = True
            txtLlevaContabilidadProveedorGeneral.Enabled = False
            txtContribuyenteEspecialProveedorGeneral.Enabled = False
            txtDireccionProveedorGeneral.Enabled = False
            txtNombreCiudad.Enabled = False
            txtTelefono1ProveedorGeneral.Enabled = False
            txtEmailProveedorGeneral.Enabled = False
            cmbFormaPagoOrdenCompra.Enabled = True
            cmbTipoPagoOrdenCompra.Enabled = True
            txtObservacionesOrdenCompra.Enabled = True
            txtDescuentoOrdenCompra.Enabled = False
            btnEliminar.Enabled = True
            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True

            dgvRequisicionProductoServicio.Enabled = True
            dgvDetalleRequisicionProductoServicio.Enabled = True
            dgvDetalleOrdenCompra.ReadOnly = False

            dgvDetalleOrdenCompra.Columns(0).ReadOnly = True
            dgvDetalleOrdenCompra.Columns(2).ReadOnly = True
            dgvDetalleOrdenCompra.Columns(6).ReadOnly = True
        End Sub
        Public Sub LimpiarParametros()
            Label3.Text = "###"
            chkReq.Checked = False
            txtIdOrdenCompra.Text = ""
            txtFechaOrdenCompra.Text = ""
            txtRucCiProveedorGeneral.Text = ""
            txtNombreComercialProveedorGeneral.Text = ""
            txtLlevaContabilidadProveedorGeneral.Text = ""
            txtContribuyenteEspecialProveedorGeneral.Text = ""
            txtDireccionProveedorGeneral.Text = ""
            txtNombreCiudad.Text = ""
            txtTelefono1ProveedorGeneral.Text = ""
            txtEmailProveedorGeneral.Text = ""
            txtObservacionesOrdenCompra.Text = ""
            dgvDetalleOrdenCompra.Rows.Clear()
            dgvRequisicionProductoServicio.Rows.Clear()
            dgvRequisicionProductoServicioNew.Rows.Clear()
            dgvDetalleRequisicionProductoServicio.DataSource = Nothing
        End Sub
        Public Sub AutocompletarNombreProveedor()
            Try
                txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = _objetoProveedorGeneral.Autocompletar(_tipoCon)
                txtNombreComercialProveedorGeneral.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreComercialProveedorGeneral.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreComercialProveedorGeneral.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Public Sub CargarRequisicionProductoServicio()
            Try
                Dim data = _objetoRequisicionProductoServicio.SeleccionarRegistrosAprobadosRequisicionProductoServicio(_tipoCon)
                'For Each row As DataRow In data.Rows
                '    dgvRequisicionProductoServicio.Rows.Add(False, row(0).ToString, row(1).ToString, row(2).ToString, row(3).ToString)
                'Next
                'dgvRequisicionProductoServicio.Columns(2).DefaultCellStyle.Format = "g"

                For Each row As DataRow In data.Rows
                    Dim dateValue As DateTime = Convert.ToDateTime(row(1))
                    dgvRequisicionProductoServicioNew.Rows.Add(False, row(0), dateValue, row(2).ToString, row(3).ToString)
                Next
                'dgvRequisicionProductoServicioNew.Columns(2).DefaultCellStyle.Format = "g"

            Catch ex As Exception
                'MsgBox("METODO CARGAR REQUISICIONES PRODUCTO / SERVICIO" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Error al cargar las requisiciones" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub dgvRequisicionProductoServicio_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRequisicionProductoServicio.SelectionChanged
            If dgvRequisicionProductoServicio.RowCount = 0 Then
                Label1.Text = "0"
                Return
            End If
            Label1.Text = dgvRequisicionProductoServicio.CurrentRow.Cells(1).Value
            CargarDetalleRequisicionProductoServicio()
        End Sub
        Public Sub CargarDetalleRequisicionProductoServicio()
            Try
                dgvDetalleRequisicionProductoServicio.DataSource = _objetoDetalleRequisicion.SeleccionarDetalleRequisicionProductoServicioXIdRequisicion(_tipoCon, CType(Label1.Text, Int32))
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
                KryptonMessageBox.Show("Error al cargar el detalle de la requisición" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            HabilitadoNuevo()
            LimpiarParametros()

            cmbFormaPagoOrdenCompra.SelectedIndex = 0
            cmbTipoPagoOrdenCompra.SelectedIndex = 0
            txtFechaOrdenCompra.Text = ValidationForms.FechaActual(_tipoCon)
            txtNombreComercialProveedorGeneral.Focus()
            CargarRequisicionProductoServicio()
        End Sub
        Private Sub txtNombreComercialProveedorGeneral_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtNombreComercialProveedorGeneral.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            CargarDatosProveedor()
        End Sub
        Public Sub CargarDatosProveedor()
            Try
                Dim pro = _objetoProveedorGeneral.BuscarProveedorGeneralXNombre(_tipoCon, txtNombreComercialProveedorGeneral.Text)
                If pro.Rows.Count > 0 Then
                    lblIdProveedorGeneral.Text = pro.Rows(0)(0)
                    txtRucCiProveedorGeneral.Text = pro.Rows(0)(2)
                    lblValorLlevacontabilidad.Text = pro.Rows(0)(6)
                    lblValorContribuyenteEspecial.Text = pro.Rows(0)(7)
                    txtLlevaContabilidadProveedorGeneral.Text = pro.Rows(0)(6)
                    txtContribuyenteEspecialProveedorGeneral.Text = pro.Rows(0)(7)
                    txtDireccionProveedorGeneral.Text = pro.Rows(0)(8)
                    lblIdCiudad.Text = pro.Rows(0)(9)
                    txtTelefono1ProveedorGeneral.Text = pro.Rows(0)(10)
                    txtEmailProveedorGeneral.Text = pro.Rows(0)(12)
                    txtNombreCiudad.Text = _objetoCiudad.BuscarNombreCiudadXIdCiudad(_tipoCon, CInt(lblIdCiudad.Text))
                End If
            Catch ex As Exception
                'MsgBox("CARGAR DATOS PROVEEDOR." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Error al cargar los datos del proveedor" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub dgvDetalleRequisicionProductoServicio_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDetalleRequisicionProductoServicio.DoubleClick
            If dgvDetalleRequisicionProductoServicio.RowCount = 0 Then Return
            For indice = 0 To dgvDetalleOrdenCompra.RowCount - 1
                If (dgvDetalleOrdenCompra.Rows(indice).Cells(0).Value & "").ToString.Trim.Length = 0 Then Continue For
                If dgvDetalleOrdenCompra.Rows(indice).Cells(0).Value = dgvDetalleRequisicionProductoServicio.CurrentRow.Cells(8).Value Then
                    'MsgBox("ESTE ITEM YA ESTÁ AGREGADO A LA ORDEN!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("Este item ya está agregado a la orden!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If
            Next
            dgvDetalleOrdenCompra.Rows.Add(dgvDetalleRequisicionProductoServicio.CurrentRow.Cells(8).Value.ToString,
                                           dgvDetalleRequisicionProductoServicio.CurrentRow.Cells(1).Value.ToString,
                                           dgvDetalleRequisicionProductoServicio.CurrentRow.Cells(2).Value.ToString,
                                           dgvDetalleRequisicionProductoServicio.CurrentRow.Cells(3).Value.ToString, String.Empty, 0)
        End Sub
        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click
            If dgvDetalleOrdenCompra.RowCount < 2 Then Return
            If dgvDetalleOrdenCompra.CurrentRow.Index = dgvDetalleOrdenCompra.RowCount - 1 Then Return
            dgvDetalleOrdenCompra.Rows.RemoveAt(dgvDetalleOrdenCompra.CurrentRow.Index)
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If ValidarParametros() Then

                RequisionesSeleccionadas()
                If chkReq.Checked And Label3.Text.Equals("###") Then

                    KryptonMessageBox.Show("Seleccione las requisiciones que serán procesadas!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                If CDec(txtTotalOrdenCompra.Text) < 0.01 Then

                    KryptonMessageBox.Show("Verifique los valores y el total de la orden de compra!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If

                If KryptonMessageBox.Show("¿Esta segura que desea guardar el comprobante?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return

                _sqlCommands.Clear()
                Try
                    ' GUARDA LA ORDEN DE COMPRA CON SU RESPECTIVO DETALLE
                    GuardarRegistroOrdenCompra()
                    GuardarRegistroDetalleOrdenCompra()

                    If chkReq.Checked AndAlso Label3.Text <> "###" Then
                        ' CAMBIA EL ESTADO DEL DETALLE REQUISICIÓN A APROVADO

                        Dim ids = Label3.Text.Split("-")
                            For Each id In ids
                                AprovarRequisicionProductoServicio(id)
                            Next

                    Else
                        AprovarRequisicionProductoServicio(Label1.Text)
                    End If

                Catch ex As Exception
                    KryptonMessageBox.Show("Error al guardar la orden de compra" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End Try

                Dim nombreU As String = "Orden de Compra por " & UserName
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
                If res(0) Then
                    ' DEJA EL FORMULARIO EN SU ESTADO INICIAL
                    DeshabilitadoInicio()
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)

                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)

                    Return
                End If


            Else
                KryptonMessageBox.Show("NO HA LLENADO TODOS LOS PARAMETROS NECESARIOS", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Sub RequisionesSeleccionadas()
            'dgvRequisicionProductoServicio.EndEdit()
            dgvRequisicionProductoServicioNew.EndEdit()
            Dim req = String.Empty
            'For Each row As DataGridViewRow In dgvRequisicionProductoServicio.Rows
            '    If CType(row.Cells(0).Value, Boolean) Then req = req & row.Cells(1).Value & " - "
            'Next
            For Each row As DataGridViewRow In dgvRequisicionProductoServicioNew.Rows
                If CType(row.Cells(0).Value, Boolean) Then req = req & row.Cells(1).Value & " - "
            Next
            req = req.Trim()

            If String.IsNullOrEmpty(req) Then req = "###"
            If req.EndsWith("-") Then req = req.Substring(0, req.Length - 2)
            Label3.Text = req
        End Sub
        Private Sub dgvDetalleOrdenCompra_CellValueChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleOrdenCompra.CellValueChanged
            Try
                Dim cant, valor, desc As Decimal
                Dim columna = dgvDetalleOrdenCompra.Columns(e.ColumnIndex).Name

                If dgvDetalleOrdenCompra.Columns(e.ColumnIndex).Name = "valorUnitarioProductoServicio" Or dgvDetalleOrdenCompra.Columns(e.ColumnIndex).Name = "cantidadProductoServicio" Or dgvDetalleOrdenCompra.Columns(e.ColumnIndex).Name = "porcentaje" Or dgvDetalleOrdenCompra.Columns(e.ColumnIndex).Name = "DESC" Then
                    If dgvDetalleOrdenCompra.CurrentRow.Cells(3).Value.ToString <> "" And dgvDetalleOrdenCompra.CurrentRow.Cells(4).Value.ToString <> "" Then



                        cant = CDec(dgvDetalleOrdenCompra.CurrentRow.Cells(3).Value)
                        valor = CDec(dgvDetalleOrdenCompra.CurrentRow.Cells(4).Value)
                        desc = CDec(dgvDetalleOrdenCompra.CurrentRow.Cells(5).Value)
                        dgvDetalleOrdenCompra.CurrentRow.Cells(6).Value = Math.Round((cant * valor) - desc, 2)
                    End If

                    If dgvDetalleOrdenCompra.Columns(e.ColumnIndex).Name = "porcentaje" Then
                        Dim porcentaje As Integer = Convert.ToInt32(dgvDetalleOrdenCompra.CurrentRow.Cells("porcentaje").Value)

                        Select Case porcentaje
                            Case 0
                                dgvDetalleOrdenCompra.CurrentRow.Cells("IVA").Value = "N"
                            Case 12, 15
                                dgvDetalleOrdenCompra.CurrentRow.Cells("IVA").Value = "S"


                        End Select



                    End If
                End If
            Catch ex As Exception
                KryptonMessageBox.Show("ERROR AL CALCULAR EL TOTAL DEL ITEM" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                dgvDetalleOrdenCompra.CurrentRow.Cells(6).Value = 0
            End Try
        End Sub
        Private Sub dgvDetalleOrdenCompra_CellEndEdit(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleOrdenCompra.CellEndEdit
            dgvDetalleOrdenCompra.Rows(e.RowIndex).ErrorText = [String].Empty

            BuscarIdItemDetalleOrdenCompra()
        End Sub
        Public Sub BuscarIdItemDetalleOrdenCompra()
            Try
                If dgvDetalleOrdenCompra.CurrentRow.Cells(1).Value <> "" And dgvDetalleOrdenCompra.CurrentCell.ColumnIndex = 1 Then
                    For indice = 0 To dgvDetalleOrdenCompra.RowCount - 2
                        If indice <> dgvDetalleOrdenCompra.CurrentRow.Index Then
                            If dgvDetalleOrdenCompra.Rows(indice).Cells(1).Value.ToString <> dgvDetalleOrdenCompra.CurrentRow.Cells(1).Value.ToString Then
                                Dim tab = _objetoSecuencialItem.SeleccionarSecuencialItemsXNombre(_tipoCon, dgvDetalleOrdenCompra.CurrentRow.Cells(1).Value.ToString)
                                If tab.Rows.Count = 0 Then
                                    dgvDetalleOrdenCompra.CurrentRow.Cells(0).Value = ""
                                    dgvDetalleOrdenCompra.CurrentRow.Cells(1).Value = ""
                                    dgvDetalleOrdenCompra.CurrentRow.Cells(2).Value = ""
                                    dgvDetalleOrdenCompra.CurrentRow.Cells(3).Value = ""
                                    dgvDetalleOrdenCompra.CurrentRow.Cells(4).Value = ""
                                    dgvDetalleOrdenCompra.CurrentRow.Cells(5).Value = ""
                                    dgvDetalleOrdenCompra.CurrentRow.Cells(6).Value = ""
                                    'MsgBox("EL ITEM INGRESADO NO SE ENCUENTRA EN LA BASE DE DATOS. POR FAVOR REGISTRELO ANTES DE INGRESARLO EN LA REQUISICIÓN", MsgBoxStyle.Exclamation, "Mensaje de validación")
                                    KryptonMessageBox.Show("El item ingresado no se encuentra en la base de datos. por favor registrelo antes de ingresarlo en la requisición", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                                    Return
                                End If
                                dgvDetalleOrdenCompra.CurrentRow.Cells(0).Value = tab.Rows(0)(0).ToString
                                dgvDetalleOrdenCompra.CurrentRow.Cells(1).Value = tab.Rows(0)(2).ToString
                                dgvDetalleOrdenCompra.CurrentRow.Cells(2).Value = tab.Rows(0)(18).ToString
                                dgvDetalleOrdenCompra.CurrentRow.Cells(3).Value = 1
                                dgvDetalleOrdenCompra.CurrentRow.Cells(5).Value = 0


                            Else
                                'MsgBox("EL ITEM SELECCIONADO YA ESTA AGREGADO A LA ORDEN DE COMPRA.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                                KryptonMessageBox.Show("El item seleccionado ya esta agregado a la orden de compra.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                                dgvDetalleOrdenCompra.CurrentRow.Cells(1).Value = ""
                                dgvDetalleOrdenCompra.Rows.RemoveAt(dgvDetalleOrdenCompra.CurrentRow.Index)
                                Exit For
                            End If
                        Else
                            Dim tab = _objetoSecuencialItem.SeleccionarSecuencialItemsXNombre(_tipoCon, dgvDetalleOrdenCompra.CurrentRow.Cells(1).Value.ToString)
                            If tab.Rows.Count = 0 Then
                                dgvDetalleOrdenCompra.CurrentRow.Cells(0).Value = ""
                                dgvDetalleOrdenCompra.CurrentRow.Cells(1).Value = ""
                                dgvDetalleOrdenCompra.CurrentRow.Cells(2).Value = ""
                                dgvDetalleOrdenCompra.CurrentRow.Cells(3).Value = ""
                                dgvDetalleOrdenCompra.CurrentRow.Cells(4).Value = ""
                                dgvDetalleOrdenCompra.CurrentRow.Cells(5).Value = ""
                                dgvDetalleOrdenCompra.CurrentRow.Cells(6).Value = ""
                                'MsgBox("EL ITEM INGRESADO NO SE ENCUENTRA EN LA BASE DE DATOS. POR FAVOR REGISTRELO ANTES DE INGRESARLO EN LA REQUISICIÓN", MsgBoxStyle.Exclamation, "Mensaje de validación")
                                KryptonMessageBox.Show("EL ITEM INGRESADO NO SE ENCUENTRA EN LA BASE DE DATOS. POR FAVOR REGISTRELO ANTES DE INGRESARLO EN LA REQUISICIÓN", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                                Return
                            End If
                            dgvDetalleOrdenCompra.CurrentRow.Cells(0).Value = tab.Rows(0)(0).ToString
                            dgvDetalleOrdenCompra.CurrentRow.Cells(1).Value = tab.Rows(0)(2).ToString
                            dgvDetalleOrdenCompra.CurrentRow.Cells(2).Value = tab.Rows(0)(18).ToString
                            dgvDetalleOrdenCompra.CurrentRow.Cells(3).Value = 1
                            dgvDetalleOrdenCompra.CurrentRow.Cells(5).Value = 0

                        End If
                    Next
                End If
            Catch ex As Exception
                'MsgBox("BUSCAR ID DE ITEM." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("ERROR AL BUSCAR EL ITEM" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
            End Try
        End Sub
        Private Sub dgvDetalleOrdenCompra_CellValidated(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleOrdenCompra.CellValidated
            CalcularTotalesOrdenCompra()
        End Sub
        Private Sub dgvDetalleOrdenCompra_CellValidating(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvDetalleOrdenCompra.CellValidating
            If dgvDetalleOrdenCompra.Columns(e.ColumnIndex).Name = "valorUnitarioProductoServicio" Then
                If String.IsNullOrEmpty(e.FormattedValue.ToString()) Then Return
            End If
        End Sub
        Private Sub dgvDetalleOrdenCompra_EditingControlShowing(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvDetalleOrdenCompra.EditingControlShowing
            Dim itemName = TryCast(e.Control, TextBox)
            'Dim comboBox = TryCast(e.Control, ComboBox)

            'If comboBox IsNot Nothing Then
            '    comboBox.DropDownStyle = ComboBoxStyle.DropDownList
            'ElseIf itemName IsNot Nothing Then
            If itemName Is Nothing Then Return
            itemName.CharacterCasing = CharacterCasing.Upper
                    If dgvDetalleOrdenCompra.CurrentCell.ColumnIndex = 1 Then
                        itemName.AutoCompleteCustomSource = _objetoSecuencialItem.Autocompletar(_tipoCon)
                        itemName.AutoCompleteMode = AutoCompleteMode.Suggest
                        itemName.AutoCompleteSource = AutoCompleteSource.CustomSource
                    Else
                        itemName.AutoCompleteMode = AutoCompleteMode.None
                    End If

            AddHandler itemName.KeyPress, AddressOf ItemType_KeyPress
        End Sub
        Private Sub ItemType_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles dgvDetalleOrdenCompra.KeyPress
            Select Case dgvDetalleOrdenCompra.CurrentCell.ColumnIndex
                Case 1
                    e.Handled = Not _validacionesAlfabetica.EsLetra(e.KeyChar)
                Case 3
                    e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
                Case 4
                    e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
                Case 5
                    e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar)
            End Select
        End Sub
        Public Function ValidarParametros() As Boolean
            Return txtNombreComercialProveedorGeneral.Text <> "" And dgvDetalleOrdenCompra.RowCount > 0 And cmbFormaPagoOrdenCompra.SelectedIndex >= 0 And cmbTipoPagoOrdenCompra.SelectedIndex >= 0
        End Function
        Public Sub CalcularTotalesOrdenCompra()
            Try
                Dim epr = New ClassEmpresa
                Dim empre = epr.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon)
                Dim piva = If(empre.Rows.Count = 0, 0, CInt(empre.Rows(0)(21).ToString()))
                Dim subtotal0, subTotal12, iva, desc, total As Decimal
                For indice = 0 To dgvDetalleOrdenCompra.RowCount - 2
                    Dim row = dgvDetalleOrdenCompra.Rows(indice)

                    If dgvDetalleOrdenCompra.Rows(indice).Cells(3).Value <> Nothing And dgvDetalleOrdenCompra.Rows(indice).Cells(4).Value <> Nothing And dgvDetalleOrdenCompra.Rows(indice).Cells(8).Value = "S" Then
                        'cambio 2023

                        subTotal12 += CDec(row.Cells(6).Value)
                        desc += CDec(row.Cells(5).Value)
                    Else
                        subtotal0 += CDec(row.Cells(6).Value)
                        desc += CDec(row.Cells(5).Value)
                    End If
                Next

                iva = Math.Round(subTotal12 * (piva / 100), 2)
                total = Math.Round(subTotal12 + iva + subtotal0 + desc, 2)

                txtSubtotal0OrdenCompra.Text = subtotal0
                txtSubtotal12OrdenCompra.Text = subTotal12
                txtDescuentoOrdenCompra.Text = desc
                txtIvaOrdenCompra.Text = iva
                txtTotalOrdenCompra.Text = total
                lblSubtotalIva.Text = "Subtotal " & piva & "%"

                'iva = subTotal12 * (piva / 100)
                'total = subtotal0 + subTotal12 + iva

            Catch ex As Exception
                '                MsgBox("CALCULAR TOTALES ORDEN DE COMPRA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "Mensaje de excepción")
                KryptonMessageBox.Show("Error al calcular los totales de la orden de compra" & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            LimpiarParametros()
            DeshabilitadoInicio()
        End Sub     
        Private Sub lblValorLlevacontabilidad_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblValorLlevacontabilidad.TextChanged
            If lblValorLlevacontabilidad.Text = "0" Then
                txtLlevaContabilidadProveedorGeneral.Text = "NO"
            ElseIf lblValorLlevacontabilidad.Text = "1" Then
                txtLlevaContabilidadProveedorGeneral.Text = "SI"
            End If
        End Sub
        Private Sub lblValorContribuyenteEspecial_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblValorContribuyenteEspecial.TextChanged
            If lblValorContribuyenteEspecial.Text = "0" Then
                txtContribuyenteEspecialProveedorGeneral.Text = "NO"
            ElseIf lblValorContribuyenteEspecial.Text = "1" Then
                txtContribuyenteEspecialProveedorGeneral.Text = "SI"
            End If
        End Sub
        Private Sub txtTotalOrdenCompra_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtTotalOrdenCompra.TextChanged
            txtSon.Text = _validacionesConversion.Letras(txtTotalOrdenCompra.Text) + " dólares"
        End Sub
        Public Sub GuardarRegistroOrdenCompra()
            txtIdOrdenCompra.Text = _objetoOrdenCompra.BuscarMayorIdOrdenCompra(_tipoCon) + 1
            With _objetoOrdenCompra
                .IdOrdenCompra = CInt(txtIdOrdenCompra.Text)
                .FechaOrdenCompra = txtFechaOrdenCompra.Text
                .IdProveedor = lblIdProveedorGeneral.Text
                .FormaPagoOrdenCompra = cmbFormaPagoOrdenCompra.Text
                .TipoPagoOrdenCompra = cmbTipoPagoOrdenCompra.Text
                If txtObservacionesOrdenCompra.Text = "" Then
                    .ObservacionesOrdenCompra = "S/O"
                Else
                    .ObservacionesOrdenCompra = txtObservacionesOrdenCompra.Text
                End If
                If txtSubtotal12OrdenCompra.Text = "" Then
                    .SubTotal12OrdenCompra = 0
                Else
                    .SubTotal12OrdenCompra = txtSubtotal12OrdenCompra.Text
                End If
                If txtSubtotal0OrdenCompra.Text = "" Then
                    .SubTotal0OrdenCompra = 0
                Else
                    .SubTotal0OrdenCompra = txtSubtotal0OrdenCompra.Text
                End If
                If txtDescuentoOrdenCompra.Text = "" Then
                    .DescuentoOrdenCompra = 0
                Else
                    .DescuentoOrdenCompra = txtDescuentoOrdenCompra.Text
                End If
                If txtIvaOrdenCompra.Text = "" Then
                    .IvaOrdenCompra = 0
                Else
                    .IvaOrdenCompra = txtIvaOrdenCompra.Text
                End If
                If txtTotalOrdenCompra.Text = "" Then
                    .TotalOrdenCompra = 0
                Else
                    .TotalOrdenCompra = txtTotalOrdenCompra.Text
                End If
                .EstadoOrdenCompra = 1
                .IdRequisicion = Label3.Text
            End With
            _sqlCommands.Add(_objetoOrdenCompra.NuevoRegistroOrdenCompra)

            _objAuditoria.AccionAuditoria = "SE CREO UNA NUEVA ORDEN DE COMPRA. Nº: OC-" + CType(txtIdOrdenCompra.Text, String) _
                                           + " FECHA: " + txtFechaOrdenCompra.Text + " PROVEEDOR RUC:" + txtRucCiProveedorGeneral.Text + " NOMBRE COMERCIAL: " + txtNombreComercialProveedorGeneral.Text
            _objAuditoria.FormularioAuditoria = Text.ToUpper
            auditoria()
        End Sub
        Public Sub Auditoria()
            With _objAuditoria
                .IdAuditoria = Convert.ToInt64(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                .IdUsuarioAuditoria = IdUsuario
                .EstadoAuditoria = 1
                .FechaAuditoria = .FechaExactaAuditoria(_tipoCon)
            End With
            _sqlCommands.Add(_objAuditoria.NuevaAuditoria)
        End Sub
        Public Sub GuardarRegistroDetalleOrdenCompra()
            Dim id = _objetoDetalleOrdenCompra.BuscarMayorIdDetalleROrdenCompra(_tipoCon) + 1
            For indice = 0 To dgvDetalleOrdenCompra.RowCount - 2
                With _objetoDetalleOrdenCompra
                    .IdDetalleOrdenCompra = id
                    .IdSecuencialItem = dgvDetalleOrdenCompra.Rows(indice).Cells(0).Value
                    .UmedidaDetalleOrdenCompra = dgvDetalleOrdenCompra.Rows(indice).Cells(2).Value
                    .CantidadDetalleOrdenCompra = dgvDetalleOrdenCompra.Rows(indice).Cells(3).Value
                    .ValorUDetalleOrdenCompra = dgvDetalleOrdenCompra.Rows(indice).Cells(4).Value.ToString.ToUpper
                    .ValorTDetalleOrdenCompra = dgvDetalleOrdenCompra.Rows(indice).Cells(5).Value.ToString.ToUpper
                    .EstadoDetalleOrdenCompra = 1
                    .IdOrdenCompra = txtIdOrdenCompra.Text
                End With
                _sqlCommands.Add(_objetoDetalleOrdenCompra.NuevoRegistroDetalleOrdenCompra)
                id += 1
            Next
        End Sub
        Public Sub AprovarRequisicionProductoServicio(ByVal idre As String)
            With _objetoRequisicionProductoServicio
                .IdRequisicionPs = idre
                .EstadoRequisicionPs = 3
            End With
            _sqlCommands.Add(_objetoRequisicionProductoServicio.ActualizarEstadoRequisicionProductoServicio)
        End Sub

        Private Sub chkReq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReq.CheckedChanged
            Label3.Text = "###"
            'For Each row As DataGridViewRow In dgvRequisicionProductoServicio.Rows
            '    row.Cells(0).Value = False
            'Next

            For Each row As DataGridViewRow In dgvRequisicionProductoServicioNew.Rows
                row.Cells(0).Value = False
            Next

        End Sub

        Private Sub dgvRequisicionProductoServicioNew_SelectionChanged(sender As Object, e As EventArgs) Handles dgvRequisicionProductoServicioNew.SelectionChanged
            If dgvRequisicionProductoServicioNew.RowCount = 0 Then
                Label1.Text = "0"
                Return
            End If
            Label1.Text = dgvRequisicionProductoServicioNew.CurrentRow.Cells(1).Value


            CargarDetalleRequisicionProductoServicio()
        End Sub

        Private Sub dgvRequisicionProductoServicioNew_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequisicionProductoServicioNew.CellContentClick
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 AndAlso chkReq.Checked Then
                ' Confirma el cambio de estado de la celda activa
                dgvRequisicionProductoServicioNew.CommitEdit(DataGridViewDataErrorContexts.Commit)

                ' Recupera el estado actual del CheckBox
                Dim isChecked As Boolean = Convert.ToBoolean(dgvRequisicionProductoServicioNew.Rows(e.RowIndex).Cells(0).Value)

                ' Obtén el valor de la celda en la columna 1
                Dim value As String = dgvRequisicionProductoServicioNew.Rows(e.RowIndex).Cells(1).Value.ToString()

                ' Actualiza el contenido del Label3
                If isChecked Then
                    ' Agregar el valor al Label si está marcado
                    If Not Label3.Text.Contains(value) Then
                        If Label3.Text = "###" Then
                            Label3.Text = value
                        Else
                            Label3.Text &= "-" & value
                        End If
                    End If
                Else
                    ' Remover el valor del Label si se desmarca
                    Dim values = Label3.Text.Split("-"c).ToList()
                    values.Remove(value)
                    Label3.Text = If(values.Count > 0, String.Join("-", values), "###")
                End If
            End If
        End Sub


    End Class
End Namespace