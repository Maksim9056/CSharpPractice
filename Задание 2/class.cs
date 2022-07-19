namespace Math
{
    public class Person
    {
        public static void TryParse(double a, double b, double c)
        {
            
            double sum;
            double result;

            sum = a + b + c;
            result = sum / 3;
            Console.WriteLine($"{result}");
            
        }
    }
}