using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abonent
{
    class ClMid
    {
        ClAbonent[] ClAbonents = new ClAbonent[10];
        ClAbonent Abonent = new ClAbonent("Test");
        int Count = 0;
        public void Add(string Name)
        {
            if (Count < ClAbonents.Length)
            {
                Abonent.Name = Name;
                ClAbonents[Count++] = Abonent;
            }
            else
            {
                Array.Resize(ref ClAbonents, ClAbonents.Length + 1);
                Add(Name);
            }
        }
    }
}
