namespace ConsoleApp1
{
    using System;
    using ClassLibrary1;
    internal class Person
    {static public void Main()
        {
            Console.WriteLine("Введите три числа для вычесления среднего арифметеческого  числа:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычеление:");
            Console.WriteLine(MathCalculator.GetMean(a, b, c));                                           
        }
        }
        }