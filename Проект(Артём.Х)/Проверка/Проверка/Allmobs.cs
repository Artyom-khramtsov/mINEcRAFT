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
        public string category;

        public Searchmobs(string name1, string land1, string Category)
        {
            name = name1;
            land = land1;
            label = new Label();
            picture = new PictureBox();
            category = Category;
        }
    }


    public partial class Mobs : Form
    {
        /// <summary>
        /// Все мобы
        /// </summary>
        public static List<Searchmobs> mob_list = new List<Searchmobs>();

        /// <summary>
        /// Мобы, у которых лайк стоит
        /// </summary>
        public static List<Searchmobs> Mob_like = new List<Searchmobs>();

        public static List<Searchmobs> Mob_dislike = new List<Searchmobs>();

        /// <summary>
        /// Формируем список всех мобов
        /// </summary>
        public static void FillMobsList()
        {
            mob_list.Add(new Searchmobs("Ифрит", "Ад", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Зомби-наездник", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Крипер", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Утопленник", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Древний страж", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Чешуйница Края", "Верхний мир, Ад, Край", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Вызыватель", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Гаст", "Ад", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Страж", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Хоглин", "Ад", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Кадавр", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Лавовый куб", "Ад", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Фантом", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Жестокий пинглин", "Ад", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Разбойник", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Разоритель", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Шалкер", "Край", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Чешуйница", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Скелет", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Cкелет-наездник", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Слизень", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Зимогор", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Досаждатель", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Поборник", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Ведьма", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Скелет-иссушитель", "Ад", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Зоглин", "Ад", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Зомби", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Зомби-житель", "Верхний мир", "Враждебные_мобы"));
            mob_list.Add(new Searchmobs("Летучая мышь", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Кошка", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Курица", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Треска", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Корова", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Лошадь", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Лиса", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Грибная корова", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Оцелот", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Попугай", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Свинья", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Кролик", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Лосось", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Овца", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Снежный голем", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Спрут", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Страйдер", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Тропическая рыба", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Черепаха", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Деревенский житель", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Странствующий торговец", "Верхний мир", "Дружелюбные_мобы"));
            mob_list.Add(new Searchmobs("Попугай", "Верхний мир", "Приручаемые_мобы"));
            mob_list.Add(new Searchmobs("Кошка", "Верхний мир", "Приручаемые_мобы"));
            mob_list.Add(new Searchmobs("Лама", "Верхний мир", "Приручаемые_мобы"));
            mob_list.Add(new Searchmobs("Волк", "Верхний мир", "Приручаемые_мобы"));
            mob_list.Add(new Searchmobs("Иссушитель", "Верхний мир, Ад, Край", "Создаваемые_мобы"));
            mob_list.Add(new Searchmobs("Снежный голем", "Верхний мир", "Создаваемые_мобы"));
            mob_list.Add(new Searchmobs("Железный голем", "Верхний мир", "Создаваемые_мобы"));

            for (int i = 0; i < mob_list.Count; i++)
            {
                mob_list[i].picture.Click += new EventHandler(OpenMob);
            }
        }

        string groupName;

        /// <summary>
        /// Открыть форму с мобами
        /// </summary>
        /// <param name="_groupName">Враждебные мобы</param>
        public Mobs(string _groupName)
        {
            InitializeComponent();
            groupName = _groupName;
            Text = groupName;

            /*if (groupName == "Не знаю")
            {
                BackgroundImage = Image.FromFile("../../../../Блоки.jfif");
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            */
            int x = 10;
            int y = 80;
            for (int i = 0; i < mob_list.Count; i++)
            {
                if (mob_list[i].category != groupName)
                    continue;

                mob_list[i].picture.BackColor = Color.Transparent;
                mob_list[i].picture.Tag = mob_list[i].name;
                mob_list[i].picture.Location = new Point(x, y);
                mob_list[i].picture.Size = new Size(300, 300);
                mob_list[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                try
                {
                    mob_list[i].picture.Load("../../" + groupName + "/" + mob_list[i].name + ".gif");
                }
                catch (Exception)
                {
                    mob_list[i].picture.Load("../../" + groupName + "/" + mob_list[i].name + ".png");
                }
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


        public static void OpenMob(object sender, EventArgs e)
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
                if (mob_list[i].category != groupName)
                    continue;

                mob_list[i].picture.Visible = true;
                mob_list[i].label.Visible = true;
                if (textBox1.Text != "" &&
                    !mob_list[i].name.Contains(textBox1.Text))
                {
                    mob_list[i].picture.Visible = false;
                    mob_list[i].label.Visible = false;
                }

                if (comboBox1.Text != "" &&
                    comboBox1.Text != "В каком мире находится?" &&
                    !mob_list[i].land.Contains(comboBox1.Text))
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

        private void Mobs_Load(object sender, EventArgs e)
        {

        }
    }
}
