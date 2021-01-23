namespace ConsturctorInheritanceLabs
{
    public class Car : Vehicule
    {

        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            System.Console.WriteLine("Car was instanciated");
        }

        public void Beep()
        {
            base.Log("Beep launched");
            System.Console.WriteLine("Beeeeeeeeeeep");
        }
    }
}
