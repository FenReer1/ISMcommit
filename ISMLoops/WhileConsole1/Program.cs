using System;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k=1;
            Console.WriteLine("Введите n\n");
            n = Convert.ToInt32(Console.ReadLine());
            while (Math.Pow(3, k) <= n)
            {
                k++;
            }
            Console.WriteLine(k);
        }
    }
}
