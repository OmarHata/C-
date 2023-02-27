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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.MyList;
        }

        private void sortByTotalAscendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var R = from Item in Program.MyList orderby Item.Total ascending select Item;
                  
            dataGridView1.DataSource=R.ToArray();
        }

        private void sortByFirstNameAscendingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void passToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = from Item in Program.MyList where Item.Total >= 50select Item;
            dataGridView1.DataSource = f.ToArray();
        }

        private void maToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = from Item in Program.MyList where Item.Total >= 50 select Item;
            double x=(double) (f.Count())/(double)Program.MyList.Length*100;
            MessageBox.Show(x.ToString());
        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = from Item in Program.MyList orderby Item.Total ascending select Item;
            MessageBox.Show(f.Last().ToString());
            SaveFileDialog dlg = new SaveFileDialog();
             dlg.Filter="TexFile|*.txt";
             if (dlg.ShowDialog() == DialogResult.OK)
             {
                 StreamWriter Writer = new StreamWriter(dlg.FileName);
                 Writer.WriteLine(f.Last().ToString());
                 Writer.Close();
             }
        }

       

        
    }
}
