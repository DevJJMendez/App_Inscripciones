using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clsIncripciones
    {
        private string Id;
        private string Nombre;
        private string Correo;
        private string Direccion;
        private string Contacto;
        private int programaFormacion;
        private string msj;

        public clsIncripciones(string Id, string Nombre, string Correo, string Direccion, string Contacto, int programaFormacion)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Correo = Correo;
            this.Direccion = Direccion;
            this.Contacto = Contacto;
            this.programaFormacion = programaFormacion;
            if (string.IsNullOrEmpty(Id) || string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Correo) || string.IsNullOrEmpty(Direccion) || string.IsNullOrEmpty(Contacto))
            {
                msj = "Debe ingresar toda la información requerida";
            }else
            {
                clsConsultarCandidato objConsultarI = new clsConsultarCandidato();
                objConsultarI.fntConsultar(Id);
                this.Id = objConsultarI.getPNombre();
                this.Correo = objConsultarI.getCorreo();
                this.Direccion = objConsultarI.getDireccion();
            }
        }
    }
}
