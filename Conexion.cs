using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Conexion
    {
        public static MySqlConnection conexion()
        {
            
            
                string servidor = "localhost";
                string bd = "tienda";
                string usuario = "root";
                string password = "";
            string cadenaConexion = "server="+servidor+";user id="+usuario+";Password="+password+";database="+bd+";SslMode=none";

                try
                {
                    MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                    return conexionBD;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            
        }
    }
}
