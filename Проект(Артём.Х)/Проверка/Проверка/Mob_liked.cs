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
                MobUC mob1 = new MobUC(mob);
                mob1.Location = new Point(x, y);
                Controls.Add(mob1);

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
