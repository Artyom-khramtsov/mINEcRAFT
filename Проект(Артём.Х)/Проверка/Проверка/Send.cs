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

namespace Проверка
{
    public partial class Send : Form
    {
        public Send()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("khramtsov.art@gmail.com", "Гость");
            // кому отправляем
            MailAddress to = new MailAddress("khramtsov.art@gmail.com");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = comboBox1.Text;
            // текст письма
            m.Body = textBox2.Text +
                 Environment.NewLine + "Телефон(либо почта): " + textBox1.Text;
            if (Address1 != "")
            {
                Attachment attachment = new Attachment(Address1);
                attachment.Name = "1.jpg";
                m.Attachments.Add(attachment);
            }

            if (Address2 != "")
            {
                Attachment attachment = new Attachment(Address2);
                attachment.Name = "2.jpg";
                m.Attachments.Add(attachment);
            }
            /*
            File.WriteAllText("Ucheb.csv","Автор,Предмет,Рейтинг");
            foreach (Uchebniki uch in Form1.zakladka)
            {
                File.AppendAllText("Ucheb.csv",
                    Environment.NewLine +
                    uch.Author + "," + uch.discipline+"," + uch.Rating.ToString());

             */
        

            

            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("khramtsov.art@gmail.com", "!Artem76");
            smtp.EnableSsl = true;
            smtp.Send(m);

            MessageBox.Show("Ушло");
        }

        string Address1 = "";
        string Address2 = "";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Address1 = openFileDialog1.FileName;
                pictureBox1.Load(Address1);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Address2 = openFileDialog1.FileName;
                pictureBox2.Load(Address2);
            }
        }
    }
}
