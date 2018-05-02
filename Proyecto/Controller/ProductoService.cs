using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class ProductoService
    {
        private SqlCommand cmd;
        private Conexion con = new Conexion();
        private string msj = "Ocurrio un problema, intente mas tarde.";
        public List<Producto> allProducto()
        {
            List<Producto> lstObj = null;
            Producto obj = null;
            Colores col = null;
            Proveedor prov = null;
            Presentacion pre = null;
            Sucursal suc = null;
            Conexion con = new Conexion();
            try
            {
                string query = "SELECT * FROM Producto";
                cmd = new SqlCommand(query, con.getConex());
                con.Dr = cmd.ExecuteReader();
                lstObj = new List<Producto>();
                while (con.Dr.Read())
                {
                    obj = new Producto();
                    col = new Colores();
                    prov = new Proveedor();
                    pre = new Presentacion();
                    suc = new Sucursal();
                    obj.CodProducto = con.Dr.GetInt32(0);
                    col.CodColor = con.Dr.GetInt32(1);
                    obj.CodColor = col;
                    pre.CodPresentacion = con.Dr.GetInt32(2);
                    obj.CodPresentacion = pre;
                    obj.CodigoBarras = con.Dr.GetString(3);
                    obj.NombreProducto = con.Dr.GetString(4);
                    obj.PrecioCompra = con.Dr.GetDecimal(5);
                    prov.CodProveedor = con.Dr.GetInt32(6);
                    obj.CodProveedor = prov;
                    obj.PrecioVenta = con.Dr.GetDecimal(7);
                    suc.CodSucursal = con.Dr.GetInt32(8);
                    obj.Sucursal = suc;
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
        public string insert(Producto cl)
        {
            try
            {
                string query = "INSERT INTO Producto ";
                query += "VALUES (@cod_pro,@cod_color,@cod_pre,@cod_barras,@nom_pro,@pre_compra,@cod_prov,@pre_venta,@cod_su)";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod_pro", cl.CodProducto);
                cmd.Parameters.AddWithValue("@cod_color", cl.CodColor);
                cmd.Parameters.AddWithValue("@cod_pre", cl.CodPresentacion);
                cmd.Parameters.AddWithValue("@cod_barras", cl.CodigoBarras);
                cmd.Parameters.AddWithValue("@nom_pro", cl.NombreProducto);
                cmd.Parameters.AddWithValue("@pre_compra", cl.PrecioCompra);
                cmd.Parameters.AddWithValue("@cod_prov", cl.CodProveedor);
                cmd.Parameters.AddWithValue("@pre_venta", cl.PrecioVenta);
                cmd.Parameters.AddWithValue("@cod_su", cl.Sucursal);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Producto: " + cl.NombreProducto + " guardado con éxito!";
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
        public string update(Producto cl)
        {
            try
            {
                string query = "UPDATE Producto SET ";
                query += "cod_color=@cod_color,cod_pre=@cod_pre,cod_barras=@cod_barras,nom_pro=@nom_pro,pre_compra=@pre_compra,cod_prov=@cod_prov,pre_venta=@pre_venta,cod_su=@cod_su";
                query += "WHERE cod_pro=@cod_pro";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod_pro", cl.CodProducto);
                cmd.Parameters.AddWithValue("@cod_color", cl.CodColor);
                cmd.Parameters.AddWithValue("@cod_pre", cl.CodPresentacion);
                cmd.Parameters.AddWithValue("@cod_barras", cl.CodigoBarras);
                cmd.Parameters.AddWithValue("@nom_pro", cl.NombreProducto);
                cmd.Parameters.AddWithValue("@pre_compra", cl.PrecioCompra);
                cmd.Parameters.AddWithValue("@cod_prov", cl.CodProveedor);
                cmd.Parameters.AddWithValue("@pre_venta", cl.PrecioVenta);
                cmd.Parameters.AddWithValue("@cod_su", cl.Sucursal);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Producto: " + cl.NombreProducto + " modificado con éxito!";
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
                string query = "DELETE FROM Producto WHERE cod_pro = @cod";
                cmd = new SqlCommand(query, con.getConex());
                cmd.Parameters.AddWithValue("@cod", cl);
                if (cmd.ExecuteNonQuery() == 1)
                    return msj = "Producto eliminado con éxito!";
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
