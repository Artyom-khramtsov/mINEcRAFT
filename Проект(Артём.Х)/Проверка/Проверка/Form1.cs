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
            Mobs.FillWords();
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
            new Mobs("Приручаемые_мобы").ShowDialog();
        }

        private void buildingClick(object sender, EventArgs e)
        {
            new Mobs("Создаваемые_мобы").ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Mobs("Нейтральные_мобы").ShowDialog();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Mob_liked form = new Mob_liked();
            form.Show();
        }

        private void MineWiki_Load(object sender, EventArgs e)
        {

        }

        private void redstone_Click(object sender, EventArgs e)
        {
            new Mobs("Боссы").ShowDialog();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            RenameAll(Mobs.Ruswords);
        }

        public void button3_Click(object sender, EventArgs e)
        {
            RenameAll(Mobs.Engwords);
        }

        void RenameAll(Dictionary<string, string> Words)
        {
            label1.Text = Words["Враждебные мобы"];
            label2.Text = Words["Дружелюбные мобы"];
            label3.Text = Words["Приручаемые мобы"];
            label5.Text = Words["Создаваемые мобы"];
            label6.Text = Words["Нейтральные мобы"];
            label7.Text = Words["Боссы"];
            button1.Text = Words["Понравившиеся"];
        }
    }
}
