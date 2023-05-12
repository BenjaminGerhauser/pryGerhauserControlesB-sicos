using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGerhauserControlesBásicos
{
    public partial class frmPrincipal : Form
    {
        Random random = new Random();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            lblEjeX.Text = e.X.ToString();
            lblEjeY.Text = e.Y.ToString();
        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = true;
        }

        private void lblBienvenida_MouseMove(object sender, MouseEventArgs e)
        {
            lblBienvenida.Location = new Point(random.Next(10, 850), random.Next(10, 850));
        }

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            frmTexto frmtexto = new frmTexto(); 
            frmtexto.ShowDialog();
        }
    }
}
