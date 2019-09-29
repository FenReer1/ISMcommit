using System;

namespace ISMLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            Console.WriteLine("Введите b\n");
            b = Convert.ToInt32(Console.ReadLine());
            for (int a = 1; a <= b; a++)
            {
                Console.WriteLine(a * b + "\n");
            }
        }
    }
}