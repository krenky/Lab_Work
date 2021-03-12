namespace figur
{
    class Elipse : Circle
    {
        int r2;

        //public Elipse(int r, int r2)
        //{
        //    r = r;
        //    r2 = r2;
        //}

        public int R2 { get => r2; set => r2 = value; }
        public override void Show()
        {
            base.Show();
        }
    }
}
