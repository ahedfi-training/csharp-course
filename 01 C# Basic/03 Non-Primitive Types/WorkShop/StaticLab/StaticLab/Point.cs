namespace StaticLab
{
    public struct Point
    {
        public int X;
        public int Y;
        public static int Z;

        public Point(int x, int y)
        {
            // all fields should be initialized
            X = x;
            Y = y;
            //Z = 0;
        }
        public Point(int x)
        {
            // all fields should be initialized
            X = x;
            Y = 0;
            // Z = 0;
        }
        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
