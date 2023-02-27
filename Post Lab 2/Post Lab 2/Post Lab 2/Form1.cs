using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Post_Lab_2
{
    public partial class Form1 : Form
    {
        string MyText;
        public Form1()
        {
            /* 
             * I WORK IN VISUAL STUDIO 2019 AND IT DOSEN'T EXIST THREE OVAL SHAPE IN TOOL BOX
             * SO I REPLACED IT WITH 3 IMAGES
             * */
            InitializeComponent();
            pictureBox1.Visible = false;
            RedLight.Visible = true;
            OrangLight.Visible = false;
            GreenLight.Visible = false;
        }
        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text File|*.txt|XML File|*.xml";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Visible = true;
            }
            //string[] Part = MyText.Split(new char[] { '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);

            timer1.Enabled = true;
            timer2.Enabled = true;

        }
    
            private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Properties.Resources._1;
         }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(RedLight.Visible == true)
            {
                RedLight.Visible = false;
                OrangLight.Visible = false;
                GreenLight.Visible = true;
            }
           else if(GreenLight.Visible==true)
            {
                RedLight.Visible = false;
                OrangLight.Visible = true;
                GreenLight.Visible = false;
            }
            else if(OrangLight.Visible == true)
            {
                RedLight.Visible = true;
                OrangLight.Visible = false;
                GreenLight.Visible = false;
            }
        }

        private void stopGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
           
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(OrangLight.Visible==true)
            {
                pictureBox1.Left = pictureBox1.Left += 5;
            }
            if(GreenLight.Visible==true)
            {
                pictureBox1.Left = pictureBox1.Left += 10;
            }
        }
    }
}
