Imports ClassLibraryCisepro.ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.VALIDACIONES
Imports Krypton.Toolkit

Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormConsultarProximosSegurosVencidos
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


        ReadOnly _sonido As New ClassBeep
        ReadOnly _objVehiculos As New ClassVehiculo

        Private Sub FormSoat_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvDispositivos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSeguros.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvDispositivos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSeguros.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                     dgvDispositivos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSeguros.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvDispositivos.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvSeguros.Font = New Font("Roboto", 8, FontStyle.Regular)
            txtFechaActual.Text = Date.Now
            txtFechaActualDispositivo.Text = Date.Now
            Dim cerrar = 0
            Consultar()
            ConsultarDispositivos()
            If dgvSeguros.RowCount > 1 Then
                'MsgBox("Algunos Vehículos necesitan renovar el SEGURO esta semana", MsgBoxStyle.Critical, "MENSAJE DE VALIDACIÓN")
                KryptonMessageBox.Show("Algunos Vehículos necesitan renovar el SEGURO esta semana", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                _sonido.Intermitente()
                tcSeguros.SelectedIndex = 0
            Else
                KryptonMessageBox.Show("No existen Vehículos que necesiten renovar el SEGURO esta semana", "MENSAJE DE VALIDACIÓN", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                cerrar += 1
            End If
            If dgvDispositivos.RowCount > 1 Then
                MsgBox("Algunos Vehículos necesitan renovar el DISPOSITIVO DE SEGURIDAD esta semana", MsgBoxStyle.Critical, "MENSAJE DE VALIDACIÓN")
                tcSeguros.SelectedIndex = 1
                _sonido.Intermitente()
            Else
                MsgBox("No existen Vehículos que necesiten renovar el DISPOSITIVO DE SEGURIDAD esta semana", MsgBoxStyle.Information, "MENSAJE DE VALIDACIÓN")
                cerrar += 1
            End If
            If cerrar = 2 Then
                Close()
            End If

           
        End Sub

        Private Sub Consultar()
            dgvSeguros.DataSource = _objVehiculos.SeleccionarSegurosProximosSemana(_tipoCon).Tables("ACTIVO_FIJO_GENERAL")
            dgvSeguros.AutoResizeColumns()
            dgvSeguros.AutoResizeRows()
            dgvSeguros.ReadOnly = False
            dgvSeguros.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvSeguros.Columns("FECHA_RENOVACION_CONTRATO").DefaultCellStyle.BackColor = Color.Red
        End Sub

        Private Sub ConsultarDispositivos()
            dgvDispositivos.DataSource = _objVehiculos.SeleccionarDispositivosSeguridadProximosSemana(_tipoCon).Tables("ACTIVO_FIJO_GENERAL")
            dgvDispositivos.AutoResizeColumns()
            dgvDispositivos.AutoResizeRows()
            dgvDispositivos.ReadOnly = False
            dgvDispositivos.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvDispositivos.Columns("FECHA_RENOVACION_DIS_SEG").DefaultCellStyle.BackColor = Color.Red
        End Sub

        Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnConsultar.Click
            Consultar()
        End Sub
    End Class
End Namespace