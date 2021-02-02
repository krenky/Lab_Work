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
        public string Name1 { get => Name; set => Name = value; }
        public List<int> Marks1 { get => Marks; set => Marks = value; }
        
        public int _Sred()
        {
            int Sum = 0;
            foreach (int i in Marks1)
            {
                Sum = i + Sum;
            }
            Sum = Sum / Marks1.Count();
            return Sum;
        }
        /*public void add(String name)
        {
            Name1 = Name1;
        }*/
    }
}
