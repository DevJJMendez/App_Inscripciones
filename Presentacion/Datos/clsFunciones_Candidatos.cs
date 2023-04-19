using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
namespace Datos
{
    public class clsFunciones_Candidatos
    {
        private DataTable dt;
        public void fntGuardar(String Id, string pNombre, string sNombre, string pApellido, string sApellido, string Contacto, string Direccion, string Correo, string Edad, int Estudio, string Acudientes)
        {
			try
			{
				clsConexion objConexion = new clsConexion();
				objConexion.fntConectar();
				string strConsulta = "insert into tbl_personas(PKId,P_Nombre,S_Nombre,P_Apellido,S_Apellido,Contacto,Dirección,Correo,Edad,FKCodigo_tbl_nivelestudio,Acudiente)values('"+Id+"','"+pNombre+"','"+sNombre+"','"+pApellido+"','"+sApellido+"','" + Contacto+"','"+Direccion+"','"+Correo+"','"+Edad+"','"+Estudio+"','"+Acudientes+"')";

				MySqlCommand objComando = new MySqlCommand(strConsulta, objConexion.objConexionSQL);

				MySqlDataReader objLectura = objComando.ExecuteReader();

				objConexion.fntDesconectar();
			}
			catch (Exception){}
        }
		public void fntCargarComboBox()
		{
            string sql = "select PKCodigo,Nombre from tbl_nivelestudio";
            clsConexion objConecta = new clsConexion();
            objConecta.fntConectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objConecta.objConexionSQL);
                dt = new DataTable();
                MySqlDataAdapter objData = new MySqlDataAdapter(comando);
                objData.Fill(dt);
                
            }
            catch (Exception)
            {
                objConecta.fntDesconectar();
            }
        }
        public DataTable getDt()
        { return this.dt; 
        }
    }
}
