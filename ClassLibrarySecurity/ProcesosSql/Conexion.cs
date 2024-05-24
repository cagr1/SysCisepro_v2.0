using System;
using System.Data.SqlClient;
using System.Data;
using ClassLibraryCisepro3.Enums;

namespace ClassLibraryCisepro3.ProcesosSql
{
    public class Conexion
    {
        private readonly SqlConnection _connCisepro;
        private readonly SqlConnection _connSeportpac;
        private readonly SqlConnection _connAsenava;

        public Conexion()
        {
            _connCisepro = new SqlConnection(Properties.Settings.Default.SysCiseproConnectionString);
            _connSeportpac = new SqlConnection(Properties.Settings.Default.SysSeportpacConnectionString);
            _connAsenava = new SqlConnection(Properties.Settings.Default.SysAsenavaConnectionString); 
        }

        public SqlConnection AbrirConexion(TipoConexion tip)
        {
            SqlConnection con;
            try
            {
                switch (tip)
                {
                    case TipoConexion.Seportpac:
                        con = _connSeportpac;
                        break;
                    case TipoConexion.Asenava:
                        con = _connAsenava;
                        break;
                    default: // CISEPRO
                        con = _connCisepro;  
                        break;
                }
                if (con.State == ConnectionState.Closed) con.Open();
            }
            catch (Exception ex)
            {
                con = null;
                Console.Write(ex.Message);
            }
            return con;
        }

        public void CerrarConexion(TipoConexion tip)
        {
            try
            { 
                switch (tip)
                {
                    case TipoConexion.Seportpac:
                        if (_connSeportpac != null && _connSeportpac.State == ConnectionState.Open) _connSeportpac.Close();
                        break;
                    case TipoConexion.Asenava:
                        if (_connAsenava != null && _connAsenava.State == ConnectionState.Open) _connAsenava.Close();
                        break;
                    default: // CISEPRO
                        if (_connCisepro != null && _connCisepro.State == ConnectionState.Open) _connCisepro.Close(); 
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
