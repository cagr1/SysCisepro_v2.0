using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.ActivoFijo
{
    public class ClassChaleco
    {

        /**
        * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
        * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
        * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
        * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
        **/

        public DataTable SeleccionarChalecosxCaducar(TipoConexion tipoCon)
        {
            var sql = "select  ID_ACTIVO_FIJO, MARCA, MODELO, ESTADO_ACTIVO, COLOR, SERIE, MATERIAL, ANO, CADUCIDAD from CHALECOS C WHERE C.CADUCIDAD < DATEADD(MONTH, 5, GETDATE())";
            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, sql, false);
        }
    }
}
