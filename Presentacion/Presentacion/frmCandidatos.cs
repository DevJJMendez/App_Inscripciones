using Negocio;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
/*
 * para establecer una imagen: 
 * se crea una variable tipo string
 * string rutaDirectorio;
 * 
 * luego se establece una ruta:
 * rutaDirectorio = Path.Combine(Application.StartupPath + "\\Imagenes");
 * 
 * se guarda la imagen en la carpeta imagenes
 * 
 * luego:
 * ptbUser.Image = Image.FromFile(rutaDirectorio + "\\user.png");
 * en la función limpiar
 * 
 * y luego se llama la funcion limpiar en el form
 * fntClean();
 * 
 * 
 * para insertar fotos :
 * 
 * private void ptbUser_Click(object sender, EventArgs e)
        {
            try
            {
                rutaDirectorio = Path.Combine(Application.StartupPath + "\\Imagenes");
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Archivo JPG|*.jpg";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    ptbUser.Image = Image.FromFile(file.FileName);
                }
            }
            catch {}
        }
 * */
namespace Presentacion
{
    public partial class frmCandidatos : Form
    {
        string rutaDirectorio;
        public frmCandidatos()
        {
            InitializeComponent();
            fntCargarComboBox();
            rutaDirectorio = Path.Combine(Application.StartupPath + "\\Imagenes");
            fntClean();
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
            ptbUser.Image = Image.FromFile(rutaDirectorio + "\\user.png");
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

        private void ptbUser_Click(object sender, EventArgs e)
        {
            try
            {
                rutaDirectorio = Path.Combine(Application.StartupPath + "\\Imagenes");
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Archivo JPG|*.jpg";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    ptbUser.Image = Image.FromFile(file.FileName);
                }
            }
            catch {}
        }
    }
}
