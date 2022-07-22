namespace ConsoleApp1
{
    using System;

    using ClassLibrary1 ;
    internal class math
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Введите среднее арифметеческое  число:");
            
            double sum;
            double result;
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            sum = a + b + c;
            result = sum / 3;
            Console.WriteLine($"Среднее арефметическое число:{result}");
        }

        }
}