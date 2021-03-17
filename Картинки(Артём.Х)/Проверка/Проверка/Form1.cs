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
            new Mobs("Враждебные_мобы").ShowDialog();
        }

        private void картинка2_Click(object sender, EventArgs e)
        {
            new Mobs("Дружелюбные_мобы").ShowDialog();
        }

        private void blocksClick(object sender, EventArgs e)
        {
            new Mobs("Не знаю").ShowDialog();
        }

        private void buildingClick(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
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
