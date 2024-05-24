using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibraryCisepro3.Operaciones
{
    public class ClassOrdenRevisionTecnica
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdOrden { get; set; }
        public int IdSeguridadElectronica { get; set; }
        public DateTime FechaRegistro { get; set; }        
        public DateTime FechaOrden { get; set; }
        public string CedulaRuc { get; set; }
        public string ApellidosNombres { get; set; }
        public int IdClienteGeneral { get; set; }
        public int Estado { get; set; }
        public string Detalle { get; set; }
        public int Tipo { get; set; }

        public DateTime FechaIniciaRevision { get; set; }
        public DateTime FechaRevisionPendiente { get; set; }
        public DateTime FechaRevisionRealizado { get; set; }

        public int BuscarMayorIdOrdenTecnica(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_orden=CASE WHEN MAX(id_orden) IS NULL THEN 0 ELSE MAX(id_orden) End FROM ORDEN_TECNICA_SUPERVISION;", false);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable SeleccionarOrdenTecnicaSupervision(TipoConexion tipoCon, string desde, string hasta, string filtro, int tipo)
        {
            var tp = string.Empty;
            var pars = new List<object[]>
            {
                new object[] { "DESDE", SqlDbType.DateTime, desde } ,
                new object[] { "HASTA", SqlDbType.DateTime, hasta } ,
                new object[] { "FILTRO", SqlDbType.VarChar, filtro }                 
            };
            if (tipo != 0)
            {
                tp = "o.tipo=@TIPO and";
                pars.Add(new object[] { "TIPO", SqlDbType.Int, tipo - 1 });
            }

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select o.ID_ORDEN, o.FECHA_ORDEN, o.CEDULARUC, (o.APELLIDOS_NOMBRES + ' | ' + c.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL) solicita, o.ESTADO, CASE o.ESTADO WHEN 0 THEN 'ANULADO' WHEN 1 THEN 'SIN REVISAR' WHEN 2 THEN 'EN PROCESO' WHEN 3 THEN 'PENDIENTE' ELSE 'REALIZADO' END STATUS, o.DETALLE_NOTIFICACION, o.FECHA_REVISION, o.FECHA_PENDIENTE, o.FECHA_REALIZADO, o.ID_SEG, o.TIPO from ORDEN_TECNICA_SUPERVISION o join CLIENTE_GENERAL c on o.ID_CLIENTE_GENERAL=c.ID_CLIENTE_GENERAL where " + tp + " o.fecha_orden between @DESDE and @HASTA and (o.CEDULARUC like ('%'+@FILTRO+'%') or o.APELLIDOS_NOMBRES like ('%'+@FILTRO+'%') or c.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL like ('%'+@FILTRO+'%')) order by o.FECHA_ORDEN;", false, pars);
        }

        public SqlCommand NuevoRegistroOrdenCommands()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into ORDEN_TECNICA_SUPERVISION (id_orden, fecha_registro, fecha_orden, cedularuc, apellidos_nombres, id_cliente_general, estado, detalle_notificacion, tipo, fecha_revision, fecha_pendiente, fecha_realizado, id_seg) values " +
                              "(@id_orden, @fecha_registro, @fecha_orden, @cedularuc, @apellidos_nombres, @id_cliente_general, @estado, @detalle_notificacion, @tipo, @fecha_revision, @fecha_pendiente, @fecha_realizado, @id_seg);"
            };
            cmd.Parameters.AddWithValue("@id_orden", SqlDbType.Int).Value = IdOrden;            
            cmd.Parameters.AddWithValue("@fecha_registro", SqlDbType.Date).Value = FechaRegistro;
            cmd.Parameters.AddWithValue("@fecha_orden", SqlDbType.Date).Value = FechaOrden;
            cmd.Parameters.AddWithValue("@cedularuc", SqlDbType.VarChar).Value = CedulaRuc;
            cmd.Parameters.AddWithValue("@apellidos_nombres", SqlDbType.VarChar).Value = ApellidosNombres;
            cmd.Parameters.AddWithValue("@id_cliente_general", SqlDbType.Int).Value = IdClienteGeneral;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado;
            cmd.Parameters.AddWithValue("@detalle_notificacion", SqlDbType.VarChar).Value = Detalle;
            cmd.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = Tipo;
            cmd.Parameters.AddWithValue("@fecha_revision", SqlDbType.Date).Value = FechaIniciaRevision;
            cmd.Parameters.AddWithValue("@fecha_pendiente", SqlDbType.Date).Value = FechaRevisionPendiente;
            cmd.Parameters.AddWithValue("@fecha_realizado", SqlDbType.Date).Value = FechaRevisionRealizado;
            cmd.Parameters.AddWithValue("@id_seg", SqlDbType.Int).Value = IdSeguridadElectronica;
            return cmd;
        }

        public SqlCommand AnularRegistroOrdenTecnica()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update ORDEN_TECNICA_SUPERVISION set estado=@estado where id_orden=@id_orden;"
            };
            cmd.Parameters.AddWithValue("@id_orden", SqlDbType.Int).Value = IdOrden;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado;
            return cmd;
        } 
    }
}
