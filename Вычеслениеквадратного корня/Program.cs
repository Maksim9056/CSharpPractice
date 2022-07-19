namespace Вычеслениеквадратного_корня
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите квардрат корень числа");

            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                number = Convert.ToDouble(input);


                if (number >= 0)
                {
                    double result  = Math.Sqrt(number);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Ошибка невозможно вычислить корень");
                }

            }
            else
            { Console.WriteLine("Ошибка введено не число"); }
        }
    }
}