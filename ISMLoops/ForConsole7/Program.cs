using System;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Введите n\n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k\n");
            k = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result = result + Math.Pow(i, k);
            }
            Console.WriteLine("\n" + result);
        }
    }
}
