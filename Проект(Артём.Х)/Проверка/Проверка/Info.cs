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
    public partial class Info : Form
    {
     
        void RenameAll(Dictionary<string, string> Words)
        {

        }


        string groupName;

        public Info(string w)
        {
            InitializeComponent();

            Text = MobType;
            label2.Text = MobType;

            if (Mobs.Language == "Английский")
            {
                RenameAll(Mobs.Engwords);
            }

            try
            {
                label3.Text = File.ReadAllText("../../" + MobType + ".txt");
                label1.Text = File.ReadAllText("../../" + MobType + "2.txt");
            }
            catch (Exception) { }

            try
            {
                pictureBox1.Load("../../" + MobType + ".gif");
            }
            catch (Exception)
            {
                pictureBox1.Load("../../"+ MobType + ".png");
            }



        }

        }

      
    }
}

