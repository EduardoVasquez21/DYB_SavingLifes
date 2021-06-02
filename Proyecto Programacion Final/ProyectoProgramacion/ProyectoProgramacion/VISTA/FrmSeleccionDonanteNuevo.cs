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
    public partial class FrmSeleccionDonanteNuevo : Form
    {
        public FrmSeleccionDonanteNuevo()
        {
            InitializeComponent();
        }

        private void FrmSeleccionDonanteNuevo_Load(object sender, EventArgs e)
        {

        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bitmap = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bitmap);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
    }
}
