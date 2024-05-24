using System.Collections.Generic;
using System.Data;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using System;
using System.Data.SqlClient;

namespace ClassLibraryCisepro3.TalentoHumano
{
    public class ClassDocumentosContrato
    {
        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/
        public int IdDocumento { get; set; }
        public int IdContrato { get; set; }
        public string TipoDocumento{ get; set; }
        public DateTime FechaCarga { get; set; }
        public string NombreDocumento { get; set; }
        public byte[] DocumentoByte { get; set; }


        public int BuscarMayorIdCodumento(TipoConexion tipoCon)
        {
            var data = ComandosSql.SeleccionarQueryToDataTable(tipoCon, "SELECT id_documento=CASE WHEN MAX(id_documento) IS NULL THEN 0 ELSE MAX(id_documento) End FROM DOCUMENTOS_CONTRATO", false);
            return data.Rows.Count == 0 ? 0 : Convert.ToInt32(data.Rows[0]["id_documento"]);
        }

        public SqlCommand RegistrarNuevoDocumentoPersonalCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "insert into DOCUMENTOS_CONTRATO (id_contrato, tipo_documento, fecha_carga, documento, id_documento, nombre) " +
                "values (@id_contrato, @tipo_documento, @fecha_carga, @documento, @id_documento, @nombre);"
            };
            cmd.Parameters.AddWithValue("@id_contrato", SqlDbType.Int).Value = IdContrato;
            cmd.Parameters.AddWithValue("@tipo_documento", SqlDbType.VarChar).Value = TipoDocumento;
            cmd.Parameters.AddWithValue("@fecha_carga", SqlDbType.Date).Value = FechaCarga;
            cmd.Parameters.AddWithValue("@documento", SqlDbType.VarBinary).Value = DocumentoByte;
            cmd.Parameters.AddWithValue("@id_documento", SqlDbType.Int).Value = IdDocumento;
            cmd.Parameters.AddWithValue("@nombre", SqlDbType.Int).Value = NombreDocumento;
            return cmd;
        }

        public SqlCommand ModificarDocumentoExistentePersonalCommand()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "update DOCUMENTOS_CONTRATO set tipo_documento=@tipo_documento, documento=@documento, nombre=@nombre where id_documento=@id_documento;"
            };
            cmd.Parameters.AddWithValue("@tipo_documento", SqlDbType.VarChar).Value = TipoDocumento;
            cmd.Parameters.AddWithValue("@documento", SqlDbType.VarBinary).Value = DocumentoByte;            
            cmd.Parameters.AddWithValue("@nombre", SqlDbType.Int).Value = NombreDocumento;
            cmd.Parameters.AddWithValue("@id_documento", SqlDbType.Int).Value = IdDocumento;
            return cmd;
        } 


        public DataTable SeleccionarDocumentoXContratoId(TipoConexion tipoCon, string idc)
        {
            var pars = new List<object[]>
            {
                new object[] { "idc", SqlDbType.Int, idc } 
            };
            return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "select tipo_documento 'NOMBRE DOCUMENTO', documento, nombre from DOCUMENTOS_CONTRATO where id_contrato = @idc order by tipo_documento;", false, pars);
        }
    }
}
