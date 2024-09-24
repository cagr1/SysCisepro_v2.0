Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Public Class FormReportCuentasPagar
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

    Public IsMin As Boolean
    Public IsGeneral As Boolean

    Public proveedor As String

    Public desde As String
    Public hasta As String
    Public saldo As String

    ReadOnly _crystalReportCuentasPagarMinGen As New CrystalReportCuentasPagarMinGen
    ReadOnly _crystalReportCuentasPagarMinProv As New CrystalReportCuentasPagarMinProv

    ReadOnly _crystalReportCuentasPagarGen As New CrystalReportCuentasPagarGen
    ReadOnly _crystalReportCuentasPagarProv As New CrystalReportCuentasPagarProv

    Private Sub FormReportCuentasPagar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If DataGrid.RowCount = 0 Then Return
            Dim ds = New DataSetVentasPdf
            If IsMin Then
                If IsGeneral Then
                    For Each row As DataGridViewRow In DataGrid.Rows
                        ds.Tables("CuentasPagarMinGen").Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value)
                    Next
                    _crystalReportCuentasPagarMinGen.SetDataSource(ds.Tables("CuentasPagarMinGen"))
                    _crystalReportCuentasPagarMinGen.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
                    _crystalReportCuentasPagarMinGen.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                    _crystalReportCuentasPagarMinGen.SetParameterValue("paramFechaInicial", desde)
                    _crystalReportCuentasPagarMinGen.SetParameterValue("paramFechaFinal", hasta)
                    _crystalReportCuentasPagarMinGen.SetParameterValue("proveedor", "-- TODOS --")
                    _crystalReportCuentasPagarMinGen.SetParameterValue("saldo", saldo)
                    _crystalReportCuentasPagarMinGen.SetParameterValue("gerente", If(_tipoCon = TipoConexion.Cisepro, "Ing. Marjorie Loor P.", "Ing. José Navarrete M."))
                    crvReporteVentas.ReportSource = _crystalReportCuentasPagarMinGen
                Else
                    For Each row As DataGridViewRow In DataGrid.Rows
                        ds.Tables("CuentasPagarMinProv").Rows.Add(row.Cells(1).Value, row.Cells(2).Value, CDate(row.Cells(3).Value).ToString("dd/MM/yyyy"), row.Cells(13).Value, row.Cells(15).Value)
                    Next
                    _crystalReportCuentasPagarMinProv.SetDataSource(ds.Tables("CuentasPagarMinProv"))
                    _crystalReportCuentasPagarMinProv.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
                    _crystalReportCuentasPagarMinProv.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                    _crystalReportCuentasPagarMinProv.SetParameterValue("paramFechaInicial", desde)
                    _crystalReportCuentasPagarMinProv.SetParameterValue("paramFechaFinal", hasta)
                    _crystalReportCuentasPagarMinProv.SetParameterValue("proveedor", proveedor)
                    _crystalReportCuentasPagarMinProv.SetParameterValue("saldo", saldo)
                    _crystalReportCuentasPagarMinProv.SetParameterValue("gerente", If(_tipoCon = TipoConexion.Cisepro, "Ing. Marjorie Loor P.", "Ing. José Navarrete M."))
                    crvReporteVentas.ReportSource = _crystalReportCuentasPagarMinProv
                End If 
            Else 
                If IsGeneral Then
                    For Each row As DataGridViewRow In DataGrid.Rows
                        ds.Tables("CuentasPagarGen").Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value)
                    Next
                    _crystalReportCuentasPagarGen.SetDataSource(ds.Tables("CuentasPagarGen"))
                    _crystalReportCuentasPagarGen.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
                    _crystalReportCuentasPagarGen.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                    _crystalReportCuentasPagarGen.SetParameterValue("paramFechaInicial", desde)
                    _crystalReportCuentasPagarGen.SetParameterValue("paramFechaFinal", hasta)
                    _crystalReportCuentasPagarGen.SetParameterValue("proveedor", "-- TODOS --")
                    _crystalReportCuentasPagarGen.SetParameterValue("saldo", saldo)
                    _crystalReportCuentasPagarGen.SetParameterValue("gerente", If(_tipoCon = TipoConexion.Cisepro, "Ing. Marjorie Loor P.", "Ing. José Navarrete M."))
                    crvReporteVentas.ReportSource = _crystalReportCuentasPagarGen
                Else
                    For Each row As DataGridViewRow In DataGrid.Rows
                        ds.Tables("CuentasPagarProv").Rows.Add(row.Cells(1).Value, row.Cells(2).Value, CDate(row.Cells(3).Value).ToString("dd/MM/yyyy"), row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, row.Cells(10).Value, row.Cells(11).Value, row.Cells(12).Value, row.Cells(13).Value)
                    Next
                    _crystalReportCuentasPagarProv.SetDataSource(ds.Tables("CuentasPagarProv"))
                    _crystalReportCuentasPagarProv.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
                    _crystalReportCuentasPagarProv.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                    _crystalReportCuentasPagarProv.SetParameterValue("paramFechaInicial", desde)
                    _crystalReportCuentasPagarProv.SetParameterValue("paramFechaFinal", hasta)
                    _crystalReportCuentasPagarProv.SetParameterValue("proveedor", proveedor)
                    _crystalReportCuentasPagarProv.SetParameterValue("saldo", saldo)
                    _crystalReportCuentasPagarProv.SetParameterValue("gerente", If(_tipoCon = TipoConexion.Cisepro, "Ing. Marjorie Loor P.", "Ing. José Navarrete M."))
                    crvReporteVentas.ReportSource = _crystalReportCuentasPagarProv
                End If 
            End If
             
            crvReporteVentas.Zoom(2)
            crvReporteVentas.Refresh()
        Catch
            crvReporteVentas.ReportSource = Nothing
        End Try
    End Sub
End Class