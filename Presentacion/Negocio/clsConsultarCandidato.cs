using Datos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clsConsultarCandidato
    {
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
        public void fntConsultar(string Id)
        {
            clsFunciones_Candidatos objConsultarC = new clsFunciones_Candidatos();
            objConsultarC.fntConsultar(Id);
            this.bmp = objConsultarC.getBmp();
            this.strPNombre = objConsultarC.getPNombre();
            this.strSNombre = objConsultarC.getSNombre();
            this.strPApellido = objConsultarC.getPApellido();
            this.strSApellido = objConsultarC.getSApellido();
            this.strContacto = objConsultarC.getContacto();
            this.strDireccion = objConsultarC.getDireccion();
            this.strCorreo = objConsultarC.getCorreo();
            this.strEdad = objConsultarC.getEdad();
            this.intEstudio = objConsultarC.getEstudio();
            this.strAcudientes = objConsultarC.getAcudientes();

        }
        public Bitmap getBmp()
        {
            return bmp;
        }
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
