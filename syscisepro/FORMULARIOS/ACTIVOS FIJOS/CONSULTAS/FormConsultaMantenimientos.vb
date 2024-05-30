Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormConsultaMantenimientos
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

        ReadOnly _objetoActivoFijoMantenimientos As New ClassActivoFijoMantenimiento
        Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnConsultar.Click
            If rbDia.Checked = True Then
                dgvActivosFijosMantenimientos.DataSource = _objetoActivoFijoMantenimientos.BuscarMantenimientosDelDia(_tipoCon).Tables("ACTIVO_FIJO_MANTENIMIENTOS")
                Ordenar()
            End If
            If rbSemana.Checked = True Then
                dgvActivosFijosMantenimientos.DataSource = _objetoActivoFijoMantenimientos.BuscarMantenimientosDeSemana(_tipoCon).Tables("ACTIVO_FIJO_MANTENIMIENTOS")
                Ordenar()
            End If
        End Sub
        Private Sub btnConsultarTodas_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnConsultarTodas.Click
            If rbTodas.Checked = True Then
                dgvActivosFijosMantenimientos.DataSource = _objetoActivoFijoMantenimientos.BuscarFichasMantenimiento(_tipoCon).Tables("ACTIVO_FIJO_MANTENIMIENTOS")
                Ordenar()
            End If
            If rbCumplidas.Checked = True Then
                dgvActivosFijosMantenimientos.DataSource = _objetoActivoFijoMantenimientos.BuscarFichasMantenimientoCumplio(_tipoCon).Tables("ACTIVO_FIJO_MANTENIMIENTOS")
                Ordenar()
            End If
            If rbNoCumplidas.Checked = True Then
                dgvActivosFijosMantenimientos.DataSource = _objetoActivoFijoMantenimientos.BuscarFichasMantenimientoNoCumplio(_tipoCon).Tables("ACTIVO_FIJO_MANTENIMIENTOS")
                Ordenar()
            End If
        End Sub

        Private Sub Ordenar()
            dgvActivosFijosMantenimientos.AutoResizeColumns()
            dgvActivosFijosMantenimientos.AutoResizeRows()
            dgvActivosFijosMantenimientos.ReadOnly = False
            dgvActivosFijosMantenimientos.EditMode = DataGridViewEditMode.EditProgrammatically
        End Sub

        Private Sub FormConsultaMantenimientos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvActivosFijosMantenimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvActivosFijosMantenimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvActivosFijosMantenimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvActivosFijosMantenimientos.Font = New Font("Roboto", 8, FontStyle.Regular)
        End Sub
    End Class
End Namespace