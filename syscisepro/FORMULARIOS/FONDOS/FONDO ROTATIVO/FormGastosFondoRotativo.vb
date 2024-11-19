
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.FONDOS.FONDO_ROTATIVO
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports syscisepro.FORMULARIOS.FONDOS.FONDO_ROTATIVO.REPORTES

Namespace FORMULARIOS.FONDOS.FONDO_ROTATIVO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormGastosFondoRotativo
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
        ReadOnly _objetoGastosFondoRotativo As New ClassGastosFondoRotativo
        ReadOnly _objetoAuxiliarConceptos As New ClassAuxiliarConceptos
        Private ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objSerie As New ClassGenerarSerie

        Dim _botonSeleccionado As Integer

        Private Sub DesabilitadoInicio() 'Desabilita lo que no tiene que cargase al inicio del formulario
            txtIdGastosFR.Enabled = False
            txtNombreGastoFR.Enabled = False
            txtCtaContableGastoFR.Enabled = False
            btnGuardarGastosFondoRotativo.Enabled = False
            btnCancelarGastosFondoRotativo.Enabled = False
        End Sub

        Private Sub HabilitadoNuevo()
            txtIdGastosFR.Enabled = False
            txtNombreGastoFR.Enabled = True
            txtCtaContableGastoFR.Enabled = False
            btnGuardarGastosFondoRotativo.Enabled = True
            btnCancelarGastosFondoRotativo.Enabled = True
            btnNuevoGastosFondoRotativo.Enabled = False
        End Sub

        Private Sub DesabilitadoCancelar()
            DesabilitadoInicio()
            btnNuevoGastosFondoRotativo.Enabled = True
        End Sub

        Private Function ValidacionParametros() As Boolean
            Return txtIdGastosFR.Text <> "" And txtNombreGastoFR.Text <> "" And txtCtaContableGastoFR.Text <> ""
        End Function

        Private Sub LimpiarParametros()
            txtIdGastosFR.Text = ""
            txtNombreGastoFR.Text = ""
            txtCtaContableGastoFR.Text = ""
        End Sub

        Private Sub CargarGastosFondoRotativo()
            Try
                dgvGastosFondoRotativo.DataSource = _objetoGastosFondoRotativo.SeleccionarGastosFondoRotativo(_tipoCon)

                dgvGastosFondoRotativo.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvGastosFondoRotativo.Columns(0).HeaderText = "ID"
                dgvGastosFondoRotativo.Columns(1).HeaderText = "CONCEPTO"
                dgvGastosFondoRotativo.Columns(2).HeaderText = "CUENTA CONTABLE"
                dgvGastosFondoRotativo.Columns(3).HeaderText = "EST"
                dgvGastosFondoRotativo.Columns(4).HeaderText = "ID FR"
                dgvGastosFondoRotativo.Columns(5).HeaderText = "ID PLAN"
                dgvGastosFondoRotativo.AutoResizeColumns()
                dgvGastosFondoRotativo.AutoResizeRows()
                dgvGastosFondoRotativo.ReadOnly = True

            Catch
                dgvGastosFondoRotativo.DataSource = Nothing
            End Try
        End Sub

        Private Sub GuardarGastosFondoRotativoNuevo()
            With _objetoGastosFondoRotativo
                .IdGastos = _objetoGastosFondoRotativo.BuscarMayorIdGastosForndoRotativo(_tipoCon) + 1
                .NombreGastos = txtNombreGastoFR.Text.Trim.ToUpper
                .CtaContableGastos = txtCtaContableGastoFR.Text
                .EstadoGastos = 1
                .IdFondoRotativoGastos = 1
                .Idplan = 137  
            End With
            _sqlCommands.Add(_objetoGastosFondoRotativo.NuevoRegistroGastosForndoRotativo)
            _objAuditoria.AccionAuditoria = "CREO UN NUEVO CONCEPTO DE FONDO ROTATIVO. ID: " + txtIdGastosFR.Text + " CONCEPTO: " + CType(txtNombreGastoFR.Text, String)
            _sqlCommands.Add(_objAuditoria.NuevaAuditoria)
        End Sub

        Private Sub GuardarAuxiliarConceptos()
            With _objetoAuxiliarConceptos
                .IdConcepto = .BuscarMayorIdAuxiliarConceptos(True) + 1
                .NombreConcepto = txtNombreGastoFR.Text.Trim.ToUpper
                .CtaContableConcepto = txtCtaContableGastoFR.Text
                .EstadoConcepto = 1
            End With
            _sqlCommands.Add(_objetoAuxiliarConceptos.NuevoRegistroAuxiliarConcepto)
        End Sub

        Private Sub FormGastosFondoRotativo_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_s
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava 
                    dgvGastosFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White 
                    dgvGastosFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White 
                    dgvGastosFondoRotativo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            dgvGastosFondoRotativo.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            CargarGastosFondoRotativo()
            DesabilitadoInicio()

        End Sub

        Private Sub btnNuevoGastosFondoRotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoGastosFondoRotativo.Click
            _botonSeleccionado = 1
            LimpiarParametros()

            txtIdGastosFR.Text = _objetoAuxiliarConceptos.BuscarMayorIdAuxiliarConceptos(_tipoCon) + 1
            txtCtaContableGastoFR.Text = "5.2.2.06." + _objSerie.SerieDeDos(_objetoAuxiliarConceptos.BuscarMayorIdAuxiliarConceptos(_tipoCon) + 1)

            HabilitadoNuevo()
        End Sub

        Private Sub btnGuardarGastosFondoRotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardarGastosFondoRotativo.Click
            If ValidacionParametros() Then
                 
                If MessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                Select Case (_botonSeleccionado)
                    Case 1
                        GuardarGastosFondoRotativoNuevo()
                        GuardarAuxiliarConceptos()
                End Select
                 
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    DesabilitadoCancelar()
                    CargarGastosFondoRotativo()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("No se puede guardar." & vbNewLine & "NO SE HAN LLENADO TODOS LOS CAMPOS NECESARIOS.", MsgBoxStyle.Exclamation, "Mensaje de validación")
                txtIdGastosFR.Focus()
            End If
        End Sub
        Private Sub btnCancelarGastosFondoRotativo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelarGastosFondoRotativo.Click
            LimpiarParametros()
            DesabilitadoCancelar()
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            Dim f = New FormReporteGastosFondoRotativo
            f.TipoCox = TipoCox
            f.Show()
        End Sub

        Private Sub dgvGastosFondoRotativo_SelectionChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles dgvGastosFondoRotativo.SelectionChanged
            If dgvGastosFondoRotativo.RowCount = 0 Then Return
            If dgvGastosFondoRotativo.CurrentRow Is Nothing Then Return
            txtIdGastosFR.Text = dgvGastosFondoRotativo.CurrentRow.Cells.Item(0).Value
            txtNombreGastoFR.Text = dgvGastosFondoRotativo.CurrentRow.Cells.Item(1).Value.ToString.ToUpper
            txtCtaContableGastoFR.Text = dgvGastosFondoRotativo.CurrentRow.Cells.Item(2).Value.ToString.ToUpper
        End Sub
    End Class
End Namespace