using System;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double result = 0;
            double factor = 1;
            Console.WriteLine("Введите n\n");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                factor = factor * i;
                result = result + factor;
            }
            Console.WriteLine("\n"+ result);
        }
    }
}
