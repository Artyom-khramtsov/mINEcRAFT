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
                 Environment.NewLine + textBox1.Text;


            /*
            File.WriteAllText("Заказ.csv", "Название...")
            foreach (Game game1 in Form1.korzina)
            {
                File.AppendAllText("Заказ.csv",
                    Environment.NewLine +
            game1.name + "," + game.genre + "," + game1.price);
            }

            m.Attachments.Add(new Attachment(Заказ.сsv));

            */

            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("khramtsov.art@gmail.com", "!Artem76");
            smtp.EnableSsl = true;
            smtp.Send(m);

            MessageBox.Show("Ушло");
        }
    }
}
