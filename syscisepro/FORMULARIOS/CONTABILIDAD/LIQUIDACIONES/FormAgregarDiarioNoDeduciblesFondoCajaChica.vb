
Imports ClassLibraryCisepro.CONTABILIDAD.CENTRO_DE_COSTOS 
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.LIQUIDACIONES
    Public Class FormAgregarDiarioNoDeduciblesFondoCajaChica
        'ReadOnly _tipoCon = [Enum].Parse(GetType(TipoConexion), 0) ' CISEPRO

        ''=================================================================================================================================================================================
        'Public varDetallePlanCuentas As String
        ''=================================================================================================================================================================================
        'Dim objetoPlanCuentas As New ClassPlanDeCuentas
        ''=================================================================================================================================================================================
        'Dim objCentroCostos As New ClassCentroCosto
        ''=================================================================================================================================================================================
        'Public Sub llenarComboCentroCostos()
        '    Dim data = objCentroCostos.SeleccionarCentroCosto(_tipoCon)
        '    cbmCentroCosto.DataSource = data
        '    cbmCentroCosto.DisplayMember = data.Columns("DETALLE_CENTRO_COSTO").ToString
        '    cbmCentroCosto.ValueMember = data.Columns("DETALLE_CENTRO_COSTO").ToString
        '    cbmCentroCosto.DropDownWidth = 300
        'End Sub
        ''=================================================================================================================================================================================
        'Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCargar.Click
        '    Me.Close()
        'End Sub
        ''=================================================================================================================================================================================
        'Private Sub FormAgregarDiarioNoDeduciblesFondoCajaChica_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        '    llenarComboCentroCostos()
        '    buscarCuenta()
        'End Sub
        ''=================================================================================================================================================================================
        'Private Sub lblCentroCosto_DoubleClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblCentroCosto.DoubleClick
        '    cbmCentroCosto.Enabled = True
        'End Sub

        'Public Sub buscarCuenta()

        '    varDetallePlanCuentas = objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, txtCodCuentaAsiento.Text)
        '    txtNombreCuentaAsiento.Text = varDetallePlanCuentas
        'End Sub

        'Private Sub txtCodCuentaAsiento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCuentaAsiento.KeyPress
        '    If e.KeyChar <> ChrW(Keys.Enter) Then
        '        e.Handled = False
        '    Else
        '        txtCodCuentaAsiento.Enabled = False
        '        txtDetalleAsiento.Focus()
        '        txtDetalleAsiento.Text = ""
        '        e.Handled = True
        '    End If
        'End Sub

        'Private Sub cbmCentroCosto_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCentroCosto.SelectionChangeCommitted
        '    cbmCentroCosto.Enabled = False
        '    txtCodCuentaAsiento.Focus()
        'End Sub

        'Private Sub txtDetalleAsiento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDetalleAsiento.KeyPress
        '    If e.KeyChar <> ChrW(Keys.Enter) Then
        '        e.Handled = False
        '    Else
        '        txtDetalleAsiento.Enabled = False
        '        btnCargar.Focus()
        '        e.Handled = True
        '    End If
        'End Sub
    End Class
End Namespace