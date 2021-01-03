using ApplicationDemo.BusinessLayer;
using AnotherApplication.BusinessLayer;

namespace ApplicationDemo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //TempClass tempClass = new TempClass();

            //PomotionService pomotionService
            //AnotherService
            PomotionService pomotionService = new PomotionService();
            var reducedAmmount = pomotionService.Reduce(100);
            System.Console.WriteLine("reducedAmmount: " + reducedAmmount);
            System.Console.ReadLine();
        }
    }
}
