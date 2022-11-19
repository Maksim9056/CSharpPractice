namespace personXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();


            char responseE;

            Console.WriteLine("Ввидите данные сотрудника (y или no)?");
            responseE = Convert.ToChar(Console.ReadLine());

            if (responseE == 'Y' || responseE == 'y')
            {
                person.Start();
               
            }
        }
    }
}