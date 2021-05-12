using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проверка
{
   

    public partial class MobForm : Form
    {
        Searchmobs Mob_Like;
        Searchmobs Mob_dislike;
        public MobForm(string MobType)
        {
            InitializeComponent();

            Text = MobType;
            label2.Text = MobType;

            string category = "Враждебные мобы";
            for (int i = 0; i < Mobs.mob_list.Count; i++)
            {
                if (MobType == Mobs.mob_list[i].name)
                {
                    Mob_Like = Mobs.mob_list[i];
                    Mob_dislike = Mobs.mob_list[i];

                    category = Mobs.mob_list[i].category;
                }
            }
            try
            {
                label3.Text = File.ReadAllText("../../" + category + "/" + MobType + ".txt");
                label1.Text = File.ReadAllText("../../" + category + "/" + MobType + "2.txt");
            }
            catch (Exception) { }

            try
            {
                pictureBox1.Load("../../" + category + "/" + MobType + ".gif");
            }
            catch (Exception)
            {
                pictureBox1.Load("../../" + category + "/" + MobType + ".png");
            }

            
            if (Mobs.Mob_like.Contains(Mob_Like))
            {
                label4.Text = "1";
            }
            else
            {
                label4.Text = "0";
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {            
            //Нашли нужного
            if (!Mobs.Mob_like.Contains(Mob_Like))
            {
                //Добавляем в список лайкнутых
                Mobs.Mob_like.Add(Mob_Like);
                label4.Text = "1";
            }
            else
            {
                Mobs.Mob_like.Remove(Mob_Like);
                MessageBox.Show("Вы отменили лайк");
                label4.Text = "0";
            }
                
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (label5.Text == "0")
            {
                label5.Text = "1";
            }
            else
            {
                MessageBox.Show("Вы отменили дизлайк");
                label5.Text = "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
