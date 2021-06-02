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
    public partial class FrmRequisitos : Form
    {
        public FrmRequisitos()
        {
            InitializeComponent();
        }

        private void btnSalirRequisitos_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void FrmRequisitos_Load(object sender, EventArgs e)
        {

        }
    }
}
