using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassAspirante
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdAspirante { get; set; }
        public DateTime FechaRegistroAspirante { get; set; }
        public string CedulaAspirante { get; set; }
        public string SexoAspirante { get; set; }
        public DateTime FechaNacimientoAspirante { get; set; }
        public int EdadAspirante { get; set; }
        public string NombresAspirante { get; set; }
        public string ApellidosAspirante { get; set; }
        public string EstadoCivilAspirante { get; set; }
        public string InstruccionAspirante { get; set; }
        public string TelefonoAspirante { get; set; }
        public string MovilAspirante { get; set; }
        public string EmailAspirante { get; set; }
        public string ProvinciaAspirante { get; set; }
        public string CiudadAspirante { get; set; }
        public string ParroquiaAspirante { get; set; }
        public string DireccionAspirante { get; set; }
        public string ObservacionAspirante { get; set; }
        public string AptoParaAspirante { get; set; }

        public int TieneCedula { get; set; }
        public int TieneVotacion { get; set; }
        public int TieneMilitar { get; set; }
        public int TieneDiscapacidad { get; set; }
        public string TipoDiscapacidad { get; set; }
        public string PruebaAntidroga { get; set; }

        public int TieneCurso { get; set; }
        public string EntidadCurso { get; set; }

        public int TieneCredencial { get; set; }
        public string EntidadCredencial { get; set; }

        public int TieneAntecedentes { get; set; }
        public string DetalleAntecedentes { get; set; }

        public int TieneNoViolencia { get; set; }
        public string DetalleNoViolencia { get; set; }

        public int TienePsicologico { get; set; }
        public string DetallePsicologico { get; set; }

        public int TieneCertTrabajo { get; set; }
        public string DetalleCertTrabajo { get; set; }

        public int TieneRecomendacion { get; set; }
        public string DetalleRecomendacion { get; set; }

        public int TieneBachiller { get; set; }
        public string DetalleBachiller { get; set; }

        public int TienePoligrafica { get; set; }
        public string DetallePoligrafica { get; set; }

        public int TieneAfis { get; set; }
        public string DetalleAfis { get; set; }

        public int TieneVehiculo { get; set; }
        public string DetalleVehiculo { get; set; }

        public byte[] Documentos { get; set; }

        public int BuscarMayorId(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT ID_ASPIRANTE=CASE WHEN MAX(ID_ASPIRANTE) IS NULL THEN 0 ELSE MAX(ID_ASPIRANTE) End FROM ASPIRANTE;", false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public int BuscarCedulaExistente(TipoConexion tipoCon, string cedula)
        {
            var pars = new List<object[]>
            {
                new object[] { "CEDULA", SqlDbType.VarChar, cedula } 
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT CEDULA=COUNT(CEDULA) from Aspirante where CEDULA=@CEDULA;", false, pars);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable SeleccionarTodosRegistrosAspiranteFiltro(TipoConexion tipoCon, int estado, string fil)
        {
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, string.Concat("%", fil, "%") } 
            };

            var est = "";
            switch (estado)
            {
                case 1:
                    est = "tab.ESTADO ='ASPIRANTE' AND";
                    break;
                case 2:
                    est = "tab.ESTADO ='ACTIVO' AND";
                    break;
                case 3:
                    est = "tab.ESTADO ='RETIRADO' AND";
                    break;
                default:
                    est = "tab.ESTADO LIKE '%' AND";
                    break;

            }

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select ID, CEDULA, NOMINA, CIUDAD, DIRECCION, OBSERVACION, APTO, isnull(ESTADO, 'ASPIRANTE') ESTADO, PUESTO, REGISTRO, convert(varchar, INGRESO, 20) INGRESO, (case WHEN SALIDA >= INGRESO THEN convert(varchar, SALIDA, 20) ELSE NULL END) SALIDA from (select A.ID_ASPIRANTE ID, A.CEDULA, (A.APELLIDOS + ' ' + A.NOMBRES) NOMINA, A.CIUDAD, A.DIRECCION, A.OBSERVACION, A.APTO_PARA APTO, case (SELECT top 1 C.ESTADO_CONTRATO FROM PERSONAL R JOIN CONTRATO C ON R.ID_PERSONAL = C.ID_PERSONAL WHERE R.cedula = A.CEDULA order by C.fecha_inicial_contrato desc) when 'VIGENTE' THEN 'ACTIVO' when 'FINIQUITO' then 'RETRIADO' else 'ASPIRANTE'END ESTADO, (select top 1 si.nombre_sitio_trabajo+ '(' + cl.nompre_razon_social_cliente_general  + ')' + '      DEL ' + convert(varchar(10), dp.fecha_desde, 103) + '      AL ' + convert(varchar(10), dp.fecha_hasta, 103) from detalle_programacion dp join personal p on dp.id_personal=p.id_personal join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo join cliente_general cl on si.id_cliente_general=cl.id_cliente_general where p.cedula = A.CEDULA order by dp.id_programacion desc, dp.fecha_desde desc) PUESTO, A.fecha_registro REGISTRO, (SELECT top 1 C.FECHA_INICIAL_CONTRATO FROM PERSONAL R JOIN CONTRATO C ON R.ID_PERSONAL = C.ID_PERSONAL WHERE R.cedula = A.CEDULA order by C.fecha_inicial_contrato desc) INGRESO, (SELECT top 1 C.FECHA_VENCIMIENTO_CONTRATO FROM PERSONAL R JOIN CONTRATO C ON R.ID_PERSONAL = C.ID_PERSONAL WHERE R.cedula = A.CEDULA order by C.fecha_inicial_contrato desc) SALIDA from ASPIRANTE A) as tab WHERE " + est + " (tab.CEDULA LIKE @FILTRO OR tab.NOMINA LIKE @FILTRO)", false, pars);
        }

        public DataTable SeleccionarDatosAspiranteById(TipoConexion tipoCon, string idAspirante)
        {
            var pars = new List<object[]>
            {
                 new object[] { "ID_ASPIRANTE", SqlDbType.VarChar, idAspirante } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT A.*, DATEDIFF(YEAR,A.FECHA_NACIMIENTO,GETDATE())-(CASE WHEN DATEADD(YY,DATEDIFF(YEAR,A.FECHA_NACIMIENTO,GETDATE()),A.FECHA_NACIMIENTO)>GETDATE() THEN 1 ELSE 0 END) ANIOS, (select top 1 si.nombre_sitio_trabajo+ '(' + cl.nompre_razon_social_cliente_general  + ')' + '      DEL ' + convert(varchar(10), dp.fecha_desde, 103) + '      AL ' + convert(varchar(10), dp.fecha_hasta, 103) from detalle_programacion dp join personal p on dp.id_personal=p.id_personal join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo join cliente_general cl on si.id_cliente_general=cl.id_cliente_general where p.cedula = A.CEDULA order by dp.id_programacion desc, dp.fecha_desde desc) PUESTO FROM ASPIRANTE A WHERE A.ID_ASPIRANTE=@ID_ASPIRANTE;", false, pars);
        }

        public DataTable SeleccionarDatosAspiranteByCi(TipoConexion tipoCon, string cedula)
        {
            var pars = new List<object[]>
            {
                 new object[] { "CEDULA", SqlDbType.VarChar, cedula } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT A.*, DATEDIFF(YEAR,A.FECHA_NACIMIENTO,GETDATE())-(CASE WHEN DATEADD(YY,DATEDIFF(YEAR,A.FECHA_NACIMIENTO,GETDATE()),A.FECHA_NACIMIENTO)>GETDATE() THEN 1 ELSE 0 END) ANIOS, (select top 1 si.nombre_sitio_trabajo+ '(' + cl.nompre_razon_social_cliente_general  + ')' + '      DEL ' + convert(varchar(10), dp.fecha_desde, 103) + '      AL ' + convert(varchar(10), dp.fecha_hasta, 103) from detalle_programacion dp join personal p on dp.id_personal=p.id_personal join sitios_trabajo si on dp.id_puesto=si.id_sitio_trabajo join cliente_general cl on si.id_cliente_general=cl.id_cliente_general where p.cedula = A.CEDULA order by dp.id_programacion desc, dp.fecha_desde desc) PUESTO FROM ASPIRANTE A WHERE A.CEDULA=@CEDULA;", false, pars);
        }

        public SqlCommand SaveAspiranteCommand(bool isUpdate)
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
            };

            if (isUpdate)
            {
                if (Documentos != null)
                {
                    cmd.CommandText = "UPDATE ASPIRANTE SET CEDULA=@IDENTIDAD,  SEXO=@SEXO, FECHA_NACIMIENTO=@FECHA_NACIMIENTO, EDAD=@EDAD, NOMBRES=@NOMBRES, APELLIDOS=@APELLIDOS, ESTADO_CIVIL=@ESTADO_CIVIL, INSTRUCCION=@INSTRUCCION, TELEFONO=@TELEFONO, MOVIL=@MOVIL, EMAIL=@EMAIL, PROVINCIA=@PROVINCIA, CIUDAD=@CIUDAD, PARROQUIA=@PARROQUIA, DIRECCION=@DIRECCION, OBSERVACION=@OBSERVACION, APTO_PARA=@APTO_PARA, TIENE_CEDULA=@TIENE_CEDULA, TIENE_CERTIFICADO_VOTACION=@TIENE_CERTIFICADO_VOTACION, TIENE_LIBRETA_MILITAR=@TIENE_LIBRETA_MILITAR, TIENE_DISCAPACIDAD=@TIENE_DISCAPACIDAD, TIPO_DISCAPACIDAD=@TIPO_DISCAPACIDAD, PRUEBA_ANTIDROGA=@PRUEBA_ANTIDROGA, TIENE_CURSO=@TIENE_CURSO, ENTIDAD_CURSO=@ENTIDAD_CURSO, TIENE_CREDENCIAL=@TIENE_CREDENCIAL, ENTIDAD_CREDENCIAL=@ENTIDAD_CREDENCIAL, TIENE_ANTECEDENTES=@TIENE_ANTECEDENTES, DETALLE_ANTECEDENTES=@DETALLE_ANTECEDENTES, TIENE_NO_VIOLENCIA=@TIENE_NO_VIOLENCIA, DETALLE_NO_VIOLENCIA=@DETALLE_NO_VIOLENCIA, TIENE_PSICOLOGICO=@TIENE_PSICOLOGICO, DETALLE_PSICOLOGICO=@DETALLE_PSICOLOGICO, TIENE_CERT_TRABAJO=@TIENE_CERT_TRABAJO, DETALLE_CERT_TRABAJO=@DETALLE_CERT_TRABAJO, TIENE_RECOMENDACION=@TIENE_RECOMENDACION, DETALLE_RECOMENDACION=@DETALLE_RECOMENDACION, TIENE_BACHILLER=@TIENE_BACHILLER, DETALLE_BACHILLER=@DETALLE_BACHILLER, TIENE_POLIGRAFICA=@TIENE_POLIGRAFICA, DETALLE_POLIGRAFICA=@DETALLE_POLIGRAFICA, TIENE_AFIS=@TIENE_AFIS, DETALLE_AFIS=@DETALLE_AFIS, TIENE_VEHICULO=@TIENE_VEHICULO, DETALLE_VEHICULO=@DETALLE_VEHICULO, DOCUMENTOS=@DOCUMENTO WHERE ID_ASPIRANTE=@ID_ASPIRANTE;";
                    cmd.Parameters.AddWithValue("@DOCUMENTO", SqlDbType.VarBinary).Value = Documentos;
                }
                else cmd.CommandText = "UPDATE ASPIRANTE SET CEDULA=@IDENTIDAD,  SEXO=@SEXO, FECHA_NACIMIENTO=@FECHA_NACIMIENTO, EDAD=@EDAD, NOMBRES=@NOMBRES, APELLIDOS=@APELLIDOS, ESTADO_CIVIL=@ESTADO_CIVIL, INSTRUCCION=@INSTRUCCION, TELEFONO=@TELEFONO, MOVIL=@MOVIL, EMAIL=@EMAIL, PROVINCIA=@PROVINCIA, CIUDAD=@CIUDAD, PARROQUIA=@PARROQUIA, DIRECCION=@DIRECCION, OBSERVACION=@OBSERVACION, APTO_PARA=@APTO_PARA, TIENE_CEDULA=@TIENE_CEDULA, TIENE_CERTIFICADO_VOTACION=@TIENE_CERTIFICADO_VOTACION, TIENE_LIBRETA_MILITAR=@TIENE_LIBRETA_MILITAR, TIENE_DISCAPACIDAD=@TIENE_DISCAPACIDAD, TIPO_DISCAPACIDAD=@TIPO_DISCAPACIDAD, PRUEBA_ANTIDROGA=@PRUEBA_ANTIDROGA, TIENE_CURSO=@TIENE_CURSO, ENTIDAD_CURSO=@ENTIDAD_CURSO, TIENE_CREDENCIAL=@TIENE_CREDENCIAL, ENTIDAD_CREDENCIAL=@ENTIDAD_CREDENCIAL, TIENE_ANTECEDENTES=@TIENE_ANTECEDENTES, DETALLE_ANTECEDENTES=@DETALLE_ANTECEDENTES, TIENE_NO_VIOLENCIA=@TIENE_NO_VIOLENCIA, DETALLE_NO_VIOLENCIA=@DETALLE_NO_VIOLENCIA, TIENE_PSICOLOGICO=@TIENE_PSICOLOGICO, DETALLE_PSICOLOGICO=@DETALLE_PSICOLOGICO, TIENE_CERT_TRABAJO=@TIENE_CERT_TRABAJO, DETALLE_CERT_TRABAJO=@DETALLE_CERT_TRABAJO, TIENE_RECOMENDACION=@TIENE_RECOMENDACION, DETALLE_RECOMENDACION=@DETALLE_RECOMENDACION, TIENE_BACHILLER=@TIENE_BACHILLER, DETALLE_BACHILLER=@DETALLE_BACHILLER, TIENE_POLIGRAFICA=@TIENE_POLIGRAFICA, DETALLE_POLIGRAFICA=@DETALLE_POLIGRAFICA, TIENE_AFIS=@TIENE_AFIS, DETALLE_AFIS=@DETALLE_AFIS, TIENE_VEHICULO=@TIENE_VEHICULO, DETALLE_VEHICULO=@DETALLE_VEHICULO WHERE ID_ASPIRANTE=@ID_ASPIRANTE;";
            }
            else
            {
                if (Documentos == null)
                {
                    cmd.CommandText = "insert into ASPIRANTE (ID_ASPIRANTE,CEDULA,SEXO,FECHA_NACIMIENTO,EDAD,NOMBRES,APELLIDOS,ESTADO_CIVIL,INSTRUCCION,TELEFONO,MOVIL,EMAIL,PROVINCIA,CIUDAD,PARROQUIA," +
                "DIRECCION,OBSERVACION,APTO_PARA,TIENE_CEDULA,TIENE_CERTIFICADO_VOTACION,TIENE_LIBRETA_MILITAR,TIENE_DISCAPACIDAD,TIPO_DISCAPACIDAD,PRUEBA_ANTIDROGA,TIENE_CURSO,ENTIDAD_CURSO,TIENE_CREDENCIAL,ENTIDAD_CREDENCIAL," +
                "TIENE_ANTECEDENTES,DETALLE_ANTECEDENTES,TIENE_NO_VIOLENCIA,DETALLE_NO_VIOLENCIA,TIENE_PSICOLOGICO,DETALLE_PSICOLOGICO,TIENE_CERT_TRABAJO,DETALLE_CERT_TRABAJO,TIENE_RECOMENDACION,DETALLE_RECOMENDACION," +
                "TIENE_BACHILLER,DETALLE_BACHILLER,TIENE_POLIGRAFICA,DETALLE_POLIGRAFICA,TIENE_AFIS,DETALLE_AFIS,TIENE_VEHICULO,DETALLE_VEHICULO,FECHA_REGISTRO) " +
                "values(@ID_ASPIRANTE,@IDENTIDAD,@SEXO,@FECHA_NACIMIENTO,@EDAD,@NOMBRES,@APELLIDOS,@ESTADO_CIVIL,@INSTRUCCION,@TELEFONO,@MOVIL,@EMAIL,@PROVINCIA,@CIUDAD,@PARROQUIA," +
                "@DIRECCION,@OBSERVACION,@APTO_PARA,@TIENE_CEDULA,@TIENE_CERTIFICADO_VOTACION,@TIENE_LIBRETA_MILITAR,@TIENE_DISCAPACIDAD,@TIPO_DISCAPACIDAD,@PRUEBA_ANTIDROGA,@TIENE_CURSO,@ENTIDAD_CURSO,@TIENE_CREDENCIAL,@ENTIDAD_CREDENCIAL," +
                "@TIENE_ANTECEDENTES,@DETALLE_ANTECEDENTES,@TIENE_NO_VIOLENCIA,@DETALLE_NO_VIOLENCIA,@TIENE_PSICOLOGICO,@DETALLE_PSICOLOGICO,@TIENE_CERT_TRABAJO,@DETALLE_CERT_TRABAJO,@TIENE_RECOMENDACION,@DETALLE_RECOMENDACION," +
                "@TIENE_BACHILLER,@DETALLE_BACHILLER,@TIENE_POLIGRAFICA,@DETALLE_POLIGRAFICA,@TIENE_AFIS,@DETALLE_AFIS,@TIENE_VEHICULO,@DETALLE_VEHICULO,@FECHA_REGISTRO)";
                }
                else
                {
                    cmd.CommandText = "insert into ASPIRANTE (ID_ASPIRANTE,CEDULA,SEXO,FECHA_NACIMIENTO,EDAD,NOMBRES,APELLIDOS,ESTADO_CIVIL,INSTRUCCION,TELEFONO,MOVIL,EMAIL,PROVINCIA,CIUDAD,PARROQUIA," +
               "DIRECCION,OBSERVACION,APTO_PARA,TIENE_CEDULA,TIENE_CERTIFICADO_VOTACION,TIENE_LIBRETA_MILITAR,TIENE_DISCAPACIDAD,TIPO_DISCAPACIDAD,PRUEBA_ANTIDROGA,TIENE_CURSO,ENTIDAD_CURSO,TIENE_CREDENCIAL,ENTIDAD_CREDENCIAL," +
               "TIENE_ANTECEDENTES,DETALLE_ANTECEDENTES,TIENE_NO_VIOLENCIA,DETALLE_NO_VIOLENCIA,TIENE_PSICOLOGICO,DETALLE_PSICOLOGICO,TIENE_CERT_TRABAJO,DETALLE_CERT_TRABAJO,TIENE_RECOMENDACION,DETALLE_RECOMENDACION," +
               "TIENE_BACHILLER,DETALLE_BACHILLER,TIENE_POLIGRAFICA,DETALLE_POLIGRAFICA,TIENE_AFIS,DETALLE_AFIS,TIENE_VEHICULO,DETALLE_VEHICULO,FECHA_REGISTRO, DOCUMENTOS) " +
               "values(@ID_ASPIRANTE,@IDENTIDAD,@SEXO,@FECHA_NACIMIENTO,@EDAD,@NOMBRES,@APELLIDOS,@ESTADO_CIVIL,@INSTRUCCION,@TELEFONO,@MOVIL,@EMAIL,@PROVINCIA,@CIUDAD,@PARROQUIA," +
               "@DIRECCION,@OBSERVACION,@APTO_PARA,@TIENE_CEDULA,@TIENE_CERTIFICADO_VOTACION,@TIENE_LIBRETA_MILITAR,@TIENE_DISCAPACIDAD,@TIPO_DISCAPACIDAD,@PRUEBA_ANTIDROGA,@TIENE_CURSO,@ENTIDAD_CURSO,@TIENE_CREDENCIAL,@ENTIDAD_CREDENCIAL," +
               "@TIENE_ANTECEDENTES,@DETALLE_ANTECEDENTES,@TIENE_NO_VIOLENCIA,@DETALLE_NO_VIOLENCIA,@TIENE_PSICOLOGICO,@DETALLE_PSICOLOGICO,@TIENE_CERT_TRABAJO,@DETALLE_CERT_TRABAJO,@TIENE_RECOMENDACION,@DETALLE_RECOMENDACION," +
               "@TIENE_BACHILLER,@DETALLE_BACHILLER,@TIENE_POLIGRAFICA,@DETALLE_POLIGRAFICA,@TIENE_AFIS,@DETALLE_AFIS,@TIENE_VEHICULO,@DETALLE_VEHICULO,@FECHA_REGISTRO, @DOCUMENTO)";
                    cmd.Parameters.AddWithValue("@DOCUMENTO", SqlDbType.VarBinary).Value = Documentos;
                }
                cmd.Parameters.AddWithValue("@FECHA_REGISTRO", SqlDbType.Int).Value = FechaRegistroAspirante;
            }

            cmd.Parameters.AddWithValue("@ID_ASPIRANTE", SqlDbType.Int).Value = IdAspirante;
            cmd.Parameters.AddWithValue("@IDENTIDAD", SqlDbType.NVarChar).Value = CedulaAspirante;
            cmd.Parameters.AddWithValue("@SEXO", SqlDbType.NVarChar).Value = SexoAspirante;
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", SqlDbType.DateTime).Value = FechaNacimientoAspirante;
            cmd.Parameters.AddWithValue("@EDAD", SqlDbType.Int).Value = EdadAspirante;
            cmd.Parameters.AddWithValue("@NOMBRES", SqlDbType.NVarChar).Value = NombresAspirante;
            cmd.Parameters.AddWithValue("@APELLIDOS", SqlDbType.NVarChar).Value = ApellidosAspirante;
            cmd.Parameters.AddWithValue("@ESTADO_CIVIL", SqlDbType.NVarChar).Value = EstadoCivilAspirante;
            cmd.Parameters.AddWithValue("@INSTRUCCION", SqlDbType.NVarChar).Value = InstruccionAspirante;
            cmd.Parameters.AddWithValue("@TELEFONO", SqlDbType.NVarChar).Value = TelefonoAspirante;
            cmd.Parameters.AddWithValue("@MOVIL", SqlDbType.NVarChar).Value = MovilAspirante;
            cmd.Parameters.AddWithValue("@EMAIL", SqlDbType.NVarChar).Value = EmailAspirante;
            cmd.Parameters.AddWithValue("@PROVINCIA", SqlDbType.NVarChar).Value = ProvinciaAspirante;
            cmd.Parameters.AddWithValue("@CIUDAD", SqlDbType.NVarChar).Value = CiudadAspirante;
            cmd.Parameters.AddWithValue("@PARROQUIA", SqlDbType.NVarChar).Value = ParroquiaAspirante;
            cmd.Parameters.AddWithValue("@DIRECCION", SqlDbType.NVarChar).Value = DireccionAspirante;
            cmd.Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = ObservacionAspirante;
            cmd.Parameters.AddWithValue("@APTO_PARA", SqlDbType.NVarChar).Value = AptoParaAspirante;
            cmd.Parameters.AddWithValue("@TIENE_CEDULA", SqlDbType.Int).Value = TieneCedula;
            cmd.Parameters.AddWithValue("@TIENE_CERTIFICADO_VOTACION", SqlDbType.Int).Value = TieneVotacion;
            cmd.Parameters.AddWithValue("@TIENE_LIBRETA_MILITAR", SqlDbType.Int).Value = TieneMilitar;
            cmd.Parameters.AddWithValue("@TIENE_DISCAPACIDAD", SqlDbType.Int).Value = TieneDiscapacidad;
            cmd.Parameters.AddWithValue("@TIPO_DISCAPACIDAD", SqlDbType.VarChar).Value = TipoDiscapacidad;
            cmd.Parameters.AddWithValue("@PRUEBA_ANTIDROGA", SqlDbType.NVarChar).Value = PruebaAntidroga;
            cmd.Parameters.AddWithValue("@TIENE_CURSO", SqlDbType.Int).Value = TieneCurso;
            cmd.Parameters.AddWithValue("@ENTIDAD_CURSO", SqlDbType.VarChar).Value = EntidadCurso;
            cmd.Parameters.AddWithValue("@TIENE_CREDENCIAL", SqlDbType.Int).Value = TieneCredencial;
            cmd.Parameters.AddWithValue("@ENTIDAD_CREDENCIAL", SqlDbType.VarChar).Value = EntidadCredencial;
            cmd.Parameters.AddWithValue("@TIENE_ANTECEDENTES", SqlDbType.Int).Value = TieneAntecedentes;
            cmd.Parameters.AddWithValue("@DETALLE_ANTECEDENTES", SqlDbType.VarChar).Value = DetalleAntecedentes;
            cmd.Parameters.AddWithValue("@TIENE_NO_VIOLENCIA", SqlDbType.Int).Value = TieneNoViolencia;
            cmd.Parameters.AddWithValue("@DETALLE_NO_VIOLENCIA", SqlDbType.VarChar).Value = DetalleNoViolencia;
            cmd.Parameters.AddWithValue("@TIENE_PSICOLOGICO", SqlDbType.Int).Value = TienePsicologico;
            cmd.Parameters.AddWithValue("@DETALLE_PSICOLOGICO", SqlDbType.VarChar).Value = DetallePsicologico;
            cmd.Parameters.AddWithValue("@TIENE_CERT_TRABAJO", SqlDbType.Int).Value = TieneCertTrabajo;
            cmd.Parameters.AddWithValue("@DETALLE_CERT_TRABAJO", SqlDbType.VarChar).Value = DetalleCertTrabajo;
            cmd.Parameters.AddWithValue("@TIENE_RECOMENDACION", SqlDbType.Int).Value = TieneRecomendacion;
            cmd.Parameters.AddWithValue("@DETALLE_RECOMENDACION", SqlDbType.VarChar).Value = DetalleRecomendacion;
            cmd.Parameters.AddWithValue("@TIENE_BACHILLER", SqlDbType.Int).Value = TieneBachiller;
            cmd.Parameters.AddWithValue("@DETALLE_BACHILLER", SqlDbType.VarChar).Value = DetalleBachiller;
            cmd.Parameters.AddWithValue("@TIENE_POLIGRAFICA", SqlDbType.Int).Value = TienePoligrafica;
            cmd.Parameters.AddWithValue("@DETALLE_POLIGRAFICA", SqlDbType.VarChar).Value = DetallePoligrafica;
            cmd.Parameters.AddWithValue("@TIENE_AFIS", SqlDbType.Int).Value = TieneAfis;
            cmd.Parameters.AddWithValue("@DETALLE_AFIS", SqlDbType.VarChar).Value = DetalleAfis;
            cmd.Parameters.AddWithValue("@TIENE_VEHICULO", SqlDbType.Int).Value = TieneVehiculo;
            cmd.Parameters.AddWithValue("@DETALLE_VEHICULO", SqlDbType.VarChar).Value = DetalleVehiculo;
            return cmd;
        }
    }
}
