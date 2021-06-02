using ProyectoProgramacion.MODEL;
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
    public partial class FrmAgendarCitas2 : Form
    {
        public FrmAgendarCitas2()
        {
            InitializeComponent();
            using (DATOSPROYECTOEntities1 db = new DATOSPROYECTOEntities1())
            {
                
            }
            Carga();
        }
        void Carga()
        {
            dtgAgendarCita.Rows.Clear();
            using (DATOSPROYECTOEntities1 db = new DATOSPROYECTOEntities1())
            {
                var Lista = db.Tbl_UserList1.ToList();

                foreach (var iteracion in Lista)
                {
                    dtgAgendarCita.Rows.Add(iteracion.Id, iteracion.NombreDonante, iteracion.Edad, iteracion.GrupoSanguineo, iteracion.FechaDonacion);

                }
            }

        }
        void Clear()
        {
            txtId.Clear();
        }
        private void btnSalirAgendarCita2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void dtgAgendarCita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            txtFecha.Text = monthCalendar1.SelectionStart.Day.ToString() + "/" +
                monthCalendar1.SelectionStart.Month.ToString() + "/" +
                monthCalendar1.SelectionStart.Year.ToString();
            try
            {
                using (DATOSPROYECTOEntities1 db = new DATOSPROYECTOEntities1())
                {
                    Tbl_UserList1 user = new Tbl_UserList1();
                    int update = (Convert.ToInt32(txtId.Text));
                    user = db.Tbl_UserList1.Find(update);
                    user.FechaDonacion = txtFecha.Text;
                    db.SaveChanges();
                    Carga();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAgendarCitas2_Load(object sender, EventArgs e)
        {

        }

        private void lblNomUs_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtgAgendarCita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgAgendarCita.CurrentRow.Cells[0].Value.ToString();
            String FechaDonacion = dtgAgendarCita.CurrentRow.Cells[4].Value.ToString();

            txtId.Text = Id;
            txtFecha.Text = FechaDonacion;
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
