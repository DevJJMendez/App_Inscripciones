using MySql.Data.MySqlClient;
using System;
using System.Globalization;
namespace Datos
{
    public class clsFunciones_Candidatos
    {
        public void fntGuardar(String Id, string pNombre, string sNombre, string pApellido, string sApellido, string Contacto, string Direccion, string Correo, string Edad, int Estudio, string Acudientes)
        {
			try
			{
				clsConexion objConexion = new clsConexion();
				objConexion.fntConectar();
				string strConsulta = "insert into tbl_personas(PKId,P_Nombre,S_Nombre,P_Apellido,S_Apellido,Contacto,Dirección,Correo,Edad,FKCodigo_tbl_nivelestudio,Acudiente)" + "values('"+Id+"','"+pNombre+"','"+sNombre+"','"+pApellido+"','"+sApellido+"','" + Contacto+"','"+Direccion+"','"+Correo+"','"+Edad+"','"+Estudio+"','"+Acudientes+"')";

				MySqlCommand objComando = new MySqlCommand(strConsulta, objConexion.objConexionSQL);

				MySqlDataReader objLectura = objComando.ExecuteReader();

				objConexion.fntDesconectar();
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
