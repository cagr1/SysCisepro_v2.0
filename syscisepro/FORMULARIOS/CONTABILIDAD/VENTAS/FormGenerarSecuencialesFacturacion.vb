Imports System.Data.SqlClient
Imports ClassLibraryCisepro.CONTABILIDAD.VENTAS
Imports ClassLibraryCisepro.ENUMS
Imports ClassLibraryCisepro.ProcesosSql
Imports Microsoft.Office.Interop
Imports syscisepro.DATOS

Namespace FORMULARIOS.CONTABILIDAD.VENTAS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormGenerarSecuencialesFacturacion

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
         
        ReadOnly _objFacturaSecuencial As New ClassFacturaSecuenciales
        ReadOnly _objetoFacturaVenta As New ClassFacturaVenta
        
        Private Sub Deshabilitado()
            btnNuevo.Enabled = True
            btnCancelar.Enabled = False
            btnGuardar.Enabled = False
            gbDatos.Enabled = False
        End Sub

        Private Sub Habilitado()
            btnNuevo.Enabled = False
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            'btnReporte.Enabled = False
            gbDatos.Enabled = True
        End Sub

        Private Sub Limpiar()
            txtCantidadFacturaSecuencial.Text = 0
            txtInicialFacturaSecuencial.Text = 0
            txtFinalFacturaSecuencial.Text = 0
            txtObservacionesFacturaSecuenciales.Text = "..."
        End Sub

        Private Function ValidarCampos()
            If lblActual.Text <> "0" And txtCantidadFacturaSecuencial.Text <> "0" And dtpFechaFacturaSecuenciales.Value.Day >= Date.Now.Day Then
                Return True
            Else
                MsgBox("DATOS INGRESADOS INVALIDOS. POR FAVOR REVISE", MsgBoxStyle.Exclamation, "MENSAJE DE VALIDACIÓN")
                Return False
            End If
        End Function

        Private Sub UltimoSecuencial()
            Dim a = _objetoFacturaVenta.BuscarMayorNumeroFacturaVentaIt(_tipoCon)
            lblActual.Text = If(a = 0, 1, a)
        End Sub

        Private Sub Cargar()
            dgvFacturaSecuenciales.DataSource = _objFacturaSecuencial.SeleccionarRegistrosFacturaSecuenciales(_tipoCon)
            dgvFacturaSecuenciales.AutoResizeColumns()
            dgvFacturaSecuenciales.AutoResizeRows()
        End Sub

        Private Sub GuardarFacturaSecuenciales()
            With _objFacturaSecuencial
                .IdSecuenciales = .BuscarMayorIdFacturaSecuencial(_tipoCon) + 1
                .FechaSecuenciales = dtpFechaFacturaSecuenciales.Value
                .CantidadSecuenciales = txtCantidadFacturaSecuencial.Text
                .InicialSecuenciales = txtInicialFacturaSecuencial.Text
                .FinalSecuenciales = txtFinalFacturaSecuencial.Text
                .ActualSecuenciales = lblActual.Text
                .ObservacionesSecuenciales = txtObservacionesFacturaSecuenciales.Text
                .EstadoSecuenciales = 1 
            End With
            _sqlCommands.Add(_objFacturaSecuencial.NuevoRegistroFacturaSecuenciales)
        End Sub

        Private Sub FormGenerarSecuencialesFacturacion_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    Label7.ForeColor = Color.White
                    Label7.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvFacturaSecuenciales.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    msKardex.ForeColor = Color.White
                    Label7.ForeColor = Color.White
                    Label7.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvFacturaSecuenciales.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    msKardex.ForeColor = Color.White
                    Label7.ForeColor = Color.White
                    Label7.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvFacturaSecuenciales.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvFacturaSecuenciales.Font = New Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)

            Deshabilitado()
            UltimoSecuencial()
            Cargar() 
        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnNuevo.Click
            Habilitado()
            Limpiar()
            UltimoSecuencial()
            txtInicialFacturaSecuencial.Text = CType(lblActual.Text, Integer) + 1
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancelar.Click
            Limpiar()
            Deshabilitado()
        End Sub

        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If ValidarCampos() = True Then

                If MessageBox.Show("¿ESTA SEGURO QUE DESEA GUARDAR?", "MENSAJE DE VALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> MsgBoxResult.Yes Then Return
                _sqlCommands.Clear()

                GuardarFacturaSecuenciales()
                 
                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, String.Empty)
                If res(0) Then
                    Cargar()
                    Limpiar()
                    Deshabilitado()
                End If
                MsgBox(res(1), If(res(0), MsgBoxStyle.Information, MsgBoxStyle.Exclamation), "Mensaje del sistema")
                 
            End If
            Cargar()
        End Sub

        Private Sub txtCantidadFacturaSecuencial_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtCantidadFacturaSecuencial.TextChanged
            Try
                UltimoSecuencial()
                If txtCantidadFacturaSecuencial.Text <> 0 Then
                    txtInicialFacturaSecuencial.Text = CInt(lblActual.Text) + 1
                    txtFinalFacturaSecuencial.Text = CInt(lblActual.Text) + CInt(txtCantidadFacturaSecuencial.Text)
                Else
                    txtInicialFacturaSecuencial.Text = 0
                    txtFinalFacturaSecuencial.Text = 0
                End If
            Catch ex As Exception
                txtInicialFacturaSecuencial.Text = 0
                txtFinalFacturaSecuencial.Text = 0
            End Try
        End Sub

        Private Sub txtCantidadFacturaSecuencial_Validated(ByVal sender As System.Object, ByVal e As EventArgs) Handles txtCantidadFacturaSecuencial.Validated
            If txtCantidadFacturaSecuencial.Text = "" Then txtCantidadFacturaSecuencial.Text = "0" 
        End Sub

        Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
            If dgvFacturaSecuenciales.Rows.Count = 0 Or dgvFacturaSecuenciales.CurrentRow Is Nothing Then Return
            ExportarDatosExcel(dgvFacturaSecuenciales, "SECUENCIALES DE FACTURACIÓN") ' exporta la facturacion 
        End Sub

        Private Sub ExportarDatosExcel(ByVal dataGridViewExp As DataGridView, ByVal titulo As String)
            Try
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
            Catch ex As Exception
                MsgBox("EXPORTAR REVISIÓN DE FACTURACIÓN." & vbNewLine & ex.Message.ToString, MsgBoxStyle.Critical, "MENSAJE DE EXCEPCIÓN")
            End Try
        End Sub
    End Class
End Namespace