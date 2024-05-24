
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteVentas
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

        Public EsChart As Boolean
        Public DataGrid As DataGridView

        Public subt As String
        Public iva As String
        Public tot As String
        Public reten As String
        Public notac As String
        Public pagar As String

        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        ReadOnly _crystalReportVentasChart As New CrystalReportVentas
        ReadOnly _crystalReportVentasReport As New CrystalReportVentasPdf

        Private Sub ConectarReporteVentasChart()
            _crystalReportVentasChart.SetDataSource(_objetoFacturaVenta.SeleccionarRegistrosReporteVentas(_tipoCon, lblFechaInicial.Text, lblFechaFinal.Text, 1))
            _crystalReportVentasChart.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
            _crystalReportVentasChart.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            _crystalReportVentasChart.SetParameterValue("paramFechaInicial", CType(lblFechaInicial.Text, DateTime))
            _crystalReportVentasChart.SetParameterValue("paramFechaFinal", CType(lblFechaFinal.Text, DateTime))
            crvReporteVentas.ReportSource = _crystalReportVentasChart
            crvReporteVentas.Zoom(2)
            crvReporteVentas.Refresh()
        End Sub

        Private Sub ConectarReporteVentasReport()
            Try
                If DataGrid.RowCount = 0 Then Return
                Dim ds = New DataSetVentasPdf

                For Each row As DataGridViewRow In DataGrid.Rows
                    If row.Cells(12).Value.ToString.Equals("0") Then Continue For
                    ds.Tables("FacturasVenta").Rows.Add(row.Cells(1).Value, CDate(row.Cells(2).Value).ToString("dd/MM/yyyy"),
                                                        row.Cells(3).Value, row.Cells(4).Value,
                                                        row.Cells(8).Value, row.Cells(10).Value, row.Cells(11).Value,
                                                        (CDec(row.Cells(13).Value) + CDec(row.Cells(14).Value)),
                                                        (CDec(row.Cells(15).Value) + CDec(row.Cells(16).Value)),
                                                        row.Cells(17).Value, row.Cells(18).Value, row.Cells(19).Value, row.Cells(20).Value)
                Next

                _crystalReportVentasReport.SetDataSource(ds.Tables("FacturasVenta"))
                _crystalReportVentasReport.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
                _crystalReportVentasReport.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                _crystalReportVentasReport.SetParameterValue("paramFechaInicial", CType(lblFechaInicial.Text, DateTime))
                _crystalReportVentasReport.SetParameterValue("paramFechaFinal", CType(lblFechaFinal.Text, DateTime))

                _crystalReportVentasReport.SetParameterValue("subt", subt)
                _crystalReportVentasReport.SetParameterValue("iva", iva)
                _crystalReportVentasReport.SetParameterValue("tot", tot)
                _crystalReportVentasReport.SetParameterValue("reten", reten)
                _crystalReportVentasReport.SetParameterValue("notac", notac)
                _crystalReportVentasReport.SetParameterValue("pagar", pagar)

                crvReporteVentas.ReportSource = _crystalReportVentasReport
                crvReporteVentas.Zoom(2)
                crvReporteVentas.Refresh()
            Catch
                crvReporteVentas.ReportSource = Nothing
            End Try 
        End Sub

        Private Sub FormReporteVentas_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing 
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                Case Else
                    Icon = My.Resources.logo_c 
            End Select

            If EsChart Then
                ConectarReporteVentasChart()
            Else
                ConectarReporteVentasReport()
            End If
        End Sub

        Private Sub crvReporteVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crvReporteVentas.Load

        End Sub
    End Class
End Namespace