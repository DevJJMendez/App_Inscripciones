using Negocio;
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
//------Función para cargar los comboBox-----------------------------------------------------------------------------
        private void fntCargarProgramas()
        {
            clsProgramas objdtProgramas = new clsProgramas();
            objdtProgramas.fntCargarProgramas();
            cbxProgramas.ValueMember = "PKCodigo";
            cbxProgramas.DisplayMember = "Nombre";
            cbxProgramas.DataSource = objdtProgramas.getdtProgramas();
        }
//------Función consultar, Capa negocio-------------------------------------------------------------------------------
        private void fntConsultaI(string Id)
        {
            clsConsultarCandidato objConsultarI = new clsConsultarCandidato();
            objConsultarI.fntConsultar(Id);
            tbxNombres.Text = objConsultarI.getPNombre() + " " + objConsultarI.getPApellido();
            tbxCorreo.Text = objConsultarI.getCorreo();
            tbxDireccion.Text = objConsultarI.getDireccion();
            tbxContacto.Text = objConsultarI.getContacto();
            pbxImagen.Image = objConsultarI.getBmp();
        }
//------llamado de la función consultar---------------------------------------------------------------------------------
        private void tbxID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fntConsultaI(tbxID.Text);
            }
        }
    }
}
