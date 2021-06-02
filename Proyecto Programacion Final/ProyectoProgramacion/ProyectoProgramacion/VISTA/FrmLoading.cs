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
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            
        }

        private void Loading_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Width != panel1.Width)
            {
                ProgressBar.Width = ProgressBar.Width + 2;
            }
            else
            {
                FrmMenu frm = new FrmMenu();
                frm.Show();
                this.Close();

            }


        }
    }
}
