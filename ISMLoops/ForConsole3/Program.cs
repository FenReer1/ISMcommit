using System;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double result=1;
            int n;
            Console.WriteLine("Введите a\n");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите n\n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i=1; i<=n; i++)
            {
                result *= a;
            }
            Console.WriteLine(result);
        }
    }
}
