using Datos;
using System.Data;

namespace Negocio
{
//--Creación de la clase nivelEstudio---------------------------------------------------------------------------------------------------------------------------------------------
    public class clsNivelEstudio
    {
//------Creación de un DataTable para almacenar los datos traidos de la base de datos y asi cargarlos al ComboBox-----------------------------------------------------------------
        private DataTable dt;
/*------Creación de la función CargarTipoEstudio----------------------------------------------------------------------------------------------------------------------------------
--------Instacia de la clase clsFuncion_Candidatos de la capa Datos y creación del objeto objDT para obtener la función fntCargarComboBox----------------------------------------------------------
*/ 
        public void fntCargarTipoEstudio()
        {
            clsFunciones_Candidatos objDT = new clsFunciones_Candidatos();
            objDT.fntCargarComboBox();
            this.dt = objDT.getDt();
        }
//------Función-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DataTable getDt()
        {
            return this.dt; 
        }
    }
}
