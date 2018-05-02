using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Controller 
{
    public class ClienteService
    {
        private SqlCommand cmd;
        private Conexion con = new Conexion();
        private string msj="Ocurrio un problema, intente mas tarde.";
        public List<Clientes> allCliente() {
        List<Clientes> lstClientes = null;
            Clientes cl = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM Clientes";
                cmd = new SqlCommand(query, con.getConex());
                con.Dr = cmd.ExecuteReader();
                lstClientes = new List<Clientes>();
                while (con.Dr.Read())
                {
                    cl = new Clientes();
                    cl.CodCliente = con.Dr.GetInt32(0);
                    cl.PNombre = con.Dr.GetString(1);
                    cl.SNombre = con.Dr.GetString(2);
                    cl.PApellido = con.Dr.GetString(3);
                    cl.SApellido = con.Dr.GetString(4);
                    cl.Direccion = con.Dr.GetString(5);
                    cl.Nit = con.Dr.GetString(6);
                    cl.Nrc = con.Dr.GetString(7);
                    cl.Telefono = con.Dr.GetString(8);
                    cl.Celular = con.Dr.GetString(9);
                    lstClientes.Add(cl);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                lstClientes = null;
            }
            finally {
                con.close();
            }
            return lstClientes;
     }
        public string insert(Clientes cl) {
            try
            {
                string query = "INSERT INTO Clientes VALUES(@pnom,@snom,@pape,@sape,@dir,@nit,@nrc,@tel,@cell)";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@pnom", cl.PNombre);
                cmd.Parameters.AddWithValue("@snom",cl.SNombre);
                cmd.Parameters.AddWithValue("@pape", cl.PApellido);
                cmd.Parameters.AddWithValue("@sape", cl.SApellido);
                cmd.Parameters.AddWithValue("@dir", cl.Direccion);
                cmd.Parameters.AddWithValue("@nit", cl.Nit);
                cmd.Parameters.AddWithValue("@nrc", cl.Nrc);
                cmd.Parameters.AddWithValue("@tel", cl.Telefono);
                cmd.Parameters.AddWithValue("@cell", cl.Celular);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj="Cliente: "+cl.PNombre+" guardado con éxito!";
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
        public string update(Clientes cl)
        {
            try
            {
                string query = "UPDATE Clientes SET pnombre = @pnom, ";
                query += "snombre = @snom, papellido = @pape, ";
                query += "sapellido = @sape, dir_cli = @dir, NIT = @nit, NRC = @nrc, Telefono = @tel, Celular = @cell";
                query += " WHERE cod_cli = @cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@pnom", cl.PNombre);
                cmd.Parameters.AddWithValue("@snom", cl.SNombre);
                cmd.Parameters.AddWithValue("@pape", cl.PApellido);
                cmd.Parameters.AddWithValue("@sape", cl.SApellido);
                cmd.Parameters.AddWithValue("@dir", cl.Direccion);
                cmd.Parameters.AddWithValue("@nit", cl.Nit);
                cmd.Parameters.AddWithValue("@nrc", cl.Nrc);
                cmd.Parameters.AddWithValue("@tel", cl.Telefono);
                cmd.Parameters.AddWithValue("@cell", cl.Celular);
                cmd.Parameters.AddWithValue("@cod", cl.CodCliente);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Cliente: " + cl.PNombre + " modificado con éxito!";
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
                string query = "DELETE FROM Clientes WHERE cod_cli = @cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod", cl);
                if (cmd.ExecuteNonQuery()==1)
                    return msj = "Cliente eliminado con éxito!";
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
