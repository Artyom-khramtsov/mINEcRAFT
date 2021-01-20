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
    public partial class Mobs : Form
    {
        public Mobs()
        {
            InitializeComponent();
        }

        private void Mobs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Ифрит");
            form.Show();
        }

        private void animals_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Зомби-наездник");
            form.Show();
        }

        private void blocks_Click(object sender, EventArgs e)
        {
            HostileMobsForm form = new HostileMobsForm("Крипер");
            form.Show();
        }
    }
}
