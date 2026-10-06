//********************************************
//*Практическая работа №9                    *
//* Выполнила: Вохмянина А.Р., группа 2-ИСП  *
//* Задание: обработка одномерных массивов   *
//********************************************
using System;

namespace работа_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Практическая работа 9 .";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Здравствуй!");
            try
            {
                double[] arrayY = new double[10];
                double x1 = 0;
                double h = 0;
                double a = 0;
                double b = 0;
                Console.Write("Введите x1: "); // шаг расчёта
                while (!double.TryParse(Console.ReadLine(), out x1))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Ошибка: введены неверные данные!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Введите x1: ");
                }
                Console.Write("Введите h: "); // шаг расчёта
                while (!double.TryParse(Console.ReadLine(), out h))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Ошибка: введены неверные данные!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Введите h: ");
                }
                Console.Write("Введите a: "); // ввод диапозона левого края
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Ошибка: введены неверные данные!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Введите a: ");
                }
                Console.Write("Введите b: "); // ввод диапозона правого края
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Ошибка: введены неверные данные!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Введите b: ");
                }
                // проверка правильности границ
                while (a >= b)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nОшибка: а должно быть меньше b!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nВведите a: ");

                    while (!double.TryParse(Console.ReadLine(), out a))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Ошибка: введены неверные данные!");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Введите a: ");
                    }
                    Console.Write("Введите b: "); // ввод диапозона правого края
                    while (!double.TryParse(Console.ReadLine(), out b))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Ошибка: введены неверные данные!");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Введите b: ");
                    }
                }
                double x = x1;
                int count = 0; // счетчик хранящий диапозон
                int i = 0;
                // Вычисление массива
                while (i < arrayY.Length)
                {
                    arrayY[i] = 2 * Math.Sin(x) + 1.2;
                    if (arrayY[i] >= a && arrayY[i] < b)
                    {
                        count++;
                    }
                    x += h;
                    i++;
                }
                // Вывод массива
                Console.Write("\nМассив : \n");
                i = 0;
                while (i < arrayY.Length)
                {
                    Console.Write("Y [");
                    Console.Write(i);
                    Console.Write("]");
                    Console.Write($"{arrayY[i]}; ");
                    i++;
                }
                Console.Write("\nКоличество элементов в диапозоне [");
                Console.Write(a);
                Console.Write(";");
                Console.Write(b);
                Console.Write("):");
                Console.Write(count);

            }
            catch (FormatException)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ошибка: введены неверные данные!");
                Console.Write("Ошибка: необходимо вводить числа!");
                Console.Write("Повторите ввод данных.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ошибка:выход за границы массива!");
                Console.Write("Повторите ввод данных.");
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Что-то пошло не так. Ошибка: " + e.Message);
            }
        }
    }
}

