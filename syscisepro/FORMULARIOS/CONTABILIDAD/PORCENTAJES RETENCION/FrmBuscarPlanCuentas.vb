Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.PORCENTAJES_RETENCION
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' Para buscar cuentas en PLAN DE CUENTAS
    ''' </summary>
    Public Class FrmBuscarPlanCuentas
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
        Public Tipo As Integer
        Private _objpLClassPlanDeCuentas As New ClassPlanDeCuentas

        Private Sub FrmBuscarPlanCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                Case Else
                    Icon = My.Resources.logo_c
            End Select

            BackColor = ValidationForms.GetColorSistema(_tipoCon)
            Label1.ForeColor = Color.White
            label2.ForeColor = Color.White
            cbxTipoCuenta.SelectedIndex = 0
            txtParametrobusqueda.Focus()
        End Sub

        Private Sub txtParametrobusqueda_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtParametrobusqueda.KeyUp
            If txtParametrobusqueda.Text.Trim().Length = 0 Then Return
            CargarCuentas(txtParametrobusqueda.Text.Trim())
        End Sub

        Private Sub CargarCuentas(ByVal fil As String)
            Try

                Dim data As DataTable
                listView1.Items.Clear()
                listView1.Groups.Clear()

                Select Case Tipo
                    Case 1
                        listView1.Groups.Add(New ListViewGroup("ACTIVOS"))
                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(_tipoCon, False, 1, fil)
                    Case 2
                        listView1.Groups.Add(New ListViewGroup("PASIVOS"))
                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(_tipoCon, False, 2, fil)
                    Case 3
                        listView1.Groups.Add(New ListViewGroup("PATRIMONIO"))
                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(_tipoCon, False, 3, fil)
                    Case 4
                        listView1.Groups.Add(New ListViewGroup("INGRESOS"))
                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(_tipoCon, False, 4, fil)
                    Case 5
                        listView1.Groups.Add(New ListViewGroup("GASTOS"))
                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(_tipoCon, False, 5, fil)
                    Case 6
                        listView1.Groups.Add(New ListViewGroup("GANANCIAS"))
                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(_tipoCon, False, 6, fil)
                    Case Else
                        listView1.Groups.Add(New ListViewGroup("ACTIVOS"))
                        listView1.Groups.Add(New ListViewGroup("PASIVOS"))
                        listView1.Groups.Add(New ListViewGroup("PATRIMONIO"))
                        listView1.Groups.Add(New ListViewGroup("INGRESOS"))
                        listView1.Groups.Add(New ListViewGroup("GASTOS"))
                        listView1.Groups.Add(New ListViewGroup("GANANCIAS"))

                        data = _objpLClassPlanDeCuentas.SeleccionarPlanCuentas(_tipoCon, True, 0, fil)
                End Select


                For Each row As DataRow In data.Rows
                    Dim lst As New ListViewItem(If(row.Item(0) IsNot Nothing, row.Item(0).ToString, String.Empty), GetListViewGroup(row.Item(7).ToString.Trim))
                    lst.UseItemStyleForSubItems = False
                    For i = 1 To data.Columns.Count - 1
                        lst.SubItems.Add(If(row.Item(i) IsNot Nothing, row.Item(i).ToString, String.Empty))
                    Next
                    listView1.Items.Add(lst)
                Next

                For Each col As ColumnHeader In listView1.Columns
                    If col.Width > 5 Then col.Width = -2
                Next

                label4.Visible = False
            Catch ex As Exception
                label4.Text = "ERROR AL CARGAR DATOS: " & ex.Message
                label4.Visible = True
                listView1.Clear()
            End Try
        End Sub

        Private Sub listView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listView1.DoubleClick
            If listView1.Items.Count = 0 Then Return
            If listView1.SelectedItems.Count = 0 Then Return
            DialogResult = DialogResult.OK
        End Sub

        Private Function GetListViewGroup(ByVal name As String) As ListViewGroup
            Dim grup As ListViewGroup = Nothing
            For Each grupo As ListViewGroup In From grupo1 As ListViewGroup In ListView1.Groups Where grupo1.ToString.Trim.Equals(name.Trim)
                grup = grupo
                Exit For
            Next
            Return grup
        End Function

        Private Sub cbxTipoCuenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoCuenta.SelectedIndexChanged
            Tipo = cbxTipoCuenta.SelectedIndex
            CargarCuentas(txtParametrobusqueda.Text.Trim())
        End Sub
    End Class
End Namespace
