using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Student
    {
        string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        string Fname;

        public string Fname1
        {
            get { return Fname; }
            set { Fname = value; }
        }
        string Lname;

        public string Lname1
        {
            get { return Lname; }
            set { Lname = value; }
        }
        double mid;

        public double Mid
        {
            get { return mid; }
            set
            {
                if (value >= 0 && value <= 30)
                    mid = value;
                else throw new Exception("Mid Value Must Be[0,30]");
            }
        }
        double final;

        public double Final
        {
            get { return final; }
            set
            {
                if (value >= 0 && value <= 50)
                    final = value;
                else throw new Exception("Final Value Must Be[0,50]");
            }
        }
        double quizes;

        public double Total{
            get { return Mid + Final + Quizes; }

            
        }
        public double Quizes
        {
            get { return quizes; }
            set
            {
                if (value >= 0 && value <= 20)
                    quizes = value;
                else throw new Exception("Quizes Value Must Be[0,20]");

            }
        }
    }
}
