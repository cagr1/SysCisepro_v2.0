Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.OPERACIONES
Imports ClassLibraryCisepro.TALENTO_HUMANO

Namespace FORMULARIOS.INVENTARIOS.PROCESO
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmBuscarProveedorCliente
        Private _tipoCon As TipoConexion

        WriteOnly Property TipoCox As Integer
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

        ReadOnly _objCliente As New ClassClienteGeneral
        ReadOnly _objProveedor As New ClassProveedores
        ReadOnly _objPersonal As New ClassPersonal
        ReadOnly _objProgramacion As New ClassProgramacionOperaciones

        Public IsOperaciones As Boolean

        Public IsAdmin As Boolean

        Public Todos As Boolean

        Public SoloDeGuardias As Boolean

        Private Sub CargarProveedores(ByVal parametroBusqueda As String)
            Try
                dgvCustodios.DataSource = _objProveedor.BuscarFiltradoPorRazonSocialProveedorGeneral(_tipoCon, parametroBusqueda)

                dgvCustodios.Columns(0).HeaderText = "ID"
                dgvCustodios.Columns(0).Width = 40
                dgvCustodios.Columns(1).Visible = False
                dgvCustodios.Columns(2).HeaderText = "C.I. / R.U.C."
                dgvCustodios.Columns(2).Width = 100

                dgvCustodios.Columns(3).HeaderText = "NOMBRE / RAZÓN SOCIAL"
                dgvCustodios.Columns(3).Width = 300

                dgvCustodios.Columns(4).HeaderText = "APELLIDO / NOMBRE COMERCIAL"
                dgvCustodios.Columns(4).Width = 300

                dgvCustodios.Columns(5).Visible = False
                dgvCustodios.Columns(6).Visible = False
                dgvCustodios.Columns(7).Visible = False

                dgvCustodios.Columns(8).HeaderText = "DIRECCIÓN"
                dgvCustodios.Columns(8).Width = 300

                dgvCustodios.Columns(9).Visible = False
                dgvCustodios.Columns(10).Visible = False
                dgvCustodios.Columns(11).Visible = False
                dgvCustodios.Columns(12).Visible = False
                dgvCustodios.Columns(13).Visible = False




            Catch ex As Exception
                dgvCustodios.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarClientesVigilanciaFisica(ByVal parametroBusqueda As String)
            Try
                dgvCustodios.DataSource = _objCliente.BuscarFiltradoPorRazonSocialClienteVigilanciaFisica(_tipoCon, parametroBusqueda)
                dgvCustodios.Columns(0).HeaderText = "ID"
                dgvCustodios.Columns(0).Width = 40
                dgvCustodios.Columns(1).Visible = False
                dgvCustodios.Columns(2).Visible = False
                dgvCustodios.Columns(3).HeaderText = "C.I. / R.U.C."
                dgvCustodios.Columns(3).Width = 100

                dgvCustodios.Columns(4).HeaderText = "NOMBRE / RAZÓN SOCIAL"
                dgvCustodios.Columns(4).Width = 300

                dgvCustodios.Columns(5).HeaderText = "APELLIDO / NOMBRE COMERCIAL"
                dgvCustodios.Columns(5).Width = 300
                dgvCustodios.Columns(6).Visible = False
                dgvCustodios.Columns(7).Visible = False
                dgvCustodios.Columns(8).HeaderText = "DIRECCIÓN"
                dgvCustodios.Columns(8).Width = 300

                dgvCustodios.Columns(9).Visible = False
                dgvCustodios.Columns(10).Visible = False
                dgvCustodios.Columns(11).Visible = False
                dgvCustodios.Columns(12).Visible = False
                dgvCustodios.Columns(13).Visible = False
                dgvCustodios.Columns(14).Visible = False
                dgvCustodios.Columns(15).Visible = False
                dgvCustodios.Columns(16).Visible = False
                dgvCustodios.Columns(17).Visible = False
                dgvCustodios.Columns(18).Visible = False
                dgvCustodios.Columns(19).Visible = False
            Catch ex As Exception
                dgvCustodios.DataSource = Nothing
            End Try
        End Sub
        Private Sub CargarClienteGeneral(ByVal parametroBusqueda As String)
            Try
                dgvCustodios.DataSource = _objCliente.BuscarFiltradoPorRazonSocialClienteGeneral(_tipoCon, parametroBusqueda)
                dgvCustodios.Columns(0).HeaderText = "ID"
                dgvCustodios.Columns(0).Width = 40
                dgvCustodios.Columns(1).Visible = False
                dgvCustodios.Columns(2).Visible = False
                dgvCustodios.Columns(3).HeaderText = "C.I. / R.U.C."
                dgvCustodios.Columns(3).Width = 100

                dgvCustodios.Columns(4).HeaderText = "NOMBRE / RAZÓN SOCIAL"
                dgvCustodios.Columns(4).Width = 300

                dgvCustodios.Columns(5).HeaderText = "APELLIDO / NOMBRE COMERCIAL"
                dgvCustodios.Columns(5).Width = 300
                dgvCustodios.Columns(6).Visible = False
                dgvCustodios.Columns(7).Visible = False
                dgvCustodios.Columns(8).HeaderText = "DIRECCIÓN"
                dgvCustodios.Columns(8).Width = 300

                dgvCustodios.Columns(9).Visible = False
                dgvCustodios.Columns(10).Visible = False
                dgvCustodios.Columns(11).Visible = False
                dgvCustodios.Columns(12).Visible = False
                dgvCustodios.Columns(13).Visible = False
                dgvCustodios.Columns(14).Visible = False
                dgvCustodios.Columns(15).Visible = False
                dgvCustodios.Columns(16).Visible = False
                dgvCustodios.Columns(17).Visible = False
                dgvCustodios.Columns(18).Visible = False
                dgvCustodios.Columns(19).Visible = False
            Catch ex As Exception
                dgvCustodios.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarPersonalGeneral(ByVal parametroBusqueda As String)
            Try
                dgvCustodios.DataSource = _objPersonal.BuscarFiltradoPorNombrePersonalGeneral(_tipoCon, parametroBusqueda, Todos)
                dgvCustodios.Columns(0).HeaderText = "ID"
                dgvCustodios.Columns(0).Width = 40
                dgvCustodios.Columns(1).Visible = False
                dgvCustodios.Columns(2).Visible = False
                dgvCustodios.Columns(3).HeaderText = "C.I. / R.U.C."
                dgvCustodios.Columns(3).Width = 100

                dgvCustodios.Columns(4).HeaderText = "NOMBRE / RAZÓN SOCIAL"
                dgvCustodios.Columns(4).Width = 200

                dgvCustodios.Columns(5).HeaderText = "APELLIDO / NOMBRE COMERCIAL"
                dgvCustodios.Columns(5).Width = 200
                dgvCustodios.Columns(6).Visible = False
                dgvCustodios.Columns(7).Visible = False
                dgvCustodios.Columns(8).HeaderText = "DIRECCIÓN"
                dgvCustodios.Columns(8).Width = 300
            Catch ex As Exception
                dgvCustodios.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarPersonalGeneralOperaciones(ByVal parametroBusqueda As String)
            Try
                dgvCustodios.DataSource = _objPersonal.BuscarFiltradoPorNombrePersonalGeneralOperaciones(_tipoCon, parametroBusqueda, Todos)
                dgvCustodios.Columns(0).HeaderText = "ID"
                dgvCustodios.Columns(0).Width = 40
                dgvCustodios.Columns(1).Visible = False
                dgvCustodios.Columns(2).Visible = False
                dgvCustodios.Columns(3).HeaderText = "C.I. / R.U.C."
                dgvCustodios.Columns(3).Width = 100

                dgvCustodios.Columns(4).HeaderText = "NOMBRE / RAZÓN SOCIAL"
                dgvCustodios.Columns(4).Width = 150

                dgvCustodios.Columns(5).HeaderText = "APELLIDO / NOMBRE COMERCIAL"
                dgvCustodios.Columns(5).Width = 150
                dgvCustodios.Columns(6).Visible = False
                dgvCustodios.Columns(7).HeaderText = "CARGO"
                dgvCustodios.Columns(7).Width = 150
                dgvCustodios.Columns(8).HeaderText = "AREA"
                dgvCustodios.Columns(8).Width = 200
                dgvCustodios.Columns(9).HeaderText = "MOVIL"
                dgvCustodios.Columns(9).Width = 100
                dgvCustodios.Columns(10).HeaderText = "TELÉFONO"
                dgvCustodios.Columns(10).Width = 100
            Catch ex As Exception
                dgvCustodios.DataSource = Nothing
            End Try
        End Sub

        Private Sub CargarPersonalGeneralAdministrativo(ByVal parametroBusqueda As String)
            Try
                dgvCustodios.DataSource = _objPersonal.BuscarFiltradoPorNombrePersonalGeneralAdministrativo(_tipoCon, parametroBusqueda, Todos)
                dgvCustodios.Columns(0).HeaderText = "ID"
                dgvCustodios.Columns(0).Width = 40
                dgvCustodios.Columns(1).Visible = False
                dgvCustodios.Columns(2).Visible = False
                dgvCustodios.Columns(3).HeaderText = "C.I. / R.U.C."
                dgvCustodios.Columns(3).Width = 100

                dgvCustodios.Columns(4).HeaderText = "NOMBRE / RAZÓN SOCIAL"
                dgvCustodios.Columns(4).Width = 150

                dgvCustodios.Columns(5).HeaderText = "APELLIDO / NOMBRE COMERCIAL"
                dgvCustodios.Columns(5).Width = 150
                dgvCustodios.Columns(6).Visible = False
                dgvCustodios.Columns(7).HeaderText = "CARGO"
                dgvCustodios.Columns(7).Width = 150
                dgvCustodios.Columns(8).HeaderText = "AREA"
                dgvCustodios.Columns(8).Width = 200
            Catch ex As Exception
                dgvCustodios.DataSource = Nothing
            End Try
        End Sub

        Private Sub txtParametrobusqueda_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtParametrobusqueda.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            If rbtProveedor.Checked Then
                CargarProveedores(txtParametrobusqueda.Text.Trim)
            ElseIf rbtCliente.Checked Then
                If Todos Then
                    CargarClienteGeneral(txtParametrobusqueda.Text.Trim)
                Else
                    CargarClientesVigilanciaFisica(txtParametrobusqueda.Text.Trim)
                End If
            Else
                If IsOperaciones Then
                    If IsAdmin Then
                        CargarPersonalGeneralAdministrativo(txtParametrobusqueda.Text.Trim)
                    Else
                        CargarPersonalGeneralOperaciones(txtParametrobusqueda.Text.Trim)
                    End If
                Else
                    CargarPersonalGeneral(txtParametrobusqueda.Text.Trim)
                End If
            End If
        End Sub

        Private Sub dgvCustodios_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustodios.CellDoubleClick
            If e.RowIndex > -1 Then
                DialogResult = DialogResult.OK
            End If
        End Sub

        Public Sub CargarPersonalNoProgramacion(ByVal idp As Integer)
            Try
                dgvCustodios.DataSource = _objProgramacion.CargarPersonalNoProgramacion(_tipoCon, idp)

                dgvCustodios.Columns(0).HeaderText = "ID"
                dgvCustodios.Columns(0).Width = 40

                dgvCustodios.Columns(1).HeaderText = "NÓMINA"
                dgvCustodios.Columns(1).Width = 300

                dgvCustodios.Columns(2).HeaderText = "ÚLIMO PUESTO REGISTRADO"
                dgvCustodios.Columns(2).Width = 390

                dgvCustodios.Columns(3).Visible = False

                For Each row As DataGridViewRow In dgvCustodios.Rows
                    If (row.Cells(2).Value & "").ToString().Trim().Length = 0 And (row.Cells(3).Value & "").ToString().Trim().Equals("ASPIRANTES PARA GUARDIAS") Then
                        row.Cells(2).Value = row.Cells(3).Value
                    End If
                Next

            Catch ex As Exception
                dgvCustodios.DataSource = Nothing
            End Try
        End Sub

        Public Sub CargarSitiosNoProgramacion(ByVal idp As Integer)
            Try
                dgvCustodios.DataSource = _objProgramacion.CargarSitiosNoProgramacion(_tipoCon, idp)

                dgvCustodios.Columns(0).HeaderText = "RIVER"
                dgvCustodios.Columns(0).Width = 50

                dgvCustodios.Columns(1).HeaderText = "CLIENTE"
                dgvCustodios.Columns(1).Width = 300

                dgvCustodios.Columns(2).HeaderText = "PUESTO"
                dgvCustodios.Columns(2).Width = 300

                dgvCustodios.Columns(3).HeaderText = "DIRECCIÓN"
                dgvCustodios.Columns(3).Width = 380
            Catch ex As Exception
                dgvCustodios.DataSource = Nothing
            End Try
        End Sub

        Private Sub FrmBuscarProveedorCliente_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a

                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s

                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c

                    dgvCustodios.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvCustodios.Font = New Font("Roboto", 8, FontStyle.Regular)
        End Sub

    End Class
End Namespace