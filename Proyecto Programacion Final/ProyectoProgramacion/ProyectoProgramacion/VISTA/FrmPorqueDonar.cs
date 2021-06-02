using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion.VISTA
{
    public partial class FrmPorqueDonar : Form
    {
        public FrmPorqueDonar()
        {
            InitializeComponent();

        }

        private void btnSalirPDonar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPorqueDonar_Load(object sender, EventArgs e)
        {

        }
    }
}
