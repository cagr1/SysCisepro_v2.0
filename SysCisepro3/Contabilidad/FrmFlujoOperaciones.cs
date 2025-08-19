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

            // Agregar las filas según la estructura requerida
            dtFlujo.Rows.Add("FLUJOS DE OPERACIÓN");//0
            dtFlujo.Rows.Add("GANANCIA (PÉRDIDA) ANTES DE 15% A TRABAJADORES E IMPUESTO A LA RENTA");//1
            dtFlujo.Rows.Add(" ");//2
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
            dtFlujo.Rows.Add("");
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
            dtFlujo.Rows.Add("Incremento (disminución) en otros pasivos");//
            dtFlujo.Rows.Add("Flujos de efectivo netos procedentes de (utilizados en) actividades de operación");
            dtFlujo.Rows.Add("FLUJOS DE INVERSION");
            dtFlujo.Rows.Add("CAMBIOS EN ACTIVOS NO CORRIENTES");
            dtFlujo.Rows.Add("(Incremento) disminución en PROPIEDADES PLANTAS Y EQUIPOS");
            dtFlujo.Rows.Add("(Incremento) disminución en ACTIVOS BIOLOGICOS");
            dtFlujo.Rows.Add("(Incremento) disminución en ACTIVOS INVERSION");
            dtFlujo.Rows.Add("(Incremento) disminución en otros activos");
            dtFlujo.Rows.Add(" ");
            dtFlujo.Rows.Add("Flujos de efectivo netos procedentes de (utilizados en) actividades de INVERSION");
            dtFlujo.Rows.Add(" ");
            dtFlujo.Rows.Add("FLUJOS DE FINANCIAMIENTO");
            dtFlujo.Rows.Add("CAMBIOS EN PASIVOS NO CORRIENTES Y PATRIMONIO :");
            dtFlujo.Rows.Add("(Incremento) disminución en CAPITAL SOCIAL");
            dtFlujo.Rows.Add("(Incremento) disminución en PARTICIPACION FUTURAS CAPITALIZACIONES");
            dtFlujo.Rows.Add("(Incremento) disminución en UTILIDADES ACUMULADAS");
            dtFlujo.Rows.Add("(Incremento) disminución en otros PATRIMONIO");
            dtFlujo.Rows.Add("(Incremento) disminución en otros PRESTAMOS A LARGO PLAZO");
            dtFlujo.Rows.Add("(Incremento) disminución en otros CTAS POR PAGAR ACCIONISTAS NO CORRIENTES");
            dtFlujo.Rows.Add("(Incremento) disminución en otros PASIVOS NO CORRIENTES");
            dtFlujo.Rows.Add("Flujos de efectivo netos procedentes de (utilizados en) actividades de FINANCIAMIENTO");
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
            //NumberFormat.Format = "#,##0.00" variacion de utilidad 
            

            dtFlujo.Rows[2]["Valor"] = variacionUtilidad;
            
            
            //Ajuste por gasto depreciacion

            string Depreciaciones = "520219";
            decimal Ajuste1 = ObtenerValorCuentaResultados(dtActual, Depreciaciones);
            
                        
            dtFlujo.Rows[4]["Valor"] = Ajuste1 ;
            
            //total bloque1
            decimal bloque1 = Ajuste1;
            //total sumado bloque 1
            dtFlujo.Rows[3]["Valor"] = bloque1;

            //BLOQUE 2
            

            //dismunicion en cuentas por cobrar clientes
            string CuentasPorCobrar = "1010205";

            decimal cambios1 = ObtenerValorCuentaVariacion(dtVariacion, CuentasPorCobrar);
            dtFlujo.Rows[18]["Valor"] = cambios1;

            //dismunicion en cuentas otras cuentas por cobrar 
            string CuentasPorCobrar2 = "1010208";
            
            decimal cambios2 = ObtenerValorCuentaVariacion(dtVariacion, CuentasPorCobrar2);
            dtFlujo.Rows[19]["Valor"] = cambios2;

            //dismunicion en anticipos de proveedores

            string AnticiposProveedores = "1010403";
            
            decimal cambios3 = ObtenerValorCuentaVariacion(dtVariacion, AnticiposProveedores);
            dtFlujo.Rows[20]["Valor"] = cambios3;
           
            //disminucion en otros activos

            string SegurosPagados = "1010401";
            
            decimal ao1 = ObtenerValorCuentaVariacion(dtVariacion, SegurosPagados);

            string AnticiposEmpleados = "1010404";
            
            decimal ao2 = ObtenerValorCuentaVariacion(dtVariacion, AnticiposEmpleados);

            string ActivosImpuestosCorrientes = "10105";
            
            decimal ao3 = ObtenerValorCuentaVariacion(dtVariacion, ActivosImpuestosCorrientes);
            
            dtFlujo.Rows[21]["Valor"] = ao1 + ao2 + ao3;

            //dismunicion en cuentas por pagar comerciales
            string CuentasPorPagar = "20103";
            
            decimal cambios4 = ObtenerValorCuentaVariacion(dtVariacion, CuentasPorPagar);
            dtFlujo.Rows[24]["Valor"] = cambios4;

            //dismunicion en cuentas por otras cuentas pagar 
            string CuentasPorPagar2 = "2010701";
            
            decimal cambios5 = ObtenerValorCuentaVariacion(dtVariacion, CuentasPorPagar2);
            dtFlujo.Rows[25]["Valor"] = cambios5;

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
            
            dtFlujo.Rows[26]["Valor"] = be + be2 + be3 + be4 + be5;

            //dismunicion en anticipos a clientes

            string AnticiposClientes = "20113";

            decimal cambios6 = ObtenerValorCuentaVariacion(dtVariacion, AnticiposClientes);
            dtFlujo.Rows[27]["Valor"] = cambios6;

            //disminucion en otros pasivos

            string ObligacionesFinancieras = "20104";
                                   
            decimal op1 = ObtenerValorCuentaVariacion(dtVariacion, ObligacionesFinancieras);

            string DividendosPorPagar = "2010706";
            
            decimal op2 = ObtenerValorCuentaVariacion(dtVariacion, DividendosPorPagar);

            string PasivoPorDerechoArriendo = "2010901";
            
            decimal op3 = ObtenerValorCuentaVariacion(dtVariacion, PasivoPorDerechoArriendo);

            dtFlujo.Rows[28]["Valor"] = op1 + op2 + op3;

            //total sumado bloque 2

            decimal bloque2 = ao1 + ao2 + ao3 + be + be2 + be3 + be4 + be5 + op1 + op2 + op3 + cambios1 + cambios2 + cambios3 + cambios4 + cambios5 + cambios6;

            dtFlujo.Rows[17]["Valor"] = bloque2;

            //flujos de efectivos netos

            dtFlujo.Rows[30]["valor"]= 

            // Asignar al DataGridView
            dgvFlujoOperaciones.DataSource = dtFlujo;
            dgvFlujoOperaciones.Columns["Valor"].DefaultCellStyle.Format = "#,##0.00";
            dgvFlujoOperaciones.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFlujoOperaciones.Rows[0].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[0].DefaultCellStyle.BackColor = Color.FromArgb(30, 57, 91);
            dgvFlujoOperaciones.Rows[0].DefaultCellStyle.ForeColor = Color.White;

            dgvFlujoOperaciones.Rows[1].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[1].DefaultCellStyle.BackColor = Color.FromArgb(30, 57, 91);
            dgvFlujoOperaciones.Rows[1].DefaultCellStyle.ForeColor = Color.White;
            

            dgvFlujoOperaciones.Rows[16].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvFlujoOperaciones.Rows[16].DefaultCellStyle.BackColor = Color.FromArgb(30, 57, 91);
            dgvFlujoOperaciones.Rows[16].DefaultCellStyle.ForeColor = Color.White;
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


    }
}
