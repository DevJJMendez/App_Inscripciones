using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;

namespace Datos
{
    public class clsFunciones_Candidatos
    {
        private DataTable dt;
        private Bitmap bmp;
        private string strPNombre;
        private string strSNombre;
        private string strPApellido;
        private string strSApellido;
        private string strContacto;
        private string strDireccion;
        private string strCorreo;
        private string strEdad;
        private int intEstudio;
        private string strAcudientes;
        public void fntGuardar(String Id, string pNombre, string sNombre, string pApellido, string sApellido, string Contacto, string Direccion, string Correo, string Edad, int Estudio, string Acudientes, byte[] imagen)
        {
			try
			{
				clsConexion objConexion = new clsConexion();
				objConexion.fntConectar();
				string strConsulta = "insert into tbl_personas(PKId,P_Nombre,S_Nombre,P_Apellido,S_Apellido,Contacto,Dirección,Correo,Edad,FKCodigo_tbl_nivelestudio,Acudiente,Imagen)values('"+Id+"','"+pNombre+"','"+sNombre+"','"+pApellido+"','"+sApellido+"','" + Contacto+"','"+Direccion+"','"+Correo+"','"+Edad+"','"+Estudio+"','"+Acudientes+"','"+imagen+"')";

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
                
            }
        }
        public DataTable getDt()
        {
            return this.dt;
        }
        public void fntConsultar(string Id)
        {
            String sql = "select P_Nombre,S_Nombre,P_Apellido,S_Apellido,Contacto,Dirección,Correo,Edad,FKCodigo_tbl_nivelestudio,Acudiente,Imagen from tbl_personas where PKId = '" + Id + "'";
            clsConexion objConsulta = new clsConexion();
            objConsulta.fntConectar();
            
                MySqlCommand comando = new MySqlCommand(sql, objConsulta.objConexionSQL);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream ms = new MemoryStream((byte[])reader["Imagen"]);
                    bmp = new Bitmap(ms);
                    strPNombre = reader["P_Nombre"].ToString();
                    strSNombre = reader["S_Nombre"].ToString();
                    strPApellido = reader["P_Apellido"].ToString();
                    strSApellido = reader["S_Apellido"].ToString();
                    strContacto = reader["Contacto"].ToString();
                    strDireccion = reader["Dirección"].ToString();
                    strCorreo = reader["Correo"].ToString();
                    strEdad = reader["Edad"].ToString();
                    intEstudio = Convert.ToInt16(reader["FKCodigo_tbl_nivelestudio"].ToString());
                    strAcudientes = reader["Acudiente"].ToString();
            }
                objConsulta.fntDesconectar();
        }
        public Bitmap getBmp() => bmp;
        public string getPNombre() => this.strPNombre;
        public string getSNombre() => this.strSNombre;
        public string getPApellido() => this.strPApellido;
        public string getSApellido() => this.strSApellido;
        public string getContacto() => this.strContacto;
        public string getDireccion() => this.strDireccion;
        public string getCorreo() => this.strCorreo;
        public string getEdad() => this.strEdad;
        public int getEstudio() => this.intEstudio;
        public string getAcudientes() => this.strAcudientes;
    }
}
