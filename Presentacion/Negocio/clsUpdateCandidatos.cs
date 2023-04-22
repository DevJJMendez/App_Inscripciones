using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clsUpdateCandidatos
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
        private string msj;

        public clsUpdateCandidatos(string Id, string pNombre, string sNombre, string pApellido, string sApellido, string Contacto, string Direccion, string Correo, string Edad, int Estudio, string Acudientes)
        {
            this.str_Id = Id;
            this.str_Pnombre = pNombre;
            this.str_Snombre = sNombre;
            this.str_Papellido = pApellido;
            this.str_Sapellido = sApellido;
            this.str_Contacto = Contacto;
            this.str_Direccion = Direccion;
            this.str_Correo = Correo;
            this.str_Edad = Edad;
            this.int_Estudio = Estudio;
            this.str_Acudientes = Acudientes;
            if (string.IsNullOrEmpty(str_Id) || string.IsNullOrEmpty(str_Pnombre) ||
                 string.IsNullOrEmpty(str_Papellido) || string.IsNullOrEmpty(str_Contacto) || string.IsNullOrEmpty(str_Direccion) || string.IsNullOrEmpty(str_Correo) || string.IsNullOrEmpty(str_Edad))
            {
                msj = "Debe ingresar toda la información requerida";
            }
//----------Creación del objeto de la clase que esta en la capa datos-------------------------------------------------------------------------------------------------------------
            else
            {
                clsFunciones_Candidatos objUpdate = new clsFunciones_Candidatos();
                objUpdate.fntUpdate(str_Id, str_Pnombre, str_Snombre, str_Papellido, str_Sapellido,
                    str_Contacto, str_Direccion, str_Correo,
                    str_Edad, int_Estudio, str_Acudientes);
                msj = $"El candidato ha sido actualizado";
            }
        }
        public string GetMsj()
        {
            return msj;
        }
    }
}
