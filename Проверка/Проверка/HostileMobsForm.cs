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
    public partial class HostileMobsForm : Form
    {
        public HostileMobsForm(string MobType)
        {
            InitializeComponent();
            Text = MobType;
            if (MobType == "Ифрит")
            {
                label1.Text = "Ифрит (англ. Blaze) — летающий враждебный моб, появляющийся в адских крепостях." +
                    Environment.NewLine + "Здоровье	20" +
                    Environment.NewLine + "           Ближний бой:" +
                    Environment.NewLine + "           Легко: 2" +
                    Environment.NewLine + "Сила атаки Нормально: 3" +
                    Environment.NewLine + "           Сложно: 4" +
                    Environment.NewLine + "Маленький огненный шар: 5" +
                    Environment.NewLine + "Размер Высота: 1,8 блока" +
                    Environment.NewLine + "       Ширина: 0,6 блока";
                label2.Text = "Ифрит";
                label3.Text = "Появление: Ифриты появляются в адских крепостях из спаунеров, которые расположены на небольших платформах," +
                    Environment.NewLine + "ри уровне освещения 11 или ниже." +
                    Environment.NewLine + "Дроп" +
                    Environment.NewLine + "0—1 огненный стержень(0—4 при зачаровании Добычи III), если убит игроком или приручённым волком. " +
                    Environment.NewLine + "10 Сфера опыта, если убит игроком или приручённым волком." +
                    Environment.NewLine + "Поведение" +
                    Environment.NewLine + "Ифриты летают, но когда не атакуют, медленно опускаются в воздухе или и вовсе остаются на земле. " +
                    Environment.NewLine + "Ифриты не пытаются всплыть в лаве или воде." +
                    Environment.NewLine + "Это означает, что они не пытаются защититься, когда получают урон от воды, но сами в воду никогда не зайдут." +
                    Environment.NewLine + "Ифриты устойчивы к лаве и огню." +
                    Environment.NewLine + "Атака" +
                    Environment.NewLine + "Ифриты атакуют игроков в радиусе 48 блоков.Если один из ифритов получил урон от игрока или моба,  " +
                    Environment.NewLine + "он предупреждает всех остальных ифритов в радиусе 48 блоков," +
                    Environment.NewLine + "чтобы они напали на атаковавшего.Ифрит пытается подлететь к цели, пока не окажется на расстоянии 0,5 - 3,5 блока от неё." +
                    Environment.NewLine + "Ифрит атакует цель своими огненными шарами. Стреляет только в том случае, если видит цель по прямой." +
                    Environment.NewLine + "Интервал между атаками составляет 5 секунд, по истечении которых в течение 0,9 секунды моб выпускает 3 огненных шара и загорается. " +
                    Environment.NewLine + "Если игрок спрячется, то ифрит остановит атаку, не выпустив все 3 шара.Точность стрельбы сравнима с раздатчиком, " +
                    Environment.NewLine + "но в отличие от последнего, скорость его шаров постоянна." +
                    Environment.NewLine + "Если же ифрит подлетит вплотную к цели, он будет использовать атаку ближнего боя, нанося на нормальной сложности 6 урона в секунду.";
                pictureBox1.Load("../../Мобы/ифрит.gif");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
