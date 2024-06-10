Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormMantenimientoProveedorCalificado

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

        ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoProveedorCalificado As New ClassProveedorCalificado
        ReadOnly _objetoContactoProveedor As New ClassContactosProveedorCalificado
        ReadOnly _objetoPaises As New ClassPaises
        ReadOnly _objetoProvincias As New ClassProvincias
        ReadOnly _objetoCiudades As New ClassCiudades

        Private Sub DeshabilitadoInicio()
            btnBuscarProveedorCalificado.Enabled = False
            dtpFechaInicio.Enabled = False
            dtpFechaActualizacion.Enabled = False
            dtpFechaCese.Enabled = False
            txtNumeroCarpeta.Enabled = False
            txtActividad.Enabled = False
            cmbImportador.Enabled = False
            cmbPais.Enabled = False
            cmbProvincia.Enabled = False
            cmbCiudad.Enabled = False
            txtPaginaWeb.Enabled = False
            txtServiciosPrestados.Enabled = False
            cmbFormaPago.Enabled = False
            txtCertificaciones.Enabled = False
            txtObservaciones.Enabled = False
            btnAgregar.Enabled = False
            btnEliminar.Enabled = False
            btnNuevoProveedorCalificado.Enabled = True
            btnCancelarProveedorCalificado.Enabled = False
            btnGuardarProveedorCalificado.Enabled = False
        End Sub

        Private Sub HabilitadoNuevo()
            btnBuscarProveedorCalificado.Enabled = True
            dtpFechaInicio.Enabled = True
            dtpFechaActualizacion.Enabled = True
            dtpFechaCese.Enabled = True
            txtNumeroCarpeta.Enabled = True
            txtActividad.Enabled = True
            cmbImportador.Enabled = True
            cmbPais.Enabled = True
            cmbProvincia.Enabled = True
            cmbCiudad.Enabled = True
            txtPaginaWeb.Enabled = True
            txtServiciosPrestados.Enabled = True
            cmbFormaPago.Enabled = True
            txtCertificaciones.Enabled = True
            txtObservaciones.Enabled = True
            btnAgregar.Enabled = True
            btnEliminar.Enabled = True
            btnNuevoProveedorCalificado.Enabled = False
            btnCancelarProveedorCalificado.Enabled = True
            btnGuardarProveedorCalificado.Enabled = True
        End Sub

        Private Sub LimpiarParametros()
            txtIdProveedorGeneral.Text = ""
            txtRucCiProveedorGeneral.Text = ""
            txtRazonSocial.Text = ""
            txtNombreComercialProveedorGeneral.Text = ""
            dtpFechaInicio.Refresh()
            dtpFechaActualizacion.Refresh()
            dtpFechaCese.Refresh()
            txtNumeroCarpeta.Text = ""
            txtActividad.Text = ""
            cmbImportador.Text = "..."
            txtPaginaWeb.Text = ""
            txtServiciosPrestados.Text = ""
            cmbFormaPago.Text = "Seleccione una Opción"
            txtCertificaciones.Text = ""
            txtObservaciones.Text = ""
        End Sub

        Private Function ValidarParametros() As Boolean
            Return txtIdProveedorGeneral.Text <> "" And txtRucCiProveedorGeneral.Text <> "" And txtRazonSocial.Text <> "" And txtNombreComercialProveedorGeneral.Text <> "" And txtNumeroCarpeta.Text <> "" And txtActividad.Text <> "" And txtPaginaWeb.Text <> "" And txtServiciosPrestados.Text <> "" And txtCertificaciones.Text <> "" And txtObservaciones.Text <> ""
        End Function

        Private Sub LlenarComboPaises()
            Try
                Dim data = _objetoPaises.SeleccionarTodosLosRegistrosPaises(_tipoCon)
                cmbPais.DataSource = data
                cmbPais.DisplayMember = data.Columns(1).ToString
                cmbPais.ValueMember = data.Columns(1).ToString
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "MSG EXCEPCIÓN")
            End Try
        End Sub

        Private Sub Auditoria()
            With _objAuditoria

                .IdAuditoria = Convert.ToInt64(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                .IdUsuarioAuditoria = IdUsuario
                .EstadoAuditoria = 1
                .FechaAuditoria = Date.Now
                .NuevaAuditoria(_tipoCon)
            End With
        End Sub

        Private Sub GuardarRegistroProveedorCalificado()
            With _objetoProveedorCalificado

                .IdProveedorCalificado = .BuscarMayorIdProveedorCalificado(_tipoCon) + 1
                .FechaInicioProveedorCalificado = dtpFechaInicio.Value
                .FechaCeseProveedorCalificado = dtpFechaCese.Value
                .FechaActualizacionProveedorCalificado = dtpFechaActualizacion.Value
                .NumeroCarpetaProveedorCalificado = txtNumeroCarpeta.Text
                .ActividadProveedorCalificado = txtActividad.Text
                .ImportadorProveedorCalificado = cmbImportador.Text
                .PaginaWebProveedorCalificado = txtPaginaWeb.Text
                .ServiciosPrestadosProveedorCalificado = txtServiciosPrestados.Text
                .FormaPagoProveedorCalificado = cmbFormaPago.Text
                .CertificacionesProveedorCalificado = txtCertificaciones.Text
                .ObservacionesProveedorCalificado = txtObservaciones.Text
                .EstadoProveedorCalificado = 1
                .IdproveedorGeneral = txtIdProveedorGeneral.Text
                .NuevoRegistroProveedorCalificado(_tipoCon)
            End With
            _objAuditoria.AccionAuditoria = "CREO REGISTRO DE PROVEEDOR CALIFICADO. ID: " + txtIdProveedorGeneral.Text + " CORRESPONDIENTE AL PROVEEDOR GENERAL: RUC: " + txtRucCiProveedorGeneral.Text + " RAZÓN SOCIAL: " + txtRazonSocial.Text
            _objAuditoria.FormularioAuditoria = Me.Text.ToUpper
            Auditoria()
        End Sub

        Private Sub GuardarRegistroContactoProveedorCalificado()
            Dim indice As Integer
            For indice = 0 To dgvContactosProveedorCalificado.RowCount - 1
                With _objetoContactoProveedor
                    .IdContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(0).Value
                    .NombresContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(1).Value
                    .ApellidosContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(2).Value
                    .CargoContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(3).Value
                    .TelefonoContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(4).Value
                    .CelularContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(5).Value
                    .EmailContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(6).Value
                    .EstadoContactoProveedorCalificado = dgvContactosProveedorCalificado.Rows(indice).Cells(7).Value
                    .IdProveedorGeneral = dgvContactosProveedorCalificado.Rows(indice).Cells(8).Value
                    .NuevoRegistroContactoProveedorCalificado(_tipoCon)
                End With
                _objAuditoria.AccionAuditoria = "CREO REGISTRO CONTÁCTO DE PROVEEDOR CALIFICADO. ID: " + dgvContactosProveedorCalificado.Rows(indice).Cells(0).Value + "NOMBRE: " + dgvContactosProveedorCalificado.Rows(indice).Cells(1).Value + " " + dgvContactosProveedorCalificado.Rows(indice).Cells(2).Value + " CORRESPONDIENTE AL PROVEEDOR GENERAL: RUC: " + txtRucCiProveedorGeneral.Text + " RAZÓN SOCIAL: " + txtRazonSocial.Text
                _objAuditoria.FormularioAuditoria = Me.Text.ToUpper
                Auditoria()
            Next
        End Sub

        Private Sub FormMantenimientoProveedorCalificado_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvContactosProveedorCalificado.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvContactosProveedorCalificado.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvContactosProveedorCalificado.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvContactosProveedorCalificado.Font = New Font("Roboto", 8, FontStyle.Regular)
            DeshabilitadoInicio()
            limpiarParametros()
            llenarComboPaises() 
        End Sub

        Private Sub btnNuevoProveedorCalificado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoProveedorCalificado.Click
            habilitadoNuevo()
            limpiarParametros()
            llenarComboPaises() 
        End Sub
        Private Sub btnCancelarProveedorCalificado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarProveedorCalificado.Click
            limpiarParametros()
            deshabilitadoInicio()
        End Sub
        Private Sub btnGuardarProveedorCalificado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarProveedorCalificado.Click
            If validarParametros() = True Then

                guardarRegistroProveedorCalificado()
                guardarRegistroContactoProveedorCalificado()
                deshabilitadoInicio()
            Else
                MsgBox("NO SE PUEDE GUARDAR." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub
        
        Private Sub btnBuscarProveedorCalificado_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarProveedorCalificado.Click
            Dim formBuscarProveedor As New FormBuscarProveedorCalificado
            formBuscarProveedor.TipoCox = TipoCox
            DialogResult = formBuscarProveedor.ShowDialog
            Try
                If DialogResult = vbOK Then
                    txtIdProveedorGeneral.Text = formBuscarProveedor.dgvProveedorGeneral.CurrentRow.Cells.Item(0).Value.ToString
                    txtRucCiProveedorGeneral.Text = formBuscarProveedor.dgvProveedorGeneral.CurrentRow.Cells.Item(2).Value.ToString
                    txtRazonSocial.Text = formBuscarProveedor.dgvProveedorGeneral.CurrentRow.Cells.Item(3).Value.ToString
                    txtNombreComercialProveedorGeneral.Text = formBuscarProveedor.dgvProveedorGeneral.CurrentRow.Cells.Item(4).Value.ToString
                End If
            Catch ex As Exception
                MsgBox("BOTÓN BUSCAR PROVEEDOR:" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar.Click
            If txtIdProveedorGeneral.Text <> "" Then
                Dim formAgregarContacto As New FormContactosProveedorCalificado
                formAgregarContacto.TipoCox = TipoCox
                DialogResult = formAgregarContacto.ShowDialog
                Try
                    If DialogResult = vbOK Then
                        dgvContactosProveedorCalificado.Rows.Add(formAgregarContacto.txtIdContactoProveedorCalificado.Text, formAgregarContacto.txtNombresContactoProveedorCalificado.Text, _
                                                                 formAgregarContacto.txtApellidosContactoProveedorCalificado.Text, formAgregarContacto.txtCargoContactoProveedorCalificado.Text, _
                                                                 formAgregarContacto.txtTelefonoContactoProveedorCalificado.Text, formAgregarContacto.txtCelularContactoProveedorCalificado.Text, _
                                                                 formAgregarContacto.txtEmailContactoProveedorCalificado.Text, "1", txtIdProveedorGeneral.Text)
                    End If
                Catch ex As Exception
                    MsgBox("BOTÓN BUSCAR PROVEEDOR:" & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
                End Try
            Else
                MsgBox("NO PUEDE AGREGAR CONTÁCTOS." & vbNewLine & "POR FAVOR PRIMERO SELECCIONE UN PROVEEDOR.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub
        Private Sub cmbPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbPais.SelectedIndexChanged
            Try
                lblIdPaises.Text = _objetoPaises.BuscarIdPaisXNombrePais(_tipoCon, cmbPais.SelectedValue.ToString)
                Dim data = _objetoProvincias.BuscarNombreProvinciasXIdPaises(_tipoCon, cmbPais.SelectedIndex + 1)
                cmbProvincia.DataSource = data
                If cmbProvincia.Items.Count = 0 Then
                    cmbProvincia.Text = "NINGÚN PAÍS"
                Else
                    lblIdPaises.Text = _objetoPaises.BuscarIdPaisXNombrePais(_tipoCon, cmbPais.SelectedValue.ToString)
                    cmbProvincia.DisplayMember = data.Columns(0).ToString
                    cmbProvincia.ValueMember = data.Columns(0).ToString
                End If
            Catch ex As Exception
            End Try
        End Sub
        Private Sub cmbProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbProvincia.SelectedIndexChanged
            Try
                lblIdProvincia.Text = _objetoProvincias.BuscarIdProvinciaXNombreProvincia(_tipoCon, cmbProvincia.SelectedValue.ToString)

                Dim data = _objetoCiudades.BuscarNombreCiudadXIdProvincia(_tipoCon, cmbProvincia.SelectedIndex + 1)
                cmbCiudad.DataSource = data
                If cmbCiudad.Items.Count = 0 Then
                    cmbCiudad.Text = "NINGUNA CIUDAD"
                Else
                    'lblIdProvincia.Text = _objetoProvincias.IdProvincias
                    cmbCiudad.DisplayMember = data.Columns(0).ToString
                    cmbCiudad.ValueMember = data.Columns(0).ToString
                End If
            Catch ex As Exception
                MsgBox("COMBOBOX PROVINCIA." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub

        Private Sub cmbCiudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbCiudad.SelectedIndexChanged
            Try
                lblIdCiudad.Text = _objetoCiudades.BuscarIdCiudadPorNombreCiudad(_tipoCon, cmbCiudad.SelectedValue.ToString)
            Catch ex As Exception
            End Try
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminar.Click
            If dgvContactosProveedorCalificado.RowCount = 0 Then
                MsgBox("NO HAY CELDAS EN LA GRILLA", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            Else
                dgvContactosProveedorCalificado.Rows.RemoveAt(dgvContactosProveedorCalificado.CurrentRow.Index)
            End If
        End Sub
    End Class
End Namespace