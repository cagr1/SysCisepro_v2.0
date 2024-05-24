using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassCuentaPersonal
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdPersonal { get; set; }
        public int IdBanco { get; set; }
        public string NumCuenta { get; set; }
        public string Tipo { get; set; }

        public DataTable SeleccionarCuenta(TipoConexion tipoCon, string id)
        {
            var pars = new List<object[]>
            {
                new object[] {"id_personal", SqlDbType.Int, id}
            };
            return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon,
                    "select * from cuentas_personal where id_personal=@id_personal;", false, pars) ;
        }

        public SqlCommand RegistrarNuevoCuentaBancoPersonalCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "delete from cuentas_personal where id_personal=@id_personal; insert into cuentas_personal values (@id_personal, @id_banco, @num_cuenta, @tipo);"
            };
            cmd.Parameters.AddWithValue("@id_personal", SqlDbType.Int).Value = IdPersonal;
            cmd.Parameters.AddWithValue("@id_banco", SqlDbType.Int).Value = IdBanco;
            cmd.Parameters.AddWithValue("@num_cuenta", SqlDbType.VarChar).Value = NumCuenta;
            cmd.Parameters.AddWithValue("@tipo", SqlDbType.VarChar).Value = Tipo;
            return cmd;
        } 
    }
}
