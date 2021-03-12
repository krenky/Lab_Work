using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figur
{
    class Circle : Figure
    {
        int r;

        public int R { get => r; set => r = value; }

        public override void Show()
        {
            throw new NotImplementedException();
        }
    }
}
