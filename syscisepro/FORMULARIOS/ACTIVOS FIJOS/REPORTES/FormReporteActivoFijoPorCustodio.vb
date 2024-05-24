Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports syscisepro.DATOS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO

Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteActivoFijoPorCustodio
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
        ReadOnly _crActivofijo As New crActivoFijoPorCustodio
        ReadOnly _objetoActivoFijo As New ClassActivoFijo
        ReadOnly _objetoEmpresa As New ClassEmpresa
        ReadOnly _objetoSucursal As New ClassSucursal

        Private Sub ConectarReporte()
            _crActivofijo.SetDataSource(_objetoActivoFijo.SeleccionarTodosRegistrosActivosFijosPorIdPersona(_tipoCon, lblIdCustodio.Text))
            _crActivofijo.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            _crActivofijo.SetParameterValue("EMPRESA", cbEmpresa.Text)
            _crActivofijo.SetParameterValue("SUCURSAL", cbSucursal.Text)
            crvActivoCustodio.ReportSource = _crActivofijo
            crvActivoCustodio.Zoom(75)
            crvActivoCustodio.Refresh()
        End Sub

        Private Sub LlenarComboEmpresa()
            Dim data = _objetoEmpresa.SeleccionarTodosLosRegistrosEmpresa(_tipoCon)
            cbEmpresa.DataSource = data
            cbEmpresa.DisplayMember = data.Columns("NOMBRE_COMERCIAL_EMPRESA").ToString
            cbEmpresa.ValueMember = data.Columns("NOMBRE_COMERCIAL_EMPRESA").ToString
            cbEmpresa.DropDownWidth = 100
        End Sub

        Private Sub LlenarComboSucursal()
            Dim data = _objetoSucursal.SeleccionarTodosLosRegistrosSucursal(_tipoCon)
            cbSucursal.DataSource = data
            cbSucursal.DisplayMember = data.Columns("NOMBRE_SUCURSAL").ToString
            cbSucursal.ValueMember = data.Columns("NOMBRE_SUCURSAL").ToString
            cbSucursal.DropDownWidth = 200
        End Sub
        Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnActualizar.Click
            ConectarReporte()
        End Sub

        Private Sub FormReporteActivoFijoPorCustodio_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                Case Else
                    Icon = My.Resources.logo_c
            End Select
            LlenarComboSucursal()
            LlenarComboEmpresa()
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscar.Click
            Dim frm As New FrmBuscarProveedorCliente
            frm.TipoCox = TipoCox
            frm.IsOperaciones = False
            frm.rbtProveedor.Visible = False
            frm.rbtPersonal.Checked = True
            frm.rbtCliente.Visible = False
            frm.txtParametrobusqueda.Width = frm.txtParametrobusqueda.Width + frm.rbtProveedor.Width + frm.rbtPersonal.Width
            frm.rbtPersonal.Location = New Point(frm.txtParametrobusqueda.Width + frm.Label1.Width + 10, 4)
            Try
                If frm.ShowDialog = vbOK Then
                    If frm.rbtPersonal.Checked Then
                        lblIdCustodio.Text = frm.dgvCustodios.CurrentRow.Cells.Item(0).Value
                        txtCustodio.Text = frm.dgvCustodios.CurrentRow.Cells.Item(5).Value & " " & frm.dgvCustodios.CurrentRow.Cells.Item(4).Value
                    End If
                End If
            Catch ex As Exception
                lblIdCustodio.Text = ""
                txtCustodio.Clear()
            End Try
        End Sub
    End Class
End Namespace