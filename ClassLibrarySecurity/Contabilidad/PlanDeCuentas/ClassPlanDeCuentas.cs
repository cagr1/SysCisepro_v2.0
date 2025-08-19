using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.Contabilidad.PlanDeCuentas
{
    public class ClassPlanDeCuentas
    {
        public DataTable SeleccionarPlanCuentas(TipoConexion tipoCon, bool todo, int tipo, string fil)
        {
            var sql = todo ? "SELECT id_plan, codigo, detalle, nivel, padre_cuenta, movimiento, tipo_cuenta, dbo.TipoCuenta(TIPO_CUENTA) tipo FROM PLAN_CUENTAS_GENERAL WHERE ESTADO = 1 AND (CODIGO LIKE '%" + fil + "%' OR DETALLE LIKE '%" + fil + "%') order by CODIGO;" :
                "SELECT id_plan, codigo, detalle, nivel, padre_cuenta, movimiento, tipo_cuenta, dbo.TipoCuenta(TIPO_CUENTA) tipo FROM PLAN_CUENTAS_GENERAL WHERE TIPO_CUENTA = " + tipo + " AND ESTADO = 1 AND (CODIGO LIKE '%" + fil + "%' OR DETALLE LIKE '%" + fil + "%') order by CODIGO;";
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, false);
        }

        public DataTable SeleccionarCuentasYDetallePlanDeCuentas(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarCuentasYDetallePlanDeCuentas", false);
        }

        public AutoCompleteStringCollection Autocompletar(TipoConexion tipoCon)
        {
            var d = SeleccionarCuentasYDetallePlanDeCuentas(tipoCon);
            var c = new AutoCompleteStringCollection();
            foreach (DataRow row in d.Rows) c.Add(row[0].ToString());
            return c;
        }

        public DataTable SeleccionarCuentasBalanceFinalYPerdidasGanacias(TipoConexion tipoCon, DateTime desde, DateTime hasta)
        {
            var pars = new List<object[]>
            {
                new object[] { "@fecha_inicial", SqlDbType.DateTime, desde }
                , new object[] { "@fecha_final", SqlDbType.DateTime, hasta }
        
            };

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_SeleccionarCuentasBalanceFinalYPerdidasGanacias", true, pars);
        }

        





    }
}
