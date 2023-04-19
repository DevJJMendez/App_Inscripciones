using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmCandidatos : Form
    {
        public frmCandidatos()
        {
            InitializeComponent();
        }

        private void fntCargarComboBox()
        {
            
        }
        private void fntClean()
        {
            tbxID.Clear();
            tbxPnombre.Clear();
            tbxSnombre.Clear();
            tbxPapellido.Clear();
            tbxSapellido.Clear();
            tbxAcudientes.Clear();
            tbxContacto.Clear();
            tbxCorreo.Clear();
            tbxDireccion.Clear();
            tbxEdad.Clear();
            cbxNestudio.SelectedIndex = 0;
            
        }
        private void ptbNewUser_Click(object sender, EventArgs e)
        {
            fntClean();
        }
    }
}
