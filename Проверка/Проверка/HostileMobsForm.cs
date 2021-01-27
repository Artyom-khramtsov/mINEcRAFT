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
                label1.Text = "Здоровье" +
                    Environment.NewLine + "Зомби - ребёнок: 20" +
                    Environment.NewLine + "Курица: 4" +
                    Environment.NewLine + "Сила атаки" +
                    Environment.NewLine + "Зависит от здоровья зомби-ребёнка" +
                    Environment.NewLine + "Спаун" +
                    Environment.NewLine + "Обычный или Нижний мир.Уровень освещения 7 или меньше. Везде, кроме плит и стекла." +
                    Environment.NewLine + "Дроп" +
                    Environment.NewLine + "Зомби - ребёнок:" +
                    Environment.NewLine + "Гнилая плоть(0–2)" +
                    Environment.NewLine + "Зомби - свиночеловек - ребёнок:" +
                    Environment.NewLine + "Гнилая плоть(0–1)" +
                    Environment.NewLine + "Кусочек золота(0–1)" +
                    Environment.NewLine + "Курица:" +
                    Environment.NewLine + "Перо(0–2)" +
                    Environment.NewLine + "Сырая курятина(0–1)" +
                    Environment.NewLine + "Жареная курятина(0–1) при смерти от огня" +
                    Environment.NewLine + "Редкий дроп" +
                    Environment.NewLine + "Зомби - ребёнок:" +
                    Environment.NewLine + "Железный слиток" +
                    Environment.NewLine + "Железный шлем" +
                    Environment.NewLine + "Морковь" +
                    Environment.NewLine + "Картофель";
               
                label3.Text = "Спаун" +
                    Environment.NewLine + "Каждый ребенок-зомби, ребенок - кадавр, ребенок - зомби - деревенский житель, ребенок - зомбированный пиглин или ребенок - утопленник, который спаунится, имеет 5 % шанс проверить наличие существующей курицы в коробке размером 10×6×10, центрированной на месте появления ребенка, и спаунится верхом на одной из этих куриц, если таковые имеются. Если это не дает 5 % -ного шанса проверить наличие существующих цыплят, то существует дополнительный 5 % -ный шанс появления детеныша зомби, установленного на новой курице.В среде, свободной от куриц, каждый порожденный зомби имеет 0,25 % шанс стать зомби-наездником; если курицы присутствуют, шанс увеличивается до 0,4875 %" +
                    Environment.NewLine + "Зомби - наездники могут спаунится с предметами. Детские зомбированные версии пиглина всегда имеют золотой меч, в то время как детские утопленные версии могут иметь трезубец." +
                    Environment.NewLine + "В Java Edition существует чрезвычайно низкий шанс для ребенка - зомби - деревенского жителя появиться полностью в алмазной броне, полностью зачарованной и держать зачарованный железный меч во время езды на цыпленке; этот шанс равен 1 из 1,9921×1035, что делает этого моба самым редким в игре." +
                    Environment.NewLine + "В Bedrock Edition, ребёнок - зомби, ребёнок - кадавр и ребёнок-зомби - житель имеют 15 % шанс стать наездником, когда он пытается атаковать деревенского жителя, игрока или железного голема, который может ездить верхом:" +
                    Environment.NewLine + "Взрослые курицы; Взрослые оцелоты и кошки; Взрослые дикие волки; Взрослые зомби и их варианты; Коровы; Свиньи; Овца; Лошади и их варианты; Муухоморы; Пауки; Пещерные пауки; Панды";
                pictureBox1.Load("../../Мобы/Зомби-наездник.png");
            }
            if (MobType == "Крипер")
            {
                label3.Text = File.ReadAllText("../../мобы/Крипер.txt");
                label3.Text = File.ReadAllText("../../мобы/" + MobType + ".txt");
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
