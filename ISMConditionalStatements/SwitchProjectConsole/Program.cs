using System;

namespace SwitchProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
            int make = 4;
            Console.WriteLine("Введите номер операции:\n 1.День недели\n 2.Месяць\n 3.Калькулятор\n 4.Выход");
            make = Convert.ToInt32(Console.ReadLine());
                switch (make)
                {
                    case 1:
                        int day;
                        Console.WriteLine("Введите номер дня недели\n");
                        day = Convert.ToInt32(Console.ReadLine());
                        switch (day)
                        {
                            case 1:
                                Console.WriteLine("Понедельник");
                                break;
                            case 2:
                                Console.WriteLine("Вторник");
                                break;
                            case 3:
                                Console.WriteLine("Среда");
                                break;
                            case 4:
                                Console.WriteLine("Четверг");
                                break;
                            case 5:
                                Console.WriteLine("Пятница");
                                break;
                            case 6:
                                Console.WriteLine("Суббота");
                                break;
                            case 7:
                                Console.WriteLine("Воскресенье");
                                break;
                            default:
                                Console.WriteLine("Ошибка");
                                break;
                        }
                        break;

                    case 2:

                        int month;
                        Console.WriteLine("Введите номер месяца\n");
                        month = Convert.ToInt32(Console.ReadLine());
                        switch (month)
                        {
                            case 1:
                                Console.WriteLine("Январь");
                                break;
                            case 2:
                                Console.WriteLine("Февраль");
                                break;
                            case 3:
                                Console.WriteLine("Март");
                                break;
                            case 4:
                                Console.WriteLine("Апрель");
                                break;
                            case 5:
                                Console.WriteLine("Май");
                                break;
                            case 6:
                                Console.WriteLine("Июнь");
                                break;
                            case 7:
                                Console.WriteLine("Июль");
                                break;
                            case 8:
                                Console.WriteLine("Август");
                                break;
                            case 9:
                                Console.WriteLine("Сентябрь");
                                break;
                            case 10:
                                Console.WriteLine("Октябрь");
                                break;
                            case 11:
                                Console.WriteLine("Ноябрь");
                                break;
                            case 12:
                                Console.WriteLine("Декабрь");
                                break;
                            default:
                                Console.WriteLine("Ошибка");
                                break;

                        }
                        break;

                    case 3:

                        double a, b;
                        Console.WriteLine("Введите два значения, которые хотите посчитать\n");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        int dia;
                        Console.WriteLine("Выбирете действие:\n 1. Сложение\n 2. Умножение\n 3. Вычетание\n 4. Деление\n");
                        dia = Convert.ToInt32(Console.ReadLine());
                        switch (dia)
                        {
                            case 1:
                                Console.WriteLine(a + b);
                                break;
                            case 2:
                                Console.WriteLine(a * b);
                                break;
                            case 3:
                                Console.WriteLine(a - b);
                                break;
                            case 4:
                                Console.WriteLine(a / b);
                                break;
                            default:
                                Console.WriteLine("Ошибка");
                                break;
                        }
                        break;

                    case 4:
                        
                            Environment.Exit(0);
                        break;

                }

            } while (true);
        }
    }
}