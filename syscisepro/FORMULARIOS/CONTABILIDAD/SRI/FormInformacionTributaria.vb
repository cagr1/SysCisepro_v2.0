
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA

Namespace FORMULARIOS.CONTABILIDAD.SRI
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormInformacionTributaria
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

        Dim objetoEmpresa As New ClassEmpresa
        Dim objetoInformacionTributaria As New ClassInformacionTributaria
        Dim objAuditoria As New ClassAuditoriaGeneral
         
        Public Sub deshabilitadoInicio()
            txtRucEmpresa.Enabled = False
            txtRazonSocialEmpresa.Enabled = False
            txtNombreComercialEmpresa.Enabled = False
            txtDireccionMatrizEmpresa.Enabled = False
            txtContribuyenteEspecialEmpresa.Enabled = False
            txtLlevaContabilidadEmpresa.Enabled = False
            txtSecuencialFactura.Enabled = False
            txtSecuencialNotaCredito.Enabled = False
            txtSecuencialComprobanteRetencion.Enabled = False
            txtNroAutorizacionFactura.Enabled = False
            txtNroAutorizaciónNotaCredito.Enabled = False
            txtNroAutorizacionComprobanteRetencion.Enabled = False
            txtPorcentajeIVA.Enabled = False
            txtPorcentajeICE.Enabled = False
            btnNuevo.Enabled = False
            btnModificar.Enabled = True
            btnGuardar.Enabled = False
            btnCancelar.Enabled = False 
            chkEmpresa.Enabled = False
            chkSecuenciales.Enabled = False
            chkNroAutorizaciones.Enabled = False
            chkImpuestos.Enabled = False
        End Sub
        Public Sub habilitadoModificar()
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True 
            chkEmpresa.Enabled = True
            chkSecuenciales.Enabled = True
            chkNroAutorizaciones.Enabled = True
            chkImpuestos.Enabled = True
        End Sub
        Public Sub habilitadoEmpresa()
            txtRucEmpresa.Enabled = True
            txtRazonSocialEmpresa.Enabled = True
            txtNombreComercialEmpresa.Enabled = True
            txtDireccionMatrizEmpresa.Enabled = True
            txtContribuyenteEspecialEmpresa.Enabled = True
            txtLlevaContabilidadEmpresa.Enabled = True
        End Sub
        Public Sub habilitadoSecuenciales()
            txtSecuencialFactura.Enabled = True
            txtSecuencialNotaCredito.Enabled = True
            txtSecuencialComprobanteRetencion.Enabled = True
        End Sub
        Public Sub habilitadoNroAutorizaciones()
            txtNroAutorizacionFactura.Enabled = True
            txtNroAutorizaciónNotaCredito.Enabled = True
            txtNroAutorizacionComprobanteRetencion.Enabled = True
        End Sub
        Public Sub habilitadoImpuestos()
            txtPorcentajeIVA.Enabled = True
            txtPorcentajeICE.Enabled = True
        End Sub
        Public Sub limpiarParametros()
            chkEmpresa.CheckState = CheckState.Unchecked
            chkSecuenciales.CheckState = CheckState.Unchecked
            chkNroAutorizaciones.CheckState = CheckState.Unchecked
            chkImpuestos.CheckState = CheckState.Unchecked
        End Sub

        Public Sub auditoria()
            Try
                With objAuditoria

                    .IdAuditoria = Convert.ToInt64(.BuscarMayorIdAuditoriaGeneral(_tipoCon) + 1)
                    .IdUsuarioAuditoria = idUsuario
                    .EstadoAuditoria = 1
                    .FechaAuditoria = Date.Now
                    .NuevaAuditoria(_tipoCon)
                End With
            Catch ex As Exception
            End Try
        End Sub
        Public Sub modificarEmpresa()
            Try
                With objetoEmpresa
                    .IdEmpresa = lblIdEmpresa.Text
                    .RucEmpresa = txtRucEmpresa.Text
                    .RazonSocialEmpresa = txtRazonSocialEmpresa.Text
                    .NombreComercialEmpresa = txtNombreComercialEmpresa.Text
                    .DireccionMatrizEmpresa = txtDireccionMatrizEmpresa.Text
                    .NroResContEspecialEmpresa = txtContribuyenteEspecialEmpresa.Text
                    .ObligadoLlevarContEmpresa = txtLlevaContabilidadEmpresa.Text
                    .EstadoEmpresa = 1
                    .ModificarRegistroEmpresaGeneral(_tipoCon)
                End With
                objAuditoria.AccionAuditoria = "ACTUALIZO INFORMACIÓN DE EMPRESA."
                objAuditoria.FormularioAuditoria = Me.Text.ToUpper
                auditoria()
            Catch ex As Exception
            End Try
        End Sub
        Public Sub actualizarSecuencialesInformacionTributaria()
            Try
                With objetoInformacionTributaria
                    .Id = lblIdInformacionTributaria.Text
                    .SecuencialFactura = txtSecuencialFactura.Text
                    .SecuencialNotaCredito = txtSecuencialNotaCredito.Text
                    .SecuencialComprobanteRetencion = txtSecuencialComprobanteRetencion.Text
                    .ActualizarSecuencialesInformacionTributaria(_tipoCon)
                End With
                objAuditoria.AccionAuditoria = "ACTUALIZO SECUENCIALES DE COMPROBANTES."
                objAuditoria.FormularioAuditoria = Me.Text.ToUpper
                auditoria()
            Catch ex As Exception
            End Try
        End Sub
        Public Sub actualizarAutorizacionesInformacionTributaria()
            Try
                With objetoInformacionTributaria
                    .Id = lblIdInformacionTributaria.Text
                    .NroAutoFactura = txtNroAutorizacionFactura.Text
                    .NroAutoNotaCredito = txtNroAutorizaciónNotaCredito.Text
                    .NroAutoComprobanteRetencion = txtNroAutorizacionComprobanteRetencion.Text
                    .ActualizarAutorizacionesInformacionTributaria(_tipoCon)
                End With
                objAuditoria.AccionAuditoria = "ACTUALIZO NÚMEROS DE AUTORIZACIÓN SRI DE COMPROBANTES."
                objAuditoria.FormularioAuditoria = Me.Text.ToUpper
                auditoria()
            Catch ex As Exception
            End Try
        End Sub
        Public Sub actualizarPorcentajesInformacionTributaria()
            Try
                With objetoInformacionTributaria
                    .Id = lblIdInformacionTributaria.Text
                    .PorcentajeIva = txtPorcentajeIVA.Text
                    .PorcentajeIce = txtPorcentajeICE.Text
                    .ActualizarPorcentajesInformacionTributaria(_tipoCon)
                End With
                objAuditoria.AccionAuditoria = "ACTUALIZO PORCENTAJES DE IMPUESTOS."
                objAuditoria.FormularioAuditoria = Me.Text.ToUpper
                auditoria()
            Catch ex As Exception
            End Try
        End Sub
        Public Sub cargarEmpresaInformacionTributaria()
            Try
                dgvEmpresa.DataSource = objetoEmpresa.SeleccionarRegistroEmpresaGeneralInformacionTributaria(_tipoCon) 
              
                dgvEmpresa.Columns(0).HeaderText = "ID EMPRESA"
                dgvEmpresa.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(1).HeaderText = "CODIGO EMPRESA"
                dgvEmpresa.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(2).HeaderText = "RUC EMPRESA"
                dgvEmpresa.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(3).HeaderText = "RAZON SOCIAL EMPRESA"
                dgvEmpresa.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(4).HeaderText = "NOMBRE COMERCIAL EMPRESA"
                dgvEmpresa.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(5).HeaderText = "DIRECCIÓN MATRIZ EMPRESA"
                dgvEmpresa.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(6).HeaderText = "# RES CONT ESPECIAL EMPRESA"
                dgvEmpresa.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(7).HeaderText = "OBLIG LLEVAR CONTABILIDAD EMPRESA"
                dgvEmpresa.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(8).HeaderText = "ID IFNORMACIÓN"
                dgvEmpresa.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(9).HeaderText = "SECUENCIAL FACTURA"
                dgvEmpresa.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(10).HeaderText = "SECUENCIAL NOTA CRÉDITO"
                dgvEmpresa.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(11).HeaderText = "SECUENCIAL COMPROBANTE RETENCIÓN"
                dgvEmpresa.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(12).HeaderText = "# AUTO FACTURA"
                dgvEmpresa.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(13).HeaderText = "# AUTO NOTA CRÉDITO"
                dgvEmpresa.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(14).HeaderText = "# AUTO COMPROBANTE RETENCIÓN"
                dgvEmpresa.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(15).HeaderText = "% IVA"
                dgvEmpresa.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.Columns(16).HeaderText = "% ICE"
                dgvEmpresa.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
                dgvEmpresa.AutoResizeColumns()
                dgvEmpresa.AutoResizeRows()
                dgvEmpresa.ReadOnly = False
                dgvEmpresa.EditMode = DataGridViewEditMode.EditProgrammatically
            Catch ex As Exception
            End Try
        End Sub
        Public Sub llenarCamposEmpresaInformacionTributaria()
            lblIdEmpresa.Text = dgvEmpresa.Rows(0).Cells(0).Value
            txtRucEmpresa.Text = dgvEmpresa.Rows(0).Cells(2).Value
            txtRazonSocialEmpresa.Text = dgvEmpresa.Rows(0).Cells(3).Value
            txtNombreComercialEmpresa.Text = dgvEmpresa.Rows(0).Cells(4).Value
            txtDireccionMatrizEmpresa.Text = dgvEmpresa.Rows(0).Cells(5).Value
            txtContribuyenteEspecialEmpresa.Text = dgvEmpresa.Rows(0).Cells(6).Value
            txtLlevaContabilidadEmpresa.Text = dgvEmpresa.Rows(0).Cells(7).Value
            lblIdInformacionTributaria.Text = dgvEmpresa.Rows(0).Cells(8).Value
            txtSecuencialFactura.Text = dgvEmpresa.Rows(0).Cells(9).Value
            txtSecuencialNotaCredito.Text = dgvEmpresa.Rows(0).Cells(10).Value
            txtSecuencialComprobanteRetencion.Text = dgvEmpresa.Rows(0).Cells(11).Value
            txtNroAutorizacionFactura.Text = dgvEmpresa.Rows(0).Cells(12).Value
            txtNroAutorizaciónNotaCredito.Text = dgvEmpresa.Rows(0).Cells(16).Value
            txtNroAutorizacionComprobanteRetencion.Text = dgvEmpresa.Rows(0).Cells(20).Value
            txtPorcentajeIVA.Text = dgvEmpresa.Rows(0).Cells(21).Value
            txtPorcentajeICE.Text = dgvEmpresa.Rows(0).Cells(22).Value
        End Sub

        Private Sub FormInformacionTributaria_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    MenuStrip1.ForeColor = Color.White
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
            End Select

            deshabilitadoInicio()
            cargarEmpresaInformacionTributaria()
            If dgvEmpresa.RowCount > 0 Then
                llenarCamposEmpresaInformacionTributaria()
            Else
                MsgBox("NO SE HA PODIDO CARGAR LA INFORMACIÓN DE LA EMPRESA", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
            End If
        End Sub
         
        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnModificar.Click
            habilitadoModificar()
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            deshabilitadoInicio()
            cargarEmpresaInformacionTributaria()
            llenarCamposEmpresaInformacionTributaria()
            limpiarParametros()
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If chkEmpresa.CheckState = CheckState.Checked Then
                modificarEmpresa()
            End If
            If chkSecuenciales.CheckState = CheckState.Checked Then
                actualizarSecuencialesInformacionTributaria()
            End If
            If chkNroAutorizaciones.CheckState = CheckState.Checked Then
                actualizarAutorizacionesInformacionTributaria()
            End If
            If chkImpuestos.CheckState = CheckState.Checked Then
                actualizarPorcentajesInformacionTributaria()
            End If
            deshabilitadoInicio()
            cargarEmpresaInformacionTributaria()
            llenarCamposEmpresaInformacionTributaria()
            limpiarParametros()
        End Sub
      
        Private Sub chkEmpresa_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkEmpresa.CheckedChanged
            If chkEmpresa.Checked = True Then
                habilitadoEmpresa()
            Else
                txtRucEmpresa.Enabled = False
                txtRazonSocialEmpresa.Enabled = False
                txtNombreComercialEmpresa.Enabled = False
                txtDireccionMatrizEmpresa.Enabled = False
                txtContribuyenteEspecialEmpresa.Enabled = False
                txtLlevaContabilidadEmpresa.Enabled = False
            End If
        End Sub
        Private Sub chkSecuenciales_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkSecuenciales.CheckedChanged
            If chkSecuenciales.Checked = True Then
                habilitadoSecuenciales()
            Else
                txtSecuencialFactura.Enabled = False
                txtSecuencialNotaCredito.Enabled = False
                txtSecuencialComprobanteRetencion.Enabled = False
            End If
        End Sub
        Private Sub chkNroAutorizaciones_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkNroAutorizaciones.CheckedChanged
            If chkNroAutorizaciones.Checked = True Then
                habilitadoNroAutorizaciones()
            Else
                txtNroAutorizacionFactura.Enabled = False
                txtNroAutorizaciónNotaCredito.Enabled = False
                txtNroAutorizacionComprobanteRetencion.Enabled = False
            End If
        End Sub
        Private Sub chkImpuestos_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chkImpuestos.CheckedChanged
            If chkImpuestos.Checked = True Then
                habilitadoImpuestos()
            Else
                txtPorcentajeIVA.Enabled = False
                txtPorcentajeICE.Enabled = False
            End If
        End Sub
    End Class
End Namespace