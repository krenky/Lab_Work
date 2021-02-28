using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abonent
{
    class ClAbonent
    {
        private String name;
        private List<int> Zvon_min = new List<int>();
        public List<int> Zvon
        {
            get
            {
                return Zvon_min;
            }
            set
            {
                Zvon_min = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public ClAbonent(string Name)
        {
            name = Name;
        }
        public void add_min(int Days, int Min)
        {
            Zvon_min[Days] = Zvon_min[Days] + Min;
        }
        public int MinDays(int Days)
        {
            return Zvon[Days];
        }
        public int SumMin()
        {
            int sum = 0;
            foreach (int i in Zvon)
            {
                sum = sum + i;
            }
            return sum;
        }
        public string PrintAll()
        {
            string all = "";
            string Sum =
            all = all + name + " " + "summa:" + Convert.ToString(SumMin()) + " = " + Prod();
            return all;
        }
        public string Prod()
        {
            string Haha = "";
            foreach (int i in Zvon)
            {
                if (i > 0)
                {
                    Haha = Haha + "+" + Convert.ToString(i);
                }
            }
            return Haha;
        }
    }
}
