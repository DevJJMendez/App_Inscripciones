﻿using Negocio;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
 */
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
        private void fntNumbersOnly()
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
            MemoryStream ms = new MemoryStream();
            ptbUser.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            ptbUser.Image = null;
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

        private void tbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            void fntNumbersOnly()
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
            fntNumbersOnly();
        }

        private void tbxContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            fntNumbersOnly();
        }
    }
}
