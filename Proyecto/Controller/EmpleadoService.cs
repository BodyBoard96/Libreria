using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class EmpleadoService
    {
        private SqlCommand cmd;
        private Conexion con = new Conexion();
        private string msj = "Ocurrio un problema, intente mas tarde.";
        public List<Empleado> allEmpleado()
        {
            List<Empleado> lstObj = null;
            Empleado obj = null;
            RolUsuario rl = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM Empleado";
                cmd = new SqlCommand(query, con.getConex());
                con.Dr = cmd.ExecuteReader();
                lstObj = new List<Empleado>();
                while (con.Dr.Read())
                {
                    obj = new Empleado();
                    obj.CodEmpleado = con.Dr.GetInt32(0);
                    obj.Nombre = con.Dr.GetString(1);
                    obj.Direccion = con.Dr.GetString(2);
                    obj.Cargo = con.Dr.GetString(3);
                    obj.Telefono = con.Dr.GetString(4);
                    obj.Celular = con.Dr.GetString(5);
                    obj.Usuario = con.Dr.GetString(6);
                    obj.Password = con.Dr.GetString(7);
                    obj.IdRol = con.Dr.GetInt32(8);
                    obj.Comision = con.Dr.GetDecimal(9);
                    lstObj.Add(obj);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                lstObj = null;
            }
            finally
            {
                con.close();
            }
            return lstObj;
        }
        public string insert(Empleado cl)
        {
            try
            {
                string query = "INSERT INTO Empleado ";
                query += "VALUES (@nom_emp, @dir_emp, @cargo, @telefono, @cel, @nom_usu, @pasword, @id_rol, @comision)";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@nom_emp", cl.Nombre);
                cmd.Parameters.AddWithValue("@dir_emp", cl.Direccion);
                cmd.Parameters.AddWithValue("@cargo", cl.Cargo);
                cmd.Parameters.AddWithValue("@telefono", cl.Telefono);
                cmd.Parameters.AddWithValue("@cel", cl.Celular);
                cmd.Parameters.AddWithValue("@nom_usu", cl.Usuario);
                cmd.Parameters.AddWithValue("@pasword", cl.Password);
                cmd.Parameters.AddWithValue("@id_rol", cl.IdRol);
                cmd.Parameters.AddWithValue("@comision", cl.Comision);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Nombre: " + cl.Nombre + " guardado con éxito!";
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
        public string update(Empleado cl)
        {
            try
            {
                string query = "UPDATE Empleado SET ";
                query += "nom_emp=@nom_emp, dir_emp=@dir_emp, cargo=@cargo, telefono=@telefono, cel=@cel, nom_usu=@nom_usu, pasword=@pasword, id_rol_usuario=@id_rol, comision=@comision";
                query += " WHERE cod_emp = @cod ";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@nom_emp", cl.Nombre);
                cmd.Parameters.AddWithValue("@dir_emp", cl.Direccion);
                cmd.Parameters.AddWithValue("@cargo", cl.Cargo);
                cmd.Parameters.AddWithValue("@telefono", cl.Telefono);
                cmd.Parameters.AddWithValue("@cel", cl.Celular);
                cmd.Parameters.AddWithValue("@nom_usu", cl.Usuario);
                cmd.Parameters.AddWithValue("@pasword", cl.Password);
                cmd.Parameters.AddWithValue("@id_rol", cl.IdRol);
                cmd.Parameters.AddWithValue("@comision", cl.Comision);
                cmd.Parameters.AddWithValue("@cod", cl.CodEmpleado);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Empleado: " + cl.Nombre + " modificado con éxito!";
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
                string query = "DELETE FROM Empleado WHERE cod_emp = @cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod", cl);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Empleado eliminado con éxito!";
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
