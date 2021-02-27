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

        public Searchmobs(string name1, string land1)
        {
            name = name1;
            land = land1;
            label = new Label();
            picture = new PictureBox();

        }
    }


    public partial class Mobs : Form
    {

        public Searchmobs[] mobs = new Searchmobs[29];
        public List<Searchmobs> mob_list = new List<Searchmobs>();

        public Mobs()
        {
            InitializeComponent();

            mob_list.Add(new Searchmobs("Ифрит", "Ад"));
            mob_list.Add(new Searchmobs("Зомби-наездник", "Верхний мир"));
            mob_list.Add(new Searchmobs("Крипер", "Верхний мир"));
            mob_list.Add(new Searchmobs("Утопленник", "Верхний мир"));
            mob_list.Add(new Searchmobs("Древний страж", "Верхний мир"));
            mob_list.Add(new Searchmobs("Чешуйница Края", "Верхний мир, Ад, Край"));
            mob_list.Add(new Searchmobs("Вызыватель", "Верхний мир"));
            mob_list.Add(new Searchmobs("Гаст", "Ад"));
            mob_list.Add(new Searchmobs("Страж", "Верхний мир"));
            mob_list.Add(new Searchmobs("Хоглин", "Ад"));
            mob_list.Add(new Searchmobs("Кадавр", "Верхний мир"));
            mob_list.Add(new Searchmobs("Лавовый куб", "Ад"));
            mob_list.Add(new Searchmobs("Фантом", "Верхний мир"));
            mob_list.Add(new Searchmobs("Жестокий пинглин", "Ад"));
            mob_list.Add(new Searchmobs("Разбойник", "Верхний мир"));
            mob_list.Add(new Searchmobs("Разоритель", "Верхний мир"));
            mob_list.Add(new Searchmobs("Шалкер", "Край"));
            mob_list.Add(new Searchmobs("Чешуйница", "Верхний мир"));
            mob_list.Add(new Searchmobs("Скелет", "Верхний мир"));
            mob_list.Add(new Searchmobs("Cкелет-наездник", "Верхний мир"));
            mob_list.Add(new Searchmobs("Слизень", "Верхний мир"));
            mob_list.Add(new Searchmobs("Зимогор", "Верхний мир"));
            mob_list.Add(new Searchmobs("Досаждатель", "Верхний мир"));
            mob_list.Add(new Searchmobs("Поборник", "Верхний мир"));
            mob_list.Add(new Searchmobs("Ведьма", "Верхний мир"));
            mob_list.Add(new Searchmobs("Скелет-иссушитель", "Ад"));
            mob_list.Add(new Searchmobs("Зоглин", "Ад"));
            mob_list.Add(new Searchmobs("Зомби", "Верхний мир"));
            mob_list.Add(new Searchmobs("Зомби-житель", "Верхний мир"));

            int x = 10;
            int y = 80;
            for (int i = 0; i < mob_list.Count; i++)
            {

                mob_list[i].picture.BackColor = Color.Transparent;
                mob_list[i].picture.Tag = mob_list[i].name;
                mob_list[i].picture.Location = new Point(x, y);
                mob_list[i].picture.Size = new Size(300, 300);
                mob_list[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                mob_list[i].picture.Click += new EventHandler(OpenMob);
                try
                {
                    mob_list[i].picture.Load("../../Мобы/" + mob_list[i].name + ".gif");
                }
                catch (Exception)
                {
                    mob_list[i].picture.Load("../../Мобы/" + mob_list[i].name + ".png");
                }
                mobs[i].picture = mob_list[i].picture;
                Controls.Add(mob_list[i].picture);


                mob_list[i].label.AutoSize = true;
                mob_list[i].label.BackColor = Color.Transparent;
                mob_list[i].label.ForeColor = Color.Red;
                mob_list[i].label.Font = new Font("Microsoft Sans Serif", 15F);
                mob_list[i].label.Location = new Point(x + 100, y + 300);
                mob_list[i].label.Size = new Size(300, 29);
                mob_list[i].label.TabIndex = 31;
                mob_list[i].label.Text = mob_list[i].name;
                Controls.Add(mob_list[i].label);


                x = x + 300;
                if (x + 300 > Width)
                {
                    x = 10;
                    y = y + 350;
                }
            }
        }
       

        private void OpenMob(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            MobForm form = new MobForm(picture.Tag.ToString());
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 80;
            for (int i = 0; i < mob_list.Count; i++)
            {
                mob_list[i].picture.Visible = true;
                mob_list[i].label.Visible = true;
                if (textBox1.Text != "" &&
                    !mob_list[i].name.Contains(textBox1.Text))
                {
                    mob_list[i].picture.Visible = false;
                    mob_list[i].label.Visible = false;
                }

                if (comboBox1.Text != "" &&
                    !mob_list[i].land.Contains(comboBox1.Text))
                    //mobs[i].land != comboBox1.Text)
                {
                    mob_list[i].picture.Visible = false;
                    mob_list[i].label.Visible = false;
                }


                if (mob_list[i].picture.Visible)
                {
                    mob_list[i].picture.Location = new Point(x, y);
                    mob_list[i].label.Location = new Point(x + 100, y + 300);

                    x = x + 300;
                    if (x + 300 > Width)
                    {
                        x = 10;
                        y = y + 350;
                    }
                }
            }



        }
      
    }
}
