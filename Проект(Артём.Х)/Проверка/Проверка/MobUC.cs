using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проверка
{
    public partial class MobUC : UserControl
    {
        Searchmobs vnutrennyMobEtoiFormy;

        public MobUC(Searchmobs mobStayi)
        {
            vnutrennyMobEtoiFormy = mobStayi;
            InitializeComponent();

            Text = mobStayi.name;
            pictureBox2.Image = mobStayi.picture.Image;
            pictureBox2.Click += new EventHandler(Mobs.OpenMob);
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Tag = mobStayi.name;
            label1.Text = mobStayi.name;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mobs.Mob_like.Remove(vnutrennyMobEtoiFormy);
            this.Parent = null;
        }
    }
}
