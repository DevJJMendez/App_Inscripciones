using Datos;
using System.Data;

namespace Negocio
{
    public class clsNivelEstudio
    {
        private DataTable dt;
        public void fntCargarTipoEstudio()
        {
            clsFunciones_Candidatos objDT = new clsFunciones_Candidatos();
            objDT.fntCargarComboBox();
            this.dt = objDT.getDt();
        }
        public DataTable getDt() => this.dt;
    }
}
