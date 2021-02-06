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
   

    public partial class HostileMobsForm : Form
    {
        

        public HostileMobsForm(string MobType)
        {
            InitializeComponent();

            Text = MobType;
            label2.Text = MobType;
            label3.Text = File.ReadAllText("../../мобы/" + MobType + ".txt");
            label1.Text = File.ReadAllText("../../мобы/" + MobType + "2.txt");

            try
            {
                pictureBox1.Load("../../Мобы/" + MobType + ".gif");
            }
            catch (Exception)
            {
                pictureBox1.Load("../../Мобы/" + MobType + ".png");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HostileMobsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
