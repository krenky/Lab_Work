using System;

namespace figur
{
    class Circle : Figure
    {
        int r;

        public Circle()
        {
            
        }

        public Circle(int r)
        {
            this.r = r;
        }

        public int R { get => r; set => r = value; }

        public override void Show()
        {
            throw new NotImplementedException();
        }
    }
}
