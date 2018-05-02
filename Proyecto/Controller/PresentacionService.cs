using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class PresentacionService
    {
        private SqlCommand cmd;
        private Conexion con = new Conexion();
        private string msj = "Ocurrio un problema, intente mas tarde.";
        public List<Presentacion> allSucursales()
        {
            List<Presentacion> lstTipos = null;
            Presentacion cl = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM Presentacion";
                cmd = new SqlCommand(query, con.getConex());
                con.Dr = cmd.ExecuteReader();
                lstTipos = new List<Presentacion>();
                while (con.Dr.Read())
                {
                    cl = new Presentacion();
                    cl.CodPresentacion = con.Dr.GetInt32(0);
                    cl.Descripcion = con.Dr.GetString(1);
                    cl.CantidadUnidad = con.Dr.GetDecimal(2);
                    lstTipos.Add(cl);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                lstTipos = null;
            }
            finally
            {
                con.close();
            }
            return lstTipos;
        }
        public Presentacion sucursalByCodigo(int code)
        {
            Presentacion cl = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM Presentacion WHERE cod_pre=@cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod", code);
                con.Dr = cmd.ExecuteReader();
                while (con.Dr.Read())
                {
                    cl = new Presentacion();
                    cl.CodPresentacion = con.Dr.GetInt32(0);
                    cl.Descripcion = con.Dr.GetString(1);
                    cl.CantidadUnidad = con.Dr.GetDecimal(2);
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
        public string insert(Presentacion cl)
        {
            try
            {
                string query = "INSERT INTO Presentacion VALUES (@desc,@can)";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@desc", cl.Descripcion);
                cmd.Parameters.AddWithValue("@nombreRol", cl.CantidadUnidad);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Presentación guardada con éxito!";
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
        public string update(Presentacion cl)
        {
            try
            {
                string query = "UPDATE Presentacion SET ";
                query += "descripcion_pre=@des, con_uni_pre=@can WHERE cod_pre=@id";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@des", cl.Descripcion);
                cmd.Parameters.AddWithValue("@can", cl.CantidadUnidad);
                cmd.Parameters.AddWithValue("@id", cl.CodPresentacion);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Presetación modificada con éxito!";
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
                string query = "DELETE FROM Presentacion WHERE cod_pre = @cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod", cl);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Presentación eliminada con éxito!";
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
