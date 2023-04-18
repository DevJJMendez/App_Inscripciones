using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace Datos
{
    public class clsConexion
    {
        MySqlConnection objConexion;
        string strConexion;
        public void fntConectar()
        {
            objConexion = new MySqlConnection();
            //************* CONEXION LOCAL ******************
            String servidor = "localhost";
            String bd = "dbs_tractora";
            String usuario = "root";
            String contraseña = "";
            String puerto = "3306";


            strConexion = "server=" + servidor + ";port=" + puerto + ";user id=" + usuario + ";password=" + contraseña + ";database=" + bd + ";";
            try
            {
                objConexion.ConnectionString = strConexion;
                objConexion.Open();
                //MessageBox.Show("Conexión establecida con el servidor de bases de datos");
            }
            catch (Exception)
            {
                MessageBox.Show("No es posible conectar con el servidor de bases de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return conex;
            }
        }
        public void fntDesconectar() { objConexion.Close(); }
    }
}
