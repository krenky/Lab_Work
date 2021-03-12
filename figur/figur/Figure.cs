namespace figur
{
    abstract class Figure
    {
        int x;
        int y;

        protected Figure(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        protected Figure()
        {

        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public void SetXY(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public abstract void Show();
        public void MoveTo(int DeltaX, int DeltaY)
        {
            this.X = +DeltaX;
            this.Y = +DeltaY;
        }
    }
}
