using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassContratos
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdContrato { get; set; }
        public long NroContrato { get; set; }
        public DateTime FechaInicialContrato { get; set; }
        public DateTime FechaFinalContrato { get; set; }
        public string PeriodoContrato { get; set; }
        public int TipoContrato { get; set; }
        public string EstadoContrato { get; set; }
        public int IdPersonalContrato { get; set; }
        public int EstadoRegistroContrato { get; set; }
        public string Observacion { get; set; }
        public int IessContratox { get; set; }
        public DateTime FechaAfiliacionContrato { get; set; }
        public int AplicaFondoReservaContrato { get; set; }
        public int XiiiEnRolContrato { get; set; }
        public int XivEnRolContrato { get; set; }
        public int AcumulaFondoReservaContrato { get; set; }
        public double RecExtra { get; set; }
        public int SeDescuentaSerguro { get; set; } 
        public int CobraQuince { get; set; }
        public int ExtSal { get; set; }
        
        public int IdProyecto { get; set; }
        public string NombreProyecto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdCliente { get; set; }
        public int EstadoProyecto { get; set; }
        public string CodigoProyecto { get; set; }

        public int BuscarMayorId(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon,"BuscarMayorIdContrato", true) ;
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }
         
        public DataTable SeleccionarTodosLosRegistrosProyectos(TipoConexion tipoCon, bool todos)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT *, (NOMBRE_PROYECTO + ' ' + CODIGO) PROYECTO FROM CONTRATO_PROYECTO " + (todos ? string.Empty : "WHERE ESTADO = 1"), false);
        }

        public DataTable SeleccionarTodosLosRegistrosProyectosById(TipoConexion tipoCon, int idp)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID", SqlDbType.Int, idp } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT * FROM CONTRATO_PROYECTO WHERE ID_PROYECTO = @ID", false, pars);
        }

        public DataTable SeleccionarContratoFiniquitoPorIdPersonalGeneral1(TipoConexion tipoCon, string idp)
        {
            var pars = new List<object[]>
            {
                new object[] { "id_personal", SqlDbType.Int, idp } 
            };
            var sql = "select  TOP 1 c.id_contrato ID, c.nro_contrato NRO_CONTRATO, convert(varchar, p.id_personal) + ' ~ ' +p.apellidos + ' ' + p.nombres NOMINA, " +
                    "o.descripcion CARGO, a.nombre_area AREA, c.fecha_inicial_contrato INICIO, c.fecha_vencimiento_contrato FINALIZA, c.periodo_contrato PERIODO, c.tipo_contrato DURACION, c.estado_contrato ESTADO_CONTRATO, " +
                    "c.iess IESS, c.fecha_afiliacion DESDE, c.reserva_rol F_RESERVA, c.xiii_rol XIII, c.xiv_rol XIV, c.observacion OBSERVACION, c.rec_ext, c.acum_fon_res, c.desc_seg, c.id_proyecto from contrato c join personal p on c.id_personal = p.id_personal " +
                    "join cargo_ocupacional o on p.id_cargo_ocupacional = o.id_cargo_ocupacional join area_general a on p.id_area = a.id_area_general " +
                    "where c.id_personal =@id_personal And c.estado_contrato = 'FINIQUITO' ORDER BY INICIO DESC;";
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars) ;
        }

        public DataTable SeleccionarContratosPorIdPersonalGeneral1(TipoConexion tipoCon, string idp)
        {
            var pars = new List<object[]>
            {
                new object[] { "id_personal", SqlDbType.Int, idp } 
            };
            var sql = "select c.id_contrato ID, c.nro_contrato NRO_CONTRATO, convert(varchar, p.id_personal) + ' ~ ' +p.apellidos + ' ' + p.nombres NOMINA, " +
                    "o.descripcion CARGO, a.nombre_area AREA, c.fecha_inicial_contrato INICIO, c.fecha_vencimiento_contrato FINALIZA, c.periodo_contrato PERIODO, c.tipo_contrato DURACION, c.estado_contrato ESTADO_CONTRATO, " +
                    "c.iess IESS, c.fecha_afiliacion DESDE, c.reserva_rol F_RESERVA, c.xiii_rol XIII, c.xiv_rol XIV, c.observacion OBSERVACION, c.rec_ext, c.acum_fon_res, c.desc_seg, c.id_proyecto from contrato c join personal p on c.id_personal = p.id_personal " +
                    "join cargo_ocupacional o on p.id_cargo_ocupacional = o.id_cargo_ocupacional join area_general a on p.id_area = a.id_area_general " +
                    "where c.id_personal =@id_personal And c.estado_contrato = 'VIGENTE';";
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars)  ;
        }

        public DataTable BuscarNroContratoRepetido(TipoConexion tipoCon, long num)
        {
            var pars = new List<object[]>
            {
                new object[] { "NRO_CONTRATO", SqlDbType.BigInt, num } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "buscarNroContratoRepetido", true, pars) ; 
        }
         
        public SqlCommand RegistrarNuevoContratoCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "INSERT INTO dbo.CONTRATO  VALUES (@ID_CONTRATO, @NRO_CONTRATO, @FECHA_INICIAL_CONTRATO, @FECHA_VENCIMIENTO_CONTRATO, @PERIODO_CONTRATO, @TIPO_CONTRATO, @ESTADO_CONTRATO, @ID_PERSONAL, @ESTADO, @IESS,  @AFILIACION, @RESERVA,  @XIII, @XIV,@OBSERVACION,@EXTRA, @ACURES, @DESCSEG, @COBRAQ,@EXTSAL,@ID_PROYECTO);"
            };
            cmd.Parameters.AddWithValue("@ID_CONTRATO", SqlDbType.BigInt).Value = IdContrato;
            cmd.Parameters.AddWithValue("@NRO_CONTRATO", SqlDbType.BigInt).Value = NroContrato;
            cmd.Parameters.AddWithValue("@FECHA_INICIAL_CONTRATO", SqlDbType.DateTime).Value = FechaInicialContrato;
            cmd.Parameters.AddWithValue("@FECHA_VENCIMIENTO_CONTRATO", SqlDbType.DateTime).Value = FechaFinalContrato;
            cmd.Parameters.AddWithValue("@PERIODO_CONTRATO", SqlDbType.DateTime).Value = PeriodoContrato;
            cmd.Parameters.AddWithValue("@TIPO_CONTRATO", SqlDbType.Int).Value = TipoContrato;
            cmd.Parameters.AddWithValue("@ESTADO_CONTRATO", SqlDbType.NVarChar).Value = EstadoContrato;
            cmd.Parameters.AddWithValue("@ID_PERSONAL", SqlDbType.Int).Value = IdPersonalContrato;
            cmd.Parameters.AddWithValue("@ESTADO", SqlDbType.Int).Value = EstadoRegistroContrato;
            cmd.Parameters.AddWithValue("@IESS", SqlDbType.Int).Value = IessContratox;
            cmd.Parameters.AddWithValue("@AFILIACION", SqlDbType.DateTime).Value = FechaAfiliacionContrato;
            cmd.Parameters.AddWithValue("@RESERVA", SqlDbType.Int).Value = AplicaFondoReservaContrato;
            cmd.Parameters.AddWithValue("@XIII", SqlDbType.Int).Value = XiiiEnRolContrato;
            cmd.Parameters.AddWithValue("@XIV", SqlDbType.Int).Value = XivEnRolContrato;
            cmd.Parameters.AddWithValue("@ACURES", SqlDbType.Int).Value = AcumulaFondoReservaContrato;
            cmd.Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = Observacion;
            cmd.Parameters.AddWithValue("@EXTRA", SqlDbType.Decimal).Value = RecExtra;
            cmd.Parameters.AddWithValue("@DESCSEG", SqlDbType.Int).Value = SeDescuentaSerguro;
            cmd.Parameters.AddWithValue("@COBRAQ", SqlDbType.Int).Value = CobraQuince;
            cmd.Parameters.AddWithValue("@EXTSAL", SqlDbType.Int).Value = ExtSal;
            cmd.Parameters.AddWithValue("@ID_PROYECTO", SqlDbType.Int).Value = IdProyecto;
            return cmd;
        }

        public SqlCommand ModificarContratoCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update contrato set tipo_contrato=@tipo_contrato, fecha_inicial_contrato=@fin,fecha_vencimiento_contrato=@fuo, fecha_afiliacion=@faf,  periodo_contrato=@ped, observacion=@observacion, RESERVA_ROL=@RESERVA, XIII_ROL=@XIII, XIV_ROL=@XIV, REC_EXT=@EXTRA, ACUM_FON_RES=@ACURES, DESC_SEG=@DESCSEG, EXTSAL=@EXTSAL, ID_PROYECTO=@ID_PROYECTO where nro_contrato=@nro_contrato and id_personal=@pers;"
            };
            cmd.Parameters.AddWithValue("@pers", SqlDbType.Int).Value = IdPersonalContrato;
            cmd.Parameters.AddWithValue("@nro_contrato", SqlDbType.Int).Value = NroContrato;

            cmd.Parameters.AddWithValue("@fin", SqlDbType.DateTime).Value = FechaInicialContrato;
            cmd.Parameters.AddWithValue("@fuo", SqlDbType.DateTime).Value = FechaFinalContrato;
            cmd.Parameters.AddWithValue("@faf", SqlDbType.DateTime).Value = FechaAfiliacionContrato;
            cmd.Parameters.AddWithValue("@ped", SqlDbType.Int).Value = PeriodoContrato;
            cmd.Parameters.AddWithValue("@tipo_contrato", SqlDbType.Int).Value = TipoContrato;

            cmd.Parameters.AddWithValue("@observacion", SqlDbType.NVarChar).Value = Observacion;
            cmd.Parameters.AddWithValue("@RESERVA", SqlDbType.Int).Value = AplicaFondoReservaContrato;
            cmd.Parameters.AddWithValue("@XIII", SqlDbType.Int).Value = XiiiEnRolContrato;
            cmd.Parameters.AddWithValue("@XIV", SqlDbType.Int).Value = XivEnRolContrato;
            cmd.Parameters.AddWithValue("@ACURES", SqlDbType.Int).Value = AcumulaFondoReservaContrato;
            cmd.Parameters.AddWithValue("@EXTRA", SqlDbType.Decimal).Value = RecExtra;
            cmd.Parameters.AddWithValue("@DESCSEG", SqlDbType.Int).Value = SeDescuentaSerguro;
            cmd.Parameters.AddWithValue("@EXTSAL", SqlDbType.Int).Value = ExtSal;
            cmd.Parameters.AddWithValue("@ID_PROYECTO", SqlDbType.Int).Value = IdProyecto;
            return cmd;
        }

        public SqlCommand ModificarContratoParametrosRolCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update contrato set RESERVA_ROL=@RESERVA, XIII_ROL=@dec, XIV_ROL=@cua, ACUM_FON_RES=@ACURES, DESC_SEG=@DESCSEG, EXTSAL=@EXTSAL where id_personal=@pers and estado_contrato=@cre;" 
            };
            cmd.Parameters.AddWithValue("@pers", SqlDbType.Int).Value = IdPersonalContrato;
            cmd.Parameters.AddWithValue("@RESERVA", SqlDbType.Int).Value = AplicaFondoReservaContrato;
            cmd.Parameters.AddWithValue("@dec", SqlDbType.Int).Value = XiiiEnRolContrato;
            cmd.Parameters.AddWithValue("@cua", SqlDbType.Int).Value = XivEnRolContrato;
            cmd.Parameters.AddWithValue("@ACURES", SqlDbType.Int).Value = AcumulaFondoReservaContrato;
            cmd.Parameters.AddWithValue("@DESCSEG", SqlDbType.Int).Value = SeDescuentaSerguro;
            cmd.Parameters.AddWithValue("@cre", SqlDbType.VarChar).Value = "VIGENTE";
            cmd.Parameters.AddWithValue("@EXTSAL", SqlDbType.Int).Value = ExtSal; 
            return cmd;
        }

        public SqlCommand RegistrarFinalizacionContratoCommand(DateTime fechaSalida, bool noSePresento)
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = noSePresento ? "update contrato set ESTADO_CONTRATO=@ESTA, OBSERVACION=@OBSERVACION, FECHA_INICIAL_CONTRATO=@FEOUT, FECHA_VENCIMIENTO_CONTRATO=@FEOUT where NRO_CONTRATO=@NRO_CONTRATO and id_personal=@idp;" :
                "update contrato set ESTADO_CONTRATO=@ESTA, OBSERVACION=@OBSERVACION, FECHA_VENCIMIENTO_CONTRATO=@FEOUT where NRO_CONTRATO=@NRO_CONTRATO and id_personal=@idp;"
            };
            cmd.Parameters.AddWithValue("@NRO_CONTRATO", SqlDbType.BigInt).Value = NroContrato;
            cmd.Parameters.AddWithValue("@OBSERVACION", SqlDbType.NVarChar).Value = Observacion;
            cmd.Parameters.AddWithValue("@ESTA", SqlDbType.NVarChar).Value = "FINIQUITO";
            cmd.Parameters.AddWithValue("@FEOUT", SqlDbType.DateTime).Value = fechaSalida;
            cmd.Parameters.AddWithValue("@idp", SqlDbType.Int).Value = IdPersonalContrato;
            return cmd;
        }

        public DataTable SeleccionarProyectosContratoFiltro(TipoConexion tipoCon, string filtro)
        {
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, string.Concat("%", filtro, "%") } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT P.ID_PROYECTO ID, P.CODIGO, P.NOMBRE_PROYECTO NOMBRE, P.FECHA_INICIO INICIO, P.FECHA_FIN FIN, P.ID_CLIENTE IDC, C.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL CLIENTE, P.ESTADO FROM CONTRATO_PROYECTO P LEFT JOIN CLIENTE_GENERAL C ON P.ID_CLIENTE=C.ID_CLIENTE_GENERAL WHERE P.NOMBRE_PROYECTO like @FILTRO or C.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL like @FILTRO;", false, pars);
        }

        public int BuscarMayorIdProyecto(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT ID_PROYECTO=CASE WHEN MAX(ID_PROYECTO) IS NULL THEN 0 ELSE MAX(ID_PROYECTO) End FROM CONTRATO_PROYECTO", false);
            return data.Rows.Count == 0 ? 0 : Convert.ToInt32(data.Rows[0]["ID_PROYECTO"]);
        }

        public SqlCommand RegistrarNuevoProyectoCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into CONTRATO_PROYECTO values (@ID_PROYECTO, @NOMBRE_PROYECTO, @FECHA_INICIO, @FECHA_FIN, @ID_CLIENTE, @ESTADO, @CODIGO);"
            };
            cmd.Parameters.AddWithValue("@ID_PROYECTO", SqlDbType.BigInt).Value = IdProyecto;
            cmd.Parameters.AddWithValue("@NOMBRE_PROYECTO", SqlDbType.NVarChar).Value = NombreProyecto;
            cmd.Parameters.AddWithValue("@FECHA_INICIO", SqlDbType.DateTime).Value = FechaInicio;
            cmd.Parameters.AddWithValue("@FECHA_FIN", SqlDbType.DateTime).Value = FechaFin;
            cmd.Parameters.AddWithValue("@ID_CLIENTE", SqlDbType.BigInt).Value = IdCliente;
            cmd.Parameters.AddWithValue("@ESTADO", SqlDbType.BigInt).Value = EstadoProyecto;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = CodigoProyecto;
            return cmd;
        }

        public SqlCommand ModificarNuevoProyectoCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update CONTRATO_PROYECTO set NOMBRE_PROYECTO=@NOMBRE_PROYECTO, FECHA_INICIO=@FECHA_INICIO, FECHA_FIN=@FECHA_FIN, ID_CLIENTE=@ID_CLIENTE, ESTADO=@ESTADO, CODIGO=@CODIGO WHERE ID_PROYECTO=@ID_PROYECTO;"
            };
            cmd.Parameters.AddWithValue("@ID_PROYECTO", SqlDbType.BigInt).Value = IdProyecto;
            cmd.Parameters.AddWithValue("@NOMBRE_PROYECTO", SqlDbType.NVarChar).Value = NombreProyecto;
            cmd.Parameters.AddWithValue("@FECHA_INICIO", SqlDbType.DateTime).Value = FechaInicio;
            cmd.Parameters.AddWithValue("@FECHA_FIN", SqlDbType.DateTime).Value = FechaFin;
            cmd.Parameters.AddWithValue("@ID_CLIENTE", SqlDbType.BigInt).Value = IdCliente;
            cmd.Parameters.AddWithValue("@ESTADO", SqlDbType.BigInt).Value = EstadoProyecto;
            cmd.Parameters.AddWithValue("@CODIGO", SqlDbType.NVarChar).Value = CodigoProyecto;
            return cmd;
        }


        public int BuscarMayorNumTicketFarmacia(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT num_ticket=CASE WHEN MAX(num_ticket) IS NULL THEN 0 ELSE MAX(num_ticket) End FROM TICKETS_FARMACIA_COMECSA WHERE tipo_ticket = 0;", false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public int BuscarMayorNumTicketComecsa(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT num_ticket=CASE WHEN MAX(num_ticket) IS NULL THEN 0 ELSE MAX(num_ticket) End FROM TICKETS_FARMACIA_COMECSA WHERE tipo_ticket = 1;", false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public int BuscarMayorNumTicketComisariato(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT num_ticket=CASE WHEN MAX(num_ticket) IS NULL THEN 0 ELSE MAX(num_ticket) End FROM TICKETS_FARMACIA_COMECSA WHERE tipo_ticket = 3;", false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public int BuscarMayorNumTicketAnticipo(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT num_ticket=CASE WHEN MAX(num_ticket) IS NULL THEN 0 ELSE MAX(num_ticket) End FROM TICKETS_FARMACIA_COMECSA WHERE tipo_ticket = 2;", false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }
    }
}
