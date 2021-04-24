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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Minecraft");

        }
    }
}
