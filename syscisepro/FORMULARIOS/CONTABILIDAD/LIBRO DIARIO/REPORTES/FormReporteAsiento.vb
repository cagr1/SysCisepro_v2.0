Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.LIBRO_DIARIO.REPORTES
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormReporteAsiento
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

        Public EsAsiento As Boolean
        Public IdUsuario As Integer
        Public DataGrid As DataGridView

        Public debe As String
        Public haber As String

        Public desde As String
        Public hasta As String

        ReadOnly _objetoAsientoDiario As New ClassAjustarAsientosLibroDiario
        ReadOnly _crAsientoDiarioCisepro As New crAsientoDiario
        Public NumeroRegistro As Int64 = 0

        ReadOnly _crAsientoDiarioTodos As New CrystalReportLibroDiarioPdf

        Private Sub ConectarReporteComprobanteCompra()
            _crAsientoDiarioCisepro.SetDataSource(_objetoAsientoDiario.BuscarReporteAsientoLibroDiarioXNumeroRegistro(_tipoCon, NumeroRegistro))
            _crAsientoDiarioCisepro.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
            crvAsientoDiario.ReportSource = _crAsientoDiarioCisepro
            crvAsientoDiario.Zoom(2)
        End Sub

        Private Sub ConectarReporteComprobanteTodos()
            Try
                If DataGrid.RowCount = 0 Then Return
                Dim ds = New DataSetVentasPdf

                For Each row As DataGridViewRow In DataGrid.Rows
                    ds.Tables("LibroDiario").Rows.Add(CDate(row.Cells(1).Value).ToString("dd/MM/yyyy"),
                                                        row.Cells(2).Value, row.Cells(3).Value,
                                                        row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value,
                                                        row.Cells(8).Value)
                Next

                _crAsientoDiarioTodos.SetDataSource(ds.Tables("LibroDiario"))
                _crAsientoDiarioTodos.SetParameterValue("cia", ValidationForms.NombreCompany(_tipoCon))
                _crAsientoDiarioTodos.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
                _crAsientoDiarioTodos.SetParameterValue("paramFechaInicial", desde)
                _crAsientoDiarioTodos.SetParameterValue("paramFechaFinal", hasta)

                _crAsientoDiarioTodos.SetParameterValue("debe", debe)
                _crAsientoDiarioTodos.SetParameterValue("haber", haber)

                crvAsientoDiario.ReportSource = _crAsientoDiarioTodos
                crvAsientoDiario.Zoom(2)
                crvAsientoDiario.Refresh()
            Catch
                crvAsientoDiario.ReportSource = Nothing
            End Try 
        End Sub

        Private Sub FormReporteAsiento_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a 
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s  
                Case Else
                    Icon = My.Resources.logo_c  
            End Select
            lblNumeroRegistro.Text = NumeroRegistro

            If EsAsiento Then
                ConectarReporteComprobanteCompra()
            Else
                ConectarReporteComprobanteTodos()
            End If
        End Sub
    End Class
End Namespace