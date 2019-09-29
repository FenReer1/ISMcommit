using System;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, result;
            result = 0;
            Console.WriteLine("Введите a, меньшее\n");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b, большее\n");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i=a; i <= b; i++)
            {
                result+=i*i;
            }
            Console.WriteLine("\n"+result);
        }
    }
}
