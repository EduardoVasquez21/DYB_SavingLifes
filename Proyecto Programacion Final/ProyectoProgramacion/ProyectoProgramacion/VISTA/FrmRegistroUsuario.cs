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
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();
            Carga();
            Clear();
        }
        void Carga()
        {
            dtgRegistroUsuario.Rows.Clear();
            ClsRegistroUser clsRegistro = new ClsRegistroUser();
            List<Tbl_UserList1> Lista = clsRegistro.cargarRegistros();


            foreach (var iteracion in Lista)
            {

                    dtgRegistroUsuario.Rows.Add(iteracion.Id, iteracion.NombreDonante, iteracion.Departamento, iteracion.Direccion, iteracion.Telefono, iteracion.DUI, iteracion.Edad, iteracion.Sexo, iteracion.GrupoSanguineo, iteracion.Correo);
                }
            }



        void Clear()
        {
            txtNombreDonante.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtDui.Clear();
            txtCorreo.Clear();

        }

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {
            Clear();

        }



        private void btnSalirUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgRegistroUsuario.CurrentRow.Cells[0].Value.ToString();
            String NombreDonante = dtgRegistroUsuario.CurrentRow.Cells[1].Value.ToString();
            String Direccion = dtgRegistroUsuario.CurrentRow.Cells[3].Value.ToString();
            String Telefono = dtgRegistroUsuario.CurrentRow.Cells[4].Value.ToString();
            String Edad = dtgRegistroUsuario.CurrentRow.Cells[6].Value.ToString();
            String GrupoSanguineo = dtgRegistroUsuario.CurrentRow.Cells[8].Value.ToString();
            String Departamento = dtgRegistroUsuario.CurrentRow.Cells[2].Value.ToString();
            String DUI = dtgRegistroUsuario.CurrentRow.Cells[5].Value.ToString();
            String Sexo = dtgRegistroUsuario.CurrentRow.Cells[7].Value.ToString();
            String Correo = dtgRegistroUsuario.CurrentRow.Cells[9].Value.ToString();
          //  String Estatus = dtgRegistroUsuario.CurrentRow.Cells[9].Value.ToString();


            txtId.Text = Id;
            txtNombreDonante.Text = NombreDonante;
            cmbDepto.Text = Departamento;
            txtDireccion.Text = Direccion;
            txtTelefono.Text = Telefono;
            txtDui.Text = DUI;
            CmbEdad.Text = Edad;
            cmbSexo.Text = Sexo;
            CmbGrupoSanguineo.Text = GrupoSanguineo;
            txtCorreo.Text = Correo;
            
        }

        private void btnAceptarUsuario_Click(object sender, EventArgs e)
        {
            ClsRegistroUser clsRegistro = new ClsRegistroUser();
            Tbl_UserList1 tbl = new Tbl_UserList1();
            tbl.NombreDonante = txtNombreDonante.Text;
            tbl.Direccion = txtDireccion.Text;
            tbl.DUI = Convert.ToInt32(txtDui.Text);
            tbl.Edad = Convert.ToInt32(CmbEdad.Text);
            tbl.Telefono = Convert.ToInt32(txtTelefono.Text);
            tbl.Departamento = cmbDepto.Text;
            tbl.Sexo = cmbSexo.Text;
            tbl.FechaDonacion = cmbFecha.Text;
            tbl.GrupoSanguineo = CmbGrupoSanguineo.Text;
            tbl.Correo = txtCorreo.Text;
            tbl.estatus = "Disponible";
            
            
            clsRegistro.SaveRegistro(tbl);

            cmbDepto.SelectedIndex = 0;
            CmbEdad.SelectedIndex = 0;
            cmbSexo.SelectedIndex = 0;
            CmbGrupoSanguineo.SelectedIndex = 0;
            cmbFecha.SelectedIndex = 0;

            Carga();
            Clear();
            dtgRegistroUsuario.Refresh();
            dtgRegistroUsuario.ClearSelection();
            int lastrow = dtgRegistroUsuario.Rows.Count - 1;
            dtgRegistroUsuario.FirstDisplayedScrollingRowIndex = lastrow;
            dtgRegistroUsuario.Rows[lastrow].Selected = true;


        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            try
            {
                using (DATOSPROYECTOEntities1 db = new DATOSPROYECTOEntities1())
                {
                    Tbl_UserList1 usser = new Tbl_UserList1();
                    int update = (Convert.ToInt32(txtId.Text));
                    usser = db.Tbl_UserList1.Find(update);
                    usser.NombreDonante = txtNombreDonante.Text;
                    usser.Direccion = txtDireccion.Text;
                    usser.DUI = Convert.ToInt32(txtDui.Text);
                    usser.Edad = Convert.ToInt32(CmbEdad.Text);
                    usser.Telefono = Convert.ToInt32(txtTelefono.Text);
                    usser.Departamento = cmbDepto.Text;
                    usser.Sexo = cmbSexo.Text;
                    usser.FechaDonacion = cmbFecha.Text;
                    usser.GrupoSanguineo = CmbGrupoSanguineo.Text;
                    usser.Correo = txtCorreo.Text;

                    db.SaveChanges();

                    cmbDepto.SelectedIndex = 0;
                    CmbEdad.SelectedIndex = 0;
                    cmbSexo.SelectedIndex = 0;
                    CmbGrupoSanguineo.SelectedIndex = 0;
                    cmbFecha.SelectedIndex = 0;

                    Carga();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtNombreDonante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtDui.Focus();
            }
        }
    }
}
