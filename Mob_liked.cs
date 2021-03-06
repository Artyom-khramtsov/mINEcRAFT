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
                Label lb1 = new Label();
                lb1.Location = new Point(x, y);
                lb1.Text = mob.name;
                lb1.Size = new Size(300, 300);
                Controls.Add(lb1);
                 
            }


        }

       
    }
}
