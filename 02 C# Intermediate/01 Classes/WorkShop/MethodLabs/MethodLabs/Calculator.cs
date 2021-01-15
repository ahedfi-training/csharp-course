namespace MethodLabs
{
    public class Calculator
    {
        public int Add(string msg, params int[] numbers)
        {
            System.Console.WriteLine(msg);
            var value = 0;
            foreach (var number in numbers)
            {
                value += number;
            }
            return value;
        }
    }
}
