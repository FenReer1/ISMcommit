using System;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число");
                double r =0 ;
                int n;
                do
                {
                    n = int.Parse(Console.ReadLine());
                    r = r + n;
                }
                while (n != 0);
                Console.WriteLine(r);
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }

        }
    }
}
