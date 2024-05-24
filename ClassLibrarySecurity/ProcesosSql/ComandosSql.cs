using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ClassLibraryCisepro3.Enums;

namespace ClassLibraryCisepro3.ProcesosSql
{
    public static class ComandosSql
    {
        private static readonly Conexion Conexion = new Conexion();
         
        public static void Salir(TipoConexion tip)
        {
            Conexion.CerrarConexion(tip);
        }

        public static DataTable SeleccionarQueryToDataTable(TipoConexion tip, string query, bool esProcesoAlmacenado)
        {
            var table = new DataTable();
            
            try
            {
                using (var cmd = new SqlCommand(query, Conexion.AbrirConexion(tip)))
                {
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = esProcesoAlmacenado ? CommandType.StoredProcedure : CommandType.Text;
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return table;
        }

        public static DataTable SeleccionarQueryWithParamsToDataTable(TipoConexion tip, string query, bool esProcesoAlmacenado, List<object[]> pars)
        {
            var table = new DataTable();
            try
            {
                using (var cmd = new SqlCommand(query, Conexion.AbrirConexion(tip)))
                {
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = esProcesoAlmacenado ? CommandType.StoredProcedure : CommandType.Text;
                    if (pars.Count > 0) foreach (var param in pars) cmd.Parameters.AddWithValue((string)param[0], (SqlDbType)param[1]).Value = param[2];

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return table;
        }

        public static bool ProcesarComando(TipoConexion tip, SqlCommand command)
        {
            var result = false;
            try
            {
                var con = Conexion.AbrirConexion(tip);
                command.CommandTimeout = 0;
                command.Connection = con;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"Error al procesar comando simple: " + ex.Message);
            }
            return result;
        }

        public static object[] ProcesarTransacciones(TipoConexion tip, List<SqlCommand> querys, string tag)
        {
            var result = new object[] { false, string.Empty };
            SqlTransaction trans = null;
            var qr = string.Empty;
            try
            {
                var con = Conexion.AbrirConexion(tip);
                trans = con.BeginTransaction();

                // LOG (GUARDA LAS SENTENCIAS EJECUTADAS EN CADA PROCESO, PARA MANTENIMIENTO) 
                string query;
                var  r = string.Empty;
                foreach (var sql in querys)
                {
                    if (sql.CommandText.Contains("@"))
                    {
                        query = sql.Parameters.Cast<SqlParameter>().Aggregate(sql.CommandText, (current, par) => current.Replace(par.ParameterName, "'" + par.Value + "'"));
                        r += query + ";";
                    }
                    else r += sql.CommandText + ";";   
                }
                r = r.Replace("'", "");

                querys.Add(new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = "INSERT INTO LOGSQL VALUES(dbo.MaxIdLog(), '" + tag + "', '" + r + "', getDate());"
                });

                // EJECUTA LAS INSTRUCCIONES DE CADA FORM
                foreach (var sql in querys)
                {
                    qr = sql.CommandText;
                    sql.CommandTimeout = 0;
                    sql.Connection = con;
                    sql.Transaction = trans;
                    sql.ExecuteNonQuery();
                }
                trans.Commit();
                result[0] = true;
                result[1] = "Transacción procesada correctamente.";
            }
            catch (SqlException ex)
            {
                Console.WriteLine(@"SqlException: " + qr);
                result[0] = false;
                result[1] = "Error al procesar la transacción: " + ex.Message;
                if (trans != null) trans.Rollback();
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"Exception: " + qr);
                result[0] = false;
                result[1] = "Error al procesar la transacción: " + ex.Message;
                if (trans != null) trans.Rollback();
            }
            return result;
        } 
    }
}