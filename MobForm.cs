using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проверка
{
   

    public partial class MobForm : Form
    {
        

        public MobForm(string MobType)
        {
            InitializeComponent();

            Text = MobType;
            label2.Text = MobType;
            try
            {
                label3.Text = File.ReadAllText("../../мобы/" + MobType + ".txt");
                label1.Text = File.ReadAllText("../../мобы/" + MobType + "2.txt");
            }
            catch (Exception) { }

            try
            {
                pictureBox1.Load("../../Мобы/" + MobType + ".gif");
            }
            catch (Exception)
            {
                pictureBox1.Load("../../Мобы/" + MobType + ".png");
            }
        }

        
    }
}
