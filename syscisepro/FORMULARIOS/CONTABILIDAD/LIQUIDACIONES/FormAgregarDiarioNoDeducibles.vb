
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS 
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.LIQUIDACIONES
    Public Class FormAgregarDiarioNoDeducibles
        'ReadOnly _tipoCon = [Enum].Parse(GetType(TipoConexion), 0) ' CISEPRO
        'Public varDetallePlanCuentas As String
        'Public varValorDebe As Decimal = 0

        'Dim objetoPlanCuentas As New ClassPlanDeCuentas

        'Dim objetoCentroCosto As New ClassCentroCosto

        'Public Sub habilitadoNuevo()
        '    '===
        '    btnEnviar.Enabled = True
        '    '===
        '    txtCodCuentaAsiento.Enabled = True
        '    txtNombreCuentaAsiento.Enabled = True
        '    txtConceptoAsiento.Enabled = True
        '    txtDetalleAsiento.Enabled = True
        '    cmbCentroCosto.Enabled = True
        '    txtValorDebeAsiento.Enabled = False
        '    txtValorHaberAsiento.Enabled = False
        'End Sub
        'Public Sub limpiarParametros()
        '    txtCodCuentaAsiento.Text = ""
        '    txtNombreCuentaAsiento.Text = ""
        '    txtConceptoAsiento.Text = ""
        '    txtDetalleAsiento.Text = ""
        '    cmbCentroCosto.Text = ""
        'End Sub
        'Public Sub llenarComboCentroCosto()
        '    Try
        '        Dim data = objetoCentroCosto.SeleccionarCentroCosto(_tipoCon)
        '        cmbCentroCosto.DataSource = data
        '        cmbCentroCosto.DisplayMember = data.Columns(1).ToString
        '        cmbCentroCosto.ValueMember = data.Columns(1).ToString
        '    Catch ex As Exception
        '    End Try
        'End Sub

        'Private Sub FormAgregarDiarioNoDeducibles_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        '    'deshabilitadoInicio()
        '    limpiarParametros()
        '    habilitadoNuevo()
        '    llenarComboCentroCosto()
        '    txtValorDebeAsiento.Text = varValorDebe
        '    txtValorHaberAsiento.Text = "0.00"
        'End Sub

        'Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEnviar.Click
        '    Me.Close()
        'End Sub
        'Private Sub txtCodCuentaAsiento_Leave(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtCodCuentaAsiento.Leave
        '    If txtCodCuentaAsiento.Text <> "520228" Then
        '        MsgBox("CUENTA NO VALIDA." & vbNewLine & "PARA REGISTRAR OTROS GASTOS NO DEDUCIBLES EN EL LIBRO DIARIO UTILICE LA CUENTA 520228", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
        '        txtCodCuentaAsiento.Text = ""
        '        txtCodCuentaAsiento.Focus()
        '    Else

        '        varDetallePlanCuentas = objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, txtCodCuentaAsiento.Text)
        '        txtNombreCuentaAsiento.Text = varDetallePlanCuentas
        '    End If
        'End Sub

        'Private Sub txtConceptoAsiento_Validated(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtConceptoAsiento.Validated
        '    If txtConceptoAsiento.Text.ToUpper <> "OTROS GASTOS NO DEDUCIBLES" Then
        '        MsgBox("CONCEPTO NO VALIDO." & vbNewLine & "TIENE QUE GUARDAR CON CONCEPTO 'OTROS GASTOS NO DEDUCIBLES'.", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
        '        txtConceptoAsiento.Text = ""
        '        txtConceptoAsiento.Focus()
        '    End If
        'End Sub

        'Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
        '    Me.Close()
        'End Sub
    End Class
End Namespace