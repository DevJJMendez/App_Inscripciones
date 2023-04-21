using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmInscrip : Form
    {
        public frmInscrip()
        {
            InitializeComponent();
            fntCargarProgramas();
            
        }
//------Función para cargar los comboBox----------------------------------
        private void fntCargarProgramas()
        {
            clsProgramas objdtProgramas = new clsProgramas();
            objdtProgramas.fntCargarProgramas();
            cbxProgramas.ValueMember = "PKCodigo";
            cbxProgramas.DisplayMember = "Nombre";
            cbxProgramas.DataSource = objdtProgramas.getdtProgramas();
        }
//------Función consultar, Capa negocio-------------------------------------------------------------------------------------------------------------------------------------------
        private void fntConsultaI(string Id)
        {
            clsConsultarCandidato objConsultarI = new clsConsultarCandidato();
            objConsultarI.fntConsultar(Id);
            tbxNombres.Text = objConsultarI.getPNombre();
            tbxCorreo.Text = objConsultarI.getCorreo();
            tbxDireccion.Text = objConsultarI.getDireccion();
            tbxContacto.Text = objConsultarI.getContacto();
            pbxImagen.Image = objConsultarI.getBmp();
        }
//------Instanciación de la función consultar-------------------------------------------------------------------------------------------------------------------------------------
        private void tbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                fntConsultaI(tbxID.Text);
            }
        }
    }
}
