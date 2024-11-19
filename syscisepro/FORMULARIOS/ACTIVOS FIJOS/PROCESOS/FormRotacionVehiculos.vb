Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports Krypton.Toolkit

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormRotacionVehiculos
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
        Public UserName As String

        ReadOnly _objPersonal As New ClassPersonal
        ReadOnly _objVehiculos As New ClassVehiculo
        ReadOnly _objRotacion As New ClassRotacionActivos
        ReadOnly _objActivoFijo As New ClassActivoFijo
        Dim _idRotacion As Integer = 0

        Private Sub FormRotacionVehiculos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvPersonal.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvRotaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvPersonal.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvRotaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvPersonal.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvRotaciones.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvPersonal.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvVehiculos.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvRotaciones.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            Cargar()
        End Sub

        Private Sub Cargar()
            Try
                txtFechaRotacion.Text = Date.Now
                dgvPersonal.DataSource = _objPersonal.SeleccionarTodosLosRegistrosSupervisores(_tipoCon)
                dgvPersonal.AutoResizeColumns()
                dgvPersonal.AutoResizeRows()
                dgvPersonal.ReadOnly = False
                dgvPersonal.EditMode = DataGridViewEditMode.EditProgrammatically
                For indexPersonal = 0 To dgvPersonal.Columns.Count - 1
                    dgvPersonal.Columns(indexPersonal).SortMode = DataGridViewColumnSortMode.NotSortable
                Next
                For indexRotaciones = 0 To dgvRotaciones.Columns.Count - 1
                    dgvRotaciones.Columns(indexRotaciones).SortMode = DataGridViewColumnSortMode.NotSortable
                Next
                dgvPersonal.Columns("CEDULA").Visible = False
                dgvPersonal.Columns("DIRECCION").Visible = False
                dgvPersonal.Columns("FECHA_NACIMIENTO").Visible = False
                dgvPersonal.Columns("SEXO").Visible = False
                dgvPersonal.Columns("CIUDAD").Visible = False
                dgvPersonal.Columns("PROVINCIA").Visible = False
                dgvPersonal.Columns("SUELDO").Visible = False
                dgvPersonal.Columns("LIBRETA_MILITAR").Visible = False
                dgvPersonal.Columns("TIPO_SANGRE").Visible = False
                dgvPersonal.Columns("PASAPORTE").Visible = False
                dgvPersonal.Columns("PESO").Visible = False
                dgvPersonal.Columns("EDAD").Visible = False
                dgvPersonal.Columns("PRUEBA_ANTIDROGA").Visible = False
                dgvPersonal.Columns("FECHA_ENTRADA").Visible = False
                dgvPersonal.Columns("FECHA_SALIDA").Visible = False
                dgvPersonal.Columns("ESTADO_PERSONAL").Visible = False
                dgvPersonal.Columns("ID_AREA").Visible = False
                dgvPersonal.Columns("ID_CARGO_OCUPACIONAL").Visible = False
                dgvPersonal.Columns("INSTRUCCION").Visible = False
                dgvPersonal.Columns("ESTADO_CIVIL").Visible = False
            Catch ex As Exception
                dgvPersonal.DataSource = Nothing
            End Try
            Try
                dgvVehiculos.DataSource = _objVehiculos.SeleccionarTodosLosRegistrosVehiculos(_tipoCon).Tables("VEHICULOS")
                dgvVehiculos.AutoResizeColumns()
                dgvVehiculos.AutoResizeRows()
                dgvVehiculos.ReadOnly = False
                dgvVehiculos.EditMode = DataGridViewEditMode.EditProgrammatically
                For index = 0 To dgvVehiculos.Columns.Count - 1
                    dgvVehiculos.Columns(index).SortMode = DataGridViewColumnSortMode.NotSortable
                Next
                dgvVehiculos.Columns("ID_AREA").Visible = False
                dgvVehiculos.Columns("ID_EMPRESA").Visible = False
                dgvVehiculos.Columns("ID_SUCURSAL").Visible = False
                dgvVehiculos.Columns("ID_GERENCIAS").Visible = False
                dgvVehiculos.Columns("CARPETA").Visible = False
                dgvVehiculos.Columns("CONTRATO").Visible = False
                dgvVehiculos.Columns("CODIGO").Visible = False
                dgvVehiculos.Columns("NOMBRE_PROVEDOR").Visible = False
                dgvVehiculos.Columns("RESPONSABLE").Visible = False
                dgvVehiculos.Columns("CODIGO_ARANCEL").Visible = False
                dgvVehiculos.Columns("NUM_ORDEN_COMPRA").Visible = False
                dgvVehiculos.Columns("NUM_FACTURA").Visible = False
                dgvVehiculos.Columns("VALOR_FACTURA").Visible = False
                dgvVehiculos.Columns("VALOR_ADICIONAL").Visible = False
                dgvVehiculos.Columns("VALOR_RESIDUAL").Visible = False
                dgvVehiculos.Columns("FECHA_ADQUISICION").Visible = False
                dgvVehiculos.Columns("AÑOS_VIDA_UTIL").Visible = False
                dgvVehiculos.Columns("CTA_ACTIVO").Visible = False
                dgvVehiculos.Columns("CTA_GASTOS").Visible = False
                dgvVehiculos.Columns("CTA_DEPRECIACION").Visible = False
                dgvVehiculos.Columns("ESTADO").Visible = False
                dgvVehiculos.Columns("MARCA").Visible = False
                dgvVehiculos.Columns("MODELO").Visible = False
                dgvVehiculos.Columns("ESTADO_ACTIVO1").Visible = False
                dgvVehiculos.Columns("ID_ACTIVO_FIJO1").Visible = False
                dgvVehiculos.Columns("MOTOR").Visible = False
                dgvVehiculos.Columns("CILINDRAJE").Visible = False
                dgvVehiculos.Columns("TIPO").Visible = False
                dgvVehiculos.Columns("CAPACIDAD").Visible = False
                dgvVehiculos.Columns("ANO_FABRICACION").Visible = False
                dgvVehiculos.Columns("ASEGURADORA").Visible = False
                dgvVehiculos.Columns("SEGURO").Visible = False
                dgvVehiculos.Columns("BROKER").Visible = False
                dgvVehiculos.Columns("NRO_POLIZA").Visible = False
                dgvVehiculos.Columns("COSTO_PRIMA").Visible = False
                dgvVehiculos.Columns("DISPOSITIVO_SEGURIDAD").Visible = False
                dgvVehiculos.Columns("FECHA_INICIO_CONTRATO").Visible = False
                dgvVehiculos.Columns("FECHA_FINAL_CONTRATO").Visible = False
                dgvVehiculos.Columns("FECHA_RENOVACION_CONTRATO").Visible = False
                dgvVehiculos.Columns("FECHA_INICIO_DIS_SEG").Visible = False
                dgvVehiculos.Columns("FECHA_FINAL_DIS_SEG").Visible = False
                dgvVehiculos.Columns("FECHA_RENOVACION_DIS_SEG").Visible = False
                dgvVehiculos.Columns("ESTADO1").Visible = False
            Catch ex As Exception
                dgvVehiculos.DataSource = Nothing
            End Try
        End Sub
        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregar.Click
            If dgvPersonal.CurrentRow Is Nothing Then Return
            If dgvPersonal.CurrentRow.DefaultCellStyle.BackColor <> Color.GreenYellow And dgvVehiculos.CurrentRow.DefaultCellStyle.BackColor <> Color.Yellow Then
                dgvPersonal.Rows(dgvPersonal.CurrentCell.RowIndex.ToString()).DefaultCellStyle.BackColor = Color.GreenYellow
                dgvPersonal.Rows(dgvPersonal.CurrentCell.RowIndex.ToString()).Selected = False
                dgvPersonal.Rows(dgvPersonal.CurrentCell.RowIndex.ToString + 1).Selected = True
                dgvVehiculos.Rows(dgvVehiculos.CurrentCell.RowIndex.ToString()).DefaultCellStyle.BackColor = Color.Yellow
                dgvVehiculos.Rows(dgvVehiculos.CurrentCell.RowIndex.ToString()).Selected = False
                dgvVehiculos.Rows(dgvVehiculos.CurrentCell.RowIndex.ToString() + 1).Selected = True
                Dim fila As String() = {_idRotacion,
                                        dgvVehiculos.CurrentRow.Cells.Item("ID_ACTIVO_FIJO").Value.ToString(),
                                        dgvVehiculos.CurrentRow.Cells.Item("NOMBRE_ACTIVO").Value.ToString(),
                                        txtFechaRotacion.Text,
                                        dgvPersonal.CurrentRow.Cells.Item("ID_PERSONAL").Value.ToString(),
                                        dgvPersonal.CurrentRow.Cells.Item("APELLIDOS").Value.ToString() + " " + dgvPersonal.CurrentRow.Cells.Item("NOMBRES").Value.ToString(),
                                        dgvVehiculos.CurrentRow.Cells.Item("ID_PERSONAL").Value.ToString(),
                                        dgvVehiculos.CurrentRow.Cells.Item("NOMBRE_CUSTODIO").Value.ToString(),
                                        txtObservacion.Text.ToUpper.Trim}
                dgvRotaciones.Rows.Add(fila)
                _idRotacion += 1
            End If
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            _idRotacion = _objRotacion.BuscarMayorIdRotacion(_tipoCon) + 1
            txtIdRotacion.Text = _idRotacion
            btnNuevo.Enabled = False
            btnAgregar.Enabled = True
            btnGuardar.Enabled = True
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click


            If KryptonMessageBox.Show("¿Esta seguro que desea guardar?", "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
            _sqlCommands.Clear()

            For indice = 0 To dgvRotaciones.Rows.Count - 2
                With _objRotacion
                    .IdRotacion = dgvRotaciones.Rows(indice).Cells("ID_ROTACION").Value
                    .IdActivoFijo = dgvRotaciones.Rows(indice).Cells("ID_ACTIVO").Value
                    .Fecha = txtFechaRotacion.Text
                    .IdCustodioAnterior = dgvRotaciones.Rows(indice).Cells("ID_CUSTODIO_ANTERIOR").Value
                    .IdCustodioNuevo = dgvRotaciones.Rows(indice).Cells("ID_CUSTODIO_NUEVO").Value
                    .NombreCustodioAnterior = dgvRotaciones.Rows(indice).Cells("CUSTODIO_ANTERIOR").Value
                    .NombreCustodioNuevo = dgvRotaciones.Rows(indice).Cells("CUSTODIO_NUEVO").Value
                    .Observacion = dgvRotaciones.Rows(indice).Cells("OBSERVACION").Value
                    .Estado = 1
                End With
                _sqlCommands.Add(_objRotacion.NuevaRotacionVehiculos)

                _sqlCommands.Add(_objActivoFijo.ActualizarActivoFijoPoRotacionCustodio(CType(dgvRotaciones.Rows(indice).Cells("ID_ACTIVO").Value, Integer),
                                                       txtFechaRotacion.Text,
                                                       CType(dgvRotaciones.Rows(indice).Cells("ID_CUSTODIO_NUEVO").Value, Integer),
                                                       CType(dgvRotaciones.Rows(indice).Cells("CUSTODIO_NUEVO").Value, String)))
            Next

            Dim nombreU As String = "Rotacion de Vehiculo por: " & UserName
            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
            If res(0) Then
                btnNuevo.Enabled = True
                btnAgregar.Enabled = False
                btnGuardar.Enabled = False
                dgvRotaciones.Rows.Clear()
                Cargar()
            End If

            Dim messageIcon As KryptonMessageBoxIcon
            If res(0) Then
                messageIcon = KryptonMessageBoxIcon.Information
            Else
                messageIcon = KryptonMessageBoxIcon.Exclamation
            End If
            KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, messageIcon)


        End Sub
    End Class
End Namespace