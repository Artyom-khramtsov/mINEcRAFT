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
        Searchmobs Mob_Like;
        

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
            //Нашли нужного
            if (!Mobs.mob_list.Contains(Mob_Like))
            {
                //Добавляем в список лайкнутых
                Mobs.Mob_like.Add(Mob_Like);
            }
            else
                MessageBox.Show("Он и так один из нас");           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
