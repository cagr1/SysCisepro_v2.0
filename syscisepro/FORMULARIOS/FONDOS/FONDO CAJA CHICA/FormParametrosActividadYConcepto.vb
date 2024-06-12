
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.CAJA_CHICA
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports syscisepro.DATOS

Namespace FORMULARIOS.FONDOS.FONDO_CAJA_CHICA
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormParametrosActividadYConcepto
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

        ReadOnly _objGastosCajaCh As New ClassGastosCajaChica
        ReadOnly _objetoAuxiliarConceptos As New ClassAuxiliarConceptos
        ReadOnly _objPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objSerie As New ClassGenerarSerie

        Private Sub LlenarComboPlanCuentas()
            Dim data = _objPlanCuentas.SeleccionarCuentasOtrosGastos(_tipoCon)
            cbmPlanCuentas.DataSource = data
            cbmPlanCuentas.DisplayMember = data.Columns("DETALLE").ToString
            cbmPlanCuentas.ValueMember = data.Columns("DETALLE").ToString
        End Sub

        Private Sub GuardarAuxiliarConceptos()
            With _objetoAuxiliarConceptos
                .IdConcepto = CType(lblIdGastoCajaChica.Text, Integer)
                .NombreConcepto = txtDetalle.Text.Trim.ToUpper
                .CtaContableConcepto = txtCtaContable.Text.Trim.ToUpper
                .EstadoConcepto = 1 
            End With
            _sqlCommands.Add(_objetoAuxiliarConceptos.NuevoRegistroAuxiliarConcepto)
        End Sub
        Private Sub FormParametrosActividadYConcepto_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvGastosCajaChica.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvGastosCajaChica.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvGastosCajaChica.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvGastosCajaChica.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            LlenarComboPlanCuentas()
            CargarGastosCajaChica()
            lblCuentaGastos.Text = _objPlanCuentas.BuscarCodigoPlanCuentasPorDetalle(_tipoCon, cbmPlanCuentas.Text)

        End Sub

        Private Sub CargarGastosCajaChica()
            dgvGastosCajaChica.DataSource = _objGastosCajaCh.SeleccionarTodosRegistrosGastosCajaChica(_tipoCon)
            dgvGastosCajaChica.AutoResizeColumns()
            dgvGastosCajaChica.AutoResizeRows()
            dgvGastosCajaChica.ReadOnly = False
            dgvGastosCajaChica.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvGastosCajaChica.Columns("CTA_CONTABLE_GASTO_CAJA_CH").DefaultCellStyle.BackColor = Color.Ivory
            dgvGastosCajaChica.Columns("CTA_CONTABLE_GASTO_CAJA_CH").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            btnGuardar.Enabled = True : btnNuevo.Enabled = False
            txtDetalle.Enabled = True

            lblIdGastoCajaChica.Text = _objetoAuxiliarConceptos.BuscarMayorIdAuxiliarConceptos(_tipoCon) + 1
            txtCtaContable.Text = lblCuentaGastos.Text + "." + _objSerie.SerieDeDos(_objetoAuxiliarConceptos.BuscarMayorIdAuxiliarConceptos(_tipoCon) + 1)
            txtDetalle.Text = ""
            txtDetalle.Focus()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            _sqlCommands.Clear()

            If txtDetalle.Text <> "" And txtCtaContable.Text <> "" Then
                With _objGastosCajaCh
                    .IdGastos = _objGastosCajaCh.BuscarMayorIdGastosCajaChica(_tipoCon) + 1
                    .NombreGastos = txtDetalle.Text.Trim.ToUpper
                    .CtaContable = txtCtaContable.Text.Trim.ToUpper
                    .IdPlan = _objPlanCuentas.BuscarIdPlanCuentasPorDetalle(_tipoCon, cbmPlanCuentas.Text)
                    .Estado = 1
                End With
                _sqlCommands.Add(_objGastosCajaCh.NuevaGastosCajaChica)

                GuardarAuxiliarConceptos()

                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    CargarGastosCajaChica()
                    btnGuardar.Enabled = False
                    btnNuevo.Enabled = True
                    txtDetalle.Text = ""
                    txtDetalle.Enabled = False
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("No ha llenado todos los parámetros necesarios", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÓN")
                txtDetalle.Focus()
            End If
        End Sub
        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            tcParametros.SelectedIndex = 1
            ConectarReporte()
        End Sub

        Private Sub ConectarReporte()
            Dim crConceptosCajaChica As New crConceptos
            crConceptosCajaChica.SetDataSource(_objGastosCajaCh.SeleccionarCajasChicaConceptos(_tipoCon))
            crConceptosCajaChica.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvActividades.ReportSource = crConceptosCajaChica
            crvActividades.Zoom(75)
            crvActividades.Refresh()
        End Sub
    End Class
End Namespace