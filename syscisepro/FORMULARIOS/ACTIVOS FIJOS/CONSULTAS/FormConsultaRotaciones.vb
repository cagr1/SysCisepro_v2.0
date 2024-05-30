Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.ENUMS
Imports syscisepro.DATOS

Namespace FORMULARIOS.ACTIVOS_FIJOS.CONSULTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormConsultaRotaciones
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

        ReadOnly _objRotaciones As New ClassRotacionActivos
        ReadOnly _crRotaciones As New crRotaciones

        Dim _indice As Integer = 0

        Private Sub Todas()
            dgvRotacionesVehiculos.DataSource = _objRotaciones.SeleccionarRotacionesVehiculos(_tipoCon)
            dgvRotacionesVehiculos.ReadOnly = False
            dgvRotacionesVehiculos.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvRotacionesVehiculos.AutoResizeColumns()
            dgvRotacionesVehiculos.AutoResizeRows()
            dgvRotacionesVehiculos.Columns("ESTADO").Visible = False
        End Sub

        Private Sub Hoy()
            dgvRotacionesVehiculos.DataSource = _objRotaciones.SeleccionarRotacionesVehiculosDiarias(_tipoCon)
            dgvRotacionesVehiculos.ReadOnly = False
            dgvRotacionesVehiculos.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvRotacionesVehiculos.AutoResizeColumns()
            dgvRotacionesVehiculos.AutoResizeRows()
            dgvRotacionesVehiculos.Columns("ESTADO").Visible = False
        End Sub

        Private Sub Entre()
            dgvRotacionesVehiculos.DataSource = _objRotaciones.SeleccionarTodosLosRegistrosRotacionesPorFecha(_tipoCon, dtpFechaInicial.Text, dtpFechaFinal.Text)
            dgvRotacionesVehiculos.ReadOnly = False
            dgvRotacionesVehiculos.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvRotacionesVehiculos.AutoResizeColumns()
            dgvRotacionesVehiculos.AutoResizeRows()
            dgvRotacionesVehiculos.Columns("ESTADO").Visible = False
        End Sub
        Private Sub pdRotaciones_PrintPage(ByVal sender As System.Object, ByVal e As Printing.PrintPageEventArgs) Handles pdRotaciones.PrintPage
            Dim estiloDetalles = New Font("Calibri", 6, FontStyle.Italic)
            Dim estiloCabecera As New Font("Arial", 16, FontStyle.Bold)

            Dim margenSuperior As Double = e.MarginBounds.Left
            Dim posicionY As Double
            Dim lineasPorPagina As Double
            Dim contador = 0
            Dim row As Windows.Forms.DataGridViewRow
            ' Calculamos el número de líneas que caben en cada página
            lineasPorPagina = e.MarginBounds.Height / estiloDetalles.GetHeight(e.Graphics)
            ' Imprimimos las cabeceras
            posicionY = margenSuperior + (contador * estiloDetalles.GetHeight(e.Graphics))
            e.Graphics.DrawString("                     REPORTE RÁPIDO DE ROTACION DE VEHÍCULOS", estiloCabecera, Brushes.BlueViolet, 10, posicionY)
            ' Dejamos una línea de separación
            contador += 4
            ' Recorremos las filas del DataGridView hasta que llegemos
            ' a las líneas que nos caben en cada página o al final del grid.
            While contador < lineasPorPagina AndAlso _indice < dgvRotacionesVehiculos.Rows.Count
                row = dgvRotacionesVehiculos.Rows(_indice)
                Dim texto = (From celda As DataGridViewCell In row.Cells Where celda.Value IsNot Nothing).Aggregate("        ", Function(current, celda) current + (vbTab + celda.Value.ToString()))
                ' Calculamos la posición en la que se escribe la línea
                posicionY = margenSuperior + (contador * estiloDetalles.GetHeight(e.Graphics))
                ' Escribimos la línea con el objeto Graphics
                e.Graphics.DrawString(texto, estiloDetalles, Brushes.Black, 10, posicionY)
                ' Incrementamos los contadores
                contador += 1
                _indice += 1
            End While
            ' Una vez fuera del bucle comprobamos si nos quedan más filas
            ' por imprimir, si quedan saldrán en la siguente página
            If _indice < dgvRotacionesVehiculos.Rows.Count Then
                e.HasMorePages = True
            Else
                ' si llegamos al final, se establece HasMorePages a
                ' false para que se acabe la impresión
                e.HasMorePages = False
                _indice = 0
            End If
        End Sub
        Private Sub btnReporteRotaciones_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReporteRotaciones.Click

            If rbTodas.Checked = True Then
                _crRotaciones.SetDataSource(_objRotaciones.SeleccionarRotacionesVehiculos(_tipoCon))      
            End If
            If rbDia.Checked = True Then
                _crRotaciones.SetDataSource(_objRotaciones.SeleccionarRotacionesVehiculosDiarias(_tipoCon)) 
            End If
            If rbEntre.Checked = True Then
                _crRotaciones.SetDataSource(_objRotaciones.SeleccionarTodosLosRegistrosRotacionesPorFecha(_tipoCon, dtpFechaInicial.Text, dtpFechaFinal.Text)) 
            End If
            crvRotaciones.ReportSource = _crRotaciones
            _crRotaciones.Refresh()
            _crRotaciones.SetParameterValue("img", ValidationForms.NombreLogo(_tipoCon, Application.StartupPath))
        End Sub

        Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnConsultar.Click
            If rbTodas.Checked = True Then
                Todas()
            End If
            If rbDia.Checked = True Then
                Hoy()
            End If
            If rbEntre.Checked = True Then
                Entre()
            End If
        End Sub
        Private Sub btnPrevio_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnPrevio.Click
            pdRotaciones.DefaultPageSettings.Landscape = True
            ppdRotaciones.Document = pdRotaciones
            ppdRotaciones.StartPosition = FormStartPosition.CenterScreen
            ppdRotaciones.WindowState = FormWindowState.Normal
            ppdRotaciones.PrintPreviewControl.Zoom = 0.5
            ppdRotaciones.ShowDialog()
        End Sub
        Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnImprimir.Click
            pdRotaciones.Print()
        End Sub

        Private Sub FormConsultaRotaciones_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvRotacionesVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    dgvRotacionesVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    dgvRotacionesVehiculos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvRotacionesVehiculos.Font = New Font("Roboto", 8, FontStyle.Regular)

        End Sub
    End Class
End Namespace