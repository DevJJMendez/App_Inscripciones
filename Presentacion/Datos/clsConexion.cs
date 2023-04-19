using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
namespace Datos
{
    public class clsConexion
    {
        public MySqlConnection objConexionSQL;
        string strConexion;
        public void fntConectar()
        {
            objConexionSQL = new MySqlConnection();
            //************* CONEXION LOCAL ******************
            String servidor = "10.230.16.156";
            String bd = "dbs_inscripcion_jjmendez";
            String usuario = "yoyito";
            String contraseña = "Sena2023";
            String puerto = "3306";

            strConexion = "server=" + servidor + ";port=" + puerto + ";user id=" + usuario + ";password=" + contraseña + ";database=" + bd + ";";
            try
            {
                objConexionSQL.ConnectionString = strConexion;
                objConexionSQL.Open();
                //MessageBox.Show("Conexión establecida con el servidor de bases de datos");
            }
            catch (Exception)
            {
                //MessageBox.Show("No es posible conectar con el servidor de bases de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return conex;
            }
        }
        public void fntDesconectar() { objConexionSQL.Close(); }
    }
}
