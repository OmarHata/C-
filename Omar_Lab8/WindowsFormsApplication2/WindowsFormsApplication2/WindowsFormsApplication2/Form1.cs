using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x1, y1;
        int x2, y2;
        bool flag;
        int Index;
        Shape MyShspe;
        //Pen P = new Pen(Color.Blue, 3);
        List<Shape> Mylist = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            for (int i = 0; i < Mylist.Count; i++)
            {
                if (Mylist[i].IsInside(x1, y1))
                {
                    Mylist[i].select(g);
                    flag = true;
                    Index = i;
                    break;
                }
            }

           // g.DrawRectangle(P, x1, y1, 100, 100);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            int dx=x2-x1;
            int dy=y2-y1;
            if (flag)
            {
               // Mylist[Index].MOVE(dx, dy);
                Mylist[Index].FILL(g);
                
                flag = false;

            }
            else
            {
                if (e.Button == MouseButtons.Left)
                    MyShspe = new Shape(x1, y1, x2, y2, TYPE.rect,TYPE2.DRAW);
                else if (e.Button == MouseButtons.Right)
                    MyShspe = new Shape(x1, y1, x2, y2, TYPE.ellipse,TYPE2.DRAW);
                MyShspe.DRAW(g, Color.Red);
                Mylist.Add(MyShspe);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
        }

       
        

        
    }
}
