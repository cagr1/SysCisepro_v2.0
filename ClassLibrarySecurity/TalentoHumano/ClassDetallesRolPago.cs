using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassDetallesRol
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public string Grupo { get; set; }
        public int IdPersonal { get; set; }
        public int Num { get; set; }
        public string Cliente { get; set; }
        public string Ubicacion { get; set; }
        public string Nomina { get; set; }
        public string Cedula { get; set; }
        public DateTime Ingreso { get; set; }
        public string Cargo { get; set; }
        public string Area { get; set; }
        public double SueldoBase { get; set; }
        public int DiasTrabaja { get; set; }
        public double SueldoDiasTrabaja { get; set; }
        public int DiasDescansoMedico { get; set; }
        public double SueldoDescansoMedico { get; set; }
        public double SueldoTrabajaMasDesMedico { get; set; }
        public double HorasN { get; set; }
        public double CostoHorasN { get; set; }
        public double TotalHorasN { get; set; }
        public double HorasSup { get; set; }
        public double CostoHorasSup { get; set; }
        public double TotalHorasSup { get; set; }
        public double HorasExt { get; set; }
        public double CostoHorasExt { get; set; }
        public double TotalHorasExt { get; set; }
        public double HorasExtf { get; set; }
        public double CostoHorasExtf { get; set; }
        public double TotalHorasExtf { get; set; }
        public double RecargoNocturno { get; set; }
        public double Adicional { get; set; }
        public double OtroIngreos { get; set; }
        public double TotalExt { get; set; }
        public double IngresosMasExt { get; set; }
        public double Xiii { get; set; }
        public double XiiiPension { get; set; }
        public double Xiv { get; set; }
        public double XivPension { get; set; }
        public double FondoRes { get; set; }
        public double FondoResMesant { get; set; }
        public double TotBenef { get; set; }
        public double TotIngresos { get; set; }
        public string Espacio { get { return "-"; } }
        public double DescIess { get; set; }
        public double DescQuiAnt { get; set; }
        public double DescQuiro { get; set; }
        public double DescHipot { get; set; }
        public double DescExtSalCon { get; set; }
        public double DescAntEme { get; set; }
        public double DescCapaSeg { get; set; }
        public double DescAntVar { get; set; }
        public double DescPresEmp { get; set; }
        public double DescComec { get; set; }
        public double DescComis { get; set; }
        public double DesEquipoSegu { get; set; }
        public double DesAlmuerzo { get; set; }
        public double Des10moPension { get; set; }
        public double DesPensionAlim { get; set; }
        public double DesMulta { get; set; }
        public double DescOtros { get; set; }
        public double TotalDescuentos { get; set; }
        public double NetoRecibir { get; set; }
        public double Extra { get; set; }
        public int Fonres { get; set; }
        public int XiiiRol { get; set; }
        public int XivRol { get; set; }
        public int Acufor { get; set; }
        public int Deseg { get; set; }
        public int XiiiSe { get; set; }
        public int Idbanco { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string Tipban { get; set; }
        public int Esta { get; set; }
         
        public int IdRol { get; set; }
        public int IdDetaRol { get; set; }
        public int TipoFila { get; set; }

        public DateTime FechaNacim { get; set; }
        public string Ciudad { get; set; }

        public double ValorAcumuladoFonRes { get; set; }

        public int ExtSal { get; set; }
        public int ExtEdit { get; set; }
        public int Firma { get; set; }
        public double DescDiasNoLaborados { get; set; }

        public double DescDifDecFon { get; set; }

        public int BuscarMayorIdDetalleRolPago(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_deta_rol=CASE WHEN MAX(id_deta_rol) IS NULL THEN 0 ELSE MAX(id_deta_rol) End FROM DETALLES_ROL", false);
            return data.Rows.Count == 0 ? 0 : Convert.ToInt32(data.Rows[0]["id_deta_rol"]);
        }

        public int BuscarMayorIdDetalleRol(TipoConexion tipoCon)
        { 
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "BuscarMayorIdetarol",true);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0]["id_deta_rol"]);
        
        }

        public DataTable SeleccionarDatosRolPago(TipoConexion tipoCon, int idr)
        {
            var pars = new List<object[]>
            {
                new object[] { "id_rol", SqlDbType.Int, idr } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select detalles_rol.*, personal.estado_personal from detalles_rol join personal on detalles_rol.id_personal = personal.id_personal where id_rol = @id_rol order by id_deta_rol;", false, pars);
        }

        public SqlCommand GuardarDetalleRolPagoCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into DETALLES_ROL (grupo, id_personal, num, cliente, ubicacion, nomina, cedula, ingreso, cargo,area,sueldob,diast,sueldodt,diasdm,sueldodm,sueldodtdm,"+
                "hnor,cos_hnor,tot_hnor,hsup,cos_hsup,tot_hsup,hext,cos_hext,tot_hext,hextf,cos_hextf,tot_hextf,rec_noturno,adicional,ot_ing,tot_ext,ing_ext,xiii,xiii_pension,xiv,xiv_pension,fon_res,fon_res_ant,tot_ben,"+
                "tot_ing,espacio,desc_iess,quin_ante,desc_quir,desc_hip,desc_exsc,ant_eme,desc_capa,ant_vari,desc_prem,desc_comc,desc_comi, desc_equip,desc_pension,desc_vivi,desc_multas,ot_desc,tot_desc,neto_rol,extra,fonres,"+
                "xiiirol,xivrol,acufor,deseg,xiisex,id_banco,banco,cuenta,tipo_banco,est,id_rol,id_deta_rol,tipo, f_nacim, ciudad, val_acum_fon_res, desc_almuerzo, extsal, desc_diasnolab, dif_dec_fon, extedit) " +
                "values (@grupo, @id_personal, @num, @cliente, @ubicacion, @nomina, @cedula, @ingreso, @cargo,@area,@sueldob,@diast,@sueldodt,@diasdm,@sueldodm,@sueldodtdm," +
                "@hnor,@cos_hnor,@tot_hnor,@hsup,@cos_hsup,@tot_hsup,@hext,@cos_hext,@tot_hext,@hextf,@cos_hextf,@tot_hextf,@rec_noturno,@adicional,@ot_ing,@tot_ext,@ing_ext,@xiii,@xiii_pension,@xiv,@xiv_pension,@fon_res,@fon_res_ant,@tot_ben," +
                "@tot_ing,@espacio,@desc_iess,@quin_ante,@desc_quir,@desc_hip,@desc_exsc,@ant_eme,@desc_capa,@ant_vari,@desc_prem,@desc_comc,@desc_comi, @desc_equip,@desc_pension,@desc_vivi,@desc_multas,@ot_desc,@tot_desc,@neto_rol,@extra,@fonres," +
                "@xiiirol,@xivrol,@acufor,@deseg,@xiisex,@id_banco,@banco,@cuenta,@tipo_banco,@est,@id_rol,@id_deta_rol,@tipo, @fnac, @ciud, @val_acum_fon_res, @desc_almuerzo, @extsal, @desc_diasnolab, @dif_dec_fon, @extedit);"
            };

            cmd.Parameters.AddWithValue("@grupo", SqlDbType.VarChar).Value = Grupo;
            cmd.Parameters.AddWithValue("@id_personal", SqlDbType.Int).Value = IdPersonal;
            cmd.Parameters.AddWithValue("@num", SqlDbType.Int).Value = Num;
            cmd.Parameters.AddWithValue("@cliente", SqlDbType.VarChar).Value = Cliente;
            cmd.Parameters.AddWithValue("@ubicacion", SqlDbType.VarChar).Value = Ubicacion;
            cmd.Parameters.AddWithValue("@nomina", SqlDbType.VarChar).Value = Nomina;
            cmd.Parameters.AddWithValue("@cedula", SqlDbType.VarChar).Value = Cedula;
            cmd.Parameters.AddWithValue("@ingreso", SqlDbType.DateTime).Value = Ingreso;
            cmd.Parameters.AddWithValue("@cargo", SqlDbType.VarChar).Value = Cargo;
            cmd.Parameters.AddWithValue("@area", SqlDbType.VarChar).Value = Area;
            cmd.Parameters.AddWithValue("@sueldob", SqlDbType.Decimal).Value = SueldoBase;
            cmd.Parameters.AddWithValue("@diast", SqlDbType.Int).Value = DiasTrabaja;
            cmd.Parameters.AddWithValue("@sueldodt", SqlDbType.Decimal).Value = SueldoDiasTrabaja;
            cmd.Parameters.AddWithValue("@diasdm", SqlDbType.Int).Value = DiasDescansoMedico;
            cmd.Parameters.AddWithValue("@sueldodm", SqlDbType.Decimal).Value = SueldoDescansoMedico;
            cmd.Parameters.AddWithValue("@sueldodtdm", SqlDbType.Decimal).Value = SueldoTrabajaMasDesMedico;
            cmd.Parameters.AddWithValue("@hnor", SqlDbType.Decimal).Value = HorasN;
            cmd.Parameters.AddWithValue("@cos_hnor", SqlDbType.Decimal).Value = CostoHorasN;
            cmd.Parameters.AddWithValue("@tot_hnor", SqlDbType.Decimal).Value = TotalHorasN;
            cmd.Parameters.AddWithValue("@hsup", SqlDbType.Decimal).Value = HorasSup;
            cmd.Parameters.AddWithValue("@cos_hsup", SqlDbType.Decimal).Value = CostoHorasSup;
            cmd.Parameters.AddWithValue("@tot_hsup", SqlDbType.Decimal).Value = TotalHorasSup;
            cmd.Parameters.AddWithValue("@hext", SqlDbType.Decimal).Value = HorasExt;
            cmd.Parameters.AddWithValue("@cos_hext", SqlDbType.Decimal).Value = CostoHorasExt;
            cmd.Parameters.AddWithValue("@tot_hext", SqlDbType.Decimal).Value = TotalHorasExt;
            cmd.Parameters.AddWithValue("@hextf", SqlDbType.Decimal).Value = HorasExtf;
            cmd.Parameters.AddWithValue("@cos_hextf", SqlDbType.Decimal).Value = CostoHorasExtf;
            cmd.Parameters.AddWithValue("@tot_hextf", SqlDbType.Decimal).Value = TotalHorasExtf;
            cmd.Parameters.AddWithValue("@rec_noturno", SqlDbType.Decimal).Value = RecargoNocturno;
            cmd.Parameters.AddWithValue("@adicional", SqlDbType.Decimal).Value = Adicional;
            cmd.Parameters.AddWithValue("@ot_ing", SqlDbType.Decimal).Value = OtroIngreos;
            cmd.Parameters.AddWithValue("@tot_ext", SqlDbType.Decimal).Value = TotalExt;
            cmd.Parameters.AddWithValue("@ing_ext", SqlDbType.Decimal).Value = IngresosMasExt;
            cmd.Parameters.AddWithValue("@xiii", SqlDbType.Decimal).Value = Xiii;
            cmd.Parameters.AddWithValue("@xiii_pension", SqlDbType.Decimal).Value = XiiiPension;
            cmd.Parameters.AddWithValue("@xiv", SqlDbType.Decimal).Value = Xiv;
            cmd.Parameters.AddWithValue("@xiv_pension", SqlDbType.Decimal).Value = XivPension;
            cmd.Parameters.AddWithValue("@fon_res", SqlDbType.Decimal).Value = FondoRes;
            cmd.Parameters.AddWithValue("@fon_res_ant", SqlDbType.Decimal).Value = FondoResMesant;
            cmd.Parameters.AddWithValue("@tot_ben", SqlDbType.Decimal).Value = TotBenef;
            cmd.Parameters.AddWithValue("@tot_ing", SqlDbType.Decimal).Value = TotIngresos;
            
            cmd.Parameters.AddWithValue("@espacio", SqlDbType.VarChar).Value = Espacio;
            
            cmd.Parameters.AddWithValue("@desc_iess", SqlDbType.Decimal).Value = DescIess;
            cmd.Parameters.AddWithValue("@quin_ante", SqlDbType.Decimal).Value = DescQuiAnt;
            cmd.Parameters.AddWithValue("@desc_quir", SqlDbType.Decimal).Value = DescQuiro;
            cmd.Parameters.AddWithValue("@desc_hip", SqlDbType.Decimal).Value = DescHipot;
            cmd.Parameters.AddWithValue("@desc_exsc", SqlDbType.Decimal).Value = DescExtSalCon;
            cmd.Parameters.AddWithValue("@ant_eme", SqlDbType.Decimal).Value = DescAntEme;
            cmd.Parameters.AddWithValue("@desc_capa", SqlDbType.Decimal).Value = DescCapaSeg;
            cmd.Parameters.AddWithValue("@ant_vari", SqlDbType.Decimal).Value = DescAntVar;
            cmd.Parameters.AddWithValue("@desc_prem", SqlDbType.Decimal).Value = DescPresEmp;
            cmd.Parameters.AddWithValue("@desc_comc", SqlDbType.Decimal).Value = DescComec;
            cmd.Parameters.AddWithValue("@desc_comi", SqlDbType.Decimal).Value = DescComis;
            cmd.Parameters.AddWithValue("@desc_equip", SqlDbType.Decimal).Value = DesEquipoSegu;
            cmd.Parameters.AddWithValue("@desc_pension", SqlDbType.Decimal).Value = Des10moPension;
            cmd.Parameters.AddWithValue("@desc_vivi", SqlDbType.Decimal).Value = DesPensionAlim;
            cmd.Parameters.AddWithValue("@desc_multas", SqlDbType.Decimal).Value = DesMulta;
            cmd.Parameters.AddWithValue("@ot_desc", SqlDbType.Decimal).Value = DescOtros;
            cmd.Parameters.AddWithValue("@tot_desc", SqlDbType.Decimal).Value = TotalDescuentos;
            cmd.Parameters.AddWithValue("@neto_rol", SqlDbType.Decimal).Value = NetoRecibir;
            cmd.Parameters.AddWithValue("@extra", SqlDbType.Decimal).Value = Extra;

            cmd.Parameters.AddWithValue("@fonres", SqlDbType.Int).Value = Fonres;
            cmd.Parameters.AddWithValue("@xiiirol", SqlDbType.Int).Value = XiiiRol;
            cmd.Parameters.AddWithValue("@xivrol", SqlDbType.Int).Value = XivRol;
            cmd.Parameters.AddWithValue("@acufor", SqlDbType.Int).Value = Acufor;
            cmd.Parameters.AddWithValue("@deseg", SqlDbType.Int).Value = Deseg;
            cmd.Parameters.AddWithValue("@xiisex", SqlDbType.Int).Value = XiiiSe;
           
            cmd.Parameters.AddWithValue("@id_banco", SqlDbType.Int).Value = Idbanco;
            cmd.Parameters.AddWithValue("@banco", SqlDbType.VarChar).Value = Banco;
            cmd.Parameters.AddWithValue("@cuenta", SqlDbType.VarChar).Value = Cuenta;
            cmd.Parameters.AddWithValue("@tipo_banco", SqlDbType.VarChar).Value = Tipban;
            cmd.Parameters.AddWithValue("@est", SqlDbType.Int).Value = Esta;
            
            cmd.Parameters.AddWithValue("@id_rol", SqlDbType.Int).Value = IdRol;
            cmd.Parameters.AddWithValue("@id_deta_rol", SqlDbType.Decimal).Value = IdDetaRol;
            cmd.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = TipoFila;

            cmd.Parameters.AddWithValue("@fnac", SqlDbType.DateTime).Value = FechaNacim;
            cmd.Parameters.AddWithValue("@ciud", SqlDbType.VarChar).Value = Ciudad;
            cmd.Parameters.AddWithValue("@val_acum_fon_res", SqlDbType.Decimal).Value = ValorAcumuladoFonRes;
            cmd.Parameters.AddWithValue("@desc_almuerzo", SqlDbType.Decimal).Value = DesAlmuerzo;
            cmd.Parameters.AddWithValue("@extsal", SqlDbType.Int).Value = ExtSal;
            cmd.Parameters.AddWithValue("@desc_diasnolab", SqlDbType.Decimal).Value = DescDiasNoLaborados;
            cmd.Parameters.AddWithValue("@dif_dec_fon", SqlDbType.Decimal).Value = DescDifDecFon;
            cmd.Parameters.AddWithValue("@extedit", SqlDbType.Int).Value = ExtEdit;
            
            return cmd;
        }

        public DataSet SeleccionarDetalleRolLista(TipoConexion tipoCon, List<string> ids, int idr)
        {

            var lids = ids.Aggregate("(", (current, id) => current + (id + ","));
            lids = lids.EndsWith(",") ? lids.Substring(0, lids.Length - 1) + ")" : lids + ")";

            var pars = new List<object[]>
            {
                new object[] { "id_rol", SqlDbType.Int, idr } ,
                
            };

            var rol = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "SELECT grupo, id_personal, num, cliente, ubicacion, nomina, cedula, ingreso, cargo, area, sueldob, diast, sueldodt, diasdm, sueldodm, sueldodtdm, hnor, cos_hnor, tot_hnor, hsup, cos_hsup,tot_hsup, hext, cos_hext, tot_hext, hextf, cos_hextf, tot_hextf, rec_noturno, adicional, ot_ing ,(tot_ext - adicional) as tot_ext, ing_ext, xiii, xiii_pension, xiv, xiv_pension, fon_res, fon_res_ant, tot_ben, tot_ing, espacio,desc_iess, quin_ante, desc_quir, desc_hip, desc_exsc, ant_eme, desc_capa, ant_vari, desc_prem, desc_comc, desc_comi, desc_equip, desc_pension, desc_vivi, desc_multas, ot_desc, tot_desc,neto_rol, extra, fonres, xiiirol, xivrol, acufor, deseg, xiisex, forsex, id_banco, case when banco = 'SIN BANCO' then 'PAGADO EN CHEQUE' ELSE BANCO END AS banco,cuenta, tipo_banco, est, id_rol, id_deta_rol, tipo, f_nacim, ciudad, val_acum_fon_res, desc_almuerzo, extsal,desc_diasnolab, dif_dec_fon, extedit FROM DETALLES_ROL WHERE ID_ROL = @id_rol  AND ID_PERSONAL in " + lids + " " + "ORDER BY num", false, pars);
            rol.TableName = "DETALLES_ROL";

            

            var ds = new DataSet();
            ds.Tables.Add(rol);
            
            return ds;
        }


    } 
}
