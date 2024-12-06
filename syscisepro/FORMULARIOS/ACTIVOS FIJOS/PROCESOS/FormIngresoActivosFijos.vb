Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.DEPRECIACIONES
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.TIPOS_DE_ACTIVOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.PROVEEDORES
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ESTRUCTURA_EMPRESA
Imports ClassLibraryCisepro.INVENTARIOS.PARAMETROS
Imports ClassLibraryCisepro.JERARQUIAS_DE_ACTIVOS
Imports ClassLibraryCisepro.ProcesosSql
Imports ClassLibraryCisepro.TALENTO_HUMANO
Imports ClassLibraryCisepro.VALIDACIONES
Imports ClassLibraryCisepro.VALIDACIONES.VEHICULOS
Imports syscisepro.FORMULARIOS.INVENTARIOS.PROCESO
Imports ClassLibraryCisepro.DIVISION_GEOGRÁFICA
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports System.Diagnostics
Imports System.IO
Imports Krypton.Toolkit
Imports ClassLibraryCisepro.USUARIOS_DEL_SISTEMA
Imports ReaLTaiizor.Controls
Imports System.Windows.Forms
Imports System.Drawing
Imports syscisepro.DATOS
Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormIngresoActivosFijos

        Private _tipoCon As TipoConexion
        Property TipoCox As Integer
            Private Get
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

        Public _sqlCommands As List(Of SqlCommand)
        Public IdUsuario As Integer

        ReadOnly _objetoCategoria As New ClassCategoria
        ReadOnly _objetoGrupo As New ClassGrupo
        ReadOnly _objetoSubGrupo As New ClassSubGrupo
        ReadOnly _objetoSecuencial As New ClassSecuencial
        ReadOnly _objetoEmpresa As New ClassEmpresa
        ReadOnly _objetoSucursal As New ClassSucursal
        ReadOnly _objetoGerencias As New ClassGerenciasGeneral
        ReadOnly _objetoArea As New ClassArea
        ReadOnly _objetoMaterial As New ClassMaterial
        ReadOnly _objetoMarca As New ClassMarca
        ReadOnly _objetoColor As New ClassColor
        ReadOnly _objetoActivoFijo As New ClassActivoFijo
        ReadOnly _objetoSitio As New ClassSitiosTrabajo
        ReadOnly _objetoAuditoria As New ClassAuditoriaGeneral


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
        ReadOnly _objetoGenerador As New ClassGeneradores
        ReadOnly _objetoChaleco As New ClassChalecos
        ReadOnly _objetoSoftware As New ClassSoftware


        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objDepreciacion As New ClassDepreciaciones
        ReadOnly _objDetalleDepreciacion As New ClassDetalleDepreciaciones
        ReadOnly _objHistorialVehiculos As New ClassHistorialVehiculos
        ReadOnly _objProveedor As New ClassProveedores
        ReadOnly _objPersonal As New ClassPersonal

        ReadOnly _objUser As New ClassUsuarioGeneral
        ReadOnly _validacionesNumeros As New ClassNumerico
        ReadOnly _validacionesDecimal As New ClassDecimal
        ReadOnly _validacionesAlfanumerica As New ClassAlfanumerico


        Dim _formDialogoNuevoActivo As FormDialogoNuevoActivo
        Public _tipoAccion As Integer
        Public EsDialogo As Boolean


        Dim _porcentajeDepreciacion As Decimal
        Dim _valorDepreciacion As Decimal
        Public pdfFilePath As String
        Public UserName As String




        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            Hide()
            _formDialogoNuevoActivo = New FormDialogoNuevoActivo
            _formDialogoNuevoActivo.TipoCox = TipoCox
            If _formDialogoNuevoActivo.ShowDialog() = DialogResult.OK Then
                Select Case _formDialogoNuevoActivo.Tipo
                    Case 0 : HabilitarCamposArmas(True, True)
                    Case 1 : HabilitarCamposRadios(True, True)
                    Case 2 : HabilitarCamposVehiculos(True, True)
                    Case 3 : HabilitarCamposTerrenos(True, True)
                    Case 4 : HabilitarCamposEquiposComputo(True, True)
                    Case 5 : HabilitarCamposLibrosyColecciones(True, True)
                    Case 6 : HabilitarCamposEquiposOficina(True, True)
                    Case 7 : HabilitarCamposMueblesOficina(True, True)
                    Case 8 : HabilitarCamposEquiposCocina(True, True)
                    Case 9 : HabilitarCamposEquiposAmbientación(True, True)
                    Case 10 : HabilitarCamposEquiposComunicacion(True, True)
                    Case 11 : HabilitarCamposEquiposSeguridad(True, True)
                    Case 12 : HabilitarCamposCamarasSeguridad(True, True)
                    Case 13 : HabilitarCamposGeneradores(True, True)
                    Case 14 : HabilitarCamposChalecos(True, True)
                    Case 15 : HabilitarCamposSoftware(True, True)
                    Case Else
                        Show()

                        KryptonMessageBox.Show("DEBE SELECCIONAR UN TIPO DE ACTIVO!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        Return
                End Select

                AutocompletarNombreProveedor()
                AutocompletarPersonal()
                AutocompletarResponsable()

                LlenarComboEmpresa()
                LlenarComboArea()
                LlenarComboGerencias()

                CargarCategoria()

                LlenarComboCuentasActivo()
                LlenarComboCuentasDepreciaciones()
                LlenarComboCuentasGastos()

                HabiLitarParametrosActivos(True, True)
                tcVarios.SelectedIndex = _formDialogoNuevoActivo.Tipo
                tcVarios1.SelectedIndex = _formDialogoNuevoActivo.Tipo

                btnNuevo.Enabled = False
                btnGuardar.Enabled = True
                ButtonCancelar.Enabled = True

                'txtIdActivoFijo.Text = "AUTO"

                Text = _formDialogoNuevoActivo.Titulo
                txtAdicionalChaleco.Text = "Decision 584 Art. 11 Literal C. Decreto Ejecutivo 2393 Art. 11 Numeral 3, Art. 176"
                _tipoAccion = 1
            End If
            _formDialogoNuevoActivo.Close()
            Show()
            dtpFechaAdquisicion.Value = DateTime.Now
            dtpAceptacionMatricula.Value = DateTime.Now
            dtpCaducidadMatricula.Value = DateTime.Now
            dtpAceptacionTenencia.Value = DateTime.Now
            dtpCaducidadTenencia.Value = DateTime.Now
        End Sub

        Public Sub HabilitarCamposArmas(ByVal enable As Boolean, ByVal clear As Boolean)
            txtPermisoFuncionamiento.Enabled = enable
            txtPermisoComandoConjunto.Enabled = enable
            txtSerieArmas.Enabled = enable

            txtNroTenenciaArmas.Enabled = enable
            txtNroMatriculaArma.Enabled = enable
            cbxOrigen.Enabled = enable

            dtpAceptacionTenencia.Enabled = enable
            dtpCaducidadTenencia.Enabled = enable
            dtpAceptacionMatricula.Enabled = enable
            dtpCaducidadMatricula.Enabled = enable

            btnAgregarArma.Enabled = enable
            btnEliminarArma.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return

            txtPermisoFuncionamiento.Clear()
            txtPermisoComandoConjunto.Clear()
            cbxOrigen.SelectedIndex = 0
            txtSerieArmas.Clear()
            txtNroTenenciaArmas.Clear()
            txtNroMatriculaArma.Clear()
            dgvArmas.Rows.Clear()

            lblArmasCount.Text = "Verifique las series antes de guardar!!"
        End Sub

        Public Sub HabilitarCamposRadios(ByVal enable As Boolean, ByVal clear As Boolean)
            cbmMarcaRadio.Enabled = enable
            txtModeloRadio.Enabled = enable
            txtSerieRadio.Enabled = enable
            cbmColoresRadio.Enabled = enable
            cbmEstadoRadio.Enabled = enable
            txtNumeroPermisoUsoRadio.Enabled = enable
            dtpFecPerUsoRadioAceptacion.Enabled = enable
            dtpFecPerRadioCaducidad.Enabled = enable
            txtGarantia.Enabled = enable
            chkGarantiaRadio.Enabled = enable
            btnGarantiaRadio.Enabled = enable
            btnAddRadio.Enabled = enable
            btnDelRadio.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtModeloRadio.Clear()
            txtSerieRadio.Clear()
            txtNumeroPermisoUsoRadio.Clear()
            cbmEstadoRadio.SelectedIndex = 0
            LlenarComboMarcasRadio()
            LlenarComboColoresRadio()

            dgvRadios.Rows.Clear()

            lblRadiosCount.Text = "Verifique las series antes de guardar!!"
        End Sub

        Public Sub HabilitarCamposVehiculos(ByVal enable As Boolean, ByVal clear As Boolean)
            dtpSoat.Enabled = enable
            txtPlacaVehiculo.Enabled = enable
            txtSerieVehiculo.Enabled = enable
            txtChasisVehiculo.Enabled = enable
            txtMotorVehiculo.Enabled = enable
            txtTipoVehiculo.Enabled = enable
            txtCilindrajeVehiculo.Enabled = enable
            txtCapacidadVehiculo.Enabled = enable
            txtModeloVehiculo.Enabled = enable
            cbmMarcaVehiculo.Enabled = enable
            cbmColorVehiculo.Enabled = enable
            cbmEstadoVehiculo.Enabled = enable
            cbmAnoFabricacionVehiculo.Enabled = enable
            chNingunSeguro.Enabled = enable
            chNingunDispositivo.Enabled = enable
            txtAseguradoraNombre.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtPlacaVehiculo.Clear()
            txtSerieVehiculo.Clear()
            txtChasisVehiculo.Clear()
            txtMotorVehiculo.Clear()
            txtTipoVehiculo.Clear()
            txtCilindrajeVehiculo.Clear()
            txtCapacidadVehiculo.Clear()
            txtModeloVehiculo.Clear()
            chNingunSeguro.Checked = False
            chNingunDispositivo.Checked = False

            cbmEstadoVehiculo.SelectedIndex = 0
            LlenarComboMarcasVehiculos()
            LlenarComboColoresVehiculos()
            cbmAnoFabricacionVehiculo.Items.Clear()
            For aniosFabricacion = 1990 To Date.Now.Year Step 1
                cbmAnoFabricacionVehiculo.Items.Add(aniosFabricacion)
            Next
            cbmAnoFabricacionVehiculo.SelectedIndex = cbmAnoFabricacionVehiculo.Items.Count - 1
            chNingunSeguro_CheckedChanged(Nothing, Nothing)
            chNingunDispositivo_CheckedChanged(Nothing, Nothing)
        End Sub

        Public Sub HabilitarCamposTerrenos(ByVal enable As Boolean, ByVal clear As Boolean)
            txtMedidaTerreno.Enabled = enable
            txtUbicacionTerreno.Enabled = enable
            txtEstadoTerreno.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtMedidaTerreno.Clear()
            txtUbicacionTerreno.Clear()
            txtEstadoTerreno.Clear()
        End Sub

        Public Sub HabilitarCamposEquiposComputo(ByVal enable As Boolean, ByVal clear As Boolean)
            cbmMarcaEquipoComputo.Enabled = enable
            txtModeloEquipoComputo.Enabled = enable
            cbmEstadoEquipoComputo.Enabled = enable
            txtComponenteEquipoComputo.Enabled = enable
            cbmColorEquipoComputo.Enabled = enable
            btnAgregarEquipo.Enabled = enable
            btnEliminarEquipoComputo.Enabled = enable
            chkGarantiaComputo.Enabled = enable
            txtGarantiaComputo.Enabled = enable
            btnGarantiaComputo.Enabled = enable
            dtpCaducidadComputo.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtModeloEquipoComputo.Clear()
            txtComponenteEquipoComputo.Clear()
            cbmEstadoEquipoComputo.SelectedIndex = 0
            LlenarComboMarcasDeEquiposComputo()
            LlenarComboColoresEquiposDeComputo()
        End Sub

        Public Sub HabilitarCamposLibrosyColecciones(ByVal enable As Boolean, ByVal clear As Boolean)
            txtEditorial.Enabled = enable
            txtAutor.Enabled = enable
            txtTomos.Enabled = enable
            cbmAñosEdicionLibros.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtEditorial.Clear()
            txtAutor.Clear()
            txtTomos.Clear()
            cbmAñosEdicionLibros.Items.Clear()
            For aniosFabricacion = 1990 To Date.Now.Year Step 1
                cbmAñosEdicionLibros.Items.Add(aniosFabricacion)
            Next
            cbmAñosEdicionLibros.SelectedIndex = cbmAñosEdicionLibros.Items.Count - 1
        End Sub

        Public Sub HabilitarCamposEquiposOficina(ByVal enable As Boolean, ByVal clear As Boolean)
            cbmMarcaEquiposOficina.Enabled = enable
            txtModeloEquiposOficina.Enabled = enable
            cbmEstadoActivoEquiposOficina.Enabled = enable
            txtSerieEquiposOficina.Enabled = enable
            cbmColorEquiposOficina.Enabled = enable
            cbmMaterialEquiposOficina.Enabled = enable
            cbmAñosEquiposOficina.Enabled = enable
            btnAddEquipoOficina.Enabled = enable
            btnDelEquipoOficina.Enabled = enable
            chkGarantiaOficina.Enabled = enable
            txtGarantiaOficina.Enabled = enable
            btnGarantiaOficina.Enabled = enable
            dtpCaducidadOficina.Enabled = enable
            ' LIMPIAR
            If Not clear Then Return
            txtModeloEquiposOficina.Clear()
            txtSerieEquiposOficina.Clear()
            cbmEstadoActivoEquiposOficina.SelectedIndex = 0
            LlenarComboMarcasDeEquiposOficina()
            LlenarComboColoresEquiposDeOficina()
            LlenarComboMaterialEquiposDeOficina()
            cbmAñosEquiposOficina.Items.Clear()
            For aniosFabricacion = 1990 To Date.Now.Year Step 1
                cbmAñosEquiposOficina.Items.Add(aniosFabricacion)
            Next
            cbmAñosEquiposOficina.SelectedIndex = cbmAñosEquiposOficina.Items.Count - 1

            dgvEquiposOficina.Rows.Clear()

            lblEquiposOficinaCount.Text = "Verifique las series antes de guardar!!"
        End Sub

        Public Sub HabilitarCamposMueblesOficina(ByVal enable As Boolean, ByVal clear As Boolean)
            cbmMarcaMueblesOficina.Enabled = enable
            txtModeloMueblesOficina.Enabled = enable
            cbmEstadoActivoMueblesOficina.Enabled = enable
            cbmColorMueblesOficina.Enabled = enable
            cbmMaterialMueblesOficina.Enabled = enable
            cbmAñosMueblesOficina.Enabled = enable

            btnAddMuebleOficina.Enabled = enable
            btnDelMuebleOficina.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtModeloMueblesOficina.Clear()
            cbmEstadoActivoMueblesOficina.SelectedIndex = 0
            LlenarComboMarcasDeMueblesOficina()
            LlenarComboColoresMueblesOficina()
            LlenarComboMaterialMueblesOficina()
            cbmAñosMueblesOficina.Items.Clear()
            For aniosFabricacion = 1990 To Date.Now.Year Step 1
                cbmAñosMueblesOficina.Items.Add(aniosFabricacion)
            Next
            cbmAñosMueblesOficina.SelectedIndex = cbmAñosMueblesOficina.Items.Count - 1

            dgvMuebleOficina.Rows.Clear()

            lblMuebleOficinaCount.Text = "Verifique las series antes de guardar!!"
        End Sub

        Public Sub HabilitarCamposEquiposCocina(ByVal enable As Boolean, ByVal clear As Boolean)
            cbmMarcaEquiposCocina.Enabled = enable
            txtModeloEquiposCocina.Enabled = enable
            cbmEstadoEquiposCocina.Enabled = enable
            txtSerieEquiposCocina.Enabled = enable
            cbmColorEquiposCocina.Enabled = enable
            cbmMaterialEquiposCocina.Enabled = enable
            cbmAñosEquiposCocina.Enabled = enable

            btnAddEquipoCocina.Enabled = enable
            btnDellEquipoCocina.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtModeloEquiposCocina.Clear()
            txtSerieEquiposCocina.Clear()
            cbmEstadoEquiposCocina.SelectedIndex = 0
            LlenarComboMarcasDeEquiposCocina()
            LlenarComboColoresEquiposDeCocina()
            LlenarComboMaterialEquiposDeCocina()
            cbmAñosEquiposCocina.Items.Clear()
            For aniosFabricacion = 1990 To Date.Now.Year Step 1
                cbmAñosEquiposCocina.Items.Add(aniosFabricacion)
            Next
            cbmAñosEquiposCocina.SelectedIndex = cbmAñosEquiposCocina.Items.Count - 1

            dgvEquipoCocina.Rows.Clear()

            lblEquipoCocinaCount.Text = "Verifique las series antes de guardar!!"
        End Sub

        Public Sub HabilitarCamposEquiposAmbientación(ByVal enable As Boolean, ByVal clear As Boolean)
            cbmMarcaEquiposAmbientacion.Enabled = enable
            txtModeloEquiposAmbientacion.Enabled = enable
            cbmEstadoEquiposAmbientacion.Enabled = enable
            txtSerieEquiposAmbientacion.Enabled = enable
            cbmColorEquiposAmbientacion.Enabled = enable
            cbmMaterialEquiposAmbientacion.Enabled = enable
            cbmAñosEquiposAmbientacion.Enabled = enable
            txtAmperajeEquiposAmbientacion.Enabled = enable
            txtVoltajeEquiposAmbientacion.Enabled = enable
            txtTipoEquiposAmbientacion.Enabled = enable

            btnAddEquipoAmbientacion.Enabled = enable
            btnDelEquipoAmbientacion.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtModeloEquiposAmbientacion.Clear()
            txtSerieEquiposAmbientacion.Clear()
            txtAmperajeEquiposAmbientacion.Clear()
            txtVoltajeEquiposAmbientacion.Clear()
            txtTipoEquiposAmbientacion.Clear()
            cbmEstadoEquiposAmbientacion.SelectedIndex = 0
            LlenarComboMarcasDeEquiposAbientacion()
            LlenarComboColoresEquiposAbientacion()
            LlenarComboMaterialEquiposAbientacion()
            cbmAñosEquiposAmbientacion.Items.Clear()
            For aniosFabricacion = 1990 To Date.Now.Year Step 1
                cbmAñosEquiposAmbientacion.Items.Add(aniosFabricacion)
            Next
            cbmAñosEquiposAmbientacion.SelectedIndex = cbmAñosEquiposAmbientacion.Items.Count - 1

            dgvEquipoAmbientacion.Rows.Clear()

            lblEquipoAmbientacionCount.Text = "Verifique las series antes de guardar!!"
        End Sub

        Public Sub HabilitarCamposEquiposComunicacion(ByVal enable As Boolean, ByVal clear As Boolean)
            cbmMarcaEquiposComunicacion.Enabled = enable
            txtModeloEquiposComunicacion.Enabled = enable
            cbmEstadoEquiposComunicacion.Enabled = enable
            txtSerieEquiposComunicacion.Enabled = enable
            cbmColorEquiposComunicacion.Enabled = enable
            cbmMaterialEquiposComunicacion.Enabled = enable
            cbmAñosEquiposComunicacion.Enabled = enable
            dtpInicioPermisoFrecuencia.Enabled = enable
            dtpFinaLPermisoFrecuencia.Enabled = enable

            btnAddEquipoComunicacion.Enabled = enable
            btnDelEquipoComunicacion.Enabled = enable

            chkGarantiaComunicacion.Enabled = enable
            txtGarantiaComunicacion.Enabled = enable
            btnGarantiaComunicacion.Enabled = enable


            ' LIMPIAR
            If Not clear Then Return
            txtModeloEquiposComunicacion.Clear()
            txtSerieEquiposComunicacion.Clear()
            cbmEstadoEquiposComunicacion.SelectedIndex = 0
            LlenarComboMarcasDeEquiposComunicacion()
            LlenarComboColoresEquiposComunicacion()
            LlenarComboMaterialEquiposComunicacion()
            cbmAñosEquiposComunicacion.Items.Clear()
            For aniosFabricacion = 1990 To Date.Now.Year Step 1
                cbmAñosEquiposComunicacion.Items.Add(aniosFabricacion)
            Next
            cbmAñosEquiposComunicacion.SelectedIndex = cbmAñosEquiposComunicacion.Items.Count - 1

            dgvEquipoComunicacion.Rows.Clear()

            lblEquipoComunicacionCount.Text = "Verifique las series antes de guardar!!"
        End Sub

        Public Sub HabilitarCamposEquiposSeguridad(ByVal enable As Boolean, ByVal clear As Boolean)
            cbmMarcaEquipoSeguridad.Enabled = enable
            txtModeloEquipoSeguridad.Enabled = enable
            cbmEstadoEquipoSeguridad.Enabled = enable
            txtSerieEquipoSeguridad.Enabled = enable
            cbmColorEquipoSeguridad.Enabled = enable
            cbmMaterialEquipoSeguridad.Enabled = enable
            cbmAñosEquipoSeguridad.Enabled = enable
            txtAdicionalEquipoSeguridad.Enabled = enable

            btnAddEquipoSeguridad.Enabled = enable
            btnDelEquipoSeguridad.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtModeloEquipoSeguridad.Clear()
            txtSerieEquipoSeguridad.Clear()
            txtAdicionalEquipoSeguridad.Clear()
            cbmEstadoEquipoSeguridad.SelectedIndex = 0
            LlenarComboMarcasEquiposSeguridad()
            LlenarComboColoresEquiposSeguridad()
            LlenarComboMaterialesEquiposSeguridad()
            cbmAñosEquipoSeguridad.Items.Clear()
            For aniosFabricacion = 1990 To Date.Now.Year Step 1
                cbmAñosEquipoSeguridad.Items.Add(aniosFabricacion)
            Next
            cbmAñosEquipoSeguridad.SelectedIndex = cbmAñosEquipoSeguridad.Items.Count - 1

            dgvEquipoSeguridad.Rows.Clear()

            lblEquipoSeguridadCount.Text = "Verifique las series antes de guardar!!"
        End Sub

        Public Sub HabilitarCamposCamarasSeguridad(ByVal enable As Boolean, ByVal clear As Boolean)
            cbmMarcaCamarasSeguridad.Enabled = enable
            txtModeloCamarasSeguridad.Enabled = enable
            cbmEstadoCamarasSeguridad.Enabled = enable
            txtSerieCamarasSeguridad.Enabled = enable
            cbmColorCamarasSeguridad.Enabled = enable
            cbmMaterialCamarasSeguridad.Enabled = enable
            cbmAñosCamarasSeguridad.Enabled = enable
            txtAdicionalCamarasSeguridad.Enabled = enable

            btnAddCamara.Enabled = enable
            btnDelCamara.Enabled = enable

            chkGarantiaCamara.Enabled = enable
            txtGarantiaCamara.Enabled = enable
            btnGarantiaCamara.Enabled = enable
            dtpCaducidadCamara.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtModeloCamarasSeguridad.Clear()
            txtSerieCamarasSeguridad.Clear()
            txtAdicionalCamarasSeguridad.Clear()
            cbmEstadoCamarasSeguridad.SelectedIndex = 0
            LlenarComboMarcasCamaras()
            LlenarComboColoresCamaras()
            LlenarComboMaterialesCamaras()
            cbmAñosCamarasSeguridad.Items.Clear()
            For aniosFabricacion = 1990 To Date.Now.Year Step 1
                cbmAñosCamarasSeguridad.Items.Add(aniosFabricacion)
            Next
            cbmAñosCamarasSeguridad.SelectedIndex = cbmAñosCamarasSeguridad.Items.Count - 1

            dgvCamara.Rows.Clear()

            lblCamaraCount.Text = "Verifique las series antes de guardar!!"
        End Sub

        Public Sub HabilitarCamposGeneradores(ByVal enable As Boolean, ByVal clear As Boolean)
            cbmMarcaGeneradores.Enabled = enable
            txtModeloGeneradores.Enabled = enable
            cbmEstadoGeneradores.Enabled = enable
            txtSerieGeneradores.Enabled = enable
            cbmColorGeneradores.Enabled = enable
            cbmMaterialGeneradores.Enabled = enable
            cbmAñosGeneradores.Enabled = enable
            txtAmperajeGeneradores.Enabled = enable
            txtVoltajeGeneradores.Enabled = enable
            txtTipoGeneradores.Enabled = enable
            txtAdicionalGeneradores.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtModeloGeneradores.Clear()
            txtSerieGeneradores.Clear()
            txtAmperajeGeneradores.Clear()
            txtVoltajeGeneradores.Clear()
            txtTipoGeneradores.Clear()
            txtAdicionalGeneradores.Clear()
            cbmEstadoGeneradores.SelectedIndex = 0
            LlenarComboMarcasGeneradores()
            LlenarComboColoresGeneradores()
            LlenarComboMaterialesGeneradores()
            cbmAñosGeneradores.Items.Clear()
            For aniosFabricacion = 1990 To Date.Now.Year Step 1
                cbmAñosGeneradores.Items.Add(aniosFabricacion)
            Next
            cbmAñosGeneradores.SelectedIndex = cbmAñosGeneradores.Items.Count - 1
        End Sub

        Public Sub HabilitarCamposChalecos(ByVal enable As Boolean, ByVal clear As Boolean)
            cbmMarcaChaleco.Enabled = enable
            txtModeloChaleco.Enabled = enable
            cbmEstadoChaleco.Enabled = enable
            txtSerieChaleco.Enabled = enable
            cbmColorChaleco.Enabled = enable
            cbmMaterialChaleco.Enabled = enable
            cbmAñosChaleco.Enabled = enable
            dtpCaducidadChaleco.Enabled = enable
            txtAdicionalChaleco.Enabled = enable
            chkGarantiaChaleco.Enabled = enable
            txtGarantiaChaleco.Enabled = enable
            btnGarantiaChaleco.Enabled = enable
            btnAddChaleco.Enabled = enable
            btnDelChaleco.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtModeloChaleco.Clear()
            txtSerieChaleco.Clear()
            txtAdicionalChaleco.Clear()
            cbmEstadoChaleco.SelectedIndex = 0
            LlenarComboMarcasChalecos()
            LlenarComboColoresChalecos()
            LlenarComboMaterialesChalecos()
            cbmAñosChaleco.Items.Clear()
            txtGarantiaChaleco.Clear()
            For aniosFabricacion = 1990 To Date.Now.Year Step 1
                cbmAñosChaleco.Items.Add(aniosFabricacion)
            Next
            cbmAñosChaleco.SelectedIndex = cbmAñosChaleco.Items.Count - 1

            dgvChaleco.Rows.Clear()

            lblChalecoCount.Text = "Verifique las series antes de guardar!!"
        End Sub

        Public Sub HabilitarCamposSoftware(ByVal enable As Boolean, ByVal clear As Boolean)
            txtDetalleSoftware.Enabled = enable
            txtVersionSoftware.Enabled = enable
            txtProvedorSoftware.Enabled = enable
            cbmTipoSoftware.Enabled = enable

            ' LIMPIAR
            If Not clear Then Return
            txtDetalleSoftware.Clear()
            txtVersionSoftware.Clear()
            txtProvedorSoftware.Clear()
        End Sub

        Public Sub HabiLitarParametrosActivos(ByVal enable As Boolean, ByVal clear As Boolean)
            cbmCategoria.Enabled = enable
            cbmGrupo.Enabled = enable
            cbmSubGrupo.Enabled = enable
            cbmSecuencial.Enabled = enable
            cbmEstadoActivoActual.Enabled = enable
            cbmMantenimiento.Enabled = enable
            dtpFechaActual.Enabled = enable
            txtResponsable.Enabled = enable
            bntPuesto.Enabled = enable
            dtpFechaMantenimiento.Enabled = enable

            cbEmpresa.Enabled = enable
            cbArea.Enabled = enable
            cbgerencias.Enabled = enable
            cbSucursal.Enabled = enable
            txtCarpeta.Enabled = enable
            txtContrato.Enabled = enable
            txtNombreActivo.Enabled = enable
            txtNombreProvedor.Enabled = enable
            txtNombreCustodio.Enabled = enable

            'GroupBox2.Enabled = enable
            'GroupBox6.Enabled = enable

            gbxInformacion.Enabled = enable
            gbxDatos.Enabled = enable
            gbxContabilidad.Enabled = enable

            txtSitio.Text = _objetoSitio.BuscarNombreSitioxIdSitio(_tipoCon, 1, True)
            txtSitio.Tag = 1


            ' LIMPIAR
            If Not clear Then Return
            'txtIdActivoFijo.Clear()
            txtResponsable.Clear()
            txtCarpeta.Clear()
            txtContrato.Clear()
            txtNombreActivo.Clear()
            txtNombreProvedor.Clear()
            txtNombreCustodio.Clear()
            txtCodigoArancel.Clear()
            txtOrdenCompra.Clear()
            txtValorFactura.Clear()
            txtValorAdicional.Clear()
            txtValorResidual.Clear()
            txtAñosVidaUtil.Clear()
            cbmEstadoActivoActual.SelectedIndex = 0
            cbmMantenimiento.SelectedIndex = 0
            pdfFilePath = String.Empty


        End Sub

        Private Sub bntPuesto_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles bntPuesto.Click
            Dim frm As New FrmBuscarPuestoTrabajo
            frm.TipoCox = TipoCox
            frm.Label3.Text = "TODOS LOS PUESTOS REGISTRADOS"
            frm.Text = "BUSCAR SITIOS DE TRABAJO"
            Try
                If frm.ShowDialog <> DialogResult.OK Then Return
                txtSitio.Tag = frm.ListView1.SelectedItems(0).SubItems(0).Text
                txtSitio.Text = frm.ListView1.SelectedItems(0).SubItems(2).Text.Trim & " (" & frm.ListView1.SelectedItems(0).Group.Header.Trim & ")"
            Catch
                txtSitio.Tag = Nothing
                txtSitio.Text = "NO SE HA DEFINIDO LOS DATOS DEL PUESTO"
            End Try
        End Sub

        Public Sub CargarCategoria()
            Try
                cbmCategoria.DataSource = _objetoCategoria.CargarDatosCategoria(_tipoCon)
                cbmCategoria.DisplayMember = "NOMBRE_CATEGORIA"
                cbmCategoria.ValueMember = "ID_CATEGORIA"
                If (CType(cbmCategoria.DataSource, DataTable).Rows.Count > 0) Then cbmCategoria.SelectedValue = 1
            Catch
                cbmCategoria.DataSource = Nothing
            End Try
        End Sub

        Private Sub cbmCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCategoria.SelectedValueChanged
            If cbmCategoria.SelectedValue Is Nothing Or TypeOf cbmCategoria.SelectedValue Is DataRowView Then Return
            Try
                cbmGrupo.DataSource = _objetoGrupo.BuscarNombresGrupoPorId(_tipoCon, cbmCategoria.SelectedValue)
                cbmGrupo.DisplayMember = "NOMBRE_GRUPO"
                cbmGrupo.ValueMember = "ID_GRUPO"
                If (CType(cbmGrupo.DataSource, DataTable).Rows.Count > 0) Then cbmGrupo.SelectedIndex = 0
            Catch
                cbmGrupo.DataSource = Nothing
            End Try
        End Sub

        Private Sub cbmGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmGrupo.SelectedValueChanged
            If cbmGrupo.SelectedValue Is Nothing Or TypeOf cbmGrupo.SelectedValue Is DataRowView Then Return
            Try
                cbmSubGrupo.DataSource = _objetoSubGrupo.BuscarNombresSubGrupoPorIdGrupo(_tipoCon, cbmGrupo.SelectedValue)
                cbmSubGrupo.DisplayMember = "NOMBRE_SUB_GRUPO"
                cbmSubGrupo.ValueMember = "ID_SUB_GRUPO"
                If (CType(cbmSubGrupo.DataSource, DataTable).Rows.Count > 0) Then cbmSubGrupo.SelectedIndex = 0
            Catch
                cbmSubGrupo.DataSource = Nothing
            End Try
        End Sub

        Private Sub cbmSubGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmSubGrupo.SelectedValueChanged
            If cbmSubGrupo.SelectedValue Is Nothing Or TypeOf cbmSubGrupo.SelectedValue Is DataRowView Then Return
            Try
                cbmSecuencial.DataSource = _objetoSecuencial.BuscarNombreSecuencialPorIdSub(_tipoCon, cbmSubGrupo.SelectedValue)
                cbmSecuencial.DisplayMember = "NOMBRE_SECUENCIAL"
                cbmSecuencial.ValueMember = "ID_SECUENCIAL"
                If (CType(cbmSecuencial.DataSource, DataTable).Rows.Count > 0) Then cbmSecuencial.SelectedIndex = 0
            Catch
                cbmSecuencial.DataSource = Nothing
            End Try
        End Sub

        Private Function GenerarCodigoActivo(ByVal tipo As Integer) As String
            Try
                Dim cc = _objetoCategoria.BuscarCodigoCategoriaPorNombreCategoria(_tipoCon, cbmCategoria.Text.Trim())
                Dim cg = _objetoGrupo.BuscarCodigoGrupoPorNombreGrupo(_tipoCon, cbmGrupo.Text.Trim())
                Dim cs = _objetoSubGrupo.BuscarCodigoGrupoPorNombreGrupo(_tipoCon, cbmSubGrupo.Text.Trim())
                Dim cx = _objetoSecuencial.BuscarCodigoSecuencialPorNombre(_tipoCon, cbmSecuencial.Text.Trim())
                Dim codigo = (cc & "." & cg & "." & cs & "." & cx).ToString().Trim

                Select Case tipo
                    Case 0 : codigo += "." + txtSerieArmas.Text.ToUpper.Trim()
                    Case 1 : codigo += "." + txtSerieRadio.Text.ToUpper.Trim()
                    Case 2 : codigo += "." + txtPlacaVehiculo.Text.ToUpper.Trim()
                    Case 4 : codigo += String.Empty
                    Case 6 : codigo += "." + txtSerieEquiposOficina.Text.ToUpper.Trim()
                    Case 8 : codigo += "." + txtSerieEquiposCocina.Text.ToUpper.Trim()
                    Case 9 : codigo += "." + txtSerieEquiposAmbientacion.Text.ToUpper.Trim()
                    Case 10 : codigo += "." + txtSerieEquiposComunicacion.Text.ToUpper.Trim()
                    Case 11 : codigo += "." + txtSerieEquipoSeguridad.Text.ToUpper.Trim()
                    Case 12 : codigo += "." + txtSerieCamarasSeguridad.Text.ToUpper.Trim()
                    Case 13 : codigo += "." + txtSerieGeneradores.Text.ToUpper.Trim()
                    Case 14 : codigo += "." + txtSerieChaleco.Text.ToUpper.Trim()
                    Case Else
                        codigo += String.Empty
                End Select
                If codigo.Trim().EndsWith(".") Then codigo = codigo.Substring(0, codigo.Length - 1)
                Return codigo
            Catch
                Return String.Empty
            End Try
        End Function

        Public Sub LlenarComboEmpresa()
            Try
                cbEmpresa.DataSource = _objetoEmpresa.SeleccionarTodosLosRegistrosEmpresa(_tipoCon)
                cbEmpresa.DisplayMember = "NOMBRE_COMERCIAL_EMPRESA"
                cbEmpresa.ValueMember = "ID_EMPRESA"
                If (CType(cbEmpresa.DataSource, DataTable).Rows.Count > 0) Then cbEmpresa.SelectedIndex = 0
            Catch
                cbEmpresa.DataSource = Nothing
            End Try
        End Sub

        Private Sub cbEmpresa_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbEmpresa.SelectedValueChanged
            If cbEmpresa.SelectedValue Is Nothing Or TypeOf cbEmpresa.SelectedValue Is DataRowView Then Return
            Try
                cbSucursal.DataSource = _objetoSucursal.SeleccionarTodosLosRegistrosSucursal(_tipoCon)
                cbSucursal.DisplayMember = "NOMBRE_SUCURSAL"
                cbSucursal.ValueMember = "ID_SUCURSAL"
                If (CType(cbSucursal.DataSource, DataTable).Rows.Count > 0) Then cbSucursal.SelectedIndex = 0
            Catch
                cbSucursal.DataSource = Nothing
            End Try
        End Sub

        Public Sub LlenarComboArea()
            Try
                cbArea.DataSource = _objetoArea.SeleccionarTodosLosRegistrosArea(_tipoCon)
                cbArea.DisplayMember = "NOMBRE_AREA"
                cbArea.ValueMember = "ID_AREA_GENERAL"
                If (CType(cbArea.DataSource, DataTable).Rows.Count > 0) Then cbArea.SelectedIndex = 0
            Catch
                cbArea.DataSource = Nothing
            End Try
        End Sub

        Public Sub LlenarComboGerencias()
            Try
                cbgerencias.DataSource = _objetoGerencias.SeleccionarTodosLosRegistrosGerenciasGeneral(_tipoCon)
                cbgerencias.DisplayMember = "NOMBRE_GERENCIAS"
                cbgerencias.ValueMember = "ID_GERENCIAS_GENERAL"
                If (CType(cbgerencias.DataSource, DataTable).Rows.Count > 0) Then cbgerencias.SelectedIndex = 0
            Catch
                cbgerencias.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMarcasRadio()
            Try
                cbmMarcaRadio.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarcaRadio.DisplayMember = "MARCA"
                cbmMarcaRadio.ValueMember = "ID"
                If (CType(cbmMarcaRadio.DataSource, DataTable).Rows.Count > 0) Then cbmMarcaRadio.SelectedIndex = 0
            Catch
                cbmMarcaRadio.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColoresRadio()
            Try
                cbmColoresRadio.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColoresRadio.DisplayMember = "COLOR"
                cbmColoresRadio.ValueMember = "ID"
                If (CType(cbmColoresRadio.DataSource, DataTable).Rows.Count > 0) Then cbmColoresRadio.SelectedIndex = 0
            Catch
                cbmColoresRadio.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMarcasVehiculos()
            Try
                cbmMarcaVehiculo.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarcaVehiculo.DisplayMember = "MARCA"
                cbmMarcaVehiculo.ValueMember = "ID"
                If (CType(cbmMarcaVehiculo.DataSource, DataTable).Rows.Count > 0) Then cbmMarcaVehiculo.SelectedIndex = 0
            Catch
                cbmMarcaVehiculo.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColoresVehiculos()
            Try
                cbmColorVehiculo.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColorVehiculo.DisplayMember = "COLOR"
                cbmColorVehiculo.ValueMember = "ID"
                If (CType(cbmColorVehiculo.DataSource, DataTable).Rows.Count > 0) Then cbmColorVehiculo.SelectedIndex = 0
            Catch
                cbmColorVehiculo.DataSource = Nothing
            End Try
        End Sub

        Private Sub chNingunSeguro_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chNingunSeguro.CheckedChanged
            If chNingunSeguro.Checked Then
                txtAseguradoraNombre.Text = "NO TIENE ASEGURADORA"
                txtSeguro.Text = "NO TIENE SEGURO"
                txtBroker.Text = "NO TIENE BROKER"
                txtNroPoliza.Text = "SIN POLIZA"
                txtCostoPrima.Text = "0"
                dtpFechaInicioContratoPoliza.Value = New DateTime(1990, 1, 1, 0, 0, 0)
                dtpFechaFinalContratoPoliza.Value = dtpFechaInicioContratoPoliza.Value
                dtpFechaRenovacionContratoPoliza.Value = dtpFechaInicioContratoPoliza.Value
                txtDispositivoSeguridad.Text = "SIN DISPOSITIVO DE SEGURIDAD"
                dtpInicioContratoDispositivoSeguridad.Value = dtpFechaInicioContratoPoliza.Value
                dtpFinalContratoDispositivoSeguridad.Value = dtpFechaInicioContratoPoliza.Value
                dtpRenovacionContratoDispositivoSeguridad.Value = dtpFechaInicioContratoPoliza.Value
            Else
                txtAseguradoraNombre.Clear()
                txtSeguro.Clear()
                txtBroker.Clear()
                txtNroPoliza.Clear()
                txtCostoPrima.Clear()
                dtpFechaInicioContratoPoliza.Value = dtpFechaActual.Value
                dtpFechaFinalContratoPoliza.Value = dtpFechaInicioContratoPoliza.Value
                dtpFechaRenovacionContratoPoliza.Value = dtpFechaInicioContratoPoliza.Value
                txtDispositivoSeguridad.Clear()
                dtpInicioContratoDispositivoSeguridad.Value = dtpFechaInicioContratoPoliza.Value
                dtpFinalContratoDispositivoSeguridad.Value = dtpFechaInicioContratoPoliza.Value
                dtpRenovacionContratoDispositivoSeguridad.Value = dtpFechaInicioContratoPoliza.Value
            End If
        End Sub

        Private Sub chNingunDispositivo_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles chNingunDispositivo.CheckedChanged
            If chNingunDispositivo.Checked Then
                txtDispositivoSeguridad.Text = "SIN DISPOSITIVO DE SEGURIDAD"
                dtpInicioContratoDispositivoSeguridad.Value = New DateTime(1990, 1, 1, 0, 0, 0)
                dtpFinalContratoDispositivoSeguridad.Value = dtpInicioContratoDispositivoSeguridad.Value
                dtpRenovacionContratoDispositivoSeguridad.Value = dtpInicioContratoDispositivoSeguridad.Value
            Else
                txtDispositivoSeguridad.Clear()
                dtpInicioContratoDispositivoSeguridad.Value = dtpFechaActual.Value
                dtpFinalContratoDispositivoSeguridad.Value = dtpInicioContratoDispositivoSeguridad.Value
                dtpRenovacionContratoDispositivoSeguridad.Value = dtpInicioContratoDispositivoSeguridad.Value
            End If
        End Sub

        Private Sub LlenarComboMarcasDeEquiposComputo()
            Try
                cbmMarcaEquipoComputo.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarcaEquipoComputo.DisplayMember = "MARCA"
                cbmMarcaEquipoComputo.ValueMember = "ID"
                If (CType(cbmMarcaEquipoComputo.DataSource, DataTable).Rows.Count > 0) Then cbmMarcaEquipoComputo.SelectedIndex = 0
            Catch
                cbmMarcaEquipoComputo.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColoresEquiposDeComputo()
            Try
                cbmColorEquipoComputo.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColorEquipoComputo.DisplayMember = "COLOR"
                cbmColorEquipoComputo.ValueMember = "ID"
                If (CType(cbmColorEquipoComputo.DataSource, DataTable).Rows.Count > 0) Then cbmColorEquipoComputo.SelectedIndex = 0
            Catch
                cbmColorEquipoComputo.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMarcasDeMueblesOficina()
            Try
                cbmMarcaMueblesOficina.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarcaMueblesOficina.DisplayMember = "MARCA"
                cbmMarcaMueblesOficina.ValueMember = "ID"
                If (CType(cbmMarcaMueblesOficina.DataSource, DataTable).Rows.Count > 0) Then cbmMarcaMueblesOficina.SelectedIndex = 0
            Catch
                cbmMarcaMueblesOficina.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColoresMueblesOficina()
            Try
                cbmColorMueblesOficina.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColorMueblesOficina.DisplayMember = "COLOR"
                cbmColorMueblesOficina.ValueMember = "ID"
                If (CType(cbmColorMueblesOficina.DataSource, DataTable).Rows.Count > 0) Then cbmColorMueblesOficina.SelectedIndex = 0
            Catch
                cbmColorMueblesOficina.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMaterialMueblesOficina()
            Try
                cbmMaterialMueblesOficina.DataSource = _objetoMaterial.SeleccionarTodosLosRegistrosMaterial(_tipoCon)
                cbmMaterialMueblesOficina.DisplayMember = "MATERIAL"
                cbmMaterialMueblesOficina.ValueMember = "ID"
                If (CType(cbmMaterialMueblesOficina.DataSource, DataTable).Rows.Count > 0) Then cbmMaterialMueblesOficina.SelectedIndex = 0
            Catch
                cbmMaterialMueblesOficina.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMarcasDeEquiposOficina()
            Try
                cbmMarcaEquiposOficina.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarcaEquiposOficina.DisplayMember = "MARCA"
                cbmMarcaEquiposOficina.ValueMember = "ID"
                If (CType(cbmMarcaEquiposOficina.DataSource, DataTable).Rows.Count > 0) Then cbmMarcaEquiposOficina.SelectedIndex = 0
            Catch
                cbmMarcaEquiposOficina.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColoresEquiposDeOficina()
            Try
                cbmColorEquiposOficina.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColorEquiposOficina.DisplayMember = "COLOR"
                cbmColorEquiposOficina.ValueMember = "ID"
                If (CType(cbmColorEquiposOficina.DataSource, DataTable).Rows.Count > 0) Then cbmColorEquiposOficina.SelectedIndex = 0
            Catch
                cbmColorEquiposOficina.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMaterialEquiposDeOficina()
            Try
                cbmMaterialEquiposOficina.DataSource = _objetoMaterial.SeleccionarTodosLosRegistrosMaterial(_tipoCon)
                cbmMaterialEquiposOficina.DisplayMember = "MATERIAL"
                cbmMaterialEquiposOficina.ValueMember = "ID"
                If (CType(cbmMaterialEquiposOficina.DataSource, DataTable).Rows.Count > 0) Then cbmMaterialEquiposOficina.SelectedIndex = 0
            Catch
                cbmMaterialEquiposOficina.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMarcasDeEquiposCocina()
            Try
                cbmMarcaEquiposCocina.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarcaEquiposCocina.DisplayMember = "MARCA"
                cbmMarcaEquiposCocina.ValueMember = "ID"
                If (CType(cbmMarcaEquiposCocina.DataSource, DataTable).Rows.Count > 0) Then cbmMarcaEquiposCocina.SelectedIndex = 0
            Catch
                cbmMarcaEquiposCocina.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColoresEquiposDeCocina()
            Try
                cbmColorEquiposCocina.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColorEquiposCocina.DisplayMember = "COLOR"
                cbmColorEquiposCocina.ValueMember = "ID"
                If (CType(cbmColorEquiposCocina.DataSource, DataTable).Rows.Count > 0) Then cbmColorEquiposCocina.SelectedIndex = 0
            Catch
                cbmColorEquiposCocina.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMaterialEquiposDeCocina()
            Try
                cbmMaterialEquiposCocina.DataSource = _objetoMaterial.SeleccionarTodosLosRegistrosMaterial(_tipoCon)
                cbmMaterialEquiposCocina.DisplayMember = "MATERIAL"
                cbmMaterialEquiposCocina.ValueMember = "ID"
                If (CType(cbmMaterialEquiposCocina.DataSource, DataTable).Rows.Count > 0) Then cbmMaterialEquiposCocina.SelectedIndex = 0
            Catch
                cbmMaterialEquiposCocina.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMarcasDeEquiposAbientacion()
            Try
                cbmMarcaEquiposAmbientacion.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarcaEquiposAmbientacion.DisplayMember = "MARCA"
                cbmMarcaEquiposAmbientacion.ValueMember = "ID"
                If (CType(cbmMarcaEquiposAmbientacion.DataSource, DataTable).Rows.Count > 0) Then cbmMarcaEquiposAmbientacion.SelectedIndex = 0
            Catch
                cbmMarcaEquiposAmbientacion.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColoresEquiposComunicacion()
            Try
                cbmColorEquiposComunicacion.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColorEquiposComunicacion.DisplayMember = "COLOR"
                cbmColorEquiposComunicacion.ValueMember = "ID"
                If (CType(cbmColorEquiposComunicacion.DataSource, DataTable).Rows.Count > 0) Then cbmColorEquiposComunicacion.SelectedIndex = 0
            Catch
                cbmColorEquiposComunicacion.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMaterialEquiposComunicacion()
            Try
                cbmMaterialEquiposComunicacion.DataSource = _objetoMaterial.SeleccionarTodosLosRegistrosMaterial(_tipoCon)
                cbmMaterialEquiposComunicacion.DisplayMember = "MATERIAL"
                cbmMaterialEquiposComunicacion.ValueMember = "ID"
                If (CType(cbmMaterialEquiposComunicacion.DataSource, DataTable).Rows.Count > 0) Then cbmMaterialEquiposComunicacion.SelectedIndex = 0
            Catch
                cbmMaterialEquiposComunicacion.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMarcasDeEquiposComunicacion()
            Try
                cbmMarcaEquiposComunicacion.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarcaEquiposComunicacion.DisplayMember = "MARCA"
                cbmMarcaEquiposComunicacion.ValueMember = "ID"
                If (CType(cbmMarcaEquiposComunicacion.DataSource, DataTable).Rows.Count > 0) Then cbmMarcaEquiposComunicacion.SelectedIndex = 0
            Catch
                cbmMarcaEquiposComunicacion.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColoresEquiposAbientacion()
            Try
                cbmColorEquiposAmbientacion.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColorEquiposAmbientacion.DisplayMember = "COLOR"
                cbmColorEquiposAmbientacion.ValueMember = "ID"
                If (CType(cbmColorEquiposAmbientacion.DataSource, DataTable).Rows.Count > 0) Then cbmColorEquiposAmbientacion.SelectedIndex = 0
            Catch
                cbmColorEquiposAmbientacion.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMaterialEquiposAbientacion()
            Try
                cbmMaterialEquiposAmbientacion.DataSource = _objetoMaterial.SeleccionarTodosLosRegistrosMaterial(_tipoCon)
                cbmMaterialEquiposAmbientacion.DisplayMember = "MATERIAL"
                cbmMaterialEquiposAmbientacion.ValueMember = "ID"
                If (CType(cbmMaterialEquiposAmbientacion.DataSource, DataTable).Rows.Count > 0) Then cbmMaterialEquiposAmbientacion.SelectedIndex = 0
            Catch
                cbmMaterialEquiposAmbientacion.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMarcasEquiposSeguridad()
            Try
                cbmMarcaEquipoSeguridad.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarcaEquipoSeguridad.DisplayMember = "MARCA"
                cbmMarcaEquipoSeguridad.ValueMember = "ID"
                If (CType(cbmMarcaEquipoSeguridad.DataSource, DataTable).Rows.Count > 0) Then cbmMarcaEquipoSeguridad.SelectedIndex = 0
            Catch
                cbmMarcaEquipoSeguridad.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColoresEquiposSeguridad()
            Try
                cbmColorEquipoSeguridad.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColorEquipoSeguridad.DisplayMember = "COLOR"
                cbmColorEquipoSeguridad.ValueMember = "ID"
                If (CType(cbmColorEquipoSeguridad.DataSource, DataTable).Rows.Count > 0) Then cbmColorEquipoSeguridad.SelectedIndex = 0
            Catch
                cbmColorEquipoSeguridad.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMaterialesEquiposSeguridad()
            Try
                cbmMaterialEquipoSeguridad.DataSource = _objetoMaterial.SeleccionarTodosLosRegistrosMaterial(_tipoCon)
                cbmMaterialEquipoSeguridad.DisplayMember = "MATERIAL"
                cbmMaterialEquipoSeguridad.ValueMember = "ID"
                If (CType(cbmMaterialEquipoSeguridad.DataSource, DataTable).Rows.Count > 0) Then cbmMaterialEquipoSeguridad.SelectedIndex = 0
            Catch
                cbmMaterialEquipoSeguridad.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMarcasCamaras()
            Try
                cbmMarcaCamarasSeguridad.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarcaCamarasSeguridad.DisplayMember = "MARCA"
                cbmMarcaCamarasSeguridad.ValueMember = "ID"
                If (CType(cbmMarcaCamarasSeguridad.DataSource, DataTable).Rows.Count > 0) Then cbmMarcaCamarasSeguridad.SelectedIndex = 0
            Catch
                cbmMarcaCamarasSeguridad.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColoresCamaras()
            Try
                cbmColorCamarasSeguridad.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColorCamarasSeguridad.DisplayMember = "COLOR"
                cbmColorCamarasSeguridad.ValueMember = "ID"
                If (CType(cbmColorCamarasSeguridad.DataSource, DataTable).Rows.Count > 0) Then cbmColorCamarasSeguridad.SelectedIndex = 0
            Catch
                cbmColorCamarasSeguridad.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMaterialesCamaras()
            Try
                cbmMaterialCamarasSeguridad.DataSource = _objetoMaterial.SeleccionarTodosLosRegistrosMaterial(_tipoCon)
                cbmMaterialCamarasSeguridad.DisplayMember = "MATERIAL"
                cbmMaterialCamarasSeguridad.ValueMember = "ID"
                If (CType(cbmMaterialCamarasSeguridad.DataSource, DataTable).Rows.Count > 0) Then cbmMaterialCamarasSeguridad.SelectedIndex = 0
            Catch
                cbmMaterialCamarasSeguridad.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMarcasGeneradores()
            Try
                cbmMarcaGeneradores.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarcaGeneradores.DisplayMember = "MARCA"
                cbmMarcaGeneradores.ValueMember = "ID"
                If (CType(cbmMarcaGeneradores.DataSource, DataTable).Rows.Count > 0) Then cbmMarcaGeneradores.SelectedIndex = 0
            Catch
                cbmMarcaGeneradores.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColoresGeneradores()
            Try
                cbmColorGeneradores.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColorGeneradores.DisplayMember = "COLOR"
                cbmColorGeneradores.ValueMember = "ID"
                If (CType(cbmColorGeneradores.DataSource, DataTable).Rows.Count > 0) Then cbmColorGeneradores.SelectedIndex = 0
            Catch
                cbmColorGeneradores.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMaterialesGeneradores()
            Try
                cbmMaterialGeneradores.DataSource = _objetoMaterial.SeleccionarTodosLosRegistrosMaterial(_tipoCon)
                cbmMaterialGeneradores.DisplayMember = "MATERIAL"
                cbmMaterialGeneradores.ValueMember = "ID"
                If (CType(cbmMaterialGeneradores.DataSource, DataTable).Rows.Count > 0) Then cbmMaterialGeneradores.SelectedIndex = 0
            Catch
                cbmMaterialGeneradores.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMarcasChalecos()
            Try
                cbmMarcaChaleco.DataSource = _objetoMarca.SeleccionarTodosLosRegistrosMarca(_tipoCon)
                cbmMarcaChaleco.DisplayMember = "MARCA"
                cbmMarcaChaleco.ValueMember = "ID"
                If (CType(cbmMarcaChaleco.DataSource, DataTable).Rows.Count > 0) Then cbmMarcaChaleco.SelectedIndex = 0
            Catch
                cbmMarcaChaleco.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboColoresChalecos()
            Try
                cbmColorChaleco.DataSource = _objetoColor.SeleccionarTodosLosRegistrosColor(_tipoCon)
                cbmColorChaleco.DisplayMember = "COLOR"
                cbmColorChaleco.ValueMember = "ID"
                If (CType(cbmColorChaleco.DataSource, DataTable).Rows.Count > 0) Then cbmColorChaleco.SelectedIndex = 0
            Catch
                cbmColorChaleco.DataSource = Nothing
            End Try
        End Sub

        Private Sub LlenarComboMaterialesChalecos()
            Try
                cbmMaterialChaleco.DataSource = _objetoMaterial.SeleccionarTodosLosRegistrosMaterial(_tipoCon)
                cbmMaterialChaleco.DisplayMember = "MATERIAL"
                cbmMaterialChaleco.ValueMember = "ID"
                If (CType(cbmMaterialChaleco.DataSource, DataTable).Rows.Count > 0) Then cbmMaterialChaleco.SelectedIndex = 0
            Catch
                cbmMaterialChaleco.DataSource = Nothing
            End Try
        End Sub

        Public Sub LlenarComboCuentasActivo()
            Try
                cbmCuentasActivo.DataSource = _objetoPlanCuentas.SeleccionarCuentasActivoFijo(_tipoCon)
                cbmCuentasActivo.DisplayMember = "CUENTA"
                cbmCuentasActivo.ValueMember = "CODIGO"
                cbmCuentasActivo.DropDownWidth = 350
                If (CType(cbmCuentasActivo.DataSource, DataTable).Rows.Count > 0) Then cbmCuentasActivo.SelectedIndex = 0
            Catch
                cbmCuentasActivo.DataSource = Nothing
            End Try
        End Sub

        Public Sub LlenarComboCuentasGastos()
            Try
                cbmCuentaGastos.DataSource = _objetoPlanCuentas.SeleccionarCuentasGastosFijo(_tipoCon)
                cbmCuentaGastos.DisplayMember = "CUENTA"
                cbmCuentaGastos.ValueMember = "CODIGO"
                cbmCuentaGastos.DropDownWidth = 350
                If (CType(cbmCuentaGastos.DataSource, DataTable).Rows.Count > 0) Then cbmCuentaGastos.SelectedIndex = 0
            Catch
                cbmCuentaGastos.DataSource = Nothing
            End Try
        End Sub

        Public Sub LlenarComboCuentasDepreciaciones()
            Try
                cbmCuentaDepreciacion.DataSource = _objetoPlanCuentas.SeleccionarCuentasDepreciacionesFijo(_tipoCon)
                cbmCuentaDepreciacion.DisplayMember = "CUENTA"
                cbmCuentaDepreciacion.ValueMember = "CODIGO"
                cbmCuentaDepreciacion.DropDownWidth = 350
                If (CType(cbmCuentaDepreciacion.DataSource, DataTable).Rows.Count > 0) Then cbmCuentaDepreciacion.SelectedIndex = 0
            Catch
                cbmCuentaDepreciacion.DataSource = Nothing
            End Try
        End Sub

        Public Sub AutocompletarNombreProveedor()
            Try
                txtNombreProvedor.AutoCompleteCustomSource = _objProveedor.AutocompletarConId(_tipoCon)
                txtNombreProvedor.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreProvedor.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreProvedor.AutoCompleteCustomSource = Nothing
            End Try
        End Sub

        Public Sub AutocompletarPersonal()
            Try
                txtNombreCustodio.AutoCompleteCustomSource = _objPersonal.AutocompletarConId(_tipoCon)
                txtNombreCustodio.AutoCompleteMode = AutoCompleteMode.Suggest
                txtNombreCustodio.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtNombreCustodio.AutoCompleteCustomSource = Nothing
            End Try
        End Sub

        Public Sub AutocompletarResponsable()
            Try
                txtResponsable.AutoCompleteCustomSource = _objPersonal.AutocompletarConId(_tipoCon)
                txtResponsable.AutoCompleteMode = AutoCompleteMode.Suggest
                txtResponsable.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch
                txtResponsable.AutoCompleteCustomSource = Nothing
            End Try
        End Sub

        Private Function ValidacionParametrosGenerales()
            Return txtResponsable.Text.Trim().Length > 0 And CInt(txtSitio.Tag) > 0 And
            txtCarpeta.Text.Trim().Length > 0 And txtContrato.Text.Trim().Length > 0 And txtNombreActivo.Text.Trim().Length > 0 And
            txtNombreProvedor.Text.Trim().Length > 0 And txtNombreCustodio.Text.Trim().Length > 0 And
            txtcuentaActivo.Text.Trim().Length > 0 And txtCuentaGastos.Text.Trim().Length > 0 And txtCuentaDepreciacion.Text.Trim().Length > 0 And
           txtCodigoArancel.Text.Trim().Length > 0 And txtOrdenCompra.Text.Trim().Length > 0 And txtNumeroFactura.Text.Trim().Length > 0 And
            txtValorFactura.Text.Trim().Length > 0 And txtValorResidual.Text.Trim().Length > 0 And
            txtAñosVidaUtil.Text.Trim().Length > 0 'And txtValorAdicional.Text.Trim().Length > 0
        End Function

        '====== ARMAS ==================================================================================================================================================================================================
        Private Function ValidacionParametrosArmas() As Boolean
            Return txtPermisoFuncionamiento.Text.Trim().Length > 0 And txtPermisoComandoConjunto.Text.Trim().Length > 0 And
                txtNroTenenciaArmas.Text.Trim().Length > 0 And txtNroMatriculaArma.Text.Trim().Length > 0 And txtSerieArmas.Text.Trim().Length > 0 And cbxOrigen.Text.Trim().Length > 0
        End Function
        '===== RADIOS ==================================================================================================================================================================================================
        Private Function ValidacionParametrosRadios() As Boolean
            Return cbmMarcaRadio.Text.Trim().Length > 0 And txtModeloRadio.Text.Trim().Length > 0 And txtSerieRadio.Text.Trim().Length > 0 And txtNumeroPermisoUsoRadio.Text.Trim().Length > 0 And
            cbmColoresRadio.Text.Trim().Length > 0 And cbmEstadoRadio.Text.Trim().Length > 0
        End Function
        '===== VEHÍCULOS ===============================================================================================================================================================================================
        Private Function ValidacionParametrosVehiculos() As Boolean
            Return cbmMarcaVehiculo.Text.Trim().Length > 0 And txtModeloVehiculo.Text.Trim().Length > 0 And txtSerieVehiculo.Text.Trim().Length > 0 And txtChasisVehiculo.Text.Trim().Length > 0 And
                 txtPlacaVehiculo.Text.Trim().Length > 0 And txtMotorVehiculo.Text.Trim().Length > 0 And txtCilindrajeVehiculo.Text.Trim().Length > 0 And txtCapacidadVehiculo.Text.Trim().Length > 0 And txtTipoVehiculo.Text.Trim().Length > 0 And
                     cbmColorVehiculo.SelectedValue > 0 And cbmEstadoVehiculo.Text.Trim().Length > 0 And txtAseguradoraNombre.Text.Trim().Length > 0 And txtSeguro.Text.Trim().Length > 0 And txtBroker.Text.Trim().Length > 0 And
                                txtNroPoliza.Text.Trim().Length > 0 And txtCostoPrima.Text.Trim().Length > 0 And txtDispositivoSeguridad.Text.Trim().Length > 0
        End Function
        '===== TERRENOS ================================================================================================================================================================================================
        Private Function ValidacionParametrosTerrenos() As Boolean
            Return txtMedidaTerreno.Text.Trim().Length > 0 And txtUbicacionTerreno.Text.Trim().Length > 0 And txtEstadoTerreno.Text.Trim().Length > 0
        End Function
        '===== EQUIPOS DE COMPUTO ======================================================================================================================================================================================
        Private Function ValidacionParametrosEquiposComputo() As Boolean
            Return txtModeloEquipoComputo.Text.Trim().Length > 0 And txtComponenteEquipoComputo.Text.Trim().Length > 0
        End Function
        '===== LIBROS Y COLECCIONES ====================================================================================================================================================================================
        Private Function ValidacionParametrosLibrosyColecciones() As Boolean
            Return txtEditorial.Text.Trim().Length > 0 And txtAutor.Text.Trim().Length > 0 And txtTomos.Text.Trim().Length > 0 And cbmAñosEdicionLibros.Text.Trim().Length > 0
        End Function
        '===== EQUIPOS DE OFICINA ======================================================================================================================================================================================
        Private Function ValidacionParametrosEquiposOficina() As Boolean
            Return cbmMarcaEquiposOficina.Text.Trim().Length > 0 And txtModeloEquiposOficina.Text.Trim().Length > 0 And cbmEstadoActivoEquiposOficina.Text.Trim().Length > 0 And txtSerieEquiposOficina.Text.Trim().Length > 0 And cbmColorEquiposOficina.Text.Trim().Length > 0 And
                cbmMaterialEquiposOficina.Text.Trim().Length > 0 And cbmAñosEquiposOficina.Text.Trim().Length > 0
        End Function
        '===== MUEBLES DE OFICINA ======================================================================================================================================================================================
        Private Function ValidacionParametrosMueblesOficina() As Boolean
            Return cbmMarcaMueblesOficina.Text.Trim().Length > 0 And txtModeloMueblesOficina.Text.Trim().Length > 0 And cbmEstadoActivoMueblesOficina.Text.Trim().Length > 0 And cbmColorMueblesOficina.Text.Trim().Length > 0 And
                cbmMaterialMueblesOficina.Text.Trim().Length > 0 And cbmAñosMueblesOficina.Text.Trim().Length > 0
        End Function
        '===== EQUIPOS DE COCINA ======================================================================================================================================================================================
        Private Function ValidacionParametrosEquiposCocina() As Boolean
            Return cbmMarcaEquiposCocina.Text.Trim().Length > 0 And txtModeloEquiposCocina.Text.Trim().Length > 0 And cbmEstadoEquiposCocina.Text.Trim().Length > 0 And txtSerieEquiposCocina.Text.Trim().Length > 0 And cbmColorEquiposCocina.Text.Trim().Length > 0 And
                cbmMaterialEquiposCocina.Text.Trim().Length > 0 And cbmAñosEquiposCocina.Text.Trim().Length > 0
        End Function
        '===== EQUIPOS DE AMBIENTACIÓN =================================================================================================================================================================================
        Private Function ValidacionParametrosEquiposAmbientación() As Boolean
            Return cbmMarcaEquiposAmbientacion.Text.Trim().Length > 0 And txtModeloEquiposAmbientacion.Text.Trim().Length > 0 And cbmEstadoEquiposAmbientacion.Text.Trim().Length > 0 And txtSerieEquiposAmbientacion.Text.Trim().Length > 0 And
                cbmColorEquiposAmbientacion.Text.Trim().Length > 0 And cbmMaterialEquiposAmbientacion.Text.Trim().Length > 0 And cbmAñosEquiposAmbientacion.Text.Trim().Length > 0
        End Function
        '===== EQUIPOS DE COMUNICACIÓN =================================================================================================================================================================================
        Private Function ValidacionParametrosEquiposComunicacion() As Boolean
            Return cbmMarcaEquiposComunicacion.Text.Trim().Length > 0 And txtModeloEquiposComunicacion.Text.Trim().Length > 0 And cbmEstadoEquiposComunicacion.Text.Trim().Length > 0 And txtSerieEquiposComunicacion.Text.Trim().Length > 0 And
                cbmColorEquiposComunicacion.Text.Trim().Length > 0 And cbmMaterialEquiposComunicacion.Text.Trim().Length > 0 And cbmAñosEquiposComunicacion.Text.Trim().Length > 0
        End Function
        '===== EQUIPOS DE SEGURIDAD =================================================================================================================================================================================
        Private Function ValidacionParametrosEquiposSeguridad() As Boolean
            Return cbmMarcaEquipoSeguridad.Text.Trim().Length > 0 And txtModeloEquipoSeguridad.Text.Trim().Length > 0 And cbmEstadoEquipoSeguridad.Text.Trim().Length > 0 And txtSerieEquipoSeguridad.Text.Trim().Length > 0 And
                cbmColorEquipoSeguridad.Text.Trim().Length > 0 And cbmMaterialEquipoSeguridad.Text.Trim().Length > 0 And cbmAñosEquipoSeguridad.Text.Trim().Length > 0 And txtAdicionalEquipoSeguridad.Text.Trim().Length > 0
        End Function
        '===== CAMARAS DE SEGURIDAD =================================================================================================================================================================================
        Private Function ValidacionParametrosCamarasSeguridad() As Boolean
            Return cbmMarcaCamarasSeguridad.Text.Trim().Length > 0 And txtModeloCamarasSeguridad.Text.Trim().Length > 0 And cbmEstadoCamarasSeguridad.Text.Trim().Length > 0 And txtSerieCamarasSeguridad.Text.Trim().Length > 0 And
                cbmColorCamarasSeguridad.Text.Trim().Length > 0 And cbmMaterialCamarasSeguridad.Text.Trim().Length > 0 And cbmAñosCamarasSeguridad.Text.Trim().Length > 0 And txtAdicionalCamarasSeguridad.Text.Trim().Length > 0
        End Function
        '===== GENERADORES =================================================================================================================================================================================
        Private Function ValidacionParametrosGeneradores() As Boolean
            Return cbmMarcaGeneradores.Text.Trim().Length > 0 And txtModeloGeneradores.Text.Trim().Length > 0 And cbmEstadoGeneradores.Text.Trim().Length > 0 And txtSerieGeneradores.Text.Trim().Length > 0 And
                cbmColorGeneradores.Text.Trim().Length > 0 And cbmMaterialGeneradores.Text.Trim().Length > 0 And cbmAñosGeneradores.Text.Trim().Length > 0 And txtAdicionalGeneradores.Text.Trim().Length > 0
        End Function
        '===== CHALECOS =================================================================================================================================================================================
        Private Function ValidacionParametrosChalecos() As Boolean
            Return cbmMarcaChaleco.Text.Trim().Length > 0 And txtModeloChaleco.Text.Trim().Length > 0 And cbmEstadoChaleco.Text.Trim().Length > 0 And txtSerieChaleco.Text.Trim().Length > 0 And cbmColorChaleco.Text.Trim().Length > 0 And
                cbmMaterialChaleco.Text.Trim().Length > 0 And cbmAñosChaleco.Text.Trim().Length > 0 And txtAdicionalChaleco.Text.Trim().Length > 0
        End Function
        '===== SOFTWARE =================================================================================================================================================================================
        Private Function ValidacionParametrosSoftware() As Boolean
            Return txtDetalleSoftware.Text.Trim().Length > 0 And txtVersionSoftware.Text.Trim().Length > 0 And txtProvedorSoftware.Text.Trim().Length > 0 And cbmTipoSoftware.Text.Trim().Length > 0
        End Function

        Private Sub btnAgregarEquipo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarEquipo.Click
            If ValidacionParametrosEquiposComputo() Then
                dgvEquiposComputo.Rows.Add(cbmMarcaEquipoComputo.Text.ToString.ToUpper, txtModeloEquipoComputo.Text.Trim.ToUpper, txtComponenteEquipoComputo.Text.Trim.ToUpper, cbmEstadoEquipoComputo.Text.Trim.ToUpper, cbmColorEquipoComputo.Text.Trim.ToUpper, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), If(chkGarantiaComputo.Checked, 1, 0), txtGarantiaComputo.Text.Trim, txtValorFactura.Text.Trim, txtValorResidual.Text.Trim, txtAñosVidaUtil.Text.Trim, dtpCaducidadComputo.Value.ToShortDateString)

                cbmMarcaEquipoComputo.SelectedIndex = 0
                txtModeloEquipoComputo.Clear()
                cbmEstadoEquipoComputo.SelectedIndex = 0
                txtComponenteEquipoComputo.Clear()
                cbmColorEquipoComputo.SelectedIndex = 0
                chkGarantiaComputo.Checked = False
                txtGarantiaComputo.Clear()
                dgvEquiposComputo.Refresh()
            Else

                KryptonMessageBox.Show("No se puede agregar el componente sino completa todos los parámetros necesarios", "Mensaje de información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)


            End If
        End Sub

        Private Sub btnEliminarEquipoComputo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnEliminarEquipoComputo.Click


            If dgvEquiposComputo.RowCount = 0 Then Return
            If dgvEquiposComputo.CurrentRow Is Nothing Then Return
            dgvEquiposComputo.Rows.RemoveAt(dgvEquiposComputo.CurrentRow.Index)
            dgvEquiposComputo.Refresh()

        End Sub

        Private Sub txtResponsable_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtResponsable.KeyPress, txtNombreProvedor.KeyPress, txtNombreCustodio.KeyPress, txtNombreActivo.KeyPress, txtSerieVehiculo.KeyPress, txtSeguro.KeyPress, txtPlacaVehiculo.KeyPress, txtMotorVehiculo.KeyPress, txtModeloVehiculo.KeyPress, txtModeloRadio.KeyPress, txtDispositivoSeguridad.KeyPress, txtChasisVehiculo.KeyPress, txtCapacidadVehiculo.KeyPress, txtBroker.KeyPress, txtAseguradoraNombre.KeyPress, txtVersionSoftware.KeyPress, txtUbicacionTerreno.KeyPress, txtSerieEquiposOficina.KeyPress, txtSerieEquiposCocina.KeyPress, txtProvedorSoftware.KeyPress, txtModeloMueblesOficina.KeyPress, txtModeloEquiposOficina.KeyPress, txtModeloEquiposCocina.KeyPress, txtModeloEquipoComputo.KeyPress, txtMedidaTerreno.KeyPress, txtEstadoTerreno.KeyPress, txtEditorial.KeyPress, txtDetalleSoftware.KeyPress, txtComponenteEquipoComputo.KeyPress, txtAutor.KeyPress, txtSerieRadio.KeyPress
            e.Handled = Not _validacionesAlfanumerica.EsAlfanumerico(e.KeyChar)
        End Sub

        Private Sub txtCarpeta_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtContrato.KeyPress, txtCarpeta.KeyPress, txtAñosVidaUtil.KeyPress, txtTomos.KeyPress, txtTipoVehiculo.KeyPress, txtSerieArmas.KeyPress, txtPermisoFuncionamiento.KeyPress, txtPermisoComandoConjunto.KeyPress, txtOrdenCompra.KeyPress, txtNumeroPermisoUsoRadio.KeyPress, txtNroTenenciaArmas.KeyPress, txtNroPoliza.KeyPress, txtNroMatriculaArma.KeyPress, txtCodigoArancel.KeyPress
            'e.Handled = Not _validacionesNumeros.EsNumero(e.KeyChar)
        End Sub

        Private Sub txtNumeroFactura_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles txtValorResidual.KeyPress, txtValorFactura.KeyPress, txtValorAdicional.KeyPress, txtNumeroFactura.KeyPress, txtCostoPrima.KeyPress, txtCilindrajeVehiculo.KeyPress
            e.Handled = Not _validacionesDecimal.EsDecimal(e.KeyChar)
        End Sub

        Private Sub lblValorResidual_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblValorResidual.Click

            If cbxVidaUtil.Checked Then
                txtAñosVidaUtil.Enabled = True
                Select Case txtAñosVidaUtil.Text
                    Case "3" ' DEPRECIACIÓN MUEBLES Y ENSERES
                        _porcentajeDepreciacion = 0.3333
                    Case "5" ' DEPRECIACIÓN MAQUINARIAS Y EQUIPOS
                        _porcentajeDepreciacion = 0.2
                    Case "10" ' DEPRECIACIÓN VEHÍCULOS
                        _porcentajeDepreciacion = 0.2
                    Case "5202190106"
                        _porcentajeDepreciacion = 0.1

                    Case Else ' DEPRECIACIÓN EQUIPOS EN GENERAL
                        _porcentajeDepreciacion = 0.3333
                        txtAñosVidaUtil.Text = "3"
                End Select

            Else
                Try
                    Dim Valor_residual As Decimal = CDec(txtValorFactura.Text) * _porcentajeDepreciacion
                    'txtValorResidual.Text = CDec(txtValorFactura.Text) * _porcentajeDepreciacion
                    txtValorResidual.Text = Decimal.Round(Valor_residual, 3).ToString()
                    _valorDepreciacion = CDec(txtValorFactura.Text) - CDec(txtValorResidual.Text)
                Catch
                    txtValorResidual.Text = "0.00"
                    _valorDepreciacion = 0
                End Try
            End If

        End Sub

        Private Sub btnAgregarCategoria_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAgregarCategoria.Click
            Dim formAgregarCategoria As New FormAgregarCategoria
            formAgregarCategoria.TipoCox = TipoCox
            formAgregarCategoria.IdUsuario = IdUsuario
            formAgregarCategoria.ShowDialog()
            CargarCategoria()
        End Sub

        Private Sub btnParametros_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnParametros.Click
            Dim formMantenimientoMarcasMaterialesColores As New FormMantenimientoMarcasMaterialesColores
            formMantenimientoMarcasMaterialesColores.IdUsuario = IdUsuario
            formMantenimientoMarcasMaterialesColores.TipoCox = TipoCox
            formMantenimientoMarcasMaterialesColores.ShowDialog()
            CargarCategoria()
        End Sub

        Private Sub GuardarDatosActivoGeneralVarios(ByVal idActivoFijo As Integer, ByVal idDepreciacion As Integer, ByVal serie As String, ByVal ValorFactura As Decimal, ByVal ValorResidual As Decimal, ByVal VidaUtil As Integer, ByVal IdDetaDepre As Integer)

            With _objetoActivoFijo
                .IdActivoFijo = idActivoFijo
                .IdPersonal = If(txtNombreCustodio.Text.Contains("-"), txtNombreCustodio.Text.Split("-")(1), 0)
                .IdEmpresa = cbEmpresa.SelectedValue
                .IdSucursal = cbSucursal.SelectedValue
                .IdGerencias = cbgerencias.SelectedValue
                .IdAreas = cbArea.SelectedValue
                .Carpeta = txtCarpeta.Text.Trim
                .Contrato = txtContrato.Text.Trim
                .Codigo = serie
                .NombreActivo = txtNombreActivo.Text.ToUpper.Trim
                .NombreProvedor = txtNombreProvedor.Text.ToUpper.Trim
                .NombreCustodio = txtNombreCustodio.Text.ToUpper.Trim
                .Responsable = txtResponsable.Text.ToUpper.Trim
                .Fecha = dtpFechaActual.Value
                .CodigoArancel = txtCodigoArancel.Text.ToUpper.Trim
                .NumeroOrdenCompra = txtOrdenCompra.Text.Trim
                .NumeroFactura = txtNumeroFactura.Text.Trim
                .ValorFactura = CDec(txtValorFactura.Text)
                '.ValorAdicional = CDec(txtValorAdicional.Text)
                .ValorAdicional = 0
                .ValorResidual = CDec(txtValorResidual.Text)
                .FechaAdquisicion = dtpFechaAdquisicion.Value
                .AnosVidaUtil = txtAñosVidaUtil.Text
                .CuentaActivo = txtcuentaActivo.Text.Trim
                .CuentaGastos = txtCuentaGastos.Text.Trim
                .CuentaDepreciacion = txtCuentaDepreciacion.Text.Trim
                .EstadoActivo = cbmEstadoActivoActual.Text.ToUpper
                .Estado = 1

                .TipoActivo = _formDialogoNuevoActivo.GetSelectedTitulo
                .Mantenimiento = cbmMantenimiento.Text.ToUpper
                .IdSitio = 1
                .IdProveedorGeneral = If(txtNombreProvedor.Text.Contains("-"), txtNombreProvedor.Text.Split("-")(1), 0)
                .FechaMantenimiento = If(cbmMantenimiento.Text <> "NO", dtpFechaMantenimiento.Value, New DateTime(1990, 1, 1, 0, 0, 0))
            End With
            _sqlCommands.Add(_objetoActivoFijo.NuevaActivoFijo())

            ' SEGUNDO DEPRECIACION

            Dim fecha = dtpFechaActual.Value
            Dim valResi = ValorResidual
            Dim valfac = ValorFactura
            Dim vidauti = VidaUtil
            Dim ValorResi = valResi
            Dim idde = IdDetaDepre



            If txtCuentaDepreciacion.Text.Trim().Length > 0 Then

                With _objDepreciacion
                    .Id = idDepreciacion
                    .IdActivoFijo = idActivoFijo
                    .Porcentaje = _porcentajeDepreciacion
                    .CuentaContable = txtCuentaDepreciacion.Text.Trim
                    .Tope = CInt(txtAñosVidaUtil.Text)
                    .Estado = 1
                End With
                _sqlCommands.Add(_objDepreciacion.NuevaDepreciacionGeneral())



                _objDetalleDepreciacion.ValorResidualDepreciacion = valfac
                _objDetalleDepreciacion.ValorDepreciacion = 0.0


                For i = 1 To vidauti


                    With _objDetalleDepreciacion
                        .IdDetalle = idde
                        .Fecha = fecha
                        .NumeroDepreciacion = i
                        .ValorDepreciacion += valResi
                        .ValorResidualDepreciacion -= valResi
                        .Estado = 1
                        .IdDetalleGeneral = idDepreciacion
                        _sqlCommands.Add(_objDetalleDepreciacion.NuevaDetalleDepreciacion())
                    End With
                    fecha = fecha.AddYears(1)
                    idde += 1
                Next


            End If


        End Sub

        'Private Sub GuardarDatosActivoGeneral(ByVal idActivoFijo As Integer, ByVal idDepreciacion As Integer, ByVal serie As String)



        '    With _objetoActivoFijo
        '        .IdActivoFijo = idActivoFijo
        '        .IdPersonal = If(txtNombreCustodio.Text.Contains("-"), txtNombreCustodio.Text.Split("-")(1), 0)
        '        .IdEmpresa = cbEmpresa.SelectedValue
        '        .IdSucursal = cbSucursal.SelectedValue
        '        .IdGerencias = cbgerencias.SelectedValue
        '        .IdAreas = cbArea.SelectedValue
        '        .Carpeta = txtCarpeta.Text.Trim
        '        .Contrato = txtContrato.Text.Trim
        '        .Codigo = serie
        '        .NombreActivo = txtNombreActivo.Text.ToUpper.Trim
        '        .NombreProvedor = txtNombreProvedor.Text.ToUpper.Trim
        '        .NombreCustodio = txtNombreCustodio.Text.ToUpper.Trim
        '        .Responsable = txtResponsable.Text.ToUpper.Trim
        '        .Fecha = dtpFechaActual.Value
        '        .CodigoArancel = txtCodigoArancel.Text.ToUpper.Trim
        '        .NumeroOrdenCompra = txtOrdenCompra.Text.Trim
        '        .NumeroFactura = txtNumeroFactura.Text.Trim
        '        .ValorFactura = CDec(txtValorFactura.Text)
        '        '.ValorAdicional = CDec(txtValorAdicional.Text)
        '        .ValorAdicional = 0
        '        .ValorResidual = CDec(txtValorResidual.Text)
        '        .FechaAdquisicion = dtpFechaAdquisicion.Value
        '        .AnosVidaUtil = txtAñosVidaUtil.Text
        '        .CuentaActivo = txtcuentaActivo.Text.Trim
        '        .CuentaGastos = txtCuentaGastos.Text.Trim
        '        .CuentaDepreciacion = txtCuentaDepreciacion.Text.Trim
        '        .EstadoActivo = cbmEstadoActivoActual.Text.ToUpper
        '        .Estado = 1

        '        .TipoActivo = _formDialogoNuevoActivo.GetSelectedTitulo
        '        .Mantenimiento = cbmMantenimiento.Text.ToUpper
        '        .IdSitio = 1
        '        .IdProveedorGeneral = If(txtNombreProvedor.Text.Contains("-"), txtNombreProvedor.Text.Split("-")(1), 0)
        '        .FechaMantenimiento = If(cbmMantenimiento.Text <> "NO", dtpFechaMantenimiento.Value, New DateTime(1990, 1, 1, 0, 0, 0))
        '    End With
        '    _sqlCommands.Add(_objetoActivoFijo.NuevaActivoFijo())


        '    Dim fecha = dtpFechaActual.Value


        '    ' SEGUNDO DEPRECIACION
        '    'Dim idde = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + 1
        '    Dim idde = idDepreciacion + 1

        '    Dim valResi = Convert.ToDecimal(txtValorResidual)
        '    Dim valfac = Convert.ToDecimal(txtValorFactura)
        '    Dim vidauti = Convert.ToInt32(txtAñosVidaUtil)
        '    Dim ValorResi = valResi
        '    _objDetalleDepreciacion.ValorResidualDepreciacion = Double.Parse(valfac)

        '    If txtCuentaDepreciacion.Text.Trim().Length > 0 Then

        '        With _objDepreciacion
        '            .Id = idDepreciacion
        '            .IdActivoFijo = idActivoFijo
        '            .Porcentaje = _porcentajeDepreciacion
        '            .CuentaContable = txtCuentaDepreciacion.Text.Trim
        '            .Tope = CInt(txtAñosVidaUtil.Text)
        '            .Estado = 1
        '        End With
        '        _sqlCommands.Add(_objDepreciacion.NuevaDepreciacionGeneral())


        '        For i = 1 To vidauti

        '            With _objDetalleDepreciacion
        '                .IdDetalle = idde
        '                .Fecha = fecha
        '                .NumeroDepreciacion = i
        '                .ValorDepreciacion += ValorResi
        '                .ValorResidualDepreciacion -= ValorResi
        '                .Estado = 1
        '                .IdDetalleGeneral = idDepreciacion
        '                _sqlCommands.Add(_objDetalleDepreciacion.NuevaDetalleDepreciacion())
        '            End With
        '            fecha = fecha.AddYears(1)
        '            idde += 1

        '        Next


        'With _objDetalleDepreciacion
        '    .IdDetalle = idDepreciacion
        '    .Fecha = dtpFechaActual.Value
        '    .NumeroDepreciacion = 1
        '    .ValorDepreciacion = CDec(_valorDepreciacion)
        '    .ValorResidualDepreciacion = CDec(txtValorResidual.Text)
        '    .Estado = 1
        'End With
        '_sqlCommands.Add(_objDetalleDepreciacion.NuevaDetalleDepreciacion())
        '    End If




        ''If txtAñosVidaUtil.Text.Length > 0 Then
        ''    Dim id = idDepreciacion

        '    Dim valResi = Convert.ToDecimal(txtValorResidual)
        '    Dim valfac = Convert.ToDecimal(txtValorFactura)
        '    Dim vidauti = Convert.ToInt32(txtAñosVidaUtil)
        '    Dim ValorResi = valResi
        '    _objDetalleDepreciacion.ValorResidualDepreciacion = Double.Parse(valfac)

        '    For i = 1 To vidauti

        '        With _objDetalleDepreciacion
        '            .IdDetalle = id
        '            .Fecha = fecha
        '            .NumeroDepreciacion = i
        '            .ValorDepreciacion += ValorResi
        '            .ValorResidualDepreciacion -= ValorResi
        '            .Estado = 1
        '            .IdDetalleGeneral = idDepreciacion
        '            _sqlCommands.Add(_objDetalleDepreciacion.NuevaDetalleDepreciacion())
        '        End With
        '        fecha = fecha.AddYears(1)
        '        id += 1

        '    Next


        'End If






        'End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If Not ValidacionParametrosGenerales() Then

                KryptonMessageBox.Show("Debe llenar todos los datos generales del activo fijo!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End If

            _sqlCommands.Clear()

            ' IDS GENERALES
            Dim idActivoFijo = _objetoActivoFijo.BuscarMayorIdActivoFijo(_tipoCon) + 1
            Dim idDepreciacion = _objDepreciacion.BuscarMayorIdDepreciacion(_tipoCon) + 1
            Dim valfactura = Convert.ToDecimal(txtValorFactura.Text)
            Dim valResidual = Convert.ToDecimal(txtValorResidual.Text)
            Dim vidautil = Convert.ToInt32(txtAñosVidaUtil.Text)
            Dim id = 1

            Select Case _formDialogoNuevoActivo.Tipo
                Case 0 '"ARMAS"
                    If dgvArmas.RowCount = 0 Then

                        KryptonMessageBox.Show("DEBE LLENAR TODOS LOS DATOS DE LAS ARMAS!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    For Each row As DataGridViewRow In dgvArmas.Rows
                        ' PRIMERO EL REGISTRO ACTIVO FIJO
                        Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + id

                        GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, row.Cells(2).Value.ToString.Trim, row.Cells(11).Value.ToString.Trim, row.Cells(12).Value.ToString.Trim, row.Cells(13).Value.ToString.Trim, IdDetaDepre)

                        With _objetoArmas
                            .IdActivoFijo = idActivoFijo
                            .NumeroPermisoGobierno = row.Cells(3).Value.ToString.Trim
                            .NumeroPermisoComando = row.Cells(4).Value.ToString.Trim
                            .NumeroTenencia = row.Cells(5).Value.ToString.Trim
                            .FechaAceptacionTenencia = row.Cells(6).Value.ToString.Trim
                            .FechaCaducidadTenencia = row.Cells(7).Value.ToString.Trim
                            .NumeroMatricula = row.Cells(8).Value.ToString.Trim
                            .FechaAceptacionMatricula = row.Cells(9).Value.ToString.Trim
                            .FechaCaducidadMatricula = row.Cells(10).Value.ToString.Trim
                            .Serie = row.Cells(1).Value.ToString.Trim
                            .Estado = 1
                            .Origen = row.Cells(0).Value.ToString.Trim
                        End With
                        _sqlCommands.Add(_objetoArmas.NuevoArmas())

                        idActivoFijo += 1
                        idDepreciacion += 1
                        id += vidautil
                    Next

                Case 1 '"RADIOS"
                    If dgvRadios.RowCount = 0 Then

                        KryptonMessageBox.Show("Debe llenar todos los datos de las radios!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    For Each row As DataGridViewRow In dgvRadios.Rows
                        ' PRIMERO EL REGISTRO ACTIVO FIJO
                        Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + id
                        GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, row.Cells(8).Value.ToString.Trim, row.Cells(11).Value.ToString.Trim, row.Cells(12).Value.ToString.Trim, row.Cells(13).Value.ToString.Trim, IdDetaDepre)

                        With _objetoRadios
                            .IdActivoFijo = idActivoFijo
                            .Marca = row.Cells(0).Value.ToString.Trim
                            .Modelo = row.Cells(1).Value.ToString.Trim
                            .Serie = row.Cells(2).Value.ToString.Trim
                            .Color = row.Cells(3).Value.ToString.Trim
                            .EstadoActivo = row.Cells(4).Value.ToString.Trim
                            .NumPermisoUso = row.Cells(5).Value.ToString.Trim
                            .FecAceptacionPermiso = row.Cells(6).Value.ToString.Trim
                            .FecCaducidadPermiso = row.Cells(7).Value.ToString.Trim
                            .Estado = 1
                            .Garantia = row.Cells(9).Value
                            Dim docRadio As String = row.Cells("DOCUMENTO").Value.ToString()
                            If Not String.IsNullOrEmpty(docRadio) Then
                                If File.Exists(docRadio) Then
                                    .Documento = File.ReadAllBytes(docRadio)
                                Else

                                    .Documento = Nothing
                                End If
                            Else

                                .Documento = Nothing
                            End If
                            .Ruta = row.Cells(10).Value.ToString.Trim


                        End With
                        _sqlCommands.Add(_objetoRadios.NuevoRadios())

                        idActivoFijo += 1
                        idDepreciacion += 1
                        id += vidautil
                    Next

                Case 2 '"VEHÍCULOS"
                    If Not ValidacionParametrosVehiculos() Then

                        KryptonMessageBox.Show("Debe llenar todos los datos del vehículo!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    ' PRIMERO EL REGISTRO ACTIVO FIJO
                    Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + 1
                    GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), valfactura, valResidual, vidautil, IdDetaDepre)

                    With _objetoVehiculos
                        .IdActivo = idActivoFijo
                        .Marca = cbmMarcaVehiculo.Text.Trim.ToUpper
                        .Modelo = txtModeloVehiculo.Text.Trim.ToUpper
                        .Serie = txtSerieVehiculo.Text.Trim.ToUpper
                        .Chasis = txtChasisVehiculo.Text.Trim.ToUpper
                        .EstadoActivo = cbmEstadoVehiculo.Text.Trim.ToUpper
                        .Placas = txtPlacaVehiculo.Text.Trim.ToUpper
                        .Motor = txtMotorVehiculo.Text.Trim.ToUpper
                        .Cilindraje = txtCilindrajeVehiculo.Text.Trim.ToUpper
                        .Capacidad = txtCapacidadVehiculo.Text.Trim.ToUpper
                        .Tipo = txtTipoVehiculo.Text.Trim.ToUpper
                        .Color = cbmColorVehiculo.Text.Trim.ToUpper
                        .Anio = cbmAnoFabricacionVehiculo.Text.Trim.ToUpper
                        .Aseguradora = txtAseguradoraNombre.Text.Trim.ToUpper
                        .Seguro = txtSeguro.Text.Trim.ToUpper
                        .Broker = txtBroker.Text.Trim.ToUpper
                        .NumeroPoliza = txtNroPoliza.Text.Trim.ToUpper
                        .CostoPrima = txtCostoPrima.Text.Trim.ToUpper
                        .DispositivoSeguridad = txtDispositivoSeguridad.Text.Trim.ToUpper
                        .FechaInicioContrato = dtpFechaInicioContratoPoliza.Text
                        .FechaFinalContrato = dtpFechaFinalContratoPoliza.Text
                        .FechaRenovacionContrato = dtpFechaRenovacionContratoPoliza.Text
                        .FechaInicioDispositivoSeguridad = dtpInicioContratoDispositivoSeguridad.Text
                        .FechaFinalDispositivoSeguridad = dtpFinalContratoDispositivoSeguridad.Text
                        .FechaRenovacionDispositivoSeguridad = dtpRenovacionContratoDispositivoSeguridad.Text
                        .Estado = 1
                        .Soat = dtpSoat.Text
                    End With
                    _sqlCommands.Add(_objetoVehiculos.NuevoVehiculos())

                    With _objHistorialVehiculos
                        .IdActivoFijo = idActivoFijo
                        .Aseguradora = txtAseguradoraNombre.Text.ToUpper
                        .Seguro = txtSeguro.Text.ToUpper
                        .Broker = txtBroker.Text.ToUpper
                        .NroPoliza = txtNroPoliza.Text.ToUpper
                        .CostoPrima = CDec(txtCostoPrima.Text)
                        .DispositivoSeguridad = txtDispositivoSeguridad.Text.ToUpper
                        .FechaInicioContrato = dtpFechaInicioContratoPoliza.Text
                        .FechaFinalContrato = dtpFechaFinalContratoPoliza.Text
                        .FechaRenovacionContrato = dtpFechaRenovacionContratoPoliza.Text
                        .FechaInicioDispositivo = dtpInicioContratoDispositivoSeguridad.Text
                        .FechaFinalDispositivo = dtpFinalContratoDispositivoSeguridad.Text
                        .FechaRenovacionDispositivo = dtpRenovacionContratoDispositivoSeguridad.Text
                        .Fecha = dtpFechaActual.Value
                        .Soat = dtpSoat.Text
                    End With
                    _sqlCommands.Add(_objHistorialVehiculos.NuevoHistorialVehiculos())

                Case 3 '"TERRENOS"
                    If Not ValidacionParametrosTerrenos() Then

                        KryptonMessageBox.Show("Debe llenar todos los datos del terreno!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    ' PRIMERO EL REGISTRO ACTIVO FIJO
                    Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + 1
                    GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), valfactura, valResidual, vidautil, IdDetaDepre)

                    With _objetoTerrenos
                        .IdActivoFijo = idActivoFijo
                        .Medida = txtMedidaTerreno.Text
                        .Ubicacion = txtUbicacionTerreno.Text.Trim.ToUpper
                        .EstadoTerreno = txtEstadoTerreno.Text.Trim.ToUpper
                        .Estado = 1
                    End With
                    _sqlCommands.Add(_objetoTerrenos.NuevoTerrenos())

                Case 4 '"EQUIPOS DE COMPUTO"
                    If dgvEquiposComputo.RowCount = 0 Then

                        KryptonMessageBox.Show("Debe llenar todos los datos de los equipos de computo!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    For Each row As DataGridViewRow In dgvEquiposComputo.Rows
                        ' PRIMERO EL REGISTRO ACTIVO FIJO
                        Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + id
                        GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, row.Cells(5).Value.ToString.Trim, row.Cells(8).Value.ToString.Trim, row.Cells(9).Value.ToString.Trim, row.Cells(10).Value.ToString.Trim, IdDetaDepre)

                        With _objetoEquiposComputo
                            .IdActivoFijo = idActivoFijo
                            .Marca = row.Cells(0).Value.ToString.Trim
                            .Modelo = row.Cells(1).Value.ToString.Trim
                            .Componente = row.Cells(2).Value.ToString.Trim
                            .EstadoComponente = row.Cells(3).Value.ToString.Trim
                            .ColorComponente = row.Cells(4).Value.ToString.Trim
                            .CodigoComponente = row.Cells(5).Value.ToString.Trim
                            .Estado = 1
                            .Garantia = row.Cells(6).Value
                            Dim docComputo As String = row.Cells("RUTACOMPUTO").Value.ToString()
                            If Not String.IsNullOrEmpty(docComputo) Then
                                If File.Exists(docComputo) Then
                                    .Documento = File.ReadAllBytes(docComputo)
                                Else

                                    .Documento = Nothing
                                End If
                            Else

                                .Documento = Nothing
                            End If

                            .Caducidad = row.Cells(11).Value.ToString.Trim
                            .Ruta = row.Cells(7).Value.ToString.Trim


                        End With
                        _sqlCommands.Add(_objetoEquiposComputo.NuevaEquipoComputo())

                        idActivoFijo += 1
                        idDepreciacion += 1
                        id += vidautil
                    Next

                Case 5 '"LIBROS Y COLECCIONES"
                    If Not ValidacionParametrosLibrosyColecciones() Then

                        KryptonMessageBox.Show("Debe llenar todos los datos de los libros y colecciones!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    ' PRIMERO EL REGISTRO ACTIVO FIJO
                    Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + 1
                    GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), valfactura, valResidual, vidautil, IdDetaDepre)

                    With _objetoLibrosColecciones
                        .IdActivoFijo = idActivoFijo
                        .Editorial = txtEditorial.Text.Trim.ToUpper
                        .Autor = txtAutor.Text.Trim.ToUpper
                        .Tomos = txtTomos.Text
                        .Edicion = cbmAñosEdicionLibros.Text
                        .Estado = 1
                    End With
                    _sqlCommands.Add(_objetoLibrosColecciones.NuevaLibrosColecciones())

                Case 6 '"EQUIPOS DE OFICINA"
                    If dgvEquiposOficina.RowCount = 0 Then

                        KryptonMessageBox.Show("Debe llenar todos los datos de los equipos de oficina!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    For Each row As DataGridViewRow In dgvEquiposOficina.Rows
                        ' PRIMERO EL REGISTRO ACTIVO FIJO
                        Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + id
                        GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, row.Cells(7).Value.ToString.Trim, row.Cells(10).Value.ToString.Trim, row.Cells(11).Value.ToString.Trim, row.Cells(12).Value.ToString.Trim, IdDetaDepre)

                        With _objetoEquiposOficina
                            .IdActivoFijo = idActivoFijo
                            .Marca = row.Cells(0).Value.ToString.Trim
                            .Modelo = row.Cells(1).Value.ToString.Trim
                            .EstadoActivo = row.Cells(2).Value.ToString.Trim
                            .Color = row.Cells(4).Value.ToString.Trim
                            .Serie = row.Cells(3).Value.ToString.Trim
                            .Material = row.Cells(5).Value.ToString.Trim
                            .Anio = row.Cells(6).Value.ToString.Trim
                            .Estado = 1
                            .Garantia = row.Cells(8).Value
                            Dim docOficina As String = row.Cells("rutaOficina").Value.ToString()
                            If Not String.IsNullOrEmpty(docOficina) Then
                                If File.Exists(docOficina) Then
                                    .Documento = File.ReadAllBytes(docOficina)
                                Else

                                    .Documento = Nothing
                                End If
                            Else

                                .Documento = Nothing
                            End If

                            .Ruta = row.Cells(9).Value.ToString.Trim
                            .Caducidad = row.Cells(13).Value.ToString.Trim

                        End With
                        _sqlCommands.Add(_objetoEquiposOficina.NuevoEquiposOficina())

                        idActivoFijo += 1
                        idDepreciacion += 1
                        id += vidautil
                    Next

                Case 7 '"MUEBLES DE OFICINA"
                    If dgvMuebleOficina.RowCount = 0 Then

                        KryptonMessageBox.Show("Debe llenar todos los datos de los muebles!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    For Each row As DataGridViewRow In dgvMuebleOficina.Rows
                        ' PRIMERO EL REGISTRO ACTIVO FIJO
                        Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + id
                        GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, row.Cells(6).Value.ToString.Trim, row.Cells(7).Value.ToString.Trim, row.Cells(8).Value.ToString.Trim, row.Cells(9).Value.ToString.Trim, IdDetaDepre)

                        With _objetoMueblesOficina
                            .IdActivoFijo = idActivoFijo
                            .Marca = row.Cells(0).Value.ToString.Trim
                            .Modelo = row.Cells(1).Value.ToString.Trim
                            .EstadoActivo = row.Cells(2).Value.ToString.Trim
                            .Color = row.Cells(3).Value.ToString.Trim
                            .Material = row.Cells(4).Value.ToString.Trim
                            .Anio = row.Cells(5).Value.ToString.Trim
                            .Estado = 1
                        End With
                        _sqlCommands.Add(_objetoMueblesOficina.NuevoMueblesOficina())

                        idActivoFijo += 1
                        idDepreciacion += 1
                        id += vidautil
                    Next

                Case 8 '"EQUIPOS DE COCINA"
                    If dgvEquipoCocina.RowCount = 0 Then

                        KryptonMessageBox.Show("Debe llenar todos los datos de los equipos!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    For Each row As DataGridViewRow In dgvEquipoCocina.Rows
                        ' PRIMERO EL REGISTRO ACTIVO FIJO
                        Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + id
                        GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, row.Cells(7).Value.ToString.Trim, row.Cells(7).Value.ToString.Trim, row.Cells(8).Value.ToString.Trim, row.Cells(9).Value.ToString.Trim, IdDetaDepre)

                        With _objetoEquiposCocina
                            .IdActivoFijo = idActivoFijo
                            .Marca = row.Cells(0).Value.ToString.Trim
                            .Modelo = row.Cells(1).Value.ToString.Trim
                            .EstadoActivo = row.Cells(2).Value.ToString.Trim
                            .Color = row.Cells(3).Value.ToString.Trim
                            .Serie = row.Cells(4).Value.ToString.Trim
                            .Material = row.Cells(5).Value.ToString.Trim
                            .Anio = row.Cells(6).Value.ToString.Trim
                            .Estado = 1
                        End With
                        _sqlCommands.Add(_objetoEquiposCocina.NuevoEquiposCocina())

                        idActivoFijo += 1
                        idDepreciacion += 1
                        id += vidautil
                    Next

                Case 9 '"EQUIPOS DE AMBIENTACIÓN"
                    If dgvEquipoAmbientacion.RowCount = 0 Then

                        KryptonMessageBox.Show("Debe llenar todos los datos de los equipos!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    For Each row As DataGridViewRow In dgvEquipoAmbientacion.Rows
                        ' PRIMERO EL REGISTRO ACTIVO FIJO
                        Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + id
                        GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, row.Cells(10).Value.ToString.Trim, row.Cells(11).Value.ToString.Trim, row.Cells(12).Value.ToString.Trim, row.Cells(13).Value.ToString.Trim, IdDetaDepre)

                        With _objetoEquiposAmbientacion
                            .IdActivoFijo = idActivoFijo
                            .Marca = row.Cells(0).Value.ToString.Trim
                            .Modelo = row.Cells(1).Value.ToString.Trim
                            .Color = row.Cells(2).Value.ToString.Trim
                            .Material = row.Cells(3).Value.ToString.Trim
                            .Serie = row.Cells(4).Value.ToString.Trim
                            .Amperaje = row.Cells(5).Value.ToString.Trim
                            .Voltaje = row.Cells(6).Value.ToString.Trim
                            .Tipo = row.Cells(7).Value.ToString.Trim
                            .Anio = row.Cells(8).Value.ToString.Trim
                            .EstadoActivo = row.Cells(9).Value.ToString.Trim
                            .Estado = 1
                        End With
                        _sqlCommands.Add(_objetoEquiposAmbientacion.NuevoEquiposAmbientacion())

                        idActivoFijo += 1
                        idDepreciacion += 1
                        id += vidautil
                    Next

                Case 10 '"EQUIPOS DE COMUNICACIÓN Y TELEFONÍA"
                    If dgvEquipoComunicacion.RowCount = 0 Then

                        KryptonMessageBox.Show("Debe llenar todos los datos de los equipos!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    For Each row As DataGridViewRow In dgvEquipoComunicacion.Rows
                        ' PRIMERO EL REGISTRO ACTIVO FIJO
                        Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + id
                        GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, row.Cells(9).Value.ToString.Trim, row.Cells(12).Value.ToString.Trim, row.Cells(13).Value.ToString.Trim, row.Cells(14).Value.ToString.Trim, IdDetaDepre)



                        With _objetoEquiposComunicacion
                            .IdActivoFijo = idActivoFijo
                            .Marca = row.Cells(0).Value.ToString.Trim
                            .Modelo = row.Cells(1).Value.ToString.Trim
                            .EstadoActivo = row.Cells(2).Value.ToString.Trim
                            .Serie = row.Cells(3).Value.ToString.Trim
                            .Color = row.Cells(4).Value.ToString.Trim
                            .Material = row.Cells(5).Value.ToString.Trim
                            .Anio = row.Cells(6).Value.ToString.Trim
                            .InicioPermisoFrecuencia = row.Cells(7).Value.ToString.Trim
                            .FinalPermisoFrecuencia = row.Cells(8).Value.ToString.Trim
                            .Estado = 1
                            .Garantia = row.Cells(10).Value
                            .Ruta = row.Cells(11).Value.ToString.Trim
                            Dim docComunicacion As String = row.Cells("rutaComunicacion").Value.ToString()
                            If Not String.IsNullOrEmpty(docComunicacion) Then
                                If File.Exists(docComunicacion) Then
                                    .Documento = File.ReadAllBytes(docComunicacion)
                                Else

                                    .Documento = Nothing
                                End If
                            Else

                                .Documento = Nothing
                            End If

                        End With
                        _sqlCommands.Add(_objetoEquiposComunicacion.NuevaEquipoComunicacion())

                        idActivoFijo += 1
                        idDepreciacion += 1
                        id += vidautil
                    Next

                Case 11 '"EQUIPOS DE SEGURIDAD INDUSTRIAL"
                    If dgvEquipoSeguridad.RowCount = 0 Then

                        KryptonMessageBox.Show("Debe llenar todos los datos de los equipos de seguridad!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    For Each row As DataGridViewRow In dgvEquipoSeguridad.Rows
                        ' PRIMERO EL REGISTRO ACTIVO FIJO
                        Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + id
                        GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, row.Cells(8).Value.ToString.Trim, row.Cells(9).Value.ToString.Trim, row.Cells(10).Value.ToString.Trim, row.Cells(11).Value.ToString.Trim, IdDetaDepre)



                        With _objetoEquiposSeguridad
                            .IdActivoFijo = idActivoFijo
                            .Marca = row.Cells(0).Value.ToString.Trim
                            .Modelo = row.Cells(1).Value.ToString.Trim
                            .EstadoActivo = row.Cells(2).Value.ToString.Trim
                            .Serie = row.Cells(3).Value.ToString.Trim
                            .Color = row.Cells(4).Value.ToString.Trim
                            .Material = row.Cells(5).Value.ToString.Trim
                            .Anio = row.Cells(6).Value.ToString.Trim
                            .Adicional = row.Cells(7).Value.ToString.Trim
                            .Estado = 1
                        End With
                        _sqlCommands.Add(_objetoEquiposSeguridad.NuevaEquipoSeguridad())

                        idActivoFijo += 1
                        idDepreciacion += 1
                        id += vidautil
                    Next

                Case 12 '"CAMARAS DE SEGURIDAD"
                    If dgvCamara.RowCount = 0 Then

                        KryptonMessageBox.Show("Debe llenar todos los datos de las camaras de seguridad!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    For Each row As DataGridViewRow In dgvCamara.Rows
                        ' PRIMERO EL REGISTRO ACTIVO FIJO
                        Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + id
                        GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, row.Cells(8).Value.ToString.Trim, row.Cells(11).Value.ToString.Trim, row.Cells(12).Value.ToString.Trim, row.Cells(13).Value.ToString.Trim, IdDetaDepre)

                        With _objetoCamarasSeguridad
                            .IdActivoFijo = idActivoFijo
                            .Marca = row.Cells(0).Value.ToString.Trim
                            .Modelo = row.Cells(1).Value.ToString.Trim
                            .EstadoActivo = row.Cells(2).Value.ToString.Trim
                            .Serie = row.Cells(3).Value.ToString.Trim
                            .Color = row.Cells(4).Value.ToString.Trim
                            .Material = row.Cells(5).Value.ToString.Trim
                            .Anio = row.Cells(6).Value.ToString.Trim
                            .Adicional = row.Cells(7).Value.ToString.Trim
                            .Estado = 1
                            .Garantia = row.Cells(9).Value
                            Dim docCamara As String = row.Cells("rutaCamara").Value.ToString()
                            If Not String.IsNullOrEmpty(docCamara) Then
                                If File.Exists(docCamara) Then
                                    .Documento = File.ReadAllBytes(docCamara)
                                Else

                                    .Documento = Nothing
                                End If
                            Else

                                .Documento = Nothing
                            End If
                            .Caducidad = row.Cells(14).Value.ToString.Trim
                            .Ruta = row.Cells(10).Value.ToString.Trim
                        End With
                        _sqlCommands.Add(_objetoCamarasSeguridad.NuevaCamarasSeguridad())

                        idActivoFijo += 1
                        idDepreciacion += 1
                        id += vidautil
                    Next


                Case 13 '"GENERADORES"
                    If Not ValidacionParametrosGeneradores() Then

                        KryptonMessageBox.Show("Debe llenar todos los datos del generador!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    ' PRIMERO EL REGISTRO ACTIVO FIJO
                    Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + id
                    GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), valfactura, valResidual, vidautil, IdDetaDepre)

                    With _objetoGenerador
                        .IdActivoFijo = idActivoFijo
                        .Marca = cbmMarcaGeneradores.Text.Trim.ToUpper
                        .Modelo = txtModeloGeneradores.Text.Trim.ToUpper
                        .EstadoActivo = cbmEstadoGeneradores.Text.Trim.ToUpper
                        .Color = cbmColorGeneradores.Text.Trim.ToUpper
                        .Serie = txtSerieGeneradores.Text.Trim.ToUpper
                        .Material = cbmMaterialGeneradores.Text.Trim.ToUpper
                        .Amperaje = txtAmperajeGeneradores.Text
                        .Voltaje = txtVoltajeGeneradores.Text
                        .Tipo = txtTipoGeneradores.Text.Trim.ToUpper
                        .Adicional = txtAdicionalGeneradores.Text.Trim.ToUpper
                        .Anio = cbmAñosGeneradores.Text
                        .Estado = 1
                    End With
                    _sqlCommands.Add(_objetoGenerador.NuevaGenerador())

                Case 14 '"CHALECOS"
                    If dgvChaleco.RowCount = 0 Then

                        KryptonMessageBox.Show("Debe llenar todos los datos de los chalecos!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    For Each row As DataGridViewRow In dgvChaleco.Rows
                        ' PRIMERO EL REGISTRO ACTIVO FIJO
                        Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + id
                        GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, row.Cells(9).Value.ToString.Trim, row.Cells(11).Value.ToString.Trim, row.Cells(12).Value.ToString.Trim, row.Cells(13).Value.ToString.Trim, IdDetaDepre)

                        With _objetoChaleco
                            .IdActivoFijo = idActivoFijo
                            .Marca = row.Cells(0).Value.ToString.Trim
                            .Modelo = row.Cells(1).Value.ToString.Trim
                            .EstadoActivo = row.Cells(2).Value.ToString.Trim
                            .Color = row.Cells(4).Value.ToString.Trim
                            .Serie = row.Cells(3).Value.ToString.Trim
                            .Material = row.Cells(5).Value.ToString.Trim
                            .Anio = row.Cells(6).Value.ToString.Trim
                            .Adicional = row.Cells(7).Value.ToString.Trim
                            .Caducidad = row.Cells(14).Value.ToString.Trim
                            .Estado = 1
                            .Garantia = row.Cells(9).Value
                            Dim docChaleco As String = row.Cells("rutaChaleco").Value.ToString()
                            If Not String.IsNullOrEmpty(docChaleco) Then
                                If File.Exists(docChaleco) Then
                                    .Documento = File.ReadAllBytes(docChaleco)
                                Else

                                    .Documento = Nothing
                                End If
                            Else

                                .Documento = Nothing
                            End If

                            .Ruta = row.Cells(10).Value.ToString.Trim
                        End With
                        _sqlCommands.Add(_objetoChaleco.NuevoChaleco())

                        idActivoFijo += 1
                        idDepreciacion += 1
                        id += vidautil
                    Next


                Case 15 '"SOFTWARE"
                    If Not ValidacionParametrosSoftware() Then

                        KryptonMessageBox.Show("Debe llenar todos los datos del software!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                        Return
                    End If

                    ' PRIMERO EL REGISTRO ACTIVO FIJO
                    Dim IdDetaDepre = _objDetalleDepreciacion.BuscarMayorIdDetalleDepreciacion(_tipoCon) + 1
                    GuardarDatosActivoGeneralVarios(idActivoFijo, idDepreciacion, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), valfactura, valResidual, vidautil, IdDetaDepre)

                    With _objetoSoftware
                        .IdActivoFijo = idActivoFijo
                        .Detalle = txtDetalleSoftware.Text.Trim.ToUpper
                        .Version = txtVersionSoftware.Text.Trim.ToUpper
                        .Provedor = txtProvedorSoftware.Text.Trim.ToUpper
                        .Tipo = cbmTipoSoftware.Text.Trim.ToUpper
                        .Estado = 1
                    End With
                    _sqlCommands.Add(_objetoSoftware.NuevaSoftware())
            End Select

            If EsDialogo Then DialogResult = DialogResult.OK


            Dim nombreU As String = "Ingreso de Activo por: " & UserName
            Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, nombreU)
            If res(0) Then
                Select Case _formDialogoNuevoActivo.Tipo
                    Case 0 '"ARMAS"
                        HabilitarCamposArmas(False, False)
                    Case 1 '"RADIOS"
                        HabilitarCamposRadios(False, False)
                    Case 2 '"VEHÍCULOS"
                        HabilitarCamposVehiculos(False, False)
                    Case 3 '"TERRENOS"
                        HabilitarCamposTerrenos(False, False)
                    Case 4 '"EQUIPOS DE COMPUTO"
                        HabilitarCamposEquiposComputo(False, False)
                    Case 5 '"LIBROS Y COLECCIONES"
                        HabilitarCamposLibrosyColecciones(False, False)
                    Case 6 '"EQUIPOS DE OFICINA"
                        HabilitarCamposEquiposOficina(False, False)
                    Case 7 '"MUEBLES DE OFICINA"
                        HabilitarCamposMueblesOficina(False, False)
                    Case 8 '"EQUIPOS DE COCINA"
                        HabilitarCamposEquiposCocina(False, False)
                    Case 9 '"EQUIPOS DE AMBIENTACIÓN"
                        HabilitarCamposEquiposAmbientación(False, False)
                    Case 10 '"EQUIPOS DE COMUNICACIÓN Y TELEFONÍA"
                        HabilitarCamposEquiposComunicacion(False, False)
                    Case 11 '"EQUIPOS DE SEGURIDAD INDUSTRIAL"
                        HabilitarCamposEquiposSeguridad(False, False)
                    Case 12 '"CAMARAS DE SEGURIDAD"
                        HabilitarCamposCamarasSeguridad(False, False)
                    Case 13 '"GENERADORES"
                        HabilitarCamposGeneradores(False, False)
                    Case 14 '"CHALECOS"
                        HabilitarCamposChalecos(False, False)
                    Case 15 '"SOFTWARE" 
                        HabilitarCamposSoftware(False, False)
                End Select

                HabiLitarParametrosActivos(False, False)
                btnNuevo.Enabled = True
                btnGuardar.Enabled = False
                ButtonCancelar.Enabled = False
                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            Else
                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
                Return
            End If



        End Sub

        Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonCancelar.Click
            If EsDialogo Then DialogResult = DialogResult.Cancel

            _tipoAccion = 0
            HabilitarCamposArmas(False, True)
            HabilitarCamposRadios(False, True)
            HabilitarCamposVehiculos(False, True)
            HabilitarCamposTerrenos(False, True)
            HabilitarCamposEquiposComputo(False, True)
            HabilitarCamposLibrosyColecciones(False, True)
            HabilitarCamposEquiposOficina(False, True)
            HabilitarCamposMueblesOficina(False, True)
            HabilitarCamposEquiposCocina(False, True)
            HabilitarCamposEquiposAmbientación(False, True)
            HabilitarCamposEquiposComunicacion(False, True)
            HabilitarCamposEquiposSeguridad(False, True)
            HabilitarCamposCamarasSeguridad(False, True)
            HabilitarCamposGeneradores(False, True)
            HabilitarCamposChalecos(False, True)
            HabilitarCamposSoftware(False, True)
            HabiLitarParametrosActivos(False, True)
            tcVarios.SelectedIndex = 0
            btnNuevo.Enabled = True
            btnGuardar.Enabled = False
            ButtonCancelar.Enabled = False
        End Sub

        Private Sub cbmCuentasActivo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCuentasActivo.SelectedValueChanged
            If cbmCuentasActivo.SelectedValue Is Nothing Or TypeOf cbmCuentasActivo.SelectedValue Is DataRowView Then Return
            txtcuentaActivo.Text = cbmCuentasActivo.SelectedValue
        End Sub

        Private Sub cbmCuentaGastos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCuentaGastos.SelectedValueChanged
            If cbmCuentaGastos.SelectedValue Is Nothing Or TypeOf cbmCuentaGastos.SelectedValue Is DataRowView Then Return
            txtCuentaGastos.Text = cbmCuentaGastos.SelectedValue
        End Sub

        Private Sub cbmCuentaDepreciacion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cbmCuentaDepreciacion.SelectedValueChanged
            If cbmCuentaDepreciacion.SelectedValue Is Nothing Or TypeOf cbmCuentaDepreciacion.SelectedValue Is DataRowView Then Return
            txtCuentaDepreciacion.Text = cbmCuentaDepreciacion.SelectedValue
            Select Case txtCuentaDepreciacion.Text
                Case "5202190101" ' DEPRECIACIÓN MUEBLES Y ENSERES
                    _porcentajeDepreciacion = 0.1
                    txtAñosVidaUtil.Text = "10"
                Case "5202190102" ' DEPRECIACIÓN MAQUINARIAS Y EQUIPOS
                    _porcentajeDepreciacion = 0.1
                    txtAñosVidaUtil.Text = "10"
                Case "5202190103" ' DEPRECIACIÓN VEHÍCULOS
                    _porcentajeDepreciacion = 0.2
                    txtAñosVidaUtil.Text = "5"
                Case "5202190106"
                    _porcentajeDepreciacion = 0.1
                    txtAñosVidaUtil.Text = "10"
                Case Else ' DEPRECIACIÓN EQUIPOS EN GENERAL
                    _porcentajeDepreciacion = 0.3333
                    txtAñosVidaUtil.Text = "3"
            End Select
        End Sub

        Private Sub txtValorFactura_KeyUp(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles txtValorFactura.KeyUp
            lblValorResidual_Click(Nothing, Nothing)
        End Sub

        Private Sub tcVarios_Selecting(ByVal sender As System.Object, ByVal e As Windows.Forms.TabControlCancelEventArgs) Handles tcVarios.Selecting
            If _tipoAccion <> 0 Then e.Cancel = True
        End Sub

        Private Sub FormIngresoActivosFijos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    MenuStrip1.ForeColor = Color.White
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvEquiposComputo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    MenuStrip1.ForeColor = Color.White
                    dgvEquiposComputo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac

                Case Else
                    Icon = My.Resources.logo_c
                    'MenuStrip1.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    MenuStrip1.ForeColor = Color.White
                    dgvEquiposComputo.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro

            End Select


            'customTabControl.
            'dgvMantenimientoDepreciaciones.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvRadios.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvArmas.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvCamara.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvChaleco.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvEquipoCocina.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvEquipoAmbientacion.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvEquipoComunicacion.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvEquipoSeguridad.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvEquiposComputo.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvEquiposOficina.Font = New Font("Roboto", 8, FontStyle.Regular)
            dgvMuebleOficina.Font = New Font("Roboto", 8, FontStyle.Regular)
            lblArmasCount.ForeColor = ValidationForms.GetColorSistema(_tipoCon)
            lblCamaraCount.ForeColor = ValidationForms.GetColorSistema(_tipoCon)
            lblChalecoCount.ForeColor = ValidationForms.GetColorSistema(_tipoCon)
            lblRadiosCount.ForeColor = ValidationForms.GetColorSistema(_tipoCon)
            lblEquiposOficinaCount.ForeColor = ValidationForms.GetColorSistema(_tipoCon)
            lblEquipoAmbientacionCount.ForeColor = ValidationForms.GetColorSistema(_tipoCon)
            lblEquipoCocinaCount.ForeColor = ValidationForms.GetColorSistema(_tipoCon)
            lblEquipoComunicacionCount.ForeColor = ValidationForms.GetColorSistema(_tipoCon)
            lblEquipoSeguridadCount.ForeColor = ValidationForms.GetColorSistema(_tipoCon)
            lblMarcaEquipoComputo.ForeColor = ValidationForms.GetColorSistema(_tipoCon)
            lblMuebleOficinaCount.ForeColor = ValidationForms.GetColorSistema(_tipoCon)






            _sqlCommands = New List(Of SqlCommand)
        End Sub


        Private Sub cbmSecuencial_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbmSecuencial.SelectedValueChanged
            If cbmSecuencial.SelectedValue Is Nothing Or TypeOf cbmSecuencial.SelectedValue Is DataRowView Then Return
        End Sub
        ''' <summary>
        ''' AJUSTE PARA AGREGAR N ACTIVOS A LA VEZ
        ''' </summary> 
        Private Sub btnAgregarArma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarArma.Click
            If ValidacionParametrosArmas() Then
                dgvArmas.Rows.Add(cbxOrigen.Text.Trim, txtSerieArmas.Text.Trim, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo),
                                  txtPermisoFuncionamiento.Text.Trim, txtPermisoComandoConjunto.Text.Trim, txtNroTenenciaArmas.Text.Trim,
                                  dtpAceptacionTenencia.Value.ToShortDateString(), dtpCaducidadTenencia.Value.ToShortDateString(), txtNroMatriculaArma.Text.Trim,
                                  dtpAceptacionMatricula.Value.ToShortDateString(), dtpCaducidadMatricula.Value.ToShortDateString(), txtValorFactura.Text.Trim, txtValorResidual.Text.Trim, txtAñosVidaUtil.Text.Trim)

                ' LIMPIAR
                txtPermisoFuncionamiento.Clear()
                txtPermisoComandoConjunto.Clear()
                cbxOrigen.SelectedIndex = 0
                txtSerieArmas.Clear()
                txtNroTenenciaArmas.Clear()
                txtNroMatriculaArma.Clear()


                dgvArmas.Refresh()

                lblArmasCount.Text = "Verifique las series antes de guardar!!        " & dgvArmas.RowCount & " armas en TOTAL!"
            Else

                KryptonMessageBox.Show("Debe llenar todos los datos generales del arma!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub btnEliminarArma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarArma.Click
            If dgvArmas.RowCount = 0 Then Return
            If dgvArmas.CurrentRow Is Nothing Then Return
            dgvArmas.Rows.RemoveAt(dgvArmas.CurrentRow.Index)
            dgvArmas.Refresh()
            If dgvArmas.RowCount = 0 Then
                lblArmasCount.Text = "Verifique las series antes de guardar!!"
            Else
                lblArmasCount.Text = "Verifique las series antes de guardar!!        " & dgvArmas.RowCount & " ARMAS EN TOTAL!"
            End If
        End Sub

        Private Sub btnAddRadio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRadio.Click
            If ValidacionParametrosRadios() Then

                dgvRadios.Rows.Add(cbmMarcaRadio.Text.Trim, txtModeloRadio.Text.Trim, txtSerieRadio.Text.Trim, cbmColoresRadio.Text.Trim,
                                   cbmEstadoRadio.Text.Trim, txtNumeroPermisoUsoRadio.Text.Trim, dtpFecPerUsoRadioAceptacion.Value.ToShortDateString,
                                   dtpFecPerRadioCaducidad.Value.ToShortDateString, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), If(chkGarantiaRadio.Checked, 1, 0), txtGarantia.Text.Trim, txtValorFactura.Text.Trim, txtValorResidual.Text.Trim, txtAñosVidaUtil.Text.Trim)

                ' LIMPIAR
                cbmMarcaRadio.SelectedIndex = 0
                txtModeloRadio.Clear()
                txtSerieRadio.Clear()
                cbmEstadoRadio.SelectedIndex = 0
                cbmColoresRadio.SelectedIndex = 0
                txtNumeroPermisoUsoRadio.Clear()
                chkGarantiaRadio.Checked = False
                txtGarantia.Clear()
                dgvRadios.Refresh()

                lblRadiosCount.Text = "Verifique las series antes de guardar!!        " & dgvArmas.RowCount & " RADIOS EN TOTAL!"
            Else

                KryptonMessageBox.Show("Debe llenar todos los datos generales del radio!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub btnDelRadio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelRadio.Click
            If dgvRadios.RowCount = 0 Then Return
            If dgvRadios.CurrentRow Is Nothing Then Return
            dgvRadios.Rows.RemoveAt(dgvRadios.CurrentRow.Index)
            dgvRadios.Refresh()
            If dgvRadios.RowCount = 0 Then
                lblRadiosCount.Text = "Verifique las series antes de guardar!!"
            Else
                lblRadiosCount.Text = "Verifique las series antes de guardar!!        " & dgvRadios.RowCount & " RADIOS EN TOTAL!"
            End If
        End Sub

        Private Sub btnAddEquipoOficina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEquipoOficina.Click
            If ValidacionParametrosEquiposOficina() Then

                dgvEquiposOficina.Rows.Add(cbmMarcaEquiposOficina.Text.Trim, txtModeloEquiposOficina.Text.Trim, cbmEstadoActivoEquiposOficina.Text.Trim, txtSerieEquiposOficina.Text.Trim,
                                   cbmColorEquiposOficina.Text.Trim, cbmMaterialEquiposOficina.Text.Trim, cbmAñosEquiposOficina.Text.Trim, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), If(chkGarantiaOficina.Checked, 1, 0), txtGarantiaOficina.Text.Trim, txtValorFactura.Text.Trim, txtValorResidual.Text.Trim, txtAñosVidaUtil.Text.Trim, dtpCaducidadOficina.Value.ToShortDateString)

                ' LIMPIAR
                cbmMarcaEquiposOficina.SelectedIndex = 0
                txtModeloEquiposOficina.Clear()
                cbmEstadoActivoEquiposOficina.SelectedIndex = 0
                txtSerieEquiposOficina.Clear()
                cbmColorEquiposOficina.SelectedIndex = 0
                cbmMaterialEquiposOficina.SelectedIndex = 0
                cbmAñosEquiposOficina.SelectedIndex = 0

                dgvEquiposOficina.Refresh()

                lblEquiposOficinaCount.Text = "Verifique las series antes de guardar!!        " & dgvEquiposOficina.RowCount & " EQUIPOS EN TOTAL!"
            Else

                KryptonMessageBox.Show("Debe llenar todos los datos generales del equipo!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub btnDelEquipoOficina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelEquipoOficina.Click
            If dgvEquiposOficina.RowCount = 0 Then Return
            If dgvEquiposOficina.CurrentRow Is Nothing Then Return
            dgvEquiposOficina.Rows.RemoveAt(dgvEquiposOficina.CurrentRow.Index)
            dgvEquiposOficina.Refresh()
            If dgvEquiposOficina.RowCount = 0 Then
                lblEquiposOficinaCount.Text = "Verifique las series antes de guardar!!"
            Else
                lblEquiposOficinaCount.Text = "Verifique las series antes de guardar!!        " & dgvEquiposOficina.RowCount & " EQUIPOS EN TOTAL!"
            End If
        End Sub

        Private Sub btnAddMuebleOficina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMuebleOficina.Click
            If ValidacionParametrosMueblesOficina() Then

                dgvMuebleOficina.Rows.Add(cbmMarcaMueblesOficina.Text.Trim, txtModeloMueblesOficina.Text.Trim, cbmEstadoActivoMueblesOficina.Text.Trim,
                                   cbmColorMueblesOficina.Text.Trim, cbmMaterialMueblesOficina.Text.Trim, cbmAñosMueblesOficina.Text.Trim, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), txtValorFactura.Text.Trim, txtValorResidual.Text.Trim, txtAñosVidaUtil.Text.Trim)

                ' LIMPIAR
                cbmMarcaMueblesOficina.SelectedIndex = 0
                txtModeloMueblesOficina.Clear()
                cbmEstadoActivoMueblesOficina.SelectedIndex = 0
                cbmColorMueblesOficina.SelectedIndex = 0
                cbmMaterialMueblesOficina.SelectedIndex = 0
                cbmAñosMueblesOficina.SelectedIndex = 0

                dgvMuebleOficina.Refresh()

                lblMuebleOficinaCount.Text = "Verifique las series antes de guardar!!        " & dgvMuebleOficina.RowCount & " MUEBLES EN TOTAL!"
            Else

                KryptonMessageBox.Show("Debe llenar todos los datos generales del equipo!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub btnDelMuebleOficina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelMuebleOficina.Click
            If dgvMuebleOficina.RowCount = 0 Then Return
            If dgvMuebleOficina.CurrentRow Is Nothing Then Return
            dgvMuebleOficina.Rows.RemoveAt(dgvMuebleOficina.CurrentRow.Index)
            dgvMuebleOficina.Refresh()
            If dgvMuebleOficina.RowCount = 0 Then
                lblMuebleOficinaCount.Text = "Verifique las series antes de guardar!!"
            Else
                lblMuebleOficinaCount.Text = "Verifique las series antes de guardar!!        " & dgvMuebleOficina.RowCount & " MUEBLES EN TOTAL!"
            End If
        End Sub

        Private Sub btnAddEquipoCocina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEquipoCocina.Click
            If ValidacionParametrosEquiposCocina() Then

                dgvEquipoCocina.Rows.Add(cbmMarcaEquiposCocina.Text.Trim, txtModeloEquiposCocina.Text.Trim, cbmEstadoEquiposCocina.Text.Trim, txtSerieEquiposCocina.Text.Trim,
                                   cbmColorEquiposCocina.Text.Trim, cbmMaterialEquiposCocina.Text.Trim, cbmAñosEquiposCocina.Text.Trim, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), txtGarantiaOficina.Text.Trim, txtValorFactura.Text.Trim, txtValorResidual.Text.Trim, txtAñosVidaUtil.Text.Trim)

                ' LIMPIAR
                cbmMarcaEquiposCocina.SelectedIndex = 0
                txtModeloEquiposCocina.Clear()
                cbmEstadoEquiposCocina.SelectedIndex = 0
                txtSerieEquiposCocina.Clear()
                cbmColorEquiposCocina.SelectedIndex = 0
                cbmMaterialEquiposCocina.SelectedIndex = 0
                cbmAñosEquiposCocina.SelectedIndex = 0

                dgvEquipoCocina.Refresh()

                lblEquipoCocinaCount.Text = "Verifique las series antes de guardar!!        " & dgvEquipoCocina.RowCount & " EQUIPOS EN TOTAL!"
            Else

                KryptonMessageBox.Show("Debe llenar todos los datos generales del equipo!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub btnDellEquipoCocina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDellEquipoCocina.Click
            If dgvEquipoCocina.RowCount = 0 Then Return
            If dgvEquipoCocina.CurrentRow Is Nothing Then Return
            dgvEquipoCocina.Rows.RemoveAt(dgvEquipoCocina.CurrentRow.Index)
            dgvEquipoCocina.Refresh()
            If dgvEquipoCocina.RowCount = 0 Then
                lblEquipoCocinaCount.Text = "Verifique las series antes de guardar!!"
            Else
                lblEquipoCocinaCount.Text = "Verifique las series antes de guardar!!        " & dgvEquipoCocina.RowCount & " EQUIPOS EN TOTAL!"
            End If
        End Sub

        Private Sub btnAddEquipoAmbientacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEquipoAmbientacion.Click
            If ValidacionParametrosEquiposAmbientación() Then

                dgvEquipoAmbientacion.Rows.Add(cbmMarcaEquiposAmbientacion.Text.Trim, txtModeloEquiposAmbientacion.Text.Trim, cbmColorEquiposAmbientacion.Text.Trim, cbmMaterialEquiposAmbientacion.Text.Trim,
                                   txtSerieEquiposAmbientacion.Text.Trim, txtAmperajeEquiposAmbientacion.Text.Trim, txtVoltajeEquiposAmbientacion.Text.Trim, txtTipoEquiposAmbientacion.Text.Trim,
                                   cbmAñosEquiposAmbientacion.Text.Trim, cbmEstadoEquiposAmbientacion.Text.Trim, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), txtValorFactura.Text.Trim, txtValorResidual.Text.Trim, txtAñosVidaUtil.Text.Trim)

                ' LIMPIAR
                cbmMarcaEquiposAmbientacion.SelectedIndex = 0
                txtModeloEquiposAmbientacion.Clear()
                cbmEstadoEquiposAmbientacion.SelectedIndex = 0
                txtSerieEquiposAmbientacion.Clear()
                cbmColorEquiposAmbientacion.SelectedIndex = 0
                cbmMaterialEquiposAmbientacion.SelectedIndex = 0
                cbmAñosEquiposAmbientacion.SelectedIndex = 0
                txtAmperajeEquiposAmbientacion.Clear()
                txtVoltajeEquiposAmbientacion.Clear()
                txtTipoEquiposAmbientacion.Clear()

                dgvEquipoAmbientacion.Refresh()

                lblEquipoAmbientacionCount.Text = "Verifique las series antes de guardar!!        " & dgvEquipoAmbientacion.RowCount & " EQUIPOS EN TOTAL!"
            Else

                KryptonMessageBox.Show("Debe llenar todos los datos generales del equipo!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub btnDelEquipoAmbientacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelEquipoAmbientacion.Click
            If dgvEquipoAmbientacion.RowCount = 0 Then Return
            If dgvEquipoAmbientacion.CurrentRow Is Nothing Then Return
            dgvEquipoAmbientacion.Rows.RemoveAt(dgvEquipoAmbientacion.CurrentRow.Index)
            dgvEquipoAmbientacion.Refresh()
            If dgvEquipoAmbientacion.RowCount = 0 Then
                lblEquipoAmbientacionCount.Text = "Verifique las series antes de guardar!!"
            Else
                lblEquipoAmbientacionCount.Text = "Verifique las series antes de guardar!!        " & dgvEquipoAmbientacion.RowCount & " EQUIPOS EN TOTAL!"
            End If
        End Sub

        Private Sub btnAddEquipoComunicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If ValidacionParametrosEquiposComunicacion() Then

                dgvEquipoComunicacion.Rows.Add(cbmMarcaEquiposComunicacion.Text.Trim, txtModeloEquiposComunicacion.Text.Trim, cbmEstadoEquiposComunicacion.Text.Trim, txtSerieEquiposComunicacion.Text.Trim,
                                   cbmColorEquiposComunicacion.Text.Trim, cbmMaterialEquiposComunicacion.Text.Trim, cbmAñosEquiposComunicacion.Text.Trim,
                                   dtpInicioPermisoFrecuencia.Value.ToShortDateString, dtpFinaLPermisoFrecuencia.Value.ToShortDateString, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), If(chkGarantiaComunicacion.Checked, 1, 0), txtGarantiaComunicacion.Text.Trim, txtValorFactura.Text.Trim, txtValorResidual.Text.Trim, txtAñosVidaUtil.Text.Trim)

                ' LIMPIAR
                cbmMarcaEquiposComunicacion.SelectedIndex = 0
                txtModeloEquiposComunicacion.Clear()
                cbmEstadoEquiposComunicacion.SelectedIndex = 0
                txtSerieEquiposComunicacion.Clear()
                cbmColorEquiposComunicacion.SelectedIndex = 0
                cbmMaterialEquiposComunicacion.SelectedIndex = 0
                cbmAñosEquiposComunicacion.SelectedIndex = 0
                chkGarantiaComunicacion.Checked = False
                txtGarantiaComunicacion.Clear()
                dgvEquipoComunicacion.Refresh()

                lblEquipoComunicacionCount.Text = "Verifique las series antes de guardar!!        " & dgvEquipoComunicacion.RowCount & " EQUIPOS EN TOTAL!"
            Else

                KryptonMessageBox.Show("Debe llenar todos los datos generales del equipo!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub btnDelEquipoComunicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If dgvEquipoComunicacion.RowCount = 0 Then Return
            If dgvEquipoComunicacion.CurrentRow Is Nothing Then Return
            dgvEquipoComunicacion.Rows.RemoveAt(dgvEquipoComunicacion.CurrentRow.Index)
            dgvEquipoComunicacion.Refresh()
            If dgvEquipoComunicacion.RowCount = 0 Then
                lblEquipoComunicacionCount.Text = "Verifique las series antes de guardar!!"
            Else
                lblEquipoComunicacionCount.Text = "Verifique las series antes de guardar!!        " & dgvEquipoComunicacion.RowCount & " EQUIPOS EN TOTAL!"
            End If
        End Sub

        Private Sub btnAddEquipoSeguridad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEquipoSeguridad.Click
            If ValidacionParametrosEquiposSeguridad() Then

                dgvEquipoSeguridad.Rows.Add(cbmMarcaEquipoSeguridad.Text.Trim, txtModeloEquipoSeguridad.Text.Trim, cbmEstadoEquipoSeguridad.Text.Trim, txtSerieEquipoSeguridad.Text.Trim,
                                   cbmColorEquipoSeguridad.Text.Trim, cbmMaterialEquipoSeguridad.Text.Trim, cbmAñosEquipoSeguridad.Text.Trim,
                                    txtAdicionalEquipoSeguridad.Text.Trim, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), txtValorFactura.Text.Trim, txtValorResidual.Text.Trim, txtAñosVidaUtil.Text.Trim)

                ' LIMPIAR
                cbmMarcaEquipoSeguridad.SelectedIndex = 0
                txtModeloEquipoSeguridad.Clear()
                cbmEstadoEquipoSeguridad.SelectedIndex = 0
                txtSerieEquipoSeguridad.Clear()
                cbmColorEquipoSeguridad.SelectedIndex = 0
                cbmMaterialEquipoSeguridad.SelectedIndex = 0
                cbmAñosEquipoSeguridad.SelectedIndex = 0
                txtAdicionalEquipoSeguridad.Clear()

                dgvEquipoSeguridad.Refresh()

                lblEquipoSeguridadCount.Text = "Verifique las series antes de guardar!!        " & dgvEquipoSeguridad.RowCount & " EQUIPOS EN TOTAL!"
            Else

                KryptonMessageBox.Show("Debe llenar todos los datos generales del equipo!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub btnDelEquipoSeguridad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelEquipoSeguridad.Click
            If dgvEquipoSeguridad.RowCount = 0 Then Return
            If dgvEquipoSeguridad.CurrentRow Is Nothing Then Return
            dgvEquipoSeguridad.Rows.RemoveAt(dgvEquipoSeguridad.CurrentRow.Index)
            dgvEquipoSeguridad.Refresh()
            If dgvEquipoSeguridad.RowCount = 0 Then
                lblEquipoSeguridadCount.Text = "Verifique las series antes de guardar!!"
            Else
                lblEquipoSeguridadCount.Text = "Verifique las series antes de guardar!!        " & dgvEquipoSeguridad.RowCount & " EQUIPOS EN TOTAL!"
            End If
        End Sub

        Private Sub btnAddCamara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If ValidacionParametrosCamarasSeguridad() Then

                dgvCamara.Rows.Add(cbmMarcaCamarasSeguridad.Text.Trim, txtModeloCamarasSeguridad.Text.Trim, cbmEstadoCamarasSeguridad.Text.Trim, txtSerieCamarasSeguridad.Text.Trim,
                                   cbmColorCamarasSeguridad.Text.Trim, cbmMaterialCamarasSeguridad.Text.Trim, cbmAñosCamarasSeguridad.Text.Trim,
                                   txtAdicionalCamarasSeguridad.Text, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), If(chkGarantiaCamara.Checked, 1, 0), txtGarantiaCamara.Text, txtValorFactura.Text.Trim, txtValorResidual.Text.Trim, txtAñosVidaUtil.Text.Trim, dtpCaducidadCamara.Value.ToShortDateString)

                ' LIMPIAR
                cbmMarcaCamarasSeguridad.SelectedIndex = 0
                txtModeloCamarasSeguridad.Clear()
                cbmEstadoCamarasSeguridad.SelectedIndex = 0
                txtSerieCamarasSeguridad.Clear()
                cbmColorCamarasSeguridad.SelectedIndex = 0
                cbmMaterialCamarasSeguridad.SelectedIndex = 0
                cbmAñosCamarasSeguridad.SelectedIndex = 0
                txtAdicionalCamarasSeguridad.Clear()
                chkGarantiaCamara.Checked = False
                txtGarantiaCamara.Clear()
                dgvCamara.Refresh()

                lblCamaraCount.Text = "Verifique las series antes de guardar!!        " & dgvCamara.RowCount & " EQUIPOS EN TOTAL!"
            Else

                KryptonMessageBox.Show("Debe llenar todos los datos generales del equipo!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub btnDelCamara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If dgvCamara.RowCount = 0 Then Return
            If dgvCamara.CurrentRow Is Nothing Then Return
            dgvCamara.Rows.RemoveAt(dgvCamara.CurrentRow.Index)
            dgvCamara.Refresh()
            If dgvCamara.RowCount = 0 Then
                lblCamaraCount.Text = "Verifique las series antes de guardar!!"
            Else
                lblCamaraCount.Text = "Verifique las series antes de guardar!!        " & dgvCamara.RowCount & " CAMARAS EN TOTAL!"
            End If
        End Sub

        Private Sub btnAddChaleco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddChaleco.Click
            If ValidacionParametrosChalecos() Then

                dgvChaleco.Rows.Add(cbmMarcaChaleco.Text.Trim, txtModeloChaleco.Text.Trim, cbmEstadoChaleco.Text.Trim, txtSerieChaleco.Text.Trim,
                                   cbmColorChaleco.Text.Trim, cbmMaterialChaleco.Text.Trim, cbmAñosChaleco.Text.Trim,
                                   txtAdicionalChaleco.Text, GenerarCodigoActivo(_formDialogoNuevoActivo.Tipo), If(chkGarantiaChaleco.Checked, 1, 0), txtGarantiaChaleco.Text.Trim, txtValorFactura.Text.Trim, txtValorResidual.Text.Trim, txtAñosVidaUtil.Text.Trim, dtpCaducidadChaleco.Value.ToShortDateString)

                ' LIMPIAR
                cbmMarcaChaleco.SelectedIndex = 0
                txtModeloChaleco.Clear()
                cbmEstadoChaleco.SelectedIndex = 0
                txtSerieChaleco.Clear()
                cbmColorChaleco.SelectedIndex = 0
                cbmMaterialChaleco.SelectedIndex = 0
                cbmAñosChaleco.SelectedIndex = 0
                txtGarantiaChaleco.Clear()
                chkGarantiaChaleco.Checked = False
                dgvChaleco.Refresh()

                lblChalecoCount.Text = "Verifique las series antes de guardar!!        " & dgvChaleco.RowCount & " CHALECOS EN TOTAL!"
            Else

                KryptonMessageBox.Show("Debe llenar todos los datos generales del equipo!!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub btnDelChaleco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelChaleco.Click
            If dgvChaleco.RowCount = 0 Then Return
            If dgvChaleco.CurrentRow Is Nothing Then Return
            dgvChaleco.Rows.RemoveAt(dgvChaleco.CurrentRow.Index)
            txtAdicionalChaleco.Text = "Decision 584 Art. 11 Literal C. Decreto Ejecutivo 2393 Art. 11 Numeral 3, Art. 176"
            dgvChaleco.Refresh()
            If dgvChaleco.RowCount = 0 Then
                lblChalecoCount.Text = "Verifique las series antes de guardar!!"
            Else
                lblChalecoCount.Text = "Verifique las series antes de guardar!!        " & dgvChaleco.RowCount & " CHALECOS EN TOTAL!"
            End If
        End Sub

        Private Sub txtSerieArmas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieArmas.TextChanged

        End Sub

        Private Sub txtCuentaDepreciacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaDepreciacion.TextChanged
            If (Not String.IsNullOrEmpty(txtCuentaDepreciacion.Text)) Then





            End If
        End Sub

        Private Sub gpInfActfijo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub Label159_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub btnGarantiaRadio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGarantiaRadio.Click
            Try
                pdfFilePath = String.Empty
                Using openFileDialog As New OpenFileDialog()
                    openFileDialog.InitialDirectory = "C:\"
                    openFileDialog.Title = "SELECCIONAR DOCUMENTO"
                    openFileDialog.CheckFileExists = True
                    openFileDialog.CheckPathExists = True
                    openFileDialog.DefaultExt = "pdf"
                    openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
                    openFileDialog.FilterIndex = 2
                    openFileDialog.RestoreDirectory = True
                    openFileDialog.ReadOnlyChecked = True
                    openFileDialog.ShowReadOnly = True
                    If openFileDialog.ShowDialog() = DialogResult.OK Then
                        txtGarantia.Text = openFileDialog.FileName
                        pdfFilePath = openFileDialog.FileName ' Store the path in the variable

                    End If
                End Using
            Catch ex As Exception
                'MessageBox.Show("Error opening PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                KryptonMessageBox.Show("Error abriendo PDF: " & ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try

        End Sub

        Private Sub btnGarantiaComputo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGarantiaComputo.Click
            Try
                pdfFilePath = String.Empty
                Using openFileDialog As New OpenFileDialog()
                    openFileDialog.InitialDirectory = "C:\"
                    openFileDialog.Title = "SELECCIONAR DOCUMENTO"
                    openFileDialog.CheckFileExists = True
                    openFileDialog.CheckPathExists = True
                    openFileDialog.DefaultExt = "pdf"
                    openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
                    openFileDialog.FilterIndex = 2
                    openFileDialog.RestoreDirectory = True
                    openFileDialog.ReadOnlyChecked = True
                    openFileDialog.ShowReadOnly = True
                    If openFileDialog.ShowDialog() = DialogResult.OK Then
                        txtGarantiaComputo.Text = openFileDialog.FileName
                        pdfFilePath = openFileDialog.FileName ' Store the path in the variable

                    End If
                End Using
            Catch ex As Exception
                'MessageBox.Show("Error opening PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                KryptonMessageBox.Show("Error abriendo PDF: " & ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnGarantiaOficina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGarantiaOficina.Click
            Try
                pdfFilePath = String.Empty
                Using openFileDialog As New OpenFileDialog()
                    openFileDialog.InitialDirectory = "C:\"
                    openFileDialog.Title = "SELECCIONAR DOCUMENTO"
                    openFileDialog.CheckFileExists = True
                    openFileDialog.CheckPathExists = True
                    openFileDialog.DefaultExt = "pdf"
                    openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
                    openFileDialog.FilterIndex = 2
                    openFileDialog.RestoreDirectory = True
                    openFileDialog.ReadOnlyChecked = True
                    openFileDialog.ShowReadOnly = True
                    If openFileDialog.ShowDialog() = DialogResult.OK Then
                        txtGarantiaOficina.Text = openFileDialog.FileName
                        pdfFilePath = openFileDialog.FileName ' Store the path in the variable

                    End If
                End Using
            Catch ex As Exception

                KryptonMessageBox.Show("Error abriendo PDF: " & ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnGarantiaComunicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                pdfFilePath = String.Empty
                Using openFileDialog As New OpenFileDialog()
                    openFileDialog.InitialDirectory = "C:\"
                    openFileDialog.Title = "SELECCIONAR DOCUMENTO"
                    openFileDialog.CheckFileExists = True
                    openFileDialog.CheckPathExists = True
                    openFileDialog.DefaultExt = "pdf"
                    openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
                    openFileDialog.FilterIndex = 2
                    openFileDialog.RestoreDirectory = True
                    openFileDialog.ReadOnlyChecked = True
                    openFileDialog.ShowReadOnly = True
                    If openFileDialog.ShowDialog() = DialogResult.OK Then
                        txtGarantiaComunicacion.Text = openFileDialog.FileName
                        pdfFilePath = openFileDialog.FileName ' Store the path in the variable

                    End If
                End Using
            Catch ex As Exception

                KryptonMessageBox.Show("Error abriendo PDF: " & ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnGarantiaCamara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                pdfFilePath = String.Empty
                Using openFileDialog As New OpenFileDialog()
                    openFileDialog.InitialDirectory = "C:\"
                    openFileDialog.Title = "SELECCIONAR DOCUMENTO"
                    openFileDialog.CheckFileExists = True
                    openFileDialog.CheckPathExists = True
                    openFileDialog.DefaultExt = "pdf"
                    openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
                    openFileDialog.FilterIndex = 2
                    openFileDialog.RestoreDirectory = True
                    openFileDialog.ReadOnlyChecked = True
                    openFileDialog.ShowReadOnly = True
                    If openFileDialog.ShowDialog() = DialogResult.OK Then
                        txtGarantiaCamara.Text = openFileDialog.FileName
                        pdfFilePath = openFileDialog.FileName ' Store the path in the variable

                    End If
                End Using
            Catch ex As Exception

                KryptonMessageBox.Show("Error abriendo PDF: " & ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnGarantiaChaleco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                pdfFilePath = String.Empty
                Using openFileDialog As New OpenFileDialog()
                    openFileDialog.InitialDirectory = "C:\"
                    openFileDialog.Title = "SELECCIONAR DOCUMENTO"
                    openFileDialog.CheckFileExists = True
                    openFileDialog.CheckPathExists = True
                    openFileDialog.DefaultExt = "pdf"
                    openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
                    openFileDialog.FilterIndex = 2
                    openFileDialog.RestoreDirectory = True
                    openFileDialog.ReadOnlyChecked = True
                    openFileDialog.ShowReadOnly = True
                    If openFileDialog.ShowDialog() = DialogResult.OK Then
                        txtGarantiaChaleco.Text = openFileDialog.FileName
                        pdfFilePath = openFileDialog.FileName ' Store the path in the variable

                    End If
                End Using
            Catch ex As Exception
                'MessageBox.Show("Error opening PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                KryptonMessageBox.Show("Error abriendo PDF: " & ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub txtAdicionalChaleco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub cbxVidaUtil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxVidaUtil.CheckedChanged

        End Sub

        Private Sub Label38_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub cbmAnoFabricacionVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmAnoFabricacionVehiculo.SelectedIndexChanged

        End Sub

        Private Sub Label35_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub Label77_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub Label76_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub KryptonGroupBox2_Paint(sender As Object, e As PaintEventArgs) Handles KryptonGroupBox2.Paint

        End Sub

        Private Sub txtSerieEquiposComunicacion_TextChanged(sender As Object, e As EventArgs) Handles txtSerieEquiposComunicacion.TextChanged

        End Sub

        Private Sub KryptonLabel112_Click(sender As Object, e As EventArgs) Handles KryptonLabel112.Click

        End Sub

        Private Sub txtAmperajeGeneradores_TextChanged(sender As Object, e As EventArgs) Handles txtAmperajeGeneradores.TextChanged

        End Sub

        Private Sub KryptonLabel135_Click(sender As Object, e As EventArgs) Handles KryptonLabel135.Click

        End Sub


        'NO BORRAR ESTE METODO
        'Private Sub tcVarios_DrawItem(sender As Object, e As DrawItemEventArgs) Handles tcVarios.DrawItem


        '    Dim tabRect As Rectangle = tcVarios.GetTabRect(e.Index)
        '    Dim isSelected As Boolean = (e.Index = tcVarios.SelectedIndex)

        '    Define Text color based on selection
        '    Dim textColor As Color = If(isSelected, GetTabColor(_tipoCon), Color.DarkGray) ' Selected text color

        '    Adjust the tab rectangle to remove any borders
        '    tabRect.Inflate(0, 0) ' Ensures the tab rectangle takes the full width available

        '    Draw the text of the tab without any background
        '    TextRenderer.DrawText(e.Graphics, tcVarios.TabPages(e.Index).Text, tcVarios.Font, tabRect, textColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)

        '    Draw the bottom border line for the selected tab
        '    If isSelected Then
        '        Using borderBrush As New SolidBrush(GetTabColor(_tipoCon)) ' Line color for the selected tab
        '            Dim borderRect As New Rectangle(tabRect.X, tabRect.Bottom, tabRect.Width, 3) ' Height of the border line
        '            e.Graphics.FillRectangle(borderBrush, borderRect)
        '        End Using
        '    End If

        '    Dim TabControl1 As TabControl = CType(sender, TabControl)
        '    Dim tabPage1 As System.Windows.Forms.TabPage = TabControl1.TabPages(e.Index)

        '    Dim tabRect As Rectangle = TabControl1.GetTabRect(e.Index)
        '    tabRect.Inflate(-2, -2)
        '    Dim isSelected As Boolean = (e.Index = TabControl1.SelectedIndex)

        '    Dim lineColor As Color = GetTabColor(_tipoCon)

        '    Dim backColor As Color = If(isSelected, GetTabColor(_tipoCon), Color.White)


        '    Using backbrush As New SolidBrush(If(isSelected, tabPage1.BackColor, Color.White))
        '        e.Graphics.FillRectangle(backbrush, tabRect)
        '    End Using



        '    If isSelected Then
        '        Dim topLineRect As New Rectangle(tabRect.X, tabRect.Y, tabRect.Width, 1)
        '        Using topBrush As New SolidBrush(backColor)
        '            e.Graphics.FillRectangle(topBrush, topLineRect)
        '        End Using

        '    End If

        '    If isSelected Then
        '        Dim tabpageLineRect As New Rectangle(0, 0, tabPage1.Width, 1)
        '        Using lineBrush As New SolidBrush(lineColor)
        '            tabPage1.CreateGraphics().FillRectangle(lineBrush, tabpageLineRect)
        '        End Using
        '    End If

        '    Dim Textcolor As Color = If(isSelected, backColor, Color.DarkGray)
        '    TextRenderer.DrawText(e.Graphics, tabPage1.Text, TabControl1.Font, tabRect, textColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)

        'End Sub


        'Private Function GetTabColor(ByVal tipoCon As TipoConexion) As Color
        '    Select Case tipoCon
        '        Case TipoConexion.Seportpac
        '            Return My.MySettingsProperty.Settings.ColorSeportpac
        '        Case TipoConexion.Asenava
        '            Return My.MySettingsProperty.Settings.ColorAsenava
        '        Case Else ' Default connection (CISEPRO)
        '            Return My.MySettingsProperty.Settings.ColorCisepro
        '    End Select
        'End Function
    End Class
End Namespace