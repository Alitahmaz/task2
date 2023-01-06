namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a:");
            int a = int.Parse(Console.ReadLine());
            if (a >= 100 && a <= 999)
            {
                int result = a * 1000 + a; 
                Console.WriteLine(result);
            }
        }
    }
   
}