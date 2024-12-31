
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.INVENTARIOS.ITEMS
Imports ClassLibraryCisepro.ProcesosSql

Namespace FORMULARIOS.INVENTARIOS.PROCESO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormAsignarProveedorAItem
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

        ReadOnly _objSecuencialItem As New ClassSecuencialItem
        ReadOnly _objProveedor As New ClassProveedores
        ReadOnly _objDetalleProveedorItem As New ClassDetalleProveedorItem
 
        Dim _validarProveedor As Integer = 0
        Dim _validarRepetidos As Integer = 0
        ReadOnly titulo As String = "Mensaje de información"
 
        Public Sub CargarItem()
            Try
                dgvItems.DataSource = _objSecuencialItem.SeleccionarSecuencialItemsActivas(_tipoCon, "")
            Catch ex As Exception
                dgvItems.DataSource = Nothing
                Exit Try
            End Try
        End Sub
        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Private Sub Tip(ByVal control As Object _
                       , ByVal mensaje As String _
                       , ByVal tituloTip As String, _
                       ByVal icono As Integer)
            '--------------------------------------------------------------
            'icono 0=ERROR,1=INFORMACIÓN,2=NINGUNO,3=PELIGRO
            'tituloTip=EL TÍTULO DEL TIP EMERGENTE
            'control=OBJETO QUE SE NECESITA MOSTRAR EL TIP DE AYUDA
            'mensaje=MENSAJE QUE SE DESEA MOSTRAR
            '--------------------------------------------------------------
            ttPublico.SetToolTip(control, vbCr & mensaje)
            ttPublico.ToolTipIcon = icono
            ttPublico.ToolTipTitle = tituloTip
            ttPublico.IsBalloon = True
        End Sub
        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Public Sub AutocompletarDetalleItem()
            Try
                txtBuscarDetalleItems.AutoCompleteCustomSource = _objSecuencialItem.Autocompletar(_tipoCon)
                txtBuscarDetalleItems.AutoCompleteMode = AutoCompleteMode.Suggest
                txtBuscarDetalleItems.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
                txtBuscarDetalleItems.Text = ""
                Exit Try
            End Try
        End Sub
        Public Sub AutocompletarNombreProveedor()
            Try
                txtBuscarNombreProveedor.AutoCompleteCustomSource = _objProveedor.Autocompletar(_tipoCon)
                txtBuscarNombreProveedor.AutoCompleteMode = AutoCompleteMode.Suggest
                txtBuscarNombreProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource

            Catch ex As Exception
                txtBuscarNombreProveedor.Text = ""
                Exit Try
            End Try
        End Sub
        Public Sub CargarProveedoresItems(ByVal idSecuencial As Int64)
            Try
                dgvProveedoresAgregados.DataSource = _objDetalleProveedorItem.SeleccionarTodosLosRegistrosDetallesProveedorItem(_tipoCon, idSecuencial)
                dgvProveedoresAgregados.AutoResizeRows()
                dgvProveedoresAgregados.AutoResizeColumns()

                dgvProveedoresAgregados.Columns(3).Width = 500
                dgvProveedoresAgregados.Columns(6).Width = 500
            Catch ex As Exception
                Exit Try
            End Try
        End Sub
        Public Sub CargarSecuencialesItems()
            Try
                dgvItems.DataSource = _objDetalleProveedorItem.SeleccionarTodosLosRegistrosSecuencialItem(_tipoCon)
                dgvItems.AutoResizeRows()
                dgvItems.AutoResizeColumns()

                dgvItems.Columns(0).Width = 40
                dgvItems.Columns(1).Width = 60
                dgvItems.Columns(2).Width = 280
                dgvItems.Columns(3).Width = 280
                dgvItems.Columns(4).Width = 80
                dgvItems.Columns(5).Width = 80
                dgvItems.Columns(6).Width = 80
                dgvItems.Columns(7).Width = 80

            Catch ex As Exception
                Exit Try
            End Try
        End Sub
        Private Sub FormAsignarProveedorAItem_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvItems.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvProveedor.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvProveedores.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvProveedoresAgregados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvItems.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvProveedor.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvProveedores.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvProveedoresAgregados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvItems.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvProveedor.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvProveedores.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvProveedoresAgregados.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvItems.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvProveedor.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvProveedores.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvProveedoresAgregados.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            AutocompletarDetalleItem()
            autocompletarNombreProveedor() 
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarProveedor.Click
            If dgvProveedor.RowCount = 0 Then
                MsgBox("Debe agregar al menos un item / proveedor en la lista!", MsgBoxStyle.Exclamation, "Mensaje de validación")
                Return
            End If

            btnGuardar.Enabled = True
            btnEliminarProveedor.Enabled = True
            Dim fila As String() = {txtBuscarNombreProveedor.Tag _
                                    , txtRuc.Text _
                                    , txtBuscarNombreProveedor.Text _
                                    , txtBuscarDetalleItems.Tag _
                                    , txtCódigoItem.Text _
                                    , txtBuscarDetalleItems.Text}
            For indice = 0 To dgvProveedor.Rows.Count - 1
                If txtBuscarNombreProveedor.Tag = dgvProveedor.Rows(indice).Cells(0).Value Then
                    _validarProveedor += 1
                End If
            Next
            For indice = 0 To dgvProveedoresAgregados.Rows.Count - 1
                If txtBuscarNombreProveedor.Tag = dgvProveedoresAgregados.Rows(indice).Cells(4).Value Then
                    _validarRepetidos += 1
                End If
            Next
            If _validarProveedor = 0 And _validarRepetidos = 0 And txtBuscarNombreProveedor.Text <> "" Then
                dgvProveedor.Rows.Add(fila)
                dgvProveedor.Columns(2).Width = 500
                dgvProveedor.Columns(5).Width = 500
            Else
                MsgBox("El proveedor ya esta Agregado", MsgBoxStyle.Exclamation, "Mensaje de validación")
                _validarRepetidos = 0
            End If
            dgvProveedor.AutoResizeRows()
            dgvProveedor.AutoResizeColumns()
            txtBuscarNombreProveedor.Enabled = True
            txtBuscarNombreProveedor.Text = ""
            txtBuscarNombreProveedor.Focus()
            txtRuc.Text = ""
            txtBuscarNombreProveedor.Tag = Nothing
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminarProveedor.Click
            Try
                If dgvProveedor.Rows.Count > 0 Then
                    dgvProveedor.Rows.RemoveAt(dgvProveedor.CurrentCell.RowIndex())
                Else
                    btnGuardar.Enabled = False
                    btnEliminarProveedor.Enabled = False
                    btnAgregarProveedor.Enabled = True
                End If
            Catch ex As Exception
                MsgBox("No se puede eliminar fila inexistente", MsgBoxStyle.Critical, "Mensaje de validación")
            End Try
        End Sub

        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            Try
                If dgvProveedor.Rows.Count > 0 Then
                    If MessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                    _sqlCommands.Clear()

                    For indice = 0 To dgvProveedor.Rows.Count - 1
                        With _objDetalleProveedorItem
                            .IdProveedor = CType(dgvProveedor.Rows(indice).Cells(0).Value, Integer)
                            .IdSecuencial = CType(dgvProveedor.Rows(indice).Cells(3).Value, Int64)
                            .Estado = 1
                            .Fecha = Date.Now                            
                        End With
                        _sqlCommands.Add(_objDetalleProveedorItem.NuevaDetalleProvedorItem)
                    Next
                    Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                    If res(0) Then
                        dgvProveedor.Rows.Clear()
                        _validarProveedor = 0
                        _validarRepetidos = 0
                        CargarProveedoresItems(CLng(txtBuscarDetalleItems.Tag))
                        txtBuscarNombreProveedor.Text = "INGRESE EL NOMBRE DEL PROVEEDOR"
                        txtBuscarDetalleItems.Text = "INGRESE EL NOMBRE DEL ITEM DE PRODUCTO"
                        txtBuscarNombreProveedor.Tag = Nothing
                        txtBuscarDetalleItems.Tag = Nothing
                        btnGuardar.Enabled = False
                        btnAgregarProveedor.Enabled = True
                        btnEliminarProveedor.Enabled = False
                    End If
                    MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
                     
                Else
                    MsgBox("No se puede guardar debido a que no existe ningún proveedor agregado", MsgBoxStyle.Critical, "Mensaje de validación")
                End If
            Catch ex As Exception
                Exit Try
            End Try
            
        End Sub

        Private Sub txtBuscarDetalleItems_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtBuscarDetalleItems.KeyUp
            If e.KeyCode = Keys.Enter Then
                 
                Dim id = _objSecuencialItem.BuscarIdSecuencialItemXNombreSecuencialItem(_tipoCon, txtBuscarDetalleItems.Text.Trim.ToUpper)

                If id = 0 Then
                    txtBuscarDetalleItems.Text = ""
                    txtBuscarDetalleItems.Enabled = True
                    txtBuscarDetalleItems.Focus()
                    MsgBox("SELECCIONE UN ITEM VÁLIDO", MsgBoxStyle.Exclamation, "Mensaje de validación")
                Else
                    txtCódigoItem.Text = _objSecuencialItem.BuscarCodigoSecuencialItemxNombreSecuencial(_tipoCon, txtBuscarDetalleItems.Text.Trim.ToUpper)
                    txtBuscarDetalleItems.Tag = _objSecuencialItem.BuscarIdSecuencialItemXNombreSecuencialItem(_tipoCon, txtBuscarDetalleItems.Text.Trim.ToUpper)

                    CargarProveedoresItems(id)
                    txtBuscarNombreProveedor.Focus()
                End If
            End If
        End Sub

        Private Sub txtBuscarNombreProveedor_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtBuscarNombreProveedor.KeyUp
            If e.KeyCode = Keys.Enter Then
                 
                Dim r = _objProveedor.BuscarIdProveedorXRazonSocialProveedor(_tipoCon, txtBuscarNombreProveedor.Text.Trim.ToUpper)

                If r = 0 Then
                    txtBuscarNombreProveedor.Text = ""
                    txtBuscarNombreProveedor.Enabled = True
                    txtBuscarNombreProveedor.Focus()
                    MsgBox("SELECCIONE UN PROVEEDOR VÁLIDO", MsgBoxStyle.Exclamation, "Mensaje de validación")
                Else
                    txtRuc.Text = _objProveedor.BuscarRucProveedorXIdProveedor(_tipoCon, r)
                    txtBuscarNombreProveedor.Tag = r
                    btnAgregarProveedor.Enabled = True
                End If
            End If
        End Sub

        Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            cargarSecuencialesItems()
        End Sub

        Private Sub dgvItems_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) 
            If dgvItems.Rows.Count = 0 Or dgvItems.CurrentRow Is Nothing Then Return
            CargarProveedoresItems(dgvItems.CurrentRow.Cells(0).Value)
        End Sub
    End Class
End Namespace
