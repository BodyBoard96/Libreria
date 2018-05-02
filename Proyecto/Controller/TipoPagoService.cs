using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class TipoPagoService
    {
        private SqlCommand cmd;
        private Conexion con = new Conexion();
        private string msj = "Ocurrio un problema, intente mas tarde.";
        public List<TipoPago> allSucursales()
        {
            List<TipoPago> lstTipos = null;
            TipoPago cl = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM tipo_pago";
                cmd = new SqlCommand(query, con.getConex());
                con.Dr = cmd.ExecuteReader();
                lstTipos = new List<TipoPago>();
                while (con.Dr.Read())
                {
                    cl = new TipoPago();
                    cl.CodigoTipoPago = con.Dr.GetInt32(0);
                    cl.TipoPaga = con.Dr.GetString(1);
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
        public TipoPago sucursalByCodigo(int code)
        {
            TipoPago cl = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM tipo_pago WHERE cod_tipo_pago=@cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod", code);
                con.Dr = cmd.ExecuteReader();
                while (con.Dr.Read())
                {
                    cl = new TipoPago();
                    cl.CodigoTipoPago = con.Dr.GetInt32(0);
                    cl.TipoPaga = con.Dr.GetString(1);
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
        public string insert(TipoPago cl)
        {
            try
            {
                string query = "INSERT INTO tipo_pago VALUES (@nombreRol)";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@nombreRol", cl.TipoPaga);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Tipo pago guardado con éxito!";
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
        public string update(TipoPago cl)
        {
            try
            {
                string query = "UPDATE tipo_pago SET ";
                query += "tipo_pago=@name WHERE cod_tipo_pago=@id";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@name", cl.TipoPaga);
                cmd.Parameters.AddWithValue("@id", cl.CodigoTipoPago);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Tipo pago modificado con éxito!";
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
                string query = "DELETE FROM tipo_pago WHERE cod_tipo_pago = @cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod", cl);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Tipo pago eliminado con éxito!";
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
