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
    public partial class FrmSeleccion : Form
    {
        public FrmSeleccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSeleccionDonanteHabitual frm = new FrmSeleccionDonanteHabitual();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSeleccionDonanteNuevo frm = new FrmSeleccionDonanteNuevo();
            frm.Show();
        }

        private void FrmSeleccion_Load(object sender, EventArgs e)
        {

        }
    }
}
