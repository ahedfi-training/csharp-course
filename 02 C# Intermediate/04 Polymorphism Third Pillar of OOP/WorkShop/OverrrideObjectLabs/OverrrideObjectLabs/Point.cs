namespace OverrrideObjectLabs
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            var anotherPoint = obj as Point;
            
            if (anotherPoint == null)
                return false;

            //if (anotherPoint.X == this.X && anotherPoint.Y == this.Y)
            //    return true;
            //else
            //    return false;

            return anotherPoint.X == this.X && anotherPoint.Y == this.Y;
        }
    }
}
