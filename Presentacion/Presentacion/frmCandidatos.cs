using Negocio;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmCandidatos : Form
    {
        public frmCandidatos()
        {
            InitializeComponent();
            fntCargarComboBox();
        }

        private void fntCargarComboBox()
        {
            clsNivelEstudio objdt = new clsNivelEstudio();
            objdt.fntCargarTipoEstudio();
            cbxNestudio.ValueMember = "PKCodigo";
            cbxNestudio.DisplayMember = "Nombre";
            cbxNestudio.DataSource = objdt.getDt();
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
            //cbxNestudio.SelectedIndex = 0;
            tbxID.Focus();
            
        }
        private void ptbNewUser_Click(object sender, EventArgs e)
        {
            fntClean();
        }

        private void pbxGuardar_Click(object sender, EventArgs e)
        {
            clsAgregarCandidatos objAgregarCandidato = new clsAgregarCandidatos(tbxID.Text, tbxPnombre.Text, tbxSnombre.Text, tbxPapellido.Text, tbxSapellido.Text, tbxContacto.Text, tbxDireccion.Text, tbxCorreo.Text, tbxEdad.Text, cbxNestudio.SelectedIndex+1, tbxAcudientes.Text);
            MessageBox.Show($"{objAgregarCandidato.getMsn()}");
        }
    }
}
