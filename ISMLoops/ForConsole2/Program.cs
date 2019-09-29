using System;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double result=0;
            Console.WriteLine("Введите n\n");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                result = result + 1.0 / i;
            }
            Console.WriteLine(result+"\n");
        }
    }
}
