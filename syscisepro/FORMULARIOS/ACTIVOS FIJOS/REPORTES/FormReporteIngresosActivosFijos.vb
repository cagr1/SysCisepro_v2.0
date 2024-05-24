Imports ClassLibraryCisepro.ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.ACTIVOS_FIJOS.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteIngresosActivosFijos
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
        ReadOnly _crIngresoMueblesOficina As New crIngresoMueblesOficina
        ReadOnly _crIngresoArmas As New crIngresoArmas
        ReadOnly _crIngresoRadios As New crIngresoRadios
        ReadOnly _crIngresoVehiculos As New crIngresoVehiculos
        ReadOnly _crIngresoTerrenos As New crIngresoTerrenos
        ReadOnly _crIngresoEquiposDeComputo As New crIngresoEquiposDeComputo
        ReadOnly _crIngresoLibrosYColecciones As New crIngresoLibrosYColecciones
        ReadOnly _crIngresoEquiposDeOficina As New crIngresoEquiposDeOficina
        ReadOnly _crIngresoEquiposDeCocina As New crIngresoEquiposDeCocina
        ReadOnly _crIngresoEquiposDeAmbientacion As New crIngresoEquiposDeAmbientacion
        ReadOnly _crIngresoEquipoDeComunicacion As New crIngresoEquiposDeComunicacionYTelefonia
        ReadOnly _crIngresoEquipoDeSeguridad As New crIngresoEquiposDeSeguridadIndustrial
        ReadOnly _crIngresoCamarasDeSeguridad As New crIngresoCamarasDeSeguridad
        ReadOnly _crIngresoGeneradores As New crIngresoGeneradores
        ReadOnly _crIngresoChalecos As New crIngresoChalecos
        ReadOnly _crIngresoSoftware As New crIngresoSoftware

        '==============================================================================================================================================================================================================
        ReadOnly _objMueblesOficina As New ClassMueblesOficina
        ReadOnly _objArmas As New ClassArmas
        ReadOnly _objRadios As New ClassRadios
        ReadOnly _objVehiculos As New ClassVehiculo
        ReadOnly _objTerrenos As New ClassTerreno
        ReadOnly _objEquiposDeComputo As New ClassEquipoComputo
        ReadOnly _objLibrosYColecciones As New ClassLibrosColecciones
        ReadOnly _objEquiposDeOficina As New ClassEquiposOficina
        ReadOnly _objEquiposDeCocina As New ClassEquiposCocina
        ReadOnly _objEquiposDeAmbientacion As New ClassEquiposAmbientacion
        ReadOnly _objEquiposDeComunicacion As New ClassEquiposComunicacion
        ReadOnly _objEquiposDeSeguridad As New ClassEquiposSeguridad
        ReadOnly _objCamarasDeSeguridad As New ClassCamarasSeguridad
        ReadOnly _objGeneradores As New ClassGeneradores
        ReadOnly _objChalecos As New ClassChalecos
        ReadOnly _objSoftware As New ClassSoftware
        '==============================================================================================================================================================================================================
        Private Sub CargarMueblesOficina()
            _crIngresoMueblesOficina.SetDataSource(_objMueblesOficina.SeleccionarIngresosMueblesOficina(_tipoCon))
            _crIngresoMueblesOficina.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoMueblesOficina
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarArmas()
            _crIngresoArmas.SetDataSource(_objArmas.SeleccionarIngresosArmas(_tipoCon))
            _crIngresoArmas.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoArmas
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarRadios()
            _crIngresoRadios.SetDataSource(_objRadios.SeleccionarIngresosRadios(_tipoCon))
            _crIngresoRadios.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoRadios
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarVehiculos()
            _crIngresoVehiculos.SetDataSource(_objVehiculos.SeleccionarIngresosVehiculos(_tipoCon))
            _crIngresoVehiculos.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoVehiculos
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarTerrenos()
            _crIngresoTerrenos.SetDataSource(_objTerrenos.SeleccionarIngresosTerrenos(_tipoCon))
            _crIngresoTerrenos.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoTerrenos
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarLibroYColecciones()
            _crIngresoLibrosYColecciones.SetDataSource(_objLibrosYColecciones.SeleccionarIngresosLibrosYColecciones(_tipoCon))
            _crIngresoLibrosYColecciones.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoLibrosYColecciones
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarEquiposDeComputo()
            _crIngresoEquiposDeComputo.SetDataSource(_objEquiposDeComputo.SeleccionarIngresosEquiposDeComputo(_tipoCon))
            _crIngresoEquiposDeComputo.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoEquiposDeComputo
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarEquiposDeOficina()
            _crIngresoEquiposDeOficina.SetDataSource(_objEquiposDeOficina.SeleccionarIngresosEquiposDeOficina(_tipoCon))
            _crIngresoEquiposDeOficina.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoEquiposDeOficina
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarEquiposDeCocina()
            _crIngresoEquiposDeCocina.SetDataSource(_objEquiposDeCocina.SeleccionarIngresosEquiposDeCocina(_tipoCon))
            _crIngresoEquiposDeCocina.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoEquiposDeCocina
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarEquiposDeAmbientación()
            _crIngresoEquiposDeAmbientacion.SetDataSource(_objEquiposDeAmbientacion.SeleccionarIngresosEquiposDeAmbientacion(_tipoCon))
            _crIngresoEquiposDeAmbientacion.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoEquiposDeAmbientacion
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarEquiposDeComunicacion()
            _crIngresoEquipoDeComunicacion.SetDataSource(_objEquiposDeComunicacion.SeleccionarTodosLosRegistrosEquiposComunicacion(_tipoCon))
            _crIngresoEquipoDeComunicacion.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoEquipoDeComunicacion
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarEquiposDeSeguridad()
            _crIngresoEquipoDeSeguridad.SetDataSource(_objEquiposDeSeguridad.SeleccionarIngresosEquiposDeSeguridad(_tipoCon))
            _crIngresoEquipoDeSeguridad.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoEquipoDeSeguridad
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarCamarasDeSeguridad()
            _crIngresoCamarasDeSeguridad.SetDataSource(_objCamarasDeSeguridad.SeleccionarIngresosCamarasDeSeguridad(_tipoCon))
            _crIngresoCamarasDeSeguridad.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoCamarasDeSeguridad
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarGeneradores()
            _crIngresoGeneradores.SetDataSource(_objGeneradores.SeleccionarIngresosGeneradores(_tipoCon))
            _crIngresoGeneradores.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoGeneradores
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarChalecos()
            _crIngresoChalecos.SetDataSource(_objChalecos.SeleccionarIngresosChaleco(_tipoCon))
            _crIngresoChalecos.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoChalecos
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub

        Private Sub CargarSoftware()
            _crIngresoSoftware.SetDataSource(_objSoftware.SeleccionarIngresosSoftware(_tipoCon))
            _crIngresoSoftware.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvDatos.ReportSource = _crIngresoSoftware
            crvDatos.Zoom(75)
            crvDatos.Refresh()
        End Sub
        Private Sub cbmTipoActivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmTipoActivo.SelectedIndexChanged
            If cbmTipoActivo.Text = "MUEBLES DE OFICINA" Then
                CargarMueblesOficina()
            End If
            If cbmTipoActivo.Text = "ARMAS" Then
                CargarArmas()
            End If
            If cbmTipoActivo.Text = "RADIOS" Then
                CargarRadios()
            End If
            If cbmTipoActivo.Text = "VEHICULOS" Then
                CargarVehiculos()
            End If
            If cbmTipoActivo.Text = "TERRENOS" Then
                CargarTerrenos()
            End If
            If cbmTipoActivo.Text = "EQUIPOS DE COMPUTO" Then
                CargarEquiposDeComputo()
            End If
            If cbmTipoActivo.Text = "LIBROS Y COLECCIONES" Then
                CargarLibroYColecciones()
            End If
            If cbmTipoActivo.Text = "EQUIPOS DE OFICINA" Then
                CargarEquiposDeOficina()
            End If
            If cbmTipoActivo.Text = "EQUIPOS DE COCINA" Then
                CargarEquiposDeCocina()
            End If
            If cbmTipoActivo.Text = "EQUIPOS DE AMBIENTACION" Then
                CargarEquiposDeAmbientación()
            End If
            If cbmTipoActivo.Text = "EQUIPOS DE COMUNICACION Y TELEFONIA" Then
                CargarEquiposDeComunicacion()
            End If
            If cbmTipoActivo.Text = "EQUIPOS DE SEGURIDAD INDUSTRIAL" Then
                CargarEquiposDeSeguridad()
            End If
            If cbmTipoActivo.Text = "CAMARAS DE SEGURIDAD" Then
                CargarCamarasDeSeguridad()
            End If
            If cbmTipoActivo.Text = "GENERADORES" Then
                CargarGeneradores()
            End If
            If cbmTipoActivo.Text = "CHALECOS" Then
                CargarChalecos()
            End If
            If cbmTipoActivo.Text = "SOFTWARE" Then
                CargarSoftware()
            End If
        End Sub

        Private Sub FormReporteIngresosActivosFijos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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