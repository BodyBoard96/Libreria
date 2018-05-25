using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class LoginService
    {
        private SqlCommand cmd;
        public Empleado validate(string user, string pass) {
            Conexion con = new Conexion();
            Empleado em = null;
            try
            {
                string query = "SELECT * FROM Empleado WHERE nom_usu = @user  AND pasword = @pass";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@user",user);
                cmd.Parameters.AddWithValue("@pass", pass);
                con.Dr = cmd.ExecuteReader();
                while (con.Dr.Read())
                {
                    em = new Empleado();
                    em.CodEmpleado = con.Dr.GetInt32(0);
                    em.Nombre = con.Dr.GetString(1);
                    em.Direccion = con.Dr.GetString(2);
                    em.Cargo = con.Dr.GetString(3);
                    em.Telefono = con.Dr.GetString(4);
                    em.Celular = con.Dr.GetString(5);
                    em.Usuario = con.Dr.GetString(6);
                    em.Password = con.Dr.GetString(7);
                    em.IdRol = con.Dr.GetInt32(8);
                    em.Comision = con.Dr.GetDecimal(9);
                }
                return em;
            }
            catch (Exception e)
            {
                em = null;
            }
            finally {
                con.close();
            }
            return em;
        }
    }
}
