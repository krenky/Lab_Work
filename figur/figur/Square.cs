using System;

namespace figur
{
    class Square : Figure
    {
        private int a;

        public Square()
        {
        }

        public int A { get => a; set => a = value; }

        public override void Show()
        {
            throw new NotImplementedException();
        }
    }
}
