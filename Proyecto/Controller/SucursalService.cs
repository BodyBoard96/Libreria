using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Controller 
{
    public class SucursalService
    {
        private SqlCommand cmd;
        private Conexion con = new Conexion();
        private string msj = "Ocurrio un problema, intente mas tarde.";
        public List<Sucursal> allSucursales()
        {
            List<Sucursal> lstSucursal = null;
            Sucursal cl = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM sucursal";
                cmd = new SqlCommand(query, con.getConex());
                con.Dr = cmd.ExecuteReader();
                lstSucursal = new List<Sucursal>();
                while (con.Dr.Read())
                {
                    cl = new Sucursal();
                    cl.CodSucursal = con.Dr.GetInt32(0);
                    cl.Direccion = con.Dr.GetString(1);
                    cl.Telefono = con.Dr.GetString(2);
                    cl.Email = con.Dr.GetString(3);
                    lstSucursal.Add(cl);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                lstSucursal = null;
            }
            finally
            {
                con.close();
            }
            return lstSucursal;
        }

        public Sucursal sucursalByCodigo(int code)
        {
            Sucursal cl = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM sucursal WHERE cod_su=@cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod", code);
                con.Dr = cmd.ExecuteReader();
                while (con.Dr.Read())
                {
                    cl = new Sucursal();
                    cl.CodSucursal = con.Dr.GetInt32(0);
                    cl.Direccion = con.Dr.GetString(1);
                    cl.Telefono = con.Dr.GetString(2);
                    cl.Email = con.Dr.GetString(3);
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
        public string insert(Sucursal cl)
        {
            try
            {
                string query = "INSERT INTO sucursal VALUES (@Direcion,@telefono,@Email)";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@Direcion", cl.Direccion);
                cmd.Parameters.AddWithValue("@telefono", cl.Telefono);
                cmd.Parameters.AddWithValue("@Email", cl.Email);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Sucursal guardada con éxito!";
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
        public string update(Sucursal cl)
        {
            try
            {
                string query = "UPDATE sucursal SET ";
                query += "Direcion=@Direcion,telefono=@telefono,Email=@Email WHERE cod_su = @cod ";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@Direcion", cl.Direccion);
                cmd.Parameters.AddWithValue("@telefono", cl.Telefono);
                cmd.Parameters.AddWithValue("@Email", cl.Email);
                cmd.Parameters.AddWithValue("@cod", cl.CodSucursal);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Sucursal modificada con éxito!";
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
                string query = "DELETE FROM sucursal WHERE cod_suc = @cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod", cl);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Colore eliminado con éxito!";
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
