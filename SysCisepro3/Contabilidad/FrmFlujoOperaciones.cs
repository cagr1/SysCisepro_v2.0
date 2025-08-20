using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.Contabilidad.PlanDeCuentas;
using SysCisepro3.Properties;

using ClassLibraryCisepro3.UsuarioGeneral;
using SysCisepro3.Datos;
using SysCisepro3.TalentoHumano;
using ClosedXML.Excel;
using ClassLibraryCisepro3.Estaticas;
using System.Diagnostics;
using System.IO;

namespace SysCisepro3.Contabilidad
{
    public partial class FrmFlujoOperaciones : KryptonForm
    {
        public static TipoConexion TipoCon { private get; set; }
        public static ClassUsuarioGeneral Usuario { private get; set; }
        private readonly ClassPlanDeCuentas _objClassPlanDeCuentas;

        private static FrmFlujoOperaciones _instance;
        public static FrmFlujoOperaciones Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FrmFlujoOperaciones();
                return _instance;
            }
        }

        public FrmFlujoOperaciones(TipoConexion tipoCon, ClassUsuarioGeneral usuario)
        {
            InitializeComponent();        
            TipoCon = tipoCon;
            Usuario = usuario;
            _objClassPlanDeCuentas = new ClassPlanDeCuentas();
        }

        private FrmFlujoOperaciones()
        {
            InitializeComponent();
            _objClassPlanDeCuentas = new ClassPlanDeCuentas();
        }




        private void FrmFlujoOperaciones_Load(object sender, EventArgs e)
        {
            switch (TipoCon)
            {
                case TipoConexion.Seportpac:
                    Icon = Resources.logo_s;
                    break;
                case TipoConexion.Asenava:
                    Icon = Resources.logo_a;
                    break;
                default: // CISEPRO
                    Icon = Resources.logo_c;
                    break;
            }

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = new DateTime(dtpFechaDesde.Value.Year, dtpFechaDesde.Value.Month, dtpFechaDesde.Value.Day, 0, 0, 0);
            DateTime fechaHasta = new DateTime(dtpFechaHasta.Value.Year, dtpFechaHasta.Value.Month, dtpFechaHasta.Value.Day, 23, 59, 59);

            int anioAnterior = dtpFechaDesde.Value.Year - 1;

            DateTime fechaDesdeAntiguo = new DateTime(anioAnterior, 1, 1, 0, 0, 0);
            DateTime fechaHastaAntiguo = new DateTime(anioAnterior, 12, 31, 23, 59, 59);

            //limpiar dt y dgvFlujoOperaciones
            dgvFlujoOperaciones.DataSource = null;

            //llenar el dtActual
            DataTable dtActual = _objClassPlanDeCuentas.SeleccionarCuentasBalanceFinalYPerdidasGanacias(TipoCon, fechaDesde, fechaHasta);

            //lenar el dtAntiguo
            DataTable dtAntiguo = _objClassPlanDeCuentas.SeleccionarCuentasBalanceFinalYPerdidasGanacias(TipoCon, Convert.ToDateTime(fechaDesdeAntiguo), Convert.ToDateTime(fechaHastaAntiguo));

            ProcesarJerarquias(ref dtActual);
            ProcesarJerarquias(ref dtAntiguo);

            // Crear DataTable para variación
            DataTable dtVariacion = new DataTable();
            
            dtVariacion.Columns.Add("CUENTA", typeof(string));
            dtVariacion.Columns.Add("SALDO_ACTUAL", typeof(decimal));
            dtVariacion.Columns.Add("SALDO_ANTIGUO", typeof(decimal));
            dtVariacion.Columns.Add("VARIACION", typeof(decimal));
            dtVariacion.Columns.Add("NIVEL", typeof(int));
            dtVariacion.Columns.Add("PADRE", typeof(string));

            // Llenar dtVariacion con la diferencia entre saldos procesados
            foreach (DataRow rowActual in dtActual.Rows)
            {
                string codigo = rowActual["Cuenta"].ToString();
                DataRow[] rowsAntiguo = dtAntiguo.Select($"Cuenta = '{codigo}'");

                decimal saldoAntiguo = rowsAntiguo.Length > 0 ? Convert.ToDecimal(rowsAntiguo[0]["Saldo"]) : 0;
                decimal saldoActual = Convert.ToDecimal(rowActual["Saldo"]);
                decimal variacion = saldoActual - saldoAntiguo;

                DataRow newRow = dtVariacion.NewRow();
                
                newRow["CUENTA"] = rowActual["CUENTA"]; // Ajustar según columnas reales
                newRow["SALDO_ACTUAL"] = saldoActual;
                newRow["SALDO_ANTIGUO"] = saldoAntiguo;
                newRow["VARIACION"] = variacion;
                newRow["NIVEL"] = Convert.ToInt32(rowActual["Nivel"]);
                newRow["PADRE"] = rowActual["Padre"];
                dtVariacion.Rows.Add(newRow);
            }

            // Crear DataTable para el flujo de efectivo
            DataTable dtFlujo = new DataTable();
            dtFlujo.Columns.Add("Descripcion", typeof(string));
            dtFlujo.Columns.Add("Valor", typeof(decimal));

            DataRow row = dtFlujo.NewRow();
            DataRow row2 = dtFlujo.NewRow();
            DataRow row3 = dtFlujo.NewRow();
            DataRow row4 = dtFlujo.NewRow();
            DataRow row5 = dtFlujo.NewRow();
            DataRow row6 = dtFlujo.NewRow();
            DataRow row7 = dtFlujo.NewRow();
            DataRow row8 = dtFlujo.NewRow();
            DataRow row9 = dtFlujo.NewRow();
            DataRow row10 = dtFlujo.NewRow();
            DataRow row11 = dtFlujo.NewRow();
            DataRow row12 = dtFlujo.NewRow();

            // Agregar las filas según la estructura requerida
            dtFlujo.Rows.Add("FLUJOS DE OPERACIÓN");//0
            dtFlujo.Rows.Add(row);
            dtFlujo.Rows.Add("GANANCIA (PÉRDIDA) ANTES DE 15% A TRABAJADORES E IMPUESTO A LA RENTA");//1
            dtFlujo.Rows.Add(row2);//2
            dtFlujo.Rows.Add("AJUSTE POR PARTIDAS DISTINTAS AL EFECTIVO:");//3
            dtFlujo.Rows.Add("Ajustes por gasto de depreciación y amortización");//3
            dtFlujo.Rows.Add("Ajustes por Gastos Intereses (FLUJO FINANCIAMIENTO)");//4
            dtFlujo.Rows.Add("Ajustes por gastos por deterioro (reversiones por deterioro) reconocidas en los resultados del periodo");//5
            dtFlujo.Rows.Add("Pérdida (ganancia) de moneda extranjera no realizada");
            dtFlujo.Rows.Add("Pérdidas en cambio de moneda extranjera");
            dtFlujo.Rows.Add("Ajustes por gastos en provisiones");
            dtFlujo.Rows.Add("Ajuste por participaciones no controladoras");
            dtFlujo.Rows.Add("Ajuste por pagos basados en acciones");
            dtFlujo.Rows.Add("Ajustes por ganancias (pérdidas) en valor razonable");
            dtFlujo.Rows.Add("Ajustes por gasto por impuesto a la renta");
            dtFlujo.Rows.Add("Ajustes por gasto por participación trabajadores");
            dtFlujo.Rows.Add("Otros ajustes por partidas distintas al efectivo");
            dtFlujo.Rows.Add(row3);
            dtFlujo.Rows.Add("CAMBIOS EN ACTIVOS Y PASIVOS:");//16
            dtFlujo.Rows.Add("(Incremento) disminución en cuentas por cobrar clientes");//17
            dtFlujo.Rows.Add("(Incremento) disminución en otras cuentas por cobrar");//18
            dtFlujo.Rows.Add("(Incremento) disminución en anticipos de proveedores");//19
            dtFlujo.Rows.Add("(Incremento) disminución en inventarios");
            dtFlujo.Rows.Add("(Incremento) disminución en Act Biologico Corto Plazo");
            dtFlujo.Rows.Add("(Incremento) disminución en otros activos");
            dtFlujo.Rows.Add("Incremento (disminución) en cuentas por pagar comerciales");
            dtFlujo.Rows.Add("Incremento (disminución) en otras cuentas por pagar");
            dtFlujo.Rows.Add("Incremento (disminución) en beneficios empleados");
            dtFlujo.Rows.Add("Incremento (disminución) en anticipos de clientes");
            dtFlujo.Rows.Add("Incremento (disminución) en otros pasivos");
            dtFlujo.Rows.Add(row4);
            dtFlujo.Rows.Add("Flujos de efectivo netos procedentes de (utilizados en) actividades de operación");
            dtFlujo.Rows.Add(row5);
            dtFlujo.Rows.Add("FLUJOS DE INVERSION");
            dtFlujo.Rows.Add(row6);
            dtFlujo.Rows.Add("CAMBIOS EN ACTIVOS NO CORRIENTES");
            dtFlujo.Rows.Add("(Incremento) disminución en PROPIEDADES PLANTAS Y EQUIPOS");
            dtFlujo.Rows.Add("(Incremento) disminución en ACTIVOS BIOLOGICOS");
            dtFlujo.Rows.Add("(Incremento) disminución en ACTIVOS INVERSION");
            dtFlujo.Rows.Add("(Incremento) disminución en otros activos");
            dtFlujo.Rows.Add(row7);
            dtFlujo.Rows.Add("Flujos de efectivo netos procedentes de (utilizados en) actividades de INVERSION");
            dtFlujo.Rows.Add(row8);
            dtFlujo.Rows.Add("FLUJOS DE FINANCIAMIENTO");
            dtFlujo.Rows.Add(row9);
            dtFlujo.Rows.Add("CAMBIOS EN PASIVOS NO CORRIENTES Y PATRIMONIO :");
            dtFlujo.Rows.Add("(Incremento) disminución en CAPITAL SOCIAL");
            dtFlujo.Rows.Add("(Incremento) disminución en PARTICIPACION FUTURAS CAPITALIZACIONES");
            dtFlujo.Rows.Add("(Incremento) disminución en UTILIDADES ACUMULADAS");
            dtFlujo.Rows.Add("(Incremento) disminución en otros PATRIMONIO");
            dtFlujo.Rows.Add("(Incremento) disminución en otros PRESTAMOS A LARGO PLAZO");
            dtFlujo.Rows.Add("(Incremento) disminución en otros CTAS POR PAGAR ACCIONISTAS NO CORRIENTES");
            dtFlujo.Rows.Add("(Incremento) disminución en otros PASIVOS NO CORRIENTES");
            dtFlujo.Rows.Add(row10);
            dtFlujo.Rows.Add("Flujos de efectivo netos procedentes de (utilizados en) actividades de FINANCIAMIENTO");
            dtFlujo.Rows.Add(row11);
            dtFlujo.Rows.Add("EFECTOS DE LA VARIACION SOBRE EL EFECTIVO Y EQUIVALENTES AL DE EFECTIVO");
            dtFlujo.Rows.Add("Efectos de la variación en la tasa de cambio sobre el efectivo y equivalentes al efectivo");
            dtFlujo.Rows.Add("INCREMENTO (DISMINUCIÓN) NETO DE EFECTIVO Y EQUIVALENTES AL EFECTIVO");
            dtFlujo.Rows.Add("EFECTIVO Y EQUIVALENTES AL EFECTIVO AL PRINCIPIO DEL PERIODO");
            dtFlujo.Rows.Add("EFECTIVO Y EQUIVALENTES AL EFECTIVO AL FINAL DEL PERIODO");
            
            
            //BLOQUE 1
            // Ganancia(Perdida) antes de 15% a trabajadores
            string Activo = "1";
            decimal ActivoActual= ObtenerValorCuentaResultados(dtActual, Activo);
            decimal ActivoAnterior = ObtenerValorCuentaResultados(dtAntiguo, Activo);
            
            string Pasivo = "2";
            decimal PasivoActual = ObtenerValorCuentaResultados(dtActual, Pasivo);
            decimal PasivoAnterior = ObtenerValorCuentaResultados(dtAntiguo, Pasivo);

            string Patrimonio = "3";
            decimal PatrimonioActual = ObtenerValorCuentaResultados(dtActual, Patrimonio);
            decimal PatrimonioAnterior = ObtenerValorCuentaResultados(dtAntiguo, Patrimonio);

            decimal utilidadActual = ActivoActual + PasivoActual + PatrimonioActual ;
            decimal utilidadAnterior = ActivoAnterior + PasivoAnterior + PatrimonioAnterior;

            decimal variacionUtilidad = utilidadActual - utilidadAnterior;
            
            

            dtFlujo.Rows[2]["Valor"] = variacionUtilidad;
            
            
            //Ajuste por gasto depreciacion

            string Depreciaciones = "520219";
            decimal Ajuste1 = ObtenerValorCuentaResultados(dtActual, Depreciaciones);
            
                        
            dtFlujo.Rows[5]["Valor"] = Ajuste1 ;
            
            //total bloque1
            decimal bloque1 = Ajuste1;
            //total sumado bloque 1
            dtFlujo.Rows[4]["Valor"] = bloque1;

            //BLOQUE 2
            

            //dismunicion en cuentas por cobrar clientes
            string CuentasPorCobrar = "1010205";

            decimal activo1 = ObtenerValorCuentaVariacion(dtVariacion, CuentasPorCobrar);
            dtFlujo.Rows[19]["Valor"] = activo1;

            //dismunicion en cuentas otras cuentas por cobrar 
            string CuentasPorCobrar2 = "1010208";
            
            decimal activo2 = ObtenerValorCuentaVariacion(dtVariacion, CuentasPorCobrar2);
            dtFlujo.Rows[20]["Valor"] = activo2;

            //dismunicion en anticipos de proveedores

            string AnticiposProveedores = "1010403";
            
            decimal activo3 = ObtenerValorCuentaVariacion(dtVariacion, AnticiposProveedores);
            dtFlujo.Rows[21]["Valor"] = activo3;
           
            //disminucion en otros activos

            string SegurosPagados = "1010401";
            
            decimal ao1 = ObtenerValorCuentaVariacion(dtVariacion, SegurosPagados);

            string AnticiposEmpleados = "1010404";
            
            decimal ao2 = ObtenerValorCuentaVariacion(dtVariacion, AnticiposEmpleados);

            string ActivosImpuestosCorrientes = "10105";
            
            decimal ao3 = ObtenerValorCuentaVariacion(dtVariacion, ActivosImpuestosCorrientes);

            decimal otrosActivos = (ao1 + ao2 + ao3);
            
            dtFlujo.Rows[24]["Valor"] = otrosActivos;

            //dismunicion en cuentas por pagar comerciales
            string CuentasPorPagar = "20103";
            
            decimal pasivo1 = ObtenerValorCuentaVariacion(dtVariacion, CuentasPorPagar);
            dtFlujo.Rows[25]["Valor"] = pasivo1;

            //dismunicion en cuentas por otras cuentas pagar 
            string CuentasPorPagar2 = "2010701";
            
            decimal pasivo2 = ObtenerValorCuentaVariacion(dtVariacion, CuentasPorPagar2);
            dtFlujo.Rows[26]["Valor"] = pasivo2;

            //dismunicion en benefecios a empleados
            string iess = "2010703";
            
            decimal be = ObtenerValorCuentaVariacion(dtVariacion, iess);
            
            string beneficiosxley = "2010704";

            decimal be2 = ObtenerValorCuentaVariacion(dtVariacion, beneficiosxley);

            string participacionTrabajadores = "2010705";

            decimal be3 = ObtenerValorCuentaVariacion(dtVariacion, participacionTrabajadores);
            
            string sueldos = "2010707";

            decimal be4 = ObtenerValorCuentaVariacion(dtVariacion, sueldos);

            string utilidadesporpagar = "2010709001";

            decimal be5 = ObtenerValorCuentaVariacion(dtVariacion, utilidadesporpagar);

            decimal totalBeneficios = be + be2 + be3 + be4 + be5;
            
            dtFlujo.Rows[27]["Valor"] = totalBeneficios;

            //dismunicion en anticipos a clientes

            string AnticiposClientes = "20113";

            decimal pasivo3 = ObtenerValorCuentaVariacion(dtVariacion, AnticiposClientes);
            dtFlujo.Rows[28]["Valor"] = pasivo3;

            //disminucion en otros pasivos

            string ObligacionesFinancieras = "20104";
                                   
            decimal op1 = ObtenerValorCuentaVariacion(dtVariacion, ObligacionesFinancieras);

            string DividendosPorPagar = "2010706";
            
            decimal op2 = ObtenerValorCuentaVariacion(dtVariacion, DividendosPorPagar);

            string PasivoPorDerechoArriendo = "2010901";
            
            decimal op3 = ObtenerValorCuentaVariacion(dtVariacion, PasivoPorDerechoArriendo);

            decimal otrosPasivos = (op1 + op2 + op3);

            dtFlujo.Rows[29]["Valor"] = otrosPasivos;

            //total sumado bloque 2

            decimal bloque2 = activo1 + activo2 + activo3  + otrosActivos + pasivo1 + pasivo2 + pasivo3  + totalBeneficios  + otrosPasivos;

            dtFlujo.Rows[18]["Valor"] = bloque2;

            //flujos de efectivos netos procendetes de actividades de operaciones

            dtFlujo.Rows[31]["valor"]=  variacionUtilidad + bloque1 - bloque2;

            //bloque3

            // (Incremento) disminución en PROPIEDADES PLANTAS Y EQUIPOS

            string mueblesYEnseres = "1020105";

            decimal muebles = ObtenerValorCuentaVariacion(dtVariacion, mueblesYEnseres);
            
            string equiposComputacion = "1020108";
            
            decimal equipos = ObtenerValorCuentaVariacion(dtVariacion, equiposComputacion);

            string vehiuclosEqupos = "1020109";
            
            decimal vehiculos = ObtenerValorCuentaVariacion(dtVariacion, vehiuclosEqupos);

            string otrosMuebles = "1020110";

            decimal otros = ObtenerValorCuentaVariacion(dtVariacion, otrosMuebles);

            decimal propiedades = muebles + equipos + vehiculos + otros;
                        
            dtFlujo.Rows[36]["Valor"] = propiedades;

            decimal bloque3 = propiedades;

            //  Flujos de efectivo netos procedentes de (utilizados en) actividades de INVERSION

            dtFlujo.Rows[41]["valor"] = bloque3;


            //bloque 4

            //(Incremento)disminución en otros PRESTAMOS A LARGO PLAZO

            string ObligacionesFiancieras = "20203";

            decimal Obligaciones = ObtenerValorCuentaVariacion(dtVariacion, ObligacionesFiancieras);

            dtFlujo.Rows[50]["Valor"] = Obligaciones;

            //(Incremento) disminución en otros PASIVOS NO CORRIENTES

            string ProvisionesBenficicios = "20207";

            decimal Provisiones = ObtenerValorCuentaVariacion(dtVariacion, ProvisionesBenficicios);

            dtFlujo.Rows[52]["Valor"] = Provisiones;

            decimal bloque4 =  Obligaciones + Provisiones;
            
            //Flujos de efectivo netos procedentes de (utilizados en) actividades de FINANCIAMIENTO

            dtFlujo.Rows[54]["valor"] = bloque4;

            //bloque 5

            // INCREMENTO (DISMINUCIÓN) NETO DE EFECTIVO Y EQUIVALENTES AL EFECTIVO

            dtFlujo.Rows[58]["valor"] = (variacionUtilidad + bloque1 - bloque2) + bloque3 + bloque4;

            //EFECTIVO Y EQUIVALENTES AL EFECTIVO AL PRINCIPIO DEL PERIODO
            string EfectivoEquivalente = "10101";
            decimal EFectivoAntiguo = ObtenerValorCuentaResultados(dtAntiguo, EfectivoEquivalente);

            dtFlujo.Rows[59]["valor"] = EFectivoAntiguo;


            //EFECTIVO Y EQUIVALENTES AL EFECTIVO AL FINAL DEL PERIODO

            dtFlujo.Rows[60]["valor"] = variacionUtilidad + bloque1 - bloque2 + bloque3 + bloque4 + EFectivoAntiguo;



            // Asignar al DataGridView
            dgvFlujoOperaciones.DataSource = dtFlujo;
            dgvFlujoOperaciones.Columns["Valor"].DefaultCellStyle.Format = "#,##0.00";
            dgvFlujoOperaciones.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFlujoOperaciones.Rows[0].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(30, 57, 91);
            dgvFlujoOperaciones.Rows[0].DefaultCellStyle.ForeColor = Color.White;

            dgvFlujoOperaciones.Rows[2].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[2].DefaultCellStyle.BackColor = Color.FromArgb(30, 57, 91);
            dgvFlujoOperaciones.Rows[2].DefaultCellStyle.ForeColor = Color.White;

            dgvFlujoOperaciones.Rows[4].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[4].DefaultCellStyle.BackColor = Color.FromArgb(30, 57, 91);
            dgvFlujoOperaciones.Rows[4].DefaultCellStyle.ForeColor = Color.White;


            dgvFlujoOperaciones.Rows[18].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[18].DefaultCellStyle.BackColor = Color.FromArgb(30, 57, 91);
            dgvFlujoOperaciones.Rows[18].DefaultCellStyle.ForeColor = Color.White;

            dgvFlujoOperaciones.Rows[31].DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[31].DefaultCellStyle.ForeColor = Color.FromArgb(30, 57, 91);

            dgvFlujoOperaciones.Rows[33].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[33].DefaultCellStyle.BackColor = Color.FromArgb(30, 57, 91);
            dgvFlujoOperaciones.Rows[33].DefaultCellStyle.ForeColor = Color.White;

            dgvFlujoOperaciones.Rows[35].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[35].DefaultCellStyle.BackColor = Color.FromArgb(30, 57, 91);
            dgvFlujoOperaciones.Rows[35].DefaultCellStyle.ForeColor = Color.White;

            dgvFlujoOperaciones.Rows[41].DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[41].DefaultCellStyle.ForeColor = Color.FromArgb(30, 57, 91);

            dgvFlujoOperaciones.Rows[43].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[43].DefaultCellStyle.BackColor = Color.FromArgb(30, 57, 91);
            dgvFlujoOperaciones.Rows[43].DefaultCellStyle.ForeColor = Color.White;

            dgvFlujoOperaciones.Rows[45].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[45].DefaultCellStyle.BackColor = Color.FromArgb(30, 57, 91);
            dgvFlujoOperaciones.Rows[45].DefaultCellStyle.ForeColor = Color.White;

            dgvFlujoOperaciones.Rows[54].DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[54].DefaultCellStyle.ForeColor = Color.FromArgb(30, 57, 91);

            dgvFlujoOperaciones.Rows[56].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[56].DefaultCellStyle.BackColor = Color.FromArgb(30, 57, 91);
            dgvFlujoOperaciones.Rows[56].DefaultCellStyle.ForeColor = Color.White;



            dgvFlujoOperaciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);



        }

        // Función para obtener valores de cuentas de resultados
        private decimal ObtenerValorCuentaResultados(DataTable dt, string codigoCuenta)
        {
            DataRow[] rows = dt.Select($"Cuenta = '{codigoCuenta}'");
            if (rows.Length > 0)
                return Convert.ToDecimal(rows[0]["Saldo"]);
            return 0;
        }

        // Función para obtener valores de cuentas de resultados
        private decimal ObtenerValorCuentaVariacion(DataTable dt, string codigoCuenta)
        {
            DataRow[] rows = dt.Select($"Cuenta = '{codigoCuenta}'");
            if (rows.Length > 0)
                return Convert.ToDecimal(rows[0]["VARIACION"]);
            return 0;
        }



        // Función para procesar jerarquías (sumar nodos hijos a padres)
        private void ProcesarJerarquias(ref DataTable dt)
        {
            // Agregar saldos de hijos a padres (de nivel 7 a 1)
            for (int i = 7; i >= 1; i--)
            {
                DataView view = new DataView(dt, $"Nivel = {i}", "", DataViewRowState.CurrentRows);
                foreach (DataRowView rowView in view)
                {
                    string padre = rowView["Padre"].ToString();
                    if (!string.IsNullOrEmpty(padre))
                    {
                        DataRow[] rowsPadre = dt.Select($"Cuenta = '{padre}'");

                        if (rowsPadre.Length > 0)
                        {
                            decimal saldoHijo = Convert.ToDecimal(rowView["Saldo"]);
                            decimal saldoPadre = Convert.ToDecimal(rowsPadre[0]["Saldo"]);
                            rowsPadre[0]["Saldo"] = saldoPadre + saldoHijo;
                        }
                    }
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ExportToExcelDgv(dgvFlujoOperaciones, "FlujoOperaciones");

        }


        private void ExportToExcelDgv(DataGridView dgv, string nombreArchivo)
        {

            try
            {

                if (dgv == null || dgv.Rows.Count == 0)
                {
                    KryptonMessageBox.Show("No hay datos para exportar.", "Aviso", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                    return;
                }

                var fec = DateTime.Now;
                var sfd = new SaveFileDialog
                {
                    Filter = @"Excel Files(.xlsx)|*.xlsx",
                    Title = @"EXPORTAR A EXCEL",
                    FileName = $"{nombreArchivo}_{fec.Year}{fec.Month}{fec.Day}_{fec.Hour}{fec.Minute}.xlsx"
                };

                if (sfd.ShowDialog() != DialogResult.OK) return;

                // Usamos ClosedXML para crear un archivo Excel
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("FLUJO_OPERACIONES");

                // Contar columnas visibles
                int l = -1;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible) l++;
                }
                string ic = ValidationForms.NumToCharExcel(l);

                // Número de filas
                int rc = dgv.RowCount + 20;

                // Establecer tamaño de fuente
                worksheet.Range("A1:" + ic + rc).Style.Font.SetFontSize(10);

                // Título
                worksheet.Range("A1:" + ic + "1").Merge().Value = Validaciones.NombreCompany(TipoCon) + " - Flujo de Efectivo";
                worksheet.Range("A1:" + ic + "1").Style.Font.SetBold(true).Font.SetFontSize(12);
                worksheet.Range("A1:" + ic + "1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                worksheet.Range("A1:" + ic + "1").Style.Fill.SetBackgroundColor(XLColor.FromColor(ValidationForms.GetColorSistema(TipoCon)));
                worksheet.Range("A1:" + ic + "1").Style.Font.SetFontColor(XLColor.White);

                // Fecha de impresión
                worksheet.Range("A3:" + ic + "3").Merge().Value = "Desde el " + dtpFechaDesde.Value.ToShortDateString() + " AL " + dtpFechaHasta.Value.ToShortDateString() + "                Fecha de Impresión: " + Usuario.Now(TipoCon);
                worksheet.Range("A3:" + ic + "3").Style.Font.SetFontSize(12);

                // Encabezados de las columnas
                int head = 5;
                int x = 1;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (!dgv.Columns[i].Visible) continue;
                    worksheet.Cell(head, x).Value = dgv.Columns[i].HeaderText;
                    worksheet.Cell(head, x).Style.Font.SetBold(true);
                    worksheet.Cell(head, x).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                    worksheet.Cell(head, x).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    worksheet.Cell(head, x).Style.Fill.SetBackgroundColor(XLColor.FromColor(ValidationForms.GetColorSistema(TipoCon)));
                    worksheet.Cell(head, x).Style.Font.SetFontColor(XLColor.White);
                    x++;
                }

                // Datos de las filas
                head++;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    int y = 1;
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (!dgv.Columns[j].Visible) continue;
                        var cellValue = row.Cells[j].Value;
                        var headerText = dgv.Columns[j].HeaderText.ToUpper();

                        if (headerText == "Descripcion" )
                        {
                            worksheet.Cell(head, y).Value = cellValue?.ToString() ?? string.Empty;
                        }
                        else
                        {
                            if (IsNumeric(cellValue))
                            {
                                worksheet.Cell(head, y).Value = Convert.ToDouble(cellValue);
                                worksheet.Cell(head, y).Style.NumberFormat.Format = "#,##0.00";
                            }
                            else
                            {
                                worksheet.Cell(head, y).Value = cellValue?.ToString() ?? string.Empty;
                            }
                        }



                        worksheet.Cell(head, y).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                        y++;
                    }
                    head++;
                }

                
                // Logo en la celda correspondiente
                var newlogo = Validaciones.NombreLogo(TipoCon, System.Windows.Forms.Application.StartupPath);

                using (var logoImage = Image.FromFile(newlogo))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        logoImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        ms.Position = 0;

                        worksheet.AddPicture(ms)
                            .MoveTo(worksheet.Cell(2, 7))
                            .WithSize(70, 70);
                    }
                }

                // Ajustar el ancho de las columnas
                worksheet.Columns().AdjustToContents();



                // Guardar el archivo en la ruta seleccionada por el usuario
                workbook.SaveAs(sfd.FileName);

                // Abrimos el archivo
                Process.Start(sfd.FileName);

                KryptonMessageBox.Show(@"ARCHIVO generado correctamente!", "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("HUBO UN PROBLEMA AL EXPORTAR DATOS!" + Environment.NewLine + ex.Message, "Mensaje del Sistema", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }

        }

        private bool IsNumeric(object value)
        {
            if (value == null) return false;
            return double.TryParse(value.ToString(), out _);
        }
    }
}
