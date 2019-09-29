using System;

namespace ForConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите n\n");
            n = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for(int i=1; i<=n; i++)
            {
                result = result + Math.Pow(i, n - i++);
            }
            Console.WriteLine("\n"+result);
        }
    }
}
