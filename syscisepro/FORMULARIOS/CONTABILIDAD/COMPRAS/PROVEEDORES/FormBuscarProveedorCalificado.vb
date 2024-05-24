Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES

    Public Class FormBuscarProveedorCalificado
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

        ReadOnly _objetoProveedorGeneral As New ClassProveedores

        Private Sub CargarProveedorGeneral()
            Try
                dgvProveedorGeneral.DataSource = _objetoProveedorGeneral.SeleccionarRegistrosProveedorGeneralCalificado(_tipoCon) 
                dgvProveedorGeneral.Columns(0).HeaderText = "ID"
                dgvProveedorGeneral.Columns(0).DefaultCellStyle.BackColor = Color.Azure
                dgvProveedorGeneral.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.Columns(1).HeaderText = "FECHA"
                dgvProveedorGeneral.Columns(1).DefaultCellStyle.BackColor = Color.Azure
                dgvProveedorGeneral.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.Columns(2).HeaderText = "RUC / CI"
                dgvProveedorGeneral.Columns(2).DefaultCellStyle.BackColor = Color.Azure
                dgvProveedorGeneral.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.Columns(3).HeaderText = "RAZÓN SOCIAL"
                dgvProveedorGeneral.Columns(3).DefaultCellStyle.BackColor = Color.Azure
                dgvProveedorGeneral.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.Columns(4).HeaderText = "NOMBRE COMERCIAL"
                dgvProveedorGeneral.Columns(4).DefaultCellStyle.BackColor = Color.Cyan
                dgvProveedorGeneral.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.Columns(5).HeaderText = "TIPO PROVEEDOR"
                dgvProveedorGeneral.Columns(5).DefaultCellStyle.BackColor = Color.Cyan
                dgvProveedorGeneral.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.Columns(6).HeaderText = "LLEVA CONTABILIDAD"
                dgvProveedorGeneral.Columns(6).DefaultCellStyle.BackColor = Color.Azure
                dgvProveedorGeneral.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.Columns(7).HeaderText = "CONTRIBUYENTE ESPECIAL"
                dgvProveedorGeneral.Columns(7).DefaultCellStyle.BackColor = Color.Azure
                dgvProveedorGeneral.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.Columns(8).HeaderText = "DIRECCIÓN"
                dgvProveedorGeneral.Columns(8).DefaultCellStyle.BackColor = Color.Azure
                dgvProveedorGeneral.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.Columns(9).HeaderText = "TELEFONO 1"
                dgvProveedorGeneral.Columns(9).DefaultCellStyle.BackColor = Color.Azure
                dgvProveedorGeneral.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.Columns(10).HeaderText = "TELEFONO 2"
                dgvProveedorGeneral.Columns(10).DefaultCellStyle.BackColor = Color.Azure
                dgvProveedorGeneral.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.Columns(11).HeaderText = "E-MAIL"
                dgvProveedorGeneral.Columns(11).DefaultCellStyle.BackColor = Color.Azure
                dgvProveedorGeneral.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.Columns(12).HeaderText = "EST"
                dgvProveedorGeneral.Columns(12).DefaultCellStyle.BackColor = Color.Azure
                dgvProveedorGeneral.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvProveedorGeneral.AutoResizeColumns()
                dgvProveedorGeneral.AutoResizeRows()
                dgvProveedorGeneral.ReadOnly = True 
            Catch
                dgvProveedorGeneral.DataSource = Nothing
            End Try
        End Sub

        Private Sub txtBusqueda_KeyUp(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles txtBusqueda.KeyUp
            If txtBusqueda.Text.Trim().Length = 0 Then Return
            If e.KeyCode <> Keys.Enter Then Return
            If rbNombre.Checked Then
                dgvProveedorGeneral.DataSource = _objetoProveedorGeneral.BuscarProveedorGeneralCalificadoXNombre(_tipoCon, txtBusqueda.Text)
                dgvProveedorGeneral.AutoResizeColumns()
                dgvProveedorGeneral.ReadOnly = True
                dgvProveedorGeneral.EditMode = DataGridViewEditMode.EditProgrammatically
            ElseIf rb.Checked Then
                dgvProveedorGeneral.DataSource = _objetoProveedorGeneral.BuscarProveedorGeneralCalificadoXRuc(_tipoCon, txtBusqueda.Text)
                dgvProveedorGeneral.AutoResizeColumns()
                dgvProveedorGeneral.ReadOnly = True
                dgvProveedorGeneral.EditMode = DataGridViewEditMode.EditProgrammatically
            Else
                MsgBox("SELECCIONE UN PARÁMETRO DE BÚSQUEDA", MsgBoxStyle.Critical, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub

        Private Sub FormBuscarProveedorCalificado_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvProveedorGeneral.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvProveedorGeneral.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvProveedorGeneral.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            'cargarProveedorGeneral()
            txtBusqueda.Focus()
        End Sub
         
        Private Sub dgvProveedorGeneral_CellDoubleClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedorGeneral.CellDoubleClick
            If dgvProveedorGeneral.RowCount = 0 Then Return
            If dgvProveedorGeneral.CurrentRow Is Nothing Then Return
            DialogResult = DialogResult.OK
        End Sub
    End Class
End Namespace