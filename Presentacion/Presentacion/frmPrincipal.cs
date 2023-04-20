using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Negocio;
namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCandidatos objCandidatos = new frmCandidatos();
            objCandidatos.Show();
        }

        private void ptbInscripciones_Click(object sender, EventArgs e)
        {
            frmInscripciones objInscripciones = new frmInscripciones();
            objInscripciones.ShowDialog();
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
