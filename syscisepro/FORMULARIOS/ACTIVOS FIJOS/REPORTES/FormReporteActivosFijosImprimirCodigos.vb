Imports ClassLibraryCisepro.ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
Imports ClassLibraryCisepro.ENUMS
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports syscisepro.DATOS

Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteActivosFijosImprimirCodigos
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

        ReadOnly _crActivoArmas As New crArmas
        ReadOnly _crActivoRadios As New crRadios
        ReadOnly _crActivoVehiculos As New crVehiculos
        ReadOnly _crActivoTerrenos As New crTerrenos
        ReadOnly _crEquiposComputo As New crEquiposComputo
        ReadOnly _crLibrosColecciones As New crLibrosColecciones
        ReadOnly _crEquiposOficina As New crEquiposOficina
        ReadOnly _crMueblesOficina As New crMueblesOficina
        ReadOnly _crEquiposCocina As New crEquiposCocina
        ReadOnly _crEquiposAmbientacion As New crEquiposAmbientacion
        ReadOnly _crEquiposComunicacion As New crEquiposComunicacion
        ReadOnly _crEquiposSeguridad As New crEquiposSeguridad
        ReadOnly _crCamarasSeguridad As New crCamarasSeguridad
        ReadOnly _crGeneradores As New crGeneradores
        ReadOnly _crChalecos As New crChalecos
        ReadOnly _crSoftware As New crSotfware

        ReadOnly _objetoArmas As New ClassArmas
        ReadOnly _objetoRadios As New ClassRadios
        ReadOnly _objetoVehiculos As New ClassVehiculo
        ReadOnly _objetoTerrenos As New ClassTerreno
        ReadOnly _objetoEquiposComputo As New ClassEquipoComputo
        ReadOnly _objetoLibrosColecciones As New ClassLibrosColecciones
        ReadOnly _objetoEquiposOficina As New ClassEquiposOficina
        ReadOnly _objetoMueblesOficina As New ClassMueblesOficina
        ReadOnly _objetoEquiposCocina As New ClassEquiposCocina
        ReadOnly _objetoEquiposAmbientacion As New ClassEquiposAmbientacion
        ReadOnly _objetoEquiposComunicacion As New ClassEquiposComunicacion
        ReadOnly _objetoEquiposSeguridad As New ClassEquiposSeguridad
        ReadOnly _objetoCamarasSeguridad As New ClassCamarasSeguridad
        ReadOnly _objetoGeneradores As New ClassGeneradores
        ReadOnly _objetoChalecos As New ClassChalecos
        ReadOnly _objetoSoftware As New ClassSoftware

        Private Sub cbmTipoActivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmTipoActivo.SelectedIndexChanged
            If cbmTipoActivo.Text = "ARMAS" Then
                ConectarReporte(_crActivoArmas)
                '_crActivoArmas.SetDatabaseLogon("syscisepro", "syscisepro")
                _crActivoArmas.SetDataSource(_objetoArmas.SeleccionarTodosLosRegistrosArmas(_tipoCon))
                _crActivoArmas.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crActivoArmas
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "RADIOS" Then
                ConectarReporte(_crActivoRadios)
                '_crActivoRadios.SetDatabaseLogon("syscisepro", "syscisepro")
                _crActivoRadios.SetDataSource(_objetoRadios.SeleccionarTodosLosRegistrosRadios(_tipoCon))
                _crActivoRadios.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crActivoRadios
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "VEHICULOS" Then
                ConectarReporte(_crActivoVehiculos)
                '_crActivoVehiculos.SetDatabaseLogon("syscisepro", "syscisepro")
                _crActivoVehiculos.SetDataSource(_objetoVehiculos.SeleccionarTodosLosRegistrosVehiculos(_tipoCon))
                _crActivoVehiculos.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crActivoVehiculos
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "TERRENOS" Then
                ConectarReporte(_crActivoTerrenos)
                '_crActivoTerrenos.SetDatabaseLogon("syscisepro", "syscisepro")
                _crActivoTerrenos.SetDataSource(_objetoTerrenos.SeleccionarTodosLosRegistrosTerrenos(_tipoCon))
                _crActivoTerrenos.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crActivoTerrenos
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "EQUIPOS DE COMPUTO" Then
                ConectarReporte(_crEquiposComputo)
                '_crEquiposComputo.SetDatabaseLogon("syscisepro", "syscisepro")
                _crEquiposComputo.SetDataSource(_objetoEquiposComputo.SeleccionarTodosLosRegistrosEquiposComputo(_tipoCon))
                _crEquiposComputo.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crEquiposComputo
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "LIBROS Y COLECCIONES" Then
                ConectarReporte(_crLibrosColecciones)
                _crLibrosColecciones.SetDatabaseLogon("syscisepro", "syscisepro")
                _crLibrosColecciones.SetDataSource(_objetoLibrosColecciones.SeleccionarTodosLosRegistrosLibrosColecciones(_tipoCon))
                _crLibrosColecciones.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crLibrosColecciones
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "EQUIPOS DE OFICINA" Then
                ConectarReporte(_crEquiposOficina)
                '_crEquiposOficina.SetDatabaseLogon("syscisepro", "syscisepro")
                _crEquiposOficina.SetDataSource(_objetoEquiposOficina.SeleccionarTodosLosRegistrosEquiposOficina(_tipoCon))
                _crEquiposOficina.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crEquiposOficina
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "MUEBLES DE OFICINA" Then
                ConectarReporte(_crMueblesOficina)
                '_crMueblesOficina.SetDatabaseLogon("syscisepro", "syscisepro")
                _crMueblesOficina.SetDataSource(_objetoMueblesOficina.SeleccionarTodosLosRegistrosMueblesOficina(_tipoCon))
                _crMueblesOficina.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crMueblesOficina
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "EQUIPOS DE COCINA" Then
                ConectarReporte(_crEquiposCocina)
                '_crEquiposCocina.SetDatabaseLogon("syscisepro", "syscisepro")
                _crEquiposCocina.SetDataSource(_objetoEquiposCocina.SeleccionarTodosLosRegistrosEquiposCocina(_tipoCon))
                _crEquiposCocina.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crEquiposCocina
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "EQUIPOS DE AMBIENTACION" Then
                ConectarReporte(_crEquiposAmbientacion)
                '_crEquiposAmbientacion.SetDatabaseLogon("syscisepro", "syscisepro")
                _crEquiposAmbientacion.SetDataSource(_objetoEquiposAmbientacion.SeleccionarTodosLosRegistrosEquiposAmbientacion(_tipoCon))
                _crEquiposAmbientacion.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crEquiposAmbientacion
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "EQUIPOS DE COMUNICACION Y TELEFONIA" Then
                ConectarReporte(_crEquiposComunicacion)
                '_crEquiposComunicacion.SetDatabaseLogon("syscisepro", "syscisepro")
                _crEquiposComunicacion.SetDataSource(_objetoEquiposComunicacion.SeleccionarTodosLosRegistrosEquiposComunicacion(_tipoCon))
                _crEquiposComunicacion.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crEquiposComunicacion
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "EQUIPOS DE SEGURIDAD INDUSTRIAL" Then
                ConectarReporte(_crEquiposSeguridad)
                '_crEquiposSeguridad.SetDatabaseLogon("syscisepro", "syscisepro")
                _crEquiposSeguridad.SetDataSource(_objetoEquiposSeguridad.SeleccionarTodosLosRegistrosEquiposSeguridad(_tipoCon))
                _crEquiposSeguridad.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crEquiposSeguridad
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "CAMARAS DE SEGURIDAD" Then
                ConectarReporte(_crCamarasSeguridad)
                '_crCamarasSeguridad.SetDatabaseLogon("syscisepro", "syscisepro")
                _crCamarasSeguridad.SetDataSource(_objetoCamarasSeguridad.SeleccionarTodosLosRegistrosCamarasSeguridad(_tipoCon))
                _crCamarasSeguridad.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crCamarasSeguridad
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "GENERADORES" Then
                ConectarReporte(_crGeneradores)
                '_crGeneradores.SetDatabaseLogon("syscisepro", "syscisepro")
                _crGeneradores.SetDataSource(_objetoGeneradores.SeleccionarTodosLosRegistrosGeneradores(_tipoCon))
                _crGeneradores.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crGeneradores
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "CHALECOS" Then
                ConectarReporte(_crChalecos)
                ' _crChalecos.SetDatabaseLogon("syscisepro", "syscisepro")
                _crChalecos.SetDataSource(_objetoChalecos.SeleccionarTodosLosRegistrosChalecos(_tipoCon))
                _crChalecos.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crChalecos
                Zoom()
                RefrescarReporte()
            End If
            If cbmTipoActivo.Text = "SOFTWARE" Then
                ConectarReporte(_crSoftware)
                ' _crSoftware.SetDatabaseLogon("syscisepro", "syscisepro")
                _crSoftware.SetDataSource(_objetoSoftware.SeleccionarTodosLosRegistrosSoftware(_tipoCon))
                _crSoftware.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                crvActivosFijos.ReportSource = _crSoftware
                Zoom()
                RefrescarReporte()
            End If
        End Sub

        Private Sub Zoom()
            crvActivosFijos.Zoom(75)
        End Sub

        Private Sub RefrescarReporte()
            crvActivosFijos.Refresh()
            'crvActivosFijos.RefreshReport()
        End Sub

        Private Sub ConectarReporte(ByVal reporte As ReportDocument)
            Dim conexionInformacion As ConnectionInfo = New ConnectionInfo()
            Dim tablas As Tables = reporte.Database.Tables
             
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    conexionInformacion.DatabaseName = "SYSASENAVA"
                Case TipoConexion.Seportpac
                    conexionInformacion.DatabaseName = "SYSSEPORTPAC"
                Case Else
                    conexionInformacion.DatabaseName = "SYSCISEPRO"
            End Select
             
            conexionInformacion.UserID = "syscisepro"
            conexionInformacion.Password = "syscisepro"
            conexionInformacion.ServerName = "192.168.0.137"
            conexionInformacion.Type = ConnectionInfoType.SQL
            For Each tabla As CrystalDecisions.CrystalReports.Engine.Table In tablas
                Dim tablaCrystal As TableLogOnInfo = tabla.LogOnInfo
                tablaCrystal.ConnectionInfo = conexionInformacion
                tabla.ApplyLogOnInfo(tablaCrystal)
            Next
        End Sub

        Private Sub FormReporteActivosFijosImprimirCodigos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                Case Else
                    Icon = My.Resources.logo_c 
            End Select
        End Sub
    End Class
End Namespace