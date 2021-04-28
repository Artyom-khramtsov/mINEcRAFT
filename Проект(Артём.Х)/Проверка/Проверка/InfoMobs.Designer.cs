namespace Проверка
{
    partial class InfoMobs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoMobs));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label33 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1182, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Об игре");
            this.pictureBox1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label33
            // 
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label33.Cursor = System.Windows.Forms.Cursors.No;
            this.label33.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label33.Location = new System.Drawing.Point(0, 429);
            this.label33.Multiline = true;
            this.label33.Name = "label33";
            this.label33.ReadOnly = true;
            this.label33.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.label33.Size = new System.Drawing.Size(1182, 426);
            this.label33.TabIndex = 13;
            // 
            // InfoMobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 855);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label33);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoMobs";
            this.Text = "InfoMobs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox label33;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}