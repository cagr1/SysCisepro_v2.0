Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.BALANCE
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FrmReporteBalanceFinal
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

        ReadOnly _crObjetoBalanceFinal As New crBalanceFinal
        Public Datos As DataTable

        Public FInicio As String
        Public FFin As String
        Public Footer As String

        Public Sub New(ByVal tbname As String)
            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            Datos = New DataTable(tbname)
            Datos.Columns.Add("DETALLE")
            Datos.Columns.Add("TOTAL")
            Datos.Columns.Add("B")

        End Sub

        Private Sub FrmReporteBalanceFinal_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a 
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                    Icon = My.Resources.logo_c 
            End Select

            Try
                _crObjetoBalanceFinal.SetDataSource(Datos)
                crvPlanDeCuentas.ReportSource = _crObjetoBalanceFinal
                _crObjetoBalanceFinal.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                _crObjetoBalanceFinal.SetParameterValue("empresa", "CISEPRO CIA. LTDA")
                _crObjetoBalanceFinal.SetParameterValue("detalle", "BALANCE FINAL")
                _crObjetoBalanceFinal.SetParameterValue("inicio", FInicio)
                _crObjetoBalanceFinal.SetParameterValue("fin", FFin)
                _crObjetoBalanceFinal.SetParameterValue("foot", Footer)

                crvPlanDeCuentas.Refresh()
                crvPlanDeCuentas.Zoom(75)
            Catch ex As Exception
            End Try
        End Sub

    End Class
End Namespace