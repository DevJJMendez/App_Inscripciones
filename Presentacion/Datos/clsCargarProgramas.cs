using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class clsCargarProgramas
    {
        private DataTable dtProgramas;
        public void fntCargarProgramas()
        {
            string sql = "select PKCodigo,Nombre from tbl_programas";
            clsConexion objConecta = new clsConexion();
            objConecta.fntConectar();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objConecta.objConexionSQL);
                dtProgramas = new DataTable();
                MySqlDataAdapter objData = new MySqlDataAdapter(comando);
                objData.Fill(dtProgramas);

            }
            catch (Exception)
            {

            }
        }
        public DataTable getdtProgramas()
        {
            return this.dtProgramas;
        }
    }
}
