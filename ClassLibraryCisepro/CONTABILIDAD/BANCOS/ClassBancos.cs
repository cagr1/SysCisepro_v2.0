using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace ClassLibraryCisepro.CONTABILIDAD.BANCOS
{
    public class ClassBancos
    {
        /// <summary>
        /// ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        /// SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        /// CON EL MISMO TIPO DE DATO
        /// TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        public int IdBancos;
        public string Codigo;
        public string Nombre;
        public string Direccion;
        public string OficialCredito;
        public string Telefono;
        public string Fax;
        public string Email;
        public int Estado;


        public DataTable SeleccionarRegistrosBancos(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarRegistrosBancos", true);
        }

        public DataTable SeleccionarOrdenadosRegistrosBancos(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarOrdenadosRegistrosBancos", true);
        }

        public int BuscarMayorIdBancos(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            var data = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdBancos", true);
            return Conversions.ToInteger(data.Rows.Count == 0 ? 0 : data.Rows[0][0] is DBNull ? string.Empty : Conversions.ToString(data.Rows[0][0]));
        }

        public int BuscarIdBancoXNombreBanco(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, string nombreBancoBuscado)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "NOMBRE_BANCO", SqlDbType.NVarChar, nombreBancoBuscado });
            var data = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdBancoXNombreBanco", true, pars);
            return Conversions.ToInteger(data.Rows.Count == 0 ? 0 : data.Rows[0][0] is DBNull ? string.Empty : Conversions.ToString(data.Rows[0][0]));
        }

        public string BuscarCodigoBancoXNombreBanco(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, string nombreBancoBuscado)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "NOMBRE_BANCO", SqlDbType.NVarChar, nombreBancoBuscado });
            var data = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarCodigoBancoXNombreBanco", true, pars);
            return data.Rows.Count == 0 ? string.Empty : data.Rows[0][0] is DBNull ? string.Empty : Conversions.ToString(data.Rows[0][0]);
        }

        public bool NuevoRegistroBancos(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            var comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "NuevoRegistroBancos";
            comando.Parameters.AddWithValue("@ID_BANCO", SqlDbType.Int).Value = IdBancos;
            comando.Parameters.AddWithValue("@CODIGO_BANCO", SqlDbType.NVarChar).Value = Codigo;
            comando.Parameters.AddWithValue("@NOMBRE_BANCO", SqlDbType.NVarChar).Value = Nombre;
            comando.Parameters.AddWithValue("@DIRECCION_BANCO", SqlDbType.NVarChar).Value = Direccion;
            comando.Parameters.AddWithValue("@OFICIAL_CREDITO_BANCO", SqlDbType.NVarChar).Value = OficialCredito;
            comando.Parameters.AddWithValue("@TELEFONO_BANCO", SqlDbType.NVarChar).Value = Telefono;
            comando.Parameters.AddWithValue("@FAX_BANCO", SqlDbType.NVarChar).Value = Fax;
            comando.Parameters.AddWithValue("@EMAIL_BANCO", SqlDbType.NVarChar).Value = Email;
            comando.Parameters.AddWithValue("@ESTADO_BANCO", SqlDbType.Int).Value = Estado;
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.ProcesarComandoCisepro(tipoCon, comando);
        }

        public bool ModificarRegistroBancos(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            var comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "modificarRegistroBancos";
            comando.Parameters.AddWithValue("@ID_BANCO", SqlDbType.Int).Value = IdBancos;
            comando.Parameters.AddWithValue("@NOMBRE_BANCO", SqlDbType.NVarChar).Value = Nombre;
            comando.Parameters.AddWithValue("@DIRECCION_BANCO", SqlDbType.NVarChar).Value = Direccion;
            comando.Parameters.AddWithValue("@OFICIAL_CREDITO_BANCO", SqlDbType.NVarChar).Value = OficialCredito;
            comando.Parameters.AddWithValue("@TELEFONO_BANCO", SqlDbType.NVarChar).Value = Telefono;
            comando.Parameters.AddWithValue("@FAX_BANCO", SqlDbType.NVarChar).Value = Fax;
            comando.Parameters.AddWithValue("@EMAIL_BANCO", SqlDbType.NVarChar).Value = Email;
            comando.Parameters.AddWithValue("@ESTADO_BANCO", SqlDbType.Int).Value = Estado;
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.ProcesarComandoCisepro(tipoCon, comando);
        }

    }
}