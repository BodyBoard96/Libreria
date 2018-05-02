using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Conexion{
        private string stringConexion = Util.DATA_SOURCE;
        private SqlDataReader dr;
        private SqlConnection con;

        public SqlDataReader Dr {get {return dr;} set { dr = value;}}

        public void close() {
            try
            {
                Dr.Close();
                con.Close();
            }
            catch (Exception e) {
            }
        }

        public SqlConnection getConex() {
            try
            {
                con = new SqlConnection(stringConexion);
                con.Open();
            }
            catch (Exception e)
            {
                //Logger
            }
            return con;
        }
    }
}
