using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class RolUsuarioServices
    {
        private SqlCommand cmd;
        private Conexion con = new Conexion();
        private string msj = "Ocurrio un problema, intente mas tarde.";
        public List<RolUsuario> allSucursales()
        {
            List<RolUsuario> lstRoles = null;
            RolUsuario cl = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM rol_usuario";
                cmd = new SqlCommand(query, con.getConex());
                con.Dr = cmd.ExecuteReader();
                lstRoles = new List<RolUsuario>();
                while (con.Dr.Read())
                {
                    cl = new RolUsuario();
                    cl.IdRolUsuario = con.Dr.GetInt32(0);
                    cl.NombreRol = con.Dr.GetString(1);
                    lstRoles.Add(cl);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                lstRoles = null;
            }
            finally
            {
                con.close();
            }
            return lstRoles;
        }

        public RolUsuario sucursalByCodigo(int code)
        {
            RolUsuario cl = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM rol_usuario WHERE id_rol_usuario=@cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod", code);
                con.Dr = cmd.ExecuteReader();
                while (con.Dr.Read())
                {
                    cl = new RolUsuario();
                    cl.IdRolUsuario = con.Dr.GetInt32(0);
                    cl.NombreRol = con.Dr.GetString(1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                cl = null;
            }
            finally
            {
                con.close();
            }
            return cl;
        }
        public string insert(RolUsuario cl)
        {
            try
            {
                string query = "INSERT INTO rol_usuario VALUES (@nombreRol)";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@nombreRol", cl.NombreRol);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Rol guardado con éxito!";
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }
            finally
            {
                con.close();
            }
            return msj;
        }
        public string update(RolUsuario cl)
        {
            try
            {
                string query = "UPDATE rol_usuario SET ";
                query += "nombreRol=@name WHERE id_rol_usuario=@id";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@name", cl.NombreRol);
                cmd.Parameters.AddWithValue("@id", cl.IdRolUsuario);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Rol modificado con éxito!";
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }
            finally
            {
                con.close();
            }
            return msj;
        }
        public string delete(int cl)
        {
            try
            {
                string query = "DELETE FROM rol_usuario WHERE id_rol_usuario = @cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod", cl);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Rol eliminado con éxito!";
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }
            finally
            {
                con.close();
            }
            return msj;
        }
    }
}
