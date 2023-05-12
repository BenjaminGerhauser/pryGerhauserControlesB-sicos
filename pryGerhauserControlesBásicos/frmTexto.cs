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
    public partial class frmTexto : Form
    {
        public frmTexto()
        {
            InitializeComponent();
        }

        private void txtEscribir_TextChanged(object sender, EventArgs e)
        {
            lblCopia.Text = txtEscribir.Text;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (optAzul.Checked == true)
            {
                lblCopia.ForeColor = Color.Blue;
                txtEscribir.ForeColor = Color.Blue;  
            }
            if (optRojo.Checked == true)
            {
                lblCopia.ForeColor = Color.Red;
                txtEscribir.ForeColor = Color.Red;
            }
                
        }
    }
}
