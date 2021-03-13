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
    public partial class Mob_liked : Form
    {
        public Mob_liked()
        {
            InitializeComponent();

            int x = 10;
            int y = 80;
            foreach (Searchmobs mob in Mobs.Mob_like)
            {
                //mob - конкретный персонаж, которого рисуем на этой форме
                Label lb1 = new Label();
                lb1.AutoSize = true;
                lb1.BackColor = Color.Transparent;
                lb1.ForeColor = Color.Red;
                lb1.Font = new Font("Microsoft Sans Serif", 15F);
                lb1.Location = new Point(x + 100, y + 300);
                lb1.Size = new Size(300, 29);
                lb1.TabIndex = 31;
                lb1.Text = mob.name;
                Controls.Add(lb1);

                PictureBox Pb1 = new PictureBox();
                Pb1.Click += new EventHandler(Mobs.OpenMob);
                Pb1.BackColor = Color.Transparent;
                Pb1.Tag = mob.name;
                Pb1.Location = new Point(x, y);
                Pb1.Size = new Size(300, 300);
                Pb1.SizeMode = PictureBoxSizeMode.Zoom;
                try
                {
                    Pb1.Load("../../" + mob.category + "/" + mob.name + ".gif");
                }
                catch (Exception)
                {
                    Pb1.Load("../../" + mob.category + "/" + mob.name + ".png");
                }
                Controls.Add(Pb1);

                x = x + 300;
                if (x + 300 > Width)
                {
                    x = 10;
                    y = y + 350;
                }
            }
        }

        private void Mob_liked_Load(object sender, EventArgs e)
        {

        }
    }
}
