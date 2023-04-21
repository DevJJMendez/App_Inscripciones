using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class clsProgramas
    {
        private DataTable dtProgramas;

        public void fntCargarProgramas()
        {
            clsCargarProgramas objdtProgramas = new clsCargarProgramas();
            objdtProgramas.fntCargarProgramas();
            this.dtProgramas = objdtProgramas.getdtProgramas();
        }
        public DataTable getdtProgramas()
        {
            return this.dtProgramas;
        }
    }
}
