using System.Collections.Generic;
using System.Data;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using System.Linq;

namespace ClassLibraryCisepro3.EstructuraEmpresa
{
    public class ClassBancos
    {
        public DataTable SeleccionarRegistrosBancosCuentasPersonal(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select b.id_banco, b.banco from cuentas_personal c join banco_roles b on c.id_banco=b.id_banco group by  b.id_banco, b.banco;", false);
        }

        public DataTable SeleccionarRegistrosBancosCuentasPersonalFull(TipoConexion tipoCon,string filban, string filtro)
        {
            var pars = new List<object[]>
            {
                new object[] { "FILBAN", SqlDbType.NVarChar, filban } ,
                new object[] { "FILTRO", SqlDbType.NVarChar, filtro } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_seleccionarRegistrosBancosCuentasPersonal", true, pars);
        }

        public DataTable SeleccionarRegistroBancoPorIdPersonal(TipoConexion tipoCon, int idp)
        {
            var pars = new List<object[]>
            {
                new object[] { "IDP", SqlDbType.Int, idp } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from cuentas_personal c join banco_roles b on c.id_banco = b.id_banco where c.id_personal = @IDP and b.id_banco<>0;", false, pars);
        }

        public DataTable SeleccionarRegistroBancoPorNumCuenta(TipoConexion tipoCon, string cta)
        {
            var pars = new List<object[]>
            {
                new object[] { "CTA", SqlDbType.VarChar, cta } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select c.*, b.*, g.apellidos, g.nombres from cuentas_personal c join personal g on c.id_personal=g.id_personal join banco_roles b on c.id_banco = b.id_banco where c.num_cuenta = @CTA;", false, pars);
        }

        public DataTable SeleccionarRegistrosBancos(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosBancos", true);
        }

        public DataTable SeleccionarRegistrosBancosRoles(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select * from banco_roles", false);
        }

        public Dictionary<string, string> SeleccionarRegistrosBancosRolesDict(TipoConexion tipoCon)
        {
            var dict = new Dictionary<string, string>();
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select id_banco, cod from banco_roles", false);
            foreach (DataRow row in data.Rows) dict.Add(row[0].ToString(), row[1].ToString());
            return dict;
        }
    }
}
