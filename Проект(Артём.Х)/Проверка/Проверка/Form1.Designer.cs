﻿namespace Проверка
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.building)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechanisms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redstone)).BeginInit();
            this.SuspendLayout();
            // 
            // mobs
            // 
            this.mobs.BackColor = System.Drawing.Color.Transparent;
            this.mobs.ErrorImage = null;
            this.mobs.Image = ((System.Drawing.Image)(resources.GetObject("mobs.Image")));
            this.mobs.Location = new System.Drawing.Point(58, 59);
            this.mobs.Margin = new System.Windows.Forms.Padding(4);
            this.mobs.Name = "mobs";
            this.mobs.Size = new System.Drawing.Size(300, 250);
            this.mobs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mobs.TabIndex = 5;
            this.mobs.TabStop = false;
            this.mobs.Click += new System.EventHandler(this.picture1_Click);
            // 
            // animals
            // 
            this.animals.BackColor = System.Drawing.Color.Transparent;
            this.animals.Image = ((System.Drawing.Image)(resources.GetObject("animals.Image")));
            this.animals.Location = new System.Drawing.Point(408, 59);
            this.animals.Margin = new System.Windows.Forms.Padding(4);
            this.animals.Name = "animals";
            this.animals.Size = new System.Drawing.Size(300, 250);
            this.animals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.animals.TabIndex = 6;
            this.animals.TabStop = false;
            this.animals.Click += new System.EventHandler(this.картинка2_Click);
            // 
            // blocks
            // 
            this.blocks.BackColor = System.Drawing.Color.Transparent;
            this.blocks.Image = ((System.Drawing.Image)(resources.GetObject("blocks.Image")));
            this.blocks.Location = new System.Drawing.Point(743, 454);
            this.blocks.Margin = new System.Windows.Forms.Padding(4);
            this.blocks.Name = "blocks";
            this.blocks.Size = new System.Drawing.Size(300, 173);
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
            this.label1.Location = new System.Drawing.Point(85, 320);
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
            this.label2.Location = new System.Drawing.Point(438, 320);
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
            this.label3.Location = new System.Drawing.Point(769, 670);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Приручаемые мобы";
            // 
            // building
            // 
            this.building.BackColor = System.Drawing.Color.Transparent;
            this.building.Image = ((System.Drawing.Image)(resources.GetObject("building.Image")));
            this.building.Location = new System.Drawing.Point(752, 77);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(300, 217);
            this.building.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.building.TabIndex = 14;
            this.building.TabStop = false;
            this.building.Click += new System.EventHandler(this.buildingClick);
            // 
            // mechanisms
            // 
            this.mechanisms.BackColor = System.Drawing.Color.Transparent;
            this.mechanisms.Image = ((System.Drawing.Image)(resources.GetObject("mechanisms.Image")));
            this.mechanisms.Location = new System.Drawing.Point(58, 415);
            this.mechanisms.Name = "mechanisms";
            this.mechanisms.Size = new System.Drawing.Size(300, 250);
            this.mechanisms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mechanisms.TabIndex = 15;
            this.mechanisms.TabStop = false;
            this.mechanisms.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // redstone
            // 
            this.redstone.BackColor = System.Drawing.Color.Transparent;
            this.redstone.Image = ((System.Drawing.Image)(resources.GetObject("redstone.Image")));
            this.redstone.Location = new System.Drawing.Point(408, 415);
            this.redstone.Name = "redstone";
            this.redstone.Size = new System.Drawing.Size(300, 250);
            this.redstone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redstone.TabIndex = 16;
            this.redstone.TabStop = false;
            this.redstone.Click += new System.EventHandler(this.redstone_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(776, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Создаваемые мобы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(75, 668);
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
            this.label7.Location = new System.Drawing.Point(513, 668);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Боссы";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Понравившиеся";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(178, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 32);
            this.button2.TabIndex = 22;
            this.button2.Text = "RU";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(230, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 32);
            this.button3.TabIndex = 23;
            this.button3.Text = "EN";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Snow;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(984, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 32);
            this.button5.TabIndex = 25;
            this.button5.Text = "Нижний мир";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Snow;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(845, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 32);
            this.button4.TabIndex = 26;
            this.button4.Text = "Верхний мир";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Snow;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(714, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 32);
            this.button6.TabIndex = 27;
            this.button6.Text = "Край";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.Snow;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(583, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 32);
            this.button7.TabIndex = 28;
            this.button7.Text = "О мобах";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MineWiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 731);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MineWiki";
            this.Text = "MineWiki";
            this.Load += new System.EventHandler(this.MineWiki_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

