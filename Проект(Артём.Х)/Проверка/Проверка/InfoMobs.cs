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
    public partial class InfoMobs : Form
    {
        void RenameAll(Dictionary<string, string> Words)
        {
            button1.Text = Words["Нижний мир"];
            button1.Text = Words["Верхний мир"];
            button1.Text = Words["Край"];
        }

        public InfoMobs(string Infomobs)
        {
            InitializeComponent();

            Text = Infomobs;
            

            if (Mobs.Language == "Английский")
            {
                RenameAll(Mobs.Engwords);
            }

            try
            {
                label33.Text = File.ReadAllText("../../Инфомобы.txt");

            }
            catch (Exception) { }

         
        }
    }
}
