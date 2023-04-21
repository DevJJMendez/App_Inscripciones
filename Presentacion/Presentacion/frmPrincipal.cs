using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
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
        private void pbxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbInscripciones_Click(object sender, EventArgs e)
        {
            frmInscrip objInscripciones = new frmInscrip();
            objInscripciones.ShowDialog();
        }
    }
}
