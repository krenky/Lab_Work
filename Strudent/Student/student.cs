using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class student
    {
        private String Name;
        private List<int> Marks;
        private int Sred = 0;
        public string Name1 { get => Name; set => Name = value; }
        public List<int> Marks1 { get => Marks; set => Marks = value; }
        public int Sred1 { get => Sred; set => Sred = value; }

        public String sred()
        {
            int sred = 0;
            if (Marks1.Count > 0)
            {
                foreach (int i in Marks1)
                {
                    sred = i + sred;
                }
                sred = sred / Marks1.Count();
                Sred1 = sred;
            }
            return Convert.ToString(sred);
        }
        public string Out_marks()
        {
            string marks = "";
            if (Marks1.Count != null)
            {
                foreach (int i in Marks1)
                {
                    marks = marks + Convert.ToString(i) + ",";
                }
            }
            return marks;
        }
    }
}
