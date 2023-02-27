using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Student:IComparable<Student>
    {
        public static int flag;
        public int CompareTo(Student B)
        { 
            if(flag==0)
            return B.fname.CompareTo(this.fname);
            else
                return this.fname.CompareTo(B.fname);

        }

        string id;
        string SSN;

        public string SSN1
        {
            get { return SSN; }
            set { SSN = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        string fname;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        string lname;

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        double mid;

        public double Mid
        {
            get { return mid; }
            set
            {
                if (value >= 0 && value <= 30)
                    mid = value;
                else throw new Exception("Value Must Be [0,30]");
            }
        }
        double final;

        public double Final
        {
            get { return final; }
            set
            {
                if (value >= 0 && value <= 50) final = value;
                else throw new Exception("Value must be [0,50]");
            }
        }
        double quizes;

        public double Quizes
        {
            get { return quizes; }
            set
            {
                if (value >= 0 && value <= 20) quizes = value;
                else throw new Exception("value must be [0,20]");
            }
        }
        public double Total {
            get { return mid + final + quizes; }
        }
        public override string ToString()
        {
            return fname+" "+Total;
        }
    }
}
