using System;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            double fday = 10, k=1;
            double p, s=fday;
            Console.WriteLine("Введите p\n");
            p = Convert.ToDouble(Console.ReadLine());
            if (0 <= p && p <= 50)
            {
                while (fday <= 200)
                {
                    fday += fday * p;
                    k++;
                    s = fday;
                }
                Console.WriteLine("k="+k +"\ns="+ s);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
