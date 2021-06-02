using ProyectoProgramacion.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoProgramacion.DAO
{
    class ClsRegistroUser
    {


        public List<Tbl_UserList1> cargarRegistros()
        {
            List<Tbl_UserList1> tbl_Users;

            using (DATOSPROYECTOEntities1 dp = new DATOSPROYECTOEntities1())
            {
                tbl_Users = dp.Tbl_UserList1.ToList();
            }

            return tbl_Users;
        }


        public void SaveRegistro(Tbl_UserList1 tu)
        {
            try
            {
                using (DATOSPROYECTOEntities1 DE = new DATOSPROYECTOEntities1())
                {

                    Tbl_UserList1 tbl = new Tbl_UserList1();

                    tbl.NombreDonante = tu.NombreDonante;
                    tbl.Direccion = tu.Direccion;
                    tbl.DUI = tu.DUI;
                    tbl.Edad = tu.Edad;
                    tbl.Telefono = tu.Telefono;
                    tbl.Departamento = tu.Departamento;
                    tbl.Sexo = tu.Sexo;
                    tbl.FechaDonacion = tu.FechaDonacion;
                    tbl.GrupoSanguineo = tu.GrupoSanguineo;
                    DE.Tbl_UserList1.Add(tu);
                    DE.SaveChanges();
                    MessageBox.Show("Guardado");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
    }
}

