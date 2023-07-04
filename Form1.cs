using System.Net;
using System.Net.Http;
using System.Net.Mail;

namespace EmailSender
{
    public partial class Form1 : Form
    {
        string correoEmisor = "correodummyintec@gmail.com";

        public Form1()
        {
            InitializeComponent();
        }

        //Inicio metodo btnCancelar_click
        //Vacía todos los campos cuando el usuario le da a cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbEmailReceptor.Clear();
            tbAsunto.Clear();
            tbCuerpoMsg.Clear();

            MessageBox.Show("Correo cancelado exitosamente", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Fin metodo btnCancelar_click


        //Inicio metodo btnEnviar_click
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (tbEmailReceptor.Text == "")
            {
                MessageBox.Show("Debe de ingresar un correo receptor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                EnviarCorreo(tbEmailReceptor.Text, tbAsunto.Text, tbCuerpoMsg.Text);
            }
        }
        //Fin metodo btnEnviar_click

        //Inicio metodo EnviarCorreo
        private void EnviarCorreo(string receptor, string asunto, string cuerpo)
        {
            MailMessage correo = PrepararCorreo(receptor, asunto, cuerpo);

            SmtpClient servidor = RealizarConexionSMTP();

            try
            {
                servidor.Send(correo);
                MessageBox.Show("Correo enviado exitosamente.", "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Fin metodo EnviarCorreo

        //Inicio metodo PrepararCorreo
        private MailMessage PrepararCorreo(string receptor, string asunto, string cuerpo)
        {
            MailMessage mailMessage = new MailMessage();

            mailMessage.From = new MailAddress(correoEmisor);
            mailMessage.To.Add(tbEmailReceptor.Text);
            mailMessage.Subject = tbAsunto.Text;
            mailMessage.Body = tbCuerpoMsg.Text;

            return mailMessage;
        }
        //Fin metodo PrepararCorreo

        //Inicio metodo RealizarConexionSMTP
        private SmtpClient RealizarConexionSMTP()
        {
            //Server address: smtp.gmail.com
            //SSL: 587

            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(correoEmisor, "tkllfsnkoaewxpvh");
            smtpClient.EnableSsl = true;

            return smtpClient;
        }
        //Fin metodo RealizarConexionSMTP
    }
}