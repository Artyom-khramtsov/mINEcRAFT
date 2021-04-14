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


    

        public Info(string world)
        {
            InitializeComponent();

            Text = world;
            label2.Text = world;

            if (Mobs.Language == "Английский")
            {
                RenameAll(Mobs.Engwords);
            }

            try
            {
                label33.Text = File.ReadAllText("../../" + world + ".txt");
           
            }
            catch (Exception) { }

            try
            {
                BackgroundImage = Image.FromFile("../../" + world + ".gif");
            }
            catch (Exception)
            {
                BackgroundImage = Image.FromFile("../../" + world + ".png");
                //pictureBox4.Load("../../"+ world + ".png");
            }



        }

        

      
    }
}

