 Namespace FORMULARIOS.CONTABILIDAD.PERDIDAS_Y_GANANCIAS

    Public Class FrmReportePerdidasYGanancias

        Dim crObjetoPrediasGanancias As New crPerdidasGanancias
        Dim tbDatos As DataTable

        Dim inicio As String
        Dim fin As String
        Dim foot As String

        Public Sub New(ByVal tbname As String)

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            tbDatos = New DataTable(tbname)
            tbDatos.Columns.Add("DETALLE")
            tbDatos.Columns.Add("TOTAL")
            tbDatos.Columns.Add("B")

        End Sub

        Private Sub FrmReportePerdidasYGanancias_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            Try
                crObjetoPrediasGanancias.SetDataSource(Datos)
                crvPlanDeCuentas.ReportSource = crObjetoPrediasGanancias

                crObjetoPrediasGanancias.SetParameterValue("empresa", "CISEPRO CIA. LTDA")
                crObjetoPrediasGanancias.SetParameterValue("detalle", "BALANCE DE PÉRDIDAS Y GANANCIAS")
                crObjetoPrediasGanancias.SetParameterValue("inicio", inicio)
                crObjetoPrediasGanancias.SetParameterValue("fin", fin)
                crObjetoPrediasGanancias.SetParameterValue("foot", foot)

                crvPlanDeCuentas.Refresh()
                crvPlanDeCuentas.Zoom(75)
            Catch ex As Exception
            End Try
        End Sub

        Public Property Datos As DataTable
            Get
                Return tbDatos
            End Get
            Set(ByVal value As DataTable)
                tbDatos = value
            End Set
        End Property
        Public Property FInicio As String
            Get
                Return inicio
            End Get
            Set(ByVal value As String)
                inicio = value
            End Set
        End Property
        Public Property FFin As String
            Get
                Return fin
            End Get
            Set(ByVal value As String)
                fin = value
            End Set
        End Property
        Public Property Footer As String
            Get
                Return foot
            End Get
            Set(ByVal value As String)
                foot = value
            End Set
        End Property
    End Class
End Namespace