using System;
using System.Collections.Generic;
using System.Data;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.DivisionGeografica
{
    public class ClassSitiosTrabajo
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public DataTable SeleccionarSitiosTrabajoGrupos(TipoConexion tipoCon, string filtro)
        {
            var sql = "SELECT G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL FROM SITIOS_TRABAJO S " +
                      "JOIN PROVINCIAS P ON S.ID_PROVINCIA= P.ID_PROVINCIAS JOIN CIUDADES C ON S.ID_CIUDAD=C.ID_CIUDAD " +
                      "JOIN PARROQUIAS R ON S.ID_PARROQUIA=R.ID_PARROQUIAS JOIN PERSONAL E ON S.ID_PERSONAL_SUPERVISOR=E.ID_PERSONAL " +
                      "left join cliente_general G on  s.ID_CLIENTE_GENERAL=g.ID_CLIENTE_GENERAL " +
                      "where s.estado = 1 and (S.NOMBRE_SITIO_TRABAJO LIKE ('%' + @FILTRO + '%') OR S.RIVER LIKE ('%' + @FILTRO + '%') OR G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL LIKE ('%' + @FILTRO + '%') OR G.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL LIKE ('%' + @FILTRO + '%')) " +
                      "GROUP BY G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL ORDER BY G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL;";
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, filtro } 
            };

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars) ;
        }

        public DataTable SeleccionarSitiosConGrupos(TipoConexion tipoCon, string filtro)
        {

            string sql;

            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, filtro } 
            };

            sql = "SELECT S.NOMBRE_SITIO_TRABAJO + ' - '  + S.RIVER AS SITIO_RIVER , S.ID_SITIO_TRABAJO " +
                    "FROM SITIOS_TRABAJO S " +
                     "WHERE s.estado = 1 AND S.GRUPO LIKE '%' + @FILTRO + '%'";
             return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
          }

                public DataTable SeleccionarSitiosTrabajoDatos(TipoConexion tipoCon, string filtro)
        {
            var sql =
                "SELECT S.ID_SITIO_TRABAJO, S.RIVER, s.NOMBRE_SITIO_TRABAJO, S.DIRECCION_SITIO_TRABAJO,  C.NOMBRE_CIUDADES, E.APELLIDOS + ' ' + E.NOMBRES SUPERVISOR, S.ID_PROVINCIA,  P.NOMBRE_PROVINCIAS, " +
                " S.ID_CIUDAD, S.ID_PARROQUIA, R.NOMBRE_PARROQUIAS, S.REFERENCIA_SITIO_TRABAJO, s.TIPO_SITIO_TRABAJO, " +
                "S.ID_PERSONAL_SUPERVISOR,  S.ESTADO, s.ID_CLIENTE_GENERAL, G.TIPO_IDENTIFICACION_CLIENTE_GENERAL, " +
                "G.RUC_CI_CLIENTE_GENERAL CLIENTE, G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL, G.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL,  S.LATITUD,  S.LONGITUD,  S.GRUPO, " +
                "s.rive FROM SITIOS_TRABAJO S JOIN PROVINCIAS P ON S.ID_PROVINCIA= P.ID_PROVINCIAS " +
                "JOIN CIUDADES C ON S.ID_CIUDAD=C.ID_CIUDAD JOIN PARROQUIAS R ON S.ID_PARROQUIA=R.ID_PARROQUIAS " +
                "JOIN PERSONAL E ON S.ID_PERSONAL_SUPERVISOR=E.ID_PERSONAL " +
                "left join cliente_general G on  s.ID_CLIENTE_GENERAL=g.ID_CLIENTE_GENERAL " +
                "where s.estado = 1 and (S.NOMBRE_SITIO_TRABAJO LIKE ('%' + @FILTRO + '%') OR S.RIVER LIKE ('%' + @FILTRO + '%') OR G.NOMPRE_RAZON_SOCIAL_CLIENTE_GENERAL LIKE ('%' + @FILTRO + '%') OR G.APELLIDO_NOMBRE_COMERCIAL_CLIENTE_GENRAL LIKE ('%' + @FILTRO + '%')) ORDER BY  S.NOMBRE_SITIO_TRABAJO;";
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, filtro } 
            };

            return  ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);
        }

        public DataTable SeleccionarSitios(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SeleccionarSitios", true);
        }

        public DataTable SeleccionarGruposSitios(TipoConexion tipoCon, bool todos, bool retirados, bool admin)
        {
            var sq = retirados
                ? "select 'GENERAL' UNION ALL (select rtrim(ltrim(grupo)) grupo from GRUPO_STITIO where grupo <> 'GENERAL' group by grupo) union all SELECT 'RETIRADOS'"
                : "select 'GENERAL' UNION ALL (select rtrim(ltrim(grupo)) grupo from GRUPO_STITIO where grupo <> 'GENERAL' group by grupo)";
            var sql = todos
                ? "select rtrim(ltrim(grupo)) grupo from GRUPO_STITIO group by grupo"
                : admin ? sq + " union all SELECT 'ADMINISTRATIVO'" : sq;
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, false);
        }

        public DataTable SeleccionarGruposSitiosAplicaDescuentoDiferencia(TipoConexion tipoCon)
        {
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "select grupo from grupo_stitio where desc_diff = 0", false);
        }

        public DataTable BuscarUltimoPuestoPorIdPersonal(TipoConexion tipoCon, int idp, bool admin)
        {
            var pars = new List<object[]>
            {
                new object[] { "IDP", SqlDbType.Int, idp } 
            };

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, admin ? "select *  from sitios_trabajo s join cliente_general c on s.id_cliente_general = c.id_cliente_general where s.id_sitio_trabajo = 1;" : "select top 1 * from detalle_programacion d join sitios_trabajo s on d.id_puesto=s.id_sitio_trabajo join cliente_general  c on s.id_cliente_general=c.id_cliente_general where d.id_personal = @IDP and d.estado = 1 order by d.id_programacion desc;", false, pars);
        }

        public DataTable BuscarDatosSitioxIdSitio(TipoConexion tipoCon, string id)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_SITIO_TRABAJO", SqlDbType.Int, id } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select * from sitios_trabajo where id_sitio_trabajo = @ID_SITIO_TRABAJO", false, pars);
        }

        public string BuscarNombreSitioxIdSitio(TipoConexion tipoCon, string id, bool sp)
        {
            var pars = new List<object[]>
            {
                new object[] { "ID_SITIO_TRABAJO", SqlDbType.Int, id } 
            };
            var sql = sp ? "buscarNombreSitioxIdSitio" : "select s.nombre_sitio_trabajo + ' ('+c.nompre_razon_social_cliente_general+')' NOMBRE_SITIO_TRABAJO from SITIOS_TRABAJO s join cliente_general c on s.id_cliente_general=c.id_cliente_general where s.id_sitio_trabajo = @ID_SITIO_TRABAJO";

            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, sp, pars);
            return data.Rows.Count == 0 ? string.Empty : data.Rows[0][0] == DBNull.Value ? string.Empty : data.Rows[0][0].ToString(); 
        }


        public int BuscarSitioId(TipoConexion tipoCon, string filtro)
        {
            var pars = new List<object[]>
            {
                new object[] { "FILTRO", SqlDbType.VarChar, filtro } 
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "(SELECT S.ID_SITIO_TRABAJO FROM SITIOS_TRABAJO S where s.estado = 1 and S.NOMBRE_SITIO_TRABAJO LIKE ('%' + @FILTRO + '%'));", false, pars);
            return data.Rows.Count == 0 ? 0 : data.Rows[0][0] == DBNull.Value ? 0 : Convert.ToInt32(data.Rows[0][0]);
        }

        public DataTable SeleccionarItemsByIdSitio(TipoConexion tipoCon, Int32 idSitio, DateTime fechad, DateTime fechah, string grupo)
        {
            var pars = new List<object[]>();
            pars.Add(new object[] { "ID_SITIO", SqlDbType.Int, idSitio });
            pars.Add(new object[] { "FECHAD", SqlDbType.DateTime, fechad });
            pars.Add(new object[] { "FECHAH", SqlDbType.DateTime, fechah });
            pars.Add(new object[] { "grupo", SqlDbType.VarChar, grupo });
            // E SALE DEL PUESTO - INGRESA A BODEGA
            // I ENRA AL PUESTO - SALE DE BODEGA

            //var Sql = "SELECT * " + "FROM " + "( SELECT CU.ID_COMPROBANTE AS COMPROBANTE, CU.FECHA,CU.CANTIDAD_ARTICULOS AS CANTIDAD," + "CASE WHEN CU.ID_ACTIVIDAD = 1 THEN 'I' " + "WHEN CU.ID_ACTIVIDAD = 2 THEN 'E' " + "ELSE '' " + "END AS TIPO, " + "SI.NOMBRE_SECUENCIAL_ITEM, K.ID_KARDEX, DCIB.OBSERVACION, CIB.RAZON " + "FROM CONTROL_UNIFORMES CU join COMPROBANTE_INGRESO_BODEGA CIB on CU.ID_COMPROBANTE = CIB.ID_COMPROBANTE " + "JOIN DETALLE_KARDEX DK ON CU.ID_DETALLE_KARDEX = DK.ID_DETALLE JOIN KARDEX K ON K.ID_KARDEX = DK.ID_KARDEX " + "JOIN SECUENCIAL_ITEM SI ON K.ID_SECUENCIAL_ITEM = SI.ID_SECUENCIAL_ITEM JOIN DETALLE_COMPROBANTE_INGRESO_BODEGA DCIB " + "ON DCIB.ID_COMPROBANTE = CIB.ID_COMPROBANTE " + "WHERE CIB.ID_SITIO_TRABAJO = @ID_SITIO AND CU.FECHA BETWEEN @FECHAD AND @FECHAH " + "AND CIB.ESTADO = 1 AND DK.ESTADO = 1 " + "UNION " + "SELECT CU.ID_COMPROBANTE , CU.FECHA,CU.CANTIDAD_ARTICULOS, " + "CASE WHEN CU.ID_ACTIVIDAD = 1 THEN 'I' " + "WHEN CU.ID_ACTIVIDAD = 2 THEN 'E' " + "ELSE '' " + "END AS TIPO, " + "SI.NOMBRE_SECUENCIAL_ITEM, K.ID_KARDEX, DCEB.OBSERVACION, CEB.RAZON " + "FROM CONTROL_UNIFORMES CU join COMPROBANTE_EGRESO_BODEGA CEB on CU.ID_COMPROBANTE = CEB.ID_COMPROBANTE " + "JOIN DETALLE_KARDEX DK ON CU.ID_DETALLE_KARDEX = DK.ID_DETALLE JOIN KARDEX K ON K.ID_KARDEX = DK.ID_KARDEX " + "JOIN SECUENCIAL_ITEM SI ON K.ID_SECUENCIAL_ITEM = SI.ID_SECUENCIAL_ITEM JOIN DETALLE_COMPROBANTE_EGRESO_BODEGA DCEB " + "ON DCEB.ID_COMPROBANTE = CEB.ID_COMPROBANTE " + "WHERE CEB.ID_SITIO_TRABAJO = @ID_SITIO AND CU.FECHA BETWEEN @FECHAD AND @FECHAH " + "AND CEB.ESTADO = 1 AND DK.ESTADO = 1) " + "AS TAB " + "GROUP BY TAB.COMPROBANTE,TAB.FECHA,TAB.CANTIDAD, TAB.ID_KARDEX, TAB.OBSERVACION,TAB.RAZON, TAB.TIPO, TAB.NOMBRE_SECUENCIAL_ITEM " + "ORDER BY TAB.FECHA";
            //var sql = "SELECT DK.ID_COMPROBANTE,dk.FECHA, DK.CANTIDAD_INGRESO as CANTIDAD,'I' TIPO, dk.ID_KARDEX, DCIB.OBSERVACION AS SERIE, SI.NOMBRE_SECUENCIAL_ITEM, CIB.RAZON FROM  DETALLE_KARDEX DK  JOIN COMPROBANTE_INGRESO_BODEGA CIB ON DK.ID_COMPROBANTE = CIB.ID_COMPROBANTE  JOIN DETALLE_COMPROBANTE_INGRESO_BODEGA DCIB ON DCIB.ID_COMPROBANTE = CIB.ID_COMPROBANTE JOIN KARDEX K ON DK.ID_KARDEX = K.ID_KARDEX  JOIN SECUENCIAL_ITEM SI ON SI.ID_SECUENCIAL_ITEM = K.ID_SECUENCIAL_ITEM JOIN SITIOS_TRABAJO ST ON ST.ID_SITIO_TRABAJO = CIB.ID_SITIO_TRABAJO  WHERE DK.ESTADO > 0 AND CIB.ESTADO > 0 AND DCIB.ESTADO_DETALLE > 0 AND DK.CANTIDAD_INGRESO > 0 AND dk.FECHA BETWEEN @fechad AND @fechah AND CIB.ID_SITIO_TRABAJO = @ID_SITIO  AND DCIB.ID_KARDEX = K.ID_KARDEX UNION  SELECT DK.ID_COMPROBANTE, dk.FECHA, DK.CANTIDAD_EGRESO AS CANTIDAD, 'E' TIPO, dk.ID_KARDEX , DCEB.OBSERVACION AS SERIE, SI.NOMBRE_SECUENCIAL_ITEM, CEB.RAZON  FROM DETALLE_KARDEX DK  JOIN COMPROBANTE_EGRESO_BODEGA CEB ON DK.ID_COMPROBANTE = CEB.ID_COMPROBANTE  JOIN DETALLE_COMPROBANTE_EGRESO_BODEGA DCEB ON DCEB.ID_COMPROBANTE = CEB.ID_COMPROBANTE JOIN KARDEX K ON DK.ID_KARDEX = K.ID_KARDEX  JOIN SECUENCIAL_ITEM SI ON SI.ID_SECUENCIAL_ITEM = K.ID_SECUENCIAL_ITEM JOIN SITIOS_TRABAJO ST ON ST.ID_SITIO_TRABAJO = CEB.ID_SITIO_TRABAJO  WHERE DK.ESTADO > 0 AND CEB.ESTADO > 0 AND DCEB.ESTADO_DETALLE > 0 AND DK.CANTIDAD_EGRESO > 0 AND dk.FECHA BETWEEN @fechad AND @fechah AND CEB.ID_SITIO_TRABAJO = @ID_SITIO AND DCEB.ID_KARDEX = K.ID_KARDEX ORDER BY DK.FECHA";

            var sql = "";
            if (idSitio == 0)
            {
                 sql = @"SELECT DK.ID_COMPROBANTE,dk.FECHA, DK.CANTIDAD_INGRESO as CANTIDAD,'I' TIPO, dk.ID_KARDEX, DCIB.OBSERVACION AS SERIE, SI.NOMBRE_SECUENCIAL_ITEM, CIB.RAZON, ST.NOMBRE_SITIO_TRABAJO AS SITIO_TRABAJO
                        FROM  DETALLE_KARDEX DK 
                        JOIN COMPROBANTE_INGRESO_BODEGA CIB ON DK.ID_COMPROBANTE = CIB.ID_COMPROBANTE 
                        JOIN DETALLE_COMPROBANTE_INGRESO_BODEGA DCIB ON DCIB.ID_COMPROBANTE = CIB.ID_COMPROBANTE
                        JOIN KARDEX K ON DK.ID_KARDEX = K.ID_KARDEX 
                        JOIN SECUENCIAL_ITEM SI ON SI.ID_SECUENCIAL_ITEM = K.ID_SECUENCIAL_ITEM
                        JOIN SITIOS_TRABAJO ST ON ST.ID_SITIO_TRABAJO = CIB.ID_SITIO_TRABAJO 
                        WHERE DK.ESTADO > 0 AND CIB.ESTADO > 0 AND DCIB.ESTADO_DETALLE > 0 AND DK.CANTIDAD_INGRESO > 0
                        AND dk.FECHA BETWEEN @fechad AND @fechah AND st.GRUPO like @grupo 
                        AND DCIB.ID_KARDEX = K.ID_KARDEX
                        UNION 
                        SELECT DK.ID_COMPROBANTE, dk.FECHA, DK.CANTIDAD_EGRESO AS CANTIDAD, 'E' TIPO, dk.ID_KARDEX , DCEB.OBSERVACION AS SERIE, SI.NOMBRE_SECUENCIAL_ITEM, CEB.RAZON, ST.NOMBRE_SITIO_TRABAJO  AS SITIO_TRABAJO
                        FROM DETALLE_KARDEX DK 
                        JOIN COMPROBANTE_EGRESO_BODEGA CEB ON DK.ID_COMPROBANTE = CEB.ID_COMPROBANTE 
                        JOIN DETALLE_COMPROBANTE_EGRESO_BODEGA DCEB ON DCEB.ID_COMPROBANTE = CEB.ID_COMPROBANTE
                        JOIN KARDEX K ON DK.ID_KARDEX = K.ID_KARDEX 
                        JOIN SECUENCIAL_ITEM SI ON SI.ID_SECUENCIAL_ITEM = K.ID_SECUENCIAL_ITEM
                        JOIN SITIOS_TRABAJO ST ON ST.ID_SITIO_TRABAJO = CEB.ID_SITIO_TRABAJO 
                        WHERE DK.ESTADO > 0 AND CEB.ESTADO > 0 AND DCEB.ESTADO_DETALLE > 0 AND DK.CANTIDAD_EGRESO > 0
                        AND dk.FECHA BETWEEN @fechad AND @fechah AND st.GRUPO like @grupo 
                        AND DCEB.ID_KARDEX = K.ID_KARDEX
                        ORDER BY DK.FECHA";

            }
            else
            {

                sql = @"SELECT DK.ID_COMPROBANTE,dk.FECHA, DK.CANTIDAD_INGRESO as CANTIDAD,'I' TIPO, dk.ID_KARDEX, DCIB.OBSERVACION AS SERIE, SI.NOMBRE_SECUENCIAL_ITEM, CIB.RAZON
                    FROM  DETALLE_KARDEX DK 
                    JOIN COMPROBANTE_INGRESO_BODEGA CIB ON DK.ID_COMPROBANTE = CIB.ID_COMPROBANTE 
                    JOIN DETALLE_COMPROBANTE_INGRESO_BODEGA DCIB ON DCIB.ID_COMPROBANTE = CIB.ID_COMPROBANTE
                    JOIN KARDEX K ON DK.ID_KARDEX = K.ID_KARDEX 
                    JOIN SECUENCIAL_ITEM SI ON SI.ID_SECUENCIAL_ITEM = K.ID_SECUENCIAL_ITEM
                    JOIN SITIOS_TRABAJO ST ON ST.ID_SITIO_TRABAJO = CIB.ID_SITIO_TRABAJO 
                    WHERE DK.ESTADO > 0 AND CIB.ESTADO > 0 AND DCIB.ESTADO_DETALLE > 0 AND DK.CANTIDAD_INGRESO > 0
                    AND dk.FECHA BETWEEN @fechad AND @fechah AND CIB.ID_SITIO_TRABAJO = @id_sitio 
                    AND DCIB.ID_KARDEX = K.ID_KARDEX
                    UNION 
                    SELECT DK.ID_COMPROBANTE, dk.FECHA, DK.CANTIDAD_EGRESO AS CANTIDAD, 'E' TIPO, dk.ID_KARDEX , DCEB.OBSERVACION AS SERIE, SI.NOMBRE_SECUENCIAL_ITEM, CEB.RAZON 
                    FROM DETALLE_KARDEX DK 
                    JOIN COMPROBANTE_EGRESO_BODEGA CEB ON DK.ID_COMPROBANTE = CEB.ID_COMPROBANTE 
                    JOIN DETALLE_COMPROBANTE_EGRESO_BODEGA DCEB ON DCEB.ID_COMPROBANTE = CEB.ID_COMPROBANTE
                    JOIN KARDEX K ON DK.ID_KARDEX = K.ID_KARDEX 
                    JOIN SECUENCIAL_ITEM SI ON SI.ID_SECUENCIAL_ITEM = K.ID_SECUENCIAL_ITEM
                    JOIN SITIOS_TRABAJO ST ON ST.ID_SITIO_TRABAJO = CEB.ID_SITIO_TRABAJO 
                    WHERE DK.ESTADO > 0 AND CEB.ESTADO > 0 AND DCEB.ESTADO_DETALLE > 0 AND DK.CANTIDAD_EGRESO > 0
                    AND dk.FECHA BETWEEN @fechad AND @fechah AND CEB.ID_SITIO_TRABAJO = @id_sitio
                    AND DCEB.ID_KARDEX = K.ID_KARDEX
                    ORDER BY DK.FECHA";
            
            }

            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);




            
        }


        public DataTable SeleccionarItemsByTodo(TipoConexion tipoCon, DateTime fechad, DateTime fechah, string filtro)
        {
            var pars = new List<object[]>();
            
            pars.Add(new object[] { "FECHAD", SqlDbType.DateTime, fechad });
            pars.Add(new object[] { "FECHAH", SqlDbType.DateTime, fechah });
            pars.Add(new object[] { "filtro", SqlDbType.VarChar, filtro });
           

            var  sql = @"SELECT DK.ID_COMPROBANTE,dk.FECHA, DK.CANTIDAD_INGRESO as CANTIDAD,'I' TIPO, dk.ID_KARDEX, DCIB.OBSERVACION AS SERIE, SI.NOMBRE_SECUENCIAL_ITEM, CIB.RAZON, ST.NOMBRE_SITIO_TRABAJO AS SITIO_TRABAJO, ST.RIVER as RIVER
                        FROM  DETALLE_KARDEX DK 
                        JOIN COMPROBANTE_INGRESO_BODEGA CIB ON DK.ID_COMPROBANTE = CIB.ID_COMPROBANTE 
                        JOIN DETALLE_COMPROBANTE_INGRESO_BODEGA DCIB ON DCIB.ID_COMPROBANTE = CIB.ID_COMPROBANTE
                        JOIN KARDEX K ON DK.ID_KARDEX = K.ID_KARDEX 
                        JOIN SECUENCIAL_ITEM SI ON SI.ID_SECUENCIAL_ITEM = K.ID_SECUENCIAL_ITEM
                        JOIN SITIOS_TRABAJO ST ON ST.ID_SITIO_TRABAJO = CIB.ID_SITIO_TRABAJO 
                        WHERE DK.ESTADO > 0 AND CIB.ESTADO > 0 AND DCIB.ESTADO_DETALLE > 0 AND DK.CANTIDAD_INGRESO > 0
                        AND dk.FECHA BETWEEN @fechad AND @fechah AND (st.GRUPO  like '%'+ @filtro + '%' OR st.RIVER like '%'+ @filtro + '%'  OR st.NOMBRE_SITIO_TRABAJO like  '%'+ @filtro + '%')
                        AND DCIB.ID_KARDEX = K.ID_KARDEX
                        UNION 
                        SELECT DK.ID_COMPROBANTE, dk.FECHA, DK.CANTIDAD_EGRESO AS CANTIDAD, 'E' TIPO, dk.ID_KARDEX , DCEB.OBSERVACION AS SERIE, SI.NOMBRE_SECUENCIAL_ITEM, CEB.RAZON, ST.NOMBRE_SITIO_TRABAJO  AS SITIO_TRABAJO, ST.RIVER as RIVER
                        FROM DETALLE_KARDEX DK 
                        JOIN COMPROBANTE_EGRESO_BODEGA CEB ON DK.ID_COMPROBANTE = CEB.ID_COMPROBANTE 
                        JOIN DETALLE_COMPROBANTE_EGRESO_BODEGA DCEB ON DCEB.ID_COMPROBANTE = CEB.ID_COMPROBANTE
                        JOIN KARDEX K ON DK.ID_KARDEX = K.ID_KARDEX 
                        JOIN SECUENCIAL_ITEM SI ON SI.ID_SECUENCIAL_ITEM = K.ID_SECUENCIAL_ITEM
                        JOIN SITIOS_TRABAJO ST ON ST.ID_SITIO_TRABAJO = CEB.ID_SITIO_TRABAJO 
                        WHERE DK.ESTADO > 0 AND CEB.ESTADO > 0 AND DCEB.ESTADO_DETALLE > 0 AND DK.CANTIDAD_EGRESO > 0
                        AND dk.FECHA BETWEEN @fechad AND @fechah and (st.GRUPO  like '%'+ @filtro + '%' OR st.RIVER like '%'+ @filtro + '%'  OR st.NOMBRE_SITIO_TRABAJO like  '%'+ @filtro + '%')
                        AND DCEB.ID_KARDEX = K.ID_KARDEX
                        ORDER BY DK.FECHA";


            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, sql, false, pars);

            }
           

    
        }

    }

