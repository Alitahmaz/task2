namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a:");
            double a = double.Parse(Console.ReadLine());
            if (a>=10000 && a<=99999)
            {
                double result = a * 18 / 100;
                double result2 = result * 3 / 10;
                Console.WriteLine(result2);
            }
        }
    }
}