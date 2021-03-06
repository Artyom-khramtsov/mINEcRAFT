using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проверка
{
    public partial class Animals : Form
    {
     
        public Animals()
        {
            InitializeComponent();

            Mobs.mob_list.Add(new Searchmobs("Летучая мышь", "Верхний мир", "Дружелюбные_мобы"));
 
      
            int x = 10;
            int y = 80;
            for (int i = 0; i < Mobs.mob_list.Count; i++)
            {

                Mobs.mob_list[i].picture.BackColor = Color.Transparent;
                Mobs.mob_list[i].picture.Tag = Mobs.mob_list[i].name;
                Mobs.mob_list[i].picture.Location = new Point(x, y);
                Mobs.mob_list[i].picture.Size = new Size(300, 300);
                Mobs.mob_list[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                Mobs.mob_list[i].picture.Click += new EventHandler(OpenMob);
                try
                {
                    Mobs.mob_list[i].picture.Load("../../Дружелюбные_мобы/" + Mobs.mob_list[i].name + ".gif");
                }
                catch (Exception)
                {
                    Mobs.mob_list[i].picture.Load("../../Дружелюбные_мобы/" + Mobs.mob_list[i].name + ".png");
                }
                
                Controls.Add(Mobs.mob_list[i].picture);


                Mobs.mob_list[i].label.AutoSize = true;
                Mobs.mob_list[i].label.BackColor = Color.Transparent;
                Mobs.mob_list[i].label.ForeColor = Color.Red;
                Mobs.mob_list[i].label.Font = new Font("Microsoft Sans Serif", 15F);
                Mobs.mob_list[i].label.Location = new Point(x + 100, y + 300);
                Mobs.mob_list[i].label.Size = new Size(300, 29);
                Mobs.mob_list[i].label.TabIndex = 31;
                Mobs.mob_list[i].label.Text = Mobs.mob_list[i].name;
                Controls.Add(Mobs.mob_list[i].label);


                x = x + 300;
                if (x + 300 > Width)
                {
                    x = 10;
                    y = y + 350;
                }
            }

        }

        private void OpenMob(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            MobForm form = new MobForm(picture.Tag.ToString());
            form.Show();

        }

        private void Animals_Load(object sender, EventArgs e)
        {

        }
    }
}
