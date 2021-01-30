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
            if (MobType == "Ифрит")
            {     
                pictureBox1.Load("../../Мобы/ифрит.gif");
            }
            if (MobType == "Зомби-наездник")
            {
                pictureBox1.Load("../../Мобы/Зомби-наездник.png");
            }
            if (MobType == "Крипер")
            {
                pictureBox1.Load("../../Мобы/Крипер.png");
            }
            if (MobType == "Утопленник")
            {
                pictureBox1.Load("../../Мобы/Утопленник.png");
            }
            if (MobType == "Древний страж")
            {
                pictureBox1.Load("../../Мобы/Древний страж.gif");
            }
            if (MobType == "Чешуйница Края")
            {
                pictureBox1.Load("../../Мобы/Чешуйница Края.gif");
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
