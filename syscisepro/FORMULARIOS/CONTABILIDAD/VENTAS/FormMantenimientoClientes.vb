Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports ClassLibraryCisepro.VALIDACIONES
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO
Imports Krypton.Toolkit
Imports ClosedXML.Excel
Imports System.IO

Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormMantenimientoClientes
        Private _tipoCon As TipoConexion

        Property TipoCox As Integer
            Private Get
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

        ReadOnly _objetoAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoClienteGeneral As New ClassClienteGeneral
        ReadOnly _objetoConvenioCliente As New ClassConvenioClienteDebito
        ReadOnly _objetoContratoCliente As New ClassContratoCliente
        ReadOnly _objetoSitio As New ClassSitiosTrabajo
        ReadOnly _objProvincias As New ClassProvincias
        ReadOnly _objCiudad As New ClassCiudades
        ReadOnly _objParroquias As New ClassParroquias
        ReadOnly _objPer As New ClassPersonal
        ReadOnly _validacionesNumeros As New ClassNumerico
        ReadOnly _validacionesDecimales As New ClassDecimal
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _objetoNumeroRegistroAsientoFacturaVenta As New ClassNumeroRegistroAsientoFacturaVenta

        ReadOnly _objetoDireccionesFacturacion As New ClassDireccionesFacturacion

        Dim _botonSeleccionado As Integer = 0
        Dim botonSeleccionadoSitio As Integer = 0

        Private Sub FormMantenimientoClientes_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA            
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing


                    MenuStrip2.ForeColor = Color.White
                    MenuStrip2.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    MenuStrip3.ForeColor = Color.White
                    MenuStrip3.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    MenuStrip5.ForeColor = Color.White
                    MenuStrip5.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvClienteGeneral.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSitios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    DataGridView1.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    DataGridView2.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    DataGridView3.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s

                    dgvClienteGeneral.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSitios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    DataGridView1.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    DataGridView2.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    DataGridView3.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c


                    'MenuStrip3.ForeColor = Color.White
                    'MenuStrip3.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    'MenuStrip5.ForeColor = Color.White
                    'MenuStrip5.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvClienteGeneral.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSitios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    DataGridView1.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvFacturaVenta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    DataGridView2.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    DataGridView3.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvClienteGeneral.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvSitios.Font = New Font("Roboto", 8, FontStyle.Regular)
            DataGridView1.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvFacturaVenta.Font = New Font("Roboto", 8, FontStyle.Regular)
            DataGridView2.Font = New Font("Roboto", 8, FontStyle.Regular)
            DataGridView3.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)

            dtpFechaDesde.Value = New DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0)
            dtpFechaHasta.Value = dtpFechaDesde.Value.AddYears(1).AddDays(-1)
            'GenerarAnios()
            DeshabilitadoInicio()
            AutocompletarNombreCiudades()
            AutocompletarConsorcioCliente()
            LlenarSupervisores()
            LlenarProvincia()

            txtBuscarCliente.Focus()
        End Sub

        Private Sub DeshabilitadoInicio()
            'gbDatosClienteGeneral.Enabled = False
            cmbTipoCliente.Enabled = False
            cmbTipoEmpresa.Enabled = False
            cmbTipoIdentificacion.Enabled = False
            txtNombreRazonSocialClienteGeneral.Enabled = False
            txtApellidoNombreComercial.Enabled = False
            txtRucCiClienteGeneral.Enabled = False
            'gbDireccionClienteGeneral.Enabled = False
            txtCiudad.Enabled = False
            txtDireccionUbicacionClienteGeneral.Enabled = False
            txtDireccionFacturacionClienteGeneral.Enabled = False
            txtConsorcioGrupo.Enabled = False
            'gbFechaIngresoClienteGeneral.Enabled = False
            dtpFechaIngresoClienteGeneral.Enabled = False

            'gbInformacionContacto.Enabled = False
            txtContactoClienteGeneral.Enabled = False
            txtEmailClienteGeneral.Enabled = False
            'gbTelefonos.Enabled = False
            txtTelefono1ClienteGeneral.Enabled = False
            txtTelefono2ClienteGeneral.Enabled = False
            'gbIngresoObservaciones.Enabled = False
            TextBoxVal.Enabled = False
            dtpFechaContrato.Enabled = False
            txtObservaciones.Enabled = False
            'gbNroResolucionContEspecial.Enabled = False
            rbSiContribuyenteEspecial.Enabled = False
            rbNoContribuyenteEspecial.Enabled = False
            txtnroResContEspecial.Enabled = False
            'gbOligadoLlevarContabilidad.Enabled = False
            rbSILlevaContabilidad.Enabled = False
            rbNOLlevaContabilidad.Enabled = False
            txtnroResContEspecial.Enabled = False
            'gbTipoClienteGeneral.Enabled = False
            cmbTipoCliente.Enabled = False
            ToolStripMenuItem14.Enabled = False
            ToolStripMenuItem11.Enabled = False
            ToolStripMenuItem16.Enabled = False
            Button2.Enabled = False

            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            btnAnular.Enabled = False
            btnCancelar.Enabled = False

            btnAdd.Enabled = False
            btnRemove.Enabled = False
        End Sub
        Private Sub AutocompletarNombreCiudades()
            txtCiudad.AutoCompleteCustomSource = _objCiudad.Autocompletar(_tipoCon)
            txtCiudad.AutoCompleteMode = AutoCompleteMode.Suggest
            txtCiudad.AutoCompleteSource = AutoCompleteSource.CustomSource
        End Sub
        Private Sub AutocompletarConsorcioCliente()
            txtConsorcioGrupo.AutoCompleteCustomSource = _objetoClienteGeneral.AutocompletarConsorcio(_tipoCon)
            txtConsorcioGrupo.AutoCompleteMode = AutoCompleteMode.Suggest
            txtConsorcioGrupo.AutoCompleteSource = AutoCompleteSource.CustomSource
        End Sub
        Private Sub LlenarSupervisores()
            Try
                Dim pars = _objPer.BuscarPersonal(_tipoCon)
                cbxSupervisor.DataSource = pars
                cbxSupervisor.DisplayMember = pars.Columns("DATOS").ToString
                cbxSupervisor.ValueMember = pars.Columns("ID").ToString
                cbxSupervisor.DropDownWidth = 300
                cbxSupervisor.SelectedValue = 468
                cbxSupervisor.SelectedIndex = 0
            Catch
                cbxSupervisor.DataSource = Nothing
            End Try
        End Sub
        Private Sub LlenarProvincia()
            Try
                Dim provs As DataTable = _objProvincias.SeleccionarTodosLosRegistrosProvincias(_tipoCon)
                cbmProvincia.DataSource = provs
                cbmProvincia.DisplayMember = provs.Columns("NOMBRE_PROVINCIAS").ToString
                cbmProvincia.ValueMember = provs.Columns("ID_PROVINCIAS").ToString
                cbmProvincia.DropDownWidth = 200
                cbmProvincia.SelectedIndex = 0
            Catch
                cbmProvincia.DataSource = Nothing
            End Try
        End Sub
        Private Sub cbmProvincia_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmProvincia.SelectedValueChanged
            If cbmProvincia.SelectedValue Is Nothing Or TypeOf cbmProvincia.SelectedValue Is DataRowView Then Return
            LlenarCiudad()
        End Sub
        Private Sub LlenarCiudad()
            Try
                Dim cius = _objCiudad.BuscarNombreCiudadXIdProvincia(_tipoCon, cbmProvincia.SelectedValue.ToString)
                cbmCanton.DataSource = cius
                cbmCanton.DisplayMember = cius.Columns("NOMBRE_CIUDADES").ToString
                cbmCanton.ValueMember = cius.Columns("ID_CIUDAD").ToString
                cbmCanton.DropDownWidth = 300
                cbmCanton.SelectedIndex = 0
            Catch
                cbmCanton.DataSource = Nothing
            End Try
        End Sub
        Private Sub cbmCanton_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCanton.SelectedValueChanged
            If cbmCanton.SelectedValue Is Nothing Or TypeOf cbmCanton.SelectedValue Is DataRowView Then Return
            LlenarParroquia()
        End Sub
        Private Sub LlenarParroquia()
            Try
                Dim pars = _objParroquias.BuscarNombreParroquiaXIdCiudad(_tipoCon, cbmCanton.SelectedValue.ToString)
                cbmParroquia.DataSource = pars
                cbmParroquia.DisplayMember = pars.Columns("NOMBRE_PARROQUIAS").ToString
                cbmParroquia.ValueMember = pars.Columns("ID_PARROQUIAS").ToString
                cbmParroquia.DropDownWidth = 300
                cbmParroquia.SelectedIndex = 0
            Catch
                cbmParroquia.DataSource = Nothing
            End Try
        End Sub
        Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem1.Click
            txtBuscarCliente.Clear()
            CargarClienteGeneral()
        End Sub
        Private Sub CargarSitiosClienteGeneral()
            Try
                dgvSitios.DataSource = _objetoSitio.SeleccionarSitiosxIdCliente(_tipoCon, Label23.Text.Trim, String.Empty)

                dgvSitios.Columns(0).HeaderText = "ID"
                dgvSitios.Columns(0).Width = 50
                dgvSitios.Columns(1).HeaderText = "NOMBRE SITIO"
                dgvSitios.Columns(1).Width = 250
                dgvSitios.Columns(2).Visible = False
                dgvSitios.Columns(3).HeaderText = "PROVINCIA"
                dgvSitios.Columns(3).Width = 90
                dgvSitios.Columns(4).Visible = False
                dgvSitios.Columns(5).HeaderText = "CIUDAD"
                dgvSitios.Columns(5).Width = 90
                dgvSitios.Columns(6).Visible = False
                dgvSitios.Columns(7).HeaderText = "PARROQUIA"
                dgvSitios.Columns(7).Width = 120
                dgvSitios.Columns(8).HeaderText = "DIRECCIÓN UBICACIÓN"
                dgvSitios.Columns(8).Width = 200
                dgvSitios.Columns(9).HeaderText = "REFERENCIA UBICACIÓN"
                dgvSitios.Columns(9).Width = 200
                dgvSitios.Columns(10).HeaderText = "TIPO"
                dgvSitios.Columns(10).Width = 50
                dgvSitios.Columns(11).Visible = False
                dgvSitios.Columns(12).HeaderText = "SUPERVISOR"
                dgvSitios.Columns(12).Width = 230
                dgvSitios.Columns(13).Width = 60

                dgvSitios.ReadOnly = False
                dgvSitios.EditMode = DataGridViewEditMode.EditProgrammatically

                For Each row As DataGridViewRow In From row1 As DataGridViewRow In dgvSitios.Rows Where row1.Cells("ESTADO").Value = 0
                    row.DefaultCellStyle.BackColor = Color.Coral
                Next

            Catch
                dgvSitios.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvClienteGeneral_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvClienteGeneral.SelectionChanged
            If dgvClienteGeneral.RowCount = 0 Then Return
            If _botonSeleccionado <> 0 Then Return

            If dgvClienteGeneral.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                lblIdClienteGeneral.Text = "..."
            Else
                Label44.Text = dgvClienteGeneral.CurrentRow.Cells.Item(0).Value
                Label47.Text = dgvClienteGeneral.CurrentRow.Cells.Item(3).Value
                TextBox13.Text = dgvClienteGeneral.CurrentRow.Cells.Item(4).Value
                TextBox12.Text = dgvClienteGeneral.CurrentRow.Cells.Item(5).Value

                lblIdClienteGeneral.Text = dgvClienteGeneral.CurrentRow.Cells.Item(0).Value
                cmbTipoIdentificacion.Text = dgvClienteGeneral.CurrentRow.Cells.Item(2).Value
                txtRucCiClienteGeneral.Text = dgvClienteGeneral.CurrentRow.Cells.Item(3).Value
                txtNombreRazonSocialClienteGeneral.Text = dgvClienteGeneral.CurrentRow.Cells.Item(4).Value
                txtApellidoNombreComercial.Text = dgvClienteGeneral.CurrentRow.Cells.Item(5).Value
                txtnroResContEspecial.Text = dgvClienteGeneral.CurrentRow.Cells.Item(6).Value
                If dgvClienteGeneral.CurrentRow.Cells.Item(6).Value = "SI" Then
                    rbSiContribuyenteEspecial.Checked = True
                ElseIf dgvClienteGeneral.CurrentRow.Cells.Item(6).Value = "NO" Or dgvClienteGeneral.CurrentRow.Cells.Item(6).Value = "0" Then
                    rbNoContribuyenteEspecial.Checked = True
                End If
                If dgvClienteGeneral.CurrentRow.Cells.Item(7).Value = "SI" Then
                    rbSILlevaContabilidad.Checked = True
                Else
                    rbNOLlevaContabilidad.Checked = True
                End If
                txtDireccionUbicacionClienteGeneral.Text = dgvClienteGeneral.CurrentRow.Cells.Item(8).Value
                txtDireccionFacturacionClienteGeneral.Text = dgvClienteGeneral.CurrentRow.Cells.Item(9).Value
                txtConsorcioGrupo.Text = dgvClienteGeneral.CurrentRow.Cells.Item(10).Value
                lblIdCiudad.Text = dgvClienteGeneral.CurrentRow.Cells.Item(11).Value
                txtCiudad.Text = _objCiudad.BuscarNombreCiudadXIdCiudad(_tipoCon, CType(lblIdCiudad.Text, Integer))
                txtTelefono1ClienteGeneral.Text = dgvClienteGeneral.CurrentRow.Cells.Item(12).Value
                txtTelefono2ClienteGeneral.Text = dgvClienteGeneral.CurrentRow.Cells.Item(13).Value
                txtEmailClienteGeneral.Text = dgvClienteGeneral.CurrentRow.Cells.Item(14).Value
                txtContactoClienteGeneral.Text = dgvClienteGeneral.CurrentRow.Cells.Item(15).Value
                dtpFechaIngresoClienteGeneral.Value = dgvClienteGeneral.CurrentRow.Cells.Item(16).Value
                cmbTipoCliente.Text = dgvClienteGeneral.CurrentRow.Cells.Item(17).Value
                txtObservaciones.Text = dgvClienteGeneral.CurrentRow.Cells.Item(18).Value
                cmbTipoEmpresa.Text = If(dgvClienteGeneral.CurrentRow.Cells.Item(20).Value Is DBNull.Value, "", dgvClienteGeneral.CurrentRow.Cells.Item(20).Value)
                Label23.Text = dgvClienteGeneral.CurrentRow.Cells.Item(0).Value
                ComboBox1.Text = dgvClienteGeneral.CurrentRow.Cells.Item(2).Value
                TextBox1.Text = dgvClienteGeneral.CurrentRow.Cells.Item(3).Value
                TextBox2.Text = dgvClienteGeneral.CurrentRow.Cells.Item(4).Value
                TextBox3.Text = dgvClienteGeneral.CurrentRow.Cells.Item(5).Value

                Label17.Text = dgvClienteGeneral.CurrentRow.Cells.Item(0).Value
                ComboBox3.Text = dgvClienteGeneral.CurrentRow.Cells.Item(2).Value
                TextBox4.Text = dgvClienteGeneral.CurrentRow.Cells.Item(3).Value
                TextBox6.Text = dgvClienteGeneral.CurrentRow.Cells.Item(4).Value + " (" + dgvClienteGeneral.CurrentRow.Cells.Item(5).Value + ")"

                'Datos contrato
                'convertir dgvClienteGeneral.CurrentRow.Cells.Item(22).Value a Year
                Dim Year = If(dgvClienteGeneral.CurrentRow.Cells.Item(22).Value.ToString() Is DBNull.Value, "", dgvClienteGeneral.CurrentRow.Cells.Item(22).Value) 'fecha

                dtpFechaContrato.Text = If(dgvClienteGeneral.CurrentRow.Cells.Item(22).Value Is DBNull.Value, "01/01/1985", dgvClienteGeneral.CurrentRow.Cells.Item(22).Value)
                TextBoxVal.Text = If(dgvClienteGeneral.CurrentRow.Cells.Item(23).Value Is DBNull.Value, "", dgvClienteGeneral.CurrentRow.Cells.Item(23).Value) 'valor
                TextBox5.Text = If(dgvClienteGeneral.CurrentRow.Cells.Item(23).Value Is DBNull.Value, "", dgvClienteGeneral.CurrentRow.Cells.Item(23).Value) 'valor
                TextBox7.Text = If(dgvClienteGeneral.CurrentRow.Cells.Item(22).Value Is DBNull.Value, "", dgvClienteGeneral.CurrentRow.Cells.Item(22).Value) 'fecha

                dgvFacturaVenta.DataSource = Nothing
                SumarTotalFacturas()

                'Try
                ' Dim c = _objetoContratoCliente.BuscarContratoActivoClienteGeneralXId(_tipoCon, dgvClienteGeneral.CurrentRow.Cells.Item(20).Value)
                '    ComboBox2.SelectedItem = c.Rows(0)(3)
                '    TextBoxVal.Text = c.Rows(0)(2)
                '    TextBoxVal.Tag = dgvClienteGeneral.CurrentRow.Cells.Item(20).Value

                '    TextBox7.Text = c.Rows(0)(3)
                '    TextBox5.Text = c.Rows(0)(2)
                '    TextBox5.Tag = dgvClienteGeneral.CurrentRow.Cells.Item(20).Value
                'Catch ex As Exception
                '    ComboBox2.SelectedIndex = ComboBox2.Items.Count - 1
                '    TextBoxVal.Text = "0.00"
                '    TextBoxVal.Tag = Nothing

                '    TextBox7.Clear()
                '    TextBox5.Clear()
                '    TextBox5.Tag = Nothing

                '    KryptonMessageBox.Show("El cliente no tiene contrato activo." & vbNewLine & ex.Message, "Cisepro", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)

                'End Try

                ToolStripMenuItem14.Enabled = True
                ToolStripMenuItem11.Enabled = False
                ToolStripMenuItem16.Enabled = False

                CargarSitiosClienteGeneral()
                CargarCuentasBanco()

                ToolStripMenuItem9.PerformClick()
            End If
        End Sub
        Private Sub CargarCuentasBanco()
            Dim data = _objetoConvenioCliente.BuscarConvenioClienteGeneralXId(_tipoCon, lblIdClienteGeneral.Text)
            DataGridView1.Rows.Clear()
            For Each row As DataRow In data.Rows
                DataGridView1.Rows.Add(row.Item("ID_CONVENIO"),
                                       row.Item("ID_CLIENTE_GENERAL"),
                                       row.Item("BANCO_CONVENIO"),
                                       row.Item("TIPO_CUENTA"),
                                       row.Item("TIPO_DOC"),
                                       row.Item("NUM_CUENTA_TARJ"),
                                       row.Item("NUM_CI_RUC"),
                                       row.Item("TITULAR_CUENTA"),
                                       CDbl(row.Item("VALOR")).ToString("N"),
                                       row.Item("OBSERVACION"))
            Next
        End Sub
        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click

            HabilitadoNuevo()
            LimpiarParametros()
            _botonSeleccionado = 1

            'ComboBox2.SelectedIndex = 0
            cmbTipoIdentificacion.SelectedIndex = 0
            cmbTipoCliente.SelectedIndex = 0
            rbNoContribuyenteEspecial.Checked = True
            rbNOLlevaContabilidad.Checked = True
            cmbTipoEmpresa.SelectedIndex = 0
            DataGridView1.Rows.Clear()

            txtRucCiClienteGeneral.Focus()
        End Sub
        Private Sub HabilitadoNuevo()
            'gbDatosClienteGeneral.Enabled = True
            cmbTipoCliente.Enabled = True
            cmbTipoEmpresa.Enabled = True
            cmbTipoIdentificacion.Enabled = True
            txtNombreRazonSocialClienteGeneral.Enabled = True
            txtApellidoNombreComercial.Enabled = True
            txtRucCiClienteGeneral.Enabled = True
            'gbDireccionClienteGeneral.Enabled = True
            txtCiudad.Enabled = True
            txtDireccionUbicacionClienteGeneral.Enabled = True
            txtDireccionFacturacionClienteGeneral.Enabled = True
            txtConsorcioGrupo.Enabled = True
            'gbFechaIngresoClienteGeneral.Enabled = True
            dtpFechaIngresoClienteGeneral.Enabled = True
            'gbInformacionContacto.Enabled = True
            txtContactoClienteGeneral.Enabled = True
            txtEmailClienteGeneral.Enabled = True
            'gbTelefonos.Enabled = True
            txtTelefono1ClienteGeneral.Enabled = True
            txtTelefono2ClienteGeneral.Enabled = True
            'gbIngresoObservaciones.Enabled = True
            TextBoxVal.Enabled = True
            'ComboBox2.Enabled = True
            dtpFechaContrato.Enabled = True
            txtObservaciones.Enabled = True
            'gbNroResolucionContEspecial.Enabled = True
            rbSiContribuyenteEspecial.Enabled = True
            rbNoContribuyenteEspecial.Enabled = True
            'gbOligadoLlevarContabilidad.Enabled = True
            rbSILlevaContabilidad.Enabled = True
            rbNOLlevaContabilidad.Enabled = True
            txtnroResContEspecial.Enabled = True


            'gbTipoClienteGeneral.Enabled = True
            cmbTipoCliente.Enabled = True

            ToolStripMenuItem14.Enabled = False
            ToolStripMenuItem11.Enabled = False
            ToolStripMenuItem16.Enabled = False
            Button2.Enabled = False

            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnAnular.Enabled = False
            btnCancelar.Enabled = True

            btnAdd.Enabled = True
            btnRemove.Enabled = True
        End Sub
        Private Sub HabilitadoModificar()
            'gbDatosClienteGeneral.Enabled = True
            cmbTipoCliente.Enabled = True
            cmbTipoEmpresa.Enabled = True
            cmbTipoIdentificacion.Enabled = True
            txtNombreRazonSocialClienteGeneral.Enabled = True
            txtApellidoNombreComercial.Enabled = True
            txtRucCiClienteGeneral.Enabled = True
            'gbDireccionClienteGeneral.Enabled = True
            txtCiudad.Enabled = True
            txtDireccionUbicacionClienteGeneral.Enabled = True
            txtDireccionFacturacionClienteGeneral.Enabled = True
            txtConsorcioGrupo.Enabled = True
            'gbFechaIngresoClienteGeneral.Enabled = True
            dtpFechaIngresoClienteGeneral.Enabled = True
            'gbInformacionContacto.Enabled = True
            txtContactoClienteGeneral.Enabled = True
            txtEmailClienteGeneral.Enabled = True
            'gbTelefonos.Enabled = True
            txtTelefono1ClienteGeneral.Enabled = True
            txtTelefono2ClienteGeneral.Enabled = True
            'gbIngresoObservaciones.Enabled = True
            TextBoxVal.Enabled = True
            'ComboBox2.Enabled = True
            dtpFechaContrato.Enabled = True
            txtObservaciones.Enabled = True
            'gbNroResolucionContEspecial.Enabled = True
            rbSiContribuyenteEspecial.Enabled = True
            rbNoContribuyenteEspecial.Enabled = True
            'gbOligadoLlevarContabilidad.Enabled = True
            rbSILlevaContabilidad.Enabled = True
            rbNOLlevaContabilidad.Enabled = True
            txtnroResContEspecial.Enabled = True
            'gbOligadoLlevarContabilidad.Enabled = True

            'gbTipoClienteGeneral.Enabled = True
            cmbTipoCliente.Enabled = True

            ToolStripMenuItem14.Enabled = False
            ToolStripMenuItem11.Enabled = False
            ToolStripMenuItem16.Enabled = False
            Button2.Enabled = False

            btnNuevo.Enabled = False
            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnAnular.Enabled = False
            btnCancelar.Enabled = True

            btnAdd.Enabled = True
            btnRemove.Enabled = True
        End Sub
        Private Sub LimpiarParametros()
            Label44.Text = "..."
            Label47.Text = "..."
            TextBox12.Clear()
            TextBox13.Clear()

            txtRucCiClienteGeneral.Text = ""
            txtNombreRazonSocialClienteGeneral.Text = ""
            txtApellidoNombreComercial.Text = ""
            txtnroResContEspecial.Text = ""

            rbSiContribuyenteEspecial.Checked = False
            rbNoContribuyenteEspecial.Checked = False
            rbSILlevaContabilidad.Checked = False
            rbNOLlevaContabilidad.Checked = False
            txtDireccionUbicacionClienteGeneral.Text = ""
            txtDireccionFacturacionClienteGeneral.Text = "SIN DIRECCIÓN"
            txtConsorcioGrupo.Text = "SIN GRUPO"
            txtCiudad.Text = ""
            txtTelefono1ClienteGeneral.Text = "0"
            txtTelefono2ClienteGeneral.Text = "0"
            txtEmailClienteGeneral.Text = "SIN CORREO"
            txtContactoClienteGeneral.Text = "SIN CONTÁCTO"
            txtObservaciones.Text = "..."

            TextBoxVal.Text = "0.00"
            TextBoxVal.Tag = Nothing
            Label23.Text = "..."
            ComboBox1.Text = ""
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        End Sub
        Private Sub txtCiudad_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtCiudad.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            lblIdCiudad.Text = _objCiudad.BuscarIdCiudadPorNombreCiudad(_tipoCon, txtCiudad.Text)
        End Sub
        Private Sub txtRucCiClienteGeneral_Validated(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtRucCiClienteGeneral.Validated
            If _botonSeleccionado = 1 Then
                Dim c = _objetoClienteGeneral.BuscarRazonSocialClienteGeneralXRuc(_tipoCon, txtRucCiClienteGeneral.Text)
                If c <> "0" Then
                    'MsgBox("ESTE RUC YA SE ENCUANTRA REGISTRADO CON EL CLIENTE:" & vbNewLine & c, MsgBoxStyle.Exclamation, "Mensaje de validación")
                    KryptonMessageBox.Show("Este ruc ya se encuentra registrado con el cliente:" & vbNewLine & c, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    txtRucCiClienteGeneral.Focus()
                End If
            End If
        End Sub
        Private Sub txtnroResContEspecial_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtnroResContEspecial.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtRucCiClienteGeneral_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtRucCiClienteGeneral.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtTelefono1ClienteGeneral_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtTelefono1ClienteGeneral.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtTelefono2ClienteGeneral_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtTelefono2ClienteGeneral.KeyPress
            e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub
        Private Sub txtBuscarCliente_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtBuscarCliente.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            CargarClienteGeneral()
        End Sub
        Private Sub CargarClienteGeneral()
            Try
                dgvClienteGeneral.DataSource = _objetoClienteGeneral.BuscarFiltradoPorRazonSocialClienteGeneral(_tipoCon, txtBuscarCliente.Text)
                dgvClienteGeneral.AutoResizeRows()
                dgvClienteGeneral.Columns(0).HeaderText = "Id"
                dgvClienteGeneral.Columns(0).Width = 50
                dgvClienteGeneral.Columns(1).HeaderText = "Cod."
                dgvClienteGeneral.Columns(1).Visible = False
                dgvClienteGeneral.Columns(2).HeaderText = "Ident."
                dgvClienteGeneral.Columns(2).Width = 50
                dgvClienteGeneral.Columns(3).HeaderText = "RUC / CI"
                dgvClienteGeneral.Columns(3).Width = 90
                dgvClienteGeneral.Columns(4).HeaderText = "Nombre / Razón Social"
                dgvClienteGeneral.Columns(4).Width = 200
                dgvClienteGeneral.Columns(5).HeaderText = "Apellido / Nombre comercial"
                dgvClienteGeneral.Columns(5).Width = 200
                dgvClienteGeneral.Columns(6).HeaderText = "NRO cont especial"
                dgvClienteGeneral.Columns(6).Width = 70
                dgvClienteGeneral.Columns(7).HeaderText = "Oblig CONT"
                dgvClienteGeneral.Columns(7).Width = 60
                dgvClienteGeneral.Columns(8).HeaderText = "Dirección ubicación"
                dgvClienteGeneral.Columns(8).Width = 200
                dgvClienteGeneral.Columns(9).HeaderText = "Dirección facturación"
                dgvClienteGeneral.Columns(9).Width = 200
                dgvClienteGeneral.Columns(10).HeaderText = "consorcio/ grupo"
                dgvClienteGeneral.Columns(10).Width = 120
                dgvClienteGeneral.Columns(11).HeaderText = "ciudad"
                dgvClienteGeneral.Columns(11).Width = 60
                dgvClienteGeneral.Columns(12).HeaderText = "telefono 1"
                dgvClienteGeneral.Columns(12).Width = 80
                dgvClienteGeneral.Columns(13).HeaderText = "telefono 2"
                dgvClienteGeneral.Columns(13).Width = 80
                dgvClienteGeneral.Columns(14).HeaderText = "E-mail"
                dgvClienteGeneral.Columns(14).Width = 150
                dgvClienteGeneral.Columns(15).HeaderText = "Contácto"
                dgvClienteGeneral.Columns(15).Width = 200
                dgvClienteGeneral.Columns(16).HeaderText = "Fecha Ingreso"
                dgvClienteGeneral.Columns(16).Width = 80
                dgvClienteGeneral.Columns(17).HeaderText = "Tipo Cliente"
                dgvClienteGeneral.Columns(17).Width = 100
                dgvClienteGeneral.Columns(18).HeaderText = "Observaciones"
                dgvClienteGeneral.Columns(18).Width = 200
                dgvClienteGeneral.Columns(19).HeaderText = "EST"
                dgvClienteGeneral.Columns(19).Visible = False
                dgvClienteGeneral.Columns(20).HeaderText = "Tipo Empresa"
                dgvClienteGeneral.Columns(20).Width = 80
                dgvClienteGeneral.Columns(21).Visible = False
                dgvClienteGeneral.Columns(22).HeaderText = "Fecha Contrato"
                dgvClienteGeneral.Columns(22).Width = 80
                dgvClienteGeneral.Columns(23).HeaderText = "Valor"
                dgvClienteGeneral.Columns(23).Width = 80

                dgvClienteGeneral.ReadOnly = True
                dgvClienteGeneral.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                KryptonMessageBox.Show("Error: " & ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                dgvClienteGeneral.DataSource = Nothing
            End Try
        End Sub
        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificar.Click
            HabilitadoModificar()
            _botonSeleccionado = 2
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            'ComboBox2.SelectedIndex = 0

            LimpiarParametros()
            DeshabilitadoInicio()

            AutocompletarConsorcioCliente()
            DataGridView1.Rows.Clear()

            txtBuscarCliente.Focus()
            _botonSeleccionado = 0
        End Sub
        Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem2.Click
            CargarSitiosClienteGeneral()
        End Sub
        Private Sub dgvClienteGeneral_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvSitios.CellDoubleClick
            If dgvClienteGeneral.RowCount = 0 Then Return
            'TabControl1.SelectedIndex = 1
            KryptonNavigator1.SelectedPage = KryptonPage2
        End Sub
        Private Sub dgvSitios_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvSitios.SelectionChanged
            If botonSeleccionadoSitio <> 0 Or dgvSitios.CurrentRow Is Nothing Then
                Return
            End If

            Label28.Text = dgvSitios.CurrentRow.Cells(0).Value
            cbmProvincia.SelectedValue = dgvSitios.CurrentRow.Cells(2).Value
            cbmCanton.SelectedValue = dgvSitios.CurrentRow.Cells(4).Value
            cbmParroquia.SelectedValue = dgvSitios.CurrentRow.Cells(6).Value
            txtNombreSitio.Text = dgvSitios.CurrentRow.Cells(1).Value
            cbmTipo.SelectedItem = dgvSitios.CurrentRow.Cells(10).Value

            txtDireccion.Text = dgvSitios.CurrentRow.Cells(8).Value
            txtReferencia.Text = dgvSitios.CurrentRow.Cells(9).Value
            cbxSupervisor.SelectedValue = dgvSitios.CurrentRow.Cells(11).Value
        End Sub
        Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAdd.Click
            If txtRucCiClienteGeneral.Text.Trim.Length = 0 Then Return
            Try
                Dim frm As New FrmCrearConvenioBanco
                frm.Cero()
                If frm.ShowDialog = vbOK Then
                    If frm.txtCedRucTitular.Text.Trim.Length > 0 And frm.txtTitular.Text.Trim.Length > 0 And frm.txtNumCtaTarj.Text.Trim.Length > 0 Then
                        Dim v As Double
                        If Double.TryParse(frm.txtValor.Text.Trim, v) And v > 0 Then
                            DataGridView1.Rows.Add(frm.IdConvenio,
                                                   lblIdClienteGeneral.Text.Trim,
                                                   frm.cbxBanco.Text.Trim,
                                                   frm.cbxTipoCuenta.Text.Trim,
                                                   frm.cbxTipoDoc.Text.Trim,
                                                   frm.txtNumCtaTarj.Text.Trim,
                                                   frm.txtCedRucTitular.Text.Trim,
                                                   frm.txtTitular.Text.Trim,
                                                   v.ToString("N"),
                                                   frm.TextBox1.Text.Trim)
                        Else
                            KryptonMessageBox.Show("Debe agregar el valor a debitar, correspondiente al convenio!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        End If
                    Else
                        KryptonMessageBox.Show("Debe agregar todos los datos del convenio!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If
                End If
            Catch ex As Exception
                KryptonMessageBox.Show("Ocurrio un problema al agregar convenio: " & ex.Message, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try
        End Sub
        Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
            If _botonSeleccionado = 0 Then Return
            If DataGridView1.RowCount = 0 Then Return
            If DataGridView1.CurrentRow Is Nothing Then Return
            Try
                Dim frm As New FrmCrearConvenioBanco
                frm.IdConvenio = CInt(DataGridView1.CurrentRow.Cells(0).Value)
                frm.cbxBanco.Text = (DataGridView1.CurrentRow.Cells(2).Value & "").ToString.Trim
                frm.cbxTipoCuenta.Text = (DataGridView1.CurrentRow.Cells(3).Value & "").ToString.Trim
                frm.cbxTipoDoc.Text = (DataGridView1.CurrentRow.Cells(4).Value & "").ToString.Trim
                frm.txtNumCtaTarj.Text = (DataGridView1.CurrentRow.Cells(5).Value & "").ToString.Trim
                frm.txtCedRucTitular.Text = (DataGridView1.CurrentRow.Cells(6).Value & "").ToString.Trim
                frm.txtTitular.Text = (DataGridView1.CurrentRow.Cells(7).Value & "").ToString.Trim
                frm.txtValor.Text = (DataGridView1.CurrentRow.Cells(8).Value & "").ToString.Trim
                frm.TextBox1.Text = (DataGridView1.CurrentRow.Cells(9).Value & "").ToString.Trim

                If frm.ShowDialog = vbOK Then
                    If frm.txtCedRucTitular.Text.Trim.Length > 0 And frm.txtTitular.Text.Trim.Length > 0 And frm.txtNumCtaTarj.Text.Trim.Length > 0 Then
                        Dim v As Double
                        If Double.TryParse(frm.txtValor.Text.Trim, v) And v > 0 Then
                            DataGridView1.CurrentRow.Cells(2).Value = frm.cbxBanco.Text.Trim
                            DataGridView1.CurrentRow.Cells(3).Value = frm.cbxTipoCuenta.Text.Trim
                            DataGridView1.CurrentRow.Cells(4).Value = frm.cbxTipoDoc.Text.Trim
                            DataGridView1.CurrentRow.Cells(5).Value = frm.txtNumCtaTarj.Text.Trim
                            DataGridView1.CurrentRow.Cells(6).Value = frm.txtCedRucTitular.Text.Trim
                            DataGridView1.CurrentRow.Cells(7).Value = frm.txtTitular.Text.Trim
                            DataGridView1.CurrentRow.Cells(8).Value = v.ToString("N")
                            DataGridView1.CurrentRow.Cells(9).Value = frm.TextBox1.Text.Trim
                        Else
                            KryptonMessageBox.Show("Debe agregar el valor a debitar, correspondiente al convenio!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        End If
                    Else
                        KryptonMessageBox.Show("Debe agregar todos los datos del convenio!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If
                End If
            Catch ex As Exception
                KryptonMessageBox.Show("Ocurrio un problema al modificar convenio: " & ex.Message, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try
        End Sub
        Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnRemove.Click
            If DataGridView1.RowCount = 0 Then Return
            If KryptonMessageBox.Show("Seguro que desea quitar este convenio", "Mensaje del sistema", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Try
                If _botonSeleccionado = 2 Then _objetoConvenioCliente.QuitarRegistroConvenioClienteGeneral(_tipoCon, CInt(DataGridView1.CurrentRow.Cells(0).Value))
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            Catch ex As Exception
                KryptonMessageBox.Show("Ocurrio un problema al quitar convenio: " & ex.Message, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try
        End Sub
        Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem3.Click
            ExportarDatosExcel(dgvClienteGeneral, "LISTA GENERAL CLIENTES")
        End Sub
        Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem4.Click
            ExportarDatosExcel(dgvSitios, "REPORTE DE SITIOS DE TRABAJO ")
        End Sub
        Private Sub rbNoContribuyenteEspecial_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbNoContribuyenteEspecial.CheckedChanged
            txtnroResContEspecial.Text = "0"
        End Sub
        Private Sub rbSiContribuyenteEspecial_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbSiContribuyenteEspecial.CheckedChanged
            txtnroResContEspecial.Clear()
        End Sub
        Private Sub ExportarDatosExcel(ByVal dgvAsientosDiario As DataGridView, ByVal titulo As String)
            Try
                If dgvAsientosDiario.Rows.Count = 0 Then

                    KryptonMessageBox.Show("No hay datos que exportar!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    Return
                End If



                'Dim fec = ValidationForms.FechaActual(_tipoCon)

                'Dim app = New Excel.Application()
                'Dim workbook = app.Workbooks.Add(Type.Missing)
                'Dim worksheet = workbook.Worksheets(1)
                'worksheet.Name = "CLIENTES"

                'Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                'worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Font.Size = 10

                'worksheet.Range("A1:" & ic & "1").Merge()
                'worksheet.Range("A1:" & ic & "1").Value = ValidationForms.NombreCompany(_tipoCon) & "  -  " & titulo
                'worksheet.Range("A1:" & ic & "1").Font.Bold = True
                'worksheet.Range("A1:" & ic & "1").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                'worksheet.Range("A1:" & ic & "1").Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                'worksheet.Range("A1:" & ic & "1").Font.Color = Color.White
                'worksheet.Range("A1:" & ic & "1").Font.Size = 12
                ''Copete  
                'worksheet.Range("A2:" & ic & "2").Merge()
                'worksheet.Range("A2:" & ic & "2").Value = "PERÍODO: TODOS LOS CLIENTES"
                'worksheet.Range("A2:" & ic & "2").Font.Size = 12
                ''Fecha  
                'worksheet.Range("A3:" & ic & "3").Merge()
                'worksheet.Range("A3:" & ic & "3").Value = "Fecha de Reporte: " & fec.ToLongDateString() & " " & fec.ToLongTimeString()
                'worksheet.Range("A3:" & ic & "3").Font.Size = 12

                ''Aca se ingresa las columnas
                'Dim indc = 1
                'Dim headin = 5
                'For i = 0 To dgvAsientosDiario.Columns.Count - 1
                '    If Not dgvAsientosDiario.Columns(i).Visible Then Continue For
                '    worksheet.Cells(headin, indc) = dgvAsientosDiario.Columns(i).HeaderText
                '    worksheet.Cells(headin, indc).Font.Bold = True
                '    worksheet.Cells(headin, indc).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                '    worksheet.Cells(headin, indc).Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                '    worksheet.Cells(headin, indc).Interior.Color = ValidationForms.GetColorSistema(_tipoCon)
                '    worksheet.Cells(headin, indc).Font.Color = Color.White
                '    indc += 1
                'Next

                ''Aca se ingresa el detalle recorrera la tabla celda por celda
                'For i = 0 To dgvAsientosDiario.Rows.Count - 1
                '    indc = 1
                '    For j = 0 To dgvAsientosDiario.Columns.Count - 1

                '        If Not dgvAsientosDiario.Columns(j).Visible Then Continue For

                '        ' asigna valor a celda
                '        worksheet.Cells(i + 1 + headin, indc) = dgvAsientosDiario.Rows(i).Cells(j).Value

                '        ' definir bordes
                '        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
                '        worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
                '        If i = dgvAsientosDiario.RowCount - 1 Then worksheet.Cells(i + 1 + headin, indc).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
                '        indc += 1
                '    Next
                'Next

                'worksheet.Range("A1:" & ic & (dgvAsientosDiario.RowCount + 50)).Columns.AutoFit()

                'app.DisplayAlerts = False
                'app.Visible = True
                'app.DisplayAlerts = True
                'workbook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
                saveFileDialog.Title = "Guardar archivo Excel"
                saveFileDialog.FileName = $"{titulo}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"


                If saveFileDialog.ShowDialog() <> DialogResult.OK Then
                    Exit Sub
                End If



                Dim fec = ValidationForms.FechaActual(_tipoCon)
                Dim tituloReporte = ValidationForms.NombreCompany(_tipoCon) & " - " & titulo

                ' Crear workbook y worksheet
                Dim workbook As New XLWorkbook()
                Dim worksheet = workbook.Worksheets.Add("Lista_Clientes")
                Dim colorSistema As System.Drawing.Color = ValidationForms.GetColorSistema(_tipoCon)
                Dim xlColor As XLColor = XLColor.FromColor(colorSistema)

                ' Definir rango para el título
                Dim ic = ValidationForms.NumToCharExcelFromVisibleColumnsDataGrid(dgvAsientosDiario)
                worksheet.Range("A1:" & ic & "1").Merge()
                worksheet.Cell(1, 1).Value = tituloReporte.ToString()
                worksheet.Cell(1, 1).Style.Font.SetBold(True)
                worksheet.Cell(1, 1).Style.Font.SetFontSize(12)
                worksheet.Cell(1, 1).Style.Font.SetFontColor(XLColor.White)
                worksheet.Cell(1, 1).Style.Fill.SetBackgroundColor(xlColor)
                worksheet.Cell(1, 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)

                ' Copete
                worksheet.Range("A2:" & ic & "2").Merge()
                'worksheet.Cell(2, 1).Value = $"{cmbBancos.Text} CTA: {cmbCuentaBancos.Text}, PERÍODO: {dtpDesde.Value.ToLongDateString()} AL {dtpHasta.Value.ToLongDateString()}"
                worksheet.Cell(2, 1).Value = $"PERÍODO: AL {fec.ToLongDateString()}"
                worksheet.Cell(2, 1).Style.Font.SetFontSize(12)

                ' Fecha
                worksheet.Range("A3:" & ic & "3").Merge()
                worksheet.Cell(3, 1).Value = $"Fecha de Reporte: {fec.ToLongDateString()} {fec.ToLongTimeString()}"
                worksheet.Cell(3, 1).Style.Font.SetFontSize(12)

                ' Encabezados de columnas
                Dim indc = 1
                Dim headin = 5
                For i = 0 To dgvAsientosDiario.Columns.Count - 1
                    If Not dgvAsientosDiario.Columns(i).Visible Then Continue For
                    worksheet.Cell(headin, indc).Value = dgvAsientosDiario.Columns(i).HeaderText
                    worksheet.Cell(headin, indc).Style.Font.SetBold(True)
                    worksheet.Cell(headin, indc).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                    worksheet.Cell(headin, indc).Style.Fill.SetBackgroundColor(xlColor)
                    worksheet.Cell(headin, indc).Style.Font.SetFontColor(XLColor.White)
                    worksheet.Cell(headin, indc).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                    indc += 1
                Next

                ' Detalle de datos
                For i = 0 To dgvAsientosDiario.Rows.Count - 1
                    indc = 1
                    For j = 0 To dgvAsientosDiario.Columns.Count - 1
                        If Not dgvAsientosDiario.Columns(j).Visible Then Continue For

                        ' Obtener el valor de la celda
                        Dim cellValue = dgvAsientosDiario.Rows(i).Cells(j).Value

                        ' Validar si el valor de la celda no es Nothing
                        If cellValue IsNot Nothing Then
                            worksheet.Cell(i + 1 + headin, indc).Value = cellValue.ToString()
                        Else
                            worksheet.Cell(i + 1 + headin, indc).Value = String.Empty ' Valor predeterminado si la celda es Nothing
                        End If

                        ' Establecer bordes
                        Dim cell = worksheet.Cell(i + 1 + headin, indc)
                        cell.Style.Border.SetLeftBorder(XLBorderStyleValues.Thin)
                        cell.Style.Border.SetRightBorder(XLBorderStyleValues.Thin)

                        If i = dgvAsientosDiario.RowCount - 1 Then
                            cell.Style.Border.SetBottomBorder(XLBorderStyleValues.Thin)
                        End If

                        indc += 1
                    Next
                Next

                ' Ajustar columnas automáticamente
                worksheet.Columns("A:" & ic).AdjustToContents()

                ' Guardar el archivo en una ubicación temporal y abrirlo
                Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), saveFileDialog.FileName)
                ' Guardar el archivo en una ubicación temporal
                workbook.SaveAs(saveFileDialog.FileName)

                ' Abrir el archivo Excel automáticamente
                Process.Start(tempFilePath)

                KryptonMessageBox.Show("Datos exportados correctamente", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)


            Catch ex As Exception
                KryptonMessageBox.Show("Hubo un problema al exportar datos!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub
        Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAnular.Click
            If lblIdClienteGeneral.Text <> "..." Then

                'If MessageBox.Show("¿ESTA SEGURA QUE DESEA ANULAR?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                If KryptonMessageBox.Show("¿ESTA SEGURA QUE DESEA ANULAR?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                _sqlCommands.Clear()

                ActualizarEstadoClienteGeneral()


                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    DeshabilitadoInicio()
                    LimpiarParametros()

                    CargarClienteGeneral()
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If
                'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")

            Else
                'MsgBox("PARA ANULAR, PRIMERO SELECCIONE UN CLIENTE.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("Para anular, primero seleccione un cliente.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Sub ActualizarEstadoClienteGeneral()
            With _objetoClienteGeneral
                .IdCliente = lblIdClienteGeneral.Text
                .EstadoCliente = 0
            End With
            _sqlCommands.Add(_objetoClienteGeneral.ActualizarEstadoClienteGeneral)
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If ValidarParametros() Then

                'If MessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR LOS CAMBIOS?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
                If KryptonMessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR LOS CAMBIOS?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
                txtBuscarCliente.Text = txtApellidoNombreComercial.Text.Trim
                _sqlCommands.Clear()

                If _botonSeleccionado = 1 Then
                    GuardarClienteGeneral()
                Else
                    ModificarClienteGeneral()
                End If

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    AutocompletarConsorcioCliente()
                    _botonSeleccionado = 0

                    DeshabilitadoInicio()
                    CargarClienteGeneral()

                    txtBuscarCliente.Focus()
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                Else
                    KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                    Return
                End If

            Else
                'MsgBox("No se puede guardar." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If

        End Sub
        Private Function ValidarParametros() As Boolean
            Return txtRucCiClienteGeneral.Text <> "" And txtNombreRazonSocialClienteGeneral.Text <> "" And txtApellidoNombreComercial.Text <> "" _
               And txtnroResContEspecial.Text <> "" And txtDireccionUbicacionClienteGeneral.Text <> "" And txtDireccionFacturacionClienteGeneral.Text <> "" _
               And txtConsorcioGrupo.Text <> "" And txtCiudad.Text <> "" And txtTelefono1ClienteGeneral.Text <> "" And txtTelefono2ClienteGeneral.Text <> "" _
               And txtEmailClienteGeneral.Text <> "" And txtContactoClienteGeneral.Text <> "" And txtObservaciones.Text <> "" And cmbTipoIdentificacion.Text <> "" _
               And cmbTipoCliente.Text <> "" And cmbTipoEmpresa.Text <> ""
        End Function
        Private Sub GuardarClienteGeneral()
            With _objetoClienteGeneral
                .IdCliente = _objetoClienteGeneral.BuscarMayorIdClienteGeneral(_tipoCon) + 1
                .CodigoCliente = "0"
                .TipoIdentificacionCliente = cmbTipoIdentificacion.Text
                .RucCiCliente = txtRucCiClienteGeneral.Text
                .NombreRazonSocialCliente = txtNombreRazonSocialClienteGeneral.Text
                .ApellidoNombreComercialCliente = txtApellidoNombreComercial.Text
                If rbSiContribuyenteEspecial.Checked = True Then
                    .NroResContEspecialCliente = "SI"
                ElseIf rbNoContribuyenteEspecial.Checked = True Then
                    .NroResContEspecialCliente = "NO"
                End If
                If rbSILlevaContabilidad.Checked = True Then
                    .ObligLlevarContCliente = "SI"
                ElseIf rbNOLlevaContabilidad.Checked = True Then
                    .ObligLlevarContCliente = "NO"
                End If
                .DireccionUbicacionCliente = txtDireccionUbicacionClienteGeneral.Text
                .DireccionFacturacionCliente = txtDireccionFacturacionClienteGeneral.Text
                .ConsorcioCliente = txtConsorcioGrupo.Text
                .IdCiudadCliente = lblIdCiudad.Text
                .Telefono1Cliente = txtTelefono1ClienteGeneral.Text
                .Telefono2Cliente = txtTelefono2ClienteGeneral.Text
                .EmailCliente = txtEmailClienteGeneral.Text
                .ContactoCliente = txtContactoClienteGeneral.Text
                .FechaIngresoCliente = dtpFechaIngresoClienteGeneral.Value
                .TipoCliente = cmbTipoCliente.Text
                .ObservacionesCliente = txtObservaciones.Text
                .EstadoCliente = 1
                .TipoEmpresa = cmbTipoEmpresa.Text
            End With
            _sqlCommands.Add(_objetoClienteGeneral.NuevoRegistroClienteGeneral)

            With _objetoContratoCliente
                .IdContrato = CInt(.BuscarMayorIdContrato(_tipoCon)) + 1
                .IdClienteGeneral = _objetoClienteGeneral.IdCliente
                .Valor = If(TextBoxVal.Text.Trim().Length = 0, 0, CDec(TextBoxVal.Text.Trim()))
                .Fecha = dtpFechaContrato.Value 'ValidationForms.FechaActual(_tipoCon)
                .Anio = CInt(dtpFechaContrato.Value.Year) 'dtpFechaContrato.Value.Year
                .Estado = 1
            End With
            _sqlCommands.Add(_objetoContratoCliente.NuevoRegistroContratoClienteGeneral)

            For Each row As DataGridViewRow In DataGridView1.Rows
                With _objetoConvenioCliente
                    .IdConvenio = CInt(row.Cells(0).Value)
                    .IdClienteGeneral = CInt(row.Cells(1).Value)
                    .Banco = (row.Cells(2).Value & "").ToString.Trim
                    .TipoCenta = (row.Cells(3).Value & "").ToString.Trim
                    .TipoDoc = (row.Cells(4).Value & "").ToString.Trim
                    .NumCtaTrj = (row.Cells(5).Value & "").ToString.Trim
                    .CedRuc = (row.Cells(6).Value & "").ToString.Trim
                    .Titular = (row.Cells(7).Value & "").ToString.Trim
                    .Valor = CDbl(row.Cells(8).Value)
                    .Observacion = (row.Cells(9).Value & "").ToString.Trim
                End With
                If CInt(row.Cells(0).Value) = 0 Then
                    _objetoConvenioCliente.IdConvenio = _objetoConvenioCliente.BuscarMayorIdConvenio(_tipoCon)
                    _sqlCommands.Add(_objetoConvenioCliente.NuevoRegistroConvenioClienteGeneral)
                Else
                    _sqlCommands.Add(_objetoConvenioCliente.ActualizarRegistroConvenioClienteGeneral)
                End If
            Next

            _objetoAuditoria.AccionAuditoria = "CREO UN NUEVO CLIENTE GENERAL. ID: " + lblIdClienteGeneral.Text + " RUC: " + txtRucCiClienteGeneral.Text + " RAZÓN SOCIAL: " + txtNombreRazonSocialClienteGeneral.Text + " TIPO: " + cmbTipoCliente.Text
            _objetoAuditoria.FormularioAuditoria = Text.ToUpper
            Auditoria()
        End Sub
        Private Sub Auditoria()
            With _objetoAuditoria
                .IdAuditoria = CLng(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                .IdUsuarioAuditoria = IdUsuario
                .EstadoAuditoria = 1
                .FechaAuditoria = _objetoAuditoria.FechaExactaAuditoria(_tipoCon)
            End With
            _sqlCommands.Add(_objetoAuditoria.NuevaAuditoria)
        End Sub
        Private Sub ModificarClienteGeneral()
            With _objetoClienteGeneral
                .IdCliente = lblIdClienteGeneral.Text
                .CodigoCliente = "0"
                .TipoIdentificacionCliente = cmbTipoIdentificacion.Text
                .RucCiCliente = txtRucCiClienteGeneral.Text
                .NombreRazonSocialCliente = txtNombreRazonSocialClienteGeneral.Text
                .ApellidoNombreComercialCliente = txtApellidoNombreComercial.Text
                If rbSiContribuyenteEspecial.Checked = True Then
                    .NroResContEspecialCliente = "SI"
                ElseIf rbNoContribuyenteEspecial.Checked = True Then
                    .NroResContEspecialCliente = "NO"
                End If
                If rbSILlevaContabilidad.Checked = True Then
                    .ObligLlevarContCliente = "SI"
                ElseIf rbNOLlevaContabilidad.Checked = True Then
                    .ObligLlevarContCliente = "NO"
                End If
                .DireccionUbicacionCliente = txtDireccionUbicacionClienteGeneral.Text
                .DireccionFacturacionCliente = txtDireccionFacturacionClienteGeneral.Text
                .ConsorcioCliente = txtConsorcioGrupo.Text
                .IdCiudadCliente = lblIdCiudad.Text
                .Telefono1Cliente = txtTelefono1ClienteGeneral.Text
                .Telefono2Cliente = txtTelefono2ClienteGeneral.Text
                .EmailCliente = txtEmailClienteGeneral.Text
                .ContactoCliente = txtContactoClienteGeneral.Text
                .FechaIngresoCliente = dtpFechaIngresoClienteGeneral.Value
                .TipoCliente = cmbTipoCliente.Text
                .ObservacionesCliente = txtObservaciones.Text
                .EstadoCliente = 1
                .TipoEmpresa = cmbTipoEmpresa.Text
            End With
            _sqlCommands.Add(_objetoClienteGeneral.ModificarRegistroClienteGeneral)

            With _objetoContratoCliente
                .IdClienteGeneral = _objetoClienteGeneral.IdCliente
                .Valor = If(TextBoxVal.Text.Trim().Length = 0, 0, CDec(TextBoxVal.Text.Trim()))
                .Fecha = dtpFechaContrato.Value 'ValidationForms.FechaActual(_tipoCon)
                .Anio = CInt(dtpFechaContrato.Value.Year)    'CInt(dtpFechaContrato.Value.Year)
                .Estado = 1
            End With
            If (TextBoxVal.Tag & "").ToString().Trim().Length = 0 Then
                _objetoContratoCliente.IdContrato = CInt(_objetoContratoCliente.BuscarMayorIdContrato(_tipoCon)) + 1
                _sqlCommands.Add(_objetoContratoCliente.NuevoRegistroContratoClienteGeneral)
            Else
                _objetoContratoCliente.IdContrato = CInt(TextBoxVal.Tag)
                _sqlCommands.Add(_objetoContratoCliente.ModificarRegistroContratoClienteGeneral())
            End If



            For Each row As DataGridViewRow In DataGridView1.Rows
                With _objetoConvenioCliente
                    .IdConvenio = CInt(row.Cells(0).Value)
                    .IdClienteGeneral = CInt(row.Cells(1).Value)
                    .Banco = (row.Cells(2).Value & "").ToString.Trim
                    .TipoCenta = (row.Cells(3).Value & "").ToString.Trim
                    .TipoDoc = (row.Cells(4).Value & "").ToString.Trim
                    .NumCtaTrj = (row.Cells(5).Value & "").ToString.Trim
                    .CedRuc = (row.Cells(6).Value & "").ToString.Trim
                    .Titular = (row.Cells(7).Value & "").ToString.Trim
                    .Valor = CDbl(row.Cells(8).Value)
                    .Observacion = (row.Cells(9).Value & "").ToString.Trim
                End With
                If CInt(row.Cells(0).Value) = 0 Then
                    _objetoConvenioCliente.IdConvenio = _objetoConvenioCliente.BuscarMayorIdConvenio(_tipoCon)
                    _sqlCommands.Add(_objetoConvenioCliente.NuevoRegistroConvenioClienteGeneral)
                Else
                    _sqlCommands.Add(_objetoConvenioCliente.ActualizarRegistroConvenioClienteGeneral)
                End If
            Next
        End Sub
        'Private Sub GenerarAnios()
        '    Dim c = _objetoContratoCliente.BuscarAniosContratoActivoClienteGeneral(_tipoCon)
        '    Dim f = ValidationForms.FechaActual(_tipoCon)
        '    ComboBox2.Items.Clear()
        '    For Each r As DataRow In c.Rows
        '        ComboBox2.Items.Add(r(0))
        '    Next
        '    If Not ComboBox2.Items.Contains(f.Year) Then ComboBox2.Items.Add(f.Year)
        'End Sub
        Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles TextBoxVal.KeyPress
            e.Handled = Not _validacionesDecimales.EsDecimal(e.KeyChar, TextBoxVal.Text)
        End Sub

        'Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        '    If ComboBox2.Items.Count = 0 Then Return
        '    If dgvClienteGeneral.CurrentRow Is Nothing Then Return
        '    If dgvClienteGeneral.CurrentRow.Cells.Item(20).Value Is DBNull.Value Then Return
        '    Try
        'Dim c = _objetoContratoCliente.BuscarContratoActivoXIdClienteAnio(_tipoCon, dgvClienteGeneral.CurrentRow.Cells.Item(0).Value, ComboBox2.SelectedItem)
        '        ComboBox2.SelectedItem = c.Rows(0)(3)
        '        TextBoxVal.Text = c.Rows(0)(2)
        '        TextBoxVal.Tag = c.Rows(0)(0)
        '    Catch
        '        ComboBox2.SelectedIndex = 0
        '        TextBoxVal.Text = "0.00"
        '        TextBoxVal.Tag = Nothing
        '    End Try
        'End Sub

        Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem5.Click
            Try
                Dim fechaDesde = dtpFechaDesde.Value.Day.ToString & "-" & dtpFechaDesde.Value.Month.ToString & "-" & dtpFechaDesde.Value.Year.ToString & " 00:00:00.001"
                Dim fechaHasta = dtpFechaHasta.Value.Day.ToString & "-" & dtpFechaHasta.Value.Month.ToString & "-" & dtpFechaHasta.Value.Year.ToString & " 23:59:59.000"

                dgvFacturaVenta.DataSource = _objetoFacturaVenta.SeleccionarFacturasVentaXParametros(_tipoCon, lblIdClienteGeneral.Text, fechaDesde, fechaHasta, 1)
                dgvFacturaVenta.AutoResizeColumns()
                dgvFacturaVenta.Columns(0).Width = 50
                dgvFacturaVenta.Columns(1).Width = 70
                dgvFacturaVenta.Columns(2).Width = 120
                dgvFacturaVenta.Columns(2).DefaultCellStyle.Format = "g"
                dgvFacturaVenta.Columns(3).Visible = False
                dgvFacturaVenta.Columns(4).Visible = False
                dgvFacturaVenta.Columns(12).Visible = False
                dgvFacturaVenta.Columns(20).Width = 300
                dgvFacturaVenta.Columns(22).Visible = False
                lblNroRegistros.Text = dgvFacturaVenta.RowCount

                SumarTotalFacturas()
            Catch
                dgvFacturaVenta.DataSource = Nothing
            End Try
        End Sub

        Private Sub SumarTotalFacturas()
            Dim totalACobrar As Decimal = 0
            Dim totalNotaCredito As Decimal = 0
            Dim totalRetencion As Decimal = 0
            Dim totalSubtotal As Decimal = 0
            Dim totalIva As Decimal = 0
            Dim totalFacturacion As Decimal = 0

            For indiceSuma = 0 To dgvFacturaVenta.RowCount - 1
                If dgvFacturaVenta.Rows(indiceSuma).Cells("EST").Value <> 0 Then
                    totalSubtotal += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells("SUBTOTAL").Value)
                    totalIva += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells("IVA").Value)
                    totalFacturacion += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells("TOTAL").Value)
                    totalRetencion += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells(17).Value)
                    totalNotaCredito += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells(18).Value)
                    totalACobrar += CDec(dgvFacturaVenta.Rows(indiceSuma).Cells(19).Value)
                End If
            Next

            txtTotalACobrar.Text = totalACobrar
            txtTotalNotaCredito.Text = totalNotaCredito
            txtTotalRetencion.Text = totalRetencion
            txtTotalSubtotal.Text = totalSubtotal
            txtTotalIVA.Text = totalIva
            txtTotalFacturas.Text = totalFacturacion

            Dim totCont = If(TextBox5.Text.Trim().Length = 0, 0, CDec(TextBox5.Text.Trim))
            TextBox8.Text = totCont - totalACobrar
        End Sub

        Private Sub dgvFacturaVenta_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacturaVenta.CellDoubleClick, dgvClienteGeneral.CellDoubleClick
            Try
                If dgvFacturaVenta.CurrentRow.Cells("EST").Value = 0 Then Return
                Dim formAsientoDiario As New FormBuscarAsientoDiario
                formAsientoDiario.TipoCox = TipoCox
                If Not dgvFacturaVenta.CurrentRow.Cells.Item(0).Value Is DBNull.Value Then
                    formAsientoDiario.NumeroRegsitroBusqueda = _objetoNumeroRegistroAsientoFacturaVenta.BuscarNumeroRegistroAsientoPorIdFactura(_tipoCon, dgvFacturaVenta.CurrentRow.Cells.Item(0).Value)
                    DialogResult = formAsientoDiario.ShowDialog
                End If
            Catch ex As Exception
                'MessageBox.Show("Error al cargar asiento de venta! " & vbNewLine & ex.Message)
                KryptonMessageBox.Show("Error al cargar asiento de venta! " & vbNewLine & ex.Message, "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub TextBox9_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles TextBox9.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            CargarClienteConvenioGeneral()
        End Sub

        Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem7.Click
            TextBox9.Clear()
            CargarClienteConvenioGeneral()
        End Sub

        Private Sub CargarClienteConvenioGeneral()
            Try
                DataGridView2.DataSource = _objetoClienteGeneral.BuscarFiltradoPorConvenioClienteGeneral(_tipoCon, TextBox9.Text)
                DataGridView2.AutoResizeRows()
                DataGridView2.Columns(0).Width = 40
                DataGridView2.Columns(1).Width = 40
                DataGridView2.Columns(2).Width = 130
                DataGridView2.Columns(3).Width = 200
                DataGridView2.Columns(4).Width = 200
                DataGridView2.Columns(5).Width = 130
                DataGridView2.Columns(6).Width = 130
                DataGridView2.Columns(7).Width = 130
                DataGridView2.Columns(8).Width = 200
                DataGridView2.Columns(9).Width = 90

                DataGridView2.ReadOnly = True
                DataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
                DataGridView2.DataSource = Nothing
            End Try
        End Sub

        Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItem13.Click
            ExportarDatosExcel(DataGridView2, "LISTA CLIENTES CONVENIOS")
        End Sub

        Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
            If lblIdClienteGeneral.Text = "..." Then Return
            If dgvClienteGeneral.Rows.Count = 0 Then Return

            Dim fechaDesde = DateTimePicker7.Value.Day.ToString & "-" & DateTimePicker7.Value.Month.ToString & "-" & DateTimePicker7.Value.Year.ToString & " 00:00:00"
            Dim fechaHasta = DateTimePicker6.Value.Day.ToString & "-" & DateTimePicker6.Value.Month.ToString & "-" & DateTimePicker6.Value.Year.ToString & " 23:59:59"

            Dim grupos = _objetoSitio.SeleccionarRegistroGrupoAsistenciaDetallesByPuestoDiasCliente(_tipoCon, CInt(lblIdClienteGeneral.Text), fechaDesde, fechaHasta, TextBox10.Text)
            Dim datos = _objetoSitio.SeleccionarRegistroDetalleAsistenciaDetallesByPuestoDiasCliente(_tipoCon, CInt(lblIdClienteGeneral.Text), fechaDesde, fechaHasta, TextBox10.Text)

            ListView3.Items.Clear()
            ListView3.Groups.Clear()

            ' grupos
            For Each group In From row As DataRow In grupos.Rows Select New ListViewGroup(row.Item(1).ToString.Trim)
                ListView3.Groups.Add(group)
            Next

            ' detalles
            For Each row As DataRow In datos.Rows
                Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup(row.Item(0).ToString.Trim, ListView3))
                lst.UseItemStyleForSubItems = False

                For i = 1 To datos.Columns.Count - 1
                    If i = 1 Then
                        lst.SubItems.Add(row.Item(i).ToString.Split(" ")(0).Trim)
                    Else
                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                    End If
                Next

                If row.Item(5).ToString.Equals("ASISTENCIA") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 34, 139, 34)
                If row.Item(5).ToString.Equals("LIBRE") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 135, 206, 250)
                If row.Item(5).ToString.Equals("INASISTENCIA") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 240, 128, 128)
                If row.Item(5).ToString.Equals("DOBLADA") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 240, 128, 128)
                If row.Item(5).ToString.Equals("VACACIONES") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 135, 206, 235)
                If row.Item(5).ToString.Equals("PERMISO MÉDICO") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 255, 218, 155)
                If row.Item(5).ToString.Equals("CALAMIDAD DOMÉSTICA") Then lst.SubItems(5).BackColor = Color.FromArgb(255, 255, 218, 155)
                lst.SubItems(5).ForeColor = Color.White

                ListView3.Items.Add(lst)
            Next
        End Sub

        Private Function GetListViewGroup(ByVal namer As String, ByVal list As ListView) As ListViewGroup
            Dim grup As ListViewGroup = Nothing
            For Each grupo As ListViewGroup In From grupo1 As ListViewGroup In list.Groups Where grupo1.ToString.Trim.Equals(namer.Trim)
                grup = grupo
                Exit For
            Next
            Return grup
        End Function

        Private Sub TextBox10_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox10.KeyUp
            If e.KeyValue <> 13 Then Return
            ToolStripMenuItem8.PerformClick()
        End Sub
         
        Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
            ' LISTAR DIRECCIONES
            If Label44.Text = "..." Then Return
            Try
                Dim data = _objetoDireccionesFacturacion.BuscarDireccionesFacturacionClienteXIdCliente(_tipoCon, Label44.Text)
                DataGridView3.Rows.Clear()
                For Each row As DataRow In data.Rows
                    DataGridView3.Rows.Add(row(0).ToString(), row(2).ToString())
                Next
                DataGridView3.ReadOnly = True
                ToolStripMenuItem14.Enabled = True
                ToolStripMenuItem11.Enabled = False
                ToolStripMenuItem16.Enabled = False
                Button2.Enabled = False
            Catch ex As Exception
                DataGridView3.Rows.Clear()
            End Try
        End Sub
         
        Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
            DataGridView3.EndEdit()

            ' GUARDAR DIRECCIONES
            If Label44.Text = "..." Then Return
            'If MessageBox.Show("¿ESTA SEGURA QUE DESEA GUARDAR LOS CAMBIOS?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            If KryptonMessageBox.Show("¿Esta segura que desea guardar los cambios?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> DialogResult.Yes Then Return
            _sqlCommands.Clear()

            Dim id = _objetoDireccionesFacturacion.BuscarMayorIdDireccionFacturacion(_tipoCon) + 1

            For Each row As DataGridViewRow In DataGridView3.Rows
                If row.Index = DataGridView3.RowCount - 1 Then Exit For
                With _objetoDireccionesFacturacion                   
                    .IdCliente = Label44.Text
                    .Direccion = row.Cells(1).Value & ""
                End With

                If (row.Cells(0).Value & "").ToString().Trim().Equals("-") Then
                    _objetoDireccionesFacturacion.IdDireccion = id
                    _sqlCommands.Add(_objetoDireccionesFacturacion.NuevoRegistroDireccionCliente)
                    id += 1
                Else
                    _objetoDireccionesFacturacion.IdDireccion = row.Cells(0).Value & ""
                    _sqlCommands.Add(_objetoDireccionesFacturacion.UpdateRegistroDireccionCliente)
                End If
            Next
             
            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
            If res(0) Then
                DataGridView3.ReadOnly = True
                ToolStripMenuItem14.Enabled = True
                ToolStripMenuItem11.Enabled = False
                ToolStripMenuItem16.Enabled = False
                Button2.Enabled = False
                ToolStripMenuItem9.PerformClick()
                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else
                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End If
            'End If
            'MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
        End Sub

        Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
            ' EDITAR DIRECCIONES
            If Label44.Text = "..." Then Return
            DataGridView3.ReadOnly = False
            ToolStripMenuItem14.Enabled = False
            ToolStripMenuItem11.Enabled = True
            ToolStripMenuItem16.Enabled = True
            Button2.Enabled = True
        End Sub

        Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
            ' CANCELAR
            DataGridView3.ReadOnly = True
            ToolStripMenuItem14.Enabled = True
            ToolStripMenuItem11.Enabled = False
            ToolStripMenuItem16.Enabled = False
            Button2.Enabled = False
            ToolStripMenuItem9.PerformClick()
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            If DataGridView3.CurrentRow.Index = DataGridView3.RowCount - 1 Then Return
            DataGridView3.Rows.Remove(DataGridView3.CurrentRow)
        End Sub

        Private Sub DataGridView3_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellEndEdit
            For Each row As DataGridViewRow In DataGridView3.Rows
                If row.Index = DataGridView3.RowCount - 1 Then Exit For
                If row.Cells(0).Value Is Nothing Then row.Cells(0).Value = "-"
            Next
        End Sub

        Private Sub DataGridView3_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView3.EditingControlShowing
            If DataGridView3.CurrentCell.ColumnIndex = 1 Then AddHandler CType(e.Control, TextBox).KeyPress, AddressOf DataGridTextBox_keyPress
        End Sub

        Private Sub DataGridTextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End Sub

        Private Sub MenuStrip4_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip4.ItemClicked

        End Sub

        Private Sub AGREGARSITIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AGREGARSITIOToolStripMenuItem.Click
            Dim f As New syscisepro.FORMULARIOS.DIVISION_GEOGRÁFICA.FormSitiosTrabajo()
            f.TipoCox = _tipoCon
            f.Show()
        End Sub

        Private Sub KryptonPage5_Click(sender As Object, e As EventArgs) Handles KryptonPage5.Click

        End Sub

        Private Sub KryptonPage1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click

        End Sub

        Private Sub chkConvenio_CheckedChanged(sender As Object, e As EventArgs) Handles chkConvenio.CheckedChanged
            If chkConvenio.Checked Then
                ' Mostrar controles de convenio
                gbxConvenioCliente.BringToFront()
                btnAdd.BringToFront()
                btnRemove.BringToFront()
            Else
                ' Regresar a la normalidad
                dgvClienteGeneral.BringToFront()
                btnAdd.SendToBack()
                btnRemove.SendToBack()
            End If
        End Sub

        Private Sub btnConvenio_Click(sender As Object, e As EventArgs) Handles btnConvenio.Click
            If DataGridView1.RowCount = 0 Then
                KryptonMessageBox.Show("No existen cuentas de convenio", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            Dim id = DataGridView1.CurrentRow.Cells(0).Value



        End Sub
    End Class
End Namespace