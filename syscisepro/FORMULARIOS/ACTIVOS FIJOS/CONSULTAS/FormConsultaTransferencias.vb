Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormConsultaTransferencias
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

        ReadOnly _objetoActivoFijoTransferencias As New ClassActivoFijoTransferencias
        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            Try
                If rbTodas.Checked = True Then
                    dgvConsulta.DataSource = _objetoActivoFijoTransferencias.SeleccionarTodosLosRegistrosTransferencias(_tipoCon)
                    Ocultar()
                End If
                If rbFecha.Checked = True Then
                    dgvConsulta.DataSource = _objetoActivoFijoTransferencias.SeleccionarTodosLosRegistrosTransferenciasPorFecha(_tipoCon, dtpFechaInicial.Value, dtpFechaFinal.Value)
                    Ocultar()
                End If
                If rbCustodioAnterior.Checked = True Then
                    dgvConsulta.DataSource = _objetoActivoFijoTransferencias.SeleccionarTodosLosRegistrosTransferenciasPorCustodioAnterior(_tipoCon, txtParametroBusqueda.Text.Trim.ToUpper)
                    Ocultar()
                End If
                If rbCustodioNuevo.Checked = True Then
                    dgvConsulta.DataSource = _objetoActivoFijoTransferencias.SeleccionarTodosLosRegistrosTransferenciasPorCustodioNuevo(_tipoCon, txtParametroBusqueda.Text.Trim.ToUpper)
                    Ocultar()
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub Ocultar()
            dgvConsulta.Columns("ID_TRANSFERENCIA").DefaultCellStyle.BackColor = Color.Azure
            dgvConsulta.Columns("ID_TRANSFERENCIA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
            dgvConsulta.Columns("ID_PERSONAL_ANTERIOR").Visible = False
            dgvConsulta.Columns("ID_PERSONAL_NUEVO").Visible = False
            dgvConsulta.AutoResizeColumns()
            dgvConsulta.AutoResizeRows()
            dgvConsulta.ReadOnly = False
            dgvConsulta.EditMode = DataGridViewEditMode.EditProgrammatically
        End Sub

        Private Sub FormConsultaTransferencias_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvConsulta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvConsulta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvConsulta.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select 
        End Sub
    End Class
End Namespace