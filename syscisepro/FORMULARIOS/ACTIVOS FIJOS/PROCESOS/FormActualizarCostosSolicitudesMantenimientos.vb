Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ACTIVOS_FIJOS.MODULOS_DE_ACTIVOS_FIJOS
Imports ClassLibraryCisepro.CONTABILIDAD.COMPRAS.COMPROBANTES_COMPRA
Imports ClassLibraryCisepro.ENUMS
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.ACTIVOS_FIJOS.PROCESOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormActualizarCostosSolicitudesMantenimientos
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

        Dim _sqlCommands As List(Of SqlCommand)
        Public IdUsuario As Integer

        ReadOnly _objActMan As New ClassActivoFijoMantenimiento
        ReadOnly _objCompCom As New ClassComprobantesCompra

        Private Sub FormActualizarCostosSolicitudesMantenimientos_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    dgvAsientosMantenimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobanteCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvDetallesmantenimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvSolicitudesMantenimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s 
                    dgvAsientosMantenimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobanteCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvDetallesmantenimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvSolicitudesMantenimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c 
                    dgvAsientosMantenimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobanteCompra.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvDetallesmantenimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvSolicitudesMantenimientos.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select

            CargarSolicitudesMantenimientosPendientes()
            CargarAsientosMantenimiento() 
        End Sub

        Private Sub CargarSolicitudesMantenimientosPendientes()
            Try
                dgvSolicitudesMantenimientos.DataSource = _objActMan.SeleccionarSolictudesMantenimientosPendiente(_tipoCon)
                dgvSolicitudesMantenimientos.AutoResizeRows()
                dgvSolicitudesMantenimientos.AutoResizeColumns()
            Catch
                dgvSolicitudesMantenimientos.DataSource = Nothing
                Exit Try
            End Try
        End Sub
        Private Sub CargarAsientosMantenimiento()
            dgvAsientosMantenimientos.DataSource = _objActMan.SeleccionarAsientosMantenimientos(_tipoCon)
            dgvAsientosMantenimientos.AutoResizeRows()
            dgvAsientosMantenimientos.AutoResizeColumns()
        End Sub
        '=============================================================================================================================================================================
        Private Sub dgvSolicitudesMantenimientos_CellClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvSolicitudesMantenimientos.CellClick
            CargarDetallesMantenimiento()
        End Sub
        '=============================================================================================================================================================================
        Private Sub CargarDetallesMantenimiento()
            Try
                dgvDetallesmantenimientos.DataSource = _objActMan.SeleccionarDetallesMantenimientoXidMantenimiento(_tipoCon, dgvSolicitudesMantenimientos.CurrentRow.Cells.Item(0).Value.ToString.ToUpper)
                dgvDetallesmantenimientos.AutoResizeRows()
                dgvDetallesmantenimientos.AutoResizeColumns()
            Catch
                dgvDetallesmantenimientos.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub dgvAsientosMantenimientos_CellClick(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvAsientosMantenimientos.CellClick
            Try
                Dim cadena As String

                cadena = dgvAsientosMantenimientos.CurrentRow.Cells.Item(4).Value
                Dim varCadena = ""
                Dim totalCadena
                totalCadena = cadena.Length
                For indice = 5 To totalCadena
                    If Mid(cadena, indice, 1) = " " Then
                        Exit For
                    Else
                        varCadena = Mid(cadena, 1, indice)
                    End If
                Next
                dgvComprobanteCompra.DataSource = _objCompCom.SeleccionarComprobantesCompraXIdComprobanteCompra(_tipoCon, CType(Mid(varCadena, 5, varCadena.Length), Int64))
                dgvComprobanteCompra.AutoResizeRows()
                dgvComprobanteCompra.AutoResizeColumns()
            Catch
                dgvComprobanteCompra.DataSource = Nothing
                Exit Try
            End Try
        End Sub

        Private Sub ExportarDatosExcel(ByVal dataGridViewExp As DataGridView, ByVal titulo As String)
            Dim mExcel As New Excel.Application
            mExcel.Cursor = Excel.XlMousePointer.xlWait
            mExcel.Visible = True
            Dim objLibroExcel As Excel.Workbook = mExcel.Workbooks.Add
            Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
            With objHojaExcel
                .Visible = Excel.XlSheetVisibility.xlSheetVisible
                .Activate()
                'Encabezado  
                .Range("A1:L1").Merge()
                .Range("A1:L1").Value = ValidationForms.NombreCompany(_tipoCon)
                .Range("A1:L1").Font.Bold = True
                .Range("A1:L1").Font.Size = 15

                'Copete  
                .Range("A2:L2").Merge()
                .Range("A2:L2").Value = titulo
                .Range("A2:L2").Font.Bold = True
                .Range("A2:L2").Font.Size = 12

                Const primeraLetra As Char = "A"
                Const primerNumero As Short = 3
                Dim Letra As Char, UltimaLetra As Char
                Dim Numero As Integer, UltimoNumero As Integer
                Dim cod_letra As Byte = Asc(primeraLetra) - 1
                Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
                Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
                'Establecer formatos de las columnas de la hija de cálculo  
                Dim strColumna As String = ""
                Dim LetraIzq As String = ""
                Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
                Letra = primeraLetra
                Numero = primerNumero
                Dim objCelda As Excel.Range
                For Each c As DataGridViewColumn In dataGridViewExp.Columns
                    If c.Visible Then
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Chr(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + Letra + Numero.ToString
                        objCelda = .Range(strColumna, Type.Missing)
                        objCelda.Value = c.HeaderText
                        objCelda.EntireColumn.Font.Size = 8
                        'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
                        If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                            objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
                        End If
                    End If
                Next

                Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
                objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
                UltimaLetra = Letra
                Dim UltimaLetraIzq As String = LetraIzq

                'CARGA DE DATOS  
                Dim i As Integer = Numero + 1

                For Each reg As DataGridViewRow In dataGridViewExp.Rows
                    LetraIzq = ""
                    cod_LetraIzq = Asc(primeraLetra) - 1
                    Letra = primeraLetra
                    cod_letra = Asc(primeraLetra) - 1
                    For Each c As DataGridViewColumn In dataGridViewExp.Columns
                        If c.Visible Then
                            If Letra = "Z" Then
                                Letra = primeraLetra
                                cod_letra = Asc(primeraLetra)
                                cod_LetraIzq += 1
                                LetraIzq = Chr(cod_LetraIzq)
                            Else
                                cod_letra += 1
                                Letra = Chr(cod_letra)
                            End If
                            strColumna = LetraIzq + Letra
                            ' acá debería realizarse la carga  
                            .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                            '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))  
                            '.Range(strColumna + i, strColumna + i).In()  
                        End If
                    Next
                    Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
                    objRangoReg.Rows.BorderAround()
                    objRangoReg.Select()
                    i += 1
                Next
                UltimoNumero = i

                'Dibujar las líneas de las columnas  
                LetraIzq = ""
                cod_LetraIzq = Asc("A")
                cod_letra = Asc(primeraLetra)
                Letra = primeraLetra
                For Each c As DataGridViewColumn In dataGridViewExp.Columns
                    If c.Visible Then
                        objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
                        objCelda.BorderAround()
                        If Letra = "Z" Then
                            Letra = primeraLetra
                            cod_letra = Asc(primeraLetra)
                            LetraIzq = Chr(cod_LetraIzq)
                            cod_LetraIzq += 1
                        Else
                            cod_letra += 1
                            Letra = Chr(cod_letra)
                        End If
                    End If
                Next

                'Dibujar el border exterior grueso  
                Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
                objRango.Select()
                objRango.Columns.AutoFit()
                objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            End With

            mExcel.Cursor = Excel.XlMousePointer.xlDefault
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnExportar.Click
            ExportarDatosExcel(dgvAsientosMantenimientos, "MANTENIMIENTOS")
        End Sub
    End Class
End Namespace