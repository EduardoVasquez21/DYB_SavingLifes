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
    public partial class FrmCompatibilidadSanguinea : Form
    {
        public FrmCompatibilidadSanguinea()
        {
            InitializeComponent();
            using (DATOSPROYECTOEntities1 db = new DATOSPROYECTOEntities1())
            {
                var Lista = db.Tbl_UserList1.ToList();

                foreach (var iteracion in Lista)
                {

                    dtgCompatibilidad.Rows.Add(iteracion.Id, iteracion.NombreDonante,iteracion.GrupoSanguineo);
                }
            }
            Carga();
        }
        void Carga()
        {


        }

        private void btnSalirTipoSangre_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void dtgCompatibilidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmCompatibilidadSanguinea_Load(object sender, EventArgs e)
        {

        }
       
       
    }
}
