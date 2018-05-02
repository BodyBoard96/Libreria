using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class ColoresService
    {
        private SqlCommand cmd;
        private Conexion con = new Conexion();
        private string msj = "Ocurrio un problema, intente mas tarde.";
        public List<Colores> allColores()
        {
            List<Colores> lstColores = null;
            Colores cl = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM colores";
                cmd = new SqlCommand(query, con.getConex());
                con.Dr = cmd.ExecuteReader();
                lstColores = new List<Colores>();
                while (con.Dr.Read())
                {
                    cl = new Colores();
                    cl.CodColor = con.Dr.GetInt32(0);
                    cl.Color = con.Dr.GetString(1);
                    lstColores.Add(cl);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                lstColores = null;
            }
            finally
            {
                con.close();
            }
            return lstColores;
        }
        public string insert(Colores cl)
        {
            try
            {
                string query = "INSERT INTO colores VALUES(@pnom)";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@pnom", cl.Color);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Color: " + cl.Color + " guardado con éxito!";
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
        public string update(Colores cl)
        {
            try
            {
                string query = "UPDATE colores SET color = @color ";
                query += "WHERE cod_color = @cod ";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@color", cl.Color);
                cmd.Parameters.AddWithValue("@cod", cl.CodColor);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Color: " + cl.Color + " modificado con éxito!";
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
                string query = "DELETE FROM colores WHERE cod_color = @cod";
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
