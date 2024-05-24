using System;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql; 

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassParametrosRol
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
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
        public double PorcentajeDescansoMedico { get; set; }
        public double PorcentajeExtensionSalud { get; set; }

        public ClassParametrosRol SeleccionarParametrosRolesByIdRol(TipoConexion tipoCon, int idrol)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select * from rol_pago where id_rol=" + idrol + ";", false);
            if (data.Rows.Count == 0) return null;
            return new ClassParametrosRol
            {
                SueldoBasico = Convert.ToDouble(data.Rows[0]["SUELDO_BASICO_UNIFICADO"]),
                SueldoVigilantes = Convert.ToDouble(data.Rows[0]["SUELDO_VIGILANTES"]),
                CostoHorasNoral = Convert.ToDouble(data.Rows[0]["COSTO_HORAS"]),
                CostoHoras50 = Convert.ToDouble(data.Rows[0]["COSTO_HORAS_50"]),
                CostoHoras100 = Convert.ToDouble(data.Rows[0]["COSTO_HORAS_100"]),
                PorcentajePatronalIess = Convert.ToDouble(data.Rows[0]["PORCEN_APORTE_PATRONAL"]),
                PorcentajePersonalIess = Convert.ToDouble(data.Rows[0]["PROCEN_APORTE_PERSONAL"]),
                PorcentajeFondoReserva = Convert.ToDouble(data.Rows[0]["PROCENTAJE_FONDO_RESERVA"]),
                OtrosDescuentosOperativos = Convert.ToDouble(data.Rows[0]["OTROS_DESC_VIGI"]),
                OtrosDescuentosAdmin = Convert.ToDouble(data.Rows[0]["OTROS_DESC_ADMI"]),
                AnticipoUtilidad = Convert.ToDouble(data.Rows[0]["ANTICIPO_UTILIDAD_MES"]),
                AnticipoGuardias = Convert.ToDouble(data.Rows[0]["VALOR_ANTICIPO_GUARDIAS"]),
                QuinceAdminEsSueldoMasExtra = Convert.ToInt32(data.Rows[0]["QUINCE_AD_SB_EX"]),
                PorcentajeDescansoMedico = Convert.ToDouble(data.Rows[0]["PORCENTAJE_DES_MED"]),
                PorcentajeExtensionSalud = Convert.ToDouble(data.Rows[0]["PORCENTAJE_EXT_SAL"])
            };
        }

        public ClassParametrosRol SeleccionarParametrosActualesRoles(TipoConexion tipoCon)
        {
            var data =   ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select * from parametros_rol_pago;", false) ;
            if (data.Rows.Count == 0) return null;
            return new ClassParametrosRol
            {
                SueldoBasico = Convert.ToDouble(data.Rows[0]["SUELDO_BASICO_UNIFICADO"]),
                SueldoVigilantes = Convert.ToDouble(data.Rows[0]["SUELDO_VIGILANTES"]),
                CostoHorasNoral = Convert.ToDouble(data.Rows[0]["COSTO_HORAS"]),
                CostoHoras50 = Convert.ToDouble(data.Rows[0]["COSTO_HORAS_50"]),
                CostoHoras100 = Convert.ToDouble(data.Rows[0]["COSTO_HORAS_100"]),
                PorcentajePatronalIess = Convert.ToDouble(data.Rows[0]["PORCEN_APORTE_PATRONAL"]),
                PorcentajePersonalIess = Convert.ToDouble(data.Rows[0]["PROCEN_APORTE_PERSONAL"]),
                PorcentajeFondoReserva = Convert.ToDouble(data.Rows[0]["PROCENTAJE_FONDO_RESERVA"]),
                OtrosDescuentosOperativos = Convert.ToDouble(data.Rows[0]["OTROS_DESC_VIGI"]),
                OtrosDescuentosAdmin = Convert.ToDouble(data.Rows[0]["OTROS_DESC_ADMI"]),
                AnticipoUtilidad = Convert.ToDouble(data.Rows[0]["ANTICIPO_UTILIDAD_MES"]),
                AnticipoGuardias = Convert.ToDouble(data.Rows[0]["VALOR_ANTICIPO_GUARDIAS"]),
                QuinceAdminEsSueldoMasExtra = Convert.ToInt32(data.Rows[0]["QUINCE_AD_SB_EX"]),
                PorcentajeDescansoMedico = Convert.ToDouble(data.Rows[0]["PORCENTAJE_DES_MED"]),
                PorcentajeExtensionSalud = Convert.ToDouble(data.Rows[0]["PORCENTAJE_EXT_SAL"])
            };
        }
    }
}
