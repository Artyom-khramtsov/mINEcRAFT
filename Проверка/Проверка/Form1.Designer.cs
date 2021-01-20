namespace Проверка
{
    partial class MineWiki
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MineWiki));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mobs = new System.Windows.Forms.PictureBox();
            this.animals = new System.Windows.Forms.PictureBox();
            this.blocks = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.building = new System.Windows.Forms.PictureBox();
            this.mechanisms = new System.Windows.Forms.PictureBox();
            this.redstone = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.building)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanisms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redstone)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(300, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 26);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mobs
            // 
            this.mobs.BackColor = System.Drawing.Color.Transparent;
            this.mobs.ErrorImage = null;
            this.mobs.Image = ((System.Drawing.Image)(resources.GetObject("mobs.Image")));
            this.mobs.Location = new System.Drawing.Point(100, 125);
            this.mobs.Margin = new System.Windows.Forms.Padding(4);
            this.mobs.Name = "mobs";
            this.mobs.Size = new System.Drawing.Size(300, 300);
            this.mobs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mobs.TabIndex = 5;
            this.mobs.TabStop = false;
            this.mobs.Click += new System.EventHandler(this.picture1_Click);
            // 
            // animals
            // 
            this.animals.BackColor = System.Drawing.Color.Transparent;
            this.animals.Image = ((System.Drawing.Image)(resources.GetObject("animals.Image")));
            this.animals.Location = new System.Drawing.Point(450, 125);
            this.animals.Margin = new System.Windows.Forms.Padding(4);
            this.animals.Name = "animals";
            this.animals.Size = new System.Drawing.Size(300, 300);
            this.animals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.animals.TabIndex = 6;
            this.animals.TabStop = false;
            this.animals.Click += new System.EventHandler(this.картинка2_Click);
            // 
            // blocks
            // 
            this.blocks.BackColor = System.Drawing.Color.Transparent;
            this.blocks.Image = ((System.Drawing.Image)(resources.GetObject("blocks.Image")));
            this.blocks.Location = new System.Drawing.Point(800, 125);
            this.blocks.Margin = new System.Windows.Forms.Padding(4);
            this.blocks.Name = "blocks";
            this.blocks.Size = new System.Drawing.Size(300, 300);
            this.blocks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blocks.TabIndex = 7;
            this.blocks.TabStop = false;
            this.blocks.Click += new System.EventHandler(this.blocksClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(127, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Враждебные мобы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(480, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Дружелюбные мобы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(900, 425);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Блоки";
            // 
            // building
            // 
            this.building.BackColor = System.Drawing.Color.Transparent;
            this.building.Image = ((System.Drawing.Image)(resources.GetObject("building.Image")));
            this.building.Location = new System.Drawing.Point(100, 475);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(300, 300);
            this.building.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.building.TabIndex = 14;
            this.building.TabStop = false;
            this.building.Click += new System.EventHandler(this.buildingClick);
            // 
            // mechanisms
            // 
            this.mechanisms.BackColor = System.Drawing.Color.Transparent;
            this.mechanisms.Image = ((System.Drawing.Image)(resources.GetObject("mechanisms.Image")));
            this.mechanisms.Location = new System.Drawing.Point(450, 475);
            this.mechanisms.Name = "mechanisms";
            this.mechanisms.Size = new System.Drawing.Size(300, 300);
            this.mechanisms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mechanisms.TabIndex = 15;
            this.mechanisms.TabStop = false;
            this.mechanisms.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // redstone
            // 
            this.redstone.BackColor = System.Drawing.Color.Transparent;
            this.redstone.Image = ((System.Drawing.Image)(resources.GetObject("redstone.Image")));
            this.redstone.Location = new System.Drawing.Point(800, 475);
            this.redstone.Name = "redstone";
            this.redstone.Size = new System.Drawing.Size(300, 300);
            this.redstone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redstone.TabIndex = 16;
            this.redstone.TabStop = false;
            this.redstone.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(186, 788);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Постройки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(489, 788);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Нейтральные мобы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(904, 788);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Редстоун";
            // 
            // MineWiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 857);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.redstone);
            this.Controls.Add(this.mechanisms);
            this.Controls.Add(this.building);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blocks);
            this.Controls.Add(this.animals);
            this.Controls.Add(this.mobs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MineWiki";
            this.Text = "MineWiki";
            ((System.ComponentModel.ISupportInitialize)(this.mobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.building)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanisms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redstone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox mobs;
        private System.Windows.Forms.PictureBox animals;
        private System.Windows.Forms.PictureBox blocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox building;
        private System.Windows.Forms.PictureBox mechanisms;
        private System.Windows.Forms.PictureBox redstone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

