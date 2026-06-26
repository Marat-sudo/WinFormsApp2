using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private string emailText = "";

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string secondnName = textBoxSecondName.Text;
            string rez = textBoxRez.Text;
            string date = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            string text = richTextBox1.Text;

            emailText = name + "\n" +
                secondnName + "\n" +
                rez + "\n" +
                date + "\n" +
                text + "\n";

            labelTest.Text = emailText;


            emailText =
        "<h2>Отчет: </h2>" +
        "<p><b>Имя:</b> " + name + "</p>" +
        "<p><b>Фамилия:</b> " + secondnName + "</p>" +
        "<p><b>Название отчета:</b> " + rez + "</p>" +
        "<p><b>дата:</b><br/>" + date + "</p>" +
        "<p><b>отчёт:</b><br/>" + text + "</p>";

        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("braticmaratic@mail.ru", "Отправитель");
            MailAddress to = new MailAddress("k_d_i01@mail.ru", "Получатель");
            using (MailMessage mail_message = new MailMessage(from, to))
            using (SmtpClient smtp_cl = new SmtpClient())
            {
                smtp_cl.UseDefaultCredentials = false;
                smtp_cl.Credentials = new NetworkCredential("braticmaratic@mail.ru", "DsY2IFd7mgydRPVDsIMn");
                mail_message.Subject = "this marat";
                mail_message.Body = emailText;

                mail_message.IsBodyHtml = true;
                smtp_cl.Host = " smtp.mail.ru ";
                smtp_cl.Port = 2525;
                smtp_cl.EnableSsl = true;
                smtp_cl.DeliveryMethod = SmtpDeliveryMethod.Network;
                try
                {
                    smtp_cl.Send(mail_message);
                    MessageBox.Show("Сообщение успешно отправлено");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка отправки: " + ex.Message);
                }
            }
        }
    }
}
