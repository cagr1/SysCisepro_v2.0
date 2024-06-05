Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.VALIDACIONES
Imports syscisepro.FORMULARIOS.ACTIVOS_FIJOS.REPORTES

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormBajasActivosFijos
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

        ReadOnly _objActivoFijo As New ClassActivoFijo
        ReadOnly _objActivoFijoBaja As New ClassActivoFijoBajas
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoValidacionesNumeros As New ClassNumerico
        ReadOnly _objetoValidacionesAlfanumerico As New ClassAlfanumerico
        ReadOnly _objetoValidacionesAlfabetico As New ClassAlfabetico
        
        Private Sub txtBusquedaActivoFijo_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtBusquedaActivoFijo.TextChanged
            If rbCodigoActivo.Checked = True Then
                Try
                    dgvActivosFijos.DataSource = _objActivoFijo.BuscarPorCodigoActivoFijo(_tipoCon, txtBusquedaActivoFijo.Text)
                    dgvActivosFijos.AutoResizeColumns()
                    dgvActivosFijos.AutoResizeRows()
                    dgvActivosFijos.ReadOnly = False
                    dgvActivosFijos.EditMode = DataGridViewEditMode.EditProgrammatically
                    dgvActivosFijos.Columns("ID_EMPRESA").Visible = False
                    dgvActivosFijos.Columns("ID_SUCURSAL").Visible = False
                    dgvActivosFijos.Columns("ID_AREA").Visible = False
                    dgvActivosFijos.Columns("ID_GERENCIAS").Visible = False
                Catch ex As Exception
                    dgvActivosFijos.DataSource = Nothing
                End Try 
            End If
            If rbNombreCustodio.Checked = True Then
                Try
                    dgvActivosFijos.DataSource = _objActivoFijo.BuscarPorCustodioActivoFijo(_tipoCon, txtBusquedaActivoFijo.Text)
                    dgvActivosFijos.AutoResizeColumns()
                    dgvActivosFijos.AutoResizeRows()
                    dgvActivosFijos.ReadOnly = False
                    dgvActivosFijos.EditMode = DataGridViewEditMode.EditProgrammatically
                    dgvActivosFijos.Columns("ID_EMPRESA").Visible = False
                    dgvActivosFijos.Columns("ID_SUCURSAL").Visible = False
                    dgvActivosFijos.Columns("ID_AREA").Visible = False
                    dgvActivosFijos.Columns("ID_GERENCIAS").Visible = False
                Catch ex As Exception
                    dgvActivosFijos.DataSource = Nothing
                End Try 
            End If
        End Sub

        Private Sub GuardarBaja()
            With _objActivoFijoBaja
                .Id = _objActivoFijoBaja.BuscarMayorIdBajas(_tipoCon) + 1
                .FechaBaja = txtFecha.Text
                .IdCustodio = lblIdCustodio.Text
                .IdActivo = lblCodigo.Text
                .Autorizo = txtAutorizo.Text.ToUpper
                .Motivo = cbmMotivo.Text.ToUpper
                .Destinatario = txtDestinatario.Text.ToUpper
                .InformeTecnico = txtInformeTecnico.Text.ToUpper
                .NroMemorandum = txtNroMemorandum.Text
                .Estado = 1
                .TipoActivo = lblTipoActivo.Text.Trim.ToUpper
                .EstadoActivo = cbmEstadoActivo.Text.Trim.ToUpper 
            End With
            _sqlCommands.Add(_objActivoFijoBaja.NuevoActivoFijoBajas)
        End Sub

        Private Sub dgvActivosFijos_CellClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvActivosFijos.CellClick
            If dgvActivosFijos.RowCount = 0 Or dgvActivosFijos.CurrentRow Is Nothing Then Return

            lblCodigo.Text = dgvActivosFijos.CurrentRow.Cells.Item(0).Value.ToString()
            lblCodigoActivo.Text = dgvActivosFijos.CurrentRow.Cells.Item(8).Value.ToString()
            lblNombreActivoFijo.Text = dgvActivosFijos.CurrentRow.Cells.Item(9).Value.ToString()
            lblIdCustodio.Text = dgvActivosFijos.CurrentRow.Cells.Item(1).Value.ToString()
            lblNombreCustodio.Text = dgvActivosFijos.CurrentRow.Cells.Item(11).Value.ToString()
            lblTipoActivo.Text = dgvActivosFijos.CurrentRow.Cells.Item(27).Value.ToString().Trim
        End Sub

        Private Sub ParametrosEnabled(ByVal busqueda As Boolean, ByVal estadoActivo As Boolean, ByVal motivo As Boolean, ByVal informeTecnico As Boolean, ByVal nroMemorandum As Boolean, ByVal destinatario As Boolean, ByVal autotorizo As Boolean)
            txtBusquedaActivoFijo.Enabled = busqueda
            cbmEstadoActivo.Enabled = estadoActivo
            cbmMotivo.Enabled = motivo
            txtInformeTecnico.Enabled = informeTecnico
            txtNroMemorandum.Enabled = nroMemorandum
            txtDestinatario.Enabled = destinatario
            txtAutorizo.Enabled = autotorizo
        End Sub

        Private Sub Limpiar()
            txtBusquedaActivoFijo.Text = ""
            cbmEstadoActivo.Text = ""
            cbmMotivo.Text = ""
            txtInformeTecnico.Text = ""
            txtNroMemorandum.Text = ""
            txtDestinatario.Text = ""
            txtAutorizo.Text = ""
        End Sub

        Private Function ValidacionParametros() As Boolean
            Return txtIdBaja.Text <> "" And cbmEstadoActivo.Text <> "" And cbmMotivo.Text <> "" And txtInformeTecnico.Text <> "" _
               And txtNroMemorandum.Text <> "" And txtDestinatario.Text <> "" And lblCodigo.Text <> "" And lblCodigoActivo.Text <> "" And lblIdCustodio.Text <> "" And _
               lblNombreActivoFijo.Text <> "" And lblNombreCustodio.Text <> "" And txtAutorizo.Text <> ""  
        End Function

        Private Sub btnNuevoBaja_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevoBaja.Click
            ParametrosEnabled(True, True, True, True, True, True, True) 
            btnNuevoBaja.Enabled = False
            btnBaja.Enabled = True
        End Sub

        Private Sub FormBajasActivosFijos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvActivosFijos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvActivosFijos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvActivosFijos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvActivosFijos.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            txtFecha.Text = Date.Now 
        End Sub

        Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBaja.Click
            If ValidacionParametros() Then
                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                Select Case (lblTipoActivo.Text)
                    Case "ARMAS"
                        _sqlCommands.Add(_objActivoFijo.BajaArmas(CInt(lblCodigo.Text)))
                    Case "RADIOS"
                        _sqlCommands.Add(_objActivoFijo.BajaRadios(CInt(lblCodigo.Text))) 
                    Case "VEHÍCULOS" 
                        _sqlCommands.Add(_objActivoFijo.BajaVehiculos(CInt(lblCodigo.Text)))
                    Case "TERRENOS"
                        _sqlCommands.Add(_objActivoFijo.BajaTerrenos(CInt(lblCodigo.Text)))
                    Case "EQUIPOS DE COMPUTO"
                        _sqlCommands.Add(_objActivoFijo.BajaEquiposComputo(CInt(lblCodigo.Text)))
                    Case "LIBROS Y COLECCIONES"
                        _sqlCommands.Add(_objActivoFijo.BajaLibrosYColecciones(CInt(lblCodigo.Text)))
                    Case "EQUIPOS DE OFICINA"
                        _sqlCommands.Add(_objActivoFijo.BajaEquiposOficina(CInt(lblCodigo.Text)))
                    Case "MUEBLES DE OFICINA"
                        _sqlCommands.Add(_objActivoFijo.BajaMueblesOficina(CInt(lblCodigo.Text)))
                    Case "EQUIPOS DE COCINA"
                        _sqlCommands.Add(_objActivoFijo.BajaEquiposCocina(CInt(lblCodigo.Text)))
                    Case "EQUIPOS DE AMBIENTACIÓN"                        
                        _sqlCommands.Add(_objActivoFijo.BajaEquiposAmbientacion(CInt(lblCodigo.Text)))
                    Case "EQUIPOS DE COMUNICACIÓN Y TELEFONÍA"
                        _sqlCommands.Add(_objActivoFijo.BajaEquiposComunicacion(CInt(lblCodigo.Text)))
                    Case "EQUIPOS DE SEGURIDAD INDUSTRIAL"
                        _sqlCommands.Add(_objActivoFijo.BajaEquiposSeguridadIndustrial(CInt(lblCodigo.Text)))
                    Case "CAMARAS DE SEGURIDAD"
                        _sqlCommands.Add(_objActivoFijo.BajaCamarasSeguridad(CInt(lblCodigo.Text)))
                    Case "GENERADORES"
                        _sqlCommands.Add(_objActivoFijo.BajaGeneradores(CInt(lblCodigo.Text)))
                    Case "CHALECOS"
                        _sqlCommands.Add(_objActivoFijo.BajaChalecos(CInt(lblCodigo.Text)))
                    Case "SOFTWARE"
                        _sqlCommands.Add(_objActivoFijo.BajasSoftware(CInt(lblCodigo.Text)))
                End Select
                 
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    Auditoria()
                    GuardarBaja()
                    btnNuevoBaja.Enabled = True
                    btnBaja.Enabled = False
                    ParametrosEnabled(False, False, False, False, False, False, False)
                    Limpiar()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
            Else
                MsgBox("NO HA LLENADO TODOS LOS PARÁMETROS DE BAJAS", MsgBoxStyle.Information, "MENSAJE DE INFORMACIÓN")
            End If
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporte.Click
            Dim formReporteBajas As New FormReporteBajas
            formReporteBajas.TipoCox = TipoCox
            formReporteBajas.lblIdBaja.Text = txtIdBaja.Text
            formReporteBajas.ShowDialog()
        End Sub

        Private Sub Auditoria()
            _objAuditoria.IdAuditoria = _objAuditoria.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1
            _objAuditoria.FechaAuditoria = _objAuditoria.FechaExactaAuditoria(_tipoCon)
            _objAuditoria.FormularioAuditoria = Text.Trim
            _objAuditoria.EstadoAuditoria = 1
            _objAuditoria.IdUsuarioAuditoria = IdUsuario
            _objAuditoria.AccionAuditoria = "REGISTRO UNA BAJA CON N° DE REGISTRO: " + txtIdBaja.Text
            _sqlCommands.Add(_objAuditoria.NuevaAuditoria)
        End Sub

        Private Sub txtNroMemorandum_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtNroMemorandum.KeyPress
            e.Handled = Not _objetoValidacionesNumeros.EsNumero(e.KeyChar)
        End Sub

        Private Sub txtDestinatario_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtDestinatario.KeyPress
            e.Handled = Not _objetoValidacionesAlfanumerico.EsAlfanumerico(e.KeyChar)
        End Sub

        Private Sub txtAutorizo_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtAutorizo.KeyPress
            e.Handled = Not _objetoValidacionesAlfabetico.EsLetra(e.KeyChar)
        End Sub
    End Class
End Namespace