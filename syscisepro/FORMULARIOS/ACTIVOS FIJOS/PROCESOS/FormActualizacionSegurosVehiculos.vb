Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES.VEHICULOS

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormActualizacionSegurosVehiculos
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
         
        ReadOnly _objVehiculos As New ClassVehiculo
        ReadOnly _objHistorialVehiculos As New ClassHistorialVehiculos

        Private Sub FormActualizacionSegurosVehiculos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvActualizacionVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvActualizacionVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvActualizacionVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            _sqlCommands = New List(Of SqlCommand)
            CargarTodos() 
        End Sub
        Private Sub CargarTodos()
            dgvActualizacionVehiculos.DataSource = _objVehiculos.SeleccionarTodosLosRegistrosVehiculos(_tipoCon).Tables("VEHICULOS")
            dgvActualizacionVehiculos.AutoResizeColumns()
            dgvActualizacionVehiculos.AutoResizeRows()
            dgvActualizacionVehiculos.ReadOnly = False
            dgvActualizacionVehiculos.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvActualizacionVehiculos.Columns("ID_ACTIVO_FIJO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvActualizacionVehiculos.Columns("ID_PERSONAL").Visible = False
            dgvActualizacionVehiculos.Columns("ID_EMPRESA").Visible = False
            dgvActualizacionVehiculos.Columns("ID_SUCURSAL").Visible = False
            dgvActualizacionVehiculos.Columns("ID_GERENCIAS").Visible = False
            dgvActualizacionVehiculos.Columns("ID_AREA").Visible = False
            dgvActualizacionVehiculos.Columns("CONTRATO").Visible = False
        End Sub
        Private Sub CargarCodigo()
            dgvActualizacionVehiculos.DataSource = _objVehiculos.BuscarPorCodigoVehiculo(_tipoCon, txtParametroBusqueda.Text)
            dgvActualizacionVehiculos.AutoResizeColumns()
            dgvActualizacionVehiculos.AutoResizeRows()
            dgvActualizacionVehiculos.ReadOnly = False
            dgvActualizacionVehiculos.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvActualizacionVehiculos.Columns("ID_ACTIVO_FIJO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvActualizacionVehiculos.Columns("ID_PERSONAL").Visible = False
            dgvActualizacionVehiculos.Columns("ID_EMPRESA").Visible = False
            dgvActualizacionVehiculos.Columns("ID_SUCURSAL").Visible = False
            dgvActualizacionVehiculos.Columns("ID_GERENCIAS").Visible = False
            dgvActualizacionVehiculos.Columns("ID_AREA").Visible = False
            dgvActualizacionVehiculos.Columns("CONTRATO").Visible = False
            dgvActualizacionVehiculos.Columns("CODIGO").DefaultCellStyle.BackColor = Color.Black
            dgvActualizacionVehiculos.Columns("CODIGO").DefaultCellStyle.ForeColor = Color.LightGreen
            dgvActualizacionVehiculos.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End Sub
        Private Sub CargarPlacas()
            dgvActualizacionVehiculos.DataSource = _objVehiculos.BuscarPorPlacaVehiculo(_tipoCon, txtParametroBusqueda.Text)
            dgvActualizacionVehiculos.AutoResizeColumns()
            dgvActualizacionVehiculos.AutoResizeRows()
            dgvActualizacionVehiculos.ReadOnly = False
            dgvActualizacionVehiculos.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvActualizacionVehiculos.Columns("ID_ACTIVO_FIJO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvActualizacionVehiculos.Columns("ID_PERSONAL").Visible = False
            dgvActualizacionVehiculos.Columns("ID_EMPRESA").Visible = False
            dgvActualizacionVehiculos.Columns("ID_SUCURSAL").Visible = False
            dgvActualizacionVehiculos.Columns("ID_GERENCIAS").Visible = False
            dgvActualizacionVehiculos.Columns("ID_AREA").Visible = False
            dgvActualizacionVehiculos.Columns("CONTRATO").Visible = False
            dgvActualizacionVehiculos.Columns("PLACAS").DefaultCellStyle.BackColor = Color.Black
            dgvActualizacionVehiculos.Columns("PLACAS").DefaultCellStyle.ForeColor = Color.LightGreen
            dgvActualizacionVehiculos.Columns("PLACAS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End Sub
        Private Sub dgvActualizacionVehiculos_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvActualizacionVehiculos.Click
            txtNombreActivo.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("NOMBRE_ACTIVO").Value.ToString()
            txtIdActivo.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("ID_ACTIVO_FIJO").Value.ToString()
            txtPlacas.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("PLACAS").Value.ToString()
            txtAseguradora.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("ASEGURADORA").Value.ToString()
            txtBroker.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("BROKER").Value.ToString()
            txtSeguro.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("SEGURO").Value.ToString()
            txtNroPoliza.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("NRO_POLIZA").Value.ToString()
            txtCostoPrima.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("COSTO_PRIMA").Value.ToString()
            txtDispositivoSeguridad.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("DISPOSITIVO_SEGURIDAD").Value.ToString()
            dtpFechaInicioContrato.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("FECHA_INICIO_CONTRATO").Value.ToString()
            dtpFechaFinalContrato.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("FECHA_FINAL_CONTRATO").Value.ToString()
            dtpFechaRenovacionContrato.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("FECHA_RENOVACION_CONTRATO").Value.ToString()
            dtpFechaRenovacionContrato.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("FECHA_RENOVACION_CONTRATO").Value.ToString()
            dtpFechaInicioDispositivo.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("FECHA_INICIO_DIS_SEG").Value.ToString()
            dtpFechaInicioDispositivo.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("FECHA_INICIO_DIS_SEG").Value.ToString()
            dtpFechaFinalDispositivo.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("FECHA_FINAL_DIS_SEG").Value.ToString()
            dtpFechaRenovacionDispositivo.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("FECHA_RENOVACION_DIS_SEG").Value.ToString()
            dtpSoat.Text = dgvActualizacionVehiculos.CurrentRow.Cells.Item("SOAT").Value.ToString()
        End Sub
        Private Sub txtParametroBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtParametroBusqueda.TextChanged
            If rbCodigoActivo.Checked Then CargarCodigo() 
            If rbPlacas.Checked Then  CargarPlacas() 
        End Sub
        Private Sub Parametros(ByVal aseguradora As Boolean, _
                              ByVal broker As Boolean, _
                              ByVal nroPoliza As Boolean, _
                              ByVal costoPrima As Boolean, _
                              ByVal seguro As Boolean, _
                              ByVal fechaInicioContrato As Boolean, _
                              ByVal fechaFinalContrato As Boolean, _
                              ByVal fechaRenovacionContrato As Boolean, _
                              ByVal dispositivoSeguridad As Boolean, _
                              ByVal fechaInicioDispositivo As Boolean, _
                              ByVal fechaFinalDispositivo As Boolean, _
                              ByVal fechaRenovacionDispositivo As Boolean, _
                              ByVal soat As Boolean)
            txtAseguradora.Enabled = aseguradora
            txtBroker.Enabled = broker
            txtNroPoliza.Enabled = nroPoliza
            txtCostoPrima.Enabled = costoPrima
            txtSeguro.Enabled = seguro
            dtpFechaInicioContrato.Enabled = fechaInicioContrato
            dtpFechaFinalContrato.Enabled = fechaFinalContrato
            dtpFechaRenovacionContrato.Enabled = fechaRenovacionContrato
            dtpFechaInicioDispositivo.Enabled = fechaInicioDispositivo
            dtpFechaFinalDispositivo.Enabled = fechaFinalDispositivo
            dtpFechaRenovacionDispositivo.Enabled = fechaRenovacionDispositivo
            txtDispositivoSeguridad.Enabled = dispositivoSeguridad
            dtpSoat.Enabled = soat
        End Sub
        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificar.Click
            btnActualizar.Enabled = True
            btnModificar.Enabled = False
            If txtIdActivo.Text <> "" Then
                Parametros(True, True, True, True, True, True, True, True, True, True, True, True, True)
            Else
                MsgBox("Necesita seleccionar un Vehículo para actulizar datos", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÓN")
                btnActualizar.Enabled = False
            End If
        End Sub
        Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnActualizar.Click
            If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            _sqlCommands.Clear()
             
            If txtIdActivo.Text <> "" Then
                _objHistorialVehiculos.BuscarNroHistorialPorIActivo(_tipoCon, txtIdActivo.Text)
                With _objVehiculos
                    .IdActivo = txtIdActivo.Text
                    .Aseguradora = txtAseguradora.Text.ToUpper
                    .Seguro = txtSeguro.Text.ToUpper
                    .Broker = txtBroker.Text.ToUpper
                    .NumeroPoliza = txtNroPoliza.Text.ToUpper
                    .CostoPrima = CType(txtCostoPrima.Text, Decimal)
                    .DispositivoSeguridad = txtDispositivoSeguridad.Text.ToUpper
                    .FechaInicioContrato = dtpFechaInicioContrato.Text
                    .FechaFinalContrato = dtpFechaFinalContrato.Text
                    .FechaRenovacionContrato = dtpFechaRenovacionContrato.Text
                    .FechaInicioDispositivoSeguridad = dtpFechaInicioDispositivo.Text
                    .FechaFinalDispositivoSeguridad = dtpFechaFinalDispositivo.Text
                    .FechaRenovacionDispositivoSeguridad = dtpFechaRenovacionDispositivo.Text
                    .Estado = 1
                    .Soat = dtpSoat.Text
                End With
                _sqlCommands.Add(_objVehiculos.ActualizarSegurosVehiculo)

                With _objHistorialVehiculos
                    .IdActivoFijo = txtIdActivo.Text
                    .NroHistorial = _objHistorialVehiculos.BuscarNroHistorialPorIActivo(_tipoCon, CType(txtIdActivo.Text, Integer)) + 1
                    .Fecha = Date.Now
                    .Soat = dtpSoat.Text
                    .Aseguradora = txtAseguradora.Text.ToUpper
                    .Seguro = txtSeguro.Text.ToUpper
                    .Broker = txtBroker.Text.ToUpper
                    .NroPoliza = txtNroPoliza.Text.ToUpper
                    .CostoPrima = CType(txtCostoPrima.Text, Decimal)
                    .DispositivoSeguridad = txtDispositivoSeguridad.Text.ToUpper
                    .FechaInicioContrato = dtpFechaInicioContrato.Text
                    .FechaFinalContrato = dtpFechaFinalContrato.Text
                    .FechaRenovacionContrato = dtpFechaRenovacionContrato.Text
                    .FechaInicioDispositivo = dtpFechaInicioDispositivo.Text
                    .FechaFinalDispositivo = dtpFechaFinalDispositivo.Text
                    .FechaRenovacionDispositivo = dtpFechaRenovacionDispositivo.Text
                End With
                _sqlCommands.Add(_objHistorialVehiculos.NuevoHistorialVehiculos)
            End If
             
            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
            If res(0) Then
                CargarTodos()
                txtIdActivo.Text = ""
                txtNombreActivo.Text = ""
                txtPlacas.Text = ""
                txtAseguradora.Text = ""
                txtBroker.Text = ""
                txtNroPoliza.Text = ""
                txtCostoPrima.Text = ""
                txtDispositivoSeguridad.Text = ""
                txtSeguro.Text = ""
            End If
            MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
        End Sub

    End Class
End Namespace