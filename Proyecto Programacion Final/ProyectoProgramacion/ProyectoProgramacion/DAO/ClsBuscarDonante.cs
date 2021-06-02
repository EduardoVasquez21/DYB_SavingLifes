using ProyectoProgramacion.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion.DAO
{
    class ClsBuscarDonante
    {
        public List<Tbl_UserList1> cargarDonantes()
        {
            List<Tbl_UserList1> Lista;


            using (DATOSPROYECTOEntities1 db = new DATOSPROYECTOEntities1())
            {
                Lista = db.Tbl_UserList1.ToList();


            }
            return Lista;
        }

        public void deleteUser(int Id)
        {

            try
            {
                using (DATOSPROYECTOEntities1 DP = new DATOSPROYECTOEntities1())
                {

                    int Eliminar = Convert.ToInt32(Id);
                    Tbl_UserList1 user = DP.Tbl_UserList1.Where(x => x.Id == Eliminar).Select(x => x).FirstOrDefault();
                    DP.Tbl_UserList1.Remove(user);
                    DP.SaveChanges();
                    MessageBox.Show("Dato Eliminado");

                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
    }
}
