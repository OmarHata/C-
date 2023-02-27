
namespace Post_Lab_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RedLight = new System.Windows.Forms.PictureBox();
            this.OrangLight = new System.Windows.Forms.PictureBox();
            this.GreenLight = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(682, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.stopGameToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startGameToolStripMenuItem.Text = "Start Game";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // stopGameToolStripMenuItem
            // 
            this.stopGameToolStripMenuItem.Name = "stopGameToolStripMenuItem";
            this.stopGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopGameToolStripMenuItem.Text = "Stop Game";
            this.stopGameToolStripMenuItem.Click += new System.EventHandler(this.stopGameToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Post_Lab_2.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(23, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RedLight
            // 
            this.RedLight.Image = global::Post_Lab_2.Properties.Resources.red_png;
            this.RedLight.Location = new System.Drawing.Point(516, 134);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(61, 166);
            this.RedLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RedLight.TabIndex = 4;
            this.RedLight.TabStop = false;
            // 
            // OrangLight
            // 
            this.OrangLight.Image = global::Post_Lab_2.Properties.Resources.Orange_png;
            this.OrangLight.Location = new System.Drawing.Point(516, 135);
            this.OrangLight.Name = "OrangLight";
            this.OrangLight.Size = new System.Drawing.Size(61, 165);
            this.OrangLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.OrangLight.TabIndex = 5;
            this.OrangLight.TabStop = false;
            // 
            // GreenLight
            // 
            this.GreenLight.Image = global::Post_Lab_2.Properties.Resources.Green_png;
            this.GreenLight.Location = new System.Drawing.Point(513, 135);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(64, 166);
            this.GreenLight.TabIndex = 6;
            this.GreenLight.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 476);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.OrangLight);
            this.Controls.Add(this.RedLight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox RedLight;
        private System.Windows.Forms.PictureBox OrangLight;
        private System.Windows.Forms.PictureBox GreenLight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

