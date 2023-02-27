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
using System.Xml.Serialization;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.MyList;
        }

        private void sortByTotalAscendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var R = from Item in Program.MyList
                    orderby Item.Total ascending
                    select Item;
            dataGridView1.DataSource = R.ToArray();
        }

        private void sortByFnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = from Item in Program.MyList
                    orderby Item.Fname descending
                    select Item;
            dataGridView1.DataSource = f.ToArray();
        }

        private void passToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = from Item in Program.MyList
                    where Item.Total >= 50
                    select Item;
            dataGridView1.DataSource = f.ToArray();
        }

        private void passedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = from Item in Program.MyList
                    where Item.Total >= 50
                    select Item;
            double x;
            x = (double)(f.Count() / (double)Program.MyList.Count) * 100;
            MessageBox.Show(x.ToString());

        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = from Item in Program.MyList
                    orderby Item.Total ascending
                    select Item;
            MessageBox.Show(f.Last().ToString());
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "TextFile|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(dlg.FileName);
                Writer.WriteLine(f.Last().ToString());
                Writer.Close();
            }


        }

        private void getRANGFEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.MyList.GetRange(0, 3);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.MyList.RemoveRange(0, 3);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.MyList;
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.MyList.Reverse(0, 3);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.MyList;
        }

        private void ascToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.flag = 1;
            Program.MyList.Sort();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.MyList;
        }

        private void descToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.flag = 0;
            Program.MyList.Sort();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.MyList;
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            F.ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.MyList;

        }

        private void saveAsXmlFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "XMLFILE|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                XmlSerializer SER = new XmlSerializer(typeof(List<Student>));
                SER.Serialize(writer, Program.MyList);
                writer.Close();
            }


        }



        private void readFromXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "XMLFILE|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader =new  StreamReader(dlg.FileName);
                XmlSerializer SER = new XmlSerializer(typeof(List<Student>));
                List<Student>StdList =(List<Student>)SER.Deserialize(reader);
                reader.Close();
                dataGridView1.DataSource=StdList;
            }

        }

}
    }


