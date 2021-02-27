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
        }

        private void picture1_Click(object sender, EventArgs e)
        {
            Mobs form = new Mobs();
            form.Show();
        }

        private void картинка2_Click(object sender, EventArgs e)
        {
            Animals form = new Animals();
            form.Show();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Redstone form = new Redstone();
            form.Show();
        }

    }
}
