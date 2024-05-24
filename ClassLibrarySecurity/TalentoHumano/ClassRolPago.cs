using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassRolPago
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdRol { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int Quincena { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public int Estado { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaValidacion { get; set; }
        public int Tipo { get; set; }
        public int CantFil { get; set; }
        public double SueldoBasico { get; set; }
        public double SueldoVigilantes { get; set; }
        public double CostoHorasNoral { get; set; }
        public double CostoHoras50 { get; set; }
        public double CostoHoras100 { get; set; }
        public double PorcentajePatronalIess { get; set; }
        public double PorcentajePersonalIess { get; set; }
        public double PorcentajeFondoReserva { get; set; }
        public double OtrosDescuentosOperativos { get; set; }
        public double OtrosDescuentosAdmin { get; set; }
        public double AnticipoUtilidad { get; set; }
        public double AnticipoGuardias { get; set; }
        public int QuinceAdminEsSueldoMasExtra { get; set; }
        public string Retenidos { get; set; }
        public string Grupo { get; set; }
        public double PorcentajeDescansoMedico { get; set; }
        public double PorcentajeExtensionSalud { get; set; }

        public DataTable SeleccionarGruposParaExtraPorCliente(TipoConexion tipoCon, string desde, string hasta, int idc)
        {
            var pars = new List<object[]>
            {
                new object[] { "DESDE", SqlDbType.DateTime, desde },
                new object[] { "HASTA", SqlDbType.DateTime, hasta },
                new object[] { "IDC", SqlDbType.Int, idc }
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select st.nombre_sitio_trabajo from asignacion_personal ap join personal pe on ap.id_personal = pe.id_personal join sitios_trabajo st on ap.id_puesto=st.id_sitio_trabajo join cliente_general cg on st.id_cliente_general=cg.id_cliente_general where cg.id_cliente_general=@IDC and ap.tipo <> 'PENDIENTE' and  ap.fecha between @DESDE and @HASTA group by st.nombre_sitio_trabajo order by st.nombre_sitio_trabajo;", false, pars);
        }

        public DataTable SeleccionarDatosParaExtraPorCliente(TipoConexion tipoCon, string desde, string hasta, int idc)
        {
            var pars = new List<object[]>
            {
                new object[] { "DESDE", SqlDbType.DateTime, desde },
                new object[] { "HASTA", SqlDbType.DateTime, hasta },
                new object[] { "IDC", SqlDbType.Int, idc }
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon,
                "select cg.id_cliente_general, cg.nompre_razon_social_cliente_general, st.id_sitio_trabajo,st.nombre_sitio_trabajo, ap.id_personal, " +
"pe.cedula, pe.apellidos + ' ' + pe.nombres nombres, st.cant_horas,'0', '0',st.cant_horas_50,'0','0', st.cant_horas_100,'0','0', st.cant_horas_ext,'0','0', st.cant_rec_noc, st.cant_adici " +
"from asignacion_personal ap " +
"join personal pe on ap.id_personal = pe.id_personal " +
"join sitios_trabajo st on ap.id_puesto=st.id_sitio_trabajo " +
"join cliente_general cg on st.id_cliente_general=cg.id_cliente_general " +
"where cg.id_cliente_general=@IDC and ap.tipo <> 'PENDIENTE' and " +
"ap.fecha between @DESDE and @HASTA " +
"group by cg.id_cliente_general, cg.nompre_razon_social_cliente_general, st.id_sitio_trabajo,st.nombre_sitio_trabajo, " +
"ap.id_personal, pe.cedula, pe.apellidos, pe.nombres, st.cant_horas,  st.cant_horas_50, st.cant_horas_100, st.cant_horas_ext, st.cant_rec_noc, st.cant_adici " +
"order by cg.nompre_razon_social_cliente_general, st.nombre_sitio_trabajo, pe.apellidos, pe.nombres, st.cant_horas,  st.cant_horas_50, st.cant_horas_100, st.cant_horas_ext, st.cant_rec_noc, st.cant_adici;"
                , false, pars);
        }


        public DataTable SeleccionarDetallesPersonalOperQuinceNuevoRolPago(TipoConexion tipoCon, DateTime desde, DateTime hasta, DateTime fcon, string grupo)
        {
            var pars = new List<object[]>
            {
                new object[] { "DESDE", SqlDbType.DateTime, desde } ,
                new object[] { "HASTA", SqlDbType.Date, hasta } ,
                new object[] { "FEON", SqlDbType.Date, fcon } ,
                new object[] { "GRUPO", SqlDbType.VarChar, grupo } 
            };
            return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SeleccionarDetallesPersonalOperQuinceNuevoRolPago", true, pars) ;
        }

        public DataTable SeleccionarDetallesPersonalAdminNuevoRolPago(TipoConexion tipoCon, int mes, int anio, int quince, bool retirados, DateTime desde, DateTime hasta )
        {
            if ((mes < 0 && mes > 12) || (anio < 2000 && anio > 300) || (quince < 0 && quince > 2)) return new DataTable();
            var pars = new List<object[]>();

            string sql;
            var qui = quince == 0 ? " , co.cobra_quince" : ", (select top 1 dr.neto_rol from detalles_rol dr join rol_pago rp on dr.id_rol=rp.id_rol " + 
                "where dr.id_personal=pe.id_personal and rp.mes_rol = " + mes + " and rp.anio_rol=" + anio + " and rp.quincena=0 and rp.tipo=1 and rp.estado>1 order by rp.fecha_elab desc) quincena," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 0) quirografario," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 1) hipotecario," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 2) saludconyuge," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 3) emergente," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 4) capaseg," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 5) varios," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 6) empresa," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 7) comecsa," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 8) comisariato," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 9) bodegaseg," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 10) multas," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 11) otros," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 12) pension,"+
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 13) pensionxiii,"+
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 14) pensionxiv, " +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 15) almuerzo, "+
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=pe.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mes + " and dr.anio_rol = " + anio + " and dr.tipo = 16) diasnolab ";

            if (retirados)
            {
                sql =
                    "select pe.id_personal, cl.nompre_razon_social_cliente_general cliente, ps.nombre_sitio_trabajo, pe.apellidos + ' ' + pe.nombres nomina, pe.cedula, pe.fecha_entrada, cr.descripcion, ar.nombre_area, pe.sueldo, co.RESERVA_ROL, co.XIII_ROL, co.XIV_ROL, co.REC_EXT, co.ACUM_FON_RES, co.DESC_SEG, ps.decimo_extra XIII_SBU_EXT, (case when (pe.fecha_entrada > pe.fecha_salida) then 1 else case when (pe.fecha_salida < @hasta) then 0 else 1 end end) estado_personal, cp.id_banco, bc.nombre_banco, cp.num_cuenta, cp.tipo" +
                    qui +
                    " , pe.fecha_nacimiento, pe.ciudad, co.extsal from personal pe join contrato co on (pe.id_personal = co.id_personal and co.estado = 1) join area_general ar on pe.id_area = ar.id_area_general join cargo_ocupacional cr on pe.id_cargo_ocupacional=cr.id_cargo_ocupacional join gerencias_general gg on ar.id_gerencias_general = gg.id_gerencias_general join sitios_trabajo ps on LTRIM(RTRIM(pe.ubicacion)) = LTRIM(RTRIM(str(ps.id_sitio_trabajo))) join cliente_general cl on ps.id_cliente_general=cl.id_cliente_general join cuentas_personal cp on pe.id_personal = cp.id_personal join bancos bc on cp.id_banco = bc.id_banco where (pe.estado_personal = 1 and gg.id_gerencias_general = 1 and co.estado_contrato = 'VIGENTE') or (pe.estado_personal = 0 and gg.id_gerencias_general = 1 and co.fecha_vencimiento_contrato between @desde and @hasta) order by gg.nombre_gerencias, pe.estado_personal desc, pe.apellidos, pe.nombres;";
            }
            else
            {
                sql = "select pe.id_personal, cl.nompre_razon_social_cliente_general cliente, ps.nombre_sitio_trabajo, pe.apellidos + ' ' + pe.nombres nomina, pe.cedula, pe.fecha_entrada, cr.descripcion, ar.nombre_area, pe.sueldo, co.RESERVA_ROL, co.XIII_ROL, co.XIV_ROL, co.REC_EXT, co.ACUM_FON_RES, co.DESC_SEG, ps.decimo_extra XIII_SBU_EXT, (case when (pe.fecha_entrada > pe.fecha_salida) then 1 else case when (pe.fecha_salida < @hasta) then 0 else 1 end end) estado_personal, cp.id_banco, bc.nombre_banco, cp.num_cuenta, cp.tipo" + 
                    qui +
                    ",  pe.fecha_nacimiento, pe.ciudad, co.extsal from personal pe join contrato co on (pe.id_personal = co.id_personal and co.estado = 1) join area_general ar on pe.id_area = ar.id_area_general join cargo_ocupacional cr on pe.id_cargo_ocupacional=cr.id_cargo_ocupacional join gerencias_general gg on ar.id_gerencias_general = gg.id_gerencias_general join sitios_trabajo ps on LTRIM(RTRIM(pe.ubicacion)) = LTRIM(RTRIM(str(ps.id_sitio_trabajo))) join cliente_general cl on ps.id_cliente_general=cl.id_cliente_general join cuentas_personal cp on pe.id_personal = cp.id_personal join bancos bc on cp.id_banco = bc.id_banco where pe.estado_personal = 1 and gg.id_gerencias_general = 1 and co.estado_contrato = 'VIGENTE' order by gg.nombre_gerencias, pe.apellidos, pe.nombres;";
            }

            pars.Add(new object[] { "desde", SqlDbType.DateTime, desde });
            pars.Add(new object[] { "hasta", SqlDbType.DateTime, hasta });

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        }

        public DataTable SeleccionarDetallesPersonalOperNuevoRolPagoMes(TipoConexion tipoCon, DateTime desded, DateTime hastad, string group, bool activos, int mesx, int aniox, int quince, DateTime desdex)
        {
            
            // cambios en ln 201 y 217 co.ID_PROYECTO = 58 
            var pars = new List<object[]>();

            var esta = activos ?
                "(pe.estado_personal = 1 and co.estado_contrato = 'VIGENTE' and (ap.fecha between @DESDE and @HASTA)  or (pe.estado_personal = 0 and co.fecha_vencimiento_contrato > @HASTA))" :
                "(co.estado_contrato = 'FINIQUITO' and ap.fecha between @DESDE and @HASTA) and (pe.estado_personal = 0 and co.fecha_vencimiento_contrato between @DESDEX and @HASTA)";

            var stat = activos ? "1" : "0";  

            var gr = string.IsNullOrEmpty(group) ? string.Empty : group.Equals("RETIRADOS") ? string.Empty : "where grupo = @GRUPO";

            var qui = quince == 0 ? " " : ", (select top 1 dr.neto_rol from detalles_rol dr join rol_pago rp on dr.id_rol=rp.id_rol " +
                             "where dr.id_personal=datos.id_personal and rp.mes_rol = " + mesx + " and rp.anio_rol=" + aniox + " and rp.quincena=0 and rp.tipo=0 and rp.estado>0 order by rp.fecha_elab desc) quincena," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 0) quirografario," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 1) hipotecario," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 2) saludconyuge," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 3) emergente," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 4) capaseg," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 5) varios," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 6) empresa," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 7) comecsa," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 8) comisariato," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 9) bodegaseg," +
                             "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 10) multas," +
                            "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 11) otros, " +
                            "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 12) pension, " +
                            "(select cant_horas from sitios_trabajo st where st.id_sitio_trabajo = datos.idsitio) cant_horas, " + 
                            " (select cant_horas_50 from sitios_trabajo st where st.id_sitio_trabajo = datos.idsitio) cant_horas_50, "+
                            "(select cant_horas_100 from sitios_trabajo st where st.id_sitio_trabajo = datos.idsitio) cant_horas_100, "+
                            "(select cant_horas_ext from sitios_trabajo st where st.id_sitio_trabajo = datos.idsitio) cant_horas_ext, "+
                            "(select cant_rec_noc from sitios_trabajo st where st.id_sitio_trabajo = datos.idsitio) cant_rec_noc, "+
                            "(select cant_adici from sitios_trabajo st where st.id_sitio_trabajo = datos.idsitio) cant_adici, "+
                            "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 13) pensionxiii, " +
                            "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 14) pensionxiv, "+
                            "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 15) almuerzo, " +
            "(select sum(dr.valor) from descuentos_rol dr where dr.id_personal=datos.id_personal and dr.estado = 1 and dr.procesado=0 and dr.mes_rol=" + mesx + " and dr.anio_rol = " + aniox + " and dr.tipo = 16) diasnolab ";

            var sql = "select *  " + qui + "  from (select pe.id_personal, pe.apellidos + ' ' + pe.nombres nomina, pe.cedula, " +
"pe.fecha_entrada, cr.descripcion, ar.nombre_area, pe.sueldo, 0 dias, " +
"(select top 1 c.nompre_razon_social_cliente_general from asignacion_personal a " +
"join personal p on a.id_personal = p.id_personal " +
"join sitios_trabajo s on a.id_puesto = LTRIM(RTRIM(str(s.id_sitio_trabajo))) " +
"join cliente_general c on s.id_cliente_general=c.id_cliente_general " +
"where p.id_personal = pe.id_personal and (a.fecha between @DESDE and @HASTA) " +
"group by c.nompre_razon_social_cliente_general, s.nombre_sitio_trabajo, a.fecha order by a.fecha desc) CLIENTE, " +
"(select top 1 s.nombre_sitio_trabajo from asignacion_personal a " +
"join personal p on a.id_personal = p.id_personal " +
"join sitios_trabajo s on a.id_puesto = LTRIM(RTRIM(str(s.id_sitio_trabajo))) " +
"join cliente_general c on s.id_cliente_general=c.id_cliente_general " +
"where p.id_personal = pe.id_personal and (a.fecha between @DESDE and @HASTA) " +
"group by c.nompre_razon_social_cliente_general, s.nombre_sitio_trabajo, a.fecha order by a.fecha desc) SITIO, " +
"(select top 1 s.grupo from asignacion_personal a " +
"join personal p on a.id_personal = p.id_personal " +
"join sitios_trabajo s on a.id_puesto = LTRIM(RTRIM(str(s.id_sitio_trabajo))) " +
"join cliente_general c on s.id_cliente_general=c.id_cliente_general " +
"where p.id_personal = pe.id_personal and (a.fecha between @DESDE and @HASTA) " +
"group by c.nompre_razon_social_cliente_general, s.nombre_sitio_trabajo, a.fecha,s.grupo order by a.fecha desc) GRUPO, " +
"co.RESERVA_ROL, co.XIII_ROL, co.XIV_ROL, co.REC_EXT, co.ACUM_FON_RES, case when co.id_proyecto = 58 then  0 else co.DESC_SEG end as DESC_SEG, " +
"(select top 1  s.decimo_extra from asignacion_personal a " +
"join personal p on a.id_personal = p.id_personal " +
"join sitios_trabajo s on a.id_puesto = LTRIM(RTRIM(str(s.id_sitio_trabajo))) " +
"join cliente_general c on s.id_cliente_general=c.id_cliente_general " +
"where p.id_personal = pe.id_personal and (a.fecha between @DESDE and @HASTA) " +
"group by c.nompre_razon_social_cliente_general, s.nombre_sitio_trabajo, a.fecha, s.decimo_extra order by a.fecha desc) XIII_SBU_EXT, " +
stat + " ESTADO_PERSONAL, cp.id_banco, bc.nombre_banco, cp.num_cuenta, cp.tipo, pe.fecha_nacimiento, pe.ciudad, (select top 1 s.id_sitio_trabajo from asignacion_personal a join personal p on a.id_personal = p.id_personal join sitios_trabajo s on a.id_puesto = LTRIM(RTRIM(str(s.id_sitio_trabajo))) join cliente_general c on s.id_cliente_general=c.id_cliente_general where p.id_personal = pe.id_personal and (a.fecha between @DESDE and @HASTA) group by c.nompre_razon_social_cliente_general, s.id_sitio_trabajo, a.fecha order by a.fecha desc) IDSITIO, CO.EXTSAL " +
"from asignacion_personal ap " +
"join sitios_trabajo s on ap.id_puesto=s.id_sitio_trabajo " + 
"join personal pe on ap.id_personal = pe.id_personal " +
"join contrato co on pe.id_personal = co.id_personal " +
"join area_general ar on pe.id_area = ar.id_area_general " +
"join cargo_ocupacional cr on pe.id_cargo_ocupacional=cr.id_cargo_ocupacional " +
"join gerencias_general gg on ar.id_gerencias_general = gg.id_gerencias_general " +
"join cuentas_personal cp on pe.id_personal = cp.id_personal join bancos bc on cp.id_banco = bc.id_banco " +
"where " + esta + "group by pe.id_personal, pe.apellidos, pe.nombres, pe.cedula, pe.fecha_nacimiento, pe.ciudad, pe.fecha_entrada, cr.descripcion, ar.nombre_area, pe.sueldo,co.RESERVA_ROL, co.XIII_ROL, co.XIV_ROL, co.REC_EXT, co.ACUM_FON_RES, co.DESC_SEG, co.ID_PROYECTO, ESTADO_PERSONAL, cp.id_banco, bc.nombre_banco, cp.num_cuenta, cp.tipo, CO.EXTSAL) as datos " +
            gr + " order by sitio, nomina;";

            pars.Add(new object[] { "DESDE", SqlDbType.DateTime, desded });
            pars.Add(new object[] { "HASTA", SqlDbType.DateTime, hastad });

            if (!string.IsNullOrEmpty(group)) pars.Add(new object[] { "GRUPO", SqlDbType.VarChar, group });
            if (!activos) pars.Add(new object[] { "DESDEX", SqlDbType.DateTime, desded });

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        }
         
        public DataTable SeleccionarRolesPorMesAnio(TipoConexion tipoCon, int mes, int anio)
        {
            var pars = new List<object[]>
            {
                new object[] { "MES", SqlDbType.DateTime, mes } ,
                new object[] { "ANIO", SqlDbType.Date, anio } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select r.ID_ROL ID, r.FECHA_ELAB ELABORADO, r.mes_rol, dbo.MesEnLetrasPorNumero(r.mes_rol) MES, r.anio_rol AÑO, r.quincena, (case r.tipo when 0 then 'OPERATIVO ' + r.grupo when 1 then 'ADMINISTRATIVO' else '-- TODOS --' end) PERSONAL, (case r.quincena when 0 then 'QUINCENA / ANTICIPO' else 'MENSUAL' end) PERIODO, r.DESDE, r.HASTA, case when r.grupo = 'GENERAL' then (select SUM(d.neto_rol) from detalles_rol d where d.id_rol=r.id_rol and (d.grupo = 'GENERAL' OR d.grupo = 'RETIRADOS' )and d.cliente like 'TOTAL %') else (select d.neto_rol from detalles_rol d where d.id_rol=r.id_rol and d.grupo = r.grupo and d.cliente like 'TOTAL %') end TOTAL, r.estado, (case estado when 1 then 'EN PROCESO' when 2 then 'VALIDADO' else 'ANULADO' end) DETALLE, r.OBSERVACION, r.FECHA_VAL VALIDADO, r.retenidos, r.grupo from rol_pago r where r.ESTADO > 0 AND r.quincena = 1 AND r.mes_rol= @MES AND r.anio_rol = @ANIO;", false, pars);
        }

        public DataTable SeleccionarRolesPorFecha(TipoConexion tipoCon, DateTime desde, DateTime hasta)
        {
            var pars = new List<object[]>
            {
                new object[] { "DESDE", SqlDbType.DateTime, desde } ,
                new object[] { "HASTA", SqlDbType.Date, hasta } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select r.ID_ROL ID, r.FECHA_ELAB ELABORADO, r.mes_rol, dbo.MesEnLetrasPorNumero(r.mes_rol) MES, r.anio_rol AÑO, r.quincena, (case r.tipo when 0 then 'OPERATIVO ' + r.grupo when 1 then 'ADMINISTRATIVO' else '-- TODOS --' end) PERSONAL, (case r.quincena when 0 then 'QUINCENA / ANTICIPO' else 'MENSUAL' end) PERIODO, r.DESDE, r.HASTA, case when r.grupo = 'GENERAL' then (select SUM(d.neto_rol) from detalles_rol d where d.id_rol=r.id_rol and (d.grupo = 'GENERAL' OR d.grupo = 'RETIRADOS' )and d.cliente like 'TOTAL %') else (select d.neto_rol from detalles_rol d where d.id_rol=r.id_rol and d.grupo = r.grupo and d.cliente like 'TOTAL %') end TOTAL, r.estado, (case r.estado when 1 then 'EN PROCESO' when 2 then 'VALIDADO' else 'ANULADO' end) DETALLE, r.OBSERVACION, r.FECHA_VAL VALIDADO, r.retenidos, r.grupo from rol_pago r where r.ESTADO > 0 AND (r.fecha_ELAB between @desde and @hasta);", false, pars);
        }

        public DataTable SeleccionarPersonalRetenidosRolPago(TipoConexion tipoCon, int idr)
        {
            var pars = new List<object[]>
            {
                   new object[] { "idrol", SqlDbType.Int, idr } 
            };
            return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select retenidos from rol_pago where id_rol = @idrol", false, pars) ;
        }

        public int BuscarMayorIdRolPago(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_rol=CASE WHEN MAX(id_rol) IS NULL THEN 0 ELSE MAX(id_rol) End FROM ROL_PAGO", false);
            return data.Rows.Count == 0 ? 0 : Convert.ToInt32(data.Rows[0]["id_rol"]);
        }
         
        public SqlCommand GuardarRolPagoCommand()
        {
            //CASE WHEN @grupo = 'CUERPO DE BOMBEROS VOLUNTARIOS DE CUENCA' THEN 0.0 ELSE @OTROS_DESC_VIGI END
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into ROL_PAGO (id_rol, fecha_elab, mes_rol, anio_rol, quincena, desde, hasta, estado, observacion, fecha_val, tipo, auxfil,SUELDO_VIGILANTES,COSTO_HORAS,COSTO_HORAS_50,COSTO_HORAS_100,PORCEN_APORTE_PATRONAL,PROCEN_APORTE_PERSONAL,PROCENTAJE_FONDO_RESERVA,SUELDO_BASICO_UNIFICADO,OTROS_DESC_VIGI,OTROS_DESC_ADMI,ANTICIPO_UTILIDAD_MES,VALOR_ANTICIPO_GUARDIAS, grupo, porcentaje_des_med, porcentaje_ext_sal) " +
                        "values (@id_rol, @fecha_elab, @mes_rol, @anio_rol, @quincena, @desde, @hasta, @estado, @observacion, @fecha_val, @tipo, @auxfil, @SUELDO_VIGILANTES,@COSTO_HORAS,@COSTO_HORAS_50,@COSTO_HORAS_100,@PORCEN_APORTE_PATRONAL,@PROCEN_APORTE_PERSONAL,@PROCENTAJE_FONDO_RESERVA,@SUELDO_BASICO_UNIFICADO,@OTROS_DESC_VIGI,@OTROS_DESC_ADMI,@ANTICIPO_UTILIDAD_MES,@VALOR_ANTICIPO_GUARDIAS, @grupo, @porcentaje_des_med, @porcentaje_ext_sal);"
            };
            cmd.Parameters.AddWithValue("@id_rol", SqlDbType.Int).Value = IdRol;
            cmd.Parameters.AddWithValue("@fecha_elab", SqlDbType.Date).Value = FechaElaboracion;
            cmd.Parameters.AddWithValue("@mes_rol", SqlDbType.Int).Value = Mes;
            cmd.Parameters.AddWithValue("@anio_rol", SqlDbType.Int).Value = Anio;
            cmd.Parameters.AddWithValue("@quincena", SqlDbType.Int).Value = Quincena;
            cmd.Parameters.AddWithValue("@desde", SqlDbType.Date).Value = Desde;
            cmd.Parameters.AddWithValue("@hasta", SqlDbType.Date).Value = Hasta;
            cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Estado;
            cmd.Parameters.AddWithValue("@observacion", SqlDbType.Text).Value = Observacion;
            cmd.Parameters.AddWithValue("@fecha_val", SqlDbType.Date).Value = FechaValidacion;
            cmd.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = Tipo;
            cmd.Parameters.AddWithValue("@auxfil", SqlDbType.Int).Value = CantFil;

            cmd.Parameters.AddWithValue("@SUELDO_VIGILANTES", SqlDbType.Decimal).Value = SueldoVigilantes;
            cmd.Parameters.AddWithValue("@COSTO_HORAS", SqlDbType.Decimal).Value = CostoHorasNoral;
            cmd.Parameters.AddWithValue("@COSTO_HORAS_50", SqlDbType.Decimal).Value = CostoHoras50;
            cmd.Parameters.AddWithValue("@COSTO_HORAS_100", SqlDbType.Decimal).Value = CostoHoras100;
            cmd.Parameters.AddWithValue("@PORCEN_APORTE_PATRONAL", SqlDbType.Decimal).Value = PorcentajePatronalIess;
            cmd.Parameters.AddWithValue("@PROCEN_APORTE_PERSONAL", SqlDbType.Decimal).Value = PorcentajePersonalIess;
            cmd.Parameters.AddWithValue("@PROCENTAJE_FONDO_RESERVA", SqlDbType.Decimal).Value = PorcentajeFondoReserva;
            cmd.Parameters.AddWithValue("@SUELDO_BASICO_UNIFICADO", SqlDbType.Decimal).Value = SueldoBasico;
            cmd.Parameters.AddWithValue("@OTROS_DESC_VIGI", SqlDbType.Decimal).Value = OtrosDescuentosOperativos;
            cmd.Parameters.AddWithValue("@OTROS_DESC_ADMI", SqlDbType.Decimal).Value = OtrosDescuentosAdmin;
            cmd.Parameters.AddWithValue("@ANTICIPO_UTILIDAD_MES", SqlDbType.Decimal).Value = AnticipoUtilidad;
            cmd.Parameters.AddWithValue("@VALOR_ANTICIPO_GUARDIAS", SqlDbType.Decimal).Value = AnticipoGuardias;
            cmd.Parameters.AddWithValue("@grupo", SqlDbType.VarChar).Value = Grupo;
            cmd.Parameters.AddWithValue("@porcentaje_des_med", SqlDbType.Decimal).Value = PorcentajeDescansoMedico;
            cmd.Parameters.AddWithValue("@porcentaje_ext_sal", SqlDbType.Decimal).Value = PorcentajeExtensionSalud;
            return cmd;
        }

        public SqlCommand ModificarRolPagoCommand(int idrol)
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update ROL_PAGO set observacion=@observacion where id_rol=@id_rol;"
            };
            cmd.Parameters.AddWithValue("@id_rol", SqlDbType.Int).Value = idrol;
            cmd.Parameters.AddWithValue("@observacion", SqlDbType.Text).Value = Observacion;
            return cmd;
        }

        public SqlCommand DeleteDetallesRolByIdRolPagoCommand(int idrol)
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "delete from detalles_rol where id_rol=@id_rol;"
            };
            cmd.Parameters.AddWithValue("@id_rol", SqlDbType.Int).Value = idrol;
            return cmd;
        }

        public SqlCommand ValidarByIdRolPagoCommand(int idrol)
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update rol_pago set estado=2, fecha_val = @fecha where id_rol=@id_rol;"
            };
            cmd.Parameters.AddWithValue("@id_rol", SqlDbType.Int).Value = idrol;
            cmd.Parameters.AddWithValue("@fecha", SqlDbType.Date).Value = FechaValidacion;
            return cmd;
        }

        public SqlCommand AnularByIdRolPagoCommand(int idrol)
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update rol_pago set estado=0 where id_rol=@id_rol; update detalles_rol set est=0 where id_rol=@id_rol;"
            };
            cmd.Parameters.AddWithValue("@id_rol", SqlDbType.Int).Value = idrol; 
            return cmd;
        }

        public SqlCommand GuardarRetenidosRolPagoCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update ROL_PAGO set retenidos = @retenidos where id_rol = @id_rol;"
            };
            cmd.Parameters.AddWithValue("@id_rol", SqlDbType.Int).Value = IdRol;
            cmd.Parameters.AddWithValue("@retenidos", SqlDbType.Text).Value = Retenidos;
            return cmd;
        }

        public DataTable SeleccionarDetallesPersonalRolPorIdPersonal(TipoConexion tipoCon, long idp)
        {
            var sql = "select top 1 *, case when a.id_gerencias_general = 1 then pe.sueldo else (select sueldo_vigilantes from parametros_rol_pago) end salario from personal pe join contrato co on pe.id_personal = co.id_personal join area_general a on pe.id_area = a.id_area_general left join cuentas_personal cu on pe.id_personal = cu.id_personal left join bancos ba on cu.id_banco=ba.id_banco where pe.id_personal = " + idp + " order by co.fecha_inicial_contrato desc;";
            //var sql = "select top 1 *, case when a.id_gerencias_general = 1 then pe.sueldo else (select sueldo_vigilantes from parametros_rol_pago) end salario from personal pe join contrato co on pe.id_personal = co.id_personal join area_general a on pe.id_area = a.id_area_general left join cuentas_personal cu on pe.id_personal = cu.id_personal left join bancos ba on cu.id_banco=ba.id_banco where pe.id_personal = " + idp + " order by co.fecha_inicial_contrato desc;";
            return  ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, false);
        }

        public DataTable SeleccionarDetallesDescuentosIdPersonalRolPago(TipoConexion tipoCon, int mes, int anio, int idper)
        {
            var pars = new List<object[]>
            {
                new object[] { "mes", SqlDbType.Int, mes },
                new object[] { "anio", SqlDbType.Int, anio },
                new object[] { "idper", SqlDbType.Int, idper }
            };
            var sql = "select id_personal,  " +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 12) then valor else 0 end) adicional," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 13) then valor else 0 end) otrosing," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 0) then valor else 0 end) quirografario," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 1) then valor else 0 end) hipotecario," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 2) then valor else 0 end) saludconyuge," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 3) then valor else 0 end) emergente," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 4) then valor else 0 end) capaseg," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 5) then valor else 0 end) varios," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 6) then valor else 0 end) empresa," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 7) then valor else 0 end) comecsa," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 8) then valor else 0 end) comisariato," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 9) then valor else 0 end) bodegaseg," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 10) then valor else 0 end) multas," +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 11) then valor else 0 end) otros, " +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 12) then valor else 0 end) pension, " +
                    "(select top 1 dr.neto_rol from detalles_rol dr join rol_pago rp on dr.id_rol=rp.id_rol where dr.id_personal=de.id_personal and rp.mes_rol = 1 and rp.anio_rol=2020 and rp.quincena=0 and rp.tipo=0 and rp.estado > 0 order by rp.fecha_elab desc ) quincena, " +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 13) then valor else 0 end) pensionxiii, " +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 14) then valor else 0 end) pensionxiv, " +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 15) then valor else 0 end) almuerzo, " +
                    "sum(case when (estado = 1 and procesado=0 and mes_rol=" + mes + " and anio_rol = " + anio + " and tipo = 15) then valor else 0 end) diasnolab " +
                    "from descuentos_rol de where id_personal = @idper and mes_rol = @mes and anio_rol = @anio group by id_personal";

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        }

        public DataTable SeleccionarDetallesDescuentosPersonalRolPago(TipoConexion tipoCon, int mes, int anio, int tipo)
        {
            var pars = new List<object[]>
            {
                new object[] { "mes", SqlDbType.Int, mes },
                new object[] { "anio", SqlDbType.Int, anio },
                new object[] { "tipo", SqlDbType.Int, tipo }
            };
            var sql = "select de.id_personal, " +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 12) then valor else 0 end) adicional," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 0) then valor else 0 end) quirografario," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 13) then valor else 0 end) otrosing," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 1) then valor else 0 end) hipotecario," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 2) then valor else 0 end) saludconyuge," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 3) then valor else 0 end) emergente," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 4) then valor else 0 end) capaseg," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 5) then valor else 0 end) varios," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 6) then valor else 0 end) empresa," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 7) then valor else 0 end) comecsa," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 8) then valor else 0 end) comisariato," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 9) then valor else 0 end) bodegaseg," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 10) then valor else 0 end) multas," +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 11) then valor else 0 end) otros, " +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 12) then valor else 0 end) pension, " +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 13) then valor else 0 end) pensionxiii, " +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 14) then valor else 0 end) pensionxiv, " +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 15) then valor else 0 end) almuerzo, " +
                    "sum(case when (de.estado = 1 and de.procesado=0 and de.mes_rol=" + mes + " and de.anio_rol = " + anio + " and de.tipo = 16) then valor else 0 end) diasnolab " +                    
                    "from descuentos_rol de " +
                    "join personal pe on de.id_personal = pe.id_personal join area_general ar on pe.id_area = ar.id_area_general join gerencias_general ge on ar.id_gerencias_general = ge.id_gerencias_general "+
                    "where de.mes_rol = @mes and de.anio_rol = @anio and ge.id_gerencias_general = @tipo group by de.id_personal";

            return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        }

        public DataTable SeleccionarDetallesQuincenaPersonalRolPago(TipoConexion tipoCon, int mes, int anio, int tipo)
        {
            var pars = new List<object[]>
            {
                new object[] { "mes", SqlDbType.Int, mes },
                new object[] { "anio", SqlDbType.Int, anio },
                new object[] { "tipo", SqlDbType.Int, tipo }
            };
            var sql = "select dr.id_personal, dr.neto_rol from detalles_rol dr join rol_pago rp on dr.id_rol=rp.id_rol " +
                      "where rp.mes_rol =@mes and rp.anio_rol=@anio and rp.quincena=0 and rp.tipo=@tipo and rp.estado > 0";

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        }

        public DataTable SeleccionarDetallesParametrosPersonal(TipoConexion tipoCon)
        {
            var sql = "select p.id_personal,c.RESERVA_ROL,c.XIII_ROL,c.XIV_ROL,c.ACUM_FON_RES,c.DESC_SEG, " + // c.XIII_SBU_EXT, c.FORES_EXT,
                      "x.id_banco, b.nombre_banco, x.num_cuenta, x.tipo, p.fecha_entrada,g.descripcion, r.nombre_area, " +
                      "case when r.id_gerencias_general = 1 then p.sueldo else (select sueldo_vigilantes from parametros_rol_pago) end sueldo, " +
                      "p.fecha_nacimiento, p.ciudad, c.extsal from personal p left join cargo_ocupacional g on p.id_cargo_ocupacional=g.id_cargo_ocupacional " +
                      "left join area_general r on p.id_area=r.id_area_general left join contrato c on p.id_personal = c.id_personal " +
                      "left join cuentas_personal x on p.id_personal = x.id_personal  join bancos b on x.id_banco = b.id_banco where p.estado_personal = 1 and c.estado_contrato = 'VIGENTE';";
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, false);
        }
    }
}
