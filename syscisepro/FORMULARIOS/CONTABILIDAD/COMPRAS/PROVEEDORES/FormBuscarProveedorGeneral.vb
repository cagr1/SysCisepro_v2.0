'Imports SysCisepro
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.CONTABILIDAD.COMPRAS.PROVEEDORES

    Public Class FormBuscarProveedorGeneral
        ReadOnly _tipoCon = [Enum].Parse(GetType(TipoConexion), 0) ' CISEPRO
        Dim objetoProveedorGeneral As New ClassProveedores

        Public Sub cargarProveedorGeneral()
            Try
                dgvProveedorGeneral.DataSource = objetoProveedorGeneral.SeleccionarRegistrosProveedorGeneral(_tipoCon)
                'cantidadRegistrosProveedorGeneral = objetoProveedorGeneral.SeleccionarRegistrosProveedorGeneral.Rows.Count
                dgvProveedorGeneral.AutoResizeColumns()
                dgvProveedorGeneral.AutoResizeRows()
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
                dgvProveedorGeneral.ReadOnly = False
                dgvProveedorGeneral.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
            End Try
        End Sub

        Private Sub FormBuscarProveedorGeneral_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            cargarProveedorGeneral()
        End Sub

        Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtBusqueda.TextChanged
            Try
                If rbNombre.Checked Then
                    dgvProveedorGeneral.DataSource = objetoProveedorGeneral.BuscarProveedorGeneralXNombre(_tipoCon, txtBusqueda.Text)
                    dgvProveedorGeneral.AutoResizeColumns()
                    'dgvBusquedaPersonal.AutoResizeRows()
                    dgvProveedorGeneral.ReadOnly = False
                    dgvProveedorGeneral.EditMode = DataGridViewEditMode.EditProgrammatically
                Else

                    If rb.Checked Then
                        dgvProveedorGeneral.DataSource = objetoProveedorGeneral.BuscarProveedorGeneralXRuc(_tipoCon, txtBusqueda.Text)
                        dgvProveedorGeneral.AutoResizeColumns()
                        'dgvBusquedaPersonal.AutoResizeRows()
                        dgvProveedorGeneral.ReadOnly = False
                        dgvProveedorGeneral.EditMode = DataGridViewEditMode.EditProgrammatically
                    Else
                        MsgBox("SELECCIONE UN PARÁMETRO DE BÚSQUEDA", MsgBoxStyle.Critical, "MENSAJE DE VALIDACIÓN")
                    End If
                End If
            Catch ex As Exception
            End Try
        End Sub
    End Class
End Namespace