using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ClassLibraryCisepro.CONTABILIDAD.VENTAS
{
    public class ClassClienteGeneral
    {
        /// <summary>
        /// ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S)
        /// SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE
        /// CON EL MISMO TIPO DE DATO
        /// TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE</summary>
        public long IdCliente;
        public string CodigoCliente;
        public string TipoIdentificacionCliente;
        public string RucCiCliente;
        public string NombreRazonSocialCliente;
        public string ApellidoNombreComercialCliente;
        public string NroResContEspecialCliente;
        public string ObligLlevarContCliente;
        public string DireccionUbicacionCliente;
        public string DireccionFacturacionCliente;
        public string ConsorcioCliente;
        public int IdCiudadCliente;
        public string Telefono1Cliente;
        public string Telefono2Cliente;
        public string EmailCliente;
        public string ContactoCliente;
        public DateTime FechaIngresoCliente;
        public string TipoCliente;
        public string ObservacionesCliente;
        public int EstadoCliente;
        public string TipoEmpresa;


        public int BuscarMayorIdClienteGeneral(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            var data = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarMayorIdClienteGeneral", true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] is DBNull ? 0 : Conversions.ToInteger(data.Rows[0][0]);
        }

        public DataTable BuscarClienteGeneralXNombreComercial(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, string parametroBusqueda)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL", SqlDbType.VarChar, parametroBusqueda });
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarClienteGeneralXNombreComercial", true, pars);
        }

        public DataTable BuscarClienteGeneralXRazonSocial(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, string parametroBusqueda)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL", SqlDbType.VarChar, parametroBusqueda });
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarClienteGeneralXRazonSocial", true, pars);
        }

        public int BuscarIdClienteXNombreComercial(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, string cod)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL", SqlDbType.NVarChar, cod });
            var data = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarIdClienteXNombreComercial", true, pars);
            return data.Rows.Count == 0 ? 0 : Conversions.ToInteger(data.Rows[0]["ID_CLIENTE_GENERAL"]);
        }

        public int BuscarIdClienteXRazonSocial(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, string cod)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "NOMBRE_RAZON_SOCIAL_CLIENTE_GENRAL", SqlDbType.NVarChar, cod });
            var data = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarIdClienteXRazonSocial", true, pars);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] is DBNull ? 0 : Conversions.ToInteger(data.Rows[0][0]);
        }

        public string BuscarRazonSocialClienteGeneralXRuc(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, string idActivoF)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "RUC_CI_CLIENTE_GENERAL", SqlDbType.Int, idActivoF });
            var data = ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "BuscarRazonSocialClienteGeneralXRuc", true, pars);
            return data.Rows.Count == 0 ? "0" : Conversions.ToString(data.Rows[0]["NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL"]);
        }

        public DataTable CargarClienteGeneralFacturasPorCobrar(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, string parametroBusqueda, string desde, string hasta)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "DESDE", SqlDbType.DateTime, desde });
            pars.Add(new object[] { "HASTA", SqlDbType.DateTime, hasta });
            pars.Add(new object[] { "DETALLE", SqlDbType.NVarChar, parametroBusqueda });
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "cargarClienteGeneralFacturasPorCobrar", true, pars);
        }

        public DataTable CargarClienteGeneralSinFacturasPorRangoFecha(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, DateTime desde, DateTime hasta)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "@FECHA_INICIAL", SqlDbType.DateTime, desde });
            pars.Add(new object[] { "@FECHA_FINAL", SqlDbType.DateTime, hasta });
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_cargarClienteGeneralSinFacturasPorCobrarPorRangoFecha", true, pars);
        }

        public DataTable BuscarFiltradoPorRazonSocialClienteVigilanciaFisica(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, string parametroBusqueda)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL", SqlDbType.VarChar, parametroBusqueda });
            // and c.id_cliente_general in (select s.id_CLIENTE_GENERAL from sitios_trabajo s where s.id_sitio_trabajo in (select a.id_puesto from asignacion_personal a))
            // Return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT	C.*, (SELECT TOP 1 ID_CONTRATO FROM CONTRATO_CLIENTE WHERE ID_CLIENTE_GENERAL=C.ID_CLIENTE_GENERAL AND ESTADO =1 ORDER BY ANIO DESC) FROM CLIENTE_GENERAL C WHERE C.ESTADO_CLIENTE_GENERAL = 1 and c.id_cliente_general in (select s.id_CLIENTE_GENERAL from sitios_trabajo s where s.id_sitio_trabajo in (select a.id_puesto from asignacion_personal a)) and (C.RUC_CI_CLIENTE_GENERAL LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%') or C.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%') or C.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%'));", False, pars)
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT	C.*, (SELECT TOP 1 ID_CONTRATO FROM CONTRATO_CLIENTE WHERE ID_CLIENTE_GENERAL=C.ID_CLIENTE_GENERAL AND ESTADO =1 ORDER BY ANIO DESC) FROM CLIENTE_GENERAL C WHERE C.ESTADO_CLIENTE_GENERAL = 1 and (C.RUC_CI_CLIENTE_GENERAL LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%') or C.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%') or C.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL LIKE ('%'+@NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL+'%'));", false, pars);
        }

        public DataTable BuscarFiltradoPorConvenioClienteGeneral(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, string parametroBusqueda)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "FIL", SqlDbType.VarChar, parametroBusqueda });
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select cg.id_cliente_general ID, cb.id_convenio IDC, cg.ruc_ci_cliente_general CI_RUC_CLIENTE, cg.nompre_razon_social_cliente_general CLIENTE, cb.banco_convenio BANCO, cb.tipo_cuenta TIPO, cb.num_cuenta_tarj CUENTA_TARJETA, cb.num_ci_ruc CI_RUC_TITULAR, cb.titular_cuenta TITULAR_CUENTA, cb.valor VALOR from convenio_cliente_banco_debito cb join cliente_general cg on cb.id_cliente_general = cg.id_cliente_general where cb.estado = 1 AND (cg.nompre_razon_social_cliente_general  like ('%'+@FIL+'%') or cb.banco_convenio like ('%'+@FIL+'%') or cb.num_ci_ruc like ('%'+@FIL+'%') or cb.titular_cuenta like  ('%'+@FIL+'%'))", false, pars);
        }

        public DataTable BuscarFiltradoPorRazonSocialClienteGeneral(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon, string parametroBusqueda)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL", SqlDbType.VarChar, parametroBusqueda });
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarFiltradoPorRazonSocialClienteGeneral", true, pars);
        }

        public DataTable BuscarRazonSocialClienteGeneral(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarRazonSocialClienteGeneral", true);
        }

        public DataTable BuscarConsorcioClienteGeneral(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            return ClassLibraryCisepro.ProcesosSql.ComandosSql.SeleccionarQueryToDataTable(tipoCon, "buscarConsorcioClienteGeneral", true);
        }

        public AutoCompleteStringCollection Autocompletar(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            var dt = BuscarRazonSocialClienteGeneral(tipoCon);
            var coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
                coleccion.Add(Convert.ToString(row["NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL"]));
            return coleccion;
        }

        public AutoCompleteStringCollection AutocompletarConsorcio(ClassLibraryCisepro.ENUMS.TipoConexion tipoCon)
        {
            var dt = BuscarConsorcioClienteGeneral(tipoCon);
            var coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
                coleccion.Add(Convert.ToString(row["CONSORCIO_CLIENTE_GENERAL"]));
            return coleccion;
        }

        public SqlCommand NuevoRegistroClienteGeneral()
        {
            var comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "nuevoRegistroClienteGeneral";
            comando.Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente;
            comando.Parameters.AddWithValue("@CODIGO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = CodigoCliente;
            comando.Parameters.AddWithValue("@TIPO_IDENTIFICACION_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = TipoIdentificacionCliente;
            comando.Parameters.AddWithValue("@RUC_CI_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = RucCiCliente;
            comando.Parameters.AddWithValue("@NOMBRE_RAZON_SOCIAL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = NombreRazonSocialCliente;
            comando.Parameters.AddWithValue("@APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ApellidoNombreComercialCliente;
            comando.Parameters.AddWithValue("@NRO_RES_CONT_ESPECIAL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = NroResContEspecialCliente;
            comando.Parameters.AddWithValue("@OBLIG_LLEVAR_CONT_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ObligLlevarContCliente;
            comando.Parameters.AddWithValue("@DIRECCION_UBICACION_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = DireccionUbicacionCliente;
            comando.Parameters.AddWithValue("@DIRECCION_FACTURACION_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = DireccionFacturacionCliente;
            comando.Parameters.AddWithValue("@CONSORCIO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ConsorcioCliente;
            comando.Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudadCliente;
            comando.Parameters.AddWithValue("@TELEFONO_1_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = Telefono1Cliente;
            comando.Parameters.AddWithValue("@TELEFONO_2_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = Telefono2Cliente;
            comando.Parameters.AddWithValue("@EMAIL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = EmailCliente;
            comando.Parameters.AddWithValue("@CONTACTO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ContactoCliente;
            comando.Parameters.AddWithValue("@FECHA_INGRESO_CLIENTE_GENERAL", SqlDbType.DateTime).Value = FechaIngresoCliente;
            comando.Parameters.AddWithValue("@TIPO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = TipoCliente;
            comando.Parameters.AddWithValue("@OBSERVACIONES_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ObservacionesCliente;
            comando.Parameters.AddWithValue("@ESTADO_CLIENTE_GENERAL", SqlDbType.Int).Value = EstadoCliente;
            comando.Parameters.AddWithValue("@TIPO_EMPRESA_CLIENTE", SqlDbType.NVarChar).Value = TipoEmpresa;
            return comando;
        }

        public SqlCommand ModificarRegistroClienteGeneral()
        {
            var comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "modificarRegistroClienteGeneral";
            comando.Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente;
            comando.Parameters.AddWithValue("@CODIGO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = CodigoCliente;
            comando.Parameters.AddWithValue("@TIPO_IDENTIFICACION_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = TipoIdentificacionCliente;
            comando.Parameters.AddWithValue("@RUC_CI_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = RucCiCliente;
            comando.Parameters.AddWithValue("@NOMBRE_RAZON_SOCIAL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = NombreRazonSocialCliente;
            comando.Parameters.AddWithValue("@APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ApellidoNombreComercialCliente;
            comando.Parameters.AddWithValue("@NRO_RES_CONT_ESPECIAL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = NroResContEspecialCliente;
            comando.Parameters.AddWithValue("@OBLIG_LLEVAR_CONT_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ObligLlevarContCliente;
            comando.Parameters.AddWithValue("@DIRECCION_UBICACION_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = DireccionUbicacionCliente;
            comando.Parameters.AddWithValue("@DIRECCION_FACTURACION_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = DireccionFacturacionCliente;
            comando.Parameters.AddWithValue("@CONSORCIO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ConsorcioCliente;
            comando.Parameters.AddWithValue("@ID_CIUDAD", SqlDbType.Int).Value = IdCiudadCliente;
            comando.Parameters.AddWithValue("@TELEFONO_1_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = Telefono1Cliente;
            comando.Parameters.AddWithValue("@TELEFONO_2_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = Telefono2Cliente;
            comando.Parameters.AddWithValue("@EMAIL_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = EmailCliente;
            comando.Parameters.AddWithValue("@CONTACTO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ContactoCliente;
            comando.Parameters.AddWithValue("@FECHA_INGRESO_CLIENTE_GENERAL", SqlDbType.DateTime).Value = FechaIngresoCliente;
            comando.Parameters.AddWithValue("@TIPO_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = TipoCliente;
            comando.Parameters.AddWithValue("@OBSERVACIONES_CLIENTE_GENERAL", SqlDbType.NVarChar).Value = ObservacionesCliente;
            comando.Parameters.AddWithValue("@ESTADO_CLIENTE_GENERAL", SqlDbType.Int).Value = EstadoCliente;
            comando.Parameters.AddWithValue("@TIPO_EMPRESA_CLIENTE", SqlDbType.NVarChar).Value = TipoEmpresa;
            return comando;
        }

        public SqlCommand ActualizarEstadoClienteGeneral()
        {
            var comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "actualizarEstadoClienteGeneral";
            comando.Parameters.AddWithValue("@ID_CLIENTE_GENERAL", SqlDbType.BigInt).Value = IdCliente;
            comando.Parameters.AddWithValue("@ESTADO_CLIENTE_GENERAL", SqlDbType.Int).Value = EstadoCliente;
            return comando;
        }

    }
}