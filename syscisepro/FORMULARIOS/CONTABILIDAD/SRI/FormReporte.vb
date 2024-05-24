Imports ClassLibraryCisepro.CONTABILIDAD.SRI
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Reporting.WinForms
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.SRI

    Public Class FormReporte
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
        'Cree dos listas una para el Encabezado y otra para el detalle
        '
        Public ReadOnly Invoice As New List(Of ClassAts)()
        '
        'Cree las propiedades publicas Titulo y Empresa
        '
        Private Property Empresa As String
        Public Property Periodo As String

        Private Sub FormReporte_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load, ReportViewerATS.Load

            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Empresa = ValidationForms.NombreCompany(_tipoCon)

            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a 
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                Case Else
                    Icon = My.Resources.logo_c 
            End Select

            'Limpiemos el DataSource del informe
            ReportViewerATS.LocalReport.DataSources.Clear()
            '
            'Establezcamos los parametros que enviaremos al reporte
            'recuerde que son dos para el titulo del reporte y para el nombre de la empresa
            '
            Dim parameters(1) As ReportParameter
            parameters(0) = New ReportParameter("Empresa", Empresa.ToString, True)
            parameters(1) = New ReportParameter("Periodo", Periodo.ToString)
            '
            'Establezcamos la lista como Datasource del informe
            '
            ReportViewerATS.LocalReport.DataSources.Add(New ReportDataSource("ATS", Invoice))
            'ReportViewerATS.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detail))
            '
            'Enviemos la lista de parametros
            '
            ReportViewerATS.LocalReport.SetParameters(parameters)

            '
            'Hagamos un refresh al reportViewer
            '
            ReportViewerATS.RefreshReport()
            'Catch ex As Exception
            '    MsgBox(ex.Message.ToString)
            'End Try
        End Sub
    End Class
End Namespace