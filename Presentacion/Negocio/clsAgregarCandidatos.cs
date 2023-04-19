using Datos;
namespace Negocio
{
    public class clsAgregarCandidatos
    {
        private string str_Id;
        private string str_Pnombre;
        private string str_Snombre;
        private string str_Papellido;
        private string str_Sapellido;
        private string str_Contacto;
        private string str_Direccion;
        private string str_Correo;
        private string str_Edad;
        private int int_Estudio;
        private string str_Acudientes;
        private string str_msn;//enviar mensaje a la capa de presentación.

        public clsAgregarCandidatos(string str_Id, string str_Pnombre, string str_Snombre, string str_Papellido, string str_Sapellido, string str_Contacto, string str_Direccion, string str_Correo, string str_Edad, int int_Estudio, string str_Acudientes)
        {
            this.str_Id = str_Id;
            this.str_Pnombre = str_Pnombre;
            this.str_Snombre = str_Snombre;
            this.str_Papellido = str_Papellido;
            this.str_Sapellido = str_Sapellido;
            this.str_Contacto = str_Contacto;
            this.str_Direccion = str_Direccion;
            this.str_Correo = str_Correo;
            this.str_Edad = str_Edad;
            this.int_Estudio = int_Estudio;
            this.str_Acudientes = str_Acudientes;
            if (str_Id == "" || str_Pnombre == "" || str_Snombre == "" ||
                str_Papellido == "" || str_Sapellido == "" || str_Contacto == "" || str_Direccion == "" || str_Correo == "" || str_Edad == "" || str_Acudientes == "")
            {
                str_msn = "Debe ingresar toda la información requerida";
            }
            else
            {
                clsFunciones_Candidatos objGuardar = new clsFunciones_Candidatos();
                objGuardar.fntGuardar(str_Id, str_Pnombre, str_Snombre, str_Papellido, str_Sapellido,
                    str_Contacto, str_Direccion, str_Correo,
                    str_Edad, int_Estudio, str_Acudientes);
                str_msn = $"El candidato {str_Pnombre} {str_Papellido} ha sido registrado";
            }
        }
        public string getMsn()
        {
            return str_msn;
        }
    }
}
