namespace Пробник
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new Class1();

            char responseE;

            Console.WriteLine("Сыграли бы вы в игру «камень-ножницы» (y или n)?");
            responseE = Convert.ToChar(Console.ReadLine());

            while (player.validateRespomse(responseE) == false)
            {
                Console.WriteLine("Неправильный ввод . Пожалуйста, повторите свой выбор ");
                responseE = Convert.ToChar(Console.ReadLine());
                if (responseE == 'Y' || responseE == 'y')

                {
                    Console.Clear();
                    player.PlayGame();

                }
                {
                    Console.WriteLine("До свидания");
                    Console.ReadLine();
                }
            }
        }
    }
}