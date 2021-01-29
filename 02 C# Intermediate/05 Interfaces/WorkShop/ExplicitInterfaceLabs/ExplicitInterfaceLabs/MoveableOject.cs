namespace ExplicitInterfaceLabs
{
    class MoveableOject : ILeft, IRight
    {
        void ILeft.Move() {
            System.Console.WriteLine("left");
        }
        void IRight.Move() {
            System.Console.WriteLine("right");
        }

        public void Freeze()
        {

        }
    }
}
