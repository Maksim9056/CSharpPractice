namespace ConsoleApp1
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Введите среднее арифметеческое  число:");
            double x;
            double y;
            double z;
            double sum;
            double result;
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            sum = a + b + c;
            result = sum / 3;
            Console.WriteLine($"{result}");
        }

        }
}