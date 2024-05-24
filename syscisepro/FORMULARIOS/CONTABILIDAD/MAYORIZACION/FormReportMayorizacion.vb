Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Public Class FormReportMayorizacion
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
    Public DataGrid As DataGridView

    Public cuenta As String

    Public deudor As String
    Public acreedor As String
    Public saldo As String

    Public desde As String
    Public hasta As String

    ReadOnly _crystalReportMayorizacion As New CrystalReportMayorizacion

    Private Sub FormReportMayorizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If DataGrid.RowCount = 0 Then Return
            Dim ds = New DataSetVentasPdf

            For Each row As DataGridViewRow In DataGrid.Rows
                ds.Tables("Mayorizacion").Rows.Add(CDate(row.Cells(0).Value).ToString("dd/MM/yyyy"),
                                                    row.Cells(8).Value, row.Cells(3).Value,
                                                    row.Cells(4).Value, row.Cells(6).Value, row.Cells(1).Value, row.Cells(2).Value)
            Next

            Dim dtit = ""
            If cuenta.Trim().Substring(0, 1).Equals("1") Then dtit = "ACTIVOS"
            If cuenta.Trim().Substring(0, 1).Equals("2") Then dtit = "PASIVOS"
            If cuenta.Trim().Substring(0, 1).Equals("3") Then dtit = "PATRIMONIO"
            If cuenta.Trim().Substring(0, 1).Equals("4") Then dtit = "INGRESOS"
            If cuenta.Trim().Substring(0, 1).Equals("5") Then dtit = "EGRESOS"
            If cuenta.Trim().Substring(0, 1).Equals("6") Then dtit = "GASTOS"
             
            _crystalReportMayorizacion.SetDataSource(ds.Tables("Mayorizacion"))
            _crystalReportMayorizacion.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
            _crystalReportMayorizacion.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            _crystalReportMayorizacion.SetParameterValue("paramFechaInicial", desde)
            _crystalReportMayorizacion.SetParameterValue("paramFechaFinal", hasta)
            _crystalReportMayorizacion.SetParameterValue("cuenta", cuenta)
            _crystalReportMayorizacion.SetParameterValue("titulo", dtit)

            _crystalReportMayorizacion.SetParameterValue("deudor", deudor)
            _crystalReportMayorizacion.SetParameterValue("acreedor", acreedor)
            _crystalReportMayorizacion.SetParameterValue("saldo", saldo)

            crvReporteVentas.ReportSource = _crystalReportMayorizacion
            crvReporteVentas.Zoom(2)
            crvReporteVentas.Refresh()
        Catch
            crvReporteVentas.ReportSource = Nothing
        End Try
    End Sub

    Private Sub crvReporteVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crvReporteVentas.Load

    End Sub
End Class