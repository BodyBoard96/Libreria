using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Controller 
{
    public class ProveedorService
    {
        private SqlCommand cmd;
        private Conexion con = new Conexion();
        private string msj = "Ocurrio un problema, intente mas tarde.";
        public List<Proveedor> allProveedor()
        {
            List<Proveedor> lstObj = null;
            Proveedor obj = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM Proveedor";
                cmd = new SqlCommand(query, con.getConex());
                con.Dr = cmd.ExecuteReader();
                lstObj = new List<Proveedor>();
                while (con.Dr.Read())
                {
                    obj = new Proveedor();
                    obj.CodProveedor = con.Dr.GetInt32(0);
                    obj.Nombre = con.Dr.GetString(1);
                    obj.NombreEjecutivo = con.Dr.GetString(2);
                    obj.Nrc = con.Dr.GetString(3);
                    obj.Nit = con.Dr.GetString(4);
                    obj.DireccionProveedor = con.Dr.GetString(5);
                    obj.Telefono = con.Dr.GetString(6);
                    obj.CelularEjecutivo = con.Dr.GetString(7);
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
        public string insert(Proveedor cl)
        {
            try
            {
                string query = "INSERT INTO Proveedor";
                query += " VALUES (@nom_prov,@nom_ejec,@NRC,@NIT,@dir_prov,@telefono,@celular_ejec)";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@nom_prov", cl.Nombre);
                cmd.Parameters.AddWithValue("@nom_ejec", cl.NombreEjecutivo);
                cmd.Parameters.AddWithValue("@NRC", cl.Nrc);
                cmd.Parameters.AddWithValue("@NIT", cl.Nit);
                cmd.Parameters.AddWithValue("@dir_prov", cl.DireccionProveedor);
                cmd.Parameters.AddWithValue("@telefono", cl.Telefono);
                cmd.Parameters.AddWithValue("@celular_ejec", cl.CelularEjecutivo);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Proveedor: " + cl.Nombre + " guardado con éxito!";
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
        public string update(Proveedor cl)
        {
            try
            {
                string query = "UPDATE Proveedor SET ";
                query += "nom_prov=@nom_prov,nom_ejec=@nom_ejec,NRC=@NRC,NIT=@NIT,dir_prov=@dir_prov,=telefono,celular_ejec=@celular_ejec";
                query += "WHERE cod_prov = @cod ";
                cmd = new SqlCommand(query, con.getConex());
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@nom_prov", cl.Nombre);
                cmd.Parameters.AddWithValue("@nom_ejec", cl.NombreEjecutivo);
                cmd.Parameters.AddWithValue("@NRC", cl.Nrc);
                cmd.Parameters.AddWithValue("@NIT", cl.Nit);
                cmd.Parameters.AddWithValue("@dir_prov", cl.DireccionProveedor);
                cmd.Parameters.AddWithValue("@telefono", cl.Telefono);
                cmd.Parameters.AddWithValue("@celular_ejec", cl.CelularEjecutivo);
                cmd.Parameters.AddWithValue("@cod", cl.CodProveedor);
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
                string query = "DELETE FROM Proveedor WHERE cod_prov = @cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod", cl);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Proveedor eliminado con éxito!";
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
