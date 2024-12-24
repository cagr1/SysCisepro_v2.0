Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Krypton.Toolkit



Namespace FORMULARIOS.CONTABILIDAD.BANCOS.REPORTES
    Public Class FormReporteTodo
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

        Public ids As List(Of String)
        Public data As DataTable

        Private Sub FormReporteTodo_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = Nothing
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                Case Else
                    Icon = My.Resources.logo_c
            End Select

        End Sub

        Private Sub GenerarTodo()
            'compare if ids > 0 or is not null
            If ids.Count > 0 Then
                Dim ruta As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "ComprobanteCompra.pdf")
                PdfViewer1.Document?.Dispose()
                PdfViewer1.Document = Nothing

                Dim pdfStream As New MemoryStream()
                'Using fs As New FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None)
                Dim document As New iTextSharp.text.Document(PageSize.A5)
                Dim writer As PdfWriter = PdfWriter.GetInstance(document, PdfStream)
                writer.CloseStream = False
                document.Open()

                Dim baseFont As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED)
                Dim fuente12 As iTextSharp.text.Font = New Font(baseFont, 12, iTextSharp.text.Font.BOLD)
                Dim fuente10Bold As iTextSharp.text.Font = New Font(baseFont, 10, iTextSharp.text.Font.BOLD)
                Dim fuente10 As iTextSharp.text.Font = New Font(baseFont, 10)
                Dim fuente8 As iTextSharp.text.Font = New Font(baseFont, 8)
                Dim fuente8Bold As iTextSharp.text.Font = New Font(baseFont, 8, iTextSharp.text.Font.BOLD)

                Dim rutaImagen As String = ValidationForms.NombreLogoNuevo(_tipoCon, Application.StartupPath)
                Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(rutaImagen)
                logo.ScaleToFit(30, 30)



            Else
                KryptonMessageBox.Show("No hay registros para mostrar", "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End If

        End Sub

    End Class
End Namespace