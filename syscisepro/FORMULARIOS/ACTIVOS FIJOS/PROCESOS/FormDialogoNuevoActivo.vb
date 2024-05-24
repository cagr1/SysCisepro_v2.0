Imports ClassLibraryCisepro.ENUMS

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormDialogoNuevoActivo

        Public Tipo As Integer
        Public Titulo As String

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

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnAceptar.Click
            DialogResult = DialogResult.OK
        End Sub
        Private Sub rbArmas_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles rbArmas.CheckedChanged, rbVehiculo.CheckedChanged, rbTerrenos.CheckedChanged, rbSoftware.CheckedChanged, rbRadios.CheckedChanged, rbMueblesOficina.CheckedChanged, rbLibrosYcolecciones.CheckedChanged, rbGeneradores.CheckedChanged, rbEquiposSeguridadIndustrial.CheckedChanged, rbEquiposOficina.CheckedChanged, rbEquiposComunicacion.CheckedChanged, rbEquiposComputo.CheckedChanged, rbEquiposCocina.CheckedChanged, rbEquiposAmbientacion.CheckedChanged, rbChaleco.CheckedChanged, rbCamarasSeguridad.CheckedChanged
            Dim rbt = CType(sender, RadioButton)
            If Not rbt.Checked Then Return
            Tipo = CInt(rbt.Tag)
            Titulo = rbt.Text.Trim()
        End Sub


        Public Function GetSelectedTitulo() As String
            Select Case Tipo
                
                Case 1
                    Return "RADIOS"
                Case 2
                    Return "VEHÍCULOS"
                Case 3
                    Return "TERRENOS"
                Case 4
                    Return "EQUIPOS DE COMPUTO"
                Case 5
                    Return "LIBROS Y COLECCIONES"
                Case 6
                    Return "EQUIPOS DE OFICINA"
                Case 7
                    Return "MUEBLES DE OFICINA"
                Case 8
                    Return "EQUIPOS DE COCINA"
                Case 9
                    Return "EQUIPOS DE AMBIENTACIÓN"
                Case 10
                    Return "EQUIPOS DE COMUNICACIÓN Y TELEFONÍA"
                Case 11
                    Return "EQUIPOS DE SEGURIDAD INDUSTRIAL"
                Case 12
                    Return "CAMARAS DE SEGURIDAD"
                Case 13
                    Return "GENERADORES"
                Case 14
                    Return "CHALECOS"
                Case 15
                    Return "SOFTWARE"
                Case Else
                    Return "ARMAS"
            End Select
        End Function

        Private Sub FormDialogoNuevoActivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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