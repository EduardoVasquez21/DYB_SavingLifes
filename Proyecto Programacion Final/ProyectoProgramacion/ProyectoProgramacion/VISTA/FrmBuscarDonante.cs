using ProyectoProgramacion.DAO;
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
    public partial class FrmBuscarDonante : Form
    {
        public string Id { get; private set; }

        public FrmBuscarDonante()
        {
            InitializeComponent();
            using (DATOSPROYECTOEntities1 db = new DATOSPROYECTOEntities1())
            {
                var Lista = db.Tbl_UserList1.ToList();

                foreach (var iteracion in Lista)
                {

                    dtgBuscarDonante.Rows.Add(iteracion.Id, iteracion.NombreDonante, iteracion.Departamento, iteracion.Direccion, iteracion.Telefono, iteracion.DUI, iteracion.Edad, iteracion.Sexo, iteracion.GrupoSanguineo,iteracion.FechaDonacion);
                }
            }
            Carga();
        }
        void Carga()
        {
            dtgBuscarDonante.Rows.Clear();
            ClsBuscarDonante clsBuscar = new ClsBuscarDonante();
            List<Tbl_UserList1> Lista = clsBuscar.cargarDonantes();


            foreach (var iteracion in Lista)
            {

                    dtgBuscarDonante.Rows.Add(iteracion.Id, iteracion.NombreDonante, iteracion.Departamento, iteracion.Direccion, iteracion.Telefono, iteracion.DUI, iteracion.Edad, iteracion.Sexo, iteracion.GrupoSanguineo,iteracion.FechaDonacion);
                }
            }
        
        void Clear()
        {
            txtId.Clear();
            txtDonanteaBuscar.Clear();
        }
        private void btnSalirBDonante_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void btnEliminarBDonante_Click(object sender, EventArgs e)
        {
           
            try
            {
                ClsBuscarDonante clsBD = new ClsBuscarDonante();
                clsBD.deleteUser(Convert.ToInt32(txtId.Text));
                Carga();
                Clear();
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dtgBuscarDonante.Refresh();
            dtgBuscarDonante.ClearSelection();
            int lastrow = dtgBuscarDonante.Rows.Count - 1;
            dtgBuscarDonante.FirstDisplayedScrollingRowIndex = lastrow;
            dtgBuscarDonante.Rows[lastrow].Selected = true;

        }

        private void dtgBuscarDonante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgBuscarDonante.CurrentRow.Cells[0].Value.ToString();
            

            txtId.Text = Id;

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
          
            
            txtId.Text = Id;
        }

        private void FrmBuscarDonante_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            dtgBuscarDonante.Rows.Clear();
            using (DATOSPROYECTOEntities1 bd = new DATOSPROYECTOEntities1())
            {

                var consulta = (from user in bd.Tbl_UserList1

                                where user.NombreDonante.Contains(txtDonanteaBuscar.Text)
                                select new
                                {
                                    user.Id,
                                    user.NombreDonante,
                                    user.Departamento,
                                    user.Direccion,
                                    user.Telefono,
                                    user.DUI,
                                    user.Edad,
                                    user.Sexo,
                                    user.GrupoSanguineo,
                                    user.FechaDonacion,
                                    user.estatus

                                }).ToList();

                foreach (var iteracion in consulta)
                {

                    dtgBuscarDonante.Rows.Add(iteracion.Id, iteracion.NombreDonante, iteracion.Departamento, iteracion.Direccion, iteracion.Telefono, iteracion.DUI, iteracion.Edad, iteracion.Sexo, iteracion.GrupoSanguineo, iteracion.FechaDonacion, iteracion.estatus);


                }

            }
        }

        private void txtId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDonanteaBuscar_TextChanged(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (DATOSPROYECTOEntities1 db = new DATOSPROYECTOEntities1())
                {
                    Tbl_UserList1 uuser = new Tbl_UserList1();
                    int update = (Convert.ToInt32(txtId.Text));
                    uuser = db.Tbl_UserList1.Find(update);
                    uuser.estatus = "Donacion exitosa";

                    db.SaveChanges();
                    Carga();
                    Clear();
                }
                load();
                this.Hide();
                FrmEnvioMensajeCorreo frm = new FrmEnvioMensajeCorreo();
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
