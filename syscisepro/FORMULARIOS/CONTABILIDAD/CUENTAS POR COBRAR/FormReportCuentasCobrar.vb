Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Public Class FormReportCuentasCobrar
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
    Public IsConsorcio As Boolean
    Public IsConsorcioDetalle As Boolean

    Public cliente As String

    Public desde As String
    Public hasta As String
    Public saldo As String

    ReadOnly _crystalReportCuentasCobrarMinGen As New CrystalReportCuentasCobrarMinGen
    ReadOnly _crystalReportCuentasCobrarMinCli As New CrystalReportCuentasCobrarMinCli

    ReadOnly _crystalReportCuentasCobrarGen As New CrystalReportCuentasCobrarGen
    ReadOnly _crystalReportCuentasCobrarCli As New CrystalReportCuentasCobrarCli
    ReadOnly _crystalReportCuentasCobrarCons As New CrystalReportCuentasCobrarCons

    Private Sub FormReportCuentasCobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If DataGrid.RowCount = 0 Then Return
            Dim ds = New DataSetVentasPdf
            If IsMin Then
                If IsGeneral Then
                    For Each row As DataGridViewRow In DataGrid.Rows
                        ds.Tables("CuentasCobrarMinGen").Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(8).Value)
                    Next
                    _crystalReportCuentasCobrarMinGen.SetDataSource(ds.Tables("CuentasCobrarMinGen"))
                    _crystalReportCuentasCobrarMinGen.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
                    _crystalReportCuentasCobrarMinGen.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                    _crystalReportCuentasCobrarMinGen.SetParameterValue("paramFechaInicial", desde)
                    _crystalReportCuentasCobrarMinGen.SetParameterValue("paramFechaFinal", hasta)
                    _crystalReportCuentasCobrarMinGen.SetParameterValue("proveedor", "-- TODOS --")
                    _crystalReportCuentasCobrarMinGen.SetParameterValue("saldo", saldo)
                    _crystalReportCuentasCobrarMinGen.SetParameterValue("gerente", If(_tipoCon = TipoConexion.Cisepro, "Ing. Marjorie Loor P.", "Ing. José Navarrete M."))
                    crvReporteVentas.ReportSource = _crystalReportCuentasCobrarMinGen
                Else
                    For Each row As DataGridViewRow In DataGrid.Rows
                        ds.Tables("CuentasCobrarMinCli").Rows.Add(row.Cells(1).Value, CDate(row.Cells(2).Value).ToString("dd/MM/yyyy"), row.Cells(9).Value, row.Cells(8).Value)
                    Next
                    _crystalReportCuentasCobrarMinCli.SetDataSource(ds.Tables("CuentasCobrarMinCli"))
                    _crystalReportCuentasCobrarMinCli.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
                    _crystalReportCuentasCobrarMinCli.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                    _crystalReportCuentasCobrarMinCli.SetParameterValue("paramFechaInicial", desde)
                    _crystalReportCuentasCobrarMinCli.SetParameterValue("paramFechaFinal", hasta)
                    _crystalReportCuentasCobrarMinCli.SetParameterValue("proveedor", cliente)
                    _crystalReportCuentasCobrarMinCli.SetParameterValue("saldo", saldo)
                    _crystalReportCuentasCobrarMinCli.SetParameterValue("gerente", If(_tipoCon = TipoConexion.Cisepro, "Ing. Marjorie Loor P.", "Ing. José Navarrete M."))
                    crvReporteVentas.ReportSource = _crystalReportCuentasCobrarMinCli
                End If
            Else
                If IsGeneral Then
                    For Each row As DataGridViewRow In DataGrid.Rows
                        ds.Tables("CuentasCobrarGen").Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value)
                    Next
                    _crystalReportCuentasCobrarGen.SetDataSource(ds.Tables("CuentasCobrarGen"))
                    _crystalReportCuentasCobrarGen.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
                    _crystalReportCuentasCobrarGen.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                    _crystalReportCuentasCobrarGen.SetParameterValue("paramFechaInicial", desde)
                    _crystalReportCuentasCobrarGen.SetParameterValue("paramFechaFinal", hasta)
                    _crystalReportCuentasCobrarGen.SetParameterValue("proveedor", "-- TODOS --")
                    _crystalReportCuentasCobrarGen.SetParameterValue("saldo", saldo)
                    _crystalReportCuentasCobrarGen.SetParameterValue("gerente", If(_tipoCon = TipoConexion.Cisepro, "Ing. Marjorie Loor P.", "Ing. José Navarrete M."))
                    crvReporteVentas.ReportSource = _crystalReportCuentasCobrarGen
                Else
                    If IsConsorcio Then
                        For Each row As DataGridViewRow In DataGrid.Rows
                            ds.Tables("CuentasCobrarGen").Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value)
                        Next
                        _crystalReportCuentasCobrarGen.SetDataSource(ds.Tables("CuentasCobrarGen"))
                        _crystalReportCuentasCobrarGen.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
                        _crystalReportCuentasCobrarGen.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                        _crystalReportCuentasCobrarGen.SetParameterValue("paramFechaInicial", desde)
                        _crystalReportCuentasCobrarGen.SetParameterValue("paramFechaFinal", hasta)
                        _crystalReportCuentasCobrarGen.SetParameterValue("proveedor", cliente)
                        _crystalReportCuentasCobrarGen.SetParameterValue("saldo", saldo)
                        crvReporteVentas.ReportSource = _crystalReportCuentasCobrarGen
                    Else
                        If IsConsorcioDetalle Then
                            For Each row As DataGridViewRow In DataGrid.Rows
                                ds.Tables("CuentasCobrarCliCons").Rows.Add(row.Cells(1).Value, row.Cells(2).Value, CDate(row.Cells(3).Value).ToString("dd/MM/yyyy"), row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, row.Cells(10).Value)
                            Next
                            _crystalReportCuentasCobrarCons.SetDataSource(ds.Tables("CuentasCobrarCliCons"))
                            _crystalReportCuentasCobrarCons.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
                            _crystalReportCuentasCobrarCons.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                            _crystalReportCuentasCobrarCons.SetParameterValue("paramFechaInicial", desde)
                            _crystalReportCuentasCobrarCons.SetParameterValue("paramFechaFinal", hasta)
                            _crystalReportCuentasCobrarCons.SetParameterValue("proveedor", cliente)
                            _crystalReportCuentasCobrarCons.SetParameterValue("saldo", saldo)
                            _crystalReportCuentasCobrarCons.SetParameterValue("gerente", If(_tipoCon = TipoConexion.Cisepro, "Ing. Marjorie Loor P.", "Ing. José Navarrete M."))
                            crvReporteVentas.ReportSource = _crystalReportCuentasCobrarCons
                        Else
                            For Each row As DataGridViewRow In DataGrid.Rows
                                ds.Tables("CuentasCobrarCli").Rows.Add(row.Cells(1).Value, CDate(row.Cells(2).Value).ToString("dd/MM/yyyy"), row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value)
                            Next
                            _crystalReportCuentasCobrarCli.SetDataSource(ds.Tables("CuentasCobrarCli"))
                            _crystalReportCuentasCobrarCli.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
                            _crystalReportCuentasCobrarCli.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                            _crystalReportCuentasCobrarCli.SetParameterValue("paramFechaInicial", desde)
                            _crystalReportCuentasCobrarCli.SetParameterValue("paramFechaFinal", hasta)
                            _crystalReportCuentasCobrarCli.SetParameterValue("proveedor", cliente)
                            _crystalReportCuentasCobrarCli.SetParameterValue("saldo", saldo)
                            _crystalReportCuentasCobrarCli.SetParameterValue("gerente", If(_tipoCon = TipoConexion.Cisepro, "Ing. Marjorie Loor P.", "Ing. José Navarrete M."))
                            crvReporteVentas.ReportSource = _crystalReportCuentasCobrarCli 
                        End If 
                    End If
                End If
            End If

            crvReporteVentas.Zoom(2)
            crvReporteVentas.Refresh()
        Catch
            crvReporteVentas.ReportSource = Nothing
        End Try
    End Sub
End Class