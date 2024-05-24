using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;

namespace ClassLibraryCisepro3.UsuarioGeneral
{
    public class ClassPermisosUsuario
    {

        /**
         * ATRIBUTOS QUE ESTAN LIGADOS A LA(S) TABLA(S) CORRESPONDIENTE(S) 
         * SI AGREGO UNA COLUMNA EN LA TABLA (BD), ES RECOMENDABLE CREAR SU ATRIBUTO CORRESPONDIENTE CON EL MISMO TIPO DE DATO
         * TODOS LOS METODOS DE GUARDAR, SELECCIONAR, BUSCAR, ESTAN LIGADOS A UN PROCEDIMIENTO EN BD Y SU TIPO DE RETRNO GENERAL ES DATATABLE
         * HAY METODOS DONDE NO USAMOS PROCEDIMIENTOS ALMACENADOS SINO LAS SENTENCIAS SQL DE ACUERDO A LA LOGICA DE USO
         **/

        
        public int idRol { get; set; }
        public int idRolUserPermisos { get; set; }
        public int idMenuUno { get; set; }
        public int idMenuDos { get; set; }
        public int idMenuTres { get; set; }
        public string tipopRol { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public DateTime fecha { get; set; }


       

        public bool BuscarMenuUnoUsuario(TipoConexion tipoCon, int Id, int menu)
        {
                                  
            
            var pars = new List<object[]>
            {
                new object[] { "@roluser", SqlDbType.Int, Id },
                new object[] {"@menuId", SqlDbType.Int, menu},
                
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_BuscarMenuUnoUsuario", true, pars);
            if (data.Rows.Count > 0)
            {
                return Convert.ToBoolean(data.Rows[0][0]);
            }

            return false;
        }


        public bool BuscarMenuDosUsuario(TipoConexion tipoCon, int Id, int menu, int menuDos)
        {
            var pars = new List<object[]>
            {
                new object[] { "@roluser", SqlDbType.Int, Id },
                new object[] {"@menuId", SqlDbType.Int, menu},
                new object[] {"@menuIdDos", SqlDbType.Int, menuDos},
                
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_BuscarMenuDosUsuario", true, pars);
            if (data.Rows.Count > 0)
            {
                return Convert.ToBoolean(data.Rows[0][0]);
            }

            return false;
        }

        public bool BuscarMenuTresUsuario(TipoConexion tipoCon, int Id, int menu, int menuDos, int menuTres)
        {
            var pars = new List<object[]>
            {
                new object[] { "@roluser", SqlDbType.Int, Id },
                new object[] {"@menuId", SqlDbType.Int, menu},
                new object[] {"@menuIdDos", SqlDbType.Int, menuDos},
                new object[] {"@menuIdTres", SqlDbType.Int, menuTres},
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_BuscarMenuTresUsuario", true, pars);
            if (data.Rows.Count > 0)
            {
                return Convert.ToBoolean(data.Rows[0][0]);
            }

            return false;
        }

        public DataTable CargarRolesActivos(TipoConexion tipoCon)
        {

            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_seleccionarRolesActivos", false);
        }

        public DataTable CargarRoles(TipoConexion tipoCon)
        {

            return ComandosSql.SeleccionarQueryToDataTable(tipoCon, "sp_seleccionarRoles", false);
        }

        public SqlCommand NuevoRol()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sp_nuevoRolUser"
            };
            
            cmd.Parameters.AddWithValue("@fld_tipo_rol", SqlDbType.Int).Value = tipopRol;
            cmd.Parameters.AddWithValue("@fld_descripcion", SqlDbType.NVarChar).Value = descripcion;
            cmd.Parameters.AddWithValue("@fld_estado",SqlDbType.Bit).Value = estado;
            cmd.Parameters.AddWithValue("@fld_create_at", SqlDbType.DateTime).Value = fecha;
            return cmd;
        }

        public SqlCommand ModificarRol()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sp_modificarRolUser"
            };
            cmd.Parameters.AddWithValue("@fld_id_rol", SqlDbType.Int).Value = idRol;
            cmd.Parameters.AddWithValue("@fld_tipo_rol", SqlDbType.NVarChar).Value = tipopRol;
            cmd.Parameters.AddWithValue("@fld_descripcion", SqlDbType.NVarChar).Value = descripcion;
            cmd.Parameters.AddWithValue("@fld_estado", SqlDbType.Bit).Value = estado;
            cmd.Parameters.AddWithValue("@fld_create_at", SqlDbType.DateTime).Value = fecha;
            return cmd;
        }

        public DataTable CargarRolesPorId(TipoConexion tipocon, int id)
        {

            {
                var pars = new List<object[]>
                    {
                new object[] { "@idrol", SqlDbType.Int,  id },
                
                    };

                return ComandosSql.SeleccionarQueryWithParamsToDataTable(tipocon, "sp_seleccionarRoluserporId", true, pars);
            }
        
        }

        public bool BuscarIdPermisoRol(TipoConexion tipoCon, int idRol, int IdPermiso)
        {


            var pars = new List<object[]>
            {
                new object[] { "@idRolPermiso", SqlDbType.Int, IdPermiso },
                new object[] { "@idRol", SqlDbType.Int, idRol },
            };
            var data = ComandosSql.SeleccionarQueryWithParamsToDataTable(tipoCon, "sp_buscarIdPermisos", true, pars);
            if (data.Rows.Count > 0)
            {
                return Convert.ToBoolean(data.Rows[0][0]);
            }

            return false;
        }

        public SqlCommand NuevoPermiso()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sp_nuevoPermisoUser"
            };

            
            cmd.Parameters.AddWithValue("@fld_id_rol_user", SqlDbType.Int).Value = idRol;
            cmd.Parameters.AddWithValue("@fld_id_menu", SqlDbType.Int).Value = idMenuUno ;
            cmd.Parameters.AddWithValue("@fld_id_menu_dos", SqlDbType.Int).Value = idMenuDos;
            cmd.Parameters.AddWithValue("@fld_id_menu_tres", SqlDbType.Int).Value = idMenuTres;
            cmd.Parameters.AddWithValue("@fld_estado", SqlDbType.Bit).Value = estado;
            cmd.Parameters.AddWithValue("@fld_create_at", SqlDbType.DateTime).Value = fecha;
            return cmd;
        }


        public SqlCommand ModificarPermiso()
        {
            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sp_modificarPermisoUser"
            };
            cmd.Parameters.AddWithValue("@fld_id_permisos", SqlDbType.Int).Value = idRolUserPermisos;
            cmd.Parameters.AddWithValue("@fld_id_rol_user", SqlDbType.Int).Value = idRol;
            cmd.Parameters.AddWithValue("@fld_id_menu", SqlDbType.Int).Value = idMenuUno;
            cmd.Parameters.AddWithValue("@fld_id_menu_dos", SqlDbType.Int).Value = idMenuDos;
            cmd.Parameters.AddWithValue("@fld_id_menu_tres", SqlDbType.Int).Value = idMenuTres;
            cmd.Parameters.AddWithValue("@fld_estado", SqlDbType.Bit).Value = estado;
            cmd.Parameters.AddWithValue("@fld_create_at", SqlDbType.DateTime).Value = fecha;
            return cmd;
        }


    }

}
