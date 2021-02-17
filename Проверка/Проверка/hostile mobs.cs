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
        public string land;
    }


    public partial class Mobs : Form
    {

        public Searchmobs[] mobs = new Searchmobs[30];

        public Mobs()
        {
            InitializeComponent();

            mobs[0] = new Searchmobs();
            mobs[0].name = "Ифрит";
            mobs[0].land = "Ад";

            mobs[1] = new Searchmobs();
            mobs[1].name = "Зомби-наездник";
            mobs[1].land = "Верхний мир";

            mobs[2] = new Searchmobs();
            mobs[2].name = "Крипер";
            mobs[2].land = "Верхний мир";

            mobs[3] = new Searchmobs();
            mobs[3].name = "Утопленник";
            mobs[3].land = "Верхний мир";

            mobs[4] = new Searchmobs();
            mobs[4].name = "Древний страж";
            mobs[4].land = "Верхний мир";

            mobs[5] = new Searchmobs();
            mobs[5].name = "Чешуйница Края";
            mobs[5].land = "Верхний мир, Ад, Край";

            mobs[6] = new Searchmobs();
            mobs[6].name = "Вызыватель";
            mobs[6].land = "Верхний мир";

            mobs[7] = new Searchmobs();
            mobs[7].name = "Гаст";
            mobs[7].land = "Ад";

            mobs[8] = new Searchmobs();
            mobs[8].name = "Страж";
            mobs[8].land = "Верхний мир";

            mobs[9] = new Searchmobs();
            mobs[9].name = "Хоглин";
            mobs[9].land = "Ад";

            mobs[10] = new Searchmobs();
            mobs[10].name = "Кадавр";
            mobs[10].land = "Верхний мир";

            mobs[11] = new Searchmobs();
            mobs[11].name = "Лавовый куб";
            mobs[11].land = "Ад";

            mobs[12] = new Searchmobs();
            mobs[12].name = "Фантом";
            mobs[12].picture = pictureBox13;
            mobs[12].label = label13;
            mobs[12].land = "Верхний мир";

            mobs[13] = new Searchmobs();
            mobs[13].name = "Жестокий пинглин";
            mobs[13].picture = pictureBox14;
            mobs[13].label = label14;
            mobs[13].land = "Ад";

            int x = 10;
            int y = 80;
            for (int i = 0; i < 14; i++)
            {


                PictureBox pb1 = new PictureBox();

                pb1.BackColor = Color.Transparent;
                pb1.Location = new Point(x, y);
                pb1.Size = new Size(300, 300);
                pb1.SizeMode = PictureBoxSizeMode.Zoom;
                try
                {
                    pb1.Load("../../Мобы/" + mobs[i].name + ".gif");
                }
                catch (Exception)
                {
                    pb1.Load("../../Мобы/" + mobs[i].name + ".png");
                }
                mobs[i].picture = pb1;
                Controls.Add(pb1);

                Label Lb1 = new Label();
                Lb1.AutoSize = true;
                Lb1.BackColor = Color.Transparent;
                Lb1.ForeColor = Color.Red;
                Lb1.Font = new Font("Microsoft Sans Serif", 15F);
                Lb1.Location = new Point(x + 100, y + 300);
                Lb1.Size = new Size(300, 29);
                Lb1.TabIndex = 31;
                Lb1.Text = mobs[i].name;
                mobs[i].label = Lb1;
                Controls.Add(Lb1);

                x = x + 350;
                if(x + 300 > Width)
                {
                    x = 10;
                    y = y + 350;
                }

            }
        }
        private void Mobs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Ифрит");
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Зомби-наездник");
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Крипер");
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Утопленник");
            form.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Древний страж");
            form.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Чешуйница Края");
            form.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Вызыватель");
            form.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Гаст");
            form.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Страж");
            form.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Хоглин");
            form.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Кадавр");
            form.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Лавовый куб");
            form.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Фантом");
            form.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Жестокий пинглин");
            form.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Разбойник");
            form.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Разоритель");
            form.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Шалкер");
            form.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Чешуйница");
            form.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Скелет");
            form.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Слизень");
            form.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Cкелет-наездник");
            form.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Зимогор");
            form.Show();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Досаждатель");
            form.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Поборник");
            form.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Ведьма");
            form.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Скелет-иссушитель");
            form.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Зоглин");
            form.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Зомби");
            form.Show();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Зомби-житель");
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 14; i++)
            {
                mobs[i].picture.Visible = true;
                mobs[i].label.Visible = true;
                if (textBox1.Text != "" &&
                    !mobs[i].name.Contains(textBox1.Text))
                {
                    mobs[i].picture.Visible = false;
                    mobs[i].label.Visible = false;
                }

                if (comboBox1.Text != "" &&
                    !mobs[i].land.Contains(comboBox1.Text))
                    //mobs[i].land != comboBox1.Text)
                {
                    mobs[i].picture.Visible = false;
                    mobs[i].label.Visible = false;
                }
            }



        }
      
    }
}
