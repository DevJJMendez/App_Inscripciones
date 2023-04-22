using Negocio;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class frmCandidatos : Form
    {
        string rutaDirectorio;
        public frmCandidatos()
        {
            InitializeComponent();
//---------Se inicia la función para que cargue los comboBox al iniciar-----------------------------------------------------------------------------------------------------------
            fntCargarComboBox();
//----------Abrir ruta para ingresar foto-----------------------------------------------------------------------------------------------------------------------------------------
            rutaDirectorio = Path.Combine(Application.StartupPath + "\\Imagenes");
            fntClean();
        }

/*------Creación de la función para cargar los comboBox---------------------------------------------------------------------------------------------------------------------------
 -------Instacia de la clase y creación del objeto para obtener la función--------------------------------------------------------------------------------------------------------
*/
        private void fntCargarComboBox()
        {
            clsNivelEstudio objdt = new clsNivelEstudio();
            objdt.fntCargarTipoEstudio();
            cbxNestudio.ValueMember = "PKCodigo";
            cbxNestudio.DisplayMember = "Nombre";
            cbxNestudio.DataSource = objdt.getDt();
        }
/*------Creación de la función para cargar los comboBox---------------------------------------------------------------------------------------------------------------------------
 -------Instacia de la clase y creación del objeto para obtener la función--------------------------------------------------------------------------------------------------------
*/
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

 //-----Función guardar-----------------------------------------------------------------------------------------------------------------------------------------------------------
        private void pbxGuardar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            ptbUser.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            ptbUser.Image = null;
//----------Creación del objeto para obtener el metodo getMsn---------------------------------------------------------------------------------------------------------------------
            clsAgregarCandidatos objAgregarCandidato = new clsAgregarCandidatos(tbxID.Text,
                tbxPnombre.Text,
                    tbxSnombre.Text,
                        tbxPapellido.Text,
                            tbxSapellido.Text,
                                tbxContacto.Text,
                                    tbxDireccion.Text,
                                        tbxCorreo.Text,
                                            tbxEdad.Text,
                                                cbxNestudio.SelectedIndex+1,
                                                    tbxAcudientes.Text,aByte);
                                                            MessageBox.Show($"{objAgregarCandidato.getMsn()}");
                                                                      fntClean();
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
        private void tbxCorreo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!IsValidEmail(tbxCorreo.Text, out errorMsg))
            {
                // Cancela la validación y establece el foco en el control TextBox
                e.Cancel = true;
                tbxCorreo.Select(0, tbxCorreo.Text.Length);

                // Muestra un mensaje de error al usuario
                MessageBox.Show(errorMsg);
            }
        }
        public static bool IsValidEmail(string email, out string errorMsg)
        {
            // Verifica si el correo electrónico es válido usando una expresión regular
            bool isValid = true;
            errorMsg = "";

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                isValid = addr.Address == email;
            }
            catch
            {
                isValid = false;
            }

            if (!isValid)
            {
                errorMsg = "El correo electrónico ingresado no es válido";
            }

            return isValid;
        }

        private void fntConsultar(string Id)
        {
            clsConsultarCandidato objConsultar = new clsConsultarCandidato();
            objConsultar.fntConsultar(Id);
            ptbUser.Image = objConsultar.getBmp();
            tbxPnombre.Text = objConsultar.getPNombre();
            tbxSnombre.Text = objConsultar.getSNombre();
            tbxPapellido.Text = objConsultar.getPApellido();
            tbxSapellido.Text = objConsultar.getSApellido();
            tbxContacto.Text = objConsultar.getContacto();
            tbxDireccion.Text = objConsultar.getDireccion();
            tbxCorreo.Text = objConsultar.getCorreo();
            tbxEdad.Text = objConsultar.getEdad();
            cbxNestudio.Text = Convert.ToString(objConsultar.getEstudio());
            tbxAcudientes.Text = objConsultar.getAcudientes();
        }
        private void ptbConsultar_Click(object sender, EventArgs e)
        {
            fntConsultar(tbxID.Text);
        }

        private void ptbHome_Click(object sender, EventArgs e)
        {
            frmPrincipal objPrincipal = new frmPrincipal();
            objPrincipal.Show();
        }
        private void ptbUpdate_Click(object sender, EventArgs e)
        {
            clsUpdateCandidatos objUpdateC = new clsUpdateCandidatos(tbxID.Text,tbxPnombre.Text,tbxSnombre.Text,tbxPapellido.Text,tbxSapellido.Text,tbxContacto.Text,tbxDireccion.Text,tbxCorreo.Text,tbxEdad.Text,cbxNestudio.SelectedIndex + 1, tbxAcudientes.Text);
            MessageBox.Show($"{objUpdateC.GetMsj()}");
            fntClean();
        }
    }
}
