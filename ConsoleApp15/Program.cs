namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ci eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("2 ci eded daxil edin:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine((a < 0 && b > 0) || (a > 0 && b < 0));
        }
    }
}