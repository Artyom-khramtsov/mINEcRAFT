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
    public struct Searchmobs
    {
        public PictureBox picture;
        public Label label;
        public string name;
    }


    public partial class Mobs : Form
    {

        public Searchmobs[] mobs = new Searchmobs[19];

        public Mobs()
        {
            InitializeComponent();

            mobs[0] = new Searchmobs();
            mobs[0].name = "Ифрит";
            mobs[0].picture = pictureBox1;
            mobs[0].label = label1;

            mobs[1] = new Searchmobs();
            mobs[1].name = "Зомби-наездник";
            mobs[1].picture = animals;
            mobs[1].label = label2;

            mobs[2] = new Searchmobs();
            mobs[2].name = "Крипер";
            mobs[2].picture = blocks;
            mobs[2].label = label3;

            mobs[3] = new Searchmobs();
            mobs[3].name = "Утопленник";
            mobs[3].picture = building;
            mobs[3].label = label4;

            mobs[4] = new Searchmobs();
            mobs[4].name = "Древний страж";
            mobs[4].picture = mechanisms;
            mobs[4].label = label5;

            mobs[5] = new Searchmobs();
            mobs[5].name = "Чешуйница Края";
            mobs[5].picture = redstone;
            mobs[5].label = label6;

            mobs[6] = new Searchmobs();
            mobs[6].name = "Вызыватель";
            mobs[6].picture = pictureBox4;
            mobs[6].label = label7;
        }

        private void Mobs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Ифрит");
            form.Show();
        }

        private void animals_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Зомби-наездник");
            form.Show();
        }

        private void blocks_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Крипер");
            form.Show();
        }

        private void building_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Утопленник");
            form.Show();
        }

        private void mechanisms_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Древний страж");
            form.Show();
        }

        private void redstone_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Чешуйница Края");
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Вызыватель");
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Гаст");
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Страж");
            form.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Хоглин");
            form.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Кадавр");
            form.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Лавовый куб");
            form.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Фантом");
            form.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Жестокий пинглин");
            form.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Разбойник");
            form.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Разоритель");
            form.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Шалкер");
            form.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Чешуйница");
            form.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Скелет");
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mobs[0].picture.Visible = false;
            mobs[0].label.Visible = false;
            if (mobs[0].name.Contains(textBox1.Text))
            {
                mobs[0].picture.Visible = true;
                mobs[0].label.Visible = true;
            }

            mobs[1].picture.Visible = false;
            mobs[1].label.Visible = false;
            if (mobs[1].name.Contains(textBox1.Text))
            {
                mobs[1].picture.Visible = true;
                mobs[1].label.Visible = true;
            }

            mobs[2].picture.Visible = false;
            mobs[2].label.Visible = false;
            if (mobs[2].name.Contains(textBox1.Text))
            {
                mobs[2].picture.Visible = true;
                mobs[2].label.Visible = true;
            }

            mobs[3].picture.Visible = false;
            mobs[3].label.Visible = false;
            if (mobs[3].name.Contains(textBox1.Text))
            {
                mobs[3].picture.Visible = true;
                mobs[3].label.Visible = true;
            }

            mobs[4].picture.Visible = false;
            mobs[4].label.Visible = false;
            if (mobs[4].name.Contains(textBox1.Text))
            {
                mobs[4].picture.Visible = true;
                mobs[4].label.Visible = true;
            }

            mobs[5].picture.Visible = false;
            mobs[5].label.Visible = false;
            if (mobs[5].name.Contains(textBox1.Text))
            {
                mobs[5].picture.Visible = true;
                mobs[5].label.Visible = true;
            }

            mobs[6].picture.Visible = false;
            mobs[6].label.Visible = false;
            if (mobs[6].name.Contains(textBox1.Text))
            {
                mobs[6].picture.Visible = true;
                mobs[6].label.Visible = true;
            }
        }

       
    }
}
