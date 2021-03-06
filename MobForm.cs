using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проверка
{
   

    public partial class MobForm : Form
    {
        string Mob_Like;

        public MobForm(string MobType)
        {
            InitializeComponent();

            Mob_Like = MobType;
            Text = MobType;
            label2.Text = MobType;

            string category = "Враждебные мобы";
            for (int i = 0; i < Mobs.mob_list.Count; i++)
            {
                if (MobType == Mobs.mob_list[i].name)
                {
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

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Бегаем по всем мобам
            foreach (Searchmobs mob in Mobs.mob_list)
            { 
                //Нашли нужного
                if(mob.name == Mob_Like)
                {
                    //Добавляем в список лайкнутых
                    Mobs.Mob_like.Add(mob);

                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Бегаем по всем мобам
            foreach (Searchmobs mob in Mobs.Mob_dislike)
            {
                //Нашли нужного
                if (mob.name == Mob_Like)
                {
                    //Добавляем в список лайкнутых
                    Mobs.Mob_dislike.Add(mob);

                }
            }
        }
    }
}
