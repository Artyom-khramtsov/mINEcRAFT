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
    public partial class MineWiki : Form
    {
        public MineWiki()
        {
            InitializeComponent();
            Mobs.FillMobsList();
        }

        private void picture1_Click(object sender, EventArgs e)
        {
            Mobs form = new Mobs();
            form.ShowDialog();
        }

        private void картинка2_Click(object sender, EventArgs e)
        {
            Animals form = new Animals();
            form.ShowDialog();
        }

        private void blocksClick(object sender, EventArgs e)
        {
            Blocks form = new Blocks();
            form.Show();
        }

        private void buildingClick(object sender, EventArgs e)
        {
            Bildings form = new Bildings();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mexanism form = new Mexanism();
            form.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Mob_liked form = new Mob_liked();
            form.Show();
        }

        private void MineWiki_Load(object sender, EventArgs e)
        {

        }
    }
}
