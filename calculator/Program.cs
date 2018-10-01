using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать! Вы зашли в консольный калькулятор! Перед началом использования введите дествие которое вы хотите совершить:");
            Console.WriteLine("(1) Сложение(a + b)");
            Console.WriteLine("(2) Вычитание(a - b)");
            Console.WriteLine("(3) Умножение(a * b)");
            Console.WriteLine("(4) Деление(a/b)");
            Console.WriteLine("(5) Возвести число в квадрат(a^2)");
            Console.WriteLine("(6) Возведение числа в степень(a^b)");
            Console.WriteLine("(7) Вычисление факториала(a!)");
            Console.WriteLine("(8) Вычисление синуса(sin(a))");
            Console.WriteLine("(9) Вычисление косинуса(cos(a))");
            Console.WriteLine("(10) Вычисление квадратного корня(Sqrt(a))");
            Console.WriteLine("(11) Вычесление процента.");
            Console.WriteLine("(0) Выход");
            do
            {
                int str = Convert.ToInt32(Console.ReadLine());
                if (str == 0)
                {
                    Console.WriteLine("Идет завершение программы...");
                    Console.WriteLine("Нажмите любую клавишу для закрытия приложения...");
                    Console.ReadKey();
                    break;

                }
                else if (str == 1)
                {
                    Console.WriteLine("Вы выбрали сложение.");
                    Console.Write("\nВведите первое число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int sum = a + b;
                    Console.WriteLine("Ответ: " + sum);
                }

                else if (str == 2)
                {
                    Console.WriteLine("Вы выбрали вычитание.");
                    Console.Write("\nВведите первое число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int raz = a - b;
                    Console.WriteLine("Ответ: " + raz);
                }

                else if (str == 3)
                {
                    Console.WriteLine("Вы выбрали умножение.");
                    Console.Write("\nВведите первое число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int pr = a * b;
                    Console.WriteLine("Ответ: " + pr);
                }

                else if (str == 4)
                {
                    Console.WriteLine("Вы выбрали деление.");
                    Console.Write("\nВведите первое число: ");
                    string symbol1 = Console.ReadLine();
                    float a = Convert.ToSingle(symbol1);
                    Console.Write("Введите второе число: ");
                    string symbol2 = Console.ReadLine();
                    float b = Convert.ToSingle(symbol2);
                    float del = a / b;
                    Console.WriteLine("Ответ: {0:0.##} ", del);
                }
                else if (str == 5)
                {
                    Console.WriteLine("Вы выбрали возведение в квадрат.");
                    Console.WriteLine("\n Введите число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int kv = a * a;
                    Console.WriteLine("Ответ: " + kv);
                }
                else if (str == 6)
                {
                    Console.WriteLine("Вы выбрали возведение в степень.");
                    Console.WriteLine("\nВведите какое число возводить в степень: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("В какую степень возводить?");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ответ: " + Math.Pow(a, b));
                }
                else if (str == 7)
                {
                    Console.WriteLine("Вы выбрали вычисление факториала.");
                    Console.WriteLine("\nВведите число: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int fact = 1;
                    for (int i = 2; i <= a; i++)
                    {
                        fact = fact * i;
                    }
                    Console.WriteLine("Ответ: " + fact);

                }
                else if (str == 8)
                {
                    Console.WriteLine("Вы выбрали вычисление синуса.");
                    Console.WriteLine("\nВведите число: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double sin = Math.Sin(Math.PI * a / 180);
                    Console.WriteLine("Ответ: {0:0.###} ", sin);
                }
                else if (str == 9)
                {
                    Console.WriteLine("Вы выбрали вычисление косинуса.");
                    Console.WriteLine("\nВведите число: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double cos = Math.Cos(Math.PI * a / 180);
                    Console.WriteLine("Ответ: {0:0.###} ", cos);
                }

                else if (str == 10)
                {
                    Console.WriteLine("Вы выбрали вычисление Квадратного корня.");
                    Console.WriteLine("\nВведите число: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Double sqrt = Math.Sqrt(a);
                    Console.WriteLine("Ответ: {0:0.###}", sqrt);
                }
                else if (str == 11)
                {
                    Console.WriteLine("Вы выбрали расчет процента.");
                    Console.WriteLine("\nВведите число: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Double b = a/100;
                    Console.WriteLine("Ответ: {0:0.###}", b);

                }
            }
            while (true);
        }
    }
}
