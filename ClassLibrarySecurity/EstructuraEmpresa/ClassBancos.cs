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
                new object[] { "FILBAN", SqlDbType.VarChar, filban } ,
                new object[] { "FILTRO", SqlDbType.VarChar, filtro } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select pe.id_personal, pe.cedula, pe.apellidos + ' ' + pe.nombres nombres, cg.descripcion, ar.nombre_area, cp.id_banco, ba.banco, cp.num_cuenta, cp.tipo from cuentas_personal cp join banco_roles ba on cp.id_banco=ba.id_banco join personal pe on cp.id_personal = pe.id_personal join cargo_ocupacional cg on pe.id_cargo_ocupacional = cg.id_cargo_ocupacional join area_general ar on pe.id_area = ar.id_area_general where pe.estado_personal = 1 and ba.banco like ('%'+@FILBAN+'%') and (pe.cedula like ('%'+@FILTRO+'%') or pe.apellidos like ('%'+@FILTRO+'%') or pe.nombres like ('%'+@FILTRO+'%') or  cp.num_cuenta like ('%'+@FILTRO+'%')) order by ba.id_banco desc, pe.apellidos, pe.nombres;", false, pars);
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
