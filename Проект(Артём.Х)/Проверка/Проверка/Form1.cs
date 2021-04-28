using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
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
            new Mobs("Враждебные мобы").ShowDialog();
        }

        private void картинка2_Click(object sender, EventArgs e)
        {
            new Mobs("Дружелюбные мобы").ShowDialog();
        }

        private void blocksClick(object sender, EventArgs e)
        {
            new Mobs("Приручаемые мобы").ShowDialog();
        }

        private void buildingClick(object sender, EventArgs e)
        {
            new Mobs("Создаваемые мобы").ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Mobs("Нейтральные мобы").ShowDialog();
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
            Mobs.Language = "Русский";
        }

        public void button3_Click(object sender, EventArgs e)
        {
            RenameAll(Mobs.Engwords);
            Mobs.Language = "Английский";
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
            button7.Text = Words["О мобах"];
            button6.Text = Words["Край"];
            button4.Text = Words["Верхний мир"];
            button5.Text = Words["Нижний мир"];
        }


        private void button6_Click(object sender, EventArgs e)
        {
            new Info("Край").ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            new Info("Верхний мир").ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Info("Нижний мир").ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            new InfoMobs("О мобах").ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }
    }
}
