using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string[] lines;
            lines = File.ReadAllLines("RuWords.txt");
            foreach (string line in lines)
            {
                string[] Ru = line.Split(new string[] { "; " }, StringSplitOptions.None);
                Ruswords.Add(Ru[0], Ru[1]);
            }


            lines = File.ReadAllLines("EnWords.txt");
            foreach (string line in lines)
            {
                string[] En = line.Split(new string[] { "; " }, StringSplitOptions.None);
                Engwords.Add(En[0], En[1]);
            }
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
            string[] lines;
            lines = File.ReadAllLines("AllMobs.txt");
            foreach (string line in lines)
            {
                string[] mob = line.Split(new string[] { "; " }, StringSplitOptions.None);
                mob_list.Add(new Searchmobs(mob[0], mob[1], mob[2]));
            }

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
