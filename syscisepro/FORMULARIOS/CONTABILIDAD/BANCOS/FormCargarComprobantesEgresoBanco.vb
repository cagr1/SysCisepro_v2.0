Imports System.Data
Imports System.Data.OleDb
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS
Imports ClassLibraryCisepro.CONTABILIDAD.BANCOS.AUDITORIA
Imports ClassLibraryCisepro.CONTABILIDAD.LIBRO_DIARIO
Imports ClassLibraryCisepro.CONTABILIDAD.PLAN_DE_CUENTAS
Imports ClassLibraryCisepro.ENUMS
Imports System.Data.SqlClient
Imports ClassLibraryCisepro.ProcesosSql
Imports Excel = Microsoft.Office.Interop.Excel
Imports Krypton.Toolkit

Namespace FORMULARIOS.CONTABILIDAD.BANCOS
    ''' <summary>
    ''' CISEPRO - SEPORTPAC - ASENAVA 2019
    ''' </summary>
    Public Class FormCargarComprobantesEgresoBanco
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
        Public UserName As String

        ReadOnly _objetoPlanCuentas As New ClassPlanDeCuentas
        ReadOnly _objetoLibroDiario As New ClassLibroDiario
        ReadOnly _objetoAsientoLibroDiario As New ClassAsientosLibroDiario
        ReadOnly _objetoNumeroRegistro As New ClassNumeroRegistroAsiento
        ReadOnly _objetoNumeroRegistroAsientoComprobanteEgreso As New ClassNumeroRegistroAsientoComprobanteEgreso
        ReadOnly _objetoComprobanteEgresoBancos As New ClassComprobanteEgresoBanco
        ReadOnly _objetoChequeEmitido As New ClassChequesEmitidosCxp
        ReadOnly _objAuditoria As New ClassAuditoriaGeneral
        ReadOnly _objetoBancos As New ClassBancos
        ReadOnly _objetoCuentaBancos As New ClassCuentasBancos

        Dim _sqlCommands As List(Of SqlCommand)
        Dim _validarNumeroCheques As Integer = 0
        Dim _validarimportacion As Integer = 0
        Dim _varIdLibroDiario As Int64

        Private Sub FormCargarComprobantesEgresoBanco_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
            ' DEFINIR TIPO Y COLOR DE SISTEMA
            Select Case _tipoCon
                Case TipoConexion.Asenava
                    Icon = My.Resources.logo_a
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorAsenava
                    dgvComprobantesEgresoBanco.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorAsenava
                Case TipoConexion.Seportpac
                    Icon = My.Resources.logo_s
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorSeportpac
                    dgvComprobantesEgresoBanco.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorSeportpac
                Case Else
                    Icon = My.Resources.logo_c
                    msKardex.ForeColor = Color.White
                    'msKardex.BackColor = My.MySettingsProperty.Settings.ColorCisepro
                    dgvComprobantesEgresoBanco.DefaultCellStyle.SelectionBackColor = My.MySettingsProperty.Settings.ColorCisepro
            End Select
            dgvComprobantesEgresoBanco.Font = New System.Drawing.Font("Roboto", 8, FontStyle.Regular)
            _sqlCommands = New List(Of SqlCommand)
            AutocompletarPlanCuentas()
            LlenarComboBancos()
            dgvComprobantesEgresoBanco.ContextMenuStrip = ContextMenuStripClicDerecho 'Asigno a la propiedad contextMenuStrip del dgv el menu creado para el clic derecho
        End Sub
        Private Sub AutocompletarPlanCuentas()
            Try
                txtCuentaDebe.AutoCompleteCustomSource = _objetoPlanCuentas.Autocompletar(_tipoCon)
                txtCuentaDebe.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                txtCuentaDebe.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
                txtCuentaDebe.AutoCompleteCustomSource = Nothing
            End Try
        End Sub
        Private Sub LlenarComboBancos()
            Try
                Dim data = _objetoBancos.SeleccionarRegistrosBancos(_tipoCon)
                cmbBancos.DataSource = data
                cmbBancos.DisplayMember = data.Columns(2).ToString
                cmbBancos.ValueMember = data.Columns(0).ToString
            Catch
                cmbBancos.DataSource = Nothing
            End Try
        End Sub
        Private Sub cmbBancos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBancos.SelectedValueChanged
            LlenarComboCuentasBancos()
        End Sub
        Private Sub LlenarComboCuentasBancos()
            Try
                Dim data = _objetoCuentaBancos.BuscarNumeroCuentaXIdBanco(_tipoCon, CInt(cmbBancos.SelectedValue))
                cmbCuentaBancos.DataSource = data
                cmbCuentaBancos.DisplayMember = data.Columns(1).ToString
                cmbCuentaBancos.ValueMember = data.Columns(0).ToString
            Catch
                cmbCuentaBancos.DataSource = Nothing
            End Try
        End Sub
        Private Sub dgvComprobantesEgresoBanco_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvComprobantesEgresoBanco.MouseDown
            If e.Button <> MouseButtons.Right Then Return
            dgvComprobantesEgresoBanco.Rows(dgvComprobantesEgresoBanco.CurrentCell.RowIndex.ToString()).Selected = True
        End Sub
        Private Sub ToolStripMenuItemEliminar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolStripMenuItemEliminar.Click
            If dgvComprobantesEgresoBanco.SelectedRows.Count <> 1 Then

                KryptonMessageBox.Show("Debe seleccionar sólo una fila!", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                Return
            End If

            Dim lsMensage As String = "¿Esta seguro de querer eliminar este Registro" & vbCrLf & dgvComprobantesEgresoBanco.CurrentRow().Cells(2).Value.ToString()

            If KryptonMessageBox.Show(lsMensage, "Mensaje de validación", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
            dgvComprobantesEgresoBanco.Rows.RemoveAt(dgvComprobantesEgresoBanco.CurrentRow.Index)

            KryptonMessageBox.Show("Fila eliminada", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
        End Sub
        Private Sub txtCuentaDebe_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaDebe.KeyUp
            If e.KeyCode <> Keys.Enter Then Return
            Try
                Dim cad = txtCuentaDebe.Text.Trim().Split("-")
                lblCodigoCta.Text = cad(0)
            Catch ex As Exception
                lblCodigoCta.Text = "0"

                KryptonMessageBox.Show("Error al seleccionar la cuenta! " & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try
        End Sub
        Private Sub btnBuscarPersonal_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBuscarPersonal.Click
            Try
                ofdSeleccionarArchivo.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
                ofdSeleccionarArchivo.Title = "Seleccione el archivo de Excel"
                If ofdSeleccionarArchivo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    txtRutaArchivo.Text = ofdSeleccionarArchivo.FileName
                    ImportarArchivoDeExcel(txtRutaArchivo.Text)
                    ValidarCheques()
                End If
            Catch ex As Exception

                KryptonMessageBox.Show("Error al seleccionar el archivo! " & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End Try
        End Sub
        Private Sub ImportarArchivoDeExcel(ByVal archivoImportar As String)
            Dim excelApp As New Excel.Application()
            Dim workbook As Excel.Workbook = Nothing
            Dim worksheet As Excel.Worksheet = Nothing
            Dim Range As Excel.Range = Nothing

            'Dim conexion As OleDbConnection
            'Dim dtSet As DataSet
            'Dim misqlDa As OleDbDataAdapter
            'Dim enlace As BindingSource
            'Dim consulta As String
            Try
                'conexion = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & archivoImportar & "';Extended Properties=Excel 12.0;")
                'conexion.Open()
                ''consulta = "select FECHA, RUC_CI, NOMBRE_RECEPTOR, CONCEPTO, RAZON_COMPROBANTE, VALOR, BANCO, CUENTA, NUMERO_CHEQUE from [COMPROBANTE_EGRESO_BANCOS$]"
                'misqlDa = New OleDbDataAdapter(consulta, conexion)
                'dtSet = New DataSet()
                'enlace = New BindingSource()
                'misqlDa.Fill(dtSet, "COMPROBANTE_EGRESO")
                'enlace.DataSource = dtSet
                'enlace.DataMember = "COMPROBANTE_EGRESO"
                'dgvComprobantesEgresoBanco.DataSource = enlace
                'conexion.Close()

                workbook = excelApp.Workbooks.Open(archivoImportar)
                worksheet = CType(workbook.Sheets(1), Excel.Worksheet)
                Range = worksheet.UsedRange

                Dim dt As New DataTable()

                For col = 1 To Range.Columns.Count
                    dt.Columns.Add(New DataColumn(Range.Cells(1, col).Value))
                Next

                For row = 2 To Range.Rows.Count
                    Dim dr As DataRow = dt.NewRow()
                    For col = 1 To Range.Columns.Count
                        dr(col - 1) = Range.Cells(row, col).Value
                    Next
                    dt.Rows.Add(dr)
                Next

                dgvComprobantesEgresoBanco.DataSource = dt
                _validarimportacion = 1
            Catch ex As Exception

                KryptonMessageBox.Show("Error al importar el archivo excel! " & vbNewLine & "Por favor revise que el formato sea el establecido. " & vbNewLine & ex.Message.ToString, "Mensaje de excepción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                _validarimportacion = 0
            End Try
        End Sub
        Private Sub ValidarCheques()
            _validarNumeroCheques = 1
            Dim b As String
            For indice = 0 To dgvComprobantesEgresoBanco.Rows.Count - 1
                b = _objetoChequeEmitido.BuscarBancoXNumeroChequeEmitido(_tipoCon, dgvComprobantesEgresoBanco.Rows(indice).Cells(8).Value)
                If b <> "0" Then
                    If b = dgvComprobantesEgresoBanco.Rows(indice).Cells(6).Value Then

                        KryptonMessageBox.Show("El número de cheque: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(8).Value.ToString & vbNewLine & "Ya esta girado en el banco seleccionado:" + cmbBancos.SelectedValue.ToString, "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        dgvComprobantesEgresoBanco.Rows(indice).DefaultCellStyle.BackColor = Color.Salmon
                        _validarNumeroCheques = 0
                    End If
                End If
            Next
        End Sub
        Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGuardar.Click
            If txtRutaArchivo.Text <> "" And dgvComprobantesEgresoBanco.Rows.Count > 0 Then
                If txtCuentaDebe.Text <> "" And lblCodigoCta.Text <> 0 Then
                    If _validarimportacion = 1 Then
                        If ValidarComprobantesEgreso() Then
                            ValidarCheques()
                            If _validarNumeroCheques = 1 Then

                                _sqlCommands.Clear()


                                ' ID LIBRO DIARIO
                                _varIdLibroDiario = _objetoLibroDiario.BuscarMayorIdLibroDiario(_tipoCon)

                                GuardarGeneralComprobanteEgresoChequeAsiento()

                                Dim User As String = "Carga de Comprobante de Egreso por:" + UserName

                                Dim res = ComandosSql.ProcesarTransacciones(_tipoCon, _sqlCommands, User)


                                If res(0) Then

                                    txtRutaArchivo.Text = ""
                                    txtCuentaDebe.Text = ""
                                    lblCodigoCta.Text = "0"

                                    KryptonMessageBox.Show("Planilla guardada correctamente!", "Mensaje del sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
                                End If
                                Dim messageIcon As KryptonMessageBoxIcon
                                If res(0) Then
                                    messageIcon = KryptonMessageBoxIcon.Information
                                Else
                                    messageIcon = KryptonMessageBoxIcon.Exclamation
                                End If
                                KryptonMessageBox.Show(res(1), "Mensaje del sistema", KryptonMessageBoxButtons.OK, messageIcon)


                            Else

                                KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "Existen cheques ya guardados en el archivo importado.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                            End If
                        Else

                            KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "Existen datos en blanco en el archivo importado.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                        End If
                    Else
                        KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "el archivo seleccionado no se cargo de forma correcta." & vbNewLine & "POR FAVOR REVISE EL FORMATO.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                    End If
                Else
                    KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "No se ha seleccionado una cta. contable.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
                End If
            Else
                KryptonMessageBox.Show("No se puede guardar." & vbNewLine & "No se han cargado ningún archivo.", "Mensaje de validación", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Exclamation)
            End If
        End Sub
        Private Function ValidarComprobantesEgreso() As Boolean
            Dim nulo As Integer = 1 ' si es nulo = 0 / no es nulo = 1
            For indiceFila = 0 To dgvComprobantesEgresoBanco.RowCount - 1
                For indiceColumna = 0 To dgvComprobantesEgresoBanco.ColumnCount - 1
                    If dgvComprobantesEgresoBanco.Rows(indiceFila).Cells(indiceColumna).Value Is DBNull.Value Then
                        nulo = 0
                        dgvComprobantesEgresoBanco.Rows(indiceFila).DefaultCellStyle.BackColor = Color.Salmon
                    End If
                Next
            Next
            Return nulo = 1
        End Function
        Private Sub GuardarGeneralComprobanteEgresoChequeAsiento()
            Dim _idComprobanteEgreso = _objetoComprobanteEgresoBancos.BuscarMayorIdComprobanteEgresoBancos(_tipoCon) + 1
            Dim _idCheque = _objetoChequeEmitido.BuscarMayorIdChequeEmitidoCxp(_tipoCon) + 1
            Dim _varIdAsiento = _objetoAsientoLibroDiario.BuscarMayorIdAsientoLibroDiario(_tipoCon) + 1

            Dim nRegistroNuevo = _objetoNumeroRegistro.BuscarMayorNumeroRegistro(_tipoCon) + 1
            Dim nRegistroAnterior = _objetoNumeroRegistro.BuscarMayorNumeroAnterior(_tipoCon) + 1

            For indice = 0 To dgvComprobantesEgresoBanco.Rows.Count - 1
                If dgvComprobantesEgresoBanco.Rows(indice).DefaultCellStyle.BackColor <> Color.Salmon Then

                    dgvComprobantesEgresoBanco.ClearSelection()
                    dgvComprobantesEgresoBanco.Rows(indice).Selected = True

                    ' GUARDAR TABLA COMPROBANTE_EGRESO_BANCOS
                    With _objetoComprobanteEgresoBancos                        
                        .Id = _idComprobanteEgreso
                        .NumeroComprobante = _idComprobanteEgreso
                        .FechaComprobante = CDate(dgvComprobantesEgresoBanco.Rows(indice).Cells(0).Value)
                        .NumeroFactura = "0"
                        .RucCiReceptor = dgvComprobantesEgresoBanco.Rows(indice).Cells(1).Value
                        .NombreReceptor = dgvComprobantesEgresoBanco.Rows(indice).Cells(2).Value
                        .Actividad = "1010102"
                        .Concepto = dgvComprobantesEgresoBanco.Rows(indice).Cells(3).Value
                        .TipoPago = "CHEQUE"
                        .Razon = dgvComprobantesEgresoBanco.Rows(indice).Cells(4).Value
                        .Valor = dgvComprobantesEgresoBanco.Rows(indice).Cells(5).Value
                        .NumeroCheque = dgvComprobantesEgresoBanco.Rows(indice).Cells(8).Value
                        .Estado = 2
                        .IdCentroCosto = 2
                        .IdProvincias = "7"
                        .IdCiudad = "58"
                        .IdParroquias = "287"
                        .IdBancos = CInt(cmbBancos.SelectedValue)
                        .IdCuentaBanco = CInt(cmbCuentaBancos.SelectedValue)
                        '.NuevoRegistroComprobanteEgresoBancos(_tipoCon) 
                    End With
                    _sqlCommands.Add(_objetoComprobanteEgresoBancos.NuevoRegistroComprobanteEgresoBancos())


                    ' GUARDAR TABLA _CHEQUES
                    With _objetoChequeEmitido
                        .IdCheque = _idCheque
                        .FechaEmisionCheque = CDate(dgvComprobantesEgresoBanco.Rows(indice).Cells(0).Value)
                        .BancoCheque = dgvComprobantesEgresoBanco.Rows(indice).Cells(6).Value
                        .CtaCteCheque = dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value
                        .NumeroCheque = dgvComprobantesEgresoBanco.Rows(indice).Cells(8).Value
                        .BeneficiarioCheque = dgvComprobantesEgresoBanco.Rows(indice).Cells(2).Value
                        .ValorCheque = dgvComprobantesEgresoBanco.Rows(indice).Cells(5).Value
                        .EstadoCheque = 1
                        .FechaCobro = "26-10-1984 05:30:00"
                        .IdComprobante = _idComprobanteEgreso
                        '.NuevoRegistroChequeEmitidoCxp(_tipoCon)
                    End With
                    _sqlCommands.Add(_objetoChequeEmitido.NuevoRegistroChequeEmitidoCxp())

                    ' GUARDAR TABLA NUMERO_REGISTRO                   
                    With _objetoNumeroRegistro
                        .NumeroRegistro = nRegistroNuevo
                        .NumeroAnterior = nRegistroAnterior
                        '.NuevoNumeroRegistroAsientoLibroDiario(_tipoCon)
                    End With
                    _sqlCommands.Add(_objetoNumeroRegistro.NuevoNumeroRegistroAsientoLibroDiarioCommand())

                    ' GUARDAR TABLA ASIENTOS_LIBRO_DIARIO 'DEBE'
                    With _objetoAsientoLibroDiario
                        .IdAsiento = _varIdAsiento
                        .FechaAsiento = CDate(dgvComprobantesEgresoBanco.Rows(indice).Cells(0).Value)
                        .CodigoCuentaAsiento = lblCodigoCta.Text.Trim
                        .NombreCuentaAsiento = txtCuentaDebe.Text.Trim().Split("-")(1).Trim
                        .ConceptoAsiento = "COMPROBANTE DE EGRESO BANCOS"
                        .DetalleTransaccionAsiento = "ID: " + _idComprobanteEgreso.ToString + " " + dgvComprobantesEgresoBanco.Rows(indice).Cells(3).Value.ToString + " BANCO: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(6).Value.ToString + " CTA:" + dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value.ToString + " CHEQUE Nº: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(8).Value.ToString
                        .ProvinciaAsiento = "EL ORO"
                        .CiudadAsiento = "MACHALA"
                        .ParroquiaAsiento = "MACHALA"
                        .CentroCostoAsiento = "GERENCIA ADMINISTRATIVA-FINANCIERA"
                        .ValorDebeAsiento = dgvComprobantesEgresoBanco.Rows(indice).Cells(5).Value
                        .ValorHaberAsiento = "0.00"
                        .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                        .DebeHaberAsiento = 1   ' DEBE=1 / HABER=2 
                        .ConciliarAsiento = 1
                        .EstadoAsiento = 1
                        .IdLibroDiario = _varIdLibroDiario
                        .EstadoMayorAsiento = 0
                        '.NuevoRegistroAsientoLibroDiario(_tipoCon)
                    End With
                    _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())

                    ' GUARDAR TABLA ASIENTOS_LIBRO_DIARIO 'HABER'
                    _varIdAsiento += 1
                    With _objetoAsientoLibroDiario 
                        .IdAsiento = _varIdAsiento
                        .FechaAsiento = CDate(dgvComprobantesEgresoBanco.Rows(indice).Cells(0).Value)
                        .CodigoCuentaAsiento = _objetoCuentaBancos.BuscarCodigoPlanXIdCuenta(_tipoCon, CInt(cmbCuentaBancos.SelectedValue)).Trim
                        .NombreCuentaAsiento = _objetoPlanCuentas.BuscarDetallePlanCuentasXcodigo(_tipoCon, .CodigoCuentaAsiento).Trim
                        .ConceptoAsiento = "COMPROBANTE DE EGRESO BANCOS"
                        .DetalleTransaccionAsiento = "ID: " + _idComprobanteEgreso.ToString + " " + dgvComprobantesEgresoBanco.Rows(indice).Cells(3).Value.ToString + " BANCO: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(6).Value.ToString + " CTA:" + dgvComprobantesEgresoBanco.Rows(indice).Cells(7).Value.ToString + " CHEQUE Nº: " + dgvComprobantesEgresoBanco.Rows(indice).Cells(8).Value.ToString
                        .ProvinciaAsiento = "EL ORO"
                        .CiudadAsiento = "MACHALA"
                        .ParroquiaAsiento = "MACHALA"
                        .CentroCostoAsiento = "GERENCIA ADMINISTRATIVA-FINANCIERA"
                        .ValorDebeAsiento = "0.00"
                        .ValorHaberAsiento = dgvComprobantesEgresoBanco.Rows(indice).Cells(5).Value
                        .NumeroRegistroAsiento = _objetoNumeroRegistro.NumeroRegistro
                        .DebeHaberAsiento = 2   ' DEBE=1 / HABER=2 
                        .ConciliarAsiento = 1
                        .EstadoAsiento = 1
                        .IdLibroDiario = _varIdLibroDiario
                        .EstadoMayorAsiento = 0
                        '.NuevoRegistroAsientoLibroDiario(_tipoCon)
                    End With
                    _sqlCommands.Add(_objetoAsientoLibroDiario.NuevoRegistroAsientoLibroDiarioCommand())


                    ' GUARDAR TABLA NUMERO_REGISTRO_ASIENTO_
                    With _objetoNumeroRegistroAsientoComprobanteEgreso
                        .IdComprobanteEgreso = _idComprobanteEgreso
                        .IdLibro = _varIdLibroDiario
                        .IdAsiento = _objetoAsientoLibroDiario.IdAsiento
                        .NumeroRegistro = _objetoNumeroRegistro.NumeroRegistro
                        '.NuevoRegistroNumeroRegistroAsientoComprobanteEgreso(_tipoCon)
                    End With
                    _sqlCommands.Add(_objetoNumeroRegistroAsientoComprobanteEgreso.NuevoRegistroNumeroRegistroAsientoComprobanteEgreso())


                    _idComprobanteEgreso += 1
                    _idCheque += 1
                    _varIdAsiento += 1
                    nRegistroNuevo += 1
                    nRegistroAnterior += 1
                End If
            Next
        End Sub
    End Class
End Namespace