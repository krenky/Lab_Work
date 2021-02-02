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

        public void _Sred()
        {
            foreach (int i in Marks1)
            {
                Sred = i + Sred;
            }
            Sred = Sred / Marks1.Count();
        }
        /*public void add(String name)
        {
            Name1 = Name1;
        }*/
    }
}
