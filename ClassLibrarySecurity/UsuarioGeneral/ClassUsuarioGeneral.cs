using System;
using System.Collections.Generic;
using System.Data;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.UsuarioGeneral
{
    public class ClassUsuarioGeneral
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdArea { get; set; }
        public string Datos { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string TipoUsuario { get; set; }
        public int Estado { get; set; }
        public string IdPersonal { get; set; }
        public int IdRol { get; set; }
        public string RutaAts { get; set; }
        public string RutaDocsElec { get; set; }
        public string RutaFirmElec { get; set; }

        public void SalirSistema(TipoConexion tipoCon)
        {
            ComandosSql.Salir(tipoCon);
        }
         
        public DataTable SeleccionarUsuariosGeneral(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT ID_USUARIO, DATOS, LOGIN = CONVERT(NVARCHAR(MAX), DECRYPTBYPASSPHRASE('LOGIN',LOGIN)), PASSWORD = CONVERT(NVARCHAR(MAX), DECRYPTBYPASSPHRASE('PASSWORD',PASSWORD)), TIPO_USUARIO, ID_PERSONAL FROM USUARIO_GENERAL WHERE ESTADO = 1 ORDER BY LOGIN;", false);
        }

        public DataTable GetDatosEmpresa(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT * FROM EMPRESA_GENERAL", false);
        }

        public string ObtenerNombrePersonalXIdUser(TipoConexion tipoCon, string idu)
        {
            if (string.IsNullOrEmpty(idu.Trim())) return Datos;
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select apellidos+ ' ' + nombres nombre from personal where id_personal = " + idu, false) ;
            return data.Rows.Count == 0 ? Datos : data.Rows[0]["nombre"].ToString();
        }

        public string ObtenerRutasDocsEltectronicos(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select * from RUTA_DOC_ELECTRONICO;", false);
            return data.Rows.Count == 0 ? string.Empty : data.Rows[0]["ruta_direccion"] + "~" + data.Rows[1]["ruta_direccion"] + "~" + data.Rows[2]["ruta_direccion"];
        }

        public DateTime Now(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon,"select getDate() fecha;", false);
            return data.Rows.Count == 0 ? DateTime.MinValue : Convert.ToDateTime(data.Rows[0]["fecha"]);
        }
        public DateTime ObtenerFechaSola(TipoConexion tipoCon)
        {
            var data = Now(tipoCon);
            return new DateTime(data.Year, data.Month, data.Day, 0, 0, 0);
        }

        public ClassUsuarioGeneral BuscarUsuarioPorLogin(TipoConexion tipoCon, string login, string pwd)
        {
            var pars = new List<object[]>
            {
                new object[] { "LOGIN", SqlDbType.VarChar, login },
                new object[] { "PASSWORD", SqlDbType.VarChar, pwd }
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarUsuarioxLoginYPassword", true, pars) ;
            if (data.Rows.Count == 0) return null;
            return new ClassUsuarioGeneral
            {
                IdUsuario = Convert.ToInt32(data.Rows[0]["ID_USUARIO"]),
                IdEmpresa = Convert.ToInt32(data.Rows[0]["ID_EMPRESA"]),
                IdSucursal = Convert.ToInt32(data.Rows[0]["ID_SUCURSAL"]),
                IdArea = Convert.ToInt32(data.Rows[0]["ID_AREA"]),
                Datos = data.Rows[0]["DATOS"].ToString(),
                Login = data.Rows[0]["LOGIN"].ToString(),
                Password = data.Rows[0]["PASSWD"].ToString(),
                TipoUsuario = data.Rows[0]["TIPO_USUARIO"].ToString(),
                Estado = Convert.ToInt32(data.Rows[0]["ESTADO"]),
                IdPersonal = data.Rows[0]["ID_PERSONAL"].ToString(),
                IdRol = Convert.ToInt32(data.Rows[0]["ID_ROL"])
            };
        }

       
    }
}