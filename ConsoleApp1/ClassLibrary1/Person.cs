namespace ClassLibrary1
{
    public class Person
    {
        static public void Main (double a,double b ,double c)
        {
            Console.WriteLine("Введите среднее арифметеческое  число:");

           
            double sum;
            double result;
            sum = a + b + c;
            result = sum / 3;
            Console.WriteLine($"Среднее арефметическое число {result}");

        }
    }
}