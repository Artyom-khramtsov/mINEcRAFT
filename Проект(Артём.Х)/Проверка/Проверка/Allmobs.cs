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

        public static Dictionary<string, string> Ruswords = new Dictionary<string, string>();
        public static Dictionary<string, string> Engwords = new Dictionary<string, string>();

        public static string Language = "Русский";

        public static void FillWords()
        {
            Ruswords.Add("Понравившиеся", "Понравившиеся");
            Engwords.Add("Понравившиеся", "Liked ones");
            Ruswords.Add("Враждебные мобы", "Враждебные мобы");
            Engwords.Add("Враждебные мобы", "Hostile mobs");
            Ruswords.Add("Дружелюбные мобы", "Дружелюбные мобы");
            Engwords.Add("Дружелюбные мобы", "Friendly mobs");
            Ruswords.Add("Приручаемые мобы", "Приручаемые мобы");
            Engwords.Add("Приручаемые мобы", "Tame mobs");
            Ruswords.Add("Создаваемые мобы", "Создаваемые мобы");
            Engwords.Add("Создаваемые мобы", "Created mobs");
            Ruswords.Add("Нейтральные мобы", "Нейтральные мобы");
            Engwords.Add("Нейтральные мобы", "Neutral mobs");
            Ruswords.Add("Боссы", "Боссы");
            Engwords.Add("Боссы", "Bosses");

            Ruswords.Add("Ифрит", "Ифрит");
            Engwords.Add("Ифрит", "Blaze");
            Ruswords.Add("Cкелет-наездник", "Cкелет-наездник");
            Engwords.Add("Cкелет-наездник", "Spider Jockey");
            Ruswords.Add("Ведьма", "Ведьма");
            Engwords.Add("Ведьма", "Witch");
            Ruswords.Add("Вызыватель", "Вызыватель");
            Engwords.Add("Вызыватель", "Evoker");
            Ruswords.Add("Гаст", "Гаст");
            Engwords.Add("Гаст", "Ghast");
            Ruswords.Add("Досаждатель", "Досаждатель");
            Engwords.Add("Досаждатель", "Vex");
            Ruswords.Add("Древний страж", "Древний страж");
            Engwords.Add("Древний страж", "Elder guardian");
            Ruswords.Add("Жестокий пинглин", "Жестокий пинглин");
            Engwords.Add("Жестокий пинглин", "Piglin Brute");
            Ruswords.Add("Зимогор", "Зимогор");
            Engwords.Add("Зимогор", "Stray");
            Ruswords.Add("Зоглин", "Зоглин");
            Engwords.Add("Зоглин", "Zoglin");
            Ruswords.Add("Зомби", "Зомби");
            Engwords.Add("Зомби", "Zombie");
            Ruswords.Add("Зомби-житель", "Зомби-житель");
            Engwords.Add("Зомби-житель", "Zombie villagers");
            Ruswords.Add("Зомби-наездник", "Зомби-наездник");
            Engwords.Add("Зомби-наездник", "Chicken Jockey");
            Ruswords.Add("Кадавр", "Кадавр");
            Engwords.Add("Кадавр", "Husk");
            Ruswords.Add("Крипер", "Крипер");
            Engwords.Add("Крипер", "Creeper");
            Ruswords.Add("Лавовый куб", "Лавовый куб");
            Engwords.Add("Лавовый куб", "Magma Cube");
            Ruswords.Add("Поборник", "Поборник");
            Engwords.Add("Поборник", "Vindicator");
            Ruswords.Add("Разбойник", "Разбойник");
            Engwords.Add("Разбойник", "Pillager");
            Ruswords.Add("Разоритель", "Разоритель");
            Engwords.Add("Разоритель", "Ravager");
            Ruswords.Add("Скелет", "Скелет");
            Engwords.Add("Скелет", "Skeleton");
            Ruswords.Add("Скелет-иссушитель", "Скелет-иссушитель");
            Engwords.Add("Скелет-иссушитель", "Wither Skeleton");
            Ruswords.Add("Слизень", "Слизень");
            Engwords.Add("Слизень", "Slime");
            Ruswords.Add("Страж", "Страж");
            Engwords.Add("Страж", "Guardian");
            Ruswords.Add("Утопленник", "Утопленник");
            Engwords.Add("Утопленник", "Drowned");
            Ruswords.Add("Фантом", "Фантом");
            Engwords.Add("Фантом", "Phantom");
            Ruswords.Add("Хоглин", "Хоглин");
            Engwords.Add("Хоглин", "Hoglin");
            Ruswords.Add("Чешуйница Края", "Чешуйница Края");
            Engwords.Add("Чешуйница Края", "Endermite");
            Ruswords.Add("Чешуйница", "Чешуйница");
            Engwords.Add("Чешуйница", "Silverfish");
            Ruswords.Add("Шалкер", "Шалкер");
            Engwords.Add("Шалкер", "Shulker");


            Ruswords.Add("В каком мире находится?", "В каком мире находится?");
            Engwords.Add("В каком мире находится?", "What world is it in?");
            Ruswords.Add("Поиск", "Поиск");
            Engwords.Add("Поиск", "Search");
        }

        void RenameAll(Dictionary<string, string> Words)
        {
            comboBox1.Text = Words["В каком мире находится?"];
            button1.Text = Words["Поиск"];
            Text = Words[groupName];
        }
        /// <summary>
        /// Формируем список всех мобов
        /// </summary>
        public static void FillMobsList()
        {
            mob_list.Add(new Searchmobs("Ифрит", "Ад", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Зомби-наездник", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Крипер", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Утопленник", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Древний страж", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Чешуйница Края", "Верхний мир, Ад, Край", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Вызыватель", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Гаст", "Ад", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Страж", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Хоглин", "Ад", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Кадавр", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Лавовый куб", "Ад", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Фантом", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Жестокий пинглин", "Ад", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Разбойник", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Разоритель", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Шалкер", "Край", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Чешуйница", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Скелет", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Cкелет-наездник", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Слизень", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Зимогор", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Досаждатель", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Поборник", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Ведьма", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Скелет-иссушитель", "Ад", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Зоглин", "Ад", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Зомби", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Зомби-житель", "Верхний мир", "Враждебные мобы"));
            mob_list.Add(new Searchmobs("Летучая мышь", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Кошка", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Курица", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Треска", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Корова", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Лошадь", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Лиса", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Грибная корова", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Оцелот", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Попугай", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Свинья", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Кролик", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Лосось", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Овца", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Снежный голем", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Спрут", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Страйдер", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Тропическая рыба", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Черепаха", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Деревенский житель", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Странствующий торговец", "Верхний мир", "Дружелюбные мобы"));
            mob_list.Add(new Searchmobs("Попугай", "Верхний мир", "Приручаемые мобы"));
            mob_list.Add(new Searchmobs("Кошка", "Верхний мир", "Приручаемые мобы"));
            mob_list.Add(new Searchmobs("Лама", "Верхний мир", "Приручаемые мобы"));
            mob_list.Add(new Searchmobs("Волк", "Верхний мир", "Приручаемые мобы"));
            mob_list.Add(new Searchmobs("Иссушитель", "Верхний мир, Ад, Край", "Создаваемые мобы"));
            mob_list.Add(new Searchmobs("Снежный голем", "Верхний мир", "Создаваемые мобы"));
            mob_list.Add(new Searchmobs("Железный голем", "Верхний мир", "Создаваемые мобы"));
            mob_list.Add(new Searchmobs("Иссушитель", "Верхний мир, Ад, Край", "Боссы"));
            mob_list.Add(new Searchmobs("Дракон края", "Край", "Боссы"));
            mob_list.Add(new Searchmobs("Лама", "Верхний мир", "Приручаемые мобы"));
            mob_list.Add(new Searchmobs("Железный голем", "Верхний мир", "Нейтральные мобы"));
            mob_list.Add(new Searchmobs("Волк", "Верхний мир", "Нейтральные мобы"));
            mob_list.Add(new Searchmobs("Белый медведь", "Верхний мир", "Нейтральные мобы"));
            mob_list.Add(new Searchmobs("Дельфин", "Верхний мир", "Нейтральные мобы"));
            mob_list.Add(new Searchmobs("Зомбифицированный пиглин", "Ад", "Нейтральные мобы"));
            mob_list.Add(new Searchmobs("Иглобрюх", "Верхний мир", "Нейтральные мобы"));
            mob_list.Add(new Searchmobs("Панда", "Верхний мир", "Нейтральные мобы"));
            mob_list.Add(new Searchmobs("Паук", "Верхний мир", "Нейтральные мобы"));
            mob_list.Add(new Searchmobs("Пещерный паук", "Верхний мир", "Нейтральные мобы"));
            mob_list.Add(new Searchmobs("Пиглин", "Ад", "Нейтральные мобы"));
            mob_list.Add(new Searchmobs("Пчела", "Верхний мир", "Нейтральные мобы"));
            mob_list.Add(new Searchmobs("Странник Края", "Край", "Нейтральные мобы"));

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

            if (Language == "Английский")
            {
                RenameAll(Engwords);
            }

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
                try
                {
                    if (Language == "Английский")
                        mob_list[i].label.Text = Engwords[mob_list[i].name];
                }
                catch (Exception) { }
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
