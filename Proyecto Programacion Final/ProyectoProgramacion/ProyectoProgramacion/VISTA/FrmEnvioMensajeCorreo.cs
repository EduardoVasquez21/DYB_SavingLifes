using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Net.Mime;
using ProyectoProgramacion.MODEL;

namespace ProyectoProgramacion.VISTA
{
    public partial class FrmEnvioMensajeCorreo : Form
    {
        private string To;
        private string Subject;
        private string Body;

        private MailMessage mail;
        private Attachment Data;

        public FrmEnvioMensajeCorreo()
        {
            InitializeComponent();
            using (DATOSPROYECTOEntities1 db = new DATOSPROYECTOEntities1())
            {
                var Lista = db.Tbl_UserList1.ToList();

                foreach (var iteracion in Lista)
                {

                    dtgEnviarCorreo.Rows.Add( iteracion.NombreDonante, iteracion.Correo);
                }
            }
            Carga();
        }

        void Carga()
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!(txtPara.Text.Trim() == ""))
            {
                To = txtPara.Text;
                Subject = txtAsunto.Text;
                Body = txtMensaje.Text;

                mail = new MailMessage();
                mail.To.Add(new MailAddress(this.To));
                mail.From = new MailAddress("proyectoprogra2021@gmail.com");
                mail.Subject = Subject;
                mail.Body = Body;
                mail.IsBodyHtml = false;

                if (!(txtAjuntarArchivo.Text.Trim() == ""))
                {
                    Data = new Attachment(txtAjuntarArchivo.Text, MediaTypeNames.Application.Octet);
                    mail.Attachments.Add(Data);

                }
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                using (client)
                {
                    client.Credentials = new System.Net.NetworkCredential("proyectoprogra2021@gmail.com", "Proyecto2021");
                    client.EnableSsl = true;
                    client.Send(mail);

                }
                MessageBox.Show("---Su mensaje fue enviado--- ");

            }
            this.Close();
            FrmBuscarDonante frm = new FrmBuscarDonante();
            frm.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtAjuntarArchivo.Text = openFileDialog1.FileName;
        }

        private void FrmEnvioMensajeCorreo_Load(object sender, EventArgs e)
        {

        }

        private void dtgEnviarCorreo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Nombre = dtgEnviarCorreo.CurrentRow.Cells[0].Value.ToString();
            String Correo = dtgEnviarCorreo.CurrentRow.Cells[1].Value.ToString();


            //txtNombreDonante.Text = Nombre;
            txtPara.Text = Correo;
            
        }
    }
}
