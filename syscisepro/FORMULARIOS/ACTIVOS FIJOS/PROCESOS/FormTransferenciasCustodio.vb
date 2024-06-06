Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO 
Imports syscisepro.FORMULARIOS.ACTIVOS_FIJOS.REPORTES

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormTransferenciasActivosFijos
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

        ReadOnly _objetoPersonal As New ClassPersonal
        ReadOnly _objetoActivoFijo As New ClassActivoFijo
        ReadOnly _objetoDetalleTransferencias As New ClassDetalleTransferencias
        ReadOnly _objetoActovoFijoTransferencias As New ClassActivoFijoTransferencias
        ReadOnly _objetoEmpresa As New ClassEmpresa
        ReadOnly _objetoSucursal As New ClassSucursal
        ReadOnly _objetoGerencias As New ClassGerenciasGeneral
        ReadOnly _objetoArea As New ClassArea
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral

        Private Sub Auditoria()
            _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
            _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
            _objAuditoria.FormularioAuditoria = Text.Trim
            _objAuditoria.EstadoAuditoria = 1
            _objAuditoria.IdUsuarioAuditoria = IdUsuario
            _objAuditoria.AccionAuditoria = "REGISTRO UN TRANSFERENCIA CON N° DE REGISTRO:" + txtIdTransferencia.Text
            _sqlCommands.Add(_objAuditoria.NuevaAuditoria) 
        End Sub
        Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtBusqueda.TextChanged
            If rbApellido.Checked Then
                dgvBusquedaPersonal.DataSource = _objetoPersonal.BuscarPorApellidosElPersonal(_tipoCon, txtBusqueda.Text, True)
            Else
                If rbNombre.Checked Then
                    dgvBusquedaPersonal.DataSource = _objetoPersonal.BuscarDatosPersonal(_tipoCon, txtBusqueda.Text)
                Else
                    If rbCédula.Checked Then
                        dgvBusquedaPersonal.DataSource = _objetoPersonal.BuscarPorCedulaElPersonal(_tipoCon, txtBusqueda.Text)
                    Else
                        MsgBox("Seleccione un parámetro de busqueda", MsgBoxStyle.Critical, "Mensaje de Validación")
                    End If
                End If
            End If
        End Sub

        Private Sub FormTransferenciasActivosFijos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvActivoFijo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvTransferencias.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvBusquedaPersonal.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvActivoFijo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvTransferencias.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvBusquedaPersonal.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvActivoFijo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvTransferencias.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvBusquedaPersonal.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvActivoFijo.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvTransferencias.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvBusquedaPersonal.Font = New Font("Roboto", 8, FontStyle.Regular)

            _sqlCommands = New List(Of SqlCommand)
            txtFechaTransferencia.Text = Date.Now
            cargarPersonal()
            cargarActivoFijo()
            llenarComboEmpresa()
            llenarComboSucursal()
            llenarComboGerencias()
            llenarComboArea() 
        End Sub

        Private Sub CargarActivoFijo()
            Try
                dgvActivoFijo.DataSource = _objetoActivoFijo.SeleccionarTodosRegistrosActivosFijos(_tipoCon)
                dgvActivoFijo.Columns("ID_EMPRESA").Visible = False
                dgvActivoFijo.Columns("ID_SUCURSAL").Visible = False
                dgvActivoFijo.Columns("ID_AREA").Visible = False
                dgvActivoFijo.Columns("ID_GERENCIAS").Visible = False
                dgvActivoFijo.Columns("CARPETA").Visible = False
                dgvActivoFijo.Columns("CONTRATO").Visible = False
                dgvActivoFijo.Columns("NOMBRE_PROVEDOR").Visible = False
                dgvActivoFijo.Columns("CODIGO_ARANCEL").Visible = False
                dgvActivoFijo.Columns("NUM_ORDEN_COMPRA").Visible = False
                dgvActivoFijo.Columns("NUM_FACTURA").Visible = False
                dgvActivoFijo.Columns("VALOR_FACTURA").Visible = False
                dgvActivoFijo.Columns("VALOR_ADICIONAL").Visible = False
                dgvActivoFijo.Columns("VALOR_RESIDUAL").Visible = False
                dgvActivoFijo.Columns("FECHA_ADQUISICION").Visible = False
                dgvActivoFijo.Columns("AÑOS_VIDA_UTIL").Visible = False
                dgvActivoFijo.Columns("CTA_ACTIVO").Visible = False
                dgvActivoFijo.Columns("CTA_GASTOS").Visible = False
                dgvActivoFijo.Columns("CTA_DEPRECIACION").Visible = False
                dgvActivoFijo.Columns("ESTADO").Visible = False
                dgvActivoFijo.AutoResizeColumns()
                dgvActivoFijo.AutoResizeRows()
                dgvActivoFijo.Columns("CODIGO").DefaultCellStyle.BackColor = Color.LightGray
                dgvActivoFijo.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns("ID_ACTIVO_FIJO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvActivoFijo.Columns("NOMBRE_ACTIVO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgvActivoFijo.ReadOnly = False
                dgvActivoFijo.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch
                dgvActivoFijo.DataSource = Nothing
            End Try 
        End Sub

        Private Sub CargarPersonal()
            Try
                dgvBusquedaPersonal.DataSource = _objetoPersonal.SeleccionarTodosRegistrosPersonal(_tipoCon)
                dgvBusquedaPersonal.Columns("PROVINCIA").Visible = False
                dgvBusquedaPersonal.Columns("DIRECCION").Visible = False
                dgvBusquedaPersonal.Columns("FECHA_NACIMIENTO").Visible = False
                dgvBusquedaPersonal.Columns("SEXO").Visible = False
                dgvBusquedaPersonal.Columns("CIUDAD").Visible = False
                dgvBusquedaPersonal.Columns("SUELDO").Visible = False
                dgvBusquedaPersonal.Columns("LIBRETA_MILITAR").Visible = False
                dgvBusquedaPersonal.Columns("TIPO_SANGRE").Visible = False
                dgvBusquedaPersonal.Columns("PASAPORTE").Visible = False
                dgvBusquedaPersonal.Columns("PESO").Visible = False
                dgvBusquedaPersonal.Columns("EDAD").Visible = False
                dgvBusquedaPersonal.Columns("PROVINCIA").Visible = False
                dgvBusquedaPersonal.Columns("PRUEBA_ANTIDROGA").Visible = False
                dgvBusquedaPersonal.Columns("FECHA_ENTRADA").Visible = False
                dgvBusquedaPersonal.Columns("FECHA_SALIDA").Visible = False
                dgvBusquedaPersonal.Columns("ESTADO_PERSONAL").Visible = False
                dgvBusquedaPersonal.Columns("INSTRUCCION").Visible = False
                dgvBusquedaPersonal.Columns("ESTADO_CIVIL").Visible = False
                dgvBusquedaPersonal.Columns("ID_AREA").Visible = False
                dgvBusquedaPersonal.Columns("ID_CARGO_OCUPACIONAL").Visible = False
                dgvBusquedaPersonal.AutoResizeColumns()
                dgvBusquedaPersonal.AutoResizeRows()
                dgvBusquedaPersonal.Columns("ID_PERSONAL").DefaultCellStyle.BackColor = Color.LightGray
                dgvBusquedaPersonal.Columns("ID_PERSONAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvBusquedaPersonal.Columns("NOMBRES").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgvBusquedaPersonal.Columns("APELLIDOS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                dgvBusquedaPersonal.ReadOnly = False
                dgvBusquedaPersonal.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch
                dgvBusquedaPersonal.DataSource = Nothing
            End Try 
        End Sub

        Private Sub txtBusquedaActivoFijo_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtBusquedaActivoFijo.TextChanged
            If rbCodigoActivo.Checked Then
                dgvActivoFijo.DataSource = _objetoActivoFijo.BuscarPorCodigoActivoFijo(_tipoCon, txtBusquedaActivoFijo.Text)
            Else
                If rbNombreCustodio.Checked Then
                    dgvActivoFijo.DataSource = _objetoActivoFijo.BuscarPorCustodioActivoFijo(_tipoCon, txtBusquedaActivoFijo.Text)
                Else
                    MsgBox("Seleccione un parámetro de busqueda", MsgBoxStyle.Critical, "Mensaje de Validación")
                End If
            End If
        End Sub

        Private Sub LlenarComboEmpresa()
            Try
                Dim data = _objetoEmpresa.SeleccionarTodosLosRegistrosEmpresa(_tipoCon)
                cbEmpresa.DataSource = data
                cbEmpresa.DisplayMember = data.Columns("NOMBRE_EMPRESA").ToString
                cbEmpresa.ValueMember = data.Columns("NOMBRE_EMPRESA").ToString
                cbEmpresa.DropDownWidth = 100
            Catch
                cbEmpresa.DataSource = Nothing
            End Try 
        End Sub

        Private Sub LlenarComboSucursal()
            Try
                Dim data = _objetoSucursal.SeleccionarTodosLosRegistrosSucursal(_tipoCon)
                cbSucursal.DataSource =
                cbSucursal.DisplayMember = data.Columns("NOMBRE_SUCURSAL").ToString
                cbSucursal.ValueMember = data.Columns("NOMBRE_SUCURSAL").ToString
                cbSucursal.DropDownWidth = 200
            Catch
                cbSucursal.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboArea()
            Try
                cbArea.DataSource = _objetoArea.SeleccionarTodosLosRegistrosArea(_tipoCon)
                cbArea.DisplayMember = "NOMBRE_AREA"
                cbArea.ValueMember = "NOMBRE_AREA"
                cbArea.DropDownWidth = 300
            Catch
                cbArea.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboGerencias()
            Try
                cbgerencias.DataSource = _objetoGerencias.SeleccionarTodosLosRegistrosGerenciasGeneral(_tipoCon)
                cbgerencias.DisplayMember = "NOMBRE_GERENCIAS"
                cbgerencias.ValueMember = "NOMBRE_GERENCIAS"
                cbgerencias.DropDownWidth = 400
            Catch
                cbgerencias.DataSource = Nothing
            End Try
        End Sub

        Private Sub btnAgregarActivoFijo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarActivoFijo.Click
            Dim buscar As Boolean
            Dim fila As String() = { _
                                       txtIdTransferencia.Text, _
                                       dgvActivoFijo.CurrentRow.Cells.Item("CODIGO").Value.ToString(), _
                                       dgvActivoFijo.CurrentRow.Cells.Item("NOMBRE_ACTIVO").Value.ToString(), _
                                       cbEstadoActual.Text.Trim.ToUpper, _
                                       _objetoEmpresa.BuscarIdEmpresaPorNombre(_tipoCon, cbEmpresa.Text.Trim).ToString, _
                                       _objetoSucursal.BuscarIdSucursalPorNombre(_tipoCon, cbSucursal.Text.Trim).ToString, _
                                       _objetoGerencias.BuscarIdGerenciasPorNombreGerencias(_tipoCon, cbgerencias.Text.Trim).ToString, _
                                       _objetoArea.BuscarIdAreaGeneralPorNombreAreaGeneral(_tipoCon, cbArea.Text.Trim).ToString, _
                                       txtIdCustodioNuevo.Text.Trim, _
                                       dgvActivoFijo.CurrentRow.Cells.Item("ID_ACTIVO_FIJO").Value.ToString()
                                   }

            If txtIdTransferencia.Text <> "" Then
                For indice = 0 To dgvTransferencias.Rows.Count - 1
                    If dgvActivoFijo.CurrentRow.Cells.Item("CODIGO").Value = dgvTransferencias.Rows(indice).Cells("CODIGO_ACTIVO").Value Then
                        buscar = True
                        MsgBox("El Activo fijo REPETIDO en transferencia", MsgBoxStyle.Critical, "Mensaje de Validación")
                        indice = dgvTransferencias.Rows.Count - 1

                    Else
                        buscar = False
                    End If
                    If Me.dgvActivoFijo.CurrentRow.Cells.Item("ID_PERSONAL").Value = txtIdCustodioAnterior.Text Then
                    Else
                        MsgBox("Activo fijo NO CORRESPONDE al anterior custodio", MsgBoxStyle.Critical, "Mensaje de Validación")
                        buscar = True
                        indice = dgvTransferencias.Rows.Count - 1
                    End If
                Next
                If buscar = False Then
                    Me.dgvTransferencias.Rows.Add(fila)
                End If
            Else
                MsgBox("No se puede crear la transferencia", MsgBoxStyle.Critical, "Mensaje de Validación")
            End If 
        End Sub

        Private Sub btnEliminarActivoFijoTransferencia_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminarActivoFijoTransferencia.Click
            Try
                If dgvTransferencias.Rows.Count > 1 Then
                    dgvTransferencias.Rows.RemoveAt(dgvTransferencias.CurrentCell.RowIndex())
                End If
            Catch ex As Exception
                MsgBox("No se puede eliminar, fila inexistente", MsgBoxStyle.Critical, "Mensaje de Validación")
            End Try
        End Sub

        Private Sub dgvActivoFijo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvActivoFijo.CellClick
            dgvActivoFijo.Rows(dgvActivoFijo.CurrentCell.RowIndex.ToString()).Selected = True
        End Sub

        Private Sub dgvBusquedaPersonal_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBusquedaPersonal.CellClick
            dgvBusquedaPersonal.Rows(dgvBusquedaPersonal.CurrentCell.RowIndex.ToString()).Selected = True

        End Sub

        Private Sub ButtonNuevoRegistro_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonNuevoRegistro.Click
           btnGuardarTransferencia.Enabled = True
            txtRazon.Enabled = True
            cbAutoriza.Enabled = True
            btnAgregarActivoFijo.Enabled = True
            btnEliminarActivoFijoTransferencia.Enabled = True
            ButtonNuevoRegistro.Enabled = False
            cbEmpresa.Enabled = True
            cbSucursal.Enabled = True
            cbgerencias.Enabled = True
            cbArea.Enabled = True
            cbEstadoActual.Enabled = True
        End Sub
        Private Function Validaciones() As Boolean
            Return txtIdCustodioAnterior.Text <> "" And txtNombreCustodioAnterior.Text <> "" And txtIdCustodioNuevo.Text <> "" And txtNombreCustodioNuevo.Text <> "" And txtIdTransferencia.Text <> "" And _
               cbAutoriza.Text <> "" And txtRazon.Text <> "" And dgvTransferencias.Rows.Count > 1 And txtFechaTransferencia.Text <> "" 
        End Function
        Private Sub ButtonGuardarTransferencia_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarTransferencia.Click
            If Validaciones() Then
                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                With _objetoActovoFijoTransferencias
                    .Id = _objetoActovoFijoTransferencias.BuscarMayorIdActivoFijoTransferencia(_tipoCon) + 1
                    .Fecha = txtFechaTransferencia.Text
                    .IdPersonalAnterior = txtIdCustodioAnterior.Text
                    .IdPersonalNuevo = txtIdCustodioNuevo.Text
                    .NombreAutoriza = cbAutoriza.Text.ToUpper.Trim
                    .RazonTransferencia = txtRazon.Text.ToUpper.Trim
                    .UbicacionAnterior = txtUbicacionAnterior.Text
                    .CustodioAnterior = txtNombreCustodioAnterior.Text
                    .UbicacionNueva = txtUbicacionNueva.Text
                    .CustodioNuevo = txtNombreCustodioNuevo.Text
                    .Estado = 1
                End With
                _sqlCommands.Add(_objetoActovoFijoTransferencias.NuevoActivoFijoTransferencias)

                For indice = 0 To dgvTransferencias.Rows.Count - 2
                    With _objetoActivoFijo
                        .IdActivoFijo = dgvTransferencias.Rows(indice).Cells("ID_ACTIVO_FIJO").Value
                        .IdPersonal = dgvTransferencias.Rows(indice).Cells("ID_PERSONAL").Value
                        .NombreCustodio = txtNombreCustodioNuevo.Text.Trim.ToUpper
                        .IdEmpresa = dgvTransferencias.Rows(indice).Cells("ID_EMPRESA").Value
                        .IdSucursal = dgvTransferencias.Rows(indice).Cells("ID_SUCURSAL").Value
                        .IdGerencias = dgvTransferencias.Rows(indice).Cells("ID_GERENCIAS").Value
                        .IdAreas = dgvTransferencias.Rows(indice).Cells("ID_AREA").Value
                        .EstadoActivo = dgvTransferencias.Rows(indice).Cells("ESTADO_ACTIVO").Value
                    End With
                    _sqlCommands.Add(_objetoActivoFijo.ActualizarCustodiosDeActivosFijosPorTransferencias)
                Next

                For indice = 0 To dgvTransferencias.Rows.Count - 2
                    With _objetoDetalleTransferencias
                        .IdDetalle = Convert.ToInt64(txtIdTransferencia.Text)
                        .CodigoActivo = dgvTransferencias.Rows(indice).Cells("CODIGO_ACTIVO").Value
                        .NombreActivo = dgvTransferencias.Rows(indice).Cells("NOMBRE_ACTIVO").Value
                        .IdEmpresa = dgvTransferencias.Rows(indice).Cells("ID_EMPRESA").Value
                        .IdSucursal = dgvTransferencias.Rows(indice).Cells("ID_SUCURSAL").Value
                        .IdGerencias = dgvTransferencias.Rows(indice).Cells("ID_GERENCIAS").Value
                        .IdArea = dgvTransferencias.Rows(indice).Cells("ID_AREA").Value
                        .Estado = 1
                        .EstadoTransferencia = dgvTransferencias.Rows(indice).Cells("ESTADO_ACTIVO").Value
                    End With
                    _sqlCommands.Add(_objetoDetalleTransferencias.NuevoDetalleTransferencia)
                Next
                Auditoria()

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    CargarActivoFijo()
                    CargarPersonal()
                    dgvTransferencias.Rows.Clear()
                    btnGuardarTransferencia.Enabled = False
                    txtRazon.Enabled = False
                    cbAutoriza.Enabled = False
                    btnAgregarActivoFijo.Enabled = False
                    btnEliminarActivoFijoTransferencia.Enabled = False
                    ButtonNuevoRegistro.Enabled = True
                    cbEmpresa.Enabled = False
                    cbSucursal.Enabled = False
                    cbgerencias.Enabled = False
                    cbArea.Enabled = False
                    cbEstadoActual.Enabled = False
                    txtIdCustodioAnterior.Text = ""
                    txtNombreCustodioAnterior.Text = ""
                    txtIdCustodioNuevo.Text = ""
                    txtNombreCustodioNuevo.Text = ""
                    txtRazon.Text = ""
                    cbAutoriza.Text = ""
                    txtUbicacionAnterior.Text = ""
                    txtUbicacionNueva.Text = ""

                    Dim reporteTransferencias As New FormReporteTransferenciasActivosFijos
                    reporteTransferencias.lblIdTransferencia.Text = txtIdTransferencia.Text
                    reporteTransferencias.ShowDialog()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
                Else
                MsgBox("No a completado todos los parametros necesarios en la transferencia", MsgBoxStyle.Critical, "Mensaje de Validación")
            End If
            End Sub

        Private Sub btnCustodioNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNombreCustodioNuevo.Click
            Try
                If dgvBusquedaPersonal.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    MsgBox("´Tabla de Personal Vacía por favor comunicarse con RR.HH", MsgBoxStyle.Critical, "Mensaje de Validación")
                Else
                    If txtIdCustodioAnterior.Text <> dgvBusquedaPersonal.CurrentRow.Cells.Item(0).Value.ToString Then
                        txtNombreCustodioNuevo.Text = dgvBusquedaPersonal.CurrentRow.Cells.Item(2).Value.ToString + " " + dgvBusquedaPersonal.CurrentRow.Cells.Item(3).Value.ToString
                        txtIdCustodioNuevo.Text = dgvBusquedaPersonal.CurrentRow.Cells.Item(0).Value.ToString
                        txtUbicacionNueva.Text = dgvBusquedaPersonal.CurrentRow.Cells.Item("UBICACION").Value.ToString
                    Else
                        MsgBox("No se puede agragar custodi@", MsgBoxStyle.Critical, "Mensaje de Validación")
                        txtIdCustodioNuevo.Text = ""
                        txtNombreCustodioNuevo.Text = ""
                        txtUbicacionNueva.Text = ""
                    End If
                End If
            Catch ex As Exception
                MsgBox("Dato no encontrado, vuelva a buscar el personal", MsgBoxStyle.Critical, "Mensaje de Validación")
            End Try
        End Sub

        Private Sub btnCustodioAnterior_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtNombreCustodioAnterior.Click
            Try
                If dgvBusquedaPersonal.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    MsgBox("´Tabla de Personal Vacía por favor comunicarse con RR.HH", MsgBoxStyle.Critical, "Mensaje de Validación")
                Else
                    If txtIdCustodioNuevo.Text <> dgvBusquedaPersonal.CurrentRow.Cells.Item(0).Value.ToString Then
                        txtNombreCustodioAnterior.Text = dgvBusquedaPersonal.CurrentRow.Cells.Item(2).Value.ToString + " " + dgvBusquedaPersonal.CurrentRow.Cells.Item(3).Value.ToString
                        txtIdCustodioAnterior.Text = dgvBusquedaPersonal.CurrentRow.Cells.Item(0).Value.ToString
                        txtUbicacionAnterior.Text = dgvBusquedaPersonal.CurrentRow.Cells.Item("UBICACION").Value.ToString
                    Else
                        MsgBox("No se puede agragar custodi@", MsgBoxStyle.Critical, "Mensaje de Validación")
                        txtIdCustodioAnterior.Text = ""
                        txtNombreCustodioAnterior.Text = ""
                        txtUbicacionAnterior.Text = ""
                    End If
                End If
            Catch ex As Exception
                MsgBox("Dato no encontrado, vuelva a buscar el personal", MsgBoxStyle.Critical, "Mensaje de Validación")
            End Try
        End Sub

    End Class
End Namespace